using System;
using System.Collections.Generic;
using System.Text;

namespace com.taishsoft.common
{
    /// <summary>
    /// 字符串比较，忽略大小写
    /// </summary>
    public class clsStrCompareIgnoreCase : IEqualityComparer<string>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        public bool Equals(string t1, string t2)
        {
            return (t1.Equals(t2, StringComparison.OrdinalIgnoreCase));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int GetHashCode(string t)
        {
            return t.ToString().GetHashCode();
        }
    }
}
