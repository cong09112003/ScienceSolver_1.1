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
    public partial class BasicCalculate : Form
    {
        public BasicCalculate()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            textBox1.Text = str.Replace(" ", " ");
            Console.WriteLine(Mathematics_Calculate.Infix_to_Postfix(textBox1.Text));
            try
            {
                textBox3.Text = Mathematics_Calculate.Infix_to_Postfix(Mathematics_Calculate.Infix_to_Postfix(textBox1.Text));
                textBox2.Text=Mathematics_Calculate.EvaluatePostfix(Mathematics_Calculate.Infix_to_Postfix(textBox1.Text)).ToString();
            }
            catch (Exception ex) 
            {
                Console.WriteLine(textBox2.Text = "ERROR");
                Console.WriteLine(textBox3.Text = "ERROR");
                Console.WriteLine(ex.ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            textBox1.Text=str.Replace(" ", " ");
            Console.WriteLine(Mathematics_Calculate.Infix_to_Postfix(textBox1.Text));
            try
            {
                textBox3.Text = Mathematics_Calculate.Infix_to_Postfix(Mathematics_Calculate.Infix_to_Postfix(textBox1.Text));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString()); 
                Console.WriteLine(textBox2.Text = "ERROR");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox1.Text = "(7!+5*3-4/3+8^2-3)";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
