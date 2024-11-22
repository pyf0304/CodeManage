using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace com.taishsoft.commdb
{
    public class clsSqlConnect_TzBak
    {

        public static ArrayList arrSqlConnectList = new ArrayList();
        public static int intMaxSqlConnect = 20;
        public static int intCurrMaxConnectId = 1;

        private int mintConnectId;//连接号

        public int ConnectId
        {
            get { return mintConnectId; }
            set { mintConnectId = value; }
        }

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
        private System.Data.SqlClient.SqlConnection mSqlConnect;

        public System.Data.SqlClient.SqlConnection SqlConnect
        {
            get { return mSqlConnect; }
            set { mSqlConnect = value; }
        }
        public void Close()
        {
            mbolIsUsing = false;
        }
        public static clsSqlConnect_TzBak getSqlConnect(string strConnectString)
        {
            //System.Data.SqlClient.SqlConnection objConn;
            bool bolIsGetConnect = false;   //是否获得连接
            foreach (clsSqlConnect_TzBak objSqlConnect_Tz in arrSqlConnectList)
            {
                if (objSqlConnect_Tz.IsUsing == false)
                {
                    if (objSqlConnect_Tz.ConnectString == strConnectString)
                    {
                        if (objSqlConnect_Tz.SqlConnect.State == System.Data.ConnectionState.Closed)
                        {
                            objSqlConnect_Tz.SqlConnect.Open();
                        }

                        bolIsGetConnect = true;

                        objSqlConnect_Tz.IsUsing = true;

                        return objSqlConnect_Tz;
                    }
                }
            }
            if (arrSqlConnectList.Count >= intMaxSqlConnect)
            {
                foreach (clsSqlConnect_TzBak objSqlConnect_Tz in arrSqlConnectList)
                {
                    if (objSqlConnect_Tz.IsUsing == false && objSqlConnect_Tz.ConnectString != strConnectString)
                    {
                        objSqlConnect_Tz.SqlConnect.Close();
                        objSqlConnect_Tz.SqlConnect.ConnectionString = strConnectString;
                        objSqlConnect_Tz.ConnectString = strConnectString;
                        objSqlConnect_Tz.SqlConnect.Open();
                        bolIsGetConnect = true;
                        objSqlConnect_Tz.IsUsing = true;
                        return objSqlConnect_Tz;
                    }
                }
            }
            if (arrSqlConnectList.Count < intMaxSqlConnect)
            {
                clsSqlConnect_TzBak objSqlConnect_Tz = new clsSqlConnect_TzBak();
                objSqlConnect_Tz.ConnectId = clsSqlConnect_TzBak.intCurrMaxConnectId++;
                objSqlConnect_Tz.SqlConnect = new System.Data.SqlClient.SqlConnection();
                objSqlConnect_Tz.SqlConnect.ConnectionString = strConnectString;
                objSqlConnect_Tz.ConnectString = strConnectString;
                objSqlConnect_Tz.SqlConnect.Open();
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
        public static void CloseSqlConnect(clsSqlConnect_TzBak objSqlConnect_Tz)
        {
            objSqlConnect_Tz.IsUsing = false;
        }
        public static void ClearAllSqlConnect()
        {
            foreach (clsSqlConnect_TzBak objSqlConnect_Tz in arrSqlConnectList)
            {
                if (objSqlConnect_Tz.IsUsing == true)
                {
                    objSqlConnect_Tz.IsUsing = false;
                }
            }
            foreach (clsSqlConnect_TzBak objSqlConnect_Tz in arrSqlConnectList)
            {
                if (objSqlConnect_Tz.SqlConnect.State == System.Data.ConnectionState.Open)
                {
                    objSqlConnect_Tz.SqlConnect.Close();
                }
            }
            arrSqlConnectList.Clear();
        }
    }
}
