using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using com.taishsoft.lexicalAnalysis;

namespace com.taishsoft.common
{
    /// <summary>
    /// 正则表达式类的摘要说明
    /// </summary>

    public class clsCheckSql
    {
        private string[,] mstrInvaildSymbol4Sql = new string[,]{
            { "*", "SQL注入:'*'" }, 
            { ";", "SQL注入:';'" },
            {"<","SQL注入:'<'" },
            {">","SQL注入:'>'" },
            {"&","SQL注入:'&'" },
            {"or","SQL注入:'or'" },
            {"drop","SQL注入:'drop'" },
            {"delete","SQL注入:'delete'" },
            {"exec","SQL注入:'exec'" },
            {"select","SQL注入:'select'" },
            {"insert","SQL注入:'insert'" },
            {"update","SQL注入:'update'" },
            {"count","SQL注入:'count'" },
            {"chr","SQL注入:'chr'" },
            {"char","SQL注入:'char'" },
            {"javascript","SQL注入:'javascript'" },
            {"master","SQL注入:'master'" },
            {"src","" },
            {"http","" },
            {"like","" },
            {"truncate","" },
            {"declare","" },
            {"create","" },
            {"waitfor","" },
            {"alter","" },
            {"(","" },
            {")","" },
            {"%","" },
            {"where","" },
            {"'","" }
            //{"","" }          
        };
        private static string[] mstrInvaildSymbol4SqlInsert = new string[]{
             "*",
             ";",
             "%",
             "'",
            //"<",
            //">",
            "&",
             "alter",
            "count",
            "chr",
            "char",
            "create",
            "drop",
            "declare",
            "delete",
            "exec",
            "http",
            //"insert",
            "javascript",
            "like",
            "master",
             "or",
            "select",
            "sleep",
            "src",
            "truncate",
            "update",
            "waitfor",
             "where"
            //"(",
            //")",
          
            //{"","" }          
        };
        private static string[] mstrInvaildSymbol4SqlUpdate = new string[]{
             "*",
             ";",
             "%",
             "'",
            //"<",
            //">",
            "&",
             "alter",
            "count",
            "chr",
            "char",
            "create",
            "drop",
            "declare",
            "delete",
            "exec",
            "http",
            "insert",
            "javascript",
            "like",
            "master",
             "or",
            "select",
            "sleep",
            "src",
            "truncate",
            //"update",
            "waitfor",
             //"where"
            //"(",
            //")",
          
            //{"","" }          
        };
        private static string[] mstrInvaildSymbol4SqlDelete = new string[]{
             "*",
             ";",
             "%",
             "'",
            //"<",
            //">",
            "&",
             "alter",
            "count",
            "chr",
            "char",
            "create",
            "drop",
            "declare",
            //"delete",
            "exec",
            "http",
            "insert",
            "javascript",
            "like",
            "master",
             "or",
            "select",
            "sleep",
            "src",
            "truncate",
            "update",
            "waitfor",
             //"where"
            //"(",
            //")",
          
            //{"","" }          
        };
        private static string[] mstrInvaildSymbol4SqlWhere = new string[]{
             "*",
             ";",
             "%",
             "'",
            //"<",
            //">",
            "&",
             "alter",
            "count",
            "chr",
            "char",
            "create",   
            "drop",
            "declare",
            "delete",
            "exec",          
            "http",
            "insert",
            "javascript",
            //"like",
            "master",
             "or",
            "select",
            "sleep",
            "src",
            "truncate",
            "update",   
            "waitfor",
             //"where"
            //"(",
            //")",
          
            //{"","" }          
        };
        private static string[] mstrInvaildSymbol4SqlWhereV2 = new string[]{
             "*",
             ";",
            "<",
            ">",
            "&",
            "or",
            "drop",
            "delete",
            "exec",
            "select",
            "insert",
            "update",
            "count",
            "chr",
            "char",
            "javascript",
            "master",
            "src",
            "http",
            //"like",
            "truncate",
            "declare",
            "create",
            "waitfor",
            "alter",
            //"(",
            //")",
            "%",
            "where",
            "'"
            //{"","" }          
        };
        private static string[] mstrInvaildSymbol4Field = new string[]{
             "*",
             ";",
            "<",
            ">",
            "&",
            "=",
            "and",
            "or",
            "drop",
            "delete",
            "exec",
            "select",
            "insert",
            "update",
            "count",
            "chr",
            "char",
            "javascript",
            "master",
            "src",
            "http",
            //"like",
            "truncate",
            "declare",
            "create",
            "waitfor",
            "alter",
            "(",
            ")",
            "%",
            "where",
            "'"
            //{"","" }          
        };
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
        

