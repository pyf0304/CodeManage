using AGC.BusinessLogic;
using AGC.Entity;
using AgcCommBase;
using com.taishsoft.datetime;

using System.Text;

namespace AutoGCLib
{
    /// <summary>
    /// clsCommonFunc4GC ��ժҪ˵����
    /// ���ɴ���ϵͳ��һЩ���ú���,�ڸ����в���Ҫ���ñ���Ϣ���ֶ���Ϣ
    /// </summary>
    public class clsCommonFunc4GC
	{
		public clsCommonFunc4GC()
		{
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
			//
		}
		/// <summary>
		/// ����ϵͳ�й��õ�һЩУ�麯��,����
		/// �ж��ַ����Ƿ�����ֵ��
		/// �ж��ַ����Ƿ��Ǹ�����
		/// �ж��ַ����Ƿ���������
		/// </summary>
		/// <returns></returns>
		public static string    GenIsNumeric()
		{
			StringBuilder strCodeForCs = new StringBuilder();
			strCodeForCs.Append("\r\n" + "/// <summary>");
			strCodeForCs.Append("\r\n" + "/// �ж��Ƿ���������ֵ");
			strCodeForCs.Append("\r\n" + "/// </summary>");
			strCodeForCs.Append("\r\n" + "/// <param name = \"strValue\">��Ҫ�жϵ��ַ���</param>");
			strCodeForCs.Append("\r\n" + "/// <returns>True/False</returns>");
			strCodeForCs.Append("\r\n" + "public bool IsNumeric(string strValue)");
			strCodeForCs.Append("\r\n" + "{");
			strCodeForCs.Append("\r\n" + "int intLen = strValue.Length;");
			strCodeForCs.Append("\r\n" + "for(int i = 0; i<intLen; i++)");
			strCodeForCs.Append("\r\n" + "{");
			strCodeForCs.Append("\r\n" + "if (char.IsDigit(strValue, i)  ==  false)");
			strCodeForCs.Append("\r\n" + "{");
			strCodeForCs.Append("\r\n" + "return false;");
			strCodeForCs.Append("\r\n" + "}");
			strCodeForCs.Append("\r\n" + "}");
			strCodeForCs.Append("\r\n" + "return true;");
			strCodeForCs.Append("\r\n" + "}");
			return strCodeForCs.ToString();
		}
		public static string    GenIsDigit()
		{
			StringBuilder strCodeForCs = new StringBuilder();
			strCodeForCs.Append("\r\n" + "/// <summary>");
			strCodeForCs.Append("\r\n" + "/// �ж��Ƿ�������");
			strCodeForCs.Append("\r\n" + "/// </summary>");
			strCodeForCs.Append("\r\n" + "/// <param name = \"strValue\">��Ҫ�жϵ��ַ���</param>");
			strCodeForCs.Append("\r\n" + "/// <returns>True/False</returns>");
			strCodeForCs.Append("\r\n" + "public bool IsDigit(string strValue)");
			strCodeForCs.Append("\r\n" + "{");
			strCodeForCs.Append("\r\n" + "int intLen = strValue.Length;");
			strCodeForCs.Append("\r\n" + "for(int i = 0; i<intLen; i++)");
			strCodeForCs.Append("\r\n" + "{");
			strCodeForCs.Append("\r\n" + "if (char.IsDigit(strValue, i)  ==  false)");
			strCodeForCs.Append("\r\n" + "{");
			strCodeForCs.Append("\r\n" + "return false;");
			strCodeForCs.Append("\r\n" + "}");
			strCodeForCs.Append("\r\n" + "}");
			strCodeForCs.Append("\r\n" + "return true;");
			strCodeForCs.Append("\r\n" + "}");
			return strCodeForCs.ToString();
		}
		public static string    GenIsFloat()
		{
			StringBuilder strCodeForCs = new StringBuilder();
			strCodeForCs.Append("\r\n" + "/// <summary>");
			strCodeForCs.Append("\r\n" + "/// �ж��Ƿ��Ǹ�������ֵ");
			strCodeForCs.Append("\r\n" + "/// </summary>");
			strCodeForCs.Append("\r\n" + "/// <param name = \"strValue\">��Ҫ�жϵ��ַ���</param>");
			strCodeForCs.Append("\r\n" + "/// <returns>True/False</returns>");
			strCodeForCs.Append("\r\n" + "public bool IsFloat(string strValue)");
			strCodeForCs.Append("\r\n" + "{");
			strCodeForCs.Append("\r\n" + "int intPointNum = 0;");
			strCodeForCs.Append("\r\n" + "char [] arrChar = strValue.ToCharArray();");
			strCodeForCs.Append("\r\n" + "int intLen = strValue.Length;");
			strCodeForCs.Append("\r\n" + "for(int i = 0; i<intLen; i++)");
			strCodeForCs.Append("\r\n" + "{");
			strCodeForCs.Append("\r\n" + "if (char.IsDigit(strValue, i)  ==  true || arrChar[i]  ==  '.')");
			strCodeForCs.Append("\r\n" + "{");
			strCodeForCs.Append("\r\n" + "}");
			strCodeForCs.Append("\r\n" + "else");
			strCodeForCs.Append("\r\n" + "{");
			strCodeForCs.Append("\r\n" + "return false;");
			strCodeForCs.Append("\r\n" + "}");
			strCodeForCs.Append("\r\n" + "if (arrChar[i]  ==  '.') intPointNum++;");

			strCodeForCs.Append("\r\n" + "}");
			strCodeForCs.Append("\r\n" + "//����ܹ��м���С����,����ж���1��С����,�Ͳ���ȷ");
			strCodeForCs.Append("\r\n" + "if (intPointNum>1) return false;");
			strCodeForCs.Append("\r\n" + "return true;");
			strCodeForCs.Append("\r\n" + "}");
			return strCodeForCs.ToString();
		}

