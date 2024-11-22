
using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Data.OracleClient;
using System.Collections.Generic;

namespace com.taishsoft.commdbfororacle
{
    public class clsGeneralTab
    {
        protected string _CurrTabName;    //��ǰ�������������صı���
        protected string KeyFldName;	//��ǰ��Ĺؼ����ֶε�����

        //�����ǳ�����Ϣ
        protected string[] mstrErrMsg = { "0:����", "1:Ժϵ��Ϊ��", "2:רҵ���Ϊ��", "3:������ͬ�ı��" };
        //�����ǳ�����Ϣ����
        protected int mintErrNo = 0;   //0:����,1:�����Ϊ��,2:ѧ��Ϊ��
        protected string mstrDispErrMsg;         //������ʾ�Ĵ�����Ϣ
        protected string mstrModuleName;
        //		public static string mstrClassName;
        protected bool mblnDisposed = false;     //�Ƿ��Ѿ��ͷŶ���(������������)
        protected const string EXCEPTION_MSG = " there was an error in the method. please see the Application Log for details.";
        //���������Ա���
        ///�ú���������:
        protected string m_sSID;
        protected string m_sServer_Tz;
        protected string m_sUid;
        protected string m_sPassword_Tz;
        protected string p_sConnectString;
        protected bool mbolIsHaveSpecialConnectString;	//�Ƿ�����������Ӵ�

        public clsGeneralTab()
        {
            SetInit();
        }
        public clsGeneralTab(string strServer, string strSID, string strUid, string strPassword)
        {
            this.m_sServer_Tz = strServer;
            this.m_sSID = strSID;
            this.m_sUid = strUid;
            this.m_sPassword_Tz = strPassword;
            mbolIsHaveSpecialConnectString = true;
            p_sConnectString = GetConnectString();
        }
        public string GetConnectString()
        {
            //by davidfujian (��˳��)
            //2004-2-28 Night
            //��������ַ���
            StringBuilder sbConnString = new StringBuilder();
            sbConnString.Append("Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)");
            sbConnString.AppendFormat("(HOST={0})",
                this.m_sServer_Tz);
            sbConnString.Append("(PORT=1521)))");
            sbConnString.AppendFormat("(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME={0})));",
                this.m_sSID);
            sbConnString.AppendFormat("User Id={0};Password={1};",
                this.m_sUid,
                this.m_sPassword_Tz);
            p_sConnectString = sbConnString.ToString();
            return p_sConnectString;
        }
        /// <summary>
        /// ��ȡSQL����
        /// </summary>
        /// <returns></returns>
        public static clsSpecSQLforOra GetSpecSQLObj_GeneralTab()
        {
            clsSpecSQLforOra objSQL = null;
            if (clsSpecSQLforOra.bolIsUseConnectStrName == true)
            {
                objSQL = new clsSpecSQLforOra(clsSpecSQLforOra.strConnectStrName, true);
                return objSQL;
            }
            if (string.IsNullOrEmpty(clsSpecSQLforOra.ConnectString) == true)
            {
                objSQL = new clsSpecSQLforOra();
            }
            else
            {
                objSQL = new clsSpecSQLforOra(clsSpecSQLforOra.ConnectString);
            }
            return objSQL;

        }
        /// <summary>
        /// ���������Щ���Գ�ʼֵ
        /// </summary>
        protected void SetInit()
        {
            _CurrTabName = "Users";    //��ǰ�������������صı���
            KeyFldName = "UserId";		//��ǰ��Ĺؼ����ֶε�����
            mstrModuleName = this.GetType().ToString();
        }


        public int ErrNo
        {
            get
            {
                return mintErrNo;
            }
            set
            {
                mintErrNo = value;
            }
        }
        public bool IsHaveSpecialConnectString
        {
            get
            {
                return this.mbolIsHaveSpecialConnectString;
            }
            set
            {
                this.mbolIsHaveSpecialConnectString = value;
            }
        }
        public string SID
        {
            get
            {
                return this.m_sSID;
            }
            set
            {
                if (value != "" && this.m_sSID != value)
                    this.m_sSID = value;
            }
        }

