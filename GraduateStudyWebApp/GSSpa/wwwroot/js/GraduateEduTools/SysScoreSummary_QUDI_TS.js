(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L0_Entity/GraduateEduTools/clsSysScoreSummaryEN.js", "../TS/L0_Entity/GraduateEduTools/clsvSysScoreSummaryEN.js", "../TS/L0_Entity/ParameterTable/clsSysScoreTypeEN.js", "../TS/L0_Entity/SysPara/clsSchoolYearEN.js", "../TS/PubFun/clsCommonFunc4Web2.js", "../TS/PubFun/clsPager.js", "../TS/L3_ForWApi/GraduateEduTools/clsSysScoreSummaryWApi.js", "../TS/L3_ForWApi/GraduateEduTools/clsvSysScoreSummaryWApi.js", "../TS/L3_ForWApi/SysPara/clsSchoolYearWApi.js", "../TS/L3_ForWApiEx/GraduateEdu/clsvSysScoreSummaryExWApi.js", "../TS/PubFun/clsOperateList2.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/L3_ForWApi/ParameterTable/clsSysScoreTypeWApi.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.SysScoreSummary_QUDI_TS = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:SysScoreSummary_QUDI_TS
    表名:SysScoreSummary(01120628)
    生成代码版本:2020.04.17.1
    生成日期:2020/04/22 17:34:18
    生成者:
    工程名称:问卷调查
    工程ID:0112
    相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
    PrjDataBaseId:0122
    模块中文名:研究生培养
    模块英文名:GraduateEdu
    框架-层名:WA_界面脚本后台_TS(WA_ViewScriptCS_TS)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //import * as $ from "jquery";
    //import * as QQ from "q";
    const clsSysScoreSummaryEN_js_1 = require("../TS/L0_Entity/GraduateEduTools/clsSysScoreSummaryEN.js");
    const clsvSysScoreSummaryEN_js_1 = require("../TS/L0_Entity/GraduateEduTools/clsvSysScoreSummaryEN.js");
    const clsSysScoreTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsSysScoreTypeEN.js");
    const clsSchoolYearEN_js_1 = require("../TS/L0_Entity/SysPara/clsSchoolYearEN.js");
    const clsCommonFunc4Web2_js_1 = require("../TS/PubFun/clsCommonFunc4Web2.js");
    const clsPager_js_1 = require("../TS/PubFun/clsPager.js");
    const clsSysScoreSummaryWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTools/clsSysScoreSummaryWApi.js");
    const clsvSysScoreSummaryWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTools/clsvSysScoreSummaryWApi.js");
    const clsSchoolYearWApi_js_1 = require("../TS/L3_ForWApi/SysPara/clsSchoolYearWApi.js");
    const clsvSysScoreSummaryExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEdu/clsvSysScoreSummaryExWApi.js");
    const clsOperateList2_js_1 = require("../TS/PubFun/clsOperateList2.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsSysScoreTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsSysScoreTypeWApi.js");
    /* SysScoreSummary_QUDI_TS 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
    */
    class SysScoreSummary_QUDI_TS extends clsOperateList2_js_1.clsOperateList {
        constructor() {
            super(...arguments);
            this.mstrListDiv = "divDataLst";
            this.objPager = new clsPager_js_1.clsPager();
            this.RecCount = 0;
        }
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 5;
        }
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
       */
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                //建立缓存
                //
                //const arrSchoolYear_Cache = await SchoolYear_GetObjLstAsync("1=1");//查询区域
                //const arrSysScoreType_Cache = await SysScoreType_GetObjLstAsync("1=1");//查询区域
                //const arrvSysScoreSummary_Cache = await vSysScoreSummary_GetObjLstAsync("1=1");
                //var objSchoolYear_Cond: clsSchoolYearEN = new clsSchoolYearEN();//查询区域
                var objSysScoreType_Cond = new clsSysScoreTypeEN_js_1.clsSysScoreTypeEN(); //查询区域
                const ddlSchoolYear_q = this.BindDdl_SchoolYear("ddlSchoolYear_q"); //查询区域
                //const ddlScoreTypeId_q = SysScoreType_BindDdl_ScoreTypeId_Cache("ddlScoreTypeId_q", objSysScoreType_Cond);//查询区域
                const ddlSchoolYear = this.BindDdl_SchoolYear("ddlSchoolYear"); //编辑区域
                //const ddlScoreTypeId = SysScoreType_BindDdl_ScoreTypeId_Cache("ddlScoreTypeId", objSysScoreType_Cond);//编辑区域
                this.hidSortvSysScoreSummaryBy = "schoolYear Asc";
                var strWhereCond = this.CombinevSysScoreSummaryCondition();
                const responseText = await (0, clsvSysScoreSummaryWApi_js_1.vSysScoreSummary_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_vSysScoreSummary();
            }
            catch (e) {
                var strMsg = `页面启动不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load_Cache)
       */
        async Page_Load_Cache() {
            // 在此处放置用户代码以初始化页面
            try {
                const arrSchoolYear_Cache = await (0, clsSchoolYearWApi_js_1.SchoolYear_GetObjLstAsync)("1=1"); //查询区域
                const arrSysScoreType_Cache = await (0, clsSysScoreTypeWApi_js_1.SysScoreType_GetObjLstAsync)("1=1"); //查询区域
                const arrvSysScoreSummary_Cache = await (0, clsvSysScoreSummaryWApi_js_1.vSysScoreSummary_GetObjLstAsync)("1=1");
                var objSchoolYear_Cond = new clsSchoolYearEN_js_1.clsSchoolYearEN(); //查询区域
                var objSysScoreType_Cond = new clsSysScoreTypeEN_js_1.clsSysScoreTypeEN(); //查询区域
                const ddlSchoolYear_q = (0, clsSchoolYearWApi_js_1.SchoolYear_BindDdl_SchoolYearInDiv_Cache)(this.divName4List, "ddlSchoolYear_q"); //查询区域
                const ddlScoreTypeId_q = (0, clsSysScoreTypeWApi_js_1.SysScoreType_BindDdl_ScoreTypeIdInDiv_Cache)(this.divName4List, "ddlScoreTypeId_q"); //查询区域
                const ddlSchoolYear = (0, clsSchoolYearWApi_js_1.SchoolYear_BindDdl_SchoolYearInDiv_Cache)(this.divName4List, "ddlSchoolYear"); //编辑区域
                const ddlScoreTypeId = (0, clsSysScoreTypeWApi_js_1.SysScoreType_BindDdl_ScoreTypeIdInDiv_Cache)(this.divName4List, "ddlScoreTypeId"); //编辑区域
                this.hidSortvSysScoreSummaryBy = "schoolYear Asc";
                var objvSysScoreSummary_Cond = this.CombinevSysScoreSummaryConditionObj();
                var strid_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls();
                this.RecCount = await (0, clsvSysScoreSummaryWApi_js_1.vSysScoreSummary_GetRecCountByCond_Cache)(objvSysScoreSummary_Cond, strid_CurrEduCls);
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_vSysScoreSummary_Cache();
            }
            catch (e) {
                var strMsg = `页面启动不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 根据条件获取相应的对象列表
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
       */
        async btnQuery_Click(strListDiv) {
            var strWhereCond = this.CombinevSysScoreSummaryCondition();
            try {
                const responseRecCount = await (0, clsvSysScoreSummaryWApi_js_1.vSysScoreSummary_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                var objPagerPara = {
                    pageIndex: 1,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvSysScoreSummaryBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvSysScoreSummaryWApi_js_1.vSysScoreSummary_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    var arrvSysScoreSummaryObjLst = jsonData;
                    this.BindTab_vSysScoreSummary(this.mstrListDiv, arrvSysScoreSummaryObjLst);
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `查询不成功,${e}.`;
                alert(strMsg);
            }
        }
        /// <summary>
        /// 为下拉框获取数据,从表:[schoolYear]中获取
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DdlBind_Cache)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
        BindDdl_SchoolYear(strDdlName) {
            var strWhereCond = " 1 =1 ";
            var objDdl = document.getElementById(strDdlName);
            if (objDdl == null) {
                var strMsg = `下拉框：${strDdlName} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsSchoolYearWApi_js_1.SchoolYear_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                        // const responseText = SchoolYear_GetObjLst_Cache().then((jsonData) => {
                        var arrSchoolYearObjLst = jsonData;
                        clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindDdl_ObjLst(strDdlName, arrSchoolYearObjLst, clsSchoolYearEN_js_1.clsSchoolYearEN.con_SchoolYear, clsSchoolYearEN_js_1.clsSchoolYearEN.con_SchoolYearName, "学年");
                        console.log("完成BindDdl_SchoolYearId!");
                        resolve(jsonData);
                    });
                    //var arrObjLst_Sel: Array<clsSchoolYearEN> = SchoolYear_GetObjLstAsync(strWhereCond);
                    //clsCommonFunc4Web.BindDdl_ObjLst(strDdlName, arrObjLst_Sel, clsSchoolYearEN.con_SchoolYear, clsSchoolYearEN.con_SchoolYearName, "学年");
                    console.log("完成BindDdl_SchoolYear!");
                }
                catch (e) {
                    var strMsg = `使用缓存对象列表绑定下拉框出错,${e}.`;
                    alert(strMsg);
                }
            });
        }
        /* 添加新记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
       */
        async btnAddNewRecord_Click() {
            this.OpType = "Add";
            try {
                const responseText = await this.AddNewRecord();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加新记录初始化不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 在数据表里修改记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecordInTab_Click)
       */
        btnUpdateRecordInTab_Click(strKeyId) {
            this.OpType = "Update";
            if (strKeyId == "") {
                alert("请选择需要修改的记录！");
                return;
            }
            var lngKeyId = Number(strKeyId);
            this.UpdateRecord(lngKeyId);
        }
        /*
        在数据表里删除记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecordInTab_Click)
       */
        async btnDelRecordInTab_Click(strKeyId) {
            try {
                if (strKeyId == "") {
                    alert("请选择需要删除的记录！");
                    return "";
                }
                var lngKeyId = Number(strKeyId);
                const responseText = await this.DelRecord(lngKeyId);
                const responseBindGv = await this.BindGv_vSysScoreSummary();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /*
        在数据表里选择记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnSelectRecordInTab_Click)
       */
        async btnSelectRecordInTab_Click(strKeyId) {
            try {
                if (strKeyId == "") {
                    alert("请选择需要删除的记录！");
                    return "";
                }
                var lngKeyId = Number(strKeyId);
                this.SelectRecord(lngKeyId);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `选择记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /*
        在数据表里详细信息记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDetailRecordInTab_Click)
       */
        async btnDetailRecordInTab_Click(strKeyId) {
            this.OpType = "Detail";
            try {
                if (strKeyId == "") {
                    alert("请选择需要详细信息的记录！");
                    return "";
                }
                var lngKeyId = Number(strKeyId);
                this.DetailRecord(lngKeyId);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `详细信息记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /*
        根据关键字删除记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
       */
        async DelRecord(lngmId) {
            try {
                const responseText = await (0, clsSysScoreSummaryWApi_js_1.SysScoreSummary_DelRecordAsync)(lngmId);
                var returnInt = responseText;
                if (returnInt > 0) {
                    var strInfo = `删除记录成功,共删除${returnInt}条记录!`;
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    var strInfo = `删除记录不成功!`;
                    //显示信息框
                    alert(strInfo);
                }
                console.log("完成DelRecord!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /*
        根据关键字详细信息记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DetailRecord)
         <param name = "sender">参数列表</param>
       */
        async DetailRecord(lngmId) {
            this.btnOKUpd = "";
            this.btnCancel = "关闭";
            try {
                const responseText = await (0, clsSysScoreSummaryWApi_js_1.SysScoreSummary_GetObjBymIdAsync)(lngmId);
                var objSysScoreSummaryEN = responseText;
                this.GetDataFromSysScoreSummaryClass(objSysScoreSummaryEN);
                console.log("完成DetailRecord!");
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        }
        /*
        根据关键字选择相应的记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SelectRecord)
         <param name = "sender">参数列表</param>
       */
        async SelectRecord(lngmId) {
            try {
                const responseText = await (0, clsSysScoreSummaryWApi_js_1.SysScoreSummary_GetObjBymIdAsync)(lngmId);
                var objSysScoreSummaryEN = responseText;
                console.log("完成SelectRecord!");
                clsCommonFunc4Web2_js_1.clsCommonFunc4Web.Redirect("/Index/Main_vSysScoreSummary");
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 修改记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
       */
        btnUpdateRecord_Click(strKeyId) {
            this.OpType = "Update";
            //var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
            if (strKeyId == "") {
                alert("请选择需要修改的记录！");
                return;
            }
            var lngKeyId = Number(strKeyId);
            this.UpdateRecord(lngKeyId);
        }
        /* 删除记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecord_Click)
       */
        async btnDelRecord_Click() {
            try {
                var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要删除的记录！");
                    return "";
                }
                const responseText = await this.DelMultiRecord(arrKeyIds);
                const responseBindGv = await this.BindGv_vSysScoreSummary();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /* 根据条件获取相应的对象列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnExportExcel_Click)
       */
        async btnExportExcel_Click() {
            var strWhereCond = " 1=1 ";
            try {
                const responseText = await (0, clsvSysScoreSummaryWApi_js_1.vSysScoreSummary_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    var arrvSysScoreSummaryObjLst = jsonData;
                    this.BindTab_vSysScoreSummary(this.mstrListDiv, arrvSysScoreSummaryObjLst);
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `导出Excel不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
         具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
       */
        async btnOKUpd_Click() {
            var strCommandText = this.btnOKUpd;
            try {
                switch (strCommandText) {
                    case "添加":
                        const responseText1 = await this.AddNewRecord();
                        break;
                    case "确认添加":
                        //这是一个单表的插入的代码,由于逻辑层太简单,
                        //就把逻辑层合并到控制层,
                        if (this.OpType == "AddWithMaxId") {
                            //const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData)=>{
                            //var returnBool2: boolean = jsonData;
                            //if (returnBool2 == true)
                            //{
                            //HideDialog();
                            //this.BindGv_vSysScoreSummary();
                            //}
                            //});
                        }
                        else {
                            const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    HideDialog();
                                    this.BindGv_vSysScoreSummary();
                                }
                            });
                        }
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                            var returnBool = jsonData;
                            var strInfo = returnBool ? "修改成功！" : "修改不成功！";
                            strInfo += "(In SysScoreSummary_QUDI_TS.btnOKUpd_Click)";
                            $('#lblResult51').val(strInfo);
                            //显示信息框
                            console.log(strInfo);
                            alert(strInfo);
                            if (returnBool == true) {
                                HideDialog();
                                this.BindGv_vSysScoreSummary();
                            }
                        });
                        break;
                    default:
                        var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnOKUpd_Click())`;
                        alert(strMsg);
                        break;
                }
            }
            catch (e) {
                var strMsg = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
                alert(strMsg);
            }
        }
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
         <returns>条件串(strWhereCond)</returns>
       */
        CombinevSysScoreSummaryCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.UserName_q != "") {
                    strWhereCond += ` And ${clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_UserName} like '% ${this.UserName_q}%'`;
                }
                if (this.SchoolYear_q != "" && this.SchoolYear_q != "0") {
                    strWhereCond += ` And ${clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_SchoolYear} = '${this.SchoolYear_q}'`;
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineSysScoreSummaryCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
         <returns>条件串(strWhereCond)</returns>
       */
        CombinevSysScoreSummaryConditionObj() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var objvSysScoreSummary_Cond = new clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.UserName_q != "") {
                    strWhereCond += ` And ${clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_UserName} like '% ${this.UserName_q}%'`;
                    objvSysScoreSummary_Cond.SetCondFldValue(clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_UserName, this.UserName_q, "like");
                }
                if (this.SchoolYear_q != "" && this.SchoolYear_q != "0") {
                    strWhereCond += ` And ${clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_SchoolYear} = '${this.SchoolYear_q}'`;
                    objvSysScoreSummary_Cond.SetCondFldValue(clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_SchoolYear, this.SchoolYear_q, "=");
                }
                if (this.ScoreTypeId_q != "" && this.ScoreTypeId_q != "0") {
                    strWhereCond += ` And ${clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_ScoreTypeId} = '${this.ScoreTypeId_q}'`;
                    objvSysScoreSummary_Cond.SetCondFldValue(clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_ScoreTypeId, this.ScoreTypeId_q, "=");
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0005)在组合查询条件对象(CombineSysScoreSummaryConditionObj)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return objvSysScoreSummary_Cond;
        }
        /* 显示vSysScoreSummary对象的所有属性值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
         <param name = "divContainer">显示容器</param>
         <param name = "arrSysScoreSummaryObjLst">需要绑定的对象列表</param>
       */
        BindTab_vSysScoreSummary(divContainer, arrvSysScoreSummaryObjLst) {
            var o = document.getElementById(divContainer);
            if (o == null) {
                alert(`${divContainer}不存在！`);
                return;
            }
            var arrDataColumn = [
                {
                    FldName: "",
                    ColHeader: "",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "CheckBox",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "schoolYear",
                    ColHeader: "学年",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "userName",
                    ColHeader: "用户名",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "collegeName",
                    ColHeader: "学院名称",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "majorName",
                    ColHeader: "专业名称",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "gradeBaseName",
                    ColHeader: "年级名称",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "ScoreTypeName",
                    ColHeader: "分数类型名称",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                //{
                //    FldName: "",
                //    ColHeader: "修改",
                //    Text: "修改",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Button",
                //    orderNum: 1,
                //    FuncName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btnUpdateRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
                //{
                //    FldName: "",
                //    ColHeader: "删除",
                //    Text: "删除",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Button",
                //    orderNum: 1,
                //    FuncName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
            ];
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindTabV2(o, arrvSysScoreSummaryObjLst, arrDataColumn, "mId");
            this.objPager.RecCount = this.RecCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        /* 函数功能:在数据 列表中跳转到某一页
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
         <param name = "intPageIndex">页序号</param>
       */
        async IndexPage(intPageIndex) {
            if (intPageIndex == 0) {
                intPageIndex = this.objPager.PageCount;
            }
            console.log("跳转到" + intPageIndex + "页");
            this.setCurrPageIndex(intPageIndex, this.divName4Pager);
            this.BindGv_vSysScoreSummary();
        }
        /* 根据条件获取相应的对象列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
       */
        async BindGv_vSysScoreSummary() {
            var strListDiv = this.mstrListDiv;
            var strWhereCond = this.CombinevSysScoreSummaryCondition();
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrvSysScoreSummaryNumObjLst = [];
            var arrvSysScoreSummaryObjLst = [];
            try {
                const responseRecCount = await (0, clsvSysScoreSummaryWApi_js_1.vSysScoreSummary_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvSysScoreSummaryBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst1 = await (0, clsvSysScoreSummaryExWApi_js_1.vSysScoreSummaryEx_GetUserNumObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrvSysScoreSummaryNumObjLst = jsonData;
                });
                const responseObjLst2 = await (0, clsvSysScoreSummaryWApi_js_1.vSysScoreSummary_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvSysScoreSummaryObjLst = jsonData;
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                alert(strMsg);
            }
            //if (arrvSysScoreSummaryObjLst.length == 0) {
            //    var strMsg: string = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
            //    alert(strMsg);
            //    return;
            //}
            try {
                arrvSysScoreSummaryNumObjLst;
                this.BindTab_vSysScoreSummary(strListDiv, arrvSysScoreSummaryObjLst);
                console.log("完成BindGv_vSysScoreSummary!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /* 根据条件获取相应的对象列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv_Cache)
       */
        async BindGv_vSysScoreSummary_Cache() {
            var strListDiv = this.mstrListDiv;
            var objvSysScoreSummary_Cond = this.CombinevSysScoreSummaryConditionObj();
            var strWhereCond = JSON.stringify(objvSysScoreSummary_Cond);
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrvSysScoreSummaryObjLst = [];
            try {
                var strid_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls();
                //const arrvSysScoreSummary_Cache = await vSysScoreSummary_GetObjLstAsync("1=1");
                this.RecCount = await (0, clsvSysScoreSummaryWApi_js_1.vSysScoreSummary_GetRecCountByCond_Cache)(objvSysScoreSummary_Cond, strid_CurrEduCls);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvSysScoreSummaryBy,
                    sortFun: (x, y) => { return 0; }
                };
                var arrvSysScoreSummaryObjLst = await (0, clsvSysScoreSummaryWApi_js_1.vSysScoreSummary_GetObjLstByPager_Cache)(objPagerPara, strid_CurrEduCls);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                alert(strMsg);
            }
            if (arrvSysScoreSummaryObjLst.length == 0) {
                var strMsg = `在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=SysScoreSummary)`;
                alert(strMsg);
                return;
            }
            try {
                this.BindTab_vSysScoreSummary(strListDiv, arrvSysScoreSummaryObjLst);
                console.log("完成BindGv_vSysScoreSummary!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /* 函数功能:从界面列表中根据某一个字段排序
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortBy)
         <param name = "strSortByFld">排序的字段</param>
       */
        async SortBy(strSortByFld) {
            if (this.hidSortvSysScoreSummaryBy.indexOf(strSortByFld) >= 0) {
                if (this.hidSortvSysScoreSummaryBy.indexOf("Asc") >= 0) {
                    this.hidSortvSysScoreSummaryBy = `${strSortByFld} Desc`;
                }
                else {
                    this.hidSortvSysScoreSummaryBy = `${strSortByFld} Asc`;
                }
            }
            else {
                this.hidSortvSysScoreSummaryBy = `${strSortByFld} Asc`;
            }
            const responseBindGv = await this.BindGv_vSysScoreSummary();
        }
        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Clear)
        /// </summary>	
        Clear() {
            this.userId = "";
            $('#ddlSchoolYear option[0]').attr("selected", true);
            $('#ddlScoreTypeId option[0]').attr("selected", true);
            this.updUser = "";
            this.updDate = "";
            this.memo = "";
        }
        /* 为插入记录做准备工作
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
       */
        async AddNewRecord() {
            this.btnOKUpd = "确认添加";
            this.btnCancel = "取消添加";
            this.Clear();
            //wucSysScoreSummaryB1.mId = clsSysScoreSummaryBL.GetMaxStrId_S();
        }
        /* 为插入记录做准备工作
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxId)
       */
        AddNewRecordWithMaxId() {
            this.btnOKUpd = "确认添加";
            this.btnCancel = "取消添加";
            this.Clear();
            //wucSysScoreSummaryB1.mId = clsSysScoreSummaryBL.GetMaxStrId_S();
        }
        /* 函数功能:把界面上的属性数据传到类对象中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
         <param name = "pobjSysScoreSummaryEN">数据传输的目的类对象</param>
       */
        PutDataToSysScoreSummaryClass(pobjSysScoreSummaryEN) {
            pobjSysScoreSummaryEN.userId = this.userId; // 用户ID
            pobjSysScoreSummaryEN.schoolYear = this.schoolYear; // 学年
            pobjSysScoreSummaryEN.scoreTypeId = this.scoreTypeId; // 分数类型Id
            pobjSysScoreSummaryEN.updUser = this.updUser; // 修改人
            pobjSysScoreSummaryEN.updDate = this.updDate; // 修改日期
            pobjSysScoreSummaryEN.memo = this.memo; // 备注
        }
        /* 添加新记录，保存函数
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
       */
        async AddNewRecordSave() {
            this.DivName = "divAddNewRecordSave";
            var objSysScoreSummaryEN = new clsSysScoreSummaryEN_js_1.clsSysScoreSummaryEN();
            this.PutDataToSysScoreSummaryClass(objSysScoreSummaryEN);
            try {
                const responseText2 = await (0, clsSysScoreSummaryWApi_js_1.SysScoreSummary_AddNewRecordAsync)(objSysScoreSummaryEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strInfo = `添加记录成功!`;
                    $('#lblResult46').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    var strInfo = `添加记录不成功!`;
                    $('#lblResult46').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                return responseText2; //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加记录不成功,${e}.`;
                alert(strMsg);
                return false;
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        /* 函数功能:把以该关键字的记录内容显示在界面上,
              在这里是把值传到表控件中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowData)
         <param name = "lngmId">表记录的关键字,显示该表关键字的内容</param>
       */
        async ShowData(lngmId) {
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            var objSysScoreSummaryEN = new clsSysScoreSummaryEN_js_1.clsSysScoreSummaryEN();
            try {
                const responseText = await (0, clsSysScoreSummaryWApi_js_1.SysScoreSummary_IsExistAsync)(lngmId);
                var returnBool = responseText;
                if (returnBool == false) {
                    var strInfo = `关键字:[${lngmId}] 的记录不存在!`;
                    //$('#lblResult1').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                else {
                }
            }
            catch (e) {
                var strMsg = `检查相应关键字的记录存在不成功, ${e}.`;
                alert(strMsg);
            }
            try {
                const responseText = await (0, clsSysScoreSummaryWApi_js_1.SysScoreSummary_GetObjBymIdAsync)(lngmId);
                objSysScoreSummaryEN = responseText;
            }
            catch (e) {
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
            //3、用提供的关键字初始化一个类对象；
            this.GetDataFromSysScoreSummaryClass(objSysScoreSummaryEN);
        }
        /* 函数功能:把类对象的属性内容显示到界面上
        注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
         如果在设置数据库时,就应该一级字段在前,二级字段在后
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
         <param name = "pobjSysScoreSummaryEN">表实体类对象</param>
       */
        GetDataFromSysScoreSummaryClass(pobjSysScoreSummaryEN) {
            this.userId = pobjSysScoreSummaryEN.userId; // 用户ID
            this.schoolYear = pobjSysScoreSummaryEN.schoolYear; // 学年
            this.scoreTypeId = pobjSysScoreSummaryEN.scoreTypeId; // 分数类型Id
            this.updUser = pobjSysScoreSummaryEN.updUser; // 修改人
            this.updDate = pobjSysScoreSummaryEN.updDate; // 修改日期
            this.memo = pobjSysScoreSummaryEN.memo; // 备注
        }
        /* 根据关键字获取相应的记录的对象
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
         <param name = "sender">参数列表</param>
       */
        async UpdateRecord(lngmId) {
            this.btnOKUpd = "确认修改";
            this.btnCancel = "取消修改";
            this.KeyId = lngmId.toString();
            try {
                const responseText = await (0, clsSysScoreSummaryWApi_js_1.SysScoreSummary_GetObjBymIdAsync)(lngmId);
                var objSysScoreSummaryEN = responseText;
                this.GetDataFromSysScoreSummaryClass(objSysScoreSummaryEN);
                console.log("完成UpdateRecord!");
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 修改记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
       */
        async UpdateRecordSave() {
            this.DivName = "divUpdateRecordSave";
            var objSysScoreSummaryEN = new clsSysScoreSummaryEN_js_1.clsSysScoreSummaryEN();
            objSysScoreSummaryEN.mId = Number(this.KeyId);
            this.PutDataToSysScoreSummaryClass(objSysScoreSummaryEN);
            objSysScoreSummaryEN.sf_UpdFldSetStr = objSysScoreSummaryEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objSysScoreSummaryEN.mId == 0 || objSysScoreSummaryEN.mId == undefined) {
                throw "关键字不能为空!";
            }
            try {
                const responseText = await (0, clsSysScoreSummaryWApi_js_1.SysScoreSummary_UpdateRecordAsync)(objSysScoreSummaryEN);
                var returnBool = !!responseText;
                if (returnBool == true) {
                }
                return returnBool;
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `修改记录不成功,${e}.`;
                alert(strMsg);
                return false;
            }
            return true;
        }
        /* 根据关键字列表删除记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelMultiRecord)
       */
        async DelMultiRecord(arrmId) {
            try {
                const responseText = await (0, clsSysScoreSummaryWApi_js_1.SysScoreSummary_DelSysScoreSummarysAsync)(arrmId);
                var returnInt = responseText;
                if (returnInt > 0) {
                    var strInfo = `删除记录成功,共删除${returnInt}条记录!`;
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    var strInfo = `删除记录不成功!`;
                    //显示信息框
                    alert(strInfo);
                }
                console.log("完成DelMultiRecord!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /* 显示{0}对象的所有属性值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowTabObj)
         <param name = "divContainer">显示容器</param>
         <param name = "objSysScoreSummary">需要显示的对象</param>
       */
        ShowSysScoreSummaryObj(divContainer, objSysScoreSummary) {
            var o = document.getElementById(divContainer);
            if (o == null) {
                alert(`${divContainer}不存在！`);
                return;
            }
            var sstrKeys = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetObjKeys(objSysScoreSummary);
            var ul = document.createElement("ul");
            for (let strKey of sstrKeys) {
                var strValue = objSysScoreSummary[strKey];
                var li = document.createElement("li");
                li.innerHTML = `${strKey}:${strValue}`;
                ul.appendChild(li);
            }
            o.appendChild(ul);
        }
        /* 函数功能:从界面列表中获取第一个关键字的值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
         <param name = "pobjSysScoreSummaryEN">表实体类对象</param>
        <returns>列表的第一个关键字值</returns>
       */
        GetFirstKey() {
            if (clsCommonFunc4Web2_js_1.arrSelectedKeys.length == 1) {
                return clsCommonFunc4Web2_js_1.arrSelectedKeys[0];
            }
            else {
                alert(`请选择一个关键字！目前选择了:${clsCommonFunc4Web2_js_1.arrSelectedKeys.length}个关键字。`);
                return "";
            }
        }
        /*
        演示Session 操作
          (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Demo_Session)
        */
        async Demo_Session() {
            try {
                //设置Session
                var strUserId = "TestUserId";
                await this.SetSessionAsync("userId", strUserId);
                //获取Session
                var strUserId_Value1 = await this.GetSessionAsync("userId");
                console.log('strUserId_Value1:' + strUserId_Value1);
                //获取Session方法2：直接读取页面中的hidUserId
                var strUserId_Value2 = this.hidUserId;
                console.log('strUserId_Value2:' + strUserId_Value2);
            }
            catch (e) {
                var strMsg = `演示Session不成功,${e}.`;
                alert(strMsg);
            }
        }
        /*
        设置Session
          (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetSessionAsync)
        <param name = "Key">关键字</param>
        <param name = "Value">值</param>
        */
        SetSessionAsync(Key, Value) {
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl_Session_SetString,
                    cache: false,
                    async: false,
                    type: 'get',
                    dataType: "json",
                    data: {
                        Key: Key,
                        Value: Value
                    },
                    success: function (data) {
                        var strKey = data.key;
                        var strValue = data.value;
                        console.log('strKey, strValue=' + strKey + strValue);
                    }
                });
            });
        }
        /*
        获取Session 关键字的值
          (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetSessionAsync)
        <param name = "Key">关键字</param>
         <return>值</return>
        */
        GetSessionAsync(Key) {
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl_Session_GetString,
                    cache: false,
                    async: false,
                    type: 'get',
                    dataType: "json",
                    data: {
                        Key: Key,
                    },
                    success: function (data) {
                        var strKey = data.key;
                        var strValue = data.value;
                        console.log('strKey, strValue=' + strKey + strValue);
                        resolve(data);
                    },
                    error: function (result) {
                        console.log(result);
                        console.log(JSON.stringify(result));
                        if (result.statusText == "error") {
                            var strInfo = `网络错误！访问网络不成功！`;
                            reject(strInfo);
                        }
                        else {
                            reject(result.statusText);
                        }
                    }
                });
            });
        }
        /*
        * 设置取消按钮的标题
       */
        set btnCancel(value) {
            $("#btnCancel").html(value);
        }
        /*
        * 设置确定按钮的标题
       */
        set btnOKUpd(value) {
            $("#btnOKUpd").html(value);
        }
        /*
        * 获取按钮的标题
       */
        get btnOKUpd() {
            return $("#btnOKUpd").html();
        }
        /*
        * 设置当前页序号
       */
        set CurrPageIndex(value) {
            $("#hidCurrPageIndex").val(value);
        }
        /*
        * 获取当前页序号
       */
        get CurrPageIndex() {
            return $("#hidCurrPageIndex").val();
        }
        /*
        * 添加、修改用的层名
       */
        set DivName(value) {
            $("#hidDivName").val(value);
        }
        /*
        * 设置排序字段-相当使用ViewState功能
       */
        set hidSortvSysScoreSummaryBy(value) {
            $("#hidSortvSysScoreSummaryBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvSysScoreSummaryBy() {
            return $("#hidSortvSysScoreSummaryBy").val();
        }
        /*
        * 用户Id
       */
        get hidUserId() {
            return $("#hidUserId").val();
        }
        /*
        * 设置关键字的值
       */
        set KeyId(value) {
            $("#hidKeyId").val(value);
        }
        /*
        * 设置关键字的值
       */
        get KeyId() {
            return $("#hidKeyId").val();
        }
        /*
        * 备注
       */
        set memo(value) {
            $("#txtMemo").val(value);
        }
        /*
        * 备注
       */
        get memo() {
            return $("#txtMemo").val();
        }
        /*
        * 设置操作类型：Add||Update||Detail
       */
        set OpType(value) {
            $("#hidOpType").val(value);
        }
        /*
        * 设置操作类型：Add||Update||Detail
       */
        get OpType() {
            return $("#hidOpType").val();
        }
        /*
        * 学年
       */
        set schoolYear(value) {
            $("#ddlSchoolYear").val(value);
        }
        /*
        * 学年
       */
        get schoolYear() {
            return $("#ddlSchoolYear").val();
        }
        /*
        * 学年
       */
        get SchoolYear_q() {
            return $("#ddlSchoolYear_q").val();
        }
        /*
        * 分数类型Id
       */
        set scoreTypeId(value) {
            $("#ddlScoreTypeId").val(value);
        }
        /*
        * 分数类型Id
       */
        get scoreTypeId() {
            return $("#ddlScoreTypeId").val();
        }
        /*
        * 分数类型Id
       */
        get ScoreTypeId_q() {
            return $("#ddlScoreTypeId_q").val();
        }
        /*
        * 修改日期
       */
        set updDate(value) {
            $("#txtUpdDate").val(value);
        }
        /*
        * 修改日期
       */
        get updDate() {
            return $("#txtUpdDate").val();
        }
        /*
        * 修改人
       */
        set updUser(value) {
            $("#txtUpdUser").val(value);
        }
        /*
        * 修改人
       */
        get updUser() {
            return $("#txtUpdUser").val();
        }
        /*
        * 用户ID
       */
        set userId(value) {
            $("#txtUserId").val(value);
        }
        /*
        * 用户ID
       */
        get userId() {
            return $("#txtUserId").val();
        }
        /*
        * 用户名
       */
        get UserName_q() {
            return $("#txtUserName_q").val();
        }
    }
    exports.SysScoreSummary_QUDI_TS = SysScoreSummary_QUDI_TS;
});
