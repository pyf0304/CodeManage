(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L0_Entity/GraduateEduPaper/clsJournalSubjectCategoryEN.js", "../TS/L3_ForWApi/GraduateEduPaper/clsJournalSubjectCategoryWApi.js", "../TS/PubFun/clsCommonFunc4Web2.js", "../TS/PubFun/clsOperateList2.js", "../TS/PubFun/clsString2.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.JournalSubjectCategoryCRUD = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:JournalSubjectCategoryCRUD(界面:JournalSubjectCategoryCRUD)
    表名:JournalSubjectCategory(01120931)
    生成代码版本:2021.06.19.1
    生成日期:2021/06/20 00:12:23
    生成者:
    工程名称:问卷调查
    工程ID:0112
    相关数据库:103.116.76.183,9433EduHigh_Jsie
    PrjDataBaseId:0170
    模块中文名:研培论文
    模块英文名:GraduateEduPaper
    框架-层名:WA_界面后台_TS(WA_ViewScriptCS_TS)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //import * as $ from "jquery";
    //import * as QQ from "q";
    const clsJournalSubjectCategoryEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsJournalSubjectCategoryEN.js");
    const clsJournalSubjectCategoryWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsJournalSubjectCategoryWApi.js");
    const clsCommonFunc4Web2_js_1 = require("../TS/PubFun/clsCommonFunc4Web2.js");
    const clsOperateList2_js_1 = require("../TS/PubFun/clsOperateList2.js");
    const clsString2_js_1 = require("../TS/PubFun/clsString2.js");
    /* JournalSubjectCategoryCRUD 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
   */
    class JournalSubjectCategoryCRUD extends clsOperateList2_js_1.clsOperateList {
        constructor() {
            super();
            this.divName4Query = "divQuery"; //查询区的层Id
            this.divName4Function = "divFunction"; //功能区的层Id
            this.RecCount = 0;
            JournalSubjectCategoryCRUD.objPage_CRUD = this;
        }
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 5;
        }
        /* 函数功能:设置事件函数
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetEventFunc)
       */
        async SetEventFunc() {
            // 在此处放置用户代码以初始化页面
            try {
            }
            catch (e) {
                var strMsg = `页面启动不成功,${e}.`;
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load_Cache)
       */
        async Page_Load_Cache() {
            // 在此处放置用户代码以初始化页面
            try {
                // 为查询区绑定下拉框
                const gvBindDdl = await this.BindDdl4QueryRegion();
                this.SetEventFunc();
                this.hidSortJournalSubjectCategoryBy = "journalSubjectCategoryId Asc";
                if (this.bolIsInitShow == false) //
                 {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true; //
                }
                //2、显示无条件的表内容在GridView中
                const responseBindGv = await this.BindGv_JournalSubjectCategory_Cache();
            }
            catch (e) {
                var strMsg = `页面启动不成功,${e}.`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
            }
        }
        /* 根据条件获取相应的对象列表
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
       */
        async btnQuery_Click() {
            this.setCurrPageIndex(1, this.divName4Pager);
            const responseBindGv = await this.BindGv_JournalSubjectCategory_Cache();
        }
        /* 合并数据
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineData)
       */
        CombineData(arrJournalSubjectCategoryObjLst, arrDataColumn) {
            var intRowNum = arrJournalSubjectCategoryObjLst.length;
            var intColNum = arrDataColumn.length;
            var arrData = new Array();
            var arrHead = new Array();
            for (var j = 0; j < intColNum; j++) {
                arrHead.push(arrDataColumn[j].ColHeader);
            }
            arrData.push(arrHead);
            for (var i = 0; i < intRowNum; i++) {
                var arrRow = new Array();
                var objEN = arrJournalSubjectCategoryObjLst[i];
                for (var j = 0; j < intColNum; j++) {
                    arrRow.push(objEN[arrDataColumn[j].FldName]); //i + "" + j;
                }
                arrData.push(arrRow);
            }
            console.log("arrData", arrData);
            var strFileName = clsString2_js_1.clsString.Format("期刊学科门类({0})导出.xlsx", clsJournalSubjectCategoryEN_js_1.clsJournalSubjectCategoryEN._CurrTabName);
            exportSpecialExcel_pyf(arrData, strFileName);
        }
        /* 根据条件获取相应的对象列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ExportExcel_Cache)
       */
        async ExportExcel_JournalSubjectCategory_Cache() {
            if (this.hidSortJournalSubjectCategoryBy == null) {
                var strMsg = `在显示列表时，排序字段(hidSortJournalSubjectCategoryBy)为空，请检查！(In BindGv_JournalSubjectCategory_Cache)`;
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            var strListDiv = this.mstrListDiv;
            var objJournalSubjectCategory_Cond = this.CombineJournalSubjectCategoryConditionObj4ExportExcel();
            var strWhereCond = JSON.stringify(objJournalSubjectCategory_Cond);
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrJournalSubjectCategoryObjLst = [];
            try {
                this.RecCount = await (0, clsJournalSubjectCategoryWApi_js_1.JournalSubjectCategory_GetRecCountByCond_Cache)(objJournalSubjectCategory_Cond);
                if (this.RecCount == 0) {
                    var lblMsg = document.createElement("span");
                    lblMsg.innerHTML = clsString2_js_1.clsString.Format("根据条件:[{0}]获取的对象列表数为0！", objJournalSubjectCategory_Cond.whereCond);
                    var divDataLst = document.getElementById("divDataLst");
                    if (divDataLst != null) {
                        divDataLst.innerText = "";
                        divDataLst.appendChild(lblMsg);
                    }
                    var strMsg = `在绑定Gv_Cache过程中，根据条件:[${objJournalSubjectCategory_Cond.whereCond}]获取的对象列表数为0！`;
                    console.error("Error: ", strMsg);
                    //console.trace();
                    alert(strMsg);
                    return;
                }
                var arrJournalSubjectCategoryObjLst = await (0, clsJournalSubjectCategoryWApi_js_1.JournalSubjectCategory_GetSubObjLst_Cache)(objJournalSubjectCategory_Cond);
            }
            catch (e) {
                var strMsg = `绑定GridView不成功,${e}.`;
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            if (arrJournalSubjectCategoryObjLst.length == 0) {
                var strKey = `${clsJournalSubjectCategoryEN_js_1.clsJournalSubjectCategoryEN._CurrTabName}`;
                var strMsg = `在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=${strKey})`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            try {
                var arrDataColumn = [
                    {
                        FldName: "journalSubjectCategoryId",
                        SortBy: "",
                        ColHeader: "期刊学科门类Id",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 2,
                        FuncName: () => { }
                    },
                    {
                        FldName: "journalSubjectCategoryName",
                        SortBy: "",
                        ColHeader: "期刊学科门类名称",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 3,
                        FuncName: () => { }
                    },
                    {
                        FldName: "updDate",
                        SortBy: "",
                        ColHeader: "修改日期",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 4,
                        FuncName: () => { }
                    },
                    {
                        FldName: "updUser",
                        SortBy: "",
                        ColHeader: "修改人",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 5,
                        FuncName: () => { }
                    },
                    {
                        FldName: "memo",
                        SortBy: "",
                        ColHeader: "备注",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 6,
                        FuncName: () => { }
                    },
                ];
                arrJournalSubjectCategoryObjLst = arrJournalSubjectCategoryObjLst.sort(this.SortFun_ExportExcel);
                this.CombineData(arrJournalSubjectCategoryObjLst, arrDataColumn);
                console.log("完成BindGv_JournalSubjectCategory!");
            }
            catch (e) {
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /* 根据条件获取相应的对象列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ExportExcel)
       */
        async ExportExcel_JournalSubjectCategory() {
            if (this.hidSortJournalSubjectCategoryBy == null) {
                var strMsg = `在显示列表时，排序字段(hidSortJournalSubjectCategoryBy)为空，请检查！(In BindGv_JournalSubjectCategory_Cache)`;
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            var strListDiv = this.mstrListDiv;
            var strWhereCond = this.CombineJournalSubjectCategoryCondition();
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrJournalSubjectCategoryObjLst = [];
            try {
                this.RecCount = await (0, clsJournalSubjectCategoryWApi_js_1.JournalSubjectCategory_GetRecCountByCondAsync)(strWhereCond);
                if (this.RecCount == 0) {
                    var lblMsg = document.createElement("span");
                    lblMsg.innerHTML = clsString2_js_1.clsString.Format("根据条件:[{0}]获取的对象列表数为0！", strWhereCond);
                    var divDataLst = document.getElementById("divDataLst");
                    if (divDataLst != null) {
                        divDataLst.innerText = "";
                        divDataLst.appendChild(lblMsg);
                    }
                    var strMsg = `在绑定ExportExcel过程中，根据条件:[${strWhereCond}]获取的对象列表数为0！`;
                    console.error("Error: ", strMsg);
                    //console.trace();
                    alert(strMsg);
                    return;
                }
                var arrJournalSubjectCategoryObjLst = await (0, clsJournalSubjectCategoryWApi_js_1.JournalSubjectCategory_GetObjLstAsync)(strWhereCond);
            }
            catch (e) {
                var strMsg = `绑定GridView不成功,${e}.`;
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            if (arrJournalSubjectCategoryObjLst.length == 0) {
                var strMsg = `在ExportExcel过程中，根据条件对象获取的对象列表数为0！`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            try {
                var arrDataColumn = [
                    {
                        FldName: "journalSubjectCategoryId",
                        SortBy: "",
                        ColHeader: "期刊学科门类Id",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 2,
                        FuncName: () => { }
                    },
                    {
                        FldName: "journalSubjectCategoryName",
                        SortBy: "",
                        ColHeader: "期刊学科门类名称",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 3,
                        FuncName: () => { }
                    },
                    {
                        FldName: "updDate",
                        SortBy: "",
                        ColHeader: "修改日期",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 4,
                        FuncName: () => { }
                    },
                    {
                        FldName: "updUser",
                        SortBy: "",
                        ColHeader: "修改人",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 5,
                        FuncName: () => { }
                    },
                    {
                        FldName: "memo",
                        SortBy: "",
                        ColHeader: "备注",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 6,
                        FuncName: () => { }
                    },
                ];
                arrJournalSubjectCategoryObjLst = arrJournalSubjectCategoryObjLst.sort(this.SortFun_ExportExcel);
                this.CombineData(arrJournalSubjectCategoryObjLst, arrDataColumn);
                console.log("完成BindGv_JournalSubjectCategory!");
            }
            catch (e) {
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /* 函数功能:为查询区绑定下拉框
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4QueryRegion)
       */
        async BindDdl4QueryRegion() {
            // 在此处放置用户代码以初始化页面
        }
        /*
         添加新记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnCopyRecord_Click)
        */
        async btnCopyRecord_Click() {
            try {
                var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要克隆的记录！");
                    return "";
                }
                const responseText = await this.CopyRecord(arrKeyIds);
                const responseBindGv = await this.BindGv_JournalSubjectCategory_Cache();
            }
            catch (e) {
                var strMsg = `复制记录不成功,${e}.`;
                console.error(strMsg);
                alert(strMsg);
            }
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
                if (clsCommonFunc4Web2_js_1.clsCommonFunc4Web.confirm_del(0) == false) {
                    return;
                }
                const responseText = await this.DelRecord(strKeyId);
                const responseBindGv = await this.BindGv_JournalSubjectCategory_Cache();
            }
            catch (e) {
                var strMsg = `删除记录不成功. ${e}.`;
                console.error(strMsg);
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
                if (clsCommonFunc4Web2_js_1.clsCommonFunc4Web.confirm_del(0) == false) {
                    return;
                }
                this.SelectRecord(strKeyId);
            }
            catch (e) {
                var strMsg = `选择记录不成功. ${e}.`;
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /*
        根据关键字删除记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
       */
        async DelRecord(strJournalSubjectCategoryId) {
            try {
                const responseText = await (0, clsJournalSubjectCategoryWApi_js_1.JournalSubjectCategory_DelRecordAsync)(strJournalSubjectCategoryId);
                var returnInt = responseText;
                if (returnInt > 0) {
                    (0, clsJournalSubjectCategoryWApi_js_1.JournalSubjectCategory_ReFreshCache)();
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
                var strMsg = `删除记录不成功. ${e}.`;
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /*
        根据关键字选择相应的记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SelectRecord)
         <param name = "sender">参数列表</param>
       */
        async SelectRecord(strJournalSubjectCategoryId) {
            try {
                const responseText = await (0, clsJournalSubjectCategoryWApi_js_1.JournalSubjectCategory_GetObjByJournalSubjectCategoryIdAsync)(strJournalSubjectCategoryId);
                var objJournalSubjectCategoryEN = responseText;
                console.log("完成SelectRecord!");
                clsCommonFunc4Web2_js_1.clsCommonFunc4Web.Redirect("/Index/Main_JournalSubjectCategory");
            }
            catch (e) {
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
            }
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
                if (clsCommonFunc4Web2_js_1.clsCommonFunc4Web.confirm_del(arrKeyIds.length) == false) {
                    return;
                }
                const responseText = await this.DelMultiRecord(arrKeyIds);
                const responseBindGv = await this.BindGv_JournalSubjectCategory_Cache();
            }
            catch (e) {
                var strMsg = `删除记录不成功. ${e}.`;
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /* 根据条件获取相应的对象列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnExportExcel_Click)
       */
        async btnExportExcel_Click() {
            const responseBindGv = await this.ExportExcel_JournalSubjectCategory_Cache();
        }
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
         <returns>条件串(strWhereCond)</returns>
       */
        CombineJournalSubjectCategoryCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.JournalSubjectCategoryId_q != "") {
                    strWhereCond += ` And ${clsJournalSubjectCategoryEN_js_1.clsJournalSubjectCategoryEN.con_JournalSubjectCategoryId} like '% ${this.JournalSubjectCategoryId_q}%'`;
                }
                if (this.JournalSubjectCategoryName_q != "") {
                    strWhereCond += ` And ${clsJournalSubjectCategoryEN_js_1.clsJournalSubjectCategoryEN.con_JournalSubjectCategoryName} like '% ${this.JournalSubjectCategoryName_q}%'`;
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0009)在组合查询条件(CombineJournalSubjectCategoryCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
         <returns>条件串(strWhereCond)</returns>
       */
        CombineJournalSubjectCategoryConditionObj() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var objJournalSubjectCategory_Cond = new clsJournalSubjectCategoryEN_js_1.clsJournalSubjectCategoryEN();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.JournalSubjectCategoryId_q != "") {
                    strWhereCond += ` And ${clsJournalSubjectCategoryEN_js_1.clsJournalSubjectCategoryEN.con_JournalSubjectCategoryId} like '% ${this.JournalSubjectCategoryId_q}%'`;
                    objJournalSubjectCategory_Cond.SetCondFldValue(clsJournalSubjectCategoryEN_js_1.clsJournalSubjectCategoryEN.con_JournalSubjectCategoryId, this.JournalSubjectCategoryId_q, "like");
                }
                if (this.JournalSubjectCategoryName_q != "") {
                    strWhereCond += ` And ${clsJournalSubjectCategoryEN_js_1.clsJournalSubjectCategoryEN.con_JournalSubjectCategoryName} like '% ${this.JournalSubjectCategoryName_q}%'`;
                    objJournalSubjectCategory_Cond.SetCondFldValue(clsJournalSubjectCategoryEN_js_1.clsJournalSubjectCategoryEN.con_JournalSubjectCategoryName, this.JournalSubjectCategoryName_q, "like");
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0010)在组合查询条件对象(CombineJournalSubjectCategoryConditionObj)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            objJournalSubjectCategory_Cond.whereCond = strWhereCond;
            return objJournalSubjectCategory_Cond;
        }
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj4ExportExcel)
         <returns>条件串(strWhereCond)</returns>
       */
        CombineJournalSubjectCategoryConditionObj4ExportExcel() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var objJournalSubjectCategory_Cond = new clsJournalSubjectCategoryEN_js_1.clsJournalSubjectCategoryEN();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.JournalSubjectCategoryId_q != "") {
                    strWhereCond += ` And ${clsJournalSubjectCategoryEN_js_1.clsJournalSubjectCategoryEN.con_JournalSubjectCategoryId} like '% ${this.JournalSubjectCategoryId_q}%'`;
                    objJournalSubjectCategory_Cond.SetCondFldValue(clsJournalSubjectCategoryEN_js_1.clsJournalSubjectCategoryEN.con_JournalSubjectCategoryId, this.JournalSubjectCategoryId_q, "like");
                }
                if (this.JournalSubjectCategoryName_q != "") {
                    strWhereCond += ` And ${clsJournalSubjectCategoryEN_js_1.clsJournalSubjectCategoryEN.con_JournalSubjectCategoryName} like '% ${this.JournalSubjectCategoryName_q}%'`;
                    objJournalSubjectCategory_Cond.SetCondFldValue(clsJournalSubjectCategoryEN_js_1.clsJournalSubjectCategoryEN.con_JournalSubjectCategoryName, this.JournalSubjectCategoryName_q, "like");
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0013)在组合导出Excel条件对象(CombineJournalSubjectCategoryConditionObj4ExportExcel)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            objJournalSubjectCategory_Cond.whereCond = strWhereCond;
            return objJournalSubjectCategory_Cond;
        }
        /* 显示JournalSubjectCategory对象的所有属性值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
         <param name = "divContainer">显示容器</param>
         <param name = "arrJournalSubjectCategoryObjLst">需要绑定的对象列表</param>
       */
        BindTab_JournalSubjectCategory(divContainer, arrJournalSubjectCategoryObjLst) {
            var o = document.getElementById(divContainer);
            if (o == null) {
                alert(`${divContainer}不存在！`);
                return;
            }
            var arrDataColumn = [
                {
                    FldName: "",
                    SortBy: "",
                    ColHeader: "",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "CheckBox",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "journalSubjectCategoryId",
                    SortBy: "journalSubjectCategoryId",
                    ColHeader: "期刊学科门类Id",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 2,
                    FuncName: () => { }
                },
                {
                    FldName: "journalSubjectCategoryName",
                    SortBy: "journalSubjectCategoryName",
                    ColHeader: "期刊学科门类名称",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 3,
                    FuncName: () => { }
                },
                {
                    FldName: "updDate",
                    SortBy: "updDate",
                    ColHeader: "修改日期",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 4,
                    FuncName: () => { }
                },
                {
                    FldName: "updUser",
                    SortBy: "updUser",
                    ColHeader: "修改人",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 5,
                    FuncName: () => { }
                },
                {
                    FldName: "memo",
                    SortBy: "memo",
                    ColHeader: "备注",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 6,
                    FuncName: () => { }
                },
            ];
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindTabV4(o, arrJournalSubjectCategoryObjLst, arrDataColumn, "journalSubjectCategoryId", this);
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
            const responseBindGv = await this.BindGv_JournalSubjectCategory_Cache();
        }
        /* 根据条件获取相应的对象列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv_Cache)
       */
        async BindGv_JournalSubjectCategory_Cache() {
            if (this.hidSortJournalSubjectCategoryBy == null) {
                var strMsg = `在显示列表时，排序字段(hidSortJournalSubjectCategoryBy)为空，请检查！(In BindGv_JournalSubjectCategory_Cache)`;
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            var strListDiv = this.mstrListDiv;
            var objJournalSubjectCategory_Cond = this.CombineJournalSubjectCategoryConditionObj();
            var strWhereCond = JSON.stringify(objJournalSubjectCategory_Cond);
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrJournalSubjectCategoryObjLst = [];
            try {
                this.RecCount = await (0, clsJournalSubjectCategoryWApi_js_1.JournalSubjectCategory_GetRecCountByCond_Cache)(objJournalSubjectCategory_Cond);
                if (this.RecCount == 0) {
                    var lblMsg = document.createElement("span");
                    lblMsg.innerHTML = clsString2_js_1.clsString.Format("根据条件:[{0}]获取的对象列表数为0！", objJournalSubjectCategory_Cond.whereCond);
                    var divDataLst = document.getElementById("divDataLst");
                    if (divDataLst != null) {
                        divDataLst.innerText = "";
                        divDataLst.appendChild(lblMsg);
                    }
                    var strMsg = `在绑定Gv_Cache过程中，根据条件:[${objJournalSubjectCategory_Cond.whereCond}]获取的对象列表数为0！`;
                    console.error("Error: ", strMsg);
                    //console.trace();
                    alert(strMsg);
                    return;
                }
                var intPageCount = this.objPager.GetPageCount(this.RecCount, this.pageSize);
                if (intCurrPageIndex == 0) {
                    if (intPageCount > 1)
                        intCurrPageIndex = intPageCount;
                    else
                        intCurrPageIndex = 1;
                    this.setCurrPageIndex(intCurrPageIndex, this.divName4Pager);
                }
                else if (intCurrPageIndex > intPageCount) {
                    intCurrPageIndex = intPageCount;
                    this.setCurrPageIndex(intCurrPageIndex, this.divName4Pager);
                }
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortJournalSubjectCategoryBy,
                    sortFun: clsJournalSubjectCategoryWApi_js_1.JournalSubjectCategory_SortFun_Defa
                };
                var arrJournalSubjectCategoryObjLst = await (0, clsJournalSubjectCategoryWApi_js_1.JournalSubjectCategory_GetObjLstByPager_Cache)(objPagerPara);
            }
            catch (e) {
                var strMsg = `绑定GridView不成功,${e}.`;
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            var divPager = document.getElementById("divPager");
            if (this.RecCount <= this.pageSize) {
                if (divPager != null) {
                    divPager.style.display = "none";
                }
            }
            else {
                if (divPager != null) {
                    divPager.style.display = "block";
                }
            }
            if (arrJournalSubjectCategoryObjLst.length == 0) {
                var lblMsg = document.createElement("span");
                lblMsg.innerHTML = "根据条件获取的对象列表数为0！";
                var divDataLst = document.getElementById("divDataLst");
                if (divDataLst != null) {
                    divDataLst.innerText = "";
                    divDataLst.appendChild(lblMsg);
                }
                var strKey = `${clsJournalSubjectCategoryEN_js_1.clsJournalSubjectCategoryEN._CurrTabName}`;
                var strMsg = `在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=${strKey})`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            try {
                this.BindTab_JournalSubjectCategory(strListDiv, arrJournalSubjectCategoryObjLst);
                console.log("完成BindGv_JournalSubjectCategory_Cache!");
            }
            catch (e) {
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /// <summary>
        /// 排序函数。根据表对象中随机两个字段的值进行比较,正常使用时，需用该类的扩展类的同名函数
        /// 作者:pyf
        /// 日期:
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortFunExportExcel)
        /// </summary>
        /// <param name = "a">比较的第1个对象</param>
        /// <param name = "b">比较的第1个对象</param>
        /// <returns>返回两个对象比较的结果</returns>
        SortFun_ExportExcel(a, b) {
            if (a.updDate == b.updDate)
                return a.updUser.localeCompare(b.updUser);
            else
                return a.updDate.localeCompare(b.updDate);
        }
        /* 函数功能:从界面列表中根据某一个字段排序
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortBy)
         <param name = "objAnchorElement">带有排序字段的Anchors</param>
       */
        async SortBy(objAnchorElement) {
            console.log("objAnchorElement(In SetAllCkechedKeysV2):", objAnchorElement);
            //event = window.event || event;
            var thisEventObj = objAnchorElement;
            var strFldName = thisEventObj.getAttribute("FldName");
            if (clsString2_js_1.clsString.IsNullOrEmpty(strFldName) == true)
                return;
            var strSortByFld = strFldName;
            if (this.hidSortJournalSubjectCategoryBy.indexOf(strSortByFld) >= 0) {
                if (this.hidSortJournalSubjectCategoryBy.indexOf("Asc") >= 0) {
                    this.hidSortJournalSubjectCategoryBy = `${strSortByFld} Desc`;
                }
                else {
                    this.hidSortJournalSubjectCategoryBy = `${strSortByFld} Asc`;
                }
            }
            else {
                this.hidSortJournalSubjectCategoryBy = `${strSortByFld} Asc`;
            }
            const responseBindGv = await this.BindGv_JournalSubjectCategory_Cache();
        }
        /// <summary>
        /// 在用户自定义控件中，设置关键字的值，是否只读
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetKeyReadOnly)
        /// </summary>
        /// <param name = "bolReadonly">是否只读</param>
        SetKeyReadOnly(bolReadonly) {
            $('#txtJournalSubjectCategoryId').prop['ReadOnly'] = bolReadonly;
        }
        /* 复制记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CopyRecord)
       */
        async CopyRecord(arrJournalSubjectCategoryId) {
            try {
                const responseText = await (0, clsJournalSubjectCategoryWApi_js_1.JournalSubjectCategory_GetObjLstByJournalSubjectCategoryIdLstAsync)(arrJournalSubjectCategoryId);
                console.log('responseText=');
                console.log(responseText);
                var intCount = 0;
                var arrJournalSubjectCategoryObjLst = responseText;
                for (let objInFor of arrJournalSubjectCategoryObjLst) {
                    const strMaxStrId = await (0, clsJournalSubjectCategoryWApi_js_1.JournalSubjectCategory_GetMaxStrIdAsync)();
                    console.log('strMaxStrId=' + strMaxStrId);
                    objInFor.journalSubjectCategoryId = strMaxStrId;
                    const responseText2 = await (0, clsJournalSubjectCategoryWApi_js_1.JournalSubjectCategory_AddNewRecordAsync)(objInFor);
                    console.log('responseText2=');
                    console.log(responseText2);
                    var returnBool = !!responseText2;
                    if (returnBool == true) {
                        (0, clsJournalSubjectCategoryWApi_js_1.JournalSubjectCategory_ReFreshCache)();
                        var strInfo = `克隆记录成功!`;
                        intCount++;
                    }
                    else {
                        var strInfo = `克隆记录不成功!`;
                        //显示信息框
                        alert(strInfo);
                    }
                }
                var strInfo = `共克隆了${intCount}条记录!`;
                alert(strInfo);
                console.log('完成！');
            }
            catch (e) {
                var strMsg = `复制记录不成功,${e}.`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
            }
        }
        /* 根据关键字列表删除记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelMultiRecord)
       */
        async DelMultiRecord(arrJournalSubjectCategoryId) {
            try {
                const responseText = await (0, clsJournalSubjectCategoryWApi_js_1.JournalSubjectCategory_DelJournalSubjectCategorysAsync)(arrJournalSubjectCategoryId);
                var returnInt = responseText;
                if (returnInt > 0) {
                    (0, clsJournalSubjectCategoryWApi_js_1.JournalSubjectCategory_ReFreshCache)();
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
                var strMsg = `删除记录不成功. ${e}.`;
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /* 显示{0}对象的所有属性值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowTabObj)
         <param name = "divContainer">显示容器</param>
         <param name = "objJournalSubjectCategory">需要显示的对象</param>
       */
        ShowJournalSubjectCategoryObj(divContainer, objJournalSubjectCategory) {
            var o = document.getElementById(divContainer);
            if (o == null) {
                alert(`${divContainer}不存在！`);
                return;
            }
            var sstrKeys = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetObjKeys(objJournalSubjectCategory);
            var ul = document.createElement("ul");
            for (let strKey of sstrKeys) {
                var strValue = objJournalSubjectCategory[strKey];
                var li = document.createElement("li");
                li.innerHTML = `${strKey}:${strValue}`;
                ul.appendChild(li);
            }
            o.appendChild(ul);
        }
        /* 函数功能:从界面列表中获取第一个关键字的值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
         <param name = "pobjJournalSubjectCategoryEN">表实体类对象</param>
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
        * 设置排序字段-相当使用ViewState功能
       */
        set hidSortJournalSubjectCategoryBy(value) {
            $("#hidSortJournalSubjectCategoryBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortJournalSubjectCategoryBy() {
            return $("#hidSortJournalSubjectCategoryBy").val();
        }
        /*
        * 期刊学科门类Id (Used In CombineCondition())
       */
        get JournalSubjectCategoryId_q() {
            var objDiv = $(`#${this.divName4Query}`);
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckControlExist(this.divName4Query, "input", "txtJournalSubjectCategoryId_q");
            var strId = `input[id ^= "txtJournalSubjectCategoryId_q"]`;
            return objDiv.find(strId).val();
        }
        /*
        * 期刊学科门类Id (Used In CombineCondition())
       */
        set JournalSubjectCategoryId_q(value) {
            var objDiv = $(`#${this.divName4Query}`);
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckControlExist(this.divName4Query, "input", "txtJournalSubjectCategoryId_q");
            var strId = `input[id ^= "txtJournalSubjectCategoryId_q"]`;
            objDiv.find(strId).val(value);
        }
        /*
        * 期刊学科门类名称 (Used In CombineCondition())
       */
        get JournalSubjectCategoryName_q() {
            var objDiv = $(`#${this.divName4Query}`);
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckControlExist(this.divName4Query, "input", "txtJournalSubjectCategoryName_q");
            var strId = `input[id ^= "txtJournalSubjectCategoryName_q"]`;
            return objDiv.find(strId).val();
        }
        /*
        * 期刊学科门类名称 (Used In CombineCondition())
       */
        set JournalSubjectCategoryName_q(value) {
            var objDiv = $(`#${this.divName4Query}`);
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckControlExist(this.divName4Query, "input", "txtJournalSubjectCategoryName_q");
            var strId = `input[id ^= "txtJournalSubjectCategoryName_q"]`;
            objDiv.find(strId).val(value);
        }
    }
    exports.JournalSubjectCategoryCRUD = JournalSubjectCategoryCRUD;
});
