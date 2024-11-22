using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraduateStudyWebApp.FunClass
{
    public class clsPubVar
    {

        public const string CurrPrjId = "0015";
        //public const string IPAddressAndPort = " http://localhost:49590";
        public const string IPAddressAndPort = "https://www.sh-tz.com";
        //public const string IPAddressAndPort = "http://tzar.tpddns.cn:9080";
        public static string WebRoot { get; set; }

        public static string Url_Session_SetString { get; set; }
        public static string Url_Session_GetString { get; set; }
    }
}
