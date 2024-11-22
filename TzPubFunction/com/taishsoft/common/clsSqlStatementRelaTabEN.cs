
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
    /// Sql语句相关表(SqlStatementRelaTab)
    /// </summary>
    [Serializable]
    public class SqlStatementRelaTab : clsEntityBase2
    {
        public const string CurrTabName_S = "SqlStatementRelaTab"; //当前表名，与该类相关的表名
        public const string CurrTabKeyFldName_S = "SqlStatementRelaTabId"; //当前表中的关键字名称，与该类相关的表中关键字名
        protected const int mintAttributeCount = 16;
        public static string[] AttributeName = new string[] { "SqlStatementRelaTabId", "SqlStatementId", "TabId", "TabName", "TabAliases", "RelaFldId", "OtherFldId", "OtherTabId", "SV_RelaTabTypeId", "TabRelationTypeId", "TabRelationText", "OrderNum", "PrjId", "UpdDate", "UpdUserId", "Memo" };
        //以下是属性变量

        protected string mstrSqlStatementRelaTabId;    //Sql语句相关表Id
        protected string mstrSqlStatementId;    //Sql语句Id
        protected string mstrTabId;    //表ID
        protected string mstrTabName;    //表名
        protected string mstrTabAliases;    //表别名
        protected string mstrRelaFldId;    //关系字段
        protected string mstrOtherFldId;    //其他表字段
        protected string mstrOtherTabId;    //其他表Id
        protected string mstrSV_RelaTabTypeId;    //Sql视图相关表类型Id
        protected string mstrTabRelationTypeId;    //表关系类型Id
        protected string mstrTabRelationText;    //表关系文本
        protected int mintOrderNum;    //序号
        protected string mstrPrjId;    //工程ID
        protected string mstrUpdDate;    //修改日期
        protected string mstrUpdUserId;    //修改用户Id
        protected string mstrMemo;    //说明
        protected int mintIntTag;    //整型Tag
        protected string mstrStrTag;    //字符型标签
        protected bool mbolIsCheckProperty;    //是否检查属性

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

        public SqlStatementRelaTab()
        {
            SetInit();
            mbolIsCheckProperty = false;
            _CurrTabName = "SqlStatementRelaTab";
            lstKeyFldNames.Add("SqlStatementRelaTabId");
        }

        public SqlStatementRelaTab(string strSqlStatementRelaTabId)
        {
            if (string.IsNullOrEmpty(strSqlStatementRelaTabId) == true)
            {
                throw new Exception("在表：SqlStatementRelaTab中，关键字不能为空 或 null！");
            }

            mstrSqlStatementRelaTabId = strSqlStatementRelaTabId;
            SetInit();
            mbolIsCheckProperty = false;
            _CurrTabName = "SqlStatementRelaTab";
            lstKeyFldNames.Add("SqlStatementRelaTabId");
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
                if (strAttributeName == "SqlStatementRelaTabId")
                {
                    return mstrSqlStatementRelaTabId;
                }
                else if (strAttributeName == "SqlStatementId")
                {
                    return mstrSqlStatementId;
                }
                else if (strAttributeName == "TabId")
                {
                    return mstrTabId;
                }
                else if (strAttributeName == "TabName")
                {
                    return mstrTabName;
                }
                else if (strAttributeName == "TabAliases")
                {
                    return mstrTabAliases;
                }
                else if (strAttributeName == "RelaFldId")
                {
                    return mstrRelaFldId;
                }
                else if (strAttributeName == "OtherFldId")
                {
                    return mstrOtherFldId;
                }
                else if (strAttributeName == "OtherTabId")
                {
                    return mstrOtherTabId;
                }
                else if (strAttributeName == "SV_RelaTabTypeId")
                {
                    return mstrSV_RelaTabTypeId;
                }
                else if (strAttributeName == "TabRelationTypeId")
                {
                    return mstrTabRelationTypeId;
                }
                else if (strAttributeName == "TabRelationText")
                {
                    return mstrTabRelationText;
                }
                else if (strAttributeName == "OrderNum")
                {
                    return mintOrderNum;
                }
                else if (strAttributeName == "PrjId")
                {
                    return mstrPrjId;
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
                if (strAttributeName == "SqlStatementRelaTabId")
                {
                    mstrSqlStatementRelaTabId = value.ToString();
                    AddUpdatedFld("SqlStatementRelaTabId");
                }
                else if (strAttributeName == "SqlStatementId")
                {
                    mstrSqlStatementId = value.ToString();
                    AddUpdatedFld("SqlStatementId");
                }
                else if (strAttributeName == "TabId")
                {
                    mstrTabId = value.ToString();
                    AddUpdatedFld("TabId");
                }
                else if (strAttributeName == "TabName")
                {
                    mstrTabName = value.ToString();
                    AddUpdatedFld("TabName");
                }
                else if (strAttributeName == "TabAliases")
                {
                    mstrTabAliases = value.ToString();
                    AddUpdatedFld("TabAliases");
                }
                else if (strAttributeName == "RelaFldId")
                {
                    mstrRelaFldId = value.ToString();
                    AddUpdatedFld("RelaFldId");
                }
                else if (strAttributeName == "OtherFldId")
                {
                    mstrOtherFldId = value.ToString();
                    AddUpdatedFld("OtherFldId");
                }
                else if (strAttributeName == "OtherTabId")
                {
                    mstrOtherTabId = value.ToString();
                    AddUpdatedFld("OtherTabId");
                }
                else if (strAttributeName == "SV_RelaTabTypeId")
                {
                    mstrSV_RelaTabTypeId = value.ToString();
                    AddUpdatedFld("SV_RelaTabTypeId");
                }
                else if (strAttributeName == "TabRelationTypeId")
                {
                    mstrTabRelationTypeId = value.ToString();
                    AddUpdatedFld("TabRelationTypeId");
                }
                else if (strAttributeName == "TabRelationText")
                {
                    mstrTabRelationText = value.ToString();
                    AddUpdatedFld("TabRelationText");
                }
                else if (strAttributeName == "OrderNum")
                {
                    mintOrderNum = TransNullToInt(value.ToString());
                    AddUpdatedFld("OrderNum");
                }
                else if (strAttributeName == "PrjId")
                {
                    mstrPrjId = value.ToString();
                    AddUpdatedFld("PrjId");
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
                if ("SqlStatementRelaTabId" == AttributeName[intIndex])
                {
                    return mstrSqlStatementRelaTabId;
                }
                else if ("SqlStatementId" == AttributeName[intIndex])
                {
                    return mstrSqlStatementId;
                }
                else if ("TabId" == AttributeName[intIndex])
                {
                    return mstrTabId;
                }
                else if ("TabName" == AttributeName[intIndex])
                {
                    return mstrTabName;
                }
                else if ("TabAliases" == AttributeName[intIndex])
                {
                    return mstrTabAliases;
                }
                else if ("RelaFldId" == AttributeName[intIndex])
                {
                    return mstrRelaFldId;
                }
                else if ("OtherFldId" == AttributeName[intIndex])
                {
                    return mstrOtherFldId;
                }
                else if ("OtherTabId" == AttributeName[intIndex])
                {
                    return mstrOtherTabId;
                }
                else if ("SV_RelaTabTypeId" == AttributeName[intIndex])
                {
                    return mstrSV_RelaTabTypeId;
                }
                else if ("TabRelationTypeId" == AttributeName[intIndex])
                {
                    return mstrTabRelationTypeId;
                }
                else if ("TabRelationText" == AttributeName[intIndex])
                {
                    return mstrTabRelationText;
                }
                else if ("OrderNum" == AttributeName[intIndex])
                {
                    return mintOrderNum;
                }
                else if ("PrjId" == AttributeName[intIndex])
                {
                    return mstrPrjId;
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
                if ("SqlStatementRelaTabId" == AttributeName[intIndex])
                {
                    mstrSqlStatementRelaTabId = value.ToString();
                    AddUpdatedFld("SqlStatementRelaTabId");
                }
                else if ("SqlStatementId" == AttributeName[intIndex])
                {
                    mstrSqlStatementId = value.ToString();
                    AddUpdatedFld("SqlStatementId");
                }
                else if ("TabId" == AttributeName[intIndex])
                {
                    mstrTabId = value.ToString();
                    AddUpdatedFld("TabId");
                }
                else if ("TabName" == AttributeName[intIndex])
                {
                    mstrTabName = value.ToString();
                    AddUpdatedFld("TabName");
                }
                else if ("TabAliases" == AttributeName[intIndex])
                {
                    mstrTabAliases = value.ToString();
                    AddUpdatedFld("TabAliases");
                }
                else if ("RelaFldId" == AttributeName[intIndex])
                {
                    mstrRelaFldId = value.ToString();
                    AddUpdatedFld("RelaFldId");
                }
                else if ("OtherFldId" == AttributeName[intIndex])
                {
                    mstrOtherFldId = value.ToString();
                    AddUpdatedFld("OtherFldId");
                }
                else if ("OtherTabId" == AttributeName[intIndex])
                {
                    mstrOtherTabId = value.ToString();
                    AddUpdatedFld("OtherTabId");
                }
                else if ("SV_RelaTabTypeId" == AttributeName[intIndex])
                {
                    mstrSV_RelaTabTypeId = value.ToString();
                    AddUpdatedFld("SV_RelaTabTypeId");
                }
                else if ("TabRelationTypeId" == AttributeName[intIndex])
                {
                    mstrTabRelationTypeId = value.ToString();
                    AddUpdatedFld("TabRelationTypeId");
                }
                else if ("TabRelationText" == AttributeName[intIndex])
                {
                    mstrTabRelationText = value.ToString();
                    AddUpdatedFld("TabRelationText");
                }
                else if ("OrderNum" == AttributeName[intIndex])
                {
                    mintOrderNum = TransNullToInt(value.ToString());
                    AddUpdatedFld("OrderNum");
                }
                else if ("PrjId" == AttributeName[intIndex])
                {
                    mstrPrjId = value.ToString();
                    AddUpdatedFld("PrjId");
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
        /// Sql语句相关表Id(说明:;字段类型:char;字段长度:8;是否可空:False)
        /// </summary>
        public string SqlStatementRelaTabId
        {
            get
            {
                return mstrSqlStatementRelaTabId;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrSqlStatementRelaTabId = value;
                }
                else
                {
                    mstrSqlStatementRelaTabId = value;
                }
                //记录修改过的字段
                AddUpdatedFld("SqlStatementRelaTabId");
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
        /// 表ID(说明:;字段类型:char;字段长度:8;是否可空:False)
        /// </summary>
        public string TabId
        {
            get
            {
                return mstrTabId;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrTabId = value;
                }
                else
                {
                    mstrTabId = value;
                }
                //记录修改过的字段
                AddUpdatedFld("TabId");
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
        /// 表别名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
        /// </summary>
        public string TabAliases
        {
            get
            {
                return mstrTabAliases;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrTabAliases = value;
                }
                else
                {
                    mstrTabAliases = value;
                }
                //记录修改过的字段
                AddUpdatedFld("TabAliases");
            }
        }
        /// <summary>
        /// 关系字段(说明:;字段类型:char;字段长度:8;是否可空:True)
        /// </summary>
        public string RelaFldId
        {
            get
            {
                return mstrRelaFldId;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrRelaFldId = value;
                }
                else
                {
                    mstrRelaFldId = value;
                }
                //记录修改过的字段
                AddUpdatedFld("RelaFldId");
            }
        }
        /// <summary>
        /// 其他表字段(说明:;字段类型:char;字段长度:8;是否可空:True)
        /// </summary>
        public string OtherFldId
        {
            get
            {
                return mstrOtherFldId;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrOtherFldId = value;
                }
                else
                {
                    mstrOtherFldId = value;
                }
                //记录修改过的字段
                AddUpdatedFld("OtherFldId");
            }
        }
        /// <summary>
        /// 其他表Id(说明:;字段类型:char;字段长度:8;是否可空:True)
        /// </summary>
        public string OtherTabId
        {
            get
            {
                return mstrOtherTabId;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrOtherTabId = value;
                }
                else
                {
                    mstrOtherTabId = value;
                }
                //记录修改过的字段
                AddUpdatedFld("OtherTabId");
            }
        }
        /// <summary>
        /// Sql视图相关表类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
        /// </summary>
        public string SV_RelaTabTypeId
        {
            get
            {
                return mstrSV_RelaTabTypeId;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrSV_RelaTabTypeId = value;
                }
                else
                {
                    mstrSV_RelaTabTypeId = value;
                }
                //记录修改过的字段
                AddUpdatedFld("SV_RelaTabTypeId");
            }
        }
        /// <summary>
        /// 表关系类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
        /// </summary>
        public string TabRelationTypeId
        {
            get
            {
                return mstrTabRelationTypeId;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrTabRelationTypeId = value;
                }
                else
                {
                    mstrTabRelationTypeId = value;
                }
                //记录修改过的字段
                AddUpdatedFld("TabRelationTypeId");
            }
        }
        /// <summary>
        /// 表关系文本(说明:;字段类型:varchar;字段长度:500;是否可空:True)
        /// </summary>
        public string TabRelationText
        {
            get
            {
                return mstrTabRelationText;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrTabRelationText = value;
                }
                else
                {
                    mstrTabRelationText = value;
                }
                //记录修改过的字段
                AddUpdatedFld("TabRelationText");
            }
        }
        /// <summary>
        /// 序号(说明:;字段类型:int;字段长度:4;是否可空:False)
        /// </summary>
        public int OrderNum
        {
            get
            {
                return mintOrderNum;
            }
            set
            {
                mintOrderNum = value;
                //记录修改过的字段
                AddUpdatedFld("OrderNum");
            }
        }
        /// <summary>
        /// 工程ID(说明:;字段类型:char;字段长度:4;是否可空:False)
        /// </summary>
        public string PrjId
        {
            get
            {
                return mstrPrjId;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrPrjId = value;
                }
                else
                {
                    mstrPrjId = value;
                }
                //记录修改过的字段
                AddUpdatedFld("PrjId");
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
                AddUpdatedFld("IntTag");
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
                AddUpdatedFld("StrTag");
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
                AddUpdatedFld("IsCheckProperty");
            }
        }
    }
}