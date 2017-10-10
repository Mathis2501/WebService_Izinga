using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WebService_Izinga;

namespace TestThingy
{
    class Program
    {
        string[] arr = new string[3];
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();
        }

        public void TeliaLogReader()
        {
            TeliaSMS NewSMS = new TeliaSMS();
            LogReader lr = new LogReader();


            string filepath = @"C:\Program Files (x86)\Mobilt Bredband\Log\trace_0.txt";
            string targetpath = @"C:\Program Files (x86)\Mobilt Bredband\Log\trace_0_kopi.txt";


            File.Copy(filepath, targetpath);


            foreach (string line in File.ReadAllLines(targetpath))
            {

                if (line.Contains("Number=+4551418279"))
                {
                    Regex regex = new Regex(@"(\d{4}[-]\d{2}[-]\d{2}\s\d{2}[:]\d{2}[:]\d{2})|(\w{3,}[=][a-zA-Z+0-9\s]{0,})");
                    MatchCollection match = regex.Matches(line);
                    arr[0] = match[0].ToString();
                    arr[1] = match[1].ToString();
                    arr[2] = match[2].ToString();

                    string[] ContentArr = arr[2].Split('=');


                    string[] NumberArr = arr[1].Split('=');


                    Console.WriteLine("Recieved SMS From " + NumberArr[1]);
                    Console.WriteLine("The alaram was : " + ContentArr[1]);
                    Console.WriteLine("The alaram was triggered at " + lr.IntepretDateTime(arr[0].ToString()));
                    Console.WriteLine();
                    Console.WriteLine("Recieved SMS From " + NumberArr[1]);
                    Console.WriteLine("The alaram was : " + ContentArr[1]);
                    Console.WriteLine("The alaram was triggered at " + lr.IntepretDateTime(arr[0].ToString()));


                }
            }




            File.Delete(targetpath);
        }
        void Run()
        {
            TeliaLogReader();
            Console.ReadKey();
        }
    }
}
