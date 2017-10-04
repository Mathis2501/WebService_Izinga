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
        private List<Alarm> alarms;

        public Service1()
        {
            alarms = new List<Alarm>();
        }

      

        public string TriggerAlarm(string typeOfAlarm)
        {
            alarms.Add(new Alarm((typeOfAlarm)));
            return $"Alarm received: {typeOfAlarm}";
        }
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
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
