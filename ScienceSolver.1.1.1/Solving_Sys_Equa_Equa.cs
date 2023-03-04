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
    public partial class Solving_Sys_Equa_Equa : Form
    {
        public Solving_Sys_Equa_Equa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SystemOfEquation k=new SystemOfEquation();
            k.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Equations_Solving k=new Equations_Solving();
            k.ShowDialog();
            this.Show();
        }
    }
}
