using System;
using System.Collections;
namespace com.taishsoft.common
{
    /// <summary>
    /// Bind_TrueOrFalse ��ժҪ˵����//
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
            // TODO: �ڴ˴���ӹ��캯���߼�
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
