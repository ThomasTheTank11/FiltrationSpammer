using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltrationSpammer.Properties;

namespace FiltrationSpammer
{
    class core
    {
        public static string accountID
        {
            get { return Settings.Default["accountid"].ToString(); }
            set { Settings.Default["accountid"] = value; }
        }

        public static string authToken
        {
            get { return Settings.Default["authtoken"].ToString(); }
            set { Settings.Default["authtoken"] = value; }
        }
    }
}
