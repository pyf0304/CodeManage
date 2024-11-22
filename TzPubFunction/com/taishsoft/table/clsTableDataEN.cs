
//----------------------
//生成代码版本：2015.08.06.1
//生成日期：2015/08/20
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

namespace com.taishsoft.table
{
    /// <summary>
    /// 表数据(TableData)
    /// </summary>
    [Serializable]
    public class clsTableDataEN : clsEntityBase2
    {
        /// <summary>
        /// 当前表名，与该类相关的表名
        /// </summary>
        public const string CurrTabName_S = "TableData"; //当前表名，与该类相关的表名
        /// <summary>
        /// 当前表中的关键字名称，与该类相关的表中关键字名
        /// </summary>
        public const string CurrTabKeyFldName_S = "mId"; //当前表中的关键字名称，与该类相关的表中关键字名
        /// <summary>
        /// 属性个数
        /// </summary>
        protected const int mintAttributeCount = 13;
        /// <summary>
        /// 属性名称数组
        /// </summary>
        public static string[] AttributeName = new string[] { "mId", "RowNo", "ColNo", "MyOrderWay", "CellIndex", "CellContent", "ColSpan", "RowSpan", "IsSameAsUp", "IsSameAsLeft", "DownSameNum", "RightSameNum", "Memo" };
        //以下是属性变量

        /// <summary>
        /// 流水号
        /// </summary>
        protected long mlngmId;    //流水号
        /// <summary>
        /// 行号
        /// </summary>
        protected int mintRowNo;    //行号
        /// <summary>
        /// 列号
        /// </summary>
        protected int mintColNo;    //列号
        /// <summary>
        /// 主序方式
        /// </summary>
        protected string mstrMyOrderWay;    //主序方式
        /// <summary>
        /// 单元格序号
        /// </summary>
        protected int mintCellIndex;    //单元格序号
        /// <summary>
        /// 单元格内容
        /// </summary>
        protected string mstrCellContent;    //单元格内容
        /// <summary>
        /// 列跨数
        /// </summary>
        protected int mintColSpan;    //列跨数
        /// <summary>
        /// 行跨数
        /// </summary>
        protected int mintRowSpan;    //行跨数
        /// <summary>
        /// 是否同上
        /// </summary>
        protected bool mbolIsSameAsUp;    //是否同上
        /// <summary>
        /// 是否同左
        /// </summary>
        protected bool mbolIsSameAsLeft;    //是否同左
        /// <summary>
        /// 向下相同数
        /// </summary>
        protected int mintDownSameNum;    //向下相同数
        /// <summary>
        /// 向右相同数
        /// </summary>
        protected int mintRightSameNum;    //向右相同数
        /// <summary>
        /// 备注
        /// </summary>
        protected string mstrMemo;    //备注


        /// <summary>
        /// 常量："mId"
        /// </summary>
        public const string con_mId = "mId";    //流水号

        /// <summary>
        /// 常量："RowNo"
        /// </summary>
        public const string con_RowNo = "RowNo";    //行号

        /// <summary>
        /// 常量："ColNo"
        /// </summary>
        public const string con_ColNo = "ColNo";    //列号

        /// <summary>
        /// 常量："MyOrderWay"
        /// </summary>
        public const string con_MyOrderWay = "MyOrderWay";    //主序方式

        /// <summary>
        /// 常量："CellIndex"
        /// </summary>
        public const string con_CellIndex = "CellIndex";    //单元格序号

        /// <summary>
        /// 常量："CellContent"
        /// </summary>
        public const string con_CellContent = "CellContent";    //单元格内容

        /// <summary>
        /// 常量："ColSpan"
        /// </summary>
        public const string con_ColSpan = "ColSpan";    //列跨数

        /// <summary>
        /// 常量："RowSpan"
        /// </summary>
        public const string con_RowSpan = "RowSpan";    //行跨数

        /// <summary>
        /// 常量："IsSameAsUp"
        /// </summary>
        public const string con_IsSameAsUp = "IsSameAsUp";    //是否同上

        /// <summary>
        /// 常量："IsSameAsLeft"
        /// </summary>
        public const string con_IsSameAsLeft = "IsSameAsLeft";    //是否同左

