using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AgcCommBase;

using com.taishsoft.commexception;
using com.taishsoft.common;
using com.taishsoft.comm_db_obj;
using com.taishsoft.datetime;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using AGC.PureClassEx;

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
    partial class WA_Access4CSharp : clsGeneCodeBase
    {
        private string strKeyFldName_ObjName = "";
        private string strKeyFldName_PrivateVar = "";
        #region ���캯��

        public WA_Access4CSharp()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }
        public WA_Access4CSharp(string strPrjId)
          : base(strPrjId)
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }
        public WA_Access4CSharp(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
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
            var arrKeyPrivateVar = arrPrjTabFldEx.Select(x => x.PrivFuncName).ToList();
            strKeyFldName_PrivateVar = string.Join(",", arrKeyPrivateVar);

            objPrjTabENEx.CurrDate = clsDateTime.getTodayStr2(0);

            //���û���������;
            //string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; ///��ʱ����;
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
                objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId);


            objPrjTabENEx.ClsName = string.Format("cls{0}WApi", objPrjTabENEx.TabName); ;
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebApiTransferLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".cs";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName(objFuncModule, objPrjTabENEx);

            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".cs";
            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            try
            {
                //������ʼ

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));

                //������ʼ

                strCodeForCs.Append("\r\n" + "using System;"); //
                strCodeForCs.Append("\r\n" + "using System.Data; "); //
                strCodeForCs.Append("\r\n" + "using System.Data.SqlClient;");
                strCodeForCs.Append("\r\n" + "using System.Text; "); //
                strCodeForCs.Append("\r\n" + "using System.Web;"); //
                strCodeForCs.Append("\r\n" + "using System.Collections; "); //
                strCodeForCs.Append("\r\n" + "using System.Collections.Generic;"); //
                strCodeForCs.Append("\r\n" + "using System.ComponentModel;"); //
                strCodeForCs.Append("\r\n" + "using System.Linq;"); //
                strCodeForCs.Append("\r\n" + "using System.Reflection;"); //

                strCodeForCs.AppendFormat("\r\n" + "using Newtonsoft.Json;"); //
                strCodeForCs.AppendFormat("\r\n" + "using Newtonsoft.Json.Linq; "); //
                //strCodeForCs.AppendFormat("\r\n" + "using Comm.WebApi;"); //

                // strCodeForCs.AppendFormat("\r\n" + "using {1}4WS.ServiceReference{0};", objPrjTabENEx.TabName, objProject.PrjDomain); //

                strCodeForCs.Append("\r\n" + "using com.taishsoft.common;"); //
                strCodeForCs.Append("\r\n" + "using com.taishsoft.comm_db_obj;"); //
                strCodeForCs.Append("\r\n" + "using com.taishsoft.dynamiccompiler;"); //
                strCodeForCs.Append("\r\n" + "using com.taishsoft.json;"); //
                //strCodeForCs.Append("\r\n" + "using System.ServiceModel;"); //
                strCodeForCs.AppendFormat("\r\n" + "using {0}.Entity;", objProjectsENEx.PrjDomain);


                //strCodeForCs.AppendFormat("\r\n" + "using {0}.BusinessLogic;", objProjectsENEx.PrjDomain);


                strCodeForCs.Append("\r\n" + ""); //
                                                  //if (objPrjTabENEx.IsForSilverLight == true)
                                                  //{
                                                  //    strCodeForCs.AppendFormat("\r\n" + "namespace SL4WS",
                                                  //    objProject.PrjDomain);
                                                  //}
                                                  //else
                                                  //{
                strCodeForCs.AppendFormat("\r\n" + "namespace {0}4WApi",
                objProject.PrjDomain);
                //}
                strCodeForCs.Append("\r\n" + "{");

                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_Static = arrvFunction4GeneCodeObjLst.Where(x => x.FuncTypeId == enumFunctionType.PureStaticFunction_12);
                if (arrvFunction4GeneCodeObjLst_Static.Count() > 0)
                {
                    strCodeForCs.Append("\r\n" + "/// <summary>");
                    strCodeForCs.Append("\r\n" + "/// ��̬��");
                    strCodeForCs.Append("\r\n" + "/// </summary>");
                    strCodeForCs.AppendFormat("\r\n" + "public static class  {0}_Static", objPrjTabENEx.ClsName);
                    strCodeForCs.Append("\r\n" + "{");
                    foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst_Static)
                    {
                        //clsFunction4GeneCodeEN objFunction4GeneCodeEN1 = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
                        strFuncName = objvFunction4GeneCodeEN.FuncName;

                        if (strFuncName.Substring(0, 6) == "Print:")
                        {
                            strCodeForCs.Append("\r\n" + "");
                            strCodeForCs.Append("\r\n" + "");
                            strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
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
                            strCodeForCs.Append("\r\n" + strTemp);
                        }
                    }
                    strCodeForCs.Append("\r\n" + "}");

                }





                //clsvFunction4GeneCodeEN objvFunction4GeneCodeEN21 = clsvFunction4GeneCodeBLEx.GetObjByFuncNameCacheEx("Gen_4WA_GeneEnumConstList");
                strTemp = A_GeneFuncCodeByFuncName("Gen_4WA_GeneEnumConstList");
                strCodeForCs.Append(strTemp);
                //objvFunction4GeneCodeEN1 = clsvFunction4GeneCodeBLEx.GetObjByFuncNameCacheEx("Gen_4WA_GeneEnumConstList4Field");
                strTemp = A_GeneFuncCodeByFuncName("Gen_4WA_GeneEnumConstList4Field");
                strCodeForCs.Append(strTemp);

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);
                //if (objPrjTabENEx.IsForSilverLight == true)
                //{
                //    strCodeForCs.AppendFormat("\r\n /// For SilverLight");
                //}
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.Append("\r\n" + "public class " + objPrjTabENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");


                strCodeForCs.AppendFormat("\r\n" + "private static readonly string mstrApiControllerName = \"{0}Api\";",
                    objPrjTabENEx.TabName);
                //strCodeForCs.Append("\r\n" + "private static string mstrDir = \"0\";");

                //˽��������-----�����Թ���
                //strCodeForCs.Append("\r\n /// <summary>");
                //strCodeForCs.Append("\r\n /// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
                //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                //strCodeForCs.Append("\r\n /// </summary>");
                //strCodeForCs.AppendFormat("\r\n" + "public static List<cls{0}EN> arr{0}ObjLstCache = null;",
                //       objPrjTabENEx.TabName);

                //strCodeForCs.AppendFormat("\r\n /// <summary>");
                //strCodeForCs.AppendFormat("\r\n /// �ӻ����в���ʧ�ܵĴ���");
                //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                //strCodeForCs.AppendFormat("\r\n /// </summary>");
                //strCodeForCs.AppendFormat("\r\n" + "protected static int intFindFailCount = 0;");

                //˽��������-----�����Թ���
                //strCodeForCs.AppendFormat("\r\n" + "private static {0}ServiceSoapClient obj{0}ServiceSoapClient = null;",
                //objPrjTabENEx.TabName);
                //strCodeForCs.Append("\r\n /// <summary>");
                //strCodeForCs.Append("\r\n /// ");
                //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                //strCodeForCs.Append("\r\n /// </summary>");
                //strCodeForCs.Append("\r\n /// <returns></returns>");
                //strCodeForCs.AppendFormat("\r\n" + "public static {0}ServiceSoapClient Get{0}ServiceSoapClient()",
                //objPrjTabENEx.TabName);
                //strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.AppendFormat("\r\n" + "if (obj{0}ServiceSoapClient == null)",
                //objPrjTabENEx.TabName);
                //strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.Append("\r\n" + "BasicHttpBinding binding = new BasicHttpBinding();");
                //strCodeForCs.AppendFormat("\r\n" + "binding.Name = \"{0}ServiceSoap\";",
                //objPrjTabENEx.TabName);
                //strCodeForCs.Append("\r\n" + "binding.CloseTimeout = new System.TimeSpan(6000);");
                //strCodeForCs.Append("\r\n" + "binding.MaxReceivedMessageSize = 2147483647;");
                ////                strCodeForCs.Append("\r\n" + "String strServiceUrl = String.Empty;");
                //strCodeForCs.Append("\r\n" + "string strServiceUrl = GetServiceUrl(mstrApiControllerName, ref mstrDir);");
                ////strCodeForCs.Append("\r\n" + "if (clsSysPara4WebApi.bolIsLocalHost == false)");
                ////strCodeForCs.Append("\r\n" + "{");
                ////strCodeForCs.AppendFormat("\r\n" + "strServiceUrl = String.Format(\"http://{{0}}/{{1}}/{2}Service.asmx\", clsSysPara4WebApi.strCurrIPAddressAndPort, clsSysPara4WebApi.strCurrPrx);",
                ////"{", "}", objPrjTabENEx.TabName);
                ////strCodeForCs.Append("\r\n" + "}");
                ////strCodeForCs.Append("\r\n" + "else");
                ////strCodeForCs.Append("\r\n" + "{");
                ////strCodeForCs.AppendFormat("\r\n" + "strServiceUrl = String.Format(\"http://{{0}}/{2}Service.asmx\", clsSysPara4WebApi.strCurrIPAddressAndPort_Local);",
                ////"{", "}", objPrjTabENEx.TabName);
                ////strCodeForCs.Append("\r\n" + "}");

                //strCodeForCs.Append("\r\n" + "EndpointAddress address = new EndpointAddress(strServiceUrl);");

                //strCodeForCs.AppendFormat("\r\n" + "return new {0}ServiceSoapClient(binding, address);",
                //objPrjTabENEx.TabName);
                //strCodeForCs.Append("\r\n" + "}");
                //strCodeForCs.Append("\r\n" + "else");
                //strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.AppendFormat("\r\n" + "return obj{0}ServiceSoapClient;",
                //objPrjTabENEx.TabName);
                //strCodeForCs.Append("\r\n" + "}");
                //strCodeForCs.Append("\r\n" + "}");
                //�������еĺ���

                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_NotStatic = arrvFunction4GeneCodeObjLst.Where(x => x.FuncTypeId != enumFunctionType.PureStaticFunction_12);

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst_NotStatic)
                {
                    clsFunction4GeneCodeEN objFunction4GeneCodeEN1 = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

                    strFuncName = objvFunction4GeneCodeEN.FuncName;

                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }

                strCodeForCs.Append("\r\n" + "}");


                string strCommFun4WACode = new CommFun4WA4CSharp().GeneCode_This(objPrjTabENEx, this.CmPrjId);
                if (strCommFun4WACode.IndexOf("û�п������ɵĺ���4GC") == -1)
                {
                    strCodeForCs.AppendLine(strCommFun4WACode);
                }

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
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
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

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objWebSrvClassENEx.CurrUserName, objWebSrvClassENEx));

                //������ʼ

                strCodeForCs.Append("\r\n" + "using System;"); //
                strCodeForCs.Append("\r\n" + "using System.Data; "); //
                strCodeForCs.Append("\r\n" + "using System.Data.SqlClient;");
                strCodeForCs.Append("\r\n" + "using System.Text; "); //
                strCodeForCs.Append("\r\n" + "using System.Collections; "); //
                strCodeForCs.Append("\r\n" + "using com.taishsoft.common;"); //
                strCodeForCs.Append("\r\n" + "using System.ServiceModel;"); //
                strCodeForCs.AppendFormat("\r\n" + "using {1}4WS.ServiceReference{0};", objWebSrvClassENEx.ClsName, objProject.PrjDomain); //
                strCodeForCs.Append("\r\n" + "using System.Collections.Generic;"); //

                strCodeForCs.Append("\r\n" + ""); //
                                                  //if (objWebSrvClassENEx.IsForSilverLight == true)
                                                  //{
                                                  //    strCodeForCs.AppendFormat("\r\n" + "namespace SL4WS",
                                                  //    objProject.PrjDomain);
                                                  //}
                                                  //else
                                                  //{
                strCodeForCs.AppendFormat("\r\n" + "namespace {0}4WS",
                objProject.PrjDomain);
                //}
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}",
                    objWebSrvClassENEx.ClsName);
                //if (objWebSrvClassENEx.IsForSilverLight == true)
                //{
                //    strCodeForCs.AppendFormat("\r\n /// For SilverLight");
                //}
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.Append("\r\n" + "public class " + objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");


                strCodeForCs.AppendFormat("\r\n" + "private static string mstrApiControllerName = \"{0}\";",
                    objWebSrvClassENEx.PageName);
                strCodeForCs.Append("\r\n" + "private static string mstrDir = \"0\";");

                //˽��������-----�����Թ���
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                //strCodeForCs.AppendFormat("\r\n" + "public static List<cls{0}EN> arr{0}ObjLstCache = null;",
                //       objWebSrvClassENEx.TabName);

                strCodeForCs.AppendFormat("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// �ӻ����в���ʧ�ܵĴ���");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "protected static int intFindFailCount = 0;");

                //˽��������-----�����Թ���
                strCodeForCs.AppendFormat("\r\n" + "private static {0}SoapClient obj{0}SoapClient = null;",
                objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n /// <returns></returns>");
                strCodeForCs.AppendFormat("\r\n" + "public static {0}SoapClient Get{0}SoapClient()",
                objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "if (obj{0}SoapClient == null)",
                objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "BasicHttpBinding binding = new BasicHttpBinding();");
                strCodeForCs.AppendFormat("\r\n" + "binding.Name = \"{0}ServiceSoap\";",
                objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n" + "binding.CloseTimeout = new System.TimeSpan(6000);");
                strCodeForCs.Append("\r\n" + "binding.MaxReceivedMessageSize = 2147483647;");
                //                strCodeForCs.Append("\r\n" + "String strServiceUrl = String.Empty;");
                strCodeForCs.Append("\r\n" + "string strServiceUrl = GetServiceUrl(mstrApiControllerName, ref mstrDir);");
                //strCodeForCs.Append("\r\n" + "if (clsSysPara4WebApi.bolIsLocalHost == false)");
                //strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.AppendFormat("\r\n" + "strServiceUrl = String.Format(\"http://{{0}}/{{1}}/{2}Service.asmx\", clsSysPara4WebApi.strCurrIPAddressAndPort, clsSysPara4WebApi.strCurrPrx);",
                //"{", "}", objWebSrvClassENEx.TabName);
                //strCodeForCs.Append("\r\n" + "}");
                //strCodeForCs.Append("\r\n" + "else");
                //strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.AppendFormat("\r\n" + "strServiceUrl = String.Format(\"http://{{0}}/{2}Service.asmx\", clsSysPara4WebApi.strCurrIPAddressAndPort_Local);",
                //"{", "}", objWebSrvClassENEx.TabName);
                //strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "EndpointAddress address = new EndpointAddress(strServiceUrl);");

                strCodeForCs.AppendFormat("\r\n" + "return new {0}SoapClient(binding, address);",
                objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "return obj{0}SoapClient;",
                objWebSrvClassENEx.ClsName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
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
                            strCodeForCs.Append("\r\n" + strTemp);
                            clsWebSrvFunctionsBLEx.SetGeneCode(objWebSrvFunctionsENEx.WebSrvFunctionId, true);
                        }
                        else
                        {
                            strTemp = string.Format("//�ú�����[{0}]�޷�����.", objWebSrvFunctionsENEx.FunctionSignature);
                            strCodeForCs.Append("\r\n" + strTemp);
                        }
                    }
                    catch (Exception objException)
                    {
                        strTemp = string.Format("//�ú�����[{0}]�޷�����.����:[{1}]({2}->{3})",
                            objWebSrvFunctionsENEx.FunctionSignature,
                            objException.Message,
                            clsStackTrace.GetCurrClassFunctionByLevel(2),
                            clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }
                strFuncName = "Gen_4WA_GetServiceUrl";
                clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncNameCacheEx(strFuncName);

                strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                if (string.IsNullOrEmpty(strTemp) == false)
                {
                    strCodeForCs.Append("\r\n" + strTemp);
                }

                strCodeForCs.Append("\r\n" + "}");
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


        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(WA_Access4CSharp);
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
            StringBuilder strCodeForCs = new StringBuilder();

            ///�๹����----------------------------------------------;
            strCodeForCs.Append("\r\n public " + objPrjTabENEx.ClsName + "()");
            strCodeForCs.Append("\r\n {");

            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }

        public string Gen_4WA_CheckPropertyNew()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            ///������������Ƿ���ȷ-------------------------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// �������ֶ�ֵ�Ƿ�Ϸ�,1)����Ƿ�ɿ�;2)����ֶ�ֵ�����Ƿ񳬳�,���������׳�����.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\npublic static void CheckPropertyNew(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);

                if (objField.IsTabNullable = false && objField.FieldTypeId != "02")
                {
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte[]" || objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte")
                    {
                        continue;
                    }
                    strCodeForCs.AppendFormat("\r\nif (Object.Equals(null, {0}) ",
                        strPrivPropNameWithObjectName);
                    strCodeForCs.AppendFormat("\r\n|| (!Object.Equals(null, {0}) && {0}.ToString() == \"\")",
                         strPrivPropNameWithObjectName);

                    if (string.IsNullOrEmpty(objField.ObjFieldTab4CodeConv().CodeTabId) != true)
                    {
                        strCodeForCs.AppendFormat("\r\n|| (!Object.Equals(null, {0}) && {0}.ToString() == \"0\")",
                             strPrivPropNameWithObjectName);
                    }
                    strCodeForCs.Append(")");
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.AppendFormat("\r\n throw new Exception(\"�ֶ�[{0}]����Ϊ��(NULL)!\");",
                    objField.ColCaption);
                    strCodeForCs.Append("\r\n}");
                }


            }
            ///������Գ��ȴ���;
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);

                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text" && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string" && objField.ObjFieldTabENEx.FldLength > 0)
                {
                    strCodeForCs.AppendFormat("\r\nif (!Object.Equals(null, {0}) && GetStrLen({0}) > {1})",
                         strPrivPropNameWithObjectName,
                          objField.ObjFieldTabENEx.FldLength);
                    strCodeForCs.Append("\r\n{");
                    strCodeForCs.AppendFormat("\r\n throw new Exception(\"�ֶ�[{0}]�ĳ��Ȳ��ܳ���{1}!\");",
                    objField.ColCaption, objField.ObjFieldTabENEx.FldLength.ToString().Trim());
                    strCodeForCs.Append("\r\n}");
                }
            }
            strCodeForCs.AppendFormat("\r\n obj{0}EN._IsCheckProperty = true;", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n }");
            ///������������Ƿ���ȷ == == ;
            return strCodeForCs.ToString();
        }

        /// <summary>");
        /// ����������ȡ���ݱ�,��DataTable��ʾ");
        /// </summary>");
        /// <param name = \"objPrjTabENEx\">�����</param>");
        /// <returns>������������һ����Χ��DataTable</returns>
        public string Gen_4WA_GetDataTable()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">������</param>");
            strCodeForCs.Append("\r\n /// <returns>������������һ����Χ��DataTable</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static DataTable GetDataTable(string strWhereCond)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "DataSet objDS;");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "objDS = obj{0}Service.GetDataSet(strWhereCond);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "DataTable objDT = objDS.Tables[0];");
            strCodeForCs.Append("\r\n" + "return objDT;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n string strMsg = string.Format(\"ִ��WebApi���ܳ���, {0}.(from {1}). WebApi��ַ:{2}).\",");
            strCodeForCs.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
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
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// {0}", objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
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
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">�����Ͳ���,����:{1}</param>",
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
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">{1}</param>",
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
            strCodeForCs.AppendFormat("\r\n /// <returns>����{0}</returns>",
                objWebSrvFunctionsENEx.ReturnValueDescription);
            if (objSelfDefDataTypeEN != null)
            {
                strCodeForCs.AppendFormat("\r\n" + "public static {0} {1}({2})",
                        objSelfDefDataTypeEN.CsType, objWebSrvFunctionsENEx.FunctionName,
                        sbParaList.ToString());
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "public static {0} {1}({2})",
                            objFuncReturnTypeEN.CsType, objWebSrvFunctionsENEx.FunctionName,
                            sbParaList.ToString());
            }
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "{0}SoapClient obj{0}Service = Get{0}SoapClient();",
                    objWebSrvClassENEx.ClsName);
            //strCodeForCs.Append("\r\n" + "DataSet objDS;");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            if (objSelfDefDataTypeEN != null)
            {
                strCodeForCs.AppendFormat("\r\n" + "{0} {1} = obj{2}Service.{3}({4});",
                     objSelfDefDataTypeEN.CsType,
                     objSelfDefDataTypeEN.DefaVarName,
                     objWebSrvClassENEx.ClsName,
                     objWebSrvFunctionsENEx.FunctionName,
                     sbParaVarList.ToString());
                strCodeForCs.AppendFormat("\r\n" + "return {0};", objSelfDefDataTypeEN.DefaVarName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "{0} {1}Temp = obj{2}Service.{3}({4});",
                    objFuncReturnTypeEN.CsType,
                    objFuncReturnTypeEN.DataTypeAbbr,
                    objWebSrvClassENEx.ClsName,
                    objWebSrvFunctionsENEx.FunctionName,
                    sbParaVarList.ToString());
                strCodeForCs.AppendFormat("\r\n" + "return {0}Temp;", objFuncReturnTypeEN.DataTypeAbbr);
            }
            //strCodeForCs.Append("\r\n" + "DataTable objDT = objDS.Tables[0];");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n string strMsg = string.Format(\"ִ��WebApi���ܳ���, {0}.(from {1}). WebApi��ַ:{2}).\",");
            strCodeForCs.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
        /// <summary>");
        /// ����������ȡ���ݱ�,��DataTable��ʾ");
        /// </summary>");
        /// <param name = \"objPrjTabENEx\">�����</param>");
        /// <returns>������������һ����Χ��DataTable</returns>
        public string Gen_4WA_GetTopDataTable()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ���ݱ�,��DataTable��ʾ");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">������</param>");
            strCodeForCs.Append("\r\n /// <returns>������������һ����Χ��DataTable</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "DataSet objDS;");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "objDS = obj{0}Service.GetTopDataSet(intTopSize, strWhereCond);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "DataTable objDT = objDS.Tables[0];");
            strCodeForCs.Append("\r\n" + "return objDT;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n string strMsg = string.Format(\"ִ��WebApi���ܳ���, {0}.(from {1}). WebApi��ַ:{2}).\",");
            strCodeForCs.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        /// <summary>");
        /// ����������ȡһ����Χ�����ݱ�,��DataTable��ʾ");
        /// </summary>");
        /// <param name = \"objPrjTabENEx\">�����</param>");
        /// <returns>������������һ����Χ��DataTable</returns>
        public string Gen_4WA_GetDataTableByRange()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡһ����Χ�����ݱ�,��DataTable��ʾ");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">������</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strCodeForCs.Append("\r\n /// <returns>������������һ����Χ��DataTable</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static DataTable GetDataTableByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "DataSet objDS;");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "objDS = obj{0}Service.GetDataSetByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);",
                    objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "DataTable objDT = objDS.Tables[0];");
            strCodeForCs.Append("\r\n" + "return objDT;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n string strMsg = string.Format(\"ִ��WebApi���ܳ���, {0}.(from {1}). WebApi��ַ:{2}).\",");
            strCodeForCs.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
        /// <summary>
        /// ��ȡ��View��DataTable
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_GetDataTableV()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��ȡ����ͼ��DataTable");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>����ͼ��DataTable</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static DataTable GetDataTableV(string strWhereCond)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "DataSet objDS;");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "objDS = obj{0}Service.GetDataSetV(strWhereCond);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "DataTable objDT = objDS.Tables[0];");
            strCodeForCs.Append("\r\n" + "return objDT;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n string strMsg = string.Format(\"ִ��WebApi���ܳ���, {0}.(from {1}). WebApi��ַ:{2}).\",");
            strCodeForCs.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        /// <summary>");
        /// ����������ȡһ����Χ�����ݱ�,��DataTable��ʾ");
        /// </summary>");
        /// <param name = \"objPrjTabENEx\">�����</param>");
        /// <returns>������������һ����Χ��DataTable</returns>
        public string Gen_4WA_GetDataTableVByRange()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡһ����Χ�����ݱ�,��DataTable��ʾ");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">������</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strCodeForCs.Append("\r\n /// <returns>������������һ����Χ��DataTable</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static DataTable GetDataTableVByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "DataSet objDS;");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "objDS = obj{0}Service.GetDataSetVByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "DataTable objDT = objDS.Tables[0];");
            strCodeForCs.Append("\r\n" + "return objDT;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n string strMsg = string.Format(\"ִ��WebApi���ܳ���, {0}.(from {1}). WebApi��ַ:{2}).\",");
            strCodeForCs.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ��ȡ��View��DataTable
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_GetDataTableV2()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��ȡ���������ı���ͼ��DataTable");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>����ͼ��DataTable</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static DataTable Get{0}V(string strWhereCond)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "DataSet objDS;");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "objDS = obj{0}Service.GetDataSetV(strWhereCond);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "DataTable objDT = objDS.Tables[0];");
            strCodeForCs.Append("\r\n" + "return objDT;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n string strMsg = string.Format(\"ִ��WebApi���ܳ���, {0}.(from {1}). WebApi��ַ:{2}).\",");
            strCodeForCs.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        /// <summary>");
        /// ����������ȡһ����Χ�����ݱ�,��DataTable��ʾ");
        /// </summary>");
        /// <param name = \"objPrjTabENEx\">�����</param>");
        /// <returns>������������һ����Χ��DataTable</returns>
        public string Gen_4WA_GetDataTableV2ByRange()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡһ����Χ�����ݱ�,��DataTable��ʾ");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">������</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strOrderBy\">����ʽ</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMinNum\">��Χ֮��Сֵ</param>");
            strCodeForCs.Append("\r\n /// <param name = \"intMaxNum\">��Χ֮���ֵ</param>");
            strCodeForCs.Append("\r\n /// <returns>������������һ����Χ��DataTable</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static DataTable GetDataTableVByRange(string strWhereCond, string strOrderBy, int intMinNum, int intMaxNum)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "DataSet objDS;");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "objDS = obj{0}Service.GetDataSetVByRange(strWhereCond, strOrderBy, intMinNum, intMaxNum);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "DataTable objDT = objDS.Tables[0];");
            strCodeForCs.Append("\r\n" + "return objDT;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n string strMsg = string.Format(\"ִ��WebApi���ܳ���, {0}.(from {1}). WebApi��ַ:{2}).\",");
            strCodeForCs.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
        public string Gen_4WA_GetObjLst()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ�����б�");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">��������</param>");
            strCodeForCs.Append("\r\n /// <returns>���ض����б�</returns>");
            strCodeForCs.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLst(string strWhereCond)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n List<cls{0}EN> arrObjLst; ",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "string strAction = \"GetObjLst\";");


            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strCodeForCs.Append("\r\n" + "};");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "arrObjLst = clsJSON.GetObjLstFromJson<cls{0}EN>(strResult);",
            //     objPrjTabENEx.TabName);
            //strCodeForCs.Append("\r\n" + "return arrObjLst;");
            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strJson = JsonConvert.SerializeObject(jobjReturn0[\"returnObjLst\"]);");

            strCodeForCs.AppendFormat("\r\n" + "arrObjLst = JsonConvert.DeserializeObject<List<cls{0}EN>>(strJson);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "return arrObjLst;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return null;");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"��ȡ���������б����,{0}.(from {1})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strCodeForCs.ToString();
        }

        public string Gen_4WA_GetObjLstByKeyLst()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ���ݹؼ����б��ȡ�����б�");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
                {
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">��ؼ���</param>", objInFor.PrivFuncName);
                }
                strCodeForCs.Append("\r\n /// <returns>���ض����б�</returns>");
                strCodeForCs.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLstByKeyLsts(List<{2}> arr{1})",
                        objPrjTabENEx.TabName,
                        objKeyField.FldName_FstUcase,
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                        objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n{");
                strCodeForCs.AppendFormat("\r\n List<cls{0}EN> arrObjLst; ",
                objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "string strAction = \"GetObjLstByKeyLsts\";",
                    objKeyField.FldName_FstUcase);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n /// <param name = \"arr{0}\">�ؼ����б�</param>", objKeyField.FldName_FstUcase);
                strCodeForCs.Append("\r\n /// <returns>���ض����б�</returns>");
                strCodeForCs.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLstBy{1}Lst(List<{2}> arr{1})",
                        objPrjTabENEx.TabName,
                        objKeyField.FldName_FstUcase,
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                        objKeyField.PrivFuncName);
                strCodeForCs.Append("\r\n{");
                strCodeForCs.AppendFormat("\r\n List<cls{0}EN> arrObjLst; ",
                objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "string strAction = \"GetObjLstBy{0}Lst\";",
                    objKeyField.FldName_FstUcase);
            }


            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>();");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            //strCodeForCs.Append("\r\n" + "};");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "string strJSON = clsJSON.GetJsonFromObjLst(arr{0});", objKeyField.FldName_FstUcase);
            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "arrObjLst = clsJSON.GetObjLstFromJson<cls{0}EN>(strResult);",
            //     objPrjTabENEx.TabName);
            //strCodeForCs.Append("\r\n" + "return arrObjLst;");
            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strJson = JsonConvert.SerializeObject(jobjReturn0[\"returnObjLst\"]);");

            strCodeForCs.AppendFormat("\r\n" + "arrObjLst = JsonConvert.DeserializeObject<List<cls{0}EN>>(strJson);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "return arrObjLst;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return null;");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"���ݹؼ����б��ȡ�����б����,{0}.(from {1})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strCodeForCs.ToString();
        }

        public string Gen_4WA_GetObjLstByKeyLst_WACache()
        {

            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ���ݹؼ����б��ȡ�����б�");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
                {
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">��ؼ���</param>", objInFor.PrivFuncName);
                }
                strCodeForCs.Append("\r\n /// <returns>���ض����б�</returns>");
                if (objPrjTabENEx.objCacheClassifyFld_TS == null)
                {
                    strCodeForCs.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLstByKeyLsts_WACache(List<{2}> arr{1})",
                        objPrjTabENEx.TabName,
                        objKeyField.FldName_FstUcase,
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                        objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLstByKeyLsts_WACache(List<{2}> arr{1}, {3} {4})",
                       objPrjTabENEx.TabName,
                       objKeyField.FldName_FstUcase,
                       objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objPrjTabENEx.objCacheClassifyFld_TS.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objPrjTabENEx.objCacheClassifyFld_TS.PrivFuncName
                   );
                }

                strCodeForCs.Append("\r\n{");
                strCodeForCs.AppendFormat("\r\n List<cls{0}EN> arrObjLst; ",
                objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "string strAction = \"GetObjLstByKeyLstsCache\";",
                    objKeyField.FldName_FstUcase);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n /// <param name = \"arr{0}\">�ؼ����б�</param>", objKeyField.FldName_FstUcase);
                strCodeForCs.Append("\r\n /// <returns>���ض����б�</returns>");
                if (objPrjTabENEx.objCacheClassifyFld_TS == null)
                {
                    strCodeForCs.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLstBy{1}Lst_WACache(List<{2}> arr{1})",
                        objPrjTabENEx.TabName,
                        objKeyField.FldName_FstUcase,
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                        objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLstBy{1}Lst_WACache(List<{2}> arr{1}, {3} {4})",
                       objPrjTabENEx.TabName,
                       objKeyField.FldName_FstUcase,
                       objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objPrjTabENEx.objCacheClassifyFld_TS.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objPrjTabENEx.objCacheClassifyFld_TS.PrivFuncName
                   );
                }

                strCodeForCs.Append("\r\n{");
                strCodeForCs.AppendFormat("\r\n List<cls{0}EN> arrObjLst; ",
                objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "string strAction = \"GetObjLstBy{0}LstCache\";",
                    objKeyField.FldName_FstUcase);
            }

            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>()");
            strCodeForCs.Append("\r\n" + "{");
            if (objPrjTabENEx.objCacheClassifyFld_TS != null)
            {
                strCodeForCs.AppendFormat("\r\n" + "[\"{0}\"] = {1}",
                        objPrjTabENEx.objCacheClassifyFld_TS.FldName,
                        objPrjTabENEx.objCacheClassifyFld_TS.PrivFuncName);
            }
            strCodeForCs.Append("\r\n" + "};");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "string strJSON = clsJSON.GetJsonFromObjLst(arr{0});", objKeyField.FldName_FstUcase);
            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "arrObjLst = clsJSON.GetObjLstFromJson<cls{0}EN>(strResult);",
            //     objPrjTabENEx.TabName);
            //strCodeForCs.Append("\r\n" + "return arrObjLst;");
            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strJson = JsonConvert.SerializeObject(jobjReturn0[\"returnObjLst\"]);");

            strCodeForCs.AppendFormat("\r\n" + "arrObjLst = JsonConvert.DeserializeObject<List<cls{0}EN>>(strJson);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "return arrObjLst;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return null;");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"���ݹؼ����б��ȡ�����б����,{0}.(from {1})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strCodeForCs.ToString();
        }


        public string Gen_4WA_GetDataTableByObjLst()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ���ݶ����б��ȡDataTable");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"arrObjLst\">�����Ķ����б�</param>");
            strCodeForCs.Append("\r\n /// <returns>����DataTable</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static DataTable GetDataTableByObjLst(List<cls{0}EN> arrObjLst)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "DataTable objDT = new DataTable();");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strCodeForCs.AppendFormat("\r\n" + "objDT.Columns.Add(con{0}.{1}, Type.GetType(\"{2}\"));",
                    objPrjTabENEx.TabName, objField.FldName,
                    objField.ObjFieldTabENEx.objDataTypeAbbrEN.NetSysType);
            }
            strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN objInFor in arrObjLst)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "DataRow objDR = objDT.NewRow();");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strCodeForCs.AppendFormat("\r\n" + "objDR[con{0}.{1}] = objInFor[con{0}.{1}];",
                    objPrjTabENEx.TabName, objField.FldName);
            }
            strCodeForCs.Append("\r\n" + "objDT.Rows.Add(objDR);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return objDT;");
            strCodeForCs.Append("\r\n" + "}");

            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strCodeForCs.ToString();
        }


        public string Gen_4WA_GetTopObjLst()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ���������б�");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"objTopPara\">��ȡ���������б�Ĳ�������</param>");
            strCodeForCs.Append("\r\n /// <returns>���ض����б�</returns>");
            strCodeForCs.AppendFormat("\r\npublic static List<cls{0}EN> GetTopObjLst(stuTopPara objTopPara)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n List<cls{0}EN> arrObjLst; ",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "string strAction = \"GetTopObjLst\";");


            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = objTopPara.GetDictParam();");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strJSON = clsJSON.GetJsonFromObj<stuTopPara>(objTopPara);");
            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "arrObjLst = clsJSON.GetObjLstFromJson<cls{0}EN>(strResult);",
            //     objPrjTabENEx.TabName);
            //strCodeForCs.Append("\r\n" + "return arrObjLst;");
            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strJson = JsonConvert.SerializeObject(jobjReturn0[\"returnObjLst\"]);");

            strCodeForCs.AppendFormat("\r\n" + "arrObjLst = JsonConvert.DeserializeObject<List<cls{0}EN>>(strJson);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "return arrObjLst;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return null;");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"����������ȡ���������б�,{0}.(from {1})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strCodeForCs.ToString();
        }

        public string Gen_4WA_GetServiceUrl()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��ȡWeb����ĵ�ַ");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>���ص�ǰ�ļ���Web����ĵ�ַ</returns>");

            strCodeForCs.Append("\r\npublic static string GetServiceUrl(string strPageName, ref string strDir)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\n" + "String strServiceUrl = String.Empty;");
            strCodeForCs.Append("\r\n" + "if (strDir == \"0\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strDir = clsDict_PageName_Dic.GetDir4PageName(strPageName);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "if (clsSysPara4WebApi.bolIsLocalHost == false)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (string.IsNullOrEmpty(strDir) == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strServiceUrl = String.Format(\"http://{0}/{1}/{2}\",");
            strCodeForCs.Append("\r\n" + "clsSysPara4WebApi.strCurrIPAddressAndPort, clsSysPara4WebApi.strCurrPrx, strPageName);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strServiceUrl = String.Format(\"http://{0}/{1}/{2}/{3}\",");
            strCodeForCs.Append("\r\n" + "clsSysPara4WebApi.strCurrIPAddressAndPort, clsSysPara4WebApi.strCurrPrx, strDir, strPageName);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (string.IsNullOrEmpty(strDir) == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strServiceUrl = String.Format(\"http://{0}/{1}\",");
            strCodeForCs.Append("\r\n" + "clsSysPara4WebApi.strCurrIPAddressAndPort_Local,");
            strCodeForCs.Append("\r\n" + "strPageName);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strServiceUrl = String.Format(\"http://{0}/{1}/{2}\",");
            strCodeForCs.Append("\r\n" + "clsSysPara4WebApi.strCurrIPAddressAndPort_Local, strDir, strPageName);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return strServiceUrl;");
            strCodeForCs.Append("\r\n" + "}");

            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strCodeForCs.ToString();
        }
        public string Gen_4WA_GetWebApiUrl_SelfDefWS()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��ȡWeb����ĵ�ַ");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>���ص�ǰ�ļ���Web����ĵ�ַ</returns>");

            strCodeForCs.Append("\r\npublic static string GetServiceUrl(string strApiControllerName, string strAction, ref string strDir)");
            strCodeForCs.Append("\r\n{");

            strCodeForCs.Append("\r\n" + "String strServiceUrl = String.Empty;");
            strCodeForCs.Append("\r\n" + "if (strDir == \"0\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strDir = clsDict_PageName_Dic.GetDir4PageName(strApiControllerName);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "if (clsSysPara4WebApi.bolIsLocalHost == false)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (string.IsNullOrEmpty(strDir) == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strServiceUrl = String.Format(\"http://{0}/api/{1}/{2}/{3}\",");
            strCodeForCs.Append("\r\n" + "clsSysPara4WebApi.strCurrIPAddressAndPort, clsSysPara4WebApi.strCurrPrx, strApiControllerName, strAction);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strServiceUrl = String.Format(\"http://{0}/api/{1}/{2}/{3}/{4}\",");
            strCodeForCs.Append("\r\n" + "clsSysPara4WebApi.strCurrIPAddressAndPort, clsSysPara4WebApi.strCurrPrx, strDir, strApiControllerName, strAction);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (string.IsNullOrEmpty(strDir) == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strServiceUrl = String.Format(\"http://{0}/api/{1}/{2}\",");
            strCodeForCs.Append("\r\n" + "clsSysPara4WebApi.strCurrIPAddressAndPort_Local,");
            strCodeForCs.Append("\r\n" + "strApiControllerName, strAction);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strServiceUrl = String.Format(\"http://{0}/api/{1}/{2}/{3}\",");
            strCodeForCs.Append("\r\n" + "clsSysPara4WebApi.strCurrIPAddressAndPort_Local, strDir, strApiControllerName, strAction);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return strServiceUrl;");
            strCodeForCs.Append("\r\n" + "}");

            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strCodeForCs.ToString();
        }


        public string Gen_4WA_GetObjLstByRange()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��Χ�ڵĶ����б�");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"objRangePara\">���ݷ�Χ��ȡ��¼�Ĳ�������</param>");

            strCodeForCs.Append("\r\n /// <returns>���ض����б�</returns>");
            strCodeForCs.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLstByRange(stuRangePara objRangePara)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n List<cls{0}EN> arrObjLst; ",
objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "string strAction = \"GetObjLstByRange\";");


            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam =  objRangePara.GetDictParam();");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strJSON = clsJSON.GetJsonFromObj<stuRangePara>(objRangePara);");
            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "arrObjLst = clsJSON.GetObjLstFromJson<cls{0}EN>(strResult);",
            //     objPrjTabENEx.TabName);
            //strCodeForCs.Append("\r\n" + "return arrObjLst;");
            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strJson = JsonConvert.SerializeObject(jobjReturn0[\"returnObjLst\"]);");

            strCodeForCs.AppendFormat("\r\n" + "arrObjLst = JsonConvert.DeserializeObject<List<cls{0}EN>>(strJson);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "return arrObjLst;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return null;");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n string strMsg = string.Format(\"ִ��WebApi���ܳ���, {0}.(from {1}). WebApi��ַ:{2}).\",");
            strCodeForCs.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strCodeForCs.ToString();
        }
        public string Gen_4WA_GetObjLstByPager()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ҳ��ȡJSON�����б�");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"objPagerPara\">��ҳ��ȡ��¼�Ĳ�������</param>");
            strCodeForCs.Append("\r\n /// <returns>����JSON�����б�</returns>");
            strCodeForCs.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLstByPager(stuPagerPara objPagerPara)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n List<cls{0}EN> arrObjLst; ",
objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "string strAction = \"GetObjLstByPager\";");



            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = objPagerPara.GetDictParam();");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);");
            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "arrObjLst = clsJSON.GetObjLstFromJson<cls{0}EN>(strResult);",
            //     objPrjTabENEx.TabName);
            //strCodeForCs.Append("\r\n" + "return arrObjLst;");
            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strJson = JsonConvert.SerializeObject(jobjReturn0[\"returnObjLst\"]);");

            strCodeForCs.AppendFormat("\r\n" + "arrObjLst = JsonConvert.DeserializeObject<List<cls{0}EN>>(strJson);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "return arrObjLst;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return null;");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n string strMsg = string.Format(\"ִ��WebApi���ܳ���, {0}.(from {1}). WebApi��ַ:{2}).\",");
            strCodeForCs.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strCodeForCs.ToString();
        }

        public string Gen_4WA_GetObjLstByPagerCache()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ҳ��ȡJSON�����б�, ʹ�û���");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"objPagerPara\">��ҳ��ȡ��¼�Ĳ�������</param>");
            strCodeForCs.Append("\r\n /// <returns>����JSON�����б�</returns>");
            strCodeForCs.AppendFormat("\r\npublic static List<cls{0}EN> GetObjLstByPagerCache(stuPagerPara objPagerPara)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n List<cls{0}EN> arrObjLst; ",
objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "string strAction = \"GetObjLstByPagerCache\";");



            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = objPagerPara.GetDictParam();");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);");
            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "arrObjLst = clsJSON.GetObjLstFromJson<cls{0}EN>(strResult);",
            //     objPrjTabENEx.TabName);
            //strCodeForCs.Append("\r\n" + "return arrObjLst;");
            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strJson = JsonConvert.SerializeObject(jobjReturn0[\"returnObjLst\"]);");

            strCodeForCs.AppendFormat("\r\n" + "arrObjLst = JsonConvert.DeserializeObject<List<cls{0}EN>>(strJson);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "return arrObjLst;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return null;");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n string strMsg = string.Format(\"ִ��WebApi���ܳ���, {0}.(from {1}). WebApi��ַ:{2}).\",");
            strCodeForCs.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strCodeForCs.ToString();
        }


        /// <summary>
        /// ��ȡ��������������
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_GetRecordProperty4Object()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ���ݶ���Ĺؼ���ֵ,��ȡ�����ȫ������");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��ض���</param>", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "/// <returns>�Ƿ�ɹ�</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static bool Get{0}(ref cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "bool bolResult = obj{0}Service.Get{0}(ref obj{0}EN);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "return bolResult;");

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ��ȡ��������������
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_GetObjByKeyId()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.AppendFormat("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// ��ȡ��ǰ�ؼ��ֵļ�¼����,�ö������ʽ��ʾ.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// </summary>");
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
                {
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">��ؼ���</param>", objInFor.PrivFuncName);
                }
                strCodeForCs.AppendFormat("\r\n /// <returns>�����</returns>");
                strCodeForCs.AppendFormat("\r\n" + "public static cls{0}EN GetObjByKeyLst({2})",
                objPrjTabENEx.TabName, objKeyField.FldName, objPrjTabENEx.KeyVarDefineLstStr);
                strCodeForCs.Append("\r\n" + "{");
                foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
                {
                    if (objInFor.IsNumberType())
                    {
                        strCodeForCs.Append("\r\n" + $"if ({objInFor.PrivFuncName} == 0) return null;");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + $"if ({objInFor.PrivFuncName} == \"\") return null;");
                    }
                }
                strCodeForCs.AppendFormat("\r\n" + "string strAction = \"GetObjByKeyLst\";", objKeyField.FldName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">��ؼ���</param>", objKeyField.PrivFuncName);
                strCodeForCs.AppendFormat("\r\n /// <returns>�����</returns>");
                strCodeForCs.AppendFormat("\r\n" + "public static cls{0}EN GetObjBy{1}({2})",
                objPrjTabENEx.TabName, objKeyField.FldName, objPrjTabENEx.KeyVarDefineLstStr);
                strCodeForCs.Append("\r\n" + "{");
                if (objKeyField.IsNumberType())
                {
                    strCodeForCs.Append("\r\n" + $"if ({objKeyField.PrivFuncName} == 0) return null;");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + $"if ({objKeyField.PrivFuncName} == \"\") return null;");
                }
                strCodeForCs.AppendFormat("\r\n" + "string strAction = \"GetObjBy{0}\";", objKeyField.FldName);
            }

            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>()");
            strCodeForCs.Append("\r\n" + "{");
            foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
            {
                if (objInFor.IsNumberType() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "[\"{0}\"] = {0}.ToString(),", objInFor.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "[\"{0}\"] = {0},", objInFor.PrivFuncName);
                }
            }
            strCodeForCs.Append("\r\n" + "};");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = clsJSON.GetObjFromJson<cls{0}EN>(strResult);", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strJson = JsonConvert.SerializeObject(jobjReturn0[\"returnObj\"]);");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = JsonConvert.DeserializeObject<cls{0}EN>(strJson);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "return obj{0}EN;", objPrjTabENEx.TabName);

            //strCodeForCs.Append("\r\n" + "return bolReturnBool;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return null;");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"��ȡ������¼����,{0}.(from {1})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");


            //strCodeForCs.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            //objPrjTabENEx.TabName);

            //strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = obj{0}Service.GetObjBy{2}({1});",
            //objPrjTabENEx.TabName, objKeyField.PrivFuncName, objKeyField.FldName);
            //strCodeForCs.AppendFormat("\r\n" + "return obj{0}EN;", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ��ȡ��������������
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_GetObjByKeyId_WACache()
        {

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.AppendFormat("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// ��ȡ��ǰ�ؼ��ֵļ�¼����,�ö������ʽ��ʾ.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// </summary>");
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
                {
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">��ؼ���</param>", objInFor.PrivFuncName);
                }
                strCodeForCs.AppendFormat("\r\n /// <returns>�����</returns>");
                if (objPrjTabENEx.objCacheClassifyFld_TS == null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "public static cls{0}EN GetObjByKeyLst_WACache({2})",
                objPrjTabENEx.TabName, objKeyField.FldName, objPrjTabENEx.KeyVarDefineLstStr);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "public static cls{0}EN GetObjByKeyLst_WACache({2}, {3} {4})",
                        objPrjTabENEx.TabName, objKeyField.FldName, objPrjTabENEx.KeyVarDefineLstStr,
                    objPrjTabENEx.objCacheClassifyFld_TS.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objPrjTabENEx.objCacheClassifyFld_TS.PrivFuncName);
                }
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "string strAction = \"GetObjByKeyLstCache\";", objKeyField.FldName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">��ؼ���</param>", objKeyField.PrivFuncName);
                strCodeForCs.AppendFormat("\r\n /// <returns>�����</returns>");
                if (objPrjTabENEx.objCacheClassifyFld_TS == null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "public static cls{0}EN GetObjBy{1}_WACache({2})",
                objPrjTabENEx.TabName, objKeyField.FldName, objPrjTabENEx.KeyVarDefineLstStr);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "public static cls{0}EN GetObjBy{1}_WACache({2}, {3} {4})",
                        objPrjTabENEx.TabName, objKeyField.FldName, objPrjTabENEx.KeyVarDefineLstStr,
                    objPrjTabENEx.objCacheClassifyFld_TS.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    objPrjTabENEx.objCacheClassifyFld_TS.PrivFuncName);
                }
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "string strAction = \"GetObjBy{0}Cache\";", objKeyField.FldName);
            }

            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>()");
            strCodeForCs.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "[\"{0}\"] = {1}.ToString(){2}", objKeyField.FldName, objKeyField.PrivFuncName, objPrjTabENEx.objCacheClassifyFld_TS == null ? "" : ",");
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "[\"{0}\"] = {1}{2}", objKeyField.FldName, objKeyField.PrivFuncName, objPrjTabENEx.objCacheClassifyFld_TS == null ? "" : ",");
            }
            if (objPrjTabENEx.objCacheClassifyFld_TS != null)
            {
                strCodeForCs.AppendFormat("\r\n" + "[\"{0}\"] = {1}",
                objPrjTabENEx.objCacheClassifyFld_TS.FldName,
                objPrjTabENEx.objCacheClassifyFld_TS.PrivFuncName);
            }
            strCodeForCs.Append("\r\n" + "};");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = clsJSON.GetObjFromJson<cls{0}EN>(strResult);", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strJson = JsonConvert.SerializeObject(jobjReturn0[\"returnObj\"]);");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = JsonConvert.DeserializeObject<cls{0}EN>(strJson);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "return obj{0}EN;", objPrjTabENEx.TabName);

            //strCodeForCs.Append("\r\n" + "return bolReturnBool;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return null;");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"��ȡ������¼����,{0}.(from {1})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");


            //strCodeForCs.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            //objPrjTabENEx.TabName);

            //strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN = obj{0}Service.GetObjBy{2}({1});",
            //objPrjTabENEx.TabName, objKeyField.PrivFuncName, objKeyField.FldName);
            //strCodeForCs.AppendFormat("\r\n" + "return obj{0}EN;", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ɾ��������¼
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_DelRecord()
        {

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ���ݹؼ���ɾ����¼");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>ʵ��ɾ����¼�ĸ���</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static int DelRecord({0})",
            objPrjTabENEx.KeyVarDefineLstStr);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strAction = \"DelRecord\";");




            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                strCodeForCs.AppendFormat("\r\n cls{0}EN obj{0}EN = cls{0}WApi.GetObjByKeyLst({1});",
    objPrjTabENEx.TabName, strKeyFldName_PrivateVar);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n cls{0}EN obj{0}EN = cls{0}WApi.GetObjBy{1}({2});",
       objPrjTabENEx.TabName, objKeyField.FldName, strKeyFldName_PrivateVar);
            }
            strCodeForCs.AppendFormat("\r\n" + "if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, {0}.ToString(), out string strResult, out string strErrMsg) == true)",
                objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "int intResult  = int.Parse(strResult);");
            //strCodeForCs.Append("\r\n" + "return intResult;");
            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            if (objPrjTabENEx.IsUseCache_TS() == true && thisCacheClassify_TS.IsForExtendClass == false)
            {
                if (objPrjTabENEx.objCacheClassifyFld_TS == null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}WApi.ReFreshCache();", objPrjTabENEx.TabName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}WApi.ReFreshCache(obj{0}EN.{1});", objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld_TS.PropertyName(this.IsFstLcase));
                }
            }
                strCodeForCs.Append("\r\n" + "var intReturnInt = (int)jobjReturn0[\"returnInt\"];");
            strCodeForCs.Append("\r\n" + "return intReturnInt;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return 0;");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n string strMsg = string.Format(\"ִ��WebApi���ܳ���, {0}.(from {1}). WebApi��ַ:{2}).\",");
            strCodeForCs.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ɾ��������¼
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_DelMultiRecord()
        {
            if (objPrjTabENEx.arrKeyFldSet.Count > 1) return "";
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ���ݹؼ����б�ɾ����¼");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>ʵ��ɾ����¼�ĸ���</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static int Del{0}s(List<string> arr{1})",
            objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "string strAction = \"Del{0}s\";", objPrjTabENEx.TabName);


            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>();");


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "string strJSON = clsJSON.GetJsonFromObjLst(arr{0});",
                objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "int intResult  = int.Parse(strResult);");
            //strCodeForCs.Append("\r\n" + "return intResult;");
            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            if (objPrjTabENEx.IsUseCache_TS() == true && thisCacheClassify_TS.IsForExtendClass == false)
            {
                if (objPrjTabENEx.objCacheClassifyFld_TS == null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}WApi.ReFreshCache();", objPrjTabENEx.TabName);
                }
                else
                {
                    if (objKeyField.IsNumberType())
                    {
                        strCodeForCs.AppendFormat("\r\n cls{0}EN obj{0}EN = cls{0}WApi.GetObjBy{1}({2}.Parse(arr{1}[0]));",
        objPrjTabENEx.TabName, objKeyField.FldName, objKeyField.CsType);

                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n cls{0}EN obj{0}EN = cls{0}WApi.GetObjBy{1}(arr{1}[0]);",
        objPrjTabENEx.TabName, objKeyField.FldName, objKeyField.PrivFuncName);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}WApi.ReFreshCache(obj{0}EN.{1});", objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld_TS.PropertyName(this.IsFstLcase));
                }
            }
            strCodeForCs.Append("\r\n" + "var intReturnInt = (int)jobjReturn0[\"returnInt\"];");
            strCodeForCs.Append("\r\n" + "return intReturnInt;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return 0;");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n string strMsg = string.Format(\"ִ��WebApi���ܳ���, {0}.(from {1}). WebApi��ַ:{2}).\",");
            strCodeForCs.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }


        /// <summary>
        /// ɾ��������¼
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_DelRecords()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ���ݹؼ����б�ɾ����¼");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>ʵ��ɾ����¼�ĸ���</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static int DelRecords(string strKeyIdLst)",
            objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "string strAction = \"DelRecords\";", objPrjTabENEx.TabName);


            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>();");


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "string strJSON = clsJSON.GetJsonFromObjLst(strKeyIdLst);",
            //    objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "int intResult  = int.Parse(strResult);");
            //strCodeForCs.Append("\r\n" + "return intResult;");
            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "var intReturnInt = (int)jobjReturn0[\"returnInt\"];");
            strCodeForCs.Append("\r\n" + "return intReturnInt;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return 0;");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n string strMsg = string.Format(\"ִ��WebApi���ܳ���, {0}.(from {1}). WebApi��ַ:{2}).\",");
            strCodeForCs.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ɾ��������¼
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_DelMultiRecordByCond()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��������ɾ����¼");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>ʵ��ɾ����¼�ĸ���</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static int Del{0}sByCond(string strWhereCond)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "string strAction = \"Del{0}sByCond\";", objPrjTabENEx.TabName);


            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strCodeForCs.Append("\r\n" + "};");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "  int intRecCount =  int.Parse(strResult);");
            //strCodeForCs.Append("\r\n" + "return intRecCount;");
            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "var intReturnInt = (int)jobjReturn0[\"returnInt\"];");
            strCodeForCs.Append("\r\n" + "return intReturnInt;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return 0;");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n string strMsg = string.Format(\"ִ��WebApi���ܳ���, {0}.(from {1}). WebApi��ַ:{2}).\",");
            strCodeForCs.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }


        public string Gen_4WA_AddNewRecordWithMaxId()
        {
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "string") return "";

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��Ӽ�¼");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>�½���¼�Ĺؼ���</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static {1} AddNewRecordWithMaxId(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName, objKeyField.CsType);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strAction = \"AddNewRecordWithMaxId\";");


            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>();");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "string strJson = clsJSON.GetJsonFromObj<cls{0}EN>(obj{0}EN);",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "bool bolResult = bool.Parse(strResult);");
            //strCodeForCs.Append("\r\n" + "return bolResult;");
            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "// ��̬�Ķ����б�,���������ػ���,��Լ�¼����,��Ϊ���������ʹ��");
            if (objPrjTabENEx.IsUseCache_TS() == true && thisCacheClassify_TS.IsForExtendClass == false)
            {
                if (objPrjTabENEx.objCacheClassifyFld_TS == null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}WApi.ReFreshCache();", objPrjTabENEx.TabName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}WApi.ReFreshCache(obj{0}EN.{1});", objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld_TS.PropertyName(this.IsFstLcase));
                }
            }
                strCodeForCs.AppendFormat("\r\n" + "var {0} = ({1})jobjReturn0[\"returnStr\"];", objKeyField.PrivFuncName, objKeyField.CsType);
            strCodeForCs.AppendFormat("\r\n" + "return {0};", objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return \"\";");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n string strMsg = string.Format(\"ִ��WebApi���ܳ���, {0}.(from {1}). WebApi��ַ:{2}).\",");
            strCodeForCs.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public string Gen_4WA_AddNewRecord()
        {

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��Ӽ�¼");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>�Ƿ�ɹ�?</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static bool AddNewRecord(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strAction = \"AddNewRecord\";");


            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>();");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "string strJson = clsJSON.GetJsonFromObj<cls{0}EN>(obj{0}EN);",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "bool bolResult = bool.Parse(strResult);");
            //strCodeForCs.Append("\r\n" + "return bolResult;");
            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "// ��̬�Ķ����б�,���������ػ���,��Լ�¼����,��Ϊ���������ʹ��");
            if (objPrjTabENEx.IsUseCache_TS() == true && thisCacheClassify_TS.IsForExtendClass == false)
            {
                if (objPrjTabENEx.objCacheClassifyFld_TS == null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}WApi.ReFreshCache();", objPrjTabENEx.TabName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}WApi.ReFreshCache(obj{0}EN.{1});", objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld_TS.PropertyName(this.IsFstLcase));
                }
            }
            strCodeForCs.Append("\r\n" + "var bolReturnBool = (bool)jobjReturn0[\"returnBool\"];");
            strCodeForCs.Append("\r\n" + "return bolReturnBool;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return false;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n string strMsg = string.Format(\"ִ��WebApi���ܳ���, {0}.(from {1}). WebApi��ַ:{2}).\",");
            strCodeForCs.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        public string Gen_4WA_DefineObjCommFun4BL()
        {

            StringBuilder strCodeForCs = new StringBuilder();

            ///�๹����----------------------------------------------;
            strCodeForCs.Append("\r\n" + " /// <summary>");
            strCodeForCs.Append("\r\n" + "/// ר�����߼������ڴ�����ȹ��������Ķ���");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "/// </summary>");
            if (objPrjTabENEx.objCacheClassifyFld_TS == null)
            {
                strCodeForCs.Append("\r\n" + "public static clsCommFun4BL objCommFun4WApi = null;");
            }
            else
            {
                strCodeForCs.Append("\r\n" + "public static clsCommFun4BLV2 objCommFun4WApi = null;");
            }
            //strCodeForCs.Append("\r\n" + "public static event OnAddNewRecord onAddNewRecord;");
            //strCodeForCs.Append("\r\n" + "public static event OnUpdateRecord onUpdateRecord;");
            //strCodeForCs.Append("\r\n" + "public static event OnDeleteRecord onDelRecord;");

            return strCodeForCs.ToString();
        }

        public string Gen_4WA_CopyObj_S()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��ͬһ����Ķ���,���Ƶ���һ������");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">Դ����</param>", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}ENT\">Ŀ�����</param>", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n public static void CopyTo(cls{0}EN obj{0}ENS, cls{0}EN obj{0}ENT)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FldOpTypeId == "0004") continue;//������д
                if (objField.FldOpTypeId == "0002") //ֻ����д
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.Set{1}(obj{0}ENS.{1}); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName, objField.ObjFieldTabENEx.PrivPropName, objField.ColCaption);
                }
                else if (objField.FldOpTypeId == "0003") //ֻд
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.Get{2}(); //{3}",
                      objPrjTabENEx.TabName, objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase),
                      objField.ObjFieldTabENEx.FldName,
                      objField.ColCaption);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}ENT.{1} = obj{0}ENS.{1}; //{2}",
                    objPrjTabENEx.TabName, objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase), objField.ColCaption);
                }
            }

            //strCodeForCs.AppendFormat("\r\n" + "{0}DA.CopyTo(obj{0}ENS, obj{0}ENT);",
            //objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "CopyTo", "Copy��:{0} �������ݳ���!", "���ɴ���");

            strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{0})Copy��������ݳ���,{{1}}.({{0}})\",", strErrId, "{", "}");
            strCodeForCs.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.AppendFormat("\r\n" + "objException.Message); ");
            strCodeForCs.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strCodeForCs.AppendFormat("\r\n" + "throw new Exception(\"(errid:{22})Copy��:{0} �������ݳ���!({1}:CopyTo)\\r\\n\" + objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strCodeForCs.AppendFormat("\r\n" + "throw new Exception(\"Copy��:{0} �������ݳ���!({1}: CopyTo)\"+ objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n}");
            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strCodeForCs.ToString();
        }

        public string Gen_4WA_ToDataTable()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "/// <summary>");
            strCodeForCs.Append("\r\n" + "/// �����б� ת��Ϊ DataTable���ݼ���");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "/// </summary>");
            strCodeForCs.Append("\r\n" + "/// <param name=\"arrObj\">ԭ�����б�</param>");
            strCodeForCs.Append("\r\n" + "/// <returns>���ص�DataTable</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static DataTable ToDataTable(List<cls{0}EN> arrObj)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "DataTable dataTable = new DataTable(); //ʵ����");
            strCodeForCs.Append("\r\n" + "DataTable result;");

            strCodeForCs.Append("\r\n" + "if (arrObj.Count == 0) return null;");
            strCodeForCs.AppendFormat("\r\n" + "if (cls{0}EN.AttributeName.Length == 0)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "result = dataTable;");
            strCodeForCs.Append("\r\n" + "return result;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "Type type = typeof(cls{0}EN);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "PropertyInfo[] arrPropertyInfo = type.GetProperties();");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//Columns");
            strCodeForCs.AppendFormat("\r\n" + "foreach (string strAttrName in cls{0}EN.AttributeName)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();");
            strCodeForCs.Append("\r\n" + "dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN objInFor in arrObj)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//Rows");
            strCodeForCs.Append("\r\n" + "DataRow dataRow = dataTable.NewRow();");
            strCodeForCs.AppendFormat("\r\n" + "foreach (string strAttrName in cls{0}EN.AttributeName)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "dataRow[strAttrName] = objInFor[strAttrName];");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "dataTable.Rows.Add(dataRow); //ѭ������е�DataTable��");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objExceptoin)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "throw objExceptoin;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "result = dataTable;");
            strCodeForCs.Append("\r\n" + "return result;");
            strCodeForCs.Append("\r\n" + "}");

            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strCodeForCs.ToString();
        }



        public string Gen_4WA_UpdateRecord()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// �޸ļ�¼");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>�Ƿ�ɹ�?</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static bool UpdateRecord(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty(obj{0}EN.sfUpdFldSetStr) == true)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"�޸�ʱ,�޸ı�־��Ϊ��,����ϵ����Ա.����ؼ���:{0}.(from {1}).\",");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1}, clsStackTrace.GetCurrClassFunction());", objPrjTabENEx.TabName, objKeyField.PropertyName(this.IsFstLcase));
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "string strAction = \"UpdateRecord\";");


            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>();");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "string strJson = clsJSON.GetJsonFromObj<cls{0}EN>(obj{0}EN);",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "bool bolResult = bool.Parse(strResult);");
            //strCodeForCs.Append("\r\n" + "return bolResult;");
            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "var bolReturnBool = (bool)jobjReturn0[\"returnBool\"];");
            strCodeForCs.Append("\r\n" + "return bolReturnBool;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return false;");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n string strMsg = string.Format(\"ִ��WebApi���ܳ���, {0}.(from {1}). WebApi��ַ:{2}).\",");
            strCodeForCs.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public string Gen_4WA_EditRecordEx()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// �༭��¼�������������ھ��޸ģ������ھ����");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>�Ƿ�ɹ�?</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static bool EditRecordEx(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty(obj{0}EN.sfUpdFldSetStr) == true)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"�޸�ʱ,�޸ı�־��Ϊ��,����ϵ����Ա.����ؼ���:{0}.(from {1}).\",");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1}, clsStackTrace.GetCurrClassFunction());", objPrjTabENEx.TabName, objKeyField.PropertyName(this.IsFstLcase));
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "string strAction = \"EditRecordEx\";");


            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>();");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "string strJson = clsJSON.GetJsonFromObj<cls{0}EN>(obj{0}EN);",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "bool bolResult = bool.Parse(strResult);");
            //strCodeForCs.Append("\r\n" + "return bolResult;");
            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "var bolReturnBool = (bool)jobjReturn0[\"returnBool\"];");
            strCodeForCs.Append("\r\n" + "return bolReturnBool;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return false;");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n string strMsg = string.Format(\"ִ��WebApi���ܳ���, {0}.(from {1}). WebApi��ַ:{2}).\",");
            strCodeForCs.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }


        public string Gen_4WA_IsExistRecord()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ���������ж��Ƿ���ڼ�¼");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>�Ƿ����?���ڷ���True</returns>");
            strCodeForCs.Append("\r\n" + "public static bool IsExistRecord(string strWhereCond)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//����¼�Ƿ����");
            strCodeForCs.Append("\r\n" + "string strAction = \"IsExistRecord\";");


            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strCodeForCs.Append("\r\n" + "};");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "var bolReturnBool = (bool)jobjReturn0[\"returnBool\"];");
            strCodeForCs.Append("\r\n" + "return bolReturnBool;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return false;");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"��ȡ������¼����,{0}.(from {1})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            //objPrjTabENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "bool bolIsExist = obj{0}Service.IsExistRecord(strWhereCond);",
            //objPrjTabENEx.TabName);
            //strCodeForCs.Append("\r\n" + "return bolIsExist;");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public string Gen_4WA_GetRecCountByCond()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��ؼ�¼��");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">������</param>");
            strCodeForCs.Append("\r\n /// <returns>��¼��</returns>");
            strCodeForCs.Append("\r\n" + "public static int GetRecCountByCond(string strWhereCond)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "string strAction = \"GetRecCountByCond\";");


            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strCodeForCs.Append("\r\n" + "};");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "return int.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "var intReturnInt = (int)jobjReturn0[\"returnInt\"];");
            strCodeForCs.Append("\r\n" + "return intReturnInt;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return 0;");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"��ȡ������¼����,{0}.(from {1})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");


            //strCodeForCs.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            //objPrjTabENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "int intRecCount = obj{0}Service.GetRecCountByCond(strWhereCond);",
            //objPrjTabENEx.TabName);
            //strCodeForCs.Append("\r\n" + "return intRecCount;");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public string Gen_4WA_GetFldValue()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��ؼ�¼��");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">������</param>");
            strCodeForCs.Append("\r\n /// <returns>��¼��</returns>");
            strCodeForCs.Append("\r\n" + "public static List<string> GetFldValue(string strFldName, string strWhereCond)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "string strAction = \"GetFldValue\";");


            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "[\"strFldName\"] = strFldName,");
            strCodeForCs.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strCodeForCs.Append("\r\n" + "};");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "return int.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "var arrReturnStrLst = (List<string>)jobjReturn0[\"returnStrLst\"];");
            //strCodeForCs.Append("\r\n" + "return arrReturnStrLst;");
            strCodeForCs.Append("\r\n" + "string strReturnStrLst = (string)jobjReturn0[\"returnStrLst\"];");
            strCodeForCs.Append("\r\n" + "var arrReturnStrLst = strReturnStrLst.Split(\",\".ToCharArray());");
            strCodeForCs.Append("\r\n" + "return arrReturnStrLst.Select(x => x).ToList();");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return null;");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"��ȡ������¼����,{0}.(from {1})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");


            //strCodeForCs.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            //objPrjTabENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "int intRecCount = obj{0}Service.GetRecCountByCond(strWhereCond);",
            //objPrjTabENEx.TabName);
            //strCodeForCs.Append("\r\n" + "return intRecCount;");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        public string Gen_4WA_funSetFldValue()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// �������������ֶ�ֵ");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strFldName\">�ֶ���</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strValue\">ֵ</param>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">������</param>");
            strCodeForCs.Append("\r\n /// <returns>��¼��</returns>");
            strCodeForCs.Append("\r\n" + "public static int SetFldValue(string strFldName, string strValue, string strWhereCond)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "string strAction = \"SetFldValue\";");


            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "[\"strFldName\"] = strFldName,");
            strCodeForCs.Append("\r\n" + "[\"strValue\"] = strValue,");
            strCodeForCs.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strCodeForCs.Append("\r\n" + "};");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "return int.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "var arrReturnStrLst = (List<string>)jobjReturn0[\"returnStrLst\"];");
            //strCodeForCs.Append("\r\n" + "return arrReturnStrLst;");
            strCodeForCs.Append("\r\n" + "var intReturnInt = (int)jobjReturn0[\"returnInt\"];");
            strCodeForCs.Append("\r\n" + "return intReturnInt;");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return 0;");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"�������������ֶ�ֵ,{0}.(from {1})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");


            //strCodeForCs.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            //objPrjTabENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "int intRecCount = obj{0}Service.GetRecCountByCond(strWhereCond);",
            //objPrjTabENEx.TabName);
            //strCodeForCs.Append("\r\n" + "return intRecCount;");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }


        public string Gen_4WA_IsExist()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ���ݹؼ����ж��Ƿ���ڼ�¼");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns>�Ƿ����?���ڷ���True</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static bool IsExist({0})",
            objPrjTabENEx.KeyVarDefineLstStr);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//����¼�Ƿ����");
            strCodeForCs.Append("\r\n" + "string strAction = \"IsExist\";");


            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>()");
            strCodeForCs.Append("\r\n" + "{");
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
                {                   
                    
                    if (objInFor.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == false)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "[\"{0}\"] = {0}.ToString(),", objInFor.PrivFuncName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "[\"{0}\"] = {0},", objInFor.PrivFuncName);
                    }
                }
            }
            else
            {

                if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == false)
                {
                    strCodeForCs.AppendFormat("\r\n" + "[\"{0}\"] = {0}.ToString()", objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "[\"{0}\"] = {0}", objKeyField.PrivFuncName);
                }
            }
            strCodeForCs.Append("\r\n" + "};");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "bool bolIsExist = bool.Parse(strResult);");
            //strCodeForCs.Append("\r\n" + "return bolIsExist;");
            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "var bolReturnBool = (bool)jobjReturn0[\"returnBool\"];");
            strCodeForCs.Append("\r\n" + "return bolReturnBool;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return false;");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"��ȡ������¼����,{0}.(from {1})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.AppendFormat("\r\n" + "{0}ServiceSoapClient obj{0}Service = Get{0}ServiceSoapClient();",
            //objPrjTabENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "bool bolIsExist = obj{0}Service.IsExist({1});",
            //objPrjTabENEx.TabName, objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            //strCodeForCs.Append("\r\n" + "return bolIsExist;");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_4WA_GetMaxStrId()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ��ȡ��ǰ��ؼ���ֵ�����ֵ,�ټ�1,�����ظ�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.Append("\r\n /// <returns>��ǰ��ؼ���ֵ�����ֵ,�ټ�1</returns>");
                strCodeForCs.AppendFormat("\r\n" + "public static string GetMaxStrId()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strAction = \"GetMaxStrId\";");


                strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>();");


                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)");
                strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.AppendFormat("\r\n" + "string strMax{0} = strResult;",
                //objKeyField.FldName_FstUcase);
                //strCodeForCs.AppendFormat("\r\n" + "return strMax{0};",
                //objKeyField.FldName_FstUcase);
                strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
                strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "var strReturnStr = (string)jobjReturn0[\"returnStr\"];");
                strCodeForCs.Append("\r\n" + "return strReturnStr;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else return \"\";");

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"��ȡ���ֵ����,{0}.(from {1})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "}");
            }
            return strCodeForCs.ToString();
        }

        public string Gen_4WA_GetMaxStrIdByPrefix()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ����ǰ׺��ȡ��ǰ��ؼ���ֵ�����ֵ,�ټ�1,�����ظ�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.Append("\r\n /// <returns>��ǰ��ؼ���ֵ�����ֵ,�ټ�1</returns>");
                strCodeForCs.AppendFormat("\r\n" + "public static string GetMaxStrIdByPrefix(string strPrefix)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//����¼�Ƿ����");
                strCodeForCs.Append("\r\n" + "string strAction = \"GetMaxStrIdByPrefix\";");


                strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "{\"strPrefix\", strPrefix}");
                strCodeForCs.Append("\r\n" + "};");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)");
                strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.AppendFormat("\r\n" + "string strMax{0} = strResult;",
                //objKeyField.FldName_FstUcase);
                //strCodeForCs.AppendFormat("\r\n" + "return strMax{0};",
                //objKeyField.FldName_FstUcase);
                strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
                strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "var strReturnStr = (string)jobjReturn0[\"returnStr\"];");
                strCodeForCs.Append("\r\n" + "return strReturnStr;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else return \"\";");

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (Exception objException)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"����ǰ׺��ȡ���ֵ����,{0}.(from {1})\", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());");
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "}");
            }
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ��ȡ��ǰ�����������ĵ�һ����¼�Ĺؼ���ֵ
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_GetFirstID()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��ȡ��ǰ�����������ĵ�һ����¼�Ĺؼ���ֵ");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">������</param>");
            strCodeForCs.Append("\r\n /// <returns>���صĵ�һ����¼�Ĺؼ���ֵ</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static {0} GetFirstID(string strWhereCond)",
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "string strAction = \"GetFirstID\";");


            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strCodeForCs.Append("\r\n" + "};");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            switch (objKeyField.CsType)
            {
                case "long":
                    //strCodeForCs.Append("\r\n" + "return long.Parse(strResult);");
                    strCodeForCs.Append("\r\n" + "var strReturnStr = (string)jobjReturn0[\"returnStr\"];");
                    strCodeForCs.Append("\r\n" + "return long.Parse(strReturnStr);");
                    break;
                case "int":
                    //strCodeForCs.Append("\r\n" + "return int.Parse(strResult);");
                    strCodeForCs.Append("\r\n" + "var strReturnStr = (string)jobjReturn0[\"returnStr\"];");
                    strCodeForCs.Append("\r\n" + "return int.Parse(strReturnStr);");
                    break;
                default:
                    //strCodeForCs.Append("\r\n" + "return strResult;");
                    strCodeForCs.Append("\r\n" + "var strReturnStr = (string)jobjReturn0[\"returnStr\"];");
                    strCodeForCs.Append("\r\n" + "return strReturnStr;");
                    break;
            }
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            if (clsDataTypeAbbrBLEx.IsNumberType(objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN) == true)
            {
                strCodeForCs.Append("\r\n" + "else return 0;");
            }
            else
            {
                strCodeForCs.Append("\r\n" + "else return \"\";");
            }
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n string strMsg = string.Format(\"ִ��WebApi���ܳ���, {0}.(from {1}). WebApi��ַ:{2}).\",");
            strCodeForCs.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ��ȡ��ǰ�����������ĵ�һ����¼�Ķ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_GetFirstObj()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��ȡ��ǰ�����������ĵ�һ����¼�Ķ���");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">������</param>");
            strCodeForCs.Append("\r\n /// <returns>���صĵ�һ����¼�Ĺؼ���ֵ</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static cls{1}EN GetFirstObj(string strWhereCond)",
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "string strAction = \"GetFirstObj\";", objPrjTabENEx.TabName);


            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "[\"strWhereCond\"] = strWhereCond");
            strCodeForCs.Append("\r\n" + "};");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = clsJSON.GetObjFromJson<cls{0}EN>(strResult);", objPrjTabENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "return obj{0}EN;", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strJson = JsonConvert.SerializeObject(jobjReturn0[\"returnObj\"]);");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = JsonConvert.DeserializeObject<cls{0}EN>(strJson);",
                objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "return obj{0}EN;", objPrjTabENEx.TabName);

            //strCodeForCs.Append("\r\n" + "return bolReturnBool;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return null;");


            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n string strMsg = string.Format(\"ִ��WebApi���ܳ���, {0}.(from {1}). WebApi��ַ:{2}).\",");
            strCodeForCs.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }


        /// <summary>
        /// ��Ӽ�¼,���ҷ��عؼ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_AddNewRecordWithReturnKey()
        {
            if (objKeyField.PrimaryTypeId != "02") return "";

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// �ѱ������ӵ����ݿ���,���ҷ��ظü�¼�Ĺؼ���(���Identity�ؼ���)");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵı����</param>",
                    objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n /// <returns>��������Ӽ�¼�Ĺؼ���</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static string AddNewRecordWithReturnKey(cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strAction = \"AddNewRecordWithReturnKey\";");

            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>();");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "string strJson = clsJSON.GetJsonFromObj<cls{0}EN>(obj{0}EN);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "string strKey = strResult;",
            //objPrjTabENEx.TabName);
            //strCodeForCs.Append("\r\n" + "return strKey;");
            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "// ��̬�Ķ����б�,���������ػ���,��Լ�¼����,��Ϊ���������ʹ��");
            if (objPrjTabENEx.IsUseCache_TS() == true && thisCacheClassify_TS.IsForExtendClass == false)
            {
                if (objPrjTabENEx.objCacheClassifyFld_TS == null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}WApi.ReFreshCache();", objPrjTabENEx.TabName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}WApi.ReFreshCache(obj{0}EN.{1});", objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld_TS.PropertyName(this.IsFstLcase));
                }
            }
                strCodeForCs.Append("\r\n" + "var strReturnStr = (string)jobjReturn0[\"returnStr\"];");
            strCodeForCs.Append("\r\n" + "return strReturnStr;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return \"\";");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n string strMsg = string.Format(\"ִ��WebApi���ܳ���, {0}.(from {1}). WebApi��ַ:{2}).\",");
            strCodeForCs.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ��Ӽ�¼,���ҷ��عؼ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_UpdateWithCondition()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��ȡ��ǰ�����������ĵ�һ����¼�Ķ���");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ�޸ĵĶ���</param>",
                  objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">������</param>");
            strCodeForCs.Append("\r\n /// <returns>���صĵ�һ����¼�Ĺؼ���ֵ</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static bool UpdateWithCondition(cls{0}EN obj{0}EN, string strWhereCond)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty(obj{0}EN.sfUpdFldSetStr) == true)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"�޸�ʱ,�޸ı�־��Ϊ��,����ϵ����Ա.����ؼ���:{0}.(from {1}).\",");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1}, clsStackTrace.GetCurrClassFunction());", objPrjTabENEx.TabName, objKeyField.PropertyName(this.IsFstLcase));
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "if (string.IsNullOrEmpty(strWhereCond) == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"�������޸�ʱ,������Ϊ��,����ϵ����Ա.����ؼ���:{0}.(from {1}).\",");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1}, clsStackTrace.GetCurrClassFunction());", objPrjTabENEx.TabName, objKeyField.PropertyName(this.IsFstLcase));
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "string strAction = \"UpdateWithCondition\";");


            strCodeForCs.Append("\r\n" + "Dictionary<string, string> dictParam = new Dictionary<string, string>();");


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "string strJson = clsJSON.GetJsonFromObj<cls{0}EN>(obj{0}EN);",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out string strResult, out string strErrMsg) == true)");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "bool bolResult = bool.Parse(strResult);");
            //strCodeForCs.Append("\r\n" + "return bolResult;");
            strCodeForCs.Append("\r\n" + "JObject jobjReturn0 = JObject.Parse(strResult);");
            strCodeForCs.Append("\r\n" + "if ((int)jobjReturn0[\"errorId\"] == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "var bolReturnBool = (bool)jobjReturn0[\"returnBool\"];");
            strCodeForCs.Append("\r\n" + "return bolReturnBool;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"{0}\", jobjReturn0[\"errorMsg\"]);");
            strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else return false;");

            strCodeForCs.Append("\r\n" + "}");



            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n string strMsg = string.Format(\"ִ��WebApi���ܳ���, {0}.(from {1}). WebApi��ַ:{2}).\",");
            strCodeForCs.Append("\r\n      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));");

            strCodeForCs.AppendFormat("\r\n throw new Exception(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
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
            if (objPrjTabENEx.IsUseCache_TS() == false) return $"//�ñ�û��ʹ��Cache,����Ҫ����[Get{strTextFieldName}By{objKeyField.FldName}Cache]����;(in {clsStackTrace.GetCurrClassFunction()})";

            StringBuilder strCodeForCs = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;

            strCodeForCs.AppendFormat("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// ���ݹؼ��ֻ�ȡ�������, �ӻ���Ķ����б��л�ȡ.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���</param>", objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n /// <returns>���ݹؼ��ֻ�ȡ������</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static string Get{4}By{1}Cache({2} {3})",
            objPrjTabENEx.TabName,
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
            objKeyField.PrivFuncName,
            strTextFieldName);
            strCodeForCs.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true) return \"\";",
                  objKeyField.PrivFuncName);
            }
            strCodeForCs.Append("\r\n" + "//��ʼ���б���");
            strCodeForCs.Append("\r\n" + "InitListCache(); ");


            strCodeForCs.Append("\r\n" + "int intStart = 0;");
            strCodeForCs.AppendFormat("\r\n" + "int intEnd = arr{0}ObjLstCache.Count - 1;", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "int intMid = 0;");
            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
                 objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "while (intEnd >= intStart)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "intMid = (intStart + intEnd) / 2;");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = arr{0}ObjLstCache[intMid];",
              objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.{1} == {2})",
                objPrjTabENEx.TabName,
                objKeyField.PropertyName(this.IsFstLcase),
                objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "intFindFailCount = 0;");
            strCodeForCs.AppendFormat("\r\n" + "return obj{0}EN.{1};",
                  objPrjTabENEx.TabName,
                  strTextFieldName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "else if (obj{0}EN.{1}.CompareTo({2}) > 0)",
                  objPrjTabENEx.TabName,
                  objKeyField.PropertyName(this.IsFstLcase),
                  objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "intEnd = intMid - 1;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "intStart = intMid + 1;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");


            //strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0}EN in arr{0}ObjLstCache)",
            //objPrjTabENEx.TabName);
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.{1} == {2})",
            //objPrjTabENEx.TabName,
            //objKeyField.FldName,
            //objKeyField.PrivFuncName);
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "return obj{0}EN.{1};",
            //objPrjTabENEx.TabName,
            //strTextFieldName);
            //strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "intFindFailCount++;");
            strCodeForCs.AppendFormat("\r\n" + "// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "if (intFindFailCount == 1) return Get{0}By{1}Cache({2});",
                strTextFieldName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n" + "string strErrMsgForGetObjById = string.Format(\"��{2}���󻺴��б���,�Ҳ�����¼[{3} = {{0}}][intFindFailCount = {{1}}](����:{{2}})\", {4}, intFindFailCount, clsStackTrace.GetCurrFunction());",
              "{", "}",
              objPrjTabENEx.TabName,
              objKeyField.FldName,
              objKeyField.PrivFuncName,
              strTextFieldName);
            strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN != null)",
                  objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "strErrMsgForGetObjById += string.Format(\"���һ�β��ҵĶ�������ֶ�����ֵ:{{0}}.[intMid = {{1}}]\", obj{2}EN.{3}, intMid);",
               "{", "}",
               objPrjTabENEx.TabName,
               objKeyField.PropertyName(this.IsFstLcase));
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "strErrMsgForGetObjById += string.Format(\"���һ�β��ҵĶ���Ϊnull, ����![intMid = {{0}}]\", intMid);",
               "{", "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "clsLog.LogErrorS2(\"cls{0}BL\", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, \"\", \"\");",
               objPrjTabENEx.TabName,
                objKeyField.FldName,
                strTextFieldName);
            //strCodeForCs.Append("\r\n" + "// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
            //strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
            //       objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "throw new Exception(strErrMsgForGetObjById);");
            //strCodeForCs.AppendFormat("\r\n" + "return \"\";");
            strCodeForCs.Append("\r\n" + "}");

            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strCodeForCs.ToString();
        }


        /// <summary>
        /// ��ʼ���б���.
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_InitListCache()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //��ʼ���б���.-----------------------------;


            strCodeForCs.AppendFormat("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// ��ʼ���б���.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// </summary>");
            strCodeForCs.Append("\r\n" + "public static void InitListCache()");
            strCodeForCs.Append("\r\n" + "{");

            if (objPrjTabENEx.SqlDsTypeId == clsSQLDSTypeBLEx.SQLTAB)
            {
                strCodeForCs.Append("\r\n" + "//��黺��ˢ�»���");
                strCodeForCs.Append("\r\n" + "string strMsg;");
                strCodeForCs.AppendFormat("\r\n" + "if (cls{0}WApi.objCommFun4WApi == null)", objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"��cls{2}WApiû��ˢ�»������({2}_objCommFun4WApi == null), ����ϵ����Ա!(from {{0}})\", clsStackTrace.GetCurrClassFunction());",
                    "{", "}", objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + "}");
            }
            else if (objPrjTabENEx.SqlDsTypeId == clsSQLDSTypeBLEx.SQLVIEW)
            {
                List<string> arrTabId = clsPrjTabBLEx.GetRelaParentNodeByTabId(objPrjTabENEx.TabId, objPrjTabENEx.PrjId);
                bool bolIsDef_strMsg = false;
                foreach (string strRelaTabId in arrTabId)
                {
                    clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strRelaTabId, objPrjTabENEx.PrjId);
                    if (objPrjTab.SqlDsTypeId == clsSQLDSTypeBLEx.SQLVIEW) continue;
                    if (objPrjTab.TabName == "Sex")
                    {
                        string strMsg = string.Format("objPrjTab.TabName={0},objPrjTab.TabStateId='{1}'",
                            objPrjTab.TabName, objPrjTab.TabStateId);
                        clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
                    }
                    if (objPrjTab.TabStateId != "01") continue;

                    if (bolIsDef_strMsg == false)
                    {
                        strCodeForCs.Append("\r\n" + "//��黺��ˢ�»���");
                        strCodeForCs.Append("\r\n" + "string strMsg;");
                        bolIsDef_strMsg = true;
                    }
                    strCodeForCs.AppendFormat("\r\n" + "if (cls{0}WApi.objCommFun4WApi == null)", objPrjTab.TabName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"��cls{2}WApiû��ˢ�»������(cls{2}WApi.objCommFun4WApi == null), ����ϵ����Ա!(from {{0}})\", clsStackTrace.GetCurrClassFunction());",
                        "{", "}", objPrjTab.TabName);
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                }
            }

            strCodeForCs.Append("\r\n" + "//��ʼ���б���");
            strCodeForCs.AppendFormat("\r\n" + "//string strWhereCond = string.Format(\"1 = 1 order by {0}\");", objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "//if (arr{0}ObjLstCache == null)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "//{");
            strCodeForCs.AppendFormat("\r\n" + "//arr{0}ObjLstCache = await cls{0}WApi.GetObjLst(strWhereCond);",
                  objPrjTabENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "intFldNumCache = arr{0}ObjLstCache.Count;", 
            //      objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "//}");
            strCodeForCs.Append("\r\n" + "}");

            //��ʼ���б���.======================= = ;
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_GetObjByKeyCache()
        {
            if (objPrjTabENEx.IsUseCache == false) return string.Format("//�ñ�û��ʹ��Cache,����Ҫ����[GetObjByKeyLstCache()]����;",
                               objKeyField.FldName);
            if (objPrjTabENEx.IsUseCache_TS() == false) return $"//�ñ�û��ʹ��Cache,����Ҫ����[GetObjByKeyLstCache()]����;(in {clsStackTrace.GetCurrClassFunction()})";
            Tuple<string,string, string> tup = thisWA_FP(WA_F.GetObjByKeyId_Cache, "CSharp");
            var strFuncParamsDefLst = tup.Item1;
            var strFuncParamsLst = tup.Item2;
            //var strFuncParamsLst_Cache = tup.Item3;


            Tuple<string, string, string> tup_GetObjLstCache = thisWA_FP(WA_F.GetObjLst_Cache, "CSharp");
   
            var strFuncParamsLst_Cache = tup_GetObjLstCache.Item2;


            StringBuilder strCodeForCs = new StringBuilder();
            //���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;

            strCodeForCs.AppendFormat("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// ���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.û�оͷ���null.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// </summary>");
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
                {
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">��ؼ���</param>", objInFor.PrivFuncName);
                }
                strCodeForCs.AppendFormat("\r\n /// <returns>���ݹؼ��ֻ�ȡ�Ķ���</returns>");


                strCodeForCs.AppendFormat("\r\n" + "public static cls{0}EN GetObjByKeyLstCache({1})",
         objPrjTabENEx.TabName,
         strFuncParamsDefLst);

                strCodeForCs.Append("\r\n" + "{");
                foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
                {
                    if (objInFor.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true) return null;",
                          objKeyField.PrivFuncName);
                    }
                }
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���</param>", objKeyField.PrivFuncName);
                strCodeForCs.AppendFormat("\r\n /// <returns>���ݹؼ��ֻ�ȡ�Ķ���</returns>");


                strCodeForCs.Append("\r\n" + $"public static cls{objPrjTabENEx.TabName}EN GetObjBy{objKeyField.FldName}Cache({strFuncParamsDefLst})");

                strCodeForCs.Append("\r\n" + "{");
                if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true) return null;",
                      objKeyField.PrivFuncName);
                }
            }
            strCodeForCs.Append("\r\n" + "//��ʼ���б���");
            //strCodeForCs.Append("\r\n" + "InitListCache(); ");
            if (objPrjTabENEx.objCacheClassifyFld_TS == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "string strKey = string.Format(\"{{0}}\", cls{0}EN._CurrTabName);",
                    objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLstCache = GetObjLstCache();",
                    objPrjTabENEx.TabName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "string strKey = string.Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1});",
                                objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld_TS.PrivFuncName);
                strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLstCache = GetObjLstCache({1});",
                    objPrjTabENEx.TabName, strFuncParamsLst_Cache);
            }
            strCodeForCs.AppendFormat("\r\n" + "IEnumerable <cls{0}EN> arr{0}ObjLst_Sel =", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "from obj{0}EN in arr{0}ObjLstCache", objPrjTabENEx.TabName);
            int intIndex = 0;
            foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
            {
                if (intIndex == 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "where obj{0}EN.{1} == {2} ",
                objPrjTabENEx.TabName,
                objInFor.PropertyName(this.IsFstLcase),
                objInFor.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + " && obj{0}EN.{1} == {2} ",
                objPrjTabENEx.TabName,
                objInFor.PropertyName(this.IsFstLcase),
                objInFor.PrivFuncName);
                }
                intIndex++;
            }
            strCodeForCs.AppendFormat("\r\n" + "select obj{0}EN;", objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ObjLst_Sel.Count() == 0)",
      objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {
                strCodeForCs.AppendFormat("\r\n" + "   cls{0}EN obj = cls{0}WApi.GetObjByKeyLst({2});",
                         objPrjTabENEx.TabName,
                         objKeyField.FldName,
                         objPrjTabENEx.KeyPrivFuncFldNameLstStr);

            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "   cls{0}EN obj = cls{0}WApi.GetObjBy{1}({2});",
                            objPrjTabENEx.TabName,
                            objKeyField.FldName,
                            objPrjTabENEx.KeyPrivFuncFldNameLstStr);
            }
            strCodeForCs.Append("\r\n" + "   if (obj != null)");
            strCodeForCs.Append("\r\n" + " {");
            //strCodeForCs.AppendFormat("\r\n" + "     cls{0}BL.arr{0}ObjLstCache = null;",
            //            objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "CacheHelper.Remove(strKey);", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "     return obj;");
            strCodeForCs.Append("\r\n" + " }");
            strCodeForCs.Append("\r\n" + "return null;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLst_Sel.First();", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");

            //���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strCodeForCs.ToString();
        }

        /// ���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_GetObjLstByKeyLstCache()
        {

            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;     
            if (objPrjTabENEx.IsUseCache == false) return string.Format("//�ñ�û��ʹ��Cache,����Ҫ����[GetObjLstByKeyLstsCache()]����;",
                              objKeyField.FldName);

            if (objPrjTabENEx.IsUseCache_TS() == false) return $"//�ñ�û��ʹ��Cache,����Ҫ����[GetObjLstByKeyLstsCache()]����;(in {clsStackTrace.GetCurrClassFunction()})";


            Tuple<string, string, string> tup = thisWA_FP(WA_F.GetObjLst_Cache, "CSharp");
            var strFuncParamsDefLst = tup.Item1;
            var strFuncParamsLst = tup.Item2;

            StringBuilder strCodeForCs = new StringBuilder();
            //���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;

            strCodeForCs.AppendFormat("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// ���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.û�оͷ���null.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// </summary>");
            if (objPrjTabENEx.arrKeyFldSet.Count > 1)
            {


                if (objPrjTabENEx.objCacheClassifyFld_TS == null)
                {
                    foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
                    {
                        strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">��ؼ���</param>", objInFor.PrivFuncName);
                    }
                    strCodeForCs.AppendFormat("\r\n /// <returns>���ݹؼ����б��ȡ�Ķ���</returns>");
                    strCodeForCs.AppendFormat("\r\n" + "public static IEnumerable<cls{0}EN> GetObjLstByKeyLstsCache(List<{2}> arr{1})",
                objPrjTabENEx.TabName,
                objKeyField.FldName_FstUcase,
                objKeyField.CsType,
                objKeyField.PrivFuncName);
                }
                else
                {
                    foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
                    {
                        strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">��ؼ���</param>", objInFor.PrivFuncName);
                    }
                    strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">�����ֶ�ֵ</param>", objPrjTabENEx.objCacheClassifyFld_TS.PrivFuncName);
                    strCodeForCs.AppendFormat("\r\n /// <returns>���ݹؼ����б��ȡ�Ķ���</returns>");
                    strCodeForCs.AppendFormat("\r\n" + "public static IEnumerable<cls{0}EN> GetObjLstByKeyLstsCache(List<{2}> arr{1}, {3})",
             objPrjTabENEx.TabName,
             objKeyField.FldName_FstUcase,
             objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
             strFuncParamsDefLst);
                }
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n /// <param name = \"arr{0}\">�����Ĺؼ����б�</param>", objKeyField.FldName_FstUcase);
                strCodeForCs.AppendFormat("\r\n /// <returns>���ݹؼ����б��ȡ�Ķ���</returns>");

                if (objPrjTabENEx.objCacheClassifyFld_TS == null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "public static IEnumerable<cls{0}EN> GetObjLstBy{1}LstCache(List<{2}> arr{1})",
                objPrjTabENEx.TabName,
                objKeyField.FldName_FstUcase,
                objKeyField.CsType,
                objKeyField.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "public static IEnumerable<cls{0}EN> GetObjLstBy{1}LstCache(List<{2}> arr{1}, {3})",
             objPrjTabENEx.TabName,
             objKeyField.FldName_FstUcase,
             objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                    strFuncParamsDefLst);
                }

            }

            strCodeForCs.Append("\r\n" + "{");
            //if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true) return null;",
            //      objKeyField.PrivFuncName);
            //}
            strCodeForCs.Append("\r\n" + "//��ʼ���б���");
            //strCodeForCs.Append("\r\n" + "InitListCache(); ");
            if (objPrjTabENEx.objCacheClassifyFld_TS == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "string strKey = string.Format(\"{{0}}\", cls{0}EN._CurrTabName);",
                    objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLstCache = GetObjLstCache();",
                    objPrjTabENEx.TabName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "string strKey = string.Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1});",
                                objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld_TS.PrivFuncName);
                strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLstCache = GetObjLstCache({1});",
                    objPrjTabENEx.TabName, strFuncParamsLst);
            }
            strCodeForCs.AppendFormat("\r\n" + "IEnumerable <cls{0}EN> arr{0}ObjLst_Sel =", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "from obj{0}EN in arr{0}ObjLstCache", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "where arr{1}.Contains(obj{0}EN.{2})",
                objPrjTabENEx.TabName,
                objKeyField.FldName_FstUcase,
                objKeyField.PropertyName(this.IsFstLcase));
            strCodeForCs.AppendFormat("\r\n" + "select obj{0}EN;", objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLst_Sel;", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");

            //���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strCodeForCs.ToString();
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

            Tuple<string, string, string> tup = thisWA_FP(WA_F.GetRecNameByKeyCache, "CSharp");
            var strFuncParamsDefLst = tup.Item1;
            var strFuncParamsLst = tup.Item2;
            //var strFuncParamsLst_Cache = tup.Item3;


            Tuple<string, string, string> tup_GetObjLstCache = thisWA_FP(WA_F.GetObjLst_Cache, "CSharp");

            var strFuncParamsLst_Cache = tup_GetObjLstCache.Item2;


            StringBuilder strCodeForCs = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;

            strCodeForCs.AppendFormat("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// ���ݹؼ��ֻ�ȡ�������, �ӻ���Ķ����б��л�ȡ.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���</param>", objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n /// <returns>���ݹؼ��ֻ�ȡ������</returns>");
            if (objPrjTabENEx.objCacheClassifyFld_TS == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "public static string Get{4}By{1}Cache({2} {3})",
            objPrjTabENEx.TabName,
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
            objKeyField.PrivFuncName,
            strTextFieldName);
            }
            else
            {
                strCodeForCs.Append("\r\n" + $"public static string Get{strTextFieldName}By{objKeyField.FldName}Cache({strFuncParamsDefLst})");
            }
            strCodeForCs.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true) return \"\";",
                  objKeyField.PrivFuncName);
            }
            strCodeForCs.Append("\r\n" + "//��ʼ���б���");
            //strCodeForCs.Append("\r\n" + "InitListCache(); ");
            if (objPrjTabENEx.objCacheClassifyFld_TS == null)
            {
                //strCodeForCs.AppendFormat("\r\n" + "string strKey = string.Format(\"{{0}}\", cls{0}EN._CurrTabName);",
                //    objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLstCache = GetObjLstCache();",
                    objPrjTabENEx.TabName);
            }
            else
            {
                //strCodeForCs.AppendFormat("\r\n" + "string strKey = string.Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1});",
                //                objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld_TS.PrivFuncName);
                strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLstCache = GetObjLstCache({1});",
                    objPrjTabENEx.TabName, strFuncParamsLst_Cache);
            }

            strCodeForCs.AppendFormat("\r\n" + "IEnumerable <cls{0}EN> arr{0}ObjLst_Sel1 =", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "from obj{0}EN in arr{0}ObjLstCache", objPrjTabENEx.TabName);
            int intIndex = 0;
            foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
            {
                if (intIndex == 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "where obj{0}EN.{1} == {2} ",
                objPrjTabENEx.TabName,
                objInFor.PropertyName(this.IsFstLcase),
                objInFor.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + " && obj{0}EN.{1} == {2} ",
                objPrjTabENEx.TabName,
                objInFor.PropertyName(this.IsFstLcase),
                objInFor.PrivFuncName);
                }
                intIndex++;
            }
            strCodeForCs.AppendFormat("\r\n" + "select obj{0}EN;", objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "List <cls{0}EN> arr{0}ObjLst_Sel = new List<cls{0}EN>();", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj in arr{0}ObjLst_Sel1)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst_Sel.Add(obj);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ObjLst_Sel.Count > 0)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLst_Sel[0].{1};",
                objPrjTabENEx.TabName, strTextFieldName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "string strErrMsgForGetObjById = string.Format(\"��{2}���󻺴��б���,�Ҳ�����¼[{3} = {{0}}](����:{{1}})\", {4}, clsStackTrace.GetCurrFunction());",
              "{", "}",
              objPrjTabENEx.TabName,
              objKeyField.FldName,
              objKeyField.PrivFuncName,
              strTextFieldName);
            strCodeForCs.AppendFormat("\r\n" + "clsLog.LogErrorS2(\"cls{0}BL\", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, \"\", \"\");",
               objPrjTabENEx.TabName,
                objKeyField.FldName,
                strTextFieldName);
            //strCodeForCs.Append("\r\n" + "// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
            //strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
            //       objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "throw new Exception(strErrMsgForGetObjById);");
            //strCodeForCs.AppendFormat("\r\n" + "return \"\";");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// ���ݹؼ��ֻ�ȡ�������, �ӻ���Ķ����б��л�ȡ.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���</param>", objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n /// <returns>���ݹؼ��ֻ�ȡ������</returns>");
            if (objPrjTabENEx.objCacheClassifyFld_TS == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "public static string GetNameBy{1}Cache({2} {3})",
            objPrjTabENEx.TabName,
            objKeyField.FldName,
            objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
            objKeyField.PrivFuncName,
            strTextFieldName);
            }
            else
            {
                strCodeForCs.Append("\r\n" + $"public static string GetNameBy{objKeyField.FldName}Cache({strFuncParamsDefLst})");
            }
            strCodeForCs.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}) == true) return \"\";",
                  objKeyField.PrivFuncName);
            }
            strCodeForCs.Append("\r\n" + "//��ʼ���б���");
            //strCodeForCs.Append("\r\n" + "InitListCache(); ");

            if (objPrjTabENEx.objCacheClassifyFld_TS == null)
            {
                //strCodeForCs.AppendFormat("\r\n" + "string strKey = string.Format(\"{{0}}\", cls{0}EN._CurrTabName);",
                //    objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLstCache = GetObjLstCache();",
                    objPrjTabENEx.TabName);
            }
            else
            {
                //strCodeForCs.AppendFormat("\r\n" + "string strKey = string.Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1});",
                //                objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld_TS.PrivFuncName);
                strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLstCache = GetObjLstCache({1});",
                    objPrjTabENEx.TabName, strFuncParamsLst_Cache);
            }
            strCodeForCs.AppendFormat("\r\n" + "IEnumerable <cls{0}EN> arr{0}ObjLst_Sel1 =", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "from obj{0}EN in arr{0}ObjLstCache", objPrjTabENEx.TabName);
            intIndex = 0;
            foreach (var objInFor in objPrjTabENEx.arrKeyFldSet)
            {
                if (intIndex == 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "where obj{0}EN.{1} == {2} ",
                objPrjTabENEx.TabName,
                objInFor.PropertyName(this.IsFstLcase),
                objInFor.PrivFuncName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + " && obj{0}EN.{1} == {2} ",
                objPrjTabENEx.TabName,
                objInFor.PropertyName(this.IsFstLcase),
                objInFor.PrivFuncName);
                }
                intIndex++;
            }
            strCodeForCs.AppendFormat("\r\n" + "select obj{0}EN;", objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "List <cls{0}EN> arr{0}ObjLst_Sel = new List<cls{0}EN>();", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj in arr{0}ObjLst_Sel1)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst_Sel.Add(obj);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ObjLst_Sel.Count > 0)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLst_Sel[0].{1};",
                objPrjTabENEx.TabName, strTextFieldName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "string strErrMsgForGetObjById = string.Format(\"��{2}���󻺴��б���,�Ҳ�����¼���������[{3} = {{0}}](����:{{1}})\", {4}, clsStackTrace.GetCurrFunction());",
              "{", "}",
              objPrjTabENEx.TabName,
              objKeyField.FldName,
              objKeyField.PrivFuncName,
              strTextFieldName);
            strCodeForCs.AppendFormat("\r\n" + "clsLog.LogErrorS2(\"cls{0}BL\", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, \"\", \"\");",
               objPrjTabENEx.TabName,
                objKeyField.FldName,
                strTextFieldName);
            //strCodeForCs.Append("\r\n" + "// ��̬�Ķ����б�,���ڻ���,��Լ�¼����,��Ϊ���������ʹ��");
            //strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLstCache = null;",
            //       objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "throw new Exception(strErrMsgForGetObjById);");
            //strCodeForCs.AppendFormat("\r\n" + "return \"\";");
            strCodeForCs.Append("\r\n" + "}");

            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strCodeForCs.ToString();
        }


        /// <summary>
        /// �ѱ������ݰ󶨵�ListView��
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_BindListView()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //strCodeForCs.Append("\r\n //1/���ɰ�ListView�Ĵ���");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.Append("\r\n /// ��������:���ݽ����ϲ�ѯ�ؼ������������ݲ�ѯ���¼,");
                strCodeForCs.Append("\r\n ///			 ����ʾ��ListView�С�");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public static int BindLv_{0}(System.Windows.Forms.ListView lv{0}, string strWhereCond)",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//��������:(��4��)");
                strCodeForCs.Append("\r\n" + "//	1����Ͻ�����������");
                strCodeForCs.Append("\r\n" + "//	2��������������ȡ�ñ�����������DataTable��");
                strCodeForCs.Append("\r\n" + "//	3������ListView����ͷ��Ϣ");
                strCodeForCs.Append("\r\n" + "//	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��");
                strCodeForCs.Append("\r\n" + "//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�lblRecCount�С�");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.AppendFormat("\r\n" + "System.Windows.Forms.ListViewItem lvi{0}; ",
                objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arr{0}ObjLst;",
                objPrjTabENEx.TabName);

                strCodeForCs.Append("\r\n" + "//	2��������������ȡ�ñ�����������DataTable��");
                strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = GetObjLst(strWhereCond);",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "//	3������ListView����ͷ��Ϣ");
                strCodeForCs.AppendFormat("\r\n" + "lv{0}.Items.Clear();//���ԭ������Item",
                objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "lv{0}.Columns.Clear();//���ԭ��������ͷ��Ϣ",
                objPrjTabENEx.TabName);
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.FieldTypeId != "04" && objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "byte[]")	//���ǹ����ֶ�
                    {
                        strCodeForCs.AppendFormat("\r\n" + "lv{0}.Columns.Add(\"{1}\", 100, System.Windows.Forms.HorizontalAlignment.Left);",
                        objPrjTabENEx.TabName, objField.ColCaption);
                    }
                }
                strCodeForCs.AppendFormat("\r\n" + "lv{0}.View = System.Windows.Forms.View.Details;",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "//	4������ListView��Item��Ϣ���������м�¼��ʾ��ListView��");
                strCodeForCs.AppendFormat("\r\n" + "foreach (cls{0}EN obj{0}EN in arr{0}ObjLst)",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "lvi{0} = new System.Windows.Forms.ListViewItem();",
                objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "lvi{0}.Tag = obj{0}EN.{1};",
                objPrjTabENEx.TabName, objKeyField.PropertyName(this.IsFstLcase));
                strCodeForCs.AppendFormat("\r\n" + "lvi{0}.Text = obj{0}EN.{1}.ToString();",
                objPrjTabENEx.TabName, objKeyField.PropertyName(this.IsFstLcase));
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
                            strCodeForCs.AppendFormat("\r\n" + "lvi{0}.SubItems.Add(obj{0}EN.{1});",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "lvi{0}.SubItems.Add(obj{0}EN.{1}.ToString());",
                            objPrjTabENEx.TabName, objField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));
                        }
                    }
                }
                strCodeForCs.AppendFormat("\r\n" + "lv{0}.Items.Add(lvi{0});",
                objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "//	4�����ü�¼����״̬,");
                strCodeForCs.Append("\r\n" + "//		�ڱ��������ǰ�״̬��ʾ�ڿؼ�txtRecCount�С�");
                strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLst.Count;",
                objPrjTabENEx.TabName);
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

                    if (objTabFeature_BindDdl.arrTabFeatureFldsSet().Exists(x => x.FieldTypeId == enumFieldType.NameField_03) == false)
                    {
                        continue;
                        //                        throw new Exception("��ǰ��û�������ֶ�,������Ӱ���������!");
                    }
                    if (objTabFeature_BindDdl.arrTabFeatureFldsSet().Exists(x => x.FieldTypeId == enumFieldType.KeyField_02) == false)
                    {
                        continue;
                        //                        throw new Exception("��ǰ��û�йؼ��ֶ�,������Ӱ���������!");
                    }
                    List<clsTabFeatureFldsENEx> arrFieldLst_Cond = objTabFeature_BindDdl.arrTabFeatureFldsSetEx().Where(x => x.FieldTypeId == enumFieldType.ConditionField_16).ToList();

                    List<string> arrCondFldId = objTabFeature_BindDdl.GetCondFldIdLst();
                    var objFuncParaLst = new FuncParaLst("DdlParaLst", this.IsFstLcase, enumAppLevel.DefindFunc);
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
                    //��0��:�ѿؼ���������ComboBoxת����ComboBox


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
                            strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arrObjLst = cls{0}WApi.GetObjLst(strCondition).OrderBy(x=>x.{1}).ToList();",
                                 objPrjTabENEx.TabName,
                                 objField_Sort.ObjFieldTab().FldName);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arrObjLst = cls{0}WApi.GetObjLst(strCondition);",
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
            StringBuilder strCodeForCs = new StringBuilder();
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
                    //strCodeForCs.AppendFormat("\r\n" + "public static System.Data.DataTable Get{0}()",
                    //strValueFieldName);
                    //strCodeForCs.Append("\r\n" + "{");
                    //strCodeForCs.Append("\r\n" + "//��ȡĳѧԺ����רҵ��Ϣ");
                    //strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";",
                    //strValueFieldName, strTextFieldName, objPrjTabENEx.TabName);
                    ////						if (objField.DsCondStr.Trim() == "" )
                    ////						{
                    ////							strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} \";", 
                    ////								strValueFieldName, strTextFieldName, objPrjTabENEx.TabName);
                    ////						}
                    ////						else
                    ////						{
                    ////							strCodeForCs.AppendFormat("\r\n" + "string strSQL = \"select {0}, {1} from {2} where {3}\";", 
                    ////								strValueFieldName, strTextFieldName, objPrjTabENEx.TabName, objField.DsCondStr);
                    ////						}
                    ////strCodeForCs.Append("\r\n" + "clsSpecSQLforSql mySql=new 1clsSpecSQLforSql();");
                    //strCodeForCs.AppendFormat("\r\n clsSpecSQLforSql mySql = cls{0}BL.GetSpecSQLObj();", objPrjTabENEx.TabName);

                    //strCodeForCs.Append("\r\n" + "System.Data.DataTable objDT = mySql.GetDataTable(strSQL);");
                    //strCodeForCs.Append("\r\n" + "return objDT;");
                    //strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// �󶨻���Win��������");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.Append("\r\n /// <param name=\"objComboBox\">��Ҫ�󶨵�ǰ���������</param>");
                    strCodeForCs.AppendFormat("\r\n" + "public static void BindCbo_{0}(System.Windows.Forms.ComboBox objComboBox)",
                    strValueFieldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//Ϊ����ԴΪ�����������������");
                    strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arrObjLst = GetObjLst(\"1=1\");",
                    objPrjTabENEx.TabName);


                    strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{0}EN;",
                    objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "//��ʼ��һ�������б�");
                    //strCodeForCs.AppendFormat("\r\n" + "ArrayList {0}List = new ArrayList();",
                    //objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "//�����0��ڵ�0���в��롰��ѡ��...��,Ϊ�˷����û�,��WEB��ʽ���ơ�");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = new cls{0}EN();",
                    objPrjTabENEx.TabName);
                    if (bolIsNumber4ValueFieldName)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = 0;",
                        objPrjTabENEx.TabName, strValueFieldName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = \"0\";",
                        objPrjTabENEx.TabName, strValueFieldName);
                    }
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = \"ѡ[{2}]...\";",
                        objPrjTabENEx.TabName, strTextFieldName, objPrjTabENEx.TabCnName);

                    strCodeForCs.AppendFormat("\r\n" + "arrObjLst.Insert(0, obj{0}EN);",
                    objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "//��DataTable�е���������ӵ������б���");

                    strCodeForCs.Append("\r\n" + "//���������������Դ���Լ�����ֵ���ʾ��");
                    strCodeForCs.AppendFormat("\r\n" + "objComboBox.DataSource = arrObjLst;",
                    objPrjTabENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "objComboBox.ValueMember=\"{1}\";",
                            objPrjTabENEx.TabName, strValueFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objComboBox.DisplayMember=\"{1}\";",
                           objPrjTabENEx.TabName, strTextFieldName);
                    strCodeForCs.Append("\r\n" + "objComboBox.SelectedIndex = 0;");
                    strCodeForCs.Append("\r\n" + "}");
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
        public string Gen_4WA_DdlBindFunction()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
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

                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// �󶨻���Web��������");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.Append("\r\n /// <param name=\"objDDL\">��Ҫ�󶨵�ǰ���������</param>");
                    strCodeForCs.AppendFormat("\r\n" + "public static void BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL)",
                    strValueFieldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//Ϊ����Դ�ڱ����������������");

                    strCodeForCs.AppendFormat("\r\n" + "System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem(\"ѡ[{0}]...\",\"0\");",
                          objPrjTabENEx.TabCnName);

                    strCodeForCs.AppendFormat("\r\n" + "List<cls{0}EN> arrObjLst = GetObjLst(\"1=1\");",
                        objPrjTabENEx.TabName);

                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataValueField=\"{1}\";",
                        objPrjTabENEx.TabName, strValueFieldName);
                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataTextField=\"{1}\";",
                        objPrjTabENEx.TabName, strTextFieldName);
                    strCodeForCs.Append("\r\n" + "objDDL.DataSource = arrObjLst;");
                    strCodeForCs.Append("\r\n" + "objDDL.DataBind();");
                    strCodeForCs.Append("\r\n" + "objDDL.Items.Insert(0, li);");
                    strCodeForCs.Append("\r\n" + "objDDL.SelectedIndex = 0;");
                    strCodeForCs.Append("\r\n" + "}");
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
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����������Ϣ:{1}.({2})", strFuncName,
                    objException.Message,
                    clsStackTrace.GetCurrClassFunction());
                clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
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

            StringBuilder strCodeForCs = new StringBuilder();
            //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ���ݱ���������enum�б�");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "string")
            {
                strCodeForCs.AppendFormat("\r\npublic class enum{0}WA",
                       objPrjTabENEx.TabName,
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                strCodeForCs.Append("\r\n{");

                foreach (DataRow objRow in objDT.Rows)
                {
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.AppendFormat("\r\n /// {0}", objRow[strNamedFieldName]);
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n" + "public const string {0}_{1} = \"{1}\";",
                        objRow[strEnglishNameFieldName], objRow[strKeyFieldName]);
                }
            }
            else
            {
                strCodeForCs.AppendFormat("\r\npublic enum enum{0} : {1}",
                objPrjTabENEx.TabName,
                objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType);
                strCodeForCs.Append("\r\n{");

                foreach (DataRow objRow in objDT.Rows)
                {
                    strCodeForCs.AppendFormat("\r\n" + "[Description(\"{0}\")]", objRow[strNamedFieldName]);
                    strCodeForCs.AppendFormat("\r\n" + "{0}_{1} = {1},", objRow[strEnglishNameFieldName], objRow[strKeyFieldName]);
                }
            }
            strCodeForCs.Append("\r\n}");

            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strCodeForCs.ToString();
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

            StringBuilder strCodeForCs = new StringBuilder();
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "string") continue;
                if (objField.FieldTypeId != "07") continue;
                //��ȡĳһ����ֵ�ļ�¼��-----------------------------;
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// ���ݱ��ֶ���������enum�б�-�ֶ�����[{0}]", objField.ObjFieldTabENEx.FldName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");

                strCodeForCs.AppendFormat("\r\npublic class enum{0}_{1}WS",
                       objPrjTabENEx.TabName,
                        objField.ObjFieldTabENEx.FldName);
                strCodeForCs.Append("\r\n{");
                List<string> arrExistItem = new List<string>();
                foreach (DataRow objRow in objDT.Rows)
                {
                    string strFieldValue = objRow[objField.ObjFieldTabENEx.FldName].ToString();
                    if (arrExistItem.Contains(strFieldValue)) continue;
                    arrExistItem.Add(strFieldValue);
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.AppendFormat("\r\n /// {0}", strFieldValue);
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n" + "public const string con{0} = \"{0}\";",
                        strFieldValue);
                }

                strCodeForCs.Append("\r\n}");
            }
            //��ȡĳһ����ֵ�ļ�¼�� == = ;
            return strCodeForCs.ToString();
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
                Type t = typeof(WA_Access4CSharp);
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

        public void Gen_4WA_Static_SetFieldValue4OneField(clsPrjTabFldENEx objField, StringBuilder strCodeForCs)
        {
            if (objField.FldOpTypeId == "0004") return;//������д
            if (objField.FldOpTypeId == "0002") return;//ֻ����д
            string strPrivPropNameWithObjectName = clsFieldTabBLEx.PrivPropNameWithObjectName(objField.ObjFieldTabENEx, "obj" + objPrjTabENEx.TabName + "EN", this.IsFstLcase);
            string strPrivPropNameWithObjectName4Get = clsFieldTabBLEx.PrivPropNameWithObjectName4Get(objField, "obj" + objPrjTabENEx.TabName + "EN");

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// /// ����:Ϊ���������ֶ�ֵ");
            strCodeForCs.Append("\r\n /// /// �ŵ�:1������ʵ�ֺ�������,�������ֵ����һ��д.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ�����ֶ�ֵ��ʵ�����</param>", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">{1}</param>", objField.PrivFuncName, objField.ObjFieldTab().Caption);
            strCodeForCs.Append("\r\n /// <param name = \"strComparisonOp\">�Ƚ������,�����ֵ,��������֯������</param>");
            strCodeForCs.Append("\r\n /// <returns>���ض���,���Լ�����д</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static cls{0}EN Set{1}(this cls{0}EN obj{0}EN, {2} {3}, string strComparisonOp=\"\")",
            objPrjTabENEx.TabName, objField.FldName, objField.CsType, objField.PrivFuncName);
            strCodeForCs.Append("\r\n	{");
            //objUserStateEN.Memo = strMemo;


            //���ǿ�
            if (objField.IsTabNullable == false && objField.FieldTypeId != "02")
            {
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte[]" || objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "byte")
                {

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "clsCheckSql.CheckFieldNotNull({0}, con{2}.{3});",
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

                strCodeForCs.AppendFormat("\r\n" + "clsCheckSql.CheckFieldLen({0}, {1}, con{2}.{3});",
         objField.PrivFuncName,
         objField.ObjFieldTabENEx.FldLength,
         objPrjTabENEx.TabName,
         objField.ObjFieldTabENEx.FldName);

            }
            //������
            if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName != "text"
               && objField.ObjFieldTabENEx.objDataTypeAbbrEN.DataTypeName == "char" && objField.ObjFieldTabENEx.FldLength > 0)
            {

                strCodeForCs.AppendFormat("\r\n" + "clsCheckSql.CheckFieldForeignKey({0}, {1}, con{2}.{3});",
           objField.PrivFuncName,
           objField.ObjFieldTabENEx.FldLength,
           objPrjTabENEx.TabName,
           objField.ObjFieldTabENEx.FldName);

            }

            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2}; //{3}",
             objPrjTabENEx.TabName, objField.PropertyName(this.IsFstLcase), objField.PrivFuncName, objField.ColCaption);
            strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty(strComparisonOp) == false)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.dicFldComparisonOp.ContainsKey(con{0}.{1}) == false)",
                objPrjTabENEx.TabName, objField.ObjFieldTabENEx.FldName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.dicFldComparisonOp.Add(con{0}.{1}, strComparisonOp);",
                objPrjTabENEx.TabName,
                objField.ObjFieldTabENEx.FldName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.dicFldComparisonOp[con{0}.{1}] = strComparisonOp;", objPrjTabENEx.TabName,
                objField.ObjFieldTabENEx.FldName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "return obj{0}EN;", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n	}");


        }

        public string Gen_4WA_Static_SetFieldValue()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            objPrjTabENEx.arrFldSet.ForEach(obj => Gen_4WA_Static_SetFieldValue4OneField(obj, strCodeForCs));

            return strCodeForCs.ToString();
        }
        public string Gen_4WA_ReFreshThisCache()
        {

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ˢ�±����еĻ���.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            if (objPrjTabENEx.objCacheClassifyFld_TS == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "public static void ReFreshThisCache()");
            }
            else
            {
                //strCodeForCs.AppendFormat("\r\n" + "public static void ReFreshThisCache({0} {1} = \"\")",
                //    objPrjTabENEx.objCacheClassifyFld_TS.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                //objPrjTabENEx.objCacheClassifyFld_TS.PrivFuncName);

                strCodeForCs.AppendFormat("\r\n" + "public static void ReFreshThisCache(string {1} = \"\")",
               objPrjTabENEx.objCacheClassifyFld_TS.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
           objPrjTabENEx.objCacheClassifyFld_TS.PrivFuncName);
            }
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "string strMsg;");
            strCodeForCs.Append("\r\n" + "if (clsSysParaEN.spSetRefreshCacheOn == true)");
            strCodeForCs.Append("\r\n" + "{");
            if (objPrjTabENEx.objCacheClassifyFld_TS == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "string strKey = string.Format(\"{{0}}\", cls{0}EN._CurrTabName);",
                    objPrjTabENEx.TabName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "string strKey = string.Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1});",
                                objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld_TS.PrivFuncName);
            }
            strCodeForCs.AppendFormat("\r\n" + "CacheHelper.Remove(strKey);", objPrjTabENEx.TabName);

            //strCodeForCs.AppendFormat("\r\n" + "strMsg = string.Format(\"ˢ1�»���ɹ�!({{2}}->{{1}}->{{0}})\",");
            //strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            //strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunctionByLevel(2),");
            //strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunctionByLevel(3)); ");
            //strCodeForCs.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "strMsg = string.Format(\"ˢ�»����Ѿ��رա�(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})\",");
            strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunctionByLevel(2),");
            strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunctionByLevel(3));");
            strCodeForCs.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
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
        public string Gen_4WA_Static_Update()
        {

            StringBuilder strCodeForCs = new StringBuilder();
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "Update_Static", "�޸ļ�¼ʱ�ؼ��ֲ���Ϊ��!", "���ɴ���");

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// /// ����:ͨ��SQL�������޸ļ�¼,�÷�ʽ���Ż���ʽ");
            strCodeForCs.Append("\r\n /// /// �ŵ�:1���ܹ������ֶ��еĵ�Ʋ���⣻2���ܹ��������ֶ�,��ֻ���޸Ĺ����ֶβ���Ҫ�޸�ͬ�������ݿ�.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵ�ʵ�����</param>", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n /// <returns>����޸ĳɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static bool Update(this cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "{");
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "bool")
            {
                if (IsNumberType4Key == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + " if (obj{0}EN.{1} == 0)",
                     objPrjTabENEx.TabName, objKeyField.PropertyName(this.IsFstLcase));
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true)",
                        objPrjTabENEx.TabName, objKeyField.PropertyName(this.IsFstLcase));
                }
                strCodeForCs.Append("\r\n" + " {");

                strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{0})�޸ļ�¼ʱ�ؼ��ֲ���Ϊ��!(from {{0}})\\r\\n\",", strErrId);
                strCodeForCs.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");
                strCodeForCs.AppendFormat("\r\n" + "throw new Exception(strMsg); ");
                strCodeForCs.Append("\r\n" + " }");
            }
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.sfUpdFldSetStr = obj{0}EN.getsfUpdFldSetStr();", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "cls{0}WApi.CheckPropertyNew(obj{0}EN); ", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "bool bolResult = cls{0}WApi.UpdateRecord(obj{0}EN);",
            objPrjTabENEx.TabName);
            //strCodeForCs.Append("\r\n" + "  //�����޸ļ�¼���¼�");
            //strCodeForCs.Append("\r\n" + "try");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "    onUpdateRecord?.Invoke(obj{0}EN);", TabName);
            //strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "string strMsg2 = string.Format(\"�ڵ����޸ļ�¼�����¼�ʱ��������{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
            //strCodeForCs.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg2);");
            //strCodeForCs.Append("\r\n" + "throw new Exception(strMsg2);");
            //strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "// ��̬�Ķ����б�,���������ػ���,��Լ�¼����,��Ϊ���������ʹ��");
            if (objPrjTabENEx.IsUseCache_TS() == true && thisCacheClassify_TS.IsForExtendClass == false)
            {
                if (objPrjTabENEx.objCacheClassifyFld_TS == null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}WApi.ReFreshCache();", objPrjTabENEx.TabName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}WApi.ReFreshCache(obj{0}EN.{1});", objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld_TS.PropertyName(this.IsFstLcase));
                }
            }
                strCodeForCs.Append("\r\n" + "return bolResult;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");
            strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
                objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "Update_Static", "�޸ļ�¼����!", "���ɴ���");

            strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{0})�޸ļ�¼����,{{1}}!(from {{0}})\",", strErrId);
            strCodeForCs.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.AppendFormat("\r\n" + "objException.Message); ");
            strCodeForCs.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        public string Gen_4WA_Static_AddNewRecord()
        {

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// /// ����:ͨ��SQL�����������¼,�÷�ʽ���Ż���ʽ");
            strCodeForCs.Append("\r\n /// /// �ŵ�:1���ܹ������ֶ��еĵ�Ʋ���⣻2���ܹ�ʹ�ֶ�ֵΪNULL���ֶ��������");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵ�ʵ�����</param>", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n /// <returns>�������ɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static bool AddNewRecord(this cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");

            if (objKeyField.PrimaryTypeId != enumPrimaryType.StringAutoAddPrimaryKey_03
                && objKeyField.PrimaryTypeId != enumPrimaryType.Identity_02
                && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "bool"
                && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "int"
                 && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "long")
            {
                strCodeForCs.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true)",
                    objPrjTabENEx.TabName, objKeyField.PropertyName(this.IsFstLcase));
                strCodeForCs.Append("\r\n" + " {");
                strCodeForCs.Append("\r\n" + "string strMsg = string.Format(\"��Ӽ�¼ʱ,�ؼ��ֲ���Ϊ��!(from {0})\\r\\n\", ");
                strCodeForCs.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");
                strCodeForCs.Append("\r\n throw new Exception(strMsg);");

                strCodeForCs.Append("\r\n" + " }");

                strCodeForCs.AppendFormat("\r\n" + " if (cls{0}WApi.IsExist({1}) == true)",
                   objPrjTabENEx.TabName, strKeyFldName_ObjName);
                strCodeForCs.Append("\r\n" + " {");
                strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"��Ӽ�¼ʱ,�ؼ���:[{{0}}]�Ѿ�����!(from {{1}})\\r\\n\", obj{0}EN.{1}, ",
                    objPrjTabENEx.TabName, objKeyField.PropertyName(this.IsFstLcase));
                strCodeForCs.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction()); ");
                strCodeForCs.Append("\r\n throw new Exception(strMsg);");
                strCodeForCs.Append("\r\n" + " }");
            }

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
            {
                strCodeForCs.AppendFormat("\r\n" + " if (string.IsNullOrEmpty(obj{0}EN.{1}) == true || cls{0}WApi.IsExist({2}) == true)",
                    objPrjTabENEx.TabName, objKeyField.PropertyName(this.IsFstLcase), strKeyFldName_ObjName);
                strCodeForCs.Append("\r\n" + " {");
                strCodeForCs.AppendFormat("\r\n" + "     obj{0}EN.{1} = cls{0}WApi.GetMaxStrId();",
                    objPrjTabENEx.TabName, objKeyField.PropertyName(this.IsFstLcase));
                strCodeForCs.Append("\r\n" + " }");
            }
            strCodeForCs.AppendFormat("\r\n" + "cls{0}WApi.CheckPropertyNew(obj{0}EN); ", objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "bool bolResult = cls{0}WApi.AddNewRecord(obj{0}EN);",
            objPrjTabENEx.TabName);
            //strCodeForCs.Append("\r\n" + "  //��������¼�¼���¼�");
            //strCodeForCs.Append("\r\n" + "try");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "    onAddNewRecord?.Invoke(obj{0}EN);", TabName);
            //strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "string strMsg2 = string.Format(\"�ڵ�����Ӽ�¼�����¼�ʱ��������{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
            //strCodeForCs.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg2);");
            //strCodeForCs.Append("\r\n" + "throw new Exception(strMsg2);");
            //strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "// ��̬�Ķ����б�,���������ػ���,��Լ�¼����,��Ϊ���������ʹ��");
            if (objPrjTabENEx.IsUseCache_TS() == true && thisCacheClassify_TS.IsForExtendClass == false)
            {
                if (objPrjTabENEx.objCacheClassifyFld_TS == null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}WApi.ReFreshCache();", objPrjTabENEx.TabName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}WApi.ReFreshCache(obj{0}EN.{1});", objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld_TS.PropertyName(this.IsFstLcase));
                }
            }
            strCodeForCs.Append("\r\n" + "return bolResult;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "AddNewRecord_Static", "����̬��Ӽ�¼����!", "���ɴ���");

            strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{0})��Ӽ�¼����, {{1}}.(from {{0}})\",", strErrId);
            strCodeForCs.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.AppendFormat("\r\n" + "objException.Message); ");
            strCodeForCs.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strCodeForCs.AppendFormat("\r\n" + "throw new Exception(\"(errid:{22})��Ӽ�¼����!({1}:AddNewRecordBySql2)\\r\\n\" + objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strCodeForCs.AppendFormat("\r\n" + "throw new Exception(\"��Ӽ�¼����!({1}: AddNewRecordBySQL2)\\r\\n\" + objException.Message);",
            //   objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public string Gen_4WA_Static_AddNewRecordWithMaxId()
        {
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "string") return "";

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// /// ����:ͨ��SQL�����������¼,���йؼ���Ϊ���л�ȡ�����ֵ. �÷�ʽ���Ż���ʽ");
            strCodeForCs.Append("\r\n /// /// �ŵ�:1���ܹ������ֶ��еĵ�Ʋ���⣻2���ܹ�ʹ�ֶ�ֵΪNULL���ֶ��������");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵ�ʵ�����</param>", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n /// <returns>�������ɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static {1} AddNewRecordWithMaxId(this cls{0}EN obj{0}EN)",
            objPrjTabENEx.TabName, objKeyField.CsType);
            strCodeForCs.Append("\r\n" + "{");



            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "cls{0}WApi.CheckPropertyNew(obj{0}EN); ", objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "{1} {2} = cls{0}WApi.AddNewRecordWithMaxId(obj{0}EN);",
            objPrjTabENEx.TabName, objKeyField.CsType, objKeyField.PrivFuncName);
            //strCodeForCs.Append("\r\n" + "  //��������¼�¼���¼�");
            //strCodeForCs.Append("\r\n" + "try");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "    onAddNewRecord?.Invoke(obj{0}EN);", TabName);
            //strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "string strMsg2 = string.Format(\"�ڵ�����Ӽ�¼�����¼�ʱ��������{0}.({1})\", objException.Message, clsStackTrace.GetCurrClassFunction());");
            //strCodeForCs.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg2);");
            //strCodeForCs.Append("\r\n" + "throw new Exception(strMsg2);");
            //strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "// ��̬�Ķ����б�,���������ػ���,��Լ�¼����,��Ϊ���������ʹ��");
            if (objPrjTabENEx.IsUseCache_TS() == true && thisCacheClassify_TS.IsForExtendClass == false)
            {
                if (objPrjTabENEx.objCacheClassifyFld_TS == null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}WApi.ReFreshCache();", objPrjTabENEx.TabName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}WApi.ReFreshCache(obj{0}EN.{1});", objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld_TS.PropertyName(this.IsFstLcase));
                }
            }
            strCodeForCs.AppendFormat("\r\n" + "return {0};", objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
      objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "AddNewRecordWithMaxId_Static", "����̬��Ӽ�¼����!", "���ɴ���");

            strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{0})��Ӽ�¼����, {{1}}.(from {{0}})\",", strErrId);
            strCodeForCs.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.AppendFormat("\r\n" + "objException.Message); ");
            strCodeForCs.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            //strCodeForCs.AppendFormat("\r\n" + "throw new Exception(\"(errid:{22})��Ӽ�¼����!({1}:AddNewRecordBySql2)\\r\\n\" + objException.Message);",
            //  objPrjTabENEx.TabName, objPrjTabENEx.ClsName, strErrId);

            //strCodeForCs.AppendFormat("\r\n" + "throw new Exception(\"��Ӽ�¼����!({1}: AddNewRecordBySQL2)\\r\\n\" + objException.Message);",
            //   objPrjTabENEx.TabName, objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public string Gen_4WA_Static_UpdateWithCondition()
        {

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// /// ����:ͨ��SQL�������޸ļ�¼,�÷�ʽ�Ƿ��Ż���ʽ,���������޸ļ�¼");
            strCodeForCs.Append("\r\n /// /// ȱ��:1�����ܴ����ֶ��еĵ�Ʋ���⣻2�����ܴ������ֶ�,��ֻ���޸Ĺ����ֶβ���Ҫ�޸�ͬ�������ݿ�.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ�޸ĵĶ���</param>", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">�޸ļ�¼ʱ������</param>");
            strCodeForCs.Append("\r\n /// <returns>����޸ĳɹ��򷵻�TRUE,����ΪFALSE</returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static bool UpdateWithCondition(this cls{0}EN obj{0}EN, string strWhereCond)",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "cls{0}WApi.CheckPropertyNew(obj{0}EN); ", objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "bool bolResult = cls{0}WApi.UpdateWithCondition(obj{0}EN, strWhereCond);",
            objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "// ��̬�Ķ����б�,���������ػ���,��Լ�¼����,��Ϊ���������ʹ��");
            if (objPrjTabENEx.IsUseCache_TS() == true && thisCacheClassify_TS.IsForExtendClass == false)
            {
                if (objPrjTabENEx.objCacheClassifyFld_TS == null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}WApi.ReFreshCache();", objPrjTabENEx.TabName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "cls{0}WApi.ReFreshCache(obj{0}EN.{1});", objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld_TS.PropertyName(this.IsFstLcase));
                }
            }
            strCodeForCs.Append("\r\n" + "return bolResult;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (Exception objException)");
            strCodeForCs.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objPrjTabENEx.CodeTypeId,
        objPrjTabENEx.PrjId, objPrjTabENEx.ClsName, "UpdateWithCondition_Static", "���������޸ļ�¼����!", "���ɴ���");

            strCodeForCs.AppendFormat("\r\n" + "string strMsg = string.Format(\"(errid:{0})���������޸ļ�¼����, {{1}}.(from {{0}})\\r\\n\",", strErrId);
            strCodeForCs.AppendFormat("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            strCodeForCs.AppendFormat("\r\n" + "objException.Message); ");
            strCodeForCs.AppendFormat("\r\n" + "throw new Exception(strMsg); ");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_GetObjLstCache()
        {

            if (objPrjTabENEx.IsUseCache == false) return string.Format("//�ñ�û��ʹ��Cache,����Ҫ����[GetObjLstCache()]����;",
                             objKeyField.FldName);
            if (objPrjTabENEx.IsUseCache_TS() == false) return $"//�ñ�û��ʹ��Cache,����Ҫ����[GetObjLstCache()]����;(in {clsStackTrace.GetCurrClassFunction()})";

            Tuple<string, string, string> tup = thisWA_FP(WA_F.GetObjLst_Cache, "CSharp");
            var strFuncParamsDefLst = tup.Item1;
            var strFuncParamsLst = tup.Item2;
            StringBuilder strCodeForCs = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;

            strCodeForCs.AppendFormat("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// �ӻ����л�ȡ���ж����б�.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <returns>�ӻ����л�ȡ�����ж����б�</returns>");


            strCodeForCs.Append("\r\n" + $"public static List<cls{objPrjTabENEx.TabName}EN> GetObjLstCache({strFuncParamsDefLst})");



            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//��ʼ���б���");
            strCodeForCs.Append("\r\n" + "var strWhereCond = \"1=1\";");

            if (thisCacheClassify_TS.IsHasCacheClassfyFld == false)
            {
                strCodeForCs.Append("\r\n" + $"var strKey = {thisWA_F(WA_F._CurrTabName)};");
            }
            else if (thisCacheClassify_TS.IsHasCacheClassfyFld2 == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}._WhereFormat) == false)", ThisClsName4EN);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "strWhereCond =string.Format({0}._WhereFormat, {1});",
                    ThisClsName4EN, thisCacheClassify_TS.PriVarName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                if (thisCacheClassify_TS.IsForExtendClass == false)
                {
                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond = string.Format(\"{{0}}='{{1}}'\",con{0}.{1}, {2});", ThisTabName4GC, thisCacheClassify_TS.FldName, thisCacheClassify_TS.PriVarName);
                }
                else
                {
                    strCodeForCs.Append("\r\n" + "var strMsg =$\"�����ֶ�Ϊ��չ�ֶ�,��ʱ_WhereFormat����Ϊ��!({clsStackTrace.GetCurrFunction()})\";");             
                    strCodeForCs.Append("\r\n" + "throw new Exception(strMsg);");
                }
                strCodeForCs.Append("\r\n" + "}");

                if (thisCacheClassify_TS.IsNumberType == true)
                {
                    strCodeForCs.Append("\r\n" + $"var strKey = string.Format(\"{{0}}_{{1}}\", {thisWA_F(WA_F._CurrTabName)}, {thisCacheClassify_TS.PriVarName});");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + $"var strKey = string.Format(\"{{0}}_{{1}}\", {thisWA_F(WA_F._CurrTabName)}, {thisCacheClassify_TS.PriVarName});");
                }
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "if (string.IsNullOrEmpty({0}._WhereFormat) == false)", ThisClsName4EN);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "strWhereCond = string.Format({0}._WhereFormat, {1}, {2});",
                    ThisClsName4EN, thisCacheClassify_TS.PriVarName, thisCacheClassify_TS.PriVarName2);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "strWhereCond = string.Format(\"{0}='{{0}}' and {2}='{{1}}'\", {1}, {3});",
                    thisCacheClassify_TS.FldName, thisCacheClassify_TS.PriVarName,
                    thisCacheClassify_TS.FldName2, thisCacheClassify_TS.PriVarName2);
                strCodeForCs.Append("\r\n" + "}");

                if (thisCacheClassify_TS.IsNumberType == true)
                {
                    strCodeForCs.Append("\r\n" + $"var strKey = string.Format(\"{{0}}_{{1}}_{{2}}\", {thisWA_F(WA_F._CurrTabName)}, {thisCacheClassify_TS.PriVarName}, {thisCacheClassify_TS.PriVarName2});");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + $"var strKey = string.Format(\"{{0}}_{{1}}_{{2}}\", {thisWA_F(WA_F._CurrTabName)}, {thisCacheClassify_TS.PriVarName}, {thisCacheClassify_TS.PriVarName2});");
                }
            }

            //strCodeForCs.Append("\r\n" + "InitListCache(); ");
            if (objPrjTabENEx.objCacheClassifyFld_TS == null)
            {

                strCodeForCs.Append("\r\n" + $"List<cls{objPrjTabENEx.TabName}EN> arr{objPrjTabENEx.TabName}ObjLstCache = CacheHelper.GetCache(strKey, () => {{ return GetObjLst(strWhereCond); }});");
            }
            else
            {

                strCodeForCs.Append("\r\n" + $"List<cls{objPrjTabENEx.TabName}EN> arr{objPrjTabENEx.TabName}ObjLstCache = CacheHelper.GetCache(strKey, () => {{ return GetObjLst(strWhereCond); }});");

            }
            strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLstCache;",
                     objPrjTabENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "return null;");
            strCodeForCs.Append("\r\n" + "}");

            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strCodeForCs.ToString();
        }

        public string Gen_4WA_GetObjLstCacheFromObjLst()
        {

            if (objPrjTabENEx.IsUseCache == false) return string.Format("//�ñ�û��ʹ��Cache,����Ҫ����[GetObjLstCacheFromObjLst()]����;",
                             objKeyField.FldName);
            if (objPrjTabENEx.IsUseCache_TS() == false) return $"//�ñ�û��ʹ��Cache,����Ҫ����[GetObjLstCacheFromObjLst()]����;(in {clsStackTrace.GetCurrClassFunction()})";
            if (thisCacheClassify_TS.FldName == "") return $"//�ñ�û�л�������ֶ�,����Ҫ����[GetObjLstCacheFromObjLst()]����;(in {clsStackTrace.GetCurrClassFunction()})";
            if (thisCacheClassify_TS.IsForExtendClass == true) return $"//�ñ�������ֶ�����չ�ֶ�,����Ҫ����[GetObjLstCacheFromObjLst()]����;(in {clsStackTrace.GetCurrClassFunction()})";

            Tuple<string, string, string> tup = thisWA_FP(WA_F.GetObjLst_CacheFromObjLst, "CSharp");
            var strFuncParamsDefLst = tup.Item1;
            var strFuncParamsLst = tup.Item2;
            StringBuilder strCodeForCs = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;

            strCodeForCs.AppendFormat("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// �ӻ����л�ȡ���ж����б�, ����������������һ�������б�.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <returns>�ӻ����л�ȡ�����ж����б�</returns>");


            strCodeForCs.Append("\r\n" + $"public static List<cls{objPrjTabENEx.TabName}EN> GetObjLstCacheFromObjLst({strFuncParamsDefLst})");



            strCodeForCs.Append("\r\n" + "{");

            if (thisCacheClassify_TS.IsHasCacheClassfyFld == false)
            {
                strCodeForCs.Append("\r\n" + $"var strKey = {thisWA_F(WA_F._CurrTabName)};");
            }
            else if (thisCacheClassify_TS.IsHasCacheClassfyFld2 == false)
            {
                if (thisCacheClassify_TS.IsNumberType == true)
                {
                    strCodeForCs.Append("\r\n" + $"var strKey = string.Format(\"{{0}}_{{1}}\", {thisWA_F(WA_F._CurrTabName)}, {thisCacheClassify_TS.PriVarName});");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + $"var strKey = string.Format(\"{{0}}_{{1}}\", {thisWA_F(WA_F._CurrTabName)}, {thisCacheClassify_TS.PriVarName});");
                }
            }
            else
            {
                if (thisCacheClassify_TS.IsNumberType == true)
                {
                    strCodeForCs.Append("\r\n" + $"var strKey = string.Format(\"{{0}}_{{1}}_{{2}}\", {thisWA_F(WA_F._CurrTabName)}, {thisCacheClassify_TS.PriVarName}, {thisCacheClassify_TS.PriVarName2});");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + $"var strKey = string.Format(\"{{0}}_{{1}}_{{2}}\", {thisWA_F(WA_F._CurrTabName)}, {thisCacheClassify_TS.PriVarName}, {thisCacheClassify_TS.PriVarName2});");
                }
            }


            strCodeForCs.Append("\r\n" + $"List<cls{ThisTabName4GC}EN> arr{ThisTabName4GC}ObjLstCache = null;");
            strCodeForCs.Append("\r\n" + $"if (CacheHelper.Exsits(strKey) == true)");
            strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + $"arr{ThisTabName4GC}ObjLstCache = CacheHelper.Get<List<cls{ThisTabName4GC}EN>>(strKey);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + $"var arrObjLst_Sel = arrObjLst_P.Where(x => x.{thisCacheClassify_TS.FldName} == {thisCacheClassify_TS.PriVarName}).ToList();");
                strCodeForCs.Append("\r\n" + $"CacheHelper.Add(strKey, arrObjLst_Sel);");
                strCodeForCs.Append("\r\n" + $"arr{ThisTabName4GC}ObjLstCache = CacheHelper.Get<List<cls{ThisTabName4GC}EN>>(strKey);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "return arr{0}ObjLstCache;",
                     objPrjTabENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "return null;");
            strCodeForCs.Append("\r\n" + "}");

            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strCodeForCs.ToString();
        }


        public string Gen_4WA_ReFreshCache()
        {

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ˢ�»���.�ѵ�ǰ��Ļ����Լ��ñ������ͼ�Ļ������.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            if (objPrjTabENEx.objCacheClassifyFld_TS == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "public static void ReFreshCache()");
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "public static void ReFreshCache({0} {1})",
                                    objPrjTabENEx.objCacheClassifyFld_TS.ObjFieldTabENEx.objDataTypeAbbrEN.CsType,
                objPrjTabENEx.objCacheClassifyFld_TS.PrivFuncName);
            }
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
            strCodeForCs.AppendFormat("\r\n" + "if (cls{0}WApi.objCommFun4WApi != null) ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + " string strMsg = string.Format(\"ˢ1�»���ɹ�!({{2}}->{{1}}->{{0}})\",", "{", "}");
            //strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunction(),");
            //strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunctionByLevel(2),");
            //strCodeForCs.Append("\r\n" + "clsStackTrace.GetCurrClassFunctionByLevel(3)); ");
            //strCodeForCs.Append("\r\n" + "clsSysParaEN.objLog.WriteDebugLog(strMsg);");

            strCodeForCs.Append("\r\n" + "// ��̬�Ķ����б�,���������ػ���,��Լ�¼����,��Ϊ���������ʹ��");
            if (objPrjTabENEx.objCacheClassifyFld_TS == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "string strKey = string.Format(\"{{0}}\", cls{0}EN._CurrTabName);",
                    objPrjTabENEx.TabName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "string strKey = string.Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1});",
                                objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld_TS.PrivFuncName);
            }

            strCodeForCs.AppendFormat("\r\n" + "CacheHelper.Remove(strKey);", objPrjTabENEx.TabName);
            if (objPrjTabENEx.objCacheClassifyFld_TS == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "cls{0}WApi.objCommFun4WApi.ReFreshCache();",
                objPrjTabENEx.TabName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "cls{0}WApi.objCommFun4WApi.ReFreshCache({1}.ToString());",
             objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld_TS.PrivFuncName);
            }

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        public string Gen_4WA_Static_GetConditionString4Constraint()
        {
            int intVerCount = 1;
            StringBuilder strCodeForCs = new StringBuilder();
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

                        strCodeForCs.Append("\r\n /// <summary>");
                        strCodeForCs.AppendFormat("\r\n /// ��ȡΨһ��������--{0}({1}), ���ɶ�����Ψһ�������ֶιؼ�����ֵ��ɵ�������",
                                                  objPrjTabENEx.TabName, objPrjTabENEx.TabCnName);
                        strCodeForCs.Append($"\r\n /// Ψһ������:{objInFor.ConstraintName4GC()}");
                        strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n /// </summary>");
                        strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">Ҫ��Ψһ�Ķ���</param>",
                               objPrjTabENEx.TabName, objPrjTabENEx.TabCnName);
                        strCodeForCs.Append("\r\n /// <returns></returns>");
                        strCodeForCs.Append($"\r\npublic static string GetUniConditionStr{strVersion}(this cls{ThisTabName4GC}EN obj{ThisTabName4GC}EN)"); strCodeForCs.Append("\r\n{");
                        strCodeForCs.Append("\r\n" + "//����¼�Ƿ����");

                        //strCodeForCs.Append("\r\n" + "bool bolIsUniqueness;");
                        strCodeForCs.Append("\r\nStringBuilder sbCondition = new StringBuilder();");

                        strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN == null) return \"\";",
                        objPrjTabENEx.TabName);

                        switch (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                        {
                            case "int":
                            case "long":
                            case "short":
                                strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.{1} == 0)",
                                objPrjTabENEx.TabName,
                                objKeyField.PropertyName(this.IsFstLcase));
                                break;
                            case "string":
                                strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.{1} == null || obj{0}EN.{1} == \"\")",
                                objPrjTabENEx.TabName,
                                objKeyField.PropertyName(this.IsFstLcase));
                                break;
                            default:
                                strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.{1} == null || obj{0}EN.{1} == \"\")",
                                objPrjTabENEx.TabName,
                                objKeyField.PropertyName(this.IsFstLcase));
                                break;
                        }
                        strCodeForCs.Append("\r\n" + "{");


                        strCodeForCs.AppendFormat("\r\nsbCondition.AppendFormat(\"1 = 1\");",
                           objKeyField.FldName,
                           objKeyField.PrivFuncName,
                           "{", "}");

                        foreach (clsConstraintFieldsEN objField in arrObjLst_Flds)
                        {

                            strCodeForCs.AppendFormat("\r\n sbCondition.AppendFormat(\" and {0} = '{{0}}'\", obj{1}EN.{2});",
                                        objField.ObjFieldTab().FldName,
                                        objPrjTabENEx.TabName,
                                                objField.ObjFieldTab().PropertyName(this.IsFstLcase));
                        }
                        strCodeForCs.AppendFormat("\r\nreturn sbCondition.ToString();",
                                objPrjTabENEx.TabName);


                        strCodeForCs.Append("\r\n}");

                        //bool bolIsFirst = true;


                        strCodeForCs.Append("\r\n else {");

                        if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == false)
                        {
                            strCodeForCs.AppendFormat("\r\nsbCondition.AppendFormat(\"{0} !=  {{0}}\", obj{1}EN.{2});",
                               objKeyField.FldName,
                               objPrjTabENEx.TabName,
                                                objKeyField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\nsbCondition.AppendFormat(\"{0} !=  '{{0}}'\", obj{1}EN.{2});",
                               objKeyField.FldName,
                               objPrjTabENEx.TabName,
                                                objKeyField.ObjFieldTabENEx.PropertyName(this.IsFstLcase));
                        }
                        foreach (clsConstraintFieldsEN objField in arrObjLst_Flds)
                        {

                            strCodeForCs.AppendFormat("\r\n sbCondition.AppendFormat(\" and {0} = '{{0}}'\", obj{1}EN.{2});",
                                        objField.ObjFieldTab().FldName,
                                        objPrjTabENEx.TabName,
                                                objField.ObjFieldTab().PropertyName(this.IsFstLcase));
                        }
                        strCodeForCs.AppendFormat("\r\n return sbCondition.ToString();",
                                objPrjTabENEx.TabName);
                        strCodeForCs.Append("\r\n}");

                        strCodeForCs.Append("\r\n" + "}");
                        break;

                    case enumConstraintType.MaxMinValue_02:

                        //strCodeForCs.Append("\r\n /// <summary>");
                        //strCodeForCs.AppendFormat("\r\n /// ��������Сֵ(MaxMinValue)--{0}({1}), ����������ֵ,�ͷ���False; ���������Сֵ,�ͷ���False; ",
                        //  objPrjTabENEx.TabName, objPrjTabENEx.TabCnName);
                        //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                        //strCodeForCs.Append("\r\n /// </summary>");
                        //strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">Ҫ���������ֵ�Ķ���</param>",
                        //       objPrjTabENEx.TabName, objPrjTabENEx.TabCnName);
                        //strCodeForCs.Append("\r\n /// <returns></returns>");
                        //strCodeForCs.AppendFormat("\r\npublic static bool CheckMaxMinValue_{1}(this cls{0}EN obj{0}EN)",
                        //             objPrjTabENEx.TabName, objInFor.ConstraintName4GC());
                        //strCodeForCs.Append("\r\n{");

                        //strCodeForCs.Append("\r\n" + "bool bolResult;");

                        //strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN == null) return true;",
                        //objPrjTabENEx.TabName);

                        //foreach (clsConstraintFieldsEN objField in arrObjLst_Flds)
                        //{
                        //    if (string.IsNullOrEmpty(objField.MaxValue) == false)
                        //    {
                        //        strCodeForCs.AppendFormat("\r\n " + "if (obj{1}EN.{0}> {2}) bolResult = false;",
                        //                    objField.ObjFieldTabENEx.FldName,
                        //                    objPrjTabENEx.TabName, objField.MaxValue);
                        //    }
                        //    if (string.IsNullOrEmpty(objField.MinValue) == false)
                        //    {
                        //        strCodeForCs.AppendFormat("\r\n " + "if (obj{1}EN.{0}< {2}) bolResult = false;",
                        //               objField.ObjFieldTabENEx.FldName,
                        //               objPrjTabENEx.TabName, objField.MinValue);
                        //    }

                        //}

                        //strCodeForCs.Append("\r\n" + "return true;");

                        //strCodeForCs.Append("\r\n" + "}");
                        break;


                }
            }

            ///�������ĳ����(������)�Ƿ�Ψһ == == == == == == == == = ;
            return strCodeForCs.ToString();
        }


    }
}
