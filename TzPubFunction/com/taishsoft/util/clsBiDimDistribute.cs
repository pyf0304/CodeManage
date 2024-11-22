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
        /// ����Ϊ����
        /// </summary>
        RowMainOrder,   //
        /// <summary>
        /// ����Ϊ����
        /// </summary>
        ColMainOrder    //����Ϊ����
    };
    /// <summary>
    /// ����λ�ã������кš��к�
    /// </summary>
    public class clsPosition
    {
        /// <summary>
        /// �к�
        /// </summary>
        public int iRow;
        /// <summary>
        /// �к�
        /// </summary>
        public int iCol;

    }
	/// <summary>
	/// clsBiDimDistribute ��ժҪ˵����
	/// ��Ҫ���ڶ�ά�ؼ��ķֲ�������һ��ؼ���һ��3����ʾ
	/// </summary>
	public class clsBiDimDistribute
	{
        private bool mbolIsCalcRowHeightByWeights = false;//�Ƿ�ͨ��Ȩ���������и�
        /// <summary>
        /// �Ƿ�ͨ��Ȩ���������и�
        /// </summary>
        public bool IsCalcRowHeightByWeights
        {
            get { return mbolIsCalcRowHeightByWeights; }
            set { mbolIsCalcRowHeightByWeights = value; }
        }
        private bool mbolIsCalcColWidthByWeights = false;//�Ƿ�ͨ��Ȩ���������п�
        /// <summary>
        /// �Ƿ�ͨ��Ȩ���������п�
        /// </summary>
        public bool IsCalcColWidthByWeights
        {
            get { return mbolIsCalcColWidthByWeights; }
            set { mbolIsCalcColWidthByWeights = value; }
        }
        private float mfltTotalTableHeight;//�ܵı��
        /// <summary>
        /// �ܵı��
        /// </summary>
        public float TotalTableHeight
        {
            get { return mfltTotalTableHeight; }
            set { mfltTotalTableHeight = value; }
        }
        private float mfltTotalTableWidth;//�ܵı��
        /// <summary>
        /// �ܵı��
        /// </summary>
        public float TotalTableWidth
        {
            get { return mfltTotalTableWidth; }
            set { mfltTotalTableWidth = value; }
        }
        private float[] mfltHeightWeights = null;//�и�Ȩ��
        /// <summary>
        /// �и�Ȩ��
        /// </summary>
        public float[] HeightWeights
        {
            get { return mfltHeightWeights; }
            set { mfltHeightWeights = value; }
        }
        private float[] mfltWidthWeights = null;//�п�Ȩ��
        /// <summary>
        /// �п�Ȩ��
        /// </summary>
        public float[] WidthWeights
        {
            get { return mfltWidthWeights; }
            set { mfltWidthWeights = value; }
        }
        private float[] mfltMinHeights = null;//��С�и�
        /// <summary>
        /// ��С�и�
        /// </summary>
        public float[] MinHeights
        {
            get { return mfltMinHeights; }
            set { mfltMinHeights = value; }
        }
        private float[] mfltMinWidths = null;//��С�п�
        /// <summary>
        /// ��С�п�
        /// </summary>
        public float[] MinWidths
        {
            get { return mfltMinWidths; }
            set { mfltMinWidths = value; }
        }

        private float mfltUnitRowHeight;//ÿ��λ�и�
        /// <summary>
        /// ÿ��λ�и�
        /// </summary>
        public float UnitRowHeight
        {
            get { return mfltUnitRowHeight; }
        }
        private float mfltUnitColWidth;//ÿ��λ�п�
        /// <summary>
        /// ÿ��λ�п�
        /// </summary>
        public float UnitColWidth
        {
            get { return mfltUnitColWidth; }
         }

        private float[] mfltCalcRowHeight = null;//�������и�
        /// <summary>
        /// �������и�
        /// </summary>
        public float[] CalcRowHeight
        {
            get { return mfltCalcRowHeight; }
            set { mfltCalcRowHeight = value; }
        }
        private float[] mfltCalcColWidth = null;//ÿ��λ�п�
        /// <summary>
        /// ÿ��λ�п�
        /// </summary>
        public float[] CalcColWidth
        {
            get { return mfltCalcColWidth; }
            set { mfltCalcColWidth = value; }
        }

		private float mfltStartX;		//	��ʼλ��X���û��ṩ
		private float mfltStartY;		//	��ʼλ��Y���û��ṩ
		private float mfltLineHeight;	//	�иߣ��û��ṩ
		private float mfltColWidth;	//	�п��û��ṩ
		private int mintColNum;		//	�������û��ṩ
        private int mintRowNum;		//	������ͨ������õ�
		private int mintIndex;		// ��ǰ��ţ���Ŵ�0��ʼ
        private OrderWay mMyOrderWay = OrderWay.RowMainOrder;
        /// <summary>
        /// ����ʽ������Ϊ���򣬻�������Ϊ����
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
			// TODO: �ڴ˴���ӹ��캯���߼�
			//
		}
        /// <summary>
        /// ��ʼλ��X���û��ṩ
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
        /// ��ʼλ��Y���û��ṩ
        /// </summary>
		public float StartY		//	��ʼλ��Y���û��ṩ
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
		public float LineHeight	//	�иߣ��û��ṩ
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
        /// �п��û��ṩ
        /// </summary>
		public float ColWidth	//	�п��û��ṩ
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
        /// �������û��ṩ
        /// </summary>
		public int ColNum		//	�������û��ṩ
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
        /// ������ͨ������õ�
        /// </summary>
		public int RowNum		//	������ͨ������õ�
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
        /// ��ǰ��ţ���Ŵ�0��ʼ
        /// </summary>
		public int Index		// ��ǰ��ţ���Ŵ�0��ʼ
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
		/// ��ȡĳ���(index)��ĵ�ǰλ��
		/// </summary>
		/// <param name="intIndex">�����</param>
		/// <returns>��ŵ��λ��</returns>
		public PointF GetPosition(int intIndex)
		{
			int intRow, intCol;	//�кš��к�,�кš��кŶ��Ǵ�0��ʼ
            float fltCurrX, fltCurrY;		//��ǰλ��X��Y
            if (mMyOrderWay == OrderWay.RowMainOrder)
            {
                intCol = intIndex % mintColNum;		//����ĳ��ŵ���к�(intCol)
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
                intCol = intIndex / mintRowNum;		//����ĳ��ŵ���к�(intCol)
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
        /// ��ȡĳ���(index)��ĵ�ǰ����λ��
        /// </summary>
        /// <param name="intIndex">�����</param>
        /// <returns>��ŵ������λ��</returns>
        public clsPosition GetPosition_RowCol(int intIndex)
        {
            int intRow, intCol;	//�кš��к�,�кš��кŶ��Ǵ�0��ʼ
            clsPosition objPosition = new clsPosition();
          
            if (mMyOrderWay == OrderWay.RowMainOrder)
            {
                intCol = intIndex % mintColNum;		//����ĳ��ŵ���к�(intCol)
                intRow = intIndex / mintColNum;
                objPosition.iRow = intRow;
                objPosition.iCol = intCol;
            }
            else
            {
                intCol = intIndex / mintRowNum;		//����ĳ��ŵ���к�(intCol)
                intRow = intIndex % mintRowNum;
                objPosition.iRow = intRow;
                objPosition.iCol = intCol;
            }
            return objPosition;
        }
        /// <summary>
        /// ����ǰN���иߺ�
        /// </summary>
        /// <param name="intN">ǰN��</param>
        /// <returns>�иߺ�</returns>
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
        /// ����ǰN���п��
        /// </summary>
        /// <param name="intN">ǰN��</param>
        /// <returns>�иߺ�</returns>
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
        /// ��ȡ�û��ؼ��ĸ߶ȣ������ڲ����ӿؼ���
        /// </summary>
        /// <param name="intCtlNum">�ӿؼ���</param>
        /// <returns>�û��ؼ��ĸ߶�</returns>
        public float GetCtlHeigh(int intCtlNum)
		{
			int intRow, intCol;	//�кš��к�,�кš��кŶ��Ǵ�0��ʼ
            if (mMyOrderWay == OrderWay.RowMainOrder)
            {
                intCol = intCtlNum / mintColNum;		//����ĳ��ŵ���к�(intCol)
                intRow = intCtlNum % mintColNum;
            }
            else
            {
                intCol = intCtlNum % mintRowNum;		//����ĳ��ŵ���к�(intCol)
                intRow = intCtlNum / mintRowNum;
            }
			if (intCol != 0)
			{
				intRow ++;	//�������Ϊ0�Ͳ��ӣ�����ͼ�1
			}
			float fltCtlHeight;		//�û��ؼ��ĸ߶�
            fltCtlHeight = mfltStartX + intRow * mfltLineHeight;
            return fltCtlHeight;
		}
		/// <summary>
		/// ��ȡ�û��ؼ��Ŀ�ȣ������ڲ��Ŀؼ�����
		/// </summary>
		/// <returns>�û��ؼ��Ŀ��</returns>
		public float GetCtlWidth()
		{
			float fltCtlWidth;		//�û��ؼ��ĸ߶�
            fltCtlWidth = mintColNum * mfltColWidth;
            return fltCtlWidth;
		}

        /// <summary>
        /// ͨ��Ȩ���������иߺ��п�
        /// </summary>
        public void CalcRowHeightByWeights()
        {
            //���㲽�裺
            //1����֤����ȷ��

            //2�������ܵ�Ȩ��
            //3������ÿ��λ���иߡ��п�
            //4������ÿ���е��иߡ��п�
            //5��У���иߡ��п��Ƿ������С�иߡ��п������������˳�
            //6���ų�������иߺ��п���к��У����¼���ÿ��λ���иߡ��п�
            //7�������ų�����иߺ��п���к��У����¼���ÿ���е��иߡ��п�

            //���㲽�裺
            //1����֤����ȷ��



            //1.1 ��֤�иߵ�Ȩ�ز���С�ڵ���0
            if (mintRowNum <= 0)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("����={0}����ȷ���������ܵ���0��", mintRowNum);
                throw new Exception(sbMsg.ToString());
            }
            for (int i = 0; i < mintRowNum; i++)
            {
                if (mfltHeightWeights[i] <= 0)
                {
                    StringBuilder sbMsg = new StringBuilder();
                    sbMsg.AppendFormat("��{0}��={1}����ȷ���и�Ȩ�޲��ܵ���0��", i, mfltHeightWeights[i]);
                    throw new Exception(sbMsg.ToString());
                }
            }

            ////1.2 ��֤�п��Ȩ�ز���С�ڵ���0
            //for (int i = 0; i < mintColNum; i++)
            //{
            //    if (mfltHeightWeights[i] <= 0)
            //    {
            //        StringBuilder sbMsg = new StringBuilder();
            //        sbMsg.AppendFormat("��{0}��={1}����ȷ���и�Ȩ�޲��ܵ���0��", i, mfltHeightWeights[i]);
            //        throw new Exception(sbMsg.ToString());
            //    }
            //}

            //2�������ܵ�Ȩ��
            float fltTotalRowWeight = 0;
            for (int i = 0; i < mintRowNum; i++)
            {
                fltTotalRowWeight += mfltHeightWeights[i];
            }

            //3������ÿ��λ���иߡ��п�
            if (mfltTotalTableHeight <= 0)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("�ܱ��={0}����ȷ���ܱ�߲��ܵ���0��", mfltTotalTableHeight);
                throw new Exception(sbMsg.ToString());
            }
            mfltUnitRowHeight = mfltTotalTableHeight / fltTotalRowWeight;
            //4������ÿ���е��иߡ��п�
            for (int i = 0; i < mintRowNum; i++)
            {
                mfltCalcRowHeight[i] = mfltUnitRowHeight * mfltHeightWeights[i];
            }
            //5��У���иߡ��п��Ƿ������С�иߡ��п������������˳�
            bool bolIsValid = true;
            for (int i = 0; i < mintRowNum; i++)
            {
                if (mfltMinHeights[i] > 0 && mfltCalcRowHeight[i] < mfltMinHeights[i])
                {
                    bolIsValid = false;
                }
            }
            if (bolIsValid == true) return;
            //6���ų�������иߺ��п���к��У����¼���ÿ��λ���иߡ��п�
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

            //7�������ų�����иߺ��п���к��У����¼���ÿ���е��иߡ��п�

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
        /// ͨ��Ȩ���������иߺ��п�
        /// </summary>
        public void CalcColWidthByWeights()
        {
            //���㲽�裺
            //1����֤����ȷ��

            //2�������ܵ�Ȩ��
            //3������ÿ��λ���п��п�
            //4������ÿ���е��п��п�
            //5��У���п��п��Ƿ������С�п��п������������˳�
            //6���ų�������п���п���к��У����¼���ÿ��λ���п��п�
            //7�������ų�����п���п���к��У����¼���ÿ���е��п��п�

            //���㲽�裺
            //1����֤����ȷ��



            //1.1 ��֤�п��Ȩ�ز���С�ڵ���0
            if (mintColNum <= 0)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("����={0}����ȷ���������ܵ���0��", mintColNum);
                throw new Exception(sbMsg.ToString());
            }
            for (int i = 0; i < mintColNum; i++)
            {
                if (mfltWidthWeights[i] <= 0)
                {
                    StringBuilder sbMsg = new StringBuilder();
                    sbMsg.AppendFormat("��{0}��={1}����ȷ���п�Ȩ�޲��ܵ���0��", i, mfltWidthWeights[i]);
                    throw new Exception(sbMsg.ToString());
                }
            }

            ////1.2 ��֤�п��Ȩ�ز���С�ڵ���0
            //for (int i = 0; i < mintColNum; i++)
            //{
            //    if (mfltWidthWeights[i] <= 0)
            //    {
            //        StringBuilder sbMsg = new StringBuilder();
            //        sbMsg.AppendFormat("��{0}��={1}����ȷ���п�Ȩ�޲��ܵ���0��", i, mfltWidthWeights[i]);
            //        throw new Exception(sbMsg.ToString());
            //    }
            //}

            //2�������ܵ�Ȩ��
            float fltTotalColWeight = 0;
            for (int i = 0; i < mintColNum; i++)
            {
                fltTotalColWeight += mfltWidthWeights[i];
            }

            //3������ÿ��λ���п��п�
            if (mfltTotalTableWidth <= 0)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("�ܱ��={0}����ȷ���ܱ���ܵ���0��", mfltTotalTableWidth);
                throw new Exception(sbMsg.ToString());
            }
            mfltUnitColWidth = mfltTotalTableWidth / fltTotalColWeight;
            //4������ÿ���е��п��п�
            for (int i = 0; i < mintColNum; i++)
            {
                mfltCalcColWidth[i] = mfltUnitColWidth * mfltWidthWeights[i];
            }
            //5��У���п��п��Ƿ������С�п��п������������˳�
            bool bolIsValid = true;
            for (int i = 0; i < mintColNum; i++)
            {
                if (mfltMinWidths[i] > 0 && mfltCalcColWidth[i] < mfltMinWidths[i])
                {
                    bolIsValid = false;
                }
            }
            if (bolIsValid == true) return;
            //6���ų�������п���п���к��У����¼���ÿ��λ���п��п�
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

            //7�������ų�����п���п���к��У����¼���ÿ���е��п��п�

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
