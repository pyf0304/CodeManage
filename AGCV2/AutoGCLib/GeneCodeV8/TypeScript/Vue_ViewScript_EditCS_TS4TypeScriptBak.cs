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
    partial class Vue_ViewScript_EditCS_TS4TypeScriptBak : clsGeneCodeBase, IImportClass
    {
        private List<clsPropertyDef4GC> arrPropertyDef4GC = null;
        private string strVarDef4ViewCacheFld = "";
        //private string strVarDef4GivingValue = "";
        //private string objPrjTabENEx = "";
        int intZIndex;      ///控件焦点序号
        float intCurrLeft;  ///控件的左边空;
        float intCurrTop;  ///控件的顶面空;
        //clsBiDimDistribute objBiDimDistribue4Qry = null;
        #region 构造函数
        public Vue_ViewScript_EditCS_TS4TypeScriptBak()
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            InitPageSetup();
        }
        public Vue_ViewScript_EditCS_TS4TypeScriptBak(string strViewId)
       : base("", strViewId, "", "")
        {
            // 
            // TODO: 在此处添加构造函数逻辑
            //
            this.strDataBaseType = clsPubConst.con_MsSql;
            InitPageSetup();
        }
        public Vue_ViewScript_EditCS_TS4TypeScriptBak(string strTabId, string strViewId, string strPrjDataBaseId, string strPrjId)
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

                strCodeForCs.Append("\r\n /** 函数功能:页面导入,当页面开始运行时所发生的事件");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "public async Page_Load()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.Page_Load.name;",
objViewInfoENEx.TabName, objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "// 在此处放置用户代码以初始化页面");
                //strCodeForCs.Append("\r\n" + GenPotenceRelaCode());
                //生成Page_Load中的绑定下拉框的代码
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");
                //设置事件函数
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

                strCodeForCs.Append("\r\n /** 函数功能:设置事件函数");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "public async SetEventFunc()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.SetEventFunc.name;",
