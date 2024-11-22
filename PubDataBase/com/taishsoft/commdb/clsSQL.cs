//该类为通用数据层，目标为所有数据库应用程序服务，既可以用于WEB应用程序
//也可以用于桌面应用程序。
//目前版本：V1.0，
//定义时间：2004年8月12日
//最后修改者：潘以锋
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
        protected bool mblnDisposed = false;     //'是否已经释放对象(用于析构函数)
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
        protected string EXCEPTION_MSG = new clsResource().Property("s0001");// "SQL层出错：";    //there was an error in the method. please see the Application Log for details.";
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
            //by davidfujian (李顺道)
            //2004-2-28 Night
            //获得连接字符串
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
                LogError(objException, "打开连接失败!");
          
               
                StringBuilder sbMessage = new StringBuilder();
                sbMessage.Append(objException.Message);
                sbMessage.Append("\r\n");
                sbMessage.Append("打开连接失败!请检查连接串!\r\n");
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
                    sbMessage.AppendFormat("打开的服务器：{0}，\r\n数据库：{1}。", //，\r\n用户名：{2}。",
                        m_sServer,
                        m_sDatabase,
                        m_sUid);
                }
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    string strMsg = string.Format("出错：{0}. Sql语句：{1}", objException.Message, sbMessage.ToString());
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                        intCurrLevel++;
                        if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                    }
                    clsDebugBase_Sql.WriteLog(strMsg);
                }
                //				sbMessage.Append("打开连接失败!请检查连接串!");
                throw new Exception(sbMessage.ToString(), objException);
                //				dtTab=new DataTable();
                //				return dtTab;	
            }
            //finally
            //{
            //}
        }
        //静态的处理错误日志的函数
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
                LogErrorS(objException, "打开连接失败!");
             
                StringBuilder sbMessage = new StringBuilder();
                sbMessage.Append(objException.Message);
                sbMessage.Append("\r\n");
                sbMessage.Append("打开连接失败!请检查连接串!\r\n");
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
                    sbMessage.AppendFormat("打开的服务器：{0}，\r\n数据库：{1}。", //，\r\n用户名：{2}。",
                        m_sServer,
                        m_sDatabase,
                        m_sUid);
                }
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    string strMsg = string.Format("出错：{0}. Sql语句：{1}", objException.Message, sbMessage.ToString());
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                        intCurrLevel++;
                        if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                    }
                    clsDebugBase_Sql.WriteLog(strMsg);
                }
                //				sbMessage.Append("打开连接失败!请检查连接串!");
                throw new Exception(sbMessage.ToString(), objException);
                //				dtTab=new DataTable();
                //				return dtTab;	
            }
            finally
            {
            }
        }
        /// <summary>
        /// 功能：获取给定表的记录数.
        /// </summary>
        /// <param name="strTabName">所给定的表名</param>
        /// <returns>记录数，为整型</returns>
        public int GetRecCount(string strTabName)
        {
            //by davidfujian 
            //2004-7-24 Night
            //获得并返回表
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
                intRecCount = (int)sqlCmd.ExecuteScalar();//获得记录总数
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    SqlStatement objSqlStatementEN = null;
                    try
                    {
                        objSqlStatementEN = SqlStatementAC.AnalysisSqlStatement(strSQL);
                        string strMsg = SqlStatementAC.GetSqlStatementAnalysisInfo(objSqlStatementEN, intRecCount);
                        //s1trMsg += string.Format("|底层函数:[funGetRecCount]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("出错：{0}|Sql语句:[{1}]", objException.Message, strSQL);
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
                    string strMsg = string.Format("出错：{0}. Sql语句：{1}", objException.Message, strSQL);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
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
        /// 功能：获取给定表中满足条件的记录数
        /// </summary>
        /// <param name="strTabName">所给定的表名</param>
        /// <param name="strCondtion">所给定的记录条件</param>
        /// <returns>记录数，为整型</returns>
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
                intRecCount = (int)sqlCmd.ExecuteScalar();//获得记录总数
                if (clsDebugBase_Sql.IsDebug == true)
                {
                    SqlStatement objSqlStatementEN = null;
                    try
                    {
                        objSqlStatementEN = SqlStatementAC.AnalysisSqlStatement(strSQL.ToString());
                        string strMsg = SqlStatementAC.GetSqlStatementAnalysisInfo(objSqlStatementEN, intRecCount);
                        //s1trMsg += string.Format("|底层函数:[funGetRecCount]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("出错：{0}|Sql语句:[{1}]|底层函数:[funGetRecCount]",
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
                    string strMsg = string.Format("出错：{0}. Sql语句：{1}", objException.Message, strSQL.ToString());
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
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
            //by davidfujian (李顺道)
            //2004-2-28 Night
            //从参数中获得连接字符串
            mstrSPConfigXML = "";
            mstrModuleName = this.GetType().ToString();
            this.p_sConnectString = sconnectString;
        }
        /// <summary>
        /// 根据Sql语句，获取DataTable
        /// </summary>
        /// <param name="strSql">Sql语句</param>
        /// <returns>获取的DataTable</returns>
        public DataTable GetDataTable(string strSql)
        {
            //by davidfujian (李顺道)
            //2004-2-28 Night
            //获得并返回表
          
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
                        //s1trMsg += string.Format("|底层函数:[GetDataTable]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("出错：{0}|Sql语句:[{1}]|底层函数:[GetDataTable]", objException.Message, strSql);
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
                    string strMsg = string.Format("出错：{0}. Sql语句：{1}", objException.Message, strSql);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
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
        /// 根据条件获取分页记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
        /// </summary>
        /// <param name = "strTabName">表名</param>
        /// <param name = "strKeyFldName">表关键字</param>
        /// <param name = "intPageIndex">页序号</param>
        /// <param name = "intPageSize">页记录数</param>
        /// <param name = "strCondition">条件串</param>
        /// <param name = "strOrderBy">排序方式</param>
        /// <returns>返回数据表DataTable</returns>
        public System.Data.DataTable GetDataTableByPager(string strTabName, string strKeyFldName, int intPageIndex, int intPageSize, string strCondition, string strOrderBy)
        {
            try
            {
                clsCheckSql.CheckStrSQL_Weak(strCondition);
                strCondition = clsString.RemoveElementValue(strCondition, "Exclude");
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsAppCodeTypeRelaDA: GetDataTableByPager)", objException.Message));
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
        /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
        /// </summary>
        /// <param name = "strTabName">表名</param>
        /// <param name = "intTopSize">顶部记录数</param>
        /// <param name = "strCondition">条件串</param>
        /// <param name = "strOrderBy">排序方式</param>
        /// <returns>返回数据表DataTable</returns>
        public System.Data.DataTable GetDataTableByTop(string strTabName, int intTopSize, string strCondition, string strOrderBy)
        {
            try
            {
                clsCheckSql.CheckStrSQL_Weak(strCondition);
                strCondition = clsString.RemoveElementValue(strCondition, "Exclude");
            }
            catch (Exception objException)
            {
                throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsAppCodeTypeRelaDA: GetDataTableByPager)", objException.Message));
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
        /// 根据关键字值获取数据表中的一条记录,用DataTable表示
        /// </summary>
        /// <param name = "strTabName">表名</param>
        /// <param name = "strKeyFldName">表关键字</param>
        /// <param name = "strKeyValue">关键字值</param>
        /// <param name = "bolIsNumurable">是否数值型</param>
        /// <returns>返回数据表DataTable</returns>
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
        /// 根据Sql语句，获取DataTable
        /// </summary>
        /// <param name="strSql">Sql语句</param>
        /// <param name="objSqlConnect"></param>
        /// <param name="objSqlTransaction"></param>
        /// <returns>获取的DataTable</returns>
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
                        //s1trMsg += string.Format("|底层函数:[GetDataTable]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("出错：{0}|Sql语句:[{1}]|底层函数:[GetDataTable]", objException.Message, strSql);
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
                    string strMsg = string.Format("出错：{0}. Sql语句：{1}", objException.Message, strSql);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
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
        /// 根据Sql语句， 获取DataTable
        /// </summary>
        /// <param name="strSql">Sql语句</param>
        /// <param name="strTabName">表名</param>
        /// <returns>获取的DataTable</returns>
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
                        //s1trMsg += string.Format("|底层函数:[GetDataTable]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("出错：{0}|Sql语句:[{1}]|底层函数:[GetDataTable]", objException.Message, strSql);
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
                    string strMsg = string.Format("出错：{0}. Sql语句：{1}", objException.Message, strSql);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
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
        /// 获取DataTable，以XML文件形式输出
        /// </summary>
        /// <param name="strSql">Sql语句</param>
        /// <param name="strTabName">表名</param>
        /// <param name="strXmlFileName">输出的XML文件名</param>
        /// <returns>是否成功？</returns>
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
                        //s1trMsg += string.Format("|底层函数:[GetDataTableXml]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("出错：{0}|Sql语句:[{1}]|底层函数:[GetDataTableXml]", objException.Message, strSql);
                       
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
                    string strMsg = string.Format("出错：{0}. Sql语句：{1}", objException.Message, strSql);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
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
        /// 获取DataTable，以XML文件形式输出
        /// </summary>
        /// <param name="objTable_SqlCommandText">Sql语句</param>
        /// <param name="strXmlFileName">输出的XML文件名</param>
        /// <returns>是否成功？</returns>
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
                        //s1trMsg += string.Format("|底层函数:[GetDataTableXml]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("出错：{0}|Sql语句:[{1}]|底层函数:[GetDataTableXml]", objException.Message, objTable_SqlCommandText.SqlCommandText);
                         
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
                    string strMsg = string.Format("出错：{0}. Sql语句：{1}", objException.Message, objTable_SqlCommandText.SqlCommandText);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
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
            //by davidfujian (李顺道)
            //2004-2-28 Night
            //获得并返回表

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
                        //s1trMsg += string.Format("|底层函数:[funGetRecCount]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("出错：{0}|Sql语句:[{3}]|intStartRec:[{1}]|intEndRec:[{2}]",
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
                    string strMsg = string.Format("出错：{0}. Sql语句：{1}", objException.Message, strSql);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
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
        /// 功能：获取一个DataSet，即多个DataTable
        /// </summary>
        /// <param name="sql">多个SQL串，</param>
        /// <returns>返回包含多个DataTable的DataSet</returns>
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
                            //s1trMsg += string.Format("|底层函数:[GetSqlTables]");
                            StackTrace trace = new StackTrace();
                            int intCurrLevel = 0;
                            foreach (StackFrame frame in trace.GetFrames())
                            {
                                string strFileName = frame.GetFileName();
                                string strMothodName = frame.GetMethod().Name;
                                if (frame.GetMethod().DeclaringType == null) break;
                                string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                                strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                                intCurrLevel++;
                                if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                            }
                            clsDebugBase_Sql.WriteLog(strMsg);
                        }
                        catch (Exception objException)
                        {
                            string strMsg = string.Format("出错：{0}|Sql语句:[{1}]|底层函数:[GetSqlTables]",
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
                    string strMsg = string.Format("出错：{0}. Sql语句：{1}", objException.Message, sqlCmd.CommandText);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
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
        /// 获取SqlDataReader
        /// </summary>
        /// <param name="strSql">Sql语句</param>
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
                    //s1trMsg += string.Format("|底层函数:[GetSqlDataReader]");
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                        intCurrLevel++;
                        if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                    }
                    clsDebugBase_Sql.WriteLog(strMsg);
                }
                catch (Exception objException)
                {
                    string strMsg = string.Format("出错：{0}|Sql语句:[{1}]|底层函数:[GetDataTableXml]",
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
                    string strMsg = string.Format("出错：{0}. Sql语句：{1}", objException.Message, strSql);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
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
        /// 功能：	获取某表中第一个符合条件的某字段的值
        /// </summary>
        /// <param name="strTableName">表名</param>
        /// <param name="strFieldName">字段名</param>
        /// <param name="WhereConditionString">条件串</param>
        /// <returns>第一个字段值</returns>
        public string GetFirstFldValueOfTable(string strTableName,
            string strFieldName,
            string WhereConditionString)
        {
            //获得并返回表
            SqlCommand sqlCmd;
            SqlDataAdapter sqlAdp;
            DataTable objDT;
            ArrayList arrList = new ArrayList();
            string strKeyValue;
            string strSQL;
            //																						  '组织SQL串
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
                        //s1trMsg += string.Format("|底层函数:[GetFirstFldValueOfTable]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("出错：{0}|Sql语句:[{1}]|底层函数:[GetFirstFldValueOfTable]",
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
                    string strMsg = string.Format("出错：{0}. Sql语句：{1}", objException.Message, strSQL);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
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
        /// 功能：	获取某表中符合条件的某字段的值
        /// </summary>
        /// <param name="strTableName">表名</param>
        /// <param name="strFieldName">字段名</param>
        /// <param name="WhereConditionString">条件串</param>
        /// <returns>列表</returns>
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
                    sbMsg.AppendFormat("在函数funGetFldDataOfTable中，SQL语句：{0}中含有：distinct，同时有Order By，且Order By中超出字段{1}的字段{2}。",
                                    strSQL1,
                                    strFieldName,
                                    strWhere);
                    throw new Exception(sbMsg.ToString());
                }
            }
            //获得并返回表
            SqlCommand sqlCmd;
            SqlDataAdapter sqlAdp;
            DataTable objDT;
            List<string> arrList = new List<string>();
            int iRow, iCol;
            string strKeyValue;
            string strSQL;
            //																						  '组织SQL串
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
                        //s1trMsg += string.Format("|底层函数:[funGetFldDataOfTable]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("出错：{0}|Sql语句:[{1}]|底层函数:[funGetFldDataOfTable]",
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
                    string strMsg = string.Format("出错：{0}. Sql语句：{1}", objException.Message, strSQL);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
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
        /// 功能：	获取某表中符合条件的某字段的值
        /// </summary>
        /// <param name="strTableName">表名</param>
        /// <param name="strFieldName">字段名</param>
        /// <param name="WhereConditionString">条件串</param>
        /// <returns>列表</returns>
        public List<string> GetFldDataOfTableNoDistinct(string strTableName,
            string strFieldName,
            string WhereConditionString)
        {
            string strWhere = WhereConditionString.ToLower();
            strWhere = strWhere.Replace("  ", " ");
           
            //获得并返回表
            SqlCommand sqlCmd;
            SqlDataAdapter sqlAdp;
            DataTable objDT;
            List<string> arrList = new List<string>();
            int iRow, iCol;
            string strKeyValue;
            string strSQL;
            //																						  '组织SQL串
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
                        //s1trMsg += string.Format("|底层函数:[funGetFldDataOfTableNoDistinct]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("出错：{0}|Sql语句:[{1}]|底层函数:[funGetFldDataOfTableNoDistinct]",
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
                    string strMsg = string.Format("出错：{0}. Sql语句：{1}", objException.Message, strSQL);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
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
        /// 功能：	获取某表中符合条件的某字段的值
        /// </summary>
        /// <param name="strTableName">表名</param>
        /// <param name="strFieldName">字段名</param>
        /// <param name="WhereConditionString">条件串</param>
        /// <returns>列表</returns>
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
                    sbMsg.AppendFormat("在函数funGetFldDataOfTable中，SQL语句：{0}中含有：distinct，同时有Order By，且Order By中超出字段{1}的字段{2}。",
                                    strSQL1,
                                    strFieldName,
                                    strWhere);
                    throw new Exception(sbMsg.ToString());
                }
            }
            //获得并返回表
            SqlCommand sqlCmd;
            SqlDataAdapter sqlAdp;
            DataTable objDT;
            ArrayList arrList = new ArrayList();
            int iRow, iCol;
            string strKeyValue;
            string strSQL;
            //																						  '组织SQL串
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
                        //s1trMsg += string.Format("|底层函数:[funGetFldDataOfTable]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("出错：{0}|Sql语句:[{1}]|底层函数:[funGetFldDataOfTable]",
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
                    string strMsg = string.Format("出错：{0}. Sql语句：{1}", objException.Message, strSQL);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
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
        /// 功能：	获取SQL语句执行后唯一结果值
        /// </summary>
        /// <param name="strSql">SQL语句</param>
        /// <param name="strFieldName">字段名</param>
        /// <returns>唯一结果值</returns>
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
                        //s1trMsg += string.Format("|底层函数:[funGetFldValueBySql]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("出错：{0}|Sql语句:[{1}]|底层函数:[funGetFldValueBySql]",
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
                    string strMsg = string.Format("出错：{0}. Sql语句：{1}", objException.Message, strSql);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
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
        /// 功能：	获取SQL语句执行后结果值列表
        /// </summary>
        /// <param name="strSql">SQL语句</param>
        /// <param name="strFieldName">字段名</param>
        /// <returns>结果值列表</returns>
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
                        //s1trMsg += string.Format("|底层函数:[funGetFldValuesBySql]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("出错：{0}|Sql语句:[{1}]|底层函数:[funGetFldValuesBySql]",
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
                    string strMsg = string.Format("出错：{0}. Sql语句：{1}", objException.Message, strSql);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
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
        /// 功能：	获取某表中符合条件的某字段的值
        /// </summary>
        /// <param name="strTableName">表名</param>
        /// <param name="strFieldName">字段名</param>
        /// <param name="WhereConditionString">条件串</param>
        /// <param name="strOrderBy">排序表达式</param>
        /// <returns>列表</returns>
        public ArrayList GetFldDataOfTable2(string strTableName,
            string strFieldName,
            string WhereConditionString,
            string strOrderBy)
        {
            //获得并返回表
            SqlCommand sqlCmd;
            SqlDataAdapter sqlAdp;
            DataTable objDT;
            ArrayList arrList = new ArrayList();
            int iRow, iCol;
            string strKeyValue;
            string strSQL;

            //																						  '组织SQL串
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
                        //s1trMsg += string.Format("|底层函数:[funGetFldDataOfTable2]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("出错：{0}|Sql语句:[{1}]|底层函数:[funGetFldDataOfTable2]",
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
                    string strMsg = string.Format("出错：{0}. Sql语句：{1}", objException.Message, strSQL);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
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
        /// 功能：设置某表的符合条件的某字段值
        /// </summary>
        /// <param name="strTableName">表名</param>
        /// <param name="strFieldName">字段名</param>
        /// <param name="varValue">设置值</param>
        /// <param name="WhereConditionString"></param>
        /// <returns>返回影响的记录数，整型数</returns>
        public int SetFldDataOfTable<T>(string strTableName,
            string strFieldName,
            T varValue,
            string WhereConditionString)
        {
            //获得并返回表
            SqlCommand sqlCmd;
            StringBuilder strSQL = new StringBuilder();
            //														  '组织SQL串

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
                        //s1trMsg += string.Format("|底层函数:[funSetFldDataOfTable]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("出错：{0}|Sql语句:[{1}]|底层函数:[funSetFldDataOfTable]",
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
                    string strMsg = string.Format("出错：{0}. Sql语句：{1}", objException.Message, strSQL.ToString());
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
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
        /// 根据Sql语句，获取DataSet
        /// </summary>
        /// <param name="strSql">Sql语句</param>
        /// <param name="strTableName">表名</param>
        /// <returns>获取的DataSet</returns>
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
                        //s1trMsg += string.Format("|底层函数:[GetDataSet]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("出错：{0}|Sql语句:[{1}]|底层函数:[GetDataSet]",
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
                    string strMsg = string.Format("出错：{0}. Sql语句：{1}", objException.Message, strSql);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
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
        /// 获取DataSet
        /// </summary>
        /// <param name="objTable_SqlCommandText">表名-SQL语句对象</param>
        /// <returns>返回DataSet</returns>
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
                        //s1trMsg += string.Format("|底层函数:[GetDataSet]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("出错：{0}|Sql语句:[{1}]|底层函数:[GetDataSet]",
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
                    string strMsg = string.Format("出错：{0}. Sql语句：{1}", objException.Message, objTable_SqlCommandText.SqlCommandText);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
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
        /// 获取DataSet,用XML形式来表示
        /// </summary>
        /// <param name="objTable_SqlCommandText">表名-SQL语句对象</param>
        /// <param name="strXmlFileName">生成的XML文件名</param>
        /// <returns>返回生成XML文件是否成功</returns>
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
                        //s1trMsg += string.Format("|底层函数:[GetDataSetXml]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("出错：{0}|Sql语句:[{1}]|底层函数:[GetDataSetXml]",
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
                    string strMsg = string.Format("出错：{0}. Sql语句：{1}", objException.Message, objTable_SqlCommandText.SqlCommandText);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
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
        /// 获取给定多个表名-SQL语句对象的DataSet
        /// </summary>
        /// <param name="arrTable_SqlCommandTextList">表名-SQL语句对象列表</param>
        /// <returns>返回DataSet</returns>
        public DataSet GetDataSet(ArrayList arrTable_SqlCommandTextList)
        {
            //by 潘以锋
            //2007-12-2
            //获得并返回记录集
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
                            //s1trMsg += string.Format("|底层函数:[GetDataSet]");
                            StackTrace trace = new StackTrace();
                            int intCurrLevel = 0;
                            foreach (StackFrame frame in trace.GetFrames())
                            {
                                string strFileName = frame.GetFileName();
                                string strMothodName = frame.GetMethod().Name;
                                if (frame.GetMethod().DeclaringType == null) break;
                                string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                                strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                                intCurrLevel++;
                                if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                            }
                            clsDebugBase_Sql.WriteLog(strMsg);
                        }
                        catch (Exception objException)
                        {
                            string strMsg = string.Format("出错：{0}|Sql语句:[{1}]|底层函数:[GetDataSet]",
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
                    string strMsg = string.Format("出错：{0}. Sql语句：{1}", objException.Message, strSql);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
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
        /// 获取DataSet
        /// </summary>
        /// <param name="arrTable_SqlCommandTextList">表名-SQL语句对象</param>
        /// <param name="strXmlFileName">XML文件名</param>
        /// <returns>返回DataSet</returns>
        public bool GetDataSetXml(ArrayList arrTable_SqlCommandTextList, string strXmlFileName)
        {
            //by 潘以锋
            //2007-12-2
            //获得并返回记录集
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
                            //s1trMsg += string.Format("|底层函数:[GetDataSet]");
                            StackTrace trace = new StackTrace();
                            int intCurrLevel = 0;
                            foreach (StackFrame frame in trace.GetFrames())
                            {
                                string strFileName = frame.GetFileName();
                                string strMothodName = frame.GetMethod().Name;
                                if (frame.GetMethod().DeclaringType == null) break;
                                string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                                strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                                intCurrLevel++;
                                if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                            }
                            clsDebugBase_Sql.WriteLog(strMsg);
                        }
                        catch (Exception objException)
                        {
                            string strMsg = string.Format("出错：{0}|Sql语句:[{1}]底层函数:[GetDataSet]",
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
                    string strMsg = string.Format("出错：{0}. Sql语句：{1}", objException.Message, strSql);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
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
            //by davidfujian(李顺道)
            //2004-3-8 11:12
            //检测记录是否存在
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
                        //s1trMsg += string.Format("|底层函数:[CheckDataExist]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("出错：{0}|Sql语句:[{1}]|底层函数:[CheckDataExist]",
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
                    string strMsg = string.Format("出错：{0}. Sql语句：{1}", objException.Message, sqlCmd.CommandText);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
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
        /// 是否存在记录
        /// </summary>
        /// <param name="strTable">表名</param>
        /// <param name="strCondition">条件串</param>
        /// <returns>是否存在</returns>
        public bool IsExistRecord(string strTable, string strCondition)
        {
            //by davidfujian(潘以锋)
            //2004-3-8 11:12
            //检测记录是否存在
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
                        //s1trMsg += string.Format("|底层函数:[IsExistRecord]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("出错：{0}|Sql语句:[{1}]|底层函数:[IsExistRecord]",
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
                    string strMsg = string.Format("出错：{0}. Sql语句：{1}", objException.Message, sqlCmd.CommandText);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
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
        /// 是否存在记录
        /// </summary>
        /// <param name="strTable">表名</param>
        /// <param name="strCondition">条件串</param>
        /// <param name="objSqlConnect">SqlConnection</param>
        /// <param name="objSqlTransaction">SqlTransaction</param>
        /// <returns>是否存在</returns>
        public bool IsExistRecord(string strTable, string strCondition, SqlConnection objSqlConnect, SqlTransaction objSqlTransaction)
        {
            //by 潘以锋
            //2004-3-8 11:12
            //检测记录是否存在
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
                        //s1trMsg += string.Format("|底层函数:[GetSqlDataReader]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("出错：{0}|Sql语句:[{1}]|底层函数:[GetDataTableXml]",
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
                    string strMsg = string.Format("出错：{0}. Sql语句：{1}", objException.Message, sqlCmd.CommandText);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
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
        /// 执行SQL语句
        /// </summary>
        /// <param name="strSql">被执行的SQL语句</param>
        /// <returns>是否成功？</returns>
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
                        //s1trMsg += string.Format("|底层函数:[ExecSql]");
                    
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("出错：{0}|Sql语句:[{1}]|底层函数:[ExecSql]",
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
                    string strMsg = string.Format("出错：{0}. Sql语句：{1}", objException.Message, strSql);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
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
        /// 执行SQL语句
        /// </summary>
        /// <param name="strSql">被执行的SQL语句</param>
        /// <param name="objSqlConnect">Sql连接对象</param>
        /// <param name="objSqlTransaction">Sql事务对象</param>
        /// <returns>是否成功？</returns>
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
        /// 执行SQL语句
        /// </summary>
        /// <param name="strSql">被执行的SQL语句</param>
        /// <param name="intCommandTimeout">命令执行最长花费的时间</param>
        /// <returns>是否成功？</returns>
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
                        //s1trMsg += string.Format("|底层函数:[ExecSql]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("出错：{0}|Sql语句:[{1}]|底层函数:[ExecSql]",
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
                    string strMsg = string.Format("出错：{0}. Sql语句：{1}", objException.Message, strSql);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
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
        /// 功能：执行SQL语句
        /// </summary>
        /// <param name="ssql">需要执行的SQL语句</param>
        /// <returns>执行SQL语句影响的记录数，整型</returns>
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
                        //s1trMsg += string.Format("|底层函数:[ExecSql2]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("出错:{0}|Sql语句:[{1}]|底层函数:[ExecSql2]",
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
                    string strMsg = string.Format("出错：{0}. Sql语句：{1}", objException.Message, strSql);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
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
        /// 功能：执行SQL语句
        /// </summary>
        /// <param name="strSql">需要执行的SQL语句</param>
        /// <param name="objSqlConnect">Sql连接对象</param>
        /// <param name="objSqlTransaction">Sql事务对象</param>
        /// <returns>执行SQL语句影响的记录数，整型</returns>
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
                        //s1trMsg += string.Format("|底层函数:[ExecSql2]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("出错：{0}|Sql语句:[{1}]|底层函数:[ExecSql2]",
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
                    string strMsg = string.Format("出错：{0}. Sql语句：{1}", objException.Message, strSql);
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
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
        /// 测试连接是否成功
        /// </summary>
        /// <param name="strConnectString">连接串</param>
        /// <returns>是否连接成功？</returns>
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
                throw new Exception("测试连接不成功！" + objException.Message);
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
                throw new Exception("测试连接不成功！\n\r" + objException.Message);
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
        /// 功能：把指定文件的内容存贮到满足条件的指定表字段中。
        /// </summary>
        /// <param name="strFileName">需要存贮文件内容的文件名</param>
        /// <param name="strTabName">需要存贮文件内容的目标数据表名</param>
        /// <param name="strFldName">需要存贮文件内容的目标数据表的字段名</param>
        /// <param name="strCondition">需要存贮文件内容的目标数据表中决定记录的条件字符串</param>
        /// <param name="intBufferLen">存贮数据时的缓冲区长度</param>
        public void StoreFile(string strFileName,
            string strTabName,
            string strFldName,
            string strCondition,
            int intBufferLen)
        {
            StringBuilder strSQL = new StringBuilder();
            //步骤：
            //	  1、获取指定记录当前
            //	  
            m_oConn = getConnectObj(this.p_sConnectString);

            try
            {
                //
                //string sql="SELECT @Pointer = TEXTPTR("+ColumnPointerName+") FROM "+TableName+" WHERE "+ColumnIDName+"='"+ID+"'";
                //string sql="EXEC xxkp.dbo.Select_StoreFile @Pointer output,'"+GWBH+"'";
                //				strSQL=@"SELECT @Pointer = TEXTPTR(xxkp.dbo.photo.PHOTO) FROM xxkp.dbo.PHOTO WHERE GWBH='"+GWBH+"' WRITETEXT PHOTO.PHOTO @Pointer ''";
                //定义SQL语句，用于获取字段指针。
                strSQL.AppendFormat("SELECT @Pointer = TEXTPTR({0}.{1}) FROM {0} WHERE {2}",
                    strTabName, strFldName, strCondition);
                //将获取指针的位置数据清空
                strSQL.AppendFormat(" WRITETEXT {0}.{1} @Pointer ''",
                    strTabName, strFldName);
                //新建SqlCommand对象
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Connection = m_oConn;

                sqlCmd.CommandTimeout = 9600;
                sqlCmd.CommandText = strSQL.ToString();
                //定义参数
                SqlParameter ptrParm = sqlCmd.Parameters.Add("@Pointer", SqlDbType.Binary, 16);
                //获取指针，所以此时参数方向为输出(Output)
                ptrParm.Direction = ParameterDirection.Output;
                //打开连接
                //m_oConn.Open();
                sqlCmd.ExecuteNonQuery();

                //改变参数类型用于输入
                ptrParm.Direction = ParameterDirection.Input;
                //				//
                //				sql="WRITETEXT "+TableName+"."+ColumnPointerName+" @Pointer ''";
                //				sqlCmd.CommandText=sql;
                //				sqlCmd.ExecuteNonQuery();
                //定义SQL语句用于输入数据。
                strSQL = new StringBuilder();

                //				strSQL="Exec Update_StoreFile @Pointer,@Offset,@Bytes,'"+GWBH+"'";
                strSQL.AppendFormat("UPDATETEXT {0}.{1} @Pointer @Offset 0 @Bytes",
                    strTabName, strFldName);
                sqlCmd.CommandText = strSQL.ToString();
                //定义参数用于输入的二进制类型。
                SqlParameter photoParm = sqlCmd.Parameters.Add("@Bytes", SqlDbType.Image, intBufferLen);
                //定义参数用于输入的偏移量。
                SqlParameter offsetParm = sqlCmd.Parameters.Add("@Offset", SqlDbType.Int);
                //初始直为0。
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
        /// 功能：把指定文件的内容存贮到满足条件的指定表字段中。
        /// </summary>
        /// <param name="strFileName">需要存贮文件内容的文件名</param>
        /// <param name="strTabName">需要存贮文件内容的目标数据表名</param>
        /// <param name="strFldName">需要存贮文件内容的目标数据表的字段名</param>
        /// <param name="strCondition">需要存贮文件内容的目标数据表中决定记录的条件字符串</param>
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
        /// 功能：把满足条件的指定表字段中的内容取出来，并且并且存入给定的文件名中。
        /// </summary>
        /// <param name="strFileName">需要存贮文件内容的文件名</param>
        /// <param name="strTabName">需要获取文件内容的目标数据表名</param>
        /// <param name="strFldName">需要获取文件内容的目标数据表的字段名</param>
        /// <param name="strCondition">需要获取文件内容的目标数据表中决定记录的条件字符串</param>
        /// <param name="intBufferLen">获取数据时的缓冲区长度</param>
        public bool GetFile(string strFileName,
            string strTabName,
            string strFldName,
            string strCondition,
            int intBufferLen)
        {
            bool bolIsHaveFile = false; //是否有文件
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

                //如果相关子目录不存在就新建子目录
                string strFolder;
                strFolder = ParentDir(strFileName);
                //        '把每一个属性块中的内容删除掉
                if (System.IO.Directory.Exists(strFolder) == false)
                {
                    Directory.CreateDirectory(strFolder);
                }
                // Create a file to hold the output.
                fs = new FileStream(strFileName, FileMode.Create, FileAccess.Write);
                bw = new BinaryWriter(fs);

                // Reset the starting byte for the new BLOB.
                startIndex = 0;

                //myReader进行读操作，成功则返回 true 。
                if (myReader.Read())
                {
                    // blen 返回文件长度。
                    int blen = (int)myReader.GetInt32(0);

                    //					//声明新委托。
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
        /// 父目录
        /// </summary>
        /// <param name="strPath">给定的目录</param>
        /// <returns>父目录名</returns>
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
        /// 功能：把满足条件的指定表字段中的内容取出来，并且并且存入给定的文件名中。
        /// </summary>
        /// <param name="strFileName">需要存贮文件内容的文件名</param>
        /// <param name="strTabName">需要获取文件内容的目标数据表名</param>
        /// <param name="strFldName">需要获取文件内容的目标数据表的字段名</param>
        /// <param name="strCondition">需要获取文件内容的目标数据表中决定记录的条件字符串</param>
        /// <returns>是否成功？</returns>
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
        /// 获取表中关键字的最大值，以字符串表示
        /// </summary>
        /// <param name="strTabName">表名</param>
        /// <param name="strFldName">字段名</param>
        /// <param name="intFldLen">字段长度</param>
        /// <param name="strPrefix">前缀</param>
        /// <returns>获取表中关键字的最大值</returns>
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
                        ////s1trMsg += string.Format("|底层函数:[GetMaxStrId]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("出错：{0}|Sql语句:[{1}]|底层函数:[GetMaxStrId]",
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
                    string strMsg = string.Format("出错：{0}. Sql语句：{1}", objException.Message, strSQL.ToString());
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
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
                    string strMsg = string.Format("获取的最大值：[{0}]|底层函数:[GetMaxStrId]",
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
                    string strMsg = string.Format("获取的最大值：[{0}]|底层函数:[GetMaxStrId]",
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
                        //s1trMsg += string.Format("|底层函数:[GetMaxStrId]");
                        StackTrace trace = new StackTrace();
                        int intCurrLevel = 0;
                        foreach (StackFrame frame in trace.GetFrames())
                        {
                            string strFileName = frame.GetFileName();
                            string strMothodName = frame.GetMethod().Name;
                            if (frame.GetMethod().DeclaringType == null) break;
                            string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                            strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
                            intCurrLevel++;
                            if (intCurrLevel > clsDebugBase_Sql.TraceLevel) break;
                        }
                        clsDebugBase_Sql.WriteLog(strMsg);
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("出错：{0}|Sql语句:[{1}]|底层函数:[GetMaxStrId]",
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
                    string strMsg = string.Format("出错：{0}. Sql语句：{1}", objException.Message, strSQL.ToString());
                    StackTrace trace = new StackTrace();
                    int intCurrLevel = 0;
                    foreach (StackFrame frame in trace.GetFrames())
                    {
                        string strFileName = frame.GetFileName();
                        string strMothodName = frame.GetMethod().Name;
                        if (frame.GetMethod().DeclaringType == null) break;
                        string strDeclaringType = frame.GetMethod().DeclaringType.FullName;
                        strMsg += string.Format("|调用类函数{2}:[{0}.{1}]", strDeclaringType, strMothodName, intCurrLevel);
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
                    string strMsg = string.Format("获取的最大值：[{0}]|底层函数:[GetMaxStrId]",
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
                    string strMsg = string.Format("获取的最大值：[{0}]|底层函数:[GetMaxStrId]",
                        strNextMaxValue);
                    clsDebugBase_Sql.WriteLog(strMsg);
                }
                return strNextMaxValue;
            }
        }

        /// <summary>
        /// 组装字符串，
        /// </summary>
        /// <param name="mStr">原来的字符串</param>
        /// <param name="count">该字符串的重复次数</param>
        /// <returns>组装好的字符串</returns>
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

            //1.创建ExecStoredProcedureReturnDT
            //2.创建stored procedure,为其添加权限
            //3.更改xml文档
            //4.更改BuildParameters为protected

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
            //用户必须在使用该方法前，为cmd赋名
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
            //用户必须在使用该方法前，为cmd赋名
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
            //用户必须在使用该方法前，为cmd赋名
           
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
            //用户必须在使用该方法前，为cmd赋名
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
                    //获得"name" 
                    strParameterName = para.Attributes.GetNamedItem("name").Value;

                    //获得"size"
                    intParameterSize = Int32.Parse(para.Attributes.GetNamedItem("size").Value);

                    //获得"datatype"
                    intSQLDataType = GetSqlDataType(para.Attributes.GetNamedItem("datatype").Value);

                    //获得"direction"
                    intParameterDirection = GetParamDirection(para.Attributes.GetNamedItem("direction").Value);

                    //获得"precision"
                    //bytPrecision = Byte.Parse(para.Attributes.GetNamedItem("precision").Value);

                    //获得"scale"
                    //bytScale = Byte.Parse(para.Attributes.GetNamedItem("scale").Value);

                    //获得"isNullable"
                    blnIsNullable = Boolean.Parse(para.Attributes.GetNamedItem("isNullable").Value);

                    objParameter = new SqlParameter(strParameterName, intSQLDataType, intParameterSize);
                    //paramValues
                    objParameterValue = paramValues[intParamCounter];
                    objParameter.Value = objParameterValue;

                    //设置方向
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
            //by 潘以锋 at 2008-1-28
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
                //sbMessage.AppendFormat("在数据库中,没有存储过程:<{0}>,请联系DBA!", strSp_Name);
                sbMessage.AppendFormat(strS0002, strSp_Name);
                throw new Exception(sbMessage.ToString());
            }
            if (objSqlSP.arrSpParamObjList.Count != paramValues.Count)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strS0003 = new clsResource().Property("s0003");
//                sbMessage.AppendFormat("在存储过程:<{0}>中的参数个数:<{1}>,传递的参数个数:<{2}>,两者不一致,请检查!",
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

                    //获得"name" 
                    strParameterName = objSqlSp_Para.ParaName;

                    //获得"size"
                    intParameterSize = objSqlSp_Para.ParaSize;

                    //获得"datatype"
                    intSQLDataType = GetSqlDataType(objSqlSp_Para.ParaDataType);

                    //获得"direction"
                    intParameterDirection = GetParamDirection(objSqlSp_Para.ParaDirection);

                    //获得"isNullable"
                    blnIsNullable = objSqlSp_Para.IsNullable;

                    objParameter = new SqlParameter(strParameterName, intSQLDataType, intParameterSize);
                    //paramValues
                    objParameterValue = paramValues[intParamCounter];
                    if (objParameterValue == null)
                    {
                        objParameterValue = System.DBNull.Value;
                    }
                    //检查值类型是否正确------------------------
                    if (objParameterValue != null && objParameterValue != System.DBNull.Value)
                    {
                        if (clsSqlObject.IsValid(objSqlSp_Para.ParaDataType, objParameterValue.ToString()) == false)
                        {
                            StringBuilder sbMessage = new StringBuilder();
                            sbMessage.AppendFormat("在存储过程:<{0}>中,参数:<{1}>的类型:<{2}>,而传递进来的值为<{3}>,不能配匹,请检查!",
                                strSp_Name,
                                objSqlSp_Para.ParaName,
                                objSqlSp_Para.ParaDataType,
                                objParameterValue.ToString());
                            throw new Exception(sbMessage.ToString());
                        }
                    }
                    //检查值类型是否正确=======================
                    objParameter.Value = objParameterValue;

                    //设置方向
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

