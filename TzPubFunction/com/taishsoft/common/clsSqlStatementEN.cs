
//----------------------
//生成代码版本：2014.10.06.1
//生成日期：2014/10/25
//生成者：潘以锋
//工程名称：AGC_CSV7
//工程ID：0005
//模块中文名：Sql视图管理
//模块英文名：SqlViewMan
//注意：1、需要数据底层（PubDataBase.dll）的版本：2014.10.06.1
//       2、需要公共函数层（TzPubFunction.dll）的版本：2014.10.06.1
//========================
using System;
using System.Text;
using System.Collections;
using com.taishsoft.comm_db_obj;

namespace com.taishsoft.common
{
    /// <summary>
    /// Sql语句(SqlStatement)
    /// </summary>
    [Serializable]
    public class SqlStatement : clsEntityBase2
    {
        public const string CurrTabKeyFldName_S = "SqlStatementId"; //当前表中的关键字名称，与该类相关的表中关键字名
        protected const int mintAttributeCount = 22;
        public static string[] AttributeName = new string[] { "SqlStatementId", "OperateType", "TabName", "SelectText", "FromText", "WhereCondition", "GROUPBY", "HavingStr", "OrderBy", "IntoText", "ValuesText", "UpdateText", "SetText", "DeleteText", "OrderNum4Refer", "SqlStatementText", "ErrMsg", "CreateDate", "AnalysisDate", "UpdDate", "UpdUserId", "Memo" };
        //以下是属性变量

        protected string mstrSqlStatementId;    //Sql语句Id
        protected string mstrOperateType;    //操作类型
        protected string mstrTabName;    //表名
        protected string mstrSelectText;    //Select文本内容
        protected string mstrFromText;    //From文本内容
        protected string mstrWhereCondition;    //条件串
        protected string mstrGROUPBY;    //分组
        protected string mstrHavingStr;    //分组过滤
        protected string mstrOrderBy;    //排序
        protected string mstrIntoText;    //Into文本
        protected string mstrValuesText;    //Values文本
        protected string mstrUpdateText;    //Update文本
        protected string mstrSetText;    //Set文本
        protected string mstrDeleteText;    //Delete文本
        protected int mintOrderNum4Refer;    //引用序号
        protected string mstrSqlStatementText;    //Sql语句文本内容
        protected string mstrErrMsg;    //错误信息
        protected string mstrCreateDate;    //建立日期
        protected string mstrAnalysisDate;    //分析日期
        protected string mstrUpdDate;    //修改日期
        protected string mstrUpdUserId;    //修改用户Id
        protected string mstrMemo;    //说明


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

        public SqlStatement()
        {
            SetInit();
            mbolIsCheckProperty = false;
            _CurrTabName = "SqlStatement";
            lstKeyFldNames.Add("SqlStatementId");
        }

