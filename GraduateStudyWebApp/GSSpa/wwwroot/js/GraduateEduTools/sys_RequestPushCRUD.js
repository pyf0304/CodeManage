(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L0_Entity/DailyRunning/clsCurrEduClsEN.js", "../TS/L0_Entity/GraduateEduTools/clssys_RequestPushEN.js", "../TS/L0_Entity/GraduateEduTools/clssys_RequestPushENEx.js", "../TS/L0_Entity/UserManage/clsvUsersSimEN.js", "../TS/L3_ForWApi/DailyRunning/clsCurrEduClsWApi.js", "../TS/L3_ForWApi/GraduateEduTools/clssys_RequestPushWApi.js", "../TS/L3_ForWApi/UserManage/clsvUsersSimWApi.js", "../TS/PubFun/clsCommonFunc4Web2.js", "../TS/PubFun/clsOperateList2.js", "../TS/PubFun/clsStackTrace.js", "../TS/PubFun/clsString2.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.sys_RequestPushCRUD = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:sys_RequestPushCRUD
    表名:sys_RequestPush(01120726)
    生成代码版本:2020.09.01.1
    生成日期:2020/09/01 17:03:53
    生成者:
    工程名称:问卷调查
    工程ID:0112
    相关数据库:101.251.68.133,9433EduHigh_Jsie
    PrjDataBaseId:0170
    模块中文名:研培设置
    模块英文名:GraduateEduTools
    框架-层名:WA_界面后台_TS(WA_ViewScriptCS_TS)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //import * as $ from "jquery";
    //import * as QQ from "q";
    const clsCurrEduClsEN_js_1 = require("../TS/L0_Entity/DailyRunning/clsCurrEduClsEN.js");
    const clssys_RequestPushEN_js_1 = require("../TS/L0_Entity/GraduateEduTools/clssys_RequestPushEN.js");
    const clssys_RequestPushENEx_js_1 = require("../TS/L0_Entity/GraduateEduTools/clssys_RequestPushENEx.js");
    const clsvUsersSimEN_js_1 = require("../TS/L0_Entity/UserManage/clsvUsersSimEN.js");
    const clsCurrEduClsWApi_js_1 = require("../TS/L3_ForWApi/DailyRunning/clsCurrEduClsWApi.js");
    const clssys_RequestPushWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTools/clssys_RequestPushWApi.js");
    const clsvUsersSimWApi_js_1 = require("../TS/L3_ForWApi/UserManage/clsvUsersSimWApi.js");
    const clsCommonFunc4Web2_js_1 = require("../TS/PubFun/clsCommonFunc4Web2.js");
    const clsOperateList2_js_1 = require("../TS/PubFun/clsOperateList2.js");
    const clsStackTrace_js_1 = require("../TS/PubFun/clsStackTrace.js");
    const clsString2_js_1 = require("../TS/PubFun/clsString2.js");
    /* sys_RequestPushCRUD 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
    */
    class sys_RequestPushCRUD extends clsOperateList2_js_1.clsOperateList {
        constructor() {
            super(...arguments);
            this.mstrListDiv = "divDataLst"; //列表区数据列表层id
            this.bolIsLoadEditRegion = false; //记录是否导入编辑区的变量
            this.bolIsLoadDetailRegion = false; //记录是否导入详细信息区的变量
            this.divName4Edit = "divEdit"; //编辑区的Id
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
                this.hidSortsys_RequestPushBy = "receiveUser Asc";
                //2、显示无条件的表内容在GridView中
                const responseBindGv = await this.BindGv_sys_RequestPush4Func();
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
                this.hidSortsys_RequestPushBy = "receiveUser Asc";
                //2、显示无条件的表内容在GridView中
                const responseBindGv = await this.BindGv_sys_RequestPush4Func();
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
            const responseBindGv = await this.BindGv_sys_RequestPush4Func();
        }
        /// <summary>
        /// 设置绑定下拉框，针对字段:[id_CurrEduCls]
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TS4QryRegion)
        /// </summary>
        async SetDdl_id_CurrEduCls() {
            var objCurrEduCls_Cond = new clsCurrEduClsEN_js_1.clsCurrEduClsEN(); //查询区域
            const ddlid_CurrEduCls_q = await (0, clsCurrEduClsWApi_js_1.CurrEduCls_BindDdl_id_CurrEduClsInDiv_Cache)(this.divName4List, "ddlid_CurrEduCls_q"); //查询区域
        }
        /* 函数功能:为查询区绑定下拉框
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4QueryRegion)
       */
        async BindDdl4QueryRegion() {
            // 在此处放置用户代码以初始化页面
            const ddlid_CurrEduCls_q = await this.SetDdl_id_CurrEduCls(); //查询区域
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
                const responseBindGv = await this.BindGv_sys_RequestPush4Func();
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
                var lngKeyId = Number(strKeyId);
                const responseText = await this.DelRecord(lngKeyId);
                const responseBindGv = await this.BindGv_sys_RequestPush4Func();
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
        根据关键字删除记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
       */
        async DelRecord(lngRequestId) {
            try {
                const responseText = await (0, clssys_RequestPushWApi_js_1.sys_RequestPush_DelRecordAsync)(lngRequestId);
                var returnInt = responseText;
                if (returnInt > 0) {
                    //sys_RequestPush_ReFreshCache();
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
        async SelectRecord(lngRequestId) {
            try {
                const responseText = await (0, clssys_RequestPushWApi_js_1.sys_RequestPush_GetObjByRequestIdAsync)(lngRequestId);
                var objsys_RequestPushEN = responseText;
                console.log("完成SelectRecord!");
                clsCommonFunc4Web2_js_1.clsCommonFunc4Web.Redirect("/Index/Main_sys_RequestPush");
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
                const responseBindGv = await this.BindGv_sys_RequestPush4Func();
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
                const responseText = await (0, clssys_RequestPushWApi_js_1.sys_RequestPush_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    var arrsys_RequestPushObjLst = jsonData;
                    this.BindTab_sys_RequestPush(this.mstrListDiv, arrsys_RequestPushObjLst);
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
        Combinesys_RequestPushCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.ReceiveUser_q != "") {
                    strWhereCond += ` And ${clssys_RequestPushEN_js_1.clssys_RequestPushEN.con_ReceiveUser} like '% ${this.ReceiveUser_q}%'`;
                }
                if (this.id_CurrEduCls_q != "" && this.id_CurrEduCls_q != "0") {
                    strWhereCond += ` And ${clssys_RequestPushEN_js_1.clssys_RequestPushEN.con_id_CurrEduCls} = '${this.id_CurrEduCls_q}'`;
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0009)在组合查询条件(Combinesys_RequestPushCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
         <returns>条件串(strWhereCond)</returns>
       */
        Combinesys_RequestPushConditionObj() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var objsys_RequestPush_Cond = new clssys_RequestPushEN_js_1.clssys_RequestPushEN();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.ReceiveUser_q != "") {
                    strWhereCond += ` And ${clssys_RequestPushEN_js_1.clssys_RequestPushEN.con_ReceiveUser} like '% ${this.ReceiveUser_q}%'`;
                    objsys_RequestPush_Cond.SetCondFldValue(clssys_RequestPushEN_js_1.clssys_RequestPushEN.con_ReceiveUser, this.ReceiveUser_q, "like");
                }
                if (this.id_CurrEduCls_q != "" && this.id_CurrEduCls_q != "0") {
                    strWhereCond += ` And ${clssys_RequestPushEN_js_1.clssys_RequestPushEN.con_id_CurrEduCls} = '${this.id_CurrEduCls_q}'`;
                    objsys_RequestPush_Cond.SetCondFldValue(clssys_RequestPushEN_js_1.clssys_RequestPushEN.con_id_CurrEduCls, this.id_CurrEduCls_q, "=");
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0010)在组合查询条件对象(Combinesys_RequestPushConditionObj)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return objsys_RequestPush_Cond;
        }
        /* 显示sys_RequestPush对象的所有属性值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
         <param name = "divContainer">显示容器</param>
         <param name = "arrsys_RequestPushObjLst">需要绑定的对象列表</param>
       */
        BindTab_sys_RequestPush(divContainer, arrsys_RequestPushObjLst) {
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
                    FldName: "receiveUser",
                    SortBy: "",
                    ColHeader: "接收用户",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 2,
                    FuncName: () => { }
                },
                {
                    FldName: "id_CurrEduCls",
                    SortBy: "",
                    ColHeader: "教学班",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 3,
                    FuncName: () => { }
                },
                {
                    FldName: "requestUser",
                    SortBy: "",
                    ColHeader: "推送人",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 4,
                    FuncName: () => { }
                },
                {
                    FldName: "requestDate",
                    SortBy: "",
                    ColHeader: "推送日期",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 5,
                    FuncName: () => { }
                },
                {
                    FldName: "",
                    SortBy: "",
                    ColHeader: "修改",
                    Text: "修改",
                    TdClass: "text-left",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId, strText) => {
                        var btn1 = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btn_Click('UpdateRecordInTab', '${strKeyId}');`);
                        return btn1;
                    }
                },
                {
                    FldName: "",
                    SortBy: "",
                    ColHeader: "删除",
                    Text: "删除",
                    TdClass: "text-left",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId, strText) => {
                        var btn1 = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btn_Click('DelRecordInTab', '${strKeyId}');`);
                        return btn1;
                    }
                },
            ];
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindTabV2(o, arrsys_RequestPushObjLst, arrDataColumn, "requestId");
            this.objPager.RecCount = this.RecCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        /* 显示sys_RequestPush对象的所有属性值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab4Func)
         <param name = "divContainer">显示容器</param>
         <param name = "arrsys_RequestPushObjLst">需要绑定的对象列表</param>
       */
        BindTab_sys_RequestPush4Func(divContainer, arrsys_RequestPushExObjLst) {
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
                    FldName: "userName",
                    SortBy: "userName",
                    ColHeader: "接收用户",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 2,
                    FuncName: () => { }
                },
                {
                    FldName: "eduClsName",
                    SortBy: "eduClsName",
                    ColHeader: "教学班",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 3,
                    FuncName: () => { }
                },
                {
                    FldName: "requestUser",
                    SortBy: "requestUser",
                    ColHeader: "推送人",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 4,
                    FuncName: () => { }
                },
                {
                    FldName: "requestDate",
                    SortBy: "requestDate",
                    ColHeader: "推送日期",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 5,
                    FuncName: () => { }
                },
                {
                    FldName: "",
                    SortBy: "",
                    ColHeader: "修改",
                    Text: "修改",
                    TdClass: "text-left",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId, strText) => {
                        var btn1 = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btn_Click('UpdateRecordInTab', '${strKeyId}');`);
                        return btn1;
                    }
                },
                {
                    FldName: "",
                    SortBy: "",
                    ColHeader: "删除",
                    Text: "删除",
                    TdClass: "text-left",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId, strText) => {
                        var btn1 = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btn_Click('DelRecordInTab', '${strKeyId}');`);
                        return btn1;
                    }
                },
            ];
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindTabV2(o, arrsys_RequestPushExObjLst, arrDataColumn, "requestId");
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
            const responseBindGv = await this.BindGv_sys_RequestPush4Func();
        }
        /* 根据条件获取相应的对象列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
       */
        async BindGv_sys_RequestPush() {
            if (this.hidSortsys_RequestPushBy == null) {
                var strMsg = `在显示列表时，排序字段(hidSortsys_RequestPushBy)为空，请检查！(In BindGv_sys_RequestPush)`;
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            var strListDiv = this.mstrListDiv;
            var strWhereCond = this.Combinesys_RequestPushCondition();
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrsys_RequestPushObjLst = [];
            try {
                const responseRecCount = await (0, clssys_RequestPushWApi_js_1.sys_RequestPush_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortsys_RequestPushBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clssys_RequestPushWApi_js_1.sys_RequestPush_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrsys_RequestPushObjLst = jsonData;
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
            if (arrsys_RequestPushObjLst.length == 0) {
                var strMsg = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            try {
                this.BindTab_sys_RequestPush(strListDiv, arrsys_RequestPushObjLst);
                console.log("完成BindGv_sys_RequestPush!");
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
        async BindGv_sys_RequestPush_Cache() {
            if (this.hidSortsys_RequestPushBy == null) {
                var strMsg = `在显示列表时，排序字段(hidSortsys_RequestPushBy)为空，请检查！(In BindGv_sys_RequestPush_Cache)`;
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            var strListDiv = this.mstrListDiv;
            var objsys_RequestPush_Cond = this.Combinesys_RequestPushConditionObj();
            var strWhereCond = JSON.stringify(objsys_RequestPush_Cond);
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrsys_RequestPushObjLst = [];
            try {
                this.RecCount = await (0, clssys_RequestPushWApi_js_1.sys_RequestPush_GetRecCountByCond_Cache)(objsys_RequestPush_Cond);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortsys_RequestPushBy,
                    sortFun: (x, y) => { return 0; }
                };
                var arrsys_RequestPushObjLst = await (0, clssys_RequestPushWApi_js_1.sys_RequestPush_GetObjLstByPager_Cache)(objPagerPara);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                alert(strMsg);
                return;
            }
            if (arrsys_RequestPushObjLst.length == 0) {
                var strKey = `${clssys_RequestPushEN_js_1.clssys_RequestPushEN._CurrTabName}`;
                var strMsg = `在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=${strKey})`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            try {
                this.BindTab_sys_RequestPush(strListDiv, arrsys_RequestPushObjLst);
                console.log("完成BindGv_sys_RequestPush!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /* 根据条件获取相应的对象列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv4Func)
       */
        async BindGv_sys_RequestPush4Func() {
            if (this.hidSortsys_RequestPushBy == null) {
                var strMsg = `在显示列表时，排序字段(hidSortsys_RequestPushBy)为空，请检查！(In BindGv_sys_RequestPush_Cache)`;
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            var strListDiv = this.mstrListDiv;
            var objsys_RequestPush_Cond = this.Combinesys_RequestPushConditionObj();
            var strWhereCond = JSON.stringify(objsys_RequestPush_Cond);
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrsys_RequestPushObjLst = [];
            var arrsys_RequestPushExObjLst = [];
            try {
                this.RecCount = await (0, clssys_RequestPushWApi_js_1.sys_RequestPush_GetRecCountByCond_Cache)(objsys_RequestPush_Cond);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortsys_RequestPushBy,
                    sortFun: (x, y) => { return 0; }
                };
                arrsys_RequestPushObjLst = await (0, clssys_RequestPushWApi_js_1.sys_RequestPush_GetObjLstByPager_Cache)(objPagerPara);
                arrsys_RequestPushExObjLst = arrsys_RequestPushObjLst.map(this.CopyToEx);
                for (var objInFor of arrsys_RequestPushExObjLst) {
                    const conFuncMap = await this.FuncMap(objInFor);
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                alert(strMsg);
                return;
            }
            if (arrsys_RequestPushObjLst.length == 0) {
                var strKey = `${clssys_RequestPushEN_js_1.clssys_RequestPushEN._CurrTabName}`;
                var strMsg = `在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=${strKey})`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            try {
                this.BindTab_sys_RequestPush4Func(strListDiv, arrsys_RequestPushExObjLst);
                console.log("完成BindGv_sys_RequestPush!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CopyToEx)
        /// </summary>
        /// <param name = "objsys_RequestPushENS">源对象</param>
        /// <returns>目标对象=>clssys_RequestPushEN:objsys_RequestPushENT</returns>
        CopyToEx(objsys_RequestPushENS) {
            var objsys_RequestPushENT = new clssys_RequestPushENEx_js_1.clssys_RequestPushENEx();
            try {
                (0, clssys_RequestPushWApi_js_1.sys_RequestPush_CopyObjTo)(objsys_RequestPushENS, objsys_RequestPushENT);
                return objsys_RequestPushENT;
            }
            catch (e) {
                var strMsg = clsString2_js_1.clsString.Format("(errid:WiTsCs0011)Copy表对象数据出错,${e}.({0})", clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction());
                alert(strMsg);
                return objsys_RequestPushENT;
            }
        }
        /// <summary>
        /// 把一个扩展类的部分属性进行函数转换
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_FuncMap)
        /// </summary>
        /// <param name = "objsys_RequestPushS">源对象</param>
        async FuncMap(objsys_RequestPush) {
            try {
                {
                    var vUsersSim_UserId = objsys_RequestPush.receiveUser;
                    var vUsersSim_UserName = await (0, clsvUsersSimWApi_js_1.vUsersSim_func)(clsvUsersSimEN_js_1.clsvUsersSimEN.con_UserId, clsvUsersSimEN_js_1.clsvUsersSimEN.con_UserName, vUsersSim_UserId);
                    objsys_RequestPush.userName = vUsersSim_UserName;
                }
                ;
                {
                    var CurrEduCls_id_CurrEduCls = objsys_RequestPush.id_CurrEduCls;
                    var CurrEduCls_eduClsName = await (0, clsCurrEduClsWApi_js_1.CurrEduCls_func)(clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_CurrEduCls, clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_EduClsName, CurrEduCls_id_CurrEduCls);
                    objsys_RequestPush.eduClsName = CurrEduCls_eduClsName;
                }
                ;
            }
            catch (e) {
                var strMsg = `(errid:WiTsCs0012)函数映射表对象数据出错,${e}.(${clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction()})`;
                alert(strMsg);
            }
        }
        /* 函数功能:从界面列表中根据某一个字段排序
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortBy)
         <param name = "strSortByFld">排序的字段</param>
       */
        async SortBy(strSortByFld) {
            if (this.hidSortsys_RequestPushBy.indexOf(strSortByFld) >= 0) {
                if (this.hidSortsys_RequestPushBy.indexOf("Asc") >= 0) {
                    this.hidSortsys_RequestPushBy = `${strSortByFld} Desc`;
                }
                else {
                    this.hidSortsys_RequestPushBy = `${strSortByFld} Asc`;
                }
            }
            else {
                this.hidSortsys_RequestPushBy = `${strSortByFld} Asc`;
            }
            const responseBindGv = await this.BindGv_sys_RequestPush4Func();
        }
        /* 复制记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CopyRecord)
       */
        async CopyRecord(arrRequestId) {
            try {
                const responseText = await (0, clssys_RequestPushWApi_js_1.sys_RequestPush_GetObjLstByRequestIdLstAsync)(arrRequestId);
                console.log('responseText=');
                console.log(responseText);
                var intCount = 0;
                var arrsys_RequestPushObjLst = responseText;
                for (let objInFor of arrsys_RequestPushObjLst) {
                    const responseText2 = await (0, clssys_RequestPushWApi_js_1.sys_RequestPush_AddNewRecordAsync)(objInFor);
                    console.log('responseText2=');
                    console.log(responseText2);
                    var returnBool = !!responseText2;
                    if (returnBool == true) {
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
        async DelMultiRecord(arrRequestId) {
            try {
                const responseText = await (0, clssys_RequestPushWApi_js_1.sys_RequestPush_Delsys_RequestPushsAsync)(arrRequestId);
                var returnInt = responseText;
                if (returnInt > 0) {
                    //sys_RequestPush_ReFreshCache();
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
         <param name = "objsys_RequestPush">需要显示的对象</param>
       */
        Showsys_RequestPushObj(divContainer, objsys_RequestPush) {
            var o = document.getElementById(divContainer);
            if (o == null) {
                alert(`${divContainer}不存在！`);
                return;
            }
            var sstrKeys = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetObjKeys(objsys_RequestPush);
            var ul = document.createElement("ul");
            for (let strKey of sstrKeys) {
                var strValue = objsys_RequestPush[strKey];
                var li = document.createElement("li");
                li.innerHTML = `${strKey}:${strValue}`;
                ul.appendChild(li);
            }
            o.appendChild(ul);
        }
        /* 函数功能:从界面列表中获取第一个关键字的值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
         <param name = "pobjsys_RequestPushEN">表实体类对象</param>
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
        set hidSortsys_RequestPushBy(value) {
            $("#hidSortsys_RequestPushBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortsys_RequestPushBy() {
            return $("#hidSortsys_RequestPushBy").val();
        }
        /*
        * 当前教学班流水号 (Used In CombineCondition())
       */
        get id_CurrEduCls_q() {
            return $("#ddlid_CurrEduCls_q").val();
        }
        /*
        * 接收用户 (Used In CombineCondition())
       */
        get ReceiveUser_q() {
            return $("#txtReceiveUser_q").val();
        }
    }
    exports.sys_RequestPushCRUD = sys_RequestPushCRUD;
});
