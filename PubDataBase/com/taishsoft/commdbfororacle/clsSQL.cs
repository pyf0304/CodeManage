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
using System.Data.OracleClient;
using System.Collections.Generic;
using com.taishsoft.syspara;
using System.Diagnostics;
using com.taishsoft.common;
using com.taishsoft.comm_db_obj;

namespace com.taishsoft.commdbfororacle
{
	public class clsSQL
	{	
		//Attributes
//		public delegate void StateEventHandler(StateEventArgs e);
//		public static event StateEventHandler OnChange;
		protected bool mblnDisposed = false;     //'�Ƿ��Ѿ��ͷŶ���(������������)
		protected string m_sSPConfigXMLFile;
		protected string mstrSPConfigXML;
        private int mintConnectWay;

        public int ConnectWay
        {
            get { return mintConnectWay; }
            set { mintConnectWay = value; }
        }

        protected string m_sDatabase; 
		protected string m_sSID; 
		protected string m_sServer;
		protected string m_sUid;
		protected string m_sPassword;
		protected string p_sConnectString;
		protected OracleConnection m_oConn;
		protected string mstrModuleName;
		protected const string EXCEPTION_MSG = "there was an error in the method. please see the Application Log for details.";

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
				if(value!="" && this.m_sSPConfigXMLFile!=value)
					this.m_sSPConfigXMLFile=value;
			}
		}
		public string SPConfigXML
		{
			get
			{
				return this.mstrSPConfigXML;
			}
			set
			{
				if(value!="" && this.mstrSPConfigXML!=value)
					this.mstrSPConfigXML=value;
			}
		}