		public static string    GenIsDate()
		{
			StringBuilder strCodeForCs = new StringBuilder();
			strCodeForCs.Append("\r\n" + "/// <summary>");
			strCodeForCs.Append("\r\n" + "/// �жϸ����ַ����Ƿ�������������");
			strCodeForCs.Append("\r\n" + "/// </summary>");
			strCodeForCs.Append("\r\n" + "/// <param name = \"strValue\">��Ҫ�жϵ��ַ���</param>");
			strCodeForCs.Append("\r\n" + "/// <returns>True/False</returns>");
			strCodeForCs.Append("\r\n" + "public bool IsDate(string strValue)");
			strCodeForCs.Append("\r\n" + "{");
			strCodeForCs.Append("\r\n" + "string strDate = \"\";");
			strCodeForCs.Append("\r\n" + "if (strValue  ==  \"\") return true;");
			strCodeForCs.Append("\r\n" + "if (strValue.Length <8) ");
			strCodeForCs.Append("\r\n" + "{");
			strCodeForCs.Append("\r\n" + "return false;");
			strCodeForCs.Append("\r\n" + "}");
			strCodeForCs.Append("\r\n" + "if (strValue.Length  ==  8)");
			strCodeForCs.Append("\r\n" + "{");
			strCodeForCs.Append("\r\n" + "strDate = strValue.Substring(0,4) + \"-\" + strValue.Substring(4,2) + \"-\" + strValue.Substring(6,2);");
			strCodeForCs.Append("\r\n" + "}");
			strCodeForCs.Append("\r\n" + "strDate = strValue;");
			strCodeForCs.Append("\r\n" + "try");
			strCodeForCs.Append("\r\n" + "{");
			strCodeForCs.Append("\r\n" + "DateTime dt = DateTime.Parse(strDate);");
			strCodeForCs.Append("\r\n" + "}");
			strCodeForCs.Append("\r\n" + "catch (Exception expt)");
			strCodeForCs.Append("\r\n" + "{");
			strCodeForCs.Append("\r\n" + "return false;");
			strCodeForCs.Append("\r\n" + "}");
			strCodeForCs.Append("\r\n" + "return true;");
			strCodeForCs.Append("\r\n" + "}");
			return strCodeForCs.ToString();
		}
		public static string    GenGetTodayStr()
		{
			StringBuilder strCodeForCs = new StringBuilder();

			strCodeForCs.Append("\r\n" + "/// <summary>");
			strCodeForCs.Append("\r\n" + "/// ����:��ȡ��ǰ���ڵ��ַ���");
			strCodeForCs.Append("\r\n" + "/// ���ڸ�ʽ:");
			strCodeForCs.Append("\r\n" + "///    ���ڵ��ַ����ĸ�ʽ������:");
			strCodeForCs.Append("\r\n" + "///		1��YYYYMMDD��	����20050120");
			strCodeForCs.Append("\r\n" + "///		2��YYYY-MM-DD	����2005-01-20");
			strCodeForCs.Append("\r\n" + "///		3��YYYY/MM/DD	����2005/01/20");
			strCodeForCs.Append("\r\n" + "/// </summary>");
			strCodeForCs.Append("\r\n" + "/// <param name = \"intFormat\">���ڸ�ʽ,����3��,�������0,1,2");
			strCodeForCs.Append("\r\n" + "///							������ͬ,��������ֵ�Ͳ�ͬ,");
			strCodeForCs.Append("\r\n" + "///							�μ���������ڸ�ʽ");
			strCodeForCs.Append("\r\n" + "///	</param>");
			strCodeForCs.Append("\r\n" + "/// <returns>���ص�ǰ���ڵ��ַ���</returns>");
			strCodeForCs.Append("\r\n" + "public string getTodayStr(int intFormat)");
			strCodeForCs.Append("\r\n" + "{");
			strCodeForCs.Append("\r\n" + "string strToday;");
			strCodeForCs.Append("\r\n" + "string strYear, strMonth, strDay;");
			strCodeForCs.Append("\r\n" + "int intYear, intMonth, intDay;");
			strCodeForCs.Append("\r\n" + "intYear = System.DateTime.Today.Year;");
			strCodeForCs.Append("\r\n" + "intMonth = System.DateTime.Today.Month;");
			strCodeForCs.Append("\r\n" + "intDay = System.DateTime.Today.Day;");
			strCodeForCs.Append("\r\n" + "strYear = intYear.ToString().Trim();");
			strCodeForCs.Append("\r\n" + "if (intMonth>9) strMonth = intMonth.ToString().Trim();");
			strCodeForCs.Append("\r\n" + "else strMonth = \"0\" + intMonth.ToString().Trim();");
			strCodeForCs.Append("\r\n" + "if (intDay>9) strDay = intDay.ToString().Trim();");
			strCodeForCs.Append("\r\n" + "else strDay = \"0\" + intDay.ToString().Trim();");
			strCodeForCs.Append("\r\n" + "strToday = strYear + strMonth + strDay;");
			strCodeForCs.Append("\r\n" + "switch(intFormat)");
			strCodeForCs.Append("\r\n" + "{");
			strCodeForCs.Append("\r\n" + "case 0:");
			strCodeForCs.Append("\r\n" + "strToday = strYear + strMonth + strDay;");
			strCodeForCs.Append("\r\n" + "break;");
			strCodeForCs.Append("\r\n" + "case 1:");
			strCodeForCs.Append("\r\n" + "strToday = strYear + \"-\" + strMonth + \"-\" + strDay;");
			strCodeForCs.Append("\r\n" + "break;");
			strCodeForCs.Append("\r\n" + "case 2:");
			strCodeForCs.Append("\r\n" + "strToday = strYear + \"/\" + strMonth + \"/\" + strDay;");
			strCodeForCs.Append("\r\n" + "break;");
			strCodeForCs.Append("\r\n" + "}");
			strCodeForCs.Append("\r\n" + "return strToday;");
			strCodeForCs.Append("\r\n" + "}");
			return strCodeForCs.ToString();
		}
		public static string    GenGetCurrMonth()
		{
			StringBuilder strCodeForCs = new StringBuilder();

			strCodeForCs.Append("\r\n" + "/// <summary>");
			strCodeForCs.Append("\r\n" + "/// ����:��ȡ��ǰ�µ��ַ���");
			strCodeForCs.Append("\r\n" + "/// �µĸ�ʽ:");
			strCodeForCs.Append("\r\n" + "///    �µ��ַ����ĸ�ʽ������:");
			strCodeForCs.Append("\r\n" + "///		1��YYYYMM��	����200501");
			strCodeForCs.Append("\r\n" + "///		2��YYYY-MM-DD	����2005-01");
			strCodeForCs.Append("\r\n" + "///		3��YYYY/MM/DD	����2005/01");
			strCodeForCs.Append("\r\n" + "/// </summary>");
			strCodeForCs.Append("\r\n" + "/// <param name = \"intFormat\">�µĸ�ʽ,����3��,�������0,1,2");
			strCodeForCs.Append("\r\n" + "///							������ͬ,��������ֵ�Ͳ�ͬ,");
			strCodeForCs.Append("\r\n" + "///							�μ�������µĸ�ʽ");
			strCodeForCs.Append("\r\n" + "///	</param>");
			strCodeForCs.Append("\r\n" + "/// <returns>���ص�ǰ�µ��ַ���</returns>");
			strCodeForCs.Append("\r\n" + "public string getCurrMonth(int intFormat)");
			strCodeForCs.Append("\r\n" + "{");
			strCodeForCs.Append("\r\n" + "string strCurrMonth;");
			strCodeForCs.Append("\r\n" + "string strYear, strMonth;");
			strCodeForCs.Append("\r\n" + "int intYear, intMonth;");
			strCodeForCs.Append("\r\n" + "intYear = System.DateTime.Today.Year;");
			strCodeForCs.Append("\r\n" + "intMonth = System.DateTime.Today.Month;");
			strCodeForCs.Append("\r\n" + "strYear = intYear.ToString().Trim();");
			strCodeForCs.Append("\r\n" + "if (intMonth>9) strMonth = intMonth.ToString().Trim();");
			strCodeForCs.Append("\r\n" + "else strMonth = \"0\" + intMonth.ToString().Trim();");
			strCodeForCs.Append("\r\n" + "strCurrMonth = strYear + strMonth;");
			strCodeForCs.Append("\r\n" + "switch(intFormat)");
			strCodeForCs.Append("\r\n" + "{");
			strCodeForCs.Append("\r\n" + "case 0:");
			strCodeForCs.Append("\r\n" + "strCurrMonth = strYear + strMonth;");
			strCodeForCs.Append("\r\n" + "break;");
			strCodeForCs.Append("\r\n" + "case 1:");
			strCodeForCs.Append("\r\n" + "strCurrMonth = strYear + \"-\" + strMonth;");
			strCodeForCs.Append("\r\n" + "break;");
			strCodeForCs.Append("\r\n" + "case 2:");
			strCodeForCs.Append("\r\n" + "strCurrMonth = strYear + \"/\" + strMonth;");
			strCodeForCs.Append("\r\n" + "break;");
			strCodeForCs.Append("\r\n" + "}");
			strCodeForCs.Append("\r\n" + "return strCurrMonth;");
			strCodeForCs.Append("\r\n" + "}");
			return strCodeForCs.ToString();
		}
        public static string GenUserInfoAndDate4Projects(string strCurrUserName, clsProjectsEN objProjectsEN, string strCmPrjId,
            string strClassName, clsPubConst.LangType ltLangType)
        {
            var objCMProject = clsCMProjectBL.GetObjByCmPrjId_Cache(strCmPrjId);
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /*-- -- -- -- -- -- -- -- -- -- --");
            strCodeForCs.AppendFormat("\r\n ���ɴ���汾:{0}", clsSysParaEN_Local.strVersion);
            //strCodeForCs.AppendFormat("\r\n ///����:{0}", "���Է�");
            strCodeForCs.AppendFormat("\r\n ��������:{0}", clsDateTime.getTodayDateTimeStr(2));
            strCodeForCs.AppendFormat("\r\n ������:{0}", strCurrUserName);
            strCodeForCs.AppendFormat("\r\n ��������:{0}({1})", objProjectsEN.PrjName, objProjectsEN.PrjId);
            strCodeForCs.AppendFormat("\r\n CM����:{0}(��������ĸ{1})", objCMProject.CmPrjName, objCMProject.IsFstLcase?"Сд":"���޶�");

            strCodeForCs.AppendFormat("\r\n ��������:{0}", objProjectsEN.PrjDomain);
            strCodeForCs.AppendFormat("\r\n ��������:{0}", clsPubConst.GetLangTypeStringByLangType(ltLangType));

            strCodeForCs.AppendFormat("\r\n ע��:1����Ҫ���ݵײ�(PubDataBase.dll)�İ汾:{0}", com.taishsoft.syspara.clsSysPara_PubDataBase.strVersion);
            strCodeForCs.AppendFormat("\r\n      2����Ҫ����������(TzPubFunction.dll)�İ汾:{0}", com.taishsoft.common.clsSysPara_TzPubFunction.strVersion);
            strCodeForCs.Append("\r\n == == == == == == == == == == == == ");
            strCodeForCs.Append("\r\n **/");
            return strCodeForCs.ToString();
        }
        public static string GenUserInfoAndDate(string strCurrUserName, clsPrjTabENEx objPrjTabENEx)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            var objCMProject = clsCMProjectBL.GetObjByCmPrjId_Cache(objPrjTabENEx.CmPrjId);
            strCodeForCs.Append("\r\n /*-- -- -- -- -- -- -- -- -- -- --");
            strCodeForCs.AppendFormat("\r\n" + " ����:{0}", objPrjTabENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + " ����:{0}({1})", objPrjTabENEx.TabName, objPrjTabENEx.TabId);