        /// <summary>
        /// 常量："DownSameNum"
        /// </summary>
        public const string con_DownSameNum = "DownSameNum";    //向下相同数

        /// <summary>
        /// 常量："RightSameNum"
        /// </summary>
        public const string con_RightSameNum = "RightSameNum";    //向右相同数

        /// <summary>
        /// 常量："Memo"
        /// </summary>
        public const string con_Memo = "Memo";    //备注
             
       
        /// <summary>
        /// 
        /// </summary>
        public clsTableDataEN()
        {
            SetInit();
            mbolIsCheckProperty = false;
            _CurrTabName = "TableData";
            lstKeyFldNames.Add("mId");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lngmId"></param>
        public clsTableDataEN(long lngmId)
        {
            if (lngmId == 0)
            {
                throw new Exception("关键字不能为0！");
            }

            mlngmId = lngmId;
            SetInit();
            mbolIsCheckProperty = false;
            _CurrTabName = "TableData";
            lstKeyFldNames.Add("mId");
        }
        /// <summary>
        /// 
        /// </summary>
        public static int AttributeCount
        {
            get
            {
                return mintAttributeCount;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strAttributeName"></param>
        /// <returns></returns>
        public object this[string strAttributeName]
        {
            get
            {
                if (strAttributeName == con_mId)
                {
                    return mlngmId;
                }
                else if (strAttributeName == con_RowNo)
                {
                    return mintRowNo;
                }
                else if (strAttributeName == con_ColNo)
                {
                    return mintColNo;
                }
                else if (strAttributeName == con_MyOrderWay)
                {
                    return mstrMyOrderWay;
                }
                else if (strAttributeName == con_CellIndex)
                {
                    return mintCellIndex;
                }
                else if (strAttributeName == con_CellContent)
                {
                    return mstrCellContent;
                }
                else if (strAttributeName == con_ColSpan)
                {
                    return mintColSpan;
                }
                else if (strAttributeName == con_RowSpan)
                {
                    return mintRowSpan;
                }
                else if (strAttributeName == con_IsSameAsUp)
                {
                    return mbolIsSameAsUp;
                }
                else if (strAttributeName == con_IsSameAsLeft)
                {
                    return mbolIsSameAsLeft;
                }
                else if (strAttributeName == con_DownSameNum)
                {
                    return mintDownSameNum;
                }
                else if (strAttributeName == con_RightSameNum)
                {
                    return mintRightSameNum;
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
                else if (strAttributeName == con_RowNo)
                {
                    mintRowNo = TransNullToInt(value.ToString());
                    AddUpdatedFld(con_RowNo);
                }
                else if (strAttributeName == con_ColNo)
                {
                    mintColNo = TransNullToInt(value.ToString());
                    AddUpdatedFld(con_ColNo);
                }
                else if (strAttributeName == con_MyOrderWay)
                {
                    mstrMyOrderWay = value.ToString();
                    AddUpdatedFld(con_MyOrderWay);
                }
                else if (strAttributeName == con_CellIndex)
                {
                    mintCellIndex = TransNullToInt(value.ToString());
                    AddUpdatedFld(con_CellIndex);
                }
                else if (strAttributeName == con_CellContent)
                {
                    mstrCellContent = value.ToString();
                    AddUpdatedFld(con_CellContent);
                }
                else if (strAttributeName == con_ColSpan)
                {
                    mintColSpan = TransNullToInt(value.ToString());
                    AddUpdatedFld(con_ColSpan);
                }
                else if (strAttributeName == con_RowSpan)
                {
                    mintRowSpan = TransNullToInt(value.ToString());
                    AddUpdatedFld(con_RowSpan);
                }
                else if (strAttributeName == con_IsSameAsUp)
                {
                    mbolIsSameAsUp = TransNullToBool(value.ToString());
                    AddUpdatedFld(con_IsSameAsUp);
                }
                else if (strAttributeName == con_IsSameAsLeft)
                {
                    mbolIsSameAsLeft = TransNullToBool(value.ToString());
                    AddUpdatedFld(con_IsSameAsLeft);
                }
                else if (strAttributeName == con_DownSameNum)
                {
                    mintDownSameNum = TransNullToInt(value.ToString());
                    AddUpdatedFld(con_DownSameNum);
                }
                else if (strAttributeName == con_RightSameNum)
                {
                    mintRightSameNum = TransNullToInt(value.ToString());
                    AddUpdatedFld(con_RightSameNum);
                }
                else if (strAttributeName == con_Memo)
                {
                    mstrMemo = value.ToString();
                    AddUpdatedFld(con_Memo);
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="intIndex"></param>
        /// <returns></returns>
        public object this[int intIndex]
        {
            get
            {
                if (con_mId == AttributeName[intIndex])
                {
                    return mlngmId;
                }
                else if (con_RowNo == AttributeName[intIndex])
                {
                    return mintRowNo;
                }
                else if (con_ColNo == AttributeName[intIndex])
                {
                    return mintColNo;
                }
                else if (con_MyOrderWay == AttributeName[intIndex])
                {
                    return mstrMyOrderWay;
                }
                else if (con_CellIndex == AttributeName[intIndex])
                {
                    return mintCellIndex;
                }
                else if (con_CellContent == AttributeName[intIndex])
                {
                    return mstrCellContent;
                }
                else if (con_ColSpan == AttributeName[intIndex])
                {
                    return mintColSpan;
                }
                else if (con_RowSpan == AttributeName[intIndex])
                {
                    return mintRowSpan;
                }
                else if (con_IsSameAsUp == AttributeName[intIndex])
                {
                    return mbolIsSameAsUp;
                }
                else if (con_IsSameAsLeft == AttributeName[intIndex])
                {
                    return mbolIsSameAsLeft;
                }
                else if (con_DownSameNum == AttributeName[intIndex])
                {
                    return mintDownSameNum;
                }
                else if (con_RightSameNum == AttributeName[intIndex])
                {
                    return mintRightSameNum;
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
                else if (con_RowNo == AttributeName[intIndex])
                {
                    mintRowNo = TransNullToInt(value.ToString());
                    AddUpdatedFld(con_RowNo);
                }
                else if (con_ColNo == AttributeName[intIndex])
                {
                    mintColNo = TransNullToInt(value.ToString());
                    AddUpdatedFld(con_ColNo);
                }
                else if (con_MyOrderWay == AttributeName[intIndex])
                {
                    mstrMyOrderWay = value.ToString();
                    AddUpdatedFld(con_MyOrderWay);
                }
                else if (con_CellIndex == AttributeName[intIndex])
                {
                    mintCellIndex = TransNullToInt(value.ToString());
                    AddUpdatedFld(con_CellIndex);
                }
                else if (con_CellContent == AttributeName[intIndex])
                {
                    mstrCellContent = value.ToString();
                    AddUpdatedFld(con_CellContent);
                }
                else if (con_ColSpan == AttributeName[intIndex])
                {
                    mintColSpan = TransNullToInt(value.ToString());
                    AddUpdatedFld(con_ColSpan);
                }
                else if (con_RowSpan == AttributeName[intIndex])
                {
                    mintRowSpan = TransNullToInt(value.ToString());
                    AddUpdatedFld(con_RowSpan);
                }
                else if (con_IsSameAsUp == AttributeName[intIndex])
                {
                    mbolIsSameAsUp = TransNullToBool(value.ToString());
                    AddUpdatedFld(con_IsSameAsUp);
                }
                else if (con_IsSameAsLeft == AttributeName[intIndex])
                {
                    mbolIsSameAsLeft = TransNullToBool(value.ToString());
                    AddUpdatedFld(con_IsSameAsLeft);
                }
                else if (con_DownSameNum == AttributeName[intIndex])
                {
                    mintDownSameNum = TransNullToInt(value.ToString());
                    AddUpdatedFld(con_DownSameNum);
                }
                else if (con_RightSameNum == AttributeName[intIndex])
                {
                    mintRightSameNum = TransNullToInt(value.ToString());
                    AddUpdatedFld(con_RightSameNum);
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
        /// 行号(说明:;字段类型:int;字段长度:4;是否可空:False)
        /// </summary>
        public int RowNo
        {
            get
            {
                return mintRowNo;
            }
            set
            {
                mintRowNo = value;
                //记录修改过的字段
                AddUpdatedFld(con_RowNo);
            }
        }
        /// <summary>
        /// 列号(说明:;字段类型:int;字段长度:4;是否可空:False)
        /// </summary>
        public int ColNo
        {
            get
            {
                return mintColNo;
            }
            set
            {
                mintColNo = value;
                //记录修改过的字段
                AddUpdatedFld(con_ColNo);
            }
        }
        /// <summary>
        /// 主序方式(说明:;字段类型:varchar;字段长度:20;是否可空:False)
        /// </summary>
        public string MyOrderWay
        {
            get
            {
                return mstrMyOrderWay;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrMyOrderWay = value;
                }
                else
                {
                    mstrMyOrderWay = value;
                }
                //记录修改过的字段
                AddUpdatedFld(con_MyOrderWay);
            }
        }
        /// <summary>
        /// 单元格序号(说明:;字段类型:int;字段长度:4;是否可空:False)
        /// </summary>
        public int CellIndex
        {
            get
            {
                return mintCellIndex;
            }
            set
            {
                mintCellIndex = value;
                //记录修改过的字段
                AddUpdatedFld(con_CellIndex);
            }
        }
        /// <summary>
        /// 单元格内容(说明:;字段类型:varchar;字段长度:4000;是否可空:False)
        /// </summary>
        public string CellContent
        {
            get
            {
                return mstrCellContent;
            }
            set
            {
                if (value == "")
                {
                    mintErrNo = 1;
                    mstrCellContent = value;
                }
                else
                {
                    mstrCellContent = value;
                }
                //记录修改过的字段
                AddUpdatedFld(con_CellContent);
            }
        }
        /// <summary>
        /// 列跨数(说明:;字段类型:int;字段长度:4;是否可空:False)
        /// </summary>
        public int ColSpan
        {
            get
            {
                return mintColSpan;
            }
            set
            {
                mintColSpan = value;
                //记录修改过的字段
                AddUpdatedFld(con_ColSpan);
            }
        }
        /// <summary>
        /// 行跨数(说明:;字段类型:int;字段长度:4;是否可空:False)
        /// </summary>
        public int RowSpan
        {
            get
            {
                return mintRowSpan;
            }
            set
            {
                mintRowSpan = value;
                //记录修改过的字段
                AddUpdatedFld(con_RowSpan);
            }
        }
        /// <summary>
        /// 是否同上(说明:;字段类型:bit;字段长度:1;是否可空:False)
        /// </summary>
        public bool IsSameAsUp
        {
            get
            {
                return mbolIsSameAsUp;
            }
            set
            {
                mbolIsSameAsUp = value;
                //记录修改过的字段
                AddUpdatedFld(con_IsSameAsUp);
            }
        }
        /// <summary>
        /// 是否同左(说明:;字段类型:bit;字段长度:1;是否可空:False)
        /// </summary>
        public bool IsSameAsLeft
        {
            get
            {
                return mbolIsSameAsLeft;
            }
            set
            {
                mbolIsSameAsLeft = value;
                //记录修改过的字段
                AddUpdatedFld(con_IsSameAsLeft);
            }
        }
        /// <summary>
        /// 向下相同数(说明:;字段类型:int;字段长度:4;是否可空:False)
        /// </summary>
        public int DownSameNum
        {
            get
            {
                return mintDownSameNum;
            }
            set
            {
                mintDownSameNum = value;
                //记录修改过的字段
                AddUpdatedFld(con_DownSameNum);
            }
        }
        /// <summary>
        /// 向右相同数(说明:;字段类型:int;字段长度:4;是否可空:False)
        /// </summary>
        public int RightSameNum
        {
            get
            {
                return mintRightSameNum;
            }
            set
            {
                mintRightSameNum = value;
                //记录修改过的字段
                AddUpdatedFld(con_RightSameNum);
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
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetDispData()
        {
            string strMsg = string.Format("{5}{6}-{0}-{1}-{2}-{3}-{4}", 
                this.CellContent, this.DownSameNum, this.RowSpan, this.IsSameAsUp, 
                this.IsSameAsLeft, this.RowNo, this.ColNo);
            return strMsg;
        }
    }
}