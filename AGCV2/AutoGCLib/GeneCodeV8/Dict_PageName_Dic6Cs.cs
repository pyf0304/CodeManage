using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AgcCommBase;

using com.taishsoft.commexception;
using com.taishsoft.common;using com.taishsoft.comm_db_obj;
using com.taishsoft.datetime;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Linq;

namespace AutoGCLib
{
    /// <summary>
    /// ����ר�����������ݱ��ı�������,�ô��������߼����һ����,��ϵ�ṹ���µ���,
    /// �������¼���:
    ///		1�������
    ///			ͨ�ý����,ר���ṩһЩ����ؼ��Ĺ�����������
    ///		2���߼���
    ///			2.1 ҵ���߼���
    ///			2.2 �������㡣����:
    ///					1)����¼�����ӡ�
    ///					2)����¼��ɾ��
    ///					3)����¼���޸�
    ///					4)����¼�Ĳ�ѯ
    ///					5)��ȡĳЩ����¼���й��ֶ�����
    ///					6)���ñ���¼���й��ֶ����Եȡ�
    ///		3�����ݲ�,��ͨ�����ݲ�,ר�����ڲ������ݿ��һЩ����,�Լ���������һЩͨ�ò���
    /// </summary>
    partial class Dict_PageName_Dic6Cs : clsGeneCodeBase
    {
        private string strKeyFldName_ObjName = "";


        #region ���캯��

        public Dict_PageName_Dic6Cs()
        {
            // 
            // TODO: �ڴ˴����ӹ��캯���߼�
            //
        }
        public Dict_PageName_Dic6Cs(string strPrjId)
          : base(strPrjId)
        {
            // 
            // TODO: �ڴ˴����ӹ��캯���߼�
            //
        }
        public Dict_PageName_Dic6Cs(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
          : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: �ڴ˴����ӹ��캯���߼�
            //
        }
        #endregion
            
        /// <summary>
        /// ����Web������̨����
        /// </summary>
        /// <returns></returns>
        public string A_GenWebServiceCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
            string strResult;
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strResult = string.Format("��ǰ��:[{0}]���ֶ���Ϊ0,�޷�����ͨ���߼���!({1})",
                        objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strResult = string.Format("��ǰ��:[{0}]�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!({1})",
                   objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            objPrjTabENEx.CurrDate = clsDateTime.getTodayStr2(0);

            //���û���������;
            //string strFolder;
            string strClassFName;
            StringBuilder strBuilder = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; ///��ʱ����;


            objPrjTabENEx.ClsName = string.Format("{0}Service", objPrjTabENEx.TabName);
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".asmx.cs";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName( objFuncModule, objPrjTabENEx);

            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".asmx.cs";

            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //

            try
            {
                //������ʼ

                strBuilder.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));

                strBuilder.Append("\r\n" + "using System;"); //
                strBuilder.Append("\r\n" + "using System.Data; "); //
                strBuilder.Append("\r\n" + "using System.Text; "); //
                strBuilder.Append("\r\n" + "using System.Collections; "); //
                strBuilder.Append("\r\n" + "using System.Collections.Generic;");
                strBuilder.Append("\r\n" + "using System.Web.Services;");
                strBuilder.Append("\r\n" + "using System.Web.Services.Protocols;");
                strBuilder.Append("\r\n" + "using System.ComponentModel;");
                strBuilder.Append("\r\n" + "using com.taishsoft.json;");

                strBuilder.AppendFormat("\r\n" + "using {0}.Entity;",
                objProject.PrjDomain);
                strBuilder.AppendFormat("\r\n" + "using {0}.BusinessLogic;",
                objProject.PrjDomain);
                strBuilder.Append("\r\n" + ""); //
                strBuilder.Append("\r\n" + "using com.taishsoft.common;");
                strBuilder.Append("\r\n" + "using com.taishsoft.datetime;");

                strBuilder.Append("\r\n" + ""); //
                strBuilder.AppendFormat("\r\n" + "namespace {0}.WebSrv",
                objProject.PrjDomain);
                strBuilder.Append("\r\n" + "{");


                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// {0}Service ��ժҪ˵��",
                objPrjTabENEx.TabName);
                //if (objPrjTabENEx.IsForSilverLight == true)
                //{
                //    strBuilder.AppendFormat("\r\n /// For SilverLight");
                //}
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.Append("\r\n" + "[WebService(Namespace = \"http://tempuri.org/\")]");
                strBuilder.Append("\r\n" + "[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]");
                strBuilder.Append("\r\n" + "[ToolboxItem(false)]");
                strBuilder.AppendFormat("\r\n" + "public class  {0}Service : System.Web.Services.WebService",
                objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "{ ");




