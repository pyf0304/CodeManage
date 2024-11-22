using System;
using System.Collections;
namespace com.taishsoft.common
{
    /// <summary>
    /// Bind_TrueOrFalse 的摘要说明。//
    /// </summary>
    public class clsBoolObj_TrueOrFalse
    {
        /// <summary>
        /// 
        /// </summary>
        protected string mstrTrueOrFalse;
        /// <summary>
        /// 
        /// </summary>
        protected int iTrueOrFalse;
        /// <summary>
        /// 
        /// </summary>
        public clsBoolObj_TrueOrFalse()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
        /// <summary>
        /// 
        /// </summary>
        public int iFalseOrTrue
        {
            get
            {
                return iTrueOrFalse;
            }
            set
            {
                iTrueOrFalse = value;
            }
        }
        public string sTrueOrFalse
        {
            get
            {
                return mstrTrueOrFalse;
            }
            set
            {
                mstrTrueOrFalse = value;
            }
        }
    }
}
