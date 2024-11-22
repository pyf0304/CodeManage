(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../TS/PubFun/clsCommFunc4Ctrl.js", "../../TS/PubFun/clsCommFunc4Ctrl.js", "../../TS/L3_ForWApi/SysPara/clsXzGradeBaseWApi.js", "../../TS/L3_ForWApi/BaseInfo_Share/clsXzClgWApi.js", "../../TS/L3_ForWApi/BaseInfo_Share/clsXzMajorWApi.js", "../../TS/L3_ForWApi/UserManage_Share/clsUserIdentityWApi.js", "../../TS/PubFun/clsPublocalStorage.js", "../../TS/L3_ForWApi/UserManage_Share/clsUsersWApi.js", "../../TS/L3_ForWApi/UserManage_Share/clsUsersWApi.js", "../../TS/L3_ForWApi/UserManage_Share/clsUsersWApi.js", "../../TS/L3_ForWApi/UserManage_Share/clsUsersWApi.js", "../../TS/L0_Entity/UserManage_Share/clsUsersEN.js", "../../TS/L3_ForWApi/UserManage_Share/clsUsersWApi.js", "../../TS/L3_ForWApi/UserManage_Share/clsUsersWApi.js", "../../TS/L3_ForWApi/UserManage_Share/clsUsersWApi.js", "../../TS/L3_ForWApi/UserManage_Share/clsUsersWApi.js", "../../TS/PubFun/clsCommFunc4Ctrl.js", "../../TS/PubFun/clsString.js", "../../TS/PubFun/clsDateTime.js", "../../TS/L0_Entity/PrjMenu/clsPageDispModeEN.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.Users_Edit3 = void 0;
    /**
    * 类名:Users_Edit3(界面:UsersCRUD)
    * 表名:Users(01120034)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 01:05:50
    * 生成者:
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:用户管理(UserManage)
    * 框架-层名:WA_编辑区后台_TS(TS)(WA_ViewScript_EditCS_TS)
    * 编程语言:TypeScript
    **/
    //import $ from "jquery";
    const clsCommFunc4Ctrl_js_1 = require("../../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsCommFunc4Ctrl_js_2 = require("../../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsXzGradeBaseWApi_js_1 = require("../../TS/L3_ForWApi/SysPara/clsXzGradeBaseWApi.js");
    const clsXzClgWApi_js_1 = require("../../TS/L3_ForWApi/BaseInfo_Share/clsXzClgWApi.js");
    const clsXzMajorWApi_js_1 = require("../../TS/L3_ForWApi/BaseInfo_Share/clsXzMajorWApi.js");
    const clsUserIdentityWApi_js_1 = require("../../TS/L3_ForWApi/UserManage_Share/clsUserIdentityWApi.js");
    const clsPublocalStorage_js_1 = require("../../TS/PubFun/clsPublocalStorage.js");
    const clsUsersWApi_js_1 = require("../../TS/L3_ForWApi/UserManage_Share/clsUsersWApi.js");
    const clsUsersWApi_js_2 = require("../../TS/L3_ForWApi/UserManage_Share/clsUsersWApi.js");
    const clsUsersWApi_js_3 = require("../../TS/L3_ForWApi/UserManage_Share/clsUsersWApi.js");
    const clsUsersWApi_js_4 = require("../../TS/L3_ForWApi/UserManage_Share/clsUsersWApi.js");
    const clsUsersEN_js_1 = require("../../TS/L0_Entity/UserManage_Share/clsUsersEN.js");
    const clsUsersWApi_js_5 = require("../../TS/L3_ForWApi/UserManage_Share/clsUsersWApi.js");
    const clsUsersWApi_js_6 = require("../../TS/L3_ForWApi/UserManage_Share/clsUsersWApi.js");
    const clsUsersWApi_js_7 = require("../../TS/L3_ForWApi/UserManage_Share/clsUsersWApi.js");
    const clsUsersWApi_js_8 = require("../../TS/L3_ForWApi/UserManage_Share/clsUsersWApi.js");
    const clsCommFunc4Ctrl_js_3 = require("../../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsString_js_1 = require("../../TS/PubFun/clsString.js");
    const clsDateTime_js_1 = require("../../TS/PubFun/clsDateTime.js");
    const clsPageDispModeEN_js_1 = require("../../TS/L0_Entity/PrjMenu/clsPageDispModeEN.js");
    /** Users_Edit3 的摘要说明。其中Q代表查询,U代表修改
    * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:GeneCode)
    **/
    class Users_Edit3 {
        constructor(objShowList) {
            this.opType = "";
            this.keyId = "";
            this.bolIsLoadEditRegion = false; //记录是否导入编辑区的变量
            this.divName4Edit = "divEdit"; //编辑区的Id
            this.iShowList = objShowList;
            Users_Edit3.objPage_Edit = this;
            this.objUsers = new clsUsersEN_js_1.clsUsersEN();
        }
        /**
        * 在当前界面中，导入编辑区域
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Edit)
        * @returns
        **/
        async AddDPV_Edit(divName4Edit) {
            const strThisFuncName = this.AddDPV_Edit.name;
            (0, clsCommFunc4Ctrl_js_3.CheckDivExist)(divName4Edit);
            const strUrl = "../UserManage_Share/Users_Edit3";
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
        ShowDialog_Users(strOp) {
            const strThisFuncName = this.ShowDialog_Users.name;
            //检查相关控件是否存在
            (0, clsCommFunc4Ctrl_js_3.CheckControlExist)(this.divName4Edit, "div", "divEditDialog_Users");
            (0, clsCommFunc4Ctrl_js_3.CheckControlExist)(this.divName4Edit, "h4", "lblDialogTitle_Users");
            if (strOp === "Add" || strOp === "AddWithMaxId") {
                (0, clsCommFunc4Ctrl_js_1.SetH4HtmlByIdInDiv)(this.divName4Edit, 'lblDialogTitle_Users', '添加记录');
                //Users_Edit3Ex.GetMaxStrId('#txtUserId');
            }
            else if (strOp === "Update") {
                (0, clsCommFunc4Ctrl_js_1.SetH4HtmlByIdInDiv)(this.divName4Edit, 'lblDialogTitle_Users', '修改记录');
            }
            else if (strOp === "Detail") {
                const btnSubmit_Users = (0, clsCommFunc4Ctrl_js_2.getButtonObjByIdInDiv)(this.divName4Edit, 'btnSubmit_Users');
                btnSubmit_Users.hidden = true;
                (0, clsCommFunc4Ctrl_js_1.SetH4HtmlByIdInDiv)(this.divName4Edit, 'lblDialogTitle_Users', '详细信息');
            }
            ShowDialog('#divEditDialog_Users');
        }
        /**
        * 隐藏对话框
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_TS_HideDialog)
        **/
        HideDialog_Users() {
            const strThisFuncName = this.HideDialog_Users.name;
            (0, clsCommFunc4Ctrl_js_3.CheckControlExist)(this.divName4Edit, "div", "divEditDialog_Users");
            HideDialog('#divEditDialog_Users');
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
                    this.btnSubmit_Users = "确认添加";
                    this.btnCancel_Users = "取消添加";
                    const responseText = this.AddNewRecord();
                    if (Users_Edit3.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_Users('Add');
                    }
                }
                else {
                    this.opType = "Add";
                    this.btnSubmit_Users = "确认添加";
                    this.btnCancel_Users = "取消添加";
                    const responseText = await this.AddNewRecord();
                    if (Users_Edit3.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_Users('Add');
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
                    this.btnSubmit_Users = "确认添加";
                    this.btnCancel_Users = "取消添加";
                    const responseText = this.AddNewRecordWithMaxId();
                    if (Users_Edit3.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_Users('Add');
                    }
                }
                else {
                    this.opType = "AddWithMaxId";
                    this.btnSubmit_Users = "确认添加";
                    this.btnCancel_Users = "取消添加";
                    const responseText = this.AddNewRecordWithMaxId();
                    if (Users_Edit3.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_Users('Add');
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
        * 设置绑定下拉框，针对字段:[id_GradeBase]
        * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdlInDiv_TS4TabFeature)
        **/
        async SetDdl_id_GradeBaseInDiv() {
            await (0, clsXzGradeBaseWApi_js_1.XzGradeBase_BindDdl_id_GradeBaseInDiv_Cache)(this.divName4Edit, "ddlid_GradeBase"); //
        }
        /**
        * 设置绑定下拉框，针对字段:[id_XzCollege]
        * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdlInDiv_TS4TabFeature)
        **/
        async SetDdl_id_XzCollegeInDiv() {
            await (0, clsXzClgWApi_js_1.XzClg_BindDdl_id_XzCollegeInDiv_Cache)(this.divName4Edit, "ddlid_XzCollege"); //
        }
        /**
        * 设置绑定下拉框，针对字段:[id_XzMajor]
        * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdlInDiv_TS4TabFeature)
        **/
        async SetDdl_id_XzMajorInDiv() {
            await (0, clsXzMajorWApi_js_1.XzMajor_BindDdl_id_XzMajorInDiv_Cache)(this.divName4Edit, "ddlid_XzMajor"); //
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
            await this.SetDdl_id_GradeBaseInDiv(); //编辑区域
            await this.SetDdl_id_XzCollegeInDiv(); //编辑区域
            await this.SetDdl_id_XzMajorInDiv(); //编辑区域
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
                    this.btnSubmit_Users = "确认修改";
                    this.btnCancel_Users = "取消修改";
                    this.UpdateRecord(strKeyId);
                    if (Users_Edit3.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_Users('Update');
                    }
                }
                else {
                    this.opType = "Update";
                    this.btnSubmit_Users = "确认修改";
                    this.btnCancel_Users = "取消修改";
                    this.UpdateRecord(strKeyId);
                    if (Users_Edit3.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_Users('Update');
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
                    this.btnSubmit_Users = "确认修改";
                    this.btnCancel_Users = "取消修改";
                    const update = await this.UpdateRecord(strKeyId);
                    if (update == false) {
                        const strMsg = (0, clsString_js_1.Format)("在修改记录时,显示记录数据不成功!");
                        console.error(strMsg);
                        alert(strMsg);
                        return;
                    }
                    if (Users_Edit3.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_Users('Update');
                    }
                }
                else {
                    this.opType = "Update";
                    this.btnSubmit_Users = "确认修改";
                    this.btnCancel_Users = "取消修改";
                    const update = await this.UpdateRecord(strKeyId);
                    if (update == false) {
                        const strMsg = (0, clsString_js_1.Format)("在修改记录时,显示记录数据不成功!");
                        console.error(strMsg);
                        alert(strMsg);
                        return;
                    }
                    if (Users_Edit3.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_Users('Update');
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
            const strCommandText = this.btnSubmit_Users;
            try {
                let returnBool = false;
                let returnKeyId = "";
                let strInfo = "";
                let strMsg = "";
                switch (strCommandText) {
                    case "添加":
                        this.btnSubmit_Users = "确认添加";
                        this.btnCancel_Users = "取消添加";
                        await this.AddNewRecord();
                        break;
                    case "确认添加":
                        //这是一个单表的插入的代码,由于逻辑层太简单,
                        //就把逻辑层合并到控制层,
                        if (this.opType == "AddWithMaxId") {
                            returnKeyId = await this.AddNewRecordWithMaxIdSave();
                            if ((0, clsString_js_1.IsNullOrEmpty)(returnKeyId) == false) {
                                if (Users_Edit3.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                                    this.HideDialog_Users();
                                }
                                this.iShowList.BindGv(clsUsersEN_js_1.clsUsersEN._CurrTabName, returnKeyId);
                            }
                        }
                        else {
                            returnBool = await this.AddNewRecordSave();
                            if (returnBool == true) {
                                if (Users_Edit3.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                                    this.HideDialog_Users();
                                }
                                this.iShowList.BindGv(clsUsersEN_js_1.clsUsersEN._CurrTabName, returnBool.toString());
                            }
                        }
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        returnBool = await this.UpdateRecordSave();
                        strInfo = returnBool ? "修改成功！" : "修改不成功！";
                        strInfo += "(In Users_Edit3.btnSubmit_Click)";
                        //显示信息框
                        //console.log(strInfo);
                        alert(strInfo);
                        if (returnBool == true) {
                            if (Users_Edit3.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                                this.HideDialog_Users();
                            }
                            this.iShowList.BindGv(clsUsersEN_js_1.clsUsersEN._CurrTabName, returnBool.toString());
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
            this.userStateId = "";
            this.password = "";
            $('#ddlid_GradeBase option[0]').attr("selected", "true");
            $('#ddlid_XzCollege option[0]').attr("selected", "true");
            $('#ddlid_XzMajor option[0]').attr("selected", "true");
            this.stuIdTeacherId = "";
            this.email = "";
            $('#ddlIdentityID option[0]').attr("selected", "true");
            this.isRegister = false;
            this.registerDate = "";
            this.mobilePhone = "";
            this.openId = "";
            this.updDate = "";
            this.updUser = "";
            this.memo = "";
        }
        /** 为插入记录做准备工作
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
        **/
        async AddNewRecord() {
            const strThisFuncName = this.AddNewRecord.name;
            this.Clear();
            //wucUsersB1.userId = Users_GetMaxStrId_S();
        }
        /** 为插入记录做准备工作
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxId)
        **/
        AddNewRecordWithMaxId() {
            const strThisFuncName = this.AddNewRecordWithMaxId.name;
            this.SetKeyReadOnly(false);
            this.Clear();
            //wucUsersB1.userId = Users_GetMaxStrId_S();
        }
        /** 函数功能:把界面上的属性数据传到类对象中
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
        * @param pobjUsersEN">数据传输的目的类对象</param>
        **/
        async PutDataToUsersClass(pobjUsersEN) {
            const strThisFuncName = this.PutDataToUsersClass.name;
            pobjUsersEN.SetUserId(this.userId); // 用户ID
            pobjUsersEN.SetUserName(this.userName); // 用户名
            pobjUsersEN.SetUserStateId(this.userStateId); // 用户状态Id
            pobjUsersEN.SetPassword(this.password); // Password
            pobjUsersEN.Setid_GradeBase(this.id_GradeBase); // 年级流水号
            pobjUsersEN.Setid_XzCollege(this.id_XzCollege); // 学院流水号
            pobjUsersEN.Setid_XzMajor(this.id_XzMajor); // 专业流水号
            pobjUsersEN.SetStuIdTeacherId(this.stuIdTeacherId); // 学工号
            pobjUsersEN.SetEmail(this.email); // 电子邮箱
            pobjUsersEN.SetIdentityID(this.identityID); // 身份编号
            pobjUsersEN.SetIsRegister(this.isRegister); // IsRegister
            pobjUsersEN.SetRegisterDate(this.registerDate); // RegisterDate
            pobjUsersEN.SetMobilePhone(this.mobilePhone); // 手机
            pobjUsersEN.SetOpenId(this.openId); // 微信OpenId
            pobjUsersEN.SetUpdDate(clsDateTime_js_1.clsDateTime.getTodayDateTimeStr(1)); // 修改日期
            pobjUsersEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改人
            pobjUsersEN.SetMemo(this.memo); // 备注
        }
        /** 添加新记录，保存函数
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
        **/
        async AddNewRecordSave() {
            const strThisFuncName = this.AddNewRecordSave.name;
            const objUsersEN = new clsUsersEN_js_1.clsUsersEN();
            try {
                await this.PutDataToUsersClass(objUsersEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("从界面获取数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                (0, clsUsersWApi_js_1.Users_CheckPropertyNew)(objUsersEN);
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
                const bolIsExist = await (0, clsUsersWApi_js_2.Users_IsExistAsync)(objUsersEN.userId);
                if (bolIsExist == true) {
                    const strMsg = (0, clsString_js_1.Format)("添加记录时，关键字：{0}已经存在！", objUsersEN.userId);
                    console.error(strMsg);
                    alert(strMsg);
                    return false; //一定要有一个返回值，否则会出错！
                }
                returnBool = await (0, clsUsersWApi_js_3.Users_AddNewRecordAsync)(objUsersEN);
                if (returnBool == true) {
                    (0, clsUsersWApi_js_4.Users_ReFreshCache)();
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
            const objUsersEN = new clsUsersEN_js_1.clsUsersEN();
            try {
                await this.PutDataToUsersClass(objUsersEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("从界面获取数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                throw (strMsg); //一定要有一个返回值，否则会出错！
            }
            try {
                (0, clsUsersWApi_js_1.Users_CheckPropertyNew)(objUsersEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("检查数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                throw (strMsg); //一定要有一个返回值，否则会出错！
            }
            try {
                //检查唯一性条件
                const responseKeyId = await (0, clsUsersWApi_js_5.Users_AddNewRecordWithMaxIdAsync)(objUsersEN);
                const returnKeyId = responseKeyId;
                if ((0, clsString_js_1.IsNullOrEmpty)(returnKeyId) == false) {
                    (0, clsUsersWApi_js_4.Users_ReFreshCache)();
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
            let objUsersEN = new clsUsersEN_js_1.clsUsersEN();
            try {
                const returnBool = await (0, clsUsersWApi_js_2.Users_IsExistAsync)(strUserId);
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
                const objUsersEN_Const = await (0, clsUsersWApi_js_6.Users_GetObjByUserIdAsync)(strUserId);
                if (objUsersEN_Const == null) {
                    const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                    console.error(strMsg);
                    alert(strMsg);
                    return;
                }
                objUsersEN = objUsersEN_Const;
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
            //3、用提供的关键字初始化一个类对象；
            this.GetDataFromUsersClass(objUsersEN);
        }
        /** 函数功能:把类对象的属性内容显示到界面上
        * 注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
        * 如果在设置数据库时,就应该一级字段在前,二级字段在后
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
        * @param pobjUsersEN">表实体类对象</param>
        **/
        async GetDataFromUsersClass(pobjUsersEN) {
            const strThisFuncName = this.GetDataFromUsersClass.name;
            this.userId = pobjUsersEN.userId; // 用户ID
            this.userName = pobjUsersEN.userName; // 用户名
            this.userStateId = pobjUsersEN.userStateId; // 用户状态Id
            this.password = pobjUsersEN.password; // Password
            this.id_GradeBase = pobjUsersEN.id_GradeBase; // 年级流水号
            this.id_XzCollege = pobjUsersEN.id_XzCollege; // 学院流水号
            this.id_XzMajor = pobjUsersEN.id_XzMajor; // 专业流水号
            this.stuIdTeacherId = pobjUsersEN.stuIdTeacherId; // 学工号
            this.email = pobjUsersEN.email; // 电子邮箱
            this.identityID = pobjUsersEN.identityID; // 身份编号
            this.isRegister = pobjUsersEN.isRegister; // IsRegister
            this.registerDate = pobjUsersEN.registerDate; // RegisterDate
            this.mobilePhone = pobjUsersEN.mobilePhone; // 手机
            this.openId = pobjUsersEN.openId; // 微信OpenId
            this.updDate = pobjUsersEN.updDate; // 修改日期
            this.updUser = pobjUsersEN.updUser; // 修改人
            this.memo = pobjUsersEN.memo; // 备注
        }
        /** 根据关键字获取相应的记录的对象
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
        * @param sender">参数列表</param>
        **/
        async UpdateRecord(strUserId) {
            const strThisFuncName = this.UpdateRecord.name;
            this.keyId = strUserId;
            try {
                const objUsersEN_Const = await (0, clsUsersWApi_js_6.Users_GetObjByUserIdAsync)(strUserId);
                if (objUsersEN_Const == null) {
                    const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                    console.error(strMsg);
                    alert(strMsg);
                    return false;
                }
                this.objUsers = objUsersEN_Const;
                const conGetDataFromClass = await this.GetDataFromUsersClass(objUsersEN_Const);
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
            const objUsersEN = new clsUsersEN_js_1.clsUsersEN();
            objUsersEN.SetUserId(this.keyId);
            await this.PutDataToUsersClass(objUsersEN);
            objUsersEN.sf_UpdFldSetStr = objUsersEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objUsersEN.userId == "" || objUsersEN.userId == undefined) {
                console.error("关键字不能为空!");
                throw "关键字不能为空!";
            }
            try {
                (0, clsUsersWApi_js_7.Users_CheckProperty4Update)(objUsersEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("检查数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                //检查唯一性条件
                const returnBool = await (0, clsUsersWApi_js_8.Users_UpdateRecordAsync)(objUsersEN);
                if (returnBool == true) {
                    (0, clsUsersWApi_js_4.Users_ReFreshCache)();
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
        * 设置取消按钮的标题(Used In AddNewRecord())
        **/
        set btnCancel_Users(value) {
            (0, clsCommFunc4Ctrl_js_3.SetButtonHtmlByIdInDiv)(this.divName4Edit, "btnCancel_Users", value);
        }
        /**
        * 获取按钮的标题
        **/
        get btnSubmit_Users() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetButtonHtmlInDiv)(this.divName4Edit, "btnSubmit_Users");
            return strValue;
        }
        /**
        * 设置确定按钮的标题(Used In AddNewRecord())
        **/
        set btnSubmit_Users(value) {
            (0, clsCommFunc4Ctrl_js_3.SetButtonHtmlByIdInDiv)(this.divName4Edit, "btnSubmit_Users", value);
        }
        /**
        * 电子邮箱 (Used In Clear())
        **/
        set email(value) {
            (0, clsCommFunc4Ctrl_js_3.SetInputValueByIdInDiv)(this.divName4Edit, "txtEmail", value);
        }
        /**
        * 电子邮箱 (Used In PutDataToClass())
        **/
        get email() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetInputValueInDiv)(this.divName4Edit, "txtEmail");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 年级流水号 (Used In Clear())
        **/
        set id_GradeBase(value) {
            (0, clsCommFunc4Ctrl_js_3.SetSelectValueByIdInDiv)(this.divName4Edit, "ddlid_GradeBase", value);
        }
        /**
        * 年级流水号 (Used In PutDataToClass())
        **/
        get id_GradeBase() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetSelectValueInDiv)(this.divName4Edit, "ddlid_GradeBase");
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
            (0, clsCommFunc4Ctrl_js_3.SetSelectValueByIdInDiv)(this.divName4Edit, "ddlid_XzCollege", value);
        }
        /**
        * 学院流水号 (Used In PutDataToClass())
        **/
        get id_XzCollege() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetSelectValueInDiv)(this.divName4Edit, "ddlid_XzCollege");
            if (strValue == undefined)
                return "";
            else if (strValue == "0")
                return "";
            else
                return strValue;
        }
        /**
        * 专业流水号 (Used In Clear())
        **/
        set id_XzMajor(value) {
            (0, clsCommFunc4Ctrl_js_3.SetSelectValueByIdInDiv)(this.divName4Edit, "ddlid_XzMajor", value);
        }
        /**
        * 专业流水号 (Used In PutDataToClass())
        **/
        get id_XzMajor() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetSelectValueInDiv)(this.divName4Edit, "ddlid_XzMajor");
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
            (0, clsCommFunc4Ctrl_js_3.SetSelectValueByIdInDiv)(this.divName4Edit, "ddlIdentityID", value);
        }
        /**
        * 身份编号 (Used In PutDataToClass())
        **/
        get identityID() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetSelectValueInDiv)(this.divName4Edit, "ddlIdentityID");
            if (strValue == undefined)
                return "";
            else if (strValue == "0")
                return "";
            else
                return strValue;
        }
        /**
        * IsRegister (Used In Clear())
        **/
        set isRegister(value) {
            (0, clsCommFunc4Ctrl_js_3.SetCheckBoxValueByIdInDiv)(this.divName4Edit, "chkIsRegister", value);
        }
        /**
        * IsRegister (Used In PutDataToClass())
        **/
        get isRegister() {
            const bolValue = (0, clsCommFunc4Ctrl_js_3.GetCheckBoxValueInDiv)(this.divName4Edit, "chkIsRegister");
            return bolValue;
        }
        /**
        * 备注 (Used In Clear())
        **/
        set memo(value) {
            (0, clsCommFunc4Ctrl_js_3.SetInputValueByIdInDiv)(this.divName4Edit, "txtMemo", value);
        }
        /**
        * 备注 (Used In PutDataToClass())
        **/
        get memo() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetInputValueInDiv)(this.divName4Edit, "txtMemo");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 手机 (Used In Clear())
        **/
        set mobilePhone(value) {
            (0, clsCommFunc4Ctrl_js_3.SetInputValueByIdInDiv)(this.divName4Edit, "txtMobilePhone", value);
        }
        /**
        * 手机 (Used In PutDataToClass())
        **/
        get mobilePhone() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetInputValueInDiv)(this.divName4Edit, "txtMobilePhone");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 微信OpenId (Used In Clear())
        **/
        set openId(value) {
            (0, clsCommFunc4Ctrl_js_3.SetInputValueByIdInDiv)(this.divName4Edit, "txtOpenId", value);
        }
        /**
        * 微信OpenId (Used In PutDataToClass())
        **/
        get openId() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetInputValueInDiv)(this.divName4Edit, "txtOpenId");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * Password (Used In Clear())
        **/
        set password(value) {
            (0, clsCommFunc4Ctrl_js_3.SetInputValueByIdInDiv)(this.divName4Edit, "txtPassword", value);
        }
        /**
        * Password (Used In PutDataToClass())
        **/
        get password() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetInputValueInDiv)(this.divName4Edit, "txtPassword");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * RegisterDate (Used In Clear())
        **/
        set registerDate(value) {
            (0, clsCommFunc4Ctrl_js_3.SetInputValueByIdInDiv)(this.divName4Edit, "txtRegisterDate", value);
        }
        /**
        * RegisterDate (Used In PutDataToClass())
        **/
        get registerDate() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetInputValueInDiv)(this.divName4Edit, "txtRegisterDate");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 学工号 (Used In Clear())
        **/
        set stuIdTeacherId(value) {
            (0, clsCommFunc4Ctrl_js_3.SetInputValueByIdInDiv)(this.divName4Edit, "txtStuIdTeacherId", value);
        }
        /**
        * 学工号 (Used In PutDataToClass())
        **/
        get stuIdTeacherId() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetInputValueInDiv)(this.divName4Edit, "txtStuIdTeacherId");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 修改日期 (Used In Clear())
        **/
        set updDate(value) {
            (0, clsCommFunc4Ctrl_js_3.SetInputValueByIdInDiv)(this.divName4Edit, "txtUpdDate", value);
        }
        /**
        * 修改日期 (Used In PutDataToClass())
        **/
        get updDate() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetInputValueInDiv)(this.divName4Edit, "txtUpdDate");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 修改人 (Used In Clear())
        **/
        set updUser(value) {
            (0, clsCommFunc4Ctrl_js_3.SetInputValueByIdInDiv)(this.divName4Edit, "txtUpdUser", value);
        }
        /**
        * 修改人 (Used In PutDataToClass())
        **/
        get updUser() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetInputValueInDiv)(this.divName4Edit, "txtUpdUser");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 用户ID (Used In Clear())
        **/
        set userId(value) {
            (0, clsCommFunc4Ctrl_js_3.SetInputValueByIdInDiv)(this.divName4Edit, "txtUserId", value);
        }
        /**
        * 用户ID (Used In PutDataToClass())
        **/
        get userId() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetInputValueInDiv)(this.divName4Edit, "txtUserId");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 用户名 (Used In Clear())
        **/
        set userName(value) {
            (0, clsCommFunc4Ctrl_js_3.SetInputValueByIdInDiv)(this.divName4Edit, "txtUserName", value);
        }
        /**
        * 用户名 (Used In PutDataToClass())
        **/
        get userName() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetInputValueInDiv)(this.divName4Edit, "txtUserName");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 用户状态Id (Used In Clear())
        **/
        set userStateId(value) {
            (0, clsCommFunc4Ctrl_js_3.SetInputValueByIdInDiv)(this.divName4Edit, "txtUserStateId", value);
        }
        /**
        * 用户状态Id (Used In PutDataToClass())
        **/
        get userStateId() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetInputValueInDiv)(this.divName4Edit, "txtUserStateId");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
    }
    exports.Users_Edit3 = Users_Edit3;
    Users_Edit3.strPageDispModeId = "01"; //PopupBox(弹出框)
});
