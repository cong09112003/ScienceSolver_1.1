using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ScienceSolver._1._1._1
{
    public partial class HighLevelCalculate : Form
    {
        const int CONTROL_SIZE = 30;
        bool _isInProcess = false;
        bool _isInfix2Prefix = false;
        Control _preCtl, _nextCtl;

        public HighLevelCalculate()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "(20 / 11) / 2022 + 8";
            textBox2.Text = " ";
            textBox6.Text = " ";
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();
            flowLayoutPanel3.Controls.Clear();
            listView1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str=ExprHelper.FormatExpression(textBox1.Text);
            textBox1.Text=str.Replace(" "," ");
            //button1_Click(sender, e);
            Console.WriteLine(Y2Expression.Infix2Postfix(textBox1.Text));
            if (!_isInProcess)
            {
                str = ExprHelper.FormatExpression(textBox1.Text);
                textBox1.Text = str.Replace(" ", " ");
                try
                {
                    textBox2.Text = Y2Expression.Infix2Postfix(textBox1.Text);
                    textBox6.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox1.Text));

                }
                catch (Exception ex)
                {

                    textBox2.Text = "ERROR";
                    textBox6.Text = ex.Message;
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(!_isInProcess)
                return;
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();
            flowLayoutPanel3.Controls.Clear();


            button4.Text = "Start";
            _isInProcess = false;
            timer1.Stop();

            
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        // startpauseclick
        private void button4_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text.Trim()))
                return;
            if (!timer1.Enabled)
            {
                if (!_isInProcess)
                {
                    string infix = textBox1.Text;
                    infix = ExprHelper.FormatExpression(infix);

                    IEnumerable<string> tokens;

                    tokens = infix.Split(' ');

                    foreach (string s in tokens)
                    {
                        Label lbl = new Label();
                        lbl.TextAlign = ContentAlignment.MiddleCenter;
                        lbl.Text = s;

                        lbl.Width = CONTROL_SIZE;
                        lbl.Height = CONTROL_SIZE;

                        flowLayoutPanel1.Controls.Add(lbl);
                    }
                    listView1.Items.Clear();
                    textBox6.Clear();
                }
                button4.Text = "Pause";
                timer1.Interval = (int)numericUpDown1.Value;
            }
            else
            {
                if(_isInProcess) { button4.Text = "Resume"; }
                else { button4.Text = "Start"; }
            }
            _isInProcess= true;
            timer1.Enabled = !timer1.Enabled;
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //
        private void ProcessPostfix(Control ctl)
        {
            if (ExprHelper.IsOperator(ctl.Text))
            {

                if (_preCtl != null && ExprHelper.IsOperator(_preCtl.Text))
                {
                    if (ctl.Text == "-")
                    {
                        _nextCtl.Text = ctl.Text + _nextCtl.Text;
                        Output(_nextCtl);
                    }
                    else if (ExprHelper.IsUnaryFunction(ctl.Text))
                    {
                        PushStack(ctl);
                    }
                }
                else
                {
                    while (flowLayoutPanel3.Controls.Count > 0 &&
                        ExprHelper.GetPriority(ctl.Text) <= ExprHelper.GetPriority(PeekStack().Text))
                        Output(PopStack());
                    PushStack(ctl);
                }
            }

            else if (ctl.Text == "(")
                PushStack(ctl);
            else if (ctl.Text == ")")
            {
                Control x = PopStack();
                while (x.Text != "(")
                {
                    Output(x);
                    x = PopStack();
                }
            }
            else // IsOperand
            {
                Output(ctl);
            }
        }
        Control PeekStack()
        {
            return flowLayoutPanel3.Controls[flowLayoutPanel3.Controls.Count - 1];
        }
        Control PopStack()
        {
            Control ctl = flowLayoutPanel3.Controls[flowLayoutPanel3.Controls.Count - 1];
            flowLayoutPanel3.Controls.Remove(ctl);

            return ctl;
        }
        void PushStack(Control ctl)
        {
            flowLayoutPanel3.Controls.Add(ctl);

        }
        void Output(Control ctl)
        {
            flowLayoutPanel2.Controls.Add(ctl);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        void AddToListView(Control ctl)
        {
            string s = String.Empty;
            if (ctl != null)
                s = ctl.Text;
            ListViewItem item = listView1.Items.Add(s);
            StringBuilder str = new StringBuilder();

            // stack
            foreach (Control c in flowLayoutPanel3.Controls)
                str.Append(c.Text).Append(" ");

            s = str.ToString().Trim();
            if (s == String.Empty)
                s = "{Empty}";

            item.SubItems.Add(s);

            // output
            str = new StringBuilder();
            foreach (Control c in flowLayoutPanel2.Controls)
                str.Append(c.Text).Append(" ");

            s = str.ToString().Trim();
            if (s == String.Empty)
                s = "{Empty}";
            item.SubItems.Add(s);

            if (listView1.Items.Count > 1)
                listView1.Items[listView1.Items.Count - 2].Selected = false;

            item.Selected = true;

            listView1.TopItem = item;
        }
        private void StepForward()
        {
            try
            {
                if (flowLayoutPanel1.Controls.Count > 0)
                {
                    Control ctl = flowLayoutPanel1.Controls[0];
                    

                    flowLayoutPanel1.Controls.Remove(ctl);

                    if (flowLayoutPanel1.Controls.Count > 0)
                        _nextCtl = flowLayoutPanel1.Controls[0];

                    ProcessPostfix(ctl);

                    AddToListView(ctl);

                    _preCtl = ctl;
                }
                else if (flowLayoutPanel3.Controls.Count > 0)
                {
                    Control ctl = PopStack();
                    Output(ctl);

                    // last 
                    if (flowLayoutPanel1.Controls.Count == 0 && flowLayoutPanel3.Controls.Count == 0)
                        AddToListView(null);
                }
                else if (flowLayoutPanel2.Controls.Count > 0) // final expression
                {
                    int index = 0;
                    if (_isInfix2Prefix)
                        index = flowLayoutPanel2.Controls.Count - 1;


                    Control ctl = flowLayoutPanel2.Controls[index];

                    textBox6.Text += ctl.Text + " ";
                    flowLayoutPanel2.Controls.Remove(ctl);

                    ctl.Dispose();
                }
                else
                {
                   button2_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                timer1.Stop();
                MessageBox.Show(ex.Message);
            }
        }
    }
        
}
