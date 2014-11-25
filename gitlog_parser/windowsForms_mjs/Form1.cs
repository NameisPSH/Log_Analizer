using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace windowsForms_mjs
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 분석시작 버튼 누르면 분석에 관한 패널 뜸 
            tabPage1.Visible = false;
            tabPage2.Visible = false;
            tabControl1.Visible = false;
            panel1.Visible = true; 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //파일 불러오기 창 띄우기

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName, Encoding.Default);

                while (sr.Peek() >= 0)
                {
                    string str = sr.ReadLine().ToString();
                    int i = str.Length - 1;

                    for (int j = 0; j <= str.Length - 1; j++)
                    {
                        if (i >= 0)
                        {
                            // 파일안의 글자 읽기
                            // textBoxSFile.Text += str.Substring(i, 1);
                            // i--;

                        }
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //파일 불러오기 창 띄우기

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName, Encoding.Default);

                while (sr.Peek() >= 0)
                {
                    string str = sr.ReadLine().ToString();
                    int i = str.Length - 1;

                    for (int j = 0; j <= str.Length - 1; j++)
                    {
                        if (i >= 0)
                        {
                            // 파일안의 글자 읽기
                            // textBoxSFile.Text += str.Substring(i, 1);
                            // i--;

                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //팀 수 선택 갯수에 따라 불러오기 셋팅 바꿔주기
            textBoxT1.Visible = false;
            textBoxT2.Visible = true;
            textBoxT3.Visible = true;
            textBoxT4.Visible = true;
            textBoxT5.Visible = false;
            buttonT1.Visible = false;
            buttonT2.Visible = true;
            buttonT3.Visible = true;
            buttonT4.Visible = true;
            buttonT5.Visible = false;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1T1_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //팀 수 선택 갯수에 따라 불러오기 셋팅 바꿔주기
            textBoxT1.Visible = false;
            textBoxT2.Visible = true;
            textBoxT3.Visible = false;
            textBoxT4.Visible = true;
            textBoxT5.Visible = false;
            buttonT1.Visible = false;
            buttonT2.Visible = true;
            buttonT3.Visible = false;
            buttonT4.Visible = true;
            buttonT5.Visible = false;
            
        }

        private void radioButtonT4_CheckedChanged(object sender, EventArgs e)
        {
            //팀 수 선택 갯수에 따라 불러오기 셋팅 바꿔주기
            textBoxT1.Visible = true;
            textBoxT2.Visible = true;
            textBoxT3.Visible = true;
            textBoxT4.Visible = true;
            textBoxT5.Visible = false;
            buttonT1.Visible = true;
            buttonT2.Visible = true;
            buttonT3.Visible = true;
            buttonT4.Visible = true;
            buttonT5.Visible = false;
        }

        private void radioButtonT5_CheckedChanged(object sender, EventArgs e)
        {
            //팀 수 선택 갯수에 따라 불러오기 셋팅 바꿔주기
            textBoxT1.Visible = true;
            textBoxT2.Visible = true;
            textBoxT3.Visible = true;
            textBoxT4.Visible = true;
            textBoxT5.Visible = true;
            buttonT1.Visible = true;
            buttonT2.Visible = true;
            buttonT3.Visible = true;
            buttonT4.Visible = true;
            buttonT5.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //파일 불러오기 창 띄우기

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName, Encoding.Default);

                while (sr.Peek() >= 0)
                {
                    string str = sr.ReadLine().ToString();
                    int i = str.Length - 1;

    
                    for (int j = 0; j <= str.Length - 1; j++)
                    {
                        if (i >= 0)
                        {
                            // 파일안의 글자 읽기
                            // textBoxSFile.Text += str.Substring(i, 1);
                            // i--;

                        }
                    }
                }
            }
        }
        /*
        //저장
         private string dir = Path.Combine(Application.StartupPath, "txtKor.txt");   //파일저장

        private void btnOK_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(String.Format("{0}",txt1.Text));
            StreamWriter sw = new StreamWriter(dir, false, Encoding.Default);
            sw.WriteLine(sb.ToString());
            sw.Close();
            sw.Dispose();
            MessageBox.Show("저장");
        }
        }
        */
        private void textBoxSFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog D1 = openFileDialog1;

            string fullPathName1 = D1.FileName;
            //string fileName = D1.SafeFileName;
            //string pathName = fullName.Substring(0, (fullPathName.Length - fileName.Length));

            textBoxSFile.Text = fullPathName1; // 전체경로
        }

        private void buttonT3_Click(object sender, EventArgs e)
        {
            //파일 불러오기 창 띄우기

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName, Encoding.Default);

                while (sr.Peek() >= 0)
                {
                    string str = sr.ReadLine().ToString();
                    int i = str.Length - 1;

                    for (int j = 0; j <= str.Length - 1; j++)
                    {
                        if (i >= 0)
                        {
                            // 파일안의 글자 읽기
                            // textBoxSFile.Text += str.Substring(i, 1);
                            // i--;

                        }
                    }
                }
            }
        }

        private void buttonT4_Click(object sender, EventArgs e)
        {
            //파일 불러오기 창 띄우기

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName, Encoding.Default);

                while (sr.Peek() >= 0)
                {
                    string str = sr.ReadLine().ToString();
                    int i = str.Length - 1;

                    for (int j = 0; j <= str.Length - 1; j++)
                    {
                        if (i >= 0)
                        {
                            // 파일안의 글자 읽기
                            // textBoxSFile.Text += str.Substring(i, 1);
                            // i--;

                        }
                    }
                }
            }
        }

        private void buttonT5_Click(object sender, EventArgs e)
        {
            //파일 불러오기 창 띄우기

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName, Encoding.Default);

                while (sr.Peek() >= 0)
                {
                    string str = sr.ReadLine().ToString();
                    int i = str.Length - 1;

                    for (int j = 0; j <= str.Length - 1; j++)
                    {
                        if (i >= 0)
                        {
                            // 파일안의 글자 읽기
                            // textBoxSFile.Text += str.Substring(i, 1);
                            // i--;

                        }
                    }
                }
            }
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog D2 = openFileDialog2;

            string fullPathName2 = D2.FileName;
            //string fileName = D2.SafeFileName;
            //string pathName = fullName.Substring(0, (fullPathName.Length - fileName.Length));

            textBoxT1.Text = fullPathName2; // 전체경로
        }

        private void textBoxT4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxT5_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog3_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog D3 = openFileDialog3;

            string fullPathName3 = D3.FileName;
            //string fileName = dlg.SafeFileName;
            //string pathName = fullName.Substring(0, (fullPathName.Length - fileName.Length));

            textBoxT2.Text = fullPathName3; // 전체경로
        }

        private void openFileDialog4_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog D4 = openFileDialog4;

            string fullPathName4 = D4.FileName;
            //string fileName = dlg.SafeFileName;
            //string pathName = fullName.Substring(0, (fullPathName.Length - fileName.Length));

            textBoxT3.Text = fullPathName4; // 전체경로
        }

        private void openFileDialog5_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog D5 = openFileDialog5;

            string fullPathName5 = D5.FileName;
            //string fileName5 = dlg.SafeFileName;
            //string pathName = fullName.Substring(0, (fullPathName.Length - fileName.Length));

            textBoxT4.Text = fullPathName5; // 전체경로
        }

        private void openFileDialog6_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog D6 = openFileDialog6;

            string fullPathName6 = D6.FileName;
            //string fileName = dlg.SafeFileName;
            //string pathName = fullName.Substring(0, (fullPathName.Length - fileName.Length));

            textBoxT5.Text = fullPathName6; // 전체경로
        }
            
    }
}
