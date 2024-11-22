using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using AGC.BusinessLogic;
using AGC.BusinessLogicEx;
using AGC.Entity;
using AGC.PureClass;
using AGC.PureClassEx;
using AgcCommBase;

using com.taishsoft.commexception;
using com.taishsoft.common;
using com.taishsoft.comm_db_obj;
using com.taishsoft.util;
using TzAdvancedLib;

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
    partial class Vue_ViewScriptCS_TS4TypeScript : WA_ViewScriptCS_TS4TypeScript
    {
        private bool bolIsGeneDispAllErrMsg;
        #region 构造函数
        public Vue_ViewScriptCS_TS4TypeScript()
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.arrImportClass = new List<ImportClass>();
            bolIsGeneDispAllErrMsg = false;
        }
        public Vue_ViewScriptCS_TS4TypeScript(string strViewId)
       : base("", strViewId, "", "")
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            this.arrImportClass = new List<ImportClass>();
            bolIsGeneDispAllErrMsg = false;
        }
        public Vue_ViewScriptCS_TS4TypeScript(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
        : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            this.arrImportClass = new List<ImportClass>();
            bolIsGeneDispAllErrMsg = false;
            this.GetClsName();
            if (thisCacheClassify4View.IsHasCacheClassfyFld == true)
            {
                thisCacheClassify4View.VarDef4Fld = string.Format("{0}.{1}Cache", ThisClsName, thisCacheClassify4View.FldName);
            }
            if (thisCacheClassify4View.IsHasCacheClassfyFld2 == true)
            {
                thisCacheClassify4View.VarDef4Fld2 = string.Format("{0}.{1}Cache", ThisClsName, thisCacheClassify4View.FldName2);
            }
        }
        ///// <summary>
        ///// 初始化页面设置
        ///// </summary>
        //public void InitPageSetup()
        //{
        //    intZIndex = 100;        ///控件焦点序号
        //    intCurrLeft = 10;  ///控件的左边空;
        //    intCurrTop = 10;
        //}

        #endregion

        public string Gen_Vue_Ts_Page_Load()
        {
            return Gen_WApi_Ts_Page_Load();
        }

        public string Gen_Vue_Ts_Page_LoadCache()
        {
            return Gen_WApi_Ts_Page_LoadCache();
        }


        public string Gen_Vue_Ts_DdlBind()
        {
            return Gen_WApi_Ts_DdlBind();
        }

        public string Gen_Vue_Ts_BindDdl4QueryRegion()
        {
            return Gen_WApi_Ts_BindDdl4QueryRegion();
        }


        public string Gen_Vue_Ts_BindDdl4FeatureRegion()
        {
            return Gen_WApi_Ts_BindDdl4FeatureRegion();
        }


        Func<clsQryRegionFldsENEx, ASPDropDownListEx> GetDdlObj = obj => clsASPDropDownListBLEx.GetDropDownLst_Asp(obj, new clsGetTabFieldObj());

        public string Gen_Vue_Ts_SetBindDdl4QryRegion()
        {
            return Gen_WApi_Ts_SetBindDdl4QryRegion();
        }

        public string Gen_Vue_Ts_SetBindDdl4FeatureRegion()
        {
            return Gen_WApi_Ts_SetBindDdl4FeatureRegion();
        }

        public string Gen_Vue_Ts_DdlBind4QueryRegion()
        {
            return "";// Gen_WApi_Ts_DdlBind4QueryRegion();
        }

        public string Gen_Vue_Ts_DdlBind4ViewFeatureInPage_Load()
        {
            return Gen_WApi_Ts_DdlBind4ViewFeatureInPage_Load();

        }


        /// <summary>
        /// 生成App页面后台代码
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            arrPropertyDef4GC = new List<clsPropertyDef4GC>();
            var objCodeType = clsCodeTypeBL.GetObjByCodeTypeIdCache(objViewInfoENEx.CodeTypeId);
            //让用户设置属性;

            if (string.IsNullOrEmpty(TabId_Out4ListRegion) == false)
            {
                var objPrjTab_ListRegion = clsPrjTabBL.GetObjByTabIdCache(TabId_Out4ListRegion, objViewInfoENEx.PrjId);
                if (objPrjTab_ListRegion != null)
                {
                    strSqlDsTypeId4ListRegion = objPrjTab_ListRegion.SqlDsTypeId;
                }

                objPrjTabEx_ListRegion = clsPrjTabBLEx.CopyToEx(objPrjTab_ListRegion);
                objPrjTabEx_ListRegion.GetObjAllInfoEx();

                if (this.IsUseFunc)
                {
                    strFuncName4BindGv = string.Format("BindGv_{0}4Func", TabName_Out4ListRegion4GC);
                }
                else
                {
                    if (PrjTabEx_ListRegion.IsUseStorageCache_TS())
                    {
                        strFuncName4BindGv = string.Format("BindGv_{0}Cache", TabName_Out4ListRegion4GC);
                    }
                    else
                    {
                        strFuncName4BindGv = string.Format("BindGv_{0}", TabName_Out4ListRegion4GC);
                    }
                }
            }
            string strFuncName = "";
            string strTemp = ""; ///临时变量;
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;
            clsPubFun4BLEx.CheckDgStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsPubFun4BLEx.CheckTitleStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.TitleStyleId);

            objViewInfoENEx.WebFormName = ThisClsName;
            objViewInfoENEx.WebFormFName = string.Format("{0}.ts", ThisClsName);

            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;

            strRe_ClsName = objViewInfoENEx.WebFormName;
            objFuncModuleEN = clsFuncModule_AgcBL.GetObjByFuncModuleAgcIdCache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);
            strRe_FileNameWithModuleName = clsPubFun4GC.GetFileNameWithModuleName(objCodeType, objFuncModuleEN, objViewInfoENEx, objViewInfoENEx.TabName);

            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjIdCache(objViewInfoENEx.PrjId); //
            try
            {
                //准备数据
                //获取界面所需要的公共变量

                if (string.IsNullOrEmpty(this.TabId_Out4ListRegion) == false) this.GetViewPubVarLst(this.TabId_Out4ListRegion);

                //生成所有的函数
                List<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                    clsvFunction4GeneCodeBLEx.GetObjLstByViewInfoEx(objViewInfoENEx);
                List<clsvFunction4GeneCodeEN> arrFunc = arrvFunction4GeneCodeObjLst.Where(x => x.FuncName == "Gen_WApi_Ts_GetConditionInFldValueLst").ToList();
                //为所有的函数定义相关输入控件
                List<string> arrValueLst = new List<string>();

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    strTemp = A_GeneFuncCode(objvFunction4GeneCodeEN, ref Re_objFunction4Code);
                    objvFunction4GeneCodeEN.CodeText = strTemp;
                }
                strFuncName = "";
                arrPropertyDef4GC.Add(new clsPropertyDef4GC
                {
                    OperateType = "set",
                    ControlType = "label",
                    CtrlId = string.Format("lblViewTitle", TabName_Out4ListRegion4GC),
                    PropertyName = string.Format("ViewTitle", TabName_Out4ListRegion4GC),
                    Comment = "设置界面标题-相当使用ViewState功能",
                    DataType = "string",
                    ParentDivName = $"divVarSet.refDivLayout"
                });

                arrPropertyDef4GC.Add(new clsPropertyDef4GC
                {
                    OperateType = "get",
                    ControlType = "label",
                    CtrlId = string.Format("lblViewTitle", TabName_Out4ListRegion4GC),
                    PropertyName = string.Format("ViewTitle", TabName_Out4ListRegion4GC),
                    Comment = "设置界面标题",
                    DataType = "string",
                    ParentDivName = $"divVarSet.refDivLayout"
                });


                StringBuilder sbPropertyDef = new StringBuilder();
                clsPubFun4GC.Gen_WApi_Ts_ControlProperty(sbPropertyDef, arrPropertyDef4GC, $"divVarSet.refDivQuery", this, this.strBaseUrl);

                //类名开始
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate4WebApi(objViewInfoENEx.CurrUserName,
                    objViewInfoENEx, this.CmPrjId));

                strCodeForCs.AppendFormat("\r\n" + "//import $ from \"jquery\";");

                GetImportClassLst(objFuncModuleEN);

                arrImportClass = arrImportClass.Distinct(new ImportClass4GCComparer()).ToList();
                foreach (var objInFor in arrImportClass)
                {
                    objInFor.ClsName = objInFor.ClsName;
                    objInFor.FilePath = objInFor.FilePath.Replace(".js", "")
                              .Replace("../../TS/", "@/ts/")
                              .Replace("../../L3ForWApi/", "@/ts/L3ForWApi/")
                              .Replace("../../L3ForWApiEx/", "@/ts/L3ForWApiEx/")
                              .Replace("../TS/", "@/ts/");
                }
                var arrImportClass_RemoveDup = clsPubFun4GC.ImportClass_RemoveDup(arrImportClass);

                foreach (var objInFor in arrImportClass_RemoveDup)
                {
                    strCodeForCs.AppendFormat("\r\n" + "import {{ {0} }} from \"{1}\";",
                      objInFor.ClsName,
                        objInFor.FilePath.Replace(".js", "")
                              .Replace("../../TS/", "@/ts/")
                              .Replace("../../L3ForWApi/", "@/ts/L3ForWApi/")
                              .Replace("../../L3ForWApiEx/", "@/ts/L3ForWApiEx/")
                              .Replace("../TS/", "@/ts/"));
                }
                if (objViewInfoENEx.objViewRegion_ExportExcel != null)
                {
                    strCodeForCs.Append("\r\n" + " /**");
                    strCodeForCs.Append("\r\n" + "* 宣布一个用于导出Excel的函数,用于调用js端的导出Excel。");
                    strCodeForCs.Append("\r\n" + " **/");

                    strCodeForCs.AppendFormat("\r\n" + "declare function exportSpecialExcel_pyf(arrData:any, strFileName:string): void;", objViewInfoENEx.TabName_In);
                }


                strCodeForCs.AppendFormat("\r\n /** {0} 的摘要说明。其中Q代表查询,U代表修改",
                    ThisClsName);
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + "export abstract class  {0} implements clsOperateList", ThisClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "public static vuebtn_Click: (strCommandName: string, strKeyId: any) => void;");
                strCodeForCs.Append("\r\n" + "public static GetPropValue: (strPropName: string) => string;");

                //if (IsHasEditRegion) strCodeForCs.Append("\r\n" + "public static EditObj: any;");
                //if (IsHasDetailRegion) strCodeForCs.Append("\r\n" + "public static DetailObj: any;");

                strCodeForCs.Append("\r\n" + GenePubVar4DataListView());

                //strCodeForCs.Append("\r\n" + GeneViewPubVar_TS(strFuncName));

                strCodeForCs.AppendFormat("\r\n" + "public static objPageCRUD: {0};", ThisClsName);

                strCodeForCs.Append("\r\n" + "public static sortFunStatic: (ascOrDesc: string) => (x: any, y: any) => number;");

                //strCodeForCs.Append("\r\n" + "public static ascOrDesc4SortFun = \"Asc\";");
                //strCodeForCs.AppendFormat("\r\n" + "public static sort{0}By = \"\";", TabName_Out4ListRegion4GC);

                strCodeForCs.Append("\r\n" + "constructor() {");
                //strCodeForCs.Append("\r\n" + "super();");
                strCodeForCs.AppendFormat("\r\n" + "{0}.objPageCRUD = this;", ThisClsName);
                //AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetDivObjInDivObjN", enumImportObjType.CustomFunc, this.strBaseUrl);
                strCodeForCs.Append("\r\n" + "this.objPager = new clsPager(this);");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.AppendFormat("\r\n /**");
                strCodeForCs.AppendFormat("\r\n * 获取当前组件的divList的层对象");
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "public get thisDivList(): HTMLDivElement {");
                strCodeForCs.Append("\r\n" + $"return divVarSet.refDivList;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.AppendFormat("\r\n /**");
                strCodeForCs.AppendFormat("\r\n * 获取当前组件的divLayout的层对象");
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "public get thisDivLayout(): HTMLDivElement {");
                strCodeForCs.Append("\r\n" + $"return divVarSet.refDivLayout;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.AppendFormat("\r\n /**");
                strCodeForCs.AppendFormat("\r\n * 获取当前界面的主表名");
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "public get thisTabName(): string {");
                strCodeForCs.Append("\r\n" + $"return cls{objViewInfoENEx.TabName}EN._CurrTabName;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.AppendFormat("\r\n /**");
                strCodeForCs.AppendFormat("\r\n * 每页记录数,在扩展类可以修改");
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "public get pageSize():number {");
                strCodeForCs.Append("\r\n" + "return 5;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "public recCount = 0;");

                strCodeForCs.Append("\r\n" + "");

                strCodeForCs.Append("\r\n" + "/** ");
                strCodeForCs.Append("\r\n" + "* 函数功能:初始设置，用来初始化一些变量值");
                strCodeForCs.Append("\r\n" + "**/");
                strCodeForCs.Append("\r\n" + "  public abstract InitVarSet() : void; ");

                strCodeForCs.Append("\r\n" + "/** ");
                strCodeForCs.Append("\r\n" + "* 函数功能:初始化界面控件值，放在绑定下拉框之后");
                strCodeForCs.Append("\r\n" + "**/");
                strCodeForCs.Append("\r\n" + "  public abstract InitCtlVar() : void; ");

                foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
                {
                    strFuncName = objvFunction4GeneCodeEN.FuncName;
                    if (strFuncName == "Gen_WApi_Ts_GetConditionInFldValueLst")
                    {
                        string ss = "";
                    }
                    if (string.IsNullOrEmpty(objvFunction4GeneCodeEN.CodeText) == false)
                    {
                        strCodeForCs.Append("\r\n" + objvFunction4GeneCodeEN.CodeText);
                    }
                }
                strCodeForCs.Append("\r\n" + sbPropertyDef.ToString());


                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }



        public string Gen_Vue_Ts_SetKeyReadOnly()
        {
            return Gen_WApi_Ts_SetKeyReadOnly();
        }

        //public string G1en_Vue_Ts_Clear()
        //{
        //    return G1en_WApi_Ts_Clear();
        //}

        public string Gen_Vue_Ts_CopyRecord()
        {
            return Gen_WApi_Ts_CopyRecord();

        }


        public string Gen_Vue_Ts_SortFunExportExcel()
        {
            return Gen_WApi_Ts_SortFunExportExcel();

        }
        public string Gen_Vue_Ts_ExportExcelCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return Gen_WApi_Ts_ExportExcelCache(objvFunction4GeneCodeEN);

        }

        public string Gen_Vue_Ts_ExportExcel4Func_NoCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (this.IsUseFunc4ExcelExport == false) return "";

            if (objViewInfoENEx.objViewRegion_ExportExcel == null) return "";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 根据条件获取相应的对象列表");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");

            strCodeForCs.AppendFormat("\r\n" + "public async ExportExcel_{0}4Func() ",
                TabName_Out4ExportExcel4GC);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.ExportExcel_{0}4Func.name;", TabName_Out4ExportExcel4GC);
            strCodeForCs.AppendFormat("\r\n" + "if (viewVarSet.sort{0}By == null)", TabName_Out4ListRegion4GC, ThisClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"在显示列表时,排序字段(sort{0}By)为空,请检查!(In BindGv_{0}Cache)\");", TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);


            strCodeForCs.Append("\r\n" + GC_WhereCondition(enumRegionType.ExcelExportRegion_0007, true));

            strCodeForCs.AppendFormat("\r\n" + " let arr{0}ObjLst: Array <cls{0}EN> = [];", TabName_Out4ExportExcel4GC);
            strCodeForCs.AppendFormat("\r\n" + " let arr{0}ExObjLst: Array <cls{0}ENEx> = [];", TabName_Out4ExportExcel4GC);
            AddImportClass(TabId_Out4ExportExcel, TabName_Out4ExportExcel4GC, string.Format("cls{0}EN", ViewMainTabName4GC), enumImportObjType.ENExClass, this.strBaseUrl);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + GC_RecCount(enumRegionType.ExcelExportRegion_0007, ""));

            strCodeForCs.Append("\r\n" + GC_GetObjExLst(enumRegionType.ExcelExportRegion_0007, ""));

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `导出Excel时获取数据不成功,${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");

            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");

            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ObjLst.length == 0)", TabName_Out4ExportExcel4GC);
            strCodeForCs.Append("\r\n" + "{");


            if (thisCacheClassify4View.IsHasCacheClassfyFld == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}\", cls{0}EN._CurrTabName);",
                ViewMainTabName4GC, ThisClsName);
            }
            else if (thisCacheClassify4View.IsHasCacheClassfyFld2 == false)
            {
                if (thisCacheClassify4View.IsNumberType == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1}.value);",
                           ViewMainTabName4GC, thisCacheClassify4View.ViewVarName);

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1}.value);",
                         ViewMainTabName4GC, thisCacheClassify4View.ViewVarName);
                }
            }
            else
            {
                if (thisCacheClassify4View.IsNumberType == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}_{{2}}\", cls{0}EN._CurrTabName, {1}.value, {2}.value);",
                           ViewMainTabName4GC, thisCacheClassify4View.ViewVarName, thisCacheClassify4View.ViewVarName2);

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}_{{2}}\", cls{0}EN._CurrTabName, {1}.value, {2}.value);",
                         ViewMainTabName4GC, thisCacheClassify4View.ViewVarName, thisCacheClassify4View.ViewVarName2);
                }
            }

            if (thisCacheClassify4View.IsHasCacheClassfyFld == false)
            {

                strCodeForCs.AppendFormat("\r\n" + "const strMsg = `根据条件获取的${{this.thisTabName}}记录数为0!(Key=${{strKey}})`;",
                    ViewMainTabName4GC);
            }
            else if (thisCacheClassify4View.IsHasCacheClassfyFld2 == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "const strMsg = `根据条件获取的${{this.thisTabName}}记录数为0!(Key=${{strKey}})`;",
                     ViewMainTabName4GC, ThisClsName, thisCacheClassify4View.FldName);
            }
            else
            {

                strCodeForCs.AppendFormat("\r\n" + "const strMsg = `根据条件获取的${{this.thisTabName}}记录数为0!(Key=${{strKey}})`;",
                     ViewMainTabName4GC, ThisClsName, thisCacheClassify4View.FldName,
                     thisCacheClassify4View.FldName2);
            }
            strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
            strCodeForCs.Append("\r\n" + "//console.trace();");
            //strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"根据条件:[{{0}}]共获取对象列表数：{{1}}!\", strWhereCond, arr{0}ObjLst.length);",
            //    ViewMainTabName4GC);

            //strCodeForCs.Append("\r\n" + "//显示信息框");
            //strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const arrDataColumn: Array < clsDataColumn > =");
            strCodeForCs.Append("\r\n" + "       [");

            var arrExcelExportRegionFlds = objViewInfoENEx.arrExcelExportRegionFldSet.OrderBy(x => x.SeqNum);
            foreach (clsExcelExportRegionFldsENEx objDGRegionFldsENEx in arrExcelExportRegionFlds)
            {
                if (string.IsNullOrEmpty(objDGRegionFldsENEx.FldName)) continue;


                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "fldName: \"{0}\",", objDGRegionFldsENEx.FldName_Lcase);
                strCodeForCs.AppendFormat("\r\n" + "sortBy: \"{0}\",", "");
                strCodeForCs.Append("\r\n" + "sortFun: SortFun,");
                strCodeForCs.Append("\r\n" + "getDataSource: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"{0}\",", objDGRegionFldsENEx.ColCaption);
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

            strCodeForCs.Append("\r\n" + "];");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "await this.ExtendFldFuncMap(arr{0}ExObjLst, arrDataColumn);", TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `扩展字段值的映射出错,${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = arr{0}ObjLst.sort(this.SortFunExportExcel);", TabName_Out4ExportExcel4GC);

            strCodeForCs.AppendFormat("\r\n" + "  this.CombineData(arr{0}ObjLst, arrDataColumn); ",
                TabName_Out4ExportExcel4GC, objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + "//console.log(\"完成BindGv_{0}!\");", TabName_Out4ExportExcel4GC);
            //strCodeForCs.Append("\r\n" + "resolve(jsonData);");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `绑定${this.thisTabName}对象列表不成功, ${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");

            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_Vue_Ts_ExportExcel4Func(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (this.IsUseFunc4ExcelExport == false) return "";
            string strIsShare = "";
            if (objViewInfoENEx.IsShare) strIsShare = "Share";
            if (PrjTabEx_ListRegion.IsUseStorageCache_TS() == false)
            {
                return Gen_Vue_Ts_ExportExcel4Func_NoCache(objvFunction4GeneCodeEN);
            }
            if (objViewInfoENEx.objViewRegion_ExportExcel == null) return "";

            List<string> arrCondFldId = new List<string>();
            var objFuncParaLst = new FuncParaLst("ExportExcel4Func", this.IsFstLcase, enumAppLevel.InvokeFunc);
            objFuncParaLst.AddParaByCacheClassify(thisCacheClassify_ExportExcel_TS, arrCondFldId, enumProgLangType.TypeScript_09);

            //string strFuncParaLst = objFuncParaLst.GetCondFldLst4Para();
            List<string> arrVarNameLst = new List<string>();
            if (thisCacheClassify4View.IsHasCacheClassfyFld == true)
            {
                var strViewVarName = $"{thisCacheClassify4View.ViewVarName}.value";
                arrVarNameLst.Add(strViewVarName);
                AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{objViewInfoENEx.TabName}VueShare", thisCacheClassify4View.ViewVarName, enumImportObjType.CustomFunc, "");

            }
            if (thisCacheClassify4View.IsHasCacheClassfyFld2 == true)
            {
                var strViewVarName = $"{thisCacheClassify4View.ViewVarName2}.value";
                arrVarNameLst.Add(strViewVarName);
                AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{objViewInfoENEx.TabName}VueShare", thisCacheClassify4View.ViewVarName2, enumImportObjType.CustomFunc, "");

            }
            string strCondFldLst_Cache = string.Join(",", arrVarNameLst);
            //string strCheckEmptyCode = objFuncParaLst.Gc_CheckVarEmpty_Ts(this.ClsName, strFuncName, true, this, this.strBaseUrl);
            if (strCondFldLst_Cache.Length > 0) strCondFldLst_Cache = "," + strCondFldLst_Cache;


            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 根据条件获取相应的对象列表");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");

            strCodeForCs.AppendFormat("\r\n" + "public async ExportExcel_{0}4Func() ",
                TabName_Out4ExportExcel4GC);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.ExportExcel_{0}4Func.name;", TabName_Out4ExportExcel4GC);
            strCodeForCs.AppendFormat("\r\n" + "if (viewVarSet.sort{0}By == null)", TabName_Out4ListRegion4GC, ThisClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"在显示列表时,排序字段(sort{0}By)为空,请检查!(In BindGv_{0}Cache)\");", TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
            if (PrjTabEx_ExcelExportRegion.CacheModeId == enumCacheMode.ClientCache_02 ||
                PrjTabEx_ExcelExportRegion.CacheModeId == enumCacheMode.localStorage_03 ||
                PrjTabEx_ExcelExportRegion.CacheModeId == enumCacheMode.sessionStorage_04)
            {
                strCodeForCs.AppendFormat("\r\n" + "const obj{0}Cond = await Combine{0}ConditionObj4ExportExcel();", TabName_Out4ExportExcel4GC);
                AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{objViewInfoENEx.TabName}VueShare", $"Combine{TabName_Out4ListRegion4GC}ConditionObj4ExportExcel", enumImportObjType.CustomFunc, "");

            }
            else
            {
                strCodeForCs.Append("\r\n" + $"const strWhereCond = await Combine{TabName_Out4ExportExcel4GC}Condition();");
                AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{objViewInfoENEx.TabName}VueShare", $"Combine{TabName_Out4ListRegion4GC}Condition", enumImportObjType.CustomFunc, "");

            }

            strCodeForCs.AppendFormat("\r\n" + " let arr{0}ObjLst: Array <cls{0}EN> = [];", TabName_Out4ExportExcel4GC);
            strCodeForCs.AppendFormat("\r\n" + " let arr{0}ExObjLst: Array <cls{0}ENEx> = [];", TabName_Out4ExportExcel4GC);
            AddImportClass(TabId_Out4ExportExcel, TabName_Out4ExportExcel4GC, string.Format("cls{0}EN", ViewMainTabName4GC), enumImportObjType.ENExClass, this.strBaseUrl);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + GC_RecCount(enumRegionType.ExcelExportRegion_0007, strCondFldLst_Cache));

            strCodeForCs.Append("\r\n" + GC_GetObjExLst(enumRegionType.ExcelExportRegion_0007, strCondFldLst_Cache));

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `导出Excel时获取数据不成功,${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");

            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");

            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ObjLst.length == 0)", TabName_Out4ExportExcel4GC);
            strCodeForCs.Append("\r\n" + "{");


            if (thisCacheClassify4View.IsHasCacheClassfyFld == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}\", cls{0}EN._CurrTabName);",
                ViewMainTabName4GC, ThisClsName);
            }
            else if (thisCacheClassify4View.IsHasCacheClassfyFld2 == false)
            {
                if (thisCacheClassify4View.IsNumberType == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1}.value);",
                           ViewMainTabName4GC, thisCacheClassify4View.ViewVarName);

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1}.value);",
                         ViewMainTabName4GC, thisCacheClassify4View.ViewVarName);
                }
            }
            else
            {
                if (thisCacheClassify4View.IsNumberType == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}_{{2}}\", cls{0}EN._CurrTabName, {1}.value, {2}.value);",
                           ViewMainTabName4GC, thisCacheClassify4View.ViewVarName, thisCacheClassify4View.ViewVarName2);

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}_{{2}}\", cls{0}EN._CurrTabName, {1}.value, {2}.value);",
                         ViewMainTabName4GC, thisCacheClassify4View.ViewVarName, thisCacheClassify4View.ViewVarName2);
                }
            }

            if (thisCacheClassify4View.IsHasCacheClassfyFld == false)
            {

                strCodeForCs.AppendFormat("\r\n" + "const strMsg = `根据条件获取的${{this.thisTabName}}记录数为0!(Key=${{strKey}})`;",
                    ViewMainTabName4GC);
            }
            else if (thisCacheClassify4View.IsHasCacheClassfyFld2 == false)
            {

                strCodeForCs.AppendFormat("\r\n" + "const strMsg = `根据条件获取的${{this.thisTabName}}记录数为0!(Key=${{strKey}})`;",
                     ViewMainTabName4GC, ThisClsName, thisCacheClassify4View.FldName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const strMsg = `根据条件获取的${{this.thisTabName}}记录数为0!(Key=${{strKey}})`;",
                     ViewMainTabName4GC, ThisClsName, thisCacheClassify4View.FldName,
                     thisCacheClassify4View.FldName2);
            }
            strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
            strCodeForCs.Append("\r\n" + "//console.trace();");

            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"根据条件:[{{0}}]共获取对象列表数：{{1}}!\", strWhereCond, arr{0}ObjLst.length);",
            //    ViewMainTabName4GC);

            //strCodeForCs.Append("\r\n" + "//显示信息框");
            //strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const arrDataColumn: Array < clsDataColumn > =");
            strCodeForCs.Append("\r\n" + "       [");

            var arrExcelExportRegionFlds = objViewInfoENEx.arrExcelExportRegionFldSet.OrderBy(x => x.SeqNum);
            foreach (clsExcelExportRegionFldsENEx objDGRegionFldsENEx in arrExcelExportRegionFlds)
            {
                if (string.IsNullOrEmpty(objDGRegionFldsENEx.FldName)) continue;


                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "fldName: \"{0}\",", objDGRegionFldsENEx.PropertyName(this.IsFstLcase));
                strCodeForCs.AppendFormat("\r\n" + "sortBy: \"{0}\",", "");
                strCodeForCs.Append("\r\n" + "sortFun: SortFun,");
                strCodeForCs.Append("\r\n" + "getDataSource: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"{0}\",", objDGRegionFldsENEx.ColCaption);
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

            strCodeForCs.Append("\r\n" + "];");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "await this.ExtendFldFuncMap(arr{0}ExObjLst, arrDataColumn);", TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `扩展字段值的映射出错,${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = arr{0}ObjLst.sort(this.SortFunExportExcel);", TabName_Out4ExportExcel4GC);

            strCodeForCs.AppendFormat("\r\n" + "  this.CombineData(arr{0}ObjLst, arrDataColumn); ",
                TabName_Out4ExportExcel4GC, objKeyField.FldName);

            strCodeForCs.AppendFormat("\r\n" + "//console.log(\"完成BindGv_{0}!\");", TabName_Out4ExportExcel4GC);
            //strCodeForCs.Append("\r\n" + "resolve(jsonData);");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `绑定${this.thisTabName}对象列表不成功, ${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");

            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_Vue_Ts_SelectRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return Gen_WApi_Ts_SelectRecord(objvFunction4GeneCodeEN);

        }
        public string Gen_Vue_Ts_BindTab(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            if (objViewInfoENEx.arrDGRegionFldSet == null) return "";
            IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFlds_GridRegion = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.RegionId == objViewInfoENEx.objViewRegion_Feature.RegionId);
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.AppendFormat("\r\n /** 显示{0}对象的所有属性值", TabName_Out4ListRegion4GC);
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @param divContainer:显示容器，其中包括divDataLst,divPager, divDataLst显示数据, divPager显示分页");
            strCodeForCs.AppendFormat("\r\n * @param arr{0}ObjLst:需要绑定的对象列表",
                ViewMainTabName4GC);
            strCodeForCs.Append("\r\n" + " **/");

            strCodeForCs.AppendFormat("\r\n" + "public async BindTab_{0}(divContainer: HTMLDivElement, arr{0}ExObjLst: Array<cls{0}ENEx>) ",
                TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + "{");



            strCodeForCs.Append("\r\n" + "if (divContainer == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(Format(\"{0}不存在!\",divContainer));");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            
            //strCodeForCs.Append("\r\n" + "const sstrFldName: Array < string > = new Array<string>();");
            //strCodeForCs.Append("\r\n" + "const sstrColHeader: Array < string > = new Array<string>();");
            //strCodeForCs.Append("\r\n" + "sstrFldName.push(\"IdentityID\"); sstrColHeader.push(\"身份Id\");");
            strCodeForCs.Append("\r\n" + "const arrDataColumn: Array < clsDataColumn > =");
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

                string strSortBy = "";

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
                else
                {
                    strSortBy = objDGRegionFldsENEx.SortExpression_FstLcase(this.IsFstLcase);
                }

                strCodeForCs.Append("\r\n" + "{");
                var objPrjTabFld = clsPrjTabFldBLEx.GetObjByTabIdAndFldIdCache(objDGRegionFldsENEx.ObjPrjTab_PC().TabId, objDGRegionFldsENEx.FldId, objViewInfoENEx.PrjId);
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
            if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.UpdateRecord_Gv_0174).Count() > 0)  //在DG中是否有修改按钮
            {

                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "fldName: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "sortBy: \"\",");
                strCodeForCs.Append("\r\n" + "sortFun: SortFun,");
                strCodeForCs.Append("\r\n" + "getDataSource: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"修改\",");
                strCodeForCs.Append("\r\n" + "text: \"修改\",");
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
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"删除\",");
                strCodeForCs.Append("\r\n" + "text: \"删除\",");
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
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"详细信息\",");
                strCodeForCs.Append("\r\n" + "text: \"详细信息\",");
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
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"选择\",");
                strCodeForCs.Append("\r\n" + "text: \"选择\",");
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
            strCodeForCs.Append("\r\n" + $"if (ref{ThisListClsName}.value != null){{");

            if (objPrjTabEx_ListRegion.arrKeyFldSet.Count > 1)
            {

                if (strSqlDsTypeId4ListRegion == enumSQLDSType.SqlView_02)
                {
                    strCodeForCs.AppendFormat("\r\n" + "await BindTabByList(arr{0}ExObjLst, this.dispAllErrMsg_q); ",
                     TabName_Out4ListRegion4GC);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "await BindTabByList(arr{0}ExObjLst, this.dispAllErrMsg_q); ",
                        TabName_Out4ListRegion4GC);
                }
            }
            else
            {
                if (strSqlDsTypeId4ListRegion == enumSQLDSType.SqlView_02)
                {
                    strCodeForCs.AppendFormat("\r\n" + "await BindTabByList(arr{0}ExObjLst, this.dispAllErrMsg_q); ",
                     TabName_Out4ListRegion4GC);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "await BindTabByList(arr{0}ExObjLst, this.dispAllErrMsg_q); ",
                        TabName_Out4ListRegion4GC);
                }
            }
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else {");
            strCodeForCs.Append("\r\n" + $"const divDataLst = GetDivObjInDivObj(divContainer, 'divDataLst');");
            AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetDivObjInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);
            strCodeForCs.Append("\r\n" + "if (divDataLst == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"alert(\"在BindTab_{TabName_Out4ListRegion4GC}函数中，divDataLst不存在!\");");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            if (objPrjTabEx_ListRegion.arrKeyFldSet.Count > 1)
            {

                if (strSqlDsTypeId4ListRegion == enumSQLDSType.SqlView_02)
                {
                    strCodeForCs.AppendFormat("\r\n" + "await BindTab_KeyLst_V(divDataLst, arr{0}ExObjLst, arrDataColumn,  arrKeyLst, this); ",
                     TabName_Out4ListRegion4GC, objKeyField.FldName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "await BindTab_KeyLst(divDataLst, arr{0}ExObjLst, arrDataColumn, arrKeyLst, this); ",
                        TabName_Out4ListRegion4GC, objKeyField.FldName);
                }
            }
            else
            {
                if (strSqlDsTypeId4ListRegion == enumSQLDSType.SqlView_02)
                {
                    strCodeForCs.AppendFormat("\r\n" + "await BindTab_V(divDataLst, arr{0}ExObjLst, arrDataColumn,  cls{0}EN.con_{1}, this); ",
                     TabName_Out4ListRegion4GC, objKeyField.FldName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "await BindTab(divDataLst, arr{0}ExObjLst, arrDataColumn,  cls{0}EN.con_{1}, this); ",
                        TabName_Out4ListRegion4GC, objKeyField.FldName);
                }
            }


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + $"if (this.objPager.IsInit(divContainer, this.divName4Pager) == false)");
            strCodeForCs.Append("\r\n" + $"this.objPager.InitShow(divContainer, this.divName4Pager);");
            strCodeForCs.Append("\r\n" + "this.objPager.recCount = this.recCount;");
            strCodeForCs.Append("\r\n" + "this.objPager.pageSize = this.pageSize;");
            //strCodeForCs.Append("\r\n" + "this.objPager.ShowPager();");
            strCodeForCs.Append("\r\n" + $"this.objPager.ShowPagerV2(divContainer, this, this.divName4Pager);");
            //strCodeForCs.Append("\r\n" + "$(\"#divPager\").load(\"../PubWebClass/pager.html\");");
            strCodeForCs.Append("\r\n" + "}");
            if (bolIsGeneDispAllErrMsg == false)
            {
                bolIsGeneDispAllErrMsg = true;
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.Append("\r\n" + "* 是否显示所有错误");
                strCodeForCs.Append("\r\n" + "**/");
                strCodeForCs.Append("\r\n" + "public get dispAllErrMsg_q(): boolean {");
                strCodeForCs.Append("\r\n" + "return true;");
                strCodeForCs.Append("\r\n" + "}");
            }
            return strCodeForCs.ToString();


        }


        public string Gen_Vue_Ts_BindTab4FuncBak(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (this.IsUseFunc == false) return "";

            IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFlds_GridRegion = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.RegionId == objViewInfoENEx.objViewRegion_Feature.RegionId);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.AppendFormat("\r\n /** 显示{0}对象的所有属性值", TabName_Out4ListRegion4GC);
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @param divContainer:显示容器");
            strCodeForCs.AppendFormat("\r\n * @param arr{0}ExObjLst:需要绑定的对象列表",
                ViewMainTabName4GC);
            strCodeForCs.Append("\r\n" + " **/");

            strCodeForCs.AppendFormat("\r\n" + "public async BindTab_{0}4Func(divContainer: HTMLDivElement, arr{0}ExObjLst: Array<cls{0}ENEx>) ",
                TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.BindTab_{0}4Func.name;", TabName_Out4ListRegion4GC);


            strCodeForCs.Append("\r\n" + "if (divContainer == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(Format(\"{0}不存在!\",divContainer));");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "];");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "await this.ExtendFldFuncMap(arr{0}ExObjLst, arrDataColumn);", TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `扩展字段值的映射出错,${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            if (objPrjTabEx_ListRegion.arrKeyFldSet.Count > 1)
            {
                //int intIndex = 0;
                //foreach (var objInFor in objPrjTabEx_ListRegion.arrKeyFldSet)
                //{
                //    if (intIndex == 0)
                //    {
                //        strCodeForCs.AppendFormat("\r\n" + " const arrKeyLst = [cls{0}EN.con_{1} ",
                //            TabName_Out4ListRegion4GC, objInFor.ObjFieldTab0().FldName);
                //    }
                //    else
                //    {
                //        strCodeForCs.AppendFormat(", cls{0}EN.con_{1}", TabName_Out4ListRegion4GC, objInFor.ObjFieldTab0().FldName);
                //    }
                //    intIndex++;
                //}
                //strCodeForCs.Append("];");

                //let arrKeyLst = [clsUserCodePrjMainPath_MachineNameEN.con_UserCodePrjMainPathId, clsUserCodePrjMainPath_MachineNameEN.con_MachineName];

                if (strSqlDsTypeId4ListRegion == enumSQLDSType.SqlView_02)
                {
                    strCodeForCs.AppendFormat("\r\n" + "await BindTabByList(arr{0}ExObjLst, this.dispAllErrMsg_q); ",
                     TabName_Out4ListRegion4GC);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "await BindTabByList(arr{0}ExObjLst, this.dispAllErrMsg_q); ",
                     TabName_Out4ListRegion4GC);
                }
            }
            else
            {
                if (strSqlDsTypeId4ListRegion == enumSQLDSType.SqlView_02)
                {
                    strCodeForCs.AppendFormat("\r\n" + "await BindTabByList(arr{0}ExObjLst, this.dispAllErrMsg_q); ",
                     TabName_Out4ListRegion4GC);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "await BindTabByList(arr{0}ExObjLst, this.dispAllErrMsg_q); ",
                     TabName_Out4ListRegion4GC);
                }
            }

            strCodeForCs.Append("\r\n" + $"if (this.objPager.IsInit(divContainer, this.divName4Pager) == false)");
            strCodeForCs.Append("\r\n" + $"this.objPager.InitShow(divContainer, this.divName4Pager);");
            strCodeForCs.Append("\r\n" + "this.objPager.recCount = this.recCount;");
            strCodeForCs.Append("\r\n" + "this.objPager.pageSize = this.pageSize;");
            strCodeForCs.Append("\r\n" + $"this.objPager.ShowPagerV2(divContainer, this, this.divName4Pager);");
            //strCodeForCs.Append("\r\n" + "$(\"#divPager\").load(\"../PubWebClass/pager.html\");");
            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }

        public string Gen_Vue_Ts_BindTab4Func(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (this.IsUseFunc == false) return "";

            IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFlds_GridRegion = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.RegionId == objViewInfoENEx.objViewRegion_Feature.RegionId);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.AppendFormat("\r\n /** 显示{0}对象的所有属性值", TabName_Out4ListRegion4GC);
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @param divContainer:显示容器");
            strCodeForCs.AppendFormat("\r\n * @param arr{0}ExObjLst:需要绑定的对象列表",
                ViewMainTabName4GC);
            strCodeForCs.Append("\r\n" + " **/");

            strCodeForCs.AppendFormat("\r\n" + "public async BindTab_{0}4Func(divContainer: HTMLDivElement, arr{0}ExObjLst: Array<cls{0}ENEx>) ",
                TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.BindTab_{0}4Func.name;", TabName_Out4ListRegion4GC);


            strCodeForCs.Append("\r\n" + "if (divContainer == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(Format(\"{0}不存在!\",divContainer));");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.Append("\r\n" + "const sstrFldName: Array < string > = new Array<string>();");
            //strCodeForCs.Append("\r\n" + "const sstrColHeader: Array < string > = new Array<string>();");
            //strCodeForCs.Append("\r\n" + "sstrFldName.push(\"IdentityID\"); sstrColHeader.push(\"身份Id\");");
            strCodeForCs.Append("\r\n" + "const arrDataColumn: Array < clsDataColumn > =");
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
            if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.UpdateRecord_Gv_0174).Count() > 0)  //在DG中是否有修改按钮
            {

                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "fldName: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "sortBy: \"\",");
                strCodeForCs.Append("\r\n" + "sortFun: SortFun,");
                strCodeForCs.Append("\r\n" + "getDataSource: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"修改\",");
                strCodeForCs.Append("\r\n" + "text: \"修改\",");
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
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"删除\",");
                strCodeForCs.Append("\r\n" + "text: \"删除\",");
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
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"详细信息\",");
                strCodeForCs.Append("\r\n" + "text: \"详细信息\",");
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
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"选择\",");
                strCodeForCs.Append("\r\n" + "text: \"选择\",");
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
            strCodeForCs.Append("\r\n" + "const strMsg = `扩展字段值的映射出错,${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + $"if (ref{ThisListClsName}.value != null){{");
            
            if (objPrjTabEx_ListRegion.arrKeyFldSet.Count > 1)
            {
                
                if (strSqlDsTypeId4ListRegion == enumSQLDSType.SqlView_02)
                {
                    strCodeForCs.AppendFormat("\r\n" + "await BindTabByList(arr{0}ExObjLst, this.dispAllErrMsg_q); ",
                                        TabName_Out4ListRegion4GC);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "await BindTabByList(arr{0}ExObjLst, this.dispAllErrMsg_q); ",
                                        TabName_Out4ListRegion4GC);
                }
            }
            else
            {
                if (strSqlDsTypeId4ListRegion == enumSQLDSType.SqlView_02)
                {
                    strCodeForCs.AppendFormat("\r\n" + "await BindTabByList(arr{0}ExObjLst, this.dispAllErrMsg_q); ",
                                        TabName_Out4ListRegion4GC);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "await BindTabByList(arr{0}ExObjLst, this.dispAllErrMsg_q); ",
                                        TabName_Out4ListRegion4GC);
                }
            }
                   strCodeForCs.Append("\r\n" + "}");
   strCodeForCs.Append("\r\n" + "else {");
            strCodeForCs.Append("\r\n" + $"const divDataLst = GetDivObjInDivObj(divContainer, 'divDataLst');");
            AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetDivObjInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);
            strCodeForCs.Append("\r\n" + "if (divDataLst == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + $"alert(\"在BindTab_{TabName_Out4ListRegion4GC}4Func函数中，divDataLst不存在!\");");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            if (objPrjTabEx_ListRegion.arrKeyFldSet.Count > 1)
            {
                int intIndex = 0;
                foreach (var objInFor in objPrjTabEx_ListRegion.arrKeyFldSet)
                {
                    if (intIndex == 0)
                    {
                        strCodeForCs.AppendFormat("\r\n" + " const arrKeyLst = [cls{0}EN.con_{1} ",
                            TabName_Out4ListRegion4GC, objInFor.ObjFieldTab0().FldName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat(", cls{0}EN.con_{1}", TabName_Out4ListRegion4GC, objInFor.ObjFieldTab0().FldName);
                    }
                    intIndex++;
                }
                strCodeForCs.Append("];");

                //let arrKeyLst = [clsUserCodePrjMainPath_MachineNameEN.con_UserCodePrjMainPathId, clsUserCodePrjMainPath_MachineNameEN.con_MachineName];

                if (strSqlDsTypeId4ListRegion == enumSQLDSType.SqlView_02)
                {
                    strCodeForCs.AppendFormat("\r\n" + "await BindTab_KeyLst_V(divDataLst, arr{0}ExObjLst, arrDataColumn,  arrKeyLst, this); ",
                     TabName_Out4ListRegion4GC, objKeyField.FldName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "await BindTab_KeyLst(divDataLst, arr{0}ExObjLst, arrDataColumn, arrKeyLst, this); ",
                        TabName_Out4ListRegion4GC, objKeyField.FldName);
                }
            }
            else
            {
                if (strSqlDsTypeId4ListRegion == enumSQLDSType.SqlView_02)
                {
                    strCodeForCs.AppendFormat("\r\n" + "await BindTab_V(divDataLst, arr{0}ExObjLst, arrDataColumn,  cls{0}EN.con_{1}, this); ",
                     TabName_Out4ListRegion4GC, objKeyField.FldName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "await BindTab(divDataLst, arr{0}ExObjLst, arrDataColumn,  cls{0}EN.con_{1}, this); ",
                        TabName_Out4ListRegion4GC, objKeyField.FldName);
                }
            }


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + $"if (this.objPager.IsInit(divContainer, this.divName4Pager) == false)");
            strCodeForCs.Append("\r\n" + $"this.objPager.InitShow(divContainer, this.divName4Pager);");
            strCodeForCs.Append("\r\n" + "this.objPager.recCount = this.recCount;");
            strCodeForCs.Append("\r\n" + "this.objPager.pageSize = this.pageSize;");
            strCodeForCs.Append("\r\n" + $"this.objPager.ShowPagerV2(divContainer, this, this.divName4Pager);");
            //strCodeForCs.Append("\r\n" + "$(\"#divPager\").load(\"../PubWebClass/pager.html\");");
            strCodeForCs.Append("\r\n" + "}");
            if (bolIsGeneDispAllErrMsg == false)
            {
                bolIsGeneDispAllErrMsg = true;
            strCodeForCs.Append("\r\n" + "/**");
            strCodeForCs.Append("\r\n" + "* 是否显示所有错误");
            strCodeForCs.Append("\r\n" + "**/");
            strCodeForCs.Append("\r\n" + "public get dispAllErrMsg_q(): boolean {");
            strCodeForCs.Append("\r\n" + "return true;");
            strCodeForCs.Append("\r\n" + "}");
            }
            return strCodeForCs.ToString();
        }

        public string Gen_Vue_Ts_ExtendFldFuncMap(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return Gen_WApi_Ts_ExtendFldFuncMap(objvFunction4GeneCodeEN);
        }
        public string Gen_Vue_Ts_BindGv(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return Gen_WApi_Ts_BindGv(objvFunction4GeneCodeEN);
        }
        public string Gen_Vue_Ts_BindGvCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return Gen_WApi_Ts_BindGvCache(objvFunction4GeneCodeEN);
        }

        public string Gen_Vue_Ts_ExportExcel(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return Gen_WApi_Ts_ExportExcel(objvFunction4GeneCodeEN);
        }
        public string Gen_Vue_Ts_ShowTabObj(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return Gen_WApi_Ts_ShowTabObj(objvFunction4GeneCodeEN);
        }


        public string Gen_Vue_Ts_BindGv4Func(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (this.IsUseFunc == false) return "";
            if (PrjTabEx_ListRegion.IsUseStorageCache_TS() == false)
            {
                return Gen_Vue_Ts_BindGv4Func_NoCache(objvFunction4GeneCodeEN);
            }
            string strIsShare = "";
            if (objViewInfoENEx.IsShare) strIsShare = "Share";
            var objFuncParaLst = new FuncParaLst("BindGv4Func", this.IsFstLcase, enumAppLevel.InvokeFunc);
            List<string> arrCondFldId = new List<string>();
            objFuncParaLst.AddParaByCacheClassify(thisCacheClassify_List_TS, arrCondFldId, enumProgLangType.TypeScript_09);

            //string strFuncParaLst = objFuncParaLst.GetCondFldLst4Para();
            List<string> arrVarNameLst = new List<string>();
            if (thisCacheClassify4View.IsHasCacheClassfyFld == true)
            {
                var strViewVarName = $"{thisCacheClassify4View.ViewVarName}.value";
                arrVarNameLst.Add(strViewVarName);
                AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{objViewInfoENEx.TabName}VueShare", thisCacheClassify4View.ViewVarName, enumImportObjType.CustomFunc, "");

            }
            if (thisCacheClassify4View.IsHasCacheClassfyFld2 == true)
            {
                var strViewVarName = $"{thisCacheClassify4View.ViewVarName2}.value";
                arrVarNameLst.Add(strViewVarName);
                AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{objViewInfoENEx.TabName}VueShare", thisCacheClassify4View.ViewVarName2, enumImportObjType.CustomFunc, "");

            }
            string strCondFldLst_Cache = string.Join(",", arrVarNameLst);
            //string strCheckEmptyCode = objFuncParaLst.Gc_CheckVarEmpty_Ts(this.ClsName, strFuncName, true, this, this.strBaseUrl);
            if (strCondFldLst_Cache.Length > 0) strCondFldLst_Cache = "," + strCondFldLst_Cache;

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 根据条件获取相应的对象列表");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");

            strCodeForCs.AppendFormat("\r\n" + "public async BindGv_{0}4Func(divList: HTMLDivElement) ",
                TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.BindGv_{0}4Func.name;", TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + $"if (viewVarSet.sort{TabName_Out4ListRegion4GC}By == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"在显示列表时,排序字段(sort{0}By)为空,请检查!(In BindGv_{0}Cache)\");", TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
            //strCodeForCs.Append("\r\n" + $"const divDataLst = GetDivObjInDivObj(divList, 'divDataLst');");
            //AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetDivObjInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);
            if (PrjTabEx_ListRegion.IsUseStoreCache_TS() == true)
            {
                strCodeForCs.AppendFormat("\r\n" + "const strWhereCond = await Combine{0}Condition();", TabName_Out4ListRegion4GC);
                AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{objViewInfoENEx.TabName}VueShare", $"Combine{TabName_Out4ListRegion4GC}Condition", enumImportObjType.CustomFunc, "");

            }
            else if (PrjTabEx_ListRegion.IsUseStorageCache_TS() == true)
            {
                strCodeForCs.AppendFormat("\r\n" + "const obj{0}Cond = await Combine{0}ConditionObj();", TabName_Out4ListRegion4GC);
                AddImportClass("", $"@/views{strIsShare}/{objFuncModuleEN.FuncModuleEnName}/{objViewInfoENEx.TabName}VueShare", $"Combine{TabName_Out4ListRegion4GC}ConditionObj", enumImportObjType.CustomFunc, "");

                if (thisCacheClassify4View.IsHasCacheClassfyFld == true && thisCacheClassify4View.IsForExtendClass == false)
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue(cls{0}EN.con_{1}, {2}.value, \"=\");",
                            TabName_Out4ListRegion4GC,
                            thisCacheClassify4View.FldName,
                                thisCacheClassify4View.ViewVarName);
                }
                if (thisCacheClassify4View.IsHasCacheClassfyFld2 == true && thisCacheClassify4View.IsForExtendClass2 == false)
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}Cond.SetCondFldValue(cls{0}EN.con_{1}, {2}.value, \"=\");",
                            TabName_Out4ListRegion4GC,
                            thisCacheClassify4View.FldName2,
                                thisCacheClassify4View.ViewVarName2);
                }

                strCodeForCs.AppendFormat("\r\n" + "const strWhereCond = JSON.stringify(obj{0}Cond);", TabName_Out4ListRegion4GC);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const strWhereCond = await Combine{0}Condition();", TabName_Out4ListRegion4GC);
                AddImportClass("", $"@/views/{objFuncModuleEN.FuncModuleEnName}/{ThisClsName}.vue", $"Combine{TabName_Out4ListRegion4GC}Condition", enumImportObjType.CustomFunc, "");

            }
            strCodeForCs.Append("\r\n" + "const intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页");

            strCodeForCs.AppendFormat("\r\n" + " let arr{0}ExObjLst: Array <cls{0}ENEx> = [];", TabName_Out4ListRegion4GC);
            AddImportClass(objViewInfoENEx.MainTabId, ViewMainTabName4GC, string.Format("cls{0}EN", ViewMainTabName4GC), enumImportObjType.ENExClass, this.strBaseUrl);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + GC_RecCount(enumRegionType.ListRegion_0002, strCondFldLst_Cache, true));

            //strCodeForCs.Append("\r\n" + $"this1.recCount = await {thisWA_F_InList(WA_F.GetRecCountByCondCache)}(obj{TabName_Out4ListRegion4GC}Cond {strCondFldLst_Cache});");


            strCodeForCs.Append("\r\n" + GC_GetObjExLst(enumRegionType.ListRegion_0002, strCondFldLst_Cache));


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `绑定GridView不成功,${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");

            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ExObjLst.length == 0)", TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + "{");

            if (thisCacheClassify4View.IsHasCacheClassfyFld == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}\", cls{0}EN._CurrTabName);",
                ViewMainTabName4GC, ThisClsName);
            }
            else if (thisCacheClassify4View.IsHasCacheClassfyFld2 == false)
            {
                if (thisCacheClassify4View.IsNumberType == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1}.value);",
                           ViewMainTabName4GC, thisCacheClassify4View.ViewVarName);

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1}.value);",
                         ViewMainTabName4GC, thisCacheClassify4View.ViewVarName);
                }
            }
            else
            {
                if (thisCacheClassify4View.IsNumberType == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}_{{2}}\", cls{0}EN._CurrTabName, {1}.value, {2}.value);",
                           ViewMainTabName4GC, thisCacheClassify4View.ViewVarName, thisCacheClassify4View.ViewVarName2);

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}_{{2}}\", cls{0}EN._CurrTabName, {1}.value, {2}.value);",
                         ViewMainTabName4GC, thisCacheClassify4View.ViewVarName, thisCacheClassify4View.ViewVarName2);
                }
            }

            if (thisCacheClassify4View.IsHasCacheClassfyFld == false)
            {

                strCodeForCs.AppendFormat("\r\n" + "const strMsg = `根据条件获取的${{this.thisTabName}}记录数为0!(Key=${{strKey}})`;",
                    ViewMainTabName4GC);
            }
            else if (thisCacheClassify4View.IsHasCacheClassfyFld2 == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "const strMsg = `根据条件获取的${{this.thisTabName}}记录数为0!(Key=${{strKey}})`;",
                     ViewMainTabName4GC, ThisClsName, thisCacheClassify4View.FldName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const strMsg = `根据条件获取的${{this.thisTabName}}记录数为0!(Key=${{strKey}})`;",
                     ViewMainTabName4GC, ThisClsName, thisCacheClassify4View.FldName,
                     thisCacheClassify4View.FldName2);
            }
            strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
            strCodeForCs.Append("\r\n" + "//console.trace();");
            //strCodeForCs.Append("\r\n" + "ShowEmptyRecNumInfoByDiv(divDataLst, strMsg);");
            strCodeForCs.Append("\r\n" + $"this.objPager.Hide(divList, this.divName4Pager);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}4Func(divList, arr{1}ExObjLst);",
                 objvFunction4GeneCodeEN.OrderNum, TabName_Out4ListRegion4GC);
            strCodeForCs.AppendFormat("\r\n" + "//console.log(\"完成BindGv_{0}4Func!\");", TabName_Out4ListRegion4GC);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `绑定${this.thisTabName}对象列表不成功, ${e}.(in ${this.constructor.name}.${strThisFuncName})`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");

            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_Vue_Ts_BindGv4Func_NoCache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (this.IsUseFunc == false) return "";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 根据条件获取相应的对象列表");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");

            strCodeForCs.AppendFormat("\r\n" + "public async BindGv_{0}4Func(divList: HTMLDivElement) ",
                TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.BindGv_{0}4Func.name;", TabName_Out4ListRegion4GC);
            strCodeForCs.AppendFormat("\r\n" + "if (viewVarSet.sort{0}By == null)", TabName_Out4ListRegion4GC, ThisClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"在显示列表时,排序字段(sort{0}By)为空,请检查!(In BindGv_{0}Cache)\");", TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + GC_WhereCondition(enumRegionType.ListRegion_0002, true));

            strCodeForCs.Append("\r\n" + "const intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页");

            strCodeForCs.AppendFormat("\r\n" + " let arr{0}ExObjLst: Array <cls{0}ENEx> = [];", TabName_Out4ListRegion4GC);
            AddImportClass(objViewInfoENEx.MainTabId, ViewMainTabName4GC, string.Format("cls{0}EN", ViewMainTabName4GC), enumImportObjType.ENExClass, this.strBaseUrl);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + GC_RecCount(enumRegionType.ListRegion_0002, "", true));

            //strCodeForCs.Append("\r\n" + $"this1.recCount = await {thisWA_F_InList(WA_F.GetRecCountByCondAsync)}(strWhereCond);");

            strCodeForCs.Append("\r\n" + GC_GetObjExLst(enumRegionType.ListRegion_0002, ""));

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `绑定GridView不成功,${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");

            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ExObjLst.length == 0)", TabName_Out4ListRegion4GC);
            strCodeForCs.Append("\r\n" + "{");

            if (thisCacheClassify4View.IsHasCacheClassfyFld == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}\", cls{0}EN._CurrTabName);",
                ViewMainTabName4GC, ThisClsName);
            }
            else if (thisCacheClassify4View.IsHasCacheClassfyFld2 == false)
            {
                if (thisCacheClassify4View.IsNumberType == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1}.value);",
                           ViewMainTabName4GC, thisCacheClassify4View.ViewVarName);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}\", cls{0}EN._CurrTabName, {1}.value);",
                         ViewMainTabName4GC, thisCacheClassify4View.ViewVarName);
                }
            }
            else
            {
                if (thisCacheClassify4View.IsNumberType == true)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}_{{2}}\", cls{0}EN._CurrTabName, {1}.value, {2}.value);",
                           ViewMainTabName4GC, thisCacheClassify4View.ViewVarName, thisCacheClassify4View.ViewVarName2);

                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{{0}}_{{1}}_{{2}}\", cls{0}EN._CurrTabName, {1}.value, {2}.value);",
                         ViewMainTabName4GC, thisCacheClassify4View.ViewVarName, thisCacheClassify4View.ViewVarName2);
                }
            }

            if (thisCacheClassify4View.IsHasCacheClassfyFld == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "const strMsg = `根据条件获取的${{this.thisTabName}}记录数为0!(Key=${{strKey}})`;",
                    ViewMainTabName4GC);
            }
            else if (thisCacheClassify4View.IsHasCacheClassfyFld2 == false)
            {
                strCodeForCs.AppendFormat("\r\n" + "const strMsg = `根据条件获取的${{this.thisTabName}}记录数为0!(Key=${{strKey}})`;",
                     ViewMainTabName4GC, ThisClsName, thisCacheClassify4View.FldName);
            }
            else
            {

                strCodeForCs.AppendFormat("\r\n" + "const strMsg = `根据条件获取的${{this.thisTabName}}记录数为0!(Key=${{strKey}})`;",
                     ViewMainTabName4GC, ThisClsName, thisCacheClassify4View.FldName,
                     thisCacheClassify4View.FldName2);
            }
            strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
            strCodeForCs.Append("\r\n" + "//console.trace();");

            //strCodeForCs.Append("\r\n" + "ShowEmptyRecNumInfoByDiv(divDataLst, strMsg);");

            strCodeForCs.Append("\r\n" + $"this.objPager.Hide(divList, this.divName4Pager);");
            //strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}4Func(divList, arr{1}ExObjLst);",
                 objvFunction4GeneCodeEN.OrderNum, TabName_Out4ListRegion4GC);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = `绑定${this.thisTabName}对象列表不成功, ${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");

            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }



        public string Gen_Vue_Ts_CombineData4Func(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return Gen_WApi_Ts_CombineData4Func(objvFunction4GeneCodeEN);

        }


        public string Gen_Vue_Ts_CombineData(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return Gen_WApi_Ts_CombineData(objvFunction4GeneCodeEN);

        }


        public string Gen_Vue_Ts_btnQuery_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return Gen_WApi_Ts_btnQuery_Click(objvFunction4GeneCodeEN);
        }

        public string Gen_Vue_Ts_btnExportExcel_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return Gen_WApi_Ts_btnExportExcel_Click(objvFunction4GeneCodeEN);

        }



        public string Gen_Vue_Ts_btnDelRecordBySign_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return Gen_WApi_Ts_btnDelRecordBySign_Click(objvFunction4GeneCodeEN);

        }

        public string Gen_Vue_Ts_btnUnDelRecordBySign_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return Gen_WApi_Ts_btnUnDelRecordBySign_Click(objvFunction4GeneCodeEN);

        }


        public string Gen_Vue_Ts_btnDelRecord_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return Gen_WApi_Ts_btnDelRecord_Click(objvFunction4GeneCodeEN);

        }

        public string Gen_Vue_Ts_GetCurrPageIndex()
        {
            return Gen_WApi_Ts_GetCurrPageIndex();
        }
        public string Gen_Vue_Ts_ShowEmptyRecNumInfo()
        {
            return Gen_WApi_Ts_ShowEmptyRecNumInfo();
        }

        public string Gen_Vue_Ts_IndexPage()
        {
            return Gen_WApi_Ts_IndexPage();
        }
        public string Gen_Vue_Ts_BindInDiv()
        {
            return Gen_WApi_Ts_BindInDiv();
        }

        public string Gen_Vue_Ts_SetCurrPageIndex()
        {
            return Gen_WApi_Ts_SetCurrPageIndex();
        }

        public string Gen_Vue_Ts_PrevPage()
        {
            return Gen_WApi_Ts_PrevPage();
        }

        public string Gen_Vue_Ts_NextPage()
        {
            return Gen_WApi_Ts_NextPage();
        }



        public string Gen_Vue_Ts_btnDelRecordInTab_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return Gen_WApi_Ts_btnDelRecordInTab_Click(objvFunction4GeneCodeEN);

        }

        public string Gen_Vue_Ts_btnSelectRecordInTab_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return Gen_WApi_Ts_btnSelectRecordInTab_Click(objvFunction4GeneCodeEN);


        }


        public string Gen_Vue_Ts_btnDetailRecordInTab_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return Gen_WApi_Ts_btnDetailRecordInTab_Click(objvFunction4GeneCodeEN);
        }


        //public string Gen_Vue_Ts_btnUpdateRecordInTab_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        //{
        //    return Gen_WApi_Ts_btnUpdateRecordInTab_Click(objvFunction4GeneCodeEN);
        //}




        public string Gen_Vue_Ts_DelMultiRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return Gen_WApi_Ts_DelMultiRecord(objvFunction4GeneCodeEN);
        }


        public string Gen_Vue_Ts_DelRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return Gen_WApi_Ts_DelRecord(objvFunction4GeneCodeEN);
        }

        //public string Gen_Vue_Ts_btnAddNewRecord_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        //{
        //    return Gen_WApi_Ts_btnAddNewRecord_Click(objvFunction4GeneCodeEN);
        //}

        Func<clsViewFeatureFldsENEx, ASPDropDownListEx> GetDdlObj2 = obj => clsASPDropDownListBLEx.GetDropDownLst_Asp(obj, new clsGetTabFieldObj());

        public string Gen_Vue_Ts_CombineCondition(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return Gen_WApi_Ts_CombineCondition(objvFunction4GeneCodeEN);
        }

        public string Gen_Vue_Ts_CombineConditionObj(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return Gen_WApi_Ts_CombineConditionObj(objvFunction4GeneCodeEN);

        }
        public string Gen_Vue_Ts_GetConditionInFldValueLst(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return Gen_WApi_Ts_GetConditionInFldValueLst(objvFunction4GeneCodeEN);

        }


        public string Gen_Vue_Ts_CombineConditionObj4ExportExcel(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return Gen_WApi_Ts_CombineConditionObj4ExportExcel(objvFunction4GeneCodeEN);

        }

        public string Gen_Vue_Ts_GetFirstKey()
        {
            return Gen_WApi_Ts_GetFirstKey();

        }
        public string Gen_Vue_Ts_SortBy()
        {
            return Gen_WApi_Ts_SortBy();

        }

        //public string Gen_Vue_Ts_IndexPage()
        //{
        //    return Gen_WApi_Ts_IndexPage();

        //}

        //public string Gen_Vue_Ts_PrevPage()
        //{
        //    return Gen_WApi_Ts_PrevPage();

        //}

        //public string Gen_Vue_Ts_NextPage()
        //{
        //    return Gen_WApi_Ts_NextPage();

        //}

        /// <summary>
        /// 定义用于编辑的层Div,该层可以被弹出
        /// </summary>
        /// <param name="objvFunction4GeneCodeEN"></param>
        /// <returns></returns>
        public string Gen_Vue_Ts_DefDiv4EditRegion()
        {
            return Gen_WApi_Ts_DefDiv4EditRegion();

        }

        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            return A_GeneFuncCodeBase(objvFunction4GeneCodeEN, typeof(Vue_ViewScriptCS_TS4TypeScript));

        }
        public override void GetClsName()
        {
            //this.ClsName = string.Format("WApi{0}_QUDI_TS", objViewInfoENEx.TabName);
            //ThisClsName = this.ClsName;

            this.ClsName = objViewInfoENEx.ViewName;
            objViewInfoENEx.ClsName = this.ClsName;
        }
        public override string GeneCode4Function(string strFuncId4GC, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;
            string strTemp; //临时变量;
            string strFuncName = "";
            try
            {
                //类名开始
                clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GCCacheEx(strFuncId4GC);
                strFuncName = objvFunction4GeneCodeEN.FuncName;

                if (strFuncName.Substring(0, 6) == "Print:")
                {
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n" + "");
                    strCodeForCs.Append("\r\n " + strFuncName.Substring(6));
                    return strCodeForCs.ToString();
                }

                if (objvFunction4GeneCodeEN.FuncTypeId == "10")//用户自定义函数
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
                string strMsg = string.Format("在生成函数:[{0}]时出错。错误信息:{1}.({2})", strFuncName,
                    objException.Message,
                    clsStackTrace.GetCurrClassFunction());
                clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }
        public string Gen_Vue_Ts_btnCopyRecord_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            return Gen_WApi_Ts_btnCopyRecord_Click(objvFunction4GeneCodeEN);

        }

        public string Gen_Vue_Ts_btnSetFldValue_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            if (strFuncName4BindGv == "") return "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFldsObjLst = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.FeatureId == "0148");
                foreach (clsFeatureRegionFldsENEx objInFor in arrFeatureRegionFldsObjLst)
                {

                    clsFieldTabEN objFieldTabEN = clsFieldTabBL.GetObjByFldIdCache(objInFor.ReleFldId, objInFor.PrjId());
                    string strFuncName = string.Format("{0}", objInFor.ButtonName.Substring(3));
                    strCodeForCs.AppendFormat("\r\n /** 设置字段值-{0}", objFieldTabEN.FldName);
                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n **/");

                    strCodeForCs.AppendFormat("\r\n" + "public async {0}_Click() {{", objInFor.ButtonName);
                    strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.{0}_Click.name;", objInFor.ButtonName);
                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + $"const arrKeyIds = GetCheckedKeyIdsInDivObj(divVarSet.refDivList);");
                    AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetCheckedKeyIdsInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                    strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + $"alert(`请选择需要设置{objInFor.ObjFieldTabENEx.Caption}的${{this.thisTabName}}记录!`);");
                    strCodeForCs.Append("\r\n" + "return \"\";");
                    strCodeForCs.Append("\r\n" + "}");

                    clsViewFeatureFldsENEx objViewFeatureFlds = null;
                    if (objInFor.ValueGivingModeId == enumValueGivingMode.GivenValue_02)
                    {
                        List<clsViewFeatureFldsENEx> arrViewFeatureFlds = objViewInfoENEx.arrViewFeatureFlds.Where(x =>
                               x.ViewFeatureId == objInFor.ViewFeatureId).ToList();
                        if (arrViewFeatureFlds.Count == 0)
                        {
                            throw new Exception("功能：设置字段值的给值方式是给定值,但缺少相应的界面功能字段,请维护后再生成代码");
                        }
                        objViewFeatureFlds = arrViewFeatureFlds[0];

                    }
                    if (objInFor.FeatureId == enumPrjFeature.SetFieldValue_0148
        && objInFor.ValueGivingModeId == enumValueGivingMode.GivenValue_02)
                    {
                        List<clsViewFeatureFldsENEx> arrViewFeatureFlds = objViewInfoENEx.arrViewFeatureFlds.Where(x =>
                        x.ViewFeatureId == objInFor.ViewFeatureId).ToList();
                        if (arrViewFeatureFlds.Count == 0)
                        {
                            throw new Exception("功能：设置字段值的给值方式是给定值,但缺少相应的界面功能字段,请维护后再生成代码");
                        }

                        objViewFeatureFlds = arrViewFeatureFlds[0];
                        ASPControlEx objASPControlENEx = clsASPControlBLEx.GetControl_Asp(objViewFeatureFlds);

                        string strCtrlId = objASPControlENEx.CtrlId.Replace("SetFldValue_SetFldValue", "SetFldValue");
                        switch (objViewFeatureFlds.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType)
                        {
                            case "Number":
                                strCodeForCs.Append("\r\n" + $"const str{objViewFeatureFlds.ObjFieldTabENEx.FldName} = GetSelectValueInDivObj(divVarSet.refDivFunction, \"{strCtrlId}\");");
                                AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetSelectValueInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                                strCodeForCs.AppendFormat("\r\n" + "if (str{0} == \"\")",
                                            objViewFeatureFlds.ObjFieldTabENEx.FldName);

                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"请输入{0}({1})!\";",
                                    objViewFeatureFlds.ObjFieldTabENEx.Caption,
                                    objViewFeatureFlds.ObjFieldTabENEx.FldName);
                                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                                strCodeForCs.Append("\r\n" + "//console.trace();");
                                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                                strCodeForCs.Append("\r\n" + "return;");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.AppendFormat("\r\n" + "//console.log('str{0}=' + str{0});", objViewFeatureFlds.ObjFieldTabENEx.FldName);

                                strCodeForCs.AppendFormat("\r\n" + "const {0} = Number(str{1});",
                                    objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName,
                                    objViewFeatureFlds.ObjFieldTabENEx.FldName); break;
                            case "boolean":
                                if (objViewFeatureFlds.CtlTypeId == enumCtlType.CheckBox_02)
                                {
                                    strCodeForCs.Append("\r\n" + $"const {objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName} = GetCheckBoxValueInDivObj(divVarSet.refDivFunction, '{strCtrlId}');");
                                    AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetCheckBoxValueInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "const {0}: boolean = $(\"#{1}\").prop(\"checked\");",
                      objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName,
                      strCtrlId);
                                }
                                strCodeForCs.AppendFormat("\r\n" + "//console.log('{0}=' + {0});", objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);

                                break;
                            default:
                                strCodeForCs.Append("\r\n" + $"const str{objViewFeatureFlds.ObjFieldTabENEx.FldName} = GetSelectValueInDivObj(divVarSet.refDivFunction, \"{strCtrlId}\");");
                                AddImportClass("", "/PubFun/clsCommFunc4Ctrl.js", "GetSelectValueInDivObj", enumImportObjType.CustomFunc, this.strBaseUrl);

                                strCodeForCs.AppendFormat("\r\n" + "if (str{0} == \"\")",
                                            objViewFeatureFlds.ObjFieldTabENEx.FldName);

                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"请输入{0}({1})!\";",
                                    objViewFeatureFlds.ObjFieldTabENEx.Caption,
                                    objViewFeatureFlds.ObjFieldTabENEx.FldName);
                                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                                strCodeForCs.Append("\r\n" + "//console.trace();");
                                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                                strCodeForCs.Append("\r\n" + "return;");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.AppendFormat("\r\n" + "//console.log('str{0}=' + str{0});", objViewFeatureFlds.ObjFieldTabENEx.FldName);
                                break;
                        }
                        strCodeForCs.Append("\r\n" + "//console.log('arrKeyIds=');");
                        strCodeForCs.Append("\r\n" + "//console.log(arrKeyIds);");
                        if (objViewFeatureFlds.ObjFieldTabENEx.IsNumberType())
                        {
                            strCodeForCs.AppendFormat("\r\n" + "const {0} = Number(str{2});", objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName,
                                objViewFeatureFlds.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
                                objViewFeatureFlds.ObjFieldTabENEx.FldName);
                        }
                        if (objPrjTabEx_ListRegion.arrKeyFldSet.Count > 1)
                        {
                            strCodeForCs.Append("\r\n" + "    for (const strKeyLst of arrKeyIds) {");

                            strCodeForCs.AppendFormat("\r\n" + "await this.{0}(strKeyLst, {1});", strFuncName, objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);

                            strCodeForCs.Append("\r\n" + "}");
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "await this.{0}(arrKeyIds, {1});", strFuncName, objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);
                        }
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + "//console.log('arrKeyIds=');");
                        strCodeForCs.Append("\r\n" + "//console.log(arrKeyIds);");
                        strCodeForCs.AppendFormat("\r\n" + "await this.{0}(arrKeyIds);", strFuncName);
                    }

                    strCodeForCs.Append("\r\n" + $"await this.{strFuncName4BindGv}(divVarSet.refDivList);");

                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch(e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "const strMsg = `设置记录不成功,${e}.(in ${this.constructor.name}.${strThisFuncName}`;");

                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");

                    strCodeForCs.Append("\r\n" + "alert(strMsg);");

                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                }

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }



        public string Gen_Vue_Ts_SetFieldValue()
        {
            if (PrjTabEx_EditRegion.arrKeyFldSet.Count > 1) return Gen_Vue_Ts_SetFieldValue4MultiKey();

            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFldsObjLst = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.FeatureId == "0148");
                foreach (clsFeatureRegionFldsENEx objInFor in arrFeatureRegionFldsObjLst)
                {
                    clsFieldTabEN objFieldTabEN = clsFieldTabBL.GetObjByFldIdCache(objInFor.ReleFldId, objInFor.PrjId());
                    string strFuncName = string.Format("{0}", objInFor.ButtonName.Substring(3));

                    strCodeForCs.AppendFormat("\r\n /** 设置字段值-{0}", objFieldTabEN.FldName);
                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n **/");

                    string strKeys = "";
                    ArrayList arrKeysLst = new ArrayList();
                    foreach (clsPrjTabFldENEx objPrjTabFldENEx in objViewInfoENEx.arrKeyPrjTabFldSet)
                    {
                        arrKeysLst.Add("\"" + objPrjTabFldENEx.FldName + "\"");
                    }
                    //objViewInfoENEx.arrKeyPrjTabFldSet.Count.objMainPrjTab.
                    strKeys = clsArray.Join(arrKeysLst, ",");
                    //List<string> lstExam1TypeId = GetAllCheckedKeysFromGv();
                    //if (lstExam1TypeId == null) return;


                    clsViewFeatureFldsENEx objViewFeatureFlds = null;


                    if (objInFor.ValueGivingModeId == enumValueGivingMode.GivenValue_02)
                    {
                        List<clsViewFeatureFldsENEx> arrViewFeatureFlds = objViewInfoENEx.arrViewFeatureFlds.Where(x =>
                               x.ViewFeatureId == objInFor.ViewFeatureId).ToList();
                        if (arrViewFeatureFlds.Count == 0)
                        {
                            throw new Exception("功能：设置字段值的给值方式是给定值,但缺少相应的界面功能字段,请维护后再生成代码");
                        }
                        objViewFeatureFlds = arrViewFeatureFlds[0];

                        strCodeForCs.AppendFormat("\r\n" + "public async {0}(arr{1}: Array<string>, {3}: {2})",
                                strFuncName,
                                objKeyField.FldName,
                                objViewFeatureFlds.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType, objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.{0}.name;", strFuncName);
                        //ASPDropDownListEx objASPDropDownListENEx = clsASPDropDownListBLEx.GetDropDownLst_Asp(objViewFeatureFlds);
                        switch (objViewFeatureFlds.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType)
                        {
                            case "string":

                                strCodeForCs.AppendFormat("\r\n" + "if ({0} == null || {0} == \"\" )",
                                            objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);

                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"请输入{0}({1})!\";",
                                    objViewFeatureFlds.ObjFieldTabENEx.Caption,
                                    objViewFeatureFlds.ObjFieldTabENEx.FldName);
                                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                                strCodeForCs.Append("\r\n" + "//console.trace();");
                                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                                strCodeForCs.Append("\r\n" + "return \"\";");
                                strCodeForCs.Append("\r\n" + "}");
                                break;
                            case "number":

                                strCodeForCs.AppendFormat("\r\n" + "if ({0} == null || {0} == 0 )",
                                            objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);

                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"请输入{0}({1})!\";",
                                    objViewFeatureFlds.ObjFieldTabENEx.Caption,
                                    objViewFeatureFlds.ObjFieldTabENEx.FldName);
                                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                                strCodeForCs.Append("\r\n" + "//console.trace();");
                                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                                strCodeForCs.Append("\r\n" + "return \"\";");
                                strCodeForCs.Append("\r\n" + "}");
                                break;
                        }
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "public async {0}(arr{1}: Array<string>)",
                                strFuncName, objKeyField.FldName);
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.{0}.name;", strFuncName);
                    }

                    strCodeForCs.AppendFormat("\r\n" + "if (arr{0}.length == 0)", objKeyField.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "const strMsg = \"没有选择记录,不能设置字段值!\";");
                    strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                    strCodeForCs.Append("\r\n" + "//console.trace();");
                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "return \"\";");
                    strCodeForCs.Append("\r\n" + "}");

                    //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");

                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.Append("\r\n" + $"const arr{TabName_In4Edit4GC}ObjLst = await {thisWA_F_InList(WA_F.GetObjLstByKeyLstAsync)}(arr{objKeyField.FldName});");

                    strCodeForCs.Append("\r\n" + "let intCount = 0;");
                    strCodeForCs.AppendFormat("\r\n" + "for (const objInFor of arr{0}ObjLst)",
                        TabName_In4Edit4GC);
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN = new cls{0}EN();", TabName_In4Edit4GC);
                    strCodeForCs.AppendFormat("\r\n" + "ObjectAssign(obj{0}EN, objInFor);", TabName_In4Edit4GC);
                    AddImportClass(objViewInfoENEx.InRelaTabId, "/PubFun/clsCommFunc4Web.js", "ObjectAssign", enumImportObjType.CustomFunc, this.strBaseUrl);
                    strCodeForCs.Append("\r\n" + $"obj{TabName_In4Edit4GC}EN.Set{objKeyField.FldName}(objInFor.{objKeyField.PropertyName(this.IsFstLcase)});");

                    if (objInFor.ValueGivingModeId == enumValueGivingMode.GivenValue_02)
                    {
                        if (objViewFeatureFlds == null)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(\"这里不正确,值为空!\");",
                                                      TabName_In4Edit4GC, objFieldTabEN.FldName);
                        }
                        else
                        {

                            if (clsPrjTabFldBLEx.IsForExtendClass(TabId_In4Edit, objInFor.ReleFldId, objInFor.PrjId) == true)
                            {
                                strCodeForCs.AppendFormat("\r\n" + "//obj{0}EN.Set{1}({2});",
                                                       TabName_In4Edit4GC, objFieldTabEN.FldName,
                                                       objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}({2});",
                                                          TabName_In4Edit4GC, objFieldTabEN.FldName,
                                                          objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);
                            }
                        }
                    }
                    else
                    {

                        clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFieldTabEN.DataTypeId);
                        if (clsDataTypeAbbrBLEx.IsNumberType(objDataTypeAbbrEN) == true)
                        {
                            //strCodeForCs.Append("\r\n" + "objInFor.ExamTypeName = \"C_\" + objInFor.ExamTypeName;");
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}({2});",
                                  TabName_In4Edit4GC, objFieldTabEN.FldName, objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);
                        }
                        else
                        {
                            if (objDataTypeAbbrEN.CsType == "bool")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(TransToBool(\"{2}\"));",
                                                        TabName_In4Edit4GC, objFieldTabEN.FldName, objInFor.DefaultValue);
                                AddImportClass("", "/PubFun/clsString.js", "TransToBool", enumImportObjType.CustomFunc, this.strBaseUrl);

                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(\"{2}\");",
                                    TabName_In4Edit4GC, objFieldTabEN.FldName, objInFor.DefaultValue);
                            }
                        }
                    }
                    strCodeForCs.Append("\r\n" + "let returnBool = false;");
                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "    obj{0}EN.sfUpdFldSetStr = obj{0}EN.updFldString;//设置哪些字段被修改(脏字段)", TabName_In4Edit4GC);

                    strCodeForCs.Append("\r\n" + $"returnBool = await {thisWA_F_InEdit(WA_F.UpdateRecordAsync)}(obj{TabName_In4Edit4GC}EN);");

                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (e)");
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.Append("\r\n" + "const strMsg = `设置记录不成功,${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "throw (strMsg);");
                    strCodeForCs.Append("\r\n" + "}");


                    strCodeForCs.Append("\r\n" + "if (returnBool == true)");
                    strCodeForCs.Append("\r\n" + "{");
                    //strCodeForCs.Append("\r\n" + "const strInfo = Format(\"设置记录成功!\");");
                    strCodeForCs.Append("\r\n" + "intCount++;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "else");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "const strInfo = Format(\"设置记录不成功!\");");

                    strCodeForCs.Append("\r\n" + "//显示信息框");
                    strCodeForCs.Append("\r\n" + "alert(strInfo);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "const strInfo = Format(\"共设置了{0}条记录!\", intCount);");

                    strCodeForCs.Append("\r\n" + "alert(strInfo);");
                    strCodeForCs.Append("\r\n" + "//console.log('完成!');");

                    strCodeForCs.Append("\r\n" + "if (intCount > 0)");
                    strCodeForCs.Append("\r\n" + "{");
                    Gene_ReFreshCache(strCodeForCs);
                    strCodeForCs.Append("\r\n" + "}");

                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "const strMsg = `设置记录不成功,${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
                    strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                    strCodeForCs.Append("\r\n" + "//console.trace();");
                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");

                }

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_Vue_Ts_SetFieldValue4MultiKey()
        {

            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFldsObjLst = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.FeatureId == "0148");
                foreach (clsFeatureRegionFldsENEx objInFor in arrFeatureRegionFldsObjLst)
                {
                    clsFieldTabEN objFieldTabEN = clsFieldTabBL.GetObjByFldIdCache(objInFor.ReleFldId, objInFor.PrjId());
                    string strFuncName = string.Format("{0}", objInFor.ButtonName.Substring(3));

                    strCodeForCs.AppendFormat("\r\n /** 设置字段值-{0}", objFieldTabEN.FldName);
                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n **/");

                    string strKeys = "";
                    ArrayList arrKeysLst = new ArrayList();
                    foreach (clsPrjTabFldENEx objPrjTabFldENEx in objViewInfoENEx.arrKeyPrjTabFldSet)
                    {
                        arrKeysLst.Add("\"" + objPrjTabFldENEx.FldName + "\"");
                    }
                    //objViewInfoENEx.arrKeyPrjTabFldSet.Count.objMainPrjTab.
                    strKeys = clsArray.Join(arrKeysLst, ",");
                    //List<string> lstExam1TypeId = GetAllCheckedKeysFromGv();
                    //if (lstExam1TypeId == null) return;


                    clsViewFeatureFldsENEx objViewFeatureFlds = null;


                    if (objInFor.ValueGivingModeId == enumValueGivingMode.GivenValue_02)
                    {
                        List<clsViewFeatureFldsENEx> arrViewFeatureFlds = objViewInfoENEx.arrViewFeatureFlds.Where(x =>
                               x.ViewFeatureId == objInFor.ViewFeatureId).ToList();
                        if (arrViewFeatureFlds.Count == 0)
                        {
                            throw new Exception("功能：设置字段值的给值方式是给定值,但缺少相应的界面功能字段,请维护后再生成代码");
                        }
                        objViewFeatureFlds = arrViewFeatureFlds[0];

                        strCodeForCs.Append("\r\n" + $"public async {strFuncName}(strKeyLst: string, {objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName}: {objViewFeatureFlds.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType})");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.{0}.name;", strFuncName);
                        //ASPDropDownListEx objASPDropDownListENEx = clsASPDropDownListBLEx.GetDropDownLst_Asp(objViewFeatureFlds);
                        switch (objViewFeatureFlds.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType)
                        {
                            case "string":

                                strCodeForCs.AppendFormat("\r\n" + "if ({0} == null || {0} == \"\" )",
                                            objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);

                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"请输入{0}({1})!\";",
                                    objViewFeatureFlds.ObjFieldTabENEx.Caption,
                                    objViewFeatureFlds.ObjFieldTabENEx.FldName);
                                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                                strCodeForCs.Append("\r\n" + "//console.trace();");
                                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                                strCodeForCs.Append("\r\n" + "return \"\";");
                                strCodeForCs.Append("\r\n" + "}");
                                break;
                            case "number":

                                strCodeForCs.AppendFormat("\r\n" + "if ({0} == null || {0} == 0 )",
                                            objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);

                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"请输入{0}({1})!\";",
                                    objViewFeatureFlds.ObjFieldTabENEx.Caption,
                                    objViewFeatureFlds.ObjFieldTabENEx.FldName);
                                strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                                strCodeForCs.Append("\r\n" + "//console.trace();");
                                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                                strCodeForCs.Append("\r\n" + "return \"\";");
                                strCodeForCs.Append("\r\n" + "}");
                                break;
                        }
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + $"public async {strFuncName}(arr{objKeyField.FldName}: Array<string>)");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.{0}.name;", strFuncName);
                    }

                    strCodeForCs.AppendFormat("\r\n" + "if (strKeyLst.length == 0)", objKeyField.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "const strMsg = \"没有选择记录,不能设置字段值!\";");
                    strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                    strCodeForCs.Append("\r\n" + "//console.trace();");
                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "return \"\";");
                    strCodeForCs.Append("\r\n" + "}");

                    //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");

                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + $"const objKeyLst = {TabName_In4Edit4GC}_SplitKeyLst(strKeyLst);");
                    AddImportClass(objViewInfoENEx.MainTabId, ViewMainTabName4GC, string.Format("SplitKeyLst", objKeyField.FldName), enumImportObjType.WApiClassFunc, this.strBaseUrl);

                    StringBuilder sbTemp = new StringBuilder();
                    foreach (var objInFor1 in PrjTabEx_EditRegion.arrKeyFldSet)
                    {
                        sbTemp.AppendFormat("\r\n" + $"objKeyLst.{objInFor1.PropertyName(this.IsFstLcase)},");
                    }
                    strCodeForCs.Append("\r\n" + $"const obj{TabName_In4Edit4GC}EN = await {thisWA_F_InList(WA_F.GetObjByKeyLstAsync)}({sbTemp.ToString()});");

                    strCodeForCs.Append("\r\n" + "let intCount = 0;");
                    strCodeForCs.Append("\r\n" + $"if (obj{TabName_In4Edit4GC}EN == null) return false");



                    foreach (var objInFor1 in PrjTabEx_EditRegion.arrKeyFldSet)
                    {
                        strCodeForCs.Append("\r\n" + $"obj{TabName_In4Edit4GC}EN.Set{objInFor1.FldName}(objKeyLst.{objInFor1.PropertyName(this.IsFstLcase)});");
                    }


                    if (objInFor.ValueGivingModeId == enumValueGivingMode.GivenValue_02)
                    {
                        if (objViewFeatureFlds == null)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(\"这里不正确,值为空!\");",
                                                      TabName_In4Edit4GC, objFieldTabEN.FldName);
                        }
                        else
                        {

                            if (clsPrjTabFldBLEx.IsForExtendClass(TabId_In4Edit, objInFor.ReleFldId, objInFor.PrjId) == true)
                            {
                                strCodeForCs.AppendFormat("\r\n" + "//obj{0}EN.Set{1}({2});",
                                                       TabName_In4Edit4GC, objFieldTabEN.FldName,
                                                       objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}({2});",
                                                          TabName_In4Edit4GC, objFieldTabEN.FldName,
                                                          objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);
                            }
                        }
                    }
                    else
                    {

                        clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeIdCache(objFieldTabEN.DataTypeId);
                        if (clsDataTypeAbbrBLEx.IsNumberType(objDataTypeAbbrEN) == true)
                        {
                            //strCodeForCs.Append("\r\n" + "objInFor.ExamTypeName = \"C_\" + objInFor.ExamTypeName;");
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}({2});",
                                  TabName_In4Edit4GC, objFieldTabEN.FldName, objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);
                        }
                        else
                        {
                            if (objDataTypeAbbrEN.CsType == "bool")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(TransToBool(\"{2}\"));",
                                                        TabName_In4Edit4GC, objFieldTabEN.FldName, objInFor.DefaultValue);
                                AddImportClass("", "/PubFun/clsString.js", "TransToBool", enumImportObjType.CustomFunc, this.strBaseUrl);

                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.Set{1}(\"{2}\");",
                                    TabName_In4Edit4GC, objFieldTabEN.FldName, objInFor.DefaultValue);
                            }
                        }
                    }
                    strCodeForCs.Append("\r\n" + "let returnBool = false;");
                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "    obj{0}EN.sfUpdFldSetStr = obj{0}EN.updFldString;//设置哪些字段被修改(脏字段)", TabName_In4Edit4GC);

                    strCodeForCs.Append("\r\n" + $"returnBool = await {thisWA_F_InEdit(WA_F.UpdateRecordAsync)}(obj{TabName_In4Edit4GC}EN);");

                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (e)");
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.Append("\r\n" + "const strMsg = `设置记录不成功,${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "throw (strMsg);");
                    strCodeForCs.Append("\r\n" + "}");


                    strCodeForCs.Append("\r\n" + "if (returnBool == true)");
                    strCodeForCs.Append("\r\n" + "{");
                    //strCodeForCs.Append("\r\n" + "const strInfo = Format(\"设置记录成功!\");");
                    strCodeForCs.Append("\r\n" + "intCount++;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "else");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "const strInfo = Format(\"设置记录不成功!\");");

                    strCodeForCs.Append("\r\n" + "//显示信息框");
                    strCodeForCs.Append("\r\n" + "alert(strInfo);");
                    strCodeForCs.Append("\r\n" + "}");
                    //strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "const strInfo = Format(\"共设置了{0}条记录!\", intCount);");

                    strCodeForCs.Append("\r\n" + "alert(strInfo);");
                    strCodeForCs.Append("\r\n" + "//console.log('完成!');");

                    strCodeForCs.Append("\r\n" + "if (intCount > 0)");
                    strCodeForCs.Append("\r\n" + "{");
                    Gene_ReFreshCache(strCodeForCs);
                    strCodeForCs.Append("\r\n" + "}");

                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "const strMsg = `设置记录不成功,${e}.(in ${this.constructor.name}.${strThisFuncName}`;");
                    strCodeForCs.Append("\r\n" + "console.error(\"Error: \", strMsg);");
                    strCodeForCs.Append("\r\n" + "//console.trace();");
                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");

                }

            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_Vue_Ts_btnGoTop_Click()
        {
            return Gen_WApi_Ts_btnGoTop_Click();
        }

        public string Gen_Vue_Ts_btnUpMove_Click()
        {
            return Gen_WApi_Ts_btnUpMove_Click();
        }

        public string Gen_Vue_Ts_MoveRecord()
        {
            return Gen_WApi_Ts_MoveRecord();
        }

        public string Gen_Vue_Ts_btnDownMove_Click()
        {
            return Gen_WApi_Ts_btnDownMove_Click();
        }


        public string Gen_Vue_Ts_PreCheck4Order()
        {
            return Gen_WApi_Ts_PreCheck4Order();

        }

        public string Gen_Vue_Ts_btnGoBottum_Click()
        {
            return Gen_WApi_Ts_btnGoBottum_Click();

        }
        public string Gen_Vue_Ts_btnReOrder_Click()
        {
            return Gen_WApi_Ts_btnReOrder_Click();

        }

        public string Gen_Vue_Ts_Code4QueryRegion()
        {
            return Gen_WApi_Ts_Code4QueryRegion();

        }

        public string Gen_Vue_Ts_Code4FeatureRegion()
        {
            return Gen_WApi_Ts_Code4QueryRegion();
        }
        public string Gen_Vue_Ts_Code4ListRegion()
        {
            return Gen_WApi_Ts_Code4QueryRegion();
        }

        public string Gen_Vue_Ts_Code4DetailRegion()
        {
            return Gen_WApi_Ts_Code4DetailRegion();

        }



        public string Gen_Vue_Ts_Code4EditRegion()
        {
            return Gen_WApi_Ts_Code4EditRegion();

        }
        public string Gen_Vue_Ts_Code4ExcelExportRegion()
        {
            return Gen_WApi_Ts_Code4ExcelExportRegion();

        }

        public string Gen_Vue_Ts_CopyToEx()
        {
            return Gen_WApi_Ts_CopyToEx();

        }
        public string Gen_Vue_Ts_FuncMap4ExcelExport()
        {
            return Gen_WApi_Ts_FuncMap4ExcelExport();
        }


        public string Gen_Vue_Ts_SetEventFunc()
        {
            return Gen_WApi_Ts_SetEventFunc();

        }

        public string Gen_Vue_Ts_GeneEventFunc()
        {
            return Gen_WApi_Ts_GeneEventFunc();

        }

        public string Gen_Vue_Ts_GetDivName()
        {
            return "";
            //StringBuilder strCodeForCs = new StringBuilder();
            //strCodeForCs.Append("\r\n /**");
            //strCodeForCs.Append("\r\n * 获取div对象，根据不同的div类型");
            //strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            //strCodeForCs.Append("\r\n **/");
            //strCodeForCs.Append("\r\n" + "public getDivName(strDivType: enumDivType): HTMLDivElement | null {");
            //strCodeForCs.Append("\r\n" + "const strThisFuncName = this.getDivName.name;");

            //strCodeForCs.Append("\r\n" + "let divName;");

            //strCodeForCs.Append("\r\n" + "let divTypeName;");
            //strCodeForCs.Append("\r\n" + "let strMsg;");
            //strCodeForCs.Append("\r\n" + "switch (strDivType)");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "case enumDivType.LayOut_01:");
            //strCodeForCs.Append("\r\n" + $"divName = this.divLayout;");
            //strCodeForCs.Append("\r\n" + "divTypeName = 'divLayout';");
            //strCodeForCs.Append("\r\n" + "break;");
            //strCodeForCs.Append("\r\n" + "case enumDivType.Query_02:");
            //strCodeForCs.Append("\r\n" + $"divName = this.divQuery;");
            //strCodeForCs.Append("\r\n" + "divTypeName = 'divQuery';");
            //strCodeForCs.Append("\r\n" + "break;");
            //strCodeForCs.Append("\r\n" + "case enumDivType.Function_03:");
            //strCodeForCs.Append("\r\n" + $"divName = this.divFunction;");
            //strCodeForCs.Append("\r\n" + "divTypeName = 'divFunction';");
            //strCodeForCs.Append("\r\n" + "break;");
            ////strCodeForCs.Append("\r\n" + "case enumDivType.DataList_04:");
            ////strCodeForCs.Append("\r\n" + $"divName = this.divDataLst;");
            ////strCodeForCs.Append("\r\n" + "divTypeName = 'divDataLst';");
            ////strCodeForCs.Append("\r\n" + "break;");
            //strCodeForCs.Append("\r\n" + "case enumDivType.List_05:");
            //strCodeForCs.Append("\r\n" + $"divName = this.divList;");
            //strCodeForCs.Append("\r\n" + "divTypeName = 'divList';");
            //strCodeForCs.Append("\r\n" + "break;");
            ////strCodeForCs.Append("\r\n" + "case enumDivType.Paper_06:");
            ////strCodeForCs.Append("\r\n" + $"divName = this.divPager;");
            ////strCodeForCs.Append("\r\n" + "divTypeName = 'divPager';");
            ////strCodeForCs.Append("\r\n" + "break;");
            //strCodeForCs.Append("\r\n" + "default:");
            //strCodeForCs.Append("\r\n" + "strMsg = `获取div对象时，DivType =${strDivType}没有被处理，请检查！(in ${this.constructor.name}.${ strThisFuncName})`;");
            //strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            //strCodeForCs.Append("\r\n" + "alert(strMsg);");
            //strCodeForCs.Append("\r\n" + "return null;");
            //strCodeForCs.Append("\r\n" + "break;");
            //strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.Append("\r\n" + "if (divName == null)");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "strMsg = `当前${ divTypeName}层(div)对象为空，请检查！(in ${ this.constructor.name}.${ strThisFuncName})`;");
            //strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            //strCodeForCs.Append("\r\n" + "alert(strMsg);");
            //strCodeForCs.Append("\r\n" + "return null;");
            //strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "return divName;");
            //strCodeForCs.Append("\r\n" + "}");


            //return strCodeForCs.ToString();
        }
    }
}
