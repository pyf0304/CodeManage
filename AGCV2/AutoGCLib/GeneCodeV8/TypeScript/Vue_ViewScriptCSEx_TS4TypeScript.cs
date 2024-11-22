using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AgcCommBase;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commexception;
using com.taishsoft.common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
    partial class Vue_ViewScriptCSEx_TS4TypeScript : clsGeneCodeBase
    {
     

        //private string objPrjTabENEx = "";

        //clsBiDimDistribute objBiDimDistribue4Qry = null;




        public Vue_ViewScriptCSEx_TS4TypeScript()
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            this.arrImportClass = new List<ImportClass>();
        }
        public Vue_ViewScriptCSEx_TS4TypeScript(string strViewId)
       : base("", strViewId, "", "")
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            this.arrImportClass = new List<ImportClass>();
        }
        public Vue_ViewScriptCSEx_TS4TypeScript(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
        : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            this.arrImportClass = new List<ImportClass>();
        }

        public string Gen_Vue_Ts_DdlBind4QueryRegion()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///���ɽ��б���;


                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.objCtlType.CtlTypeName == "DropDownList")
                    {
                        if (objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType == "boolean")
                        {
                            //strCodeForCs.AppendFormat("\r\n" + "clsCommForWebForm.BindDdl_TrueAndFalse(ddl{0}_q);",
                            //            objQryRegionFldsEx.FldName);
                        }
                        else
                        {
                            //string strDS_DataValueField;
                            //string strDS_DataTextField;
                            string strDsTabName;
                            string strDS_TabCnName;
                            try
                            {
                                clsPrjTabEN objPrjTab = clsQryRegionFldsBLEx.Ds_PrjTab4Get(objQryRegionFldsEx);
                                strDsTabName = objPrjTab.TabName;
                                strDS_TabCnName = objPrjTab.TabCnName;
                            }
                            catch (Exception objException)
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("�����ɽ���{0}����:{1}ʱ,����������, ��ȡ����Դ��������:{2}.",
                                objViewInfoENEx.ViewName, "��ѯ����", objException.Message);
                                throw new Exception(sbMsg.ToString());
                            }
                            if (string.IsNullOrEmpty(strDsTabName) == true)
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("�����ɽ���{0}����:{1}ʱ,����������, ����Դ����Ϊ��,����!({2}).",
                                objViewInfoENEx.ViewName, "��ѯ����", clsStackTrace.GetCurrClassFunction());
                                throw new Exception(sbMsg.ToString());
                            }
                            //try
                            //{
                            //    strDS_DataValueField = clsQryRegionFldsBLEx.Ds_DataValueField4Get(objQryRegionFldsEx);
                            //}
                            //catch (Exception objException)
                            //{
                            //    StringBuilder sbMsg = new StringBuilder();
                            //    sbMsg.AppendFormat("�����ɽ���{0}����:{1}ʱ,����������, ��ȡ����Դֵ�ֶ���ʱ����:{2}.<br/>����Դ����Ϊ:{3}.",
                            //    objViewInfoENEx.ViewName, "��ѯ����", objException.Message, strDsTabName);
                            //    throw new Exception(sbMsg.ToString());
                            //}
                            //if (string.IsNullOrEmpty(strDS_DataValueField) == true)
                            //{
                            //    StringBuilder sbMsg = new StringBuilder();
                            //    sbMsg.AppendFormat("�����ɽ���{0}����:{1}ʱ,����������, ��ȡ����Դֵ�ֶ���ʱ����.<br/>����Դ����Ϊ:{2}.({3})",
                            //        objViewInfoENEx.ViewName, "��ѯ����", strDsTabName,
                            //        clsStackTrace.GetCurrClassFunction());
                            //    throw new Exception(sbMsg.ToString());
                            //}
                            //try
                            //{
                            //    strDS_DataTextField = clsQryRegionFldsBLEx.Ds_DataTextField4Get(objQryRegionFldsEx);
                            //}
                            //catch (Exception objException)
                            //{
                            //    StringBuilder sbMsg = new StringBuilder();
                            //    sbMsg.AppendFormat("�����ɽ���{0}����:{1}ʱ,����������, ��ȡ����Դ�ı��ֶ���ʱ����:{2}.<br/>����Դ����Ϊ:{3},ֵ�ֶ���Ϊ:{4}.",
                            //    objViewInfoENEx.ViewName, "��ѯ����", objException.Message, strDsTabName, strDS_DataValueField);
                            //    throw new Exception(sbMsg.ToString());
                            //}
                            //if (string.IsNullOrEmpty(strDS_DataTextField) == true)
                            //{
                            //    StringBuilder sbMsg = new StringBuilder();
                            //    sbMsg.AppendFormat("�����ɽ���{0}����:{1}ʱ,����������, ��ȡ����Դ�ı��ֶ���ʱ����.<br/>����Դ����Ϊ:{2},ֵ�ֶ���Ϊ:{3}.({4})",
                            //          objViewInfoENEx.ViewName, "��ѯ����", strDsTabName, strDS_DataValueField,
                            //          clsStackTrace.GetCurrClassFunction());
                            //    throw new Exception(sbMsg.ToString());
                            //}
                            //if (arrDdlKeyIdLst.Contains(strDS_DataValueField) == false)
                            //{
                            //    arrDdlKeyIdLst.Add(strDS_DataValueField);
                            //}
                            //else
                            //{
                            //    continue;
                            //}
                            switch (objQryRegionFldsEx.DdlItemsOptionId)
                            {
                                case "01": ///�б��;
                                    //									string strTemp2 ;
                                    string delimStr = " ,.:";
                                    char[] delimiter = delimStr.ToCharArray();
                                    //									string words = "one two,three:four.";
                                    string[] split = null;
                                    int iItemNums;
                                    int i;

                                    strCodeForCs.AppendFormat("\r\n /** ��������:ddl{0}�ĺ�����", objQryRegionFldsEx.FldName);
                                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                                    strCodeForCs.Append("\r\n" + " **/");

                                    strCodeForCs.AppendFormat("\r\n" + "public void BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL)",
                                        objQryRegionFldsEx.FldName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "ListItem li = new ListItem(\"��ѡ��...\",\"0\");");
                                    split = objQryRegionFldsEx.ItemsString.Split(delimiter);
                                    iItemNums = split.GetUpperBound(0);
                                    for (i = split.GetLowerBound(0); i <= iItemNums; i++)
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "objDDL.Items.Add(\"{0}\");", split[i]);
                                    }
                                    strCodeForCs.Append("\r\n" + "objDDL.Items.Insert(0, li);");
                                    strCodeForCs.Append("\r\n" + "objDDL.SelectedIndex = 0;");
                                    strCodeForCs.Append("\r\n" + "//Ϊ�������������ݵ�����,����������б�����ֱ����ӵ�");
                                    strCodeForCs.Append("\r\n ///objDDL.Items.Add(\"��\");");
                                    strCodeForCs.Append("\r\n ///objDDL.Items.Add(\"Ů\");");
                                    strCodeForCs.Append("\r\n" + "}");
                                    break;
                                case "02": ///�б�������Դ��;

                                    strCodeForCs.Append("\r\n" + "/**");
                                    strCodeForCs.AppendFormat("\r\n" + "* Ϊ�������ȡ����,�ӱ�:[{0}]�л�ȡ",
                                      strDsTabName);
                                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

                                    strCodeForCs.Append("\r\n" + "* returns:��ȡ�����ֶΡ������ֶ����е����м�¼��¼��DataTable");
                                    strCodeForCs.Append("\r\n" + " **/");
                                    //strCodeForCs.AppendFormat("\r\n" + "public static BindDdl_{1}(ddl{1}: string, strWhereCond:string=\"1=1\") {{",
                                    //  strDsTabName, strDS_DataValueField, strDS_DataTextField);
                                    //strCodeForCs.Append("\r\n" + "//let strWhereCond = \" 1 =1 \";");
                                    //strCodeForCs.AppendFormat("\r\n" + "const objDdl = document.getElementById(ddl{1});",
                                    //    strDsTabName, strDS_DataValueField, strDS_DataTextField);
                                    //strCodeForCs.Append("\r\n" + "if (objDdl == null)");
                                    //strCodeForCs.Append("\r\n" + "{");
                                    //strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"������{{0}} ������!\", ddl{1});",
                                    //    strDsTabName, strDS_DataValueField, strDS_DataTextField);
                                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                                    strCodeForCs.Append("\r\n" + "throw (strMsg);");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "return new Promise((resolve, reject) => {");

                                    strCodeForCs.Append("\r\n" + "try");
                                    strCodeForCs.Append("\r\n" + "{");

                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "catch (e)");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "const strMsg = Format(\"��������(��ѯ��)���ɹ�,{0}.\",e);");
                                    strCodeForCs.Append("\r\n" + "console.error(strMsg)");
                                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                                    strCodeForCs.Append("\r\n" + "}");

                                    strCodeForCs.Append("\r\n" + "}");


                                    break;
                                case "03": ///�б�������ԴSQL��;
                                    strCodeForCs.Append("\r\n" + "/**");
                                    strCodeForCs.AppendFormat("\r\n" + "*  Ϊ�������ȡ����,��Sql��:[{0}]�л�ȡ",
                                       objQryRegionFldsEx.DsSqlStr);
                                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

                                    strCodeForCs.Append("\r\n" + "* returns:��ȡ�Զ����Sql�������е����м�¼��¼��DataTable");
                                    strCodeForCs.Append("\r\n" + " **/");
                                    strCodeForCs.AppendFormat("\r\n" + "public System.Data.DataTable Get{0}(string strCondition)",
                                    objQryRegionFldsEx.FldName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "//��ȡĳѧԺ����רҵ��Ϣ");
                                    //strCodeForCs.Append("\r\n" + "clsSpecSQLforSql mySql = new 1clsSpecSQLforSql();");
                                    strCodeForCs.AppendFormat("\r\n clsSpecSQLforSql mySql = cls{0}BL.GetSpecSQLObj();", objViewInfoENEx.TabName);

                                    strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = mySql.GetDataTable({0});",
                                    objQryRegionFldsEx.DsSqlStr);
                                    strCodeForCs.Append("\r\n" + "return objDT;");
                                    strCodeForCs.Append("\r\n" + "}");

                                    strCodeForCs.Append("\r\n /** �󶨻���Web��������");
                                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                                    strCodeForCs.Append("\r\n * @param objDDL\">��Ҫ�󶨵�ǰ���������</param>");
                                    strCodeForCs.Append("\r\n" + " **/");

                                    strCodeForCs.AppendFormat("\r\n" + "public void BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL)",
                                    objQryRegionFldsEx.FldName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "//Ϊ����Դ�ڱ����������������");
                                    strCodeForCs.Append("\r\n" + "ListItem li = new ListItem(\"��ѡ��...\",\"0\");");
                                    strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = Get{0}();",
                                    objQryRegionFldsEx.FldName);
                                    //strCodeForCs.AppendFormat("\r\n" + "objDDL.DataValueField = cls{0}EN.con_{1};",
                                    //  strDsTabName, strDS_DataValueField);
                                    //strCodeForCs.AppendFormat("\r\n" + "objDDL.DataTextField = cls{0}EN.con_{1};",
                                    //  strDsTabName, strDS_DataTextField);
                                    strCodeForCs.Append("\r\n" + "objDDL.DataSource = objDT;");
                                    strCodeForCs.Append("\r\n" + "objDDL.DataBind();");
                                    strCodeForCs.Append("\r\n" + "objDDL.Items.Insert(0, li);");
                                    strCodeForCs.Append("\r\n" + "objDDL.SelectedIndex = 0;");
                                    strCodeForCs.Append("\r\n" + "}");
                                    break;
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

        public string Gen_Vue_Ts_SortColumn()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                string strFuncName_Temp = getBindGvFuncName();
                ///���ɽ��б���;
                strCodeForCs.Append("\r\n" + "public async SortColumn(sortColumnKey: string, sortDirection: string) {");
                strCodeForCs.Append("\r\n" + $"switch(sortColumnKey)");
                strCodeForCs.Append("\r\n" + "{");
                var arrDGRegionFlds = objViewInfoENEx.arrDGRegionFldSet.OrderBy(x => x.SeqNum);
                foreach (clsDGRegionFldsENEx objDGRegionFldsENEx in arrDGRegionFlds)
                {
                    if (string.IsNullOrEmpty(objDGRegionFldsENEx.OutFldId) == true) continue;
                    string strOutFldName =  objDGRegionFldsENEx.OutFldName();
                    strCodeForCs.Append("\r\n" + $"case \"{clsString.FirstLcaseS(strOutFldName)}|Ex\":");
                    string strRelaTabId = clsDnPathBLEx.GetLeftJoinTabIdByDnPathId(
                        objDGRegionFldsENEx.TabId(),
                        objDGRegionFldsENEx.DnPathId(),
                        objDGRegionFldsENEx.PrjId);
                    List<string> arrOnCondition = clsDnPathBLEx.GetOnConditionByDnPathId(
                                            objDGRegionFldsENEx.DnPathId(),
                                            objDGRegionFldsENEx.PrjId);
                    if (arrOnCondition != null && arrOnCondition.Count > 0 && strRelaTabId != "")
                    {
                        string strTabName = clsPrjTabBLEx.GetTabNameByTabIdCache(strRelaTabId, objDGRegionFldsENEx.PrjId);
                        string strOnCoditionLst = string.Join(",", arrOnCondition);
                        strCodeForCs.Append("\r\n" + $"viewVarSet.sort{objViewInfoENEx.TabName}By = `{strTabName}|{strOutFldName} ${{sortDirection}}|{strOnCoditionLst}`;");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + $"viewVarSet.sort{objViewInfoENEx.TabName}By = Format('{{0}} {{1}}', sortColumnKey, sortDirection);");
                    }
                    strCodeForCs.Append("\r\n" + "break;");
                }

                strCodeForCs.Append("\r\n" + "default:");
                strCodeForCs.Append("\r\n" + $"viewVarSet.sort{objViewInfoENEx.TabName}By = Format('{{0}} {{1}}', sortColumnKey, sortDirection);");
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + $"await {strFuncName_Temp}(this.thisDivList);");
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
        /// ����Appҳ���̨����
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            //���û���������;

            string strIsShare = "";
            if (objViewInfoENEx.IsShare) strIsShare = "Share";
            string strFuncName = "";
            string strTemp = ""; ///��ʱ����;
            StringBuilder strCodeForCs = new StringBuilder();  ///�������WebForm�Ĵ���;
            //			string strTemp ;     ///��ʱ����;
            clsPubFun4BLEx.CheckDgStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsPubFun4BLEx.CheckTitleStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.TitleStyleId);

            clsDataGridStyleEN objDGStyleEx = clsDataGridStyleBL.GetObjByDgStyleIdCache(objViewInfoENEx.objViewStyleEN.DgStyleId);
         

            objViewInfoENEx.WebFormName = ThisClsName;
            objViewInfoENEx.WebFormFName = string.Format("{0}.ts", ThisClsName);

            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;

            strRe_ClsName = objViewInfoENEx.WebFormName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);

            clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(objViewInfoENEx.CodeTypeId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName(objCodeType, objFuncModule, objViewInfoENEx, objViewInfoENEx.TabName);

            //strXmlFileName = strXmlFileName.ToLower();
            //objViewInfoENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;
            objFuncModuleEN = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);

            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objViewInfoENEx.PrjId); //
            try
            {
                //������ʼ
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate4WebApi(objViewInfoENEx.CurrUserName,
                    objViewInfoENEx, this.CmPrjId));
                
                //strCodeForCs.AppendFormat("\r\n" + "import $ from \"jquery\";");
                strCodeForCs.AppendFormat("\r\n" + "//import * as QQ from \"q\";");

                strCodeForCs.AppendFormat("\r\n" + "import {{ {0} }} from \"@/viewsBase/{1}/{0}\";",
                        this.BaseClsName, objFuncModule.FuncModuleEnName4GC());
                var strRefEditObj = "";
                var strRefDetailObj = "";
                if (IsHasEditRegion == true) strRefEditObj = $", ref{ThisEditClsName}";
                if (IsHasDetailRegion == true) strRefDetailObj = $", ref{ThisDetailClsName}";

                strCodeForCs.Append("\r\n" + $"import {{ viewVarSet,divVarSet {strRefEditObj} {strRefDetailObj} }} from \"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName4GC()}/{objViewInfoENEx.TabName}VueShare\";");
                strCodeForCs.Append("\r\n" + " import { Format }                from '@/ts/PubFun/clsString';");

                var objViewRegion_Edit = objViewInfoENEx.objViewRegion_Edit;
                if (IsHasEditRegion == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "import {{ {0}Ex }} from \"@/views/{1}/{0}Ex\";",
                        ThisEditClsName, objFuncModule.FuncModuleEnName4GC());
                }
                if (PrjTabEx_EditRegion != null && thisEditTabProp_TS.KeyFldCount > 1)
                {
                    strCodeForCs.Append("\r\n" + "import { GetCheckedKeyLstsInDivObj, GetFirstCheckedKeyLstInDivObj }   from \"@/ts/PubFun/clsCommFunc4Ctrl.js\";");
                    //strCodeForCs.AppendFormat("\r\n" + "import {{ {0}_SplitKeyLst }} from \"@/ts/L3ForWApi/{1}/cls{0}WApi\";",
                    //    TabName_In4Edit,
                    //    thisEditTabProp_TS.FuncModuleEnName4GC);

                }
                else
                {
                    if (PrjTabEx_View.SqlDsTypeId == enumSQLDSType.SqlTab_01)
                    {
                        strCodeForCs.Append("\r\n" + "import { GetCheckedKeyIdsInDivObj, GetFirstCheckedKeyIdInDivObj }   from \"@/ts/PubFun/clsCommFunc4Ctrl.js\";");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + "import { GetCheckedKeyIdsInDivObj }   from \"@/ts/PubFun/clsCommFunc4Ctrl.js\";");
                    }
                }

                strCodeForCs.Append("\r\n" + "import { AccessBindGvDefault } from '@/ts/PubFun/clsErrMsgBLEx';");
                //strCodeForCs.Append("\r\n" + "import { Format } from \"@/ts/PubFun/clsString\";");
                strCodeForCs.Append("\r\n" + "import { IShowList } from \"@/ts/PubFun/IShowList\";");
                strCodeForCs.AppendFormat("\r\n /** {0} ��ժҪ˵��������Q�����ѯ,U�����޸�",
                    ThisClsName);
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + "export class  {0} extends {1} implements IShowList", ThisClsName, this.BaseClsName);
                strCodeForCs.Append("\r\n" + "{");
                
                strCodeForCs.AppendFormat("\r\n" + "//public static mstrSort{0}By = \"{1}\";",
                    objViewInfoENEx.TabName_Out, objKeyField.FldName);

                strCodeForCs.AppendFormat("\r\n /**");
                strCodeForCs.AppendFormat("\r\n * ÿҳ��¼��,����չ������޸�");
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "public get pageSize():number {");
                strCodeForCs.Append("\r\n" + "return 10;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.Append("\r\n" + "* ��������:��ʼ���ã�������ʼ��һЩ����ֵ");
                strCodeForCs.Append("\r\n" + "**/");
                strCodeForCs.Append("\r\n" + "public async InitVarSet(): Promise<void> {");
                strCodeForCs.Append("\r\n" + $"console.log('InitVarSet in {ThisClsName}');");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "/** ");
                strCodeForCs.Append("\r\n" + "* ��������:��ʼ������ؼ�ֵ�����ڰ�������֮��");
                strCodeForCs.Append("\r\n" + "**/");
                strCodeForCs.Append("\r\n" + "  public async InitCtlVar() : Promise<void> {");
                strCodeForCs.Append("\r\n" + $"console.log('InitCtlVar in {ThisClsName}');");
                strCodeForCs.Append("\r\n" + "}");

                string strFuncName_Temp = getBindGvFuncName();

                strCodeForCs.Append("\r\n" + "BindGv(strType: string, strPara: string) {");
                if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "alert(`����û�а󶨸ú�����[this.BindGv_{0}]!${{strType}}${{strPara}}`);", objViewInfoENEx.TabName_Out);
                    strCodeForCs.Append("\r\n" + $"//{strFuncName_Temp}(divVarSet.refDivList);");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "console.log(strType + strPara);", objViewInfoENEx.TabName_Out);
                    strCodeForCs.Append("\r\n" + $"{strFuncName_Temp}(divVarSet.refDivList);");
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "BindGvCache(strType: string, strPara: string) {");
                strCodeForCs.Append("\r\n" + "console.log(\"strPara\", strPara);");
                
                strCodeForCs.Append("\r\n" + "switch(strType)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "case \"{0}\":", objViewInfoENEx.TabName_Out);
           
                if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
                {
                    strCodeForCs.Append("\r\n" + $"{strFuncName_Temp}(divVarSet.refDivList);");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + $"alert('����û�а󶨸ú�����[{strFuncName_Temp}]!');");
                    strCodeForCs.Append("\r\n" + $"//{strFuncName_Temp}(divVarSet.refDivList);");
                }
                strCodeForCs.Append("\r\n" + "break;");
                strCodeForCs.Append("\r\n" + "default:");
                strCodeForCs.Append("\r\n" + "AccessBindGvDefault(strType);");
                strCodeForCs.Append("\r\n" + "break;");

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");


                /////���ɽ�����PageLoad����;
                //strCodeForCs.Append("\r\n" + "#region ҳ����������");

                /////���ɽ�����PageLoad����;
                //strTemp = GenPageLoadCode(false);
                //strCodeForCs.Append(strTemp);
                //strCodeForCs.Append("\r\n" + "#endregion ҳ����������");
                //�������еĺ���
                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
           clsvFunction4GeneCodeBLEx.GetObjLstByViewInfoEx(objViewInfoENEx);

                //IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                //  clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objViewInfoENEx.FunctionTemplateId,
                //  objViewInfoENEx.LangType, objViewInfoENEx.CodeTypeId, objViewInfoENEx.SqlDsTypeId);
                //IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLstByFeature = objViewInfoENEx.arrvFunction4GeneCodeSetByFeatureLst;
                //arrvFunction4GeneCodeObjLstByFeature = arrvFunction4GeneCodeObjLstByFeature.Where(x => x.CodeTypeId == objViewInfoENEx.CodeTypeId);
                //IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_All = arrvFunction4GeneCodeObjLst.Union(arrvFunction4GeneCodeObjLstByFeature, new VFunction4GeneCodeComparer());
                //arrvFunction4GeneCodeObjLst_All = arrvFunction4GeneCodeObjLst_All.OrderBy(x => x.FuncName4Code);

                //Ϊ���еĺ��������������ؼ�
                List<string> arrValueLst = new List<string>();

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    //string strTemp = "";
                    //if (strFuncName.IndexOf("TS_ScriptCS") > 0)
                    //{
                    //string strFuncName4Code = objvFunction4GeneCodeEN.FuncName4Code;
                    //if (strFuncName4Code.Contains("AddNew") == true
                    //    || strFuncName4Code.Contains("Update") == true
                    //    || strFuncName4Code.Contains("GetObjByKey") == true)
                    //{
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    //string strSource = string.Format("ac{0}_UnitTest", objViewInfoENEx.TabName);
                    //string strTarget = string.Format("ac{0}_UTScript", objViewInfoENEx.TabName);

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
                strCodeForCs.Append( Gen_Vue_Ts_SortColumn());
                
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
        /// ����:����Ĳ�ѯ���޸ġ����롢ɾ��
        /// </summary>
        /// <returns></returns>

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
                    strCodeForCs.AppendFormat("\r\n" + "<div style = \"position: relative; width: 648px; height: 37px; left: 0px; top: 0px;\">");
                    strCodeForCs.AppendFormat("\r\n" + "<asp:Label ID = \"lblViewTitle\" runat = \"server\" CssClass = \"h5\" >{0}",
                      strTitle);
                    strCodeForCs.AppendFormat("\r\n" + "</asp:Label>");
                    //����в�ѯ����
                    if (objViewInfoENEx.objViewTypeCodeTab.IsHaveQuery)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "<asp:Label ID = \"lblMsg_List\" runat = \"server\" CssClass = \"text-warning\"  Style = \"z-index: 105;");
                        strCodeForCs.AppendFormat("\r\n" + "left: 54px; position: relative; top: 4px\" Width = \"347px\"></asp:Label>");
                    }
                    strCodeForCs.AppendFormat("\r\n" + "	</div>");
                    break;
            }

            intZIndex += 1;
            return strCodeForCs.ToString();
        }

        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            return A_GeneFuncCodeBase(objvFunction4GeneCodeEN, typeof(Vue_ViewScriptCSEx_TS4TypeScript));
            //string strFuncName = objvFunction4GeneCodeEN.FuncName;
            //try
            //{
            //    string strCode = "";
            //    Type t = typeof(Vue_ViewScriptCSEx_TS4TypeScript);
            //    MethodInfo mt = t.GetMethod(strFuncName, BindingFlags.Instance | BindingFlags.Public);

            //    if (mt == null)
            //    {
            //        string strMsg = string.Format("������û����Ӧ�ĺ���:{0}.(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
            //        throw new Exception(strMsg);
            //    }
            //    else
            //    {
            //        //                string str = (string)mt.Invoke(null, new object[] { "1234567890123"    });
            //        if (mt.GetParameters().Length == 0)
            //        {
            //            strCode = (string)mt.Invoke(this, null);
            //        }
            //        else if (mt.GetParameters().Length == 1)
            //        {
            //            strCode = (string)mt.Invoke(this, new object[] { objvFunction4GeneCodeEN });
            //        }
            //        //Console.WriteLine(str);
            //    }

            //    return strCode;
            //}
            //catch (Exception objException)
            //{
            //    StringBuilder sbMessage = new StringBuilder();
            //    string strMsg = "";
            //    if (objException.InnerException != null && string.IsNullOrEmpty(objException.InnerException.Message) == false)
            //    {
            //        strMsg = objException.InnerException.Message;
            //    }
            //    else
            //    {
            //        strMsg = objException.Message;
            //    }
            //    sbMessage.AppendFormat("�����ɺ���:{0}ʱ����. \r\n������Ϣ:{1}.", strFuncName, strMsg);
            //    throw new Exception(sbMessage.ToString());
            //}
        }
        public override void GetClsName()
        {

            //if (PrjTabEx_ListRegion.IsUseCache_TS())
            //{
            //    this.ClsName = string.Format("WApi{0}_QUDICacheEx", objViewInfoENEx.TabName);
            //    this.BaseClsName = string.Format("WApi{0}_QUDICache", objViewInfoENEx.TabName);

            //    ThisClsName = this.ClsName;

            //}
            //else
            //{
            //    this.ClsName = string.Format("WApi{0}_QUDI_JSEx", objViewInfoENEx.TabName);
            //    this.BaseClsName = string.Format("WApi{0}_QUDI_JS", objViewInfoENEx.TabName);
            //    ThisClsName = this.ClsName;
            //}
            this.ClsName = string.Format("{0}Ex", objViewInfoENEx.ViewName);
            this.BaseClsName = string.Format("{0}", objViewInfoENEx.ViewName);
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
                        objViewInfoENEx.MainTabId, objViewInfoENEx.PrjDataBaseId, objViewInfoENEx.PrjId);
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

        public string Gen_Vue_Ts_GeneEventFuncEx()
        {
            if (objViewInfoENEx.arrQryRegionFldSet == null) return "";
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {


                var arrQryRegionFlds_ChangeEvent = objViewInfoENEx.arrQryRegionFldSet.Where(x => string.IsNullOrEmpty(x.ChangeEvent) == false && x.InUse == true).ToList();
                arrQryRegionFlds_ChangeEvent.ForEach(x =>
                {
                    var objCtlTypeAbbr = clsCtlTypeBL.GetObjByCtlTypeIdCache(x.CtlTypeId);

                    strCodeForCs.Append("\r\n /** ��������:ϵͳ���ɵ�Change�¼�����");
                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + " **/");
                    strCodeForCs.AppendFormat("\r\n" + "public async {0}()",
                       x.ChangeEvent);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "alert('������չ��:{0}Ex����д�ú���!');", ThisClsName);
                    strCodeForCs.Append("\r\n" + "}");
                });

                strCodeForCs.Append("\r\n" + "");

                var arrQryRegionFlds_ClickEvent = objViewInfoENEx.arrQryRegionFldSet.Where(x => string.IsNullOrEmpty(x.ClickEvent) == false && x.InUse == true).ToList();
                arrQryRegionFlds_ClickEvent.ForEach(x =>
                {
                    var objCtlTypeAbbr = clsCtlTypeBL.GetObjByCtlTypeIdCache(x.CtlTypeId);
                    strCodeForCs.Append("\r\n /** ��������:ϵͳ���ɵ�Click�¼�����");
                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + " **/");

                    strCodeForCs.AppendFormat("\r\n" + "public  async {0}(){{;",
                       x.ClickEvent, ThisClsName);
                    strCodeForCs.AppendFormat("\r\n" + "alert('������չ��:{0}Ex����д�ú���!');", ThisClsName);
                    strCodeForCs.Append("\r\n" + "}");
                });

                strCodeForCs.Append("\r\n" + "");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("�����ɺ���:[{0}]ʱ����{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }
        public string Gen_Vue_TS_btn_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFldsObjLst = objViewInfoENEx.arrFeatureRegionFlds;
            if (objViewInfoENEx.arrFeatureRegionFlds == null)
            {
                string strMsg = string.Format("���湦����Ϊ��,����ӽ��湦��!����:{0}. (In {1})", objViewInfoENEx.ViewName, clsStackTrace.GetCurrClassFunction());
                throw new Exception(strMsg);

            }
            List<string> arrButtonName = arrFeatureRegionFldsObjLst.Select(x => x.ButtonName)
                .Select(x => x.Substring(3))
                .ToList();
            var arr = new List<string> { enumPrjFeature.DefaultFeature_0240, enumPrjFeature.SetFieldValue_0148 };
            List<clsFeatureRegionFldsENEx> arrFeatureRegionFldsObjLst_DefaultFeature = objViewInfoENEx.arrFeatureRegionFlds.Where(x => arr.Contains(x.FeatureId)).ToList();

            var objViewRegion_Edit = objViewInfoENEx.objViewRegion_Edit;

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * ��ť����,���ڵ���Js������btnClick");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");

            strCodeForCs.AppendFormat("\r\n" + "public static btn_Click(strCommandName: string, strKeyId: string) {{");

            //strCodeForCs.AppendFormat("\r\n" + "const objPage:{0} = new {0}();", ThisClsName);
            strCodeForCs.AppendFormat("\r\n" + "let objPage: {0};", ThisClsName);
            
            strCodeForCs.Append("\r\n" + "let objPageEdit;");
            strCodeForCs.AppendFormat("\r\n" + "if ({0}.objPageCRUD == null)", this.BaseClsName);
            
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "{0}.objPageCRUD = new {1}();", this.BaseClsName, ThisClsName);
            strCodeForCs.AppendFormat("\r\n" + "objPage = <{0}> {0}.objPageCRUD;", ThisClsName, this.BaseClsName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "objPage = <{0}> {0}.objPageCRUD;", ThisClsName, this.BaseClsName);
            strCodeForCs.Append("\r\n" + "}");

           
            if (PrjTabEx_View.SqlDsTypeId == enumSQLDSType.SqlTab_01)   strCodeForCs.Append("\r\n" + "let strMsg = '';");

            //strCodeForCs.Append("\r\n" + "const strKeyId = clsCommFunc4Ctrl.GetFirstCheckedKeyId(objPage.divName4List);");
            string strKeyLstName = "arrKeyIds";
            if (PrjTabEx_EditRegion != null && thisEditTabProp_TS.KeyFldCount > 1)
            {
                strKeyLstName = "arrKeyLsts";
                strCodeForCs.Append("\r\n" + $"const arrKeyLsts = GetCheckedKeyLstsInDivObj(divVarSet.refDivList);");
                //strCodeForCs.Append("\r\n" + "let objKeyLst;");
                strCodeForCs.Append("\r\n" + "let strKeyLst = \"\"; ");
                //strCodeForCs.Append("\r\n" + $"strKeyLst = GetFirstCheckedKeyLstInDivObj(divVarSet.refDivList);");
            }
            else
            {
                strCodeForCs.Append("\r\n" + $"const arrKeyIds = GetCheckedKeyIdsInDivObj(divVarSet.refDivList);");
                //if (PrjTabEx_View.SqlDsTypeId == enumSQLDSType.SqlTab_01) 
                //    strCodeForCs.Append("\r\n" + $"strKeyId = GetFirstCheckedKeyIdInDivObj(divVarSet.refDivList);");
                //else strCodeForCs.Append("\r\n" + "console.log(strKeyId);");
            }
            strCodeForCs.Append("\r\n" + "switch (strCommandName)");
            strCodeForCs.Append("\r\n" + "{");

            arrFeatureRegionFldsObjLst_DefaultFeature.ForEach(x =>
            {
                string strCommandName = x.CommandName;
                strCodeForCs.AppendFormat("\r\n" + "case \"{0}\":    //�Զ��幦��:{1}", strCommandName, x.Text);
                if (string.IsNullOrEmpty(x.FuncName) == false)
                {
                    strCodeForCs.AppendFormat("\r\n" + "objPage.{0}();", x.FuncName.Replace("()", ""));
                }
                strCodeForCs.Append("\r\n" + "break;");
            });

            strCodeForCs.Append("\r\n" + "case \"Query\":    //��ѯ��¼");
            strCodeForCs.Append("\r\n" + "objPage.btnQuery_Click();");
            strCodeForCs.Append("\r\n" + "break;");

            if (IsHasEditRegion == true)
            {
                strCodeForCs.Append("\r\n" + "case \"AddNewRecordWithMaxId\":    //��Ӽ�¼ʹ�����ؼ���");
                strCodeForCs.Append("\r\n" + "case \"CreateWithMaxId\":    //��Ӽ�¼ʹ�����ؼ���");
                strCodeForCs.Append("\r\n" + "case \"AddNewRecord\":            //��Ӽ�¼");
                strCodeForCs.Append("\r\n" + "case \"Create\":            //��Ӽ�¼");

                    strCodeForCs.Append("\r\n" + $"objPageEdit = new {ThisEditClsName}Ex('{ThisEditClsName}Ex', objPage);//��ʼ���༭��,���õ�ǰ��Ϊ�༭��ĸ��࣬�༭���ص���" );
                    strCodeForCs.AppendFormat("\r\n" + "console.log(objPageEdit);", ThisEditClsName);

                strCodeForCs.Append("\r\n" + $"ref{ThisEditClsName}.value.btn{TabName_In4Edit}_Edit_Click(strCommandName, strKeyId);");
                strCodeForCs.Append("\r\n" + "break;");
                if (IsHasDetailRegion)
                {
                    strCodeForCs.Append("\r\n" + "case \"Detail\":            //��ϸ��Ϣ");
                    strCodeForCs.Append("\r\n" + $"ref{ThisDetailClsName}.value.btn{TabName_Out4DetailRegion}_Detail_Click(strCommandName, strKeyId);");                 
                    strCodeForCs.Append("\r\n" + "break;");
                }
                strCodeForCs.Append("\r\n" + "case \"UpdateRecord\":            //�޸ļ�¼");
                strCodeForCs.Append("\r\n" + "case \"Update\":            //�޸ļ�¼");
                strCodeForCs.Append("\r\n" + $"objPageEdit = new {ThisEditClsName}Ex('{ThisEditClsName}Ex',objPage);//��ʼ���༭��,���õ�ǰ��Ϊ�༭��ĸ��࣬�༭���ص���");
                strCodeForCs.AppendFormat("\r\n" + "console.log(objPageEdit);", ThisEditClsName);

                if (thisEditTabProp_TS.KeyFldCount > 1)
                {
                    strCodeForCs.Append("\r\n" + $"strKeyLst = GetFirstCheckedKeyLstInDivObj(divVarSet.refDivList);");
                    strCodeForCs.Append("\r\n" + "if (strKeyLst == 'undefined')");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "strMsg = `���޸ļ�¼ʱ����ȡ��¼�ؼ���Ϊ:${ strKeyLst},���ɹ�!`;");
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + $"ref{ThisEditClsName}.value.btn{TabName_In4Edit}_Edit_Click(strCommandName, strKeyLst);");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + $"strKeyId = GetFirstCheckedKeyIdInDivObj(divVarSet.refDivList);");
                    strCodeForCs.Append("\r\n" + "if (strKeyId == 'undefined')");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "strMsg = `���޸ļ�¼ʱ����ȡ��¼�ؼ���Ϊ:${ strKeyId},���ɹ�!`;");
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + $"ref{ThisEditClsName}.value.btn{TabName_In4Edit}_Edit_Click(strCommandName, strKeyId);");
                }
                strCodeForCs.Append("\r\n" + "break;");
                if (objViewInfoENEx.objViewRegion_Feature.IsHaveUpdateRecord_Gv())
                {
                    strCodeForCs.Append("\r\n" + "case \"UpdateRecordInTab\":            //�޸ļ�¼InTab");
                    if (thisEditTabProp_TS.KeyFldCount > 1)
                    {
                        strCodeForCs.Append("\r\n" + $"ref{ThisEditClsName}.value.btn{TabName_In4Edit}_Edit_Click(strCommandName, strKeyLst);");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + $"ref{ThisEditClsName}.value.btn{TabName_In4Edit}_Edit_Click(strCommandName, strKeyId);");
                    }
                    strCodeForCs.Append("\r\n" + "break;");
                }
            }
            if (objViewInfoENEx.objViewRegion_Feature.IsHaveCopyRecord())
            {
                strCodeForCs.Append("\r\n" + "case \"CopyRecord\":            //���Ƽ�¼");
                strCodeForCs.Append("\r\n" + "case \"Clone\":            //���Ƽ�¼");


                strCodeForCs.AppendFormat("\r\n" + "if ({0}.length == 0)", strKeyLstName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(`��ѡ����Ҫ���Ƶ�[${objPage.thisTabName}]��¼!`);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "{0}objPage.btnCopyRecord_Click();", arrButtonName.Contains("CopyRecord") ? "" : "//");
                strCodeForCs.Append("\r\n" + "break;");
            }
            if (objViewInfoENEx.objViewRegion_Feature.IsHaveExportToFile())
            {
                strCodeForCs.Append("\r\n" + "case \"ExportExcel\":            //����Excel");
                var objViewRegion_ExportExcel = objViewInfoENEx.objViewRegion_ExportExcel;
                var bolIsHasExcelExport = objViewRegion_ExportExcel != null && arrButtonName.Contains("ExportExcel");
                strCodeForCs.AppendFormat("\r\n" + "{0}objPage.btnExportExcel_Click();", bolIsHasExcelExport ? "" : "//");

                strCodeForCs.Append("\r\n" + "//alert(\"����Excel���ܻ�û�п�ͨ!\");");
                //strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "break;");
            }
            if (PrjTabEx_View.SqlDsTypeId == enumSQLDSType.SqlTab_01)
            {
                strCodeForCs.Append("\r\n" + "case \"DelRecord\":            //ɾ����¼");
                strCodeForCs.Append("\r\n" + "case \"Delete\":            //ɾ����¼");

                strCodeForCs.AppendFormat("\r\n" + "if ({0}.length == 0)", strKeyLstName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(`��ѡ����Ҫɾ����[${objPage.thisTabName}]��¼!`);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "objPage.btnDelRecord_Click();");
                strCodeForCs.Append("\r\n" + "break;");
                if (objViewInfoENEx.objViewRegion_Feature.IsHaveDetailRecord_Gv())
                {
                    strCodeForCs.Append("\r\n" + "case \"DelRecordInTab\":   //ɾ����¼InTab ");
                    if (PrjTabEx_EditRegion != null && thisEditTabProp_TS.KeyFldCount > 1)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "objKeyLst = {0}_SplitKeyLst(strKeyId);", TabName_In4Edit);
                        strCodeForCs.Append("\r\n" + "objPage.btnDelRecordInTab_Click(");
                        int intIndex = 0;
                        foreach (var objInFor in PrjTabEx_EditRegion.arrKeyFldSet)
                        {
                            if (intIndex == 0)
                            {
                                strCodeForCs.AppendFormat("objKeyLst.{0}", objInFor.PropertyName(this.IsFstLcase));
                            }
                            else
                            {
                                strCodeForCs.AppendFormat(", objKeyLst.{0}", objInFor.PropertyName(this.IsFstLcase));
                            }
                            intIndex++;
                        }
                        strCodeForCs.Append(");");
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + "objPage.btnDelRecordInTab_Click(strKeyId);");
                    }
                    strCodeForCs.Append("\r\n" + "break;");
                }
                if (objViewInfoENEx.objViewRegion_Feature.IsHaveDelRecordBySign())
                {
                    strCodeForCs.Append("\r\n" + "case \"DelRecordBySign\":            //����־ɾ����¼");
                    strCodeForCs.Append("\r\n" + "case \"DeleteBySign\":            //����־ɾ����¼");

                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.length == 0)", strKeyLstName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "alert(`��ѡ����Ҫ����־ɾ����[${objPage.thisTabName}]��¼!`);");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "{0}objPage.btnDelRecordBySign_Click();", arrButtonName.Contains("DelRecordBySign") ? "" : "//");
                    strCodeForCs.Append("\r\n" + "break;");


                    strCodeForCs.Append("\r\n" + "case \"UnDelRecordBySign\":            //����־�ָ�ɾ����¼");
                    strCodeForCs.Append("\r\n" + "case \"UnDeleteBySign\":            //����־�ָ�ɾ����¼");

                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.length == 0)", strKeyLstName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "alert(`��ѡ����Ҫ�ָ�ɾ����[${objPage.thisTabName}]��¼!`);");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "{0}objPage.btnUnDelRecordBySign_Click();",
                        arrButtonName.Contains("UnDelRecordBySign") ? "" : "//");
                    strCodeForCs.Append("\r\n" + "break;");
                }
                if (objViewInfoENEx.objViewRegion_Feature.IsHaveAdjustOrderNum())
                {
                    strCodeForCs.Append("\r\n" + "case \"GoTop\":            //�ö���¼");

                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.length == 0)", strKeyLstName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "alert(`��ѡ����Ҫ�ö���[${objPage.thisTabName}]��¼!`);");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "{0}objPage.btnGoTop_Click();",
                        arrButtonName.Contains("GoTop") ? "" : "//");
                    strCodeForCs.Append("\r\n" + "break;");


                    strCodeForCs.Append("\r\n" + "case \"GoBottum\":            //�Ƶ׼�¼");

                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.length == 0)", strKeyLstName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "alert(`��ѡ����Ҫ�Ƶ׵�[${objPage.thisTabName}]��¼!`);");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "{0}objPage.btnGoBottum_Click();",
                        arrButtonName.Contains("GoBottum") ? "" : "//");
                    strCodeForCs.Append("\r\n" + "break;");


                    strCodeForCs.Append("\r\n" + "case \"UpMove\":            //���Ƽ�¼");

                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.length == 0)", strKeyLstName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "alert(`��ѡ����Ҫ���Ƶ�[${objPage.thisTabName}]��¼!`);");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "{0}objPage.btnUpMove_Click();",
                        arrButtonName.Contains("UpMove") ? "" : "//");
                    strCodeForCs.Append("\r\n" + "break;");


                    strCodeForCs.Append("\r\n" + "case \"DownMove\":            //���Ƽ�¼");

                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.length == 0)", strKeyLstName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "alert(`��ѡ����Ҫ���Ƶ�[${objPage.thisTabName}]��¼!`);");
                    strCodeForCs.Append("\r\n" + "return;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "{0}objPage.btnDownMove_Click();",
                        arrButtonName.Contains("DownMove") ? "" : "//");
                    strCodeForCs.Append("\r\n" + "break;");


                    strCodeForCs.Append("\r\n" + "case \"ReOrder\":            //�����¼");
                    strCodeForCs.AppendFormat("\r\n" + "{0}objPage.btnReOrder_Click();",
                        arrButtonName.Contains("ReOrder") ? "" : "//");
                    strCodeForCs.Append("\r\n" + "break;");
                }
                strCodeForCs.Append("\r\n" + "default:");
                strCodeForCs.AppendFormat("\r\n" + "strMsg = `����:${{strCommandName}}�ں���({0}.btnClick)��û�б�����!`;", this.ClsName);
                strCodeForCs.Append("\r\n" + "console.error(strMsg)");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "break;");
            }

            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.Append("\r\n" + "}");

            arrFeatureRegionFldsObjLst_DefaultFeature.ForEach(x =>
            {
                if (x.FeatureId == enumPrjFeature.DefaultFeature_0240)
                {
                    if (string.IsNullOrEmpty(x.FuncName) == false)
                    {
                        strCodeForCs.Append("\r\n /**");
                        strCodeForCs.AppendFormat("\r\n * �Զ��幦��:{0}", x.Text);
                        strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n **/");
                        strCodeForCs.AppendFormat("\r\n" + "public {0}()", x.FuncName.Replace("()",""));
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.Append("\r\n" + "//�Զ��幦��;");
                        strCodeForCs.Append("\r\n" + "};");
                    }
                }
            });


            return strCodeForCs.ToString();
        }

        public string Gen_Vue_TS_btn_ClickBak(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return new WA_ViewScriptCSEx_TS4TypeScript().Gen_WApi_TS_btn_Click(objvFunction4GeneCodeEN);
       
        }
public string getBindGvFuncName()
        {
            string strSuffix = "";
            string strFuncName_Temp = $"this.BindGv_{TabName_Out4ListRegion}";
            if (objViewInfoENEx.objMainPrjTab.IsUseCache_TS() == true) strSuffix = "Cache";
            if (this.IsUseFunc == true) strSuffix = "4Func";
            if (PrjTabEx_ListRegion.IsUseCache_TS() == true)
            {
                strFuncName_Temp = $"this.BindGv_{TabName_Out4ListRegion}{strSuffix}";
            }
            else
            {
                strFuncName_Temp = $"this.BindGv_{TabName_Out4ListRegion}{strSuffix}";
            }
            return strFuncName_Temp;
        }
    }
}