        /// <summary>
        /// 日期校验常量
        /// </summary>
        public const String REGEXP_IS_VALID_DATE = @"^(?:(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00)))(\/|-|\.)(?:0?2\1(?:29))$)|(?:(?:1[6-9]|[2-9]\d)?\d{2})(\/|-|\.)(?:(?:(?:0?[13578]|1[02])\2(?:31))|(?:(?:0?[1,3-9]|1[0-2])\2(29|30))|(?:(?:0?[1-9])|(?:1[0-2]))\2(?:0?[1-9]|1\d|2[0-8]))$";

        public clsCheckSql()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }

      


        #region 校验给定的字符串含有SQL注入
        /// <summary>
        /// 校验给定的字符串含有SQL注入-强检查
        /// </summary>
        /// <param name="strSQLWhere">供检查的源字符串</param>
        /// <returns>检查结果，如果有注入就返回TRUE，否则返回FALSE</returns>
        public static bool CheckStrSQLV2(string strSQLWhere)
        {
            List<string> arrInvaildSymbol4SqlWhere = new List<string>(mstrInvaildSymbol4SqlWhereV2);
            //Regex rg = new Regex(REGEXP_IS_DECODE_HTML);
            List<clsWord_LA> arrWord_LA = clsLexicalAnalysis4Sql.getWordLst(strSQLWhere);
            foreach(clsWord_LA objWord_LA in arrWord_LA)
            {
                if (arrInvaildSymbol4SqlWhere.Contains(objWord_LA.Word.ToLower()) == true)
                {
                    if (objWord_LA.Word.ToLower() == "select")
                    {
                        int intIndex_Curr = arrWord_LA.IndexOf(objWord_LA);
                        if (intIndex_Curr > 2)
                        {
                            clsWord_LA objWord_LA_Prev = arrWord_LA[intIndex_Curr - 2];
                            if (objWord_LA_Prev.Word.ToLower() == "in")
                            {
                                continue;
                            }
                        }
                    }
                    string strMsg = string.Format("在Where条件[{0}]中疑似存在Sql注入词：[{1}].", strSQLWhere, objWord_LA.Word);
                    throw new Exception(strMsg);
                }
            }
            return true;
        }

        /// <summary>
        /// 校验给定的字段值含有SQL注入(Sql Injection)
        /// </summary>
        /// <param name="strFieldValue">供检查的字段值</param>
        /// <param name="strFieldName">字段名</param>
        /// <returns>检查结果，如果有注入就返回TRUE，否则返回FALSE</returns>
        public static bool CheckSqlInjection4Field(string strFieldValue, string strFieldName)
        {
            if (string.IsNullOrEmpty(strFieldValue) == true) return true;
            List<string> arrInvaildSymbol4Field = new List<string>(mstrInvaildSymbol4Field);
            //Regex rg = new Regex(REGEXP_IS_DECODE_HTML);
            strFieldValue = strFieldValue.Replace("'", "''");
            List<clsWord_LA> arrWord_LA = clsLexicalAnalysis4Sql.getWordLst(strFieldValue);
            foreach (clsWord_LA objWord_LA in arrWord_LA)
            {
                if (arrInvaildSymbol4Field.Contains(objWord_LA.Word.ToLower()) == true)
                {
                    //string strMsg = string.Format("在字段值[{0}]中疑似存在Sql注入词：[{1}].",
                    //    strFieldValue, objWord_LA.Word);
                    string strMsg = string.Format("(errid:CheckSql002)字段名:[{0}]的值中疑似存在Sql注入词:[{1}]!(字段值:[{2}])({3})",
                           strFieldName, objWord_LA.Word, strFieldValue,  
                               clsStackTrace.GetCurrClassFunctionByLevel(2));                  
                    throw new Exception(strMsg);
                }
            }
            return true;
        }

