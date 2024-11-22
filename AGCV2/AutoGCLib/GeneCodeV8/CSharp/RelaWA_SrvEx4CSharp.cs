using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commexception;
using com.taishsoft.common;
using com.taishsoft.datetime;
using System;
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
    partial class RelaWA_SrvEx4CSharp : clsGeneCodeBase
    {

        #region ���캯��

        public RelaWA_SrvEx4CSharp()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }
        public RelaWA_SrvEx4CSharp(string strPrjId)
          : base(strPrjId)
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }
        public RelaWA_SrvEx4CSharp(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
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


            objPrjTabENEx.ClsName = string.Format("{0}ExApiController", objPrjTabENEx.TabName);
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
                strBuilder.AppendFormat("\r\n" + "using {0}.Entity;",                objProject.PrjDomain);
                strBuilder.AppendFormat("\r\n" + "using {0}.BusinessLogic;",                        objProject.PrjDomain);
                strBuilder.AppendFormat("\r\n" + "using {0}.BusinessLogicEx;",                    objProject.PrjDomain);                
                strBuilder.Append("\r\n" + ""); //
                strBuilder.Append("\r\n" + "using com.taishsoft.common;");
                strBuilder.Append("\r\n" + "using com.taishsoft.datetime;");
                strBuilder.Append("\r\n" + "using System.Web.Http;");
                strBuilder.Append("\r\n" + "using System.Net;");
                strBuilder.Append("\r\n" + "using Newtonsoft.Json.Linq; using Comm.WebApi;");
                strBuilder.Append("\r\n" + ""); //
                strBuilder.AppendFormat("\r\n" + "namespace {0}.WebApi",
                        objProject.PrjDomain);
                strBuilder.Append("\r\n" + "{");


                strBuilder.Append("\r\n /// <summary>");
                strBuilder.AppendFormat("\r\n /// {0} ��ժҪ˵��",
                        objPrjTabENEx.ClsName);
                //if (objPrjTabENEx.IsForSilverLight == true)
                //{
                //    strBuilder.AppendFormat("\r\n /// For SilverLight");
                //}
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n" + "public class  {0} : {1}ApiController",
                          objPrjTabENEx.ClsName, objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "{ ");

                //�������еĺ���

                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                  clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
                  objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId);

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
                    string strFuncName = objvFunction4GeneCodeEN.FuncName;

                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strBuilder.Append("\r\n" + strTemp);
                    }
                }
                //�����û��Զ���ĺ���
                string strCode = clsFunction4CodeBLEx.GeneCode4Class(objPrjTabENEx.ClsName, objPrjTabENEx.CodeTypeId, objPrjTabENEx.PrjId);
                strBuilder.Append("\r\n" + strCode);

                strBuilder.Append("\r\n" + "}");
                strBuilder.Append("\r\n" + "}");

                ////������д���ļ���;
                ////�����ļ������ļ�����,���ж��Ƿ����;
                //strFolder = clsString.ParentDir_S(strClassFName);
                //if (System.IO.Directory.Exists(strFolder) == false)
                //{
                //    Directory.CreateDirectory(strFolder);
                //}

                //if (clsSysParaEN_Local.IsBackupForGeneCode  == true)
                //{
                //    string strSimpleFileName = clsString.GetSimpleFName_S(strClassFName);
                //    string strFindFileFullFile = clsFile.FindFileFromFolder(objPrjTabENEx.FolderName_Root, strSimpleFileName);
                //    while (string.IsNullOrEmpty(strFindFileFullFile) == false)
                //    {
                //        string strMsg = string.Format("�ļ�:{0}�Ѿ�����!", strFindFileFullFile);
                //        throw new Exception(strMsg);
                //    }
                //}
                ////UTF8Encoding utf8 = new UTF8Encoding(false);
                //clsFile.CreateFileByString(strClassFName, strBuilder.ToString(), myEncoding);
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strBuilder.ToString();
        }

        /// <summary>
        /// ���ɹ��캯��1
        /// </summary>
        /// <returns></returns>
        public string Gen_WAEx_ClassConstructor1()
        {
            StringBuilder strBuilder = new StringBuilder();

            ///�๹����----------------------------------------------;
            strBuilder.Append("\r\n/// <summary>");
            strBuilder.Append("\r\n/// ���캯��");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n/// </summary>");
            strBuilder.Append("\r\n public " + objPrjTabENEx.ClsName + "()");
            strBuilder.Append("\r\n {");
            strBuilder.Append("\r\n }");
            return strBuilder.ToString();
        }

        public string Gen_WAEx_EditRelationEx()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFuncName = "";
            try
            {
                //�޸Ĵ���׼�����̴��� for C#
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.Append("\r\n /// �༭��¼���̵����ݱ��С����������ؼ�¼���޸�,�����ھ����");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}\">��Ҫ�޸ĵ�ʵ�����</param>", objPrjTabENEx.TabName);
                strBuilder.Append("\r\n /// <returns>�޸��Ƿ�ɹ���</returns>");
                strBuilder.Append("\r\n" + "[HttpPost]");
                strBuilder.AppendFormat("\r\n" + "public ActionResult EditRelationEx([FromBody]cls{0}EN obj{0})",
                objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "{");
                
                strBuilder.Append("\r\n" + "//��������:");
                strBuilder.Append("\r\n" + "//1����鴫��ȥ�Ķ��������Ƿ�Ϸ�");
                strBuilder.Append("\r\n" + "//2�����Ψһ��");
                strBuilder.Append("\r\n" + "//3��������ʵ�������ݴ��������ݿ���");
                //strBuilder.Append("\r\n" + "string strMsg;	//ר�����ڴ�����Ϣ�ı���");

                strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
                strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");

                strBuilder.AppendFormat("\r\n" + "string str{0}JSONObj = clsJSON.GetJsonFromObj(obj{0});",
                          objPrjTabENEx.TabName);

                strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"str{0}JSONObj\", str{0}JSONObj);",
                          objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");

                strBuilder.AppendFormat("\r\n" + "obj{0}._IsCheckProperty = true;",
                    objPrjTabENEx.TabName);
                strBuilder.Append("\r\n try");
                strBuilder.Append("\r\n {");

                                strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}.EditRelationEx();", objPrjTabENEx.TabName);

                strBuilder.Append("\r\n" + "return Json(new { errorId = 0, errorMsg = \"\", returnBool = bolResult });");

                strBuilder.Append("\r\n" + "}");
         
                strBuilder.Append("\r\n catch (Exception objException)");
                strBuilder.Append("\r\n {");
                strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
                //strBuilder.Append("\r\n" + "return clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
                strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
                strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
                strBuilder.Append("\r\n }");
                strBuilder.Append("\r\n }");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strBuilder.ToString();
        }

        public string Gen_WAEx_AddRelationEx()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFuncName = "";
            try
            {
                //�޸Ĵ���׼�����̴��� for C#
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.Append("\r\n /// �༭��¼���̵����ݱ��С����������ؼ�¼���޸�,�����ھ����");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}\">��Ҫ�޸ĵ�ʵ�����</param>", objPrjTabENEx.TabName);
                strBuilder.Append("\r\n /// <returns>�޸��Ƿ�ɹ���</returns>");
                strBuilder.Append("\r\n" + "[HttpPost]");
                strBuilder.AppendFormat("\r\n" + "public ActionResult AddRelationEx([FromBody]cls{0}EN obj{0})",
                objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "{");
                
                strBuilder.Append("\r\n" + "//��������:");
                strBuilder.Append("\r\n" + "//1����鴫��ȥ�Ķ��������Ƿ�Ϸ�");
                strBuilder.Append("\r\n" + "//2�����Ψһ��");
                strBuilder.Append("\r\n" + "//3��������ʵ�������ݴ��������ݿ���");
                //strBuilder.Append("\r\n" + "string strMsg;	//ר�����ڴ�����Ϣ�ı���");

                strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
                strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");

                strBuilder.AppendFormat("\r\n" + "string str{0}JSONObj = clsJSON.GetJsonFromObj(obj{0});",
                          objPrjTabENEx.TabName);

                strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"str{0}JSONObj\", str{0}JSONObj);",
                          objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
                //strBuilder.AppendFormat("\r\n" + "obj{0}._IsCheckProperty = true;",
                //    objPrjTabENEx.TabName);
                strBuilder.Append("\r\n try");
                strBuilder.Append("\r\n {");

                if (new List<string>() { clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY, enumPrimaryType.StringAutoAddPrimaryKey_03 }.Contains(objKeyField.PrimaryTypeId))
                {
                    if (objKeyField.CsType == "string")
                    {
                        strBuilder.AppendFormat("\r\n" + "obj{0}.{1} = cls{0}BL.GetMaxStrId();",
                              objPrjTabENEx.TabName, objKeyField.ObjFieldTabENEx.FldName);

                    }
                    else
                    {
                        strBuilder.AppendFormat("\r\n" + "obj{0}.{1} = cls{0}BL.GetMaxId();",
                            objPrjTabENEx.TabName, objKeyField.ObjFieldTabENEx.FldName);

                    }
                }
                strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}.AddRelationEx();", objPrjTabENEx.TabName);

                strBuilder.Append("\r\n" + "return Json(new { errorId = 0, errorMsg = \"\", returnBool = bolResult });");

                strBuilder.Append("\r\n" + "}");

                strBuilder.Append("\r\n catch (Exception objException)");
                strBuilder.Append("\r\n {");
                strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
                //strBuilder.Append("\r\n" + "return clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
                strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
                strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
                strBuilder.Append("\r\n }");
                strBuilder.Append("\r\n }");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strBuilder.ToString();
        }

        public string Gen_WAEx_UpdateRelationEx()
        {
            StringBuilder strBuilder = new StringBuilder();
            string strFuncName = "";
            try
            {
                //�޸Ĵ���׼�����̴��� for C#
                strBuilder.Append("\r\n /// <summary>");
                strBuilder.Append("\r\n /// �༭��¼���̵����ݱ��С����������ؼ�¼���޸�,�����ھ����");
                strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strBuilder.Append("\r\n /// </summary>");
                strBuilder.AppendFormat("\r\n /// <param name = \"obj{0}\">��Ҫ�޸ĵ�ʵ�����</param>", objPrjTabENEx.TabName);
                strBuilder.Append("\r\n /// <returns>�޸��Ƿ�ɹ���</returns>");
                strBuilder.Append("\r\n" + "[HttpPost]");
                strBuilder.AppendFormat("\r\n" + "public ActionResult UpdateRelationEx([FromBody]cls{0}EN obj{0})",
                objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "{");
                
                strBuilder.Append("\r\n" + "//��������:");
                strBuilder.Append("\r\n" + "//1����鴫��ȥ�Ķ��������Ƿ�Ϸ�");
                strBuilder.Append("\r\n" + "//2�����Ψһ��");
                strBuilder.Append("\r\n" + "//3��������ʵ�������ݴ��������ݿ���");
                //strBuilder.Append("\r\n" + "string strMsg;	//ר�����ڴ�����Ϣ�ı���");

                strBuilder.Append("\r\n" + "string strFunctionName = clsStackTrace.GetCurrFunction();");
                strBuilder.Append("\r\n" + "Dictionary<string, string> dictParam = new();");

                strBuilder.AppendFormat("\r\n" + "string str{0}JSONObj = clsJSON.GetJsonFromObj(obj{0});",
                          objPrjTabENEx.TabName);

                strBuilder.AppendFormat("\r\n" + "dictParam.Add(\"str{0}JSONObj\", str{0}JSONObj);",
                          objPrjTabENEx.TabName);
                strBuilder.Append("\r\n" + "clsPubFun_WebApi.Log4Debug(this, strFunctionName, dictParam);");
                strBuilder.AppendFormat("\r\n" + "obj{0}._IsCheckProperty = true;",
                    objPrjTabENEx.TabName);
                strBuilder.Append("\r\n try");
                strBuilder.Append("\r\n {");

                strBuilder.AppendFormat("\r\n" + "bool bolResult = obj{0}.UpdateRelationEx();", objPrjTabENEx.TabName);

                strBuilder.Append("\r\n" + "return Json(new { errorId = 0, errorMsg = \"\", returnBool = bolResult });");

                strBuilder.Append("\r\n" + "}");

                strBuilder.Append("\r\n catch (Exception objException)");
                strBuilder.Append("\r\n {");
                strBuilder.Append("\r\n" + "string strMsg = string.Format(\"{0}.(from {1})\", objException.Message,  clsStackTrace.GetCurrClassFunction());");
                //strBuilder.Append("\r\n" + "return clsPubFun_WebApi.AccessException(strMsg, HttpStatusCode.NotFound);");
                strBuilder.Append("\r\n" + "clsPubVar_WebApi.objLog.WriteDebugLog(strMsg);");
                strBuilder.Append("\r\n" + "return Json(new { errorId = 1, errorMsg = strMsg });");
                strBuilder.Append("\r\n }");
                strBuilder.Append("\r\n }");
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
                Type t = typeof(RelaWA_SrvEx4CSharp);
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

    }
}
