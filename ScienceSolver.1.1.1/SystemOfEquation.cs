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
    public partial class SystemOfEquation : Form
    {
        public SystemOfEquation()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SystemOfEquation_2 k = new SystemOfEquation_2();
            k.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SystemOfEquations_3 m = new SystemOfEquations_3();
            m.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SystemOfEquations_4 o = new SystemOfEquations_4();
            o.ShowDialog();
            this.Show();
        }
    }
}
