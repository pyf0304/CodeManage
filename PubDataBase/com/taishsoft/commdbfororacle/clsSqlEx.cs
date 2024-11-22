using System;
using System.Collections;
using System.Data;
using System.Data.OracleClient;
using System.Text;
using System.Collections.Generic;
using com.taishsoft.comm_db_obj;
using com.taishsoft.encrypt;
using System.Configuration;
using com.taishsoft.common;

namespace com.taishsoft.commdbfororacle
{
    /// <summary>
    /// clsSqlEx ��ժҪ˵����
    /// </summary>
    public class clsSqlEx : clsSQL
    {
        public clsSqlEx()
        {
            //
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }
        public clsSqlEx(string sconnectString) : base(sconnectString)
        {
        }

        public clsSqlEx(string server, string database, string uid, string pwd) : base(server, database, uid, pwd)
        {

        }
        public clsSqlEx(string strConnectStringName, bool bolIsUseConnStrName)
        {
            if (bolIsUseConnStrName == true)
            {
                mstrConnectStrName = strConnectStringName;
                //�������ļ��л�ȡ���Ӵ�
                //GetConnectStringFromConfigWithConnStrName();
                p_sConnectString = clsSqlEx.GetConnectStrByName(mstrConnectStrName);
                //this.ConnectionString

            }
        }

        ///���Ӵ�����
        public static string strConnectStrName = "";
        public static bool bolIsUseConnectStrName = false;

        private static bool mbolIsUseEncrypt = false;//�Ƿ�ʹ�ü������Ӵ�

        public static bool IsUseEncrypt
        {
            get { return clsSqlEx.mbolIsUseEncrypt; }
            set { clsSqlEx.mbolIsUseEncrypt = value; }
        }

        private static string mstrConnectString = "";

        public static string ConnectString
        {
            get { return clsSqlEx.mstrConnectString; }
            set
            {
                clsSqlEx.mstrConnectString = value;
            }
        }
        private static string mstrConnectString2 = "";

        public static string ConnectString2
        {
            get { return clsSqlEx.mstrConnectString2; }
            set
            {
                clsSqlEx.mstrConnectString2 = value;
            }
        }
        private static string mstrWebConfigFileName;

