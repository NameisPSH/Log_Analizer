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
    class Parsing_Data
    {
        /*
         * 2014-11-19 권상희
         * Github log Data를 나눠서 저장할 변수 선언
         */
        ArrayList author;
        ArrayList email;
        ArrayList date;
        ArrayList subject;
        ArrayList Insertion_number;
        ArrayList Deletion_number;
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
            new System.IO.StreamReader(@"C:\Users\내문서\Documents\Visual Studio 2010\Projects\gitlog_parser\gitlog_parser\log_stat.txt");
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
            // commitSum : Commit 단위로 Parsing_class Data에 필드값을 넣기 위한 변수
            int commitSum = 0;
            // totalCommitValue : Log의 최종 commit수 변수
            int totalCommitValue = 0;
            // parseNumber : commit마다 log에 접근하여 나눠서 할당하기 위한 변수
            int parseNumber =0;
            ArrayList commitNumber= new ArrayList();
            for (int i = 0; i < logData.Count; i++)
            {
                if (logData[i].ToString().Contains("Author") == true)
                {
                    commitNumber.Add(i);
                }
            }
            for (int i = logData.Count - 1; i <= 0; i--)
            {
                if (logData[i].ToString().Contains("Author") == true)
                {
                    System.Console.WriteLine(logData[i].ToString());
                }
            }
            totalCommitValue = commitNumber.Count;
            System.Console.WriteLine(totalCommitValue);
            for (int i = commitNumber.Count-1; i >= 0; i--)
            {
               parseNumber = int.Parse(commitNumber[i].ToString());
               System.Console.WriteLine(logData[parseNumber].ToString());
            }
           
            // 마지막 commit의 Author 확인
            // System.Console.Write(logData[int.Parse(commitNumber[totalCommitValue-1].ToString())]);
        }
    }
}