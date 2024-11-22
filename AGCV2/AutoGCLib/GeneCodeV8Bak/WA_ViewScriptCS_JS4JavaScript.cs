using System;
using System.Text;
using System.Data;
using System.Collections;
using System.IO;
using com.taishsoft.commexception;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.comm_db_obj;


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
    partial class WA_ViewScriptCS_JS4JavaScript : clsGeneCodeBase
    {
        public bool Is4RJ { get; set; }
        private string strVarDef4ViewCacheFld = "";
        private List<clsPropertyDef4GC> arrPropertyDef4GC = null;
        int intZIndex;      ///控件焦点序号
        float intCurrLeft;  ///控件的左边空;
        float intCurrTop;  ///控件的顶面空;
        clsBiDimDistribute objBiDimDistribue4Qry = null;
        #region 构造函数
        public WA_ViewScriptCS_JS4JavaScript()
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            InitPageSetup();
        }
        public WA_ViewScriptCS_JS4JavaScript(string strViewId)
       : base("", strViewId, "", "")
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
        public WA_ViewScriptCS_JS4JavaScript(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
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

        public string Gen_WApi_Js_Page_Load()
        {
            if (objViewInfoENEx.IsUseCache4List) return "";

            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /* 函数功能:页面导入,当页面开始运行时所发生的事件");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.Page_Load = async function()", objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "// 在此处放置用户代码以初始化页面");
                //strCodeForCs.Append("\r\n" + GenPotenceRelaCode());
                //生成Page_Load中的绑定下拉框的代码
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                //建立缓存
                strCodeForCs.Append("\r\n" + "//建立缓存");

                strCodeForCs.AppendFormat("\r\n" + "{0}.SetCommFun4BL();",
                           ImportClass.GetOutString(string.Format("clsPubFun", objViewInfoENEx.TabName), this.Is4RJ));
                List<string> arrTabName = new List<string>();

                strCodeForCs.Append("\r\n // 为查询区绑定下拉框");
                strCodeForCs.AppendFormat("\r\n" + "const gvBindDdl = await this.BindDdl4QueryRegion();", objViewInfoENEx.ClsName);

                strCodeForCs.Append("\r\n" + Gen_WApi_Js_DdlBind4ViewFeatureInPage_Load());

                strCodeForCs.AppendFormat("\r\n" + "{2}.sort{1}By = \"{0} Asc\";",
                        objViewInfoENEx.FirstSortField, objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName);


                strCodeForCs.Append("\r\n" + "//2、显示无条件的表内容在GridView中");

                strCodeForCs.AppendFormat("\r\n" + "const gvResult = await this.BindGv_{0}();", objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = \"页面启动不成功,\" + e+ \".\";");
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

        public string Gen_WApi_Js_Page_Load_Cache()
        {
            clsVarManage objVarManage = new clsVarManage("JavaScript");
            if (objViewInfoENEx.arrRelaMainTabFldSet.Where(x => x.FldId == objViewInfoENEx.objMainPrjTab.CacheClassifyField).Count() > 0)
            {
                objViewInfoENEx.objCacheClassifyFld4View = objViewInfoENEx.arrRelaMainTabFldSet.Where(x => x.FldId == objViewInfoENEx.objMainPrjTab.CacheClassifyField).First();
            }
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                strCodeForCs.Append("\r\n /* 函数功能:页面导入,当页面开始运行时所发生的事件");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.Page_Load_Cache = async function()", objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "// 在此处放置用户代码以初始化页面");
                //strCodeForCs.Append("\r\n" + GenPotenceRelaCode());
                //生成Page_Load中的绑定下拉框的代码
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                //建立缓存
                strCodeForCs.Append("\r\n" + "// 设置建立缓存");
                strCodeForCs.AppendFormat("\r\n" + "{0}.SetCommFun4BL();",
                           ImportClass.GetOutString(string.Format("clsPubFun", objViewInfoENEx.TabName), this.Is4RJ));


                strCodeForCs.Append("\r\n // 为查询区绑定下拉框");
                strCodeForCs.AppendFormat("\r\n" + "const gvBindDdl = await this.BindDdl4QueryRegion();", objViewInfoENEx.ClsName);

                strCodeForCs.Append("\r\n" + Gen_WApi_Js_DdlBind4ViewFeatureInPage_Load());



                strCodeForCs.AppendFormat("\r\n" + "{2}.sort{1}By = \"{0} Asc\";",
                        objViewInfoENEx.FirstSortField, objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName);

                strCodeForCs.Append("\r\n" + "//2、显示无条件的表内容在GridView中");
                strCodeForCs.AppendFormat("\r\n" + "const gvResult = await this.BindGv_{0}_Cache();", objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = \"页面启动不成功,\" + e+ \".\";");
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


        public string Gen_WApi_Js_DdlBind4EditRegionBak()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //生成仅有变量;
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.objCtlTypeAbbr.CtlTypeName == "DropDownList")
                    {
                        if (objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType == "boolean")
                        {
                        }
                        else
                        {
                            string strDS_DataValueField;
                            string strDS_DataTextField;
                            string strDs_TabName;
                            string strDS_TabCnName;
                            try
                            {
                                clsPrjTabEN objPrjTab = clsEditRegionFldsBLEx.InitDs_PrjTab4Get(objEditRegionFldsEx);
                                strDs_TabName = objPrjTab.TabName;
                                strDS_TabCnName = objPrjTab.TabCnName;
                            }
                            catch (Exception objException)
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 获取数据源表名出错:{2}.",
                                objViewInfoENEx.ViewName, "编辑区域", objException.Message);
                                throw new Exception(sbMsg.ToString());
                            }
                            if (string.IsNullOrEmpty(strDs_TabName) == true)
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 数据源表名为空，请检查!({2}).",
                                objViewInfoENEx.ViewName, "编辑区域", clsStackTrace.GetCurrClassFunction());
                                throw new Exception(sbMsg.ToString());
                            }
                            try
                            {
                                strDS_DataValueField = clsEditRegionFldsBLEx.InitDs_DataValueField(objEditRegionFldsEx);
                            }
                            catch (Exception objException)
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 获取数据源值字段名时出错:{2}.<br/>数据源表名为:{3}.",
                                objViewInfoENEx.ViewName, "编辑区域", objException.Message, strDs_TabName);
                                throw new Exception(sbMsg.ToString());
                            }
                            if (string.IsNullOrEmpty(strDS_DataValueField) == true)
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 获取数据源值字段名时出错.<br/>数据源表名为:{2}.({3})",
                                    objViewInfoENEx.ViewName, "编辑区域", strDs_TabName,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(sbMsg.ToString());
                            }
                            try
                            {
                                strDS_DataTextField = clsEditRegionFldsBLEx.InitDs_DataTextField(objEditRegionFldsEx);
                            }
                            catch (Exception objException)
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 获取数据源文本字段名时出错:{2}.<br/>数据源表名为:{3},值字段名为:{4}.",
                                objViewInfoENEx.ViewName, "编辑区域", objException.Message, strDs_TabName, strDS_DataValueField);
                                throw new Exception(sbMsg.ToString());
                            }
                            if (string.IsNullOrEmpty(strDS_DataTextField) == true)
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 获取数据源文本字段名时出错.<br/>数据源表名为:{2},值字段名为:{3}.({4})",
                                      objViewInfoENEx.ViewName, "编辑区域", strDs_TabName, strDS_DataValueField,
                                      clsStackTrace.GetCurrClassFunction());
                                throw new Exception(sbMsg.ToString());
                            }
                            if (arrDdlKeyIdLst.Contains(strDS_DataValueField) == false)
                            {
                                arrDdlKeyIdLst.Add(strDS_DataValueField);
                            }
                            else
                            {
                                continue;
                            }
                            switch (objEditRegionFldsEx.DdlItemsOptionId)
                            {
                                case "01": ///列表项串;
                                    //									string strTemp2 ;
                                    string delimStr = " ,.:";
                                    char[] delimiter = delimStr.ToCharArray();
                                    //									string words = "one two,three:four.";
                                    string[] split = null;
                                    int iItemNums;
                                    int i;

                                    strCodeForCs.AppendFormat("\r\n /*绑定下拉框:ddl{0}的函数。", objEditRegionFldsEx.FldName);
                                    strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                                    strCodeForCs.Append("\r\n" + "*/");
                                    strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.BindDdl_{1} = function(objDDL)",
                                         objViewInfoENEx.ClsName,
                                    objEditRegionFldsEx.FldName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "ListItem li = new ListItem(\"请选择...\",\"0\");");
                                    split = objEditRegionFldsEx.ItemsString.Split(delimiter);
                                    iItemNums = split.GetUpperBound(0);
                                    for (i = split.GetLowerBound(0); i <= iItemNums; i++)
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "objDDL.Items.Add(\"{0}\");", split[i]);
                                    }
                                    strCodeForCs.Append("\r\n" + "objDDL.Items.Insert(0, li);");
                                    strCodeForCs.Append("\r\n" + "objDDL.SelectedIndex = 0;");
                                    strCodeForCs.Append("\r\n" + "//为下拉框设置内容的样例,该下拉框的列表项是直接添加的");
                                    strCodeForCs.Append("\r\n ///objDDL.Items.Add(\"男\");");
                                    strCodeForCs.Append("\r\n ///objDDL.Items.Add(\"女\");");
                                    strCodeForCs.Append("\r\n" + "}");
                                    break;
                                case "02": ///列表项数据源表;
                                    strCodeForCs.Append("\r\n" + "/// <summary>");
                                    strCodeForCs.AppendFormat("\r\n" + "/// 为下拉框获取数据,从表:[{0}]中获取",
                                      strDs_TabName);
                                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                                    strCodeForCs.Append("\r\n" + "/// </summary>");
                                    strCodeForCs.Append("\r\n" + "/// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>");
                                    strCodeForCs.AppendFormat("\r\n" + "{4}.prototype.BindDdl_{1} = function(ddl{1}, strWhereCond) {{",
                                      strDs_TabName,
                                      strDS_DataValueField,
                                      strDS_DataTextField,
                                      objEditRegionFldsEx.CtrlId,
                                      objViewInfoENEx.ClsName);
                                    strCodeForCs.Append("\r\n" + "//let strWhereCond = \" 1 =1 \";");
                                    strCodeForCs.AppendFormat("\r\n" + "const objDdl = document.getElementById(ddl{1});",
                                        strDs_TabName, strDS_DataValueField, strDS_DataTextField);
                                    strCodeForCs.Append("\r\n" + "if (objDdl == null)");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"下拉框：\" + ddl{1} + \" 不存在！\";",
                                        strDs_TabName, strDS_DataValueField, strDS_DataTextField);
                                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                                    strCodeForCs.Append("\r\n" + "throw (strMsg);");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "return new Promise((resolve, reject) => {");

                                    strCodeForCs.Append("\r\n" + "try");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "const responseText = {3}.GetObjLst(strWhereCond).then((jsonData)=>{{",
                                        strDs_TabName, strDS_DataValueField, strDS_DataTextField,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", strDs_TabName), this.Is4RJ));
                                    strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst =  jsonData;",
                                        strDs_TabName, strDS_DataValueField, strDS_DataTextField);
                                    //this.BindTab_{0}(strListDiv, arr{0}ObjLst);
                                    strCodeForCs.AppendFormat("\r\n" + "{5}.BindDdl_ObjLst(ddl{1}, arr{0}ObjLst, {4}.con_{1}, {4}.con_{2}, \"{3}\");",
                                        strDs_TabName,
                                        strDS_DataValueField,
                                        strDS_DataTextField,
                                        strDS_TabCnName,
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ),
                                      ImportClass.GetOutString(string.Format("clsCommFunc4Web", objViewInfoENEx.TabName), this.Is4RJ));
                                    strCodeForCs.AppendFormat("\r\n" + "console.log(\"完成BindDdl_{0}!\");", strDS_DataValueField);
                                    strCodeForCs.Append("\r\n" + "resolve(jsonData);");
                                    strCodeForCs.Append("\r\n" + "});");


                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "catch (e)");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "const strMsg = \"绑定下拉框不成功,\" + e+ \".\";");
                                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "});");
                                    strCodeForCs.Append("\r\n" + "}");


                                    break;
                                case "03": ///列表项数据源SQL串;
                                    strCodeForCs.Append("\r\n" + "/// <summary>");
                                    strCodeForCs.AppendFormat("\r\n" + "/// 为下拉框获取数据,从Sql串:[{0}]中获取",
                                       objEditRegionFldsEx.Ds_SQLStr);
                                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                                    strCodeForCs.Append("\r\n" + "/// </summary>");
                                    strCodeForCs.Append("\r\n" + "/// <returns>获取自定义的Sql串中两列的所有记录记录的DataTable</returns>");

                                    strCodeForCs.AppendFormat("\r\n" + "{1}.prototype.System.Data.DataTable Get{0}(string strCondition)",
                                    objEditRegionFldsEx.FldName, objViewInfoENEx.ClsName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "//获取某学院所有专业信息");
                                    //strCodeForCs.Append("\r\n" + "clsSpecSQLforSql mySql = new 1clsSpecSQLforSql();");
                                    strCodeForCs.AppendFormat("\r\n clsSpecSQLforSql mySql = {1}.GetSpecSQLObj();",
                                        objViewInfoENEx.TabName,
                                      ImportClass.GetOutString(string.Format("cls{0}BL", objViewInfoENEx.TabName), this.Is4RJ));

                                    strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = mySql.GetDataTable({0});",
                                    objEditRegionFldsEx.Ds_SQLStr);
                                    strCodeForCs.Append("\r\n" + "return objDT;");
                                    strCodeForCs.Append("\r\n" + "}");

                                    strCodeForCs.Append("\r\n /* 绑定基于Web的下拉框");
                                    strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                                    strCodeForCs.Append("\r\n  <param name = \"objDDL\">需要绑定当前表的下拉框</param>");
                                    strCodeForCs.Append("\r\n" + "*/");
                                    strCodeForCs.AppendFormat("\r\n" + "{1}.prototype.void BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL)",
                                    objEditRegionFldsEx.FldName, objViewInfoENEx.ClsName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "//为数据源于表的下拉框设置内容");
                                    strCodeForCs.Append("\r\n" + "ListItem li = new ListItem(\"请选择...\",\"0\");");
                                    strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = Get{0}();",
                                    objEditRegionFldsEx.FldName);
                                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataValueField = {3}.con_{1};",
                                      strDs_TabName, strDS_DataValueField,
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ));
                                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataTextField = {3}.con_{1};",
                                      strDs_TabName, strDS_DataTextField,
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ));
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
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Js_DdlBind4QueryRegionBak()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //生成仅有变量;
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    if (objQryRegionFldsEx.objCtlTypeAbbr.CtlTypeName == "DropDownList")
                    {
                        if (objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType == "boolean")
                        {
                            //strCodeForCs.AppendFormat("\r\n" + "clsCommForWebForm.BindDdl_TrueAndFalse(ddl{0}_q);",
                            //            objQryRegionFldsEx.FldName);
                        }
                        else
                        {
                            string strDS_DataValueField;
                            string strDS_DataTextField;
                            string strDs_TabName;
                            string strDS_TabCnName;
                            try
                            {
                                clsPrjTabEN objPrjTab = clsQryRegionFldsBLEx.Ds_PrjTab4Get(objQryRegionFldsEx);
                                strDs_TabName = objPrjTab.TabName;
                                strDS_TabCnName = objPrjTab.TabCnName;
                            }
                            catch (Exception objException)
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 获取数据源表名出错:{2}.",
                                objViewInfoENEx.ViewName, "查询区域", objException.Message);
                                throw new Exception(sbMsg.ToString());
                            }
                            if (string.IsNullOrEmpty(strDs_TabName) == true)
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 数据源表名为空，请检查!({2}).",
                                objViewInfoENEx.ViewName, "查询区域", clsStackTrace.GetCurrClassFunction());
                                throw new Exception(sbMsg.ToString());
                            }
                            try
                            {
                                strDS_DataValueField = clsQryRegionFldsBLEx.Ds_DataValueField4Get(objQryRegionFldsEx);
                            }
                            catch (Exception objException)
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 获取数据源值字段名时出错:{2}.<br/>数据源表名为:{3}.",
                                objViewInfoENEx.ViewName, "查询区域", objException.Message, strDs_TabName);
                                throw new Exception(sbMsg.ToString());
                            }
                            if (string.IsNullOrEmpty(strDS_DataValueField) == true)
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 获取数据源值字段名时出错.<br/>数据源表名为:{2}.({3})",
                                    objViewInfoENEx.ViewName, "查询区域", strDs_TabName,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(sbMsg.ToString());
                            }
                            try
                            {
                                strDS_DataTextField = clsQryRegionFldsBLEx.Ds_DataTextField4Get(objQryRegionFldsEx);
                            }
                            catch (Exception objException)
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 获取数据源文本字段名时出错:{2}.<br/>数据源表名为:{3},值字段名为:{4}.",
                                objViewInfoENEx.ViewName, "查询区域", objException.Message, strDs_TabName, strDS_DataValueField);
                                throw new Exception(sbMsg.ToString());
                            }
                            if (string.IsNullOrEmpty(strDS_DataTextField) == true)
                            {
                                StringBuilder sbMsg = new StringBuilder();
                                sbMsg.AppendFormat("在生成界面{0}区域:{1}时,生成下拉框, 获取数据源文本字段名时出错.<br/>数据源表名为:{2},值字段名为:{3}.({4})",
                                      objViewInfoENEx.ViewName, "查询区域", strDs_TabName, strDS_DataValueField,
                                      clsStackTrace.GetCurrClassFunction());
                                throw new Exception(sbMsg.ToString());
                            }
                            if (arrDdlKeyIdLst.Contains(strDS_DataValueField) == false)
                            {
                                arrDdlKeyIdLst.Add(strDS_DataValueField);
                            }
                            else
                            {
                                continue;
                            }
                            switch (objQryRegionFldsEx.DdlItemsOptionId)
                            {
                                case "01": ///列表项串;
                                    //									string strTemp2 ;
                                    string delimStr = " ,.:";
                                    char[] delimiter = delimStr.ToCharArray();
                                    //									string words = "one two,three:four.";
                                    string[] split = null;
                                    int iItemNums;
                                    int i;

                                    strCodeForCs.AppendFormat("\r\n /*绑定下拉框:ddl{0}的函数。", objQryRegionFldsEx.FldName);
                                    strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                                    strCodeForCs.Append("\r\n" + "*/");

                                    strCodeForCs.AppendFormat("\r\n" + "{1}.prototype.void BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL)",
                                        objQryRegionFldsEx.FldName, objViewInfoENEx.ClsName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "ListItem li = new ListItem(\"请选择...\",\"0\");");
                                    split = objQryRegionFldsEx.ItemsString.Split(delimiter);
                                    iItemNums = split.GetUpperBound(0);
                                    for (i = split.GetLowerBound(0); i <= iItemNums; i++)
                                    {
                                        strCodeForCs.AppendFormat("\r\n" + "objDDL.Items.Add(\"{0}\");", split[i]);
                                    }
                                    strCodeForCs.Append("\r\n" + "objDDL.Items.Insert(0, li);");
                                    strCodeForCs.Append("\r\n" + "objDDL.SelectedIndex = 0;");
                                    strCodeForCs.Append("\r\n" + "//为下拉框设置内容的样例,该下拉框的列表项是直接添加的");
                                    strCodeForCs.Append("\r\n ///objDDL.Items.Add(\"男\");");
                                    strCodeForCs.Append("\r\n ///objDDL.Items.Add(\"女\");");
                                    strCodeForCs.Append("\r\n" + "}");
                                    break;
                                case "02": ///列表项数据源表;

                                    strCodeForCs.Append("\r\n" + "/// <summary>");
                                    strCodeForCs.AppendFormat("\r\n" + "/// 为下拉框获取数据,从表:[{0}]中获取",
                                      strDs_TabName);
                                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                                    strCodeForCs.Append("\r\n" + "/// </summary>");
                                    strCodeForCs.Append("\r\n" + "/// <returns>获取主键字段、名称字段两列的所有记录记录的DataTable</returns>");
                                    strCodeForCs.AppendFormat("\r\n" + "{3}.prototype.BindDdl_{1} = function(ddl{1}, strWhereCond) {{",
                                      strDs_TabName,
                                      strDS_DataValueField,
                                      strDS_DataTextField,
                                      objViewInfoENEx.ClsName);
                                    strCodeForCs.Append("\r\n" + "//let strWhereCond = \" 1 =1 \";");
                                    strCodeForCs.AppendFormat("\r\n" + "const objDdl = document.getElementById(ddl{1});",
                                        strDs_TabName, strDS_DataValueField, strDS_DataTextField);
                                    strCodeForCs.Append("\r\n" + "if (objDdl == null)");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"下拉框：\" + ddl{1} + \" 不存在！\";",
                                        strDs_TabName, strDS_DataValueField, strDS_DataTextField);
                                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                                    strCodeForCs.Append("\r\n" + "throw (strMsg);");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "return new Promise((resolve, reject) => {");

                                    strCodeForCs.Append("\r\n" + "try");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "const responseText = {3}.GetObjLst(strWhereCond).then((jsonData)=>{{",
                                        strDs_TabName, strDS_DataValueField, strDS_DataTextField,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", strDs_TabName), this.Is4RJ));
                                    strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst =  jsonData;",
                                        strDs_TabName, strDS_DataValueField, strDS_DataTextField);
                                    //this.BindTab_{0}(strListDiv, arr{0}ObjLst);
                                    strCodeForCs.AppendFormat("\r\n" + "{5}.BindDdl_ObjLst(ddl{1}, arr{0}ObjLst, {4}.con_{1}, {4}.con_{2}, \"{3}\");",
                                        strDs_TabName, strDS_DataValueField, strDS_DataTextField, strDS_TabCnName,
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ),
                                      ImportClass.GetOutString(string.Format("clsCommFunc4Web", objViewInfoENEx.TabName), this.Is4RJ));
                                    strCodeForCs.AppendFormat("\r\n" + "console.log(\"完成BindDdl_{0}!\");", strDS_DataValueField);
                                    strCodeForCs.Append("\r\n" + "resolve(jsonData);");
                                    strCodeForCs.Append("\r\n" + "});");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "catch (e)");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "const strMsg = \"绑定查询区下拉框不成功,\" + e+ \".\";");
                                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "});");
                                    strCodeForCs.Append("\r\n" + "}");


                                    break;
                                case "03": ///列表项数据源SQL串;
                                    strCodeForCs.Append("\r\n" + "/// <summary>");
                                    strCodeForCs.AppendFormat("\r\n" + "/// 为下拉框获取数据,从Sql串:[{0}]中获取",
                                       objQryRegionFldsEx.Ds_SQLStr);
                                    strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                                    strCodeForCs.Append("\r\n" + "/// </summary>");
                                    strCodeForCs.Append("\r\n" + "/// <returns>获取自定义的Sql串中两列的所有记录记录的DataTable</returns>");

                                    strCodeForCs.AppendFormat("\r\n" + "{1}.prototype.System.Data.DataTable Get{0}(string strCondition)",
                                    objQryRegionFldsEx.FldName, objViewInfoENEx.ClsName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "//获取某学院所有专业信息");
                                    //strCodeForCs.Append("\r\n" + "clsSpecSQLforSql mySql = new 1clsSpecSQLforSql();");
                                    strCodeForCs.AppendFormat("\r\n clsSpecSQLforSql mySql = {1}.GetSpecSQLObj();",
                                        objViewInfoENEx.TabName,
                                      ImportClass.GetOutString(string.Format("cls{0}BL", objViewInfoENEx.TabName), this.Is4RJ));

                                    strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = mySql.GetDataTable({0});",
                                    objQryRegionFldsEx.Ds_SQLStr);
                                    strCodeForCs.Append("\r\n" + "return objDT;");
                                    strCodeForCs.Append("\r\n" + "}");

                                    strCodeForCs.Append("\r\n /* 绑定基于Web的下拉框");
                                    strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                                    strCodeForCs.Append("\r\n  <param name = \"objDDL\">需要绑定当前表的下拉框</param>");
                                    strCodeForCs.Append("\r\n" + "*/");

                                    strCodeForCs.AppendFormat("\r\n" + "{1}.prototype.void BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL)",
                                    objQryRegionFldsEx.FldName, objViewInfoENEx.ClsName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "//为数据源于表的下拉框设置内容");
                                    strCodeForCs.Append("\r\n" + "ListItem li = new ListItem(\"请选择...\",\"0\");");
                                    strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = Get{0}();",
                                    objQryRegionFldsEx.FldName);
                                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataValueField = {2}.con_{1};",
                                      strDs_TabName, strDS_DataValueField,
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ));
                                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataTextField = {2}.con_{1};",
                                      strDs_TabName, strDS_DataTextField,
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ));
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
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Js_BindDdl4QueryRegion()
        {
            clsVarManage objVarManage = new clsVarManage("JavaScript");
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            IEnumerable<ASPDropDownListEx> arrASPDropDownListObj_Query = objViewInfoENEx.arrASPDropDownListObj.Where(x => x.RegionTypeId == enumRegionType.QueryRegion_0001);
            try
            {
                strCodeForCs.Append("\r\n /* 函数功能:为查询区绑定下拉框");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.BindDdl4QueryRegion = async function()", objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "// 在此处放置用户代码以初始化页面");

                List<string> arrTabName = new List<string>();
                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj_Query)
                {
                    //if (objInfor.RegionTypeId == enumRegionType.EditRegion_0003) continue;
                    //if (objInfor.Ds_TabName == objViewInfoENEx.TabName) continue;
                    if (arrTabName.Contains(objInfor.Ds_TabName) == true) continue;
                    if (objInfor.DdlItemsOptionId == enumDDLItemsOption.TrueAndFalseList_04) continue;
                    if (objInfor.CsType == "bool") continue;
                    arrTabName.Add(objInfor.Ds_TabName);
                    strCodeForCs.AppendFormat("\r\n" + " var obj{0}_Cond = new {2}();//{1}",
                        objInfor.Ds_TabName, clsRegionTypeBL.GetNameByRegionTypeId_Cache(objInfor.RegionTypeId),
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objInfor.Ds_TabName), this.Is4RJ));
                }


                //strCodeForCs.Append("\r\n" + "$(\"#divPager\").load(\"../PubWebClass/pager\");");
                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj_Query)
                {
                    var objVar = clsGCVariableBL.GetObjByVarId_Cache(objInfor.VarId_Cond1, objInfor.PrjId);
                    //if (objInfor.RegionTypeId == enumRegionType.EditRegion_0003) continue;
                    if (objInfor.CsType == "bool")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "{1}.BindDdl_TrueAndFalse(\"{0}\");",
                                 objInfor.CtrlId,
                                      ImportClass.GetOutString(string.Format("clsCommFunc4Web", objViewInfoENEx.TabName), this.Is4RJ));
                    }
                    else
                    {
                        if (objInfor.objFieldTab_ConditionField == null)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "const {2} = await {6}.BindDdl_{1}_Cache(\"{2}\", obj{3}_Cond);//{4}",
                                        objInfor.FldName,
                                         objInfor.objFieldTab_ValueField.FldName,
                                        objInfor.CtrlId,
                                        objInfor.Ds_TabName,
                                        clsRegionTypeBL.GetNameByRegionTypeId_Cache(objInfor.RegionTypeId),
                                        objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "",
                                        ImportClass.GetOutString(string.Format("cls{0}WApi", objInfor.Ds_TabName), this.Is4RJ));
                        }
                        else
                        {

                            string strVariableName = string.Format("{0}{1}",
                                        objInfor.objFieldTab_ConditionField.PrivFuncName(),
                                        objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "");
                            if (objVarManage.AddVariable(new clsVariable(strVariableName)) == true)
                            {

                                if (objViewInfoENEx.objCacheClassifyFld4View != null
                                    && objViewInfoENEx.objCacheClassifyFld4View.FldName == objInfor.objFieldTab_ConditionField.FldName)
                                {
                                    objVarManage.SetVariableProp(strVariableName, "\"\"", objVar.GetVarDef4View(ClsName));
                                }
                                else
                                {
                                    objVarManage.SetVariableProp(strVariableName, "\"\"", objVar.GetVarDef4View(ClsName));
                                }

                                //生成缓存分类字段的检查代码，检查是否被赋正确值
                                clsPubFun4GC.GC_CheckCode4CacheClassifyFld(strCodeForCs, objViewInfoENEx.objCacheClassifyFld4View, strVariableName, this.ClsName);
                                strCodeForCs.AppendFormat("\r\n" + "//var {0}{2} = \"\";//定义条件字段",
                                    objInfor.objFieldTab_ConditionField.PrivFuncName(), objInfor.objFieldTab_ConditionField.ObjDataTypeAbbr().TypeScriptType,
                                    objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "");
                            }

                            //strCodeForCs.AppendFormat("\r\n" + "const {0}{2} = \"\";",
                            //         objInfor.objFieldTab_ConditionField.PrivFuncName(),
                            //         objInfor.objFieldTab_ConditionField.ObjDataTypeAbbr().TypeScriptType,
                            //         objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "");

                            strCodeForCs.AppendFormat("\r\n" + "const {2} = await {7}.BindDdl_{1}_Cache(\"{2}\", obj{3}_Cond, {5}{6});//{4}",
                                 objInfor.FldName,
                                 objInfor.objFieldTab_ValueField.FldName,
                         objInfor.CtrlId, objInfor.Ds_TabName
                         , clsRegionTypeBL.GetNameByRegionTypeId_Cache(objInfor.RegionTypeId),
                         objInfor.objFieldTab_ConditionField.PrivFuncName(),
                         objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "",
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objInfor.Ds_TabName), this.Is4RJ));
                        }
                    }
                }
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

        public string Gen_WApi_Js_DdlBind4ViewFeatureInPage_Load()
        {
            clsVarManage objVarManage = new clsVarManage("JavaScript");
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
                    strCodeForCs.AppendFormat("\r\n" + objInfor.GC_BindDdl4WA_JS(objVarManage, objViewInfoENEx.objCacheClassifyFld4View, strVarDef4ViewCacheFld));

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



        public string Gen_WApi_Js_BindDdl4EditRegion()
        {
            clsVarManage objVarManage = new clsVarManage("JavaScript");
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            IEnumerable<ASPDropDownListEx> arrASPDropDownListObj_Edit = objViewInfoENEx.arrASPDropDownListObj.Where(x => x.RegionTypeId == enumRegionType.EditRegion_0003);
            try
            {
                strCodeForCs.Append("\r\n /* 函数功能:为编辑区绑定下拉框");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.BindDdl4EditRegion = async function()", objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "// 在此处放置用户代码以初始化页面");

                List<string> arrTabName = new List<string>();
                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj_Edit)
                {
                    //if (objInfor.RegionTypeId == enumRegionType.EditRegion_0003) continue;
                    //if (objInfor.Ds_TabName == objViewInfoENEx.TabName) continue;
                    if (arrTabName.Contains(objInfor.Ds_TabName) == true) continue;
                    arrTabName.Add(objInfor.Ds_TabName);
                    strCodeForCs.AppendFormat("\r\n" + " var obj{0}_Cond = new {2}();//{1}",
                        objInfor.Ds_TabName, clsRegionTypeBL.GetNameByRegionTypeId_Cache(objInfor.RegionTypeId),
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objInfor.Ds_TabName), this.Is4RJ));
                }


                //strCodeForCs.Append("\r\n" + "$(\"#divPager\").load(\"../PubWebClass/pager\");");
                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj_Edit)
                {
                    var objVar = clsGCVariableBL.GetObjByVarId_Cache(objInfor.VarId_Cond1, objInfor.PrjId);
                    //if (objInfor.RegionTypeId == enumRegionType.EditRegion_0003) continue;
                    if (objInfor.CsType == "bool")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "{1}.BindDdl_TrueAndFalse(\"{0}\");",
                                 objInfor.CtrlId,
                                      ImportClass.GetOutString(string.Format("clsCommFunc4Web", objViewInfoENEx.TabName), this.Is4RJ));
                    }
                    else
                    {
                        if (objInfor.objFieldTab_ConditionField == null)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "const {2} = await {6}.BindDdl_{1}_Cache(\"{2}\", obj{3}_Cond);//{4}",
                                 objInfor.FldName,
                                         objInfor.objFieldTab_ValueField.FldName,
                         objInfor.CtrlId,
                         objInfor.Ds_TabName,
                         clsRegionTypeBL.GetNameByRegionTypeId_Cache(objInfor.RegionTypeId),
                         objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "",
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objInfor.Ds_TabName), this.Is4RJ));
                        }
                        else
                        {

                            string strVariableName = string.Format("{0}{1}",
                                        objInfor.objFieldTab_ConditionField.PrivFuncName(),
                                        objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "");
                            if (objVarManage.AddVariable(new clsVariable(strVariableName)) == true)
                            {

                                if (objViewInfoENEx.objCacheClassifyFld4View != null
                                    && objViewInfoENEx.objCacheClassifyFld4View.FldName == objInfor.objFieldTab_ConditionField.FldName)
                                {
                                    objVarManage.SetVariableProp(strVariableName, "\"\"", objVar.GetVarDef4View(ClsName));
                                }
                                else
                                {
                                    objVarManage.SetVariableProp(strVariableName, "\"\"", objVar.GetVarDef4View(ClsName));
                                }

                                //生成缓存分类字段的检查代码，检查是否被赋正确值
                                clsPubFun4GC.GC_CheckCode4CacheClassifyFld(strCodeForCs, objViewInfoENEx.objCacheClassifyFld4View, strVariableName, this.ClsName);
                                strCodeForCs.AppendFormat("\r\n" + "//var {0}{2} = \"\";//定义条件字段",
                                    objInfor.objFieldTab_ConditionField.PrivFuncName(), objInfor.objFieldTab_ConditionField.ObjDataTypeAbbr().TypeScriptType,
                                    objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "");
                            }

                            //strCodeForCs.AppendFormat("\r\n" + "const {0}{2} = \"\";",
                            //         objInfor.objFieldTab_ConditionField.PrivFuncName(),
                            //         objInfor.objFieldTab_ConditionField.ObjDataTypeAbbr().TypeScriptType,
                            //         objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "");

                            strCodeForCs.AppendFormat("\r\n" + "const {2} = await {7}.BindDdl_{1}_Cache(\"{2}\", obj{3}_Cond, {5}{6});//{4}",
                                 objInfor.FldName,
                                 objInfor.objFieldTab_ValueField.FldName,
                         objInfor.CtrlId, objInfor.Ds_TabName
                         , clsRegionTypeBL.GetNameByRegionTypeId_Cache(objInfor.RegionTypeId),
                         objInfor.objFieldTab_ConditionField.PrivFuncName(),
                         objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "",
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objInfor.Ds_TabName), this.Is4RJ));
                        }
                    }
                }
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


        private List<ImportClass> GetImportClassLst(clsFuncModule_AgcEN objFuncModule)
        {
            List<ImportClass> arrImportClass = new List<ImportClass>();
            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("cls{0}EN", objViewInfoENEx.TabName),
                FilePath = string.Format("../../Js/L0_Entity/{0}/cls{1}EN.js", objFuncModule.FuncModuleEnName,
                   objViewInfoENEx.TabName)
            });
            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("cls{0}BL", objViewInfoENEx.TabName),
                FilePath = string.Format("../../Js/L2_BLL/{0}/cls{1}BL.js", objFuncModule.FuncModuleEnName,
 objViewInfoENEx.TabName)
            });
            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("cls{0}WApi", objViewInfoENEx.TabName),
                FilePath = string.Format("../../Js/L3_ForWApi/{0}/cls{1}WApi.js", objFuncModule.FuncModuleEnName,
           objViewInfoENEx.TabName)
            });
            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("clsCommFunc4Web", objViewInfoENEx.TabName),
                FilePath = string.Format("clscommonfunc4web", objFuncModule.FuncModuleEnName,
        objViewInfoENEx.TabName)
            });
            if (objViewInfoENEx.TabName != objViewInfoENEx.TabName_Out)
            {
                arrImportClass.Add(new ImportClass
                {
                    ClassName = string.Format("cls{0}BL", objViewInfoENEx.TabName_Out),
                    FilePath = string.Format("../../Js/L2_BLL/{0}/cls{1}BL.js", objFuncModule.FuncModuleEnName,
                                   objViewInfoENEx.TabName_Out)
                });
                arrImportClass.Add(new ImportClass
                {
                    ClassName = string.Format("cls{0}EN", objViewInfoENEx.TabName_Out),
                    FilePath = string.Format("../../Js/L0_Entity/{0}/cls{1}EN.js", objFuncModule.FuncModuleEnName,
                                objViewInfoENEx.TabName_Out)
                });
                arrImportClass.Add(new ImportClass
                {
                    ClassName = string.Format("cls{0}WApi", objViewInfoENEx.TabName_Out),
                    FilePath = string.Format("../../Js/L3_ForWApi/{0}/cls{1}WApi.js", objFuncModule.FuncModuleEnName,
                                objViewInfoENEx.TabName_Out)
                });
            }
            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("tzDictionary", objViewInfoENEx.TabName),
                ModuleName = "Dictionary_js_1",
                FilePath = string.Format("tzdictionary", objFuncModule.FuncModuleEnName,
               objViewInfoENEx.TabName)
            });

            List<string> arrTabId4Ddl = clsViewInfoBLEx.getRelaTabId4Ddl_Qry(objViewInfoENEx.ViewId, objViewInfoENEx.PrjId);
            foreach (string strTabId in arrTabId4Ddl)
            {
                if (strTabId == objViewInfoENEx.MainTabId) continue;
                clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId_Cache(strTabId, objViewInfoENEx.PrjId);

                clsFuncModule_AgcEN objFuncModule_AgcEN = clsFuncModule_AgcBL.GetObjByFuncModuleAgcId_Cache(objPrjTabEN.FuncModuleAgcId, objPrjTabEN.PrjId);
                arrImportClass.Add(new ImportClass
                {
                    ClassName = string.Format("cls{0}EN", objViewInfoENEx.TabName),
                    FilePath = string.Format("../../Js/L0_Entity/{0}/cls{1}EN.js", objFuncModule_AgcEN.FuncModuleEnName,
                             objPrjTabEN.TabName)
                });

                arrImportClass.Add(new ImportClass
                {
                    ClassName = string.Format("cls{0}WApi", objViewInfoENEx.TabName),
                    FilePath = string.Format("../../Js/L3_ForWApi/{0}/cls{1}WApi.js", objFuncModule_AgcEN.FuncModuleEnName,
                             objPrjTabEN.TabName)
                });

            }
            List<string> arrTabName = new List<string>();
            foreach (ASPDropDownListEx objInfor in objViewInfoENEx.arrASPDropDownListObj)
            {
                if (arrTabName.Contains(objInfor.Ds_TabName) == true) continue;
                if (string.IsNullOrEmpty(objInfor.Ds_TabId) == true) continue;
                arrTabName.Add(objInfor.Ds_TabName);
                clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId_Cache(objInfor.Ds_TabId, objViewInfoENEx.PrjId);

                clsFuncModule_AgcEN objFuncModule_AgcEN = clsFuncModule_AgcBL.GetObjByFuncModuleAgcId_Cache(objPrjTabEN.FuncModuleAgcId, objPrjTabEN.PrjId);
                arrImportClass.Add(new ImportClass
                {
                    ClassName = string.Format("cls{0}EN", objInfor.Ds_TabName),
                    FilePath = string.Format("../../Js/L0_Entity/{0}/cls{1}EN.js", objFuncModule_AgcEN.FuncModuleEnName,
          objInfor.Ds_TabName)
                });
                arrImportClass.Add(new ImportClass
                {
                    ClassName = string.Format("cls{0}WApi", objInfor.Ds_TabName),
                    FilePath = string.Format("../../Js/L3_ForWApi/{0}/cls{1}WApi.js", objFuncModule_AgcEN.FuncModuleEnName,
                          objInfor.Ds_TabName)
                });
            }
            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("cls{0}WApi", objViewInfoENEx.TabName_Out),
                FilePath = string.Format("../../Js/L3_ForWApi/{0}/cls{1}WApi.js", objFuncModule.FuncModuleEnName,
                  objViewInfoENEx.TabName_Out)
            });


            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("clsPager", objViewInfoENEx.TabName),
                FilePath = string.Format("../../Js/PubFun/clsPager.js", objFuncModule.FuncModuleEnName,
            objViewInfoENEx.TabName)
            });
            //arrImportClass.Add(new ImportClass
            //{
            //    ClassName = string.Format("clsStack1Trace", objViewInfoENEx.TabName),
            //    FilePath = string.Format("clsstacktrace", objFuncModule.FuncModuleEnName,
            //objViewInfoENEx.TabName)
            //});
            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("clsOrderByData", objViewInfoENEx.TabName),
                FilePath = string.Format("../../Js/PubFun/clsOrderByData.js", objFuncModule.FuncModuleEnName,
            objViewInfoENEx.TabName)
            });
            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("stuPagerPara", objViewInfoENEx.TabName),
                FilePath = string.Format("../../Js/PubFun/stuPagerPara.js", objFuncModule.FuncModuleEnName,
            objViewInfoENEx.TabName)
            });
            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("clsDataColumn", objViewInfoENEx.TabName),
                FilePath = string.Format("../../Js/PubFun/clsDataColumn.js", objFuncModule.FuncModuleEnName,
            objViewInfoENEx.TabName)
            });
            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("clsPubFun", objViewInfoENEx.TabName),
                FilePath = string.Format("../../Js/PubFun/clsPubFun.js", objFuncModule.FuncModuleEnName,
            objViewInfoENEx.TabName)
            });

            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("jsString", objViewInfoENEx.TabName),
                FilePath = string.Format("../../Js/PubFun/jsString.js", objFuncModule.FuncModuleEnName,
        objViewInfoENEx.TabName)
            });

            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("arrSelectedKeys", objViewInfoENEx.TabName),
                FilePath = string.Format("../../Js/PubFun/clsCommFunc4Web.js", objFuncModule.FuncModuleEnName,
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
            this.Is4RJ = true;
            arrPropertyDef4GC = new List<clsPropertyDef4GC>();
            //让用户设置属性;
            if (objViewInfoENEx.arrEditRegionFldSet4InUse == null || objViewInfoENEx.arrEditRegionFldSet4InUse.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有编辑区域,或者编辑区域没有字段。请检查!", strViewName);
                sbMessage.Append("\r\n当前界面的功能:查询(Q)、修改(U)、删除(D)、添加(I)。");
                throw new clsDbObjException(sbMessage.ToString());
            }
            if (objViewInfoENEx.arrQryRegionFldSet == null)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有查询区域。请检查!", strViewName);
                sbMessage.Append("\r\n当前界面的功能:查询(Q)、修改(U)、删除(D)、添加(I)。");
                throw new clsDbObjException(sbMessage.ToString());
            }
            if (objViewInfoENEx.arrDGRegionFldSet == null || objViewInfoENEx.arrDGRegionFldSet.Count == 0)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有DataGrid区域,或者DataGrid区域没有字段。请检查!", strViewName);
                sbMessage.Append("\r\n当前界面的功能:查询(Q)、修改(U)、删除(D)、添加(I)。");
                throw new clsDbObjException(sbMessage.ToString());
            }
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
            //    objViewInfoENEx.WebFormName = string.Format("WA_{0}_QUDI_Cache", objViewInfoENEx.TabName);
            //    objViewInfoENEx.WebFormFName = string.Format("WA_{0}_QUDI_Cache.js",
            //        objViewInfoENEx.TabName, objViewInfoENEx.WebFormName);
            //}
            //else
            //{
            //    objViewInfoENEx.WebFormName = string.Format("WA_{0}_QUDI_JS", objViewInfoENEx.TabName);
            //    objViewInfoENEx.WebFormFName = string.Format("WA_{0}_QUDI_JS.js",
            //        objViewInfoENEx.TabName, objViewInfoENEx.WebFormName);
            //}
            objViewInfoENEx.WebFormName = objViewInfoENEx.ClsName;
            objViewInfoENEx.WebFormFName = string.Format("{0}.js", objViewInfoENEx.ClsName);

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
                //类名开始
                strCodeForCs.Append(clsPubFun4GC.GenUserInfoAndDate4WebApi(objViewInfoENEx.CurrUserName,
                    objViewInfoENEx));


                List<ImportClass> arrImportClass = GetImportClassLst(objFuncModule);

                //strCodeForCs.Append("\r\n ///生成查询删除记录的控制层代码");
                //strCodeForCs.Append("\r\n" + GenRefDomainName());    //生成参考域名
                strCodeForCs.Append("\r\n" + "(function(factory) {");
                strCodeForCs.Append("\r\n" + "if (typeof module === \"object\" && typeof module.exports === \"object\")");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const v = factory(require, exports);");
                strCodeForCs.Append("\r\n" + "if (v !== undefined) module.exports = v;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else if (typeof define === \"function\" && define.amd)");
                strCodeForCs.Append("\r\n" + "{");
                IEnumerable<string> arrFilePath = arrImportClass.Select(x => string.Format("\"{0}\"", x.FilePath));
                string strFilePathStr = string.Join(",", arrFilePath);
                strCodeForCs.AppendFormat("\r\n" + "define([\"require\", \"exports\", {0}], factory);", strFilePathStr);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "})(function(require, exports) {");
                strCodeForCs.Append("\r\n" + "\"use strict\";");
                strCodeForCs.Append("\r\n" + "Object.defineProperty(exports, \"__esModule\", { value: true });");

                arrImportClass.ForEach(x =>
                {
                    if (string.IsNullOrEmpty(x.ModuleName) == true)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "const {0}_js_1 = require(\"{1}\");", x.ClassName, x.FilePath);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "const {2} = require(\"{1}\");", x.ClassName, x.FilePath, x.ModuleName);
                    }
                });

                strCodeForCs.AppendFormat("\r\n /* {0} 的摘要说明。其中Q代表查询,U代表修改",
                    objViewInfoENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "*/");


                strCodeForCs.AppendFormat("\r\n" + "const {0} = /** @class **/ (function() {{", objViewInfoENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n" + "function {0}()", objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");


                strCodeForCs.Append("\r\n" + "this.divName4DataList = \"divDataLst\";");
                strCodeForCs.Append("\r\n" + "this.objPager = new clsPager_js_1.clsPager();");
                strCodeForCs.AppendFormat("\r\n /**");
                strCodeForCs.AppendFormat("\r\n * 每页记录数，在扩展类可以修改");
                strCodeForCs.Append("\r\n" + "*/");

                strCodeForCs.Append("\r\n" + "this.recCount = 0;");
                strCodeForCs.Append("\r\n" + "}");





                strCodeForCs.AppendFormat("\r\n" + "Object.defineProperty({0}.prototype, \"PageSize\", {{",
                    objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "get: function() { return 5;},");
                strCodeForCs.Append("\r\n" + "enumerable: true,");
                strCodeForCs.Append("\r\n" + "configurable: true");
                strCodeForCs.Append("\r\n" + "});");



                strCodeForCs.Append("\r\n" + "");

                //strCodeForCs.Append("\r\n" + "#endregion 页面启动函数");
                //生成所有的函数
                IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                    clsvFunction4GeneCodeBLEx.GetObjLstByViewInfoEx(objViewInfoENEx);


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

                Gen_WApi_Js_ControlProperty(strCodeForCs);

                if (objViewInfoENEx.objCacheClassifyFld4View != null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "{0}.{1}_Cache = \"\";",
                        objViewInfoENEx.ClsName,
                        objViewInfoENEx.objCacheClassifyFld4View.FldName);
                }
                strCodeForCs.AppendFormat("\r\n" + "{0}.bolIsLoadEditRegion = false;  //", objViewInfoENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n" + "{0}.divName4Edit = \"divEdit\";  //", objViewInfoENEx.ClsName);


                strCodeForCs.AppendFormat("\r\n" + "return {0};", objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "}());");
                strCodeForCs.AppendFormat("\r\n" + "exports.{0} = {0};", objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "});");
            }
            catch (Exception ex)
            {
                string strMsg = string.Format("在生成函数:[{0}]时出错。{1}. (In {2})", strFuncName, ex.Message, clsStackTrace.GetCurrClassFunction());

                clsEntityBase.LogErrorS(ex, strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }


        //Object.defineProperty({0}.prototype, "UserStateId", {
        //    /*
        //    * 用户状态号
        //   **/
        //    get: function()
        //{
        //    return $("#ddlUserStateId").val();
        //},
        //    /*
        //    * 用户状态号
        //   **/
        //    set: function(value)
        //{
        //        $("#ddlUserStateId").val(value);
        //},
        //    enumerable: true,
        //    configurable: true
        //});

        public void Gen_WApi_Js_ControlProperty(StringBuilder strCodeForCs)
        {
            var arrPropertyDef4GC2 = arrPropertyDef4GC.OrderBy(x => x.PropertyName).Distinct(new PropertyDef4GCComparer()).ToList();

            arrPropertyDef4GC2.ForEach(x =>
            {
                strCodeForCs.AppendFormat("\r\n /**");
                strCodeForCs.AppendFormat("\r\n * {0}", x.Comment);
                //strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "Object.defineProperty({0}.prototype, \"{1}\", {{", objViewInfoENEx.ClsName, x.PropertyName);
                string[] arrOpType = x.OperateType.Split(",".ToCharArray());
                foreach (string strOpType in arrOpType)
                {
                    switch (strOpType)
                    {
                        case "get":
                            strCodeForCs.Append("\r\n" + "    get: function()");
                            strCodeForCs.Append("\r\n" + "{");
                            switch (x.ControlType)
                            {
                                case "checkbox":
                                case "CheckBox":
                                    strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").prop(\"checked\");", x.CtrlId);
                                    break;
                                case "input":
                                    strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").val();", x.CtrlId);
                                    break;
                                case "button":
                                    strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").html();", x.CtrlId);
                                    break;
                                case "dropdownlist":
                                    strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").val();", x.CtrlId);
                                    break;
                                default:
                                    strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").val();", x.CtrlId);
                                    break;
                            }
                            strCodeForCs.Append("\r\n" + " },");
                            break;
                        case "set":
                            strCodeForCs.Append("\r\n" + " set: function(value)");
                            strCodeForCs.Append("\r\n" + "{");
                            switch (x.ControlType)
                            {
                                case "checkbox":
                                    strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").attr(\"checked\", value);", x.CtrlId);
                                    break;
                                case "input":
                                    strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").val(value);", x.CtrlId);
                                    break;
                                case "button":
                                    strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").html(value);", x.CtrlId);
                                    break;
                                case "dropdownlist":
                                    strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").val(value);", x.CtrlId);
                                    break;
                                default:
                                    strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").val(value);", x.CtrlId);
                                    break;
                            }
                            strCodeForCs.Append("\r\n" + "},");
                            break;

                    }
                }
                strCodeForCs.Append("\r\n" + " enumerable: true,");
                strCodeForCs.Append("\r\n" + "configurable: true");
                strCodeForCs.Append("\r\n" + "});");
            });
        }

        public string Gen_WApi_Js_BindTab(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFlds_GridRegion = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.RegionId == objViewInfoENEx.objViewRegion_Feature.RegionId);

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.AppendFormat("\r\n /* 显示{0}对象的所有属性值", objViewInfoENEx.TabName_Out);
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n  <param name = \"divContainer\">显示容器</param>");
            strCodeForCs.AppendFormat("\r\n  <param name = \"arr{0}ObjLst\">需要绑定的对象列表</param>",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "*/");

            strCodeForCs.AppendFormat("\r\n" + "{1}.prototype.BindTab_{0} = function(divContainer, arr{0}ObjLst) ",
                objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "const o = document.getElementById(divContainer);");
            strCodeForCs.Append("\r\n" + "if (o == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"\" + divContainer + \"不存在！\");");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "const sstrFldName: Array < string > = new Array<string>();");
            //strCodeForCs.Append("\r\n" + "const sstrColHeader: Array < string > = new Array<string>();");
            //strCodeForCs.Append("\r\n" + "sstrFldName.push(\"IdentityID\"); sstrColHeader.push(\"身份Id\");");
            strCodeForCs.Append("\r\n" + "const arrDataColumn =");
            strCodeForCs.Append("\r\n" + "       [");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "fldName: \"\",");
            strCodeForCs.Append("\r\n" + "colHeader: \"\",");
            strCodeForCs.Append("\r\n" + "text: \"\",");
            strCodeForCs.Append("\r\n" + "columnType: \"CheckBox\",");
            strCodeForCs.Append("\r\n" + "orderNum: 1,");
            strCodeForCs.Append("\r\n" + "funcName: (strKey:string, strText:string) => { console.log(strKey, strText);return new HTMLElement();}");
            strCodeForCs.Append("\r\n" + "},");
            foreach (clsDGRegionFldsENEx objDGRegionFldsENEx in objViewInfoENEx.arrDGRegionFldSet)
            {
                if (objDGRegionFldsENEx.ObjFieldTabENEx == null) continue;

                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "fldName: \"{0}\",", objDGRegionFldsENEx.FldName);
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"{0}\",", objDGRegionFldsENEx.HeaderText);
                strCodeForCs.Append("\r\n" + "text: \"\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Label\",");
                strCodeForCs.Append("\r\n" + "orderNum: 1,");
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
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"修改\",");
                strCodeForCs.Append("\r\n" + "text: \"修改\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Button\",");
                strCodeForCs.Append("\r\n" + "orderNum: 1,");
                strCodeForCs.Append("\r\n" + "funcName: (strKeyId, strText) => { ");
                strCodeForCs.Append("\r\n" + "const btn1 = document.createElement(\"button\");");
                strCodeForCs.Append("\r\n" + "btn1.innerText = strText;");
                strCodeForCs.Append("\r\n" + "btn1.className = \"btn btn-outline-info btn-sm\";");
                strCodeForCs.Append("\r\n" + "btn1.setAttribute(\"onclick\", \"btnUpdateRecordInTab_Click('\" + strKeyId + \"');\");");

                strCodeForCs.Append("\r\n" + "return btn1;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "},");
            }
            if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.DelRecord_Gv_0175).Count() > 0)
            {
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "fldName: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"删除\",");
                strCodeForCs.Append("\r\n" + "text: \"删除\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Button\",");
                strCodeForCs.Append("\r\n" + "orderNum: 1,");
                strCodeForCs.Append("\r\n" + "funcName: (strKeyId, strText) => { ");
                strCodeForCs.Append("\r\n" + "const btn1 = document.createElement(\"button\");");
                strCodeForCs.Append("\r\n" + "btn1.innerText = strText;");
                strCodeForCs.Append("\r\n" + "btn1.className = \"btn btn-outline-info btn-sm\";");
                strCodeForCs.Append("\r\n" + "btn1.setAttribute(\"onclick\", \"btnDelRecordInTab_Click('\" + strKeyId + \"');\");");

                strCodeForCs.Append("\r\n" + "return btn1;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "},");
            }
            if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.DetailRecord_Gv_0181).Count() > 0)
            {
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "fldName: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"详细信息\",");
                strCodeForCs.Append("\r\n" + "text: \"详细信息\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Button\",");
                strCodeForCs.Append("\r\n" + "orderNum: 1,");
                strCodeForCs.Append("\r\n" + "funcName: (strKeyId, strText) => { ");
                strCodeForCs.Append("\r\n" + "const btn1 = document.createElement(\"button\");");
                strCodeForCs.Append("\r\n" + "btn1.innerText = strText;");
                strCodeForCs.Append("\r\n" + "btn1.className = \"btn btn-outline-info btn-sm\";");
                strCodeForCs.Append("\r\n" + "btn1.setAttribute(\"onclick\", \"btnDetailRecordInTab_Click('\" + strKeyId + \"');\");");

                strCodeForCs.Append("\r\n" + "return btn1;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "},");

            }
            if (arrFeatureRegionFlds_GridRegion.Where(x1 => x1.FeatureId == enumPrjFeature.SelectRecord_Gv_0182).Count() > 0)
            {
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "fldName: \"\",");
                strCodeForCs.AppendFormat("\r\n" + "colHeader: \"选择\",");
                strCodeForCs.Append("\r\n" + "text: \"选择\",");
                strCodeForCs.Append("\r\n" + "columnType: \"Button\",");
                strCodeForCs.Append("\r\n" + "orderNum: 1,");
                strCodeForCs.Append("\r\n" + "funcName: (strKeyId, strText) => { ");
                strCodeForCs.Append("\r\n" + "const btn1 = document.createElement(\"button\");");
                strCodeForCs.Append("\r\n" + "btn1.innerText = strText;");
                strCodeForCs.Append("\r\n" + "btn1.className = \"btn btn-outline-info btn-sm\";");
                strCodeForCs.Append("\r\n" + "btn1.setAttribute(\"onclick\", \"btnSelectRecordInTab_Click('\" + strKeyId + \"');\");");

                strCodeForCs.Append("\r\n" + "return btn1;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "},");

            }
            strCodeForCs.Append("\r\n" + "];");
            strCodeForCs.AppendFormat("\r\n" + "{2}.BindTabV3(o, arr{0}ObjLst, arrDataColumn,  cls{0}EN.con_{1}); ",
                objViewInfoENEx.TabName_Out, objKeyField.FldName,
                                      ImportClass.GetOutString(string.Format("clsCommFunc4Web", objViewInfoENEx.TabName), this.Is4RJ));
            strCodeForCs.Append("\r\n" + "this.objPager.recCount = this.recCount;");
            strCodeForCs.Append("\r\n" + "this.objPager.pageSize = this.pageSize;");
            strCodeForCs.Append("\r\n" + "this.objPager.ShowPager();");
            //strCodeForCs.Append("\r\n" + "$(\"#divPager\").load(\"../PubWebClass/pager.html\");");
            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }
        public string Gen_WApi_Js_AddDPV_Pager(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 在当前界面的列表区添加分页区域");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "{0}.AddDPV_Pager = function(divName4Pager) {{",
                objViewInfoENEx.ClsName);
            //strBuilder.Append("\r\n" + "const objLst = document.getElementsByTagName(\"div\");");
            //strBuilder.Append("\r\n" + "const strStartName = \"divEditPager\";");
            //strBuilder.AppendFormat("\r\n" + "let arrElement = WA_{0}_UT_JS.GetArray(objLst) ;", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\n" + "let arrDiv = arrElement ;");
            //strBuilder.Append("\r\n" + "let arrFind = arrDiv.filter(x => x.id.indexOf(strStartName) > -1);");
            //strBuilder.Append("\r\n" + "arrFind.forEach(x => x.innerHTML = \"\");");
            //strBuilder.Append("\r\n" + "//var o = document.getElementById(\"div\") ;");
            strBuilder.Append("\r\n" + "const strUrl = \"../../Js/ShareView/_Pager.html\";");
            strBuilder.Append("\r\n" + "console.log(\"divName4Pager:(In AddDPV_Pager)\" + divName4Pager);");
            strBuilder.Append("\r\n" + "$.ajax({");
            strBuilder.Append("\r\n" + "url: strUrl,");
            strBuilder.Append("\r\n" + "method: \"GET\",");
            strBuilder.Append("\r\n" + "dataType: \"html\",");
            strBuilder.Append("\r\n" + "data: { },");
            strBuilder.Append("\r\n" + "success: function(data:any) {");
            strBuilder.Append("\r\n" + "console.log(\"已经成功获取页面:\" + strUrl + \"  字节数: \" + data.length.toString());");
            strBuilder.Append("\r\n" + "$('#' + divName4Pager).html(data);");
            strBuilder.AppendFormat("\r\n" + "//setTimeout(() => {{ {0}.BindTab(); }}, 100);",
                ImportClass.GetOutString(string.Format("clsPagerObj", objViewInfoENEx.TabName), this.Is4RJ));
            strBuilder.AppendFormat("\r\n" + "//{0}.BindTab();",
                ImportClass.GetOutString(string.Format("clsPagerObj", objViewInfoENEx.TabName), this.Is4RJ));
            strBuilder.Append("\r\n" + "},");
            strBuilder.Append("\r\n" + "error: (e:any) => {");
            strBuilder.Append("\r\n" + "console.error(e);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }

        public string Gen_WApi_Js_AddDPV_Edit(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            string strClassName = string.Format("WA_{0}_Edit", objViewInfoENEx.TabName);
            clsViewRegionENEx objViewRegionENEx = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.EditRegion_0003);
            if (objViewRegionENEx != null && string.IsNullOrEmpty(objViewRegionENEx.ClassName) == false)
            {
                strClassName = objViewRegionENEx.ClassName;
            }

            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\r\n /// <summary>");
            strBuilder.Append("\r\n /// 在当前界面中，导入编辑区域");
            strBuilder.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strBuilder.Append("\r\n /// </summary>");
            strBuilder.Append("\r\n /// <returns></returns>");
            strBuilder.AppendFormat("\r\n" + "{0}.AddDPV_Edit = function(divName4Edit) {{",
                objViewInfoENEx.ClsName);
            //strBuilder.Append("\r\n" + "const objLst = document.getElementsByTagName(\"div\");");
            //strBuilder.Append("\r\n" + "const strStartName = \"divEditEdit\";");
            //strBuilder.AppendFormat("\r\n" + "let arrElement = WA_{0}_UT_JS.GetArray(objLst) ;", objPrjTabENEx.TabName);

            //strBuilder.Append("\r\n" + "let arrDiv = arrElement ;");
            //strBuilder.Append("\r\n" + "let arrFind = arrDiv.filter(x => x.id.indexOf(strStartName) > -1);");
            //strBuilder.Append("\r\n" + "arrFind.forEach(x => x.innerHTML = \"\");");
            //strBuilder.Append("\r\n" + "//var o = document.getElementById(\"div\") ;");
            strBuilder.AppendFormat("\r\n" + "const strUrl = \"./{0}.html\";", strClassName);
            strBuilder.Append("\r\n" + "console.log(\"divName4Edit:(In AddDPV_Edit)\" + divName4Edit);");
            strBuilder.Append("\r\n" + "return new Promise(function(resolve, reject) {");
            strBuilder.Append("\r\n" + "$.ajax({");
            strBuilder.Append("\r\n" + "url: strUrl,");
            strBuilder.Append("\r\n" + "method: \"GET\",");
            strBuilder.Append("\r\n" + "dataType: \"html\",");
            strBuilder.Append("\r\n" + "data: { },");
            strBuilder.Append("\r\n" + "success: function(data:any) {");
            strBuilder.Append("\r\n" + "console.log(\"已经成功获取页面:\" + strUrl + \"  字节数: \" + data.length.toString());");
            strBuilder.Append("\r\n" + "$('#' + divName4Edit).html(data);");
            strBuilder.Append("\r\n" + "resolve(true);");
            strBuilder.AppendFormat("\r\n" + "//setTimeout(() => {{ {0}.BindTab(); }}, 100);",
                ImportClass.GetOutString(string.Format("clsEditObj", objViewInfoENEx.TabName), this.Is4RJ));
            strBuilder.AppendFormat("\r\n" + "//{0}.BindTab();",
                ImportClass.GetOutString(string.Format("clsEditObj", objViewInfoENEx.TabName), this.Is4RJ));
            strBuilder.Append("\r\n" + "},");
            strBuilder.Append("\r\n" + "error: (e:any) => {");
            strBuilder.Append("\r\n" + "console.error(e);");
            strBuilder.Append("\r\n" + "reject(e);");
            strBuilder.Append("\r\n" + "}");
            strBuilder.Append("\r\n" + "});");
            strBuilder.Append("\r\n" + "});");
            strBuilder.Append("\r\n" + "}");
            return strBuilder.ToString();
        }



        public string Gen_WApi_Js_Demo_Session(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "/**");
            strCodeForCs.Append("\r\n" + "演示Session 操作");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.Demo_Session = async function()", objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "//设置Session");
            strCodeForCs.Append("\r\n" + "const strUserId = \"TestUserId\";");
            strCodeForCs.Append("\r\n" + "await this.SetSession(\"UserId\", strUserId);");
            strCodeForCs.Append("\r\n" + "//获取Session");
            strCodeForCs.Append("\r\n" + "const strUserId_Value1 = await this.GetSession(\"UserId\");");
            strCodeForCs.Append("\r\n" + "console.log('strUserId_Value1:' + strUserId_Value1);");
            strCodeForCs.Append("\r\n" + "//获取Session方法2：直接读取页面中的hidUserId");
            strCodeForCs.Append("\r\n" + "const strUserId_Value2 = this.hidUserId;");


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
            strCodeForCs.Append("\r\n" + "const strMsg = \"演示Session不成功,\" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Js_SetSession(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "/**");
            strCodeForCs.Append("\r\n" + "设置Session");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "<param name = \"Key\">关键字</param>");
            strCodeForCs.Append("\r\n" + "<param name = \"Value\">值</param>");
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.SetSession = function(Key, Value) {{", objViewInfoENEx.ClsName);
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
            strCodeForCs.Append("\r\n" + "const strKey = data.key;");
            strCodeForCs.Append("\r\n" + "const strValue = data.value;");


            strCodeForCs.Append("\r\n" + "console.log('strKey, strValue=' + strKey + strValue);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Js_GetSession(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n" + "/**");
            strCodeForCs.Append("\r\n" + "获取Session 关键字的值");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "<param name = \"Key\">关键字</param>");
            strCodeForCs.Append("\r\n" + " <return>值</return>");
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.GetSession = function(Key) {{", objViewInfoENEx.ClsName);
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
            strCodeForCs.Append("\r\n" + "const strKey = data.key;");
            strCodeForCs.Append("\r\n" + "const strValue = data.value;");

            strCodeForCs.Append("\r\n" + "console.log('strKey, strValue=' + strKey + strValue);");

            strCodeForCs.Append("\r\n" + "resolve(data);");
            strCodeForCs.Append("\r\n" + "},");
            strCodeForCs.Append("\r\n" + "error: function(result:any) {");
            strCodeForCs.Append("\r\n" + "console.error(result);");
            strCodeForCs.Append("\r\n" + "console.error(JSON.stringify(result));");
            //alert(JSON.stringify(result));
            strCodeForCs.Append("\r\n" + "if (result.statusText == \"error\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"网络错误！访问网络不成功！\";");
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


        public string Gen_WApi_Js_SetKeyReadOnly()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //生成私有代码;
                if (objKeyField.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                    {
                        if (objEditRegionFldsEx.FldName != objKeyField.ObjFieldTabENEx.FldName) continue;
                        strCodeForCs.Append("\r\n" + "/// <summary>");
                        strCodeForCs.Append("\r\n" + "/// 在用户自定义控件中，设置关键字的值，是否只读");
                        strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + "/// </summary>");
                        strCodeForCs.Append("\r\n" + "/// <param name = \"bolReadonly\">是否只读</param>");
                        strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.SetKeyReadOnly = function(bolReadonly)", objViewInfoENEx.ClsName);
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "$('#{0}').prop['ReadOnly'] = bolReadonly;", objEditRegionFldsEx.CtrlId);
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

        public string Gen_WApi_Js_Clear()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                //生成私有代码;
                strCodeForCs.Append("\r\n" + "/// <summary>");
                strCodeForCs.Append("\r\n" + "/// 清除用户自定义控件中，所有控件的值");
                strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "/// </summary>	");
                strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.Clear = function()", objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.InUse == false) continue;
                    if (objEditRegionFldsEx.ObjFieldTabENEx == null) continue;
                    if (objEditRegionFldsEx.ObjFieldTabENEx == null) continue;
                    if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                    && objEditRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        continue;
                    }
                    try
                    {
                        arrPropertyDef4GC.Add(new clsPropertyDef4GC
                        {
                            OperateType = "set",
                            ControlType = objEditRegionFldsEx.CtlTypeName,
                            CtrlId = objEditRegionFldsEx.CtrlId,
                            PropertyName = objEditRegionFldsEx.PropertyName(),
                            Comment = objEditRegionFldsEx.ObjFieldTabENEx.Caption,
                            DataType = objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType
                        });
                        string strInitValue = objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue4Var(this.objViewInfoENEx.objCodeType.ProgLangTypeId);

                        switch (objEditRegionFldsEx.objCtlTypeAbbr.CtlTypeName)
                        {
                            case "Button":
                                break;
                            case "CheckBox":
                                if (objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "this.{0} = false;",
                                    objEditRegionFldsEx.FldName);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "this.{0} = {1};",
                                    objEditRegionFldsEx.FldName,
                                    objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue);
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
                                objEditRegionFldsEx.CtrlId);
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
                                if (objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "this.{0} = {1};",
                                    objEditRegionFldsEx.FldName, strInitValue);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "this.{0} = \"{1}\";",
                                        objEditRegionFldsEx.FldName, objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue);
                                }

                                break;
                            default:
                                strCodeForCs.AppendFormat("\r\n" + "this.{0} = {1};",
                                 objEditRegionFldsEx.FldName, strInitValue);
                                break;
                        }
                    }
                    catch (Exception objException)
                    {
                        string strMsg = string.Format("生成字段:{0}时出错！{1}(In {2})", objEditRegionFldsEx.FldName,
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

        public string Gen_WApi_Js_CopyRecord()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {


                List<clsFeatureRegionFldsENEx> arrFeature_AdditionalCopy = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.FieldTypeId == enumFieldType.AdditionalCopyField_15).ToList();
                clsFieldTabEN objFieldTab_Copy = null;
                string strCopyValue = "";
                if (arrFeature_AdditionalCopy.Count() > 0)
                {
                    clsFeatureRegionFldsENEx objFeature_AdditionalCopy = arrFeature_AdditionalCopy[0];
                    strCopyValue = objFeature_AdditionalCopy.DefaultValue;
                    if (string.IsNullOrEmpty(strCopyValue)) strCopyValue = "C_";
                    if (string.IsNullOrEmpty(objFeature_AdditionalCopy.ReleFldId) == false)
                    {
                        objFieldTab_Copy = clsFieldTabBL.GetObjByFldId_Cache(objFeature_AdditionalCopy.ReleFldId, objViewInfoENEx.PrjId);
                    }
                }
                strCodeForCs.Append("\r\n /* 复制记录");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "{1}.prototype.CopyRecord = async function(arr{0}) {{", objKeyField.FldName, objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const responseText = await {2}.GetObjLstBy{1}Lst(arr{1});",
                    objViewInfoENEx.TabName_In, objKeyField.FldName,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName_In), this.Is4RJ));
                strCodeForCs.Append("\r\n" + "console.log('responseText=');");
                strCodeForCs.Append("\r\n" + "console.log(responseText);");
                strCodeForCs.Append("\r\n" + "const intCount = 0;");
                strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst =  responseText;",
                    objViewInfoENEx.TabName_In);
                strCodeForCs.AppendFormat("\r\n" + "for (const objInFor of arr{0}ObjLst)",
                    objViewInfoENEx.TabName_In);
                strCodeForCs.Append("\r\n" + "{");
                if (objFieldTab_Copy == null)
                {
                    //strCodeForCs.Append("\r\n" + "objInFor.ExamTypeName = \"C_\" + objInFor.ExamTypeName;");
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "objInFor.{0} =\"{1}\" + objInFor.{0};",
                        objFieldTab_Copy.PropertyName(), strCopyValue);
                }
                if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strMaxStrId = await {1}.GetMaxStrId();",
                        objViewInfoENEx.TabName_In,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName_In), this.Is4RJ));
                    strCodeForCs.Append("\r\n" + "console.log('strMaxStrId=' + strMaxStrId);");
                    strCodeForCs.AppendFormat("\r\n" + "objInFor.{0} = strMaxStrId;", objKeyField.PropertyName());
                }
                strCodeForCs.AppendFormat("\r\n" + "const responseText2 = await {1}.AddNewRecord(objInFor);", objViewInfoENEx.TabName_In,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName_In), this.Is4RJ));
                strCodeForCs.Append("\r\n" + "console.log('responseText2=');");
                strCodeForCs.Append("\r\n" + "console.log(responseText2);");
                strCodeForCs.Append("\r\n" + "const returnBool = !!responseText2;");
                strCodeForCs.Append("\r\n" + "if (returnBool == true)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strInfo = \"克隆记录成功!\";");
                strCodeForCs.Append("\r\n" + "intCount++;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strInfo = \"克隆记录不成功!\";");
                //strCodeForCs.Append("\r\n" + "$('#lblResult20').val(strInfo);");
                strCodeForCs.Append("\r\n" + "//显示信息框");
                strCodeForCs.Append("\r\n" + "alert(strInfo);");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "const strInfo = \"共克隆了\" + intCount + \"条记录!\";");
                //strCodeForCs.Append("\r\n" + "$('#lblResult20').val(strInfo);
                strCodeForCs.Append("\r\n" + "alert(strInfo);");
                strCodeForCs.Append("\r\n" + "console.log('完成！');");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = \"复制记录不成功,\" + e+ \".\";");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
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


        public string Gen_WApi_Js_btnOKUpd_Click()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,");
                strCodeForCs.Append("\r\n  具体功能为把界面内容同步数据库中,把界面内容保存到数据库中");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.btnSubmit_Click = async function()", objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                //strCodeForCs.AppendFormat("\r\n" + "//var strCommandText = $('#btnOKUpd').html();");
                strCodeForCs.AppendFormat("\r\n" + "const strCommandText = this.btnOKUpd;");

                clsPropertyDef4GC objPropertyDef4GC = new clsPropertyDef4GC
                {
                    OperateType = "get",
                    ControlType = "button",
                    CtrlId = "btnOKUpd",
                    PropertyName = "btnOKUpd",
                    Comment = "获取按钮的标1题",
                    DataType = "string"
                };
                arrPropertyDef4GC.Add(objPropertyDef4GC);


                strCodeForCs.Append("\r\n" + "try {");
                strCodeForCs.Append("\r\n" + "switch(strCommandText)");
                strCodeForCs.Append("\r\n" + "{");
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd)
                {

                    strCodeForCs.Append("\r\n" + "case \"添加\":");
                    strCodeForCs.AppendFormat("\r\n" + "this.btnSubmit_{0} = \"确认添加\";", objViewInfoENEx.TabName_In);
                    strCodeForCs.AppendFormat("\r\n" + "this.btnCancel_{0} = \"取消添加\";", objViewInfoENEx.TabName_In);

                    strCodeForCs.AppendFormat("\r\n" + "const responseText1 = await this.AddNewRecord();",
                    objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "break;				");
                    strCodeForCs.Append("\r\n" + "case \"确认添加\":");
                    strCodeForCs.Append("\r\n" + "//这是一个单表的插入的代码,由于逻辑层太简单,");
                    strCodeForCs.Append("\r\n" + "//就把逻辑层合并到控制层,");
                    strCodeForCs.Append("\r\n" + "if (this.opType == \"AddWithMaxId\")");
                    strCodeForCs.Append("\r\n" + "{");
                    if (objKeyField.CsType != "string")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "//const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData)=>{{",
                              objViewInfoENEx.TabName);
                        strCodeForCs.Append("\r\n" + "//var returnBool2 = jsonData;");
                        strCodeForCs.Append("\r\n" + "//if (returnBool2 == true)");
                        strCodeForCs.Append("\r\n" + "//{");
                        strCodeForCs.AppendFormat("\r\n" + "//HideDialog_{0}();", objViewInfoENEx.TabName_In);
                        strCodeForCs.AppendFormat("\r\n" + "//this.BindGv_{0}{1}();", objViewInfoENEx.TabName_Out, objViewInfoENEx.IsUseCache4List ? "_Cache" : "");
                        strCodeForCs.Append("\r\n" + "//}");
                        strCodeForCs.Append("\r\n" + "//});");

                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData)=>{{",
                              objViewInfoENEx.TabName);
                        strCodeForCs.Append("\r\n" + "const returnBool2 = jsonData;");
                        strCodeForCs.Append("\r\n" + "if (returnBool2 == true)");
                        strCodeForCs.Append("\r\n" + "{");


                        strCodeForCs.AppendFormat("\r\n" + "this.HideDialog_{0}();", objViewInfoENEx.TabName_In);

                        strCodeForCs.AppendFormat("\r\n" + "this.BindGv_{0}{1}();", objViewInfoENEx.TabName_Out, objViewInfoENEx.IsUseCache4List ? "_Cache" : "");

                        strCodeForCs.Append("\r\n" + "}");
                        strCodeForCs.Append("\r\n" + "});");
                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "else");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "const responseText2 = await this.AddNewRecordSave().then((jsonData)=>{{",
                          objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "const returnBool = jsonData;");
                    strCodeForCs.Append("\r\n" + "if (returnBool == true)");
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.AppendFormat("\r\n" + "this.HideDialog_{0}();", objViewInfoENEx.TabName_In);

                    strCodeForCs.AppendFormat("\r\n" + "this.BindGv_{0}{1}();", objViewInfoENEx.TabName_Out, objViewInfoENEx.IsUseCache4List ? "_Cache" : "");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "});");
                    strCodeForCs.Append("\r\n" + "}");

                    strCodeForCs.Append("\r\n" + "break;");
                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                {
                    strCodeForCs.Append("\r\n" + "case \"确认修改\":");
                    strCodeForCs.Append("\r\n" + "//这是一个单表的修改的代码,由于逻辑层太简单,");
                    strCodeForCs.AppendFormat("\r\n" + "const responseText3 = await this.UpdateRecordSave().then((jsonData)=>{{",
                    objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "const returnBool = jsonData;");
                    strCodeForCs.Append("\r\n" + "let strInfo = returnBool ? \"修改成功！\" : \"修改不成功！\";");
                    strCodeForCs.AppendFormat("\r\n" + "strInfo += \"(In {0}.btnSubmit_Click)\";",
                        objViewInfoENEx.ClsName);
                    //strCodeForCs.Append("\r\n" + "$('#l1blResult51').val(strInfo);");
                    strCodeForCs.Append("\r\n" + "//显示信息框");
                    strCodeForCs.Append("\r\n" + "console.log(strInfo);");
                    strCodeForCs.Append("\r\n" + "alert(strInfo);");

                    strCodeForCs.Append("\r\n" + "if (returnBool == true)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "this.HideDialog_{0}();", objViewInfoENEx.TabName_In);
                    strCodeForCs.AppendFormat("\r\n" + "this.BindGv_{0}{1}();", objViewInfoENEx.TabName_Out, objViewInfoENEx.IsUseCache4List ? "_Cache" : "");

                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "});");
                    strCodeForCs.Append("\r\n" + "break;");
                    strCodeForCs.Append("\r\n" + "default:");
                    strCodeForCs.Append("\r\n" + "const strMsg = \"strCommandText:\" + strCommandText + \"在switch中没有处理！(In btnSubmit_Click())\"");
                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "break;");
                }
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = \"(errid: WiTsCs0033)在保存记录时(\" + strCommandText + \")时出错!请联系管理员!\" + e+ \"\";");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
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

        public string Gen_WApi_Js_ShowTabObj(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 显示{0}对象的所有属性值");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());

            strCodeForCs.Append("\r\n  <param name = \"divContainer\">显示容器</param>");
            strCodeForCs.AppendFormat("\r\n  <param name = \"obj{0}\">需要显示的对象</param>",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "{1}.prototype.Show{0}Obj = function(divContainer, obj{0}) ",
                objViewInfoENEx.TabName, objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const o = document.getElementById(divContainer);");
            strCodeForCs.Append("\r\n" + "if (o == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"\" + divContainer + \"不存在！\");");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "const sstrKeys = {1}.GetObjKeys(obj{0});",
                objViewInfoENEx.TabName,
                                      ImportClass.GetOutString(string.Format("clsCommFunc4Web", objViewInfoENEx.TabName), this.Is4RJ));
            strCodeForCs.Append("\r\n" + "const ul = document.createElement(\"ul\");");

            strCodeForCs.Append("\r\n" + "for (const strKey of sstrKeys)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strValue = obj{0}.GetFldValue(strKey);",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "const li = document.createElement(\"li\");");
            strCodeForCs.Append("\r\n" + "li.innerHTML = \"\" + strKey + \":\" + strValue + \"\";");
            strCodeForCs.Append("\r\n" + "ul.appendChild(li);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "o.appendChild(ul);");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Js_UpdateRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 根据关键字获取相应的记录的对象");

            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n  <param name = \"sender\">参数列表</param>");
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "{2}.prototype.UpdateRecord = async function({0}) ",
                 objKeyField.PrivFuncName,
                  objKeyField.TypeScriptType, objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");

            //strCodeForCs.Append("\r\n" + "//$('#btnOKUpd').text(\"确认修改\");");
            //strCodeForCs.Append("\r\n" + "//$('#btnCancel').text(\"取消修改\");");
            //strCodeForCs.Append("\r\n" + "//$('#btnOKUpd').html(\"确认修改\");");
            //strCodeForCs.Append("\r\n" + "//$('#btnCancel').html(\"取消修改\");");
            strCodeForCs.Append("\r\n" + "this.btnOKUpd = \"确认修改\";");
            strCodeForCs.Append("\r\n" + "this.btnCancel = \"取消修改\";");

            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "set",
                ControlType = "button",
                CtrlId = "btnOKUpd",
                PropertyName = "btnOKUpd",
                Comment = "设置确定按钮的标题",
                DataType = "string"
            });

            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "set",
                ControlType = "button",
                CtrlId = "btnCancel",
                PropertyName = "btnCancel",
                Comment = "设置取消按钮的标题",
                DataType = "string"
            });

            //strCodeForCs.AppendFormat("\r\n" + "//$('#hidKeyId').val({0});", objKeyField.PrivFuncName);
            if (objKeyField.IsNumberType())
            {
                strCodeForCs.AppendFormat("\r\n" + "this.KeyId = {0}.toString();", objKeyField.PrivFuncName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "this.KeyId = {0};", objKeyField.PrivFuncName);
            }

            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            //GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;

            if (objDataTypeAbbrEN.IsNeedQuote == true)
            {
                //strCodeForCs.AppendFormat("\r\n" + "const {0}: {1} = strKeyId;",
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

                        //strCodeForCs.AppendFormat("\r\n" + "const {1} = Number(strKeyId);",
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


            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN = await {3}.GetObjBy{1}({2});",
                objViewInfoENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName_In), this.Is4RJ));

            strCodeForCs.AppendFormat("\r\n" + "this.GetDataFrom{0}Class(obj{0}EN);",
                objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "console.log(\"完成UpdateRecord!\");", objViewInfoENEx.TabName_Out);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"根据关键字获取相应的记录的对象不成功,\" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Js_SelectRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* ");
            strCodeForCs.Append("\r\n " + "根据关键字选择相应的记录");

            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n  <param name = \"sender\">参数列表</param>");
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "{2}.prototype.SelectRecord = async function({0}) ",
                 objKeyField.PrivFuncName,
                  objKeyField.TypeScriptType, objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");

            //strCodeForCs.Append("\r\n" + "$('#btnOKUpd').text(\"确认修改\");");
            //strCodeForCs.Append("\r\n" + "$('#btnCancel').text(\"取消修改\");");
            //strCodeForCs.Append("\r\n" + "$('#btnOKUpd').html(\"确认修改\");");
            //strCodeForCs.Append("\r\n" + "$('#btnCancel').html(\"取消修改\");");

            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            //GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;

            if (objDataTypeAbbrEN.IsNeedQuote == true)
            {
                //strCodeForCs.AppendFormat("\r\n" + "const {0}: {1} = strKeyId;",
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


            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN = await {3}.GetObjBy{1}({2});",
                objViewInfoENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName_In), this.Is4RJ));


            strCodeForCs.AppendFormat("\r\n" + "console.log(\"完成SelectRecord!\");", objViewInfoENEx.TabName_Out);
            strCodeForCs.AppendFormat("\r\n" + "{1}.Redirect(\"/Index/Main_{0}\");", objViewInfoENEx.TabName_Out,
                                      ImportClass.GetOutString(string.Format("clsCommFunc4Web", objViewInfoENEx.TabName), this.Is4RJ));

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"根据关键字获取相应的记录的对象不成功,\" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Js_DetailRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* ");
            strCodeForCs.Append("\r\n " + "根据关键字详细信息记录");

            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n  <param name = \"sender\">参数列表</param>");
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "{2}.prototype.DetailRecord = async function({0}) ",
                 objKeyField.PrivFuncName,
                  objKeyField.TypeScriptType, objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "this.btnOKUpd = \"\";");
            strCodeForCs.Append("\r\n" + "this.btnCancel = \"关闭\";");
            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "set",
                ControlType = "button",
                CtrlId = "btnOKUpd",
                PropertyName = "btnOKUpd",
                Comment = "设置确定按钮的标题",
                DataType = "string"
            });

            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "set",
                ControlType = "button",
                CtrlId = "btnCancel",
                PropertyName = "btnCancel",
                Comment = "设置取消按钮的标题",
                DataType = "string"
            });
            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            //GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;

            if (objDataTypeAbbrEN.IsNeedQuote == true)
            {
                //strCodeForCs.AppendFormat("\r\n" + "const {0}: {1} = strKeyId;",
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


            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN = await {3}.GetObjBy{1}({2});",
                objViewInfoENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName_In), this.Is4RJ));

            strCodeForCs.AppendFormat("\r\n" + "this.GetDataFrom{0}Class(obj{0}EN);",
                objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "console.log(\"完成DetailRecord!\");", objViewInfoENEx.TabName_Out);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"根据关键字获取相应的记录的对象不成功,\" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Js_ScriptCSGetFirstObj(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            //clsvFunction4GeneCodeEN objvFunction4GeneCodeEN
            //objvFunction4GeneCodeEN.FuncId4GC;
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 根据条件获取相应的第一条记录的对象");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");

            strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.btnGetFirstObj_Click = async function() {{", objViewInfoENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);


            //strCodeForCs.Append("\r\n" + "strWhereCond =\" 1=1 \";");
            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN = await {1}.GetFirstObj(strWhereCond);",
                objViewInfoENEx.TabName,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName_In), this.Is4RJ));

            strCodeForCs.AppendFormat("\r\n" + "strWhereCond = $('#txtstrWhereCond{0}').val();",
                        objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = \"根据条件:[\" + strWhereCond + \"] 获取第一个记录对象：\" + obj{0}EN.{1} + \"!\";",
                objViewInfoENEx.TabName,
                objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "this.Show{1}Obj(\"divResult{0}\", obj{1}EN);",
    objvFunction4GeneCodeEN.OrderNum, objViewInfoENEx.TabName);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"根据条件获取相应的第一条记录的对象不成功,\" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Js_QueryLst(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 根据条件获取相应的对象列表");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "{1}.prototype.Query{0}Lst = function(strListDiv) ",
                objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            strCodeForCs.AppendFormat("\r\n" + "const strWhereCond = this.Combine{0}Condition();", objViewInfoENEx.TabName_Out);

            //strCodeForCs.Append("\r\n" + "const1 intCurrPageIndex = this.CurrPageIndex;//获取当前页");
            strCodeForCs.Append("\r\n" + "const intCurrPageIndex = GetCurrPageIndex(this.currPageIndex);//获取当前页");

            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "get",
                ControlType = "input",
                CtrlId = "hidCurrPageIndex",
                PropertyName = "CurrPageIndex",
                Comment = "获取当前页序号",
                DataType = "number"

            });
            //GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            strCodeForCs.Append("\r\n" + "return new Promise((resolve, reject) => {");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const objPagerPara = {");
            strCodeForCs.Append("\r\n" + "pageIndex: intCurrPageIndex,");
            strCodeForCs.Append("\r\n" + "pageSize: this.pageSize,");
            strCodeForCs.Append("\r\n" + "whereCond: strWhereCond,");
            strCodeForCs.AppendFormat("\r\n" + "orderBy: {1}.sort{0}By", objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "const responseText = {1}.GetObjLstByPager(objPagerPara).then((jsonData)=>{{",
                objViewInfoENEx.TabName_Out,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName_Out), this.Is4RJ));

            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst  = jsonData;",
                objViewInfoENEx.TabName_Out);

            //strCodeForCs.AppendFormat("\r\n" + "const strInfo = \"根据条件:[\" + strWhereCond + \"]共获取对象列表数：\" + arr{0}ObjLst.length + \"!\";",
            //    objViewInfoENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            //strCodeForCs.Append("\r\n" + "//显示信息框");
            //strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(strListDiv, arr{1}ObjLst);",
                 objvFunction4GeneCodeEN.OrderNum, objViewInfoENEx.TabName_Out);
            strCodeForCs.AppendFormat("\r\n" + "console.log(\"完成Query{0}Lst!\");", objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "resolve(jsonData);");
            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"查询对象列表不成功,\" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
        public string Gen_WApi_Js_BindGv(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (objViewInfoENEx.IsUseCache4List) return "";
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 根据条件获取相应的对象列表");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");

            strCodeForCs.AppendFormat("\r\n" + "{1}.prototype.BindGv_{0} = async function() ",
                objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.Append("\r\n" + "const strListDiv = this.divName4DataList;");

            strCodeForCs.AppendFormat("\r\n" + "const strWhereCond = this.Combine{0}Condition();", objViewInfoENEx.TabName_Out);
            //strCodeForCs.Append("\r\n" + "const1 intCurrPageIndex = this.CurrPageIndex;//获取当前页");
            strCodeForCs.Append("\r\n" + "const intCurrPageIndex = GetCurrPageIndex(this.currPageIndex);//获取当前页");

            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "get",
                ControlType = "input",
                CtrlId = "hidCurrPageIndex",
                PropertyName = "CurrPageIndex",
                Comment = "获取当前页序号",
                DataType = "number"

            });

            //GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            //strCodeForCs.Append("\r\n" + "return new Promise((resolve, reject) => {");
            strCodeForCs.AppendFormat("\r\n" + " let arr{0}ObjLst = [];", objViewInfoENEx.TabName_Out);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const responseRecCount = await {1}.GetRecCountByCond(strWhereCond).then((jsonData) => {{",
objViewInfoENEx.TabName_Out,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName_Out), this.Is4RJ));

            strCodeForCs.AppendFormat("\r\n" + "this.recCount = jsonData;");
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "const objPagerPara = {");
            strCodeForCs.Append("\r\n" + "pageIndex: intCurrPageIndex,");
            strCodeForCs.Append("\r\n" + "pageSize: this.pageSize,");
            strCodeForCs.Append("\r\n" + "whereCond: strWhereCond,");
            strCodeForCs.AppendFormat("\r\n" + "orderBy: {1}.sort{0}By", objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "const responseObjLst = await {1}.GetObjLstByPager(objPagerPara).then((jsonData)=>{{",
                objViewInfoENEx.TabName_Out,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName_Out), this.Is4RJ));

            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst = jsonData;",
                objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"绑定GridView不成功,\" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ObjLst.length == 0)", objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！\";");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.AppendFormat("\r\n" + "const strInfo = \"根据条件:[\" + strWhereCond + \"]共获取对象列表数：\" + arr{0}ObjLst.length + \"!\";",
            //    objViewInfoENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            //strCodeForCs.Append("\r\n" + "//显示信息框");
            //strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(strListDiv, arr{1}ObjLst);",
                 objvFunction4GeneCodeEN.OrderNum, objViewInfoENEx.TabName_Out);
            strCodeForCs.AppendFormat("\r\n" + "console.log(\"完成BindGv_{0}!\");", objViewInfoENEx.TabName_Out);
            //strCodeForCs.Append("\r\n" + "resolve(jsonData);");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg =\"绑定对象列表不成功, \" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Js_BindGv_Cache(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 根据条件获取相应的对象列表");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");

            strCodeForCs.AppendFormat("\r\n" + "{1}.prototype.BindGv_{0}_Cache = async function() ",
                objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
            strCodeForCs.Append("\r\n" + "const strListDiv = this.divName4DataList;");

            strCodeForCs.AppendFormat("\r\n" + "const obj{0}_Cond = this.Combine{0}ConditionObj();", objViewInfoENEx.TabName_Out);
            if (objViewInfoENEx.objCacheClassifyFld4View != null)
            {
                strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue({3}.con_{1}, {4}, \"=\");",
                        objViewInfoENEx.TabName_Out,
                        objViewInfoENEx.objCacheClassifyFld4View.FldName,
                        clsString.combineStrS("9", objViewInfoENEx.objCacheClassifyFld4View.ObjFieldTabENEx.FldLength - 1),
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ),
                                      strVarDef4ViewCacheFld);
            }
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN_Sim = {1}.GetSimObjFromObj(obj{0}_Cond);", objViewInfoENEx.TabName_Out,
                                      ImportClass.GetOutString(string.Format("cls{0}BL", objViewInfoENEx.TabName_Out), this.Is4RJ));
            //strCodeForCs.AppendFormat("\r\n" + "//console.log(obj{0}EN_Sim);", objViewInfoENEx.TabName_Out);
            strCodeForCs.AppendFormat("\r\n" + "const strWhereCond = JSON.stringify(obj{0}EN_Sim);", objViewInfoENEx.TabName_Out);

            //strCodeForCs.Append("\r\n" + "const1 intCurrPageIndex = this.CurrPageIndex;//获取当前页");
            strCodeForCs.Append("\r\n" + "const intCurrPageIndex = GetCurrPageIndex(this.currPageIndex);//获取当前页");

            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "get",
                ControlType = "input",
                CtrlId = "hidCurrPageIndex",
                PropertyName = "CurrPageIndex",
                Comment = "获取当前页序号",
                DataType = "number"

            });

            //GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            //strCodeForCs.Append("\r\n" + "return new Promise((resolve, reject) => {");
            strCodeForCs.AppendFormat("\r\n" + " let arr{0}ObjLst = [];", objViewInfoENEx.TabName_Out);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            if (objViewInfoENEx.objCacheClassifyFld4View == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "this.recCount = await {1}.GetRecCountByCond_Cache(obj{0}_Cond);",
                    objViewInfoENEx.TabName_Out,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName_Out), this.Is4RJ));
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "this.recCount = await  {3}.GetRecCountByCond_Cache(obj{0}_Cond, {1}.{2}_Cache);",
                    objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName, objViewInfoENEx.objCacheClassifyFld4View.FldName,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName_Out), this.Is4RJ));
            }

            strCodeForCs.Append("\r\n" + "const objPagerPara = {");
            strCodeForCs.Append("\r\n" + "pageIndex: intCurrPageIndex,");
            strCodeForCs.Append("\r\n" + "pageSize: this.pageSize,");
            strCodeForCs.Append("\r\n" + "whereCond: strWhereCond,");
            strCodeForCs.AppendFormat("\r\n" + "orderBy: {1}.sort{0}By", objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "}");
            if (objViewInfoENEx.objCacheClassifyFld4View == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst = await {1}.GetObjLstByPager_Cache(objPagerPara);",
                    objViewInfoENEx.TabName_Out,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName_Out), this.Is4RJ));
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst = await {3}.GetObjLstByPager_Cache(objPagerPara, {1}.{2}_Cache);",
                    objViewInfoENEx.TabName_Out,
                    objViewInfoENEx.ClsName,
                    objViewInfoENEx.objCacheClassifyFld4View.FldName,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName_Out), this.Is4RJ));
            }

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"绑定GridView不成功,\" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "if (arr{0}ObjLst.length == 0)", objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "{");
            if (objViewInfoENEx.objCacheClassifyFld4View == null)
            {
                strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key={0})\";",
                    objViewInfoENEx.TabName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key={0}_\" + {1}.{2}_Cache + \")\";",
                     objViewInfoENEx.TabName, objViewInfoENEx.ClsName, objViewInfoENEx.objCacheClassifyFld4View.FldName);
            }
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.AppendFormat("\r\n" + "const strInfo = \"根据条件:[\" + strWhereCond + \"]共获取对象列表数：\" + arr{0}ObjLst.length + \"!\";",
            //    objViewInfoENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            //strCodeForCs.Append("\r\n" + "//显示信息框");
            //strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(strListDiv, arr{1}ObjLst);",
                 objvFunction4GeneCodeEN.OrderNum, objViewInfoENEx.TabName_Out);
            strCodeForCs.AppendFormat("\r\n" + "console.log(\"完成BindGv_{0}!\");", objViewInfoENEx.TabName_Out);
            //strCodeForCs.Append("\r\n" + "resolve(jsonData);");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg =\"绑定对象列表不成功, \" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "});");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Js_btnQuery_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 根据条件获取相应的对象列表");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "{1}.prototype.btnQuery_Click = async function(strListDiv) ",
                objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
            if (objViewInfoENEx.IsUseCache4List)
            {
                strCodeForCs.AppendFormat("\r\n" + "const obj{0}_Cond = this.Combine{0}ConditionObj();", objViewInfoENEx.TabName_Out);
                if (objViewInfoENEx.objCacheClassifyFld4View != null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue({3}.con_{1}, {4}, \"=\");",
                            objViewInfoENEx.TabName_Out,
                            objViewInfoENEx.objCacheClassifyFld4View.FldName,
                            clsString.combineStrS("9", objViewInfoENEx.objCacheClassifyFld4View.ObjFieldTabENEx.FldLength - 1),
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ),
                                      strVarDef4ViewCacheFld);
                }
                strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN_Sim = {1}.GetSimObjFromObj(obj{0}_Cond);", objViewInfoENEx.TabName_Out,
                                      ImportClass.GetOutString(string.Format("cls{0}BL", objViewInfoENEx.TabName_Out), this.Is4RJ));
                //strCodeForCs.AppendFormat("\r\n" + "//console.log(obj{0}EN_Sim);", objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "const strWhereCond = JSON.stringify(obj{0}EN_Sim);", objViewInfoENEx.TabName_Out);

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                if (objViewInfoENEx.objCacheClassifyFld4View == null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "this.recCount = await {1}.GetRecCountByCond_Cache(obj{0}_Cond);",
                        objViewInfoENEx.TabName_Out,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName_Out), this.Is4RJ));
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "this.recCount = await {3}.GetRecCountByCond_Cache(obj{0}_Cond, {1}.{2}_Cache);",
                        objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName, objViewInfoENEx.objCacheClassifyFld4View.FldName,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName_Out), this.Is4RJ));
                }

                strCodeForCs.Append("\r\n" + "const objPagerPara = {");
                strCodeForCs.Append("\r\n" + "pageIndex: 1,");
                strCodeForCs.Append("\r\n" + "pageSize: this.pageSize,");
                strCodeForCs.Append("\r\n" + "whereCond: strWhereCond,");
                strCodeForCs.AppendFormat("\r\n" + "orderBy: {1}.sort{0}By", objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "}");
                if (objViewInfoENEx.objCacheClassifyFld4View == null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst = await {1}.GetObjLstByPager_Cache(objPagerPara);",
                        objViewInfoENEx.TabName_Out,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName_Out), this.Is4RJ));
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst = await {3}.GetObjLstByPager_Cache(objPagerPara, {1}.{2}_Cache);",
                        objViewInfoENEx.TabName_Out,
                        objViewInfoENEx.ClsName, objViewInfoENEx.objCacheClassifyFld4View.FldName,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName_Out), this.Is4RJ));
                }
                strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(this.divName4DataList, arr{1}ObjLst);",
         objvFunction4GeneCodeEN.OrderNum, objViewInfoENEx.TabName_Out);


            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const strWhereCond = this.Combine{0}Condition();", objViewInfoENEx.TabName_Out);
                //GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const responseRecCount = await {1}.GetRecCountByCond(strWhereCond).then((jsonData) => {{",
        objViewInfoENEx.TabName_Out,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName_Out), this.Is4RJ));

                strCodeForCs.AppendFormat("\r\n" + "this.recCount = jsonData;");
                strCodeForCs.Append("\r\n" + "});");
                strCodeForCs.Append("\r\n" + "const objPagerPara = {");
                strCodeForCs.Append("\r\n" + "pageIndex: 1,");
                strCodeForCs.Append("\r\n" + "pageSize: this.pageSize,");
                strCodeForCs.Append("\r\n" + "whereCond: strWhereCond,");
                strCodeForCs.AppendFormat("\r\n" + "orderBy: {1}.sort{0}By", objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "const responseObjLst = await {1}.GetObjLstByPager(objPagerPara).then((jsonData) => {{",
                    objViewInfoENEx.TabName_Out,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName_Out), this.Is4RJ));

                strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst  = jsonData;",
                    objViewInfoENEx.TabName_Out);
                strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(this.divName4DataList, arr{1}ObjLst);",
         objvFunction4GeneCodeEN.OrderNum, objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "});");

            }



            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"查询不成功,\" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Js_btnExportExcel_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 根据条件获取相应的对象列表");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "{1}.prototype.btnExportExcel_Click = async function() ",
                objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            strCodeForCs.Append("\r\n" + "const strWhereCond =\" 1=1 \";");
            //GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const responseText = await {1}.GetObjLst(strWhereCond).then((jsonData)=>{{",
                objViewInfoENEx.TabName_Out,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName_Out), this.Is4RJ));

            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst  = jsonData;",
                objViewInfoENEx.TabName_Out);

            //strCodeForCs.AppendFormat("\r\n" + "const strInfo = \"根据条件:[\" + strWhereCond + \"]共获取对象列表数：\" + arr{0}ObjLst.length + \"!\";",
            //    objViewInfoENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            //strCodeForCs.Append("\r\n" + "//显示信息框");
            //strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(this.divName4DataList, arr{1}ObjLst);",
         objvFunction4GeneCodeEN.OrderNum, objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "});");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"导出Excel不成功,\" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Js_GetObjLst4DdlBind(clsViewInfoENEx objViewInfoENEx, string strTabName, string strValueFld, string strTextFld)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 根据条件获取相应的对象列表");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");

            strCodeForCs.AppendFormat("\r\n" + "{1}.prototype.btnGetObjLst_Click = async function() ",
                objViewInfoENEx.TabName, objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "strWhereCond =\" 1=1 \";");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst = await {1}.GetObjLst(strWhereCond);",
                objViewInfoENEx.TabName,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName), this.Is4RJ));

            strCodeForCs.AppendFormat("\r\n" + "const objFirstObj = new {1}();", objViewInfoENEx.TabName,
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ));
            strCodeForCs.AppendFormat("\r\n" + "objFirstObj.{0} = \"0\";",
               strValueFld, strTextFld);
            strCodeForCs.AppendFormat("\r\n" + "objFirstObj.{0} = \"请选择...\";", strTextFld);
            strCodeForCs.AppendFormat("\r\n" + "arr{0}ObjLst.add(0, objFirstObj);",
                strTabName);
            strCodeForCs.AppendFormat("\r\n" + "{1}.arr{0}ObjLst_Cache = arr{0}ObjLst;",
                strTabName, objViewInfoENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "mspnObject.setPrompt(\"请选择您的{0}: \");", objViewInfoENEx.TabCnName);

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
            strCodeForCs.Append("\r\n" + "const strMsg = \"根据条件获取相应的下拉框对象列表不成功,\" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Js_ScriptCSGetTopObjLst(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 根据条件获取相应的顶部对象列表");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "{1}.prototype.btnGetTopObjLst_Click = async function() ",
                objViewInfoENEx.TabName, objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst = await {1}.GetTopObjLst(strWhereCond, intTopSize);",
                objViewInfoENEx.TabName,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName), this.Is4RJ));

            strCodeForCs.AppendFormat("\r\n" + "const strInfo = \"根据条件:[\" + strWhereCond + \"],顶部数:[\" + intTopSize + \"]共获取顶部对象列表数：\" + arr{0}ObjLst.length + \"!\";",
                objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(\"divResult{0}\", arr{1}ObjLst);",
  objvFunction4GeneCodeEN.OrderNum, objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"根据条件获取相应的顶部对象列表不成功, \" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Js_ScriptCSGetObjLstByPager(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 根据条件获取相应的分页对象列表");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "{1}.prototype.btnGetObjLstByPager_Click = async function() ",
                objViewInfoENEx.TabName, objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            //strCodeForCs.Append("\r\n" + "Integer intPageIndex = 2;");
            //strCodeForCs.Append("\r\n" + "Integer intPageSize = 2;");
            //strCodeForCs.Append("\r\n" + "strWhereCond =\" 1=1 \";");
            //strCodeForCs.Append("\r\n" + "string strOrderBy =\"\";");

            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");


            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst = await {1}.GetObjLstByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);",
                objViewInfoENEx.TabName,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName), this.Is4RJ));

            strCodeForCs.AppendFormat("\r\n" + "const strInfo = \"根据条件:[\" + strWhereCond + \"],每页记录数:[\" + intPageSize+ \"],第[\" + intPageIndex+ \"]页,共获取分页对象列表数：\" + arr{0}ObjLst.length + \"!\";",
                objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(\"divResult{0}\", arr{1}ObjLst);",
  objvFunction4GeneCodeEN.OrderNum, objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"根据条件获取相应的分页对象列表不成功, \" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Js_ScriptCSGetObjLstByRange(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 根据条件获取范围内相应的对象列表");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "{1}.prototype.btnGetObjLstByRange_Click = async function() ",
                objViewInfoENEx.TabName, objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);


            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst = await {1}.GetObjLstByRange( intMinNum, intMaxNum, strWhereCond, strOrderBy);",
                objViewInfoENEx.TabName,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName), this.Is4RJ));

            strCodeForCs.AppendFormat("\r\n" + "const strInfo = \"根据条件:[\" + strWhereCond + \"],最小记录号:[\" + intMinNum + \"],最大记录号:[\" + intMaxNum + \"],共获取分页对象列表数：\" + arr{0}ObjLst.length + \"!\";",
                objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindTab_{1}(\"divResult{0}\", arr{1}ObjLst);",
  objvFunction4GeneCodeEN.OrderNum, objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"根据条件获取范围内相应的对象列表不成功, \" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }



        /// <summary>
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public string Gen_WApi_Js_ScriptCSIsExistRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 检查相应关键字的记录是否存在");

            strCodeForCs.AppendFormat("\r\n /// ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.btnIsExistRecord_Click = async function() {{", objViewInfoENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);


            //strCodeForCs.AppendFormat("\r\n" + "strWhereCond = \"{0} ='12'\";",
            //    objKeyField.FldName);
            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const returnBool = await {1}.IsExistRecord(strWhereCond);",
                objViewInfoENEx.TabName,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName), this.Is4RJ));

            strCodeForCs.Append("\r\n" + "if (returnBool == false)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "strWhereCond = $('#txtstrWhereCond{0}').val();",
                objvFunction4GeneCodeEN.OrderNum);

            strCodeForCs.AppendFormat("\r\n" + "const strInfo = \"根据条件:[\" + strWhereCond + \"] 的记录不存在!\";",
                objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "strWhereCond = $('#txtstrWhereCond{0}').val();",
                objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = \"根据条件:[\" + strWhereCond + \"]的相关记录存在!\";",
                objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"检查相应关键字的记录是否存在不成功, \" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 根据关键字获取相应的记录的对象 
        /// </summary>
        /// <returns></returns>
        public string Gen_WApi_Js_ScriptCSGetRecCountByCond(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 获取某一条件的记录数");

            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.btnGetRecCountByCond_Click = async function() {{", objViewInfoENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            //strCodeForCs.AppendFormat("\r\n" + "strWhereCond = \"{0} ='12'\";",
            //    objKeyField.FldName);
            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const responseText = await {1}.GetRecCountByCond(strWhereCond);",
                objViewInfoENEx.TabName,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName), this.Is4RJ));

            strCodeForCs.Append("\r\n" + "const returnInt = Number(responseText);");

            strCodeForCs.AppendFormat("\r\n" + "strWhereCond = $('#txtstrWhereCond{0}').val();",
                objvFunction4GeneCodeEN.OrderNum);

            strCodeForCs.AppendFormat("\r\n" + "const strInfo = \"根据条件:\" + strWhereCond + \"的记录数:\" + returnInt + \"!\";",
                objKeyField.FldName);
            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"获取某一条件的记录数不成功,\" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
        public string Gen_WApi_Js_btnDelRecordBySign_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 按标志删除记录");

            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.btnDelRecordBySign_Click = async function() {{", objViewInfoENEx.ClsName);


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const arrKeyIds = {0}.GetCheckedKeyIds();",
                                      ImportClass.GetOutString(string.Format("clsCommFunc4Web", objViewInfoENEx.TabName), this.Is4RJ));
            strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"请选择需要按标志删除的记录！\");");
            strCodeForCs.Append("\r\n" + "return \"\";");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.Append("\r\n" + "$(\"#Text1\").val(\"进入函数：btnDelete4Gv_Click\");");

            strCodeForCs.AppendFormat("\r\n" + "const returnInt = await {2}.DelRecordBySign(arrKeyIds);", objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower(),
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName), this.Is4RJ));

            strCodeForCs.Append("\r\n" + "if (returnInt > 0)");
            strCodeForCs.Append("\r\n" + "{");

            if (objViewInfoENEx.IsUseCache4List == true)
            {
                if (objViewInfoENEx.objCacheClassifyFld4View == null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "{1}.ReFreshCache();", objViewInfoENEx.TabName,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName), this.Is4RJ));
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "{3}.ReFreshCache({2}.{1}_Cache);",
                        objViewInfoENEx.TabName,
                        objViewInfoENEx.objCacheClassifyFld4View.FldName,
                        objViewInfoENEx.ClsName,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName), this.Is4RJ));
                }
            }
            strCodeForCs.Append("\r\n" + "const strInfo = \"按标志删除记录成功,共删除\" + returnInt + \"条记录!\";");
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"按标志删除记录不成功!\";");
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "const responseText2 = await this.BindGv_{0}{1}();", objViewInfoENEx.TabName_Out, objViewInfoENEx.IsUseCache4List ? "_Cache" : "");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"按标志删除记录不成功. \" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Js_btnUnDelRecordBySign_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 按标志恢复删除记录");

            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.btnUnDelRecordBySign_Click = async function() {{", objViewInfoENEx.ClsName);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const arrKeyIds = {0}.GetCheckedKeyIds();",
                                      ImportClass.GetOutString(string.Format("clsCommFunc4Web", objViewInfoENEx.TabName), this.Is4RJ));
            strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"请选择需要恢复删除的记录！\");");
            strCodeForCs.Append("\r\n" + "return \"\";");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.Append("\r\n" + "$(\"#Text1\").val(\"进入函数：btnDelete4Gv_Click\");");

            strCodeForCs.AppendFormat("\r\n" + "const returnInt = await {2}.UnDelRecordBySign(arrKeyIds);", objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower(),
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName), this.Is4RJ));

            strCodeForCs.Append("\r\n" + "if (returnInt > 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"按标志恢复记录成功,共恢复了\" + returnInt + \"条记录!\";");
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"按标志恢复记录不成功!\";");
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "const responseText2 = await this.BindGv_{0}{1}();", objViewInfoENEx.TabName_Out, objViewInfoENEx.IsUseCache4List ? "_Cache" : "");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"按标志恢复记录不成功. \" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Js_btnDelRecord_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 删除记录");

            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.btnDelRecord_Click = async function() {{", objViewInfoENEx.ClsName);


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const arrKeyIds = {0}.GetCheckedKeyIds();",
                                      ImportClass.GetOutString(string.Format("clsCommFunc4Web", objViewInfoENEx.TabName), this.Is4RJ));
            strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"请选择需要删除的记录！\");");
            strCodeForCs.Append("\r\n" + "return \"\";");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "if (clsCommFunc4Web.confirm_del(arrKeyIds.length) == false)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");


            //strCodeForCs.Append("\r\n" + "$(\"#Text1\").val(\"进入函数：btnDelete4Gv_Click\");");

            strCodeForCs.AppendFormat("\r\n" + "const responseText = await this.DelMultiRecord(arrKeyIds);", objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            if (objViewInfoENEx.IsUseCache4List)
            {
                strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = this.BindGv_{0}_Cache();", objViewInfoENEx.TabName_Out);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = await this.BindGv_{0}();", objViewInfoENEx.TabName_Out);
            }
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"删除记录不成功. \" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Js_btnDelRecordInTab_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* ");
            strCodeForCs.Append("\r\n 在数据表里删除记录");

            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.btnDelRecordInTab_Click = async function(strKeyId) {{", objViewInfoENEx.ClsName);


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + " if (strKeyId == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"请选择需要删除的记录！\");");
            strCodeForCs.Append("\r\n" + "return \"\";");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "if (clsCommFunc4Web.confirm_del(0) == false)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");


            //strCodeForCs.Append("\r\n" + "$(\"#Text1\").val(\"进入函数：btnDelete4Gv_Click\");");
            if (objKeyField.TypeScriptType == "number")
            {
                strCodeForCs.Append("\r\n" + "const lngKeyId =  Number(strKeyId);");

                strCodeForCs.AppendFormat("\r\n" + "const responseText = await this.DelRecord(lngKeyId);", objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const responseText = await this.DelRecord(strKeyId);", objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());

            }

            if (objViewInfoENEx.IsUseCache4List)
            {
                strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = this.BindGv_{0}_Cache();", objViewInfoENEx.TabName_Out);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = await this.BindGv_{0}();", objViewInfoENEx.TabName_Out);
            }

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"删除记录不成功. \" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Js_btnSelectRecordInTab_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* ");
            strCodeForCs.Append("\r\n 在数据表里选择记录");

            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.btnSelectRecordInTab_Click = async function(strKeyId) {{", objViewInfoENEx.ClsName);


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + " if (strKeyId == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"请选择需要删除的记录！\");");
            strCodeForCs.Append("\r\n" + "return \"\";");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "if (clsCommFunc4Web.confirm_del(0) == false)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");


            if (objKeyField.TypeScriptType == "number")
            {
                strCodeForCs.Append("\r\n" + "const lngKeyId =  Number(strKeyId);");

                strCodeForCs.AppendFormat("\r\n" + "this.SelectRecord(lngKeyId);",
                 objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "this.SelectRecord(strKeyId);",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            }

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"选择记录不成功. \" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Js_btnDetailRecordInTab_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* ");
            strCodeForCs.Append("\r\n 在数据表里详细信息记录");

            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.btnDetailRecordInTab_Click = async function(strKeyId) {{", objViewInfoENEx.ClsName);
            //strCodeForCs.Append("\r\n" + "//$('#hidOpType').val(\"Detail\");");
            strCodeForCs.Append("\r\n" + "this.opType = \"Detail\";");

           

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + " if (strKeyId == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"请选择需要详细信息的记录！\");");
            strCodeForCs.Append("\r\n" + "return \"\";");
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.Append("\r\n" + "$(\"#Text1\").val(\"进入函数：btnDelete4Gv_Click\");");
            if (objKeyField.TypeScriptType == "number")
            {
                strCodeForCs.Append("\r\n" + "const lngKeyId =  Number(strKeyId);");

                strCodeForCs.AppendFormat("\r\n" + "this.DetailRecord(lngKeyId);",
                 objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "this.DetailRecord(strKeyId);",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            }


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"详细信息记录不成功. \" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Js_btnUpdateRecord_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 修改记录");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.btnUpdateRecord_Click = async function() {{", objViewInfoENEx.ClsName);
            //strCodeForCs.Append("\r\n" + "$('#hidOpType').val(\"Update\");");
            strCodeForCs.Append("\r\n" + "this.opType = \"Update\";");


       
            strCodeForCs.AppendFormat("\r\n" + "const strKeyId = {0}.GetFirstCheckedKeyId();",
                                      ImportClass.GetOutString(string.Format("clsCommFunc4Web", objViewInfoENEx.TabName), this.Is4RJ));
            strCodeForCs.Append("\r\n" + "    if (strKeyId == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"请选择需要修改的记录！\");");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "if ({0}.bolIsLoadEditRegion == false)  //", objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const responseBool = await {0}.AddDPV_Edit({0}.divName4Edit);", objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n // 为编辑区绑定下拉框");
            strCodeForCs.AppendFormat("\r\n" + "const conBindDdl = await this.BindDdl4EditRegion();", objViewInfoENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "this.ShowDialog_{0}('Update');", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + "{0}.bolIsLoadEditRegion = true;  //", objViewInfoENEx.ClsName);
            if (objKeyField.TypeScriptType == "number")
            {
                strCodeForCs.Append("\r\n" + "const lngKeyId =  Number(strKeyId);");

                strCodeForCs.AppendFormat("\r\n" + "this.UpdateRecord(lngKeyId);",
                 objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "this.UpdateRecord(strKeyId);",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            }
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "this.ShowDialog_{0}('Update');", objViewInfoENEx.TabName_In);
            if (objKeyField.TypeScriptType == "number")
            {
                strCodeForCs.Append("\r\n" + "const lngKeyId =  Number(strKeyId);");

                strCodeForCs.AppendFormat("\r\n" + "this.UpdateRecord(lngKeyId);",
                 objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "this.UpdateRecord(strKeyId);",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            }
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Js_btnUpdateRecordInTab_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 在数据表里修改记录");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.btnUpdateRecordInTab_Click = async function(strKeyId) {{", objViewInfoENEx.ClsName);
            //strCodeForCs.Append("\r\n" + "$('#hidOpType').val(\"Update\");");
            strCodeForCs.Append("\r\n" + "this.opType = \"Update\";");

       
            strCodeForCs.Append("\r\n" + "    if (strKeyId == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"请选择需要修改的记录！\");");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.AppendFormat("\r\n" + "if ({0}.bolIsLoadEditRegion == false)  //", objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const responseBool = await {0}.AddDPV_Edit({0}.divName4Edit);", objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n // 为编辑区绑定下拉框");
            strCodeForCs.AppendFormat("\r\n" + "const conBindDdl = await this.BindDdl4EditRegion();", objViewInfoENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "this.ShowDialog_{0}('Update');", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + "{0}.bolIsLoadEditRegion = true;  //", objViewInfoENEx.ClsName);
            if (objKeyField.TypeScriptType == "number")
            {
                strCodeForCs.Append("\r\n" + "const lngKeyId =  Number(strKeyId);");

                strCodeForCs.AppendFormat("\r\n" + "this.UpdateRecord(lngKeyId);",
                 objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "this.UpdateRecord(strKeyId);",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            }
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "this.ShowDialog_{0}('Update');", objViewInfoENEx.TabName_In);
            if (objKeyField.TypeScriptType == "number")
            {
                strCodeForCs.Append("\r\n" + "const lngKeyId =  Number(strKeyId);");

                strCodeForCs.AppendFormat("\r\n" + "this.UpdateRecord(lngKeyId);",
                 objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "this.UpdateRecord(strKeyId);",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            }

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Js_ScriptCSDelRecords(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 删除记录");

            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.btnDelRecords_Click = async function() {{", objViewInfoENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            strCodeForCs.AppendFormat("\r\n" + "string strKeyIdLst = txtstrKeyIdLst{0}.Text.Trim();",
                  objvFunction4GeneCodeEN.OrderNum);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const responseText = await {2}.DelRecords(strKeyIdLst);",
                objViewInfoENEx.TabName,
                objKeyField.PrivFuncName,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName), this.Is4RJ));

            strCodeForCs.Append("\r\n" + "const returnInt = Number(responseText);");

            strCodeForCs.Append("\r\n" + "if (returnInt > 0)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "const strInfo = \"删除记录成功,共删除\" + returnInt + \"条记录!\";");
            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"删除记录不成功!\";");
            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"删除记录不成功. \" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Js_DelMultiRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 根据关键字列表删除记录");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "{1}.prototype.DelMultiRecord = async function(arr{0}) {{",
                objKeyField.FldName, objViewInfoENEx.ClsName);

            //   GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);

            //strCodeForCs.AppendFormat("\r\n" + "const arr{0}:Array<string> = arrKeys;", objKeyField.FldName);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const returnInt = await {2}.Del{0}s(arr{1});",
                objViewInfoENEx.TabName,
                objKeyField.FldName,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName), this.Is4RJ));

            strCodeForCs.Append("\r\n" + "if (returnInt > 0)");
            strCodeForCs.Append("\r\n" + "{");
            if (objViewInfoENEx.IsUseCache4List == true)
            {
                if (objViewInfoENEx.objCacheClassifyFld4View != null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "{3}.ReFreshCache({2}.{1}_Cache);",
                        objViewInfoENEx.TabName_In,
                        objViewInfoENEx.objCacheClassifyFld4View.FldName,
                        objViewInfoENEx.ClsName,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName), this.Is4RJ));
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "{1}.ReFreshCache();",
                        objViewInfoENEx.TabName_In,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName), this.Is4RJ));
                }
            }

            strCodeForCs.Append("\r\n" + "const strInfo = \"删除记录成功,共删除\" + returnInt + \"条记录!\";");
            //            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"删除记录不成功!\";");
            //strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "console.log(\"完成DelMultiRecord!\");", objViewInfoENEx.TabName_Out);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"删除记录不成功. \" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Js_DelRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /* ");
            strCodeForCs.Append("\r\n 根据关键字删除记录");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "{2}.prototype.DelRecord = async function({0}) {{",
                objKeyField.PrivFuncName,
                  objKeyField.TypeScriptType, objViewInfoENEx.ClsName);

            //   GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);

            //strCodeForCs.AppendFormat("\r\n" + "const arr{0}:Array<string> = arrKeys;", objKeyField.FldName);
            clsDataTypeAbbrEN objDataTypeAbbrEN = objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN;

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const returnInt = await {2}.DelRecord({1});",
                objViewInfoENEx.TabName,
                objKeyField.PrivFuncName,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName), this.Is4RJ));

            strCodeForCs.Append("\r\n" + "if (returnInt > 0)");
            strCodeForCs.Append("\r\n" + "{");
            if (objViewInfoENEx.IsUseCache4List == true)
            {
                if (objViewInfoENEx.objCacheClassifyFld4View != null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "{3}.ReFreshCache({2}.{1}_Cache);",
                        objViewInfoENEx.TabName_In, objViewInfoENEx.objCacheClassifyFld4View.FldName, objViewInfoENEx.ClsName,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName), this.Is4RJ));
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "{1}.ReFreshCache();",
                        objViewInfoENEx.TabName_In,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName), this.Is4RJ));
                }
            }

            strCodeForCs.Append("\r\n" + "const strInfo = \"删除记录成功,共删除\" + returnInt + \"条记录!\";");
            //            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"删除记录不成功!\";");
            //strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "console.log(\"完成DelRecord!\");", objViewInfoENEx.TabName_Out);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"删除记录不成功. \" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Js_ScriptCSDelMultiRecordByCond(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 根据条件删除多条记录");

            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.Append("\r\n" + "WApiUsers_QUDI_Cache.prototype.btnDelMultiRecordByCond_Click = async function() {");
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);
            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const returnInt = await {1}.Del{0}sByCond(strWhereCond);",
                objViewInfoENEx.TabName,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName), this.Is4RJ));

            strCodeForCs.Append("\r\n" + "if (returnInt > 0)");
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.Append("\r\n" + "const strInfo = \"删除记录成功,共删除\" + returnInt + \"条记录!\";");
            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"删除记录不成功!\";");
            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"删除记录不成功. \" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }




        /// <summary>
        /// 添加记录保存函数  
        /// </summary>
        /// <returns></returns>
        public string Gen_WApi_Js_AddNewRecordSave(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 添加新记录，保存函数");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.AddNewRecordSave = async function(){{", objViewInfoENEx.ClsName);

            //strCodeForCs.AppendFormat("\r\n" + "this.divName = \"div{0}\";", objvFunction4GeneCodeEN.FuncName4Code);                
            //arrPropertyDef4GC.Add(new clsPropertyDef4GC
            //{
            //    OperateType = "set",
            //    ControlType = "input",
            //    CtrlId = "hidDivName",
            //    PropertyName = "divName",
            //    Comment = "添加、修改用的层1名",
            //    DataType = "string"

            //});
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN = new {1}();",
               objViewInfoENEx.TabName,
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ));

            strCodeForCs.AppendFormat("\r\n" + "   this.PutDataTo{0}Class(obj{0}EN);",
                  objViewInfoENEx.TabName);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            if (objKeyField.PrimaryTypeId == enumPrimaryType.Identity_02)
            {

            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const bolIsExist = await {2}.IsExist(obj{0}EN.{1});",
                    objViewInfoENEx.TabName, objKeyField.FldName,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName), this.Is4RJ));

                strCodeForCs.Append("\r\n" + "if (bolIsExist == true)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"添加记录时，关键字：\" + obj{0}EN.{1} + \"已经存在！\";",
                    objViewInfoENEx.TabName, objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "return false;//一定要有一个返回值，否则会出错！");
                strCodeForCs.Append("\r\n" + "}");
            }
            strCodeForCs.AppendFormat("\r\n" + "const responseText2 = await {1}.AddNewRecord(obj{0}EN);",
                objViewInfoENEx.TabName,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName), this.Is4RJ));

            strCodeForCs.AppendFormat("\r\n" + "const returnBool = !!responseText2;",
                objViewInfoENEx.TabName);

            strCodeForCs.Append("\r\n" + "if (returnBool == true)");
            strCodeForCs.Append("\r\n" + "{");
            if (objViewInfoENEx.IsUseCache4List == true)
            {
                if (objViewInfoENEx.objCacheClassifyFld4View == null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "{1}.ReFreshCache();", objViewInfoENEx.TabName_In,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName), this.Is4RJ));
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "{2}.ReFreshCache(obj{0}EN.{1});",
                        objViewInfoENEx.TabName, objViewInfoENEx.objCacheClassifyFld4View.FldName,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName), this.Is4RJ));
                }

            }
            strCodeForCs.Append("\r\n" + "const strInfo = \"添加记录成功!\";");
            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"添加记录不成功!\";");
            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + "return false;//一定要有一个返回值，否则会出错！");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return responseText2;//一定要有一个返回值，否则会出错！");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"添加记录不成功,\" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return false;//一定要有一个返回值，否则会出错！");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return true;//一定要有一个返回值，否则会出错！");

            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }

        /// <summary>
        /// 添加记录保存函数  
        /// </summary>
        /// <returns></returns>
        public string Gen_WApi_Js_AddNewRecordWithMaxIdSave(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "string") return "";

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 添加新记录，由后台自动获取最大值的关键字。保存函数");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.AddNewRecordWithMaxIdSave = async function(){{", objViewInfoENEx.ClsName);

            //strCodeForCs.AppendFormat("\r\n" + "this.divName = \"div{0}\";", objvFunction4GeneCodeEN.FuncName4Code);
            //arrPropertyDef4GC.Add(new clsPropertyDef4GC
            //{
            //    OperateType = "set",
            //    ControlType = "input",
            //    CtrlId = "hidDivName",
            //    PropertyName = "divName",
            //    Comment = "添加、修改用的层1名",
            //    DataType = "string"

            //});
            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN = new {1}();",
               objViewInfoENEx.TabName,
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ));

            strCodeForCs.AppendFormat("\r\n" + "   this.PutDataTo{0}Class(obj{0}EN);",
                  objViewInfoENEx.TabName);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            if (objKeyField.PrimaryTypeId == enumPrimaryType.Identity_02)
            {

            }
            else
            {

            }
            strCodeForCs.AppendFormat("\r\n" + "const responseText2 = await {1}.AddNewRecordWithMaxId(obj{0}EN);",
                objViewInfoENEx.TabName,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName), this.Is4RJ));

            strCodeForCs.AppendFormat("\r\n" + "const returnBool = !!responseText2;",
                objViewInfoENEx.TabName);

            strCodeForCs.Append("\r\n" + "if (returnBool == true)");
            strCodeForCs.Append("\r\n" + "{");
            if (objViewInfoENEx.IsUseCache4List == true)
            {
                if (objViewInfoENEx.objCacheClassifyFld4View == null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "{1}.ReFreshCache();", objViewInfoENEx.TabName_In,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName), this.Is4RJ));
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "{2}.ReFreshCache(obj{0}EN.{1});",
                        objViewInfoENEx.TabName, objViewInfoENEx.objCacheClassifyFld4View.FldName,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName), this.Is4RJ));
                }

            }
            strCodeForCs.Append("\r\n" + "const strInfo = \"添加记录成功!\";");
            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = \"添加记录不成功!\";");
            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return responseText2;//一定要有一个返回值，否则会出错！");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"添加记录不成功,\" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return false;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return true;//一定要有一个返回值，否则会出错！");

            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Js_btnAddNewRecord_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 添加新记录");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.btnAddNewRecord_Click = async function() {{", objViewInfoENEx.ClsName);
            //        strCodeForCs.Append("\r\n" + "//$('#hidOpType').val(\"Add\");");
            strCodeForCs.Append("\r\n" + "this.opType = \"Add\";");


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "if ({0}.bolIsLoadEditRegion == false)  //", objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const responseBool = await {0}.AddDPV_Edit({0}.divName4Edit);", objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n // 为编辑区绑定下拉框");
            strCodeForCs.AppendFormat("\r\n" + "const conBindDdl = await this.BindDdl4EditRegion();", objViewInfoENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "this.ShowDialog_{0}('Add');", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + "{0}.bolIsLoadEditRegion = true;  //", objViewInfoENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "this.btnSubmit_{0} = \"确认添加\";", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + "this.btnCancel_{0} = \"取消添加\";", objViewInfoENEx.TabName_In);

            strCodeForCs.AppendFormat("\r\n" + "const responseText = this.AddNewRecord();",
                    objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "this.ShowDialog_{0}('Add');", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + "this.btnSubmit_{0} = \"确认添加\";", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + "this.btnCancel_{0} = \"取消添加\";", objViewInfoENEx.TabName_In);

            strCodeForCs.AppendFormat("\r\n" + "const responseText = await this.AddNewRecord();",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"添加新记录初始化不成功,\" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Js_btnAddNewRecordWithMaxId_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 添加新记录");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.btnAddNewRecordWithMaxId_Click = async function() {{", objViewInfoENEx.ClsName);
            //        strCodeForCs.Append("\r\n" + "//$('#hidOpType').val(\"Add\");");
            strCodeForCs.Append("\r\n" + "this.opType = \"AddWithMaxId\";");
                

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "this.btnSubmit_{0} = \"确认添加\";", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + "this.btnCancel_{0} = \"取消添加\";", objViewInfoENEx.TabName_In);

            strCodeForCs.AppendFormat("\r\n" + "const responseText = await this.AddNewRecordWithMaxId();",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"添加新记录初始化不成功,\" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_WApi_Js_GetMaxStrId(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 获取当前表关键字值的最大值,再加1,避免重复");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");


            strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.GetMaxStrId = async function(strKeyCtrlName) {{", objViewInfoENEx.ClsName);

            //strCodeForCs.AppendFormat("\r\n" + "this.divName = \"div{0}\";", objvFunction4GeneCodeEN.FuncName4Code);
            //arrPropertyDef4GC.Add(new clsPropertyDef4GC
            //{
            //    OperateType = "set",
            //    ControlType = "input",
            //    CtrlId = "hidDivName",
            //    PropertyName = "divName",
            //    Comment = "添加、修改用的层1名",
            //    DataType = "string"
            //});
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const returnString = await {1}.GetMaxStrId();",
                objViewInfoENEx.TabName,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName), this.Is4RJ));

            strCodeForCs.Append("\r\n" + "if (returnString == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = \"获取表{0}的最大关键字为空，不成功，请检查!\";",
                objViewInfoENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + " $(strKeyCtrlName).val(returnString);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = \"获取表{0}的最大关键字为：\" + returnString + \"!\";",
                objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + " $(strKeyCtrlName).val(returnString);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"获取表关键字的最大值不成功,\" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Js_ScriptCSGetMaxStrIdByPrefix(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 根据前缀获取当前表关键字值的最大值,再加1,避免重复");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");

            strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.btnGetMaxStrIdByPrefix_Click = async function() {{", objViewInfoENEx.ClsName);
            //            strCodeForCs.AppendFormat("\r\n" + "string strPrefix = \"2\";");
            strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const returnString = await {1}.GetMaxStrIdByPrefix(strPrefix);",
                objViewInfoENEx.TabName,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName), this.Is4RJ));

            strCodeForCs.Append("\r\n" + "if (returnString == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = \"获取表{0}的最大关键字为空，不成功，请检查!\";",
                objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = \"获取表{0}的最大关键字为：\" + returnString + \"!\";",
                objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"获取表关键字的最大值不成功,\" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Js_UpdateRecordSave(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /* 修改记录");
            strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + "*/");
            strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.UpdateRecordSave = async function() {{", objViewInfoENEx.ClsName);

            //strCodeForCs.AppendFormat("\r\n" + "this.divName = \"div{0}\";", objvFunction4GeneCodeEN.FuncName4Code);
            //arrPropertyDef4GC.Add(new clsPropertyDef4GC
            //{
            //    OperateType = "set",
            //    ControlType = "input",
            //    CtrlId = "hidDivName",
            //    PropertyName = "divName",
            //    Comment = "添加、修改用的层1名",
            //    DataType = "string"
            //});

            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN = new {1}();",
           objViewInfoENEx.TabName,
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ));

            if (objKeyField.TypeScriptType == "number")
            {
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = Number(this.keyId);",
                    objViewInfoENEx.TabName, objKeyField.PropertyName());
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = this.keyId;",
                    objViewInfoENEx.TabName, objKeyField.PropertyName());
            }

            strCodeForCs.AppendFormat("\r\n" + "   this.PutDataTo{0}Class(obj{0}EN);",
                objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.sf_UpdFldSetStr = obj{0}EN.updFldString;//设置哪些字段被修改(脏字段)",
                objViewInfoENEx.TabName);
            if (objKeyField.TypeScriptType == "number")
            {
                strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.{1} == 0 || obj{0}EN.{1} == undefined){{",
                objViewInfoENEx.TabName, objKeyField.PropertyName());

                strCodeForCs.Append("\r\n" + "console.error(\"关键字不能为空!\");");
                strCodeForCs.Append("\r\n" + "throw \"关键字不能为空!\";");
                //strCodeForCs.Append("\r\n" + "return false;");
                strCodeForCs.Append("\r\n" + "}");
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "if (obj{0}EN.{1} == \"\" || obj{0}EN.{1} == undefined){{",
                        objViewInfoENEx.TabName, objKeyField.PropertyName());
                strCodeForCs.Append("\r\n" + "console.error(\"关键字不能为空!\");");
                strCodeForCs.Append("\r\n" + "throw \"关键字不能为空!\";");
                //strCodeForCs.Append("\r\n" + "return false;");
                strCodeForCs.Append("\r\n" + "}");
            }

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const responseText = await {1}.UpdateRecord(obj{0}EN);",
                objViewInfoENEx.TabName,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName), this.Is4RJ));

            strCodeForCs.AppendFormat("\r\n" + "const returnBool = !!responseText;",
                  objViewInfoENEx.TabName);

            strCodeForCs.Append("\r\n" + "if (returnBool == true)");
            strCodeForCs.Append("\r\n" + "{");
            if (objViewInfoENEx.IsUseCache4List == true)
            {
                if (objViewInfoENEx.objCacheClassifyFld4View == null)
                {
                    strCodeForCs.AppendFormat("\r\n" + "{1}.ReFreshCache();", objViewInfoENEx.TabName_In,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName), this.Is4RJ));
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "{3}.ReFreshCache({2}.{1}_Cache);",
                        objViewInfoENEx.TabName,
                        objViewInfoENEx.objCacheClassifyFld4View.FldName,
                        objViewInfoENEx.ClsName,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName), this.Is4RJ));
                }

            }
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return returnBool;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"修改记录不成功,\" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return false;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return true;");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }
        Func<clsvViewFeatureFldsENEx, ASPDropDownListEx> GetDdlObj2 = obj => clsASPDropDownListBLEx.GetDropDownLst_Asp(obj, new clsGetTabFieldObj());

        public string Gen_WApi_Js_DdlBindFunction4Page_Load()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            //string strDS_DataValueField = "";
            //string strDs_TabName = "";
            try
            {

                foreach (ASPDropDownListEx objInfor in objViewInfoENEx.arrASPDropDownListObj)
                {
                    //if (objInfor.RegionTypeId == enumRegionType.EditRegion_0003) continue;
                    if (objInfor.CsType == "bool")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "{1}.BindDdl_TrueAndFalse(\"{0}\");",
                                 objInfor.CtrlId,
                                      ImportClass.GetOutString(string.Format("clsCommFunc4Web", objViewInfoENEx.TabName), this.Is4RJ));
                    }
                    else
                    {
                        if (objInfor.objFieldTab_ConditionField == null)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "const {2} = {6}.BindDdl_{1}_Cache(\"{2}\", obj{3}_Cond);//{4}",
                                 objInfor.FldName,
                                      objInfor.objFieldTab_ValueField.FldName,
                         objInfor.CtrlId,
                         objInfor.Ds_TabName,
                         clsRegionTypeBL.GetNameByRegionTypeId_Cache(objInfor.RegionTypeId),
                         objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "",
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objInfor.Ds_TabName), this.Is4RJ));
                        }
                        else
                        {

                            strCodeForCs.AppendFormat("\r\n" + "const {0}{2} = \"\";",
                                     objInfor.objFieldTab_ConditionField.PrivFuncName(),
                                     objInfor.objFieldTab_ConditionField.ObjDataTypeAbbr().TypeScriptType,
                                     objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "");
                            strCodeForCs.AppendFormat("\r\n" + "const {2} = {7}.BindDdl_{1}_Cache(\"{2}\", obj{3}_Cond, {5}{6});//{4}",
                                 objInfor.FldName,
                                        objInfor.objFieldTab_ValueField.FldName,
                         objInfor.CtrlId,
                         objInfor.Ds_TabName,
                         clsRegionTypeBL.GetNameByRegionTypeId_Cache(objInfor.RegionTypeId),
                         objInfor.objFieldTab_ConditionField.PrivFuncName(),
                         objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "",
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objInfor.Ds_TabName), this.Is4RJ));
                        }
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


        public string Gen_WApi_Js_DdlBindFunction4Page_Load_Cache(clsVarManage objVarManage)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            //string strDS_DataValueField = "";
            //string strDs_TabName = "";
            try
            {

                foreach (ASPDropDownListEx objInfor in objViewInfoENEx.arrASPDropDownListObj)
                {
                    var objVar = clsGCVariableBL.GetObjByVarId_Cache(objInfor.VarId_Cond1, objInfor.PrjId);
                    //if (objInfor.RegionTypeId == enumRegionType.EditRegion_0003) continue;
                    if (objInfor.CsType == "bool")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "{1}.BindDdl_TrueAndFalse(\"{0}\");",
                                 objInfor.CtrlId,
                                      ImportClass.GetOutString(string.Format("clsCommFunc4Web", objViewInfoENEx.TabName), this.Is4RJ));
                    }
                    else
                    {
                        if (objInfor.objFieldTab_ConditionField == null)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "const {2} = await {6}.BindDdl_{1}_Cache(\"{2}\", obj{3}_Cond);//{4}",
                                 objInfor.FldName,
                                         objInfor.objFieldTab_ValueField.FldName,
                         objInfor.CtrlId,
                         objInfor.Ds_TabName,
                         clsRegionTypeBL.GetNameByRegionTypeId_Cache(objInfor.RegionTypeId),
                         objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "",
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objInfor.Ds_TabName), this.Is4RJ));
                        }
                        else
                        {

                            string strVariableName = string.Format("{0}{2}",
                objInfor.objFieldTab_CacheClassify().PrivFuncName(), objInfor.objFieldTab_CacheClassify().ObjDataTypeAbbr().TypeScriptType,
                objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "");
                            if (objVarManage.AddVariable(new clsVariable(strVariableName)) == true)
                            {
                                if (objViewInfoENEx.objCacheClassifyFld4View.FldName == objInfor.objFieldTab_CacheClassify().FldName)
                                {
                                    objVarManage.SetVariableProp(strVariableName, "\"\"", objVar.GetVarDef4View(ClsName));
                                }
                                else
                                {
                                    objVarManage.SetVariableProp(strVariableName, "\"\"", objVar.GetVarDef4View(ClsName));
                                }

                                //生成缓存分类字段的检查代码，检查是否被赋正确值
                                clsPubFun4GC.GC_CheckCode4CacheClassifyFld(strCodeForCs, objViewInfoENEx.objCacheClassifyFld4View, strVariableName, this.ClsName);

                                strCodeForCs.AppendFormat("\r\n" + "//var {0}{2} = \"\";//定义条件字段",
                                    objInfor.objFieldTab_CacheClassify().PrivFuncName(), objInfor.objFieldTab_CacheClassify().ObjDataTypeAbbr().TypeScriptType,
                                    objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "");
                            }

                            //strCodeForCs.AppendFormat("\r\n" + "const {0}{2} = \"\";",
                            //         objInfor.objFieldTab_ConditionField.PrivFuncName(),
                            //         objInfor.objFieldTab_ConditionField.ObjDataTypeAbbr().TypeScriptType,
                            //         objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "");

                            strCodeForCs.AppendFormat("\r\n" + "const {2} = await {7}.BindDdl_{1}_Cache(\"{2}\", obj{3}_Cond, {5}{6});//{4}",
                                 objInfor.FldName,
                                 objInfor.objFieldTab_ValueField.FldName,
                         objInfor.CtrlId, objInfor.Ds_TabName
                         , clsRegionTypeBL.GetNameByRegionTypeId_Cache(objInfor.RegionTypeId),
                         objInfor.objFieldTab_ConditionField.PrivFuncName(),
                         objInfor.RegionTypeId == enumRegionType.QueryRegion_0001 ? "_q" : "",
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objInfor.Ds_TabName), this.Is4RJ));
                        }
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


        public string Gen_WApi_Js_CombineCondition(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                ///生成仅有变量;


                strCodeForCs.Append("\r\n /* 把所有的查询控件内容组合成一个条件串");
                strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());

                strCodeForCs.Append("\r\n  <returns>条件串(strWhereCond)</returns>");
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "{1}.prototype.Combine{0}Condition = function() ", objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//使条件串的初值为\"1 = 1\",以便在该串的后面用\"and \"添加其他条件,");
                strCodeForCs.Append("\r\n" + "//例如 1 = 1 && UserName = '张三'");
                strCodeForCs.Append("\r\n" + "let strWhereCond = \" 1 = 1 \";");
                strCodeForCs.Append("\r\n" + "//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。");

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    arrPropertyDef4GC.Add(new clsPropertyDef4GC
                    {
                        OperateType = "get",
                        ControlType = objQryRegionFldsEx.objCtlTypeAbbr.CtlTypeName,
                        CtrlId = objQryRegionFldsEx.CtrlId,
                        PropertyName = objQryRegionFldsEx.PropertyName,
                        Comment = objQryRegionFldsEx.ObjFieldTabENEx.Caption,
                        DataType = objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType
                    });
                    switch (objQryRegionFldsEx.objCtlTypeAbbr.CtlTypeName) //objEditRegionFldsEx.objCtlTypeAbbr.CtlTypeName
                    {

                        case "CheckBox":
                            //strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Checked == true)",
                            //            objQryRegionFldsEx.CtrlId);
                            strCodeForCs.AppendFormat("\r\n" + "if (this.{0} == true)",
                         objQryRegionFldsEx.PropertyName);
                            strCodeForCs.Append("\r\n" + "{");

                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += \" And \" + {2}.con_{0} + \" = '1'\";",
                                     objQryRegionFldsEx.FldName,
                                     objViewInfoENEx.TabName_Out,
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ)
                                     );
                            strCodeForCs.Append("\r\n" + "}");

                            strCodeForCs.AppendFormat("\r\n" + "else");
                            strCodeForCs.Append("\r\n" + "{");

                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += \" And \" + {2}.con_{0} + \" = '0'\";",
                                 objQryRegionFldsEx.FldName,
                                     objViewInfoENEx.TabName_Out,
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName_Out), this.Is4RJ));
                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case "DropDownList": ///如果控件是下拉框;
                            if (objQryRegionFldsEx.ObjFieldTabENEx.CsType == "bool")
                            {

                                strCodeForCs.AppendFormat("\r\n" + "if ($(\"#{0}\").prop(\"selectedIndex\") == 1)",
                                objQryRegionFldsEx.CtrlId);
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);

                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += \" And \" + {2}.con_{0} + \" = '1'\"; ",
                                      objQryRegionFldsEx.FldName,
                                       objViewInfoENEx.TabName_Out,
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ));
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.AppendFormat("\r\n" + "else if ($(\"#{0}\").prop(\"selectedIndex\") == 2)",
                                objQryRegionFldsEx.CtrlId);
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);

                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += \" And \" + {2}.con_{0} + \" = '0'\";",
                                       objQryRegionFldsEx.FldName,
                                     objViewInfoENEx.TabName_Out,
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ));
                                strCodeForCs.Append("\r\n" + "}");

                            }
                            else
                            {

                                if (objQryRegionFldsEx.ObjFieldTabENEx.IsNumberType())
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != 0)",
                                         objQryRegionFldsEx.PropertyName);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "if ( this.{0} != \"\" && this.{0} != \"0\")",
                                            objQryRegionFldsEx.PropertyName);
                                }
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);
                                switch (objQryRegionFldsEx.ObjFieldTabENEx.CsType)
                                {
                                    case "string":


                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += \" And \" + {3}.con_{0} + \" = '\" + this.{1} + \"'\";",
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName,
                                        objViewInfoENEx.TabName_Out,
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ));
                                        break;
                                    case "int":


                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += \" And \" + {3}.con_{0} + \" = \" + this.{1} + \"\";",
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName,
                                        objViewInfoENEx.TabName_Out,
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ));
                                        break;
                                    default:


                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += \" And \" + {3}.con_{0} + \" = '\" + this.{1} + \"'\";",
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName,
                                        objViewInfoENEx.TabName_Out,
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ));
                                        break;
                                }
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            break;

                        case "TextBox": ///如果控件类型是文本框;

                            if (objQryRegionFldsEx.ObjFieldTabENEx.CsType != "string"
                                && objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02)
                            {
                                objQryRegionFldsEx.QueryOptionId = enumQueryOption.EqualQuery_01;
                            }
                            if ((objQryRegionFldsEx.QueryOptionId == enumQueryOption.Known_00) ||
                            (objQryRegionFldsEx.QueryOptionId == enumQueryOption.EqualQuery_01)) ///相等查询;
                            {
                                if (objQryRegionFldsEx.ObjFieldTabENEx.IsNumberType())
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != 0)",
                                        objQryRegionFldsEx.PropertyName);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != \"\")",
                        objQryRegionFldsEx.PropertyName);
                                }

                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);
                                if (objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += \" And \" + {3}.con_{0} + \" = '\" + this.{1} + \"'\";",
                                objQryRegionFldsEx.FldName,
                                objQryRegionFldsEx.PropertyName,
                                objViewInfoENEx.TabName_Out,
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ));
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += \" And \" + {3}.con_{0} + \" = \" + this.{1} + \"\";",
                             objQryRegionFldsEx.FldName,
                             objQryRegionFldsEx.PropertyName,
                             objViewInfoENEx.TabName_Out,
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ));
                                }
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02) ///模糊查询;
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if ( this.{0} != \"\")", objQryRegionFldsEx.PropertyName);
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += \" And \" + {3}.con_{0} + \" like '% \" + this.{1} + \"%'\";",
                                   objQryRegionFldsEx.FldName,
                                     objQryRegionFldsEx.PropertyName,
                                     objViewInfoENEx.TabName_Out,
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ));
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.RangeQuery_03)
                            { ///范围查询;
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != \"\")", objQryRegionFldsEx.PropertyName);
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += \" And \" + {3}.con_{0} + \" = '\" + this.{1} + \"'\", , );",
                                objQryRegionFldsEx.FldName,
                                objQryRegionFldsEx.PropertyName,
                                objViewInfoENEx.TabName_Out,
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ));
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != \"\")", objQryRegionFldsEx.PropertyName);
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += \"And \" + {3}.con_{0} + \" = '\" + this.{1} + \"'\", , );",
                                     objQryRegionFldsEx.FldName,
                                      objQryRegionFldsEx.PropertyName,
                                      objViewInfoENEx.TabName_Out,
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ));
                                strCodeForCs.Append("\r\n" + "}");
                            }
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
                        case "CheckBoxList":
                            break;
                        case "DataGrid":
                            break;
                        case "DataList":
                            break;
                        case "Button":
                            break;
                    }
                }


                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(objException)");
                strCodeForCs.Append("\r\n" + "{");
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                  objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "CombineTabNameCondition(in js)", "在组合查询条件(CombineTabNameCondition(in js))时出错!请联系管理员!", "生成代码");
                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName);

                strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"(errid:{1})在组合查询条件(Combine{0}Condition)时出错!请联系管理员!\" + objException.message + \"\";",
                   objViewInfoENEx.TabName, strErrId);
                strCodeForCs.Append("\r\n" + "throw strMsg;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return strWhereCond;");
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

        public string Gen_WApi_Js_CombineConditionObj(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                ///生成仅有变量;


                strCodeForCs.Append("\r\n /* 把所有的查询控件内容组合成一个条件串");
                strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());

                strCodeForCs.Append("\r\n  <returns>条件串(strWhereCond)</returns>");
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "{1}.prototype.Combine{0}ConditionObj = function() ", objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "//使条件串的初值为\"1 = 1\",以便在该串的后面用\"and \"添加其他条件,");
                strCodeForCs.Append("\r\n" + "//例如 1 = 1 && UserName = '张三'");
                strCodeForCs.Append("\r\n" + "let strWhereCond = \" 1 = 1 \";");
                strCodeForCs.AppendFormat("\r\n" + "const obj{0}_Cond = new {1}();", objViewInfoENEx.TabName_Out,
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ));



                strCodeForCs.Append("\r\n" + "//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。");

                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
                {
                    arrPropertyDef4GC.Add(new clsPropertyDef4GC
                    {
                        OperateType = "get",
                        ControlType = objQryRegionFldsEx.objCtlTypeAbbr.CtlTypeName,
                        CtrlId = objQryRegionFldsEx.CtrlId,
                        PropertyName = objQryRegionFldsEx.PropertyName,
                        Comment = objQryRegionFldsEx.ObjFieldTabENEx.Caption,
                        DataType = objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType
                    });
                    switch (objQryRegionFldsEx.objCtlTypeAbbr.CtlTypeName) //objEditRegionFldsEx.objCtlTypeAbbr.CtlTypeName
                    {

                        case "CheckBox":
                            //strCodeForCs.AppendFormat("\r\n" + "if (this.{0}.Checked == true)",
                            //            objQryRegionFldsEx.CtrlId);
                            strCodeForCs.AppendFormat("\r\n" + "if (this.{0} == true)",
                         objQryRegionFldsEx.PropertyName);
                            strCodeForCs.Append("\r\n" + "{");

                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += \" And \" + {2}.con_{0} + \" = '1'\";",
                                     objQryRegionFldsEx.FldName,
                                     objViewInfoENEx.TabName_Out,
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ));
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue({2}.con_{1}, true, \"=\");",
                                objViewInfoENEx.TabName_Out,
                                objQryRegionFldsEx.FldName,
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ));


                            strCodeForCs.Append("\r\n" + "}");

                            strCodeForCs.AppendFormat("\r\n" + "else");
                            strCodeForCs.Append("\r\n" + "{");

                            strCodeForCs.AppendFormat("\r\n" + "strWhereCond += \" And \" + {2}.con_{0} + \" = '0'\";",
                                 objQryRegionFldsEx.FldName,
                                     objViewInfoENEx.TabName_Out,
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ));
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue({2}.con_{1}, false, \"=\");",
                            objViewInfoENEx.TabName_Out,
                            objQryRegionFldsEx.FldName,
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ));

                            strCodeForCs.Append("\r\n" + "}");
                            break;
                        case "DropDownList": ///如果控件是下拉框;
                            if (objQryRegionFldsEx.ObjFieldTabENEx.CsType == "bool")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if ($(\"#{0}\").prop(\"selectedIndex\") == 1)",
                                objQryRegionFldsEx.CtrlId);
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);

                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += \" And \" + {2}.con_{0} + \" = '1'\"; ",
                                      objQryRegionFldsEx.FldName,
                                       objViewInfoENEx.TabName_Out,
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ));
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue({2}.con_{1}, true, \"=\");",
                                    objViewInfoENEx.TabName_Out,
                                    objQryRegionFldsEx.FldName,
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ));

                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.AppendFormat("\r\n" + "else if ($(\"#{0}\").prop(\"selectedIndex\") == 2)",
                                objQryRegionFldsEx.CtrlId);
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);

                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += \" And \" + {2}.con_{0} + \" = '0'\";",
                                       objQryRegionFldsEx.FldName,
                                     objViewInfoENEx.TabName_Out,
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ));
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue({2}.con_{1}, false, \"=\");",
                                    objViewInfoENEx.TabName_Out,
                                    objQryRegionFldsEx.FldName,
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ));

                                strCodeForCs.Append("\r\n" + "}");

                            }
                            else
                            {

                                if (objQryRegionFldsEx.ObjFieldTabENEx.IsNumberType())
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != 0)",
                                         objQryRegionFldsEx.PropertyName);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "if ( this.{0} != \"\" && this.{0} != \"0\")",
                                            objQryRegionFldsEx.PropertyName);
                                }
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);
                                switch (objQryRegionFldsEx.ObjFieldTabENEx.CsType)
                                {
                                    case "string":


                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += \" And \" + {3}.con_{0} + \" = '\" + this.{1} + \"'\";",
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName,
                                        objViewInfoENEx.TabName_Out,
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ));
                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue({3}.con_{1}, this.{2}, \"=\");",
                                    objViewInfoENEx.TabName_Out,
                                    objQryRegionFldsEx.FldName,
                                    objQryRegionFldsEx.PropertyName,
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ));


                                        break;
                                    case "int":


                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += \" And \" + {3}.con_{0} + \" = \" + this.{1} + \"\";",
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName,
                                        objViewInfoENEx.TabName_Out,
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ));
                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue({3}.con_{1}, this.{2}, \"=\");",
                                objViewInfoENEx.TabName_Out,
                                objQryRegionFldsEx.FldName,
                                objQryRegionFldsEx.PropertyName,
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ));
                                        break;
                                    default:


                                        strCodeForCs.AppendFormat("\r\n" + "strWhereCond += \" And \" + {3}.con_{0} + \" = '\" + this.{1} + \"'\";",
                                        objQryRegionFldsEx.FldName,
                                        objQryRegionFldsEx.PropertyName,
                                        objViewInfoENEx.TabName_Out,
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ));
                                        strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue({3}.con_{1}, this.{2}, \"=\");",
                                objViewInfoENEx.TabName_Out,
                                objQryRegionFldsEx.FldName,
                                objQryRegionFldsEx.PropertyName,
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ));
                                        break;
                                }
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            break;

                        case "TextBox": ///如果控件类型是文本框;

                            if (objQryRegionFldsEx.ObjFieldTabENEx.CsType != "string"
                                && objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02)
                            {
                                objQryRegionFldsEx.QueryOptionId = enumQueryOption.EqualQuery_01;
                            }
                            if ((objQryRegionFldsEx.QueryOptionId == enumQueryOption.Known_00) ||
                            (objQryRegionFldsEx.QueryOptionId == enumQueryOption.EqualQuery_01)) ///相等查询;
                            {
                                if (objQryRegionFldsEx.ObjFieldTabENEx.IsNumberType())
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != 0)",
                                        objQryRegionFldsEx.PropertyName);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != \"\")",
                        objQryRegionFldsEx.PropertyName);
                                }

                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);
                                if (objQryRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.IsNeedQuote == true)
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += \" And \" + {3}.con_{0} + \" = '\" + this.{1} + \"'\";",
                                objQryRegionFldsEx.FldName,
                                objQryRegionFldsEx.PropertyName,
                                objViewInfoENEx.TabName_Out,
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ));
                                    strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue({3}.con_{1}, this.{2}, \"=\");",
                                objViewInfoENEx.TabName_Out,
                                objQryRegionFldsEx.FldName,
                                objQryRegionFldsEx.PropertyName,
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ));
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "strWhereCond += \" And \" + {3}.con_{0} + \" = \" + this.{1} + \"\";",
                             objQryRegionFldsEx.FldName,
                             objQryRegionFldsEx.PropertyName,
                             objViewInfoENEx.TabName_Out,
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ));
                                    strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue({3}.con_{1}, this.{2}, \"=\");",
                                objViewInfoENEx.TabName_Out,
                                objQryRegionFldsEx.FldName,
                                objQryRegionFldsEx.PropertyName,
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ));
                                }
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.FuzzyQuery_02) ///模糊查询;
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if ( this.{0} != \"\")", objQryRegionFldsEx.PropertyName);
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += \" And \" + {3}.con_{0} + \" like '% \" + this.{1} + \"%'\";",
                                   objQryRegionFldsEx.FldName,
                                     objQryRegionFldsEx.PropertyName,
                                     objViewInfoENEx.TabName_Out,
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ));
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue({3}.con_{1}, this.{2}, \"like\");",
                                objViewInfoENEx.TabName_Out,
                                objQryRegionFldsEx.FldName,
                                objQryRegionFldsEx.PropertyName,
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ));

                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else if (objQryRegionFldsEx.QueryOptionId == enumQueryOption.RangeQuery_03)
                            { ///范围查询;
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != \"\")", objQryRegionFldsEx.PropertyName);
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += \" And \" + {3}.con_{0} + \" = '\" + this.{1} + \"'\", , );",
                                objQryRegionFldsEx.FldName,
                                objQryRegionFldsEx.PropertyName,
                                objViewInfoENEx.TabName_Out,
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ));
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue({3}.con_{1}, this.{2}, \"=\");",
                            objViewInfoENEx.TabName_Out,
                            objQryRegionFldsEx.FldName,
                            objQryRegionFldsEx.PropertyName,
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ));
                                strCodeForCs.Append("\r\n" + "}");
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "if (this.{0} != \"\")", objQryRegionFldsEx.PropertyName);
                                strCodeForCs.Append("\r\n" + "{");
                                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName_Out);
                                strCodeForCs.AppendFormat("\r\n" + "strWhereCond += \"And \" + {3}.con_{0} + \" = '\" + this.{1} + \"'\", , );",
                                     objQryRegionFldsEx.FldName,
                                      objQryRegionFldsEx.PropertyName,
                                      objViewInfoENEx.TabName_Out,
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ));
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}_Cond.SetCondFldValue({3}.con_{1}, this.{2}, \"=\");",
                            objViewInfoENEx.TabName_Out,
                            objQryRegionFldsEx.FldName,
                            objQryRegionFldsEx.PropertyName,
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ));
                                strCodeForCs.Append("\r\n" + "}");
                            }
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
                        case "CheckBoxList":
                            break;
                        case "DataGrid":
                            break;
                        case "DataList":
                            break;
                        case "Button":
                            break;
                    }
                }


                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch(objException)");
                strCodeForCs.Append("\r\n" + "{");
                string strErrId = clsErrorIdManageBLEx.GetMaxErrIdWithAddRecAndCheckDuplicate(objViewInfoENEx.CodeTypeId,
                  objViewInfoENEx.PrjId, objViewInfoENEx.WebFormName, "CombineTabNameConditionObj", "在组合查询条件对象(CombineTabNameConditionObj)时出错!请联系管理员!", "生成代码");
                AutoGCPubFuncV6.CheckTabNameIsNotNull(objViewInfoENEx.TabName);

                strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"(errid:{1})在组合查询条件对象(Combine{0}ConditionObj)时出错!请联系管理员!\" + objException.message + \"\";",
                   objViewInfoENEx.TabName, strErrId);
                strCodeForCs.Append("\r\n" + "throw strMsg;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.AppendFormat("\r\n" + "return obj{0}_Cond;", objViewInfoENEx.TabName_Out);
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
                            strCodeForCs.AppendFormat("\r\n" + "const {1} = $('#txt{1}{2}').val();",
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
                                    strCodeForCs.AppendFormat("\r\n" + "const {1} = Number($('#txt{1}{2}').val());",
                                        objDataTypeAbbrEN.TypeScriptType,
                                        objFuncPara4CodeEN.ParaName,
                                        objvFunction4GeneCodeEN.OrderNum);
                                    break;
                                case enumDataTypeAbbr.Array_31:
                                    strCodeForCs.AppendFormat("\r\n" + "const {1} = $('#txt{1}{2}').val();",
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
        public string Gen_WApi_Js_PutDataToClass(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {

                strCodeForCs.Append("\r\n /* 函数功能:把界面上的属性数据传到类对象中");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n  <param name = \"pobj{0}EN\">数据传输的目的类对象</param>",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "{1}.prototype.PutDataTo{0}Class = function(pobj{0}EN)",
                                objViewInfoENEx.TabName, objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    string strTemp = GetCode4FieldInPutDataToClass(objEditRegionFldsEx, objViewInfoENEx);
                    strCodeForCs.AppendFormat("{0}", strTemp);
                }
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
        private string GetCode4FieldInPutDataToClass(clsEditRegionFldsENEx objEditRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder sbCodeForCs = new StringBuilder();
            if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objEditRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }
            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "get",
                ControlType = objEditRegionFldsEx.CtlTypeName,
                CtrlId = objEditRegionFldsEx.CtrlId,
                PropertyName = objEditRegionFldsEx.PropertyName(),
                Comment = objEditRegionFldsEx.ObjFieldTabENEx.Caption,
                DataType = objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType
            });
            switch (objEditRegionFldsEx.CtlTypeId)
            {
                case enumCtlTypeAbbr.CheckBox_02:
                    sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = this.{1};",
     objViewInfoENEx.TabName,
     objEditRegionFldsEx.FldName,
     objEditRegionFldsEx.CtrlId);
                    break;
                default:
                    sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = this.{1};",
            objViewInfoENEx.TabName,
            objEditRegionFldsEx.FldName,
            objEditRegionFldsEx.CtrlId);
                    break;
            }
            sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

            return sbCodeForCs.ToString();
        }
        public string Gen_WApi_Js_GetDataFromClass(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
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
                strCodeForCs.AppendFormat("\r\n" + "{1}.prototype.GetDataFrom{0}Class = function(pobj{0}EN )",
                objViewInfoENEx.TabName, objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    string strTemp = GetCode4FieldInGetDataFromClass(objEditRegionFldsEx, objViewInfoENEx);
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
        private string GetCode4FieldInGetDataFromClass(clsEditRegionFldsENEx objEditRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {

            StringBuilder sbCodeForCs = new StringBuilder();


            if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objEditRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }
            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "set",
                ControlType = objEditRegionFldsEx.CtlTypeName,
                CtrlId = objEditRegionFldsEx.CtrlId,
                PropertyName = objEditRegionFldsEx.PropertyName(),
                Comment = objEditRegionFldsEx.ObjFieldTabENEx.Caption,
                DataType = objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType
            });
            switch (objEditRegionFldsEx.CtlTypeId)
            {
                case enumCtlTypeAbbr.CheckBox_02:
                    //7、设置checkbox为选中状态
                    //$('input:checkbox').attr("checked", 'checked');//or
                    //$('input:checkbox').attr("checked", true);
                    //8、设置checkbox为不选中状态
                    //$('input:checkbox').attr("checked", '');//or
                    //$('input:checkbox').attr("checked", false);
                    sbCodeForCs.AppendFormat("\r\n" + "this.{2} = pobj{1}EN.{2};",
                                objEditRegionFldsEx.CtrlId,
                                objViewInfoENEx.TabName,
                                objEditRegionFldsEx.FldName);
                    sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);
                    break;
                default:
                    sbCodeForCs.AppendFormat("\r\n" + " this.{2} = pobj{1}EN.{2};",
                                objEditRegionFldsEx.CtrlId,
                                objViewInfoENEx.TabName,
                                objEditRegionFldsEx.FldName);
                    sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);
                    break;
            }

            return sbCodeForCs.ToString();
        }
        public string Gen_WApi_Js_GetFirstKey()
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
                strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.GetFirstKey = function() {{", objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "if (arrSelectedKeys.length == 1) {");
                strCodeForCs.Append("\r\n" + "return arrSelectedKeys[0];");

                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "else {");

                strCodeForCs.Append("\r\n" + "alert(\"请选择一个关键字！目前选择了:\" + arrSelectedKeys.length + \"个关键字。\");");
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
        public string Gen_WApi_Js_SortBy()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /* 函数功能:从界面列表中根据某一个字段排序");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n  <param name = \"strSortByFld\">排序的字段</param>",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "*/");
                strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.SortBy = async function(strSortByFld) {{", objViewInfoENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n" + "if ({1}.sort{0}By.indexOf(strSortByFld) >= 0)", objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "if ({1}.sort{0}By.indexOf(\"Asc\") >= 0)", objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{1}.sort{0}By = \"\" + strSortByFld + \" Desc\";", objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{1}.sort{0}By = \"\" + strSortByFld + \" Asc\";", objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "else");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "{1}.sort{0}By = \"\" + strSortByFld + \" Asc\";", objViewInfoENEx.TabName_Out, objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "}");
                if (objViewInfoENEx.IsUseCache4List)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = this.BindGv_{0}_Cache();", objViewInfoENEx.TabName_Out);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = await this.BindGv_{0}();", objViewInfoENEx.TabName_Out);
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

        public string Gen_WApi_Js_IndexPage()
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
                strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.IndexPage = function(intPageIndex)", objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
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
                strCodeForCs.AppendFormat("\r\n" + "this.BindGv_{1}{2}();",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName_Out, objViewInfoENEx.IsUseCache4List ? "_Cache" : "");
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

            //			string strTemp ;     ///临时变量;
            ///判断DataGrid是否需要排序
            //foreach (clsDGRegionFldsENEx objDGRegionFldsEx in objViewInfoENEx.arrDGRegionFldSet)
            //{
            //    if (objDGRegionFldsEx.IsNeedSort)
            //    {
            //        objViewInfoENEx.objViewRegion_List.AllowSorting() = true;
            //    }
            //}
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

                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveDel == true)
                {
                    objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                    ASPHtmlButtonEx objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnDelete4Gv();
                    objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                    objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate == true)
                {

                    objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                    ASPHtmlButtonEx objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnUpdate4Gv();
                    objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                    objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveExeUpdate)
                {

                    objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                    ASPHtmlButtonEx objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnUpdate4Gv();
                    objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                    objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveDetail == true)
                {

                    objASPNETColENEx = clsASPColBLEx.GetEmptyTd();
                    //clsInpu
                    ASPHtmlButtonEx objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnDetail4Gv();
                    objASPNETColENEx.arrSubAspControlLst2.Add(objASPNETHtmlButtonENEx);
                    objASPNETRowENEx.arrSubAspControlLst2.Add(objASPNETColENEx);

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

        private string GenViewTitle(string strTitle, clsViewInfoENEx objViewInfoENEx)
        {
            if (string.IsNullOrEmpty(objViewInfoENEx.objViewStyleEN.TitleStyleId) == true)
            {
                StringBuilder sbMsg = new StringBuilder();
                sbMsg.AppendFormat("在界面:{0}中,没有设置标题类型,请检查!", objViewInfoENEx.ViewName);
                throw new Exception(sbMsg.ToString());
            }
            clsTitleStyleEN objTitleStyle = clsTitleStyleBL.GetObjByTitleStyleId_Cache(objViewInfoENEx.objViewStyleEN.TitleStyleId);
            if (objTitleStyle == null)
            {
                string strMsg = string.Format("(errid:BlEx000044)标题模式Id:[{0}]没有相应的对象，请检查!(AutoGC6Cs_VWeb_Net2005:GenViewTitle)", objViewInfoENEx.objViewStyleEN.TitleStyleId);
                throw new Exception(strMsg);
            }
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //			string strTemp;     ///临时变量;
            ///生成Label的代码;
            switch (objTitleStyle.TitleTypeId)
            {
                case "01":
                    strCodeForCs.AppendFormat("\r\n" + "<table id = \"tabTitle\" style = \"z-index: 102; left: 8px; position: absolute; top: 1px\" cellspacing = \"1\" ");
                    strCodeForCs.AppendFormat("\r\n" + "cellpadding = \"1\" width = \"100%\" bgColor = \"{0}\" border = \"0\">",
                      objTitleStyle.BackColor);
                    strCodeForCs.AppendFormat("\r\n" + "<tr>");
                    strCodeForCs.AppendFormat("\r\n" + "<td bgColor = \"{0}\">",
                      objTitleStyle.BackColor);
                    strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"lblViewTile\" runat = \"server\" Font-Size = \"Small\" Font-Names = \"宋体\" ForeColor = \"{1}\" Font-Bold = \"True\">{0}</asp:Label>",
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
                    //如果有查询区域
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

        /// <summary>
        /// 生成查询区域相关代码
        /// </summary>
        /// <returns></returns>
        public string GenQryRegionCode4Table()
        {
            StringBuilder strCodeForCs = new StringBuilder();  ///用来存放WebForm的代码;
            //用来定义正文的标签类型
            clsLabelStyleEN objLabelStyle_Text = clsLabelStyleBL.GetObjByLabelStyleId_Cache("0001");
            clsGenCtlStyleEN objGenCtlStyle = clsGenCtlStyleBL.GetObjByGenCtlStyleId_Cache("0001");
            clsCheckStyleEN objCheckStyle = clsCheckStyleBL.GetObjByCheckStyleId_Cache("0001");
            clsButtonStyleEN objButtonStyle = clsButtonStyleBL.GetObjByButtonStyleId_Cache("0001");
            float intDivHeight;
            int intQueryFldNum = 0;

            if (objViewInfoENEx.arrQryRegionFldSet == null)
            {
                StringBuilder sbMessage = new StringBuilder();
                string strViewName = objViewInfoENEx.ViewName;
                sbMessage.AppendFormat("当前所选界面名称:{0},在该界面中没有查询区域。请检查!", strViewName);
                throw new clsDbObjException(sbMessage.ToString());
            }
            objBiDimDistribue4Qry = new clsBiDimDistribute();

            objBiDimDistribue4Qry.ColNum = objViewInfoENEx.objViewRegion_Query.ColNum;
            objBiDimDistribue4Qry.ColWidth = 250;
            objBiDimDistribue4Qry.LineHeight = 30;
            float intDivWidth = objBiDimDistribue4Qry.GetCtlWidth();

            intQueryFldNum = objViewInfoENEx.arrQryRegionFldSet.Count;

            //			intDivHeight = intQueryFldNum * 28 +40;
            intDivHeight = objBiDimDistribue4Qry.GetCtlHeigh(intQueryFldNum) + 40;

            strCodeForCs.AppendFormat("\r\n" + "<div id = \"divQuery\" class = \"div_query\"> ",
              objViewInfoENEx.TabName, intDivHeight);
            strCodeForCs.AppendFormat("\r\n" + "<table class = \"msgtable\" style = \"width: 80%\"> ",
             objViewInfoENEx.TabName, intDivHeight);

            intCurrTop -= 30;//因为这是在层(div)中
            int intFieldNum = 0;
            objBiDimDistribue4Qry.StartX = (int)intCurrLeft;
            objBiDimDistribue4Qry.StartY = (int)intCurrTop;
            ///生成专门用于查询的界面控件的代码;
            ///
            bool bolIsTrEnd = true;
            foreach (clsQryRegionFldsENEx objQryRegionFldsEx in objViewInfoENEx.arrQryRegionFldSet)
            {
                if (intFieldNum % objViewInfoENEx.objViewRegion_Query.ColNum == 0)
                {
                    strCodeForCs.Append("\r\n" + "<tr>");
                    bolIsTrEnd = false;
                }

                switch (objQryRegionFldsEx.objCtlTypeAbbr.CtlTypeName)
                {
                    case "CheckBox":
                        strCodeForCs.Append("\r\n" + GenCheckBoxNoPosition(objCheckStyle, objQryRegionFldsEx.CtrlId, objQryRegionFldsEx.LabelCaption));
                        break;
                    default:
                        strCodeForCs.AppendFormat("\r\n" +
                          GenCombineCtlNoPosition(objLabelStyle_Text,
                          "lbl" + objQryRegionFldsEx.FldName + "_q",
                          objQryRegionFldsEx.LabelCaption,
                          objGenCtlStyle,
                          objQryRegionFldsEx.objCtlTypeAbbr.CtlTypeName,
                          objQryRegionFldsEx.CtrlId));
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
            ///生成查询按钮的代码;
            ///
            if (bolIsTrEnd == true)
            {
                strCodeForCs.Append("\r\n" + "<tr>");
                bolIsTrEnd = false;
            }
            strCodeForCs.Append("\r\n" + "<td>");
            ASPHtmlButtonEx objASPNETHtmlButtonENEx = clsASPHtmlButtonBLEx.GetbtnQuery();

            objASPNETHtmlButtonENEx.GeneCode((enumApplicationType)objViewInfoENEx.ApplicationTypeId, strCodeForCs); //;, "btnQuery", "查询", "btnQuery_Click"));
            strCodeForCs.Append("\r\n" + "</td>");

            strCodeForCs.Append("\r\n" + "</tr>");
            strCodeForCs.Append("\r\n" + "</table>");
            strCodeForCs.Append("\r\n" + "</div>");

            intCurrTop += 40;
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
        public string Gen_WApi_Js_DefDiv4EditRegion()
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

            foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
            {
                ///如果该字段不是标识递增型就生成控件,否则就不生成;
                if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objEditRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                {
                    continue;
                }
                strCodeForCs.AppendFormat("\r\n" + "<tr>");
                //strCodeForCs.AppendFormat("\r\n" + "<td>");
                ///插入验证控件代码;
                switch (objEditRegionFldsEx.ObjFieldTabENEx.CsType)
                {
                    case "bool":
                        strCodeForCs.AppendFormat("\r\n" + "<td colspan='2'>");
                        strCodeForCs.AppendFormat("\r\n" + "<asp:CheckBox id = \"chk{0}\" runat = \"server\" Text = \"{1}\" CssClass = \"Check_Defa\"></asp:CheckBox>",
                          objEditRegionFldsEx.FldName,
                          objEditRegionFldsEx.LabelCaption);
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
                          "lbl" + objEditRegionFldsEx.FldName,
                          objEditRegionFldsEx.LabelCaption);
                        strCodeForCs.AppendFormat("\r\n" + "</td>");
                        strCodeForCs.AppendFormat("\r\n" + "<td class = \"ValueTD\">");
                        strCodeForCs.AppendFormat("\r\n" + "<asp:TextBox id = \"txt{0}\" runat = \"server\" CssClass = \"ValueControl\"></asp:TextBox>",
                          objEditRegionFldsEx.FldName,
                          objEditRegionFldsEx.LabelCaption);
                        strCodeForCs.AppendFormat("\r\n" + "</td>");
                        break;
                    default:
                        strCodeForCs.AppendFormat("\r\n" + "<td class = \"NameTD\">");
                        strCodeForCs.AppendFormat("\r\n" + "<asp:Label id = \"{0}\" runat = \"server\" CssClass = \"NameControl\">{1}</asp:Label>",
                          "lbl" + objEditRegionFldsEx.FldName,
                          objEditRegionFldsEx.LabelCaption);
                        strCodeForCs.AppendFormat("\r\n" + "</td>");
                        strCodeForCs.AppendFormat("\r\n" + "<td class = \"ValueTD\">");
                        strCodeForCs.AppendFormat("\r\n" + "<asp:{0} id = \"{1}\" runat = \"server\" CssClass = \"ValueControl\"></asp:{0}>",
                          objEditRegionFldsEx.objCtlTypeAbbr.CtlTypeName,
                            objEditRegionFldsEx.CtrlId,
                          objEditRegionFldsEx.LabelCaption);
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

        public string Gen_WApi_Js_ShowData()
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

                    strCodeForCs.AppendFormat("\r\n" + "{2}.prototype.ShowData = async function({0}) {{",
                        objKeyField.PrivFuncName, objKeyField.TypeScriptType, objViewInfoENEx.ClsName);
                    strCodeForCs.Append("\r\n" + "        //操作步骤:");
                    strCodeForCs.Append("\r\n" + "        //1、检查关键字是否为空；");
                    strCodeForCs.Append("\r\n" + "        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；");
                    strCodeForCs.Append("\r\n" + "        //3、用提供的关键字初始化一个类对象；");
                    strCodeForCs.Append("\r\n" + "        //4、获取类对象的所有属性；");
                    strCodeForCs.Append("\r\n" + "        //5、把该对象的所有属性显示在界面上,在这里显示在表控件中");
                    strCodeForCs.Append("\r\n" + "        //2、检查该关键字的记录是否存在,如果不存在就返回不显示；");

                    strCodeForCs.Append("\r\n" + "        try {");
                    strCodeForCs.AppendFormat("\r\n" + "            const returnBool = await {2}.IsExist({1});",
                        objViewInfoENEx.TabName_In, objKeyField.PrivFuncName,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName), this.Is4RJ));

                    strCodeForCs.Append("\r\n" + "            if (returnBool == false) {");
                    strCodeForCs.AppendFormat("\r\n" + "                var strInfo = \"关键字:[\" + {0} + \"] 的记录不存在!\";",
                         objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + "                //$('#lblResult1').val(strInfo);");
                    strCodeForCs.Append("\r\n" + "                //显示信息框");
                    strCodeForCs.Append("\r\n" + "                alert(strInfo);");
                    strCodeForCs.Append("\r\n" + "            }");
                    strCodeForCs.Append("\r\n" + "            else {");

                    strCodeForCs.Append("\r\n" + "            }");
                    strCodeForCs.Append("\r\n" + "        }");
                    strCodeForCs.Append("\r\n" + "        catch (e) {");
                    strCodeForCs.Append("\r\n" + "            const strMsg = \"检查相应关键字的记录存在不成功, \" + e+ \".\";");
                    strCodeForCs.Append("\r\n" + "            alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "        }");
                    strCodeForCs.Append("\r\n" + "        try {");
                    strCodeForCs.AppendFormat("\r\n" + "            const obj{0}EN = await {3}.GetObjBy{1}({2});",
                        objViewInfoENEx.TabName_In,
                        objKeyField.FldName,
                        objKeyField.PrivFuncName,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName), this.Is4RJ));

                    strCodeForCs.Append("\r\n" + "        }");
                    strCodeForCs.Append("\r\n" + "        catch (e) {");
                    strCodeForCs.Append("\r\n" + "            const strMsg = \"根据关键字获取相应的记录的对象不成功,\" + e+ \".\";");
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
            return A_GeneFuncCodeBase(objvFunction4GeneCodeEN, typeof(WA_ViewScriptCS_JS4JavaScript));

        }
        public override void GetClsName()
        {
            //if (objViewInfoENEx.IsUseCache4List)
            //{
            //    this.ClsName = string.Format("WA_{0}_QUDI_Cache", objViewInfoENEx.TabName);
            //    objViewInfoENEx.ClsName = this.ClsName;
            //}
            //else
            //{
            //    this.ClsName = string.Format("WA_{0}_QUDI_JS", objViewInfoENEx.TabName);
            //    objViewInfoENEx.ClsName = this.ClsName;
            //}
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
                string strMsg = string.Format("在生成函数:[{0}]时出错。错误信息:{1}.({2})", strFuncName,
                    objException.Message,
                    clsStackTrace.GetCurrClassFunction());
                clsSysParaEN_Local.objLog4GCError.WriteDebugLog(strMsg);
                throw new Exception(strMsg);
            }
            return strCodeForCs.ToString();
        }
        public string Gen_WApi_Js_btnCopyRecord_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n  添加新记录");
            strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.btnCopyRecord_Click = async function() {{", objViewInfoENEx.ClsName);
            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);


            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const arrKeyIds = {0}.GetCheckedKeyIds();",
                                      ImportClass.GetOutString(string.Format("clsCommFunc4Web", objViewInfoENEx.TabName), this.Is4RJ));
            strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"请选择需要克隆的记录！\");");
            strCodeForCs.Append("\r\n" + "return \"\";");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "const responseText = await this.CopyRecord(arrKeyIds);");
            if (objViewInfoENEx.IsUseCache4List)
            {
                strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = this.BindGv_{0}_Cache();", objViewInfoENEx.TabName_Out);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = await this.BindGv_{0}();", objViewInfoENEx.TabName_Out);
            }
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = \"复制记录不成功,\" + e+ \".\";");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }

        public string Gen_WApi_Js_btnSetFldValue_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFldsObjLst = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.FeatureId == "0148");
                foreach (clsFeatureRegionFldsENEx objInFor in arrFeatureRegionFldsObjLst)
                {
                    clsFieldTabEN objFieldTabEN = clsFieldTabBL.GetObjByFldId_Cache(objInFor.ReleFldId, objInFor.PrjId);

                    string strFuncName = string.Format("{0}", objInFor.ButtonName.Substring(3));
                    strCodeForCs.AppendFormat("\r\n /* 设置字段值-{0}", objFieldTabEN.FldName);
                    strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n **/");

                    strCodeForCs.AppendFormat("\r\n" + "{1}.prototype.{0}_Click = async function() {{", objInFor.ButtonName, objViewInfoENEx.ClsName);
                    //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);


                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "const arrKeyIds = {0}.GetCheckedKeyIds();",
                                      ImportClass.GetOutString(string.Format("clsCommFunc4Web", objViewInfoENEx.TabName), this.Is4RJ));
                    strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "alert(\"请选择需要克隆的记录！\");");
                    strCodeForCs.Append("\r\n" + "return \"\";");
                    strCodeForCs.Append("\r\n" + "}");

                    clsvViewFeatureFldsENEx objViewFeatureFlds = null;
                    if (objInFor.ValueGivingModeId == enumValueGivingMode.GivenValue_02)
                    {
                        List<clsvViewFeatureFldsENEx> arrViewFeatureFlds = objViewInfoENEx.arrvViewFeatureFlds.Where(x =>
                               x.ViewFeatureId == objInFor.ViewFeatureId).ToList();
                        if (arrViewFeatureFlds.Count == 0)
                        {
                            throw new Exception("功能：设置字段值的给值方式是给定值，但缺少相应的界面功能字段，请维护后再生成代码");
                        }
                        objViewFeatureFlds = arrViewFeatureFlds[0];

                    }
                    if (objInFor.FeatureId == enumPrjFeature.SetFieldValue_0148
        && objInFor.ValueGivingModeId == enumValueGivingMode.GivenValue_02)
                    {
                        List<clsvViewFeatureFldsENEx> arrViewFeatureFlds = objViewInfoENEx.arrvViewFeatureFlds.Where(x =>
                        x.ViewFeatureId == objInFor.ViewFeatureId).ToList();
                        if (arrViewFeatureFlds.Count == 0)
                        {
                            throw new Exception("功能：设置字段值的给值方式是给定值，但缺少相应的界面功能字段，请维护后再生成代码");
                        }

                        objViewFeatureFlds = arrViewFeatureFlds[0];
                        ASPControlEx objASPControlENEx = clsASPControlBLEx.GetControl_Asp(objViewFeatureFlds);

                        string strCtrlId = objASPControlENEx.CtrlId.Replace("SetFldValue_SetFldValue", "SetFldValue");
                        switch (objViewFeatureFlds.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType)
                        {
                            case "Number":
                                strCodeForCs.AppendFormat("\r\n" + "let str{0} = $(\"#{1}\").val();",
                  objViewFeatureFlds.ObjFieldTabENEx.FldName,
                  strCtrlId);

                                strCodeForCs.AppendFormat("\r\n" + "if (str{0} == \"\")",
                                            objViewFeatureFlds.ObjFieldTabENEx.FldName);

                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"请输入{0}({1})!\";",
                                    objViewFeatureFlds.ObjFieldTabENEx.Caption,
                                    objViewFeatureFlds.ObjFieldTabENEx.FldName);
                                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                                strCodeForCs.Append("\r\n" + "return;");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.AppendFormat("\r\n" + "console.log('str{0}=' + str{0});", objViewFeatureFlds.ObjFieldTabENEx.FldName);

                                strCodeForCs.AppendFormat("\r\n" + "let {0} = Number(str{1});",
                                    objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName,
                                    objViewFeatureFlds.ObjFieldTabENEx.FldName); break;
                            case "boolean":
                                strCodeForCs.AppendFormat("\r\n" + "let {0} = $(\"#{1}\").prop(\"checked\");",
                  objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName,
                  strCtrlId);

                                strCodeForCs.AppendFormat("\r\n" + "console.log('{0}=' + {0});", objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);

                                break;
                            default:
                                strCodeForCs.AppendFormat("\r\n" + "let str{0} = $(\"#{1}\").val();",
                  objViewFeatureFlds.ObjFieldTabENEx.FldName,
                  strCtrlId);

                                strCodeForCs.AppendFormat("\r\n" + "if (str{0} == \"\")",
                                            objViewFeatureFlds.ObjFieldTabENEx.FldName);

                                strCodeForCs.Append("\r\n" + "{");
                                strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"请输入{0}({1})!\";",
                                    objViewFeatureFlds.ObjFieldTabENEx.Caption,
                                    objViewFeatureFlds.ObjFieldTabENEx.FldName);
                                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                                strCodeForCs.Append("\r\n" + "return;");
                                strCodeForCs.Append("\r\n" + "}");
                                strCodeForCs.AppendFormat("\r\n" + "console.log('str{0}=' + str{0});", objViewFeatureFlds.ObjFieldTabENEx.FldName);
                                break;
                        }
                        strCodeForCs.Append("\r\n" + "console.log('arrKeyIds=');");
                        strCodeForCs.Append("\r\n" + "console.log(arrKeyIds);");

                        strCodeForCs.AppendFormat("\r\n" + "const responseText = await this.{0}(arrKeyIds, {1});", strFuncName, objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);
                    }
                    else
                    {
                        strCodeForCs.Append("\r\n" + "console.log('arrKeyIds=');");
                        strCodeForCs.Append("\r\n" + "console.log(arrKeyIds);");
                        strCodeForCs.AppendFormat("\r\n" + "const responseText = await this.{0}(arrKeyIds);", strFuncName);
                    }
                    if (objViewInfoENEx.IsUseCache4List)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = this.BindGv_{0}_Cache();", objViewInfoENEx.TabName_Out);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = await this.BindGv_{0}();", objViewInfoENEx.TabName_Out);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch(e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"设置记录不成功,\" + e + \".(In {0}_Click())\";",
                        objInFor.ButtonName);
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



        public string Gen_WApi_Js_SetFieldValue()
        {
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {
                IEnumerable<clsFeatureRegionFldsENEx> arrFeatureRegionFldsObjLst = objViewInfoENEx.arrFeatureRegionFlds.Where(x => x.FeatureId == "0148");
                foreach (clsFeatureRegionFldsENEx objInFor in arrFeatureRegionFldsObjLst)
                {

                    clsFieldTabEN objFieldTabEN = clsFieldTabBL.GetObjByFldId_Cache(objInFor.ReleFldId, objInFor.PrjId);
                    string strFuncName = string.Format("{0}", objInFor.ButtonName.Substring(3));

                    strCodeForCs.AppendFormat("\r\n /* 设置字段值-{0}", objFieldTabEN.FldName);
                    strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
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


                    clsvViewFeatureFldsENEx objViewFeatureFlds = null;


                    if (objInFor.ValueGivingModeId == enumValueGivingMode.GivenValue_02)
                    {
                        List<clsvViewFeatureFldsENEx> arrViewFeatureFlds = objViewInfoENEx.arrvViewFeatureFlds.Where(x =>
                               x.ViewFeatureId == objInFor.ViewFeatureId).ToList();
                        if (arrViewFeatureFlds.Count == 0)
                        {
                            throw new Exception("功能：设置字段值的给值方式是给定值，但缺少相应的界面功能字段，请维护后再生成代码");
                        }
                        objViewFeatureFlds = arrViewFeatureFlds[0];

                        strCodeForCs.AppendFormat("\r\n" + "{4}.prototype.{0} = async function(arr{1}, {3})",
                                strFuncName,
                                objKeyField.FldName,
                                objViewFeatureFlds.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
                                objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName,
                                objViewInfoENEx.ClsName);
                        strCodeForCs.Append("\r\n" + "{");
                        //ASPDropDownListEx objASPDropDownListENEx = clsASPDropDownListBLEx.GetDropDownLst_Asp(objViewFeatureFlds);
                        if (objViewFeatureFlds.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType != "boolean")
                        {
                            strCodeForCs.AppendFormat("\r\n" + "if ({0} == null || {0} == \"\" )",
                                        objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);

                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"请输入{0}({1})!\";",
                                objViewFeatureFlds.ObjFieldTabENEx.Caption,
                                objViewFeatureFlds.ObjFieldTabENEx.FldName);
                            strCodeForCs.Append("\r\n" + "alert(strMsg);");
                            strCodeForCs.Append("\r\n" + "return \"\";");
                            strCodeForCs.Append("\r\n" + "}");
                        }
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "{2}.prototype.{0} = async function(arr{1})",
                                strFuncName, objKeyField.FldName, objViewInfoENEx.ClsName);
                        strCodeForCs.Append("\r\n" + "{");
                    }

                    strCodeForCs.AppendFormat("\r\n" + "if (arr{0}.length == 0)", objKeyField.FldName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "let strMsg = \"没有选择记录，不能设置字段值!\";");
                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "return \"\";");
                    strCodeForCs.Append("\r\n" + "}");

                    //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");

                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.AppendFormat("\r\n" + "const responseText = await {2}.GetObjLstBy{1}Lst(arr{1});",
objViewInfoENEx.TabName_In, objKeyField.FldName,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName), this.Is4RJ));
                    strCodeForCs.Append("\r\n" + "console.log('responseText=');");
                    strCodeForCs.Append("\r\n" + "console.log(responseText);");
                    strCodeForCs.Append("\r\n" + "const intCount = 0;");
                    strCodeForCs.AppendFormat("\r\n" + "const arr{0}ObjLst =  responseText;",
                        objViewInfoENEx.TabName_In);
                    strCodeForCs.AppendFormat("\r\n" + "for (const objInFor of arr{0}ObjLst)",
                        objViewInfoENEx.TabName_In);
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.AppendFormat("\r\n" + "let obj{0}EN = new {1}();", objViewInfoENEx.TabName_In,
                                      ImportClass.GetOutString(string.Format("cls{0}EN", objViewInfoENEx.TabName), this.Is4RJ));
                    strCodeForCs.AppendFormat("\r\n" + "{1}.CopyObjTo(objInFor, obj{0}EN);", objViewInfoENEx.TabName_In,
                                      ImportClass.GetOutString(string.Format("cls{0}BL", objViewInfoENEx.TabName), this.Is4RJ));


                    if (objInFor.ValueGivingModeId == enumValueGivingMode.GivenValue_02)
                    {
                        if (objViewFeatureFlds == null)
                        {
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = \"这里不正确，值为空！\";",
                                                      objViewInfoENEx.TabName_In, objFieldTabEN.FldName);
                        }
                        else
                        {
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                                                      objViewInfoENEx.TabName_In, objFieldTabEN.FldName,
                                                      objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);
                        }
                    }
                    else
                    {

                        clsDataTypeAbbrEN objDataTypeAbbrEN = clsDataTypeAbbrBL.GetObjByDataTypeId_Cache(objFieldTabEN.DataTypeId);
                        if (clsDataTypeAbbrBLEx.IsNumberType(objDataTypeAbbrEN) == true)
                        {
                            //strCodeForCs.Append("\r\n" + "objInFor.ExamTypeName = \"C_\" + objInFor.ExamTypeName;");
                            strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = {2};",
                                  objViewInfoENEx.TabName_In, objFieldTabEN.FldName, objViewFeatureFlds.ObjFieldTabENEx.PrivFuncName);
                        }
                        else
                        {
                            if (objDataTypeAbbrEN.CsType == "bool")
                            {
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} = TransToBool(\"{2}\");",
                                                        objViewInfoENEx.TabName_In, objFieldTabEN.FldName, objInFor.DefaultValue);
                            }
                            else
                            {
                                strCodeForCs.AppendFormat("\r\n" + "obj{0}EN.{1} =\"{2}\";",
                                    objViewInfoENEx.TabName_In, objFieldTabEN.FldName, objInFor.DefaultValue);
                            }
                        }
                    }
                    strCodeForCs.Append("\r\n" + "const returnBool = false;");
                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "    obj{0}EN.sf_UpdFldSetStr = obj{0}EN.updFldString;//设置哪些字段被修改(脏字段)", objViewInfoENEx.TabName_In);

                    strCodeForCs.AppendFormat("\r\n" + "const responseUpdate = await {1}.UpdateRecord(obj{0}EN);", objViewInfoENEx.TabName_In,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName), this.Is4RJ));
                    strCodeForCs.Append("\r\n" + "console.log('responseUpdate=');");
                    strCodeForCs.Append("\r\n" + "console.log(responseUpdate);");
                    strCodeForCs.Append("\r\n" + "returnBool = !!responseUpdate;");

                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "let strMsg = \"修改记录出错。\" + e + \". (In {0}())\";", strFuncName);

                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "throw (strMsg);");
                    strCodeForCs.Append("\r\n" + "}");


                    strCodeForCs.Append("\r\n" + "if (returnBool == true)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "const strInfo = \"设置记录成功!\";");
                    strCodeForCs.Append("\r\n" + "intCount++;");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "else");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "const strInfo = \"设置记录不成功!\";");
                    //strCodeForCs.Append("\r\n" + "$('#lblResult20').val(strInfo);");
                    strCodeForCs.Append("\r\n" + "//显示信息框");
                    strCodeForCs.Append("\r\n" + "alert(strInfo);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "const strInfo = \"共设置了\" + intCount + \"条记录!\";");
                    //strCodeForCs.Append("\r\n" + "$('#lblResult20').val(strInfo);
                    strCodeForCs.Append("\r\n" + "alert(strInfo);");
                    strCodeForCs.Append("\r\n" + "console.log('完成！');");
                    if (objViewInfoENEx.IsUseCache4List == true)
                    {
                        if (objViewInfoENEx.objCacheClassifyFld4View == null)
                        {
                            strCodeForCs.Append("\r\n" + "if (intCount > 0)");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "{1}.ReFreshCache();", objViewInfoENEx.TabName,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName), this.Is4RJ));
                            strCodeForCs.Append("\r\n" + "}");
                        }
                        else
                        {
                            strCodeForCs.Append("\r\n" + "if (intCount > 0)");
                            strCodeForCs.Append("\r\n" + "{");
                            strCodeForCs.AppendFormat("\r\n" + "{3}.ReFreshCache({2}.{1}_Cache);", objViewInfoENEx.TabName,
                                 objViewInfoENEx.objCacheClassifyFld4View.FldName, objViewInfoENEx.ClsName,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName), this.Is4RJ));
                            strCodeForCs.Append("\r\n" + "}");
                        }
                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch (e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"设置记录不成功,\" + e+ \".(In {0}())\";", strFuncName);
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


        public string Gen_WApi_Js_btnGoTop_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);
                if (objAdjustOrderNum == null) return "";
                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";

                strCodeForCs.Append("\r\n /* 置顶");
                strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");
                strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.btnGoTop_Click = async function()", objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (this.PreCheck4Order() == false) return;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    foreach (clsvViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + " var str{0} =this.{1};",
