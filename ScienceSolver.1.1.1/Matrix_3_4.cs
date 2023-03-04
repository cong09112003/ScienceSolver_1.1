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
    public partial class Matrix_3_4 : Form
    {
        public Matrix_3_4()
        {
            InitializeComponent();
        }
        public delegate void SaveData(double data1, double data2, double data3, double data4, double data5, double data6, double data7,
            double data8, double data9,double data10,double data11,double data12);
        public SaveData Savematrix;
        private void Matrix_3_4_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Savematrix(double.Parse(textBox1.Text), double.Parse(textBox3.Text), double.Parse(textBox7.Text), double.Parse(textBox12.Text)
                                , double.Parse(textBox2.Text), double.Parse(textBox4.Text), double.Parse(textBox8.Text),
                                double.Parse(textBox11.Text),
                                double.Parse(textBox5.Text), double.Parse(textBox6.Text), double.Parse(textBox9.Text), double.Parse(textBox10.Text));

        }
    }
}
