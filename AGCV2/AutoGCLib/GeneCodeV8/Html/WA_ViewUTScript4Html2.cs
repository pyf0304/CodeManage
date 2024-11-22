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
using AGC.PureClass;
using AGC.PureClassEx;
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
    partial class WA_ViewUTScript4Html : clsGeneCodeBase
    {

        //public WA_ViewUTScript4Html()
        //{


        //    // 
        //    // TODO: �ڴ˴���ӹ��캯���߼�
        //    //
        //}
        //public WA_ViewUTScript4Html(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
        //  : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
        //{
        //    // 
        //    // TODO: �ڴ˴���ӹ��캯���߼�
        //    //
        //}
        /// <summary>
        /// ����ָ���ĺ���
        /// </summary>
        /// <returns>�������ɵ�ָ����������</returns>
        public string A_GenCode4Function_CS_Ts_DefButtonBak(string strFuncId4GC)
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


        public string A_GeneFuncCode_CS_Ts_DefButtonBak(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            try
            {
                switch (objvFunction4GeneCodeEN.FuncName)
                {

                    case "Gen_WA_WUT_Js_DefButtonGetFirstObj":
                        return Gen_WA_WUT_Js_DefButtonGetFirstObj(objvFunction4GeneCodeEN);

                    case "Gen_WA_WUT_Js_DefButtonGetObjByKey":
                        return Gen_WA_WUT_Js_DefButtonGetObjByKey(objvFunction4GeneCodeEN);

                    case "Gen_WA_WUT_Js_DefButtonGetObjByKeyCache":
                        return Gen_WA_WUT_Js_DefButtonGetObjByKeyCache(objvFunction4GeneCodeEN);

                    case "Gen_WA_WUT_Js_DefButtonGetObjByKey_WACache":
                        return Gen_WA_WUT_Js_DefButtonGetObjByKey_WACache(objvFunction4GeneCodeEN);

                    case "Gen_WA_WUT_Js_DefButtonDelRecord":
                        return Gen_WA_WUT_Js_DefButtonDelRecord(objvFunction4GeneCodeEN);

                    case "Gen_WA_WUT_Js_DefButtonDelRecords":
                        return Gen_WA_WUT_Js_DefButtonDelRecords(objvFunction4GeneCodeEN);
                    case "Gen_WA_WUT_Js_DefButtonDelMultiRecord":
                        return Gen_WA_WUT_Js_DefButtonDelMultiRecord(objvFunction4GeneCodeEN);
                    case "Gen_WA_WUT_Js_DefButtonDelMultiRecordByCond":
                        return Gen_WA_WUT_Js_DefButtonDelMultiRecordByCond(objvFunction4GeneCodeEN);

                        
                    case "Gen_WA_WUT_Js_DefButtonAddNewRecord":
                        return Gen_WA_WUT_Js_DefButtonAddNewRecord(objvFunction4GeneCodeEN);

                    case "Gen_WA_WUT_Js_DefButtonAddNewRecord4GetMaxStrId":
                        return Gen_WA_WUT_Js_DefButtonAddNewRecord4GetMaxStrId(objvFunction4GeneCodeEN);
                    case "Gen_WA_WUT_Js_DefButtonGetMaxStrId":
                        return Gen_WA_WUT_Js_DefButtonGetMaxStrId(objvFunction4GeneCodeEN);
                    case "Gen_WA_WUT_Js_DefButtonGetMaxStrIdByPrefix":
                        return Gen_WA_WUT_Js_DefButtonGetMaxStrIdByPrefix(objvFunction4GeneCodeEN);

                    case "Gen_WA_WUT_Js_DefButtonUpdateRecord":
                        return Gen_WA_WUT_Js_DefButtonUpdateRecord(objvFunction4GeneCodeEN);

                    case "Gen_WA_WUT_Js_DefButtonIsExistRecord":
                        return Gen_WA_WUT_Js_DefButtonIsExistRecord(objvFunction4GeneCodeEN);

                    case "Gen_WA_WUT_Js_DefButtonIsExistRecordCache":
                        return Gen_WA_WUT_Js_DefButtonIsExistRecordCache(objvFunction4GeneCodeEN);

                    case "Gen_WA_WUT_Js_DefButtonGetRecCountByCond":
                        return Gen_WA_WUT_Js_DefButtonGetRecCountByCond(objvFunction4GeneCodeEN);

                    case "Gen_WA_WUT_Js_DefButtonGetRecCountByCondCache":
                        return Gen_WA_WUT_Js_DefButtonGetRecCountByCondCache(objvFunction4GeneCodeEN);

                    case "Gen_WA_WUT_Js_DefButtonGetObjLst":
                        return Gen_WA_WUT_Js_DefButtonGetObjLst(objvFunction4GeneCodeEN);

                    case "Gen_WA_WUT_Js_DefButtonGetObjLstByKeyLst":
                        return Gen_WA_WUT_Js_DefButtonGetObjLstByKeyLst(objvFunction4GeneCodeEN);

                    case "Gen_WA_WUT_Js_DefButtonGetObjLstByKeyLstCache":
                        return Gen_WA_WUT_Js_DefButtonGetObjLstByKeyLstCache(objvFunction4GeneCodeEN);

                    case "Gen_WA_WUT_Js_DefButtonGetObjLstByKeyLst_WACache":
                        return Gen_WA_WUT_Js_DefButtonGetObjLstByKeyLst_WACache(objvFunction4GeneCodeEN);

                    case "Gen_WA_WUT_Js_DefButtonGetTopObjLst":
                        return Gen_WA_WUT_Js_DefButtonGetTopObjLst(objvFunction4GeneCodeEN);

                    case "Gen_WA_WUT_Js_DefButtonGetObjLstByPager":
                        return Gen_WA_WUT_Js_DefButtonGetObjLstByPager(objvFunction4GeneCodeEN);

                    case "Gen_WA_WUT_Js_DefButtonGetObjLstByPagerCache":
                        return Gen_WA_WUT_Js_DefButtonGetObjLstByPagerCache(objvFunction4GeneCodeEN);

                    case "Gen_WA_WUT_Js_DefButtonGetSubObjLstCache":
                        return Gen_WA_WUT_Js_DefButtonGetSubObjLstCache(objvFunction4GeneCodeEN);

                    case "Gen_WA_WUT_Js_DefButtonGetSubObjLst_WACache":
                        return Gen_WA_WUT_Js_DefButtonGetSubObjLst_WACache(objvFunction4GeneCodeEN);

                    case "Gen_WA_WUT_Js_DefButtonGetObjLstByPager_WACache":
                        return Gen_WA_WUT_Js_DefButtonGetObjLstByPager_WACache(objvFunction4GeneCodeEN);

                    case "Gen_WA_WUT_Js_DefButtonGetObjLstByRange":
                        return Gen_WA_WUT_Js_DefButtonGetObjLstByRange(objvFunction4GeneCodeEN);

                    case "Gen_WA_WUT_Js_DefLabelMsg":
                        return Gen_WA_WUT_Js_DefLabelMsg(objvFunction4GeneCodeEN);
                    case "Gen_WA_WUT_Js_DefDiv4EditRegion":
                        return Gen_WA_WUT_Js_DefDiv4EditRegion(objvFunction4GeneCodeEN);


                    default:
                        string strMsg = string.Format("������:{1}��Switchû�д���,����({0})",
                             clsStackTrace.GetCurrClassFunction(), objvFunction4GeneCodeEN.FuncName);
                        throw new Exception(strMsg);
                        //            return "///��1����������:" + strFuncName;
                }
            }
            catch (Exception objException)
            {
                StringBuilder sbMessage = new StringBuilder();
                sbMessage.AppendFormat("�����ɺ���:{0}ʱ����. \r\n������Ϣ:{1}.", objvFunction4GeneCodeEN.FuncName, objException.Message);
                throw new Exception(sbMessage.ToString());
            }
        }


        /// <summary>
        /// ����Web Serviceת�������
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

            //���û���������;
            //string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp = ""; ///��ʱ����;

            objPrjTabENEx.ClsName = string.Format("WA_{0}_UT_JS", objPrjTabENEx.TabName);
            //objPrjTabENEx.ClsName = objPrjTabENEx.ClsName.ToLower();
            //objPrjTabENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            objPrjTabENEx.SimpleFileName = objPrjTabENEx.ClsName + ".html";
            strRe_ClsName = objPrjTabENEx.ClsName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objPrjTabENEx.FuncModuleAgcId, objPrjTabENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName( objFuncModule, objPrjTabENEx);
            strClassFName = objPrjTabENEx.FolderName + objPrjTabENEx.ClsName + ".aspx.cs";

            objPrjTabENEx.FileName = strClassFName;
            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objPrjTabENEx.PrjId); //
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
              clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objPrjTabENEx.FunctionTemplateId(this.CmPrjId),
              objPrjTabENEx.LangType, objPrjTabENEx.CodeTypeId, objPrjTabENEx.SqlDsTypeId)
                            .OrderBy(x => x.OrderNum); 

            try
            {
                //���ɲ����¼�Ľ������;
                //      strCodeForCs.Append("///���ɲ�ѯ���޸ġ�ɾ������Ӽ�¼�Ľ������(���ÿؼ�)");
                //strCodeForCs.AppendFormat("\r\n" + "<%@ Page language = \"c#\" AutoEventWireup = \"true\" CodeBehind = \"{0}.aspx.cs\" Inherits = \"{1}.WApiForm.{0}\" %>",
                //  objPrjTabENEx.ClsName, objProjectsENEx.PrjDomain);
                strCodeForCs.Append("\r\n" + "<!DOCTYPE html>");
                strCodeForCs.Append("\r\n" + "<html>");
                strCodeForCs.Append("\r\n" + "<head>");
                strCodeForCs.Append("\r\n" + "<meta charset = \"utf-8\" />");
                strCodeForCs.AppendFormat("\r\n" + "<title>{0}-��Ԫ���� </title>", objPrjTabENEx.TabCnName);
                strCodeForCs.Append("\r\n" + "    <link href=\"../../Content/bootstrap.css\" rel=\"stylesheet\" />");
                //strCodeForCs.Append("\r\n" + "    <link href=\"../../Css/site.css\" rel=\"stylesheet\" />");
                strCodeForCs.Append("\r\n" + "    <script src=\"../../scripts/jquery-3.4.1.min.js\"></script>");
                //strCodeForCs.Append("\r\n" + "    <script src=\"../../scripts/bootstrap.js\"></script>");
                //strCodeForCs.Append("\r\n" + "    <script src=\"/js1/site.js\" asp-append-version=\"true\"></script>");
                //strCodeForCs.Append("\r\n" + "<script src=\"../../scripts/popper.js\"></script>");
                strCodeForCs.Append("\r\n" + "<script data-main=\"../../js/src/config\" src=\"../../scripts/require.js\"></script>");
                
                string strClsName4UT_JS = string.Format("WA_{0}_UT_JS", objPrjTabENEx.TabName);
                string strClsName4UT_Js_Lower = string.Format("WA_{0}_UT_JS", objPrjTabENEx.TabName).ToLower();
                string strTabName_Lower = objPrjTabENEx.TabName.ToLower();
                long lngCMProjectAppRelaId = clsCMProjectAppRelaBLEx.getCMProjectAppRelaId(this.CmPrjId, objPrjTabENEx.ApplicationTypeId, objPrjTabENEx.PrjId);
                
                clsvUserCodePathEN objvUserCodePathEN = clsvUserCodePathBLEx.GetObjByCodeTypeIdCache1(lngCMProjectAppRelaId, objPrjTabENEx.CodeTypeId, objPrjTabENEx.PrjId);

                strCodeForCs.Append("\r\n" + "     <script>    ");
                strCodeForCs.Append("\r\n" + "//var strUrl1 = \"@Url.Content(\"~/Test/_FldComparison/\")\";");
                strCodeForCs.Append("\r\n" + "//console.log(\"strUrl1: \" + strUrl1);");
                strCodeForCs.Append("\r\n" + "//var strCurrRootUrl = \"@Url.Content(\"~/\")\";");
                strCodeForCs.Append("\r\n" + "//console.log(\"strCurrRootUrl:\" + strCurrRootUrl);");

                strCodeForCs.Append("\r\n" + "         function ExpandDiv(divName, bolIsAddFldComparison, divName4Edit) {");

                strCodeForCs.Append("\r\n" + "//����RequireJS������tzPubFun.ts�еĺ���OnlyShowDiv��");
                strCodeForCs.Append("\r\n" + "require([\"../../js/PubFun/tzPubFun.js\"], function (pubfun) {");
                strCodeForCs.Append("\r\n" + "      pubfun.OnlyShowDiv(divName, \"function\", \"content\");");                
                strCodeForCs.AppendFormat("\r\n" + "//console.log(\"divName4Edit:(In WA_{0}_UT_JS)\" + divName4Edit);", objPrjTabENEx.TabName);
                strCodeForCs.Append("\r\n" + "if (bolIsAddFldComparison == true)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "AddDPV_FldComparison(divName4Edit);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "});");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "function AddDPV_FldComparison(divName4Edit)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "require([\"../{1}{3}/{0}.js\"], function({2}) {{",
                              strClsName4UT_Js_Lower, objFuncModule.FuncModuleEnName4GC(), objPrjTabENEx.TabName.ToLower(), objvUserCodePathEN.SuffixPath);
                strCodeForCs.AppendFormat("\r\n" + "{0}.{1}.AddDPV_FldComparison(divName4Edit);", strTabName_Lower, strClsName4UT_JS);
                strCodeForCs.Append("\r\n" + "});");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "window.onload = function() {");
                strCodeForCs.Append("\r\n" + "const hidDivName = document.getElementById(\"hidDivName\");");
                strCodeForCs.Append("\r\n" + "const divName = hidDivName.value;");
                strCodeForCs.Append("\r\n" + "ExpandDiv(divName);");
                strCodeForCs.Append("\r\n" + "GetFldNameLst();");
                strCodeForCs.Append("\r\n" + "CreateCache();");
                strCodeForCs.Append("\r\n" + "}");

                //strCodeForCs.AppendFormat("\r\n" + "function btn{0}_Click() {{", strFuncName4Code);
                //strCodeForCs.AppendFormat("\r\n" + "require([\"../{1}{3}/{0}.js\"], function({2}) {{",
                //    strClsName4UT_Js_Lower, objFuncModule.FuncModuleEnName4GC(), objPrjTabENEx.TabName.ToLower(), objvUserCodePathEN.SuffixPath);
                //strCodeForCs.AppendFormat("\r\n" + "{0}.{1}.btn{2}_Click();",
                //    strTabName_Lower, strClsName4UT_JS, strFuncName4Code);
                //strCodeForCs.Append("\r\n" + "});");

                strCodeForCs.Append("\r\n" + "function CallBakFldNameLst(myFldNameLst)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "arrFldName = myFldNameLst.split(\",\");");
                strCodeForCs.Append("\r\n" + "//console.log(arrFldName);");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "function GetFldNameLst()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "require([\"../{1}{3}/{0}.js\"], function({2}) {{",
                              strClsName4UT_Js_Lower, objFuncModule.FuncModuleEnName4GC(), objPrjTabENEx.TabName.ToLower(), objvUserCodePathEN.SuffixPath);
                strCodeForCs.Append("\r\n" + "const strKey = $(\"#txtInput\").val();");
                           strCodeForCs.AppendFormat("\r\n" + "const bb = {0}.{1}.GetFldNameLst(CallBakFldNameLst);", strTabName_Lower, strClsName4UT_JS);

                strCodeForCs.Append("\r\n" + "});");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + " function CreateCache() {");
                strCodeForCs.AppendFormat("\r\n" + "require([\"../{1}{3}/{0}.js\"], function({2}) {{",
                              strClsName4UT_Js_Lower, objFuncModule.FuncModuleEnName4GC(), objPrjTabENEx.TabName.ToLower(), objvUserCodePathEN.SuffixPath);

                strCodeForCs.Append("\r\n" + "            var strKey = $(\"#txtInput\").val();");
                strCodeForCs.AppendFormat("\r\n" + "            var bb = {0}.{1}.CreateCache(strKey);", strTabName_Lower, strClsName4UT_JS);
                strCodeForCs.Append("\r\n" + "            $(\"#lblPageStatusContent\").attr(\"value\", bb);// ������");
                strCodeForCs.Append("\r\n" + "        });");
                strCodeForCs.Append("\r\n" + "    }");

                strCodeForCs.AppendFormat("\r\n" + "function ShowDialog_{0}(pstrOp) {{", objViewInfoENEx.TabName_In);
                strCodeForCs.Append("\r\n" + "            strOp = pstrOp;");
                strCodeForCs.Append("\r\n" + "require(['jquery', 'bootstrap'], function($) {");
                strCodeForCs.Append("\r\n" + "            if (strOp === \"Add\" || strOp === \"AddWithMaxId\") {");
                strCodeForCs.AppendFormat("\r\n" + "                $('#lblDialogTitle_{0}').html('��Ӽ�¼');", objViewInfoENEx.TabName_In);
                strCodeForCs.Append("\r\n" + "            }");
                strCodeForCs.Append("\r\n" + "            else {");
                strCodeForCs.AppendFormat("\r\n" + "                $('#lblDialogTitle_{0}').html('�޸ļ�¼');", objViewInfoENEx.TabName_In);
                strCodeForCs.Append("\r\n" + "            }");
                strCodeForCs.AppendFormat("\r\n" + "            $('#divEditDialog_{0}').modal('show');", objViewInfoENEx.TabName_In);
                strCodeForCs.Append("\r\n" + "});");
                strCodeForCs.Append("\r\n" + "        }");
                strCodeForCs.Append("\r\n" + "        function Submit_{0}(pstrOp) {  ");
                strCodeForCs.Append("\r\n" + "            alert(\"�ύ\" + strOp);");
      
                strCodeForCs.AppendFormat("\r\n" + "require([\"{0}\"], function({1}) {{",
                    strClsName4UT_Js_Lower, strTabName_Lower);

                strCodeForCs.Append("\r\n" + "            if (strOp == \"Add\")");
                strCodeForCs.Append("\r\n" + "            {");
                strCodeForCs.AppendFormat("\r\n" + "           {0}.{1}.btnAddNewRecord_Click();",
                    strTabName_Lower, strClsName4UT_JS);
                strCodeForCs.Append("\r\n" + "            }");
                strCodeForCs.Append("\r\n" + "            else");
                strCodeForCs.Append("\r\n" + "            {");
                strCodeForCs.AppendFormat("\r\n" + "           {0}.{1}.btnUpdateRecord_Click()",
                    strTabName_Lower, strClsName4UT_JS);
                strCodeForCs.Append("\r\n" + "            }");
                strCodeForCs.Append("\r\n" + "});");

                strCodeForCs.Append("\r\n" + "        }");
                //objPrjTabENEx.arrTabFeatureSet

                //clsUserCodePathEN objUserCodePathEN = clsUserCodePathBLEx.GetObjByCodeTypeIdCache(objPrjTabENEx.CodeTypeId, objPrjTabENEx.ApplicationTypeId, objPrjTabENEx.PrjId, objPrjTabENEx.UserId);
                //����RequireJS, ��Ҫ���ɽ�����ͨ��Js����������Ts�ĺ���,
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    string strFuncName4Code = TransKeyWords4FuncName(objvFunction4GeneCodeEN.FuncName4Code);

                    strCodeForCs.Append("\r\n /// <summary>");
                    strCodeForCs.AppendFormat("\r\n /// {0}", objvFunction4GeneCodeEN.FuncCHName4Code);
                    //strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n /// </summary>");
                    strCodeForCs.AppendFormat("\r\n" + "function btn{0}_Click() {{", strFuncName4Code);
                    strCodeForCs.AppendFormat("\r\n" + "require([\"../{1}{3}/{0}.js\"], function({2}) {{",
                        strClsName4UT_Js_Lower, objFuncModule.FuncModuleEnName4GC(), objPrjTabENEx.TabName.ToLower(), objvUserCodePathEN.SuffixPath);
                    strCodeForCs.AppendFormat("\r\n" + "{0}.{1}.btn{2}_Click();",
                        strTabName_Lower, strClsName4UT_JS, strFuncName4Code);
                    strCodeForCs.Append("\r\n" + "});");

                    strCodeForCs.Append("\r\n" + "}");

                }


                strCodeForCs.Append("\r\n" + "    </script>");

                strCodeForCs.Append("\r\n" + "</head>");


                strCodeForCs.Append("\r\n" + "<body>");
                //strCodeForCs.Append("\r\n" + "<form id = \"form1\" runat = \"server\">");

                ASPHiddenFieldEx objASPNETHiddenFieldENEx = new ASPHiddenFieldEx();
                objASPNETHiddenFieldENEx.CtrlId = "hidDivName";
                objASPNETHiddenFieldENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

                ASPHiddenFieldEx objASPNETHiddenFieldENEx2 = new ASPHiddenFieldEx();
                objASPNETHiddenFieldENEx2.CtrlId = "hidFldComparisonObjLst";
                objASPNETHiddenFieldENEx2.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

                //�����������ĵı�ǩ����
                clsLabelStyleEN objLabelStyle_Text = clsLabelStyleBL.GetObjByLabelStyleIdCache("0001");
                //��������1�ű���ı�ǩ����
                clsLabelStyleEN objLabelStyle_T1 = clsLabelStyleBL.GetObjByLabelStyleIdCache("0003");
                clsGenCtlStyleEN objGenCtlStyle = clsGenCtlStyleBL.GetObjByGenCtlStyleIdCache("0001");
                clsCheckStyleEN objCheckStyle = clsCheckStyleBL.GetObjByCheckStyleIdCache("0001");
                clsButtonStyleEN objButtonStyle = clsButtonStyleBL.GetObjByButtonStyleIdCache("0001");
                //0003:QUDIģʽ


                strCodeForCs.Append("\r\n" + "<div id = \"tabLayout\" class = \"tab_layout\" ");
                strCodeForCs.Append("\r\n" + "runat = \"server\">");
                strCodeForCs.Append("\r\n" + "<div id=\"divPageStatus\" style=\"width: 100%; float: left; margin-bottom:5px;\">");
                strCodeForCs.Append("\r\n" + "        <hr />");
                strCodeForCs.Append("\r\n" + "        <Label id=\"lblPageStatus\" name=\"lblPageStatus\" class=\"h6\" style=\"width:100px;height:24px;\">");
                strCodeForCs.Append("\r\n" + "            ҳ��״̬:");
                strCodeForCs.Append("\r\n" + "        </Label>");
                strCodeForCs.Append("\r\n" + "        <Label id=\"lblPageStatusContent\" name=\"lblPageStatusContent\" class=\"text-secondary\" style=\"width:600px;height:24px;\">");
                strCodeForCs.Append("\r\n" + "            ����״̬δ֪");
                strCodeForCs.Append("\r\n" + "        </Label>");
                strCodeForCs.Append("\r\n" + "    </div>");

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    //string strTemp = "";

                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    //strTemp = A_GeneFuncCode_Java(strFuncName);
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }
                //strTemp = A_GeneFuncCode_CS_DefButton("Gen_WA_WUT_Js_DefLabelMsg");
                //if (string.IsNullOrEmpty(strTemp) == false)
                //{
                //    strCodeForCs.Append("\r\n" + strTemp);
                //}

                strCodeForCs.Append("\r\n" + "</div>");

                //strCodeForCs.Append("\r\n" + "</form>");
                strCodeForCs.Append("\r\n" + "</body>");
                strCodeForCs.Append("\r\n" + "</html>");

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
        /// �̳�Runnable�����ʵ�ֵġ�run������  
        /// </summary>
        /// <returns></returns>
        public string Gen_WA_WUT_Js_DefButtonAddNewRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "AddNewRecord";

            string strFunctionName_CN = string.Format("{0}������¼�¼", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //��������������Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }

        public string Gen_WA_WUT_Js_DefButtonAddNewRecord4GetMaxStrId(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "AddNewRecord4GetMaxStrId";

            string strFunctionName_CN = string.Format("{0}������¼�¼(��ȡ���ؼ���)", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //��������������Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }

        public string Gen_WA_WUT_Js_DefButtonGetMaxStrId(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "GetMaxStrId";

            string strFunctionName_CN = string.Format("{0}����ȡ���ؼ���ֵ", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //��������������Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }

        public string Gen_WA_WUT_Js_DefButtonGetMaxStrIdByPrefix(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "GetMaxStrIdByPrefix";

            string strFunctionName_CN = string.Format("{0}����ȡ���ؼ���ֵ,����ǰ׺", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //��������������Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);


            return strCodeForCs.ToString();
        }

        public string Gen_WA_WUT_Js_DefButtonUpdateRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "UpdateRecord";

            string strFunctionName_CN = string.Format("{0}���޸ļ�¼", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //��������������Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);
            
         

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }
        public string Gen_WA_WUT_Js_DefButtonDelRecords(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
           StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "DelRecords";

            string strFunctionName_CN = string.Format("{0}��ɾ��������¼ͨ���ؼ��ִ�", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //��������������Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);


            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }

        public string Gen_WA_WUT_Js_DefButtonDelMultiRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "DelMultiRecord";

            string strFunctionName_CN = string.Format("{0}�����ݹؼ����б�ɾ��������¼", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //��������������Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);


            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }
        public string Gen_WA_WUT_Js_DefButtonDelMultiRecordByCond(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "DelMultiRecordByCond";

            string strFunctionName_CN = string.Format("{0}����������ɾ��������¼", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //��������������Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);


            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }

        public string Gen_WA_WUT_Js_DefButtonDelRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "DelRecord";
            string strFunctionName_CN = string.Format("{0}��ɾ����¼", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);
            //ASPLabelEx objASPNETLabelENEx = GetOrderNumLabel(intOrderNum);
            //objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETLabelENEx);

            //��������������Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);


            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }
        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��� 
        /// </summary>
        /// <returns></returns>
        public string Gen_WA_WUT_Js_DefButtonIsExistRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "IsExistRecord";

            string strFunctionName_CN = string.Format("{0}������Ƿ���ڼ�¼", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //��������������Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);


            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }

        public string Gen_WA_WUT_Js_DefButtonIsExistRecordCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "IsExistRecord";

            string strFunctionName_CN = string.Format("{0}������Ƿ���ڼ�¼", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //��������������Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);


            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }


        /// <summary>
        /// ���ݹؼ��ֻ�ȡ��Ӧ�ļ�¼�Ķ��� 
        /// </summary>
        /// <returns></returns>
        public string Gen_WA_WUT_Js_DefButtonIsExist(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "IsExistRecord";

            string strFunctionName_CN = string.Format("{0}������Ƿ���ڹؼ��ּ�¼", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //��������������Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);


            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }
        public string Gen_WA_WUT_Js_DefButtonIsExistCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "IsExistRecord";

            string strFunctionName_CN = string.Format("{0}������Ƿ���ڹؼ��ּ�¼", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //��������������Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);


            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// �������ڱ༭�Ĳ�Div,�ò���Ա�����
        /// </summary>
        /// <param name="objvFunction4GeneCodeEN"></param>
        /// <returns></returns>
        public string Gen_WA_WUT_Js_DefDiv4EditRegion(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.AppendFormat("\r\n" + " <div class=\"modal fade\" id=\"divEditDialog_{0}\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"lblDialogTitle_{0}\" aria-hidden=\"true\">", 
                objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + " <div class=\"modal-dialog modal-dialog-centered modal-dialog-scrollable\">");
            strCodeForCs.Append("\r\n" + " <div class=\"modal-content\">");
            strCodeForCs.Append("\r\n" + " <div class=\"modal-header\">");
            strCodeForCs.AppendFormat("\r\n" + " <h4 class=\"modal-title\" id=\"lblDialogTitle_{0}\">ģ̬��Modal������</h4>", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + " <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-hidden=\"true\">&times;</button>");
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " <div class=\"modal-body\">");
            strCodeForCs.Append("\r\n" + " <table style=\"width: 100%;\">");

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                ///������ֶβ��Ǳ�ʶ�����;����ɿؼ�,����Ͳ�����;
                if (objField.FieldTypeId == enumFieldType.KeyField_02
                  && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                strCodeForCs.AppendFormat("\r\n" + "<tr>");
                //strCodeForCs.AppendFormat("\r\n" + "<td>");
                ///������֤�ؼ�����;
                switch (objField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType)
                {
                    case "bool":
                        strCodeForCs.AppendFormat("\r\n" + "<td colspan='2'>");
                        strCodeForCs.AppendFormat("\r\n" + "<asp:CheckBox id = \"chk{0}\" runat = \"server\" Text = \"{1}\" CssClass = \"Check_Defa\"></asp:CheckBox>",
                          objField.ObjFieldTabENEx.FldName,
                          objField.ColCaption);
                        strCodeForCs.AppendFormat("\r\n" + "</td>");
                        //strCodeForCs.AppendFormat("\r\n" + "<td>");
                        //strCodeForCs.AppendFormat("\r\n" + "</td>");
                        break;
                    case "int":
                    case "short":
                    case "long":                      
                    case "DateTime":                       
                    case "double":
                    case "float":
                        strCodeForCs.AppendFormat("\r\n" + "<td class = \"NameTD\">");
                        strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"{0}\" runat = \"server\" CssClass = \"NameControl\">{1}</asp:Label>",
                          "lbl" + objField.ObjFieldTabENEx.FldName,
                          objField.ColCaption);
                        strCodeForCs.AppendFormat("\r\n" + "</td>");
                        strCodeForCs.AppendFormat("\r\n" + "<td class = \"ValueTD\">");
                        strCodeForCs.AppendFormat("\r\n" + "<asp:TextBox id = \"txt{0}\" runat = \"server\" CssClass = \"ValueControl\"></asp:TextBox>",
                          objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                        strCodeForCs.AppendFormat("\r\n" + "</td>");
                        break;
                    default:
                        strCodeForCs.AppendFormat("\r\n" + "<td class = \"NameTD\">");
                        strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"{0}\" runat = \"server\" CssClass = \"NameControl\">{1}</asp:Label>",
                          "lbl" + objField.ObjFieldTabENEx.FldName,
                          objField.ColCaption);
                        strCodeForCs.AppendFormat("\r\n" + "</td>");
                        strCodeForCs.AppendFormat("\r\n" + "<td class = \"ValueTD\">");
                        strCodeForCs.AppendFormat("\r\n" + "<asp:TextBox id = \"txt{0}\" runat = \"server\" CssClass = \"ValueControl\"></asp:TextBox>",
                          objField.ObjFieldTabENEx.FldName, objField.ColCaption);
                        strCodeForCs.AppendFormat("\r\n" + "</td>");
                        break;
                }
//                strCodeForCs.AppendFormat("\r\n" + "</td>");
                strCodeForCs.AppendFormat("\r\n" + "<td></td>");
                strCodeForCs.AppendFormat("\r\n" + "</tr>");
                //intZIndex += 1;
                //intCurrTop += 25;

            }

            //strCodeForCs.Append("\r\n" + " <tr>");
            //strCodeForCs.Append("\r\n" + " <td>1&nbsp;</td>");
            //strCodeForCs.Append("\r\n" + " <td>2&nbsp;</td>");
            //strCodeForCs.Append("\r\n" + " <td>3&nbsp;</td>");
            //strCodeForCs.Append("\r\n" + " </tr>");
            //strCodeForCs.Append("\r\n" + " <tr>");
            //strCodeForCs.Append("\r\n" + " <td>4&nbsp;</td>");
            //strCodeForCs.Append("\r\n" + " <td>5&nbsp;</td>");
            //strCodeForCs.Append("\r\n" + " <td>6&nbsp;</td>");
            //strCodeForCs.Append("\r\n" + " </tr>");
            strCodeForCs.Append("\r\n" + " </table>");
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " <div class=\"modal-footer\">");
            strCodeForCs.Append("\r\n" + " <button type=\"button\" class=\"btn btn-default\" data-dismiss=\"modal\">�ر�</button>");
            strCodeForCs.AppendFormat("\r\n" + " <button type=\"button\" class=\"btn btn-primary\" onclick=\"btn{0}_Edit_Click('Submit')\">�ύ����</button>", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " <!-- /.modal-content -->");
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " <!-- /.modal -->");
            strCodeForCs.Append("\r\n" + " </div>");

            return strCodeForCs.ToString();
        }

        public string Gen_WA_WUT_Js_DefButtonGetRecCountByCond(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "GetRecCountByCond";

            string strFunctionName_CN = string.Format("{0}������������ȡ��¼��", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //��������������Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);


            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }

        public string Gen_WA_WUT_Js_DefButtonGetRecCountByCondCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "GetRecCountByCond";

            string strFunctionName_CN = string.Format("{0}������������ȡ��¼��", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //��������������Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);


            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }

        public string Gen_WA_WUT_Js_DefButtonGetObjLst(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "GetObjLst";

            string strFunctionName_CN = string.Format("{0}����ȡ��¼�����б�", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //��������������Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }
        public string Gen_WA_WUT_Js_DefButtonGetObjLstByKeyLst(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "GetObjLst";

            string strFunctionName_CN = string.Format("{0}�����ݹؼ����б��ȡ�����б�", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //��������������Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }

        public string Gen_WA_WUT_Js_DefButtonGetObjLstByKeyLst_WACache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "GetObjLst";

            string strFunctionName_CN = string.Format("{0}�����ݹؼ����б��ȡ�����б�, ʹ��WebApi����", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //��������������Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }
        public string Gen_WA_WUT_Js_DefButtonGetObjLstByKeyLstCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "GetObjLst";

            string strFunctionName_CN = string.Format("{0}�����ݹؼ����б��ȡ�����б�, ʹ��WebApi����", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //��������������Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }


        public string Gen_WA_WUT_Js_DefButtonGetTopObjLst(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "GetTopObjLst";

            string strFunctionName_CN = string.Format("{0}����ȡ������¼�����б�", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //��������������Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }

        public string Gen_WA_WUT_Js_DefButtonGetObjLstByPager(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "GetObjLstByPager";

            string strFunctionName_CN = string.Format("{0}����ȡ��ҳ��¼�����б�", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //��������������Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);


            return strCodeForCs.ToString();
        }

        public string Gen_WA_WUT_Js_DefButtonGetObjLstByPager_WACache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "GetObjLstByPager";

            string strFunctionName_CN = string.Format("{0}����ȡ��ҳ��¼�����б�, ʹ��WebApi����", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //��������������Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);


            return strCodeForCs.ToString();
        }

        public string Gen_WA_WUT_Js_DefButtonGetObjLstByPagerCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "GetObjLstByPager";

            string strFunctionName_CN = string.Format("{0}����ȡ��ҳ��¼�����б�, ʹ��WebApi����", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //��������������Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);


            return strCodeForCs.ToString();
        }

        public string Gen_WA_WUT_Js_DefButtonGetSubObjLstCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "GetObjLstByPager";

            string strFunctionName_CN = string.Format("{0}����ȡ��ҳ��¼�����б�, ʹ��WebApi����", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //��������������Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);


            return strCodeForCs.ToString();
        }

        public string Gen_WA_WUT_Js_DefButtonGetSubObjLst_WACache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "GetObjLstByPager";

            string strFunctionName_CN = string.Format("{0}����ȡ��ҳ��¼�����б�, ʹ��WebApi����", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //��������������Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);


            return strCodeForCs.ToString();
        }

        public string Gen_WA_WUT_Js_DefButtonGetObjLstByRange(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "GetObjLstByRange";

            string strFunctionName_CN = string.Format("{0}����ȡ��Χ�ڼ�¼�����б�", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //��������������Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);


            return strCodeForCs.ToString();
        }
     

        public string Gen_WA_WUT_Js_DefButtonGetObjByKey(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "GetObjByKey";

            string strFunctionName_CN = string.Format("{0}�����ݹؼ��ֻ�ȡ����", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //��������������Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);


            return strCodeForCs.ToString();
        }

        public string Gen_WA_WUT_Js_DefButtonGetObjByKeyCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "GetObjByKey";

            string strFunctionName_CN = string.Format("{0}�����ݹؼ��ֻ�ȡ����, ʹ��WebApi����", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //��������������Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);


            return strCodeForCs.ToString();
        }

        public string Gen_WA_WUT_Js_DefButtonGetObjByKey_WACache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "GetObjByKey";

            string strFunctionName_CN = string.Format("{0}�����ݹؼ��ֻ�ȡ����, ʹ��WebApi����", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //��������������Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);


            return strCodeForCs.ToString();
        }

        public string Gen_WA_WUT_Js_DefButtonGetFirstObj(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "GetFirstObj";

            string strFunctionName_CN = string.Format("{0}����ȡ���������ĵ�һ����¼����", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //��������������Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }

        public ASPLabelEx GetOrderNumLabel_JS(int intOrderNum)
        {


            ASPLabelEx objASPNETLabelENEx = new ASPLabelEx();
            objASPNETLabelENEx.CtrlId = string.Format("lblOrderNum{0}", intOrderNum);
            objASPNETLabelENEx.Text = string.Format("��{0}��������", intOrderNum);
            objASPNETLabelENEx.Width = 80;
            objASPNETLabelENEx.Height = 24;

            return objASPNETLabelENEx;
        }
        public ASPDivEx GetParaInputCtrlGroup_JS(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            ASPDivEx objASPNETDivENEx = new ASPDivEx();
            objASPNETDivENEx.CtrlId = string.Format("divParaGroup{0}", objvFunction4GeneCodeEN.OrderNum);
            objASPNETDivENEx.Style = string.Format("width: 100%; float: left");
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GCCache(objvFunction4GeneCodeEN.FuncId4GC);
            GC_GetInputValueCtrl4Para(objFunction4GeneCodeEN.FuncId4Code, objvFunction4GeneCodeEN.OrderNum, objASPNETDivENEx);
            ASPDivEx objASPNETDivENEx_Edit = new ASPDivEx();
            objASPNETDivENEx_Edit.CtrlId = string.Format("divEditFldComparison{0}", objvFunction4GeneCodeEN.OrderNum);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Edit);
            return objASPNETDivENEx;


        }

        public string Gen_WA_WUT_Js_DefLabelMsg(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();


            ASPLabelEx objASPNETLabelENEx = new ASPLabelEx();
            objASPNETLabelENEx.CtrlId = string.Format("lblMsg");
            objASPNETLabelENEx.Text = "��ʾ���";
            objASPNETLabelENEx.Width = 200;
            objASPNETLabelENEx.Height = 24;
            objASPNETLabelENEx.mTextSize = "12sp";
            objASPNETLabelENEx.minHeight = "35dp";

            //objASPNETLabelENEx.layout_constraintStart_toStartOf = "parent";
            //objASPNETLabelENEx.layout_constraintTop_toBottomOf = "@+id/txtNum2";
            objASPNETLabelENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }

        public string Gen_WA_WUT_Js_DefButtonByCommonFunction(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            ASPDivEx objASPNETDivENEx = new ASPDivEx();
            objASPNETDivENEx.CtrlId = string.Format("div{0}", objWebSrvFunctionsENEx.FunctionName);
            objASPNETDivENEx.Style = string.Format("width: 100%; float: left");

            ASPButtonEx objASPNETButtonENEx = new ASPButtonEx();
            objASPNETButtonENEx.CtrlId = string.Format("btn{0}", objWebSrvFunctionsENEx.FunctionName);
            objASPNETButtonENEx.OnClick = string.Format("btn{0}_Click", objWebSrvFunctionsENEx.FunctionName); ;
            objASPNETButtonENEx.Text = objWebSrvFunctionsENEx.FunctionName;
            objASPNETButtonENEx.Width = 200;
            objASPNETButtonENEx.Height = 24;
            objASPNETButtonENEx.mTextSize = "12sp";
            objASPNETButtonENEx.minHeight = "35dp";

            //ASPDivEx objASPNETDivENEx_Para = GetParaInputCtrlGroup(objvFunction4GeneCodeEN);
            //objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Para);

            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETButtonENEx);

            //�����ʾ����Ŀؼ�
            //ASPDivEx objASPNETDivENEx_ShowResult = GetFunctionResultDiv(objvFunction4GeneCodeEN);
            //objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_ShowResult);

            //���ˮƽ��
            ASPHrEx objASPNETHrENEx = new ASPHrEx();
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETHrENEx);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }

        public string GetLinearLayout4FunctionByCommonFunction_JS(clsWebSrvFunctionsENEx objWebSrvFunctionsENEx)
        {

            StringBuilder strCodeForCs = new StringBuilder();

            ASPDivEx objASPNETDivENEx = new ASPDivEx();
            objASPNETDivENEx.CtrlId = string.Format("div{0}", objWebSrvFunctionsENEx.FunctionName);
            objASPNETDivENEx.Style = string.Format("width: 100%; float: left");

            ASPButtonEx objASPNETButtonENEx = new ASPButtonEx();
            objASPNETButtonENEx.CtrlId = string.Format("btn{0}", objWebSrvFunctionsENEx.FunctionName);
            objASPNETButtonENEx.OnClick = string.Format("btn{0}_Click", objWebSrvFunctionsENEx.FunctionName); ;
            objASPNETButtonENEx.Text = objWebSrvFunctionsENEx.FunctionName;
            objASPNETButtonENEx.Width = 200;
            objASPNETButtonENEx.Height = 24;
            objASPNETButtonENEx.mTextSize = "12sp";
            objASPNETButtonENEx.minHeight = "35dp";

            //ASPDivEx objASPNETDivENEx_Para = GetParaInputCtrlGroup(objvFunction4GeneCodeEN);
            //objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Para);

            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETButtonENEx);

            //�����ʾ����Ŀؼ�
            //ASPDivEx objASPNETDivENEx_ShowResult = GetFunctionResultDiv(objvFunction4GeneCodeEN);
            //objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_ShowResult);

            //���ˮƽ��
            ASPHrEx objASPNETHrENEx = new ASPHrEx();
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETHrENEx);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);



            return strCodeForCs.ToString();
        }
        private void GC_GetInputValueCtrl4Para_JS(string strFuncId4Code, int intOrderNum, ASPDivEx objASPNETDivENEx)
        {
            string strMsg = "";
            //            StringBuilder strCodeForCs = new StringBuilder();
            List<clsFuncPara4CodeEN> arrFuncPara4CodeObjLst =
  clsFuncPara4CodeBLEx.GetObjListByFuncId4CodeCacheEx(strFuncId4Code, enumFunctionPurpose.GeneCode_01);
            if (arrFuncPara4CodeObjLst == null) return;
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
                ASPDivEx objASPNETDivENEx_Para = new ASPDivEx();
                objASPNETDivENEx_Para.CtrlId = string.Format("divPara{0}{1}", objFuncPara4CodeEN.ParaName, intOrderNum);
                objASPNETDivENEx_Para.Style = string.Format("width: 100%; float: left");

                ASPLabelEx objASPNETLabelENEx = new ASPLabelEx();
                objASPNETLabelENEx.CtrlId = string.Format("lblPara{0}{1}", objFuncPara4CodeEN.ParaName, intOrderNum);
                objASPNETLabelENEx.Text = objFuncPara4CodeEN.ParaName;
                objASPNETLabelENEx.Width = 200;
                objASPNETLabelENEx.Height = 24;

                objASPNETDivENEx_Para.arrSubAspControlLst2.Add(objASPNETLabelENEx);

                if (objDataTypeAbbrEN.IsNeedQuote == true)
                {
                    ASPTextBoxEx objASPNETTextBoxENEx = new ASPTextBoxEx();
                    objASPNETTextBoxENEx.CtrlId = string.Format("txt{0}{1}", objFuncPara4CodeEN.ParaName, intOrderNum);
                    if (objFuncPara4CodeEN.ParaName.IndexOf("Where") > 0)
                    {
                        objASPNETTextBoxENEx.Text = string.Format("1=1", intOrderNum);
                    }
                    objASPNETTextBoxENEx.Width = 80;
                    objASPNETTextBoxENEx.Height = 24;
                    objASPNETDivENEx_Para.arrSubAspControlLst2.Add(objASPNETTextBoxENEx);

                    objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Para);
                }
                else
                {
                    ASPTextBoxEx objASPNETTextBoxENEx = new ASPTextBoxEx();
                    objASPNETTextBoxENEx.CtrlId = string.Format("txt{0}{1}", objFuncPara4CodeEN.ParaName, intOrderNum);
                    if (objFuncPara4CodeEN.ParaName.IndexOf("pageSize") > 0)
                    {
                        objASPNETTextBoxENEx.Text = string.Format("5", intOrderNum);
                    }
                    else if (objFuncPara4CodeEN.ParaName.IndexOf("pageIndex") > 0)
                    {
                        objASPNETTextBoxENEx.Text = string.Format("1", intOrderNum);
                    }
                    else if (objFuncPara4CodeEN.ParaName.IndexOf("topSize") > 0)
                    {
                        objASPNETTextBoxENEx.Text = string.Format("3", intOrderNum);
                    }
                    else if (objFuncPara4CodeEN.ParaName.IndexOf("Min") > 0)
                    {
                        objASPNETTextBoxENEx.Text = string.Format("2", intOrderNum);
                    }
                    else if (objFuncPara4CodeEN.ParaName.IndexOf("Max") > 0)
                    {
                        objASPNETTextBoxENEx.Text = string.Format("5", intOrderNum);
                    }

                    objASPNETTextBoxENEx.Width = 80;
                    objASPNETTextBoxENEx.Height = 24;
                    objASPNETDivENEx_Para.arrSubAspControlLst2.Add(objASPNETTextBoxENEx);

                    objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Para);

                }
            }

        }
      
        public ASPDivEx GetFunctionGroupDiv_JS(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4CodeEN objFunction4CodeEN = clsFunction4CodeBL.GetObjByFuncId4CodeCache(objvFunction4GeneCodeEN.FuncId4Code);// "UpdateRecord";
            string strFunctionName = TransKeyWords4FuncName(  objFunction4CodeEN.FuncName4Code);


            //string strFunctionName_CN = string.Format("{0}������Ƿ���ڼ�¼", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = new ASPDivEx();
            objASPNETDivENEx.CtrlId = string.Format("div{0}", strFunctionName);
            objASPNETDivENEx.Style = string.Format("width: 100%; float: left; margin-bottom:5px;");
            objASPNETDivENEx.Class = "function";
            
            //���ˮƽ��
            ASPHrEx objASPNETHrENEx = new ASPHrEx();
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETHrENEx);

            ASPDivEx objASPNETDivENEx_Title = GetDiv4FuncTitle_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Title);

            return objASPNETDivENEx;
        }

        private ASPDivEx GetFunctionResultDiv_JS(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4CodeEN objFunction4CodeEN = clsFunction4CodeBL.GetObjByFuncId4CodeCache(objvFunction4GeneCodeEN.FuncId4Code);// "UpdateRecord";
            string strFunctionName =TransKeyWords4FuncName( objFunction4CodeEN.FuncName4Code);

            string strFunctionName_CN = string.Format("{0}��{1}", objvFunction4GeneCodeEN.OrderNum, objFunction4CodeEN.FuncCHName4Code);

            ASPDivEx objASPNETDivENEx_Para = new ASPDivEx();
            objASPNETDivENEx_Para.CtrlId = string.Format("divResult{0}", objvFunction4GeneCodeEN.OrderNum);
            objASPNETDivENEx_Para.Style = string.Format("width: 100%; float: left");

            ASPHtmlButtonEx objASPNETButtonENEx = new ASPHtmlButtonEx();
            //objASPNETButtonENEx.Is4PureHtml = true;
            objASPNETButtonENEx.CtrlId = string.Format("btn{0}", strFunctionName);
            if (strFunctionName.Contains("Add") == true)
            {
                objASPNETButtonENEx.OnClick = string.Format("ShowDialog{1}('Add');", strFunctionName, objPrjTabENEx.TabName); ;
            }
            else if (strFunctionName.Contains("Update") == true)
            {
                objASPNETButtonENEx.OnClick = string.Format("this.ShowDialog_{1}('Update');", strFunctionName, objPrjTabENEx.TabName); ;
            }
            else
            {
                objASPNETButtonENEx.OnClick = string.Format("btn{0}_Click()", strFunctionName, objPrjTabENEx.TabName); ;
            }
            objASPNETButtonENEx.Value = strFunctionName_CN;

            objASPNETButtonENEx.Width = 400;
            objASPNETButtonENEx.Height = 24;
            objASPNETButtonENEx.Class = "btn btn-outline-info btn-sm";

            objASPNETButtonENEx.Style = "width:400px;";
            objASPNETButtonENEx.mTextSize = "12sp";
            objASPNETButtonENEx.minHeight = "35dp";
         

            ASPLabelEx objASPNETLabelENEx2 = new ASPLabelEx();
            //objASPNETLabelENEx2.Is4PureHtml = true;
            objASPNETLabelENEx2.CtrlId = string.Format("lblResult{0}", objvFunction4GeneCodeEN.OrderNum);
            objASPNETLabelENEx2.Text = "���";
            objASPNETLabelENEx2.CssClass = "Content";
            objASPNETLabelENEx2.Width = 600;
            objASPNETLabelENEx2.Height = 24;

            ASPDivEx objASPNETDivENEx_List = new ASPDivEx();
            objASPNETDivENEx_List.CtrlId = string.Format("divList{0}", objvFunction4GeneCodeEN.OrderNum);
            objASPNETDivENEx_List.Style = string.Format("width: 100%; float: left");

            objASPNETDivENEx_Para.arrSubAspControlLst2.Add(objASPNETButtonENEx);
            objASPNETDivENEx_Para.arrSubAspControlLst2.Add(objASPNETLabelENEx2);
            objASPNETDivENEx_Para.arrSubAspControlLst2.Add(objASPNETDivENEx_List);
            return objASPNETDivENEx_Para;
            
        }
        /// <summary>
        /// ���������ı���Div
        /// </summary>
        /// <param name="objvFunction4GeneCodeEN"></param>
        /// <returns></returns>
        public ASPDivEx GetDiv4FuncTitle_JS(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4CodeEN objFunction4CodeEN = clsFunction4CodeBL.GetObjByFuncId4CodeCache(objvFunction4GeneCodeEN.FuncId4Code);// "UpdateRecord";
            string strFunctionName = TransKeyWords4FuncName( objFunction4CodeEN.FuncName4Code);
            //string strFunctionName = "DelRecord";
            string strFunctionName_CN = string.Format("{0}��{1}({2})", 
                objvFunction4GeneCodeEN.OrderNum, objFunction4CodeEN.FuncCHName4Code, objFunction4CodeEN.FuncName4Code);

            //< div class="title" style="width:100%">
            //      <div style = "float:left; width:80%; " >
            //                 < asp:Label ID = "lblIsExistRecord4Title" Width="600px" Height="24px" Text="���" runat="server" />

            //      </div>
            //      <div style = "float:right; width:20%; " >
            //          < input id="btnIsExistRecord4Expand" type="button" value="չ��" onclick="ExpandDiv('divGen_WA_WUT_Js_DefButtonIsExistRecord')" />
            //      </div>
            //  </div>
            ASPDivEx objASPNETDivENEx = new ASPDivEx();
            objASPNETDivENEx.Class = "title";
            objASPNETDivENEx.Style = "width:100%; height:25px;";

            {
                ASPDivEx objASPNETDivENEx_Left = new ASPDivEx();

                objASPNETDivENEx_Left.Style = "float:left; width:80%;";
                //clsASPLabelBLEx.GeneCode
                ASPLabelEx objASPNETLabelENEx = new ASPLabelEx();
                //objASPNETLabelENEx.Is4PureHtml = true;
                objASPNETLabelENEx.CtrlId = string.Format("lblTitle{0}", objvFunction4GeneCodeEN.OrderNum);
                objASPNETLabelENEx.Text = string.Format("���ԣ�{0}", strFunctionName_CN);
                objASPNETLabelENEx.CssClass = "h6";
                objASPNETLabelENEx.Width = 700;
                objASPNETLabelENEx.Height = 20;

                objASPNETDivENEx_Left.arrSubAspControlLst2.Add(objASPNETLabelENEx);

                objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Left);

            }
            {
                ASPDivEx objASPNETDivENEx_Right = new ASPDivEx();

                objASPNETDivENEx_Right.Style = "float:right; width:20%;";

                ASPHtmlButtonEx objASPNETHtmlButtonENEx = new ASPHtmlButtonEx();
                objASPNETHtmlButtonENEx.CtrlId = string.Format("btnExpand{0}", strFunctionName);
                objASPNETHtmlButtonENEx.Value = string.Format("չ��");
                var arrFuncPara4Code = clsFuncPara4CodeBLEx.GetObjListByFuncId4CodeCacheEx(objFunction4CodeEN.FuncId4Code, enumFunctionPurpose.GeneCode_01);
                if (arrFuncPara4Code == null)
                {
                    objASPNETHtmlButtonENEx.OnClick = string.Format("ExpandDiv('div{0}');", strFunctionName);
                }
                else
                {
                    var arrFuncPara4Code_Sel = arrFuncPara4Code.Where(x => x.DataTypeId == enumDataTypeAbbr.Object_29);
                    if (arrFuncPara4Code_Sel.Count() > 0)
                    {
                        objASPNETHtmlButtonENEx.OnClick = string.Format("ExpandDiv('div{0}', true, 'divEditFldComparison{1}');", strFunctionName, objvFunction4GeneCodeEN.OrderNum);
                    }
                    else
                    {
                        objASPNETHtmlButtonENEx.OnClick = string.Format("ExpandDiv('div{0}');", strFunctionName);
                    }
                }
                objASPNETHtmlButtonENEx.Width = 300;
                objASPNETHtmlButtonENEx.Height = 24;

                objASPNETDivENEx_Right.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                
                objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Right);
            }
            
            return objASPNETDivENEx;
        }

        /// <summary>
        /// ��������������Div
        /// </summary>
        /// <param name="objvFunction4GeneCodeEN"></param>
        /// <returns></returns>
        public ASPDivEx GetDiv4FuncContent_JS(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4CodeEN objFunction4CodeEN = clsFunction4CodeBL.GetObjByFuncId4CodeCache(objvFunction4GeneCodeEN.FuncId4Code);// "UpdateRecord";
            string strFunctionName = TransKeyWords4FuncName( objFunction4CodeEN.FuncName4Code);

            string strFunctionName_CN = string.Format("{0}��{1}", objvFunction4GeneCodeEN.OrderNum, objFunction4CodeEN.FuncCHName4Code);

            ASPDivEx objASPNETDivENEx = new ASPDivEx();
            objASPNETDivENEx.Class = "content";
            objASPNETDivENEx.Style = "width: 100%";

            {
                ASPDivEx objASPNETDivENEx_Para = GetParaInputCtrlGroup_JS(objvFunction4GeneCodeEN);
                objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Para);
            }
            //{
            //    ASPDivEx objASPNETDivENEx_Button = new ASPDivEx();
            //    objASPNETDivENEx_Button.Class = "button";
            //    objASPNETDivENEx_Button.Style = "width: 100%";

            //    ASPButtonEx objASPNETButtonENEx = new ASPButtonEx();
            //    objASPNETButtonENEx.CtrlId = string.Format("btn{0}", strFunctionName);
            //    objASPNETButtonENEx.OnClick = string.Format("btn{0}_Click", strFunctionName); ;
            //    objASPNETButtonENEx.Text = strFunctionName_CN;
            //    objASPNETButtonENEx.Width = 200;
            //    objASPNETButtonENEx.Height = 24;
            //    objASPNETButtonENEx.mTextSize = "12sp";
            //    objASPNETButtonENEx.minHeight = "35dp";
            //    objASPNETDivENEx_Button.arrSubAspControlLst2.Add(objASPNETButtonENEx);
            //    objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Button);
            //}
            //�����ʾ����Ŀؼ�
            ASPDivEx objASPNETDivENEx_ShowResult = GetFunctionResultDiv_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_ShowResult);

            return objASPNETDivENEx;

            //objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            //return strCodeForCs.ToString();
        }
  //      private void GC_GetInputValueCtrl4Para(string strFuncId4Code, int intOrderNum, ASPDivEx objASPNETDivENEx)
  //      {
  //          string strMsg = "";
  //          //            StringBuilder strCodeForCs = new StringBuilder();
  //          List<clsFuncPara4CodeEN> arrFuncPara4CodeObjLst =
  //clsFuncPara4CodeBLEx.GetObjListByFuncId4CodeCacheEx(strFuncId4Code);
  //          if (arrFuncPara4CodeObjLst == null) return;
  //          foreach (clsFuncPara4CodeEN objFuncPara4CodeEN in arrFuncPara4CodeObjLst)
  //          {
  //              clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFuncPara4CodeEN.DataTypeId);
  //              clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;
  //              if (objDataTypeAbbrEN == null)
  //              {
  //                  objSelfDefDataTypeEN_Para = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objFuncPara4CodeEN.ParameterType);
  //                  if (objSelfDefDataTypeEN_Para == null)
  //                  {
  //                      strMsg = string.Format("�����������������ͣ�[{0}({1})]û�д���,����������Ӧ���롣", objDataTypeAbbrEN.DataTypeId,
  //                          objFuncPara4CodeEN.ParameterType);
  //                      throw new Exception(strMsg);
  //                  }
  //              }
  //              if (objFuncPara4CodeEN.IsByRef == true)
  //              {
  //                  strMsg = string.Format("Java���������Ĳ����������Ͳ�������������[{0}],�������ͣ�[{1}]û�д���,����������Ӧ���롣",
  //                     objFuncPara4CodeEN.ParaName,
  //                       objFuncPara4CodeEN.ParameterType);
  //                  throw new Exception(strMsg);
  //              }
  //              ASPDivEx objASPNETDivENEx_Para = new ASPDivEx();
  //              objASPNETDivENEx_Para.CtrlId = string.Format("divPara{0}{1}", objFuncPara4CodeEN.ParaName, intOrderNum);
  //              objASPNETDivENEx_Para.Style = string.Format("width: 100%; float: left");

  //              ASPLabelEx objASPNETLabelENEx = new ASPLabelEx();
  //              objASPNETLabelENEx.CtrlId = string.Format("lblPara{0}{1}", objFuncPara4CodeEN.ParaName, intOrderNum);
  //              objASPNETLabelENEx.Text = objFuncPara4CodeEN.ParaName;
  //              objASPNETLabelENEx.Width = 200;
  //              objASPNETLabelENEx.Height = 24;

  //              objASPNETDivENEx_Para.arrSubAspControlLst2.Add(objASPNETLabelENEx);

  //              if (objDataTypeAbbrEN.IsNeedQuote == true)
  //              {
  //                  ASPTextBoxEx objASPNETTextBoxENEx = new ASPTextBoxEx();
  //                  objASPNETTextBoxENEx.CtrlId = string.Format("txt{0}{1}", objFuncPara4CodeEN.ParaName, intOrderNum);
  //                  if (objFuncPara4CodeEN.ParaName.IndexOf("Where") > 0)
  //                  {
  //                      objASPNETTextBoxENEx.Text = string.Format("1=1", intOrderNum);
  //                  }
  //                  objASPNETTextBoxENEx.Width = 80;
  //                  objASPNETTextBoxENEx.Height = 24;
  //                  objASPNETDivENEx_Para.arrSubAspControlLst2.Add(objASPNETTextBoxENEx);

  //                  objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Para);
  //              }
  //              else
  //              {
  //                  ASPTextBoxEx objASPNETTextBoxENEx = new ASPTextBoxEx();
  //                  objASPNETTextBoxENEx.CtrlId = string.Format("txt{0}{1}", objFuncPara4CodeEN.ParaName, intOrderNum);
  //                  if (objFuncPara4CodeEN.ParaName.IndexOf("pageSize") > 0)
  //                  {
  //                      objASPNETTextBoxENEx.Text = string.Format("5", intOrderNum);
  //                  }
  //                  else if (objFuncPara4CodeEN.ParaName.IndexOf("pageIndex") > 0)
  //                  {
  //                      objASPNETTextBoxENEx.Text = string.Format("1", intOrderNum);
  //                  }
  //                  else if (objFuncPara4CodeEN.ParaName.IndexOf("topSize") > 0)
  //                  {
  //                      objASPNETTextBoxENEx.Text = string.Format("3", intOrderNum);
  //                  }
  //                  else if (objFuncPara4CodeEN.ParaName.IndexOf("Min") > 0)
  //                  {
  //                      objASPNETTextBoxENEx.Text = string.Format("2", intOrderNum);
  //                  }
  //                  else if (objFuncPara4CodeEN.ParaName.IndexOf("Max") > 0)
  //                  {
  //                      objASPNETTextBoxENEx.Text = string.Format("5", intOrderNum);
  //                  }

  //                  objASPNETTextBoxENEx.Width = 80;
  //                  objASPNETTextBoxENEx.Height = 24;
  //                  objASPNETDivENEx_Para.arrSubAspControlLst2.Add(objASPNETTextBoxENEx);

  //                  objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Para);

  //              }
  //          }

  //      }

    }

}
