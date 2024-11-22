using System;
using System.Collections.Generic;
using System.Text;

namespace com.taishsoft.common
{
    /// <summary>
    /// 
    /// </summary>
    public class clsBoolCollection
    {
        bool [] mbolCollection;
        int mintCount = 0;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="intCount"></param>
        public clsBoolCollection(int intCount)
        {
            mbolCollection = new bool[intCount];
            mintCount = intCount;
        }
  
        /// <summary>
        /// ��ȡ�����ð����ĵ��е��ַ���������
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool this[int index] 
        {
            get 
            {
                if (index < 0 || index > mintCount)
                {
                    throw new Exception("������" + index.ToString() + "������Χ��");
                }
                return mbolCollection[index]; 
            }
            set 
            {
                if (index < 0 || index > mintCount)
                {
                    throw new Exception("������" + index.ToString() + "������Χ��");
                }
                mbolCollection[index] = value; 
            }
        }

  
        /// <summary>
        /// ��ȡ�����ĵ����ַ��ļ���
        /// </summary>
        public int Count 
        {
            get 
            { 
                return mintCount; 
            }
        }
    }
}
