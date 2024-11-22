using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace com.taishsoft.common
{
    /// <summary>
    /// 正则表达式类的摘要说明
    /// </summary>

    public class clsCommonRegular
    {
        /// <summary>
        /// 电子邮件校验常量
        /// </summary>
        public const String REGEXP_IS_VALID_EMAIL = @"^\w+((-\w+)|(\.\w+))*\@\w+((\.|-)\w+)*\.\w+$";  //电子邮件校验常量
        /// <summary>
        /// 网址校验常量
        /// </summary>
        public const String REGEXP_IS_VALID_URL = @"^http://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?";    //网址校验常量
        /// <summary>
        /// 邮编校验常量
        /// </summary>
        public const String REGEXP_IS_VALID_ZIP = @"\d{6}";     //邮编校验常量
        /// <summary>
        /// 身份证校验常量
        /// </summary>
        public const String REGEXP_IS_VALID_SSN = @"\d{18}|\d{15}";    //身份证校验常量 
        /// <summary>
        /// 整数校验常量
        /// </summary>
        public const String REGEXP_IS_VALID_INT = @"^\d{1,}$";     //整数校验常量
        /// <summary>
        /// HEML解码校验
        /// </summary>
        public const String REGEXP_IS_DECODE_HTML = @"&lt;(.*)&gt;.*&lt;\/\1&gt;|&lt;(.*) \/&gt;";    //整数校验常量
        /// <summary>
        /// 浮点数校验（数值校验常量）
        /// </summary>
        public const String REGEXP_IS_VALID_DEMICAL = @"^-?(0|\d+)(\.\d+)?$";    //数值校验常量 "
        /// <summary>
        /// 是否是HTML代码
        /// </summary>
        public const String REGEXP_IS_HTML = @"<(.*)>.*<\/\1>|<(.*) \/>";
        /// <summary>
        /// 字符、数字、下划线检验常量
        /// </summary>
        public const String REGEXP_TEXT = @"\w+$";//字符、数字、下划线检验常量
        /// <summary>
        /// 数字检验
        /// </summary>
        public const String REGEXP_TEXT_NUM = @"^\d+$";
        /// <summary>
        /// 汉字
        /// </summary>
        public const String REGEXP_TEXT_CHINESE = @"^[\u4E00-\u9FA5]+$";
        /// <summary>
        /// 非字符数字
        /// </summary>
        public const String REGEXP_TEXT_NOT_LETTER_NUM = @"\W+$";
        /// <summary>
        /// 汉字字母
        /// </summary>
        public const String REGEXP_TEXT_CHINESE_LETTER_NUM = @"^[\u4E00-\u9FA5A-Za-z0-9]+$";
        /// <summary>
        /// 汉字字符数字非下划线
        /// </summary>
        public const String REGEXP_TEXT_CHINEST_LETTER_NUM_UNDERLINE = @"[\u4e00-\u9fa5A-Za-z0-9_]+$";
        /// <summary>
        /// 汉字字符数字下划线
        /// </summary>
        public const String REGEXP_TEXT_CHINEST_LETTER_NUM_LINE = @"[\u4e00-\u9fa5A-Za-z0-9_@#$%^&*?]+$";
        //日期校验常量
        public const String REGEXP_IS_VALID_DATE = @"^(?:(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00)))(\/|-|\.)(?:0?2\1(?:29))$)|(?:(?:1[6-9]|[2-9]\d)?\d{2})(\/|-|\.)(?:(?:(?:0?[13578]|1[02])\2(?:31))|(?:(?:0?[1,3-9]|1[0-2])\2(29|30))|(?:(?:0?[1-9])|(?:1[0-2]))\2(?:0?[1-9]|1\d|2[0-8]))$";

        /// <summary>
        /// 
        /// </summary>
        public clsCommonRegular()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }

        #region 校验给定的值格式与电子邮箱是否相符

        /// <summary>
        /// 校验给定的值格式与电子邮箱是否相符
        /// </summary>
        /// <param name="SrcEmail"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static bool IsValidEmail(string SrcEmail, ref string Error)
        {
            if (string.IsNullOrEmpty(SrcEmail))
            {
                Error = "邮箱不能为空！";
            }
            bool isValid = (new Regex(REGEXP_IS_VALID_EMAIL)).IsMatch(SrcEmail);
            if (!isValid)
            {
                Error = "邮箱格式不正确！";
                return false;
            }
            return true;
        }
        #endregion

        #region 校验给定的值格式与邮编是否相符

        /// <summary>
        /// 校验给定的值格式与邮编是否相符
        /// </summary>
        /// <param name="SrcZip"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static bool IsValidZip(string SrcZip, ref string Error)
        {
            if (string.IsNullOrEmpty(SrcZip))
            {
                Error = "邮编不能为空！";
            }
            bool isValid = (new Regex(REGEXP_IS_VALID_ZIP)).IsMatch(SrcZip);
            if (!isValid)
            {
                Error = "邮编格式不正确！";
                return false;
            }
            return true;
        }
        #endregion

        #region 校验给定的值格式与身份证是否相符
        /// <summary>
        /// 校验给定的值格式与身份证是否相符
        /// </summary>
        /// <param name="SrcSSNField"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static bool IsValidSSN(string SrcSSNField, ref string Error)
        {
            if (string.IsNullOrEmpty(SrcSSNField))
            {
                Error = "身份证不能为空！";
            }
            bool isValid = (new Regex(REGEXP_IS_VALID_SSN)).IsMatch(SrcSSNField);
            if (!isValid)
            {
                Error = "身份证格式不正确！";
                return false;
            }
            return true;
        }
        #endregion

        #region 校验给定的值格式与URL是否相符
        /// <summary>
        /// 判断给定的值格式与URL是否相符
        /// </summary>
        /// <param name="ErrorField"></param>
        /// <returns></returns>
        public static string GetUrlFieldError(string ErrorField)
        {
            return ErrorField + "格式不正确http://www.abc.com)！";
        }
        public static bool IsValidUrl(string SrcUrl, ref string Error)
        {
            if (string.IsNullOrEmpty(SrcUrl))
            {
                Error = "URL不能为空！";
            }
            bool isValid = (new Regex(REGEXP_IS_VALID_URL)).IsMatch(SrcUrl);
            if (!isValid)
            {
                Error = "URL格式不正确！";
                return false;
            }
            return true;
        }
        #endregion

        #region 校验给定的值是否为日期类型
        /// <summary>
        /// 判断给定的是否为日期类型
        /// </summary>
        /// <param name="SrcDate">给定的字符串</param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static bool IsValidDate(string SrcDate, ref string Error)
        {
            if (string.IsNullOrEmpty(SrcDate))
            {
                Error = "日期不能为空！";
            }
            bool isValid = (new Regex(REGEXP_IS_VALID_DATE)).IsMatch(SrcDate);
            if (!isValid)
            {
                Error = "日期格式不正确！";
                return false;
            }
            return true;
        }
        #endregion

        #region 校验给定的是否为数值型
        /// <summary>
        /// 判断给定的是否为数值型
        /// </summary>
        /// <param name="SrcNumber"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static bool IsValidNumber(string SrcNumber, ref string Error)
        {
            if (string.IsNullOrEmpty(SrcNumber))
            {
                Error = "数值不能为空！";
            }
            bool isValid = (new Regex(REGEXP_IS_VALID_DEMICAL)).IsMatch(SrcNumber);
            if (!isValid)
            {
                Error = "不是数值型！";
                return false;
            }
            return true;
        }
        #endregion

        #region 去除含有HTML的数据
        /// <summary>
        /// 去除含有HTML的数据
        /// </summary>
        /// <param name="SrcHTML"></param>
        /// <returns></returns>
        public static string ReplaceHTML(string SrcHTML)
        {
            Regex rg = new Regex(REGEXP_IS_HTML);
            return rg.Replace(SrcHTML, "");
        }
        #endregion

        #region 去除含有HTML的数据
        /// <summary>
        /// 去除含有HTML的数据
        /// </summary>
        /// <param name="SrcHTML"></param>
        /// <returns></returns>
        public static string ReplaceDECODEHTML(string SrcHTML)
        {
            Regex rg = new Regex(REGEXP_IS_DECODE_HTML);
            return rg.Replace(SrcHTML, "");
        }
        #endregion


        #region 校验给定的字符串含有SQL注入
        /// <summary>
        /// 校验给定的字符串含有SQL注入-强检查
        /// </summary>
        /// <param name="strSQLWhere">供检查的源字符串</param>
        /// <returns>检查结果，如果有注入就返回TRUE，否则返回FALSE</returns>
        public static bool CheckStrSQL_strong(string strSQLWhere)
        {
            //Regex rg = new Regex(REGEXP_IS_DECODE_HTML);
            bool bo = true;
            strSQLWhere = strSQLWhere.ToLower();
            if (strSQLWhere.Contains("*"))
            {
                throw new Exception("SQL注入:'*'");
            }
            if (strSQLWhere.Contains(";"))
            {
                throw new Exception("SQL注入:';'");
            }
            if (strSQLWhere.Contains("<"))
            {
                throw new Exception("SQL注入:'<'");
            }
            if (strSQLWhere.Contains(">"))
            {
                throw new Exception("SQL注入:'>'");
            }
            if (strSQLWhere.Contains("&"))
            {
                throw new Exception("SQL注入:'&'");
            }
            if (strSQLWhere.Contains("or "))
            {
                throw new Exception("SQL注入:'or'");
            }
            if (strSQLWhere.Contains("drop"))
            {
                throw new Exception("SQL注入:'drop'");
            }
            if (strSQLWhere.Contains("delete"))
            {
                throw new Exception("SQL注入:'delete'");
            }
            if (strSQLWhere.Contains("exec"))
            {
                throw new Exception("SQL注入:'exec'");
            }
            if (strSQLWhere.Contains("insert"))
            {
                throw new Exception("SQL注入:'insert'");
            }
            if (strSQLWhere.Contains("update"))
            {
                throw new Exception("SQL注入:'update'");
            }
            if (strSQLWhere.Contains("count"))
            {
                throw new Exception("SQL注入:'count'");
            }
            if (strSQLWhere.Contains("chr"))
            {
                throw new Exception("SQL注入:'chr'");
            }
            if (strSQLWhere.Contains("char"))
            {
                throw new Exception("SQL注入:'char'");
            }
            if (strSQLWhere.Contains("javascript"))
            {
                throw new Exception("SQL注入:'javascript'");
            }
            if (strSQLWhere.Contains("master"))
            {
                throw new Exception("SQL注入:'master'");
            }
            if (strSQLWhere.Contains("src"))
            {
                throw new Exception("SQL注入:'src'");
            }
            if (strSQLWhere.Contains("http"))
            {
                throw new Exception("SQL注入:'http'");
            }
            if (strSQLWhere.Contains("like"))
            {
                throw new Exception("SQL注入:'like'");
            }
            if (strSQLWhere.Contains("truncate"))
            {
                throw new Exception("SQL注入:'truncate'");
            }
            if (strSQLWhere.Contains("declare"))
            {
                throw new Exception("SQL注入:'declare'");
            }
            if (strSQLWhere.Contains("create"))
            {
                throw new Exception("SQL注入:'create'");
            }
            if (strSQLWhere.Contains("waitfor"))
            {
                throw new Exception("SQL注入:'waitfor'");
            }
            if (strSQLWhere.Contains("alter"))
            {
                throw new Exception("SQL注入:'alter'");
            }

            if (strSQLWhere.Contains("("))
            {
                throw new Exception("SQL注入:'('");
            }
            if (strSQLWhere.Contains(")"))
            {
                throw new Exception("SQL注入:')'");
            }
            if (strSQLWhere.Contains("%"))
            {
                throw new Exception("SQL注入:'%'");
            }
            if (strSQLWhere.Contains("where"))
            {
                throw new Exception("SQL注入:'where'");
            }
            if (strSQLWhere.Contains("or ")
                )
            {
                throw new Exception("SQL注入:'or'");
            }
            if (strSQLWhere.Contains("master"))
            {
                throw new Exception("SQL注入:'master'");
            }
            if (strSQLWhere.Contains("like"))
            {
                throw new Exception("SQL注入:'like'");
            }
            if (strSQLWhere.Contains("'"))
            {
                throw new Exception("SQL注入:'非法单引号'");
            }
            bo = false;
            return bo;
        }

        /// <summary>
        /// 校验给定的字符串含有SQL注入
        /// </summary>
        /// <param name="strSQLWhere">供检查的源字符串</param>
        /// <returns>检查结果，如果有注入就返回TRUE，否则返回FALSE</returns>
        public static bool CheckStrSQL(string strSQLWhere)
        {
            //Regex rg = new Regex(REGEXP_IS_DECODE_HTML);
            bool bo = true;
            strSQLWhere = strSQLWhere.ToLower();
            strSQLWhere = clsString.RemoveStringValueInSingleQuotation(strSQLWhere);
            if (strSQLWhere.Contains("*"))
            {
                throw new Exception("SQL注入:'*'");
            }
            if (strSQLWhere.Contains(";"))
            {
                throw new Exception("SQL注入:';'");
            }
            //if (strSQLWhere.Contains("<"))
            //{
            //    throw new Exception("SQL注入:'<'");
            //}
            //if (strSQLWhere.Contains(">"))
            //{
            //    throw new Exception("SQL注入:'>'");
            //}
            if (strSQLWhere.Contains("&"))
            {
                throw new Exception("SQL注入:'&'");
            }
            if (strSQLWhere.Contains("or "))
            {
                throw new Exception("SQL注入:'or'");
            }
            if (strSQLWhere.Contains("drop"))
            {
                throw new Exception("SQL注入:'drop'");
            }
            if (strSQLWhere.Contains("delete "))
            {
                throw new Exception("SQL注入:'delete'");
            }
            if (strSQLWhere.Contains("exec "))
            {
                throw new Exception("SQL注入:'exec'");
            }
            if (strSQLWhere.Contains("insert"))
            {
                throw new Exception("SQL注入:'insert'");
            }
            if (strSQLWhere.Contains("update"))
            {
                throw new Exception("SQL注入:'update'");
            }
            if (strSQLWhere.Contains("count"))
            {
                throw new Exception("SQL注入:'count'");
            }
            if (strSQLWhere.Contains("chr"))
            {
                throw new Exception("SQL注入:'chr'");
            }
            if (strSQLWhere.Contains("char"))
            {
                throw new Exception("SQL注入:'char'");
            }
            if (strSQLWhere.Contains("javascript"))
            {
                throw new Exception("SQL注入:'javascript'");
            }
            if (strSQLWhere.Contains("master"))
            {
                throw new Exception("SQL注入:'master'");
            }
            if (strSQLWhere.Contains("src"))
            {
                throw new Exception("SQL注入:'src'");
            }
            if (strSQLWhere.Contains("http"))
            {
                throw new Exception("SQL注入:'http'");
            }
            if (strSQLWhere.Contains("like"))
            {
                throw new Exception("SQL注入:'like'");
            }
            if (strSQLWhere.Contains("truncate"))
            {
                throw new Exception("SQL注入:'truncate'");
            }
            if (strSQLWhere.Contains("declare"))
            {
                throw new Exception("SQL注入:'declare'");
            }
            if (strSQLWhere.Contains("create "))
            {
                throw new Exception("SQL注入:'create'");
            }
            if (strSQLWhere.Contains("waitfor"))
            {
                throw new Exception("SQL注入:'waitfor'");
            }
            if (strSQLWhere.Contains("alter"))
            {
                throw new Exception("SQL注入:'alter'");
            }

            //if (strSQLWhere.Contains("("))
            //{
            //    throw new Exception("SQL注入:'('");
            //}
            //if (strSQLWhere.Contains(")"))
            //{
            //    throw new Exception("SQL注入:')'");
            //}
            if (strSQLWhere.Contains("%"))
            {
                throw new Exception("SQL注入:'%'");
            }
            if (strSQLWhere.Contains("where"))
            {
                throw new Exception("SQL注入:'where'");
            }
            if (strSQLWhere.Contains("or ")
                )
            {
                throw new Exception("SQL注入:'or'");
            }
            if (strSQLWhere.Contains("master"))
            {
                throw new Exception("SQL注入:'master'");
            }
            if (strSQLWhere.Contains("like"))
            {
                throw new Exception("SQL注入:'like'");
            }
            bo = false;
            return bo;
        }
        /// <summary>
        /// 获取组装后的排除串。例如：源串“or|delete”,组合后的串：“[exclude]or|delete[/exclude]”
        /// </summary>
        /// <param name="strSource">源串</param>
        /// <returns>以组装后排除串</returns>
        public static string GetExcludeStr(string strSource)
        {
            if (string.IsNullOrEmpty( strSource) == true) return "";
            return string.Format("[exclude]{0}[/exclude]", strSource);
        }

        /// <summary>
        /// 校验给定的字符串含有SQL注入,弱检查，不检查Select
        /// </summary>
        /// <param name="strSQLWhere">供检查的源字符串</param>
        /// <returns>检查结果，如果有注入就返回TRUE，否则返回FALSE</returns>
        public static bool CheckStrSQL_Weak(string strSQLWhere)
        {

            bool bo = true;
            string strElementValue = clsString.GetElementValue(strSQLWhere, "exclude");

            string[] sstrExclude = null;
            if (string.IsNullOrEmpty(strElementValue) == false)
            {
                List<string> lstExclude = new List<string>();
                sstrExclude = strElementValue.Split('|');
                foreach (string strExclude in sstrExclude)
                {
                    lstExclude.Add(strExclude);
                }
                strSQLWhere = clsString.RemoveElementValue(strSQLWhere, "exclude");
                return CheckStrSQL_Weak(strSQLWhere, lstExclude);
            }
            strSQLWhere = strSQLWhere.ToLower();
            strSQLWhere = clsString.RemoveStringValueInSingleQuotation(strSQLWhere);
            
            List<string> lstCheckStr = new List<string>();

            lstCheckStr.Add("*");
            lstCheckStr.Add(";");
            lstCheckStr.Add("&");
            lstCheckStr.Add("or ");
            lstCheckStr.Add("drop ");
            lstCheckStr.Add("delete");
            lstCheckStr.Add("exec ");
            lstCheckStr.Add("insert ");
            lstCheckStr.Add("update ");
            lstCheckStr.Add("count(");
            lstCheckStr.Add("count (");
            lstCheckStr.Add("char");
            lstCheckStr.Add("javascript");
            lstCheckStr.Add("master");
            //lstCheckStr.Add("like");
            lstCheckStr.Add("truncate");
            lstCheckStr.Add("declare");
            lstCheckStr.Add("create ");
            lstCheckStr.Add("waitfor");
            lstCheckStr.Add("alter");
            lstCheckStr.Add("sleep");

            foreach (string strCheckItem in lstCheckStr)
            {
                if (strSQLWhere.Contains(strCheckItem))
                {
                    int intIndex = strSQLWhere.IndexOf(strCheckItem);
                    bool bolIsSqlIn = true;
                    while (intIndex >= 0)
                    {
                        string strPrevChar = strSQLWhere.Substring(intIndex - 1, 1);
                        if (clsString.IsLetter(strPrevChar) == true)
                        {
                            bolIsSqlIn = false;
                            intIndex = strSQLWhere.IndexOf(strCheckItem, intIndex+1);

                        }
                        else
                        {
                            bolIsSqlIn = true;
                            break;
                        }
                    }
                    if (bolIsSqlIn == false) continue;
                    if (clsSysPara_TzPubFunction.AppType == "WEBAPP")
                    {
                        throw new Exception(string.Format("SQL注入:'{0}'", strCheckItem));
                    }
                    if (DetailCheckOr(strSQLWhere) == true)
                    {
                        throw new Exception(string.Format("SQL注入:'{0}'", strCheckItem));
                    }
                }
            }
            bo = false;
            return bo;
        }
        /// <summary>
        /// 详细检查'or '
        /// </summary>
        /// <param name="?"></param>
        /// <returns></returns>
        private static bool DetailCheckOr(string strSQLWhere)
        {
            string strWhere = strSQLWhere.Replace("or =", "");
            if (strWhere.Contains("or ") == false)
            {
                return false;
            }
            int iIndex = strWhere.IndexOf("or ");
            while (iIndex >= 1 && strWhere.Contains("or ") == true)
            {
                int iIndex2 = iIndex - 1;
                string strPrevChar = strWhere.Substring(iIndex2, 1);
                if (strPrevChar == ")" || strPrevChar == " ") return true;
                string strWhere1 = strWhere.Substring(0, iIndex);
                string strWhere2 = strWhere.Substring(iIndex+2);
                strWhere = strWhere1 + strWhere2;
                iIndex = strWhere.IndexOf("or ");
            }
            return false;
        }
        /// <summary>
        /// 校验给定的字符串含有SQL注入,弱检查，不检查Select
        /// </summary>
        /// <param name="strSQLWhere">供检查的源字符串</param>
        /// <param name="lstExclude">排除的检查字符串列表</param>
        /// <returns>检查结果，如果有注入就返回TRUE，否则返回FALSE</returns>
        public static bool CheckStrSQL_Weak(string strSQLWhere, List<string> lstExclude)
        {

            bool bo = true;
            strSQLWhere = strSQLWhere.ToLower();
            strSQLWhere = clsString.RemoveStringValueInSingleQuotation(strSQLWhere);
            
            List<string> lstCheckStr = new List<string>();

            lstCheckStr.Add("*");
            lstCheckStr.Add(";");
            lstCheckStr.Add("&");
            lstCheckStr.Add("or ");
            lstCheckStr.Add("drop ");
            lstCheckStr.Add("delete");
            lstCheckStr.Add("exec ");
            lstCheckStr.Add("insert ");
            lstCheckStr.Add("update ");
            lstCheckStr.Add("count(");
            lstCheckStr.Add("count (");
            lstCheckStr.Add("char");
            lstCheckStr.Add("javascript");
            lstCheckStr.Add("master");
            //lstCheckStr.Add("like");
            lstCheckStr.Add("truncate");
            lstCheckStr.Add("declare");
            lstCheckStr.Add("create ");
            lstCheckStr.Add("waitfor");
            lstCheckStr.Add("alter");
            lstCheckStr.Add("sleep");

            foreach (string strCheckItem in lstCheckStr)
            {
                if (strSQLWhere.Contains(strCheckItem) && lstExclude.Contains(strCheckItem) == false)
                {
                    int intIndex = strSQLWhere.IndexOf(strCheckItem);
                    bool bolIsSqlIn = true;
                    while (intIndex>=0)
                    {
                        string strPrevChar = strSQLWhere.Substring(intIndex - 1, 1);
                        if (clsString.IsLetter(strPrevChar) == true)
                        {
                            bolIsSqlIn = false;
                            intIndex = strSQLWhere.IndexOf(strCheckItem, intIndex+1);

                        }
                        else
                        {
                            bolIsSqlIn = true;
                            break;
                        }
                    }
                    if (bolIsSqlIn == false) continue;
                    if (clsSysPara_TzPubFunction.AppType == "WEBAPP")
                    {
                        throw new Exception(string.Format("SQL注入:'{0}'", strCheckItem));
                    }
                    if (DetailCheckOr(strSQLWhere) == true)
                    {
                        throw new Exception(string.Format("SQL注入:'{0}'", strCheckItem));
                    }
                }
            }

            bo = false;
            return bo;
        }

        #endregion

        #region 校验给定的字符串含有SQL注入
        /// <summary>
        /// 校验给定的字符串含有Html脚本注入
        /// </summary>
        /// <param name="strSQLWhere">供检查的源字符串</param>
        /// <returns>检查结果，如果有注入就返回TRUE，否则返回FALSE</returns>
        public static bool CheckStrScript(string strSQLWhere)
        {
            //Regex rg = new Regex(REGEXP_IS_DECODE_HTML);
            bool bo = true;
            strSQLWhere = strSQLWhere.ToLower();

            if (strSQLWhere.Contains("'"))
            {
                throw new Exception("SQL注入:'非法单引号'");
            }
            if (strSQLWhere.Contains("*"))
            {
                throw new Exception("SQL注入:'*'");
            }
            if (strSQLWhere.Contains(";"))
            {
                throw new Exception("SQL注入:';'");
            }
            if (strSQLWhere.Contains("("))
            {
                throw new Exception("SQL注入:'('");
            }
            if (strSQLWhere.Contains(")"))
            {
                throw new Exception("SQL注入:')'");
            }
            if (strSQLWhere.Contains("<"))
            {
                throw new Exception("SQL注入:'<'");
            }
            if (strSQLWhere.Contains(">"))
            {
                throw new Exception("SQL注入:'>'");
            }
            if (strSQLWhere.Contains("="))
            {
                throw new Exception("SQL注入:'='");
            }
            if (strSQLWhere.Contains("%"))
            {
                throw new Exception("SQL注入:'%'");
            }
            if (strSQLWhere.Contains("&"))
            {
                throw new Exception("SQL注入:'&'");
            }
            if (strSQLWhere.Contains("and"))
            {
                throw new Exception("SQL注入:'and'");
            }
            if (strSQLWhere.Contains("char"))
            {
                throw new Exception("SQL注入:'char'");
            }
            if (strSQLWhere.Contains("or "))
            {
                throw new Exception("SQL注入:'or'");
            }
            if (strSQLWhere.Contains("javascript"))
            {
                throw new Exception("SQL注入:'javascript'");
            }
            if (strSQLWhere.Contains("script"))
            {
                throw new Exception("SQL注入:'script'");
            }
            if (strSQLWhere.Contains("master"))
            {
                throw new Exception("SQL注入:'master'");
            }
            if (strSQLWhere.Contains("img"))
            {
                throw new Exception("SQL注入:'img'");
            }
            if (strSQLWhere.Contains("src"))
            {
                throw new Exception("SQL注入:'src'");
            }
            if (strSQLWhere.Contains("http"))
            {
                throw new Exception("SQL注入:'http'");
            }
            if (strSQLWhere.Contains("like"))
            {
                throw new Exception("SQL注入:'like'");
            }
            if (strSQLWhere.Contains("truncate"))
            {
                throw new Exception("SQL注入:'truncate'");
            }
            if (strSQLWhere.Contains("declare"))
            {
                throw new Exception("SQL注入:'declare'");
            }
            if (strSQLWhere.Contains("create"))
            {
                throw new Exception("SQL注入:'create'");
            }
            if (Regex.IsMatch(strSQLWhere, @"<frameset[\s\S]+</frameset *>"))
            {
                throw new Exception("SQL注入:'frameset'");
            }
            if (Regex.IsMatch(strSQLWhere, @"<iframe[\s\S]+</iframe *>"))
            {
                throw new Exception("SQL注入:'iframe'");
            }
            if (Regex.IsMatch(strSQLWhere, @" on[\s\S]*="))
            {
                throw new Exception("SQL注入:'on*='");
            }
            if (Regex.IsMatch(strSQLWhere, @" href *= *[\s\S]*script *:"))
            {
                throw new Exception("SQL注入:'script'");
            }
            if (Regex.IsMatch(strSQLWhere, @"<script[\s\S]+</script *>"))
            {
                throw new Exception("SQL注入:'script'");
            }
            bo = false;


            return bo;
        }
        #endregion
    }
}