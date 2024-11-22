
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
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Xml;
using com.taishsoft.file;
using com.taishsoft.common;

using System.Data;
using System.Data.SqlClient;
using com.taishsoft.util;

namespace com.taishsoft.table
{
    /// <summary>
    /// 表数据(TableData)
    /// 数据源类型：SQL表
    /// </summary>
    public class clsTableDataBL
    {
        /// <summary>
        /// 静态的对象列表，用于缓存，针对记录较少，作为参数表可以使用
        /// </summary>
        public List<clsTableDataEN> arrTableDataObjLst = null;

        
        private int mintRowNum = 0;
        /// <summary>
        /// 表行数
        /// </summary>
        public int RowNum
        {
            get { return mintRowNum; }
            set { mintRowNum = value; }
        }
        private int mintColNum = 0;
        /// <summary>
        /// 表列数
        /// </summary>
        public int ColNum
        {
            get { return mintColNum; }
            set { mintColNum = value; }
        }
        private OrderWay mMyOrderWay = OrderWay.RowMainOrder;
        /// <summary>
        /// 排序方式，以行为主序，还是以列为主序
        /// </summary>
        public OrderWay MyOrderWay
        {
            get { return mMyOrderWay; }
            set { mMyOrderWay = value; }
        }

    

        /// <summary>
        /// 类的构造函数
        /// </summary>
        public clsTableDataBL()
        {
            arrTableDataObjLst = new List<clsTableDataEN>();
        }

     
     



        #region 克隆复制对象

    


        #endregion 克隆复制对象
        #region 表数据操作

        /// <summary>
        /// 添加新的表单元格对象到对象列表中, 提供单元格的行列序号
        /// </summary>
        /// <param name="intRow">行</param>
        /// <param name="intCol">列</param>
        /// <param name="strCellContent">单元格数据</param>
        /// <returns>表单元格对象</returns>
        public clsTableDataEN AddTableDataObj(int intRow, int intCol, string strCellContent)
        {

            clsTableDataEN objTableDataEN = GetTableDataObj(intRow, intCol);
            if (objTableDataEN != null)
            {
                string strMsg = string.Format("在表单元格对象列表中，已经存在 行:{0} 列:{1} 的单元格！",
                    intRow, intCol);
                throw new Exception(strMsg);
            }

            objTableDataEN = new clsTableDataEN();
            objTableDataEN.RowNo = intRow;
            objTableDataEN.ColNo = intCol;
            objTableDataEN.CellIndex = GetIndexByPosition_RowCol(intRow, intCol);
            //if (this.MyOrderWay == OrderWay.RowMainOrder)
            //{
            //    if (this.ColNum == 0)
            //    {
            //        throw new Exception ("以行为主序的表数据中，列数不能为0！");
            //    }
            //    objTableDataEN.CellIndex = (intRow - 1) * this.ColNum + intCol;
            //}
            //else
            //{
            //    if (this.RowNum == 0)
            //    {
            //        throw new Exception("以列为主序的表数据中，行数不能为0！");
            //    }
            //    objTableDataEN.CellIndex = (intCol - 1) * this.RowNum + intRow;
            
            //}
            objTableDataEN.CellContent = strCellContent;
            objTableDataEN.ColSpan = 0;
            objTableDataEN.RowSpan = 0;
            objTableDataEN.DownSameNum = 0;
            objTableDataEN.RightSameNum = 0;
            objTableDataEN.IsSameAsLeft = false;
            objTableDataEN.IsSameAsUp = false;
            arrTableDataObjLst.Add(objTableDataEN);
            arrTableDataObjLst.Sort((customer1, customer2) => customer1.CellIndex.CompareTo(customer2.CellIndex));
       
            if (intRow >= mintRowNum)
            {
                mintRowNum = intRow + 1;
            }
            if (intCol >= mintColNum)
            {
                mintColNum = intCol + 1;
            }
            return objTableDataEN;
        }