        /// <summary>
        /// 校验给定的字符串含有SQL注入
        /// </summary>
        /// <param name="strSQLWhere">供检查的源字符串</param>
        /// <returns>检查结果，如果有注入就返回TRUE，否则返回FALSE</returns>
        public static bool CheckStrSQL(string strSQLWhere)
        {
            List<string> arrInvaildSymbol4SqlWhere = new List<string>(mstrInvaildSymbol4SqlWhere);
            //Regex rg = new Regex(REGEXP_IS_DECODE_HTML);
            List<clsWord_LA> arrWord_LA = clsLexicalAnalysis4Sql.getWordLst(strSQLWhere);
            foreach (clsWord_LA objWord_LA in arrWord_LA)
            {
                if (arrInvaildSymbol4SqlWhere.Contains(objWord_LA.Word.ToLower()) == true)
                {
                    if (objWord_LA.Word.ToLower() == "select")
                    {
                        int intIndex_Curr = arrWord_LA.IndexOf(objWord_LA);
                        if (intIndex_Curr > 2)
                        {
                            clsWord_LA objWord_LA_Prev = arrWord_LA[intIndex_Curr - 2];
                            if (objWord_LA_Prev.Word.ToLower() == "in")
                            {
                                continue;
                            }
                        }
                    }
                    string strMsg = string.Format("在Where条件[{0}]中疑似存在Sql注入词：[{1}].", strSQLWhere, objWord_LA.Word);
                    throw new Exception(strMsg);
                }
            }
            return true;         
        }
        
        /// <summary>
        /// 校验给定的SqlInsert语句中是否含有SQL注入
        /// </summary>
        /// <param name="strSqlInsert">供检查的SqlInsert语句</param>
        /// <returns>检查结果，如果有注入就返回TRUE，否则返回FALSE</returns>
        public static bool CheckSqlInjection4Insert(string strSqlInsert)
        {
            List<string> arrInvaildSymbol4SqlInsert = new List<string>(mstrInvaildSymbol4SqlInsert);
            //Regex rg = new Regex(REGEXP_IS_DECODE_HTML);
            List<clsWord_LA> arrWord_LA = clsLexicalAnalysis4Sql.getWordLst(strSqlInsert);
            foreach (clsWord_LA objWord_LA in arrWord_LA)
            {
                if (arrInvaildSymbol4SqlInsert.Contains(objWord_LA.Word.ToLower()) == true)
                {
                    if (objWord_LA.Word.ToLower() == ";")
                    {
                        int intIndex_Curr = arrWord_LA.IndexOf(objWord_LA);
                        if (intIndex_Curr == arrWord_LA.Count-2)
                        {
                            continue;
                        }
                    }
                    {
                        int intIndex_Curr = arrWord_LA.IndexOf(objWord_LA);
                        clsWord_LA objWord_LA_Prev = arrWord_LA[intIndex_Curr - 1];
                        if (objWord_LA_Prev != null && objWord_LA_Prev.Word == "\\")
                        {
                            continue;
                        }
                        clsWord_LA objWord_LA_Next = arrWord_LA[intIndex_Curr + 1];
                        if (objWord_LA_Next != null && objWord_LA_Next.Word == "\\")
                        {
                            continue;
                        }
                    }
                    string strMsg = string.Format("在SqlInsert语句:[{0}]中疑似存在Sql注入词：[{1}].", strSqlInsert, objWord_LA.Word);
                    throw new Exception(strMsg);
                }
            }
            return true;
        }

        /// <summary>
        /// 校验给定的SqlUpdate语句中是否含有SQL注入
        /// </summary>
        /// <param name="strSqlUpdate">供检查的SqlUpdate语句</param>
        /// <returns>检查结果，如果有注入就返回TRUE，否则返回FALSE</returns>
        public static bool CheckSqlInjection4Update(string strSqlUpdate)
        {
            List<string> arrInvaildSymbol4SqlUpdate = new List<string>(mstrInvaildSymbol4SqlUpdate);
            //Regex rg = new Regex(REGEXP_IS_DECODE_HTML);
            List<clsWord_LA> arrWord_LA = clsLexicalAnalysis4Sql.getWordLst(strSqlUpdate);
            foreach (clsWord_LA objWord_LA in arrWord_LA)
            {
                if (arrInvaildSymbol4SqlUpdate.Contains(objWord_LA.Word.ToLower()) == true)
                {
                    if (objWord_LA.Word.ToLower() == ";")
                    {
                        int intIndex_Curr = arrWord_LA.IndexOf(objWord_LA);
                        if (intIndex_Curr == arrWord_LA.Count - 2)
                        {
                            continue;
                        }
                    }
                    {
                        int intIndex_Curr = arrWord_LA.IndexOf(objWord_LA);
                        clsWord_LA objWord_LA_Prev = arrWord_LA[intIndex_Curr - 1];
                        if (objWord_LA_Prev != null && objWord_LA_Prev.Word == "\\")
                        {
                            continue;
                        }
                        clsWord_LA objWord_LA_Next = arrWord_LA[intIndex_Curr + 1];
                        if (objWord_LA_Next != null && objWord_LA_Next.Word == "\\")
                        {
                            continue;
                        }
                    }

                    string strMsg = string.Format("在SqlUpdate语句:[{0}]中疑似存在Sql注入词：[{1}].", strSqlUpdate, objWord_LA.Word);
                    throw new Exception(strMsg);
                }
            }
            return true;
        }

