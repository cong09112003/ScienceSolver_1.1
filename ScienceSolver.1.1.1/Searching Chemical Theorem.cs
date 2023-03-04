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
    public partial class Searching_Chemical_Theorem : Form
    {
        public Searching_Chemical_Theorem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Chemistry_TheoremList.Docfile(Application.StartupPath + "\\DinhLuatHoaHoc.txt");
            Chemistry_Theorem res=Chemistry_TheoremList.Find_Chemistry_Theorem(int.Parse(comboBox1.Text));
            if(res!=null)
            {
                textBox1.Text = "SUCCESS";
                listBox1.Items.Clear();
                listBox1.Items.Add("ID of theorem:" + res.ID);
                listBox1.Items.Add("Name of theorem:" + res.Name);
                string[]arr=res.Description.Split(',');
                for(int i=0;i<arr.Length;i++) 
                {
                    listBox1.Items.Add(arr[i]);
                }
                listBox1.Items.Add("Formula of theorem:");
                string[]arr2=res.formula.Split("#");
                for (int i = 0; i < arr2.Length; i++)
                {
                    listBox1.Items.Add(arr2[i]);
                }
            }    
        }
        static List<Chemistry_Theorem> ds = new List<Chemistry_Theorem>();
        public static void Docfile()
        {
            try
            {
                StreamReader sr = new StreamReader(Application.StartupPath+ "\\DinhLuatHoaHoc.txt", Encoding.UTF8);
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] arr = line.Split(';');
                    if (arr.Length == 4)
                    {
                        Chemistry_Theorem dinhluat = new Chemistry_Theorem();
                        dinhluat.ID = int.Parse(arr[0]);
                        dinhluat.Name = arr[1];
                        dinhluat.Description = arr[2];
                        dinhluat.formula = arr[3];
                        ds.Add(dinhluat);   
                    }
                    line = sr.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Docfile();
            try
            {
                textBox1.Text = "SUCCESS";
                listBox1.Items.Clear();
                foreach (Chemistry_Theorem res in ds)
                {
                    listBox1.Items.Add("ID of theorem:" + res.ID);
                    listBox1.Items.Add("Name of theorem:" + res.Name);
                    string[] arr = res.Description.Split(',');
                    for (int i = 0; i < arr.Length; i++)
                    {
                        listBox1.Items.Add(arr[i]);
                    }
                    listBox1.Items.Add("Formula of theorem:");
                    string[] arr2 = res.formula.Split("#");
                    for (int i = 0; i < arr2.Length; i++)
                    {
                        listBox1.Items.Add(arr2[i]);
                    }
                    listBox1.Items.Add("");
                }    
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString()); 
            }
        }
    }
}
