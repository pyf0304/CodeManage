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
    partial class Vue_ViewScript_DetailCS_TS4TypeScriptBak : clsGeneCodeBase
    {
        //private string objPrjTabENEx = "";
        private string strMapFuncCode = "";
        private List<string> arrTabId4MapFunc = null;// new List<string>();

        private bool bolIsUseFunc4Detail = false;
        private string strTabName_Out4Detail = "";

        private string strTabId_Out4Detail = "";

        private List<clsPropertyDef4GC> arrPropertyDef4GC = null;
        private string strVarDef4ViewCacheFld = "";
        //private string strVarDef4GivingValue = "";

        int intZIndex;      ///控件焦点序号
        float intCurrLeft;  ///控件的左边空;
        float intCurrTop;  ///控件的顶面空;
        #region 构造函数
        public Vue_ViewScript_DetailCS_TS4TypeScriptBak()
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            InitPageSetup();
        }
        public Vue_ViewScript_DetailCS_TS4TypeScriptBak(string strViewId)
       : base("", strViewId, "", "")
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
        }
        public Vue_ViewScript_DetailCS_TS4TypeScriptBak(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
        : base(strTabId, strViewId, strPrjDataBaseId, strPrjId)
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
            this.GetClsName();
            if (objViewInfoENEx.objCacheClassifyFld4View != null)
            {
                strVarDef4ViewCacheFld = string.Format("{0}.{1}_Cache", objViewInfoENEx.ClsName, objViewInfoENEx.objCacheClassifyFld4View.FldName);
            }

        }
        /// <summary>
        /// 初始化页面设置
        /// </summary>
        public void InitPageSetup()
        {
            intZIndex = 100;        ///控件焦点序号
            intCurrLeft = 10;  ///控件的左边空;
            intCurrTop = 10;
        }

        #endregion

        public string Gen_Vue_Ts_Page_Load()
        {

            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /* 函数功能:页面导入,当页面开始运行时所发生的事件");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.Append("\r\n" + "public async Page_Load()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.Page_Load.name;",
       objViewInfoENEx.TabName, objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "// 在此处放置用户代码以初始化页面");
                //strCodeForCs.Append("\r\n" + GenPotenceRelaCode());
                //生成Page_Load中的绑定下拉框的代码
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                //设置缓存
                strCodeForCs.Append("\r\n" + "this.SetEventFunc();");

                //strCodeForCs.Append("\r\n" + "clsPubFun.SetCommFun4BL();");
                List<string> arrTabName = new List<string>();



                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = Format(\"页面启动不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
                strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_Vue_Ts_SetEventFunc()
        {

            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /* 函数功能:设置事件函数");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.Append("\r\n" + "public async SetEventFunc()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.SetEventFunc.name;",
       objViewInfoENEx.TabName, objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "// 在此处放置用户代码以初始化页面");


                //strCodeForCs.Append("\r\n" + GenPotenceRelaCode());
                //生成Page_Load中的绑定下拉框的代码
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");

                var arrDetailRegionFlds_ChangeEvent = objViewInfoENEx.arrDetailRegionFldSet.Where(x => string.IsNullOrEmpty(x.ChangeEvent) == false && x.InUse == true).ToList();
                arrDetailRegionFlds_ChangeEvent.ForEach(x =>
                {
                    var objCtlTypeAbbr = clsCtlTypeAbbrBL.GetObjByCtlTypeId_Cache(x.CtlTypeId);
                    strCodeForCs.AppendFormat("\r\n" + "var {0}: {1} = < {1} > document.getElementById('{0}');",
                                    x.CtrlId, objCtlTypeAbbr.HtmlCtrlTypeName);
                    strCodeForCs.AppendFormat("\r\n" + "{0}.addEventListener('change', e => {{ this.{0}_SelectedIndexChanged(); }});",
                       x.CtrlId, objViewInfoENEx.ClsName);
                });

                var arrDetailRegionFlds_ClickEvent = objViewInfoENEx.arrDetailRegionFldSet.Where(x => string.IsNullOrEmpty(x.ClickEvent) == false && x.InUse == true).ToList();
                arrDetailRegionFlds_ClickEvent.ForEach(x =>
                {
                    var objCtlTypeAbbr = clsCtlTypeAbbrBL.GetObjByCtlTypeId_Cache(x.CtlTypeId);
                    strCodeForCs.AppendFormat("\r\n" + "var {0}: {1} = < {1} > document.getElementById('{0}');",
                                    x.CtrlId, objCtlTypeAbbr.HtmlCtrlTypeName);
                    strCodeForCs.AppendFormat("\r\n" + "{0}.addEventListener('change', e => {{ this.{0}_Clicked(); }});",
                       x.CtrlId, objViewInfoENEx.ClsName);
                });
                if (arrDetailRegionFlds_ChangeEvent.Count == 0 && arrDetailRegionFlds_ClickEvent.Count == 0)
                {
                    strCodeForCs.Append("\r\n" + "//没有定义相关事件");
                }

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = Format(\"页面启动不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
                strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_Vue_Ts_GeneEventFunc()
        {

            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {


                var arrDetailRegionFlds_ChangeEvent = objViewInfoENEx.arrDetailRegionFldSet.Where(x => string.IsNullOrEmpty(x.ChangeEvent) == false && x.InUse == true).ToList();
                arrDetailRegionFlds_ChangeEvent.ForEach(x =>
                {
                    var objCtlTypeAbbr = clsCtlTypeAbbrBL.GetObjByCtlTypeId_Cache(x.CtlTypeId);

                    strCodeForCs.Append("\r\n /* 函数功能:系统生成的Change事件函数");
                    strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + "*/");
                    strCodeForCs.AppendFormat("\r\n" + "public abstract {0}():void;//",
                       x.ChangeEvent);
                    //strCodeForCs.AppendFormat("\r\n" + "alert('请在扩展层:{0}Ex中覆盖该函数！');", objViewInfoENEx.ClsName);
                    //strCodeForCs.Append("\r\n" + "}");
                });

                strCodeForCs.Append("\r\n" + "");

                var arrDetailRegionFlds_ClickEvent = objViewInfoENEx.arrDetailRegionFldSet.Where(x => string.IsNullOrEmpty(x.ClickEvent) == false && x.InUse == true).ToList();
                arrDetailRegionFlds_ClickEvent.ForEach(x =>
                {
                    var objCtlTypeAbbr = clsCtlTypeAbbrBL.GetObjByCtlTypeId_Cache(x.CtlTypeId);
                    strCodeForCs.Append("\r\n /* 函数功能:系统生成的Click事件函数");
                    strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + "*/");

                    strCodeForCs.AppendFormat("\r\n" + "public abstract {0}():void;",
                       x.ClickEvent, objViewInfoENEx.ClsName);
                  
                });

                strCodeForCs.Append("\r\n" + "");

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }






        public string Gen_Vue_Ts_DdlBind4ViewFeatureInPage_Load()
        {
            clsVarManage objVarManage = new clsVarManage("TypeScript");
            string strCacheClassifyFldName4View = "";
            if (objViewInfoENEx.objCacheClassifyFld4View != null)
            {
                strCacheClassifyFldName4View = objViewInfoENEx.objCacheClassifyFld4View.FldName;
            }
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {


                //clsASPDropDownListBLEx.
                List<string> arrDropDownTypeLst = new List<string> { enumCtlTypeAbbr.DropDownList_06, enumCtlTypeAbbr.DropDownList_Bool_18 };

                //从界面功能字段中获取下拉框字段

                IEnumerable<clsvViewFeatureFldsENEx> arrWFF4DropDownLst = objViewInfoENEx.arrvViewFeatureFlds.Where(x => arrDropDownTypeLst.Contains(x.CtlTypeId));
                List<ASPDropDownListEx> arrASPDropDownListObj4WFF = arrWFF4DropDownLst
                    .Select(GetDdlObj2).Distinct(new ASPDropDownListEx4GCComparer()).ToList();

                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj4WFF)
                {
                    string strCtrlId = objInfor.CtrlId;
                    if (objInfor.FeatureId == enumPrjFeature.SetFieldValue_0148)
                    {
                        if (strCtrlId.IndexOf("_SetFldValue") == -1)
                        {
                            strCtrlId = strCtrlId + "_SetFldValue";
                            objInfor.CtrlId = strCtrlId;
                        }
                    }
                    strCodeForCs.AppendFormat("\r\n" + objInfor.GC_BindDdl4WA_TS(objVarManage, strCacheClassifyFldName4View, strVarDef4ViewCacheFld, objInfor.objFieldTab_CacheClassify()));
                }
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        private List<ImportClass> GetImportClassLst(clsFuncModule_AgcEN objFuncModule)
        {
            List<ImportClass> arrImportClass = new List<ImportClass>();
            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("cls{0}EN", objViewInfoENEx.TabName),
                FilePath = string.Format("../TS/L0_Entity/{0}/cls{1}EN", objFuncModule.FuncModuleEnName,
                   objViewInfoENEx.TabName)
            });

            if (bolIsUseFunc4Detail == true)
            {
                arrImportClass.Add(new ImportClass
                {
                    ClassName = string.Format("cls{0}ENEx", strTabName_Out4Detail),
                    FilePath = string.Format("../TS/L0_Entity/{0}/cls{1}ENEx", objFuncModule.FuncModuleEnName,
                        strTabName_Out4Detail)
                });
                arrImportClass.Add(new ImportClass
                {
                    ClassName = string.Format("cls{0}ExWApi", strTabName_Out4Detail),
                    FilePath = string.Format("../TS/L3_ForWApiEx/{0}/cls{1}ExWApi", objFuncModule.FuncModuleEnName,
                     strTabName_Out4Detail)
                });
            }
            
            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("cls{0}BL", objViewInfoENEx.TabName),
                FilePath = string.Format("../TS/L3_ForWApi/{0}/cls{1}WApi", objFuncModule.FuncModuleEnName,
                    objViewInfoENEx.TabName)
            });
            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("cls{0}WApi", objViewInfoENEx.TabName),
                FilePath = string.Format("../TS/L3_ForWApi/{0}/cls{1}WApi", objFuncModule.FuncModuleEnName,
                  objViewInfoENEx.TabName)
            });

            if (objViewInfoENEx.TabName != objViewInfoENEx.TabName_Out)
            {
                arrImportClass.Add(new ImportClass
                {
                    ClassName = string.Format("cls{0}WApi", objViewInfoENEx.TabName_Out),
                    FilePath = string.Format("../TS/L3_ForWApi/{0}/cls{1}WApi", objFuncModule.FuncModuleEnName,
                                   objViewInfoENEx.TabName_Out)
                });
                arrImportClass.Add(new ImportClass
                {
                    ClassName = string.Format("cls{0}BL", objViewInfoENEx.TabName_Out),
                    FilePath = string.Format("../TS/L3_ForWApi/{0}/cls{1}WApi", objFuncModule.FuncModuleEnName,
                                 objViewInfoENEx.TabName_Out)
                });
                arrImportClass.Add(new ImportClass
                {
                    ClassName = string.Format("cls{0}EN", objViewInfoENEx.TabName_Out),
                    FilePath = string.Format("../TS/L0_Entity/{0}/cls{1}EN", objFuncModule.FuncModuleEnName,
                                objViewInfoENEx.TabName_Out)
                });
            }

          
            foreach (string strTabId in arrTabId4MapFunc)
            {
                if (strTabId == objViewInfoENEx.MainTabId) continue;
                clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId_Cache(strTabId, objViewInfoENEx.PrjId);

                clsFuncModule_AgcEN objFuncModule_AgcEN = clsFuncModule_AgcBL.GetObjByFuncModuleAgcId_Cache(objPrjTabEN.FuncModuleAgcId, objPrjTabEN.PrjId);
                arrImportClass.Add(new ImportClass
                {
                    ClassName = string.Format("cls{0}EN", objPrjTabEN.TabName),
                    FilePath = string.Format("../TS/L0_Entity/{0}/cls{1}EN", objFuncModule_AgcEN.FuncModuleEnName,
                             objPrjTabEN.TabName)
                });

                arrImportClass.Add(new ImportClass
                {
                    ClassName = string.Format("cls{0}WApi", objPrjTabEN.TabName),
                    FilePath = string.Format("../TS/L3_ForWApi/{0}/cls{1}WApi", objFuncModule_AgcEN.FuncModuleEnName,
                             objPrjTabEN.TabName)
                });

            }

            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("arrSelectedKeys, clsCommFunc4Web", objViewInfoENEx.TabName),
                FilePath = string.Format("../TS/PubFun/clsCommFunc4Web", objFuncModule.FuncModuleEnName,
        objViewInfoENEx.TabName)
            });
            
           
            //arrImportClass.Add(new ImportClass
            //{
            //    ClassName = string.Format("clsStack1Trace", objViewInfoENEx.TabName),
            //    FilePath = string.Format("../TS/PubFun/clsStackTrace", objFuncModule.FuncModuleEnName,
            //objViewInfoENEx.TabName)
            //});
           
            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("TransToBool", objViewInfoENEx.TabName),
                FilePath = string.Format("../TS/PubFun/jsString", objFuncModule.FuncModuleEnName,
      objViewInfoENEx.TabName)
            });
            

            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("clsPubSessionStorage", objViewInfoENEx.TabName),
                FilePath = string.Format("../TS/PubFun/clsPubSessionStorage", objFuncModule.FuncModuleEnName,
  objViewInfoENEx.TabName)
            });
            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("Format, IsNullOrEmpty", objViewInfoENEx.TabName),
                FilePath = string.Format("../TS/PubFun/clsString", objFuncModule.FuncModuleEnName,
 objViewInfoENEx.TabName)
            });
                        arrImportClass = arrImportClass.Distinct(new ImportClass4GCComparer()).ToList();
            return arrImportClass;
        }

        /// <summary>
        /// 生成App页面后台代码
        /// </summary>
        /// <returns></returns>
        public override string GeneCode(ref string strRe_ClsName, ref string strRe_FileNameWithModuleName)
        {
            if (objViewInfoENEx.objViewRegion_Detail == null || objViewInfoENEx.objViewRegion_Detail.InUseInViewInfo(objViewInfoENEx) == false)
            {
                return "";
            }
            arrPropertyDef4GC = new List<clsPropertyDef4GC>();
            //让用户设置属性;
            if (objViewInfoENEx.arrDetailRegionFldSet4InUse == null || objViewInfoENEx.arrDetailRegionFldSet4InUse.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有编辑区域,或者编辑区域没有字段。请检查!", strViewName);
                sbMessage.Append("\r\n当前界面的功能:查询(Q)、修改(U)、删除(D)、添加(I)。");
                throw new clsDbObjException(sbMessage.ToString());
            }
            if (objViewInfoENEx.arrDetailRegionFldSet4InUse.Where(x => x.IsUseFunc == true).Count() > 0)
            {
                this.bolIsUseFunc4Detail = true;
            }
            strTabName_Out4Detail = clsPrjTabBL.GetNameByTabId_Cache(objViewInfoENEx.objViewRegion_Detail.TabId, objViewInfoENEx.PrjId);
            strTabId_Out4Detail = objViewInfoENEx.objViewRegion_Detail.TabId;

            //string strResult = "";

            string strFuncName = "";
            string strTemp = ""; ///临时变量;
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp ;     ///临时变量;
            clsPubFun4BLEx.CheckDgStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.DgStyleId);
            clsPubFun4BLEx.CheckTitleStyleId4ViewInfo(objViewInfoENEx.objViewStyleEN.TitleStyleId);

            clsDataGridStyleEN objDGStyleEx = clsDataGridStyleBL.GetObjByDgStyleId_Cache(objViewInfoENEx.objViewStyleEN.DgStyleId);


            //if (objViewInfoENEx.IsUseCache4List)
            //{
            //    objViewInfoENEx.WebFormName = string.Format("WApi{0}_QUDI_Cache", objViewInfoENEx.TabName);
            //    objViewInfoENEx.WebFormFName = string.Format("WApi{0}_QUDI_Cache.ts",
            //        objViewInfoENEx.TabName, objViewInfoENEx.WebFormName);
            //}
            //else
            //{
            //    objViewInfoENEx.WebFormName = string.Format("WApi{0}_QUDI_TS", objViewInfoENEx.TabName);
            //    objViewInfoENEx.WebFormFName = string.Format("WApi{0}_QUDI_TS.ts",
            //        objViewInfoENEx.TabName, objViewInfoENEx.WebFormName);
            //}

            objViewInfoENEx.WebFormName = objViewInfoENEx.ClsName;
            objViewInfoENEx.WebFormFName = string.Format("{0}.ts", objViewInfoENEx.ClsName);

            objViewInfoENEx.FileName = objViewInfoENEx.WebFormFName;

            strRe_ClsName = objViewInfoENEx.WebFormName;
            clsFuncModule_AgcEN objFuncModule = clsFuncModule_AgcBL.GetObjByFuncModuleAgcId_Cache(objViewInfoENEx.FuncModuleAgcId, objViewInfoENEx.PrjId);

            clsCodeTypeEN objCodeType = clsCodeTypeBL.GetObjByCodeTypeId_Cache(objViewInfoENEx.CodeTypeId);
            if (objCodeType.IsDirByTabName == false)
            {
                strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objFuncModule.FuncModuleEnName, objViewInfoENEx.WebFormFName);
            }
            else
            {
                strRe_FileNameWithModuleName = string.Format("{0}\\{1}", objViewInfoENEx.TabName, objViewInfoENEx.WebFormFName);
            }
            //strXmlFileName = strXmlFileName.ToLower();
            //objViewInfoENEx1.ProgLevelTypeId = clsProgLevelTypeENEx.WebServiceTransferLevel;

            clsProjectsEN objProject = clsProjectsBL.GetObjByPrjId_Cache(objViewInfoENEx.PrjId); //
            try
            {
                arrTabId4MapFunc = new List<string>();
                strMapFuncCode = Gen_Vue_Ts_FuncMap4Detail();

                //类名开始
                strCodeForCs.Append(clsCommonFunc4GC.GenUserInfoAndDate4WebApi(objViewInfoENEx.CurrUserName,
                    objViewInfoENEx));

                //strCodeForCs.AppendFormat("\r\n" + "///// <reference path=\"../../scripts/typings/jquery/jquery.d.ts\" />");
                //strCodeForCs.AppendFormat("\r\n" + "///// <reference path=\"../../scripts/typings/q/q.d.ts\" />");
                //strCodeForCs.AppendFormat("\r\n" + "///// <reference path=\"../../scripts/typings/handlebars/handlebars.d.ts\" />");
                //strCodeForCs.AppendFormat("\r\n" + "//import * as $ from \"jquery\";");
                //strCodeForCs.AppendFormat("\r\n" + "//import * as QQ from \"q\";");
                List<ImportClass> arrImportClass = GetImportClassLst(objFuncModule);
                foreach (var objInFor in arrImportClass)
                {
                    strCodeForCs.AppendFormat("\r\n" + "import {{ {0} }} from \"{1}\";",
                      objInFor.ClassName,
                        objInFor.FilePath);
                }
            
                strCodeForCs.Append("\r\n" + " /**");
                strCodeForCs.Append("\r\n" + "* 宣布一个已经在存在的函数ShowDialog，用于显示对象框，");
                strCodeForCs.Append("\r\n" + "* strOpType：是操作类型，是三种类型之一：Add, Update, Detail");
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "declare function ShowDialog(strDialogName:string): void;", objViewInfoENEx.TabName_In);
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.Append("\r\n" + "* 宣布一个已经在存在的函数HideDialog，用于隐藏对象框，");
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "declare function HideDialog(strDialogName:string): void;", objViewInfoENEx.TabName_In);
                //strCodeForCs.Append("\r\n" + "/**");
                //strCodeForCs.Append("\r\n" + "* 宣布一个已经在其他地方定义存在的变量strUrl_Session_SetString，");
                //strCodeForCs.Append("\r\n" + "* 用于定义处理Session-设置String函数的地址");
                //strCodeForCs.Append("\r\n" + "*/");
                //strCodeForCs.Append("\r\n" + "declare var strUrl_Session_SetString:string;");
                //strCodeForCs.Append("\r\n" + "declare var strUrl_Session_GetString: string;");
                //strCodeForCs.Append("\r\n" + "/**");
                //strCodeForCs.Append("\r\n" + "* 宣布一个已经在其他地方定义存在的变量strCurrPrjId，");
                //strCodeForCs.Append("\r\n" + "* 用于定义当前工程Id");
                //strCodeForCs.Append("\r\n" + "*/");
                //strCodeForCs.Append("\r\n" + "declare var strCurrPrjId: string;");

                //strCodeForCs.Append("\r\n" + "declare var $;");
                strCodeForCs.Append("\r\n" + "import $ from \"jquery\";");


                strCodeForCs.AppendFormat("\r\n /* {0} 的摘要说明。其中Q代表查询,U代表修改",
                    objViewInfoENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "export abstract class {0} ", objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                if (objViewInfoENEx.objCacheClassifyFld4View != null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "public static {0}_Cache = \"\";",
                        objViewInfoENEx.objCacheClassifyFld4View.FldName);
                }
                List<string> arrFldName4StaticKeyId = new List<string>();
                var objFeatureRegionFlds_Detail = objViewInfoENEx.arrFeatureRegionFlds.Find(x => x.FeatureId == enumPrjFeature.DetailRecord_0239);
                if (objFeatureRegionFlds_Detail != null && objFeatureRegionFlds_Detail.KeyIdGetModeId == enumGCKeyIdGetMode.ViewStaticVariable_0002)
                {
                    if (arrFldName4StaticKeyId.Contains(objKeyField.FldName) == false)
                    {
                        arrFldName4StaticKeyId.Add(objKeyField.FldName);
                    }
                }
                List<string> arrFeatureId = new List<string>() { enumPrjFeature.UpdateRecord_0137, enumPrjFeature.UpdateRecord_0199 };
                var objFeatureRegionFlds_Update = objViewInfoENEx.arrFeatureRegionFlds.Find(x => arrFeatureId.Contains(x.FeatureId));

                if (objFeatureRegionFlds_Update != null && objFeatureRegionFlds_Update.KeyIdGetModeId == enumGCKeyIdGetMode.ViewStaticVariable_0002)
                {
                    if (arrFldName4StaticKeyId.Contains(objKeyField.FldName) == false)
                    {
                        arrFldName4StaticKeyId.Add(objKeyField.FldName);
                    }
                }
                arrFldName4StaticKeyId.ForEach(x =>
                {
                    string strDefaValue = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.DefaValue;
                    if (string.IsNullOrEmpty(strDefaValue) == true) strDefaValue = "\"\"";
                    strCodeForCs.AppendFormat("\r\n" + "public static {0}_Static: {1} = {2};",
                   x,
                   objKeyField.TypeScriptType, strDefaValue);
                });

                List<string> arrVarName = new List<string>();
                var arrQryRegionFlds = objViewInfoENEx.arrQryRegionFldSet.Where(x => x.CtlTypeId == enumCtlTypeAbbr.ViewVariable_38);
                if (arrQryRegionFlds.Count() > 0)
                {

                    foreach (var objInFor in arrQryRegionFlds)
                    {
                        string strVarName = "";
                        string strInitValue = "";
                        var objVar = clsGCVariableBL.GetObjByVarId_Cache(objInFor.VarId, objViewInfoENEx.PrjId);
                        if (objVar != null)
                        {
                            strVarName = objVar.VarExpression;
                            if (objInFor.ObjFieldTabENEx.TypeScriptType == "number")
                            {
                                strInitValue = objVar.InitValue;
                            }
                            else
                            {
                                strInitValue = string.Format("\"{0}\"", objVar.InitValue);
                            }
                        }
                        if (arrVarName.Contains(strVarName) == false && string.IsNullOrEmpty(strVarName) == false)
                        {
                            strCodeForCs.AppendFormat("\r\n" + " public static {0}: {1} = {2};",

                                    strVarName,
                                    objInFor.ObjFieldTabENEx.TypeScriptType,
                                    strInitValue);
                            arrVarName.Add(strVarName);
                        }
                    }
                }
                var arrDetailRegionFlds = objViewInfoENEx.arrDetailRegionFldSet.Where(x => x.CtlTypeId == enumCtlTypeAbbr.ViewVariable_38);
                if (arrDetailRegionFlds.Count() > 0)
                {

                    foreach (var objInFor in arrDetailRegionFlds)
                    {
                        string strVarName = "";
                        string strInitValue = "";
                        var objVar = clsGCVariableBL.GetObjByVarId_Cache(objInFor.VarId, objViewInfoENEx.PrjId);
                        if (objVar != null)
                        {
                            strVarName = objVar.VarExpression;
                            if (objInFor.ObjFieldTabENEx.TypeScriptType == "number")
                            {
                                strInitValue = objVar.InitValue;
                            }
                            else
                            {
                                strInitValue = string.Format("\"{0}\"", objVar.InitValue);
                            }
                        }
                        if (arrVarName.Contains(strVarName) == false && string.IsNullOrEmpty(strVarName) == false)
                        {
                            strCodeForCs.AppendFormat("\r\n" + " public static {0}: {1} = {2};",

                                    strVarName,
                                    objInFor.ObjFieldTabENEx.TypeScriptType,
                                    strInitValue);
                            arrVarName.Add(strVarName);
                        }
                    }
                }

                strCodeForCs.Append("\r\n" + "private iShowList: IShowList;");

                strCodeForCs.Append("\r\n" + "public mstrListDiv = \"divDataLst\";");
                strCodeForCs.Append("\r\n" + "public bolIsLoadDetailRegion = false;  //记录是否导入编辑区的变量");
               
                strCodeForCs.Append("\r\n" + "public divName4Detail = \"divDetail\";  //编辑区的Id");
                
                strCodeForCs.Append("\r\n" + "constructor(objShowList: IShowList) {");
                strCodeForCs.Append("\r\n" + "this.iShowList = objShowList;");
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "");
                /////生成界面中Page_Load代码;
                //strCodeForCs.Append("\r\n" + "#region 页面启动函数");

                /////生成界面中Page_Load代码;
                //strTemp = GenPage_LoadCode(false);
                //strCodeForCs.Append(strTemp);
                //strCodeForCs.Append("\r\n" + "#endregion 页面启动函数");
                //生成所有的函数
                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                    clsvFunction4GeneCodeBLEx.GetObjLstByViewInfoEx(objViewInfoENEx);

                //IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                //  clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(objViewInfoENEx.FunctionTemplateId,
                //          objViewInfoENEx.LangType, objViewInfoENEx.CodeTypeId, objViewInfoENEx.SqlDsTypeId);

                //IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLstByFeature = objViewInfoENEx.arrvFunction4GeneCodeSetByFeatureLst;
                //arrvFunction4GeneCodeObjLstByFeature = arrvFunction4GeneCodeObjLstByFeature.Where(x => x.CodeTypeId == objViewInfoENEx.CodeTypeId);

                //IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst_All = arrvFunction4GeneCodeObjLst.Union(arrvFunction4GeneCodeObjLstByFeature, 
                //    new VFunction4GeneCodeComparer());                
                //arrvFunction4GeneCodeObjLst_All = arrvFunction4GeneCodeObjLst_All.OrderBy(x => x.FuncName4Code);


                //为所有的函数定义相关输入控件
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

                clsPubFun4GC.Gen_WApi_Ts_ControlProperty(strCodeForCs, arrPropertyDef4GC, "this.divName4Detail");
       
                //strCodeForCs.Append("\r\n" + "}");
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

        public class PropertyDef4GCComparer : IEqualityComparer<clsPropertyDef4GC>
        {
            public bool Equals(clsPropertyDef4GC t1, clsPropertyDef4GC t2)
            {
                return (t1.OperateType == t2.OperateType && t1.PropertyName == t2.PropertyName);
            }
            public int GetHashCode(clsPropertyDef4GC t)
            {
                return t.ToString().GetHashCode();
            }
        }

        public void Gen_Vue_Ts_ControlProperty4One_NotInDiv(StringBuilder strCodeForCs, clsPropertyDef4GC x)
        {
            strCodeForCs.AppendFormat("\r\n /**");
            strCodeForCs.AppendFormat("\r\n * {0}", x.Comment);
            //strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            string strIsStatic = "";
            if (x.IsStatic) strIsStatic = "static";
            switch (x.OperateType)
            {
                case "get":
                    strCodeForCs.AppendFormat("\r\n" + "public {3} {0} {1}():{2} {{", x.OperateType, x.PropertyName, x.DataType, strIsStatic);

                    switch (x.ControlType)
                    {
                        case "checkbox":
                        case "CheckBox":
                            strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").prop(\"checked\");", x.CtrlId);
                            break;
                        case "input":
                        case "TextBox":
                            if (x.DataType == "number")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "var str{1} = $(\"#{0}\").val();", x.CtrlId, x.PropertyName);
                                strCodeForCs.AppendFormat("\r\n" + "if (IsNullOrEmpty(str{0})) return 0;", x.PropertyName);
                                strCodeForCs.AppendFormat("\r\n" + "return Number(str{0});", x.PropertyName);
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").val();", x.CtrlId);
                            }
                            break;
                        case "button":
                            strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").html();", x.CtrlId);
                            break;
                        case "dropdownlist":
                        case "DropDownList":

                            if (x.DataType == "boolean")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if ($(\"#{0}\").val() == \"0\") return false;", x.CtrlId);
                            }
                            else if (x.DataType == "number")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if ($(\"#{0}\").val() == \"0\") return 0;", x.CtrlId);
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if ($(\"#{0}\").val() == \"0\") return \"\";", x.CtrlId);
                            }

                            strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").val();", x.CtrlId);
                            break;
                        case "ViewVariable":
                            strCodeForCs.Append("\r\n" + "//界面变量(ViewVariable)");
                            strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                x.CtrlId);
                            strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "//缓存存在，直接返回");
                            strCodeForCs.Append("\r\n" + "var strValue:string = sessionStorage.getItem(strKey) as string;");
                            strCodeForCs.Append("\r\n" + "return strValue;");

                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "return \"\";");
                            break;
                        case "CacheClassifyField_TS":
                            strCodeForCs.Append("\r\n" + "//缓存分类字段(CacheClassifyField_TS)");
                            strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                x.CtrlId);
                            strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "//缓存存在，直接返回");
                            strCodeForCs.Append("\r\n" + "var strValue:string = sessionStorage.getItem(strKey) as string;");
                            strCodeForCs.Append("\r\n" + "return strValue;");

                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "return \"\";");
                            break;
                        case "GivenValue":
                            strCodeForCs.Append("\r\n" + "//针对给定值(GivenValue)");
                            strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                x.CtrlId);
                            strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "//缓存存在，直接返回");
                            strCodeForCs.Append("\r\n" + "var strValue:string = sessionStorage.getItem(strKey) as string;");
                            if (x.DataType == "number")
                            {
                                strCodeForCs.Append("\r\n" + "return Number(strValue);");
                            }
                            else
                            {
                                strCodeForCs.Append("\r\n" + "return strValue;");
                            }
                            strCodeForCs.Append("\r\n" + "}");
                            if (x.DataType == "number")
                            {
                                strCodeForCs.Append("\r\n" + "return 0;");
                            }
                            else
                            {
                                strCodeForCs.Append("\r\n" + "return \"\";");
                            }
                            break;
                        default:
                            strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").val();", x.CtrlId);
                            break;
                    }
                    break;
                case "set":
                    strCodeForCs.AppendFormat("\r\n" + "public {3} {0} {1}(value: {2}) {{", x.OperateType, x.PropertyName, x.DataType, strIsStatic);

                    switch (x.ControlType)
                    {
                        case "checkbox":
                        case "CheckBox":

                            strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").attr(\"checked\", value);", x.CtrlId);
                            break;
                        case "input":
                        case "TextBox":
                            strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").val(value);", x.CtrlId);
                            break;
                        case "button":
                            strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").html(value);", x.CtrlId);
                            break;
                        case "Label":
                            strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").html(value);", x.CtrlId);
                            break;
                        case "dropdownlist":
                        case "DropDownList":
                            strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").val(value);", x.CtrlId);
                            break;
                        case "ViewVariable":
                            strCodeForCs.Append("\r\n" + "//界面变量(ViewVariable)");
                            strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                x.CtrlId);
                            strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "//缓存存在，直接返回");
                            strCodeForCs.Append("\r\n" + "sessionStorage.removeItem(strKey);");
                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value.toString());");
                            break;
                        case "CacheClassifyField_TS":
                            strCodeForCs.Append("\r\n" + "//缓存分类字段(CacheClassifyField_TS)");
                            strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                x.CtrlId);
                            strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "//缓存存在，直接返回");
                            strCodeForCs.Append("\r\n" + "sessionStorage.removeItem(strKey);");
                            strCodeForCs.Append("\r\n" + "}");
                            strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value);");
                            break;
                        case "GivenValue":
                            strCodeForCs.Append("\r\n" + "//针对给定值(GivenValue)");
                            strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                x.CtrlId);
                            strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.Append("\r\n" + "//缓存存在，直接返回");
                            strCodeForCs.Append("\r\n" + "sessionStorage.removeItem(strKey);");
                            strCodeForCs.Append("\r\n" + "}");
                            if (x.DataType == "number")
                            {
                                strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value.toString());");
                            }
                            else
                            {
                                strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value);");
                            }
                            break;
                        default:
                            strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").val(value);", x.CtrlId);
                            break;
                    }
                    break;

            }
            strCodeForCs.Append("\r\n" + "}");

        }

        public void Gen_Vue_Ts_ControlPropertyBak(StringBuilder strCodeForCs)
        {
            var arrPropertyDef4GC2 = arrPropertyDef4GC.OrderBy(x => x.PropertyName).Distinct(new PropertyDef4GCComparer()).ToList();

            arrPropertyDef4GC2.ForEach(x =>
            {
                if (string.IsNullOrEmpty(x.ParentDivName) == true)
                {
                    Gen_Vue_Ts_ControlProperty4One_NotInDiv(strCodeForCs, x);
                    return;
                }
                strCodeForCs.AppendFormat("\r\n /**");
                strCodeForCs.AppendFormat("\r\n * {0}", x.Comment);
                //strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "*/");
                string strIsStatic = "";
                if (x.IsStatic) strIsStatic = "static";
                switch (x.OperateType)
                {
                    case "get":
                        strCodeForCs.AppendFormat("\r\n" + "public {3} {0} {1}():{2} {{", x.OperateType, x.PropertyName, x.DataType, strIsStatic);

                        strCodeForCs.Append("\r\n" + "const objDiv = $(`#${this.divName4Detail}`);");
                        //strCodeForCs.Append("\r\n" + "if (objDiv.length == 0)");
                        //strCodeForCs.Append("\r\n" + "{");
                        //strCodeForCs.Append("\r\n" + "const strMsg = Format(\"层:{0}不存在, 请检查！\", this.divName4Detail);");
                        //strCodeForCs.Append("\r\n" + "alert(strMsg);");
                        //switch (x.DataType)
                        //{
                        //    case "number":
                        //        strCodeForCs.Append("\r\n" + "return 0;");
                        //        break;
                        //    case "boolean":
                        //        strCodeForCs.Append("\r\n" + "return false;");
                        //        break;
                        //    case "string":
                        //        strCodeForCs.Append("\r\n" + "return \"\";");
                        //        break;
                        //    default:
                        //        strCodeForCs.Append("\r\n" + "return \"\";");
                        //        break;
                        //}
                        //strCodeForCs.Append("\r\n" + "}");

                        switch (x.ControlType)
                        {
                            case "checkbox":
                            case "CheckBox":
                                strCodeForCs.AppendFormat("\r\n" + "    CheckControlExist({1}, \"input\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"input[id ^= '{0}']\");", x.CtrlId);
                                strCodeForCs.Append("\r\n" + " objDiv.find(strId).prop(\"checked\");");

                                //strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").prop(\"checked\");", x.CtrlId);
                                break;
                            case "input":
                            case "TextBox":
                                strCodeForCs.AppendFormat("\r\n" + "    CheckControlExist({1}, \"input\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"input[id ^= '{0}']\");", x.CtrlId);
                                strCodeForCs.Append("\r\n" + " objDiv.find(strId).prop(\"checked\");");
                                if (x.DataType == "number")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + " var str{1} = objDiv.find(strId).val();", x.CtrlId, x.PropertyName);

                                    //strCodeForCs.AppendFormat("\r\n" + "var str{1} = $(\"#{0}\").val();", x.CtrlId, x.PropertyName);
                                    strCodeForCs.AppendFormat("\r\n" + "if (IsNullOrEmpty(str{0})) return 0;", x.PropertyName);
                                    strCodeForCs.AppendFormat("\r\n" + "return Number(str{0});", x.PropertyName);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + " return objDiv.find(strId).val();", x.CtrlId, x.PropertyName);

                                    //strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").val();", x.CtrlId);
                                }
                                //strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").val();", x.CtrlId);
                                break;
                            case "button":
                                strCodeForCs.AppendFormat("\r\n" + "    CheckControlExist({1}, \"button\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"button[id ^= '{0}']\");", x.CtrlId);

                                strCodeForCs.AppendFormat("\r\n" + " return objDiv.find(strId).html();", x.CtrlId, x.PropertyName);

                                //strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").html();", x.CtrlId);
                                break;
                            case "dropdownlist":
                            case "DropDownList":
                                strCodeForCs.AppendFormat("\r\n" + "    CheckControlExist({1}, \"select\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"select[id ^= '{0}']\");", x.CtrlId);

                                if (x.DataType == "boolean")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + " if (objDiv.find(strId).val() == \"0\") return false;", x.CtrlId);

                                    //                                    strCodeForCs.AppendFormat("\r\n" + "if ($(\"#{0}\").val() == \"0\") return false;", x.CtrlId);
                                }
                                else if (x.DataType == "number")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + " if (objDiv.find(strId).val() == \"0\") return 0;", x.CtrlId);

                                    //strCodeForCs.AppendFormat("\r\n" + "if ($(\"#{0}\").val() == \"0\") return 0;", x.CtrlId);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + " if (objDiv.find(strId).val() == \"0\") return \"\";", x.CtrlId);

                                    //strCodeForCs.AppendFormat("\r\n" + "if ($(\"#{0}\").val() == \"0\") return \"\";", x.CtrlId);
                                }
                                strCodeForCs.AppendFormat("\r\n" + " return objDiv.find(strId).val();", x.CtrlId, x.PropertyName);

                                //strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").val();", x.CtrlId);
                                break;
                            case "ViewVariable":
                                strCodeForCs.Append("\r\n" + "//界面变量(ViewVariable)");
                                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                    x.CtrlId);
                                strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "//缓存存在，直接返回");
                                strCodeForCs.Append("\r\n" + "var strValue:string = sessionStorage.getItem(strKey) as string;");
                                strCodeForCs.Append("\r\n" + "return strValue;");

                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "return \"\";");
                                break;
                            case "CacheClassifyField_TS":
                                strCodeForCs.Append("\r\n" + "//缓存分类字段(CacheClassifyField_TS)");
                                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                    x.CtrlId);
                                strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "//缓存存在，直接返回");
                                strCodeForCs.Append("\r\n" + "var strValue:string = sessionStorage.getItem(strKey) as string;");
                                strCodeForCs.Append("\r\n" + "return strValue;");

                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "return \"\";");
                                break;
                            case "GivenValue":
                                strCodeForCs.Append("\r\n" + "//针对给定值(GivenValue)");
                                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                    x.CtrlId);
                                strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "//缓存存在，直接返回");
                                strCodeForCs.Append("\r\n" + "var strValue:string = sessionStorage.getItem(strKey) as string;");
                                if (x.DataType == "number")
                                {
                                    strCodeForCs.Append("\r\n" + "return Number(strValue);");
                                }
                                else
                                {
                                    strCodeForCs.Append("\r\n" + "return strValue;");
                                }
                                strCodeForCs.Append("\r\n" + "}");
                                if (x.DataType == "number")
                                {
                                    strCodeForCs.Append("\r\n" + "return 0;");
                                }
                                else
                                {
                                    strCodeForCs.Append("\r\n" + "return \"\";");
                                }
                                break;
                            default:
                                strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").val();", x.CtrlId);
                                break;
                        }
                        break;
                    case "set":
                        strCodeForCs.AppendFormat("\r\n" + "public {3} {0} {1}(value: {2}) {{", x.OperateType, x.PropertyName, x.DataType, strIsStatic);
                        strCodeForCs.Append("\r\n" + "const objDiv = $(`#${this.divName4Detail}`);");
                        //strCodeForCs.Append("\r\n" + "if (objDiv.length == 0)");
                        //strCodeForCs.Append("\r\n" + "{");
                        //strCodeForCs.Append("\r\n" + "const strMsg = Format(\"层:{0}不存在, 请检查！\", this.divName4Detail);");
                        //strCodeForCs.Append("\r\n" + "alert(strMsg);");
                        //strCodeForCs.Append("\r\n" + "return;");
                        //strCodeForCs.Append("\r\n" + "}");


                        switch (x.ControlType)
                        {
                            case "checkbox":
                            case "CheckBox":
                                strCodeForCs.AppendFormat("\r\n" + "    CheckControlExist({1}, \"input\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"input[id ^= '{0}']\");", x.CtrlId);
                                strCodeForCs.Append("\r\n" + " objDiv.find(strId).attr(\"checked\", value);");

                                //strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").attr(\"checked\", value);", x.CtrlId);
                                break;
                            case "input":
                            case "TextBox":
                                strCodeForCs.AppendFormat("\r\n" + "    CheckControlExist({1}, \"input\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"input[id ^= '{0}']\");", x.CtrlId);
                                strCodeForCs.Append("\r\n" + " objDiv.find(strId).val(value);");

                                //strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").val(value);", x.CtrlId);
                                break;
                            case "button":
                                strCodeForCs.AppendFormat("\r\n" + "    CheckControlExist({1}, \"button\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"button[id ^= '{0}']\");", x.CtrlId);
                                strCodeForCs.Append("\r\n" + " objDiv.find(strId).html(value);");

                                //strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").html(value);", x.CtrlId);
                                break;
                            case "Label":
                                strCodeForCs.AppendFormat("\r\n" + "    CheckControlExist({1}, \"label\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"label[id ^= '{0}']\");", x.CtrlId);
                                strCodeForCs.Append("\r\n" + " objDiv.find(strId).html(value);");

                                //strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").html(value);", x.CtrlId);
                                break;
                            case "dropdownlist":
                            case "DropDownList":
                                strCodeForCs.AppendFormat("\r\n" + "    CheckControlExist({1}, \"select\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"select[id ^= '{0}']\");", x.CtrlId);
                                strCodeForCs.Append("\r\n" + " objDiv.find(strId).val(value);");

                                //strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").val(value);", x.CtrlId);
                                break;
                            case "ViewVariable":
                                strCodeForCs.Append("\r\n" + "//界面变量(ViewVariable)");
                                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                    x.CtrlId);
                                strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "//缓存存在，直接返回");
                                strCodeForCs.Append("\r\n" + "sessionStorage.removeItem(strKey);");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value.toString());");
                                break;
                            case "CacheClassifyField_TS":
                                strCodeForCs.Append("\r\n" + "//缓存分类字段(CacheClassifyField_TS)");
                                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                    x.CtrlId);
                                strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "//缓存存在，直接返回");
                                strCodeForCs.Append("\r\n" + "sessionStorage.removeItem(strKey);");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value);");
                                break;
                            case "GivenValue":
                                strCodeForCs.Append("\r\n" + "//针对给定值(GivenValue)");
                                strCodeForCs.AppendFormat("\r\n" + "const strKey = Format(\"{0}\");",
                                    x.CtrlId);
                                strCodeForCs.Append("\r\n" + " if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey))");
                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.Append("\r\n" + "//缓存存在，直接返回");
                                strCodeForCs.Append("\r\n" + "sessionStorage.removeItem(strKey);");
                                strCodeForCs.Append("\r\n" + "}");
                                if (x.DataType == "number")
                                {
                                    strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value.toString());");
                                }
                                else
                                {
                                    strCodeForCs.Append("\r\n" + "sessionStorage.setItem(strKey, value);");
                                }
                                break;
                            default:
                                strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").val(value);", x.CtrlId);
                                break;
                        }
                        break;

                }
                strCodeForCs.Append("\r\n" + "}");
            });
        }


        public string Gen_Vue_Ts_Demo_Session(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "/**");
            strCodeForCs.Append("\r\n" + "演示Session 操作");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.Append("\r\n" + "public async Demo_Session()");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.Demo_Session.name;",
       objViewInfoENEx.TabName, objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//设置Session");
            strCodeForCs.Append("\r\n" + "var strUserId = \"TestUserId\";");
            strCodeForCs.Append("\r\n" + "await this.SetSessionAsync(\"UserId\", strUserId);");
            strCodeForCs.Append("\r\n" + "//获取Session");
            strCodeForCs.Append("\r\n" + "var strUserId_Value1 = await this.GetSessionAsync(\"UserId\");");
            strCodeForCs.Append("\r\n" + "console.log('strUserId_Value1:' + strUserId_Value1);");
            strCodeForCs.Append("\r\n" + "//获取Session方法2：直接读取页面中的hidUserId");
            //          strCodeForCs.Append("\r\n" + "var strUserId_Value2 = $('#hidUserId').val();");
            strCodeForCs.Append("\r\n" + "var strUserId_Value2 = this.hidUserId;");


            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "get",
                ControlType = "input",
                CtrlId = "hidUserId",
                PropertyName = "hidUserId",
                Comment = "用户Id",
                DataType = "string"
            });
            strCodeForCs.Append("\r\n" + "console.log('strUserId_Value2:' + strUserId_Value2);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"演示Session不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }


        public string Gen_Vue_Ts_SetSessionAsync(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "/**");
            strCodeForCs.Append("\r\n" + "设置Session");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "<param name = \"Key\">关键字</param>");
            strCodeForCs.Append("\r\n" + "<param name = \"Value\">值</param>");
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.Append("\r\n" + "public SetSessionAsync(Key: string, Value: string): Promise<void> {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.SetSessionAsync.name;",
       objViewInfoENEx.TabName, objKeyField.FldName);
            //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

            strCodeForCs.Append("\r\n" + "return new Promise(function(resolve, reject) {");
            strCodeForCs.Append("\r\n" + "            $.ajax({");
            strCodeForCs.Append("\r\n" + "url: strUrl_Session_SetString,");
            strCodeForCs.Append("\r\n" + "cache: false,");
            strCodeForCs.Append("\r\n" + "async: false,");
            strCodeForCs.Append("\r\n" + "type: 'get',");
            strCodeForCs.Append("\r\n" + "dataType: \"json\",");
            strCodeForCs.Append("\r\n" + "data: {");
            strCodeForCs.Append("\r\n" + "Key: Key,");
            strCodeForCs.Append("\r\n" + "Value: Value");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "success: function (data) {");
            strCodeForCs.Append("\r\n" + "var strKey = data.key;");
            strCodeForCs.Append("\r\n" + "var strValue = data.value;");


            strCodeForCs.Append("\r\n" + "console.log('strKey, strValue=' + strKey + strValue);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_Vue_Ts_GetSessionAsync(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "/**");
            strCodeForCs.Append("\r\n" + "获取Session 关键字的值");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "<param name = \"Key\">关键字</param>");
            strCodeForCs.Append("\r\n" + " <return>值</return>");
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.Append("\r\n" + "public GetSessionAsync(Key: string): Promise<string> {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.GetSessionAsync.name;",
       objViewInfoENEx.TabName, objKeyField.FldName);
            
            //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");


            strCodeForCs.Append("\r\n" + "return new Promise(function(resolve, reject) {");
            strCodeForCs.Append("\r\n" + "            $.ajax({");
            strCodeForCs.Append("\r\n" + "url: strUrl_Session_GetString,");
            strCodeForCs.Append("\r\n" + "cache: false,");
            strCodeForCs.Append("\r\n" + "async: false,");
            strCodeForCs.Append("\r\n" + "type: 'get',");
            strCodeForCs.Append("\r\n" + "dataType: \"json\",");
            strCodeForCs.Append("\r\n" + "data: {");
            strCodeForCs.Append("\r\n" + "Key: Key,");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "success: function (data) {");
            strCodeForCs.Append("\r\n" + "var strKey = data.key;");
            strCodeForCs.Append("\r\n" + "var strValue = data.value;");

            strCodeForCs.Append("\r\n" + "console.log('strKey, strValue=' + strKey + strValue);");

            strCodeForCs.Append("\r\n" + "resolve(data);");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"网络错误！访问网络不成功！\");");
            strCodeForCs.Append("\r\n" + "reject(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "reject(result.statusText);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_Vue_Ts_SetKeyReadOnly()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //生成私有代码;
                if (objKeyField.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    foreach (clsDetailRegionFldsENEx objDetailRegionFldsEx in objViewInfoENEx.arrDetailRegionFldSet4InUse)
                    {
                        if (objDetailRegionFldsEx.FldName != objKeyField.ObjFieldTabENEx.FldName) continue;
                        strCodeForCs.Append("\r\n" + "/// <summary>");
                        strCodeForCs.Append("\r\n" + "/// 在用户自定义控件中，设置关键字的值，是否只读");
                        strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + "/// </summary>");
                        strCodeForCs.Append("\r\n" + "/// <param name = \"bolReadonly\">是否只读</param>");
                        strCodeForCs.Append("\r\n" + "public SetKeyReadOnly(bolReadonly:boolean)");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.SetKeyReadOnly.name;",
       objViewInfoENEx.TabName, objKeyField.FldName);
                        //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

                        strCodeForCs.AppendFormat("\r\n" + "$('#{0}').prop['ReadOnly'] = bolReadonly;", objDetailRegionFldsEx.CtrlId);
                        strCodeForCs.Append("\r\n" + "}");
                    }
                }
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_Vue_Ts_Clear()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //生成私有代码;
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// 清除用户自定义控件中，所有控件的值");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>	");
                strCodeForCs.Append("\r\n" + "public Clear()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.Clear.name;",
       objViewInfoENEx.TabName, objKeyField.FldName);
                //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

                foreach (clsDetailRegionFldsENEx objDetailRegionFldsEx in objViewInfoENEx.arrDetailRegionFldSet4InUse)
                {


                    if (objDetailRegionFldsEx.InUse == false) continue;
                    if (objDetailRegionFldsEx.ObjFieldTabENEx == null) continue;
                    if (objDetailRegionFldsEx.ObjFieldTabENEx == null) continue;
                    if (objDetailRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                    && objDetailRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        continue;
                    }
                    try
                    {
                        arrPropertyDef4GC.Add(new clsPropertyDef4GC
                        {
                            OperateType = "set",
                            ControlType = objDetailRegionFldsEx.CtlTypeName,
                            CtrlId = objDetailRegionFldsEx.CtrlId,
                            PropertyName = objDetailRegionFldsEx.FldName,
                            Comment = string.Format("{0} (Used In {1})", objDetailRegionFldsEx.ObjFieldTabENEx.Caption,
                                        "Clear()"),
                            DataType = objDetailRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType
                        });
                        string strInitValue = objDetailRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue4Var(this.objViewInfoENEx.objCodeType.ProgLangTypeId);

                        switch (objDetailRegionFldsEx.objCtlTypeAbbr.CtlTypeName)
                        {
                            case "Button":
                                break;
                            case "CheckBox":
                                if (objDetailRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "this.{0} = false;",
                                    objDetailRegionFldsEx.FldName);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "this.{0} = {1};",
                                    objDetailRegionFldsEx.FldName,
                                    objDetailRegionFldsEx.ObjFieldTabENEx.DefaultValue);
                                }
                                break;
                            case "CheckBoxList":
                                break;
                            case "DataGrid":
                                break;
                            case "DataList":
                                break;
                            case "DropDownList": ///如果控件是下拉框;
                                strCodeForCs.AppendFormat("\r\n" + "$('#{0} option[0]').attr(\"selected\", true);",
                                objDetailRegionFldsEx.CtrlId);
                                break;
                            case "HyperLink":
                                break;
                            case "Image":
                                break;
                            case "ImageButton":
                                break;
                            case "Label":
                                break;
                            case "Link1Button":
                                break;
                            case "ListBox":
                                break;
                            case "Panel":
                                break;
                            case "RadioButton":
                                break;
                            case "RadioButtonList":
                                break;
                            case "TextBox": ///如果控件类型是文本框;
                                if (objDetailRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "this.{0} = {1};",
                                    objDetailRegionFldsEx.FldName, strInitValue);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "this.{0} = \"{1}\";",
                                        objDetailRegionFldsEx.FldName, objDetailRegionFldsEx.ObjFieldTabENEx.DefaultValue);
                                }

                                break;
                            default:
                                strCodeForCs.AppendFormat("\r\n" + "this.{0} = {1};",
                                 objDetailRegionFldsEx.FldName, strInitValue);
                                break;
                        }
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("生成字段:{0}时出错！{1}(In {2})", objDetailRegionFldsEx.FldName,
                            objException.Message,
                            clsStackTrace.GetCurrClassFunction());
                        clsPubVar4BLEx.objLog4GC.WriteDebugLog(strMsg);
                    }
                }
                strCodeForCs.Append("\r\n" + "}");
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }

        //生成插入记录准备过程代码
        private void iShowList_BindGv(StringBuilder strCode)
        {
            if (objViewInfoENEx.IsUseCache4List == true)
            {
                strCode.AppendFormat("\r\n" + "this.iShowList.BindGv_Cache(cls{0}EN._CurrTabName, \"\");", objViewInfoENEx.TabName_Out);
            }
            else
            {
                strCode.AppendFormat("\r\n" + "this.iShowList.BindGv(cls{0}EN._CurrTabName, \"\");", objViewInfoENEx.TabName_Out);
            }
        }
        private void await_iShowList_BindGv(StringBuilder strCode)
        {
            if (objViewInfoENEx.IsUseCache4List == true)
            {
                strCode.AppendFormat("\r\n" + "const conShowList = await this.iShowList.BindGv_Cache(cls{0}EN._CurrTabName, \"\");", objViewInfoENEx.TabName_Out);
            }
            else
            {
                strCode.AppendFormat("\r\n" + "const conShowList = await this.iShowList.BindGv(cls{0}EN._CurrTabName, \"\");", objViewInfoENEx.TabName_Out);
            }
        }

        public string Gen_Vue_Ts_ShowTabObj(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 显示{0}对象的所有属性值");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());

            strCodeForCs.Append("\r\n  <param name = \"divContainer\">显示容器</param>");
            strCodeForCs.AppendFormat("\r\n  <param name = \"obj{0}\">需要显示的对象</param>",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "public Show{0}Obj(divContainer: string, obj{0}: cls{0}EN) ",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.Show{0}Obj.name;",
       objViewInfoENEx.TabName, objKeyField.FldName);
            
            //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");
            strCodeForCs.Append("\r\n" + "var o = document.getElementById(divContainer);");
            strCodeForCs.Append("\r\n" + "if (o == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(Format(\"{0}不存在！\",divContainer));");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "const sstrKeys = GetObjKeys(obj{0});",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "var ul: HTMLUListElement = document.createElement(\"ul\");");

            strCodeForCs.Append("\r\n" + "for (const strKey of sstrKeys)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strValue = obj{0}.GetFldValue(strKey);",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "var li: HTMLLIElement = document.createElement(\"li\");");
            strCodeForCs.Append("\r\n" + "li.innerHTML = Format(\"{0}:{1}\", strKey, strValue);");
            strCodeForCs.Append("\r\n" + "ul.appendChild(li);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "o.appendChild(ul);");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }




        public string Gen_Vue_Ts_SelectRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* ");
            strCodeForCs.Append("\r\n " + "根据关键字选择相应的记录");

            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n  <param name = \"sender\">参数列表</param>");
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "public async SelectRecord({0}: {1}) ",
                 objKeyField.PrivFuncName,
                  objKeyField.TypeScriptType);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.SelectRecord.name;",
       objViewInfoENEx.TabName, objKeyField.FldName);

           
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;
            //clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;

            //strCodeForCs.AppendFormat("\r\n" + "var strKeyId: string = $('#txtstrKeyId{0}').val();",
            //        objvFunction4GeneCodeEN.OrderNum);

            if (objDataTypeAbbrEN.IsNeedQuote == true)
            {
                //strCodeForCs.AppendFormat("\r\n" + "var {0}: {1} = strKeyId;",
                //  objKeyField.PrivFuncName,
                //  objKeyField.TypeScriptType);
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

                        //strCodeForCs.AppendFormat("\r\n" + "var {1}: {0} = Number(strKeyId);",
                        //    objDataTypeAbbrEN.TypeScriptType,
                        //    objKeyField.PrivFuncName);
                        break;
                    default:
                        string strMsg = string.Format("数据类型：[{0}({1})](TypeScript:{2})在函数中没有处理！({3})",
                            objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                            objDataTypeAbbrEN.TypeScriptType,
                            clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                }
            }
            //strCodeForCs.Append("\r\n" + "return new Promise((resolve, reject) => {");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");


            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN = await {0}_GetObjBy{1}Async({2});",
                objViewInfoENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);


            strCodeForCs.AppendFormat("\r\n" + "console.log(\"完成SelectRecord!\", obj{0}EN);", objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "Redirect(\"/Index/Main_{0}\");", objViewInfoENEx.TabName_Out);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"根据关键字获取相应的记录的对象不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }


        public string Gen_Vue_Ts_DetailRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (bolIsUseFunc4Detail == true) return "";
            //clsDetailRegionEN objDetailRegion = null;
            clsViewRegionEN objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.DetailRegion_0006);
            if (objViewRegion == null || objViewRegion.InUseInViewInfo(objViewInfoENEx) == false) return "";

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* ");
            strCodeForCs.Append("\r\n " + "根据关键字详细信息记录");

            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n  <param name = \"sender\">参数列表</param>");
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "public async DetailRecord({0}: {1}) ",
                 objKeyField.PrivFuncName,
                  objKeyField.TypeScriptType);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.DetailRecord.name;",
       objViewInfoENEx.TabName, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "this.btnSubmit_d_{0} = \"\";", objViewInfoENEx.TabName_Out);
            strCodeForCs.AppendFormat("\r\n" + "this.btnCancel_d_{0} = \"关闭\";", objViewInfoENEx.TabName_Out);
            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "set",
                ControlType = "button",
                CtrlId = string.Format("btnSubmit_d_{0}", objViewInfoENEx.TabName_Out),
                PropertyName = string.Format("btnSubmit_d_{0}", objViewInfoENEx.TabName_Out),
                Comment = "设置确定按钮的标题(Used In DetailRecord())",
                DataType = "string"
            });

            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "set",
                ControlType = "button",
                CtrlId = string.Format("btnCancel_d_{0}", objViewInfoENEx.TabName_Out),
                PropertyName = string.Format("btnCancel_d_{0}", objViewInfoENEx.TabName_Out),
                Comment = "设置取消按钮的标题(Used In DetailRecord())",
                DataType = "string"
            });

            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;

            if (objDataTypeAbbrEN.IsNeedQuote == true)
            {
                //strCodeForCs.AppendFormat("\r\n" + "var {0}: {1} = strKeyId;",
                //  objKeyField.PrivFuncName,
                //  objKeyField.TypeScriptType);
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

                        //strCodeForCs.AppendFormat("\r\n" + "var {1}: {0} = Number(strKeyId);",
                        //    objDataTypeAbbrEN.TypeScriptType,
                        //    objKeyField.PrivFuncName);
                        break;
                    default:
                        string strMsg = string.Format("数据类型：[{0}({1})](TypeScript:{2})在函数中没有处理！({3})",
                            objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                            objDataTypeAbbrEN.TypeScriptType,
                            clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                }
            }

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");


            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN = await {0}_GetObjBy{1}Async({2});",
                objViewInfoENEx.TabName_Out,
                objKeyField.FldName,
                objKeyField.PrivFuncName);

            strCodeForCs.AppendFormat("\r\n" + "this.ShowDetailDataFrom{0}Class(obj{0}EN);",
                objViewInfoENEx.TabName_Out);
            strCodeForCs.AppendFormat("\r\n" + "console.log(\"完成DetailRecord!\");", objViewInfoENEx.TabName_Out);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"显示详细信息不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_Vue_Ts_DetailRecord4Func(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (bolIsUseFunc4Detail == false) return "";
            //clsDetailRegionEN objDetailRegion = null;
            clsViewRegionEN objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.DetailRegion_0006);
            if (objViewRegion == null || objViewRegion.InUseInViewInfo(objViewInfoENEx) == false) return "";

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* ");
            strCodeForCs.Append("\r\n " + "根据关键字详细信息记录");

            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n  <param name = \"sender\">参数列表</param>");
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "public async DetailRecord4Func({0}: {1}) ",
                 objKeyField.PrivFuncName,
                  objKeyField.TypeScriptType);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.DetailRecord4Func.name;",
       objViewInfoENEx.TabName, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "this.btnSubmit_d_{0} = \"\";", objViewInfoENEx.TabName_Out);
            strCodeForCs.AppendFormat("\r\n" + "this.btnCancel_d_{0} = \"关闭\";", objViewInfoENEx.TabName_Out);
            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "set",
                ControlType = "button",
                CtrlId = string.Format("btnSubmit_d_{0}", objViewInfoENEx.TabName_Out),
                PropertyName = string.Format("btnSubmit_d_{0}", objViewInfoENEx.TabName_Out),
                Comment = "设置确定按钮的标题(Used In DetailRecord())",
                DataType = "string"
            });

            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "set",
                ControlType = "button",
                CtrlId = string.Format("btnCancel_d_{0}", objViewInfoENEx.TabName_Out),
                PropertyName = string.Format("btnCancel_d_{0}", objViewInfoENEx.TabName_Out),
                Comment = "设置取消按钮的标题(Used In DetailRecord())",
                DataType = "string"
            });

            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;

            if (objDataTypeAbbrEN.IsNeedQuote == true)
            {
                //strCodeForCs.AppendFormat("\r\n" + "var {0}: {1} = strKeyId;",
                //  objKeyField.PrivFuncName,
                //  objKeyField.TypeScriptType);
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

                        //strCodeForCs.AppendFormat("\r\n" + "var {1}: {0} = Number(strKeyId);",
                        //    objDataTypeAbbrEN.TypeScriptType,
                        //    objKeyField.PrivFuncName);
                        break;
                    default:
                        string strMsg = string.Format("数据类型：[{0}({1})](TypeScript:{2})在函数中没有处理！({3})",
                            objDataTypeAbbrEN.DataTypeName, objDataTypeAbbrEN.DataTypeId,
                            objDataTypeAbbrEN.TypeScriptType,
                            clsStackTrace.GetCurrClassFunction());
                        throw new Exception(strMsg);
                }
            }

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");


            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN = await {0}_GetObjBy{1}Async({2});",
                objViewInfoENEx.TabName_Out,
                objKeyField.FldName,
                objKeyField.PrivFuncName);

            strCodeForCs.AppendFormat("\r\n" + "var obj{0}ENEx = this.CopyToEx(obj{0}EN);", strTabName_Out4Detail);
            strCodeForCs.AppendFormat("\r\n" + "const conFuncMap = await this.FuncMap4Detail(obj{0}ENEx);", strTabName_Out4Detail);

            strCodeForCs.AppendFormat("\r\n" + "this.ShowDetailDataFrom{0}Class4Func(obj{0}ENEx);",
                objViewInfoENEx.TabName_Out);
            strCodeForCs.AppendFormat("\r\n" + "console.log(\"完成DetailRecord4Func!\");", objViewInfoENEx.TabName_Out);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"显示详细信息4Func不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_Vue_Ts_GetObjLst4DdlBind(clsViewInfoENEx objViewInfoENEx, string strTabName, string strValueFld, string strTextFld)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 根据条件获取相应的对象列表");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");

            strCodeForCs.AppendFormat("\r\n" + "public async btnGetObjLst_Click() ",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnGetObjLst_Click.name;",
       objViewInfoENEx.TabName, objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "strWhereCond =\" 1=1 \";");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "var arr{0}ObjLst: Array<cls{0}EN> = await {0}_GetObjLstAsync(strWhereCond);",
                objViewInfoENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "cls{0}EN objFirstObj = new cls{0}EN();", objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "objFirstObj.{0} = \"0\";",
               strValueFld, strTextFld);
            strCodeForCs.AppendFormat("\r\n" + "objFirstObj.{0} = \"请选择...\";", strTextFld);
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst.add(0, objFirstObj);",
                strTabName);
            strCodeForCs.AppendFormat("\r\n" + "{1}.arr{0}ObjLst_Cache = arr{0}ObjLst;",
                strTabName, objViewInfoENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "mspnObject.setPrompt(\"请选择您的{0}: \");", objViewInfoENEx.objMainPrjTab.TabCnName);

            strCodeForCs.AppendFormat("\r\n" + "if (mobjDdlAdapter{0} == null)", strTabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "mobjDdlAdapter{0} = new ddlAdapter{0}(macPage, arr{0}ObjLst);",
                strTabName);
            strCodeForCs.Append("\r\n" + "}");
            //            userStateAdapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
            strCodeForCs.AppendFormat("\r\n" + "mspnObject.setAdapter(mobjDdlAdapter{0});",
                strTabName);
            //strCodeForCs.Append("\r\n" + "SendMessage(\"没有使用缓存！\");");
            strCodeForCs.AppendFormat("\r\n" + "mobjParentObjDelegate.NotifyFinished(\"BindDdl_{0}, 没有使用缓存！\", 1);",
                strTabName);

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"根据条件获取相应的下拉框对象列表不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

       
        public string Gen_Vue_Ts_btnDetailRecordInTab_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsViewRegionEN objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.DetailRegion_0006);
            if (objViewRegion == null || objViewRegion.InUseInViewInfo(objViewInfoENEx) == false) return "";

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* ");
            strCodeForCs.Append("\r\n 在数据表里详细信息记录");

            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.Append("\r\n" + "public async btnDetailRecordInTab_Click(strKeyId:string) {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnDetailRecordInTab_Click.name;",
       objViewInfoENEx.TabName, objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "this.OpType = \"Detail\";");

            clsPropertyDef4GC objPropertyDef4GC = new clsPropertyDef4GC
            {
                OperateType = "set",
                ControlType = "input",
                CtrlId = "hidOpType",
                PropertyName = "OpType",
                Comment = "设置操作类型：Add||Update||Detail",
                DataType = "string"
            };
            arrPropertyDef4GC.Add(objPropertyDef4GC);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "const arrKeyIds = clsCommFunc4Ctrl.GetCheckedKeyIds();");
            strCodeForCs.Append("\r\n" + " if (strKeyId == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"请选择需要详细信息的记录！\");");
            strCodeForCs.Append("\r\n" + "return \"\";");
            strCodeForCs.Append("\r\n" + "}");
            string strSuffix4Func = "";//后缀4Func
            if (bolIsUseFunc4Detail == true) strSuffix4Func = "4Func";
            //strCodeForCs.Append("\r\n" + "$(\"#Text1\").val(\"进入函数：btnDelete4Gv_Click\");");
            if (objKeyField.TypeScriptType == "number")
            {
                strCodeForCs.Append("\r\n" + "var lngKeyId =  Number(strKeyId);");

                strCodeForCs.AppendFormat("\r\n" + "this.DetailRecord{0}(lngKeyId);",
                 strSuffix4Func);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "this.DetailRecord{0}(strKeyId);",
                    strSuffix4Func);
            }


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"详细信息记录不成功. {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_Vue_Ts_btnDetailRecord_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            clsViewRegionEN objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.DetailRegion_0006);
            if (objViewRegion == null || objViewRegion.InUseInViewInfo(objViewInfoENEx) == false) return "";

            var objFeatureRegionFlds_Detail = objViewInfoENEx.arrFeatureRegionFlds.Find(x => x.FeatureId == enumPrjFeature.DetailRecord_0239);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 修改记录");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.Append("\r\n" + "public async btnDetailRecord_Click(strKeyId:string) {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnDetailRecord_Click.name;",
       objViewInfoENEx.TabName, objKeyField.FldName);
            //strCodeForCs.Append("\r\n" + "$('#hidOpType').val(\"Update\");");
            strCodeForCs.Append("\r\n" + "this.OpType_d = \"Detail\";");


            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "set",
                ControlType = "input",
                CtrlId = "hidOpType_d",
                PropertyName = "OpType_d",
                Comment = "设置操作类型：Add||Update||Detail",
                DataType = "string"
            });
            if (objFeatureRegionFlds_Detail == null
                || string.IsNullOrEmpty(objFeatureRegionFlds_Detail.KeyIdGetModeId)
                || objFeatureRegionFlds_Detail.KeyIdGetModeId == enumGCKeyIdGetMode.ListCheckedRecord_0001)
            {
                strCodeForCs.Append("\r\n" + "if (IsNullOrEmpty(strKeyId) == true)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = \"需要显示详细信息记录的关键字为空，请检查！\";");
                strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");

                strCodeForCs.Append("\r\n" + "}");
            }
            else if (objFeatureRegionFlds_Detail.KeyIdGetModeId == enumGCKeyIdGetMode.ViewStaticVariable_0002)
            {
                strCodeForCs.AppendFormat("\r\n" + "var strKeyId = {0}.{1}_Static;", this.ClsName, objKeyField.FldName);
                if (objKeyField.IsNumberType() == true)
                {
                    strCodeForCs.Append("\r\n" + "    if (strKeyId == 0)");
                }
                else
                {
                    strCodeForCs.Append("\r\n" + "    if (strKeyId == \"\")");
                }
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(\"在显示详细信息时，界面静态关键字为空！(In btnDetailRecord_Click)\");");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
            }
            strCodeForCs.AppendFormat("\r\n" + "if (this.bolIsLoadDetailRegion == false)  //", objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const responseBool = await this.AddDPV_Detail(this.divName4Detail);", objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n // 为编辑区绑定下拉框");
            strCodeForCs.AppendFormat("\r\n" + "//const conBindDdl = await this.BindDdl4DetailRegion();", objViewInfoENEx.ClsName);

           
            strCodeForCs.AppendFormat("\r\n" + "this.bolIsLoadDetailRegion = true;  //", objViewInfoENEx.ClsName);
            string strSuffix4Func = "";//后缀4Func
            if (bolIsUseFunc4Detail == true) strSuffix4Func = "4Func";
            if (objKeyField.TypeScriptType == "number")
            {
                strCodeForCs.Append("\r\n" + "var lngKeyId =  Number(strKeyId);");

                strCodeForCs.AppendFormat("\r\n" + "this.DetailRecord{0}(lngKeyId);",
                 strSuffix4Func);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "this.DetailRecord{0}(strKeyId);",
                    strSuffix4Func);
            }
            if (objViewRegion.PageDispModeId == enumPageDispMode.PopupBox_01)
            {
                strCodeForCs.AppendFormat("\r\n" + "this.ShowDialog_{0}('Detail');", objViewInfoENEx.TabName_In);
            }
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
           
            if (objKeyField.TypeScriptType == "number")
            {
                strCodeForCs.Append("\r\n" + "var lngKeyId =  Number(strKeyId);");

                strCodeForCs.AppendFormat("\r\n" + "this.DetailRecord{0}(lngKeyId);",
                 strSuffix4Func);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "this.DetailRecord{0}(strKeyId);",
                    strSuffix4Func);
            }
            if (objViewRegion.PageDispModeId == enumPageDispMode.PopupBox_01)
            {
                strCodeForCs.AppendFormat("\r\n" + "this.ShowDialog_{0}('Detail');", objViewInfoENEx.TabName_In);
            }
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }


    
        Func<clsvViewFeatureFldsENEx, ASPDropDownListEx> GetDdlObj2 = obj => clsASPDropDownListBLEx.GetDropDownLst_Asp(obj, new clsGetTabFieldObj());



        private void GC_GetInputValue4Para_TS(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, StringBuilder strCodeForCs)
        {
            clsFunction4GeneCodeEN objFunction4GeneCodeEN = clsFunction4GeneCodeBL.GetObjByFuncId4GC_Cache(objvFunction4GeneCodeEN.FuncId4GC);

            string strMsg = "";
            //            StringBuilder strCodeForCs = new StringBuilder();
            List<clsFuncPara4CodeEN> arrFuncPara4CodeObjLst =
            clsFuncPara4CodeBLEx.GetObjListByFuncId4Code_CacheEx(objFunction4GeneCodeEN.FuncId4Code, enumFunctionPurpose.GeneCode_01);
            if (arrFuncPara4CodeObjLst != null)
            {
                foreach (clsFuncPara4CodeEN objFuncPara4CodeEN in arrFuncPara4CodeObjLst)
                {
                    clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeId_Cache(objFuncPara4CodeEN.DataTypeId);
                    clsSelfDefDataTypeEN objSelfDefDataTypeEN_Para = null;
                    if (objDataTypeAbbrEN == null)
                    {
                        objSelfDefDataTypeEN_Para = clsSelfDefDataTypeBLEx.getSelfDefDataTypeByDataTypeName(objFuncPara4CodeEN.ParameterType);
                        if (objSelfDefDataTypeEN_Para == null)
                        {
                            strMsg = string.Format("函数参数的数据类型：[{0}({1})]没有处理，不能生成相应代码。", objDataTypeAbbrEN.DataTypeId,
                                objFuncPara4CodeEN.ParameterType);
                            throw new Exception(strMsg);
                        }
                    }
                    if (objFuncPara4CodeEN.IsByRef == true)
                    {
                        strMsg = string.Format("Java函数参数的不接受引用型参数。参数名：[{0}]，数据类型：[{1}]没有处理，不能生成相应代码。",
                           objFuncPara4CodeEN.ParaName,
                             objFuncPara4CodeEN.ParameterType);
                        throw new Exception(strMsg);
                    }
                    else
                    {
                        if (objDataTypeAbbrEN.IsNeedQuote == true)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "var {1}: {0} = $('#txt{1}{2}').val();",
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
                                    strCodeForCs.AppendFormat("\r\n" + "var {1}:{0} = Number($('#txt{1}{2}').val());",
                                        objDataTypeAbbrEN.TypeScriptType,
                                        objFuncPara4CodeEN.ParaName,
                                        objvFunction4GeneCodeEN.OrderNum);
                                    break;
                                case enumDataTypeAbbr.Array_31:
                                    strCodeForCs.AppendFormat("\r\n" + "var {1}:{0} = $('#txt{1}{2}').val();",
                                        objDataTypeAbbrEN.TypeScriptType,
                                        objFuncPara4CodeEN.ParaName,
                                        objvFunction4GeneCodeEN.OrderNum);
                                    break;
                                default:
                                    strMsg = string.Format("数据类型：[{0}({1})](TypeScript:{2})在函数中没有处理！({3})",
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
        public string Gen_Vue_Ts_GetDataFromClass(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /* 函数功能:把类对象的属性内容显示到界面上");
                strCodeForCs.Append("\r\n 注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值");
                strCodeForCs.Append("\r\n  如果在设置数据库时,就应该一级字段在前,二级字段在后");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n  <param name = \"pobj{0}EN\">表实体类对象</param>",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "public GetDataFrom{0}Class(pobj{2}EN: cls{1}EN )",
                objViewInfoENEx.TabName, objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.GetDataFrom{0}Class.name;",
       objViewInfoENEx.TabName, objKeyField.FldName);
                //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

                foreach (clsDetailRegionFldsENEx objDetailRegionFldsEx in objViewInfoENEx.arrDetailRegionFldSet4InUse)
                {
                    string strTemp = GetCode4FieldInGetDataFromClass(objDetailRegionFldsEx, objViewInfoENEx);
                    strCodeForCs.AppendFormat("{0}", strTemp);

                }
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

        public string Gen_Vue_Ts_ShowDetailDataFromClass(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (bolIsUseFunc4Detail == true) return "";
            //clsDetailRegionEN objDetailRegion = null;
            clsViewRegionEN objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.DetailRegion_0006);
            if (objViewRegion == null || objViewRegion.InUseInViewInfo(objViewInfoENEx) == false) return "";

            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /* 函数功能:把类对象的属性内容显示到界面的详细信息区域中");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n  <param name = \"pobj{0}EN\">表实体类对象</param>",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "public ShowDetailDataFrom{0}Class(pobj{2}EN: cls{1}EN )",
                           objViewInfoENEx.TabName_Out, objViewInfoENEx.TabName_Out, objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.ShowDetailDataFrom{0}Class.name;",
       objViewInfoENEx.TabName_Out, objKeyField.FldName);
  
                //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

                foreach (clsDetailRegionFldsENEx objDetailRegionFldsEx in objViewInfoENEx.arrDetailRegionFldSet4InUse)
                {
                    string strTemp = GetCode4FieldInShowDetailDataFromClass(objDetailRegionFldsEx, objViewInfoENEx);
                    strCodeForCs.AppendFormat("{0}", strTemp);

                }
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

        private string GetCode4FieldInShowDetailDataFromClass(clsDetailRegionFldsENEx objDetailRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {
   
            StringBuilder sbCodeForCs = new StringBuilder();

            if (objDetailRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objDetailRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }
            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "set",
                ControlType = objDetailRegionFldsEx.CtlTypeName,
                CtrlId = objDetailRegionFldsEx.CtrlId + "_d",
                PropertyName = objDetailRegionFldsEx.PropertyName() + "_d",
                Comment = string.Format("{0} (Used In {1})", objDetailRegionFldsEx.ObjFieldTabENEx.Caption,
                                        "ShowDetailDataFromClass()"),
                DataType = objDetailRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
                ParentDivName = "this.divName4Detail"
            });
            switch (objDetailRegionFldsEx.CtlTypeId)
            {
                case enumCtlTypeAbbr.CheckBox_02:
                    //7、设置checkbox为选中状态
                    //$('input:checkbox').attr("checked", 'checked');//or
                    //$('input:checkbox').attr("checked", true);
                    //8、设置checkbox为不选中状态
                    //$('input:checkbox').attr("checked", '');//or
                    //$('input:checkbox').attr("checked", false);
                    sbCodeForCs.AppendFormat("\r\n" + "this.{2}_d = pobj{1}EN.{2};",
                                objDetailRegionFldsEx.CtrlId,
                                objViewInfoENEx.TabName_Out,
                                objDetailRegionFldsEx.FldName);
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
                case enumCtlTypeAbbr.GivenValue_35:
                    sbCodeForCs.AppendFormat("\r\n" + "// this.{2}_d = pobj{1}EN.{2};",
                                objDetailRegionFldsEx.CtrlId,
                                objViewInfoENEx.TabName_Out,
                                objDetailRegionFldsEx.FldName);
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
                case enumCtlTypeAbbr.DropDownList_06:
                    sbCodeForCs.AppendFormat("\r\n" + " this.{2}_d = pobj{1}EN.{2};",
                                objDetailRegionFldsEx.CtrlId,
                                objViewInfoENEx.TabName_Out,
                                objDetailRegionFldsEx.FldName);
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
                case enumCtlTypeAbbr.CacheClassifyField_37:
                    sbCodeForCs.AppendFormat("\r\n" + "// this.{2}_d = pobj{1}EN.{2};",
                         objDetailRegionFldsEx.CtrlId,
                         objViewInfoENEx.TabName_Out,
                         objDetailRegionFldsEx.FldName);
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
                default:
                    sbCodeForCs.AppendFormat("\r\n" + " this.{2}_d = pobj{1}EN.{2};",
                                objDetailRegionFldsEx.CtrlId,
                                objViewInfoENEx.TabName_Out,
                                objDetailRegionFldsEx.FldName);
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
            }

            return sbCodeForCs.ToString();
        }


        private string GetCode4FieldInGetDataFromClass(clsDetailRegionFldsENEx objDetailRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {

            StringBuilder sbCodeForCs = new StringBuilder();


            if (objDetailRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objDetailRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }
            if (objDetailRegionFldsEx.CtlTypeId != enumCtlTypeAbbr.ViewVariable_38)
            {
                arrPropertyDef4GC.Add(new clsPropertyDef4GC
                {
                    OperateType = "set",
                    ControlType = objDetailRegionFldsEx.CtlTypeName,
                    CtrlId = objDetailRegionFldsEx.CtrlId,
                    PropertyName = objDetailRegionFldsEx.FldName,
                    Comment = string.Format("{0} (Used In {1})", objDetailRegionFldsEx.ObjFieldTabENEx.Caption,
                                        "GetDataFromClass()"),
                    DataType = objDetailRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType
                });
            }
            switch (objDetailRegionFldsEx.CtlTypeId)
            {
                case enumCtlTypeAbbr.CheckBox_02:
                    //7、设置checkbox为选中状态
                    //$('input:checkbox').attr("checked", 'checked');//or
                    //$('input:checkbox').attr("checked", true);
                    //8、设置checkbox为不选中状态
                    //$('input:checkbox').attr("checked", '');//or
                    //$('input:checkbox').attr("checked", false);
                    sbCodeForCs.AppendFormat("\r\n" + "this.{2} = pobj{1}EN.{2};",
                                objDetailRegionFldsEx.CtrlId,
                                objViewInfoENEx.TabName,
                                objDetailRegionFldsEx.PropertyName());
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
                case enumCtlTypeAbbr.GivenValue_35:
                    sbCodeForCs.AppendFormat("\r\n" + "// this.{2} = pobj{1}EN.{2};",
                                objDetailRegionFldsEx.CtrlId,
                                objViewInfoENEx.TabName,
                                objDetailRegionFldsEx.PropertyName());
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
                case enumCtlTypeAbbr.DropDownList_06:
                    sbCodeForCs.AppendFormat("\r\n" + " this.{2} = pobj{1}EN.{2};",
                                objDetailRegionFldsEx.CtrlId,
                                objViewInfoENEx.TabName,
                                objDetailRegionFldsEx.PropertyName());
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
                case enumCtlTypeAbbr.CacheClassifyField_37:
                    sbCodeForCs.AppendFormat("\r\n" + "// this.{2} = pobj{1}EN.{2};",
                         objDetailRegionFldsEx.CtrlId,
                         objViewInfoENEx.TabName,
                         objDetailRegionFldsEx.FldName);
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
                default:
                    sbCodeForCs.AppendFormat("\r\n" + " this.{2} = pobj{1}EN.{2};",
                                objDetailRegionFldsEx.CtrlId,
                                objViewInfoENEx.TabName,
                                objDetailRegionFldsEx.PropertyName());
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
            }

            return sbCodeForCs.ToString();
        }
        public string Gen_Vue_Ts_GetFirstKey()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /* 函数功能:从界面列表中获取第一个关键字的值");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n  <param name = \"pobj{0}EN\">表实体类对象</param>",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n <returns>列表的第一个关键字值</returns>");
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.Append("\r\n" + "public GetFirstKey(): string {");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.GetFirstKey.name;",
       objViewInfoENEx.TabName, objKeyField.FldName);
//strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");


                strCodeForCs.Append("\r\n" + "if (arrSelectedKeys.length == 1) {");
                strCodeForCs.Append("\r\n" + "return arrSelectedKeys[0];");

                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "else {");

                strCodeForCs.Append("\r\n" + "alert(`请选择一个关键字！目前选择了:${ arrSelectedKeys.length}个关键字。`);");
                strCodeForCs.Append("\r\n" + "return \"\";");

                strCodeForCs.Append("\r\n" + "}");

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

        public string Gen_Vue_Ts_IndexPage()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /* 函数功能:在数据 列表中跳转到某一页");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n  <param name = \"intPageIndex\">页序号</param>",
                        objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.Append("\r\n" + "public IndexPage(intPageIndex:number)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.IndexPage.name;",
       objViewInfoENEx.TabName, objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "if (intPageIndex == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "intPageIndex = this.objPager.pageCount;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "console.log(\"跳转到\" + intPageIndex + \"页\");");

                //strCodeForCs.Append("\r\n" + "this1.CurrPageIndex = intPageIndex;");
                strCodeForCs.Append("\r\n" + "this.SetCurrPageIndex(intPageIndex);");
                arrPropertyDef4GC.Add(new clsPropertyDef4GC
                {
                    OperateType = "set",
                    ControlType = "input",
                    CtrlId = "hidCurrPageIndex",
                    PropertyName = "CurrPageIndex",
                    Comment = "设置当前页序号",
                    DataType = "number"

                });
                //strCodeForCs.AppendFormat("\r\n" + "this.BindGv_{1}{2}();",
                //    objViewInfoENEx.TabName, objViewInfoENEx.TabName_Out, objViewInfoENEx.IsUseCache4List ? "_Cache" : "");
                await_iShowList_BindGv(strCodeForCs);

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


        /// <summary>
        /// 功能:单表的查询、修改、插入、删除
        /// </summary>
        /// <returns></returns>
        public string GenFunctionRegion(clsViewRegionEN objDGRegionENEx, clsViewInfoENEx objViewInfoENEx)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //int iDGHeight;      //DataGrid的高度
            //int iDG_Div_Left;
            if (objViewInfoENEx.arrDGRegionFldSet == null || objViewInfoENEx.arrDGRegionFldSet.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有DataGrid区域,或者DataGrid区域没有字段。请检查!", strViewName);
                throw new clsDbObjException(sbMessage.ToString());
            }

       
            try
            {
                ///生成插入记录的界面代码;
                //objViewInfoENEx.objViewRegion_List.Style_Zindex() = intZIndex + 1;
                //objViewInfoENEx.objViewRegion_List.Style_Left = (int)intCurrLeft;
                //objViewInfoENEx.objViewRegion_List.Style_Top = (int)intCurrTop;

                //iDGHeight = objViewInfoENEx.objViewRegion_List.Height + 50;


                strCodeForCs.AppendFormat("\r\n" + "<div id = \"divFunction\" class = \"div_Funttion\" runat = \"server\">",
                  objViewInfoENEx.TabName, intCurrTop);

                //if (objViewInfoENEx.objViewRegion_List.IsCheck() == true || objViewInfoENEx.objViewRegion_List.IsRadio() == true)
                //{
                //strCodeForCs.AppendFormat("\r\n" + "<tr>");
                //strCodeForCs.AppendFormat("\r\n" + "<td>");
                //添加层div
                ASPHtmlTableEx objASPNETHtmlTableENEx = clsASPHtmlTableBLEx.GettabGridFunction();
                ASPRowEx objASPNETRowENEx = clsASPRowBLEx.GetEmptyTr();
                objASPNETHtmlTableENEx.arrSubAspControlLst2.Add(objASPNETRowENEx);

                ASPColEx objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);
                //列表标题
                ASPLabelEx objASPNETLabelENEx = clsASPLabelBLEx.GetDataListTitle(objViewInfoENEx);
                objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETLabelENEx);

                //

                //strCodeForCs.AppendFormat("\r\n" + "<table id = \"tabGridFunction\" style = \"width: 100%; height: 32px\" class = \"msgtable\" >");
                //strCodeForCs.AppendFormat("\r\n" + "<tr>");
                //strCodeForCs.Append("\r\n" + "<td>");

                //strCodeForCs.AppendFormat("\r\n" + "<asp:label id = \"lbl{0}List\" runat = \"server\" style = \"z-index: 105; \" ",
                //  objViewInfoENEx.TabName);
                //strCodeForCs.AppendFormat("\r\n" + "CssClass = \"h6\" Width = \"250px\">{0}列表</asp:label>",
                //  objViewInfoENEx.objInRelaTab.TabCnName);
                //strCodeForCs.Append("\r\n" + "</td>");

                //iDG_Div_Left = 390;//第一个按钮的左为390
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd
                  || objViewInfoENEx.objViewTypeCodeTab.IsHaveExeAdd)
                {
                    objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                    ASPHtmlButtonEx objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnAddNewRec4Gv();
                    objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                    objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);
                    //strCodeForCs.Append("\r\n" + "<td>");

                    //strCodeForCs.AppendFormat("\r\n" + "<asp:button id = \"btnAddNewRec4Gv\" runat = \"server\" OnClick = \"btnAddNewRec4Gv_Click\" style = \"z-index: 106; \"",
                    //  iDG_Div_Left);
                    //strCodeForCs.AppendFormat("\r\n" + "Width = \"80px\" CssClass = \"btn btn-primary btn-sm\" Text = \"添加记录\"></asp:button>");
                    //strCodeForCs.Append("\r\n" + "</td>");
                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveDel == true)
                {
                    objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                    ASPHtmlButtonEx objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnDelete4Gv();
                    objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                    objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);
                    //iDG_Div_Left += 85;
                    //strCodeForCs.Append("\r\n" + "<td>");
                    //strCodeForCs.AppendFormat("\r\n" + "<asp:button id = \"btnDelete4Gv\" OnClick = \"btnDelete4Gv_Click\" style = \"z-index: 104; \" runat = \"server\"",
                    //  iDG_Div_Left);
                    //strCodeForCs.AppendFormat("\r\n" + "Width = \"80px\" CssClass = \"btn btn-primary btn-sm\" Text = \"删除记录\"></asp:button>");
                    //strCodeForCs.Append("\r\n" + "</td>");
                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate == true)
                {

                    objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                    ASPHtmlButtonEx objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnUpdate4Gv();
                    objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                    objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                    //iDG_Div_Left += 85;
                    //strCodeForCs.Append("\r\n" + "<td>");
                    //strCodeForCs.AppendFormat("\r\n" + "<asp:button id = \"btnUpdate4Gv\" OnClick = \"btnUpdate4Gv_Click\" style = \"z-index: 105; \" runat = \"server\"",
                    //  iDG_Div_Left);
                    //strCodeForCs.AppendFormat("\r\n" + "Width = \"80px\" CssClass = \"btn btn-primary btn-sm\" Text = \"修改记录\"></asp:button>");
                    //strCodeForCs.Append("\r\n" + "</td>");
                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExeUpdate)
                {

                    objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                    ASPHtmlButtonEx objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnUpdate4Gv();
                    objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                    objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                    //iDG_Div_Left += 85;
                    //strCodeForCs.Append("\r\n" + "<td>");
                    //strCodeForCs.AppendFormat("\r\n" + "<asp:button id = \"btnUpdate4Gv\" OnClick = \"btnUpdate4Gv_Click\" style = \"z-index: 105; \" runat = \"server\"",
                    //  iDG_Div_Left);
                    //strCodeForCs.AppendFormat("\r\n" + "Width = \"80px\" CssClass = \"btn btn-primary btn-sm\" Text = \"修改记录\"></asp:button>");
                    //strCodeForCs.Append("\r\n" + "</td>");
                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveDetail == true)
                {

                    objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                    //clsInpu
                    ASPHtmlButtonEx objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnDetail4Gv();
                    objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                    objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                    //iDG_Div_Left += 85;
                    //strCodeForCs.Append("\r\n" + "<td>");
                    //strCodeForCs.AppendFormat("\r\n" + "<asp:button id = \"btnDetail4Gv\" style = \"z-index: 105; \" runat = \"server\"",
                    //  iDG_Div_Left);
                    //strCodeForCs.AppendFormat("\r\n" + "Width = \"80px\" CssClass = \"btn btn-primary btn-sm\" Text = \"详细信息\"></asp:button>");
                    //strCodeForCs.Append("\r\n" + "</td>");
                }
                if (objViewInfoENEx.arrFeatureId.Contains("0142") == true)
                {
                    //List<ASPHtmlButtonEx> arrAspNetButton4AdjustOrderNum = new List<ASPHtmlButtonEx>();
                    objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                    ASPHtmlButtonEx objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnGoTop();
                    objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                    objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                    objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                    objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnUpMove();
                    objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                    objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                    objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                    objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnDownMove();
                    objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                    objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                    objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                    objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnGoBottum();
                    objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                    objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                    objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                    objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnReOrder();
                    objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                    objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                    //foreach (ASPHtmlButtonEx objInfor in arrAspNetButton4AdjustOrderNum)
                    //{
                    //    clsASPHtmlButtonBLEx.GeneCode(objInfor, strCodeForCs);

                    //}
                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExcelExport == true)
                {
                    objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                    ASPHtmlButtonEx objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnExportExcel4Gv();
                    objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                    objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                    //iDG_Div_Left += 85;
                    //strCodeForCs.Append("\r\n" + "<td>");

                    //strCodeForCs.AppendFormat("\r\n" + "<asp:button id = \"btnExportExcel4Gv\" OnClick = \"btnExportExcel4Gv_Click\" ",
                    //  iDG_Div_Left);
                    //strCodeForCs.AppendFormat("\r\n" + "runat = \"server\" Width = \"80px\" CssClass = \"btn btn-primary btn-sm\" Text = \"导出Excel\"></asp:button>");
                    //strCodeForCs.Append("\r\n" + "</td>");
                }
                if (objViewInfoENEx.IsNeedSetExportFld == true &&
                      objViewInfoENEx.objViewTypeCodeTab.IsHaveSetExportExcel == true)
                {
                    objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                    ASPHtmlButtonEx objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnSetExportExcel4User();
                    objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                    objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                    //iDG_Div_Left += 85;
                    //strCodeForCs.Append("\r\n" + "<td>");

                    //strCodeForCs.AppendFormat("\r\n" + "<asp:button id = \"btnSetExportExcel4User\" OnClick = \"btnSetExportExcel4User_Click\" ",
                    //  iDG_Div_Left);
                    //strCodeForCs.AppendFormat("\r\n" + "runat = \"server\" Width = \"100px\" CssClass = \"btn btn-primary btn-sm\" Text = \"设置导出字段\"></asp:button>");
                    //strCodeForCs.Append("\r\n" + "</td>");
                }

                //层结束
                //strCodeForCs.AppendFormat("\r\n" + "</tr>");
                //strCodeForCs.Append("\r\n" + "</table>");
                objASPNETHtmlTableENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs);

                //}
                //生成GridView的代码;


                strCodeForCs.AppendFormat("\r\n" + "</div>");

                intCurrTop += 45;

            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

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
            clsTitleStyleEN objTitleStyle = clsTitleStyleBL.GetObjByTitleStyleId_Cache(objViewInfoENEx.objViewStyleEN.TitleStyleId);
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp;     ///临时变量;
            ///生成Label的代码;
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


        /// <summary>
        /// 生成CheckBox控件
        /// </summary>
        /// <param name = "objCheckStyle"></param>
        /// <returns></returns>
        public string GenCheckBoxNoPosition(clsCheckStyleEN objCheckStyle, string strCheckId, string strCheckText)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp;     ///临时变量;
            try
            {
                objCheckStyle.Style_Zindex = intZIndex + 1;
                objCheckStyle.Style_Left = (int)intCurrLeft;
                objCheckStyle.Style_Top = (int)intCurrTop;

                ///生成CheckBox的代码;
                ///
                //生成控件的<开始标志>和<ID>
                strCodeForCs.Append("\r\n" + "<td>");
                strCodeForCs.AppendFormat("\r\n" + "<asp:CheckBox id = \"{0}\" ",
                  strCheckId);
                //生成<控件样式Style>
                //生成<高度>和<宽度>
                strCodeForCs.AppendFormat("\r\n" + "style = \"z-index: {0}; Width:{1}px; Height:{2}px;\" ",
                  objCheckStyle.Style_Zindex,
                  objCheckStyle.Width, objCheckStyle.Height);
                //生成运行模式是否在服务器运行
                strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" ",
                  objCheckStyle.Runat);

                //生成<字号>和<字体>
                //strCodeForCs.AppendFormat("\r\n" + "Font-Size = \"{0}\" Font-Names = \"{1}\" ", 
                //  objCheckStyle.FontSize, objCheckStyle.FontName);
                //生成<显示文本> 
                strCodeForCs.AppendFormat("\r\n" + "Text = \"{0}\" ", strCheckText);

                //生成<结束标志>
                strCodeForCs.Append("\r\n" + "CssClass = \"Check_Defa\"></asp:CheckBox>");

                strCodeForCs.Append("\r\n" + "</td>");

                intZIndex += 1;

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
        /// 生成{组合控件},即左边的标签,和右边的输入条件的控件
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
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp;     ///临时变量;
            objLabelStyle.Style_Zindex = intZIndex + 1;
            objLabelStyle.Style_Left = (int)intCurrLeft;
            objLabelStyle.Style_Top = (int)intCurrTop;
            ///生成Label的代码;
            ///      
            strCodeForCs.Append("\r\n" + "<td>");

            strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"{0}\" style = \"z-index: {1};\" ",
              strLabelId, objLabelStyle.Style_Zindex, objLabelStyle.Width, objLabelStyle.Height);
            strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" CssClass = \"NameLabel\">",
              objLabelStyle.Runat);
            strCodeForCs.AppendFormat("{0}</asp:Label>",
              strLabelText);
            strCodeForCs.Append("\r\n" + "</td>");

            intZIndex += 1;

            objGenCtlStyle.Style_Zindex = intZIndex + 1;
            objGenCtlStyle.Style_Left = (int)intCurrLeft + objLabelStyle.Width + 5;
            //objGenCtlStyle.Style_Left = (int)intCurrLeft + 5;
            objGenCtlStyle.Style_Top = (int)intCurrTop;
            ///生成右边控件的代码;
            strCodeForCs.Append("\r\n" + "<td>");

            strCodeForCs.AppendFormat("\r\n" + "<asp:{0} id = \"{1}\" style = \"z-index: {2}; \" ",
              strCtlTypeName, strCtlId, objGenCtlStyle.Style_Zindex, objGenCtlStyle.Width, objGenCtlStyle.Height);

            strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" CssClass = \"TextBox_Defa\">",
              objGenCtlStyle.Runat);
            strCodeForCs.AppendFormat("\r\n" + "</asp:{0}>",
              strCtlTypeName);
            strCodeForCs.Append("\r\n" + "</td>");

            intZIndex += 1;
            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 生成Button控件
        /// </summary>
        /// <param name = "objCheckStyle"></param>
        /// <returns></returns>
        public string GenButtonNoPosition(clsButtonStyleEN objButtonStyle, string strButtonId, string strButtonText, string strOnClick)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp;     ///临时变量;
            try
            {
                objButtonStyle.Style_Zindex = intZIndex + 1;
                objButtonStyle.Style_Left = (int)intCurrLeft;
                objButtonStyle.Style_Top = (int)intCurrTop;

                ///生成Button的代码;
                ///
                //生成控件的<开始标志>和<ID>
                strCodeForCs.AppendFormat("\r\n" + "<asp:Button id = \"{0}\" ",
                  strButtonId);
                //生成<控件样式Style>
                //生成<高度>和<宽度>
                strCodeForCs.AppendFormat("\r\n" + "style = \"z-index: {0}; Width:{2}px; Height:{3}px;\" ",
                  objButtonStyle.Style_Zindex, objButtonStyle.Style_Left,
                  objButtonStyle.Width, objButtonStyle.Height);

                //生成运行模式是否在服务器运行
                strCodeForCs.AppendFormat("\r\n" + "runat = \"{0}\" ",
                  objButtonStyle.Runat);

                //生成<字号>和<字体>
                //				strCodeForCs.AppendFormat("\r\n" + "Font-Size = \"{0}\" Font-Names = \"{1}\" ", 
                //					objButtonStyle.FontSize, objButtonStyle.FontName);
                //生成<显示文本> 
                strCodeForCs.AppendFormat("\r\n" + "Text = \"{0}\" CssClass = \"btn btn-primary btn-sm\" ", strButtonText);
                //生成单击事件
                strCodeForCs.AppendFormat("\r\n" + "OnClick = \"{0}\" ", strOnClick);

                //生成<结束标志>
                strCodeForCs.Append("\r\n" + "></asp:Button>");

                intZIndex += 1;

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
        /// 定义用于编辑的层Div，该层可以被弹出
        /// </summary>
        /// <param name="objvFunction4GeneCodeEN"></param>
        /// <returns></returns>
        public string Gen_Vue_Ts_DefDiv4DetailRegion()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.AppendFormat("\r\n" + " <div class=\"modal fade\" id=\"divEditDialog_{0}\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"lblDialogTitle_{0}\" aria-hidden=\"true\">",
                objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + " <div class=\"modal-dialog\">");
            strCodeForCs.Append("\r\n" + " <div class=\"modal-content\">");
            strCodeForCs.Append("\r\n" + " <div class=\"modal-header\">");
            strCodeForCs.AppendFormat("\r\n" + " <h4 class=\"modal-title\" id=\"lblDialogTitle_{0}\">模态框（Modal）标题</h4>", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + " <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-hidden=\"true\">&times;</button>");
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " <div class=\"modal-body\">");
            strCodeForCs.Append("\r\n" + " <table style=\"width: 100%;\">");

            foreach (clsDetailRegionFldsENEx objDetailRegionFldsEx in objViewInfoENEx.arrDetailRegionFldSet4InUse)
            {
                ///如果该字段不是标识递增型就生成控件,否则就不生成;
                if (objDetailRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objDetailRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                strCodeForCs.AppendFormat("\r\n" + "<tr>");
                //strCodeForCs.AppendFormat("\r\n" + "<td>");
                ///插入验证控件代码;
                switch (objDetailRegionFldsEx.ObjFieldTabENEx.CsType)
                {
                    case "bool":
                        strCodeForCs.AppendFormat("\r\n" + "<td colspan='2'>");
                        strCodeForCs.AppendFormat("\r\n" + "<asp:CheckBox id = \"chk{0}\" runat = \"server\" Text = \"{1}\" CssClass = \"Check_Defa\"></asp:CheckBox>",
                          objDetailRegionFldsEx.FldName,
                          objDetailRegionFldsEx.LabelCaption);
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
                          "lbl" + objDetailRegionFldsEx.FldName,
                          objDetailRegionFldsEx.LabelCaption);
                        strCodeForCs.AppendFormat("\r\n" + "</td>");
                        strCodeForCs.AppendFormat("\r\n" + "<td class = \"ValueTD\">");
                        strCodeForCs.AppendFormat("\r\n" + "<asp:TextBox id = \"txt{0}\" runat = \"server\" CssClass = \"ValueControl\"></asp:TextBox>",
                          objDetailRegionFldsEx.FldName,
                          objDetailRegionFldsEx.LabelCaption);
                        strCodeForCs.AppendFormat("\r\n" + "</td>");
                        break;
                    default:
                        strCodeForCs.AppendFormat("\r\n" + "<td class = \"NameTD\">");
                        strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"{0}\" runat = \"server\" CssClass = \"NameControl\">{1}</asp:Label>",
                          "lbl" + objDetailRegionFldsEx.FldName,
                          objDetailRegionFldsEx.LabelCaption);
                        strCodeForCs.AppendFormat("\r\n" + "</td>");
                        strCodeForCs.AppendFormat("\r\n" + "<td class = \"ValueTD\">");
                        strCodeForCs.AppendFormat("\r\n" + "<asp:{0} id = \"{1}\" runat = \"server\" CssClass = \"ValueControl\"></asp:{0}>",
                          objDetailRegionFldsEx.objCtlTypeAbbr.CtlTypeName,
                            objDetailRegionFldsEx.CtrlId,
                          objDetailRegionFldsEx.LabelCaption);
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
            strCodeForCs.AppendFormat("\r\n" + " <button type=\"button\" class=\"btn btn-primary\" onclick=\"Submit_{0}()\">提交更改</button>", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " <!-- /.modal-content -->");
            strCodeForCs.Append("\r\n" + " </div>");
            strCodeForCs.Append("\r\n" + " <!-- /.modal -->");
            strCodeForCs.Append("\r\n" + " </div>");

            return strCodeForCs.ToString();
        }

        public string Gen_Vue_Ts_ShowData()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate
|| objViewInfoENEx.objViewTypeCodeTab.IsHaveDetail)
                {
                    strCodeForCs.Append("\r\n /* 函数功能:把以该关键字的记录内容显示在界面上,");
                    strCodeForCs.Append("\r\n 　　　   在这里是把值传到表控件中");
                    strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.AppendFormat("\r\n  <param name = \"{0}\">表记录的关键字,显示该表关键字的内容</param>",
                      objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "*/");

                    strCodeForCs.AppendFormat("\r\n" + "  public async ShowData({0}: {1}) {{",
                        objKeyField.PrivFuncName, objKeyField.TypeScriptType);
                    strCodeForCs.Append("\r\n" + "        //操作步骤:");
                    strCodeForCs.Append("\r\n" + "        //1、检查关键字是否为空；");
                    strCodeForCs.Append("\r\n" + "        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；");
                    strCodeForCs.Append("\r\n" + "        //3、用提供的关键字初始化一个类对象；");
                    strCodeForCs.Append("\r\n" + "        //4、获取类对象的所有属性；");
                    strCodeForCs.Append("\r\n" + "        //5、把该对象的所有属性显示在界面上,在这里显示在表控件中");
                    strCodeForCs.Append("\r\n" + "        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；");
                    strCodeForCs.AppendFormat("\r\n" + "        let obj{0}EN = new cls{0}EN();",
                        objViewInfoENEx.TabName_In);
                    strCodeForCs.Append("\r\n" + "        try {");
                    strCodeForCs.AppendFormat("\r\n" + "            const returnBool = await {0}_IsExistAsync({1});",
                        objViewInfoENEx.TabName_In, objKeyField.PrivFuncName);

                    strCodeForCs.Append("\r\n" + "            if (returnBool == false) {");
                    strCodeForCs.AppendFormat("\r\n" + "                const strInfo = Format(\"关键字:[{{0}}] 的记录不存在!\", {0});",
                         objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "                //$('#lblResult1').val(strInfo);");
                    strCodeForCs.Append("\r\n" + "                //显示信息框");
                    strCodeForCs.Append("\r\n" + "                alert(strInfo);");
                    strCodeForCs.Append("\r\n" + "            }");
                    strCodeForCs.Append("\r\n" + "            else {");
                    //                    strCodeForCs.Append("\r\n" + "                const strInfo = Format(\"关键字:[${strExam1TypeId}]的相关记录存在!\");");
                    //                  strCodeForCs.Append("\r\n" + "                //$('#lblResult1').val(strInfo);");
                    //                strCodeForCs.Append("\r\n" + "                //显示信息框");
                    //              strCodeForCs.Append("\r\n" + "                alert(strInfo);");
                    strCodeForCs.Append("\r\n" + "            }");
                    strCodeForCs.Append("\r\n" + "        }");
                    strCodeForCs.Append("\r\n" + "        catch (e) {");
                    strCodeForCs.Append("\r\n" + "            const strMsg = Format(\"检查相应关键字的记录存在不成功, {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "            alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "        }");
                    strCodeForCs.Append("\r\n" + "        try {");
                    strCodeForCs.AppendFormat("\r\n" + "            obj{0}EN = await {0}_GetObjBy{1}Async({2});",
                        objViewInfoENEx.TabName_In, objKeyField.FldName, objKeyField.PrivFuncName);
          
                    strCodeForCs.Append("\r\n" + "        }");
                    strCodeForCs.Append("\r\n" + "        catch (e) {");
                    strCodeForCs.Append("\r\n" + "            const strMsg = Format(\"根据关键字获取相应的记录的对象不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "            alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "        }");

                    strCodeForCs.Append("\r\n" + "        //3、用提供的关键字初始化一个类对象；");

                    strCodeForCs.AppendFormat("\r\n" + "        this.GetDataFrom{0}Class(obj{0}EN);",
                        objViewInfoENEx.TabName_In);


                    strCodeForCs.Append("\r\n" + "}");
                }
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public override string A_GeneFuncCode(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN, ref clsFunction4CodeEN Re_objFunction4Code)
        {
            return A_GeneFuncCodeBase(objvFunction4GeneCodeEN, typeof(Vue_ViewScript_DetailCS_TS4TypeScriptBak));
            //string strFuncName = objvFunction4GeneCodeEN.FuncName;
            //try
            //{
            //    string strCode = "";
            //    Type t = typeof(Vue_ViewScript_DetailCS_TS4TypeScriptBak);
            //    MethodInfo mt = t.GetMethod(strFuncName, BindingFlags.Instance | BindingFlags.Public);

            //    if (mt == null)
            //    {
            //        string strMsg = string.Format("在类中没有相应的函数:{0}.(In {1})", strFuncName, clsStackTrace.GetCurrClassFunction());
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
            //    sbMessage.AppendFormat("在生成函数:{0}时出错. \r\n出错信息:{1}.", strFuncName, strMsg);
            //    throw new Exception(sbMessage.ToString());
            //}
        }
        public override void GetClsName()
        {
            //this.ClsName = string.Format("WApi{0}_QUDI_TS", objViewInfoENEx.TabName);
            //objViewInfoENEx.ClsName = this.ClsName;
            string strClassName = string.Format("WA_{0}_Detail", objViewInfoENEx.TabName);
            clsViewRegionENEx objViewRegionENEx = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.DetailRegion_0006);
            if (objViewRegionENEx != null && string.IsNullOrEmpty(objViewRegionENEx.ClassName) == false)
            {
                strClassName = objViewRegionENEx.ClassName;
            }
            this.ClsName = strClassName;

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
                clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = clsvFunction4GeneCodeBLEx.GetObjByFuncId4GC_CacheEx(strFuncId4GC);
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
      
     
        private void Gene_ReFreshCache(StringBuilder sbCode)
        {
            if (objViewInfoENEx.IsUseCache4List == true)
            {
                if (objViewInfoENEx.objCacheClassifyFld4View == null)
                {
                    sbCode.AppendFormat("\r\n" + "{0}_ReFreshCache();", objViewInfoENEx.TabName_In);
                }
                else
                {
                    sbCode.AppendFormat("\r\n" + "{0}_ReFreshCache({2}.{1}_Cache);", objViewInfoENEx.TabName, 
                        objViewInfoENEx.objCacheClassifyFld4View.FldName, objViewInfoENEx.ClsName);
                }
            }
            else
            {
                if (objViewInfoENEx.objCacheClassifyFld4View == null)
                {
                    sbCode.AppendFormat("\r\n" + "//{0}_ReFreshCache();", objViewInfoENEx.TabName_In);
                }
                else
                {
                    sbCode.AppendFormat("\r\n" + "//{0}_ReFreshCache({2}.{1}_Cache);", objViewInfoENEx.TabName, 
                        objViewInfoENEx.objCacheClassifyFld4View.FldName, objViewInfoENEx.ClsName);
                }
            }
        }

       
        public string Gen_Vue_Ts_Code4DetailRegion()
        {
            arrPropertyDef4GC = new List<clsPropertyDef4GC>();
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                     clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(enumFunctionTemplate.RegionFunctionDetailSet_0005,
                     objViewInfoENEx.CodeTypeId,
                     enumRegionType.DetailRegion_0006)
                                   .OrderBy(x => x.OrderNum);
            foreach (clsvFunction4GeneCodeEN objvFunction4GeneCodeEN in arrvFunction4GeneCodeObjLst)
            {
                string strFuncName = objvFunction4GeneCodeEN.FuncName;
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
                        strCodeForCs.Append(strTemp);
                    }
                }
                catch (Exception objException)
                {
                    throw objException;
                }
            }

            strCodeForCs.Append("\r\n" + "");
            return strCodeForCs.ToString();

        }



        public string Gen_Vue_Ts_AddDPV_Detail(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            string strClassName = string.Format("WA_{0}_Detail", objViewInfoENEx.TabName);
            clsViewRegionENEx objViewRegionENEx = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.DetailRegion_0006);
            if (objViewRegionENEx != null && string.IsNullOrEmpty(objViewRegionENEx.ClassName) == false)
            {
                strClassName = objViewRegionENEx.ClassName;
            }

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 在当前界面中，导入编辑区域");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.Append("\r\n /// <returns></returns>");
            strCodeForCs.AppendFormat("\r\n" + "public async AddDPV_Detail(divName4Detail:string) {{",
                objViewInfoENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.AddDPV_Detail.name;",
       objViewInfoENEx.TabName, objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "const strUrl = \"./{0}/\";", strClassName);
            strCodeForCs.Append("\r\n" + "console.log(\"divName4Detail:(In AddDPV_Detail)\" + divName4Detail);");
            strCodeForCs.Append("\r\n" + "return new Promise(function(resolve, reject) {");
            strCodeForCs.Append("\r\n" + "$.ajax({");
            strCodeForCs.Append("\r\n" + "url: strUrl,");
            strCodeForCs.Append("\r\n" + "method: \"GET\",");
            strCodeForCs.Append("\r\n" + "dataType: \"html\",");
            strCodeForCs.Append("\r\n" + "data: { },");
            strCodeForCs.Append("\r\n" + "success: function(data:any) {");
            strCodeForCs.Append("\r\n" + "console.log(\"已经成功获取页面:\" + strUrl + \"  字节数: \" + data.length.toString());");
            strCodeForCs.Append("\r\n" + "$('#' + divName4Detail).html(data);");
            strCodeForCs.Append("\r\n" + "resolve(true);");
            strCodeForCs.AppendFormat("\r\n" + "//setTimeout(() => {{ clsDetailObj.BindTab(); }}, 100);");
            strCodeForCs.AppendFormat("\r\n" + "//clsDetailObj.BindTab();");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: (e:any) => {");
            strCodeForCs.Append("\r\n" + "console.error(e);");
            strCodeForCs.Append("\r\n" + "reject(e);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public string Gen_Vue_TS_ShowDialog(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  显示对话框");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "public ShowDialog_{0}(strOp:string) {{", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.ShowDialog_{0}.name;",
       objViewInfoENEx.TabName_In, objKeyField.FldName);
            
            //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

            strCodeForCs.AppendFormat("\r\n" + "CheckControlExist(this.divName4Detail, \"div\", \"divDetailDialog_{0}\");", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + "CheckControlExist(this.divName4Detail, \"h4\", \"lblDialogTitle_{0}\");", objViewInfoENEx.TabName_In);

            //strCodeForCs.Append("\r\n" + "   strOp = pstrOp;");
            strCodeForCs.Append("\r\n" + "       if (strOp === \"Add\" || strOp === \"AddWithMaxId\") {");
            strCodeForCs.AppendFormat("\r\n" + "           $('#lblDialogTitle_{0}').html('添加记录');", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + "//{0}Ex.GetMaxStrId('#txt{1}');",
                    objViewInfoENEx.ClsName, objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "        }");
            strCodeForCs.Append("\r\n" + "else if (strOp === \"Update\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "            $('#lblDialogTitle_{0}').html('修改记录');", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else if (strOp === \"Detail\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "            $('#btnSubmit_{0}').hide();", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + "            $('#lblDialogTitle_{0}').html('详细信息');", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "ShowDialog('#divDetailDialog_{0}');", objViewInfoENEx.TabName_In);

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public string Gen_Vue_TS_HideDialog(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  隐藏对话框");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "public HideDialog_{0}() {{", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.HideDialog_{0}.name;",
       objViewInfoENEx.TabName_In, objKeyField.FldName);
            //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

            strCodeForCs.AppendFormat("\r\n" + "CheckControlExist(this.divName4Detail, \"div\", \"divDetailDialog_{0}\");", objViewInfoENEx.TabName_In);

            strCodeForCs.AppendFormat("\r\n" + "HideDialog('#divDetailDialog_{0}');", objViewInfoENEx.TabName_In);

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        public string Gen_Vue_Ts_ShowDetailDataFromClass4Func(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (bolIsUseFunc4Detail == false) return "";

            //clsDetailRegionEN objDetailRegion = null;
            clsViewRegionEN objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.DetailRegion_0006);
            if (objViewRegion == null || objViewRegion.InUseInViewInfo(objViewInfoENEx) == false) return "";

            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /* 函数功能:把类对象的属性内容显示到界面的详细信息区域中");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n  <param name = \"pobj{0}EN\">表实体类对象</param>",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "public ShowDetailDataFrom{0}Class4Func(pobj{2}ENEx: cls{1}ENEx )",
                           objViewInfoENEx.TabName_Out, objViewInfoENEx.TabName_Out, objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.ShowDetailDataFrom{0}Class4Func.name;",
       objViewInfoENEx.TabName_Out, objKeyField.FldName);
                
                //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

                foreach (clsDetailRegionFldsENEx objDetailRegionFldsEx in objViewInfoENEx.arrDetailRegionFldSet4InUse)
                {
                    string strTemp = GetCode4FieldInShowDetailDataFromClass4Func(objDetailRegionFldsEx, objViewInfoENEx);
                    strCodeForCs.AppendFormat("{0}", strTemp);

                }
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
        private string GetCode4FieldInShowDetailDataFromClass4Func(clsDetailRegionFldsENEx objDetailRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {

            StringBuilder sbCodeForCs = new StringBuilder();

            if (objDetailRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objDetailRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }
            if (objDetailRegionFldsEx.IsUseFunc == true)
            {
                string strDataType = "";
                var objDataNode = clsDataNodeBL.GetObjByDataNodeId_Cache(objDetailRegionFldsEx.OutDataNodeId, objViewInfoENEx.CmPrjId);
                var objFieldTab = clsFieldTabBL.GetObjByFldId_Cache(objDataNode.FldId, objDataNode.PrjId);
                strDataType = objFieldTab.TypeScriptType();
                string strCtrlId = clsCtlTypeAbbrBLEx.GetCtrlId(objDetailRegionFldsEx.CtlTypeId, objDetailRegionFldsEx.DataPropertyName);
                arrPropertyDef4GC.Add(new clsPropertyDef4GC
                {
                    OperateType = "set",
                    ControlType = objDetailRegionFldsEx.CtlTypeName,
                    CtrlId = strCtrlId + "_d",
                    PropertyName = objDetailRegionFldsEx.DataPropertyName_FstLcase() + "_d",
                    Comment = string.Format("{0} (Used In {1})", objDetailRegionFldsEx.ObjFieldTabENEx.Caption,
                                    "ShowDetailDataFromClass4Func()"),
                    DataType = strDataType,
                    ParentDivName = "this.divName4Detail"
                });
            }
            else
            {
                string strCtrlId = clsCtlTypeAbbrBLEx.GetCtrlId(objDetailRegionFldsEx.CtlTypeId, objDetailRegionFldsEx.FldName);

                arrPropertyDef4GC.Add(new clsPropertyDef4GC
                {
                    OperateType = "set",
                    ControlType = objDetailRegionFldsEx.CtlTypeName,
                    CtrlId = strCtrlId + "_d",
                    PropertyName = objDetailRegionFldsEx.PropertyName() + "_d",
                    Comment = string.Format("{0} (Used In {1})", objDetailRegionFldsEx.ObjFieldTabENEx.Caption,
                                            "ShowDetailDataFromClass4Func()"),
                    DataType = objDetailRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
                    ParentDivName = "this.divName4Detail"
                });
            }
            switch (objDetailRegionFldsEx.CtlTypeId)
            {
                case enumCtlTypeAbbr.CheckBox_02:
                    //7、设置checkbox为选中状态
                    //$('input:checkbox').attr("checked", 'checked');//or
                    //$('input:checkbox').attr("checked", true);
                    //8、设置checkbox为不选中状态
                    //$('input:checkbox').attr("checked", '');//or
                    //$('input:checkbox').attr("checked", false);
                    sbCodeForCs.AppendFormat("\r\n" + "this.{0}_d = pobj{1}ENEx.{2};",
                                objDetailRegionFldsEx.DataPropertyName_FstLcase(),
                                objViewInfoENEx.TabName_Out,
                                objDetailRegionFldsEx.PropertyName());
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
                case enumCtlTypeAbbr.GivenValue_35:
                    sbCodeForCs.AppendFormat("\r\n" + "// this.{0}_d = pobj{1}ENEx.{2};",
                                objDetailRegionFldsEx.DataPropertyName_FstLcase(),
                                objViewInfoENEx.TabName_Out,
                                objDetailRegionFldsEx.PropertyName());
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
                case enumCtlTypeAbbr.DropDownList_06:
                    sbCodeForCs.AppendFormat("\r\n" + " this.{0}_d = pobj{1}ENEx.{2};",
                                objDetailRegionFldsEx.DataPropertyName_FstLcase(),
                                objViewInfoENEx.TabName_Out,
                                objDetailRegionFldsEx.PropertyName());
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
                case enumCtlTypeAbbr.CacheClassifyField_37:
                    sbCodeForCs.AppendFormat("\r\n" + "// this.{0}_d = pobj{1}ENEx.{2};",
                         objDetailRegionFldsEx.DataPropertyName_FstLcase(),
                         objViewInfoENEx.TabName_Out,
                         objDetailRegionFldsEx.PropertyName());
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
                default:
                    if (objDetailRegionFldsEx.IsUseFunc == true)
                    {
                        sbCodeForCs.AppendFormat("\r\n" + " this.{0}_d = pobj{1}ENEx.{3};",
                                 objDetailRegionFldsEx.DataPropertyName_FstLcase(),
                                 objViewInfoENEx.TabName_Out,
                                 objDetailRegionFldsEx.PropertyName(),
                                 objDetailRegionFldsEx.DataPropertyName_FstLcase());
                    }
                    else
                    {
                        sbCodeForCs.AppendFormat("\r\n" + " this.{0}_d = pobj{1}ENEx.{2};",
                                    objDetailRegionFldsEx.PropertyName(),
                                    objViewInfoENEx.TabName_Out,
                                    objDetailRegionFldsEx.PropertyName());
                    }
                    sbCodeForCs.AppendFormat("// {0}", objDetailRegionFldsEx.LabelCaption);
                    break;
            }

            return sbCodeForCs.ToString();
        }
        public string Gen_Vue_Ts_FuncMap4Detail()
        {
            if (string.IsNullOrEmpty(strMapFuncCode) == false) return strMapFuncCode;
            if (bolIsUseFunc4Detail == false) return "";
            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 把一个扩展类的部分属性进行函数转换");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}S\">源对象</param>", strTabName_Out4Detail);
            strCodeForCs.AppendFormat("\r\n public async FuncMap4Detail(obj{0}:cls{0}ENEx )", strTabName_Out4Detail);
            strCodeForCs.Append("\r\n{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.FuncMap4Detail.name;");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            List<clsDetailRegionFldsENEx> arrDetailRegionFld_Sel = objViewInfoENEx.arrDetailRegionFldSet.FindAll(x => x.IsUseFunc == true);
            //Graph g1 = clsDataNodeBLEx.InitGraph(objViewInfoENEx.CmPrjId);
            foreach (clsDetailRegionFldsENEx objDetailRegionFldsEx in arrDetailRegionFld_Sel)
            {
                strCodeForCs.Append("\r\n" + "{");
                var objDataNode_Curr = clsDataNodeBLEx.GetObjByTabIdAndFldId_Cache(strTabId_Out4Detail, objDetailRegionFldsEx.FldId, 1, objViewInfoENEx.CmPrjId);
                if (objDataNode_Curr == null)
                {
                    string strMsg = string.Format("TabId={0},FldId=[{1}], VersionNo=1, CmPrjId={2}的结点为空，请检查！", strTabId_Out4Detail, objDetailRegionFldsEx.FldId, objViewInfoENEx.CmPrjId);
                    throw new Exception(strMsg);
                }
                //var arrPath = clsDataNodeBLEx.GetGraphPath(g, objDataNode_Start.DataNodeId, objDetailRegionFldsEx.OutDataNodeId, objViewInfoENEx.PrjId);
                string strLastVarName = "";
                //var strCmPrjId = clsCMProjectPrjTabBLEx.GetFirstCmPrjIdByTabId_Cache(strTabId_Out4ListRegion);
                var arrPath = clsDataNodeFuncMapBLEx.GetGraphPath(objDataNode_Curr.DataNodeId, objDetailRegionFldsEx.OutDataNodeId, objViewInfoENEx.CmPrjId);
                foreach (var objInFor in arrPath)
                {
                    var objDataNode_Start = clsDataNodeBL.GetObjByDataNodeId_Cache(objInFor.InDataNodeId, objInFor.CmPrjId);
                    var objDataNode_End = clsDataNodeBL.GetObjByDataNodeId_Cache(objInFor.OutDataNodeId, objInFor.CmPrjId);
                    var objFieldTab_Start = clsFieldTabBL.GetObjByFldId_Cache(objDataNode_Start.FldId, objInFor.PrjId);
                    var objFieldTab_End = clsFieldTabBL.GetObjByFldId_Cache(objDataNode_End.FldId, objInFor.PrjId);

                    switch (objInFor.FuncMapModeId)
                    {
                        case enumFuncMapMode.Table_01:
                            var objPrjTab = clsPrjTabBL.GetObjByTabId_Cache(objInFor.TabId, objInFor.PrjId);
                            string strCacheClassifyField = "";
                            if (string.IsNullOrEmpty(objPrjTab.CacheClassifyField_TS) == false)
                            {
                                var objCacheClassifyField = clsFieldTabBL.GetObjByFldId_Cache(objPrjTab.CacheClassifyField_TS, objPrjTab.PrjId);

                                strCacheClassifyField = string.Format(", obj{0}.{1}", strTabName_Out4Detail, objCacheClassifyField.PropertyName());
                            }
                            if (arrPath.Count == 1)
                            {
                                if (objDataNode_Start.TabId == strTabId_Out4Detail)
                                {
                                    strCodeForCs.AppendFormat("\r\n const {0} = obj{1}.{2};", objDataNode_Start.DataNodeName,
                                        strTabName_Out4Detail,
                                        objFieldTab_Start.PropertyName());
                                }
                                //else
                                //{
                                //    strCodeForCs.AppendFormat("\r\n const {0} = {1};", objDataNode_Start.DataNodeName, objDataNode_Start.DataNodeName);
                                //}
                            }
                            strCodeForCs.AppendFormat("\r\n const {0} = await {1}_func(cls{1}EN.con_{2}, cls{1}EN.con_{3}, {4}.toString() {5});",
                                objDataNode_End.DataNodeName,
                                objPrjTab.TabName,
                                objFieldTab_Start.FldName,
                                objFieldTab_End.FldName,
                                objDataNode_Start.DataNodeName,
                                strCacheClassifyField);
                            if (arrTabId4MapFunc.Contains(objPrjTab.TabId) == false)
                            {
                                arrTabId4MapFunc.Add(objPrjTab.TabId);
                            }
                            strLastVarName = objDataNode_End.DataNodeName;
                            break;
                        case enumFuncMapMode.Function_02:
                            var objDNFun = clsDNFunctionBL.GetObjByDnFunctionId_Cache(objInFor.DnFunctionId, objViewInfoENEx.PrjId);
                            switch (objDNFun.DnFunctionName)
                            {
                                case "equal":

                                    if (objDataNode_Start.TabId == strTabId_Out4Detail)
                                    {
                                        strCodeForCs.AppendFormat("\r\n const {0} = obj{1}.{2};", objDataNode_End.DataNodeName,
                                            strTabName_Out4Detail,
                                            objFieldTab_Start.PropertyName());
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n const {0} = {1};", objDataNode_End.DataNodeName, objDataNode_Start.DataNodeName);
                                    }
                                    strLastVarName = objDataNode_End.DataNodeName;
                                    break;
                                case "GetDateTime_Sim":
                                    //var objPrjTab2 = clsPrjTabBL.GetObjByTabId_Cache(objInFor.TabId, objInFor.PrjId);
                                    if (objDataNode_Start.TabId == strTabId_Out4Detail)
                                    {
                                        strCodeForCs.AppendFormat("\r\n const {0} = clsDateTime.GetDateTime_Sim(obj{1}.{2});",
                                     objDataNode_End.DataNodeName,
                                            strTabName_Out4Detail,
                                        objFieldTab_Start.PropertyName());
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n const {0} = clsDateTime.GetDateTime_Sim({1});",
                                        objDataNode_End.DataNodeName,
                                        objDataNode_Start.DataNodeName);
                                    }
                                    strLastVarName = objDataNode_End.DataNodeName;
                                    break;
                                default:
                                    //var objPrjTab3 = clsPrjTabBL.GetObjByTabId_Cache(objInFor.TabId, objInFor.PrjId);
                                    if (objDataNode_Start.TabId == strTabId_Out4Detail)
                                    {
                                        strCodeForCs.AppendFormat("\r\n const {0} = await {3}(obj{1}.{2});",
                                     objDataNode_End.DataNodeName,
                                            strTabName_Out4Detail,
                                        objFieldTab_Start.PropertyName(),
                                        objDNFun.DnFunctionName);
                                    }
                                    else
                                    {
                                        strCodeForCs.AppendFormat("\r\n const {0} = await {2}({1});",
                                        objDataNode_End.DataNodeName,
                                        objDataNode_Start.DataNodeName,
                                        objDNFun.DnFunctionName);
                                    }
                                    strLastVarName = objDataNode_End.DataNodeName;
                                    break;
                            }
                            break;
                    }

                }
                strCodeForCs.AppendFormat("\r\n obj{0}.{1} = {2};",
                                    strTabName_Out4Detail,
                                    objDetailRegionFldsEx.DataPropertyName_FstLcase(),
                                    strLastVarName);
                strCodeForCs.Append("\r\n" + "}");
            }

            //strCodeForCs.AppendFormat("\r\n return obj{0}ENT;", strTabName_Out4ListRegion);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e)");
            strCodeForCs.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                objViewInfoENEx.PrjId, objViewInfoENEx.ClsName, "FuncMap4ExcelExport", "函数映射表:{0} 对象数据出错!", "生成代码");

            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"(errid:{0})函数映射4ExcelExport表对象数据出错,{{0}}.)\", e);", strErrId);
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            //strCodeForCs.AppendFormat("\r\n" + "throw new Exception(\"(errid:{22})Copy表:{0} 对象数据出错!({1}:CopyTo)\\r\\n\" + objException.Message);",
            //  objViewInfoENEx, objViewInfoENEx.ClsName, strErrId);

            //strCodeForCs.AppendFormat("\r\n" + "throw new Exception(\"Copy表:{0} 对象数据出错!({1}: CopyTo)\"+ objException.Message);",
            //  objViewInfoENEx, objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strCodeForCs.ToString();
        }

        public string Gen_Vue_Ts_CopyToEx()
        {
            if (bolIsUseFunc4Detail == false ) return "";
            StringBuilder strCodeForCs = new StringBuilder();
            //获取某一条件值的记录集-----------------------------;
            strCodeForCs.Append("\r\n /// <summary>");
            strCodeForCs.Append("\r\n /// 把同一个类的对象,复制到另一个对象");
            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n /// </summary>");
            strCodeForCs.AppendFormat("\r\n /// <param name = \"obj{0}ENS\">源对象</param>", strTabName_Out4Detail);
            strCodeForCs.AppendFormat("\r\n /// <returns>目标对象=>cls{0}EN:obj{0}ENT</returns>", strTabName_Out4Detail);
            strCodeForCs.AppendFormat("\r\n public CopyToEx(obj{0}ENS:cls{0}EN ): cls{0}ENEx", strTabName_Out4Detail);
            strCodeForCs.Append("\r\n{");
      
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.CopyToEx.name;");
            strCodeForCs.AppendFormat("\r\n const obj{0}ENT = new cls{0}ENEx();", strTabName_Out4Detail);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "{0}_CopyObjTo(obj{0}ENS, obj{0}ENT);",
                    strTabName_Out4Detail);

            strCodeForCs.AppendFormat("\r\n return obj{0}ENT;", strTabName_Out4Detail);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e)");
            strCodeForCs.Append("\r\n" + "{");
            string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                objViewInfoENEx.PrjId, objViewInfoENEx.ClsName, "CopyToEx", "Copy表Ex:{0} 对象数据出错!", "生成代码");

            strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"(errid:{0})Copy表对象数据出错,{{0}}.(in {{1}}.{{2}})\", e, this.constructor.name, strThisFuncName);", strErrId);
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            
            strCodeForCs.AppendFormat("\r\n return obj{0}ENT;", strTabName_Out4Detail);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n}");
            //获取某一条件值的记录集 == = ;
            return strCodeForCs.ToString();
        }
    }
}
