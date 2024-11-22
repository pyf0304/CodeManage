(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L0_Entity/BaseInfo/clsXzClgEN.js", "../TS/L0_Entity/BaseInfo/clsXzMajorEN.js", "../TS/L0_Entity/SysPara/clsXzGradeBaseEN.js", "../TS/L0_Entity/UserManage/clsUserIdentityEN.js", "../TS/L0_Entity/UserManage/clsUsersEN.js", "../TS/L0_Entity/UserManage/clsvUsersEN.js", "../TS/L3_ForWApi/BaseInfo/clsXzClgWApi.js", "../TS/L3_ForWApi/BaseInfo/clsXzMajorWApi.js", "../TS/L3_ForWApi/SysPara/clsXzGradeBaseWApi.js", "../TS/L3_ForWApi/UserManage/clsUserIdentityWApi.js", "../TS/L3_ForWApi/UserManage/clsUsersWApi.js", "../TS/L3_ForWApi/UserManage/clsvUsersWApi.js", "../TS/PubFun/clsCommonFunc4Web2.js", "../TS/PubFun/clsOperateList2.js", "../TS/PubFun/clsString2.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.Users_QUDI = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:WApiUsers_QUDI_TS
    表名:Users(01120034)
    生成代码版本:2020.03.03.1
    生成日期:2020/03/04 13:39:07
    生成者:
    工程名称:问卷调查
    工程ID:0112
    相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
    PrjDataBaseId:0122
    模块中文名:用户管理
    模块英文名:UserManage
    框架-层名:WA_界面脚本后台_TS(WA_ViewScriptCS_TS)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //import * as $ from "jquery";
    //import * as QQ from "q";
    const clsXzClgEN_js_1 = require("../TS/L0_Entity/BaseInfo/clsXzClgEN.js");
    const clsXzMajorEN_js_1 = require("../TS/L0_Entity/BaseInfo/clsXzMajorEN.js");
    const clsXzGradeBaseEN_js_1 = require("../TS/L0_Entity/SysPara/clsXzGradeBaseEN.js");
    const clsUserIdentityEN_js_1 = require("../TS/L0_Entity/UserManage/clsUserIdentityEN.js");
    const clsUsersEN_js_1 = require("../TS/L0_Entity/UserManage/clsUsersEN.js");
    const clsvUsersEN_js_1 = require("../TS/L0_Entity/UserManage/clsvUsersEN.js");
    const clsXzClgWApi_js_1 = require("../TS/L3_ForWApi/BaseInfo/clsXzClgWApi.js");
    const clsXzMajorWApi_js_1 = require("../TS/L3_ForWApi/BaseInfo/clsXzMajorWApi.js");
    const clsXzGradeBaseWApi_js_1 = require("../TS/L3_ForWApi/SysPara/clsXzGradeBaseWApi.js");
    const clsUserIdentityWApi_js_1 = require("../TS/L3_ForWApi/UserManage/clsUserIdentityWApi.js");
    const clsUsersWApi_js_1 = require("../TS/L3_ForWApi/UserManage/clsUsersWApi.js");
    const clsvUsersWApi_js_1 = require("../TS/L3_ForWApi/UserManage/clsvUsersWApi.js");
    const clsCommonFunc4Web2_js_1 = require("../TS/PubFun/clsCommonFunc4Web2.js");
    const clsOperateList2_js_1 = require("../TS/PubFun/clsOperateList2.js");
    const clsString2_js_1 = require("../TS/PubFun/clsString2.js");
    /* WApiUsers_QUDI_TS 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
    */
    class Users_QUDI extends clsOperateList2_js_1.clsOperateList {
        constructor() {
            super(...arguments);
            this.mstrListDiv = "divDataLst";
            this.RecCount = 0;
        }
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 5;
        }
        /* 为插入记录做准备工作
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
       */
        AddNewRecord() {
            this.SetKeyReadOnly(false);
            this.btnOKUpd = "确认添加";
            this.btnCancel = "取消添加";
            this.Clear();
            //wucUsersB1.userId = Users_GetMaxStrId_S();
        }
        /* 添加新记录，保存函数
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
       */
        async AddNewRecordSave() {
            this.DivName = "divAddNewRecordSave";
            var objUsersEN = new clsUsersEN_js_1.clsUsersEN();
            this.PutDataToUsersClass(objUsersEN);
            try {
                const responseText = await (0, clsUsersWApi_js_1.Users_IsExistAsync)(objUsersEN.userId);
                var bolIsExist = responseText;
                if (bolIsExist == true) {
                    var strMsg = `添加记录时，关键字：${objUsersEN.userId}已经存在！`;
                    alert(strMsg);
                    return responseText; //一定要有一个返回值，否则会出错！
                }
                const responseText2 = await (0, clsUsersWApi_js_1.Users_AddNewRecordAsync)(objUsersEN);
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
        /* 为插入记录做准备工作
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxId)
       */
        AddNewRecordWithMaxId() {
            this.SetKeyReadOnly(false);
            this.btnOKUpd = "确认添加";
            this.btnCancel = "取消添加";
            this.Clear();
            //wucUsersB1.userId = Users_GetMaxStrId_S();
        }
        /* 添加新记录，由后台自动获取最大值的关键字。保存函数
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxIdSave)
       */
        async AddNewRecordWithMaxIdSave() {
            this.DivName = "divAddNewRecordWithMaxIdSave";
            var objUsersEN = new clsUsersEN_js_1.clsUsersEN();
            this.PutDataToUsersClass(objUsersEN);
            try {
                const responseText2 = await (0, clsUsersWApi_js_1.Users_AddNewRecordWithMaxIdAsync)(objUsersEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strInfo = `添加记录成功!`;
                    $('#lblResult47').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    var strInfo = `添加记录不成功!`;
                    $('#lblResult47').val(strInfo);
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
        /* 根据条件获取相应的对象列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
       */
        async BindGv_vUsers() {
            var strListDiv = this.mstrListDiv;
            var strWhereCond = this.CombinevUsersCondition();
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrvUsersObjLst = [];
            try {
                const responseRecCount = await (0, clsvUsersWApi_js_1.vUsers_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvUsersBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvUsersWApi_js_1.vUsers_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvUsersObjLst = jsonData;
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                alert(strMsg);
            }
            if (arrvUsersObjLst.length == 0) {
                var strMsg = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
                alert(strMsg);
                return;
            }
            try {
                this.BindTab_vUsers(strListDiv, arrvUsersObjLst);
                console.log("完成BindGv_vUsers!");
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
        async BindGv_vUsers_Cache() {
            var strListDiv = this.mstrListDiv;
            var objvUsers_Cond = this.CombinevUsersConditionObj();
            var strWhereCond = JSON.stringify(objvUsers_Cond);
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrvUsersObjLst = [];
            try {
                this.RecCount = await (0, clsvUsersWApi_js_1.vUsers_GetRecCountByCond_Cache)(objvUsers_Cond);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvUsersBy,
                    sortFun: (x, y) => { return 0; }
                };
                var arrvUsersObjLst = await (0, clsvUsersWApi_js_1.vUsers_GetObjLstByPager_Cache)(objPagerPara);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                alert(strMsg);
            }
            if (arrvUsersObjLst.length == 0) {
                var strMsg = `在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=Users)`;
                alert(strMsg);
                return;
            }
            try {
                this.BindTab_vUsers(strListDiv, arrvUsersObjLst);
                console.log("完成BindGv_vUsers!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /* 显示vUsers对象的所有属性值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
         <param name = "divContainer">显示容器</param>
         <param name = "arrUsersObjLst">需要绑定的对象列表</param>
       */
        BindTab_vUsers(divContainer, arrvUsersObjLst) {
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
                    FldName: "userId",
                    ColHeader: "用户ID",
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
                    FldName: "password",
                    ColHeader: "password",
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
                    FldName: "identityDesc",
                    ColHeader: "身份描述",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "email",
                    ColHeader: "电子邮箱",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "",
                    ColHeader: "修改",
                    Text: "修改", TdClass: "text-left", SortBy: "",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId, strText) => {
                        var btn1 = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnUpdateRecordInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
                {
                    FldName: "",
                    ColHeader: "删除",
                    Text: "删除", TdClass: "text-left", SortBy: "",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId, strText) => {
                        var btn1 = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
            ];
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindTabV2(o, arrvUsersObjLst, arrDataColumn, "userId");
            this.objPager.RecCount = this.RecCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
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
                const responseBindGv = await this.BindGv_vUsers();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
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
                const responseText = await this.DelRecord(strKeyId).then((jsonData) => {
                    ;
                });
                const responseBindGv = await this.BindGv_vUsers();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
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
                this.DetailRecord(strKeyId);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `详细信息记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /* 根据条件获取相应的对象列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnExportExcel_Click)
       */
        async btnExportExcel_Click() {
            var strWhereCond = " 1=1 ";
            try {
                const responseText = await (0, clsvUsersWApi_js_1.vUsers_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    var arrvUsersObjLst = jsonData;
                    this.BindTab_vUsers(this.mstrListDiv, arrvUsersObjLst);
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
                            const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData) => {
                                var returnBool2 = jsonData;
                                if (clsString2_js_1.clsString.IsNullOrEmpty(returnBool2) == false) {
                                    HideDialog();
                                    this.BindGv_vUsers();
                                }
                            });
                        }
                        else {
                            const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    HideDialog();
                                    this.BindGv_vUsers();
                                }
                            });
                        }
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                            var returnBool = jsonData;
                            if (returnBool == true) {
                                HideDialog();
                                this.BindGv_vUsers();
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
        /* 根据条件获取相应的对象列表
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
       */
        async btnQuery_Click(strListDiv) {
            var strWhereCond = this.CombinevUsersCondition();
            try {
                const responseRecCount = await (0, clsvUsersWApi_js_1.vUsers_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                var objPagerPara = {
                    pageIndex: 1,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvUsersBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvUsersWApi_js_1.vUsers_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    var arrvUsersObjLst = jsonData;
                    this.BindTab_vUsers(this.mstrListDiv, arrvUsersObjLst);
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `查询不成功,${e}.`;
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
            this.UpdateRecord(strKeyId);
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
            this.UpdateRecord(strKeyId);
        }
        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Clear)
        /// </summary>	
        Clear() {
            this.userId = "";
            this.userName = "";
            this.userStateId = "";
            this.password = "";
            $('#ddlid_GradeBase option[0]').attr("selected", true);
            $('#ddlid_XzCollege option[0]').attr("selected", true);
            $('#ddlid_XzMajor option[0]').attr("selected", true);
            this.stuIdTeacherId = "";
            this.email = "";
            $('#ddlIdentityID option[0]').attr("selected", true);
            this.isRegister = false;
            this.registerDate = "";
            this.mobilePhone = "";
            this.openId = "";
            this.updDate = "";
            this.updUser = "";
            this.memo = "";
        }
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
         <returns>条件串(strWhereCond)</returns>
       */
        CombinevUsersCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.id_XzCollege_q != "" && this.id_XzCollege_q != "0") {
                    strWhereCond += ` And ${clsvUsersEN_js_1.clsvUsersEN.con_id_XzCollege} = '${this.id_XzCollege_q}'`;
                }
                if (this.id_XzMajor_q != "" && this.id_XzMajor_q != "0") {
                    strWhereCond += ` And ${clsvUsersEN_js_1.clsvUsersEN.con_id_XzMajor} = '${this.id_XzMajor_q}'`;
                }
                if (this.UserName_q != "") {
                    strWhereCond += ` And ${clsvUsersEN_js_1.clsvUsersEN.con_UserName} like '% ${this.UserName_q}%'`;
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineUsersCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
         <returns>条件串(strWhereCond)</returns>
       */
        CombinevUsersConditionObj() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var objvUsers_Cond = new clsvUsersEN_js_1.clsvUsersEN();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.id_XzCollege_q != "" && this.id_XzCollege_q != "0") {
                    strWhereCond += ` And ${clsvUsersEN_js_1.clsvUsersEN.con_id_XzCollege} = '${this.id_XzCollege_q}'`;
                    objvUsers_Cond.SetCondFldValue(clsvUsersEN_js_1.clsvUsersEN.con_id_XzCollege, this.id_XzCollege_q, "=");
                }
                if (this.id_XzMajor_q != "" && this.id_XzMajor_q != "0") {
                    strWhereCond += ` And ${clsvUsersEN_js_1.clsvUsersEN.con_id_XzMajor} = '${this.id_XzMajor_q}'`;
                    objvUsers_Cond.SetCondFldValue(clsvUsersEN_js_1.clsvUsersEN.con_id_XzMajor, this.id_XzMajor_q, "=");
                }
                if (this.UserName_q != "") {
                    strWhereCond += ` And ${clsvUsersEN_js_1.clsvUsersEN.con_UserName} like '% ${this.UserName_q}%'`;
                    objvUsers_Cond.SetCondFldValue(clsvUsersEN_js_1.clsvUsersEN.con_UserName, this.UserName_q, "like");
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0005)在组合查询条件对象(CombineUsersConditionObj)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return objvUsers_Cond;
        }
        /* 根据关键字列表删除记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelMultiRecord)
       */
        DelMultiRecord(arrUserId) {
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsUsersWApi_js_1.Users_DelUserssAsync)(arrUserId).then((jsonData) => {
                        var returnInt = jsonData;
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
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    console.error('catch(e)=');
                    console.error(e);
                    var strMsg = `删除记录不成功. ${e}.`;
                    alert(strMsg);
                }
            });
        }
        /*
        根据关键字删除记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
       */
        DelRecord(strUserId) {
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsUsersWApi_js_1.Users_DelRecordAsync)(strUserId).then((jsonData) => {
                        var returnInt = jsonData;
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
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    console.error('catch(e)=');
                    console.error(e);
                    var strMsg = `删除记录不成功. ${e}.`;
                    alert(strMsg);
                }
            });
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
        根据关键字详细信息记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DetailRecord)
         <param name = "sender">参数列表</param>
       */
        DetailRecord(strUserId) {
            this.btnOKUpd = "";
            this.btnCancel = "关闭";
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsUsersWApi_js_1.Users_GetObjByUserIdAsync)(strUserId).then((jsonData) => {
                        var objUsersEN = jsonData;
                        this.GetDataFromUsersClass(objUsersEN);
                        console.log("完成DetailRecord!");
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    console.error(e);
                    var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                    alert(strMsg);
                }
            });
        }
        /* 函数功能:把类对象的属性内容显示到界面上
        注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
         如果在设置数据库时,就应该一级字段在前,二级字段在后
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
         <param name = "pobjUsersEN">表实体类对象</param>
       */
        GetDataFromUsersClass(pobjUsersEN) {
            this.userId = pobjUsersEN.userId; // 用户ID
            this.userName = pobjUsersEN.userName; // 用户名
            this.userStateId = pobjUsersEN.userStateId; // 用户状态Id
            this.password = pobjUsersEN.password; // password
            this.id_GradeBase = pobjUsersEN.id_GradeBase; // 年级流水号
            this.id_XzCollege = pobjUsersEN.id_XzCollege; // 学院流水号
            this.id_XzMajor = pobjUsersEN.id_XzMajor; // 专业流水号
            this.stuIdTeacherId = pobjUsersEN.stuIdTeacherId; // 学工号
            this.email = pobjUsersEN.email; // 电子邮箱
            this.identityID = pobjUsersEN.identityID; // 身份编号
            this.isRegister = pobjUsersEN.isRegister; // isRegister
            this.registerDate = pobjUsersEN.registerDate; // registerDate
            this.mobilePhone = pobjUsersEN.mobilePhone; // 手机
            this.openId = pobjUsersEN.openId; // 微信openId
            this.updDate = pobjUsersEN.updDate; // 修改日期
            this.updUser = pobjUsersEN.updUser; // 修改人
            this.memo = pobjUsersEN.memo; // 备注
        }
        /* 函数功能:从界面列表中获取第一个关键字的值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
         <param name = "pobjUsersEN">表实体类对象</param>
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
            this.BindGv_vUsers();
        }
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
       */
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                //1、为下拉框设置数据源,绑定列表数据
                //const ddl_id_GradeBase = await this.BindDdl_id_GradeBase("ddlid_GradeBase");
                //const ddl_id_XzCollege = await this.BindDdl_id_XzCollege("ddlid_XzCollege");
                //const ddl_id_XzMajor = await this.BindDdl_id_XzMajor("ddlid_XzMajor");
                //const ddl_IdentityID = await this.BindDdl_IdentityID("ddlIdentityID");
                //const ddl_id_XzCollege_q = await this.BindDdl_id_XzCollege("ddlid_XzCollege_q");
                //const ddl_id_XzMajor_q = await this.BindDdl_id_XzMajor("ddlid_XzMajor_q");
                this.hidSortvUsersBy = "userId Asc";
                var strWhereCond = this.CombinevUsersCondition();
                const responseText = await (0, clsvUsersWApi_js_1.vUsers_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_vUsers();
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
                const arrXzGradeBase_Cache = await (0, clsXzGradeBaseWApi_js_1.XzGradeBase_GetObjLstAsync)("1=1");
                const arrXzClg_Cache = await (0, clsXzClgWApi_js_1.XzClg_GetObjLstAsync)("1=1");
                const arrXzMajor_Cache = await (0, clsXzMajorWApi_js_1.XzMajor_GetObjLstAsync)("1=1");
                const arrUserIdentity_Cache = await (0, clsUserIdentityWApi_js_1.UserIdentity_GetObjLstAsync)("1=1");
                const arrvUsers_Cache = await (0, clsvUsersWApi_js_1.vUsers_GetObjLstAsync)("1=1");
                var objXzGradeBase_Cond = new clsXzGradeBaseEN_js_1.clsXzGradeBaseEN();
                var objXzClg_Cond = new clsXzClgEN_js_1.clsXzClgEN();
                var objXzMajor_Cond = new clsXzMajorEN_js_1.clsXzMajorEN();
                var objUserIdentity_Cond = new clsUserIdentityEN_js_1.clsUserIdentityEN();
                //1、为下拉框设置数据源,绑定列表数据
                const ddl_id_GradeBase = (0, clsXzGradeBaseWApi_js_1.XzGradeBase_BindDdl_id_GradeBaseInDiv_Cache)(this.divName4List, "ddlid_GradeBase");
                const ddl_id_XzCollege = (0, clsXzClgWApi_js_1.XzClg_BindDdl_id_XzCollegeInDiv_Cache)(this.divName4List, "ddlid_XzCollege");
                const ddl_id_XzMajor = (0, clsXzMajorWApi_js_1.XzMajor_BindDdl_id_XzMajor_Cache)(this.divName4List, "ddlid_XzMajor");
                const ddl_IdentityID = (0, clsUserIdentityWApi_js_1.UserIdentity_BindDdl_IdentityIDInDiv_Cache)(this.divName4List, "ddlIdentityID");
                const ddl_id_XzCollege_q = (0, clsXzClgWApi_js_1.XzClg_BindDdl_id_XzCollegeInDiv_Cache)(this.divName4List, "ddlid_XzCollege_q");
                const ddl_id_XzMajor_q = (0, clsXzMajorWApi_js_1.XzMajor_BindDdl_id_XzMajor_Cache)(this.divName4List, "ddlid_XzMajor_q");
                this.hidSortvUsersBy = "userId Asc";
                var objvUsers_Cond = this.CombinevUsersConditionObj();
                this.RecCount = await (0, clsvUsersWApi_js_1.vUsers_GetRecCountByCond_Cache)(objvUsers_Cond);
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_vUsers_Cache();
            }
            catch (e) {
                var strMsg = `页面启动不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 函数功能:把界面上的属性数据传到类对象中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
         <param name = "pobjUsersEN">数据传输的目的类对象</param>
       */
        PutDataToUsersClass(pobjUsersEN) {
            pobjUsersEN.userId = this.userId; // 用户ID
            pobjUsersEN.userName = this.userName; // 用户名
            pobjUsersEN.userStateId = this.userStateId; // 用户状态Id
            pobjUsersEN.password = this.password; // password
            pobjUsersEN.id_GradeBase = this.id_GradeBase; // 年级流水号
            pobjUsersEN.id_XzCollege = this.id_XzCollege; // 学院流水号
            pobjUsersEN.id_XzMajor = this.id_XzMajor; // 专业流水号
            pobjUsersEN.stuIdTeacherId = this.stuIdTeacherId; // 学工号
            pobjUsersEN.email = this.email; // 电子邮箱
            pobjUsersEN.identityID = this.identityID; // 身份编号
            pobjUsersEN.isRegister = this.isRegister; // isRegister
            pobjUsersEN.registerDate = this.registerDate; // registerDate
            pobjUsersEN.mobilePhone = this.mobilePhone; // 手机
            pobjUsersEN.openId = this.openId; // 微信openId
            pobjUsersEN.updDate = this.updDate; // 修改日期
            pobjUsersEN.updUser = this.updUser; // 修改人
            pobjUsersEN.memo = this.memo; // 备注
        }
        /*
        根据关键字选择相应的记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SelectRecord)
         <param name = "sender">参数列表</param>
       */
        async SelectRecord(strUserId) {
            try {
                const responseText = await (0, clsUsersWApi_js_1.Users_GetObjByUserIdAsync)(strUserId);
                var objUsersEN = responseText;
                console.log("完成SelectRecord!");
                clsCommonFunc4Web2_js_1.clsCommonFunc4Web.Redirect("/Index/Main_vUsers");
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        }
        /// <summary>
        /// 在用户自定义控件中，设置关键字的值，是否只读
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetKeyReadOnly)
        /// </summary>
        /// <param name = "bolReadonly">是否只读</param>
        SetKeyReadOnly(bolReadonly) {
            $('#txtUserId').prop['ReadOnly'] = bolReadonly;
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
        /* 函数功能:把以该关键字的记录内容显示在界面上,
              在这里是把值传到表控件中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowData)
         <param name = "strUserId">表记录的关键字,显示该表关键字的内容</param>
       */
        async ShowData(strUserId) {
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            var objUsersEN = new clsUsersEN_js_1.clsUsersEN();
            try {
                const responseText = await (0, clsUsersWApi_js_1.Users_IsExistAsync)(strUserId);
                var returnBool = responseText;
                if (returnBool == false) {
                    var strInfo = `关键字:[${strUserId}] 的记录不存在!`;
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
                const responseText = await (0, clsUsersWApi_js_1.Users_GetObjByUserIdAsync)(strUserId);
                objUsersEN = responseText;
            }
            catch (e) {
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
            //3、用提供的关键字初始化一个类对象；
            this.GetDataFromUsersClass(objUsersEN);
        }
        /* 显示{0}对象的所有属性值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowTabObj)
         <param name = "divContainer">显示容器</param>
         <param name = "objUsers">需要显示的对象</param>
       */
        ShowUsersObj(divContainer, objUsers) {
            var o = document.getElementById(divContainer);
            if (o == null) {
                alert(`${divContainer}不存在！`);
                return;
            }
            var sstrKeys = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetObjKeys(objUsers);
            var ul = document.createElement("ul");
            for (let strKey of sstrKeys) {
                var strValue = objUsers[strKey];
                var li = document.createElement("li");
                li.innerHTML = `${strKey}:${strValue}`;
                ul.appendChild(li);
            }
            o.appendChild(ul);
        }
        /* 函数功能:从界面列表中根据某一个字段排序
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortBy)
         <param name = "strSortByFld">排序的字段</param>
       */
        async SortBy(strSortByFld) {
            if (this.hidSortvUsersBy.indexOf(strSortByFld) >= 0) {
                if (this.hidSortvUsersBy.indexOf("Asc") >= 0) {
                    this.hidSortvUsersBy = `${strSortByFld} Desc`;
                }
                else {
                    this.hidSortvUsersBy = `${strSortByFld} Asc`;
                }
            }
            else {
                this.hidSortvUsersBy = `${strSortByFld} Asc`;
            }
            const responseBindGv = await this.BindGv_vUsers();
        }
        /* 根据关键字获取相应的记录的对象
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
         <param name = "sender">参数列表</param>
       */
        UpdateRecord(strUserId) {
            this.btnOKUpd = "确认修改";
            this.btnCancel = "取消修改";
            this.KeyId = strUserId;
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsUsersWApi_js_1.Users_GetObjByUserIdAsync)(strUserId).then((jsonData) => {
                        var objUsersEN = jsonData;
                        this.GetDataFromUsersClass(objUsersEN);
                        console.log("完成UpdateRecord!");
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    console.error(e);
                    var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                    alert(strMsg);
                }
            });
        }
        /* 修改记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
       */
        UpdateRecordSave() {
            this.DivName = "divUpdateRecordSave";
            var objUsersEN = new clsUsersEN_js_1.clsUsersEN();
            objUsersEN.userId = this.KeyId;
            this.PutDataToUsersClass(objUsersEN);
            objUsersEN.sf_UpdFldSetStr = objUsersEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objUsersEN.userId == "" || objUsersEN.userId == undefined) {
                throw "关键字不能为空!";
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsUsersWApi_js_1.Users_UpdateRecordAsync)(objUsersEN).then((jsonData) => {
                        var returnBool = jsonData;
                        if (returnBool == true) {
                            var strInfo = `修改记录成功!`;
                            $('#lblResult51').val(strInfo);
                            //显示信息框
                            alert(strInfo);
                        }
                        else {
                            var strInfo = `修改记录不成功!`;
                            $('#lblResult51').val(strInfo);
                            //显示信息框
                            alert(strInfo);
                            console.log("完成UpdateRecordSave");
                        }
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    console.error('catch(e)=');
                    console.error(e);
                    var strMsg = `修改记录不成功,${e}.`;
                    alert(strMsg);
                    return false;
                }
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
        * 获取当前页序号
       */
        get CurrPageIndex() {
            return $("#hidCurrPageIndex").val();
        }
        /*
        * 设置当前页序号
       */
        set CurrPageIndex(value) {
            $("#hidCurrPageIndex").val(value);
        }
        /*
        * 添加、修改用的层名
       */
        set DivName(value) {
            $("#hidDivName").val(value);
        }
        /*
        * 电子邮箱
       */
        set email(value) {
            $("#txtEmail").val(value);
        }
        /*
        * 电子邮箱
       */
        get email() {
            return $("#txtEmail").val();
        }
        /*
        * 设置排序字段-相当使用ViewState功能
       */
        set hidSortvUsersBy(value) {
            $("#hidSortvUsersBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvUsersBy() {
            return $("#hidSortvUsersBy").val();
        }
        /*
        * 用户Id
       */
        get hidUserId() {
            return $("#hidUserId").val();
        }
        /*
        * 年级流水号
       */
        set id_GradeBase(value) {
            $("#ddlid_GradeBase").val(value);
        }
        /*
        * 年级流水号
       */
        get id_GradeBase() {
            return $("#ddlid_GradeBase").val();
        }
        /*
        * 学院流水号
       */
        set id_XzCollege(value) {
            $("#ddlid_XzCollege").val(value);
        }
        /*
        * 学院流水号
       */
        get id_XzCollege() {
            return $("#ddlid_XzCollege").val();
        }
        /*
        * 学院流水号
       */
        get id_XzCollege_q() {
            return $("#ddlid_XzCollege_q").val();
        }
        /*
        * 专业流水号
       */
        set id_XzMajor(value) {
            $("#ddlid_XzMajor").val(value);
        }
        /*
        * 专业流水号
       */
        get id_XzMajor() {
            return $("#ddlid_XzMajor").val();
        }
        /*
        * 专业流水号
       */
        get id_XzMajor_q() {
            return $("#ddlid_XzMajor_q").val();
        }
        /*
        * 身份编号
       */
        set identityID(value) {
            $("#ddlIdentityID").val(value);
        }
        /*
        * 身份编号
       */
        get identityID() {
            return $("#ddlIdentityID").val();
        }
        /*
        * isRegister
       */
        set isRegister(value) {
            $("#chkIsRegister").val(value);
        }
        /*
        * isRegister
       */
        get isRegister() {
            return $("#chkIsRegister").prop("checked");
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
        * 手机
       */
        set mobilePhone(value) {
            $("#txtMobilePhone").val(value);
        }
        /*
        * 手机
       */
        get mobilePhone() {
            return $("#txtMobilePhone").val();
        }
        /*
        * 微信openId
       */
        set openId(value) {
            $("#txtOpenId").val(value);
        }
        /*
        * 微信openId
       */
        get openId() {
            return $("#txtOpenId").val();
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
        * password
       */
        set password(value) {
            $("#txtPassword").val(value);
        }
        /*
        * password
       */
        get password() {
            return $("#txtPassword").val();
        }
        /*
        * registerDate
       */
        set registerDate(value) {
            $("#txtRegisterDate").val(value);
        }
        /*
        * registerDate
       */
        get registerDate() {
            return $("#txtRegisterDate").val();
        }
        /*
        * 学工号
       */
        set stuIdTeacherId(value) {
            $("#txtStuIdTeacherId").val(value);
        }
        /*
        * 学工号
       */
        get stuIdTeacherId() {
            return $("#txtStuIdTeacherId").val();
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
        set userName(value) {
            $("#txtUserName").val(value);
        }
        /*
        * 用户名
       */
        get userName() {
            return $("#txtUserName").val();
        }
        /*
        * 用户名
       */
        get UserName_q() {
            return $("#txtUserName_q").val();
        }
        /*
        * 用户状态Id
       */
        set userStateId(value) {
            $("#txtUserStateId").val(value);
        }
        /*
        * 用户状态Id
       */
        get userStateId() {
            return $("#txtUserStateId").val();
        }
    }
    exports.Users_QUDI = Users_QUDI;
});
