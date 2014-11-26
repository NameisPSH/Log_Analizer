﻿using System;
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
            Analysis_Class b = new Analysis_Class();
            Date_parsing = b.Data_conversion(parsing_logData);
            b.project_date(Date_parsing);
            b.project_analysis(Date_parsing);
        }
    }
    class Parsing_class
    {
        static int totalCommitValue = 0;
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
                if (j % 5 == 2)
                {
                    //System.Console.WriteLine(Parsing_Data[j].ToString());
                }
            }
            // Parsing 된 Arraylist 전송
            return Parsing_Data;
        }
    }
    class Analysis_Class
    {
        string[] month = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        string[] conversion_month = { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" };
        string total_month = null;
        string total_Date = null;
        public ArrayList Data_conversion(ArrayList Parsing_Data)
        {
            // 년, 월, 일로 덮어씌우고 return
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
                    total_Date = cut_str_month[4] + '-' + total_month + '-' + cut_str_month[2];
                    //System.Console.WriteLine("날짜:" + total_Date);
                    Parsing_Data[j] = total_Date;
                }
            }
            for (int i = 0; i < Parsing_Data.Count; i++)
                System.Console.WriteLine(Parsing_Data[i].ToString());
            return Parsing_Data;
        }
        //, Boolean flag 전체 프로젝트 기간과, 사람당 프로젝트 기간 정리
        public int project_date(ArrayList Date_parsing)
        {
            string temp_first_Date = Date_parsing[2].ToString();
            DateTime first_Date = DateTime.Parse(temp_first_Date);
            //System.Console.WriteLine("첫날" + first_Date);

            string temp_last_Date = Date_parsing[Date_parsing.Count - 3].ToString();
            DateTime last_Date = DateTime.Parse(temp_last_Date);
            //System.Console.WriteLine("마지막날" + last_Date);

            TimeSpan Calc_Date = last_Date.Subtract(first_Date);
            int Result_Date = Calc_Date.Days;

            // System.Console.WriteLine("총 개발일수는 " + Result_Date);
            // System.Console.WriteLine("값은 : "+Date_parsing[3]);
            return Result_Date;
        }
        // 사람당 개발기간을 계산하기 위한 함수
        //public int per_pj_date(ArrayList logData, string name)
        //{

        //}
        public void project_analysis(ArrayList parsing_logData)
        {
            List<string> project_name = new List<string>();
            string temp_name = null;
            // 프로젝트 참여한 사람 이름만 단독으로 뽑아내기
            for (int i = 0; i < parsing_logData.Count; i++)
            {
                if (i % 5 == 3)
                {
                    temp_name = parsing_logData[i].ToString();
                    System.Console.WriteLine(temp_name);
                    if (project_name.Contains(temp_name) == false)
                        project_name.Add(temp_name);
                }
            }
            System.Console.WriteLine("사람이름 중복제거 이후");
            // 검증
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
            for (int j = 0; j < project_name.Count; j++)
            {
                for (int i = 0; i < parsing_logData.Count; i++)
                {
                    if (i % 5 == 3)
                    {
                        tem_pjname = parsing_logData[i].ToString();
                        if (tem_pjname.Equals(project_name[j].ToString()) == true)
                        {
                            temp_total_commit = temp_total_commit + 1;
                        }

                    }
                }
                //System.Console.WriteLine(project_name[j] + "의 커밋수" + temp_total_commit);
                temp_total_commit = 0;
            }
        }
    }
}