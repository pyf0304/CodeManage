using System;
using System.Collections.Generic;
using System.Text;

namespace com.taishsoft.common
{
    /// <summary>
    /// 整数集合
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
        // 获取和设置包含文档中的字符的索引器：

        /// <summary>
        /// 根据索引（index）获取集合中元素值
        /// </summary>
        /// <param name="index">索引</param>
        /// <returns>集合中元素值</returns>
        public int this[int index]
        {
            get
            {
                if (index < 0 || index >=mintCount)
                {
                    throw new Exception("索引：" + index.ToString() + "超出范围！");
                }
                return mintCollection[index];
            }
            set
            {
                if (index < 0 || index >=mintCount)
                {
                    throw new Exception("索引：" + index.ToString() + "超出范围！");
                }
                mintCollection[index] = value;
            }
        }

        // 获取包含文档中字符的计数：

        /// <summary>
        /// 集合中元素个数
        /// </summary>
        public int Count
        {
            get
            {
                return mintCount;
            }
        }
        /// <summary>
        /// 导出整数集合
        /// </summary>
        /// <returns></returns>
        public int[] ToIntArray()
        {
            return mintCollection;
        }
    }
}
