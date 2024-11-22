(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L0_Entity/BaseInfo/clsQxUsersEN.js", "../TS/L0_Entity/BaseInfo/clsXzClgEN.js", "../TS/L0_Entity/SysPara/clsXzGradeBaseEN.js", "../TS/L0_Entity/UserManage/clsUserIdentityEN.js", "../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js", "../TS/L3_ForWApi/BaseInfo/clsXzClgWApi.js", "../TS/L3_ForWApi/SysPara/clsXzGradeBaseWApi.js", "../TS/L3_ForWApi/UserManage/clsUserIdentityWApi.js", "../TS/PubFun/clsCommonFunc4Web2.js", "../TS/PubFun/clsOperateList2.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.QxUsers_QUDI_TS = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:QxUsers_QUDI_TS
    表名:QxUsers(01120258)
    生成代码版本:2019.10.08.1
    生成日期:2019/10/14 15:51:44
    生成者:
    工程名称:问卷调查
    工程ID:0112
    相关数据库:101.251.68.133,9433EduHigh_Jsie
    PrjDataBaseId:0170
    模块中文名:基本信息维护
    模块英文名:BaseInfo
    框架-层名:WA_界面脚本后台_TS(WA_ViewScriptCS_TS)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //import * as $ from "jquery";
    //import * as QQ from "q";
    const clsQxUsersEN_js_1 = require("../TS/L0_Entity/BaseInfo/clsQxUsersEN.js");
    //import { clsDepartmentInfoEN } from "../TS/L0_Entity/UserManage/clsDepartmentInfoEN.js";
    //import { clsDepartmentInfoWApi } from "../TS/L3_ForWApi/UserManage/clsDepartmentInfoWApi.js";
    const clsXzClgEN_js_1 = require("../TS/L0_Entity/BaseInfo/clsXzClgEN.js");
    const clsXzGradeBaseEN_js_1 = require("../TS/L0_Entity/SysPara/clsXzGradeBaseEN.js");
    const clsUserIdentityEN_js_1 = require("../TS/L0_Entity/UserManage/clsUserIdentityEN.js");
    const clsQxUsersWApi_js_1 = require("../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js");
    const clsXzClgWApi_js_1 = require("../TS/L3_ForWApi/BaseInfo/clsXzClgWApi.js");
    const clsXzGradeBaseWApi_js_1 = require("../TS/L3_ForWApi/SysPara/clsXzGradeBaseWApi.js");
    const clsUserIdentityWApi_js_1 = require("../TS/L3_ForWApi/UserManage/clsUserIdentityWApi.js");
    const clsCommonFunc4Web2_js_1 = require("../TS/PubFun/clsCommonFunc4Web2.js");
    const clsOperateList2_js_1 = require("../TS/PubFun/clsOperateList2.js");
    /* QxUsers_QUDI_TS 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
    */
    class QxUsers_QUDI_TS extends clsOperateList2_js_1.clsOperateList {
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
            //wucQxUsersB1.userId = clsQxUsersBL.GetMaxStrId_S();
        }
        /* 添加新记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
       */
        async AddNewRecordSave() {
            this.DivName = "divAddNewRecordSave";
            var objQxUsersEN = new clsQxUsersEN_js_1.clsQxUsersEN();
            this.PutDataToQxUsersClass(objQxUsersEN);
            try {
                const responseText = await (0, clsQxUsersWApi_js_1.QxUsers_IsExistAsync)(objQxUsersEN.userId);
                var bolIsExist = responseText;
                if (bolIsExist == true) {
                    var strMsg = `添加记录时，关键字：${objQxUsersEN.userId}已经存在！`;
                    alert(strMsg);
                    return responseText; //一定要有一个返回值，否则会出错！
                }
                const responseText2 = await (0, clsQxUsersWApi_js_1.QxUsers_AddNewRecordAsync)(objQxUsersEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strInfo = `添加记录成功!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    var strInfo = `添加记录不成功!`;
                    $('#lblResult40').val(strInfo);
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
        /* 根据条件获取相应的记录对象的列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
       */
        async BindGv_QxUsers() {
            var strListDiv = this.mstrListDiv;
            var strWhereCond = this.CombineQxUsersCondition();
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrQxUsersObjLst = [];
            try {
                const responseRecCount = await (0, clsQxUsersWApi_js_1.QxUsers_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortQxUsersBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsQxUsersWApi_js_1.QxUsers_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrQxUsersObjLst = jsonData;
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            if (arrQxUsersObjLst.length == 0) {
                var strMsg = `根据条件获取的对象列表数为空！`;
                alert(strMsg);
                return;
            }
            try {
                this.BindTab_QxUsers(strListDiv, arrQxUsersObjLst);
                console.log("完成BindGv_QxUsers!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /* 显示QxUsers对象的所有属性值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
         <param name = "divContainer">显示容器</param>
         <param name = "arrQxUsersObjLst">需要绑定的对象列表</param>
       */
        BindTab_QxUsers(divContainer, arrQxUsersObjLst) {
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
                    FldName: "card_State",
                    ColHeader: "card_State",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "cardNo",
                    ColHeader: "卡号",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "endYearMonth",
                    ColHeader: "结束年月",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "optUser",
                    ColHeader: "optUser",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "optDate",
                    ColHeader: "optDate",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "avatarsPicture",
                    ColHeader: "avatarsPicture",
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
                    FldName: "phoneNumber",
                    ColHeader: "phoneNumber",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "effectiveDate",
                    ColHeader: "effectiveDate",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "updDate",
                    ColHeader: "修改日期",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "updUser",
                    ColHeader: "修改人",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "effitiveBeginDate",
                    ColHeader: "effitiveBeginDate",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "effitiveEndDate",
                    ColHeader: "effitiveEndDate",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "id_College",
                    ColHeader: "学院流水号",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "isArchive",
                    ColHeader: "isArchive",
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
                        btn1.className = "btn btn-outline-info";
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
                        btn1.className = "btn btn-outline-info";
                        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
            ];
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindTabV2(o, arrQxUsersObjLst, arrDataColumn, "userId");
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
                const responseText2 = await this.BindGv_QxUsers();
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
                const responseText = await this.DelRecord(strKeyId);
                const responseText2 = await this.BindGv_QxUsers();
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
        /* 根据条件获取相应的记录对象的列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnExportExcel_Click)
       */
        async btnExportExcel_Click() {
            var strWhereCond = " 1=1 ";
            try {
                const responseText = await (0, clsQxUsersWApi_js_1.QxUsers_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    var arrQxUsersObjLst = jsonData;
                    this.BindTab_QxUsers(this.mstrListDiv, arrQxUsersObjLst);
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
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
                        const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                            var returnBool = jsonData;
                            if (returnBool == true) {
                                HideDialog();
                                this.BindGv_QxUsers();
                            }
                        });
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                            var returnBool = jsonData;
                            if (returnBool == true) {
                                HideDialog();
                                this.BindGv_QxUsers();
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
        /* 根据条件获取相应的记录对象的列表
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
       */
        async btnQuery_Click(strListDiv) {
            var strWhereCond = this.CombineQxUsersCondition();
            try {
                const responseRecCount = await (0, clsQxUsersWApi_js_1.QxUsers_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                var objPagerPara = {
                    pageIndex: 1,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortQxUsersBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsQxUsersWApi_js_1.QxUsers_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    var arrQxUsersObjLst = jsonData;
                    this.BindTab_QxUsers(this.mstrListDiv, arrQxUsersObjLst);
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
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
            $('#ddlDepartmentId option[0]').attr("selected", true);
            $('#ddlid_XzCollege option[0]').attr("selected", true);
            this.userStateId = "";
            $('#ddlid_GradeBase option[0]').attr("selected", true);
            this.card_State = "";
            this.isLeaved = false;
            this.cardNo = "";
            this.beginYearMonth = "";
            this.endYearMonth = "";
            this.optUser = "";
            this.optDate = "";
            this.memo = "";
            this.password = "";
            this.isGpUser = false;
            this.schoolID1 = "";
            this.avatarsPicture = "";
            this.email = "";
            this.phoneNumber = "";
            this.effectiveDate = "";
            this.updDate = "";
            this.updUser = "";
            this.effitiveBeginDate = "";
            this.effitiveEndDate = "";
            this.id_College = "";
            this.stuTeacherID = "";
            $('#ddlIdentityID option[0]').attr("selected", true);
            this.isArchive = false;
        }
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
         <returns>条件串(strWhereCond)</returns>
       */
        CombineQxUsersCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.UserId_q != "") {
                    strWhereCond += ` And ${clsQxUsersEN_js_1.clsQxUsersEN.con_UserId} like '% ${this.UserId_q}%'`;
                }
                if (this.UserName_q != "") {
                    strWhereCond += ` And ${clsQxUsersEN_js_1.clsQxUsersEN.con_UserName} like '% ${this.UserName_q}%'`;
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineQxUsersCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        ///// <summary>
        ///// 为下拉框获取数据,从表:[DepartmentInfo]中获取
        ///// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
        ///// </summary>
        ///// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
        //public BindDdl_DepartmentId(ddlDepartmentId: string, strWhereCond: string = "1 =1") {
        //    //var strWhereCond = " 1 =1 ";
        //    var objDdl = document.getElementById(ddlDepartmentId);
        //    if (objDdl == null) {
        //        var strMsg = `下拉框：${ddlDepartmentId} 不存在！`;
        //        alert(strMsg);
        //        throw (strMsg);
        //    }
        //    return new Promise((resolve, reject) => {
        //        try {
        //            const responseText = DepartmentInfo_GetObjLstAsync(strWhereCond).then((jsonData) => {
        //                var arrDepartmentInfoObjLst: Array<clsDepartmentInfoEN> = <Array<clsDepartmentInfoEN>>jsonData;
        //                clsCommonFunc4Web.BindDdl_ObjLst(ddlDepartmentId, arrDepartmentInfoObjLst, clsDepartmentInfoEN.con_DepartmentId, clsDepartmentInfoEN.con_DepartmentName, "DepartmentInfo");
        //                console.log("完成BindDdl_DepartmentId!");
        //                resolve(jsonData);
        //            });
        //        }
        //        catch (e) {
        //            var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
        //            alert(strMsg);
        //        }
        //    });
        //}
        /// <summary>
        /// 为下拉框获取数据,从表:[XzClg]中获取
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
        BindDdl_id_XzCollege(ddlid_XzCollege, strWhereCond = "1 =1") {
            //var strWhereCond = " 1 =1 ";
            var objDdl = document.getElementById(ddlid_XzCollege);
            if (objDdl == null) {
                var strMsg = `下拉框：${ddlid_XzCollege} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsXzClgWApi_js_1.XzClg_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                        var arrXzClgObjLst = jsonData;
                        clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindDdl_ObjLst(ddlid_XzCollege, arrXzClgObjLst, clsXzClgEN_js_1.clsXzClgEN.con_id_XzCollege, clsXzClgEN_js_1.clsXzClgEN.con_CollegeName, "学院表");
                        console.log("完成BindDdl_id_XzCollege!");
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                    alert(strMsg);
                }
            });
        }
        /// <summary>
        /// 为下拉框获取数据,从表:[XzGradeBase]中获取
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
        BindDdl_id_GradeBase(ddlid_GradeBase, strWhereCond = "1 =1") {
            //var strWhereCond = " 1 =1 ";
            var objDdl = document.getElementById(ddlid_GradeBase);
            if (objDdl == null) {
                var strMsg = `下拉框：${ddlid_GradeBase} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsXzGradeBaseWApi_js_1.XzGradeBase_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                        var arrXzGradeBaseObjLst = jsonData;
                        clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindDdl_ObjLst(ddlid_GradeBase, arrXzGradeBaseObjLst, clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_id_GradeBase, clsXzGradeBaseEN_js_1.clsXzGradeBaseEN.con_GradeBaseName, "年级");
                        console.log("完成BindDdl_id_GradeBase!");
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                    alert(strMsg);
                }
            });
        }
        /// <summary>
        /// 为下拉框获取数据,从表:[UserIdentity]中获取
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DdlBind)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
        BindDdl_IdentityID(ddlIdentityID, strWhereCond = "1 =1") {
            //var strWhereCond = " 1 =1 ";
            var objDdl = document.getElementById(ddlIdentityID);
            if (objDdl == null) {
                var strMsg = `下拉框：${ddlIdentityID} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsUserIdentityWApi_js_1.UserIdentity_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                        var arrUserIdentityObjLst = jsonData;
                        clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindDdl_ObjLst(ddlIdentityID, arrUserIdentityObjLst, clsUserIdentityEN_js_1.clsUserIdentityEN.con_IdentityID, clsUserIdentityEN_js_1.clsUserIdentityEN.con_IdentityDesc, "用户身份");
                        console.log("完成BindDdl_IdentityID!");
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                    alert(strMsg);
                }
            });
        }
        /* 根据关键字列表删除记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelMultiRecord)
       */
        DelMultiRecord(arrUserId) {
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsQxUsersWApi_js_1.QxUsers_DelQxUserssAsync)(arrUserId).then((jsonData) => {
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
                    const responseText = (0, clsQxUsersWApi_js_1.QxUsers_DelRecordAsync)(strUserId).then((jsonData) => {
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
                    const responseText = (0, clsQxUsersWApi_js_1.QxUsers_GetObjByUserIdAsync)(strUserId).then((jsonData) => {
                        var objQxUsersEN = jsonData;
                        this.GetDataFromQxUsersClass(objQxUsersEN);
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
         <param name = "pobjQxUsersEN">表实体类对象</param>
       */
        GetDataFromQxUsersClass(pobjQxUsersEN) {
            this.userId = pobjQxUsersEN.userId; // 用户ID
            this.userName = pobjQxUsersEN.userName; // 用户名
            this.departmentId = pobjQxUsersEN.departmentId; // 部门Id
            this.id_XzCollege = pobjQxUsersEN.id_XzCollege; // 学院流水号
            this.userStateId = pobjQxUsersEN.userStateId; // 用户状态Id
            this.id_GradeBase = pobjQxUsersEN.id_GradeBase; // 年级流水号
            this.card_State = pobjQxUsersEN.card_State; // card_State
            this.isLeaved = pobjQxUsersEN.isLeaved; // isLeaved
            this.cardNo = pobjQxUsersEN.cardNo; // 卡号
            this.beginYearMonth = pobjQxUsersEN.beginYearMonth; // 开始年月
            this.endYearMonth = pobjQxUsersEN.endYearMonth; // 结束年月
            this.optUser = pobjQxUsersEN.optUser; // optUser
            this.optDate = pobjQxUsersEN.optDate; // optDate
            this.memo = pobjQxUsersEN.memo; // 备注
            this.password = pobjQxUsersEN.password; // password
            this.isGpUser = pobjQxUsersEN.isGpUser; // 是否Gp用户
            this.schoolID1 = pobjQxUsersEN.schoolID1; // 学校编号
            this.avatarsPicture = pobjQxUsersEN.avatarsPicture; // avatarsPicture
            this.email = pobjQxUsersEN.email; // 电子邮箱
            this.phoneNumber = pobjQxUsersEN.phoneNumber; // phoneNumber
            this.effectiveDate = pobjQxUsersEN.effectiveDate; // effectiveDate
            this.updDate = pobjQxUsersEN.updDate; // 修改日期
            this.updUser = pobjQxUsersEN.updUser; // 修改人
            this.effitiveBeginDate = pobjQxUsersEN.effitiveBeginDate; // effitiveBeginDate
            this.effitiveEndDate = pobjQxUsersEN.effitiveEndDate; // effitiveEndDate
            this.id_College = pobjQxUsersEN.id_College; // 学院流水号
            this.stuTeacherID = pobjQxUsersEN.stuTeacherID; // 学工号
            this.identityID = pobjQxUsersEN.identityID; // 身份编号
            this.isArchive = pobjQxUsersEN.isArchive; // isArchive
        }
        /* 函数功能:从界面列表中获取第一个关键字的值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
         <param name = "pobjQxUsersEN">表实体类对象</param>
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
                    error: (e) => {
                        var strErrMsg = decodeURIComponent(e.responseText);
                        reject(e);
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
            this.BindGv_QxUsers();
        }
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
       */
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                //1、为下拉框设置数据源,绑定列表数据
                //const ddl_DepartmentId = await this.BindDdl_DepartmentId("ddlDepartmentId");
                const ddl_id_XzCollege = await this.BindDdl_id_XzCollege("ddlid_XzCollege");
                const ddl_id_GradeBase = await this.BindDdl_id_GradeBase("ddlid_GradeBase");
                const ddl_IdentityID = await this.BindDdl_IdentityID("ddlIdentityID");
                this.hidSortQxUsersBy = "userId Asc";
                var strWhereCond = this.CombineQxUsersCondition();
                const responseText = await (0, clsQxUsersWApi_js_1.QxUsers_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_QxUsers();
            }
            catch (e) {
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 函数功能:把界面上的属性数据传到类对象中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
         <param name = "pobjQxUsersEN">数据传输的目的类对象</param>
       */
        PutDataToQxUsersClass(pobjQxUsersEN) {
            pobjQxUsersEN.userId = this.userId; // 用户ID
            pobjQxUsersEN.userName = this.userName; // 用户名
            pobjQxUsersEN.departmentId = this.departmentId; // 部门Id
            pobjQxUsersEN.id_XzCollege = this.id_XzCollege; // 学院流水号
            pobjQxUsersEN.userStateId = this.userStateId; // 用户状态Id
            pobjQxUsersEN.id_GradeBase = this.id_GradeBase; // 年级流水号
            pobjQxUsersEN.card_State = this.card_State; // card_State
            pobjQxUsersEN.isLeaved = this.isLeaved; // isLeaved
            pobjQxUsersEN.cardNo = this.cardNo; // 卡号
            pobjQxUsersEN.beginYearMonth = this.beginYearMonth; // 开始年月
            pobjQxUsersEN.endYearMonth = this.endYearMonth; // 结束年月
            pobjQxUsersEN.optUser = this.optUser; // optUser
            pobjQxUsersEN.optDate = this.optDate; // optDate
            pobjQxUsersEN.memo = this.memo; // 备注
            pobjQxUsersEN.password = this.password; // password
            pobjQxUsersEN.isGpUser = this.isGpUser; // 是否Gp用户
            pobjQxUsersEN.schoolID1 = this.schoolID1; // 学校编号
            pobjQxUsersEN.avatarsPicture = this.avatarsPicture; // avatarsPicture
            pobjQxUsersEN.email = this.email; // 电子邮箱
            pobjQxUsersEN.phoneNumber = this.phoneNumber; // phoneNumber
            pobjQxUsersEN.effectiveDate = this.effectiveDate; // effectiveDate
            pobjQxUsersEN.updDate = this.updDate; // 修改日期
            pobjQxUsersEN.updUser = this.updUser; // 修改人
            pobjQxUsersEN.effitiveBeginDate = this.effitiveBeginDate; // effitiveBeginDate
            pobjQxUsersEN.effitiveEndDate = this.effitiveEndDate; // effitiveEndDate
            pobjQxUsersEN.id_College = this.id_College; // 学院流水号
            pobjQxUsersEN.stuTeacherID = this.stuTeacherID; // 学工号
            pobjQxUsersEN.identityID = this.identityID; // 身份编号
            pobjQxUsersEN.isArchive = this.isArchive; // isArchive
        }
        /* 根据条件获取相应的记录对象的列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_QueryLst)
       */
        QueryQxUsersLst(strListDiv) {
            var strWhereCond = this.CombineQxUsersCondition();
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            return new Promise((resolve, reject) => {
                try {
                    var objPagerPara = {
                        pageIndex: intCurrPageIndex,
                        pageSize: this.pageSize,
                        whereCond: strWhereCond,
                        orderBy: this.hidSortQxUsersBy,
                        sortFun: (x, y) => { return 0; }
                    };
                    const responseText = (0, clsQxUsersWApi_js_1.QxUsers_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                        var arrQxUsersObjLst = jsonData;
                        this.BindTab_QxUsers(strListDiv, arrQxUsersObjLst);
                        console.log("完成QueryQxUsersLst!");
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    console.error('catch(e)=');
                    console.error(e);
                    var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                    alert(strMsg);
                }
            });
        }
        /*
        根据关键字选择相应的记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SelectRecord)
         <param name = "sender">参数列表</param>
       */
        async SelectRecord(strUserId) {
            try {
                const responseText = await (0, clsQxUsersWApi_js_1.QxUsers_GetObjByUserIdAsync)(strUserId);
                var objQxUsersEN = responseText;
                console.log("完成SelectRecord!");
                clsCommonFunc4Web2_js_1.clsCommonFunc4Web.Redirect("/Index/Main_QxUsers");
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
            var objQxUsersEN = new clsQxUsersEN_js_1.clsQxUsersEN();
            try {
                const responseText = await (0, clsQxUsersWApi_js_1.QxUsers_IsExistAsync)(strUserId);
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
                const responseText = await (0, clsQxUsersWApi_js_1.QxUsers_GetObjByUserIdAsync)(strUserId);
                objQxUsersEN = responseText;
            }
            catch (e) {
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
            //3、用提供的关键字初始化一个类对象；
            this.GetDataFromQxUsersClass(objQxUsersEN);
        }
        /* 显示{0}对象的所有属性值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowTabObj)
         <param name = "divContainer">显示容器</param>
         <param name = "objQxUsers">需要显示的对象</param>
       */
        ShowQxUsersObj(divContainer, objQxUsers) {
            var o = document.getElementById(divContainer);
            if (o == null) {
                alert(`${divContainer}不存在！`);
                return;
            }
            var sstrKeys = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetObjKeys(objQxUsers);
            var ul = document.createElement("ul");
            for (let strKey of sstrKeys) {
                var strValue = objQxUsers[strKey];
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
            if (this.hidSortQxUsersBy.indexOf(strSortByFld) >= 0) {
                if (this.hidSortQxUsersBy.indexOf("Asc") >= 0) {
                    this.hidSortQxUsersBy = `${strSortByFld} Desc`;
                }
                else {
                    this.hidSortQxUsersBy = `${strSortByFld} Asc`;
                }
            }
            else {
                this.hidSortQxUsersBy = `${strSortByFld} Asc`;
            }
            const responseText2 = await this.BindGv_QxUsers();
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
                    const responseText = (0, clsQxUsersWApi_js_1.QxUsers_GetObjByUserIdAsync)(strUserId).then((jsonData) => {
                        var objQxUsersEN = jsonData;
                        this.GetDataFromQxUsersClass(objQxUsersEN);
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
            var objQxUsersEN = new clsQxUsersEN_js_1.clsQxUsersEN();
            objQxUsersEN.userId = this.KeyId;
            this.PutDataToQxUsersClass(objQxUsersEN);
            objQxUsersEN.sf_UpdFldSetStr = objQxUsersEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objQxUsersEN.userId == "" || objQxUsersEN.userId == undefined) {
                throw "关键字不能为空!";
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsQxUsersWApi_js_1.QxUsers_UpdateRecordAsync)(objQxUsersEN).then((jsonData) => {
                        var returnBool = jsonData;
                        if (returnBool == true) {
                            var strInfo = `修改记录成功!`;
                            $('#lblResult44').val(strInfo);
                            //显示信息框
                            alert(strInfo);
                        }
                        else {
                            var strInfo = `修改记录不成功!`;
                            $('#lblResult44').val(strInfo);
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
        * avatarsPicture
       */
        set avatarsPicture(value) {
            $("#txtAvatarsPicture").val(value);
        }
        /*
        * avatarsPicture
       */
        get avatarsPicture() {
            return $("#txtAvatarsPicture").val();
        }
        /*
        * 开始年月
       */
        set beginYearMonth(value) {
            $("#txtBeginYearMonth").val(value);
        }
        /*
        * 开始年月
       */
        get beginYearMonth() {
            return $("#txtBeginYearMonth").val();
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
        * card_State
       */
        set card_State(value) {
            $("#txtCard_State").val(value);
        }
        /*
        * card_State
       */
        get card_State() {
            return $("#txtCard_State").val();
        }
        /*
        * 卡号
       */
        set cardNo(value) {
            $("#txtCardNo").val(value);
        }
        /*
        * 卡号
       */
        get cardNo() {
            return $("#txtCardNo").val();
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
        * 部门Id
       */
        set departmentId(value) {
            $("#ddlDepartmentId").val(value);
        }
        /*
        * 部门Id
       */
        get departmentId() {
            return $("#ddlDepartmentId").val();
        }
        /*
        * 添加、修改用的层名
       */
        set DivName(value) {
            $("#hidDivName").val(value);
        }
        /*
        * effectiveDate
       */
        set effectiveDate(value) {
            $("#txtEffectiveDate").val(value);
        }
        /*
        * effectiveDate
       */
        get effectiveDate() {
            return $("#txtEffectiveDate").val();
        }
        /*
        * effitiveBeginDate
       */
        set effitiveBeginDate(value) {
            $("#txtEffitiveBeginDate").val(value);
        }
        /*
        * effitiveBeginDate
       */
        get effitiveBeginDate() {
            return $("#txtEffitiveBeginDate").val();
        }
        /*
        * effitiveEndDate
       */
        set effitiveEndDate(value) {
            $("#txtEffitiveEndDate").val(value);
        }
        /*
        * effitiveEndDate
       */
        get effitiveEndDate() {
            return $("#txtEffitiveEndDate").val();
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
        * 结束年月
       */
        set endYearMonth(value) {
            $("#txtEndYearMonth").val(value);
        }
        /*
        * 结束年月
       */
        get endYearMonth() {
            return $("#txtEndYearMonth").val();
        }
        /*
        * 设置排序字段-相当使用ViewState功能
       */
        set hidSortQxUsersBy(value) {
            $("#hidSortQxUsersBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortQxUsersBy() {
            return $("#hidSortQxUsersBy").val();
        }
        /*
        * 用户Id
       */
        get hidUserId() {
            return $("#hidUserId").val();
        }
        /*
        * 学院流水号
       */
        set id_College(value) {
            $("#txtid_College").val(value);
        }
        /*
        * 学院流水号
       */
        get id_College() {
            return $("#txtid_College").val();
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
        * isArchive
       */
        set isArchive(value) {
            $("#chkIsArchive").val(value);
        }
        /*
        * isArchive
       */
        get isArchive() {
            return $("#chkIsArchive").prop("checked");
        }
        /*
        * 是否Gp用户
       */
        set isGpUser(value) {
            $("#chkIsGpUser").val(value);
        }
        /*
        * 是否Gp用户
       */
        get isGpUser() {
            return $("#chkIsGpUser").prop("checked");
        }
        /*
        * isLeaved
       */
        set isLeaved(value) {
            $("#chkIsLeaved").val(value);
        }
        /*
        * isLeaved
       */
        get isLeaved() {
            return $("#chkIsLeaved").prop("checked");
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
        * optDate
       */
        set optDate(value) {
            $("#txtOptDate").val(value);
        }
        /*
        * optDate
       */
        get optDate() {
            return $("#txtOptDate").val();
        }
        /*
        * optUser
       */
        set optUser(value) {
            $("#txtOptUser").val(value);
        }
        /*
        * optUser
       */
        get optUser() {
            return $("#txtOptUser").val();
        }
        /*
        * 设置操作类型：Add||Update||Detail
       */
        set OpType(value) {
            $("#hidOpType").val(value);
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
        * phoneNumber
       */
        set phoneNumber(value) {
            $("#txtPhoneNumber").val(value);
        }
        /*
        * phoneNumber
       */
        get phoneNumber() {
            return $("#txtPhoneNumber").val();
        }
        /*
        * 学校编号
       */
        set schoolID1(value) {
            $("#txtSchoolID1").val(value);
        }
        /*
        * 学校编号
       */
        get schoolID1() {
            return $("#txtSchoolID1").val();
        }
        /*
        * 学工号
       */
        set stuTeacherID(value) {
            $("#txtStuTeacherID").val(value);
        }
        /*
        * 学工号
       */
        get stuTeacherID() {
            return $("#txtStuTeacherID").val();
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
        * 用户ID
       */
        get UserId_q() {
            return $("#txtUserId_q").val();
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
    exports.QxUsers_QUDI_TS = QxUsers_QUDI_TS;
});
