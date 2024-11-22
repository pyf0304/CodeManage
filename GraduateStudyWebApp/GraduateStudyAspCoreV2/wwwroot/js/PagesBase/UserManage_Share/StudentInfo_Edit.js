(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../TS/PubFun/clsCommFunc4Ctrl.js", "../../TS/PubFun/clsCommFunc4Ctrl.js", "../../TS/L3_ForWApi/EPortfolio/clsRsStuTypeWApi.js", "../../TS/L3_ForWApi/BaseInfo_Share/clsXzClgWApi.js", "../../TS/L3_ForWApi/BaseInfo_Share/clsXzMajorWApi.js", "../../TS/L3_ForWApi/SysPara/clsXzGradeBaseWApi.js", "../../TS/L3_ForWApi/PeopleManage/clsXzAdminClsWApi.js", "../../TS/L3_ForWApi/UserManage_Share/clsStudentInfoWApi.js", "../../TS/PubFun/clsPublocalStorage.js", "../../TS/L3_ForWApi/UserManage_Share/clsStudentInfoWApi.js", "../../TS/L3_ForWApi/UserManage_Share/clsStudentInfoWApi.js", "../../TS/L3_ForWApi/UserManage_Share/clsStudentInfoWApi.js", "../../TS/L3_ForWApi/UserManage_Share/clsStudentInfoWApi.js", "../../TS/L3_ForWApi/UserManage_Share/clsStudentInfoWApi.js", "../../TS/L3_ForWApi/UserManage_Share/clsStudentInfoWApi.js", "../../TS/L0_Entity/UserManage_Share/clsStudentInfoEN.js", "../../TS/L3_ForWApi/UserManage_Share/clsStudentInfoWApi.js", "../../TS/L3_ForWApi/UserManage_Share/clsStudentInfoWApi.js", "../../TS/L3_ForWApi/UserManage_Share/clsStudentInfoWApi.js", "../../TS/L3_ForWApi/UserManage_Share/clsStudentInfoWApi.js", "../../TS/PubFun/clsCommFunc4Ctrl.js", "../../TS/PubFun/clsString.js", "../../TS/PubFun/clsDateTime.js", "../../TS/L0_Entity/PrjMenu/clsPageDispModeEN.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.StudentInfo_Edit = void 0;
    /**
    * 类名:StudentInfo_Edit(界面:StudentInfoCRUD)
    * 表名:StudentInfo(01120131)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 01:05:55
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
    const clsRsStuTypeWApi_js_1 = require("../../TS/L3_ForWApi/EPortfolio/clsRsStuTypeWApi.js");
    const clsXzClgWApi_js_1 = require("../../TS/L3_ForWApi/BaseInfo_Share/clsXzClgWApi.js");
    const clsXzMajorWApi_js_1 = require("../../TS/L3_ForWApi/BaseInfo_Share/clsXzMajorWApi.js");
    const clsXzGradeBaseWApi_js_1 = require("../../TS/L3_ForWApi/SysPara/clsXzGradeBaseWApi.js");
    const clsXzAdminClsWApi_js_1 = require("../../TS/L3_ForWApi/PeopleManage/clsXzAdminClsWApi.js");
    const clsStudentInfoWApi_js_1 = require("../../TS/L3_ForWApi/UserManage_Share/clsStudentInfoWApi.js");
    const clsPublocalStorage_js_1 = require("../../TS/PubFun/clsPublocalStorage.js");
    const clsStudentInfoWApi_js_2 = require("../../TS/L3_ForWApi/UserManage_Share/clsStudentInfoWApi.js");
    const clsStudentInfoWApi_js_3 = require("../../TS/L3_ForWApi/UserManage_Share/clsStudentInfoWApi.js");
    const clsStudentInfoWApi_js_4 = require("../../TS/L3_ForWApi/UserManage_Share/clsStudentInfoWApi.js");
    const clsStudentInfoWApi_js_5 = require("../../TS/L3_ForWApi/UserManage_Share/clsStudentInfoWApi.js");
    const clsStudentInfoWApi_js_6 = require("../../TS/L3_ForWApi/UserManage_Share/clsStudentInfoWApi.js");
    const clsStudentInfoWApi_js_7 = require("../../TS/L3_ForWApi/UserManage_Share/clsStudentInfoWApi.js");
    const clsStudentInfoEN_js_1 = require("../../TS/L0_Entity/UserManage_Share/clsStudentInfoEN.js");
    const clsStudentInfoWApi_js_8 = require("../../TS/L3_ForWApi/UserManage_Share/clsStudentInfoWApi.js");
    const clsStudentInfoWApi_js_9 = require("../../TS/L3_ForWApi/UserManage_Share/clsStudentInfoWApi.js");
    const clsStudentInfoWApi_js_10 = require("../../TS/L3_ForWApi/UserManage_Share/clsStudentInfoWApi.js");
    const clsStudentInfoWApi_js_11 = require("../../TS/L3_ForWApi/UserManage_Share/clsStudentInfoWApi.js");
    const clsCommFunc4Ctrl_js_3 = require("../../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsString_js_1 = require("../../TS/PubFun/clsString.js");
    const clsDateTime_js_1 = require("../../TS/PubFun/clsDateTime.js");
    const clsPageDispModeEN_js_1 = require("../../TS/L0_Entity/PrjMenu/clsPageDispModeEN.js");
    /** StudentInfo_Edit 的摘要说明。其中Q代表查询,U代表修改
    * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:GeneCode)
    **/
    class StudentInfo_Edit {
        constructor(objShowList) {
            this.opType = "";
            this.keyId = "";
            this.bolIsLoadEditRegion = false; //记录是否导入编辑区的变量
            this.divName4Edit = "divEdit"; //编辑区的Id
            this.iShowList = objShowList;
            StudentInfo_Edit.objPage_Edit = this;
            this.objStudentInfo = new clsStudentInfoEN_js_1.clsStudentInfoEN();
        }
        /**
        * 在当前界面中，导入编辑区域
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Edit)
        * @returns
        **/
        async AddDPV_Edit(divName4Edit) {
            const strThisFuncName = this.AddDPV_Edit.name;
            (0, clsCommFunc4Ctrl_js_3.CheckDivExist)(divName4Edit);
            const strUrl = "../UserManage_Share/StudentInfo_Edit";
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
        ShowDialog_StudentInfo(strOp) {
            const strThisFuncName = this.ShowDialog_StudentInfo.name;
            //检查相关控件是否存在
            (0, clsCommFunc4Ctrl_js_3.CheckControlExist)(this.divName4Edit, "div", "divEditDialog_StudentInfo");
            (0, clsCommFunc4Ctrl_js_3.CheckControlExist)(this.divName4Edit, "h4", "lblDialogTitle_StudentInfo");
            if (strOp === "Add" || strOp === "AddWithMaxId") {
                (0, clsCommFunc4Ctrl_js_1.SetH4HtmlByIdInDiv)(this.divName4Edit, 'lblDialogTitle_StudentInfo', '添加记录');
                //StudentInfo_EditEx.GetMaxStrId('#txtid_StudentInfo');
            }
            else if (strOp === "Update") {
                (0, clsCommFunc4Ctrl_js_1.SetH4HtmlByIdInDiv)(this.divName4Edit, 'lblDialogTitle_StudentInfo', '修改记录');
            }
            else if (strOp === "Detail") {
                const btnSubmit_StudentInfo = (0, clsCommFunc4Ctrl_js_2.getButtonObjByIdInDiv)(this.divName4Edit, 'btnSubmit_StudentInfo');
                btnSubmit_StudentInfo.hidden = true;
                (0, clsCommFunc4Ctrl_js_1.SetH4HtmlByIdInDiv)(this.divName4Edit, 'lblDialogTitle_StudentInfo', '详细信息');
            }
            ShowDialog('#divEditDialog_StudentInfo');
        }
        /**
        * 隐藏对话框
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_TS_HideDialog)
        **/
        HideDialog_StudentInfo() {
            const strThisFuncName = this.HideDialog_StudentInfo.name;
            (0, clsCommFunc4Ctrl_js_3.CheckControlExist)(this.divName4Edit, "div", "divEditDialog_StudentInfo");
            HideDialog('#divEditDialog_StudentInfo');
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
                    this.btnSubmit_StudentInfo = "确认添加";
                    this.btnCancel_StudentInfo = "取消添加";
                    const responseText = this.AddNewRecord();
                    if (StudentInfo_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_StudentInfo('Add');
                    }
                }
                else {
                    this.opType = "Add";
                    this.btnSubmit_StudentInfo = "确认添加";
                    this.btnCancel_StudentInfo = "取消添加";
                    const responseText = await this.AddNewRecord();
                    if (StudentInfo_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_StudentInfo('Add');
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
                    this.btnSubmit_StudentInfo = "确认添加";
                    this.btnCancel_StudentInfo = "取消添加";
                    const responseText = this.AddNewRecordWithMaxId();
                    if (StudentInfo_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_StudentInfo('Add');
                    }
                }
                else {
                    this.opType = "AddWithMaxId";
                    this.btnSubmit_StudentInfo = "确认添加";
                    this.btnCancel_StudentInfo = "取消添加";
                    const responseText = this.AddNewRecordWithMaxId();
                    if (StudentInfo_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_StudentInfo('Add');
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
        * 设置绑定下拉框，针对字段:[id_StuType]
        * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdlInDiv_TS4TabFeature)
        **/
        async SetDdl_id_StuTypeInDiv() {
            await (0, clsRsStuTypeWApi_js_1.RsStuType_BindDdl_id_StuTypeInDiv_Cache)(this.divName4Edit, "ddlid_StuType"); //
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
        * 设置绑定下拉框，针对字段:[id_GradeBase]
        * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdlInDiv_TS4TabFeature)
        **/
        async SetDdl_id_GradeBaseInDiv() {
            await (0, clsXzGradeBaseWApi_js_1.XzGradeBase_BindDdl_id_GradeBaseInDiv_Cache)(this.divName4Edit, "ddlid_GradeBase"); //
        }
        /**
        * 设置绑定下拉框，针对字段:[id_AdminCls]
        * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdlInDiv_TS4TabFeature)
        **/
        async SetDdl_id_AdminClsInDiv() {
            await (0, clsXzAdminClsWApi_js_1.XzAdminCls_BindDdl_id_AdminClsInDiv_Cache)(this.divName4Edit, "ddlid_AdminCls"); //
        }
        /** 函数功能:为编辑区绑定下拉框
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegionInDiv)
        **/
        async BindDdl4EditRegionInDiv() {
            const strThisFuncName = this.BindDdl4EditRegionInDiv.name;
            // 在此处放置用户代码以初始化页面
            await this.SetDdl_id_StuTypeInDiv(); //编辑区域
            await this.SetDdl_id_XzCollegeInDiv(); //编辑区域
            await this.SetDdl_id_XzMajorInDiv(); //编辑区域
            await this.SetDdl_id_GradeBaseInDiv(); //编辑区域
            await this.SetDdl_id_AdminClsInDiv(); //编辑区域
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
                    this.btnSubmit_StudentInfo = "确认修改";
                    this.btnCancel_StudentInfo = "取消修改";
                    this.UpdateRecord(strKeyId);
                    if (StudentInfo_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_StudentInfo('Update');
                    }
                }
                else {
                    this.opType = "Update";
                    this.btnSubmit_StudentInfo = "确认修改";
                    this.btnCancel_StudentInfo = "取消修改";
                    this.UpdateRecord(strKeyId);
                    if (StudentInfo_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_StudentInfo('Update');
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
                    this.btnSubmit_StudentInfo = "确认修改";
                    this.btnCancel_StudentInfo = "取消修改";
                    const update = await this.UpdateRecord(strKeyId);
                    if (update == false) {
                        const strMsg = (0, clsString_js_1.Format)("在修改记录时,显示记录数据不成功!");
                        console.error(strMsg);
                        alert(strMsg);
                        return;
                    }
                    if (StudentInfo_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_StudentInfo('Update');
                    }
                }
                else {
                    this.opType = "Update";
                    this.btnSubmit_StudentInfo = "确认修改";
                    this.btnCancel_StudentInfo = "取消修改";
                    const update = await this.UpdateRecord(strKeyId);
                    if (update == false) {
                        const strMsg = (0, clsString_js_1.Format)("在修改记录时,显示记录数据不成功!");
                        console.error(strMsg);
                        alert(strMsg);
                        return;
                    }
                    if (StudentInfo_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_StudentInfo('Update');
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
            const strCommandText = this.btnSubmit_StudentInfo;
            try {
                let returnBool = false;
                let returnKeyId = "";
                let strInfo = "";
                let strMsg = "";
                switch (strCommandText) {
                    case "添加":
                        this.btnSubmit_StudentInfo = "确认添加";
                        this.btnCancel_StudentInfo = "取消添加";
                        await this.AddNewRecord();
                        break;
                    case "确认添加":
                        //这是一个单表的插入的代码,由于逻辑层太简单,
                        //就把逻辑层合并到控制层,
                        if (this.opType == "AddWithMaxId") {
                            returnKeyId = await this.AddNewRecordWithMaxIdSave();
                            if ((0, clsString_js_1.IsNullOrEmpty)(returnKeyId) == false) {
                                if (StudentInfo_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                                    this.HideDialog_StudentInfo();
                                }
                                this.iShowList.BindGv(clsStudentInfoEN_js_1.clsStudentInfoEN._CurrTabName, returnKeyId);
                            }
                        }
                        else {
                            returnBool = await this.AddNewRecordSave();
                            if (returnBool == true) {
                                if (StudentInfo_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                                    this.HideDialog_StudentInfo();
                                }
                                this.iShowList.BindGv(clsStudentInfoEN_js_1.clsStudentInfoEN._CurrTabName, returnBool.toString());
                            }
                        }
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        returnBool = await this.UpdateRecordSave();
                        strInfo = returnBool ? "修改成功！" : "修改不成功！";
                        strInfo += "(In StudentInfo_Edit.btnSubmit_Click)";
                        //显示信息框
                        //console.log(strInfo);
                        alert(strInfo);
                        if (returnBool == true) {
                            if (StudentInfo_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                                this.HideDialog_StudentInfo();
                            }
                            this.iShowList.BindGv(clsStudentInfoEN_js_1.clsStudentInfoEN._CurrTabName, returnBool.toString());
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
            $('#txtid_StudentInfo').attr('ReadOnly', bolReadonly.toString());
        }
        /**
         * 清除用户自定义控件中，所有控件的值
         * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_Clear)
         **/
        Clear() {
            const strThisFuncName = this.Clear.name;
            this.id_StudentInfo = "";
            this.stuID = "";
            this.stuName = "";
            this.id_Politics = "";
            this.id_Sex = "";
            this.id_Ethnic = "";
            this.id_UniZone = "";
            $('#ddlid_StuType option[0]').attr("selected", "true");
            $('#ddlid_XzCollege option[0]').attr("selected", "true");
            $('#ddlid_XzMajor option[0]').attr("selected", "true");
            $('#ddlid_GradeBase option[0]').attr("selected", "true");
            $('#ddlid_AdminCls option[0]').attr("selected", "true");
            this.birthday = "";
            this.nativePlace = "";
            this.duty = "";
            this.idCardNo = "";
            this.stuCardNo = "";
            this.liveAddress = "";
            this.homePhone = "";
            this.id_CardNo = "";
            this.cardNo = "";
            this.isAvconClassUser = false;
            this.isAvconUser = false;
            this.isGpUser = false;
            this.isLeaved = false;
            this.userId = "";
            this.userID4Avcon = "";
            this.enrollmentDate = "";
            this.postCode = "";
            this.email = "";
            this.isMessage = false;
            this.microblog = "";
            this.phoneNumber = "";
            this.headphoto = "";
            this.qQ = "";
            this.registerPassword = "";
            this.memo = "";
        }
        /** 为插入记录做准备工作
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
        **/
        async AddNewRecord() {
            const strThisFuncName = this.AddNewRecord.name;
            this.Clear();
            //wucStudentInfoB1.id_StudentInfo = StudentInfo_GetMaxStrId_S();
            try {
                const returnString = await (0, clsStudentInfoWApi_js_1.StudentInfo_GetMaxStrIdAsync)();
                if (returnString == "") {
                    const strInfo = (0, clsString_js_1.Format)("获取表StudentInfo的最大关键字为空，不成功，请检查!");
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    $('#txtid_StudentInfo').val(returnString);
                }
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("获取表关键字的最大值不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /** 为插入记录做准备工作
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxId)
        **/
        AddNewRecordWithMaxId() {
            const strThisFuncName = this.AddNewRecordWithMaxId.name;
            this.Clear();
            //wucStudentInfoB1.id_StudentInfo = StudentInfo_GetMaxStrId_S();
        }
        /** 函数功能:把界面上的属性数据传到类对象中
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
        * @param pobjStudentInfoEN">数据传输的目的类对象</param>
        **/
        async PutDataToStudentInfoClass(pobjStudentInfoEN) {
            const strThisFuncName = this.PutDataToStudentInfoClass.name;
            pobjStudentInfoEN.Setid_StudentInfo(this.id_StudentInfo); // 学生流水号
            pobjStudentInfoEN.SetStuID(this.stuID); // 学号
            pobjStudentInfoEN.SetStuName(this.stuName); // 姓名
            pobjStudentInfoEN.Setid_Politics(this.id_Politics); // 政治面貌流水号
            pobjStudentInfoEN.Setid_Sex(this.id_Sex); // 性别流水号
            pobjStudentInfoEN.Setid_Ethnic(this.id_Ethnic); // 民族流水号
            pobjStudentInfoEN.Setid_UniZone(this.id_UniZone); // 校区流水号
            pobjStudentInfoEN.Setid_StuType(this.id_StuType); // 学生类别流水号
            pobjStudentInfoEN.Setid_XzCollege(this.id_XzCollege); // 学院流水号
            pobjStudentInfoEN.Setid_XzMajor(this.id_XzMajor); // 专业流水号
            pobjStudentInfoEN.Setid_GradeBase(this.id_GradeBase); // 年级流水号
            pobjStudentInfoEN.Setid_AdminCls(this.id_AdminCls); // 行政班流水号
            pobjStudentInfoEN.SetBirthday(this.birthday); // 出生日期
            pobjStudentInfoEN.SetNativePlace(this.nativePlace); // 籍贯
            pobjStudentInfoEN.SetDuty(this.duty); // 职位
            pobjStudentInfoEN.SetIDCardNo(this.idCardNo); // 身份证号
            pobjStudentInfoEN.SetStuCardNo(this.stuCardNo); // 学生证号
            pobjStudentInfoEN.SetLiveAddress(this.liveAddress); // 居住地址
            pobjStudentInfoEN.SetHomePhone(this.homePhone); // 住宅电话
            pobjStudentInfoEN.SetId_CardNo(this.id_CardNo); // 内卡号
            pobjStudentInfoEN.SetCardNo(this.cardNo); // 卡号
            pobjStudentInfoEN.SetIsAvconClassUser(this.isAvconClassUser); // IsAvconClassUser
            pobjStudentInfoEN.SetIsAvconUser(this.isAvconUser); // IsAvconUser
            pobjStudentInfoEN.SetIsGpUser(this.isGpUser); // 是否Gp用户
            pobjStudentInfoEN.SetIsLeaved(this.isLeaved); // IsLeaved
            pobjStudentInfoEN.SetUserId(this.userId); // 用户ID
            pobjStudentInfoEN.SetUserID4Avcon(this.userID4Avcon); // UserID4Avcon
            pobjStudentInfoEN.SetEnrollmentDate(this.enrollmentDate); // 入校日期
            pobjStudentInfoEN.SetPostCode(this.postCode); // 邮编
            pobjStudentInfoEN.SetEmail(this.email); // 电子邮箱
            pobjStudentInfoEN.SetIsMessage(this.isMessage); // IsMessage
            pobjStudentInfoEN.SetMicroblog(this.microblog); // Microblog
            pobjStudentInfoEN.SetPhoneNumber(this.phoneNumber); // PhoneNumber
            pobjStudentInfoEN.SetHeadphoto(this.headphoto); // Headphoto
            pobjStudentInfoEN.SetQQ(this.qQ); // QQ
            pobjStudentInfoEN.SetRegisterPassword(this.registerPassword); // RegisterPassword
            pobjStudentInfoEN.SetUpdDate(clsDateTime_js_1.clsDateTime.getTodayDateTimeStr(1)); // 修改日期
            pobjStudentInfoEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改人
            pobjStudentInfoEN.SetMemo(this.memo); // 备注
        }
        /** 添加新记录，保存函数
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
        **/
        async AddNewRecordSave() {
            const strThisFuncName = this.AddNewRecordSave.name;
            const objStudentInfoEN = new clsStudentInfoEN_js_1.clsStudentInfoEN();
            try {
                await this.PutDataToStudentInfoClass(objStudentInfoEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("从界面获取数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                (0, clsStudentInfoWApi_js_2.StudentInfo_CheckPropertyNew)(objStudentInfoEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("检查数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                //检查唯一性条件
                const bolIsExistCond_StuID = await this.CheckUniCond4Add_StuID(objStudentInfoEN);
                if (bolIsExistCond_StuID == false) {
                    return false;
                }
                let returnBool = false;
                const returnKeyId = await (0, clsStudentInfoWApi_js_3.StudentInfo_AddNewRecordWithMaxIdAsync)(objStudentInfoEN);
                if ((0, clsString_js_1.IsNullOrEmpty)(returnKeyId) == false) {
                    returnBool = true;
                }
                if (returnBool == true) {
                    (0, clsStudentInfoWApi_js_4.StudentInfo_ReFreshCache)();
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
        /** 为添加记录检查唯一性条件
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_CheckUniCondition4Add)
        **/
        async CheckUniCond4Add_StuID(objStudentInfoEN) {
            const strThisFuncName = this.CheckUniCond4Add_StuID.name;
            const strUniquenessCondition = (0, clsStudentInfoWApi_js_5.StudentInfo_GetUniCondStr_StuID)(objStudentInfoEN);
            const bolIsExistCondition = await (0, clsStudentInfoWApi_js_6.StudentInfo_IsExistRecordAsync)(strUniquenessCondition);
            if (bolIsExistCondition == true) {
                const strMsg = (0, clsString_js_1.Format)("不能满足唯一性条件。满足条件：{0}的记录已经存在！", strUniquenessCondition);
                console.error(strMsg);
                alert(strMsg);
                return false;
            }
            return true;
        }
        /** 为修改记录检查唯一性条件
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_CheckUniCondition4Update)
        **/
        async CheckUniCond4Update_StuID(objStudentInfoEN) {
            const strThisFuncName = this.CheckUniCond4Update_StuID.name;
            const strUniquenessCondition = (0, clsStudentInfoWApi_js_7.StudentInfo_GetUniCondStr4Update_StuID)(objStudentInfoEN);
            const bolIsExistCondition = await (0, clsStudentInfoWApi_js_6.StudentInfo_IsExistRecordAsync)(strUniquenessCondition);
            if (bolIsExistCondition == true) {
                const strMsg = (0, clsString_js_1.Format)("不能满足唯一性条件。满足条件：{0}的记录已经存在！", strUniquenessCondition);
                console.error(strMsg);
                alert(strMsg);
                return false;
            }
            return true;
        }
        /** 添加新记录，由后台自动获取最大值的关键字。保存函数
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxIdSave)
        **/
        async AddNewRecordWithMaxIdSave() {
            const strThisFuncName = this.AddNewRecordWithMaxIdSave.name;
            const objStudentInfoEN = new clsStudentInfoEN_js_1.clsStudentInfoEN();
            try {
                await this.PutDataToStudentInfoClass(objStudentInfoEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("从界面获取数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                throw (strMsg); //一定要有一个返回值，否则会出错！
            }
            try {
                (0, clsStudentInfoWApi_js_2.StudentInfo_CheckPropertyNew)(objStudentInfoEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("检查数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                throw (strMsg); //一定要有一个返回值，否则会出错！
            }
            try {
                //检查唯一性条件
                const bolIsExistCond_StuID = await this.CheckUniCond4Add_StuID(objStudentInfoEN);
                if (bolIsExistCond_StuID == false) {
                    return "";
                }
                const responseKeyId = await (0, clsStudentInfoWApi_js_3.StudentInfo_AddNewRecordWithMaxIdAsync)(objStudentInfoEN);
                const returnKeyId = responseKeyId;
                if ((0, clsString_js_1.IsNullOrEmpty)(returnKeyId) == false) {
                    (0, clsStudentInfoWApi_js_4.StudentInfo_ReFreshCache)();
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
        * @param strid_StudentInfo: 表记录的关键字,显示该表关键字的内容
        **/
        async ShowData(strid_StudentInfo) {
            const strThisFuncName = this.ShowData.name;
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            let objStudentInfoEN = new clsStudentInfoEN_js_1.clsStudentInfoEN();
            try {
                const returnBool = await (0, clsStudentInfoWApi_js_8.StudentInfo_IsExistAsync)(strid_StudentInfo);
                if (returnBool == false) {
                    const strInfo = (0, clsString_js_1.Format)("关键字:[{0}] 的记录不存在!", strid_StudentInfo);
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
                const objStudentInfoEN_Const = await (0, clsStudentInfoWApi_js_9.StudentInfo_GetObjByid_StudentInfoAsync)(strid_StudentInfo);
                if (objStudentInfoEN_Const == null) {
                    const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                    console.error(strMsg);
                    alert(strMsg);
                    return;
                }
                objStudentInfoEN = objStudentInfoEN_Const;
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
            //3、用提供的关键字初始化一个类对象；
            this.GetDataFromStudentInfoClass(objStudentInfoEN);
        }
        /** 函数功能:把类对象的属性内容显示到界面上
        * 注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
        * 如果在设置数据库时,就应该一级字段在前,二级字段在后
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
        * @param pobjStudentInfoEN">表实体类对象</param>
        **/
        async GetDataFromStudentInfoClass(pobjStudentInfoEN) {
            const strThisFuncName = this.GetDataFromStudentInfoClass.name;
            this.id_StudentInfo = pobjStudentInfoEN.id_StudentInfo; // 学生流水号
            this.stuID = pobjStudentInfoEN.stuID; // 学号
            this.stuName = pobjStudentInfoEN.stuName; // 姓名
            this.id_Politics = pobjStudentInfoEN.id_Politics; // 政治面貌流水号
            this.id_Sex = pobjStudentInfoEN.id_Sex; // 性别流水号
            this.id_Ethnic = pobjStudentInfoEN.id_Ethnic; // 民族流水号
            this.id_UniZone = pobjStudentInfoEN.id_UniZone; // 校区流水号
            this.id_StuType = pobjStudentInfoEN.id_StuType; // 学生类别流水号
            this.id_XzCollege = pobjStudentInfoEN.id_XzCollege; // 学院流水号
            this.id_XzMajor = pobjStudentInfoEN.id_XzMajor; // 专业流水号
            this.id_GradeBase = pobjStudentInfoEN.id_GradeBase; // 年级流水号
            this.id_AdminCls = pobjStudentInfoEN.id_AdminCls; // 行政班流水号
            this.birthday = pobjStudentInfoEN.birthday; // 出生日期
            this.nativePlace = pobjStudentInfoEN.nativePlace; // 籍贯
            this.duty = pobjStudentInfoEN.duty; // 职位
            this.idCardNo = pobjStudentInfoEN.idCardNo; // 身份证号
            this.stuCardNo = pobjStudentInfoEN.stuCardNo; // 学生证号
            this.liveAddress = pobjStudentInfoEN.liveAddress; // 居住地址
            this.homePhone = pobjStudentInfoEN.homePhone; // 住宅电话
            this.id_CardNo = pobjStudentInfoEN.id_CardNo; // 内卡号
            this.cardNo = pobjStudentInfoEN.cardNo; // 卡号
            this.isAvconClassUser = pobjStudentInfoEN.isAvconClassUser; // IsAvconClassUser
            this.isAvconUser = pobjStudentInfoEN.isAvconUser; // IsAvconUser
            this.isGpUser = pobjStudentInfoEN.isGpUser; // 是否Gp用户
            this.isLeaved = pobjStudentInfoEN.isLeaved; // IsLeaved
            this.userId = pobjStudentInfoEN.userId; // 用户ID
            this.userID4Avcon = pobjStudentInfoEN.userID4Avcon; // UserID4Avcon
            this.enrollmentDate = pobjStudentInfoEN.enrollmentDate; // 入校日期
            this.postCode = pobjStudentInfoEN.postCode; // 邮编
            this.email = pobjStudentInfoEN.email; // 电子邮箱
            this.isMessage = pobjStudentInfoEN.isMessage; // IsMessage
            this.microblog = pobjStudentInfoEN.microblog; // Microblog
            this.phoneNumber = pobjStudentInfoEN.phoneNumber; // PhoneNumber
            this.headphoto = pobjStudentInfoEN.headphoto; // Headphoto
            this.qQ = pobjStudentInfoEN.qQ; // QQ
            this.registerPassword = pobjStudentInfoEN.registerPassword; // RegisterPassword
            this.memo = pobjStudentInfoEN.memo; // 备注
        }
        /** 根据关键字获取相应的记录的对象
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
        * @param sender">参数列表</param>
        **/
        async UpdateRecord(strid_StudentInfo) {
            const strThisFuncName = this.UpdateRecord.name;
            this.keyId = strid_StudentInfo;
            try {
                const objStudentInfoEN_Const = await (0, clsStudentInfoWApi_js_9.StudentInfo_GetObjByid_StudentInfoAsync)(strid_StudentInfo);
                if (objStudentInfoEN_Const == null) {
                    const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                    console.error(strMsg);
                    alert(strMsg);
                    return false;
                }
                this.objStudentInfo = objStudentInfoEN_Const;
                const conGetDataFromClass = await this.GetDataFromStudentInfoClass(objStudentInfoEN_Const);
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
            const objStudentInfoEN = new clsStudentInfoEN_js_1.clsStudentInfoEN();
            objStudentInfoEN.Setid_StudentInfo(this.keyId);
            await this.PutDataToStudentInfoClass(objStudentInfoEN);
            objStudentInfoEN.sf_UpdFldSetStr = objStudentInfoEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objStudentInfoEN.id_StudentInfo == "" || objStudentInfoEN.id_StudentInfo == undefined) {
                console.error("关键字不能为空!");
                throw "关键字不能为空!";
            }
            try {
                (0, clsStudentInfoWApi_js_10.StudentInfo_CheckProperty4Update)(objStudentInfoEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("检查数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                //检查唯一性条件
                const bolIsExistCond_StuID = await this.CheckUniCond4Update_StuID(objStudentInfoEN);
                if (bolIsExistCond_StuID == false) {
                    return false;
                }
                const returnBool = await (0, clsStudentInfoWApi_js_11.StudentInfo_UpdateRecordAsync)(objStudentInfoEN);
                if (returnBool == true) {
                    (0, clsStudentInfoWApi_js_4.StudentInfo_ReFreshCache)();
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
        * 出生日期 (Used In Clear())
        **/
        set birthday(value) {
            (0, clsCommFunc4Ctrl_js_3.SetInputValueByIdInDiv)(this.divName4Edit, "txtBirthday", value);
        }
        /**
        * 出生日期 (Used In PutDataToClass())
        **/
        get birthday() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetInputValueInDiv)(this.divName4Edit, "txtBirthday");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 设置取消按钮的标题(Used In AddNewRecord())
        **/
        set btnCancel_StudentInfo(value) {
            (0, clsCommFunc4Ctrl_js_3.SetButtonHtmlByIdInDiv)(this.divName4Edit, "btnCancel_StudentInfo", value);
        }
        /**
        * 获取按钮的标题
        **/
        get btnSubmit_StudentInfo() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetButtonHtmlInDiv)(this.divName4Edit, "btnSubmit_StudentInfo");
            return strValue;
        }
        /**
        * 设置确定按钮的标题(Used In AddNewRecord())
        **/
        set btnSubmit_StudentInfo(value) {
            (0, clsCommFunc4Ctrl_js_3.SetButtonHtmlByIdInDiv)(this.divName4Edit, "btnSubmit_StudentInfo", value);
        }
        /**
        * 卡号 (Used In Clear())
        **/
        set cardNo(value) {
            (0, clsCommFunc4Ctrl_js_3.SetInputValueByIdInDiv)(this.divName4Edit, "txtCardNo", value);
        }
        /**
        * 卡号 (Used In PutDataToClass())
        **/
        get cardNo() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetInputValueInDiv)(this.divName4Edit, "txtCardNo");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 职位 (Used In Clear())
        **/
        set duty(value) {
            (0, clsCommFunc4Ctrl_js_3.SetInputValueByIdInDiv)(this.divName4Edit, "txtDuty", value);
        }
        /**
        * 职位 (Used In PutDataToClass())
        **/
        get duty() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetInputValueInDiv)(this.divName4Edit, "txtDuty");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
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
        * 入校日期 (Used In Clear())
        **/
        set enrollmentDate(value) {
            (0, clsCommFunc4Ctrl_js_3.SetInputValueByIdInDiv)(this.divName4Edit, "txtEnrollmentDate", value);
        }
        /**
        * 入校日期 (Used In PutDataToClass())
        **/
        get enrollmentDate() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetInputValueInDiv)(this.divName4Edit, "txtEnrollmentDate");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * Headphoto (Used In Clear())
        **/
        set headphoto(value) {
            (0, clsCommFunc4Ctrl_js_3.SetInputValueByIdInDiv)(this.divName4Edit, "txtHeadphoto", value);
        }
        /**
        * Headphoto (Used In PutDataToClass())
        **/
        get headphoto() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetInputValueInDiv)(this.divName4Edit, "txtHeadphoto");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 住宅电话 (Used In Clear())
        **/
        set homePhone(value) {
            (0, clsCommFunc4Ctrl_js_3.SetInputValueByIdInDiv)(this.divName4Edit, "txtHomePhone", value);
        }
        /**
        * 住宅电话 (Used In PutDataToClass())
        **/
        get homePhone() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetInputValueInDiv)(this.divName4Edit, "txtHomePhone");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 行政班流水号 (Used In Clear())
        **/
        set id_AdminCls(value) {
            (0, clsCommFunc4Ctrl_js_3.SetSelectValueByIdInDiv)(this.divName4Edit, "ddlid_AdminCls", value);
        }
        /**
        * 行政班流水号 (Used In PutDataToClass())
        **/
        get id_AdminCls() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetSelectValueInDiv)(this.divName4Edit, "ddlid_AdminCls");
            if (strValue == undefined)
                return "";
            else if (strValue == "0")
                return "";
            else
                return strValue;
        }
        /**
        * 内卡号 (Used In Clear())
        **/
        set id_CardNo(value) {
            (0, clsCommFunc4Ctrl_js_3.SetInputValueByIdInDiv)(this.divName4Edit, "txtId_CardNo", value);
        }
        /**
        * 内卡号 (Used In PutDataToClass())
        **/
        get id_CardNo() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetInputValueInDiv)(this.divName4Edit, "txtId_CardNo");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 民族流水号 (Used In Clear())
        **/
        set id_Ethnic(value) {
            (0, clsCommFunc4Ctrl_js_3.SetInputValueByIdInDiv)(this.divName4Edit, "txtid_Ethnic", value);
        }
        /**
        * 民族流水号 (Used In PutDataToClass())
        **/
        get id_Ethnic() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetInputValueInDiv)(this.divName4Edit, "txtid_Ethnic");
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
        * 政治面貌流水号 (Used In Clear())
        **/
        set id_Politics(value) {
            (0, clsCommFunc4Ctrl_js_3.SetInputValueByIdInDiv)(this.divName4Edit, "txtid_Politics", value);
        }
        /**
        * 政治面貌流水号 (Used In PutDataToClass())
        **/
        get id_Politics() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetInputValueInDiv)(this.divName4Edit, "txtid_Politics");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 性别流水号 (Used In Clear())
        **/
        set id_Sex(value) {
            (0, clsCommFunc4Ctrl_js_3.SetInputValueByIdInDiv)(this.divName4Edit, "txtid_Sex", value);
        }
        /**
        * 性别流水号 (Used In PutDataToClass())
        **/
        get id_Sex() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetInputValueInDiv)(this.divName4Edit, "txtid_Sex");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 学生流水号 (Used In Clear())
        **/
        set id_StudentInfo(value) {
            (0, clsCommFunc4Ctrl_js_3.SetInputValueByIdInDiv)(this.divName4Edit, "txtid_StudentInfo", value);
        }
        /**
        * 学生流水号 (Used In PutDataToClass())
        **/
        get id_StudentInfo() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetInputValueInDiv)(this.divName4Edit, "txtid_StudentInfo");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 学生类别流水号 (Used In Clear())
        **/
        set id_StuType(value) {
            (0, clsCommFunc4Ctrl_js_3.SetSelectValueByIdInDiv)(this.divName4Edit, "ddlid_StuType", value);
        }
        /**
        * 学生类别流水号 (Used In PutDataToClass())
        **/
        get id_StuType() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetSelectValueInDiv)(this.divName4Edit, "ddlid_StuType");
            if (strValue == undefined)
                return "";
            else if (strValue == "0")
                return "";
            else
                return strValue;
        }
        /**
        * 校区流水号 (Used In Clear())
        **/
        set id_UniZone(value) {
            (0, clsCommFunc4Ctrl_js_3.SetInputValueByIdInDiv)(this.divName4Edit, "txtid_UniZone", value);
        }
        /**
        * 校区流水号 (Used In PutDataToClass())
        **/
        get id_UniZone() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetInputValueInDiv)(this.divName4Edit, "txtid_UniZone");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
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
        * 身份证号 (Used In Clear())
        **/
        set idCardNo(value) {
            (0, clsCommFunc4Ctrl_js_3.SetInputValueByIdInDiv)(this.divName4Edit, "txtIDCardNo", value);
        }
        /**
        * 身份证号 (Used In PutDataToClass())
        **/
        get idCardNo() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetInputValueInDiv)(this.divName4Edit, "txtIDCardNo");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * IsAvconClassUser (Used In Clear())
        **/
        set isAvconClassUser(value) {
            (0, clsCommFunc4Ctrl_js_3.SetCheckBoxValueByIdInDiv)(this.divName4Edit, "chkIsAvconClassUser", value);
        }
        /**
        * IsAvconClassUser (Used In PutDataToClass())
        **/
        get isAvconClassUser() {
            const bolValue = (0, clsCommFunc4Ctrl_js_3.GetCheckBoxValueInDiv)(this.divName4Edit, "chkIsAvconClassUser");
            return bolValue;
        }
        /**
        * IsAvconUser (Used In Clear())
        **/
        set isAvconUser(value) {
            (0, clsCommFunc4Ctrl_js_3.SetCheckBoxValueByIdInDiv)(this.divName4Edit, "chkIsAvconUser", value);
        }
        /**
        * IsAvconUser (Used In PutDataToClass())
        **/
        get isAvconUser() {
            const bolValue = (0, clsCommFunc4Ctrl_js_3.GetCheckBoxValueInDiv)(this.divName4Edit, "chkIsAvconUser");
            return bolValue;
        }
        /**
        * 是否Gp用户 (Used In Clear())
        **/
        set isGpUser(value) {
            (0, clsCommFunc4Ctrl_js_3.SetCheckBoxValueByIdInDiv)(this.divName4Edit, "chkIsGpUser", value);
        }
        /**
        * 是否Gp用户 (Used In PutDataToClass())
        **/
        get isGpUser() {
            const bolValue = (0, clsCommFunc4Ctrl_js_3.GetCheckBoxValueInDiv)(this.divName4Edit, "chkIsGpUser");
            return bolValue;
        }
        /**
        * IsLeaved (Used In Clear())
        **/
        set isLeaved(value) {
            (0, clsCommFunc4Ctrl_js_3.SetCheckBoxValueByIdInDiv)(this.divName4Edit, "chkIsLeaved", value);
        }
        /**
        * IsLeaved (Used In PutDataToClass())
        **/
        get isLeaved() {
            const bolValue = (0, clsCommFunc4Ctrl_js_3.GetCheckBoxValueInDiv)(this.divName4Edit, "chkIsLeaved");
            return bolValue;
        }
        /**
        * IsMessage (Used In Clear())
        **/
        set isMessage(value) {
            (0, clsCommFunc4Ctrl_js_3.SetCheckBoxValueByIdInDiv)(this.divName4Edit, "chkIsMessage", value);
        }
        /**
        * IsMessage (Used In PutDataToClass())
        **/
        get isMessage() {
            const bolValue = (0, clsCommFunc4Ctrl_js_3.GetCheckBoxValueInDiv)(this.divName4Edit, "chkIsMessage");
            return bolValue;
        }
        /**
        * 居住地址 (Used In Clear())
        **/
        set liveAddress(value) {
            (0, clsCommFunc4Ctrl_js_3.SetInputValueByIdInDiv)(this.divName4Edit, "txtLiveAddress", value);
        }
        /**
        * 居住地址 (Used In PutDataToClass())
        **/
        get liveAddress() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetInputValueInDiv)(this.divName4Edit, "txtLiveAddress");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
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
        * Microblog (Used In Clear())
        **/
        set microblog(value) {
            (0, clsCommFunc4Ctrl_js_3.SetInputValueByIdInDiv)(this.divName4Edit, "txtMicroblog", value);
        }
        /**
        * Microblog (Used In PutDataToClass())
        **/
        get microblog() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetInputValueInDiv)(this.divName4Edit, "txtMicroblog");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 籍贯 (Used In Clear())
        **/
        set nativePlace(value) {
            (0, clsCommFunc4Ctrl_js_3.SetInputValueByIdInDiv)(this.divName4Edit, "txtNativePlace", value);
        }
        /**
        * 籍贯 (Used In PutDataToClass())
        **/
        get nativePlace() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetInputValueInDiv)(this.divName4Edit, "txtNativePlace");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * PhoneNumber (Used In Clear())
        **/
        set phoneNumber(value) {
            (0, clsCommFunc4Ctrl_js_3.SetInputValueByIdInDiv)(this.divName4Edit, "txtPhoneNumber", value);
        }
        /**
        * PhoneNumber (Used In PutDataToClass())
        **/
        get phoneNumber() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetInputValueInDiv)(this.divName4Edit, "txtPhoneNumber");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 邮编 (Used In Clear())
        **/
        set postCode(value) {
            (0, clsCommFunc4Ctrl_js_3.SetInputValueByIdInDiv)(this.divName4Edit, "txtPostCode", value);
        }
        /**
        * 邮编 (Used In PutDataToClass())
        **/
        get postCode() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetInputValueInDiv)(this.divName4Edit, "txtPostCode");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * QQ (Used In Clear())
        **/
        set qQ(value) {
            (0, clsCommFunc4Ctrl_js_3.SetInputValueByIdInDiv)(this.divName4Edit, "txtQQ", value);
        }
        /**
        * QQ (Used In PutDataToClass())
        **/
        get qQ() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetInputValueInDiv)(this.divName4Edit, "txtQQ");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * RegisterPassword (Used In Clear())
        **/
        set registerPassword(value) {
            (0, clsCommFunc4Ctrl_js_3.SetInputValueByIdInDiv)(this.divName4Edit, "txtRegisterPassword", value);
        }
        /**
        * RegisterPassword (Used In PutDataToClass())
        **/
        get registerPassword() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetInputValueInDiv)(this.divName4Edit, "txtRegisterPassword");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 学生证号 (Used In Clear())
        **/
        set stuCardNo(value) {
            (0, clsCommFunc4Ctrl_js_3.SetInputValueByIdInDiv)(this.divName4Edit, "txtStuCardNo", value);
        }
        /**
        * 学生证号 (Used In PutDataToClass())
        **/
        get stuCardNo() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetInputValueInDiv)(this.divName4Edit, "txtStuCardNo");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 学号 (Used In Clear())
        **/
        set stuID(value) {
            (0, clsCommFunc4Ctrl_js_3.SetInputValueByIdInDiv)(this.divName4Edit, "txtStuID", value);
        }
        /**
        * 学号 (Used In PutDataToClass())
        **/
        get stuID() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetInputValueInDiv)(this.divName4Edit, "txtStuID");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 姓名 (Used In Clear())
        **/
        set stuName(value) {
            (0, clsCommFunc4Ctrl_js_3.SetInputValueByIdInDiv)(this.divName4Edit, "txtStuName", value);
        }
        /**
        * 姓名 (Used In PutDataToClass())
        **/
        get stuName() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetInputValueInDiv)(this.divName4Edit, "txtStuName");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
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
        * UserID4Avcon (Used In Clear())
        **/
        set userID4Avcon(value) {
            (0, clsCommFunc4Ctrl_js_3.SetInputValueByIdInDiv)(this.divName4Edit, "txtUserID4Avcon", value);
        }
        /**
        * UserID4Avcon (Used In PutDataToClass())
        **/
        get userID4Avcon() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetInputValueInDiv)(this.divName4Edit, "txtUserID4Avcon");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
    }
    exports.StudentInfo_Edit = StudentInfo_Edit;
    StudentInfo_Edit.strPageDispModeId = "01"; //PopupBox(弹出框)
});
