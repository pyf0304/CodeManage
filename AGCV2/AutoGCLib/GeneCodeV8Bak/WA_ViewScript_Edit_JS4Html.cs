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
using AGC.PureClass;
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
    partial class WA_ViewScript_Edit_JS4Html : clsGeneCodeBase
    {
        private string strJSPath = "";
        clsBiDimDistribute objBiDimDistribue4Qry = null;
        #region ���캯��
        public WA_ViewScript_Edit_JS4Html()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            InitPageSetup();
        }
        public WA_ViewScript_Edit_JS4Html(string strViewId)
       : base("", strViewId, "", "")
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
        }
        public WA_ViewScript_Edit_JS4Html(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
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
            intZIndex = 100;        ///�ؼ��������
            intCurrLeft = 10;  ///�ؼ�����߿�;
            intCurrTop = 10;
        }

        #endregion


        public string Gen_WApi_JS_AddDPV_Pager(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  ��̬��ӷ�ҳ����");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.Append("\r\n" + "function AddDPV_Pager(divName4Pager) {");
            strCodeForCs.AppendFormat("\r\n" + "   require([\"{2}/{0}Ex.js\"], function({1}) {{",
                    objViewInfoENEx.ClsName, 
                    objViewInfoENEx.TabName.ToLower(), 
                    strJSPath);
            strCodeForCs.AppendFormat("\r\n" + "{0}.{1}Ex.AddDPV_Pager(divName4Pager);", 
                objViewInfoENEx.TabName.ToLower(), 
                objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
                  
     
        public string Gen_WApi_JS_Page_Load(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  ҳ�浼��-�ڵ���ҳ������еĺ���");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");

            strCodeForCs.Append("\r\n" + "window.onload = function() {");

            strCodeForCs.AppendFormat("\r\n" + "   require([\"{2}/{0}Ex.js\"], function({1}) {{",
       objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower(), strJSPath);
            strCodeForCs.AppendFormat("\r\n" + "const objPage = new {1}.{0}Ex();", objViewInfoENEx.ClsName, objViewInfoENEx.TabName.ToLower());
            if (PrjTabEx_ListRegion.IsUseCache_TS())
            {
                strCodeForCs.AppendFormat("\r\n" + "objPage.PageLoadCache();",
                 objViewInfoENEx.TabName, objViewInfoENEx.TabName_Out, objViewInfoENEx.TabName.ToLower());
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "objPage.Page_Load();",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName_Out, objViewInfoENEx.TabName.ToLower());
            }
            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_JS_ShowDialog(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  ��ʾ�Ի���");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "function ShowDialog_{0}(pstrOp) {{", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + "   strOp = pstrOp;");
            strCodeForCs.Append("\r\n" + "   require(['jquery', 'bootstrap'], function($) {");
            strCodeForCs.Append("\r\n" + "       if (strOp === \"Add\" || strOp === \"AddWithMaxId\") {");

            strCodeForCs.AppendFormat("\r\n" + "//{0}Ex.GetMaxStrId('#txt{1}');",
                    objViewInfoENEx.ClsName, objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "        }");
            strCodeForCs.Append("\r\n" + "else if (strOp === \"Update\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "            $('#lblDialogTitle_{0}').html('�޸ļ�¼');", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strOp === \"Detail\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "            $('#btnSubmit{0}').hide();", objViewInfoENEx.TabName_In);

            strCodeForCs.AppendFormat("\r\n" + "            $('#lblDialogTitle_{0}').html('��ϸ��Ϣ');", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "        $('#divEditDialog_{0}').modal('show');", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + "  });");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_JS_HideDialog(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  ���ضԻ���");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "function HideDialog_{0}() {{", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + "  require(['jquery', 'bootstrap'], function($) {");
            strCodeForCs.AppendFormat("\r\n" + "      $('#divEditDialog_{0}').modal('hide');", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + "  });");
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
                                case enumDataTypeAbbr.Array_31:
                                    strCodeForCs.AppendFormat("\r\n" + "const {1}:{0} = $('#txt{1}{2}').val();",
                                        objDataTypeAbbrEN.TypeScriptType,
                                        objFuncPara4CodeEN.ParaName,
                                        objvFunction4GeneCodeEN.OrderNum);
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

        private string GetCode4FieldInPutDataToClass(clsEditRegionFldsENEx objEditRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder sbCodeForCs = new StringBuilder();
            if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }

            sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = $(\"#{2}\").val();",
            objViewInfoENEx.TabName,
            objEditRegionFldsEx.FldName,
            objEditRegionFldsEx.CtrlId);
            sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

            return sbCodeForCs.ToString();
        }
        
        private string GetCode4FieldInGetDataFromClass(clsEditRegionFldsENEx objEditRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {

            StringBuilder sbCodeForCs = new StringBuilder();


            if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }

            sbCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").val(pobj{1}EN.{2});",
                        objEditRegionFldsEx.CtrlId,
                        objViewInfoENEx.TabName,
                        objEditRegionFldsEx.FldName);
            sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

            return sbCodeForCs.ToString();
        }
    

        /// <summary>
        /// ����:����Ĳ�ѯ���޸ġ����롢ɾ��
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            string strFuncName = "";
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


            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
  clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objViewInfoENEx.FunctionTemplateId,
  objViewInfoENEx.LangType, objViewInfoENEx.CodeTypeId, objViewInfoENEx.SqlDsTypeId);

            objViewInfoENEx.WebFormName = string.Format("{0}", objViewInfoENEx.ClsName);
            objViewInfoENEx.WebFormFName = string.Format("{0}{1}.html",
                objViewInfoENEx.FolderName, objViewInfoENEx.ClsName);
            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;
 

            strRe_ClsName = objViewInfoENEx.WebFormName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName4GC(), objViewInfoENEx.WebFormFName);

            try
            {
       
                if (objViewInfoENEx.ApplicationTypeId2 == "04")
                {
                    strCodeForCs.AppendFormat("\r\n" + "<%@ Page language = \"c#\" AutoEventWireup = \"true\"  %>",
                       objViewInfoENEx.WebFormName, objViewInfoENEx.NameSpace, objViewInfoENEx.WebFormName);
                    strCodeForCs.Append("\r\n" + "<!DOCTYPE html>");
                    strCodeForCs.Append("\r\n" + "<html xmlns = \"http://www.w3.org/1999/xhtml\">");
                    strCodeForCs.Append("\r\n" + "<head runat = \"server\">");
                    strCodeForCs.Append("\r\n" + "<meta http-equiv = \"Content-Type\" content = \"text/html; charset = utf-8\" />");
                    strCodeForCs.AppendFormat("\r\n" + "<title>{0}��ά��</title>", objViewInfoENEx.ViewCnName);
                    strCodeForCs.AppendFormat("\r\n" + "<link rel = \"stylesheet\" type = \"text/css\" href = \"../../css/tz_base1.css\"/>",
                        objViewInfoENEx.NameSpace);
                    strCodeForCs.Append("\r\n" + "     <link href=\"../../Content/bootstrap.css\" rel=\"stylesheet\" />");
                    strCodeForCs.Append("\r\n" + "     <link href=\"../../Content/bootstrap.min.css\" rel=\"stylesheet\" />");
                    strCodeForCs.Append("\r\n" + "<link href=\"../../Css/PagerCss.less\" type = \"text/css\" rel = \"stylesheet/less\" />");
                    strCodeForCs.Append("\r\n" + "<script src = \"../../scripts/less-1.5.1.min.js\" ></script >");
                    strCodeForCs.Append("\r\n" + "<script type = \"text/javascript\" data-main = \"reqconfig.js\" src = \"../../Scripts/require.js\" ></script>");

                }
                else
                {
                    strCodeForCs.Append("\r\n" + "<!DOCTYPE html>");
                    strCodeForCs.Append("\r\n" + "<html>");
                    strCodeForCs.Append("\r\n" + "<head>");
                    strCodeForCs.Append("\r\n" + "<meta charset = \"utf-8\" />");
                    strCodeForCs.AppendFormat("\r\n" + "<title>{0} </title>", objViewInfoENEx.ViewCnName);
                    strCodeForCs.Append("\r\n" + "    <link href=\"../../Content/bootstrap.css\" rel=\"stylesheet\" />");
                    strCodeForCs.Append("\r\n" + "    <link href=\"../../Css/site.css\" rel=\"stylesheet\" />");
                    strCodeForCs.Append("\r\n" + "    <script src=\"../../scripts/jquery-3.4.1.min.js\"></script>");
                    strCodeForCs.Append("\r\n" + "<script data-main=\"../../js/src/config\" src=\"../../scripts/require.js\"></script>");
                }
      
                strCodeForCs.Append("\r\n" + "<script type=\"text/javascript\">");

                strJSPath = string.Format(".", objFuncModule.FuncModuleEnName4GC());

                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_JS =
                    clsvFunction4GeneCodeBLEx.GetObjLstByViewInfoEx_JS(objViewInfoENEx);

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst_JS)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;

                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);

                    if (string.IsNullOrEmpty(strTemp) == false)
                    {
                        strCodeForCs.Append("\r\n" + strTemp);
                    }
                }


                strCodeForCs.Append("\r\n" + "    </script>");

                strCodeForCs.Append("\r\n" + "</head>");
                
                strCodeForCs.Append("\r\n" + "<body>");
                         

                //���ɱ༭�������-------------------------------
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd
                  || objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                {
                    strCodeForCs.Append("\r\n" + "<!-- �༭�� -->");
                    strCodeForCs.Append("\r\n" + Gen_WApi_Cs4Ts_DefDiv4EditRegion());

                }
                //���ɱ༭������� == == == == == == == == == == == == == == 

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
                //< li class="nav-item">

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
                    //strCodeForCs.AppendFormat("\r\n" + "<div style = \"position: relative; width: 648px; height: 37px; left: 0px; top: 0px;\">");
                    //strCodeForCs.AppendFormat("\r\n" + "<asp:Label ID = \"lblViewTitle\" runat = \"server\" CssClass = \"h5\" >{0}",
                    //  strTitle);
                    //strCodeForCs.AppendFormat("\r\n" + "</asp:Label>");
                    ////����в�ѯ����
                    //if (objViewInfoENEx.objViewTypeCodeTab.IsHaveQuery)
                    //{
                    //    strCodeForCs.AppendFormat("\r\n" + "<asp:Label ID = \"lblMsg_List\" runat = \"server\" CssClass = \"text-warning\"  Style = \"z-index: 105;");
                    //    strCodeForCs.AppendFormat("\r\n" + "left: 54px; position: relative; top: 4px\" Width = \"347px\"></asp:Label>");
                    //}
                    //strCodeForCs.AppendFormat("\r\n" + "	</div>");
                    break;
            }

            intZIndex += 1;
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// ���ɲ�ѯ������ش���
        /// </summary>
        /// <returns></returns>
        public string GenQryRegionCode4Table()
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

            strCodeForCs.AppendFormat("\r\n" + "<div id = \"divQuery\" class = \"div_query\"> ",
              objViewInfoENEx.TabName, intDivHeight);


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
            //foreach(ASPControlGroupEx objInFor in arrControlGroups)
            //{

            //}
            ASPHtmlTableEx objTable = clsASPHtmlTableBLEx.PackageByTable4QueryRegion(arrControlGroups, objViewInfoENEx.objViewRegion_Query.ColNum ?? 0);
            objTable.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);


            strCodeForCs.Append("\r\n" + "</div>");

            intCurrTop += 40;
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
        public string Gen_WApi_Cs4Ts_DefDiv4EditRegion()
        {
            clsViewRegionENEx objViewRegionEx = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.EditRegion_0003);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.AppendFormat("\r\n" + " <div class=\"modal fade\" id=\"divEditDialog_{0}\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"lblDialogTitle_{0}\" aria-hidden=\"true\">", 
                objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + " <div class=\"modal-dialog modal-dialog-centered modal-dialog-scrollable\">");
            strCodeForCs.AppendFormat("\r\n" + " <div class=\"modal-content\" style=\"width: {0}px;\">", objViewRegionEx.Width +35);
            strCodeForCs.Append("\r\n" + " <div class=\"modal-header\">");
            strCodeForCs.AppendFormat("\r\n" + " <h4 class=\"modal-title\" id=\"lblDialogTitle_{0}\">ģ̬��Modal������</h4>", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + " <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-hidden=\"true\">&times;</button>");
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " <div class=\"modal-body\">");
            
            //ASPHtmlTableEx objTable = clsASPHtmlTableBLEx.GetObj4EditRegion(objViewInfoENEx.objMainPrjTab.TabName);

            Func<clsEditRegionFldsENEx, ASPControlGroupEx> GetControlGroup_Asp4PureHtml = obj => clsASPControlGroupBLEx.GetControlGroup_Asp(obj, objViewInfoENEx.PrjId, true);
            
            IEnumerable<ASPControlGroupEx> arrASPControlGroupObjLst
                = objViewInfoENEx.arrEditRegionFldSet4InUse
                .Where(x => x.IsLogUpdDateOrUpdUser(objViewInfoENEx.PrjId) == false)
                .Select(GetControlGroup_Asp4PureHtml);
    
            //��װTd
            //arrASPControlGroupObjLst = arrASPControlGroupObjLst.Select(clsASPControlGroupBLEx.PackageTr4Wuc);
            ASPHtmlTableEx objTable = clsASPHtmlTableBLEx.PackageByTable4EditRegion(arrASPControlGroupObjLst, objViewInfoENEx.objViewRegion_Edit.ColNum ?? 0);

            objTable.Width = objViewRegionEx.Width ?? 0;
            //foreach (ASPControlEx objInFor in arrASPControlGroupObjLst)
            //{
            //    objTable.arrSubAspControlLst2.Add(objInFor);
            //}
            objTable.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);
            //foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
            //{
            //    ///������ֶβ��Ǳ�ʶ�����;����ɿؼ�,����Ͳ�����;
            //    if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
            //      && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            //    {
            //        continue;
            //    }
            //    strCodeForCs.AppendFormat("\r\n" + "<tr>");
            //    //strCodeForCs.AppendFormat("\r\n" + "<td>");
            //    ///������֤�ؼ�����;
            //    switch (objEditRegionFldsEx.ObjFieldTabENEx.CsType())
            //    {
            //        case "bool":
            //            strCodeForCs.AppendFormat("\r\n" + "<td colspan='2'>");
            //            strCodeForCs.AppendFormat("\r\n" + "<asp:CheckBox id = \"chk{0}\" runat = \"server\" Text = \"{1}\" CssClass = \"Check_Defa\"></asp:CheckBox>",
            //              objEditRegionFldsEx.FldName,
            //              objEditRegionFldsEx.LabelCaption);
            //            strCodeForCs.AppendFormat("\r\n" + "</td>");
            //            //strCodeForCs.AppendFormat("\r\n" + "<td>");
            //            //strCodeForCs.AppendFormat("\r\n" + "</td>");
            //            break;
            //        case "int":
            //        case "short":
            //        case "long":
            //        case "DateTime":
            //        case "double":
            //        case "float":
            //            strCodeForCs.AppendFormat("\r\n" + "<td class = \"NameTD\">");
            //            strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"{0}\" runat = \"server\" CssClass = \"NameControl\">{1}</asp:Label>",
            //              "lbl" + objEditRegionFldsEx.FldName,
            //              objEditRegionFldsEx.LabelCaption);
            //            strCodeForCs.AppendFormat("\r\n" + "</td>");
            //            strCodeForCs.AppendFormat("\r\n" + "<td class = \"ValueTD\">");
            //            strCodeForCs.AppendFormat("\r\n" + "<asp:TextBox id = \"txt{0}\" runat = \"server\" CssClass = \"ValueControl\"></asp:TextBox>",
            //              objEditRegionFldsEx.FldName, 
            //              objEditRegionFldsEx.LabelCaption);
            //            strCodeForCs.AppendFormat("\r\n" + "</td>");
            //            break;
            //        default:
            //            strCodeForCs.AppendFormat("\r\n" + "<td class = \"NameTD\">");
            //            strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"{0}\" runat = \"server\" CssClass = \"NameControl\">{1}</asp:Label>",
            //              "lbl" + objEditRegionFldsEx.FldName,
            //              objEditRegionFldsEx.LabelCaption);
            //            strCodeForCs.AppendFormat("\r\n" + "</td>");
            //            strCodeForCs.AppendFormat("\r\n" + "<td class = \"ValueTD\">");
            //            strCodeForCs.AppendFormat("\r\n" + "<asp:{0} id = \"{1}\" runat = \"server\" CssClass = \"ValueControl\"></asp:{0}>",
            //              objEditRegionFldsEx.objCtlType.CtlTypeName,
            //                objEditRegionFldsEx.CtrlId, 
            //              objEditRegionFldsEx.LabelCaption);
            //            strCodeForCs.AppendFormat("\r\n" + "</td>");
            //            break;
            //    }
            //    //                strCodeForCs.AppendFormat("\r\n" + "</td>");
            //    strCodeForCs.AppendFormat("\r\n" + "<td></td>");
            //    strCodeForCs.AppendFormat("\r\n" + "</tr>");
            //    //intZIndex += 1;
            //    //intCurrTop += 25;

            //}         
            //strCodeForCs.Append("\r\n" + " </table>");

            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " <div class=\"modal-footer\">");
            strCodeForCs.AppendFormat("\r\n" + " <button  id=\"btnCancel{0}\" type=\"button\" class=\"btn btn-default\" data-dismiss=\"modal\">�ر�</button>", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + " <button  id=\"btnSubmit{0}\" type=\"button\" class=\"btn btn-primary\" onclick=\"Submit_{0}()\">���</button>", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " <!-- /.modal-content -->");
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " <!-- /.modal -->");
            strCodeForCs.Append("\r\n" + " </div>");

            return strCodeForCs.ToString();
        }
        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            string strFuncName = objvFunction4GeneCodeEN.FuncName;
            try
            {
                string strCode = "";
                Type t = typeof(WA_ViewScript_Edit_JS4Html);
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
            string strClassName = string.Format("WA_{0}_Edit", objViewInfoENEx.TabName);
            clsViewRegionENEx objViewRegionENEx = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.EditRegion_0003);
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
        public string Gen_WebView_WA_Code4FeatureRegion()
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp ;     ///��ʱ����;
            strCodeForCs.Append("\r\n" + "@*-- ������ --*@");
            strCodeForCs.Append("\r\n" + GenFeatureRegion(objViewInfoENEx.objViewRegion_List, objViewInfoENEx));

            return strCodeForCs.ToString();
        }
        public string Gen_WebView_WA_Code4ListRegion()
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp ;     ///��ʱ����;
            strCodeForCs.Append("\r\n" + "@*-- �б�� --*@");
            strCodeForCs.Append("\r\n" + "<div id = \"divList\" class = \"div_List\" >");

            strCodeForCs.Append("\r\n" + "<div id = \"divDataLst\" class = \"div_List\" >");

            strCodeForCs.Append("\r\n" + "</div>");
            strCodeForCs.Append("\r\n" + "<div id = \"divPager\" class = \"pager\" value=\"1\" >");
            strCodeForCs.Append("\r\n" + "@Html.Partial(\"~/Pages/PubWebClass/pager.cshtml\")");
            strCodeForCs.Append("\r\n" + "</div>");
            strCodeForCs.Append("\r\n" + "</div>");
            return strCodeForCs.ToString();
        }
        public string Gen_WebView_WA_Code4EditRegion()
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp ;     ///��ʱ����;
            strCodeForCs.Append("\r\n" + "@*-- �༭�� --*@");
            strCodeForCs.Append("\r\n" + Gen_WApi_Cs4Ts_DefDiv4EditRegion());

            return strCodeForCs.ToString();
        }
        public string Gen_WebView_WA_Code4QueryRegion()
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp ;     ///��ʱ����;
            strCodeForCs.Append("\r\n" + "@*-- ��ѯ�� --*@");

            strCodeForCs.Append("\r\n" + GenQryRegionCode4Table());
            return strCodeForCs.ToString();
        }
    }
}