            strCodeForCs.AppendFormat("\r\n ���ɴ���汾:{0}", clsSysParaEN_Local.strVersion);
            //strCodeForCs.AppendFormat("\r\n ///����:{0}", "���Է�");
            strCodeForCs.AppendFormat("\r\n ��������:{0}", clsDateTime.getTodayDateTimeStr(2));
            strCodeForCs.AppendFormat("\r\n ������:{0}", strCurrUserName);
            strCodeForCs.AppendFormat("\r\n ���ɷ�����IP:{0}", clsSysParaEN.spServerIp);
            strCodeForCs.AppendFormat("\r\n ��������:{0}({1})", objPrjTabENEx.objProjectsEN.PrjName, objPrjTabENEx.PrjId);
            strCodeForCs.AppendFormat("\r\n CM����:{0}(��������ĸ{1})", objCMProject.CmPrjName, objCMProject.IsFstLcase?"Сд":"���޶�");

            if (string.IsNullOrEmpty(objPrjTabENEx.PrjDataBaseId) == false)
            {
                clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseId_Cache(objPrjTabENEx.PrjDataBaseId);

                strCodeForCs.AppendFormat("\r\n ������ݿ�:{0}{1}", objPrjDataBaseEN.IpAddress, objPrjDataBaseEN.DataBaseName);
                strCodeForCs.AppendFormat("\r\n PrjDataBaseId:{0}", objPrjDataBaseEN.PrjDataBaseId);
            }
            strCodeForCs.AppendFormat("\r\n ģ��������:{0}({1})", objPrjTabENEx.ObjFuncModule.FuncModuleName, objPrjTabENEx.ObjFuncModule.FuncModuleEnName);
            clsCodeTypeEN objCodeTypeEN = clsCodeTypeBL.GetObjByCodeTypeId_Cache(objPrjTabENEx.CodeTypeId);
            strCodeForCs.AppendFormat("\r\n ���-����:{0}({1})", objCodeTypeEN.CodeTypeName, objCodeTypeEN.CodeTypeENName);
            strCodeForCs.AppendFormat("\r\n �������:{0}", clsPubConst.GetLangTypeStringByLangType(objPrjTabENEx.LangType));
            strCodeForCs.AppendFormat("\r\n ע��:1����Ҫ���ݵײ�(PubDataBase.dll)�İ汾:{0}", com.taishsoft.syspara.clsSysPara_PubDataBase.strVersion);
            strCodeForCs.AppendFormat("\r\n        2����Ҫ����������(TzPubFunction.dll)�İ汾:{0}", com.taishsoft.common.clsSysPara_TzPubFunction.strVersion);
            strCodeForCs.Append("\r\n == == == == == == == == == == == == ");
            strCodeForCs.Append("\r\n **/");
            return strCodeForCs.ToString();
        }

