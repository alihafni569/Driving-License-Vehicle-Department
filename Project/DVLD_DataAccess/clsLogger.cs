using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    public class clsLogger
    {
        static string SoutceApp = "Drivers License Management";
        public static void LogExption(string message, EventLogEntryType eventLogEntryType= System.Diagnostics.EventLogEntryType.Error)
        {

            try
            {

                if (!EventLog.SourceExists(SoutceApp))
                {
                    EventLog.CreateEventSource(SoutceApp, "Application");
                }

                EventLog.WriteEntry(SoutceApp, message, eventLogEntryType);


            }
            catch (Exception ex)
            {
                EventLog.WriteEntry(SoutceApp, ex.ToString(), EventLogEntryType.Error);
            }

        }
    }
}
