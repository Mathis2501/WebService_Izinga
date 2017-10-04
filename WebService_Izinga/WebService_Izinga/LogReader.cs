using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebService_Izinga
{
    public class LogReader
    {
        public List<TeliaSMS> TeliaSMSs;
        public LogReader()
        {
            TeliaSMSs = new List<TeliaSMS>();
        }

        //Intended to split up a string into object type: DateTime
        //string format is supposed to be "2017-10-04 10:51:57"

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
                    Regex regex = new Regex(@"\d{4}[-]\d{2}[-]\d{2}\s\d{2}[:]\d{2}[:]\d{2}");
                    Match match = regex.Match(line);
                    Console.WriteLine(match.Value);
                }
            }
      

            Console.ReadKey();


            File.Delete(targetpath);
        }
        public DateTime IntepretDateTime(string input)
        {
            string[] date, time, dateAndTime;
            dateAndTime = input.Split(' ');
            date = dateAndTime[0].Split('-');
            time = dateAndTime[1].Split(':');
            return new DateTime(int.Parse(date[0]), int.Parse(date[1]), int.Parse(date[2]), int.Parse(time[0]), int.Parse(time[1]), int.Parse(time[2]));

        }

        //public void OldLogReader()
        //{
            //StreamReader sr = new StreamReader(targetpath);
            //foreach (string line in File.ReadAllLines(targetpath))
            //{
            //    if (line.Contains("Number=+4551418279"))
            //    {
            //        string[] lines = line.Split(';');

            //        for (int i = 0; i < lines.Length; i++)
            //        {
            //            if (i == 0)
            //            {
            //                string[] DateandTime = lines[i].Split(' ');
            //                for (int j = 0; j < DateandTime.Length; j++)
            //                {
            //                    if (j == 0)
            //                    {
            //                        DateandTime[j] = DateandTime[j].Substring(1);
            //                        string[] RealDateandTime = DateandTime[j].Split('-');
            //                        for (int k = 0; k < RealDateandTime.Length; k++)
            //                        {
            //                            if (k == 0)
            //                            {
            //                                //NewSMS.time = RealDateandTime[k];
            //                            }
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}

            //sr.Dispose();

        //}


    }
}
