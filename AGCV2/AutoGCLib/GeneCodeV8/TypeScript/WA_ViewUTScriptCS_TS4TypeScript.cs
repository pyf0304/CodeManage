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
using AgcCommBase;
using System.Reflection;

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
    partial class WA_ViewUTScriptCS_TS4TypeScript : clsGeneCodeBase
    {
      


        #region ���캯��

        public WA_ViewUTScriptCS_TS4TypeScript()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            this.arrImportClass = new List<ImportClass>();
        }
        public WA_ViewUTScriptCS_TS4TypeScript(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
          : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //

            if (thisCacheClassify4View.IsHasCacheClassfyFld == true)
            {
                thisCacheClassify4View.VarDef4Fld = string.Format("{0}.{1}Cache", objViewInfoENEx.ClsName, thisCacheClassify4View.FldName);
            }
            if (thisCacheClassify4View.IsHasCacheClassfyFld2 == true)
            {
                thisCacheClassify4View.VarDef4Fld2 = string.Format("{0}.{1}Cache", objViewInfoENEx.ClsName, thisCacheClassify4View.FldName2);
            }

            this.strDataBaseType = clsPubConst.con_MsSql;
            this.arrImportClass = new List<ImportClass>();
        }
        #endregion

        /// <summary>
        /// ����ָ���ĺ���
        /// </summary>
        /// <returns>�������ɵ�ָ����������</returns>
        public string A_GenCode4Function_Ts_btnClick(string strFuncId4GC)
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp; //��ʱ����;
            string strFuncName = "";
            try
            {
                //������ʼ
                // clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
                string strCondition = string.Format("{0}='{1}'", convFunction4GeneCode.FuncId4GC, strFuncId4GC);
                clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBL.GetFirstObj_S(strCondition);

                //strFuncName = objFunction4GeneCodeEN.FuncName;

                //if (objFunction4GeneCodeEN.FuncTypeId == "10")//�û��Զ��庯��
                //{
                //    strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objFunction4GeneCodeEN.FuncId4GC,
                //        objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
                //}
                //else
                //{
                //    strTemp = A_GeneFuncCode_Ts_btnClick(strFuncName);
                //}
                strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
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


        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(WA_ViewUTScriptCS_TS4TypeScript);
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
                sbMessage.AppendFormat("�����ɺ���:{0}ʱ����. \r\n������Ϣ:{1}.", objvFunction4GeneCodeEN.FuncName, objException.Message);
                throw new Exception(sbMessage.ToString());
            }
        }
        /// <summary>
        /// ���û����������
        /// </summary>
        /// <param name="objPrjTab"></param>
        /// <returns></returns>
        private bool GetCacheParaVarStr()
        {
            clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(objViewInfoENEx.objViewRegion_List.TabId, objViewInfoENEx.PrjId);

            if (thisCacheClassify4View.IsHasCacheClassfyFld == true)
            {

                if (string.IsNullOrEmpty(objPrjTab.ParaVar1TS) == false)
                {
                    var objVar = clsGCVariableBL.GetObjByVarIdCache(objPrjTab.ParaVar1TS);
                    if (objVar.VarTypeId == enumGCVariableType.sessionStorage_0004)
                    {
                        thisCacheClassify4View.VarDef4Fld = string.Format("{0}", objVar.VarExpression);
                    }
                    else
                    {
                        thisCacheClassify4View.VarDef4Fld = string.Format("{0}.{1}Cache", objViewInfoENEx.ClsName, thisCacheClassify4View.FldName);
                    }
                }
                else
                {
                    thisCacheClassify4View.VarDef4Fld = string.Format("{0}.{1}Cache", objViewInfoENEx.ClsName, thisCacheClassify4View.FldName);
                }
            }
            if (thisCacheClassify4View.IsHasCacheClassfyFld2 == true)
            {
                if (string.IsNullOrEmpty(objPrjTab.ParaVar2TS) == false)
                {
                    var objVar = clsGCVariableBL.GetObjByVarIdCache(objPrjTab.ParaVar2TS);
                    if (objVar.VarTypeId == enumGCVariableType.sessionStorage_0004)
                    {
                        thisCacheClassify4View.VarDef4Fld2 = string.Format("{0}", objVar.VarExpression);
                    }
                    else
                    {
                        thisCacheClassify4View.VarDef4Fld2 = string.Format("{0}.{1}Cache", objViewInfoENEx.ClsName, thisCacheClassify4View.FldName2);
                    }
                }
                else
                {
                    thisCacheClassify4View.VarDef4Fld2 = string.Format("{0}.{1}Cache", objViewInfoENEx.ClsName, thisCacheClassify4View.FldName2);
                }
            }
            return true;
        }
        /// <summary>
        /// ����Appҳ���̨����
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
            //if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlView_02) return "";
            string strResult = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strResult = string.Format("��ǰ��:[{0}]���ֶ���Ϊ0,�޷�����ͨ���߼���({1})",
                        objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strResult = string.Format("��ǰ��:[{0}]�Ĺؼ��ֵĸ���Ϊ0,�޷�����ͨ���߼���({1})",
                   objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            objPrjTabENEx.CurrDate = clsDateTime.getTodayStr2(0);

            GetCacheParaVarStr();
            //���û���������;
            //string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp = ""; ///��ʱ����;

            objPrjTabENEx.ClsName = string.Format("WApi{0}_UT_TS", objPrjTabENEx.TabName);;
            string strXmlFileName = string.Format("WApi{0}_UT_TS", objPrjTabENEx.TabName);;
            strXmlFileName = strXmlFileName.ToLower();
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".ts";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName( objFuncModule, objPrjTabENEx);
            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".ts";

            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            try
            {
                //������ʼ
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate4WebApi(objPrjTabENEx.UserId, objPrjTabENEx, this.CmPrjId));

                //strCodeForCs.Append("\r\n ///���ɲ�ѯɾ����¼�Ŀ��Ʋ����");
                //strCodeForCs.Append("\r\n" + GenRefDomainName());    //���ɲο�����
                strCodeForCs.Append("\r\n" + "///// <reference path=\"../../../scripts/typings/jquery/jquery.d.ts\" />");
                
                strCodeForCs.Append("\r\n" + "/////import * as $ from \"jquery\";");

                strCodeForCs.AppendFormat("\r\n" + "import {{ cls{1}EN }} from \"../TS/L0Entity/{0}/cls{1}EN.js\";",
                     objFuncModule.FuncModuleEnName4GC(),
                       objPrjTabENEx.TabName);
                //strCodeForCs.AppendFormat("\r\n" + "import {{ cls{1}BL }} from \"../TS/L2_BLL/{0}/cls{1}BL.js\";",
                //                     objFuncModule.FuncModuleEnName4GC()
                //                       objPrjTabENEx.TabName);

                strCodeForCs.AppendFormat("\r\n" + "import {{ cls{1}WApi, cls{1}BL }} from \"../TS/L3ForWApi/{0}/cls{1}WApi.js\";",
                     objFuncModule.FuncModuleEnName4GC(),
                       objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "import { clsCommFunc4Web } from \"../TS/PubFun/clsCommFunc4Web.js\";");
                
                strCodeForCs.Append("\r\n" + "import { stuTopPara } from \"../TS/PubFun/stuTopPara.js\";");
                strCodeForCs.Append("\r\n" + "import { stuRangePara } from \"../TS/PubFun/stuRangePara.js\";");
                strCodeForCs.Append("\r\n" + "import { stuPagerPara } from \"../TS/PubFun/stuPagerPara.js\";");
                //strCodeForCs.Append("\r\n" + "import { clsPubFun } from \"../TS/PubFun/clsPubFun.js\";");
                //strCodeForCs.Append("\r\n" + "import { C1acheHelper } from \"../TS/PubFun/CacheHelper.js\";");
                strCodeForCs.Append("\r\n" + "import { clsFldComparisonObj } from \"../TS/PubFun/clsFldComparisonObj.js\";");
                strCodeForCs.Append("\r\n" + "declare var $;");
                //strCodeForCs.AppendFormat("\r\n" + "namespace {0}.WApiForm", objProject.PrjDomain);
                //strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n /// <summary>");
                strCodeForCs.AppendFormat("\r\n /// {0} ��ժҪ˵��������Q�����ѯ,U�����޸�", objPrjTabENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n /// </summary>");
                strCodeForCs.AppendFormat("\r\n" + "export class  {0} ", objPrjTabENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.Append("\r\n" + "private strInfo = \"\";");
                //strCodeForCs.Append("\r\n" + "private strWhereCond = \"\";");

                strCodeForCs.Append("\r\n" + "");

                if (objPrjTabENEx.objCacheClassifyFld != null)
                {

                    strCodeForCs.AppendFormat("\r\n" + "public static {0}Cache = \"\";",
                        objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
                }
                            
                //�������еĺ���
                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                  clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
                  objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId);
                //Ϊ���еĺ��������������ؼ�
                List<string> arrValueLst = new List<string>();
                             
                //Ϊ�����Ĳ�������ؼ����а�
                arrValueLst = new List<string>();
                       

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    //string strTemp = "";
                    //if (strFuncName.IndexOf("Ts_btnClick") > 0)
                    //{
                        //string strFuncName4Code = objvFunction4GeneCodeEN.FuncName4Code;
                        //if (strFuncName4Code.Contains("AddNew") == true
                        //    || strFuncName4Code.Contains("Update") == true
                        //    || strFuncName4Code.Contains("GetObjByKey") == true)
                        //{
                        strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                        //string strSource = string.Format("ac{0}_UnitTest", objPrjTabENEx.TabName);
                        //string strTarget = string.Format("ac{0}_UTScript", objPrjTabENEx.TabName);

                        //strTemp = strTemp.Replace(strSource, strTarget);
                    //}
                    //else
                    //{
                    //    strTemp = "";
                    //}
                    //strTemp = A_GeneFuncCode_Java(strFuncName);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }
                //strCodeForCs.Append("\r\n" + "}");
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
      
        public string Gen_WApi_Ts_UT_BindTab(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// ��ʾ{0}�������������ֵ", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"divContainer\">��ʾ����</param>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"arr{0}ObjLst\">��Ҫ�󶨵Ķ����б�</param>",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "BindTab_{0}(divContainer: HTMLDivElement, arr{0}ObjLst: Array<cls{0}EN>) ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"BindTab_{0}\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
      
            strCodeForCs.Append("\r\n" + "if (divContainer == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(Format(\"{0}������!\",divContainer));");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + $"const divDataLst = GetDivObjInDivObj(divContainer, 'divDataLst');");

            strCodeForCs.Append("\r\n" + "const sstrFldName: Array < string > = new Array<string>();");
            strCodeForCs.Append("\r\n" + "const sstrColHeader: Array < string > = new Array<string>();");
            
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                strCodeForCs.AppendFormat("\r\n" + "sstrFldName.push(\"{0}\"); sstrColHeader.push(\"{1}\");",
                    objField.ObjFieldTabENEx.FldName,
                    objField.ColCaption);
            }
            strCodeForCs.AppendFormat("\r\n" + "clsCommFunc4Web.BindTab(divContainer, arr{0}ObjLst, sstrFldName, sstrColHeader, \"{1}\"); ",
                objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "}");
         

            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_UT_ShowTabObj(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��ʾ{0}�������������ֵ");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"divContainer\">��ʾ����</param>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}\">��Ҫ��ʾ�Ķ���</param>",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "public static Show{0}Obj(divContainer: HTMLDivElement, obj{0}: cls{0}EN) ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"Show{0}Obj\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            
            strCodeForCs.Append("\r\n" + "if (divContainer == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(Format(\"{0}������!\",divContainer));");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "const sstrKeys = clsCommFunc4Web.GetObjKeys(obj{0});",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "const ul: HTMLUListElement = document.createElement(\"ul\");");

            strCodeForCs.Append("\r\n" + "for (const strKey of sstrKeys)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strValue = obj{0}.GetFldValue(strKey);",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "const li: HTMLLIElement = document.createElement(\"li\");");
            strCodeForCs.Append("\r\n" + "li.innerHTML = Format(\"{0}:{1}\", strKey, strValue);");
            strCodeForCs.Append("\r\n" + "ul.appendChild(li);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "divContainer.appendChild(ul);");
            strCodeForCs.Append("\r\n" + "}");
        
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_btnClickGetObjByKey(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName4Code = TransKeyWords4FuncName(objvFunction4GeneCodeEN.FuncName4Code);

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">�����б�</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "btn{0}_Click() ",
                strFuncName4Code);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btn{0}_Click\";",       strFuncName4Code);

            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            //GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;
            //clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;

            strCodeForCs.AppendFormat("\r\n" + "const strKeyId: string = $('#txtvarKeyId{0}').val();",
                    objvFunction4GeneCodeEN.OrderNum);
     
            if (objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strCodeForCs.AppendFormat("\r\n" + "const {0}: {1} = strKeyId;",
                  objKeyField.PrivFuncName,
                  objKeyField.TypeScriptType);
            }
            else
            {
                switch (objDataTypeAbbrEN.DataTypeId)
                {
                    case enumDataTypeAbbr.float_07:                       
                    case enumDataTypeAbbr.int_09:
                    case enumDataTypeAbbr.money_11:
                    case enumDataTypeAbbr.bigint_01:
                    case enumDataTypeAbbr.bigintidentity_26:

                        strCodeForCs.AppendFormat("\r\n" + "const {1}: {0} = Number(strKeyId);",
                            objDataTypeAbbrEN.TypeScriptType,
                            objKeyField.PrivFuncName);
                        break;
                    default:
                        string strMsg = string.Format("�������ͣ�[{0}({1})](TypeScript:{2})�ں�����û�д���!({3})",
                            objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                            objDataTypeAbbrEN.TypeScriptType,
                            clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                }
            }
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

           
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN = await {0}GetObjBy{1}Async({2});",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);


            strCodeForCs.AppendFormat("\r\n" + "       if (obj{0}ENConst == null)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "        {");

            strCodeForCs.Append("\r\n" + "            const strMsg = Format(\"���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���Ϊ��.(in {0}.{1})\", this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "            alert(strMsg);");
            strCodeForCs.Append("\r\n" + "            return false;");
            strCodeForCs.Append("\r\n" + "        }");

            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"���ݹؼ���:[{{0}}]��ȡ����{{1}}!\", strKeyId, obj{0}EN.{1});",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "this.Show{1}Obj(\"divList{0}\", obj{1}EN);", 
                objvFunction4GeneCodeEN.OrderNum, objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��󲻳ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

    

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_btnClickGetObjByKey_WACache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            string strFuncName4Code = TransKeyWords4FuncName(objvFunction4GeneCodeEN.FuncName4Code);

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">�����б�</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "btn{0}_Click() ",
                strFuncName4Code);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btn{0}_Click\";",        strFuncName4Code);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            //GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;
            //clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;

            strCodeForCs.AppendFormat("\r\n" + "const strKeyId: string = $('#txtvarKeyId{0}').val();",
                    objvFunction4GeneCodeEN.OrderNum);

            if (objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strCodeForCs.AppendFormat("\r\n" + "const {0}: {1} = strKeyId;",
                  objKeyField.PrivFuncName,
                  objKeyField.TypeScriptType);
            }
            else
            {
                switch (objDataTypeAbbrEN.DataTypeId)
                {
                    case enumDataTypeAbbr.float_07:
                    case enumDataTypeAbbr.int_09:
                    case enumDataTypeAbbr.money_11:
                    case enumDataTypeAbbr.bigint_01:
                    case enumDataTypeAbbr.bigintidentity_26:

                        strCodeForCs.AppendFormat("\r\n" + "const {1}: {0} = Number(strKeyId);",
                            objDataTypeAbbrEN.TypeScriptType,
                            objKeyField.PrivFuncName);
                        break;
                    default:
                        string strMsg = string.Format("�������ͣ�[{0}({1})](TypeScript:{2})�ں�����û�д���!({3})",
                            objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                            objDataTypeAbbrEN.TypeScriptType,
                            clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                }
            }
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN = await {0}GetObjBy{1}_WACacheAsync({2});",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const {0}:{1} = {2}.{0}Cache;",
                    objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                    objPrjTabENEx.objCacheClassifyFld.TypeScriptType, objPrjTabENEx.ClsName);

                strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN = await {0}GetObjBy{1}_WACacheAsync({2}, {3});",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName,
                    objPrjTabENEx.objCacheClassifyFld.PrivFuncName
                );
            }
            
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"���ݹؼ���:[{{0}}]��ȡ����{{1}}!\", strKeyId, obj{0}EN.{1});",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "this.Show{1}Obj(\"divList{0}\", obj{1}EN);",
                objvFunction4GeneCodeEN.OrderNum, objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��󲻳ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_btnClickGetObjByKeyCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            string strFuncName4Code = TransKeyWords4FuncName(objvFunction4GeneCodeEN.FuncName4Code);

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ���");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">�����б�</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "btn{0}_Click() ",
                strFuncName4Code);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btn{0}_Click\";",        strFuncName4Code, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            //GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;
            //clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;

            strCodeForCs.AppendFormat("\r\n" + "const strKeyId: string = $('#txtvarKeyId{0}').val();",
                    objvFunction4GeneCodeEN.OrderNum);

            if (objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strCodeForCs.AppendFormat("\r\n" + "const {0}: {1} = strKeyId;",
                  objKeyField.PrivFuncName,
                  objKeyField.TypeScriptType);
            }
            else
            {
                switch (objDataTypeAbbrEN.DataTypeId)
                {
                    case enumDataTypeAbbr.float_07:
                    case enumDataTypeAbbr.int_09:
                    case enumDataTypeAbbr.money_11:
                    case enumDataTypeAbbr.bigint_01:
                    case enumDataTypeAbbr.bigintidentity_26:

                        strCodeForCs.AppendFormat("\r\n" + "const {1}: {0} = Number(strKeyId);",
                            objDataTypeAbbrEN.TypeScriptType,
                            objKeyField.PrivFuncName);
                        break;
                    default:
                        string strMsg = string.Format("�������ͣ�[{0}({1})](TypeScript:{2})�ں�����û�д���!({3})",
                            objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                            objDataTypeAbbrEN.TypeScriptType,
                            clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                }
            }
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN = await {0}GetObjBy{1}Cache({2});",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const {0}:{1} = {2}.{0}Cache;",
                    objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                    objPrjTabENEx.objCacheClassifyFld.TypeScriptType, objPrjTabENEx.ClsName);

                strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN = await {0}GetObjBy{1}Cache({2}, {3});",
                objPrjTabENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName,
                    objPrjTabENEx.objCacheClassifyFld.PrivFuncName
                );
            }

            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"���ݹؼ���:[{{0}}]��ȡ����{{1}}!\", strKeyId, obj{0}EN.{1});",
                objPrjTabENEx.TabName,
                objKeyField.FldName);
            
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "this.Show{1}Obj(\"divList{0}\", obj{1}EN);",
                objvFunction4GeneCodeEN.OrderNum, objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��󲻳ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_CreateCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
                        
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��������");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "CreateCache() ");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"CreateCache\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            //strCodeForCs.Append("\r\n" + "clsPubFun.SetCommFun4BL();");
            strCodeForCs.Append("\r\n" + "let strKey = \"\";");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "//console.log(\"��ʼ��ȡ���棺{0}\");", objPrjTabENEx.TabName);
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "strKey = cls{0}EN._CurrTabName;", objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + $"await {thisWA_F(WA_F.GetObjLst_Cache)}();");
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const {0}:{1} = {2}.{0}Cache;",
               objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
               objPrjTabENEx.objCacheClassifyFld.TypeScriptType, objPrjTabENEx.ClsName);
                if (objPrjTabENEx.objCacheClassifyFld.IsNumberType() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1});",
                           objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName);

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1});",
                         objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
                }
                strCodeForCs.Append("\r\n" + $"await {thisWA_F(WA_F.GetObjLst_Cache)}({objPrjTabENEx.objCacheClassifyFld.PrivFuncName});");
            }
            strCodeForCs.AppendFormat("\r\n" + "//console.log(\"��ȡ�������!{0}\");", objPrjTabENEx.TabName);
            
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst: Array < cls{0}EN > = CacheHelper.Get(strKey);", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ObjLst != null)", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"��������Key=[{{0}}]���: ����ȡ�����б�����{{1}}!\", strKey, arr{0}ObjLst.length);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "$('#lblPageStatusContent').html(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"��������Key=[{0}]���ɹ�!\", strKey);");
            strCodeForCs.Append("\r\n" + "$('#lblPageStatusContent').html(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e) {");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"��������Key=[${strKey}]ʧ��:${e}!\");");
            strCodeForCs.Append("\r\n" + "console.error(strInfo);");
            strCodeForCs.Append("\r\n" + "$('#lblPageStatusContent').html(strInfo);");
            strCodeForCs.Append("\r\n" + "}  ");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_GetFldNameLst(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
                        
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��ȡ��ǰ����ֶ����б�");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\n" + "public static GetFldNameLst(func: (strKey: string) => any) {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetFldNameLst\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "const arrFldName: Array<string> = cls{0}EN.AttributeName;", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "const strFldNameLst1 = arrFldName.join(\",\");");
            strCodeForCs.Append("\r\n" + "clsFldComparisonObj.arrFldNameLst = arrFldName;");
            strCodeForCs.Append("\r\n" + "func(strFldNameLst1);");
            strCodeForCs.Append("\r\n" + "}");
            
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_GetArray(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��Html�ؼ�����ת����Array�б�");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\n" + "public static GetArray(arr): Array < HTMLElement > {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"GetArray\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "let arrLst: Array < HTMLElement > = new Array<HTMLElement>();");
            strCodeForCs.Append("\r\n" + "for (let i = 0; i < arr.length; i++)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const chk: HTMLElement = arr[i];// as HTMLElement;");
            strCodeForCs.Append("\r\n" + "arrLst.push(chk);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return arrLst;");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_GetLocalObjLst(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��ȡ��ǰ����ֶ����б�");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\n" + "   public static GetLocalObjLst(): Array < clsFldComparisonObj > {");
            strCodeForCs.Append("\r\n" + "const strFldComparisonObjLst = $(\"#hidFldComparisonObjLst\").val();");
                   strCodeForCs.Append("\r\n" + "if (strFldComparisonObjLst == null || strFldComparisonObjLst == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return new Array<clsFldComparisonObj>();");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "const arrFldComparisonObj: Array < clsFldComparisonObj > = JSON.parse(strFldComparisonObjLst);");
            strCodeForCs.Append("\r\n" + "return arrFldComparisonObj;");
            strCodeForCs.Append("\r\n" + "}");
            
            return strCodeForCs.ToString();
        }
        public string Gen_WApi_Ts_AddDPV_FldComparison(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��ȡ��ǰ����ֶ����б�");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\n" + "public static AddDPV_FldComparison(divName4Edit: string) {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"AddDPV_FldComparison\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "const objLst = document.getElementsByTagName(\"div\");");
            strCodeForCs.Append("\r\n" + "const strStartName = \"divEditFldComparison\";");
            strCodeForCs.AppendFormat("\r\n" + "let arrElement: Array < HTMLElement > = WApi{0}_UT_TS.GetArray(objLst) as Array<HTMLElement>;", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "let arrDiv: Array < HTMLDivElement > = arrElement as Array<HTMLDivElement>;");
            strCodeForCs.Append("\r\n" + "let arrFind: Array < HTMLDivElement > = arrDiv.filter(x => x.id.indexOf(strStartName) > -1);");
            strCodeForCs.Append("\r\n" + "arrFind.forEach(x => x.innerHTML = \"\");");
            
            strCodeForCs.Append("\r\n" + "const strUrl = \"../Test/_FldComparison/\";");
            strCodeForCs.Append("\r\n" + "//console.log(\"divName4Edit:(In AddDPV_FldComparison)\" + divName4Edit);");
            strCodeForCs.Append("\r\n" + "$.ajax({");
            strCodeForCs.Append("\r\n" + "url: strUrl,");
            strCodeForCs.Append("\r\n" + "method: \"GET\",");
            strCodeForCs.Append("\r\n" + "dataType: \"html\",");
            strCodeForCs.Append("\r\n" + "data: { },");
            strCodeForCs.Append("\r\n" + "success: function(data:any) {");
            strCodeForCs.Append("\r\n" + "console.log(\"�Ѿ��ɹ���ȡҳ��:\" + strUrl + \"  �ֽ���: \" + data.length.toString());");
            strCodeForCs.Append("\r\n" + "$('#' + divName4Edit).html(data);");
            strCodeForCs.Append("\r\n" + "//setTimeout(() => { clsFldComparisonObj.BindTab(); }, 100);");
            strCodeForCs.Append("\r\n" + "clsFldComparisonObj.BindTab();");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: (e:any) => {");
            strCodeForCs.Append("\r\n" + "console.error(e);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_btnClickGetFirstObj(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            //clsvFunction4GeneCodeEN objvFunction4GeneCodeEN
            //objvFunction4GeneCodeEN.FuncId4GC;
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��Ӧ�ĵ�һ����¼�Ķ���");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.Append("\r\n" + "export  async function " + this.tabNameHead + "btnGetFirstObj_Click() {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btnGetFirstObj_Click\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);


            //strCodeForCs.Append("\r\n" + "strWhereCond =\" 1=1 \";");
            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN = await {0}GetFirstObjAsync(strWhereCond);",
                objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "strWhereCond = $('#txtstrWhereCond{0}').val();",
                        objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"��������:[{{0}}] ��ȡ��һ����¼����{{1}}!\", strWhereCond, obj{0}EN.{1});",
                objPrjTabENEx.TabName,
                objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "this.Show{1}Obj(\"divList{0}\", obj{1}EN);",
    objvFunction4GeneCodeEN.OrderNum, objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"����������ȡ��Ӧ�ĵ�һ����¼�Ķ��󲻳ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

                   

            return strCodeForCs.ToString();
        }     

        public string Gen_WApi_Ts_btnClickGetObjLst(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��Ӧ�Ķ����б�");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "btnGetObjLst_Click() ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btnGetObjLst_Click\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            //            strCodeForCs.Append("\r\n" + "strWhereCond =\" 1=1 \";");
            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const arr{ThisTabName4GC}ObjLst = await {thisWA_F(WA_F.GetObjLstAsync)}(strWhereCond);");
                        
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"��������:[{{0}}]����ȡ�����б�����{{1}}!\", strWhereCond, arr{0}ObjLst.length);",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "//alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(\"divList{0}\", arr{1}ObjLst);",
         objvFunction4GeneCodeEN.OrderNum, objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"����������ȡ��Ӧ�Ķ����б��ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)"); 
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
     
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
       
            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_btnClickGetObjLstByKeyLst(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ���ݹؼ����б��ȡ��Ӧ�Ķ����б�");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "btnGetObjLstByKeyLst_Click() ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btnGetObjLstByKeyLst_Click\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            //            strCodeForCs.Append("\r\n" + "strWhereCond =\" 1=1 \";");
            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            //if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType == "number")
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "const arr{0}2:Array<string> = strKeyIdLst.split(',');", objKeyField.FldName);
            //    strCodeForCs.AppendFormat("\r\n" + "const arr{0}:Array<number> = arr{0}2.map(x=>Number(x));", objKeyField.FldName);
            //}
            //else
            //{
                strCodeForCs.AppendFormat("\r\n" + "const arr{0}:Array<string> = strKeyIdLst.split(',');", objKeyField.FldName);
            //}
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst = await {0}GetObjLstBy{1}LstAsync(arr{1});",
                objPrjTabENEx.TabName, objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"���ݹؼ����б�:[{{0}}]����ȡ�����б�����{{1}}!\", strKeyIdLst, arr{0}ObjLst.length);",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "//alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(\"divList{0}\", arr{1}ObjLst);",
         objvFunction4GeneCodeEN.OrderNum, objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"���ݹؼ����б��ȡ��Ӧ�����б��ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)"); 
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_btnClickGetObjLstByKeyLst_WACache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ���ݹؼ����б��ȡ��Ӧ�Ķ����б�");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "btnGetObjLstByKeyLst_WACache_Click() ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btnGetObjLstByKeyLst_WACache_Click\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            //            strCodeForCs.Append("\r\n" + "strWhereCond =\" 1=1 \";");
            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            //if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType == "number")
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "const arr{0}2:Array<string> = strKeyIdLst.split(',');", objKeyField.FldName);
            //    strCodeForCs.AppendFormat("\r\n" + "const arr{0}:Array<number> = arr{0}2.map(x=>Number(x));", objKeyField.FldName);
            //}
            //else
            //{
                strCodeForCs.AppendFormat("\r\n" + "const arr{0}:Array<string> = strKeyIdLst.split(',');", objKeyField.FldName);
            //}
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLs = await {0}GetObjLstBy{1}Lst_WACacheAsync(arr{1});",
                objPrjTabENEx.TabName, objKeyField.FldName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const {0}:{1} = {2}.{0}Cache;",
               objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
               objPrjTabENEx.objCacheClassifyFld.TypeScriptType, objPrjTabENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLs = await {0}GetObjLstBy{1}Lst_WACacheAsync(arr{1}, {2});",
                objPrjTabENEx.TabName, objKeyField.FldName, 
                objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }
            
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"���ݹؼ����б�:[{{0}}]����ȡ�����б�����{{1}}!\", strKeyIdLst, arr{0}ObjLst.length);",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "//alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(\"divList{0}\", arr{1}ObjLst);",
         objvFunction4GeneCodeEN.OrderNum, objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"���ݹؼ����б��ȡ��Ӧ�����б��ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_btnClickGetObjLstByKeyLstCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ���ݹؼ����б��ȡ��Ӧ�Ķ����б�");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "btnGetObjLstByKeyLstCache_Click() ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btnGetObjLstByKeyLstCache_Click\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            //            strCodeForCs.Append("\r\n" + "strWhereCond =\" 1=1 \";");
            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType == "number")
            {
                strCodeForCs.AppendFormat("\r\n" + "const arr{0}2:Array<string> = strKeyIdLst.split(',');", objKeyField.FldName);
                strCodeForCs.AppendFormat("\r\n" + "const arr{0}:Array<number> = arr{0}2.map(x=>Number(x));", objKeyField.FldName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const arr{0}:Array<string> = strKeyIdLst.split(',');", objKeyField.FldName);
            }
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst = await {0}GetObjLstBy{1}LstCache(arr{1});",
                objPrjTabENEx.TabName, objKeyField.FldName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const {0}:{1} = {2}.{0}Cache;",
               objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
               objPrjTabENEx.objCacheClassifyFld.TypeScriptType, objPrjTabENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst = await {0}GetObjLstBy{1}LstCache(arr{1}, {2});",
                objPrjTabENEx.TabName, objKeyField.FldName,
                objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }
            
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"���ݹؼ����б�:[{{0}}]����ȡ�����б�����{{1}}!\", strKeyIdLst, arr{0}ObjLst.length);",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "//alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(\"divList{0}\", arr{1}ObjLst);",
         objvFunction4GeneCodeEN.OrderNum, objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"���ݹؼ����б��ȡ��Ӧ�����б��ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_UT_GetObjLst4DdlBind(string strTabName, string strValueFld, string strTextFld)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��Ӧ�Ķ����б�");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "btnGetObjLst_Click() ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btnGetObjLst_Click\";",
         objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "strWhereCond =\" 1=1 \";");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const arr{ThisTabName4GC}ObjLst: Array<cls{ThisTabName4GC}EN> = await {thisWA_F(WA_F.GetObjLstAsync)}(strWhereCond);");
                   
            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN objFirstObj = new cls{0}EN();", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "objFirstObj.{0} = \"0\";",
               strValueFld, strTextFld);
            strCodeForCs.AppendFormat("\r\n" + "objFirstObj.{0} = \"��ѡ��...\";", strTextFld);
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst.add(0, objFirstObj);",
                strTabName);
            strCodeForCs.AppendFormat("\r\n" + "{1}.arr{0}ObjLstCache = arr{0}ObjLst;",
                strTabName, objPrjTabENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "mspnObject.setPrompt(\"��ѡ������{0}: \");", objPrjTabENEx.TabCnName);

            strCodeForCs.AppendFormat("\r\n" + "if (mobjDdlAdapter{0} == null)", strTabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "mobjDdlAdapter{0} = new ddlAdapter{0}(macPage, arr{0}ObjLst);",
                strTabName);
            strCodeForCs.Append("\r\n" + "}");
            //            userStateAdapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
            strCodeForCs.AppendFormat("\r\n" + "mspnObject.setAdapter(mobjDdlAdapter{0});",
                strTabName);
            //strCodeForCs.Append("\r\n" + "SendMessage(\"û��ʹ�û���!\");");
            strCodeForCs.AppendFormat("\r\n" + "mobjParentObjDelegate.NotifyFinished(\"BindDdl_{0}, û��ʹ�û���!\", 1);",
                strTabName);

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"����������ȡ���������Ӧ�����б��ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_btnClickGetTopObjLst(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��Ӧ�Ķ��������б�");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "btnGetTopObjLst_Click() ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btnGetTopObjLst_Click\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            strCodeForCs.Append("\r\n" + "const objTopPara: stuTopPara =");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "whereCond: strWhereCond,");
            strCodeForCs.Append("\r\n" + "topSize: intTopSize,");
            strCodeForCs.Append("\r\n" + "orderBy: \"\",");
            strCodeForCs.Append("\r\n" + "IsCheckSQLAttack: \"false\",");
            strCodeForCs.Append("\r\n" + "Exclude:\"\"");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst = await {0}GetTopObjLstAsync(objTopPara);",
                objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"��������:[{{0}}],������:[{{1}}]����ȡ���������б�����{{2}}!\", strWhereCond, intTopSize, arr{0}ObjLst.length);",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "//alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(\"divList{0}\", arr{1}ObjLst);",
  objvFunction4GeneCodeEN.OrderNum, objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"����������ȡ��Ӧ�Ķ��������б��ɹ�, {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
       
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_btnClickGetObjLstByPager(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��Ӧ�ķ�ҳ�����б�");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "btnGetObjLstByPager_Click() ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btnGetObjLstByPager_Click\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            //strCodeForCs.Append("\r\n" + "Integer intPageIndex = 2;");
            //strCodeForCs.Append("\r\n" + "Integer intPageSize = 2;");
            //strCodeForCs.Append("\r\n" + "strWhereCond =\" 1=1 \";");
            //strCodeForCs.Append("\r\n" + "string strOrderBy =\"\";");

            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            strCodeForCs.Append("\r\n" + GC_GetObjExLst(enumRegionType.ListRegion_0002, ""));
                        
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"��������:[{{0}}],ÿҳ��¼��:[{{1}}],��[{{2}}]ҳ,����ȡ��ҳ�����б�����{{3}}!\", strWhereCond, intPageSize, intPageIndex, arr{0}ObjLst.length);",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "//alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(\"divList{0}\", arr{1}ObjLst);",
  objvFunction4GeneCodeEN.OrderNum, objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"����������ȡ��Ӧ�ķ�ҳ�����б��ɹ�, {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.Append("\r\n" + "}");
         
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_btnClickGetObjLstByPager_WACache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��Ӧ�ķ�ҳ�����б�");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "btnGetObjLstByPager_WACache_Click() ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btnGetObjLstByPager_WACache_Click\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
    
            //strCodeForCs.Append("\r\n" + "Integer intPageIndex = 2;");
            //strCodeForCs.Append("\r\n" + "Integer intPageSize = 2;");
            //strCodeForCs.Append("\r\n" + "strWhereCond =\" 1=1 \";");
            //strCodeForCs.Append("\r\n" + "string strOrderBy =\"\";");

            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);

            strCodeForCs.AppendFormat("\r\n" + "const obj{0}Cond = new cls{0}EN();", objPrjTabENEx.TabName);
            if (objPrjTabENEx.objCacheClassifyFld != null)
            {
                strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue(cls{0}EN.con_{1},{2}, \"=\");", objPrjTabENEx.TabName,
                    objPrjTabENEx.objCacheClassifyFld.FldName, thisCacheClassify4View.VarDef4Fld);
            }
            else
            {
                //strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue(cls{0}EN.con_{1},\"{2}1\", \"=\");", objPrjTabENEx.TabName,
                //    objKeyField.FldName, clsString.combineStrS("9", objKeyField.ObjFieldTabENEx.FldLength - 1));
            }

            strCodeForCs.AppendFormat("\r\n" + "const arrFldComparisonObj = WApi{0}_UT_TS.GetLocalObjLst();", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "//console.log(`�ֶαȽ϶����¼��(���ػ�ȡ)��${ arrFldComparisonObj.length}`);");
            strCodeForCs.AppendFormat("\r\n" + "arrFldComparisonObj.forEach(x => {{ obj{0}Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); }});",
                objPrjTabENEx.TabName);


            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN_Sim = cls{0}BL.GetSimObjFromObj(obj{0}Cond);", objPrjTabENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "//console.log(obj{0}EN_Sim);", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "strWhereCond = JSON.stringify(obj{0}EN_Sim);", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + GC_GetObjExLst(enumRegionType.ListRegion_0002, ""));

            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"��������:[{{0}}],ÿҳ��¼��:[{{1}}],��[{{2}}]ҳ,����ȡ��ҳ�����б�����{{3}}!\", strWhereCond, intPageSize, intPageIndex, arr{0}ObjLst.length);",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "//alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(\"divList{0}\", arr{1}ObjLst);",
  objvFunction4GeneCodeEN.OrderNum, objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"����������ȡ��Ӧ�ķ�ҳ�����б��ɹ�, {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_btnClickGetObjLstByPagerCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��Ӧ�ķ�ҳ�����б�");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "btnGetObjLstByPagerCache_Click() ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btnGetObjLstByPagerCache_Click\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            //strCodeForCs.Append("\r\n" + "Integer intPageIndex = 2;");
            //strCodeForCs.Append("\r\n" + "Integer intPageSize = 2;");
            //strCodeForCs.Append("\r\n" + "strWhereCond =\" 1=1 \";");
            //strCodeForCs.Append("\r\n" + "string strOrderBy =\"\";");

            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);

            strCodeForCs.AppendFormat("\r\n" + "const obj{0}Cond = new cls{0}EN();", objPrjTabENEx.TabName);
            if (objPrjTabENEx.objCacheClassifyFld != null)
            {
                strCodeForCs.AppendFormat("\r\n" + "const {0}:{1} = {2}.{0}Cache;",
                 objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
                 objPrjTabENEx.objCacheClassifyFld.TypeScriptType, objPrjTabENEx.ClsName);

                strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue(cls{0}EN.con_{1},{2}, \"=\");", objPrjTabENEx.TabName,
                    objPrjTabENEx.objCacheClassifyFld.FldName, thisCacheClassify4View.VarDef4Fld);
            }
            else
            {
                //strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue(cls{0}EN.con_{1},\"{2}1\", \"=\");", objPrjTabENEx.TabName,
                //    objKeyField.FldName, clsString.combineStrS("9", objKeyField.ObjFieldTabENEx.FldLength - 1));
            }
            strCodeForCs.AppendFormat("\r\n" + "const arrFldComparisonObj = WApi{0}_UT_TS.GetLocalObjLst();", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "//console.log(`�ֶαȽ϶����¼��(���ػ�ȡ)��${ arrFldComparisonObj.length}`);");
            strCodeForCs.AppendFormat("\r\n" + "arrFldComparisonObj.forEach(x => {{ obj{0}Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); }});",
                objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN_Sim = cls{0}BL.GetSimObjFromObj(obj{0}Cond);", objPrjTabENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "//console.log(obj{0}EN_Sim);", objPrjTabENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "strWhereCond = JSON.stringify(obj{0}EN_Sim);", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + GC_GetObjExLst(enumRegionType.ListRegion_0002, ""));

            //strCodeForCs.Append("\r\n" + "const objPagerPara: stuPagerPara = {");
            //strCodeForCs.Append("\r\n" + "pageIndex: intPageIndex,");
            //strCodeForCs.Append("\r\n" + "pageSize: intPageSize,");
            //strCodeForCs.Append("\r\n" + "whereCond: strWhereCond,");
            //strCodeForCs.Append("\r\n" + "orderBy: strOrderBy,");
            //strCodeForCs.Append("\r\n" + "sortFun: (x, y) => { console.log(x,y);return 0;}");
            //strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "try");
            //strCodeForCs.Append("\r\n" + "{");

            //if (objPrjTabENEx.objCacheClassifyFld == null)
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst = await {0}GetObjLstByPagerCache(objPagerPara);",
            //    objPrjTabENEx.TabName);
            //}
            //else
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst = await {0}GetObjLstByPagerCache(objPagerPara, {1});",
            //    objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            //}
            
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"��������:[{{0}}],ÿҳ��¼��:[{{1}}],��[{{2}}]ҳ,����ȡ��ҳ�����б�����{{3}}!\", strWhereCond, intPageSize, intPageIndex, arr{0}ObjLst.length);",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "//alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(\"divList{0}\", arr{1}ObjLst);",
  objvFunction4GeneCodeEN.OrderNum, objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"����������ȡ��Ӧ�ķ�ҳ�����б��ɹ�, {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_btnClickGetSubObjLstCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {


            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��Ӧ�ķ�ҳ�����б�");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "btnGetSubObjLstCache_Click() ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btnGetSubObjLstCache_Click\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            //strCodeForCs.Append("\r\n" + "Integer intPageIndex = 2;");
            //strCodeForCs.Append("\r\n" + "Integer intPageSize = 2;");
            //strCodeForCs.Append("\r\n" + "strWhereCond =\" 1=1 \";");
            //strCodeForCs.Append("\r\n" + "string strOrderBy =\"\";");

            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);

            strCodeForCs.AppendFormat("\r\n" + "const obj{0}Cond = new cls{0}EN();", objPrjTabENEx.TabName);
            if (objPrjTabENEx.objCacheClassifyFld != null)
            {
                strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue(cls{0}EN.con_{1}, {2}, \"=\");", objPrjTabENEx.TabName,
                    objPrjTabENEx.objCacheClassifyFld.FldName, thisCacheClassify4View.VarDef4Fld);
            }
            else
            {
                //strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue(cls{0}EN.con_{1},\"{2}1\", \"=\");", objPrjTabENEx.TabName,
                //    objKeyField.FldName, clsString.combineStrS("9", objKeyField.ObjFieldTabENEx.FldLength - 1));
            }
            strCodeForCs.AppendFormat("\r\n" + "const arrFldComparisonObj = WApi{0}_UT_TS.GetLocalObjLst();", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "//console.log(`�ֶαȽ϶����¼��(���ػ�ȡ)��${ arrFldComparisonObj.length}`);");
            strCodeForCs.AppendFormat("\r\n" + "arrFldComparisonObj.forEach(x => {{ obj{0}Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); }});",
                objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN_Sim = cls{0}BL.GetSimObjFromObj(obj{0}Cond);", objPrjTabENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "//console.log(obj{0}EN_Sim);", objPrjTabENEx.TabName);
      
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.Append("\r\n" + $"const arr{0}ObjLst = await {thisWA_F(WA_F.GetSubObjLstCache)}(obj{ThisTabName4GC}Cond);");
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const {0}:{1} = {2}.{0}Cache;",
       objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
       objPrjTabENEx.objCacheClassifyFld.TypeScriptType, objPrjTabENEx.ClsName);
                strCodeForCs.Append("\r\n" + $"const arr{0}ObjLst = await {thisWA_F(WA_F.GetSubObjLstCache)}(obj{ThisTabName4GC}Cond, {objPrjTabENEx.objCacheClassifyFld.PrivFuncName});");
            }

            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"��������:[{{0}}],����ȡ�����б��Ӽ�����{{1}}!\", JSON.stringify(obj{0}Cond), arr{0}ObjLst.length);",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "//alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(\"divList{0}\", arr{1}ObjLst);",
  objvFunction4GeneCodeEN.OrderNum, objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"�������������ȡ��Ӧ�Ķ����б��Ӽ����ɹ�, {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_btnClickGetSubObjLst_WACache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {


            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��Ӧ�ķ�ҳ�����б�");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "btnGetSubObjLst_WACache_Click() ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btnGetSubObjLst_WACache_Click\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            //strCodeForCs.Append("\r\n" + "Integer intPageIndex = 2;");
            //strCodeForCs.Append("\r\n" + "Integer intPageSize = 2;");
            //strCodeForCs.Append("\r\n" + "strWhereCond =\" 1=1 \";");
            //strCodeForCs.Append("\r\n" + "string strOrderBy =\"\";");

            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);

            strCodeForCs.AppendFormat("\r\n" + "const obj{0}Cond = new cls{0}EN();", objPrjTabENEx.TabName);
            if (objPrjTabENEx.objCacheClassifyFld != null)
            {
                strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue(cls{0}EN.con_{1},{2}, \"=\");", objPrjTabENEx.TabName,
                    objPrjTabENEx.objCacheClassifyFld.FldName, thisCacheClassify4View.VarDef4Fld);
            }
            else
            {
                //strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue(cls{0}EN.con_{1},\"{2}1\", \"=\");", objPrjTabENEx.TabName,
                //    objKeyField.FldName, clsString.combineStrS("9", objKeyField.ObjFieldTabENEx.FldLength - 1));
            }
            strCodeForCs.AppendFormat("\r\n" + "const arrFldComparisonObj = WApi{0}_UT_TS.GetLocalObjLst();", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "//console.log(`�ֶαȽ϶����¼��(���ػ�ȡ)��${ arrFldComparisonObj.length}`);");
            strCodeForCs.AppendFormat("\r\n" + "arrFldComparisonObj.forEach(x => {{ obj{0}Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); }});",
                objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN_Sim = cls{0}BL.GetSimObjFromObj(obj{0}Cond);", objPrjTabENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "//console.log(obj{0}EN_Sim);", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            //if (objPrjTabENEx.objCacheClassifyFld == null)
            //{
                strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst = await {0}GetSubObjLst_WACacheAsync(obj{0}Cond);",
                objPrjTabENEx.TabName);
            //     }
            //     else
            //     {
            //         strCodeForCs.AppendFormat("\r\n" + "const {0}:{1} = \"{2}1\";",
            //objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
            //objPrjTabENEx.objCacheClassifyFld.TypeScriptType, clsString.combineStrS("9", objPrjTabENEx.objCacheClassifyFld.ObjFieldTabENEx.FldLength - 1));
            //         strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst = await {0}GetSubObjLst_WACacheAsync(obj{0}Cond, {1});",
            //     objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            //     }

            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"��������:[{{0}}],����ȡ�����б��Ӽ�����{{1}}!\", JSON.stringify(obj{0}Cond), arr{0}ObjLst.length);",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "//alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(\"divList{0}\", arr{1}ObjLst);",
  objvFunction4GeneCodeEN.OrderNum, objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"�������������ȡ��Ӧ�Ķ����б��Ӽ����ɹ�, {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_btnClickGetObjLstByRange(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����������ȡ��Χ����Ӧ�Ķ����б�");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "btnGetObjLstByRange_Click() ",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btnGetObjLstByRange_Click\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);


            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            strCodeForCs.Append("\r\n" + "const objRangePara: stuRangePara = {");
            strCodeForCs.Append("\r\n" + "  MaxNum: intMaxNum,");
            strCodeForCs.Append("\r\n" + "MinNum: intMinNum,");
            strCodeForCs.Append("\r\n" + "whereCond: strWhereCond,");
            strCodeForCs.Append("\r\n" + "orderBy: strOrderBy");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst = await {0}GetObjLstByRangeAsync(objRangePara);",
                objPrjTabENEx.TabName);
            
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"��������:[{{0}}],��С��¼��:[{{1}}],����¼��:[{{2}}],����ȡ��ҳ�����б�����{{3}}!\", strWhereCond, intMinNum, intMaxNum, arr{0}ObjLst.length);",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "//alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(\"divList{0}\", arr{1}ObjLst);",
  objvFunction4GeneCodeEN.OrderNum, objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"����������ȡ��Χ����Ӧ�Ķ����б��ɹ�, {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
  
            return strCodeForCs.ToString();
        }

      

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��� 
        /// </summary>
        /// <returns></returns>
        public string Gen_WApi_Ts_btnClickIsExistRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// �����Ӧ�ؼ��ֵļ�¼�Ƿ����");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">������</param>");
            strCodeForCs.Append("\r\n /// <returns>�����Ƿ����</returns>");

            strCodeForCs.Append("\r\n" + "export  async function " + this.tabNameHead + "btnIsExistRecord_Click() {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btnIsExistRecord_Click\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);


            //strCodeForCs.AppendFormat("\r\n" + "strWhereCond = \"{0} ='12'\";",
            //    objKeyField.FldName);
            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const returnBool = await {thisWA_F(WA_F.IsExistRecordAsync)}(strWhereCond);");

            strCodeForCs.Append("\r\n" + "if (returnBool == false)");
            strCodeForCs.Append("\r\n" + "{");
     
            strCodeForCs.AppendFormat("\r\n" + "strWhereCond = $('#txtstrWhereCond{0}').val();",
                objvFunction4GeneCodeEN.OrderNum);

            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"��������:[{{0}}] �ļ�¼������!\", strWhereCond);",
                objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            
            strCodeForCs.AppendFormat("\r\n" + "strWhereCond = $('#txtstrWhereCond{0}').val();",
                objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"��������:[{{0}}]����ؼ�¼����!\", strWhereCond);",
                objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"��������ļ�¼���ڲ��ɹ�, ${(e)}.\");");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_btnClickIsExistRecordCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// �����Ӧ�ؼ��ֵļ�¼�Ƿ����");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">������</param>");
            strCodeForCs.Append("\r\n /// <returns>�����Ƿ����</returns>");

            strCodeForCs.Append("\r\n" + "export  async function " + this.tabNameHead + "btnIsExistRecordCache_Click() {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btnIsExistRecordCache_Click\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
            
            //strCodeForCs.AppendFormat("\r\n" + "strWhereCond = \"{0} ='12'\";",
            //    objKeyField.FldName);
            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);

            strCodeForCs.AppendFormat("\r\n" + "const obj{0}Cond = new cls{0}EN();", objPrjTabENEx.TabName);
            if (objPrjTabENEx.objCacheClassifyFld != null)
            {
                strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue(cls{0}EN.con_{1}, {2}, \"=\");", objPrjTabENEx.TabName,
                    objPrjTabENEx.objCacheClassifyFld.FldName, thisCacheClassify4View.VarDef4Fld);
            }
            else
            {
                //strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue(cls{0}EN.con_{1},\"{2}1\", \"=\");", objPrjTabENEx.TabName,
                //    objKeyField.FldName, clsString.combineStrS("9", objKeyField.ObjFieldTabENEx.FldLength - 1));
            }

            strCodeForCs.AppendFormat("\r\n" + "const arrFldComparisonObj = WApi{0}_UT_TS.GetLocalObjLst();", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "//console.log(`�ֶαȽ϶����¼��(���ػ�ȡ)��${ arrFldComparisonObj.length}`);");
            strCodeForCs.AppendFormat("\r\n" + "arrFldComparisonObj.forEach(x => {{ obj{0}Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); }});",
                objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN_Sim = cls{0}BL.GetSimObjFromObj(obj{0}Cond);", objPrjTabENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "//console.log(obj{0}EN_Sim);", objPrjTabENEx.TabName);


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "await {0}IsExistRecordCache(obj{0}Cond);",
                objPrjTabENEx.TabName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const {0}:{1} = {2}.{0}Cache;",
       objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
       objPrjTabENEx.objCacheClassifyFld.TypeScriptType, objPrjTabENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n" + "const returnBool = await {0}IsExistRecordCache(obj{0}Cond, {1});",
                objPrjTabENEx.TabName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }

            strCodeForCs.Append("\r\n" + "if (returnBool == false)");
            strCodeForCs.Append("\r\n" + "{");
                        
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"��������:[{{0}}]�ļ�¼������!\", JSON.stringify(obj{0}Cond));",
                objPrjTabENEx.TabName); 

            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"��������:[{{0}}]����ؼ�¼����!\", JSON.stringify(obj{0}Cond));",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"��������ļ�¼���ڲ��ɹ�, ${(e)}.\");");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��� 
        /// </summary>
        /// <returns></returns>
        public string Gen_WApi_Ts_btnClickIsExist(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// �����Ӧ�ؼ��ֵļ�¼�Ƿ����");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">������</param>");
            strCodeForCs.Append("\r\n /// <returns>�����Ƿ����</returns>");

            strCodeForCs.Append("\r\n" + "export  async function " + this.tabNameHead + "btnIsExist_Click() {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btnIsExist_Click\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;
            strCodeForCs.AppendFormat("\r\n" + "const strKeyId: string = $('#txtstrKeyId{0}').val();",
                  objvFunction4GeneCodeEN.OrderNum);
            if (objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strCodeForCs.AppendFormat("\r\n" + "const {0}: {1} = strKeyId;",
                  objKeyField.PrivFuncName,
                  objKeyField.TypeScriptType);
            }
            else
            {
                switch (objDataTypeAbbrEN.DataTypeId)
                {
                    case enumDataTypeAbbr.float_07:
                    case enumDataTypeAbbr.int_09:
                    case enumDataTypeAbbr.money_11:
                    case enumDataTypeAbbr.bigint_01:
                    case enumDataTypeAbbr.bigintidentity_26:

                        strCodeForCs.AppendFormat("\r\n" + "const {1}: {0} = Number(strKeyId);",
                            objDataTypeAbbrEN.TypeScriptType,
                            objKeyField.PrivFuncName);
                        break;
                    default:
                        string strMsg = string.Format("�������ͣ�[{0}({1})](TypeScript:{2})�ں�����û�д���!({3})",
                            objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                            objDataTypeAbbrEN.TypeScriptType,
                            clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                }
            }
            //strCodeForCs.AppendFormat("\r\n" + "strWhereCond = \"{0} ='12'\";",
            //    objKeyField.FldName);
            //GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const returnBool = await {thisWA_F(WA_F.IsExistAsync)}({objKeyField.PrivFuncName});");
                        
            strCodeForCs.Append("\r\n" + "if (returnBool == false)");
            strCodeForCs.Append("\r\n" + "{");

            //strCodeForCs.AppendFormat("\r\n" + "strWhereCond = $('#txtstrWhereCond{0}').val();",
            //    objvFunction4GeneCodeEN.OrderNum);

            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"�ؼ���:[{{0}}] �ļ�¼������!\", strKeyId);",
                objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");

            //strCodeForCs.AppendFormat("\r\n" + "strWhereCond = $('#txtstrWhereCond{0}').val();",
            //    objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"�ؼ���:[{{0}}]����ؼ�¼����!\", strKeyId);",
                objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"�����Ӧ�ؼ��ֵļ�¼���ڲ��ɹ�, {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_btnClickIsExistCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// �����Ӧ�ؼ��ֵļ�¼�Ƿ����");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">������</param>");
            strCodeForCs.Append("\r\n /// <returns>�����Ƿ����</returns>");

            strCodeForCs.Append("\r\n" + "export  async function " + this.tabNameHead + "btnIsExistCache_Click() {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btnIsExistCache_Click\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;
            strCodeForCs.AppendFormat("\r\n" + "const strKeyId: string = $('#txtstrKeyId{0}').val();",
                  objvFunction4GeneCodeEN.OrderNum);
            if (objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strCodeForCs.AppendFormat("\r\n" + "const {0}: {1} = strKeyId;",
                  objKeyField.PrivFuncName,
                  objKeyField.TypeScriptType);
            }
            else
            {
                switch (objDataTypeAbbrEN.DataTypeId)
                {
                    case enumDataTypeAbbr.float_07:
                    case enumDataTypeAbbr.int_09:
                    case enumDataTypeAbbr.money_11:
                    case enumDataTypeAbbr.bigint_01:
                    case enumDataTypeAbbr.bigintidentity_26:

                        strCodeForCs.AppendFormat("\r\n" + "const {1}: {0} = Number(strKeyId);",
                            objDataTypeAbbrEN.TypeScriptType,
                            objKeyField.PrivFuncName);
                        break;
                    default:
                        string strMsg = string.Format("�������ͣ�[{0}({1})](TypeScript:{2})�ں�����û�д���!({3})",
                            objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                            objDataTypeAbbrEN.TypeScriptType,
                            clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                }
            }
            //strCodeForCs.AppendFormat("\r\n" + "strWhereCond = \"{0} ='12'\";",
            //    objKeyField.FldName);
            //GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "await {0}IsExistCache({1});",
                objPrjTabENEx.TabName,
                objKeyField.PrivFuncName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const {0}:{1} = {2}.{0}Cache;",
objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
objPrjTabENEx.objCacheClassifyFld.TypeScriptType, objPrjTabENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n" + "const returnBool = await {0}IsExistCache({1}, {2});",
                objPrjTabENEx.TabName,
                objKeyField.PrivFuncName, objPrjTabENEx.objCacheClassifyFld.PrivFuncName);
            }
            
            strCodeForCs.Append("\r\n" + "if (returnBool == false)");
            strCodeForCs.Append("\r\n" + "{");

            //strCodeForCs.AppendFormat("\r\n" + "strWhereCond = $('#txtstrWhereCond{0}').val();",
            //    objvFunction4GeneCodeEN.OrderNum);

            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"�ؼ���:[{{0}}] �ļ�¼������!\", strKeyId);",
                objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");

            //strCodeForCs.AppendFormat("\r\n" + "strWhereCond = $('#txtstrWhereCond{0}').val();",
            //    objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"�ؼ���:[{{0}}]����ؼ�¼����!\", strKeyId);",
                objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"�����Ӧ�ؼ��ֵļ�¼���ڲ��ɹ�, {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��� 
        /// </summary>
        /// <returns></returns>
        public string Gen_WApi_Ts_btnClickGetRecCountByCond(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��ȡĳһ�����ļ�¼��");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">������</param>");
            strCodeForCs.Append("\r\n /// <returns>�����Ƿ����</returns>");

            strCodeForCs.Append("\r\n" + "export  async function " + this.tabNameHead + "btnGetRecCountByCond_Click() {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btnGetRecCountByCond_Click\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);


            //strCodeForCs.AppendFormat("\r\n" + "strWhereCond = \"{0} ='12'\";",
            //    objKeyField.FldName);
            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const responseText = await {thisWA_F_InList(WA_F.GetRecCountByCondAsync)}(strWhereCond);");

            strCodeForCs.Append("\r\n" + "const returnInt: number = Number(responseText);");

            strCodeForCs.AppendFormat("\r\n" + "strWhereCond = $('#txtstrWhereCond{0}').val();",
                objvFunction4GeneCodeEN.OrderNum);

            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"��������:{{0}}�ļ�¼��:{{1}}!\", strWhereCond, returnInt);",
                objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"��ȡĳһ�����ļ�¼�����ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_btnClickGetRecCountByCondCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��ȡĳһ�����ļ�¼��");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">������</param>");
            strCodeForCs.Append("\r\n /// <returns>�����Ƿ����</returns>");

            strCodeForCs.Append("\r\n" + "export  async function " + this.tabNameHead + "btnGetRecCountByCondCache_Click() {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btnGetRecCountByCondCache_Click\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);


            //strCodeForCs.AppendFormat("\r\n" + "strWhereCond = \"{0} ='12'\";",
            //    objKeyField.FldName);
            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);

            strCodeForCs.AppendFormat("\r\n" + "const obj{0}Cond = new cls{0}EN();", objPrjTabENEx.TabName);
            if (objPrjTabENEx.objCacheClassifyFld != null)
            {
                strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue(cls{0}EN.con_{1},{2}, \"=\");", objPrjTabENEx.TabName,
                    objPrjTabENEx.objCacheClassifyFld.FldName, thisCacheClassify4View.VarDef4Fld);
            }
            else
            {
                //strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue(cls{0}EN.con_{1},\"{2}1\", \"=\");", objPrjTabENEx.TabName,
                //    objKeyField.FldName, clsString.combineStrS("9", objKeyField.ObjFieldTabENEx.FldLength - 1));
            }

            strCodeForCs.AppendFormat("\r\n" + "const arrFldComparisonObj = WApi{0}_UT_TS.GetLocalObjLst();", objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "//console.log(`�ֶαȽ϶����¼��(���ػ�ȡ)��${ arrFldComparisonObj.length}`);");
            strCodeForCs.AppendFormat("\r\n" + "arrFldComparisonObj.forEach(x => {{ obj{0}Cond.SetCondFldValue(x.FldName, x.FldValue, x.ComparisonOperator); }});",
                objPrjTabENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN_Sim = cls{0}BL.GetSimObjFromObj(obj{0}Cond);", objPrjTabENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "//console.log(obj{0}EN_Sim);", objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            if (objPrjTabENEx.objCacheClassifyFld == null)
            {
                strCodeForCs.Append("\r\n" + $"await {thisWA_F(WA_F.GetRecCountByCondCache)}(obj{ThisTabName4GC}Cond);");
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const {0}:{1} = {2};",
objPrjTabENEx.objCacheClassifyFld.PrivFuncName,
objPrjTabENEx.objCacheClassifyFld.TypeScriptType, thisCacheClassify4View.VarDef4Fld);
                strCodeForCs.Append("\r\n" + $"const responseText = await {thisWA_F(WA_F.GetRecCountByCondCache)}(obj{ThisTabName4GC}Cond, {objPrjTabENEx.objCacheClassifyFld.PrivFuncName});");
            }
            strCodeForCs.Append("\r\n" + "const returnInt: number = Number(responseText);");
                        
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"��������:[{{0}}]�ļ�¼��:{{1}}!\", JSON.stringify(obj{0}Cond), returnInt);",
                    objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"��ȡĳһ�����ļ�¼�����ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }




        public string Gen_WApi_Ts_btnClickDelRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ɾ����¼");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\n" + "export  async function " + this.tabNameHead + "btnDelRecord_Click() {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btnDelRecord_Click\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            strCodeForCs.AppendFormat("\r\n" + "const strKeyId: string = $('#txtstrKeyId{0}').val();",
                  objvFunction4GeneCodeEN.OrderNum);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;

            if (objDataTypeAbbrEN.IsNeedQuote == true)
            {
                strCodeForCs.AppendFormat("\r\n" + "const {0}: {1} = strKeyId;",
                  objKeyField.PrivFuncName,
                  objKeyField.TypeScriptType);
            }
            else
            {
                switch (objDataTypeAbbrEN.DataTypeId)
                {
                    case enumDataTypeAbbr.float_07:
                    case enumDataTypeAbbr.int_09:
                    case enumDataTypeAbbr.money_11:
                    case enumDataTypeAbbr.bigint_01:
                    case enumDataTypeAbbr.bigintidentity_26:

                        strCodeForCs.AppendFormat("\r\n" + "const {1}: {0} = Number(strKeyId);",
                            objDataTypeAbbrEN.TypeScriptType,
                            objKeyField.PrivFuncName);
                        break;
                    
                    default:
                        string strMsg = string.Format("�������ͣ�[{0}({1})](TypeScript:{2})�ں�����û�д���!({3})",
                            objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                            objDataTypeAbbrEN.TypeScriptType,
                            clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                }
            }
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const returnInt = await {thisWA_F(WA_F.DelRecordAsync)}({objKeyField.PrivFuncName});");

            strCodeForCs.Append("\r\n" + "if (returnInt > 0)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"ɾ����¼�ɹ�, ��ɾ����${returnInt}����¼!\");");

            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"ɾ����¼���ɹ�!\");");

            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"ɾ����¼���ɹ�. {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
        
            return strCodeForCs.ToString();
        }
        public string Gen_WApi_Ts_btnClickDelRecords(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ɾ����¼");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\n" + "export  async function " + this.tabNameHead + "btnDelRecords_Click() {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btnDelRecords_Click\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            strCodeForCs.AppendFormat("\r\n" + "string strKeyIdLst = txtstrKeyIdLst{0}.Text.Trim();",
                  objvFunction4GeneCodeEN.OrderNum);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const responseText = await {0}DelRecordsAsync(strKeyIdLst);",
                objPrjTabENEx.TabName,
                objKeyField.PrivFuncName);

            strCodeForCs.Append("\r\n" + "const returnInt: number = Number(responseText);");

            strCodeForCs.Append("\r\n" + "if (returnInt > 0)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"ɾ����¼�ɹ�,��ɾ��{0}����¼!\", returnInt);");

            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"ɾ����¼���ɹ�!\");");

            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"ɾ����¼���ɹ�. {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
         
            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_btnClickDelMultiRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName4Code = TransKeyWords4FuncName(objvFunction4GeneCodeEN.FuncName4Code);


            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ���ݹؼ����б�ɾ����¼");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "btn{0}_Click() {{",
                strFuncName4Code);
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btn{0}_Click\";",        strFuncName4Code, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
            //   GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);

            strCodeForCs.AppendFormat("\r\n" + "const strKeyIdLst:string = $('#txtarrKeyId{0}').val();",
                  objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}:Array<string> = strKeyIdLst.split(',');", objKeyField.FldName);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const returnInt = await {thisWA_F(WA_F.DelMultiRecordAsync)}(arr{objKeyField.FldName});");

            strCodeForCs.Append("\r\n" + "if (returnInt > 0)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"ɾ����¼�ɹ�,��ɾ��{0}����¼!\", returnInt);");

            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"ɾ����¼���ɹ�!\");");

            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"ɾ����¼���ɹ�. {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_btnClickDelMultiRecordByCond(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��������ɾ��������¼");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\n" + "export  async function " + this.tabNameHead + "btnDelMultiRecordByCond_Click() {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btnDelMultiRecordByCond_Click\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            //strCodeForCs.AppendFormat("\r\n" + "const strKeyIdLst:string = $('#txtstrKeyIdLst{0}').val();",
            //      objvFunction4GeneCodeEN.OrderNum);
            //strCodeForCs.AppendFormat("\r\n" + "const arr{0}:Array<string> = strKeyIdLst.split(',');", objKeyField.FldName);
            //clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const returnInt = await {thisWA_F(WA_F.DelMultiRecordByCondAsync)}(strWhereCond);");

            strCodeForCs.Append("\r\n" + "if (returnInt > 0)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"ɾ����¼�ɹ�,��ɾ��{0}����¼!\", returnInt);");

            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"ɾ����¼���ɹ�!\");");

            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"ɾ����¼���ɹ�. {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Ts_btnClickByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            string strMsg = "";
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// {0}", objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
          //  strCodeForCs.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "btn{0}_Click() ",
                objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btn{0}_Click\";",        objWebSrvFunctionsENEx.FunctionName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objWebSrvFunctionsENEx.FunctionName);

            strCodeForCs.AppendFormat("\r\n" + "{0}WS4SDController obj{0}WS4SDController = new {0}WS4SDController();",
                objWebSrvClassENEx.ClsName);

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
                    strMsg = string.Format("Java���������Ĳ����������Ͳ�������������[{0}],�������ͣ�[{1}]û�д���,����������Ӧ���롣",
                       objWebSrvFuncParaEN.ParaName,
                         objWebSrvFuncParaEN.ParameterType);
                    throw new Exception(strMsg);
                }
                else
                {
                    if (objDataTypeAbbrEN.IsNeedQuote == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "{0} {1} = txt{2}.Text.Trim();",
                            objDataTypeAbbrEN.CsType,
                            objWebSrvFuncParaEN.ParaName,
                            objWebSrvFuncParaEN._StrTag);
                    }
                    else
                    {
                        switch (objWebSrvFuncParaEN.DataTypeId)
                        {
                            case enumDataTypeAbbr.float_07:
                                strCodeForCs.AppendFormat("\r\n" + "{0} {1} = float.Parse(txt{2}.Text.ToString());",
                                    objDataTypeAbbrEN.CsType,
                                    objWebSrvFuncParaEN.ParaName,
                                    objWebSrvFuncParaEN._StrTag);
                                break;
                            case enumDataTypeAbbr.int_09:
                                strCodeForCs.AppendFormat("\r\n" + "{0} {1} = int.Parse(txt{2}.Text.ToString());",
                                    objDataTypeAbbrEN.CsType,
                                    objWebSrvFuncParaEN.ParaName,
                                    objWebSrvFuncParaEN._StrTag);
                                break;
                            case enumDataTypeAbbr.money_11:
                                strCodeForCs.AppendFormat("\r\n" + "{0} {1} = double.Parse(txt{2}.Text.ToString());",
                                    objDataTypeAbbrEN.CsType,
                                    objWebSrvFuncParaEN.ParaName,
                                    objWebSrvFuncParaEN._StrTag);
                                break;
                            default:
                                strMsg = string.Format("�������ͣ�[{0}({1})](Java:{2})�ں�����û�д���!({3})", 
                                    objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                                    objDataTypeAbbrEN.CsType, 
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                        }
                    }
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
            
            strCodeForCs.AppendFormat("\r\n" + "obj{0}WS4SDController.{1}({2});",
                    objWebSrvClassENEx.ClsName,
                    objWebSrvFunctionsENEx.FunctionName,
                    sbParaVarList.ToString());
            
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "//ͨ��WebServiceִ�к���:[{0}],���ص��¼�����,������ȷ����,����Ҫ����ִ�д���",
                objWebSrvFunctionsENEx.FunctionName);
          
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(string returnString, string strClassName, string strFunctionName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.{0}.name;",
       clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"����ֵΪ��{{0}}!\", returnString);");

            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            //  strCodeForCs.Append("\r\n" + "//clsPubFun.myAlert(strInfo, vcObj: vcParent);");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
         
            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_btnClickByCommonFunction(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strMsg = "";
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.AppendFormat("\r\n /// {0}", objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            //  strCodeForCs.Append("\r\n /// <param name = \"sender\">�¼�������</param>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "export  async function " + this.tabNameHead + "btn{0}_Click() ",
                objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btn{0}_Click\";",       objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            StringBuilder sbParaList = new StringBuilder();
            StringBuilder sbParaVarList = new StringBuilder();
            List<clsFuncPara4CodeEN> arrFuncPara4CodeObjLst =
              clsFuncPara4CodeBLEx.GetObjListByFuncId4CodeCacheEx(objvFunction4GeneCodeEN.FuncId4Code, enumFunctionPurpose.GeneCode_01);
            if (arrFuncPara4CodeObjLst != null)
            {
                foreach (clsFuncPara4CodeEN objFuncPara4CodeEN in arrFuncPara4CodeObjLst)
                {
                    clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFuncPara4CodeEN.DataTypeId);
                    clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;
                    if (objDataTypeAbbrEN == null)
                    {
                        objSelfDefDataTypeEN_Para = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objFuncPara4CodeEN.ParameterType);
                        if (objSelfDefDataTypeEN_Para == null)
                        {
                            strMsg = string.Format("�����������������ͣ�[{0}({1})]û�д���,����������Ӧ���롣", objDataTypeAbbrEN.DataTypeId,
                                objFuncPara4CodeEN.ParameterType);
                            throw new Exception(strMsg);
                        }
                    }
                    if (objFuncPara4CodeEN.IsByRef == true)
                    {
                        strMsg = string.Format("Java���������Ĳ����������Ͳ�������������[{0}],�������ͣ�[{1}]û�д���,����������Ӧ���롣",
                           objFuncPara4CodeEN.ParaName,
                             objFuncPara4CodeEN.ParameterType);
                        throw new Exception(strMsg);
                    }
                    else
                    {
                        if (objDataTypeAbbrEN.IsNeedQuote == true)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "{0} {1} = txt{2}.Text.Trim();",
                                objDataTypeAbbrEN.CsType,
                                objFuncPara4CodeEN.ParaName,
                                objFuncPara4CodeEN._StrTag);
                        }
                        else
                        {
                            switch (objFuncPara4CodeEN.DataTypeId)
                            {
                                case enumDataTypeAbbr.float_07:
                                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = float.Parse(txt{2}.Text.ToString());",
                                        objDataTypeAbbrEN.CsType,
                                        objFuncPara4CodeEN.ParaName,
                                        objFuncPara4CodeEN._StrTag);
                                    break;
                                case enumDataTypeAbbr.int_09:
                                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = int.Parse(txt{2}.Text.ToString());",
                                        objDataTypeAbbrEN.CsType,
                                        objFuncPara4CodeEN.ParaName,
                                        objFuncPara4CodeEN._StrTag);
                                    break;
                                case enumDataTypeAbbr.money_11:
                                    strCodeForCs.AppendFormat("\r\n" + "{0} {1} = double.Parse(txt{2}.Text.ToString());",
                                        objDataTypeAbbrEN.CsType,
                                        objFuncPara4CodeEN.ParaName,
                                        objFuncPara4CodeEN._StrTag);
                                    break;
                                default:
                                    strMsg = string.Format("�������ͣ�[{0}({1})](CSharp:{2})�ں�����û�д���!({3})",
                                        objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                                        objDataTypeAbbrEN.CsType,
                                        clsStackTrace.GetCurrClassFunction());
                                    throw new Exception(strMsg);
                            }
                        }
                        if (objSelfDefDataTypeEN_Para != null)
                        {
                            sbParaList.AppendFormat("{0} {1},",
                                objSelfDefDataTypeEN_Para.CsType,
                                objFuncPara4CodeEN.ParaName);
                        }
                        else
                        {
                            sbParaList.AppendFormat("{0} {1},",
                                objDataTypeAbbrEN.CsType,
                                objFuncPara4CodeEN.ParaName);
                        }
                        sbParaVarList.AppendFormat("{0},", objFuncPara4CodeEN.ParaName);
                    }
                }
            }
            if (sbParaList.Length > 0)
            {
                sbParaList.Remove(sbParaList.Length - 1, 1);
                sbParaVarList.Remove(sbParaVarList.Length - 1, 1);
            }

            strCodeForCs.AppendFormat("\r\n" + "{0}_{1}Async({2});",
                    objPrjTabENEx.TabName,
                    objvFunction4GeneCodeEN.FuncName4Code,
                    sbParaVarList.ToString());

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "//ͨ��WebServiceִ�к���:[{0}],���ص��¼�����,������ȷ����,����Ҫ����ִ�д���",
                objvFunction4GeneCodeEN.FuncName4Code);
          
            strCodeForCs.AppendFormat("\r\n" + "public void {0}(string returnString, string strClassName, string strFunctionName)",
                clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.{0}.name;",
        clsDict4GCBLEx.GetDictValueByKeyCache(enumDict4GC_DictKey1.conSelfDefFunc,
                enumDict4GC_DictKey2.conCorrectFinished));

            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"����ֵΪ��${returnString}!\");");

            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            //  strCodeForCs.Append("\r\n" + "//clsPubFun.myAlert(strInfo, vcObj: vcParent);");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }

        /// <summary>
        /// �̳�Runnable�����ʵ�ֵġ�run������  
        /// </summary>
        /// <returns></returns>
        public string Gen_WApi_Ts_btnClickAddNewRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����¼�¼");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.Append("\r\n" + "export  async function " + this.tabNameHead + "btnAddNewRecord_Click() {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btnAddNewRecord_Click\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN = new cls{0}EN();",
               objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "bool")
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                       objPrjTabENEx.TabName,
                       objField.ObjFieldTabENEx.FldName,
                       objField.ObjFieldTabENEx.DefaultValue4Test_TypeScript);
                }
                else if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "Date" || objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "DateTime")
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                       objPrjTabENEx.TabName,
                       objField.ObjFieldTabENEx.FldName,
                       objField.ObjFieldTabENEx.DefaultValue4Test_TypeScript);
                }
                else if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "short")
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                       objPrjTabENEx.TabName,
                       objField.ObjFieldTabENEx.FldName,
                       objField.ObjFieldTabENEx.DefaultValue4Test_TypeScript);
                }
                else if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = \"{2}\";",
                       objPrjTabENEx.TabName,
                       objField.ObjFieldTabENEx.FldName,
                       objField.ObjFieldTabENEx.DefaultValue4Test_TypeScript);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                          objField.ObjFieldTabENEx.DefaultValue4Test_TypeScript);
                }
            }
       
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + $"const bolIsExist = await {thisWA_F(WA_F.IsExistAsync)}(obj{ThisTabName4GC}EN.{objKeyField.PropertyName(this.IsFstLcase)});");

            strCodeForCs.Append("\r\n" + "if (bolIsExist == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"��Ӽ�¼ʱ,�ؼ��֣�{{0}}�Ѿ�����!\", obj{0}EN.{1});",
                objPrjTabENEx.TabName, objKeyField.PropertyName(this.IsFstLcase));
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return false;//һ��Ҫ��һ������ֵ,��������!");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + $"const returnBool = await {thisWA_F(WA_F.AddNewRecordAsync)}(obj{ThisTabName4GC}EN);");

            strCodeForCs.Append("\r\n" + "if (returnBool == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const strInfo = `���[{TabCnName_In4Edit4GC}({TabName_In4Edit4GC})]��¼�ɹ�!`;");

            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const strInfo = `���[{TabCnName_In4Edit4GC}({TabName_In4Edit4GC})]��¼���ɹ�!`;");

            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "}");

     
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"��Ӽ�¼���ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }

 
        public string Gen_WApi_Ts_btnClickAddNewRecord4GetMaxStrId(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����¼�¼");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.Append("\r\n" + "export  async function " + this.tabNameHead + "btnAddNewRecord4GetMaxStrId_Click() {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btnAddNewRecord4GetMaxStrId_Click\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            strCodeForCs.Append("\r\n" + $"const returnString = await {thisWA_F(WA_F.GetMaxStrIdAsync)}();");

            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN = new cls{0}EN();",
                objPrjTabENEx.TabName);
            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                if (objField.FieldTypeId == enumFieldType.KeyField_02)
                {
                    if (objField.TypeScriptType == "number")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = Number(returnString);",
                        objPrjTabENEx.TabName,
                        objField.ObjFieldTabENEx.FldName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = returnString;",
                        objPrjTabENEx.TabName,
                        objField.ObjFieldTabENEx.FldName);
                    }
                }
                else
                {
                    if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType == "boolean")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                           objPrjTabENEx.TabName,
                           objField.ObjFieldTabENEx.FldName,
                           objField.ObjFieldTabENEx.DefaultValue4Test_TypeScript);
                    }
                    else  if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType == "Date")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                           objPrjTabENEx.TabName,
                           objField.ObjFieldTabENEx.FldName,
                           objField.ObjFieldTabENEx.DefaultValue4Test_TypeScript);
                    }
                    else if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType == "short")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = (short){2};",
                           objPrjTabENEx.TabName,
                           objField.ObjFieldTabENEx.FldName,
                           objField.ObjFieldTabENEx.DefaultValue4Test_TypeScript);
                    }
                    else if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = \"{2}\";",
                           objPrjTabENEx.TabName,
                           objField.ObjFieldTabENEx.FldName,
                           objField.ObjFieldTabENEx.DefaultValue4Test_TypeScript);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                              objPrjTabENEx.TabName,
                              objField.ObjFieldTabENEx.FldName,
                              objField.ObjFieldTabENEx.DefaultValue4Test_TypeScript);
                    }
                }
            }
          
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const returnBool = await {thisWA_F_InEdit(WA_F.AddNewRecordAsync)}(obj{ThisTabName4GC}EN);");

            strCodeForCs.Append("\r\n" + "if (returnBool == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const strInfo = `���[{TabCnName_In4Edit4GC}({TabName_In4Edit4GC})]��¼�ɹ�!`;");

            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const strInfo = `���[{TabCnName_In4Edit4GC}({TabName_In4Edit4GC})]��¼���ɹ�!`;");
            
            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
      
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"��Ӽ�¼���ɹ�, {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_btnClickGetMaxStrId(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ��ȡ��ǰ��ؼ���ֵ�����ֵ,�ټ�1,�����ظ�");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.Append("\r\n" + "export  async function " + this.tabNameHead + "btnGetMaxStrId_Click() {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btnGetMaxStrId_Click\";",
            objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const returnString = await {thisWA_F(WA_F.GetMaxStrIdAsync)}();");
            
            strCodeForCs.Append("\r\n" + "if (returnString == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"��ȡ��{0}�����ؼ���Ϊ��,���ɹ�,����!\");",
                objPrjTabENEx.TabName);


            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"��ȡ��{0}�����ؼ���Ϊ��{{0}}!\", returnString);",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"��ȡ��ؼ��ֵ����ֵ���ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_btnClickGetMaxStrIdByPrefix(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// ����ǰ׺��ȡ��ǰ��ؼ���ֵ�����ֵ,�ټ�1,�����ظ�");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");

            strCodeForCs.Append("\r\n" + "export  async function " + this.tabNameHead + "btnGetMaxStrIdByPrefix_Click() {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btnGetMaxStrIdByPrefix_Click\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            //            strCodeForCs.AppendFormat("\r\n" + "string strPrefix = \"2\";");
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const returnString = await {thisWA_F(WA_F.GetMaxStrIdByPrefixAsync)}(strPrefix);");

            strCodeForCs.Append("\r\n" + "if (returnString == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"��ȡ��{0}�����ؼ���Ϊ��,���ɹ�,����!\");",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"��ȡ��{0}�����ؼ���Ϊ��{{0}}!\", returnString);",
                objPrjTabENEx.TabName);

            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"��ȡ��ؼ��ֵ����ֵ���ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
    


            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Ts_btnClickUpdateRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// �޸ļ�¼");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.Append("\r\n" + "export  async function " + this.tabNameHead + "btnUpdateRecord_Click() {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = \"btnUpdateRecord_Click\";",
       objPrjTabENEx.TabName, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN = new cls{0}EN();",
           objPrjTabENEx.TabName);

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                if (objField.FieldTypeId == enumFieldType.KeyField_02 && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "bool")
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                       objPrjTabENEx.TabName,
                       objField.ObjFieldTabENEx.FldName,
                       objField.ObjFieldTabENEx.DefaultValue4Test_TypeScript);
                }
                else if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "Date" || objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "DateTime")
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                       objPrjTabENEx.TabName,
                       objField.ObjFieldTabENEx.FldName,
                       objField.ObjFieldTabENEx.DefaultValue4Test_TypeScript);
                }
                else if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType == "short")
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                       objPrjTabENEx.TabName,
                       objField.ObjFieldTabENEx.FldName,
                       objField.ObjFieldTabENEx.DefaultValue4Test_TypeScript);
                }
                else if (objField.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = \"{2}\";",
                       objPrjTabENEx.TabName,
                       objField.ObjFieldTabENEx.FldName,
                       objField.ObjFieldTabENEx.DefaultValue4Test_TypeScript);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                          objPrjTabENEx.TabName,
                          objField.ObjFieldTabENEx.FldName,
                          objField.ObjFieldTabENEx.DefaultValue4Test_TypeScript);
                }
            }
            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.sfUpdFldSetStr = obj{0}EN.updFldString;//������Щ�ֶα��޸�(���ֶ�)",
                objPrjTabENEx.TabName);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"const returnBool = await {thisWA_F(WA_F.UpdateRecordAsync)}(obj{ThisTabName4GC}EN);");
                        
            strCodeForCs.Append("\r\n" + "if (returnBool == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�޸ļ�¼�ɹ�!\");");

            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"�޸ļ�¼���ɹ�!\");");

            strCodeForCs.Append("\r\n" + "//��ʾ��Ϣ��");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"�޸ļ�¼���ɹ�,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg)");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
 
            return strCodeForCs.ToString();
        }

        private void GC_GetInputValue4Para_TS(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, StringBuilder strCodeForCs)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);

            string strMsg = "";
            //            StringBuilder strCodeForCs = new StringBuilder();
            List<clsFuncPara4CodeEN> arrFuncPara4CodeObjLst =
  clsFuncPara4CodeBLEx.GetObjListByFuncId4CodeCacheEx(objFunction4GeneCodeEN.FuncId4Code, enumFunctionPurpose.GeneCode_01);
            if (arrFuncPara4CodeObjLst != null)
            {
                foreach (clsFuncPara4CodeEN objFuncPara4CodeEN in arrFuncPara4CodeObjLst)
                {
                    clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFuncPara4CodeEN.DataTypeId);
                    clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;
                    if (objDataTypeAbbrEN == null)
                    {
                        objSelfDefDataTypeEN_Para = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objFuncPara4CodeEN.ParameterType);
                        if (objSelfDefDataTypeEN_Para == null)
                        {
                            strMsg = string.Format("�����������������ͣ�[{0}({1})]û�д���,����������Ӧ���롣", objDataTypeAbbrEN.DataTypeId,
                                objFuncPara4CodeEN.ParameterType);
                            throw new Exception(strMsg);
                        }
                    }
                    if (objFuncPara4CodeEN.IsByRef == true)
                    {
                        strMsg = string.Format("Java���������Ĳ����������Ͳ�������������[{0}],�������ͣ�[{1}]û�д���,����������Ӧ���롣",
                           objFuncPara4CodeEN.ParaName,
                             objFuncPara4CodeEN.ParameterType);
                        throw new Exception(strMsg);
                    }
                    else
                    {
                        if (objDataTypeAbbrEN.IsNeedQuote == true)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "const {1}: {0} = $('#txt{1}{2}').val();",
                                objDataTypeAbbrEN.TypeScriptType,
                                objFuncPara4CodeEN.ParaName,
                                objvFunction4GeneCodeEN.OrderNum);
                        }
                        else
                        {
                            switch (objFuncPara4CodeEN.DataTypeId)
                            {
                                case enumDataTypeAbbr.float_07:
                                case enumDataTypeAbbr.int_09:
                                case enumDataTypeAbbr.bigint_01:
                                case enumDataTypeAbbr.bigintidentity_26:

                                case enumDataTypeAbbr.money_11:
                                    strCodeForCs.AppendFormat("\r\n" + "const {1}:{0} = Number($('#txt{1}{2}').val());",
                                        objDataTypeAbbrEN.TypeScriptType,
                                        objFuncPara4CodeEN.ParaName,
                                        objvFunction4GeneCodeEN.OrderNum);
                                    break;
                                case enumDataTypeAbbr.Object_29:
                                    strCodeForCs.AppendFormat("\r\n" + "const {1}:{0} = $('#txt{1}{2}').val();",
                                        objDataTypeAbbrEN.TypeScriptType,
                                        objFuncPara4CodeEN.ParaName,
                                        objvFunction4GeneCodeEN.OrderNum);
                                    break;
                                case enumDataTypeAbbr.Array_31:
                                    string strTypeScriptType = objDataTypeAbbrEN.TypeScriptType
                                        .Replace("[", "<")
                                        .Replace("]",">")
                                        .Replace("(", "<")
                                        .Replace(")", ">");
                                    strCodeForCs.AppendFormat("\r\n" + "const strKeyIdLst:string = $('#txt{0}{1}').val();",
                                        objFuncPara4CodeEN.ParaName,
                                        objvFunction4GeneCodeEN.OrderNum);
                                    //strCodeForCs.AppendFormat("\r\n" + "const {1}:{0} = strKeyIdLst.split(\",\");",
                                    //    strTypeScriptType,
                                    //    objFuncPara4CodeEN.ParaName);
                                    break;
                                default:
                                    strMsg = string.Format("�������ͣ�[{0}({1})](TypeScript:{2})�ں�����û�д���!({3})",
                                        objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                                        objDataTypeAbbrEN.TypeScriptType,
                                        clsStackTrace.GetCurrClassFunction());
                                    throw new Exception(strMsg);
                            }
                        }
                        //if (objSelfDefDataTypeEN_Para != null)
                        //{
                        //    sbParaList.AppendFormat("{0} {1},",
                        //        objSelfDefDataTypeEN_Para.CsType,
                        //        objFuncPara4CodeEN.ParaName);
                        //}
                        //else
                        //{
                        //    sbParaList.AppendFormat("{0} {1},",
                        //        objDataTypeAbbrEN.CsType,
                        //        objFuncPara4CodeEN.ParaName);
                        //}
                        //sbParaVarList.AppendFormat("{0},", objFuncPara4CodeEN.ParaName);
                    }
                }
            }

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

        public override void GetClsName()
        {
            this.ClsName = string.Format("WApi{0}_UT_TS", objPrjTabENEx.TabName);
            objPrjTabENEx.ClsName = this.ClsName;
        }
    }
}
