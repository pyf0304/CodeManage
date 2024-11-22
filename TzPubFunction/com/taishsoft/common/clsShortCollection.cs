using System;
using System.Collections.Generic;
using System.Text;

namespace com.taishsoft.common
{
    /// <summary>
    /// ����������
    /// </summary>
    public class clsShortCollection
    {
        short[] mshtCollection;
        int mintCount = 0;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="intCount"></param>
        public clsShortCollection(int intCount)
        {
            mshtCollection = new short[intCount];
            mintCount = intCount;
        }
        // ��ȡ�����ð����ĵ��е��ַ�����������

        /// <summary>
        /// ����������index����ȡ������Ԫ��ֵ
        /// </summary>
        /// <param name="index">����</param>
        /// <returns>������Ԫ��ֵ</returns>
        public short this[int index]
        {
            get
            {
                if (index < 0 || index >=mintCount)
                {
                    throw new Exception("������" + index.ToString() + "������Χ��");
                }
                return mshtCollection[index];
            }
            set
            {
                if (index < 0 || index >=mintCount)
                {
                    throw new Exception("������" + index.ToString() + "������Χ��");
                }
                mshtCollection[index] = value;
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
        public short[] ToShortArray()
        {
            return mshtCollection;
        }
    }
}
