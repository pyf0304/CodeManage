using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace com.taishsoft.common
{
    /// <summary>
    /// ������ʽ���ժҪ˵��
    /// </summary>

    public class clsCommonRegular
    {
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
        //����У�鳣��
        public const String REGEXP_IS_VALID_DATE = @"^(?:(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00)))(\/|-|\.)(?:0?2\1(?:29))$)|(?:(?:1[6-9]|[2-9]\d)?\d{2})(\/|-|\.)(?:(?:(?:0?[13578]|1[02])\2(?:31))|(?:(?:0?[1,3-9]|1[0-2])\2(29|30))|(?:(?:0?[1-9])|(?:1[0-2]))\2(?:0?[1-9]|1\d|2[0-8]))$";

        /// <summary>
        /// 
        /// </summary>
        public clsCommonRegular()
        {
            //
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }

        #region У�������ֵ��ʽ����������Ƿ����

        /// <summary>
        /// У�������ֵ��ʽ����������Ƿ����
        /// </summary>
        /// <param name="SrcEmail"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static bool IsValidEmail(string SrcEmail, ref string Error)
        {
            if (string.IsNullOrEmpty(SrcEmail))
            {
                Error = "���䲻��Ϊ�գ�";
            }
            bool isValid = (new Regex(REGEXP_IS_VALID_EMAIL)).IsMatch(SrcEmail);
            if (!isValid)
            {
                Error = "�����ʽ����ȷ��";
                return false;
            }
            return true;
        }
        #endregion

        #region У�������ֵ��ʽ���ʱ��Ƿ����

        /// <summary>
        /// У�������ֵ��ʽ���ʱ��Ƿ����
        /// </summary>
        /// <param name="SrcZip"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static bool IsValidZip(string SrcZip, ref string Error)
        {
            if (string.IsNullOrEmpty(SrcZip))
            {
                Error = "�ʱ಻��Ϊ�գ�";
            }
            bool isValid = (new Regex(REGEXP_IS_VALID_ZIP)).IsMatch(SrcZip);
            if (!isValid)
            {
                Error = "�ʱ��ʽ����ȷ��";
                return false;
            }
            return true;
        }
        #endregion

        #region У�������ֵ��ʽ�����֤�Ƿ����
        /// <summary>
        /// У�������ֵ��ʽ�����֤�Ƿ����
        /// </summary>
        /// <param name="SrcSSNField"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static bool IsValidSSN(string SrcSSNField, ref string Error)
        {
            if (string.IsNullOrEmpty(SrcSSNField))
            {
                Error = "���֤����Ϊ�գ�";
            }
            bool isValid = (new Regex(REGEXP_IS_VALID_SSN)).IsMatch(SrcSSNField);
            if (!isValid)
            {
                Error = "���֤��ʽ����ȷ��";
                return false;
            }
            return true;
        }
        #endregion

        #region У�������ֵ��ʽ��URL�Ƿ����
        /// <summary>
        /// �жϸ�����ֵ��ʽ��URL�Ƿ����
        /// </summary>
        /// <param name="ErrorField"></param>
        /// <returns></returns>
        public static string GetUrlFieldError(string ErrorField)
        {
            return ErrorField + "��ʽ����ȷhttp://www.abc.com)��";
        }
        public static bool IsValidUrl(string SrcUrl, ref string Error)
        {
            if (string.IsNullOrEmpty(SrcUrl))
            {
                Error = "URL����Ϊ�գ�";
            }
            bool isValid = (new Regex(REGEXP_IS_VALID_URL)).IsMatch(SrcUrl);
            if (!isValid)
            {
                Error = "URL��ʽ����ȷ��";
                return false;
            }
            return true;
        }
        #endregion

        #region У�������ֵ�Ƿ�Ϊ��������
        /// <summary>
        /// �жϸ������Ƿ�Ϊ��������
        /// </summary>
        /// <param name="SrcDate">�������ַ���</param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static bool IsValidDate(string SrcDate, ref string Error)
        {
            if (string.IsNullOrEmpty(SrcDate))
            {
                Error = "���ڲ���Ϊ�գ�";
            }
            bool isValid = (new Regex(REGEXP_IS_VALID_DATE)).IsMatch(SrcDate);
            if (!isValid)
            {
                Error = "���ڸ�ʽ����ȷ��";
                return false;
            }
            return true;
        }
        #endregion

        #region У��������Ƿ�Ϊ��ֵ��
        /// <summary>
        /// �жϸ������Ƿ�Ϊ��ֵ��
        /// </summary>
        /// <param name="SrcNumber"></param>
        /// <param name="Error"></param>
        /// <returns></returns>
        public static bool IsValidNumber(string SrcNumber, ref string Error)
        {
            if (string.IsNullOrEmpty(SrcNumber))
            {
                Error = "��ֵ����Ϊ�գ�";
            }
            bool isValid = (new Regex(REGEXP_IS_VALID_DEMICAL)).IsMatch(SrcNumber);
            if (!isValid)
            {
                Error = "������ֵ�ͣ�";
                return false;
            }
            return true;
        }
        #endregion

        #region ȥ������HTML������
        /// <summary>
        /// ȥ������HTML������
        /// </summary>
        /// <param name="SrcHTML"></param>
        /// <returns></returns>
        public static string ReplaceHTML(string SrcHTML)
        {
            Regex rg = new Regex(REGEXP_IS_HTML);
            return rg.Replace(SrcHTML, "");
        }
        #endregion

        #region ȥ������HTML������
        /// <summary>
        /// ȥ������HTML������
        /// </summary>
        /// <param name="SrcHTML"></param>
        /// <returns></returns>
        public static string ReplaceDECODEHTML(string SrcHTML)
        {
            Regex rg = new Regex(REGEXP_IS_DECODE_HTML);
            return rg.Replace(SrcHTML, "");
        }
        #endregion


        #region У��������ַ�������SQLע��
        /// <summary>
        /// У��������ַ�������SQLע��-ǿ���
        /// </summary>
        /// <param name="strSQLWhere">������Դ�ַ���</param>
        /// <returns>������������ע��ͷ���TRUE�����򷵻�FALSE</returns>
        public static bool CheckStrSQL_strong(string strSQLWhere)
        {
            //Regex rg = new Regex(REGEXP_IS_DECODE_HTML);
            bool bo = true;
            strSQLWhere = strSQLWhere.ToLower();
            if (strSQLWhere.Contains("*"))
            {
                throw new Exception("SQLע��:'*'");
            }
            if (strSQLWhere.Contains(";"))
            {
                throw new Exception("SQLע��:';'");
            }
            if (strSQLWhere.Contains("<"))
            {
                throw new Exception("SQLע��:'<'");
            }
            if (strSQLWhere.Contains(">"))
            {
                throw new Exception("SQLע��:'>'");
            }
            if (strSQLWhere.Contains("&"))
            {
                throw new Exception("SQLע��:'&'");
            }
            if (strSQLWhere.Contains("or "))
            {
                throw new Exception("SQLע��:'or'");
            }
            if (strSQLWhere.Contains("drop"))
            {
                throw new Exception("SQLע��:'drop'");
            }
            if (strSQLWhere.Contains("delete"))
            {
                throw new Exception("SQLע��:'delete'");
            }
            if (strSQLWhere.Contains("exec"))
            {
                throw new Exception("SQLע��:'exec'");
            }
            if (strSQLWhere.Contains("insert"))
            {
                throw new Exception("SQLע��:'insert'");
            }
            if (strSQLWhere.Contains("update"))
            {
                throw new Exception("SQLע��:'update'");
            }
            if (strSQLWhere.Contains("count"))
            {
                throw new Exception("SQLע��:'count'");
            }
            if (strSQLWhere.Contains("chr"))
            {
                throw new Exception("SQLע��:'chr'");
            }
            if (strSQLWhere.Contains("char"))
            {
                throw new Exception("SQLע��:'char'");
            }
            if (strSQLWhere.Contains("javascript"))
            {
                throw new Exception("SQLע��:'javascript'");
            }
            if (strSQLWhere.Contains("master"))
            {
                throw new Exception("SQLע��:'master'");
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
            if (strSQLWhere.Contains("waitfor"))
            {
                throw new Exception("SQLע��:'waitfor'");
            }
            if (strSQLWhere.Contains("alter"))
            {
                throw new Exception("SQLע��:'alter'");
            }

            if (strSQLWhere.Contains("("))
            {
                throw new Exception("SQLע��:'('");
            }
            if (strSQLWhere.Contains(")"))
            {
                throw new Exception("SQLע��:')'");
            }
            if (strSQLWhere.Contains("%"))
            {
                throw new Exception("SQLע��:'%'");
            }
            if (strSQLWhere.Contains("where"))
            {
                throw new Exception("SQLע��:'where'");
            }
            if (strSQLWhere.Contains("or ")
                )
            {
                throw new Exception("SQLע��:'or'");
            }
            if (strSQLWhere.Contains("master"))
            {
                throw new Exception("SQLע��:'master'");
            }
            if (strSQLWhere.Contains("like"))
            {
                throw new Exception("SQLע��:'like'");
            }
            if (strSQLWhere.Contains("'"))
            {
                throw new Exception("SQLע��:'�Ƿ�������'");
            }
            bo = false;
            return bo;
        }

        /// <summary>
        /// У��������ַ�������SQLע��
        /// </summary>
        /// <param name="strSQLWhere">������Դ�ַ���</param>
        /// <returns>������������ע��ͷ���TRUE�����򷵻�FALSE</returns>
        public static bool CheckStrSQL(string strSQLWhere)
        {
            //Regex rg = new Regex(REGEXP_IS_DECODE_HTML);
            bool bo = true;
            strSQLWhere = strSQLWhere.ToLower();
            strSQLWhere = clsString.RemoveStringValueInSingleQuotation(strSQLWhere);
            if (strSQLWhere.Contains("*"))
            {
                throw new Exception("SQLע��:'*'");
            }
            if (strSQLWhere.Contains(";"))
            {
                throw new Exception("SQLע��:';'");
            }
            //if (strSQLWhere.Contains("<"))
            //{
            //    throw new Exception("SQLע��:'<'");
            //}
            //if (strSQLWhere.Contains(">"))
            //{
            //    throw new Exception("SQLע��:'>'");
            //}
            if (strSQLWhere.Contains("&"))
            {
                throw new Exception("SQLע��:'&'");
            }
            if (strSQLWhere.Contains("or "))
            {
                throw new Exception("SQLע��:'or'");
            }
            if (strSQLWhere.Contains("drop"))
            {
                throw new Exception("SQLע��:'drop'");
            }
            if (strSQLWhere.Contains("delete "))
            {
                throw new Exception("SQLע��:'delete'");
            }
            if (strSQLWhere.Contains("exec "))
            {
                throw new Exception("SQLע��:'exec'");
            }
            if (strSQLWhere.Contains("insert"))
            {
                throw new Exception("SQLע��:'insert'");
            }
            if (strSQLWhere.Contains("update"))
            {
                throw new Exception("SQLע��:'update'");
            }
            if (strSQLWhere.Contains("count"))
            {
                throw new Exception("SQLע��:'count'");
            }
            if (strSQLWhere.Contains("chr"))
            {
                throw new Exception("SQLע��:'chr'");
            }
            if (strSQLWhere.Contains("char"))
            {
                throw new Exception("SQLע��:'char'");
            }
            if (strSQLWhere.Contains("javascript"))
            {
                throw new Exception("SQLע��:'javascript'");
            }
            if (strSQLWhere.Contains("master"))
            {
                throw new Exception("SQLע��:'master'");
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
            if (strSQLWhere.Contains("create "))
            {
                throw new Exception("SQLע��:'create'");
            }
            if (strSQLWhere.Contains("waitfor"))
            {
                throw new Exception("SQLע��:'waitfor'");
            }
            if (strSQLWhere.Contains("alter"))
            {
                throw new Exception("SQLע��:'alter'");
            }

            //if (strSQLWhere.Contains("("))
            //{
            //    throw new Exception("SQLע��:'('");
            //}
            //if (strSQLWhere.Contains(")"))
            //{
            //    throw new Exception("SQLע��:')'");
            //}
            if (strSQLWhere.Contains("%"))
            {
                throw new Exception("SQLע��:'%'");
            }
            if (strSQLWhere.Contains("where"))
            {
                throw new Exception("SQLע��:'where'");
            }
            if (strSQLWhere.Contains("or ")
                )
            {
                throw new Exception("SQLע��:'or'");
            }
            if (strSQLWhere.Contains("master"))
            {
                throw new Exception("SQLע��:'master'");
            }
            if (strSQLWhere.Contains("like"))
            {
                throw new Exception("SQLע��:'like'");
            }
            bo = false;
            return bo;
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
                        throw new Exception(string.Format("SQLע��:'{0}'", strCheckItem));
                    }
                    if (DetailCheckOr(strSQLWhere) == true)
                    {
                        throw new Exception(string.Format("SQLע��:'{0}'", strCheckItem));
                    }
                }
            }
            bo = false;
            return bo;
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
                        throw new Exception(string.Format("SQLע��:'{0}'", strCheckItem));
                    }
                    if (DetailCheckOr(strSQLWhere) == true)
                    {
                        throw new Exception(string.Format("SQLע��:'{0}'", strCheckItem));
                    }
                }
            }

            bo = false;
            return bo;
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
    }
}