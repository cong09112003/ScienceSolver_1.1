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
    public partial class Physics : Form
    {
        public Physics()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PhysicExchangeUnits k= new PhysicExchangeUnits();   
            k.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            Searching_Physical_Constant m=new Searching_Physical_Constant();
            m.ShowDialog();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Searching_Physics_Theorem m=new Searching_Physics_Theorem();
            m.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchingPhysicalFormula o=new SearchingPhysicalFormula();
            o.ShowDialog();
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