objViewInfoENEx.TabName, objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "// 在此处放置用户代码以初始化页面");


                //strCodeForCs.Append("\r\n" + GenPotenceRelaCode());
                //生成Page_Load中的绑定下拉框的代码
                strCodeForCs.Append("\r\n" + "try");
                strCodeForCs.Append("\r\n" + "{");

                var arrEditRegionFlds_ChangeEvent = objViewInfoENEx.arrEditRegionFldSet.Where(x => string.IsNullOrEmpty(x.ChangeEvent) == false && x.InUse == true).ToList();
                arrEditRegionFlds_ChangeEvent.ForEach(x =>
                {
                    var objCtlTypeAbbr = clsCtlTypeAbbrBL.GetObjByCtlTypeId_Cache(x.CtlTypeId);
                    strCodeForCs.AppendFormat("\r\n" + "var {0}: {1} = clsCommFunc4Ctrl.GetSelectObjInDiv(this.divName4Edit, '{0}');",
                                    x.CtrlId, objCtlTypeAbbr.HtmlCtrlTypeName);
                    strCodeForCs.AppendFormat("\r\n" + "{0}.addEventListener('change', e => {{ this.{1}(); }});",
                       x.CtrlId, x.ChangeEvent, objViewInfoENEx.ClsName);
                });

                var arrEditRegionFlds_ClickEvent = objViewInfoENEx.arrEditRegionFldSet.Where(x => string.IsNullOrEmpty(x.ClickEvent) == false && x.InUse == true).ToList();
                arrEditRegionFlds_ClickEvent.ForEach(x =>
                {
                    var objCtlTypeAbbr = clsCtlTypeAbbrBL.GetObjByCtlTypeId_Cache(x.CtlTypeId);
                    switch(objCtlTypeAbbr.HtmlCtrlTypeName)
                    {
                        case "HTMLButtonElement":
                            strCodeForCs.AppendFormat("\r\n" + "var {0}: {1} =clsCommFunc4Ctrl.GetButtonObjInDiv(this.divName4Edit, '{0}');",
                                 x.CtrlId, objCtlTypeAbbr.HtmlCtrlTypeName);
                            break;
                        case "HTMLInputElement":
                            strCodeForCs.AppendFormat("\r\n" + "var {0}: {1} =clsCommFunc4Ctrl.GetInputObjInDiv(this.divName4Edit, '{0}');",
                                 x.CtrlId, objCtlTypeAbbr.HtmlCtrlTypeName);
                            break;
                        default:
                            var strMsg = String.Format("控件类型(HtmlCtrlTypeName):{0}在switch中没有被处理！(In {1})", objCtlTypeAbbr.HtmlCtrlTypeName,
                                clsStackTrace.GetCurrClassFunction());
                            throw new Exception(strMsg);
                       
                    }
                    strCodeForCs.AppendFormat("\r\n" + "{0}.addEventListener('click', e => {{ this.{1}(); }});",
                       x.CtrlId, x.ClickEvent, objViewInfoENEx.ClsName);
                });

                if (arrEditRegionFlds_ChangeEvent.Count == 0 && arrEditRegionFlds_ClickEvent.Count == 0)
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


                var arrEditRegionFlds_ChangeEvent = objViewInfoENEx.arrEditRegionFldSet.Where(x => string.IsNullOrEmpty(x.ChangeEvent) == false && x.InUse == true).ToList();
                arrEditRegionFlds_ChangeEvent.ForEach(x =>
                {
                    var objCtlTypeAbbr = clsCtlTypeAbbrBL.GetObjByCtlTypeId_Cache(x.CtlTypeId);

                    strCodeForCs.Append("\r\n /** 函数功能:系统生成的Change事件函数");
                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + " **/");
                    strCodeForCs.AppendFormat("\r\n" + "public abstract {0}():void;//",
                       x.ChangeEvent);
                    //strCodeForCs.AppendFormat("\r\n" + "alert('请在扩展层:{0}Ex中覆盖该函数！');", objViewInfoENEx.ClsName);
                    //strCodeForCs.Append("\r\n" + "}");
                });

                strCodeForCs.Append("\r\n" + "");

                var arrEditRegionFlds_ClickEvent = objViewInfoENEx.arrEditRegionFldSet.Where(x => string.IsNullOrEmpty(x.ClickEvent) == false && x.InUse == true).ToList();
                arrEditRegionFlds_ClickEvent.ForEach(x =>
                {
                    var objCtlTypeAbbr = clsCtlTypeAbbrBL.GetObjByCtlTypeId_Cache(x.CtlTypeId);
                    strCodeForCs.Append("\r\n /** 函数功能:系统生成的Click事件函数");
                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.Append("\r\n" + " **/");

                    strCodeForCs.AppendFormat("\r\n" + "public abstract {0}():void;",
                       x.ClickEvent, objViewInfoENEx.ClsName);
                    //strCodeForCs.AppendFormat("\r\n" + "alert('请在扩展层:{0}Ex中覆盖该函数！');", objViewInfoENEx.ClsName);
                    //strCodeForCs.Append("\r\n" + "}");
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

        public string Gen_Vue_Ts_DdlBind()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                ///生成仅有变量;


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

                                    strCodeForCs.AppendFormat("\r\n /** 绑定下拉框:ddl{0}的函数。", objEditRegionFldsEx.FldName);
                                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                                    strCodeForCs.Append("\r\n" + " **/");
                                    strCodeForCs.AppendFormat("\r\n" + "public void BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL)",
                                    objEditRegionFldsEx.FldName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.BindDdl_{0}.name;", objEditRegionFldsEx.FldName, objKeyField.FldName);
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
                                    strCodeForCs.Append("\r\n" + "/**");
                                    strCodeForCs.AppendFormat("\r\n" + " * 为下拉框获取数据,从表:[{0}]中获取",
                                      strDs_TabName);
                                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                                    strCodeForCs.Append("\r\n * returns:获取主键字段、名称字段两列的所有记录记录的DataTable</returns>");
                                    strCodeForCs.Append("\r\n" + " **/");
                                    strCodeForCs.AppendFormat("\r\n" + "public async BindDdl_{1}(ddl{1}: string, strWhereCond:string=\"1=1\") {{",
                                      strDs_TabName, strDS_DataValueField, strDS_DataTextField, objEditRegionFldsEx.CtrlId);
                                    strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.BindDdl_{0}.name;", strDS_DataValueField);
                                    strCodeForCs.Append("\r\n" + "//let strWhereCond = \" 1 =1 \";");
                                    strCodeForCs.AppendFormat("\r\n" + "const objDdl = document.getElementById(ddl{1});",
                                        strDs_TabName, strDS_DataValueField, strDS_DataTextField);
                                    strCodeForCs.Append("\r\n" + "if (objDdl == null)");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"下拉框：{{0}} 不存在！\", ddl{1});",
                                        strDs_TabName, strDS_DataValueField, strDS_DataTextField);
                                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                                    strCodeForCs.Append("\r\n" + "throw (strMsg);");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "return new Promise((resolve, reject) => {");

                                    strCodeForCs.Append("\r\n" + "try");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "var arr{0}ObjLst: Array < cls{0}EN > = await {0}_GetObjLstAsync(strWhereCond).then((jsonData)=>{{",
                                        strDs_TabName, strDS_DataValueField, strDS_DataTextField);
                                    //strCodeForCs.AppendFormat("\r\n" + "var arr{0}ObjLst: Array < cls{0}EN > = <Array<cls{0}EN>> jsonData;",
                                    //    strDs_TabName, strDS_DataValueField, strDS_DataTextField);
                                    //this.BindTab_{0}(strListDiv, arr{0}ObjLst);
                                    strCodeForCs.AppendFormat("\r\n" + "clsCommFunc4Web.BindDdl_ObjLst(ddl{1}, arr{0}ObjLst, cls{0}EN.con_{1}, cls{0}EN.con_{2}, \"{3}\");",
                                        strDs_TabName, strDS_DataValueField, strDS_DataTextField, strDS_TabCnName);
                                    strCodeForCs.AppendFormat("\r\n" + "console.log(\"完成BindDdl_{0}!\");", strDS_DataValueField);
                                    strCodeForCs.Append("\r\n" + "resolve(jsonData);");
                                    //strCodeForCs.Append("\r\n" + "});");


                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "catch (e)");
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.Append("\r\n" + "const strMsg = Format(\"绑定下拉框不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
                                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                                    strCodeForCs.Append("\r\n" + "}");
                                    strCodeForCs.Append("\r\n" + "});");
                                    strCodeForCs.Append("\r\n" + "}");


                                    break;
                                case "03": ///列表项数据源SQL串;
                                    strCodeForCs.Append("\r\n" + "/**");
                                    strCodeForCs.AppendFormat("\r\n" + " * 为下拉框获取数据,从Sql串:[{0}]中获取",
                                       objEditRegionFldsEx.Ds_SQLStr);
                                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());                                    
                                    strCodeForCs.Append("\r\n * returns:获取自定义的Sql串中两列的所有记录记录的DataTable</returns>");
                                    strCodeForCs.Append("\r\n" + " **/");
                                    strCodeForCs.AppendFormat("\r\n" + "public System.Data.DataTable Get{0}(string strCondition)",
                                    objEditRegionFldsEx.FldName);
                                    strCodeForCs.Append("\r\n" + "{");

                                    strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.Get{0}.name;", objEditRegionFldsEx.FldName);
                                    strCodeForCs.Append("\r\n" + "//获取某学院所有专业信息");
                                    //strCodeForCs.Append("\r\n" + "clsSpecSQLforSql mySql = new 1clsSpecSQLforSql();");
                                    strCodeForCs.AppendFormat("\r\n clsSpecSQLforSql mySql = cls{0}BL.GetSpecSQLObj();", objViewInfoENEx.TabName);

                                    strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = mySql.GetDataTable({0});",
                                    objEditRegionFldsEx.Ds_SQLStr);
                                    strCodeForCs.Append("\r\n" + "return objDT;");
                                    strCodeForCs.Append("\r\n" + "}");

                                    strCodeForCs.Append("\r\n /** 绑定基于Web的下拉框");
                                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                                    strCodeForCs.Append("\r\n * @param  objDDL:需要绑定当前表的下拉框");
                                    strCodeForCs.Append("\r\n" + " **/");
                                    strCodeForCs.AppendFormat("\r\n" + "public void BindDdl_{0}(System.Web.UI.WebControls.DropDownList objDDL)",
                                    objEditRegionFldsEx.FldName);
                                    strCodeForCs.Append("\r\n" + "{");
                                    strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.BindDdl_{0}.name;", objEditRegionFldsEx.FldName);
                                    strCodeForCs.Append("\r\n" + "//为数据源于表的下拉框设置内容");
                                    strCodeForCs.Append("\r\n" + "ListItem li = new ListItem(\"请选择...\",\"0\");");
                                    strCodeForCs.AppendFormat("\r\n" + "System.Data.DataTable objDT = Get{0}();",
                                    objEditRegionFldsEx.FldName);
                                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataValueField = cls{0}EN.con_{1};",
                                      strDs_TabName, strDS_DataValueField);
                                    strCodeForCs.AppendFormat("\r\n" + "objDDL.DataTextField = cls{0}EN.con_{1};",
                                      strDs_TabName, strDS_DataTextField);
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
               
        public string Gen_Vue_Ts_BindDdl4EditRegion()
        {
            clsVarManage objVarManage = new clsVarManage("TypeScript");
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            IEnumerable<ASPDropDownListEx> arrASPDropDownListObj_Edit = objViewInfoENEx.arrASPDropDownListObj.Where(x => x.RegionTypeId == enumRegionType.EditRegion_0003);
            try
            {
                strCodeForCs.Append("\r\n /** 函数功能:为编辑区绑定下拉框");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + "public async BindDdl4EditRegion()", objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.BindDdl4EditRegion.name;",
objViewInfoENEx.TabName, objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "// 在此处放置用户代码以初始化页面");

                
                //strCodeForCs.Append("\r\n" + "$(\"#divPager\").load(\"../PubWebClass/pager\");");
                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj_Edit)
                {
                    try
                    {
                        Tuple<string, string> tup = this.Gen_Vue_Ts_DefineVar4Ddl(strCodeForCs, objInfor, objVarManage);
                        //
                        string strVar4Cond = tup.Item1;
                        string strVar4Cond_2 = tup.Item2;

                        if (objInfor.CsType == "bool")
                        {
                            strCodeForCs.AppendFormat("\r\n" + "clsCommFunc4Ctrl.BindDdl_TrueAndFalse(\"{0}\");",
                                     objInfor.CtrlId);
                        }
                        else
                        {
                            //if (objInfor.objFieldTab_CacheClassify() == null)
                            //{
                            strCodeForCs.AppendFormat("\r\n" + "const {2} = await this.SetDdl_{1}({4});//{3}",
                                        objInfor.FldName,
                                         objInfor.FldName,
                                        objInfor.CtrlId,
                                        clsRegionTypeBL.GetNameByRegionTypeId_Cache(objInfor.RegionTypeId),
                                        strVar4Cond_2);
                            //}
                            //else
                            //{

                            //    strCodeForCs.AppendFormat("\r\n" + "const {2} = await this.SetDdl_{1}({4} {5});//{3}",
                            //         objInfor.FldName,
                            //         objInfor.FldName,
                            //        objInfor.CtrlId,
                            //        clsRegionTypeBL.GetNameByRegionTypeId_Cache(objInfor.RegionTypeId),
                            //        objInfor.objFieldTab_CacheClassify().PrivFuncName(),
                            //        strVar4Cond_2);
                            //}
                        }
                    }
                    catch (Exception objException)
                    {
                        string strMsg = objException.Message;
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

        public Tuple<string, string> Gen_Vue_Ts_DefineVar4Ddl(StringBuilder strCodeForCs, ASPDropDownListEx objInfor, clsVarManage objVarManage)
        {

            clsFieldTabEN objFieldTab_Cond = clsFieldTabBL.GetObjByFldId_Cache(objInfor.objEditRegionFldsEN.Ds_CondFieldId, objInfor.objEditRegionFldsEN.PrjId);

            string strVar4Cond = "";
            string strVar4Cond_2 = "";
            if (objFieldTab_Cond != null && objInfor.objFieldTab_CacheClassify() != null)
            {

                {
                    strVar4Cond = objInfor.objFieldTab_CacheClassify().PrivFuncName();
                    strVar4Cond_2 = objInfor.objFieldTab_CacheClassify().PrivFuncName();
                    if (objVarManage.AddVariable(new clsVariable(objInfor.objFieldTab_CacheClassify().PrivFuncName(), objInfor.objFieldTab_CacheClassify().ObjDataTypeAbbr().TypeScriptType)) == true)
                    {

                        //生成缓存分类字段的检查代码，检查是否被赋正确值
                        if (objViewInfoENEx.objCacheClassifyFld4View != null && objViewInfoENEx.objCacheClassifyFld4View.FldName == objInfor.objFieldTab_CacheClassify().FldName)
                        {
                            string strVarDefStr = objVarManage.DefVariable(strVar4Cond, "\"\"", strVarDef4ViewCacheFld);

                            strCodeForCs.AppendFormat("\r\n" + "{0}  //定义条件字段", strVarDefStr);
                            clsPubFun4GC.GC_CheckCode4CacheClassifyFld(strCodeForCs, objViewInfoENEx.objCacheClassifyFld4View, objInfor.objFieldTab_CacheClassify().PrivFuncName(), this.ClsName);
                        }
                        else
                        {
                            string strVarDefStr = objVarManage.DefVariable(strVar4Cond, "\"\"", "");
                            strCodeForCs.AppendFormat("\r\n" + "{0}  //定义条件字段", strVarDefStr);
                        }
                    }

                }
                if (objFieldTab_Cond.PrivFuncName() != objInfor.objFieldTab_CacheClassify().PrivFuncName())
                {
                    if (objInfor.objTabFeatureFlds != null)
                    {
                        if (objInfor.objTabFeatureFlds.ValueGivingModeId == enumValueGivingMode.GivenValue_02
                             || string.IsNullOrEmpty(objInfor.objTabFeatureFlds.ValueGivingModeId) == true)
                        {
                            strVar4Cond = objFieldTab_Cond.PrivFuncName();
                            strVar4Cond_2 = string.Format("{0}, {1}", objFieldTab_Cond.PrivFuncName(), strVar4Cond_2);
                            if (objVarManage.AddVariable(new clsVariable(strVar4Cond, objFieldTab_Cond.ObjDataTypeAbbr().TypeScriptType)) == true)
                            {

                                //生成缓存分类字段的检查代码，检查是否被赋正确值
                                if (objViewInfoENEx.objCacheClassifyFld4View != null
                                    && objViewInfoENEx.objCacheClassifyFld4View.FldName == objFieldTab_Cond.FldName)
                                {
                                    string strVarDefStr = objVarManage.DefVariable(strVar4Cond, "\"\"", strVarDef4ViewCacheFld);

                                    strCodeForCs.AppendFormat("\r\n" + "{0}  //定义条件字段", strVarDefStr);
                                    clsPubFun4GC.GC_CheckCode4CacheClassifyFld(strCodeForCs, objViewInfoENEx.objCacheClassifyFld4View, objInfor.objFieldTab_CacheClassify().PrivFuncName(), this.ClsName);
                                }
                                else
                                {
                                    string strVarDefStr = objVarManage.DefVariable(strVar4Cond, "\"\"", "");
                                    if (objFieldTab_Cond.ObjDataTypeAbbr().IsNumberType() == true)
                                    {
                                        strVarDefStr = objVarManage.DefVariable(strVar4Cond, "0", "");
                                    }
                                    strCodeForCs.AppendFormat("\r\n" + "{0}  //定义条件字段", strVarDefStr);
                                }
                            }
                        }
                    }
                }
            }
            else if (objFieldTab_Cond != null && objInfor.objFieldTab_CacheClassify() == null)
            {
                if (objInfor.objTabFeatureFlds != null)
                {
                    if (objInfor.objTabFeatureFlds.ValueGivingModeId == enumValueGivingMode.GivenValue_02
                      || string.IsNullOrEmpty(objInfor.objTabFeatureFlds.ValueGivingModeId) == true)
                    {

                        strVar4Cond = objFieldTab_Cond.PrivFuncName();
                        strVar4Cond_2 = strVar4Cond;
                        if (objVarManage.AddVariable(new clsVariable(strVar4Cond, objFieldTab_Cond.ObjDataTypeAbbr().TypeScriptType)) == true)
                        {

                            //生成缓存分类字段的检查代码，检查是否被赋正确值
                            if (objViewInfoENEx.objCacheClassifyFld4View != null
                                && objViewInfoENEx.objCacheClassifyFld4View.FldName == objFieldTab_Cond.FldName)
                            {

                                string strVarDefStr = objVarManage.DefVariable(strVar4Cond, "\"\"", strVarDef4ViewCacheFld);

                                strCodeForCs.AppendFormat("\r\n" + "{0}  //定义条件字段", strVarDefStr);
                                var objFieldTab = objInfor.objFieldTab_CacheClassify();
                                if (objFieldTab != null)
                                {
                                    clsPubFun4GC.GC_CheckCode4CacheClassifyFld(strCodeForCs, objViewInfoENEx.objCacheClassifyFld4View, objFieldTab.PrivFuncName(), this.ClsName);
                                }
                            }
                            else
                            {
                                string strVarDefStr = objVarManage.DefVariable(strVar4Cond, "\"\"", "");
                                strCodeForCs.AppendFormat("\r\n" + "{0}  //定义条件字段", strVarDefStr);
                            }
                        }
                    }
                }
            }
            else if (objFieldTab_Cond == null && objInfor.objFieldTab_CacheClassify() != null)
            {
                strVar4Cond = objInfor.objFieldTab_CacheClassify().PrivFuncName();
                strVar4Cond_2 = objInfor.objFieldTab_CacheClassify().PrivFuncName();
                if (objVarManage.AddVariable(new clsVariable(objInfor.objFieldTab_CacheClassify().PrivFuncName(), objInfor.objFieldTab_CacheClassify().ObjDataTypeAbbr().TypeScriptType)) == true)
                {

                    //生成缓存分类字段的检查代码，检查是否被赋正确值
                    if (objViewInfoENEx.objCacheClassifyFld4View != null
                        && objViewInfoENEx.objCacheClassifyFld4View.FldName == objInfor.objFieldTab_CacheClassify().FldName)
                    {
                        string strVarDefStr = objVarManage.DefVariable(strVar4Cond, "\"\"", strVarDef4ViewCacheFld);

                        strCodeForCs.AppendFormat("\r\n" + "{0}  //定义条件字段", strVarDefStr);
                        clsPubFun4GC.GC_CheckCode4CacheClassifyFld(strCodeForCs, objViewInfoENEx.objCacheClassifyFld4View, objInfor.objFieldTab_CacheClassify().PrivFuncName(), this.ClsName);
                    }
                    else
                    {
                        string strVarDefStr = objVarManage.DefVariable(strVar4Cond, "\"\"", "");

                        strCodeForCs.AppendFormat("\r\n" + "{0}  //定义条件字段", strVarDefStr);
                    }
                }
            }
            else
            {

            }

            Tuple<string, string> tup = new Tuple<string, string>(strVar4Cond, strVar4Cond_2);

            return tup;
        }


        public Tuple<string, string> Gen_Vue_Ts_DefineVar4Ddl4TabFeature(StringBuilder strCodeForCs, ASPDropDownListEx objInfor, clsVarManage objVarManage)
        {
            List<string> arrConditionFldName = new List<string>();

            clsFieldTabEN objFieldTab_Cond1 = clsFieldTabBL.GetObjByFldId_Cache(objInfor.FldId_Cond1, objInfor.objEditRegionFldsEN.PrjId);
            clsFieldTabEN objFieldTab_Cond2 = clsFieldTabBL.GetObjByFldId_Cache(objInfor.FldId_Cond2, objInfor.objEditRegionFldsEN.PrjId);

            string strVar4Cond = "";
            string strVar4Cond_2 = "";
            if (objFieldTab_Cond1 != null)
            {
                var objVar = clsGCVariableBL.GetObjByVarId_Cache(objInfor.VarId_Cond1, objInfor.PrjId);
                if (objVar.VarTypeId != enumGCVariableType.DefaultValue_0002)
                {
                    string strPrivFuncName_Cond1 = objFieldTab_Cond1.PrivFuncName();
                    arrConditionFldName.Add(strPrivFuncName_Cond1);

                    strVar4Cond = strPrivFuncName_Cond1;
                    strVar4Cond_2 = strPrivFuncName_Cond1;
                    if (objVarManage.AddVariable(new clsVariable(strPrivFuncName_Cond1, objFieldTab_Cond1.ObjDataTypeAbbr().TypeScriptType)) == true)
                    {
                        string strVarDef4View = "";
                        var objGCVariable = clsGCVariableBL.GetObjByVarId_Cache(objInfor.VarId_Cond1, objInfor.objEditRegionFldsEN.PrjId);
                        switch (objGCVariable.VarTypeId)
                        {
                            case enumGCVariableType.GivingValue_0001:
                                strVarDef4View = string.Format("{0}.{1}_Giving", objViewInfoENEx.ClsName, objGCVariable.VarExpression);
                                break;
                            case enumGCVariableType.CacheClassifyField_0007:
                                strVarDef4View = string.Format("{0}.{1}", objViewInfoENEx.ClsName, objGCVariable.VarExpression);
                                break;
                            case enumGCVariableType.StaticValuable_0006:
                                strVarDef4View = string.Format("{0}.{1}", objViewInfoENEx.ClsName, objGCVariable.VarExpression);
                                break;
                            case enumGCVariableType.DefaultValue_0002:
                                break;
                            default:
                                var objGCVariableType = clsGCVariableTypeBL.GetObjByVarTypeId_Cache(objGCVariable.VarTypeId);

                                var strMsg = string.Format("在Switch中类型：[{0}({1})]没有被处理！(in {2})", objGCVariableType.VarTypeName, objGCVariableType.VarTypeId,
        clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                                //break;
                        }
                        string strVarDefStr = objVarManage.DefVariable(strVar4Cond, "\"\"", strVarDef4View);
                        strCodeForCs.AppendFormat("\r\n" + "{0}  //定义条件字段", strVarDefStr);
                        //clsPubFun4GC.GC_CheckCode4CacheClassifyFld(strCodeForCs, objViewInfoENEx.objCacheClassifyFld4View, objInfor.objFieldTab_CacheClassify().PrivFuncName(), this.ClsName);
                    }
                    else
                    {
                        //string strVarDefStr = objVarManage.DefVariable(strVar4Cond, "\"\"", "");
                        //strCodeForCs.AppendFormat("\r\n" + "{0}  //定义条件字段", strVarDefStr);
                    }
                }
            }

            if (objFieldTab_Cond2 != null)
            {
                var objVar = clsGCVariableBL.GetObjByVarId_Cache(objInfor.VarId_Cond1, objInfor.PrjId);
                if (objVar.VarTypeId != enumGCVariableType.DefaultValue_0002)
                {
                    string strPrivFuncName_Cond2 = objFieldTab_Cond2.PrivFuncName();
                    arrConditionFldName.Add(strPrivFuncName_Cond2);
                    strVar4Cond = strPrivFuncName_Cond2;
                    strVar4Cond_2 += string.Format(",{0}", strPrivFuncName_Cond2);
                    if (objVarManage.AddVariable(new clsVariable(strPrivFuncName_Cond2, objFieldTab_Cond2.ObjDataTypeAbbr().TypeScriptType)) == true)
                    {
                        string strVarDef4View = "";
                        var objGCVariable = clsGCVariableBL.GetObjByVarId_Cache(objInfor.VarId_Cond2, objInfor.objEditRegionFldsEN.PrjId);
                        switch (objGCVariable.VarTypeId)
                        {
                            case enumGCVariableType.GivingValue_0001:
                                strVarDef4View = string.Format("{0}.{1}", objViewInfoENEx.ClsName, objGCVariable.VarExpression);
                                break;
                            case enumGCVariableType.CacheClassifyField_0007:
                                strVarDef4View = string.Format("{0}.{1}_Cache", objViewInfoENEx.ClsName, objViewInfoENEx.objCacheClassifyFld4View.FldName);
                                break;
                            case enumGCVariableType.StaticValuable_0006:
                                strVarDef4View = string.Format("{0}.{1}", objViewInfoENEx.ClsName, objGCVariable.VarExpression);
                                break;
                            default:
                                var objGCVariableType = clsGCVariableTypeBL.GetObjByVarTypeId_Cache(objGCVariable.VarTypeId);

                                var strMsg = string.Format("在Switch中类型：[{0}({1})]没有被处理！(in {2})", objGCVariableType.VarTypeName, objGCVariableType.VarTypeId,
                                    clsStackTrace.GetCurrClassFunction());
                                throw new Exception(strMsg);
                                //break;
                        }
                        string strVarDefStr = objVarManage.DefVariable(strVar4Cond, "\"\"", strVarDef4View);
                        strCodeForCs.AppendFormat("\r\n" + "{0}  //定义条件字段", strVarDefStr);
                        //clsPubFun4GC.GC_CheckCode4CacheClassifyFld(strCodeForCs, objViewInfoENEx.objCacheClassifyFld4View, objInfor.objFieldTab_CacheClassify().PrivFuncName(), this.ClsName);
                    }
                    else
                    {

                    }
                }
            }

            Tuple<string, string> tup = new Tuple<string, string>(strVar4Cond, strVar4Cond_2);

            return tup;
        }


        public string Gen_Vue_Ts_BindDdl4EditRegionInDiv()
        {
            clsVarManage objVarManage = new clsVarManage("TypeScript");
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            IEnumerable<ASPDropDownListEx> arrASPDropDownListObj_Edit = objViewInfoENEx.arrASPDropDownListObj.Where(x => x.RegionTypeId == enumRegionType.EditRegion_0003);
            try
            {
                strCodeForCs.Append("\r\n /** 函数功能:为编辑区绑定下拉框");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + "public async BindDdl4EditRegionInDiv()", objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.BindDdl4EditRegionInDiv.name;",
objViewInfoENEx.TabName, objKeyField.FldName);
                strCodeForCs.Append("\r\n" + "// 在此处放置用户代码以初始化页面");

                //strCodeForCs.Append("\r\n" + "$(\"#divPager\").load(\"../PubWebClass/pager\");");
                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj_Edit)
                {
                    Tuple<string, string> tup;
                    if (string.IsNullOrEmpty(objInfor.TabFeatureId4Ddl) == true)
                    {
                        tup = this.Gen_Vue_Ts_DefineVar4Ddl(strCodeForCs, objInfor, objVarManage);
                    }
                    else
                    {
                        tup = this.Gen_Vue_Ts_DefineVar4Ddl4TabFeature(strCodeForCs, objInfor, objVarManage);
                    }
                    //
                    string strVar4Cond = tup.Item1;
                    string strVar4Cond_2 = tup.Item2;
                    if (objInfor.CsType == "bool")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "clsCommFunc4Ctrl.BindDdl_TrueAndFalse(\"{0}\");",
                                 objInfor.CtrlId);
                    }
                    else
                    {
                        //if (objInfor.objFieldTab_CacheClassify() == null)
                        //{
                        strCodeForCs.AppendFormat("\r\n" + "await this.SetDdl_{0}InDiv({1});//{2}",
                                    objInfor.FldName,
                                    strVar4Cond_2,
                                    clsRegionTypeBL.GetNameByRegionTypeId_Cache(objInfor.RegionTypeId)
                                    );
                        //}
                        //else
                        //{
                        //    string strVar4CacheClassify = objInfor.objFieldTab_CacheClassify().PrivFuncName();
                        //    if (strVar4Cond == strVar4CacheClassify)
                        //    {
                        //        strVar4Cond_2 = "";
                        //    }
                        //    strCodeForCs.AppendFormat("\r\n" + "const {2} = await this.SetDdl_{1}InDiv({4} {5});//{3}",
                        //         objInfor.FldName,
                        //         objInfor.FldName,
                        //        objInfor.CtrlId,
                        //        clsRegionTypeBL.GetNameByRegionTypeId_Cache(objInfor.RegionTypeId),
                        //        objInfor.objFieldTab_CacheClassify().PrivFuncName(),
                        //        strVar4Cond_2);
                        //}
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
                FilePath = string.Format("../TS/L0_Entity/{0}/cls{1}EN", objFuncModule.FuncModuleEnName,
                   objViewInfoENEx.TabName)
            });


            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("cls{0}WApi", objViewInfoENEx.TabName),
                FilePath = string.Format("../TS/L3_ForWApi/{0}/cls{1}WApi", objFuncModule.FuncModuleEnName,
                    objViewInfoENEx.TabName)
            });


            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("cls{0}BL", objViewInfoENEx.TabName),
                FilePath = string.Format("../TS/L3_ForWApi/{0}/cls{1}WApi", objFuncModule.FuncModuleEnName,
                    objViewInfoENEx.TabName)
            });

            if (objViewInfoENEx.TabName != objViewInfoENEx.TabName_Out)
            {
                arrImportClass.Add(new ImportClass
                {
                    ClassName = string.Format("cls{0}EN", objViewInfoENEx.TabName_Out),
                    FilePath = string.Format("../TS/L0_Entity/{0}/cls{1}EN", objFuncModule.FuncModuleEnName,
                                objViewInfoENEx.TabName_Out)
                });
            }

            //List<string> arrTabId4Ddl = clsViewInfoBLEx.getRelaTabId4Ddl_Edit(objViewInfoENEx.ViewId, objViewInfoENEx.PrjId);
            //foreach (string strTabId in arrTabId4Ddl)
            //{
            //    if (strTabId == objViewInfoENEx.MainTabId) continue;
            //    clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId_Cache(strTabId, objViewInfoENEx.PrjId);

            //    clsFuncModule_AgcEN objFuncModule_AgcEN = clsFuncModule_AgcBL.GetObjByFuncModuleAgcId_Cache(objPrjTabEN.FuncModuleAgcId, objPrjTabEN.PrjId);
            //    arrImportClass.Add(new ImportClass
            //    {
            //        ClassName = string.Format("cls{0}EN", objPrjTabEN.TabName),
            //        FilePath = string.Format("../TS/L0_Entity/{0}/cls{1}EN", objFuncModule_AgcEN.FuncModuleEnName,
            //                 objPrjTabEN.TabName)
            //    });

            //    arrImportClass.Add(new ImportClass
            //    {
            //        ClassName = string.Format("cls{0}WApi", objPrjTabEN.TabName),
            //        FilePath = string.Format("../TS/L3_ForWApi/{0}/cls{1}WApi", objFuncModule_AgcEN.FuncModuleEnName,
            //                 objPrjTabEN.TabName)
            //    });

            //}


            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("arrSelectedKeys, clsCommFunc4Web", objViewInfoENEx.TabName),
                FilePath = string.Format("../TS/PubFun/clsCommFunc4Web", objFuncModule.FuncModuleEnName,
        objViewInfoENEx.TabName)
            });
            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("clsCommFunc4Ctrl", objViewInfoENEx.TabName),
                FilePath = string.Format("../TS/PubFun/clsCommFunc4Ctrl", objFuncModule.FuncModuleEnName,
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

            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("clsDateTime", objViewInfoENEx.TabName),
                FilePath = string.Format("../TS/PubFun/clsDateTime", objFuncModule.FuncModuleEnName,
objViewInfoENEx.TabName)
            });

            var objPrjTab_PageDispMode = clsPrjTabBLEx.GetObjByTabNameEx_Cache(objViewInfoENEx.PrjId, conPageDispMode._CurrTabName_S);
            if (objPrjTab_PageDispMode != null)
            {
                var objFuncModule_PageDispMode = clsFuncModule_AgcBL.GetObjByFuncModuleAgcId_Cache(objPrjTab_PageDispMode.FuncModuleAgcId, objPrjTab_PageDispMode.PrjId);
                arrImportClass.Add(new ImportClass
                {
                    ClassName = string.Format("enumPageDispMode", objViewInfoENEx.TabName),
                    FilePath = string.Format("../TS/L0_Entity/{0}/clsPageDispModeEN", objFuncModule_PageDispMode.FuncModuleEnName)
                });
            }

            List<string> arrTabName = new List<string>();
            foreach (ASPDropDownListEx objInfor in objViewInfoENEx.arrASPDropDownListObj)
            {
                if (arrTabName.Contains(objInfor.Ds_TabName) == true) continue;
                if (string.IsNullOrEmpty(objInfor.Ds_TabId) == true) continue;
                if (objInfor.RegionTypeId == enumRegionType.QueryRegion_0001) continue;
                if (string.IsNullOrEmpty(objInfor.TabFeatureId4Ddl) == false)
                {
                    var objTabFeature = clsTabFeatureBL.GetObjByTabFeatureId_Cache(objInfor.TabFeatureId4Ddl,
                         objInfor.PrjId);
                    clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId_Cache(objTabFeature.TabId, objViewInfoENEx.PrjId);

                    arrTabName.Add(objPrjTabEN.TabName);
                    var strEx = "";
                    if (objTabFeature.IsExtendedClass == true)
                    {
                        strEx = "Ex";
                    }
                    clsFuncModule_AgcEN objFuncModule_AgcEN = clsFuncModule_AgcBL.GetObjByFuncModuleAgcId_Cache(objPrjTabEN.FuncModuleAgcId, objPrjTabEN.PrjId);

                    arrImportClass.Add(new ImportClass
                    {
                        ClassName = string.Format("cls{0}{1}WApi", objPrjTabEN.TabName, strEx),
                        FilePath = string.Format("../TS/L3_ForWApi{2}/{0}/cls{1}{2}WApi", objFuncModule_AgcEN.FuncModuleEnName,
                              objPrjTabEN.TabName, strEx)
                    });

                    //objTabFeature.IsExtendedClass.TabId
                }
                else
                {
                    arrTabName.Add(objInfor.Ds_TabName);
                    clsPrjTabEN objPrjTabEN = clsPrjTabBL.GetObjByTabId_Cache(objInfor.Ds_TabId, objViewInfoENEx.PrjId);

                    clsFuncModule_AgcEN objFuncModule_AgcEN = clsFuncModule_AgcBL.GetObjByFuncModuleAgcId_Cache(objPrjTabEN.FuncModuleAgcId, objPrjTabEN.PrjId);
                    //      arrImportClass.Add(new ImportClass
                    //      {
                    //          ClassName = string.Format("cls{0}EN", objInfor.Ds_TabName),
                    //          FilePath = string.Format("../TS/L0_Entity/{0}/cls{1}EN", objFuncModule_AgcEN.FuncModuleEnName,
                    //objInfor.Ds_TabName)
                    //      });
                    arrImportClass.Add(new ImportClass
                    {
                        ClassName = string.Format("cls{0}WApi", objInfor.Ds_TabName),
                        FilePath = string.Format("../TS/L3_ForWApi/{0}/cls{1}WApi", objFuncModule_AgcEN.FuncModuleEnName,
                              objInfor.Ds_TabName)
                    });
                }
            }
            arrImportClass.Add(new ImportClass
            {
                ClassName = string.Format("cls{0}WApi", objViewInfoENEx.TabName_Out),
                FilePath = string.Format("../TS/L3_ForWApi/{0}/cls{1}WApi", objFuncModule.FuncModuleEnName,
                  objViewInfoENEx.TabName_Out)
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
            if (objViewInfoENEx.objViewRegion_Edit == null || objViewInfoENEx.objViewRegion_Edit.IsDispInViewInfo(objViewInfoENEx) == false)
            {
                return "";
            }
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
                //类名开始
                strCodeForCs.Append(clsCommonFunc4GC.GenUserInfoAndDate4WebApi(objViewInfoENEx.CurrUserName,
                    objViewInfoENEx));

                strCodeForCs.AppendFormat("\r\n" + "import $ from \"jquery\";");
                //strCodeForCs.AppendFormat("\r\n" + "//import * as QQ from \"q\";");

                List<ImportClass> arrImportClass = GetImportClassLst(objFuncModule);
                foreach (var objInFor in arrImportClass)
                {
                    strCodeForCs.AppendFormat("\r\n" + "import {{ {0} }} from \"{1}\";",
                      objInFor.ClassName,
                        objInFor.FilePath);
                }

                //strCodeForCs.Append("\r\n" + "/**");
                //strCodeForCs.Append("\r\n" + "* 宣布一个已经在存在的函数ShowDialog，用于显示对象框，");
                //strCodeForCs.Append("\r\n" + "* @param  strOpType：是操作类型，是三种类型之一：Add, Update, Detail");
                //strCodeForCs.Append("\r\n" + " **/");
                //strCodeForCs.AppendFormat("\r\n" + "declare function ShowDialog(strDialogName:string): void;", objViewInfoENEx.TabName_In);
                //strCodeForCs.Append("\r\n" + "/**");
                //strCodeForCs.Append("\r\n" + "* 宣布一个已经在存在的函数HideDialog，用于隐藏对象框，");
                //strCodeForCs.Append("\r\n" + " **/");
                //strCodeForCs.AppendFormat("\r\n" + "declare function HideDialog(strDialogName:string): void;", objViewInfoENEx.TabName_In);
                //strCodeForCs.Append("\r\n" + "/**");
                //strCodeForCs.Append("\r\n" + "* 宣布一个已经在其他地方定义存在的变量strUrl_Session_SetString，");
                //strCodeForCs.Append("\r\n" + "* 用于定义处理Session-设置String函数的地址");
                //strCodeForCs.Append("\r\n" + " **/");
                //strCodeForCs.Append("\r\n" + "declare var strUrl_Session_SetString:string;");
                //strCodeForCs.Append("\r\n" + "declare var strUrl_Session_GetString: string;");
                //strCodeForCs.Append("\r\n" + "/**");
                //strCodeForCs.Append("\r\n" + "* 宣布一个已经在其他地方定义存在的变量strCurrPrjId，");
                //strCodeForCs.Append("\r\n" + "* 用于定义当前工程Id");
                //strCodeForCs.Append("\r\n" + " **/");
                //strCodeForCs.Append("\r\n" + "declare var strCurrPrjId: string;");

                //strCodeForCs.Append("\r\n" + "declare var $;");


                strCodeForCs.AppendFormat("\r\n /** {0} 的摘要说明。其中Q代表查询,U代表修改",
                    objViewInfoENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + "export abstract class {0} ", objViewInfoENEx.ClsName);
                strCodeForCs.Append("\r\n" + "{");
                var objPageDispMode = clsPageDispModeBL.GetObjByPageDispModeId_Cache(objViewInfoENEx.objViewRegion_Edit.PageDispModeId);
                if (objPageDispMode == null)
                {
                    string strMsg = string.Format("生成界面:[{0}]编辑区，页面显示模式为空，请重新设置！(In {1})", 
                        objViewInfoENEx.ViewName, clsStackTrace.GetCurrClassFunction());
                    throw new Exception(strMsg);
                }
                strCodeForCs.Append("\r\n" + "public opType = \"\";");
                strCodeForCs.Append("\r\n" + "public keyId = \"\";");

                strCodeForCs.AppendFormat("\r\n" + "public static strPageDispModeId = \"{0}\";//{1}({2})", 
                    objPageDispMode.PageDispModeId, objPageDispMode.PageDispModeENName, objPageDispMode.PageDispModeName);

                strCodeForCs.AppendFormat("\r\n" + "public static objPage_Edit: {0};", objViewInfoENEx.ClsName);
                List<string> arrVarName = new List<string>();

                if (objViewInfoENEx.objCacheClassifyFld4View != null)
                {
                    var strVarName = string.Format("{0}_Cache", objViewInfoENEx.objCacheClassifyFld4View_TS.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "public static {0}_Cache = \"\";",
                        objViewInfoENEx.objCacheClassifyFld4View.FldName);
                    arrVarName.Add(strVarName);
                }
                if (objViewInfoENEx.objCacheClassifyFld4View2 != null)
                {
                    var strVarName = string.Format("{0}_Cache", objViewInfoENEx.objCacheClassifyFld4View2_TS.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "public static {0}_Cache = \"\";",
                        objViewInfoENEx.objCacheClassifyFld4View2.FldName);
                    arrVarName.Add(strVarName);
                }
                if (objPrefixField != null)
                {
                    var strVarName = string.Format("{0}4Prefix_Static", objPrefixField.FldName);
                    strCodeForCs.AppendFormat("\r\n" + "public static {0}4Prefix_Static = \"\";",
                        objPrefixField.FldName);
                    arrVarName.Add(strVarName);
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
                    var strVarName = string.Format("{0}_Static", x);
                    if (arrVarName.Contains(strVarName) == false)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "public static {0}: {1} = {2};",
                       strVarName,
                       objKeyField.TypeScriptType, strDefaValue);
                        arrVarName.Add(strVarName);
                    }
                });

                //处理PutData中的特殊字段值
                List<string> arrCtlType = new List<string>() { enumCtlTypeAbbr.CacheClassifyField_37, enumCtlTypeAbbr.ViewVariable_38 };
                var arrEditRegionFlds_Var = objViewInfoENEx.arrEditRegionFldSet.Where(x => arrCtlType.Contains(x.CtlTypeId));

                foreach (var objInFor in arrEditRegionFlds_Var)
                {
                    var strDefaValue = "\"\"";
                    var strVarName = "";
                    var strDataType = "string";
                    var objField = clsFieldTabBL.GetObjByFldId_Cache(objInFor.FldId, objInFor.PrjId);
                    if (objField.IsNumberType() == true)
                    {
                        strDataType = "number";
                        strDefaValue = "0";
                    }
                    switch (objInFor.CtlTypeId)
                    {
                        case enumCtlTypeAbbr.CacheClassifyField_37:

                            strVarName = string.Format("{0}_Cache", objInFor.FldName);
                            if (arrVarName.Contains(strVarName) == false)
                            {
                                strCodeForCs.AppendFormat("\r\n" + "public static {0}: {1} = {2};",
                               strVarName,
                               strDataType, strDefaValue);
                                arrVarName.Add(strVarName);
                            }
                            break;
                        case enumCtlTypeAbbr.ViewVariable_38:

                            strVarName = string.Format("{0}_Static", objInFor.FldName);
                            if (arrVarName.Contains(strVarName) == false)
                            {
                                strCodeForCs.AppendFormat("\r\n" + "public static {0}: {1} = {2};",
                               strVarName,
                               strDataType, strDefaValue);
                                arrVarName.Add(strVarName);
                            }
                            break;

                    }
                }



                //处理与下拉框相关的静态变量
                IEnumerable<ASPDropDownListEx> arrASPDropDownListObj_Edit = objViewInfoENEx.arrASPDropDownListObj.Where(x => x.RegionTypeId == enumRegionType.EditRegion_0003);
                try
                {
                    foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj_Edit)
                    {
                        var strVarName = "";
                        if (string.IsNullOrEmpty(objInfor.TabFeatureId4Ddl) == true)
                        {
                            continue;
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(objInfor.VarId_Cond1) == false)
                            {

                                var objField = clsFieldTabBL.GetObjByFldId_Cache(objInfor.FldId_Cond1, objInfor.PrjId);
                                string strDefaValue = objField.ObjDataTypeAbbr().GetInitValue(enumProgLangType.TypeScript_09);
                                if (string.IsNullOrEmpty(strDefaValue) == true) strDefaValue = "\"\"";

                                var objGCVariable = clsGCVariableBL.GetObjByVarId_Cache(objInfor.VarId_Cond1, objInfor.objEditRegionFldsEN.PrjId);
                                switch (objGCVariable.VarTypeId)
                                {
                                    case enumGCVariableType.GivingValue_0001:

                                        strVarName = string.Format("{0}_Giving", objField.FldName);

                                        if (arrVarName.Contains(strVarName) == true) break;
                                        strCodeForCs.AppendFormat("\r\n" + "public static {0}_Giving: {1} = {2};//定义下拉框条件给定值2",
                                       objField.FldName,
                                       objField.ObjDataTypeAbbr().TypeScriptType, strDefaValue);
                                        arrVarName.Add(strVarName);
                                        break;
                                    case enumGCVariableType.CacheClassifyField_0007:
                                        strVarName = string.Format("{0}_Cache", objField.FldName);

                                        if (arrVarName.Contains(strVarName) == true) break;
                                        strCodeForCs.AppendFormat("\r\n" + "public static {0}_Cache: {1} = {2};//定义下拉框条件变量1",
                                       objField.FldName,
                                       objField.ObjDataTypeAbbr().TypeScriptType, strDefaValue);
                                        arrVarName.Add(strVarName);
                                        break;
                                    case enumGCVariableType.StaticValuable_0006:
                                        strVarName = string.Format("{0}_Static", objField.FldName);
                                        if (arrVarName.Contains(strVarName) == true) break;
                                        strCodeForCs.AppendFormat("\r\n" + "public static {0}_Static: {1} = {2};//定义下拉框条件变量1",
                                       objField.FldName,
                                       objField.ObjDataTypeAbbr().TypeScriptType, strDefaValue);
                                        arrVarName.Add(strVarName);
                                        break;
                                    case enumGCVariableType.DefaultValue_0002:
                                        break;
                                    default:
                                        var objGCVariableType = clsGCVariableTypeBL.GetObjByVarTypeId_Cache(objGCVariable.VarTypeId);

                                        var strMsg = string.Format("在Switch中类型：[{0}({1})]没有被处理！(in {2})", objGCVariableType.VarTypeName, objGCVariableType.VarTypeId,
                        clsStackTrace.GetCurrClassFunction());
                                        throw new Exception(strMsg);
                                        //break;
                                }
                            }
                            if (string.IsNullOrEmpty(objInfor.VarId_Cond2) == false)
                            {
                                var objField = clsFieldTabBL.GetObjByFldId_Cache(objInfor.FldId_Cond2, objInfor.PrjId);
                                string strDefaValue = objField.ObjDataTypeAbbr().GetInitValue(enumProgLangType.TypeScript_09);
                                if (string.IsNullOrEmpty(strDefaValue) == true) strDefaValue = "\"\"";

                                var objGCVariable = clsGCVariableBL.GetObjByVarId_Cache(objInfor.VarId_Cond2, objInfor.objEditRegionFldsEN.PrjId);
                                switch (objGCVariable.VarTypeId)
                                {
                                    case enumGCVariableType.GivingValue_0001:

                                        strVarName = string.Format("{0}_Giving", objField.FldName);

                                        if (arrVarName.Contains(strVarName) == true) break;
                                        strCodeForCs.AppendFormat("\r\n" + "public static {0}_Giving: {1} = {2};//定义下拉框条件给定值2",
                                       objField.FldName,
                                       objField.ObjDataTypeAbbr().TypeScriptType, strDefaValue);
                                        arrVarName.Add(strVarName);
                                        break;
                                    case enumGCVariableType.CacheClassifyField_0007:

                                        strVarName = string.Format("{0}_Cache", objField.FldName);

                                        if (arrVarName.Contains(strVarName) == true) break;
                                        strCodeForCs.AppendFormat("\r\n" + "public static {0}_Cache: {1} = {2};//定义下拉框条件变量2",
                                       objField.FldName,
                                       objField.ObjDataTypeAbbr().TypeScriptType, strDefaValue);
                                        arrVarName.Add(strVarName);
                                        break;
                                    case enumGCVariableType.StaticValuable_0006:
                                        strVarName = string.Format("{0}_Static", objField.FldName);
                                        if (arrVarName.Contains(strVarName) == true) break;

                                        strCodeForCs.AppendFormat("\r\n" + "public static {0}_Static: {1} = {2};//定义下拉框条件变量2",
                                       objField.FldName,
                                       objField.ObjDataTypeAbbr().TypeScriptType, strDefaValue);
                                        arrVarName.Add(strVarName);
                                        break;
                                    default:
                                        var objGCVariableType = clsGCVariableTypeBL.GetObjByVarTypeId_Cache(objGCVariable.VarTypeId);

                                        var strMsg = string.Format("在Switch中类型：[{0}({1})]没有被处理！(in {2})", objGCVariableType.VarTypeName, objGCVariableType.VarTypeId,
    clsStackTrace.GetCurrClassFunction());
                                        throw new Exception(strMsg);
                                        //break;
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


                var arrEditRegionFlds = objViewInfoENEx.arrEditRegionFldSet.Where(x => x.CtlTypeId == enumCtlTypeAbbr.ViewVariable_38);
                if (arrEditRegionFlds.Count() > 0)
                {

                    foreach (var objInFor in arrEditRegionFlds)
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

                            strCodeForCs.AppendFormat("\r\n" + " public static {0}: {1} = {2};//定义编辑区默认字段变量",

                                    strVarName,
                                    objInFor.ObjFieldTabENEx.TypeScriptType,
                                    strInitValue);
                            arrVarName.Add(strVarName);
                        }
                    }
                }

                //strCodeForCs.Append("\r\n" + "private strInfo = \"\";");
                //strCodeForCs.Append("\r\n" + "private strWhereCond = \"\";");
                strCodeForCs.AppendFormat("\r\n" + "public obj{0}: cls{0}EN;", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "protected iShowList: IShowList;");

                //strCodeForCs.Append("\r\n" + "public mstrListDiv = \"divDataLst\";");
                strCodeForCs.Append("\r\n" + "public bolIsLoadEditRegion = false;  //记录是否导入编辑区的变量");
                
                strCodeForCs.Append("\r\n" + "public divName4Edit = \"divEdit\";  //编辑区的Id");
                
                strCodeForCs.Append("\r\n" + "constructor(objShowList: IShowList) {");
                strCodeForCs.Append("\r\n" + "this.iShowList = objShowList;");
                strCodeForCs.AppendFormat("\r\n" + "{0}.objPage_Edit = this;", objViewInfoENEx.ClsName);
                strCodeForCs.AppendFormat("\r\n" + "this.obj{0} = new cls{0}EN();", objViewInfoENEx.TabName);

                strCodeForCs.Append("\r\n" + "}");

                

                strCodeForCs.Append("\r\n" + "");
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
                strFuncName = "clsPubFun4GC.Gen_Vue_Ts_ControlProperty";
                clsPubFun4GC.Gen_WApi_Ts_ControlProperty(strCodeForCs, arrPropertyDef4GC, "this.divName4Edit");
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
            strCodeForCs.Append("\r\n" + " **/");
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

                            strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").attr(\"checked\", value.toString());", x.CtrlId);
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
                strCodeForCs.Append("\r\n" + " **/");
                string strIsStatic = "";
                if (x.IsStatic) strIsStatic = "static";
                switch (x.OperateType)
                {
                    case "get":
                        strCodeForCs.AppendFormat("\r\n" + "public {3} {0} {1}():{2} {{", x.OperateType, x.PropertyName, x.DataType, strIsStatic);
                        strCodeForCs.Append("\r\n" + "const objDiv = $(`#${this.divName4Edit}`);");
                        //strCodeForCs.Append("\r\n" + "if (objDiv.length == 0)");
                        //strCodeForCs.Append("\r\n" + "{");
                        //strCodeForCs.Append("\r\n" + "const strMsg = Format(\"层:{0}不存在, 请检查！\", this.divName4Edit);");
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
                                strCodeForCs.AppendFormat("\r\n" + "    clsCommFunc4Web.CheckControlExist({1}, \"input\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"input[id ^= '{0}']\");", x.CtrlId);
                                strCodeForCs.Append("\r\n" + "return objDiv.find(strId).prop(\"checked\");");

                                //strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").prop(\"checked\");", x.CtrlId);
                                break;
                            case "input":
                            case "TextBox":
                                strCodeForCs.AppendFormat("\r\n" + "    clsCommFunc4Web.CheckControlExist({1}, \"input\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"input[id ^= '{0}']\");", x.CtrlId);

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
                                break;
                            case "button":
                                strCodeForCs.AppendFormat("\r\n" + "    clsCommFunc4Web.CheckControlExist({1}, \"button\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"button[id ^= '{0}']\");", x.CtrlId);
                                strCodeForCs.AppendFormat("\r\n" + " return objDiv.find(strId).html();", x.CtrlId, x.PropertyName);

                                //strCodeForCs.AppendFormat("\r\n" + "return $(\"#{0}\").html();", x.CtrlId);
                                break;
                            case "dropdownlist":
                            case "DropDownList":
                                strCodeForCs.AppendFormat("\r\n" + "    clsCommFunc4Web.CheckControlExist({1}, \"select\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"select[id ^= '{0}']\");", x.CtrlId);

                                if (x.DataType == "boolean")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + " if (objDiv.find(strId).val() == \"0\") return false;", x.CtrlId);
                                    //                                    strCodeForCs.AppendFormat("\r\n" + "if ($(\"#{0}\").val() == \"0\") return false;", x.CtrlId);
                                    strCodeForCs.AppendFormat("\r\n" + " return objDiv.find(strId).val();", x.CtrlId, x.PropertyName);

                                }
                                else if (x.DataType == "number")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + " if (objDiv.find(strId).val() == \"0\") return 0;", x.CtrlId);
                                    strCodeForCs.AppendFormat("\r\n" + " const strValue = objDiv.find(strId).val();", x.CtrlId, x.PropertyName);
                                    strCodeForCs.Append("\r\n" + " return Number(strValue);");

                                    //strCodeForCs.AppendFormat("\r\n" + "if ($(\"#{0}\").val() == \"0\") return 0;", x.CtrlId);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + " if (objDiv.find(strId).val() == \"0\") return \"\";", x.CtrlId);
                                    strCodeForCs.AppendFormat("\r\n" + " return objDiv.find(strId).val();", x.CtrlId, x.PropertyName);
                                    //strCodeForCs.AppendFormat("\r\n" + "if ($(\"#{0}\").val() == \"0\") return \"\";", x.CtrlId);
                                }

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
                        strCodeForCs.Append("\r\n" + "const objDiv = $(`#${this.divName4Edit}`);");
                        //strCodeForCs.Append("\r\n" + "if (objDiv.length == 0)");
                        //strCodeForCs.Append("\r\n" + "{");
                        //strCodeForCs.Append("\r\n" + "const strMsg = Format(\"层:{0}不存在, 请检查！\", this.divName4Edit);");
                        //strCodeForCs.Append("\r\n" + "alert(strMsg);");
                        //strCodeForCs.Append("\r\n" + "return;");
                        //strCodeForCs.Append("\r\n" + "}");

                        switch (x.ControlType)
                        {
                            case "checkbox":
                            case "CheckBox":
                                strCodeForCs.AppendFormat("\r\n" + "    clsCommFunc4Web.CheckControlExist({1}, \"input\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                //$('#div1').find('span[id^="s1"]').html("div1-s1");
                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"input[id ^= '{0}']\");", x.CtrlId);
                                strCodeForCs.Append("\r\n" + " objDiv.find(strId).attr(\"checked\", value);");
                                //strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").attr(\"checked\", value);", x.CtrlId);
                                break;
                            case "input":
                            case "TextBox":
                                strCodeForCs.AppendFormat("\r\n" + "    clsCommFunc4Web.CheckControlExist({1}, \"input\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"input[id ^= '{0}']\");", x.CtrlId);
                                strCodeForCs.Append("\r\n" + " objDiv.find(strId).val(value);");
                                //strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").val(value);", x.CtrlId);
                                break;
                            case "button":
                                strCodeForCs.AppendFormat("\r\n" + "    clsCommFunc4Web.CheckControlExist({1}, \"button\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"button[id ^= '{0}']\");", x.CtrlId);
                                strCodeForCs.Append("\r\n" + " objDiv.find(strId).html(value);");
                                //strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").html(value);", x.CtrlId);
                                break;
                            case "Label":
                                strCodeForCs.AppendFormat("\r\n" + "    clsCommFunc4Web.CheckControlExist({1}, \"label\", \"{0}\");", x.CtrlId, x.ParentDivName);

                                strCodeForCs.AppendFormat("\r\n" + "const strId = Format(\"label[id ^= '{0}']\");", x.CtrlId);
                                strCodeForCs.Append("\r\n" + " objDiv.find(strId).html(value);");
                                //strCodeForCs.AppendFormat("\r\n" + "$(\"#{0}\").html(value);", x.CtrlId);
                                break;
                            case "dropdownlist":
                            case "DropDownList":
                                strCodeForCs.AppendFormat("\r\n" + "    clsCommFunc4Web.CheckControlExist({1}, \"select\", \"{0}\");", x.CtrlId, x.ParentDivName);

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


        public string Gen_Vue_Ts_SetKeyReadOnly()
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
                        strCodeForCs.Append("\r\n" + "/**");
                        strCodeForCs.Append("\r\n" + "*  在用户自定义控件中，设置关键字的值，是否只读");
                        strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                        strCodeForCs.Append("\r\n" + " * @param bolReadonly:是否只读");
                        strCodeForCs.Append("\r\n" + " **/");
                        strCodeForCs.Append("\r\n" + "public SetKeyReadOnly(bolReadonly:boolean)");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.SetKeyReadOnly.name;",
objViewInfoENEx.TabName, objKeyField.FldName);
                        //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

                        //strCodeForCs.AppendFormat("\r\n" + "$('#{0}').prop['ReadOnly'] = bolReadonly;", objEditRegionFldsEx.CtrlId);
                        strCodeForCs.AppendFormat("\r\n" + "clsCommFunc4Ctrl.setInputReadOnly(this.divName4Edit, '{0}', bolReadonly);", objEditRegionFldsEx.CtrlId);
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
                strCodeForCs.Append("\r\n" + "/**");
                strCodeForCs.Append("\r\n" + " * 清除用户自定义控件中，所有控件的值");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "public Clear()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.Clear.name;",