        public static string WebConfigFileName
        {
            get { return clsSqlEx.mstrWebConfigFileName; }
            set { clsSqlEx.mstrWebConfigFileName = value; }
        }
        public static List<clsConnectStrObj> arrConnectStrObjLst = null;
        /// <summary>
        /// �������ļ�(Web.Config)�л�ȡ���Ӵ������б�
        /// </summary>
        /// <returns></returns>
        public static bool GetConnectStrObjLst()
        {
            if (arrConnectStrObjLst == null)
            {
                arrConnectStrObjLst = new List<clsConnectStrObj>();
            }
            //			p_sConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString4"];
            switch (clsSpecSQLforOra.strAppType)
            {
                case "WEBAPP":
                    if (string.IsNullOrEmpty(clsSpecSQLforOra.strWebRoot) == true)
                    {
                        throw new Exception("clsSpecSQLforSql.strWebRootΪ�գ�����Global.asax�����ø�ֵ�������ڸ���Ŀ����ʼҳ�����ø�ֵ�������޷����У�����");
                    }
                    if (clsSqlEx.IsUseEncrypt == true)
                    {
                        string strWebConfigFile = clsSqlEx.WebConfigFileName;

                        List<clsConnectStrObj> arrConnectStrObjLst_p = new List<clsConnectStrObj>();
                        arrConnectStrObjLst_p = new clsEncrypt().GetConnectStringForEncryptEx(
                            strWebConfigFile,
                            "connectionStrings/add");

                        foreach (clsConnectStrObj objConnectStrObj in arrConnectStrObjLst_p)
                        {
                            if (IsExistConnectStringName(objConnectStrObj.ConnectStringName) == false)
                            {
                                arrConnectStrObjLst.Add(objConnectStrObj);
                            }
                        }

                    }
                    else
                    {
                        System.Configuration.Configuration rootWebConfig =
            System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(clsSpecSQLforOra.strWebRoot);

                        ConnectionStringSettingsCollection connectionStrings = rootWebConfig.ConnectionStrings.ConnectionStrings;// ConfigurationManager.ConnectionStrings;


                        int i = 0;
                        Console.WriteLine("Connection strings.");
                        //arrConnectStrObjLst = new List<clsConnectStrObj>();
                        while (i < connectionStrings.Count)
                        {
                            clsConnectStrObj objConnect = new clsConnectStrObj();
                            objConnect.ConnectStringName = connectionStrings[i].Name;
                            objConnect.ConnectStringValue = connectionStrings[i].ConnectionString;
                            objConnect.ConnectStringProviderName = connectionStrings[i].ProviderName;
                            if (IsExistConnectStringName(objConnect.ConnectStringName) == false)
                            {
                                arrConnectStrObjLst.Add(objConnect);
                            }
                            //string name = connectionStrings[i].Name;
                            Console.WriteLine("Name: {0} Value: {1}",
                            objConnect.ConnectStringName, objConnect.ConnectStringValue);
                            i += 1;
                        }
                    }
                    break;
                case "WINAPP":

                    if (clsSqlEx.IsUseEncrypt == true)
                    {
                        string strApplicationConfigFile = clsApplicatoin.ExecutablePath + ".config";

                        List<clsConnectStrObj> arrConnectStrObjLst_p = new List<clsConnectStrObj>();
                        arrConnectStrObjLst_p = new clsEncrypt().GetConnectStringForEncryptEx(
                            strApplicationConfigFile,
                            "connectionStrings/add");

                        foreach (clsConnectStrObj objConnectStrObj in arrConnectStrObjLst_p)
                        {
                            if (IsExistConnectStringName(objConnectStrObj.ConnectStringName) == false)
                            {
                                arrConnectStrObjLst.Add(objConnectStrObj);
                            }
                        }

                    }
                    else
                    {
                        ConnectionStringSettingsCollection connectionStrings = ConfigurationManager.ConnectionStrings;
                        int i = 0;
                        Console.WriteLine("Connection strings.");
                        //arrConnectStrObjLst = new List<clsConnectStrObj>();
                        while (i < connectionStrings.Count)
                        {
                            clsConnectStrObj objConnect = new clsConnectStrObj();
                            objConnect.ConnectStringName = connectionStrings[i].Name;
                            objConnect.ConnectStringValue = connectionStrings[i].ConnectionString;
                            objConnect.ConnectStringProviderName = connectionStrings[i].ProviderName;
                            if (IsExistConnectStringName(objConnect.ConnectStringName) == false)
                            {
                                arrConnectStrObjLst.Add(objConnect);
                            }
                            //string name = connectionStrings[i].Name;
                            Console.WriteLine("Name: {0} Value: {1}",
                            objConnect.ConnectStringName, objConnect.ConnectStringValue);
                            i += 1;
                        }
                    }
                    break;
                case "DynamicCompiler":
                    break;
                default:
                    break;
            }
            return true;
        }
        public static bool IsExistConnectStringName(string strConnectStringName)
        {
            foreach (clsConnectStrObj objConnectStrObj in arrConnectStrObjLst)
            {
                if (objConnectStrObj.ConnectStringName == strConnectStringName)
                {
                    return true;
                }
            }
            return false;
        }
        //���Ӵ���
        protected string mstrConnectStrName = "";
        /// <summary>
        /// ���Ӵ�����
        /// </summary>
        public string ConnectStrName
        {
            get { return mstrConnectStrName; }
            set
            {
                mstrConnectStrName = value;
                if (string.IsNullOrEmpty(mstrConnectStrName) == false)
                {
                    GetConnectStringFromConfigWithConnStrName();
                }
            }
        }
        /// <summary>
        /// ��Web.config�����ļ���ȡ���Ӵ�,ͬʱʹ�����Ӵ�����
        /// </summary>
        private void GetConnectStringFromConfigWithConnStrName()
        {
            //			p_sConnectString = System.Configuration.ConfigurationManager.AppSettings["ConnectionString4"];
            if (clsSpecSQLforOra.strAppType == "WEBAPP")
            {

                if (string.IsNullOrEmpty(clsSpecSQLforOra.strWebRoot) == true)
                {
                    throw new Exception("clsSpecSQLforSql.strWebRootΪ�գ�����Global.asax�����ø�ֵ�������ڸ���Ŀ����ʼҳ�����ø�ֵ�������޷����У�����");
                }
                if (clsSqlEx.IsUseEncrypt == true)
                {
                    string strWebConfigFile = clsSqlEx.WebConfigFileName;
                    p_sConnectString = new clsEncrypt().GetConnectStringForEncrypt(
                        strWebConfigFile,
                        "connectionStrings/add",
                        mstrConnectStrName);
                }
                else
                {
                    System.Configuration.Configuration rootWebConfig =
        System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration(clsSpecSQLforOra.strWebRoot);
                    System.Configuration.ConnectionStringSettings connString;
                    if (0 == rootWebConfig.ConnectionStrings.ConnectionStrings.Count)
                    {
                        throw new Exception("��Web.Config��û�������ַ��������飡");
                    }
                    if (0 < rootWebConfig.ConnectionStrings.ConnectionStrings.Count)
                    {
                        connString =
                            rootWebConfig.ConnectionStrings.ConnectionStrings[mstrConnectStrName];
                        if (null != connString)
                        {
                            Console.WriteLine("Local connection string = \"{0}\"",
                                connString.ConnectionString);
                            p_sConnectString = connString.ConnectionString;
                        }
                        else
                        {
                            Console.WriteLine("No Local connection string");
                            throw new Exception(string.Format("�������ļ�:{1}��,��������:{0}��ָ�������Ӵ�Ϊ�գ����飡",
                                mstrConnectStrName,
                                clsSpecSQLforOra.strWebRoot));
                        }
                    }
                }
            }
            else if (clsSpecSQLforOra.strAppType == "WINAPP")
            {
                if (clsSqlEx.IsUseEncrypt == true)
                {
                    string strApplicationConfigFile = clsApplicatoin.ExecutablePath + ".config";
                    p_sConnectString = new clsEncrypt().GetConnectStringForEncrypt(
                        strApplicationConfigFile,
                        "connectionStrings/add",
                        mstrConnectStrName);
                    List<clsConnectStrObj> arrConnectStrObjLst_p = new List<clsConnectStrObj>();
                    arrConnectStrObjLst_p = new clsEncrypt().GetConnectStringForEncryptEx(
                        strApplicationConfigFile,
                        "connectionStrings/add");
                    foreach (clsConnectStrObj objConnectStrObj in arrConnectStrObjLst_p)
                    {
                        if (IsExistConnectStringName(objConnectStrObj.ConnectStringName) == false)
                        {
                            arrConnectStrObjLst.Add(objConnectStrObj);
                        }
                    }
                }
                else
                {
                    p_sConnectString = System.Configuration.ConfigurationManager.ConnectionStrings[mstrConnectStrName].ToString();
                    ConnectionStringSettingsCollection connectionStrings = ConfigurationManager.ConnectionStrings;


                    int i = 0;
                    Console.WriteLine("Connection strings.");
                    //ArrayList arrConnectStrObjLst = new ArrayList();
                    while (i < connectionStrings.Count)
                    {
                        clsConnectStrObj objConnect = new clsConnectStrObj();
                        objConnect.ConnectStringName = connectionStrings[i].Name;
                        objConnect.ConnectStringValue = connectionStrings[i].ConnectionString;
                        objConnect.ConnectStringProviderName = connectionStrings[i].ProviderName;
                        if (IsExistConnectStringName(objConnect.ConnectStringName) == false)
                        {
                            arrConnectStrObjLst.Add(objConnect);
                        }
                        //string name = connectionStrings[i].Name;
                        Console.WriteLine("Name: {0} Value: {1}",
                        objConnect.ConnectStringName, objConnect.ConnectStringValue);
                        i += 1;
                    }
                }
            }
        }
        public static string GetConnectStrByName(string strConnectStrName)
        {
            if (arrConnectStrObjLst == null)
            {
                GetConnectStrObjLst();
            }

            if (arrConnectStrObjLst == null) return "";
            if (arrConnectStrObjLst.Count == 0) return "";
            foreach (clsConnectStrObj objConnect in arrConnectStrObjLst)
            {
                if (objConnect.ConnectStringName == strConnectStrName)
                {
                    return objConnect.ConnectStringValue;
                }
            }
            return "";
        }
        /// <summary>
        /// ��ȡ�����ķ����������ݿ������б�����
        /// </summary>
        /// <returns>���б�����DataTable</returns>
        public System.Data.DataTable getTables1()
        {

            /////ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
            /////���� 1=1 && UserName = '����'
            //string strWhereCond = " 1=1 ";
            /////����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
            //if (this.txtOwner_q.Text.Trim() != "")
            //{
            //    strWhereCond += " And Owner like '%" + this.txtOwner_q.Text.Trim() + "%'";
            //}
            //if (this.txtTable_Name_q.Text.Trim() != "")
            //{
            //    strWhereCond += " And Table_Name like '%" + this.txtTable_Name_q.Text.Trim() + "%'";
            //}
            //if (this.txtTableSpace_Name_q.Text.Trim() != "")
            //{
            //    strWhereCond += " And TableSpace_Name like '%" + this.txtTableSpace_Name_q.Text.Trim() + "%'";
            //}
            //return strWhereCond;

            string strCondition = " 1=1 ";
            string strSQL;
            System.Data.DataTable objDT;
            strSQL = "Select * from ALL_ALL_TABLES where " + strCondition;
            objDT = GetDataTable(strSQL);
            return objDT;
        }

