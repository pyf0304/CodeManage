using System;
using System.Drawing;
using System.Text;
namespace com.taishsoft.util
{
    /// <summary>
    /// 
    /// </summary>
    public enum OrderWay
    {
        /// <summary>
        /// 以行为主序
        /// </summary>
        RowMainOrder,   //
        /// <summary>
        /// 以列为主序
        /// </summary>
        ColMainOrder    //以列为主序
    };
    /// <summary>
    /// 行列位置，包括行号、列号
    /// </summary>
    public class clsPosition
    {
        /// <summary>
        /// 行号
        /// </summary>
        public int iRow;
        /// <summary>
        /// 列号
        /// </summary>
        public int iCol;

    }
	/// <summary>
	/// clsBiDimDistribute 的摘要说明。
	/// 主要用于二维控件的分布，例如一组控件，一行3列显示
	/// </summary>
	public class clsBiDimDistribute
	{
        private bool mbolIsCalcRowHeightByWeights = false;//是否通过权限来计算行高
        /// <summary>
        /// 是否通过权限来计算行高
        /// </summary>
        public bool IsCalcRowHeightByWeights
        {
            get { return mbolIsCalcRowHeightByWeights; }
            set { mbolIsCalcRowHeightByWeights = value; }
        }
        private bool mbolIsCalcColWidthByWeights = false;//是否通过权限来计算列宽
        /// <summary>
        /// 是否通过权限来计算列宽
        /// </summary>
        public bool IsCalcColWidthByWeights
        {
            get { return mbolIsCalcColWidthByWeights; }
            set { mbolIsCalcColWidthByWeights = value; }
        }
        private float mfltTotalTableHeight;//总的表高
        /// <summary>
        /// 总的表高
        /// </summary>
        public float TotalTableHeight
        {
            get { return mfltTotalTableHeight; }
            set { mfltTotalTableHeight = value; }
        }
        private float mfltTotalTableWidth;//总的表宽
        /// <summary>
        /// 总的表宽
        /// </summary>
        public float TotalTableWidth
        {
            get { return mfltTotalTableWidth; }
            set { mfltTotalTableWidth = value; }
        }
        private float[] mfltHeightWeights = null;//行高权重
        /// <summary>
        /// 行高权重
        /// </summary>
        public float[] HeightWeights
        {
            get { return mfltHeightWeights; }
            set { mfltHeightWeights = value; }
        }
        private float[] mfltWidthWeights = null;//列宽权重
        /// <summary>
        /// 列宽权重
        /// </summary>
        public float[] WidthWeights
        {
            get { return mfltWidthWeights; }
            set { mfltWidthWeights = value; }
        }
        private float[] mfltMinHeights = null;//最小行高
        /// <summary>
        /// 最小行高
        /// </summary>
        public float[] MinHeights
        {
            get { return mfltMinHeights; }
            set { mfltMinHeights = value; }
        }
        private float[] mfltMinWidths = null;//最小列宽
        /// <summary>
        /// 最小列宽
        /// </summary>
        public float[] MinWidths
        {
            get { return mfltMinWidths; }
            set { mfltMinWidths = value; }
        }

        private float mfltUnitRowHeight;//每单位行高
        /// <summary>
        /// 每单位行高
        /// </summary>
        public float UnitRowHeight
        {
            get { return mfltUnitRowHeight; }
        }
        private float mfltUnitColWidth;//每单位列宽
        /// <summary>
        /// 每单位列宽
        /// </summary>
        public float UnitColWidth
        {
            get { return mfltUnitColWidth; }
         }

        private float[] mfltCalcRowHeight = null;//计算后的行高
        /// <summary>
        /// 计算后的行高
        /// </summary>
        public float[] CalcRowHeight
        {
            get { return mfltCalcRowHeight; }
            set { mfltCalcRowHeight = value; }
        }
        private float[] mfltCalcColWidth = null;//每单位列宽
        /// <summary>
        /// 每单位列宽
        /// </summary>
        public float[] CalcColWidth
        {
            get { return mfltCalcColWidth; }
            set { mfltCalcColWidth = value; }
        }

