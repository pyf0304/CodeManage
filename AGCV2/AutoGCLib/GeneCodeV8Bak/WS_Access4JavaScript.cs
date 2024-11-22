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
    partial class WS_Access4JavaScript : clsGeneCodeBase
    {

        #region ���캯��

        public WS_Access4JavaScript()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }
        public WS_Access4JavaScript(string strPrjId)
          : base(strPrjId)
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }
        public WS_Access4JavaScript(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
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
            StringBuilder strBuilder = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; ///��ʱ����;

            objPrjTabENEx.ClsName = "js" + objPrjTabENEx.TabName + "WS";
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".js";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcId_Cache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName, objPrjTabENEx.SimpleFileName);

            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".js";
            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjId_Cache(objPrjTabENEx.PrjId); //
            try
            {
                //������ʼ

                strBuilder.Append(clsPubFun4GC.GenUserInfoAndDate(objPrjTabENEx.UserId, objPrjTabENEx));

                strBuilder.Append("\r\n" + ""); //

                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// {0}({1})", objPrjTabENEx.TabCnName, objPrjTabENEx.TabName);

                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.Append("\r\n" + "/**");
                strBuilder.AppendFormat("\r\n" + "* Created by {0} on {1}.", objPrjTabENEx.UserId, clsDateTime.getTodayStr(3));
                strBuilder.AppendFormat("\r\n" + "* ע��:�����������ý��洦��ͬһ������������ò��ɹ�!", objPrjTabENEx.UserId, clsDateTime.getTodayStr(3));
                strBuilder.Append("\r\n" + "*/");
                strBuilder.Append("\r\n" + "/// <reference path=\"../PubFun/tzDictionary.js\" />");
                strBuilder.Append("\r\n" + "/// <reference path=\"../PubFun/tzResponseData.js\" />");
                strBuilder.Append("\r\n" + "/// <reference path=\"../PubFun/tzStringFormat.js\" />");
                strBuilder.Append("\r\n" + "/// <reference path=\"../PubFun/tzGetXmlHttp.js\" />");
                strBuilder.Append("\r\n" + "/// <reference path=\"../PubFun/jsPubVar.js\" />");
                strBuilder.Append("\r\n" + "const VirtualRootPath = getVirtualRootPath_web();//�ú���������/js/PubFun/jsPubFun.js�ļ���");

                strBuilder.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/tzDictionary.js\");");
                strBuilder.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/tzResponseData.js\");");
                strBuilder.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/tzGetXmlHttp.js\");");
                strBuilder.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/jsPubFun.js\");");
                strBuilder.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/jsPubVar.js\");");

                strBuilder.AppendFormat("\r\n" + "include(VirtualRootPath + \"/js/{1}/js{0}EN.js\");",
                    objPrjTabENEx.TabName,
                    objPrjTabENEx.ObjFuncModule.FuncModuleEnName);

                strBuilder.Append("\r\n" + "const ResponseData;");
                strBuilder.Append("\r\n" + "const ReCallFunc = null;");
                
                strBuilder.AppendFormat("\r\n" + "const cls{0}WS = function()",
                  objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "{");

                strBuilder.Append("\r\n" + "const Param;");
                strBuilder.Append("\r\n" + "const NameSpace = \"http://tempuri.org/\";");
                strBuilder.Append("\r\n" + "const MethodName = \"\";");
                strBuilder.Append("\r\n" + "const WEB_SERVICE_URL = \"\";");
                strBuilder.Append("\r\n" + "const soapAction = \"\";");

                strBuilder.AppendFormat("\r\n" + "const obj{0}EN;",
                      objPrjTabENEx.TabName);
                //˽��������-----�����Թ���

                //˽��������-----�����Թ���

                strBuilder.Append("\r\n" + "this.init = function()");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "this.Param = new Dictionary();");
                strBuilder.AppendFormat("\r\n" + "this.obj{0}EN = new cls{0}EN();",
                     objPrjTabENEx.TabName);
                strBuilder.AppendFormat("\r\n" + "ResponseData = new tzResponseData();",
                    objPrjTabENEx.TabName);

                strBuilder.Append("\r\n" + "};");

                strBuilder.AppendFormat("\r\n" + "this.init = function(strMethod, mapParam, pobj{0}EN, pReCallFunc)",
                  objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "Param = new Dictionary();");
                //strBuilder.Append("\r\n" + "obj{0}EN = new cls{0}EN();");
                //strBuilder.Append("\r\n" + "this.currentElementValue = \"\";");
                strBuilder.AppendFormat("\r\n" + "this.obj{0}EN = pobj{0}EN;",
                objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "ReCallFunc = pReCallFunc;");
                strBuilder.AppendFormat("\r\n" + "ResponseData = new tzResponseData();",
                     objPrjTabENEx.TabName);

                strBuilder.Append("\r\n" + "this.MethodName = strMethod;");
                strBuilder.Append("\r\n" + "this.Param = mapParam;");
                strBuilder.Append("\r\n" + "if (this.Param.length() === 0)");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "this.Param = new Dictionary();");
                strBuilder.Append("\r\n" + "}");

                strBuilder.AppendFormat("\r\n" + "this.WEB_SERVICE_URL = String.format(\"{{0}}/{{1}}/{3}/{0}Service.asmx\", CurrIPAddressAndPort, CurrPrx);",
                  objPrjTabENEx.TabName,  "{", "}", objPrjTabENEx.ObjFuncModule.FuncModuleEnName);

                //this.WEB_SERVICE_URL = String.format("{0}/{1}/MyTest1Service.asmx", CurrIPAddressAndPort, CurrPrx);

                strBuilder.Append("\r\n" + "};");
                //�������еĺ���

                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                  clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId,
                  objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId);

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    string strFuncName = objvFunction4GeneCodeEN.FuncName;

                    strTemp = A_GeneFuncCode_JavaScript(strFuncName);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strBuilder.Append("\r\n" + strTemp);
                    }
                }
                
                strBuilder.Append("\r\n" + "};");
                
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strBuilder.ToString();
        }

        /// <summary>
        /// ����Web Serviceת�������
        /// </summary>
        /// <returns></returns>
        public string A_GenWebServiceTransCode_JavaScript_SelfDefWs(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
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
            StringBuilder strBuilder = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; ///��ʱ����;

            objWebSrvClassENEx.ClsName = "js" + objWebSrvClassENEx.ClassName + "WS4SD";
            //objWebSrvClassENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objWebSrvClassENEx.SimpleFileName = objWebSrvClassENEx.ClsName + ".js";
            strRe_ClsName = objWebSrvClassENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcId_Cache(objWebSrvClassENEx.FuncModuleAgcId, objWebSrvClassENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName, objWebSrvClassENEx.SimpleFileName);

            strClassFName = objWebSrvClassENEx.FolderName + objWebSrvClassENEx.ClsName + ".js";
            objWebSrvClassENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjId_Cache(objWebSrvClassENEx.PrjId); //
            try
            {
                //������ʼ

                strBuilder.Append(clsPubFun4GC.GenUserInfoAndDate(objWebSrvClassENEx.CurrUserName, objWebSrvClassENEx));

                strBuilder.Append("\r\n" + ""); //

                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// {0}({1})", objWebSrvClassENEx.ClassName, objWebSrvClassENEx.ClassName);

                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.Append("\r\n" + "/**");
                strBuilder.AppendFormat("\r\n" + "* Created by {0} on {1}.", objWebSrvClassENEx.CurrUserName, clsDateTime.getTodayStr(3));
                strBuilder.AppendFormat("\r\n" + "* ע��:�����������ý��洦��ͬһ������������ò��ɹ�!", objWebSrvClassENEx.CurrUserName, clsDateTime.getTodayStr(3));
                strBuilder.Append("\r\n" + "*/");
                strBuilder.Append("\r\n" + "/// <reference path=\"../PubFun/tzDictionary.js\" />");
                strBuilder.Append("\r\n" + "/// <reference path=\"../PubFun/tzResponseData.js\" />");
                strBuilder.Append("\r\n" + "/// <reference path=\"../PubFun/tzStringFormat.js\" />");
                strBuilder.Append("\r\n" + "/// <reference path=\"../PubFun/tzGetXmlHttp.js\" />");
                strBuilder.Append("\r\n" + "/// <reference path=\"../PubFun/jsPubVar.js\" />");
                strBuilder.Append("\r\n" + "const VirtualRootPath = getVirtualRootPath_web();//�ú���������/js/PubFun/jsPubFun.js�ļ���");

                strBuilder.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/tzDictionary.js\");");
                strBuilder.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/tzResponseData.js\");");
                strBuilder.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/tzGetXmlHttp.js\");");
                strBuilder.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/jsPubFun.js\");");
                strBuilder.Append("\r\n" + "include(VirtualRootPath + \"/js/PubFun/jsPubVar.js\");");

                //strBuilder.AppendFormat("\r\n" + "include(VirtualRootPath + \"/js/{1}/js{0}EN.js\");",
                //    objWebSrvClassENEx.ClassName,
                //    objWebSrvClassENEx.ObjFuncModule.FuncModuleEnName);

                strBuilder.Append("\r\n" + "const ResponseData;");
                strBuilder.Append("\r\n" + "const ReCallFunc = null;");

                strBuilder.AppendFormat("\r\n" + "const cls{0}WS4SD = function()",
                  objWebSrvClassENEx.ClassName);
                strBuilder.Append("\r\n" + "{");

                strBuilder.Append("\r\n" + "const Param;");
                strBuilder.Append("\r\n" + "const NameSpace = \"http://tempuri.org/\";");
                strBuilder.Append("\r\n" + "const MethodName = \"\";");
                strBuilder.Append("\r\n" + "const WEB_SERVICE_URL = \"\";");
                strBuilder.Append("\r\n" + "const soapAction = \"\";");

                //strBuilder.AppendFormat("\r\n" + "const obj{0}EN;",
                //      objWebSrvClassENEx.ClassName);
                //˽��������-----�����Թ���

                //˽��������-----�����Թ���

                strBuilder.Append("\r\n" + "this.init = function()");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "this.Param = new Dictionary();");
                //strBuilder.AppendFormat("\r\n" + "this.obj{0}EN = new cls{0}EN();",
                //     objWebSrvClassENEx.ClassName);
                strBuilder.AppendFormat("\r\n" + "ResponseData = new tzResponseData();",
                    objWebSrvClassENEx.ClassName);

                strBuilder.Append("\r\n" + "};");

                strBuilder.AppendFormat("\r\n" + "this.init = function(strMethod, mapParam, pobj{0}EN, pReCallFunc)",
                  objWebSrvClassENEx.ClassName);
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "Param = new Dictionary();");
                //strBuilder.Append("\r\n" + "obj{0}EN = new cls{0}EN();");
                //strBuilder.Append("\r\n" + "this.currentElementValue = \"\";");
                //strBuilder.AppendFormat("\r\n" + "this.obj{0}EN = pobj{0}EN;",
                //objWebSrvClassENEx.ClassName);
                strBuilder.Append("\r\n" + "ReCallFunc = pReCallFunc;");
                strBuilder.AppendFormat("\r\n" + "ResponseData = new tzResponseData();",
                     objWebSrvClassENEx.ClassName);

                strBuilder.Append("\r\n" + "this.MethodName = strMethod;");
                strBuilder.Append("\r\n" + "this.Param = mapParam;");
                strBuilder.Append("\r\n" + "if (this.Param.length() === 0)");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "this.Param = new Dictionary();");
                strBuilder.Append("\r\n" + "}");

                strBuilder.AppendFormat("\r\n" + "this.WEB_SERVICE_URL = String.format(\"{{0}}/{{1}}/{3}/{0}.asmx\", CurrIPAddressAndPort, CurrPrx);",
                  objWebSrvClassENEx.ClassName, "{", "}", objWebSrvClassENEx.ObjFuncModule.FuncModuleEnName);

                //this.WEB_SERVICE_URL = String.format("{0}/{1}/MyTest1Service.asmx", CurrIPAddressAndPort, CurrPrx);

                strBuilder.Append("\r\n" + "};");
                //�������еĺ���
                strTemp = A_GeneFuncCode_JavaScript("Gen_4Ws_main_JavaScript_SelfDefWs");
                strBuilder.Append("\r\n" + strTemp);

                foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
                {
                    if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                    try
                    {
                        strTemp = Gen_4Ws_ByCommonFunction_JavaScript(objWebSrvFunctionsENEx);
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
                strTemp = A_GeneFuncCode_JavaScript("Gen_4Ws_CallWebService_JavaScript_SelfDefWs");
                strBuilder.Append("\r\n" + strTemp);
                strTemp = A_GeneFuncCode_JavaScript("Gen_4Ws_getReturnValue_JavaScript");
                strBuilder.Append("\r\n" + strTemp);
                //foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                //{
                //    string strFuncName = objvFunction4GeneCodeEN.FuncName;

                //    strTemp = A_GeneFuncCode(strFuncName);
                //    if (string.IsNullOrEmpty(strTemp) == false)
                //    {
                //        strBuilder.Append("\r\n" + strTemp);
                //    }
                //}

                strBuilder.Append("\r\n" + "};");

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strBuilder.ToString();
        }
        public string A_GeneFuncCode_JavaScript(string strFuncName)
        {
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

        /// <summary>
        /// ����WebService����Ӽ�¼�����ݴ���ʹ��JSON��
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_AddNewRecordByJSON_S_JavaScript()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����WebService����Ӽ�¼�����ݴ���ʹ��JSON��");
            strBuilder.AppendFormat("\r\n /// mapParam����:��", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n ///��������:��1:cls{0}WS obj{0}WS = new cls{0}WS(mHandler, \"AddNewRecordByJSON\", values, obj{0}EN);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///��������:��2:Thread mThread = new Thread(obj{0}WS);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///��������:��3:mThread.start();");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">�����б�</param>");
            strBuilder.Append("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵĶ���</param>");
            strBuilder.Append("\r\n /// <returns>��ȡ��Ӧ�ļ�¼�Ķ���</returns>");
            strBuilder.AppendFormat("\r\n" + "this.AddNewRecordByJSON = function(mapParam, obj{0}EN) ",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "let strMsg = \"\";");

            strBuilder.AppendFormat("\r\n" + "const strMethodName = \"{0}_AddNewRecordBySql2ByJSON\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);

            strBuilder.AppendFormat("\r\n" + "if (obj{0}EN.get{1}() === null || obj{0}EN.get{1}() === \"\")",
                 objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strMsg = String.format(\"��Ҫ�Ķ���Ĺؼ���Ϊ�գ��������!\");");
            strBuilder.Append("\r\n" + "throw strMsg;");
            strBuilder.Append("\r\n" + "}");

            strBuilder.AppendFormat("\r\n" + "const strJSON = obj{0}BL.GetJSONStrByObj(obj{0}EN);",
              objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + " //var strJSON = JSON.stringify(obj{0}EN);",
           objPrjTabENEx.TabName);
            //var strJSON = JSON.stringify(objMyTest1EN);
            strBuilder.AppendFormat("\r\n" + "mapParam.add(\"str{0}JSONObj\", strJSON);",
              objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "this.CallWebService(strMethodName, mapParam, this.WEB_SERVICE_URL);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strMsg = \"�ڵ���WebService����ʱ����������Ϣ��\\(String(describing: objException.reason))\";");
            strBuilder.Append("\r\n" + "throw strMsg;");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "};");

            return strBuilder.ToString();
        }

        /// <summary>
        /// ����WebService���޸ļ�¼�����ݴ���ʹ��JSON��
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_UpdateRecordByJSON_S_JavaScript()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����WebService���޸ļ�¼�����ݴ���ʹ��JSON��");
            strBuilder.AppendFormat("\r\n /// mapParam����:��", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n ///��������:��1:cls{0}WS obj{0}WS = new cls{0}WS(mHandler, \"UpdateRecordByJSON\", values, obj{0}EN);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///��������:��2:Thread mThread = new Thread(obj{0}WS);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///��������:��3:mThread.start();");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">�����б�</param>");
            strBuilder.Append("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵĶ���</param>");
            strBuilder.Append("\r\n /// <returns>��ȡ��Ӧ�ļ�¼�Ķ���</returns>");
            strBuilder.AppendFormat("\r\n" + "this.UpdateRecordByJSON = function(mapParam, obj{0}EN) ",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "let strMsg = \"\";");

            strBuilder.AppendFormat("\r\n" + "const strMethodName = \"{0}_UpdateBySql2ByJSON\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);


            strBuilder.AppendFormat("\r\n" + "const strJSON = obj{0}BL.GetJSONStrByObj(obj{0}EN);",
              objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + " if (obj{0}EN.sf_UpdFldSetStr === undefined || obj{0}EN.sf_UpdFldSetStr === null || obj{0}EN.sf_UpdFldSetStr === \"\")",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "strMsg = String.format(\"����(�ؼ��֣�{{0}})�ġ��޸��ֶμ���Ϊ�գ������޸�!\", obj{0}EN.get{1}());",
                objPrjTabENEx.TabName, objKeyField.FldName_FstUcase, "{", "}");
            strBuilder.Append("\r\n" + " throw strMsg;");
            strBuilder.Append("\r\n" + " }");
            strBuilder.AppendFormat("\r\n" + "mapParam.add(\"str{0}JSONObj\", strJSON);",
              objPrjTabENEx.TabName);

            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "this.CallWebService(strMethodName, mapParam, this.WEB_SERVICE_URL);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "strMsg = \"�ڵ���WebService����ʱ����������Ϣ��\\(String(describing: objException.reason))\";");
            strBuilder.Append("\r\n" + "throw strMsg;");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "};");

            return strBuilder.ToString();
        }



        /// <summary>
        /// ����WebService��ɾ����¼
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_DelRecord_S_JavaScript()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����WebService��ɾ����¼");
            strBuilder.AppendFormat("\r\n /// mapParam����:{0} = \"01\"", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n ///��������:��1:cls{0}WS obj{0}WS = new cls{0}WS(mHandler, \"DelRecord\", values, null);",
                 objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///��������:��2:Thread mThread = new Thread(obj{0}WS);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///��������:��3:mThread.start();");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">�����б�</param>");
            strBuilder.Append("\r\n /// <param name = \"obj{0}EN\">��Ҫ��ӵĶ���</param>");
            strBuilder.Append("\r\n /// <returns>��ȡ��Ӧ�ļ�¼�Ķ���</returns>");
            strBuilder.AppendFormat("\r\n" + "this.DelRecord = function( mapParam) ",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");

            strBuilder.AppendFormat("\r\n" + "const strMethodName = \"{0}_DelRecord\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "this.CallWebService(strMethodName, mapParam, this.WEB_SERVICE_URL);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strMsg = \"�ڵ���WebService����ʱ����������Ϣ��\\(String(describing: objException.reason))\";");
            strBuilder.Append("\r\n" + "throw strMsg;");
            strBuilder.Append("\r\n" + "}");
            
            strBuilder.Append("\r\n" + "};");

            return strBuilder.ToString();
        }



        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_IsExistRecord_S_JavaScript()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��Ӧ�ļ�¼�����б�");
            strBuilder.AppendFormat("\r\n /// mapParam����: mapParam.put(\"strWhereCond\", \"{0} = '01'\");",
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n ///��������:��1:cls{0}WS obj{0}WS = new cls{0}WS(mHandler, \"GetJSONObjLst\", values, null);",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">�����б�</param>");
            strBuilder.Append("\r\n /// <returns>��ȡ����Ӧ��¼�����б�</returns>");
            strBuilder.AppendFormat("\r\n" + "this.IsExistRecord = function( mapParam) ",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const strMethodName = \"{0}_IsExistRecord\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "this.CallWebService(strMethodName, mapParam, this.WEB_SERVICE_URL);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strMsg = \"�ڵ���WebService����ʱ����������Ϣ��\\(String(describing: objException.reason))\";");
            strBuilder.Append("\r\n" + "throw strMsg;");
            strBuilder.Append("\r\n" + "}");



            strBuilder.Append("\r\n" + "};");

            return strBuilder.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_GetRecCountByCond_JavaScript()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡĳһ�����ļ�¼��");
            strBuilder.AppendFormat("\r\n /// mapParam����: mapParam.put(\"strWhereCond\", \"{0} = '01'\");",
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n ///��������:��1:cls{0}WS obj{0}WS = new cls{0}WS(mHandler, \"GetJSONObjLst\", values, null);",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">�����б�</param>");
            strBuilder.Append("\r\n /// <returns>��ȡĳһ�����ļ�¼��</returns>");
            strBuilder.AppendFormat("\r\n" + "this.GetRecCountByCond = function( mapParam) ",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const strMethodName = \"{0}_GetRecCountByCond\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "this.CallWebService(strMethodName, mapParam, this.WEB_SERVICE_URL);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strMsg = \"�ڵ���WebService����ʱ����������Ϣ��\\(String(describing: objException.reason))\";");
            strBuilder.Append("\r\n" + "throw strMsg;");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "};");

            return strBuilder.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_GetRecordJSONObjLst_S_JavaScript()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��Ӧ�ļ�¼�����б�");
            strBuilder.AppendFormat("\r\n /// mapParam����: mapParam.put(\"strWhereCond\", \"1 = 1\");");
            strBuilder.AppendFormat("\r\n ///��������:��1:cls{0}WS obj{0}WS = new cls{0}WS(mHandler, \"GetJSONObjLst\", values, null);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///��������:��2:Thread mThread = new Thread(obj{0}WS);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///��������:��3:mThread.start();");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">�����б�</param>");
            strBuilder.Append("\r\n /// <returns>��ȡ����Ӧ��¼�����б�</returns>");
            strBuilder.AppendFormat("\r\n" + "this.GetJSONObjLst = function( mapParam) ",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const strMethodName = \"GetJSONObjLst\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "this.CallWebService(strMethodName, mapParam, this.WEB_SERVICE_URL);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strMsg = \"�ڵ���WebService����ʱ����������Ϣ��\\(String(describing: objException.reason))\";");
            strBuilder.Append("\r\n" + "throw strMsg;");
            strBuilder.Append("\r\n" + "}");



            strBuilder.Append("\r\n" + "};");

            return strBuilder.ToString();
        }


        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_GetTopRecordJSONObjLst_S_JavaScript()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��Ӧ�ļ�¼�����б�");
            strBuilder.AppendFormat("\r\n /// mapParam����: mapParam.put(\"strWhereCond\", \"1 = 1\");");
            strBuilder.AppendFormat("\r\n ///��������:��1:cls{0}WS obj{0}WS = new cls{0}WS(mHandler, \"GetTopJSONObjLst\", values, null);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///��������:��2:Thread mThread = new Thread(obj{0}WS);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///��������:��3:mThread.start();");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">�����б�</param>");
            strBuilder.Append("\r\n /// <returns>��ȡ����Ӧ��¼�����б�</returns>");
            strBuilder.AppendFormat("\r\n" + "this.GetTopJSONObjLst = function( mapParam) ",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const strMethodName = \"GetTopJSONObjLst\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "this.CallWebService(strMethodName, mapParam, this.WEB_SERVICE_URL);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strMsg = \"�ڵ���WebService����ʱ����������Ϣ��\\(String(describing: objException.reason))\";");
            strBuilder.Append("\r\n" + "throw strMsg;");
            strBuilder.Append("\r\n" + "}");
            
            strBuilder.Append("\r\n" + "};");

            return strBuilder.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_GetRecordJSONObjLstByPager_S_JavaScript()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��Ӧ�ļ�¼�����б�");
            strBuilder.AppendFormat("\r\n /// mapParam����: mapParam.put(\"strWhereCond\", \"1 = 1\");");
            strBuilder.AppendFormat("\r\n ///��������:��1:cls{0}WS obj{0}WS = new cls{0}WS(mHandler, \"GetJSONObjLstByPager\", values, null);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///��������:��2:Thread mThread = new Thread(obj{0}WS);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///��������:��3:mThread.start();");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">�����б�</param>");
            strBuilder.Append("\r\n /// <returns>��ȡ����Ӧ��¼�����б�</returns>");
            strBuilder.AppendFormat("\r\n" + "this.GetJSONObjLstByPager = function( mapParam) ",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const strMethodName = \"GetJSONObjLstByPager\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "this.CallWebService(strMethodName, mapParam, this.WEB_SERVICE_URL);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strMsg = \"�ڵ���WebService����ʱ����������Ϣ��\\(String(describing: objException.reason))\";");
            strBuilder.Append("\r\n" + "throw strMsg;");
            strBuilder.Append("\r\n" + "}");



            strBuilder.Append("\r\n" + "};");

            return strBuilder.ToString();
        }
        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_GetFirstObject_S_JavaScript()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��Ӧ�ļ�¼�����б�");
            strBuilder.AppendFormat("\r\n /// mapParam����: mapParam.put(\"strWhereCond\", \"1 = 1\");");
            strBuilder.AppendFormat("\r\n ///��������:��1:cls{0}WS obj{0}WS = new cls{0}WS(mHandler, \"GetJSONObjLst\", values, null);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///��������:��2:Thread mThread = new Thread(obj{0}WS);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///��������:��3:mThread.start();");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">�����б�</param>");
            strBuilder.Append("\r\n /// <returns>��ȡ����Ӧ��¼�����б�</returns>");
            strBuilder.AppendFormat("\r\n" + "this.GetFirstJSONObj = function( mapParam) ",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const strMethodName = \"GetFirstJSONObj\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "this.CallWebService(strMethodName, mapParam, this.WEB_SERVICE_URL);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strMsg = \"�ڵ���WebService����ʱ����������Ϣ��\\(String(describing: objException.reason))\";");
            strBuilder.Append("\r\n" + "throw strMsg;");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "};");

            return strBuilder.ToString();
        }


        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_GetMaxStrId_S_JavaScript()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����������ȡ��Ӧ�ļ�¼�����б�");
            strBuilder.AppendFormat("\r\n /// mapParam����: mapParam.put(\"strWhereCond\", \"1 = 1\");");
            strBuilder.AppendFormat("\r\n ///��������:��1:cls{0}WS obj{0}WS = new cls{0}WS(mHandler, \"GetJSONObjLst\", values, null);",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///��������:��2:Thread mThread = new Thread(obj{0}WS);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///��������:��3:mThread.start();");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">�����б�</param>");
            strBuilder.Append("\r\n /// <returns>��ȡ����Ӧ��¼�����б�</returns>");
            strBuilder.AppendFormat("\r\n" + "this.GetMaxStrId = function( mapParam) ",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const strMethodName = \"{0}_GetMaxStrId\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "this.CallWebService(strMethodName, mapParam, this.WEB_SERVICE_URL);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strMsg = \"�ڵ���WebService����ʱ����������Ϣ��\\(String(describing: objException.reason))\";");
            strBuilder.Append("\r\n" + "throw strMsg;");
            strBuilder.Append("\r\n" + "}");
            
            strBuilder.Append("\r\n" + "};");

            return strBuilder.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_GetMaxStrIdByPrefix_S_JavaScript()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ����ǰ׺��ȡ��ǰ��ؼ���ֵ�����ֵ,�ټ�1,�����ظ�");

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">�����б�</param>");
            strBuilder.Append("\r\n /// <returns>��ȡ����Ӧ��¼�����б�</returns>");
            strBuilder.AppendFormat("\r\n" + "this.GetMaxStrIdByPrefix = function( mapParam) ",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const strMethodName = \"{0}_GetMaxStrIdByPrefix\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "this.CallWebService(strMethodName, mapParam, this.WEB_SERVICE_URL);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strMsg = \"�ڵ���WebService����ʱ����������Ϣ��\\(String(describing: objException.reason))\";");
            strBuilder.Append("\r\n" + "throw strMsg;");
            strBuilder.Append("\r\n" + "}");
            
            strBuilder.Append("\r\n" + "};");

            return strBuilder.ToString();
        }



        /// <summary>
        /// ͨ�õĵ���WebService����
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_CallWebService_JavaScript()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ͨ�õĵ���WebService����");
            strBuilder.AppendFormat("\r\n /// mapParam����:{0} = \"01\"", objKeyField.PrivFuncName);

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"MethodName\">����</param>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">�����б�</param>");
            strBuilder.Append("\r\n /// <returns>��ȡ��Ӧ�ļ�¼�Ķ���</returns>");
            strBuilder.Append("\r\n" + "this.CallWebService = function(strFunctionName, dictPara, myURL) ");
            strBuilder.Append("\r\n" + "{");
            //strFunctionName = "mySum";
            strBuilder.Append("\r\n" + "const strPara;");
            strBuilder.Append("\r\n" + "strPara = \"\";");
            strBuilder.Append("\r\n" + "  var myKeyss = dictPara.keys();");
            strBuilder.Append("\r\n" + "             var intLength = dictPara.length();");
            strBuilder.Append("\r\n" + "for (let i = 0; i < intLength; i++)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const key = myKeyss[i];");
            strBuilder.Append("\r\n" + "const value = dictPara.getItem(key);");
            strBuilder.Append("\r\n" + "const strTemp = String.format(\"<{0}>{1}</{0}>\", key, value);");
            strBuilder.Append("\r\n" + "strPara = strPara + strTemp;");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "const data;");
            strBuilder.Append("\r\n" + "data = '<?xml version=\"1.0\" encoding=\"utf-8\"?>';");
            strBuilder.Append("\r\n" + "data = data + '<soap:Envelope xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:soap=\"http://schemas.xmlsoap.org/soap/envelope/\">';");
            strBuilder.Append("\r\n" + "data = data + '<soap:Body>';");
            strBuilder.Append("\r\n" + "data = data + String.format('<{0} xmlns=\"http://tempuri.org/\">', strFunctionName);");
            strBuilder.Append("\r\n" + "            data = data + strPara;");
            strBuilder.Append("\r\n" + "data = data + String.format('</{0}>', strFunctionName);");
            strBuilder.Append("\r\n" + "data = data + '</soap:Body>';");
            strBuilder.Append("\r\n" + "data = data + '</soap:Envelope>';");
            strBuilder.Append("\r\n" + "            xmlhttp = getXmlHttp();");
            strBuilder.Append("\r\n" + "const URL = myURL;//WEB_SERVICE_URL;//\"http://localhost:2408/ExamLib/WebService/MyTest1Service.asmx\";");
            strBuilder.Append("\r\n" + "xmlhttp.open(\"POST\", URL, true);");
            strBuilder.Append("\r\n" + "xmlhttp.setRequestHeader(\"Content-Type\", \"text/xml; charset=gb2312\");");
            strBuilder.Append("\r\n" + "const strSOAPAction = String.format(\"http://tempuri.org/{0}\", strFunctionName);");
            strBuilder.Append("\r\n" + "xmlhttp.setRequestHeader(\"SOAPAction\", strSOAPAction);");
            strBuilder.Append("\r\n" + "xmlhttp.send(data);");
            strBuilder.Append("\r\n" + "xmlhttp.onreadystatechange = function() {");
            strBuilder.Append("\r\n" + "//HTTP �����״̬.��һ�� XMLHttpRequest ���δ���ʱ��������Ե�ֵ�� 0 ��ʼ��ֱ�����յ������� HTTP ��Ӧ�����ֵ���ӵ� 4  ");
            strBuilder.Append("\r\n" + "if (xmlhttp.readyState === 4)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "getReturnValue(strFunctionName);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "};");

            return strBuilder.ToString();
        }


        /// <summary>
        /// ͨ�õĵ���WebService����
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_CallWebService_JavaScript_SelfDefWs()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ͨ�õĵ���WebService����");
//            strBuilder.AppendFormat("\r\n /// mapParam����:{0} = \"01\"", objWebSrvClassENEx.ClassName);

            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"MethodName\">����</param>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">�����б�</param>");
            strBuilder.Append("\r\n /// <returns>��ȡ��Ӧ�ļ�¼�Ķ���</returns>");
            strBuilder.Append("\r\n" + "this.CallWebService = function(strFunctionName, dictPara, myURL) ");
            strBuilder.Append("\r\n" + "{");
            //strFunctionName = "mySum";
            strBuilder.Append("\r\n" + "const strPara;");
            strBuilder.Append("\r\n" + "strPara = \"\";");
            strBuilder.Append("\r\n" + "  var myKeyss = dictPara.keys();");
            strBuilder.Append("\r\n" + "             var intLength = dictPara.length();");
            strBuilder.Append("\r\n" + "for (let i = 0; i < intLength; i++)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const key = myKeyss[i];");
            strBuilder.Append("\r\n" + "const value = dictPara.getItem(key);");
            strBuilder.Append("\r\n" + "const strTemp = String.format(\"<{0}>{1}</{0}>\", key, value);");
            strBuilder.Append("\r\n" + "strPara = strPara + strTemp;");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "const data;");
            strBuilder.Append("\r\n" + "data = '<?xml version=\"1.0\" encoding=\"utf-8\"?>';");
            strBuilder.Append("\r\n" + "data = data + '<soap:Envelope xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:soap=\"http://schemas.xmlsoap.org/soap/envelope/\">';");
            strBuilder.Append("\r\n" + "data = data + '<soap:Body>';");
            strBuilder.Append("\r\n" + "data = data + String.format('<{0} xmlns=\"http://tempuri.org/\">', strFunctionName);");
            strBuilder.Append("\r\n" + "            data = data + strPara;");
            strBuilder.Append("\r\n" + "data = data + String.format('</{0}>', strFunctionName);");
            strBuilder.Append("\r\n" + "data = data + '</soap:Body>';");
            strBuilder.Append("\r\n" + "data = data + '</soap:Envelope>';");
            strBuilder.Append("\r\n" + "            xmlhttp = getXmlHttp();");
            strBuilder.Append("\r\n" + "const URL = myURL;//WEB_SERVICE_URL;//\"http://localhost:2408/ExamLib/WebService/MyTest1Service.asmx\";");
            strBuilder.Append("\r\n" + "xmlhttp.open(\"POST\", URL, true);");
            strBuilder.Append("\r\n" + "xmlhttp.setRequestHeader(\"Content-Type\", \"text/xml; charset=gb2312\");");
            strBuilder.Append("\r\n" + "const strSOAPAction = String.format(\"http://tempuri.org/{0}\", strFunctionName);");
            strBuilder.Append("\r\n" + "xmlhttp.setRequestHeader(\"SOAPAction\", strSOAPAction);");
            strBuilder.Append("\r\n" + "xmlhttp.send(data);");
            strBuilder.Append("\r\n" + "xmlhttp.onreadystatechange = function() {");
            strBuilder.Append("\r\n" + "//HTTP �����״̬.��һ�� XMLHttpRequest ���δ���ʱ��������Ե�ֵ�� 0 ��ʼ��ֱ�����յ������� HTTP ��Ӧ�����ֵ���ӵ� 4  ");
            strBuilder.Append("\r\n" + "if (xmlhttp.readyState === 4)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "getReturnValue(strFunctionName);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "};");

            strBuilder.Append("\r\n" + "};");

            return strBuilder.ToString();
        }

        /// <summary>
        /// �̳�Runnable�����ʵ�ֵġ�run������
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_main_JavaScript()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �̳�Runnable�����ʵ�ֵġ�run������");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\n" + "this.main = function()");
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "switch (this.MethodName)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "case \"GetJSONObjBy{1}\":",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.AppendFormat("\r\n" + "ResponseData.what = 1;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "this.GetJSONObjBy{1}(this.Param);",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(err)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "myShowErrorMsg(err.message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "break;");
            strBuilder.AppendFormat("\r\n" + "case \"GetJSONObjLst\":",
                objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "ResponseData.what = 2;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "this.GetJSONObjLst(this.Param);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(err)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "myShowErrorMsg(err.message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "break;");

            strBuilder.Append("\r\n" + "case \"AddNewRecordByJSON\":");
            strBuilder.AppendFormat("\r\n" + "ResponseData.what = 3;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "this.AddNewRecordByJSON(this.Param, this.obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(err)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "myShowErrorMsg(err.message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "break;");
            strBuilder.Append("\r\n" + "case \"UpdateRecordByJSON\":");
            strBuilder.AppendFormat("\r\n" + "ResponseData.what = 4;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "this.UpdateRecordByJSON(this.Param, this.obj{0}EN);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(err)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "myShowErrorMsg(err.message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "break;");
            strBuilder.Append("\r\n" + "case \"DelRecord\":");
            strBuilder.AppendFormat("\r\n" + "ResponseData.what = 5;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "this.DelRecord(this.Param);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(err)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "myShowErrorMsg(err.message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "break;");
            strBuilder.AppendFormat("\r\n" + "case \"GetFirstJSONObj\":",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "ResponseData.what = 6;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "this.GetFirstJSONObj(this.Param);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(err)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "myShowErrorMsg(err.message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "break;");
            strBuilder.AppendFormat("\r\n" + "case \"IsExistRecord\":",
    objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "ResponseData.what = 7;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "this.IsExistRecord(this.Param);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(err)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "myShowErrorMsg(err.message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "break;");
            strBuilder.AppendFormat("\r\n" + "case \"GetMaxStrId\":",
                objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "ResponseData.what = 8;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "this.GetMaxStrId(this.Param);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(err)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "myShowErrorMsg(err.message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "break;");

            strBuilder.AppendFormat("\r\n" + "case \"GetMaxStrIdByPrefix\":",
             objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "ResponseData.what = 9;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "this.GetMaxStrIdByPrefix(this.Param);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(err)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "myShowErrorMsg(err.message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "break;");
            strBuilder.AppendFormat("\r\n" + "case \"GetTopJSONObjLst\":",
objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "ResponseData.what = 10;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "this.GetTopJSONObjLst(this.Param);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(err)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "myShowErrorMsg(err.message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "break;");
            strBuilder.AppendFormat("\r\n" + "case \"GetJSONObjLstByPager\":",
objPrjTabENEx.TabName);

            strBuilder.AppendFormat("\r\n" + "ResponseData.what = 11;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "this.GetJSONObjLstByPager(this.Param);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(err)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "myShowErrorMsg(err.message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "break;");
            strBuilder.AppendFormat("\r\n" + "case \"GetRecCountByCond\":",
objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n" + "ResponseData.what = 12;",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "this.GetRecCountByCond(this.Param);",
                objPrjTabENEx.TabName);
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(err)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "myShowErrorMsg(err.message);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "break;");
            strBuilder.Append("\r\n" + "default:");
            strBuilder.Append("\r\n" + "break;");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "};");


            return strBuilder.ToString();
        }

        /// <summary>
        /// �̳�Runnable�����ʵ�ֵġ�run������
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_main_JavaScript_SelfDefWs()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �̳�Runnable�����ʵ�ֵġ�run������");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\n" + "this.main = function()");
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "switch (this.MethodName)");
            strBuilder.Append("\r\n" + "{");
            int intIndex = 50;
            foreach (clsWebSrvFunctionsENEx objWebSrvFunctionsENEx in objWebSrvClassENEx.arrWebSrvFunctionsENExObjLst)
            {
                if (objWebSrvFunctionsENEx.IsAsyncFunc == true) continue;
                strBuilder.AppendFormat("\r\n" + "case \"{0}\":",
              objWebSrvFunctionsENEx.FunctionName);
                strBuilder.AppendFormat("\r\n" + "ResponseData.what = {0};", intIndex);

                strBuilder.Append("\r\n" + "try");
                strBuilder.Append("\r\n" + "{");
                strBuilder.AppendFormat("\r\n" + "this.{1}(this.Param);",
                    objWebSrvClassENEx.ClassName,
                    objWebSrvFunctionsENEx.FunctionName);
                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "catch(err)");
                strBuilder.Append("\r\n" + "{");
                strBuilder.Append("\r\n" + "myShowErrorMsg(err.message);");
                strBuilder.Append("\r\n" + "}");
                             
               
                strBuilder.Append("\r\n" + "break;");
                intIndex++;
            }
            strBuilder.Append("\r\n" + "default:");
            strBuilder.Append("\r\n" + "break;");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "};");


            return strBuilder.ToString();
        }

        /// <summary>
        /// �̳�Runnable�����ʵ�ֵġ�run������
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_start_JavaScript()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// �̳�Runnable�����ʵ�ֵġ�run������");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.Append("\r\n" + "this.start = function()");
            strBuilder.Append("\r\n" + "{");

            strBuilder.Append("\r\n" + "};");

            return strBuilder.ToString();
        }


        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_GetRecordJSONObjByKey_S_JavaScript()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���");
            strBuilder.AppendFormat("\r\n /// mapParam����:{0} = \"01\"", objKeyField.PrivFuncName);
            strBuilder.AppendFormat("\r\n ///��������:��1:cls{0}WS obj{0}WS = new cls{0}WS(mHandler, \"GetJSONObjBy{1}\", values, null);",
                  objPrjTabENEx.TabName,
                  objKeyField.FldName);
            strBuilder.AppendFormat("\r\n ///��������:��2:Thread mThread = new Thread(obj{0}WS);",
                  objPrjTabENEx.TabName);
            strBuilder.AppendFormat("\r\n ///��������:��3:mThread.start();");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <param name = \"mapParam\">�����б�</param>");
            strBuilder.Append("\r\n /// <returns>��ȡ��Ӧ�ļ�¼�Ķ���</returns>");
            strBuilder.AppendFormat("\r\n" + "this.GetJSONObjBy{1} = function(mapParam) ",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const strMethodName = \"GetJSONObjBy{1}\";",
              objPrjTabENEx.TabName,
              objKeyField.FldName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "this.CallWebService(strMethodName, mapParam, this.WEB_SERVICE_URL);");

            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "catch(objException)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "const strMsg = \"�ڵ���WebService����ʱ����������Ϣ��\\(String(describing: objException.reason))\";");
            strBuilder.Append("\r\n" + "throw strMsg;");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "};");

            return strBuilder.ToString();
        }
        /// <summary>
        /// ��ȡ����ֵ����
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_getReturnValue_JavaScript()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// ��ȡ����ֵ����");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");

            strBuilder.Append("\r\n" + "  function getReturnValue(strFunctionName) {");
            strBuilder.Append("\r\n" + "//alert(xmlhttp.readyState);");
            strBuilder.Append("\r\n" + "////5��������Ӧ����");
            strBuilder.Append("\r\n" + "////�ж϶����״̬�ǽ������");
            strBuilder.Append("\r\n" + "                //�ж�http�Ľ����Ƿ�ɹ�");
            strBuilder.Append("\r\n" + "if (xmlhttp.status !== 200)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "myShowErrorMsg(\"������!!!\");");
            strBuilder.Append("\r\n" + "return;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "//ʹ��responseXML�ķ�ʽ������XML���ݶ����DOM����");
            strBuilder.Append("\r\n" + "const domObj = xmlhttp.responseXML;");
            strBuilder.Append("\r\n" + "if (domObj)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//<message>123123123</message>");
            strBuilder.Append("\r\n" + "//dom������getElementsByTagName���Ը��ݱ�ǩ������ȡԪ�ؽڵ㣬���ص���һ������");
            strBuilder.Append("\r\n" + "const strReturnTag = strFunctionName + \"Result\";");
            strBuilder.Append("\r\n" + "const messageNodes = domObj.getElementsByTagName(strReturnTag);");

            strBuilder.Append("\r\n" + "if (messageNodes.length > 0)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "//��ȡmessage�ڵ��е��ı�����");
            strBuilder.Append("\r\n" + "//message��ǩ�е��ı���dom����message��ǩ����Ӧ��Ԫ�ؽڵ���ֽڵ㣬firstChild���Ի�ȡ����ǰ�ڵ�ĵ�һ���ӽڵ�");
            strBuilder.Append("\r\n" + "//ͨ�����·�ʽ�Ϳ��Ի�ȡ���ı���������Ӧ�Ľڵ�");
            strBuilder.Append("\r\n" + "const textNode = messageNodes[0].firstChild;");
            strBuilder.Append("\r\n" + "//�����ı��ڵ���˵������ͨ��nodeValue�ķ�ʽ�����ı��ڵ���ı�����");
//            strBuilder.Append("\r\n" + "const responseMessage = textNode.nodeValue;");
            strBuilder.Append("\r\n" + "const responseMessage = \"\";");
            strBuilder.Append("\r\n" + "if (textNode === null)");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "responseMessage = \"\";");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "responseMessage = textNode.nodeValue;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "ResponseData.errorId = 0;");
            strBuilder.Append("\r\n" + "ResponseData.IsFinished = true;");
            strBuilder.Append("\r\n" + "ResponseData.data = responseMessage;");
            strBuilder.Append("\r\n" + "ReCallFunc();");
            strBuilder.Append("\r\n" + "//alert(ResponseData.data);");
            strBuilder.Append("\r\n" + "//��������ʾ��ҳ����");
            strBuilder.Append("\r\n" + "//ͨ��dom�ķ�ʽ�ҵ�div��ǩ����Ӧ��Ԫ�ؽڵ�");
            strBuilder.Append("\r\n" + "//var divNode = document.getElementById(\"result\");");
            strBuilder.Append("\r\n" + "////����Ԫ�ؽڵ��е�html����");
            strBuilder.Append("\r\n" + "//divNode.innerHTML = responseMessage;");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "ResponseData.IsFinished = true;");
            strBuilder.Append("\r\n" + "ResponseData.errorId = 1;");
            strBuilder.Append("\r\n" + "ResponseData.faultString = \"XML���ݸ�ʽ����\";");

            strBuilder.Append("\r\n" + "myShowErrorMsg(\"XML���ݸ�ʽ����ԭʼ�ı�����Ϊ��\" + xmlhttp.responseText);");
            strBuilder.Append("\r\n" + "ReCallFunc();");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "else");
            strBuilder.Append("\r\n" + "{");
            strBuilder.Append("\r\n" + "myShowErrorMsg(\"XML���ݸ�ʽ����ԭʼ�ı�����Ϊ��\" + xmlhttp.responseText);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���
        /// </summary>
        /// <returns></returns>
        public string Gen_4Ws_ByCommonFunction_JavaScript(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            string strMsg = "";
            clsDataTypeAbbrEN objFuncReturnTypeEN = clsDataTypeAbbrBL.GetObjByDataTypeId_Cache(objWebSrvFunctionsENEx.ReturnTypeID);
            clsSelfDefDataTypeEN objSelfDefDataTypeEN = null;
            if (objFuncReturnTypeEN == null)
            {
                objSelfDefDataTypeEN = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objWebSrvFunctionsENEx.ReturnType);
                if (objSelfDefDataTypeEN == null)
                {
                    strMsg = string.Format("�����ķ������ͣ�[{0}({1})]û�д�������������Ӧ���롣", objWebSrvFunctionsENEx.ReturnTypeID, objWebSrvFunctionsENEx.ReturnType);
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
                clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeId_Cache(objWebSrvFuncParaEN.DataTypeId);
                clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;
                if (objDataTypeAbbrEN == null)
                {
                    objSelfDefDataTypeEN_Para = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objWebSrvFuncParaEN.ParameterType);
                    if (objSelfDefDataTypeEN_Para == null)
                    {
                        strMsg = string.Format("�����������������ͣ�[{0}({1})]û�д�������������Ӧ���롣", objDataTypeAbbrEN.DataTypeId,
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
                strBuilder.AppendFormat("\r\n" + "this.{1} = function(mapParam)",
                        objSelfDefDataTypeEN.CsType, objWebSrvFunctionsENEx.FunctionName,
                            sbParaList.ToString());
            }
            else
            {
                strBuilder.AppendFormat("\r\n" + "this.{1} = function(mapParam)",
                       objFuncReturnTypeEN.CsType, objWebSrvFunctionsENEx.FunctionName,
                           sbParaList.ToString());
            }
            strBuilder.Append("\r\n" + "{");
            strBuilder.AppendFormat("\r\n" + "const strMethodName = \"{0}\";",
              objWebSrvFunctionsENEx.FunctionName);
            strBuilder.Append("\r\n" + "try");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.AppendFormat("\r\n" + "return this.CallWebService(strMethodName, mapParam, this.WEB_SERVICE_URL);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.AppendFormat("\r\n" + "catch (objException)");
            strBuilder.Append("\r\n" + "{        ");
            strBuilder.AppendFormat("\r\n" + "const strMsg = String.format(\"�ڵ���WebService����:[{0}]ʱ����������Ϣ:%s\", objException.message);",
                objWebSrvFunctionsENEx.FunctionName);
            strBuilder.AppendFormat("\r\n" + "throw strMsg;");
            strBuilder.Append("\r\n" + "}");

            strBuilder.Append("\r\n" + "}");

            return strBuilder.ToString();
        }
        public override string GeneCode4Function(string strFuncId4GC, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strMsg = string.Format("����չ����û��Override�ú�������ע�⣡({0})", clsStackTrace.GetCurrClassFunction());
            throw new Exception(strMsg);
        }
        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strMsg = string.Format("����չ����û��Override�ú�������ע�⣡({0})", clsStackTrace.GetCurrClassFunction());
            throw new Exception(strMsg);
        }
        public override void GetClsName()
        {
            this.ClsName = string.Format("cls{0}WS", objPrjTabENEx.TabName);
            objPrjTabENEx.ClsName = this.ClsName;
        }

    }
}
