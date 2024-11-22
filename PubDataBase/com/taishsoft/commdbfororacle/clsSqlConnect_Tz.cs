using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data.OracleClient;
namespace com.taishsoft.commdbfororacle
{
    public class clsSqlConnect_Tz
    {

        public static List<clsSqlConnect_Tz> arrSqlConnectList = new List<clsSqlConnect_Tz>();
        public static int intMaxSqlConnect = 10;
        private bool mbolIsUsing = false;
        private string mstrConnectString;

        public string ConnectString
        {
            get { return mstrConnectString; }
            set { mstrConnectString = value; }
        }
        public bool IsUsing
        {
            get { return mbolIsUsing; }
            set { mbolIsUsing = value; }
        }
        private OracleConnection mOracleConnect;

        public OracleConnection OracleConnect
        {
            get { return mOracleConnect; }
            set { mOracleConnect = value; }
        }
        public void Close()
        {
            mbolIsUsing = false;
        }
        public static clsSqlConnect_Tz getOracleConnect(string strConnectString)
        {
            //System.Data.SqlClient.SqlConnection objConn;
            bool bolIsGetConnect = false;   //是否获得连接
            foreach(clsSqlConnect_Tz objSqlConnect_Tz in  arrSqlConnectList)
            {
                if (objSqlConnect_Tz.IsUsing == false)
                {
                    if (objSqlConnect_Tz.ConnectString == strConnectString)
                    {
                        if (objSqlConnect_Tz.OracleConnect.State == System.Data.ConnectionState.Closed)
                        {
                            objSqlConnect_Tz.OracleConnect.Open();
                        }
                        
                        bolIsGetConnect = true;
                        
                        objSqlConnect_Tz.IsUsing = true;

                        return objSqlConnect_Tz;
                    }
                }
            }
            if (arrSqlConnectList.Count >= intMaxSqlConnect)
            {
                foreach (clsSqlConnect_Tz objSqlConnect_Tz in arrSqlConnectList)
                {
                    if (objSqlConnect_Tz.IsUsing == false && objSqlConnect_Tz.ConnectString != strConnectString)
                    {
                        objSqlConnect_Tz.OracleConnect.Close();
                        objSqlConnect_Tz.OracleConnect.ConnectionString = strConnectString;
                        objSqlConnect_Tz.ConnectString = strConnectString;
                        objSqlConnect_Tz.OracleConnect.Open();
                        bolIsGetConnect = true;
                        objSqlConnect_Tz.IsUsing = true;
                        return objSqlConnect_Tz;
                    }
                }
            }
            if (arrSqlConnectList.Count < intMaxSqlConnect)
            {
                clsSqlConnect_Tz objSqlConnect_Tz = new clsSqlConnect_Tz();
                objSqlConnect_Tz.OracleConnect = new OracleConnection();
                objSqlConnect_Tz.OracleConnect.ConnectionString = strConnectString;
                objSqlConnect_Tz.ConnectString = strConnectString;
                objSqlConnect_Tz.OracleConnect.Open();
                objSqlConnect_Tz.IsUsing = true;
                arrSqlConnectList.Add(objSqlConnect_Tz);
                return objSqlConnect_Tz;
            }
            if (bolIsGetConnect == false)
            {
                StringBuilder sbMessage = new StringBuilder();
                sbMessage.AppendFormat("连接池已超过最大数：{0},请检查!", intMaxSqlConnect);
                throw new Exception(sbMessage.ToString());
            }
            return null;
        }
        public static void CloseSqlConnect(clsSqlConnect_Tz objSqlConnect_Tz)
        {
            objSqlConnect_Tz.IsUsing = false;
        }
    }
}
