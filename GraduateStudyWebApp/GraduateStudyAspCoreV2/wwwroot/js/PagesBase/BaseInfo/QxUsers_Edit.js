(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../TS/L3_ForWApi/UserManage/clsQxDepartmentInfoWApi.js", "../../TS/L3_ForWApi/BaseInfo/clsXzClgWApi.js", "../../TS/L3_ForWApi/SysPara/clsXzGradeBaseWApi.js", "../../TS/L3_ForWApi/UserManage/clsUserIdentityWApi.js", "../../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js", "../../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js", "../../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js", "../../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js", "../../TS/L0_Entity/BaseInfo/clsQxUsersEN.js", "../../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js", "../../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js", "../../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js", "../../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js", "../../TS/PubFun/clsCommFunc4Ctrl.js", "../../TS/PubFun/clsString.js", "../../TS/PubFun/clsDateTime.js", "../../TS/L0_Entity/PrjMenu/clsPageDispModeEN.js", "../../TS/PubFun/clsPublocalStorage.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.QxUsers_Edit = void 0;
    /**
    * 类名:QxUsers_Edit(界面:QxUsersCRUD)
    * 表名:QxUsers(01120258)
    * 版本:2023.01.12.1(服务器:WIN-SRV103-116)
    * 日期:2023/01/12 16:40:38
    * 生成者:
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:基本信息维护(BaseInfo)
    * 框架-层名:WA_编辑区后台_TS(TS)(WA_ViewScript_EditCS_TS)
    * 编程语言:TypeScript
    **/
    //import $ from "jquery";
    const clsQxDepartmentInfoWApi_js_1 = require("../../TS/L3_ForWApi/UserManage/clsQxDepartmentInfoWApi.js");
    const clsXzClgWApi_js_1 = require("../../TS/L3_ForWApi/BaseInfo/clsXzClgWApi.js");
    const clsXzGradeBaseWApi_js_1 = require("../../TS/L3_ForWApi/SysPara/clsXzGradeBaseWApi.js");
    const clsUserIdentityWApi_js_1 = require("../../TS/L3_ForWApi/UserManage/clsUserIdentityWApi.js");
    const clsQxUsersWApi_js_1 = require("../../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js");
    const clsQxUsersWApi_js_2 = require("../../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js");
    const clsQxUsersWApi_js_3 = require("../../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js");
    const clsQxUsersWApi_js_4 = require("../../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js");
    const clsQxUsersEN_js_1 = require("../../TS/L0_Entity/BaseInfo/clsQxUsersEN.js");
    const clsQxUsersWApi_js_5 = require("../../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js");
    const clsQxUsersWApi_js_6 = require("../../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js");
    const clsQxUsersWApi_js_7 = require("../../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js");
    const clsQxUsersWApi_js_8 = require("../../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js");
    const clsCommFunc4Ctrl_js_1 = require("../../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsString_js_1 = require("../../TS/PubFun/clsString.js");
    const clsDateTime_js_1 = require("../../TS/PubFun/clsDateTime.js");
    const clsPageDispModeEN_js_1 = require("../../TS/L0_Entity/PrjMenu/clsPageDispModeEN.js");
    const clsPublocalStorage_js_1 = require("../../TS/PubFun/clsPublocalStorage.js");
    /** QxUsers_Edit 的摘要说明。其中Q代表查询,U代表修改
    * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:GeneCode)
    **/
    class QxUsers_Edit {
        constructor(objShowList) {
            this.opType = "";
            this.keyId = "";
            this.bolIsLoadEditRegion = false; //记录是否导入编辑区的变量
            this.divName4Edit = "divEdit"; //编辑区的Id
            this.iShowList = objShowList;
            QxUsers_Edit.objPage_Edit = this;
            this.objQxUsers = new clsQxUsersEN_js_1.clsQxUsersEN();
        }
        /**
        * 在当前界面中，导入编辑区域
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Edit)
        * @returns
        **/
        async AddDPV_Edit(divName4Edit) {
            const strThisFuncName = this.AddDPV_Edit.name;
            (0, clsCommFunc4Ctrl_js_1.CheckDivExist)(divName4Edit);
            const strUrl = "../BaseInfo/QxUsers_Edit";
            //console.log("divName4Edit:(In AddDPV_Edit)" + divName4Edit);
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl,
                    method: "GET",
                    dataType: "html",
                    data: {},
                    success: function (data) {
                        console.log("已经成功获取页面:" + strUrl + "  字节数: " + data.length.toString());
                        $('#' + divName4Edit).html(data);
                        resolve(true);
                        //setTimeout(() => { clsEditObj.BindTab(); }, 100);
                        //clsEditObj.BindTab();
                    },
                    error: (e) => {
                        console.error(e);
                        reject(e);
                    }
                });
            });
        }
        /** 函数功能:页面导入,当页面开始运行时所发生的事件
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
        **/
        async Page_Load() {
            const strThisFuncName = this.Page_Load.name;
            // 在此处放置用户代码以初始化页面
            try {
                this.SetEventFunc();
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("页面启动不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /** 函数功能:设置事件函数
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_SetEventFunc)
        **/
        async SetEventFunc() {
            const strThisFuncName = this.SetEventFunc.name;
            // 在此处放置用户代码以初始化页面
            try {
                //没有定义相关事件
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("设置事件函数不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /**
        * 显示对话框
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_TS_ShowDialog)
        **/
        ShowDialog_QxUsers(strOp) {
            const strThisFuncName = this.ShowDialog_QxUsers.name;
            //检查相关控件是否存在
            (0, clsCommFunc4Ctrl_js_1.CheckControlExist)(this.divName4Edit, "div", "divEditDialog_QxUsers");
            (0, clsCommFunc4Ctrl_js_1.CheckControlExist)(this.divName4Edit, "h4", "lblDialogTitle_QxUsers");
            if (strOp === "Add" || strOp === "AddWithMaxId") {
                $('#lblDialogTitle_QxUsers').html('添加记录');
                //QxUsers_EditEx.GetMaxStrId('#txtUserId');
            }
            else if (strOp === "Update") {
                $('#lblDialogTitle_QxUsers').html('修改记录');
            }
            else if (strOp === "Detail") {
                $('#btnSubmit_QxUsers').hide();
                $('#lblDialogTitle_QxUsers').html('详细信息');
            }
            ShowDialog('#divEditDialog_QxUsers');
        }
        /**
        * 隐藏对话框
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_TS_HideDialog)
        **/
        HideDialog_QxUsers() {
            const strThisFuncName = this.HideDialog_QxUsers.name;
            (0, clsCommFunc4Ctrl_js_1.CheckControlExist)(this.divName4Edit, "div", "divEditDialog_QxUsers");
            HideDialog('#divEditDialog_QxUsers');
        }
        /** 添加新记录
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
        **/
        async btnAddNewRecord_Click() {
            const strThisFuncName = this.btnAddNewRecord_Click.name;
            try {
                if (this.bolIsLoadEditRegion == false) //
                 {
                    const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                    this.opType = "Add";
                    // 为编辑区绑定下拉框
                    const conBindDdl = await this.BindDdl4EditRegionInDiv();
                    this.SetEventFunc();
                    this.bolIsLoadEditRegion = true; //
                    this.btnSubmit_QxUsers = "确认添加";
                    this.btnCancel_QxUsers = "取消添加";
                    const responseText = this.AddNewRecord();
                    if (QxUsers_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_QxUsers('Add');
                    }
                }
                else {
                    this.opType = "Add";
                    this.btnSubmit_QxUsers = "确认添加";
                    this.btnCancel_QxUsers = "取消添加";
                    const responseText = await this.AddNewRecord();
                    if (QxUsers_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_QxUsers('Add');
                    }
                }
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("添加新记录初始化不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /** 添加新记录
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecordWithMaxId_Click)
        **/
        async btnAddNewRecordWithMaxId_Click() {
            const strThisFuncName = this.btnAddNewRecordWithMaxId_Click.name;
            try {
                if (this.bolIsLoadEditRegion == false) //
                 {
                    const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                    this.opType = "AddWithMaxId";
                    // 为编辑区绑定下拉框
                    const conBindDdl = await this.BindDdl4EditRegionInDiv();
                    this.SetEventFunc();
                    this.bolIsLoadEditRegion = true; //
                    this.btnSubmit_QxUsers = "确认添加";
                    this.btnCancel_QxUsers = "取消添加";
                    const responseText = this.AddNewRecordWithMaxId();
                    if (QxUsers_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_QxUsers('Add');
                    }
                }
                else {
                    this.opType = "AddWithMaxId";
                    this.btnSubmit_QxUsers = "确认添加";
                    this.btnCancel_QxUsers = "取消添加";
                    const responseText = this.AddNewRecordWithMaxId();
                    if (QxUsers_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_QxUsers('Add');
                    }
                }
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("添加新记录初始化不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /**
        * 设置绑定下拉框，针对字段:[DepartmentId]
        * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdlInDiv_TS4TabFeature)
        **/
        async SetDdl_DepartmentIdInDiv() {
            await (0, clsQxDepartmentInfoWApi_js_1.QxDepartmentInfo_BindDdl_DepartmentIdInDiv_Cache)(this.divName4Edit, "ddlDepartmentId"); //
        }
        /**
        * 设置绑定下拉框，针对字段:[id_XzCollege]
        * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdlInDiv_TS4TabFeature)
        **/
        async SetDdl_id_XzCollegeInDiv() {
            await (0, clsXzClgWApi_js_1.XzClg_BindDdl_id_XzCollegeInDiv_Cache)(this.divName4Edit, "ddlid_XzCollege"); //
        }
        /**
        * 设置绑定下拉框，针对字段:[id_GradeBase]
        * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdlInDiv_TS4TabFeature)
        **/
        async SetDdl_id_GradeBaseInDiv() {
            await (0, clsXzGradeBaseWApi_js_1.XzGradeBase_BindDdl_id_GradeBaseInDiv_Cache)(this.divName4Edit, "ddlid_GradeBase"); //
        }
        /**
        * 设置绑定下拉框，针对字段:[IdentityID]
        * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdlInDiv_TS4TabFeature)
        **/
        async SetDdl_IdentityIDInDiv() {
            await (0, clsUserIdentityWApi_js_1.UserIdentity_BindDdl_IdentityIDInDiv_Cache)(this.divName4Edit, "ddlIdentityID"); //
        }
        /** 函数功能:为编辑区绑定下拉框
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegionInDiv)
        **/
        async BindDdl4EditRegionInDiv() {
            const strThisFuncName = this.BindDdl4EditRegionInDiv.name;
            // 在此处放置用户代码以初始化页面
            await this.SetDdl_DepartmentIdInDiv(); //编辑区域
            await this.SetDdl_id_XzCollegeInDiv(); //编辑区域
            await this.SetDdl_id_GradeBaseInDiv(); //编辑区域
            await this.SetDdl_IdentityIDInDiv(); //编辑区域
        }
        /** 在数据表里修改记录
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecordInTab_Click)
        **/
        async btnUpdateRecordInTab_Click(strKeyId) {
            const strThisFuncName = this.btnUpdateRecordInTab_Click.name;
            if (strKeyId == "") {
                alert("请选择需要修改的记录！");
                return;
            }
            try {
                if (this.bolIsLoadEditRegion == false) //
                 {
                    const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                    this.opType = "Update";
                    // 为编辑区绑定下拉框
                    const conBindDdl = await this.BindDdl4EditRegionInDiv();
                    this.SetEventFunc();
                    this.bolIsLoadEditRegion = true; //
                    this.btnSubmit_QxUsers = "确认修改";
                    this.btnCancel_QxUsers = "取消修改";
                    this.UpdateRecord(strKeyId);
                    if (QxUsers_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_QxUsers('Update');
                    }
                }
                else {
                    this.opType = "Update";
                    this.btnSubmit_QxUsers = "确认修改";
                    this.btnCancel_QxUsers = "取消修改";
                    this.UpdateRecord(strKeyId);
                    if (QxUsers_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_QxUsers('Update');
                    }
                }
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("(errid: WiTsCs0034)在修改记录时出错!请联系管理员!{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /** 修改记录
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
        **/
        async btnUpdateRecord_Click(strKeyId) {
            const strThisFuncName = this.btnUpdateRecord_Click.name;
            if ((0, clsString_js_1.IsNullOrEmpty)(strKeyId) == true) {
                const strMsg = "修改记录的关键字为空，请检查！";
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            try {
                if (this.bolIsLoadEditRegion == false) //
                 {
                    const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                    this.opType = "Update";
                    // 为编辑区绑定下拉框
                    const conBindDdl = await this.BindDdl4EditRegionInDiv();
                    this.SetEventFunc();
                    this.bolIsLoadEditRegion = true; //
                    this.btnSubmit_QxUsers = "确认修改";
                    this.btnCancel_QxUsers = "取消修改";
                    const update = await this.UpdateRecord(strKeyId);
                    if (update == false) {
                        const strMsg = (0, clsString_js_1.Format)("在修改记录时,显示记录数据不成功!");
                        console.error(strMsg);
                        alert(strMsg);
                        return;
                    }
                    if (QxUsers_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_QxUsers('Update');
                    }
                }
                else {
                    this.opType = "Update";
                    this.btnSubmit_QxUsers = "确认修改";
                    this.btnCancel_QxUsers = "取消修改";
                    const update = await this.UpdateRecord(strKeyId);
                    if (update == false) {
                        const strMsg = (0, clsString_js_1.Format)("在修改记录时,显示记录数据不成功!");
                        console.error(strMsg);
                        alert(strMsg);
                        return;
                    }
                    if (QxUsers_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_QxUsers('Update');
                    }
                }
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("(errid: WiTsCs0034)在修改记录时出错!请联系管理员!{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /** 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
        * 具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
        **/
        async btnSubmit_Click() {
            const strThisFuncName = this.btnSubmit_Click.name;
            const strCommandText = this.btnSubmit_QxUsers;
            try {
                let returnBool = false;
                let returnKeyId = "";
                let strInfo = "";
                let strMsg = "";
                switch (strCommandText) {
                    case "添加":
                        this.btnSubmit_QxUsers = "确认添加";
                        this.btnCancel_QxUsers = "取消添加";
                        await this.AddNewRecord();
                        break;
                    case "确认添加":
                        //这是一个单表的插入的代码,由于逻辑层太简单,
                        //就把逻辑层合并到控制层,
                        if (this.opType == "AddWithMaxId") {
                            returnKeyId = await this.AddNewRecordWithMaxIdSave();
                            if ((0, clsString_js_1.IsNullOrEmpty)(returnKeyId) == false) {
                                if (QxUsers_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                                    this.HideDialog_QxUsers();
                                }
                                this.iShowList.BindGv(clsQxUsersEN_js_1.clsQxUsersEN._CurrTabName, returnKeyId);
                            }
                        }
                        else {
                            returnBool = await this.AddNewRecordSave();
                            if (returnBool == true) {
                                if (QxUsers_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                                    this.HideDialog_QxUsers();
                                }
                                this.iShowList.BindGv(clsQxUsersEN_js_1.clsQxUsersEN._CurrTabName, returnBool.toString());
                            }
                        }
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        returnBool = await this.UpdateRecordSave();
                        strInfo = returnBool ? "修改成功！" : "修改不成功！";
                        strInfo += "(In QxUsers_Edit.btnSubmit_Click)";
                        //显示信息框
                        //console.log(strInfo);
                        alert(strInfo);
                        if (returnBool == true) {
                            if (QxUsers_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                                this.HideDialog_QxUsers();
                            }
                            this.iShowList.BindGv(clsQxUsersEN_js_1.clsQxUsersEN._CurrTabName, returnBool.toString());
                        }
                        break;
                    default:
                        strMsg = (0, clsString_js_1.Format)("strCommandText:{0}在switch中没有处理！(In btnSubmit_Click())", strCommandText);
                        console.error(strMsg);
                        alert(strMsg);
                        break;
                }
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("(errid: WiTsCs0033)在保存记录时({3})时出错!请联系管理员!{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName, strCommandText);
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /**
        *  在用户自定义控件中，设置关键字的值，是否只读
         * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_SetKeyReadOnly)
         * @param bolReadonly:是否只读
         **/
        SetKeyReadOnly(bolReadonly) {
            const strThisFuncName = this.SetKeyReadOnly.name;
            $('#txtUserId').attr('ReadOnly', bolReadonly.toString());
        }
        /**
         * 清除用户自定义控件中，所有控件的值
         * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_Clear)
         **/
        Clear() {
            const strThisFuncName = this.Clear.name;
            this.userId = "";
            this.userName = "";
            $('#ddlDepartmentId option[0]').attr("selected", "true");
            $('#ddlid_XzCollege option[0]').attr("selected", "true");
            this.userStateId = "";
            $('#ddlid_GradeBase option[0]').attr("selected", "true");
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
            $('#ddlIdentityID option[0]').attr("selected", "true");
            this.isArchive = false;
        }
        /** 为插入记录做准备工作
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
        **/
        async AddNewRecord() {
            const strThisFuncName = this.AddNewRecord.name;
            this.Clear();
            //wucQxUsersB1.userId = QxUsers_GetMaxStrId_S();
        }
        /** 为插入记录做准备工作
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxId)
        **/
        AddNewRecordWithMaxId() {
            const strThisFuncName = this.AddNewRecordWithMaxId.name;
            this.SetKeyReadOnly(false);
            this.Clear();
            //wucQxUsersB1.userId = QxUsers_GetMaxStrId_S();
        }
        /** 函数功能:把界面上的属性数据传到类对象中
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
        * @param pobjQxUsersEN">数据传输的目的类对象</param>
        **/
        async PutDataToQxUsersClass(pobjQxUsersEN) {
            const strThisFuncName = this.PutDataToQxUsersClass.name;
            pobjQxUsersEN.SetUserId(this.userId); // 用户ID
            pobjQxUsersEN.SetUserName(this.userName); // 用户名
            pobjQxUsersEN.SetDepartmentId(this.departmentId); // 部门Id
            pobjQxUsersEN.Setid_XzCollege(this.id_XzCollege); // 学院流水号
            pobjQxUsersEN.SetUserStateId(this.userStateId); // 用户状态Id
            pobjQxUsersEN.Setid_GradeBase(this.id_GradeBase); // 年级流水号
            pobjQxUsersEN.SetCard_State(this.card_State); // Card_State
            pobjQxUsersEN.SetIsLeaved(this.isLeaved); // IsLeaved
            pobjQxUsersEN.SetCardNo(this.cardNo); // 卡号
            pobjQxUsersEN.SetBeginYearMonth(this.beginYearMonth); // 开始年月
            pobjQxUsersEN.SetEndYearMonth(this.endYearMonth); // 结束年月
            pobjQxUsersEN.SetOptUser(this.optUser); // OptUser
            pobjQxUsersEN.SetOptDate(this.optDate); // OptDate
            pobjQxUsersEN.SetMemo(this.memo); // 备注
            pobjQxUsersEN.SetPassword(this.password); // Password
            pobjQxUsersEN.SetIsGpUser(this.isGpUser); // 是否Gp用户
            pobjQxUsersEN.SetSchoolID1(this.schoolID1); // 学校编号
            pobjQxUsersEN.SetAvatarsPicture(this.avatarsPicture); // AvatarsPicture
            pobjQxUsersEN.SetEmail(this.email); // 电子邮箱
            pobjQxUsersEN.SetPhoneNumber(this.phoneNumber); // PhoneNumber
            pobjQxUsersEN.SetEffectiveDate(this.effectiveDate); // EffectiveDate
            pobjQxUsersEN.SetUpdDate(clsDateTime_js_1.clsDateTime.getTodayDateTimeStr(1)); // 修改日期
            pobjQxUsersEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改人
            pobjQxUsersEN.SetEffitiveBeginDate(this.effitiveBeginDate); // EffitiveBeginDate
            pobjQxUsersEN.SetEffitiveEndDate(this.effitiveEndDate); // EffitiveEndDate
            pobjQxUsersEN.Setid_College(this.id_College); // 学院流水号
            pobjQxUsersEN.SetStuTeacherID(this.stuTeacherID); // 学工号
            pobjQxUsersEN.SetIdentityID(this.identityID); // 身份编号
            pobjQxUsersEN.SetIsArchive(this.isArchive); // IsArchive
        }
        /** 添加新记录，保存函数
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
        **/
        async AddNewRecordSave() {
            const strThisFuncName = this.AddNewRecordSave.name;
            const objQxUsersEN = new clsQxUsersEN_js_1.clsQxUsersEN();
            try {
                await this.PutDataToQxUsersClass(objQxUsersEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("从界面获取数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                (0, clsQxUsersWApi_js_1.QxUsers_CheckPropertyNew)(objQxUsersEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("检查数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                //检查唯一性条件
                let returnBool = false;
                const bolIsExist = await (0, clsQxUsersWApi_js_2.QxUsers_IsExistAsync)(objQxUsersEN.userId);
                if (bolIsExist == true) {
                    const strMsg = (0, clsString_js_1.Format)("添加记录时，关键字：{0}已经存在！", objQxUsersEN.userId);
                    console.error(strMsg);
                    alert(strMsg);
                    return false; //一定要有一个返回值，否则会出错！
                }
                returnBool = await (0, clsQxUsersWApi_js_3.QxUsers_AddNewRecordAsync)(objQxUsersEN);
                if (returnBool == true) {
                    (0, clsQxUsersWApi_js_4.QxUsers_ReFreshCache)();
                    const strInfo = (0, clsString_js_1.Format)("添加记录成功!");
                    $('#lblResult46').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    const strInfo = (0, clsString_js_1.Format)("添加记录不成功!");
                    $('#lblResult46').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                return returnBool; //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("添加记录不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
        }
        /** 添加新记录，由后台自动获取最大值的关键字。保存函数
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxIdSave)
        **/
        async AddNewRecordWithMaxIdSave() {
            const strThisFuncName = this.AddNewRecordWithMaxIdSave.name;
            const objQxUsersEN = new clsQxUsersEN_js_1.clsQxUsersEN();
            try {
                await this.PutDataToQxUsersClass(objQxUsersEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("从界面获取数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                throw (strMsg); //一定要有一个返回值，否则会出错！
            }
            try {
                (0, clsQxUsersWApi_js_1.QxUsers_CheckPropertyNew)(objQxUsersEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("检查数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                throw (strMsg); //一定要有一个返回值，否则会出错！
            }
            try {
                //检查唯一性条件
                const responseKeyId = await (0, clsQxUsersWApi_js_5.QxUsers_AddNewRecordWithMaxIdAsync)(objQxUsersEN);
                const returnKeyId = responseKeyId;
                if ((0, clsString_js_1.IsNullOrEmpty)(returnKeyId) == false) {
                    (0, clsQxUsersWApi_js_4.QxUsers_ReFreshCache)();
                    const strInfo = (0, clsString_js_1.Format)("添加记录成功!");
                    $('#lblResult47').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    const strInfo = (0, clsString_js_1.Format)("添加记录不成功!");
                    $('#lblResult47').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                return responseKeyId; //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("添加记录不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                throw (strMsg);
            }
            return ""; //一定要有一个返回值，否则会出错！
        }
        /** 函数功能:把以该关键字的记录内容显示在界面上,
       * 在这里是把值传到表控件中
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_ShowData)
        * @param strUserId: 表记录的关键字,显示该表关键字的内容
        **/
        async ShowData(strUserId) {
            const strThisFuncName = this.ShowData.name;
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            let objQxUsersEN = new clsQxUsersEN_js_1.clsQxUsersEN();
            try {
                const returnBool = await (0, clsQxUsersWApi_js_2.QxUsers_IsExistAsync)(strUserId);
                if (returnBool == false) {
                    const strInfo = (0, clsString_js_1.Format)("关键字:[{0}] 的记录不存在!", strUserId);
                    //$('#lblResult1').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("检查相应关键字的记录存在不成功, {0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
            try {
                const objQxUsersEN_Const = await (0, clsQxUsersWApi_js_6.QxUsers_GetObjByUserIdAsync)(strUserId);
                if (objQxUsersEN_Const == null) {
                    const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                    console.error(strMsg);
                    alert(strMsg);
                    return;
                }
                objQxUsersEN = objQxUsersEN_Const;
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
            //3、用提供的关键字初始化一个类对象；
            this.GetDataFromQxUsersClass(objQxUsersEN);
        }
        /** 函数功能:把类对象的属性内容显示到界面上
        * 注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
        * 如果在设置数据库时,就应该一级字段在前,二级字段在后
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
        * @param pobjQxUsersEN">表实体类对象</param>
        **/
        GetDataFromQxUsersClass(pobjQxUsersEN) {
            const strThisFuncName = this.GetDataFromQxUsersClass.name;
            this.userId = pobjQxUsersEN.userId; // 用户ID
            this.userName = pobjQxUsersEN.userName; // 用户名
            this.departmentId = pobjQxUsersEN.departmentId; // 部门Id
            this.id_XzCollege = pobjQxUsersEN.id_XzCollege; // 学院流水号
            this.userStateId = pobjQxUsersEN.userStateId; // 用户状态Id
            this.id_GradeBase = pobjQxUsersEN.id_GradeBase; // 年级流水号
            this.card_State = pobjQxUsersEN.card_State; // Card_State
            this.isLeaved = pobjQxUsersEN.isLeaved; // IsLeaved
            this.cardNo = pobjQxUsersEN.cardNo; // 卡号
            this.beginYearMonth = pobjQxUsersEN.beginYearMonth; // 开始年月
            this.endYearMonth = pobjQxUsersEN.endYearMonth; // 结束年月
            this.optUser = pobjQxUsersEN.optUser; // OptUser
            this.optDate = pobjQxUsersEN.optDate; // OptDate
            this.memo = pobjQxUsersEN.memo; // 备注
            this.password = pobjQxUsersEN.password; // Password
            this.isGpUser = pobjQxUsersEN.isGpUser; // 是否Gp用户
            this.schoolID1 = pobjQxUsersEN.schoolID1; // 学校编号
            this.avatarsPicture = pobjQxUsersEN.avatarsPicture; // AvatarsPicture
            this.email = pobjQxUsersEN.email; // 电子邮箱
            this.phoneNumber = pobjQxUsersEN.phoneNumber; // PhoneNumber
            this.effectiveDate = pobjQxUsersEN.effectiveDate; // EffectiveDate
            this.updDate = pobjQxUsersEN.updDate; // 修改日期
            this.updUser = pobjQxUsersEN.updUser; // 修改人
            this.effitiveBeginDate = pobjQxUsersEN.effitiveBeginDate; // EffitiveBeginDate
            this.effitiveEndDate = pobjQxUsersEN.effitiveEndDate; // EffitiveEndDate
            this.id_College = pobjQxUsersEN.id_College; // 学院流水号
            this.stuTeacherID = pobjQxUsersEN.stuTeacherID; // 学工号
            this.identityID = pobjQxUsersEN.identityID; // 身份编号
            this.isArchive = pobjQxUsersEN.isArchive; // IsArchive
        }
        /** 根据关键字获取相应的记录的对象
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
        * @param sender">参数列表</param>
        **/
        async UpdateRecord(strUserId) {
            const strThisFuncName = this.UpdateRecord.name;
            this.keyId = strUserId;
            try {
                const objQxUsersEN_Const = await (0, clsQxUsersWApi_js_6.QxUsers_GetObjByUserIdAsync)(strUserId);
                if (objQxUsersEN_Const == null) {
                    const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                    console.error(strMsg);
                    alert(strMsg);
                    return false;
                }
                this.objQxUsers = objQxUsersEN_Const;
                const conGetDataFromClass = await this.GetDataFromQxUsersClass(objQxUsersEN_Const);
                console.log("完成UpdateRecord!");
                return true;
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return false;
            }
        }
        /** 修改记录
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
        **/
        async UpdateRecordSave() {
            const strThisFuncName = this.UpdateRecordSave.name;
            const objQxUsersEN = new clsQxUsersEN_js_1.clsQxUsersEN();
            objQxUsersEN.SetUserId(this.keyId);
            await this.PutDataToQxUsersClass(objQxUsersEN);
            objQxUsersEN.sf_UpdFldSetStr = objQxUsersEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objQxUsersEN.userId == "" || objQxUsersEN.userId == undefined) {
                console.error("关键字不能为空!");
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            try {
                (0, clsQxUsersWApi_js_7.QxUsers_CheckProperty4Update)(objQxUsersEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("检查数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                //检查唯一性条件
                const returnBool = await (0, clsQxUsersWApi_js_8.QxUsers_UpdateRecordAsync)(objQxUsersEN);
                if (returnBool == true) {
                    (0, clsQxUsersWApi_js_4.QxUsers_ReFreshCache)();
                }
                return returnBool;
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("修改记录不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return false;
            }
        }
        /**
        * AvatarsPicture (Used In Clear())
        **/
        set avatarsPicture(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtAvatarsPicture", value);
        }
        /**
        * AvatarsPicture (Used In PutDataToClass())
        **/
        get avatarsPicture() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtAvatarsPicture");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 开始年月 (Used In Clear())
        **/
        set beginYearMonth(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtBeginYearMonth", value);
        }
        /**
        * 开始年月 (Used In PutDataToClass())
        **/
        get beginYearMonth() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtBeginYearMonth");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 设置取消按钮的标题(Used In AddNewRecord())
        **/
        set btnCancel_QxUsers(value) {
            (0, clsCommFunc4Ctrl_js_1.SetButtonHtmlByIdInDiv)(this.divName4Edit, "btnCancel_QxUsers", value);
        }
        /**
        * 获取按钮的标题
        **/
        get btnSubmit_QxUsers() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetButtonHtmlInDiv)(this.divName4Edit, "btnSubmit_QxUsers");
            return strValue;
        }
        /**
        * 设置确定按钮的标题(Used In AddNewRecord())
        **/
        set btnSubmit_QxUsers(value) {
            (0, clsCommFunc4Ctrl_js_1.SetButtonHtmlByIdInDiv)(this.divName4Edit, "btnSubmit_QxUsers", value);
        }
        /**
        * Card_State (Used In Clear())
        **/
        set card_State(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtCard_State", value);
        }
        /**
        * Card_State (Used In PutDataToClass())
        **/
        get card_State() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtCard_State");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 卡号 (Used In Clear())
        **/
        set cardNo(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtCardNo", value);
        }
        /**
        * 卡号 (Used In PutDataToClass())
        **/
        get cardNo() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtCardNo");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 部门Id (Used In Clear())
        **/
        set departmentId(value) {
            (0, clsCommFunc4Ctrl_js_1.SetSelectValueByIdInDiv)(this.divName4Edit, "ddlDepartmentId", value);
        }
        /**
        * 部门Id (Used In PutDataToClass())
        **/
        get departmentId() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetSelectValueInDiv)(this.divName4Edit, "ddlDepartmentId");
            if (strValue == undefined)
                return "";
            else if (strValue == "0")
                return "";
            else
                return strValue;
        }
        /**
        * EffectiveDate (Used In Clear())
        **/
        set effectiveDate(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtEffectiveDate", value);
        }
        /**
        * EffectiveDate (Used In PutDataToClass())
        **/
        get effectiveDate() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtEffectiveDate");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * EffitiveBeginDate (Used In Clear())
        **/
        set effitiveBeginDate(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtEffitiveBeginDate", value);
        }
        /**
        * EffitiveBeginDate (Used In PutDataToClass())
        **/
        get effitiveBeginDate() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtEffitiveBeginDate");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * EffitiveEndDate (Used In Clear())
        **/
        set effitiveEndDate(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtEffitiveEndDate", value);
        }
        /**
        * EffitiveEndDate (Used In PutDataToClass())
        **/
        get effitiveEndDate() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtEffitiveEndDate");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 电子邮箱 (Used In Clear())
        **/
        set email(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtEmail", value);
        }
        /**
        * 电子邮箱 (Used In PutDataToClass())
        **/
        get email() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtEmail");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 结束年月 (Used In Clear())
        **/
        set endYearMonth(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtEndYearMonth", value);
        }
        /**
        * 结束年月 (Used In PutDataToClass())
        **/
        get endYearMonth() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtEndYearMonth");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 学院流水号 (Used In Clear())
        **/
        set id_College(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtid_College", value);
        }
        /**
        * 学院流水号 (Used In PutDataToClass())
        **/
        get id_College() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtid_College");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 年级流水号 (Used In Clear())
        **/
        set id_GradeBase(value) {
            (0, clsCommFunc4Ctrl_js_1.SetSelectValueByIdInDiv)(this.divName4Edit, "ddlid_GradeBase", value);
        }
        /**
        * 年级流水号 (Used In PutDataToClass())
        **/
        get id_GradeBase() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetSelectValueInDiv)(this.divName4Edit, "ddlid_GradeBase");
            if (strValue == undefined)
                return "";
            else if (strValue == "0")
                return "";
            else
                return strValue;
        }
        /**
        * 学院流水号 (Used In Clear())
        **/
        set id_XzCollege(value) {
            (0, clsCommFunc4Ctrl_js_1.SetSelectValueByIdInDiv)(this.divName4Edit, "ddlid_XzCollege", value);
        }
        /**
        * 学院流水号 (Used In PutDataToClass())
        **/
        get id_XzCollege() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetSelectValueInDiv)(this.divName4Edit, "ddlid_XzCollege");
            if (strValue == undefined)
                return "";
            else if (strValue == "0")
                return "";
            else
                return strValue;
        }
        /**
        * 身份编号 (Used In Clear())
        **/
        set identityID(value) {
            (0, clsCommFunc4Ctrl_js_1.SetSelectValueByIdInDiv)(this.divName4Edit, "ddlIdentityID", value);
        }
        /**
        * 身份编号 (Used In PutDataToClass())
        **/
        get identityID() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetSelectValueInDiv)(this.divName4Edit, "ddlIdentityID");
            if (strValue == undefined)
                return "";
            else if (strValue == "0")
                return "";
            else
                return strValue;
        }
        /**
        * IsArchive (Used In Clear())
        **/
        set isArchive(value) {
            (0, clsCommFunc4Ctrl_js_1.SetCheckBoxValueByIdInDiv)(this.divName4Edit, "chkIsArchive", value);
        }
        /**
        * IsArchive (Used In PutDataToClass())
        **/
        get isArchive() {
            const bolValue = (0, clsCommFunc4Ctrl_js_1.GetCheckBoxValueInDiv)(this.divName4Edit, "chkIsArchive");
            return bolValue;
        }
        /**
        * 是否Gp用户 (Used In Clear())
        **/
        set isGpUser(value) {
            (0, clsCommFunc4Ctrl_js_1.SetCheckBoxValueByIdInDiv)(this.divName4Edit, "chkIsGpUser", value);
        }
        /**
        * 是否Gp用户 (Used In PutDataToClass())
        **/
        get isGpUser() {
            const bolValue = (0, clsCommFunc4Ctrl_js_1.GetCheckBoxValueInDiv)(this.divName4Edit, "chkIsGpUser");
            return bolValue;
        }
        /**
        * IsLeaved (Used In Clear())
        **/
        set isLeaved(value) {
            (0, clsCommFunc4Ctrl_js_1.SetCheckBoxValueByIdInDiv)(this.divName4Edit, "chkIsLeaved", value);
        }
        /**
        * IsLeaved (Used In PutDataToClass())
        **/
        get isLeaved() {
            const bolValue = (0, clsCommFunc4Ctrl_js_1.GetCheckBoxValueInDiv)(this.divName4Edit, "chkIsLeaved");
            return bolValue;
        }
        /**
        * 备注 (Used In Clear())
        **/
        set memo(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtMemo", value);
        }
        /**
        * 备注 (Used In PutDataToClass())
        **/
        get memo() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtMemo");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * OptDate (Used In Clear())
        **/
        set optDate(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtOptDate", value);
        }
        /**
        * OptDate (Used In PutDataToClass())
        **/
        get optDate() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtOptDate");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * OptUser (Used In Clear())
        **/
        set optUser(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtOptUser", value);
        }
        /**
        * OptUser (Used In PutDataToClass())
        **/
        get optUser() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtOptUser");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * Password (Used In Clear())
        **/
        set password(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtPassword", value);
        }
        /**
        * Password (Used In PutDataToClass())
        **/
        get password() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtPassword");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * PhoneNumber (Used In Clear())
        **/
        set phoneNumber(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtPhoneNumber", value);
        }
        /**
        * PhoneNumber (Used In PutDataToClass())
        **/
        get phoneNumber() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtPhoneNumber");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 学校编号 (Used In Clear())
        **/
        set schoolID1(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtSchoolID1", value);
        }
        /**
        * 学校编号 (Used In PutDataToClass())
        **/
        get schoolID1() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtSchoolID1");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 学工号 (Used In Clear())
        **/
        set stuTeacherID(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtStuTeacherID", value);
        }
        /**
        * 学工号 (Used In PutDataToClass())
        **/
        get stuTeacherID() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtStuTeacherID");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 修改日期 (Used In Clear())
        **/
        set updDate(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtUpdDate", value);
        }
        /**
        * 修改日期 (Used In PutDataToClass())
        **/
        get updDate() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtUpdDate");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 修改人 (Used In Clear())
        **/
        set updUser(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtUpdUser", value);
        }
        /**
        * 修改人 (Used In PutDataToClass())
        **/
        get updUser() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtUpdUser");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 用户ID (Used In Clear())
        **/
        set userId(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtUserId", value);
        }
        /**
        * 用户ID (Used In PutDataToClass())
        **/
        get userId() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtUserId");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 用户名 (Used In Clear())
        **/
        set userName(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtUserName", value);
        }
        /**
        * 用户名 (Used In PutDataToClass())
        **/
        get userName() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtUserName");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 用户状态Id (Used In Clear())
        **/
        set userStateId(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtUserStateId", value);
        }
        /**
        * 用户状态Id (Used In PutDataToClass())
        **/
        get userStateId() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtUserStateId");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
    }
    exports.QxUsers_Edit = QxUsers_Edit;
    QxUsers_Edit.strPageDispModeId = "01"; //PopupBox(弹出框)
});