        /// <summary>
        /// 校验给定的SqlDelete语句中是否含有SQL注入
        /// </summary>
        /// <param name="strSqlDelete">供检查的SqlDelete语句</param>
        /// <returns>检查结果，如果有注入就返回TRUE，否则返回FALSE</returns>
        public static bool CheckSqlInjection4Delete(string strSqlDelete)
        {
            List<string> arrInvaildSymbol4SqlDelete = new List<string>(mstrInvaildSymbol4SqlDelete);
            //Regex rg = new Regex(REGEXP_IS_DECODE_HTML);
            List<clsWord_LA> arrWord_LA = clsLexicalAnalysis4Sql.getWordLst(strSqlDelete);
            foreach (clsWord_LA objWord_LA in arrWord_LA)
            {
                if (arrInvaildSymbol4SqlDelete.Contains(objWord_LA.Word.ToLower()) == true)
                {
                    string strMsg = string.Format("在SqlDelete语句:[{0}]中疑似存在Sql注入词：[{1}].", strSqlDelete, objWord_LA.Word);
                    throw new Exception(strMsg);
                }
            }
            return true;
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
                    lstExclude.Add(strExclude.Trim());
                }
                strSQLWhere = clsString.RemoveElementValue(strSQLWhere, "exclude");
                return CheckStrSQL_Weak(strSQLWhere, lstExclude);
            }
            //strSQLWhere = strSQLWhere.ToLower();
            //strSQLWhere = clsString.RemoveStringValueInSingleQuotation(strSQLWhere);
            List<clsWord_LA> arrWord_LA = clsLexicalAnalysis4Sql.getWordLst(strSQLWhere);

            List<string> arrInvaildSymbol4SqlWhere = new List<string>(mstrInvaildSymbol4SqlWhere);
            foreach (clsWord_LA objWord_LA in arrWord_LA)
            {
                if (arrInvaildSymbol4SqlWhere.Contains(objWord_LA.Word.ToLower()) == true)
                {
                    if (objWord_LA.Word.ToLower() == "select")
                    {
                        int intIndex_Curr = arrWord_LA.IndexOf(objWord_LA);
                        if (intIndex_Curr>2)
                        {
                            clsWord_LA objWord_LA_Prev = arrWord_LA[intIndex_Curr - 2];
                            if (objWord_LA_Prev.Word.ToLower() == "in")
                            {
                                continue;
                            }
                        }
                    }
                    
                    string strMsg = string.Format("在Where条件[{0}]中疑似存在Sql注入词：[{1}].", strSQLWhere, objWord_LA.Word);
                    if (clsSysPara_TzPubFunction.AppType == "WEBAPP")
                    {
                        throw new Exception(strMsg);
                    }
                
                }
            } 
          
            return true;
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
            //strSQLWhere = strSQLWhere.ToLower();
            //strSQLWhere = clsString.RemoveStringValueInSingleQuotation(strSQLWhere);
            List<clsWord_LA> arrWord_LA = clsLexicalAnalysis4Sql.getWordLst(strSQLWhere);
            List<string> arrInvaildSymbol4SqlWhere = new List<string>(mstrInvaildSymbol4SqlWhere);
            foreach (clsWord_LA objWord_LA in arrWord_LA)
            {
                if (arrInvaildSymbol4SqlWhere.Contains(objWord_LA.Word.ToLower()) == true
                    && lstExclude.Contains(objWord_LA.Word.ToLower()) == false)
                {
                    if (objWord_LA.Word.ToLower() == "select")
                    {
                        int intIndex_Curr = arrWord_LA.IndexOf(objWord_LA);
                        if (intIndex_Curr > 2)
                        {
                            clsWord_LA objWord_LA_Prev = arrWord_LA[intIndex_Curr - 2];
                            if (objWord_LA_Prev.Word.ToLower() == "in")
                            {
                                continue;
                            }
                        }
                    }
                    string strMsg = string.Format("在Where条件[{0}]中疑似存在Sql注入词：[{1}].", strSQLWhere, objWord_LA.Word);
                    if (clsSysPara_TzPubFunction.AppType == "WEBAPP")
                    {
                        throw new Exception(strMsg);
                    }

                }
            }
                       
            return true;
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
        /// <summary>
        /// 校验给定的字段值的字段长度
        /// </summary>
        /// <param name="strFieldValue">供检查的字段值</param>
        /// <param name="intMaxLen">最大长度</param>
        /// <param name="strFieldName">字段名</param>
        /// <returns>检查结果，如果不超长就返回TRUE，否则抛错</returns>
        public static bool CheckFieldLen(Object strFieldValue, 
            int intMaxLen, 
            string strFieldName)
        {
            if (Object.Equals(null, strFieldValue) == true)
            {
                return true;
            }
            string strTemp = strFieldValue.ToString();  
            if (getStrLen(strTemp) > intMaxLen)
            {
                string strMsg = string.Format("(errid:CheckSql001)字段名:[{0}]的值的长度为:[{3}]不能超过{1}!(字段值:[{2}])({4})",
                    strFieldName, intMaxLen, strFieldValue,
                    getStrLen(strTemp),
                    clsStackTrace.GetCurrClassFunctionByLevel(2));
                throw new Exception(strMsg);
            }
            return true;
        }


        /// <summary>
        /// 校验给定的字段值作为外键字段长度必须为固定长度
        /// </summary>
        /// <param name="strFieldValue">供检查的字段值</param>
        /// <param name="intFieldLen">字段长度</param>
        /// <param name="strFieldName">字段名</param>
        /// <returns>检查结果，如果等于固定长度就返回TRUE，否则抛错</returns>
        public static bool CheckFieldForeignKey(Object strFieldValue,
            int intFieldLen,
            string strFieldName)
        {
            if (Object.Equals(null, strFieldValue) == true)
            {
                return true;
            }
            if (string.IsNullOrEmpty(strFieldValue.ToString()) == true)
            {
                return true;
            }
            string strTemp = strFieldValue.ToString();
            if (getStrLen(strTemp) != intFieldLen)
            {
                //字段[题目表 | 问卷集ID]作为外键字段,长度应该为4!"
                string strMsg = string.Format("(errid:CheckSql003)字段名:[{0}]作为外键字段,实际长度为:[{3}],应该为[{1}]!(字段值:[{2}])({4})",
                    strFieldName, intFieldLen, strFieldValue,
                    getStrLen(strTemp),
                    clsStackTrace.GetCurrClassFunctionByLevel(2));
                throw new Exception(strMsg);
            }
            return true;
        }

        /// <summary>
        /// 校验给定的字段值不能为空(Null)
        /// </summary>
        /// <param name="strFieldValue">供检查的字段值</param>    
        /// <param name="strFieldName">字段名</param>
        /// <returns>检查结果，如果等于非空就返回TRUE，否则抛错</returns>
        public static bool CheckFieldNotNull(Object strFieldValue,
            string strFieldName)
        {
            if (Object.Equals(null, strFieldValue) == true)
            {
//                throw new clsDbObjException("(errid:Data000044)字段[题目表|题目名称]不能为空(NULL)!(clsQuestionnaireDA:CheckPropertyNew)");
                string strMsg = string.Format("(errid:CheckSql004)字段名:[{0}]不能为空(NULL)!({1})",
                  strFieldName, 
                  clsStackTrace.GetCurrClassFunctionByLevel(2));
                throw new Exception(strMsg);
            }
        
            if (string.IsNullOrEmpty(strFieldValue.ToString()) == true)
            {
                //字段[题目表 | 问卷集ID]作为外键字段,长度应该为4!"
                string strMsg = string.Format("(errid:CheckSql004)字段名:[{0}]不能为空(NULL)!({1})",
                  strFieldName,
                  clsStackTrace.GetCurrClassFunctionByLevel(2));
                throw new Exception(strMsg);
            }
            return true;
        }

        /// <summary>
        /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
        /// (AutoGCLib.AutoGCPubFuncV6:GengetStrLen)
        /// </summary>
        /// <param name = "strTemp">给定的原字符串</param>
        /// <returns>返回字符串长度</returns>
        private static int getStrLen(string strTemp)
        {
            int len;
            byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
            len = sarr.Length;//will output as 3+3*2 = 9
            return len;
        }
    }
}