using System;
using System.Collections.Generic;
using System.Text;

namespace com.taishsoft.comm_db_obj
{
    public class clsConnectStrObj
    {
        private string mstrConnectStringName = "";

        public string ConnectStringName
        {
            get { return mstrConnectStringName; }
            set { mstrConnectStringName = value; }
        }
        private string mstrConnectStringValue = "";

        public string ConnectStringValue
        {
            get { return mstrConnectStringValue; }
            set { mstrConnectStringValue = value; }
        }
        private string mstrConnectStringProviderName = "";

        public string ConnectStringProviderName
        {
            get { return mstrConnectStringProviderName; }
            set { mstrConnectStringProviderName = value; }
        }

    }
}