        public string Server_Tz
        {
            get
            {
                return this.m_sServer_Tz;
            }
            set
            {
                if (value != "" && this.m_sServer_Tz != value)
                    this.m_sServer_Tz = value;
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

        public string Password_Tz
        {
            get
            {
                return this.m_sPassword_Tz;
            }
            set
            {
                if (value != "" && this.m_sPassword_Tz != value)
                    this.m_sPassword_Tz = value;
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

        public string DispErrMsg       //������ʾ�Ĵ�����Ϣ
        {
            get
            {
                return mstrDispErrMsg;
            }
            set
            {
                mstrDispErrMsg = value;
            }
        }
        public string TabName_Curr
        {
            get
            {
                return _CurrTabName;
            }
        }
        public string TabKeyFldName
        {
            get
            {
                return KeyFldName;
            }
        }
        public virtual bool AddNewRecord()
        {
            return true;
        }

        public virtual bool Update()
        {
            return true;
        }

        /// <summary>
        /// ���ܣ��޸Ķ�����¼
        /// </summary>
        /// <param name="strCondition"></param>
        /// <returns></returns>
        public virtual int UpdateMultiRec(string strCondition)
        {
            return 0;
        }

        /// <summary>
        /// ���ܣ���ȡ��ǰ��ļ�¼��.�ñ��뵱ǰ����ء�
        /// </summary>
        /// <returns>��¼����Ϊ����</returns>
        public int funGetRecCount()
        {
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
            int intRecCount = objSQL.funGetRecCount(_CurrTabName);
            return intRecCount;
        }

        /// <summary>
        /// ���ܣ���ȡ��ǰ��ļ�¼��.�ñ��뵱ǰ����ء�
        /// </summary>
        /// <param name="strTabName">�������ı���</param>
        /// <returns>��¼����Ϊ����</returns>
        public static int funGetRecCount(string strTabName)
        {
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
            int intRecCount = objSQL.funGetRecCount(strTabName);
            return intRecCount;
        }


        /// <summary>
        /// ���ܣ���ȡ��ǰ�������������ļ�¼��
        /// </summary>
        /// <param name="strCondtion">�������ļ�¼����</param>
        /// <returns>��¼����Ϊ����</returns>
        public int funGetRecCountByCond(string strCondtion)
        {
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
            int intRecCount = objSQL.funGetRecCount(_CurrTabName, strCondtion);
            return intRecCount;
        }

        /// <summary>
        /// ���ܣ���ȡ�����������������ļ�¼��
        /// </summary>
        /// <param name="strTabName">�������ı���</param>
        /// <param name="strCondtion">�������ļ�¼����</param>
        /// <returns>��¼����Ϊ����</returns>
        public static int funGetRecCountByCond(string strTabName, string strCondtion)
        {
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
            int intRecCount = objSQL.funGetRecCount(strTabName, strCondtion);
            return intRecCount;
        }


        /// <summary>
        /// ���ܣ����õ�ǰ���еķ���������ĳ�ֶε�ֵ
        /// </summary>
        /// <param name="strFldName">�ֶ���</param>
        /// <param name="strValue">ֵ</param>
        /// <param name="strCondition">������</param>
        /// <returns>Ӱ��ļ�¼��</returns>
        public int funSetFldValue(string strFldName, string strValue, string strCondition)
        {
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
            int intRecCount = objSQL.funSetFldDataOfTable(_CurrTabName, strFldName, strValue, strCondition);
            return intRecCount;
        }


        /// <summary>
        /// ���ܣ����õ�ǰ���еķ���������ĳ�ֶε�ֵ
        /// </summary>
        /// <param name="strFldName">�ֶ���</param>
        /// <param name="fltValue">ֵ</param>
        /// <param name="strCondition">������</param>
        /// <returns>Ӱ��ļ�¼��</returns>
        public int funSetFldValue(string strFldName, float fltValue, string strCondition)
        {
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
            int intRecCount = objSQL.funSetFldDataOfTable(_CurrTabName, strFldName, fltValue, strCondition);
            return intRecCount;
        }

        /// <summary>
        /// ���ܣ����õ�ǰ���еķ���������ĳ�ֶε�ֵ
        /// </summary>
        /// <param name="strFldName">�ֶ���</param>
        /// <param name="intValue">ֵ</param>
        /// <param name="strCondition">������</param>
        /// <returns>Ӱ��ļ�¼��</returns>
        public int funSetFldValue(string strFldName, int intValue, string strCondition)
        {
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
            int intRecCount = objSQL.funSetFldDataOfTable(_CurrTabName, strFldName, intValue, strCondition);
            return intRecCount;
        }

        /// <summary>
        /// ���ܣ����ø������еķ���������ĳ�ֶε�ֵ
        /// </summary>
        /// <param name="strTabName">����</param>
        /// <param name="strFldName">�ֶ���</param>
        /// <param name="strValue">ֵ</param>
        /// <param name="strCondition">������</param>
        /// <returns>Ӱ��ļ�¼��</returns>
        public static int funSetFldValue(string strTabName, string strFldName, string strValue, string strCondition)
        {
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
            int intRecCount = objSQL.funSetFldDataOfTable(strTabName, strFldName, strValue, strCondition);
            return intRecCount;
        }

        /// <summary>
        /// ���ܣ����ø������еķ���������ĳ�ֶε�ֵ
        /// </summary>
        /// <param name="strTabName">����</param>
        /// <param name="strFldName">�ֶ���</param>
        /// <param name="intValue">ֵ</param>
        /// <param name="strCondition">������</param>
        /// <returns>Ӱ��ļ�¼��</returns>
        public static int funSetFldValue(string strTabName, string strFldName, int intValue, string strCondition)
        {
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
            int intRecCount = objSQL.funSetFldDataOfTable(strTabName, strFldName, intValue, strCondition);
            return intRecCount;
        }

        /// <summary>
        /// ���ܣ����ø������еķ���������ĳ�ֶε�ֵ
        /// </summary>
        /// <param name="strTabName">����</param>
        /// <param name="strFldName">�ֶ���</param>
        /// <param name="fltValue">ֵ</param>
        /// <param name="strCondition">������</param>
        /// <returns>Ӱ��ļ�¼��</returns>
        public static int funSetFldValue(string strTabName, string strFldName, float fltValue, string strCondition)
        {
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
            int intRecCount = objSQL.funSetFldDataOfTable(strTabName, strFldName, fltValue, strCondition);
            return intRecCount;
        }


        /// <summary>
        /// ���ܣ���ȡ��ǰ���еķ���������ĳ�ֶε�ֵ�����б���
        /// </summary>
        /// <param name="strFldName">�ֶ���</param>
        /// <param name="strCondition">������</param>
        /// <returns>��ȡ���ֶ�ֵ�б�</returns>
        public List<string> funGetFldValue(string strFldName, string strCondition)
        {
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
            List<string> arrList = objSQL.funGetFldDataOfTable(_CurrTabName, strFldName, strCondition);
            return arrList;
        }


        /// <summary>
        /// ���ܣ���ȡ�������еķ���������ĳ�ֶε�ֵ�����б���
        /// </summary>
        /// <param name="strTabName">����</param>
        /// <param name="strFldName">�ֶ���</param>
        /// <param name="strCondition">������</param>
        /// <returns>��ȡ���ֶ�ֵ�б�</returns>
        public static List<string> funGetFldValue(string strTabName, string strFldName, string strCondition)
        {
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
            List<string> arrList = objSQL.funGetFldDataOfTable(strTabName, strFldName, strCondition);
            return arrList;
        }


        public virtual bool DelRecord()
        {
            return true;
        }

        ////ͬʱɾ��������¼
        ///// <summary>
        ///// ��Ҫ��������д
        ///// </summary>
        ///// <param name="lstKey"></param>
        ///// <returns></returns>
        //		public static bool DelUsers(ArrayList lstKey)
        //		{
        //			clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
        //			string strSQL;
        //			string strKeyList;
        //			if (lstKey.Count ==0) return true;
        //			strKeyList = "";
        //			for (int i=0; i<lstKey.Count; i++)
        //			{
        //				if (i==0) strKeyList = strKeyList + "'" + lstKey[i].ToString() + "'";
        //				else strKeyList += ","  + "'" + lstKey[i].ToString() + "'";
        //			}
        //			strSQL = "";
        //			//ɾ��Users�������뵱ǰ�����йصļ�¼
        //			strSQL = strSQL + "Delete from " + currTabname + " where " + KeyFldName + " in (" + strKeyList + ")";
        //			return objSQL.ExecSql(strSQL);
        //		}






        /// <summary>
        /// ���ܣ�ɾ��������¼����������ɾ��
        /// </summary>
        /// <param name="strCondition">��Ҫɾ���ļ�¼����</param>
        /// <returns>����ɾ���ļ�¼0��</returns>
        public static int DelMultiRec(string strTabName, string strCondition)
        {
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
            string strSQL;
            if (strCondition == "")
            {
                return 0;	//��ʾɾ��0����¼��ʵ�����ǲ��ܸñ�����м�¼
            }
            else
            {
                strSQL = "Delete from " + strTabName + " where " + strCondition;
            }
            int intRecoCount = objSQL.ExecSql2(strSQL);
            return intRecoCount;
        }


        ///// <summary>
        ///// ����������д
        ///// </summary>
        ///// <returns></returns>
        //		public bool GetUsers()
        //		{
        //			string strSQL ;
        //			System.Data.DataTable objDT ; 
        //			clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
        //			strSQL = "Select * from Users where UserId=" + "'"+ mstrUserId+"'";
        //			objDT = objSQL.GetDataTable(strSQL);
        //			if (objDT.Rows.Count == 0)
        //			{
        //				objDT = null;
        //				return false;
        //			}
        //			mstrUserId=objDT.Rows[0]["UserId"].ToString().Trim();;
        //			mstrUserName=objDT.Rows[0]["UserName"].ToString().Trim();;
        //			mstrRoleId=objDT.Rows[0]["RoleId"].ToString().Trim();;
        //			mstrDepartmentId=objDT.Rows[0]["DepartmentId"].ToString().Trim();;
        //			objDT = null;
        //			return true;
        //		}
        //
        //		public static System.Data.DataTable GetUsers(string strCondition)
        //		{
        //			string strSQL; 
        //			System.Data.DataTable objDT; 
        //			clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
        //			strSQL = "Select * from Users where " + strCondition;
        //			objDT = objSQL.GetDataTable(strSQL);
        //			return objDT;
        //		}
        //

        /// <summary>
        /// ���ܣ���ȡĳһ�����Ĺؼ����б�
        ///		  �����ؼ����Ƕ���������ؼ���֮����"//"����
        /// </summary>
        /// <param name="strCondtion">������</param>
        /// <returns>�ؼ����б�</returns>
        public ArrayList GetPrimaryKeyID(string strCondtion)
        {
            string strSQL;
            System.Data.DataTable objDT;
            ArrayList arrList = new ArrayList();
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
            int iRow, iCol;
            string strKeyValue;
            strSQL = "Select " + KeyFldName + " from " + _CurrTabName + " where " + strCondtion;
            try
            {
                objDT = objSQL.GetDataTable(strSQL);
            }
            catch (Exception objException)
            {
                //				LogError(objException);
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
                //				objDT = null;
            }
            if (objDT.Rows.Count == 0)
            {
                objDT = null;
                return null;
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


        public static System.Data.DataTable GetDataTable(string strSql)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
            objDT = objSQL.GetDataTable(strSql);
            return objDT;
        }

        public virtual bool IsExist()
        {
            return true;
        }


        /// <summary>
        /// ���ܣ��ж��Ƿ����ĳһ�����ļ�¼
        /// </summary>
        /// <param name="strCondition">������</param>
        /// <returns>������ھͷ���TRUE�����򷵻�FALSE</returns>
        public static bool IsExistCondRec(string strTabName, string strCondition)
        {
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
            if (objSQL.IsExistRecord(strTabName, strCondition))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// ���ܣ��ж��Ƿ����ĳһ�����ļ�¼
        /// </summary>
        /// <param name="strCondition">������</param>
        /// <returns>������ھͷ���TRUE�����򷵻�FALSE</returns>
        public bool IsExistCondRec(string strCondition)
        {
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
            if (objSQL.IsExistRecord(_CurrTabName, strCondition))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public virtual bool CheckProperty(ref string strResult)
        {
            return true;
        }

        public virtual ArrayList GetID(string strCondtion)
        {
            return null;
        }

        //private OracleDataReader GetReader(string strCondtion)
        //{
        //    string strSQL;
        // System.Data.OracleClient.OracleDataReader objDR;
        //    clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
        //    strSQL = "Select * from " + _CurrTabName + " where " + strCondtion;
        //    try
        //    {
        //        objDR = objSQL.GetSqlDataReader(strSQL);
        //    }
        //    catch (Exception objException)
        //    {
        //        LogError(objException);
        //        throw new Exception(EXCEPTION_MSG + objException.Message, objException);
        //    }
        //    finally
        //    {
        //    }
        //    return objDR;
        //}

        public DataTable GetTable(string strCondtion)
        {
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
            strSQL = "Select * from " + _CurrTabName + " where " + strCondtion;
            try
            {
                objDT = objSQL.GetDataTable(strSQL);
            }
            catch (Exception objException)
            {
                LogError(objException);
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
            }
            return objDT;
        }

        public DataTable GetTableBySQL(string strSQL)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
            try
            {
                objDT = objSQL.GetDataTable(strSQL);
            }
            catch (Exception objException)
            {
                LogError(objException);
                throw new Exception(EXCEPTION_MSG + objException.Message, objException);
            }
            finally
            {
            }
            return objDT;
        }

        protected string TransNullToStr(Object obj)
        {
            if (obj.ToString() == "")
            {
                return "";
            }
            else
            {
                return obj.ToString();
            }
        }

        protected int TransNullToInt(Object obj)
        {
            if (obj.ToString() == "")
            {
                return 0;
            }
            else
            {
                return Int32.Parse(obj.ToString());
            }
        }
        protected short TransNullToShort(Object obj)
        {
            if (obj.ToString() == "")
            {
                return 0;
            }
            else
            {
                return short.Parse(obj.ToString());
            }
        }

        protected DateTime TransNullToDate(Object obj)
        {
            if (obj.ToString() == "")
            {
                return DateTime.Parse("#1/1/1900#");
            }
            else
            {
                return DateTime.Parse(obj.ToString());
            }
        }

        protected float TransNullToFloat(Object obj)
        {
            if (obj.ToString() == "")
            {
                return 0.0f;
            }
            else
            {
                return float.Parse(obj.ToString());
            }
        }


        protected double TransNullToDouble(Object obj)
        {
            if (obj.ToString() == "")
            {
                return 0.0;
            }
            else
            {
                return double.Parse(obj.ToString());
            }
        }


        protected bool TransNullToBool(Object obj)
        {
            if (obj.ToString() == "")
            {
                return false;
            }
            else
            {
                return bool.Parse(obj.ToString());
            }
        }

        public int getStrLen(string strTemp)
        {
            int len;
            byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
            len = sarr.Length;//will output as 3+3*2=9
            return len;
        }

        public void Dispose()
        {
            if (mblnDisposed == false)
            {
                try
                {
                    //Free up the database connection resource by 
                    //calling its Dispose method
                    //mobjConnection.Dispose()
                }
                finally
                {
                    //Because this Dispose method has done the necessary cleanup,
                    //prevent the Finalize method from being called.
                    GC.SuppressFinalize(this);

                    //Let our class know that Dispose() has been called
                    mblnDisposed = true;
                }
            }
        }

        protected void LogError(Exception objException)
        {
            //Log the error information to the Application Log
            string strLogMsg;
            try
            {
                strLogMsg = "An error occurred in the following module: "
                    + mstrModuleName + "Source: " + objException.Source

                    + "Message: " + objException.Message
                    + "Stack Trace:  " + objException.StackTrace

                    + "Target Site:  " + objException.TargetSite.ToString();

                //Write error to event log
                System.Diagnostics.EventLog.WriteEntry(mstrModuleName, strLogMsg, System.Diagnostics.EventLogEntryType.Error);
            }
            catch
            {
            }
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
        /// <summary>
        /// ���ܣ���ȡ��ǰ���ڵ��ַ���
        /// ���ڸ�ʽ��
        ///    ���ڵ��ַ����ĸ�ʽ�����֣�
        ///		1��YYYYMMDD��	����20050120
        ///		2��YYYY-MM-DD	����2005-01-20
        ///		3��YYYY/MM/DD	����2005/01/20
        /// </summary>
        /// <param name="intFormat">���ڸ�ʽ������3�֣��������0,1��2
        ///							������ͬ����������ֵ�Ͳ�ͬ��
        ///							�μ���������ڸ�ʽ
        ///	</param>
        /// <returns>���ص�ǰ���ڵ��ַ���</returns>
        public string getTodayStr(int intFormat)
        {
            string strToday;
            string strYear, strMonth, strDay;
            int intYear, intMonth, intDay;
            intYear = System.DateTime.Today.Year;
            intMonth = System.DateTime.Today.Month;
            intDay = System.DateTime.Today.Day;
            strYear = intYear.ToString().Trim();
            if (intMonth > 9) strMonth = intMonth.ToString().Trim();
            else strMonth = "0" + intMonth.ToString().Trim();
            if (intDay > 9) strDay = intDay.ToString().Trim();
            else strDay = "0" + intDay.ToString().Trim();
            strToday = strYear + strMonth + strDay;
            switch (intFormat)
            {
                case 0:
                    strToday = strYear + strMonth + strDay;
                    break;
                case 1:
                    strToday = strYear + "-" + strMonth + "-" + strDay;
                    break;
                case 2:
                    strToday = strYear + "/" + strMonth + "/" + strDay;
                    break;
            }
            return strToday;
        }
        /// <summary>
        /// ���ܣ���ȡ��ǰ�µ��ַ���
        /// �µĸ�ʽ��
        ///    �µ��ַ����ĸ�ʽ�����֣�
        ///		1��YYYYMM��	����200501
        ///		2��YYYY-MM-DD	����2005-01
        ///		3��YYYY/MM/DD	����2005/01
        /// </summary>
        /// <param name="intFormat">�µĸ�ʽ������3�֣��������0,1��2
        ///							������ͬ����������ֵ�Ͳ�ͬ��
        ///							�μ�������µĸ�ʽ
        ///	</param>
        /// <returns>���ص�ǰ�µ��ַ���</returns>
        public string getCurrMonth(int intFormat)
        {
            string strCurrMonth;
            string strYear, strMonth;
            int intYear, intMonth;
            intYear = System.DateTime.Today.Year;
            intMonth = System.DateTime.Today.Month;
            strYear = intYear.ToString().Trim();
            if (intMonth > 9) strMonth = intMonth.ToString().Trim();
            else strMonth = "0" + intMonth.ToString().Trim();
            strCurrMonth = strYear + strMonth;
            switch (intFormat)
            {
                case 0:
                    strCurrMonth = strYear + strMonth;
                    break;
                case 1:
                    strCurrMonth = strYear + "-" + strMonth;
                    break;
                case 2:
                    strCurrMonth = strYear + "/" + strMonth;
                    break;
            }
            return strCurrMonth;
        }

        /// <summary>
        /// ���ܣ���ȡ��ǰ���ڵ��ַ���
        /// ���ڸ�ʽ��
        ///    ���ڵ��ַ����ĸ�ʽ�����֣�
        ///		1��YYYYMMDD��	����20050120
        ///		2��YYYY-MM-DD	����2005-01-20
        ///		3��YYYY/MM/DD	����2005/01/20
        /// </summary>
        /// <param name="intFormat">���ڸ�ʽ������3�֣��������0,1��2
        ///							������ͬ����������ֵ�Ͳ�ͬ��
        ///							�μ���������ڸ�ʽ
        ///	</param>
        /// <returns>���ص�ǰ���ڵ��ַ���</returns>
        public static string getTodayStr_S(int intFormat)
        {
            string strToday;
            string strYear, strMonth, strDay;
            int intYear, intMonth, intDay;
            intYear = System.DateTime.Today.Year;
            intMonth = System.DateTime.Today.Month;
            intDay = System.DateTime.Today.Day;
            strYear = intYear.ToString().Trim();
            if (intMonth > 9) strMonth = intMonth.ToString().Trim();
            else strMonth = "0" + intMonth.ToString().Trim();
            if (intDay > 9) strDay = intDay.ToString().Trim();
            else strDay = "0" + intDay.ToString().Trim();
            strToday = strYear + strMonth + strDay;
            switch (intFormat)
            {
                case 0:
                    strToday = strYear + strMonth + strDay;
                    break;
                case 1:
                    strToday = strYear + "-" + strMonth + "-" + strDay;
                    break;
                case 2:
                    strToday = strYear + "/" + strMonth + "/" + strDay;
                    break;
            }
            return strToday;
        }
        /// <summary>
        /// ���ܣ���ȡ��ǰ�µ��ַ���
        /// �µĸ�ʽ��
        ///    �µ��ַ����ĸ�ʽ�����֣�
        ///		1��YYYYMM��	����200501
        ///		2��YYYY-MM-DD	����2005-01
        ///		3��YYYY/MM/DD	����2005/01
        /// </summary>
        /// <param name="intFormat">�µĸ�ʽ������3�֣��������0,1��2
        ///							������ͬ����������ֵ�Ͳ�ͬ��
        ///							�μ�������µĸ�ʽ
        ///	</param>
        /// <returns>���ص�ǰ�µ��ַ���</returns>
        public static string getCurrMonth_S(int intFormat)
        {
            string strCurrMonth;
            string strYear, strMonth;
            int intYear, intMonth;
            intYear = System.DateTime.Today.Year;
            intMonth = System.DateTime.Today.Month;
            strYear = intYear.ToString().Trim();
            if (intMonth > 9) strMonth = intMonth.ToString().Trim();
            else strMonth = "0" + intMonth.ToString().Trim();
            strCurrMonth = strYear + strMonth;
            switch (intFormat)
            {
                case 0:
                    strCurrMonth = strYear + strMonth;
                    break;
                case 1:
                    strCurrMonth = strYear + "-" + strMonth;
                    break;
                case 2:
                    strCurrMonth = strYear + "/" + strMonth;
                    break;
            }
            return strCurrMonth;
        }
        /// <summary>
        /// �ж��Ƿ�������
        /// </summary>
        /// <param name="strValue">��Ҫ�жϵ��ַ���</param>
        /// <returns>True/False</returns>
        public static bool IsDigit(string strValue)
        {
            int intLen = strValue.Length;
            for (int i = 0; i < intLen; i++)
            {
                if (char.IsDigit(strValue, i) == false)
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// �ж��Ƿ��Ǹ�������ֵ
        /// </summary>
        /// <param name="strValue">��Ҫ�жϵ��ַ���</param>
        /// <returns>True/False</returns>
        public static bool IsFloat(string strValue)
        {
            int intPointNum = 0;
            char[] arrChar = strValue.ToCharArray();
            int intLen = strValue.Length;
            for (int i = 0; i < intLen; i++)
            {
                if (char.IsDigit(strValue, i) == true || arrChar[i] == '.')
                {
                }
                else
                {
                    return false;
                }
                if (arrChar[i] == '.') intPointNum++;
            }
            //����ܹ��м���С���㣬����ж���1��С���㣬�Ͳ���ȷ
            if (intPointNum > 1) return false;
            return true;
        }
        /// <summary>
        /// �ж��Ƿ���������ֵ
        /// </summary>
        /// <param name="strValue">��Ҫ�жϵ��ַ���</param>
        /// <returns>True/False</returns>
        public static bool IsNumeric(string strValue)
        {
            int intLen = strValue.Length;
            for (int i = 0; i < intLen; i++)
            {
                if (char.IsDigit(strValue, i) == false)
                {
                    return false;
                }
            }
            return true;
        }


    }
}
