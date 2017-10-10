using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService_Izinga
{
    public class Alarm
    {
        public DateTime TimeStamp { get; set; }

        public string Type { get; set; }

        public Alarm(string type)
        {
            TimeStamp = DateTime.Now;
            Type = type;
        }
    }
}
