using System;
using System.Collections.Generic;
using System.Text;

namespace com.taishsoft.comm_db_obj
{
    public class clsTable_SqlCommandText
    {
        private string strTableName;

        public string TableName
        {
            get { return strTableName; }
            set { strTableName = value; }
        }
        private string strSqlCommandText;

        public string SqlCommandText
        {
            get { return strSqlCommandText; }
            set { strSqlCommandText = value; }
        }

    }
}
