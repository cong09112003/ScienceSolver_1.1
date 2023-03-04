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
    public partial class Vector_3_axis : Form
    {
        public Vector_3_axis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox1.Text));
            textBox2.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox2.Text));
            textBox3.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox3.Text));

            textBox4.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox4.Text));
            textBox5.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox5.Text));
            textBox6.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox6.Text));

            listBox1.Items.Clear();
            listBox1.Items.Add("vector A =" + "{ " +double.Parse(textBox1.Text) 
                + "," + double.Parse(textBox2.Text) + "," + double.Parse(textBox4.Text)+"}");
            listBox1.Items.Add("Distance of vector A: " + Mathematics_Vector_3E.AbsoulteVecto(new Mathematics_Vector_3E(double.Parse(textBox1.Text),
                double.Parse(textBox2.Text), double.Parse(textBox4.Text))) );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox1.Text));
            textBox2.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox2.Text));
            textBox3.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox3.Text));

            textBox4.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox4.Text));
            textBox5.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox5.Text));
            textBox6.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox6.Text));
            listBox1.Items.Clear();
            listBox1.Items.Add("vector B =" + "{ " + double.Parse(textBox3.Text)
                + "," + double.Parse(textBox5.Text) + "," + double.Parse(textBox6.Text) + "}");
            listBox1.Items.Add("Distance of vector A: " + Mathematics_Vector_3E.AbsoulteVecto(new Mathematics_Vector_3E(double.Parse(textBox3.Text),
                double.Parse(textBox5.Text), double.Parse(textBox6.Text))));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox1.Text));
            textBox2.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox2.Text));
            textBox3.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox3.Text));

            textBox4.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox4.Text));
            textBox5.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox5.Text));
            textBox6.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox6.Text));
            listBox1.Items.Clear();
            listBox1.Items.Add(" (A . B) = " + Mathematics_Vector_3E.ScalarProductVecto(
                new Mathematics_Vector_3E(double.Parse(textBox1.Text),
                double.Parse(textBox2.Text), double.Parse(textBox4.Text)),new Mathematics_Vector_3E(double.Parse(textBox3.Text),
                double.Parse(textBox5.Text), double.Parse(textBox6.Text))) );
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox1.Text));
            textBox2.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox2.Text));
            textBox3.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox3.Text));

            textBox4.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox4.Text));
            textBox5.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox5.Text));
            textBox6.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox6.Text));
            listBox1.Items.Clear();
            Mathematics_Vector_3E res = new Mathematics_Vector_3E(double.Parse(textBox1.Text),
                double.Parse(textBox2.Text), double.Parse(textBox4.Text)) + new Mathematics_Vector_3E(double.Parse(textBox3.Text),
                double.Parse(textBox5.Text), double.Parse(textBox6.Text));
            listBox1.Items.Add(" A + B = " + "{" + res.X + "," + res.Y + "," + res.Z + "}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox1.Text));
            textBox2.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox2.Text));
            textBox3.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox3.Text));

            textBox4.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox4.Text));
            textBox5.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox5.Text));
            textBox6.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox6.Text));
            listBox1.Items.Clear();
            Mathematics_Vector_3E res = new Mathematics_Vector_3E(double.Parse(textBox1.Text),
                double.Parse(textBox2.Text), double.Parse(textBox4.Text)) - new Mathematics_Vector_3E(double.Parse(textBox3.Text),
                double.Parse(textBox5.Text), double.Parse(textBox6.Text));
            listBox1.Items.Add(" A - B = " + "{" + res.X + "," + res.Y + "," + res.Z + "}");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox1.Text));
            textBox2.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox2.Text));
            textBox3.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox3.Text));

            textBox4.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox4.Text));
            textBox5.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox5.Text));
            textBox6.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox6.Text));
            listBox1.Items.Clear();
            Mathematics_Vector_3E res = new Mathematics_Vector_3E(double.Parse(textBox3.Text),
                double.Parse(textBox5.Text), double.Parse(textBox6.Text)) - new Mathematics_Vector_3E(double.Parse(textBox1.Text),
                double.Parse(textBox2.Text), double.Parse(textBox4.Text));
            listBox1.Items.Add(" B - A = " + "{" + res.X + "," + res.Y + "," + res.Z + "}");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox1.Text));
            textBox2.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox2.Text));
            textBox3.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox3.Text));

            textBox4.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox4.Text));
            textBox5.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox5.Text));
            textBox6.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox6.Text));
            listBox1.Items.Clear();
            double res = Mathematics_Vector_3E.FindingAngle(new Mathematics_Vector_3E(double.Parse(textBox1.Text),
                double.Parse(textBox2.Text), double.Parse(textBox4.Text)), new Mathematics_Vector_3E(double.Parse(textBox3.Text),
                double.Parse(textBox5.Text), double.Parse(textBox6.Text)));
            listBox1.Items.Add("(A,B) = " + res +" (radian)"+ " = "+ Mathematics_Vector_3E.ExchangeRadian_To_C(res) + "°");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox1.Text));
            textBox2.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox2.Text));
            textBox3.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox3.Text));

            textBox4.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox4.Text));
            textBox5.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox5.Text));
            textBox6.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox6.Text));
            listBox1.Items.Clear ();
            Mathematics_Vector_3E res = Mathematics_Vector_3E.DirectedProductVector(new Mathematics_Vector_3E(double.Parse(textBox1.Text),
                double.Parse(textBox2.Text), double.Parse(textBox4.Text)), new Mathematics_Vector_3E(double.Parse(textBox3.Text),
                double.Parse(textBox5.Text), double.Parse(textBox6.Text)));
            listBox1.Items.Add("(Directed product) A*B ="+"{"+res.X+","+res.Y+","+res.Z+"}");   
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox1.Text));
            textBox2.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox2.Text));
            textBox3.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox3.Text));

            textBox4.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox4.Text));
            textBox5.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox5.Text));
            textBox6.Text = Y2Expression.EvaluatePostfix(Y2Expression.Infix2Postfix(textBox6.Text));
            listBox1.Items.Clear ();
            double res = Mathematics_Vector_3E.FindingSinAngle(new Mathematics_Vector_3E(double.Parse(textBox1.Text),
                double.Parse(textBox2.Text), double.Parse(textBox4.Text)), new Mathematics_Vector_3E(double.Parse(textBox3.Text),
                double.Parse(textBox5.Text), double.Parse(textBox6.Text)));
            listBox1.Items.Add("sin(A,B)=" + res);
            listBox1.Items.Add("(A,B) = " + Math.Asin(res) + "(radian)" + "=" + Mathematics_Vector_3E.ExchangeRadian_To_C(Math.Asin(res)) + "°");
        }
    }
}
