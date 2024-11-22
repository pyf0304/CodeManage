using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AgcCommBase;

using com.taishsoft.commexception;
using com.taishsoft.common;using com.taishsoft.comm_db_obj;
using com.taishsoft.datetime;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;

namespace AutoGCLib
{
    /// <summary>
    /// ����ר�����������ݱ�ı�����,�ô�������߼����һ����,��ϵ�ṹ���µ���,
    /// �������¼���:
    ///		1�������
    ///			ͨ�ý����,ר���ṩһЩ����ؼ��Ĺ�����������
    ///		2���߼���
    ///			2.1 ҵ���߼���
    ///			2.2 �����㡣����:
    ///					1)���¼����ӡ�
    ///					2)���¼��ɾ��
    ///					3)���¼���޸�
    ///					4)���¼�Ĳ�ѯ
    ///					5)��ȡĳЩ���¼���й��ֶ�����
    ///					6)���ñ��¼���й��ֶ����Եȡ�
    ///		3�����ݲ�,��ͨ�����ݲ�,ר�����ڲ������ݿ��һЩ����,�Լ��������һЩͨ�ò���
    /// </summary>
    partial class RelaWA_Srv4CSharp : clsGeneCodeBase
    {
        private string strKeyFldName_ObjName = "";

        #region ���캯��

