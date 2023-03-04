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
    public partial class Matrix_1_1 : Form
    {
        public Matrix_1_1()
        {
            InitializeComponent();
        }
        public delegate void SaveData(double data);
        public SaveData Savematrix;
        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {       
            if(Savematrix!= null)
            {
                Savematrix(double.Parse(textBox1.Text));
            }
        }
        private void Matrix_1_1_Load(object sender, EventArgs e)
        {

        }
    }
}
