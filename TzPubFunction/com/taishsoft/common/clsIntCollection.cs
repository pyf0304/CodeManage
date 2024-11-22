using System;
using System.Collections.Generic;
using System.Text;

namespace com.taishsoft.common
{
    /// <summary>
    /// ��������
    /// </summary>
    public class clsIntCollection
    {
        int[] mintCollection;
        int mintCount = 0;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="intCount"></param>
        public clsIntCollection(int intCount)
        {
            mintCollection = new int[intCount];
            mintCount = intCount;
        }
        // ��ȡ�����ð����ĵ��е��ַ�����������

        /// <summary>
        /// ����������index����ȡ������Ԫ��ֵ
        /// </summary>
        /// <param name="index">����</param>
        /// <returns>������Ԫ��ֵ</returns>
        public int this[int index]
        {
            get
            {
                if (index < 0 || index >=mintCount)
                {
                    throw new Exception("������" + index.ToString() + "������Χ��");
                }
                return mintCollection[index];
            }
            set
            {
                if (index < 0 || index >=mintCount)
                {
                    throw new Exception("������" + index.ToString() + "������Χ��");
                }
                mintCollection[index] = value;
            }
        }

        // ��ȡ�����ĵ����ַ��ļ�����

        /// <summary>
        /// ������Ԫ�ظ���
        /// </summary>
        public int Count
        {
            get
            {
                return mintCount;
            }
        }
        /// <summary>
        /// ������������
        /// </summary>
        /// <returns></returns>
        public int[] ToIntArray()
        {
            return mintCollection;
        }
    }
}
