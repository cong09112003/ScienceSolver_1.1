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
    public partial class Mathematics : Form
    {
        public Mathematics()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HighLevelCalculate m= new HighLevelCalculate();
            m.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
           Solving_Sys_Equa_Equa k=new Solving_Sys_Equa_Equa();
            k.ShowDialog();
            this.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Searching_Mathematics k=new Searching_Mathematics();
            k.ShowDialog();
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Calculating_Matrix k=new Calculating_Matrix();  
            k.ShowDialog();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vector v = new Vector();
            v.ShowDialog();
            this.Show();
        }
    }
}
