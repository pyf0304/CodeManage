using System;
using System.Collections.Generic;
using System.Text;

namespace com.taishsoft.util
{
    /// <summary>
    /// �����������
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
        /// ֵ
        /// </summary>
        public string Value
        {
            get { return mstrValue; }
            set { mstrValue = value; }
        }
        private string mstrText;
        /// <summary>
        /// �ı�
        /// </summary>
        public string Text
        {
            get { return mstrText; }
            set { mstrText = value; }
        }
        /// <summary>
        /// ����:"Text"
        /// </summary>
        public const string con_Text = "Text";    //�ı�

        /// <summary>
        /// ����:"Value"
        /// </summary>
        public const string con_Value = "Value";    //ֵ
    }
}
