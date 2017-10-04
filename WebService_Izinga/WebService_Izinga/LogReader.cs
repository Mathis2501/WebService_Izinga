using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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
        public void TeliaLogReader()
        {
            TeliaSMS NewSMS = new TeliaSMS();


            string filepath = @"C:\Program Files (x86)\Mobilt Bredband\Log\trace_0.txt";
            string targetpath = @"C:\Program Files (x86)\Mobilt Bredband\Log\trace_0_kopi.txt";


            File.Copy(filepath, targetpath);

            StreamReader sr = new StreamReader(targetpath);

            foreach (string line in File.ReadAllLines(targetpath))
            {
                if (line.Contains("Number=+4551418279"))
                {
                    string[] lines = line.Split(';');

                    for (int i = 0; i < lines.Length; i++)
                    {
                        if (i == 0)
                        {
                            string[] DateandTime = lines[i].Split(' ');
                            for (int j = 0; j < DateandTime.Length; j++)
                            {
                                if (j == 0)
                                {
                                    DateandTime[j] = DateandTime[j].Substring(1);
                                    string[] RealDateandTime = DateandTime[j].Split('-');
                                    for (int k = 0; k < RealDateandTime.Length; k++)
                                    {
                                        if (k == 0)
                                        {
                                            //NewSMS.time = RealDateandTime[k];
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            sr.Dispose();



            Console.ReadKey();


            File.Delete(targetpath);




        }
    }
}
