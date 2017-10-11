using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebService_Izinga
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        private List<TeliaSMS> alarms;
        LogReader lr;

        public Service1()
        {
            alarms = new List<TeliaSMS>();
            lr = new LogReader(alarms);
        }

      


        public List<TeliaSMS> GetData()
        {
            return alarms;
            
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
