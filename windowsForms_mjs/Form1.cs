using System;
using System.Collections.Generic;
using System.Collections;
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
        // 폼간 데이터 전송을 위한 변수 선언
        Form2 child;

        public Form1()
        {
            InitializeComponent();

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 예외처리 파일을 안 넣었을 경우 파일을 넣으라는 경고창 생성
            if (fullPathName1 == null)
            {
                MessageBox.Show("파일을 넣어주세요");
            }
            else
            {
                // 버튼이 눌리면 필요한 모든 초기 변수 선언
                // ctrl+k+c
                Parsing_class a = new Parsing_class();
                ArrayList logData = new ArrayList();
                ArrayList parsing_logData = new ArrayList();
                ArrayList Date_parsing = new ArrayList();
                logData = a.fileRead(fullPathName1);
                parsing_logData = a.commitParsing(logData);
                //Analysis_Class b = new Analysis_Class();
                //Date_parsing = b.Data_conversion(parsing_logData);
                //b.project_date(Date_parsing);
                //b.project_analysis(Date_parsing);

                // 분석시작 버튼 누르면 분석에 관한 패널 뜸 
                tabPage1.Visible = false;
                tabPage2.Visible = false;
                tabControl1.Visible = false;
                panel1.Visible = true;
                button_bmp_save.Visible = true;
                button_excel_save.Visible = true;

                //값 넣기
                dataGridView1.ColumnCount = 5;
                dataGridView1.Columns[0].Name = "Insertion";
                dataGridView1.Columns[1].Name = "Deletion";
                dataGridView1.Columns[2].Name = "날짜";
                dataGridView1.Columns[3].Name = "개발자 이름";
                dataGridView1.Columns[4].Name = "email";
                // dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader); 
                for (int i = 0; i < parsing_logData.Count / 5; i++)
                {
                    string[] rows = { parsing_logData[5 * i].ToString(), parsing_logData[5 * i + 1].ToString(), parsing_logData[5 * i + 2].ToString(), parsing_logData[5 * i + 3].ToString(), parsing_logData[5 * i + 4].ToString() };
                    dataGridView1.Rows.Add(rows);
                }

                dataGridView1.Columns[0].DisplayIndex = 3;
                dataGridView1.Columns[1].DisplayIndex = 4;
                dataGridView1.Columns[2].DisplayIndex = 2;
                dataGridView1.Columns[3].DisplayIndex = 0;
                dataGridView1.Columns[4].DisplayIndex = 1;

                // dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader); 
                for (int i = 0; i < parsing_logData.Count / 5; i++)
                {
                    string[] rows = { parsing_logData[5 * i].ToString(), parsing_logData[5 * i + 1].ToString(), parsing_logData[5 * i + 2].ToString(), parsing_logData[5 * i + 3].ToString(), parsing_logData[5 * i + 4].ToString() };
                    dataGridView1.Rows.Add(rows);
                }

                dataGridView1.Columns[0].DisplayIndex = 3;
                dataGridView1.Columns[1].DisplayIndex = 4;
                dataGridView1.Columns[2].DisplayIndex = 2;
                dataGridView1.Columns[3].DisplayIndex = 0;
                dataGridView1.Columns[4].DisplayIndex = 1;
            }
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

        static string fullPathName1 = null;
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //파일 경로 텍스트박스에 찍어주기

            OpenFileDialog D1 = openFileDialog1;

            fullPathName1 = D1.FileName;
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            // 분석시작 버튼 누르면 분석에 관한 패널 뜸 
            tabPage1.Visible = false;
            tabPage2.Visible = false;
            tabControl1.Visible = false;
            panel1.Visible = true;
            button_bmp_save.Visible = true;
            button_excel_save.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button_bmp_save_Click(object sender, EventArgs e)
        {
            // png 파일로 저장
            Size sz = new Size(this.Bounds.Width, this.Bounds.Height);
            FromCapture(sz, "test.bmp");
            MessageBox.Show("bmp파일로 저장완료");
        }
        public void FromCapture(Size uFromSize, String uFileName)
        {
            Bitmap bitmap = new Bitmap(uFromSize.Width, uFromSize.Height);
            Graphics g = Graphics.FromImage(bitmap);
            g.CopyFromScreen(new Point(this.Bounds.X, this.Bounds.Y), new Point(0, 0), uFromSize);
            bitmap.Save(uFileName, System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private void button_graph_Click(object sender, EventArgs e)
        {
            //form1이 로드될 때 자식 폼 form2 생성
            child = new Form2();
            // 자식 폼의 모든 데이터 세팅 
            string[] seriesArray = { "Cats", "Dogs" };
            int[] pointsArray = { 1, 2 };
            //child.chart1.Titles.Add("hi");

            for (int i = 0; i < seriesArray.Length; i++)
            {
                // Add series.
                //Series series = child.chart1.Series.Add(seriesArray[i]);

                // Add point.
                // series.Points.Add(pointsArray[i]);
            }

            //그래프 보기 버튼을 누르면 새로운 폼 생성
            child.ShowDialog();

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            // 다시 처음 화면으로 돌리기 위해
            tabPage1.Visible = true;
            tabPage2.Visible = true;
            tabControl1.Visible = true;
            panel1.Visible = false;
            button_bmp_save.Visible = false;
            button_excel_save.Visible = false;
            // 불러온 파일 초기화 & datagridview reset
            this.dataGridView1.Rows.Clear();
            textBoxSFile.Text = null;
        }

        private void button_excel_save_Click(object sender, EventArgs e)
        {
            MessageBox.Show("엑셀파일로 저장완료");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

            //
        }
    }
}
//parsing class
class Parsing_class
{
    static int totalCommitValue = 0;
    public ArrayList fileRead(string filename)
    {
        /*
         * 2014-11-19 권상희
         * 로그 파일이 시간 역순으로 배치되어 있으므로, 개발초기부터 로그를 배치하여 읽도록 2개의 Arraylist를 이용하였습니다.
         * string line : file을 line당 읽어서 이용하기 위한 String Type 변수
        */
        ArrayList temp_logTotalData = new ArrayList();
        ArrayList logTotalData = new ArrayList();
        int counter = 0;
        string line;
        // Read the file and display it line by line.(파일 포인터)
        System.IO.StreamReader file = new System.IO.StreamReader(@filename);
        //new System.IO.StreamReader(@"C:\Users\내문서\Source\Repos\Log_Analizer\gitlog_parser\gitlog_parser\log_stat_WE.txt");
        // Text file로 부터 읽어서 프로그램 내장화
        while ((line = file.ReadLine()) != null)
        {
            //System.Console.WriteLine(line);
            temp_logTotalData.Add(line);
            counter++;
        }
        // Log text 역순 재정렬
        for (int i = temp_logTotalData.Count; i > 0; i--)
        {
            logTotalData.Add(temp_logTotalData[i - 1].ToString());
        }
        /*for (int i = 0; i < logTotalData.Count; i++)
        {
            System.Console.WriteLine(logTotalData[i].ToString());
        }*/
        file.Close();
        System.Console.WriteLine("There were {0} lines.", counter);
        // Suspend the screen.
        //System.Console.ReadLine();
        return logTotalData;
    }
    public ArrayList commitParsing(ArrayList logData)
    {
        /*
         * 2014-11-24 권상희
         * 0번 index : insertion,  1번 index : deletion, 3번 index : date 4번 index : e-mail 5번 index : author
         * index Number :0,1,2,3,4 순서 modula 5로 접근할 것
        */
        // totalCommitValue : Log의 최종 commit수 변수
        ArrayList tem_Parsing_Data = new ArrayList();
        ArrayList Parsing_Data = new ArrayList();
        string data = null;
        for (int i = 0; i < logData.Count; i++)
        {
            data = data + '%' + logData[i].ToString();
            if (logData[i].ToString().Contains("Author") == true)
            {
                //System.Console.WriteLine("data 값은\n"+data);
                tem_Parsing_Data.Add(data);
                data = null;
                i++;
            }
        }
        System.Console.WriteLine("count : " + tem_Parsing_Data.Count + "\n");
        totalCommitValue = tem_Parsing_Data.Count;
        // 검증
        /*for (int j = 0; j < tem_Parsing_Data.Count; j++)
        {
            System.Console.WriteLine(tem_Parsing_Data[j].ToString());
        }*/
        for (int i = 0; i < tem_Parsing_Data.Count; i++)
        {
            data = tem_Parsing_Data[i].ToString();
            // 1번째,2번째 (삽입,삭제) 입력
            if (data.Contains("changed,") == true)
            {
                if (data.Contains("(+") == true)
                {
                    string[] cut_str = data.Split(new string[] { ",", "insert", "dele" }, StringSplitOptions.RemoveEmptyEntries);
                    cut_str[1] = cut_str[1].Trim();
                    Parsing_Data.Add(cut_str[1]);
                    if (cut_str.Length > 4)
                    {
                        if (cut_str[4].Contains("(-") == true)
                        {
                            cut_str[3] = cut_str[3].Trim();
                            Parsing_Data.Add(cut_str[3]);
                        }
                    }
                    else
                    {
                        Parsing_Data.Add("0");
                    }
                }
                else
                {
                    Parsing_Data.Add("0");
                    if (data.Contains("(-)") == true)
                    {
                        string[] cut_str = data.Split(new string[] { ",", "deletion" }, StringSplitOptions.RemoveEmptyEntries);
                        cut_str[1] = cut_str[1].Trim();
                        Parsing_Data.Add(cut_str[1]);
                    }
                    else
                    {
                        Parsing_Data.Add("0");
                    }
                }
            }
            else
            {
                Parsing_Data.Add("0");
                Parsing_Data.Add("0");
            }
            if (data.Contains("Date:") == true)
            {
                string[] cut_str = data.Split(new string[] { "Date:", "Author:" }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < cut_str.Length; j++)
                {
                    cut_str[j] = cut_str[j].Trim();
                    //System.Console.WriteLine(j+"번째" + cut_str[j]);
                }
                // 3번째 Date(날짜) 입력
                if (cut_str[1].Contains(":") == true)
                    Parsing_Data.Add(cut_str[1]);
                string[] name_data = cut_str[2].Split(new char[] { '<', '>' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < name_data.Length; j++)
                {
                    name_data[j] = name_data[j].Trim();
                }
                // 4번째 Author(저자명) 입력
                Parsing_Data.Add(name_data[0]);
                // 5번째 e-mail 입력
                Parsing_Data.Add(name_data[1]);
            }
        }
        // total test 화면에 출력하며 검증
        //System.Console.WriteLine(Parsing_Data.Count);
        for (int j = 0; j < Parsing_Data.Count; j++)
        {
            //if (j % 5 == 2)
            {
                System.Console.WriteLine(Parsing_Data[j].ToString());
            }
        }
        // Parsing 된 Arraylist 전송
        return Parsing_Data;
    }
}
//Anlaysis class

