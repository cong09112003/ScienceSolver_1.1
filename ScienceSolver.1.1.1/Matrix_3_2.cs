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
    public partial class Matrix_3_2 : Form
    {
        public Matrix_3_2()
        {
            InitializeComponent();
        }
        public delegate void SaveData(double data1, double data2, double data3,double data4,double dat5,double data6);
        public SaveData Savematrix;
        private void button1_Click(object sender, EventArgs e)
        {
            Savematrix(double.Parse(textBox1.Text), double.Parse(textBox3.Text), double.Parse(textBox2.Text),double.Parse(textBox4.Text)
                ,double.Parse(textBox5.Text),double.Parse(textBox6.Text));
        }
    }
}
