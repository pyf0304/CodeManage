using System;
using System.Text;
using System.Data;
using System.Collections;
using System.IO;
using com.taishsoft.commexception;
using com.taishsoft.file;
using com.taishsoft.common;using com.taishsoft.comm_db_obj;


using AGC.Entity;

using com.taishsoft.datetime;
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using System.Collections.Generic;
using com.taishsoft.util;
using AgcCommBase;
using System.Reflection;
using System.Linq;

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
    partial class WA_ViewScriptCSModel_TS4CSharp : clsGeneCodeBase
    {
   
        #region ���캯��
        public WA_ViewScriptCSModel_TS4CSharp()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            InitPageSetup();
        }
        public WA_ViewScriptCSModel_TS4CSharp(string strViewId)
       : base("", strViewId, "", "")
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
        }
        public WA_ViewScriptCSModel_TS4CSharp(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
        : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
        }
        /// <summary>
        /// ��ʼ��ҳ������
        /// </summary>
        public void InitPageSetup()
        {
  
        }

        #endregion



        public string Gen_WApi_Model_SeUserId(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "/// <summary>");
            strCodeForCs.Append("\r\n" + "/// Session����-�û�Id");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "/// </summary>");
            strCodeForCs.Append("\r\n" + "public string seUserId");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "get");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strValue = HttpContext.Session.GetString(\"UserId\");");
            strCodeForCs.Append("\r\n" + "return strValue;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "set");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "HttpContext.Session.SetString(\"UserId\", value);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Model_SetSession(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "/// <summary>");
            strCodeForCs.Append("\r\n" + "/// ����Session����");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "/// </summary>");
            strCodeForCs.Append("\r\n" + "/// <param name=\"strKey\"></param>");
            strCodeForCs.Append("\r\n" + "/// <param name=\"strValue\"></param>");
            strCodeForCs.Append("\r\n" + "public void SetSession(string strKey, string strValue)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "HttpContext.Session.SetString(strKey, strValue);");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
        public string Gen_WApi_Model_WebRoot(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "/// <summary>");
            strCodeForCs.Append("\r\n" + "/// ��ǰ�������Ŀ¼,��appsettings.json���ã�environmentVariables:ASPNETCORE_PATHBASE");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "/// </summary>");
            strCodeForCs.Append("\r\n" + "public string WebRoot");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "get");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//����·��");
            strCodeForCs.Append("\r\n" + "string strPhysicalRoot = AppContext.BaseDirectory;");
            strCodeForCs.Append("\r\n" + "//��ȡ���ã������Ŀ¼");
            strCodeForCs.Append("\r\n" + "const pathBase = Environment.GetEnvironmentVariable(\"ASPNETCORE_PATHBASE\");");
            strCodeForCs.Append("\r\n" + "//��ȡ����������WebRoot");
            strCodeForCs.Append("\r\n" + "return clsPubVar.WebRoot;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
       

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Model_CurrPrjId(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "/// <summary>");
            strCodeForCs.Append("\r\n" + "/// ��ǰ�Ĺ���Id");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "/// </summary>");
            strCodeForCs.Append("\r\n" + "public string CurrPrjId");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "get");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//��ȡ����������CurrPrjId");
            strCodeForCs.Append("\r\n" + "return clsPubVar.CurrPrjId;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Model_GetSession(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "/// <summary>");
            strCodeForCs.Append("\r\n" + "/// ��ȡSession����");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "/// </summary>");
            strCodeForCs.Append("\r\n" + "/// <param name=\"strKey\">�ؼ���-Session������</param>");
            strCodeForCs.Append("\r\n" + "/// <returns>���ص�ǰ�ؼ��ֵ�ֵ</returns>");
            strCodeForCs.Append("\r\n" + "public string GetSession(string strKey)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strValue = HttpContext.Session.GetString(strKey);");
            strCodeForCs.Append("\r\n" + "return strValue;");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Model_Url_Session_GetString(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "/// <summary>");
            strCodeForCs.Append("\r\n" + "/// ��ȡSession���Եĵ�ַ");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "/// </summary>");            
            strCodeForCs.Append("\r\n" + "public string Url_Session_GetString");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "get");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "  return clsPubVar.Url_Session_GetString;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Model_Url_Session_SetString(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "/// <summary>");
            strCodeForCs.Append("\r\n" + "/// ����Session���Եĵ�ַ");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "/// </summary>");
            strCodeForCs.Append("\r\n" + "public string Url_Session_SetString");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "get");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "  return clsPubVar.Url_Session_SetString;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(WA_ViewScriptCSModel_TS4CSharp);
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
        public override void GetClsName()
        {
            

            this.ClsName = objViewInfoENEx.ViewName;
            objViewInfoENEx.ClsName = this.ClsName;
        }
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

                if (strFuncName.Substring(0, 6) == "Print:")
                {
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                    return strCodeForCs.ToString();
                }

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

        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
          
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; ///��ʱ����;

            this.GetClsName();
            objViewInfoENEx.WebFormName = this.ClsName;
            objViewInfoENEx.WebFormFName = objViewInfoENEx.FolderName + this.ClsName + ".cshtml.cs";
            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;
            objViewInfoENEx.ClsName = objViewInfoENEx.WebFormName;

            strRe_ClsName = objViewInfoENEx.WebFormName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebFormFName);

            
            try
            {
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate(objViewInfoENEx.CurrUserName, objViewInfoENEx));

                //strCodeForCs.Append("\r\n ///���ɲ�ѯ,�޸�,ɾ��,��Ӽ�¼�Ŀ��Ʋ����");

                
                strCodeForCs.AppendFormat("\r\n" + "using System;");
                strCodeForCs.AppendFormat("\r\n" + "using System.Collections.Generic;");
                strCodeForCs.AppendFormat("\r\n" + "using System.Diagnostics;");
                strCodeForCs.AppendFormat("\r\n" + "using System.Linq;");
                strCodeForCs.AppendFormat("\r\n" + "using System.Threading.Tasks;");
                strCodeForCs.AppendFormat("\r\n" + "using Microsoft.AspNetCore.Http;");
                strCodeForCs.AppendFormat("\r\n" + "using Microsoft.AspNetCore.Mvc;");
                strCodeForCs.AppendFormat("\r\n" + "using Microsoft.AspNetCore.Mvc.RazorPages;");
                strCodeForCs.AppendFormat("\r\n" + "using {0}.FunClass;", objViewInfoENEx.NameSpace);

                strCodeForCs.AppendFormat("\r\n" + "namespace {0}.Pages", objViewInfoENEx.NameSpace);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0} ��ժҪ˵��������Q�����ѯ,U�����޸�", objViewInfoENEx.WebFormName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "public class  {0}Model : PageModel", objViewInfoENEx.WebFormName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "public string Message { get; set; }");

                strCodeForCs.Append("\r\n" + "public void OnGet()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "Message = \"{0}({1})({2})ҳ��.\";", objViewInfoENEx.ViewName, objViewInfoENEx.ViewCnName, objViewInfoENEx.ViewId);
                strCodeForCs.Append("\r\n" + "}");

                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
           clsvFunction4GeneCodeBLEx.GetObjLstByViewInfoEx(objViewInfoENEx);


                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    if (strFuncName.Substring(0, 6) == "Print:")
                    {
                        strCodeForCs.Append("\r\n" + "");
                        strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                        continue;
                    }
                    try
                    {
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                        if (string.IsNullOrEmpty(strTemp) == false)
                        {
                            strCodeForCs.Append("\r\n" + strTemp);
                        }
                    }
                    catch (Exception objException)
                    {
                        throw objException;
                    }
                }


                strCodeForCs.Append("\r\n" + "");
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


    }
}
