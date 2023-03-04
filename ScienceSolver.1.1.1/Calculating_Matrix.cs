using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ScienceSolver._1._1._1
{
    public partial class Calculating_Matrix : Form
    {
        public Calculating_Matrix()
        {
            InitializeComponent();
        }
        static Mathematics_Matrix matrixA = new Mathematics_Matrix();
        static Mathematics_Matrix matrixB = new Mathematics_Matrix();
        private void Calculating_Matrix_Load(object sender, EventArgs e)
        {

        }

       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        // 1 Row
        public void LoadData1(double data1)
        {
                matrixA.Matrix[0,0] = data1;
        }
        private void LoadData2(double data1, double data2)
        {
            matrixA.Matrix[0, 0] = data1;
            matrixA.Matrix[0, 1] = data2;
        }
        private void LoadData3(double data1, double data2, double data3) 
        {
            matrixA.Matrix[0, 0]= data1;
            matrixA.Matrix[0, 1]= data2;
            matrixA.Matrix[0, 2]= data3;
        }
        private void LoadData4(double data1,double data2, double data3, double data4)
        {
            matrixA.Matrix[0, 0] = data1;
            matrixA.Matrix[0, 1] = data2;
            matrixA.Matrix[0, 2] = data3;
            matrixA.Matrix[0, 3] = data4;
        }

        // 2 Row
        private void LoadData5(double dt1,double dt2)
        {
            matrixA.Matrix[0,0]= dt1;
            matrixA.Matrix[1,0]= dt2;
        }
        private void LoadData6(double dt1, double dt2,double dt3,double dt4)
        {
            matrixA.Matrix[0,0] = dt1;
            matrixA.Matrix[0,1] = dt2;
            matrixA.Matrix[1,0] = dt3;
            matrixA.Matrix[1,1] = dt4;
        }
        private void LoadData7(double dt1,double dt2,double dt3,double dt4,double dt5,double dt6)
        {
            matrixA.Matrix[0, 0] = dt1;
            matrixA.Matrix[0, 1] = dt2;
            matrixA.Matrix[0, 2] = dt3;
            matrixA.Matrix[1, 0] = dt4;
            matrixA.Matrix[1, 1]= dt5;
            matrixA.Matrix[1, 2]= dt6;

        }
        private void LoadData8(double dt1, double dt2, double dt3, double dt4, double dt5, double dt6,double dt7,double dt8)
        {
            matrixA.Matrix[0, 0] = dt1;
            matrixA.Matrix[0, 1] = dt2;
            matrixA.Matrix[0, 2] = dt3;
            matrixA.Matrix[0, 3] = dt4;
            matrixA.Matrix[1, 0]= dt5;
            matrixA.Matrix[1, 1]= dt6;
            matrixA.Matrix[1, 2]= dt7;
            matrixA.Matrix[1, 3]= dt8;

        }
        //3 Row
        private void LoadData9(double dt1, double dt2, double dt3)
        {
            matrixA.Matrix[0, 0] = dt1;
            matrixA.Matrix[1, 0] = dt2;
            matrixA.Matrix[2, 0] = dt3;
        }
        private void LoadData10(double dt1, double dt2, double dt3, double dt4, double dt5, double dt6)
        {
            matrixA.Matrix[0, 0] = dt1;
            matrixA.Matrix[0, 1] = dt2;
            matrixA.Matrix[1, 0] = dt3;
            matrixA.Matrix[1, 1] = dt4;
            matrixA.Matrix[2, 0] = dt5;
            matrixA.Matrix[2, 1] = dt6;
        }
        private void LoadData11(double dt1, double dt2, double dt3, double dt4, double dt5, double dt6, double dt7, double dt8,double dt9)
        {
            matrixA.Matrix[0, 0] = dt1;
            matrixA.Matrix[0, 1] = dt2;
            matrixA.Matrix[0, 2] = dt3;
            matrixA.Matrix[1, 0] = dt4;
            matrixA.Matrix[1, 1] = dt5;
            matrixA.Matrix[1, 2] = dt6;
            matrixA.Matrix[2, 0] = dt7;
            matrixA.Matrix[2, 1] = dt8;
            matrixA.Matrix[2, 2] = dt9;
        }
        private void LoadData12(double dt1, double dt2, double dt3, double dt4, double dt5, double dt6, double dt7, double dt8, double dt9,double dt10,double dt11,double dt12)
        {
            matrixA.Matrix[0, 0] = dt1;
            matrixA.Matrix[0, 1] = dt2;
            matrixA.Matrix[0, 2] = dt3;
            matrixA.Matrix[0, 3] = dt4;
            matrixA.Matrix[1, 0] = dt5;
            matrixA.Matrix[1, 1] = dt6;
            matrixA.Matrix[1, 2] = dt7;
            matrixA.Matrix[1, 3] = dt8;
            matrixA.Matrix[2, 0] = dt9;
            matrixA.Matrix[2, 1] = dt10;
            matrixA.Matrix[2, 2] = dt11;
            matrixA.Matrix[2, 3] = dt12;
        }
        // 4Row
        private void LoadData13(double dt1, double dt2, double dt3,double dt4)
        {
            matrixA.Matrix[0, 0] = dt1;
            matrixA.Matrix[1, 0] = dt2;
            matrixA.Matrix[2, 0] = dt3;
            matrixA.Matrix[3, 0] = dt4;
        }
        private void LoadData14(double dt1, double dt2, double dt3, double dt4, double dt5, double dt6, double dt7, double dt8)
        {
            matrixA.Matrix[0, 0] = dt1;
            matrixA.Matrix[0, 1] = dt2;
            matrixA.Matrix[1, 0] = dt3;
            matrixA.Matrix[1, 1] = dt4;
            matrixA.Matrix[2, 0] = dt5;
            matrixA.Matrix[2, 1] = dt6;
            matrixA.Matrix[3, 0] = dt7;
            matrixA.Matrix[3, 1] = dt8;
        }
        private void LoadData15(double dt1, double dt2, double dt3, double dt4, double dt5, double dt6, double dt7, double dt8, double dt9, double dt10, double dt11, double dt12)
        {
            matrixA.Matrix[0, 0] = dt1;
            matrixA.Matrix[0, 1] = dt2;
            matrixA.Matrix[0, 2] = dt3;
            matrixA.Matrix[1, 0] = dt4;
            matrixA.Matrix[1, 1] = dt5;
            matrixA.Matrix[1, 2] = dt6;
            matrixA.Matrix[2, 0] = dt7;
            matrixA.Matrix[2, 1] = dt8;
            matrixA.Matrix[2, 2] = dt9;
            matrixA.Matrix[3, 0] = dt10;
            matrixA.Matrix[3, 1] = dt11;
            matrixA.Matrix[3, 2] = dt12;
        }
        private void LoadData16(double dt1, double dt2, double dt3, double dt4, double dt5, double dt6, double dt7, double dt8, double dt9, double dt10, double dt11, double dt12,double dt13,double dt14,double dt15,double dt16)
        {
            matrixA.Matrix[0, 0] = dt1;
            matrixA.Matrix[0, 1] = dt2;
            matrixA.Matrix[0, 2] = dt3;
            matrixA.Matrix[0, 3] = dt4;
            matrixA.Matrix[1, 0] = dt5;
            matrixA.Matrix[1, 1] = dt6;
            matrixA.Matrix[1, 2] = dt7;
            matrixA.Matrix[1, 3] = dt8;
            matrixA.Matrix[2, 0] = dt9;
            matrixA.Matrix[2, 1] = dt10;
            matrixA.Matrix[2, 2] = dt11;
            matrixA.Matrix[2, 3] = dt12;
            matrixA.Matrix[3, 0] = dt13;
            matrixA.Matrix[3, 1] = dt14;
            matrixA.Matrix[3, 2] = dt15;
            matrixA.Matrix[3, 3] = dt16;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            matrixA.Matrix_Row = int.Parse(comboxRowA.Text);
            matrixA.Matrix_Colum = int.Parse(comBoxColA.Text);
            matrixA.Matrix = new double[matrixA.Matrix_Row, matrixA.Matrix_Colum];
            listBox1.Items.Clear();
            if (matrixA.Matrix_Row==1 && matrixA.Matrix_Colum==1)      // 1Row 1Col
            {
                this.Hide();
                Matrix_1_1 f = new Matrix_1_1();
                f.Savematrix = new Matrix_1_1.SaveData(LoadData1);
                f.ShowDialog();

                listBox1.Items.Add("Matrix A");
                listBox1.Items.Add("Row of A:" + matrixA.Matrix_Row);
                listBox1.Items.Add("Column of A:" + matrixA.Matrix_Colum);
                for (int i = 0; i < matrixA.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < matrixA.Matrix_Colum; j++)
                    {
                        s +=" Matrix["+i+","+j+"] ="+ matrixA.Matrix[i,j];
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }

                this.Show();
            }
            else if(matrixA.Matrix_Row==1 && matrixA.Matrix_Colum==2)
            {
                this.Hide();
                Matrix_1_2 f = new Matrix_1_2();
                f.Savematrix=new Matrix_1_2.SaveData(LoadData2);
                f.ShowDialog();
                // Show on listBox1
                listBox1.Items.Add("Matrix A");
                listBox1.Items.Add("Row of A:" + matrixA.Matrix_Row);
                listBox1.Items.Add("Column of A:" + matrixA.Matrix_Colum);
                for (int i = 0; i < matrixA.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < matrixA.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + matrixA.Matrix[i, j]+ " ";
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }
                // return the main form
                this.Show();
            }
            else if(matrixA.Matrix_Row == 1 && matrixA.Matrix_Colum == 3)
            {
                this.Hide();
                Matrix_1_3 f = new Matrix_1_3();
                f.Savematrix=new Matrix_1_3.SaveData(LoadData3);
                f.ShowDialog();
                listBox1.Items.Add("Matrix A");
                listBox1.Items.Add("Row of A:" + matrixA.Matrix_Row);
                listBox1.Items.Add("Column of A:" + matrixA.Matrix_Colum);
                for (int i = 0; i < matrixA.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < matrixA.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + matrixA.Matrix[i, j] + " ";
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }
                // return the main form
                this.Show();
            }
            else if(matrixA.Matrix_Row==1 && matrixA.Matrix_Colum==4)
            {
                this.Hide();
                Matrix_1_4 f = new Matrix_1_4();
                f.Savematrix=new Matrix_1_4.SaveData(LoadData4);
                f.ShowDialog();
                listBox1.Items.Add("Matrix A");
                listBox1.Items.Add("Row of A:" + matrixA.Matrix_Row);
                listBox1.Items.Add("Column of A:" + matrixA.Matrix_Colum);
                for (int i = 0; i < matrixA.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < matrixA.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + matrixA.Matrix[i, j] + " ";
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }
                // return the main form
                this.Show();
            }
            else if(matrixA.Matrix_Row==2 && matrixA.Matrix_Colum==1)  // 2 Row 1 Col
            {
                this.Hide();
                Matrix_2_1 f=new Matrix_2_1();
                f.Savematrix=new Matrix_2_1.SaveData(LoadData5);
                f.ShowDialog();
                listBox1.Items.Add("Matrix A");
                listBox1.Items.Add("Row of A:" + matrixA.Matrix_Row);
                listBox1.Items.Add("Column of A:" + matrixA.Matrix_Colum);
                for (int i = 0; i < matrixA.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < matrixA.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + matrixA.Matrix[i, j] + " ";
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }
                // return the main form
                this.Show();
            }
            else if(matrixA.Matrix_Row==2&&matrixA.Matrix_Colum==2) 
            {
                this.Hide();
                Matrix_2_2 f=new Matrix_2_2();
                f.Savematrix=new Matrix_2_2.SaveData(LoadData6);
                f.ShowDialog();
                listBox1.Items.Add("Matrix A");
                listBox1.Items.Add("Row of A:" + matrixA.Matrix_Row);
                listBox1.Items.Add("Column of A:" + matrixA.Matrix_Colum);
                for (int i = 0; i < matrixA.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < matrixA.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + matrixA.Matrix[i, j] + " ";
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }
                // return the main form
                this.Show();
            }
            else if(matrixA.Matrix_Row==2 && matrixA.Matrix_Colum== 3) 
            {
                this.Hide();
                Matrix_2_3 f = new Matrix_2_3();
                f.Savematrix=new Matrix_2_3.SaveData(LoadData7);
                f.ShowDialog();
                listBox1.Items.Add("Matrix A");
                listBox1.Items.Add("Row of A:" + matrixA.Matrix_Row);
                listBox1.Items.Add("Column of A:" + matrixA.Matrix_Colum);
                for (int i = 0; i < matrixA.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < matrixA.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + matrixA.Matrix[i, j] + " ";
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }
                // return the main form
                this.Show();
            }
            else if(matrixA.Matrix_Row == 2 && matrixA.Matrix_Colum == 4)
            {
                this.Hide();
                Matrix_2_4 f=new Matrix_2_4();
                f.Savematrix=new Matrix_2_4.SaveData(LoadData8);
                f.ShowDialog();
                listBox1.Items.Add("Matrix A");
                listBox1.Items.Add("Row of A:" + matrixA.Matrix_Row);
                listBox1.Items.Add("Column of A:" + matrixA.Matrix_Colum);
                for (int i = 0; i < matrixA.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < matrixA.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + matrixA.Matrix[i, j] + " ";
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }
                // return the main form
                this.Show();
            }
            else if(matrixA.Matrix_Row==3 && matrixA.Matrix_Colum == 1) 
            {
                this.Hide();
                Matrix_3_1 f=new Matrix_3_1();
                f.Savematrix=new Matrix_3_1.SaveData(LoadData9);
                f.ShowDialog();
                listBox1.Items.Add("Matrix A");
                listBox1.Items.Add("Row of A:" + matrixA.Matrix_Row);
                listBox1.Items.Add("Column of A:" + matrixA.Matrix_Colum);
                for (int i = 0; i < matrixA.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < matrixA.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + matrixA.Matrix[i, j] + " ";
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }
                // return the main form
                this.Show();
            }
            else if (matrixA.Matrix_Row==3 && matrixA.Matrix_Colum==2)
            {
                this.Hide();
                Matrix_3_2 f=new Matrix_3_2();
                f.Savematrix=new Matrix_3_2.SaveData(LoadData10);
                f.ShowDialog();
                listBox1.Items.Add("Matrix A");
                listBox1.Items.Add("Row of A:" + matrixA.Matrix_Row);
                listBox1.Items.Add("Column of A:" + matrixA.Matrix_Colum);
                for (int i = 0; i < matrixA.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < matrixA.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + matrixA.Matrix[i, j] + " ";
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }
                // return the main form
                this.Show();
            }
            else if (matrixA.Matrix_Row==3 && matrixA.Matrix_Colum==3)
            {
                this.Hide();
                Matrix_3_3 f=new Matrix_3_3();
                f.Savematrix = new Matrix_3_3.SaveData(LoadData11);
                f.ShowDialog();
                listBox1.Items.Add("Matrix A");
                listBox1.Items.Add("Row of A:" + matrixA.Matrix_Row);
                listBox1.Items.Add("Column of A:" + matrixA.Matrix_Colum);
                for (int i = 0; i < matrixA.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < matrixA.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + matrixA.Matrix[i, j] + " ";
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }
                // return the main form
                this.Show();
            }
            else if (matrixA.Matrix_Row==3 && matrixA.Matrix_Colum==4)
            {
                this.Hide();
                Matrix_3_4 f=new Matrix_3_4();
                f.Savematrix = new Matrix_3_4.SaveData(LoadData12); 
                f.ShowDialog();
                listBox1.Items.Add("Matrix A");
                listBox1.Items.Add("Row of A:" + matrixA.Matrix_Row);
                listBox1.Items.Add("Column of A:" + matrixA.Matrix_Colum);
                for (int i = 0; i < matrixA.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < matrixA.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + matrixA.Matrix[i, j] + " ";
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }
                // return the main form
                this.Show();
            }
            else if(matrixA.Matrix_Row==4 && matrixA.Matrix_Colum==1) 
            {
                this.Hide();
                Matrix_4_1 f=new Matrix_4_1();
                f.Savematrix=new Matrix_4_1.SaveData(LoadData13);
                f.ShowDialog();
                listBox1.Items.Add("Matrix A");
                listBox1.Items.Add("Row of A:" + matrixA.Matrix_Row);
                listBox1.Items.Add("Column of A:" + matrixA.Matrix_Colum);
                for (int i = 0; i < matrixA.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < matrixA.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + matrixA.Matrix[i, j] + " ";
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }
                // return the main form
                this.Show();
            }
            else if (matrixA.Matrix_Row==4 && matrixA.Matrix_Colum== 2) 
            {
                this.Hide();
                Matrix_4_2 f=new Matrix_4_2();
                f.Savematrix=new Matrix_4_2.SaveData(LoadData14);
                f.ShowDialog();
                listBox1.Items.Add("Matrix A");
                listBox1.Items.Add("Row of A:" + matrixA.Matrix_Row);
                listBox1.Items.Add("Column of A:" + matrixA.Matrix_Colum);
                for (int i = 0; i < matrixA.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < matrixA.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + matrixA.Matrix[i, j] + " ";
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }
                // return the main form
                this.Show();
            }
            else if (matrixA.Matrix_Row==4 && matrixA.Matrix_Colum==3)
            {
                this.Hide();
                Matrix_4_3 f=new Matrix_4_3();
                f.Savematrix = new Matrix_4_3.SaveData(LoadData15);
                f.ShowDialog();
                listBox1.Items.Add("Matrix A");
                listBox1.Items.Add("Row of A:" + matrixA.Matrix_Row);
                listBox1.Items.Add("Column of A:" + matrixA.Matrix_Colum);
                for (int i = 0; i < matrixA.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < matrixA.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + matrixA.Matrix[i, j] + " ";
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }
                // return the main form
                this.Show();
            }
            else if(matrixA.Matrix_Row==4 && matrixA.Matrix_Colum== 4) 
            {
                this.Hide();
                Matrix_4_4 f=new Matrix_4_4();
                f.Savematrix=new Matrix_4_4.SaveData(LoadData16);
                f.ShowDialog();
                listBox1.Items.Add("Matrix A");
                listBox1.Items.Add("Row of A:" + matrixA.Matrix_Row);
                listBox1.Items.Add("Column of A:" + matrixA.Matrix_Colum);
                for (int i = 0; i < matrixA.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < matrixA.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + matrixA.Matrix[i, j] + " ";
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }
                // return the main form
                this.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            matrixB.Matrix_Row = int.Parse(comBoxRowB.Text);
            matrixB.Matrix_Colum = int.Parse(comBoxColB.Text);
            matrixB.Matrix = new double[matrixB.Matrix_Row, matrixB.Matrix_Colum];
            listBox1.Items.Clear();
            if (matrixB.Matrix_Row == 1 && matrixB.Matrix_Colum == 1)      // 1Row 1Col
            {
                this.Hide();
                Matrix_1_1 f = new Matrix_1_1();
                f.Savematrix = new Matrix_1_1.SaveData(LoadData1_);
                f.ShowDialog();

                listBox1.Items.Add("Matrix B");
                listBox1.Items.Add("Row of B:" + matrixB.Matrix_Row);
                listBox1.Items.Add("Column of B:" + matrixB.Matrix_Colum);
                for (int i = 0; i < matrixB.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < matrixB.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + matrixB.Matrix[i, j];
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }

                this.Show();
            }
            else if (matrixB.Matrix_Row == 1 && matrixB.Matrix_Colum == 2)
            {
                this.Hide();
                Matrix_1_2 f = new Matrix_1_2();
                f.Savematrix = new Matrix_1_2.SaveData(LoadData2_);
                f.ShowDialog();
                // Show on listBox1
                listBox1.Items.Add("Matrix B");
                listBox1.Items.Add("Row of B:" + matrixB.Matrix_Row);
                listBox1.Items.Add("Column of B:" + matrixB.Matrix_Colum);
                for (int i = 0; i < matrixB.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < matrixB.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + matrixB.Matrix[i, j];
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }

                this.Show();
            }
            else if (matrixB.Matrix_Row == 1 && matrixB.Matrix_Colum == 3)
            {
                this.Hide();
                Matrix_1_3 f = new Matrix_1_3();
                f.Savematrix = new Matrix_1_3.SaveData(LoadData3_);
                f.ShowDialog();
                listBox1.Items.Add("Matrix B");
                listBox1.Items.Add("Row of B:" + matrixB.Matrix_Row);
                listBox1.Items.Add("Column of B:" + matrixB.Matrix_Colum);
                for (int i = 0; i < matrixB.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < matrixB.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + matrixB.Matrix[i, j];
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }

                this.Show();
            }
            else if (matrixB.Matrix_Row == 1 && matrixB.Matrix_Colum == 4)
            {
                this.Hide();
                Matrix_1_4 f = new Matrix_1_4();
                f.Savematrix = new Matrix_1_4.SaveData(LoadData4_);
                f.ShowDialog();
                listBox1.Items.Add("Matrix B");
                listBox1.Items.Add("Row of B:" + matrixB.Matrix_Row);
                listBox1.Items.Add("Column of B:" + matrixB.Matrix_Colum);
                for (int i = 0; i < matrixB.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < matrixB.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + matrixB.Matrix[i, j];
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }

                this.Show();
            }
            else if (matrixB.Matrix_Row == 2 && matrixB.Matrix_Colum == 1)  // 2 Row 1 Col
            {
                this.Hide();
                Matrix_2_1 f = new Matrix_2_1();
                f.Savematrix = new Matrix_2_1.SaveData(LoadData5_);
                f.ShowDialog();
                listBox1.Items.Add("Matrix B");
                listBox1.Items.Add("Row of B:" + matrixB.Matrix_Row);
                listBox1.Items.Add("Column of B:" + matrixB.Matrix_Colum);
                for (int i = 0; i < matrixB.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < matrixB.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + matrixB.Matrix[i, j];
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }

                this.Show();
            }
            else if (matrixB.Matrix_Row == 2 && matrixB.Matrix_Colum == 2)
            {
                this.Hide();
                Matrix_2_2 f = new Matrix_2_2();
                f.Savematrix = new Matrix_2_2.SaveData(LoadData6_);
                f.ShowDialog();
                listBox1.Items.Add("Matrix B");
                listBox1.Items.Add("Row of B:" + matrixB.Matrix_Row);
                listBox1.Items.Add("Column of B:" + matrixB.Matrix_Colum);
                for (int i = 0; i < matrixB.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < matrixB.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + matrixB.Matrix[i, j];
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }

                this.Show();
            }
            else if (matrixB.Matrix_Row == 2 && matrixB.Matrix_Colum == 3)
            {
                this.Hide();
                Matrix_2_3 f = new Matrix_2_3();
                f.Savematrix = new Matrix_2_3.SaveData(LoadData7_);
                f.ShowDialog();
                listBox1.Items.Add("Matrix B");
                listBox1.Items.Add("Row of B:" + matrixB.Matrix_Row);
                listBox1.Items.Add("Column of B:" + matrixB.Matrix_Colum);
                for (int i = 0; i < matrixB.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < matrixB.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + matrixB.Matrix[i, j];
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }

                this.Show();
            }
            else if (matrixB.Matrix_Row == 2 && matrixB.Matrix_Colum == 4)
            {
                this.Hide();
                Matrix_2_4 f = new Matrix_2_4();
                f.Savematrix = new Matrix_2_4.SaveData(LoadData8_);
                f.ShowDialog();
                listBox1.Items.Add("Matrix B");
                listBox1.Items.Add("Row of B:" + matrixB.Matrix_Row);
                listBox1.Items.Add("Column of B:" + matrixB.Matrix_Colum);
                for (int i = 0; i < matrixB.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < matrixB.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + matrixB.Matrix[i, j];
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }

                this.Show();
            }
            else if (matrixB.Matrix_Row == 3 && matrixB.Matrix_Colum == 1)
            {
                this.Hide();
                Matrix_3_1 f = new Matrix_3_1();
                f.Savematrix = new Matrix_3_1.SaveData(LoadData9_);
                f.ShowDialog();
                listBox1.Items.Add("Matrix B");
                listBox1.Items.Add("Row of B:" + matrixB.Matrix_Row);
                listBox1.Items.Add("Column of B:" + matrixB.Matrix_Colum);
                for (int i = 0; i < matrixB.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < matrixB.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + matrixB.Matrix[i, j];
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }

                this.Show();
            }
            else if (matrixB.Matrix_Row == 3 && matrixB.Matrix_Colum == 2)
            {
                this.Hide();
                Matrix_3_2 f = new Matrix_3_2();
                f.Savematrix = new Matrix_3_2.SaveData(LoadData10_);
                f.ShowDialog();
                listBox1.Items.Add("Matrix B");
                listBox1.Items.Add("Row of B:" + matrixB.Matrix_Row);
                listBox1.Items.Add("Column of B:" + matrixB.Matrix_Colum);
                for (int i = 0; i < matrixB.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < matrixB.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + matrixB.Matrix[i, j];
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }

                this.Show();
            }
            else if (matrixB.Matrix_Row == 3 && matrixB.Matrix_Colum == 3)
            {
                this.Hide();
                Matrix_3_3 f = new Matrix_3_3();
                f.Savematrix = new Matrix_3_3.SaveData(LoadData11_);
                f.ShowDialog();
                listBox1.Items.Add("Matrix B");
                listBox1.Items.Add("Row of B:" + matrixB.Matrix_Row);
                listBox1.Items.Add("Column of B:" + matrixB.Matrix_Colum);
                for (int i = 0; i < matrixB.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < matrixB.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + matrixB.Matrix[i, j];
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }

                this.Show();
            }
            else if (matrixB.Matrix_Row == 3 && matrixB.Matrix_Colum == 4)
            {
                this.Hide();
                Matrix_3_4 f = new Matrix_3_4();
                f.Savematrix = new Matrix_3_4.SaveData(LoadData12_);
                f.ShowDialog();
                listBox1.Items.Add("Matrix B");
                listBox1.Items.Add("Row of B:" + matrixB.Matrix_Row);
                listBox1.Items.Add("Column of B:" + matrixB.Matrix_Colum);
                for (int i = 0; i < matrixB.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < matrixB.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + matrixB.Matrix[i, j];
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }

                this.Show();
            }
            else if (matrixB.Matrix_Row == 4 && matrixB.Matrix_Colum == 1)
            {
                this.Hide();
                Matrix_4_1 f = new Matrix_4_1();
                f.Savematrix = new Matrix_4_1.SaveData(LoadData13_);
                f.ShowDialog();
                listBox1.Items.Add("Matrix B");
                listBox1.Items.Add("Row of B:" + matrixB.Matrix_Row);
                listBox1.Items.Add("Column of B:" + matrixB.Matrix_Colum);
                for (int i = 0; i < matrixB.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < matrixB.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + matrixB.Matrix[i, j];
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }

                this.Show();
            }
            else if (matrixB.Matrix_Row == 4 && matrixB.Matrix_Colum == 2)
            {
                this.Hide();
                Matrix_4_2 f = new Matrix_4_2();
                f.Savematrix = new Matrix_4_2.SaveData(LoadData14_);
                f.ShowDialog();
                listBox1.Items.Add("Matrix B");
                listBox1.Items.Add("Row of B:" + matrixB.Matrix_Row);
                listBox1.Items.Add("Column of B:" + matrixB.Matrix_Colum);
                for (int i = 0; i < matrixB.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < matrixB.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + matrixB.Matrix[i, j];
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }

                this.Show();
            }
            else if (matrixB.Matrix_Row == 4 && matrixB.Matrix_Colum == 3)
            {
                this.Hide();
                Matrix_4_3 f = new Matrix_4_3();
                f.Savematrix = new Matrix_4_3.SaveData(LoadData15_);
                f.ShowDialog();
                listBox1.Items.Add("Matrix B");
                listBox1.Items.Add("Row of B:" + matrixB.Matrix_Row);
                listBox1.Items.Add("Column of B:" + matrixB.Matrix_Colum);
                for (int i = 0; i < matrixB.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < matrixB.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + matrixB.Matrix[i, j];
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }

                this.Show();
            }
            else if (matrixB.Matrix_Row == 4 && matrixB.Matrix_Colum == 4)
            {
                this.Hide();
                Matrix_4_4 f = new Matrix_4_4();
                f.Savematrix = new Matrix_4_4.SaveData(LoadData16_);
                f.ShowDialog();
                listBox1.Items.Add("Matrix B");
                listBox1.Items.Add("Row of B:" + matrixB.Matrix_Row);
                listBox1.Items.Add("Column of B:" + matrixB.Matrix_Colum);
                for (int i = 0; i < matrixB.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < matrixB.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + matrixB.Matrix[i, j];
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }

                this.Show();
            }
        }
        // 1 Row
        public void LoadData1_(double data1)
        {
            matrixB.Matrix[0, 0] = data1;
        }
        private void LoadData2_(double data1, double data2)
        {
            matrixB.Matrix[0, 0] = data1;
            matrixB.Matrix[0, 1] = data2;
        }
        private void LoadData3_(double data1, double data2, double data3)
        {
            matrixB.Matrix[0, 0] = data1;
            matrixB.Matrix[0, 1] = data2;
            matrixB.Matrix[0, 2] = data3;
        }
        private void LoadData4_(double data1, double data2, double data3, double data4)
        {
            matrixB.Matrix[0, 0] = data1;
            matrixB.Matrix[0, 1] = data2;
            matrixB.Matrix[0, 2] = data3;
            matrixB.Matrix[0, 3] = data4;
        }

        // 2 Row
        private void LoadData5_(double dt1, double dt2)
        {
            matrixB.Matrix[0, 0] = dt1;
            matrixB.Matrix[1, 0] = dt2;
        }
        private void LoadData6_(double dt1, double dt2, double dt3, double dt4)
        {
            matrixB.Matrix[0, 0] = dt1;
            matrixB.Matrix[0, 1] = dt2;
            matrixB.Matrix[1, 0] = dt3;
            matrixB.Matrix[1, 1] = dt4;
        }
        private void LoadData7_(double dt1, double dt2, double dt3, double dt4, double dt5, double dt6)
        {
            matrixB.Matrix[0, 0] = dt1;
            matrixB.Matrix[0, 1] = dt2;
            matrixB.Matrix[0, 2] = dt3;
            matrixB.Matrix[1, 0] = dt4;
            matrixB.Matrix[1, 1] = dt5;
            matrixB.Matrix[1, 2] = dt6;

        }
        private void LoadData8_(double dt1, double dt2, double dt3, double dt4, double dt5, double dt6, double dt7, double dt8)
        {
            matrixB.Matrix[0, 0] = dt1;
            matrixB.Matrix[0, 1] = dt2;
            matrixB.Matrix[0, 2] = dt3;
            matrixB.Matrix[0, 3] = dt4;
            matrixB.Matrix[1, 0] = dt5;
            matrixB.Matrix[1, 1] = dt6;
            matrixB.Matrix[1, 2] = dt7;
            matrixB.Matrix[1, 3] = dt8;

        }
        //3 Row
        private void LoadData9_(double dt1, double dt2, double dt3)
        {
            matrixB.Matrix[0, 0] = dt1;
            matrixB.Matrix[1, 0] = dt2;
            matrixB.Matrix[2, 0] = dt3;
        }
        private void LoadData10_(double dt1, double dt2, double dt3, double dt4, double dt5, double dt6)
        {
            matrixB.Matrix[0, 0] = dt1;
            matrixB.Matrix[0, 1] = dt2;
            matrixB.Matrix[1, 0] = dt3;
            matrixB.Matrix[1, 1] = dt4;
            matrixB.Matrix[2, 0] = dt5;
            matrixB.Matrix[2, 1] = dt6;
        }
        private void LoadData11_(double dt1, double dt2, double dt3, double dt4, double dt5, double dt6, double dt7, double dt8, double dt9)
        {
            matrixB.Matrix[0, 0] = dt1;
            matrixB.Matrix[0, 1] = dt2;
            matrixB.Matrix[0, 2] = dt3;
            matrixB.Matrix[1, 0] = dt4;
            matrixB.Matrix[1, 1] = dt5;
            matrixB.Matrix[1, 2] = dt6;
            matrixB.Matrix[2, 0] = dt7;
            matrixB.Matrix[2, 1] = dt8;
            matrixB.Matrix[2, 2] = dt9;
        }
        private void LoadData12_(double dt1, double dt2, double dt3, double dt4, double dt5, double dt6, double dt7, double dt8, double dt9, double dt10, double dt11, double dt12)
        {
            matrixB.Matrix[0, 0] = dt1;
            matrixB.Matrix[0, 1] = dt2;
            matrixB.Matrix[0, 2] = dt3;
            matrixB.Matrix[0, 3] = dt4;
            matrixB.Matrix[1, 0] = dt5;
            matrixB.Matrix[1, 1] = dt6;
            matrixB.Matrix[1, 2] = dt7;
            matrixB.Matrix[1, 3] = dt8;
            matrixB.Matrix[2, 0] = dt9;
            matrixB.Matrix[2, 1] = dt10;
            matrixB.Matrix[2, 2] = dt11;
            matrixB.Matrix[2, 3] = dt12;
        }
        // 4Row
        private void LoadData13_(double dt1, double dt2, double dt3, double dt4)
        {
            matrixB.Matrix[0, 0] = dt1;
            matrixB.Matrix[1, 0] = dt2;
            matrixB.Matrix[2, 0] = dt3;
            matrixB.Matrix[3, 0] = dt4;
        }
        private void LoadData14_(double dt1, double dt2, double dt3, double dt4, double dt5, double dt6, double dt7, double dt8)
        {
            matrixB.Matrix[0, 0] = dt1;
            matrixB.Matrix[0, 1] = dt2;
            matrixB.Matrix[1, 0] = dt3;
            matrixB.Matrix[1, 1] = dt4;
            matrixB.Matrix[2, 0] = dt5;
            matrixB.Matrix[2, 1] = dt6;
            matrixB.Matrix[3, 0] = dt7;
            matrixB.Matrix[3, 1] = dt8;
        }
        private void LoadData15_(double dt1, double dt2, double dt3, double dt4, double dt5, double dt6, double dt7, double dt8, double dt9, double dt10, double dt11, double dt12)
        {
            matrixB.Matrix[0, 0] = dt1;
            matrixB.Matrix[0, 1] = dt2;
            matrixB.Matrix[0, 2] = dt3;
            matrixB.Matrix[1, 0] = dt4;
            matrixB.Matrix[1, 1] = dt5;
            matrixB.Matrix[1, 2] = dt6;
            matrixB.Matrix[2, 0] = dt7;
            matrixB.Matrix[2, 1] = dt8;
            matrixB.Matrix[2, 2] = dt9;
            matrixB.Matrix[3, 0] = dt10;
            matrixB.Matrix[3, 1] = dt11;
            matrixB.Matrix[3, 2] = dt12;
        }
        private void LoadData16_(double dt1, double dt2, double dt3, double dt4, double dt5, double dt6, double dt7, double dt8, double dt9, double dt10, double dt11, double dt12, double dt13, double dt14, double dt15, double dt16)
        {
            matrixB.Matrix[0, 0] = dt1;
            matrixB.Matrix[0, 1] = dt2;
            matrixB.Matrix[0, 2] = dt3;
            matrixB.Matrix[0, 3] = dt4;
            matrixB.Matrix[1, 0] = dt5;
            matrixB.Matrix[1, 1] = dt6;
            matrixB.Matrix[1, 2] = dt7;
            matrixB.Matrix[1, 3] = dt8;
            matrixB.Matrix[2, 0] = dt9;
            matrixB.Matrix[2, 1] = dt10;
            matrixB.Matrix[2, 2] = dt11;
            matrixB.Matrix[2, 3] = dt12;
            matrixB.Matrix[3, 0] = dt13;
            matrixB.Matrix[3, 1] = dt14;
            matrixB.Matrix[3, 2] = dt15;
            matrixB.Matrix[3, 3] = dt16;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Mathematics_Matrix.Mathematics_MatricSquare(matrixA.Matrix_Row, matrixA.Matrix_Colum))
                {
                    MessageBox.Show(" matrix A has no determinant! ");
                }
                else
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add("det(A)=" + Mathematics_Matrix.Mathematics_MatrixDeterminant(matrixA.Matrix, matrixA.Matrix_Row));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            
            matrixA=new Mathematics_Matrix();
            matrixB=new Mathematics_Matrix();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Mathematics_Matrix.Mathematics_MatricSquare(matrixB.Matrix_Row, matrixB.Matrix_Colum))
                {
                    MessageBox.Show(" matrix B has no determinant! ");
                }
                else
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add("det(B)=" + Mathematics_Matrix.Mathematics_MatrixDeterminant(matrixB.Matrix, matrixB.Matrix_Row));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for(int i=0;i<matrixA.Matrix_Row;i++)
            {
                for(int j=0;j<matrixA.Matrix_Colum;j++) 
                {
                    matrixA.Matrix[i, j] = matrixA.Matrix[i,j]*double.Parse(txtlamda.Text);
                }
            }
            listBox1.Items.Clear();
            listBox1.Items.Add("Matrix A");
            listBox1.Items.Add("Row of A:" + matrixA.Matrix_Row);
            listBox1.Items.Add("Column of A:" + matrixA.Matrix_Colum);
            for (int i = 0; i < matrixA.Matrix_Row; i++)
            {
                string s = "";
                for (int j = 0; j < matrixA.Matrix_Colum; j++)
                {
                    s += " Matrix[" + i + "," + j + "] =" + matrixA.Matrix[i, j];
                }
                listBox1.Items.Add(s);
                listBox1.Items.Add("");
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < matrixB.Matrix_Row; i++)
            {
                for (int j = 0; j < matrixB.Matrix_Colum; j++)
                {
                    matrixB.Matrix[i, j] = matrixB.Matrix[i, j] * double.Parse(txtlamda.Text);
                }
            }
            listBox1.Items.Clear();
            listBox1.Items.Add("Matrix B");
            listBox1.Items.Add("Row of B:" + matrixB.Matrix_Row);
            listBox1.Items.Add("Column of B:" + matrixB.Matrix_Colum);
            for (int i = 0; i < matrixB.Matrix_Row; i++)
            {
                string s = "";
                for (int j = 0; j < matrixB.Matrix_Colum; j++)
                {
                    s += " Matrix[" + i + "," + j + "] =" + matrixB.Matrix[i, j];
                }
                listBox1.Items.Add(s);
                listBox1.Items.Add("");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Mathematics_Matrix temp = matrixA;
            listBox1.Items.Add("Rank(A) = " + Mathematics_Matrix.Rank(matrixA.Matrix, matrixA.Matrix_Row));
            matrixA=temp;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Mathematics_Matrix temp=matrixB;
            listBox1.Items.Add("Rank(B) = " + Mathematics_Matrix.Rank(matrixB.Matrix, matrixB.Matrix_Row));
            matrixB=temp;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Mathematics_Matrix.Mathematics_MatricSquare(matrixA.Matrix_Row, matrixA.Matrix_Colum))
            {
                Mathematics_Matrix res = Mathematics_Matrix.Mathematics_MatrixInverse(matrixA);
                listBox1.Items.Clear();
                listBox1.Items.Add("Matrix A");
                listBox1.Items.Add("Row of A:" + matrixA.Matrix_Row);
                listBox1.Items.Add("Column of A:" + matrixA.Matrix_Colum);
                for (int i = 0; i < matrixA.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < matrixA.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + matrixA.Matrix[i, j];
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }
                listBox1.Items.Add("Inverse of A:");
                for (int i = 0; i < res.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < res.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + res.Matrix[i, j];
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }
            }
            else
            {
                MessageBox.Show("Matrix A must be square !!!!");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Mathematics_Matrix.Mathematics_MatricSquare(matrixB.Matrix_Row, matrixB.Matrix_Colum))
            {
                Mathematics_Matrix res = Mathematics_Matrix.Mathematics_MatrixInverse(matrixB);
                listBox1.Items.Clear();
                listBox1.Items.Add("Matrix B");
                listBox1.Items.Add("Row of B:" + matrixB.Matrix_Row);
                listBox1.Items.Add("Column of B:" + matrixB.Matrix_Colum);
                for (int i = 0; i < matrixB.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < matrixB.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + matrixB.Matrix[i, j];
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }
                listBox1.Items.Add("Inverse of B:");
                for (int i = 0; i < res.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < res.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + res.Matrix[i, j];
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }
            }
            else
            {
                MessageBox.Show("Matrix must be square !!!!");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Mathematics_Matrix.Mathematics_MatricSquare(matrixA.Matrix_Row,matrixA.Matrix_Colum))
            {
                Mathematics_Matrix res = Mathematics_Matrix.Mathematics_MatrixAdjoint(matrixA);
                listBox1.Items.Clear();
                listBox1.Items.Add("Matrix A");
                listBox1.Items.Add("Row of A: " + matrixA.Matrix_Row);
                listBox1.Items.Add("Column of A: " + matrixA.Matrix_Colum);
                for (int i = 0; i < matrixA.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < matrixA.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + matrixA.Matrix[i, j];
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }
                listBox1.Items.Add("Adjoint of A :");
                for (int i = 0; i < res.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < res.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + res.Matrix[i, j];
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }
            }
            else
            {
                MessageBox.Show(" Matrix A must be square !!!");
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (Mathematics_Matrix.Mathematics_MatricSquare(matrixB.Matrix_Row, matrixB.Matrix_Colum))
            {
                Mathematics_Matrix res = Mathematics_Matrix.Mathematics_MatrixAdjoint(matrixB);
                listBox1.Items.Clear();
                listBox1.Items.Add("Matrix B");
                listBox1.Items.Add("Row of B: " + matrixB.Matrix_Row);
                listBox1.Items.Add("Column of B: " + matrixB.Matrix_Colum);
                for (int i = 0; i < matrixB.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < matrixB.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + matrixB.Matrix[i, j];
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }
                listBox1.Items.Add("Adjoint of B :");
                for (int i = 0; i < res.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < res.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + res.Matrix[i, j];
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }
            }
            else
            {
                MessageBox.Show("Matrix B must be square!!");
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Mathematics_Matrix res = Mathematics_Matrix.Mathematics_Matrix_Transpose(matrixA);
            listBox1.Items.Clear();
            listBox1.Items.Add("Matrix A");
            listBox1.Items.Add("Row of A: " + matrixA.Matrix_Row);
            listBox1.Items.Add("Column of A: " + matrixA.Matrix_Colum);
            for (int i = 0; i < matrixA.Matrix_Row; i++)
            {
                string s = "";
                for (int j = 0; j < matrixA.Matrix_Colum; j++)
                {
                    s += " Matrix[" + i + "," + j + "] =" + matrixA.Matrix[i, j];
                }
                listBox1.Items.Add(s);
                listBox1.Items.Add("");
            }

            listBox1.Items.Add("Transpose of A :");
            for (int i = 0; i < res.Matrix_Row; i++)
            {
                string s = "";
                for (int j = 0; j < res.Matrix_Colum; j++)
                {
                    s += " Matrix[" + i + "," + j + "] =" + res.Matrix[i, j];
                }
                listBox1.Items.Add(s);
                listBox1.Items.Add("");
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Mathematics_Matrix res = Mathematics_Matrix.Mathematics_Matrix_Transpose(matrixB);
            listBox1.Items.Clear();
            listBox1.Items.Add("Matrix B");
            listBox1.Items.Add("Row of B: " + matrixB.Matrix_Row);
            listBox1.Items.Add("Column of B: " + matrixB.Matrix_Colum);
            for (int i = 0; i < matrixB.Matrix_Row; i++)
            {
                string s = "";
                for (int j = 0; j < matrixB.Matrix_Colum; j++)
                {
                    s += " Matrix[" + i + "," + j + "] =" + matrixB.Matrix[i, j];
                }
                listBox1.Items.Add(s);
                listBox1.Items.Add("");
            }

            listBox1.Items.Add("Transpose of B :");
            for (int i = 0; i < res.Matrix_Row; i++)
            {
                string s = "";
                for (int j = 0; j < res.Matrix_Colum; j++)
                {
                    s += " Matrix[" + i + "," + j + "] =" + res.Matrix[i, j];
                }
                listBox1.Items.Add(s);
                listBox1.Items.Add("");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if(matrixA==matrixB)
            {
                listBox1.Items.Clear();
                Mathematics_Matrix res = matrixA + matrixB;
                listBox1.Items.Add(" Matrix A:");
                for (int i = 0; i < matrixA.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < matrixA.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + matrixA.Matrix[i, j];
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }
                listBox1.Items.Add("       (+)       ");
                listBox1.Items.Add("");
                listBox1.Items.Add("Matrix B: ");
                for (int i = 0; i < matrixB.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < matrixB.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + matrixB.Matrix[i, j];
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }
                listBox1.Items.Add(" Result: ");
                for (int i = 0; i < res.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < res.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + res.Matrix[i, j];
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }
            }
            else
            {
                MessageBox.Show(" matrix A can not add to matrix B!!!");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (matrixA == matrixB)
            {
                listBox1.Items.Clear();
                Mathematics_Matrix res = matrixA - matrixB;
                listBox1.Items.Add(" Matrix A:");
                for (int i = 0; i < matrixA.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < matrixA.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + matrixA.Matrix[i, j];
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }
                listBox1.Items.Add("       (-)       ");
                listBox1.Items.Add("");
                listBox1.Items.Add("Matrix B: ");
                for (int i = 0; i < matrixB.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < matrixB.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + matrixB.Matrix[i, j];
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }
                listBox1.Items.Add(" Result: ");
                for (int i = 0; i < res.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < res.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + res.Matrix[i, j];
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }
            }
            else
            {
                MessageBox.Show(" matrix A can not substract to matrix B!!!");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (matrixA == matrixB)
            {
                listBox1.Items.Clear();
                Mathematics_Matrix res = matrixB - matrixA;
                listBox1.Items.Add("Matrix B: ");
                for (int i = 0; i < matrixB.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < matrixB.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + matrixB.Matrix[i, j];
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }
                listBox1.Items.Add("       (-)       ");
                listBox1.Items.Add("");
                listBox1.Items.Add(" Matrix A:");
                for (int i = 0; i < matrixA.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < matrixA.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + matrixA.Matrix[i, j];
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }
                listBox1.Items.Add(" Result: ");
                for (int i = 0; i < res.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < res.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + res.Matrix[i, j];
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }
            }
            else
            {
                MessageBox.Show(" matrix B can not substract to matrix A!!!");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (Mathematics_Matrix.Mathematics_MatrixBooleanMultiple(matrixA.Matrix_Colum,matrixB.Matrix_Row))
            {
                listBox1.Items.Clear();
                Mathematics_Matrix res = matrixA * matrixB;
                listBox1.Items.Add(" Matrix A:");
                for (int i = 0; i < matrixA.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < matrixA.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + matrixA.Matrix[i, j];
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }
                listBox1.Items.Add("       (*)       ");
                listBox1.Items.Add("");
                listBox1.Items.Add("Matrix B: ");
                for (int i = 0; i < matrixB.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < matrixB.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + matrixB.Matrix[i, j];
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }
                listBox1.Items.Add(" Result: ");
                for (int i = 0; i < res.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < res.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + res.Matrix[i, j];
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }
            }
            else
            {
                MessageBox.Show(" A can not Multiple to B !!!!");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (Mathematics_Matrix.Mathematics_MatrixBooleanMultiple(matrixB.Matrix_Colum, matrixA.Matrix_Row))
            {
                listBox1.Items.Clear();
                Mathematics_Matrix res = matrixB * matrixA;
                listBox1.Items.Add("Matrix B: ");
                for (int i = 0; i < matrixB.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < matrixB.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + matrixB.Matrix[i, j];
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }
                listBox1.Items.Add("       (*)       ");
                listBox1.Items.Add("");
                listBox1.Items.Add(" Matrix A:");
                for (int i = 0; i < matrixA.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < matrixA.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + matrixA.Matrix[i, j];
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }
                listBox1.Items.Add(" Result: ");
                for (int i = 0; i < res.Matrix_Row; i++)
                {
                    string s = "";
                    for (int j = 0; j < res.Matrix_Colum; j++)
                    {
                        s += " Matrix[" + i + "," + j + "] =" + res.Matrix[i, j];
                    }
                    listBox1.Items.Add(s);
                    listBox1.Items.Add("");
                }
            }
            else
            {
                MessageBox.Show(" A can not Multiple to B !!!!");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (Mathematics_Matrix.Mathematics_MatricSquare(matrixB.Matrix_Row, matrixB.Matrix_Colum))
            {
                if(Mathematics_Matrix.Mathematics_MatrixBooleanMultiple(matrixB.Matrix_Colum,matrixA.Matrix_Row))
                {
                    Mathematics_Matrix res = matrixA / matrixB;
                    listBox1.Items.Add("Matrix A: ");
                    for (int i = 0; i < matrixA.Matrix_Row; i++)
                    {
                        string s = "";
                        for (int j = 0; j < matrixA.Matrix_Colum; j++)
                        {
                            s += " Matrix[" + i + "," + j + "] =" + matrixA.Matrix[i, j];
                        }
                        listBox1.Items.Add(s);
                        listBox1.Items.Add("");
                    }
                    listBox1.Items.Add("       (/)       ");
                    listBox1.Items.Add("");
                    listBox1.Items.Add("Matrix B: ");
                    for (int i = 0; i < matrixB.Matrix_Row; i++)
                    {
                        string s = "";
                        for (int j = 0; j < matrixB.Matrix_Colum; j++)
                        {
                            s += " Matrix[" + i + "," + j + "] =" + matrixB.Matrix[i, j];
                        }
                        listBox1.Items.Add(s);
                        listBox1.Items.Add("");
                    }
                    listBox1.Items.Add(" Result: ");
                    for (int i = 0; i < res.Matrix_Row; i++)
                    {
                        string s = "";
                        for (int j = 0; j < res.Matrix_Colum; j++)
                        {
                            s += " Matrix[" + i + "," + j + "] =" + res.Matrix[i, j];
                        }
                        listBox1.Items.Add(s);
                        listBox1.Items.Add("");
                    }
                }
                else
                {
                    MessageBox.Show(" Inverse of matrix B can not product to matrix A!!!!");
                }
            }
            else
            {
                MessageBox.Show("Matrix B must be square!!!");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (Mathematics_Matrix.Mathematics_MatricSquare(matrixA.Matrix_Row, matrixA.Matrix_Colum))
            {
                if (Mathematics_Matrix.Mathematics_MatrixBooleanMultiple(matrixA.Matrix_Colum, matrixB.Matrix_Row))
                {
                    Mathematics_Matrix res = matrixB / matrixA;

                    listBox1.Items.Add("Matrix B: ");
                    for (int i = 0; i < matrixB.Matrix_Row; i++)
                    {
                        string s = "";
                        for (int j = 0; j < matrixB.Matrix_Colum; j++)
                        {
                            s += " Matrix[" + i + "," + j + "] =" + matrixB.Matrix[i, j];
                        }
                        listBox1.Items.Add(s);
                        listBox1.Items.Add("");
                    }
                    listBox1.Items.Add("       (/)       ");
                    listBox1.Items.Add("");
                    listBox1.Items.Add("Matrix A: ");
                    for (int i = 0; i < matrixA.Matrix_Row; i++)
                    {
                        string s = "";
                        for (int j = 0; j < matrixA.Matrix_Colum; j++)
                        {
                            s += " Matrix[" + i + "," + j + "] =" + matrixA.Matrix[i, j];
                        }
                        listBox1.Items.Add(s);
                        listBox1.Items.Add("");
                    }
                    listBox1.Items.Add(" Result: ");
                    for (int i = 0; i < res.Matrix_Row; i++)
                    {
                        string s = "";
                        for (int j = 0; j < res.Matrix_Colum; j++)
                        {
                            s += " Matrix[" + i + "," + j + "] =" + res.Matrix[i, j];
                        }
                        listBox1.Items.Add(s);
                        listBox1.Items.Add("");
                    }
                }
                else
                {
                    MessageBox.Show(" Inverse of matrix B can not product to matrix A!!!!");
                }
            }
            else
            {
                MessageBox.Show("Matrix B must be square!!!");
            }
        }
    }
}
