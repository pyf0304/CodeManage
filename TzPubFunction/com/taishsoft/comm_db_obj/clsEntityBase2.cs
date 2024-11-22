
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections;
using com.taishsoft.comm_db_obj;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace com.taishsoft.comm_db_obj
{
    /// <summary>
    /// 实体对象的基类2
    /// </summary>
    [Serializable]
    [DataContractAttribute]
    public class clsEntityBase2
    {
        /// <summary>
        /// 当前表名，与该类相关的表名
        /// </summary>
        protected string _CurrTabName;
        /// <summary>
        /// 用于记录在修改属性过程中哪些属性被设置过
        /// </summary>
        private List<string> lstUpdatedFldCol = null;//用于记录在修改属性过程中哪些属性被设置过
        /// <summary>
        /// 对象中与条件相关的字段比较运算符
        /// </summary>
        public Dictionary<string, string> dicFldComparisonOp;

        /// <summary>
        /// 对象中与条件相关的字段比较运算符
        /// </summary>
        [DataMember]//非常重要
        public string sfFldComparisonOp
        {
            get
            {
                return mstrsfFldComparisonOp;
            }
            set
            {
                if (value == "")
                {
                    mstrsfFldComparisonOp = value;
                }
                else
                {
                    mstrsfFldComparisonOp = value;
                }
            }
        }
        //protected string _CurrTabName
        //{
        //    get { return mstrCurrTabName; }
        //    set { mstrCurrTabName = value; }
        //}
        /// <summary>
        /// 当前对象的关键字名集合
        /// </summary>
        protected List<string> lstKeyFldNames;  //当前表的关键字字段的名称

        /// <summary>
        /// 出错信息
        /// </summary>
        protected string[] mstrErrMsg_Tz = { "0:正常", "1:院系号为空", "2:专业编号为空", "3:已有相同的编号" };
        /// <summary>
        /// 表的关键字
        /// </summary>
        public virtual string _KeyId
        {
            get;
        }

        /// <summary>
        /// 表的名称字段值
        /// </summary>
        public virtual string _NameValue
        {
            get;
        }
        [DataMember]//非常重要
        private string mstrsfUpdFldSetStr = "";    //系统字段_修改字段集合串
        [DataMember]//非常重要
        private string mstrsfFldComparisonOp = "";    //系统字段_修改字段集合串

        /// <summary>
        /// 系统字段_修改字段集合串      
        /// </summary>
        [DataMember]//非常重要
        public string sfUpdFldSetStr
        {
            get
            {
                return mstrsfUpdFldSetStr;
            }
            set
            {
                if (value == "")
                {
                    mstrsfUpdFldSetStr = value;
                }
                else
                {
                    mstrsfUpdFldSetStr = value;
                }
            }
        }

        /// <summary>
        /// 错误信息号 0:正常,1:房间号为空,2:学号为空
        /// </summary>
        protected int mintErrNo = 0;   //

        /// <summary>
        /// 当前模块名，即当前类名
        /// </summary>
        public string _ModuleName { get; set; }
        //		public static string mstrClassName;
        /// <summary>
        /// 是否已经释放对象(用于析构函数)
        /// </summary>
        protected bool mblnDisposed = false;
        /// <summary>
        /// 异常信息
        /// </summary>
        protected const string EXCEPTION_MSG = "出错："; //there was an error in the method. please see the Application Log for details.";

        /// <summary>
        /// 整型Tag
        /// </summary>
        protected int mintIntTag;    //整型Tag
        /// <summary>
        /// 字符型标签
        /// </summary>
        protected string mstrStrTag;    //字符型标签
        /// <summary>
        /// 是否检查属性
        /// </summary>
        protected bool mbolIsCheckProperty;    //是否检查属性

        /// <summary>
        /// 常量:"IntTag"
        /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        public const string con_IntTag = "_IntTag";    //整型Tag

        /// <summary>
        /// 常量:"StrTag"
        /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        public const string con_StrTag = "_StrTag";    //字符型标签

        /// <summary>
        /// 常量:"IsCheckProperty"
        /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        public const string con_IsCheckProperty = "IsCheckProperty";    //是否检查属性

        ////用户指定的连接串,如果用户不指定该连接串,就用PUBDATABASE中所指定的连接串
        private static string m_strConnectStringB;
        /// <summary>
        /// 当前所使用的连接串内容
        /// (AGC_CSV7.BusinessLogicEx.AutoGCPubFuncV6:GenConnectString)
        /// </summary>
        public static string _ConnectStringB
        {
            get { return m_strConnectStringB; }
            set { m_strConnectStringB = value; }
        }
        ///// <summary>
        ///// 业务逻辑层的公共函数载体对象
        ///// </summary>
        //public clsCommFun4BL objCommFun4BL;

        /// <summary>
        /// 整型Tag(说明:;字段类型:int;字段长度:4;是否可空:False)
        /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
        /// </summary>
        public int _IntTag
        {
            get
            {
                return mintIntTag;
            }
            set
            {
                mintIntTag = value;
                //记录修改过的字段
                AddUpdatedFld(con_IntTag);
            }
        }
        /// <summary>
        /// 字符型标签(说明:;字段类型:string;字段长度:1000;是否可空:False)
        /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
        /// </summary>
        public string _StrTag
        {
            get
            {
                return mstrStrTag;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrStrTag = value;
                }
                else
                {
                    mstrStrTag = value;
                }
                //记录修改过的字段
                AddUpdatedFld(con_StrTag);
            }
        }
        /// <summary>
        /// 用于复选框的是否选择
        /// </summary>
        public string _Checked { get; set; }
        /// <summary>
        /// 是否检查属性(说明:;字段类型:bool;字段长度:1;是否可空:False)
        /// (AGC_CSV7.BusinessLogicEx.clsPrjTabFldBLEx:ToString2)
        /// </summary>
        public bool _IsCheckProperty
        {
            get
            {
                return mbolIsCheckProperty;
            }
            set
            {
                mbolIsCheckProperty = value;
                //记录修改过的字段
                AddUpdatedFld(con_IsCheckProperty);
            }
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        public clsEntityBase2()
        {
            SetInit();
            mbolIsCheckProperty = false;

        }

        /// <summary>
        /// 给类的有些通用属性进行初始值
        /// </summary>
        protected void SetInit()
        {
            _CurrTabName = "Users";    //当前表名，与该类相关的表名
            //lstKeyFldNames.Add("UserId");		//当前表的关键字字段的名称
            lstKeyFldNames = new List<string>();
            _ModuleName = this.GetType().ToString();
            lstUpdatedFldCol = new List<string>();
            dicFldComparisonOp = new Dictionary<string, string>();
        }

        /// <summary>
        /// 错误号
        /// </summary>
        public int _ErrNo
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
        /// 对外显示的错误信息
        /// </summary>
        public string _DispErrMsg { get; set; }
        /// <summary>
        /// 当前类(对象)的表名
        /// </summary>
        public string _TabName_Curr
        {
            get
            {
                return _CurrTabName;
            }
        }
        /// <summary>
        /// 当前类(对象)的表关键字段名
        /// </summary>
        public List<string> _TabKeyFldNames
        {
            get
            {
                return lstKeyFldNames;
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
            float f1 = 0.0f;
            if (obj == null) return f1;
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
        /// 添加已经修改的字段
        /// </summary>
        /// <param name="strFldName">字段名</param>
        protected void AddUpdatedFld(string strFldName)
        {
            if (lstUpdatedFldCol == null) lstUpdatedFldCol = new List<string>();
            if (lstUpdatedFldCol.Contains(strFldName) == false)
            {
                lstUpdatedFldCol.Add(strFldName);
            }
        }
        /// <summary>
        /// 获取修改字段的合并串，以“|”分隔
        /// </summary>
        /// <returns></returns>
        public string getsfUpdFldSetStr()
        {
            StringBuilder sbsfUpdFldSetStr = new StringBuilder();
            foreach (string strFldName in lstUpdatedFldCol)
            {
                sbsfUpdFldSetStr.AppendFormat("{0}|", strFldName);
            }
            return sbsfUpdFldSetStr.ToString();
        }

      

        /// <summary>
        /// 清除字段的修改标志
        /// </summary>
        /// <returns></returns>
        public bool ClearFldUpdateFlag()
        {
            this.lstUpdatedFldCol = null;
            return true;
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strAttributeName"></param>
        /// <returns></returns>
        public virtual object this[string strAttributeName]
        {
            get
            {
                return null;
            }
            set
            { }
        }
        /// <summary>
        /// 为条件设置相关字段值，为自动处理获取条件串做准备
        /// </summary>
        /// <param name = "strFldName">字段名</param>
        /// <param name = "strFldValue">字段值</param>
        /// <param name = "strComparisonOp">比较运算符</param>
        public void SetCondFldValue(string strFldName, string strFldValue, string strComparisonOp)
        {
            this[strFldName] = strFldValue;
            if (dicFldComparisonOp.ContainsKey(strFldName) == false)
            {
                dicFldComparisonOp.Add(strFldName, strComparisonOp);
            }
            else
            {
                dicFldComparisonOp[strFldName] = strComparisonOp;
            }
        }

    }
}
