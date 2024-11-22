using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using com.taishsoft.lexicalAnalysis;

namespace com.taishsoft.common
{
    /// <summary>
    /// ������ʽ���ժҪ˵��
    /// </summary>

    public class clsCheckSql
    {
        private string[,] mstrInvaildSymbol4Sql = new string[,]{
            { "*", "SQLע��:'*'" }, 
            { ";", "SQLע��:';'" },
            {"<","SQLע��:'<'" },
            {">","SQLע��:'>'" },
            {"&","SQLע��:'&'" },
            {"or","SQLע��:'or'" },
            {"drop","SQLע��:'drop'" },
            {"delete","SQLע��:'delete'" },
            {"exec","SQLע��:'exec'" },
            {"select","SQLע��:'select'" },
            {"insert","SQLע��:'insert'" },
            {"update","SQLע��:'update'" },
            {"count","SQLע��:'count'" },
            {"chr","SQLע��:'chr'" },
            {"char","SQLע��:'char'" },
            {"javascript","SQLע��:'javascript'" },
            {"master","SQLע��:'master'" },
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
        /// �����ʼ�У�鳣��
        /// </summary>
        public const String REGEXP_IS_VALID_EMAIL = @"^\w+((-\w+)|(\.\w+))*\@\w+((\.|-)\w+)*\.\w+$";  //�����ʼ�У�鳣��
        /// <summary>
        /// ��ַУ�鳣��
        /// </summary>
        public const String REGEXP_IS_VALID_URL = @"^http://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?";    //��ַУ�鳣��
        /// <summary>
        /// �ʱ�У�鳣��
        /// </summary>
        public const String REGEXP_IS_VALID_ZIP = @"\d{6}";     //�ʱ�У�鳣��
        /// <summary>
        /// ���֤У�鳣��
        /// </summary>
        public const String REGEXP_IS_VALID_SSN = @"\d{18}|\d{15}";    //���֤У�鳣�� 
        /// <summary>
        /// ����У�鳣��
        /// </summary>
        public const String REGEXP_IS_VALID_INT = @"^\d{1,}$";     //����У�鳣��
        /// <summary>
        /// HEML����У��
        /// </summary>
        public const String REGEXP_IS_DECODE_HTML = @"&lt;(.*)&gt;.*&lt;\/\1&gt;|&lt;(.*) \/&gt;";    //����У�鳣��
        /// <summary>
        /// ������У�飨��ֵУ�鳣����
        /// </summary>
        public const String REGEXP_IS_VALID_DEMICAL = @"^-?(0|\d+)(\.\d+)?$";    //��ֵУ�鳣�� "
        /// <summary>
        /// �Ƿ���HTML����
        /// </summary>
        public const String REGEXP_IS_HTML = @"<(.*)>.*<\/\1>|<(.*) \/>";
        /// <summary>
        /// �ַ������֡��»��߼��鳣��
        /// </summary>
        public const String REGEXP_TEXT = @"\w+$";//�ַ������֡��»��߼��鳣��
        /// <summary>
        /// ���ּ���
        /// </summary>
        public const String REGEXP_TEXT_NUM = @"^\d+$";
        /// <summary>
        /// ����
        /// </summary>
        public const String REGEXP_TEXT_CHINESE = @"^[\u4E00-\u9FA5]+$";
        /// <summary>
        /// ���ַ�����
        /// </summary>
        public const String REGEXP_TEXT_NOT_LETTER_NUM = @"\W+$";
        /// <summary>
        /// ������ĸ
        /// </summary>
        public const String REGEXP_TEXT_CHINESE_LETTER_NUM = @"^[\u4E00-\u9FA5A-Za-z0-9]+$";
        /// <summary>
        /// �����ַ����ַ��»���
        /// </summary>
        public const String REGEXP_TEXT_CHINEST_LETTER_NUM_UNDERLINE = @"[\u4e00-\u9fa5A-Za-z0-9_]+$";
        /// <summary>
        /// �����ַ������»���
        /// </summary>
        public const String REGEXP_TEXT_CHINEST_LETTER_NUM_LINE = @"[\u4e00-\u9fa5A-Za-z0-9_@#$%^&*?]+$";
        

        /// <summary>
        /// ����У�鳣��
        /// </summary>
        public const String REGEXP_IS_VALID_DATE = @"^(?:(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00)))(\/|-|\.)(?:0?2\1(?:29))$)|(?:(?:1[6-9]|[2-9]\d)?\d{2})(\/|-|\.)(?:(?:(?:0?[13578]|1[02])\2(?:31))|(?:(?:0?[1,3-9]|1[0-2])\2(29|30))|(?:(?:0?[1-9])|(?:1[0-2]))\2(?:0?[1-9]|1\d|2[0-8]))$";

        public clsCheckSql()
        {
            //
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }

      


        #region У��������ַ�������SQLע��
        /// <summary>
        /// У��������ַ�������SQLע��-ǿ���
        /// </summary>
        /// <param name="strSQLWhere">������Դ�ַ���</param>
        /// <returns>������������ע��ͷ���TRUE�����򷵻�FALSE</returns>
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
                    string strMsg = string.Format("��Where����[{0}]�����ƴ���Sqlע��ʣ�[{1}].", strSQLWhere, objWord_LA.Word);
                    throw new Exception(strMsg);
                }
            }
            return true;
        }

        /// <summary>
        /// У��������ֶ�ֵ����SQLע��(Sql Injection)
        /// </summary>
        /// <param name="strFieldValue">�������ֶ�ֵ</param>
        /// <param name="strFieldName">�ֶ���</param>
        /// <returns>������������ע��ͷ���TRUE�����򷵻�FALSE</returns>
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
                    //string strMsg = string.Format("���ֶ�ֵ[{0}]�����ƴ���Sqlע��ʣ�[{1}].",
                    //    strFieldValue, objWord_LA.Word);
                    string strMsg = string.Format("(errid:CheckSql002)�ֶ���:[{0}]��ֵ�����ƴ���Sqlע���:[{1}]!(�ֶ�ֵ:[{2}])({3})",
                           strFieldName, objWord_LA.Word, strFieldValue,  
                               clsStackTrace.GetCurrClassFunctionByLevel(2));                  
                    throw new Exception(strMsg);
                }
            }
            return true;
        }

        /// <summary>
        /// У��������ַ�������SQLע��
        /// </summary>
        /// <param name="strSQLWhere">������Դ�ַ���</param>
        /// <returns>������������ע��ͷ���TRUE�����򷵻�FALSE</returns>
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
                    string strMsg = string.Format("��Where����[{0}]�����ƴ���Sqlע��ʣ�[{1}].", strSQLWhere, objWord_LA.Word);
                    throw new Exception(strMsg);
                }
            }
            return true;         
        }
        
        /// <summary>
        /// У�������SqlInsert������Ƿ���SQLע��
        /// </summary>
        /// <param name="strSqlInsert">������SqlInsert���</param>
        /// <returns>������������ע��ͷ���TRUE�����򷵻�FALSE</returns>
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
                    string strMsg = string.Format("��SqlInsert���:[{0}]�����ƴ���Sqlע��ʣ�[{1}].", strSqlInsert, objWord_LA.Word);
                    throw new Exception(strMsg);
                }
            }
            return true;
        }

        /// <summary>
        /// У�������SqlUpdate������Ƿ���SQLע��
        /// </summary>
        /// <param name="strSqlUpdate">������SqlUpdate���</param>
        /// <returns>������������ע��ͷ���TRUE�����򷵻�FALSE</returns>
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

                    string strMsg = string.Format("��SqlUpdate���:[{0}]�����ƴ���Sqlע��ʣ�[{1}].", strSqlUpdate, objWord_LA.Word);
                    throw new Exception(strMsg);
                }
            }
            return true;
        }

        /// <summary>
        /// У�������SqlDelete������Ƿ���SQLע��
        /// </summary>
        /// <param name="strSqlDelete">������SqlDelete���</param>
        /// <returns>������������ע��ͷ���TRUE�����򷵻�FALSE</returns>
        public static bool CheckSqlInjection4Delete(string strSqlDelete)
        {
            List<string> arrInvaildSymbol4SqlDelete = new List<string>(mstrInvaildSymbol4SqlDelete);
            //Regex rg = new Regex(REGEXP_IS_DECODE_HTML);
            List<clsWord_LA> arrWord_LA = clsLexicalAnalysis4Sql.getWordLst(strSqlDelete);
            foreach (clsWord_LA objWord_LA in arrWord_LA)
            {
                if (arrInvaildSymbol4SqlDelete.Contains(objWord_LA.Word.ToLower()) == true)
                {
                    string strMsg = string.Format("��SqlDelete���:[{0}]�����ƴ���Sqlע��ʣ�[{1}].", strSqlDelete, objWord_LA.Word);
                    throw new Exception(strMsg);
                }
            }
            return true;
        }


        /// <summary>
        /// ��ȡ��װ����ų��������磺Դ����or|delete��,��Ϻ�Ĵ�����[exclude]or|delete[/exclude]��
        /// </summary>
        /// <param name="strSource">Դ��</param>
        /// <returns>����װ���ų���</returns>
        public static string GetExcludeStr(string strSource)
        {
            if (string.IsNullOrEmpty( strSource) == true) return "";
            return string.Format("[exclude]{0}[/exclude]", strSource);
        }

        /// <summary>
        /// У��������ַ�������SQLע��,����飬�����Select
        /// </summary>
        /// <param name="strSQLWhere">������Դ�ַ���</param>
        /// <returns>������������ע��ͷ���TRUE�����򷵻�FALSE</returns>
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
                    
                    string strMsg = string.Format("��Where����[{0}]�����ƴ���Sqlע��ʣ�[{1}].", strSQLWhere, objWord_LA.Word);
                    if (clsSysPara_TzPubFunction.AppType == "WEBAPP")
                    {
                        throw new Exception(strMsg);
                    }
                
                }
            } 
          
            return true;
        }
        /// <summary>
        /// ��ϸ���'or '
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
        /// У��������ַ�������SQLע��,����飬�����Select
        /// </summary>
        /// <param name="strSQLWhere">������Դ�ַ���</param>
        /// <param name="lstExclude">�ų��ļ���ַ����б�</param>
        /// <returns>������������ע��ͷ���TRUE�����򷵻�FALSE</returns>
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
                    string strMsg = string.Format("��Where����[{0}]�����ƴ���Sqlע��ʣ�[{1}].", strSQLWhere, objWord_LA.Word);
                    if (clsSysPara_TzPubFunction.AppType == "WEBAPP")
                    {
                        throw new Exception(strMsg);
                    }

                }
            }
                       
            return true;
        }

        #endregion

        #region У��������ַ�������SQLע��
        /// <summary>
        /// У��������ַ�������Html�ű�ע��
        /// </summary>
        /// <param name="strSQLWhere">������Դ�ַ���</param>
        /// <returns>������������ע��ͷ���TRUE�����򷵻�FALSE</returns>
        public static bool CheckStrScript(string strSQLWhere)
        {
            //Regex rg = new Regex(REGEXP_IS_DECODE_HTML);
            bool bo = true;
            strSQLWhere = strSQLWhere.ToLower();

            if (strSQLWhere.Contains("'"))
            {
                throw new Exception("SQLע��:'�Ƿ�������'");
            }
            if (strSQLWhere.Contains("*"))
            {
                throw new Exception("SQLע��:'*'");
            }
            if (strSQLWhere.Contains(";"))
            {
                throw new Exception("SQLע��:';'");
            }
            if (strSQLWhere.Contains("("))
            {
                throw new Exception("SQLע��:'('");
            }
            if (strSQLWhere.Contains(")"))
            {
                throw new Exception("SQLע��:')'");
            }
            if (strSQLWhere.Contains("<"))
            {
                throw new Exception("SQLע��:'<'");
            }
            if (strSQLWhere.Contains(">"))
            {
                throw new Exception("SQLע��:'>'");
            }
            if (strSQLWhere.Contains("="))
            {
                throw new Exception("SQLע��:'='");
            }
            if (strSQLWhere.Contains("%"))
            {
                throw new Exception("SQLע��:'%'");
            }
            if (strSQLWhere.Contains("&"))
            {
                throw new Exception("SQLע��:'&'");
            }
            if (strSQLWhere.Contains("and"))
            {
                throw new Exception("SQLע��:'and'");
            }
            if (strSQLWhere.Contains("char"))
            {
                throw new Exception("SQLע��:'char'");
            }
            if (strSQLWhere.Contains("or "))
            {
                throw new Exception("SQLע��:'or'");
            }
            if (strSQLWhere.Contains("javascript"))
            {
                throw new Exception("SQLע��:'javascript'");
            }
            if (strSQLWhere.Contains("script"))
            {
                throw new Exception("SQLע��:'script'");
            }
            if (strSQLWhere.Contains("master"))
            {
                throw new Exception("SQLע��:'master'");
            }
            if (strSQLWhere.Contains("img"))
            {
                throw new Exception("SQLע��:'img'");
            }
            if (strSQLWhere.Contains("src"))
            {
                throw new Exception("SQLע��:'src'");
            }
            if (strSQLWhere.Contains("http"))
            {
                throw new Exception("SQLע��:'http'");
            }
            if (strSQLWhere.Contains("like"))
            {
                throw new Exception("SQLע��:'like'");
            }
            if (strSQLWhere.Contains("truncate"))
            {
                throw new Exception("SQLע��:'truncate'");
            }
            if (strSQLWhere.Contains("declare"))
            {
                throw new Exception("SQLע��:'declare'");
            }
            if (strSQLWhere.Contains("create"))
            {
                throw new Exception("SQLע��:'create'");
            }
            if (Regex.IsMatch(strSQLWhere, @"<frameset[\s\S]+</frameset *>"))
            {
                throw new Exception("SQLע��:'frameset'");
            }
            if (Regex.IsMatch(strSQLWhere, @"<iframe[\s\S]+</iframe *>"))
            {
                throw new Exception("SQLע��:'iframe'");
            }
            if (Regex.IsMatch(strSQLWhere, @" on[\s\S]*="))
            {
                throw new Exception("SQLע��:'on*='");
            }
            if (Regex.IsMatch(strSQLWhere, @" href *= *[\s\S]*script *:"))
            {
                throw new Exception("SQLע��:'script'");
            }
            if (Regex.IsMatch(strSQLWhere, @"<script[\s\S]+</script *>"))
            {
                throw new Exception("SQLע��:'script'");
            }
            bo = false;


            return bo;
        }
        #endregion
        /// <summary>
        /// У��������ֶ�ֵ���ֶγ���
        /// </summary>
        /// <param name="strFieldValue">�������ֶ�ֵ</param>
        /// <param name="intMaxLen">��󳤶�</param>
        /// <param name="strFieldName">�ֶ���</param>
        /// <returns>�����������������ͷ���TRUE�������״�</returns>
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
                string strMsg = string.Format("(errid:CheckSql001)�ֶ���:[{0}]��ֵ�ĳ���Ϊ:[{3}]���ܳ���{1}!(�ֶ�ֵ:[{2}])({4})",
                    strFieldName, intMaxLen, strFieldValue,
                    getStrLen(strTemp),
                    clsStackTrace.GetCurrClassFunctionByLevel(2));
                throw new Exception(strMsg);
            }
            return true;
        }


        /// <summary>
        /// У��������ֶ�ֵ��Ϊ����ֶγ��ȱ���Ϊ�̶�����
        /// </summary>
        /// <param name="strFieldValue">�������ֶ�ֵ</param>
        /// <param name="intFieldLen">�ֶγ���</param>
        /// <param name="strFieldName">�ֶ���</param>
        /// <returns>�������������ڹ̶����Ⱦͷ���TRUE�������״�</returns>
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
                //�ֶ�[��Ŀ�� | �ʾ�ID]��Ϊ����ֶ�,����Ӧ��Ϊ4!"
                string strMsg = string.Format("(errid:CheckSql003)�ֶ���:[{0}]��Ϊ����ֶ�,ʵ�ʳ���Ϊ:[{3}],Ӧ��Ϊ[{1}]!(�ֶ�ֵ:[{2}])({4})",
                    strFieldName, intFieldLen, strFieldValue,
                    getStrLen(strTemp),
                    clsStackTrace.GetCurrClassFunctionByLevel(2));
                throw new Exception(strMsg);
            }
            return true;
        }

        /// <summary>
        /// У��������ֶ�ֵ����Ϊ��(Null)
        /// </summary>
        /// <param name="strFieldValue">�������ֶ�ֵ</param>    
        /// <param name="strFieldName">�ֶ���</param>
        /// <returns>�������������ڷǿվͷ���TRUE�������״�</returns>
        public static bool CheckFieldNotNull(Object strFieldValue,
            string strFieldName)
        {
            if (Object.Equals(null, strFieldValue) == true)
            {
//                throw new clsDbObjException("(errid:Data000044)�ֶ�[��Ŀ��|��Ŀ����]����Ϊ��(NULL)!(clsQuestionnaireDA:CheckPropertyNew)");
                string strMsg = string.Format("(errid:CheckSql004)�ֶ���:[{0}]����Ϊ��(NULL)!({1})",
                  strFieldName, 
                  clsStackTrace.GetCurrClassFunctionByLevel(2));
                throw new Exception(strMsg);
            }
        
            if (string.IsNullOrEmpty(strFieldValue.ToString()) == true)
            {
                //�ֶ�[��Ŀ�� | �ʾ�ID]��Ϊ����ֶ�,����Ӧ��Ϊ4!"
                string strMsg = string.Format("(errid:CheckSql004)�ֶ���:[{0}]����Ϊ��(NULL)!({1})",
                  strFieldName,
                  clsStackTrace.GetCurrClassFunctionByLevel(2));
                throw new Exception(strMsg);
            }
            return true;
        }

        /// <summary>
        /// ��ȡ�ַ�������,���к���Ϊ2���ֽ�,Ӣ��Ϊ1���ֽ�
        /// (AutoGCLib.AutoGCPubFuncV6:GengetStrLen)
        /// </summary>
        /// <param name = "strTemp">������ԭ�ַ���</param>
        /// <returns>�����ַ�������</returns>
        private static int getStrLen(string strTemp)
        {
            int len;
            byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
            len = sarr.Length;//will output as 3+3*2 = 9
            return len;
        }
    }
}