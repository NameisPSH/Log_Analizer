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
        Form2 form2;
        // 어떤 값의 그래프를 보여줄 건지 구분하기 위한 변수
        public int graph_state = 0;
        // 마지막 변환 데이터 저장
        public ArrayList final_data = new ArrayList();

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
                Analysis_Class b = new Analysis_Class();
                Date_parsing = b.Data_conversion(parsing_logData);
                string returnvalue = b.project_date(Date_parsing);
                string[] cut_data = returnvalue.Split(new char[] { '|' });
                for (int k = 0; k < cut_data.Length; k++)
                    cut_data[k] = cut_data[k].Trim();
                // 진슬이가 label에 + 로 추가해야 되는 최종 개발 일정 3가지 시작날, 종료날, 진행기간
                string temp_start_date = cut_data[0];
                string temp_end_date = cut_data[1];
                string temp_total_date = cut_data[2];
                // 총개발일정 검증
                System.Console.WriteLine(returnvalue);
             
                final_data = b.project_analysis(Date_parsing);

                // 분석시작 버튼 누르면 분석에 관한 패널 뜸 
                tabPage1.Visible = false;
                tabPage2.Visible = false;
                tabControl1.Visible = false;
                panel1.Visible = true;
                button_bmp_save.Visible = true;
                button_excel_save.Visible = true;

                //값 넣기
                dataGridView1.ColumnCount = 10;
                dataGridView1.Columns[0].Name = "개발자 이름";
                dataGridView1.Columns[1].Name = "총 개발기간";
                dataGridView1.Columns[2].Name = "총 LoC 수";
                dataGridView1.Columns[3].Name = "성실도";
                dataGridView1.Columns[4].Name = "총 commit 수";
                dataGridView1.Columns[5].Name = "시작 일자";
                dataGridView1.Columns[6].Name = "종료 일자";
                dataGridView1.Columns[7].Name = "Insertion";
                dataGridView1.Columns[8].Name = "Deletion";
                dataGridView1.Columns[9].Name = "Email";

                // dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader); 
                for (int i = 0; i < final_data.Count / 10; i++)
                {
                    string[] rows = {final_data[10 * i].ToString(), final_data[10 * i + 1].ToString(), final_data[10 * i + 2].ToString(), final_data[10 * i + 3].ToString(), final_data[10 * i + 4].ToString(), final_data[10 * i + 5].ToString() ,
                                       final_data[10 * i + 6].ToString(), final_data[10 * i + 7].ToString(),final_data[10 * i + 8].ToString(),final_data[10 * i + 9].ToString()};
                    dataGridView1.Rows.Add(rows);
                }

                //dataGridView1.Columns[0].DisplayIndex = 3;
                //dataGridView1.Columns[1].DisplayIndex = 4;
                //dataGridView1.Columns[2].DisplayIndex = 2;
                //dataGridView1.Columns[3].DisplayIndex = 0;
                //dataGridView1.Columns[4].DisplayIndex = 1;
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
            FromCapture(sz,"test.bmp");
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
            form2 = new Form2();
            form2.Owner = this;
            // 값 배열 생성

            // Data에 접근하기 위해 필요한 모든 초기 변수 선언 
            //Parsing_class a = new Parsing_class();
           // ArrayList logData = new ArrayList();
           // ArrayList parsing_logData = new ArrayList();
           // ArrayList Date_parsing = new ArrayList();
           // logData = a.fileRead(fullPathName1);
           // parsing_logData = a.commitParsing(logData);

            for (int i = 0; i < final_data.Count / 10; i++)
            {
                //chart1 Series 객체 생성
                System.Windows.Forms.DataVisualization.Charting.Series seriesColumn =
                    new System.Windows.Forms.DataVisualization.Charting.Series();
                //chart2 Series 객체 생성
                System.Windows.Forms.DataVisualization.Charting.Series seriesLine =
                    new System.Windows.Forms.DataVisualization.Charting.Series();
                //chart3 Series 객체 생성
                System.Windows.Forms.DataVisualization.Charting.Series seriesPie =
                    new System.Windows.Forms.DataVisualization.Charting.Series();
          
                // chart type 설정
                seriesColumn.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                seriesLine.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                seriesPie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

                string[] stringValue = {final_data[10 * i].ToString(), final_data[10 * i + 1].ToString(), final_data[10 * i + 2].ToString(), final_data[10 * i + 3].ToString(), final_data[10 * i + 4].ToString(), final_data[10 * i + 5].ToString() ,
                                       final_data[10 * i + 6].ToString(), final_data[10 * i + 7].ToString(),final_data[10 * i + 8].ToString(),final_data[10 * i + 9].ToString()};
                
                //title 값 입력
                seriesColumn.Name = stringValue[0];
                seriesLine.Name = stringValue[0];
                seriesPie.Name = stringValue[0];
                
                // x축 값 이름으로 설정
                seriesColumn.AxisLabel = stringValue[0];
                seriesLine.AxisLabel = stringValue[0];
                seriesPie.AxisLabel = stringValue[0];

                // int값으로 바꿔서 그래프 출력
                // 0 : commit / 1 : Loc / 2 : 성실도
                if (graph_state == 0)
                {
                    seriesColumn.Points.Add(int.Parse(stringValue[0]));
                    seriesLine.Points.Add(int.Parse(stringValue[0]));
                    seriesPie.Points.Add(int.Parse(stringValue[0]));
                }
                else if (graph_state == 1)
                {
                    seriesColumn.Points.Add(int.Parse(stringValue[1]));
                    seriesLine.Points.Add(int.Parse(stringValue[1]));
                    seriesPie.Points.Add(int.Parse(stringValue[1]));
           
                }
                else if (graph_state == 2)
                {
                    seriesColumn.Points.Add(int.Parse(stringValue[0]));
                    seriesLine.Points.Add(int.Parse(stringValue[0]));
                    seriesPie.Points.Add(int.Parse(stringValue[0]));
           
                }
                form2.chart1.Series.Add(seriesColumn);
                form2.chart2.Series.Add(seriesLine);
                form2.chart3.Series.Add(seriesPie);
            }

            
            //그래프 보기 버튼을 누르면 새로운 폼 생성
            form2.ShowDialog();
             
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
            fullPathName1 = null;
        }

        private void button_excel_save_Click(object sender, EventArgs e)
        {
            MessageBox.Show("엑셀파일로 저장완료");
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
           // 0일 경우 commit 수 보여주기 
           graph_state = 0;
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            // 1일 경우 LoC 수 보여주기 
            graph_state = 1;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            // 2일 경우 성실도 보여주기 
            graph_state = 2;
        }
    }
        }
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
        System.IO.StreamReader file =
        new System.IO.StreamReader(@filename);
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
         * 0번 index : insertion, / 1번 index : deletion, / 2번 index : date / 3번 index : e-mail / 4번 index : author
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
        // 단위 테스트
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
                        else
                        {
                            Parsing_Data.Add("0");
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
        // total test 화면에 출력하며 단위 테스트
        //System.Console.WriteLine(Parsing_Data.Count);
        /* log가 길경우를 대비해서 write하여 값 debug를 위한 파일포인터 생성 및 검증
         * 
        System.IO.StreamWriter file = new System.IO.StreamWriter
(@"C:\Users\내문서\Source\Repos\Log_Analizer\gitlog_parser\gitlog_parser\log_bitcoin_analysis.txt");
        for (int j = 0; j < Parsing_Data.Count; j++)
        {
            if (j % 5 == 2)
            {
                System.Console.WriteLine(j+"번째" + Parsing_Data[j].ToString());
                string temp = j + "번째" + Parsing_Data[j].ToString();
                file.WriteLine(temp);
            }
        }
         */
        // Parsing 된 Arraylist 전송
        return Parsing_Data;
    }
}
class Analysis_Class
{
    public ArrayList Data_conversion(ArrayList Parsing_Data)
    {
        // 년, 월, 일로 덮어씌우고 return
        string[] month = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        string[] conversion_month = { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" };
        string total_month = null;
        string total_Date = null;
        string data = null;
        for (int j = 0; j < Parsing_Data.Count; j++)
        {
            if (j % 5 == 2)
            {
                data = Parsing_Data[j].ToString();
                string[] cut_str_month = data.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                //Date Parsing
                for (int i = 0; i < cut_str_month.Length; i++)
                    cut_str_month[i] = cut_str_month[i].Trim();
                //System.Console.WriteLine(cut_str_month[1]);
                for (int k = 0; k < month.Length; k++)
                {
                    if (cut_str_month[1].Equals(month[k]) == true)
                    {
                        total_month = conversion_month[k];
                    }
                }
                //System.Console.WriteLine("바꾸기 전:" + cut_str_month[1] + "바꾼 후" + total_month);
                total_Date = cut_str_month[4] + '-' + total_month + '-' + cut_str_month[2] + ' ' + cut_str_month[3];
                //System.Console.WriteLine("날짜:" + total_Date);
                Parsing_Data[j] = total_Date;
            }
        }
        // 검증
        //for (int i = 0; i < Parsing_Data.Count; i++)
        //    System.Console.WriteLine(Parsing_Data[i].ToString());
        return Parsing_Data;
    }
    //, Boolean flag 전체 프로젝트 기간과, 사람당 프로젝트 기간 정리
    public string project_date(ArrayList Date_parsing)
    {
        string temp_first_Date = Date_parsing[2].ToString();
        DateTime first_Date = DateTime.Parse(temp_first_Date);
        //System.Console.WriteLine("첫날" + first_Date);

        string temp_last_Date = Date_parsing[Date_parsing.Count - 3].ToString();
        DateTime last_Date = DateTime.Parse(temp_last_Date);
        //System.Console.WriteLine("마지막날" + last_Date);

        TimeSpan Calc_Date = last_Date.Subtract(first_Date);
        string total_calc_date = null;
        // 개발기간을 날만 출력한것
        int Result_Date = Calc_Date.Days;
        if (Calc_Date.ToString().Contains("."))
        {
            string[] str_calc_date = Calc_Date.ToString().Split(new char[] { '.' });
            for (int i = 0; i < str_calc_date.Length; i++)
                str_calc_date[i] = str_calc_date[i].Trim();
            // tota_calc_date : 총 개발기간을 보여주기 위한 변수
            total_calc_date = str_calc_date[0] + "일 " + str_calc_date[1];
        }
        else
        {
            total_calc_date = Calc_Date.ToString();
        }
        //System.Console.WriteLine("총 개발일수는 " + Calc_Date);
        //System.Console.WriteLine("값은 : "+Date_parsing[3]);
        string return_perDate = first_Date.ToString() + '|' + last_Date.ToString() + '|' + total_calc_date;
        return return_perDate;
    }
    // 사람당 개발기간을 계산하기 위한 함수
    public string per_pj_date(ArrayList logData, string name)
    {
        ArrayList tempData = logData;
        String tempName = name;         // 파싱한 데이터 리스트 전체와 이름을 새로운 변수에 저장해서 사용
        String firstCommit = null;
        String lastCommit = null;
        int indexOfLastCommit = 0;      // 마지막에 커밋한 때의 이름 인덱스를 저장함  

        for (int i = 0; i < tempData.Count; i++)
        {
            if (tempData[i].Equals(tempName))  // 루프중 해당 이름과 같은 이름을 찾았을 경우
            {
                if (firstCommit == null)           // 최초로 해당 이름을 찾음
                {
                    firstCommit = tempData[i - 1].ToString();   // 해당 위치 (이름 인덱스) - 1 인덱스(날짜) 값
                }
                indexOfLastCommit = i;      // 현재 인덱스를 마지막으로 커밋한 날짜의 인덱스 값을 가지는 변수에 저장
            }
        }
        lastCommit = tempData[indexOfLastCommit - 1].ToString();    // lastCommit에 저장

        DateTime first_Date = DateTime.Parse(firstCommit);
        DateTime last_Date = DateTime.Parse(lastCommit);
        TimeSpan Calc_Date = last_Date.Subtract(first_Date);
        string total_calc_date = null;
        // 개발기간을 날만 출력한것
        int Result_Date = Calc_Date.Days;
        if (Calc_Date.ToString().Contains("."))
        {
            string[] str_calc_date = Calc_Date.ToString().Split(new char[] { '.' });
            for (int i = 0; i < str_calc_date.Length; i++)
                str_calc_date[i] = str_calc_date[i].Trim();
            // tota_calc_date : 총 개발기간을 보여주기 위한 변수
            total_calc_date = str_calc_date[0] + "일 " + str_calc_date[1];
        }
        else
        {
            total_calc_date = Calc_Date.ToString();
        }
        //System.Console.WriteLine("총 개발일수는 " + Calc_Date);
        //System.Console.WriteLine("값은 : "+Date_parsing[3]);
        string return_perDate = first_Date.ToString() + '|' + last_Date.ToString() + '|' + total_calc_date;
        return return_perDate;
    }
    // 개인당 성실도를 계산하는 함수
    public int project_sincerity(ArrayList logData, string name)
    {
        ArrayList tempData = logData;
        string tempName = name;
        string tempDate = null;

        string[] cut_date = null;   // 날짜만 뽑아내서 저장
        string yesterday = null;
        int countingNumbersOfDay = 0;


        // 우선 해당 이름으로 커밋한 작업의 커밋 날짜를 뽑아내야함
        for (int i = 0; i < tempData.Count; i++)
        {
            if (tempData[i].Equals(tempName))      // 이름탐색
            {
                tempDate = tempData[i - 1].ToString();      // 날짜 추출
                cut_date = tempDate.Split(' ');
                // 날짜 출력 테스트
                //System.Console.WriteLine("날짜 - " + tempDate + " -> " + cut_date[0]);

                if (cut_date[0].Equals(yesterday) == false)
                {
                    countingNumbersOfDay += 1;
                    yesterday = cut_date[0];
                }
            }
        }

        return countingNumbersOfDay;
    }

    public ArrayList project_analysis(ArrayList parsing_logData)
    {

        List<string> project_name = new List<string>();
        string temp_name = null;
        ArrayList total_analysis_data = new ArrayList();
        // 프로젝트 참여한 사람 이름만 단독으로 뽑아내기
        for (int i = 0; i < parsing_logData.Count; i++)
        {
            if (i % 5 == 3)
            {
                temp_name = parsing_logData[i].ToString();
                //System.Console.WriteLine(temp_name);
                if (project_name.Contains(temp_name) == false)
                    project_name.Add(temp_name);
            }
        }

        //System.Console.WriteLine("사람이름 중복제거 이후");
        // 단위 테스트
        //for (int i = 0; i < project_name.Count; i++)
        //    System.Console.WriteLine(project_name[i]);
        // GUI에 표현하기 위한 임시 tuple 생성, 반환할 arraylist에 순차적으로 들어가기 위하여 생성한 변수
        // 0번 index : 사람이름
        string temp_pername = null;
        // 1번 index : 최종 커밋수
        int temp_total_commit = 0;
        // 2번 index : 총 개발기간
        string temp_total_date = null;
        // 3번 index : 개발 시작 날
        string temp_start_date = null;
        // 4번 index : 개발 종료 날
        string temp_end_date = null;
        // 5번 index : 총 코드개발수 
        int temp_total_loc = 0;
        // 6번 index : 총 생성한 코드라인수
        int temp_ins_loc = 0;
        // 7번 index : 삭제한 총 코드라인수
        int temp_del_loc = 0;
        // tem_pjname : 매개변수로 받은 arraylist에서 사람이름만 임시적으로 추출하는 변수
        string tem_pjname = null;
        // tem_per_ins : 사람당 insertion을 추출하기 위한 변수
        int tem_per_ins = 0;
        // tem_per_del : 사람당 delection을 추출하기 위한 변수
        int tem_per_del = 0;
        // forparse_total_date : 개발기간을 쪼개기 위한 변수
        string forparse_total_date = null;
        // tem_per_sinc : 사람당 성실도를 저장하기 위한 변수
        int tem_per_sinc = 0;
        // tem_email : 해당 개발자 이메일을 받는 변수
        string tem_email = null;
        for (int j = 0; j < project_name.Count; j++)
        {
            for (int i = 0; i < parsing_logData.Count; i++)
            {
                // 이름을 기준으로 개인당 log 분석
                if (i % 5 == 3)
                {
                    tem_pjname = parsing_logData[i].ToString();
                    if (tem_pjname.Equals(project_name[j].ToString()) == true)
                    {
                        // Total commit수
                        temp_total_commit = temp_total_commit + 1;
                        // insertion 수
                        tem_per_ins = int.Parse(parsing_logData[i - 3].ToString());
                        temp_ins_loc = temp_ins_loc + tem_per_ins;
                        tem_email = parsing_logData[i + 1].ToString();
                        // 추가 단위 테스트
                        // System.Console.WriteLine(project_name[j] + "의 추가수" + tem_per_ins);
                        // deletion 수
                        tem_per_del = int.Parse(parsing_logData[i - 2].ToString());
                        temp_del_loc = temp_del_loc + tem_per_del;
                        // 삭제 단위 테스트
                        // System.Console.WriteLine(project_name[j] + "의 삭제수" + tem_per_del);
                        // 성실도
                        tem_per_sinc = project_sincerity(parsing_logData, tem_pjname);

                        // 개발기간 계산
                        forparse_total_date = per_pj_date(parsing_logData, tem_pjname);
                        // 받아온 값 나눔 
                        string[] cut_data = forparse_total_date.Split(new char[] { '|' });
                        for (int k = 0; k < cut_data.Length; k++)
                            cut_data[k] = cut_data[k].Trim();
                        temp_start_date = cut_data[0];
                        temp_end_date = cut_data[1];
                        temp_total_date = cut_data[2];
                    }
                }
            }
            // 분석 단위 테스트
            //System.Console.WriteLine(project_name[j] + "의 이멜" + tem_email);
            //System.Console.WriteLine(project_name[j] + "의 커밋수" + temp_total_commit);
            //System.Console.WriteLine(project_name[j] + "의 총 추가수" + temp_ins_loc);
            //System.Console.WriteLine(project_name[j] + "의 총 삭제수" + temp_del_loc);
            //System.Console.WriteLine(project_name[j] + "의 시작날짜" + temp_start_date);
            //System.Console.WriteLine(project_name[j] + "의 종료날짜" + temp_end_date);
            //System.Console.WriteLine(project_name[j] + "의 개발기간" + temp_total_date);
            // 성실도 테스트
            //System.Console.WriteLine("커밋한 날 수 : " + tem_per_sinc);
            // 총 코드 수 작성
            // '추가 - 삭제' 하는 것이 올바른 계산 방법인지 생각해 봐야함 
            temp_total_loc = temp_ins_loc - temp_del_loc;
            // System.Console.WriteLine(project_name[j] + "의 총 코드작성수" + temp_total_loc);

            // Visualization에 보낼 total Arraylist 선택
            total_analysis_data.Add(project_name[j]);
            total_analysis_data.Add(temp_total_date);

            total_analysis_data.Add(temp_total_loc);
            total_analysis_data.Add(tem_per_sinc);

            total_analysis_data.Add(temp_total_commit);
            total_analysis_data.Add(temp_start_date);
            total_analysis_data.Add(temp_end_date);
            total_analysis_data.Add(temp_ins_loc);
            total_analysis_data.Add(temp_del_loc);
            total_analysis_data.Add(tem_email);

            // 사람마다 값을 계산해주기 위해 초기화
            temp_total_commit = 0;
            tem_per_ins = 0;
            temp_ins_loc = 0;
            tem_per_del = 0;
            temp_del_loc = 0;
        }
        for (int i = 0; i < total_analysis_data.Count; i++)
            System.Console.WriteLine(total_analysis_data[i]);
        return total_analysis_data;
    }
}

