using Final_Project_ScienceSolver;
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
    public partial class Vector_2_axis : Form
    {
        public Vector_2_axis()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text=Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox1.Text));
            textBox2.Text=Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox2.Text));
            textBox3.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox3.Text));
            textBox4.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox4.Text));
            listBox1.Items.Clear();
            Mathematics_Vector_2E res = new Mathematics_Vector_2E(double.Parse(textBox4.Text), double.Parse(textBox3.Text)) 
                - new Mathematics_Vector_2E(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
            listBox1.Items.Add("B - A = " + "{" + res.X + "," + res.Y + "}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox1.Text));
            textBox2.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox2.Text));
            
            listBox1.Items.Clear();
            listBox1.Items.Add(" Vector A: {" + double.Parse(textBox1.Text) + "," + double.Parse(textBox2.Text) + "}");
            // Mathematics_Vector_2E res = new Mathematics_Vector_2E(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
            listBox1.Items.Add(" Distance of vector A: " + Mathematics_Vector_2E.AbsoulteVecto(new Mathematics_Vector_2E(double.Parse(textBox1.Text), double.Parse(textBox2.Text)) ) );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text=Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox1.Text));
            textBox2.Text=Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox2.Text));
            textBox3.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox3.Text));
            textBox4.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox4.Text));
            listBox1.Items.Clear();
            listBox1.Items.Add(" Vector B: {" + double.Parse(textBox4.Text) + "," + double.Parse(textBox3.Text) + "}");
            //Mathematics_Vector_2E res = new Mathematics_Vector_2E(double.Parse(textBox4.Text), double.Parse(textBox3.Text));
            listBox1.Items.Add(" Distance of vector A: " + Mathematics_Vector_2E.AbsoulteVecto(new Mathematics_Vector_2E(double.Parse(textBox4.Text), double.Parse(textBox3.Text))));
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox1.Text));
            textBox2.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox2.Text));
            textBox3.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox3.Text));
            textBox4.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox4.Text));
            listBox1.Items.Clear();
            listBox1.Items.Add("( A.B ) = "
                + Mathematics_Vector_2E.ScalarProductVecto(new Mathematics_Vector_2E(double.Parse(textBox1.Text), double.Parse(textBox2.Text)),
                (new Mathematics_Vector_2E(double.Parse(textBox4.Text), double.Parse(textBox3.Text)))) );
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox1.Text));
            textBox2.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox2.Text));
            textBox3.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox3.Text));
            textBox4.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox4.Text));
            listBox1.Items.Clear();
            Mathematics_Vector_2E res = new Mathematics_Vector_2E(double.Parse(textBox1.Text), double.Parse(textBox2.Text))
                + new Mathematics_Vector_2E(double.Parse(textBox4.Text), double.Parse(textBox3.Text));
            listBox1.Items.Add("<Unity vector> A + B = " + "{"+res.X+","+res.Y+"}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox1.Text));
            textBox2.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox2.Text));
            textBox3.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox3.Text));
            textBox4.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox4.Text));
            listBox1.Items.Clear();
            Mathematics_Vector_2E res = new Mathematics_Vector_2E(double.Parse(textBox1.Text), double.Parse(textBox2.Text))
                - new Mathematics_Vector_2E(double.Parse(textBox4.Text), double.Parse(textBox3.Text));
            listBox1.Items.Add("A - B = " + "{" + res.X + "," + res.Y + "}");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox1.Text));
            textBox2.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox2.Text));
            textBox3.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox3.Text));
            textBox4.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox4.Text));
            listBox1.Items.Clear();
            double res = Mathematics_Vector_2E.FindingAngle(new Mathematics_Vector_2E(double.Parse(textBox1.Text), double.Parse(textBox2.Text)),
                new Mathematics_Vector_2E(double.Parse(textBox4.Text), double.Parse(textBox3.Text)));
            listBox1.Items.Add(" (A,B) = " +
                 res+ "(radian)"+"="+Mathematics_Vector_3E.ExchangeRadian_To_C(res)+ "°");
        }
    }
}
