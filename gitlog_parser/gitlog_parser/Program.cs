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
            logData = a.fileRead();
            a.commitParsing(logData);
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
        public void commitParsing(ArrayList logData)
        {   
            /*
             * 2014-11-24 권상희
             * 0번 index : insertion,  1번 index : deletion, 3번 index : date 4번 index : e-mail 5번 index : author
             * index Number :0,1,2,3,4 순서 modula 5로 접근할 것
            */
            // totalCommitValue : Log의 최종 commit수 변수
            int totalCommitValue = 0;
            ArrayList Parsing_Data = new ArrayList();
            string data = null;
            
            for (int i = 0; i < logData.Count; i++)
            {
                if (logData[i].ToString().Contains("changed") == true)
                {
                    if(logData[i].ToString().Contains("insertion")==true)
                    {
                        data = logData[i].ToString();
                        string[] cut_str = data.Split(new char[]{',',' '});
                        for(int j=0 ; j<cut_str.Length;j++)
                        {
                            System.Console.WriteLine((j+1)+"번째"+cut_str[j]);
                        }
                        data = cut_str[5].Trim();
                        System.Console.WriteLine("insertion 집어넣을 데이터" + data);
                        Parsing_Data.Add(data);
                        if (cut_str.Length > 7)
                        {
                            data = cut_str[8].Trim();
                            System.Console.WriteLine("delection 집어넣을 데이터" + data);
                            Parsing_Data.Add(data);
                        }
                    }
                    else 
                    {
                        data = null;
                        Parsing_Data.Add(data);
                    }
                    if(logData[i].ToString().Contains("deletion")==true)
                    {
                        data = logData[i].ToString();
                        string[] cut_str = data.Split(new char[] { ',', ' ' });
                        if(cut_str[6].Contains("delection")==true)
                        {
                            data = cut_str[5].Trim();
                            System.Console.WriteLine("delection 집어넣을 데이터" + data);
                            Parsing_Data.Add(data);
                        }
                    }
                    else
                    {
                        data = null;
                        Parsing_Data.Add(data);
                    }               
                }
                else 
                {
                    data = null;
                    Parsing_Data.Add(data);
                    Parsing_Data.Add(data);
                }
            }
            for (int i = logData.Count - 1; i <= 0; i--)
            {
                if (logData[i].ToString().Contains("Author") == true)
                {
                    totalCommitValue = totalCommitValue + 1;
                }
            }
        }
    }
}