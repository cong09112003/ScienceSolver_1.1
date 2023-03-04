using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScienceSolver._1._1._1
{
    public partial class SearchingChemicalElements : Form
    {
        public SearchingChemicalElements()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }
        List<Chemistry_Elements> ds=new List<Chemistry_Elements>();
        private void button1_Click(object sender, EventArgs e)
        {
            Chemistry_ListElements.Docfile(Application.StartupPath + "\\NguyenToHoaHoc.txt");
            Chemistry_Elements res = Chemistry_ListElements.Find_Elements(int.Parse(textBox1.Text));
            if(res != null) 
            {
                textBox2.Text = "Success";
                listBox1.Items.Clear();
                listBox1.Items.Add("Locate in chemical table:" + res.Element_ID);
                listBox1.Items.Add("Sign of Element:" + res.Chemis_Sign);
                listBox1.Items.Add("Name of ELement:" + res.Element_Name);
                listBox1.Items.Add("Atomic Mass of element:" + res.Element_Atomic_Mass + "( MeV/c2 ) - đvc");
                listBox1.Items.Add("Configuration of element (Cấu hình electron):"+res.Element_Configuration);
                listBox1.Items.Add("Electronegativity of elements:" + res.Electronegativity);
                listBox1.Items.Add("Oxidation of elements:" + res.Oxidation);
                listBox1.Items.Add("");
            }
            else
            {
                listBox1.Items.Clear();
                textBox2.Text = "ERROR";
            }
        }
        private void docfile()
        {
            try
            {
                StreamReader sr = new StreamReader(Application.StartupPath + "\\NguyenToHoaHoc.txt", Encoding.UTF8);
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] a = line.Split(';');
                    if (a.Length == 7)
                    {
                        Chemistry_Elements nguyento = new Chemistry_Elements();
                        nguyento.Element_ID = int.Parse(a[0]);
                        nguyento.Chemis_Sign = a[1];
                        nguyento.Element_Name = a[2];
                        nguyento.Element_Atomic_Mass = double.Parse(a[3]);
                        nguyento.Element_Configuration = a[4];
                        nguyento.Electronegativity = double.Parse(a[5]);
                        nguyento.Oxidation = a[6];
                        ds.Add(nguyento);   
                    }
                    line = sr.ReadLine();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.docfile();
            listBox1.Items.Clear();
            int count = 0;
            foreach (Chemistry_Elements res in ds) 
            {
                listBox1.Items.Add("Chemical element " + (++count) + ":");
                listBox1.Items.Add("Locate in chemical table:" + res.Element_ID);
                listBox1.Items.Add("Sign of Element:" + res.Chemis_Sign);
                listBox1.Items.Add("Name of ELement:" + res.Element_Name);
                listBox1.Items.Add("Atomic Mass of element:" + res.Element_Atomic_Mass + "( MeV/c2 ) - đvc");
                listBox1.Items.Add("Configuration of element (Cấu hình electron):" + res.Element_Configuration);
                listBox1.Items.Add("Electronegativity of elements:" + res.Electronegativity);
                listBox1.Items.Add("Oxidation of elements:" + res.Oxidation);
                listBox1.Items.Add("");
            }
        }
    }
}