objViewInfoENEx.TabName, objKeyField.FldName);
                //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
               
                    if (objEditRegionFldsEx.InUse == false) continue;

                    if (objEditRegionFldsEx.ObjFieldTabENEx == null) continue;
                    if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                    && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
                    {
                        continue;
                    }
                    if (objEditRegionFldsEx.CtlTypeId == enumCtlTypeAbbr.ViewVariable_38
                        || objEditRegionFldsEx.CtlTypeId == enumCtlTypeAbbr.CacheClassifyField_37)
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
                                Comment = string.Format("{0} (Used In {1})", objEditRegionFldsEx.ObjFieldTabENEx.Caption,
                                        "Clear()"),
                                DataType = objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
                                ParentDivName = "this.divName4Edit"
                            });
                        
                        if (this.objViewInfoENEx.objCodeType == null)
                        {
                            this.objViewInfoENEx.objCodeType = clsCodeTypeBL.GetObjByCodeTypeId_Cache(this.objViewInfoENEx.CodeTypeId);
                        }
                        string strInitValue = objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.GetInitValue4Var(this.objViewInfoENEx.objCodeType.ProgLangTypeId);

                        switch (objEditRegionFldsEx.objCtlTypeAbbr.CtlTypeName)
                        {
                            case "Button":
                                break;
                            case "CheckBox":
                                if (objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue.Trim() == "")
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "this.{0} = false;",
                                    objEditRegionFldsEx.PropertyName());
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "this.{0} = {1};",
                                    objEditRegionFldsEx.PropertyName(),
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
                                strCodeForCs.AppendFormat("\r\n" + "$('#{0} option[0]').attr(\"selected\", \"true\");",
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
                                    objEditRegionFldsEx.PropertyName(), strInitValue);
                                }
                                else
                                {
                                    strCodeForCs.AppendFormat("\r\n" + "this.{0} = \"{1}\";",
                                        objEditRegionFldsEx.PropertyName(), objEditRegionFldsEx.ObjFieldTabENEx.DefaultValue);
                                }

                                break;
                            default:
                                strCodeForCs.AppendFormat("\r\n" + "this.{0} = {1};",
                                 objEditRegionFldsEx.PropertyName(), strInitValue);
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

        public string Gen_Vue_Ts_AddNewRecord()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                //生成的插入记录准备过程代码for C#

                strCodeForCs.Append("\r\n /** 为插入记录做准备工作");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + "public async AddNewRecord()",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.AddNewRecord.name;",
