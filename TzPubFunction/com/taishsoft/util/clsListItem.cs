using System;
using System.Collections.Generic;
using System.Text;

namespace com.taishsoft.util
{
    /// <summary>
    /// �����������
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
        /// ����:"Value"
        /// </summary>
        public const string con_Value = "Value";    //Value
        /// <summary>
        /// ����:"Text"
        /// </summary>
        public const string con_Text = "Text";    //Text

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
        /// ��ȡ����ȷ���������󡱵�ѡ���б���"T", "��ȷ"||"F", "����"��
        /// </summary>
        /// <returns></returns>
        public static List<clsListItem> GetTrueOrFalseLst()
        {
            List<clsListItem> arrListItemObjLst = new List<clsListItem>();
            arrListItemObjLst.Add(new clsListItem("T", "��ȷ"));
            arrListItemObjLst.Add(new clsListItem("F", "����"));
            return arrListItemObjLst;
        }
        /// <summary>
        /// ��ȡ��True������False����ѡ���б���"T", "True"||"F", "False"��
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
        /// ��ȡ���ǡ������񡱵�ѡ���б���"Y", "��"||"N", "��"��
        /// </summary>
        /// <returns></returns>
        public static List<clsListItem> GetYesOrNoLst()
        {
            List<clsListItem> arrListItemObjLst = new List<clsListItem>();
            arrListItemObjLst.Add(new clsListItem("Y", "��"));
            arrListItemObjLst.Add(new clsListItem("N", "��"));
            return arrListItemObjLst;
        }

    }
}
