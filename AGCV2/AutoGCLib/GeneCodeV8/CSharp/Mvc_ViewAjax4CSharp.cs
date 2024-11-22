using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AGC.PureClass;
using AGC.PureClassEx;
using AgcCommBase;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commexception;
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web.UI.WebControls;
using TzCommWebServerCtrlLib;

namespace AutoGCLib
{
    /// <summary>
    /// �Զ����ɽ�����Ʋ�Ĵ�����(View of Mvc)
    /// </summary>
    public class Mvc_ViewAjax4CSharp : clsGeneCodeBase
    {
        clsBiDimDistribute objBiDimDistribue4Qry = null;

        //		private objViewInfoENEx.FileName;		//���ɵ��ļ�����
        #region ���캯��
        public Mvc_ViewAjax4CSharp()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            InitPageSetup();
        }
        public Mvc_ViewAjax4CSharp(string strViewId)
       : base("", strViewId, "", "")
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
        }
        public Mvc_ViewAjax4CSharp(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
        : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
        }
        #endregion
        /// <summary>
        /// ��ʼ��ҳ������
        /// </summary>
        public void InitPageSetup()
        {
            intZIndex = 100;        ///�ؼ��������
            intCurrLeft = 10;  ///�ؼ�����߿�;
            intCurrTop = 10;
        }



        /// <summary>
        /// ���ɲ�ѯ������ش���
        /// </summary>
        /// <returns></returns>
        public string Gen_MvcView_QryRegionCode4TableBak()
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //�����������ĵı�ǩ����
            clsLabelStyleEN objLabelStyle_Text = clsLabelStyleBL.GetObjByLabelStyleIdCache("0001");
            clsGenCtlStyleEN objGenCtlStyle = clsGenCtlStyleBL.GetObjByGenCtlStyleIdCache("0001");
            clsCheckStyleEN objCheckStyle = clsCheckStyleBL.GetObjByCheckStyleIdCache("0001");
            clsButtonStyleEN objButtonStyle = clsButtonStyleBL.GetObjByButtonStyleIdCache("0001");
            float intDivHeight;
            int intQueryFldNum = 0;

           
            objBiDimDistribue4Qry = new clsBiDimDistribute();

            objBiDimDistribue4Qry.ColNum = objViewInfoENEx.objViewRegion_Query.ColNum ?? 0;
            objBiDimDistribue4Qry.ColWidth = 250;
            objBiDimDistribue4Qry.LineHeight = 30;
            float intDivWidth = objBiDimDistribue4Qry.GetCtlWidth();

            intQueryFldNum = objViewInfoENEx.arrQryRegionFldSet.Count;

            //			intDivHeight = intQueryFldNum * 28 +40;
            intDivHeight = objBiDimDistribue4Qry.GetCtlHeigh(intQueryFldNum) + 40;

            
            strCodeForCs.Append("\r\n" + "<table style = \"width: 90%\"> ");

            intCurrTop -= 30;//��Ϊ�����ڲ�(div)��
            int intFieldNum = 0;
            objBiDimDistribue4Qry.StartX = (int)intCurrLeft;
            objBiDimDistribue4Qry.StartY = (int)intCurrTop;
            ///����ר�����ڲ�ѯ�Ľ���ؼ��Ĵ���;
            ///
            bool bolIsTrEnd = true;
            foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
            {
                if (intFieldNum % objViewInfoENEx.objViewRegion_Query.ColNum == 0)
                {
                    strCodeForCs.Append("\r\n" + "<tr>");
                    bolIsTrEnd = false;
                }

                switch (objQryRegionFldsEx.objCtlType.CtlTypeName)
                {
                    case "CheckBox":
                        strCodeForCs.Append("\r\n" + GenCheckBoxNoPosition(objCheckStyle, objQryRegionFldsEx.CtrlId(), objQryRegionFldsEx.LabelCaption));
                        break;
                    default:
                        string strTemp = Gen_Mvc_CombineCtlWithFor(objLabelStyle_Text,
                            objQryRegionFldsEx.FldName,
                          "lbl" + objQryRegionFldsEx.FldName + "_q",
                          objQryRegionFldsEx.LabelCaption,
                          objGenCtlStyle,
                          objQryRegionFldsEx.objCtlType.CtlTypeName,
                          objQryRegionFldsEx.CtrlId(), objQryRegionFldsEx.DsTabId, objQryRegionFldsEx.DdlItemsOptionId);
                        strCodeForCs.Append("\r\n" + strTemp);
                        break;
                }

                intZIndex += 1;
                intCurrTop += 28;
                intFieldNum++;
                if (intFieldNum % objViewInfoENEx.objViewRegion_Query.ColNum == 0)
                {
                    strCodeForCs.Append("\r\n" + "</tr>");
                    bolIsTrEnd = true;
                }
                intCurrLeft = objBiDimDistribue4Qry.GetPosition(intFieldNum).X;
                intCurrTop = objBiDimDistribue4Qry.GetPosition(intFieldNum).Y;

            }
            ///���ɲ�ѯ��ť�Ĵ���;
            ///
            if (bolIsTrEnd == true)
            {
                strCodeForCs.Append("\r\n" + "<tr>");
                bolIsTrEnd = false;
            }
            strCodeForCs.Append("\r\n" + "<td>");

            //strCodeForCs.Append("\r\n" + Gen_Mvc_ButtonInForm(objButtonStyle, "btnQuery", "��ѯ"));
            //strCodeForCs.Append("\r\n" + GenButtonGroupInQuery());
            strCodeForCs.Append("\r\n" + "</td>");
            //strCodeForCs.Append("\r\n" + "<td>");
            //strCodeForCs.Append("\r\n" + "<a href = \"javascript:void(0);\" class=\"easyui-linkbutton\" data-options=\"iconCls:'icon-clear' \" onclick=\"resetSearch()\">���</a>");
            //strCodeForCs.Append("\r\n" + "</td>");

            strCodeForCs.Append("\r\n" + "</tr>");
            strCodeForCs.Append("\r\n" + "</table>");

            intCurrTop += 40;
            return strCodeForCs.ToString();
        }

        public string Gen_MvcView_QryRegionCode4Table()
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //�����������ĵı�ǩ����
            clsLabelStyleEN objLabelStyle_Text = clsLabelStyleBL.GetObjByLabelStyleIdCache("0001");
            clsGenCtlStyleEN objGenCtlStyle = clsGenCtlStyleBL.GetObjByGenCtlStyleIdCache("0001");
            clsCheckStyleEN objCheckStyle = clsCheckStyleBL.GetObjByCheckStyleIdCache("0001");
            clsButtonStyleEN objButtonStyle = clsButtonStyleBL.GetObjByButtonStyleIdCache("0001");
            float intDivHeight;
            int intQueryFldNum = 0;

           
            objBiDimDistribue4Qry = new clsBiDimDistribute();

            objBiDimDistribue4Qry.ColNum = objViewInfoENEx.objViewRegion_Query.ColNum ?? 0;
            objBiDimDistribue4Qry.ColWidth = 250;
            objBiDimDistribue4Qry.LineHeight = 30;
            float intDivWidth = objBiDimDistribue4Qry.GetCtlWidth();

            intQueryFldNum = objViewInfoENEx.arrQryRegionFldSet.Count;

            //			intDivHeight = intQueryFldNum * 28 +40;
            intDivHeight = objBiDimDistribue4Qry.GetCtlHeigh(intQueryFldNum) + 40;


         
            intCurrTop -= 30;//��Ϊ�����ڲ�(div)��
            //int intFieldNum = 0;
            objBiDimDistribue4Qry.StartX = (int)intCurrLeft;
            objBiDimDistribue4Qry.StartY = (int)intCurrTop;
            ///����ר�����ڲ�ѯ�Ľ���ؼ��Ĵ���;
            ///
            //bool bolIsTrEnd = true;
            IEnumerable<clsViewRegionENEx> arrViewRegion = objViewInfoENEx.arrViewRegion.Where(x => x.RegionTypeId == enumRegionType.QueryRegion_0001);
            if (arrViewRegion.Count() == 0)
            {
                string strMsg = string.Format("���湦����Ϊ��,����ӽ��湦��!����:{0}. (In {1})", objViewInfoENEx.ViewName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);

            }
            string lngRegionId = arrViewRegion.First().RegionId;

            IEnumerable<ASPControlGroupEx> arrControlGroups = clsQryRegionFldsBLEx.GetControlGroup(lngRegionId, objViewInfoENEx, "Item1");

            ASPHtmlTableEx objTable = clsASPHtmlTableBLEx.PackageByTable4QueryRegion(arrControlGroups, objViewInfoENEx.objViewRegion_Query.ColNum ?? 0);
            objTable.GeneCode4Mvc(strCodeForCs);
            
            intCurrTop += 40;
            return strCodeForCs.ToString();
        }


        public bool DispQryRegionCtrl()
        {

            return true;
        }
        public string ClsName4WucTabName4Gv()
        {
            string strClsName = string.Format("wuc{0}4Gv", objViewInfoENEx.TabName_Out);
            return strClsName;
        }
      

        /// <summary>
        /// ����:����Ĳ�ѯ���޸ġ����롢ɾ��
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
            this.objViewInfoENEx = objViewInfoENEx;
            //���û���������;
            if (objViewInfoENEx.arrEditRegionFldSet4InUse == null || objViewInfoENEx.arrEditRegionFldSet4InUse.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("��ǰ��ѡ��������:{0},�ڸý�����û�б༭����,���߱༭����û���ֶΡ�����!", strViewName);
                sbMessage.Append("\r\n��ǰ����Ĺ���:��ѯ(Q)���޸�(U)��ɾ��(D)�����(I)��");
                throw new clsDbObjException(sbMessage.ToString());
            }
          
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp ;     ///��ʱ����;
            clsPubFun4BLEx.CheckDgStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsPubFun4BLEx.CheckTitleStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.TitleStyleId);

            clsDataGridStyleEN objDGStyleEx = clsDataGridStyleBL.GetObjByDgStyleIdCache(objViewInfoENEx.objViewStyleEN.DgStyleId);

            objViewInfoENEx.WebFormName = string.Format("{0}CRUDAjax", objViewInfoENEx.TabName);
            objViewInfoENEx.WebFormFName = string.Format("{0}{1}.cshtml",
                objViewInfoENEx.FolderName, objViewInfoENEx.WebFormName);
            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;
            objViewInfoENEx.ClsName = objViewInfoENEx.WebFormName;

            strRe_ClsName = objViewInfoENEx.WebFormName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            
            clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(objViewInfoENEx.CodeTypeId);
            if (objCodeType.IsDirByTabName == false)
            {
                strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebFormFName);
            }
            else
            {
                strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objViewInfoENEx.TabName, objViewInfoENEx.WebFormFName);
            }
            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                       clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objViewInfoENEx.FunctionTemplateId,
                       objViewInfoENEx.LangType, objViewInfoENEx.CodeTypeId, objViewInfoENEx.SqlDsTypeId);



            strCodeForCs.AppendFormat("\r\n" + "@using {0}.Entity", objProjectsENEx.PrjDomain);
            strCodeForCs.AppendFormat("\r\n" + "@using {0}Mvc.HtmlHelpers", objProjectsENEx.PrjDomain);
            strCodeForCs.AppendFormat("\r\n" + "@model Tuple<{0}Mvc.Models.QryModel4{2}, {0}Mvc.Models.FeatureModel4{1}>", 
                objProjectsENEx.PrjDomain, objMainPrjTab.TabName, objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "@{");
            strCodeForCs.Append("\r\n" + "    Layout = \"~/Views/Shared/TZ_Layout.cshtml\";");
            strCodeForCs.AppendFormat("\r\n" + "    ViewBag.Title = \"{0}\";", objViewInfoENEx.ViewCnName);
            strCodeForCs.Append("\r\n" + "    string controller = ViewContext.RouteData.Route.GetRouteData(this.Context).Values[\"controller\"].ToString();");
            strCodeForCs.Append("\r\n" + "    string action = ViewContext.RouteData.Values[\"action\"].ToString();");
            strCodeForCs.Append("\r\n" + "    string btnSaveName = \"\";");
            strCodeForCs.Append("\r\n" + "    if (ViewBag.Operate == \"Add\" )");
            strCodeForCs.Append("\r\n" + "    {");
            strCodeForCs.Append("\r\n" + "        btnSaveName = \"ȷ�����\";");
            strCodeForCs.Append("\r\n" + "    }");
            strCodeForCs.Append("\r\n" + "    else if (ViewBag.Operate == \"Update\" )");
            strCodeForCs.Append("\r\n" + "    {");
            strCodeForCs.Append("\r\n" + "        btnSaveName = \"ȷ���޸�\";");
            strCodeForCs.Append("\r\n" + "    }");
            strCodeForCs.Append("\r\n" + "AjaxOptions ajaxOpts = new AjaxOptions");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "UpdateTargetId = \"divLstTab_{0}\"",
                objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "<h3>{0}</h3>", objViewInfoENEx.ViewCnName);
            strCodeForCs.Append("\r\n" + "<h4>@ViewBag.Message</h4>");

            strCodeForCs.Append("\r\n" + "<style>");
            strCodeForCs.Append("\r\n" + "#divFunction{");
            strCodeForCs.Append("\r\n" + "margin-left:10%;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "</style>");

            strCodeForCs.Append("\r\n" + "<div>");

            try
            {
                clsTzGCScript objTzGCScript = new clsTzGCScript(objViewInfoENEx);
                string strTemp = "";
                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
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
                        if (objvFunction4GeneCodeEN.FuncTypeId == "10")//�û��Զ��庯��
                        {
                            strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId4View(objvFunction4GeneCodeEN.FuncId4GC,
                                 objViewInfoENEx.ViewId, objViewInfoENEx.PrjDataBaseId, objViewInfoENEx.PrjId);
                        }
                        else
                        {
                            strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                        }
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("�����ɺ���:[{0}]ʱ����������Ϣ:{1}.", strFuncName, objException.Message);
                        throw new Exception(strMsg);
                    }
                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }

                }
                strCodeForCs.Append("\r\n" + "</div>");

                strCodeForCs.Append("\r\n" + Gen_MvcView_JsFunc4CRUD());
       
                strCodeForCs.Append("\r\n" + Gen_MvcView_JsFunc4CRUD_Backup());

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
        /// ����:����Js����,���ڽ����CRUD
        /// </summary>
        /// <returns></returns>
        public string Gen_MvcView_JsFunc4CRUD()
        {
            using (JsFunction objJsFunc = new JsFunction())
            {
                objJsFunc.funcName = "CheckAllHandler";
                objJsFunc.sbText.Append("\r\n" + "    function CheckAllHandler() {");
                objJsFunc.sbText.Append("\r\n" + "        //alert('CheckAllHandler');");
                objJsFunc.sbText.Append("\r\n" + "        var myCheckBox = event.target;");
                objJsFunc.sbText.Append("\r\n" + "        if (myCheckBox.checked === true) {");
                objJsFunc.sbText.AppendFormat("\r\n" + "            SetAllChecked('tab{0}Lst');", objViewInfoENEx.TabName_Out);
                objJsFunc.sbText.Append("\r\n" + "        }");
                objJsFunc.sbText.Append("\r\n" + "        else {");
                objJsFunc.sbText.AppendFormat("\r\n" + "            SetAllNoChecked('tab{0}Lst');", objViewInfoENEx.TabName_Out);
                objJsFunc.sbText.Append("\r\n" + "        }");
                objJsFunc.sbText.Append("\r\n" + "    }");

                arrJsFunction.Add(objJsFunc);
            }

            using (JsFunction objJsFunc = new JsFunction())
            {
                objJsFunc.funcName = "ShowEditDialog";
                objJsFunc.sbText.Append("\r\n" + "    function ShowEditDialog() {");
                objJsFunc.sbText.Append("\r\n" + "        //alert('complete');");
                objJsFunc.sbText.AppendFormat("\r\n" + "        $('#divEdit_{0}').modal('show');",
                    objViewInfoENEx.TabName_Out);
                objJsFunc.sbText.Append("\r\n" + "    }");
                arrJsFunction.Add(objJsFunc);
            }
            using (JsFunction objJsFunc = new JsFunction())
            {
                objJsFunc.funcName = "revertUTF8";
                objJsFunc.sbText.Append("\r\n" + "    function revertUTF8(szInput)");
                objJsFunc.sbText.Append("\r\n" + "    {");
                objJsFunc.sbText.Append("\r\n" + "    var x, wch, wch1, wch2, uch = \"\", szRet = \"\";");
                objJsFunc.sbText.Append("\r\n" + "    for (x = 0; x < szInput.length; x++)");
                objJsFunc.sbText.Append("\r\n" + "    {");
                objJsFunc.sbText.Append("\r\n" + "    if (szInput.charAt(x) == \"%\")");
                objJsFunc.sbText.Append("\r\n" + "    {");
                objJsFunc.sbText.Append("\r\n" + "    wch = parseInt(szInput.charAt(++x) + szInput.charAt(++x), 16);");
                objJsFunc.sbText.Append("\r\n" + "    if (!wch) { break; }");
                objJsFunc.sbText.Append("\r\n" + "    if (!(wch & 0x80))");
                objJsFunc.sbText.Append("\r\n" + "    {");
                objJsFunc.sbText.Append("\r\n" + "    wch = wch;");
                objJsFunc.sbText.Append("\r\n" + "    }");
                objJsFunc.sbText.Append("\r\n" + "    else if (!(wch & 0x20))");
                objJsFunc.sbText.Append("\r\n" + "    {");
                objJsFunc.sbText.Append("\r\n" + "    x++;");
                objJsFunc.sbText.Append("\r\n" + "    wch1 = parseInt(szInput.charAt(++x) + szInput.charAt(++x), 16);");
                objJsFunc.sbText.Append("\r\n" + "    wch = (wch & 0x1F) << 6;");
                objJsFunc.sbText.Append("\r\n" + "    wch1 = wch1 & 0x3F;");
                objJsFunc.sbText.Append("\r\n" + "    wch = wch + wch1;");
                objJsFunc.sbText.Append("\r\n" + "    }");
                objJsFunc.sbText.Append("\r\n" + "    else");
                objJsFunc.sbText.Append("\r\n" + "    {");
                objJsFunc.sbText.Append("\r\n" + "    x++;");
                objJsFunc.sbText.Append("\r\n" + "    wch1 = parseInt(szInput.charAt(++x) + szInput.charAt(++x), 16);");
                objJsFunc.sbText.Append("\r\n" + "    x++;");
                objJsFunc.sbText.Append("\r\n" + "    wch2 = parseInt(szInput.charAt(++x) + szInput.charAt(++x), 16);");
                objJsFunc.sbText.Append("\r\n" + "    wch = (wch & 0x0F) << 12;");
                objJsFunc.sbText.Append("\r\n" + "    wch1 = (wch1 & 0x3F) << 6;");
                objJsFunc.sbText.Append("\r\n" + "    wch2 = (wch2 & 0x3F);");
                objJsFunc.sbText.Append("\r\n" + "    wch = wch + wch1 + wch2;");
                objJsFunc.sbText.Append("\r\n" + "    }");
                objJsFunc.sbText.Append("\r\n" + "    szRet += String.fromCharCode(wch);");
                objJsFunc.sbText.Append("\r\n" + "    }");
                objJsFunc.sbText.Append("\r\n" + "    else");
                objJsFunc.sbText.Append("\r\n" + "    {");
                objJsFunc.sbText.Append("\r\n" + "    szRet += szInput.charAt(x);");
                objJsFunc.sbText.Append("\r\n" + "    }");
                objJsFunc.sbText.Append("\r\n" + "    }");
                objJsFunc.sbText.Append("\r\n" + "    return (szRet);");
                objJsFunc.sbText.Append("\r\n" + "    }");
                
                arrJsFunction.Add(objJsFunc);
            }
            using (JsFunction objJsFunc = new JsFunction())
            {
                objJsFunc.funcName = "OnFailureInFeatureRegion";
                objJsFunc.sbText.Append("\r\n" + "    function OnFailureInFeatureRegion(ajaxContext)");
                objJsFunc.sbText.Append("\r\n" + "    {");
                objJsFunc.sbText.Append("\r\n" + "    //var response = ajaxContext.get_response();");
                objJsFunc.sbText.Append("\r\n" + "    var statusText = ajaxContext.statusText;");
                objJsFunc.sbText.Append("\r\n" + "    var statusText_decode = revertUTF8(statusText);");
                objJsFunc.sbText.Append("\r\n" + "    console.log('revertUTF8:' + statusText_decode);");

                objJsFunc.sbText.Append("\r\n" + "    //var statusCode = response.get_statusCode();");
                objJsFunc.sbText.Append("\r\n" + "    alert(statusText_decode);");


                objJsFunc.sbText.Append("\r\n" + "    $('#spnMsg_Lst').html(statusText_decode);");
                //alert(statusText);

                objJsFunc.sbText.Append("\r\n" + "    }");
          
                arrJsFunction.Add(objJsFunc);
            }

            using (JsFunction objJsFunc = new JsFunction())
            {
                objJsFunc.funcName = "HideEditDialog";
                objJsFunc.sbText.Append("\r\n" + "    function HideEditDialog() {");
                objJsFunc.sbText.Append("\r\n" + "        //alert('complete');");
                objJsFunc.sbText.AppendFormat("\r\n" + "        $('#divEdit_{0}').modal('hide');",
                    objViewInfoENEx.TabName_Out);
                objJsFunc.sbText.Append("\r\n" + "    }");
                arrJsFunction.Add(objJsFunc);
            }
            using (JsFunction objJsFunc = new JsFunction())
            {
                objJsFunc.funcName = "OnSuccessInFeatureRegion";

                objJsFunc.sbText.Append("\r\n" + "    function OnSuccessInFeatureRegion(response, xhr){");
                objJsFunc.sbText.Append("\r\n" + "          switch (_clickedId) {");
                objJsFunc.sbText.Append("\r\n" + "              case \"btnCreate\":");
                objJsFunc.sbText.Append("\r\n" + "              case \"btnUpdate\":");
                objJsFunc.sbText.Append("\r\n" + "                  $('#divEdit').html(response);");
                objJsFunc.sbText.Append("\r\n" + "                  break;");
                objJsFunc.sbText.Append("\r\n" + "              case  \"btnExportExcel\":");
                objJsFunc.sbText.Append("\r\n" + "                  $('#spnExportExcel').html(response);");
                objJsFunc.sbText.Append("\r\n" + "                  break;");
                objJsFunc.sbText.Append("\r\n" + "              default:");
          objJsFunc.sbText.AppendFormat("\r\n" + "                  $('#divLstTab_{0}').html(response);", objViewInfoENEx.TabName_Out);
                objJsFunc.sbText.Append("\r\n" + "                  break;");
                objJsFunc.sbText.Append("\r\n" + "          }");
          //      objJsFunc.sbText.Append("\r\n" + "          strMsg = '@TempData[\"message\"]';");
                objJsFunc.sbText.Append("\r\n" + "          ShowFeatureRegionMsg(strMsg);");

                objJsFunc.sbText.Append("\r\n" + "    }");
                arrJsFunction.Add(objJsFunc);
            }

            using (JsFunction objJsFunc = new JsFunction())
            {
                objJsFunc.funcName = "OnSuccessInQueryRegion";

                objJsFunc.sbText.Append("\r\n" + "//��ѯ����ť��������,���ع���ҳ������,�ٸ��ݲ�ͬ����,���²�ͬ������");
                objJsFunc.sbText.Append("\r\n" + "    function OnSuccessInQueryRegion(response, xhr){");
                objJsFunc.sbText.Append("\r\n" + "        switch (_clickedId){");
                objJsFunc.sbText.Append("\r\n" + "              case \"btnQuery\":");
          objJsFunc.sbText.AppendFormat("\r\n" + "                  $('#divLstTab_{0}').html(response);", objViewInfoENEx.TabName_Out);
                objJsFunc.sbText.Append("\r\n" + "                  break;");                
                objJsFunc.sbText.Append("\r\n" + "              case \"btnExportExcel\":");
                objJsFunc.sbText.Append("\r\n" + "                  $('#spnExportExcel').html(response);");
                objJsFunc.sbText.Append("\r\n" + "                  break;");
                objJsFunc.sbText.Append("\r\n" + "              default:");
          objJsFunc.sbText.AppendFormat("\r\n" + "                  $('#divLstTab_{0}').html(response);", objViewInfoENEx.TabName_Out);
                objJsFunc.sbText.Append("\r\n" + "                  break;");
                objJsFunc.sbText.Append("\r\n" + "        }");

                //objJsFunc.sbText.Append("\r\n" + "if (response.indexOf('UpdateTargetId:Edit') > 0)");
                //objJsFunc.sbText.Append("\r\n" + "{");
                //objJsFunc.sbText.Append("\r\n" + "$('#divEdit').html(response);");
                //objJsFunc.sbText.Append("\r\n" + "}");
                //objJsFunc.sbText.Append("\r\n" + "else");
                //objJsFunc.sbText.Append("\r\n" + "{");
                //objJsFunc.sbText.AppendFormat("\r\n" + "$('#divLstTab_{0}').html(response);", objViewInfoENEx.TabName_Out);
                //objJsFunc.sbText.Append("\r\n" + "}");
                //alert("�Ѿ��滻��divEdit");
                objJsFunc.sbText.Append("\r\n" + "    }");

                arrJsFunction.Add(objJsFunc);
            }

            using (JsFunction objJsFunc = new JsFunction())
            {
                objJsFunc.funcName = "OnClickInFeatureRegion";

                objJsFunc.sbText.Append("\r\n" + "  //��������ť������ʱ,��¼������ť��Id");
                objJsFunc.sbText.Append("\r\n" + "    function OnClickInFeatureRegion(){");
                objJsFunc.sbText.Append("\r\n" + "        _clickedId = event.target.id;");
                objJsFunc.sbText.Append("\r\n" + "        console.log(_clickedId);");
                objJsFunc.sbText.Append("\r\n" + "    }");
                arrJsFunction.Add(objJsFunc);
            }

            using (JsFunction objJsFunc = new JsFunction())
            {
                objJsFunc.funcName = "ShowErrMsg";
                objJsFunc.sbText.Append("\r\n" + "  //������ʾ����ĺ���,ͬʱ���½����ϵ���ʾ����Ŀؼ���Ϣ");
                objJsFunc.sbText.Append("\r\n" + "    function ShowErrMsg(strMsg){");
                objJsFunc.sbText.Append("\r\n" + "        alert(strMsg);");
                objJsFunc.sbText.Append("\r\n" + "        if (strMsg.indexOf('SaveAjax') > 0){");
                objJsFunc.sbText.Append("\r\n" + "            $('#spnEditErr').html(strMsg);");
                objJsFunc.sbText.Append("\r\n" + "        }");
                objJsFunc.sbText.Append("\r\n" + "    }");
                arrJsFunction.Add(objJsFunc);
            }
            using (JsFunction objJsFunc = new JsFunction())
            {
                objJsFunc.funcName = "ShowFeatureRegionMsg";
                objJsFunc.sbText.Append("\r\n" + "  //������ʾ����ĺ���,ͬʱ���½����ϵ���ʾ����Ŀؼ���Ϣ");
                objJsFunc.sbText.Append("\r\n" + "    function ShowFeatureRegionMsg(pstrMsg){");
         
                objJsFunc.sbText.Append("\r\n" + "          switch (_clickedId) {");
                objJsFunc.sbText.Append("\r\n" + "              case \"btnCreate\":");
                objJsFunc.sbText.Append("\r\n" + "              case \"btnUpdate\":");
                objJsFunc.sbText.Append("\r\n" + "                  break;");
                objJsFunc.sbText.Append("\r\n" + "              case  \"btnDeletes\":");
        
                objJsFunc.sbText.Append("\r\n" + "                  $('#spnMsg_Lst').html(pstrMsg);");
                objJsFunc.sbText.Append("\r\n" + "                  alert(pstrMsg);");
                objJsFunc.sbText.Append("\r\n" + "                  break;");
                objJsFunc.sbText.Append("\r\n" + "              default:");
                objJsFunc.sbText.Append("\r\n" + "                  $('#spnMsg_Lst').html(pstrMsg);");
                objJsFunc.sbText.Append("\r\n" + "                  break;");
                objJsFunc.sbText.Append("\r\n" + "          }");

                objJsFunc.sbText.Append("\r\n" + "    }");
                arrJsFunction.Add(objJsFunc);
            }
            arrJsFunction.Sort((x, y) => { return x.funcName.CompareTo(y.funcName); });
          
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
        
            strCodeForCs.Append("\r\n" + "<script type=\"text/javascript\">");
            strCodeForCs.Append("\r\n" + "//Js����,���ڽ����CRUD");
            strCodeForCs.Append("\r\n" + "    var strOperate = \"@ViewBag.Operate\";");
            strCodeForCs.Append("\r\n" + "    var strMsg = '@TempData[\"message\"]';");
            strCodeForCs.Append("\r\n" + "    var IsHideQryRegion = \"@ViewBag.IsHideQryRegion\";");
            strCodeForCs.Append("\r\n" + "    //��������ť��������,���ع���ҳ������,�ٸ��ݲ�ͬ����,���²�ͬ������");
            strCodeForCs.Append("\r\n" + "    var _clickedId = \"\";");
            strCodeForCs.Append("\r\n" + "    $(function () {");
            strCodeForCs.Append("\r\n" + "        //    searchExamType();");
            strCodeForCs.Append("\r\n" + "    });");
            foreach (JsFunction objJsFunction in arrJsFunction)
            {
                strCodeForCs.Append("\r\n" + objJsFunction.funcText);
            }





            strCodeForCs.Append("\r\n" + "    if (strOperate == \"Add\") {");
            strCodeForCs.Append("\r\n" + "        ShowEditDialog();");
            strCodeForCs.Append("\r\n" + "    }");
            strCodeForCs.Append("\r\n" + "    else if (strOperate == \"Update\") {");
            strCodeForCs.Append("\r\n" + "        ShowEditDialog();");
            strCodeForCs.Append("\r\n" + "    }");
            strCodeForCs.Append("\r\n" + "    else {");
            strCodeForCs.Append("\r\n" + "        HideEditDialog();");
            strCodeForCs.Append("\r\n" + "    }");
            strCodeForCs.Append("\r\n" + "    var EditError = \"@ViewBag.EditError\";");
            strCodeForCs.Append("\r\n" + "    if (EditError == \"true\") {");
            strCodeForCs.Append("\r\n" + "        ShowEditDialog();");
            strCodeForCs.Append("\r\n" + "    }");

            strCodeForCs.Append("\r\n" + "    if (IsHideQryRegion == \"True\"){");
            strCodeForCs.Append("\r\n" + "        $('#divQryRegion').hide();");
            strCodeForCs.Append("\r\n" + "    }");


            strCodeForCs.Append("\r\n" + "</script>");
            return strCodeForCs.ToString();
        }
        /// <summary>
        /// ����:����Js����,���ڽ����CRUD, ��֮��
        /// </summary>
        /// <returns></returns>
        public string Gen_MvcView_JsFunc4CRUD_Backup()
        {
                    List<JsFunction> arrJsFunc = new List<JsFunction>();
            using (JsFunction objJsFunc = new JsFunction())
            {
                objJsFunc.funcName = "resetSearch";
                objJsFunc.sbText.Append("\r\n" + "    //ɾ��������¼");
                objJsFunc.sbText.AppendFormat("\r\n" + "    function Delete{0}s() {{",
                    objMainPrjTab.TabName);
                objJsFunc.sbText.Append("\r\n" + "        if ($(\".checkboxes:checked\").length == 0) {");
                objJsFunc.sbText.Append("\r\n" + "            alert(\"��ѡ��ɾ����������!\");");
                objJsFunc.sbText.Append("\r\n" + "            return;");
                objJsFunc.sbText.Append("\r\n" + "        }");
                objJsFunc.sbText.Append("\r\n" + "        var objects = new Array();");
                objJsFunc.sbText.Append("\r\n" + "        var obj = null;");
                objJsFunc.sbText.Append("\r\n" + "        $('.table').each(function () {");
                objJsFunc.sbText.Append("\r\n" + "            var objtr = $(this);");
                objJsFunc.sbText.Append("\r\n" + "            if (objtr.find(\".checkboxes\").prop('checked')) {");
                objJsFunc.sbText.Append("\r\n" + "                obj = new Object();");
                objJsFunc.sbText.Append("\r\n" + "                obj.Module_nbr = objtr.find(\".checkboxes\").val();");
                objJsFunc.sbText.Append("\r\n" + "                objects.push(obj);");
                objJsFunc.sbText.Append("\r\n" + "            }");
                objJsFunc.sbText.Append("\r\n" + "        })");
                objJsFunc.sbText.Append("\r\n" + "        var data = JSON.stringify(objects);");
                objJsFunc.sbText.Append("\r\n" + "        alert(data);");
                objJsFunc.sbText.Append("\r\n" + "    }");

                arrJsFunc.Add(objJsFunc);
            }
            using (JsFunction objJsFunc = new JsFunction())
            {
                objJsFunc.funcName = "resetSearch";
                objJsFunc.sbText.Append("\r\n" + "    //��ѯ���");
                objJsFunc.sbText.Append("\r\n" + "    function resetSearch() {");
                objJsFunc.sbText.Append("\r\n" + "        $('#search_Form').form('clear');");
                objJsFunc.sbText.Append("\r\n" + "    }");
                arrJsFunc.Add(objJsFunc);
            }
            using (JsFunction objJsFunc = new JsFunction())
            {
                objJsFunc.funcName = "delExamType";
                objJsFunc.sbText.Append("\r\n" + "    function delExamType(strExamTypeId) {");
                objJsFunc.sbText.Append("\r\n" + "        $.messager.confirm('ȷ��', '�Ƿ����ɾ��?', function (r) {");
                objJsFunc.sbText.Append("\r\n" + "            if (r) {");
                objJsFunc.sbText.Append("\r\n" + "                $.ajax({");
                objJsFunc.sbText.Append("\r\n" + "                    url: \"DelRecord\",");
                objJsFunc.sbText.Append("\r\n" + "                    cache: false,");
                objJsFunc.sbText.Append("\r\n" + "                    async: false,");
                objJsFunc.sbText.Append("\r\n" + "                    type: 'post',");
                objJsFunc.sbText.Append("\r\n" + "                    dataType: \"json\",");
                objJsFunc.sbText.Append("\r\n" + "                    data: { ExamTypeId: strExamTypeId },");
                objJsFunc.sbText.Append("\r\n" + "                    success: function (text) {");
                objJsFunc.sbText.Append("\r\n" + "                        if (text == '1') {");
                objJsFunc.sbText.Append("\r\n" + "                            $('#tbl').datagrid('reload');");
                objJsFunc.sbText.Append("\r\n" + "                            $.messager.alert(\"������ʾ\", \"ɾ���ɹ�\");");
                objJsFunc.sbText.Append("\r\n" + "                        }");
                objJsFunc.sbText.Append("\r\n" + "                        else {");
                objJsFunc.sbText.Append("\r\n" + "                            $.messager.alert(\"ɾ��ʧ��\");");
                objJsFunc.sbText.Append("\r\n" + "                        }");
                objJsFunc.sbText.Append("\r\n" + "                    }");
                objJsFunc.sbText.Append("\r\n" + "                });");
                objJsFunc.sbText.Append("\r\n" + "            }");
                objJsFunc.sbText.Append("\r\n" + "        });");
                objJsFunc.sbText.Append("\r\n" + "    }");
                arrJsFunc.Add(objJsFunc);
            }
            using (JsFunction objJsFunc = new JsFunction())
            {
                objJsFunc.funcName = "save()";
                objJsFunc.sbText.Append("\r\n" + "    //��ӷ���");
                objJsFunc.sbText.Append("\r\n" + "    function save() {");
                objJsFunc.sbText.Append("\r\n" + "        $('#add_Form').form('submit', {");
                objJsFunc.sbText.Append("\r\n" + "            url: 'SaveExamType',");
                objJsFunc.sbText.Append("\r\n" + "            onSubmit: function () {");
                objJsFunc.sbText.Append("\r\n" + "                var valid = $('#add_Form').form('validate');");
                objJsFunc.sbText.Append("\r\n" + "                if (valid == false) {");
                objJsFunc.sbText.Append("\r\n" + "                    return false;");
                objJsFunc.sbText.Append("\r\n" + "                }");
                objJsFunc.sbText.Append("\r\n" + "                return true;");
                objJsFunc.sbText.Append("\r\n" + "            },");
                objJsFunc.sbText.Append("\r\n" + "            success: function (data) {");
                objJsFunc.sbText.Append("\r\n" + "                data = eval('(' + data + ')');");
                objJsFunc.sbText.Append("\r\n" + "                if (data.Success) {");
                objJsFunc.sbText.Append("\r\n" + "                    $('#add_dialog').dialog('close');");
                objJsFunc.sbText.Append("\r\n" + "                    $('#tbl').datagrid('reload');");
                objJsFunc.sbText.Append("\r\n" + "                } else {");
                objJsFunc.sbText.Append("\r\n" + "                    $.messager.alert(\"������ʾ\", data.Message);");
                objJsFunc.sbText.Append("\r\n" + "                }");
                objJsFunc.sbText.Append("\r\n" + "            }");
                objJsFunc.sbText.Append("\r\n" + "        });");
                objJsFunc.sbText.Append("\r\n" + "    }");
                arrJsFunc.Add(objJsFunc);
            }
            using (JsFunction objJsFunc = new JsFunction())
            {
                objJsFunc.funcName = "GetReturnStr";
                objJsFunc.sbText.Append("\r\n" + "    function GetReturnStr() {");
                objJsFunc.sbText.Append("\r\n" + "        //alert('complete');");
                objJsFunc.sbText.Append("\r\n" + "        //  $('#myModal4Edit').modal('show');");
                objJsFunc.sbText.AppendFormat("\r\n" + "        var {0} = \"ABC\";", objKeyField.PrivFuncName);
                objJsFunc.sbText.AppendFormat("\r\n" + "        $.post(\"GetReturnStr\", {{ {0}: {1} }}, function (data) {{ alert(data); }});",
                    objKeyField.FldName, objKeyField.PrivFuncName);
                objJsFunc.sbText.Append("\r\n" + "    }");
                arrJsFunc.Add(objJsFunc);
            }
            arrJsFunc.Sort((x, y) => { return x.funcName.CompareTo(y.funcName); });
           

            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;

            strCodeForCs.Append("\r\n" + "<script type=\"text/javascript\">");
            strCodeForCs.Append("\r\n" + "//Js����,���ڽ����CRUD, ��֮��,���ܺ���������");
            Gen_MvcView_Js_DdlSelected();

            foreach (JsFunction objJsFunction in arrJsFunc)
            {
                strCodeForCs.Append("\r\n" + objJsFunction.funcText);
            }

            strCodeForCs.Append("\r\n" + "</script>");
            return strCodeForCs.ToString();
        }


        /// <summary>
        /// ����:���ɲ�ѯ����
        /// </summary>
        /// <returns></returns>
        public string Gen_MvcView_QueryRegion()
        {
            string strFuncName = "";
          
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp ;     ///��ʱ����;

            try
            {
                ///���ɲ����¼�Ľ������;
                strCodeForCs.AppendFormat("\r\n" + "@* ���ɵ����Mvc View �Ĳ�ѯ���� *@");
                strCodeForCs.AppendFormat("\r\n" + "@* ���ɺ���:{0} *@", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "<div id=\"user_accordion\" class=\"easyui-accordion\" style=\"width:100%\" data-options=\"multiple:true\">");
                strCodeForCs.Append("\r\n" + "   <div title=\"��ѯѡ��\" style=\"padding:10px;\" data-options=\"collapsed:false,collapsible:true\">");
                strCodeForCs.Append("\r\n" + "     <div style=\"width:98%;margin:auto\">");
                strCodeForCs.AppendFormat("\r\n" + "     @using (Html.BeginForm(\"{1}_Query\", \"{0}\", FormMethod.Post))",
                    objMainPrjTab.TabName, objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "     {");
                string strTemp = Gen_MvcView_QryRegionCode4Table();
                strCodeForCs.AppendFormat("\r\n" + "{0}", strTemp);

                strCodeForCs.Append("\r\n" + "     }");
                strCodeForCs.Append("\r\n" + "     </div>");
                strCodeForCs.Append("\r\n" + "   </div>");
                strCodeForCs.Append("\r\n" + "</div>");

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
        /// ����:���ɲ�ѯ����
        /// </summary>
        /// <returns></returns>
        public string Gen_MvcView_QueryRegionAjax()
        {
            string strFuncName = "";
           
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp ;     ///��ʱ����;

            try
            {
                ///���ɲ����¼�Ľ������;
                strCodeForCs.AppendFormat("\r\n" + "@* ���ɵ����Mvc View �Ĳ�ѯ���� *@");
                strCodeForCs.AppendFormat("\r\n" + "@* ���ɺ���:{0} *@", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " <div id=\"divQryRegion\" class=\"float-left\">");
                strCodeForCs.AppendFormat("\r\n" + "     @using (Ajax.BeginForm(\"Command4Query\", \"{0}\", new AjaxOptions {{ OnSuccess = \"OnSuccessInQueryRegion\" }}))",
                    objMainPrjTab.TabName, objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "     {");
 

          
                strCodeForCs.Append("\r\n" + "<div style=\"float:left; width:80%;\">");

                string strTemp = Gen_MvcView_QryRegionCode4Table();
                strCodeForCs.AppendFormat("\r\n" + "{0}", strTemp);
                strCodeForCs.Append("\r\n" + "</div>");
                strCodeForCs.Append("\r\n" + "<div style=\"float:left; width:100%;\">");
                strCodeForCs.Append("\r\n" + Gen_ValidationSummary());

                strCodeForCs.Append("\r\n" + "</div>");

                //strCodeForCs.Append("\r\n" + "<div class=\"panel-footer\">");

            
                //strCodeForCs.Append("\r\n" + "     </div>");
                strCodeForCs.Append("\r\n" + "     }");
                                
                strCodeForCs.Append("\r\n" + "</div>");

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
        /// ����:���ɲ�ѯ����
        /// </summary>
        /// <returns></returns>
        public string Gen_MvcView_QueryRegionSpa()
        {
            string strFuncName = "";
          
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp ;     ///��ʱ����;

            try
            {
                ///���ɲ����¼�Ľ������;
                strCodeForCs.AppendFormat("\r\n" + "@* ���ɵ����Mvc View �Ĳ�ѯ���� *@");
                strCodeForCs.AppendFormat("\r\n" + "@* ���ɺ���:{0} *@", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "<div id=\"user_accordion\" class=\"easyui-accordion\" style=\"width:100%\" data-options=\"multiple:true\">");
                strCodeForCs.Append("\r\n" + "   <div title=\"��ѯѡ��\" style=\"padding:10px;\" data-options=\"collapsed:false,collapsible:true\">");
                strCodeForCs.Append("\r\n" + "     <div style=\"width:98%;margin:auto\">");
                strCodeForCs.AppendFormat("\r\n" + "     @using (Ajax.BeginForm(\"{1}_QueryAjax\", \"{0}\", ajaxOpts))",
                    objMainPrjTab.TabName, objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "     {");
                string strTemp = Gen_MvcView_QryRegionCode4Table();
                strCodeForCs.AppendFormat("\r\n" + "{0}", strTemp);

                strCodeForCs.Append("\r\n" + "     }");
                strCodeForCs.Append("\r\n" + "     </div>");
                strCodeForCs.Append("\r\n" + "   </div>");
                strCodeForCs.Append("\r\n" + "</div>");

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
        /// ����:���ɱ༭����
        /// </summary>
        /// <returns></returns>
        public string Gen_MvcView_EditRegion()
        {
            string strFuncName = "";
            if (objViewInfoENEx.arrEditRegionFldSet4InUse == null)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("��ǰ��ѡ��������:{0},�ڸý�����û�б༭��������!", strViewName);
                sbMessage.Append("\r\n��ǰ����Ĺ���:��ѯ(Q)���޸�(U)��ɾ��(D)�����(I)��");
                throw new clsDbObjException(sbMessage.ToString());
            }
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp ;     ///��ʱ����;

            try
            {
                ///���ɲ����¼�Ľ������;
                strCodeForCs.AppendFormat("\r\n" + "@* ���ɵ����Mvc View �ı༭���� *@");
                strCodeForCs.AppendFormat("\r\n" + "@* ���ɺ���:{0} *@", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n" + "<div class=\"modal fade\" id=\"divEditDialog_{0}\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"lblDialogTitle_{0}\" aria-hidden=\"true\">",
                    objViewInfoENEx.TabName_In);
                strCodeForCs.Append("\r\n" + "    <div class=\"modal-dialog modal-sm\">");
                strCodeForCs.Append("\r\n" + "        <div class=\"modal-content text-left\" style=\"width: 600px; \">");
                strCodeForCs.Append("\r\n" + "            <div class=\"modal-header\">");
                strCodeForCs.Append("\r\n" + "                <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\"><span aria-hidden=\"true\">��</span></button>");
                strCodeForCs.AppendFormat("\r\n" + "          <h4 class=\"modal-title\" id=\"lblDialogTitle_{1}\">{0}�༭</h4>", 
                    objViewInfoENEx.TabCnName,
                    objViewInfoENEx.TabName_In);
                strCodeForCs.Append("\r\n" + "                @Html.ValidationSummary(true, \"\", new { @class = \"text-danger\" })");
                strCodeForCs.Append("\r\n" + "            </div>");


                strCodeForCs.AppendFormat("\r\n" + "      @using (Html.BeginForm(\"Save\", \"{0}\", FormMethod.Post))",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "            {");
                strCodeForCs.Append("\r\n" + "                if (ViewBag.Operate == \"Add\")");
                strCodeForCs.Append("\r\n" + "                {");
                strCodeForCs.Append("\r\n" + "                     @Html.Hidden(\"Operate\", \"Add\")");
                strCodeForCs.Append("\r\n" + "                 }");
                strCodeForCs.Append("\r\n" + "                 else");
                strCodeForCs.Append("\r\n" + "                 {");
                strCodeForCs.Append("\r\n" + "                      @Html.Hidden(\"Operate\", \"Update\")");
                if (objKeyField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    strCodeForCs.AppendFormat("\r\n" + "@Html.Hidden(\"{0}\", \"@Model.{0}\")", FldName4Key);
                }
                strCodeForCs.Append("\r\n" + "                 }");


                strCodeForCs.Append("\r\n" + "                @Html.AntiForgeryToken()");
                strCodeForCs.Append("\r\n" + "                <div class=\"modal-body\">");
                strCodeForCs.Append("\r\n" + "                    <div class=\"modal-footer\">");
                string strTemp = Gen_MvcView_CtlViewCodeforTab();
                strCodeForCs.AppendFormat("\r\n" + "{0}", strTemp);
                strCodeForCs.Append("\r\n" + "                        <div class=\"form-group\">");
                strCodeForCs.Append("\r\n" + "                            <div class=\"col-md-offset-2 col-md-10\">");
                strCodeForCs.Append("\r\n" + "                                <input type=\"submit\" value=\"@btnSaveName\" class=\"btn btn-default\" name=\"btnSave\" id=\"btnSave\" />");
                strCodeForCs.Append("\r\n" + "                                <button class=\"btn btn-default\" data-dismiss=\"modal\">Cancel</button>");
                strCodeForCs.Append("\r\n" + "                            </div>");
                strCodeForCs.Append("\r\n" + "                        </div>");
                strCodeForCs.Append("\r\n" + "                    </div>");
                strCodeForCs.Append("\r\n" + "                </div>");
                strCodeForCs.Append("\r\n" + "            }");
                strCodeForCs.Append("\r\n" + "        </div>");
                strCodeForCs.Append("\r\n" + "    </div>");
                strCodeForCs.Append("\r\n" + "</div>");

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
        /// ����:���ɱ༭����
        /// </summary>
        /// <returns></returns>
        public string Gen_MvcView_EditRegionAjax()
        {
            string strFuncName = "";
            if (objViewInfoENEx.arrEditRegionFldSet4InUse == null)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("��ǰ��ѡ��������:{0},�ڸý�����û�б༭��������!", strViewName);
                sbMessage.Append("\r\n��ǰ����Ĺ���:��ѯ(Q)���޸�(U)��ɾ��(D)�����(I)��");
                throw new clsDbObjException(sbMessage.ToString());
            }
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp ;     ///��ʱ����;

            try
            {
                ///���ɲ����¼�Ľ������;
                strCodeForCs.AppendFormat("\r\n" + "@* ���ɵ����Mvc View �ı༭���� *@");
                strCodeForCs.AppendFormat("\r\n" + "@* ���ɺ���:{0} *@", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n" + "<div class=\"modal fade\" id=\"divEditDialog_{0}\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"lblDialogTitle_{0}\" aria-hidden=\"true\">",
                    objViewInfoENEx.TabName_In);
                strCodeForCs.Append("\r\n" + "    <div class=\"modal-dialog modal-sm\">");
                strCodeForCs.Append("\r\n" + "        <div class=\"modal-content text-left\" style=\"width: 600px; \">");
                strCodeForCs.Append("\r\n" + "            <div class=\"modal-header\">");
                strCodeForCs.Append("\r\n" + "                <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\"><span aria-hidden=\"true\">��</span></button>");
                strCodeForCs.AppendFormat("\r\n" + "          <h4 class=\"modal-title\" id=\"lblDialogTitle_{1}\">{0}�༭</h4>", 
                    objViewInfoENEx.TabCnName,
                    objViewInfoENEx.TabName_In);
                strCodeForCs.Append("\r\n" + "                @Html.ValidationSummary(true, \"\", new { @class = \"text-danger\" })");
                strCodeForCs.Append("\r\n" + "            </div>");


                strCodeForCs.AppendFormat("\r\n" + "      @using (Html.BeginForm(\"Save\", \"{0}\", FormMethod.Post))",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "            {");
                strCodeForCs.Append("\r\n" + "                if (ViewBag.Operate == \"Add\")");
                strCodeForCs.Append("\r\n" + "                {");
                strCodeForCs.Append("\r\n" + "                     @Html.Hidden(\"Operate\", \"Add\")");
                strCodeForCs.Append("\r\n" + "                 }");
                strCodeForCs.Append("\r\n" + "                 else");
                strCodeForCs.Append("\r\n" + "                 {");
                strCodeForCs.Append("\r\n" + "                      @Html.Hidden(\"Operate\", \"Update\")");
                if (objKeyField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    strCodeForCs.AppendFormat("\r\n" + "@Html.Hidden(\"{0}\", @Model.{0})", FldName4Key);
                }
                else
                {
                    //strCodeForCs.AppendFormat("\r\n" + "@Html.Hidden(\"{0}\", @Model.{0})", FldName4Key);
                }
                strCodeForCs.Append("\r\n" + "                 }");


                strCodeForCs.Append("\r\n" + "                @Html.AntiForgeryToken()");
                strCodeForCs.Append("\r\n" + "                <div class=\"modal-body\">");
                strCodeForCs.Append("\r\n" + "                    <div class=\"modal-footer\">");
                string strTemp = Gen_MvcView_CtlViewCodeforTab();
                strCodeForCs.AppendFormat("\r\n" + "{0}", strTemp);
                strCodeForCs.Append("\r\n" + "                        <div class=\"form-group\">");
                strCodeForCs.Append("\r\n" + "                            <div class=\"col-md-offset-2 col-md-10\">");
                strCodeForCs.Append("\r\n" + "                                <input type=\"submit\" value=\"@btnSaveName\" class=\"btn btn-default\" name=\"btnSave\" id=\"btnSave\" />");
                strCodeForCs.Append("\r\n" + "                                <button class=\"btn btn-default\" data-dismiss=\"modal\">Cancel</button>");
                strCodeForCs.Append("\r\n" + "                            </div>");
                strCodeForCs.Append("\r\n" + "                        </div>");
                strCodeForCs.Append("\r\n" + "                    </div>");
                strCodeForCs.Append("\r\n" + "                </div>");
                strCodeForCs.Append("\r\n" + "            }");
                strCodeForCs.Append("\r\n" + "        </div>");
                strCodeForCs.Append("\r\n" + "    </div>");
                strCodeForCs.Append("\r\n" + "</div>");

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
        /// ����:���ɱ༭����
        /// </summary>
        /// <returns></returns>
        public string Gen_MvcView_EditRegionSpa()
        {
            string strFuncName = "";
            if (objViewInfoENEx.arrEditRegionFldSet4InUse == null)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("��ǰ��ѡ��������:{0},�ڸý�����û�б༭��������!", strViewName);
                sbMessage.Append("\r\n��ǰ����Ĺ���:��ѯ(Q)���޸�(U)��ɾ��(D)�����(I)��");
                throw new clsDbObjException(sbMessage.ToString());
            }
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp ;     ///��ʱ����;

            try
            {
                ///���ɲ����¼�Ľ������;
                strCodeForCs.AppendFormat("\r\n" + "@* ���ɵ����Mvc View �ı༭���� *@");
                strCodeForCs.AppendFormat("\r\n" + "@* ���ɺ���:{0} *@", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n" + "<div class=\"modal fade\" id=\"divEditDialog_{0}\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"lblDialogTitle_{0}\" aria-hidden=\"true\">",
                    objViewInfoENEx.TabName_In);
                strCodeForCs.Append("\r\n" + "    <div class=\"modal-dialog modal-sm\">");
                strCodeForCs.Append("\r\n" + "        <div class=\"modal-content text-left\" style=\"width: 600px; \">");
                strCodeForCs.Append("\r\n" + "            <div class=\"modal-header\">");
                strCodeForCs.Append("\r\n" + "                <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\"><span aria-hidden=\"true\">��</span></button>");
                strCodeForCs.AppendFormat("\r\n" + "          <h4 class=\"modal-title\" id=\"lblDialogTitle_{1}\">{0}�༭</h4>",
                    objViewInfoENEx.TabCnName,
                    objViewInfoENEx.TabName_In);
                strCodeForCs.Append("\r\n" + "                @Html.ValidationSummary(true, \"\", new { @class = \"text-danger\" })");
                strCodeForCs.Append("\r\n" + "            </div>");


                strCodeForCs.AppendFormat("\r\n" + "      @using (Html.BeginForm(\"Save\", \"{0}\", FormMethod.Post))",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "            {");
                strCodeForCs.Append("\r\n" + "                if (ViewBag.Operate == \"Add\")");
                strCodeForCs.Append("\r\n" + "                {");
                strCodeForCs.Append("\r\n" + "                     @Html.Hidden(\"Operate\", \"Add\")");
                strCodeForCs.Append("\r\n" + "                 }");
                strCodeForCs.Append("\r\n" + "                 else");
                strCodeForCs.Append("\r\n" + "                 {");
                strCodeForCs.Append("\r\n" + "                      @Html.Hidden(\"Operate\", \"Update\")");
                if (objKeyField.PrimaryTypeId == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    strCodeForCs.AppendFormat("\r\n" + "@Html.Hidden(\"{0}\", @Model.{0})", FldName4Key);
                }
                else
                {
                    //strCodeForCs.AppendFormat("\r\n" + "@Html.Hidden(\"{0}\", @Model.{0})", FldName4Key);
                }
                strCodeForCs.Append("\r\n" + "                 }");


                strCodeForCs.Append("\r\n" + "                @Html.AntiForgeryToken()");
                strCodeForCs.Append("\r\n" + "                <div class=\"modal-body\">");
                strCodeForCs.Append("\r\n" + "                    <div class=\"modal-footer\">");
                string strTemp = Gen_MvcView_CtlViewCodeforTab();
                strCodeForCs.AppendFormat("\r\n" + "{0}", strTemp);
                strCodeForCs.Append("\r\n" + "                        <div class=\"form-group\">");
                strCodeForCs.Append("\r\n" + "                            <div class=\"col-md-offset-2 col-md-10\">");
                strCodeForCs.Append("\r\n" + "                                <input type=\"submit\" value=\"@btnSaveName\" class=\"btn btn-default\" name=\"btnSave\" id=\"btnSave\" />");
                strCodeForCs.Append("\r\n" + "                                <button class=\"btn btn-default\" data-dismiss=\"modal\">Cancel</button>");
                strCodeForCs.Append("\r\n" + "                            </div>");
                strCodeForCs.Append("\r\n" + "                        </div>");
                strCodeForCs.Append("\r\n" + "                    </div>");
                strCodeForCs.Append("\r\n" + "                </div>");
                strCodeForCs.Append("\r\n" + "            }");
                strCodeForCs.Append("\r\n" + "        </div>");
                strCodeForCs.Append("\r\n" + "    </div>");
                strCodeForCs.Append("\r\n" + "</div>");

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
        /// ����:�����б�����
        /// </summary>
        /// <returns></returns>
        public string Gen_MvcView_ListRegion()
        {
            string strFuncName = "";
            if (objViewInfoENEx.arrDGRegionFldSet == null)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("��ǰ��ѡ��������:{0},�ڸý�����û���б���������!", strViewName);
                sbMessage.Append("\r\n��ǰ����Ĺ���:��ѯ(Q)���޸�(U)��ɾ��(D)�����(I)��");
                throw new clsDbObjException(sbMessage.ToString());
            }
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp ;     ///��ʱ����;

            try
            {          
                strCodeForCs.AppendFormat("\r\n" + "@* ���ɵ����Mvc View ���б����� *@");
                strCodeForCs.AppendFormat("\r\n" + "@* ���ɺ���:{0} *@", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "    <div class=\"panel panel-default\">");
                strCodeForCs.AppendFormat("\r\n" + "        @using (Html.BeginForm(\"Deletes\", \"{0}\", FormMethod.Post))",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "        {");
                strCodeForCs.Append("\r\n" + "            <div class=\"panel-heading\">");
                strCodeForCs.AppendFormat("\r\n" + "                <h3>{0}�б�</h3>", objViewInfoENEx.TabCnName);
                strCodeForCs.Append("\r\n" + "            </div>");
                strCodeForCs.Append("\r\n" + "            <div class=\"panel-footer\">");
                strCodeForCs.Append("\r\n" + "                @Html.ActionLink(\"���\", \"Create\", null,");
                strCodeForCs.Append("\r\n" + "             new { @class = \"btn btn-default\" })");
                strCodeForCs.Append("\r\n" + "                @*@Html.ActionLink(\"ɾ��������¼\", \"DelRecords\", null,");
                strCodeForCs.Append("\r\n" + "                    new { @class = \"btn btn-default\" })*@");
                strCodeForCs.Append("\r\n" + "                <input type=\"submit\"");
                strCodeForCs.Append("\r\n" + "                       class=\"btn btn-default\"");
                strCodeForCs.Append("\r\n" + "                       value=\"ɾ��������¼\" />");
                strCodeForCs.Append("\r\n" + "            </div>");
                strCodeForCs.Append("\r\n" + "            <div class=\"panel-body\">");
                string strTemp = Gen_Mvc_DataGrid();
                strCodeForCs.Append("\r\n" + strTemp);
                strCodeForCs.Append("\r\n" + "    </div>");
                strCodeForCs.Append("\r\n" + "        }");
                strCodeForCs.Append("\r\n" + "    </div>");
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
        /// ����:�����б�����
        /// </summary>
        /// <returns></returns>
        public string Gen_MvcView_PartialListAjax()
        {
            string strFuncName = "";
            if (objViewInfoENEx.arrDGRegionFldSet == null)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("��ǰ��ѡ��������:{0},�ڸý�����û���б���������!", strViewName);
                sbMessage.Append("\r\n��ǰ����Ĺ���:��ѯ(Q)���޸�(U)��ɾ��(D)�����(I)��");
                throw new clsDbObjException(sbMessage.ToString());
            }
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp ;     ///��ʱ����;

            try
            {
                strCodeForCs.AppendFormat("\r\n" + "@* ���ɵ����Mvc ViewLstAjax ���б����� *@");
                strCodeForCs.AppendFormat("\r\n" + "@* ���ɺ���:{0} *@", clsStackTrace.GetCurrClassFunction());
                
                string strTemp = Gen_Mvc_DataGridAjax();
                strCodeForCs.Append("\r\n" + strTemp);
                             
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
        /// ����:�����б�����
        /// </summary>
        /// <returns></returns>
        public string Gen_MvcView_PartialListSpa()
        {
            string strFuncName = "";
            if (objViewInfoENEx.arrDGRegionFldSet == null)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("��ǰ��ѡ��������:{0},�ڸý�����û���б���������!", strViewName);
                sbMessage.Append("\r\n��ǰ����Ĺ���:��ѯ(Q)���޸�(U)��ɾ��(D)�����(I)��");
                throw new clsDbObjException(sbMessage.ToString());
            }
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp ;     ///��ʱ����;

            try
            {
                strCodeForCs.AppendFormat("\r\n" + "@* ���ɵ����Mvc ViewLstAjax ���б����� *@");
                strCodeForCs.AppendFormat("\r\n" + "@* ���ɺ���:{0} *@", clsStackTrace.GetCurrClassFunction());

                string strTemp = Gen_Mvc_DataGridAjax();
                strCodeForCs.Append("\r\n" + strTemp);

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
        /// ����:�����б�����
        /// </summary>
        /// <returns></returns>
        public string Gen_MvcView_ListRegionAjax()
        {
            string strFuncName = "";
            if (objViewInfoENEx.arrDGRegionFldSet == null)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("��ǰ��ѡ��������:{0},�ڸý�����û���б���������!", strViewName);
                sbMessage.Append("\r\n��ǰ����Ĺ���:��ѯ(Q)���޸�(U)��ɾ��(D)�����(I)��");
                throw new clsDbObjException(sbMessage.ToString());
            }
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp ;     ///��ʱ����;

            try
            {
                strCodeForCs.AppendFormat("\r\n" + "@* ���ɵ����Mvc View ���б����� *@");
                strCodeForCs.AppendFormat("\r\n" + "@* ���ɺ���:{0} *@", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "    <div class=\"float-left mt-2\"  style=\"width: 100%;\">");
                strCodeForCs.AppendFormat("\r\n" + "        @using (Ajax.BeginForm(\"Command4List\", \"{0}\", new AjaxOptions",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + " {");
                strCodeForCs.Append("\r\n" + " OnSuccess = \"OnSuccessInFeatureRegion\",");
                strCodeForCs.Append("\r\n" + " OnFailure = \"OnFailureInFeatureRegion\""); 
                strCodeForCs.Append("\r\n" + " }))");
                //@using(Ajax.BeginForm("Command4List", "Student", new AjaxOptions
                //{
                //    OnSuccess = "OnSuccess"
                //}))
                strCodeForCs.Append("\r\n" + "        {");
                strCodeForCs.Append("\r\n" + "            <div >");
                //strCodeForCs.AppendFormat("\r\n" + "<ul class=\"nav\">");
                //strCodeForCs.AppendFormat("\r\n" + " <li class=\"nav-item\" style=\"width:250px;\">");
                //strCodeForCs.AppendFormat("\r\n" + "                <span class=\"h6\">{0}�б�</span>", objViewInfoENEx.TabCnName);
                //strCodeForCs.Append("\r\n" + "            </li>");
                //strCodeForCs.Append("\r\n" + " <li class=\"nav-item ml-3\">");
                //------panel-footer---------

                //strCodeForCs.Append("\r\n" + "            <div id=\"divFunction\" class=\"panel-footer\">");
                
                strCodeForCs.Append("\r\n" + Gen_MvcView_FeatureRegion());

                strCodeForCs.Append("\r\n" + "            </div>");
                //========panel-footer============

                //------panel-body---------
         
                strCodeForCs.AppendFormat("\r\n" + "    <div id = \"divLstTab_{0}\" class=\"mt-2\">",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "        @Html.Action(\"QueryAjax2\")",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "          </div>");
                //=============panel-body===========

                //------panel-footer---------
                strCodeForCs.Append("\r\n" + "      <div id=\"divLstFooter\" >");
                strCodeForCs.Append("\r\n" + "          @* ������б�-�ŵ��������,������ܵ� *@");
                strCodeForCs.Append("\r\n" + "      </div>");
                //========panel-footer============

                strCodeForCs.Append("\r\n" + "        }");
                strCodeForCs.Append("\r\n" + "    </div>");
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
        /// ����:�����б�����
        /// </summary>
        /// <returns></returns>
        public string Gen_MvcView_ListRegionSpa()
        {
            string strFuncName = "";
            if (objViewInfoENEx.arrDGRegionFldSet == null)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("��ǰ��ѡ��������:{0},�ڸý�����û���б���������!", strViewName);
                sbMessage.Append("\r\n��ǰ����Ĺ���:��ѯ(Q)���޸�(U)��ɾ��(D)�����(I)��");
                throw new clsDbObjException(sbMessage.ToString());
            }
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp ;     ///��ʱ����;

            try
            {
                strCodeForCs.AppendFormat("\r\n" + "@* ���ɵ����Mvc View ���б����� *@");
                strCodeForCs.AppendFormat("\r\n" + "@* ���ɺ���:{0} *@", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "    <div class=\"panel panel-default\">");
                strCodeForCs.AppendFormat("\r\n" + "        @using (Html.BeginForm(\"Deletes\", \"{0}\", FormMethod.Post))",
                    objMainPrjTab.TabName);
                strCodeForCs.Append("\r\n" + "        {");
                strCodeForCs.Append("\r\n" + "            <div class=\"panel-heading\">");
                strCodeForCs.AppendFormat("\r\n" + "          <h3>{0}�б�</h3>", objViewInfoENEx.TabCnName);
                strCodeForCs.Append("\r\n" + "            </div>");

                strCodeForCs.Append("\r\n" + "            <div class=\"panel-footer\">");

                strCodeForCs.Append("\r\n" + "<input type = \"button\" class=\"btn btn-default\" value=\"��Ӽ�¼\" onclick=\"AddRec()\" />");

                strCodeForCs.Append("\r\n" + "                @*@Html.ActionLink(\"ɾ��������¼\", \"DelRecords\", null,");
                strCodeForCs.Append("\r\n" + "                    new { @class = \"btn btn-default\" })*@");
                strCodeForCs.Append("\r\n" + "                <input type=\"submit\"");
                strCodeForCs.Append("\r\n" + "                       class=\"btn btn-default\"");
                strCodeForCs.Append("\r\n" + "                       value=\"ɾ��������¼\" />");
                strCodeForCs.Append("\r\n" + "            </div>");
                strCodeForCs.Append("\r\n" + "            <div class=\"panel-body\">");
                strCodeForCs.AppendFormat("\r\n" + "<div id = \"divLstTab_{0}\">",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "@Html.Action(\"QueryAjax\")",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "</div>");
                strCodeForCs.Append("\r\n" + "</div>");


                strCodeForCs.Append("\r\n" + "        }");
                strCodeForCs.Append("\r\n" + "    </div>");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }

            return strCodeForCs.ToString();
        }
              

        #region ���ɵ����ؼ������ɺ���


        public string Gen_Mvc_DataGrid()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //int iDGHeight;      //DataGrid�ĸ߶�
           
           
            try
            {
                ///���ɲ����¼�Ľ������;
                //objViewInfoENEx.objViewRegion_List.StyleZindex() = intZIndex + 1;
                //objViewInfoENEx.objViewRegion_List.StyleLeft = (int)intCurrLeft;
                //objViewInfoENEx.objViewRegion_List.StyleTop = (int)intCurrTop;

                //iDGHeight = objViewInfoENEx.objViewRegion_List.Height + 50;
               

                strCodeForCs.Append("\r\n" + "                <table class=\"table table-striped table-condensed table-bordered\">");
                strCodeForCs.Append("\r\n" + "                    <tr>");
                strCodeForCs.Append("\r\n" + "                        <th>");
                strCodeForCs.Append("\r\n" + "                            <label class=\"mt-checkbox mt-checkbox-single mt-checkbox-outline\">");
                strCodeForCs.Append("\r\n" + "                                <input id=\"btnCheckAll\" type=\"checkbox\" class=\"group-checkable\" data-set=\"#MyTable.checkboxes\" onchange=\"CheckAllHandler()\" />");
                strCodeForCs.Append("\r\n" + "                                <span></span>");
                strCodeForCs.Append("\r\n" + "                            </label>");
                strCodeForCs.Append("\r\n" + "                        </th>");
                foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
                {
                    string strFldName = objDGRegionFldsEx.ObjFieldTabENEx.FldName;
                    string strCaption = objDGRegionFldsEx.HeaderText;

                    strCodeForCs.Append("\r\n" + " <th class=\"text-left\">");
                    strCodeForCs.AppendFormat("\r\n" + "  @Html.ActionLink(\"{0}\", \"{2}_SortList\", new {{ sortOrder = ViewBag.{1}SortParm }})",
                        strCaption, strFldName, objViewInfoENEx.TabName_Out);
                    strCodeForCs.Append("\r\n" + " </th>");
                }
                strCodeForCs.Append("\r\n" + "                        <th class=\"text-center\">�޸�</th>");
                strCodeForCs.Append("\r\n" + "                        <th class=\"text-center\">ɾ��</th>");
                strCodeForCs.Append("\r\n" + "                    </tr>");

                string strSortExpression;

                strCodeForCs.AppendFormat("\r\n" + " @foreach (cls{0}EN item in Model.{0}Lst)", 
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + " {");
                strCodeForCs.Append("\r\n" + " <tr>");
                //if (objViewInfoENEx.objViewRegion_List.IsRadio() == true)    //�ж��Ƿ���Ҫ��ѡ��ť
                //{
                //    strCodeForCs.Append("\r\n" + "  <td>");
                //    strCodeForCs.Append("\r\n" + "     <label class=\"mt-checkbox mt-checkbox-single mt-checkbox-outline\">");
                //    strCodeForCs.AppendFormat("\r\n" + "     <input type=\"checkbox\" class=\"checkboxes\" value=\"@item.{0}\" checked=\"@item._Checked\" id=\"checkedId\" name =\"checkedId\" />",
                //        objKeyField.FldName);
                //    strCodeForCs.Append("\r\n" + "     <span></span>");
                //    strCodeForCs.Append("\r\n" + "     </label>");
                //    strCodeForCs.Append("\r\n" + "  </td>");
                //}
                //if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)    //�ж��Ƿ���Ҫ��ѡ��ť
                //{
                    strCodeForCs.Append("\r\n" + "   <td>");
                    strCodeForCs.Append("\r\n" + "       <label class=\"mt-checkbox mt-checkbox-single mt-checkbox-outline\">");
                    strCodeForCs.AppendFormat("\r\n" + "           <input type=\"checkbox\" class=\"checkboxes\" value=\"@item.{0}\" checked=\"@item._Checked\" id=\"checkedId\" name =\"checkedId\" />",
                        objKeyField.FldName);
                    strCodeForCs.Append("\r\n" + "           <span></span>");
                    strCodeForCs.Append("\r\n" + "       </label>");
                    strCodeForCs.Append("\r\n" + "  </td>");
                //}
            
                foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
                {
                    string strFldName = objDGRegionFldsEx.ObjFieldTabENEx.FldName;
                    if (objDGRegionFldsEx.IsNeedSort)   //�ж��Ƿ���Ҫ����
                    {
                        strSortExpression = "SortExpression = \"" + objDGRegionFldsEx.ObjFieldTabENEx.FldName + "\"";
                    }
                    else
                    {
                        strSortExpression = "";
                    }
                    strCodeForCs.AppendFormat("\r\n" + "   <td class=\"text-left\">@item.{0}</td>",
                        strFldName);
                }
                //if (objViewInfoENEx.objViewRegion_List.IsHaveUpdBtn() == true)   //��DG���Ƿ����޸İ�ť
                //{
                    strCodeForCs.Append("\r\n" + "   <td class=\"text-center\">");
                    strCodeForCs.AppendFormat("\r\n" + "      @Html.ActionLink(\"�޸�\", \"Update\", \"{0}\", new {{ {1} = @item.{1} }}, new {{ @class = \"btn btn-default\" }})",
                        objMainPrjTab.TabName, objKeyField.FldName);
                    strCodeForCs.Append("\r\n" + "   </td>");
                //}
                //if (objViewInfoENEx.objViewRegion_List.IsHaveDelBtn() == true)   //��DG���Ƿ���ɾ����ť
                //{
                    strCodeForCs.Append("\r\n" + "   <td class=\"text-center\">");
                    strCodeForCs.AppendFormat("\r\n" + "      @Html.ActionLink(\"ɾ��\", \"Delete\", \"{0}\", new {{ {1} = @item.{1} }}, new {{ @class = \"btn btn-default\" }})",
                        objMainPrjTab.TabName, objKeyField.FldName);
                    strCodeForCs.Append("\r\n" + "   </td>");
                //}
                //if (objViewInfoENEx.objViewRegion_List.IsHaveDetailBtn() == true) //��DG���Ƿ�����ϸ��Ϣ��ť
                //{
                    strCodeForCs.Append("\r\n" + "   <td class=\"text-center\">");
                    strCodeForCs.AppendFormat("\r\n" + "      @Html.ActionLink(\"��ϸ��Ϣ\", \"Detail\", \"{0}\", new {{ {1} = @item.{1} }}, new {{ @class = \"btn btn-default\" }})",
                        objMainPrjTab.TabName, objKeyField.FldName);
                    strCodeForCs.Append("\r\n" + "   </td>");
                //}
                strCodeForCs.Append("\r\n" + "  </tr>");
                strCodeForCs.Append("\r\n" + "  }");
                strCodeForCs.Append("\r\n" + " </table>");
                //strCodeForCs.Append("\r\n" + "</div>");
                //if (objViewInfoENEx.objViewRegion_List.IsJumpPage() == true)
                //{
                    strCodeForCs.Append("\r\n" + " <div class=\"btn-group pull-right\">");
                    strCodeForCs.AppendFormat("\r\n" + "   @Html.PageLinksV2(Model.PagingInfo, x => Url.Action(\"{0}_Pager\", new {{ page = x }}))",
                        objViewInfoENEx.TabName_Out);
                    strCodeForCs.Append("\r\n" + " </div>");

                    //intZIndex += objViewInfoENEx.objViewRegion_List.StyleZindex() + 1;
                    //intCurrTop += objViewInfoENEx.objViewRegion_List.Height + 5;
                    intCurrLeft = 10;
                //}
                
       
                intCurrTop += 45;

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_Mvc_DataGridAjax()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //int iDGHeight;      //DataGrid�ĸ߶�

            try
            {
                ///���ɲ����¼�Ľ������;
                //objViewInfoENEx.objViewRegion_List.StyleZindex() = intZIndex + 1;
                //objViewInfoENEx.objViewRegion_List.StyleLeft = (int)intCurrLeft;
                //objViewInfoENEx.objViewRegion_List.StyleTop = (int)intCurrTop;

                //iDGHeight = objViewInfoENEx.objViewRegion_List.Height + 50;

                strCodeForCs.Append("\r\n" + "                @Html.ValidationSummary(true, \"\", new { @class = \"text-danger\" })");

                strCodeForCs.Append("\r\n" + "                <table class=\"table table-striped table-condensed table-bordered\">");
                strCodeForCs.Append("\r\n" + "                    <tr>");
                strCodeForCs.Append("\r\n" + "                        <th>");
                strCodeForCs.Append("\r\n" + "                            <label class=\"mt-checkbox mt-checkbox-single mt-checkbox-outline\">");
                strCodeForCs.Append("\r\n" + "                                <input id=\"btnCheckAll\" type=\"checkbox\" class=\"group-checkable\" data-set=\"#MyTable.checkboxes\" onchange=\"CheckAllHandler()\" />");
                strCodeForCs.Append("\r\n" + "                                <span></span>");
                strCodeForCs.Append("\r\n" + "                            </label>");
                strCodeForCs.Append("\r\n" + "                        </th>");
                foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
                {
                    string strFldName = objDGRegionFldsEx.ObjFieldTabENEx.FldName;
                    string strCaption = objDGRegionFldsEx.HeaderText;

                    strCodeForCs.Append("\r\n" + " <th class=\"text-left\">");
                    strCodeForCs.AppendFormat("\r\n" + "  @Ajax.ActionLink(\"{0}\", \"SortListAjax\", new {{ sortOrder = ViewBag.{1}SortParm }}, ",
                        strCaption, strFldName, objViewInfoENEx.TabName_Out);
                    strCodeForCs.AppendFormat("\r\n" + "                new AjaxOptions {{ Url = Url.Action(\"SortListAjax\", new {{ sortOrder = ViewBag.{1}SortParm }}), UpdateTargetId = \"divLstTab_{2}\" }})",
                        strCaption, strFldName, objViewInfoENEx.TabName_Out);
                    strCodeForCs.Append("\r\n" + " </th>");
                }
                strCodeForCs.Append("\r\n" + "                        <th class=\"text-center\">�޸�</th>");
                strCodeForCs.Append("\r\n" + "                        <th class=\"text-center\">ɾ��</th>");
                strCodeForCs.Append("\r\n" + "                    </tr>");

                string strSortExpression;

                strCodeForCs.AppendFormat("\r\n" + " @foreach (cls{0}EN item in Model.{0}Lst)",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + " {");
                strCodeForCs.Append("\r\n" + " <tr>");
                //if (objViewInfoENEx.objViewRegion_List.IsRadio() == true)    //�ж��Ƿ���Ҫ��ѡ��ť
                //{
                //    strCodeForCs.Append("\r\n" + "  <td>");
                //    strCodeForCs.Append("\r\n" + "     <label class=\"mt-checkbox mt-checkbox-single mt-checkbox-outline\">");
                //    strCodeForCs.AppendFormat("\r\n" + "     <input type=\"checkbox\" class=\"checkboxes\" value=\"@item.{0}\" checked=\"@item._Checked\" id=\"checkedId\" name =\"checkedId\" />",
                //        objKeyField.FldName);
                //    strCodeForCs.Append("\r\n" + "     <span></span>");
                //    strCodeForCs.Append("\r\n" + "     </label>");
                //    strCodeForCs.Append("\r\n" + "  </td>");
                //}
                //if (objViewInfoENEx.objViewRegion_List.IsCheck() == true)    //�ж��Ƿ���Ҫ��ѡ��ť
                //{
                    strCodeForCs.Append("\r\n" + "   <td>");
                    strCodeForCs.Append("\r\n" + "       <label class=\"mt-checkbox mt-checkbox-single mt-checkbox-outline\">");
                    strCodeForCs.AppendFormat("\r\n" + "           <input type=\"checkbox\" class=\"checkboxes\" value=\"@item.{0}\" checked=\"@item._Checked\" id=\"checkedId\" name =\"checkedId\" />",
                        objKeyField.FldName);
                    strCodeForCs.Append("\r\n" + "           <span></span>");
                    strCodeForCs.Append("\r\n" + "       </label>");
                    strCodeForCs.Append("\r\n" + "  </td>");
                //}

                foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
                {
                    string strFldName = objDGRegionFldsEx.ObjFieldTabENEx.FldName;
                    if (objDGRegionFldsEx.IsNeedSort)   //�ж��Ƿ���Ҫ����
                    {
                        strSortExpression = "SortExpression = \"" + objDGRegionFldsEx.ObjFieldTabENEx.FldName + "\"";
                    }
                    else
                    {
                        strSortExpression = "";
                    }
                    strCodeForCs.AppendFormat("\r\n" + "   <td class=\"text-left\">@item.{0}</td>",
                        strFldName);
                }
                //if (objViewInfoENEx.objViewRegion_List.IsHaveUpdBtn() == true)   //��DG���Ƿ����޸İ�ť
                //{
                    strCodeForCs.Append("\r\n" + "   <td class=\"text-center\">");
                    strCodeForCs.AppendFormat("\r\n" + "      @Ajax.ActionLink(\"�޸�\", \"GetObjBy{1}\", \"{0}\", new {{ {1} = @item.{1} }}, new AjaxOptions {{  Url = Url.Action(\"GetJsonObjBy{1}\", new {{ {1} = @item.{1} }}), OnSuccess=\"UpdateRec\" }}, new {{ @class = \"btn btn-default\" }})",
                        objMainPrjTab.TabName, objKeyField.FldName);
                    strCodeForCs.Append("\r\n" + "   </td>");
                //}
                //if (objViewInfoENEx.objViewRegion_List.IsHaveDelBtn() == true)   //��DG���Ƿ���ɾ����ť
                //{
                    strCodeForCs.Append("\r\n" + "   <td class=\"text-center\">");
                    strCodeForCs.AppendFormat("\r\n" + "      @Html.ActionLink(\"ɾ��\", \"Delete\", \"{0}\", new {{ {1} = @item.{1} }}, new {{ @class = \"btn btn-default\" }})",
                        objMainPrjTab.TabName, objKeyField.FldName);
                    strCodeForCs.Append("\r\n" + "   </td>");
                //}
                //if (objViewInfoENEx.objViewRegion_List.IsHaveDetailBtn() == true) //��DG���Ƿ�����ϸ��Ϣ��ť
                //{
                    strCodeForCs.Append("\r\n" + "   <td class=\"text-center\">");
                    strCodeForCs.AppendFormat("\r\n" + "      @Html.ActionLink(\"��ϸ��Ϣ\", \"Detail\", \"{0}\", new {{ {1} = @item.{1} }}, new {{ @class = \"btn btn-default\" }})",
                        objMainPrjTab.TabName, objKeyField.FldName);
                    strCodeForCs.Append("\r\n" + "   </td>");
                //}
                strCodeForCs.Append("\r\n" + "  </tr>");
                strCodeForCs.Append("\r\n" + "  }");
                strCodeForCs.Append("\r\n" + " </table>");
                //strCodeForCs.Append("\r\n" + "</div>");
                //if (objViewInfoENEx.objViewRegion_List.IsJumpPage() == true)
                //{
                    strCodeForCs.Append("\r\n" + " <div class=\"btn-group pull-right\">");
                    strCodeForCs.Append("\r\n" + "   @Ajax.PageLinksAjax(Model.PagingInfo,");
                    strCodeForCs.AppendFormat("\r\n" + "       x => Url.Action(\"PagerAjax\", new {{ page = x }}), ",
                        objViewInfoENEx.TabName_Out);
                    strCodeForCs.AppendFormat("\r\n" + "        new AjaxOptions {{ Url = Url.Action(\"PagerAjax\"), UpdateTargetId = \"divLstTab_{0}\" }})",
                        objViewInfoENEx.TabName_Out);

                    strCodeForCs.Append("\r\n" + " </div>");

                    //intZIndex += objViewInfoENEx.objViewRegion_List.StyleZindex() + 1;
                    //intCurrTop += objViewInfoENEx.objViewRegion_List.Height + 5;
                    intCurrLeft = 10;
                //}
               

                intCurrTop += 45;

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }
        public string Gen_MvcView_FeatureRegion()
        {
            string strFuncName = "";
            string lngRegionId = "";
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //int iDGHeight;      //DataGrid�ĸ߶�
            //int iDG_Div_Left;
            
            try
            {
                ///���ɲ����¼�Ľ������;
      

                //strCodeForCs.AppendFormat("\r\n" + "<div id = \"divFunction\" class = \"div_Funttion\" runat = \"server\">",
                //  objViewInfoENEx.TabName, intCurrTop);
                //ASPDivEx objASPDivENEx_Function = clsASPDivBLEx.GetEmptyDiv();
                //objASPDivENEx_Function.Class = "table table-bordered table-hover";
                ////objASPDivENEx_Function.Runat = "server";
                //objASPDivENEx_Function.CtrlId = "divFunction";
                IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFldsObjLst = objViewInfoENEx.arrFeatureRegionFlds;
                if (objViewInfoENEx.arrFeatureRegionFlds == null)
                {
                    string strMsg = string.Format("���湦����Ϊ��,����ӽ��湦��!����:{0}. (In {1})", objViewInfoENEx.ViewName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);

                }
                IEnumerable<clsViewRegionENEx> arrViewRegion = objViewInfoENEx.arrViewRegion
                    .Where(x => x.RegionTypeId == enumRegionType.FeatureRegion_0008);
                if (arrViewRegion.Count() == 0)
                {
                    string strMsg = string.Format("���湦����Ϊ��,����ӽ��湦��!����:{0}. (In {1})", objViewInfoENEx.ViewName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);

                }
                lngRegionId = arrViewRegion.First().RegionId;

                IEnumerable<ASPControlEx> arrControls = clsFeatureRegionFldsBLEx.GetControlLst4Regoin(lngRegionId, objViewInfoENEx, "Item2");

                List<ASPControlGroupEx> arrControlGroupLst = arrControls
                    .OrderBy(x => x.OrderNum)
                    .Select(clsASPControlGroupBLEx.GetControlGroup).OrderBy(x => x.GroupName).ToList();


                //IEnumerable<ASPButtonEx> arrButtonLst = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.ViewImplId == enumViewImplementation.FunctionRegion_0001).Select(clsASPButtonBLEx.GetButton4MvcAjax);
                IEnumerable<ASPControlGroupEx> arrControlGroupLst_New = clsASPControlGroupBLEx.MergeControlGroup(arrControlGroupLst);



                //��Ӳ�div
                ASPUlEx objASPUlENEx = clsASPUlBLEx.GetEmptyUl();
                objASPUlENEx.Class = "nav";
                //objASPDivENEx_Function.arrSubAspControlLst2.Add(objASPUlENEx);

                ASPLiEx objASPLiENEx = clsASPLiBLEx.GetEmptyLi();
                objASPLiENEx.Class = "nav-item";
                objASPLiENEx.Style = "width:250px;";

                objASPUlENEx.arrSubAspControlLst2.Add(objASPLiENEx);
                //�б����
                ASPSpanEx objASPSpanENEx = clsASPSpanBLEx.GetDataListTitle(objViewInfoENEx.TabName, objViewInfoENEx.TabCnName);
                objASPLiENEx.arrSubAspControlLst2.Add(objASPSpanENEx);
                
                Action<ASPButtonEx> AddToLi = (x) =>
                {
                    objASPLiENEx = clsASPLiBLEx.GetEmptyLi();
                    objASPLiENEx.Class = "nav-item ml-3";
                    ASPButtonEx objASPNETButtonENEx = clsASPButtonBLEx.GetbtnAddNewRec4Gv();
                    objASPLiENEx.arrSubAspControlLst2.Add(x);
                    objASPUlENEx.arrSubAspControlLst2.Add(objASPLiENEx);
                };

                foreach (ASPControlGroupEx objInFor in arrControlGroupLst_New)
                {
                    objASPLiENEx = clsASPLiBLEx.GetEmptyLi();
                    objASPLiENEx.Class = "nav-item ml-3";
                    //ASPButtonEx objASPNETButtonENEx = clsASPButtonBLEx.GetbtnAddNewRec4Gv();
                    objASPLiENEx.arrSubAspControlLst2.Add(objInFor);
                    objASPUlENEx.arrSubAspControlLst2.Add(objASPLiENEx);
                }

                objASPLiENEx = clsASPLiBLEx.GetEmptyLi();
                objASPLiENEx.Class = "nav-item ml-3";          

                objASPUlENEx.arrSubAspControlLst2.Add(objASPLiENEx);
                //�б����
                ASPSpanEx objASPSpanENEx_Msg = clsASPSpanBLEx.GetDataListMsg("");
                objASPLiENEx.arrSubAspControlLst2.Add(objASPSpanENEx_Msg);


                objASPUlENEx.GeneCode4Mvc(strCodeForCs);
                intCurrTop += 45;

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        public string GenButtonGroupInQuery()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //int iDGHeight;      //DataGrid�ĸ߶�

            try
            {

                //< div class="row">
                //       <div class="col-md-6">
                //           @Html.ValidationSummary(true, "", new { @class = "text-danger" })
                //       </div>
                //       <div class="col-md-offset-1 col-md-1">
                //           <input value = "��ѯ" id="btnQuery" Name="action:QueryAjax" type="submit" class="btn btn-default" onclick="OnClickInFeatureRegion()" />
                //       </div>
                //       <div class="col-md-1">
                //           <input value = "����" id="btnExportExcel" Name="action:ExportExcelAjax" type="submit" class="btn btn-default" onclick="OnClickInFeatureRegion()" />
                //       </div>
                //       <div class="col-md-1">
                //           <span id = "spnExportExcel" ></ span >
                //       </ div >

                //   </ div >
                ASPUlEx objASPNETUlENEx = new ASPUlEx();
                objASPNETUlENEx.Class = "nav";
                //{
                //    ASPDivEx objASPNETDivENEx_6 = new ASPDivEx();
                //    objASPNETDivENEx_6.Class = "col-md-6";
                //    ASPCodeEx objASPNETCodeENEx = new ASPCodeEx();
                //    objASPNETCodeENEx.codeText = "@Html.ValidationSummary(true, \"\", new { @class = \"text-danger\" })";
                //    objASPNETDivENEx_6.arrSubAspControlLst2.Add(objASPNETCodeENEx);
                //    objASPNETDivENEx_Row.arrSubAspControlLst2.Add(objASPNETDivENEx_6);
                //}
                {
                    ASPLiEx objASPNETLiENEx_1_1 = new ASPLiEx();
                    objASPNETLiENEx_1_1.Class = "nav-item";
                    ASPButtonEx objASPNETButtonENEx_Query = clsASPButtonBLEx.GetbtnQuery(true, true);
                    objASPNETLiENEx_1_1.arrSubAspControlLst2.Add(objASPNETButtonENEx_Query);
                    objASPNETUlENEx.arrSubAspControlLst2.Add(objASPNETLiENEx_1_1);
                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExcelExport == true)
                {

                    ASPLiEx objASPNETLiENEx_1_2 = new ASPLiEx();
                    objASPNETLiENEx_1_2.Class = "nav-item ml-3";
                    ASPButtonEx objASPNETButtonENEx = clsASPButtonBLEx.GetbtnExportExcel4Gv(true, true);
                    objASPNETLiENEx_1_2.arrSubAspControlLst2.Add(objASPNETButtonENEx);

                    objASPNETUlENEx.arrSubAspControlLst2.Add(objASPNETLiENEx_1_2);
                }
               
                {

                    ASPLiEx objASPNETLiENEx_1_2 = new ASPLiEx();
                    objASPNETLiENEx_1_2.Class = "nav-item ml-3";
                    ASPCodeEx objASPCodeENEx = new ASPCodeEx();
                    objASPCodeENEx.CodeText = " @Html.ValidationSummary(true, \"\", new { @class = \"text-danger\" })";
                    
                    objASPNETLiENEx_1_2.arrSubAspControlLst2.Add(objASPCodeENEx);

                    objASPNETUlENEx.arrSubAspControlLst2.Add(objASPNETLiENEx_1_2);
                }


               

                {
                    ASPLiEx objASPNETLiENEx_1_3 = new ASPLiEx();

                    ASPSpanEx objASPNETSpanENEx = clsASPSpanBLEx.GetspnExportExcel(true);
                    objASPNETLiENEx_1_3.arrSubAspControlLst2.Add(objASPNETSpanENEx);
                    objASPNETUlENEx.arrSubAspControlLst2.Add(objASPNETLiENEx_1_3);
                }
                  
                   
                    if (objViewInfoENEx.IsNeedSetExportFld == true &&
      objViewInfoENEx.objViewTypeCodeTab.IsHaveSetExportExcel == true)
                    {
                    ASPLiEx objASPNETLiENEx_1_4 = new ASPLiEx();
                    ASPButtonEx objASPNETButtonENEx = clsASPButtonBLEx.GetbtnSetExportExcel4User(true, true);
                    objASPNETLiENEx_1_4.arrSubAspControlLst2.Add(objASPNETButtonENEx);

                    objASPNETUlENEx.arrSubAspControlLst2.Add(objASPNETLiENEx_1_4);
                    }

                objASPNETUlENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_ValidationSummary()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //int iDGHeight;      //DataGrid�ĸ߶�

            try
            {

                ASPCodeEx objASPCodeENEx = new ASPCodeEx();
                objASPCodeENEx.CodeText = " @Html.ValidationSummary(true, \"\", new { @class = \"text-danger\" })";


                objASPCodeENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

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
        /// ����CheckBox�ؼ�
        /// </summary>
        /// <param name = "objCheckStyle"></param>
        /// <returns></returns>
        public string GenCheckBoxNoPosition(clsCheckStyleEN objCheckStyle, string strCheckId, string strCheckText)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp;     ///��ʱ����;
            try
            {
                objCheckStyle.StyleZindex = intZIndex + 1;
                objCheckStyle.StyleLeft = (int)intCurrLeft;
                objCheckStyle.StyleTop = (int)intCurrTop;

                ///����CheckBox�Ĵ���;
                ///
                //���ɿؼ���<��ʼ��־>��<ID>
                strCodeForCs.Append("\r\n" + "<td>");
                strCodeForCs.AppendFormat("\r\n" + "<asp:CheckBox id = \"{0}\" ",
                  strCheckId);
                //����<�ؼ���ʽStyle>
                //����<�߶�>��<���>
                strCodeForCs.AppendFormat("\r\n" + "style = \"z-index: {0}; Width:{1}px; Height:{2}px;\" ",
                  objCheckStyle.StyleZindex,
                  objCheckStyle.Width, objCheckStyle.Height);
                //��������ģʽ�Ƿ��ڷ���������
                strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" ",
                  objCheckStyle.Runat);

                //����<�ֺ�>��<����>
                //strCodeForCs.AppendFormat("\r\n" + "Font-Size = \"{0}\" Font-Names = \"{1}\" ", 
                //  objCheckStyle.FontSize, objCheckStyle.FontName);
                //����<��ʾ�ı�> 
                strCodeForCs.AppendFormat("\r\n" + "Text = \"{0}\" ", strCheckText);

                //����<������־>
                strCodeForCs.Append("\r\n" + "CssClass = \"Check_Defa\"></asp:CheckBox>");

                strCodeForCs.Append("\r\n" + "</td>");

                intZIndex += 1;

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
        /// ����Button�ؼ�
        /// </summary>
        /// <param name = "objCheckStyle"></param>
        /// <returns></returns>
        public string Gen_Mvc_ButtonInForm(clsButtonStyleEN objButtonStyle, string strButtonId,
            string strButtonText, string strOnClick = "")
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp;     ///��ʱ����;
            try
            {
                objButtonStyle.StyleZindex = intZIndex + 1;
                objButtonStyle.StyleLeft = (int)intCurrLeft;
                objButtonStyle.StyleTop = (int)intCurrTop;

                ///����Button�Ĵ���;
                ///   <td>
                //    < input type = "submit" value = "��ѯ" class="btn btn-default" />
                //</td>

                //<td>
                //    <a href = "javascript:void(0);" class="easyui-linkbutton" data-options="iconCls:'icon-clear' " onclick="resetSearch()">���</a>
                //</td>
                //���ɿؼ���<��ʼ��־>��<ID>
                strCodeForCs.AppendFormat("\r\n" + "<input id = \"{0}\"  type=\"submit\" ",
                  strButtonId);
               
                strCodeForCs.AppendFormat("\r\n" + "value = \"{0}\" class = \"btn btn-default\" ", strButtonText);
                //���ɵ����¼�
                if (string.IsNullOrEmpty(strOnClick) == false)
                {
                    strCodeForCs.AppendFormat("\r\n" + "OnClick = \"{0}\" ", strOnClick);
                }
                //����<������־>
                strCodeForCs.Append("\r\n" + "/>");

                intZIndex += 1;

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
        /// ����DropDownList�ؼ�
        /// </summary>
        /// <param name = "objCheckStyle"></param>
        /// <returns></returns>
        public string GenDropDownLst(clsDropDownLstStyleEN objDropDownLstStyle, string strDropDownLstId)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp;     ///��ʱ����;
            try
            {
                objDropDownLstStyle.StyleZindex = intZIndex + 1;
                objDropDownLstStyle.StyleLeft = (int)intCurrLeft;
                objDropDownLstStyle.StyleTop = (int)intCurrTop;

                ///����DropDownList�Ĵ���;

                //���ɿؼ���<��ʼ��־>��<ID>
                strCodeForCs.AppendFormat("\r\n" + "<asp:DropDownList id = \"{0}\" ",
                  strDropDownLstId);
                //����<�ؼ���ʽStyle>
                strCodeForCs.AppendFormat("\r\n" + "style = \"z-index: {0}; left: {1}px; ",
                  objDropDownLstStyle.StyleZindex, objDropDownLstStyle.StyleLeft);
                //����<�߶�>��<���>
                strCodeForCs.AppendFormat("\r\n" + "position: {0}; top: {1}px; Width:{2}px; Height:{3}px;\" ",
                  objDropDownLstStyle.StylePosition, objDropDownLstStyle.StyleTop,
                  objDropDownLstStyle.Width, objDropDownLstStyle.Height);

                //��������ģʽ�Ƿ��ڷ���������
                strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" ",
                  objDropDownLstStyle.Runat);

                //����<�ֺ�>��<����>
                strCodeForCs.AppendFormat("\r\n" + "Font-Size = \"{0}\" Font-Names = \"{1}\" ",
                  objDropDownLstStyle.FontSize, objDropDownLstStyle.FontName);
                //����<ǰ��ɫ>
                if (objDropDownLstStyle.ForeColor != "")
                {
                    strCodeForCs.AppendFormat("\r\n" + "ForeColor = \"{0}\" ", objDropDownLstStyle.ForeColor);
                }
                //����<����ɫ>
                if (objDropDownLstStyle.BackColor != "")
                {
                    strCodeForCs.AppendFormat("\r\n" + "BackColor = \"{0}\" ", objDropDownLstStyle.BackColor);
                }
                //����<�ı��ֶ�>
                if (objDropDownLstStyle.DataTextField != "")
                {
                    strCodeForCs.AppendFormat("\r\n" + "DataTextField = \"{0}\" ", objDropDownLstStyle.DataTextField);
                }
                //����<ֵ�ֶ�>
                if (objDropDownLstStyle.DataValueField != "")
                {
                    strCodeForCs.AppendFormat("\r\n" + "DataValueField = \"{0}\" ", objDropDownLstStyle.DataValueField);
                }
                //����<�Ƿ�ɼ�>
                if (objDropDownLstStyle.Visible == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "Visible = \"{0}\" ", objDropDownLstStyle.Visible);
                }

                //����<������־>
                strCodeForCs.Append("\r\n" + "></asp:DropDownList>");

                intZIndex += 1;

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
        /// ����{��Ͽؼ�},����ߵı�ǩ,���ұߵ����������Ŀؼ�
        /// </summary>
        /// <param name = "objLabelStyle"></param>
        /// <param name = "strLabelId"></param>
        /// <param name = "strLabelText"></param>
        /// <param name = "objGenCtlStyle"></param>
        /// <param name = "strCtlTypeName"></param>
        /// <param name = "strCtlId"></param>
        /// <returns></returns>
        public string GenCombineCtl(clsLabelStyleEN objLabelStyle, string strLabelId, string strLabelText,
          clsGenCtlStyleEN objGenCtlStyle, string strCtlTypeName, string strCtlId)
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp;     ///��ʱ����;
            objLabelStyle.StyleZindex = intZIndex + 1;
            objLabelStyle.StyleLeft = (int)intCurrLeft;
            objLabelStyle.StyleTop = (int)intCurrTop;
            ///����Label�Ĵ���;
            strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"{0}\" style = \"z-index: {1}; left: {2}px; position: absolute; top: {4}px; Width:{5}px; Height:{6}px;\" ",
              strLabelId, objLabelStyle.StyleZindex, objLabelStyle.StyleLeft, objLabelStyle.StylePosition, objLabelStyle.StyleTop, objLabelStyle.Width, objLabelStyle.Height);
            strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" CssClass = \"NameLabel\">",
              objLabelStyle.Runat);
            strCodeForCs.AppendFormat("{0}</asp:Label>",
              strLabelText);

            intZIndex += 1;

            objGenCtlStyle.StyleZindex = intZIndex + 1;
            objGenCtlStyle.StyleLeft = (int)intCurrLeft + objLabelStyle.Width + 5;
            //objGenCtlStyle.StyleLeft = (int)intCurrLeft + 5;
            objGenCtlStyle.StyleTop = (int)intCurrTop;
            ///�����ұ߿ؼ��Ĵ���;

            strCodeForCs.AppendFormat("\r\n" + "<asp:{0} id = \"{1}\" style = \"z-index: {2}; left: {3}px; ",
              strCtlTypeName, strCtlId, objGenCtlStyle.StyleZindex, objGenCtlStyle.StyleLeft);
            strCodeForCs.AppendFormat("\r\n" + "position: absolute; top: {1}px; Width:{2}px; Height:{3}px;\" ",
              objGenCtlStyle.StylePosition, objGenCtlStyle.StyleTop, objGenCtlStyle.Width, objGenCtlStyle.Height);

            strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" CssClass = \"TextBox_Defa\">",
              objGenCtlStyle.Runat);
            strCodeForCs.AppendFormat("\r\n" + "</asp:{0}>",
              strCtlTypeName);
            intZIndex += 1;
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ����{��Ͽؼ�},����ߵı�ǩ,���ұߵ����������Ŀؼ�
        /// </summary>
        /// <param name = "objLabelStyle"></param>
        /// <param name = "strLabelId"></param>
        /// <param name = "strLabelText"></param>
        /// <param name = "objGenCtlStyle"></param>
        /// <param name = "strCtlTypeName"></param>
        /// <param name = "strCtlId"></param>
        /// <returns></returns>
        public string Gen_Mvc_CombineCtlWithFor(clsLabelStyleEN objLabelStyle, string strFldName, string strLabelId, string strLabelText,
          clsGenCtlStyleEN objGenCtlStyle, string strCtlTypeName, string strCtlId, string strDsTabId, string strDdlItemsOptionId)
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp;     ///��ʱ����;
            try
            {
                objLabelStyle.StyleZindex = intZIndex + 1;
                objLabelStyle.StyleLeft = (int)intCurrLeft;
                objLabelStyle.StyleTop = (int)intCurrTop;
                ///����Label�Ĵ���;

                strCodeForCs.Append("\r\n" + "<td>");
                strCodeForCs.AppendFormat("\r\n" + "@Html.LabelFor(model => model.{1}, htmlAttributes: new {{ @class = \"col-form-label text-right\", style = \"width:100px\" }})",
                    objViewInfoENEx.TabName_Out, strFldName);

                //strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"{0}\" style = \"z-index: {1};\" ",
                //  strLabelId, objLabelStyle.StyleZindex, objLabelStyle.Width, objLabelStyle.Height);
                //strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" CssClass = \"NameLabel\">",
                //  objLabelStyle.Runat);
                //strCodeForCs.AppendFormat("{0}</asp:Label>",
                //  strLabelText);
                strCodeForCs.Append("\r\n" + "</td>");

                intZIndex += 1;

                objGenCtlStyle.StyleZindex = intZIndex + 1;
                objGenCtlStyle.StyleLeft = (int)intCurrLeft + objLabelStyle.Width + 5;
                //objGenCtlStyle.StyleLeft = (int)intCurrLeft + 5;
                objGenCtlStyle.StyleTop = (int)intCurrTop;
                ///�����ұ߿ؼ��Ĵ���;
                strCodeForCs.Append("\r\n" + "<td>");
                switch (strCtlTypeName)
                {
                    case "TextBox":
                strCodeForCs.AppendFormat("\r\n" + "@Html.EditorFor(model => model.{1}, new {{ htmlAttributes = new {{ @class = \"form-control\" }} }})",
                    objViewInfoENEx.TabName_Out, strFldName);
                        break;
                    case "DropDownList":
                        if (strDdlItemsOptionId == enumDDLItemsOption.TrueAndFalseList_04)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "@Html.DropDownListFor(model => model.{1}, ViewData[\"TrueAndFalseList\"] as List<SelectListItem>)",
                                objViewInfoENEx.TabName_Out, strFldName);
                        }
                        else
                        {
                            clsPrjTabEN objPrjTab = clsPrjTabBL.GetObjByTabIdCache(strDsTabId, objProjectsENEx.PrjId);
                            strCodeForCs.AppendFormat("\r\n" + "@Html.DropDownListFor(model => model.{1}, ViewData[\"{2}List\"] as List<SelectListItem>)",
                                objViewInfoENEx.TabName_Out, strFldName, objPrjTab.TabName);
                        }
                        break;
                    default:
                        string strMsg = string.Format("�ؼ���:{1}��Switchû�д���,����!({0})",
                          clsStackTrace.GetCurrClassFunction(), strCtlTypeName);
                        throw new Exception(strMsg);
                       
            }

                //strCodeForCs.AppendFormat("\r\n" + "<asp:{0} id = \"{1}\" style = \"z-index: {2}; \" ",
                //  strCtlTypeName, strCtlId, objGenCtlStyle.StyleZindex, objGenCtlStyle.Width, objGenCtlStyle.Height);

                //strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" CssClass = \"TextBox_Defa\">",
                //  objGenCtlStyle.Runat);
                //strCodeForCs.AppendFormat("\r\n" + "</asp:{0}>",
                //  strCtlTypeName);
                strCodeForCs.Append("\r\n" + "</td>");

                intZIndex += 1;
            }
            catch (Exception objException)
            {
                string strMsg = string.Format("��������Ͽؼ�ʱ����!����:{0}.({1})", objException.Message, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }



        #endregion

        ///���¾��ǽ��������(VIEW) == == = 



        public bool DispDataGridRegionCtrl(System.Web.UI.WebControls.PlaceHolder phDataGridRegion, clsViewInfoENEx objViewInfoENEx)
        {

            Table objTable = new Table();//����һ�����
            Table objTable4JumpPage = new Table();//����һ�����
            objTable.BorderWidth = Unit.Parse("4");
            objTable.BorderColor = System.Drawing.Color.BurlyWood;

            objTable.Width = Unit.Parse("100%");
            TableRow tabRow;
            TableCell cell1;
            System.Web.UI.WebControls.Label lbl1;
            System.Web.UI.WebControls.TextBox txt1;
            System.Web.UI.WebControls.Button btn1;

            tabRow = new TableRow();//����һ��
            //if (objViewInfoENEx.objViewRegion_List.IsRadio() || objViewInfoENEx.objViewRegion_List.IsCheck())
            //{
                cell1 = new TableCell();//������Ԫ��,Ҳ���ǵ�һ��

                lbl1 = new Label();
                lbl1.Text = objViewInfoENEx.objInRelaTab.TabCnName + "�б�";
                lbl1.CssClass = "h6";
                //				lbl1.Style.Add("position","absolute");
                //				lbl1.Style.Add("left","4px");
                //				lbl1.Style.Add("top","4px");
                cell1.Controls.Add(lbl1);
                lbl1 = new Label();
                lbl1.Text = "��������";
                lbl1.CssClass = "h6";
                cell1.Controls.Add(lbl1);
                btn1 = MakeButton("��Ӽ�¼");
                cell1.Controls.Add(btn1);
                tabRow.Cells.Add(cell1);
                btn1 = MakeButton("�޸ļ�¼");
                cell1.Controls.Add(btn1);
                tabRow.Cells.Add(cell1);
                btn1 = MakeButton("ɾ����¼");
                cell1.Controls.Add(btn1);
                tabRow.Cells.Add(cell1);
                btn1 = MakeButton("����Excel");
                cell1.Controls.Add(btn1);
                tabRow.Cells.Add(cell1);
                objTable.Rows.Add(tabRow);//��ӵ������
            //}
            ///�½�����,ר���ڷ�Datagrid
            tabRow = new TableRow();//����һ��
            cell1 = new TableCell();//������Ԫ��,Ҳ���ǵ�һ��
            DataGrid dg = MakeGrid();
            cell1.Controls.Add(dg);
            cell1.HorizontalAlign = HorizontalAlign.Left;
            tabRow.Cells.Add(cell1);
            objTable.Rows.Add(tabRow);

            ///�½�����,ר���ڷ���ҳ
            ///
            tabRow = new TableRow();//����һ��
            cell1 = new TableCell();//������Ԫ��,Ҳ���ǵ�һ��
                                    //cell1.Font.Name = "verdana";
                                    //cell1.Font.Size = FontUnit.Parse("x-small");
            cell1.CssClass = "NameLabel";
            cell1.BackColor = System.Drawing.Color.Plum;    // "#c0c0c0";
            cell1.Text = "���м�¼:";
            tabRow.Cells.Add(cell1);

            cell1 = new TableCell();//������Ԫ��,Ҳ���ǵ�һ��
            lbl1 = MakeLabel("0");
            lbl1.Width = 16;
            cell1.Controls.Add(lbl1);
            tabRow.Cells.Add(cell1);

            cell1 = new TableCell();//������Ԫ��,Ҳ���ǵ�һ��
                                    //cell1.Font.Name = "verdana";
                                    //cell1.Font.Size = FontUnit.Parse("x-small");
            cell1.CssClass = "NameLabel";
            cell1.BackColor = System.Drawing.Color.Plum;    // "#c0c0c0";
            cell1.Text = "��ҳ��:";
            tabRow.Cells.Add(cell1);

            cell1 = new TableCell();//������Ԫ��,Ҳ���ǵ�һ��
            lbl1 = MakeLabel("0");
            lbl1.Width = 16;
            cell1.Controls.Add(lbl1);
            tabRow.Cells.Add(cell1);

            cell1 = new TableCell();//������Ԫ��,Ҳ���ǵ�һ��
                                    //cell1.Font.Name = "verdana";
                                    //cell1.Font.Size = FontUnit.Parse("x-small");
            cell1.CssClass = "NameLabel";
            cell1.BackColor = System.Drawing.Color.Plum;    // "#c0c0c0";
            cell1.Text = "��ǰҳ:";
            tabRow.Cells.Add(cell1);

            cell1 = new TableCell();//������Ԫ��,Ҳ���ǵ�һ��
            lbl1 = MakeLabel("0");
            lbl1.Width = 16;
            cell1.Controls.Add(lbl1);
            tabRow.Cells.Add(cell1);

            cell1 = new TableCell();//������Ԫ��,Ҳ���ǵ�һ��
            btn1 = MakeButton("��һҳ");
            btn1.Width = 50;
            cell1.Controls.Add(btn1);
            tabRow.Cells.Add(cell1);

            cell1 = new TableCell();//������Ԫ��,Ҳ���ǵ�һ��
            btn1 = MakeButton("��һҳ");
            btn1.Width = 50;
            cell1.Controls.Add(btn1);
            tabRow.Cells.Add(cell1);

            cell1 = new TableCell();//������Ԫ��,Ҳ���ǵ�һ��
                                    //cell1.Font.Name = "verdana";
                                    //cell1.Font.Size = FontUnit.Parse("x-small");
            cell1.CssClass = "NameLabel";
            cell1.BackColor = System.Drawing.Color.Plum;    // "#c0c0c0";
            cell1.Text = "����:";
            tabRow.Cells.Add(cell1);

            cell1 = new TableCell();//������Ԫ��,Ҳ���ǵ�һ��
            txt1 = MakeTextBox("1");
            txt1.Width = 35;
            cell1.Controls.Add(txt1);
            tabRow.Cells.Add(cell1);

            cell1 = new TableCell();//������Ԫ��,Ҳ���ǵ�һ��
            btn1 = MakeButton("ȷ��");
            btn1.Width = 35;
            cell1.Controls.Add(btn1);
            tabRow.Cells.Add(cell1);

            objTable4JumpPage.Rows.Add(tabRow);

            tabRow = new TableRow();
            cell1 = new TableCell();//������Ԫ��,Ҳ���ǵ�һ��
            cell1.Controls.Add(objTable4JumpPage);
            tabRow.Cells.Add(cell1);
            objTable.Rows.Add(tabRow);
            phDataGridRegion.Controls.Add(objTable);
            //			phDataGridRegion.Controls.Add(objTable4JumpPage);

            return true;
        }
        public DataGrid MakeGrid()
        {

            DataGrid mygrid = new DataGrid();
            mygrid.CellPadding = 2;
            mygrid.Attributes.Add("align", "center");
            mygrid.CellSpacing = 0;
            mygrid.Width = 700;
            mygrid.BorderWidth = 1;
            mygrid.BorderColor = ColorTranslator.FromHtml("Black");
            mygrid.AutoGenerateColumns = false;
            mygrid.ForeColor = ColorTranslator.FromHtml("Black");
            mygrid.Font.Size = 9;
            mygrid.Font.Name = "����";
            mygrid.AllowSorting = true;
            //if (objViewInfoENEx.objViewRegion_List.AllowPaging() == true)
            //{
                mygrid.AllowPaging = true;
            mygrid.PageSize = 15;// objViewInfoENEx.objViewRegion_List.PageSize();
                mygrid.ShowFooter = true;
                mygrid.PagerStyle.Mode = PagerMode.NumericPages;
            //}
            ///sort������¼�������

            //			mygrid.SortCommand += new DataGridSortCommandEventHandler(Sort_Grid);

            ///����headerstyle
            mygrid.HeaderStyle.BackColor = ColorTranslator.FromHtml("Gold");
            mygrid.HeaderStyle.ForeColor = ColorTranslator.FromHtml("Black");
            mygrid.HeaderStyle.Font.Name = "����";
            mygrid.HeaderStyle.Font.Size = 9;
            mygrid.HeaderStyle.Font.Bold = true;
            mygrid.HeaderStyle.HorizontalAlign = HorizontalAlign.Center;

            ///����alternating style
            mygrid.AlternatingItemStyle.BackColor = ColorTranslator.FromHtml("Silver");
            mygrid.AlternatingItemStyle.ForeColor = ColorTranslator.FromHtml("Black");

            ///����itemstyle
            mygrid.ItemStyle.HorizontalAlign = HorizontalAlign.Left;

            ///�������к�����
            int intColNo = 0;   //�����
                                ///����е�ѡ��ť
            //if (objViewInfoENEx.objViewRegion_List.IsRadio())
            //{
            //TemplateColumn tempCol = new TemplateColumn();
            //ColumnTemplate_Radio myColTemp = new ColumnTemplate_Radio();

            /////����ģ�������Ժ�ItemStyleģ��
            //tempCol.HeaderText = "ѡ��";
            //tempCol.HeaderStyle.HorizontalAlign = HorizontalAlign.Center;
            //tempCol.ItemStyle.BackColor = ColorTranslator.FromHtml("#FFF778");
            //tempCol.ItemStyle.HorizontalAlign = HorizontalAlign.Center;

            /////������ģ�塣
            /////��ģ���ITemplate�̳�
            //tempCol.ItemTemplate = myColTemp;
            //mygrid.Columns.AddAt(intColNo++, tempCol);

            //}
            ///����и�ѡ��ť
            //if (objViewInfoENEx.objViewRegion_List.IsCheck())
            //{
            TemplateColumn tempCol = new TemplateColumn();
            ColumnTemplate_Chk myColTemp = new ColumnTemplate_Chk();

            ///����ģ�������Ժ�ItemStyleģ��
            tempCol.HeaderText = "ȫѡ";
                tempCol.HeaderStyle.HorizontalAlign = HorizontalAlign.Center;
                tempCol.ItemStyle.BackColor = ColorTranslator.FromHtml("#FFF778");
                tempCol.ItemStyle.HorizontalAlign = HorizontalAlign.Center;

                ///������ģ�塣
                ///��ģ���ITemplate�̳�
                tempCol.ItemTemplate = myColTemp;
                mygrid.Columns.AddAt(intColNo++, tempCol);

            //}
            foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
            {
                BoundColumn boundCol = new BoundColumn();
                boundCol.HeaderText = objDGRegionFldsEx.HeaderText;
                boundCol.DataField = objDGRegionFldsEx.ObjFieldTabENEx.FldName;
                boundCol.SortExpression = objDGRegionFldsEx.ObjFieldTabENEx.FldName;
                mygrid.Columns.AddAt(intColNo++, boundCol);
                //					mygrid.Columns.AddAt(1, LastName);
            }

            //if (objViewInfoENEx.objViewRegion_List.IsHaveUpdBtn())
            //{
                ButtonColumn objButtonCol = new ButtonColumn();
                objButtonCol.HeaderText = "�޸�";
                objButtonCol.Text = "�޸�";
                //				objButtonCol.DataField = objViewCtlField.FldName;
                //				objButtonCol.SortExpression = objViewCtlField.FldName;
                objButtonCol.CommandName = "Update";
                mygrid.Columns.AddAt(intColNo++, objButtonCol);
            //}

            //if (objViewInfoENEx.objViewRegion_List.IsHaveDelBtn())
            //{
                ButtonColumn objButtonCol2 = new ButtonColumn();
            objButtonCol2.HeaderText = "ɾ��";
            objButtonCol2.Text = "ɾ��";
            //				objButtonCol.DataField = objViewCtlField.FldName;
            //				objButtonCol.SortExpression = objViewCtlField.FldName;
            objButtonCol2.CommandName = "Delete";
                mygrid.Columns.AddAt(intColNo++, objButtonCol2);

                //				TemplateColumn tempCol = new TemplateColumn();
                //				ColumnTemplate myColTemp = new ColumnTemplate();
                //
                //				///����ģ�������Ժ�ItemStyleģ��
                //				tempCol.HeaderText = "ɾ��";
                //				tempCol.HeaderStyle.HorizontalAlign = HorizontalAlign.Center;
                //				tempCol.ItemStyle.BackColor = ColorTranslator.FromHtml("#FFF778");
                //				tempCol.ItemStyle.HorizontalAlign = HorizontalAlign.Center;
                //				Button lb = new Button();
                //				lb.Text = "ɾ��";
                //				///������ģ�塣
                //				///��ģ���ITemplate�̳�
                //				myColTemp.InstantiateIn(lb);
                //				tempCol.ItemTemplate = myColTemp;
                //				
                ////<asp:TemplateColumn>
                ////<ItemTemplate>
                ////<asp:Button id = "lbnDelete" runat = "Server" CommandName = "Delete" Text = "ɾ��"></asp:Button>
                ////</ItemTemplate>
                ////</asp:TemplateColumn>
                ////
                //				mygrid.Columns.AddAt(intColNo++, tempCol);

            //}
            //if (objViewInfoENEx.objViewRegion_List.IsHaveDetailBtn())
            //{
                ButtonColumn objButtonCol3 = new ButtonColumn();
            objButtonCol3.HeaderText = "��ϸ";
            objButtonCol3.Text = "��ϸ";
            //				objButtonCol.DataField = objViewCtlField.FldName;
            //				objButtonCol.SortExpression = objViewCtlField.FldName;
            objButtonCol3.CommandName = "Update";
                mygrid.Columns.AddAt(intColNo++, objButtonCol3);
            //}

            mygrid.DataSource = MakeTestTable();

            mygrid.DataBind();
            return mygrid;
        }
        private DataView MakeTestTable()
        {
            // Create a new DataTable.
            System.Data.DataTable myDataTable = new DataTable("TestTable");
            // Declare variables for DataColumn and DataRow objects.
            DataColumn myDataColumn;
            DataRow myDataRow;
            foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
            {
                // Create new DataColumn, set DataType, ColumnName and add to DataTable.  
                myDataColumn = new DataColumn();
                myDataColumn.DataType = System.Type.GetType("System.String");
                myDataColumn.ColumnName = objDGRegionFldsEx.ObjFieldTabENEx.FldName;
                myDataColumn.ReadOnly = true;
                myDataColumn.Unique = false;
                // Add the Column to the DataColumnCollection.
                myDataTable.Columns.Add(myDataColumn);
            }
           
            for (int i = 0; i <= 2; i++)
            {
                myDataRow = myDataTable.NewRow();
                foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
                {
                    myDataRow[objDGRegionFldsEx.ObjFieldTabENEx.FldName] = i.ToString();
                }
                //				myDataRow["id"] = i;
                //				myDataRow["ParentItem"] = "ParentItem " + i;
                myDataTable.Rows.Add(myDataRow);
            }
            DataView myView = myDataTable.DefaultView;
            //myView.Sort = SortExpression;
            //Response.Write(sql);
            return myView;
        }

        public static Button MakeButton(string strButtonName)
        {
            System.Web.UI.WebControls.Button btn1;
            btn1 = new Button();
            btn1.Text = strButtonName;
            //btn1.Font.Name = "verdana";
            //btn1.Font.Size = FontUnit.Parse("x-small");
            btn1.CssClass = "btn btn-primary btn-sm";
            btn1.Width = 80;
            return btn1;
        }

        public static Label MakeLabel(string strLabelText)
        {
            System.Web.UI.WebControls.Label lbl1;
            lbl1 = new Label();
            lbl1.Text = strLabelText;
            lbl1.CssClass = "NameLabel";

            //lbl1.Font.Name = "verdana";
            //lbl1.Font.Size = FontUnit.Parse("x-small");
            lbl1.Width = 60;
            return lbl1;
        }
        public static TextBox MakeTextBox(string strTextBoxText)
        {
            System.Web.UI.WebControls.TextBox txt1;
            txt1 = new TextBox();
            txt1.Text = "";
            txt1.CssClass = "TextBox_Defa";
            //txt1.Font.Name = "verdana";
            //txt1.Font.Size = FontUnit.Parse("x-small");
            txt1.Width = 60;
            return txt1;
        }
        public static CheckBox MakeCheckBox(string strCheckBoxText)
        {
            System.Web.UI.WebControls.CheckBox chk1;
            chk1 = new CheckBox();
            chk1.Text = strCheckBoxText;
            chk1.CssClass = "Check_Defa";
            //chk1.Font.Name = "verdana";
            //chk1.Font.Size = FontUnit.Parse("x-small");
            chk1.Width = 100;
            return chk1;
        }


        public static bool DispEditRegionCtrl(System.Web.UI.WebControls.PlaceHolder phQryRegion, clsViewInfoENEx objViewInfoENEx)
        {
            int intColNum = objViewInfoENEx.objViewRegion_Edit.ColNum ?? 0;

            Table tb = new Table();//����һ�����
            tb.BorderWidth = Unit.Parse("4");
            tb.BorderColor = System.Drawing.Color.BurlyWood;
            tb.Width = Unit.Parse("100%");
            int iCtlNum = 0;
            TableRow tr;
            TableCell cell1, cell2;
            System.Web.UI.WebControls.Label lbl1;
            System.Web.UI.WebControls.CheckBox chk1;
            System.Web.UI.WebControls.TextBox txt1;
            System.Web.UI.WebControls.DropDownList ddl1;
            System.Web.UI.WebControls.Button btn1;
            System.Web.UI.WebControls.Panel panel1;

            panel1 = new Panel();
            panel1.Width = 700;
            panel1.Height = 32;


            //	<asp:label id = "Label1" style = "z-index: 109; left: 0px; position: absolute; top: 1px" runat = "server"
            //	CssClass = "h6">�༭�ֶ�����</asp:label></DIV>
            lbl1 = new Label();
            lbl1.Text = objViewInfoENEx.objInRelaTab.TabCnName + "�ֶ�����";
            lbl1.CssClass = "h6";
            //lbl1.Style.Add("position", "absolute");
            //lbl1.Style.Add("left", "4px");
            //lbl1.Style.Add("top", "4px");
            lbl1.Width = 400;
            panel1.Controls.Add(lbl1);

            btn1 = new Button();
            btn1.Text = "���";
            //btn1.Font.Name = "verdana";
            //btn1.Font.Size = FontUnit.Parse("x-small");
            btn1.CssClass = "btn btn-primary btn-sm";
            btn1.Width = 80;

            //<asp:Button id = "btnOKUpd" style = "z-index: 106; left: 720px; position: absolute; top: 0px" runat = "server"
            //												Font-Names = "verdana" Font-Size = "x-Small" Height = "24px" Width = "80px" Text = "���"></asp:Button>

            //btn1.Style.Add("position","absolute");
            //btn1.Style.Add("left","620px");
            //btn1.Style.Add("top","4px");
            panel1.Controls.Add(btn1);

            tr = new TableRow();//����һ��
            cell1 = new TableCell();//������Ԫ��,Ҳ���ǵ�һ��
            cell1.Controls.Add(panel1);
            cell1.ColumnSpan = intColNum * 2;
            tr.Cells.Add(cell1);
            //			for(int i = 0; i<intColNum*2-1; i++)
            //			{
            //				cell1 = new TableCell();//������Ԫ��,Ҳ���ǵ�һ��
            //				tr.Cells.Add(cell1);   
            //			}
            tb.Rows.Add(tr);//��ӵ������


            tr = new TableRow();//����һ��
            bool bolIsEndRow = false;
            foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
            {
                if (objEditRegionFldsEx.InUse == false) continue;
                if (iCtlNum % (intColNum * 2) == 0)
                {
                    tr = new TableRow();//����һ��
                    bolIsEndRow = false;
                }

                switch (objEditRegionFldsEx.objCtlType.CtlTypeName)
                {
                    case "CheckBox":
                        chk1 = new CheckBox();
                        chk1.Text = objEditRegionFldsEx.LabelCaption;
                        //chk1.Font.Name = "verdana";
                        //chk1.Font.Size = FontUnit.Parse("x-small");
                        lbl1.CssClass = "NameLabel";
                        chk1.Width = 100;
                        cell1 = new TableCell();//������Ԫ��,Ҳ���ǵ�һ��
                        cell1.Controls.Add(chk1);
                        tr.Cells.Add(cell1);
                        iCtlNum++;
                        cell2 = new TableCell();//������Ԫ��,Ҳ���ǵ�һ��
                        cell1.Text = "";
                        tr.Cells.Add(cell2);

                        break;
                    case "TextBox":
                        lbl1 = new Label();
                        lbl1.Text = objEditRegionFldsEx.LabelCaption;
                        //lbl1.Font.Name = "verdana";
                        //lbl1.Font.Size = FontUnit.Parse("x-small");
                        lbl1.CssClass = "NameLabel";
                        lbl1.Width = 60;
                        cell1 = new TableCell();//������Ԫ��,Ҳ���ǵ�һ��
                        cell1.Controls.Add(lbl1);
                        tr.Cells.Add(cell1);
                        iCtlNum++;
                        txt1 = new TextBox();
                        txt1.Text = "";
                        //txt1.Font.Name = "verdana";
                        //txt1.Font.Size = FontUnit.Parse("x-small");
                        txt1.CssClass = "TextBox_Defa";
                        txt1.Width = 60;
                        cell2 = new TableCell();//������Ԫ��,Ҳ���ǵ�һ��
                        cell2.Controls.Add(txt1);
                        tr.Cells.Add(cell2);
                        break;
                    case "DropDownList":
                        lbl1 = new Label();
                        lbl1.Text = objEditRegionFldsEx.LabelCaption;
                        //lbl1.Font.Name = "verdana";
                        //lbl1.Font.Size = FontUnit.Parse("x-small");
                        lbl1.CssClass = "NameLabel";
                        lbl1.Width = 60;
                        cell1 = new TableCell();//������Ԫ��,Ҳ���ǵ�һ��
                        cell1.Controls.Add(lbl1);
                        tr.Cells.Add(cell1);
                        iCtlNum++;
                        ddl1 = new DropDownList();
                        //							ddl1.Text = "";
                        //ddl1.Font.Name = "verdana";
                        //ddl1.Font.Size = FontUnit.Parse("x-small");
                        ddl1.CssClass = "DropDown_Defa";
                        ddl1.Width = 60;
                        cell2 = new TableCell();//������Ԫ��,Ҳ���ǵ�һ��
                        cell2.Controls.Add(ddl1);
                        tr.Cells.Add(cell2);
                        break;

                    default:
                        lbl1 = new Label();
                        lbl1.Text = objEditRegionFldsEx.LabelCaption;
                        //lbl1.Font.Name = "verdana";
                        //lbl1.Font.Size = FontUnit.Parse("x-small");
                        lbl1.Width = 60;
                        cell1 = new TableCell();//������Ԫ��,Ҳ���ǵ�һ��
                        cell1.Controls.Add(lbl1);
                        tr.Cells.Add(cell1);
                        iCtlNum++;
                        txt1 = new TextBox();
                        txt1.Text = "";
                        //txt1.Font.Name = "verdana";
                        //txt1.Font.Size = FontUnit.Parse("x-small");
                        txt1.Width = 60;
                        cell2 = new TableCell();//������Ԫ��,Ҳ���ǵ�һ��
                        cell2.Controls.Add(txt1);
                        tr.Cells.Add(cell2);
                        break;
                }

                if (iCtlNum % (intColNum * 2) == (intColNum * 2 - 1))
                {
                    tb.Rows.Add(tr);//��ӵ������
                    bolIsEndRow = true;
                }
                iCtlNum++;
            }
            if (bolIsEndRow == false)
            {
                tb.Rows.Add(tr);//��ӵ������
            }

            ///���ɲ�ѯ��ť�Ĵ���;
            //			strCodeForCs.Append("\r\n" + GenButton(objButtonStyle,"btnQuery","��ѯ"));
            phQryRegion.Controls.Add(tb);


            return true;
        }
        //��ʾԤ��<Excel��������>�Ŀؼ�
        public static bool DispExcelExportRegionCtrl(System.Web.UI.WebControls.PlaceHolder phExcelExportRegion, clsViewInfoENEx objViewInfoENEx)
        {

            Table tb = new Table();//����һ�����

            tb.BorderWidth = Unit.Parse("4");
            tb.BorderColor = System.Drawing.Color.BurlyWood;
            tb.Width = Unit.Parse("100%");
            TableRow tr;
            TableCell cell1;
            System.Web.UI.WebControls.Label lbl1;
            System.Web.UI.WebControls.CheckBox chk1;
            System.Web.UI.WebControls.Button btn1;
            int intColNum = objViewInfoENEx.objViewRegion_Query.ColNum ?? 0;
            int intIndex = 1;
            foreach (clsExcelExportRegionFldsENEx objExcelExportRegionFldsEx in objViewInfoENEx.arrExcelExportRegionFldSet)
            {
                tr = new TableRow();//����һ��
                                    //���
                lbl1 = new Label();
                lbl1.Text = intIndex.ToString();
                //lbl1.Font.Name = "verdana";
                //lbl1.Font.Size = FontUnit.Parse("x-small");
                lbl1.CssClass = "NameLabel";
                lbl1.Width = 20;
                cell1 = new TableCell();//������Ԫ��,Ҳ���ǵ�һ��
                cell1.Controls.Add(lbl1);
                tr.Cells.Add(cell1);

                //��ѡ��
                chk1 = new CheckBox();
                chk1.Text = "";
                //chk1.Font.Name = "verdana";
                //chk1.Font.Size = FontUnit.Parse("x-small");
                chk1.CssClass = "Check_Defa";
                chk1.Width = 30;
                cell1 = new TableCell();//������Ԫ��,Ҳ���ǵ�һ��
                cell1.Controls.Add(chk1);
                tr.Cells.Add(cell1);

                //�ֶ���(����)
                lbl1 = new Label();
                lbl1.Text = objExcelExportRegionFldsEx.ColCaption;
                //lbl1.Font.Name = "verdana";
                //lbl1.Font.Size = FontUnit.Parse("x-small");
                lbl1.CssClass = "NameLabel";
                lbl1.Width = 120;
                cell1 = new TableCell();//������Ԫ��,Ҳ���ǵ�һ��
                cell1.Controls.Add(lbl1);
                tr.Cells.Add(cell1);
                tb.Rows.Add(tr);//��ӵ������
                intIndex++;
            }
            //����EXCEL�İ�ť
            tr = new TableRow();//����һ��
                                //������
            cell1 = new TableCell();//������Ԫ��,Ҳ���ǵ�һ��
            tr.Cells.Add(cell1);
            cell1 = new TableCell();//������Ԫ��,Ҳ���ǵ�һ��
            tr.Cells.Add(cell1);

            btn1 = new Button();
            btn1.Text = "����Excel";
            //btn1.Font.Name = "verdana";
            //btn1.Font.Size = FontUnit.Parse("x-small");
            btn1.CssClass = "btn btn-primary btn-sm";
            btn1.Width = 80;
            cell1 = new TableCell();//������Ԫ��,Ҳ���ǵ�һ��
            cell1.Controls.Add(btn1);
            tr.Cells.Add(cell1);
            tb.Rows.Add(tr);//��ӵ������
                            ///���ɲ�ѯ��ť�Ĵ���;
            //			strCodeForCs.Append("\r\n" + GenButton(objButtonStyle,"btnQuery","��ѯ"));
            phExcelExportRegion.Controls.Add(tb);


            return true;
        }
        //��ʾԤ��<ListView����>�Ŀؼ�
        public static bool DispListViewRegionCtrl(System.Web.UI.WebControls.PlaceHolder phListViewRegion, clsViewInfoENEx objViewInfoENEx)
        {

            Table tb = new Table();//����һ�����

            tb.BorderWidth = Unit.Parse("4");
            tb.BorderColor = System.Drawing.Color.BurlyWood;
            tb.Width = Unit.Parse("100%");
            TableRow tr, tabRow;
            TableCell cell1;
            System.Web.UI.WebControls.Label lbl1;
            System.Web.UI.WebControls.Button btn1;
            int intColNum = objViewInfoENEx.objViewRegion_Query.ColNum ?? 0;

            Table objTable = new Table();//����һ�����

            tabRow = new TableRow();//����һ��

            cell1 = new TableCell();//������Ԫ��,Ҳ���ǵ�һ��
            lbl1 = new Label();
            lbl1.Text = objViewInfoENEx.objInRelaTab.TabCnName + "�б�";
            lbl1.CssClass = "h6";
            //				lbl1.Style.Add("position","absolute");
            //				lbl1.Style.Add("left","4px");
            //				lbl1.Style.Add("top","4px");
            lbl1.CssClass = "NameLabel";
            cell1.Controls.Add(lbl1);
            lbl1 = new Label();
            lbl1.Text = "��������";
            lbl1.CssClass = "h6";
            cell1.Controls.Add(lbl1);
            btn1 = MakeButton("��Ӽ�¼");
            cell1.Controls.Add(btn1);
            tabRow.Cells.Add(cell1);
            btn1 = MakeButton("�޸ļ�¼");
            cell1.Controls.Add(btn1);
            tabRow.Cells.Add(cell1);
            btn1 = MakeButton("ɾ����¼");
            cell1.Controls.Add(btn1);
            tabRow.Cells.Add(cell1);
            btn1 = MakeButton("����Excel");
            cell1.Controls.Add(btn1);
            tabRow.Cells.Add(cell1);
            objTable.Rows.Add(tabRow);//��ӵ������


            int intIndex = 1;
            tr = new TableRow();//����һ��
            foreach (clsDGRegionFldsENEx ObjLstViewRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
            {
                //�ֶ���(����)
                lbl1 = new Label();
                lbl1.Text = ObjLstViewRegionFldsEx.HeaderText;
                //lbl1.Font.Name = "verdana";
                //lbl1.Font.Size = FontUnit.Parse("x-small");
                lbl1.CssClass = "NameLabel";
                lbl1.Font.Bold = true;
                lbl1.Width = 60;
                cell1 = new TableCell();//������Ԫ��,Ҳ���ǵ�һ��
                cell1.Controls.Add(lbl1);
                tr.Cells.Add(cell1);
                intIndex++;
            }
            tb.Rows.Add(tr);//��ӵ������
            for (int i = 0; i < 5; i++)
            {
                tr = new TableRow();//����һ��
                intIndex = 1;
                int intFldNum = objViewInfoENEx.arrDGRegionFldSet.Count;
                for (int j = 0; j < intFldNum; j++)
                {
                    //�ֶ���(����)
                    lbl1 = new Label();
                    lbl1.Text = intIndex.ToString();
                    //lbl1.Font.Name = "verdana";
                    //lbl1.Font.Size = FontUnit.Parse("x-small");
                    lbl1.CssClass = "NameLabel";
                    lbl1.Width = 60;
                    cell1 = new TableCell();//������Ԫ��,Ҳ���ǵ�һ��
                    cell1.Controls.Add(lbl1);
                    tr.Cells.Add(cell1);
                    intIndex++;
                }
                tb.Rows.Add(tr);//��ӵ������
            }

            phListViewRegion.Controls.Add(objTable);
            phListViewRegion.Controls.Add(tb);
            return true;
        }
        //��ʾԤ����ѯ����Ŀؼ�
        public static int DispQryRegionCtrl(System.Web.UI.WebControls.PlaceHolder phQryRegion, clsViewInfoENEx objViewInfoENEx)
        {
            int intRow = 0, intCol = 0; //��ǰ��,��ǰ��
            int iCtlNum = 0;
            Table tb = new Table();//����һ�����

            tb.BorderWidth = Unit.Parse("4");
            tb.BorderColor = System.Drawing.Color.BurlyWood;
            tb.Width = Unit.Parse("100%");

            TableRow tr;
            TableCell cell1;//, cell2;
                            //System.Web.UI.WebControls.Label lbl1;
                            //System.Web.UI.WebControls.CheckBox chk1;
                            //System.Web.UI.WebControls.TextBox txt1;
                            //System.Web.UI.WebControls.DropDownList ddl1;
            System.Web.UI.WebControls.Button btn1;
            int intColNum = objViewInfoENEx.objViewRegion_Query.ColNum ?? 0;//�������������
            tr = new TableRow();//����һ��
            //bool bolIsEndRow = false;
            foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
            {
                if (intCol == intColNum)
                {
                    cell1 = new TableCell();//������Ԫ��,Ҳ���ǵ�һ��

                    tr.Cells.Add(cell1);
                    intCol++;

                    intRow++;
                    tb.Rows.Add(tr);//��ӵ������

                    tr = new TableRow();//����һ��
                    intCol = 0;
                    //bolIsEndRow = false;
                }
                wccFieldGroup wcc = new wccFieldGroup();
                wcc.Caption = objQryRegionFldsEx.LabelCaption;
                wcc.wccfg_CaptionCss = "NameLabel";
                wcc.wccfg_TextBoxCss = "TextBox_Defa";
                wcc.wccfg_LinkButtonCss = "lkbtn";
                wcc.Attributes.Add("DelThisCtrlClick", "wccFieldGroup2_DelThisCtrlClick");
                //wcc.DelThisCtrlClick += new EventHandler(wccFieldGroup2_DelThisCtrlClick);
                wcc.CtlTypeName = objQryRegionFldsEx.objCtlType.CtlTypeName;
                cell1 = new TableCell();//������Ԫ��,Ҳ���ǵ�һ��
                cell1.Controls.Add(wcc);
                tr.Cells.Add(cell1);
                intCol++;


                iCtlNum++;
            }
            //Ϊ���һ����ӵ�Ԫ��,ʹ���Ԫ��ȱ
            while (intCol < intColNum)
            {
                cell1 = new TableCell();//������Ԫ��,Ҳ���ǵ�һ��

                tr.Cells.Add(cell1);
                intCol++;
            }

            //if (bolIsEndRow == false)
            //{
            //  intRow++;
            //  tb.Rows.Add(tr);//��ӵ������
            //}
            //tr = new TableRow();//����һ��

            btn1 = new Button();
            btn1.Text = "��ѯ";
            //btn1.Font.Name = "verdana";
            //btn1.Font.Size = FontUnit.Parse("x-small");
            btn1.CssClass = "btn btn-primary btn-sm";
            btn1.Width = 80;
            cell1 = new TableCell();//������Ԫ��,Ҳ���ǵ�һ��
            cell1.Controls.Add(btn1);
            tr.Cells.Add(cell1);
            tb.Rows.Add(tr);//��ӵ������
            intRow++;
            ///���ɲ�ѯ��ť�Ĵ���;
            //			strCodeForCs.Append("\r\n" + GenButton(objButtonStyle,"btnQuery","��ѯ"));
            phQryRegion.Controls.Add(tb);


            return intRow;
        }
        //��ʾԤ��<��ϸ��Ϣ����>�Ŀؼ�
        public static bool DispDetailRegionCtrl(System.Web.UI.WebControls.PlaceHolder phDetailRegion, clsViewInfoENEx objViewInfoENEx)
        {

            Table tb = new Table();//����һ�����

            tb.BorderWidth = Unit.Parse("4");
            tb.BorderColor = System.Drawing.Color.BurlyWood;
            tb.Width = Unit.Parse("100%");
            int iCtlNum = 0;
            TableRow tr;
            TableCell cell1, cell2;
            System.Web.UI.WebControls.Label lbl1;
            System.Web.UI.WebControls.CheckBox chk1;
            System.Web.UI.WebControls.TextBox txt1;
            System.Web.UI.WebControls.DropDownList ddl1;
            System.Web.UI.WebControls.Button btn1;
            int intColNum = objViewInfoENEx.objViewRegion_Query.ColNum ?? 0;
            tr = new TableRow();//����һ��
            bool bolIsEndRow = false;
            foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
            {
                if (iCtlNum % (intColNum * 2) == 0)
                {
                    tr = new TableRow();//����һ��
                    bolIsEndRow = false;
                }

                switch (objQryRegionFldsEx.objCtlType.CtlTypeName)
                {
                    case "CheckBox":
                        chk1 = new CheckBox();
                        chk1.Text = objQryRegionFldsEx.LabelCaption;
                        //chk1.Font.Name = "verdana";
                        //chk1.Font.Size = FontUnit.Parse("x-small");
                        chk1.CssClass = "Check_Defa";
                        chk1.Width = 100;
                        cell1 = new TableCell();//������Ԫ��,Ҳ���ǵ�һ��
                        cell1.Controls.Add(chk1);
                        tr.Cells.Add(cell1);
                        iCtlNum++;
                        cell2 = new TableCell();//������Ԫ��,Ҳ���ǵ�һ��
                        cell1.Text = "";
                        tr.Cells.Add(cell2);
                        break;
                    case "TextBox":
                        lbl1 = new Label();
                        lbl1.Text = objQryRegionFldsEx.LabelCaption;
                        //lbl1.Font.Name = "verdana";
                        //lbl1.Font.Size = FontUnit.Parse("x-small");
                        lbl1.CssClass = "Label_Defa";
                        lbl1.Width = 60;
                        cell1 = new TableCell();//������Ԫ��,Ҳ���ǵ�һ��
                        cell1.Controls.Add(lbl1);
                        tr.Cells.Add(cell1);
                        iCtlNum++;
                        txt1 = new TextBox();
                        txt1.Text = "";
                        //txt1.Font.Name = "verdana";
                        //txt1.Font.Size = FontUnit.Parse("x-small");
                        txt1.CssClass = "TextBox_Defa";
                        txt1.Width = 60;
                        cell2 = new TableCell();//������Ԫ��,Ҳ���ǵ�һ��
                        cell2.Controls.Add(txt1);
                        tr.Cells.Add(cell2);
                        break;
                    case "DropDownList":
                        lbl1 = new Label();
                        lbl1.Text = objQryRegionFldsEx.LabelCaption;
                        //lbl1.Font.Name = "verdana";
                        //lbl1.Font.Size = FontUnit.Parse("x-small");
                        lbl1.CssClass = "NameLabel";
                        lbl1.Width = 60;
                        cell1 = new TableCell();//������Ԫ��,Ҳ���ǵ�һ��
                        cell1.Controls.Add(lbl1);
                        tr.Cells.Add(cell1);
                        iCtlNum++;
                        ddl1 = new DropDownList();
                        //							ddl1.Text = "";
                        //ddl1.Font.Name = "verdana";
                        //ddl1.Font.Size = FontUnit.Parse("x-small");
                        ddl1.CssClass = "DropDown_Defa";
                        ddl1.Width = 60;
                        cell2 = new TableCell();//������Ԫ��,Ҳ���ǵ�һ��
                        cell2.Controls.Add(ddl1);
                        tr.Cells.Add(cell2);
                        break;

                    default:
                        lbl1 = new Label();
                        lbl1.Text = objQryRegionFldsEx.LabelCaption;
                        //lbl1.Font.Name = "verdana";
                        //lbl1.Font.Size = FontUnit.Parse("x-small");
                        lbl1.CssClass = "NameLabel";
                        lbl1.Width = 60;
                        cell1 = new TableCell();//������Ԫ��,Ҳ���ǵ�һ��
                        cell1.Controls.Add(lbl1);
                        tr.Cells.Add(cell1);
                        iCtlNum++;
                        txt1 = new TextBox();
                        txt1.Text = "";
                        //txt1.Font.Name = "verdana";
                        //txt1.Font.Size = FontUnit.Parse("x-small");
                        txt1.CssClass = "TextBox_Defa";
                        txt1.Width = 60;
                        cell2 = new TableCell();//������Ԫ��,Ҳ���ǵ�һ��
                        cell2.Controls.Add(txt1);
                        tr.Cells.Add(cell2);
                        break;
                }

                if (iCtlNum % (intColNum * 2) == (intColNum * 2 - 1))
                {
                    tb.Rows.Add(tr);//��ӵ������
                    bolIsEndRow = true;
                }
                iCtlNum++;
            }

            if (bolIsEndRow == false)
            {
                tb.Rows.Add(tr);//��ӵ������
            }
            tr = new TableRow();//����һ��
                                //�ռ�����Ԫ��
            for (int i = 0; i < intColNum * 2 - 1; i++)
            {
                cell1 = new TableCell();//������Ԫ��,Ҳ���ǵ�һ��
                tr.Cells.Add(cell1);
            }
            btn1 = new Button();
            btn1.Text = "�ر�";
            //btn1.Font.Name = "verdana";
            //btn1.Font.Size = FontUnit.Parse("x-small");
            btn1.CssClass = "btn btn-primary btn-sm";
            btn1.Width = 80;
            cell1 = new TableCell();//������Ԫ��,Ҳ���ǵ�һ��
            cell1.Controls.Add(btn1);
            tr.Cells.Add(cell1);
            tb.Rows.Add(tr);//��ӵ������
                            ///���ɲ�ѯ��ť�Ĵ���;
            //			strCodeForCs.Append("\r\n" + GenButton(objButtonStyle,"btnQuery","��ѯ"));
            phDetailRegion.Controls.Add(tb);


            return true;
        }

        /// <summary>
        /// ����ָ���ĺ���
        /// </summary>
        /// <returns>�������ɵ�ָ����������</returns>
        public string A_GenCode4Function(clsViewInfoENEx objViewInfoENEx, string strFuncId4GC)
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///���������WebForm��ص����ļ�����;
            string strTemp = ""; //��ʱ����;
            string strFuncName = "";
            try
            {
                //������ʼ
                 clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
                strFuncName = objvFunction4GeneCodeEN.FuncName;

                //if (objFunction4GeneCodeEN.FuncTypeId == "10")//�û��Զ��庯��
                //{
                //    //strTemp = AutoGC_SelfDefineFunction.GeneCodeByFuncId(objFunction4GeneCodeEN.FuncId4GC,
                //    //    objPrjTabENEx.TabId, objPrjTabENEx.PrjDataBaseId, objPrjTabENEx.PrjId);
                //}
                //else
                //{
                //strTemp = A_GeneFuncCode(objViewInfoENEx, strFuncName);
                //}

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

        public string Gen_MvcView_CtlViewCodeforTab()
        {
            string strFuncName = "";
            //''�ù�����Ҫ���������صĿؼ�����,���������ļ�,;
            //һ���ǿؼ��Ľ����ļ�, ;
            //��һ����֮��صĽ������ļ�;
            //���û���������;

            objViewInfoENEx.CurrDate = clsDateTime.getTodayStr2(0);
            //string strFolder;
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;

            int intZIndex;
            //			int intCurrLeft;  ///�ؼ�����߿�;
            int intCurrTop;  ///�ؼ��Ķ����;
            objViewInfoENEx.WebUserCtlFName = objViewInfoENEx.FolderName + "wuc" + objViewInfoENEx.TabName + "B.ascx";
            objViewInfoENEx.FileName = objViewInfoENEx.WebUserCtlFName;
            objViewInfoENEx.ClsName = objViewInfoENEx.WebUserCtlFName;


            try
            {
                ///���ɲ����¼�Ľ������;

                intZIndex = 101;
                intCurrTop = 50;
                if (objViewInfoENEx.arrEditRegionFldSet4InUse == null || objViewInfoENEx.arrEditRegionFldSet4InUse.Count == 0)
                {
                    StringBuilder sbMessage = new StringBuilder();
                    string strViewName = objViewInfoENEx.ViewName;
                    sbMessage.AppendFormat("��ǰ��ѡ��������:{0},�ڸý�����û�б༭����,���߱༭����û���ֶΡ�����!", strViewName);
                    throw new clsDbObjException(sbMessage.ToString());
                }
                strCodeForCs.Append("\r\n" + "<table class=\"col-md-12\">");
                //strCodeForCs.Append("\r\n" + "<tr>");
                //strCodeForCs.Append("\r\n" + "<td class=\"col-md-3\">");
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.InUse == false) continue;
                    ///������ֶβ��Ǳ�ʶ�����;����ɿؼ�,����Ͳ�����;
                    if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                      && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        strCodeForCs.Append("\r\n" + "@Html.HiddenFor(model => model.{0})"); 
                    }
                    if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                        && objEditRegionFldsEx.PrimaryTypeId()== enumPrimaryType.StringAutoAddPrimaryKey_03)
                    {
                        continue;
                    }
                    string strFldName = objEditRegionFldsEx.FldName;
                    string strCaption = objEditRegionFldsEx.LabelCaption;
                    //strCodeForCs.Append("\r\n" + "                        <div class=\"form-group\">");
                    strCodeForCs.Append("\r\n" + "<tr>");
                    strCodeForCs.Append("\r\n" + "<td class=\"col-md-3\">");
                    switch (objEditRegionFldsEx.objCtlType.CtlTypeName)
                    {
                        case "CheckBox":
                            strCodeForCs.AppendFormat("\r\n" + "@Html.LabelFor(model => model.{0}, htmlAttributes: new {1} @class = \"control-label\" {2})",
                               strFldName, "{", "}");
                            strCodeForCs.AppendFormat("\r\n" + "</td>");
                            strCodeForCs.Append("\r\n" + "<td class=\"col-md-9\"  style=\"text-align:left\">");
                            strCodeForCs.AppendFormat("\r\n" + "     @Html.EditorFor(model => model.{0}, new {1} htmlAttributes = new {1} @class = \"form-control\"{2} {2})",
                                 strFldName, "{", "}");

                         
                            strCodeForCs.AppendFormat("\r\n" + "</td>");
                            break;
                        case "DropDownList":
                            clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabIdCache(objEditRegionFldsEx.DsTabId, objProjectsENEx.PrjId);
                            strCodeForCs.AppendFormat("\r\n" + "@Html.LabelFor(model => model.{0}, htmlAttributes: new {1} @class = \"control-label\" {2})",
                                strFldName, "{", "}");
                            strCodeForCs.Append("\r\n" + "</td>");
                            strCodeForCs.Append("\r\n" + "<td class=\"col-md-9\"  style=\"text-align:left\">");
                            //strCodeForCs.Append("\r\n" + "    <div class=\"col-md-8\">");
                            if (strFldName == FldName4Key)
                            {
                                strCodeForCs.Append("\r\n" + " @if (ViewBag.Operate == \"Add\")");
                                strCodeForCs.Append("\r\n" + " {");

                                strCodeForCs.AppendFormat("\r\n" + "     @Html.DropDownListFor(model => model.{0}, ViewData[\"{1}List\"] as List<SelectListItem>, new {{ htmlAttributes = new {{ @class = \"form-control\" }} }})",
                                    strFldName, objPrjTabEN.TabName);
                                strCodeForCs.AppendFormat("\r\n" + "     @Html.ValidationMessageFor(model => model.{0}, \"\", new {1} @class = \"text-danger\" {2})",
                                    strFldName, "{", "}");
                                strCodeForCs.Append("\r\n" + " }");
                                strCodeForCs.Append("\r\n" + " else");
                                strCodeForCs.Append("\r\n" + " {");

                                strCodeForCs.AppendFormat("\r\n" + "     @Html.DropDownListFor(model => model.{0}, ViewData[\"{1}List\"] as List<SelectListItem>, new {{ htmlAttributes = new {{ @class = \"form-control\" }} }})",
                                    strFldName, objPrjTabEN.TabName);
                                strCodeForCs.Append("\r\n" + " }");
                            }
                            else
                            {

                                strCodeForCs.AppendFormat("\r\n" + "     @Html.DropDownListFor(model => model.{0}, ViewData[\"{1}List\"] as List<SelectListItem>, new {{ htmlAttributes = new {{ @class = \"form-control\" }} }})",
                                    strFldName, objPrjTabEN.TabName);
                                strCodeForCs.AppendFormat("\r\n" + "     @Html.ValidationMessageFor(model => model.{0}, \"{1}����Ϊ��!\", new {2} @class = \"text-danger\" {3})",
                                    strFldName, strCaption, "{", "}");
                                strCodeForCs.Append("\r\n" + "           <asp:RequiredFieldValidator ID=\"RequiredFieldValidator2\" runat=\"server\"");
                                strCodeForCs.AppendFormat("\r\n" + "                 ControlToValidate=\"{0}\" Display=\"None\" ErrorMessage=\"������{1}\"></asp:RequiredFieldValidator>",
                                    strFldName, strCaption);
                            }
                            //strCodeForCs.Append("\r\n" + " </div>");
                            strCodeForCs.Append("\r\n" + "</td>");
                            break;
                        default:
                            strCodeForCs.AppendFormat("\r\n" + "@Html.LabelFor(model => model.{0}, htmlAttributes: new {1} @class = \"control-label\" {2})",
                                strFldName, "{", "}");
                            strCodeForCs.Append("\r\n" + "</td>");
                            strCodeForCs.Append("\r\n" + "<td class=\"col-md-9\">");

                            //strCodeForCs.Append("\r\n" + "    <div class=\"col-md-8\">");
                            if (strFldName == FldName4Key)
                            {
                                strCodeForCs.Append("\r\n" + " @if (ViewBag.Operate == \"Add\")");
                                strCodeForCs.Append("\r\n" + " {");
                                strCodeForCs.AppendFormat("\r\n" + "     @Html.EditorFor(model => model.{0}, new {1} htmlAttributes = new {1} @class = \"form-control\"{2} {2})",
                                    strFldName, "{", "}");
                                strCodeForCs.AppendFormat("\r\n" + "     @Html.ValidationMessageFor(model => model.{0}, \"\", new {1} @class = \"text-danger\" {2})",
                                    strFldName, "{", "}");
                                strCodeForCs.Append("\r\n" + " }");
                                strCodeForCs.Append("\r\n" + " else");
                                strCodeForCs.Append("\r\n" + " {");
                                strCodeForCs.AppendFormat("\r\n" + "     @Html.TextBoxFor(model => model.{0}, new {1} @readonly = \"readonly\", @class = \"form-control\" {2})",
                                    strFldName, "{", "}");
                                strCodeForCs.Append("\r\n" + " }");
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "     @Html.EditorFor(model => model.{0}, new {1} htmlAttributes = new {1} @class = \"form-control\"{2} {2})",
                                  strFldName, "{", "}");
                                strCodeForCs.AppendFormat("\r\n" + "     @Html.ValidationMessageFor(model => model.{0}, \"{1}����Ϊ��!\", new {2} @class = \"text-danger\" {3})",
                                    strFldName, strCaption, "{", "}");
                                strCodeForCs.Append("\r\n" + "           <asp:RequiredFieldValidator ID=\"RequiredFieldValidator2\" runat=\"server\"");
                                strCodeForCs.AppendFormat("\r\n" + "                 ControlToValidate=\"{0}\" Display=\"None\" ErrorMessage=\"������{1}\"></asp:RequiredFieldValidator>",
                                    strFldName, strCaption);
                            }
                            //strCodeForCs.Append("\r\n" + " </div>");
                            strCodeForCs.Append("\r\n" + "</td>");

                            break;
                    }
                    //strCodeForCs.Append("\r\n" + "                        </div>");
                    strCodeForCs.Append("\r\n" + "</tr>");


                    intZIndex += 1;
                    intCurrTop += 25;

                }
                strCodeForCs.Append("\r\n" + "  </table>");
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
                Type t = typeof(Mvc_ViewAjax4CSharp);
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
                string strErrMsg = objException.Message;
                if (strErrMsg == "���õ�Ŀ�귢�����쳣��")
                {
                    strErrMsg = objException.InnerException.Message;
                }
                sbMessage.AppendFormat("�����ɺ���:{0}ʱ����. \r\n������Ϣ:{1}.", strFuncName, strErrMsg);
                throw new Exception(sbMessage.ToString());
            }
        }
        public override void GetClsName()
        {
            this.ClsName = string.Format("{0}CRUDAjax", objViewInfoENEx.TabName);
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
        public string Gen_MvcView_Partial_EditRegion()
        {
            string strFuncName = "";
            if (objViewInfoENEx.arrEditRegionFldSet4InUse == null)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("��ǰ��ѡ��������:{0},�ڸý�����û�б༭��������!", strViewName);
                sbMessage.Append("\r\n��ǰ����Ĺ���:��ѯ(Q)���޸�(U)��ɾ��(D)�����(I)��");
                throw new clsDbObjException(sbMessage.ToString());
            }
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp ;     ///��ʱ����;

            try
            {                
                strCodeForCs.AppendFormat("\r\n" + "<div id = \"divEdit\">");
                strCodeForCs.AppendFormat("\r\n" + "</div>");
                //strCodeForCs.AppendFormat("\r\n" + "@Html.Partial(\"{0}EditAjax\")", objViewInfoENEx.TabName_In);
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }

            return strCodeForCs.ToString();
        }
        public string Gen_MvcView_Js_DdlSelected()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            List<string> arrTabName = new List<string>();
            try
            {
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd
                    || objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                {
                    strCodeForCs.Append("\r\n" + "//1��Ϊ��������������Դ,���б�����");
                    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                    {
                        if (objEditRegionFldsEx.InUse == false) continue;
                        if (objEditRegionFldsEx.objCtlType.CtlTypeName.Contains("DropDownList") == true)
                        {
                            if (objEditRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                            {
                                //if (arrTabName.Contains("TrueAndFalse") == false)
                                //{
                                //    arrTabName.Add("TrueAndFalse");
                                //    strCodeForCs.Append("\r\n" + "  ViewData[\"TrueAndFalseList\"] = clsPubFun.GetSliLst4TrueAndFalse();");
                                //}
                                using (JsFunction objJsFunc = new JsFunction())
                                {
                                    objJsFunc.funcName = string.Format("{0}Selected()", objEditRegionFldsEx.CtrlId);
                                    objJsFunc.sbText.AppendFormat("\r\n" + "function {0}Selected()", objEditRegionFldsEx.CtrlId);
                                    objJsFunc.sbText.Append("\r\n" + "{");
                                    objJsFunc.sbText.AppendFormat("\r\n" + "    var {1} = $('#{0} option:selected').val();        ",
                                        objEditRegionFldsEx.CtrlId, objEditRegionFldsEx.FldName);
                                    objJsFunc.sbText.Append("\r\n" + "    /**");

                                    objJsFunc.sbText.Append("\r\n" + "    $.ajax(");
                                    objJsFunc.sbText.Append("\r\n" + "    {");
                                    objJsFunc.sbText.AppendFormat("\r\n" + "        url: '/{0}/{1}Selected?{2}=' + {2},",
                                        objViewInfoENEx.TabName, objEditRegionFldsEx.CtrlId, objEditRegionFldsEx.FldName);
                                    objJsFunc.sbText.Append("\r\n" + "        type: 'GET',");
                                    objJsFunc.sbText.Append("\r\n" + "        data: \"\",");
                                    objJsFunc.sbText.Append("\r\n" + "        contentType: 'application/json; charset=utf-8',");
                                    objJsFunc.sbText.Append("\r\n" + "        success: function(data:any) {");
                                    objJsFunc.sbText.Append("\r\n" + "            var select = $('#ddlSubType');");
                                    objJsFunc.sbText.Append("\r\n" + "            select.empty();           ");
                                    objJsFunc.sbText.Append("\r\n" + "            $.each(data.SubTypeLst, function(index, itemData) {");
                                    objJsFunc.sbText.Append("\r\n" + "                select.append($('<option/>', {");
                                    objJsFunc.sbText.Append("\r\n" + "                    value: itemData.Value,");
                                    objJsFunc.sbText.Append("\r\n" + "                    text: itemData.Text");
                                    objJsFunc.sbText.Append("\r\n" + "                }));");
                                    objJsFunc.sbText.Append("\r\n" + "            });");
                                    objJsFunc.sbText.Append("\r\n" + "        },");
                                    objJsFunc.sbText.Append("\r\n" + "        error: function(e) {");
                                    objJsFunc.sbText.Append("\r\n" + "            alert(e);");
                                    objJsFunc.sbText.Append("\r\n" + "        }");
                                    objJsFunc.sbText.Append("\r\n" + "    });");
                                    objJsFunc.sbText.Append("\r\n" + "    **/");

                                    objJsFunc.sbText.Append("\r\n" + "}");

                                    arrJsFunction.Add(objJsFunc);
                                }
                            }
                            else
                            {
                                clsPrjTabEN objPrjTabEN_CodeTab = clsPrjTabBLEx.GetObjByTabIdEx(objEditRegionFldsEx.DsTabId);
                                if (objPrjTabEN_CodeTab == null)
                                {
                                    string strMsg = string.Format("�ڽ���༭��,{0}�����������Դ��û������,����!({1})",
                                        objEditRegionFldsEx.FldName,
                                        clsStackTrace.GetCurrClassFunction());
                                    throw new Exception(strMsg);
                                }

                                using (JsFunction objJsFunc = new JsFunction())
                                {
                                    objJsFunc.funcName = string.Format("{0}Selected()", objEditRegionFldsEx.CtrlId);

                                    objJsFunc.sbText.AppendFormat("\r\n" + "function {0}Selected()", objEditRegionFldsEx.CtrlId);
                                    objJsFunc.sbText.Append("\r\n" + "{");
                                    objJsFunc.sbText.AppendFormat("\r\n" + "    var {1} = $('#{0} option:selected').val();        ",
                                        objEditRegionFldsEx.CtrlId, objEditRegionFldsEx.FldName);
                                    objJsFunc.sbText.Append("\r\n" + "    /**");
                                    objJsFunc.sbText.Append("\r\n" + "    $.ajax(");
                                    objJsFunc.sbText.Append("\r\n" + "    {");
                                    objJsFunc.sbText.AppendFormat("\r\n" + "        url: '/{0}/{1}Selected?{2}=' + {2},",
                                        objViewInfoENEx.TabName, objEditRegionFldsEx.CtrlId, objEditRegionFldsEx.FldName);
                                    objJsFunc.sbText.Append("\r\n" + "        type: 'GET',");
                                    objJsFunc.sbText.Append("\r\n" + "        data: \"\",");
                                    objJsFunc.sbText.Append("\r\n" + "        contentType: 'application/json; charset=utf-8',");
                                    objJsFunc.sbText.Append("\r\n" + "        success: function(data:any) {");
                                    objJsFunc.sbText.Append("\r\n" + "            var select = $('#ddlSubType');");
                                    objJsFunc.sbText.Append("\r\n" + "            select.empty();           ");
                                    objJsFunc.sbText.Append("\r\n" + "            $.each(data.SubTypeLst, function(index, itemData) {");
                                    objJsFunc.sbText.Append("\r\n" + "                select.append($('<option/>', {");
                                    objJsFunc.sbText.Append("\r\n" + "                    value: itemData.Value,");
                                    objJsFunc.sbText.Append("\r\n" + "                    text: itemData.Text");
                                    objJsFunc.sbText.Append("\r\n" + "                }));");
                                    objJsFunc.sbText.Append("\r\n" + "            });");
                                    objJsFunc.sbText.Append("\r\n" + "        },");
                                    objJsFunc.sbText.Append("\r\n" + "        error: function(e) {");
                                    objJsFunc.sbText.Append("\r\n" + "            alert(e);");
                                    objJsFunc.sbText.Append("\r\n" + "        }");
                                    objJsFunc.sbText.Append("\r\n" + "    });");
                                    objJsFunc.sbText.Append("\r\n" + "    **/");

                                    objJsFunc.sbText.Append("\r\n" + "}");
                                    arrJsFunction.Add(objJsFunc);
                                }
                            }
                        }
                    }
                }


                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.objCtlType.CtlTypeName.Contains("DropDownList") == true)
                    {
                        if (objQryRegionFldsEx.ObjFieldTabENEx.CsType() == "bool")
                        {
                            //if (arrTabName.Contains("TrueAndFalse") == false)
                            //{
                            //    arrTabName.Add("TrueAndFalse");
                            //    strCodeForCs.Append("\r\n" + "  ViewData[\"TrueAndFalseList\"] = clsPubFun.GetSliLst4TrueAndFalse();");
                            //}
                            using (JsFunction objJsFunc = new JsFunction())
                            {
                                objJsFunc.funcName = string.Format("{0}Selected()", objQryRegionFldsEx.CtrlId());
                                objJsFunc.sbText.AppendFormat("\r\n" + "function {0}Selected()", objQryRegionFldsEx.CtrlId());
                                objJsFunc.sbText.Append("\r\n" + "{");
                                objJsFunc.sbText.AppendFormat("\r\n" + "    var {1} = $('#{0} option:selected').val();        ",
                                    objQryRegionFldsEx.CtrlId(), objQryRegionFldsEx.FldName);
                                objJsFunc.sbText.Append("\r\n" + "    /**");

                                objJsFunc.sbText.Append("\r\n" + "    $.ajax(");
                                objJsFunc.sbText.Append("\r\n" + "    {");
                                objJsFunc.sbText.AppendFormat("\r\n" + "        url: '/{0}/{1}Selected?{2}=' + {2},",
                                    objViewInfoENEx.TabName, objQryRegionFldsEx.CtrlId(), objQryRegionFldsEx.FldName);
                                objJsFunc.sbText.Append("\r\n" + "        type: 'GET',");
                                objJsFunc.sbText.Append("\r\n" + "        data: \"\",");
                                objJsFunc.sbText.Append("\r\n" + "        contentType: 'application/json; charset=utf-8',");
                                objJsFunc.sbText.Append("\r\n" + "        success: function(data:any) {");
                                objJsFunc.sbText.Append("\r\n" + "            var select = $('#ddlSubType');");
                                objJsFunc.sbText.Append("\r\n" + "            select.empty();           ");
                                objJsFunc.sbText.Append("\r\n" + "            $.each(data.SubTypeLst, function(index, itemData) {");
                                objJsFunc.sbText.Append("\r\n" + "                select.append($('<option/>', {");
                                objJsFunc.sbText.Append("\r\n" + "                    value: itemData.Value,");
                                objJsFunc.sbText.Append("\r\n" + "                    text: itemData.Text");
                                objJsFunc.sbText.Append("\r\n" + "                }));");
                                objJsFunc.sbText.Append("\r\n" + "            });");
                                objJsFunc.sbText.Append("\r\n" + "        },");
                                objJsFunc.sbText.Append("\r\n" + "        error: function(e) {");
                                objJsFunc.sbText.Append("\r\n" + "            alert(e);");
                                objJsFunc.sbText.Append("\r\n" + "        }");
                                objJsFunc.sbText.Append("\r\n" + "    });");
                                objJsFunc.sbText.Append("\r\n" + "    **/");

                                objJsFunc.sbText.Append("\r\n" + "}");

                                arrJsFunction.Add(objJsFunc);
                            }
                        }
                        else
                        {
                            clsPrjTabEN objPrjTabEN_CodeTab = clsPrjTabBLEx.GetObjByTabIdEx(objQryRegionFldsEx.DsTabId);
                            //clsFieldTabEN objFieldTab_ValueField = clsFieldTabBL.GetObjByFldIdCache(objQryRegionFldsEx.DsDataValueFieldId, objViewInfoENEx.PrjId);
                            //clsFieldTabEN objFieldTabEN_TextField = clsFieldTabBL.GetObjByFldIdCache(objQryRegionFldsEx.Ds_DataTextFieldId, objViewInfoENEx.PrjId);

                            if (objPrjTabEN_CodeTab == null)
                            {
                                string strMsg = string.Format("�ڽ����ѯ��,{0}�����������Դ��û������,����!({1})",
                                    objQryRegionFldsEx.FldName,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                            }
                            //if (objFieldTab_ValueField == null)
                            //{
                            //    string strMsg = string.Format("�ڽ����ѯ��,{0}�����������Դֵ�ֶ�û������,����!({1})",
                            //        objQryRegionFldsEx.FldName,
                            //        clsStackTrace.GetCurrClassFunction());
                            //    throw new Exception(strMsg);
                            //}
                            //if (objFieldTabEN_TextField == null)
                            //{
                            //    string strMsg = string.Format("�ڽ����ѯ��,{0}�����������Դ�ı��ֶ�û������,����!({1})",
                            //        objQryRegionFldsEx.FldName,
                            //        clsStackTrace.GetCurrClassFunction());
                            //    throw new Exception(strMsg);
                            //}

                            using (JsFunction objJsFunc = new JsFunction())
                            {
                                objJsFunc.funcName = string.Format("{0}Selected()", objQryRegionFldsEx.CtrlId());
                                objJsFunc.sbText.AppendFormat("\r\n" + "function {0}Selected()", objQryRegionFldsEx.CtrlId());
                                objJsFunc.sbText.Append("\r\n" + "{");
                                objJsFunc.sbText.AppendFormat("\r\n" + "    var {1} = $('#{0} option:selected').val();        ",
                                    objQryRegionFldsEx.CtrlId(), objQryRegionFldsEx.FldName);
                                objJsFunc.sbText.Append("\r\n" + "    /**");

                                objJsFunc.sbText.Append("\r\n" + "    $.ajax(");
                                objJsFunc.sbText.Append("\r\n" + "    {");
                                objJsFunc.sbText.AppendFormat("\r\n" + "        url: '/{0}/{1}Selected?{2}=' + {2},",
                                    objViewInfoENEx.TabName, objQryRegionFldsEx.CtrlId(), objQryRegionFldsEx.FldName);
                                objJsFunc.sbText.Append("\r\n" + "        type: 'GET',");
                                objJsFunc.sbText.Append("\r\n" + "        data: \"\",");
                                objJsFunc.sbText.Append("\r\n" + "        contentType: 'application/json; charset=utf-8',");
                                objJsFunc.sbText.Append("\r\n" + "        success: function(data:any) {");
                                objJsFunc.sbText.Append("\r\n" + "            var select = $('#ddlSubType');");
                                objJsFunc.sbText.Append("\r\n" + "            select.empty();           ");
                                objJsFunc.sbText.Append("\r\n" + "            $.each(data.SubTypeLst, function(index, itemData) {");
                                objJsFunc.sbText.Append("\r\n" + "                select.append($('<option/>', {");
                                objJsFunc.sbText.Append("\r\n" + "                    value: itemData.Value,");
                                objJsFunc.sbText.Append("\r\n" + "                    text: itemData.Text");
                                objJsFunc.sbText.Append("\r\n" + "                }));");
                                objJsFunc.sbText.Append("\r\n" + "            });");
                                objJsFunc.sbText.Append("\r\n" + "        },");
                                objJsFunc.sbText.Append("\r\n" + "        error: function(e) {");
                                objJsFunc.sbText.Append("\r\n" + "            alert(e);");
                                objJsFunc.sbText.Append("\r\n" + "        }");
                                objJsFunc.sbText.Append("\r\n" + "    });");
                                objJsFunc.sbText.Append("\r\n" + "    **/");

                                objJsFunc.sbText.Append("\r\n" + "}");

                                arrJsFunction.Add(objJsFunc);
                            }
                        }
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
