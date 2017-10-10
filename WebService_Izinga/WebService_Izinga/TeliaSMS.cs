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
        public string number { get; set; }
        [DataMember]
        public DateTime time { get; set; }
        [DataMember]
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
