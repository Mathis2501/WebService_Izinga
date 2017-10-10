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
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();
        }

        public void TeliaLogReader()
        {
            TeliaSMS NewSMS = new TeliaSMS();


            string filepath = @"C:\Program Files (x86)\Mobilt Bredband\Log\trace_0.txt";
            string targetpath = @"C:\Program Files (x86)\Mobilt Bredband\Log\trace_0_kopi.txt";


            File.Copy(filepath, targetpath);


            foreach (string line in File.ReadAllLines(targetpath))
            {

                if (line.Contains("Number=+4551418279"))
                {
                    Regex regex = new Regex(@"(\d{4}[-]\d{2}[-]\d{2}\s\d{2}[:]\d{2}[:]\d{2})|(\w{3,}[=][a-zA-Z+0-9\s]{0,})");
                    MatchCollection match = regex.Matches(line);

                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine(match[i]);
                    }
                }
            }


            Console.ReadKey();


            File.Delete(targetpath);
        }
        void Run()
        {
            TeliaLogReader();
        }
    }
}
