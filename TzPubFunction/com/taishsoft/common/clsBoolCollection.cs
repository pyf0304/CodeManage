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
        /// 获取和设置包含文档中的字符的索引器
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool this[int index] 
        {
            get 
            {
                if (index < 0 || index > mintCount)
                {
                    throw new Exception("索引：" + index.ToString() + "超出范围！");
                }
                return mbolCollection[index]; 
            }
            set 
            {
                if (index < 0 || index > mintCount)
                {
                    throw new Exception("索引：" + index.ToString() + "超出范围！");
                }
                mbolCollection[index] = value; 
            }
        }

  
        /// <summary>
        /// 获取包含文档中字符的计数
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
