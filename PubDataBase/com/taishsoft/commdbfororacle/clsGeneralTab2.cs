
using System;
using System.Data;
using System.Data.OracleClient;
using System.Text;
using System.Collections;
using com.taishsoft.commdbfororacle;
using com.taishsoft.comm_db_obj;
using System.Collections.Generic;
using com.taishsoft.common;

namespace com.taishsoft.commdbfororacle
{
    /// <summary>
    /// 通用数据表类的基类
    /// </summary>
    [Serializable]
    public class clsGeneralTab2
    {
        /// <summary>
        /// 当前表名，与该类相关的表名
        /// </summary>
        protected string _CurrTabName;    
        
        /// <summary>
        /// 用于记录在修改属性过程中哪些属性被设置过
        /// </summary>
        private List<string> lstUpdatedFldCol = null;//用于记录在修改属性过程中哪些属性被设置过

        //protected string _CurrTabName
        //{
        //    get { return mstrCurrTabName; }
        //    set { mstrCurrTabName = value; }
        //}
        /// <summary>
        /// 当前对象的关键字名集合
        /// </summary>
        protected List<string> lstKeyFldNames;	//当前表的关键字字段的名称

        /// <summary>
        /// 当前类(对象)的表关键字段名
        /// </summary>
        public List<string> TabKeyFldNames
        {
            get
            {
                return lstKeyFldNames;
            }
        }

        //以下是出错信息
        /// <summary>
        /// 错误信息，以数组的形式表示
        /// </summary>
        protected string[] mstrErrMsg_Tz = { "0:正常", "1:院系号为空", "2:专业编号为空", "3:已有相同的编号" };
        
        /// <summary>
        /// 出错信息号码
        /// </summary>
        protected int mintErrNo = 0;   //0:正常,1:房间号为空,2:学号为空
        /// <summary>
        /// 对外显示的错误信息
        /// </summary>
        protected string mstrDispErrMsg;         
        /// <summary>
        /// 模块名
        /// </summary>
        protected string mstrModuleName;
        //		public static string mstrClassName;
        /// <summary>
        /// 是否已经释放对象(用于析构函数)
        /// </summary>
        protected bool mblnDisposed = false;     
        /// <summary>
        /// 错误信息；
        /// </summary>
        protected const string EXCEPTION_MSG = "出错："; //there was an error in the method. please see the Application Log for details.";
        //以下是属性变量
        ///该函数不存在:

        public clsGeneralTab2()
        {
            SetInit();
        }

        /// <summary>
        /// 设置类的有些属性初始值
        /// </summary>
        protected void SetInit()
        {
            _CurrTabName = "Users";    //当前表名，与该类相关的表名
            lstKeyFldNames = new List<string>(); 		//当前表的关键字字段的名称
            lstUpdatedFldCol = new List<string>();
            mstrModuleName = this.GetType().ToString();
            
        }

        /// <summary>
        /// 错误号
        /// </summary>
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
        /// <summary>
        /// 错误信息
        /// </summary>
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
        /// <summary>
        /// 当前类(对象)的表名
        /// </summary>
        public string TabName_Curr
        {
            get
            {
                return _CurrTabName;
            }
        }
        

        private string mstrS_Name;//对象名
        /// <summary>
        /// 对象名
        /// </summary>
        public string S_Name
        {
            get { return mstrS_Name; }
            set { mstrS_Name = value; }
        }
        private string mstrS_ObjectType;//对象类型
        /// <summary>
        /// 对象类型
        /// </summary>
        public string S_ObjectType
        {
            get { return mstrS_ObjectType; }
            set { mstrS_ObjectType = value; }
        }

        ///// <summary>
        ///// 添加记录
        ///// </summary>
        ///// <returns></returns>
        //public virtual bool AddNewRecord()
        //{
        //    return true;
        //}
        ///// <summary>
        ///// 修改记录
        ///// </summary>
        ///// <returns></returns>
        //public virtual bool Update()
        //{
        //    return true;
        //}
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
        ///// <summary>
        ///// 功能：修改多条记录
        ///// </summary>
        ///// <param name="strCondition"></param>
        ///// <returns></returns>
        //public virtual int UpdateMultiRec(string strCondition)
        //{
        //    return 0;
        //}

