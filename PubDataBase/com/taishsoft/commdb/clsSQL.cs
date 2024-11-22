//����Ϊͨ�����ݲ㣬Ŀ��Ϊ�������ݿ�Ӧ�ó�����񣬼ȿ�������WEBӦ�ó���
//Ҳ������������Ӧ�ó���
//Ŀǰ�汾��V1.0��
//����ʱ�䣺2004��8��12��
//����޸��ߣ����Է�
//

using System;
using System.Collections;
using System.Data;
using System.Text;
using System.IO;
using System.Xml;
using System.Data.SqlClient;
using com.taishsoft.comm_db_obj;
using com.taishsoft.sql;
using com.taishsoft.syspara;
using com.taishsoft.common;
using com.taishsoft.resourse;
using System.Collections.Generic;
using com.taishsoft.comm_db_obj;
using com.taishsoft.syspara;
using com.taishsoft.sql;
using System.Diagnostics;

namespace com.taishsoft.commdb
{
    public class clsSQL
    {
        //Attributes
        public delegate void StateEventHandler(StateEventArgs e);
        public static event StateEventHandler OnChange;
        protected bool mblnDisposed = false;     //'�Ƿ��Ѿ��ͷŶ���(������������)
        protected string m_sSPConfigXMLFile;
        protected string mstrSPConfigXML;

        protected string m_sDatabase;
        protected string m_sServer;
        protected string m_sUid;
        protected string m_sPwd;
       
        protected string p_sConnectString;
        protected string p_sConnectString2="";
        protected System.Data.SqlClient.SqlConnection m_oConn;
        protected string mstrModuleName;
        protected string EXCEPTION_MSG = new clsResource().Property("s0001");// "SQL�����";    //there was an error in the method. please see the Application Log for details.";
        //Properties
        #region "Properties"

        public string SPConfigXMLFile
        {
            get
            {
                return this.m_sSPConfigXMLFile;
            }
            set
            {
                if (value != "" && this.m_sSPConfigXMLFile != value)
                    this.m_sSPConfigXMLFile = value;
            }
        }

        public string DataBase
        {
            get
            {
                return this.m_sDatabase;
            }
            set
            {
                if (value != "" && this.m_sDatabase != value)
                    this.m_sDatabase = value;
            }
        }

        public string Server
        {
            get
            {
                return this.m_sServer;
            }
            set
            {
                if (value != "" && this.m_sServer != value)
                    this.m_sServer = value;
            }
        }

        public string UserID
        {
            get
            {
                return this.m_sUid;
            }
            set
            {
                if (value != "" && this.m_sUid != value)
                    this.m_sUid = value;
            }
        }

        public string Password
        {
            get
            {
                return this.m_sPwd;
            }
            set
            {
                if (value != "" && this.m_sPwd != value)
                    this.m_sPwd = value;
            }
        }

        public string ConnectionString
        {
            get
            {
                return this.p_sConnectString;
            }
            set
            {
                if (value != "" && this.p_sConnectString != value)
                    this.p_sConnectString = value;
            }
        }

        #endregion