        public SqlStatement(string strSqlStatementId)
        {
            if (string.IsNullOrEmpty(strSqlStatementId) == true)
            {
                throw new Exception("在表：SqlStatement中，关键字不能为空 或 null！");
            }

            mstrSqlStatementId = strSqlStatementId;
            SetInit();
            mbolIsCheckProperty = false;
            _CurrTabName = "SqlStatement";
            lstKeyFldNames.Add("SqlStatementId");
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
                if (strAttributeName == "SqlStatementId")
                {
                    return mstrSqlStatementId;
                }
                else if (strAttributeName == "OperateType")
                {
                    return mstrOperateType;
                }
                else if (strAttributeName == "TabName")
                {
                    return mstrTabName;
                }
                else if (strAttributeName == "SelectText")
                {
                    return mstrSelectText;
                }
                else if (strAttributeName == "FromText")
                {
                    return mstrFromText;
                }
                else if (strAttributeName == "WhereCondition")
                {
                    return mstrWhereCondition;
                }
                else if (strAttributeName == "GROUPBY")
                {
                    return mstrGROUPBY;
                }
                else if (strAttributeName == "HavingStr")
                {
                    return mstrHavingStr;
                }
                else if (strAttributeName == "OrderBy")
                {
                    return mstrOrderBy;
                }
                else if (strAttributeName == "IntoText")
                {
                    return mstrIntoText;
                }
                else if (strAttributeName == "ValuesText")
                {
                    return mstrValuesText;
                }
                else if (strAttributeName == "UpdateText")
                {
                    return mstrUpdateText;
                }
                else if (strAttributeName == "SetText")
                {
                    return mstrSetText;
                }
                else if (strAttributeName == "DeleteText")
                {
                    return mstrDeleteText;
                }
                else if (strAttributeName == "OrderNum4Refer")
                {
                    return mintOrderNum4Refer;
                }
                else if (strAttributeName == "SqlStatementText")
                {
                    return mstrSqlStatementText;
                }
                else if (strAttributeName == "ErrMsg")
                {
                    return mstrErrMsg;
                }
                else if (strAttributeName == "CreateDate")
                {
                    return mstrCreateDate;
                }
                else if (strAttributeName == "AnalysisDate")
                {
                    return mstrAnalysisDate;
                }
                else if (strAttributeName == "UpdDate")
                {
                    return mstrUpdDate;
                }
                else if (strAttributeName == "UpdUserId")
                {
                    return mstrUpdUserId;
                }
                else if (strAttributeName == "Memo")
                {
                    return mstrMemo;
                }
                return null;
            }
            set
            {
                if (strAttributeName == "SqlStatementId")
                {
                    mstrSqlStatementId = value.ToString();
                    AddUpdatedFld("SqlStatementId");
                }
                else if (strAttributeName == "OperateType")
                {
                    mstrOperateType = value.ToString();
                    AddUpdatedFld("OperateType");
                }
                else if (strAttributeName == "TabName")
                {
                    mstrTabName = value.ToString();
                    AddUpdatedFld("TabName");
                }
                else if (strAttributeName == "SelectText")
                {
                    mstrSelectText = value.ToString();
                    AddUpdatedFld("SelectText");
                }
                else if (strAttributeName == "FromText")
                {
                    mstrFromText = value.ToString();
                    AddUpdatedFld("FromText");
                }
                else if (strAttributeName == "WhereCondition")
                {
                    mstrWhereCondition = value.ToString();
                    AddUpdatedFld("WhereCondition");
                }
                else if (strAttributeName == "GROUPBY")
                {
                    mstrGROUPBY = value.ToString();
                    AddUpdatedFld("GROUPBY");
                }
                else if (strAttributeName == "HavingStr")
                {
                    mstrHavingStr = value.ToString();
                    AddUpdatedFld("HavingStr");
                }
                else if (strAttributeName == "OrderBy")
                {
                    mstrOrderBy = value.ToString();
                    AddUpdatedFld("OrderBy");
                }
                else if (strAttributeName == "IntoText")
                {
                    mstrIntoText = value.ToString();
                    AddUpdatedFld("IntoText");
                }
                else if (strAttributeName == "ValuesText")
                {
                    mstrValuesText = value.ToString();
                    AddUpdatedFld("ValuesText");
                }
                else if (strAttributeName == "UpdateText")
                {
                    mstrUpdateText = value.ToString();
                    AddUpdatedFld("UpdateText");
                }
                else if (strAttributeName == "SetText")
                {
                    mstrSetText = value.ToString();
                    AddUpdatedFld("SetText");
                }
                else if (strAttributeName == "DeleteText")
                {
                    mstrDeleteText = value.ToString();
                    AddUpdatedFld("DeleteText");
                }
                else if (strAttributeName == "OrderNum4Refer")
                {
                    mintOrderNum4Refer = TransNullToInt(value.ToString());
                    AddUpdatedFld("OrderNum4Refer");
                }
                else if (strAttributeName == "SqlStatementText")
                {
                    mstrSqlStatementText = value.ToString();
                    AddUpdatedFld("SqlStatementText");
                }
                else if (strAttributeName == "ErrMsg")
                {
                    mstrErrMsg = value.ToString();
                    AddUpdatedFld("ErrMsg");
                }
                else if (strAttributeName == "CreateDate")
                {
                    mstrCreateDate = value.ToString();
                    AddUpdatedFld("CreateDate");
                }
                else if (strAttributeName == "AnalysisDate")
                {
                    mstrAnalysisDate = value.ToString();
                    AddUpdatedFld("AnalysisDate");
                }
                else if (strAttributeName == "UpdDate")
                {
                    mstrUpdDate = value.ToString();
                    AddUpdatedFld("UpdDate");
                }
                else if (strAttributeName == "UpdUserId")
                {
                    mstrUpdUserId = value.ToString();
                    AddUpdatedFld("UpdUserId");
                }
                else if (strAttributeName == "Memo")
                {
                    mstrMemo = value.ToString();
                    AddUpdatedFld("Memo");
                }
            }
        }
        public object this[int intIndex]
        {
            get
            {
                if ("SqlStatementId" == AttributeName[intIndex])
                {
                    return mstrSqlStatementId;
                }
                else if ("OperateType" == AttributeName[intIndex])
                {
                    return mstrOperateType;
                }
                else if ("TabName" == AttributeName[intIndex])
                {
                    return mstrTabName;
                }
                else if ("SelectText" == AttributeName[intIndex])
                {
                    return mstrSelectText;
                }
                else if ("FromText" == AttributeName[intIndex])
                {
                    return mstrFromText;
                }
                else if ("WhereCondition" == AttributeName[intIndex])
                {
                    return mstrWhereCondition;
                }
                else if ("GROUPBY" == AttributeName[intIndex])
                {
                    return mstrGROUPBY;
                }
                else if ("HavingStr" == AttributeName[intIndex])
                {
                    return mstrHavingStr;
                }
                else if ("OrderBy" == AttributeName[intIndex])
                {
                    return mstrOrderBy;
                }
                else if ("IntoText" == AttributeName[intIndex])
                {
                    return mstrIntoText;
                }
                else if ("ValuesText" == AttributeName[intIndex])
                {
                    return mstrValuesText;
                }
                else if ("UpdateText" == AttributeName[intIndex])
                {
                    return mstrUpdateText;
                }
                else if ("SetText" == AttributeName[intIndex])
                {
                    return mstrSetText;
                }
                else if ("DeleteText" == AttributeName[intIndex])
                {
                    return mstrDeleteText;
                }
                else if ("OrderNum4Refer" == AttributeName[intIndex])
                {
                    return mintOrderNum4Refer;
                }
                else if ("SqlStatementText" == AttributeName[intIndex])
                {
                    return mstrSqlStatementText;
                }
                else if ("ErrMsg" == AttributeName[intIndex])
                {
                    return mstrErrMsg;
                }
                else if ("CreateDate" == AttributeName[intIndex])
                {
                    return mstrCreateDate;
                }
                else if ("AnalysisDate" == AttributeName[intIndex])
                {
                    return mstrAnalysisDate;
                }
                else if ("UpdDate" == AttributeName[intIndex])
                {
                    return mstrUpdDate;
                }
                else if ("UpdUserId" == AttributeName[intIndex])
                {
                    return mstrUpdUserId;
                }
                else if ("Memo" == AttributeName[intIndex])
                {
                    return mstrMemo;
                }
                return null;
            }
            set
            {
                if ("SqlStatementId" == AttributeName[intIndex])
                {
                    mstrSqlStatementId = value.ToString();
                    AddUpdatedFld("SqlStatementId");
                }
                else if ("OperateType" == AttributeName[intIndex])
                {
                    mstrOperateType = value.ToString();
                    AddUpdatedFld("OperateType");
                }
                else if ("TabName" == AttributeName[intIndex])
                {
                    mstrTabName = value.ToString();
                    AddUpdatedFld("TabName");
                }
                else if ("SelectText" == AttributeName[intIndex])
                {
                    mstrSelectText = value.ToString();
                    AddUpdatedFld("SelectText");
                }
                else if ("FromText" == AttributeName[intIndex])
                {
                    mstrFromText = value.ToString();
                    AddUpdatedFld("FromText");
                }
                else if ("WhereCondition" == AttributeName[intIndex])
                {
                    mstrWhereCondition = value.ToString();
                    AddUpdatedFld("WhereCondition");
                }
                else if ("GROUPBY" == AttributeName[intIndex])
                {
                    mstrGROUPBY = value.ToString();
                    AddUpdatedFld("GROUPBY");
                }
                else if ("HavingStr" == AttributeName[intIndex])
                {
                    mstrHavingStr = value.ToString();
                    AddUpdatedFld("HavingStr");
                }
                else if ("OrderBy" == AttributeName[intIndex])
                {
                    mstrOrderBy = value.ToString();
                    AddUpdatedFld("OrderBy");
                }
                else if ("IntoText" == AttributeName[intIndex])
                {
                    mstrIntoText = value.ToString();
                    AddUpdatedFld("IntoText");
                }
                else if ("ValuesText" == AttributeName[intIndex])
                {
                    mstrValuesText = value.ToString();
                    AddUpdatedFld("ValuesText");
                }
                else if ("UpdateText" == AttributeName[intIndex])
                {
                    mstrUpdateText = value.ToString();
                    AddUpdatedFld("UpdateText");
                }
                else if ("SetText" == AttributeName[intIndex])
                {
                    mstrSetText = value.ToString();
                    AddUpdatedFld("SetText");
                }
                else if ("DeleteText" == AttributeName[intIndex])
                {
                    mstrDeleteText = value.ToString();
                    AddUpdatedFld("DeleteText");
                }
                else if ("OrderNum4Refer" == AttributeName[intIndex])
                {
                    mintOrderNum4Refer = TransNullToInt(value.ToString());
                    AddUpdatedFld("OrderNum4Refer");
                }
                else if ("SqlStatementText" == AttributeName[intIndex])
                {
                    mstrSqlStatementText = value.ToString();
                    AddUpdatedFld("SqlStatementText");
                }
                else if ("ErrMsg" == AttributeName[intIndex])
                {
                    mstrErrMsg = value.ToString();
                    AddUpdatedFld("ErrMsg");
                }
                else if ("CreateDate" == AttributeName[intIndex])
                {
                    mstrCreateDate = value.ToString();
                    AddUpdatedFld("CreateDate");
                }
                else if ("AnalysisDate" == AttributeName[intIndex])
                {
                    mstrAnalysisDate = value.ToString();
                    AddUpdatedFld("AnalysisDate");
                }
                else if ("UpdDate" == AttributeName[intIndex])
                {
                    mstrUpdDate = value.ToString();
                    AddUpdatedFld("UpdDate");
                }
                else if ("UpdUserId" == AttributeName[intIndex])
                {
                    mstrUpdUserId = value.ToString();
                    AddUpdatedFld("UpdUserId");
                }
                else if ("Memo" == AttributeName[intIndex])
                {
                    mstrMemo = value.ToString();
                    AddUpdatedFld("Memo");
                }
            }
        }

