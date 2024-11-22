using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AgcCommBase;

using com.taishsoft.commexception;
using com.taishsoft.common;using com.taishsoft.comm_db_obj;
using com.taishsoft.datetime;
using System;
using System.Collections;
using System.Collections.Generic;
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
    partial class WA_Access4JavaScript : clsGeneCodeBase
    {
        public bool Is4RJ { get; set; }

        #region ���캯��

        //public WA_Access4JavaScript()
        //{
        //    // 
        //    // TODO: �ڴ˴���ӹ��캯���߼�
        //    //
        //}
        //public WA_Access4JavaScript(string strPrjId)
        //  : base(strPrjId)
        //{
        //    // 
        //    // TODO: �ڴ˴���ӹ��캯���߼�
        //    //
        //}
        //public WA_Access4JavaScript(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
        //  : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
        //{
        //    // 
        //    // TODO: �ڴ˴���ӹ��캯���߼�
        //    //
        //}
        #endregion
        /// <summary>
        /// ����Web Serviceת�������
        /// </summary>
        /// <returns></returns>

        public  string GeneCodeFromTs(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
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
            objPrjTabENEx.CurrDate = clsDateTime.getTodayStr2(0);

            //���û���������;
            //string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; ///��ʱ����;

            objPrjTabENEx.ClsName = string.Format( "cls{0}WApi", objPrjTabENEx.TabName);
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebApiTransferLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".ts";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcId_Cache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName, objPrjTabENEx.SimpleFileName);

            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".ts";
            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjId_Cache(objPrjTabENEx.PrjId); //
            try
            {
                //������ʼ

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx));

                strCodeForCs.Append("\r\n" + ""); //

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);

                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.AppendFormat("\r\n" + "* Created by {0} on {1}.", objPrjTabENEx.UserId, clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "* ע��:�����������ý��洦��ͬһ������������ò��ɹ�!", objPrjTabENEx.UserId, clsDateTime.getTodayStr(3));
                strCodeForCs.Append("\r\n" + "*/");
         
                strCodeForCs.Append("\r\n" + "import * as $ from \"jquery\";");
                strCodeForCs.Append("\r\n" + "//import * as QQ from \"q\";");

                strCodeForCs.Append("\r\n" + "import { clsCommFunc4Web } from \"../../PubFun/clsCommFunc4Web.js\";");

                strCodeForCs.AppendFormat("\r\n" + "import {{ cls{1}EN }} from \"../../L0_Entity/{0}/cls{1}EN.js\";",
                     objFuncModule.FuncModuleEnName,
                       objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "import {{ cls{1}EN_Sim }} from \"../../L0_Entity/{0}/cls{1}EN_Sim.js\";",
                     objFuncModule.FuncModuleEnName,
                       objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n" + "import {{ cls{1}BL }} from \"../../L2_BLL/{0}/cls{1}BL.js\";",
                     objFuncModule.FuncModuleEnName,
                       objPrjTabENEx.TabName);



                if (objPrjTabENEx.SqlDsTypeId == clsSQLDSTypeBLEx.SQLVIEW)
                {
                    List<string> arrTabId = clsPrjTabBLEx.GetRelaParentNodeByTabId(objPrjTabENEx.TabId, objPrjTabENEx.PrjId);
                    //bool bolIsDef_strMsg = false;
                    foreach (string strRelaTabId in arrTabId)
                    {
                        clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabId_Cache(strRelaTabId, objPrjTabENEx.PrjId);
                        clsFuncModule_AgcEN objFuncModel_Agc = clsFuncModule_AgcBL.GetObjByFuncModuleAgcId_Cache(objPrjTab.FuncModuleAgcId, objPrjTab.PrjId);
                        if (objPrjTab.SqlDsTypeId == clsSQLDSTypeBLEx.SQLVIEW) continue;
                        strCodeForCs.AppendFormat("\r\n" + "import {{ cls{1}WApi }} from \"../../L3_ForWApi/{0}/cls{1}WApi.js\";",
                 objFuncModel_Agc.FuncModuleEnName,
                   objPrjTab.TabName);

                    }

                }
                strCodeForCs.Append("\r\n" + "import { Dictionary } from \"../../PubFun/tzDictionary.js\";");
                strCodeForCs.Append("\r\n" + "import { tzResponseData } from \"../../PubFun/tzResponseData.js\";");
                strCodeForCs.Append("\r\n" + "import { clsSysPara4WebApi } from \"../../PubFun/clsSysPara4WebApi.js\";");
                strCodeForCs.Append("\r\n" + "import { clsOrderByData } from \"../../PubFun/clsOrderByData.js\";");
                strCodeForCs.Append("\r\n" + "import { stuTopPara } from \"../../PubFun/stuTopPara.js\";");
                strCodeForCs.Append("\r\n" + "import { stuRangePara } from \"../../PubFun/stuRangePara.js\";");
                strCodeForCs.Append("\r\n" + "import { stuPagerPara } from \"../../PubFun/stuPagerPara.js\";");
                strCodeForCs.Append("\r\n" + "import { clsStackTrace } from \"../../PubFun/clsStackTrace.js\";");
                strCodeForCs.Append("\r\n" + "import { CacheHelper } from \"../../PubFun/CacheHelper.js\";");

                if (objPrjTabENEx.objCacheClassifyFld == null)
                {
                    strCodeForCs.Append("\r\n" + "import { clsCommFun4BL } from \"clscommfun4bl\";");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + "import { clsCommFun4BLV2 } from \"clscommfun4blv2\";");
                }

                strCodeForCs.Append("\r\n" + "const ResponseData: tzResponseData;");
                //strCodeForCs.Append("\r\n" + "const ReCallFunc = null;");

                strCodeForCs.AppendFormat("\r\n" + "export class cls{0}WApi ",
                  objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.AppendFormat("\r\n" + " this.mstrController = \"{0}Api\";",
                    objPrjTabENEx.TabName);

                strCodeForCs.AppendFormat("\r\n" + "public obj{0}EN = new {1}();",
                      objPrjTabENEx.TabName,
                           ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));
                //˽��������-----�����Թ���

                //˽��������-----�����Թ���

                strCodeForCs.AppendFormat("\r\n" + "constructor( pobj{0}EN)",
                  objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{1}.obj{0}EN = pobj{0}EN;",
                        objPrjTabENEx.TabName, 
                        objPrjTabENEx.ClsName);

                strCodeForCs.Append("\r\n" + "}");
                //�������еĺ���

                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                    clsvFunction4GeneCodeBLEx.GetObjLstByPrjTabEx(objPrjTabENEx, (int)enumApplicationType.WebApp_JS_17);


//                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
//                  clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId,
//                  objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId);
//                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_All = null;
//                //������-������صĺ���
//                IEnumerable<string> arrFeatureId = objPrjTabENEx.arrTabFeatureSet().Select(x => x.FeatureId);
//                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst4TabFeature_Cache
//= clsvFunction4GeneCodeBLEx.GetObjLst4FeatureIdLst(arrFeatureId, (int)enumApplicationType.SpaAppInCore_JS_18);
//                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst4TabFeature = null;
//                if (arrvFunction4GeneCodeObjLst4TabFeature_Cache != null)
//                {
//                    arrvFunction4GeneCodeObjLst4TabFeature = arrvFunction4GeneCodeObjLst4TabFeature_Cache.
//                        Where(x => x.CodeTypeId == objPrjTabENEx.CodeTypeId);
//                }
//                if (arrvFunction4GeneCodeObjLst4TabFeature != null && arrvFunction4GeneCodeObjLst4TabFeature.Count() > 0)
//                {
//                    arrvFunction4GeneCodeObjLst_All = arrvFunction4GeneCodeObjLst.Union(arrvFunction4GeneCodeObjLst4TabFeature, new VFunction4GeneCodeComparer());
//                }
//                else
//                {
//                    arrvFunction4GeneCodeObjLst_All = arrvFunction4GeneCodeObjLst;
//                }               
//                int intCount4 = arrvFunction4GeneCodeObjLst_All.Count();