        //Methods
        #region "Methods"
        private string GetConnectString()
        {
            //by davidfujian (��˳��)
            //2004-2-28 Night
            //��������ַ���
            p_sConnectString = "";
            p_sConnectString = "server=" + this.m_sServer + ";";
            p_sConnectString = p_sConnectString + "database=" + this.m_sDatabase + ";";
            p_sConnectString = p_sConnectString + "uid=" + this.m_sUid + ";";
            p_sConnectString = p_sConnectString + "pwd=" + this.m_sPwd + ";";
            return p_sConnectString;
        }
        public SqlConnection getConnectObj(string strConnectString)
        {
            SqlConnection objSqlConnect = null;
            try
            {
                objSqlConnect = new SqlConnection(strConnectString);
                objSqlConnect.Open();
                return objSqlConnect;
            }
            catch (Exception objException)
            {
                objSqlConnect.Dispose();
                objSqlConnect = null;
                LogError(objException, "������ʧ��!");
          
               
                StringBuilder sbMessage = new StringBuilder();
                sbMessage.Append(objException.Message);
                sbMessage.Append("\r\n");
                sbMessage.Append("������ʧ��!�������Ӵ�!\r\n");
                string[] strItems = strConnectString.Split(';');
                foreach (string strItem in strItems)
                {
                    string[] strKeyValue = strItem.Split('=');
                    if (strKeyValue[0].Equals("server", StringComparison.CurrentCultureIgnoreCase) == true)
                    {
                        m_sServer = strKeyValue[1];
                    }
                    else if (strKeyValue[0].Equals("database", StringComparison.CurrentCultureIgnoreCase) == true)
                    {
                        m_sDatabase = strKeyValue[1];
                    }
                    else if (strKeyValue[0].Equals("uid", StringComparison.CurrentCultureIgnoreCase) == true)
                    {
                        m_sUid = strKeyValue[1];
                    }
                }
                if (string.IsNullOrEmpty(m_sServer) == false)
                {
                    sbMessage.AppendFormat("�򿪵ķ�������{0}��\r\n���ݿ⣺{1}��", //��\r\n�û�����{2}��",
                        m_sServer,
                        m_sDatabase,
                        m_sUid);
                }
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    string strMsg = string.Format("����{0}. Sql��䣺{1}", objException.Message, sbMessage.ToString());
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                        intCurrLevel++;
                        if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                    }
                    clsDebugBase_Sql.WriteLog(strMsg);
                }
                //				sbMessage.Append("������ʧ��!�������Ӵ�!");
                throw new Exception(sbMessage.ToString(), objException);
                //				dtTab=new DataTable();
                //				return dtTab;	
            }
            //finally
            //{
            //}
        }
        //��̬�Ĵ��������־�ĺ���
        public static void LogErrorS(Exception objException, string strModuleName)
        {
            //Log the error information to the Application Log
            string strLogMsg;
            try
            {
                strLogMsg = "An error occurred in the following module: "
                    + strModuleName + "Source: " + objException.Source

                    + "Message: " + objException.Message
                    + "Stack Trace:  " + objException.StackTrace

                    + "Target Site:  " + objException.TargetSite.ToString();

                //Write error to event log
                System.Diagnostics.EventLog.WriteEntry(strModuleName, strLogMsg, System.Diagnostics.EventLogEntryType.Error);
            }
            catch
            {
            }
        }
        public static SqlConnection getConnectObj_S(string strConnectString)
        {
            SqlConnection objSqlConnect = null;
            try
            {
                objSqlConnect = new SqlConnection(strConnectString);
                objSqlConnect.Open();
                return objSqlConnect;
            }
            catch (Exception objException)
            {
                objSqlConnect.Dispose();
                objSqlConnect = null;
                LogErrorS(objException, "������ʧ��!");
             
                StringBuilder sbMessage = new StringBuilder();
                sbMessage.Append(objException.Message);
                sbMessage.Append("\r\n");
                sbMessage.Append("������ʧ��!�������Ӵ�!\r\n");
                string m_sDatabase = "";
                string m_sServer = "";
                string m_sUid= "";
                //string m_sPwd;
                string[] strItems = strConnectString.Split(';');
                foreach (string strItem in strItems)
                {
                    string[] strKeyValue = strItem.Split('=');
                    if (strKeyValue[0].Equals("server", StringComparison.CurrentCultureIgnoreCase) == true)
                    {
                        m_sServer = strKeyValue[1];
                    }
                    else if (strKeyValue[0].Equals("database", StringComparison.CurrentCultureIgnoreCase) == true)
                    {
                        m_sDatabase = strKeyValue[1];
                    }
                    else if (strKeyValue[0].Equals("uid", StringComparison.CurrentCultureIgnoreCase) == true)
                    {
                        m_sUid = strKeyValue[1];
                    }
                }
                if (string.IsNullOrEmpty(m_sServer) == false)
                {
                    sbMessage.AppendFormat("�򿪵ķ�������{0}��\r\n���ݿ⣺{1}��", //��\r\n�û�����{2}��",
                        m_sServer,
                        m_sDatabase,
                        m_sUid);
                }
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    string strMsg = string.Format("����{0}. Sql��䣺{1}", objException.Message, sbMessage.ToString());
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                        intCurrLevel++;
                        if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                    }
                    clsDebugBase_Sql.WriteLog(strMsg);
                }
                //				sbMessage.Append("������ʧ��!�������Ӵ�!");
                throw new Exception(sbMessage.ToString(), objException);
                //				dtTab=new DataTable();
                //				return dtTab;	
            }
            finally
            {
            }
        }
        /// <summary>
        /// ���ܣ���ȡ������ļ�¼��.
        /// </summary>
        /// <param name="strTabName">�������ı���</param>
        /// <returns>��¼����Ϊ����</returns>
        public int GetRecCount(string strTabName)
        {
            //by davidfujian 
            //2004-7-24 Night
            //��ò����ر�
            SqlCommand sqlCmd;
            int intRecCount;
            string strSQL;
            strSQL = "select count(*) from " + strTabName;
          

            m_oConn = getConnectObj(this.p_sConnectString);
            try
            {
                sqlCmd = new SqlCommand();
                sqlCmd.Connection = m_oConn;
                sqlCmd.CommandType = CommandType.Text;

                sqlCmd.CommandTimeout = 9600;
                sqlCmd.CommandText = strSQL;
                intRecCount = (int)sqlCmd.ExecuteScalar();//��ü�¼����
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    SqlStatement objSqlStatementEN = null;
                    try
                    {
                        objSqlStatementEN = SqlStatementAC.AnalysisSqlStatement(strSQL);
                        string strMsg = SqlStatementAC.GetSqlStatementAnalysisInfo(objSqlStatementEN, intRecCount);
                        //s1trMsg += string.Format("|�ײ㺯��:[funGetRecCount]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("����{0}|Sql���:[{1}]", objException.Message, strSQL);
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }

                }
                //				m_oConn.CloseB();		
                return intRecCount;
            }
            catch (Exception objException)
            {
                LogError(objException, "");
           
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    string strMsg = string.Format("����{0}. Sql��䣺{1}", objException.Message, strSQL);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                        intCurrLevel++;
                        if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                    }
                    clsDebugBase_Sql.WriteLog(strMsg);
                }
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
            }
            finally
            {
                m_oConn.Close();
            }
        }
        /// <summary>
        /// ���ܣ���ȡ�����������������ļ�¼��
        /// </summary>
        /// <param name="strTabName">�������ı���</param>
        /// <param name="strCondtion">�������ļ�¼����</param>
        /// <returns>��¼����Ϊ����</returns>
        public int GetRecCount(string strTabName, string strCondtion)
        {
        
            SqlCommand sqlCmd;
            int intRecCount;
            StringBuilder strSQL = new StringBuilder();
            strSQL.AppendFormat("select count(*) from {0} where {1}", strTabName, strCondtion);
            

            m_oConn = getConnectObj(this.p_sConnectString);
            try
            {
                sqlCmd = new SqlCommand();
                sqlCmd.Connection = m_oConn;
                sqlCmd.CommandType = CommandType.Text;

                sqlCmd.CommandTimeout = 9600;
                sqlCmd.CommandText = strSQL.ToString();
                intRecCount = (int)sqlCmd.ExecuteScalar();//��ü�¼����
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    SqlStatement objSqlStatementEN = null;
                    try
                    {
                        objSqlStatementEN = SqlStatementAC.AnalysisSqlStatement(strSQL.ToString());
                        string strMsg = SqlStatementAC.GetSqlStatementAnalysisInfo(objSqlStatementEN, intRecCount);
                        //s1trMsg += string.Format("|�ײ㺯��:[funGetRecCount]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("����{0}|Sql���:[{1}]|�ײ㺯��:[funGetRecCount]",
                            objException.Message, strSQL);
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                }
               
                //				m_oConn.CloseB();		
                return intRecCount;
            }
            catch (Exception objException)
            {
                LogError(objException, "");
    
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    string strMsg = string.Format("����{0}. Sql��䣺{1}", objException.Message, strSQL.ToString());
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                        intCurrLevel++;
                        if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                    }
                    clsDebugBase_Sql.WriteLog(strMsg);
                }
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
            }
            finally
            {
                m_oConn.Close();
            }

        }

        public clsSQL(string server, string database, string uid, string pwd)
        {
            mstrModuleName = this.GetType().ToString();
            m_sServer = server;
            m_sDatabase = database;
            m_sUid = uid;
            m_sPwd = pwd;
            p_sConnectString = GetConnectString();
            //clsSpecSQLforSql.strConnectString = p_sConnectString;
        }

        public clsSQL()
        {
            mstrSPConfigXML = "";
            mstrModuleName = this.GetType().ToString();
        }

        public clsSQL(string sconnectString)
        {
            //by davidfujian (��˳��)
            //2004-2-28 Night
            //�Ӳ����л�������ַ���
            mstrSPConfigXML = "";
            mstrModuleName = this.GetType().ToString();
            this.p_sConnectString = sconnectString;
        }
        /// <summary>
        /// ����Sql��䣬��ȡDataTable
        /// </summary>
        /// <param name="strSql">Sql���</param>
        /// <returns>��ȡ��DataTable</returns>
        public DataTable GetDataTable(string strSql)
        {
            //by davidfujian (��˳��)
            //2004-2-28 Night
            //��ò����ر�
          
            SqlCommand sqlCmd;
            SqlDataAdapter sqlAdp;
            DataTable dtTab;
            m_oConn = getConnectObj(this.p_sConnectString);
            try
            {
                sqlCmd = new SqlCommand();
                sqlCmd.Connection = m_oConn;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = strSql;
                sqlCmd.CommandTimeout = 9600;
                sqlAdp = new SqlDataAdapter();
                sqlAdp.SelectCommand = sqlCmd;
                dtTab = new DataTable();
                sqlAdp.Fill(dtTab);
               
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    SqlStatement objSqlStatementEN = null;
                    try
                    {
                        objSqlStatementEN = SqlStatementAC.AnalysisSqlStatement(strSql);
                        string strMsg = SqlStatementAC.GetSqlStatementAnalysisInfo(objSqlStatementEN, dtTab.Rows.Count);
                        //s1trMsg += string.Format("|�ײ㺯��:[GetDataTable]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("����{0}|Sql���:[{1}]|�ײ㺯��:[GetDataTable]", objException.Message, strSql);
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }

                }

                //m_oConn.CloseB();
                return dtTab;
            }
            catch (Exception objException)
            {
                System.Console.Out.WriteLine("strSql = " + strSql);
                LogError(objException, strSql);

                if (clsDebugBase_Sql.IsDebug == true)
                {
                    string strMsg = string.Format("����{0}. Sql��䣺{1}", objException.Message, strSql);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                        intCurrLevel++;
                        if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                    }
                    clsDebugBase_Sql.WriteLog(strMsg);
                }
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
       
            }
            finally
            {
                m_oConn.Close();
            }
        }

        /// <summary>
        /// ����������ȡ��ҳ��¼�����ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����
        /// </summary>
        /// <param name = "strTabName">����</param>
        /// <param name = "strKeyFldName">��ؼ���</param>
        /// <param name = "intPageIndex">ҳ���</param>
        /// <param name = "intPageSize">ҳ��¼��</param>
        /// <param name = "strCondition">������</param>
        /// <param name = "strOrderBy">����ʽ</param>
        /// <returns>�������ݱ�DataTable</returns>
        public System.Data.DataTable GetDataTableByPager(string strTabName, string strKeyFldName, int intPageIndex, int intPageSize, string strCondition, string strOrderBy)
        {
            try
            {
                clsCheckSql.CheckStrSQL_Weak(strCondition);
                strCondition = clsString.RemoveElementValue(strCondition, "Exclude");
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("(errid:Data000024)�ڷ�ҳ��ѯ�����������к���{0},����!(clsAppCodeTypeRelaDA: GetDataTableByPager)", objException.Message));
            }
            string strSQL;
            System.Data.DataTable objDT;

            int intTop_In = intPageSize * (intPageIndex - 1);
            if (string.IsNullOrEmpty(strOrderBy) == true)
            {
                strSQL = string.Format("Select Top {0} * from {3} where {1} and {4} not in (Select top {2} {4} from {3} where {1}) ", 
                    intPageSize, strCondition, intTop_In, strTabName, strKeyFldName);
            }
            else
            {
                strSQL = string.Format("Select Top {0} * from {4} where {1} and {5} not in (Select top {3} {5} from {4} where {1} order by {2}) order by {2} ", 
                    intPageSize, strCondition, strOrderBy, intTop_In, strTabName, strKeyFldName);
            }
            objDT = this.GetDataTable(strSQL);
            return objDT;
        }

        /// <summary>
        /// ����������ȡ������¼�����ݱ�,��DataTable��ʾ,ͬʱ����Ƿ���SQL����-�����
        /// </summary>
        /// <param name = "strTabName">����</param>
        /// <param name = "intTopSize">������¼��</param>
        /// <param name = "strCondition">������</param>
        /// <param name = "strOrderBy">����ʽ</param>
        /// <returns>�������ݱ�DataTable</returns>
        public System.Data.DataTable GetDataTableByTop(string strTabName, int intTopSize, string strCondition, string strOrderBy)
        {
            try
            {
                clsCheckSql.CheckStrSQL_Weak(strCondition);
                strCondition = clsString.RemoveElementValue(strCondition, "Exclude");
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("(errid:Data000024)�ڷ�ҳ��ѯ�����������к���{0},����!(clsAppCodeTypeRelaDA: GetDataTableByPager)", objException.Message));
            }
            string strSQL;
            System.Data.DataTable objDT;

            if (string.IsNullOrEmpty(strOrderBy) == true)
            {
                strSQL = string.Format("Select Top {0} * from {2} where {1} ",
                    intTopSize, strCondition, strTabName);
            }
            else
            {
                strSQL = string.Format("Select Top {0} * from {3} where {1} order by {2} ",
                    intTopSize, strCondition, strOrderBy, strTabName);
            }
            objDT = this.GetDataTable(strSQL);
            return objDT;
        }


        /// <summary>
        /// ���ݹؼ���ֵ��ȡ���ݱ��е�һ����¼,��DataTable��ʾ
        /// </summary>
        /// <param name = "strTabName">����</param>
        /// <param name = "strKeyFldName">��ؼ���</param>
        /// <param name = "strKeyValue">�ؼ���ֵ</param>
        /// <param name = "bolIsNumurable">�Ƿ���ֵ��</param>
        /// <returns>�������ݱ�DataTable</returns>
        public System.Data.DataTable GetDataTableByKey(string strTabName, string strKeyFldName, string strKeyValue, bool bolIsNumurable)
        {
            string strSQL;
            System.Data.DataTable objDT;
            
            if (bolIsNumurable == true)
            {
                strSQL = string.Format("Select  * from {0} where {1}={2}",
                    strTabName, strKeyFldName, strKeyValue);
            }
            else
            {
                strSQL = string.Format("Select  * from {0} where {1}='{2}'",
                    strTabName, strKeyFldName, strKeyValue);
            }
            objDT = this.GetDataTable(strSQL);
            return objDT;
        }


        /// <summary>
        /// ����Sql��䣬��ȡDataTable
        /// </summary>
        /// <param name="strSql">Sql���</param>
        /// <param name="objSqlConnect"></param>
        /// <param name="objSqlTransaction"></param>
        /// <returns>��ȡ��DataTable</returns>
        public DataTable GetDataTable(string strSql, SqlConnection objSqlConnect, SqlTransaction objSqlTransaction)
        {
          
            SqlCommand sqlCmd;
            SqlDataAdapter sqlAdp;
            DataTable dtTab;
            try
            {
                sqlCmd = new SqlCommand();
                sqlCmd.Connection = objSqlConnect;
                sqlCmd.Transaction = objSqlTransaction;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = strSql;
                sqlCmd.CommandTimeout = 9600;
                sqlAdp = new SqlDataAdapter();
                sqlAdp.SelectCommand = sqlCmd;
                dtTab = new DataTable();
                sqlAdp.Fill(dtTab);
             
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    SqlStatement objSqlStatementEN = null;
                    try
                    {
                        objSqlStatementEN = SqlStatementAC.AnalysisSqlStatement(strSql);
                        string strMsg = SqlStatementAC.GetSqlStatementAnalysisInfo(objSqlStatementEN,  dtTab.Rows.Count);
                        //s1trMsg += string.Format("|�ײ㺯��:[GetDataTable]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("����{0}|Sql���:[{1}]|�ײ㺯��:[GetDataTable]", objException.Message, strSql);
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                }
                return dtTab;
            }
            catch (Exception objException)
            {
                System.Console.Out.WriteLine("strSql = " + strSql);
                LogError(objException, strSql);
          
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    string strMsg = string.Format("����{0}. Sql��䣺{1}", objException.Message, strSql);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                        intCurrLevel++;
                        if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                    }
                    clsDebugBase_Sql.WriteLog(strMsg);
                }
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
                //				dtTab=new DataTable();
                //				return dtTab;	
            }
            finally
            {
            }
        }

        /// <summary>
        /// ����Sql��䣬 ��ȡDataTable
        /// </summary>
        /// <param name="strSql">Sql���</param>
        /// <param name="strTabName">����</param>
        /// <returns>��ȡ��DataTable</returns>
        public DataTable GetDataTable(string strSql, string strTabName)
        {
          
            SqlCommand sqlCmd;
            SqlDataAdapter sqlAdp;
            DataSet objDS = null;
            DataTable dtTab = null;
            m_oConn = getConnectObj(this.p_sConnectString);
            try
            {
                sqlCmd = new SqlCommand();
                sqlCmd.Connection = m_oConn;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = strSql;
                sqlCmd.CommandTimeout = 9600;
                sqlAdp = new SqlDataAdapter();
                sqlAdp.SelectCommand = sqlCmd;

                sqlAdp.Fill(objDS, strTabName);

                dtTab = objDS.Tables[strTabName];
                
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    SqlStatement objSqlStatementEN = null;
                    try
                    {
                        objSqlStatementEN = SqlStatementAC.AnalysisSqlStatement(strSql);
                        string strMsg = SqlStatementAC.GetSqlStatementAnalysisInfo(objSqlStatementEN, dtTab.Rows.Count);
                        //s1trMsg += string.Format("|�ײ㺯��:[GetDataTable]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("����{0}|Sql���:[{1}]|�ײ㺯��:[GetDataTable]", objException.Message, strSql);
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                }
                return dtTab;
            }
            catch (Exception objException)
            {
                System.Console.Out.WriteLine("strSql = " + strSql);
                LogError(objException, strSql);
          
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    string strMsg = string.Format("����{0}. Sql��䣺{1}", objException.Message, strSql);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                        intCurrLevel++;
                        if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                    }
                    clsDebugBase_Sql.WriteLog(strMsg);
                }

                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
                //				dtTab=new DataTable();
                //				return dtTab;	
            }
            finally
            {
                m_oConn.Close();
            }
        }
        /// <summary>
        /// ��ȡDataTable����XML�ļ���ʽ���
        /// </summary>
        /// <param name="strSql">Sql���</param>
        /// <param name="strTabName">����</param>
        /// <param name="strXmlFileName">�����XML�ļ���</param>
        /// <returns>�Ƿ�ɹ���</returns>
        public bool GetDataTableXml(string strSql, string strTabName, string strXmlFileName)
        {
          
            SqlCommand sqlCmd;
            SqlDataAdapter sqlAdp;
            DataSet objDS = null;
            DataTable dtTab = null;
            m_oConn = getConnectObj(this.p_sConnectString);
            try
            {
                sqlCmd = new SqlCommand();
                sqlCmd.Connection = m_oConn;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = strSql;
                sqlCmd.CommandTimeout = 9600;
                sqlAdp = new SqlDataAdapter();
                sqlAdp.SelectCommand = sqlCmd;
                objDS = new DataSet();
                sqlAdp.Fill(objDS, strTabName);

                dtTab = objDS.Tables[strTabName];
                
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    SqlStatement objSqlStatementEN = null;
                    try
                    {
                        objSqlStatementEN = SqlStatementAC.AnalysisSqlStatement(strSql);
                        string strMsg = SqlStatementAC.GetSqlStatementAnalysisInfo(objSqlStatementEN, dtTab.Rows.Count);
                        //s1trMsg += string.Format("|�ײ㺯��:[GetDataTableXml]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("����{0}|Sql���:[{1}]|�ײ㺯��:[GetDataTableXml]", objException.Message, strSql);
                       
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                }
                dtTab.WriteXml(strXmlFileName, XmlWriteMode.WriteSchema);
                //m_oConn.CloseB();
                return true;
            }
            catch (Exception objException)
            {
                System.Console.Out.WriteLine("strSql = " + strSql);
                LogError(objException, strSql);
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    string strMsg = string.Format("����{0}. Sql��䣺{1}", objException.Message, strSql);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                        intCurrLevel++;
                        if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                    }
                    clsDebugBase_Sql.WriteLog(strMsg);
                }
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
              
            }
            finally
            {
                m_oConn.Close();
            }
        }
        /// <summary>
        /// ��ȡDataTable����XML�ļ���ʽ���
        /// </summary>
        /// <param name="objTable_SqlCommandText">Sql���</param>
        /// <param name="strXmlFileName">�����XML�ļ���</param>
        /// <returns>�Ƿ�ɹ���</returns>
        public bool GetDataTableXml(clsTable_SqlCommandText objTable_SqlCommandText, string strXmlFileName)
        {
           
            SqlCommand sqlCmd;
            SqlDataAdapter sqlAdp;
            DataSet objDS = null;
            DataTable dtTab = null;
            m_oConn = getConnectObj(this.p_sConnectString);
            try
            {
                sqlCmd = new SqlCommand();
                sqlCmd.Connection = m_oConn;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = objTable_SqlCommandText.SqlCommandText;
                sqlCmd.CommandTimeout = 9600;
                sqlAdp = new SqlDataAdapter();
                sqlAdp.SelectCommand = sqlCmd;
                objDS = new DataSet();
                sqlAdp.Fill(objDS, objTable_SqlCommandText.TableName);

                dtTab = objDS.Tables[objTable_SqlCommandText.TableName];
               
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    SqlStatement objSqlStatementEN = null;
                    try
                    {
                        objSqlStatementEN = SqlStatementAC.AnalysisSqlStatement(objTable_SqlCommandText.SqlCommandText);
                        string strMsg = SqlStatementAC.GetSqlStatementAnalysisInfo(objSqlStatementEN, dtTab.Rows.Count);
                        //s1trMsg += string.Format("|�ײ㺯��:[GetDataTableXml]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("����{0}|Sql���:[{1}]|�ײ㺯��:[GetDataTableXml]", objException.Message, objTable_SqlCommandText.SqlCommandText);
                         
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                }
                dtTab.WriteXml(strXmlFileName, XmlWriteMode.WriteSchema);
                //m_oConn.CloseB();
                return true;
            }
            catch (Exception objException)
            {
                System.Console.Out.WriteLine("strSql = " + objTable_SqlCommandText.SqlCommandText);
                LogError(objException, objTable_SqlCommandText.SqlCommandText);
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    string strMsg = string.Format("����{0}. Sql��䣺{1}", objException.Message, objTable_SqlCommandText.SqlCommandText);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                        intCurrLevel++;
                        if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                    }
                    clsDebugBase_Sql.WriteLog(strMsg);
                }
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
                //				dtTab=new DataTable();
                //				return dtTab;	
            }
            finally
            {
                m_oConn.Close();
            }
        }

        public DataTable GetDataTable(string strSql, int intStartRec, int intEndRec)
        {
            //by davidfujian (��˳��)
            //2004-2-28 Night
            //��ò����ر�

            SqlCommand sqlCmd;
            SqlDataAdapter sqlAdp;
            m_oConn = getConnectObj(this.p_sConnectString);
            try
            {

                sqlCmd = new SqlCommand();
                sqlCmd.Connection = m_oConn;
                sqlCmd.CommandType = CommandType.Text;

                sqlCmd.CommandTimeout = 9600;
                sqlCmd.CommandText = strSql;

                sqlAdp = new SqlDataAdapter();
                sqlAdp.SelectCommand = sqlCmd;
                DataSet objDS = new DataSet();
                sqlAdp.Fill(objDS, intStartRec, intEndRec, "ds");
              
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    SqlStatement objSqlStatementEN = null;
                    try
                    {
                        objSqlStatementEN = SqlStatementAC.AnalysisSqlStatement(strSql);
                        string strMsg = SqlStatementAC.GetSqlStatementAnalysisInfo(objSqlStatementEN,  objDS.Tables["ds"].Rows.Count);
                        strMsg += string.Format("|intStartRec:[{0}]|intEndRec:[{1}]",
                             intStartRec, intEndRec);
                        //s1trMsg += string.Format("|�ײ㺯��:[funGetRecCount]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("����{0}|Sql���:[{3}]|intStartRec:[{1}]|intEndRec:[{2}]",
                            objException.Message, intStartRec, intEndRec, strSql);
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }

                }
                return objDS.Tables["ds"];
            }
            catch (Exception objException)
            {
                LogError(objException, strSql);
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    string strMsg = string.Format("����{0}. Sql��䣺{1}", objException.Message, strSql);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                        intCurrLevel++;
                        if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                    }
                    clsDebugBase_Sql.WriteLog(strMsg);
                }
                throw objException; ;// throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
                //				dtTab=new DataTable();
                //				return dtTab;	
            }

            finally
            {
                m_oConn.Close();
            }
        }


        /// <summary>
        /// ���ܣ���ȡһ��DataSet�������DataTable
        /// </summary>
        /// <param name="sql">���SQL����</param>
        /// <returns>���ذ������DataTable��DataSet</returns>
        public DataSet GetSqlTables(ArrayList sql)
        {

            SqlCommand sqlCmd = null;
            SqlDataAdapter sqlAdp;
            DataSet dtSet = new DataSet();
            m_oConn = getConnectObj(this.p_sConnectString);
            try
            {
                sqlCmd = new SqlCommand();
                sqlCmd.Connection = m_oConn;

                for (int i = 0; i < sql.Count; i++)
                {
                   
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.CommandText = sql[i].ToString();

                    sqlCmd.CommandTimeout = 9600;
                    sqlAdp = new SqlDataAdapter();
                    sqlAdp.SelectCommand = sqlCmd;

                    sqlAdp.Fill(dtSet, i.ToString());
                    if (clsDebugBase_Sql.IsDebug == true)
                    {
                        SqlStatement objSqlStatementEN = null;
                        try
                        {
                            objSqlStatementEN = SqlStatementAC.AnalysisSqlStatement(sql[i].ToString());
                            string strMsg = SqlStatementAC.GetSqlStatementAnalysisInfo(objSqlStatementEN, dtSet.Tables[i].Rows.Count);
                            //s1trMsg += string.Format("|�ײ㺯��:[GetSqlTables]");
                            StackTrace trace = new StackTrace();
                            int intCurrLevel = 0;
                            foreach (StackFrame frame in trace.GetFrames())
                            {
                                string strFileName = frame.GetFileName();
                                string strMothodName = frame.GetMethod().Name;
                                if (frame.GetMethod().DeclaringType == null) break;
                                string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                                strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                                intCurrLevel++;
                                if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                            }
                            clsDebugBase_Sql.WriteLog(strMsg);
                        }
                        catch (Exception objException)
                        {
                            string strMsg = string.Format("����{0}|Sql���:[{1}]|�ײ㺯��:[GetSqlTables]",
                                objException.Message, sql[i].ToString());
                            clsDebugBase_Sql.WriteLog(strMsg);
                        }
                    }
                }
                return dtSet;
            }

            catch (Exception objException)
            {
                LogError(objException, "");
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    string strMsg = string.Format("����{0}. Sql��䣺{1}", objException.Message, sqlCmd.CommandText);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                        intCurrLevel++;
                        if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                    }
                    clsDebugBase_Sql.WriteLog(strMsg);
                }
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
                //				dtSet=new DataSet();
                //				return dtSet;
            }
            finally
            {
                m_oConn.Close();
            }
        }
        /// <summary>
        /// ��ȡSqlDataReader
        /// </summary>
        /// <param name="strSql">Sql���</param>
        /// <returns>SqlDataReader</returns>
        private SqlDataReader GetSqlDataReader(string strSql)
        {
            if (clsDebugBase_Sql.IsDebug == true)
            {
                SqlStatement objSqlStatementEN = null;
                try
                {
                    objSqlStatementEN = SqlStatementAC.AnalysisSqlStatement(strSql);
                    string strMsg = SqlStatementAC.GetSqlStatementAnalysisInfo(objSqlStatementEN, -1);
                    //s1trMsg += string.Format("|�ײ㺯��:[GetSqlDataReader]");
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                        intCurrLevel++;
                        if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                    }
                    clsDebugBase_Sql.WriteLog(strMsg);
                }
                catch (Exception objException)
                {
                    string strMsg = string.Format("����{0}|Sql���:[{1}]|�ײ㺯��:[GetDataTableXml]",
                        objException.Message, strSql);
                    clsDebugBase_Sql.WriteLog(strMsg);
                }
            }
            SqlCommand sqlCmd;
            System.Data.SqlClient.SqlDataReader dtRedr;
            m_oConn = getConnectObj(this.p_sConnectString);
            try
            {
                sqlCmd = new SqlCommand();
                sqlCmd.Connection = m_oConn;
                sqlCmd.CommandType = CommandType.Text;

                sqlCmd.CommandTimeout = 9600;
                sqlCmd.CommandText = strSql;
                dtRedr = sqlCmd.ExecuteReader();
                return dtRedr;
            }
            catch (Exception objException)
            {
                LogError(objException, "");
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    string strMsg = string.Format("����{0}. Sql��䣺{1}", objException.Message, strSql);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                        intCurrLevel++;
                        if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                    }
                    clsDebugBase_Sql.WriteLog(strMsg);
                }
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
                //				return null;
            }
            finally
            {
                m_oConn.Close();
            }

        }
        /// <summary>
        /// ���ܣ�	��ȡĳ���е�һ������������ĳ�ֶε�ֵ
        /// </summary>
        /// <param name="strTableName">����</param>
        /// <param name="strFieldName">�ֶ���</param>
        /// <param name="WhereConditionString">������</param>
        /// <returns>��һ���ֶ�ֵ</returns>
        public string GetFirstFldValueOfTable(string strTableName,
            string strFieldName,
            string WhereConditionString)
        {
            //��ò����ر�
            SqlCommand sqlCmd;
            SqlDataAdapter sqlAdp;
            DataTable objDT;
            ArrayList arrList = new ArrayList();
            string strKeyValue;
            string strSQL;
            //																						  '��֯SQL��
            if (WhereConditionString != "")
            {
                WhereConditionString = " where " + WhereConditionString;
            }
            strSQL = "select " + strFieldName + " from " + strTableName + WhereConditionString;
           

            m_oConn = getConnectObj(this.p_sConnectString);
            try
            {
                sqlCmd = new SqlCommand();
                sqlCmd.Connection = m_oConn;
                sqlCmd.CommandType = CommandType.Text;

                sqlCmd.CommandTimeout = 9600;
                sqlCmd.CommandText = strSQL;
                sqlAdp = new SqlDataAdapter();
                sqlAdp.SelectCommand = sqlCmd;
                objDT = new DataTable();
                sqlAdp.Fill(objDT);
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    SqlStatement objSqlStatementEN = null;
                    try
                    {
                        objSqlStatementEN = SqlStatementAC.AnalysisSqlStatement(strSQL);
                        string strMsg = SqlStatementAC.GetSqlStatementAnalysisInfo(objSqlStatementEN, objDT.Rows.Count);
                        //s1trMsg += string.Format("|�ײ㺯��:[GetFirstFldValueOfTable]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("����{0}|Sql���:[{1}]|�ײ㺯��:[GetFirstFldValueOfTable]",
                            objException.Message, strSQL);
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                }
                //m_oConn.CloseB();
            }
            catch (Exception objException)
            {
                LogError(objException, strSQL);
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    string strMsg = string.Format("����{0}. Sql��䣺{1}", objException.Message, strSQL);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                        intCurrLevel++;
                        if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                    }
                    clsDebugBase_Sql.WriteLog(strMsg);
                }
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
                //				return null;
            }

            finally
            {
                m_oConn.Close();
            }
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return "";
            }
            strKeyValue = objDT.Rows[0][0].ToString();
            objDT = null;
            return strKeyValue;
        }
        /// <summary>
        /// ���ܣ�	��ȡĳ���з���������ĳ�ֶε�ֵ
        /// </summary>
        /// <param name="strTableName">����</param>
        /// <param name="strFieldName">�ֶ���</param>
        /// <param name="WhereConditionString">������</param>
        /// <returns>�б�</returns>
        public List<string> GetFldDataOfTable(string strTableName,
            string strFieldName,
            string WhereConditionString)
        {
            string strWhere = WhereConditionString.ToLower();
            strWhere = strWhere.Replace("  " ," ");
            strFieldName = strFieldName.ToLower();
            strFieldName = strFieldName.Replace("distinct", "");
            if (strWhere.IndexOf("order by") >= 0)
            {
                strWhere = strWhere.Replace("order by", "");
                strWhere = strWhere.Replace(strFieldName.ToLower(), "");
                strWhere = strWhere.Replace(" ", "");
                if (strWhere.Length > 0)
                {
                    string strSQL1 = "select distinct " + strFieldName + " from " + strTableName + WhereConditionString;
                    StringBuilder sbMsg = new StringBuilder();
                    sbMsg.AppendFormat("�ں���funGetFldDataOfTable�У�SQL��䣺{0}�к��У�distinct��ͬʱ��Order By����Order By�г����ֶ�{1}���ֶ�{2}��",
                                    strSQL1,
                                    strFieldName,
                                    strWhere);
                    throw new Exception(sbMsg.ToString());
                }
            }
            //��ò����ر�
            SqlCommand sqlCmd;
            SqlDataAdapter sqlAdp;
            DataTable objDT;
            List<string> arrList = new List<string>();
            int iRow, iCol;
            string strKeyValue;
            string strSQL;
            //																						  '��֯SQL��
            if (WhereConditionString != "")
            {
                WhereConditionString = " where " + WhereConditionString;
            }
            strSQL = "select distinct " + strFieldName + " from " + strTableName + WhereConditionString;
           
            m_oConn = getConnectObj(this.p_sConnectString);

            try
            {
                sqlCmd = new SqlCommand();
                sqlCmd.Connection = m_oConn;
                sqlCmd.CommandType = CommandType.Text;

                sqlCmd.CommandTimeout = 9600;
                sqlCmd.CommandText = strSQL;
                sqlAdp = new SqlDataAdapter();
                sqlAdp.SelectCommand = sqlCmd;
                objDT = new DataTable();
                sqlAdp.Fill(objDT);
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    SqlStatement objSqlStatementEN = null;
                    try
                    {
                        objSqlStatementEN = SqlStatementAC.AnalysisSqlStatement(strSQL);
                        string strMsg = SqlStatementAC.GetSqlStatementAnalysisInfo(objSqlStatementEN, objDT.Rows.Count);
                        //s1trMsg += string.Format("|�ײ㺯��:[funGetFldDataOfTable]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("����{0}|Sql���:[{1}]|�ײ㺯��:[funGetFldDataOfTable]",
                            objException.Message, strSQL);
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                }
                //m_oConn.CloseB();
            }
            catch (Exception objException)
            {
                LogError(objException, "");
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    string strMsg = string.Format("����{0}. Sql��䣺{1}", objException.Message, strSQL);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                        intCurrLevel++;
                        if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                    }
                    clsDebugBase_Sql.WriteLog(strMsg);
                }
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
                //				return null;
            }

            finally
            {
                m_oConn.Close();
            }
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrList;
            }
            for (iRow = 0; iRow <= objDT.Rows.Count - 1; iRow++)
            {
                strKeyValue = "";
                for (iCol = 0; iCol <= objDT.Columns.Count - 1; iCol++)
                {
                    if (iCol == 0)
                    {
                        strKeyValue += objDT.Rows[iRow][iCol].ToString();
                    }
                    else
                    {
                        strKeyValue += "//" + objDT.Rows[iRow][iCol].ToString();
                    }
                }
                arrList.Add(strKeyValue);
            }
            objDT = null;
            return arrList;
        }



        /// <summary>
        /// ���ܣ�	��ȡĳ���з���������ĳ�ֶε�ֵ
        /// </summary>
        /// <param name="strTableName">����</param>
        /// <param name="strFieldName">�ֶ���</param>
        /// <param name="WhereConditionString">������</param>
        /// <returns>�б�</returns>
        public List<string> GetFldDataOfTableNoDistinct(string strTableName,
            string strFieldName,
            string WhereConditionString)
        {
            string strWhere = WhereConditionString.ToLower();
            strWhere = strWhere.Replace("  ", " ");
           
            //��ò����ر�
            SqlCommand sqlCmd;
            SqlDataAdapter sqlAdp;
            DataTable objDT;
            List<string> arrList = new List<string>();
            int iRow, iCol;
            string strKeyValue;
            string strSQL;
            //																						  '��֯SQL��
            if (WhereConditionString != "")
            {
                WhereConditionString = " where " + WhereConditionString;
            }
            strSQL = "select " + strFieldName + " from " + strTableName + WhereConditionString;
           
            m_oConn = getConnectObj(this.p_sConnectString);

            try
            {
                sqlCmd = new SqlCommand();
                sqlCmd.Connection = m_oConn;
                sqlCmd.CommandType = CommandType.Text;

                sqlCmd.CommandTimeout = 9600;
                sqlCmd.CommandText = strSQL;
                sqlAdp = new SqlDataAdapter();
                sqlAdp.SelectCommand = sqlCmd;
                objDT = new DataTable();
                sqlAdp.Fill(objDT);
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    SqlStatement objSqlStatementEN = null;
                    try
                    {
                        objSqlStatementEN = SqlStatementAC.AnalysisSqlStatement(strSQL);
                        string strMsg = SqlStatementAC.GetSqlStatementAnalysisInfo(objSqlStatementEN, objDT.Rows.Count);
                        //s1trMsg += string.Format("|�ײ㺯��:[funGetFldDataOfTableNoDistinct]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("����{0}|Sql���:[{1}]|�ײ㺯��:[funGetFldDataOfTableNoDistinct]",
                            objException.Message, strSQL);
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                }
                //m_oConn.CloseB();
            }
            catch (Exception objException)
            {
                LogError(objException, "");
             
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    string strMsg = string.Format("����{0}. Sql��䣺{1}", objException.Message, strSQL);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                        intCurrLevel++;
                        if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                    }
                    clsDebugBase_Sql.WriteLog(strMsg);
                } 
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
                //				return null;
            }

            finally
            {
                m_oConn.Close();
            }
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrList;
            }
            for (iRow = 0; iRow <= objDT.Rows.Count - 1; iRow++)
            {
                strKeyValue = "";
                for (iCol = 0; iCol <= objDT.Columns.Count - 1; iCol++)
                {
                    if (iCol == 0)
                    {
                        strKeyValue += objDT.Rows[iRow][iCol].ToString();
                    }
                    else
                    {
                        strKeyValue += "//" + objDT.Rows[iRow][iCol].ToString();
                    }
                }
                arrList.Add(strKeyValue);
            }
            objDT = null;
            return arrList;
        }
        /// <summary>
        /// ���ܣ�	��ȡĳ���з���������ĳ�ֶε�ֵ
        /// </summary>
        /// <param name="strTableName">����</param>
        /// <param name="strFieldName">�ֶ���</param>
        /// <param name="WhereConditionString">������</param>
        /// <returns>�б�</returns>
        public ArrayList GetFldDataOfTable(string strTableName,
            string strFieldName,
            string WhereConditionString,
            SqlConnection objSqlConnect,
            SqlTransaction objSqlTransaction)
        {

            string strWhere = WhereConditionString.ToLower();
            strWhere = strWhere.Replace("  ", " ");
            strFieldName = strFieldName.ToLower();
            strFieldName = strFieldName.Replace("distinct", "");
            if (strWhere.IndexOf("order by") >= 0)
            {
                strWhere = strWhere.Replace("order by", "");
                strWhere = strWhere.Replace(strFieldName.ToLower(), "");
                strWhere = strWhere.Replace(" ", "");
                if (strWhere.Length > 0)
                {
                    string strSQL1 = "select distinct " + strFieldName + " from " + strTableName + WhereConditionString;
                    StringBuilder sbMsg = new StringBuilder();
                    sbMsg.AppendFormat("�ں���funGetFldDataOfTable�У�SQL��䣺{0}�к��У�distinct��ͬʱ��Order By����Order By�г����ֶ�{1}���ֶ�{2}��",
                                    strSQL1,
                                    strFieldName,
                                    strWhere);
                    throw new Exception(sbMsg.ToString());
                }
            }
            //��ò����ر�
            SqlCommand sqlCmd;
            SqlDataAdapter sqlAdp;
            DataTable objDT;
            ArrayList arrList = new ArrayList();
            int iRow, iCol;
            string strKeyValue;
            string strSQL;
            //																						  '��֯SQL��
            if (WhereConditionString != "")
            {
                WhereConditionString = " where " + WhereConditionString;
            }
            strSQL = "select distinct " + strFieldName + " from " + strTableName + WhereConditionString;
           
            try
            {
                sqlCmd = new SqlCommand();
                sqlCmd.Connection = objSqlConnect;
                sqlCmd.Transaction = objSqlTransaction;
                sqlCmd.CommandType = CommandType.Text;

                sqlCmd.CommandTimeout = 9600;
                sqlCmd.CommandText = strSQL;
                sqlAdp = new SqlDataAdapter();
                sqlAdp.SelectCommand = sqlCmd;
                objDT = new DataTable();
                sqlAdp.Fill(objDT);
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    SqlStatement objSqlStatementEN = null;
                    try
                    {
                        objSqlStatementEN = SqlStatementAC.AnalysisSqlStatement(strSQL);
                        string strMsg = SqlStatementAC.GetSqlStatementAnalysisInfo(objSqlStatementEN, objDT.Rows.Count);
                        //s1trMsg += string.Format("|�ײ㺯��:[funGetFldDataOfTable]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("����{0}|Sql���:[{1}]|�ײ㺯��:[funGetFldDataOfTable]",
                            objException.Message, strSQL);
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                }
                //m_oConn.CloseB();
            }
            catch (Exception objException)
            {
                LogError(objException, "");
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    string strMsg = string.Format("����{0}. Sql��䣺{1}", objException.Message, strSQL);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                        intCurrLevel++;
                        if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                    }
                    clsDebugBase_Sql.WriteLog(strMsg);
                }
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
                //				return null;
            }

            finally
            {
            }
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrList;
            }
            for (iRow = 0; iRow <= objDT.Rows.Count - 1; iRow++)
            {
                strKeyValue = "";
                for (iCol = 0; iCol <= objDT.Columns.Count - 1; iCol++)
                {
                    if (iCol == 0)
                    {
                        strKeyValue += objDT.Rows[iRow][iCol].ToString();
                    }
                    else
                    {
                        strKeyValue += "//" + objDT.Rows[iRow][iCol].ToString();
                    }
                }
                arrList.Add(strKeyValue);
            }
            objDT = null;
            return arrList;
        }

        /// <summary>
        /// ���ܣ�	��ȡSQL���ִ�к�Ψһ���ֵ
        /// </summary>
        /// <param name="strSql">SQL���</param>
        /// <param name="strFieldName">�ֶ���</param>
        /// <returns>Ψһ���ֵ</returns>
        public string GetFldValueBySql(string strSql, string strFieldName)
        {
            
            SqlCommand sqlCmd;
            SqlDataAdapter sqlAdp;
            DataTable objDT;
            ArrayList arrList = new ArrayList();
            m_oConn = getConnectObj(this.p_sConnectString);

            try
            {
                sqlCmd = new SqlCommand();
                sqlCmd.Connection = m_oConn;
                sqlCmd.CommandType = CommandType.Text;

                sqlCmd.CommandTimeout = 9600;
                sqlCmd.CommandText = strSql;
                sqlAdp = new SqlDataAdapter();
                sqlAdp.SelectCommand = sqlCmd;
                objDT = new DataTable();
                sqlAdp.Fill(objDT);
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    SqlStatement objSqlStatementEN = null;
                    try
                    {
                        objSqlStatementEN = SqlStatementAC.AnalysisSqlStatement(strSql);
                        string strMsg = SqlStatementAC.GetSqlStatementAnalysisInfo(objSqlStatementEN, objDT.Rows.Count);
                        //s1trMsg += string.Format("|�ײ㺯��:[funGetFldValueBySql]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("����{0}|Sql���:[{1}]|�ײ㺯��:[funGetFldValueBySql]",
                            objException.Message, strSql);
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                }
                //m_oConn.CloseB();
            }
            catch (Exception objException)
            {
                LogError(objException, "");
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    string strMsg = string.Format("����{0}. Sql��䣺{1}", objException.Message, strSql);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                        intCurrLevel++;
                        if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                    }
                    clsDebugBase_Sql.WriteLog(strMsg);
                }
                throw objException;// throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
                //				return null;
            }

            finally
            {
                m_oConn.Close();
            }
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return "";
            }
            string strValue = objDT.Rows[0][0].ToString();
            objDT = null;
            return strValue;
        }

        /// <summary>
        /// ���ܣ�	��ȡSQL���ִ�к���ֵ�б�
        /// </summary>
        /// <param name="strSql">SQL���</param>
        /// <param name="strFieldName">�ֶ���</param>
        /// <returns>���ֵ�б�</returns>
        public ArrayList GetFldValuesBySql(string strSql, string strFieldName)
        {
           
            SqlCommand sqlCmd;
            SqlDataAdapter sqlAdp;
            DataTable objDT;
            ArrayList arrList = new ArrayList();
            int iRow, iCol;
            string strKeyValue;
            m_oConn = getConnectObj(this.p_sConnectString);

            try
            {
                sqlCmd = new SqlCommand();
                sqlCmd.Connection = m_oConn;
                sqlCmd.CommandType = CommandType.Text;

                sqlCmd.CommandTimeout = 9600;
                sqlCmd.CommandText = strSql;
                sqlAdp = new SqlDataAdapter();
                sqlAdp.SelectCommand = sqlCmd;
                objDT = new DataTable();
                sqlAdp.Fill(objDT);
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    SqlStatement objSqlStatementEN = null;
                    try
                    {
                        objSqlStatementEN = SqlStatementAC.AnalysisSqlStatement(strSql);
                        string strMsg = SqlStatementAC.GetSqlStatementAnalysisInfo(objSqlStatementEN, objDT.Rows.Count);
                        //s1trMsg += string.Format("|�ײ㺯��:[funGetFldValuesBySql]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("����{0}|Sql���:[{1}]|�ײ㺯��:[funGetFldValuesBySql]",
                            objException.Message, strSql);
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                }
                //m_oConn.CloseB();
            }
            catch (Exception objException)
            {
                LogError(objException, "");
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    string strMsg = string.Format("����{0}. Sql��䣺{1}", objException.Message, strSql);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                        intCurrLevel++;
                        if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                    }
                    clsDebugBase_Sql.WriteLog(strMsg);
                }
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
                //				return null;
            }

            finally
            {
                m_oConn.Close();
            }
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrList;
            }
            for (iRow = 0; iRow <= objDT.Rows.Count - 1; iRow++)
            {
                strKeyValue = "";
                for (iCol = 0; iCol <= objDT.Columns.Count - 1; iCol++)
                {
                    if (iCol == 0)
                    {
                        strKeyValue += objDT.Rows[iRow][iCol].ToString();
                    }
                    else
                    {
                        strKeyValue += "//" + objDT.Rows[iRow][iCol].ToString();
                    }
                }
                arrList.Add(strKeyValue);
            }
            objDT = null;
            return arrList;
        }


        /// <summary>
        /// ���ܣ�	��ȡĳ���з���������ĳ�ֶε�ֵ
        /// </summary>
        /// <param name="strTableName">����</param>
        /// <param name="strFieldName">�ֶ���</param>
        /// <param name="WhereConditionString">������</param>
        /// <param name="strOrderBy">������ʽ</param>
        /// <returns>�б�</returns>
        public ArrayList GetFldDataOfTable2(string strTableName,
            string strFieldName,
            string WhereConditionString,
            string strOrderBy)
        {
            //��ò����ر�
            SqlCommand sqlCmd;
            SqlDataAdapter sqlAdp;
            DataTable objDT;
            ArrayList arrList = new ArrayList();
            int iRow, iCol;
            string strKeyValue;
            string strSQL;

            //																						  '��֯SQL��
            if (WhereConditionString != "")
            {
                WhereConditionString = " where " + WhereConditionString;
            }
            if (strOrderBy != "")
            {
                strOrderBy = " order by " + strOrderBy;
            }

            strSQL = "select " + strFieldName + " from " + strTableName + WhereConditionString + strOrderBy;
          
            m_oConn = getConnectObj(this.p_sConnectString);
            try
            {
                sqlCmd = new SqlCommand();
                sqlCmd.Connection = m_oConn;
                sqlCmd.CommandType = CommandType.Text;

                sqlCmd.CommandTimeout = 9600;
                sqlCmd.CommandText = strSQL;
                sqlAdp = new SqlDataAdapter();
                sqlAdp.SelectCommand = sqlCmd;
                objDT = new DataTable();
                sqlAdp.Fill(objDT);
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    SqlStatement objSqlStatementEN = null;
                    try
                    {
                        objSqlStatementEN = SqlStatementAC.AnalysisSqlStatement(strSQL);
                        string strMsg = SqlStatementAC.GetSqlStatementAnalysisInfo(objSqlStatementEN, objDT.Rows.Count);
                        //s1trMsg += string.Format("|�ײ㺯��:[funGetFldDataOfTable2]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("����{0}|Sql���:[{1}]|�ײ㺯��:[funGetFldDataOfTable2]",
                            objException.Message, strSQL);
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                }
                //m_oConn.CloseB();
            }
            catch (Exception objException)
            {
                LogError(objException, "");
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    string strMsg = string.Format("����{0}. Sql��䣺{1}", objException.Message, strSQL);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                        intCurrLevel++;
                        if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                    }
                    clsDebugBase_Sql.WriteLog(strMsg);
                }
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
                //				return null;
            }

            finally
            {
                m_oConn.Close();
            }
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return arrList;
            }
            for (iRow = 0; iRow <= objDT.Rows.Count - 1; iRow++)
            {
                strKeyValue = "";
                for (iCol = 0; iCol <= objDT.Columns.Count - 1; iCol++)
                {
                    if (iCol == 0)
                    {
                        strKeyValue += objDT.Rows[iRow][iCol].ToString();
                    }
                    else
                    {
                        strKeyValue += "//" + objDT.Rows[iRow][iCol].ToString();
                    }
                }
                arrList.Add(strKeyValue);
            }
            objDT = null;
            return arrList;
        }
           
        /// <summary>
        /// ���ܣ�����ĳ��ķ���������ĳ�ֶ�ֵ
        /// </summary>
        /// <param name="strTableName">����</param>
        /// <param name="strFieldName">�ֶ���</param>
        /// <param name="varValue">����ֵ</param>
        /// <param name="WhereConditionString"></param>
        /// <returns>����Ӱ��ļ�¼����������</returns>
        public int SetFldDataOfTable<T>(string strTableName,
            string strFieldName,
            T varValue,
            string WhereConditionString)
        {
            //��ò����ر�
            SqlCommand sqlCmd;
            StringBuilder strSQL = new StringBuilder();
            //														  '��֯SQL��

            if (WhereConditionString != "")
            {
                WhereConditionString = " where " + WhereConditionString;
            }

            strSQL.AppendFormat("update {0} ", strTableName);
            if (typeof(string) == typeof(T) && varValue.ToString() == "[null]")
            {
                strSQL.AppendFormat("Set {0} = null {2}", strFieldName, varValue, WhereConditionString);
            }
            else if (typeof(string) == typeof(T) || typeof(bool) == typeof(T))
            {
                strSQL.AppendFormat("Set {0} = '{1}' {2}", strFieldName, varValue, WhereConditionString);
            }
            else
            {
                strSQL.AppendFormat("Set {0} = {1} {2}", strFieldName, varValue, WhereConditionString);
            }
            m_oConn = getConnectObj(this.p_sConnectString);
            try
            {
                sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Connection = m_oConn;
                sqlCmd.CommandText = strSQL.ToString();
                int intRecCount = sqlCmd.ExecuteNonQuery();
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    SqlStatement objSqlStatementEN = null;
                    try
                    {
                        objSqlStatementEN = SqlStatementAC.AnalysisSqlStatement(strSQL.ToString());
                        string strMsg = SqlStatementAC.GetSqlStatementAnalysisInfo(objSqlStatementEN, intRecCount);
                        //s1trMsg += string.Format("|�ײ㺯��:[funSetFldDataOfTable]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("����{0}|Sql���:[{1}]|�ײ㺯��:[funSetFldDataOfTable]",
                            objException.Message, strSQL);
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                }
                return intRecCount;
            }
            catch (Exception objException)
            {
                LogError(objException, "");
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    string strMsg = string.Format("����{0}. Sql��䣺{1}", objException.Message, strSQL.ToString());
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                        intCurrLevel++;
                        if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                    }
                    clsDebugBase_Sql.WriteLog(strMsg);
                }
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
                //return -1;
            }
            finally
            {
                m_oConn.Close();
            }
            //			return intRecCount;
        }
        public System.Data.SqlClient.SqlConnection SQLConnect
        {
            get
            {
                m_oConn = getConnectObj(this.p_sConnectString);
                return m_oConn;
            }
        }
        /// <summary>
        /// ����Sql��䣬��ȡDataSet
        /// </summary>
        /// <param name="strSql">Sql���</param>
        /// <param name="strTableName">����</param>
        /// <returns>��ȡ��DataSet</returns>
        public DataSet GetDataSet(string strSql, string strTableName)
        {
           
            SqlCommand sqlCmd;
            SqlDataAdapter sqlAdp;
            DataSet dtSet;
            m_oConn = getConnectObj(this.p_sConnectString);
            try
            {
                sqlCmd = new SqlCommand();
                sqlCmd.Connection = m_oConn;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = strSql;

                sqlAdp = new SqlDataAdapter();
                sqlAdp.SelectCommand = sqlCmd;
                dtSet = new DataSet();
                sqlAdp.Fill(dtSet, strTableName);
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    SqlStatement objSqlStatementEN = null;
                    try
                    {
                        objSqlStatementEN = SqlStatementAC.AnalysisSqlStatement(strSql);
                        string strMsg = SqlStatementAC.GetSqlStatementAnalysisInfo(objSqlStatementEN, dtSet.Tables[strTableName].Rows.Count);
                        //s1trMsg += string.Format("|�ײ㺯��:[GetDataSet]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("����{0}|Sql���:[{1}]|�ײ㺯��:[GetDataSet]",
                            objException.Message, strSql);
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                }
                return dtSet;
            }

            catch (Exception objException)
            {
                LogError(objException, "");
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    string strMsg = string.Format("����{0}. Sql��䣺{1}", objException.Message, strSql);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                        intCurrLevel++;
                        if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                    }
                    clsDebugBase_Sql.WriteLog(strMsg);
                }
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
                //				dtSet=new DataSet();
                //				return dtSet;
            }
            finally
            {
                m_oConn.Close();
            }
        }

        /// <summary>
        /// ��ȡDataSet
        /// </summary>
        /// <param name="objTable_SqlCommandText">����-SQL������</param>
        /// <returns>����DataSet</returns>
        public DataSet GetDataSet(clsTable_SqlCommandText objTable_SqlCommandText)
        {
            
            SqlCommand sqlCmd;
            SqlDataAdapter sqlAdp;
            DataSet dtSet;
            m_oConn = getConnectObj(this.p_sConnectString);

            try
            {
                sqlCmd = new SqlCommand();
                sqlCmd.Connection = m_oConn;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = objTable_SqlCommandText.SqlCommandText;

                sqlAdp = new SqlDataAdapter();
                sqlAdp.SelectCommand = sqlCmd;
                dtSet = new DataSet();
                sqlAdp.Fill(dtSet, objTable_SqlCommandText.TableName);
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    SqlStatement objSqlStatementEN = null;
                    try
                    {
                        objSqlStatementEN = SqlStatementAC.AnalysisSqlStatement(objTable_SqlCommandText.SqlCommandText);
                        string strMsg = SqlStatementAC.GetSqlStatementAnalysisInfo(objSqlStatementEN, dtSet.Tables[objTable_SqlCommandText.TableName].Rows.Count);
                        //s1trMsg += string.Format("|�ײ㺯��:[GetDataSet]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("����{0}|Sql���:[{1}]|�ײ㺯��:[GetDataSet]",
                            objException.Message, objTable_SqlCommandText.SqlCommandText);
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                }
                return dtSet;
            }

            catch (Exception objException)
            {
                LogError(objException, "");
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    string strMsg = string.Format("����{0}. Sql��䣺{1}", objException.Message, objTable_SqlCommandText.SqlCommandText);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                        intCurrLevel++;
                        if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                    }
                    clsDebugBase_Sql.WriteLog(strMsg);
                }
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
                //				dtSet=new DataSet();
                //				return dtSet;
            }
            finally
            {
                m_oConn.Close();
            }
        }

        /// <summary>
        /// ��ȡDataSet,��XML��ʽ����ʾ
        /// </summary>
        /// <param name="objTable_SqlCommandText">����-SQL������</param>
        /// <param name="strXmlFileName">���ɵ�XML�ļ���</param>
        /// <returns>��������XML�ļ��Ƿ�ɹ�</returns>
        public bool GetDataSetXml(clsTable_SqlCommandText objTable_SqlCommandText, string strXmlFileName)
        {
           
            SqlCommand sqlCmd;
            SqlDataAdapter sqlAdp;
            DataSet dtSet;
            m_oConn = getConnectObj(this.p_sConnectString);

            try
            {
                sqlCmd = new SqlCommand();
                sqlCmd.Connection = m_oConn;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = objTable_SqlCommandText.SqlCommandText;

                sqlAdp = new SqlDataAdapter();
                sqlAdp.SelectCommand = sqlCmd;
                dtSet = new DataSet();
                sqlAdp.Fill(dtSet, objTable_SqlCommandText.TableName);
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    SqlStatement objSqlStatementEN = null;
                    try
                    {
                        objSqlStatementEN = SqlStatementAC.AnalysisSqlStatement(objTable_SqlCommandText.SqlCommandText);
                        string strMsg = SqlStatementAC.GetSqlStatementAnalysisInfo(objSqlStatementEN, dtSet.Tables[objTable_SqlCommandText.TableName].Rows.Count);
                        //s1trMsg += string.Format("|�ײ㺯��:[GetDataSetXml]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("����{0}|Sql���:[{1}]|�ײ㺯��:[GetDataSetXml]",
                            objException.Message, objTable_SqlCommandText.SqlCommandText);
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                }
                dtSet.WriteXml(strXmlFileName, XmlWriteMode.WriteSchema);
                return true;
            }

            catch (Exception objException)
            {
                LogError(objException, "");
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    string strMsg = string.Format("����{0}. Sql��䣺{1}", objException.Message, objTable_SqlCommandText.SqlCommandText);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                        intCurrLevel++;
                        if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                    }
                    clsDebugBase_Sql.WriteLog(strMsg);
                }
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
                //				dtSet=new DataSet();
                //				return dtSet;
            }
            finally
            {
                m_oConn.Close();
            }
        }

        /// <summary>
        /// ��ȡ�����������-SQL�������DataSet
        /// </summary>
        /// <param name="arrTable_SqlCommandTextList">����-SQL�������б�</param>
        /// <returns>����DataSet</returns>
        public DataSet GetDataSet(ArrayList arrTable_SqlCommandTextList)
        {
            //by ���Է�
            //2007-12-2
            //��ò����ؼ�¼��
            SqlCommand sqlCmd;
            SqlDataAdapter sqlAdp;
            DataSet dtSet;
            m_oConn = getConnectObj(this.p_sConnectString);
            string strSql = "";
            try
            {
                sqlCmd = new SqlCommand();
                sqlCmd.Connection = m_oConn;
                sqlCmd.CommandType = CommandType.Text;

                sqlAdp = new SqlDataAdapter();
                sqlAdp.SelectCommand = sqlCmd;
                dtSet = new DataSet();
                foreach (clsTable_SqlCommandText objTable_SqlCommandText in arrTable_SqlCommandTextList)
                {
                    strSql = objTable_SqlCommandText.SqlCommandText;
                   
                    sqlCmd.CommandText = objTable_SqlCommandText.SqlCommandText;
                    sqlAdp.Fill(dtSet, objTable_SqlCommandText.TableName);
                    if (clsDebugBase_Sql.IsDebug == true)
                    {
                        SqlStatement objSqlStatementEN = null;
                        try
                        {
                            objSqlStatementEN = SqlStatementAC.AnalysisSqlStatement(objTable_SqlCommandText.SqlCommandText);
                            string strMsg = SqlStatementAC.GetSqlStatementAnalysisInfo(objSqlStatementEN, dtSet.Tables[objTable_SqlCommandText.TableName].Rows.Count);
                            //s1trMsg += string.Format("|�ײ㺯��:[GetDataSet]");
                            StackTrace trace = new StackTrace();
                            int intCurrLevel = 0;
                            foreach (StackFrame frame in trace.GetFrames())
                            {
                                string strFileName = frame.GetFileName();
                                string strMothodName = frame.GetMethod().Name;
                                if (frame.GetMethod().DeclaringType == null) break;
                                string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                                strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                                intCurrLevel++;
                                if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                            }
                            clsDebugBase_Sql.WriteLog(strMsg);
                        }
                        catch (Exception objException)
                        {
                            string strMsg = string.Format("����{0}|Sql���:[{1}]|�ײ㺯��:[GetDataSet]",
                                objException.Message, objTable_SqlCommandText.SqlCommandText);
                            clsDebugBase_Sql.WriteLog(strMsg);
                        }
                    }
                }
                return dtSet;
            }

            catch (Exception objException)
            {
                LogError(objException, "");
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    string strMsg = string.Format("����{0}. Sql��䣺{1}", objException.Message, strSql);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                        intCurrLevel++;
                        if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                    }
                    clsDebugBase_Sql.WriteLog(strMsg);
                }
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
                //				dtSet=new DataSet();
                //				return dtSet;
            }
            finally
            {
                m_oConn.Close();
            }
        }

        /// <summary>
        /// ��ȡDataSet
        /// </summary>
        /// <param name="arrTable_SqlCommandTextList">����-SQL������</param>
        /// <param name="strXmlFileName">XML�ļ���</param>
        /// <returns>����DataSet</returns>
        public bool GetDataSetXml(ArrayList arrTable_SqlCommandTextList, string strXmlFileName)
        {
            //by ���Է�
            //2007-12-2
            //��ò����ؼ�¼��
            SqlCommand sqlCmd;
            SqlDataAdapter sqlAdp;
            DataSet dtSet;
            m_oConn = getConnectObj(this.p_sConnectString);
            string strSql = "";
            try
            {
                sqlCmd = new SqlCommand();
                sqlCmd.Connection = m_oConn;
                sqlCmd.CommandType = CommandType.Text;

                sqlAdp = new SqlDataAdapter();
                sqlAdp.SelectCommand = sqlCmd;
                dtSet = new DataSet();
                foreach (clsTable_SqlCommandText objTable_SqlCommandText in arrTable_SqlCommandTextList)
                {
                    strSql = objTable_SqlCommandText.SqlCommandText;
                   
                    sqlCmd.CommandText = objTable_SqlCommandText.SqlCommandText;
                    sqlAdp.Fill(dtSet, objTable_SqlCommandText.TableName);
                    if (clsDebugBase_Sql.IsDebug == true)
                    {
                        SqlStatement objSqlStatementEN = null;
                        try
                        {
                            objSqlStatementEN = SqlStatementAC.AnalysisSqlStatement(objTable_SqlCommandText.SqlCommandText);
                            string strMsg = SqlStatementAC.GetSqlStatementAnalysisInfo(objSqlStatementEN, dtSet.Tables[objTable_SqlCommandText.TableName].Rows.Count);
                            //s1trMsg += string.Format("|�ײ㺯��:[GetDataSet]");
                            StackTrace trace = new StackTrace();
                            int intCurrLevel = 0;
                            foreach (StackFrame frame in trace.GetFrames())
                            {
                                string strFileName = frame.GetFileName();
                                string strMothodName = frame.GetMethod().Name;
                                if (frame.GetMethod().DeclaringType == null) break;
                                string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                                strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                                intCurrLevel++;
                                if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                            }
                            clsDebugBase_Sql.WriteLog(strMsg);
                        }
                        catch (Exception objException)
                        {
                            string strMsg = string.Format("����{0}|Sql���:[{1}]�ײ㺯��:[GetDataSet]",
                                objException.Message, objTable_SqlCommandText.SqlCommandText);
                            clsDebugBase_Sql.WriteLog(strMsg);
                        }
                    }
                }
                dtSet.WriteXml(strXmlFileName, XmlWriteMode.WriteSchema);
                return true;
            }

            catch (Exception objException)
            {
                LogError(objException, "");
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    string strMsg = string.Format("����{0}. Sql��䣺{1}", objException.Message, strSql);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                        intCurrLevel++;
                        if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                    }
                    clsDebugBase_Sql.WriteLog(strMsg);
                }
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
                //				dtSet=new DataSet();
                //				return dtSet;
            }
            finally
            {
                m_oConn.Close();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ssql"></param>
        /// <param name="scondition"></param>
        /// <returns></returns>
        private bool CheckDataExist(string ssql, string scondition)
        {
            //by davidfujian(��˳��)
            //2004-3-8 11:12
            //����¼�Ƿ����
            SqlCommand sqlCmd = null;
            System.Data.SqlClient.SqlDataReader dtRedr;
            m_oConn = getConnectObj(this.p_sConnectString);
            try
            {

                sqlCmd = new SqlCommand();
                sqlCmd.Connection = m_oConn;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = ssql + " where " + scondition;
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    SqlStatement objSqlStatementEN = null;
                    try
                    {
                        objSqlStatementEN = SqlStatementAC.AnalysisSqlStatement(sqlCmd.CommandText);
                        string strMsg = SqlStatementAC.GetSqlStatementAnalysisInfo(objSqlStatementEN, -1);
                        //s1trMsg += string.Format("|�ײ㺯��:[CheckDataExist]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("����{0}|Sql���:[{1}]|�ײ㺯��:[CheckDataExist]",
                            objException.Message, sqlCmd.CommandText);
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                }

                dtRedr = sqlCmd.ExecuteReader();
                bool flag = dtRedr.HasRows;
                dtRedr.Close();
                return flag;
            }

            catch (Exception objException)
            {
                LogError(objException, "");
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    string strMsg = string.Format("����{0}. Sql��䣺{1}", objException.Message, sqlCmd.CommandText);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                        intCurrLevel++;
                        if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                    }
                    clsDebugBase_Sql.WriteLog(strMsg);
                }
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
                //				return false;
            }

            finally
            {
                m_oConn.Close();
            }
        }

        /// <summary>
        /// �Ƿ���ڼ�¼
        /// </summary>
        /// <param name="strTable">����</param>
        /// <param name="strCondition">������</param>
        /// <returns>�Ƿ����</returns>
        public bool IsExistRecord(string strTable, string strCondition)
        {
            //by davidfujian(���Է�)
            //2004-3-8 11:12
            //����¼�Ƿ����
            SqlCommand sqlCmd = null;
            SqlDataAdapter sqlAdp;
            DataTable dtTab;
            m_oConn = getConnectObj(this.p_sConnectString);
            try
            {
                sqlCmd = new SqlCommand();
                sqlCmd.Connection = m_oConn;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "select * from " + strTable + " where " + strCondition;
              
                sqlAdp = new SqlDataAdapter();
                sqlAdp.SelectCommand = sqlCmd;
                dtTab = new DataTable();
                sqlAdp.Fill(dtTab);
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    SqlStatement objSqlStatementEN = null;
                    try
                    {
                        objSqlStatementEN = SqlStatementAC.AnalysisSqlStatement(sqlCmd.CommandText);
                        string strMsg = SqlStatementAC.GetSqlStatementAnalysisInfo(objSqlStatementEN, dtTab.Rows.Count);
                        //s1trMsg += string.Format("|�ײ㺯��:[IsExistRecord]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("����{0}|Sql���:[{1}]|�ײ㺯��:[IsExistRecord]",
                            objException.Message, sqlCmd.CommandText);
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                }
                if (dtTab.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            catch (Exception objException)
            {
                LogError(objException, "");
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    string strMsg = string.Format("����{0}. Sql��䣺{1}", objException.Message, sqlCmd.CommandText);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                        intCurrLevel++;
                        if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                    }
                    clsDebugBase_Sql.WriteLog(strMsg);
                }
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
                //				return false;
            }
            finally
            {
                m_oConn.Close();
            }
        }

        /// <summary> 
        /// �Ƿ���ڼ�¼
        /// </summary>
        /// <param name="strTable">����</param>
        /// <param name="strCondition">������</param>
        /// <param name="objSqlConnect">SqlConnection</param>
        /// <param name="objSqlTransaction">SqlTransaction</param>
        /// <returns>�Ƿ����</returns>
        public bool IsExistRecord(string strTable, string strCondition, SqlConnection objSqlConnect, SqlTransaction objSqlTransaction)
        {
            //by ���Է�
            //2004-3-8 11:12
            //����¼�Ƿ����
            SqlCommand sqlCmd = null;
            SqlDataAdapter sqlAdp;
            DataTable dtTab;

            try
            {
                sqlCmd = new SqlCommand();
                sqlCmd.Connection = objSqlConnect;
                sqlCmd.Transaction = objSqlTransaction;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "select * from " + strTable + " where " + strCondition;
              
                sqlAdp = new SqlDataAdapter();
                sqlAdp.SelectCommand = sqlCmd;
                dtTab = new DataTable();
                sqlAdp.Fill(dtTab);
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    SqlStatement objSqlStatementEN = null;
                    try
                    {
                        objSqlStatementEN = SqlStatementAC.AnalysisSqlStatement(sqlCmd.CommandText);
                        string strMsg = SqlStatementAC.GetSqlStatementAnalysisInfo(objSqlStatementEN, dtTab.Rows.Count);
                        //s1trMsg += string.Format("|�ײ㺯��:[GetSqlDataReader]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("����{0}|Sql���:[{1}]|�ײ㺯��:[GetDataTableXml]",
                            objException.Message, sqlCmd.CommandText);
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                }
                if (dtTab.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            catch (Exception objException)
            {
                LogError(objException, "");
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    string strMsg = string.Format("����{0}. Sql��䣺{1}", objException.Message, sqlCmd.CommandText);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                        intCurrLevel++;
                        if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                    }
                    clsDebugBase_Sql.WriteLog(strMsg);
                }
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
                //				return false;
            }
            finally
            {
            }
        }
        /// <summary>
        /// ִ��SQL���
        /// </summary>
        /// <param name="strSql">��ִ�е�SQL���</param>
        /// <returns>�Ƿ�ɹ���</returns>
        public bool ExecSql(string strSql)
        {
            m_oConn = getConnectObj(this.p_sConnectString);

            try
            {
                SqlCommand sqlCmd;
                sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Connection = m_oConn;

                sqlCmd.CommandTimeout = 9600;
                sqlCmd.CommandText = strSql;
                int intRecCount = sqlCmd.ExecuteNonQuery();
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    SqlStatement objSqlStatementEN = null;
                    try
                    {
                        objSqlStatementEN = SqlStatementAC.AnalysisSqlStatement(strSql);
                        string strMsg = SqlStatementAC.GetSqlStatementAnalysisInfo(objSqlStatementEN, intRecCount);
                        //s1trMsg += string.Format("|�ײ㺯��:[ExecSql]");
                    
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("����{0}|Sql���:[{1}]|�ײ㺯��:[ExecSql]",
                            objException.Message, strSql);
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    
                   
                }
                return true;
            }
            catch (Exception objException)
            {
                LogError(objException, "");
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    string strMsg = string.Format("����{0}. Sql��䣺{1}", objException.Message, strSql);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                        intCurrLevel++;
                        if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                    }
                    clsDebugBase_Sql.WriteLog(strMsg);
                }
                throw new Exception(EXCEPTION_MSG + "\r\n" + objException.Message, objException);
                //				return false;
            }
            finally
            {
                m_oConn.Close();
            }
        }
        /// <summary>
        /// ִ��SQL���
        /// </summary>
        /// <param name="strSql">��ִ�е�SQL���</param>
        /// <param name="objSqlConnect">Sql���Ӷ���</param>
        /// <param name="objSqlTransaction">Sql�������</param>
        /// <returns>�Ƿ�ɹ���</returns>
        public bool ExecSql(string strSql, SqlConnection objSqlConnect, SqlTransaction objSqlTransaction)
        {
            try
            {
                SqlCommand sqlCmd;
                sqlCmd = new SqlCommand();
                sqlCmd.Transaction = objSqlTransaction;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Connection = objSqlConnect;

                sqlCmd.CommandTimeout = 9600;
                sqlCmd.CommandText = strSql;
                sqlCmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception objException)
            {
                LogError(objException, "");
         
                throw objException;// throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
                //				return false;
            }
            finally
            {
            }
        }
        /// <summary>
        /// ִ��SQL���
        /// </summary>
        /// <param name="strSql">��ִ�е�SQL���</param>
        /// <param name="intCommandTimeout">����ִ������ѵ�ʱ��</param>
        /// <returns>�Ƿ�ɹ���</returns>
        public bool ExecSql(string strSql, int intCommandTimeout)
        {
           
          
            m_oConn = getConnectObj(this.p_sConnectString);

            try
            {
                SqlCommand sqlCmd;
                sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Connection = m_oConn;
                sqlCmd.CommandText = strSql;
                sqlCmd.CommandTimeout = intCommandTimeout;
                int intRecCount = sqlCmd.ExecuteNonQuery();
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    SqlStatement objSqlStatementEN = null;
                    try
                    {
                        objSqlStatementEN = SqlStatementAC.AnalysisSqlStatement(strSql);
                        string strMsg = SqlStatementAC.GetSqlStatementAnalysisInfo(objSqlStatementEN, intRecCount);
                        //s1trMsg += string.Format("|�ײ㺯��:[ExecSql]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("����{0}|Sql���:[{1}]|�ײ㺯��:[ExecSql]",
                            objException.Message, strSql);
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                }
                return true;
            }
            catch (Exception objException)
            {
                LogError(objException, "");
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    string strMsg = string.Format("����{0}. Sql��䣺{1}", objException.Message, strSql);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                        intCurrLevel++;
                        if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                    }
                    clsDebugBase_Sql.WriteLog(strMsg);
                }
                throw new Exception(EXCEPTION_MSG + "\r\n" + objException.Message, objException);
                //				return false;
            }
            finally
            {
                m_oConn.Close();
            }
        }

        /// <summary>
        /// ���ܣ�ִ��SQL���
        /// </summary>
        /// <param name="ssql">��Ҫִ�е�SQL���</param>
        /// <returns>ִ��SQL���Ӱ��ļ�¼��������</returns>
        public int ExecSql2(string strSql)
        {
          

            int intRecCount;
            m_oConn = getConnectObj(this.p_sConnectString);

            try
            {
                SqlCommand sqlCmd;
                sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Connection = m_oConn;
                sqlCmd.CommandText = strSql;
                sqlCmd.CommandTimeout = 9600;
                intRecCount = sqlCmd.ExecuteNonQuery();
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    SqlStatement objSqlStatementEN = null;
                    try
                    {
                        objSqlStatementEN = SqlStatementAC.AnalysisSqlStatement(strSql);
                        string strMsg = SqlStatementAC.GetSqlStatementAnalysisInfo(objSqlStatementEN, intRecCount);
                        //s1trMsg += string.Format("|�ײ㺯��:[ExecSql2]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("����:{0}|Sql���:[{1}]|�ײ㺯��:[ExecSql2]",
                            objException.Message, strSql);
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                }
                return intRecCount;
            }
            catch (Exception objException)
            {
                LogError(objException, "");
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    string strMsg = string.Format("����{0}. Sql��䣺{1}", objException.Message, strSql);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                        intCurrLevel++;
                        if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                    }
                    clsDebugBase_Sql.WriteLog(strMsg);
                }
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
            }
            finally
            {
                m_oConn.Close();
            }
        }

        /// <summary>
        /// ���ܣ�ִ��SQL���
        /// </summary>
        /// <param name="strSql">��Ҫִ�е�SQL���</param>
        /// <param name="objSqlConnect">Sql���Ӷ���</param>
        /// <param name="objSqlTransaction">Sql�������</param>
        /// <returns>ִ��SQL���Ӱ��ļ�¼��������</returns>
        public int ExecSql2(string strSql, SqlConnection objSqlConnect, SqlTransaction objSqlTransaction)
        {
           
            int intRecCount;
            try
            {
                SqlCommand sqlCmd;
                sqlCmd = new SqlCommand();
                sqlCmd.Transaction = objSqlTransaction;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Connection = objSqlConnect;
                sqlCmd.CommandTimeout = 9600;
                sqlCmd.CommandText = strSql;
                intRecCount = sqlCmd.ExecuteNonQuery();
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    SqlStatement objSqlStatementEN = null;
                    try
                    {
                        objSqlStatementEN = SqlStatementAC.AnalysisSqlStatement(strSql);
                        string strMsg = SqlStatementAC.GetSqlStatementAnalysisInfo(objSqlStatementEN, intRecCount);
                        //s1trMsg += string.Format("|�ײ㺯��:[ExecSql2]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("����{0}|Sql���:[{1}]|�ײ㺯��:[ExecSql2]",
                            objException.Message, strSql);
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                }
                return intRecCount;
            }
            catch (Exception objException)
            {
                LogError(objException, "");
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    string strMsg = string.Format("����{0}. Sql��䣺{1}", objException.Message, strSql);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                        intCurrLevel++;
                        if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                    }
                    clsDebugBase_Sql.WriteLog(strMsg);
                }
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
            }
            finally
            {
                //m_oConn.Close();
            }
        }
        
        

        /// <summary>
        /// ���������Ƿ�ɹ�
        /// </summary>
        /// <param name="strConnectString">���Ӵ�</param>
        /// <returns>�Ƿ����ӳɹ���</returns>
        public static bool TestConnect(string strConnectString)
        {
            System.Data.SqlClient.SqlConnection objConn = new SqlConnection();
            objConn.ConnectionString = strConnectString;
            //objConn.ConnectionString = "server=202.121.48.140,2433;database=ecard;uid=ecard_pyf;pwd=ecarb6432;";
            try
            {
                objConn.Open();
                objConn.Close();
                return true;
            }
            catch (Exception objException)
            {
                throw new Exception("�������Ӳ��ɹ���" + objException.Message);
            }
        }
        public bool TestConnect()
        {
            System.Data.SqlClient.SqlConnection objConn = new SqlConnection();
            objConn.ConnectionString = this.p_sConnectString;
            //objConn.ConnectionString = "server=202.121.48.140,2433;database=ecard;uid=ecard_pyf;pwd=ecarb6432;";
            try
            {
                objConn.Open();
                objConn.Close();
                return true;
            }
            catch (Exception objException)
            {
                throw new Exception("�������Ӳ��ɹ���\n\r" + objException.Message);
            }
        }
        public ArrayList GetDistinctStringItems(string ssql)
        {
            //by davidfujian
            //9:57 2004-3-28
            ArrayList sarray = new ArrayList();
            m_oConn = getConnectObj(this.p_sConnectString);

            try
            {

                SqlCommand sqlCmd;

                sqlCmd = new SqlCommand();
                sqlCmd.Connection = m_oConn;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = ssql;

                sqlCmd.CommandTimeout = 9600;
                System.Data.SqlClient.SqlDataReader dtRedr;
                dtRedr = sqlCmd.ExecuteReader();

                while (dtRedr.Read())
                {
                    sarray.Add(dtRedr.GetString(0));
                }
                dtRedr.Close();
                //Close the connection to the DataBase!!
                return sarray;
            }
            catch (Exception objException)
            {
                LogError(objException, ssql);

                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
                //				return null;
            }
            finally
            {
                m_oConn.Close();
            }
        }
        /// <summary>
        /// ���ܣ���ָ���ļ������ݴ���������������ָ�����ֶ��С�
        /// </summary>
        /// <param name="strFileName">��Ҫ�����ļ����ݵ��ļ���</param>
        /// <param name="strTabName">��Ҫ�����ļ����ݵ�Ŀ�����ݱ���</param>
        /// <param name="strFldName">��Ҫ�����ļ����ݵ�Ŀ�����ݱ���ֶ���</param>
        /// <param name="strCondition">��Ҫ�����ļ����ݵ�Ŀ�����ݱ��о�����¼�������ַ���</param>
        /// <param name="intBufferLen">��������ʱ�Ļ���������</param>
        public void StoreFile(string strFileName,
            string strTabName,
            string strFldName,
            string strCondition,
            int intBufferLen)
        {
            StringBuilder strSQL = new StringBuilder();
            //���裺
            //	  1����ȡָ����¼��ǰ
            //	  
            m_oConn = getConnectObj(this.p_sConnectString);

            try
            {
                //
                //string sql="SELECT @Pointer = TEXTPTR("+ColumnPointerName+") FROM "+TableName+" WHERE "+ColumnIDName+"='"+ID+"'";
                //string sql="EXEC xxkp.dbo.Select_StoreFile @Pointer output,'"+GWBH+"'";
                //				strSQL=@"SELECT @Pointer = TEXTPTR(xxkp.dbo.photo.PHOTO) FROM xxkp.dbo.PHOTO WHERE GWBH='"+GWBH+"' WRITETEXT PHOTO.PHOTO @Pointer ''";
                //����SQL��䣬���ڻ�ȡ�ֶ�ָ�롣
                strSQL.AppendFormat("SELECT @Pointer = TEXTPTR({0}.{1}) FROM {0} WHERE {2}",
                    strTabName, strFldName, strCondition);
                //����ȡָ���λ���������
                strSQL.AppendFormat(" WRITETEXT {0}.{1} @Pointer ''",
                    strTabName, strFldName);
                //�½�SqlCommand����
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Connection = m_oConn;

                sqlCmd.CommandTimeout = 9600;
                sqlCmd.CommandText = strSQL.ToString();
                //�������
                SqlParameter ptrParm = sqlCmd.Parameters.Add("@Pointer", SqlDbType.Binary, 16);
                //��ȡָ�룬���Դ�ʱ��������Ϊ���(Output)
                ptrParm.Direction = ParameterDirection.Output;
                //������
                //m_oConn.Open();
                sqlCmd.ExecuteNonQuery();

                //�ı����������������
                ptrParm.Direction = ParameterDirection.Input;
                //				//
                //				sql="WRITETEXT "+TableName+"."+ColumnPointerName+" @Pointer ''";
                //				sqlCmd.CommandText=sql;
                //				sqlCmd.ExecuteNonQuery();
                //����SQL��������������ݡ�
                strSQL = new StringBuilder();

                //				strSQL="Exec Update_StoreFile @Pointer,@Offset,@Bytes,'"+GWBH+"'";
                strSQL.AppendFormat("UPDATETEXT {0}.{1} @Pointer @Offset 0 @Bytes",
                    strTabName, strFldName);
                sqlCmd.CommandText = strSQL.ToString();
                //���������������Ķ��������͡�
                SqlParameter photoParm = sqlCmd.Parameters.Add("@Bytes", SqlDbType.Image, intBufferLen);
                //����������������ƫ������
                SqlParameter offsetParm = sqlCmd.Parameters.Add("@Offset", SqlDbType.Int);
                //��ʼֱΪ0��
                offsetParm.Value = 0;

                FileStream fs = new FileStream(strFileName, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                StateEventArgs e = new StateEventArgs(0, fs.Length);
                int offset_ctr = 0;
                byte[] buffer;
                do
                {
                    buffer = br.ReadBytes(intBufferLen);
                    photoParm.Value = buffer;
                    offsetParm.Value = offset_ctr;
                    sqlCmd.ExecuteNonQuery();
                    offset_ctr += intBufferLen;
                    e.currentFileLength = offset_ctr;
                    if (OnChange != null)
                        OnChange(e);
                } while (buffer.Length == intBufferLen);

                br.Close();
                fs.Close();
            }
            catch (Exception objException)
            {
                LogError(objException, "");
   
                throw objException; //throw new Exception(EXCEPTION_MSG + objException.Message, objException);
                //				return null;
            }
            finally
            {
                m_oConn.Close();
            }
        }

        /// <summary>
        /// ���ܣ���ָ���ļ������ݴ���������������ָ�����ֶ��С�
        /// </summary>
        /// <param name="strFileName">��Ҫ�����ļ����ݵ��ļ���</param>
        /// <param name="strTabName">��Ҫ�����ļ����ݵ�Ŀ�����ݱ���</param>
        /// <param name="strFldName">��Ҫ�����ļ����ݵ�Ŀ�����ݱ���ֶ���</param>
        /// <param name="strCondition">��Ҫ�����ļ����ݵ�Ŀ�����ݱ��о�����¼�������ַ���</param>
        public void StoreFile(string strFileName,
            string strTabName,
            string strFldName,
            string strCondition)
        {
            StoreFile(strFileName,
                strTabName,
                strFldName,
                strCondition,
                1024);
        }

        /// <summary>
        /// ���ܣ�������������ָ�����ֶ��е�����ȡ���������Ҳ��Ҵ���������ļ����С�
        /// </summary>
        /// <param name="strFileName">��Ҫ�����ļ����ݵ��ļ���</param>
        /// <param name="strTabName">��Ҫ��ȡ�ļ����ݵ�Ŀ�����ݱ���</param>
        /// <param name="strFldName">��Ҫ��ȡ�ļ����ݵ�Ŀ�����ݱ���ֶ���</param>
        /// <param name="strCondition">��Ҫ��ȡ�ļ����ݵ�Ŀ�����ݱ��о�����¼�������ַ���</param>
        /// <param name="intBufferLen">��ȡ����ʱ�Ļ���������</param>
        public bool GetFile(string strFileName,
            string strTabName,
            string strFldName,
            string strCondition,
            int intBufferLen)
        {
            bool bolIsHaveFile = false; //�Ƿ����ļ�
            StringBuilder strSQL = new StringBuilder();
            FileStream fs;                          // Writes the BLOB to a file (*.bmp).
            BinaryWriter bw;                        // Streams the BLOB to the FileStream object.
            m_oConn = getConnectObj(this.p_sConnectString);
            try
            {
                //string sql="SELECT DATALENGTH("+ColumnPointerName+") length,"+ColumnPointerName+" FROM "+TableName+" WHERE "+ColumnIDName+"='"+ID+"'";
                //				string sql=@"select DATALENGTH(PHOTO) length,PHOTO from PHOTO where GWBH='"+GWBH+"'";
                strSQL.AppendFormat("select DATALENGTH({0}) length,{0} from {1} where {2} and {0} is not null",
                    strFldName, strTabName, strCondition);

                SqlCommand sqlCmd = new SqlCommand();
                //sqlCmd.CommandType =CommandType.Text;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Connection = m_oConn;

                sqlCmd.CommandTimeout = 9600;
                sqlCmd.CommandText = strSQL.ToString();
                byte[] outbyte = new byte[intBufferLen];  // The BLOB byte[] buffer to be filled by GetBytes.
                long retval;                            // The bytes returned from GetBytes.
                long startIndex = 0;                    // The starting position in the BLOB output.
                // Open the connection and read data into the DataReader.
                //m_oConn.Open();
                SqlDataReader myReader = sqlCmd.ExecuteReader(CommandBehavior.SequentialAccess);

                //��������Ŀ¼�����ھ��½���Ŀ¼
                string strFolder;
                strFolder = ParentDir(strFileName);
                //        '��ÿһ�����Կ��е�����ɾ����
                if (System.IO.Directory.Exists(strFolder) == false)
                {
                    Directory.CreateDirectory(strFolder);
                }
                // Create a file to hold the output.
                fs = new FileStream(strFileName, FileMode.Create, FileAccess.Write);
                bw = new BinaryWriter(fs);

                // Reset the starting byte for the new BLOB.
                startIndex = 0;

                //myReader���ж��������ɹ��򷵻� true ��
                if (myReader.Read())
                {
                    // blen �����ļ����ȡ�
                    int blen = (int)myReader.GetInt32(0);

                    //					//������ί�С�
                    StateEventArgs e = new StateEventArgs(0, blen);
                    // Read the bytes into outbyte[] and retain the number of bytes returned.
                    retval = myReader.GetBytes(1, startIndex, outbyte, 0, intBufferLen);
                    // Continue reading and writing while there are bytes beyond the size of the buffer.
                    while (retval == intBufferLen)
                    {
                        bw.Write(outbyte);
                        bw.Flush();
                        // Reposition the start index to the end of the last buffer and fill the buffer.
                        startIndex += intBufferLen;
                        retval = myReader.GetBytes(1, startIndex, outbyte, 0, intBufferLen);
                        e.currentFileLength = startIndex;
                        if (OnChange != null)
                            OnChange(e);
                    }

                    // Write the remaining buffer.
                    bw.Write(outbyte, 0, (int)retval);
                    bw.Flush();

                    e.currentFileLength = blen;
                    if (OnChange != null)
                        OnChange(e);
                    // Close the output file.
                    bw.Close();
                    fs.Close();
                    bolIsHaveFile = true;
                }
                // Close the reader and the connection.
                myReader.Close();
                return bolIsHaveFile;
                //				m_oConn.CloseB();		
            }
            catch (Exception objException)
            {
                LogError(objException, "");
       
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
                //				return null;
            }
            finally
            {
                m_oConn.Close();
            }
        }
        /// <summary>
        /// ��Ŀ¼
        /// </summary>
        /// <param name="strPath">������Ŀ¼</param>
        /// <returns>��Ŀ¼��</returns>
        public string ParentDir(string strPath)
        {
            string pDir;
            int i;
            i = strPath.LastIndexOf("\\");
            if (i == 0) return null;
            pDir = strPath.Substring(0, i);
            return pDir;
        }

        /// <summary>
        /// ���ܣ�������������ָ�����ֶ��е�����ȡ���������Ҳ��Ҵ���������ļ����С�
        /// </summary>
        /// <param name="strFileName">��Ҫ�����ļ����ݵ��ļ���</param>
        /// <param name="strTabName">��Ҫ��ȡ�ļ����ݵ�Ŀ�����ݱ���</param>
        /// <param name="strFldName">��Ҫ��ȡ�ļ����ݵ�Ŀ�����ݱ���ֶ���</param>
        /// <param name="strCondition">��Ҫ��ȡ�ļ����ݵ�Ŀ�����ݱ��о�����¼�������ַ���</param>
        /// <returns>�Ƿ�ɹ���</returns>
        public bool GetFile(string strFileName,
            string strTabName,
            string strFldName,
            string strCondition)
        {
            return GetFile(strFileName,
                strTabName,
                strFldName,
                strCondition,
                1024);
            //			GetFile(fileName,ID,1024);
        }
        /// <summary>
        /// ��ȡ���йؼ��ֵ����ֵ�����ַ�����ʾ
        /// </summary>
        /// <param name="strTabName">����</param>
        /// <param name="strFldName">�ֶ���</param>
        /// <param name="intFldLen">�ֶγ���</param>
        /// <param name="strPrefix">ǰ׺</param>
        /// <returns>��ȡ���йؼ��ֵ����ֵ</returns>
        public string GetMaxStrId(string strTabName, string strFldName, int intFldLen, string strPrefix)
        {
            SqlCommand sqlCmd;
            SqlDataAdapter sqlAdp;
            int intPrefixLen;

            System.Data.DataTable objDT;
            StringBuilder strSQL = new StringBuilder();
            intPrefixLen = strPrefix.Length;
            if (strPrefix == "")
            {
                strSQL.AppendFormat("select Max({0}) from {1}", strFldName, strTabName);
            }
            else
            {
                strSQL.AppendFormat("select Max({0}) from {1} where {0} like '{2}%'",
                    strFldName, strTabName, strPrefix);
            }
          
            m_oConn = getConnectObj(this.p_sConnectString);
            try
            {
                sqlCmd = new SqlCommand();
                sqlCmd.Connection = m_oConn;
                sqlCmd.CommandType = CommandType.Text;

                sqlCmd.CommandTimeout = 9600;
                sqlCmd.CommandText = strSQL.ToString();
                sqlAdp = new SqlDataAdapter();
                sqlAdp.SelectCommand = sqlCmd;
                objDT = new DataTable();
                sqlAdp.Fill(objDT);
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    SqlStatement objSqlStatementEN = null;
                    try
                    {
                        objSqlStatementEN = SqlStatementAC.AnalysisSqlStatement(strSQL.ToString());
                        string strMsg = SqlStatementAC.GetSqlStatementAnalysisInfo(objSqlStatementEN, objDT.Rows.Count);
                        ////s1trMsg += string.Format("|�ײ㺯��:[GetMaxStrId]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("����{0}|Sql���:[{1}]|�ײ㺯��:[GetMaxStrId]",
                            objException.Message, strSQL.ToString());
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                }
            }
            catch (Exception objException)
            {
                LogError(objException, "");
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    string strMsg = string.Format("����{0}. Sql��䣺{1}", objException.Message, strSQL.ToString());
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                        intCurrLevel++;
                        if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                    }
                    clsDebugBase_Sql.WriteLog(strMsg);
                }
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
            }
            finally
            {
                m_oConn.Close();
            }

            if (objDT.Rows.Count == 0)
            {
                return strPrefix + combineStr("0", intFldLen - 1 - intPrefixLen) + "1";

            }
            string strMaxValue = objDT.Rows[0][0].ToString();
            if (strMaxValue == "")
            {
                return strPrefix + combineStr("0", intFldLen - 1 - intPrefixLen) + "1";
            }

            int intNextMaxValue, intLen;
            string strNextMaxValue, strTemp;
            if (strPrefix == "")
            {
                intNextMaxValue = int.Parse(strMaxValue) + 1;
                strNextMaxValue = intNextMaxValue.ToString();
                intLen = strNextMaxValue.Length;
                strNextMaxValue = combineStr("0", intFldLen - intLen) + strNextMaxValue;
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    string strMsg = string.Format("��ȡ�����ֵ��[{0}]|�ײ㺯��:[GetMaxStrId]",
                        strNextMaxValue);
                    clsDebugBase_Sql.WriteLog(strMsg);
                }
                return strNextMaxValue;
            }
            else
            {
                strTemp = strMaxValue.Substring(intPrefixLen);
                intNextMaxValue = int.Parse(strTemp) + 1;
                strNextMaxValue = intNextMaxValue.ToString();
                intLen = strNextMaxValue.Length;
                strNextMaxValue = strPrefix + combineStr("0", intFldLen - intLen - intPrefixLen) + strNextMaxValue;
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    string strMsg = string.Format("��ȡ�����ֵ��[{0}]|�ײ㺯��:[GetMaxStrId]",
                        strNextMaxValue);
                    clsDebugBase_Sql.WriteLog(strMsg);
                }
                return strNextMaxValue;
            }
        }


        public string GetMaxStrId(string strTabName, string strFldName, int intFldLen, string strPrefix, int intAdditionValue)
        {
            SqlCommand sqlCmd;
            SqlDataAdapter sqlAdp;
            int intPrefixLen;

            System.Data.DataTable objDT;
            StringBuilder strSQL = new StringBuilder();
            intPrefixLen = strPrefix.Length;

            if (strPrefix == "")
            {
                strSQL.AppendFormat("select Max({0}) from {1}", strFldName, strTabName);
            }
            else
            {
                strSQL.AppendFormat("select Max({0}) from {1} where {0} like '{2}%'",
                    strFldName, strTabName, strPrefix);
            }
          
            m_oConn = getConnectObj(this.p_sConnectString);
            try
            {
                sqlCmd = new SqlCommand();
                sqlCmd.Connection = m_oConn;
                sqlCmd.CommandType = CommandType.Text;

                sqlCmd.CommandTimeout = 9600;
                sqlCmd.CommandText = strSQL.ToString();
                sqlAdp = new SqlDataAdapter();
                sqlAdp.SelectCommand = sqlCmd;
                objDT = new DataTable();
                sqlAdp.Fill(objDT);
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    SqlStatement objSqlStatementEN = null;
                    try
                    {
                        objSqlStatementEN = SqlStatementAC.AnalysisSqlStatement(strSQL.ToString());
                        string strMsg = SqlStatementAC.GetSqlStatementAnalysisInfo(objSqlStatementEN, objDT.Rows.Count);
                        //s1trMsg += string.Format("|�ײ㺯��:[GetMaxStrId]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("����{0}|Sql���:[{1}]|�ײ㺯��:[GetMaxStrId]",
                            objException.Message, strSQL.ToString());
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                }
            }
            catch (Exception objException)
            {
                LogError(objException, "");
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    string strMsg = string.Format("����{0}. Sql��䣺{1}", objException.Message, strSQL.ToString());
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|�����ຯ��{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                        intCurrLevel++;
                        if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                    }
                    clsDebugBase_Sql.WriteLog(strMsg);
                }
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
            }
            finally
            {
                m_oConn.Close();
            }

            if (objDT.Rows.Count == 0)
            {
                return strPrefix + combineStr("0", intFldLen - 1 - intPrefixLen) + "1";

            }
            string strMaxValue = objDT.Rows[0][0].ToString();
            if (strMaxValue == "")
            {
                strMaxValue = "0";
            }

            int intNextMaxValue, intLen;
            string strNextMaxValue, strTemp;
            if (strPrefix == "")
            {
                intNextMaxValue = int.Parse(strMaxValue) + 1 + intAdditionValue;
                strNextMaxValue = intNextMaxValue.ToString();
                intLen = strNextMaxValue.Length;
                strNextMaxValue = combineStr("0", intFldLen - intLen) + strNextMaxValue;
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    string strMsg = string.Format("��ȡ�����ֵ��[{0}]|�ײ㺯��:[GetMaxStrId]",
                        strNextMaxValue);
                    clsDebugBase_Sql.WriteLog(strMsg);
                }
                return strNextMaxValue;
            }
            else
            {
                if (strMaxValue == "0")
                {
                    intNextMaxValue = 0 + 1 + intAdditionValue;
                }
                else
                {
                    strTemp = strMaxValue.Substring(intPrefixLen);
                    intNextMaxValue = int.Parse(strTemp) + 1 + intAdditionValue;
                }
                strNextMaxValue = intNextMaxValue.ToString();
                intLen = strNextMaxValue.Length;
                strNextMaxValue = strPrefix + combineStr("0", intFldLen - intLen - intPrefixLen) + strNextMaxValue;
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    string strMsg = string.Format("��ȡ�����ֵ��[{0}]|�ײ㺯��:[GetMaxStrId]",
                        strNextMaxValue);
                    clsDebugBase_Sql.WriteLog(strMsg);
                }
                return strNextMaxValue;
            }
        }

        /// <summary>
        /// ��װ�ַ�����
        /// </summary>
        /// <param name="mStr">ԭ�����ַ���</param>
        /// <param name="count">���ַ������ظ�����</param>
        /// <returns>��װ�õ��ַ���</returns>
        public static string combineStr(string mStr, int count)
        {
            string strTemp = "";
            for (int i = 0; i < count; i++)
                strTemp += mStr;
            return strTemp;
        }

        #endregion

        //XML Methods
        #region "XML Methods"

        public bool ExecStoredProcedure(string sSPName, ArrayList paramValues)
        {
            //by davidfujian 2004-3-21 NOON
            //Exec a SP with long parameters

            //1.����ExecStoredProcedureReturnDT
            //2.����stored procedure,Ϊ�����Ȩ��
            //3.����xml�ĵ�
            //4.����BuildParametersΪprotected

            SqlCommand sqlCmd;
            m_oConn = getConnectObj(this.p_sConnectString);

            try
            {
                sqlCmd = new SqlCommand();
                sqlCmd.CommandText = sSPName;

                sqlCmd.CommandTimeout = 9600;
                sqlCmd.Connection = m_oConn;
                sqlCmd.CommandType = CommandType.StoredProcedure;
                BuildParameters(sqlCmd, paramValues);
                sqlCmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception objException)
            {
                LogError(objException, "");
  
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
                //				return false;
            }

            finally
            {
                m_oConn.Close();
            }
        }

        public bool ExecSP(string SPName, ArrayList ParamValues)
        {

            SqlCommand objCommand;
            m_oConn = getConnectObj(this.p_sConnectString);

            ValidateSPName(SPName);
            try
            {
                //Instantiate a new SQLCommand object.
                objCommand = new SqlCommand(SPName, m_oConn);
                //We are using a stored procedure for the CommandType.
                objCommand.CommandType = CommandType.StoredProcedure;
                //Build the parameters for the SqlCommand object.
                BuildParameters(objCommand, ParamValues);
                //Execute the stored procedure, and do not return any rows
                objCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception objException)
            {
                string strAdditionMsg;
                int intParamCounter;
                int intParamNums;
                strAdditionMsg = "SPName:=" + SPName;
                intParamNums = ParamValues.Count;
                for (intParamCounter = 0; intParamCounter < intParamNums; intParamCounter++)
                {
                    strAdditionMsg += ParamValues[intParamCounter];
                }
                //			'Log the error to the Application Log.
                LogError(objException, "");
                //			'Throw a new exception, with the original exception nested.
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
                //				return false;
            }
            finally
            {
                m_oConn.Close();
            }
        }


        public bool ExecSP(string SPName, ArrayList ParamValues, int intCommandTimeout)
        {

            SqlCommand objCommand;
            m_oConn = getConnectObj(this.p_sConnectString);

            ValidateSPName(SPName);
            try
            {
                //Instantiate a new SQLCommand object.
                objCommand = new SqlCommand(SPName, m_oConn);
                objCommand.CommandTimeout = intCommandTimeout;
                //We are using a stored procedure for the CommandType.
                objCommand.CommandType = CommandType.StoredProcedure;
                //Build the parameters for the SqlCommand object.
                BuildParameters(objCommand, ParamValues);
                //Execute the stored procedure, and do not return any rows
                objCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception objException)
            {
                string strAdditionMsg;
                int intParamCounter;
                int intParamNums;
                strAdditionMsg = "SPName:=" + SPName;
                intParamNums = ParamValues.Count;
                for (intParamCounter = 0; intParamCounter < intParamNums; intParamCounter++)
                {
                    strAdditionMsg += ParamValues[intParamCounter];
                }
                //			'Log the error to the Application Log.
                LogError(objException, "");
                //			'Throw a new exception, with the original exception nested.
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
                //				return false;
            }
            finally
            {
                m_oConn.Close();
            }
        }

        public bool ExecSP2(string SPName, ArrayList ParamValues)
        {

            SqlCommand objCommand;
            m_oConn = getConnectObj(this.p_sConnectString);

            ValidateSPName(SPName);
            try
            {
                //Instantiate a new SQLCommand object.
                objCommand = new SqlCommand(SPName, m_oConn);
                //We are using a stored procedure for the CommandType.
                objCommand.CommandType = CommandType.StoredProcedure;
                //Build the parameters for the SqlCommand object.
                BuildParameters2(objCommand, SPName, ParamValues);
                //Execute the stored procedure, and do not return any rows
                int intRecCount = objCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception objException)
            {
                string strAdditionMsg;
                int intParamCounter;
                int intParamNums;
                strAdditionMsg = "SPName:=" + SPName;
                intParamNums = ParamValues.Count;
                for (intParamCounter = 0; intParamCounter < intParamNums; intParamCounter++)
                {
                    strAdditionMsg += ParamValues[intParamCounter];
                }
                //			'Log the error to the Application Log.
                LogError(objException, "");
                //			'Throw a new exception, with the original exception nested.
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
                //				return false;
            }
            finally
            {

                m_oConn.Close();
            }
        }

        public bool ExecSP2(string SPName, ArrayList ParamValues, SqlConnection objSqlConnect, SqlTransaction objSqlTransaction)
        {

            SqlCommand objCommand;
            ValidateSPName(SPName);
            try
            {
                //Instantiate a new SQLCommand object.
                objCommand = new SqlCommand(SPName, objSqlConnect);
                objCommand.Transaction = objSqlTransaction;
                //We are using a stored procedure for the CommandType.
                objCommand.CommandType = CommandType.StoredProcedure;
                //Build the parameters for the SqlCommand object.
                BuildParameters2(objCommand, SPName, ParamValues);
                //Execute the stored procedure, and do not return any rows
                objCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception objException)
            {
                string strAdditionMsg;
                int intParamCounter;
                int intParamNums;
                strAdditionMsg = "SPName:=" + SPName;
                intParamNums = ParamValues.Count;
                for (intParamCounter = 0; intParamCounter < intParamNums; intParamCounter++)
                {
                    strAdditionMsg += ParamValues[intParamCounter];
                }
                //			'Log the error to the Application Log.
                LogError(objException, "");
                //			'Throw a new exception, with the original exception nested.
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
                //				return false;
            }
            finally
            {
                
            }
        }

        public bool ExecSP2(string SPName, ArrayList ParamValues, int intCommandTimeout)
        {

            SqlCommand objCommand;
            m_oConn = getConnectObj(this.p_sConnectString);

            ValidateSPName(SPName);
            try
            {
                //Instantiate a new SQLCommand object.
                objCommand = new SqlCommand(SPName, m_oConn);
                objCommand.CommandTimeout = intCommandTimeout;

                //We are using a stored procedure for the CommandType.
                objCommand.CommandType = CommandType.StoredProcedure;
                //Build the parameters for the SqlCommand object.
                BuildParameters2(objCommand, SPName, ParamValues);
                //Execute the stored procedure, and do not return any rows
                int intRecCount = objCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception objException)
            {
                string strAdditionMsg;
                int intParamCounter;
                int intParamNums;
                strAdditionMsg = "SPName:=" + SPName;
                intParamNums = ParamValues.Count;
                for (intParamCounter = 0; intParamCounter < intParamNums; intParamCounter++)
                {
                    strAdditionMsg += ParamValues[intParamCounter];
                }
                //			'Log the error to the Application Log.
                LogError(objException, "");
                //			'Throw a new exception, with the original exception nested.
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
                //				return false;
            }
            finally
            {
                m_oConn.Close();
            }
        }

        public bool ExecSP2(string SPName, ArrayList ParamValues, int intCommandTimeout, SqlConnection objSqlConnect, SqlTransaction objSqlTransaction)
        {

            SqlCommand objCommand;
            ValidateSPName(SPName);
            try
            {
                //Instantiate a new SQLCommand object.
                objCommand = new SqlCommand(SPName, objSqlConnect);
                objCommand.CommandTimeout = intCommandTimeout;
                objCommand.Transaction = objSqlTransaction;
                //We are using a stored procedure for the CommandType.
                objCommand.CommandType = CommandType.StoredProcedure;
                //Build the parameters for the SqlCommand object.
                BuildParameters2(objCommand, SPName, ParamValues);
                //Execute the stored procedure, and do not return any rows
                objCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception objException)
            {
                string strAdditionMsg;
                int intParamCounter;
                int intParamNums;
                strAdditionMsg = "SPName:=" + SPName;
                intParamNums = ParamValues.Count;
                for (intParamCounter = 0; intParamCounter < intParamNums; intParamCounter++)
                {
                    strAdditionMsg += ParamValues[intParamCounter];
                }
                //			'Log the error to the Application Log.
                LogError(objException, "");
                //			'Throw a new exception, with the original exception nested.
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
                //				return false;
            }
            finally
            {
          
            }
        }

        public ArrayList ExecSpWithOutPut(string SPName, ArrayList ParamValues)
        {
            ArrayList arrLst = new ArrayList();
            SqlCommand objCommand;
            m_oConn = getConnectObj(this.p_sConnectString);

            try
            {
                ValidateSPName(SPName);
                //Instantiate a new SQLCommand object.
                objCommand = new SqlCommand(SPName, m_oConn);
                //We are using a stored procedure for the CommandType.
                objCommand.CommandType = CommandType.StoredProcedure;
                //Build the parameters for the SqlCommand object.
                BuildParameters(objCommand, ParamValues);
                //Execute the stored procedure, and do not return any rows
                int intRecCount = objCommand.ExecuteNonQuery();


                //                'Build the ArrayList of output values
                foreach (SqlParameter objParameter in objCommand.Parameters)
                {
                    if (objParameter.Direction == ParameterDirection.Output)
                    {
                        arrLst.Add(objParameter.Value);
                    }
                }

                //                'Return the output values
                return arrLst;
            }
            catch (Exception objException)
            {
                string strAdditionMsg;
                int intParamCounter;
                int intParamNums;
                strAdditionMsg = "SPName:=" + SPName;
                intParamNums = ParamValues.Count;
                for (intParamCounter = 0; intParamCounter < intParamNums; intParamCounter++)
                {
                    strAdditionMsg += ParamValues[intParamCounter];
                }
                //			'Log the error to the Application Log.
                LogError(objException, strAdditionMsg);
                //			'Throw a new exception, with the original exception nested.
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message + "\r\n" + strAdditionMsg, objException);
                //				return false;
            }
            finally
            {
                m_oConn.Close();
            }
        }
        public string ExecSpWithReturn2(string SPName, ArrayList ParamValues)
        {
            SqlCommand objCommand;

            m_oConn = getConnectObj(this.p_sConnectString);
            try
            {
                ValidateSPName(SPName);
                //Instantiate a new SQLCommand object.
                objCommand = new SqlCommand(SPName, m_oConn);
                //We are using a stored procedure for the CommandType.
                objCommand.CommandType = CommandType.StoredProcedure;
                //Build the parameters for the SqlCommand object.
                BuildParameters2(objCommand, SPName, ParamValues);
                //Execute the stored procedure, and do not return any rows
                SqlParameter objParameter1 = new SqlParameter("@RETURN_VALUE", SqlDbType.Int);
                objParameter1.Size = 4;
                objParameter1.Direction = ParameterDirection.ReturnValue;
                objCommand.Parameters.Add(objParameter1);

                objCommand.ExecuteNonQuery();

                
                //                'Build the ArrayList of output values
                foreach (SqlParameter objParameter in objCommand.Parameters)
                {
                    if (objParameter.Direction == ParameterDirection.ReturnValue)
                    {
                        return objParameter.Value.ToString();
                    }
                }
                return "";
            }
            catch (Exception objException)
            {
                string strAdditionMsg;
                int intParamCounter;
                int intParamNums;
                strAdditionMsg = "SPName:=" + SPName;
                intParamNums = ParamValues.Count;
                for (intParamCounter = 0; intParamCounter < intParamNums; intParamCounter++)
                {
                    strAdditionMsg += ParamValues[intParamCounter];
                }
                //			'Log the error to the Application Log.
                LogError(objException, strAdditionMsg);
                //			'Throw a new exception, with the original exception nested.
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message + "\r\n" + strAdditionMsg, objException);
                //				return false;
            }
            finally
            {
                m_oConn.Close();
            }
        }

        public string  ExecSpWithReturn2(string SPName, ArrayList ParamValues, SqlConnection objSqlConnect, SqlTransaction objSqlTransaction)
        {
            SqlCommand objCommand;
            try
            {
                ValidateSPName(SPName);
                //Instantiate a new SQLCommand object.
                objCommand = new SqlCommand(SPName, objSqlConnect);
                objCommand.Transaction = objSqlTransaction;
                //We are using a stored procedure for the CommandType.
                objCommand.CommandType = CommandType.StoredProcedure;
                //Build the parameters for the SqlCommand object.
                BuildParameters2(objCommand, SPName, ParamValues);
                SqlParameter objParameter1 = new SqlParameter("@RETURN_VALUE", SqlDbType.Int);
                objParameter1.Size = 4;
                objParameter1.Direction = ParameterDirection.ReturnValue;
                objCommand.Parameters.Add(objParameter1);
                //Execute the stored procedure, and do not return any rows
                objCommand.ExecuteNonQuery();
                //                'Build the ArrayList of output values
                foreach (SqlParameter objParameter in objCommand.Parameters)
                {
                    if (objParameter.Direction == ParameterDirection.Output)
                    {
                        return objParameter.Value.ToString();
                    }
                }
                return "";
            }
            catch (Exception objException)
            {
                string strAdditionMsg;
                int intParamCounter;
                int intParamNums;
                strAdditionMsg = "SPName:=" + SPName;
                intParamNums = ParamValues.Count;
                for (intParamCounter = 0; intParamCounter < intParamNums; intParamCounter++)
                {
                    strAdditionMsg += ParamValues[intParamCounter];
                }
                //			'Log the error to the Application Log.
                LogError(objException, strAdditionMsg);
                //			'Throw a new exception, with the original exception nested.
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message + "\r\n" + strAdditionMsg, objException);
                //				return false;
            }
            finally
            {

            }
        }

        public ArrayList ExecSpWithOutPut2(string SPName, ArrayList ParamValues)
        {
            ArrayList arrLst = new ArrayList();
            SqlCommand objCommand;

            m_oConn = getConnectObj(this.p_sConnectString);
            try
            {
                ValidateSPName(SPName);
                //Instantiate a new SQLCommand object.
                objCommand = new SqlCommand(SPName, m_oConn);
                //We are using a stored procedure for the CommandType.
                objCommand.CommandType = CommandType.StoredProcedure;
                //Build the parameters for the SqlCommand object.
                BuildParameters2(objCommand, SPName, ParamValues);
                //Execute the stored procedure, and do not return any rows
                objCommand.ExecuteNonQuery();


                //                'Build the ArrayList of output values
                foreach (SqlParameter objParameter in objCommand.Parameters)
                {
                    if (objParameter.Direction == ParameterDirection.Output)
                    {
                        arrLst.Add(objParameter.Value);
                    }
                }

                //                'Return the output values
                return arrLst;
            }
            catch (Exception objException)
            {
                string strAdditionMsg;
                int intParamCounter;
                int intParamNums;
                strAdditionMsg = "SPName:=" + SPName;
                intParamNums = ParamValues.Count;
                for (intParamCounter = 0; intParamCounter < intParamNums; intParamCounter++)
                {
                    strAdditionMsg += ParamValues[intParamCounter];
                }
                //			'Log the error to the Application Log.
                LogError(objException, strAdditionMsg);
                //			'Throw a new exception, with the original exception nested.
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message + "\r\n" + strAdditionMsg, objException);
                //				return false;
            }
            finally
            {
                m_oConn.Close();
            }
        }

        public ArrayList ExecSpWithOutPut2(string SPName, ArrayList ParamValues, SqlConnection objSqlConnect, SqlTransaction objSqlTransaction)
        {
            ArrayList arrLst = new ArrayList();
            SqlCommand objCommand;
            try
            {
                ValidateSPName(SPName);
                //Instantiate a new SQLCommand object.
                objCommand = new SqlCommand(SPName, objSqlConnect);
                objCommand.Transaction = objSqlTransaction;
                //We are using a stored procedure for the CommandType.
                objCommand.CommandType = CommandType.StoredProcedure;
                //Build the parameters for the SqlCommand object.
                BuildParameters2(objCommand, SPName, ParamValues);
                //Execute the stored procedure, and do not return any rows
                objCommand.ExecuteNonQuery();


                //                'Build the ArrayList of output values
                foreach (SqlParameter objParameter in objCommand.Parameters)
                {
                    if (objParameter.Direction == ParameterDirection.Output)
                    {
                        arrLst.Add(objParameter.Value);
                    }
                }

                //                'Return the output values
                return arrLst;
            }
            catch (Exception objException)
            {
                string strAdditionMsg;
                int intParamCounter;
                int intParamNums;
                strAdditionMsg = "SPName:=" + SPName;
                intParamNums = ParamValues.Count;
                for (intParamCounter = 0; intParamCounter < intParamNums; intParamCounter++)
                {
                    strAdditionMsg += ParamValues[intParamCounter];
                }
                //			'Log the error to the Application Log.
                LogError(objException, strAdditionMsg);
                //			'Throw a new exception, with the original exception nested.
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message + "\r\n" + strAdditionMsg, objException);
                //				return false;
            }
            finally
            {
               
            }
        }


        protected void ValidateSPName(string SPName)
        {
            //'The name must be between 1 and 128 characters long.
            if (SPName.Length < 1 || SPName.Length > 128)
            {
                throw new Exception("A valid stored procedure name must be provided.");
            }
        }

        protected void LogError(Exception objException, string strAdditionMsg)
        {
            //'Log the error information to the Application Log
            string strLogMsg;
            try
            {
                strLogMsg = "An error occurred in the following module: "
                    + mstrModuleName + "\r\n"
                    + "Source: " + objException.Source + "\r\n"
                    + "Message: " + objException.Message + "\r\n"
                    + "Stack Trace:  " + objException.StackTrace + "\r\n"
                    + "Target Site:  " + objException.TargetSite.ToString() + "\r\n"
                    + strAdditionMsg;
                //'Write error to event log
                System.Diagnostics.EventLog.WriteEntry(mstrModuleName, strLogMsg, System.Diagnostics.EventLogEntryType.Error);
            }
            catch
            {
            }
        }

        public SqlParameter ExecStoredProcedure(SqlCommand cmd, ArrayList paramValues)
        {
            //�û�������ʹ�ø÷���ǰ��Ϊcmd����
            m_oConn = getConnectObj(this.p_sConnectString);

            try
            {
                cmd.Connection = m_oConn;
                cmd.CommandTimeout = 9600;
                cmd.CommandType = CommandType.StoredProcedure;
                BuildParameters(cmd, paramValues);
                cmd.ExecuteNonQuery();
                return cmd.Parameters[0];
            }
            catch (Exception objException)
            {
                LogError(objException, "");
 
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
                //				return null;
            }

            finally
            {
                m_oConn.Close();
            }

        }
        public SqlParameter ExecStoredProcedure2(SqlCommand cmd, String strSP_Name, ArrayList paramValues)
        {
            //�û�������ʹ�ø÷���ǰ��Ϊcmd����
            m_oConn = getConnectObj(this.p_sConnectString);

            try
            {
                cmd.Connection = m_oConn;
                cmd.CommandType = CommandType.StoredProcedure;
                BuildParameters2(cmd,strSP_Name, paramValues);
                cmd.ExecuteNonQuery();
                return cmd.Parameters[0];
            }
            catch (Exception objException)
            {
                LogError(objException, "");
          
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
                //				return null;
            }

            finally
            {
                m_oConn.Close();
            }

        }

        public SqlParameter ExecStoredProcedure2(SqlCommand cmd, String strSP_Name, ArrayList paramValues, SqlConnection objSqlConnect, SqlTransaction objSqlTransaction)
        {
            //�û�������ʹ�ø÷���ǰ��Ϊcmd����
           
            try
            {
                cmd.Connection = objSqlConnect;
                cmd.Transaction = objSqlTransaction;
                cmd.CommandType = CommandType.StoredProcedure;
                BuildParameters2(cmd, strSP_Name, paramValues);
                cmd.ExecuteNonQuery();
                return cmd.Parameters[0];
            }
            catch (Exception objException)
            {
                LogError(objException, "");
     
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
                //				return null;
            }

            finally
            {
               
            }

        }
        
        public SqlParameterCollection ExecStoredProcedureColle(SqlCommand cmd, ArrayList paramValues)
        {
            //�û�������ʹ�ø÷���ǰ��Ϊcmd����
            m_oConn = getConnectObj(this.p_sConnectString);

            try
            {
                cmd.Connection = m_oConn;
                cmd.CommandType = CommandType.StoredProcedure;
                BuildParameters(cmd, paramValues);
                cmd.ExecuteNonQuery();
                return cmd.Parameters;
            }
            catch (Exception objException)
            {
                LogError(objException, "");
   
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
                //				return null;
            }

            finally
            {
                m_oConn.Close();
            }
        }

        public DataSet ExecSPReturnDS(string sSPName, ArrayList paramValues, string stablename)
        {

            //by davidfujian 2004-3-21 NOON
            //Exec a SP with long parameters and return a DataSet
            DataSet ds = new DataSet();
            SqlCommand sqlCmd;
            m_oConn = getConnectObj(this.p_sConnectString);

            try
            {
                sqlCmd = new SqlCommand(sSPName, m_oConn);
                sqlCmd.CommandText = sSPName;

                sqlCmd.CommandTimeout = 9600;
                sqlCmd.Connection = m_oConn;
                sqlCmd.CommandType = CommandType.StoredProcedure;
                BuildParameters(sqlCmd, paramValues);

                SqlDataAdapter sqlDA = new SqlDataAdapter(sqlCmd);
                sqlDA.Fill(ds, stablename);

                return ds;
            }
            catch (Exception objException)
            {
                LogError(objException, "");
           
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
                //				return null;
            }
            finally
            {
                m_oConn.Close();
            }
        }

        public DataSet ExecSPReturnDS2(string sSPName, ArrayList paramValues, string stablename)
        {

            //by davidfujian 2004-3-21 NOON
            //Exec a SP with long parameters and return a DataSet
            DataSet ds = new DataSet();
            SqlCommand sqlCmd;
            m_oConn = getConnectObj(this.p_sConnectString);

            try
            {
                sqlCmd = new SqlCommand(sSPName, m_oConn);
                //sqlCmd.CommandText = sSPName;
                //sqlCmd.Connection = m_oConn;
                sqlCmd.CommandType = CommandType.StoredProcedure;
                BuildParameters2(sqlCmd, sSPName, paramValues);

                SqlDataAdapter sqlDA = new SqlDataAdapter(sqlCmd);
                sqlDA.Fill(ds, stablename);

                return ds;
            }
            catch (Exception objException)
            {
                LogError(objException, "");
   
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
                //				return null;
            }
            finally
            {
                m_oConn.Close();
            }
        }

        public DataSet ExecSPReturnDS2(string sSPName, ArrayList paramValues, string stablename, SqlConnection objSqlConnect, SqlTransaction objSqlTransaction)
        {

            //by davidfujian 2004-3-21 NOON
            //Exec a SP with long parameters and return a DataSet
            DataSet ds = new DataSet();
            SqlCommand sqlCmd;

            try
            {
                sqlCmd = new SqlCommand();
                sqlCmd.CommandText = sSPName;

                sqlCmd.CommandTimeout = 9600;
                sqlCmd.Connection = objSqlConnect;
                sqlCmd.Transaction = objSqlTransaction;
                sqlCmd.CommandType = CommandType.StoredProcedure;
                BuildParameters2(sqlCmd, sSPName, paramValues);

                SqlDataAdapter sqlDA = new SqlDataAdapter(sqlCmd);
                sqlDA.Fill(ds, stablename);

                return ds;
            }
            catch (Exception objException)
            {
                LogError(objException, "");
    
                throw objException; //throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
                //				return null;
            }
            finally
            {
          
            }
        }

        protected bool BuildParameters(SqlCommand cmd, ArrayList paramValues)
        {
            //by davidfujian at 3.17AM 2004-3-18
            //Get Sql Parameters form XML
            XmlDocument xdoc = new XmlDocument();
            XmlNodeList nodeList;
            if (mstrSPConfigXML.Length == 0 && m_sSPConfigXMLFile.Length == 0)
            {
                //'No parameters to add, so exit
                return false;
            }
            //See if there is an XML string of parameters
            //for the stored procedure
            if (mstrSPConfigXML.Length > 0)
            {
                //'Try to load the XML into a DOM
                try
                {
                    xdoc.LoadXml(mstrSPConfigXML);
                }
                catch (XmlException objXMLException)
                {

                    //'Throw an exception if the load failed
                    throw objXMLException;
                }
            }
            //'See if there is an XML file of parameters
            //'for the stored procedure
            if (mstrSPConfigXML.Length == 0 && m_sSPConfigXMLFile.Length > 0)
            {
                //'Try to load the XML into a DOM
                try
                {
                    xdoc.Load(m_sSPConfigXMLFile);
                }
                catch (XmlException objXMLException)
                {
                    //'Throw an exception if the load failed
                    throw objXMLException;
                }
            }
            //xdoc.Load(this.m_sSPConfigXMLFile);
            XmlElement root = xdoc.DocumentElement;
            nodeList = root.SelectNodes("/StoredProcedures/StoredProcedure[@name='" + cmd.CommandText + "']/Parameters/Parameter");
            SqlParameter objParameter;

            string strParameterName;
            int intParameterSize;
            SqlDbType intSQLDataType;
            ParameterDirection intParameterDirection;
            bool blnIsNullable;
            //byte bytPrecision;
            //byte bytScale;
            int intParamCounter = 0;
            object objParameterValue;

            try
            {
                foreach (XmlNode para in nodeList)
                {
                    //���"name" 
                    strParameterName = para.Attributes.GetNamedItem("name").Value;

                    //���"size"
                    intParameterSize = Int32.Parse(para.Attributes.GetNamedItem("size").Value);

                    //���"datatype"
                    intSQLDataType = GetSqlDataType(para.Attributes.GetNamedItem("datatype").Value);

                    //���"direction"
                    intParameterDirection = GetParamDirection(para.Attributes.GetNamedItem("direction").Value);

                    //���"precision"
                    //bytPrecision = Byte.Parse(para.Attributes.GetNamedItem("precision").Value);

                    //���"scale"
                    //bytScale = Byte.Parse(para.Attributes.GetNamedItem("scale").Value);

                    //���"isNullable"
                    blnIsNullable = Boolean.Parse(para.Attributes.GetNamedItem("isNullable").Value);

                    objParameter = new SqlParameter(strParameterName, intSQLDataType, intParameterSize);
                    //paramValues
                    objParameterValue = paramValues[intParamCounter];
                    objParameter.Value = objParameterValue;

                    //���÷���
                    objParameter.Direction = intParameterDirection;

                    //If the optional attributes have values, then set them.
                    //if (bytPrecision > 0) objParameter.Precision = bytPrecision;

                    //if (bytScale > 0) objParameter.Scale = bytScale;

                    cmd.Parameters.Add(objParameter);

                    intParamCounter = intParamCounter + 1;
       
                }
            }
            catch (Exception objException)
            {
                LogError(objException, "");
         
                throw objException;// throw new Exception(EXCEPTION_MSG1 + objException.Message, objException);
                //				return false;
            }

            finally
            {

            }
            return true;
        }
        protected bool BuildParameters2(SqlCommand cmd, string strSp_Name, ArrayList paramValues)
        {
            //by ���Է� at 2008-1-28
            SqlParameter objParameter;

            string strParameterName;
            int intParameterSize;
            SqlDbType intSQLDataType;
            ParameterDirection intParameterDirection;
            bool blnIsNullable;
            //byte bytPrecision;
            //byte bytScale;
            int intParamCounter = 0;
            object objParameterValue;

            clsSqlStoreProcedureEx objSqlSP = clsPubVar_PubDataBase.getSqlStoreProcedure(
                        p_sConnectString, strSp_Name);
            if (objSqlSP == null)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strS0002 = new clsResource().Property("s0002");
                //sbMessage.AppendFormat("�����ݿ���,û�д洢����:<{0}>,����ϵDBA!", strSp_Name);
                sbMessage.AppendFormat(strS0002, strSp_Name);
                throw new Exception(sbMessage.ToString());
            }
            if (objSqlSP.arrSpParamObjList.Count != paramValues.Count)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strS0003 = new clsResource().Property("s0003");
