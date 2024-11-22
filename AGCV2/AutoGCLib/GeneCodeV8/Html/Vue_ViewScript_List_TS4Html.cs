using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AGC.PureClass;
using AGC.PureClassEx;
using AgcCommBase;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commexception;
using com.taishsoft.common;
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
    partial class Vue_ViewScript_List_TS4Html : clsGeneCodeBase
    {
        protected clsPrjTabENEx objPrjTabEx_ListRegion = null;
        protected string strSqlDsTypeId4ListRegion = "";
        //private string strJSPath = "";
        private clsFuncModule_AgcEN objFuncModule_Gc = null;
        //clsBiDimDistribute objBiDimDistribue4Qry = null;
        #region ���캯��
        public Vue_ViewScript_List_TS4Html()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //

        }
        public Vue_ViewScript_List_TS4Html(string strViewId)
       : base("", strViewId, "", "")
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            this.strDataBaseType = clsPubConst.con_MsSql;

        }
        public Vue_ViewScript_List_TS4Html(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
        : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
        }

        #endregion

        public string Gen_List_Prop_Define()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "props:");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "items:");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "type: Array<any>,");
            strCodeForCs.Append("\r\n" + "required: true,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "showErrorMessage:");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "type: Boolean,");
            strCodeForCs.Append("\r\n" + "required: true,");
            strCodeForCs.Append("\r\n" + "default: false,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "emptyRecNumInfo:");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "type: String,");
            strCodeForCs.Append("\r\n" + "required: true,");
            strCodeForCs.Append("\r\n" + "default: '',");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "},");

            return strCodeForCs.ToString();
        }
        public string Gen_List_Emits_Define()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "emits: [");
            strCodeForCs.Append("\r\n" + "'on-edit-tab-relainfo', ");
            strCodeForCs.Append("\r\n" + "'on-sort-column'");
            strCodeForCs.Append("\r\n" + "], ");

            return strCodeForCs.ToString();
        }



        public string Gen_List_watch_Define()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "watch:");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "// ���� selectAllChecked �仯������ѡ����ͷ״̬�ı�ʱ���޸����м�¼��ѡ��״̬");
            strCodeForCs.Append("\r\n" + "selectAllChecked(newValue) {");
            strCodeForCs.Append("\r\n" + "this.items.forEach((item) => (item.checked = newValue));");
            strCodeForCs.Append("\r\n" + "},"); 
            strCodeForCs.Append("\r\n" + "},");

            return strCodeForCs.ToString();
        }


        public string Gen_List_methods_Define()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "methods:");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "},");

            return strCodeForCs.ToString();
        }

        public string Gen_List_Setup_Define()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            
            strCodeForCs.Append("\r\n" + "setup(_, { emit }) {");

            strCodeForCs.Append("\r\n" + "const selectAllChecked = ref (false); // ��ʼ����ѡ����ͷѡ��״̬Ϊ false);");
            strCodeForCs.Append("\r\n" + "const sortColumnKey = ref (''); // ��ʼ��������");
            strCodeForCs.Append("\r\n" + "const sortDirection = ref ('asc'); // ��ʼ��������");
            strCodeForCs.Append("\r\n" + Gen_List_Setup_Fun_btnClickInRow());

            strCodeForCs.Append("\r\n" + Gen_List_Setup_Fun_sortColumn());
            strCodeForCs.Append("\r\n" + Gen_List_Setup_Fun_selectAllRows());

            strCodeForCs.Append("\r\n" + "    return {");
            // items,
            strCodeForCs.Append("\r\n" + "btnClickInRow,");
            strCodeForCs.Append("\r\n" + "sortColumn,");
            strCodeForCs.Append("\r\n" + "sortColumnKey,");
            strCodeForCs.Append("\r\n" + "sortDirection,");
            strCodeForCs.Append("\r\n" + "selectAllChecked,");
            strCodeForCs.Append("\r\n" + "selectAllRows,");
            strCodeForCs.Append("\r\n" + "};");
            strCodeForCs.Append("\r\n" + "},");


            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ����:����Ĳ�ѯ���޸ġ����롢ɾ��
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            if (objViewInfoENEx.objViewRegion_List == null || objViewInfoENEx.objViewRegion_List.IsDispInViewInfo(objViewInfoENEx) == false)
            {
                return "";
            }

            //���û���������;
            if (objViewInfoENEx.arrDGRegionFldSet == null || objViewInfoENEx.arrDGRegionFldSet.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("��ǰ��ѡ��������:{0},�ڸý�����û�б༭����,���߱༭����û���ֶΡ�����!", strViewName);
                sbMessage.Append("\r\n��ǰ����Ĺ���:��ѯ(Q)���޸�(U)��ɾ��(D)�����(I)��");
                throw new clsDbObjException(sbMessage.ToString());
            }
            var objPrjTab_ListRegion = clsPrjTabBL.GetObjByTabIdCache(TabId_Out4ListRegion, objViewInfoENEx.PrjId);
            if (objPrjTab_ListRegion != null)
            {
                strSqlDsTypeId4ListRegion = objPrjTab_ListRegion.SqlDsTypeId;
            }

            objPrjTabEx_ListRegion = clsPrjTabBLEx.CopyToEx(objPrjTab_ListRegion);
            objPrjTabEx_ListRegion.GetObjAllInfoEx();
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp ;     ///��ʱ����;


            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                    clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objViewInfoENEx.FunctionTemplateId,
                        objViewInfoENEx.LangType, objViewInfoENEx.CodeTypeId, objViewInfoENEx.SqlDsTypeId);

            objViewInfoENEx.WebFormName = string.Format("{0}", ThisClsName);
            objViewInfoENEx.WebFormFName = string.Format("{0}{1}.vue",
                objViewInfoENEx.FolderName, ThisClsName);
            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;

            strRe_ClsName = objViewInfoENEx.WebFormName;
            objFuncModule_Gc = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName(objFuncModule_Gc, objViewInfoENEx);

            try
            {
                strCodeForCs.Append("\r\n" + Gen_List_Template_DefDiv4ListRegion());
                strCodeForCs.Append("\r\n" + Gen_List_Script_DefDiv4ListRegion());
                strCodeForCs.Append("\r\n" + Gen_List_Style_DefDiv4ListRegion());

            }
            catch (Exception ex)
            {
                string strMsg = $"�����ɽ��������{ex.Message}. (In {clsStackTrace.GetCurrClassFunction()})";
                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }

            return strCodeForCs.ToString();
        }



        public string GenFeatureRegion(clsViewRegionEN objDGRegionENEx, clsViewInfoENEx objViewInfoENEx)
        {
            string strFuncName = "";
            string lngRegionId = "";
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;

            //			string strTemp ;     ///��ʱ����;
            ///�ж�DataGrid�Ƿ���Ҫ����
            foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
            {
                if (objDGRegionFldsEx.IsNeedSort)
                {
                    //objViewInfoENEx.objViewRegion_List.AllowSorting() = true;
                }
            }
            try
            {


                ASPDivEx objASPDivENEx_Function = clsASPDivBLEx.GetEmptyDiv();
                objASPDivENEx_Function.Class = "table table-bordered table-hover";
                objASPDivENEx_Function.Runat = "server";
                objASPDivENEx_Function.CtrlId = "divFunction";
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
                IEnumerable<ASPControlEx> arrControls = clsFeatureRegionFldsBLEx.GetControlLst4Regoin(lngRegionId, objViewInfoENEx, "");

                List<ASPControlGroupEx> arrControlGroupLst = arrControls
                    .OrderBy(x => x.OrderNum)
                    .Select(clsASPControlGroupBLEx.GetControlGroup)
                    .OrderBy(x => x.GroupName).ToList();


                //IEnumerable<ASPButtonEx> arrButtonLst = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.ViewImplId == enumViewImplementation.FunctionRegion_0001).Select(clsASPButtonBLEx.GetButton4MvcAjax);
                IEnumerable<ASPControlGroupEx> arrControlGroupLst_New = clsASPControlGroupBLEx.MergeControlGroup(arrControlGroupLst);


                //��Ӳ�div
                ASPUlEx objASPUlENEx = clsASPUlBLEx.GetEmptyUl();
                objASPUlENEx.Class = "nav";
                objASPDivENEx_Function.arrSubAspControlLst2.Add(objASPUlENEx);

                ASPLiEx objASPLiENEx = clsASPLiBLEx.GetEmptyLi();
                objASPLiENEx.Class = "nav-item";
                objASPUlENEx.arrSubAspControlLst2.Add(objASPLiENEx);
                //�б����
                ASPLabelEx objASPNETLabelENEx = clsASPLabelBLEx.GetDataListTitle(objViewInfoENEx, true);
                objASPLiENEx.arrSubAspControlLst2.Add(objASPNETLabelENEx);

                //Action<ASPButtonEx> AddToTd = (x) =>
                //{
                //    objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                //    ASPButtonEx objASPNETButtonENEx = clsASPButtonBLEx.GetbtnAddNewRec4Gv();
                //    objASPNETColENEx.arrSubAspControlLst2.Add(x);
                //    objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);
                //};
                //<li class="nav-item">

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

                objASPDivENEx_Function.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
                //����GridView�Ĵ���;

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }
        public string ClsName4WucTabName4Gv()
        {
            string strClsName = string.Format("wuc{0}4Gv", objViewInfoENEx.TabName_Out);
            return strClsName;
        }
        private string gfunRadioClick()
        {
            clsTitleStyleEN objTitleStyle = clsTitleStyleBL.GetObjByTitleStyleIdCache(objViewInfoENEx.objViewStyleEN.TitleStyleId);
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp;     ///��ʱ����;
            ///����Label�Ĵ���;
            strCodeForCs.Append("\r\n" + "<script language = \"javascript\">");
            strCodeForCs.Append("\r\n" + "<!--");
            strCodeForCs.Append("\r\n" + "function radioClick()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (document.Form1.RadioName != null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "for (i = 0; i<document.Form1.RadioName.length; i++)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "if (document.Form1.RadioName[i].checked == true)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "document.Form1.rd.value = document.Form1.RadioName[i].value;");
            //document.getElementById("TextBox1").value = document.Form1.rd.value;
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "//-->");
            strCodeForCs.Append("\r\n" + "</script>");

            intZIndex += 1;
            return strCodeForCs.ToString();


        }

        private string GenViewTitle(string strTitle, clsViewInfoENEx objViewInfoENEx)
        {
            if (string.IsNullOrEmpty(objViewInfoENEx.objViewStyleEN.TitleStyleId) == true)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("�ڽ���:{0}��,û�����ñ�������,����!", objViewInfoENEx.ViewName);
                throw new Exception(sbMsg.ToString());
            }
            clsTitleStyleEN objTitleStyle = clsTitleStyleBL.GetObjByTitleStyleIdCache(objViewInfoENEx.objViewStyleEN.TitleStyleId);
            if (objTitleStyle == null)
            {
                string strMsg = string.Format("(errid:BlEx000044)����ģʽId:[{0}]û����Ӧ�Ķ���,����!(AutoGC6Cs_VWeb_Net2005:GenViewTitle)", objViewInfoENEx.objViewStyleEN.TitleStyleId);
                throw new Exception(strMsg);
            }
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp;     ///��ʱ����;
            ///����Label�Ĵ���;
            switch (objTitleStyle.TitleTypeId)
            {
                case "01":
                    strCodeForCs.AppendFormat("\r\n" + "<table id = \"tabTitle\" style = \"z-index: 102; left: 8px; position: absolute; top: 1px\" cellspacing = \"1\" ");
                    strCodeForCs.AppendFormat("\r\n" + "cellpadding = \"1\" width = \"100%\" bgColor = \"{0}\" border = \"0\">",
                      objTitleStyle.BackColor);
                    strCodeForCs.AppendFormat("\r\n" + "<tr>");
                    strCodeForCs.AppendFormat("\r\n" + "<td bgColor = \"{0}\">",
                      objTitleStyle.BackColor);
                    strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"lblViewTile\" runat = \"server\" Font-Size = \"Small\" Font-Names = \"����\" ForeColor = \"{1}\" Font-Bold = \"True\">{0}</asp:Label>",
                      strTitle, objTitleStyle.ForeColor);
                    strCodeForCs.AppendFormat("\r\n" + "</td>");
                    strCodeForCs.AppendFormat("\r\n" + "</tr>");
                    strCodeForCs.AppendFormat("\r\n" + "</table>");
                    break;
                case "02":

                    break;
                case "03":
                    ASPDivEx objDiv = new ASPDivEx();
                    objDiv.Style = "position: relative; width: 648px; height: 37px; left: 0px; top: 0px;";
                    ASPLabelEx objLabel = new ASPLabelEx();
                    objLabel.CtrlId = "lblViewTitle";
                    objLabel.Class = "h5";
                    //objLabel.Is4PureHtml = true;
                    objLabel.Text = strTitle;
                    objDiv.arrSubAspControlLst2.Add(objLabel);
                    ASPLabelEx objLabel_ErrMsg = clsASPLabelBLEx.GetLabel4ErrMsg("lblMsg_List", true);
                    objDiv.arrSubAspControlLst2.Add(objLabel_ErrMsg);
                    objDiv.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

                    break;
            }

            intZIndex += 1;
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
        /// ����{��Ͽؼ�},����ߵı�ǩ,���ұߵ����������Ŀؼ�
        /// </summary>
        /// <param name = "objLabelStyle"></param>
        /// <param name = "strLabelId"></param>
        /// <param name = "strLabelText"></param>
        /// <param name = "objGenCtlStyle"></param>
        /// <param name = "strCtlTypeName"></param>
        /// <param name = "strCtlId"></param>
        /// <returns></returns>
        public string GenCombineCtlNoPosition(clsLabelStyleEN objLabelStyle, string strLabelId, string strLabelText,
          clsGenCtlStyleEN objGenCtlStyle, string strCtlTypeName, string strCtlId)
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp;     ///��ʱ����;
            objLabelStyle.StyleZindex = intZIndex + 1;
            objLabelStyle.StyleLeft = (int)intCurrLeft;
            objLabelStyle.StyleTop = (int)intCurrTop;
            ///����Label�Ĵ���;
            ///      
            strCodeForCs.Append("\r\n" + "<td>");

            strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"{0}\" style = \"z-index: {1};\" ",
              strLabelId, objLabelStyle.StyleZindex, objLabelStyle.Width, objLabelStyle.Height);
            strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" CssClass = \"NameLabel\">",
              objLabelStyle.Runat);
            strCodeForCs.AppendFormat("{0}</asp:Label>",
              strLabelText);
            strCodeForCs.Append("\r\n" + "</td>");

            intZIndex += 1;

            objGenCtlStyle.StyleZindex = intZIndex + 1;
            objGenCtlStyle.StyleLeft = (int)intCurrLeft + objLabelStyle.Width + 5;
            //objGenCtlStyle.StyleLeft = (int)intCurrLeft + 5;
            objGenCtlStyle.StyleTop = (int)intCurrTop;
            ///�����ұ߿ؼ��Ĵ���;
            strCodeForCs.Append("\r\n" + "<td>");

            strCodeForCs.AppendFormat("\r\n" + "<asp:{0} id = \"{1}\" style = \"z-index: {2}; \" ",
              strCtlTypeName, strCtlId, objGenCtlStyle.StyleZindex, objGenCtlStyle.Width, objGenCtlStyle.Height);

            strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" CssClass = \"TextBox_Defa\">",
              objGenCtlStyle.Runat);
            strCodeForCs.AppendFormat("\r\n" + "</asp:{0}>",
              strCtlTypeName);
            strCodeForCs.Append("\r\n" + "</td>");

            intZIndex += 1;
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ����Button�ؼ�
        /// </summary>
        /// <param name = "objCheckStyle"></param>
        /// <returns></returns>
        public string GenButtonNoPosition(clsButtonStyleEN objButtonStyle, string strButtonId, string strButtonText, string strOnClick)
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
                ///
                //���ɿؼ���<��ʼ��־>��<ID>
                strCodeForCs.AppendFormat("\r\n" + "<asp:Button id = \"{0}\" ",
                  strButtonId);
                //����<�ؼ���ʽStyle>
                //����<�߶�>��<���>
                strCodeForCs.AppendFormat("\r\n" + "style = \"z-index: {0}; Width:{2}px; Height:{3}px;\" ",
                  objButtonStyle.StyleZindex, objButtonStyle.StyleLeft,
                  objButtonStyle.Width, objButtonStyle.Height);

                //��������ģʽ�Ƿ��ڷ���������
                strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" ",
                  objButtonStyle.Runat);

                //����<�ֺ�>��<����>
                //				strCodeForCs.AppendFormat("\r\n" + "Font-Size = \"{0}\" Font-Names = \"{1}\" ", 
                //					objButtonStyle.FontSize, objButtonStyle.FontName);
                //����<��ʾ�ı�> 
                strCodeForCs.AppendFormat("\r\n" + "Text = \"{0}\" CssClass = \"btn btn-primary btn-sm\" ", strButtonText);
                //���ɵ����¼�
                strCodeForCs.AppendFormat("\r\n" + "OnClick = \"{0}\" ", strOnClick);

                //����<������־>
                strCodeForCs.Append("\r\n" + "></asp:Button>");

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
        /// �������ڱ༭�Ĳ�Div,�ò���Ա�����
        /// </summary>
        /// <param name="objvFunction4GeneCodeEN"></param>
        /// <returns></returns>
        public string Gen_List_Template_DefDiv4ListRegion()
        {
            clsViewRegionENEx objViewRegionEx = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.ListRegion_0002);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + "<template>");
            strCodeForCs.Append("\r\n" + $"<div>");
            strCodeForCs.Append("\r\n" + $"<span v-if=\"emptyRecNumInfo !== '' && items.length === 0\">{{ emptyRecNumInfo }}</span>");
            strCodeForCs.Append("\r\n" + $"<template v-else>");
            strCodeForCs.Append("\r\n" + Gen_List_Table_All());
            strCodeForCs.Append("\r\n" + " </template>");

            strCodeForCs.Append("\r\n" + "</div>");


            strCodeForCs.Append("\r\n" + " </template>");

            return strCodeForCs.ToString();
        }



        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(Vue_ViewScript_List_TS4Html);
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
            string strClassName = string.Format("{0}_List", objViewInfoENEx.TabName);
            clsViewRegionENEx objViewRegionENEx = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.ListRegion_0002);
            if (objViewRegionENEx != null && string.IsNullOrEmpty(objViewRegionENEx.ClsName) == false)
            {
                strClassName = objViewRegionENEx.ClsName;
            }
            this.ClsName = strClassName;
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
        public string Gen_WebView_Vue_Code4FeatureRegion()
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp ;     ///��ʱ����;
            strCodeForCs.Append("\r\n" + "<!-- ������ -->");
            strCodeForCs.Append("\r\n" + GenFeatureRegion(objViewInfoENEx.objViewRegion_List, objViewInfoENEx));

            return strCodeForCs.ToString();
        }
        public string Gen_WebView_Vue_Code4ListRegion()
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp ;     ///��ʱ����;
            strCodeForCs.Append("\r\n" + "<!-- �б�� -->");
            strCodeForCs.Append("\r\n" + "<div id = \"divList\" class = \"div_List\">");

            strCodeForCs.Append("\r\n" + "<div id = \"divDataLst\" class = \"div_List\">");

            strCodeForCs.Append("\r\n" + "</div>");
            strCodeForCs.Append("\r\n" + "<div id = \"divPager\" class = \"pager\" value=\"1\">");
            strCodeForCs.Append("\r\n" + "@Html.Partial(\"~/Pages/PubWebClass/pager.cshtml\")");
            strCodeForCs.Append("\r\n" + "</div>");
            strCodeForCs.Append("\r\n" + "</div>");
            return strCodeForCs.ToString();
        }




        public string Gen_WApi_Ts_BindTab4Func(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (this.IsUseFunc == false) return "";

            IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFlds_GridRegion = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.RegionId == objViewInfoENEx.objViewRegion_Feature.RegionId);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.AppendFormat("\r\n /** ��ʾ{0}�������������ֵ", TabName_Out4ListRegion4GC);
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @param divContainer:��ʾ����");
            strCodeForCs.AppendFormat("\r\n * @param arr{0}ExObjLst:��Ҫ�󶨵Ķ����б�",
                ViewMainTabName4GC);
            strCodeForCs.Append("\r\n" + " **/");

            strCodeForCs.AppendFormat("\r\n" + "public async BindTab_{0}4Func(divContainer: HTMLDivElement, arr{0}ExObjLst: Array<cls{0}ENEx>) ",
                TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.BindTab_{0}4Func.name;", TabName_Out4ListRegion4GC);


            strCodeForCs.Append("\r\n" + "if (divContainer == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(Format(\"{0}������!\",divContainer));");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + $"const divDataLst = GetDivObjInDivObj(divContainer, 'divDataLst');");
            AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetDivObjInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

            //strCodeForCs.Append("\r\n" + "const sstrFldName: Array <string> = new Array<string>();");
            //strCodeForCs.Append("\r\n" + "const sstrColHeader: Array <string> = new Array<string>();");
            //strCodeForCs.Append("\r\n" + "sstrFldName.push(\"IdentityID\"); sstrColHeader.push(\"���Id\");");
            strCodeForCs.Append("\r\n" + "const arrDataColumn: Array <clsDataColumn> =");
            strCodeForCs.Append("\r\n" + "       [");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "fldName: \"\",");
            strCodeForCs.Append("\r\n" + "sortBy: \"\",");
            strCodeForCs.Append("\r\n" + "sortFun: SortFun,");
            strCodeForCs.Append("\r\n" + "getDataSource: \"\",");
            strCodeForCs.Append("\r\n" + "colHeader: \"\",");
            strCodeForCs.Append("\r\n" + "text: \"\",");
            strCodeForCs.Append("\r\n" + "tdClass: \"text-left\",");
            strCodeForCs.Append("\r\n" + "columnType: \"CheckBox\",");
            strCodeForCs.Append("\r\n" + "orderNum: 1,");
            strCodeForCs.Append("\r\n" + "funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}");
            strCodeForCs.Append("\r\n" + "},");
            var arrDGRegionFlds = objViewInfoENEx.arrDGRegionFldSet.OrderBy(x => x.SeqNum);
            foreach (clsDGRegionFldsENEx objDGRegionFldsENEx in arrDGRegionFlds)
            {
                if (objDGRegionFldsENEx.ObjFieldTabENEx == null) continue;
                string strFldName4Bind = objDGRegionFldsENEx.PropertyName(this.IsFstLcase);
                if (objDGRegionFldsENEx.IsUseFunc())
                {
                    strFldName4Bind = objDGRegionFldsENEx.DataPropertyName_FstLcase(this.IsFstLcase);
                }
                string strSortBy = objDGRegionFldsENEx.SortExpression_FstLcase(this.IsFstLcase);

                if (string.IsNullOrEmpty(objDGRegionFldsENEx.SortExpression) == true)
                {
                    if (string.IsNullOrEmpty(objDGRegionFldsENEx.DataPropertyName()) == false)
                    {
                        strSortBy = objDGRegionFldsENEx.DataPropertyName_FstLcase(this.IsFstLcase);
                    }
                    else
                    {
                        var objFieldTab = clsFieldTabBL.GetObjByFldIdCache(objDGRegionFldsENEx.FldId, objViewInfoENEx.PrjId);
                        if (objFieldTab != null)
                        {
                            strSortBy = objFieldTab.PropertyName(this.IsFstLcase);
                        }
                    }
                }

                strCodeForCs.Append("\r\n" + "{");
                var objPrjTabFld = clsPrjTabFldBLEx.GetObjByTabIdAndFldIdCache(objDGRegionFldsENEx.ObjPrjTab().TabId, objDGRegionFldsENEx.FldId, objViewInfoENEx.PrjId);
                if (string.IsNullOrEmpty(objDGRegionFldsENEx.DataPropertyName()) == false)
                {
                    strCodeForCs.AppendFormat("\r\n" + "fldName: cls{0}ENEx.con_{1},", TabName_Out4ListRegion4GC, objDGRegionFldsENEx.DataPropertyName4GC());
                }
                else if (objPrjTabFld != null && objPrjTabFld.IsForExtendClass)
                {
                    strCodeForCs.AppendFormat("\r\n" + "fldName: cls{0}ENEx.con_{1},", TabName_Out4ListRegion4GC, objDGRegionFldsENEx.FldName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "fldName: cls{0}EN.con_{1},", TabName_Out4ListRegion4GC, objDGRegionFldsENEx.FldName);
                }
                if (string.IsNullOrEmpty(objDGRegionFldsENEx.SortExpression) == false)
                {
                    strCodeForCs.AppendFormat("\r\n" + "sortBy: \"{0}\",", objDGRegionFldsENEx.SortExpression_FstLcase(this.IsFstLcase));
                }
                else if (objPrjTabFld != null && objPrjTabFld.IsForExtendClass)
                {
                    strCodeForCs.AppendFormat("\r\n" + "sortBy: cls{0}ENEx.con_{1},", TabName_Out4ListRegion4GC, objDGRegionFldsENEx.FldName);
                }
                else
                {
                    if (string.IsNullOrEmpty(objDGRegionFldsENEx.DataPropertyName()) == false)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "sortBy: cls{0}ENEx.con_{1},", TabName_Out4ListRegion4GC, objDGRegionFldsENEx.DataPropertyName4GC());
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "sortBy: cls{0}EN.con_{1},", TabName_Out4ListRegion4GC, objDGRegionFldsENEx.FldName);
                    }
                }
                strCodeForCs.Append("\r\n" + "sortFun: SortFun,");
                strCodeForCs.Append("\r\n" + "getDataSource: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"{0}\",", objDGRegionFldsENEx.HeaderText);
                strCodeForCs.Append("\r\n" + "text: \"\",");
                strCodeForCs.Append("\r\n" + "tdClass: \"text-left\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Label\",");
                strCodeForCs.AppendFormat("\r\n" + "orderNum: {0},", objDGRegionFldsENEx.SeqNum + 1);
                strCodeForCs.Append("\r\n" + "funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}");
                strCodeForCs.Append("\r\n" + "},");
                //strCodeForCs.AppendFormat("\r\n" + "sstrFldName.push(\"{0}\"); sstrColHeader.push(\"{1}\");",
                //    objDGRegionFldsENEx.FldName,
                //    objDGRegionFldsENEx.ColCaption);
            }
            if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.UpdateRecord_Gv_0174).Count() > 0)  //��DG���Ƿ����޸İ�ť
            {

                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "fldName: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "sortBy: \"\",");
                strCodeForCs.Append("\r\n" + "sortFun: SortFun,");
                strCodeForCs.Append("\r\n" + "getDataSource: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"�޸�\",");
                strCodeForCs.Append("\r\n" + "text: \"�޸�\",");
                strCodeForCs.Append("\r\n" + "tdClass: \"text-left\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Button\",");
                strCodeForCs.Append("\r\n" + "orderNum: 1,");
                strCodeForCs.Append("\r\n" + "funcName: (strKeyId: string, strText: string) => { ");
                strCodeForCs.Append("\r\n" + "const btn1: HTMLElement = document.createElement(\"button\");");
                strCodeForCs.Append("\r\n" + "btn1.innerText = strText;");
                strCodeForCs.Append("\r\n" + "btn1.className = \"btn btn-outline-info btn-sm\";");

                strCodeForCs.Append("\r\n" + "btn1.onclick = function() {");
                strCodeForCs.Append("\r\n" + $"{ThisClsName}.vuebtn_Click('UpdateRecordInTab', strKeyId);");
                strCodeForCs.Append("\r\n" + "};");
                strCodeForCs.Append("\r\n" + "return btn1;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "},");
            }
            if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.DelRecord_Gv_0175).Count() > 0)
            {
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "fldName: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "sortBy: \"\",");
                strCodeForCs.Append("\r\n" + "sortFun: SortFun,");
                strCodeForCs.Append("\r\n" + "getDataSource: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"ɾ��\",");
                strCodeForCs.Append("\r\n" + "text: \"ɾ��\",");
                strCodeForCs.Append("\r\n" + "tdClass: \"text-left\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Button\",");
                strCodeForCs.Append("\r\n" + "orderNum: 1,");
                strCodeForCs.Append("\r\n" + "funcName: (strKeyId: string, strText: string) => { ");
                strCodeForCs.Append("\r\n" + "const btn1: HTMLElement = document.createElement(\"button\");");
                strCodeForCs.Append("\r\n" + "btn1.innerText = strText;");
                strCodeForCs.Append("\r\n" + "btn1.className = \"btn btn-outline-info btn-sm\";");

                strCodeForCs.Append("\r\n" + "btn1.onclick = function() {");
                strCodeForCs.Append("\r\n" + $"{ThisClsName}.vuebtn_Click('DelRecordInTab', strKeyId);");
                strCodeForCs.Append("\r\n" + "};");

                strCodeForCs.Append("\r\n" + "return btn1;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "},");
            }
            if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.DetailRecord_Gv_0181).Count() > 0)
            {
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "fldName: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "sortBy: \"\",");
                strCodeForCs.Append("\r\n" + "sortFun: SortFun,");
                strCodeForCs.Append("\r\n" + "getDataSource: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"��ϸ��Ϣ\",");
                strCodeForCs.Append("\r\n" + "text: \"��ϸ��Ϣ\",");
                strCodeForCs.Append("\r\n" + "tdClass: \"text-left\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Button\",");
                strCodeForCs.Append("\r\n" + "orderNum: 1,");
                strCodeForCs.Append("\r\n" + "funcName: (strKeyId: string, strText: string) => { ");
                strCodeForCs.Append("\r\n" + "const btn1: HTMLElement = document.createElement(\"button\");");
                strCodeForCs.Append("\r\n" + "btn1.innerText = strText;");
                strCodeForCs.Append("\r\n" + "btn1.className = \"btn btn-outline-info btn-sm\";");

                strCodeForCs.Append("\r\n" + "btn1.onclick = function() {");
                strCodeForCs.Append("\r\n" + $"{ThisClsName}.vuebtn_Click('DetailRecordInTab', strKeyId);");
                strCodeForCs.Append("\r\n" + "};");

                strCodeForCs.Append("\r\n" + "return btn1;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "},");

            }
            if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.SelectRecord_Gv_0182).Count() > 0)
            {
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "fldName: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "sortBy: \"\",");
                strCodeForCs.Append("\r\n" + "sortFun: SortFun,");
                strCodeForCs.Append("\r\n" + "getDataSource: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"ѡ��\",");
                strCodeForCs.Append("\r\n" + "text: \"ѡ��\",");
                strCodeForCs.Append("\r\n" + "tdClass: \"text-left\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Button\",");
                strCodeForCs.Append("\r\n" + "orderNum: 1,");
                strCodeForCs.Append("\r\n" + "funcName: (strKeyId: string, strText: string) => { ");
                strCodeForCs.Append("\r\n" + "const btn1: HTMLElement = document.createElement(\"button\");");
                strCodeForCs.Append("\r\n" + "btn1.innerText = strText;");
                strCodeForCs.Append("\r\n" + "btn1.className = \"btn btn-outline-info btn-sm\";");

                strCodeForCs.Append("\r\n" + "btn1.onclick = function() {");
                strCodeForCs.Append("\r\n" + $"{ThisClsName}.vuebtn_Click('SelectRecordInTab', strKeyId);");
                strCodeForCs.Append("\r\n" + "};");

                strCodeForCs.Append("\r\n" + "return btn1;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "},");

            }
            strCodeForCs.Append("\r\n" + "];");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "await this.ExtendFldFuncMap(arr{0}ExObjLst, arrDataColumn);", TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `��չ�ֶ�ֵ��ӳ�����,${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");



            strCodeForCs.Append("\r\n" + $"if (this.objPager.IsInit(divContainer, this.divName4Pager) == false)");
            strCodeForCs.Append("\r\n" + $"this.objPager.InitShow(divContainer, this.divName4Pager);");
            strCodeForCs.Append("\r\n" + "this.objPager.recCount = this.recCount;");
            strCodeForCs.Append("\r\n" + "this.objPager.pageSize = this.pageSize;");
            strCodeForCs.Append("\r\n" + $"this.objPager.ShowPagerV2(divContainer, this, this.divName4Pager);");
            //strCodeForCs.Append("\r\n" + "$(\"#divPager\").load(\"../PubWebClass/pager.html\");");
            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }



        public string Gen_List_Table_Head_OneRow()
        {

            StringBuilder strCodeForCs = new StringBuilder();

            var arrDGRegionFlds = objViewInfoENEx.arrDGRegionFldSet.OrderBy(x => x.SeqNum);
            strCodeForCs.Append("\r\n" + $"<tr class=\"text-primary\">");
            strCodeForCs.Append("\r\n" + $"<th style = \"width: 30px\">");
            strCodeForCs.Append("\r\n" + $"<input v-model=\"selectAllChecked\" type=\"checkbox\" @change=\"selectAllRows\" />");
            strCodeForCs.Append("\r\n" + $"</th>");
            foreach (clsDGRegionFldsENEx objDGRegionFldsENEx in arrDGRegionFlds)
            {
                strCodeForCs.Append("\r\n" + Gen_List_tabHead_OneColumn(objDGRegionFldsENEx));
            }
            strCodeForCs.Append("\r\n" + $"</tr>");
            return strCodeForCs.ToString();
        }

        public string Gen_List_Table_Body_OneRow()
        {

            StringBuilder strCodeForCs = new StringBuilder();
            StringBuilder sbChkKeyLst = new StringBuilder();

            var arrDGRegionFlds = objViewInfoENEx.arrDGRegionFldSet.OrderBy(x => x.SeqNum);

            if (objPrjTabEx_ListRegion.arrKeyFldSet.Count > 1)
            {
                int intIndex = 0;
                foreach (var objInFor in objPrjTabEx_ListRegion.arrKeyFldSet)
                {
                    if (intIndex == 0)
                    {
                        sbChkKeyLst.Append($" item.{ objInFor.ObjFieldTab0().PropertyName_TS(this.IsFstLcase)}");
                    }
                    else
                    {
                        sbChkKeyLst.Append($" + item.{objInFor.ObjFieldTab0().PropertyName_TS(this.IsFstLcase)}");
                    }
                    intIndex++;
                }

            }
            else
            {
                int intIndex = 0;
                foreach (var objInFor in objPrjTabEx_ListRegion.arrKeyFldSet)
                {
                    if (intIndex == 0)
                    {
                        sbChkKeyLst.Append($" item.{objInFor.ObjFieldTab0().PropertyName_TS(this.IsFstLcase)}");
                    }
                    else
                    {
                        sbChkKeyLst.Append($" + item.{objInFor.ObjFieldTab0().PropertyName_TS(this.IsFstLcase)}");
                    }
                    intIndex++;
                }

            }

            strCodeForCs.Append("\r\n" + $"<tr v-for=\"(item, index) in items\" :key = \"index\" class=\"text-secondary\">");
            strCodeForCs.Append("\r\n" + $"<td>");
            strCodeForCs.Append("\r\n" + $"<input :id=\"'chk' + {sbChkKeyLst.ToString()}\"");
            strCodeForCs.Append("\r\n" + $"v-model=\"item.checked\"");
            strCodeForCs.Append("\r\n" + $"type=\"checkbox\"");
            strCodeForCs.Append("\r\n" + $"name=\"chkInTab\"");
            strCodeForCs.Append("\r\n" + $"class=\"CheckInTab\" ");
            strCodeForCs.Append("\r\n" + $" />");
            strCodeForCs.Append("\r\n" + $"</td>");
            foreach (clsDGRegionFldsENEx objDGRegionFldsENEx in arrDGRegionFlds)
            {
                strCodeForCs.Append("\r\n" + Gen_List_tabBody_OneColumn(objDGRegionFldsENEx));
            }
            strCodeForCs.Append("\r\n" + $"</tr>");
            return strCodeForCs.ToString();
        }

        public string Gen_List_tabHead_OneColumn(clsDGRegionFldsENEx objDGRegionFldsENEx)
        {
            if (objDGRegionFldsENEx.ObjFieldTabENEx == null) return "";
            string strFldName4Bind = objDGRegionFldsENEx.PropertyName(this.IsFstLcase);
            StringBuilder strCodeForCs = new StringBuilder();
            if (string.IsNullOrEmpty(objDGRegionFldsENEx.SortExpression) == true)
            {
                strCodeForCs.Append("\r\n" + $"<th>");
                strCodeForCs.Append("\r\n" + $"{objDGRegionFldsENEx.HeaderText}");
                strCodeForCs.Append("\r\n" + "</th>");
            }
            else
            {
                string strIsEx = "";
                if (string.IsNullOrEmpty(objDGRegionFldsENEx.OutFldId) == false)
                {
                    string strOutFldName = objDGRegionFldsENEx.OutFldName();
                    if (objDGRegionFldsENEx.SortExpression_FstLcase(this.IsFstLcase).IndexOf(strOutFldName, StringComparison.InvariantCultureIgnoreCase) > -1) strIsEx = "|Ex";
                }
                strCodeForCs.Append("\r\n" + $"<th @click = \"sortColumn('{objDGRegionFldsENEx.SortExpression_FstLcase(this.IsFstLcase)}{strIsEx}')\">");
                strCodeForCs.Append("\r\n" + $"{objDGRegionFldsENEx.HeaderText}");
                strCodeForCs.Append("\r\n" + $"<span>");
                strCodeForCs.Append("\r\n" + $"<i :class=\"sortColumnKey === '{objDGRegionFldsENEx.SortExpression_FstLcase(this.IsFstLcase)}{strIsEx}'? (sortDirection === 'Asc' ? 'arrow-up' : 'arrow-down'):'arrow-neutral'\"></i>");
                strCodeForCs.Append("\r\n" + "</span>");
                strCodeForCs.Append("\r\n" + "</th>");
            }
            return strCodeForCs.ToString();
        }

        public string Gen_List_tabBody_OneColumn(clsDGRegionFldsENEx objDGRegionFldsENEx)
        {
            if (objDGRegionFldsENEx.ObjFieldTabENEx == null) return "";
            string strFldName4Bind = objDGRegionFldsENEx.PropertyName(this.IsFstLcase);
            StringBuilder strCodeForCs = new StringBuilder();
            string strDataPropertyName = "";
            if (string.IsNullOrEmpty(objDGRegionFldsENEx.DataPropertyName()) == false)
            {
                strDataPropertyName = clsString.FstLcaseS(objDGRegionFldsENEx.DataPropertyName4GC());
            }
            else if (objDGRegionFldsENEx.ObjPrjTabFld() != null && objDGRegionFldsENEx.ObjPrjTabFld().IsForExtendClass)
            {
                strDataPropertyName = clsString.FstLcaseS(objDGRegionFldsENEx.FldName);
            }
            else
            {
                strDataPropertyName =clsString.FstLcaseS( objDGRegionFldsENEx.FldName);
            }

            strCodeForCs.Append("\r\n" + $"<td v-html=\"item.{strDataPropertyName}\"></td>");
            return strCodeForCs.ToString();
        }

        public string Gen_List_Table_All()
        {

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n" + $"<table>");
            strCodeForCs.Append("\r\n" + Gen_List_Table_Head_OneRow());
            strCodeForCs.Append("\r\n" + Gen_List_Table_Body_OneRow());
            strCodeForCs.Append("\r\n" + $"</table>");
            return strCodeForCs.ToString();
        }

        public string Gen_List_Style_DefDiv4ListRegion()
        {

            StringBuilder strCodeForCs = new StringBuilder();


            strCodeForCs.Append("\r\n" + "<style scoped>");
            strCodeForCs.Append("\r\n" + ".read-the-docs {");
            strCodeForCs.Append("\r\n" + "color: #888;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + ".arrow-neutral {");
            strCodeForCs.Append("\r\n" + "border: solid gray;");
                strCodeForCs.Append("\r\n" + "border-width: 0 2px 2px 0;");
            strCodeForCs.Append("\r\n" + "display: inline-block;");
            strCodeForCs.Append("\r\n" + "padding: 3px;");
            strCodeForCs.Append("\r\n" + "transform: rotate(45deg);");
                strCodeForCs.Append("\r\n" + "-webkit-transform: rotate(45deg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "/* ��ʽ�ɸ���ʵ��������е��� */");
            strCodeForCs.Append("\r\n" + ".arrow-up {");
            strCodeForCs.Append("\r\n" + "display: inline-block;");
            strCodeForCs.Append("\r\n" + "width: 0;");
            strCodeForCs.Append("\r\n" + "height: 0;");
            strCodeForCs.Append("\r\n" + "border-left: 5px solid transparent;");
            strCodeForCs.Append("\r\n" + "border-right: 5px solid transparent;");
            strCodeForCs.Append("\r\n" + "border-bottom: 5px solid #000; /* ��ͷ���ϣ��ɸ�����Ҫ������ɫ */");
            strCodeForCs.Append("\r\n" + "margin-left: 5px;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n");

           strCodeForCs.Append("\r\n" + ".arrow-down {");
            strCodeForCs.Append("\r\n" + "display: inline-block;");
            strCodeForCs.Append("\r\n" + "width: 0;");
            strCodeForCs.Append("\r\n" + "height: 0;");
            strCodeForCs.Append("\r\n" + "border-left: 5px solid transparent;");
            strCodeForCs.Append("\r\n" + "border-right: 5px solid transparent;");
            strCodeForCs.Append("\r\n" + "border-top: 5px solid #000; /* ��ͷ���£��ɸ�����Ҫ������ɫ */");
            strCodeForCs.Append("\r\n" + "margin-left: 5px;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n");

            strCodeForCs.Append("\r\n" + "th:not(:last-child) {");
            strCodeForCs.Append("\r\n" + "margin-right: 10px;");
            strCodeForCs.Append("\r\n" + "border-right: 1px solid #ccc;");
            strCodeForCs.Append("\r\n" + "background-color: rgba(0, 0, 255, 0.6);");
            strCodeForCs.Append("\r\n" + "color: white;");
            strCodeForCs.Append("\r\n" + "font-weight: bold;");
            strCodeForCs.Append("\r\n" + "padding: 2px; /* ����ڱ߾� */");


                strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n");

            strCodeForCs.Append("\r\n" + "th:last-child {");
            strCodeForCs.Append("\r\n" + "margin-right: 0; /* Reset margin for the last column */");
            strCodeForCs.Append("\r\n" + "border-right: none; /* Remove the border for the last column */");
            strCodeForCs.Append("\r\n" + "background-color: rgba(0, 0, 255, 0.6);");
            strCodeForCs.Append("\r\n" + "color: white;");
            strCodeForCs.Append("\r\n" + "font-weight: bold;");
            strCodeForCs.Append("\r\n" + "padding: 2px; /* ����ڱ߾� */");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n");

            strCodeForCs.Append("\r\n" + ".Bakth:not(:last-child) {");
            strCodeForCs.Append("\r\n" + "margin-right: 10px; /* Adjust the value to control the spacing */");
            strCodeForCs.Append("\r\n" + "border-right: 1px solid #ccc; /* Adjust the color and width as needed */");
            strCodeForCs.Append("\r\n" + "background-color: #333; /* Adjust the color as needed */");
            strCodeForCs.Append("\r\n" + "color: #fff; /* Adjust the text color as needed */");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n");

            strCodeForCs.Append("\r\n" + "td {");
            strCodeForCs.Append("\r\n" + "border-right: 1px solid #ccc; /* Adjust the color and width as needed */");
            strCodeForCs.Append("\r\n" + "padding: 2px; /* ����ڱ߾� */");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n");

            strCodeForCs.Append("\r\n" + "tr:nth-child(odd) {");
            strCodeForCs.Append("\r\n" + "background-color: #f2f2f2; /* Adjust the color as needed for odd rows */");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n");

            strCodeForCs.Append("\r\n" + "tr:nth-child(even) {");
            strCodeForCs.Append("\r\n" + "background-color: #ffffff; /* Adjust the color as needed for even rows */");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "/* ��ӱ��Ԫ��֮��Ŀ�϶ */");
            strCodeForCs.Append("\r\n" + "table {");
            strCodeForCs.Append("\r\n" + "border-collapse: separate; /* ʹ�� separate ģʽ������Ԫ��֮��Ŀ�϶ */");
            strCodeForCs.Append("\r\n" + "border-spacing: 2px; /* ���嵥Ԫ��֮��ļ�� */");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "</style>");

            return strCodeForCs.ToString();
        }


        public string Gen_List_Script_DefDiv4ListRegion()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            //���ɱ༭������� == == == == == == == == == == == == == == 
            try
            {
                strCodeForCs.Append("\r\n" + "<script lang=\"ts\">");
                strCodeForCs.Append("\r\n" + "import { defineComponent, ref } from \"vue\";");
                strCodeForCs.Append("\r\n" + "import 'jquery/dist/jquery.min.js';");
                strCodeForCs.Append("\r\n" + "import 'bootstrap/dist/js/bootstrap.min.js';");
                strCodeForCs.Append("\r\n" + "import 'bootstrap/dist/css/bootstrap.css';");
                strCodeForCs.Append("\r\n" + "//import router from '@/router';");
                //strCodeForCs.Append("\r\n" + "import { Format } from \"@/ts/PubFun/clsString\"");

                //strCodeForCs.Append("\r\n" + $"import {{ cls{this.TabName_Out4ListRegion}EN }} from \"@/ts/L0Entity/{objFuncModule_Gc.FuncModuleEnName4GC()}/cls{this.TabName_Out4ListRegion}EN\";");

                strCodeForCs.Append("\r\n" + "  export  default defineComponent({");
                strCodeForCs.Append("\r\n" + $"name: '{clsString.FirstUcaseS(ThisClsName.Replace("_",""))}',");

                strCodeForCs.Append("\r\n" + "        components: {");
                strCodeForCs.Append("\r\n" + "            // ���ע��");
                //strCodeForCs.AppendFormat("\r\n" + "{0}", objViewRegion_Edit.ClsName);
                strCodeForCs.Append("\r\n" + "        },");
                strCodeForCs.Append("\r\n" + Gen_List_Prop_Define());
                strCodeForCs.Append("\r\n" + Gen_List_Emits_Define());
                strCodeForCs.Append("\r\n" + Gen_List_Setup_Define());

                strCodeForCs.Append("\r\n" + Gen_List_watch_Define());


                strCodeForCs.Append("\r\n" + Gen_List_methods_Define());


                strCodeForCs.Append("\r\n" + "});");
                strCodeForCs.Append("\r\n" + "</script>");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_List_Setup_Fun_btnClickInRow()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  * �ύ�༭");
            strCodeForCs.AppendFormat("\r\n *({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "const btnClickInRow = (item: any) => {");
            // console.log(item);
            // alert(item.tabId);
            //strCodeForCs.Append("\r\n" + "clsPrivateSessionStorage.tabId = item.tabId;");
            strCodeForCs.Append("\r\n" + "emit('on-edit-tab-relainfo', {");
            strCodeForCs.Append("\r\n" + "tabId: item.tabId,");
            strCodeForCs.Append("\r\n" + "content: '���ǵ�ǰ��Ĺؼ���',");
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "};");
            return strCodeForCs.ToString();
        }

        public string Gen_List_Setup_Fun_sortColumn()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  * �ύ�༭");
            strCodeForCs.AppendFormat("\r\n *({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");

            strCodeForCs.Append("\r\n" + "    const sortColumn = (columnKey: string) => {");
            strCodeForCs.Append("\r\n" + "if (sortColumnKey.value === columnKey)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "// ���������ǵ�ǰ�����У����л�������");
            strCodeForCs.Append("\r\n" + "sortDirection.value = sortDirection.value === 'Asc' ? 'Desc' : 'Asc';");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "// ���������������У��������µ������к�������");
            strCodeForCs.Append("\r\n" + "sortColumnKey.value = columnKey;");
            strCodeForCs.Append("\r\n" + "sortDirection.value = 'Asc';");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "emit('on-sort-column', {");
            strCodeForCs.Append("\r\n" + "sortColumnKey: sortColumnKey.value,");
            strCodeForCs.Append("\r\n" + "sortDirection: sortDirection.value,");
            strCodeForCs.Append("\r\n" + "content: '���ǵ�ǰ�б����ͷ����',");
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "};");

            return strCodeForCs.ToString();
        }

        public string Gen_List_Setup_Fun_selectAllRows()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            // �����ѡ����ͷ�����ķ����������޸����м�¼��ѡ��״̬
            strCodeForCs.Append("\r\n" + "const selectAllRows = () => {");
            // selectAllChecked.value = !selectAllChecked.value;
            strCodeForCs.Append("\r\n" + "console.error(selectAllChecked.value);");
            strCodeForCs.Append("\r\n" + "};");
            return strCodeForCs.ToString();
        }

    }
}