objViewInfoENEx.TabName, objKeyField.FldName);
                //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

                List<string> arrKey = new List<string>() { enumPrimaryType.Identity_02,
                enumPrimaryType.StringAutoAddPrimaryKey_03,
                enumPrimaryType.StringAutoAddPrimaryKeyWithPrefix_06,
                enumPrimaryType.PrimaryKey_01 };
               
                if (arrKey.Contains(objKeyField.PrimaryTypeId) == false)
                {
                    if (objViewInfoENEx.arrEditRegionFldSet4InUse.Where(x => x.FldName == objKeyField.ObjFieldTabENEx.FldName).Count() > 0)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "this.SetKeyReadOnly(false);",
                    objViewInfoENEx.TabName);
                    }
                }

                strCodeForCs.AppendFormat("\r\n" + "this.btnSubmit_{0} = \"确认添加\";", objViewInfoENEx.TabName_In);
                strCodeForCs.AppendFormat("\r\n" + "this.btnCancel_{0} = \"取消添加\";", objViewInfoENEx.TabName_In);

                arrPropertyDef4GC.Add(new clsPropertyDef4GC
                {
                    OperateType = "set",
                    ControlType = "button",
                    CtrlId = string.Format("btnSubmit_{0}", objViewInfoENEx.TabName_In),
                    PropertyName = string.Format("btnSubmit_{0}", objViewInfoENEx.TabName_In),
                    Comment = "设置确定按钮的标题(Used In AddNewRecord())",
                    DataType = "string"
                });

                arrPropertyDef4GC.Add(new clsPropertyDef4GC
                {
                    OperateType = "set",
                    ControlType = "button",
                    CtrlId = string.Format("btnCancel_{0}", objViewInfoENEx.TabName_In),
                    PropertyName = string.Format("btnCancel_{0}", objViewInfoENEx.TabName_In),
                    Comment = "设置取消按钮的标题(Used In AddNewRecord())",
                    DataType = "string"
                });

                strCodeForCs.Append("\r\n" + "this.Clear();");

                //获取最大值
                strCodeForCs.AppendFormat("\r\n" + "//wuc{0}B1.{1} = cls{0}BL.GetMaxStrId_S();",
                objViewInfoENEx.TabName, objKeyField.ObjFieldTabENEx.PropertyName(), objKeyField.ObjFieldTabENEx.FldLength);

                if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKey_03)
                {

                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "const returnString = await {0}_GetMaxStrIdAsync();",
                        objViewInfoENEx.TabName);

                    strCodeForCs.Append("\r\n" + "if (returnString == \"\")");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"获取表{0}的最大关键字为空，不成功，请检查!\");",
                        objViewInfoENEx.TabName);

                    strCodeForCs.Append("\r\n" + "//显示信息框");
                    strCodeForCs.Append("\r\n" + "alert(strInfo);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "else");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "$('#txt{0}').val(returnString);", objKeyField.FldName);
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch(e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "const strMsg = Format(\"获取表关键字的最大值不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");

                }
                else if (objKeyField.PrimaryTypeId == enumPrimaryType.StringAutoAddPrimaryKeyWithPrefix_06)
                {
                    
                        if (objPrefixField == null)
                        {
                        strCodeForCs.AppendFormat("\r\n // 表:{0}的主键是前缀自增，但该表中没有一个相关的前缀字段。请检查！(In {1})",
                                objViewInfoENEx.TabName, clsStackTrace.GetCurrClassFunction());
               
                        }
                    
                    strCodeForCs.Append("\r\n" + "try");
                    strCodeForCs.Append("\r\n" + "{");
                    if (objPrefixField == null)
                    {
                        strCodeForCs.AppendFormat("\r\n // 表:{0}的主键是前缀自增，但该表中没有一个相关的前缀字段。请检查！(In {1})",
                                objViewInfoENEx.TabName, clsStackTrace.GetCurrClassFunction());

                        strCodeForCs.AppendFormat("\r\n" + "const responseText = await {0}_GetMaxStrIdByPrefixAsync(\"\");",
                            objViewInfoENEx.TabName);
                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "const returnString = await {0}_GetMaxStrIdByPrefixAsync({1}.{2}4Prefix_Static);",
                            objViewInfoENEx.TabName, objViewInfoENEx.ClsName, objPrefixField.FldName);
                    }

                    strCodeForCs.Append("\r\n" + "if (returnString == \"\")");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"获取表{0}的最大关键字为空，不成功，请检查!\");",
                        objViewInfoENEx.TabName);

                    strCodeForCs.Append("\r\n" + "//显示信息框");
                    strCodeForCs.Append("\r\n" + "alert(strInfo);");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "else");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "$('#txt{0}').val(returnString);", objKeyField.FldName);
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "catch(e)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.Append("\r\n" + "const strMsg = Format(\"获取表关键字的最大值不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "}");

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


        //生成插入记录准备过程代码
        public string Gen_Vue_Ts_AddNewRecordWithMaxId()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                //生成的插入记录准备过程代码for C#

                strCodeForCs.Append("\r\n /** 为插入记录做准备工作");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + "public AddNewRecordWithMaxId()",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.AddNewRecordWithMaxId.name;",
