
//----------------------
//生成代码版本：2015.08.06.1
//生成日期：2015/08/21
//生成者：潘以锋
//工程名称：教务管理系统2
//工程ID：0013
//模块中文名：系统基本参数
//模块英文名：BaseParameter
//注意：1、需要数据底层（PubDataBase.dll）的版本：2015.07.24.1
//       2、需要公共函数层（TzPubFunction.dll）的版本：2015.07.30.1
//========================
using System;
using System.Text;
using System.Collections;

using com.taishsoft.comm_db_obj;
using com.taishsoft.common;

namespace com.taishsoft.datetime
{
    /// <summary>
    /// 日期范围(DateRange)
    /// </summary>
    [Serializable]
    public class clsDateRangeEN : clsEntityBase2
    {
        public const string CurrTabName_S = "DateRange"; //当前表名，与该类相关的表名
        public const string CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称，与该类相关的表中关键字名
        protected const int mintAttributeCount = 4;
        public static string[] AttributeName = new string[] { "mId", "BeginDate", "EndDate", "Memo" };
        //以下是属性变量

        protected long mlngmId;    //流水号
        protected string mstrBeginDate;    //开始日期
        protected string mstrEndDate;    //结束日期
        protected string mstrMemo;    //备注
        protected int mintIntTag;    //整型Tag
        protected string mstrStrTag;    //字符型标签
        protected bool mbolIsCheckProperty;    //是否检查属性


        /// <summary>
        /// 常量："mId"
        /// </summary>
        public const string con_mId = "mId";    //流水号

        /// <summary>
        /// 常量："BeginDate"
        /// </summary>
        public const string con_BeginDate = "BeginDate";    //开始日期

        /// <summary>
        /// 常量："EndDate"
        /// </summary>
        public const string con_EndDate = "EndDate";    //结束日期

        /// <summary>
        /// 常量："Memo"
        /// </summary>
        public const string con_Memo = "Memo";    //备注

        /// <summary>
        /// 常量："IntTag"
        /// </summary>
        public const string con_IntTag = "IntTag";    //整型Tag

        /// <summary>
        /// 常量："StrTag"
        /// </summary>
        public const string con_StrTag = "StrTag";    //字符型标签

        /// <summary>
        /// 常量："IsCheckProperty"
        /// </summary>
        public const string con_IsCheckProperty = "IsCheckProperty";    //是否检查属性

        //用户指定的连接串,如果用户不指定该连接串,就用PUBDATABASE中所指定的连接串
        private static string m_strConnectString;
        /// <summary>
        /// 当前所使用的连接串内容
        /// </summary>
        public static string ConnectString
        {
            get { return m_strConnectString; }
            set { m_strConnectString = value; }
        }

        public clsDateRangeEN()
        {
            SetInit();
            mbolIsCheckProperty = false;
            _CurrTabName = "DateRange";
            lstKeyFldNames.Add("mId");
        }

        public clsDateRangeEN(long lngmId)
        {
            if (lngmId == 0)
            {
                throw new Exception("关键字不能为0！");
            }

            mlngmId = lngmId;
            SetInit();
            mbolIsCheckProperty = false;
            _CurrTabName = "DateRange";
            lstKeyFldNames.Add("mId");
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
                if (strAttributeName == con_mId)
                {
                    return mlngmId;
                }
                else if (strAttributeName == con_BeginDate)
                {
                    return mstrBeginDate;
                }
                else if (strAttributeName == con_EndDate)
                {
                    return mstrEndDate;
                }
                else if (strAttributeName == con_Memo)
                {
                    return mstrMemo;
                }
                return null;
            }
            set
            {
                if (strAttributeName == con_mId)
                {
                    mlngmId = TransNullToInt(value.ToString());
                    AddUpdatedFld(con_mId);
                }
                else if (strAttributeName == con_BeginDate)
                {
                    mstrBeginDate = value.ToString();
                    AddUpdatedFld(con_BeginDate);
                }
                else if (strAttributeName == con_EndDate)
                {
                    mstrEndDate = value.ToString();
                    AddUpdatedFld(con_EndDate);
                }
                else if (strAttributeName == con_Memo)
                {
                    mstrMemo = value.ToString();
                    AddUpdatedFld(con_Memo);
                }
            }
        }
        public object this[int intIndex]
        {
            get
            {
                if (con_mId == AttributeName[intIndex])
                {
                    return mlngmId;
                }
                else if (con_BeginDate == AttributeName[intIndex])
                {
                    return mstrBeginDate;
                }
                else if (con_EndDate == AttributeName[intIndex])
                {
                    return mstrEndDate;
                }
                else if (con_Memo == AttributeName[intIndex])
                {
                    return mstrMemo;
                }
                return null;
            }
            set
            {
                if (con_mId == AttributeName[intIndex])
                {
                    mlngmId = TransNullToInt(value.ToString());
                    AddUpdatedFld(con_mId);
                }
                else if (con_BeginDate == AttributeName[intIndex])
                {
                    mstrBeginDate = value.ToString();
                    AddUpdatedFld(con_BeginDate);
                }
                else if (con_EndDate == AttributeName[intIndex])
                {
                    mstrEndDate = value.ToString();
                    AddUpdatedFld(con_EndDate);
                }
                else if (con_Memo == AttributeName[intIndex])
                {
                    mstrMemo = value.ToString();
                    AddUpdatedFld(con_Memo);
                }
            }
        }

        /// <summary>
        /// 流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
        /// </summary>
        public long mId
        {
            get
            {
                return mlngmId;
            }
            set
            {
                mlngmId = value;
                //记录修改过的字段
                AddUpdatedFld(con_mId);
            }
        }
        /// <summary>
        /// 开始日期(说明:;字段类型:char;字段长度:8;是否可空:True)
        /// </summary>
        public string BeginDate
        {
            get
            {
                return mstrBeginDate;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrBeginDate = value;
                }
                else
                {
                    mstrBeginDate = value;
                }
                //记录修改过的字段
                AddUpdatedFld(con_BeginDate);
            }
        }
        /// <summary>
        /// 结束日期(说明:;字段类型:char;字段长度:8;是否可空:True)
        /// </summary>
        public string EndDate
        {
            get
            {
                return mstrEndDate;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrEndDate = value;
                }
                else
                {
                    mstrEndDate = value;
                }
                //记录修改过的字段
                AddUpdatedFld(con_EndDate);
            }
        }
        /// <summary>
        /// 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
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
                AddUpdatedFld(con_Memo);
            }
        }
        /// <summary>
        /// 整型Tag(说明:;字段类型:int;字段长度:4;是否可空:False)
        /// </summary>
        public int IntTag
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
        /// </summary>
        public string StrTag
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
        /// 是否检查属性(说明:;字段类型:bool;字段长度:1;是否可空:False)
        /// </summary>
        public bool IsCheckProperty
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
    }
}