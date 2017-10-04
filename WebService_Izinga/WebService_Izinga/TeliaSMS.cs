using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService_Izinga
{
    public class TeliaSMS
    {
        public string number { get; set; }
        public DateTime time { get; set; }
        public string content { get; set; }


        public TeliaSMS(string Number, DateTime Time, string Content)
        {
            number = Number;
            time = Time;
            content = Content;
        }
        public TeliaSMS()
        {

        }
    }
}