        public static string GenUserInfoAndDate4PureClass(string strCurrUserName, clsPrjTabENEx objPrjTabENEx)
        {
            var objCMProject = clsCMProjectBL.GetObjByCmPrjId_Cache(objPrjTabENEx.CmPrjId);
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /*-- -- -- -- -- -- -- -- -- -- --");
            strCodeForCs.AppendFormat("\r\n" + " ����:{0}", objPrjTabENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + " ����:{0}({1})", objPrjTabENEx.TabName, objPrjTabENEx.TabId);

            strCodeForCs.AppendFormat("\r\n ���ɴ���汾:{0}", clsSysParaEN_Local.strVersion);
            //strCodeForCs.AppendFormat("\r\n ///����:{0}", "���Է�");
            strCodeForCs.AppendFormat("\r\n ��������:{0}", clsDateTime.getTodayDateTimeStr(2));
            strCodeForCs.AppendFormat("\r\n ������:{0}", strCurrUserName);
            strCodeForCs.AppendFormat("\r\n ���ɷ�����IP:{0}", clsSysParaEN.spServerIp);
            strCodeForCs.AppendFormat("\r\n ��������:{0}({1})", objPrjTabENEx.objProjectsEN.PrjName, objPrjTabENEx.PrjId);
            strCodeForCs.AppendFormat("\r\n CM����:{0}(��������ĸ{1})", objCMProject.CmPrjName, objCMProject.IsFstLcase?"Сд":"���޶�");

            //if (string.IsNullOrEmpty(objPrjTabENEx.PrjDataBaseId) == false)
            //{
            //    clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseId_Cache(objPrjTabENEx.PrjDataBaseId);

            //    strCodeForCs.AppendFormat("\r\n ������ݿ�:{0}{1}", objPrjDataBaseEN.IpAddress, objPrjDataBaseEN.DataBaseName);
            //    strCodeForCs.AppendFormat("\r\n PrjDataBaseId:{0}", objPrjDataBaseEN.PrjDataBaseId);
            //}
            strCodeForCs.AppendFormat("\r\n ģ��������:{0}({1})", objPrjTabENEx.ObjFuncModule.FuncModuleName, objPrjTabENEx.ObjFuncModule.FuncModuleEnName);

            clsCodeTypeEN objCodeTypeEN = clsCodeTypeBL.GetObjByCodeTypeId_Cache(objPrjTabENEx.CodeTypeId);
            strCodeForCs.AppendFormat("\r\n ���-����:{0}({1})", objCodeTypeEN.CodeTypeName, objCodeTypeEN.CodeTypeENName);
            strCodeForCs.AppendFormat("\r\n �������:{0}", clsPubConst.GetLangTypeStringByLangType(objPrjTabENEx.LangType));
            strCodeForCs.AppendFormat("\r\n ע��:1����Ҫ����������(TzPubFunction.dll)�İ汾:{0}", com.taishsoft.common.clsSysPara_TzPubFunction.strVersion);
            strCodeForCs.Append("\r\n == == == == == == == == == == == == ");
            strCodeForCs.Append("\r\n **/");
            return strCodeForCs.ToString();
        }


