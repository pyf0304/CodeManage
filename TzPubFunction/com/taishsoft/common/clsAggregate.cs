using System;
using System.Collections;

namespace com.taishsoft.common
{
	/// <summary>
	/// clsAggregate ��ժҪ˵����
	/// ����ר���ô���һЩ���Ϸ���ĺ���
	/// </summary>
	public partial class clsAggregate
	{
        /// <summary>
        /// 
        /// </summary>
		public clsAggregate()
		{
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
			//
		}
		/// <summary>
		/// ���������ϵĲ
		/// </summary>
		/// <param name="arrAllSet">ĸ������ԭ���������е�Ԫ��</param>
		/// <param name="arrSubSet">��ĳһ�Ӽ�</param>
		/// <returns>ĸ����ȥ�Ӽ��õ��Ĳ�</returns>
		public static ArrayList TwoAggrDiff(ArrayList arrAllSet, ArrayList arrSubSet)
		{
			ArrayList arrDiffSet = new ArrayList();	//��Ҫɾ���Ĳ˵���
			//�ҳ��޸ĺ��У���ԭ��û�У����Ϊ��Ҫ�����Ĳ˵���
			foreach ( object obj in arrAllSet)
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
        public static void UniteTwoAggr(ref ArrayList arrSetA, ArrayList arrSetB)
        {
            //������B�����е�Ԫ�ض���ӵ�A������ȥ����󷵻�A����
            foreach (object obj in arrSetB)
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
        public static ArrayList IntersectTwoAggr(ArrayList arrSetA, ArrayList arrSetB)
        {
            ArrayList arrNewSet = new ArrayList();
            //������B�����е�Ԫ�ض���ӵ�A������ȥ����󷵻�A����
            foreach (object obj in arrSetB)
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