        /// <summary>
        /// 添加新的表单元格对象到对象列表中, 提供单元格的行列序号，如果表数据列表存在相同行列单元格数据，就把数据合并
        /// </summary>
        /// <param name="intRow">行</param>
        /// <param name="intCol">列</param>
        /// <param name="strCellContent">单元格数据</param>
        /// <returns>表单元格对象</returns>
        public clsTableDataEN AddTableDataObjEx(int intRow, int intCol, string strCellContent)
        {

            clsTableDataEN objTableDataEN = GetTableDataObj(intRow, intCol);
            if (objTableDataEN != null)
            {
                //string strMsg = string.Format("在表单元格对象列表中，已经存在 行:{0} 列:{1} 的单元格！",
                //    intRow, intCol);
                //throw new Exception(strMsg);
                objTableDataEN.CellContent += strCellContent;
            }
            else
            {
                objTableDataEN = new clsTableDataEN();
                objTableDataEN.RowNo = intRow;
                objTableDataEN.ColNo = intCol;
                objTableDataEN.CellIndex = GetIndexByPosition_RowCol(intRow, intCol);
                //if (this.MyOrderWay == OrderWay.RowMainOrder)
                //{
                //    if (this.ColNum == 0)
                //    {
                //        throw new Exception ("以行为主序的表数据中，列数不能为0！");
                //    }
                //    objTableDataEN.CellIndex = (intRow - 1) * this.ColNum + intCol;
                //}
                //else
                //{
                //    if (this.RowNum == 0)
                //    {
                //        throw new Exception("以列为主序的表数据中，行数不能为0！");
                //    }
                //    objTableDataEN.CellIndex = (intCol - 1) * this.RowNum + intRow;

                //}
                objTableDataEN.CellContent = strCellContent;
                objTableDataEN.ColSpan = 0;
                objTableDataEN.RowSpan = 0;
                objTableDataEN.DownSameNum = 0;
                objTableDataEN.RightSameNum = 0;
                objTableDataEN.IsSameAsLeft = false;
                objTableDataEN.IsSameAsUp = false;
                arrTableDataObjLst.Add(objTableDataEN);
                arrTableDataObjLst.Sort((customer1, customer2) => customer1.CellIndex.CompareTo(customer2.CellIndex));

                if (intRow >= mintRowNum)
                {
                    mintRowNum = intRow + 1;
                }
                if (intCol >= mintColNum)
                {
                    mintColNum = intCol + 1;
                }
            }
            return objTableDataEN;
        }

        /// <summary>
        /// 添加新的表单元格对象到对象列表中, 提供单元格的序号
        /// </summary>
        /// <param name="intIndex">单元格的序号</param>
        /// <param name="strCellContent">单元格数据</param>
        /// <returns>表单元格对象</returns>
        public clsTableDataEN AddTableDataObj(int intIndex, string strCellContent)
        {

            int intRow, intCol;

            clsPosition objPosition = GetPosition_RowCol(intIndex);
            intRow = objPosition.iRow;
            intCol = objPosition.iCol;
            clsTableDataEN objTableDataEN = GetTableDataObj(intRow, intCol);
            if (objTableDataEN != null)
            {
                string strMsg = string.Format("在表单元格对象列表中，已经存在 行:{0} 列:{1} 的单元格！",
                    intRow, intCol);
                throw new Exception(strMsg);
            }
            objTableDataEN = new clsTableDataEN();

            objTableDataEN.CellIndex = intIndex;

            objTableDataEN.RowNo = intRow;
            objTableDataEN.ColNo = intCol;
            objTableDataEN.CellContent = strCellContent;
            objTableDataEN.ColSpan = 0;
            objTableDataEN.RowSpan = 0;
            objTableDataEN.DownSameNum = 0;
            objTableDataEN.RightSameNum = 0;
            objTableDataEN.IsSameAsLeft = false;
            objTableDataEN.IsSameAsUp = false;
            arrTableDataObjLst.Add(objTableDataEN);
            arrTableDataObjLst.Sort((customer1, customer2) => customer1.CellIndex.CompareTo(customer2.CellIndex));
            if (intRow >= mintRowNum)
            {
                mintRowNum = intRow + 1;
            }
            if (intCol >= mintColNum)
            {
                mintColNum = intCol + 1;
            }
            return objTableDataEN;
        }

        /// <summary>
        /// 添加新的表单元格对象到对象列表中, 提供单元格的序号，如果表数据列表存在相同行列单元格数据，就把数据合并
        /// </summary>
        /// <param name="intIndex">单元格的序号</param>
        /// <param name="strCellContent">单元格数据</param>
        /// <returns>表单元格对象</returns>
        public clsTableDataEN AddTableDataObjEx(int intIndex, string strCellContent)
        {

            int intRow, intCol;

            clsPosition objPosition = GetPosition_RowCol(intIndex);
            intRow = objPosition.iRow;
            intCol = objPosition.iCol;
            clsTableDataEN objTableDataEN = GetTableDataObj(intRow, intCol);
            if (objTableDataEN != null)
            {
                //string strMsg = string.Format("在表单元格对象列表中，已经存在 行:{0} 列:{1} 的单元格！",
                //    intRow, intCol);
                //throw new Exception(strMsg);
                objTableDataEN.CellContent += strCellContent;
            }
            else
            {
                objTableDataEN = new clsTableDataEN();

                objTableDataEN.CellIndex = intIndex;

                objTableDataEN.RowNo = intRow;
                objTableDataEN.ColNo = intCol;
                objTableDataEN.CellContent = strCellContent;
                objTableDataEN.ColSpan = 0;
                objTableDataEN.RowSpan = 0;
                objTableDataEN.DownSameNum = 0;
                objTableDataEN.RightSameNum = 0;
                objTableDataEN.IsSameAsLeft = false;
                objTableDataEN.IsSameAsUp = false;
                arrTableDataObjLst.Add(objTableDataEN);
                arrTableDataObjLst.Sort((customer1, customer2) => customer1.CellIndex.CompareTo(customer2.CellIndex));
                if (intRow >= mintRowNum)
                {
                    mintRowNum = intRow + 1;
                }
                if (intCol >= mintColNum)
                {
                    mintColNum = intCol + 1;
                }
            }
            return objTableDataEN;
        }