        public static string GenUserInfoAndDate4TypeScript(string strCurrUserName, clsPrjTabENEx objPrjTabENEx)
        {
            var objCMProject = clsCMProjectBL.GetObjByCmPrjId_Cache(objPrjTabENEx.CmPrjId);
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /**");
            strCodeForCs.AppendFormat("\r\n" + " * ����:{0}", objPrjTabENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + " * ����:{0}({1})", objPrjTabENEx.TabName, objPrjTabENEx.TabId);

            strCodeForCs.AppendFormat("\r\n * ���ɴ���汾:{0}", clsSysParaEN_Local.strVersion);
            //strCodeForCs.AppendFormat("\r\n ///����:{0}", "���Է�");
            strCodeForCs.AppendFormat("\r\n * ��������:{0}", clsDateTime.getTodayDateTimeStr(2));
            strCodeForCs.AppendFormat("\r\n * ������:{0}", strCurrUserName);
            strCodeForCs.AppendFormat("\r\n * ���ɷ�����IP:{0}", clsSysParaEN.spServerIp);
            strCodeForCs.AppendFormat("\r\n ��������:{0}({1})", objPrjTabENEx.objProjectsEN.PrjName, objPrjTabENEx.PrjId);
            strCodeForCs.AppendFormat("\r\n CM����:{0}(��������ĸ{1})", objCMProject.CmPrjName, objCMProject.IsFstLcase?"Сд":"���޶�");

            if (string.IsNullOrEmpty(objPrjTabENEx.PrjDataBaseId) == false)
            {
                clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseId_Cache(objPrjTabENEx.PrjDataBaseId);

                strCodeForCs.AppendFormat("\r\n * ������ݿ�:{0}{1}", objPrjDataBaseEN.IpAddress, objPrjDataBaseEN.DataBaseName);
                strCodeForCs.AppendFormat("\r\n * PrjDataBaseId:{0}", objPrjDataBaseEN.PrjDataBaseId);
            }
            strCodeForCs.AppendFormat("\r\n ģ��������:{0}({1})", objPrjTabENEx.ObjFuncModule.FuncModuleName, objPrjTabENEx.ObjFuncModule.FuncModuleEnName);
            clsCodeTypeEN objCodeTypeEN = clsCodeTypeBL.GetObjByCodeTypeId_Cache(objPrjTabENEx.CodeTypeId);
            strCodeForCs.AppendFormat("\r\n * ���-����:{0}({1})", objCodeTypeEN.CodeTypeName, objCodeTypeEN.CodeTypeENName);
            strCodeForCs.AppendFormat("\r\n * �������:{0}", clsPubConst.GetLangTypeStringByLangType(objPrjTabENEx.LangType));
            strCodeForCs.AppendFormat("\r\n * ע��:1����Ҫ���ݵײ�(PubDataBase.dll)�İ汾:{0}", com.taishsoft.syspara.clsSysPara_PubDataBase.strVersion);
            strCodeForCs.AppendFormat("\r\n   *      2����Ҫ����������(TzPubFunction.dll)�İ汾:{0}", com.taishsoft.common.clsSysPara_TzPubFunction.strVersion);
            strCodeForCs.Append("\r\n **/");
            return strCodeForCs.ToString();
        }