                //�������еĺ���

                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                  clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
                  objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                .OrderBy(x => x.OrderNum);

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
                    strFuncName = objvFunction4GeneCodeEN.FuncName;

                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strBuilder.Append("\r\n" + strTemp);
                    }
                }

                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "}");

              
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ������{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
        
            }
            return strBuilder.ToString();
        }

        /// <summary>
        /// ����Web������̨����
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            
            StringBuilder strBuilder = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            //string strTemp; ///��ʱ����;

            var arrPrjTabFldEx = objPrjTabENEx.arrKeyFldSet;
            var arrKeyFldName = arrPrjTabFldEx.Select(x => x.FldName).ToList();
            var arrKeyFldName_ObjName = arrKeyFldName.Select(x => string.Format("obj{0}EN.{1}", objPrjTabENEx.TabName, x));
            strKeyFldName_ObjName = string.Join(",", arrKeyFldName_ObjName);

            //objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".asmx.cs";
            strRe_ClsName = "clsDict_PageName_Dic";
            string strSimpleFileName = "clsDict_PageName_Dic" + ".cs";
            //clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}", strSimpleFileName);
            try
            {
                //������ʼ
                string strCondition = string.Format("{0}='{1}' And {2}='01'",
                    convPrjTab.PrjId, this.objProjectsENEx.PrjId,
                    convPrjTab.TabStateId);
                List<clsvPrjTabEN> arrvPrjTabObjLst = clsvPrjTabBL.GetObjLst(strCondition);
                strBuilder.Append(clsPubFun4GC.GenUserInfoAndDate4Projects(this.objProjectsENEx.CurrUserName, this.objProjectsENEx, this.CmPrjId, strRe_ClsName, this.objProjectsENEx.LangType));

                strBuilder.Append("\r\n" + "using System;");
                strBuilder.Append("\r\n" + "using System.Collections.Generic;");
                strBuilder.Append("\r\n" + "using System.Linq;");
                strBuilder.Append("\r\n" + "using System.Text;");
                strBuilder.Append("\r\n" + "");
                strBuilder.AppendFormat("\r\n" + "namespace {0}4WS", this.objProjectsENEx.PrjDomain);
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "/// <summary>");
                strBuilder.Append("\r\n" + "/// ҳ�桢Ŀ¼�ֵ�");
                strBuilder.Append("\r\n" + "/// </summary>");
                strBuilder.Append("\r\n" + "public class clsDict_PageName_Dic");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "/// <summary>");
                strBuilder.Append("\r\n" + "/// ҳ������");
                strBuilder.Append("\r\n" + "/// </summary>");
                strBuilder.Append("\r\n" + "public static List<string> arrPageName = new List<string>();");
                strBuilder.Append("\r\n" + "/// <summary>");
                strBuilder.Append("\r\n" + "/// Ŀ¼����");
                strBuilder.Append("\r\n" + "/// </summary>");
                strBuilder.Append("\r\n" + "public static List<string> arrDir = new List<string>();");
                strBuilder.Append("\r\n" + "/// <summary>");
                strBuilder.Append("\r\n" + "/// �Ƿ��ʼ���ֵ�");
                strBuilder.Append("\r\n" + "/// </summary>");
                strBuilder.Append("\r\n" + "public static bool mbolIsInitDict = false;");
                strBuilder.Append("\r\n" + "/// <summary>");
                strBuilder.Append("\r\n" + "/// ��ʼ��ҳ�桢Ŀ¼�ֵ�");
                strBuilder.Append("\r\n" + "/// </summary>");
                strBuilder.Append("\r\n" + "public static void InitDict()");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "if (mbolIsInitDict == true) return;");
                foreach (clsvPrjTabEN objvPrjTabEN in arrvPrjTabObjLst)
                {
                    strBuilder.AppendFormat("\r\n" + "arrPageName.Add(\"{0}Service.asmx\"); arrDir.Add(\"{1}\");",
                        objvPrjTabEN.TabName, objvPrjTabEN.FuncModuleEnName.Replace("_",""));
                    //   strBuilder.Append("\r\n" + "arrPageName.Add(\"QxUserRolesService.asmx\"); arrDir.Add(\"AAA\");");
                }
                strBuilder.Append("\r\n" + "mbolIsInitDict = true;");
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "/// <summary>");
                strBuilder.Append("\r\n" + "/// ����ҳ�����ƻ�ȡ��Ӧ��Ŀ¼");
                strBuilder.Append("\r\n" + "/// </summary>");
                strBuilder.Append("\r\n" + "/// <param name=\"strPageName\"></param>");
                strBuilder.Append("\r\n" + "/// <returns></returns>");
                strBuilder.Append("\r\n" + "public static string GetDir4PageName(string strPageName)");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + " InitDict();");

                strBuilder.Append("\r\n" + "int intCount = arrPageName.Count;");
                strBuilder.Append("\r\n" + "for (int i = 0; i < intCount; i++)");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "if (arrPageName[i].Equals(strPageName, StringComparison.InvariantCultureIgnoreCase) == true)");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "return arrDir[i];");
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "return \"\";");
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strBuilder.ToString();
        }

        /// <summary>
        /// ����Web�����ǰ̨����
        /// </summary>
        /// <returns></returns>
        public string A_GenWebServiceCode4Front(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strResult;
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strResult = string.Format("��ǰ��:[{0}]���ֶ���Ϊ0,�޷�����ͨ���߼���!({1})",
                        objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strResult = string.Format("��ǰ��:[{0}]�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���!({1})",
                   objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            objPrjTabENEx.CurrDate = clsDateTime.getTodayStr2(0);

            //���û���������;
            //string strFolder;
            string strClassFName;
            StringBuilder strBuilder = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            //string strTemp; ///��ʱ����;

            //arrFuncList.Add("ExposeLogicExClass");

            objPrjTabENEx.ClsName = string.Format("{0}Service", objPrjTabENEx.TabName);
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".asmx";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName( objFuncModule, objPrjTabENEx);

            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".asmx";

            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //

            try
            {
                //������ʼ


                strBuilder.AppendFormat("\r\n" + "<%@ WebService Language=\"C#\" CodeBehind=\"{0}Service.asmx.cs\" Class=\"{1}.WebSrv.{0}Service\" %>",
                    objPrjTabENEx.TabName,
                    objProject.PrjDomain); //
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strBuilder.ToString();
        }

        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
              string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(WS_Srv4Front4CSharp);
                MethodInfo mt = t.GetMethod(strFuncName, BindingFlags.Instance | BindingFlags.Public);

                if (mt == null)
                {
                    string strMsg = string.Format("������û����Ӧ�ĺ���:{0}.(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                else
                {
                    //                string str = (string)mt.Invoke(null, newobject[] { "1234567890123"    });
                    strCode = (string)mt.Invoke(this, null);
                    //Console.WriteLine(str);
                }

                return strCode;
            }
            catch (Exception objException)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strMsg = "";
                if (objException.InnerException != null && string.IsNullOrEmpty(objException.InnerException.Message) == false)
                {
                    strMsg = objException.InnerException.Message;
                }
                else
                {
                    strMsg = objException.Message;
                }
                sbMessage.AppendFormat("�����ɺ���:{0}ʱ����. \r\n������Ϣ:{1}.", strFuncName, strMsg);
                throw new Exception(sbMessage.ToString());
            }
        }

        public string gfunConnectString()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///�û�ָ�������Ӵ�,����û���ָ�������Ӵ�,����PUBDATABASE����ָ�������Ӵ�;
            strBuilder.Append("\r\n//�û�ָ�������Ӵ�,����û���ָ�������Ӵ�,����PUBDATABASE����ָ�������Ӵ�");
            strBuilder.Append("\r\nprivate static string m_strConnectString;");

            strBuilder.Append("\r\npublic static string ConnectString");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\nget { return m_strConnectString; }");
            strBuilder.Append("\r\nset { m_strConnectString = value; }");
            strBuilder.Append("\r\n}");

            return strBuilder.ToString();
        }

        public string gfunpErrNo()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///���Թ���;
            ///ÿ�����඼Ӧ���еĴ��������;
            strBuilder.Append("\r\npublic int ErrNo");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n get");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n return mintErrNo;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n set");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n mintErrNo = value;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }
        public string gfunDispErrMsg()
        {
            StringBuilder strBuilder = new StringBuilder();

            ///ÿ�����඼Ӧ���еĶ�����ʾ�Ĵ�����Ϣ;
            strBuilder.Append("\r\npublic string DispErrMsg //������ʾ�Ĵ�����Ϣ");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n get");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n return objPrjTabENEx.DispErrMsg;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n set");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n objPrjTabENEx.DispErrMsg = value;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }

        public string Gen_GetDataSet()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ���ݼ�,��DataSet��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.AppendFormat("\r\n /// <returns>�������ݼ�,��DataSet��ʾ</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public DataSet {0}GetDataSet(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n" + "DataSet objDS = cls{0}BL.GetDataSet(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_GetTopDataSet()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ���ݼ�,��DataSet��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.AppendFormat("\r\n /// <returns>�������ݼ�,��DataSet��ʾ</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public DataSet {0}GetTopDataSet(int intTopSize, string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n" + "DataSet objDS = cls{0}BL.GetDataSet_Top(intTopSize, strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_GetDataSetByRange()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ���ݼ�,��DataSet��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strBuilder.AppendFormat("\r\n /// <returns>�������ݼ�,��DataSet��ʾ</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public DataSet {0}GetDataSetByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "[\"strOrderBy\"] = strOrderBy, ");
            strBuilder.AppendFormat("\r\n" + "[\"intMinNum\"] = intMinNum.ToString(),", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "[\"intMaxNum\"] = intMaxNum.ToString()", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n" + "DataSet objDS = cls{0}BL.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_GetDataSetV()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ��ǰ����ͼ�����ݼ�,��DataSet��ʾ");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.AppendFormat("\r\n /// <returns>���ص�ǰ����ͼ�����ݼ�,��DataSet��ʾ</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public DataSet {0}GetDataSetV(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n" + "DataSet objDS = cls{0}BL.GetDataSetV(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_GetDataSetVByRange()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ���ݼ�,��DataSet��ʾ,ͬʱ����Ƿ���SQL����-�����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strBuilder.AppendFormat("\r\n /// <returns>�������ݼ�,��DataSet��ʾ</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public DataSet {0}GetDataSetVByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "[\"strOrderBy\"] = strOrderBy, ");
            strBuilder.AppendFormat("\r\n" + "[\"intMinNum\"] = intMinNum.ToString(),", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "[\"intMaxNum\"] = intMaxNum.ToString()", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n" + "DataSet objDS = cls{0}BL.GetDataSetVByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
         
        /// <summary>
        /// ��ȡ��¼����
        /// </summary>
        /// <returns></returns>
        public string Gen_GetObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ�����б�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">��������</param>");
            strBuilder.Append("\r\n /// <returns>���ض����б�</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public List<cls{0}EN> {0}GetObjLst(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst = cls{0}BL.GetObjLst(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLst;",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// ��ȡ��¼����
        /// </summary>
        /// <returns></returns>
        public string Gen_GetTopObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ�����б�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">��������</param>");
            strBuilder.Append("\r\n /// <returns>���ض����б�</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public List<cls{0}EN> {0}GetTopObjLst(int intTopSize, string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst = cls{0}BL.GetTopObjLst(intTopSize, strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLst;",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_GetRecCountByCond()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:��ȡĳһ�����ļ�¼��");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <returns>ĳһ�����ļ�¼��</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public int {0}GetRecCountByCond(string strWhereCond)",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n" + "int intCount = cls{0}BL.GetRecCountByCond(strWhereCond);",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return intCount;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_GetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.Append("\r\n /// ��ȡ��ǰ���ؼ���ֵ�����ֵ,�ټ�1,�����ظ�");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");

                strBuilder.Append("\r\n /// <returns>��ǰ���ؼ���ֵ�����ֵ,�ټ�1</returns>");
                strBuilder.Append("\r\n" + "[WebMethod]");
                strBuilder.AppendFormat("\r\n" + "public string {0}GetMaxStrId()",
                        objPrjTabENEx.TabName, objPrjTabENEx.KeyVarDefineLstStr);
                strBuilder.Append("\r\n" + "{");

                strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
                strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
                //  strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"str{0}JSONObj\", str{0}JSONObj);", objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

                strBuilder.AppendFormat("\r\n" + "string strMax{1} = cls{0}BL.GetMaxStrId_S();",
                        objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr, objKeyField.FldName_FstUcase);
                strBuilder.AppendFormat("\r\n" + "return strMax{0};",
                        objPrjTabENEx.KeyPrivFuncFldNameLstStr);
                strBuilder.Append("\r\n" + "}");
            }
            return strBuilder.ToString();
        }

        public string Gen_GetMaxStrIdByPrefix()
        {
            StringBuilder strBuilder = new StringBuilder();
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.Append("\r\n /// ��ȡ��ǰ���ؼ���ֵ�����ֵ,�ټ�1,�����ظ�");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.Append("\r\n /// <returns>��ǰ���ؼ���ֵ�����ֵ,�ټ�1</returns>");
                strBuilder.Append("\r\n" + "[WebMethod]");
                strBuilder.AppendFormat("\r\n" + "public string {0}GetMaxStrIdByPrefix(string strPrefix)",
                        objPrjTabENEx.TabName, objPrjTabENEx.KeyVarDefineLstStr);
                strBuilder.Append("\r\n" + "{");

                strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
                strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
                //  strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"str{0}JSONObj\", str{0}JSONObj);", objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

                strBuilder.AppendFormat("\r\n" + "string strMax{1} = cls{0}BL.GetMaxStrIdByPrefix_S(strPrefix);",
                        objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr, objKeyField.FldName_FstUcase);
                strBuilder.AppendFormat("\r\n" + "return strMax{0};",
                        objPrjTabENEx.KeyPrivFuncFldNameLstStr);
                strBuilder.Append("\r\n" + "}");
            }
            return strBuilder.ToString();
        }


        public string Gen_AddNewRecordBySql2()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ͨ�����������Ӽ�¼����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">JSON�����ַ���</param>",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>�Ƿ�ɹ�</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}_AddNewRecordBySql2(cls{0}EN obj{0}EN)",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + " if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "   clsPubVar_WS.objLog.WriteDebugLog(\"clsSysParaEN.strTempXMLFileNameΪ��,����!\");");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n" + " else");
            strBuilder.Append("\r\n" + " {");


            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"obj{0}EN\", cls{0}BL.SerializeObjToXMLStr(obj{0}EN));", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.Append("\r\n" + " }");
            if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
            {
                strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true || cls{0}BL.IsExist({2}) == true)",
                    objPrjTabENEx.TabName, objKeyField.FldName, strKeyFldName_ObjName);
                strBuilder.Append("\r\n" + " {");
                strBuilder.AppendFormat("\r\n" + "     obj{0}EN.{1} = cls{0}BL.GetMaxStrId_S();",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.Append("\r\n" + " }");
            }
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}EN.AddNewRecord();",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_AddNewRecordBySql2ByJSON()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ͨ��JSON���������Ӽ�¼����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"str{0}JSONObj\">JSON�����ַ���</param>",
              objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>�Ƿ�ɹ�</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}_AddNewRecordBySql2ByJSON(string str{0}JSONObj)",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"str{0}JSONObj\", str{0}JSONObj);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");

            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = clsJSON.GetObjFromJson<cls{0}EN>(str{0}JSONObj);",
                   objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = cls{0}BL.GetObjFromSimObj(obj{0}EN_Sim);",
            //        objPrjTabENEx.TabName);
            if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
            {
                strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true || cls{0}BL.IsExist({2}) == true)",
                    objPrjTabENEx.TabName, objKeyField.FldName, strKeyFldName_ObjName);
                strBuilder.Append("\r\n" + " {");
                strBuilder.AppendFormat("\r\n" + "     obj{0}EN.{1} = cls{0}BL.GetMaxStrId_S();",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.Append("\r\n" + " }");
            }
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}EN.AddNewRecord();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n" + "string strMsg = \"ͨ��JSON���������Ӽ�¼�������!({0}Service:{0}_AddNewRecordBySql2ByJSON)\\r\\n\" + objException.Message;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubVar_WS.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n throw new Exception(strMsg);");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_AddNewRecordBySql_XML()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// ����:ͨ��SQL�����������¼,������ԴΪ����ʵ������XML��");
            strBuilder.Append("\r\n /// /// �ŵ�:1���ܹ������ֶ��еĵ�Ʋ���⣻2���ܹ�ʹ�ֶ�ֵΪNULL���ֶ�������룻3��ʹ��XML����Դ������");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"str{0}ObjXml\">����ʵ������XML��</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>�������ɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}_AddNewRecordBySql_XML(string str{0}ObjXml)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"str{0}ObjXml\", str{0}ObjXml);",
                  objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}BL.AddNewRecordBySql_XML(str{0}ObjXml);",
                  objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_UpdateBySql2()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ͨ���������޸ļ�¼����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"str{0}JSONObj\">JSON�����ַ���</param>",
              objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>�Ƿ�ɹ�</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}_UpdateBySql2(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + " if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "   clsPubVar_WS.objLog.WriteDebugLog(\"clsSysParaEN.strTempXMLFileNameΪ��,����!\");");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n" + " else");
            strBuilder.Append("\r\n" + " {");



            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"obj{0}EN\", cls{0}BL.SerializeObjToXMLStr(obj{0}EN));",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.Append("\r\n" + " }");


            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}EN.Update();",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_UpdateBySql2ByJSON()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ͨ��JSON�������޸ļ�¼����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"str{0}JSONObj\">JSON�����ַ���</param>",
              objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>�Ƿ�ɹ�</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}_UpdateBySql2ByJSON(string str{0}JSONObj)",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"str{0}JSONObj\", str{0}JSONObj);",
                      objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = clsJSON.GetObjFromJson<cls{0}EN>(str{0}JSONObj);",
                    objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = cls{0}BL.GetObjFromSimObj4Upd(obj{0}EN_Sim);",
            //        objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "cls{0}BL.SetUpdFlag(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}EN.Update();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n" + "string strMsg = \"ͨ��JSON�������޸ļ�¼�������!({0}Service:{0}_UpdateBySql2ByJSON)\\r\\n\" + objException.Message;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubVar_WS.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n throw new Exception(strMsg);");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_UpdateBySql_XML()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// ����:ͨ��SQL�������޸ļ�¼,�÷�ʽ�ṩXML��������ʵ�����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"str{0}ObjXml\">��Ҫ�޸ĵĶ���,��XML����ʾ</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>����޸ĳɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}_UpdateBySql_XML(string str{0}ObjXml)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"str{0}ObjXml\", str{0}ObjXml);",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}BL.UpdateBySql_XML(str{0}ObjXml);",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_DelRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:ɾ���ؼ�����ָ���ļ�¼");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���ֵ</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <returns>����ɾ���ļ�¼��</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public int {0}_DelRecord({1})",
            objPrjTabENEx.TabName, objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == false)
            {
                strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"{0}\", {0}.ToString());", objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"{0}\", {0});", objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            }

            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n" + "int intRecNum = cls{0}BL.DelRecord({1});",
            objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            strBuilder.Append("\r\n" + "return intRecNum;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_DelRecordBySP()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:ɾ���ؼ�����ָ���ļ�¼,ͨ���洢����(SP)��ɾ����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���ֵ</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <returns>���ɾ���ɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}_DelRecordBySP({1})",
            objPrjTabENEx.TabName, objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"{0}\", {0});",
                      objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}BL.DelRecordBySP({1});",
            objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        /// <summary>
        /// ɾ��������¼
        /// </summary>
        /// <returns></returns>
        public string Gen_DelMultiRecord()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:ͬʱɾ��������¼,ɾ�������ؼ����б��ļ�¼");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"arr{0}Lst\">�����Ĺؼ���ֵ�б�</param>", objKeyField.FldName);
            strBuilder.Append("\r\n /// <returns>����ɾ���ļ�¼��</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public int {0}_Del{0}s(string strJSON4Keys)",
                 objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "List<string> arr{0} = clsJSON.GetObjLstFromJson<string>(strJSON4Keys);",
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"arr{0}\", clsArray.GetSqlInStrByArray(arr{0}, true));", objKeyField.FldName);
            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n" + "int intRecNum = cls{0}BL.Del{0}s(arr{1});",
            objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "return intRecNum;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// ɾ��������¼
        /// </summary>
        /// <returns></returns>
        public string Gen_DelMultiRecordByJSON()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:ͬʱɾ��������¼,ɾ�������ؼ����б��ļ�¼, ͨ��JSON��");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strKeyIdLst\">�����Ĺؼ���ֵ�б���JSON��</param>", objKeyField.FldName);
            strBuilder.Append("\r\n /// <returns>����ɾ���ļ�¼��</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public int DelRecordsByJSON(string strKeyIdLst)",
                 objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"strKeyIdLst\", strKeyIdLst);",
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.AppendFormat("\r\n" + "string[] sstr{0} = strKeyIdLst.Trim().Split(',');",
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "List <string> arr{0} = new();",
                objKeyField.FldName);

            strBuilder.AppendFormat("\r\n" + "foreach (string {0} in sstr{1})",
                objKeyField.PrivFuncName,
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == false)",
                objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "arr{0}.Add({1});",
                objKeyField.FldName,
                objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "int intRecNum = cls{0}BL.Del{0}s(arr{1});",
            objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "return intRecNum;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// ɾ��������¼
        /// </summary>
        /// <returns></returns>
        public string Gen_DelMultiRecordByCond()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:ɾ�����������Ķ�����¼");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">��Ҫɾ���ļ�¼����</param>");
            strBuilder.Append("\r\n /// <returns>����ɾ���ļ�¼����</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public int {0}_Del{0}sByCond(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n" + "int intRecNum = cls{0}BL.Del{0}sByCond(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return intRecNum;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_ExposeLogicClass()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public cls{0}EN ExposeLogicClass(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{ ");

            strBuilder.Append("\r\n" + " if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "   clsPubVar_WS.objLog.WriteDebugLog(\"clsSysParaEN.strTempXMLFileNameΪ��,����!\");");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n" + " else");
            strBuilder.Append("\r\n" + " {");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"obj{0}EN\", cls{0}BL.SerializeObjToXMLStr(obj{0}EN));", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.Append("\r\n" + " }");

            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_ExposeLogicExClass()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public cls{0}Ex ExposeLogicExClass(cls{0}Ex obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + " if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "   clsPubVar_WS.objLog.WriteDebugLog(\"clsSysParaEN.strTempXMLFileNameΪ��,����!\");");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n" + " else");
            strBuilder.Append("\r\n" + " {");

            strBuilder.Append("\r\n" + " if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "   clsPubVar_WS.objLog.WriteDebugLog(\"clsSysParaEN.strTempXMLFileNameΪ��,����!\");");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n" + " else");
            strBuilder.Append("\r\n" + " {");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"obj{0}EN\", cls{0}BL.SerializeObjToXMLStr(obj{0}EN));", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.Append("\r\n" + " }");


            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "} ");
            return strBuilder.ToString();
        }


        public string gfunCheckUniqueness()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///�������ĳ����(������)�Ƿ�Ψһ-------------------------------------------;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {

                if (objField.IsTabUnique == true && objField.FieldTypeId != enumFieldType.KeyField_02)
                {

                    strBuilder.Append("\r\n /// <summary>");
                    strBuilder.AppendFormat("\r\n /// ���Ψһ��(Uniqueness)--{0}({1}), �����Ψһ,��������ͬ�ļ�¼,�ͷ���False",
                    objField.ColCaption, objField.ObjFieldTabENEx.FldName);
                    strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">{1}(����)</param>",
                    objKeyField.PrivFuncName,
                    objKeyField.ColCaption);
                    strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">{1}(Ҫ��Ψһ���ֶ�)</param>",
                    objField.ObjFieldTabENEx.PrivFuncName, objField.ColCaption);
                    strBuilder.Append("\r\n /// <returns></returns>");
                    strBuilder.AppendFormat("\r\npublic static bool Check{0}Uniqueness({1} {2}, {3} {4})",
                    objField.ObjFieldTabENEx.FldName,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objKeyField.PrivFuncName,
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objField.ObjFieldTabENEx.PrivFuncName);
                    strBuilder.Append("\r\n{");
                    strBuilder.Append("\r\nStringBuilder sbCondition = new StringBuilder();");
                    strBuilder.Append("\r\nsbCondition.AppendFormat(\"" + objKeyField.FldName + " != '{0}' and "
                  + objField.ObjFieldTabENEx.FldName + " = '{1}'\", " + objKeyField.PrivFuncName + ", " + objField.ObjFieldTabENEx.PrivFuncName + ");");
                    strBuilder.AppendFormat("\r\nif (new cls{0}BL.IsExistRecord(sbCondition.ToString()) == true)",
                    objPrjTabENEx.TabName);
                    strBuilder.Append("\r\n{");
                    strBuilder.Append("\r\nreturn false;");
                    strBuilder.Append("\r\n}");
                    strBuilder.Append("\r\nelse");
                    strBuilder.Append("\r\n{");
                    strBuilder.Append("\r\nreturn true;");
                    strBuilder.Append("\r\n}");
                    strBuilder.Append("\r\n}");

                }
            }
            ///�������ĳ����(������)�Ƿ�Ψһ == == == == == == == == = ;
            return strBuilder.ToString();
        }

        public string gfunCheckPropertyNew()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///������������Ƿ���ȷ-------------------------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �������ֶ�ֵ�Ƿ�Ϸ�,1)����Ƿ�ɿ�;2)����ֶ�ֵ�����Ƿ񳬳�,����������׳�����.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\npublic void CheckPropertyNew()");
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.IsTabNullable == false && objField.ObjFieldTabENEx.IsIdentity == false)
                {
                    strBuilder.Append("\r\nif (Object.Equals(null, " + objField.ObjFieldTabENEx.PrivPropName + ") ");
                    strBuilder.Append("\r\n|| (!Object.Equals(null, " + objField.ObjFieldTabENEx.PrivPropName + ") && " + objField.ObjFieldTabENEx.PrivPropName + " .ToString() == \"\")");
                    if (string.IsNullOrEmpty(objField.ObjFieldTab4CodeConv().CodeTabId) != true)
                    {
                        strBuilder.Append("\r\n|| (!Object.Equals(null, " + objField.ObjFieldTabENEx.PrivPropName + ") && " + objField.ObjFieldTabENEx.PrivPropName + " .ToString() == \"0\")");
                    }
                    strBuilder.Append(")");
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\n throw new Exception(\"�ֶ�[{0}]����Ϊ��(NULL)!\");",
                    objField.ColCaption);
                    strBuilder.Append("\r\n}");
                }
            }
            ///������Գ��ȴ���;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text" && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string" && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    strBuilder.Append("\r\nif (!Object.Equals(null, " + objField.ObjFieldTabENEx.PrivPropName + ") && GetStrLen(" + objField.ObjFieldTabENEx.PrivPropName + ") > " + objField.ObjFieldTabENEx.FldLength.ToString().Trim() + ")");
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\n throw new Exception(\"�ֶ�[{0}]�ĳ��Ȳ��ܳ���{1}!\");",
                    objField.ColCaption, objField.ObjFieldTabENEx.FldLength.ToString().Trim());
                    strBuilder.Append("\r\n}");
                }
            }
            strBuilder.Append("\r\n}");
            ///������������Ƿ���ȷ == == ;
            return strBuilder.ToString();
        }

   
        public string gfunDispose()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///������������---------------------------------------;
            strBuilder.Append("\r\n public void Dispose()");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n if (mblnDisposed == false)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n //Free up the database connection resource by ");
            strBuilder.Append("\r\n //calling its Dispose method");
            strBuilder.Append("\r\n //mobjConnection.Dispose()");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n finally");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n //Because this Dispose method has done the necessary cleanup,");
            strBuilder.Append("\r\n //prevent the Finalize method from being called.");
            strBuilder.Append("\r\n GC.SuppressFinalize(this);");
            strBuilder.Append("\r\n ");
            strBuilder.Append("\r\n //Let our class know that Dispose() has been called");
            strBuilder.Append("\r\n mblnDisposed = true;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n }");
            ///������������ == = ;
            return strBuilder.ToString();
        }
        public string gfunLogError()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///��ȡ�ַ�������,���к���Ϊ2���ֽ�,Ӣ��Ϊ1���ֽ� = ;
            ///������־;
            strBuilder.Append("\r\nprotected void LogError" + "(Exception objException)");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n //Log the error information to the Application Log");
            strBuilder.Append("\r\n string strLogMsg ;");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n ");
            strBuilder.Append("\r\n strLogMsg = \"An error occurred in the following module: \"");
            strBuilder.Append("\r\n+ mstrModuleName + \"Source: \" + objException.Source \r\n");
            strBuilder.Append("\r\n+ \"Message: \" + objException.Message ");
            strBuilder.Append("\r\n+ \"Stack Trace: \" + objException.StackTrace \r\n");
            strBuilder.Append("\r\n+ \"Target Site: \" + objException.TargetSite.ToString();");
            strBuilder.Append("\r\n ");
            strBuilder.Append("\r\n //Write error to event log");
            strBuilder.Append("\r\nSystem.Diagnostics.EventLog.WriteEntry(mstrModuleName, strLogMsg, System.Diagnostics.EventLogEntryType.Error);");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n catch");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n}");
            strBuilder.Append("\r\n}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// ���л�һ������Xml��
        /// </summary>
        /// <returns></returns>

        /// <summary>
        /// ���ɴ���:�ṩ����,��ѯ�ؼ���,����ж���ؼ���,��ȡ���еĵ�һ��,���������Ǹ����ֶα���������
        /// </summary>
        /// <returns></returns>
        public string Gen_GetFirstID_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            /// GetID(����������ȡ�ؼ��ֵ�����);
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡ��ǰ�����������ĵ�һ����¼�Ĺؼ���ֵ");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <returns>���صĵ�һ����¼�Ĺؼ���ֵ</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\npublic {0} {1}GetFirstID_S(string strWhereCond) ", objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");

            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n {0} {1};",
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.PrivFuncName);
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n {0} = cls{1}BL.GetFirstID_S(strWhereCond);",
            objKeyField.PrivFuncName, objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n return {0};", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n" + "string strMsg = \"��ȡFirst�ؼ��ֳ���!\\r\\n\" + objException.Message;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubVar_WS.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n throw new Exception(strMsg);");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n}");
            ///GetReader(����������ȡ����Reader);
            return strBuilder.ToString();
        }

        /// <summary>
        /// ���ɴ���:�ṩ����,��ѯ��ؼ�¼����,����ж������,��ȡ���еĵ�һ��,����������������
        /// </summary>
        /// <returns></returns>
        public string Gen_GetFirstObj()
        {
            StringBuilder strBuilder = new StringBuilder();
            /// GetID(����������ȡ�ؼ��ֵ�����);
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡ��ǰ�����������ĵ�һ����¼�Ķ���");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <returns>���صĵ�һ����¼�Ķ���</returns>");
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\npublic cls{0}EN {0}GetFirstObj_S(string strWhereCond) ", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");

            strBuilder.AppendFormat("\r\n cls{0}EN obj{0}EN = cls{0}BL.GetFirstObj_S(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n return obj{0}EN;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n" + "string strMsg = \"��ȡFirst��¼�������!\\r\\n\" + objException.Message;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubVar_WS.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n throw new Exception(strMsg);");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n}");
            ///GetReader(����������ȡ����Reader);
            return strBuilder.ToString();
        }

  

        /// <summary>
        /// ���ɴ���:��ȡ��ǰ�����������ĵ�һ����¼��JSON����
        /// </summary>
        /// <returns></returns>
        public string Gen_GetFirstJSONObj()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡ��ǰ�����������ĵ�һ����¼��JSON����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <returns>���صĵ�һ����¼��JSON����</returns>");
            strBuilder.Append("\r\n [WebMethod]");
            strBuilder.AppendFormat("\r\n public string GetFirstJSONObj(string strWhereCond)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n cls{0}EN obj{0}EN = null;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n obj{0}EN = cls{0}BL.GetFirstObj_S(strWhereCond);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n" + "string strMsg = \"����������ȡ��һ����¼�Ķ������!({0}Service:GetFirstJSONObj)\\r\\n\" + objException.Message;",
              objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubVar_WS.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n throw new Exception(strMsg);");
            strBuilder.Append("\r\n }");

            //strBuilder.AppendFormat("\r\n cls{0}EN_Sim obj{0}EN_Sim = cls{0}BL.GetSimObjFromObj(obj{0}EN);", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n string strJSON = clsJSON.GetJsonFromObj<cls{0}EN>(obj{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n return strJSON;");
            strBuilder.Append("\r\n }");

            return strBuilder.ToString();
        }



        /// <summary>
        /// ���ɴ���:����������ȡJSON�����б�
        /// </summary>
        /// <returns></returns>
        public string Gen_GetJSONObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡJSON�����б�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">��������</param>");
            strBuilder.Append("\r\n /// <returns>����JSON�����б�</returns>");
            strBuilder.Append("\r\n [WebMethod]");
            strBuilder.AppendFormat("\r\n public string GetJSONObjLst(string strWhereCond)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");

            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n List<cls{0}EN> arr{0}ObjLst;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n arr{0}ObjLst = cls{0}BL.GetObjLst(strWhereCond);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n" + "string strMsg = \"����������ȡ�Ķ����б�����!({0}Service:GetJSONObjLst)\\r\\n\" + objException.Message;",
              objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubVar_WS.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n throw new Exception(strMsg);");

            strBuilder.Append("\r\n }");

            //strBuilder.AppendFormat("\r\n List<cls{0}EN_Sim> arr{0}SimObjLst = cls{0}BL.GetSimObjLstFromObjLst(arr{0}ObjLst);", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n string strJSON = clsJSON.GetJsonFromObjLst(arr{0}ObjLst);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n return strJSON;");
            strBuilder.Append("\r\n }");

            return strBuilder.ToString();
        }


        /// <summary>
        /// ���ɴ���:����������ȡJSON�����б�
        /// </summary>
        /// <returns></returns>
        public string Gen_GetJSONObjLstByPager()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡJSON�����б�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"intPageIndex\">ҳ���</param>");
            strBuilder.Append("\r\n /// <param name = \"intPageSize\">ҳ��¼��</param>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">��������</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strBuilder.Append("\r\n /// <returns>����JSON�����б�</returns>");
            strBuilder.Append("\r\n [WebMethod]");
            strBuilder.AppendFormat("\r\n public string GetJSONObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "[\"strOrderBy\"] = strOrderBy, ");
            strBuilder.AppendFormat("\r\n" + "[\"intPageIndex\"] = intPageIndex.ToString(),", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "[\"intPageSize\"] = intPageSize.ToString()", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n List<cls{0}EN> arr{0}ObjLst;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n arr{0}ObjLst = cls{0}BL.GetObjLstByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n" + "string strMsg = \"����������ҳ��ȡ�Ķ����б�����!({0}Service:GetJSONObjLstByPager)\\r\\n\" + objException.Message;",
              objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubVar_WS.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n throw new Exception(strMsg);");
            strBuilder.Append("\r\n }");

            //strBuilder.AppendFormat("\r\n List<cls{0}EN_Sim> arr{0}SimObjLst = cls{0}BL.GetSimObjLstFromObjLst(arr{0}ObjLst);", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n string strJSON = clsJSON.GetJsonFromObjLst(arr{0}ObjLst);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n return strJSON;");
            strBuilder.Append("\r\n }");

            return strBuilder.ToString();
        }

        /// <summary>
        /// ���ɴ���:����������ȡJSON�����б�
        /// </summary>
        /// <returns></returns>
        public string Gen_GetJSONObjLstByRange()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��Χ�ڵ�JSON�����б�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">��С��¼��</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">����¼��</param>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">��������</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strBuilder.Append("\r\n /// <returns>����JSON�����б�</returns>");
            strBuilder.Append("\r\n [WebMethod]");
            strBuilder.AppendFormat("\r\n public string GetJSONObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "[\"strOrderBy\"] = strOrderBy, ");
            strBuilder.AppendFormat("\r\n" + "[\"intMinNum\"] = intMinNum.ToString(),", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "[\"intMaxNum\"] = intMaxNum.ToString()", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "};");


            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n List<cls{0}EN> arr{0}ObjLst;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n arr{0}ObjLst = cls{0}BL.GetObjLstByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n" + "string strMsg = \"����������ȡָ����Χ�ڵĶ����б�����!({0}Service:GetJSONObjLstByRange)\\r\\n\" + objException.Message;",
              objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubVar_WS.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n throw new Exception(strMsg);");
            strBuilder.Append("\r\n }");

            //strBuilder.AppendFormat("\r\n List<cls{0}EN_Sim> arr{0}SimObjLst = cls{0}BL.GetSimObjLstFromObjLst(arr{0}ObjLst);", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n string strJSON = clsJSON.GetJsonFromObjLst(arr{0}ObjLst);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n return strJSON;");
            strBuilder.Append("\r\n }");

            return strBuilder.ToString();
        }



        /// <summary>
        /// ���ɴ���:����������ȡJSON�����б�
        /// </summary>
        /// <returns></returns>
        public string Gen_GetObjLstByRange()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��Χ�ڵĶ����б�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">��С��¼��</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">����¼��</param>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">��������</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strBuilder.Append("\r\n /// <returns>���ط�Χ�ڵĶ����б�</returns>");
            strBuilder.Append("\r\n [WebMethod]");
            strBuilder.AppendFormat("\r\n public List<cls{0}EN> GetObjLstByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond,");
            strBuilder.AppendFormat("\r\n" + "[\"strOrderBy\"] = strOrderBy, ");
            strBuilder.AppendFormat("\r\n" + "[\"intMinNum\"] = intMinNum.ToString(),", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "[\"intMaxNum\"] = intMaxNum.ToString()", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n List<cls{0}EN> arr{0}ObjLst;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n arr{0}ObjLst = cls{0}BL.GetObjLstByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n" + "string strMsg = \"����������ȡָ����Χ�ڵĶ����б�����!({0}Service:GetJSONObjLstByRange)\\r\\n\" + objException.Message;",
              objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubVar_WS.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n throw new Exception(strMsg);");
            strBuilder.Append("\r\n }");

            //strBuilder.AppendFormat("\r\n List<cls{0}EN_Sim> arr{0}SimObjLst = cls{0}BL.GetSimObjLstFromObjLst(arr{0}ObjLst);", objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\n string strJSON = clsJSON.GetJsonFromObjLst(arr{0}ObjLst);", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n return arr{0}ObjLst;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");

            return strBuilder.ToString();
        }

        public string Gen_UpdateBySqlWithCondition()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public bool {0}_UpdateBySqlWithCondition(cls{0}EN obj{0}EN, string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + " if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "   clsPubVar_WS.objLog.WriteDebugLog(\"clsSysParaEN.strTempXMLFileNameΪ��,����!\");");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n" + " else");
            strBuilder.Append("\r\n" + " {");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"obj{0}EN\", cls{0}BL.SerializeObjToXMLStr(obj{0}EN));", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"strWhereCond\", strWhereCond);", objPrjTabENEx.TabName);


            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.Append("\r\n" + " }");


            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}BL.UpdateBySqlWithCondition(obj{0}EN, strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strMsg = \"�޸ļ�¼����!\\r\\n\" + objException.Message;");
            strBuilder.Append("\r\n" + "clsPubVar_WS.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_AddNewRecordBySql2WithReturnKey()
        {
            if (objKeyField.PrimaryTypeId != "02") return "";
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �ѱ��������ӵ����ݿ���,���ҷ��ظü�¼�Ĺؼ���(���Identity�ؼ���)");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ���ӵı�����</param>",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>���������Ӽ�¼�Ĺؼ���</returns>");

            strBuilder.Append("\r\n" + "[WebMethod]");
            strBuilder.AppendFormat("\r\n" + "public string {0}_AddNewRecordBySql2WithReturnKey(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + " if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "   clsPubVar_WS.objLog.WriteDebugLog(\"clsSysParaEN.strTempXMLFileNameΪ��,����!\");");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n" + " else");
            strBuilder.Append("\r\n" + " {");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"obj{0}EN\", cls{0}BL.SerializeObjToXMLStr(obj{0}EN));", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubFun_WS.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.Append("\r\n" + " }");


            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
            {
                strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true || cls{0}BL.IsExist({2}) == true)",
                    objPrjTabENEx.TabName, objKeyField.FldName, strKeyFldName_ObjName);
                strBuilder.Append("\r\n" + " {");
                strBuilder.AppendFormat("\r\n" + "     obj{0}EN.{1} = cls{0}BL.GetMaxStrId_S();",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.Append("\r\n" + " }");
            }
            strBuilder.AppendFormat("\r\n" + "string strKey = cls{0}BL.AddNewRecordBySql2WithReturnKey(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return strKey;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strMsg = \"���Ӽ�¼����!\\r\\n\" + objException.Message;");
            strBuilder.Append("\r\n" + "clsPubVar_WS.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// ����ָ���ĺ���
        /// </summary>
        /// <returns>�������ɵ�ָ����������</returns>
        public override string GeneCode4Function(string strFuncId4GC, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; //��ʱ����;
            string strFuncName = "";
            try
            {
                //������ʼ
                 clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
                strFuncName = objvFunction4GeneCodeEN.FuncName;

                if (objvFunction4GeneCodeEN.FuncTypeId == "10")//�û��Զ��庯��
                {
                    strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objvFunction4GeneCodeEN.FuncId4GC,
                        objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
                }
                else
                {
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                }

                if (string.IsNullOrEmpty(strTemp) == false)
                {
                    strCodeForCs.Append("\r\n" + strTemp);
                }

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ������������Ϣ:{1}.({2})", strFuncName,
                    objException.Message,
                    clsStackTrace.GetCurrClassFunction());
                clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ����ָ���ĺ���
        /// </summary>
        /// <returns>�������ɵ�ָ����������</returns>
        //public string A_GenCode4Function_Java(string strFuncId4GC)
        //{
        //    StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
        //    string strTemp; //��ʱ����;
        //    string strFuncName = "";
        //    try
        //    {
        //        //������ʼ
        //         clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
        //        strFuncName = objFunction4GeneCodeEN.FuncName;

        //        if (objFunction4GeneCodeEN.FuncTypeId == "10")//�û��Զ��庯��
        //        {
        //            strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objFunction4GeneCodeEN.FuncId4GC,
        //                objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
        //        }
        //        else
        //        {
        //            strTemp = A_GeneFuncCode_Java(strFuncName);
        //        }

        //        if (string.IsNullOrEmpty(strTemp) == false)
        //        {
        //            strCodeForCs.Append("\r\n" + strTemp);
        //        }

        //    }
        //    catch (Exception objException)
        //    {
        //        string strMsg = string.Format("�����ɺ���:[{0}]ʱ������������Ϣ:{1}.({2})", strFuncName,
        //            objException.Message,
        //            clsStackTrace.GetCurrClassFunction());
        //        clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
        //        throw new Exception(strMsg);
        //    }
        //    return strCodeForCs.ToString();
        //}

        /// <summary>
        /// ����ָ���ĺ���
        /// </summary>
        /// <returns>�������ɵ�ָ����������</returns>
        //public string A_GenCode4Function_JavaScript(string strFuncId4GC)
        //{
        //    StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
        //    string strTemp; //��ʱ����;
        //    string strFuncName = "";
        //    try
        //    {
        //        //������ʼ
        //         clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
        //        strFuncName = objFunction4GeneCodeEN.FuncName;

        //        if (objFunction4GeneCodeEN.FuncTypeId == "10")//�û��Զ��庯��
        //        {
        //            strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objFunction4GeneCodeEN.FuncId4GC,
        //                objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
        //        }
        //        else
        //        {
        //            strTemp = A_GeneFuncCode_JavaScript(strFuncName);
        //        }

        //        if (string.IsNullOrEmpty(strTemp) == false)
        //        {
        //            strCodeForCs.Append("\r\n" + strTemp);
        //        }

        //    }
        //    catch (Exception objException)
        //    {
        //        string strMsg = string.Format("�����ɺ���:[{0}]ʱ������������Ϣ:{1}.({2})", strFuncName,
        //            objException.Message,
        //            clsStackTrace.GetCurrClassFunction());
        //        clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
        //        throw new Exception(strMsg);
        //    }
        //    return strCodeForCs.ToString();
        //}


        /// <summary>
        /// ����ָ���ĺ���
        /// </summary>
        /// <returns>�������ɵ�ָ����������</returns>
        //public string A_GenCode4Function_SilverLight(string strFuncId4GC)
        //{
        //    StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
        //    string strTemp; //��ʱ����;
        //    string strFuncName = "";
        //    try
        //    {
        //        //������ʼ
        //         clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
        //        strFuncName = objFunction4GeneCodeEN.FuncName;

        //        if (objFunction4GeneCodeEN.FuncTypeId == "10")//�û��Զ��庯��
        //        {
        //            strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objFunction4GeneCodeEN.FuncId4GC,
        //                objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
        //        }
        //        else
        //        {
        //            strTemp = A_GeneFuncCode_SilverLight(strFuncName);
        //        }

        //        if (string.IsNullOrEmpty(strTemp) == false)
        //        {
        //            strCodeForCs.Append("\r\n" + strTemp);
        //        }

        //    }
        //    catch (Exception objException)
        //    {
        //        string strMsg = string.Format("�����ɺ���:[{0}]ʱ������������Ϣ:{1}.({2})", strFuncName,
        //            objException.Message,
        //            clsStackTrace.GetCurrClassFunction());
        //        clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
        //        throw new Exception(strMsg);
        //    }
        //    return strCodeForCs.ToString();
        //}

        /// <summary>
        /// ����ָ���ĺ���
        /// </summary>
        /// <returns>�������ɵ�ָ����������</returns>
        //public string A_GenCode4Function_Swift(string strFuncId4GC)
        //{
        //    StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
        //    string strTemp; //��ʱ����;
        //    string strFuncName = "";
        //    try
        //    {
        //        //������ʼ
        //         clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
        //        strFuncName = objFunction4GeneCodeEN.FuncName;

        //        if (objFunction4GeneCodeEN.FuncTypeId == "10")//�û��Զ��庯��
        //        {
        //            strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objFunction4GeneCodeEN.FuncId4GC,
        //                objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
        //        }
        //        else
        //        {
        //            strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
        //        }

        //        if (string.IsNullOrEmpty(strTemp) == false)
        //        {
        //            strCodeForCs.Append("\r\n" + strTemp);
        //        }

        //    }
        //    catch (Exception objException)
        //    {
        //        string strMsg = string.Format("�����ɺ���:[{0}]ʱ������������Ϣ:{1}.({2})", strFuncName,
        //            objException.Message,
        //            clsStackTrace.GetCurrClassFunction());
        //        clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
        //        throw new Exception(strMsg);
        //    }
        //    return strCodeForCs.ToString();
        //}
        public override void GetClsName()
        {
            this.ClsName = string.Format("clsDict_PageName_Dic", objPrjTabENEx.TabName);
            objPrjTabENEx.ClsName = this.ClsName;
        }

    }
}