//                sbMessage.AppendFormat("�ڴ洢����:<{0}>�еĲ�������:<{1}>,���ݵĲ�������:<{2}>,���߲�һ��,����!",
                sbMessage.AppendFormat(strS0003,
                    strSp_Name,
                    objSqlSP.arrSpParamObjList.Count,
                    paramValues.Count);
                throw new Exception(sbMessage.ToString());
            }
            try
            {
                foreach (clsSqlSP_Para objSqlSp_Para in objSqlSP.arrSpParamObjList)
                {
                    //                listBox1.Items.Add(objSqlSp_Para.ParaName);

                    //���"name" 
                    strParameterName = objSqlSp_Para.ParaName;

                    //���"size"
                    intParameterSize = objSqlSp_Para.ParaSize;

                    //���"datatype"
                    intSQLDataType = GetSqlDataType(objSqlSp_Para.ParaDataType);

                    //���"direction"
                    intParameterDirection = GetParamDirection(objSqlSp_Para.ParaDirection);

                    //���"isNullable"
                    blnIsNullable = objSqlSp_Para.IsNullable;

                    objParameter = new SqlParameter(strParameterName, intSQLDataType, intParameterSize);
                    //paramValues
                    objParameterValue = paramValues[intParamCounter];
                    if (objParameterValue == null)
                    {
                        objParameterValue = System.DBNull.Value;
                    }
                    //���ֵ�����Ƿ���ȷ------------------------
                    if (objParameterValue != null && objParameterValue != System.DBNull.Value)
                    {
                        if (clsSqlObject.IsValid(objSqlSp_Para.ParaDataType, objParameterValue.ToString()) == false)
                        {
                            StringBuilder sbMessage = new StringBuilder();
                            sbMessage.AppendFormat("�ڴ洢����:<{0}>��,����:<{1}>������:<{2}>,�����ݽ�����ֵΪ<{3}>,������ƥ,����!",
                                strSp_Name,
                                objSqlSp_Para.ParaName,
                                objSqlSp_Para.ParaDataType,
                                objParameterValue.ToString());
                            throw new Exception(sbMessage.ToString());
                        }
                    }
                    //���ֵ�����Ƿ���ȷ=======================
                    objParameter.Value = objParameterValue;

                    //���÷���
                    objParameter.Direction = intParameterDirection;

                    //If the optional attributes have values, then set them.
                    //if (bytPrecision > 0) objParameter.Precision = bytPrecision;

                    //if (bytScale > 0) objParameter.Scale = bytScale;

                    cmd.Parameters.Add(objParameter);

                    intParamCounter = intParamCounter + 1;
            
                }
            }
            catch (Exception objException)
            {
                LogError(objException, "");
    
                throw new Exception(objException.Message, objException);
                //				return false;
            }

            finally
            {

            }
            return true;
        }       

        protected SqlDbType GetSqlDataType(string dbtype)
        {
            switch (dbtype)
            {
                case "BigInt":
                case "bigint":
                case "bigint identity":
                    return SqlDbType.BigInt;

                case "Binary":
                    return SqlDbType.Binary;

                case "Bit":
                case "bit":
                    return SqlDbType.Bit;

                case "Char":
                case "char":
                    return SqlDbType.Char;

                case "DateTime":
                case "datetime":
                    return SqlDbType.DateTime;

                case "Decimal":
                case "decimal":
                    return SqlDbType.Decimal;

                case "Float":
                case "float":
                case "double":
                    return SqlDbType.Float;

                case "Image":
                    return SqlDbType.Image;

                case "Int":
                case "int":
                case "int identity":
                    return SqlDbType.Int;

                case "Money":
                case "money":
                    return SqlDbType.Money;

                case "NChar":
                    return SqlDbType.NChar;

                case "NText":
                    return SqlDbType.NText;

                case "NVarChar":
                case "nvarchar":
                    return SqlDbType.NVarChar;

                case "Real":
                    return SqlDbType.Real;

                case "SmallDateTime":
                case "smalldatetime":
                    return SqlDbType.SmallDateTime;

                case "SmallInt":
                case "smallint":
                    return SqlDbType.SmallInt;

                case "SmallMoney":
                    return SqlDbType.SmallMoney;

                case "Text":
                case "text":                    
                    return SqlDbType.Text;

                case "Timestamp":
                case "timestamp":
                    return SqlDbType.Timestamp;

                case "TinyInt":
                case "tinyint":
                    return SqlDbType.TinyInt;

                case "UniqueIdentifier":
                    return SqlDbType.UniqueIdentifier;

                case "VarBinary":
                    return SqlDbType.VarBinary;

                case "VarChar":
                case "varchar":
                    return SqlDbType.VarChar;

                case "image":
                    return SqlDbType.Image;

                case "Variant":
                    return SqlDbType.Variant;

                default:
                    //Default to Variant if anything else is supplied
                    return SqlDbType.Variant;

            }
        }

        protected ParameterDirection GetParamDirection(string ParamDirection)
        {
            switch (ParamDirection)
            {
                case "spParamInput":
                    return System.Data.ParameterDirection.Input;

                case "spParamOutput":
                    return System.Data.ParameterDirection.Output;

                case "spParamReturnValue":
                    return System.Data.ParameterDirection.ReturnValue;

                case "spParamInputOutput":
                    return System.Data.ParameterDirection.InputOutput;

                default:
                    //Default to Input if anything else is supplied
                    return System.Data.ParameterDirection.Input;
            }
        }
        #endregion
    }
    public class StateEventArgs : EventArgs
    {
        private long currentfilelength = 0;
        private long filelength = 1;
        private float percentage = 0;

        public StateEventArgs(long currentfilelength, long filelength)
        {
            this.currentfilelength = currentfilelength;
            this.filelength = filelength;
        }

        public long currentFileLength
        {
            get { return currentfilelength; }
            set
            {
                currentfilelength = value > filelength ? filelength : value;
                if (filelength != 0)
                    //					this.filelength=1;
                    //				if(currentfilelength>filelength)
                    //					this.currentfilelength=filelength;
                    this.percentage = 100 * currentfilelength / filelength;
                else
                    this.percentage = 100;

                currentfilelength = value;
            }
        }

        public long FileLength
        {
            get { return filelength; }
        }

        public float Percentage
        {
            get { return percentage; }
        }

    }

}