        public static string GenUserInfoAndDate4Java(string strCurrUserName, clsPrjTabENEx objPrjTabENEx)
        {
            var objCMProject = clsCMProjectBL.GetObjByCmPrjId_Cache(objPrjTabENEx.CmPrjId);
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * -- -- -- -- -- -- -- -- -- -- --");
            strCodeForCs.AppendFormat("\r\n" + "* ����:{0}", objPrjTabENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "*  ����:{0}({1})", objPrjTabENEx.TabName, objPrjTabENEx.TabId);
            strCodeForCs.AppendFormat("\r\n * ���ɴ���汾:{0}", clsSysParaEN_Local.strVersion);
            //strCodeForCs.AppendFormat("\r\n ///����:{0}", "���Է�");
            strCodeForCs.AppendFormat("\r\n * ��������:{0}", clsDateTime.getTodayDateTimeStr(2));
            strCodeForCs.AppendFormat("\r\n * ������:{0}", strCurrUserName);
            strCodeForCs.AppendFormat("\r\n * ���ɷ�����IP:{0}", clsSysParaEN.spServerIp);
            strCodeForCs.AppendFormat("\r\n ��������:{0}({1})", objPrjTabENEx.objProjectsEN.PrjName, objPrjTabENEx.PrjId);
            strCodeForCs.AppendFormat("\r\n CM����:{0}(��������ĸ{1})", objCMProject.CmPrjName, objCMProject.IsFstLcase?"Сд":"���޶�");

            if (string.IsNullOrEmpty(objPrjTabENEx.PrjDataBaseId) == false)
            {
                clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseId_Cache(objPrjTabENEx.PrjDataBaseId);

                strCodeForCs.AppendFormat("\r\n ������ݿ�:{0}{1}", objPrjDataBaseEN.IpAddress, objPrjDataBaseEN.DataBaseName);
                strCodeForCs.AppendFormat("\r\n PrjDataBaseId:{0}", objPrjDataBaseEN.PrjDataBaseId);
            }
            strCodeForCs.AppendFormat("\r\n * ģ��������:{0}({1})", objPrjTabENEx.ObjFuncModule.FuncModuleName, objPrjTabENEx.ObjFuncModule.FuncModuleEnName);
            strCodeForCs.AppendFormat("\r\n * ���-����:{0}-{1}", objPrjTabENEx.CodeTypeId, 
                clsCodeTypeBL.GetNameByCodeTypeId_Cache(objPrjTabENEx.CodeTypeId));
            strCodeForCs.AppendFormat("\r\n * �������:{0}", clsPubConst.GetLangTypeStringByLangType(objPrjTabENEx.LangType));
            strCodeForCs.AppendFormat("\r\n * ע��:1����Ҫ���ݵײ�(PubDataBase.dll)�İ汾:{0}", com.taishsoft.syspara.clsSysPara_PubDataBase.strVersion);
            strCodeForCs.AppendFormat("\r\n * 2����Ҫ����������(TzPubFunction.dll)�İ汾:{0}", com.taishsoft.common.clsSysPara_TzPubFunction.strVersion);
            strCodeForCs.Append("\r\n * == == == == == == == == == == == == ");
            strCodeForCs.Append("\r\n **/");
            return strCodeForCs.ToString();
        }

        public static string GenUserInfoAndDate(string strCurrUserName, clsWebSrvClassENEx objWebSrvClassENEx)
        {
            var objCMProject = clsCMProjectBL.GetObjByCmPrjId_Cache(objWebSrvClassENEx.CmPrjId);
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /*-- -- -- -- -- -- -- -- -- -- --");
            strCodeForCs.AppendFormat("\r\n" + " ����:{0}", objWebSrvClassENEx.ClsName);
            //strCodeForCs.AppendFormat("\r\n" + " ����:{0}", objWebSrvClassENEx.TabName);
            strCodeForCs.AppendFormat("\r\n ���ɴ���汾:{0}", clsSysParaEN_Local.strVersion);
            //strCodeForCs.AppendFormat("\r\n ///����:{0}", "���Է�");
            strCodeForCs.AppendFormat("\r\n ��������:{0}", clsDateTime.getTodayDateTimeStr(2));
            strCodeForCs.AppendFormat("\r\n ������:{0}", strCurrUserName);
            strCodeForCs.AppendFormat("\r\n ���ɷ�����IP:{0}", clsSysParaEN.spServerIp);
            strCodeForCs.AppendFormat("\r\n ��������:{0}({1})", objWebSrvClassENEx.objProjectsEN.PrjName, objWebSrvClassENEx.PrjId);
            strCodeForCs.AppendFormat("\r\n CM����:{0}(��������ĸ{1})", objCMProject.CmPrjName, objCMProject.IsFstLcase?"Сд":"���޶�");

            if (string.IsNullOrEmpty(objWebSrvClassENEx.PrjDataBaseId) == false)
            {
                clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseId_Cache(objWebSrvClassENEx.PrjDataBaseId);

                strCodeForCs.AppendFormat("\r\n ������ݿ�:{0}{1}", objPrjDataBaseEN.IpAddress, objPrjDataBaseEN.DataBaseName);
                strCodeForCs.AppendFormat("\r\n PrjDataBaseId:{0}", objPrjDataBaseEN.PrjDataBaseId);
            }
            strCodeForCs.AppendFormat("\r\n ģ��������:{0}({1})", objWebSrvClassENEx.ObjFuncModule.FuncModuleName, objWebSrvClassENEx.ObjFuncModule.FuncModuleEnName);
            clsCodeTypeEN objCodeTypeEN = clsCodeTypeBL.GetObjByCodeTypeId_Cache(objWebSrvClassENEx.CodeTypeId);
            strCodeForCs.AppendFormat("\r\n ���-����:{0}({1})", objCodeTypeEN.CodeTypeName, objCodeTypeEN.CodeTypeENName);

            strCodeForCs.AppendFormat("\r\n �������:{0}", clsPubConst.GetLangTypeStringByLangType(objWebSrvClassENEx.LangType));
            strCodeForCs.AppendFormat("\r\n ע��:1����Ҫ���ݵײ�(PubDataBase.dll)�İ汾:{0}", com.taishsoft.syspara.clsSysPara_PubDataBase.strVersion);
            strCodeForCs.AppendFormat("\r\n        2����Ҫ����������(TzPubFunction.dll)�İ汾:{0}", com.taishsoft.common.clsSysPara_TzPubFunction.strVersion);
            strCodeForCs.Append("\r\n == == == == == == == == == == == == ");
            strCodeForCs.Append("\r\n **/");
            return strCodeForCs.ToString();
        }