        public RelaWA_Srv4CSharp()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }
        public RelaWA_Srv4CSharp(string strPrjId)
          : base(strPrjId)
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }
        public RelaWA_Srv4CSharp(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
          : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }
        #endregion

    
        /// <summary>
        /// ����Web������̨����
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
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

            var arrPrjTabFldEx = objPrjTabENEx.arrKeyFldSet;
            var arrKeyFldName = arrPrjTabFldEx.Select(x => x.FldName).ToList();
            var arrKeyFldName_ObjName = arrKeyFldName.Select(x => string.Format("obj{0}EN.{1}", objPrjTabENEx.TabName, x));
            strKeyFldName_ObjName = string.Join(",", arrKeyFldName_ObjName);

            objPrjTabENEx.CurrDate = clsDateTime.getTodayStr2(0);

            //���û���������;
            //string strFolder;
            string strClassFName;
            StringBuilder strBuilder = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; ///��ʱ����;


            objPrjTabENEx.ClsName = string.Format("{0}ApiController", objPrjTabENEx.TabName);
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WA_SrvLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".cs";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName( objFuncModule, objPrjTabENEx);

            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".cs";

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
                //strBuilder.Append("\r\n" + "using System.Web.Services;");
                //strBuilder.Append("\r\n" + "using System.Web.Services.Protocols;");
                strBuilder.Append("\r\n" + "using System.ComponentModel;");
                strBuilder.Append("\r\n" + "using com.taishsoft.json;");
                strBuilder.AppendFormat("\r\n" + "using {0}.Entity;",
                objProject.PrjDomain);
                strBuilder.AppendFormat("\r\n" + "using {0}.BusinessLogic;",
                objProject.PrjDomain);
                strBuilder.Append("\r\n" + ""); //
                strBuilder.Append("\r\n" + "using com.taishsoft.common;");
                strBuilder.Append("\r\n" + "using com.taishsoft.datetime;");
                strBuilder.Append("\r\n" + "using System.Web.Http;");
                strBuilder.Append("\r\n" + "using System.Net;");
                strBuilder.Append("\r\n" + "using System.Linq;");
                strBuilder.Append("\r\n" + "using Newtonsoft.Json;");
                strBuilder.Append("\r\n" + "using Newtonsoft.Json.Linq; using Comm.WebApi;");
                strBuilder.Append("\r\n" + ""); //
                strBuilder.AppendFormat("\r\n" + "namespace {0}.WebApi",
                        objProject.PrjDomain);
                strBuilder.Append("\r\n" + "{");


                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// {0}Controller ��ժҪ˵��",
                        objPrjTabENEx.TabName);
                //if (objPrjTabENEx.IsForSilverLight == true)
                //{
                //    strBuilder.AppendFormat("\r\n /// For SilverLight");
                //}
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "public class  {0} : ApiController",
                          objPrjTabENEx.ClsName);
                strBuilder.Append("\r\n" + "{ ");

                //�������еĺ���

                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                clsvFunction4GeneCodeBLEx.GetObjLstByPrjTabEx(objPrjTabENEx, (int)enumApplicationType.WebApi_19, this.CmPrjId);

                               
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    if (strFuncName.Substring(0, 6) == "Print:")
                    {
                        strBuilder.Append("\r\n" + "");
                        strBuilder.Append("\r\n " + strFuncName.Substring(6));
                        continue;
                    }
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
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strBuilder.ToString();
        }


        /// <summary>
        /// ����Web Serviceת�������
        /// </summary>
        /// <returns></returns>
        public string A_GenWebApiTransCode_SelfDefWs(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
            string strResult = "";
            if (objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst.Count == 0)
            {
                strResult = string.Format("��ǰ��:[{0}]�ĺ�����Ϊ0,�޷�������ز�!({1})",
                      objWebSrvClassENEx.ClsName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }

            objWebSrvClassENEx.CurrDate = clsDateTime.getTodayStr2(0);

            //���û���������;
            //string strFolder;
            string strClassFName;
            StringBuilder strBuilder = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; ///��ʱ����;


            objWebSrvClassENEx.ClsName = string.Format("{0}WS", objWebSrvClassENEx.ClsName);
            //objWebSrvClassENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebApiTransferLevel;

            objWebSrvClassENEx.SimpleFileName = objWebSrvClassENEx.ClsName + ".cs";
            strRe_ClsName = objWebSrvClassENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objWebSrvClassENEx.FuncModuleAgcId, objWebSrvClassENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objWebSrvClassENEx.SimpleFileName);

            strClassFName = objWebSrvClassENEx.FolderName + objWebSrvClassENEx.ClsName + ".cs";
            objWebSrvClassENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objWebSrvClassENEx.PrjId); //
            try
            {
                //������ʼ

                strBuilder.Append(clsPubFun4GC.GenUserInfoAndDate(objWebSrvClassENEx.CurrUserName, objWebSrvClassENEx));

                //������ʼ

                strBuilder.Append("\r\n" + "using System;"); //
                strBuilder.Append("\r\n" + "using System.Data; "); //
                strBuilder.Append("\r\n" + "using System.Data.SqlClient;");
                strBuilder.Append("\r\n" + "using System.Text; "); //
                strBuilder.Append("\r\n" + "using System.Collections; "); //
                strBuilder.Append("\r\n" + "using com.taishsoft.common;"); //
                strBuilder.Append("\r\n" + "using System.ServiceModel;"); //
                strBuilder.AppendFormat("\r\n" + "using {1}4WS.ServiceReference{0};", objWebSrvClassENEx.ClsName, objProject.PrjDomain); //
                strBuilder.Append("\r\n" + "using System.Collections.Generic;"); //

                strBuilder.Append("\r\n" + ""); //
                                                //if (objWebSrvClassENEx.IsForSilverLight == true)
                                                //{
                                                //    strBuilder.AppendFormat("\r\n" + "namespace SL4WS",
                                                //    objProject.PrjDomain);
                                                //}
                                                //else
                                                //{
                strBuilder.AppendFormat("\r\n" + "namespace {0}4WS",
                objProject.PrjDomain);
                //}
                strBuilder.Append("\r\n" + "{");

                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// {0}",
                    objWebSrvClassENEx.ClsName);
                //if (objWebSrvClassENEx.IsForSilverLight == true)
                //{
                //    strBuilder.AppendFormat("\r\n /// For SilverLight");
                //}
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");

                strBuilder.Append("\r\n" + "public class " + objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + "{");


                strBuilder.AppendFormat("\r\n" + "private static string mstrApiControllerName = \"{0}\";",
                    objWebSrvClassENEx.PageName);
                strBuilder.Append("\r\n" + "private static string mstrDir = \"0\";");

                //˽��������-----�����Թ���
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.Append("\r\n /// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                //strBuilder.AppendFormat("\r\n" + "public static List<cls{0}EN> arr{0}ObjLstCache = null;",
                //       objWebSrvClassENEx.TabName);

                strBuilder.AppendFormat("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// �ӻ����в���ʧ�ܵĴ���");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.AppendFormat("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "protected static int intFindFailCount = 0;");

                //˽��������-----�����Թ���
                strBuilder.AppendFormat("\r\n" + "private static {0}SoapClient obj{0}SoapClient = null;",
                objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.Append("\r\n /// ");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.Append("\r\n /// <returns></returns>");
                strBuilder.AppendFormat("\r\n" + "public static {0}SoapClient Get{0}SoapClient()",
                objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "if (obj{0}SoapClient == null)",
                objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "BasicHttpBinding binding = new BasicHttpBinding();");
                strBuilder.AppendFormat("\r\n" + "binding.Name = \"{0}ServiceSoap\";",
                objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + "binding.CloseTimeout = new System.TimeSpan(6000);");
                strBuilder.Append("\r\n" + "binding.MaxReceivedMessageSize = 2147483647;");
                //                strBuilder.Append("\r\n" + "String strServiceUrl = String.Empty;");
                strBuilder.Append("\r\n" + "string strServiceUrl = GetServiceUrl(mstrApiControllerName, ref mstrDir);");
                //strBuilder.Append("\r\n" + "if (clsSysPara4WebApi.bolIsLocalHost == false)");
                //strBuilder.Append("\r\n" + "{");
                //strBuilder.AppendFormat("\r\n" + "strServiceUrl = String.Format(\"http://{{0}}/{{1}}/{2}Service.asmx\", clsSysPara4WebApi.strCurrIPAddressAndPort, clsSysPara4WebApi.strCurrPrx);",
                //"{", "}", objWebSrvClassENEx.TabName);
                //strBuilder.Append("\r\n" + "}");
                //strBuilder.Append("\r\n" + "else");
                //strBuilder.Append("\r\n" + "{");
                //strBuilder.AppendFormat("\r\n" + "strServiceUrl = String.Format(\"http://{{0}}/{2}Service.asmx\", clsSysPara4WebApi.strCurrIPAddressAndPort_Local);",
                //"{", "}", objWebSrvClassENEx.TabName);
                //strBuilder.Append("\r\n" + "}");

                strBuilder.Append("\r\n" + "EndpointAddress address = new EndpointAddress(strServiceUrl);");

                strBuilder.AppendFormat("\r\n" + "return new {0}SoapClient(binding, address);",
                objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "else");
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "return obj{0}SoapClient;",
                objWebSrvClassENEx.ClsName);
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "}");
                //�������еĺ���

                //List<clsvWebSrvFunctionsEN> arrvWebSrvFunctionsObjLst =
                //  clsvWebSrvFunctionsBLEx.getFunction4GeneCodeObjLstByTemplateId(objWebSrvClassENEx.FunctionTemplateId,
                //  objWebSrvClassENEx.LangType, objWebSrvClassENEx.ProgLevelTypeId, objWebSrvClassENEx.SqlDsTypeId);
                //List<clsvWebSrvFunctionsEN> arrvWebSrvFunctionsObjLst =
                //    clsvWebSrvFunctionsBLEx.GetvWebSrvFunctionsObjLstByClassId(objWebSrvClassENEx.WebSrvClassId);
                foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
                {
                    if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                    try
                    {
                        strTemp = Gen_4WA_ByCommonFunction(objWebSrvFunctionsENEx);
                        if (string.IsNullOrEmpty(strTemp) == false)
                        {
                            strBuilder.Append("\r\n" + strTemp);
                            clsWebSrvFunctionsBLEx.SetGeneCode(objWebSrvFunctionsENEx.WebSrvFunctionId, true);
                        }
                        else
                        {
                            strTemp = string.Format("//�ú�����[{0}]�޷�����.", objWebSrvFunctionsENEx.FunctionSignature);
                            strBuilder.Append("\r\n" + strTemp);
                        }
                    }
                    catch (Exception objException)
                    {
                        strTemp = string.Format("//�ú�����[{0}]�޷�����.����:[{1}]({2}->{3})",
                            objWebSrvFunctionsENEx.FunctionSignature,
                            objException.Message,
                            clsStackTrace.GetCurrClassFunctionByLevel(2),
                            clsStackTrace.GetCurrClassFunction());
                        strBuilder.Append("\r\n" + strTemp);
                    }
                }
                strFuncName = "Gen_4WA_GetServiceUrl";
                clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncNameCacheEx(strFuncName);

                strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                if (string.IsNullOrEmpty(strTemp) == false)
                {
                    strBuilder.Append("\r\n" + strTemp);
                }

                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strBuilder.ToString();
        }



        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(RelaWA_Srv4CSharp);
                MethodInfo mt = t.GetMethod(strFuncName, BindingFlags.Instance | BindingFlags.Public);

                if (mt == null)
                {
                    string strMsg = string.Format("������û����Ӧ�ĺ���:{0}.(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                else
                {
                    //                string str = (string)mt.Invoke(null, new object[] { "1234567890123"    });
                    if (mt.GetParameters().Length == 0)
                    {
                        strCode = (string)mt.Invoke(this, null);
                    }
                    else if (mt.GetParameters().Length == 1)
                    {
                        strCode = (string)mt.Invoke(this, new object[] { objvFunction4GeneCodeEN });
                    }
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


        public string Gen_GetDataSet(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ���ݼ�,��DataSet��ʾ,ͬʱ����Ƿ���SQL����-�����");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// ���÷���: GET /api/{0}Api/{1}?{2}",
              objPrjTabENEx.TabName,
              clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code),
              strQueryString4ParaLst);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.AppendFormat("\r\n /// <returns>�������ݼ�,��DataSet��ʾ</returns>");
            strBuilder.Append("\r\n" + "[HttpGet]");
            strBuilder.AppendFormat("\r\n" + "public DataSet GetDataSet(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strWhereCond = strWhereCond.Replace(\"'% \", \"'%\");");
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");

            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n" + "DataSet objDS = cls{0}BL.GetDataSet(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_GetTopDataSet(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ���ݼ�,��DataSet��ʾ,ͬʱ����Ƿ���SQL����-�����");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// ���÷���: GET /api/{0}Api/{1}?{2}",
              objPrjTabENEx.TabName,
              clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code),
              strQueryString4ParaLst);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.AppendFormat("\r\n /// <returns>�������ݼ�,��DataSet��ʾ</returns>");
            strBuilder.Append("\r\n" + "[HttpGet]");
            strBuilder.AppendFormat("\r\n" + "public DataSet GetTopDataSet(int intTopSize, string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strWhereCond = strWhereCond.Replace(\"'% \", \"'%\");");
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");

            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n" + "DataSet objDS = cls{0}BL.GetDataSet_Top(intTopSize, strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_GetDataSetByRange(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ���ݼ�,��DataSet��ʾ,ͬʱ����Ƿ���SQL����-�����");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// ���÷���: GET /api/{0}Api/{1}?{2}",
              objPrjTabENEx.TabName,
              clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code),
              strQueryString4ParaLst);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strBuilder.AppendFormat("\r\n /// <returns>�������ݼ�,��DataSet��ʾ</returns>");
            strBuilder.Append("\r\n" + "[HttpGet]");
            strBuilder.AppendFormat("\r\n" + "public DataSet GetDataSetByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)",
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

            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n" + "DataSet objDS = cls{0}BL.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_GetDataSetV(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ��ǰ����ͼ�����ݼ�,��DataSet��ʾ");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// ���÷���: GET /api/{0}Api/{1}?{2}",
              objPrjTabENEx.TabName,
              clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code),
              strQueryString4ParaLst);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.AppendFormat("\r\n /// <returns>���ص�ǰ����ͼ�����ݼ�,��DataSet��ʾ</returns>");
            strBuilder.Append("\r\n" + "[HttpGet]");
            strBuilder.AppendFormat("\r\n" + "public DataSet GetDataSetV(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");

            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n" + "DataSet objDS = cls{0}BL.GetDataSetV(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return objDS;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_GetDataSetVByRange(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ����������ȡ���ݼ�,��DataSet��ʾ,ͬʱ����Ƿ���SQL����-�����");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// ���÷���: GET /api/{0}Api/{1}?{2}",
              objPrjTabENEx.TabName,
              clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code),
              strQueryString4ParaLst);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strBuilder.AppendFormat("\r\n /// <returns>�������ݼ�,��DataSet��ʾ</returns>");
            strBuilder.Append("\r\n" + "[HttpGet]");
            strBuilder.AppendFormat("\r\n" + "public DataSet GetDataSetVByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)",
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
            
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");

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
        public string Gen_GetRelationProperty(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ���ݶ���Ĺؼ���ֵ,��ȡ�����ȫ������");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// ���÷���: GET /api/{0}Api/{1}?{2}",
              objPrjTabENEx.TabName,
              clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code),
              strQueryString4ParaLst);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��ض���</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "/// <returns>�Ƿ�ɹ�</returns>");
            strBuilder.Append("\r\n" + "[HttpGet]");
            strBuilder.AppendFormat("\r\n" + "public ActionResult Get{0}(ref cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + " if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "   clsPubVar_WebApi.objLog.WriteDebugLog(\"clsSysParaEN.strTempXMLFileNameΪ��,����!\");");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n" + " else");
            strBuilder.Append("\r\n" + " {");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + " {");
            strBuilder.AppendFormat("\r\n" + "[\"obj{0}EN\"] = cls{0}BL.SerializeObjToXMLStr(obj{0}EN)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + " };");
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.Append("\r\n" + " }");


            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}BL.Get{0}(ref obj{0}EN);",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 0, errorMsg = \"\", returnBool = bolResult });");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        
        /// <summary>
        /// ��ȡ��¼����ͨ���ؼ���
        /// </summary>
        /// <returns></returns>
        public string Gen_GetObjByKeyId(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ��ȡ��ǰ�ؼ��ֵļ�¼����,�ö������ʽ��ʾ.");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// ���÷���: GET /api/{0}Api/{1}?{2}=value",
              objPrjTabENEx.TabName,
              TransKeyWords4FuncName(clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code)),
              objKeyField.FldName);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">��ؼ���</param>", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <returns>�����</returns>");
            strBuilder.Append("\r\n" + "[HttpGet]");
            strBuilder.AppendFormat("\r\n" + "public ActionResult GetObjBy{1}({2} {3})",
            objPrjTabENEx.TabName, objKeyField.FldName, objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
            objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == false)
            {
                strBuilder.AppendFormat("\r\n" + "[\"{0}\"] = {0}.ToString()", objKeyField.FldName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "[\"{0}\"] = {0}", objKeyField.FldName);
            }
            strBuilder.Append("\r\n };");
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            if (IsNumberType4Key == true)
            {
                strBuilder.AppendFormat("\r\n" + " if ({0} <= 0)",
                        objKeyField.FldName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty({0}) == true)",
                      objKeyField.FldName);
            }

            strBuilder.Append("\r\n" + " {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"���ݹؼ��ֻ�ȡ����ʱ,�ؼ��ֲ���Ϊ��!({0})\", clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = cls{0}BL.GetObjBy{1}({2});",
            objPrjTabENEx.TabName, objKeyField.FldName, objKeyField.FldName);

            strBuilder.AppendFormat("\r\n" + "return Json(new {{ errorId = 0, errorMsg = \"\", returnObj = obj{0}EN }});", objPrjTabENEx.TabName);

            //strBuilder.AppendFormat("\r\n" + "return obj{0}EN;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            //strBuilder.Append("\r\n" + "return null;");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        /// <summary>
        /// ��ȡ��¼����
        /// </summary>
        /// <returns></returns>
        public string Gen_GetObjLst(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ�����б�");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// ���÷���: GET /api/{0}Api/{1}?{2}",
              objPrjTabENEx.TabName,
              clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code),
              strQueryString4ParaLst);

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}Cond\">������������������</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>���ض����б�</returns>");
            strBuilder.Append("\r\n" + "[HttpPost]");
            strBuilder.AppendFormat("\r\n" + "public ActionResult GetObjLst([FromBody]cls{0}EN obj{0}Cond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            
            //strBuilder.Append("\r\n" + "strWhereCond = strWhereCond.Replace(\"'% \", \"'%\");");
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");

            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.AppendFormat("\r\n" + "string str{0}JSONObj = clsJSON.GetJsonFromObj(obj{0}Cond);",
      objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"str{0}JSONObj\", str{0}JSONObj);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            //strBuilder.Append("\r\n" + " if (string.IsNullOrEmpty(strWhereCond) == true)");
            //strBuilder.Append("\r\n" + " {");
            //strBuilder.Append("\r\n" + "string strMsg = string.Format(\"����������ȡ�����б�,��������Ϊ��!({0})\", clsStackTrace.GetCurrClassFunction());");
            ////strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            //strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            //strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n" + "cls{0}BL.SetUpdFlag(obj{0}Cond);",
        objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "IEnumerable<cls{0}EN> arr{0}ObjLst = cls{0}BL.GetObjLst(obj{0}Cond);",
            objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLst;",
            //objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "return Json(new {{ errorId = 0, errorMsg = \"\", returnObjLst = arr{0}ObjLst }});", objPrjTabENEx.TabName);


            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            //strBuilder.Append("\r\n" + "return null;");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_GetObjLstCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ�����б�");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// ���÷���: GET /api/{0}Api/{1}?{2}",
              objPrjTabENEx.TabName,
              clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code),
              strQueryString4ParaLst);

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            //strBuilder.Append("\r\n /// <param name = \"strWhereCond\">��������</param>");
            strBuilder.Append("\r\n /// <returns>���ض����б�</returns>");
            strBuilder.Append("\r\n" + "[HttpGet]");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "public ActionResult GetObjLstCache()",
            objPrjTabENEx.TabName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "public ActionResult GetObjLstCache({0} {1})",
    objPrjTabENEx.objCacheClassifyFld.CsType, objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }
            strBuilder.Append("\r\n" + "{");
            
            //strBuilder.Append("\r\n" + "strWhereCond = strWhereCond.Replace(\"'% \", \"'%\");");
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");

            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
      
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst = cls{0}BL.GetObjLstCache();",
            objPrjTabENEx.TabName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst = cls{0}BL.GetObjLstCache({1});",
                    objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }
            //strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLst;",
            //objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "return Json(new {{ errorId = 0, errorMsg = \"\", returnObjLst = arr{0}ObjLst }});", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            //strBuilder.Append("\r\n" + "return null;");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_GetObjLstByKeyLst(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ���ݹؼ����б��ȡ��ض����б�");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// ���÷���: POST /api/{0}api/GetObjLstBy{1}Lst",
              objPrjTabENEx.TabName,
            objKeyField.FldName_FstUcase);

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"arr{0}Lst\">�����Ĺؼ���</param>", objKeyField.FldName_FstUcase);
            strBuilder.AppendFormat("\r\n /// <returns>���ݹؼ��ֻ�ȡ�Ķ���</returns>");
            strBuilder.Append("\r\n" + "[HttpPost]");
            strBuilder.AppendFormat("\r\n" + "public ActionResult GetObjLstBy{1}Lst([FromBody]string[] arr{1})",
                    objPrjTabENEx.TabName,
                    objKeyField.FldName_FstUcase);
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.AppendFormat("\r\n" + "List<string> arrLst = new(arr{0});", objKeyField.FldName_FstUcase);
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"arr{0}\", clsArray.GetSqlInStrByArray(arrLst, true));", objKeyField.FldName);
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.AppendFormat("\r\n" + "if (arr{0}.Length == 0)", objKeyField.FldName_FstUcase);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"���ݹؼ����б���ȡ�����б�ʱ,�����Ĺؼ���ֵ�б��JSON������Ϊ��!({0})\", clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "string[] sstrCollegeId = strKeyIdLst.Trim().Split(','); ");
            if (objKeyField.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "List<string> lst{0} = new(arr{0});", objKeyField.FldName_FstUcase                    );
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "List<string> lst{0}_Str = new List<string>(arr{0});", objKeyField.FldName_FstUcase);
                strBuilder.AppendFormat("\r\n" + "List<{0}> lst{1} = lst{1}_Str.Select(x=>{0}.Parse(x)).ToList();", 
                    objKeyField.CsType,
                    objKeyField.FldName_FstUcase);

            }


            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst = cls{0}BL.GetObjLstBy{1}Lst(lst{1});",
            objPrjTabENEx.TabName, objKeyField.FldName_FstUcase);
            //strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLst;",
            //objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "return Json(new {{ errorId = 0, errorMsg = \"\", returnObjLst = arr{0}ObjLst }});", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            //strBuilder.Append("\r\n" + "return null;");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_DelRelationBySign(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ���ݱ�־ɾ���ؼ����б�");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// ���÷���: POST /api/{0}api/DelRelationBySign",
              objPrjTabENEx.TabName,
            objKeyField.FldName_FstUcase);

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"arr{0}Lst\">�����Ĺؼ����б�</param>", objKeyField.FldName_FstUcase);
            strBuilder.AppendFormat("\r\n /// <returns>ɾ���ļ�¼��</returns>");
            strBuilder.Append("\r\n" + "[HttpPost]");
            strBuilder.AppendFormat("\r\n" + "public ActionResult DelRelationBySign([FromBody]string[] arr{1})",
                    objPrjTabENEx.TabName,
                    objKeyField.FldName_FstUcase);
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.AppendFormat("\r\n" + "List<string> arrLst = new(arr{0});", objKeyField.FldName_FstUcase);
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"arr{0}\", clsArray.GetSqlInStrByArray(arrLst, true));", objKeyField.FldName);
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.AppendFormat("\r\n" + "if (arr{0}.Length == 0)", objKeyField.FldName_FstUcase);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"���ݱ�־ɾ����¼ʱ,�����Ĺؼ���ֵ�б���Ϊ��!({0})\", clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "string[] sstrCollegeId = strKeyIdLst.Trim().Split(','); ");
            if (objKeyField.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "List<string> lst{0} = new(arr{0});", objKeyField.FldName_FstUcase);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "List<string> lst{0}_Str = new List<string>(arr{0});", objKeyField.FldName_FstUcase);
                strBuilder.AppendFormat("\r\n" + "List<{0}> lst{1} = lst{1}_Str.Select(x=>{0}.Parse(x)).ToList();",
                    objKeyField.CsType,
                    objKeyField.FldName_FstUcase);
            }
            
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n" + "int intRecNum = cls{0}BL.DelRelationBySign(lst{1});",
            objPrjTabENEx.TabName, objKeyField.FldName_FstUcase);
            strBuilder.Append("\r\n" + "return Json(new { errorId = 0, errorMsg = \"\", returnInt = intRecNum });");

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            //strBuilder.Append("\r\n" + "return 0;");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_UnDelRelationBySign(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ���ݱ�־�ָ�ɾ���ļ�¼�б�");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// ���÷���: POST /api/{0}api/UnDelRelationBySign",
              objPrjTabENEx.TabName,
            objKeyField.FldName_FstUcase);

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"arr{0}Lst\">�����Ĺؼ����б�</param>", objKeyField.FldName_FstUcase);
            strBuilder.AppendFormat("\r\n /// <returns>�ָ�ɾ���ļ�¼��</returns>");
            strBuilder.Append("\r\n" + "[HttpPost]");
            strBuilder.AppendFormat("\r\n" + "public ActionResult UnDelRelationBySign([FromBody]string[] arr{1})",
                    objPrjTabENEx.TabName,
                    objKeyField.FldName_FstUcase);
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.AppendFormat("\r\n" + "List<string> arrLst = new(arr{0});", objKeyField.FldName_FstUcase);
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"arr{0}\", clsArray.GetSqlInStrByArray(arrLst, true));", objKeyField.FldName);
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.AppendFormat("\r\n" + "if (arr{0}.Length == 0)", objKeyField.FldName_FstUcase);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"���ݱ�־�ָ�ɾ����¼ʱ,�����Ĺؼ���ֵ�б���Ϊ��!({0})\", clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "string[] sstrCollegeId = strKeyIdLst.Trim().Split(','); ");
            if (objKeyField.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "List<string> lst{0} = new(arr{0});", objKeyField.FldName_FstUcase);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "List<string> lst{0}_Str = new List<string>(arr{0});", objKeyField.FldName_FstUcase);
                strBuilder.AppendFormat("\r\n" + "List<{0}> lst{1} = lst{1}_Str.Select(x=>{0}.Parse(x)).ToList();",
                    objKeyField.CsType,
                    objKeyField.FldName_FstUcase);
            }

            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n" + "int intRecNum = cls{0}BL.UnDelRelationBySign(lst{1});",
            objPrjTabENEx.TabName, objKeyField.FldName_FstUcase);
            strBuilder.Append("\r\n" + "return Json(new { errorId = 0, errorMsg = \"\", returnInt = intRecNum });");

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            //strBuilder.Append("\r\n" + "return 0;");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        /// <summary>
        /// ��ȡ��¼����
        /// </summary>
        /// <returns></returns>
        public string Gen_GetTopObjLst(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ���������б�");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// ���÷���: GET /api/{0}Api/{1}?{2}",
              objPrjTabENEx.TabName,
              clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code),
              strQueryString4ParaLst);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"objTopPara\">��ȡ���������б�Ĳ�������</param>");     
            strBuilder.Append("\r\n /// <returns>���ض����б�</returns>");
            strBuilder.Append("\r\n" + "[HttpPost]");
            strBuilder.AppendFormat("\r\n" + "public ActionResult GetTopObjLst([FromBody]stuTopPara objTopPara)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.Append("\r\n" + "objTopPara.whereCond = objTopPara.whereCond.Replace(\"'% \", \"'%\");");
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = objTopPara.GetDictParam();");
    
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.Append("\r\n" + " if (string.IsNullOrEmpty(objTopPara.whereCond) == true)");
            strBuilder.Append("\r\n" + " {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"����������ȡ���������б�,��������Ϊ��!({0})\", clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n" + " if (objTopPara.topSize <= 0)");
            strBuilder.Append("\r\n" + " {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"����������ȡ���������б�,������¼��:[{0}]����С�ڵ���0!({1})\", objTopPara.topSize, clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst = cls{0}BL.GetTopObjLst(objTopPara);",
            objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLst;",
            //objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "return Json(new {{ errorId = 0, errorMsg = \"\", returnObjLst = arr{0}ObjLst }});", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            //strBuilder.Append("\r\n" + "return null;");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_GetRelationPropertyV(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ���ݶ���Ĺؼ���ֵ,��ȡ�����ȫ������");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// ���÷���: GET /api/{0}Api/{1}?{2}",
              objPrjTabENEx.TabName,
              clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code),
              strQueryString4ParaLst);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��ض���</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "/// <returns>�Ƿ�ɹ�</returns>");
            strBuilder.Append("\r\n" + "[HttpGet]");
            strBuilder.AppendFormat("\r\n" + "public ActionResult Get{0}V(ref cls{0}EN obj{0}EN)",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + " if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "   clsPubVar_WebApi.objLog.WriteDebugLog(\"clsSysParaEN.strTempXMLFileNameΪ��,����!\");");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n" + " else");
            strBuilder.Append("\r\n" + " {");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + " {");
            strBuilder.AppendFormat("\r\n" + "[\"obj{0}EN\"] = cls{0}BL.SerializeObjToXMLStr(obj{0}EN)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + " };");
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.Append("\r\n" + " }");


            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}BL.Get{0}(ref obj{0}EN);",
                    objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 0, errorMsg = \"\", returnBool = bolResult });");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_IsExistRelationByCond(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:�ж��Ƿ����ĳһ�����ļ�¼");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// ���÷���: GET /api/{0}Api/{1}?{2}",
              objPrjTabENEx.TabName,
              clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code),
              strQueryString4ParaLst);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <returns>���������Jobject, ������ھͷ���TRUE,���򷵻�FALSE</returns>");
            strBuilder.Append("\r\n" + "[HttpGet]");
            strBuilder.AppendFormat("\r\n" + "public ActionResult IsExistRelation(string strWhereCond)",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");

            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.Append("\r\n" + " if (string.IsNullOrEmpty(strWhereCond) == true)");
            strBuilder.Append("\r\n" + " {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"�ж��Ƿ����ĳһ�����ļ�¼,��������Ϊ��!({0})\", clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");

            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n" + "bool bolIsExist = cls{0}BL.IsExistRelation(strWhereCond);",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return Json(new { errorId = 0, errorMsg = \"\", returnBool = bolIsExist });");

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");

            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            //strBuilder.Append("\r\n" + "return false;");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_GetRecCountByCond(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:��ȡĳһ�����ļ�¼��");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// ���÷���: GET /api/{0}Api/{1}?{2}",
              objPrjTabENEx.TabName,
              clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code),
              strQueryString4ParaLst);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}Cond\">������������������</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>ĳһ�����ļ�¼��</returns>");
            strBuilder.Append("\r\n" + "[HttpPost]");
            strBuilder.AppendFormat("\r\n" + "public ActionResult GetRecCountByCond([FromBody]cls{0}EN obj{0}Cond)",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");

            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");

            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            //strBuilder.Append("\r\n" + " if (string.IsNullOrEmpty(strWhereCond) == true)");
            //strBuilder.Append("\r\n" + " {");
            //strBuilder.Append("\r\n" + "string strMsg = string.Format(\"��ȡĳһ�����ļ�¼��,��������Ϊ��!({0})\", clsStackTrace.GetCurrClassFunction());");
            ////strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            //strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            //strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n" + "cls{0}BL.SetUpdFlag(obj{0}Cond);",
                    objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "long intCount = cls{0}BL.GetRecCountByCond(obj{0}Cond);",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return Json(new { errorId = 0, errorMsg = \"\", returnInt = intCount });");

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            //strBuilder.Append("\r\n" + "return 0;");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_GetFldValue(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:��ȡ�����������������ļ�¼��, �ñ��뵱ǰ����ء�");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// ���÷���: GET /api/{0}Api/{1}?{2}",
              objPrjTabENEx.TabName,
              clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code),
                   strQueryString4ParaLst);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">�������ļ�¼����</param>");
            strBuilder.Append("\r\n /// <returns>��¼��,Ϊ����</returns>");
            strBuilder.Append("\r\n" + "[HttpGet]");
            strBuilder.Append("\r\npublic ActionResult GetFldValue(string strFldName, string strWhereCond)");
            strBuilder.Append("\r\n{");
            
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");

            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strFldName\"] = strFldName,");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.Append("\r\n" + " if (string.IsNullOrEmpty(strWhereCond) == true)");
            strBuilder.Append("\r\n" + " {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"��ȡĳһ�������ֶ�ֵ,��������Ϊ��!({0})\", clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n" + "List<string> arrList = cls{0}BL.GetFldValue(strFldName, strWhereCond);",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return Json(new { errorId = 0, errorMsg = \"\", returnStrLst = string.Join(\",\", arrList) });");

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            //strBuilder.Append("\r\n" + "return 0;");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
            //strBuilder.AppendFormat("\r\n List<string> arrList = {0}DA.GetFldValue(strFldName, strWhereCond);", objPrjTabENEx.TabName);
            //strBuilder.Append("\r\nreturn arrList;");        
        }
        public string Gen_funSetFldValue(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:��ȡ�����������������ļ�¼��, �ñ��뵱ǰ����ء�");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// ���÷���: GET /api/{0}Api/{1}?{2}",
              objPrjTabENEx.TabName,
              clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code),
                   strQueryString4ParaLst);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n /// <param name = \"strValue\">ֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">�������ļ�¼����</param>");
            strBuilder.Append("\r\n /// <returns>��¼��,Ϊ����</returns>");
            strBuilder.Append("\r\n" + "[HttpGet]");
            strBuilder.Append("\r\npublic ActionResult SetFldValue(string strFldName, string strValue, string strWhereCond)");
            strBuilder.Append("\r\n{");
            
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");

            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strFldName\"] = strFldName,");
            strBuilder.Append("\r\n" + "[\"strValue\"] = strValue,");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.Append("\r\n" + " if (string.IsNullOrEmpty(strWhereCond) == true)");
            strBuilder.Append("\r\n" + " {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"��ȡĳһ�������ֶ�ֵ,��������Ϊ��!({0})\", clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n" + "int intRecCount = cls{0}BL.SetFldValue(cls{0}EN._CurrTabName, strFldName, strValue, strWhereCond);",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return Json(new { errorId = 0, errorMsg = \"\", returnInt = intRecCount });");

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            //strBuilder.Append("\r\n" + "return 0;");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
            //strBuilder.AppendFormat("\r\n List<string> arrList = {0}DA.GetFldValue(strFldName, strWhereCond);", objPrjTabENEx.TabName);
            //strBuilder.Append("\r\nreturn arrList;");        
        }


        public string Gen_IsExist(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �жϵ�ǰ�����Ƿ���ڸ����ؼ���ֵ�ļ�¼");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// ���÷���: GET /api/{0}Api/{1}?{2}=value",
              objPrjTabENEx.TabName,
              clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code),
              objKeyField.FldName);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���ֵ</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <returns>�����Ƿ����?</returns>");
            strBuilder.Append("\r\n" + "[HttpGet]");
            strBuilder.AppendFormat("\r\n" + "public ActionResult IsExist({1} {2})",
                    objPrjTabENEx.TabName, objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
            objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == false)
            {
                strBuilder.AppendFormat("\r\n" + "[\"{0}\"] = {0}.ToString()", objKeyField.FldName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "[\"{0}\"] = {0}", objKeyField.FldName);
            }
            strBuilder.Append("\r\n };");
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            if (IsNumberType4Key == true)
            {
                strBuilder.AppendFormat("\r\n" + " if ({0} <= 0)",
                        objKeyField.FldName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty({0}) == true)",
                      objKeyField.FldName);
            }
            strBuilder.Append("\r\n" + " {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"�жϱ����Ƿ���ڸ����ؼ��ֵļ�¼ʱ,�ؼ��ֲ���Ϊ��!({0})\", clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n" + "bool bolIsExist = cls{0}BL.IsExist({1});",
                    objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "return Json(new { errorId = 0, errorMsg = \"\", returnBool = bolIsExist });");

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            //strBuilder.Append("\r\n" + "return false;");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_GetMaxStrId(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.Append("\r\n /// ��ȡ��ǰ��ؼ���ֵ�����ֵ,�ټ�1,�����ظ�");
                string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
                strBuilder.AppendFormat("\r\n /// ���÷���: GET /api/{0}Api/{1}?{2}",
                  objPrjTabENEx.TabName,
                  clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code),
                  strQueryString4ParaLst);
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");

                strBuilder.Append("\r\n /// <returns>��ǰ��ؼ���ֵ�����ֵ,�ټ�1</returns>");
                strBuilder.Append("\r\n" + "[HttpGet]");
                strBuilder.AppendFormat("\r\n" + "public ActionResult GetMaxStrId()",
                        objPrjTabENEx.TabName, objPrjTabENEx.KeyVarDefineLstStr);
                strBuilder.Append("\r\n" + "{");
                
                strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
                strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
                //  strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"str{0}JSONObj\", str{0}JSONObj);", objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
                strBuilder.Append("\r\n try");
                strBuilder.Append("\r\n {");
                strBuilder.AppendFormat("\r\n" + "string strMax{1} = cls{0}BL.GetMaxStrId();",
                        objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr, objKeyField.FldName_FstUcase);
                strBuilder.AppendFormat("\r\n" + "return Json(new {{ errorId = 0, errorMsg = \"\", returnStr =  strMax{0} }});", objPrjTabENEx.KeyPrivFuncFldNameLstStr);

                strBuilder.Append("\r\n }");
                strBuilder.Append("\r\n catch (Exception objException)");
                strBuilder.Append("\r\n {");
                strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
                //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
                //strBuilder.Append("\r\n" + "return \"\";");
                strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
                strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
                strBuilder.Append("\r\n }");
                strBuilder.Append("\r\n" + "}");
            }
            return strBuilder.ToString();
        }

        public string Gen_GetMaxStrIdByPrefix(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.Append("\r\n /// ��ȡ��ǰ��ؼ���ֵ�����ֵ,�ټ�1,�����ظ�");
                string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
                strBuilder.AppendFormat("\r\n /// ���÷���: GET /api/{0}Api/{1}?{2}",
                  objPrjTabENEx.TabName,
                  clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code),
                  strQueryString4ParaLst);
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.Append("\r\n /// <returns>��ǰ��ؼ���ֵ�����ֵ,�ټ�1</returns>");
                strBuilder.Append("\r\n" + "[HttpGet]");
                strBuilder.AppendFormat("\r\n" + "public ActionResult GetMaxStrIdByPrefix(string strPrefix)",
                        objPrjTabENEx.TabName, objPrjTabENEx.KeyVarDefineLstStr);
                strBuilder.Append("\r\n" + "{");
                
                strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
                strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
                strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"strPrefix\", strPrefix);", objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
                strBuilder.Append("\r\n try");
                strBuilder.Append("\r\n {");
                strBuilder.AppendFormat("\r\n" + "string strMax{1} = cls{0}BL.GetMaxStrIdByPrefix(strPrefix);",
                        objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr, objKeyField.FldName_FstUcase);
                strBuilder.AppendFormat("\r\n" + "return Json(new {{ errorId = 0, errorMsg = \"\", returnStr =  strMax{0} }});", objPrjTabENEx.KeyPrivFuncFldNameLstStr);

                strBuilder.Append("\r\n }");
                strBuilder.Append("\r\n catch (Exception objException)");
                strBuilder.Append("\r\n {");
                strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
                //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
                //strBuilder.Append("\r\n" + "return \"\";");
                strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
                strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
                strBuilder.Append("\r\n }");
                strBuilder.Append("\r\n" + "}");
            }
            return strBuilder.ToString();
        }




        public string Gen_AddNewRelation(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ͨ��JSON��������Ӽ�¼����");
            strBuilder.AppendFormat("\r\n /// ���÷���: POST /api/{0}Api/{1}",
             objPrjTabENEx.TabName,
             clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code));
            strBuilder.AppendFormat("\r\n /// ��Body������obj{0}EN��JSON����", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">����</param>",
              objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>�Ƿ�ɹ�</returns>");
            strBuilder.Append("\r\n" + "[HttpPost]");
            strBuilder.AppendFormat("\r\n" + "public ActionResult AddNewRelation([FromBody]cls{0}EN obj{0}EN)",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.AppendFormat("\r\n" + "string str{0}JSONObj = clsJSON.GetJsonFromObj(obj{0}EN);",
              objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"str{0}JSONObj\", str{0}JSONObj);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            if (objKeyField.PrimaryTypeId != enumPrimaryType.StringAutoAddPrimaryKey_03
                && objKeyField.PrimaryTypeId != enumPrimaryType.Identity_02
                && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "bool")
            {
                if (objKeyField.ObjFieldTabENEx.IsNumberType() == false)
                {
                    strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true)",
                        objPrjTabENEx.TabName, objKeyField.FldName);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + " if (obj{0}EN.{1} == 0)",
                        objPrjTabENEx.TabName, objKeyField.FldName);
                }
                strBuilder.Append("\r\n" + " {");
                strBuilder.Append("\r\n" + "string strMsg = string.Format(\"��Ӽ�¼ʱ,�ؼ��ֲ���Ϊ��!({0})\", clsStackTrace.GetCurrClassFunction());");
                //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");

                strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
                //strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
                //strBuilder.Append("\r\n throw new Exception(strMsg);");

                strBuilder.Append("\r\n" + " }");

                strBuilder.AppendFormat("\r\n" + " if (cls{0}BL.IsExist({1}) == true)",
                   objPrjTabENEx.TabName, strKeyFldName_ObjName);
                strBuilder.Append("\r\n" + " {");
                strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"��Ӽ�¼ʱ,�ؼ���:[{{0}}]�Ѿ�����!({{1}})\", obj{0}EN.{1}, clsStackTrace.GetCurrClassFunction());",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                //strBuilder.Append("\r\n" + " clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");

                strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
                //strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
                //strBuilder.Append("\r\n throw new Exception(strMsg);");
                strBuilder.Append("\r\n" + " }");
            }


            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
            {
                strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true || cls{0}BL.IsExist({2}) == true)",
                    objPrjTabENEx.TabName, objKeyField.FldName, strKeyFldName_ObjName);
                strBuilder.Append("\r\n" + " {");
                strBuilder.AppendFormat("\r\n" + "     obj{0}EN.{1} = cls{0}BL.GetMaxStrId();",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.Append("\r\n" + " }");
            }
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}EN.AddNewRelation();",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 0, errorMsg = \"\", returnBool = bolResult });");

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "return clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_AddNewRelationWithMaxId(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "string") return "";
                clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ͨ��JSON��������Ӽ�¼����");
            strBuilder.AppendFormat("\r\n /// ���÷���: POST /api/{0}Api/{1}",
             objPrjTabENEx.TabName,
             clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code));
            strBuilder.AppendFormat("\r\n /// ��Body������obj{0}EN��JSON����", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">����</param>",
              objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>�Ƿ�ɹ�</returns>");
            strBuilder.Append("\r\n" + "[HttpPost]");
            strBuilder.AppendFormat("\r\n" + "public ActionResult AddNewRelationWithMaxId([FromBody]cls{0}EN obj{0}EN)",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.AppendFormat("\r\n" + "string str{0}JSONObj = clsJSON.GetJsonFromObj(obj{0}EN);",
              objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"str{0}JSONObj\", str{0}JSONObj);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
           
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");

            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}EN.AddNewRelationWithMaxId();",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 0, errorMsg = \"\", returnBool = bolResult });");

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "return clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_GoTop(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlView_02) return "";
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            clsAdjustOrderNum objAdjustOrderNum = clsAdjustOrderNum.GetOrderNumInfoByPrjTab(objPrjTabENEx);

            if (objAdjustOrderNum.objTabFeature_AdjustOrderNum == null) return "";

            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �������Ĺؼ����б���صļ�¼�ƶ�");
            strBuilder.AppendFormat("\r\n /// ���÷���: POST /api/{0}Api/{1}",
             objPrjTabENEx.TabName,
             clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code));
            strBuilder.AppendFormat("\r\n /// ��Body������clsOrderByData��JSON����", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">����</param>",
              objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>�Ƿ�ɹ�</returns>");
            strBuilder.Append("\r\n" + "[HttpPost]");
            strBuilder.AppendFormat("\r\n" + "public ActionResult GoTop([FromBody]clsOrderByData objOrderByData)",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.Append("\r\n" + "List<string> arrLst = new(objOrderByData.KeyIdLst);");
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"arr{0}\", clsArray.GetSqlInStrByArray(arrLst, true));", objKeyField.FldName);
            strBuilder.Append("\r\n" + "dictParam.Add(\"ClassificationFieldValueLst\", objOrderByData.ClassificationFieldValueLst);");
            //strBuilder.Append("\r\n" + "dictParam.Add(\"ClassificationFieldValue2\", objOrderByData.ClassificationFieldValue2);");

                 
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.Append("\r\n" + "if (objOrderByData.KeyIdLst.Length == 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"���ݹؼ����б��ö�ʱ,�����Ĺؼ���ֵ�б��JSON������Ϊ��!({0})\", clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");

            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + "}");
            if (objKeyField.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "List<string> lst{0} = new(objOrderByData.KeyIdLst);", objKeyField.FldName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "List<string> lst{0}_T = new(objOrderByData.KeyIdLst);", objKeyField.FldName);
                strBuilder.AppendFormat("\r\n" + "List<{0}> lst{1} = lst{1}_T.Select(x=>{0}.Parse(x)).ToList();",
                objKeyField.CsType,
                objKeyField.FldName);
            }
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");

            if (objAdjustOrderNum.arrFieldLst_Classify.Count() > 0)
            {
                strBuilder.Append("\r\n" + "JObject jobjOrderByData = JObject.Parse(objOrderByData.ClassificationFieldValueLst);");

                foreach (clsTabFeatureFldsEN objInFor in objAdjustOrderNum.arrFieldLst_Classify)
                {
                    string strTemp = clsPubFun4GC.Gene_GetKeyData(objInFor);
                    strBuilder.Append("\r\n" + strTemp);
                }
                strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}BL.GoTop(lst{1}, {2});",
                        objPrjTabENEx.TabName, objKeyField.FldName,
                        objAdjustOrderNum.VarLst);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}BL.GoTop(lst{1});", objPrjTabENEx.TabName, objKeyField.FldName);
            }

            //strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 0, errorMsg = \"\", returnBool = bolResult });");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "return clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_GoBottom(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlView_02) return "";
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            clsAdjustOrderNum objAdjustOrderNum = clsAdjustOrderNum.GetOrderNumInfoByPrjTab(objPrjTabENEx);

            if (objAdjustOrderNum.objTabFeature_AdjustOrderNum == null) return "";

            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �������Ĺؼ����б���صļ�¼�Ƶ�");
            strBuilder.AppendFormat("\r\n /// ���÷���: POST /api/{0}Api/{1}",
             objPrjTabENEx.TabName,
             clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code));
            strBuilder.AppendFormat("\r\n /// ��Body������clsOrderByData��JSON����", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">����</param>",
              objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>�Ƿ�ɹ�</returns>");
            strBuilder.Append("\r\n" + "[HttpPost]");
            strBuilder.AppendFormat("\r\n" + "public ActionResult GoBottom([FromBody]clsOrderByData objOrderByData)",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
                        
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.Append("\r\n" + "List<string> arrLst = new(objOrderByData.KeyIdLst);");
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"arr{0}\", clsArray.GetSqlInStrByArray(arrLst, true));", objKeyField.FldName);
            strBuilder.Append("\r\n" + "dictParam.Add(\"ClassificationFieldValueLst\", objOrderByData.ClassificationFieldValueLst);");
            //strBuilder.Append("\r\n" + "dictParam.Add(\"ClassificationFieldValue2\", objOrderByData.ClassificationFieldValue2);");


            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.Append("\r\n" + "if (objOrderByData.KeyIdLst.Length == 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"���ݹؼ����б��õ�ʱ,�����Ĺؼ���ֵ�б��JSON������Ϊ��!({0})\", clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");

            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + "}");
            if (objKeyField.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "List<string> lst{0} = new(objOrderByData.KeyIdLst);", objKeyField.FldName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "List<string> lst{0}_T = new(objOrderByData.KeyIdLst);", objKeyField.FldName);
                strBuilder.AppendFormat("\r\n" + "List<{0}> lst{1} = lst{1}_T.Select(x=>{0}.Parse(x)).ToList();",
                objKeyField.CsType,
                objKeyField.FldName);
            }
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");

            if (objAdjustOrderNum.arrFieldLst_Classify.Count() > 0)
            {
                strBuilder.Append("\r\n" + "JObject jobjOrderByData = JObject.Parse(objOrderByData.ClassificationFieldValueLst);");

                foreach (clsTabFeatureFldsEN objInFor in objAdjustOrderNum.arrFieldLst_Classify)
                {
                    string strTemp = clsPubFun4GC.Gene_GetKeyData(objInFor);
                    strBuilder.Append("\r\n" + strTemp);
               
                }
                strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}BL.GoBottom(lst{1}, {2});",
               objPrjTabENEx.TabName, objKeyField.FldName,
               objAdjustOrderNum.VarLst);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}BL.GoBottom(lst{1});", objPrjTabENEx.TabName, objKeyField.FldName);
            }

            //strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 0, errorMsg = \"\", returnBool = bolResult });");


            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "return clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");

            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_ReOrder(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlView_02) return "";
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            clsAdjustOrderNum objAdjustOrderNum = clsAdjustOrderNum.GetOrderNumInfoByPrjTab(objPrjTabENEx);

            if (objAdjustOrderNum.objTabFeature_AdjustOrderNum == null) return "";

            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �������Ĺؼ����б���صļ�¼�Ƶ�");
            strBuilder.AppendFormat("\r\n /// ���÷���: POST /api/{0}Api/{1}",
             objPrjTabENEx.TabName,
             clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code));
            strBuilder.AppendFormat("\r\n /// ��Body������clsOrderByData��JSON����", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">����</param>",
              objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>�Ƿ�ɹ�</returns>");
            strBuilder.Append("\r\n" + "[HttpPost]");
            strBuilder.AppendFormat("\r\n" + "public ActionResult ReOrder([FromBody]clsOrderByData objOrderByData)",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            //strBuilder.Append("\r\n" + "List<string> arrLst = new(objOrderByData.KeyIdLst);");
            //strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"arr{0}\", clsArray.GetSqlInStrByArray(arrLst, true));", objKeyField.FldName);
            strBuilder.Append("\r\n" + "dictParam.Add(\"ClassificationFieldValueLst\", objOrderByData.ClassificationFieldValueLst);");
            //strBuilder.Append("\r\n" + "dictParam.Add(\"ClassificationFieldValue2\", objOrderByData.ClassificationFieldValue2);");

            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");

            //strBuilder.Append("\r\n" + "if (objOrderByData.KeyIdLst.Length == 0)");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "string strMsg = string.Format(\"���ݹؼ����б��õ�ʱ,�����Ĺؼ���ֵ�б��JSON������Ϊ��!({0})\", clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            //strBuilder.Append("\r\n" + "}");
            //strBuilder.AppendFormat("\r\n" + "List<string> lst{0} = new(objOrderByData.KeyIdLst);", objKeyField.FldName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");

            if (objAdjustOrderNum.arrFieldLst_Classify.Count() > 0)
            {
                strBuilder.Append("\r\n" + "JObject jobjOrderByData = JObject.Parse(objOrderByData.ClassificationFieldValueLst);");

                foreach (clsTabFeatureFldsEN objInFor in objAdjustOrderNum.arrFieldLst_Classify)
                {
                    string strTemp = clsPubFun4GC.Gene_GetKeyData(objInFor);
                    strBuilder.Append("\r\n" + strTemp);
                }
                strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}BL.ReOrder({1});",
                    objPrjTabENEx.TabName, objAdjustOrderNum.VarLst);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}BL.ReOrder();", objPrjTabENEx.TabName, objKeyField.FldName);
            }

            //strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 0, errorMsg = \"\", returnBool = bolResult });");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "return clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_UpMove(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlView_02) return "";
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            clsAdjustOrderNum objAdjustOrderNum = clsAdjustOrderNum.GetOrderNumInfoByPrjTab(objPrjTabENEx);

            if (objAdjustOrderNum.objTabFeature_AdjustOrderNum == null) return "";

            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �������Ĺؼ����б���صļ�¼����");
            strBuilder.AppendFormat("\r\n /// ���÷���: POST /api/{0}Api/{1}",
             objPrjTabENEx.TabName,
             clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code));
            strBuilder.AppendFormat("\r\n /// ��Body������clsOrderByData��JSON����", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">����</param>",
              objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>�Ƿ�ɹ�</returns>");
            strBuilder.Append("\r\n" + "[HttpPost]");
            strBuilder.AppendFormat("\r\n" + "public ActionResult UpMove([FromBody]clsOrderByData objOrderByData)",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.Append("\r\n" + "List<string> arrLst = new(objOrderByData.KeyIdLst);");
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"arr{0}\", clsArray.GetSqlInStrByArray(arrLst, true));", objKeyField.FldName);
            strBuilder.Append("\r\n" + "dictParam.Add(\"ClassificationFieldValueLst\", objOrderByData.ClassificationFieldValueLst);");
            //strBuilder.Append("\r\n" + "dictParam.Add(\"ClassificationFieldValue2\", objOrderByData.ClassificationFieldValue2);");
            
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.Append("\r\n" + "if (objOrderByData.KeyIdLst.Length == 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"���ݹؼ����б�����ʱ,�����Ĺؼ���ֵ�б��JSON������Ϊ��!({0})\", clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + "}");
            if (objKeyField.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "List<string> lst{0} = new(objOrderByData.KeyIdLst);", objKeyField.FldName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "List<string> lst{0}_T = new(objOrderByData.KeyIdLst);", objKeyField.FldName);
                strBuilder.AppendFormat("\r\n" + "List<{0}> lst{1} = lst{1}_T.Select(x=>{0}.Parse(x)).ToList();",
                objKeyField.CsType,
                objKeyField.FldName);
            }
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.AppendFormat("\r\n" + "foreach(var x in lst{0})", objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            if (objAdjustOrderNum.arrFieldLst_Classify.Count() > 0)
            {
                strBuilder.Append("\r\n" + "JObject jobjOrderByData = JObject.Parse(objOrderByData.ClassificationFieldValueLst);");

                foreach (clsTabFeatureFldsEN objInFor in objAdjustOrderNum.arrFieldLst_Classify)
                {
                    string strTemp = clsPubFun4GC.Gene_GetKeyData(objInFor);
                    strBuilder.Append("\r\n" + strTemp);
                }
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.AdjustOrderNum(\"UP\", x, {1});",
                        objPrjTabENEx.TabName, objAdjustOrderNum.VarLst);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.AdjustOrderNum(\"UP\", x);",
                 objPrjTabENEx.TabName, objKeyField.FldName);
            }
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 0, errorMsg = \"\", returnBool = true });");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "return clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_DownMove(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlView_02) return "";
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            clsAdjustOrderNum objAdjustOrderNum = clsAdjustOrderNum.GetOrderNumInfoByPrjTab(objPrjTabENEx);

            if (objAdjustOrderNum.objTabFeature_AdjustOrderNum == null) return "";

            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �������Ĺؼ����б���صļ�¼����");
            strBuilder.AppendFormat("\r\n /// ���÷���: POST /api/{0}Api/{1}",
             objPrjTabENEx.TabName,
             clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code));
            strBuilder.AppendFormat("\r\n /// ��Body������clsOrderByData��JSON����", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">����</param>",
              objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>�Ƿ�ɹ�</returns>");
            strBuilder.Append("\r\n" + "[HttpPost]");
            strBuilder.AppendFormat("\r\n" + "public ActionResult DownMove([FromBody]clsOrderByData objOrderByData)",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.Append("\r\n" + "List<string> arrLst = new(objOrderByData.KeyIdLst);");
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"arr{0}\", clsArray.GetSqlInStrByArray(arrLst, true));", objKeyField.FldName);
            strBuilder.Append("\r\n" + "dictParam.Add(\"ClassificationFieldValueLst\", objOrderByData.ClassificationFieldValueLst);");
            //strBuilder.Append("\r\n" + "dictParam.Add(\"ClassificationFieldValue2\", objOrderByData.ClassificationFieldValue2);");

            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.Append("\r\n" + "if (objOrderByData.KeyIdLst.Length == 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"���ݹؼ����б�����ʱ,�����Ĺؼ���ֵ�б��JSON������Ϊ��!({0})\", clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + "}");
            if (objKeyField.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "List<string> lst{0} = new(objOrderByData.KeyIdLst);", objKeyField.FldName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "List<string> lst{0}_T = new(objOrderByData.KeyIdLst);", objKeyField.FldName);
                strBuilder.AppendFormat("\r\n" + "List<{0}> lst{1} = lst{1}_T.Select(x=>{0}.Parse(x)).ToList();",
                objKeyField.CsType,
                objKeyField.FldName);
            }
            strBuilder.AppendFormat("\r\n" + "lst{0}.Reverse();", objKeyField.FldName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "foreach(var x in lst{0})", objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            if (objAdjustOrderNum.arrFieldLst_Classify.Count() > 0)
            {
                strBuilder.Append("\r\n" + "JObject jobjOrderByData = JObject.Parse(objOrderByData.ClassificationFieldValueLst);");

                foreach (clsTabFeatureFldsEN objInFor in objAdjustOrderNum.arrFieldLst_Classify)
                {
                    string strTemp = clsPubFun4GC.Gene_GetKeyData(objInFor);
                    strBuilder.Append("\r\n" + strTemp);
                }
                strBuilder.AppendFormat("\r\n" + "cls{0}BL.AdjustOrderNum(\"DOWN\", x, {1});",
                  objPrjTabENEx.TabName, objAdjustOrderNum.VarLst);
            }
            else
            {

                strBuilder.AppendFormat("\r\n" + "cls{0}BL.AdjustOrderNum(\"DOWN\", x);",
                 objPrjTabENEx.TabName, objKeyField.FldName);
            }
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 0, errorMsg = \"\", returnBool = true });");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "return clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_UpdateRelation(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ͨ��JSON�������޸ļ�¼����");
            strBuilder.AppendFormat("\r\n /// ���÷���: Post /api/{0}Api/{1}",
            objPrjTabENEx.TabName,
            clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code));
            strBuilder.AppendFormat("\r\n /// ��Body������obj{0}EN��JSON����", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"str{0}JSONObj\">JSON�����ַ���</param>",
              objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>�Ƿ�ɹ�</returns>");
            strBuilder.Append("\r\n" + "[HttpPost]");
            strBuilder.AppendFormat("\r\n" + "public ActionResult UpdateRelation([FromBody]cls{0}EN obj{0}EN)",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");

            strBuilder.AppendFormat("\r\n" + "string str{0}JSONObj = clsJSON.GetJsonFromObj(obj{0}EN);",
                      objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"str{0}JSONObj\", str{0}JSONObj);",
                      objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            if (IsNumberType4Key == true)
            {
                strBuilder.AppendFormat("\r\n" + " if (obj{0}EN.{1} <= 0)",
                        objPrjTabENEx.TabName, objKeyField.FldName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true)",
                  objPrjTabENEx.TabName, objKeyField.FldName);
            }
            strBuilder.Append("\r\n" + " {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"�޸ļ�¼ʱ,�ؼ��ֲ���Ϊ��!({0})\", clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + " }");

            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n" + "    cls{0}BL.SetUpdFlag(obj{0}EN);",
                    objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}EN.UpdateRelation();",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 0, errorMsg = \"\", returnBool = bolResult });");

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "return clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_UpdateBySql_XML(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// ����:ͨ��SQL�������޸ļ�¼,�÷�ʽ�ṩXML��������ʵ�����");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// ���÷���: GET /api/{0}Api/{1}?{2}",
              objPrjTabENEx.TabName,
              clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code),
              strQueryString4ParaLst);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"str{0}ObjXml\">��Ҫ�޸ĵĶ���,��XML����ʾ</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>����޸ĳɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strBuilder.Append("\r\n" + "[HttpGet]");
            strBuilder.AppendFormat("\r\n" + "public ActionResult UpdateBySql_XML(string str{0}ObjXml)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"str{0}ObjXml\", str{0}ObjXml);",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}BL.UpdateBySql_XML(str{0}ObjXml);",
                    objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 0, errorMsg = \"\", returnBool = bolResult });");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_DelRelation(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:ɾ���ؼ�����ָ���ļ�¼");
            strBuilder.AppendFormat("\r\n /// ���÷���: DELETE /api/{0}Api/{1}/Id",
                objPrjTabENEx.TabName,
                clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code));

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"Id\">�����Ĺؼ���ֵ</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <returns>����ɾ���ļ�¼��</returns>");
            strBuilder.Append("\r\n" + "[HttpDelete]");
            strBuilder.AppendFormat("\r\n" + "public ActionResult DelRelation({1} Id)",
            objPrjTabENEx.TabName, objPrjTabENEx.objKeyField0.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0} {1} = Id;",
                objPrjTabENEx.objKeyField0.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                 objPrjTabENEx.objKeyField0.ObjFieldTabENEx.PrivFuncName);

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == false)
            {
                strBuilder.AppendFormat("\r\n" + "[\"{0}\"] = {0}.ToString()", objKeyField.PrivFuncName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "[\"{0}\"] = {0}", objKeyField.PrivFuncName);
            }
            strBuilder.Append("\r\n };");


            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            if (IsNumberType4Key == true)
            {
                strBuilder.AppendFormat("\r\n" + " if ({0} <= 0)",
                        objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty({0}) == true)",
                      objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            }
            strBuilder.Append("\r\n" + " {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"ɾ���ؼ�����ָ���ļ�¼,�ؼ��ֲ���Ϊ��!({0})\", clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n" + "int intRecNum = cls{0}BL.DelRelation({1});",
            objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            strBuilder.Append("\r\n" + "return Json(new { errorId = 0, errorMsg = \"\", returnInt = intRecNum });");

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            //strBuilder.Append("\r\n" + "return 0;");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_DelRelationBySP(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:ɾ���ؼ�����ָ���ļ�¼,ͨ���洢����(SP)��ɾ����");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// ���÷���: GET /api/{0}Api/{1}?{2}",
              objPrjTabENEx.TabName,
              clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code),
              strQueryString4ParaLst);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���ֵ</param>", objKeyField.PrivFuncName);
            strBuilder.Append("\r\n /// <returns>���ɾ���ɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strBuilder.Append("\r\n" + "[HttpGet]");
            strBuilder.AppendFormat("\r\n" + "public ActionResult DelRelationBySP({1})",
            objPrjTabENEx.TabName, objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"{0}\", {0});",
                      objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.AppendFormat("\r\n" + "bool bolResult = cls{0}BL.DelRelationBySP({1});",
            objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            //strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 0, errorMsg = \"\", returnBool = bolResult });");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        /// <summary>
        /// ɾ��������¼
        /// </summary>
        /// <returns></returns>
        public string Gen_DelMultiRelation(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:ͬʱɾ��������¼,ɾ�������ؼ����б�ļ�¼");
            strBuilder.AppendFormat("\r\n /// ���÷���: POST /api/{0}Api/{1}",
             objPrjTabENEx.TabName,
            TransKeyWords4FuncName(clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code)));
            strBuilder.AppendFormat("\r\n /// ��Body������arr{0}(�ؼ���ֵ�б�)��JSON��", objKeyField.FldName);

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"arr{0}\">�����Ĺؼ���ֵ�б�</param>", objKeyField.FldName);
            strBuilder.Append("\r\n /// <returns>����ɾ���ļ�¼��</returns>");
            strBuilder.Append("\r\n" + "[HttpPost]");
            strBuilder.AppendFormat("\r\n" + "public ActionResult Del{0}s([FromBody]string[] arr{1})",
                 objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.AppendFormat("\r\n" + "List<string> arrLst = new(arr{0});", objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"arr{0}\", clsArray.GetSqlInStrByArray(arrLst, true));", objKeyField.FldName);
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");

            strBuilder.AppendFormat("\r\n" + "int intRecNum = cls{0}BL.Del{0}s(arrLst);",
                 objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "return Json(new { errorId = 0, errorMsg = \"\", returnInt = intRecNum });");

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            //strBuilder.Append("\r\n" + "return 0;");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// ɾ��������¼
        /// </summary>
        /// <returns></returns>
        public string Gen_DelRelations(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:ͬʱɾ��������¼,ɾ�������ؼ����б�ļ�¼, ͨ��JSON��");
            strBuilder.AppendFormat("\r\n /// ���÷���: POST /api/{0}Api/{1}",
             objPrjTabENEx.TabName,
             clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code));
            strBuilder.AppendFormat("\r\n /// ��Body������strKeyIdLst�ַ����б��JSON��", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"strKeyIdLst\">�����Ĺؼ���ֵ�б��JSON��</param>", objKeyField.FldName);
            strBuilder.Append("\r\n /// <returns>����ɾ���ļ�¼��</returns>");
            strBuilder.Append("\r\n" + "[HttpPost]");
            strBuilder.AppendFormat("\r\n" + "public ActionResult DelRelations([FromBody]string strKeyIdLst)",
                 objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"strKeyIdLst\", strKeyIdLst);",
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.Append("\r\n" + " if (string.IsNullOrEmpty(strKeyIdLst) == true)");

            strBuilder.Append("\r\n" + " {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"���ݹؼ����б�ɾ����¼ʱ,�����Ĺؼ���ֵ�б��JSON������Ϊ��!({0})\", clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");

            strBuilder.Append("\r\n" + " }");

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
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
           
                strBuilder.AppendFormat("\r\n" + "int intRecNum = cls{0}BL.Del{0}s(arr{1});",
            objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "return Json(new { errorId = 0, errorMsg = \"\", returnInt = intRecNum });");

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            //strBuilder.Append("\r\n" + "return 0;");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// ɾ��������¼
        /// </summary>
        /// <returns></returns>
        public string Gen_DelMultiRelationByCond(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
            
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����:ɾ�����������Ķ�����¼");
            strBuilder.AppendFormat("\r\n /// ���÷���: POST /api/{0}Api/Del{0}sByCond",
             objPrjTabENEx.TabName,
             clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code));
            strBuilder.AppendFormat("\r\n /// ��Body������{{\"strWhereCond\":\"1=1\"}}", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">��Ҫɾ���ļ�¼����</param>");
            strBuilder.Append("\r\n /// <returns>����ɾ���ļ�¼����</returns>");
            strBuilder.Append("\r\n" + "[HttpPost]");
           
                strBuilder.AppendFormat("\r\n" + "public ActionResult Del{0}sByCond([FromBody]string strWhereCond)",
            objPrjTabENEx.TabName);
           
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");

            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.Append("\r\n" + " if (string.IsNullOrEmpty(strWhereCond) == true)");
            strBuilder.Append("\r\n" + " {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"ɾ�����������Ķ�����¼,��������Ϊ��!({0})\", clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
           
                strBuilder.AppendFormat("\r\n" + "int intRecNum = cls{0}BL.Del{0}sByCond(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return Json(new { errorId = 0, errorMsg = \"\", returnInt = intRecNum });");

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            //strBuilder.Append("\r\n" + "return 0;");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n" + "}");
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
                    strBuilder.AppendFormat("\r\nif (new cls{0}BL.IsExistRelation(sbCondition.ToString()) == true)",
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
            strBuilder.Append("\r\n /// �������ֶ�ֵ�Ƿ�Ϸ�,1)����Ƿ�ɿ�;2)����ֶ�ֵ�����Ƿ񳬳�,���������׳�����.");
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


        /// <summary>
        /// ���ɴ���:�ṩ����,��ѯ�ؼ���,����ж���ؼ���,��ȡ���еĵ�һ��,���������Ǹ����ֶα��������
        /// </summary>
        /// <returns></returns>
        public string Gen_GetFirstID(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            /// GetID(����������ȡ�ؼ��ֵ�����);
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡ��ǰ�����������ĵ�һ����¼�Ĺؼ���ֵ");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// ���÷���: GET /api/{0}Api/{1}?{2}",
              objPrjTabENEx.TabName,
              clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code),
              strQueryString4ParaLst);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <returns>���صĵ�һ����¼�Ĺؼ���ֵ</returns>");
            strBuilder.Append("\r\n" + "[HttpGet]");
            strBuilder.AppendFormat("\r\npublic {0} GetFirstID(string strWhereCond) ", objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");

            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.Append("\r\n" + " if (string.IsNullOrEmpty(strWhereCond) == true)");
            strBuilder.Append("\r\n" + " {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"����������ȡ��һ����¼�Ĺؼ���ֵʱ,��������Ϊ��!({0})\", clsStackTrace.GetCurrClassFunction());");

            strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");

            strBuilder.Append("\r\n" + " }");
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
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            if (IsNumberType4Key == true)
            {
                strBuilder.Append("\r\n return 0;");
            }
            else
            {
                strBuilder.Append("\r\n return \"\";");
            }
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n}");
            ///GetReader(����������ȡ����Reader);
            return strBuilder.ToString();
        }

        /// <summary>
        /// ���ɴ���:�ṩ����,��ѯ��ؼ�¼����,����ж������,��ȡ���еĵ�һ��,����������������
        /// </summary>
        /// <returns></returns>
        public string Gen_GetFirstObj(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            /// GetID(����������ȡ�ؼ��ֵ�����);
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡ��ǰ�����������ĵ�һ����¼�Ķ���");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// ���÷���: GET /api/{0}Api/{1}?{2}",
              objPrjTabENEx.TabName,
              clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code),
              strQueryString4ParaLst);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <returns>���صĵ�һ����¼�Ķ���</returns>");
            strBuilder.Append("\r\n" + "[HttpGet]");
            strBuilder.AppendFormat("\r\npublic ActionResult GetFirstObj(string strWhereCond) ", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n" + "strWhereCond = strWhereCond.Replace(\"'% \", \"'%\");");
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");

            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.Append("\r\n" + " if (string.IsNullOrEmpty(strWhereCond) == true)");
            strBuilder.Append("\r\n" + " {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"����������ȡ��һ������ʱ,��������Ϊ��!({0})\", clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");

            strBuilder.AppendFormat("\r\n cls{0}EN obj{0}EN = cls{0}BL.GetFirstObj_S(strWhereCond);",
            objPrjTabENEx.TabName);

            //strBuilder.AppendFormat("\r\n return obj{0}EN;", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "return Json(new {{ errorId = 0, errorMsg = \"\", returnObj = obj{0}EN }});", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            //strBuilder.Append("\r\n" + "return null;");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");

            strBuilder.Append("\r\n}");
            ///GetReader(����������ȡ����Reader);
            return strBuilder.ToString();
        }

        /// <summary>
        /// ���ɴ���:����������ȡJSON�����б�
        /// </summary>
        /// <returns></returns>
        public string Gen_GetObjLstByPager(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ҳ��ȡJSON�����б�");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// ���÷���: GET /api/{0}Api/{1}?{2}",
              objPrjTabENEx.TabName,
              clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code),
              strQueryString4ParaLst);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"objPagerPara\">��ҳ��ȡ��¼�Ĳ�������</param>");
            strBuilder.Append("\r\n /// <returns>����JSON�����б�</returns>");
            strBuilder.Append("\r\n [HttpPost]");
            strBuilder.AppendFormat("\r\n public ActionResult GetObjLstByPager([FromBody]stuPagerPara objPagerPara)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");

            //strBuilder.Append("\r\n" + "objPagerPara.whereCond = objPagerPara.whereCond.Replace(\"'% \", \"'%\");");
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = objPagerPara.GetDictParam();");
      
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            //strBuilder.Append("\r\n" + " if (string.IsNullOrEmpty(objPagerPara.whereCond) == true)");
            //strBuilder.Append("\r\n" + " {");
            //strBuilder.Append("\r\n" + "string strMsg = string.Format(\"����������ҳ��ȡJSON�����б�,��������Ϊ��!({0})\", clsStackTrace.GetCurrClassFunction());");
            ////strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            //strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            //strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n" + " if (objPagerPara.pageSize <=0)");
            strBuilder.Append("\r\n" + " {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"����������ҳ��ȡJSON�����б�,ÿҳ��¼��:[{0}]����С�ڵ���0!({1})\", objPagerPara.pageSize, clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n" + " if (objPagerPara.pageIndex <=0)");
            strBuilder.Append("\r\n" + " {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"����������ҳ��ȡJSON�����б�,ҳ���:[{0}]����С�ڵ���0!({1})\", objPagerPara.pageIndex, clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + " }");

            strBuilder.AppendFormat("\r\n IEnumerable<cls{0}EN> arr{0}ObjLst;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n arr{0}ObjLst = cls{0}BL.GetObjLstByPager(objPagerPara);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");

            //strBuilder.AppendFormat("\r\n return arr{0}ObjLst;", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "return Json(new {{ errorId = 0, errorMsg = \"\", returnObjLst = arr{0}ObjLst }});", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n }");

            return strBuilder.ToString();
        }

        /// <summary>
        /// ���ɴ���:����������ȡJSON�����б�
        /// </summary>
        /// <returns></returns>
        public string Gen_GetObjLstByRange(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��Χ�ڵĶ����б�");
            string strQueryString4ParaLst = clsFuncPara4CodeBLEx.GC_GetQueryStringLst4FuncPara(objFunction4GeneCodeEN.FuncId4Code);
            strBuilder.AppendFormat("\r\n /// ���÷���: GET /api/{0}Api/{1}?{2}",
              objPrjTabENEx.TabName,
              clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code),
              strQueryString4ParaLst);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"objRangePara\">���ݷ�Χ��ȡ��¼�Ĳ�������</param>");
 
            strBuilder.Append("\r\n /// <returns>���ض����б�</returns>");
            strBuilder.Append("\r\n [HttpPost]");
            strBuilder.AppendFormat("\r\n public ActionResult GetObjLstByRange([FromBody]stuRangePara objRangePara)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n {");
            
            strBuilder.Append("\r\n" + "objRangePara.whereCond = objRangePara.whereCond.Replace(\"'% \", \"'%\");");
            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = objRangePara.GetDictParam();");
     
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");

            strBuilder.Append("\r\n" + " if (string.IsNullOrEmpty(objRangePara.whereCond) == true)");
            strBuilder.Append("\r\n" + " {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"����������ȡ��Χ�ڵĶ����б�,��������Ϊ��!({0})\", clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n" + " if (objRangePara.minNum <0)");
            strBuilder.Append("\r\n" + " {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"����������ҳ��ȡJSON�����б�,��С��¼��:[{0}]����С��0!({1})\", objRangePara.minNum, clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n" + " if (objRangePara.maxNum <0)");
            strBuilder.Append("\r\n" + " {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"����������ҳ��ȡJSON�����б�,����¼��:[{0}]����С��0!({1})\", objRangePara.maxNum, clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n" + " if (objRangePara.maxNum <= objRangePara.minNum)");
            strBuilder.Append("\r\n" + " {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"����������ҳ��ȡJSON�����б�,����¼��:[{0}]����С�ڵ�����С��¼��:[{1}]!({2})\", objRangePara.maxNum, objRangePara.minNum, clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + " }");
            strBuilder.AppendFormat("\r\n List<cls{0}EN> arr{0}ObjLst;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n try");
            strBuilder.Append("\r\n {");
            strBuilder.AppendFormat("\r\n arr{0}ObjLst = cls{0}BL.GetObjLstByRange(objRangePara);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n }");
            strBuilder.Append("\r\n catch (Exception objException)");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n }");

            //strBuilder.AppendFormat("\r\n return arr{0}ObjLst;", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "return Json(new {{ errorId = 0, errorMsg = \"\", returnObjLst = arr{0}ObjLst }});", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n }");

            return strBuilder.ToString();
        }

        public string Gen_UpdateWithCondition(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �����������޸ļ�¼����");
            strBuilder.AppendFormat("\r\n /// ���÷���: Post /api/{0}Api/{1}",
            objPrjTabENEx.TabName,
            clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code));
            strBuilder.AppendFormat("\r\n /// ��Body������obj{0}EN��JSON�����strWhereCond������", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"str{0}JSONObj\">JSON�����ַ���</param>",
              objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <param name = \"strWhereCond\">����</param>",
              objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>�Ƿ�ɹ�</returns>");
            strBuilder.Append("\r\n" + "[HttpPost]");
            strBuilder.AppendFormat("\r\n" + "public ActionResult UpdateWithCondition(cls{0}EN obj{0}EN, string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + " if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "   clsPubVar_WebApi.objLog.WriteDebugLog(\"clsSysParaEN.strTempXMLFileNameΪ��,����!\");");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n" + " else");
            strBuilder.Append("\r\n" + " {");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.Append("\r\n" + " }");

            strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(strWhereCond) == true)");

            strBuilder.Append("\r\n" + " {");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"���������޸ļ�¼ʱ,��������Ϊ��!({0})\", clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");

            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}EN.UpdateWithCondition(strWhereCond);",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 0, errorMsg = \"\", returnBool = bolResult });");


            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "return clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_AddNewRelationWithReturnKey(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            if (objKeyField.PrimaryTypeId != "02") return "";
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �ѱ������ӵ����ݿ���,���ҷ��ظü�¼�Ĺؼ���(���Identity�ؼ���)");
            strBuilder.AppendFormat("\r\n /// ���÷���: POST /api/{0}Api/{1}",
              objPrjTabENEx.TabName,
              clsFunction4CodeBL.GetNameByFuncId4CodeCache(objFunction4GeneCodeEN.FuncId4Code));
            strBuilder.AppendFormat("\r\n /// ��Body������obj{0}EN��JSON����", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵı����</param>",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>��������Ӽ�¼�Ĺؼ���</returns>");

            strBuilder.Append("\r\n" + "[HttpPost]");
            strBuilder.AppendFormat("\r\n" + "public ActionResult AddNewRelationWithReturnKey(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + " if (string.IsNullOrEmpty(clsSysParaEN.strTempXMLFileName) == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "   clsPubVar_WebApi.objLog.WriteDebugLog(\"clsSysParaEN.strTempXMLFileNameΪ��,����!\");");
            strBuilder.Append("\r\n" + " }");
            strBuilder.Append("\r\n" + " else");
            strBuilder.Append("\r\n" + " {");

            strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"obj{0}EN\", cls{0}BL.SerializeObjToXMLStr(obj{0}EN));", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
            strBuilder.Append("\r\n" + " }");


            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strKey = cls{0}BL.AddNewRelationBySql2WithReturnKey(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return Json(new { errorId = 0, errorMsg = \"\", returnStr =  strKey });");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
            //            strBuilder.Append("\r\n return \"\";");
            strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");

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
            StringBuilder strBuilder = new StringBuilder(); ///���������WebForm��ص����ļ�����;
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
                    strBuilder.Append("\r\n" + strTemp);
                }

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����������Ϣ:{1}.({2})", strFuncName,
                    objException.Message,
                    clsStackTrace.GetCurrClassFunction());
                clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
            return strBuilder.ToString();
        }

        public override void GetClsName()
        {
            this.ClsName = string.Format("{0}ApiController", objPrjTabENEx.TabName);
            objPrjTabENEx.ClsName = this.ClsName;
        }

        public string Gen_4WA_ByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            //            string[] sstrParaLst = objWebSrvFunctionsENEx.FuncParaLst.Split('|');
            //List<clsvWebSrvFuncParaEN> arrvWebSrvFuncParaObjLst =
            //    clsvWebSrvFuncParaBLEx.GetvWebSrvFuncParaObjLstByFuncId(objWebSrvFunctionsENEx.WebSrvFunctionId);
            string strMsg = "";
            clsDataTypeAbbrEN objFuncReturnTypeEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objWebSrvFunctionsENEx.ReturnTypeId);
            clsSelfDefDataTypeEN objSelfDefDataTypeEN = null;
            if (objFuncReturnTypeEN == null)
            {
                objSelfDefDataTypeEN = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objWebSrvFunctionsENEx.ReturnType);
                if (objSelfDefDataTypeEN == null)
                {
                    strMsg = string.Format("�����ķ������ͣ�[{0}({1})]û�д���,����������Ӧ���롣", objWebSrvFunctionsENEx.ReturnTypeId, objWebSrvFunctionsENEx.ReturnType);
                    throw new Exception(strMsg);
                }
            }
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// {0}", objWebSrvFunctionsENEx.FunctionName);
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            StringBuilder sbParaList = new StringBuilder();
            StringBuilder sbParaVarList = new StringBuilder();

            foreach (clsWebSrvFuncParaEN objWebSrvFuncParaEN in objWebSrvFunctionsENEx.arrWebSrvFuncParaObjLst)
            {
                clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objWebSrvFuncParaEN.DataTypeId);
                clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;
                if (objDataTypeAbbrEN == null)
                {
                    objSelfDefDataTypeEN_Para = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objWebSrvFuncParaEN.ParameterType);
                    if (objSelfDefDataTypeEN_Para == null)
                    {
                        strMsg = string.Format("�����������������ͣ�[{0}({1})]û�д���,����������Ӧ���롣", objDataTypeAbbrEN.DataTypeId,
                            objWebSrvFuncParaEN.ParameterType);
                        throw new Exception(strMsg);
                    }
                }
                if (objWebSrvFuncParaEN.IsByRef == true)
                {
                    strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">�����Ͳ���,����:{1}</param>",
                        objWebSrvFuncParaEN.ParaName, objWebSrvFuncParaEN.ParaCnName);
                    if (objSelfDefDataTypeEN_Para != null)
                    {
                        sbParaList.AppendFormat("ref {0} {1},", objSelfDefDataTypeEN_Para.CsType,
                            objWebSrvFuncParaEN.ParaName);
                    }
                    else
                    {
                        sbParaList.AppendFormat("ref {0} {1},", objDataTypeAbbrEN.CsType, objWebSrvFuncParaEN.ParaName);
                    }
                    sbParaVarList.AppendFormat("ref {0},", objWebSrvFuncParaEN.ParaName);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">{1}</param>",
                        objWebSrvFuncParaEN.ParaName, objWebSrvFuncParaEN.ParaCnName);
                    if (objSelfDefDataTypeEN_Para != null)
                    {
                        sbParaList.AppendFormat("{0} {1},",
                            objSelfDefDataTypeEN_Para.CsType,
                            objWebSrvFuncParaEN.ParaName);
                    }
                    else
                    {
                        sbParaList.AppendFormat("{0} {1},",
                            objDataTypeAbbrEN.CsType,
                            objWebSrvFuncParaEN.ParaName);
                    }
                    sbParaVarList.AppendFormat("{0},", objWebSrvFuncParaEN.ParaName);
                }
            }
            if (sbParaList.Length > 0)
            {
                sbParaList.Remove(sbParaList.Length - 1, 1);
                sbParaVarList.Remove(sbParaVarList.Length - 1, 1);
            }
            strBuilder.AppendFormat("\r\n /// <returns>����{0}</returns>",
                objWebSrvFunctionsENEx.ReturnValueDescription);
            if (objSelfDefDataTypeEN != null)
            {
                strBuilder.AppendFormat("\r\n" + "public static {0} {1}({2})",
                        objSelfDefDataTypeEN.CsType, objWebSrvFunctionsENEx.FunctionName,
                        sbParaList.ToString());
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "public static {0} {1}({2})",
                            objFuncReturnTypeEN.CsType, objWebSrvFunctionsENEx.FunctionName,
                            sbParaList.ToString());
            }
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}SoapClient obj{0}Service = Get{0}SoapClient();",
                    objWebSrvClassENEx.ClsName);
            //strBuilder.Append("\r\n" + "DataSet objDS;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            if (objSelfDefDataTypeEN != null)
            {
                strBuilder.AppendFormat("\r\n" + "{0} {1} = obj{2}Service.{3}({4});",
                     objSelfDefDataTypeEN.CsType,
                     objSelfDefDataTypeEN.DefaVarName,
                     objWebSrvClassENEx.ClsName,
                     objWebSrvFunctionsENEx.FunctionName,
                     sbParaVarList.ToString());
                strBuilder.AppendFormat("\r\n" + "return {0};", objSelfDefDataTypeEN.DefaVarName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "{0} {1}Temp = obj{2}Service.{3}({4});",
                    objFuncReturnTypeEN.CsType,
                    objFuncReturnTypeEN.DataTypeAbbr,
                    objWebSrvClassENEx.ClsName,
                    objWebSrvFunctionsENEx.FunctionName,
                    sbParaVarList.ToString());
                strBuilder.AppendFormat("\r\n" + "return {0}Temp;", objFuncReturnTypeEN.DataTypeAbbr);
            }
            //strBuilder.Append("\r\n" + "DataTable objDT = objDS.Tables[0];");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n string strMsg = string.Format(\"ִ��WebApi���ܳ���, {0}.(from {1}). WebApi��ַ:{2}).\",");
            strBuilder.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strBuilder.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strBuilder.AppendFormat("\r\n throw new Exception(strMsg);");

            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

    }
}