        /// <summary>
        /// Sql语句Id(说明:;字段类型:char;字段长度:8;是否可空:False)
        /// </summary>
        public string SqlStatementId
        {
            get
            {
                return mstrSqlStatementId;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrSqlStatementId = value;
                }
                else
                {
                    mstrSqlStatementId = value;
                }
                //记录修改过的字段
                AddUpdatedFld("SqlStatementId");
            }
        }
        /// <summary>
        /// 操作类型(说明:;字段类型:varchar;字段长度:30;是否可空:False)
        /// </summary>
        public string OperateType
        {
            get
            {
                return mstrOperateType;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrOperateType = value;
                }
                else
                {
                    mstrOperateType = value;
                }
                //记录修改过的字段
                AddUpdatedFld("OperateType");
            }
        }
        /// <summary>
        /// 表名(说明:;字段类型:varchar;字段长度:100;是否可空:False)
        /// </summary>
        public string TabName
        {
            get
            {
                return mstrTabName;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrTabName = value;
                }
                else
                {
                    mstrTabName = value;
                }
                //记录修改过的字段
                AddUpdatedFld("TabName");
            }
        }
        /// <summary>
        /// Select文本内容(说明:;字段类型:varchar;字段长度:8000;是否可空:False)
        /// </summary>
        public string SelectText
        {
            get
            {
                return mstrSelectText;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrSelectText = value;
                }
                else
                {
                    mstrSelectText = value;
                }
                //记录修改过的字段
                AddUpdatedFld("SelectText");
            }
        }
        /// <summary>
        /// From文本内容(说明:;字段类型:varchar;字段长度:8000;是否可空:False)
        /// </summary>
        public string FromText
        {
            get
            {
                return mstrFromText;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrFromText = value;
                }
                else
                {
                    mstrFromText = value;
                }
                //记录修改过的字段
                AddUpdatedFld("FromText");
            }
        }
        /// <summary>
        /// 条件串(说明:;字段类型:varchar;字段长度:500;是否可空:True)
        /// </summary>
        public string WhereCondition
        {
            get
            {
                return mstrWhereCondition;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrWhereCondition = value;
                }
                else
                {
                    mstrWhereCondition = value;
                }
                //记录修改过的字段
                AddUpdatedFld("WhereCondition");
            }
        }
        /// <summary>
        /// 分组(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
        /// </summary>
        public string GROUPBY
        {
            get
            {
                return mstrGROUPBY;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrGROUPBY = value;
                }
                else
                {
                    mstrGROUPBY = value;
                }
                //记录修改过的字段
                AddUpdatedFld("GROUPBY");
            }
        }
        /// <summary>
        /// 分组过滤(说明:;字段类型:varchar;字段长度:200;是否可空:True)
        /// </summary>
        public string HavingStr
        {
            get
            {
                return mstrHavingStr;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrHavingStr = value;
                }
                else
                {
                    mstrHavingStr = value;
                }
                //记录修改过的字段
                AddUpdatedFld("HavingStr");
            }
        }
        /// <summary>
        /// 排序(说明:;字段类型:varchar;字段长度:100;是否可空:True)
        /// </summary>
        public string OrderBy
        {
            get
            {
                return mstrOrderBy;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrOrderBy = value;
                }
                else
                {
                    mstrOrderBy = value;
                }
                //记录修改过的字段
                AddUpdatedFld("OrderBy");
            }
        }
        /// <summary>
        /// Into文本(说明:;字段类型:varchar;字段长度:300;是否可空:True)
        /// </summary>
        public string IntoText
        {
            get
            {
                return mstrIntoText;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrIntoText = value;
                }
                else
                {
                    mstrIntoText = value;
                }
                //记录修改过的字段
                AddUpdatedFld("IntoText");
            }
        }
        /// <summary>
        /// Values文本(说明:;字段类型:varchar;字段长度:300;是否可空:True)
        /// </summary>
        public string ValuesText
        {
            get
            {
                return mstrValuesText;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrValuesText = value;
                }
                else
                {
                    mstrValuesText = value;
                }
                //记录修改过的字段
                AddUpdatedFld("ValuesText");
            }
        }
        /// <summary>
        /// Update文本(说明:;字段类型:varchar;字段长度:300;是否可空:True)
        /// </summary>
        public string UpdateText
        {
            get
            {
                return mstrUpdateText;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrUpdateText = value;
                }
                else
                {
                    mstrUpdateText = value;
                }
                //记录修改过的字段
                AddUpdatedFld("UpdateText");
            }
        }
        /// <summary>
        /// Set文本(说明:;字段类型:varchar;字段长度:300;是否可空:True)
        /// </summary>
        public string SetText
        {
            get
            {
                return mstrSetText;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrSetText = value;
                }
                else
                {
                    mstrSetText = value;
                }
                //记录修改过的字段
                AddUpdatedFld("SetText");
            }
        }
        /// <summary>
        /// Delete文本(说明:;字段类型:varchar;字段长度:300;是否可空:True)
        /// </summary>
        public string DeleteText
        {
            get
            {
                return mstrDeleteText;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrDeleteText = value;
                }
                else
                {
                    mstrDeleteText = value;
                }
                //记录修改过的字段
                AddUpdatedFld("DeleteText");
            }
        }
        /// <summary>
        /// 引用序号(说明:;字段类型:int;字段长度:4;是否可空:True)
        /// </summary>
        public int OrderNum4Refer
        {
            get
            {
                return mintOrderNum4Refer;
            }
            set
            {
                mintOrderNum4Refer = value;
                //记录修改过的字段
                AddUpdatedFld("OrderNum4Refer");
            }
        }
        /// <summary>
        /// Sql语句文本内容(说明:;字段类型:varchar;字段长度:8000;是否可空:False)
        /// </summary>
        public string SqlStatementText
        {
            get
            {
                return mstrSqlStatementText;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrSqlStatementText = value;
                }
                else
                {
                    mstrSqlStatementText = value;
                }
                //记录修改过的字段
                AddUpdatedFld("SqlStatementText");
            }
        }
        /// <summary>
        /// 错误信息(说明:;字段类型:varchar;字段长度:4000;是否可空:True)
        /// </summary>
        public string ErrMsg
        {
            get
            {
                return mstrErrMsg;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrErrMsg = value;
                }
                else
                {
                    mstrErrMsg = value;
                }
                //记录修改过的字段
                AddUpdatedFld("ErrMsg");
            }
        }
        /// <summary>
        /// 建立日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
        /// </summary>
        public string CreateDate
        {
            get
            {
                return mstrCreateDate;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrCreateDate = value;
                }
                else
                {
                    mstrCreateDate = value;
                }
                //记录修改过的字段
                AddUpdatedFld("CreateDate");
            }
        }
        /// <summary>
        /// 分析日期(说明:;字段类型:varchar;字段长度:14;是否可空:True)
        /// </summary>
        public string AnalysisDate
        {
            get
            {
                return mstrAnalysisDate;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrAnalysisDate = value;
                }
                else
                {
                    mstrAnalysisDate = value;
                }
                //记录修改过的字段
                AddUpdatedFld("AnalysisDate");
            }
        }
        /// <summary>
        /// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
        /// </summary>
        public string UpdDate
        {
            get
            {
                return mstrUpdDate;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrUpdDate = value;
                }
                else
                {
                    mstrUpdDate = value;
                }
                //记录修改过的字段
                AddUpdatedFld("UpdDate");
            }
        }
        /// <summary>
        /// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
        /// </summary>
        public string UpdUserId
        {
            get
            {
                return mstrUpdUserId;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrUpdUserId = value;
                }
                else
                {
                    mstrUpdUserId = value;
                }
                //记录修改过的字段
                AddUpdatedFld("UpdUserId");
            }
        }
        /// <summary>
        /// 说明(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
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
        
    }
}