        /// <summary>
        /// ��ȡ�����ķ����������ݿ������б�����
        /// </summary>
        /// <returns>���б�����DataTable</returns>
        public System.Data.DataTable getTables(string strTableSpcce)
        {
            /////ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
            /////���� 1=1 && UserName = '����'
            StringBuilder sbWhereCond = new StringBuilder();
            sbWhereCond.Append(" 1=1 ");
            /////����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
            //if (this.txtOwner_q.Text.Trim() != "")
            //{
            //    strWhereCond += " And Owner like '%" + this.txtOwner_q.Text.Trim() + "%'";
            //}
            //if (this.txtTable_Name_q.Text.Trim() != "")
            //{
            //    strWhereCond += " And Table_Name like '%" + this.txtTable_Name_q.Text.Trim() + "%'";
            //}
            if (string.IsNullOrEmpty(strTableSpcce) == false)
            {
                sbWhereCond.AppendFormat(" And TableSpace_Name = '{0}'", strTableSpcce);
            }
            //return strWhereCond;            
            string strSQL;
            System.Data.DataTable objDT;
            strSQL = "Select * from ALL_ALL_TABLES where " + sbWhereCond.ToString();
            objDT = GetDataTable(strSQL);
            return objDT;
        }

        /// <summary>
        /// ��ȡ�����ķ����������ݿ������б�����
        /// </summary>
        /// <returns>���б�����DataTable</returns>
        public System.Data.DataTable getUserTables(string strTableSpcce)
        {

            /////ʹ�������ĳ�ֵΪ"1=1"���Ա��ڸô��ĺ�����"and "�����������,
            /////���� 1=1 && UserName = '����'
            StringBuilder sbWhereCond = new StringBuilder();
            sbWhereCond.Append(" 1=1 ");
            /////����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
            //if (this.txtOwner_q.Text.Trim() != "")
            //{
            //    strWhereCond += " And Owner like '%" + this.txtOwner_q.Text.Trim() + "%'";
            //}
            //if (this.txtTable_Name_q.Text.Trim() != "")
            //{
            //    strWhereCond += " And Table_Name like '%" + this.txtTable_Name_q.Text.Trim() + "%'";
            //}
            if (string.IsNullOrEmpty(strTableSpcce) == false)
            {
                sbWhereCond.AppendFormat(" And TableSpace_Name = '{0}'", strTableSpcce);
            }
            string strSQL;
            System.Data.DataTable objDT;
            strSQL = "Select * from User_TABLES where " + sbWhereCond.ToString();
            objDT = GetDataTable(strSQL);
            return objDT;
        }


