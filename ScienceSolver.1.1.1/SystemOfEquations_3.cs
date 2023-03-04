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
    public partial class SystemOfEquations_3 : Form
    {
        public SystemOfEquations_3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {



        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        Mathematics_SystemEquation sys_equa = new Mathematics_SystemEquation_Step3();
        private void button1_Click(object sender, EventArgs e)
        {
            sys_equa.a1=double.Parse(textBox1.Text);
            sys_equa.b1= double.Parse(textBox4.Text);
            sys_equa.c1= double.Parse(textBox7.Text);
            sys_equa.d1= double.Parse(textBox10.Text);

            sys_equa.a2 = double.Parse(textBox2.Text);
            sys_equa.b2=double.Parse(textBox5.Text);
            sys_equa.c2= double.Parse(textBox8.Text);
            sys_equa.d2 = double.Parse(textBox11.Text);

            sys_equa.a3= double.Parse(textBox3.Text);
            sys_equa.b3= double.Parse(textBox6.Text);
            sys_equa.c3= double.Parse(textBox9.Text);
            sys_equa.d3= double.Parse(textBox12.Text);

            sys_equa.Mathematics_SysEqua_solving();
            listBox1.Items.Clear();
            listBox1.Items.Add(textBox1.Text + ".x + " + textBox4.Text + ".y + " + textBox7.Text + ".z =" + textBox10.Text);
            listBox1.Items.Add(textBox2.Text + ".x + " + textBox5.Text + ".y + " + textBox8.Text + ".z =" + textBox11.Text);
            listBox1.Items.Add(textBox3.Text + ".x + " + textBox6.Text + ".y + " + textBox9.Text + ".z =" + textBox12.Text);
            listBox1.Items.Add("Result:");
            string[]arr = sys_equa.Variables.Split(",");
            for(int i=0;i<arr.Length;i++)
            {
                listBox1.Items.Add(arr[i]);
            }    
        }
    }
}
