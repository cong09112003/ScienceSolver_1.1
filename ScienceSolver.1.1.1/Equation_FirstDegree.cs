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
    public partial class Equation_FirstDegree : Form
    {
        public Equation_FirstDegree()
        {
            InitializeComponent();
        }
        Mathematics_Function equa = new Mathematics_Function_Degree1();
        private void button1_Click(object sender, EventArgs e)
        {
            equa.A=double.Parse(textBox1.Text);
            equa.B=double.Parse(textBox2.Text);
            equa.Mathematics_Function_Solving();
            listBox1.Items.Clear();
            string str = textBox1.Text + "x" + " + "+ textBox2.Text +" = 0";
            listBox1.Items.Add(str);
            listBox1.Items.Add("Result:");
            listBox1.Items.Add(equa.Varible);
        }
    }
}
