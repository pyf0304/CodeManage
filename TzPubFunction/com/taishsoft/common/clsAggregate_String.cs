using System;
using System.Collections;
using System.Collections.Generic;

namespace com.taishsoft.common
{
	/// <summary>
	/// clsAggregate ��ժҪ˵����
	/// ����ר���ô���һЩ���Ϸ���ĺ���
	/// </summary>
	public partial class clsAggregate
	{
		
		/// <summary>
		/// ���������ϵĲ
		/// </summary>
		/// <param name="arrAllSet">ĸ������ԭ���������е�Ԫ��</param>
		/// <param name="arrSubSet">��ĳһ�Ӽ�</param>
		/// <returns>ĸ����ȥ�Ӽ��õ��Ĳ�</returns>
		public static List<string>  TwoAggrDiff(List<string>  arrAllSet, List<string>  arrSubSet)
		{
			List<string>  arrDiffSet = new List<string> ();	//��Ҫɾ���Ĳ˵���
			//�ҳ��޸ĺ��У���ԭ��û�У����Ϊ��Ҫ�����Ĳ˵���
            foreach (string obj in arrAllSet)
			{
				if (arrSubSet.Contains(obj) == false)
				{
					arrDiffSet.Add(obj);
				}
			}
			return arrDiffSet;
		}
        /// <summary>
        /// ���������ϵĲ���
        /// </summary>
        /// <param name="arrSetA">ĸ������ԭ���������е�Ԫ��</param>
        /// <param name="arrSetB">��ĳһ�Ӽ�</param>
        /// <returns>ĸ����ȥ�Ӽ��õ��Ĳ�</returns>
        public static void UniteTwoAggr(ref List<string>  arrSetA, List<string>  arrSetB)
        {
            //������B�����е�Ԫ�ض���ӵ�A������ȥ����󷵻�A����
            foreach (string  obj in arrSetB)
            {
                if (arrSetA.Contains(obj) == false)
                {
                    arrSetA.Add(obj);
                }
            }
            //			return arrSetA;
        }
        /// <summary>
        /// ���������ϵĽ���
        /// </summary>
        /// <param name="arrSetA">�Ӽ�A</param>
        /// <param name="arrSetB">�Ӽ�B</param>
        /// <returns>�����Ӽ��Ľ���</returns>
        public static List<string>  IntersectTwoAggr(List<string>  arrSetA, List<string>  arrSetB)
        {
            List<string>  arrNewSet = new List<string> ();
            //������B�����е�Ԫ�ض���ӵ�A������ȥ����󷵻�A����
            foreach (string obj in arrSetB)
            {
                if (arrSetA.Contains(obj) == true)
                {
                    arrNewSet.Add(obj);
                }
            }
            return arrNewSet;
        }
	}
}
