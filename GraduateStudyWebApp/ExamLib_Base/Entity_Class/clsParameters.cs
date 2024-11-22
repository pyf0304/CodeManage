///----------------------
///生成代码版本：2010.05.04.1
///生成日期：2010/05/17
///生成者：潘以锋
///注意：1、需要数据底层（PubDataBase.dll）的版本：2010.05.04.1
///       2、需要公共函数层（TzPubFunction.dll）的版本：2010.05.04.1
///========================
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections;
using com.taishsoft.comm_db_obj;

namespace Questionnaire.Entity
{
    /// <summary>
    /// 参数(Parameters)
    /// </summary>
    [Serializable]
    public class clsParameters : clsEntityBase2
    {
        public const string CurrTabName_S = "Parameters"; //当前表名，与该类相关的表名
        public const string CurrTabKeyFldName_S = "Mid"; //当前表中的关键字名称，与该类相关的表中关键字名
        protected const int mintAttributeCount = 5;
        public static string[] AttributeName = new string[] { "Mid", "FunctionName", "intValue", "Memo", "strValue" };
        //以下是属性变量


        /// <summary> 
        /// Mid
        /// </summary>
        protected long mlngMid;

        /// <summary> 
        /// FunctionName
        /// </summary>
        protected string mstrFunctionName;

        /// <summary> 
        /// intValue
        /// </summary>
        protected long mlngintValue;

        /// <summary> 
        /// 备注
        /// </summary>
        protected string mstrMemo;

        /// <summary> 
        /// strValue
        /// </summary>
        protected string mstrstrValue;

        //用户指定的连接串,如果用户不指定该连接串,就用PUBDATABASE中所指定的连接串
        private static string m_strConnectString;
        public static string ConnectString
        {
            get { return m_strConnectString; }
            set { m_strConnectString = value; }
        }

        public clsParameters()
        {
            SetInit();
            CurrTabName = "Parameters";
            lstKeyFldNames.Add("Mid");
        }

        public clsParameters(long lngMid)
        {

            mlngMid = lngMid;
            SetInit();
            CurrTabName = "Parameters";
            lstKeyFldNames.Add("Mid");
        }

        public static int AttributeCount
        {
            get
            {
                return mintAttributeCount;
            }
        }
        public object this[string strAttributeName]
        {
            get
            {
                if (strAttributeName == "Mid")
                {
                    return mlngMid;
                }
                else if (strAttributeName == "FunctionName")
                {
                    return mstrFunctionName;
                }
                else if (strAttributeName == "intValue")
                {
                    return mlngintValue;
                }
                else if (strAttributeName == "Memo")
                {
                    return mstrMemo;
                }
                else if (strAttributeName == "strValue")
                {
                    return mstrstrValue;
                }
                return null;
            }
            set
            {
                if (strAttributeName == "Mid")
                {
                    mlngMid = TransNullToInt(value.ToString());
                }
                else if (strAttributeName == "FunctionName")
                {
                    mstrFunctionName = value.ToString();
                }
                else if (strAttributeName == "intValue")
                {
                    mlngintValue = TransNullToInt(value.ToString());
                }
                else if (strAttributeName == "Memo")
                {
                    mstrMemo = value.ToString();
                }
                else if (strAttributeName == "strValue")
                {
                    mstrstrValue = value.ToString();
                }
            }
        }
        public object this[int intIndex]
        {
            get
            {
                if ("Mid" == AttributeName[intIndex])
                {
                    return mlngMid;
                }
                else if ("FunctionName" == AttributeName[intIndex])
                {
                    return mstrFunctionName;
                }
                else if ("intValue" == AttributeName[intIndex])
                {
                    return mlngintValue;
                }
                else if ("Memo" == AttributeName[intIndex])
                {
                    return mstrMemo;
                }
                else if ("strValue" == AttributeName[intIndex])
                {
                    return mstrstrValue;
                }
                return null;
            }
            set
            {
                if ("Mid" == AttributeName[intIndex])
                {
                    mlngMid = TransNullToInt(value.ToString());
                }
                else if ("FunctionName" == AttributeName[intIndex])
                {
                    mstrFunctionName = value.ToString();
                }
                else if ("intValue" == AttributeName[intIndex])
                {
                    mlngintValue = TransNullToInt(value.ToString());
                }
                else if ("Memo" == AttributeName[intIndex])
                {
                    mstrMemo = value.ToString();
                }
                else if ("strValue" == AttributeName[intIndex])
                {
                    mstrstrValue = value.ToString();
                }
            }
        }

        /// <summary>
        /// Mid
        /// </summary>
        public long Mid
        {
            get
            {
                return mlngMid;
            }
            set
            {
                mlngMid = value;
                //记录修改过的字段
                AddUpdatedFld("Mid");
            }
        }
        /// <summary>
        /// FunctionName
        /// </summary>
        public string FunctionName
        {
            get
            {
                return mstrFunctionName;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrFunctionName = value;
                }
                else
                {
                    mstrFunctionName = value;
                }
                //记录修改过的字段
                AddUpdatedFld("FunctionName");
            }
        }
        /// <summary>
        /// intValue
        /// </summary>
        public long intValue
        {
            get
            {
                return mlngintValue;
            }
            set
            {
                mlngintValue = value;
                //记录修改过的字段
                AddUpdatedFld("intValue");
            }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string Memo
        {
            get
            {
                return mstrMemo;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrMemo = value;
                }
                else
                {
                    mstrMemo = value;
                }
                //记录修改过的字段
                AddUpdatedFld("Memo");
            }
        }
        /// <summary>
        /// strValue
        /// </summary>
        public string strValue
        {
            get
            {
                return mstrstrValue;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrstrValue = value;
                }
                else
                {
                    mstrstrValue = value;
                }
                //记录修改过的字段
                AddUpdatedFld("strValue");
            }
        }
    }
}