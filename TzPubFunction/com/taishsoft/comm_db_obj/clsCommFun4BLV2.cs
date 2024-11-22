using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.taishsoft.comm_db_obj
{
    /// <summary>
    /// 针对业务逻辑层的一些公共函数类，必须经继承后才能使用。
    /// </summary>
    public abstract class clsCommFun4BLV2
    {
        ///// <summary>
        ///// 重新刷新缓存的函数
        ///// </summary>
        //public abstract void ReFreshCache();
        /// <summary>
        /// 重新刷新缓存的函数
        /// </summary>
        /// <param name="strCacheClassifyField">缓存分类字段</param>
        public abstract void ReFreshCache(string strCacheClassifyField = "");
        ///// <summary>
        ///// 重新刷新缓存的函数
        ///// </summary>
        ///// <param name="intCacheClassifyField">缓存分类字段</param>
        //public abstract void ReFreshCache(int intCacheClassifyField);
        ///// <summary>
        ///// 重新刷新缓存的函数
        ///// </summary>
        ///// <param name="lngCacheClassifyField">缓存分类字段</param>
        //public abstract void ReFreshCache(long lngCacheClassifyField);
    }
}
