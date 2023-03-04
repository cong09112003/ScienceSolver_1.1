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
    public partial class SystemOfEquation_2 : Form
    {
        public SystemOfEquation_2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }
        Mathematics_SystemEquation sys_equa = new Mathematics_SystemEquation_Step2();
        private void button1_Click(object sender, EventArgs e)
        {
            sys_equa.a1=double.Parse(textBox1.Text);
            sys_equa.b1= double.Parse(textBox2.Text);
            sys_equa.c1= double.Parse(textBox3.Text);
            sys_equa.a2= double.Parse(textBox4.Text);
            sys_equa.b2=double.Parse(textBox5.Text);
            sys_equa.c2=double.Parse(textBox6.Text);
            sys_equa.Mathematics_SysEqua_solving();
            listBox1.Items.Clear();
            listBox1.Items.Add(textBox1.Text + ".x + " + textBox2.Text + ".y = " + textBox3.Text);
            listBox1.Items.Add(textBox4.Text + ".x + " + textBox5.Text + ".y = " + textBox6.Text);
            listBox1.Items.Add("Result:");
            string[] arr = sys_equa.Variables.Split(",");
            for(int i=0;i<arr.Length;i++) 
            {
                listBox1.Items.Add(arr[i]);
            }
        }
    }
}