        public static string GenUserInfoAndDate(string strCurrUserName, clsViewInfoENEx objViewInfoENEx)
        {
            var objCMProject = clsCMProjectBL.GetObjByCmPrjId_Cache(objViewInfoENEx.CmPrjId);
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /*-- -- -- -- -- -- -- -- -- -- --");
            strCodeForCs.AppendFormat("\r\n" + " ����:{0}", objViewInfoENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + " ������:{0}({1})", objViewInfoENEx.ViewName, objViewInfoENEx.ViewId);
         
            strCodeForCs.AppendFormat("\r\n ���ɴ���汾:{0}", clsSysParaEN_Local.strVersion);
            //strCodeForCs.AppendFormat("\r\n ///����:{0}", "���Է�");
            strCodeForCs.AppendFormat("\r\n ��������:{0}", clsDateTime.getTodayDateTimeStr(2));
            strCodeForCs.AppendFormat("\r\n ������:{0}", strCurrUserName);
            strCodeForCs.AppendFormat("\r\n ��������:{0}({1})", objViewInfoENEx.objProjectsEN.PrjName, objViewInfoENEx.PrjId);
            strCodeForCs.AppendFormat("\r\n CM����:{0}(��������ĸ{1})", objCMProject.CmPrjName, objCMProject.IsFstLcase?"Сд":"���޶�");


            if (string.IsNullOrEmpty(objViewInfoENEx.PrjDataBaseId) == false)
            {
                clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseId_Cache(objViewInfoENEx.PrjDataBaseId);

                strCodeForCs.AppendFormat("\r\n ������ݿ�:{0}{1}", objPrjDataBaseEN.IpAddress, objPrjDataBaseEN.DataBaseName);
                strCodeForCs.AppendFormat("\r\n PrjDataBaseId:{0}", objPrjDataBaseEN.PrjDataBaseId);
            }
            strCodeForCs.AppendFormat("\r\n ģ��������:{0}({1})", objViewInfoENEx.ObjFuncModule.FuncModuleName, objViewInfoENEx.ObjFuncModule.FuncModuleEnName);
            clsCodeTypeEN objCodeTypeEN = clsCodeTypeBL.GetObjByCodeTypeId_Cache(objViewInfoENEx.CodeTypeId);
            strCodeForCs.AppendFormat("\r\n ���-����:{0}({1})", objCodeTypeEN.CodeTypeName, objCodeTypeEN.CodeTypeENName);

            strCodeForCs.AppendFormat("\r\n �������:{0}", clsPubConst.GetLangTypeStringByLangType(objViewInfoENEx.LangType));

            strCodeForCs.AppendFormat("\r\n ע��:1����Ҫ���ݵײ�(PubDataBase.dll)�İ汾:{0}", com.taishsoft.syspara.clsSysPara_PubDataBase.strVersion);
            strCodeForCs.AppendFormat("\r\n      2����Ҫ����������(TzPubFunction.dll)�İ汾:{0}", com.taishsoft.common.clsSysPara_TzPubFunction.strVersion);
            strCodeForCs.Append("\r\n == == == == == == == == == == == == ");
            strCodeForCs.Append("\r\n **/");
            return strCodeForCs.ToString();
        }

        public static string GenUserInfoAndDate4WebApi(string strCurrUserName, clsViewInfoENEx objViewInfoENEx)
        {
            var objCMProject = clsCMProjectBL.GetObjByCmPrjId_Cache(objViewInfoENEx.CmPrjId);
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.AppendFormat("\r\n" + " * ����:{0}(����:{1})", 
                objViewInfoENEx.ClsName, objViewInfoENEx.ViewName);
            strCodeForCs.AppendFormat("\r\n" + " * ����:{0}({1})", objViewInfoENEx.TabName, objViewInfoENEx.MainTabId);

            strCodeForCs.AppendFormat("\r\n * ���ɴ���汾:{0}", clsSysParaEN_Local.strVersion);
            //strCodeForCs.AppendFormat("\r\n ///����:{0}", "���Է�");
            strCodeForCs.AppendFormat("\r\n * ��������:{0}", clsDateTime.getTodayDateTimeStr(2));
            strCodeForCs.AppendFormat("\r\n * ������:{0}", strCurrUserName);
            strCodeForCs.AppendFormat("\r\n ��������:{0}({1})", objViewInfoENEx.objProjectsEN.PrjName, objViewInfoENEx.PrjId);
            strCodeForCs.AppendFormat("\r\n CM����:{0}(��������ĸ{1})", objCMProject.CmPrjName, objCMProject.IsFstLcase?"Сд":"���޶�");

            if (string.IsNullOrEmpty(objViewInfoENEx.PrjDataBaseId) == false)
            {
                clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseId_Cache(objViewInfoENEx.PrjDataBaseId);

                strCodeForCs.AppendFormat("\r\n * ������ݿ�:{0}{1}", objPrjDataBaseEN.IpAddress, objPrjDataBaseEN.DataBaseName);
                strCodeForCs.AppendFormat("\r\n * PrjDataBaseId:{0}", objPrjDataBaseEN.PrjDataBaseId);
            }
            strCodeForCs.AppendFormat("\r\n * ģ��������:{0}({1})", objViewInfoENEx.ObjFuncModule.FuncModuleName, objViewInfoENEx.ObjFuncModule.FuncModuleEnName);
            clsCodeTypeEN objCodeTypeEN = clsCodeTypeBL.GetObjByCodeTypeId_Cache(objViewInfoENEx.CodeTypeId);
            strCodeForCs.AppendFormat("\r\n * ���-����:{0}({1})", objCodeTypeEN.CodeTypeName, objCodeTypeEN.CodeTypeENName);

            strCodeForCs.AppendFormat("\r\n * �������:{0}", clsPubConst.GetLangTypeStringByLangType(objViewInfoENEx.LangType));
            strCodeForCs.Append("\r\n **/");
            return strCodeForCs.ToString();
        }

