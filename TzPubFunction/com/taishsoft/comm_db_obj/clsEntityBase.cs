
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections;

using com.taishsoft.comm_db_obj;

namespace com.taishsoft.comm_db_obj
{
    [Serializable]
    public class clsEntityBase
    {
        /// <summary>
        /// 当前表名，与该类相关的表名
        /// </summary>
        protected string _CurrTabName;    
        /// <summary>
        /// 用于记录在修改属性过程中哪些属性被设置过
        /// </summary>
        public Hashtable htProperty = null;//用于记录在修改属性过程中哪些属性被设置过

        //protected string _CurrTabName
        //{
        //    get { return mstrCurrTabName; }
        //    set { mstrCurrTabName = value; }
        //}

        /// <summary>
        /// 当前表的关键字字段的名称
        /// </summary>
        protected string KeyFldName;    

    
        /// <summary>
        /// 以下是出错信息
        /// </summary>
        protected string[] mstrErrMsg_Tz = { "0:正常", "1:院系号为空", "2:专业编号为空", "3:已有相同的编号" };
       
        /// <summary>
        /// 以下是出错信息号码
        /// </summary>
        protected int mintErrNo = 0;   //0:正常,1:房间号为空,2:学号为空
        /// <summary>
        /// 
        /// </summary>
        protected string mstrDispErrMsg;         //对外显示的错误信息
        /// <summary>
        /// 
        /// </summary>
        protected string mstrModuleName;
        //		public static string mstrClassName;
        /// <summary>
        /// 是否已经释放对象(用于析构函数)
        /// </summary>
        protected bool mblnDisposed = false;     //是否已经释放对象(用于析构函数)
        /// <summary>
        /// 
        /// </summary>
        protected const string EXCEPTION_MSG = "出错："; //there was an error in the method. please see the Application Log for details.";
        //以下是属性变量
        ///该函数不存在:

        public clsEntityBase()
        {
            SetInit();
        }

        /// <summary>
        /// 设置类的有些属性初始值
        /// </summary>
        protected void SetInit()
        {
            _CurrTabName = "Users";    //当前表名，与该类相关的表名
            KeyFldName = "UserId";		//当前表的关键字字段的名称
            mstrModuleName = this.GetType().ToString();
            htProperty = new Hashtable();
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
        /// <summary>
        /// 当前类(对象)的表关键字段名
        /// </summary>
        public string TabKeyFldName
        {
            get
            {
                return KeyFldName;
            }
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
                float f1 =  0.0f;
                if (obj == null) return f1;
                float.TryParse( obj.ToString(), out f1);
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
        /// 处理错误日志的函数
        /// </summary>
        /// <param name="objException">异常对象</param>
        /// <param name="strModuleName">模块名称</param>
        public static void LogErrorS(Exception objException, string strModuleName)
        {           
            string strLogMsg;
            try
            {
                strLogMsg = "有一个错误发生在下面的模块中: "
                    + strModuleName + "消息源: " + objException.Source
                    + "水牛: " + objException.Message
                    + "跟踪:  " + objException.StackTrace
                    + "目录站点:  " + objException.TargetSite.ToString();

                //Write error to event log
                System.Diagnostics.EventLog.WriteEntry(strModuleName, strLogMsg, System.Diagnostics.EventLogEntryType.Error);
            }
            catch
            {
            }
        }

        /// <summary>
        /// 处理错误日志的函数
        /// </summary>
        /// <param name="strModuleName">模块名称</param>
        /// <param name="strSource">来源</param>
        /// <param name="strMessage">错误信息</param>
        /// <param name="strStackTrace">跟踪信息</param>
        /// <param name="strTargetSite">目标站点</param>
        public static void LogErrorS2(string strModuleName, string strSource, string strMessage, string strStackTrace, string strTargetSite)
        {
            //Log the error information to the Application Log
            StringBuilder sbLogMsg = new StringBuilder();
            try
            {
                sbLogMsg.Append("一个错误出现!\r\n");
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

    }
}
