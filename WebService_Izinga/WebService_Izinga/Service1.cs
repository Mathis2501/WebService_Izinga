using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace WebService_Izinga
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        private object postAlarmLock = new object();
        private List<TeliaSMS> alarms;
        private LogReader lr = new LogReader();



        public Service1()
        {
            alarms = lr.TeliaLogReader();
        }


        public List<TeliaSMS> GetAlarms()
        {
            return alarms;

        }

        public void PostAlarm(TeliaSMS ts)
        {

            try
            {
                Monitor.Enter(postAlarmLock);
                if (ts != null)
                {
                    alarms.Add(ts);
                }
            }
            catch (Exception)
            {


            }
            finally
            {
                Monitor.Exit(postAlarmLock);
            }

        }



        //public CompositeType GetDataUsingDataContract(CompositeType composite)
        //{
        //    if (composite == null)
        //    {
        //        throw new ArgumentNullException("composite");
        //    }
        //    if (composite.BoolValue)
        //    {
        //        composite.StringValue += "Suffix";
        //    }
        //    return composite;
        //}
    }
}
