using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScienceSolver._1._1._1
{
    public partial class SearchingMathFormula : Form
    {
        static List<Mathematics_Formula> _formulalist=new List<Mathematics_Formula>();
        public SearchingMathFormula()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Mathematics_FormulaList.DocFile(Application.StartupPath + "\\CongThucToanHoc.txt");
            Mathematics_Formula res=Mathematics_FormulaList.Find_Mathematics_Formula(textBox1.Text);
            if(res != null) 
            {
                textBox2.Text = "Sucesss";
                listBox1.Items.Clear();
                listBox1.Items.Add("Area :"+res.Area);
                listBox1.Items.Add("ID of formula:" + res.ID);
                listBox1.Items.Add("Formula name:" + res.Name_For);
                listBox1.Items.Add("Formula:" + res.Formula);
            }
            else
            {
                textBox2.Text = "ERROR";
                listBox1.Items.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Application.StartupPath + "\\CongThucToanHoc.txt";
                _formulalist=Mathematics_FormulaList.Docfile(path);
                listBox1.Items.Clear();
                textBox2.Text = "success";
                int count = 0;
                foreach(Mathematics_Formula congthuc in _formulalist)
                {
                    listBox1.Items.Add("Formula " + (++count));
                    listBox1.Items.Add("Area: " + congthuc.Area);
                    listBox1.Items.Add("ID" + congthuc.ID);
                    listBox1.Items.Add("Name Formula:" + congthuc.Name_For);
                    listBox1.Items.Add("Formula"+congthuc.Formula);
                    listBox1.Items.Add("");
                }
            }
            catch(Exception ex) 
            {
                textBox2.Text = "ERORR";
                MessageBox.Show(ex.Message);    
            }
        }
        
    }
}
