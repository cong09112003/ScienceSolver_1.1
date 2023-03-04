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
    public partial class Equation_FourthDegree : Form
    {
        public Equation_FourthDegree()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {


        }
        Mathematics_Function equa = new Mathematics_Function_Degree4();
        private void button1_Click(object sender, EventArgs e)
        {
            equa.A = double.Parse(textBox1.Text);
            equa.B = double.Parse(textBox2.Text);
            equa.C = double.Parse(textBox3.Text);  
            equa.D = double.Parse(textBox4.Text);
            equa.E = double.Parse(textBox5.Text);
            equa.Mathematics_Function_Solving();
            string str = textBox1.Text + ".x^4 + " + textBox2.Text + ".x^3 + " + textBox3.Text + ".x^2 + " + textBox4.Text + ".x + " + textBox5.Text + " = 0";
            listBox1.Items.Clear();
            listBox1.Items.Add(str);
            listBox1.Items.Add("Result:");
            string[] arr = equa.Varible.Split(",");
            for(int i=0;i<arr.Length;i++) 
            {
                listBox1.Items.Add(arr[i]);
            }
        }
    }
}
