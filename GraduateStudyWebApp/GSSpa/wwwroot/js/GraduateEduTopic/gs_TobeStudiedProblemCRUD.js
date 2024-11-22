(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L0_Entity/GraduateEduTopic/clsgs_TobeStudiedProblemEN.js", "../TS/L0_Entity/GraduateEduTopic/clsvgs_TobeStudiedProblemEN.js", "../TS/L3_ForWApi/GraduateEduTopic/clsgs_TobeStudiedProblemWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvgs_TobeStudiedProblemWApi.js", "../TS/PubFun/clsCommonFunc4Web2.js", "../TS/PubFun/clsOperateList2.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_TobeStudiedProblemCRUD = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:gs_TobeStudiedProblemCRUD
    表名:gs_TobeStudiedProblem(01120776)
    生成代码版本:2020.12.12.1
    生成日期:2020/12/15 21:53:21
    生成者:
    工程名称:问卷调查
    工程ID:0112
    相关数据库:103.116.76.183,9433EduHigh_Jsie
    PrjDataBaseId:0170
    模块中文名:研培主题
    模块英文名:GraduateEduTopic
    框架-层名:WA_界面后台_TS(WA_ViewScriptCS_TS)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //import * as $ from "jquery";
    //import * as QQ from "q";
    const clsgs_TobeStudiedProblemEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsgs_TobeStudiedProblemEN.js");
    const clsvgs_TobeStudiedProblemEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvgs_TobeStudiedProblemEN.js");
    const clsgs_TobeStudiedProblemWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsgs_TobeStudiedProblemWApi.js");
    const clsvgs_TobeStudiedProblemWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvgs_TobeStudiedProblemWApi.js");
    const clsCommonFunc4Web2_js_1 = require("../TS/PubFun/clsCommonFunc4Web2.js");
    const clsOperateList2_js_1 = require("../TS/PubFun/clsOperateList2.js");
    /* gs_TobeStudiedProblemCRUD 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
    */
    class gs_TobeStudiedProblemCRUD extends clsOperateList2_js_1.clsOperateList {
        constructor() {
            super(...arguments);
            this.mstrListDiv = "divDataLst"; //列表区数据列表层id
            this.bolIsLoadEditRegion = false; //记录是否导入编辑区的变量
            this.bolIsLoadDetailRegion = false; //记录是否导入详细信息区的变量
            this.divName4Edit = "divTobeStudiedProblemEdit"; //编辑区的Id
            this.divName4Detail = "divDetail"; //详细信息区的Id
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
                // 为查询区绑定下拉框
                const gvBindDdl = await this.BindDdl4QueryRegion();
                this.hidSortvgs_TobeStudiedProblemBy = "problemTitle Asc";
                //2、显示无条件的表内容在GridView中
                const responseBindGv = await this.BindGv_vgs_TobeStudiedProblem();
            }
            catch (e) {
                var strMsg = `页面启动不成功,${e}.`;
                console.error("Error: ", strMsg);
                //console.trace();
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
                this.hidSortvgs_TobeStudiedProblemBy = "problemTitle Asc";
                //2、显示无条件的表内容在GridView中
                const responseBindGv = await this.BindGv_vgs_TobeStudiedProblem();
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
            this.CurrPageIndex = 1;
            const responseBindGv = await this.BindGv_vgs_TobeStudiedProblem();
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
                const responseBindGv = await this.BindGv_vgs_TobeStudiedProblem();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `复制记录不成功,${e}.`;
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
                const responseText = await this.DelRecord(strKeyId);
                const responseBindGv = await this.BindGv_vgs_TobeStudiedProblem();
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
                this.SelectRecord(strKeyId);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `选择记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /*
        根据关键字删除记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
       */
        async DelRecord(strProblemId) {
            try {
                const responseText = await (0, clsgs_TobeStudiedProblemWApi_js_1.gs_TobeStudiedProblem_DelRecordAsync)(strProblemId);
                var returnInt = responseText;
                if (returnInt > 0) {
                    //gs_TobeStudiedProblem_ReFreshCache();
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
        根据关键字选择相应的记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SelectRecord)
         <param name = "sender">参数列表</param>
       */
        async SelectRecord(strProblemId) {
            try {
                const responseText = await (0, clsgs_TobeStudiedProblemWApi_js_1.gs_TobeStudiedProblem_GetObjByProblemIdAsync)(strProblemId);
                var objgs_TobeStudiedProblemEN = responseText;
                console.log("完成SelectRecord!");
                clsCommonFunc4Web2_js_1.clsCommonFunc4Web.Redirect("/Index/Main_vgs_TobeStudiedProblem");
            }
            catch (e) {
                console.error(e);
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
                const responseText = await this.DelMultiRecord(arrKeyIds);
                const responseBindGv = await this.BindGv_vgs_TobeStudiedProblem();
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
                const responseText = await (0, clsvgs_TobeStudiedProblemWApi_js_1.vgs_TobeStudiedProblem_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    var arrvgs_TobeStudiedProblemObjLst = jsonData;
                    this.BindTab_vgs_TobeStudiedProblem(this.mstrListDiv, arrvgs_TobeStudiedProblemObjLst);
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `导出Excel不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
         <returns>条件串(strWhereCond)</returns>
       */
        Combinevgs_TobeStudiedProblemCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.ProblemTitle_q != "") {
                    strWhereCond += ` And ${clsvgs_TobeStudiedProblemEN_js_1.clsvgs_TobeStudiedProblemEN.con_ProblemTitle} like '% ${this.ProblemTitle_q}%'`;
                }
                if (this.ProblemDate_q != "") {
                    strWhereCond += ` And ${clsvgs_TobeStudiedProblemEN_js_1.clsvgs_TobeStudiedProblemEN.con_ProblemDate} like '% ${this.ProblemDate_q}%'`;
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0009)在组合查询条件(Combinegs_TobeStudiedProblemCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
         <returns>条件串(strWhereCond)</returns>
       */
        Combinevgs_TobeStudiedProblemConditionObj() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var objvgs_TobeStudiedProblem_Cond = new clsvgs_TobeStudiedProblemEN_js_1.clsvgs_TobeStudiedProblemEN();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.ProblemTitle_q != "") {
                    strWhereCond += ` And ${clsvgs_TobeStudiedProblemEN_js_1.clsvgs_TobeStudiedProblemEN.con_ProblemTitle} like '% ${this.ProblemTitle_q}%'`;
                    objvgs_TobeStudiedProblem_Cond.SetCondFldValue(clsvgs_TobeStudiedProblemEN_js_1.clsvgs_TobeStudiedProblemEN.con_ProblemTitle, this.ProblemTitle_q, "like");
                }
                if (this.ProblemDate_q != "") {
                    strWhereCond += ` And ${clsvgs_TobeStudiedProblemEN_js_1.clsvgs_TobeStudiedProblemEN.con_ProblemDate} like '% ${this.ProblemDate_q}%'`;
                    objvgs_TobeStudiedProblem_Cond.SetCondFldValue(clsvgs_TobeStudiedProblemEN_js_1.clsvgs_TobeStudiedProblemEN.con_ProblemDate, this.ProblemDate_q, "like");
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0010)在组合查询条件对象(Combinegs_TobeStudiedProblemConditionObj)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return objvgs_TobeStudiedProblem_Cond;
        }
        /* 显示vgs_TobeStudiedProblem对象的所有属性值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
         <param name = "divContainer">显示容器</param>
         <param name = "arrgs_TobeStudiedProblemObjLst">需要绑定的对象列表</param>
       */
        BindTab_vgs_TobeStudiedProblem(divContainer, arrvgs_TobeStudiedProblemObjLst) {
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
                    FldName: "problemTitle",
                    SortBy: "problemTitle",
                    ColHeader: "问题标题",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 2,
                    FuncName: () => { }
                },
                {
                    FldName: "problemContent",
                    SortBy: "problemContent",
                    ColHeader: "问题内容",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 3,
                    FuncName: () => { }
                },
                {
                    FldName: "problemDate",
                    SortBy: "problemDate",
                    ColHeader: "问题日期",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 4,
                    FuncName: () => { }
                },
                {
                    FldName: "updDate",
                    SortBy: "updDate",
                    ColHeader: "修改日期",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 5,
                    FuncName: () => { }
                },
                {
                    FldName: "updUser",
                    SortBy: "updUser",
                    ColHeader: "修改人",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 6,
                    FuncName: () => { }
                },
                {
                    FldName: "versionCount",
                    SortBy: "versionCount",
                    ColHeader: "版本统计",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 7,
                    FuncName: () => { }
                },
                {
                    FldName: "participant",
                    SortBy: "participant",
                    ColHeader: "参与者",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 8,
                    FuncName: () => { }
                },
            ];
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindTabV2(o, arrvgs_TobeStudiedProblemObjLst, arrDataColumn, "problemId");
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
            const responseBindGv = await this.BindGv_vgs_TobeStudiedProblem();
        }
        /* 根据条件获取相应的对象列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
       */
        async BindGv_vgs_TobeStudiedProblem() {
            if (this.hidSortvgs_TobeStudiedProblemBy == null) {
                var strMsg = `在显示列表时，排序字段(hidSortvgs_TobeStudiedProblemBy)为空，请检查！(In BindGv_vgs_TobeStudiedProblem)`;
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            var strListDiv = this.mstrListDiv;
            var strWhereCond = this.Combinevgs_TobeStudiedProblemCondition();
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrvgs_TobeStudiedProblemObjLst = [];
            try {
                const responseRecCount = await (0, clsvgs_TobeStudiedProblemWApi_js_1.vgs_TobeStudiedProblem_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvgs_TobeStudiedProblemBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvgs_TobeStudiedProblemWApi_js_1.vgs_TobeStudiedProblem_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvgs_TobeStudiedProblemObjLst = jsonData;
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
            }
            if (arrvgs_TobeStudiedProblemObjLst.length == 0) {
                var strMsg = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            try {
                this.BindTab_vgs_TobeStudiedProblem(strListDiv, arrvgs_TobeStudiedProblemObjLst);
                console.log("完成BindGv_vgs_TobeStudiedProblem!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                //console.trace();
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /* 根据条件获取相应的对象列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv_Cache)
       */
        async BindGv_vgs_TobeStudiedProblem_Cache() {
            if (this.hidSortvgs_TobeStudiedProblemBy == null) {
                var strMsg = `在显示列表时，排序字段(hidSortvgs_TobeStudiedProblemBy)为空，请检查！(In BindGv_vgs_TobeStudiedProblem_Cache)`;
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            var strListDiv = this.mstrListDiv;
            var objvgs_TobeStudiedProblem_Cond = this.Combinevgs_TobeStudiedProblemConditionObj();
            var strWhereCond = JSON.stringify(objvgs_TobeStudiedProblem_Cond);
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrvgs_TobeStudiedProblemObjLst = [];
            try {
                this.RecCount = await (0, clsvgs_TobeStudiedProblemWApi_js_1.vgs_TobeStudiedProblem_GetRecCountByCond_Cache)(objvgs_TobeStudiedProblem_Cond);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvgs_TobeStudiedProblemBy,
                    sortFun: (x, y) => { return 0; }
                };
                var arrvgs_TobeStudiedProblemObjLst = await (0, clsvgs_TobeStudiedProblemWApi_js_1.vgs_TobeStudiedProblem_GetObjLstByPager_Cache)(objPagerPara);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                alert(strMsg);
                return;
            }
            if (arrvgs_TobeStudiedProblemObjLst.length == 0) {
                var strKey = `${clsgs_TobeStudiedProblemEN_js_1.clsgs_TobeStudiedProblemEN._CurrTabName}`;
                var strMsg = `在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=${strKey})`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            try {
                this.BindTab_vgs_TobeStudiedProblem(strListDiv, arrvgs_TobeStudiedProblemObjLst);
                console.log("完成BindGv_vgs_TobeStudiedProblem!");
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
            if (this.hidSortvgs_TobeStudiedProblemBy.indexOf(strSortByFld) >= 0) {
                if (this.hidSortvgs_TobeStudiedProblemBy.indexOf("Asc") >= 0) {
                    this.hidSortvgs_TobeStudiedProblemBy = `${strSortByFld} Desc`;
                }
                else {
                    this.hidSortvgs_TobeStudiedProblemBy = `${strSortByFld} Asc`;
                }
            }
            else {
                this.hidSortvgs_TobeStudiedProblemBy = `${strSortByFld} Asc`;
            }
            const responseBindGv = await this.BindGv_vgs_TobeStudiedProblem();
        }
        /// <summary>
        /// 在用户自定义控件中，设置关键字的值，是否只读
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetKeyReadOnly)
        /// </summary>
        /// <param name = "bolReadonly">是否只读</param>
        SetKeyReadOnly(bolReadonly) {
            $('#txtProblemId').prop['ReadOnly'] = bolReadonly;
        }
        /* 复制记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CopyRecord)
       */
        async CopyRecord(arrProblemId) {
            try {
                const responseText = await (0, clsgs_TobeStudiedProblemWApi_js_1.gs_TobeStudiedProblem_GetObjLstByProblemIdLstAsync)(arrProblemId);
                console.log('responseText=');
                console.log(responseText);
                var intCount = 0;
                var arrgs_TobeStudiedProblemObjLst = responseText;
                for (let objInFor of arrgs_TobeStudiedProblemObjLst) {
                    const responseText2 = await (0, clsgs_TobeStudiedProblemWApi_js_1.gs_TobeStudiedProblem_AddNewRecordAsync)(objInFor);
                    console.log('responseText2=');
                    console.log(responseText2);
                    var returnBool = !!responseText2;
                    if (returnBool == true) {
                        //gs_TobeStudiedProblem_ReFreshCache();
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
        async DelMultiRecord(arrProblemId) {
            try {
                const responseText = await (0, clsgs_TobeStudiedProblemWApi_js_1.gs_TobeStudiedProblem_Delgs_TobeStudiedProblemsAsync)(arrProblemId);
                var returnInt = responseText;
                if (returnInt > 0) {
                    //gs_TobeStudiedProblem_ReFreshCache();
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
         <param name = "objgs_TobeStudiedProblem">需要显示的对象</param>
       */
        Showgs_TobeStudiedProblemObj(divContainer, objgs_TobeStudiedProblem) {
            var o = document.getElementById(divContainer);
            if (o == null) {
                alert(`${divContainer}不存在！`);
                return;
            }
            var sstrKeys = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetObjKeys(objgs_TobeStudiedProblem);
            var ul = document.createElement("ul");
            for (let strKey of sstrKeys) {
                var strValue = objgs_TobeStudiedProblem[strKey];
                var li = document.createElement("li");
                li.innerHTML = `${strKey}:${strValue}`;
                ul.appendChild(li);
            }
            o.appendChild(ul);
        }
        /* 函数功能:从界面列表中获取第一个关键字的值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
         <param name = "pobjgs_TobeStudiedProblemEN">表实体类对象</param>
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
        * 设置当前页序号
       */
        set CurrPageIndex(value) {
            $("#hidCurrPageIndex").val(value);
        }
        /*
        * 获取当前页序号(Used In BindGv_)
       */
        get CurrPageIndex() {
            return $("#hidCurrPageIndex").val();
        }
        /*
        * 设置排序字段-相当使用ViewState功能
       */
        set hidSortvgs_TobeStudiedProblemBy(value) {
            $("#hidSortvgs_TobeStudiedProblemBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvgs_TobeStudiedProblemBy() {
            return $("#hidSortvgs_TobeStudiedProblemBy").val();
        }
        /*
        * 问题日期 (Used In CombineCondition())
       */
        get ProblemDate_q() {
            return $("#txtProblemDate_q").val();
        }
        /*
        * 问题标题 (Used In CombineCondition())
       */
        get ProblemTitle_q() {
            return $("#txtProblemTitle_q").val();
        }
    }
    exports.gs_TobeStudiedProblemCRUD = gs_TobeStudiedProblemCRUD;
});