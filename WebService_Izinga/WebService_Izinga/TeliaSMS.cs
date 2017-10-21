using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WebService_Izinga
{
    [DataContract]
    public class TeliaSMS
    {
        [DataMember]
        public string Number { get; private set; }
        [DataMember]
        public DateTime Time { get; private set; }
        [DataMember]
        public string Content { get; private set; }


        public TeliaSMS(string number, DateTime time, string content)
        {
            Number = number;
            Time = time;
            Content = content;
        }

    }
}
