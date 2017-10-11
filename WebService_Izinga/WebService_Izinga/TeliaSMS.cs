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
        public string number { get; private set; }
        [DataMember]
        public DateTime time { get; private set; }
        [DataMember]
        public string content { get; private set; }


        public TeliaSMS(string Number, DateTime Time, string Content)
        {
            number = Number;
            time = Time;
            content = Content;
        }
    
    }
}