objViewInfoENEx.TabName, objKeyField.FldName);
                //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

                if (objKeyField.PrimaryTypeId != clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY && objKeyField.PrimaryTypeId != enumPrimaryType.StringAutoAddPrimaryKey_03)
                {
                    if (objViewInfoENEx.arrEditRegionFldSet4InUse.Where(x => x.FldName == objKeyField.ObjFieldTabENEx.FldName).Count() > 0)
                    {
                        strCodeForCs.AppendFormat("\r\n" + "this.SetKeyReadOnly(false);",
                        objViewInfoENEx.TabName);
                    }
                }

                strCodeForCs.AppendFormat("\r\n" + "this.btnSubmit_{0} = \"确认添加\";", objViewInfoENEx.TabName_In);
                strCodeForCs.AppendFormat("\r\n" + "this.btnCancel_{0} = \"取消添加\";", objViewInfoENEx.TabName_In);

                arrPropertyDef4GC.Add(new clsPropertyDef4GC
                {
                    OperateType = "set",
                    ControlType = "button",
                    CtrlId = string.Format("btnSubmit_{0}", objViewInfoENEx.TabName_In),
                    PropertyName = string.Format("btnSubmit_{0}", objViewInfoENEx.TabName_In),
                    Comment = "设置确定按钮的标题(Used In AddNewRecordWithMaxId())",
                    DataType = "string"
                });

                arrPropertyDef4GC.Add(new clsPropertyDef4GC
                {
                    OperateType = "set",
                    ControlType = "button",
                    CtrlId = string.Format("btnCancel_{0}", objViewInfoENEx.TabName_In),
                    PropertyName = string.Format("btnCancel_{0}", objViewInfoENEx.TabName_In),
                    Comment = "设置取消按钮的标题(Used In AddNewRecordWithMaxId())",
                    DataType = "string"
                });

                strCodeForCs.Append("\r\n" + "this.Clear();");

                //获取最大值
                strCodeForCs.AppendFormat("\r\n" + "//wuc{0}B1.{1} = cls{0}BL.GetMaxStrId_S();",
                objViewInfoENEx.TabName, objKeyField.ObjFieldTabENEx.PropertyName(), objKeyField.ObjFieldTabENEx.FldLength);

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
        public string Gen_Vue_Ts_btnOKUpd_Click()
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();

            try
            {

                strCodeForCs.Append("\r\n /** 函数功能:事件函数,当单击<确定修改>时发生的事件函数,");
                strCodeForCs.Append("\r\n * 具体功能为把界面内容同步数据库中,把界面内容保存到数据库中");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.Append("\r\n" + "public async btnSubmit_Click()");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnSubmit_Click.name;",
objViewInfoENEx.TabName, objKeyField.FldName);
                strCodeForCs.AppendFormat("\r\n" + "const strCommandText: string = this.btnSubmit_{0};", objViewInfoENEx.TabName_In);
                strCodeForCs.Append("\r\n" + "let returnBool: boolean;");
                strCodeForCs.Append("\r\n" + "let strMsg = \"\";");
                strCodeForCs.Append("\r\n" + "let strInfo = \"\";");

                clsPropertyDef4GC objPropertyDef4GC = new clsPropertyDef4GC
                {
                    OperateType = "get",
                    ControlType = "button",
                    CtrlId = string.Format("btnSubmit_{0}", objViewInfoENEx.TabName_In),
                    PropertyName = string.Format("btnSubmit_{0}", objViewInfoENEx.TabName_In),
                    Comment = "获取按钮的标题",
                    DataType = "string",
                    ParentDivName = "this.divName4Edit"
                };
                arrPropertyDef4GC.Add(objPropertyDef4GC);

                arrPropertyDef4GC.Add(new clsPropertyDef4GC
                {
                    OperateType = "get",
                    ControlType = "input",
                    CtrlId = "hidOpType",
                    PropertyName = "OpType",
                    Comment = "获取操作类型：Add||Update||Detail",
                    DataType = "string",
                    ParentDivName = "this.divName4Edit"
                });

                strCodeForCs.Append("\r\n" + "try {");
                //strCodeForCs.AppendFormat("\r\n" + "cls{0}EN obj{1}EN;",
                //objViewInfoENEx.TabName, objViewInfoENEx.TabName);
            
                strCodeForCs.Append("\r\n" + "switch(strCommandText)");
                strCodeForCs.Append("\r\n" + "{");
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveAdd)
                {

                    strCodeForCs.Append("\r\n" + "case \"添加\":");
                    strCodeForCs.AppendFormat("\r\n" + "this.btnSubmit_{0} = \"确认添加\";", objViewInfoENEx.TabName_In);
                    strCodeForCs.AppendFormat("\r\n" + "this.btnCancel_{0} = \"取消添加\";", objViewInfoENEx.TabName_In);

                    strCodeForCs.AppendFormat("\r\n" + "await this.AddNewRecord();",
                    objViewInfoENEx.TabName);
                    strCodeForCs.Append("\r\n" + "break;				");
                    strCodeForCs.Append("\r\n" + "case \"确认添加\":");
                    strCodeForCs.Append("\r\n" + "//这是一个单表的插入的代码,由于逻辑层太简单,");
                    strCodeForCs.Append("\r\n" + "//就把逻辑层合并到控制层,");
                    strCodeForCs.Append("\r\n" + "if (this.OpType == \"AddWithMaxId\")");
                    strCodeForCs.Append("\r\n" + "{");
                    if (objKeyField.CsType != "string")
                    {
                        strCodeForCs.AppendFormat("\r\n" + "//const returnKeyId = await this.AddNewRecordWithMaxIdSave();",
                              objViewInfoENEx.TabName);
                        //strCodeForCs.Append("\r\n" + "//const returnKeyId: string = <string>jsonData;");
                        strCodeForCs.Append("\r\n" + "//if (IsNullOrEmpty(returnKeyId) == false)");
                        strCodeForCs.Append("\r\n" + "//{");
                        strCodeForCs.AppendFormat("\r\n" + "//HideDialog_{0}();", objViewInfoENEx.TabName_In);

                        strCodeForCs.AppendFormat("\r\n" + "//this.iShowList.BindGv_Cache(cls{0}EN._CurrTabName, \"\");", objViewInfoENEx.TabName_Out);

                        strCodeForCs.Append("\r\n" + "//}");
                        //strCodeForCs.Append("\r\n" + "//});");

                    }
                    else
                    {
                        strCodeForCs.AppendFormat("\r\n" + "const returnKeyId = await this.AddNewRecordWithMaxIdSave();",
                              objViewInfoENEx.TabName);
                        //strCodeForCs.Append("\r\n" + "const returnKeyId: string = <string>jsonData;");
                        strCodeForCs.Append("\r\n" + "if (IsNullOrEmpty(returnKeyId) == false)");
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "if ({0}.strPageDispModeId == enumPageDispMode.PopupBox_01)",
     objViewInfoENEx.ClsName);
                        strCodeForCs.Append("\r\n" + "{");
                        strCodeForCs.AppendFormat("\r\n" + "this.HideDialog_{0}();", objViewInfoENEx.TabName_In);
                        strCodeForCs.Append("\r\n" + "}");
                        //strCodeForCs.AppendFormat("\r\n" + "this.BindGv_{0}{1}();", objViewInfoENEx.TabName_Out, objViewInfoENEx.IsUseCache4List?"_Cache":"");

                        iShowList_BindGv(strCodeForCs);

                        strCodeForCs.Append("\r\n" + "}");
                        //strCodeForCs.Append("\r\n" + "});");
                    }
                    strCodeForCs.Append("\r\n" + "}");
                    strCodeForCs.Append("\r\n" + "else");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "returnBool = await this.AddNewRecordSave();",
                          objViewInfoENEx.TabName);
                    //strCodeForCs.Append("\r\n" + "const returnBool: boolean = jsonData;");
                    strCodeForCs.Append("\r\n" + "if (returnBool == true)");
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.strPageDispModeId == enumPageDispMode.PopupBox_01)",
                    objViewInfoENEx.ClsName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "this.HideDialog_{0}();", objViewInfoENEx.TabName_In);
                    strCodeForCs.Append("\r\n" + "}");
                    //strCodeForCs.AppendFormat("\r\n" + "this.BindGv_{0}{1}();", objViewInfoENEx.TabName_Out, objViewInfoENEx.IsUseCache4List ? "_Cache" : "");
                    iShowList_BindGv(strCodeForCs);

                    strCodeForCs.Append("\r\n" + "}");
                    //strCodeForCs.Append("\r\n" + "});");
                    strCodeForCs.Append("\r\n" + "}");

                    strCodeForCs.Append("\r\n" + "break;");
                }
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate)
                {
                    strCodeForCs.Append("\r\n" + "case \"确认修改\":");
                    strCodeForCs.Append("\r\n" + "//这是一个单表的修改的代码,由于逻辑层太简单,");
                    //strCodeForCs.AppendFormat("\r\n" + "obj{0}EN = (cls{0}EN) Session[\"obj{0}EN\"];",
                    //objViewInfoENEx.TabName);
                    strCodeForCs.AppendFormat("\r\n" + "returnBool = await this.UpdateRecordSave();",
                    objViewInfoENEx.TabName);
                    //strCodeForCs.Append("\r\n" + "const returnBool: boolean = jsonData;");
                    strCodeForCs.Append("\r\n" + "strInfo = returnBool ? \"修改成功！\" : \"修改不成功！\";");
                    strCodeForCs.AppendFormat("\r\n" + "strInfo += \"(In {0}.btnSubmit_Click)\";",
                        objViewInfoENEx.ClsName);
                    //strCodeForCs.Append("\r\n" + "$('#l1blResult51').val(strInfo);");
                    strCodeForCs.Append("\r\n" + "//显示信息框");
                    strCodeForCs.Append("\r\n" + "console.log(strInfo);");
                    strCodeForCs.Append("\r\n" + "alert(strInfo);");

                    strCodeForCs.Append("\r\n" + "if (returnBool == true)");
                    strCodeForCs.Append("\r\n" + "{");

                    strCodeForCs.AppendFormat("\r\n" + "if ({0}.strPageDispModeId == enumPageDispMode.PopupBox_01)",
         objViewInfoENEx.ClsName);
                    strCodeForCs.Append("\r\n" + "{");
                    strCodeForCs.AppendFormat("\r\n" + "this.HideDialog_{0}();", objViewInfoENEx.TabName_In);
                    strCodeForCs.Append("\r\n" + "}");
                    //strCodeForCs.AppendFormat("\r\n" + "this.BindGv_{0}{1}();", objViewInfoENEx.TabName_Out, objViewInfoENEx.IsUseCache4List ? "_Cache" : "");
                    iShowList_BindGv(strCodeForCs);

                    strCodeForCs.Append("\r\n" + "}");
                    //strCodeForCs.Append("\r\n" + "});");
                    strCodeForCs.Append("\r\n" + "break;");
                    strCodeForCs.Append("\r\n" + "default:");
                    strCodeForCs.Append("\r\n" + "strMsg = Format(\"strCommandText:{0}在switch中没有处理！(In btnSubmit_Click())\", strCommandText);");
                    strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                    strCodeForCs.Append("\r\n" + "alert(strMsg);");
                    strCodeForCs.Append("\r\n" + "break;");
                }
                strCodeForCs.Append("\r\n" + "}");

                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "catch (e)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "strMsg = Format(\"(errid: WiTsCs0033)在保存记录时({0})时出错!请联系管理员!{1}.(in {2}.{3})\", strCommandText, e, this.constructor.name, strThisFuncName);");
                strCodeForCs.Append("\r\n" + "console.error(strMsg);");
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

        public string Gen_Vue_Ts_ShowTabObj(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 显示{0}对象的所有属性值");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());

            strCodeForCs.Append("\r\n * @param divContainer\">显示容器</param>");
            strCodeForCs.AppendFormat("\r\n * @param obj{0}\">需要显示的对象</param>",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.AppendFormat("\r\n" + "public Show{0}Obj(divContainer: string, obj{0}: cls{0}EN) ",
                objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.Show{0}Obj.name;", objViewInfoENEx.TabName);
            
            //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

            strCodeForCs.Append("\r\n" + "var o = document.getElementById(divContainer);");
            strCodeForCs.Append("\r\n" + "if (o == null)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(Format(\"{0}不存在！\",divContainer));");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "const sstrKeys = clsCommFunc4Web.GetObjKeys(obj{0});",
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

        public string Gen_Vue_Ts_UpdateRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 根据关键字获取相应的记录的对象");

            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @param sender\">参数列表</param>");
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.AppendFormat("\r\n" + "public async UpdateRecord({0}: {1}):Promise<boolean> ",
                 objKeyField.PrivFuncName,
                  objKeyField.TypeScriptType);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.UpdateRecord.name;",
objViewInfoENEx.TabName, objKeyField.FldName);
            
            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "set",
                ControlType = "button",
                CtrlId = string.Format("btnSubmit_{0}", objViewInfoENEx.TabName_In),
                PropertyName = string.Format("btnSubmit_{0}", objViewInfoENEx.TabName_In),
                Comment = "设置确定按钮的标题(Used In UpdateRecord())",
                DataType = "string"
            });

            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "set",
                ControlType = "button",
                CtrlId = string.Format("btnCancel_{0}", objViewInfoENEx.TabName_In),
                PropertyName = string.Format("btnCancel_{0}", objViewInfoENEx.TabName_In),
                Comment = "设置取消按钮的标题(Used In UpdateRecord())",
                DataType = "string"
            });

            //strCodeForCs.AppendFormat("\r\n" + "//$('#hidKeyId').val({0});", objKeyField.PrivFuncName);
            if (objKeyField.IsNumberType())
            {
                strCodeForCs.AppendFormat("\r\n" + "this.keyId = {0}.toString();", objKeyField.PrivFuncName);
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "this.keyId = {0};", objKeyField.PrivFuncName);
            }
            
            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            //GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
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

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");


            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN = await {0}_GetObjBy{1}Async({2});",
                objViewInfoENEx.TabName,
                objKeyField.FldName,
                objKeyField.PrivFuncName);

            strCodeForCs.AppendFormat("\r\n" + "this.obj{0} = obj{0}EN;", objViewInfoENEx.TabName);

            //strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"根据关键字:[{{0}}]获取对象：{{1}}!\", strKeyId, obj{0}EN.{1});",
            //    objViewInfoENEx.TabName,
            //    objKeyField.FldName);
            //strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            //strCodeForCs.Append("\r\n" + "//显示信息框");
            //strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.AppendFormat("\r\n" + "await this.GetDataFrom{0}Class(obj{0}EN);",
                objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "console.log(\"完成UpdateRecord!\");", objViewInfoENEx.TabName_Out);
            strCodeForCs.Append("\r\n" + "return true;");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"根据关键字获取相应的记录的对象不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return false;");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }
        Func<clsEditRegionFldsENEx, ASPDropDownListEx> GetDdlObj = obj => clsASPDropDownListBLEx.GetDropDownLst_Asp(obj, new clsGetTabFieldObj());

        public string Gen_Vue_Ts_SetBindDdl()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {
                List<string> arrDropDownTypeLst = new List<string> { enumCtlTypeAbbr.DropDownList_06, enumCtlTypeAbbr.DropDownList_Bool_18 };
                IEnumerable<clsEditRegionFldsENEx> arrERF4DropDownLst = objViewInfoENEx.arrEditRegionFldSet4InUse.Where(x => arrDropDownTypeLst.Contains(x.CtlTypeId));
                IEnumerable<ASPDropDownListEx> arrASPDropDownListObj = arrERF4DropDownLst.Select(GetDdlObj);
                var objImportClass = new ImportClass();
                foreach (ASPDropDownListEx objInfor in arrASPDropDownListObj)
                {
                    if (objInfor.CsType == "bool")
                    {
                        strCodeForCs.AppendLine(objInfor.GC_SetBindDdl4BoolInDiv_TS());
                    }
                    else if (string.IsNullOrEmpty( objInfor.TabFeatureId4Ddl) == false)
                    {
                        objInfor.DivName = "this.divName4Edit";
                        strCodeForCs.Append(objInfor.GC_SetBindDdlInDiv_TS4TabFeature(clsCommonFunc4GC.AddImportClass));

                    }
                    else
                    {
                        //strCodeForCs.Append(objInfor.G1C_SetBindDdl_TS());
                        objInfor.DivName = "this.divName4Edit";
                        strCodeForCs.Append(objInfor.GC_SetBindDdl_TSInDiv3B());
                    }
                }
            }
            catch (Exception ex)
            {
                clsEntityBase.LogErrorS(ex, "");
                throw new Exception(ex.Message, ex);
            }
            return strCodeForCs.ToString();
        }


        public string Gen_Vue_Ts_SelectRecord(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** ");
            strCodeForCs.Append("\r\n " + "* 根据关键字选择相应的记录");

            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n * @param sender\">参数列表</param>");
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.AppendFormat("\r\n" + "public async SelectRecord({0}: {1}) ",
                 objKeyField.PrivFuncName,
                  objKeyField.TypeScriptType);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.SelectRecord.name;",
