using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.taishsoft.common
{
    /// <summary>
    /// 有关列表数组的处理函数集合
    /// </summary>
    public class clsArray
    {
        /// <summary>
        /// 根据列表获取SQL中的IN串
        /// </summary>
        /// <param name="arrValues">关键字列表</param>
        /// <param name="bolIsHaveQuote">是否有引号</param>
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
        /// 根据列表获取SQL中的IN串
        /// </summary>
        /// <param name="arrValues">关键字列表</param>
        /// <param name="bolIsHaveQuote">是否有引号</param>
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
        /// 根据列表获取SQL中的IN串
        /// </summary>
        /// <param name="arrValues">关键字列表</param>
        /// <param name="bolIsHaveQuote">是否有引号</param>
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
        /// 根据列表获取SQL中的IN串
        /// </summary>
        /// <param name="arrValues">关键字列表</param>
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
        /// 根据列表获取SQL中的IN串
        /// </summary>
        /// <param name="arrValues">关键字列表</param>
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
        /// 根据列表获取SQL中的IN串
        /// </summary>
        /// <param name="arrValues">关键字列表</param>
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
        /// 把列表拼接成字符串，并可以指定分隔串
        /// </summary>
        /// <param name="arrValues">关键字列表</param>
        /// <param name="strSplitStr">分隔串</param>
        /// <returns>组合成的字符串</returns>
        public static string Join(ArrayList arrValues, string strSplitStr)
        {
            string strInStr = "";
            string[] strValues = (string[])(arrValues.ToArray(System.Type.GetType("System.String")));
            strInStr = string.Join(strSplitStr, strValues);
            return strInStr;
        }

        /// <summary>
        /// 把列表(List《string》)拼接成字符串，并可以指定分隔串
        /// </summary>
        /// <param name="arrValues">关键字列表</param>
        /// <param name="strSplitStr">分隔串</param>
        /// <returns>组合成的字符串</returns>
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
        /// 把字符串列表转换为ArrayList
        /// </summary>
        /// <param name="arrString">原字符列表</param>
        /// <returns>ArrayList形式的字符列表</returns>
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
        /// 把ArrayList转换为字符串列表(list(string))
        /// </summary>
        /// <param name="arrString">原ArrayList列表</param>
        /// <returns>list(string)形式的字符列表</returns>
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
        /// 根据字符数组获取ArrayList
        /// </summary>
        /// <param name="strOrigin">源字符数组</param>
        /// <returns>获取的ArrayList数组</returns>
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
        /// 根据字符数组获取List_string
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
        /// 根据List<string>获取字符数组
        /// </summary>
        /// <param name="strOrigin">源字符数组</param>
        /// <returns>获取的List<string>数组</returns>
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