        public static string GenUserInfoAndDate4WebApi(string strCurrUserName, clsPrjTabENEx objPrjTabENEx)
        {
            var objCMProject = clsCMProjectBL.GetObjByCmPrjId_Cache(objPrjTabENEx.CmPrjId);
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.AppendFormat("\r\n" + " * ����:{0}", objPrjTabENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + " * ����:{0}({1})", objPrjTabENEx.TabName, objPrjTabENEx.TabId);

            strCodeForCs.AppendFormat("\r\n * ���ɴ���汾:{0}", clsSysParaEN_Local.strVersion);
            //strCodeForCs.AppendFormat("\r\n ///����:{0}", "���Է�");
            strCodeForCs.AppendFormat("\r\n * ��������:{0}", clsDateTime.getTodayDateTimeStr(2));
            strCodeForCs.AppendFormat("\r\n * ������:{0}", strCurrUserName);
            strCodeForCs.AppendFormat("\r\n ��������:{0}({1})", objPrjTabENEx.objProjectsEN.PrjName, objPrjTabENEx.PrjId);
            strCodeForCs.AppendFormat("\r\n CM����:{0}(��������ĸ{1})", objCMProject.CmPrjName, objCMProject.IsFstLcase?"Сд":"���޶�");

            if (string.IsNullOrEmpty(objPrjTabENEx.PrjDataBaseId) == false)
            {
                clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseId_Cache(objPrjTabENEx.PrjDataBaseId);

                strCodeForCs.AppendFormat("\r\n * ������ݿ�:{0}{1}", objPrjDataBaseEN.IpAddress, objPrjDataBaseEN.DataBaseName);
                strCodeForCs.AppendFormat("\r\n * PrjDataBaseId:{0}", objPrjDataBaseEN.PrjDataBaseId);
            }
            strCodeForCs.AppendFormat("\r\n ģ��������:{0}({1})", objPrjTabENEx.ObjFuncModule.FuncModuleName, objPrjTabENEx.ObjFuncModule.FuncModuleEnName);
            clsCodeTypeEN objCodeTypeEN = clsCodeTypeBL.GetObjByCodeTypeId_Cache(objPrjTabENEx.CodeTypeId);
            strCodeForCs.AppendFormat("\r\n * ���-����:{0}({1})", objCodeTypeEN.CodeTypeName, objCodeTypeEN.CodeTypeENName);

            strCodeForCs.AppendFormat("\r\n * �������:{0}", clsPubConst.GetLangTypeStringByLangType(objPrjTabENEx.LangType));

            strCodeForCs.Append("\r\n **/");
            return strCodeForCs.ToString();
        }


        public static string GenUserInfoAndDate4Java(string strCurrUserName, clsViewInfoENEx objViewInfoENEx)
        {
            var objCMProject = clsCMProjectBL.GetObjByCmPrjId_Cache(objViewInfoENEx.CmPrjId);
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /*-- -- -- -- -- -- -- -- -- -- --");
            strCodeForCs.AppendFormat("\r\n" + " ����:{0}", objViewInfoENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + " ����:{0}({1})", objViewInfoENEx.TabName, objViewInfoENEx.MainTabId);
            
            strCodeForCs.AppendFormat("\r\n ���ɴ���汾:{0}", clsSysParaEN_Local.strVersion);
            //strCodeForCs.AppendFormat("\r\n ///����:{0}", "���Է�");
            strCodeForCs.AppendFormat("\r\n ��������:{0}", clsDateTime.getTodayDateTimeStr(2));
            strCodeForCs.AppendFormat("\r\n ������:{0}", strCurrUserName);
            strCodeForCs.AppendFormat("\r\n ��������:{0}({1})", objViewInfoENEx.objProjectsEN.PrjName, objViewInfoENEx.PrjId);
            strCodeForCs.AppendFormat("\r\n CM����:{0}(��������ĸ{1})", objCMProject.CmPrjName, objCMProject.IsFstLcase?"Сд":"���޶�");

            if (string.IsNullOrEmpty(objViewInfoENEx.PrjDataBaseId) == false)
            {
                clsPrjDataBaseEN objPrjDataBaseEN = clsPrjDataBaseBL.GetObjByPrjDataBaseId_Cache(objViewInfoENEx.PrjDataBaseId);

                strCodeForCs.AppendFormat("\r\n ������ݿ�:{0}{1}", objPrjDataBaseEN.IpAddress, objPrjDataBaseEN.DataBaseName);
                strCodeForCs.AppendFormat("\r\n PrjDataBaseId:{0}", objPrjDataBaseEN.PrjDataBaseId);
            }
            strCodeForCs.AppendFormat("\r\n ģ��������:{0}({1})", objViewInfoENEx.ObjFuncModule.FuncModuleName, objViewInfoENEx.ObjFuncModule.FuncModuleEnName);
            clsCodeTypeEN objCodeTypeEN = clsCodeTypeBL.GetObjByCodeTypeId_Cache(objViewInfoENEx.CodeTypeId);
            strCodeForCs.AppendFormat("\r\n ���-����:{0}({1})", objCodeTypeEN.CodeTypeName, objCodeTypeEN.CodeTypeENName);
            strCodeForCs.AppendFormat("\r\n �������:{0}", clsPubConst.GetLangTypeStringByLangType(objViewInfoENEx.LangType));
            strCodeForCs.Append("\r\n == == == == == == == == == == == == ");
            strCodeForCs.Append("\r\n **/");
            return strCodeForCs.ToString();
        }
    }
}