        /// <summary>
        /// 添加新的表单元格对象到对象列表中
        /// </summary>
        /// <param name="objTableDataEN_S">行</param>
        /// <returns>表单元格对象</returns>
        public clsTableDataEN CopyFrom(clsTableDataEN objTableDataEN_S)
        {

            clsTableDataEN objTableDataEN = GetTableDataObj(objTableDataEN_S.RowNo, objTableDataEN_S.ColNo);
            if (objTableDataEN != null)
            {
                string strMsg = string.Format("在表单元格对象列表中，已经存在 行:{0} 列:{1} 的单元格！",
                    objTableDataEN_S.RowNo, objTableDataEN_S.ColNo);
                throw new Exception(strMsg);
            }
            objTableDataEN = new clsTableDataEN();
            objTableDataEN.RowNo = objTableDataEN_S.RowNo;
            objTableDataEN.ColNo = objTableDataEN_S.ColNo;
            objTableDataEN.CellContent = objTableDataEN_S.CellContent;
            objTableDataEN.ColSpan = objTableDataEN_S.ColSpan;
            objTableDataEN.RowSpan = objTableDataEN_S.RowSpan;
            objTableDataEN.DownSameNum = objTableDataEN_S.DownSameNum;
            objTableDataEN.RightSameNum = objTableDataEN_S.RightSameNum;
            objTableDataEN.IsSameAsLeft = objTableDataEN_S.IsSameAsLeft;
            objTableDataEN.IsSameAsUp = objTableDataEN_S.IsSameAsUp;
            arrTableDataObjLst.Add(objTableDataEN);
            if (objTableDataEN_S.RowNo >= mintRowNum)
            {
                mintRowNum = objTableDataEN_S.RowNo + 1;
            }
            if (objTableDataEN_S.ColNo >= mintColNum)
            {
                mintColNum = objTableDataEN_S.ColNo + 1;
            }
            return objTableDataEN;
        }
        /// <summary>
        /// 从表单元格对象列表中，找到某行、列的单元格对象
        /// </summary>
        /// <param name="intRow">行</param>
        /// <param name="intCol">列</param>
        /// <returns>表单元格对象</returns>
        public clsTableDataEN GetTableDataObj(int intRow, int intCol)
        {
            foreach (clsTableDataEN objTableDataEN in arrTableDataObjLst)
            {
                if (objTableDataEN.RowNo == intRow && objTableDataEN.ColNo == intCol)
                {
                    return objTableDataEN;
                }
            }
         
            return null;
        }
        /// <summary>
        /// 检查同上
        /// </summary>
        /// <returns></returns>
        public bool CheckSameAsUp()
        {
            for (int iCol = 0; iCol < mintColNum; iCol++)
            {
                string strUpCellData = "";
                //int intUpRow = 0;
                //int intUpCol = 0;
                  clsTableDataEN objTableDataEN_Up = null;
                for (int iRow = 0; iRow < mintRowNum; iRow++)
                {
                    clsTableDataEN objTableDataEN = GetTableDataObj(iRow, iCol);
                    if (objTableDataEN == null)
                    {
                        if (objTableDataEN_Up != null)
                        {

                        }
                        objTableDataEN_Up = objTableDataEN;
                        strUpCellData = "";
                        continue;
                    }
                    string strThisCellData = objTableDataEN.CellContent;
                    if (strThisCellData == strUpCellData)
                    {
                        objTableDataEN_Up.DownSameNum++;
                        objTableDataEN.IsSameAsUp = true;
                    }
                    else
                    {
                        objTableDataEN_Up = objTableDataEN;
                        objTableDataEN_Up.DownSameNum = 1;
                        strUpCellData = objTableDataEN_Up.CellContent;
                    }
                }
            }
           
            return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="objTableData_T"></param>
        public void CopyTo(clsTableDataBL objTableData_T)
        {
            foreach (clsTableDataEN objTableDataEN in this.arrTableDataObjLst)
            {
                objTableData_T.CopyFrom(objTableDataEN);
            }
        }
        #endregion 表数据操作

        #region 行列位置操作
        /// <summary>
        /// 获取某序号(index)点的当前行列位置
        /// </summary>
        /// <param name="intIndex">点序号</param>
        /// <returns>序号点的行列位置</returns>
        public clsPosition GetPosition_RowCol(int intIndex)
        {
            int intRow, intCol;	//行号、列号,行号、列号都是从0开始
            clsPosition objPosition = new clsPosition();

            if (mMyOrderWay == OrderWay.RowMainOrder)
            {
                if (mintColNum == 0)
                {
                    throw new Exception("列数不能为0！");
                }
                intCol = intIndex % mintColNum;		//计算某序号点的列号(intCol)
                intRow = intIndex / mintColNum;
                objPosition.iRow = intRow;
                objPosition.iCol = intCol;
            }
            else
            {
                if (mintRowNum == 0)
                {
                    throw new Exception("行数不能为0！");
                }
                intCol = intIndex / mintRowNum;		//计算某序号点的列号(intCol)
                intRow = intIndex % mintRowNum;
                objPosition.iRow = intRow;
                objPosition.iCol = intCol;
            }
            return objPosition;
        }

        /// <summary>
        /// 根据单元格的行列位置获取其序号(index)
        /// </summary>
        /// <param name="objPosition">序号点的行列位置</param>
        /// <returns>序号(index)</returns>
        public int GetIndexByPosition_RowCol(clsPosition objPosition)
        {
            //int intRow, intCol;	//行号、列号,行号、列号都是从0开始
            //clsPosition objPosition = new clsPosition();
            int intIndex = 0;
            if (mMyOrderWay == OrderWay.RowMainOrder)
            {
                if (mintColNum == 0)
                {
                    throw new Exception("以行为主序的表数据中，列数不能为0！");
                }
                intIndex = objPosition.iRow * mintColNum + objPosition.iCol;		//计算某序号点的列号(intCol)
             
            }
            else
            {
                if (this.RowNum == 0)
                {
                    throw new Exception("以列为主序的表数据中，行数不能为0！");
                }
                intIndex = objPosition.iCol * mintRowNum + objPosition.iRow;		//计算某序号点的列号(intCol)
            }
            return intIndex;
        }



        /// <summary>
        /// 根据单元格的行列位置获取其序号(index)
        /// </summary>
        /// <param name="iRow">行号</param>
        /// <param name="iCol">列号</param>
        /// <returns>序号(index)</returns>
        public int GetIndexByPosition_RowCol(int iRow, int iCol)
        {
            //int intRow, intCol;	//行号、列号,行号、列号都是从0开始
            //clsPosition objPosition = new clsPosition();
            int intIndex = 0;
            if (mMyOrderWay == OrderWay.RowMainOrder)
            {
                if (mintColNum == 0)
                {
                    throw new Exception("以行为主序的表数据中，列数不能为0！");
                }
                intIndex = iRow * mintColNum + iCol;		//计算某序号点的列号(intCol)

            }
            else
            {
                if (this.RowNum == 0)
                {
                    throw new Exception("以列为主序的表数据中，行数不能为0！");
                }
                intIndex = iCol * mintRowNum + iRow;		//计算某序号点的列号(intCol)
            }
            return intIndex;
        }
        #endregion 行列位置操作

        /// <summary>
        /// 获取有数据的列，用数组形式返回
        /// </summary>
        /// <returns></returns>
        public int[] GetIsHaveData4Col()
        {
            int[] intIsHaveData4Cols = new int[this.ColNum];
            foreach (clsTableDataEN objTableDataEN in this.arrTableDataObjLst)
            {
                if (string.IsNullOrEmpty(objTableDataEN.CellContent) == false)
                {
                    intIsHaveData4Cols[objTableDataEN.ColNo] = 1;
                }
            }
            return intIsHaveData4Cols;
        }
        /// <summary>
        /// 获取有数据的行，用数组形式返回
        /// </summary>
        /// <returns></returns>
        public int[] GetIsHaveData4Row()
        {
            int[] intIsHaveData4Rows = new int[this.RowNum];
            foreach (clsTableDataEN objTableDataEN in this.arrTableDataObjLst)
            {
                if (string.IsNullOrEmpty(objTableDataEN.CellContent) == false)
                {
                    intIsHaveData4Rows[objTableDataEN.RowNo] = 1;
                }
            }
            return intIsHaveData4Rows;
        }
    }
}