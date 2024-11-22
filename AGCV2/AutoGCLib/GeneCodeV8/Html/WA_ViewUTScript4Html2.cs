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
    /// 该类专门用生成数据表的表代理层,该代理层是逻辑层的一部分,体系结构从下到下,
    /// 共分以下几层:
    ///		1、界面层
    ///			通用界面层,专门提供一些界面控件的公共操作函数
    ///		2、逻辑层
    ///			2.1 业务逻辑层
    ///			2.2 表代理层。包括:
    ///					1)表记录的添加、
    ///					2)表记录的删除
    ///					3)表记录的修改
    ///					4)表记录的查询
    ///					5)获取某些表记录的有关字段属性
    ///					6)设置表记录的有关字段属性等。
    ///		3、数据层,即通用数据层,专门用于操作数据库的一些操作,以及操作表的一些通用操作
    /// </summary>
    partial class WA_ViewUTScript4Html : clsGeneCodeBase
    {

        //public WA_ViewUTScript4Html()
        //{


        //    // 
        //    // TODO: 在此处添加构造函数逻辑
        //    //
        //}
        //public WA_ViewUTScript4Html(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
        //  : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
        //{
        //    // 
        //    // TODO: 在此处添加构造函数逻辑
        //    //
        //}
        /// <summary>
        /// 生成指定的函数
        /// </summary>
        /// <returns>返回生成的指定函数代码</returns>
        public string A_GenCode4Function_CS_Ts_DefButtonBak(string strFuncId4GC)
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; //临时变量;
            string strFuncName = "";
            try
            {
                //类名开始
                // clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
                string strCondition = string.Format("{0}='{1}'", convFunction4GeneCode.FuncId4GC, strFuncId4GC);
                clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBL.GetFirstObj_S(strCondition);

                //strFuncName = objFunction4GeneCodeEN.FuncName;

                //if (objFunction4GeneCodeEN.FuncTypeId == "10")//用户自定义函数
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
                string strMsg = string.Format("在生成函数:[{0}]时出错。错误信息:{1}.({2})", strFuncName,
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
                        string strMsg = string.Format("功能名:{1}在Switch没有处理,请检查({0})",
                             clsStackTrace.GetCurrClassFunction(), objvFunction4GeneCodeEN.FuncName);
                        throw new Exception(strMsg);
                        //            return "///该1函数不存在:" + strFuncName;
                }
            }
            catch (Exception objException)
            {
                StringBuilder sbMessage = new StringBuilder();
                sbMessage.AppendFormat("在生成函数:{0}时出错. \r\n出错信息:{1}.", objvFunction4GeneCodeEN.FuncName, objException.Message);
                throw new Exception(sbMessage.ToString());
            }
        }


        /// <summary>
        /// 生成Web Service转换层代码
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
            //if (objPrjTabENEx.SqlDsTypeId == enumSQLDSType.SqlView_02) return "";
            string strResult = "";
            if (objPrjTabENEx.TabFldNum() == 0)
            {
                strResult = string.Format("当前表:[{0}]的字段数为0,无法生成通用逻辑层({1})",
                        objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            if (objPrjTabENEx.KeyFldNum() == 0)
            {
                strResult = string.Format("当前表:[{0}]的关键字的个数为0,无法生成通用逻辑层({1})",
                   objPrjTabENEx.TabName, clsStackTrace.GetCurrClassFunction());
                throw new clsDbObjException(strResult);
            }
            objPrjTabENEx.CurrDate = clsDateTime.getTodayStr2(0);

            //让用户设置属性;
            //string strFolder;
            string strClassFName;
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp = ""; ///临时变量;

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
                //生成插入记录的界面代码;
                //      strCodeForCs.Append("///生成查询、修改、删除、添加记录的界面代码(利用控件)");
                //strCodeForCs.AppendFormat("\r\n" + "<%@ Page language = \"c#\" AutoEventWireup = \"true\" CodeBehind = \"{0}.aspx.cs\" Inherits = \"{1}.WApiForm.{0}\" %>",
                //  objPrjTabENEx.ClsName, objProjectsENEx.PrjDomain);
                strCodeForCs.Append("\r\n" + "<!DOCTYPE html>");
                strCodeForCs.Append("\r\n" + "<html>");
                strCodeForCs.Append("\r\n" + "<head>");
                strCodeForCs.Append("\r\n" + "<meta charset = \"utf-8\" />");
                strCodeForCs.AppendFormat("\r\n" + "<title>{0}-单元测试 </title>", objPrjTabENEx.TabCnName);
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

                strCodeForCs.Append("\r\n" + "//基于RequireJS来调用tzPubFun.ts中的函数OnlyShowDiv。");
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
                strCodeForCs.Append("\r\n" + "            $(\"#lblPageStatusContent\").attr(\"value\", bb);// 布尔型");
                strCodeForCs.Append("\r\n" + "        });");
                strCodeForCs.Append("\r\n" + "    }");

                strCodeForCs.AppendFormat("\r\n" + "function ShowDialog_{0}(pstrOp) {{", objViewInfoENEx.TabName_In);
                strCodeForCs.Append("\r\n" + "            strOp = pstrOp;");
                strCodeForCs.Append("\r\n" + "require(['jquery', 'bootstrap'], function($) {");
                strCodeForCs.Append("\r\n" + "            if (strOp === \"Add\" || strOp === \"AddWithMaxId\") {");
                strCodeForCs.AppendFormat("\r\n" + "                $('#lblDialogTitle_{0}').html('添加记录');", objViewInfoENEx.TabName_In);
                strCodeForCs.Append("\r\n" + "            }");
                strCodeForCs.Append("\r\n" + "            else {");
                strCodeForCs.AppendFormat("\r\n" + "                $('#lblDialogTitle_{0}').html('修改记录');", objViewInfoENEx.TabName_In);
                strCodeForCs.Append("\r\n" + "            }");
                strCodeForCs.AppendFormat("\r\n" + "            $('#divEditDialog_{0}').modal('show');", objViewInfoENEx.TabName_In);
                strCodeForCs.Append("\r\n" + "});");
                strCodeForCs.Append("\r\n" + "        }");
                strCodeForCs.Append("\r\n" + "        function Submit_{0}(pstrOp) {  ");
                strCodeForCs.Append("\r\n" + "            alert(\"提交\" + strOp);");
      
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
                //基于RequireJS, 需要生成界面中通过Js函数来调用Ts的函数,
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

                //用来定义正文的标签类型
                clsLabelStyleEN objLabelStyle_Text = clsLabelStyleBL.GetObjByLabelStyleIdCache("0001");
                //用来定义1号标题的标签类型
                clsLabelStyleEN objLabelStyle_T1 = clsLabelStyleBL.GetObjByLabelStyleIdCache("0003");
                clsGenCtlStyleEN objGenCtlStyle = clsGenCtlStyleBL.GetObjByGenCtlStyleIdCache("0001");
                clsCheckStyleEN objCheckStyle = clsCheckStyleBL.GetObjByCheckStyleIdCache("0001");
                clsButtonStyleEN objButtonStyle = clsButtonStyleBL.GetObjByButtonStyleIdCache("0001");
                //0003:QUDI模式


                strCodeForCs.Append("\r\n" + "<div id = \"tabLayout\" class = \"tab_layout\" ");
                strCodeForCs.Append("\r\n" + "runat = \"server\">");
                strCodeForCs.Append("\r\n" + "<div id=\"divPageStatus\" style=\"width: 100%; float: left; margin-bottom:5px;\">");
                strCodeForCs.Append("\r\n" + "        <hr />");
                strCodeForCs.Append("\r\n" + "        <Label id=\"lblPageStatus\" name=\"lblPageStatus\" class=\"h6\" style=\"width:100px;height:24px;\">");
                strCodeForCs.Append("\r\n" + "            页面状态:");
                strCodeForCs.Append("\r\n" + "        </Label>");
                strCodeForCs.Append("\r\n" + "        <Label id=\"lblPageStatusContent\" name=\"lblPageStatusContent\" class=\"text-secondary\" style=\"width:600px;height:24px;\">");
                strCodeForCs.Append("\r\n" + "            缓存状态未知");
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
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        /// <summary>
        /// 继承Runnable类必须实现的【run】函数  
        /// </summary>
        /// <returns></returns>
        public string Gen_WA_WUT_Js_DefButtonAddNewRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "AddNewRecord";

            string strFunctionName_CN = string.Format("{0}、添加新记录", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //建立函数的内容Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }

        public string Gen_WA_WUT_Js_DefButtonAddNewRecord4GetMaxStrId(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "AddNewRecord4GetMaxStrId";

            string strFunctionName_CN = string.Format("{0}、添加新记录(获取最大关键字)", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //建立函数的内容Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }

        public string Gen_WA_WUT_Js_DefButtonGetMaxStrId(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "GetMaxStrId";

            string strFunctionName_CN = string.Format("{0}、获取最大关键字值", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //建立函数的内容Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }

        public string Gen_WA_WUT_Js_DefButtonGetMaxStrIdByPrefix(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "GetMaxStrIdByPrefix";

            string strFunctionName_CN = string.Format("{0}、获取最大关键字值,根据前缀", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //建立函数的内容Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);


            return strCodeForCs.ToString();
        }

        public string Gen_WA_WUT_Js_DefButtonUpdateRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "UpdateRecord";

            string strFunctionName_CN = string.Format("{0}、修改记录", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //建立函数的内容Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);
            
         

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }
        public string Gen_WA_WUT_Js_DefButtonDelRecords(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
           StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "DelRecords";

            string strFunctionName_CN = string.Format("{0}、删除多条记录通过关键字串", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //建立函数的内容Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);


            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }

        public string Gen_WA_WUT_Js_DefButtonDelMultiRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "DelMultiRecord";

            string strFunctionName_CN = string.Format("{0}、根据关键字列表删除多条记录", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //建立函数的内容Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);


            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }
        public string Gen_WA_WUT_Js_DefButtonDelMultiRecordByCond(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "DelMultiRecordByCond";

            string strFunctionName_CN = string.Format("{0}、根据条件删除多条记录", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //建立函数的内容Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);


            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }

        public string Gen_WA_WUT_Js_DefButtonDelRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "DelRecord";
            string strFunctionName_CN = string.Format("{0}、删除记录", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);
            //ASPLabelEx objASPNETLabelENEx = GetOrderNumLabel(intOrderNum);
            //objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETLabelENEx);

            //建立函数的内容Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);


            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }
        /// <summary>
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public string Gen_WA_WUT_Js_DefButtonIsExistRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "IsExistRecord";

            string strFunctionName_CN = string.Format("{0}、检查是否存在记录", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //建立函数的内容Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);


            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }

        public string Gen_WA_WUT_Js_DefButtonIsExistRecordCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "IsExistRecord";

            string strFunctionName_CN = string.Format("{0}、检查是否存在记录", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //建立函数的内容Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);


            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }


        /// <summary>
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public string Gen_WA_WUT_Js_DefButtonIsExist(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "IsExistRecord";

            string strFunctionName_CN = string.Format("{0}、检查是否存在关键字记录", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //建立函数的内容Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);


            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }
        public string Gen_WA_WUT_Js_DefButtonIsExistCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "IsExistRecord";

            string strFunctionName_CN = string.Format("{0}、检查是否存在关键字记录", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //建立函数的内容Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);


            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 定义用于编辑的层Div,该层可以被弹出
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
            strCodeForCs.AppendFormat("\r\n" + " <h4 class=\"modal-title\" id=\"lblDialogTitle_{0}\">模态框（Modal）标题</h4>", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + " <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-hidden=\"true\">&times;</button>");
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " <div class=\"modal-body\">");
            strCodeForCs.Append("\r\n" + " <table style=\"width: 100%;\">");

            foreach (clsPrjTabFldENEx objField in objPrjTabENEx.arrFldSet)
            {
                ///如果该字段不是标识递增型就生成控件,否则就不生成;
                if (objField.FieldTypeId == enumFieldType.KeyField_02
                  && objField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                strCodeForCs.AppendFormat("\r\n" + "<tr>");
                //strCodeForCs.AppendFormat("\r\n" + "<td>");
                ///插入验证控件代码;
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
            strCodeForCs.Append("\r\n" + " <button type=\"button\" class=\"btn btn-default\" data-dismiss=\"modal\">关闭</button>");
            strCodeForCs.AppendFormat("\r\n" + " <button type=\"button\" class=\"btn btn-primary\" onclick=\"btn{0}_Edit_Click('Submit')\">提交更改</button>", objViewInfoENEx.TabName_In);
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

            string strFunctionName_CN = string.Format("{0}、根据条件获取记录数", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //建立函数的内容Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);


            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }

        public string Gen_WA_WUT_Js_DefButtonGetRecCountByCondCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "GetRecCountByCond";

            string strFunctionName_CN = string.Format("{0}、根据条件获取记录数", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //建立函数的内容Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);


            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }

        public string Gen_WA_WUT_Js_DefButtonGetObjLst(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "GetObjLst";

            string strFunctionName_CN = string.Format("{0}、获取记录对象列表", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //建立函数的内容Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }
        public string Gen_WA_WUT_Js_DefButtonGetObjLstByKeyLst(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "GetObjLst";

            string strFunctionName_CN = string.Format("{0}、根据关键字列表获取对象列表", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //建立函数的内容Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }

        public string Gen_WA_WUT_Js_DefButtonGetObjLstByKeyLst_WACache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "GetObjLst";

            string strFunctionName_CN = string.Format("{0}、根据关键字列表获取对象列表, 使用WebApi缓存", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //建立函数的内容Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }
        public string Gen_WA_WUT_Js_DefButtonGetObjLstByKeyLstCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "GetObjLst";

            string strFunctionName_CN = string.Format("{0}、根据关键字列表获取对象列表, 使用WebApi缓存", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //建立函数的内容Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }


        public string Gen_WA_WUT_Js_DefButtonGetTopObjLst(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "GetTopObjLst";

            string strFunctionName_CN = string.Format("{0}、获取顶部记录对象列表", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //建立函数的内容Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }

        public string Gen_WA_WUT_Js_DefButtonGetObjLstByPager(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "GetObjLstByPager";

            string strFunctionName_CN = string.Format("{0}、获取分页记录对象列表", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //建立函数的内容Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);


            return strCodeForCs.ToString();
        }

        public string Gen_WA_WUT_Js_DefButtonGetObjLstByPager_WACache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "GetObjLstByPager";

            string strFunctionName_CN = string.Format("{0}、获取分页记录对象列表, 使用WebApi缓存", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //建立函数的内容Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);


            return strCodeForCs.ToString();
        }

        public string Gen_WA_WUT_Js_DefButtonGetObjLstByPagerCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "GetObjLstByPager";

            string strFunctionName_CN = string.Format("{0}、获取分页记录对象列表, 使用WebApi缓存", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //建立函数的内容Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);


            return strCodeForCs.ToString();
        }

        public string Gen_WA_WUT_Js_DefButtonGetSubObjLstCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "GetObjLstByPager";

            string strFunctionName_CN = string.Format("{0}、获取分页记录对象列表, 使用WebApi缓存", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //建立函数的内容Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);


            return strCodeForCs.ToString();
        }

        public string Gen_WA_WUT_Js_DefButtonGetSubObjLst_WACache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "GetObjLstByPager";

            string strFunctionName_CN = string.Format("{0}、获取分页记录对象列表, 使用WebApi缓存", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //建立函数的内容Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);


            return strCodeForCs.ToString();
        }

        public string Gen_WA_WUT_Js_DefButtonGetObjLstByRange(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "GetObjLstByRange";

            string strFunctionName_CN = string.Format("{0}、获取范围内记录对象列表", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //建立函数的内容Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);


            return strCodeForCs.ToString();
        }
     

        public string Gen_WA_WUT_Js_DefButtonGetObjByKey(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "GetObjByKey";

            string strFunctionName_CN = string.Format("{0}、根据关键字获取对象", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //建立函数的内容Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);


            return strCodeForCs.ToString();
        }

        public string Gen_WA_WUT_Js_DefButtonGetObjByKeyCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "GetObjByKey";

            string strFunctionName_CN = string.Format("{0}、根据关键字获取对象, 使用WebApi缓存", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //建立函数的内容Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);


            return strCodeForCs.ToString();
        }

        public string Gen_WA_WUT_Js_DefButtonGetObjByKey_WACache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "GetObjByKey";

            string strFunctionName_CN = string.Format("{0}、根据关键字获取对象, 使用WebApi缓存", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //建立函数的内容Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);


            return strCodeForCs.ToString();
        }

        public string Gen_WA_WUT_Js_DefButtonGetFirstObj(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            //string strFunctionName = "GetFirstObj";

            string strFunctionName_CN = string.Format("{0}、获取满足条件的第一条记录对象", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = GetFunctionGroupDiv_JS(objvFunction4GeneCodeEN);

            //建立函数的内容Div
            ASPDivEx objASPNETDivENEx_Content = GetDiv4FuncContent_JS(objvFunction4GeneCodeEN);
            objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_Content);

            objASPNETDivENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

            return strCodeForCs.ToString();
        }

        public ASPLabelEx GetOrderNumLabel_JS(int intOrderNum)
        {


            ASPLabelEx objASPNETLabelENEx = new ASPLabelEx();
            objASPNETLabelENEx.CtrlId = string.Format("lblOrderNum{0}", intOrderNum);
            objASPNETLabelENEx.Text = string.Format("第{0}个函数：", intOrderNum);
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
            objASPNETLabelENEx.Text = "显示结果";
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

            //添加显示结果的控件
            //ASPDivEx objASPNETDivENEx_ShowResult = GetFunctionResultDiv(objvFunction4GeneCodeEN);
            //objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_ShowResult);

            //添加水平线
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

            //添加显示结果的控件
            //ASPDivEx objASPNETDivENEx_ShowResult = GetFunctionResultDiv(objvFunction4GeneCodeEN);
            //objASPNETDivENEx.arrSubAspControlLst2.Add(objASPNETDivENEx_ShowResult);

            //添加水平线
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
                        strMsg = string.Format("函数参数的数据类型：[{0}({1})]没有处理,不能生成相应代码。", objDataTypeAbbrEN.DataTypeId,
                            objFuncPara4CodeEN.ParameterType);
                        throw new Exception(strMsg);
                    }
                }
                if (objFuncPara4CodeEN.IsByRef == true)
                {
                    strMsg = string.Format("Java函数参数的不接受引用型参数。参数名：[{0}],数据类型：[{1}]没有处理,不能生成相应代码。",
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


            //string strFunctionName_CN = string.Format("{0}、检查是否存在记录", objvFunction4GeneCodeEN.OrderNum);

            ASPDivEx objASPNETDivENEx = new ASPDivEx();
            objASPNETDivENEx.CtrlId = string.Format("div{0}", strFunctionName);
            objASPNETDivENEx.Style = string.Format("width: 100%; float: left; margin-bottom:5px;");
            objASPNETDivENEx.Class = "function";
            
            //添加水平线
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

            string strFunctionName_CN = string.Format("{0}、{1}", objvFunction4GeneCodeEN.OrderNum, objFunction4CodeEN.FuncCHName4Code);

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
            objASPNETLabelENEx2.Text = "结果";
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
        /// 建立函数的标题Div
        /// </summary>
        /// <param name="objvFunction4GeneCodeEN"></param>
        /// <returns></returns>
        public ASPDivEx GetDiv4FuncTitle_JS(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4CodeEN objFunction4CodeEN = clsFunction4CodeBL.GetObjByFuncId4CodeCache(objvFunction4GeneCodeEN.FuncId4Code);// "UpdateRecord";
            string strFunctionName = TransKeyWords4FuncName( objFunction4CodeEN.FuncName4Code);
            //string strFunctionName = "DelRecord";
            string strFunctionName_CN = string.Format("{0}、{1}({2})", 
                objvFunction4GeneCodeEN.OrderNum, objFunction4CodeEN.FuncCHName4Code, objFunction4CodeEN.FuncName4Code);

            //< div class="title" style="width:100%">
            //      <div style = "float:left; width:80%; " >
            //                 < asp:Label ID = "lblIsExistRecord4Title" Width="600px" Height="24px" Text="结果" runat="server" />

            //      </div>
            //      <div style = "float:right; width:20%; " >
            //          < input id="btnIsExistRecord4Expand" type="button" value="展开" onclick="ExpandDiv('divGen_WA_WUT_Js_DefButtonIsExistRecord')" />
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
                objASPNETLabelENEx.Text = string.Format("测试：{0}", strFunctionName_CN);
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
                objASPNETHtmlButtonENEx.Value = string.Format("展开");
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
        /// 建立函数的内容Div
        /// </summary>
        /// <param name="objvFunction4GeneCodeEN"></param>
        /// <returns></returns>
        public ASPDivEx GetDiv4FuncContent_JS(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsFunction4CodeEN objFunction4CodeEN = clsFunction4CodeBL.GetObjByFuncId4CodeCache(objvFunction4GeneCodeEN.FuncId4Code);// "UpdateRecord";
            string strFunctionName = TransKeyWords4FuncName( objFunction4CodeEN.FuncName4Code);

            string strFunctionName_CN = string.Format("{0}、{1}", objvFunction4GeneCodeEN.OrderNum, objFunction4CodeEN.FuncCHName4Code);

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
            //添加显示结果的控件
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
  //                      strMsg = string.Format("函数参数的数据类型：[{0}({1})]没有处理,不能生成相应代码。", objDataTypeAbbrEN.DataTypeId,
  //                          objFuncPara4CodeEN.ParameterType);
  //                      throw new Exception(strMsg);
  //                  }
  //              }
  //              if (objFuncPara4CodeEN.IsByRef == true)
  //              {
  //                  strMsg = string.Format("Java函数参数的不接受引用型参数。参数名：[{0}],数据类型：[{1}]没有处理,不能生成相应代码。",
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
