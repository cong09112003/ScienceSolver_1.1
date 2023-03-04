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
    public partial class Equations_Solving : Form
    {
        public Equations_Solving()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Equation_FirstDegree k1= new Equation_FirstDegree();
            k1.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Equation_SecondeDegree k2= new Equation_SecondeDegree();
            k2.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Equation_ThirdDegree k3=new Equation_ThirdDegree();
            k3.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Equation_FourthDegree k4=new Equation_FourthDegree();
            k4.ShowDialog();
            this.Show();
        }

        private void Equations_Solving_Load(object sender, EventArgs e)
        {

        }
    }
}
