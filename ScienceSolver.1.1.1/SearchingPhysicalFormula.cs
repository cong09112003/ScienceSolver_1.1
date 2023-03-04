using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScienceSolver._1._1._1
{
    public partial class SearchingPhysicalFormula : Form
    {
        public SearchingPhysicalFormula()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Physics_ListFormula.Docfile(Application.StartupPath + "//CongThucVatLy.txt");
            Physics_Formula res = Physics_ListFormula.Find_Physics_Formula(int.Parse(textBox1.Text));
            if (res != null) 
            {
                textBox2.Text = "SUCCESS";
                listBox1.Items.Clear();
                listBox1.Items.Add("ID: " + res.ID);
                listBox1.Items.Add("Name of physical formula: " + res.Name);
                listBox1.Items.Add("Description of physical formula: " + res.Description);
                listBox1.Items.Add("Fomula of physical formula:" + res.Formula);
            }
            else
            {
                textBox2.Text = "ERORR";
                listBox1.Items.Clear();
            }    
        }
        List<Physics_Formula> ds= new List<Physics_Formula>();
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.docfile();
                listBox1.Items.Clear();
                int count = 0;
                foreach (Physics_Formula res in ds)
                {
                    listBox1.Items.Add("Num" + (++count));
                    listBox1.Items.Add("ID: " + res.ID);
                    listBox1.Items.Add("Name of physical formula: " + res.Name);
                    listBox1.Items.Add("Description of physical formula: " + res.Description);
                    listBox1.Items.Add("Fomula of physical formula:" + res.Formula);
                    listBox1.Items.Add(" ");
                }
            }
            catch(Exception ex) { 
                MessageBox.Show(ex.Message);
                textBox2.Text = "ERROR";
                listBox1.Items.Clear();
            }
        }
        private void docfile()
        {
            try
            {
                StreamReader sr = new StreamReader(Application.StartupPath+"//CongThucVatLy.txt", Encoding.UTF8);
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] arr = line.Split(';');
                    if (arr.Length == 4)
                    {
                        Physics_Formula congthuc = new Physics_Formula();
                        congthuc.ID = int.Parse(arr[0]);
                        congthuc.Name = arr[1];
                        congthuc.Description = arr[2];
                        congthuc.Formula = arr[3];
                        ds.Add(congthuc);
                    }
                    line = sr.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