objInFor.FldName, objInFor.CtrlId.Substring(3));

                        arrPropertyDef4GC.Add(new clsPropertyDef4GC
                        {
                            OperateType = "get",
                            ControlType = objInFor.CtlTypeName,
                            CtrlId = objInFor.CtrlId,
                            PropertyName = objInFor.CtrlId.Substring(3),
                            Comment = objInFor.FldName,
                            DataType = "string"
                        });
                    }
                }
                strCodeForCs.AppendFormat("\r\n" + "const arrKeyIds = {0}.GetCheckedKeyIds();",
                                      ImportClass.GetOutString(string.Format("clsCommFunc4Web", objViewInfoENEx.TabName), this.Is4RJ));
                strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(\"请选择需要置顶的记录！\");");
                strCodeForCs.Append("\r\n" + "return \"\";");
                strCodeForCs.Append("\r\n" + "}");

                //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const objOrderByData = new clsOrderByData();");
                strCodeForCs.Append("\r\n" + "objOrderByData.KeyIdLst = arrKeyIds;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const jsonObject =");
                    strCodeForCs.Append("\r\n" + "{");

                    foreach (clsvViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "\"{0}\": {1},",
                           objInFor.FldName,
                           objInFor.PrivFuncName);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "const jsonStr = JSON.stringify(jsonObject);");
                    strCodeForCs.Append("\r\n" + "objOrderByData.ClassificationFieldValueLst = jsonStr;");
                    strCodeForCs.AppendFormat("\r\n" + "const responseRederBy = await {3}.GoTop(objOrderByData);",
                     objViewInfoENEx.TabName,
                     objKeyField.PrivFuncListName,
                                          objAdjustOrderNum.VarLst,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName), this.Is4RJ));
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseRederBy = await {2}.GoTop(objOrderByData);",
                     objViewInfoENEx.TabName,
                     objKeyField.PrivFuncListName,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName), this.Is4RJ));
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = \"置顶出错。错误:\" + e.Message + \".(In \" + clsStackTrace.GetCurrClassFunction() + \")\";");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                if (objViewInfoENEx.IsUseCache4List)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = this.BindGv_{0}_Cache();", objViewInfoENEx.TabName_Out);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = await this.BindGv_{0}();", objViewInfoENEx.TabName_Out);
                }
                //strCodeForCs.AppendFormat("\r\n" + "foreach({0} {1} in lst{2})",
                //    objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.ObjFieldTabENEx.PrivFuncName,
                //    objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                //strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strListDiv = this.divName4DataList;");

                strCodeForCs.Append("\r\n" + "const strListDiv = this.divName4DataList;");
                strCodeForCs.AppendFormat("\r\n" + "arrKeyIds.forEach((e) => {0}.SetCheckedItem4KeyId(strListDiv, e));",
                                      ImportClass.GetOutString(string.Format("clsCommFunc4Web", objViewInfoENEx.TabName), this.Is4RJ));
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

        public string Gen_WApi_Js_btnUpMove_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);
                if (objAdjustOrderNum == null) return "";
                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";


                strCodeForCs.Append("\r\n /**");
                strCodeForCs.AppendFormat("\r\n 上移");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");
                strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.btnUpMove_Click = async function()", objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (this.PreCheck4Order() == false) return;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    foreach (clsvViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {

                        strCodeForCs.AppendFormat("\r\n" + " var str{0} =this.{1};",
          objInFor.FldName, objInFor.CtrlId.Substring(3));

                        arrPropertyDef4GC.Add(new clsPropertyDef4GC
                        {
                            OperateType = "get",
                            ControlType = objInFor.CtlTypeName,
                            CtrlId = objInFor.CtrlId,
                            PropertyName = objInFor.CtrlId.Substring(3),
                            Comment = objInFor.FldName,
                            DataType = "string"
                        });
                    }
                }
                strCodeForCs.AppendFormat("\r\n" + "const arrKeyIds = {0}.GetCheckedKeyIds();",
                                      ImportClass.GetOutString(string.Format("clsCommFunc4Web", objViewInfoENEx.TabName), this.Is4RJ));
                strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(\"请选择需要上移的记录!\");");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");


                //                strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const objOrderByData = new clsOrderByData();");
                strCodeForCs.Append("\r\n" + "objOrderByData.KeyIdLst = arrKeyIds;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const jsonObject =");
                    strCodeForCs.Append("\r\n" + "{");

                    foreach (clsvViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "\"{0}\": {1},",
                            objInFor.FldName,
                            objInFor.PrivFuncName);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "const jsonStr = JSON.stringify(jsonObject);");
                    strCodeForCs.Append("\r\n" + "objOrderByData.ClassificationFieldValueLst = jsonStr;");
                    strCodeForCs.AppendFormat("\r\n" + "const responseRederBy = await {3}.UpMove(objOrderByData);",
                     objViewInfoENEx.TabName,
                     objAdjustOrderNum.VarLst,
                     objKeyField.PrivFuncName,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName), this.Is4RJ));
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseRederBy = await {2}.UpMove(objOrderByData);",
                     objViewInfoENEx.TabName,
                                          objKeyField.PrivFuncName,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName), this.Is4RJ));
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = \"上移记录出错。错误:\" + e.Message + \".(In \" + clsStackTrace.GetCurrClassFunction() + \")\";");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                if (objViewInfoENEx.IsUseCache4List)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = this.BindGv_{0}_Cache();", objViewInfoENEx.TabName_Out);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = await this.BindGv_{0}();", objViewInfoENEx.TabName_Out);
                }
                strCodeForCs.Append("\r\n" + "const strListDiv = this.divName4DataList;");
                strCodeForCs.AppendFormat("\r\n" + "arrKeyIds.forEach((e) => {0}.SetCheckedItem4KeyId(strListDiv, e));",
                                      ImportClass.GetOutString(string.Format("clsCommFunc4Web", objViewInfoENEx.TabName), this.Is4RJ));
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

        public string Gen_WApi_Js_MoveRecord()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);
                if (objAdjustOrderNum == null) return "";
                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";



                strCodeForCs.Append("\r\n /**");
                strCodeForCs.AppendFormat("\r\n 移动记录，包括上移和下移");
                strCodeForCs.AppendFormat("\r\n ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");
                strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.MoveRecord = async function(strDirect)", objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (this.PreCheck4Order() == false) return;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    foreach (clsvViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + " var str{0} =$('#{1}').val();",
                            objInFor.FldName, objInFor.CtrlId);
                    }
                }
                strCodeForCs.AppendFormat("\r\n" + "const strKeyId = {0}.GetFirstCheckedKeyId();",
                                      ImportClass.GetOutString(string.Format("clsCommFunc4Web", objViewInfoENEx.TabName), this.Is4RJ));
                strCodeForCs.Append("\r\n" + "    if (strKeyId == \"\")");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(\"请选择需要移动(\" + strDirect + \")的记录!\");");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");


                //                strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseRederBy = await {3}.AdjustOrderNum(strDirect, {2}, strKeyId);",
                     objViewInfoENEx.TabName,
                     objAdjustOrderNum.VarLst,
                     objKeyField.PrivFuncName,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName), this.Is4RJ));
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseRederBy = await {2}.AdjustOrderNum(strDirect, strKeyId);",
                     objViewInfoENEx.TabName,
                                          objKeyField.PrivFuncName,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName), this.Is4RJ));
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = \"移动(\" + strDirect + \")记录出错。错误:\" + e.Message + \".(In \" + clsStackTrace.GetCurrClassFunction() + \")\";");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                if (objViewInfoENEx.IsUseCache4List)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = this.BindGv_{0}_Cache();", objViewInfoENEx.TabName_Out);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = await this.BindGv_{0}();", objViewInfoENEx.TabName_Out);
                }
                strCodeForCs.AppendFormat("\r\n" + "//{0}1.SetCheckedItemForGv({1});",
                    this.GetClsNameByRegionTypeId(enumRegionType.ListRegion_0002), objKeyField.PrivFuncName);

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

        public string Gen_WApi_Js_btnDownMove_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);
                if (objAdjustOrderNum == null) return "";
                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";

                strCodeForCs.Append("\r\n /**");
                strCodeForCs.AppendFormat("\r\n 下移");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");
                strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.btnDownMove_Click = async function()", objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (this.PreCheck4Order() == false) return;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    foreach (clsvViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {

                        strCodeForCs.AppendFormat("\r\n" + " var str{0} =this.{1};",
                      objInFor.FldName, objInFor.CtrlId.Substring(3));

                        arrPropertyDef4GC.Add(new clsPropertyDef4GC
                        {
                            OperateType = "get",
                            ControlType = objInFor.CtlTypeName,
                            CtrlId = objInFor.CtrlId,
                            PropertyName = objInFor.CtrlId.Substring(3),
                            Comment = objInFor.FldName,
                            DataType = "string"
                        });
                    }
                }
                strCodeForCs.AppendFormat("\r\n" + "const arrKeyIds = {0}.GetCheckedKeyIds();",
                                      ImportClass.GetOutString(string.Format("clsCommFunc4Web", objViewInfoENEx.TabName), this.Is4RJ));
                strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(\"请选择需要下移的记录!\");");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");


                //                strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const objOrderByData = new clsOrderByData();");
                strCodeForCs.Append("\r\n" + "objOrderByData.KeyIdLst = arrKeyIds;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const jsonObject =");
                    strCodeForCs.Append("\r\n" + "{");

                    foreach (clsvViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "\"{0}\": {1},",
                            objInFor.FldName,
                            objInFor.PrivFuncName);

                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "const jsonStr = JSON.stringify(jsonObject);");
                    strCodeForCs.Append("\r\n" + "objOrderByData.ClassificationFieldValueLst = jsonStr;");
                    strCodeForCs.AppendFormat("\r\n" + "const responseRederBy = await {3}.DownMove(objOrderByData);",
                     objViewInfoENEx.TabName,
                     objAdjustOrderNum.VarLst,
                     objKeyField.PrivFuncName,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName), this.Is4RJ));
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseRederBy = await {2}.DownMove(objOrderByData);",
                     objViewInfoENEx.TabName,
                                          objKeyField.PrivFuncName,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName), this.Is4RJ));
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = \"下移记录出错。错误:\" + e.Message + \".(In \" + clsStackTrace.GetCurrClassFunction() + \")\";");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = strMsg;");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                if (objViewInfoENEx.IsUseCache4List)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = this.BindGv_{0}_Cache();", objViewInfoENEx.TabName_Out);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = await this.BindGv_{0}();", objViewInfoENEx.TabName_Out);
                }
                strCodeForCs.Append("\r\n" + "const strListDiv = this.divName4DataList;");
                strCodeForCs.AppendFormat("\r\n" + "arrKeyIds.forEach((e) => {0}.SetCheckedItem4KeyId(strListDiv, e));",
                                      ImportClass.GetOutString(string.Format("clsCommFunc4Web", objViewInfoENEx.TabName), this.Is4RJ));

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

        public string Gen_WApi_Js_PreCheck4Order()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsFeatureRegionFldsENEx objFeatureRegionFlds_GoTop = objViewInfoENEx.arrFeatureRegionFlds.Find(x => x.FeatureId == enumPrjFeature.AdjustOrderNum_1196);
                if (objFeatureRegionFlds_GoTop == null) return "";
                //clsViewFeatureFldsENEx objField_OrderNum = objViewInfoENEx.arrViewFeatureFlds.Find(x => x.FieldTypeId == enumFieldType.OrderNumField_09 && x.ViewFeatureId == objFeatureRegionFlds_GoTop.ViewFeatureId);
                IEnumerable<clsvViewFeatureFldsENEx> arrFieldLst_Classify = objViewInfoENEx.arrvViewFeatureFlds.Where(x => x.FieldTypeId == enumFieldType.ClassificationField_10 && x.ViewFeatureId == objFeatureRegionFlds_GoTop.ViewFeatureId);

                List<clsPrjTabFldENEx> arrFldSet = clsPrjTabFldBLEx.GetObjExLst(objViewInfoENEx.MainTabId, objViewInfoENEx.PrjId);

                if (string.IsNullOrEmpty(objFeatureRegionFlds_GoTop.ReleFldId))
                {
                    strCodeForCs.AppendFormat("\r\n" + "//表：[{0}]的序号字段为空，不能生成【预检函数(PreCheck4Order)】;",
                        objViewInfoENEx.TabName);
                    return strCodeForCs.ToString();

                }
                strCodeForCs.Append("\r\n /**");
                strCodeForCs.AppendFormat("\r\n 移动记录序号时的预检查函数");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");
                strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.PreCheck4Order = function()", objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                if (arrFieldLst_Classify.Count() > 0)
                {
                    foreach (clsvViewFeatureFldsENEx objInFor in arrFieldLst_Classify)
                    {

                        strCodeForCs.AppendFormat("\r\n" + " var str{0} =this.{1};",
     objInFor.FldName, objInFor.CtrlId.Substring(3));

                        arrPropertyDef4GC.Add(new clsPropertyDef4GC
                        {
                            OperateType = "get",
                            ControlType = objInFor.CtlTypeName,
                            CtrlId = objInFor.CtrlId,
                            PropertyName = objInFor.CtrlId.Substring(3),
                            Comment = objInFor.FldName,
                            DataType = "string"
                        });

                        strCodeForCs.AppendFormat("\r\n" + "if (str{0} == \"\")",
                            objInFor.FldName);

                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "const strMsg = \"请输入{0}!\";", objInFor.ObjFieldTab().FldName);
                        strCodeForCs.Append("\r\n" + "alert(strMsg);");

                        strCodeForCs.Append("\r\n" + "return false;");
                        strCodeForCs.Append("\r\n" + "}");
                    }
                }
                strCodeForCs.Append("\r\n" + "return true;");
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

        public string Gen_WApi_Js_btnGoBottum_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);
                if (objAdjustOrderNum == null) return "";
                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";




                strCodeForCs.Append("\r\n /**");
                strCodeForCs.AppendFormat("\r\n 置底");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");
                strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.btnGoBottum_Click = async function()", objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "if (this.PreCheck4Order() == false) return;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    foreach (clsvViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + " var str{0} =this.{1};",
     objInFor.FldName, objInFor.CtrlId.Substring(3));

                        arrPropertyDef4GC.Add(new clsPropertyDef4GC
                        {
                            OperateType = "get",
                            ControlType = objInFor.CtlTypeName,
                            CtrlId = objInFor.CtrlId,
                            PropertyName = objInFor.CtrlId.Substring(3),
                            Comment = objInFor.FldName,
                            DataType = "string"
                        });
                    }
                }
                strCodeForCs.AppendFormat("\r\n" + "const arrKeyIds = {0}.GetCheckedKeyIds();",
                                      ImportClass.GetOutString(string.Format("clsCommFunc4Web", objViewInfoENEx.TabName), this.Is4RJ));
                strCodeForCs.Append("\r\n" + "if (arrKeyIds.length == 0)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "alert(\"请选择需要置底的记录！\");");
                strCodeForCs.Append("\r\n" + "return \"\";");
                strCodeForCs.Append("\r\n" + "}");

                //strCodeForCs.Append("\r\n" + "lblMsg_List.Text = \"\";");
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const objOrderByData = new clsOrderByData();");
                strCodeForCs.Append("\r\n" + "objOrderByData.KeyIdLst = arrKeyIds;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const jsonObject =");
                    strCodeForCs.Append("\r\n" + "{");

                    foreach (clsvViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "\"{0}\": {1},",
                            objInFor.FldName,
                            objInFor.PrivFuncName);

                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "const jsonStr = JSON.stringify(jsonObject);");
                    strCodeForCs.Append("\r\n" + "objOrderByData.ClassificationFieldValueLst = jsonStr;");
                    strCodeForCs.AppendFormat("\r\n" + "const responseRederBy = await {1}.GoBottom(objOrderByData);",
                         objViewInfoENEx.TabName,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName), this.Is4RJ));
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseRederBy = await {2}.GoBottom(objOrderByData);",
                         objViewInfoENEx.TabName,
                         objKeyField.PrivFuncListName,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName), this.Is4RJ));
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = \"置底出错。错误:\" + e.Message + \".(In \" + clsStackTrace.GetCurrClassFunction() + \")\";");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                if (objViewInfoENEx.IsUseCache4List)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = this.BindGv_{0}_Cache();", objViewInfoENEx.TabName_Out);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = await this.BindGv_{0}();", objViewInfoENEx.TabName_Out);
                }
                //strCodeForCs.AppendFormat("\r\n" + "foreach({0} {1} in lst{2})",
                //        objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType, objKeyField.ObjFieldTabENEx.PrivFuncName,
                //        objKeyField.ObjFieldTabENEx.FldName_FstUcase);
                //strCodeForCs.Append("\r\n" + "{");

                strCodeForCs.Append("\r\n" + "const strListDiv = this.divName4DataList;");
                strCodeForCs.AppendFormat("\r\n" + "arrKeyIds.forEach((e) => {0}.SetCheckedItem4KeyId(strListDiv, e));",
                                      ImportClass.GetOutString(string.Format("clsCommFunc4Web", objViewInfoENEx.TabName), this.Is4RJ));
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
        public string Gen_WApi_Js_btnReOrder_Click()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                clsAdjustOrderNum4View objAdjustOrderNum = clsAdjustOrderNum4View.GetOrderNumInfoByViewInfo(objViewInfoENEx);
                if (objAdjustOrderNum == null) return "";
                if (objAdjustOrderNum.objFeatureRegionFlds_AdjustOrderNum == null) return "";

                strCodeForCs.Append("\r\n /**");
                strCodeForCs.AppendFormat("\r\n 重序");
                strCodeForCs.AppendFormat("\r\n  ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n **/");
                strCodeForCs.AppendFormat("\r\n" + "{0}.prototype.btnReOrder_Click = async function()", objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "if (this.PreCheck4Order() == false) return;");
                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    foreach (clsvViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + " var str{0} =this.{1};",
     objInFor.FldName, objInFor.CtrlId.Substring(3));

                        arrPropertyDef4GC.Add(new clsPropertyDef4GC
                        {
                            OperateType = "get",
                            ControlType = objInFor.CtlTypeName,
                            CtrlId = objInFor.CtrlId,
                            PropertyName = objInFor.CtrlId.Substring(3),
                            Comment = objInFor.FldName,
                            DataType = "string"
                        });
                    }
                }
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const objOrderByData = new clsOrderByData();");

                if (objAdjustOrderNum.arrvViewFeatureFlds_Classify.Count() > 0)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const jsonObject =");
                    strCodeForCs.Append("\r\n" + "{");
                    foreach (clsvViewFeatureFldsENEx objInFor in objAdjustOrderNum.arrvViewFeatureFlds_Classify)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "\"{0}\": {1},",
                            objInFor.FldName,
                            objInFor.PrivFuncName);
                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.AppendFormat("\r\n" + "const jsonStr = JSON.stringify(jsonObject);");
                    strCodeForCs.Append("\r\n" + "objOrderByData.ClassificationFieldValueLst = jsonStr;");

                    strCodeForCs.AppendFormat("\r\n" + "const responseRederBy = await {2}.ReOrder(objOrderByData);",
                   objViewInfoENEx.TabName,
                   objAdjustOrderNum.VarLst,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName), this.Is4RJ));
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseRederBy = await {1}.ReOrder(objOrderByData);",
                   objViewInfoENEx.TabName,
                                      ImportClass.GetOutString(string.Format("cls{0}WApi", objViewInfoENEx.TabName), this.Is4RJ));
                }
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = \"重序出错。错误:\" + e.Message + \".(In \" + clsStackTrace.GetCurrClassFunction() + \")\";");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");

                if (objViewInfoENEx.IsUseCache4List)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = this.BindGv_{0}_Cache();", objViewInfoENEx.TabName_Out);
                }
                else
                {
                    strCodeForCs.AppendFormat("\r\n" + "const responseBindGv = await this.BindGv_{0}();", objViewInfoENEx.TabName_Out);
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

        public string Gen_WApi_Js_Code4QueryRegion()
        {
            //arrPropertyDef4GC = new1 List<clsPropertyDef4GC>();
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                     clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(enumFunctionTemplate.RegionFunctionDetailSet_0005,
                            objViewInfoENEx.CodeTypeId,
                            enumRegionType.QueryRegion_0001)
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

        public string Gen_WApi_Js_Code4FeatureRegion()
        {
            //arrPropertyDef4GC = new 1List<clsPropertyDef4GC>();
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                     clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(enumFunctionTemplate.RegionFunctionDetailSet_0005,
                     objViewInfoENEx.CodeTypeId,
                     enumRegionType.FeatureRegion_0008)
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
        public string Gen_WApi_Js_Code4ListRegion()
        {
            //arrPropertyDef4GC = new 1List<clsPropertyDef4GC>();
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                     clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(enumFunctionTemplate.RegionFunctionDetailSet_0005,
                     objViewInfoENEx.CodeTypeId,
                     enumRegionType.ListRegion_0002)
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
        public string Gen_WApi_Js_Code4EditRegion()
        {
            //arrPropertyDef4GC = new 1List<clsPropertyDef4GC>();
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                     clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(enumFunctionTemplate.RegionFunctionDetailSet_0005,
                     objViewInfoENEx.CodeTypeId,
                     enumRegionType.EditRegion_0003)
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
        public string Gen_WApi_Js_Code4ExcelExportRegion()
        {
            //arrPropertyDef4GC = new1 List<clsPropertyDef4GC>();
            StringBuilder strCodeForCs = new StringBuilder(); ///用来存放与WebForm相关的类文件代码;

            IEnumerable<clsvFunction4GeneCodeEN> arrvFunction4GeneCodeObjLst =
                     clsvFunctionTemplateRelaBLEx.getFunction4GeneCodeObjLstByTemplateId(enumFunctionTemplate.RegionFunctionDetailSet_0005,
                     objViewInfoENEx.CodeTypeId,
                     enumRegionType.ExcelExportRegion_0007)
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

    }
}
