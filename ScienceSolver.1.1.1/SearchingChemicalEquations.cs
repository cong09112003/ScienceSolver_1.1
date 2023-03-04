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
    public partial class SearchingChemicalEquations : Form
    {
        public SearchingChemicalEquations()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Chemistry_ElementsEquationList.DocFile(Application.StartupPath + "\\PhuongTrinhHoaHoc.txt");
            Chemistry_ElementsEquation res = Chemistry_ElementsEquationList.Find_Chemistr_Equation(textBox1.Text);
            if (res != null) 
            {
                textBox2.Text = "Success";
                listBox1.Items.Add("Result of " + textBox1.Text.ToLower());
                string[] equa = res.Chemist_Equation.Split('/');
                for (int i = 0; i< equa.Length;i++)
                {
                    listBox1.Items.Add(equa[i]);    
                }    
            }
            else
            {
                listBox1.Items.Clear();
                textBox2.Text = "ERROR";
            }
        }
        List<Chemistry_ElementsEquation> ds = new List<Chemistry_ElementsEquation>();
        private void button1_Click(object sender, EventArgs e)
        {
            this.docfile();
            listBox1.Items.Clear();
            int count = 0;
            foreach(Chemistry_ElementsEquation phuongtrinh in ds)
            {
                listBox1.Items.Add("Equaton"+(++count));
                string[] equa = phuongtrinh.Chemist_Equation.Split('/');
                for (int i = 0; i < equa.Length; i++)
                {
                    listBox1.Items.Add(equa[i]);
                }
                listBox1.Items.Add("");
            }    
        }
        private void docfile()
        {
            try
            {
                StreamReader sr = new StreamReader(Application.StartupPath + "\\PhuongTrinhHoaHoc.txt", Encoding.UTF8);
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] a = line.Split(';');
                    if (a.Length == 2)
                    {
                        Chemistry_ElementsEquation phuongtrinhhoahoc = new Chemistry_ElementsEquation();
                        phuongtrinhhoahoc.Precursors = a[0];
                        // List of equation for each the precursor
                        phuongtrinhhoahoc.Chemist_Equation = a[1];  
                        ds.Add(phuongtrinhhoahoc);
                    }
                    line = sr.ReadLine();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
