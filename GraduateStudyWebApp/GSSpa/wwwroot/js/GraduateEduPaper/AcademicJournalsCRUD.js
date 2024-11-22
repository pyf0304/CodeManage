(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L0_Entity/GraduateEduPaper/clsAcademicJournalsEN.js", "../TS/L0_Entity/GraduateEduPaper/clsAcademicJournalsENEx.js", "../TS/L0_Entity/GraduateEduPaper/clsJournalSubjectCategoryEN.js", "../TS/L0_Entity/GraduateEduPaper/clsJournalSubjectEN.js", "../TS/L3_ForWApi/GraduateEduPaper/clsAcademicJournalsWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsJournalSubjectCategoryWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsJournalSubjectWApi.js", "../TS/PubFun/clsCommonFunc4Web2.js", "../TS/PubFun/clsOperateList2.js", "../TS/PubFun/clsString2.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.AcademicJournalsCRUD = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:AcademicJournalsCRUD(界面:AcademicJournalsCRUD)
    表名:AcademicJournals(01120929)
    生成代码版本:2021.06.20.1
    生成日期:2021/06/20 17:34:14
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
    const clsAcademicJournalsEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsAcademicJournalsEN.js");
    const clsAcademicJournalsENEx_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsAcademicJournalsENEx.js");
    const clsJournalSubjectCategoryEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsJournalSubjectCategoryEN.js");
    const clsJournalSubjectEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsJournalSubjectEN.js");
    const clsAcademicJournalsWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsAcademicJournalsWApi.js");
    const clsJournalSubjectCategoryWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsJournalSubjectCategoryWApi.js");
    const clsJournalSubjectWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsJournalSubjectWApi.js");
    const clsCommonFunc4Web2_js_1 = require("../TS/PubFun/clsCommonFunc4Web2.js");
    const clsOperateList2_js_1 = require("../TS/PubFun/clsOperateList2.js");
    const clsString2_js_1 = require("../TS/PubFun/clsString2.js");
    /* AcademicJournalsCRUD 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
   */
    class AcademicJournalsCRUD extends clsOperateList2_js_1.clsOperateList {
        constructor() {
            super();
            this.divName4Query = "divQuery"; //查询区的层Id
            this.divName4Function = "divFunction"; //功能区的层Id
            this.RecCount = 0;
            AcademicJournalsCRUD.objPage_CRUD = this;
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
                this.hidSortAcademicJournalsBy = "journalId Asc";
                if (this.bolIsInitShow == false) //
                 {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true; //
                }
                //2、显示无条件的表内容在GridView中
                const responseBindGv = await this.BindGv_AcademicJournals4Func();
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
            const responseBindGv = await this.BindGv_AcademicJournals4Func();
        }
        /* 合并数据
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineData)
       */
        CombineData(arrAcademicJournalsObjLst, arrDataColumn) {
            var intRowNum = arrAcademicJournalsObjLst.length;
            var intColNum = arrDataColumn.length;
            var arrData = new Array();
            var arrHead = new Array();
            for (var j = 0; j < intColNum; j++) {
                arrHead.push(arrDataColumn[j].ColHeader);
            }
            arrData.push(arrHead);
            for (var i = 0; i < intRowNum; i++) {
                var arrRow = new Array();
                var objEN = arrAcademicJournalsObjLst[i];
                for (var j = 0; j < intColNum; j++) {
                    arrRow.push(objEN[arrDataColumn[j].FldName]); //i + "" + j;
                }
                arrData.push(arrRow);
            }
            console.log("arrData", arrData);
            var strFileName = clsString2_js_1.clsString.Format("学术期刊({0})导出.xlsx", clsAcademicJournalsEN_js_1.clsAcademicJournalsEN._CurrTabName);
            exportSpecialExcel_pyf(arrData, strFileName);
        }
        /* 合并数据
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineData4Func)
       */
        CombineData4Func(arrAcademicJournalsExObjLst, arrDataColumn) {
            var intRowNum = arrAcademicJournalsExObjLst.length;
            var intColNum = arrDataColumn.length;
            var arrData = new Array();
            var arrHead = new Array();
            for (var j = 0; j < intColNum; j++) {
                arrHead.push(arrDataColumn[j].ColHeader);
            }
            arrData.push(arrHead);
            for (var i = 0; i < intRowNum; i++) {
                var arrRow = new Array();
                var objEN = arrAcademicJournalsExObjLst[i];
                for (var j = 0; j < intColNum; j++) {
                    arrRow.push(objEN[arrDataColumn[j].FldName]); //i + "" + j;
                }
                arrData.push(arrRow);
            }
            console.log("arrData", arrData);
            var strFileName = clsString2_js_1.clsString.Format("学术期刊({0})导出.xlsx", clsAcademicJournalsEN_js_1.clsAcademicJournalsEN._CurrTabName);
            exportSpecialExcel_pyf(arrData, strFileName);
        }
        /* 根据条件获取相应的对象列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ExportExcel4Func)
       */
        async ExportExcel_AcademicJournals4Func() {
            if (this.hidSortAcademicJournalsBy == null) {
                var strMsg = `在显示列表时，排序字段(hidSortAcademicJournalsBy)为空，请检查！(In BindGv_AcademicJournals_Cache)`;
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            var strListDiv = this.mstrListDiv;
            var objAcademicJournals_Cond = this.CombineAcademicJournalsConditionObj4ExportExcel();
            var strWhereCond = JSON.stringify(objAcademicJournals_Cond);
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrAcademicJournalsObjLst = [];
            var arrAcademicJournalsExObjLst = [];
            try {
                this.RecCount = await (0, clsAcademicJournalsWApi_js_1.AcademicJournals_GetRecCountByCond_Cache)(objAcademicJournals_Cond);
                if (this.RecCount == 0) {
                    var lblMsg = document.createElement("span");
                    lblMsg.innerHTML = clsString2_js_1.clsString.Format("根据条件:[{0}]获取的对象列表数为0！", objAcademicJournals_Cond.whereCond);
                    var divDataLst = document.getElementById("divDataLst");
                    if (divDataLst != null) {
                        divDataLst.innerText = "";
                        divDataLst.appendChild(lblMsg);
                    }
                    var strMsg = `在绑定Gv_Cache过程中，根据条件:[${objAcademicJournals_Cond.whereCond}]获取的对象列表数为0！`;
                    console.error("Error: ", strMsg);
                    //console.trace();
                    alert(strMsg);
                    return;
                }
                var arrAcademicJournalsObjLst = await (0, clsAcademicJournalsWApi_js_1.AcademicJournals_GetSubObjLst_Cache)(objAcademicJournals_Cond);
                arrAcademicJournalsExObjLst = arrAcademicJournalsObjLst.map(this.CopyToEx);
                for (var objInFor of arrAcademicJournalsExObjLst) {
                    const conFuncMap = await this.FuncMap4ExcelExport(objInFor);
                }
            }
            catch (e) {
                var strMsg = `导出Excel时获取数据不成功,${e}.`;
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            if (arrAcademicJournalsObjLst.length == 0) {
                var strKey = `${clsAcademicJournalsEN_js_1.clsAcademicJournalsEN._CurrTabName}`;
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
                        ColHeader: "学科门类",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 2,
                        FuncName: () => { }
                    },
                    {
                        FldName: "journalSubjectId",
                        SortBy: "",
                        ColHeader: "学科代码",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 3,
                        FuncName: () => { }
                    },
                    {
                        FldName: "journalSubjectId",
                        SortBy: "",
                        ColHeader: "学科",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 4,
                        FuncName: () => { }
                    },
                    {
                        FldName: "journalId",
                        SortBy: "",
                        ColHeader: "期刊Id",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 5,
                        FuncName: () => { }
                    },
                    {
                        FldName: "journalName",
                        SortBy: "",
                        ColHeader: "期刊名称",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 6,
                        FuncName: () => { }
                    },
                    {
                        FldName: "updDate",
                        SortBy: "",
                        ColHeader: "修改日期",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 7,
                        FuncName: () => { }
                    },
                    {
                        FldName: "updUser",
                        SortBy: "",
                        ColHeader: "修改人",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 8,
                        FuncName: () => { }
                    },
                    {
                        FldName: "memo",
                        SortBy: "",
                        ColHeader: "备注",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 9,
                        FuncName: () => { }
                    },
                ];
                arrAcademicJournalsObjLst = arrAcademicJournalsObjLst.sort(this.SortFun_ExportExcel);
                this.CombineData(arrAcademicJournalsObjLst, arrDataColumn);
                console.log("完成BindGv_AcademicJournals!");
            }
            catch (e) {
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /// <summary>
        /// 设置绑定下拉框，针对字段:[journalSubjectCategoryId]
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TS4QryRegion)
        /// </summary>
        async SetDdl_JournalSubjectCategoryId() {
            var objJournalSubjectCategory_Cond = new clsJournalSubjectCategoryEN_js_1.clsJournalSubjectCategoryEN(); //查询区域
            const ddlJournalSubjectCategoryId_q = await (0, clsJournalSubjectCategoryWApi_js_1.JournalSubjectCategory_BindDdl_JournalSubjectCategoryIdInDiv_Cache)(this.divName4List, "ddlJournalSubjectCategoryId_q"); //查询区域
        }
        /// <summary>
        /// 设置绑定下拉框，针对字段:[journalSubjectId]
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TS4QryRegion)
        /// </summary>
        async SetDdl_JournalSubjectId() {
            var objJournalSubject_Cond = new clsJournalSubjectEN_js_1.clsJournalSubjectEN(); //查询区域
            const ddlJournalSubjectId_q = await (0, clsJournalSubjectCategoryWApi_js_1.JournalSubjectCategory_BindDdl_JournalSubjectCategoryIdInDiv_Cache)(this.divName4List, "ddlJournalSubjectId_q"); //查询区域
        }
        /* 函数功能:为查询区绑定下拉框
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4QueryRegion)
       */
        async BindDdl4QueryRegion() {
            // 在此处放置用户代码以初始化页面
            const ddlJournalSubjectCategoryId_q = await this.SetDdl_JournalSubjectCategoryId(); //查询区域
            const ddlJournalSubjectId_q = await this.SetDdl_JournalSubjectId(); //查询区域
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
                const responseBindGv = await this.BindGv_AcademicJournals4Func();
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
                const responseBindGv = await this.BindGv_AcademicJournals4Func();
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
        async DelRecord(strJournalId) {
            try {
                const responseText = await (0, clsAcademicJournalsWApi_js_1.AcademicJournals_DelRecordAsync)(strJournalId);
                var returnInt = responseText;
                if (returnInt > 0) {
                    (0, clsAcademicJournalsWApi_js_1.AcademicJournals_ReFreshCache)();
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
        async SelectRecord(strJournalId) {
            try {
                const responseText = await (0, clsAcademicJournalsWApi_js_1.AcademicJournals_GetObjByJournalIdAsync)(strJournalId);
                var objAcademicJournalsEN = responseText;
                console.log("完成SelectRecord!");
                clsCommonFunc4Web2_js_1.clsCommonFunc4Web.Redirect("/Index/Main_AcademicJournals");
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
                const responseBindGv = await this.BindGv_AcademicJournals4Func();
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
            const responseBindGv = await this.ExportExcel_AcademicJournals4Func();
        }
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
         <returns>条件串(strWhereCond)</returns>
       */
        CombineAcademicJournalsCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.JournalId_q != "") {
                    strWhereCond += ` And ${clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalId} like '% ${this.JournalId_q}%'`;
                }
                if (this.JournalName_q != "") {
                    strWhereCond += ` And ${clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalName} like '% ${this.JournalName_q}%'`;
                }
                if (this.JournalSubjectCategoryId_q != "" && this.JournalSubjectCategoryId_q != "0") {
                    strWhereCond += ` And ${clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalSubjectCategoryId} = '${this.JournalSubjectCategoryId_q}'`;
                }
                if (this.JournalSubjectId_q != "" && this.JournalSubjectId_q != "0") {
                    strWhereCond += ` And ${clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalSubjectId} = '${this.JournalSubjectId_q}'`;
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0009)在组合查询条件(CombineAcademicJournalsCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
         <returns>条件串(strWhereCond)</returns>
       */
        CombineAcademicJournalsConditionObj() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var objAcademicJournals_Cond = new clsAcademicJournalsEN_js_1.clsAcademicJournalsEN();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.JournalId_q != "") {
                    strWhereCond += ` And ${clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalId} like '% ${this.JournalId_q}%'`;
                    objAcademicJournals_Cond.SetCondFldValue(clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalId, this.JournalId_q, "like");
                }
                if (this.JournalName_q != "") {
                    strWhereCond += ` And ${clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalName} like '% ${this.JournalName_q}%'`;
                    objAcademicJournals_Cond.SetCondFldValue(clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalName, this.JournalName_q, "like");
                }
                if (this.JournalSubjectCategoryId_q != "" && this.JournalSubjectCategoryId_q != "0") {
                    strWhereCond += ` And ${clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalSubjectCategoryId} = '${this.JournalSubjectCategoryId_q}'`;
                    objAcademicJournals_Cond.SetCondFldValue(clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalSubjectCategoryId, this.JournalSubjectCategoryId_q, "=");
                }
                if (this.JournalSubjectId_q != "" && this.JournalSubjectId_q != "0") {
                    strWhereCond += ` And ${clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalSubjectId} = '${this.JournalSubjectId_q}'`;
                    objAcademicJournals_Cond.SetCondFldValue(clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalSubjectId, this.JournalSubjectId_q, "=");
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0010)在组合查询条件对象(CombineAcademicJournalsConditionObj)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            objAcademicJournals_Cond.whereCond = strWhereCond;
            return objAcademicJournals_Cond;
        }
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj4ExportExcel)
         <returns>条件串(strWhereCond)</returns>
       */
        CombineAcademicJournalsConditionObj4ExportExcel() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var objAcademicJournals_Cond = new clsAcademicJournalsEN_js_1.clsAcademicJournalsEN();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.JournalId_q != "") {
                    strWhereCond += ` And ${clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalId} like '% ${this.JournalId_q}%'`;
                    objAcademicJournals_Cond.SetCondFldValue(clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalId, this.JournalId_q, "like");
                }
                if (this.JournalName_q != "") {
                    strWhereCond += ` And ${clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalName} like '% ${this.JournalName_q}%'`;
                    objAcademicJournals_Cond.SetCondFldValue(clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalName, this.JournalName_q, "like");
                }
                if (this.JournalSubjectCategoryId_q != "" && this.JournalSubjectCategoryId_q != "0") {
                    strWhereCond += ` And ${clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalSubjectCategoryId} = '${this.JournalSubjectCategoryId_q}'`;
                    objAcademicJournals_Cond.SetCondFldValue(clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalSubjectCategoryId, this.JournalSubjectCategoryId_q, "=");
                }
                if (this.JournalSubjectId_q != "" && this.JournalSubjectId_q != "0") {
                    strWhereCond += ` And ${clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalSubjectId} = '${this.JournalSubjectId_q}'`;
                    objAcademicJournals_Cond.SetCondFldValue(clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalSubjectId, this.JournalSubjectId_q, "=");
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0013)在组合导出Excel条件对象(CombineAcademicJournalsConditionObj4ExportExcel)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            objAcademicJournals_Cond.whereCond = strWhereCond;
            return objAcademicJournals_Cond;
        }
        /* 显示AcademicJournals对象的所有属性值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
         <param name = "divContainer">显示容器</param>
         <param name = "arrAcademicJournalsObjLst">需要绑定的对象列表</param>
       */
        BindTab_AcademicJournals(divContainer, arrAcademicJournalsObjLst) {
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
                    SortBy: "journalSubjectCategoryName",
                    ColHeader: "学科门类",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 2,
                    FuncName: () => { }
                },
                {
                    FldName: "journalSubjectId",
                    SortBy: "journalSubjectCode",
                    ColHeader: "学科代码",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 3,
                    FuncName: () => { }
                },
                {
                    FldName: "journalSubjectId",
                    SortBy: "journalSubjectName",
                    ColHeader: "学科",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 4,
                    FuncName: () => { }
                },
                {
                    FldName: "journalId",
                    SortBy: "journalId",
                    ColHeader: "期刊Id",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 5,
                    FuncName: () => { }
                },
                {
                    FldName: "journalName",
                    SortBy: "journalName",
                    ColHeader: "期刊名称",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 6,
                    FuncName: () => { }
                },
                {
                    FldName: "updDate",
                    SortBy: "updDate",
                    ColHeader: "修改日期",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 7,
                    FuncName: () => { }
                },
                {
                    FldName: "updUser",
                    SortBy: "updUser",
                    ColHeader: "修改人",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 8,
                    FuncName: () => { }
                },
                {
                    FldName: "memo",
                    SortBy: "memo",
                    ColHeader: "备注",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 9,
                    FuncName: () => { }
                },
            ];
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindTabV4(o, arrAcademicJournalsObjLst, arrDataColumn, "journalId", this);
            this.objPager.RecCount = this.RecCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        /* 显示AcademicJournals对象的所有属性值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab4Func)
         <param name = "divContainer">显示容器</param>
         <param name = "arrAcademicJournalsExObjLst">需要绑定的对象列表</param>
       */
        BindTab_AcademicJournals4Func(divContainer, arrAcademicJournalsExObjLst) {
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
                    FldName: "journalSubjectCategoryName",
                    SortBy: "journalSubjectCategoryName",
                    ColHeader: "学科门类",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 2,
                    FuncName: () => { }
                },
                {
                    FldName: "journalSubjectCode",
                    SortBy: "journalSubjectCode",
                    ColHeader: "学科代码",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 3,
                    FuncName: () => { }
                },
                {
                    FldName: "journalSubjectName",
                    SortBy: "journalSubjectName",
                    ColHeader: "学科",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 4,
                    FuncName: () => { }
                },
                {
                    FldName: "journalId",
                    SortBy: "journalId",
                    ColHeader: "期刊Id",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 5,
                    FuncName: () => { }
                },
                {
                    FldName: "journalName",
                    SortBy: "journalName",
                    ColHeader: "期刊名称",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 6,
                    FuncName: () => { }
                },
                {
                    FldName: "updDate",
                    SortBy: "updDate",
                    ColHeader: "修改日期",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 7,
                    FuncName: () => { }
                },
                {
                    FldName: "updUser",
                    SortBy: "updUser",
                    ColHeader: "修改人",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 8,
                    FuncName: () => { }
                },
                {
                    FldName: "memo",
                    SortBy: "memo",
                    ColHeader: "备注",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 9,
                    FuncName: () => { }
                },
            ];
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindTabV4(o, arrAcademicJournalsExObjLst, arrDataColumn, "journalId", this);
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
            const responseBindGv = await this.BindGv_AcademicJournals4Func();
        }
        /* 根据条件获取相应的对象列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv4Func)
       */
        async BindGv_AcademicJournals4Func() {
            if (this.hidSortAcademicJournalsBy == null) {
                var strMsg = `在显示列表时，排序字段(hidSortAcademicJournalsBy)为空，请检查！(In BindGv_AcademicJournals_Cache)`;
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            var strListDiv = this.mstrListDiv;
            var objAcademicJournals_Cond = this.CombineAcademicJournalsConditionObj();
            var strWhereCond = JSON.stringify(objAcademicJournals_Cond);
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrAcademicJournalsObjLst = [];
            var arrAcademicJournalsExObjLst = [];
            try {
                this.RecCount = await (0, clsAcademicJournalsWApi_js_1.AcademicJournals_GetRecCountByCond_Cache)(objAcademicJournals_Cond);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortAcademicJournalsBy,
                    sortFun: (x, y) => { return 0; }
                };
                arrAcademicJournalsObjLst = await (0, clsAcademicJournalsWApi_js_1.AcademicJournals_GetObjLstByPager_Cache)(objPagerPara);
                arrAcademicJournalsExObjLst = arrAcademicJournalsObjLst.map(this.CopyToEx);
                for (var objInFor of arrAcademicJournalsExObjLst) {
                    const conFuncMap = await this.FuncMap(objInFor);
                }
            }
            catch (e) {
                var strMsg = `绑定GridView不成功,${e}.`;
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            if (arrAcademicJournalsObjLst.length == 0) {
                var strKey = `${clsAcademicJournalsEN_js_1.clsAcademicJournalsEN._CurrTabName}`;
                var strMsg = `在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=${strKey})`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            try {
                this.BindTab_AcademicJournals4Func(strListDiv, arrAcademicJournalsExObjLst);
                console.log("完成BindGv_AcademicJournals4Func!");
            }
            catch (e) {
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CopyToEx)
        /// </summary>
        /// <param name = "objAcademicJournalsENS">源对象</param>
        /// <returns>目标对象=>clsAcademicJournalsEN:objAcademicJournalsENT</returns>
        CopyToEx(objAcademicJournalsENS) {
            var objAcademicJournalsENT = new clsAcademicJournalsENEx_js_1.clsAcademicJournalsENEx();
            try {
                (0, clsAcademicJournalsWApi_js_1.AcademicJournals_CopyObjTo)(objAcademicJournalsENS, objAcademicJournalsENT);
                return objAcademicJournalsENT;
            }
            catch (e) {
                var strMsg = clsString2_js_1.clsString.Format("(errid:WiTsCs0011)Copy表对象数据出错,${e}.");
                console.error(strMsg);
                alert(strMsg);
                return objAcademicJournalsENT;
            }
        }
        /// <summary>
        /// 把一个扩展类的部分属性进行函数转换
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_FuncMap)
        /// </summary>
        /// <param name = "objAcademicJournalsS">源对象</param>
        async FuncMap(objAcademicJournals) {
            try {
                {
                    var JournalSubjectCategory_JournalSubjectCategoryId = objAcademicJournals.journalSubjectCategoryId;
                    var JournalSubjectCategory_JournalSubjectCategoryName = await (0, clsJournalSubjectCategoryWApi_js_1.JournalSubjectCategory_func)(clsJournalSubjectCategoryEN_js_1.clsJournalSubjectCategoryEN.con_JournalSubjectCategoryId, clsJournalSubjectCategoryEN_js_1.clsJournalSubjectCategoryEN.con_JournalSubjectCategoryName, JournalSubjectCategory_JournalSubjectCategoryId);
                    objAcademicJournals.journalSubjectCategoryName = JournalSubjectCategory_JournalSubjectCategoryName;
                }
                ;
                {
                    var JournalSubject_JournalSubjectId = objAcademicJournals.journalSubjectId;
                    var JournalSubject_JournalSubjectName = await (0, clsJournalSubjectWApi_js_1.JournalSubject_func)(clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_JournalSubjectId, clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_JournalSubjectName, JournalSubject_JournalSubjectId);
                    objAcademicJournals.journalSubjectName = JournalSubject_JournalSubjectName;
                }
                ;
                {
                    var JournalSubject_JournalSubjectId = objAcademicJournals.journalSubjectId;
                    var JournalSubject_JournalSubjectCode = await (0, clsJournalSubjectWApi_js_1.JournalSubject_func)(clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_JournalSubjectId, clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_JournalSubjectCode, JournalSubject_JournalSubjectId);
                    objAcademicJournals.journalSubjectCode = JournalSubject_JournalSubjectCode;
                }
                ;
            }
            catch (e) {
                var strMsg = `(errid:WiTsCs0012)函数映射表对象数据出错,${e}.`;
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
        /// <summary>
        /// 把一个扩展类的部分属性进行函数转换
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_FuncMap4ExcelExport)
        /// </summary>
        /// <param name = "objAcademicJournalsS">源对象</param>
        async FuncMap4ExcelExport(objAcademicJournals) {
            try {
                {
                    var JournalSubjectCategory_JournalSubjectCategoryId = objAcademicJournals.journalSubjectCategoryId;
                    var JournalSubjectCategory_JournalSubjectCategoryName = await (0, clsJournalSubjectCategoryWApi_js_1.JournalSubjectCategory_func)(clsJournalSubjectCategoryEN_js_1.clsJournalSubjectCategoryEN.con_JournalSubjectCategoryId, clsJournalSubjectCategoryEN_js_1.clsJournalSubjectCategoryEN.con_JournalSubjectCategoryName, JournalSubjectCategory_JournalSubjectCategoryId);
                    objAcademicJournals.journalSubjectCategoryName = JournalSubjectCategory_JournalSubjectCategoryName;
                }
                ;
                {
                    var JournalSubject_JournalSubjectId = objAcademicJournals.journalSubjectId;
                    var JournalSubject_JournalSubjectCode = await (0, clsJournalSubjectWApi_js_1.JournalSubject_func)(clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_JournalSubjectId, clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_JournalSubjectCode, JournalSubject_JournalSubjectId);
                    objAcademicJournals.journalSubjectCode = JournalSubject_JournalSubjectCode;
                }
                ;
                {
                    var JournalSubject_JournalSubjectId = objAcademicJournals.journalSubjectId;
                    var JournalSubject_JournalSubjectName = await (0, clsJournalSubjectWApi_js_1.JournalSubject_func)(clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_JournalSubjectId, clsJournalSubjectEN_js_1.clsJournalSubjectEN.con_JournalSubjectName, JournalSubject_JournalSubjectId);
                    objAcademicJournals.journalSubjectName = JournalSubject_JournalSubjectName;
                }
                ;
            }
            catch (e) {
                var strMsg = `(errid:WiTsCs0014)函数映射4ExcelExport表对象数据出错,${e}.`;
                console.error(strMsg);
                alert(strMsg);
            }
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
            if (this.hidSortAcademicJournalsBy.indexOf(strSortByFld) >= 0) {
                if (this.hidSortAcademicJournalsBy.indexOf("Asc") >= 0) {
                    this.hidSortAcademicJournalsBy = `${strSortByFld} Desc`;
                }
                else {
                    this.hidSortAcademicJournalsBy = `${strSortByFld} Asc`;
                }
            }
            else {
                this.hidSortAcademicJournalsBy = `${strSortByFld} Asc`;
            }
            const responseBindGv = await this.BindGv_AcademicJournals4Func();
        }
        /// <summary>
        /// 在用户自定义控件中，设置关键字的值，是否只读
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetKeyReadOnly)
        /// </summary>
        /// <param name = "bolReadonly">是否只读</param>
        SetKeyReadOnly(bolReadonly) {
            $('#txtJournalId').prop['ReadOnly'] = bolReadonly;
        }
        /* 复制记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CopyRecord)
       */
        async CopyRecord(arrJournalId) {
            try {
                const responseText = await (0, clsAcademicJournalsWApi_js_1.AcademicJournals_GetObjLstByJournalIdLstAsync)(arrJournalId);
                console.log('responseText=');
                console.log(responseText);
                var intCount = 0;
                var arrAcademicJournalsObjLst = responseText;
                for (let objInFor of arrAcademicJournalsObjLst) {
                    const strMaxStrId = await (0, clsAcademicJournalsWApi_js_1.AcademicJournals_GetMaxStrIdAsync)();
                    console.log('strMaxStrId=' + strMaxStrId);
                    objInFor.journalId = strMaxStrId;
                    const responseText2 = await (0, clsAcademicJournalsWApi_js_1.AcademicJournals_AddNewRecordAsync)(objInFor);
                    console.log('responseText2=');
                    console.log(responseText2);
                    var returnBool = !!responseText2;
                    if (returnBool == true) {
                        (0, clsAcademicJournalsWApi_js_1.AcademicJournals_ReFreshCache)();
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
        async DelMultiRecord(arrJournalId) {
            try {
                const responseText = await (0, clsAcademicJournalsWApi_js_1.AcademicJournals_DelAcademicJournalssAsync)(arrJournalId);
                var returnInt = responseText;
                if (returnInt > 0) {
                    (0, clsAcademicJournalsWApi_js_1.AcademicJournals_ReFreshCache)();
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
         <param name = "objAcademicJournals">需要显示的对象</param>
       */
        ShowAcademicJournalsObj(divContainer, objAcademicJournals) {
            var o = document.getElementById(divContainer);
            if (o == null) {
                alert(`${divContainer}不存在！`);
                return;
            }
            var sstrKeys = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetObjKeys(objAcademicJournals);
            var ul = document.createElement("ul");
            for (let strKey of sstrKeys) {
                var strValue = objAcademicJournals[strKey];
                var li = document.createElement("li");
                li.innerHTML = `${strKey}:${strValue}`;
                ul.appendChild(li);
            }
            o.appendChild(ul);
        }
        /* 函数功能:从界面列表中获取第一个关键字的值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
         <param name = "pobjAcademicJournalsEN">表实体类对象</param>
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
        set hidSortAcademicJournalsBy(value) {
            $("#hidSortAcademicJournalsBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortAcademicJournalsBy() {
            return $("#hidSortAcademicJournalsBy").val();
        }
        /*
        * 期刊Id (Used In CombineCondition())
       */
        get JournalId_q() {
            var objDiv = $(`#${this.divName4Query}`);
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckControlExist(this.divName4Query, "input", "txtJournalId_q");
            var strId = `input[id ^= "txtJournalId_q"]`;
            return objDiv.find(strId).val();
        }
        /*
        * 期刊Id (Used In CombineCondition())
       */
        set JournalId_q(value) {
            var objDiv = $(`#${this.divName4Query}`);
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckControlExist(this.divName4Query, "input", "txtJournalId_q");
            var strId = `input[id ^= "txtJournalId_q"]`;
            objDiv.find(strId).val(value);
        }
        /*
        * 期刊名称 (Used In CombineCondition())
       */
        get JournalName_q() {
            var objDiv = $(`#${this.divName4Query}`);
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckControlExist(this.divName4Query, "input", "txtJournalName_q");
            var strId = `input[id ^= "txtJournalName_q"]`;
            return objDiv.find(strId).val();
        }
        /*
        * 期刊名称 (Used In CombineCondition())
       */
        set JournalName_q(value) {
            var objDiv = $(`#${this.divName4Query}`);
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckControlExist(this.divName4Query, "input", "txtJournalName_q");
            var strId = `input[id ^= "txtJournalName_q"]`;
            objDiv.find(strId).val(value);
        }
        /*
        * 期刊学科门类Id (Used In CombineCondition())
       */
        get JournalSubjectCategoryId_q() {
            var objDiv = $(`#${this.divName4Query}`);
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckControlExist(this.divName4Query, "select", "ddlJournalSubjectCategoryId_q");
            var strId = `select[id ^= "ddlJournalSubjectCategoryId_q"]`;
            if (objDiv.find(strId).val() == "0")
                return "";
            return $("#ddlJournalSubjectCategoryId_q").val();
        }
        /*
        * 期刊学科门类Id (Used In CombineCondition())
       */
        set JournalSubjectCategoryId_q(value) {
            var objDiv = $(`#${this.divName4Query}`);
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckControlExist(this.divName4Query, "select", "ddlJournalSubjectCategoryId_q");
            var strId = `select[id ^= "ddlJournalSubjectCategoryId_q"]`;
            objDiv.find(strId).val(value);
        }
        /*
        * 期刊学科Id (Used In CombineCondition())
       */
        get JournalSubjectId_q() {
            var objDiv = $(`#${this.divName4Query}`);
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckControlExist(this.divName4Query, "select", "ddlJournalSubjectId_q");
            var strId = `select[id ^= "ddlJournalSubjectId_q"]`;
            if (objDiv.find(strId).val() == "0")
                return "";
            return $("#ddlJournalSubjectId_q").val();
        }
        /*
        * 期刊学科Id (Used In CombineCondition())
       */
        set JournalSubjectId_q(value) {
            var objDiv = $(`#${this.divName4Query}`);
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckControlExist(this.divName4Query, "select", "ddlJournalSubjectId_q");
            var strId = `select[id ^= "ddlJournalSubjectId_q"]`;
            objDiv.find(strId).val(value);
        }
    }
    exports.AcademicJournalsCRUD = AcademicJournalsCRUD;
});
