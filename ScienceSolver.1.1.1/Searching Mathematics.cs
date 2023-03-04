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
    public partial class Searching_Mathematics : Form
    {
        public Searching_Mathematics()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchingMathFormula k = new SearchingMathFormula();
            k.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Searching_Mathematics_Theorem k = new Searching_Mathematics_Theorem();
            k.ShowDialog();
            this.Show();
        }
    }
}