		private float mfltStartX;		//	起始位置X，用户提供
		private float mfltStartY;		//	起始位置Y，用户提供
		private float mfltLineHeight;	//	行高，用户提供
		private float mfltColWidth;	//	列宽，用户提供
		private int mintColNum;		//	列数，用户提供
        private int mintRowNum;		//	行数，通过计算得到
		private int mintIndex;		// 当前序号，序号从0开始
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
        /// 
        /// </summary>
		public clsBiDimDistribute()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}
        /// <summary>
        /// 起始位置X，用户提供
        /// </summary>
		public float StartX
		{
			get
			{
				return mfltStartX;
			}
			set
			{
				mfltStartX = value;
			}
		}
        /// <summary>
        /// 起始位置Y，用户提供
        /// </summary>
		public float StartY		//	起始位置Y，用户提供
		{
			get
			{
				return mfltStartY;
			}
			set
			{
                mfltStartY = value;
			}
		}
		public float LineHeight	//	行高，用户提供
		{
			get
			{
				return mfltLineHeight;
			}
			set
			{
				mfltLineHeight = value;
			}
		}
        /// <summary>
        /// 列宽，用户提供
        /// </summary>
		public float ColWidth	//	列宽，用户提供
		{
			get
			{
				return mfltColWidth;
			}
			set
			{
				mfltColWidth = value;
			}
		}
        /// <summary>
        /// 列数，用户提供
        /// </summary>
		public int ColNum		//	列数，用户提供
		{
			get
			{
				return mintColNum;
			}
			set
			{
				if (value == 0)
				{
					mintColNum = 2;
				}
				else
				{
					mintColNum = value;
				}
                if (mintColNum > 0)
                {
                    mfltCalcColWidth = new float[mintColNum];
                    mfltWidthWeights = new float[mintColNum];
                    mfltMinWidths = new float[mintColNum];


                }

			}
		}
        /// <summary>
        /// 行数，通过计算得到
        /// </summary>
		public int RowNum		//	行数，通过计算得到
		{
			get
			{
				return mintRowNum;
			}
            set
            {
                if (value == 0)
                {
                    mintRowNum = 2;
                }
                else
                {
                    mintRowNum = value;
                }
                if (mintRowNum > 0)
                {
                    mfltCalcRowHeight = new float[mintRowNum];
                    mfltHeightWeights = new float[mintRowNum];
                    mfltMinHeights = new float[mintRowNum];
                 

                }
            }
		}
        /// <summary>
        /// 当前序号，序号从0开始
        /// </summary>
		public int Index		// 当前序号，序号从0开始
		{
			get
			{
				return mintIndex;
			}
			set
			{
				mintIndex = value;
			}
		}
		/// <summary>
		/// 获取某序号(index)点的当前位置
		/// </summary>
		/// <param name="intIndex">点序号</param>
		/// <returns>序号点的位置</returns>
		public PointF GetPosition(int intIndex)
		{
			int intRow, intCol;	//行号、列号,行号、列号都是从0开始
            float fltCurrX, fltCurrY;		//当前位置X、Y
            if (mMyOrderWay == OrderWay.RowMainOrder)
            {
                intCol = intIndex % mintColNum;		//计算某序号点的列号(intCol)
                intRow = intIndex / mintColNum;
                if (mbolIsCalcColWidthByWeights == true)
                {
                    fltCurrX = mfltStartX + CalcColWidthSum4First_n_Terms(intCol);
                }
                else
                {
                    fltCurrX = mfltStartX + intCol * mfltColWidth;
                }
                if (mbolIsCalcColWidthByWeights == true)
                {
                    fltCurrY = mfltStartY + CalcRowHeightSum4First_n_Terms(intRow);
                }
                else
                {
                    fltCurrY = mfltStartY + intRow * mfltLineHeight;
                }
            }
            else
            {
                intCol = intIndex / mintRowNum;		//计算某序号点的列号(intCol)
                intRow = intIndex % mintRowNum;
                if (mbolIsCalcColWidthByWeights == true)
                {
                    fltCurrX = mfltStartX + CalcColWidthSum4First_n_Terms(intCol);
                }
                else
                {
                    fltCurrX = mfltStartX + intCol * mfltColWidth;
                }
                if (mbolIsCalcColWidthByWeights == true)
                {
                    fltCurrY = mfltStartY + CalcRowHeightSum4First_n_Terms(intRow);
                }
                else
                {
                    fltCurrY = mfltStartY + intRow * mfltLineHeight;
                }
            }
            return new PointF(fltCurrX, fltCurrY);
		}



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
                intCol = intIndex % mintColNum;		//计算某序号点的列号(intCol)
                intRow = intIndex / mintColNum;
                objPosition.iRow = intRow;
                objPosition.iCol = intCol;
            }
            else
            {
                intCol = intIndex / mintRowNum;		//计算某序号点的列号(intCol)
                intRow = intIndex % mintRowNum;
                objPosition.iRow = intRow;
                objPosition.iCol = intCol;
            }
            return objPosition;
        }
        /// <summary>
        /// 计算前N项行高和
        /// </summary>
        /// <param name="intN">前N项</param>
        /// <returns>行高和</returns>
        public float CalcRowHeightSum4First_n_Terms(int intN)
        {
            float fltSum = 0;
            for (int i = 0; i < intN; i++)
            {
                fltSum += CalcRowHeight[i];
            }
            return fltSum;
        }
        /// <summary>
        /// 计算前N项列宽和
        /// </summary>
        /// <param name="intN">前N项</param>
        /// <returns>行高和</returns>
        public float CalcColWidthSum4First_n_Terms(int intN)
        {
            float fltSum = 0;
            for (int i = 0; i < intN; i++)
            {
                fltSum += CalcColWidth[i];
            }
            return fltSum;
        }
        /// <summary>
        /// 获取用户控件的高度，根据内部的子控件数
        /// </summary>
        /// <param name="intCtlNum">子控件数</param>
        /// <returns>用户控件的高度</returns>
        public float GetCtlHeigh(int intCtlNum)
		{
			int intRow, intCol;	//行号、列号,行号、列号都是从0开始
            if (mMyOrderWay == OrderWay.RowMainOrder)
            {
                intCol = intCtlNum / mintColNum;		//计算某序号点的列号(intCol)
                intRow = intCtlNum % mintColNum;
            }
            else
            {
                intCol = intCtlNum % mintRowNum;		//计算某序号点的列号(intCol)
                intRow = intCtlNum / mintRowNum;
            }
			if (intCol != 0)
			{
				intRow ++;	//如果余数为0就不加，否则就加1
			}
			float fltCtlHeight;		//用户控件的高度
            fltCtlHeight = mfltStartX + intRow * mfltLineHeight;
            return fltCtlHeight;
		}
		/// <summary>
		/// 获取用户控件的宽度，根据内部的控件列数
		/// </summary>
		/// <returns>用户控件的宽度</returns>
		public float GetCtlWidth()
		{
			float fltCtlWidth;		//用户控件的高度
            fltCtlWidth = mintColNum * mfltColWidth;
            return fltCtlWidth;
		}

        /// <summary>
        /// 通过权重来计算行高和列宽
        /// </summary>
        public void CalcRowHeightByWeights()
        {
            //计算步骤：
            //1、验证的正确性

            //2、计算总的权重
            //3、计算每单位的行高、列宽
            //4、计算每行列的行高、列宽
            //5、校验行高、列宽是否高于最小行高、列宽，满足条件则退出
            //6、排除掉最低行高和列宽的行和列，重新计算每单位的行高、列宽
            //7、计算排除最低行高和列宽的行和列，重新计算每行列的行高、列宽

            //计算步骤：
            //1、验证的正确性



            //1.1 验证行高的权重不能小于等于0
            if (mintRowNum <= 0)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("行数={0}不正确，行数不能低于0！", mintRowNum);
                throw new Exception(sbMsg.ToString());
            }
            for (int i = 0; i < mintRowNum; i++)
            {
                if (mfltHeightWeights[i] <= 0)
                {
                    StringBuilder sbMsg = new StringBuilder();
                    sbMsg.AppendFormat("第{0}行={1}不正确，行高权限不能低于0！", i, mfltHeightWeights[i]);
                    throw new Exception(sbMsg.ToString());
                }
            }

            ////1.2 验证列宽的权重不能小于等于0
            //for (int i = 0; i < mintColNum; i++)
            //{
            //    if (mfltHeightWeights[i] <= 0)
            //    {
            //        StringBuilder sbMsg = new StringBuilder();
            //        sbMsg.AppendFormat("第{0}行={1}不正确，行高权限不能低于0！", i, mfltHeightWeights[i]);
            //        throw new Exception(sbMsg.ToString());
            //    }
            //}

            //2、计算总的权重
            float fltTotalRowWeight = 0;
            for (int i = 0; i < mintRowNum; i++)
            {
                fltTotalRowWeight += mfltHeightWeights[i];
            }

            //3、计算每单位的行高、列宽
            if (mfltTotalTableHeight <= 0)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("总表高={0}不正确，总表高不能低于0！", mfltTotalTableHeight);
                throw new Exception(sbMsg.ToString());
            }
            mfltUnitRowHeight = mfltTotalTableHeight / fltTotalRowWeight;
            //4、计算每行列的行高、列宽
            for (int i = 0; i < mintRowNum; i++)
            {
                mfltCalcRowHeight[i] = mfltUnitRowHeight * mfltHeightWeights[i];
            }
            //5、校验行高、列宽是否高于最小行高、列宽，满足条件则退出
            bool bolIsValid = true;
            for (int i = 0; i < mintRowNum; i++)
            {
                if (mfltMinHeights[i] > 0 && mfltCalcRowHeight[i] < mfltMinHeights[i])
                {
                    bolIsValid = false;
                }
            }
            if (bolIsValid == true) return;
            //6、排除掉最低行高和列宽的行和列，重新计算每单位的行高、列宽
            bool[] bolIsExclude = new bool[mintRowNum];
            float fltMinTotalRowHeight = 0;
            for (int i = 0; i < mintRowNum; i++)
            {
                if (mfltMinHeights[i] > 0 && mfltCalcRowHeight[i] < mfltMinHeights[i])
                {
                    bolIsExclude[i] = true;
                    mfltCalcRowHeight[i] = mfltMinHeights[i];
                    fltMinTotalRowHeight += mfltCalcRowHeight[i];
                }
                else
                {
                    bolIsExclude[i] = false;
                }
            }
            fltTotalRowWeight = 0;
            for (int i = 0; i < mintRowNum; i++)
            {
                if (bolIsExclude[i] == false)
                {
                    fltTotalRowWeight+=mfltHeightWeights[i];
                }
            }

            mfltUnitRowHeight = (mfltTotalTableHeight-fltMinTotalRowHeight) / fltTotalRowWeight;

            //7、计算排除最低行高和列宽的行和列，重新计算每行列的行高、列宽

            for (int i = 0; i < mintRowNum; i++)
            {
                if (bolIsExclude[i] == false)
                {
                    mfltCalcRowHeight[i] = mfltUnitRowHeight * mfltHeightWeights[i];
                }
            }
            return;
        }


        /// <summary>
        /// 通过权重来计算行高和列宽
        /// </summary>
        public void CalcColWidthByWeights()
        {
            //计算步骤：
            //1、验证的正确性

            //2、计算总的权重
            //3、计算每单位的列宽、列宽
            //4、计算每行列的列宽、列宽
            //5、校验列宽、列宽是否高于最小列宽、列宽，满足条件则退出
            //6、排除掉最低列宽和列宽的行和列，重新计算每单位的列宽、列宽
            //7、计算排除最低列宽和列宽的行和列，重新计算每行列的列宽、列宽

            //计算步骤：
            //1、验证的正确性



            //1.1 验证列宽的权重不能小于等于0
            if (mintColNum <= 0)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("列数={0}不正确，列数不能低于0！", mintColNum);
                throw new Exception(sbMsg.ToString());
            }
            for (int i = 0; i < mintColNum; i++)
            {
                if (mfltWidthWeights[i] <= 0)
                {
                    StringBuilder sbMsg = new StringBuilder();
                    sbMsg.AppendFormat("第{0}行={1}不正确，列宽权限不能低于0！", i, mfltWidthWeights[i]);
                    throw new Exception(sbMsg.ToString());
                }
            }

            ////1.2 验证列宽的权重不能小于等于0
            //for (int i = 0; i < mintColNum; i++)
            //{
            //    if (mfltWidthWeights[i] <= 0)
            //    {
            //        StringBuilder sbMsg = new StringBuilder();
            //        sbMsg.AppendFormat("第{0}行={1}不正确，列宽权限不能低于0！", i, mfltWidthWeights[i]);
            //        throw new Exception(sbMsg.ToString());
            //    }
            //}

            //2、计算总的权重
            float fltTotalColWeight = 0;
            for (int i = 0; i < mintColNum; i++)
            {
                fltTotalColWeight += mfltWidthWeights[i];
            }

            //3、计算每单位的列宽、列宽
            if (mfltTotalTableWidth <= 0)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("总表宽={0}不正确，总表宽不能低于0！", mfltTotalTableWidth);
                throw new Exception(sbMsg.ToString());
            }
            mfltUnitColWidth = mfltTotalTableWidth / fltTotalColWeight;
            //4、计算每行列的列宽、列宽
            for (int i = 0; i < mintColNum; i++)
            {
                mfltCalcColWidth[i] = mfltUnitColWidth * mfltWidthWeights[i];
            }
            //5、校验列宽、列宽是否高于最小列宽、列宽，满足条件则退出
            bool bolIsValid = true;
            for (int i = 0; i < mintColNum; i++)
            {
                if (mfltMinWidths[i] > 0 && mfltCalcColWidth[i] < mfltMinWidths[i])
                {
                    bolIsValid = false;
                }
            }
            if (bolIsValid == true) return;
            //6、排除掉最低列宽和列宽的行和列，重新计算每单位的列宽、列宽
            bool[] bolIsExclude = new bool[mintColNum];
            float fltMinTotalColWidth = 0;
            for (int i = 0; i < mintColNum; i++)
            {
                if (mfltMinWidths[i] > 0 && mfltCalcColWidth[i] < mfltMinWidths[i])
                {
                    bolIsExclude[i] = true;
                    mfltCalcColWidth[i] = mfltMinWidths[i];
                    fltMinTotalColWidth += mfltCalcColWidth[i];
                }
                else
                {
                    bolIsExclude[i] = false;
                }
            }
            fltTotalColWeight = 0;
            for (int i = 0; i < mintColNum; i++)
            {
                if (bolIsExclude[i] == false)
                {
                    fltTotalColWeight += mfltWidthWeights[i];
                }
            }

            mfltUnitColWidth = (mfltTotalTableWidth - fltMinTotalColWidth) / fltTotalColWeight;

            //7、计算排除最低列宽和列宽的行和列，重新计算每行列的列宽、列宽

            for (int i = 0; i < mintColNum; i++)
            {
                if (bolIsExclude[i] == false)
                {
                    mfltCalcColWidth[i] = mfltUnitColWidth * mfltWidthWeights[i];
                }
            }
            return;
        }
	}
}
