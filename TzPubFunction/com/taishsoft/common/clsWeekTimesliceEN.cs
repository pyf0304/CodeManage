
//----------------------
//生成代码版本：2015.08.06.1
//生成日期：2015/08/19
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
//using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.common;

namespace com.taishsoft.common
{
    /// <summary>
    /// 周时间段(WeekTimeslice)
    /// </summary>
    [Serializable]
    public class clsWeekTimesliceEN : clsEntityBase2
    {
        public const string CurrTabName_S = "WeekTimeslice"; //当前表名，与该类相关的表名
        public const string CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称，与该类相关的表中关键字名
        protected const int mintAttributeCount = 5;
        public static string[] AttributeName = new string[] { "mId", "WeekDayID", "StartTime", "EndTime", "Memo" };
        //以下是属性变量

        protected long mlngmId;    //流水号
        protected string mstrWeekDayID;    //星期代号
        protected string mstrStartTime;    //开始时间
        protected string mstrEndTime;    //结束时间
        protected string mstrMemo;    //备注
        protected int mintIntTag;    //整型Tag
        protected string mstrStrTag;    //字符型标签
        protected bool mbolIsCheckProperty;    //是否检查属性


        /// <summary>
        /// 常量："mId"
        /// </summary>
        public const string con_mId = "mId";    //流水号

        /// <summary>
        /// 常量："WeekDayID"
        /// </summary>
        public const string con_WeekDayID = "WeekDayID";    //星期代号

        /// <summary>
        /// 常量："StartTime"
        /// </summary>
        public const string con_StartTime = "StartTime";    //开始时间

        /// <summary>
        /// 常量："EndTime"
        /// </summary>
        public const string con_EndTime = "EndTime";    //结束时间

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

        public clsWeekTimesliceEN()
        {
            SetInit();
            mbolIsCheckProperty = false;
            _CurrTabName = "WeekTimeslice";
            lstKeyFldNames.Add("mId");
        }

        public clsWeekTimesliceEN(long lngmId)
        {
            if (lngmId == 0)
            {
                throw new Exception("关键字不能为0！");
            }

            mlngmId = lngmId;
            SetInit();
            mbolIsCheckProperty = false;
            _CurrTabName = "WeekTimeslice";
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
                else if (strAttributeName == con_WeekDayID)
                {
                    return mstrWeekDayID;
                }
                else if (strAttributeName == con_StartTime)
                {
                    return mstrStartTime;
                }
                else if (strAttributeName == con_EndTime)
                {
                    return mstrEndTime;
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
                else if (strAttributeName == con_WeekDayID)
                {
                    mstrWeekDayID = value.ToString();
                    AddUpdatedFld(con_WeekDayID);
                }
                else if (strAttributeName == con_StartTime)
                {
                    mstrStartTime = value.ToString();
                    AddUpdatedFld(con_StartTime);
                }
                else if (strAttributeName == con_EndTime)
                {
                    mstrEndTime = value.ToString();
                    AddUpdatedFld(con_EndTime);
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
                else if (con_WeekDayID == AttributeName[intIndex])
                {
                    return mstrWeekDayID;
                }
                else if (con_StartTime == AttributeName[intIndex])
                {
                    return mstrStartTime;
                }
                else if (con_EndTime == AttributeName[intIndex])
                {
                    return mstrEndTime;
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
                else if (con_WeekDayID == AttributeName[intIndex])
                {
                    mstrWeekDayID = value.ToString();
                    AddUpdatedFld(con_WeekDayID);
                }
                else if (con_StartTime == AttributeName[intIndex])
                {
                    mstrStartTime = value.ToString();
                    AddUpdatedFld(con_StartTime);
                }
                else if (con_EndTime == AttributeName[intIndex])
                {
                    mstrEndTime = value.ToString();
                    AddUpdatedFld(con_EndTime);
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
        /// 星期代号(说明:;字段类型:char;字段长度:1;是否可空:False)
        /// </summary>
        public string WeekDayID
        {
            get
            {
                return mstrWeekDayID;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrWeekDayID = value;
                }
                else
                {
                    mstrWeekDayID = value;
                }
                //记录修改过的字段
                AddUpdatedFld(con_WeekDayID);
            }
        }
        /// <summary>
        /// 开始时间(说明:;字段类型:varchar;字段长度:8;是否可空:True)
        /// </summary>
        public string StartTime
        {
            get
            {
                return mstrStartTime;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrStartTime = value;
                }
                else
                {
                    mstrStartTime = value;
                }
                //记录修改过的字段
                AddUpdatedFld(con_StartTime);
            }
        }
        /// <summary>
        /// 结束时间(说明:;字段类型:varchar;字段长度:8;是否可空:True)
        /// </summary>
        public string EndTime
        {
            get
            {
                return mstrEndTime;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrEndTime = value;
                }
                else
                {
                    mstrEndTime = value;
                }
                //记录修改过的字段
                AddUpdatedFld(con_EndTime);
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