using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace gitlog_parser
{
    class Program
    {
        static void Main(string[] args)
        {
            Parsing_class a = new Parsing_class();
            ArrayList logData = new ArrayList();
            ArrayList parsing_logData = new ArrayList();
            ArrayList Date_parsing = new ArrayList();
            logData = a.fileRead();
            parsing_logData = a.commitParsing(logData);
            //Analysis_Class b = new Analysis_Class();
            //Date_parsing = b.Data_conversion(parsing_logData);
            //b.project_date(Date_parsing);
        }
    }
    class Parsing_class
    {
        public ArrayList fileRead()
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
            new System.IO.StreamReader(@"C:\Users\내문서\Source\Repos\Log_Analizer\gitlog_parser\gitlog_parser\log_stat_WE.txt");
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
            int totalCommitValue = 0;
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
            for(int i = 0; i <tem_Parsing_Data.Count;i++)
            {
                data = tem_Parsing_Data[i].ToString();
                // 1번째,2번째 (삽입,삭제) 입력
                if(data.Contains("changed,") == true)
                {
                    if (data.Contains("(+") == true)
                    {
                        string[] cut_str = data.Split(new string[]{",","insert","dele"},StringSplitOptions.RemoveEmptyEntries);
                        cut_str[1] = cut_str[1].Trim();
                        Parsing_Data.Add(cut_str[1]);
                        if(cut_str.Length > 4)
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
                    string[] cut_str = data.Split(new string[] { "Date:", "Author:"}, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 0; j < cut_str.Length; j++)
                    {
                        cut_str[j] = cut_str[j].Trim();
                        //System.Console.WriteLine(j+"번째" + cut_str[j]);
                    }
                    // 3번째 Date(날짜) 입력
                    if (cut_str[1].Contains(":")==true)
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
            for(int j = 0;j < Parsing_Data.Count;j++)
            {
                if(j % 5 == 2)
                {
                    //System.Console.WriteLine(Parsing_Data[j].ToString());
                }
            }
            // Parsing 된 Arraylist 전송
            return Parsing_Data;
        }
    }
}