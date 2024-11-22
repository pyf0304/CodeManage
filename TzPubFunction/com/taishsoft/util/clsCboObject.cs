using System;
using System.Collections.Generic;
using System.Text;

namespace com.taishsoft.util
{
    /// <summary>
    /// 下拉框对象类
    /// </summary>
    public class clsCboObject
    {
        /// <summary>
        /// 
        /// </summary>
        public clsCboObject()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strValue"></param>
        /// <param name="strText"></param>
        public clsCboObject(string strValue, string strText)
        {
            mstrValue = strValue;
            mstrText = strText;
        }
        private string mstrValue;
        /// <summary>
        /// 值
        /// </summary>
        public string Value
        {
            get { return mstrValue; }
            set { mstrValue = value; }
        }
        private string mstrText;
        /// <summary>
        /// 文本
        /// </summary>
        public string Text
        {
            get { return mstrText; }
            set { mstrText = value; }
        }
        /// <summary>
        /// 常量:"Text"
        /// </summary>
        public const string con_Text = "Text";    //文本

        /// <summary>
        /// 常量:"Value"
        /// </summary>
        public const string con_Value = "Value";    //值
    }
}
