using System;
using System.Collections.Generic;
using System.Text;

namespace com.taishsoft.util
{
    /// <summary>
    /// 下拉框对象类
    /// </summary>
    public class clsListItem
    {
        /// <summary>
        /// 
        /// </summary>
        public clsListItem()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strValue"></param>
        /// <param name="strText"></param>
        public clsListItem(string strValue, string strText)
        {
            mstrValue = strValue;
            mstrText = strText;
        }
        /// <summary>
        /// 常量:"Value"
        /// </summary>
        public const string con_Value = "Value";    //Value
        /// <summary>
        /// 常量:"Text"
        /// </summary>
        public const string con_Text = "Text";    //Text

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
        /// 获取“正确”、“错误”的选项列表。（"T", "正确"||"F", "错误"）
        /// </summary>
        /// <returns></returns>
        public static List<clsListItem> GetTrueOrFalseLst()
        {
            List<clsListItem> arrListItemObjLst = new List<clsListItem>();
            arrListItemObjLst.Add(new clsListItem("T", "正确"));
            arrListItemObjLst.Add(new clsListItem("F", "错误"));
            return arrListItemObjLst;
        }
        /// <summary>
        /// 获取“True”、“False”的选项列表。（"T", "True"||"F", "False"）
        /// </summary>
        /// <returns></returns>
        public static List<clsListItem> GetTrueOrFalseLst_EN()
        {
            List<clsListItem> arrListItemObjLst = new List<clsListItem>();
            arrListItemObjLst.Add(new clsListItem("T", "True"));
            arrListItemObjLst.Add(new clsListItem("F", "False"));
            return arrListItemObjLst;
        }
        /// <summary>
        /// 获取“是”、“否”的选项列表。（"Y", "是"||"N", "否"）
        /// </summary>
        /// <returns></returns>
        public static List<clsListItem> GetYesOrNoLst()
        {
            List<clsListItem> arrListItemObjLst = new List<clsListItem>();
            arrListItemObjLst.Add(new clsListItem("Y", "是"));
            arrListItemObjLst.Add(new clsListItem("N", "否"));
            return arrListItemObjLst;
        }

    }
}
