using System;

namespace com.taishsoft.common
{
	/// <summary>
	/// clsDataTypeTrans 的摘要说明。
	/// 该类主要用于：数据类型转换
	/// </summary>
	public class clsDataTypeTrans
	{
		public clsDataTypeTrans()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}
		/// <summary>
		/// 浮点型-->格式字符串
		/// </summary>
		/// <param name="fltValue">浮点型值</param>
		/// <param name="intPrecision">小数位数</param>
		/// <returns></returns>
		public static string FloatToStr(float fltValue, int intPrecision)
		{
			//算法：
			//1、把浮点型值乘以10的小数位数方，例如1位就乘以100,3位就乘以10000；
			//2、把浮点值转换成整型值
			
			if (intPrecision<0)
			{
				return "";
			}
			float fltValuePostDot;//小数点后的浮点型值
			int intValuePreDot;//小数点前的值
			int intValuePostDot;//小数点后的值
			int intSign;//传进来的浮点数正负号
			if (fltValue>=0.0f)
			{
				intSign = 1;
			}
			else
			{
				intSign = -1;
				fltValue = fltValue * -1.0f;
			}
			intValuePreDot = (int)fltValue;
			fltValuePostDot = fltValue - intValuePreDot;
			string strValue = "";
			float fltMidValue = 0.0f;//中间浮点型值
			int intMidValue;
			if (intPrecision == 0)
			{
				return intSign.ToString() + intValuePreDot.ToString();
			}
			else if (intPrecision >0)
			{
				//小数点后值乘以多个10
				fltMidValue = fltValuePostDot;
				for(int i = 1; i <= intPrecision+1; i++)
				{
					fltMidValue = fltMidValue * 10.0f;
				}			
				//把浮点小数转换成相应的整型值
				intMidValue = (int)fltMidValue;
				intValuePostDot = intMidValue / 10;
				if (intMidValue % 10 >=5)
				{
					intValuePostDot = intValuePostDot+1;
				}
				string strValuePostDot = intValuePostDot.ToString();
				if (strValuePostDot.Length < intPrecision)
				{
					int iTemp = intPrecision - strValuePostDot.Length;
					for(int i=0; i<iTemp; i++)
					{
						strValuePostDot = "0" + strValuePostDot;
					}
				}
				if (intSign >0)
				{
					strValue = intValuePreDot.ToString() + "." + strValuePostDot;
				}
				else
				{
					strValue = "-" + intValuePreDot.ToString() + "." + strValuePostDot;
				}
				return strValue;
			}
			return "";
		}
	}
}
