using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AGC.PureClassEx;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commexception;
using com.taishsoft.common;
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
    partial class NodeWA_Access4CSharp : clsGeneCodeBase
    {
        private string strKeyFldName_ObjName = "";

        #region ���캯��

        public NodeWA_Access4CSharp()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }
        public NodeWA_Access4CSharp(string strPrjId)
          : base(strPrjId)
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }
        public NodeWA_Access4CSharp(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
          : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }
        #endregion

        

        /// <summary>
        /// ����Web Serviceת�������
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
            string strResult = "";
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
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
                objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId);


            objPrjTabENEx.ClsName = string.Format("cls{0}WApi", objPrjTabENEx.TabName);
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebApiTransferLevel;

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

                //������ʼ

                strBuilder.Append("\r\n" + "using System;"); //
                strBuilder.Append("\r\n" + "using System.Data; "); //
                strBuilder.Append("\r\n" + "using System.Data.SqlClient;");
                strBuilder.Append("\r\n" + "using System.Text; "); //
                strBuilder.Append("\r\n" + "using System.Web;"); //
                strBuilder.Append("\r\n" + "using System.Collections; "); //
                strBuilder.Append("\r\n" + "using System.Collections.Generic;"); //
                strBuilder.Append("\r\n" + "using System.ComponentModel;"); //
                strBuilder.Append("\r\n" + "using System.Linq;"); //
                strBuilder.Append("\r\n" + "using System.Reflection;"); //

                strBuilder.AppendFormat("\r\n" + "using Newtonsoft.Json;"); //
                strBuilder.AppendFormat("\r\n" + "using Newtonsoft.Json.Linq; using Comm.WebApi;"); //
                                                                                 // strBuilder.AppendFormat("\r\n" + "using {1}4WS.ServiceReference{0};", objPrjTabENEx.TabName, objProject.PrjDomain); //

                strBuilder.Append("\r\n" + "using com.taishsoft.common;"); //
                strBuilder.Append("\r\n" + "using com.taishsoft.comm_db_obj;"); //
                strBuilder.Append("\r\n" + "using com.taishsoft.dynamiccompiler;"); //
                strBuilder.Append("\r\n" + "using com.taishsoft.json;"); //
                //strBuilder.Append("\r\n" + "using System.ServiceModel;"); //
                strBuilder.AppendFormat("\r\n" + "using {0}.Entity;", objProjectsENEx.PrjDomain);

           
                //strBuilder.AppendFormat("\r\n" + "using {0}.BusinessLogic;", objProjectsENEx.PrjDomain);


                strBuilder.Append("\r\n" + ""); //
                                                //if (objPrjTabENEx.IsForSilverLight == true)
                                                //{
                                                //    strBuilder.AppendFormat("\r\n" + "namespace SL4WS",
                                                //    objProject.PrjDomain);
                                                //}
                                                //else
                                                //{
                strBuilder.AppendFormat("\r\n" + "namespace {0}4WApi",
                objProject.PrjDomain);
                //}
                strBuilder.Append("\r\n" + "{");

                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_Static = arrvFunction4GeneCodeObjLst.Where(x => x.FuncTypeId == enumFunctionType.PureStaticFunction_12);
                if (arrvFunction4GeneCodeObjLst_Static.Count() > 0)
                {
                    strBuilder.AppendFormat("\r\n" + "public static class  {0}_Static", objPrjTabENEx.ClsName);
                    strBuilder.Append("\r\n" + "{");
                    foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst_Static)
                    {
                        //clsFunction4GeneCodeEN objFunction4GeneCodeEN1 = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
                        strFuncName = objvFunction4GeneCodeEN.FuncName;

                        if (strFuncName.Substring(0, 6) == "Print:")
                        {
                            strBuilder.Append("\r\n" + "");
                            strBuilder.Append("\r\n" + "");
                            strBuilder.Append("\r\n " + strFuncName.Substring(6));
                            continue;
                        }
                        try
                        {
                            objPrjTabENEx.FuncId4GC = objvFunction4GeneCodeEN.FuncId4GC;
                            if (objvFunction4GeneCodeEN.FuncTypeId == "10")//�û��Զ��庯��
                            {
                                strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objvFunction4GeneCodeEN.FuncId4GC,
                                    objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
                            }
                            else
                            {
                                strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
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
                        if (string.IsNullOrEmpty(strTemp) == false)
                        {
                            strBuilder.Append("\r\n" + strTemp);
                        }
                    }
                    strBuilder.Append("\r\n" + "}");

                }





                //clsvFunction4GeneCodeEN objvFunction4GeneCodeEN21 = clsvFunction4GeneCodeBLEx.GetObjByFuncNameCacheEx("Gen_4WA_GeneEnumConstList");
                strTemp = A_GeneFuncCodeByFuncName("Gen_4WA_GeneEnumConstList");
                strBuilder.Append(strTemp);
                //objvFunction4GeneCodeEN1 = clsvFunction4GeneCodeBLEx.GetObjByFuncNameCacheEx("Gen_4WA_GeneEnumConstList4Field");
                strTemp = A_GeneFuncCodeByFuncName("Gen_4WA_GeneEnumConstList4Field");
                strBuilder.Append(strTemp);

                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
                //if (objPrjTabENEx.IsForSilverLight == true)
                //{
                //    strBuilder.AppendFormat("\r\n /// For SilverLight");
                //}
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");

                strBuilder.Append("\r\n" + "public class " + objPrjTabENEx.ClsName);
                strBuilder.Append("\r\n" + "{");


                strBuilder.AppendFormat("\r\n" + "private static readonly string mstrApiControllerName = \"{0}Api\";",
                    objPrjTabENEx.TabName);
                //strBuilder.Append("\r\n" + "private static string mstrDir = \"0\";");

                //˽��������-----�����Թ���
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.Append("\r\n /// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "public static List<cls{0}EN> arr{0}ObjLstCache = null;",
                       objPrjTabENEx.TabName);

                strBuilder.AppendFormat("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// �ӻ����в���ʧ�ܵĴ���");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.AppendFormat("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "protected static int intFindFailCount = 0;");

                //˽��������-----�����Թ���
                //strBuilder.AppendFormat("\r\n" + "private static {0}ServiceSoapClient obj{0}ServiceSoapClient = null;",
                //objPrjTabENEx.TabName);
                //strBuilder.Append("\r\n /// <summary>");
                //strBuilder.Append("\r\n /// ");
                //strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                //strBuilder.Append("\r\n /// </summary>");
                //strBuilder.Append("\r\n /// <returns></returns>");
                //strBuilder.AppendFormat("\r\n" + "public static {0}ServiceSoapClient Get{0}ServiceSoapClient()",
                //objPrjTabENEx.TabName);
                //strBuilder.Append("\r\n" + "{");
                //strBuilder.AppendFormat("\r\n" + "if (obj{0}ServiceSoapClient == null)",
                //objPrjTabENEx.TabName);
                //strBuilder.Append("\r\n" + "{");
                //strBuilder.Append("\r\n" + "BasicHttpBinding binding = new BasicHttpBinding();");
                //strBuilder.AppendFormat("\r\n" + "binding.Name = \"{0}ServiceSoap\";",
                //objPrjTabENEx.TabName);
                //strBuilder.Append("\r\n" + "binding.CloseTimeout = new System.TimeSpan(6000);");
                //strBuilder.Append("\r\n" + "binding.MaxReceivedMessageSize = 2147483647;");
                ////                strBuilder.Append("\r\n" + "String strServiceUrl = String.Empty;");
                //strBuilder.Append("\r\n" + "string strServiceUrl = GetServiceUrl(mstrApiControllerName, ref mstrDir);");
                ////strBuilder.Append("\r\n" + "if (clsSysPara4WebApi.bolIsLocalHost == false)");
                ////strBuilder.Append("\r\n" + "{");
                ////strBuilder.AppendFormat("\r\n" + "strServiceUrl = String.Format(\"http://{{0}}/{{1}}/{2}Service.asmx\", clsSysPara4WebApi.strCurrIPAddressAndPort, clsSysPara4WebApi.strCurrPrx);",
                ////"{", "}", objPrjTabENEx.TabName);
                ////strBuilder.Append("\r\n" + "}");
                ////strBuilder.Append("\r\n" + "else");
                ////strBuilder.Append("\r\n" + "{");
                ////strBuilder.AppendFormat("\r\n" + "strServiceUrl = String.Format(\"http://{{0}}/{2}Service.asmx\", clsSysPara4WebApi.strCurrIPAddressAndPort_Local);",
                ////"{", "}", objPrjTabENEx.TabName);
                ////strBuilder.Append("\r\n" + "}");

                //strBuilder.Append("\r\n" + "EndpointAddress address = new EndpointAddress(strServiceUrl);");

                //strBuilder.AppendFormat("\r\n" + "return new {0}ServiceSoapClient(binding, address);",
                //objPrjTabENEx.TabName);
                //strBuilder.Append("\r\n" + "}");
                //strBuilder.Append("\r\n" + "else");
                //strBuilder.Append("\r\n" + "{");
                //strBuilder.AppendFormat("\r\n" + "return obj{0}ServiceSoapClient;",
                //objPrjTabENEx.TabName);
                //strBuilder.Append("\r\n" + "}");
                //strBuilder.Append("\r\n" + "}");
                //�������еĺ���

                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_NotStatic = arrvFunction4GeneCodeObjLst.Where(x => x.FuncTypeId != enumFunctionType.PureStaticFunction_12);

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst_NotStatic)
                {
                    clsFunction4GeneCodeEN objFunction4GeneCodeEN1 = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

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
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objWebSrvClassENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
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
                Type t = typeof(NodeWA_Access4CSharp);
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


        public string Gen_4WA_ClassConstructor1()
        {
            StringBuilder strBuilder = new StringBuilder();

            ///�๹����----------------------------------------------;
            strBuilder.Append("\r\n public " + objPrjTabENEx.ClsName + "()");
            strBuilder.Append("\r\n {");

            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }

        public string Gen_4WA_CheckPropertyNew()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///������������Ƿ���ȷ-------------------------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �������ֶ�ֵ�Ƿ�Ϸ�,1)����Ƿ�ɿ�;2)����ֶ�ֵ�����Ƿ񳬳�,���������׳�����.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\npublic static void CheckPropertyNew(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);

                if (objField.IsTabNullable = false && objField.FieldTypeId != "02")
                {
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte[]" || objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte")
                    {
                        continue;
                    }
                    strBuilder.AppendFormat("\r\nif (Object.Equals(null, {0}) ",
                        strPrivPropNameWithObjectName);
                    strBuilder.AppendFormat("\r\n|| (!Object.Equals(null, {0}) && {0}.ToString() == \"\")",
                         strPrivPropNameWithObjectName);

                    if (string.IsNullOrEmpty(objField.ObjFieldTab4CodeConv().CodeTabId) != true)
                    {
                        strBuilder.AppendFormat("\r\n|| (!Object.Equals(null, {0}) && {0}.ToString() == \"0\")",
                             strPrivPropNameWithObjectName);
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
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);

                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text" && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string" && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    strBuilder.AppendFormat("\r\nif (!Object.Equals(null, {0}) && GetStrLen({0}) > {1})",
                         strPrivPropNameWithObjectName,
                          objField.ObjFieldTabENEx.FldLength);
                    strBuilder.Append("\r\n{");
                    strBuilder.AppendFormat("\r\n throw new Exception(\"�ֶ�[{0}]�ĳ��Ȳ��ܳ���{1}!\");",
                    objField.ColCaption, objField.ObjFieldTabENEx.FldLength.ToString().Trim());
                    strBuilder.Append("\r\n}");
                }
            }
            strBuilder.AppendFormat("\r\n obj{0}EN._IsCheckProperty = true;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n }");
            ///������������Ƿ���ȷ == == ;
            return strBuilder.ToString();
        }

        /// <summary>");
        /// ����������ȡ���ݱ�,��DataTable��ʾ");
        /// </summary>");
        /// <param name = \"objPrjTabENEx\">�����</param>");
        /// <returns>������������һ����Χ��DataTable</returns>
        public string Gen_4WA_GetDataTable()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <returns>������������һ����Χ��DataTable</returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTable(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataSet objDS;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = obj{0}Service.GetDataSet(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataTable objDT = objDS.Tables[0];");
            strBuilder.Append("\r\n" + "return objDT;");
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

        /// <summary>;
        /// ���ݺ�������,������صķ���ת���㺯��;
        /// </summary>");
        /// <param name = \"objPrjTabENEx\">�����</param>;
        /// <returns>������������һ����Χ��DataTable</returns>
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
        /// <summary>");
        /// ����������ȡ���ݱ�,��DataTable��ʾ");
        /// </summary>");
        /// <param name = \"objPrjTabENEx\">�����</param>");
        /// <returns>������������һ����Χ��DataTable</returns>
        public string Gen_4WA_GetTopDataTable()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <returns>������������һ����Χ��DataTable</returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataSet objDS;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = obj{0}Service.GetTopDataSet(intTopSize, strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataTable objDT = objDS.Tables[0];");
            strBuilder.Append("\r\n" + "return objDT;");
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


        /// <summary>");
        /// ����������ȡһ����Χ�����ݱ�,��DataTable��ʾ");
        /// </summary>");
        /// <param name = \"objPrjTabENEx\">�����</param>");
        /// <returns>������������һ����Χ��DataTable</returns>
        public string Gen_4WA_GetDataTableByRange()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡһ����Χ�����ݱ�,��DataTable��ʾ");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strBuilder.Append("\r\n /// <returns>������������һ����Χ��DataTable</returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTableByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataSet objDS;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = obj{0}Service.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataTable objDT = objDS.Tables[0];");
            strBuilder.Append("\r\n" + "return objDT;");
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
        /// <summary>
        /// ��ȡ��View��DataTable
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_GetDataTableV()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡ����ͼ��DataTable");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>����ͼ��DataTable</returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTableV(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataSet objDS;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = obj{0}Service.GetDataSetV(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataTable objDT = objDS.Tables[0];");
            strBuilder.Append("\r\n" + "return objDT;");
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
        /// <summary>");
        /// ����������ȡһ����Χ�����ݱ�,��DataTable��ʾ");
        /// </summary>");
        /// <param name = \"objPrjTabENEx\">�����</param>");
        /// <returns>������������һ����Χ��DataTable</returns>
        public string Gen_4WA_GetDataTableVByRange()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡһ����Χ�����ݱ�,��DataTable��ʾ");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strBuilder.Append("\r\n /// <returns>������������һ����Χ��DataTable</returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTableVByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataSet objDS;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = obj{0}Service.GetDataSetVByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataTable objDT = objDS.Tables[0];");
            strBuilder.Append("\r\n" + "return objDT;");
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

        /// <summary>
        /// ��ȡ��View��DataTable
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_GetDataTableV2()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡ���������ı���ͼ��DataTable");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>����ͼ��DataTable</returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable Get{0}V(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataSet objDS;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = obj{0}Service.GetDataSetV(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataTable objDT = objDS.Tables[0];");
            strBuilder.Append("\r\n" + "return objDT;");
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

        /// <summary>");
        /// ����������ȡһ����Χ�����ݱ�,��DataTable��ʾ");
        /// </summary>");
        /// <param name = \"objPrjTabENEx\">�����</param>");
        /// <returns>������������һ����Χ��DataTable</returns>
        public string Gen_4WA_GetDataTableV2ByRange()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡһ����Χ�����ݱ�,��DataTable��ʾ");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strBuilder.Append("\r\n /// <returns>������������һ����Χ��DataTable</returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTableVByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataSet objDS;");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "objDS = obj{0}Service.GetDataSetVByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "DataTable objDT = objDS.Tables[0];");
            strBuilder.Append("\r\n" + "return objDT;");
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
        public string Gen_4WA_GetObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ�����б�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"obj{0}Cond\">������������������</param>");
            strBuilder.Append("\r\n /// <returns>���ض����б�</returns>");
            strBuilder.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLst(cls{0}EN obj{0}Cond)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n List<cls{0}EN> arrObjLst; ",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "string strAction = \"GetObjLst\";");
            
            
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strJson = clsJSON.GetJsonFromObj<cls{0}EN>(obj{0}Cond);", objPrjTabENEx.TabName);
            //if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)

                strBuilder.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "arrObjLst = clsJSON.GetObjLstFromJson<cls{0}EN>(strResult);",
            //     objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "return arrObjLst;");
            strBuilder.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strBuilder.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strJson = JsonConvert.SerializeObject(jobjReturn0[\"returnObjLst\"]);");

            strBuilder.AppendFormat("\r\n" + "arrObjLst = JsonConvert.DeserializeObject<List<cls{0}EN>>(strJson);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return arrObjLst;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");


            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else return null;");
         

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"��ȡ���������б����,{0}.(from {1})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strBuilder.ToString();
        }

        public string Gen_4WA_GetObjLstByKeyLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ���ݹؼ����б��ȡ�����б�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">��������</param>");
            strBuilder.Append("\r\n /// <returns>���ض����б�</returns>");
            strBuilder.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLstBy{1}Lst(List<{2}> arr{1})", 
                    objPrjTabENEx.TabName                ,
                    objKeyField.FldName_FstUcase,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objKeyField.PrivFuncName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n List<cls{0}EN> arrObjLst; ",
            objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "string strAction = \"GetObjLstBy{0}Lst\";",
                objKeyField.FldName_FstUcase);
            
            
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            //strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strJSON = clsJSON.GetJsonFromObjLst(arr{0});", objKeyField.FldName_FstUcase);
            strBuilder.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "arrObjLst = clsJSON.GetObjLstFromJson<cls{0}EN>(strResult);",
            //     objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "return arrObjLst;");
            strBuilder.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strBuilder.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strJson = JsonConvert.SerializeObject(jobjReturn0[\"returnObjLst\"]);");

            strBuilder.AppendFormat("\r\n" + "arrObjLst = JsonConvert.DeserializeObject<List<cls{0}EN>>(strJson);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return arrObjLst;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else return null;");


            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"���ݹؼ����б��ȡ�����б����,{0}.(from {1})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strBuilder.ToString();
        }


        public string Gen_4WA_GetTopObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ���������б�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"objTopPara\">��ȡ���������б�Ĳ�������</param>");     
            strBuilder.Append("\r\n /// <returns>���ض����б�</returns>");
            strBuilder.AppendFormat("\r\npublic static List<cls{0}EN> GetTopObjLst(stuTopPara objTopPara)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n List<cls{0}EN> arrObjLst; ",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "string strAction = \"GetTopObjLst\";");
            
            
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = objTopPara.GetDictParam();");
 
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strJSON = clsJSON.GetJsonFromObj<stuTopPara>(objTopPara);");
            strBuilder.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "arrObjLst = clsJSON.GetObjLstFromJson<cls{0}EN>(strResult);",
            //     objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "return arrObjLst;");
            strBuilder.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strBuilder.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strJson = JsonConvert.SerializeObject(jobjReturn0[\"returnObjLst\"]);");

            strBuilder.AppendFormat("\r\n" + "arrObjLst = JsonConvert.DeserializeObject<List<cls{0}EN>>(strJson);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return arrObjLst;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else return null;");


            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"����������ȡ���������б�,{0}.(from {1})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strBuilder.ToString();
        }

        public string Gen_4WA_GetServiceUrl()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡWeb����ĵ�ַ");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>���ص�ǰ�ļ���Web����ĵ�ַ</returns>");

            strBuilder.Append("\r\npublic static string GetServiceUrl(string strPageName, ref string strDir)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n" + "String strServiceUrl = String.Empty;");
            strBuilder.Append("\r\n" + "if (strDir == \"0\")");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strDir = clsDict_PageName_Dic.GetDir4PageName(strPageName);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "if (clsSysPara4WebApi.bolIsLocalHost == false)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (string.IsNullOrEmpty(strDir) == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strServiceUrl = String.Format(\"http://{0}/{1}/{2}\",");
            strBuilder.Append("\r\n" + "clsSysPara4WebApi.strCurrIPAddressAndPort, clsSysPara4WebApi.strCurrPrx, strPageName);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strServiceUrl = String.Format(\"http://{0}/{1}/{2}/{3}\",");
            strBuilder.Append("\r\n" + "clsSysPara4WebApi.strCurrIPAddressAndPort, clsSysPara4WebApi.strCurrPrx, strDir, strPageName);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (string.IsNullOrEmpty(strDir) == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strServiceUrl = String.Format(\"http://{0}/{1}\",");
            strBuilder.Append("\r\n" + "clsSysPara4WebApi.strCurrIPAddressAndPort_Local,");
            strBuilder.Append("\r\n" + "strPageName);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strServiceUrl = String.Format(\"http://{0}/{1}/{2}\",");
            strBuilder.Append("\r\n" + "clsSysPara4WebApi.strCurrIPAddressAndPort_Local, strDir, strPageName);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "return strServiceUrl;");
            strBuilder.Append("\r\n" + "}");

            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strBuilder.ToString();
        }
        public string Gen_4WA_GetWebApiUrl_SelfDefWS()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡWeb����ĵ�ַ");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>���ص�ǰ�ļ���Web����ĵ�ַ</returns>");

            strBuilder.Append("\r\npublic static string GetServiceUrl(string strApiControllerName, string strAction, ref string strDir)");
            strBuilder.Append("\r\n{");

            strBuilder.Append("\r\n" + "String strServiceUrl = String.Empty;");
            strBuilder.Append("\r\n" + "if (strDir == \"0\")");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strDir = clsDict_PageName_Dic.GetDir4PageName(strApiControllerName);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "if (clsSysPara4WebApi.bolIsLocalHost == false)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (string.IsNullOrEmpty(strDir) == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strServiceUrl = String.Format(\"http://{0}/api/{1}/{2}/{3}\",");
            strBuilder.Append("\r\n" + "clsSysPara4WebApi.strCurrIPAddressAndPort, clsSysPara4WebApi.strCurrPrx, strApiControllerName, strAction);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strServiceUrl = String.Format(\"http://{0}/api/{1}/{2}/{3}/{4}\",");
            strBuilder.Append("\r\n" + "clsSysPara4WebApi.strCurrIPAddressAndPort, clsSysPara4WebApi.strCurrPrx, strDir, strApiControllerName, strAction);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (string.IsNullOrEmpty(strDir) == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strServiceUrl = String.Format(\"http://{0}/api/{1}/{2}\",");
            strBuilder.Append("\r\n" + "clsSysPara4WebApi.strCurrIPAddressAndPort_Local,");
            strBuilder.Append("\r\n" + "strApiControllerName, strAction);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strServiceUrl = String.Format(\"http://{0}/api/{1}/{2}/{3}\",");
            strBuilder.Append("\r\n" + "clsSysPara4WebApi.strCurrIPAddressAndPort_Local, strDir, strApiControllerName, strAction);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "return strServiceUrl;");
            strBuilder.Append("\r\n" + "}");

            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strBuilder.ToString();
        }


        public string Gen_4WA_GetObjLstByRange()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��Χ�ڵĶ����б�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"objRangePara\">���ݷ�Χ��ȡ��¼�Ĳ�������</param>");

            strBuilder.Append("\r\n /// <returns>���ض����б�</returns>");
            strBuilder.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLstByRange(stuRangePara objRangePara)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n List<cls{0}EN> arrObjLst; ",
objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "string strAction = \"GetObjLstByRange\";");
            
            
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam =  objRangePara.GetDictParam();");
         
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strJSON = clsJSON.GetJsonFromObj<stuRangePara>(objRangePara);");
            strBuilder.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "arrObjLst = clsJSON.GetObjLstFromJson<cls{0}EN>(strResult);",
            //     objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "return arrObjLst;");
            strBuilder.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strBuilder.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strJson = JsonConvert.SerializeObject(jobjReturn0[\"returnObjLst\"]);");

            strBuilder.AppendFormat("\r\n" + "arrObjLst = JsonConvert.DeserializeObject<List<cls{0}EN>>(strJson);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return arrObjLst;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else return null;");


            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n string strMsg = string.Format(\"ִ��WebApi���ܳ���, {0}.(from {1}). WebApi��ַ:{2}).\",");
            strBuilder.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strBuilder.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strBuilder.AppendFormat("\r\n throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");
            
            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strBuilder.ToString();
        }
        public string Gen_4WA_GetObjLstByPager()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ҳ��ȡJSON�����б�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"objPagerPara\">��ҳ��ȡ��¼�Ĳ�������</param>");
            strBuilder.Append("\r\n /// <returns>����JSON�����б�</returns>");
            strBuilder.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLstByPager(stuPagerPara objPagerPara)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.AppendFormat("\r\n List<cls{0}EN> arrObjLst; ",
objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "string strAction = \"GetObjLstByPager\";");
            
            
            
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = objPagerPara.GetDictParam();");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);");
            strBuilder.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "arrObjLst = clsJSON.GetObjLstFromJson<cls{0}EN>(strResult);",
            //     objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "return arrObjLst;");
            strBuilder.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strBuilder.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strJson = JsonConvert.SerializeObject(jobjReturn0[\"returnObjLst\"]);");

            strBuilder.AppendFormat("\r\n" + "arrObjLst = JsonConvert.DeserializeObject<List<cls{0}EN>>(strJson);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return arrObjLst;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else return null;");


            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n string strMsg = string.Format(\"ִ��WebApi���ܳ���, {0}.(from {1}). WebApi��ַ:{2}).\",");
            strBuilder.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strBuilder.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strBuilder.AppendFormat("\r\n throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");
            
            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strBuilder.ToString();
        }


        /// <summary>
        /// ��ȡ��������������
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_GetNodeProperty4Object()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ���ݶ���Ĺؼ���ֵ,��ȡ�����ȫ������");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��ض���</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "/// <returns>�Ƿ�ɹ�</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool Get{0}(ref cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}Service.Get{0}(ref obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "return bolResult;");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        /// <summary>
        /// ��ȡ��������������
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_GetObjByKeyId()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ��ȡ��ǰ�ؼ��ֵļ�¼����,�ö������ʽ��ʾ.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">��ؼ���</param>", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <returns>�����</returns>");
            strBuilder.AppendFormat("\r\n" + "public static cls{0}EN GetObjBy{1}({2})",
            objPrjTabENEx.TabName, objKeyField.FldName, objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strAction = \"GetObjBy{0}\";", objKeyField.FldName);
            
            
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == false)
            {
                strBuilder.AppendFormat("\r\n" + "[\"{0}\"] = {1}.ToString()", objKeyField.FldName, objKeyField.PrivFuncName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "[\"{0}\"] = {1}", objKeyField.FldName, objKeyField.PrivFuncName);
            }
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "obj{0}EN = clsJSON.GetObjFromJson<cls{0}EN>(strResult);", objPrjTabENEx.TabName);
            
            strBuilder.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strBuilder.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strJson = JsonConvert.SerializeObject(jobjReturn0[\"returnObj\"]);");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = JsonConvert.DeserializeObject<cls{0}EN>(strJson);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\n" + "return bolReturnBool;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else return null;");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"��ȡ������¼����,{0}.(from {1})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");


            //strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            //objPrjTabENEx.TabName);

            //strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = obj{0}Service.GetObjBy{2}({1});",
            //objPrjTabENEx.TabName, objKeyField.PrivFuncName, objKeyField.FldName);
            //strBuilder.AppendFormat("\r\n" + "return obj{0}EN;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        /// <summary>
        /// ɾ��������¼
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_DelNode()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ���ݹؼ���ɾ����¼");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>ʵ��ɾ����¼�ĸ���</returns>");
            strBuilder.AppendFormat("\r\n" + "public static int DelNode({1} {0})",
            objKeyField.PrivFuncName, objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strAction = \"DelNode\";");
            
            
     

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, {0}.ToString(), out string strResult, out string strErrMsg) == true)",
                objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "int intResult  = int.Parse(strResult);");
            //strBuilder.Append("\r\n" + "return intResult;");
            strBuilder.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strBuilder.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const intReturnInt = (int)jobjReturn0[\"returnInt\"];");
            strBuilder.Append("\r\n" + "return intReturnInt;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else return 0;");

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

        /// <summary>
        /// ɾ��������¼
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_DelMultiNode()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ���ݹؼ����б�ɾ����¼");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>ʵ��ɾ����¼�ĸ���</returns>");
            strBuilder.AppendFormat("\r\n" + "public static int Del{0}s(List<string> arr{1})",
            objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strAction = \"Del{0}s\";", objPrjTabENEx.TabName);
            
            
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
           

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strJSON = clsJSON.GetJsonFromObjLst(arr{0});",
                objKeyField.FldName);

            strBuilder.Append("\r\n" + "if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "int intResult  = int.Parse(strResult);");
            //strBuilder.Append("\r\n" + "return intResult;");
            strBuilder.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strBuilder.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const intReturnInt = (int)jobjReturn0[\"returnInt\"];");
            strBuilder.Append("\r\n" + "return intReturnInt;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else return 0;");

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


        /// <summary>
        /// ɾ��������¼
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_DelNodes()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ���ݹؼ����б�ɾ����¼");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>ʵ��ɾ����¼�ĸ���</returns>");
            strBuilder.AppendFormat("\r\n" + "public static int DelNodes(string strKeyIdLst)",
            objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strAction = \"DelNodes\";", objPrjTabENEx.TabName);
            
            
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");


            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "string strJSON = clsJSON.GetJsonFromObjLst(strKeyIdLst);",
            //    objKeyField.FldName);

            strBuilder.Append("\r\n" + "if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out string strResult, out string strErrMsg) == true)");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "int intResult  = int.Parse(strResult);");
            //strBuilder.Append("\r\n" + "return intResult;");
            strBuilder.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strBuilder.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const intReturnInt = (int)jobjReturn0[\"returnInt\"];");
            strBuilder.Append("\r\n" + "return intReturnInt;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else return 0;");

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

        /// <summary>
        /// ɾ��������¼
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_DelMultiNodeByCond()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��������ɾ����¼");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>ʵ��ɾ����¼�ĸ���</returns>");
            strBuilder.AppendFormat("\r\n" + "public static int Del{0}sByCond(string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strAction = \"Del{0}sByCond\";", objPrjTabENEx.TabName);
            
            
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "};");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)");
            strBuilder.Append("\r\n" + "{");          
            //strBuilder.Append("\r\n" + "  int intRecCount =  int.Parse(strResult);");
            //strBuilder.Append("\r\n" + "return intRecCount;");
            strBuilder.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strBuilder.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const intReturnInt = (int)jobjReturn0[\"returnInt\"];");
            strBuilder.Append("\r\n" + "return intReturnInt;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else return 0;");

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


        public string Gen_4WA_AddNewNodeWithMaxId()
        {
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "string") return "";
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��Ӽ�¼");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>�Ƿ�ɹ�?</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool AddNewNodeWithMaxId(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strAction = \"AddNewNodeWithMaxId\";");
            
            
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "string strJson = clsJSON.GetJsonFromObj<cls{0}EN>(obj{0}EN);",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "bool bolResult = bool.Parse(strResult);");
            //strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strBuilder.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const bolReturnBool = (bool)jobjReturn0[\"returnBool\"];");
            strBuilder.Append("\r\n" + "return bolReturnBool;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else return false;");
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

        public string Gen_4WA_AddNewNode()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��Ӽ�¼");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>�Ƿ�ɹ�?</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool AddNewNode(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strAction = \"AddNewNode\";");
            
            
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
         
            strBuilder.AppendFormat("\r\n" + "string strJson = clsJSON.GetJsonFromObj<cls{0}EN>(obj{0}EN);",
                objPrjTabENEx.TabName);
            
            strBuilder.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "bool bolResult = bool.Parse(strResult);");
            //strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strBuilder.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const bolReturnBool = (bool)jobjReturn0[\"returnBool\"];");
            strBuilder.Append("\r\n" + "return bolReturnBool;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else return false;");
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
        public string Gen_4WA_DefineObjCommFun4BL()
        {

            StringBuilder strBuilder = new StringBuilder();

            ///�๹����----------------------------------------------;
            strBuilder.Append("\r\n" + " /// <summary>");
            strBuilder.Append("\r\n" + "/// ר�����߼������ڴ�����ȹ��������Ķ���");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n" + "/// </summary>");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strBuilder.Append("\r\n" + "public static clsCommFun4BL objCommFun4BL = null;");
            }
            else
            {
                strBuilder.Append("\r\n" + "public static clsCommFun4BLV2 objCommFun4BL = null;");
            }
            //strBuilder.Append("\r\n" + "public static event OnAddNewNode onAddNewNode;");
            //strBuilder.Append("\r\n" + "public static event OnUpdateNode onUpdateNode;");
            //strBuilder.Append("\r\n" + "public static event OnDeleteNode onDelNode;");

            return strBuilder.ToString();
        }

        public string Gen_4WA_CopyObj_S()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ͬһ����Ķ���,���Ƶ���һ������");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">Դ����</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}ENT\">Ŀ�����</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n public static void CopyTo(cls{0}EN obj{0}ENS, cls{0}EN obj{0}ENT)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.Set{1}(obj{0}ENS.{1}); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else if (objField.FldOpTypeId == "0003") //ֻд
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.Get{1}(); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.{1}; //{3}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
            }

            //strBuilder.AppendFormat("\r\n" + "{0}DA.CopyTo(obj{0}ENS, obj{0}ENT);",
            //objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "CopyTo", "Copy��:{0} �������ݳ���!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{0})Copy��������ݳ���,{{1}}.({{0}})\",", strErrId, "{", "}");
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{22})Copy��:{0} �������ݳ���!({1}:CopyTo)\\r\\n\" + objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"Copy��:{0} �������ݳ���!({1}: CopyTo)\"+ objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strBuilder.ToString();
        }

        public string Gen_4WA_ToDataTable()
        {
            StringBuilder strBuilder = new StringBuilder();
 
            strBuilder.Append("\r\n" + "/// <summary>");
            strBuilder.Append("\r\n" + "/// �����б� ת��Ϊ DataTable���ݼ���");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n" + "/// </summary>");
            strBuilder.Append("\r\n" + "/// <param name=\"arrObj\">ԭ�����б�</param>");
            strBuilder.Append("\r\n" + "/// <returns>���ص�DataTable</returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable ToDataTable(List<cls{0}EN> arrObj)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable dataTable = new DataTable(); //ʵ����");
            strBuilder.Append("\r\n" + "DataTable result;");

            strBuilder.Append("\r\n" + "if (arrObj.Count == 0) return null;");
            strBuilder.AppendFormat("\r\n" + "if (cls{0}EN.AttributeName.Length == 0)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "result = dataTable;");
            strBuilder.Append("\r\n" + "return result;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "Type type = typeof(cls{0}EN);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "PropertyInfo[] arrPropertyInfo = type.GetProperties();");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//Columns");
            strBuilder.AppendFormat("\r\n" + "foreach (string strAttrName in cls{0}EN.AttributeName)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();");
            strBuilder.Append("\r\n" + "dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "foreach (cls{0}EN objInFor in arrObj)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//Rows");
            strBuilder.Append("\r\n" + "DataRow dataRow = dataTable.NewRow();");
            strBuilder.AppendFormat("\r\n" + "foreach (string strAttrName in cls{0}EN.AttributeName)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "dataRow[strAttrName] = objInFor[strAttrName];");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "dataTable.Rows.Add(dataRow); //ѭ������е�DataTable��");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objExceptoin)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "throw objExceptoin;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "result = dataTable;");
            strBuilder.Append("\r\n" + "return result;");
            strBuilder.Append("\r\n" + "}");

            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strBuilder.ToString();
        }



        public string Gen_4WA_UpdateNode()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �޸ļ�¼");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>�Ƿ�ɹ�?</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool UpdateNode(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty(obj{0}EN.sfUpdFldSetStr) == true)", objPrjTabENEx.TabName); 
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"�޸�ʱ,�޸ı�־��Ϊ��,����ϵ����Ա.����ؼ���:{0}.(from {1}).\",");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1}, clsStackTrace.GetCurrClassFunction());", objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "string strAction = \"UpdateNode\";");
            
            
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
                       
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "string strJson = clsJSON.GetJsonFromObj<cls{0}EN>(obj{0}EN);",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "bool bolResult = bool.Parse(strResult);");
            //strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strBuilder.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const bolReturnBool = (bool)jobjReturn0[\"returnBool\"];");
            strBuilder.Append("\r\n" + "return bolReturnBool;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else return false;");

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

        public string Gen_4WA_IsExistNode()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ���������ж��Ƿ���ڼ�¼");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>�Ƿ����?���ڷ���True</returns>");
            strBuilder.Append("\r\n" + "public static bool IsExistNode(string strWhereCond)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//����¼�Ƿ����");
            strBuilder.Append("\r\n" + "string strAction = \"IsExistNode\";");
            
            
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "};");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strBuilder.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const bolReturnBool = (bool)jobjReturn0[\"returnBool\"];");       
            strBuilder.Append("\r\n" + "return bolReturnBool;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");          
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else return false;");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"��ȡ������¼����,{0}.(from {1})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            //strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            //objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\n" + "bool bolIsExist = obj{0}Service.IsExistNode(strWhereCond);",
            //objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "return bolIsExist;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4WA_GetRecCountByCond()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��ؼ�¼��");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}Cond\">������������������</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>��¼��</returns>");
            strBuilder.AppendFormat("\r\n" + "public static int GetRecCountByCond(cls{0}EN obj{0}Cond)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strAction = \"GetRecCountByCond\";");
            
            
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strJson = clsJSON.GetJsonFromObj<cls{0}EN>(obj{0}Cond);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "return int.Parse(strResult);");
            strBuilder.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strBuilder.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const intReturnInt = (int)jobjReturn0[\"returnInt\"];");
            strBuilder.Append("\r\n" + "return intReturnInt;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else return 0;");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"��ȡ������¼����,{0}.(from {1})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");


            //strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            //objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\n" + "int intRecCount = obj{0}Service.GetRecCountByCond(strWhereCond);",
            //objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "return intRecCount;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4WA_GetFldValue()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��ؼ�¼��");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <returns>��¼��</returns>");
            strBuilder.Append("\r\n" + "public static List<string> GetFldValue(string strFldName, string strWhereCond)");
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strAction = \"GetFldValue\";");
            
            
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strFldName\"] = strFldName,");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "return int.Parse(strResult);");
            strBuilder.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strBuilder.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "const arrReturnStrLst = (List<string>)jobjReturn0[\"returnStrLst\"];");
            //strBuilder.Append("\r\n" + "return arrReturnStrLst;");
            strBuilder.Append("\r\n" + "string strReturnStrLst = (string)jobjReturn0[\"returnStrLst\"];");
            strBuilder.Append("\r\n" + "const arrReturnStrLst = strReturnStrLst.Split(\",\".ToCharArray());");
            strBuilder.Append("\r\n" + "return arrReturnStrLst.Select(x => x).ToList();");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else return null;");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"��ȡ������¼����,{0}.(from {1})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");


            //strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            //objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\n" + "int intRecCount = obj{0}Service.GetRecCountByCond(strWhereCond);",
            //objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "return intRecCount;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_4WA_funSetFldValue()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �������������ֶ�ֵ");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strFldName\">�ֶ���</param>");
            strBuilder.Append("\r\n /// <param name = \"strValue\">ֵ</param>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <returns>��¼��</returns>");
            strBuilder.Append("\r\n" + "public static int SetFldValue(string strFldName, string strValue, string strWhereCond)");
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "string strAction = \"SetFldValue\";");
            
            
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strFldName\"] = strFldName,");
            strBuilder.Append("\r\n" + "[\"strValue\"] = strValue,");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "return int.Parse(strResult);");
            strBuilder.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strBuilder.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "const arrReturnStrLst = (List<string>)jobjReturn0[\"returnStrLst\"];");
            //strBuilder.Append("\r\n" + "return arrReturnStrLst;");
            strBuilder.Append("\r\n" + "const intReturnInt = (int)jobjReturn0[\"returnInt\"];");
            strBuilder.Append("\r\n" + "return intReturnInt;");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else return 0;");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"�������������ֶ�ֵ,{0}.(from {1})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");


            //strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            //objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\n" + "int intRecCount = obj{0}Service.GetRecCountByCond(strWhereCond);",
            //objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "return intRecCount;");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }


        public string Gen_4WA_IsExist()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ���ݹؼ����ж��Ƿ���ڼ�¼");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns>�Ƿ����?���ڷ���True</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool IsExist({0})",
            objPrjTabENEx.KeyVarDefineLstStr);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//����¼�Ƿ����");
            strBuilder.Append("\r\n" + "string strAction = \"IsExist\";");
            
            
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == false)
            {
                strBuilder.AppendFormat("\r\n" + "[\"{0}\"] = {1}.ToString()", objKeyField.FldName, objKeyField.PrivFuncName);
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "[\"{0}\"] = {1}", objKeyField.FldName, objKeyField.PrivFuncName);
            }
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "bool bolIsExist = bool.Parse(strResult);");
            //strBuilder.Append("\r\n" + "return bolIsExist;");
            strBuilder.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strBuilder.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const bolReturnBool = (bool)jobjReturn0[\"returnBool\"];");            
            strBuilder.Append("\r\n" + "return bolReturnBool;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else return false;");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"��ȡ������¼����,{0}.(from {1})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            //strBuilder.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            //objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\n" + "bool bolIsExist = obj{0}Service.IsExist({1});",
            //objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            //strBuilder.Append("\r\n" + "return bolIsExist;");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        public string Gen_4WA_GetMaxStrId()
        {
            StringBuilder strBuilder = new StringBuilder();
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.Append("\r\n /// ��ȡ��ǰ��ؼ���ֵ�����ֵ,�ټ�1,�����ظ�");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");

                strBuilder.Append("\r\n /// <returns>��ǰ��ؼ���ֵ�����ֵ,�ټ�1</returns>");
                strBuilder.AppendFormat("\r\n" + "public static string GetMaxStrId()");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "string strAction = \"GetMaxStrId\";");
                
                
                strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
              

                strBuilder.Append("\r\n" + "try");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)");
                strBuilder.Append("\r\n" + "{");
                //strBuilder.AppendFormat("\r\n" + "string strMax{0} = strResult;",
                //objKeyField.FldName_FstUcase);
                //strBuilder.AppendFormat("\r\n" + "return strMax{0};",
                //objKeyField.FldName_FstUcase);
                strBuilder.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
                strBuilder.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "const strReturnStr = (string)jobjReturn0[\"returnStr\"];");
                strBuilder.Append("\r\n" + "return strReturnStr;");
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "else");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
                strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "else return \"\";");

                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "catch (Exception objException)");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "string strMsg = string.Format(\"��ȡ���ֵ����,{0}.(from {1})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());");
                strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
                strBuilder.Append("\r\n" + "}");
                               
                strBuilder.Append("\r\n" + "}");
            }
            return strBuilder.ToString();
        }
        public string Gen_4WA_GetMaxStrIdByPrefix()
        {
            StringBuilder strBuilder = new StringBuilder();
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.Append("\r\n /// ����ǰ׺��ȡ��ǰ��ؼ���ֵ�����ֵ,�ټ�1,�����ظ�");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");

                strBuilder.Append("\r\n /// <returns>��ǰ��ؼ���ֵ�����ֵ,�ټ�1</returns>");
                strBuilder.AppendFormat("\r\n" + "public static string GetMaxStrIdByPrefix(string strPrefix)");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "//����¼�Ƿ����");
                strBuilder.Append("\r\n" + "string strAction = \"GetMaxStrIdByPrefix\";");
                
                
                strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
                strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"strPrefix\", strPrefix);", objPrjTabENEx.TabName);

                strBuilder.Append("\r\n" + "try");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)");
                strBuilder.Append("\r\n" + "{");
                //strBuilder.AppendFormat("\r\n" + "string strMax{0} = strResult;",
                //objKeyField.FldName_FstUcase);
                //strBuilder.AppendFormat("\r\n" + "return strMax{0};",
                //objKeyField.FldName_FstUcase);
                strBuilder.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
                strBuilder.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "const strReturnStr = (string)jobjReturn0[\"returnStr\"];");
                strBuilder.Append("\r\n" + "return strReturnStr;");
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "else");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
                strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
                strBuilder.Append("\r\n" + "}");

                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "else return \"\";");

                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "catch (Exception objException)");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "string strMsg = string.Format(\"����ǰ׺��ȡ���ֵ����,{0}.(from {1})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());");
                strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
                strBuilder.Append("\r\n" + "}");

                strBuilder.Append("\r\n" + "}");
            }
            return strBuilder.ToString();
        }
        
        /// <summary>
        /// ��ȡ��ǰ�����������ĵ�һ����¼�Ĺؼ���ֵ
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_GetFirstID()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡ��ǰ�����������ĵ�һ����¼�Ĺؼ���ֵ");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <returns>���صĵ�һ����¼�Ĺؼ���ֵ</returns>");
            strBuilder.AppendFormat("\r\n" + "public static {0} GetFirstID(string strWhereCond)",
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
            strBuilder.Append("\r\n" + "{");       

            strBuilder.Append("\r\n" + "string strAction = \"GetFirstID\";");
            
            
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strBuilder.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strBuilder.Append("\r\n" + "{");
            switch (objKeyField.CsType)
            {
                case "long":
                    //strBuilder.Append("\r\n" + "return long.Parse(strResult);");
                    strBuilder.Append("\r\n" + "const strReturnStr = (string)jobjReturn0[\"returnStr\"];");
                    strBuilder.Append("\r\n" + "return long.Parse(strReturnStr);");
                    break;
                case "int":
                    //strBuilder.Append("\r\n" + "return int.Parse(strResult);");
                    strBuilder.Append("\r\n" + "const strReturnStr = (string)jobjReturn0[\"returnStr\"];");
                    strBuilder.Append("\r\n" + "return int.Parse(strReturnStr);");
                    break;
                default:
                    //strBuilder.Append("\r\n" + "return strResult;");
                    strBuilder.Append("\r\n" + "const strReturnStr = (string)jobjReturn0[\"returnStr\"];");
                    strBuilder.Append("\r\n" + "return strReturnStr;");
                    break;
            }
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
            {
                strBuilder.Append("\r\n" + "else return 0;");
            }
            else
            {
                strBuilder.Append("\r\n" + "else return \"\";");
            }
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

        /// <summary>
        /// ��ȡ��ǰ�����������ĵ�һ����¼�Ķ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_GetFirstObj()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡ��ǰ�����������ĵ�һ����¼�Ķ���");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <returns>���صĵ�һ����¼�Ĺؼ���ֵ</returns>");
            strBuilder.AppendFormat("\r\n" + "public static cls{1}EN GetFirstObj(string strWhereCond)",
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strAction = \"GetFirstObj\";", objPrjTabENEx.TabName);
            
            
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "obj{0}EN = clsJSON.GetObjFromJson<cls{0}EN>(strResult);", objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\n" + "return obj{0}EN;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strBuilder.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strJson = JsonConvert.SerializeObject(jobjReturn0[\"returnObj\"]);");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = JsonConvert.DeserializeObject<cls{0}EN>(strJson);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\n" + "return bolReturnBool;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else return null;");


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


        /// <summary>
        /// ��Ӽ�¼,���ҷ��عؼ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_AddNewNodeWithReturnKey()
        {
            if (objKeyField.PrimaryTypeId != "02") return "";
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �ѱ������ӵ����ݿ���,���ҷ��ظü�¼�Ĺؼ���(���Identity�ؼ���)");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵı����</param>",
                    objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>��������Ӽ�¼�Ĺؼ���</returns>");
            strBuilder.AppendFormat("\r\n" + "public static string AddNewNodeWithReturnKey(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strAction = \"AddNewNode\";");
            
            
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "string strJson = clsJSON.GetJsonFromObj<cls{0}EN>(obj{0}EN);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "string strKey = strResult;",
            //objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "return strKey;");
            strBuilder.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strBuilder.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strReturnStr = (string)jobjReturn0[\"returnStr\"];");
            strBuilder.Append("\r\n" + "return strReturnStr;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else return \"\";");

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

        /// <summary>
        /// ��Ӽ�¼,���ҷ��عؼ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_UpdateWithCondition()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡ��ǰ�����������ĵ�һ����¼�Ķ���");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ�޸ĵĶ���</param>",
                  objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">������</param>");
            strBuilder.Append("\r\n /// <returns>���صĵ�һ����¼�Ĺؼ���ֵ</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool UpdateWithCondition(cls{0}EN obj{0}EN, string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty(obj{0}EN.sfUpdFldSetStr) == true)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"�޸�ʱ,�޸ı�־��Ϊ��,����ϵ����Ա.����ؼ���:{0}.(from {1}).\",");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1}, clsStackTrace.GetCurrClassFunction());", objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "if (string.IsNullOrEmpty(strWhereCond) == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"�������޸�ʱ,������Ϊ��,����ϵ����Ա.����ؼ���:{0}.(from {1}).\",");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1}, clsStackTrace.GetCurrClassFunction());", objPrjTabENEx.TabName, objKeyField.FldName);
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "string strAction = \"UpdateWithCondition\";");
            
            
            strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");


            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "string strJson = clsJSON.GetJsonFromObj<cls{0}EN>(obj{0}EN);",
                objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)");
            strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "bool bolResult = bool.Parse(strResult);");
            //strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strBuilder.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const bolReturnBool = (bool)jobjReturn0[\"returnBool\"];");
            strBuilder.Append("\r\n" + "return bolReturnBool;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else return false;");

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
        /// <summary>
        /// ���ݹؼ��ֻ�ȡ�������, �ӻ���Ķ����б��л�ȡ.
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_GetNameByKeyCache()
        {
            string strTextFieldName = "";
            string strValueFieldName = "";
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == "02")
                {
                    strValueFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                }
                if (objField.FieldTypeId == "03")
                {
                    strTextFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                }
            }
            if (strValueFieldName == "" || strTextFieldName == "")
            {
                return "";
            }
            if (objPrjTabENEx.IsUseCache == false) return string.Format("//�ñ�û��ʹ��Cache,����Ҫ����[Get{0}By{1}Cache]����;",
        strTextFieldName, objKeyField.FldName);


            StringBuilder strBuilder = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;

            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ���ݹؼ��ֻ�ȡ�������, �ӻ���Ķ����б��л�ȡ.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���</param>", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <returns>���ݹؼ��ֻ�ȡ������</returns>");
            strBuilder.AppendFormat("\r\n" + "public static string Get{4}By{1}Cache({2} {3})",
            objPrjTabENEx.TabName,
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
            objKeyField.PrivFuncName,
            strTextFieldName);
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true) return \"\";",
                  objKeyField.PrivFuncName);
            }
            strBuilder.Append("\r\n" + "//��ʼ���б���");
            strBuilder.Append("\r\n" + "InitListCache(); ");


            strBuilder.Append("\r\n" + "int intStart = 0;");
            strBuilder.AppendFormat("\r\n" + "int intEnd = arr{0}ObjLstCache.Count - 1;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "int intMid = 0;");
            strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
                 objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "while (intEnd >= intStart)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "intMid = (intStart + intEnd) / 2;");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN = arr{0}ObjLstCache[intMid];",
              objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1} == {2})",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "intFindFailCount = 0;");
            strBuilder.AppendFormat("\r\n" + "return obj{0}EN.{1};",
                  objPrjTabENEx.TabName,
                  strTextFieldName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "else if (obj{0}EN.{1}.CompareTo({2}) > 0)",
                  objPrjTabENEx.TabName,
                  objKeyField.FldName,
                  objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "intEnd = intMid - 1;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "intStart = intMid + 1;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");


            //strBuilder.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0}EN in arr{0}ObjLstCache)",
            //objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1} == {2})",
            //objPrjTabENEx.TabName,
            //objKeyField.FldName,
            //objKeyField.PrivFuncName);
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "return obj{0}EN.{1};",
            //objPrjTabENEx.TabName,
            //strTextFieldName);
            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "intFindFailCount++;");
            strBuilder.AppendFormat("\r\n" + "// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "if (intFindFailCount == 1) return Get{0}By{1}Cache({2});",
                strTextFieldName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n" + "string strErrMsgForGetObjById = string.Format(\"��{2}���󻺴��б���,�Ҳ�����¼[{3} = {{0}}][intFindFailCount = {{1}}](����:{{2}})\", {4}, intFindFailCount, clsStackTrace.GetCurrFunction());",
              "{", "}",
              objPrjTabENEx.TabName,
              objKeyField.FldName,
              objKeyField.PrivFuncName,
              strTextFieldName);
            strBuilder.AppendFormat("\r\n" + "if (obj{0}EN != null)",
                  objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "strErrMsgForGetObjById += string.Format(\"���һ�β��ҵĶ�������ֶ�����ֵ:{{0}}.[intMid = {{1}}]\", obj{2}EN.{3}, intMid);",
               "{", "}",
               objPrjTabENEx.TabName,
               objKeyField.FldName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "strErrMsgForGetObjById += string.Format(\"���һ�β��ҵĶ���Ϊnull, ����![intMid = {{0}}]\", intMid);",
               "{", "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "clsLog.LogErrorS2(\"cls{0}BL\", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, \"\", \"\");",
               objPrjTabENEx.TabName,
                objKeyField.FldName,
                strTextFieldName);
            //strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
            //strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
            //       objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "throw new Exception(strErrMsgForGetObjById);");
            //strBuilder.AppendFormat("\r\n" + "return \"\";");
            strBuilder.Append("\r\n" + "}");

            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strBuilder.ToString();
        }


        /// <summary>
        /// ��ʼ���б���.
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_InitListCache()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ʼ���б���.-----------------------------;


            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ��ʼ���б���.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.Append("\r\n" + "public static void InitListCache()");
            strBuilder.Append("\r\n" + "{");
            //if (objPrjTabENEx.SqlDsTypeId == clsSQLDSTypeBLEx.SQLTAB)
            //{
            //    strBuilder.Append("\r\n" + "//��黺��ˢ�»���");
            //    strBuilder.Append("\r\n" + "string strMsg;");
            //    strBuilder.AppendFormat("\r\n" + "if (cls{0}BL.objCommFun4BL == null)", objPrjTabENEx.TabName);
            //    strBuilder.Append("\r\n" + "{");
            //    strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"��cls{2}BLû��ˢ�»������(cls{2}BL.objCommFun4BL == null), ����ϵ����Ա!({{0}})\", clsStackTrace.GetCurrClassFunction());",
            //        "{", "}", objPrjTabENEx.TabName);
            //    strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            //    strBuilder.Append("\r\n" + "}");
            //}
            //else if (objPrjTabENEx.SqlDsTypeId == clsSQLDSTypeBLEx.SQLVIEW)
            //{
            //    List<string> arrTabId = clsPrjTabBLEx.GetRelaParentNodeByTabId(objPrjTabENEx.TabId, objPrjTabENEx.PrjId);
            //    bool bolIsDef_strMsg = false;
            //    foreach (string strRelaTabId in arrTabId)
            //    {
            //        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strRelaTabId, objPrjTabENEx.PrjId);
            //        if (objPrjTab.SqlDsTypeId == clsSQLDSTypeBLEx.SQLVIEW) continue;

            //        if (bolIsDef_strMsg == false)
            //        {
            //            strBuilder.Append("\r\n" + "//��黺��ˢ�»���");
            //            strBuilder.Append("\r\n" + "string strMsg;");
            //            bolIsDef_strMsg = true;
            //        }
            //        strBuilder.AppendFormat("\r\n" + "if (cls{0}BL.objCommFun4BL == null)", objPrjTab.TabName);
            //        strBuilder.Append("\r\n" + "{");
            //        strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"��cls{2}BLû��ˢ�»������(cls{2}BL.objCommFun4BL == null), ����ϵ����Ա!({{0}})\", clsStackTrace.GetCurrClassFunction());",
            //            "{", "}", objPrjTab.TabName);
            //        strBuilder.Append("\r\n" + "throw new Exception(strMsg);");
            //        strBuilder.Append("\r\n" + "}");
            //    }
            //}
            strBuilder.Append("\r\n" + "//��ʼ���б���");
            strBuilder.AppendFormat("\r\n" + "string strWhereCond = string.Format(\"1 = 1 order by {0}\");", objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "if (arr{0}ObjLstCache == null)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = await {0}GetObjLst(strWhereCond);",
                  objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\n" + "intFldNumCache = arr{0}ObjLstCache.Count;", 
            //      objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            //��ʼ���б���.======================= = ;
            return strBuilder.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_GetObjByKeyCache()
        {
         
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;
            if (objPrjTabENEx.IsUseCache == false) return "//�ñ���Ҫʹ��Cache;";
            StringBuilder strBuilder = new StringBuilder();
            //���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;

            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.û�оͷ���null.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���</param>", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <returns>���ݹؼ��ֻ�ȡ�Ķ���</returns>");
            strBuilder.AppendFormat("\r\n" + "public static cls{0}EN GetObjBy{1}Cache({2} {3})",
            objPrjTabENEx.TabName,
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
            objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true) return null;",
                  objKeyField.PrivFuncName);
            }
            strBuilder.Append("\r\n" + "//��ʼ���б���");
            strBuilder.Append("\r\n" + "InitListCache(); ");

            strBuilder.AppendFormat("\r\n" + "IEnumerable <cls{0}EN> arr{0}ObjLst_Sel1 =", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "from obj{0}EN in arr{0}ObjLstCache", objPrjTabENEx.TabName);
            int intIndex = 0;
            foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
            {
                if (intIndex == 0)
                {
                    strBuilder.AppendFormat("\r\n" + "where obj{0}EN.{1} == {2} ",
                objPrjTabENEx.TabName,
                objInFor.PropertyName(this.IsFstLcase),
                objInFor.PrivFuncName);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + " && obj{0}EN.{1} == {2} ",
                objPrjTabENEx.TabName,
                objInFor.PropertyName(this.IsFstLcase),
                objInFor.PrivFuncName);
                }
                intIndex++;
            }
            strBuilder.AppendFormat("\r\n" + "select obj{0}EN;", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "List <cls{0}EN> arr{0}ObjLst_Sel = new List<cls{0}EN>();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "foreach (cls{0}EN obj in arr{0}ObjLst_Sel1)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLst_Sel.Add(obj);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "if (arr{0}ObjLst_Sel.Count == 0)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "return null;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLst_Sel[0];", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");


            //���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strBuilder.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ�������, �ӻ���Ķ����б��л�ȡ.
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_GetRecNameByKeyCache()
        {
            string strTextFieldName = "";
            string strValueFieldName = "";
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == "02")
                {
                    strValueFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                }
                if (objField.FieldTypeId == "03")
                {
                    strTextFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                }
            }
            if (strValueFieldName == "" || strTextFieldName == "")
            {
                return "";
            }
            if (objPrjTabENEx.IsUseCache == false) return string.Format("//�ñ�û��ʹ��Cache,����Ҫ����[Get{0}By{1}Cache]����;",
        strTextFieldName, objKeyField.FldName);
            if (objPrjTabENEx.IsUseCache_TS() == false) return $"//�ñ�û��ʹ��Cache,����Ҫ����[Get{strTextFieldName}By{objKeyField.FldName}Cache]����;(in {clsStackTrace.GetCurrClassFunction()})";

            StringBuilder strBuilder = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;

            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ���ݹؼ��ֻ�ȡ�������, �ӻ���Ķ����б��л�ȡ.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���</param>", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <returns>���ݹؼ��ֻ�ȡ������</returns>");
            strBuilder.AppendFormat("\r\n" + "public static string Get{4}By{1}Cache({2} {3})",
            objPrjTabENEx.TabName,
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
            objKeyField.PrivFuncName,
            strTextFieldName);
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true) return \"\";",
                  objKeyField.PrivFuncName);
            }
            strBuilder.Append("\r\n" + "//��ʼ���б���");
            strBuilder.Append("\r\n" + "InitListCache(); ");


            strBuilder.AppendFormat("\r\n" + "IEnumerable <cls{0}EN> arr{0}ObjLst_Sel1 =", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "from obj{0}EN in arr{0}ObjLstCache", objPrjTabENEx.TabName);
            int intIndex = 0;
            foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
            {
                if (intIndex == 0)
                {
                    strBuilder.AppendFormat("\r\n" + "where obj{0}EN.{1} == {2} ",
                objPrjTabENEx.TabName,
                objInFor.PropertyName(this.IsFstLcase),
                objInFor.PrivFuncName);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + " && obj{0}EN.{1} == {2} ",
                objPrjTabENEx.TabName,
                objInFor.PropertyName(this.IsFstLcase),
                objInFor.PrivFuncName);
                }
                intIndex++;
            }
            strBuilder.AppendFormat("\r\n" + "select obj{0}EN;", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "List <cls{0}EN> arr{0}ObjLst_Sel = new List<cls{0}EN>();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "foreach (cls{0}EN obj in arr{0}ObjLst_Sel1)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLst_Sel.Add(obj);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "if (arr{0}ObjLst_Sel.Count > 0)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLst_Sel[0].{1};",
                objPrjTabENEx.TabName, strTextFieldName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "string strErrMsgForGetObjById = string.Format(\"��{2}���󻺴��б���,�Ҳ�����¼[{3} = {{0}}](����:{{1}})\", {4}, clsStackTrace.GetCurrFunction());",
              "{", "}",
              objPrjTabENEx.TabName,
              objKeyField.FldName,
              objKeyField.PrivFuncName,
              strTextFieldName);
            strBuilder.AppendFormat("\r\n" + "clsLog.LogErrorS2(\"cls{0}BL\", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, \"\", \"\");",
               objPrjTabENEx.TabName,
                objKeyField.FldName,
                strTextFieldName);
            //strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
            //strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
            //       objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "throw new Exception(strErrMsgForGetObjById);");
            //strBuilder.AppendFormat("\r\n" + "return \"\";");
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// ���ݹؼ��ֻ�ȡ�������, �ӻ���Ķ����б��л�ȡ.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���</param>", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n /// <returns>���ݹؼ��ֻ�ȡ������</returns>");
            strBuilder.AppendFormat("\r\n" + "public static string GetNameBy{1}Cache({2} {3})",
            objPrjTabENEx.TabName,
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
            objKeyField.PrivFuncName,
            strTextFieldName);
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true) return \"\";",
                  objKeyField.PrivFuncName);
            }
            strBuilder.Append("\r\n" + "//��ʼ���б���");
            strBuilder.Append("\r\n" + "InitListCache(); ");


            strBuilder.AppendFormat("\r\n" + "IEnumerable <cls{0}EN> arr{0}ObjLst_Sel1 =", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "from obj{0}EN in arr{0}ObjLstCache", objPrjTabENEx.TabName);
            intIndex = 0;
            foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
            {
                if (intIndex == 0)
                {
                    strBuilder.AppendFormat("\r\n" + "where obj{0}EN.{1} == {2} ",
                objPrjTabENEx.TabName,
                objInFor.PropertyName(this.IsFstLcase),
                objInFor.PrivFuncName);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + " && obj{0}EN.{1} == {2} ",
                objPrjTabENEx.TabName,
                objInFor.PropertyName(this.IsFstLcase),
                objInFor.PrivFuncName);
                }
                intIndex++;
            }
            strBuilder.AppendFormat("\r\n" + "select obj{0}EN;", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "List <cls{0}EN> arr{0}ObjLst_Sel = new List<cls{0}EN>();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "foreach (cls{0}EN obj in arr{0}ObjLst_Sel1)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLst_Sel.Add(obj);", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "if (arr{0}ObjLst_Sel.Count > 0)",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLst_Sel[0].{1};",
                objPrjTabENEx.TabName, strTextFieldName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "string strErrMsgForGetObjById = string.Format(\"��{2}���󻺴��б���,�Ҳ�����¼���������[{3} = {{0}}](����:{{1}})\", {4}, clsStackTrace.GetCurrFunction());",
              "{", "}",
              objPrjTabENEx.TabName,
              objKeyField.FldName,
              objKeyField.PrivFuncName,
              strTextFieldName);
            strBuilder.AppendFormat("\r\n" + "clsLog.LogErrorS2(\"cls{0}BL\", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, \"\", \"\");",
               objPrjTabENEx.TabName,
                objKeyField.FldName,
                strTextFieldName);
            //strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
            //strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
            //       objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "throw new Exception(strErrMsgForGetObjById);");
            //strBuilder.AppendFormat("\r\n" + "return \"\";");
            strBuilder.Append("\r\n" + "}");

            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strBuilder.ToString();
        }


        /// <summary>
        /// �ѱ������ݰ󶨵�ListView��
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_BindListView()
        {
            string strFuncName = "";
            StringBuilder strBuilder = new StringBuilder();
            try
            {
                //strBuilder.Append("\r\n //1/���ɰ�ListView�Ĵ���");
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.Append("\r\n /// ��������:���ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼,");
                strBuilder.Append("\r\n ///			 ����ʾ��ListView�С�");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "public static int BindLv_{0}(System.Windows.Forms.ListView lv{0}, string strWhereCond)",
                objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "//��������:(��4��)");
                strBuilder.Append("\r\n" + "//	1����Ͻ�����������");
                strBuilder.Append("\r\n" + "//	2��������������ȡ�ñ�����������DataTable��");
                strBuilder.Append("\r\n" + "//	3������ListView����ͷ��Ϣ");
                strBuilder.Append("\r\n" + "//	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��");
                strBuilder.Append("\r\n" + "//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�lblRecCount�С�");
                strBuilder.Append("\r\n" + "");
                strBuilder.AppendFormat("\r\n" + "System.Windows.Forms.ListViewItem lvi{0}; ",
                objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst;",
                objPrjTabENEx.TabName);

                strBuilder.Append("\r\n" + "//	2��������������ȡ�ñ�����������DataTable��");
                strBuilder.AppendFormat("\r\n" + "arr{0}ObjLst = GetObjLst(strWhereCond);",
                objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "//	3������ListView����ͷ��Ϣ");
                strBuilder.AppendFormat("\r\n" + "lv{0}.Items.Clear();//���ԭ������Item",
                objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n" + "lv{0}.Columns.Clear();//���ԭ��������ͷ��Ϣ",
                objPrjTabENEx.TabName);
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.FieldTypeId != "04" && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "byte[]")	//���ǹ����ֶ�
                    {
                        strBuilder.AppendFormat("\r\n" + "lv{0}.Columns.Add(\"{1}\", 100, System.Windows.Forms.HorizontalAlignment.Left);",
                        objPrjTabENEx.TabName, objField.ColCaption);
                    }
                }
                strBuilder.AppendFormat("\r\n" + "lv{0}.View = System.Windows.Forms.View.Details;",
                objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "//	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��");
                strBuilder.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0}EN in arr{0}ObjLst)",
                objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "lvi{0} = new System.Windows.Forms.ListViewItem();",
                objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n" + "lvi{0}.Tag = obj{0}EN.{1};",
                objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.AppendFormat("\r\n" + "lvi{0}.Text = obj{0}EN.{1}.ToString();",
                objPrjTabENEx.TabName, objKeyField.FldName);
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objKeyField.FldId == objField.FldId)
                    {
                        continue;
                    }
                    if (objField.FieldTypeId != "04"
                    && objField.IsTabForeignKey == false
                    && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "byte[]")
                    {
                        if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
                        {
                            strBuilder.AppendFormat("\r\n" + "lvi{0}.SubItems.Add(obj{0}EN.{1});",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                        }
                        else
                        {
                            strBuilder.AppendFormat("\r\n" + "lvi{0}.SubItems.Add(obj{0}EN.{1}.ToString());",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                        }
                    }
                }
                strBuilder.AppendFormat("\r\n" + "lv{0}.Items.Add(lvi{0});",
                objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "//	4�����ü�¼����״̬,");
                strBuilder.Append("\r\n" + "//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�");
                strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLst.Count;",
                objPrjTabENEx.TabName);
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
        public string Gen_4WA_TabFeature_ComboBoxBindFunction()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
 
            bool bolIsNeedQuote = true;
            //clsDataTypeAbbrEN objDataTypeAbbr4ValueField = null;
            try
            {
                List<clsTabFeatureEN> arrTabFeature = objPrjTabENEx.arrTabFeatureSet().Where(x => x.FeatureId == enumPrjFeature.Tab_BindDdl_0173).ToList();
                foreach (var objTabFeature_BindDdl in arrTabFeature)
                {
                    if (objTabFeature_BindDdl == null) continue;
                    if (objTabFeature_BindDdl.IsNeedGC == false)
                    {
                        strCodeForCs.Append("\r\n//�ñ��������ܲ���Ҫ����;");
                        continue;
                    }
                    if (objTabFeature_BindDdl.IsExtendedClass == true)
                    {
                        strCodeForCs.Append("\r\n//�ñ��������ܽ���ʹ������չ��;");
                        continue;
                    }
                    //clsTabFeatureFldsENEx objField_OrderNum = objTabFeature_AdjustOrderNum.arrTabFeatureFldsSet().Find(x => x.FieldTypeId == enumFieldType.OrderNumField_09);
                    //IEnumerable<clsTabFeatureFldsENEx> arrFieldLst_Classify = objTabFeature_AdjustOrderNum.arrTabFeatureFldsSet().Where(x => x.FieldTypeId == enumFieldType.ClassificationField_10);

                    if (objTabFeature_BindDdl.arrTabFeatureFldsSet().Exists(x => x.FieldTypeId == enumFieldType.NameField_03) == false)
                    {
                        throw new Exception("��ǰ��û�������ֶ�,������Ӱ���������!");
                    }
                    if (objTabFeature_BindDdl.arrTabFeatureFldsSet().Exists(x => x.FieldTypeId == enumFieldType.KeyField_02) == false)
                    {
                        throw new Exception("��ǰ��û�йؼ��ֶ�,������Ӱ���������!");
                    }
                    List<clsTabFeatureFldsENEx> arrFieldLst_Cond = objTabFeature_BindDdl.arrTabFeatureFldsSetEx().Where(x => x.FieldTypeId == enumFieldType.ConditionField_16).ToList();

                    List<string> arrCondFldId = objTabFeature_BindDdl.GetCondFldIdLst();
                    var objFuncParaLst = new FuncParaLst("DdlParaLst", this.IsFstLcase, enumAppLevel.InvokeFunc);
                    objFuncParaLst.AddParaByTabFeature(objTabFeature_BindDdl, arrFieldLst_Cond, enumProgLangType.CSharp_01);
                    objFuncParaLst.AddParaByCacheClassify(thisCacheClassify, arrCondFldId, enumProgLangType.CSharp_01);
                    string strFuncPara = objFuncParaLst.GetCondFldLst4Para4CSharp();
                    string strPrivFuncName_Additional = objFuncParaLst.GetCondFldLst();
                    string strCodeText_CheckEmpty = objFuncParaLst.Gc_CheckVarEmpty_Cs(this.ClsName,
                        objTabFeature_BindDdl.FuncNameJs, true);

                    string strFuncRemark = objFuncParaLst.GetFuncRemark4CSharp();

                    clsTabFeatureFldsEN objField_Key = objTabFeature_BindDdl.arrTabFeatureFldsSet().Find(x => x.FieldTypeId == enumFieldType.KeyField_02);
                    clsTabFeatureFldsEN objField_Name = objTabFeature_BindDdl.arrTabFeatureFldsSet().Find(x => x.FieldTypeId == enumFieldType.NameField_03);
                    string strTextFieldName = objField_Name.ObjFieldTab().FldName;
                    string strValueFieldName = objField_Key.ObjFieldTab().FldName;
                    bolIsNeedQuote = objField_Key.ObjFieldTab().ObjDataTypeAbbr1().IsNeedQuote;
                  

                    if (strValueFieldName != "" && strTextFieldName != "")
                    {
                        strCodeForCs.Append("\r\n /// <summary>");
                        strCodeForCs.Append("\r\n /// �󶨻���Win��������");
                        strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n /// </summary>");
                        strCodeForCs.Append("\r\n /// <param name = \"objComboBox\">��Ҫ�󶨵�ǰ���������</param>");
                        //���������������ĺ���˵��
                        strCodeForCs.Append("\r\n" + strFuncRemark);

                        strCodeForCs.AppendFormat("\r\n" + "public static void BindCbo_{0}(System.Windows.Forms.ComboBox objComboBox {1})",
                            strValueFieldName, strFuncPara == "" ? "" : ", " + strFuncPara);
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.Append("\r\n" + "//Ϊ����ԴΪ�����������������");
                        strCodeForCs.AppendFormat("\r\n" + "string strCondition = string.Format(\"1 =1 Order By {{0}}\", con{0}.{1}); ",
                            objPrjTabENEx.TabName, strValueFieldName);
                        if (objTabFeature_BindDdl.arrTabFeatureFldsSet().Exists(x => x.FieldTypeId == enumFieldType.SortField_06) == true)
                        {
                            clsTabFeatureFldsEN objField_Sort = objTabFeature_BindDdl.arrTabFeatureFldsSet().Find(x => x.FieldTypeId == enumFieldType.SortField_06);
                            strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arrObjLst = {0}GetObjLst(strCondition).OrderBy(x=>x.{1}).ToList();",
                                 objPrjTabENEx.TabName,
                                 objField_Sort.ObjFieldTab().FldName);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arrObjLst = {0}GetObjLst(strCondition);",
                                 objPrjTabENEx.TabName);
                        }
                        //���ɹ����������
                        string strFilterCondition = objFuncParaLst.GeneFilterCondition4CSharp(false);
                        strCodeForCs.Append(strFilterCondition);
                        string strObjLstName = "arrObjLst";
                        if (strFilterCondition.Length > 5)
                        {
                            strObjLstName = "arrObjLstSel";
                        }
                        //strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = cls{1}BL.GetDataTable(strCondition);",
                        //    strValueFieldName, objPrjTabENEx.TabName);

                        strCodeForCs.AppendFormat("\r\n" + "//��ʼ��һ�������б�");

                        strCodeForCs.Append("\r\n" + "//�����0��ڵ�0���в��롰��ѡ��...��,Ϊ�˷����û�,��WEB��ʽ���ơ�");
                        strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = new cls{0}EN()",
                        objPrjTabENEx.TabName);
                        strCodeForCs.Append("\r\n" + "{");
                        if (bolIsNeedQuote == true)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "{1} = \"0\",",
                            objPrjTabENEx.TabName, strValueFieldName);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "{1} = 0,",
                            objPrjTabENEx.TabName, strValueFieldName);

                        }

                        strCodeForCs.AppendFormat("\r\n" + "{1} = \"ѡ[{2}]...\"",
                            objPrjTabENEx.TabName, strTextFieldName, objPrjTabENEx.TabCnName);
                        strCodeForCs.Append("\r\n" + "};");

                        strCodeForCs.AppendFormat("\r\n" + "{1}.Insert(0, obj{0}EN);",
                        objPrjTabENEx.TabName, strObjLstName);

                        strCodeForCs.Append("\r\n" + "//���������������Դ���Լ�����ֵ���ʾ��");

                        strCodeForCs.AppendFormat("\r\n" + "objComboBox.ValueMember = con{0}.{1};",
                         objPrjTabENEx.TabName, strValueFieldName);
                        strCodeForCs.AppendFormat("\r\n" + "objComboBox.DisplayMember = con{0}.{1};",
                         objPrjTabENEx.TabName, strTextFieldName);
                        strCodeForCs.AppendFormat("\r\n" + "objComboBox.DataSource = {0};", strObjLstName);
                        strCodeForCs.Append("\r\n" + "objComboBox.SelectedIndex = 0;");
                        strCodeForCs.Append("\r\n" + "}");
                    }
                }
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_4WA_ComboBoxBindFunction()
        {
            string strFuncName = "";
            StringBuilder strBuilder = new StringBuilder();
            string strTextFieldName = "";
            string strValueFieldName = "";
            bool bolIsNumber4ValueFieldName = false;
            try
            {
                //��0��:�ѿؼ���������ComboBoxת����ComboBox
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.FieldTypeId == "02")
                    {
                        strValueFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                        bolIsNumber4ValueFieldName = objField.IsNumberType();
                    }
                    if (objField.FieldTypeId == "03")
                    {
                        strTextFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                    }
                }
                if (strValueFieldName != "" && strTextFieldName != "")
                {
                    //strBuilder.AppendFormat("\r\n" + "public static System.Data.DataTable Get{0}()",
                    //strValueFieldName);
                    //strBuilder.Append("\r\n" + "{");
                    //strBuilder.Append("\r\n" + "//��ȡĳѧԺ����רҵ��Ϣ");
                    //strBuilder.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";",
                    //strValueFieldName, strTextFieldName, objPrjTabENEx.TabName);
                    ////						if (objField.DsCondStr.Trim() == "" )
                    ////						{
                    ////							strBuilder.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";", 
                    ////								strValueFieldName, strTextFieldName, objPrjTabENEx.TabName);
                    ////						}
                    ////						else
                    ////						{
                    ////							strBuilder.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} where {3}\";", 
                    ////								strValueFieldName, strTextFieldName, objPrjTabENEx.TabName, objField.DsCondStr);
                    ////						}
                    ////strBuilder.Append("\r\n" + "clsSpecSQLforSql mySql=new 1clsSpecSQLforSql();");
                    //strBuilder.AppendFormat("\r\n clsSpecSQLforSql mySql = cls{0}BL.GetSpecSQLObj();", objPrjTabENEx.TabName);

                    //strBuilder.Append("\r\n" + "System.Data.DataTable objDT = mySql.GetDataTable(strSQL);");
                    //strBuilder.Append("\r\n" + "return objDT;");
                    //strBuilder.Append("\r\n" + "}");
                    strBuilder.Append("\r\n /// <summary>");
                    strBuilder.Append("\r\n /// �󶨻���Win��������");
                    strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.Append("\r\n /// <param name=\"objComboBox\">��Ҫ�󶨵�ǰ���������</param>");
                    strBuilder.AppendFormat("\r\n" + "public static void BindCbo_{0}(System.Windows.Forms.ComboBox objComboBox)",
                    strValueFieldName);
                    strBuilder.Append("\r\n" + "{");
                    strBuilder.Append("\r\n" + "//Ϊ����ԴΪ�����������������");
                    strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arrObjLst = GetObjLst(\"1=1\");",
                    objPrjTabENEx.TabName);


                    strBuilder.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
                    objPrjTabENEx.TabName);
                    strBuilder.AppendFormat("\r\n" + "//��ʼ��һ�������б�");
                    //strBuilder.AppendFormat("\r\n" + "ArrayList {0}List = new ArrayList();",
                    //objPrjTabENEx.TabName);
                    strBuilder.Append("\r\n" + "//�����0��ڵ�0���в��롰��ѡ��...��,Ϊ�˷����û�,��WEB��ʽ���ơ�");
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN = new cls{0}EN();",
                    objPrjTabENEx.TabName);
                    if (bolIsNumber4ValueFieldName)
                    {
                        strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = 0;",
                        objPrjTabENEx.TabName, strValueFieldName);
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = \"0\";",
                        objPrjTabENEx.TabName, strValueFieldName);
                    }
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = \"ѡ[{2}]...\";",
                        objPrjTabENEx.TabName, strTextFieldName, objPrjTabENEx.TabCnName);

                    strBuilder.AppendFormat("\r\n" + "arrObjLst.Insert(0, obj{0}EN);",
                    objPrjTabENEx.TabName);
                    strBuilder.Append("\r\n" + "//��DataTable�е���������ӵ������б���");

                    strBuilder.Append("\r\n" + "//���������������Դ���Լ�����ֵ���ʾ��");
                    strBuilder.AppendFormat("\r\n" + "objComboBox.DataSource = arrObjLst;",
                    objPrjTabENEx.TabName);
                    strBuilder.AppendFormat("\r\n" + "objComboBox.ValueMember=\"{1}\";",
                            objPrjTabENEx.TabName, strValueFieldName);
                    strBuilder.AppendFormat("\r\n" + "objComboBox.DisplayMember=\"{1}\";",
                           objPrjTabENEx.TabName, strTextFieldName);
                    strBuilder.Append("\r\n" + "objComboBox.SelectedIndex = 0;");
                    strBuilder.Append("\r\n" + "}");
                }
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strBuilder.ToString();
        }
        public string Gen_4WA_DdlBindFunction()
        {
            string strFuncName = "";
            StringBuilder strBuilder = new StringBuilder();
            string strTextFieldName = "";
            string strValueFieldName = "";
            try
            {
                ///���ɽ��б���;
                //��������ĺ��� ����;
                //��0��:�ѿؼ���������ComboBoxת����ComboBox
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.FieldTypeId == "02")
                    {
                        strValueFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                    }
                    if (objField.FieldTypeId == "03")
                    {
                        strTextFieldName = objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase);
                    }
                }
                if (strValueFieldName != "" && strTextFieldName != "")
                {
                   
                    strBuilder.Append("\r\n /// <summary>");
                    strBuilder.Append("\r\n /// �󶨻���Web��������");
                    strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.Append("\r\n /// <param name=\"objDDL\">��Ҫ�󶨵�ǰ���������</param>");
                    strBuilder.AppendFormat("\r\n" + "public static void BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL)",
                    strValueFieldName);
                    strBuilder.Append("\r\n" + "{");
                    strBuilder.Append("\r\n" + "//Ϊ����Դ�ڱ����������������");

                    strBuilder.AppendFormat("\r\n" + "System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem(\"ѡ[{0}]...\",\"0\");",
                          objPrjTabENEx.TabCnName);

                    strBuilder.AppendFormat("\r\n" + "List<cls{0}EN> arrObjLst = GetObjLst(\"1=1\");",
                        objPrjTabENEx.TabName);

                    strBuilder.AppendFormat("\r\n" + "objDDL.DataValueField=\"{1}\";",
                        objPrjTabENEx.TabName, strValueFieldName);
                    strBuilder.AppendFormat("\r\n" + "objDDL.DataTextField=\"{1}\";",
                        objPrjTabENEx.TabName, strTextFieldName);
                    strBuilder.Append("\r\n" + "objDDL.DataSource = arrObjLst;");
                    strBuilder.Append("\r\n" + "objDDL.DataBind();");
                    strBuilder.Append("\r\n" + "objDDL.Items.Insert(0, li);");
                    strBuilder.Append("\r\n" + "objDDL.SelectedIndex = 0;");
                    strBuilder.Append("\r\n" + "}");
                }
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

 
        public string Gen_4WA_GeneEnumConstList()
        {
            string strKeyFieldName = "";
            string strNamedFieldName = "";
            string strEnglishNameFieldName = "";

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == "02")
                {
                    strKeyFieldName = objField.ObjFieldTabENEx.FldName;
                }
                if (objField.FieldTypeId == "03")
                {
                    strNamedFieldName = objField.ObjFieldTabENEx.FldName;
                }
                if (objField.FieldTypeId == "05")
                {
                    strEnglishNameFieldName = objField.ObjFieldTabENEx.FldName;
                }
            }
            if (string.IsNullOrEmpty(strKeyFieldName) == true) return "";
            if (string.IsNullOrEmpty(strNamedFieldName) == true) return "";
            if (string.IsNullOrEmpty(strEnglishNameFieldName) == true) return "";
            DataTable objDT;
            try
            {
                objDT = clsTablesBLEx.GetDataTableByTabName(objPrjTabENEx.TabName, this.objPrjDataBaseEN.PrjDataBaseId);
            }
            catch (Exception objException)
            {
                clsEntityBase.LogErrorS(objException, clsStackTrace.GetCurrClassFunction());
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("�ڻ�ȡ�����ݣ�GetDataTableByTabName��ʱ����!������{0},������Ϣ��{1}��({2})",
                    objPrjTabENEx.TabName, objException.Message,
                    clsStackTrace.GetCurrClassFunction());
                clsSysParaEN_Local.objLog4GCError.WriteDebugLog(sbMsg.ToString());
                throw new Exception(sbMsg.ToString());
            }

            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ���ݱ���������enum�б�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strBuilder.AppendFormat("\r\npublic class enum{0}WA",
                       objPrjTabENEx.TabName,
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                strBuilder.Append("\r\n{");

                foreach (DataRow objRow in objDT.Rows)
                {
                    strBuilder.Append("\r\n /// <summary>");
                    strBuilder.AppendFormat("\r\n /// {0}", objRow[strNamedFieldName]);
                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.AppendFormat("\r\n" + "public const string {0}_{1} = \"{1}\";",
                        objRow[strEnglishNameFieldName], objRow[strKeyFieldName]);
                }
            }
            else
            {
                strBuilder.AppendFormat("\r\npublic enum enum{0} : {1}",
                objPrjTabENEx.TabName,
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                strBuilder.Append("\r\n{");

                foreach (DataRow objRow in objDT.Rows)
                {
                    strBuilder.AppendFormat("\r\n" + "[Description(\"{0}\")]", objRow[strNamedFieldName]);
                    strBuilder.AppendFormat("\r\n" + "{0}_{1} = {1},", objRow[strEnglishNameFieldName], objRow[strKeyFieldName]);                    
                }
            }
            strBuilder.Append("\r\n}");

            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strBuilder.ToString();
        }
        public string Gen_4WA_GeneEnumConstList4Field()
        {

            string strStrConstFieldName = "";

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {

                if (objField.FieldTypeId == "07")
                {
                    strStrConstFieldName = objField.ObjFieldTabENEx.FldName;
                }
            }

            if (string.IsNullOrEmpty(strStrConstFieldName) == true) return "";
            DataTable objDT;
            try
            {
                objDT = clsTablesBLEx.GetDataTableByTabName(objPrjTabENEx.TabName, this.objPrjDataBaseEN.PrjDataBaseId);
            }
            catch (Exception objException)
            {
                clsEntityBase.LogErrorS(objException, clsStackTrace.GetCurrClassFunction());
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("�ڻ�ȡ�����ݣ�GetDataTableByTabName��ʱ����!������{0},������Ϣ��{1}��({2})",
                    objPrjTabENEx.TabName, objException.Message,
                    clsStackTrace.GetCurrClassFunction());
                clsSysParaEN_Local.objLog4GCError.WriteDebugLog(sbMsg.ToString());
                throw new Exception(sbMsg.ToString());
            }

            StringBuilder strBuilder = new StringBuilder();
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "string") continue;
                if (objField.FieldTypeId != "07") continue;
                //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// ���ݱ��ֶ���������enum�б�-�ֶ�����[{0}]", objField.ObjFieldTabENEx.FldName);
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");

                strBuilder.AppendFormat("\r\npublic class enum{0}_{1}WS",
                       objPrjTabENEx.TabName,
                        objField.ObjFieldTabENEx.FldName);
                strBuilder.Append("\r\n{");
                List<string> arrExistItem = new List<string>();
                foreach (DataRow objRow in objDT.Rows)
                {
                    string strFieldValue = objRow[objField.ObjFieldTabENEx.FldName].ToString();
                    if (arrExistItem.Contains(strFieldValue)) continue;
                    arrExistItem.Add(strFieldValue);
                    strBuilder.Append("\r\n /// <summary>");
                    strBuilder.AppendFormat("\r\n /// {0}", strFieldValue);
                    strBuilder.Append("\r\n /// </summary>");
                    strBuilder.AppendFormat("\r\n" + "public const string con{0} = \"{0}\";",
                        strFieldValue);
                }

                strBuilder.Append("\r\n}");
            }
            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strBuilder.ToString();
        }


        public override void GetClsName()
        {
            this.ClsName = string.Format("{0}ApiController", objPrjTabENEx.TabName);
            objPrjTabENEx.ClsName = this.ClsName;
        }
        public string A_GeneFuncCodeByFuncName(string strFuncName)
        {
            //string strFuncName = objvFunction4GeneCodeEN.FuncName;
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBLEx.GetObjByFuncNameCache(strFuncName);
            try
            {
                string strCode = "";
                Type t = typeof(NodeWA_Access4CSharp);
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
                        strCode = (string)mt.Invoke(this, new object[] { objFunction4GeneCodeEN });
                    }
                    //Console.WriteLine(str);
                }

                return strCode;

            }
            catch (Exception objException)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����������Ϣ:{1}.({2})", strFuncName,
                        objException.Message,
                        clsStackTrace.GetCurrClassFunction());
                clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
        }

        public void Gen_4WA_Static_SetFieldValue4OneField(clsPrjTabFldENEx objField, StringBuilder strBuilder)
        {
            if (objField.FldOpTypeId == "0004") return;//������д
            if (objField.FldOpTypeId == "0002") return;//ֻ����д
            string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);
            string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// ����:Ϊ���������ֶ�ֵ");
            strBuilder.Append("\r\n /// /// �ŵ�:1������ʵ�ֺ�������,�������ֵ����һ��д.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ�����ֶ�ֵ��ʵ�����</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"strComparisonOp\">�Ƚ������,�����ֵ,��������֯������</param>");
            strBuilder.Append("\r\n /// <returns>���ض���,���Լ�����д</returns>");
            strBuilder.AppendFormat("\r\n" + "public static cls{0}EN Set{1}(this cls{0}EN obj{0}EN, {2} {3}, string strComparisonOp=\"\")",
            objPrjTabENEx.TabName, objField.FldName, objField.CsType, objField.PrivFuncName);
            strBuilder.Append("\r\n	{");
            //objUserStateEN.Memo = strMemo;


            //���ǿ�
            if (objField.IsTabNullable == false && objField.FieldTypeId != "02")
            {
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte[]" || objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte")
                {

                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldNotNull({0}, con{2}.{3});",
                   objField.PrivFuncName,
                   objField.ObjFieldTabENEx.FldLength,
                   objPrjTabENEx.TabName,
                   objField.ObjFieldTabENEx.FldName);

                }

            }
            //����ֶγ���

            if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string"
                && objField.ObjFieldTabENEx.FldLength > 0)
            {

                strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldLen({0}, {1}, con{2}.{3});",
         objField.PrivFuncName,
         objField.ObjFieldTabENEx.FldLength,
         objPrjTabENEx.TabName,
         objField.ObjFieldTabENEx.FldName);

            }
            //������
            if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
               && objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName == "char" && objField.ObjFieldTabENEx.FldLength > 0)
            {

                strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldForeignKey({0}, {1}, con{2}.{3});",
           objField.PrivFuncName,
           objField.ObjFieldTabENEx.FldLength,
           objPrjTabENEx.TabName,
           objField.ObjFieldTabENEx.FldName);

            }

            strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = {2}; //{3}",
             objPrjTabENEx.TabName, objField.FldName, objField.PrivFuncName, objField.ColCaption);
            strBuilder.AppendFormat("\r\n" + "if (string.IsNullOrEmpty(strComparisonOp) == false)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.dicFldComparisonOp.ContainsKey(con{0}.{1}) == false)",
                objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.dicFldComparisonOp.Add(con{0}.{1}, strComparisonOp);",
                objPrjTabENEx.TabName,
                objField.ObjFieldTabENEx.FldName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.dicFldComparisonOp[con{0}.{1}] = strComparisonOp;", objPrjTabENEx.TabName,
                objField.ObjFieldTabENEx.FldName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "return obj{0}EN;", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n	}");


        }

        public string Gen_4WA_Static_SetFieldValue()
        {
            StringBuilder strBuilder = new StringBuilder();

            objPrjTabENEx.arrFldSet.ForEach(obj => Gen_4WA_Static_SetFieldValue4OneField(obj, strBuilder));

            return strBuilder.ToString();
        }
        public string Gen_4WA_ReFreshThisCache()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ˢ�±����еĻ���.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n" + "public static void ReFreshThisCache()");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "string strMsg;");
            strBuilder.Append("\r\n" + "if (clsSysParaEN.spSetRefreshCacheOn == true)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
          objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"ˢ1�»���ɹ�!({{2}}->{{1}}->{{0}})\",");
            //strBuilder.Append("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            //strBuilder.Append("\r\n" + "clsStackTrace.GetCurrClassFunctionByLevel(2),");
            //strBuilder.Append("\r\n" + "clsStackTrace.GetCurrClassFunctionByLevel(3)); ");
            //strBuilder.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strMsg = string.Format(\"ˢ�»����Ѿ��رա�(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})\",");
            strBuilder.Append("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.Append("\r\n" + "clsStackTrace.GetCurrClassFunctionByLevel(2),");
            strBuilder.Append("\r\n" + "clsStackTrace.GetCurrClassFunctionByLevel(3));");
            strBuilder.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg);");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="objViewInfoENEx"></param>
        /// <returns></returns>
        public string Gen_4WA_Static_CombineConditionByCondObj()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// �������������е��ֶ�������ϳ�һ��������");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <returns>������(strWhereCond)</returns>");
                strCodeForCs.AppendFormat("\r\n" + "public static string GetCombineCondition(this cls{0}EN obj{0}Cond)", objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//ʹ�������ĳ�ֵΪ\"1 = 1\",�Ա��ڸô��ĺ�����\"and \"�����������,");
                strCodeForCs.Append("\r\n" + "//���� 1 = 1 && UserName = '����'");
                strCodeForCs.Append("\r\n" + "string strWhereCond = \" 1 = 1 \";");
                strCodeForCs.Append("\r\n" + "//����������ؼ������ݲ�Ϊ��,�����һ����������ӵ����������С�");


                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {

                    switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeId) //objEditRegionFldsEx.objCtlType.CtlTypeName
                    {
                        case enumDataTypeAbbr.bit_03:
                            strCodeForCs.AppendFormat("\r\n" + "if (obj{0}Cond.IsUpdated(con{0}.{1}) == true)",
                                 objPrjTabENEx.TabName,
                                        objField.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "if (obj{0}Cond.{1} == true)",
                                        objPrjTabENEx.TabName,
                                        objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));
                            strCodeForCs.Append("\r\n" + "{");


                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '1'\", con{1}.{0});",
                                     objField.ObjFieldTabENEx.FldName,
                                     objPrjTabENEx.TabName,
                                     "{", "}");
                            strCodeForCs.Append("\r\n" + "}");

                            strCodeForCs.AppendFormat("\r\n" + "else");
                            strCodeForCs.Append("\r\n" + "{");

                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} = '0'\", con{1}.{0});",
                                 objField.ObjFieldTabENEx.FldName,
                                     objPrjTabENEx.TabName,
                                    "{", "}");
                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "}");

                            break;

                        case enumDataTypeAbbr.char_04:
                        case enumDataTypeAbbr.varchar_25:
                        case enumDataTypeAbbr.nvarchar_15:
                            strCodeForCs.AppendFormat("\r\n" + "if (obj{0}Cond.IsUpdated(con{0}.{1}) == true)",
                      objPrjTabENEx.TabName,
                             objField.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "string strComparisonOp{1} = obj{0}Cond.dicFldComparisonOp[con{0}.{1}];",
                                objPrjTabENEx.TabName,
                                objField.ObjFieldTabENEx.FldName);

                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} {{2}} '{{1}}'\", con{1}.{0}, obj{1}Cond.{2}, strComparisonOp{0});",
                                objField.ObjFieldTabENEx.FldName,
                                objPrjTabENEx.TabName,
                                objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));

                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case enumDataTypeAbbr.datetime_05:
                            strCodeForCs.AppendFormat("\r\n" + "if (obj{0}Cond.IsUpdated(con{0}.{1}) == true)",
                      objPrjTabENEx.TabName,
                             objField.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "string strComparisonOp{1} = obj{0}Cond.dicFldComparisonOp[con{0}.{1}];",
                                objPrjTabENEx.TabName,
                                objField.ObjFieldTabENEx.FldName);

                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} {{2}} '{{1}}'\", con{1}.{0}, obj{1}Cond.{2}, strComparisonOp{0});",
                                objField.ObjFieldTabENEx.FldName,
                                objPrjTabENEx.TabName,
                                objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));

                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case enumDataTypeAbbr.decimal_06:
                        case enumDataTypeAbbr.float_07:
                        case enumDataTypeAbbr.int_09:
                        case enumDataTypeAbbr.bigint_01:
                        case enumDataTypeAbbr.bigintidentity_26:


                            strCodeForCs.AppendFormat("\r\n" + "if (obj{0}Cond.IsUpdated(con{0}.{1}) == true)",
                      objPrjTabENEx.TabName,
                             objField.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "string strComparisonOp{1} = obj{0}Cond.dicFldComparisonOp[con{0}.{1}];",
                                objPrjTabENEx.TabName,
                                objField.ObjFieldTabENEx.FldName);

                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += string.Format(\" And {{0}} {{2}} {{1}}\", con{1}.{0}, obj{1}Cond.{2}, strComparisonOp{0});",
                                objField.ObjFieldTabENEx.FldName,
                                objPrjTabENEx.TabName,
                                objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));

                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        default:
                            strCodeForCs.AppendFormat("\r\n" + "//��������{0}({1})�ں���:[{2}]��û�д���!",
                                  objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName,
                                  clsStackTrace.GetCurrClassFunction());
                            break;
                    }
                }

                strCodeForCs.Append("\r\n" + " return strWhereCond;");

                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }
        public string Gen_4WA_Static_UpdateNode()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "UpdateNode_Static", "�޸ļ�¼ʱ�ؼ��ֲ���Ϊ��!", "���ɴ���");

            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// ����:ͨ��SQL�������޸ļ�¼,�÷�ʽ���Ż���ʽ");
            strBuilder.Append("\r\n /// /// �ŵ�:1���ܹ������ֶ��еĵ�Ʋ���⣻2���ܹ��������ֶ�,��ֻ���޸Ĺ����ֶβ���Ҫ�޸�ͬ�������ݿ�.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵ�ʵ�����</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>����޸ĳɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool UpdateNode(this cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "bool")
            {
                if (IsNumberType4Key == true)
                {
                    strBuilder.AppendFormat("\r\n" + " if (obj{0}EN.{1} == 0)",
                     objPrjTabENEx.TabName, objKeyField.FldName);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true)",
                        objPrjTabENEx.TabName, objKeyField.FldName);
                }
                strBuilder.Append("\r\n" + " {");

                strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{0})�޸ļ�¼ʱ�ؼ��ֲ���Ϊ��!(from {{0}})\\r\\n\",", strErrId);
                strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");
                strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");
                strBuilder.Append("\r\n" + " }");
            }
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "obj{0}EN.sfUpdFldSetStr = obj{0}EN.getsfUpdFldSetStr();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.CheckPropertyNew(); ", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "bool bolResult = {0}_UpdateNode(obj{0}EN);",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "  //�����޸ļ�¼���¼�");
            //strBuilder.Append("\r\n" + "try");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "    onUpdateNode?.Invoke(obj{0}EN);", TabName);
            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "catch (Exception objException)");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "string strMsg2 = string.Format(\"�ڵ����޸ļ�¼�����¼�ʱ��������{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg2);");
            //strBuilder.Append("\r\n" + "throw new Exception(strMsg2);");
            //strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���������ػ���,��Լ�¼����,��Ϊ���������ʹ��");
            strBuilder.AppendFormat("\r\n" + "{0}_ReFreshCache();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "UpdateNode_Static", "�޸Ľ�����!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{0})�޸Ľ�����,{{1}}!(from {{0}})\",", strErrId);
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        public string Gen_4WA_Static_AddNewNode()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// ����:ͨ��SQL�����������¼,�÷�ʽ���Ż���ʽ");
            strBuilder.Append("\r\n /// /// �ŵ�:1���ܹ������ֶ��еĵ�Ʋ���⣻2���ܹ�ʹ�ֶ�ֵΪNULL���ֶ��������");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵ�ʵ�����</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>�������ɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool AddNewNode(this cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

            if (objKeyField.PrimaryTypeId != enumPrimaryType.StringAutoAddPrimaryKey_03
                && objKeyField.PrimaryTypeId != enumPrimaryType.Identity_02
                && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "bool"
                && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "int"
                 && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "long")
            {
                strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true)",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.Append("\r\n" + " {");
                strBuilder.Append("\r\n" + "string strMsg = string.Format(\"��Ӽ�¼ʱ,�ؼ��ֲ���Ϊ��!(from {0})\\r\\n\", ");
                strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");
                strBuilder.Append("\r\n throw new Exception(strMsg);");

                strBuilder.Append("\r\n" + " }");

                strBuilder.AppendFormat("\r\n" + " if ({0}_IsExist({1}) == true)",
                   objPrjTabENEx.TabName, strKeyFldName_ObjName);
                strBuilder.Append("\r\n" + " {");
                strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"��Ӽ�¼ʱ,�ؼ���:[{{0}}]�Ѿ�����!(from {{1}})\\r\\n\", obj{0}EN.{1}, ",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");
                strBuilder.Append("\r\n throw new Exception(strMsg);");
                strBuilder.Append("\r\n" + " }");
            }

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
            {
                strBuilder.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true || {0}_IsExist({2}) == true)",
                    objPrjTabENEx.TabName, objKeyField.FldName, strKeyFldName_ObjName);
                strBuilder.Append("\r\n" + " {");
                strBuilder.AppendFormat("\r\n" + "     obj{0}EN.{1} = {0}GetMaxStrId();",
                    objPrjTabENEx.TabName, objKeyField.FldName);
                strBuilder.Append("\r\n" + " }");
            }
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.CheckPropertyNew(); ", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "bool bolResult = {0}_AddNewNode(obj{0}EN);",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "  //��������¼�¼���¼�");
            //strBuilder.Append("\r\n" + "try");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "    onAddNewNode?.Invoke(obj{0}EN);", TabName);
            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "catch (Exception objException)");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "string strMsg2 = string.Format(\"�ڵ�����Ӽ�¼�����¼�ʱ��������{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg2);");
            //strBuilder.Append("\r\n" + "throw new Exception(strMsg2);");
            //strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���������ػ���,��Լ�¼����,��Ϊ���������ʹ��");
            strBuilder.AppendFormat("\r\n" + "{0}_ReFreshCache();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "AddNewNode_Static", "����̬��Ӽ�¼����!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{0})��Ӽ�¼����, {{1}}.(from {{0}})\",", strErrId);
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{22})��Ӽ�¼����!({1}:AddNewNodeBySql2)\\r\\n\" + objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"��Ӽ�¼����!({1}: AddNewNodeBySQL2)\\r\\n\" + objException.Message);",
            //   objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4WA_Static_AddNewNodeWithMaxId()
        {
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "string") return "";
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// ����:ͨ��SQL�����������¼,���йؼ���Ϊ���л�ȡ�����ֵ. �÷�ʽ���Ż���ʽ");
            strBuilder.Append("\r\n /// /// �ŵ�:1���ܹ������ֶ��еĵ�Ʋ���⣻2���ܹ�ʹ�ֶ�ֵΪNULL���ֶ��������");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵ�ʵ�����</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <returns>�������ɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool AddNewNodeWithMaxId(this cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");

          
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.CheckPropertyNew(); ", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}EN.AddNewNodeWithMaxId();",
            objPrjTabENEx.TabName);
            //strBuilder.Append("\r\n" + "  //��������¼�¼���¼�");
            //strBuilder.Append("\r\n" + "try");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.AppendFormat("\r\n" + "    onAddNewNode?.Invoke(obj{0}EN);", TabName);
            //strBuilder.Append("\r\n" + "}");
            //strBuilder.Append("\r\n" + "catch (Exception objException)");
            //strBuilder.Append("\r\n" + "{");
            //strBuilder.Append("\r\n" + "string strMsg2 = string.Format(\"�ڵ�����Ӽ�¼�����¼�ʱ��������{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
            //strBuilder.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg2);");
            //strBuilder.Append("\r\n" + "throw new Exception(strMsg2);");
            //strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���������ػ���,��Լ�¼����,��Ϊ���������ʹ��");
            strBuilder.AppendFormat("\r\n" + "{0}_ReFreshCache();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "AddNewNodeWithMaxId_Static", "����̬��Ӽ�¼����!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{0})��Ӽ�¼����, {{1}}.(from {{0}})\",", strErrId);
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{22})��Ӽ�¼����!({1}:AddNewNodeBySql2)\\r\\n\" + objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"��Ӽ�¼����!({1}: AddNewNodeBySQL2)\\r\\n\" + objException.Message);",
            //   objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_4WA_Static_UpdateWithCondition()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// /// ����:ͨ��SQL�������޸ļ�¼,�÷�ʽ�Ƿ��Ż���ʽ,���������޸ļ�¼");
            strBuilder.Append("\r\n /// /// ȱ��:1�����ܴ����ֶ��еĵ�Ʋ���⣻2�����ܴ������ֶ�,��ֻ���޸Ĺ����ֶβ���Ҫ�޸�ͬ�������ݿ�.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ�޸ĵĶ���</param>", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n /// <param name = \"strWhereCond\">�޸ļ�¼ʱ������</param>");
            strBuilder.Append("\r\n /// <returns>����޸ĳɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strBuilder.AppendFormat("\r\n" + "public static bool UpdateWithCondition(this cls{0}EN obj{0}EN, string strWhereCond)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.CheckPropertyNew(); ", objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}EN.UpdateWithCondition(strWhereCond);",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "// ��̬�Ķ����б�,���������ػ���,��Լ�¼����,��Ϊ���������ʹ��");
            strBuilder.AppendFormat("\r\n" + "{0}_ReFreshCache();", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "return bolResult;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
        objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "UpdateWithCondition_Static", "���������޸ļ�¼����!", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{0})���������޸ļ�¼����, {{1}}.(from {{0}})\\r\\n\",", strErrId);
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }
        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_GetObjLstCache()
        {
            if (objPrjTabENEx.IsUseCache == false) return "//�ñ���Ҫʹ��Cache;";
            if (objPrjTabENEx.IsUseCache_TS() == false) return $"//�ñ�û��ʹ��Cache,����Ҫ����[GetObjLstCache()]����;(in {clsStackTrace.GetCurrClassFunction()})";

            StringBuilder strBuilder = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;

            strBuilder.AppendFormat("\r\n /// <summary>");
            strBuilder.AppendFormat("\r\n /// �ӻ����л�ȡ���ж����б�.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.AppendFormat("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <returns>�ӻ����л�ȡ�����ж����б�</returns>");
            strBuilder.AppendFormat("\r\n" + "public static List<cls{0}EN> GetObjLstCache()",
            objPrjTabENEx.TabName,
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
            objKeyField.PrivFuncName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//��ʼ���б���");
            //strBuilder.Append("\r\n" + "InitListCache(); ");

            strBuilder.AppendFormat("\r\n" + "return arr{0}ObjLstCache;",
              objPrjTabENEx.TabName);
            //strBuilder.AppendFormat("\r\n" + "return null;");
            strBuilder.Append("\r\n" + "}");

            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strBuilder.ToString();
        }

        public string Gen_4WA_ReFreshCache()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ˢ�»���.�ѵ�ǰ��Ļ����Լ��ñ������ͼ�Ļ������.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n" + "public static void ReFreshCache()");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "  if (clsSysParaEN.spIsUseQueue4Task == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (clsSysParaEN.arrFunctionLst4Queue == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();");
            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "clsDynamicFunction objDynamicFunction = new clsDynamicFunction()");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "NameSpace = \"{0}.BusinessLogic\",", objProjectsENEx.PrjDomain);
            //strCodeForCs.AppendFormat("\r\n" + "ClassName = \"cls{0}BL\",", objPrjTabENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "AssemblyType = typeof({0}.BusinessLogic.cls{1}BL),", objProjectsENEx.PrjDomain, objPrjTabENEx.TabName);
            //strCodeForCs.Append("\r\n" + "FunctionName = clsStackTrace.GetCurrFunction()");
            //strCodeForCs.Append("\r\n" + "};");

            //strCodeForCs.Append("\r\n" + "if (clsDynamicFunction.IsExistSameFunction(clsSysParaEN.arrFunctionLst4Queue, objDynamicFunction) == true)");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "return;");
            //strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "clsSysParaEN.arrFunctionLst4Queue.Enqueue(objDynamicFunction);");
            //strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "if ({0}_objCommFun4BL != null) ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + " string strMsg = string.Format(\"ˢ1�»���ɹ�!({{2}}->{{1}}->{{0}})\",", "{", "}");
            //strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            //strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunctionByLevel(2),");
            //strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunctionByLevel(3)); ");
            //strCodeForCs.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg);");

            strCodeForCs.Append("\r\n" + "// ��̬�Ķ����б�,���������ػ���,��Լ�¼����,��Ϊ���������ʹ��");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
                   objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "{0}_objCommFun4BL.ReFreshCache();",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        public string Gen_4WA_Static_GetConditionString4Constraint()
        {
            int intVerCount = 1;
            StringBuilder strBuilder = new StringBuilder();
            //�������ĳ����(������)�Ƿ�Ψһ-------------------------------------------;
            foreach (clsPrjConstraintEN objInFor in objPrjTabENEx.arrPrjConstraintSet())
            {
                if (objInFor.InUse == false) continue;
                string strVersion = "";
                if (intVerCount > 1) strVersion = string.Format($"_V{intVerCount}"); intVerCount++;
                
                IEnumerable<clsConstraintFieldsEN> arrObjLst_Flds = clsConstraintFieldsBLEx.GetObjLstByPrjConstraintIdCache(objInFor.PrjConstraintId, objInFor.PrjId); 
                switch (objInFor.ConstraintTypeId)
                {
                    case enumConstraintType.Uniqueness_01:

                        strBuilder.Append("\r\n /// <summary>");
                        strBuilder.AppendFormat("\r\n /// ��ȡΨһ��������--{0}({1}), ���ɶ�����Ψһ�������ֶιؼ�����ֵ��ɵ�������",
                                                  objPrjTabENEx.TabName, objPrjTabENEx.TabCnName);
                        strBuilder.Append($"\r\n /// Ψһ������:{objInFor.ConstraintName4GC()}");
                        strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                        strBuilder.Append("\r\n /// </summary>");
                        strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">Ҫ��Ψһ�Ķ���</param>",
                               objPrjTabENEx.TabName, objPrjTabENEx.TabCnName);
                        strBuilder.Append("\r\n /// <returns></returns>");
                        strBuilder.Append($"\r\npublic static string GetUniConditionStr{strVersion}(this cls{ThisTabName4GC}EN obj{ThisTabName4GC}EN)");
                        strBuilder.Append("\r\n{");
                        strBuilder.Append("\r\n" + "//����¼�Ƿ����");

                        //strBuilder.Append("\r\n" + "bool bolIsUniqueness;");
                        strBuilder.Append("\r\nStringBuilder sbCondition = new StringBuilder();");

                        strBuilder.AppendFormat("\r\n" + "if (obj{0}EN == null) return \"\";",
                        objPrjTabENEx.TabName);

                        switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                        {
                            case "int":
                            case "long":
                            case "short":
                                strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1} == 0)",
                                objPrjTabENEx.TabName,
                                objKeyField.PropertyName(this.IsFstLcase));
                                break;
                            case "string":
                                strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1} == null || obj{0}EN.{1} == \"\")",
                                objPrjTabENEx.TabName,
                                objKeyField.PropertyName(this.IsFstLcase));
                                break;
                            default:
                                strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.{1} == null || obj{0}EN.{1} == \"\")",
                                objPrjTabENEx.TabName,
                                objKeyField.PropertyName(this.IsFstLcase));
                                break;
                        }
                        strBuilder.Append("\r\n" + "{");

                  

                        strBuilder.AppendFormat("\r\nsbCondition.AppendFormat(\"1 = 1\");",
                           objKeyField.FldName,
                           objKeyField.PrivFuncName,
                           "{", "}");

                        foreach (clsConstraintFieldsEN objField in arrObjLst_Flds)
                        {

                            strBuilder.AppendFormat("\r\n sbCondition.AppendFormat(\" and {0} = '{{0}}'\", obj{1}EN.{0});",
                                        objField.ObjFieldTab().FldName,
                                        objPrjTabENEx.TabName);
                        }
                        strBuilder.AppendFormat("\r\nreturn sbCondition.ToString();",
                                objPrjTabENEx.TabName);


                        strBuilder.Append("\r\n}");

                        //bool bolIsFirst = true;


                        strBuilder.Append("\r\n else {");

                        if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == false)
                        {
                            strBuilder.AppendFormat("\r\nsbCondition.AppendFormat(\"{0} !=  {{0}}\", obj{1}EN.{0});",
                               objKeyField.FldName,
                               objPrjTabENEx.TabName);
                        }
                        else
                        {
                            strBuilder.AppendFormat("\r\nsbCondition.AppendFormat(\"{0} !=  '{{0}}'\", obj{1}EN.{0});",
                               objKeyField.FldName,
                               objPrjTabENEx.TabName);
                        }
                        foreach (clsConstraintFieldsEN objField in arrObjLst_Flds)
                        {

                            strBuilder.AppendFormat("\r\n sbCondition.AppendFormat(\" and {0} = '{{0}}'\", obj{1}EN.{0});",
                                        objField.ObjFieldTab().FldName,
                                        objPrjTabENEx.TabName);
                        }
                        strBuilder.AppendFormat("\r\n return sbCondition.ToString();",
                                objPrjTabENEx.TabName);
                        strBuilder.Append("\r\n}");

                        strBuilder.Append("\r\n" + "}");
                        break;

                    case enumConstraintType.MaxMinValue_02:

                        //strBuilder.Append("\r\n /// <summary>");
                        //strBuilder.AppendFormat("\r\n /// ��������Сֵ(MaxMinValue)--{0}({1}), ����������ֵ,�ͷ���False; ���������Сֵ,�ͷ���False; ",
                        //  objPrjTabENEx.TabName, objPrjTabENEx.TabCnName);
                        //strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                        //strBuilder.Append("\r\n /// </summary>");
                        //strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">Ҫ���������ֵ�Ķ���</param>",
                        //       objPrjTabENEx.TabName, objPrjTabENEx.TabCnName);
                        //strBuilder.Append("\r\n /// <returns></returns>");
                        //strBuilder.AppendFormat("\r\npublic static bool CheckMaxMinValue_{1}(this cls{0}EN obj{0}EN)",
                        //             objPrjTabENEx.TabName, objInFor.ConstraintName4GC());
                        //strBuilder.Append("\r\n{");

                        //strBuilder.Append("\r\n" + "bool bolResult;");

                        //strBuilder.AppendFormat("\r\n" + "if (obj{0}EN == null) return true;",
                        //objPrjTabENEx.TabName);

                        //foreach (clsConstraintFieldsEN objField in arrObjLst_Flds)
                        //{
                        //    if (string.IsNullOrEmpty(objField.MaxValue) == false)
                        //    {
                        //        strBuilder.AppendFormat("\r\n " + "if (obj{1}EN.{0}> {2}) bolResult = false;",
                        //                    objField.ObjFieldTabENEx.FldName,
                        //                    objPrjTabENEx.TabName, objField.MaxValue);
                        //    }
                        //    if (string.IsNullOrEmpty(objField.MinValue) == false)
                        //    {
                        //        strBuilder.AppendFormat("\r\n " + "if (obj{1}EN.{0}< {2}) bolResult = false;",
                        //               objField.ObjFieldTabENEx.FldName,
                        //               objPrjTabENEx.TabName, objField.MinValue);
                        //    }

                        //}

                        //strBuilder.Append("\r\n" + "return true;");

                        //strBuilder.Append("\r\n" + "}");
                        break;


                }
            }

            ///�������ĳ����(������)�Ƿ�Ψһ == == == == == == == == = ;
            return strBuilder.ToString();
        }

        public string Gen_4WA_Static_CheckProperty4Condition()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///������������Ƿ���ȷ-------------------------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �������ֶ�ֵ����֯��ѯ����ʱ�Ƿ�Ϸ�,1)����Ƿ������ = ���� and ��;2)����ֶ�ֵ�����Ƿ񳬳�,���������׳�����.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\npublic static void CheckProperty4Condition(this cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            //����¼�Ƿ����

            ///������Գ��ȴ���;
            string strFunctionName = string.Format("CheckProperty4Condition", objPrjTabENEx.TabName, objKeyField.FldName);
            string strExplanation = "�ֶ�[{2}({3})|{0}({4})]�ĳ��Ȳ��ܳ���{1}!ֵ:{{0}}";
            string strErrId1 = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strExplanation = "�ֶ�[{2}({3})|{0}({4})]�Ĳ��ܰ����� = ��!ֵ:{{0}}";
            string strErrId2 = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strExplanation = "�ֶ�[{2}({3})|{0}({4})]�Ĳ��ܰ����� and��!ֵ:{{0}}";
            string strErrId3 = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");

            strExplanation = "�ֶ�[{2}({3})|{0}({4})]�Ĳ��ܰ�����and ��!ֵ:{{0}}";
            string strErrId4 = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");
            strBuilder.AppendFormat("\r\n" + "//����ֶγ���");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);

                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                    && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string"
                    && objField.ObjFieldTabENEx.FldLength > 0)
                {

                    strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldLen({0}, {1}, con{2}.{3});",
                        strPrivPropNameWithObjectName,
                        objField.ObjFieldTabENEx.FldLength,
                        objPrjTabENEx.TabName,
                        objField.ObjFieldTabENEx.FldName);
                }
            }
            strBuilder.AppendFormat("\r\n" + "//���Sqlע��");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);

                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                    && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string"
                    && objField.ObjFieldTabENEx.FldLength > 0)
                {

                    //  strBuilder.AppendFormat("\r\n" + "//���Sqlע��");
                    strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckSqlInjection4Field({0}, con{1}.{2});",
                      strPrivPropNameWithObjectName,
                      objPrjTabENEx.TabName,
                      objField.ObjFieldTabENEx.FldName);


                }
            }
            strBuilder.AppendFormat("\r\n" + "//�������ֶγ���");

            ///�������ֶγ���;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.IsTabForeignKey == false) continue;//����������,�Ͳ���Ҫ���
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);

                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                    && objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName == "char" && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldForeignKey({0}, {1}, con{2}.{3});",
                     strPrivPropNameWithObjectName,
                     objField.ObjFieldTabENEx.FldLength,
                     objPrjTabENEx.TabName,
                     objField.ObjFieldTabENEx.FldName);

                }
            }
            strBuilder.AppendFormat("\r\n obj{0}EN._IsCheckProperty = true;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n}");

            ///������������Ƿ���ȷ == == ;
            return strBuilder.ToString();
        }
        public string Gen_4WA_Static_CheckPropertyNew()
        {
            StringBuilder strBuilder = new StringBuilder();
            ///������������Ƿ���ȷ-------------------------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �������ֶ�ֵ�Ƿ�Ϸ�,1)����Ƿ�ɿ�;2)����ֶ�ֵ�����Ƿ񳬳�,���������׳�����.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\npublic static void CheckPropertyNew(this cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");

            //����¼�Ƿ����
            string strFunctionName = string.Format("CheckPropertyNew[{2}]",
             objPrjTabENEx.TabName, objKeyField.FldName, this.strDataBaseType);
            string strExplanation = "�ֶ�[{1}|{0}]����Ϊ��(NULL)!";
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");
            strBuilder.AppendFormat("\r\n" + "//����ֶβ���Ϊ��(NULL)");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);

                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");

                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//ֻ���Ͳ���Ҫ���
                if (objField.IsTabNullable == false && objField.FieldTypeId != "02")
                {
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte[]" || objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte")
                    {
                        continue;
                    }

                    if (objField.FldOpTypeId == "0003")
                    {
                        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldNotNull({0}, con{2}.{3});",
                   strPrivPropNameWithObjectName,
                   objField.ObjFieldTabENEx.FldLength,
                   objPrjTabENEx.TabName,
                   objField.ObjFieldTabENEx.FldName);
                        //strBuilder.AppendFormat("\r\nif (Object.Equals(null, {0}) ",
                        //    strPrivPropNameWithObjectName4Get);
                        //strBuilder.AppendFormat("\r\n|| (!Object.Equals(null, {0}) && {0}.ToString()  ==  \"\")",
                        //    strPrivPropNameWithObjectName4Get );
                        //if (string.IsNullOrEmpty(objField.ObjFieldTabENEx.CodeTabId) != true)
                        //{
                        //    strBuilder.AppendFormat("\r\n|| (!Object.Equals(null, {0}) && {0}.ToString()  ==  \"0\")",
                        //         strPrivPropNameWithObjectName4Get );
                        //}
                        //strBuilder.Append(")");
                        //strBuilder.Append("\r\n{");
                        //strBuilder.AppendFormat("\r\n throw new clsDbObjException(\"(errid:{2})�ֶ�[{1}|{0}]����Ϊ��(NULL)!(cls{3}DA:CheckPropertyNew)\");",
                        //        objField.ColCaption,
                        //        objPrjTabENEx.TabCnName,
                        //        strErrId,
                        //        objPrjTabENEx.TabName);
                        //strBuilder.Append("\r\n}");
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldNotNull({0}, con{2}.{3});",
                  strPrivPropNameWithObjectName,
                  objField.ObjFieldTabENEx.FldLength,
                  objPrjTabENEx.TabName,
                  objField.ObjFieldTabENEx.FldName);
                        //strBuilder.AppendFormat("\r\nif (Object.Equals(null, {0}) ",
                        //    strPrivPropNameWithObjectName );
                        //strBuilder.AppendFormat("\r\n|| (!Object.Equals(null, {0}) && {0}.ToString()  ==  \"\")",
                        //     strPrivPropNameWithObjectName );
                        //if (string.IsNullOrEmpty(objField.ObjFieldTabENEx.CodeTabId) != true)
                        //{
                        //    strBuilder.AppendFormat("\r\n|| (!Object.Equals(null, {0}) && {0}.ToString()  ==  \"0\")",
                        //         strPrivPropNameWithObjectName );
                        //}
                        //strBuilder.Append(")");
                        //strBuilder.Append("\r\n{");
                        //strBuilder.AppendFormat("\r\n throw new clsDbObjException(\"(errid:{2})�ֶ�[{1}|{0}]����Ϊ��(NULL)!(cls{3}DA:CheckPropertyNew)\");",
                        //            objField.ColCaption,
                        //            objPrjTabENEx.TabCnName,
                        //            strErrId,
                        //            objPrjTabENEx.TabName);
                        //strBuilder.Append("\r\n}");
                    }
                }


            }
            //������Գ��ȴ���;

            strFunctionName = string.Format("CheckPropertyNew1", objPrjTabENEx.TabName, objKeyField.FldName);
            strExplanation = "�ֶ�[{2}({3})|{0}({4})]�ĳ��Ȳ��ܳ���{1}!ֵ:{{0}}";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");
            strBuilder.AppendFormat("\r\n" + "//����ֶγ���");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");

                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//ֻ���Ͳ���Ҫ���
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                    && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string"
                    && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    if (objField.FldOpTypeId == "0003")
                    {
                        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldLen({0}, {1}, con{2}.{3});",
                 strPrivPropNameWithObjectName,
                 objField.ObjFieldTabENEx.FldLength,
                 objPrjTabENEx.TabName,
                 objField.ObjFieldTabENEx.FldName);
                        //strBuilder.AppendFormat("\r\nif (!Object.Equals(null, {0}) && GetStrLen({0}) > {1})", strPrivPropNameWithObjectName4Get, objField.ObjFieldTabENEx.FldLength);
                        //strBuilder.Append("\r\n{");
                        //strBuilder.AppendFormat("\r\n throw new clsDbObjException(string.Format(\"(errid:{7})�ֶ�[{2}({3})|{0}({4})]�ĳ��Ȳ��ܳ���{1}!ֵ:{{0}}(cls{3}DA:CheckPropertyNew)\", obj{3}EN.{4}));",
                        //objField.ColCaption,
                        //objField.ObjFieldTabENEx.FldLength.ToString().Trim(),
                        //objPrjTabENEx.TabCnName,
                        //objPrjTabENEx.TabName,
                        //objField.ObjFieldTabENEx.FldName,
                        //"{", "}",
                        //strErrId);
                        // strBuilder.Append("\r\n}");
                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldLen({0}, {1}, con{2}.{3});",
                             strPrivPropNameWithObjectName,
                            objField.ObjFieldTabENEx.FldLength,
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName);

                    }
                }
            }

            //�������ֶγ���;

            strFunctionName = string.Format("CheckPropertyNew2", objPrjTabENEx.TabName, objKeyField.FldName);
            strExplanation = "�ֶ�[{2}|{0}]��Ϊ����ֶ�,����Ӧ��Ϊ{1}!";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");
            strBuilder.AppendFormat("\r\n" + "//����ֶ�����̶�����");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");

                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//ֻ���Ͳ���Ҫ���
                if (objField.IsTabForeignKey == false) continue;//����������,�Ͳ���Ҫ���
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                    && objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName == "char" && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    if (objField.FldOpTypeId == "0003")
                    {
                        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldForeignKey({0}, {1}, con{2}.{3});",
                   strPrivPropNameWithObjectName,
                   objField.ObjFieldTabENEx.FldLength,
                   objPrjTabENEx.TabName,
                   objField.ObjFieldTabENEx.FldName);

                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldForeignKey({0}, {1}, con{2}.{3});",
                   strPrivPropNameWithObjectName,
                   objField.ObjFieldTabENEx.FldLength,
                   objPrjTabENEx.TabName,
                   objField.ObjFieldTabENEx.FldName);

                    }
                }
            }
      
            strBuilder.AppendFormat("\r\n obj{0}EN._IsCheckProperty = true;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n}");

            ///������������Ƿ���ȷ-------------------------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// רҵ����޸ļ�¼,�������ֶ�ֵ�Ƿ�Ϸ�,1)����ֶ�ֵ�����Ƿ񳬳�,���������׳�����.");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\npublic static void CheckProperty4Update(this cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            //������Գ��ȴ���;
            strFunctionName = string.Format("CheckProperty4Update", objPrjTabENEx.TabName, objKeyField.FldName);
            strExplanation = "�ֶ�[{2}({3})|{0}({4})]�ĳ��Ȳ��ܳ���{1}!ֵ:{{0}}";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");
            strBuilder.AppendFormat("\r\n" + "//����ֶγ���");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");

                if (objField.FieldTypeId == enumFieldType.KeyField_02) continue;
                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//ֻ���Ͳ���Ҫ���
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                    && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string"
                    && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    if (objField.FldOpTypeId == "0003")
                    {
                        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldLen({0}, {1}, con{2}.{3});",
                         strPrivPropNameWithObjectName,
                        objField.ObjFieldTabENEx.FldLength,
                      objPrjTabENEx.TabName,
                      objField.ObjFieldTabENEx.FldName);


                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldLen({0}, {1}, con{2}.{3});",
                         strPrivPropNameWithObjectName,
                        objField.ObjFieldTabENEx.FldLength,
                      objPrjTabENEx.TabName,
                      objField.ObjFieldTabENEx.FldName);

                    }
                }
            }
            ///�������ֶγ���;
            strFunctionName = string.Format("CheckProperty4Update", objPrjTabENEx.TabName, objKeyField.FldName);
            strExplanation = "�ֶ�[{2}|{0}]��Ϊ����ֶ�,����Ӧ��Ϊ{1}!";
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
               objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, strFunctionName, strExplanation, "���ɴ���");
            strBuilder.AppendFormat("\r\n" + "//�������ֶγ���");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);
                string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");

                if (objField.FldOpTypeId == "0002" || objField.FldOpTypeId == "0004") continue;//ֻ���Ͳ���Ҫ���
                if (objField.IsTabForeignKey == false) continue;//����������,�Ͳ���Ҫ���
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
                    && objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName == "char" && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    if (objField.FldOpTypeId == "0003")
                    {
                        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldForeignKey({0}, {1}, con{2}.{3});",
                   strPrivPropNameWithObjectName,
                   objField.ObjFieldTabENEx.FldLength,
                   objPrjTabENEx.TabName,
                   objField.ObjFieldTabENEx.FldName);

                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n" + "clsCheckSql.CheckFieldForeignKey({0}, {1}, con{2}.{3});",
                   strPrivPropNameWithObjectName,
                   objField.ObjFieldTabENEx.FldLength,
                   objPrjTabENEx.TabName,
                   objField.ObjFieldTabENEx.FldName);

                    }
                }
            }
         
            strBuilder.AppendFormat("\r\n obj{0}EN._IsCheckProperty = true;", objPrjTabENEx.TabName);

            strBuilder.Append("\r\n}");
            ///������������Ƿ���ȷ == == ;
            return strBuilder.ToString();
        }
        public string Gen_4BL_DefineObjCommFun4BL()
        {

            StringBuilder strCodeForCs = new StringBuilder();

            ///�๹����----------------------------------------------;
            strCodeForCs.Append("\r\n" + " /// <summary>");
            strCodeForCs.Append("\r\n" + "/// ר�����߼������ڴ�����ȹ��������Ķ���");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "/// </summary>");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.Append("\r\n" + "public static clsCommFun4BL objCommFun4BL = null;");
            }
            else
            {
                strCodeForCs.Append("\r\n" + "public static clsCommFun4BLV2 objCommFun4BL = null;");
            }
            //strCodeForCs.Append("\r\n" + "public static event OnAddNewNode onAddNewNode;");
            //strCodeForCs.Append("\r\n" + "public static event OnUpdateNode onUpdateNode;");
            //strCodeForCs.Append("\r\n" + "public static event OnDeleteNode onDelNode;");

            return strCodeForCs.ToString();
        }
        public string Gen_4WA_GetDataTableByObjLst()
        {
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ���ݶ����б��ȡDataTable");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"arrObjLst\">�����Ķ����б�</param>");
            strBuilder.Append("\r\n /// <returns>����DataTable</returns>");
            strBuilder.AppendFormat("\r\n" + "public static DataTable GetDataTableByObjLst(List<cls{0}EN> arrObjLst)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataTable objDT = new DataTable();");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strBuilder.AppendFormat("\r\n" + "objDT.Columns.Add(con{0}.{1}, Type.GetType(\"{2}\"));",
                    objPrjTabENEx.TabName, objField.FldName,
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.NetSysType);
            }
            strBuilder.AppendFormat("\r\n" + "foreach (cls{0}EN objInFor in arrObjLst)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "DataRow objDR = objDT.NewRow();");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strBuilder.AppendFormat("\r\n" + "objDR[con{0}.{1}] = objInFor[con{0}.{1}];",
                    objPrjTabENEx.TabName, objField.FldName);
            }
            strBuilder.Append("\r\n" + "objDT.Rows.Add(objDR);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "return objDT;");
            strBuilder.Append("\r\n" + "}");

            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strBuilder.ToString();
        }
        public string Gen_4BL_SetUpdFlag_S()
        {
            if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlView_02) return "";
            StringBuilder strBuilder = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �����޸ı�־,�������ֶ��޸ı�־�ַ�����ȡ��һ���ֶ��Ѿ����޸�");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}EN\">Դ�򻯶���</param>", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n public static void SetUpdFlag(cls{0}EN obj{0}EN)", objPrjTabENEx.TabName);
            strBuilder.Append("\r\n{");
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "obj{0}EN.ClearUpdateState();", objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n   string strsfUpdFldSetStr = obj{0}EN.sfUpdFldSetStr;",
              objPrjTabENEx.TabName);
            strBuilder.Append("\r\n    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');");
            strBuilder.Append("\r\n   List<string> arrFldSet = new List<string>(sstrFldSet);");

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.Set{1}(obj{0}EN.{1}); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else if (objField.FldOpTypeId == "0003") //ֻд
                {
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = obj{0}EN.Get{1}(); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else
                {
                    strBuilder.AppendFormat("\r\n" + "if (arrFldSet.Contains(con{0}.{1}, new clsStrCompareIgnoreCase())  ==  true)",
                         objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
                    strBuilder.Append("\r\n" + "{");
                    strBuilder.AppendFormat("\r\n" + "obj{0}EN.{1} = obj{0}EN.{1}; //{3}",
                               objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                    strBuilder.Append("\r\n" + "}");

                }
            }

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch (Exception objException)");
            strBuilder.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                  objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "SetUpdFlag", "���ñ���޸ı�־����!��:{0}.", "���ɴ���");

            strBuilder.AppendFormat("\r\n" + "strMsg = string.Format(\"(errid:{0})���ñ���޸ı�־����,{{1}}.({{0}})\",", strErrId, "{", "}");
            strBuilder.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strBuilder.AppendFormat("\r\n" + "objException.Message); ");
            strBuilder.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"(errid:{22})Copy��:{0} ��������(����޸�)����!({1}:CopyObjFromSimObj4Upd)\\r\\n\" + objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strBuilder.AppendFormat("\r\n" + "throw new Exception(\"Copy��:{0} �������ݳ���!({1}: CopyObjFromSimObj4Upd)\"+ objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strBuilder.ToString();
        }

    }
}