//                arrvFunction4GeneCodeObjLst_All = arrvFunction4GeneCodeObjLst_All.OrderBy(x => x.OrderNum);

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GC_Cache(objvFunction4GeneCodeEN.FuncId4GC);
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
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
        public string A_GenWebApiTransCode_Ts_SelfDefWs(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
            string strResult = "";
            if (objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst.Count == 0)
            {
                strResult = string.Format("��ǰ��:[{0}]�ĺ�����Ϊ0,�޷�������ز�!({1})",
                      objWebSrvClassENEx.ClassName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }

            objWebSrvClassENEx.CurrDate = clsDateTime.getTodayStr2(0);

            //���û���������;
            //string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; ///��ʱ����;

            objWebSrvClassENEx.ClsName = "cls" + objWebSrvClassENEx.ClassName + "WS4SD";
            //objWebSrvClassENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebApiTransferLevel;

            objWebSrvClassENEx.SimpleFileName = objWebSrvClassENEx.ClsName + ".ts";
            strRe_ClsName = objWebSrvClassENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcId_Cache(objWebSrvClassENEx.FuncModuleAgcId, objWebSrvClassENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName, objWebSrvClassENEx.SimpleFileName);

            strClassFName = objWebSrvClassENEx.FolderName + objWebSrvClassENEx.ClsName + ".ts";
            objWebSrvClassENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjId_Cache(objWebSrvClassENEx.PrjId); //
            try
            {
                //������ʼ

                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objWebSrvClassENEx.CurrUserName, objWebSrvClassENEx));

                strCodeForCs.Append("\r\n" + ""); //

                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0}({1})", objWebSrvClassENEx.ClassName, objWebSrvClassENEx.ClassName);

                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.AppendFormat("\r\n" + "* Created by {0} on {1}.", objWebSrvClassENEx.CurrUserName, clsDateTime.getTodayStr(3));
                strCodeForCs.AppendFormat("\r\n" + "* ע��:�����������ý��洦��ͬһ������������ò��ɹ�!", objWebSrvClassENEx.CurrUserName, clsDateTime.getTodayStr(3));
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.Append("\r\n" + "const VirtualRootPath = getVirtualRootPath_web();//�ú���������/js/PubFun/jsPubFun.ts�ļ���");

                strCodeForCs.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/tzDictionary.ts\");");
                strCodeForCs.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/tzResponseData.ts\");");
                strCodeForCs.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/tzGetXmlHttp.ts\");");
                strCodeForCs.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/jsPubFun.ts\");");
                strCodeForCs.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/jsPubVar.ts\");");

                //strCodeForCs.AppendFormat("\r\n" + "include(VirtualRootPath + \"/js/{1}/js{0}EN.ts\");",
                //    objWebSrvClassENEx.ClassName,
                //    objWebSrvClassENEx.ObjFuncModule.FuncModuleEnName);

                strCodeForCs.Append("\r\n" + "const ResponseData;");
                strCodeForCs.Append("\r\n" + "const ReCallFunc = null;");

                strCodeForCs.AppendFormat("\r\n" + "const cls{0}WS4SD = function()",
                  objWebSrvClassENEx.ClassName);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "const Param;");
                strCodeForCs.Append("\r\n" + "const NameSpace = \"http://tempuri.org/\";");
                strCodeForCs.Append("\r\n" + "const MethodName = \"\";");
                strCodeForCs.Append("\r\n" + "const WEB_SERVICE_URL = \"\";");
                strCodeForCs.Append("\r\n" + "const soapAction = \"\";");

                //strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN;",
                //      objWebSrvClassENEx.ClassName);
                //˽��������-----�����Թ���

                //˽��������-----�����Թ���

                strCodeForCs.AppendFormat("\r\n" + "{0}.init = function()", objPrjTabENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{0}.Param = new {1}();", objPrjTabENEx.ClsName,
                           ImportClass.GetOutString(string.Format("Dictionary", objPrjTabENEx.TabName), this.Is4RJ));
                strCodeForCs.AppendFormat("\r\n" + "ResponseData = new tzResponseData();",
                    objWebSrvClassENEx.ClassName);

                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.AppendFormat("\r\n" + "{1}.init = function(strMethod, mapParam, pobj{0}EN, pReCallFunc)",
                        objWebSrvClassENEx.ClassName, 
                        objPrjTabENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "Param = new {0}();", ImportClass.GetOutString(string.Format("Dictionary", objPrjTabENEx.TabName), this.Is4RJ));
                strCodeForCs.Append("\r\n" + "ReCallFunc = pReCallFunc;");
                strCodeForCs.AppendFormat("\r\n" + "ResponseData = new tzResponseData();",
                     objWebSrvClassENEx.ClassName);

                strCodeForCs.AppendFormat("\r\n" + "{0}.MethodName = strMethod;", objPrjTabENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n" + "{0}.Param = mapParam;", objPrjTabENEx.ClsName);
                strCodeForCs.Append("\r\n" + "if (this.Param.length() === 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{0}.Param = new {1}();", objPrjTabENEx.ClsName, 
                    ImportClass.GetOutString(string.Format("Dictionary", objPrjTabENEx.TabName), this.Is4RJ));
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.AppendFormat("\r\n" + "{2}.WEB_SERVICE_URL = CurrIPAddressAndPort + \"/\" +CurrPrx + \"/{1}/{0}.asmx\";",
                        objWebSrvClassENEx.ClassName, 
                        objWebSrvClassENEx.ObjFuncModule.FuncModuleEnName, 
                        objPrjTabENEx.ClsName);

                strCodeForCs.Append("\r\n" + "}");
                //�������еĺ���

                clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncName_CacheEx("Gen_4WA_main_Ts_SelfDefWs");
                strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                strCodeForCs.Append("\r\n" + strTemp);

                foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
                {
                    if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                    try
                    {
                        strTemp = Gen_4WA_Js_ByCommonFunction(objWebSrvFunctionsENEx);
                        if (string.IsNullOrEmpty(strTemp) == false)
                        {
                            strCodeForCs.Append("\r\n" + strTemp);
                            clsWebSrvFunctionsBLEx.SetGeneCode(objWebSrvFunctionsENEx.WebSrvFunctionId, true);
                        }
                        else
                        {
                            strTemp = string.Format("//�ú���: [{0}]�޷�����.", objWebSrvFunctionsENEx.FunctionSignature);
                            strCodeForCs.Append("\r\n" + strTemp);
                        }
                    }
                    catch (Exception objException)
                    {
                        strTemp = string.Format("//�ú���: [{0}]�޷�����.����:[{1}]({2}->{3})",
                            objWebSrvFunctionsENEx.FunctionSignature,
                            objException.Message,
                            clsStackTrace.GetCurrClassFunctionByLevel(2),
                            clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }

                objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncName_CacheEx("Gen_4WA_CallWebApi_Ts_SelfDefWs");
                strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                strCodeForCs.Append("\r\n" + strTemp);

                objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncName_CacheEx("Gen_4WA_getReturnValue_TypeScript");
                strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                strCodeForCs.Append("\r\n" + strTemp);


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
        public string A_GeneFuncCode_TypeScript1(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncId4GC = objvFunction4GeneCodeEN.FuncId4GC;
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            if (strFuncName.IndexOf("Async") > 0)
            {
                return A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
            }
            try
            {
                string strCode = "";
                Type t = typeof(WA_Srv4CSharp);
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

        /// <summary>
        /// ����WebApi����Ӽ�¼�����ݴ���ʹ��JSON��
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Js_AddNewRecordBak()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����WebApi����Ӽ�¼�����ݴ���ʹ��JSON��");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵĶ���</param>", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n /// <param name = \"cb\">CallBack������������ʾ��ȷ�������</param>");
            strCodeForCs.Append("\r\n /// <param name = \"errorCb\">CallBack������������ʾ������Ϣ</param>");
            strCodeForCs.Append("\r\n /// <returns>��ȡ��Ӧ�ļ�¼�Ķ���</returns>");
            strCodeForCs.AppendFormat("\r\n" + "{2}.AddNewRecord  = function(obj{0}EN, cb, errorCb) ",
                    objPrjTabENEx.TabName,
                    objKeyField.FldName, 
                    objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "let strMsg = \"\";");

            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"AddNewRecord\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            if (objKeyField.PrimaryTypeId != enumPrimaryType.StringAutoAddPrimaryKey_03
     && objKeyField.PrimaryTypeId != enumPrimaryType.Identity_02
     && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType != "bool"
     && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType != "int"
      && objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType != "long")
            {

                if (objKeyField.TypeScriptType == "number")
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.{1} === null || obj{0}EN.{1} === 0)",
                      objPrjTabENEx.TabName,
                   objKeyField.FldName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.{1} === null || obj{0}EN.{1} === \"\")",
                         objPrjTabENEx.TabName,
                      objKeyField.FldName);
                }
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "strMsg = \"��Ҫ�Ķ���Ĺؼ���Ϊ�գ��������!\";");
                strCodeForCs.Append("\r\n" + "throw strMsg;");
                strCodeForCs.Append("\r\n" + "}");
            }

            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN_Sim = {1}.GetSimObjFromObj(obj{0}EN);",
              objPrjTabENEx.TabName,
                           ImportClass.GetOutString(string.Format("cls{0}BL", objPrjTabENEx.TabName), this.Is4RJ));
            strCodeForCs.AppendFormat("\r\n" + " //var strJSON = JSON.stringify(obj{0}EN);",
           objPrjTabENEx.TabName);
            //var strJSON = JSON.stringify(objMyTest1EN);
            //strCodeForCs.AppendFormat("\r\n" + "mapParam.add(\"str{0}JSONObj\", strJSON);",
            //  objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "const strUrl = this.GetWebApiUrl({0}.mstrController, strAction);", objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const response = await axios.post(strUrl, obj{0}EN_Sim);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "const data = response.data;");

            strCodeForCs.Append("\r\n" + "cb(data);");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"������󣡷��ʵ�ַ:\" + strUrl + \"���ɹ���\";");
            strCodeForCs.Append("\r\n" + "errorCb(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "errorCb(result.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
             
        /// <summary>
        /// ����WebApi��ɾ����¼
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Js_DelRecordBak()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����WebApi��ɾ����¼");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">�ؼ���</param>", objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n /// <param name = \"cb\">CallBack������������ʾ��ȷ�������</param>");
            strCodeForCs.Append("\r\n /// <param name = \"errorCb\">CallBack������������ʾ������Ϣ</param>");
            strCodeForCs.Append("\r\n /// <returns>��ȡɾ���Ľ��</returns>");
            strCodeForCs.AppendFormat("\r\n" + "{2}.DelRecord  = function({0}, cb, errorCb) ",
                            objKeyField.PrivFuncName, 
                            KeyDataType, 
                            objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"DelRecord\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "const strUrl = this.GetWebApiUrl({0}.mstrController, strAction);", objPrjTabENEx.ClsName);

            strCodeForCs.Append("\r\n" + "$.ajax({");
            strCodeForCs.Append("\r\n" + "url: strUrl,");
            strCodeForCs.Append("\r\n" + "method: \"DELETE\",");
            strCodeForCs.Append("\r\n" + "dataType: \"json\",");

            strCodeForCs.AppendFormat("\r\n" + "data: {{ \"\": {0} }},", objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "success: function(data:any) {");
            strCodeForCs.Append("\r\n" + "cb(data);");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"������󣡷��ʵ�ַ:\" + strUrl + \"���ɹ���\";");
            strCodeForCs.Append("\r\n" + "errorCb(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "errorCb(result.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");


            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
                
        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Js_GetRecCountByCondBak()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��ȡĳһ�����ļ�¼��");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"strWhereCond\">����</param>");
            strCodeForCs.Append("\r\n /// <param name = \"cb\">CallBack������������ʾ��ȷ�������</param>");
            strCodeForCs.Append("\r\n /// <param name = \"errorCb\">CallBack������������ʾ������Ϣ</param>");
            strCodeForCs.Append("\r\n /// <returns>��ȡĳһ�����ļ�¼��</returns>");
            strCodeForCs.AppendFormat("\r\n" + "{2}.GetRecCountByCond = function(strWhereCond, cb, errorCb) ",
                    objPrjTabENEx.TabName,
                    objKeyField.FldName, 
                    objPrjTabENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strAction = \"GetRecCountByCond\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "const strUrl = this.GetWebApiUrl({0}.mstrController, strAction);", objPrjTabENEx.ClsName);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const response = await axios.get(strUrl,");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "params: { \"strWhereCond\": strWhereCond}");
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "const data = response.data;");

            strCodeForCs.Append("\r\n" + "cb(data);");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"������󣡷��ʵ�ַ:\" + strUrl + \"���ɹ���\";");
            strCodeForCs.Append("\r\n" + "errorCb(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "errorCb(result.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
        
        /// <summary>
        /// ���ݹؼ��ֻ�ȡ�������, �ӻ���Ķ����б��л�ȡ.
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Js_GetObjByKeyId_Cache()
        {

            StringBuilder strCodeForCs = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;

            strCodeForCs.AppendFormat("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// ���ݹؼ��ֻ�ȡ��ض���, �ӻ����л�ȡ.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���</param>", objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n /// <returns>����</returns>");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "{4}.GetObjBy{1}_Cache = async function({2}) {{",
                        objPrjTabENEx.TabName, 
                        objKeyField.FldName,
                        objKeyField.PrivFuncName,
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType, 
                        objPrjTabENEx.ClsName);

            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "{6}.GetObjBy{1}_Cache = async function({2},{4}) {{",
                    objPrjTabENEx.TabName, 
                    objKeyField.FldName,
                    objKeyField.PrivFuncName,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType, 
                    objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                    objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType, 
                    objPrjTabENEx.ClsName);
            }
            //if (objPrjTabENEx.objCacheClassifyFld == null)
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "const strKey = {1}._CurrTabName;",
            //     objPrjTabENEx.TabName,
            //               ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));

            //}
            //else
            //{
            //    if (objPrjTabENEx.objCacheClassifyFld.IsNumberType() == true)
            //    {
            //        strCodeForCs.AppendFormat("\r\n" + "const strKey = \"{{ {2}._CurrTabName}}_\" + {1} ;",
            //               objPrjTabENEx.TabName, 
            //               objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
            //               ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));

            //    }
            //    else
            //    {
            //        strCodeForCs.AppendFormat("\r\n" + "const strKey =  {2}._CurrTabName + \"_\" + {1} ;",
            //             objPrjTabENEx.TabName, 
            //             objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
            //               ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));
            //    }
            //}
            //strCodeForCs.AppendFormat("\r\n" + "if ({0}.Exsits(strKey) == false)",
            //               ImportClass.GetOutString(string.Format("CacheHelper", objPrjTabENEx.TabName), this.Is4RJ));
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "const strMsg = \"Key:[\" + strKey + \"]�Ķ����б��治����,���飡\";");
            //strCodeForCs.Append("\r\n" + "throw new Error(strMsg);");
            //strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst_Cache = {1}.Get(strKey);", objPrjTabENEx.TabName,
            //               ImportClass.GetOutString(string.Format("CacheHelper", objPrjTabENEx.TabName), this.Is4RJ));

            
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst_Cache = await {0}_GetObjLst_Cache();", objPrjTabENEx.TabName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst_Cache = await {0}_GetObjLst_Cache({1});", objPrjTabENEx.TabName,
                    objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }
            strCodeForCs.AppendFormat("\r\n" + "const obj = new {1}();", objPrjTabENEx.TabName,
                           ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}_Sel = arr{0}ObjLst_Cache.filter(x => x.{1} == {2});",
                objPrjTabENEx.TabName, objKeyField.PropertyName(), objKeyField.PrivFuncName);

            strCodeForCs.AppendFormat("\r\n" + "const obj{0};", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}_Sel.length > 0)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "obj{0} = arr{0}_Sel[0];", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "return obj{0};", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return obj;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"���ݹؼ���:[\" + {0}  + \"]��ȡ��Ӧ�Ķ��󲻳ɹ�!\";", objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return obj;");

            strCodeForCs.Append("\r\n" + "}");

            //���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strCodeForCs.ToString();
        }


        public string Gen_4WA_Js_SetCache()
        {

            StringBuilder strCodeForCs = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;

            strCodeForCs.AppendFormat("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// ���ݹؼ��ֻ�ȡ��ض���, �ӻ����л�ȡ.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���</param>", objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n /// <returns>����</returns>");

                strCodeForCs.AppendFormat("\r\n" + "{0}.SetCache = function() {{",
                        objPrjTabENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "{0}.objCommFun4BL = new {1}();",
                objPrjTabENEx.ClsName,
                           ImportClass.GetOutString(string.Format("clsCommFun4WA4{0}", objPrjTabENEx.TabName), this.Is4RJ));

            strCodeForCs.AppendFormat("\r\n //������������ӵ�clsPubFun.js��");
            strCodeForCs.AppendFormat("\r\n" + "//\"../L3_ForWApi/{1}/{0}_js\"",
                    objPrjTabENEx.TabName, objFuncModuleEN.FuncModuleEnName);
            strCodeForCs.AppendFormat("\r\n" + "//var cls{0}WApi_js_1 = require(\"../L3_ForWApi/{1}/{0}_js\");",
                objPrjTabENEx.TabName, objFuncModuleEN.FuncModuleEnName);
            strCodeForCs.AppendFormat("\r\n" + "//{0}.SetCache();",
                           ImportClass.GetOutString(string.Format("cls{0}WApi", objPrjTabENEx.TabName), this.Is4RJ));

            strCodeForCs.Append("\r\n" + "}");

            //���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ�������, �ӻ���Ķ����б��л�ȡ.
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Js_IsExist_Cache()
        {

            StringBuilder strCodeForCs = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;

            strCodeForCs.AppendFormat("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// ���ݹؼ����ж��Ƿ���ڼ�¼, �ӱ��ػ������ж�.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">�����Ĺؼ���</param>", objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n /// <returns>����</returns>");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "{4}.IsExist_Cache = async function({2}) {{",
                    objPrjTabENEx.TabName, 
                    objKeyField.FldName,
                    objKeyField.PrivFuncName,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType, 
                    objPrjTabENEx.ClsName);

            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "{6}.IsExist_Cache = async function({2},{4}) {{",
                        objPrjTabENEx.TabName, 
                        objKeyField.FldName,
                        objKeyField.PrivFuncName,
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType, 
                        objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                        objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType, 
                        objPrjTabENEx.ClsName);
            }
            //if (objPrjTabENEx.objCacheClassifyFld == null)
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "const strKey = {1}._CurrTabName;",
            //     objPrjTabENEx.TabName,
            //               ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));

            //}
            //else
            //{
            //    if (objPrjTabENEx.objCacheClassifyFld.IsNumberType() == true)
            //    {
            //        strCodeForCs.AppendFormat("\r\n" + "const strKey = \"{{ {2}._CurrTabName}}_\" + {1} ;",
            //               objPrjTabENEx.TabName, 
            //               objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
            //               ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));

            //    }
            //    else
            //    {
            //        strCodeForCs.AppendFormat("\r\n" + "const strKey =  {2}._CurrTabName + \"_\" + {1} ;",
            //             objPrjTabENEx.TabName, 
            //             objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
            //               ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));
            //    }
            //}
            //strCodeForCs.AppendFormat("\r\n" + "if ({0}.Exsits(strKey) == false)",
            //               ImportClass.GetOutString(string.Format("CacheHelper", objPrjTabENEx.TabName), this.Is4RJ));
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "const strMsg = \"Key:[\" + strKey + \"]�Ķ����б��治����,���飡\";");
            //strCodeForCs.Append("\r\n" + "throw new Error(strMsg);");
            //strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst_Cache = {1}.Get(strKey);", objPrjTabENEx.TabName,
            //               ImportClass.GetOutString(string.Format("CacheHelper", objPrjTabENEx.TabName), this.Is4RJ));

            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst_Cache = await {0}_GetObjLst_Cache();", objPrjTabENEx.TabName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst_Cache = await {0}_GetObjLst_Cache({1});", objPrjTabENEx.TabName,
                    objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }
            strCodeForCs.AppendFormat("\r\n" + "const obj = new {1}();", objPrjTabENEx.TabName,
                           ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}_Sel = arr{0}ObjLst_Cache.filter(x => x.{1} == {2});",
                objPrjTabENEx.TabName, objKeyField.PropertyName(), objKeyField.PrivFuncName);

            strCodeForCs.AppendFormat("\r\n" + "const obj{0};", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}_Sel.length > 0)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");    
            strCodeForCs.AppendFormat("\r\n" + "return true;", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return false;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"���ݹؼ���:[\" + {0}  + \"]�ж��Ƿ���ڲ��ɹ�!\";", objKeyField.PrivFuncName);
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return false;");

            strCodeForCs.Append("\r\n" + "}");

            //���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strCodeForCs.ToString();
        }


        /// <summary>
        /// ���ݹؼ��ֻ�ȡ�������, �ӻ���Ķ����б��л�ȡ.
        /// </summary>
        /// <returns></returns>
        public string Gen_4WA_Js_GetObjLstByKeyLst_Cache()
        {

            StringBuilder strCodeForCs = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;

            strCodeForCs.AppendFormat("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// ���ݹؼ����б��ȡ��ض����б�, �ӻ����л�ȡ.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"arr{0}Lst\">�ؼ����б�</param>", objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n /// <returns>�����б�</returns>");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "{3}.GetObjLstBy{1}Lst_Cache =  async function(arr{1}Lst) {{",
                    objPrjTabENEx.TabName,
                    objKeyField.FldName,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType, 
                    objPrjTabENEx.ClsName);

            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "{5}.GetObjLstBy{1}Lst_Cache =  async function(arr{1}Lst,{3}) {{",
                    objPrjTabENEx.TabName,
                    objKeyField.FldName,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType, 
                    objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                        objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType, 
                        objPrjTabENEx.ClsName);
            }
            //if (objPrjTabENEx.objCacheClassifyFld == null)
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "const strKey = {1}._CurrTabName;",
            //     objPrjTabENEx.TabName,
            //               ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));

            //}
            //else
            //{
            //    if (objPrjTabENEx.objCacheClassifyFld.IsNumberType() == true)
            //    {
            //        strCodeForCs.AppendFormat("\r\n" + "const strKey = {2}._CurrTabName + \"_\" + {1} ;",
            //               objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
            //               ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));

            //    }
            //    else
            //    {
            //        strCodeForCs.AppendFormat("\r\n" + "const strKey =  {2}._CurrTabName + \"_\" + {1} ;",
            //             objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
            //               ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));
            //    }
            //}
            //strCodeForCs.AppendFormat("\r\n" + "if ({0}.Exsits(strKey) == false)",
            //               ImportClass.GetOutString(string.Format("CacheHelper", objPrjTabENEx.TabName), this.Is4RJ));
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "const strMsg = \"Key:[\" + strKey + \"]�Ķ����б��治����,���飡\";");
            //strCodeForCs.Append("\r\n" + "throw new Error(strMsg);");
            //strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.Append("\r\n" + "try");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst_Cache = {1}.Get(strKey);", objPrjTabENEx.TabName,
            //               ImportClass.GetOutString(string.Format("CacheHelper", objPrjTabENEx.TabName), this.Is4RJ));

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst_Cache = await {0}_GetObjLst_Cache();", objPrjTabENEx.TabName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst_Cache = await {0}_GetObjLst_Cache({1});", objPrjTabENEx.TabName,
                    objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}_Sel = arr{0}ObjLst_Cache.filter(x => arr{1}Lst.indexOf(x.{2})>-1);",
                objPrjTabENEx.TabName, objKeyField.FldName, objKeyField.PropertyName());

            strCodeForCs.AppendFormat("\r\n" + "return arr{0}_Sel;", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"���ݹؼ���:[\" + arr{0}Lst.join(\",\")  + \"]��ȡ��Ӧ�Ķ��󲻳ɹ�!\";", objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "throw new Error(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "return null;", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "}");

            //���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strCodeForCs.ToString();
        }


        public string Gen_4WA_Js_GetObjLstByPager_Cache()
        {

            StringBuilder strCodeForCs = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;

            strCodeForCs.AppendFormat("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// �ӻ����л�ȡ��ҳ�����б�.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"objPagerPara\">��ҳ�����ṹ</param>", objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n /// <returns>�����б�</returns>");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "{3}.GetObjLstByPager_Cache =  async function(objPagerPara) {{",
                        objPrjTabENEx.TabName,
                        objKeyField.FldName,
                        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType, 
                        objPrjTabENEx.ClsName);

            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "{2}.GetObjLstByPager_Cache =  async function(objPagerPara,{0}) {{",
                    objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                    objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType, 
                    objPrjTabENEx.ClsName);
            }
            //if (objPrjTabENEx.objCacheClassifyFld == null)
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "const strKey = {1}._CurrTabName;",
            //     objPrjTabENEx.TabName,
            //               ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));

            //}
            //else
            //{
            //    if (objPrjTabENEx.objCacheClassifyFld.IsNumberType() == true)
            //    {
            //        strCodeForCs.AppendFormat("\r\n" + "const strKey = \"{{ {2}._CurrTabName}}_\" + {1};",
            //               objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
            //               ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));

            //    }
            //    else
            //    {
            //        strCodeForCs.AppendFormat("\r\n" + "const strKey =  {2}._CurrTabName + \"_\" + {1} ;",
            //             objPrjTabENEx.TabName, 
            //             objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
            //               ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));
            //    }
            //}
            //strCodeForCs.AppendFormat("\r\n" + "if ({0}.Exsits(strKey) == false)",
            //               ImportClass.GetOutString(string.Format("CacheHelper", objPrjTabENEx.TabName), this.Is4RJ));
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "const strMsg = \"Key:[\" + strKey + \"]�Ķ����б��治����,���飡\";");
            //strCodeForCs.Append("\r\n" + "throw new Error(strMsg);");
            //strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst_Cache = {1}.Get(strKey);", objPrjTabENEx.TabName,
            //               ImportClass.GetOutString(string.Format("CacheHelper", objPrjTabENEx.TabName), this.Is4RJ));

            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst_Cache = await {0}_GetObjLst_Cache();", objPrjTabENEx.TabName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst_Cache = await {0}_GetObjLst_Cache({1});", objPrjTabENEx.TabName,
                    objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}_Sel = arr{0}ObjLst_Cache;", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "const obj_Cond = JSON.parse(objPagerPara.whereCond);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "const dicFldComparisonOp = {};");
            strCodeForCs.Append("\r\n" + "if (obj_Cond.sf_FldComparisonOp != \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "//console.log(\"cls{0}WApi->GetObjLstByPager_Cache->dicFldComparisonOp:\");", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "//console.log(dicFldComparisonOp);", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "try {");
            strCodeForCs.AppendFormat("\r\n" + "const sstrKeys = {0}.GetObjKeys(obj_Cond);",
                           ImportClass.GetOutString(string.Format("clsCommFunc4Web", objPrjTabENEx.TabName), this.Is4RJ));
            strCodeForCs.Append("\r\n" + "//console.log(sstrKeys);");

            strCodeForCs.Append("\r\n" + "for (const strKey of sstrKeys) {");
            strCodeForCs.Append("\r\n" + "if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;");
            strCodeForCs.Append("\r\n" + "const strComparisonOp = dicFldComparisonOp[strKey];");
            strCodeForCs.AppendFormat("\r\n" + "const obj{0} = cls{0}BL.GetObjFromSimObj(obj_Cond);", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "const strValue = obj{0}.GetFldValue(strKey);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "const strType = typeof(strValue);");
            strCodeForCs.Append("\r\n" + "switch (strType) {");
            strCodeForCs.Append("\r\n" + "case \"string\":");
            strCodeForCs.Append("\r\n" + "if (strValue == null) continue;");
            strCodeForCs.Append("\r\n" + "if (strValue == \"\") continue;");
            strCodeForCs.Append("\r\n" + "if (strComparisonOp == \"=\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}_Sel = arr{0}_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"like\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}_Sel = arr{0}_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");

            strCodeForCs.Append("\r\n" + "case \"boolean\":");
            strCodeForCs.Append("\r\n" + "if (strValue == null) continue;");

            strCodeForCs.Append("\r\n" + "if (strComparisonOp == \"=\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}_Sel = arr{0}_Sel.filter(x => x.GetFldValue(strKey) == strValue);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");

            strCodeForCs.Append("\r\n" + "case \"number\":");
            strCodeForCs.Append("\r\n" + "if (Number(strValue) == 0) continue;");
            strCodeForCs.Append("\r\n" + "if (strComparisonOp == \"=\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}_Sel = arr{0}_Sel.filter(x => x.GetFldValue(strKey) == strValue);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \">=\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}_Sel = arr{0}_Sel.filter(x => x.GetFldValue(strKey) >= strValue);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"<=\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}_Sel = arr{0}_Sel.filter(x => x.GetFldValue(strKey) <= strValue);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \">\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}_Sel = arr{0}_Sel.filter(x => x.GetFldValue(strKey) > strValue);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"<\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}_Sel = arr{0}_Sel.filter(x => x.GetFldValue(strKey) <= strValue);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.Append("\r\n" + "const intStart = objPagerPara.pageSize* (objPagerPara.pageIndex - 1);");
            strCodeForCs.Append("\r\n" + "if (intStart <= 0) intStart = 0;");
                  
            strCodeForCs.Append("\r\n" + "const intEnd = intStart + objPagerPara.pageSize;");


            strCodeForCs.Append("\r\n" + "if (objPagerPara.orderBy != null && objPagerPara.orderBy.length>0) {");
            strCodeForCs.Append("\r\n" + "const sstrSplit = objPagerPara.orderBy.split(\" \");");
            strCodeForCs.Append("\r\n" + "const strSortType = \"asc\";");
            strCodeForCs.Append("\r\n" + "const strSortFld = sstrSplit[0];");
            strCodeForCs.Append("\r\n" + "if (sstrSplit.length > 1) strSortType = sstrSplit[1];");

            strCodeForCs.Append("\r\n" + "if (strSortType.toLowerCase() == \"asc\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}_Sel = arr{0}_Sel.sort((x, y) => x[strSortFld].localeCompare(y[strSortFld]));", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}_Sel = arr{0}_Sel.sort((x, y) => y[strSortFld].localeCompare(x[strSortFld]));", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}_Sel = arr{0}_Sel.slice(intStart, intEnd);     ", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "return arr{0}_Sel;", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e) {");
            strCodeForCs.Append("\r\n" + "const strMsg = \"��������:[\" +objPagerPara.whereCond + \"]��ȡ��Ӧ�Ķ��󲻳ɹ�!\";");
            strCodeForCs.Append("\r\n" + "throw new Error(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "return null;", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "}");

            //���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strCodeForCs.ToString();
        }

        public string Gen_4WA_Js_GetSubObjLst_Cache()
        {

            StringBuilder strCodeForCs = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;

            strCodeForCs.AppendFormat("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// ������������, �ӻ���Ķ����б��л�ȡ�Ӽ�.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}_Cond\">��������</param>", objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n /// <returns>�����б��Ӽ�</returns>");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "{1}.GetSubObjLst_Cache =  async function(obj{0}_Cond) {{",
                  objPrjTabENEx.TabName,
                     objPrjTabENEx.ClsName);

            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "{1}.GetSubObjLst_Cache =  async function(obj{2}_Cond,{0}) {{",
                     objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                objPrjTabENEx.ClsName,
                objPrjTabENEx.TabName);
            }
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}_Sim = {1}.GetSimObjFromObj(obj{0}_Cond);", objPrjTabENEx.TabName,
                           ImportClass.GetOutString(string.Format("cls{0}BL", objPrjTabENEx.TabName), this.Is4RJ));

            //if (objPrjTabENEx.objCacheClassifyFld == null)
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "const strKey = {1}._CurrTabName;",
            //     objPrjTabENEx.TabName,
            //     ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));

            //}
            //else
            //{
            //    if (objPrjTabENEx.objCacheClassifyFld.IsNumberType() == true)
            //    {
            //        strCodeForCs.AppendFormat("\r\n" + "const strKey = {2}._CurrTabName + \"_\" + {1} ;",
            //               objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
            //               ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));

            //    }
            //    else
            //    {
            //        strCodeForCs.AppendFormat("\r\n" + "const strKey =  {2}._CurrTabName + \"_\" + {1} ;",
            //             objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
            //               ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));
            //    }
            //}
            //strCodeForCs.AppendFormat("\r\n" + "if ({0}.Exsits(strKey) == false)",
            //               ImportClass.GetOutString(string.Format("CacheHelper", objPrjTabENEx.TabName), this.Is4RJ));
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "const strMsg = \"Key:[\" + strKey + \"]�Ķ����б��治����,���飡\";");
            //strCodeForCs.Append("\r\n" + "throw new Error(strMsg);");
            //strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst_Cache = {1}.Get(strKey);", objPrjTabENEx.TabName,
            //               ImportClass.GetOutString(string.Format("CacheHelper", objPrjTabENEx.TabName), this.Is4RJ));
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst_Cache = await {0}_GetObjLst_Cache();", objPrjTabENEx.TabName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst_Cache = await {0}_GetObjLst_Cache({1});", objPrjTabENEx.TabName,
                    objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}_Sel = arr{0}ObjLst_Cache;", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "if (obj{0}_Sim.sf_FldComparisonOp == null || obj{0}_Sim.sf_FldComparisonOp == \"\") return arr{0}_Sel;", objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "const dicFldComparisonOp = JSON.parse(obj{0}_Sim.sf_FldComparisonOp);", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "//console.log(\"cls{0}WApi->GetSubObjLst_Cache->dicFldComparisonOp:\");", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "//console.log(dicFldComparisonOp);", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "try {");
            strCodeForCs.AppendFormat("\r\n" + "const sstrKeys = {1}.GetObjKeys(obj{0}_Sim);", objPrjTabENEx.TabName,
                           ImportClass.GetOutString(string.Format("clsCommFunc4Web", objPrjTabENEx.TabName), this.Is4RJ));
            strCodeForCs.Append("\r\n" + "//console.log(sstrKeys);");

            strCodeForCs.Append("\r\n" + "for (const strKey of sstrKeys) {");
            strCodeForCs.Append("\r\n" + "if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;");
            strCodeForCs.Append("\r\n" + "const strComparisonOp = dicFldComparisonOp[strKey];");

            strCodeForCs.AppendFormat("\r\n" + "const strValue = obj{0}_Cond.GetFldValue(strKey);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "const strType = typeof(strValue);");
            strCodeForCs.Append("\r\n" + "switch (strType) {");
            strCodeForCs.Append("\r\n" + "case \"string\":");
            strCodeForCs.Append("\r\n" + "if (strValue == null) continue;");
            strCodeForCs.Append("\r\n" + "if (strValue == \"\") continue;");
            strCodeForCs.Append("\r\n" + "if (strComparisonOp == \"=\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}_Sel = arr{0}_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"like\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}_Sel = arr{0}_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");

            strCodeForCs.Append("\r\n" + "case \"boolean\":");
            strCodeForCs.Append("\r\n" + "if (strValue == null) continue;");

            strCodeForCs.Append("\r\n" + "if (strComparisonOp == \"=\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}_Sel = arr{0}_Sel.filter(x => x.GetFldValue(strKey) == strValue);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");


            strCodeForCs.Append("\r\n" + "case \"number\":");
            strCodeForCs.Append("\r\n" + "if (Number(strValue) == 0) continue;");
            strCodeForCs.Append("\r\n" + "if (strComparisonOp == \"=\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}_Sel = arr{0}_Sel.filter(x => x.GetFldValue(strKey) == strValue);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \">=\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}_Sel = arr{0}_Sel.filter(x => x.GetFldValue(strKey) >= strValue);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"<=\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}_Sel = arr{0}_Sel.filter(x => x.GetFldValue(strKey) <= strValue);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \">\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}_Sel = arr{0}_Sel.filter(x => x.GetFldValue(strKey) > strValue);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"<\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}_Sel = arr{0}_Sel.filter(x => x.GetFldValue(strKey) <= strValue);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "return arr{0}_Sel;", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e) {");
            strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"��������:[\" +JSON.stringify( obj{0}_Sim) + \"]��ȡ��Ӧ�Ķ��󲻳ɹ�!\";", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "throw new Error(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "return null;", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "}");

            //���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strCodeForCs.ToString();
        }


        public string Gen_4WA_Js_IsExistRecord_Cache()
        {

            StringBuilder strCodeForCs = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;

            strCodeForCs.AppendFormat("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// ������������, �ӻ���Ķ����б��л�ȡ�Ӽ�.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}_Cond\">��������</param>", objKeyField.PrivFuncName);
            strCodeForCs.AppendFormat("\r\n /// <returns>�����б��Ӽ�</returns>");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "{1}.IsExistRecord_Cache =  async function(obj{0}_Cond) {{",
                  objPrjTabENEx.TabName, objPrjTabENEx.ClsName);

            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "{5}.IsExistRecord_Cache =  async function(obj{0}_Cond,{3}) {{",
                    objPrjTabENEx.TabName,
                    objKeyField.FldName,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType, 
                    objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                    objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType, 
                    objPrjTabENEx.ClsName);
            }
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}_Sim = {1}.GetSimObjFromObj(obj{0}_Cond);", objPrjTabENEx.TabName,
                           ImportClass.GetOutString(string.Format("cls{0}BL", objPrjTabENEx.TabName), this.Is4RJ));

            //if (objPrjTabENEx.objCacheClassifyFld == null)
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "const strKey = {1}._CurrTabName;",
            //     objPrjTabENEx.TabName,
            //               ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));

            //}
            //else
            //{
            //    if (objPrjTabENEx.objCacheClassifyFld.IsNumberType() == true)
            //    {
            //        strCodeForCs.AppendFormat("\r\n" + "const strKey = {2}._CurrTabName + \"_\" + {1} ;",
            //               objPrjTabENEx.TabName, 
            //               objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
            //               ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));

            //    }
            //    else
            //    {
            //        strCodeForCs.AppendFormat("\r\n" + "const strKey =  {2}._CurrTabName + \"_\" + {1} ;",
            //             objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
            //               ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));
            //    }
            //}
            //strCodeForCs.AppendFormat("\r\n" + "if ({0}.Exsits(strKey) == false)",
            //               ImportClass.GetOutString(string.Format("CacheHelper", objPrjTabENEx.TabName), this.Is4RJ));
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "const strMsg = \"Key:[\" + strKey + \"]�Ķ����б��治����,���飡\";");
            //strCodeForCs.Append("\r\n" + "throw new Error(strMsg);");
            //strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst_Cache = {1}.Get(strKey);", objPrjTabENEx.TabName,
            //               ImportClass.GetOutString(string.Format("CacheHelper", objPrjTabENEx.TabName), this.Is4RJ));

            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst_Cache = await {0}_GetObjLst_Cache();", objPrjTabENEx.TabName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst_Cache = await {0}_GetObjLst_Cache({1});", objPrjTabENEx.TabName,
                    objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}_Sel = arr{0}ObjLst_Cache;", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "if (obj{0}_Sim.sf_FldComparisonOp == null || obj{0}_Sim.sf_FldComparisonOp == \"\") return arr{0}_Sel.length>0?true:false;", objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "const dicFldComparisonOp = JSON.parse(obj{0}_Sim.sf_FldComparisonOp);", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "//console.log(\"cls{0}WApi->GetSubObjLst_Cache->dicFldComparisonOp:\");", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "//console.log(dicFldComparisonOp);", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "try {");
            strCodeForCs.AppendFormat("\r\n" + "const sstrKeys = {1}.GetObjKeys(obj{0}_Sim);", objPrjTabENEx.TabName,
                           ImportClass.GetOutString(string.Format("clsCommFunc4Web", objPrjTabENEx.TabName), this.Is4RJ));
            strCodeForCs.Append("\r\n" + "//console.log(sstrKeys);");

            strCodeForCs.Append("\r\n" + "for (const strKey of sstrKeys) {");
            strCodeForCs.Append("\r\n" + "if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;");
            strCodeForCs.Append("\r\n" + "const strComparisonOp = dicFldComparisonOp[strKey];");

            strCodeForCs.AppendFormat("\r\n" + "const strValue = obj{0}_Cond.GetFldValue(strKey);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "const strType = typeof(strValue);");
            strCodeForCs.Append("\r\n" + "switch (strType) {");
            strCodeForCs.Append("\r\n" + "case \"string\":");
            strCodeForCs.Append("\r\n" + "if (strValue == null) continue;");
            strCodeForCs.Append("\r\n" + "if (strValue == \"\") continue;");
            strCodeForCs.Append("\r\n" + "if (strComparisonOp == \"=\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}_Sel = arr{0}_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"like\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}_Sel = arr{0}_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");

            strCodeForCs.Append("\r\n" + "case \"boolean\":");
            strCodeForCs.Append("\r\n" + "if (strValue == null) continue;");

            strCodeForCs.Append("\r\n" + "if (strComparisonOp == \"=\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}_Sel = arr{0}_Sel.filter(x => x.GetFldValue(strKey) == strValue);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
  strCodeForCs.Append("\r\n" + "break;");

            strCodeForCs.Append("\r\n" + "case \"number\":");
            strCodeForCs.Append("\r\n" + "if (Number(strValue) == 0) continue;");
            strCodeForCs.Append("\r\n" + "if (strComparisonOp == \"=\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}_Sel = arr{0}_Sel.filter(x => x.GetFldValue(strKey) == strValue);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \">=\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}_Sel = arr{0}_Sel.filter(x => x.GetFldValue(strKey) >= strValue);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"<=\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}_Sel = arr{0}_Sel.filter(x => x.GetFldValue(strKey) <= strValue);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \">\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}_Sel = arr{0}_Sel.filter(x => x.GetFldValue(strKey) > strValue);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"<\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}_Sel = arr{0}_Sel.filter(x => x.GetFldValue(strKey) <= strValue);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}_Sel.length > 0)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "return true;", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return false;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e) {");
            strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"��������:[\" +JSON.stringify( obj{0}_Sim) + \"]�ж��Ƿ���ڲ��ɹ�!\";", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "throw new Error(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "return false;", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "}");

            //���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strCodeForCs.ToString();
        }


        public string Gen_4WA_Js_GetRecCountByCond_Cache()
        {

            StringBuilder strCodeForCs = new StringBuilder();
            ///���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ.-----------------------------;

            strCodeForCs.AppendFormat("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// ������������, �ӻ���Ķ����б��л�ȡ��¼��.");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.AppendFormat("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}_Cond\">��������</param>", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n /// <returns>�����б��¼��</returns>");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "{1}.GetRecCountByCond_Cache =  async function(obj{0}_Cond) {{",
                  objPrjTabENEx.TabName,
                    objPrjTabENEx.ClsName);

            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "{5}.GetRecCountByCond_Cache =  async function(obj{0}_Cond,{3}) {{",
                    objPrjTabENEx.TabName,
                    objKeyField.FldName,
                    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType, 
                    objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                    objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType, 
                    objPrjTabENEx.ClsName);
            }
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}_Sim = {1}.GetSimObjFromObj(obj{0}_Cond);", objPrjTabENEx.TabName,
                           ImportClass.GetOutString(string.Format("cls{0}BL", objPrjTabENEx.TabName), this.Is4RJ));

            //if (objPrjTabENEx.objCacheClassifyFld == null)
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "const strKey = {1}._CurrTabName;",
            //     objPrjTabENEx.TabName,
            //               ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));

            //}
            //else
            //{
            //    if (objPrjTabENEx.objCacheClassifyFld.IsNumberType() == true)
            //    {
            //        strCodeForCs.AppendFormat("\r\n" + "const strKey = {2}._CurrTabName + \"_\" + {1} ;",
            //               objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
            //               ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));

            //    }
            //    else
            //    {
            //        strCodeForCs.AppendFormat("\r\n" + "const strKey =  {2}._CurrTabName + \"_\" + {1} ;",
            //             objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
            //               ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));
            //    }
            //}
            //strCodeForCs.AppendFormat("\r\n" + "if ({0}.Exsits(strKey) == false)",
            //               ImportClass.GetOutString(string.Format("CacheHelper", objPrjTabENEx.TabName), this.Is4RJ));
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "const strMsg = \"Key:[\" + strKey + \"]�Ķ����б��治����,���飡\";");
            //strCodeForCs.Append("\r\n" + "throw new Error(strMsg);");
            //strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst_Cache = {1}.Get(strKey);", objPrjTabENEx.TabName,
            //               ImportClass.GetOutString(string.Format("CacheHelper", objPrjTabENEx.TabName), this.Is4RJ));
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst_Cache = await {0}_GetObjLst_Cache();", objPrjTabENEx.TabName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst_Cache = await {0}_GetObjLst_Cache({1});", objPrjTabENEx.TabName,
                    objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}_Sel = arr{0}ObjLst_Cache;", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "if (obj{0}_Sim.sf_FldComparisonOp == null || obj{0}_Sim.sf_FldComparisonOp == \"\") return arr{0}_Sel.length;", objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "const dicFldComparisonOp = JSON.parse(obj{0}_Sim.sf_FldComparisonOp);", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "//console.log(\"cls{0}WApi->GetSubObjLst_Cache->dicFldComparisonOp:\");", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "//console.log(dicFldComparisonOp);", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "try {");
            strCodeForCs.AppendFormat("\r\n" + "const sstrKeys = {1}.GetObjKeys(obj{0}_Sim);", objPrjTabENEx.TabName,
                           ImportClass.GetOutString(string.Format("clsCommFunc4Web", objPrjTabENEx.TabName), this.Is4RJ));
            strCodeForCs.Append("\r\n" + "//console.log(sstrKeys);");

            strCodeForCs.Append("\r\n" + "for (const strKey of sstrKeys) {");
            strCodeForCs.Append("\r\n" + "if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false) continue;");
            strCodeForCs.Append("\r\n" + "const strComparisonOp = dicFldComparisonOp[strKey];");

            strCodeForCs.AppendFormat("\r\n" + "const strValue = obj{0}_Cond.GetFldValue(strKey);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "const strType = typeof(strValue);");
            strCodeForCs.Append("\r\n" + "switch (strType) {");
            strCodeForCs.Append("\r\n" + "case \"string\":");
            strCodeForCs.Append("\r\n" + "if (strValue == null) continue;");
            strCodeForCs.Append("\r\n" + "if (strValue == \"\") continue;");
            strCodeForCs.Append("\r\n" + "if (strComparisonOp == \"=\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}_Sel = arr{0}_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"like\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}_Sel = arr{0}_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "break;");

            strCodeForCs.Append("\r\n" + "case \"boolean\":");
            strCodeForCs.Append("\r\n" + "if (strValue == null) continue;");

            strCodeForCs.Append("\r\n" + "if (strComparisonOp == \"=\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}_Sel = arr{0}_Sel.filter(x => x.GetFldValue(strKey) == strValue);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
 strCodeForCs.Append("\r\n" + "break;");

            strCodeForCs.Append("\r\n" + "case \"number\":");
            strCodeForCs.Append("\r\n" + "if (Number(strValue) == 0) continue;");
            strCodeForCs.Append("\r\n" + "if (strComparisonOp == \"=\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}_Sel = arr{0}_Sel.filter(x => x.GetFldValue(strKey) == strValue);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \">=\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}_Sel = arr{0}_Sel.filter(x => x.GetFldValue(strKey) >= strValue);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"<=\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}_Sel = arr{0}_Sel.filter(x => x.GetFldValue(strKey) <= strValue);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \">\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}_Sel = arr{0}_Sel.filter(x => x.GetFldValue(strKey) > strValue);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strComparisonOp == \"<\") {");
            strCodeForCs.AppendFormat("\r\n" + "arr{0}_Sel = arr{0}_Sel.filter(x => x.GetFldValue(strKey) <= strValue);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "break;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "return arr{0}_Sel.length;", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e) {");
            strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"��������:[\" +JSON.stringify( obj{0}_Sim) + \"]��ȡ��Ӧ�Ķ��󲻳ɹ�!\";", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "throw new Error(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "return 0;", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "}");

            //���ݹؼ��ֻ�ȡ��ض���, �ӻ���Ķ����б��л�ȡ. == = ;
            return strCodeForCs.ToString();
        }


        public string Gen_4WA_Js_ClassConstructor1Bak()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            ///�๹����----------------------------------------------;
            strCodeForCs.Append("\r\n public " + objPrjTabENEx.ClsName + "()");
            strCodeForCs.Append("\r\n {");

            strCodeForCs.Append("\r\n }");
            return strCodeForCs.ToString();
        }
        public string Gen_4WA_Js_ComboBoxBindFunctionBak()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            string strTextFieldName = "";
            string strValueFieldName = "";

            try
            {
                //��0��:�ѿؼ���������ComboBoxת����ComboBox
                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.FieldTypeId == "02")
                    {
                        strValueFieldName = objField.ObjFieldTabENEx.FldName;
                    }
                    if (objField.FieldTypeId == "03")
                    {
                        strTextFieldName = objField.ObjFieldTabENEx.FldName;
                    }
                }
                if (strValueFieldName != "" && strTextFieldName != "")
                {     
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// �󶨻���Win��������");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.Append("\r\n /// <param name=\"objComboBox\">��Ҫ�󶨵�ǰ���������</param>");
                    strCodeForCs.AppendFormat("\r\n" + "{1}.BindCbo_{0} = function(System.Windows.Forms.ComboBox objComboBox)",
                            strValueFieldName, objPrjTabENEx.ClsName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//Ϊ����ԴΪ�����������������");
                    strCodeForCs.AppendFormat("\r\n" + "Array<{1}> arrObjLst = GetObjLst(\"1=1\");",
                    objPrjTabENEx.TabName,
                           ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));


                    strCodeForCs.AppendFormat("\r\n" + "{1} obj{0}EN;",
                    objPrjTabENEx.TabName,
                           ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));
                    strCodeForCs.AppendFormat("\r\n" + "//��ʼ��һ�������б�");
                    //strCodeForCs.AppendFormat("\r\n" + "ArrayList {0}List = new ArrayList();",
                    //objPrjTabENEx.TabName);
                    strCodeForCs.Append("\r\n" + "//�����0��ڵ�0���в��롰��ѡ��...��,Ϊ�˷����û�,��WEB��ʽ���ơ�");
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = new {1}();",
                    objPrjTabENEx.TabName,
                           ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = \"0\";",
                    objPrjTabENEx.TabName, strValueFieldName);

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

        public string Gen_4WA_Js_DdlBind_Cache()
        {
            string strFuncName = "";
            string strTextFieldName = "";
            string strValueFieldName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;


                foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
                {
                    if (objField.FieldTypeId == "02")
                    {
                        strValueFieldName = objField.ObjFieldTabENEx.FldName;
                    }
                    if (objField.FieldTypeId == "03")
                    {
                        strTextFieldName = objField.ObjFieldTabENEx.FldName;
                    }
                }
                if (string.IsNullOrEmpty(strTextFieldName) == true) return "";

                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.AppendFormat("\r\n" + "/// Ϊ�������ȡ����,�ӱ�:[{0}]�л�ȡ",
                  objPrjTabENEx.TabName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>");
                strCodeForCs.Append("\r\n" + "/// <returns>��ȡ�����ֶΡ������ֶ����е����м�¼��¼��DataTable</returns>");
                if (objPrjTabENEx.objCacheClassifyFld == null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "{3}.BindDdl_{1}_Cache2 = function(strDdlName, obj{0}_Cond) {{",
                        objPrjTabENEx.TabName, 
                        strValueFieldName, 
                        strTextFieldName, 
                        objPrjTabENEx.ClsName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "{5}.BindDdl_{1}_Cache2 = function(strDdlName, obj{0}_Cond, {3}) {{",
                        objPrjTabENEx.TabName, 
                        strValueFieldName, 
                        strTextFieldName, 
                        objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                        objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType, 
                        objPrjTabENEx.ClsName);
                }
                strCodeForCs.Append("\r\n" + "//let strWhereCond = \" 1 =1 \";");
                strCodeForCs.AppendFormat("\r\n" + "const objDdl = document.getElementById(strDdlName);",
                    objPrjTabENEx.TabName, strValueFieldName, strTextFieldName);
                strCodeForCs.Append("\r\n" + "if (objDdl == null)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"������\" + strDdlName  + \" �����ڣ�\";",
                    objPrjTabENEx.TabName, strValueFieldName, strTextFieldName);
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                strCodeForCs.Append("\r\n" + "throw (strMsg);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return new Promise((resolve, reject) => {");

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                if (objPrjTabENEx.objCacheClassifyFld == null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const arrObjLst_Sel = {0}_GetSubObjLst_Cache(obj{0}_Cond);", objPrjTabENEx.TabName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const arrObjLst_Sel = {0}_GetSubObjLst_Cache(obj{0}_Cond,{1});", 
                        objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName);

                }
                //this.BindTab_{0}(strListDiv, arr{0}ObjLst);
                strCodeForCs.AppendFormat("\r\n" + "{5}.BindDdl_ObjLst(strDdlName, arrObjLst_Sel, {4}.con_{1}, {4}.con_{2}, \"{3}\");",
                                objPrjTabENEx.TabName, 
                                strValueFieldName, 
                                strTextFieldName, 
                                objPrjTabENEx.TabCnName,
                           ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ),
                           ImportClass.GetOutString(string.Format("clsCommFunc4Web", objPrjTabENEx.TabName), this.Is4RJ));
                strCodeForCs.AppendFormat("\r\n" + "//console.log(\"���BindDdl_{0}!\");", strValueFieldName);

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = \"ʹ�û�������б�����������,\" +e + \".\";");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "});");
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

        public string Gen_4WA_Js_DdlBindFunctionBak()
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
                        strValueFieldName = objField.ObjFieldTabENEx.FldName;
                    }
                    if (objField.FieldTypeId == "03")
                    {
                        strTextFieldName = objField.ObjFieldTabENEx.FldName;
                    }
                }
                if (strValueFieldName != "" && strTextFieldName != "")
                {
                    
                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.Append("\r\n /// �󶨻���Web��������");
                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.Append("\r\n /// <param name=\"objDDL\">��Ҫ�󶨵�ǰ���������</param>");
                    strCodeForCs.AppendFormat("\r\n" + "{1}.BindDdl_{0} = function(System.Web.UI.WebControls.DropDownList objDDL)",
                            strValueFieldName, 
                            objPrjTabENEx.ClsName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "//Ϊ����Դ�ڱ����������������");

                    strCodeForCs.AppendFormat("\r\n" + "System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem(\"ѡ[{0}]...\",\"0\");",
                          objPrjTabENEx.TabCnName);

                    strCodeForCs.AppendFormat("\r\n" + "Array<{1}> arrObjLst = GetObjLst(\"1=1\");",
                        objPrjTabENEx.TabName,
                           ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));

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
        public string GeneCode4FunctionFromTs(string strFuncId4GC)
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; //��ʱ����;
            string strFuncName = "";
            try
            {
                //������ʼ
                clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GC_CacheEx(strFuncId4GC);
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

        /// <summary>
        /// ����ָ���ĺ���
        /// </summary>
        /// <returns>�������ɵ�ָ����������</returns>
        public string A_GenCode4Function_Java1(string strFuncId4GC)
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; //��ʱ����;
            string strFuncName = "";
            try
            {
                //������ʼ
                clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GC_CacheEx(strFuncId4GC);
                strFuncName = objvFunction4GeneCodeEN.FuncName;

                if (objvFunction4GeneCodeEN.FuncTypeId == "10")//�û��Զ��庯��
                {
                    strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objvFunction4GeneCodeEN.FuncId4GC,
                        objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
                }
                else
                {
                    switch (objvFunction4GeneCodeEN.ProgLangTypeId)
                    {
                        case "02":
                            strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                            break;
                        default:
                            strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                            break;

                    }
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

        /// <summary>
        /// ����ָ���ĺ���
        /// </summary>
        /// <returns>�������ɵ�ָ����������</returns>
        public string A_GenCode4Function_Swift41(string strFuncId4GC)
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; //��ʱ����;
            string strFuncName = "";
            try
            {
                //������ʼ
                clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GC_CacheEx(strFuncId4GC);
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

        /// <summary>
        /// ����ָ���ĺ���
        /// </summary>
        /// <returns>�������ɵ�ָ����������</returns>
        public string A_GenCode4Function_JavaScript1(string strFuncId4GC)
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; //��ʱ����;
            string strFuncName = "";
            try
            {
                //������ʼ
                clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GC_CacheEx(strFuncId4GC);
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

        /// <summary>
        /// ����ָ���ĺ���
        /// </summary>
        /// <returns>�������ɵ�ָ����������</returns>
        public string A_GenCode4Function_SilverLight1(string strFuncId4GC)
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; //��ʱ����;
            string strFuncName = "";
            try
            {
                //������ʼ
                clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GC_CacheEx(strFuncId4GC);
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


        //public override void GetClsName()
        //{
        //    this.ClsName = string.Format("cls{0}WApi", objPrjTabENEx.TabName);
        //    objPrjTabENEx.ClsName = this.ClsName;
        //}
        public string A_GeneFuncCodeFromTs(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(WA_Access4JavaScript);
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
        public string Gen_4WA_TabFeature_DdlBindFunction()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
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
                    if (objTabFeature_BindDdl.arrTabFeatureFldsSet().Exists(x => x.FieldTypeId == enumFieldType.NameField_03) == false)
                    {
                        throw new Exception("��ǰ��û�������ֶΣ�������Ӱ��������ܣ�");
                    }
                    if (objTabFeature_BindDdl.arrTabFeatureFldsSet().Exists(x => x.FieldTypeId == enumFieldType.KeyField_02) == false)
                    {
                        throw new Exception("��ǰ��û�йؼ��ֶΣ�������Ӱ��������ܣ�");
                    }
                    clsTabFeatureFldsEN objField_Key = objTabFeature_BindDdl.arrTabFeatureFldsSet().Find(x => x.FieldTypeId == enumFieldType.KeyField_02);
                    clsTabFeatureFldsEN objField_Name = objTabFeature_BindDdl.arrTabFeatureFldsSet().Find(x => x.FieldTypeId == enumFieldType.NameField_03);
                    clsTabFeatureFldsEN objField_OrderNum = objTabFeature_BindDdl.arrTabFeatureFldsSet().Find(x => x.FieldTypeId == enumFieldType.OrderNumField_09);
                    string strTextFieldName = objField_Name.ObjFieldTab().FldName;
                    string strValueFieldName = objField_Key.ObjFieldTab().FldName;
                    //��0��:�ѿؼ���������ComboBoxת����ComboBox

                    if (strValueFieldName != "" && strTextFieldName != "")
                    {

                        strCodeForCs.Append("\r\n /// <summary>");
                        strCodeForCs.Append("\r\n /// �󶨻���Web��������");
                        strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n /// </summary>");
                        IEnumerable<clsTabFeatureFldsEN> arrField_Condition = objTabFeature_BindDdl.arrTabFeatureFldsSet().Where(x => x.FieldTypeId == enumFieldType.ConditionField_16);
                        strCodeForCs.Append("\r\n /// <param name = \"objDDL\">��Ҫ�󶨵�ǰ���������</param>");
                        foreach (clsTabFeatureFldsEN objInFor in arrField_Condition)
                        {
                            if (objInFor.ValueGivingModeId == enumValueGivingMode.DefaultValue_01) continue;
                            strCodeForCs.AppendFormat("\r\n /// <param name = \"{0}\">{1}</param>", objInFor.ObjFieldTab().PrivFuncName1(), objInFor.ObjFieldTab().Caption);
                        }
                        StringBuilder sbFuncPara = new StringBuilder();
                        List<string> arrPrivFuncName_Additional = new List<string>();
                        foreach (clsTabFeatureFldsEN objInFor in arrField_Condition)
                        {
                            if (objInFor.ValueGivingModeId == enumValueGivingMode.DefaultValue_01) continue;
                            arrPrivFuncName_Additional.Contains(objInFor.ObjFieldTab().PrivFuncName1());
                            sbFuncPara.AppendFormat(", {0}", objInFor.ObjFieldTab().PrivFuncName1(), objInFor.ObjFieldTab().ObjDataTypeAbbr1().CsType);

                        }
                        if (objPrjTabENEx.objCacheClassifyFld == null)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "{3}.{0}_Cache = async function(strDdlName, obj{1}_Cond)",
                                    objTabFeature_BindDdl.FuncName_Js,
                                    objPrjTabENEx.TabName,
                                    sbFuncPara.ToString(),
                                    objPrjTabENEx.ClsName);
                        }
                        else
                        {
                            if (arrPrivFuncName_Additional.Contains(objPrjTabENEx.objCacheClassifyFld.PrivFuncName) == true)
                            {
                                strCodeForCs.AppendFormat("\r\n" + "{3}.{0}_Cache = async function(strDdlName, obj{1}_Cond, {4})",
                                        objTabFeature_BindDdl.FuncName_Js,
                                        objPrjTabENEx.TabName,
                                        sbFuncPara.ToString(),
                                        objPrjTabENEx.ClsName,
                                             objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "{5}.{0}_Cache = async function(strDdlName, obj{1}_Cond, {2})",
                                        objTabFeature_BindDdl.FuncName_Js,
                                        objPrjTabENEx.TabName,
                                        objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                                        objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
                                        sbFuncPara.ToString(),
                                        objPrjTabENEx.ClsName);
                            }
                        }
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "const objDdl = document.getElementById(strDdlName);",
        objPrjTabENEx.TabName, strValueFieldName, strTextFieldName);
                        strCodeForCs.Append("\r\n" + "if (objDdl == null)");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"������\" + strDdlName  + \" �����ڣ�\";",
                            objPrjTabENEx.TabName, strValueFieldName, strTextFieldName);
                        strCodeForCs.Append("\r\n" + "alert(strMsg);");
                        strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                        strCodeForCs.Append("\r\n" + "throw (strMsg);");
                        strCodeForCs.Append("\r\n" + "}");

                        strCodeForCs.Append("\r\n" + "//Ϊ����Դ�ڱ����������������");
                        strCodeForCs.AppendFormat("\r\n" + "//console.log(\"��ʼ��{0}_Cache\");", objTabFeature_BindDdl.FuncName_Js);

                        if (objPrjTabENEx.objCacheClassifyFld == null)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "const arrObjLst_Sel = await {0}_GetSubObjLst_Cache(obj{0}_Cond);", objPrjTabENEx.TabName);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "const arrObjLst_Sel = await {0}_GetSubObjLst_Cache(obj{0}_Cond, {1});",
                                objPrjTabENEx.TabName,
                                objPrjTabENEx.objCacheClassifyFld.PrivFuncName);

                        }

                        if (objTabFeature_BindDdl.arrTabFeatureFldsSet().Exists(x => x.FieldTypeId == enumFieldType.SortField_06) == true)
                        {
                            clsTabFeatureFldsEN objField_Sort = objTabFeature_BindDdl.arrTabFeatureFldsSet().Find(x => x.FieldTypeId == enumFieldType.SortField_06);

                            strCodeForCs.AppendFormat("\r\n" + "arrObjLst_Sel = arrObjLst_Sel.sort(x => x[{2}.con_{1}]);",
                                 objPrjTabENEx.TabName, objField_Sort.ObjFieldTab().FldName,
                                ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ));
                        }
                        if (arrField_Condition.Count() > 0)
                        {
                            StringBuilder sbCondition = new StringBuilder();
                            sbCondition.Append("x=>");
                            bool bolIsFirst = true;
                            foreach (clsTabFeatureFldsEN objInFor in arrField_Condition)
                            {
                                string strValue = "";
                                if (objInFor.ValueGivingModeId == enumValueGivingMode.DefaultValue_01)
                                {
                                    switch (objInFor.ObjFieldTab().ObjDataTypeAbbr1().CsType)
                                    {
                                        case "bool":
                                            if (objInFor.DefaultValue == "1")
                                            {
                                                strValue = "true";
                                            }
                                            else if (objInFor.DefaultValue == "0")
                                            {
                                                strValue = "false";
                                            }
                                            else
                                            {
                                                bool bolValue = bool.Parse(objInFor.DefaultValue);
                                                strValue = bolValue ? "true" : "false";
                                            }
                                            break;
                                        case "string":
                                            strValue = string.Format("\"{0}\"", objInFor.DefaultValue);
                                            break;
                                        case "int":
                                        case "bigint":
                                        case "short":
                                            strValue = string.Format("{0}", objInFor.DefaultValue);
                                            break;

                                        default:
                                            strValue = string.Format("\"{0}\"", objInFor.DefaultValue);
                                            break;
                                    }
                                }
                                else
                                {
                                    strValue = string.Format("{0}", objInFor.ObjFieldTab().PrivFuncName1());
                                }
                                if (bolIsFirst)
                                {
                                    sbCondition.AppendFormat("x.{0} == {1}",
                                         objInFor.ObjFieldTab().PropertyName(),
                                         strValue);
                                    bolIsFirst = false;
                                }
                                else
                                {
                                    sbCondition.AppendFormat("&& x.{0} == {1}",
                                         objInFor.ObjFieldTab().PropertyName(),
                                         strValue);
                                }
                            }
                            strCodeForCs.AppendFormat("\r\n" + "arrObjLst_Sel = arrObjLst_Sel.filter({1});",
                                objPrjTabENEx.TabName, sbCondition.ToString());
                        }
                        strCodeForCs.AppendFormat("\r\n" + "{5}.BindDdl_ObjLst(strDdlName, arrObjLst_Sel, {4}.con_{1}, {4}.con_{2}, \"{3}\");",
                                        objPrjTabENEx.TabName,
                                        strValueFieldName,
                                        strTextFieldName,
                                        objPrjTabENEx.TabCnName,
                                        ImportClass.GetOutString(string.Format("cls{0}EN", objPrjTabENEx.TabName), this.Is4RJ),
                                        ImportClass.GetOutString(string.Format("clsCommFunc4Web", objPrjTabENEx.TabName), this.Is4RJ));

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


    }
}