        /// <summary>
        /// ��ȡ�����ķ����������ݿ������б�����
        /// </summary>
        /// <returns>���б�����DataTable</returns>
        public bool IsExistTable(string strTabName)
        {

            StringBuilder sbCondition = new StringBuilder();
            sbCondition.Append(" 1=1 ");
            if (string.IsNullOrEmpty(strTabName) == false)
            {
                sbCondition.AppendFormat(" And Table_Name = '{0}'", strTabName);
            }

            string strSQL;
            System.Data.DataTable objDT;
            strSQL = "Select * from ALL_ALL_TABLES where " + sbCondition.ToString();
            objDT = GetDataTable(strSQL);
            if (objDT.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// ��ȡ�����ķ����������ݿ�������VIEW����
        /// </summary>
        /// <returns>����View����DataTable</returns>
        public System.Data.DataTable getViews()
        {
            string strCondition = " 1=1 ";
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
            strSQL = "Select concat(Owner, View_name) As OwnerView_Name, ALL_VIEWS.* from ALL_VIEWS where " + strCondition;
            objDT = objSQL.GetDataTable(strSQL);
            return objDT;

        }
        /// <summary>
        /// ���ܣ���ȡ���������������Ϣ
        /// </summary>
        /// <param name="strTabName">�����ı���</param>
        /// <returns>���������������Ϣ����DataTable��ʽ</returns>
        public DataTable GetColumns(string strTabName)
        {
            DataTable objDT;
            try
            {
                StringBuilder sbWhereCond = new StringBuilder();
                sbWhereCond.Append(" 1=1 ");
                //����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
                if (string.IsNullOrEmpty(strTabName) == false)
                {
                    sbWhereCond.AppendFormat(" And Table_Name = '{0}'", strTabName);
                }
                string strSQL;
                clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
                strSQL = "Select concat(Owner, Table_name) As OwnerTable_Name, ALL_TAB_COLUMNS.* from ALL_TAB_COLUMNS where " + sbWhereCond.ToString();
                objDT = objSQL.GetDataTable(strSQL);
                return objDT;
            }
            catch (Exception objException)
            {
                //'Log the error
                LogError(objException, "");
                //'Close the connection
                //'Throw a new exception
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
                //'                mobjConnection.Close()
            }
        }
        public OracleDataReader ExecSPReturnDR(string SPName, ArrayList ParamValues)
        {
            OracleCommand objCommand;
            OracleDataReader objReader;
            try
            {
                //'Make sure that the object has not been disposed yet
                if (mblnDisposed == true)
                {
                    throw new ObjectDisposedException(mstrModuleName, "This object has already been disposed.");
                }
                //'Make sure we are getting a valid stored procedure name.
                ValidateSPName(SPName);
                //'Open the connection (required for the ExecuteReader method).
                m_oConn = new OracleConnection(this.p_sConnectString);
                m_oConn.Open();
                //'Initialize the SQLCommand object
                objCommand = new OracleCommand(SPName, m_oConn);
                objCommand.CommandType = CommandType.StoredProcedure;
                //'Build the parameters, if any
                BuildParameters(objCommand, ParamValues);
                //'Execute the sp and get the SqlDataReader.
                objReader = objCommand.ExecuteReader();
                //'Return the value
                return objReader;
            }
            catch (Exception objException)
            {
                //'Log the error
                LogError(objException, "");

                //'Close the connection
                m_oConn.Close();
                //'Throw a new exception
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
        }

        /// <summary>
        /// ���ܣ���ȡ������ĳӵ���ߵ���������Ϣ
        /// </summary>
        /// <param name="strTabName">�����ı���</param>
        /// <param name="strDataBaseOwner">������ӵ����</param>
        /// <returns>���������������Ϣ����DataTable��ʽ</returns>
        public DataTable GetColumns(string strTabName, string strDataBaseOwner)
        {
            DataTable objDT;
            try
            {
                StringBuilder sbWhereCond = new StringBuilder();
                sbWhereCond.Append(" 1=1 ");
                //����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
                if (string.IsNullOrEmpty(strDataBaseOwner) == false)
                {
                    sbWhereCond.AppendFormat(" And Owner = '{0}'", strDataBaseOwner);
                }
                if (string.IsNullOrEmpty(strTabName) == false)
                {
                    sbWhereCond.AppendFormat(" And Table_Name = '{0}'", strTabName);
                }
                string strSQL;
                strSQL = "Select concat(Owner, Table_name) As OwnerTable_Name, ALL_TAB_COLUMNS.* from ALL_TAB_COLUMNS where " + sbWhereCond.ToString();
                objDT = GetDataTable(strSQL);
                return objDT;
            }
            catch (Exception objException)
            {
                //'Log the error
                LogError(objException, "");
                //'Close the connection
                //'Throw a new exception
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
                //'                mobjConnection.Close()
            }
        }

        /// <summary>
        /// ���ܣ���ȡ������ĳӵ���ߵ���������Ϣ
        /// </summary>
        /// <param name="strTabName">�����ı���</param>
        /// <param name="strColumnName">����</param>
        /// <param name="strDataBaseOwner">������ӵ����</param>
        /// <returns>���������������Ϣ����DataTable��ʽ</returns>
        public DataTable GetColumns(string strTabName, string strColumnName, string strDataBaseOwner)
        {
            DataTable objDT;
            try
            {
                StringBuilder sbWhereCond = new StringBuilder();
                sbWhereCond.Append(" 1=1 ");
                //����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
                if (string.IsNullOrEmpty(strDataBaseOwner) == false)
                {
                    sbWhereCond.AppendFormat(" And Owner = '{0}'", strDataBaseOwner);
                }
                if (string.IsNullOrEmpty(strTabName) == false)
                {
                    sbWhereCond.AppendFormat(" And Table_Name = '{0}'", strTabName);
                }
                if (string.IsNullOrEmpty(strColumnName) == false)
                {
                    sbWhereCond.AppendFormat(" And Column_Name = '{0}'", strColumnName);
                }

                string strSQL;
                strSQL = "Select concat(Owner, Table_name) As OwnerTable_Name, ALL_TAB_COLUMNS.* from ALL_TAB_COLUMNS where " + sbWhereCond.ToString();
                objDT = GetDataTable(strSQL);
                return objDT;
            }
            catch (Exception objException)
            {
                //'Log the error
                LogError(objException, "");
                //'Close the connection
                //'Throw a new exception
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
                //'                mobjConnection.Close()
            }
        }

        public DataTable ExecSpReturnDT(string sSPName, ArrayList paramValues)
        {

            //by davidfujian 2004-3-21 NOON
            //Exec a SP with long parameters and return a DataSet
            DataTable dt = new DataTable();
            OracleCommand sqlCmd;


            m_oConn = new OracleConnection(this.p_sConnectString);
            m_oConn.Open();
            sqlCmd = new OracleCommand(sSPName, m_oConn);
            sqlCmd.CommandText = sSPName;
            sqlCmd.Connection = m_oConn;
            sqlCmd.CommandType = CommandType.StoredProcedure;
            BuildParameters(sqlCmd, paramValues);

            OracleDataAdapter sqlDA = new OracleDataAdapter(sqlCmd);
            sqlDA.Fill(dt);

            return dt;

        }
        /// <summary>
        /// ��ȡ�����ķ����������ݿ������б�����
        /// </summary>
        /// <returns>���б�����DataTable</returns>
        public System.Data.DataTable getTableAndViewsBySp_Tables()
        {
            System.Data.DataTable objDT;
            string strSQL;
            //strSQL = "Select * from sysobjects where xtype='U' or  xtype='V' order by name";
            strSQL = "sp_tables";
            objDT = GetDataTable(strSQL);
            return objDT;
        }
        ///// <summary>
        ///// ��ȡ�����ķ����������ݿ������б�����
        ///// </summary>
        ///// <returns>���б�����DataTable</returns>
        //public System.Data.DataTable getTableAndViews()
        //{
        //    System.Data.DataTable objDT;
        //    string strSQL;
        //    strSQL = "Select * from sysobjects where xtype='U' or  xtype='V' order by name";
        //    //strSQL = "sp_tables";
        //    objDT = GetDataTable(strSQL);
        //    return objDT;
        //}
        /// <summary>
        /// ��ȡ�����ķ����������ݿ������б�����
        /// </summary>
        /// <returns>���б�����DataTable</returns>
        public bool IsExistColumnInTable(string strTabName, string strDataBaseOwner, string strColumnName)
        {

            DataTable objDT;
            try
            {
                StringBuilder sbWhereCond = new StringBuilder();
                sbWhereCond.Append(" 1=1 ");
                //����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
                if (string.IsNullOrEmpty(strDataBaseOwner) == false)
                {
                    sbWhereCond.AppendFormat(" And Owner = '{0}'", strDataBaseOwner);
                }
                if (string.IsNullOrEmpty(strTabName) == false)
                {
                    sbWhereCond.AppendFormat(" And Table_Name = '{0}'", strTabName);
                }
                if (string.IsNullOrEmpty(strColumnName) == false)
                {
                    sbWhereCond.AppendFormat(" And Column_Name = '{0}'", strColumnName);
                }

                string strSQL;
                strSQL = "Select concat(Owner, Table_name) As OwnerTable_Name, ALL_TAB_COLUMNS.* from ALL_TAB_COLUMNS where " + sbWhereCond.ToString();
                objDT = GetDataTable(strSQL);
                if (objDT.Rows.Count == 0)
                {
                    return false;
                }
                return true;
            }
            catch (Exception objException)
            {
                //'Log the error
                LogError(objException, "");
                //'Close the connection
                //'Throw a new exception
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
                //'                mobjConnection.Close()
            }
        }

        /// <summary>
        /// ��ȡ��ָ���ı����ֶ��Ƿ��ʶ�͡�
        /// </summary>
        /// <param name="strTabName">����</param>
        /// <param name="strDataBaseOwner">ӵ����</param>
        /// <param name="strColumnName">����</param>
        /// <returns>�����ͣ��ǣ���</returns>
        public bool IsIdentity(string strTabName, string strDataBaseOwner, string strColumnName)
        {
            System.Data.DataTable objDT;
            StringBuilder sbSQL = new StringBuilder();
            StringBuilder sbMsg = new StringBuilder();
            sbSQL.AppendFormat("SELECT COLUMNPROPERTY( OBJECT_ID('{0}.{1}'),'{2}','IsIdentity') AS 'IsIdentity'",
                        strDataBaseOwner,
                        strTabName,
                        strColumnName
                        );
            objDT = GetDataTable(sbSQL.ToString());
            if (objDT.Rows.Count == 0)
            {
                sbMsg.AppendFormat("�ڱ�{2}.{0}�У�����ֶ�{1}�Ƿ�Identity����",
                    strTabName, strColumnName, strDataBaseOwner);
                throw new Exception(sbMsg.ToString());
            }
            if (objDT.Rows.Count == 1)
            {
                string strTemp = objDT.Rows[0]["IsIdentity"].ToString();
                if (strTemp == "1") return true;
                else return false;
            }
            return false;

        }
        /// <summary>
        /// ��ȡ������
        /// </summary>
        /// <param name="strTabName">����</param>
        /// <returns>����б���DataTable��ʽ����</returns>
        public DataTable GetFKeys(string strTabName)
        {
            DataTable objDT;
            try
            {
                StringBuilder sbWhereCond = new StringBuilder();
                sbWhereCond.Append(" 1=1 ");
                //����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
                //if (string.IsNullOrEmpty(strDataBaseOwner) == false)
                //{
                //    sbWhereCond.AppendFormat(" And Owner = '{0}", strDataBaseOwner);
                //}
                if (string.IsNullOrEmpty(strTabName) == false)
                {
                    sbWhereCond.AppendFormat(" And Table_Name = '{0}'", strTabName);
                }

                StringBuilder sbSQL = new StringBuilder();
                clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
                sbSQL.Append("select   COLUMN_NAME   from   all_cons_columns   a,all_constraints   b   ");
                sbSQL.Append("  where   a.CONSTRAINT_NAME=b.CONSTRAINT_NAME   and   B.CONSTRAINT_TYPE='P'   ");
                sbSQL.AppendFormat("  AND   B.TABLE_NAME='{0}';  ", strTabName);
                objDT = objSQL.GetDataTable(sbSQL.ToString());
                return objDT;
            }
            catch (Exception objException)
            {
                //'Log the error
                LogError(objException, "");
                //'Close the connection
                //'Throw a new exception
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
                //'                mobjConnection.Close()
            }
        }

        /// <summary>
        /// ��ȡ���ݱ�������б�
        /// </summary>
        /// <param name="strTabName">����</param>
        /// <returns>�����б���ArrayList��ʽ����</returns>
        public ArrayList GetPKeys(string strTabName)
        {
            ArrayList arrKeys = new ArrayList();
            DataTable objDT;
            try
            {
                StringBuilder sbWhereCond = new StringBuilder();
                sbWhereCond.Append(" 1=1 ");
                //����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
                //if (string.IsNullOrEmpty(strDataBaseOwner) == false)
                //{
                //    sbWhereCond.AppendFormat(" And Owner = '{0}", strDataBaseOwner);
                //}
                if (string.IsNullOrEmpty(strTabName) == false)
                {
                    sbWhereCond.AppendFormat(" And Table_Name = '{0}'", strTabName);
                }

                StringBuilder sbSQL = new StringBuilder();

                sbSQL.Append("select COLUMN_NAME from user_cons_columns a,user_constraints b ");
                sbSQL.Append("  where a.CONSTRAINT_NAME=b.CONSTRAINT_NAME and B.CONSTRAINT_TYPE='P'");
                sbSQL.AppendFormat(" AND B.TABLE_NAME='{0}'", strTabName);
                objDT = GetDataTable(sbSQL.ToString());
                foreach (DataRow objRow in objDT.Rows)
                {
                    arrKeys.Add(objRow["COLUMN_NAME"].ToString());
                }
                return arrKeys;
            }
            catch (Exception objException)
            {
                //'Log the error
                LogError(objException, "");
                //'Close the connection
                //'Throw a new exception
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
                //'                mobjConnection.Close()
            }
        }

        /// <summary>
        /// ��ȡ������
        /// </summary>
        /// <param name="strTabName">����</param>
        /// <param name="strDataBaseOwner">ӵ����</param>
        /// <returns>����б���DataTable��ʽ����</returns>
        public DataTable GetFKeys(string strTabName, string strDataBaseOwner)
        {
            DataTable objDT;
            try
            {
                StringBuilder sbWhereCond = new StringBuilder();
                sbWhereCond.Append(" 1=1 ");
                //����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
                if (string.IsNullOrEmpty(strDataBaseOwner) == false)
                {
                    sbWhereCond.AppendFormat(" And Owner = '{0}", strDataBaseOwner);
                }
                if (string.IsNullOrEmpty(strTabName) == false)
                {
                    sbWhereCond.AppendFormat(" And Table_Name = '{0}'", strTabName);
                }

                StringBuilder sbSQL = new StringBuilder();
                clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
                sbSQL.Append("select   COLUMN_NAME   from   all_cons_columns   a,all_constraints   b   ");
                sbSQL.Append("  where   a.CONSTRAINT_NAME=b.CONSTRAINT_NAME   and   B.CONSTRAINT_TYPE='P'   ");
                sbSQL.AppendFormat("  AND   B.TABLE_NAME='{0}' ", strTabName);
                sbSQL.AppendFormat("  AND   B.Owner='{0}'; ", strDataBaseOwner);
                objDT = objSQL.GetDataTable(sbSQL.ToString());
                return objDT;
            }
            catch (Exception objException)
            {
                //'Log the error
                LogError(objException, "");
                //'Close the connection
                //'Throw a new exception
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
                //'                mobjConnection.Close()
            }
        }

        /// <summary>
        /// ��ȡ���ݱ�������б�
        /// </summary>
        /// <param name="strTabName">����</param>
        /// <param name="strDataBaseOwner">ӵ����</param>
        /// <returns>�����б���ArrayList��ʽ����</returns>
        public List<string> GetPKeys(string strTabName, string strDataBaseOwner)
        {
            List<string> arrKeys = new List<string>();
            DataTable objDT;
            try
            {
                StringBuilder sbWhereCond = new StringBuilder();
                sbWhereCond.Append(" 1=1 ");
                //����������ؼ������ݲ�Ϊ�գ������һ����������ӵ����������С�
                if (string.IsNullOrEmpty(strDataBaseOwner) == false)
                {
                    sbWhereCond.AppendFormat(" And Owner = '{0}", strDataBaseOwner);
                }
                if (string.IsNullOrEmpty(strTabName) == false)
                {
                    sbWhereCond.AppendFormat(" And Table_Name = '{0}'", strTabName);
                }

                StringBuilder sbSQL = new StringBuilder();
                clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
                sbSQL.Append("select   COLUMN_NAME   from   all_cons_columns   a,all_constraints   b   ");
                sbSQL.Append("  where   a.CONSTRAINT_NAME=b.CONSTRAINT_NAME   and   B.CONSTRAINT_TYPE='P'   ");
                sbSQL.AppendFormat("  AND   B.TABLE_NAME='{0}' ", strTabName);
                sbSQL.AppendFormat("  AND   B.Owner='{0}'; ", strDataBaseOwner);
                objDT = objSQL.GetDataTable(sbSQL.ToString());
                foreach (DataRow objRow in objDT.Rows)
                {
                    arrKeys.Add(objRow["COLUMN_NAME"].ToString());
                }
                return arrKeys;
            }
            catch (Exception objException)
            {
                //'Log the error
                LogError(objException, "");
                //'Close the connection
                //'Throw a new exception
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
                //'                mobjConnection.Close()
            }
        }

        /// <summary>
        /// ��ȡԼ��
        /// </summary>
        /// <param name="strTabName">����</param>
        /// <returns>Լ������DataTable��ʽ����</returns>
        public DataTable GetConstraint(string strTabName)
        {
            ArrayList ParaValueList = new ArrayList();
            DataTable objDT;
            mstrSPConfigXML = "<StoredProcedures><StoredProcedure name='sp_helpconstraint'> <Parameters> "
                + " <Parameter name='@objname' size='128' datatype='VarChar' direction='spParamInput' isNullable='True' /> "
                + "	<Parameter name='@nomsg' size='5' datatype='VarChar' direction='spParamInput' isNullable='True' /> "
                + " </Parameters></StoredProcedure></StoredProcedures>";
            ParaValueList.Clear();
            ParaValueList.Add(strTabName);
            ParaValueList.Add("nomsg");
            try
            {
                objDT = ExecSpReturnDT("sp_helpconstraint", ParaValueList);
                //'        objSQL = Nothing
                ParaValueList.Clear();
                return objDT;
            }
            catch (Exception objException)
            {
                //'Log the error
                LogError(objException, "");
                //'Close the connection
                //'Throw a new exception
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
                //'                mobjConnection.Close()
            }
        }

    }
}
