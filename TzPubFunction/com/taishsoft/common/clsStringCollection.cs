using System;
using System.Collections.Generic;
using System.Text;

namespace com.taishsoft.common
{
    public class clsStringCollection
    {
        string[] mstrCollection;
        int mintCount = 0;
        public clsStringCollection(int intCount)
        {
            mstrCollection = new string[intCount];
            mintCount = intCount;
        }
        // ��ȡ�����ð����ĵ��е��ַ�����������
        public string this[int index]
        {
            get
            {
                if (index < 0 || index >=mintCount)
                {
                    throw new Exception("������" + index.ToString() + "������Χ��");
                }
                return mstrCollection[index];
            }
            set
            {
                if (index < 0 || index >=mintCount)
                {
                    throw new Exception("������" + index.ToString() + "������Χ��");
                }
                mstrCollection[index] = value;
            }
        }

        // ��ȡ�����ĵ����ַ��ļ�����
        public int Count
        {
            get
            {
                return mintCount;
            }
        }
        public string[] ToStringArray()
        {
            return mstrCollection;
        }
    }
}
