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
    public partial class Matrix_1_3 : Form
    {
        public delegate void SaveData(double data1, double data2,double data3);
        public SaveData Savematrix;

        public Matrix_1_3()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Savematrix != null)
            {
                Savematrix(double.Parse(textBox1.Text), double.Parse(textBox3.Text),double.Parse(textBox2.Text));
            }
        }
    }
}
