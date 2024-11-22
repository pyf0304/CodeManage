using System;

namespace com.taishsoft.common
{
	/// <summary>
	/// clsDataTypeTrans ��ժҪ˵����
	/// ������Ҫ���ڣ���������ת��
	/// </summary>
	public class clsDataTypeTrans
	{
		public clsDataTypeTrans()
		{
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
			//
		}
		/// <summary>
		/// ������-->��ʽ�ַ���
		/// </summary>
		/// <param name="fltValue">������ֵ</param>
		/// <param name="intPrecision">С��λ��</param>
		/// <returns></returns>
		public static string FloatToStr(float fltValue, int intPrecision)
		{
			//�㷨��
			//1���Ѹ�����ֵ����10��С��λ����������1λ�ͳ���100,3λ�ͳ���10000��
			//2���Ѹ���ֵת��������ֵ
			
			if (intPrecision<0)
			{
				return "";
			}
			float fltValuePostDot;//С�����ĸ�����ֵ
			int intValuePreDot;//С����ǰ��ֵ
			int intValuePostDot;//С������ֵ
			int intSign;//�������ĸ�����������
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
			float fltMidValue = 0.0f;//�м両����ֵ
			int intMidValue;
			if (intPrecision == 0)
			{
				return intSign.ToString() + intValuePreDot.ToString();
			}
			else if (intPrecision >0)
			{
				//С�����ֵ���Զ��10
				fltMidValue = fltValuePostDot;
				for(int i = 1; i <= intPrecision+1; i++)
				{
					fltMidValue = fltMidValue * 10.0f;
				}			
				//�Ѹ���С��ת������Ӧ������ֵ
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
