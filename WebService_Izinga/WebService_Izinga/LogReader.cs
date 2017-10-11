﻿using System;
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

        private List<TeliaSMS> teliaMessages;
        public LogReader()
        {

        }
        public LogReader(List<TeliaSMS> alarms)
        {
            teliaMessages = alarms;
            TeliaLogReader();
        }

        

        public void TeliaLogReader()
        {

            
            string filepath = @"C:\Program Files (x86)\Mobilt Bredband\Log\trace_0.txt";
            //string targetpath = @"C:\Program Files (x86)\Mobilt Bredband\Log\trace_0_kopi.txt";
            string targetFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Mobilt Bredband\\Log";
            string targetpath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Mobilt Bredband\\Log\\trace_0_kopi.txt";

            if (!Directory.Exists(targetFolder))
            {
                Directory.CreateDirectory(targetFolder);
            }

            File.Copy(filepath, targetpath);
           
            
            foreach (string line in File.ReadAllLines(targetpath))
            {
                
                if (line.Contains("Number=+4552631220"))
                {
                    Regex regex = new Regex(@"(\d{4}[-]\d{2}[-]\d{2}\s\d{2}[:]\d{2}[:]\d{2})|(\w{3,}[=][a-zA-Z+0-9\s]{0,})");
                    MatchCollection match = regex.Matches(line);


                    DateTime timeOfAlaram = IntepretDateTime(match[0].ToString());
                    string number = IntepretData(match[1].ToString());
                    string content = IntepretData(match[2].ToString());

                    

                    TeliaSMS newAlaram = new TeliaSMS(number, timeOfAlaram, content);

                    
                    if (!teliaMessages.Exists(x => x.time == timeOfAlaram))
                    {
                        teliaMessages.Add(newAlaram);
                    }

                    
                }
            }

            File.Delete(targetpath);
        }

        public void Objectfiller()
        {

        }
        //Intended to split up a string into object type: DateTime
        //string format is supposed to be "2017-10-04 10:51:57"
        public DateTime IntepretDateTime(string input)
        {
            string[] date, time, dateAndTime;
            dateAndTime = input.Split(' ');
            date = dateAndTime[0].Split('-');
            time = dateAndTime[1].Split(':');
            return new DateTime(int.Parse(date[0]), int.Parse(date[1]), int.Parse(date[2]), int.Parse(time[0]), int.Parse(time[1]), int.Parse(time[2]));

        }

        public string IntepretData(string input)
        {
            string[] DataArray = input.Split('=');
            return DataArray[1];
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
