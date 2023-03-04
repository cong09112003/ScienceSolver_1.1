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
    public partial class Matrix_2_4 : Form
    {
        public Matrix_2_4()
        {
            InitializeComponent();
        }
        public delegate void SaveData(double data1, double data2, double data3, double data4, double dt5, double dt6,double dt7,double dt8);
        public SaveData Savematrix;
        private void button1_Click(object sender, EventArgs e)
        {
            if (Savematrix != null)
            {
                Savematrix(double.Parse(textBox1.Text), double.Parse(textBox3.Text), double.Parse(textBox6.Text), double.Parse(textBox8.Text), 
                    double.Parse(textBox2.Text), double.Parse(textBox4.Text), double.Parse(textBox5.Text), double.Parse(textBox7.Text));
            }
        }
    }
}
