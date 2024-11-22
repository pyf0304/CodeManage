using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.taishsoft.common
{
    /// <summary>
    /// �й��б�����Ĵ���������
    /// </summary>
    public class clsArray
    {
        /// <summary>
        /// �����б��ȡSQL�е�IN��
        /// </summary>
        /// <param name="arrValues">�ؼ����б�</param>
        /// <param name="bolIsHaveQuote">�Ƿ�������</param>
        /// <returns></returns>
        public static string GetSqlInStrByArray(ArrayList arrValues, bool bolIsHaveQuote)
        {
            StringBuilder sbInStr = new StringBuilder();
            string strInStr = "";
            if (bolIsHaveQuote == true)
            {
                foreach (string strValue in arrValues)
                {
                    if (string.IsNullOrEmpty(strValue.Trim()) == false)
                    {
                        sbInStr.AppendFormat("'{0}',", strValue);
                    }
                }
                strInStr = sbInStr.ToString();
                strInStr = strInStr.TrimEnd(',');
            }
            else
            {
                foreach (string strValue in arrValues)
                {
                    if (string.IsNullOrEmpty(strValue.Trim()) == false)
                    {
                        sbInStr.AppendFormat("{0},", strValue);
                    }
                }
                strInStr = sbInStr.ToString();
                strInStr = strInStr.TrimEnd(',');
            }
            return strInStr;
        }
        /// <summary>
        /// �����б��ȡSQL�е�IN��
        /// </summary>
        /// <param name="arrValues">�ؼ����б�</param>
        /// <param name="bolIsHaveQuote">�Ƿ�������</param>
        /// <returns></returns>
        public static string GetSqlInStrByArray(List<string > arrValues, bool bolIsHaveQuote)
        {
            StringBuilder sbInStr = new StringBuilder();
            string strInStr = "";
            if (bolIsHaveQuote == true)
            {
                foreach (string strValue in arrValues)
                {
                    if (string.IsNullOrEmpty(strValue.Trim()) == false)
                    {
                        sbInStr.AppendFormat("'{0}',", strValue);
                    }
                }
                strInStr = sbInStr.ToString();
                strInStr = strInStr.TrimEnd(',');
            }
            else
            {
                foreach (string strValue in arrValues)
                {
                    if (string.IsNullOrEmpty(strValue.Trim()) == false)
                    {
                        sbInStr.AppendFormat("{0},", strValue);
                    }
                }
                strInStr = sbInStr.ToString();
                strInStr = strInStr.TrimEnd(',');
            }
            return strInStr;
        }

        /// <summary>
        /// �����б��ȡSQL�е�IN��
        /// </summary>
        /// <param name="arrValues">�ؼ����б�</param>
        /// <param name="bolIsHaveQuote">�Ƿ�������</param>
        /// <returns></returns>
        public static string GetSqlInStrByArray(IEnumerable<string> arrValues, bool bolIsHaveQuote)
        {
            StringBuilder sbInStr = new StringBuilder();
            string strInStr = "";
            IEnumerable<string> arrValues_p = null;
            if (bolIsHaveQuote == true)
            {
                arrValues_p = arrValues.Select(x => string.Format("'{0}'", x));
                strInStr = string.Join(",", arrValues_p);
            }
            else
            {
                strInStr = string.Join(",", arrValues);
            }
            return strInStr;
        }


        /// <summary>
        /// �����б��ȡSQL�е�IN��
        /// </summary>
        /// <param name="arrValues">�ؼ����б�</param>
        /// <returns></returns>
        public static string GetSqlInStrByArray(List<long> arrValues)
        {
            StringBuilder sbInStr = new StringBuilder();
            string strInStr = "";

            foreach (long strValue in arrValues)
            {
                sbInStr.AppendFormat("{0},", strValue);   
            }
            strInStr = sbInStr.ToString();
            strInStr = strInStr.TrimEnd(',');
            
            return strInStr;
        }

        /// <summary>
        /// �����б��ȡSQL�е�IN��
        /// </summary>
        /// <param name="arrValues">�ؼ����б�</param>
        /// <returns></returns>
        public static string GetSqlInStrByArray(List<int> arrValues)
        {
            StringBuilder sbInStr = new StringBuilder();
            string strInStr = "";

            foreach (long strValue in arrValues)
            {
                sbInStr.AppendFormat("{0},", strValue);
            }
            strInStr = sbInStr.ToString();
            strInStr = strInStr.TrimEnd(',');

            return strInStr;
        }
        /// <summary>
        /// �����б��ȡSQL�е�IN��
        /// </summary>
        /// <param name="arrValues">�ؼ����б�</param>
        /// <returns></returns>
        public static string GetSqlInStrByArray(List<short> arrValues)
        {
            StringBuilder sbInStr = new StringBuilder();
            string strInStr = "";

            foreach (long strValue in arrValues)
            {
                sbInStr.AppendFormat("{0},", strValue);
            }
            strInStr = sbInStr.ToString();
            strInStr = strInStr.TrimEnd(',');

            return strInStr;
        }
        /// <summary>
        /// ���б�ƴ�ӳ��ַ�����������ָ���ָ���
        /// </summary>
        /// <param name="arrValues">�ؼ����б�</param>
        /// <param name="strSplitStr">�ָ���</param>
        /// <returns>��ϳɵ��ַ���</returns>
        public static string Join(ArrayList arrValues, string strSplitStr)
        {
            string strInStr = "";
            string[] strValues = (string[])(arrValues.ToArray(System.Type.GetType("System.String")));
            strInStr = string.Join(strSplitStr, strValues);
            return strInStr;
        }

        /// <summary>
        /// ���б�(List��string��)ƴ�ӳ��ַ�����������ָ���ָ���
        /// </summary>
        /// <param name="arrValues">�ؼ����б�</param>
        /// <param name="strSplitStr">�ָ���</param>
        /// <returns>��ϳɵ��ַ���</returns>
        public static string Join(List<string> arrValues, string strSplitStr)
        {
            string strInStr = "";
            //string[] strValues = (string[])(arrValues.ToArray(System.Type.GetType("System.String")));
            //strInStr = string.Join(strSplitStr, strValues);
            foreach (string strValue in arrValues)
            {
                strInStr += strValue + strSplitStr;
            }
            strInStr.TrimEnd(strSplitStr.ToCharArray());
            return strInStr;
        }
        /// <summary>
        /// ���ַ����б�ת��ΪArrayList
        /// </summary>
        /// <param name="arrString">ԭ�ַ��б�</param>
        /// <returns>ArrayList��ʽ���ַ��б�</returns>
        public static ArrayList CopyTo(List<string> arrString)
        {
            ArrayList arrLst = new ArrayList();
            foreach (string str in arrString)
            {
                arrLst.Add(str);
            }
            return arrLst;
        }

        /// <summary>
        /// ��ArrayListת��Ϊ�ַ����б�(list(string))
        /// </summary>
        /// <param name="arrString">ԭArrayList�б�</param>
        /// <returns>list(string)��ʽ���ַ��б�</returns>
        public static List<string > CopyArrayListToList_String(ArrayList arrString)
        {
            List<string> arrLst = new List<string>();
            foreach (string str in arrString)
            {
                arrLst.Add(str);
            }
            return arrLst;
        }
        /// <summary>
        /// �����ַ������ȡArrayList
        /// </summary>
        /// <param name="strOrigin">Դ�ַ�����</param>
        /// <returns>��ȡ��ArrayList����</returns>
        public static ArrayList GetArrayListByString(string[] strOrigin)
        {
            ArrayList aryResult = new ArrayList();
            try
            {
                for (int i = 0; i < strOrigin.Length; i++)
                {
                    aryResult.Add(strOrigin[i]);
                }
            }
            catch
            {
                aryResult = null;
            }
            return aryResult;
        }
       

        /// <summary>
        /// �����ַ������ȡList_string
        /// </summary>
        /// <param name="strOrigin"></param>
        /// <returns>List_string</returns>
        public static List<string> GetListByString(string[] strOrigin)
        {
            List<string> aryResult = new List<string>();
            try
            {
                for (int i = 0; i < strOrigin.Length; i++)
                {
                    aryResult.Add(strOrigin[i]);
                }
            }
            catch
            {
                aryResult = null;
            }
            return aryResult;
        }

        /// <summary>
        /// ����List<string>��ȡ�ַ�����
        /// </summary>
        /// <param name="strOrigin">Դ�ַ�����</param>
        /// <returns>��ȡ��List<string>����</returns>
        public static string[] GetStringSByList(   List<string> lstOrigin)
        {
            string[] sstrResult = new string[lstOrigin.Count];
            try
            {
                int i = 0;
                foreach (string ss in lstOrigin)
                {
                    sstrResult[i] = ss;
                    i++;
                }
            }
            catch(Exception objExccetion)
            {
                sstrResult = null;
            }
            return sstrResult;
        }
    }
}