        ///// <summary>
        ///// 功能：获取当前表的记录数.该表与当前类相关。
        ///// </summary>
        ///// <returns>记录数，为整型</returns>
        //public int funGetRecCount()
        //{
        //    clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
        //    int intRecCount = objSQL.funGetRecCount(_CurrTabName);
        //    return intRecCount;
        //}

        /// <summary>
        /// 功能：获取当前表的记录数.该表与当前类相关。
        /// </summary>
        /// <param name="strTabName">所给定的表名</param>
        /// <returns>记录数，为整型</returns>
        public static int funGetRecCount(string strTabName)
        {
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
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
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
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
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
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
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
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
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
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
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
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
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
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
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
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
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
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
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
            List<string> arrList = objSQL.funGetFldDataOfTable(_CurrTabName, strFldName, strCondition);
            return arrList;
        }

        /// <summary>
        /// 功能：获取当前表中的符合条件的某字段的值，以列表返回
        /// </summary>
        /// <param name="strFldName">字段名</param>
        /// <param name="strCondition">条件串</param>
        /// <returns>获取的字段值列表</returns>
        public List<string> funGetFldValueNoDistinct(string strFldName, string strCondition)
        {
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
            List<string> arrList = objSQL.funGetFldDataOfTableNoDistinct(_CurrTabName, strFldName, strCondition);
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
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
            List<string> arrList = objSQL.funGetFldDataOfTable(strTabName, strFldName, strCondition);
            return arrList;
        }

        /// <summary>
        /// 功能：获取给定表中的符合条件的某字段的值，以列表返回
        /// </summary>
        /// <param name="strTabName">表名</param>
        /// <param name="strFldName">字段名</param>
        /// <param name="strCondition">条件串</param>
        /// <returns>获取的字段值列表</returns>
        public static List<string> funGetFldValueNoDistinct(string strTabName, string strFldName, string strCondition)
        {
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
            List<string> arrList = objSQL.funGetFldDataOfTableNoDistinct(strTabName, strFldName, strCondition);
            return arrList;
        }

        /// <summary>
        /// 功能：获取给定表中的符合条件的某字段的值，以列表返回
        /// </summary>
        /// <param name="strTabName">表名</param>
        /// <param name="strFldName">字段名</param>
        /// <param name="strCondition">条件串</param>
        /// <param name="objSqlConnect">SqlConnect</param>
        /// <param name="objSqlTransaction">OracleTransaction</param>
        /// <returns>获取的字段值列表</returns>
        public static List<string> funGetFldValue(string strTabName, string strFldName, string strCondition, OracleConnection objSqlConnect, OracleTransaction objSqlTransaction)
        {
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
            List<string> arrList = objSQL.funGetFldDataOfTable(strTabName, strFldName, strCondition);
            return arrList;
        }
        ///// <summary>
        ///// 删除记录
        ///// </summary>
        ///// <returns></returns>
        //public virtual bool DelRecord()
        //{
        //    return true;
        //}