objViewInfoENEx.TabName, objKeyField.FldName);

            //strCodeForCs.AppendFormat("\r\n" + "$('#hidDivName').val(\"div{0}\");", objvFunction4GeneCodeEN.FuncName4Code);

            //GC_GetInputValue4Para_TS(objvFunction4GeneCodeEN, strCodeForCs);
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
            strCodeForCs.AppendFormat("\r\n" + "clsCommFunc4Web.Redirect(\"/Index/Main_{0}\");", objViewInfoENEx.TabName_Out);

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

        public string Gen_Vue_Ts_GetObjLst4DdlBind(clsViewInfoENEx objViewInfoENEx, string strTabName, string strValueFld, string strTextFld)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 根据条件获取相应的对象列表");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");

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
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"根据条件获取相应的下拉框对象列表不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

      

        public string Gen_Vue_Ts_btnSelectRecordInTab_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** ");
            strCodeForCs.Append("\r\n * 在数据表里选择记录");

            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.Append("\r\n" + "public async btnSelectRecordInTab_Click(strKeyId:string) {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnSelectRecordInTab_Click.name;",
objViewInfoENEx.TabName, objKeyField.FldName);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "const arrKeyIds = clsCommFunc4Ctrl.GetCheckedKeyIds();");
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
                strCodeForCs.Append("\r\n" + "var lngKeyId =  Number(strKeyId);");

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
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"选择记录不成功. {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
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

            strCodeForCs.Append("\r\n /** ");
            strCodeForCs.Append("\r\n * 在数据表里详细信息记录");

            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.Append("\r\n" + "public async btnDetailRecordInTab_Click(strKeyId:string) {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnDetailRecordInTab_Click.name;",
objViewInfoENEx.TabName, objKeyField.FldName);
            //strCodeForCs.Append("\r\n" + "//$('#hidOpType').val(\"Detail\");");
            strCodeForCs.Append("\r\n" + "this.OpType = \"Detail\";");

            clsPropertyDef4GC objPropertyDef4GC = new clsPropertyDef4GC
            {
                OperateType = "set",
                ControlType = "input",
                CtrlId = "hidOpType",
                PropertyName = "OpType",
                Comment = "设置操作类型：Add||Update||Detail",
                DataType = "string",
                ParentDivName = "this.divName4Edit"
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

            //strCodeForCs.Append("\r\n" + "$(\"#Text1\").val(\"进入函数：btnDelete4Gv_Click\");");
            if (objKeyField.TypeScriptType == "number")
            {
                strCodeForCs.Append("\r\n" + "var lngKeyId =  Number(strKeyId);");

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
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"详细信息记录不成功. {0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_Vue_Ts_btnUpdateRecord_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            List<string> arrFeatureId = new List<string>() { enumPrjFeature.UpdateRecord_0137, enumPrjFeature.UpdateRecord_0199 };
            var objFeatureRegionFlds_Update = objViewInfoENEx.arrFeatureRegionFlds.Find(x => arrFeatureId.Contains(x.FeatureId));

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 修改记录");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.Append("\r\n" + "public async btnUpdateRecord_Click(strKeyId: string) {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnUpdateRecord_Click.name;",
objViewInfoENEx.TabName, objKeyField.FldName);
            //strCodeForCs.Append("\r\n" + "$('#hidOpType').val(\"Update\");");


            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "set",
                ControlType = "input",
                CtrlId = "hidOpType",
                PropertyName = "OpType",
                Comment = "设置操作类型：Add||Update||Detail",
                DataType = "string",
                ParentDivName = "this.divName4Edit"
            });
            if (objFeatureRegionFlds_Update == null
                || string.IsNullOrEmpty(objFeatureRegionFlds_Update.KeyIdGetModeId)
                || objFeatureRegionFlds_Update.KeyIdGetModeId == enumGCKeyIdGetMode.ListCheckedRecord_0001)
            {
                strCodeForCs.Append("\r\n" + "if (IsNullOrEmpty(strKeyId) == true)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.Append("\r\n" + "const strMsg = \"修改记录的关键字为空，请检查！\";");
                strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
            }
            else if (objFeatureRegionFlds_Update.KeyIdGetModeId == enumGCKeyIdGetMode.ViewStaticVariable_0002)
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
                strCodeForCs.Append("\r\n" + "alert(\"请选择需要修改的记录！\");");
                strCodeForCs.Append("\r\n" + "return;");
                strCodeForCs.Append("\r\n" + "}");
            }
            strCodeForCs.Append("\r\n" + "try {");
            //strCodeForCs.AppendFormat("\r\n" + "if (this.bolIsLoadEditRegion1 == false)  //", objViewInfoENEx.ClsName);
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "await this.AddDPV_Edit(this.divName4Edit);", objViewInfoENEx.ClsName);
            //strCodeForCs.Append("\r\n" + "this.OpType = \"Update\";");

            //strCodeForCs.Append("\r\n // 为编辑区绑定下拉框");
            ////strCodeForCs.Append("\r\n" + "if (this.b1olIsUseInDiv == true)");
            ////strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "await this.BindDdl4EditRegionInDiv();", objViewInfoENEx.ClsName);
            ////strCodeForCs.Append("\r\n" + "}");
            ////strCodeForCs.Append("\r\n" + "else");
            ////strCodeForCs.Append("\r\n" + "{");
            ////strCodeForCs.AppendFormat("\r\n" + "const conBindDdl = await this.BindDdl4EditRegion();", objViewInfoENEx.ClsName);
            ////strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.AppendFormat("\r\n" + "this.SetEventFunc();");
            //strCodeForCs.AppendFormat("\r\n" + "this.bolIsLoadEditRegion = true;  //", objViewInfoENEx.ClsName);

            
            //if (objKeyField.TypeScriptType == "number")
            //{
            //    strCodeForCs.Append("\r\n" + "var lngKeyId =  Number(strKeyId);");

            //    strCodeForCs.AppendFormat("\r\n" + "const update = await this.UpdateRecord(lngKeyId);",
            //     objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            //}
            //else
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "const update = await this.UpdateRecord(strKeyId);",
            //        objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            //}

            //strCodeForCs.Append("\r\n" + "if (update == false)");
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.Append("\r\n" + "const strMsg = Format(\"在修改记录时,显示记录数据不成功!\");");
            //strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            //strCodeForCs.Append("\r\n" + "alert(strMsg);");
            //strCodeForCs.Append("\r\n" + "return;");
            //strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.AppendFormat("\r\n" + "if ({0}.strPageDispModeId == enumPageDispMode.PopupBox_01)",
            //    objViewInfoENEx.ClsName);
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "this.ShowDialog_{0}('Update');", objViewInfoENEx.TabName_In);
            //strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "else");
            //strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "this.OpType = \"Update\";");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindDdl4EditRegionInDiv();", objViewInfoENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "this.SetEventFunc();");
            if (objKeyField.TypeScriptType == "number")
            {
                strCodeForCs.Append("\r\n" + "var lngKeyId =  Number(strKeyId);");

                strCodeForCs.AppendFormat("\r\n" + "const update = await this.UpdateRecord(lngKeyId);",
                 objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const update = await this.UpdateRecord(strKeyId);",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            }
            strCodeForCs.Append("\r\n" + "if (update == false)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"在修改记录时,显示记录数据不成功!\");");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.AppendFormat("\r\n" + "if ({0}.strPageDispModeId == enumPageDispMode.PopupBox_01)",
                objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");

            strCodeForCs.AppendFormat("\r\n" + "this.ShowDialog_{0}('Update');", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"(errid: WiTsCs0034)在修改记录时出错!请联系管理员!{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }



        public string Gen_Vue_Ts_btnUpdateRecordInTab_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 在数据表里修改记录");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.Append("\r\n" + "public async btnUpdateRecordInTab_Click(strKeyId:string) {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnUpdateRecordInTab_Click.name;",
objViewInfoENEx.TabName, objKeyField.FldName);
            //strCodeForCs.Append("\r\n" + "$('#hidOpType').val(\"Update\");");

            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "set",
                ControlType = "input",
                CtrlId = "hidOpType",
                PropertyName = "OpType",
                Comment = "设置操作类型：Add||Update||Detail",
                DataType = "string",
                ParentDivName = "this.divName4Edit"
            });

            strCodeForCs.Append("\r\n" + "    if (strKeyId == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "alert(\"请选择需要修改的记录！\");");
            strCodeForCs.Append("\r\n" + "return;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "try {");
            //strCodeForCs.AppendFormat("\r\n" + "if (this.bolIsLoadEditRegion1 == false)  //", objViewInfoENEx.ClsName);
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "await this.AddDPV_Edit(this.divName4Edit);", objViewInfoENEx.ClsName);
            //strCodeForCs.Append("\r\n" + "this.OpType = \"Update\";");

            //strCodeForCs.Append("\r\n // 为编辑区绑定下拉框");
            ////strCodeForCs.Append("\r\n" + "if (this.b1olIsUseInDiv == true)");
            ////strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "await this.BindDdl4EditRegionInDiv();", objViewInfoENEx.ClsName);
            ////strCodeForCs.Append("\r\n" + "}");
            ////strCodeForCs.Append("\r\n" + "else");
            ////strCodeForCs.Append("\r\n" + "{");
            ////strCodeForCs.AppendFormat("\r\n" + "const conBindDdl = await this.BindDdl4EditRegion();", objViewInfoENEx.ClsName);
            ////strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.AppendFormat("\r\n" + "this.SetEventFunc();");

            //strCodeForCs.AppendFormat("\r\n" + "this.bolIsLoadEditRegion = true;  //", objViewInfoENEx.ClsName);
            //if (objKeyField.TypeScriptType == "number")
            //{
            //    strCodeForCs.Append("\r\n" + "var lngKeyId =  Number(strKeyId);");

            //    strCodeForCs.AppendFormat("\r\n" + "this.UpdateRecord(lngKeyId);",
            //     objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            //}
            //else
            //{
            //    strCodeForCs.AppendFormat("\r\n" + "this.UpdateRecord(strKeyId);",
            //        objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            //}
            //strCodeForCs.AppendFormat("\r\n" + "if ({0}.strPageDispModeId == enumPageDispMode.PopupBox_01)",
            //    objViewInfoENEx.ClsName);
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "this.ShowDialog_{0}('Update');", objViewInfoENEx.TabName_In);
            //strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "else");
            //strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "this.OpType = \"Update\";");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindDdl4EditRegionInDiv();", objViewInfoENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "this.SetEventFunc();");
            if (objKeyField.TypeScriptType == "number")
            {
                strCodeForCs.Append("\r\n" + "var lngKeyId =  Number(strKeyId);");

                strCodeForCs.AppendFormat("\r\n" + "this.UpdateRecord(lngKeyId);",
                 objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "this.UpdateRecord(strKeyId);",
                    objViewInfoENEx.TabName, objViewInfoENEx.TabName.ToLower());
            }
            strCodeForCs.AppendFormat("\r\n" + "if ({0}.strPageDispModeId == enumPageDispMode.PopupBox_01)",
                objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "this.ShowDialog_{0}('Update');", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch (e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"(errid: WiTsCs0034)在修改记录时出错!请联系管理员!{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
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
        public string Gen_Vue_Ts_AddNewRecordSave(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 添加新记录，保存函数");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.Append("\r\n" + "public async AddNewRecordSave(): Promise<boolean>{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.AddNewRecordSave.name;",
objViewInfoENEx.TabName, objKeyField.FldName);

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

            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN = new cls{0}EN();",
               objViewInfoENEx.TabName);

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "await this.PutDataTo{0}Class(obj{0}EN);",
                  objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"从界面获取数据不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return false;//一定要有一个返回值，否则会出错！");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.CheckPropertyNew(obj{0}EN);",
                   objViewInfoENEx.TabName);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"检查数据不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return false;//一定要有一个返回值，否则会出错！");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            if (objKeyField.PrimaryTypeId == enumPrimaryType.Identity_02)
            {

            }
            else
            {
                strCodeForCs.AppendFormat("\r\n" + "const bolIsExist = await {0}_IsExistAsync(obj{0}EN.{1});",
                    objViewInfoENEx.TabName, objKeyField.PropertyName());
                                
                strCodeForCs.Append("\r\n" + "if (bolIsExist == true)");
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"添加记录时，关键字：{{0}}已经存在！\", obj{0}EN.{1});",
                    objViewInfoENEx.TabName, objKeyField.PropertyName());
                strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "return false;//一定要有一个返回值，否则会出错！");
                strCodeForCs.Append("\r\n" + "}");
            }
            strCodeForCs.AppendFormat("\r\n" + "const responseText2 = await {0}_AddNewRecordAsync(obj{0}EN);",
                objViewInfoENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "const returnBool = !!responseText2;",
                objViewInfoENEx.TabName);

            strCodeForCs.Append("\r\n" + "if (returnBool == true)");
            strCodeForCs.Append("\r\n" + "{");
            Gene_ReFreshCache(strCodeForCs);
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"添加记录成功!\");");
            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"添加记录不成功!\");");
            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return responseText2;//一定要有一个返回值，否则会出错！");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"添加记录不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return false;//一定要有一个返回值，否则会出错！");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }


        public string Gen_Vue_Ts_CheckUniCondition4Add(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            //if (objViewInfoENEx.objMainPrjTab.arrConstraintFieldsSet.Count == 0) return "";
            StringBuilder strCodeForCs = new StringBuilder();
            foreach (clsPrjConstraintEN objInFor in objViewInfoENEx.objMainPrjTab.arrPrjConstraintSet())
            {
                IEnumerable<clsConstraintFieldsEN> arrObjLst_Flds = clsConstraintFieldsBLEx.GetObjLstByPrjConstraintId_Cache(objInFor.PrjConstraintId, objInFor.PrjId);

                strCodeForCs.Append("\r\n /** 为添加记录检查唯一性条件");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + "public async CheckUniCond4Add_{1}(obj{0}EN: cls{0}EN): Promise<boolean>{{",
                    objViewInfoENEx.TabName, objInFor.ConstraintName);
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.CheckUniCond4Add_{0}.name;",
                    objInFor.ConstraintName);
                if (objInFor.IsNullable == true)
                {
                    foreach (var objField in arrObjLst_Flds)
                    {
                        var objPrjTabFld = clsPrjTabFldBLEx.GetObjByTabIdAndFldId_Cache(objInFor.TabId, objField.FldId, objInFor.PrjId);
                        if (objPrjTabFld.IsTabNullable == false) continue;
                        strCodeForCs.AppendFormat("\r\n" + "   if (IsNullOrEmpty(obj{0}EN.{1}) == true) return true;", objViewInfoENEx.TabName, objField.ObjFieldTab().PropertyName());
                    }
                }

                strCodeForCs.AppendFormat("\r\n" + "const strUniquenessCondition = cls{0}BL.GetUniCondStr_{1}(obj{0}EN);", objViewInfoENEx.TabName, objInFor.ConstraintName);
                strCodeForCs.AppendFormat("\r\n" + "const bolIsExistCondition = await {0}_IsExistRecordAsync(strUniquenessCondition);", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "if (bolIsExistCondition == true)");
                strCodeForCs.Append("\r\n" + "{");
                if (String.IsNullOrEmpty(objInFor.ErrMsg) == false)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"{0}.满足条件：{{0}}的记录已经存在！\",  strUniquenessCondition);", objInFor.ErrMsg);
                }
                else
                {
                    strCodeForCs.Append("\r\n" + "const strMsg = Format(\"不能满足唯一性条件。满足条件：{0}的记录已经存在！\", strUniquenessCondition);");
                }
                strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "return false;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return true;");

                strCodeForCs.Append("\r\n" + "}");
            }
            return strCodeForCs.ToString();
        }

        public string Gen_Vue_Ts_CheckUniCondition4Update(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            foreach (clsPrjConstraintEN objInFor in objViewInfoENEx.objMainPrjTab.arrPrjConstraintSet())
            {
                IEnumerable<clsConstraintFieldsEN> arrObjLst_Flds = clsConstraintFieldsBLEx.GetObjLstByPrjConstraintId_Cache(objInFor.PrjConstraintId, objInFor.PrjId);

                strCodeForCs.Append("\r\n /** 为修改记录检查唯一性条件");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + "public async CheckUniCond4Update_{1}(obj{0}EN: cls{0}EN): Promise<boolean>{{",
                    objViewInfoENEx.TabName, objInFor.ConstraintName);
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.CheckUniCond4Update_{0}.name;", objInFor.ConstraintName);
                if (objInFor.IsNullable == true)
                {
                    foreach (var objField in arrObjLst_Flds)
                    {
                        var objPrjTabFld = clsPrjTabFldBLEx.GetObjByTabIdAndFldId_Cache(objInFor.TabId, objField.FldId, objInFor.PrjId);
                        if (objPrjTabFld.IsTabNullable == false) continue;
                        strCodeForCs.AppendFormat("\r\n" + "   if (IsNullOrEmpty(obj{0}EN.{1}) == true) return true;", objViewInfoENEx.TabName, objField.ObjFieldTab().PropertyName());
                    }
                }
                strCodeForCs.AppendFormat("\r\n" + "const strUniquenessCondition = cls{0}BL.GetUniCondStr4Update_{1}(obj{0}EN);", objViewInfoENEx.TabName, objInFor.ConstraintName);
                strCodeForCs.AppendFormat("\r\n" + "const bolIsExistCondition = await {0}_IsExistRecordAsync(strUniquenessCondition);", objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "if (bolIsExistCondition == true)");
                strCodeForCs.Append("\r\n" + "{");
                if (String.IsNullOrEmpty(objInFor.ErrMsg) == false)
                {
                    strCodeForCs.AppendFormat("\r\n" + "const strMsg = Format(\"{0}.满足条件：{{0}}的记录已经存在！\",  strUniquenessCondition);", objInFor.ErrMsg);
                }
                else
                {
                    strCodeForCs.Append("\r\n" + "const strMsg = Format(\"不能满足唯一性条件。满足条件：{0}的记录已经存在！\", strUniquenessCondition);");
                }
                strCodeForCs.Append("\r\n" + "console.error(strMsg);");
                strCodeForCs.Append("\r\n" + "alert(strMsg);");
                strCodeForCs.Append("\r\n" + "return false;");
                strCodeForCs.Append("\r\n" + "}");
                strCodeForCs.Append("\r\n" + "return true;");

                strCodeForCs.Append("\r\n" + "}");
            }
            return strCodeForCs.ToString();
        }



        /// <summary>
        /// 添加记录保存函数  
        /// </summary>
        /// <returns></returns>
        public string Gen_Vue_Ts_AddNewRecordWithMaxIdSave(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            if (objKeyField.ObjFieldTabENEx.objDataTypeAbbrEN.CsType != "string") return "";

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 添加新记录，由后台自动获取最大值的关键字。保存函数");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.Append("\r\n" + "public async AddNewRecordWithMaxIdSave(): Promise<string>{");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.AddNewRecordWithMaxIdSave.name;",
objViewInfoENEx.TabName, objKeyField.FldName);
            
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

            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN = new cls{0}EN();",
               objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "await this.PutDataTo{0}Class(obj{0}EN);",
                  objViewInfoENEx.TabName);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"从界面获取数据不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "throw(strMsg);//一定要有一个返回值，否则会出错！");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.CheckPropertyNew(obj{0}EN);",
                   objViewInfoENEx.TabName);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"检查数据不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "throw(strMsg);//一定要有一个返回值，否则会出错！");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            if (objKeyField.PrimaryTypeId == enumPrimaryType.Identity_02)
            {

            }
            else
            {
                
            }
            strCodeForCs.AppendFormat("\r\n" + "const responseKeyId = await {0}_AddNewRecordWithMaxIdAsync(obj{0}EN);",
                objViewInfoENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "const returnKeyId: string = responseKeyId;",
                objViewInfoENEx.TabName);

            strCodeForCs.Append("\r\n" + "if (IsNullOrEmpty(returnKeyId) == false)");
            strCodeForCs.Append("\r\n" + "{");
            Gene_ReFreshCache(strCodeForCs);
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"添加记录成功!\");");
            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strInfo = Format(\"添加记录不成功!\");");
            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return responseKeyId;//一定要有一个返回值，否则会出错！");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"添加记录不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "throw(strMsg);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return \"\";//一定要有一个返回值，否则会出错！");

            strCodeForCs.Append("\r\n" + "}");


            return strCodeForCs.ToString();
        }


        public string Gen_Vue_Ts_btnAddNewRecord_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 添加新记录");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.Append("\r\n" + "public async btnAddNewRecord_Click() {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnAddNewRecord_Click.name;",
objViewInfoENEx.TabName, objKeyField.FldName);
            //        strCodeForCs.Append("\r\n" + "//$('#hidOpType').val(\"Add\");");


            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "set",
                ControlType = "input",
                CtrlId = "hidOpType",
                PropertyName = "OpType",
                Comment = "设置操作类型：Add||Update||Detail",
                DataType = "string",
                ParentDivName = "this.divName4Edit"
            });

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            //strCodeForCs.AppendFormat("\r\n" + "if (this.bolIsLoadEditRegion1 == false)  //", objViewInfoENEx.ClsName);
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "await this.AddDPV_Edit(this.divName4Edit);", objViewInfoENEx.ClsName);
            //strCodeForCs.Append("\r\n" + "this.OpType = \"Add\";");

            //strCodeForCs.Append("\r\n // 为编辑区绑定下拉框");
            ////strCodeForCs.Append("\r\n" + "if (this.b1olIsUseInDiv == true)");
            ////strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "await this.BindDdl4EditRegionInDiv();", objViewInfoENEx.ClsName);
            ////strCodeForCs.Append("\r\n" + "}");
            ////strCodeForCs.Append("\r\n" + "else");
            ////strCodeForCs.Append("\r\n" + "{");
            ////strCodeForCs.AppendFormat("\r\n" + "const conBindDdl = await this.BindDdl4EditRegion();", objViewInfoENEx.ClsName);
            ////strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.AppendFormat("\r\n" + "this.SetEventFunc();");

            //strCodeForCs.AppendFormat("\r\n" + "this.bolIsLoadEditRegion = true;  //", objViewInfoENEx.ClsName);
            //strCodeForCs.AppendFormat("\r\n" + "await this.AddNewRecord();",
            //        objViewInfoENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "if ({0}.strPageDispModeId == enumPageDispMode.PopupBox_01)",
            //    objViewInfoENEx.ClsName);
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "this.ShowDialog_{0}('Add');", objViewInfoENEx.TabName_In);
            //strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "else");
            //strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "this.OpType = \"Add\";");
            strCodeForCs.AppendFormat("\r\n" + "await this.BindDdl4EditRegionInDiv();", objViewInfoENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "this.SetEventFunc();");
            strCodeForCs.AppendFormat("\r\n" + "this.btnSubmit_{0} = \"确认添加\";", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + "this.btnCancel_{0} = \"取消添加\";", objViewInfoENEx.TabName_In);

            strCodeForCs.AppendFormat("\r\n" + "await this.AddNewRecord();",
                objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "if ({0}.strPageDispModeId == enumPageDispMode.PopupBox_01)",
                objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "this.ShowDialog_{0}('Add');", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.Append("\r\n" + "}");


            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"添加新记录初始化不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }

        public string Gen_Vue_Ts_btnAddNewRecordWithMaxId_Click(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 添加新记录");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.Append("\r\n" + "public async btnAddNewRecordWithMaxId_Click() {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.btnAddNewRecordWithMaxId_Click.name;",
objViewInfoENEx.TabName, objKeyField.FldName);
            //        strCodeForCs.Append("\r\n" + "//$('#hidOpType').val(\"Add\");");

            arrPropertyDef4GC.Add(new clsPropertyDef4GC
            {
                OperateType = "set",
                ControlType = "input",
                CtrlId = "hidOpType",
                PropertyName = "OpType",
                Comment = "设置操作类型：Add||Update||Detail",
                DataType = "string",
                ParentDivName = "this.divName4Edit"
            });

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");

            //strCodeForCs.AppendFormat("\r\n" + "if (this.bolIsLoadEditRegion1 == false)  //", objViewInfoENEx.ClsName);
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "await this.AddDPV_Edit(this.divName4Edit);", objViewInfoENEx.ClsName);
            //strCodeForCs.Append("\r\n" + "this.OpType = \"AddWithMaxId\";");


            //strCodeForCs.Append("\r\n // 为编辑区绑定下拉框");
            ////strCodeForCs.Append("\r\n" + "if (this.b1olIsUseInDiv == true)");
            ////strCodeForCs.Append("\r\n" + "{");

            //strCodeForCs.AppendFormat("\r\n" + "await this.BindDdl4EditRegionInDiv();", objViewInfoENEx.ClsName);
            ////strCodeForCs.Append("\r\n" + "}");
            ////strCodeForCs.Append("\r\n" + "else");
            ////strCodeForCs.Append("\r\n" + "{");
            ////strCodeForCs.AppendFormat("\r\n" + "const conBindDdl = await this.BindDdl4EditRegion();", objViewInfoENEx.ClsName);
            ////strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.AppendFormat("\r\n" + "this.SetEventFunc();");

            //strCodeForCs.AppendFormat("\r\n" + "this.bolIsLoadEditRegion = true;  //", objViewInfoENEx.ClsName);
            //strCodeForCs.AppendFormat("\r\n" + "this.AddNewRecordWithMaxId();",
            //        objViewInfoENEx.TabName);
            //strCodeForCs.AppendFormat("\r\n" + "if ({0}.strPageDispModeId == enumPageDispMode.PopupBox_01)",
            //    objViewInfoENEx.ClsName);
            //strCodeForCs.Append("\r\n" + "{");
            //strCodeForCs.AppendFormat("\r\n" + "this.ShowDialog_{0}('Add');", objViewInfoENEx.TabName_In);
            //strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.Append("\r\n" + "}");
            //strCodeForCs.Append("\r\n" + "else");
            //strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "this.OpType = \"AddWithMaxId\";");

            strCodeForCs.AppendFormat("\r\n" + "await this.BindDdl4EditRegionInDiv();", objViewInfoENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "this.SetEventFunc();");
            strCodeForCs.AppendFormat("\r\n" + "this.btnSubmit_{0} = \"确认添加\";", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + "this.btnCancel_{0} = \"取消添加\";", objViewInfoENEx.TabName_In);

            strCodeForCs.AppendFormat("\r\n" + "this.AddNewRecordWithMaxId();",
                objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "if ({0}.strPageDispModeId == enumPageDispMode.PopupBox_01)",
                objViewInfoENEx.ClsName);
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "this.ShowDialog_{0}('Add');", objViewInfoENEx.TabName_In);
            strCodeForCs.Append("\r\n" + "}");

            //strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"添加新记录初始化不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "}");

            return strCodeForCs.ToString();
        }


        public string Gen_Vue_Ts_GetMaxStrId(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 获取当前表关键字值的最大值,再加1,避免重复");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");


            strCodeForCs.Append("\r\n" + "public async GetMaxStrId(strKeyCtrlName) {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.GetMaxStrId.name;",
objViewInfoENEx.TabName, objKeyField.FldName);

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
            strCodeForCs.AppendFormat("\r\n" + "const returnString = await {0}_GetMaxStrIdAsync();",
                objViewInfoENEx.TabName);
            
            strCodeForCs.Append("\r\n" + "if (returnString == \"\")");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"获取表{0}的最大关键字为空，不成功，请检查!\");",
                objViewInfoENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + " $(strKeyCtrlName).val(returnString);");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "else");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const strInfo = Format(\"获取表{0}的最大关键字为：{{0}}!\", returnString);",
                objViewInfoENEx.TabName);
            strCodeForCs.AppendFormat("\r\n" + "$('#lblResult{0}').val(strInfo);", objvFunction4GeneCodeEN.OrderNum);
            strCodeForCs.Append("\r\n" + "//显示信息框");
            strCodeForCs.Append("\r\n" + "alert(strInfo);");
            strCodeForCs.Append("\r\n" + " $(strKeyCtrlName).val(returnString);");
            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"获取表关键字的最大值不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "}");



            return strCodeForCs.ToString();
        }
               
        public string Gen_Vue_Ts_UpdateRecordSave(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            StringBuilder strCodeForCs = new StringBuilder();

            strCodeForCs.Append("\r\n /** 修改记录");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n" + " **/");
            strCodeForCs.Append("\r\n" + "public async UpdateRecordSave(): Promise<boolean> {");
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.UpdateRecordSave.name;",
objViewInfoENEx.TabName, objKeyField.FldName);

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

            strCodeForCs.AppendFormat("\r\n" + "const obj{0}EN = new cls{0}EN();",
           objViewInfoENEx.TabName);

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

            strCodeForCs.AppendFormat("\r\n" + "await this.PutDataTo{0}Class(obj{0}EN);",
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
            strCodeForCs.AppendFormat("\r\n" + "cls{0}BL.CheckProperty4Update(obj{0}EN);",
                   objViewInfoENEx.TabName);

            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"检查数据不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return false;//一定要有一个返回值，否则会出错！");

            strCodeForCs.Append("\r\n" + "}");

            strCodeForCs.Append("\r\n" + "try");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.AppendFormat("\r\n" + "const responseText = await {0}_UpdateRecordAsync(obj{0}EN);",
                objViewInfoENEx.TabName);

            strCodeForCs.AppendFormat("\r\n" + "const returnBool = !!responseText;",
                  objViewInfoENEx.TabName);

            strCodeForCs.Append("\r\n" + "if (returnBool == true)");
            strCodeForCs.Append("\r\n" + "{");
            Gene_ReFreshCache(strCodeForCs);
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "return returnBool;");
            strCodeForCs.Append("\r\n" + "}");
            strCodeForCs.Append("\r\n" + "catch(e)");
            strCodeForCs.Append("\r\n" + "{");
            strCodeForCs.Append("\r\n" + "const strMsg = Format(\"修改记录不成功,{0}.(in {1}.{2})\", e, this.constructor.name, strThisFuncName);");
            strCodeForCs.Append("\r\n" + "console.error(strMsg);");
            strCodeForCs.Append("\r\n" + "alert(strMsg);");
            strCodeForCs.Append("\r\n" + "return false;");
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
        public string Gen_Vue_Ts_PutDataToClass(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {

                strCodeForCs.Append("\r\n /** 函数功能:把界面上的属性数据传到类对象中");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n * @param pobj{0}EN\">数据传输的目的类对象</param>",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + "public async PutDataTo{0}Class(pobj{2}EN: cls{1}EN)",
                objViewInfoENEx.TabName, objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.PutDataTo{0}Class.name;", objViewInfoENEx.TabName);
                //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet)
                {
                    
                    if (objEditRegionFldsEx.InUse == false)
                    {
                        if (objEditRegionFldsEx.FieldTypeId() == enumFieldType.Log_UpdUser_14)
                        {
                            //string str1 = "";

                        }
                        else if (objEditRegionFldsEx.FieldTypeId() == enumFieldType.Log_UpdDate_13)
                        {
                            //string str2 = "";
                        }
                        else
                        {
                            continue;
                        }
                    }

                    try
                    {
                        string strTemp = GetCode4FieldInPutDataToClass(objEditRegionFldsEx, objViewInfoENEx);
                        strCodeForCs.AppendFormat("{0}", strTemp);
                    }
                    catch(Exception objExceptionIn)
                    {
                        throw objExceptionIn;
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
        private string GetCode4FieldInPutDataToClass(clsEditRegionFldsENEx objEditRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {
            StringBuilder sbCodeForCs = new StringBuilder();
            if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objEditRegionFldsEx.PrimaryTypeId() == clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }
            if (objEditRegionFldsEx.CtlTypeId != enumCtlTypeAbbr.ViewVariable_38 
                && objEditRegionFldsEx.CtlTypeId != enumCtlTypeAbbr.CacheClassifyField_37)
            {
                arrPropertyDef4GC.Add(new clsPropertyDef4GC
                {
                    OperateType = "get",
                    ControlType = objEditRegionFldsEx.CtlTypeName,
                    CtrlId = objEditRegionFldsEx.CtrlId,
                    PropertyName = objEditRegionFldsEx.PropertyName(),
                    Comment = string.Format("{0} (Used In {1})", objEditRegionFldsEx.ObjFieldTabENEx.Caption,
                                        "PutDataToClass()"),
                    DataType = objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
                    ParentDivName = "this.divName4Edit"
                });
            }
            if (objEditRegionFldsEx.FieldTypeId() == enumFieldType.Log_UpdUser_14)
            {
                sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = clsPubSessionStorage.userId;",
                    objViewInfoENEx.TabName,
                    objEditRegionFldsEx.PropertyName());
            }
            else if (objEditRegionFldsEx.FieldTypeId() == enumFieldType.Log_UpdDate_13)
            {
                sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = clsDateTime.getTodayDateTimeStr(1);",
                    objViewInfoENEx.TabName,
                    objEditRegionFldsEx.PropertyName());
            }
            else
            {
                switch (objEditRegionFldsEx.CtlTypeId)
                {
                    case enumCtlTypeAbbr.CheckBox_02:
                        sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = this.{1};",
         objViewInfoENEx.TabName,
         objEditRegionFldsEx.PropertyName(),
         objEditRegionFldsEx.CtrlId);
                        break;
                    case enumCtlTypeAbbr.TextBox_16:
                        sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = this.{1};",
         objViewInfoENEx.TabName,
         objEditRegionFldsEx.PropertyName(),
         objEditRegionFldsEx.CtrlId);
                        break;
                    case enumCtlTypeAbbr.DropDownList_06:
                        sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = this.{1};",
         objViewInfoENEx.TabName,
         objEditRegionFldsEx.PropertyName(),
         objEditRegionFldsEx.CtrlId);
                        break;
                    case enumCtlTypeAbbr.CacheClassifyField_37:
                        sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = {2};",
         objViewInfoENEx.TabName,
         objEditRegionFldsEx.PropertyName(),
         strVarDef4ViewCacheFld);
                        break;
                    case enumCtlTypeAbbr.DefaultValue_36:
                        if (objEditRegionFldsEx.ObjFieldTab().ObjDataTypeAbbr().IsNumberType() == true)
                        {
                            sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = {2};",
         objViewInfoENEx.TabName,
         objEditRegionFldsEx.PropertyName(),
         objEditRegionFldsEx.DefaultValue);
                        }
                        else if (objEditRegionFldsEx.ObjFieldTab().DataTypeId == enumDataTypeAbbr.bit_03)
                        {
                            sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = {2};",
         objViewInfoENEx.TabName,
         objEditRegionFldsEx.PropertyName(),
         objEditRegionFldsEx.DefaultValue);
                        }
                        else
                        {
                            sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = \"{2}\";",
        objViewInfoENEx.TabName,
        objEditRegionFldsEx.PropertyName(),
         objEditRegionFldsEx.DefaultValue);
                        }
                       
                        break;
                    case enumCtlTypeAbbr.ViewVariable_38:
                        string strVarName = "";
                        var objVar = clsGCVariableBL.GetObjByVarId_Cache(objEditRegionFldsEx.VarId, objViewInfoENEx.PrjId);
                        if (objVar != null)
                        {
                            strVarName = objVar.VarExpression;
                        }
                        sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = {2}.{3};",
         objViewInfoENEx.TabName,
         objEditRegionFldsEx.PropertyName(),
         objViewInfoENEx.ClsName, strVarName);
                        break;
                    case enumCtlTypeAbbr.GivenValue_35:
                        sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = {2};",
         objViewInfoENEx.TabName,
         objEditRegionFldsEx.PropertyName(),
         strVarDef4ViewCacheFld);
                        break;

                    default:
                        sbCodeForCs.AppendFormat("\r\n" + "pobj{0}EN.{1} = this.{1};",
                objViewInfoENEx.TabName,
                objEditRegionFldsEx.PropertyName(),
                objEditRegionFldsEx.CtrlId);
                        break;
                }
            }
            sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);

            return sbCodeForCs.ToString();
        }
        public string Gen_Vue_Ts_GetDataFromClass(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /** 函数功能:把类对象的属性内容显示到界面上");
                strCodeForCs.Append("\r\n * 注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值");
                strCodeForCs.Append("\r\n * 如果在设置数据库时,就应该一级字段在前,二级字段在后");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n * @param pobj{0}EN\">表实体类对象</param>",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + "public GetDataFrom{0}Class(pobj{2}EN: cls{1}EN )",
                objViewInfoENEx.TabName, objViewInfoENEx.TabName, objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.GetDataFrom{0}Class.name;", objViewInfoENEx.TabName);
                //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

                foreach (clsEditRegionFldsENEx objEditRegionFldsEx in objViewInfoENEx.arrEditRegionFldSet4InUse)
                {
                    if (objEditRegionFldsEx.CtlTypeId == enumCtlTypeAbbr.ViewVariable_38
                       || objEditRegionFldsEx.CtlTypeId == enumCtlTypeAbbr.CacheClassifyField_37)
                    {
                        continue;
                    }
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

        public string Gen_Vue_Ts_ShowDetailDataFromClass(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            //clsDetailRegionEN objDetailRegion = null;
            clsViewRegionEN objViewRegion = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.DetailRegion_0006);
            if (objViewRegion == null || objViewRegion.InUseInViewInfo(objViewInfoENEx) == false) return "";

            string strFuncName = "";
            StringBuilder strCodeForCs = new StringBuilder();
            try
            {

                strCodeForCs.Append("\r\n /** 函数功能:把类对象的属性内容显示到界面的详细信息区域中");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n * @param pobj{0}EN\">表实体类对象</param>",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n" + " **/");
                strCodeForCs.AppendFormat("\r\n" + "public ShowDetailDataFrom{0}Class(pobj{2}EN: cls{1}EN )",
                           objViewInfoENEx.TabName_Out, objViewInfoENEx.TabName_Out, objViewInfoENEx.TabName_Out);
                strCodeForCs.Append("\r\n" + "{");
                strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.ShowDetailDataFrom{0}Class.name;", objViewInfoENEx.TabName_Out);
                
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


        private string GetCode4FieldInGetDataFromClass(clsEditRegionFldsENEx objEditRegionFldsEx, clsViewInfoENEx objViewInfoENEx)
        {

            StringBuilder sbCodeForCs = new StringBuilder();


            if (objEditRegionFldsEx.ObjFieldTabENEx.FieldTypeId == enumFieldType.KeyField_02
                  && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
            {
                return "";
            }
            if (objEditRegionFldsEx.CtlTypeId != enumCtlTypeAbbr.ViewVariable_38
                && objEditRegionFldsEx.CtlTypeId != enumCtlTypeAbbr.CacheClassifyField_37)
            {
                arrPropertyDef4GC.Add(new clsPropertyDef4GC
                {
                    OperateType = "set",
                    ControlType = objEditRegionFldsEx.CtlTypeName,
                    CtrlId = objEditRegionFldsEx.CtrlId,
                    PropertyName = objEditRegionFldsEx.PropertyName(),
                    Comment = string.Format("{0} (Used In {1})", objEditRegionFldsEx.ObjFieldTabENEx.Caption,
                                        "GetDataFromClass()"),
                    DataType = objEditRegionFldsEx.ObjFieldTabENEx.objDataTypeAbbrEN.TypeScriptType,
                    ParentDivName = "this.divName4Edit"
                });
            }
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
                                objEditRegionFldsEx.PropertyName());
                    sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);
                    break;
                case enumCtlTypeAbbr.GivenValue_35:
                    sbCodeForCs.AppendFormat("\r\n" + "// this.{2} = pobj{1}EN.{2};",
                                objEditRegionFldsEx.CtrlId,
                                objViewInfoENEx.TabName,
                                objEditRegionFldsEx.PropertyName());
                    sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);
                    break;
                case enumCtlTypeAbbr.DropDownList_06:
                    sbCodeForCs.AppendFormat("\r\n" + " this.{2} = pobj{1}EN.{2};",
                                objEditRegionFldsEx.CtrlId,
                                objViewInfoENEx.TabName,
                                objEditRegionFldsEx.PropertyName());
                    sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);
                    break;
                case enumCtlTypeAbbr.CacheClassifyField_37:
                    sbCodeForCs.AppendFormat("\r\n" + "// this.{2} = pobj{1}EN.{2};",
                         objEditRegionFldsEx.CtrlId,
                         objViewInfoENEx.TabName,
                         objEditRegionFldsEx.PropertyName());
                    sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);
                    break;
                default:
                    sbCodeForCs.AppendFormat("\r\n" + " this.{2} = pobj{1}EN.{2};",
                                objEditRegionFldsEx.CtrlId,
                                objViewInfoENEx.TabName,
                                objEditRegionFldsEx.PropertyName());
                    sbCodeForCs.AppendFormat("// {0}", objEditRegionFldsEx.LabelCaption);
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

                strCodeForCs.Append("\r\n /** 函数功能:从界面列表中获取第一个关键字的值");
                strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                strCodeForCs.AppendFormat("\r\n * @param pobj{0}EN\">表实体类对象</param>",
                objViewInfoENEx.TabName);
                strCodeForCs.Append("\r\n * returns:列表的第一个关键字值</returns>");
                strCodeForCs.Append("\r\n" + " **/");
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

                if (objViewInfoENEx.objViewRegion_List.IsCheck() == true || objViewInfoENEx.objViewRegion_List.IsRadio() == true)
                {
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

                }
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
        public string Gen_Vue_Ts_DefDiv4EditRegion()
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
                  && objEditRegionFldsEx.PrimaryTypeId()== clsPrimaryTypeNameENEx.IDENTITY_PRIMARYKEY)
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

        public string Gen_Vue_Ts_ShowData()
        {
            StringBuilder strCodeForCs = new StringBuilder();
            string strFuncName = "";
            try
            {
                if (objViewInfoENEx.objViewTypeCodeTab.IsHaveUpdate
|| objViewInfoENEx.objViewTypeCodeTab.IsHaveDetail)
                {
                    strCodeForCs.Append("\r\n /** 函数功能:把以该关键字的记录内容显示在界面上,");
                    strCodeForCs.Append("\r\n * 在这里是把值传到表控件中");
                    strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
                    strCodeForCs.AppendFormat("\r\n * @param {0}\">表记录的关键字,显示该表关键字的内容</param>",
                      objKeyField.PrivFuncName);
                    strCodeForCs.Append("\r\n" + " **/");

                    strCodeForCs.AppendFormat("\r\n" + "  public async ShowData({0}: {1}) {{",
                        objKeyField.PrivFuncName, objKeyField.TypeScriptType);
                    strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.ShowData.name;", objViewInfoENEx.TabName_Out);
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
                    //strCodeForCs.Append("\r\n" + "            else {");
                    //                    strCodeForCs.Append("\r\n" + "                const strInfo = Format(\"关键字:[${strExam1TypeId}]的相关记录存在!\");");
                    //                  strCodeForCs.Append("\r\n" + "                //$('#lblResult1').val(strInfo);");
                    //                strCodeForCs.Append("\r\n" + "                //显示信息框");
                    //              strCodeForCs.Append("\r\n" + "                alert(strInfo);");
                    //strCodeForCs.Append("\r\n" + "            }");
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
            return A_GeneFuncCodeBase(objvFunction4GeneCodeEN, typeof(Vue_ViewScript_EditCS_TS4TypeScriptBak));
            //string strFuncName = objvFunction4GeneCodeEN.FuncName;
            //try
            //{
            //    string strCode = "";
            //    Type t = typeof(Vue_ViewScript_EditCS_TS4TypeScriptBak);
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
            string strClassName = string.Format("WA_{0}_Edit", objViewInfoENEx.TabName);
            clsViewRegionENEx objViewRegionENEx = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.EditRegion_0003);
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
                else if (objViewInfoENEx.objCacheClassifyFld4View2 == null)
                {
                    sbCode.AppendFormat("\r\n" + "{0}_ReFreshCache({2}.{1}_Cache);", objViewInfoENEx.TabName, 
                        objViewInfoENEx.objCacheClassifyFld4View.FldName, objViewInfoENEx.ClsName);
                }
                else
                {
                    sbCode.AppendFormat("\r\n" + "{0}_ReFreshCache({1}.{2}_Cache, {1}.{3}_Cache);", objViewInfoENEx.TabName, objViewInfoENEx.ClsName,
                        objViewInfoENEx.objCacheClassifyFld4View.FldName,
                        objViewInfoENEx.objCacheClassifyFld4View2.FldName);
                }
            }
            else
            {
                if (objViewInfoENEx.objCacheClassifyFld4View == null)
                {
                    sbCode.AppendFormat("\r\n" + "//{0}_ReFreshCache();", objViewInfoENEx.TabName_In);
                }
                else if (objViewInfoENEx.objCacheClassifyFld4View2 == null)
                {
                    sbCode.AppendFormat("\r\n" + "//{0}_ReFreshCache({2}.{1}_Cache);", objViewInfoENEx.TabName, objViewInfoENEx.objCacheClassifyFld4View.FldName, objViewInfoENEx.ClsName);
                }
                else
                {
                    sbCode.AppendFormat("\r\n" + "//{0}_ReFreshCache({1}.{2}_Cache, {1}.{3}_Cache);", objViewInfoENEx.TabName,
                        objViewInfoENEx.ClsName,
                        objViewInfoENEx.objCacheClassifyFld4View.FldName,
                        objViewInfoENEx.objCacheClassifyFld4View2.FldName
                        );
                }
            }
        }


        public string Gen_Vue_Ts_Code4EditRegion()
        {
            if (arrPropertyDef4GC == null)  arrPropertyDef4GC = new List<clsPropertyDef4GC>();
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

        public string Gen_Vue_Ts_AddDPV_Edit(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {

            string strClassName = string.Format("WA_{0}_Edit", objViewInfoENEx.TabName);
            clsViewRegionENEx objViewRegionENEx = objViewInfoENEx.arrViewRegion.Find(x => x.RegionTypeId == enumRegionType.EditRegion_0003);
            if (objViewRegionENEx != null && string.IsNullOrEmpty(objViewRegionENEx.ClassName) == false)
            {
                strClassName = objViewRegionENEx.ClassName;
            }

            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * 在当前界面中，导入编辑区域");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            
            strCodeForCs.Append("\r\n * @returns ");
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "public async AddDPV_Edit(divName4Edit:string) {{",
                objViewInfoENEx.ClsName);
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.AddDPV_Edit.name;",
objViewInfoENEx.TabName, objKeyField.FldName);
            strCodeForCs.Append("\r\n" + "clsCommFunc4Web.CheckDivExist(divName4Edit);");
            //strCodeForCs.Append("\r\n" + "var objLst = document.getElementsByTagName(\"div\");");
            //strCodeForCs.Append("\r\n" + "var strStartName = \"divEditEdit\";");
            //strCodeForCs.AppendFormat("\r\n" + "let arrElement = WA_{0}_UT_JS.GetArray(objLst) ;", objViewInfoENEx.TabName);

            //strCodeForCs.Append("\r\n" + "let arrDiv = arrElement ;");
            //strCodeForCs.Append("\r\n" + "let arrFind = arrDiv.filter(x => x.id.indexOf(strStartName) > -1);");
            //strCodeForCs.Append("\r\n" + "arrFind.forEach(x => x.innerHTML = \"\");");
            //strCodeForCs.Append("\r\n" + "//var o = document.getElementById(\"div\") ;");
            strCodeForCs.AppendFormat("\r\n" + "const strUrl = \"./{0}\";", strClassName);
            strCodeForCs.Append("\r\n" + "console.log(\"divName4Edit:(In AddDPV_Edit)\" + divName4Edit);");
            strCodeForCs.Append("\r\n" + "return new Promise(function(resolve, reject) {");
            strCodeForCs.Append("\r\n" + "$.ajax({");
            strCodeForCs.Append("\r\n" + "url: strUrl,");
            strCodeForCs.Append("\r\n" + "method: \"GET\",");
            strCodeForCs.Append("\r\n" + "dataType: \"html\",");
            strCodeForCs.Append("\r\n" + "data: { },");
            strCodeForCs.Append("\r\n" + "success: function(data:any) {");
            strCodeForCs.Append("\r\n" + "console.log(\"已经成功获取页面:\" + strUrl + \"  字节数: \" + data.length.toString());");
            strCodeForCs.Append("\r\n" + "$('#' + divName4Edit).html(data);");
            strCodeForCs.Append("\r\n" + "resolve(true);");
            strCodeForCs.AppendFormat("\r\n" + "//setTimeout(() => {{ clsEditObj.BindTab(); }}, 100);");
            strCodeForCs.AppendFormat("\r\n" + "//clsEditObj.BindTab();");
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
            strCodeForCs.Append("\r\n * 显示对话框");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "public ShowDialog_{0}(strOp:string) {{", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.ShowDialog_{0}.name;", objViewInfoENEx.TabName_In);
            
            //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

            //strCodeForCs.Append("\r\n" + "   strOp = pstrOp;");
            strCodeForCs.Append("\r\n" + "//检查相关控件是否存在");
            strCodeForCs.AppendFormat("\r\n" + "clsCommFunc4Web.CheckControlExist(this.divName4Edit, \"div\", \"divEditDialog_{0}\");", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + "clsCommFunc4Web.CheckControlExist(this.divName4Edit, \"h4\", \"lblDialogTitle_{0}\");", objViewInfoENEx.TabName_In);
            
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
            strCodeForCs.AppendFormat("\r\n" + "clsCommFunc4Web.ShowDialog('#divEditDialog_{0}');", objViewInfoENEx.TabName_In);

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public string Gen_Vue_TS_HideDialog(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
        {
            StringBuilder strCodeForCs = new StringBuilder();
            strCodeForCs.Append("\r\n /**");
            strCodeForCs.Append("\r\n * 隐藏对话框");
            strCodeForCs.AppendFormat("\r\n * ({0})", clsStackTrace.GetCurrClassFunction());
            strCodeForCs.Append("\r\n **/");
            strCodeForCs.AppendFormat("\r\n" + "public HideDialog_{0}() {{", objViewInfoENEx.TabName_In);
            strCodeForCs.AppendFormat("\r\n" + "const strThisFuncName = this.HideDialog_{0}.name;", objViewInfoENEx.TabName_In);
            //strCodeForCs.Append("\r\n" + "console.log('strThisFuncName1', strThisFuncName);");

            strCodeForCs.AppendFormat("\r\n" + "clsCommFunc4Web.CheckControlExist(this.divName4Edit, \"div\", \"divEditDialog_{0}\");", objViewInfoENEx.TabName_In);

            strCodeForCs.AppendFormat("\r\n" + "clsCommFunc4Web.HideDialog('#divEditDialog_{0}');", objViewInfoENEx.TabName_In);

            strCodeForCs.Append("\r\n" + "}");
            return strCodeForCs.ToString();
        }

        public ImportClass AddImportClass()
        {
           arrI
                var obj = new ImportClass();
                obj.FilePath = "";
                return obj;
           
        }
    }
}
