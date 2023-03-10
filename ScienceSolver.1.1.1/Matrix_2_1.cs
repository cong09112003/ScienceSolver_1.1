using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ScienceSolver._1._1._1
{
    public partial class Matrix_2_1 : Form
    {
        public delegate void SaveData(double data1, double data2);
        public SaveData Savematrix;
        public Matrix_2_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Savematrix != null)
            {
                Savematrix(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
            }
        }
    }
}