        //同时删除多条记录
        ///// <summary>
        ///// 需要在子类中写
        ///// </summary>
        ///// <param name="lstKey"></param>
        ///// <returns></returns>
        //		public static bool DelUsers(ArrayList lstKey)
        //		{
        //			clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
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
        /// <param name="strTabName">表名</param>
        /// <param name="strCondition">需要删除的记录条件</param>
        /// <returns>返回删除的记录0。</returns>
        public static int DelMultiRec(string strTabName, string strCondition)
        {
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
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
        //			clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
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
        //			clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
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
        public List<string> GetPrimaryKeyID(string strCondtion)
        {
            string strSQL;
            System.Data.DataTable objDT;
            List<string> arrList = new List<string>();
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
            int iRow, iCol;
            string strKeyValue;
            string strKeyFldNames = clsArray.GetSqlInStrByArray(lstKeyFldNames, false);
            strSQL = "Select " + strKeyFldNames + " from " + _CurrTabName + " where " + strCondtion;
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

        /// <summary>
        /// 根据SQL语句获取数据表(DataTable)
        /// </summary>
        /// <param name="strSql">提供的SQL语句</param>
        /// <returns>返回的数据表(DataTable)</returns>
        public static System.Data.DataTable GetDataTable(string strSql)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
            objDT = objSQL.GetDataTable(strSql);
            return objDT;
        }

        /// <summary>
        /// 获取DataSet
        /// </summary>
        /// <param name="strSql">用于Select 的SQL语句。</param>
        /// <param name="strTableName">DataSet中的表名。</param>
        /// <returns>返回的DataSet</returns>
        public DataSet GetDataSet(string strSql, string strTableName)
        {
            System.Data.DataSet objDS;
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
            objDS = objSQL.GetDataSet(strSql, strTableName);
            return objDS;
        }

         /// <summary>
        /// 获取DataSet
        /// </summary>
        /// <param name="objTable_SqlCommandText">表名-SQL语句对象</param>
        /// <returns>返回DataSet</returns>
        public DataSet GetDataSet(clsTable_SqlCommandText objTable_SqlCommandText)
        {
            System.Data.DataSet objDS;
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
            objDS = objSQL.GetDataSet(objTable_SqlCommandText);
            return objDS;
        }
                /// <summary>
        /// 获取给定多个表名-SQL语句对象的DataSet
        /// </summary>
        /// <param name="arrTable_SqlCommandTextList">表名-SQL语句对象列表</param>
        /// <returns>返回DataSet</returns>
        public DataSet GetDataSet(ArrayList arrTable_SqlCommandTextList)
        {
            System.Data.DataSet objDS;
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
            objDS = objSQL.GetDataSet(arrTable_SqlCommandTextList);
            return objDS;
        }
        
        /// <summary>
        /// 获取用XML形式表示的DataSet
        /// </summary>
        /// <param name="arrTable_SqlCommandTextList">表名-SQL语句对象列表</param>
        /// <param name="strXmlFileName">Xml文件名</param>
        /// <returns>返回DataSet，用XML形式表示</returns>
        public bool GetDataSetXml(ArrayList arrTable_SqlCommandTextList, string strXmlFileName)
        {
            bool bolResult;
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
            bolResult = objSQL.GetDataSetXml(arrTable_SqlCommandTextList, strXmlFileName);
            return bolResult;
        }
         /// <summary>
        /// 获取DataSet,用XML形式来表示
        /// </summary>
        /// <param name="objTable_SqlCommandText">表名-SQL语句对象</param>
        /// <param name="strXmlFileName">生成的XML文件名</param>
        /// <returns>返回生成XML文件是否成功</returns>
        public bool GetDataSetXml(clsTable_SqlCommandText objTable_SqlCommandText, string strXmlFileName)
        {
            bool bolResult;
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
            bolResult = objSQL.GetDataSetXml(objTable_SqlCommandText, strXmlFileName);
            return bolResult;
 
        }
        ///// <summary>
        ///// 判断是否存在记录
        ///// </summary>
        ///// <returns></returns>
        //public virtual bool IsExist()
        //{
        //    return true;
        //}


        /// <summary>
        /// 功能：判断是否存在某一条件的记录
        /// </summary>
        /// <param name="strTabName">表名</param>
        /// <param name="strCondition">条件串</param>
        /// <returns>如果存在就返回TRUE，否则返回FALSE</returns>
        public static bool IsExistCondRec(string strTabName, string strCondition)
        {
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
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
        /// <param name="strTabName">表名</param>
        /// <param name="strCondition">条件串</param>
        /// <param name="objSqlConnect">SqlConnect</param>
        /// <param name="objSqlTransaction">OracleTransaction</param>
        /// <returns>如果存在就返回TRUE，否则返回FALSE</returns>
        public static bool IsExistCondRec(string strTabName, string strCondition, OracleConnection objSqlConnect, OracleTransaction objSqlTransaction)
        {
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
            if (objSQL.IsExistRecord(strTabName, strCondition, objSqlConnect, objSqlTransaction))
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
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
            if (objSQL.IsExistRecord(_CurrTabName, strCondition))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //public virtual bool CheckProperty(ref string strResult)
        //{
        //    strResult = "在扩展类中没有重新定义函数<CheckProperty>,你可以使用CheckPropertyNew,或者重新定义<CheckProperty>.请与管理员联系!";
        //    return false;
        //}
        ///// <summary>
        ///// 获取满足条件的关键字ID列表
        ///// </summary>
        ///// <param name="strCondtion"></param>
        ///// <returns></returns>
        //public virtual ArrayList GetID(string strCondtion)
        //{
        //    return null;
        //}
        
        /// <summary>
        /// 获取当前表的数据表(DataTable)
        /// </summary>
        /// <param name="strCondtion">条件串</param>
        /// <returns>返回的数据表(DataTable)</returns>
        public DataTable GetTable(string strCondtion)
        {
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
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
        /// <summary>
        /// 获取当前表的数据表(DataTable)
        /// </summary>
        /// <param name="strCondtion">条件串</param>
        /// <returns>返回的数据表(DataTable)</returns>
        public DataTable GetTable(string strCondtion, string strOrderBy)
        {
            string strSQL;
            System.Data.DataTable objDT;
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
            strSQL =string .Format( "Select * from {0} where {1} order by {2}", _CurrTabName , strCondtion, strOrderBy);
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

        /// <summary>
        /// 根据SQL语句获取数据表(DataTable)
        /// </summary>
        /// <param name="strSQL">SQL语句</param>
        /// <returns>返回的数据表(DataTable)</returns>
        public DataTable GetTableBySQL(string strSQL)
        {
            System.Data.DataTable objDT;
            clsSpecSQLforOra objSQL = clsGeneralTab.GetSpecSQLObj_GeneralTab();
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
        /// <summary>
        /// 把可能为null的对象转换为字符串,如果为NULL就返回空串
        /// </summary>
        /// <param name="obj">给出的对象</param>
        /// <returns>返回的字符串</returns>
        protected string TransNullToStr(Object obj)
        {
            if (obj == null) return "";
            if (obj.ToString() == "")
            {
                return "";
            }
            else
            {
                return obj.ToString();
            }
        }
        /// <summary>
        /// 把可能为null的对象转换为字符串,如果为NULL就返回空串
        /// </summary>
        /// <param name="obj">给出的对象</param>
        /// <returns>返回的字符串</returns>
        public static string TransNullToStr_S(Object obj)
        {
            if (obj == null) return "";
            if (obj.ToString() == "")
            {
                return "";
            }
            else
            {
                return obj.ToString();
            }
        }
        /// <summary>
        /// 把可能为null的对象转换为整型,如果为NULL就返回0
        /// </summary>
        /// <param name="obj">给出的对象</param>
        /// <returns>返回的整型值</returns>
        protected int TransNullToInt(Object obj)
        {
            int i = 0;
            if (obj == null) return 0;
            if (obj.ToString() == "") return 0;

            Int32.TryParse(obj.ToString(), out i);
            return i;
        }
        /// <summary>
        /// 把可能为null的对象转换为整型,如果为NULL就返回0
        /// </summary>
        /// <param name="obj">给出的对象</param>
        /// <returns>返回的整型值</returns>
        public static int TransNullToInt_S(Object obj)
        {

            int i = 0;
            if (obj == null) return 0;
            if (obj.ToString() == "") return 0;
            Int32.TryParse(obj.ToString(), out i);
            return i;
        }
        /// <summary>
        /// 把可能为null的对象转换为短整型,如果为NULL就返回0
        /// </summary>
        /// <param name="obj">给出的对象</param>
        /// <returns>返回的短整型值</returns>
        protected short TransNullToShort(Object obj)
        {
            short i = 0;
            if (obj == null) return 0;
            short.TryParse(obj.ToString(), out i);
            return i;
        }
        /// <summary>
        /// 把可能为null的对象转换为短整型,如果为NULL就返回0
        /// </summary>
        /// <param name="obj">给出的对象</param>
        /// <returns>返回的短整型值</returns>
        public static short TransNullToShort_S(Object obj)
        {
            short i = 0;
            if (obj == null) return 0;
            short.TryParse(obj.ToString(), out i);
            return i;
        }
        /// <summary>
        /// 把可能为null的对象转换为日期型,如果为NULL就返回#1/1/1900#(最小的日期)
        /// </summary>
        /// <param name="obj">给出的对象</param>
        /// <returns>返回的日期型值</returns>
        protected DateTime TransNullToDate(Object obj)
        {
            DateTime objDT = System.DateTime.Parse("#1/1/1900#");
            System.DateTime.TryParse(obj.ToString(), out objDT);
            return objDT;
        }
        /// <summary>
        /// 把可能为null的对象转换为日期型,如果为NULL就返回#1/1/1900#(最小的日期)
        /// </summary>
        /// <param name="obj">给出的对象</param>
        /// <returns>返回的日期型值</returns>
        public static DateTime TransNullToDate_S(Object obj)
        {
            DateTime objDT = System.DateTime.Parse("#1/1/1900#");
            if (obj == null) return objDT;
            System.DateTime.TryParse(obj.ToString(), out objDT);
            return objDT;
        }
        /// <summary>
        /// 把可能为null的对象转换为浮点型,如果为NULL就返回0.0f
        /// </summary>
        /// <param name="obj">给出的对象</param>
        /// <returns>返回的浮点型值</returns>
        protected float TransNullToFloat(Object obj)
        {
            float f1 = 0.0f;
            if (obj == null) return f1;
            if (obj.ToString() == "") return f1;
            float.TryParse(obj.ToString(), out f1);
            return f1;
        }
        /// <summary>
        /// 把可能为null的对象转换为浮点型,如果为NULL就返回0.0f
        /// </summary>
        /// <param name="obj">给出的对象</param>
        /// <returns>返回的浮点型值</returns>
        public static float TransNullToFloat_S(Object obj)
        {
            float f1 = 0.0f;
            if (obj == null) return f1;
            if (obj.ToString() == "") return f1;
            float.TryParse(obj.ToString(), out f1);
            return f1;
        }
        /// <summary>
        /// 把可能为null的对象转换为双精浮点型,如果为NULL就返回0.0
        /// </summary>
        /// <param name="obj">给出的对象</param>
        /// <returns>返回的双精浮点型值</returns>
        protected double TransNullToDouble(Object obj)
        {
            double d1 = 0.0;
            if (obj == null) return d1;
            if (obj.ToString() == "") return d1;
            double.TryParse(obj.ToString(), out d1);
            return d1;
        }

        /// <summary>
        /// 把可能为null的对象转换为双精浮点型,如果为NULL就返回0.0
        /// </summary>
        /// <param name="obj">给出的对象</param>
        /// <returns>返回的双精浮点型值</returns>
        public static double TransNullToDouble_S(Object obj)
        {
            double d1 = 0.0;
            if (obj == null) return d1;
            if (obj.ToString() == "") return d1;
            double.TryParse(obj.ToString(), out d1);
            return d1;
        }

        /// <summary>
        /// 把可能为null的对象转换为布尔型,如果为NULL就返回假(false)
        /// </summary>
        /// <param name="obj">给出的对象</param>
        /// <returns>返回的布尔型值</returns>
        protected bool TransNullToBool(Object obj)
        {
            if (obj == null) return false;
            if (obj.ToString() == "")
            {
                return false;
            }
            else
            {
                string strFirstByte = obj.ToString().Substring(0, 1);
                strFirstByte = strFirstByte.ToLower();
                if (strFirstByte == "y" || strFirstByte == "t" || strFirstByte == "1")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        /// <summary>
        /// 把可能为null的对象转换为布尔型,如果为NULL就返回假(false)
        /// </summary>
        /// <param name="obj">给出的对象</param>
        /// <returns>返回的布尔型值</returns>
        public static bool TransNullToBool_S(Object obj)
        {
            if (obj == null) return false;
            if (obj.ToString() == "")
            {
                return false;
            }
            else
            {
                string strFirstByte = obj.ToString().Substring(0, 1);
                strFirstByte = strFirstByte.ToLower();
                if (strFirstByte == "y" || strFirstByte == "t" || strFirstByte == "1")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        /// <summary>
        /// 获取字符串的长度,汉字作为2个字节,英文作为1个字节
        /// </summary>
        /// <param name="strTemp">给出的字符串</param>
        /// <returns>返回字符串的长度</returns>
        public int getStrLen(string strTemp)
        {
            int len;
            byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
            len = sarr.Length;//will output as 3+3*2=9
            return len;
        }
        /// <summary>
        /// 释放对象所占用的内存
        /// </summary>
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
        /// <summary>
        /// 记录日志,把给出的异常错误记录到日志中.
        /// </summary>
        /// <param name="objException">给出的异常错误</param>
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

        /// <summary>
        /// 处理错误日志的函数
        /// </summary>
        /// <param name="objException">异常对象</param>
        /// <param name="strModuleName">模块名称</param>
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
        ///// <summary>
        ///// 处理错误日志的函数
        ///// </summary>
        ///// <param name="objException">异常对象</param>
        ///// <param name="strModuleName">模块名称</param>
        ///// 





        /// <summary>
        /// 处理错误日志的函数
        /// </summary>
        /// <param name="strModuleName">模块名称</param>
        /// <param name="strSource">来源</param>
        /// <param name="strMessage">错误信息</param>
        /// <param name="strStackTrace">跟踪信息</param>
        /// <param name="strTargetSite">目标站点</param>
        public static void LogErrorS2( string strModuleName, string strSource, string strMessage, string strStackTrace, string strTargetSite)
        {
            //Log the error information to the Application Log
            StringBuilder sbLogMsg = new StringBuilder();
            try
            {
                sbLogMsg.Append( "一个错误出现!\r\n");
                sbLogMsg.AppendFormat("模块名：{0}.\r\n", strModuleName);
                sbLogMsg.AppendFormat("来源：{0}.\r\n", strSource);
                sbLogMsg.AppendFormat("错误信息：{0}.\r\n", strMessage);
                sbLogMsg.AppendFormat("跟踪信息：{0}.\r\n", strStackTrace);
                sbLogMsg.AppendFormat("站点：{0}.\r\n", strTargetSite);

                //Write error to event log
                System.Diagnostics.EventLog.WriteEntry(strModuleName, sbLogMsg.ToString(), System.Diagnostics.EventLogEntryType.Error);
            }
            catch
            {
            }
        }

        //静态的处理错误日志的函数

        /// <summary>
        /// 处理应用的日志，记录到应用（Application）的日志中。
        /// </summary>
        /// <param name="strMsg">信息</param>
        /// <param name="strModuleName">模块名称</param>
        public static void LogApplicationS(string strMsg, string strModuleName)
        {
            //Log the error information to the Application Log
            string strLogMsg;
            try
            {
                strLogMsg = "An Log occurred in the following module: "
                    + strModuleName  + "Message: " + strMsg;

                //Write error to event log
                System.Diagnostics.EventLog.WriteEntry(strModuleName, strLogMsg, System.Diagnostics.EventLogEntryType.Information);
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
        public static string getTodayStr_S(int intFormat)
        {
            string strToday;
            string strYear, strMonth, strDay, strWeek;
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
            strWeek = TransWeekFromEngToChs(System.DateTime.Today.DayOfWeek.ToString());

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
                case 3:
                    strToday = strYear + "年" + strMonth + "月" + strDay + "日";
                    break;
                case 4:
                    strToday = strYear + "年" + strMonth + "月" + strDay + "日 " + strWeek;
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
        public static string GetCurrMonth_S(int intFormat)
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
        /// 把英文的星期转换为中文的星期
        /// </summary>
        /// <param name="strEngWeek">英文周的名称</param>
        /// <returns>周的中文名称</returns>
        private static string TransWeekFromEngToChs(string strEngWeek)
        {
            if (strEngWeek == "Friday") return "星期五";
            else if (strEngWeek == "Monday") return "星期一";
            else if (strEngWeek == "Saturday") return "星期六";
            else if (strEngWeek == "Sunday") return "星期日";
            else if (strEngWeek == "Thursday") return "星期四";
            else if (strEngWeek == "Tuesday") return "星期二";
            else if (strEngWeek == "Wednesday") return "星期三";
            else return "星期数据非法!";
        }
        /// <summary>
        /// 获取给定表的给定字段的最大值(字符串)
        /// </summary>
        /// <param name="strTabName">给定表</param>
        /// <param name="strFldName">给定字段</param>
        /// <param name="intFldLen">字段长度</param>
        /// <param name="strPrefix">前缀</param>
        /// <returns>返回的字符串最大值</returns>
        public static string GetMaxStrId(string strTabName, string strFldName, int intFldLen, string strPrefix)
        {
            clsSpecSQLforOra mySql = clsGeneralTab.GetSpecSQLObj_GeneralTab();
            string strMaxValue = mySql.GetMaxStrId(strTabName, strFldName, intFldLen, strPrefix);
            return strMaxValue;
        }
        /// <summary>
        /// 获取给定表的给定字段的最大值(字符串)
        /// </summary>
        /// <param name="strTabName">给定表</param>
        /// <param name="strFldName">给定字段</param>
        /// <param name="intFldLen">字段长度</param>
        /// <param name="strPrefix">前缀</param>
        /// <param name="intAdditionValue">附加的值,即在获取的最大值基础上再加上附加值</param>
        /// <returns>返回的最大值字符串</returns>
        public static string GetMaxStrId(string strTabName, string strFldName, int intFldLen, string strPrefix, int intAdditionValue)
        {
            clsSpecSQLforOra mySql = clsGeneralTab.GetSpecSQLObj_GeneralTab();
            string strMaxValue = mySql.GetMaxStrId(strTabName, strFldName, intFldLen, strPrefix, intAdditionValue);
            return strMaxValue;
        }

        /// <summary>
        /// 判断是否是浮点型数值
        /// </summary>
        /// <param name="strValue">需要判断的字符串</param>
        /// <returns>True/False</returns>
        public static bool IsFloat(string strValue)
        {
            int intPointNum = 0;
            //用于处理负数的情况
            if (strValue.Substring(0, 1) == "-") strValue = strValue.Substring(1);
            if (strValue.Substring(0, 1) == "+") strValue = strValue.Substring(1);

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
            if (intLen == 0) return false;
            //用于处理负数的情况
            if (strValue.Substring(0, 1) == "-") strValue = strValue.Substring(1);
            if (strValue.Substring(0, 1) == "+") strValue = strValue.Substring(1);
            intLen = strValue.Length;
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
        /// 判断是否是整型数值
        /// </summary>
        /// <param name="strValue">需要判断的字符串</param>
        /// <returns>True/False</returns>
        public static bool IsShortNumeric(string strValue)
        {
            int intLen = strValue.Length;
            int i;
            for (i = 0; i < intLen; i++)
            {
                if (char.IsDigit(strValue, i) == false)
                {
                    return false;
                }
            }
            if (i > 4)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// 添加已经修改的字段
        /// </summary>
        /// <param name="strFldName">字段名</param>
        protected void AddUpdatedFld(string strFldName)
        {
            if (lstUpdatedFldCol.Contains(strFldName) == false)
            {
                lstUpdatedFldCol.Add(strFldName);
            }
        }

        /// <summary>
        /// 检查字段是否修改过。
        /// </summary>
        /// <param name="strFldName">字段名</param>
        /// <returns>返回 true:修改过；false:未修改</returns>
        public bool IsUpdated(string strFldName)
        {
            if (lstUpdatedFldCol.Contains(strFldName) == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// 清除修改状态,即清空存储脏字段信息的lstUpdatedFldCol集合.
        /// </summary>
        public void ClearUpdateState()
        {
            lstUpdatedFldCol.Clear();
        }

    }
}
