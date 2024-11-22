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
        // 获取和设置包含文档中的字符的索引器：
        public string this[int index]
        {
            get
            {
                if (index < 0 || index >=mintCount)
                {
                    throw new Exception("索引：" + index.ToString() + "超出范围！");
                }
                return mstrCollection[index];
            }
            set
            {
                if (index < 0 || index >=mintCount)
                {
                    throw new Exception("索引：" + index.ToString() + "超出范围！");
                }
                mstrCollection[index] = value;
            }
        }

        // 获取包含文档中字符的计数：
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
