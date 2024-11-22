using com.taishsoft.comm_db_obj;
using com.taishsoft.commdb;
using com.taishsoft.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace com.taishsoft.commdb
{
    /// <summary>
    /// 数据处理层公共基类，包括：一些公共函数
    /// </summary>
    public abstract class clsCommBase4DA2
    {
        /// <summary>
        /// 当前表名
        /// </summary>
        public virtual string _CurrTabName_S
        {
            get
            {
                return "";
            }
        }
        //public virtual string ModuleName_S
        //{
        //    get
        //    {
        //        return "";
        //    }
        //}
        
        /// <summary>
        /// 获取SQL服务器连接对象
        /// (AutoGCLib.AutoGC6Cs_M:Gen_GetSpecSQLObj)
        /// </summary>
        /// <returns>SQL服务器连接对象</returns>
        public virtual clsSpecSQLforSql GetSpecSQLObj_Obj()
        {
            return new clsSpecSQLforSql();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="objClassRoomEN"></param>
        /// <returns></returns>
        public abstract bool AddNewRecordBySQL(clsEntityBase2 objClassRoomEN);
        
        /// <summary>
        /// 功能:获取当前表中的符合条件的某字段的值,以列表返回
        /// (AutoGCLib.AutoGCPubFuncV6:GenfunGetFldValue)
        /// </summary>
        /// <param name = "strFldName">字段名</param>
        /// <param name = "strCondition">条件串</param>
        /// <returns>获取的字段值列表</returns>
        public List<string> GetFldValue(string strFldName, string strCondition)
        {
            if (string.IsNullOrEmpty(_CurrTabName_S) == true)
            {
                string strMsg = string.Format("没有覆盖父类中的_CurrTabName_S，请检查！({0})", clsStackTrace.GetCurrClassFunctionByLevel(2));
                throw new Exception(strMsg);
            }
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = GetSpecSQLObj_Obj();
            
            List<string> arrList = objSQL.GetFldDataOfTable(_CurrTabName_S, strFldName, strCondition);
            return arrList;
        }



        /// <summary>
        /// 功能:获取当前表中的符合条件的某字段的值,以列表返回
        /// (AutoGCLib.AutoGCPubFuncV6:GenfunGetFldValueNoDistinct)
        /// </summary>
        /// <param name = "strFldName">字段名</param>
        /// <param name = "strCondition">条件串</param>
        /// <returns>获取的字段值列表</returns>
        public List<string> GetFldValueNoDistinct(string strFldName, string strCondition)
        {
            if (string.IsNullOrEmpty(_CurrTabName_S) == true)
            {
                string strMsg = string.Format("没有覆盖父类中的_CurrTabName_S，请检查！({0})", clsStackTrace.GetCurrClassFunctionByLevel(2));
                throw new Exception(strMsg);
            }

            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = GetSpecSQLObj_Obj();

            List<string> arrList = objSQL.GetFldDataOfTableNoDistinct(_CurrTabName_S, strFldName, strCondition);
            return arrList;
        }



        /// <summary>
        /// 功能:设置当前表中的符合条件的某字段的值
        /// (AutoGCLib.AutoGCPubFuncV6:GenfunSetFldValue)
        /// </summary>
        /// <param name = "strFldName">字段名</param>
        /// <param name = "varValue">值</param>
        /// <param name = "strCondition">条件串</param>
        /// <returns>影响的记录数</returns>
        public int SetFldValue<T>(string strFldName, T varValue, string strCondition)
        {
            if (string.IsNullOrEmpty(_CurrTabName_S) == true)
            {
                string strMsg = string.Format("没有覆盖父类中的_CurrTabName_S，请检查！({0})", clsStackTrace.GetCurrClassFunctionByLevel(2));
                throw new Exception(strMsg);
            }
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = GetSpecSQLObj_Obj();
            int intRecCount = objSQL.SetFldDataOfTable(_CurrTabName_S, strFldName, varValue, strCondition);
            return intRecCount;
        }



      
        #region 处理属性值null的转换

        /// <summary>
        /// 把Null数据转换成String型,如果给定的对象不是Null,就直接返回。
        /// (AutoGCLib.AutoGCPubFuncV6:GenTransNullToStr)
        /// </summary>
        /// <param name = "obj">给定的对象</param>
        /// <returns>返回String型数据</returns>
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
        /// 把Null数据转换成Int型,如果给定的对象不是Null,就直接返回。
        /// (AutoGCLib.AutoGCPubFuncV6:GenTransNullToInt)
        /// </summary>
        /// <param name = "obj">给定的对象</param>
        /// <returns>返回Int型数据</returns>
        protected int TransNullToInt(Object obj)
        {
            if (obj == null) return 0;
            if (obj.ToString() == "")
            {
                return 0;
            }
            else
            {
                return Int32.Parse(obj.ToString());
            }
        }

        /// <summary>
        /// 把Null数据转换成short型,如果给定的对象不是Null,就直接返回。
        /// (AutoGCLib.AutoGCPubFuncV6:GenTransNullToShort)
        /// </summary>
        /// <param name = "obj">给定的对象</param>
        /// <returns>返回short型数据</returns>
        protected short TransNullToShort(Object obj)
        {
            if (obj == null) return 0;
            if (obj.ToString() == "")
            {
                return 0;
            }
            else
            {
                return short.Parse(obj.ToString());
            }
        }

        /// <summary>
        /// 把Null数据转换成Long型,如果给定的对象不是Null,就直接返回。
        /// (AutoGCLib.AutoGCPubFuncV6:GenTransNullToLong)
        /// </summary>
        /// <param name = "obj">给定的对象</param>
        /// <returns>返回Long型数据</returns>
        protected long TransNullToLong(Object obj)
        {
            if (obj == null) return 0;
            if (obj.ToString() == "")
            {
                return 0;
            }
            else
            {
                return Int64.Parse(obj.ToString());
            }
        }

        /// <summary>
        /// 把Null数据转换成DateTime型,如果给定的对象不是Null,就直接返回。
        /// (AutoGCLib.AutoGCPubFuncV6:GenTransNullToDate)
        /// </summary>
        /// <param name = "obj">给定的对象</param>
        /// <returns>返回DateTime型数据</returns>
        protected DateTime TransNullToDate(Object obj)
        {
            if (obj == null) return DateTime.Parse("#1/1/1900#");
            if (obj.ToString() == "")
            {
                return DateTime.Parse("#1/1/1900#");
            }
            else
            {
                return DateTime.Parse(obj.ToString());
            }
        }

        /// <summary>
        /// 把Null数据转换成Float型,如果给定的对象不是Null,就直接返回。
        /// (AutoGCLib.AutoGCPubFuncV6:GenTransNullToFloat)
        /// </summary>
        /// <param name = "obj">给定的对象</param>
        /// <returns>返回Float型数据</returns>
        protected float TransNullToFloat(Object obj)
        {
            float f1 = 0.0f;
            if (obj == null) return f1;
            if (obj.ToString() == "")
            {
                return 0.0f;
            }
            else
            {
                return float.Parse(obj.ToString());
            }
        }


        /// <summary>
        /// 把Null数据转换成Double型,如果给定的对象不是Null,就直接返回。
        /// (AutoGCLib.AutoGCPubFuncV6:GenTransNullToDouble)
        /// </summary>
        /// <param name = "obj">给定的对象</param>
        /// <returns>返回Double型数据</returns>
        protected double TransNullToDouble(Object obj)
        {
            double d1 = 0.0;
            if (obj == null) return d1;
            if (obj.ToString() == "")
            {
                return 0.0;
            }
            else
            {
                return double.Parse(obj.ToString());
            }
        }


        /// <summary>
        /// 把Null数据转换成布尔型,如果给定的对象不是Null,就直接返回。
        /// (AutoGCLib.AutoGCPubFuncV6:GenTransNullToBool)
        /// </summary>
        /// <param name = "obj">给定的对象</param>
        /// <returns>返回布尔型数据</returns>
        protected bool TransNullToBool(Object obj)
        {
            if (obj == null) return false;
            if (obj.ToString() == "")
            {
                return false;
            }
            else
            {
                return bool.Parse(obj.ToString());
            }
        }


        #endregion 处理属性值null的转换

       

        ////用户指定的连接串,如果用户不指定该连接串,就用PUBDATABASE中所指定的连接串
        //private static string m_strC1onnectString;
        ///// <summary>
        ///// 当前所使用的连接串内容
        ///// (AutoGCLib.AutoGCPubFuncV6:GenConnectString)
        ///// </summary>
        //public static string _C1onnectString
        //{
        //    get { return m_strConnectString; }
        //    set { m_strConnectString = value; }
        //}

        /// <summary>
        /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
        /// (AutoGCLib.AutoGCPubFuncV6:GengetStrLen)
        /// </summary>
        /// <param name = "strTemp">给定的原字符串</param>
        /// <returns>返回字符串长度</returns>
        public static int getStrLen(string strTemp)
        {
            int len;
            byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
            len = sarr.Length;//will output as 3+3*2 = 9
            return len;
        }
        #region 日志

        /// <summary>
        /// 把给定的异常对象存储到日志中去(含模块名)
        /// (AutoGCLib.AutoGCPubFuncV6:GenLogError_S)
        /// </summary>
        /// <param name = "objException">给定的异常对象</param>
        /// <param name = "strModuleName">模块名称</param>
        protected static void LogErrorS(Exception objException, string strModuleName)
        {
            //Log the error information to the Application Log
            string strLogMsg;
            try
            {

                strLogMsg = "An error occurred in the following module: "
               + strModuleName + "Source: " + objException.Source

               + "Message: " + objException.Message
               + "Stack Trace: " + objException.StackTrace

               + "Target Site: " + objException.TargetSite.ToString();

                //Write error to event log
                System.Diagnostics.EventLog.WriteEntry(strModuleName, strLogMsg, System.Diagnostics.EventLogEntryType.Error);
            }
            catch
            {
            }
        }

        /// <summary>
        /// 把给定的异常对象存储到日志中去
        /// (AutoGCLib.AutoGCPubFuncV6:GenLogError)
        /// </summary>
        /// <param name = "objException">给定的异常对象</param>
        protected void LogError(Exception objException)
        {
            //Log the error information to the Application Log
            string strLogMsg;
            string strModuleName = clsStackTrace.GetCurrClassFunctionByLevel(2);
            try
            {

                strLogMsg = "An error occurred in the following module: "
               + strModuleName + "Source: " + objException.Source

               + "Message: " + objException.Message
               + "Stack Trace: " + objException.StackTrace

               + "Target Site: " + objException.TargetSite.ToString();

                //Write error to event log
                System.Diagnostics.EventLog.WriteEntry(strModuleName, strLogMsg, System.Diagnostics.EventLogEntryType.Error);
            }
            catch
            {
            }
        }
        #endregion 日志

        /// <summary>
        /// 检查是否存在给定表
        /// (AutoGCLib.AutoGCPubFuncV6:GenIsExistTable)
        /// </summary>
        /// <param name = "strTabName">给定表</param>
        /// <returns>存在就返回True,否则返回FalseD</returns>
        public bool IsExistTable(string strTabName)
        {
            clsSpecSQLforSql objSQL = null;
            //获取连接对象
            objSQL = GetSpecSQLObj_Obj();
            bool bolIsExist = objSQL.IsExistTable(strTabName);
            return bolIsExist;
        }
    }
}