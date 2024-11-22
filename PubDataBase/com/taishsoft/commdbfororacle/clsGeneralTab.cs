
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
        protected string _CurrTabName;    //当前表名，与该类相关的表名
        protected string KeyFldName;	//当前表的关键字字段的名称

        //以下是出错信息
        protected string[] mstrErrMsg = { "0:正常", "1:院系号为空", "2:专业编号为空", "3:已有相同的编号" };
        //以下是出错信息号码
        protected int mintErrNo = 0;   //0:正常,1:房间号为空,2:学号为空
        protected string mstrDispErrMsg;         //对外显示的错误信息
        protected string mstrModuleName;
        //		public static string mstrClassName;
        protected bool mblnDisposed = false;     //是否已经释放对象(用于析构函数)
        protected const string EXCEPTION_MSG = " there was an error in the method. please see the Application Log for details.";
        //以下是属性变量
        ///该函数不存在:
        protected string m_sSID;
        protected string m_sServer_Tz;
        protected string m_sUid;
        protected string m_sPassword_Tz;
        protected string p_sConnectString;
        protected bool mbolIsHaveSpecialConnectString;	//是否有特殊的连接串

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
            //by davidfujian (李顺道)
            //2004-2-28 Night
            //获得连接字符串
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
        /// 获取SQL对象
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
        /// 设置类的有些属性初始值
        /// </summary>
        protected void SetInit()
        {
            _CurrTabName = "Users";    //当前表名，与该类相关的表名
            KeyFldName = "UserId";		//当前表的关键字字段的名称
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

        public string DispErrMsg       //对外显示的错误信息
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
        /// 功能：修改多条记录
        /// </summary>
        /// <param name="strCondition"></param>
        /// <returns></returns>
        public virtual int UpdateMultiRec(string strCondition)
        {
            return 0;
        }

        /// <summary>
        /// 功能：获取当前表的记录数.该表与当前类相关。
        /// </summary>
        /// <returns>记录数，为整型</returns>
        public int funGetRecCount()
        {
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
            int intRecCount = objSQL.funGetRecCount(_CurrTabName);
            return intRecCount;
        }

        /// <summary>
        /// 功能：获取当前表的记录数.该表与当前类相关。
        /// </summary>
        /// <param name="strTabName">所给定的表名</param>
        /// <returns>记录数，为整型</returns>
        public static int funGetRecCount(string strTabName)
        {
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
            int intRecCount = objSQL.funGetRecCount(strTabName);
            return intRecCount;
        }


        /// <summary>
        /// 功能：获取当前表中满足条件的记录数
        /// </summary>
        /// <param name="strCondtion">所给定的记录条件</param>
        /// <returns>记录数，为整型</returns>
        public int funGetRecCountByCond(string strCondtion)
        {
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
            int intRecCount = objSQL.funGetRecCount(_CurrTabName, strCondtion);
            return intRecCount;
        }

        /// <summary>
        /// 功能：获取给定表中满足条件的记录数
        /// </summary>
        /// <param name="strTabName">所给定的表名</param>
        /// <param name="strCondtion">所给定的记录条件</param>
        /// <returns>记录数，为整型</returns>
        public static int funGetRecCountByCond(string strTabName, string strCondtion)
        {
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
            int intRecCount = objSQL.funGetRecCount(strTabName, strCondtion);
            return intRecCount;
        }


        /// <summary>
        /// 功能：设置当前表中的符合条件的某字段的值
        /// </summary>
        /// <param name="strFldName">字段名</param>
        /// <param name="strValue">值</param>
        /// <param name="strCondition">条件串</param>
        /// <returns>影响的记录数</returns>
        public int funSetFldValue(string strFldName, string strValue, string strCondition)
        {
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
            int intRecCount = objSQL.funSetFldDataOfTable(_CurrTabName, strFldName, strValue, strCondition);
            return intRecCount;
        }


        /// <summary>
        /// 功能：设置当前表中的符合条件的某字段的值
        /// </summary>
        /// <param name="strFldName">字段名</param>
        /// <param name="fltValue">值</param>
        /// <param name="strCondition">条件串</param>
        /// <returns>影响的记录数</returns>
        public int funSetFldValue(string strFldName, float fltValue, string strCondition)
        {
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
            int intRecCount = objSQL.funSetFldDataOfTable(_CurrTabName, strFldName, fltValue, strCondition);
            return intRecCount;
        }

        /// <summary>
        /// 功能：设置当前表中的符合条件的某字段的值
        /// </summary>
        /// <param name="strFldName">字段名</param>
        /// <param name="intValue">值</param>
        /// <param name="strCondition">条件串</param>
        /// <returns>影响的记录数</returns>
        public int funSetFldValue(string strFldName, int intValue, string strCondition)
        {
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
            int intRecCount = objSQL.funSetFldDataOfTable(_CurrTabName, strFldName, intValue, strCondition);
            return intRecCount;
        }

        /// <summary>
        /// 功能：设置给定表中的符合条件的某字段的值
        /// </summary>
        /// <param name="strTabName">表名</param>
        /// <param name="strFldName">字段名</param>
        /// <param name="strValue">值</param>
        /// <param name="strCondition">条件串</param>
        /// <returns>影响的记录数</returns>
        public static int funSetFldValue(string strTabName, string strFldName, string strValue, string strCondition)
        {
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
            int intRecCount = objSQL.funSetFldDataOfTable(strTabName, strFldName, strValue, strCondition);
            return intRecCount;
        }

        /// <summary>
        /// 功能：设置给定表中的符合条件的某字段的值
        /// </summary>
        /// <param name="strTabName">表名</param>
        /// <param name="strFldName">字段名</param>
        /// <param name="intValue">值</param>
        /// <param name="strCondition">条件串</param>
        /// <returns>影响的记录数</returns>
        public static int funSetFldValue(string strTabName, string strFldName, int intValue, string strCondition)
        {
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
            int intRecCount = objSQL.funSetFldDataOfTable(strTabName, strFldName, intValue, strCondition);
            return intRecCount;
        }

        /// <summary>
        /// 功能：设置给定表中的符合条件的某字段的值
        /// </summary>
        /// <param name="strTabName">表名</param>
        /// <param name="strFldName">字段名</param>
        /// <param name="fltValue">值</param>
        /// <param name="strCondition">条件串</param>
        /// <returns>影响的记录数</returns>
        public static int funSetFldValue(string strTabName, string strFldName, float fltValue, string strCondition)
        {
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
            int intRecCount = objSQL.funSetFldDataOfTable(strTabName, strFldName, fltValue, strCondition);
            return intRecCount;
        }


        /// <summary>
        /// 功能：获取当前表中的符合条件的某字段的值，以列表返回
        /// </summary>
        /// <param name="strFldName">字段名</param>
        /// <param name="strCondition">条件串</param>
        /// <returns>获取的字段值列表</returns>
        public List<string> funGetFldValue(string strFldName, string strCondition)
        {
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
            List<string> arrList = objSQL.funGetFldDataOfTable(_CurrTabName, strFldName, strCondition);
            return arrList;
        }


        /// <summary>
        /// 功能：获取给定表中的符合条件的某字段的值，以列表返回
        /// </summary>
        /// <param name="strTabName">表名</param>
        /// <param name="strFldName">字段名</param>
        /// <param name="strCondition">条件串</param>
        /// <returns>获取的字段值列表</returns>
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

        ////同时删除多条记录
        ///// <summary>
        ///// 需要在子类中写
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
        //			//删除Users本表中与当前对象有关的记录
        //			strSQL = strSQL + "Delete from " + currTabname + " where " + KeyFldName + " in (" + strKeyList + ")";
        //			return objSQL.ExecSql(strSQL);
        //		}






        /// <summary>
        /// 功能：删除多条记录，带条件的删除
        /// </summary>
        /// <param name="strCondition">需要删除的记录条件</param>
        /// <returns>返回删除的记录0。</returns>
        public static int DelMultiRec(string strTabName, string strCondition)
        {
            clsSpecSQLforOra objSQL = new clsSpecSQLforOra();
            string strSQL;
            if (strCondition == "")
            {
                return 0;	//表示删除0条记录，实际上是不能该表的所有记录
            }
            else
            {
                strSQL = "Delete from " + strTabName + " where " + strCondition;
            }
            int intRecoCount = objSQL.ExecSql2(strSQL);
            return intRecoCount;
        }


        ///// <summary>
        ///// 在子类中重写
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
        /// 功能：获取某一条件的关键字列表
        ///		  如果表关键字是多个，则多个关键字之间用"//"隔开
        /// </summary>
        /// <param name="strCondtion">条件串</param>
        /// <returns>关键字列表</returns>
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
        /// 功能：判断是否存在某一条件的记录
        /// </summary>
        /// <param name="strCondition">条件串</param>
        /// <returns>如果存在就返回TRUE，否则返回FALSE</returns>
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
        /// 功能：判断是否存在某一条件的记录
        /// </summary>
        /// <param name="strCondition">条件串</param>
        /// <returns>如果存在就返回TRUE，否则返回FALSE</returns>
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
        /// <summary>
        /// 功能：获取当前日期的字符串
        /// 日期格式：
        ///    日期的字符串的格式有三种：
        ///		1、YYYYMMDD。	例如20050120
        ///		2、YYYY-MM-DD	例如2005-01-20
        ///		3、YYYY/MM/DD	例如2005/01/20
        /// </summary>
        /// <param name="intFormat">日期格式，共有3种，传入参数0,1，2
        ///							参数不同，函数返回值就不同，
        ///							参见上面的日期格式
        ///	</param>
        /// <returns>返回当前日期的字符串</returns>
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
        /// 功能：获取当前月的字符串
        /// 月的格式：
        ///    月的字符串的格式有三种：
        ///		1、YYYYMM。	例如200501
        ///		2、YYYY-MM-DD	例如2005-01
        ///		3、YYYY/MM/DD	例如2005/01
        /// </summary>
        /// <param name="intFormat">月的格式，共有3种，传入参数0,1，2
        ///							参数不同，函数返回值就不同，
        ///							参见上面的月的格式
        ///	</param>
        /// <returns>返回当前月的字符串</returns>
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
        /// 功能：获取当前日期的字符串
        /// 日期格式：
        ///    日期的字符串的格式有三种：
        ///		1、YYYYMMDD。	例如20050120
        ///		2、YYYY-MM-DD	例如2005-01-20
        ///		3、YYYY/MM/DD	例如2005/01/20
        /// </summary>
        /// <param name="intFormat">日期格式，共有3种，传入参数0,1，2
        ///							参数不同，函数返回值就不同，
        ///							参见上面的日期格式
        ///	</param>
        /// <returns>返回当前日期的字符串</returns>
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
        /// 功能：获取当前月的字符串
        /// 月的格式：
        ///    月的字符串的格式有三种：
        ///		1、YYYYMM。	例如200501
        ///		2、YYYY-MM-DD	例如2005-01
        ///		3、YYYY/MM/DD	例如2005/01
        /// </summary>
        /// <param name="intFormat">月的格式，共有3种，传入参数0,1，2
        ///							参数不同，函数返回值就不同，
        ///							参见上面的月的格式
        ///	</param>
        /// <returns>返回当前月的字符串</returns>
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
        /// 判断是否是数字
        /// </summary>
        /// <param name="strValue">需要判断的字符串</param>
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
        /// 判断是否是浮点型数值
        /// </summary>
        /// <param name="strValue">需要判断的字符串</param>
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
            //检查总共有几个小数点，如果有多于1个小数点，就不正确
            if (intPointNum > 1) return false;
            return true;
        }
        /// <summary>
        /// 判断是否是整型数值
        /// </summary>
        /// <param name="strValue">需要判断的字符串</param>
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