//		public string DataBase
//		{
//			get
//			{
//				return this.m_sDatabase ;
//			}
//			set
//			{
//				if(value!="" && this.m_sDatabase!=value)
//					this.m_sDatabase=value;
//			}
//		}
		public string SID
		{
			get
			{
				return this.m_sSID ;
			}
			set
			{
				if(value!="" && this.m_sSID!=value)
					this.m_sSID=value;
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
				if(value!="" && this.m_sServer!=value)
					this.m_sServer=value;
			}
		}

		public string UserID
		{
			get
			{
				return this.m_sUid ;
			}
			set
			{
				if(value!="" && this.m_sUid !=value)
					this.m_sUid =value;
			}
		}

		public string Password
		{
			get
			{
				return this.m_sPassword  ;
			}
			set
			{
				if(value!="" && this.m_sPassword  !=value)
					this.m_sPassword =value;
			}
		}

		public string ConnectionString
		{
			get
			{
				return this.p_sConnectString ;
			}
			set
			{
				if(value!="" && this.p_sConnectString  !=value)
					this.p_sConnectString  =value;
			}
		}

		#endregion

		//Methods
		#region "Methods"
		public string GetConnectString()
		{ 
			//by davidfujian (��˳��)
			//2004-2-28 Night
			//��������ַ���
			StringBuilder sbConnString = new StringBuilder();
            if (this.ConnectWay == 2)
            {
                sbConnString.Append("Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)");
                sbConnString.AppendFormat("(HOST={0})",
                    this.m_sServer);
                sbConnString.Append("(PORT=1521)))");
                sbConnString.AppendFormat("(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME={0})));",
                    this.m_sSID);
                sbConnString.AppendFormat("User Id={0};Password={1};",
                    this.m_sUid,
                    this.m_sPassword);
            }
            else
            {
                sbConnString.AppendFormat("Data Source={0};Persist Security Info=True;", this.m_sSID);
                sbConnString.AppendFormat("User Id={0};Password={1};Unicode=True;",
                   this.m_sUid,
                   this.m_sPassword);
            }
			p_sConnectString = sbConnString.ToString();
			return p_sConnectString;
		}
		/// <summary>
		/// ���ܣ���ȡ������ļ�¼��.
		/// </summary>
		/// <param name="strTabName">�������ı���</param>
		/// <returns>��¼����Ϊ����</returns>
		public int funGetRecCount(string strTabName)
		{
			//by davidfujian 
			//2004-7-24 Night
			//��ò����ر�
			OracleCommand sqlCmd;
			int intRecCount;
			string strSQL;
			strSQL = "select count(*) from " + strTabName ;
			try
			{

				m_oConn=new OracleConnection (this.p_sConnectString );
				this.m_oConn.Open();

				sqlCmd=new OracleCommand();
				sqlCmd.Connection=m_oConn;
				sqlCmd.CommandType=CommandType.Text;
				sqlCmd.CommandText =strSQL;
                intRecCount = int.Parse(sqlCmd.ExecuteScalar().ToString());//��ü�¼����
				m_oConn.Close();
				return intRecCount;
			}
			catch(Exception objException)
			{
				LogError(objException,"");
				Console.WriteLine(objException.ToString() );
				throw new Exception(EXCEPTION_MSG + objException.Message, objException);
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
		public int funGetRecCount(string strTabName, string strCondtion)
		{
			//by davidfujian 
			//2004-7-24 Night
			//��ò����ر�
			OracleCommand sqlCmd;
			int intRecCount;
			StringBuilder strSQL = new StringBuilder();
			strSQL.AppendFormat("select count(*) from {0} where {1}" , strTabName, strCondtion);
			try
			{
				m_oConn=new OracleConnection (this.p_sConnectString );
				this.m_oConn.Open();
				sqlCmd=new OracleCommand();
				sqlCmd.Connection=m_oConn;
				sqlCmd.CommandType=CommandType.Text;
				sqlCmd.CommandText =strSQL.ToString();
				intRecCount = int.Parse(sqlCmd.ExecuteScalar().ToString());//��ü�¼����
				m_oConn.Close();
				return intRecCount;
			}
			catch(Exception objException)
			{
				LogError(objException,"");
				Console.WriteLine(objException.ToString() );
				throw new Exception(EXCEPTION_MSG + objException.Message, objException);
			}
			finally
			{
				m_oConn.Close();
			}
			
		}

		public clsSQL(string server,string strSID,string uid,string pwd)
		{
			mstrModuleName = this.GetType().ToString();
			m_sServer=server;
			m_sSID=strSID;
			m_sUid=uid;
			m_sPassword=pwd;
			p_sConnectString=GetConnectString();
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
			this.p_sConnectString =sconnectString;
		}
		
		public DataTable GetDataTable(string ssql)
		{
			//by davidfujian (��˳��)
			//2004-2-28 Night
			//��ò����ر�
			OracleCommand sqlCmd;
			OracleDataAdapter sqlAdp;
			DataTable  dtTab;

			try
			{
				m_oConn=new OracleConnection (this.p_sConnectString );
				this.m_oConn.Open();

				sqlCmd=new OracleCommand();
				sqlCmd.Connection=m_oConn;
				sqlCmd.CommandType=CommandType.Text;
				sqlCmd.CommandText =ssql;

				sqlAdp=new OracleDataAdapter();
				sqlAdp.SelectCommand = sqlCmd;
				dtTab=new DataTable();
				sqlAdp.Fill(dtTab);
				//m_oConn.Close();
				return dtTab;
			}
			catch(Exception objException)
			{
                System.Console.Out.WriteLine("strSQL = " + ssql);
                LogError(objException, ssql);
				Console.WriteLine(objException.ToString() );
				throw new Exception(EXCEPTION_MSG + objException.Message, objException);
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
		public DataSet GetSqlTables (ArrayList sql)
		{

			OracleCommand sqlCmd;
			OracleDataAdapter sqlAdp;
			DataSet dtSet=new DataSet();
			try
			{
				m_oConn=new OracleConnection (this.p_sConnectString );
				this.m_oConn.Open();

				sqlCmd=new OracleCommand();
				sqlCmd.Connection=m_oConn;

				for(int i=0;i<sql.Count;i++)
				{
					sqlCmd.CommandType=CommandType.Text;
					sqlCmd.CommandText =sql[i].ToString();

					sqlAdp=new OracleDataAdapter();
					sqlAdp.SelectCommand = sqlCmd;

					sqlAdp.Fill(dtSet,i.ToString());
					
				}
				return dtSet;
			}

			catch(Exception objException)
			{
				LogError(objException,"");
				Console.WriteLine(objException.ToString() );
				throw new Exception(EXCEPTION_MSG + objException.Message, objException);
				//				dtSet=new DataSet();
				//				return dtSet;
			}
			finally
			{
				m_oConn.Close();
			}
		}

		private OracleDataReader GetSqlDataReader(string ssql)
		{
			//by davidfujian (��˳��)
			//2004-2-28 Night
			//��ò����ر�
			OracleCommand sqlCmd;
			OracleDataReader  dtRedr;
			try
			{
				m_oConn=new OracleConnection (this.p_sConnectString);
				m_oConn.Open();
				sqlCmd=new OracleCommand();
				sqlCmd.Connection =m_oConn;
				sqlCmd.CommandType =CommandType.Text;
				sqlCmd.CommandText =ssql;
				dtRedr=sqlCmd.ExecuteReader();
				return dtRedr;
			}
			catch(Exception objException)
			{
				LogError(objException,"");
				Console.WriteLine(objException.ToString() );
				throw new Exception(EXCEPTION_MSG + objException.Message, objException);
				//				return null;
			}
			finally
			{
				//m_oConn.Close();
			}

		}

		/// <summary>
		/// ���ܣ�	��ȡĳ���з���������ĳ�ֶε�ֵ
		/// </summary>
		/// <param name="strTableName">����</param>
		/// <param name="strFieldName">�ֶ���</param>
		/// <param name="WhereConditionString">������</param>
		/// <returns>�б�</returns>
        public List<string> funGetFldDataOfTable(string strTableName, 
			string strFieldName, 
			string WhereConditionString)
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
			OracleCommand sqlCmd;
			OracleDataAdapter sqlAdp;
			DataTable  objDT;
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
			try
			{
				m_oConn=new OracleConnection (this.p_sConnectString );
				this.m_oConn.Open();
				sqlCmd=new OracleCommand();
				sqlCmd.Connection=m_oConn;
				sqlCmd.CommandType=CommandType.Text;
				sqlCmd.CommandText =strSQL;
				sqlAdp=new OracleDataAdapter();
				sqlAdp.SelectCommand = sqlCmd;
				objDT = new DataTable();
				sqlAdp.Fill(objDT);
				//m_oConn.Close();
			}
			catch(Exception e)
			{
				Console.WriteLine(e.ToString() );
				return null;
			}

			finally
			{
				m_oConn.Close();	
			}
			if (objDT.Rows.Count == 0 )
			{
				objDT = null;
				return arrList;
			}
			for (iRow = 0; iRow<= objDT.Rows.Count - 1;iRow++)
			{
				strKeyValue = "";
				for (iCol = 0; iCol<= objDT.Columns.Count - 1;iCol++)
				{
					if (iCol == 0 )
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
		public ArrayList funGetFldDataOfTable2(string strTableName, 
			string strFieldName, 
			string WhereConditionString,
			string strOrderBy)
		{
			//��ò����ر�
			OracleCommand sqlCmd;
			OracleDataAdapter sqlAdp;
			DataTable  objDT;
			ArrayList arrList= new ArrayList();
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
			try
			{
				m_oConn=new OracleConnection (this.p_sConnectString );
				this.m_oConn.Open();
				sqlCmd=new OracleCommand();
				sqlCmd.Connection=m_oConn;
				sqlCmd.CommandType=CommandType.Text;
				sqlCmd.CommandText =strSQL;
				sqlAdp=new OracleDataAdapter();
				sqlAdp.SelectCommand = sqlCmd;
				objDT = new DataTable();
				sqlAdp.Fill(objDT);
				//m_oConn.Close();
			}
			catch(Exception e)
			{
				Console.WriteLine(e.ToString() );
				return null;
			}

			finally
			{
				m_oConn.Close();	
			}
			if (objDT.Rows.Count == 0 )
			{
				objDT = null;
				return arrList;
			}
			for (iRow = 0; iRow<= objDT.Rows.Count - 1;iRow++)
			{
				strKeyValue = "";
				for (iCol = 0; iCol<= objDT.Columns.Count - 1;iCol++)
				{
					if (iCol == 0 )
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
		/// <param name="strValue">ֵ���ַ���</param>
		/// <param name="WhereConditionString"></param>
		/// <returns>����Ӱ��ļ�¼����������</returns>
		public int funSetFldDataOfTable(string strTableName, 
			string strFieldName, 
			string strValue, 
			string WhereConditionString)
		{
			//��ò����ر�
			OracleCommand sqlCmd;
			StringBuilder strSQL=new StringBuilder();
			//																						  '��֯SQL��
			if (WhereConditionString != "")
			{
				WhereConditionString = " where " + WhereConditionString;
			}
			strSQL.AppendFormat("update {0} ", strTableName);
			strSQL.AppendFormat("Set {0} = '{1}' {2}", strFieldName, strValue, WhereConditionString);
			try
			{
				m_oConn=new OracleConnection (this.p_sConnectString);
				m_oConn.Open();
				sqlCmd=new OracleCommand();
				sqlCmd.CommandType =CommandType.Text;
				sqlCmd.Connection=m_oConn;
				sqlCmd.CommandText =strSQL.ToString();
				int intRecCount =  sqlCmd.ExecuteNonQuery();
				return intRecCount;
			}
			catch(Exception e)
			{
				Console.WriteLine(e.ToString() );
				return -1;
			}
			finally
			{
				m_oConn.Close();
			}
			//			return intRecCount;
		}
					
		/// <summary>
		/// ���ܣ�����ĳ��ķ���������ĳ�ֶ�ֵ
		/// </summary>
		/// <param name="strTableName">����</param>
		/// <param name="strFieldName">�ֶ���</param>
		/// <param name="intValue">����ֵ</param>
		/// <param name="WhereConditionString"></param>
		/// <returns>����Ӱ��ļ�¼����������</returns>
		public int funSetFldDataOfTable(string strTableName, 
			string strFieldName, 
			int intValue, 
			string WhereConditionString)
		{
			//��ò����ر�
			OracleCommand sqlCmd;
			StringBuilder strSQL=new StringBuilder();
			//																						  '��֯SQL��
			if (WhereConditionString != "")
			{
				WhereConditionString = " where " + WhereConditionString;
			}
			strSQL.AppendFormat("update {0} ", strTableName);
			strSQL.AppendFormat("Set {0} = {1} {2}", strFieldName, intValue, WhereConditionString);
			try
			{
				m_oConn=new OracleConnection (this.p_sConnectString);
				m_oConn.Open();
				sqlCmd=new OracleCommand();
				sqlCmd.CommandType =CommandType.Text;
				sqlCmd.Connection=m_oConn;
				sqlCmd.CommandText =strSQL.ToString();
				int intRecCount =  sqlCmd.ExecuteNonQuery();
				return intRecCount;
			}
			catch(Exception e)
			{
				Console.WriteLine(e.ToString() );
				return -1;
			}
			finally
			{
				m_oConn.Close();
			}
			//			return intRecCount;
		}

		/// <summary>
		/// ���ܣ�����ĳ��ķ���������ĳ�ֶ�ֵ
		/// </summary>
		/// <param name="strTableName">����</param>
		/// <param name="strFieldName">�ֶ���</param>
		/// <param name="fltValue">������ֵ</param>
		/// <param name="WhereConditionString"></param>
		/// <returns>����Ӱ��ļ�¼����������</returns>
		public int funSetFldDataOfTable(string strTableName, 
			string strFieldName, 
			float fltValue, 
			string WhereConditionString)
		{
			//��ò����ر�
			OracleCommand sqlCmd;
			StringBuilder strSQL=new StringBuilder();
			//																						  '��֯SQL��
			if (WhereConditionString != "")
			{
				WhereConditionString = " where " + WhereConditionString;
			}

			strSQL.AppendFormat("update {0} ", strTableName);
			strSQL.AppendFormat("Set {0} = {1} {2}", strFieldName, fltValue, WhereConditionString);
			try
			{
				m_oConn=new OracleConnection (this.p_sConnectString);
				m_oConn.Open();
				sqlCmd=new OracleCommand();
				sqlCmd.CommandType =CommandType.Text;
				sqlCmd.Connection=m_oConn;
				sqlCmd.CommandText =strSQL.ToString();
				int intRecCount =  sqlCmd.ExecuteNonQuery();
				return intRecCount;
			}
			catch(Exception e)
			{
				Console.WriteLine(e.ToString() );
				return -1;
			}
			finally
			{
				m_oConn.Close();
			}
			//			return intRecCount;
		}

		public OracleConnection OracleConnect
		{
			get
			{
				try
				{
					m_oConn=new OracleConnection (this.p_sConnectString);
					m_oConn.Open();
					return m_oConn;
				}
				catch(Exception objException)
				{
					LogError(objException,"");
					Console.WriteLine(objException.ToString() );
					throw new Exception(EXCEPTION_MSG + objException.Message, objException);
					//					return null;
				}
				finally
				{
					m_oConn.Close();
				}
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

            OracleCommand sqlCmd;
            OracleDataAdapter sqlAdp;
            DataSet dtSet;
            m_oConn = getConnectObj(this.p_sConnectString);

            try
            {
                sqlCmd = new OracleCommand();
                sqlCmd.Connection = m_oConn;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = objTable_SqlCommandText.SqlCommandText;

                sqlAdp = new OracleDataAdapter();
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
            OracleCommand sqlCmd;
            OracleDataAdapter sqlAdp;
            DataSet dtSet;
            m_oConn = getConnectObj(this.p_sConnectString);
            string strSql = "";
            try
            {
                sqlCmd = new OracleCommand();
                sqlCmd.Connection = m_oConn;
                sqlCmd.CommandType = CommandType.Text;

                sqlAdp = new OracleDataAdapter();
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
        /// �Ƿ���ڼ�¼
        /// </summary>
        /// <param name="strTable">����</param>
        /// <param name="strCondition">������</param>
        /// <param name="objSqlConnect">OracleConnection</param>
        /// <param name="objSqlTransaction">OracleTransaction</param>
        /// <returns>�Ƿ����</returns>
        public bool IsExistRecord(string strTable, string strCondition, OracleConnection objSqlConnect, OracleTransaction objSqlTransaction)
        {
            //by ���Է�
            //2004-3-8 11:12
            //����¼�Ƿ����
            OracleCommand sqlCmd = null;
            OracleDataAdapter sqlAdp;
            DataTable dtTab;

            try
            {
                sqlCmd = new OracleCommand();
                sqlCmd.Connection = objSqlConnect;
                sqlCmd.Transaction = objSqlTransaction;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "select * from " + strTable + " where " + strCondition;

                sqlAdp = new OracleDataAdapter();
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
        } /// <summary>
        /// ��ȡ�����������-SQL�������DataSet
        /// </summary>
        /// <param name="arrTable_SqlCommandTextList">����-SQL�������б�</param>
        /// <returns>����DataSet</returns>
        public DataSet GetDataSet(ArrayList arrTable_SqlCommandTextList)
        {
            //by ���Է�
            //2007-12-2
            //��ò����ؼ�¼��
            OracleCommand sqlCmd;
            OracleDataAdapter sqlAdp;
            DataSet dtSet;
            m_oConn = getConnectObj(this.p_sConnectString);
            string strSql = "";
            try
            {
                sqlCmd = new OracleCommand();
                sqlCmd.Connection = m_oConn;
                sqlCmd.CommandType = CommandType.Text;

                sqlAdp = new OracleDataAdapter();
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
        /// <param name="objTable_SqlCommandText">����-SQL������</param>
        /// <returns>����DataSet</returns>
        public DataSet GetDataSet(clsTable_SqlCommandText objTable_SqlCommandText)
        {

            OracleCommand sqlCmd;
            OracleDataAdapter sqlAdp;
            DataSet dtSet;
            m_oConn = getConnectObj(this.p_sConnectString);

            try
            {
                sqlCmd = new OracleCommand();
                sqlCmd.Connection = m_oConn;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = objTable_SqlCommandText.SqlCommandText;

                sqlAdp = new OracleDataAdapter();
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
		public DataSet GetDataSet(string ssql,string stablename)
		{
			//by davidfujian (��˳��)
			//2004-3-21 Noon
			//��ò����ؼ�¼��
			OracleCommand sqlCmd;
			OracleDataAdapter sqlAdp;
			DataSet  dtSet;
			try
			{
				m_oConn=new OracleConnection (this.p_sConnectString );
				this.m_oConn.Open();

				sqlCmd=new OracleCommand();
				sqlCmd.Connection=m_oConn;
				sqlCmd.CommandType=CommandType.Text;
				sqlCmd.CommandText =ssql;

				sqlAdp=new OracleDataAdapter();
				sqlAdp.SelectCommand = sqlCmd;
				dtSet=new DataSet();
				sqlAdp.Fill(dtSet,stablename);
				return dtSet;
			}

			catch(Exception objException)
			{
				LogError(objException,"");
				Console.WriteLine(objException.ToString() );
				throw new Exception(EXCEPTION_MSG + objException.Message, objException);
				//				dtSet=new DataSet();
				//				return dtSet;
			}
			finally
			{
				m_oConn.Close();
			}
		}
		
		public bool CheckDataExist(string ssql,string scondition)
		{
			//by davidfujian(��˳��)
			//2004-3-8 11:12
			//����¼�Ƿ����
			OracleCommand sqlCmd;
			OracleDataReader  dtRedr;
			
			try
			{
				m_oConn=new OracleConnection (this.p_sConnectString);
				m_oConn.Open();

				sqlCmd=new OracleCommand();
				sqlCmd.Connection =m_oConn;
				sqlCmd.CommandType =CommandType.Text;
				sqlCmd.CommandText =ssql + " where " + scondition;
				//Console.WriteLine(sqlCmd.CommandText);
			
				dtRedr=sqlCmd.ExecuteReader();
				bool flag=dtRedr.HasRows;
				m_oConn.Close();
				dtRedr.Close();
				return flag;
			}

			catch(Exception objException)
			{
				LogError(objException,"");
				Console.WriteLine(objException.ToString() );
				throw new Exception(EXCEPTION_MSG + objException.Message, objException);
				//				return false;
			}

			finally
			{
				m_oConn.Close();
			}
		}
		public bool IsExistRecord(string strTable,string strCondition)
		{
			//by davidfujian(���Է�)
			//2004-3-8 11:12
			//����¼�Ƿ����
			OracleCommand sqlCmd;
			OracleDataReader  dtRedr;
			
			try
			{
				m_oConn=new OracleConnection (this.p_sConnectString);
				m_oConn.Open();

				sqlCmd=new OracleCommand();
				sqlCmd.Connection =m_oConn;
				sqlCmd.CommandType =CommandType.Text;
				sqlCmd.CommandText ="select * from " + strTable + " where " + strCondition;
				//Console.WriteLine(sqlCmd.CommandText);
			
				dtRedr=sqlCmd.ExecuteReader();
				bool flag=dtRedr.HasRows;
				m_oConn.Close();
				dtRedr.Close();
				return flag;
			}

			catch(Exception objException)
			{
				LogError(objException,"");
				Console.WriteLine(objException.ToString() );
				throw new Exception(EXCEPTION_MSG + objException.Message, objException);
				//				return false;
			}
			finally
			{
				m_oConn.Close();
			}
		}

        public DataSet ExecSPreturnDS(string sSPName, ArrayList paramValues, string stablename)
        {

            //by davidfujian 2004-3-21 NOON
            //Exec a SP with long parameters and return a DataSet
            DataSet ds = new DataSet();
            OracleCommand sqlCmd;
            clsSqlConnect_Tz objSqlConnect_Tz = null;

            try
            {
                objSqlConnect_Tz = clsSqlConnect_Tz.getOracleConnect(this.p_sConnectString);
                ////m_oConn=new OracleConnection(this.p_sConnectString );
                //this.m_oConn.Open();
                m_oConn = objSqlConnect_Tz.OracleConnect;
                sqlCmd = new OracleCommand(sSPName, m_oConn);
                sqlCmd.CommandText = sSPName;
                sqlCmd.Connection = m_oConn;
                sqlCmd.CommandType = CommandType.StoredProcedure;
                BuildParameters(sqlCmd, paramValues);

                OracleDataAdapter sqlDA = new OracleDataAdapter(sqlCmd);
                sqlDA.Fill(ds, stablename);

                return ds;
            }
            catch (Exception objException)
            {
                LogError(objException, "");
                Console.WriteLine(objException.ToString());
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
                //				return null;
            }
            finally
            {
                objSqlConnect_Tz.Close();
                //				m_oConn.CloseB();		
            }
        }

        protected bool BuildParameters(OracleCommand cmd, ArrayList paramValues)
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
            OracleParameter objParameter;

            string strParameterName;
            int intParameterSize;
            OracleType intSQLDataType;
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

                    objParameter = new OracleParameter(strParameterName, intSQLDataType, intParameterSize);
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
                    //Console.WriteLine(intParamCounter);
                }
            }
            catch (Exception objException)
            {
                LogError(objException, "");
                Console.WriteLine(objException.ToString());
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
                //				return false;
            }

            finally
            {

            }
            return true;
        }

		public bool ExecSql(string ssql)
		{
			//by davidfujian(��˳��)
			//2004-3-18 8:18
			//ִ��Stored Procedure
			try
			{
				OracleCommand sqlCmd;	
				m_oConn=new OracleConnection (this.p_sConnectString);
				m_oConn.Open();
				sqlCmd=new OracleCommand();
				sqlCmd.CommandType =CommandType.Text;
				sqlCmd.Connection=m_oConn;
				sqlCmd.CommandText =ssql;
				sqlCmd.ExecuteNonQuery();
				return true;
			}
			catch(Exception objException)
			{
				LogError(objException,"");
				Console.WriteLine(objException.ToString() );
				throw new Exception(EXCEPTION_MSG + objException.Message, objException);
				//				return false;
			}
			finally
			{
				m_oConn.Close();
			}
		}

        public bool ExecSql(string ssql, OracleConnection objOraConnect, OracleTransaction objOraTransaction)
        {
            //by davidfujian(��˳��)
            //2004-3-18 8:18
            //ִ��Stored Procedure
            try
            {
                OracleCommand sqlCmd;            
                sqlCmd = new OracleCommand();
                sqlCmd.Transaction = objOraTransaction;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Connection = objOraConnect;
                sqlCmd.CommandText = ssql;
                sqlCmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception objException)
            {
                LogError(objException, "");
                Console.WriteLine(objException.ToString());
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
                //				return false;
            }
            finally
            {
                m_oConn.Close();
            }
        }
        public static bool TestConnect(string strConnectString)
        {
            OracleConnection objConn = new OracleConnection();
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
		/// <summary>
		/// ���ܣ�ִ��SQL���
		/// </summary>
		/// <param name="ssql">��Ҫִ�е�SQL���</param>
		/// <returns>ִ��SQL���Ӱ��ļ�¼��������</returns>
		public int ExecSql2(string ssql)
		{
			int intRecCount;
			try
			{
				OracleCommand sqlCmd;	
				m_oConn=new OracleConnection (this.p_sConnectString);
				m_oConn.Open();
				sqlCmd=new OracleCommand();
				sqlCmd.CommandType =CommandType.Text;
				sqlCmd.Connection=m_oConn;
				sqlCmd.CommandText =ssql;
				intRecCount = sqlCmd.ExecuteNonQuery();
				return intRecCount;
			}
			catch(Exception objException)
			{
				LogError(objException,"");
				Console.WriteLine(objException.ToString() );
				throw new Exception(EXCEPTION_MSG + objException.Message, objException);
			}
			finally
			{
				m_oConn.Close();
			}
		}


		public ArrayList GetDistinctStringItems(string ssql)
		{	
			//by davidfujian
			//9:57 2004-3-28
			ArrayList sarray=new ArrayList();
			try
			{
				m_oConn=new OracleConnection (this.p_sConnectString);
				m_oConn.Open();
			
				OracleCommand sqlCmd;

				sqlCmd=new OracleCommand();
				sqlCmd.Connection =m_oConn;
				sqlCmd.CommandType =CommandType.Text;
				sqlCmd.CommandText =ssql;

				OracleDataReader  dtRedr;
				dtRedr=sqlCmd.ExecuteReader();
			
				while(dtRedr.Read())
				{
					sarray.Add(dtRedr.GetString(0));
				}
			
				//Close the connection to the DataBase!!
				m_oConn.Close();
				return sarray;
			}
			catch(Exception objException)
			{
				LogError(objException,"");
				Console.WriteLine(objException.ToString() );
				throw new Exception(EXCEPTION_MSG + objException.Message, objException);
				//				return null;
			}
			finally
			{
				m_oConn.Close();
			}
		}


		public string ParentDir(string strPath)
		{
			string pDir;
			int i;
			i=strPath.LastIndexOf("\\");
			if (i==0) return null;
			pDir=strPath.Substring(0, i);
			return pDir;
		}
		
		public string GetMaxStrId(string strTabName, string strFldName, int intFldLen, string strPrefix)
		{
			OracleCommand sqlCmd;
			OracleDataAdapter sqlAdp;
			int intPrefixLen;

			System.Data.DataTable objDT;
			StringBuilder strSQL = new StringBuilder();
			intPrefixLen = strPrefix.Length;
			if (strPrefix=="")
			{
				strSQL.AppendFormat("select Max({0}) from {1}" , strFldName, strTabName);
			}
			else
			{
				strSQL.AppendFormat("select Max({0}) from {1} where {0} like '{2}%'" , 
					strFldName, strTabName, strPrefix);
			}
			try
			{
				m_oConn=new OracleConnection (this.p_sConnectString );
				this.m_oConn.Open();
				sqlCmd=new OracleCommand();
				sqlCmd.Connection=m_oConn;
				sqlCmd.CommandType=CommandType.Text;
				sqlCmd.CommandText =strSQL.ToString();
				sqlAdp=new OracleDataAdapter();
				sqlAdp.SelectCommand = sqlCmd;
				objDT = new DataTable();
				sqlAdp.Fill(objDT);
			}
			catch(Exception objException)
			{
				LogError(objException,"");
				Console.WriteLine(objException.ToString() );
				throw new Exception(EXCEPTION_MSG + objException.Message, objException);
			}
			finally
			{
				m_oConn.Close();
			}
			
			if (objDT.Rows.Count == 0)
			{
				return strPrefix +   combineStr("0", intFldLen-1 - intPrefixLen) + "1";
				
			}
			string strMaxValue = objDT.Rows[0][0].ToString();
			if (strMaxValue == "")
			{
				return  strPrefix + combineStr("0", intFldLen - 1 - intPrefixLen) + "1";
			}

			int intNextMaxValue, intLen;
			string strNextMaxValue, strTemp ;
			if (strPrefix =="")
			{
				intNextMaxValue = int.Parse(strMaxValue) +1;
				strNextMaxValue = intNextMaxValue.ToString();
				intLen = strNextMaxValue.Length;
				strNextMaxValue = combineStr("0", intFldLen-intLen) + strNextMaxValue;
				return strNextMaxValue;
			}
			else
			{
				strTemp = strMaxValue.Substring(intPrefixLen);
				intNextMaxValue = int.Parse(strTemp) +1;
				strNextMaxValue = intNextMaxValue.ToString();
				intLen = strNextMaxValue.Length;
				strNextMaxValue =strPrefix + combineStr("0", intFldLen-intLen - intPrefixLen) + strNextMaxValue;
				return strNextMaxValue;
			}
		}
        /// <summary>
        /// ���ܣ�	��ȡĳ���з���������ĳ�ֶε�ֵ
        /// </summary>
        /// <param name="strTableName">����</param>
        /// <param name="strFieldName">�ֶ���</param>
        /// <param name="WhereConditionString">������</param>
        /// <returns>�б�</returns>
        public List<string> funGetFldDataOfTableNoDistinct(string strTableName,
            string strFieldName,
            string WhereConditionString)
        {
            string strWhere = WhereConditionString.ToLower();
            strWhere = strWhere.Replace("  ", " ");

            //��ò����ر�
            OracleCommand sqlCmd;
            OracleDataAdapter sqlAdp;
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
                sqlCmd = new OracleCommand();
                sqlCmd.Connection = m_oConn;
                sqlCmd.CommandType = CommandType.Text;

                sqlCmd.CommandTimeout = 9600;
                sqlCmd.CommandText = strSQL;
                sqlAdp = new OracleDataAdapter();
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

        public OracleConnection getConnectObj(string strConnectString)
        {
            OracleConnection objSqlConnect = null;
            try
            {
                objSqlConnect = new OracleConnection(strConnectString);
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
		public string GetMaxStrId(string strTabName, string strFldName, int intFldLen, string strPrefix, int intAdditionValue)
		{
			OracleCommand sqlCmd;
			OracleDataAdapter sqlAdp;
			int intPrefixLen;

			System.Data.DataTable objDT;
			StringBuilder strSQL = new StringBuilder();
			intPrefixLen = strPrefix.Length;
			if (strPrefix=="")
			{
				strSQL.AppendFormat("select Max({0}) from {1}" , strFldName, strTabName);
			}
			else
			{
				strSQL.AppendFormat("select Max({0}) from {1} where {0} like '{2}%'" , 
					strFldName, strTabName, strPrefix);
			}
			try
			{
				m_oConn=new OracleConnection (this.p_sConnectString );
				this.m_oConn.Open();
				sqlCmd=new OracleCommand();
				sqlCmd.Connection=m_oConn;
				sqlCmd.CommandType=CommandType.Text;
				sqlCmd.CommandText =strSQL.ToString();
				sqlAdp=new OracleDataAdapter();
				sqlAdp.SelectCommand = sqlCmd;
				objDT = new DataTable();
				sqlAdp.Fill(objDT);
			}
			catch(Exception objException)
			{
				LogError(objException,"");
				Console.WriteLine(objException.ToString() );
				throw new Exception(EXCEPTION_MSG + objException.Message, objException);
			}
			finally
			{
				m_oConn.Close();
			}
			
			if (objDT.Rows.Count == 0)
			{
				return strPrefix +   combineStr("0", intFldLen-1 - intPrefixLen) + "1";
				
			}
			string strMaxValue = objDT.Rows[0][0].ToString();
			if (strMaxValue == "")
			{
				strMaxValue = "0";
			}

			int intNextMaxValue, intLen;
			string strNextMaxValue, strTemp ;
			if (strPrefix =="")
			{
				intNextMaxValue = int.Parse(strMaxValue) + 1 + intAdditionValue;
				strNextMaxValue = intNextMaxValue.ToString();
				intLen = strNextMaxValue.Length;
				strNextMaxValue = combineStr("0", intFldLen-intLen) + strNextMaxValue;
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
				strNextMaxValue =strPrefix + combineStr("0", intFldLen-intLen - intPrefixLen) + strNextMaxValue;
				return strNextMaxValue;
			}
		}

		/// <summary>
		/// ��װ�ַ�����
		/// </summary>
		/// <param name="mStr">ԭ�����ַ���</param>
		/// <param name="count">���ַ������ظ�����</param>
		/// <returns>��װ�õ��ַ���</returns>
		public string combineStr(string mStr, int count)
		{
			string strTemp="";
			for (int i = 0; i<count; i++)
				strTemp += mStr;
			return strTemp;
		}

		#endregion

		//XML Methods
		#region "XML Methods"

		protected void ValidateSPName(string SPName )
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
		protected OracleType GetSqlDataType(string dbtype)
		{
			switch (dbtype)
			{
				case "BigInt":

                    return OracleType.Int32;
                    		
				case "Binary" :
                    return OracleType.Byte;
				
				case "Bit" :
                    return OracleType.Byte;

				case "Char":
                    return OracleType.Char;
					
				case "DateTime":
                    return OracleType.DateTime;
					
				case "Decimal" :
                    return OracleType.Number;
					
				case "Float" :
                    return OracleType.Float;
					
				case "Image":
                    return OracleType.Blob;
					
				case "Int":
					return OracleType.Int32;
					
				case "Money":
					return OracleType.Number;
					
				case "NChar":
					return OracleType.NChar;
					
				case "NText":
					return OracleType.NClob;
					
				case "NVarChar":
					return OracleType.NVarChar;
					
				case "Real":
					return OracleType.Double;
					
				case "SmallDateTime":
					return OracleType.DateTime;
					
				case "SmallInt":
					return OracleType.Int16;
					
				case "SmallMoney":
					return OracleType.Float;
					
				case "Text":
					return OracleType.Clob;
					
				case "Timestamp":
					return OracleType.Timestamp;
					
				case "TinyInt":
					return OracleType.Byte;
														
				case "VarChar":
					return OracleType.VarChar;
					
				case "Variant":
					return OracleType.VarChar;
					
				default:
					//Default to Variant if anything else is supplied
					return OracleType.VarChar;
					
			}
		}

        public bool ExecSP(string SPName, ArrayList ParamValues)
        {

            OracleCommand objCommand;
            clsSqlConnect_Tz objSqlConnect_Tz = null;

            try
            {
                ValidateSPName(SPName);
                objSqlConnect_Tz = clsSqlConnect_Tz.getOracleConnect(this.p_sConnectString);
                ////m_oConn=new OracleConnection(this.p_sConnectString );
                //this.m_oConn.Open();
                m_oConn = objSqlConnect_Tz.OracleConnect;
            }
            catch (Exception objException)
            {
                LogError(objException, "������ʧ��!");
                Console.WriteLine(objException.ToString());
                StringBuilder sbMessage = new StringBuilder();
                sbMessage.Append(objException.Message);
                sbMessage.Append("\r\n");
                sbMessage.Append("������ʧ��!�������Ӵ�!\r\n");
                if (string.IsNullOrEmpty(m_sServer) == false && string.IsNullOrEmpty(m_sSID) == false)
                {
                    sbMessage.AppendFormat("�򿪵ķ�������{0}��\r\nSID��{1}��\r\n�û�����{2}��",
                        m_sServer,
                        m_sSID,
                        m_sUid);
                }
                //				sbMessage.Append("������ʧ��!�������Ӵ�!");
                throw new Exception(sbMessage.ToString(), objException);
                //				dtTab=new DataTable();
                //				return dtTab;	
            }
            try
            {
                //Instantiate a new OracleCommand object.
                objCommand = new OracleCommand(SPName, m_oConn);
                //We are using a stored procedure for the CommandType.
                objCommand.CommandType = CommandType.StoredProcedure;
                //Build the parameters for the OracleCommand object.
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
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
                //				return false;
            }
            finally
            {
                objSqlConnect_Tz.Close();
                //				m_oConn.CloseB();		
            }
        }

		protected ParameterDirection GetParamDirection(string ParamDirection)
		{
			switch(ParamDirection)
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




        public ArrayList ExecSpWithOutPut(string SPName, ArrayList ParamValues)
        {
            ArrayList arrLst = new ArrayList();
            OracleCommand objCommand;
            m_oConn = getConnectObj(this.p_sConnectString);

            try
            {
                ValidateSPName(SPName);
                //Instantiate a new OracleCommand object.
                objCommand = new OracleCommand(SPName, m_oConn);
                //We are using a stored procedure for the CommandType.
                objCommand.CommandType = CommandType.StoredProcedure;
                //Build the parameters for the OracleCommand object.
                BuildParameters(objCommand, ParamValues);
                //Execute the stored procedure, and do not return any rows
                int intRecCount = objCommand.ExecuteNonQuery();


                //                'Build the ArrayList of output values
                foreach (OracleParameter objParameter in objCommand.Parameters)
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


        public DataSet ExecSPReturnDS(string sSPName, ArrayList paramValues, string stablename)
        {

            //by davidfujian 2004-3-21 NOON
            //Exec a SP with long parameters and return a DataSet
            DataSet ds = new DataSet();
            OracleCommand sqlCmd;
            m_oConn = getConnectObj(this.p_sConnectString);

            try
            {
                sqlCmd = new OracleCommand(sSPName, m_oConn);
                sqlCmd.CommandText = sSPName;

                sqlCmd.CommandTimeout = 9600;
                sqlCmd.Connection = m_oConn;
                sqlCmd.CommandType = CommandType.StoredProcedure;
                BuildParameters(sqlCmd, paramValues);

                OracleDataAdapter sqlDA = new OracleDataAdapter(sqlCmd);
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

   
	}
}

