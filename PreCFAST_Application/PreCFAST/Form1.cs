using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           


        }

        private void Work()
        {
            wr1();
            RunCFAST();
        }

        private string inFileName = "Platforma1.in";
        private void wr1()
        {
            string s;
            s = inFileName;

            try
            {
                /*
                string s;
                saveFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    saveFileDialog1.OpenFile();
 
                s = saveFileDialog1.FileName;
                */
                FileStream FS = new FileStream(s, FileMode.Create, FileAccess.Write);

                StreamWriter SW = new StreamWriter(FS);

                SW.WriteLine(maskedTextBox1.Text);
                SW.Close();
                FS.Close();
            }
            catch (EndOfStreamException Mes)
            {
                MessageBox.Show(Mes.Message + " " + Mes.InnerException + " " + Mes.Source);
            }
            catch (AccessViolationException Mes)
            {
                MessageBox.Show(Mes.Message + " " + Mes.InnerException + " " + Mes.Source);
            }
            catch (IOException Mes)
            {
                MessageBox.Show(Mes.Message + " " + Mes.InnerException + " " + Mes.Source);
            }

        }

        private void wr2()
        {
            string s;
            s = inFileName;

            try
            {
                /*
                string s;
                saveFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    saveFileDialog1.OpenFile();
 
                s = saveFileDialog1.FileName;
                */
                FileStream FS = new FileStream(s, FileMode.Append, FileAccess.Write);

                StreamWriter SW = new StreamWriter(FS);

                SW.WriteLine(maskedTextBox2.Text);
                SW.Close();
                FS.Close();
            }
            catch (EndOfStreamException Mes)
            {
                MessageBox.Show(Mes.Message + " " + Mes.InnerException + " " + Mes.Source);
            }
            catch (AccessViolationException Mes)
            {
                MessageBox.Show(Mes.Message + " " + Mes.InnerException + " " + Mes.Source);
            }
            catch (IOException Mes)
            {
                MessageBox.Show(Mes.Message + " " + Mes.InnerException + " " + Mes.Source);
            }

        }

        private void RunCFAST()
        {
	        string CommandString = null;
	        int found = 0;
	        int ProcessID = 0;
            string FileName;
            string result;
            string arguments;

            result = Path.GetFileNameWithoutExtension(inFileName);
            System.Diagnostics.Process MyProc = new System.Diagnostics.Process();
            FileName = @"CFAST.exe" + " " + result + " /i";
            arguments = " " + result + " /f";
            string fileName = "cfast.exe";
            ExecuteProgram( fileName,  arguments);
            
            arguments = "";
            fileName = "PostCFAST.exe";
            ExecuteProgram( fileName,  arguments);
            
            return;
            MyProc.StartInfo.FileName = FileName;
            MyProc.Start();
        }


        public static void ExecuteProgram(string fileName, string arguments)
        {
            Process prc = null;
            string output = string.Empty;

            try
            {
                // Устанавливаем параметры запуска процесса
                prc = new Process();
                prc.StartInfo.FileName = fileName;
                prc.StartInfo.Arguments = arguments;

                // Старт
                prc.Start();

                // Ждем пока процесс не завершится
                prc.WaitForExit();
            }
            finally
            {
                if (prc != null) prc.Close();
            }
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_G()
        {
            double W, L, H, S, FlowRate;
            W = Convert.ToDouble(textBox_W.Text);
            L = Convert.ToDouble(textBox_L.Text);
            H = Convert.ToDouble(textBox_H.Text);
            S = Convert.ToDouble(textBox_S.Text);
            FlowRate = Convert.ToDouble(tbFlowRate.Text);
            
            string text;

            wr1();


            string s;
            s = inFileName;
            FileStream FS = new FileStream(s, FileMode.Append, FileAccess.Write);
            StreamWriter SW = new StreamWriter(FS);

            text = @"COMPA,Platforma," + textBox_W.Text + "," + textBox_L.Text + "," + textBox_H.Text + "," + "0,0,0,CONCRETE,OFF,CONCRETE";
            //  COMPA,B_Platforma,12,150,4.8,0,0,0,CONCRETE,OFF,CONCRETE
            SW.WriteLine(text);


            text = @"MVENT,2,3,1,V,0," + textBox_S.Text + @",V,0," + textBox_S.Text + @"," + tbFlowRate.Text + ",200,300,1";
            //MVENT,2,3,1,V,0,123,V,0,123,345,200,300,1
            //VVENT,3,2,55,2,1
            SW.WriteLine(text);

            SW.Close();
            FS.Close();



            wr2();
            
        }

        private void btCalc_Click(object sender, EventArgs e)
        {

            Save_G();
            RunCFAST();
            //RunSMVGeometry();

        }

        private void btG_Click(object sender, EventArgs e)
        {

            string CommandString = null;
            int found = 0;
            int ProcessID = 0;
            string FileName;
            string result;
            string arguments;

            Save_G();
            RunSMVGeometry();

            result = Path.GetFileNameWithoutExtension(inFileName) + ".smv";
            //System.Diagnostics.Process MyProc = new System.Diagnostics.Process();
            //FileName = @"CFAST.exe" + " " + result + " /i";
            arguments = " " + result ;
            string fileName = "smokeview.exe";
            ExecuteProgram(fileName, arguments);
            return;
            arguments = "";
            fileName = "PostCFAST.exe";
            ExecuteProgram(fileName, arguments);

            return;
            //MyProc.StartInfo.FileName = FileName;
            //MyProc.Start();

        }

        private void RunSMVGeometry()
        {
            string CommandString = null;
            int found = 0;
            int ProcessID = 0;
            string FileName;
            string result;
            string arguments;

            result = Path.GetFileNameWithoutExtension(inFileName);
            System.Diagnostics.Process MyProc = new System.Diagnostics.Process();
            FileName = @"CFAST.exe" + " " + result + " /i";
            arguments = " " + result + " /i";
            string fileName = "cfast.exe";
            ExecuteProgram(fileName, arguments);

            return;
            arguments = "";
            fileName = "PostCFAST.exe";
            ExecuteProgram(fileName, arguments);

            return;
            MyProc.StartInfo.FileName = FileName;
            MyProc.Start();
            
        }

        private void textBox_W_TextChanged(object sender, EventArgs e)
        {

        }

    }
}


