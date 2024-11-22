(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../TS/PubFun/clsCommFunc4Ctrl.js", "../../TS/PubFun/clsCommFunc4Ctrl.js", "../../TS/L3_ForWApi/CourseLearning_Share/clscc_CourseTypeWApi.js", "../../TS/L3_ForWApi/BaseInfo_Share/clsXzMajorWApi.js", "../../TS/L3_ForWApi/CourseLearning_Share/clscc_CourseWApi.js", "../../TS/PubFun/clsPublocalStorage.js", "../../TS/L3_ForWApi/CourseLearning_Share/clscc_CourseWApi.js", "../../TS/L3_ForWApi/CourseLearning_Share/clscc_CourseWApi.js", "../../TS/L3_ForWApi/CourseLearning_Share/clscc_CourseWApi.js", "../../TS/L3_ForWApi/CourseLearning_Share/clscc_CourseWApi.js", "../../TS/L3_ForWApi/CourseLearning_Share/clscc_CourseWApi.js", "../../TS/L3_ForWApi/CourseLearning_Share/clscc_CourseWApi.js", "../../TS/L0_Entity/CourseLearning_Share/clscc_CourseEN.js", "../../TS/L3_ForWApi/CourseLearning_Share/clscc_CourseWApi.js", "../../TS/L3_ForWApi/CourseLearning_Share/clscc_CourseWApi.js", "../../TS/L3_ForWApi/CourseLearning_Share/clscc_CourseWApi.js", "../../TS/L3_ForWApi/CourseLearning_Share/clscc_CourseWApi.js", "../../TS/PubFun/clsCommFunc4Ctrl.js", "../../TS/PubFun/clsString.js", "../../TS/PubFun/clsDateTime.js", "../../TS/L0_Entity/PrjMenu/clsPageDispModeEN.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.cc_Course_Edit = void 0;
    /**
    * 类名:cc_Course_Edit(界面:cc_CourseCRUD)
    * 表名:cc_Course(01120056)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:58:55
    * 生成者:
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:课程学习(CourseLearning)
    * 框架-层名:WA_编辑区后台_TS(TS)(WA_ViewScript_EditCS_TS)
    * 编程语言:TypeScript
    **/
    //import $ from "jquery";
    const clsCommFunc4Ctrl_js_1 = require("../../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsCommFunc4Ctrl_js_2 = require("../../TS/PubFun/clsCommFunc4Ctrl.js");
    const clscc_CourseTypeWApi_js_1 = require("../../TS/L3_ForWApi/CourseLearning_Share/clscc_CourseTypeWApi.js");
    const clsXzMajorWApi_js_1 = require("../../TS/L3_ForWApi/BaseInfo_Share/clsXzMajorWApi.js");
    const clscc_CourseWApi_js_1 = require("../../TS/L3_ForWApi/CourseLearning_Share/clscc_CourseWApi.js");
    const clsPublocalStorage_js_1 = require("../../TS/PubFun/clsPublocalStorage.js");
    const clscc_CourseWApi_js_2 = require("../../TS/L3_ForWApi/CourseLearning_Share/clscc_CourseWApi.js");
    const clscc_CourseWApi_js_3 = require("../../TS/L3_ForWApi/CourseLearning_Share/clscc_CourseWApi.js");
    const clscc_CourseWApi_js_4 = require("../../TS/L3_ForWApi/CourseLearning_Share/clscc_CourseWApi.js");
    const clscc_CourseWApi_js_5 = require("../../TS/L3_ForWApi/CourseLearning_Share/clscc_CourseWApi.js");
    const clscc_CourseWApi_js_6 = require("../../TS/L3_ForWApi/CourseLearning_Share/clscc_CourseWApi.js");
    const clscc_CourseWApi_js_7 = require("../../TS/L3_ForWApi/CourseLearning_Share/clscc_CourseWApi.js");
    const clscc_CourseEN_js_1 = require("../../TS/L0_Entity/CourseLearning_Share/clscc_CourseEN.js");
    const clscc_CourseWApi_js_8 = require("../../TS/L3_ForWApi/CourseLearning_Share/clscc_CourseWApi.js");
    const clscc_CourseWApi_js_9 = require("../../TS/L3_ForWApi/CourseLearning_Share/clscc_CourseWApi.js");
    const clscc_CourseWApi_js_10 = require("../../TS/L3_ForWApi/CourseLearning_Share/clscc_CourseWApi.js");
    const clscc_CourseWApi_js_11 = require("../../TS/L3_ForWApi/CourseLearning_Share/clscc_CourseWApi.js");
    const clsCommFunc4Ctrl_js_3 = require("../../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsString_js_1 = require("../../TS/PubFun/clsString.js");
    const clsDateTime_js_1 = require("../../TS/PubFun/clsDateTime.js");
    const clsPageDispModeEN_js_1 = require("../../TS/L0_Entity/PrjMenu/clsPageDispModeEN.js");
    /** cc_Course_Edit 的摘要说明。其中Q代表查询,U代表修改
    * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:GeneCode)
    **/
    class cc_Course_Edit {
        constructor(objShowList) {
            this.opType = "";
            this.keyId = "";
            this.bolIsLoadEditRegion = false; //记录是否导入编辑区的变量
            this.divName4Edit = "divEdit"; //编辑区的Id
            this.iShowList = objShowList;
            cc_Course_Edit.objPage_Edit = this;
            this.objcc_Course = new clscc_CourseEN_js_1.clscc_CourseEN();
        }
        /**
        * 在当前界面中，导入编辑区域
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Edit)
        * @returns
        **/
        async AddDPV_Edit(divName4Edit) {
            const strThisFuncName = this.AddDPV_Edit.name;
            (0, clsCommFunc4Ctrl_js_3.CheckDivExist)(divName4Edit);
            const strUrl = "../CourseLearning_Share/cc_Course_Edit";
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
        ShowDialog_cc_Course(strOp) {
            const strThisFuncName = this.ShowDialog_cc_Course.name;
            //检查相关控件是否存在
            (0, clsCommFunc4Ctrl_js_3.CheckControlExist)(this.divName4Edit, "div", "divEditDialog_cc_Course");
            (0, clsCommFunc4Ctrl_js_3.CheckControlExist)(this.divName4Edit, "h4", "lblDialogTitle_cc_Course");
            if (strOp === "Add" || strOp === "AddWithMaxId") {
                (0, clsCommFunc4Ctrl_js_1.SetH4HtmlByIdInDiv)(this.divName4Edit, 'lblDialogTitle_cc_Course', '添加记录');
                //cc_Course_EditEx.GetMaxStrId('#txtCourseId');
            }
            else if (strOp === "Update") {
                (0, clsCommFunc4Ctrl_js_1.SetH4HtmlByIdInDiv)(this.divName4Edit, 'lblDialogTitle_cc_Course', '修改记录');
            }
            else if (strOp === "Detail") {
                const btnSubmit_cc_Course = (0, clsCommFunc4Ctrl_js_2.getButtonObjByIdInDiv)(this.divName4Edit, 'btnSubmit_cc_Course');
                btnSubmit_cc_Course.hidden = true;
                (0, clsCommFunc4Ctrl_js_1.SetH4HtmlByIdInDiv)(this.divName4Edit, 'lblDialogTitle_cc_Course', '详细信息');
            }
            ShowDialog('#divEditDialog_cc_Course');
        }
        /**
        * 隐藏对话框
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_TS_HideDialog)
        **/
        HideDialog_cc_Course() {
            const strThisFuncName = this.HideDialog_cc_Course.name;
            (0, clsCommFunc4Ctrl_js_3.CheckControlExist)(this.divName4Edit, "div", "divEditDialog_cc_Course");
            HideDialog('#divEditDialog_cc_Course');
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
                    this.btnSubmit_cc_Course = "确认添加";
                    this.btnCancel_cc_Course = "取消添加";
                    const responseText = this.AddNewRecord();
                    if (cc_Course_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_cc_Course('Add');
                    }
                }
                else {
                    this.opType = "Add";
                    this.btnSubmit_cc_Course = "确认添加";
                    this.btnCancel_cc_Course = "取消添加";
                    const responseText = await this.AddNewRecord();
                    if (cc_Course_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_cc_Course('Add');
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
                    this.btnSubmit_cc_Course = "确认添加";
                    this.btnCancel_cc_Course = "取消添加";
                    const responseText = this.AddNewRecordWithMaxId();
                    if (cc_Course_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_cc_Course('Add');
                    }
                }
                else {
                    this.opType = "AddWithMaxId";
                    this.btnSubmit_cc_Course = "确认添加";
                    this.btnCancel_cc_Course = "取消添加";
                    const responseText = this.AddNewRecordWithMaxId();
                    if (cc_Course_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_cc_Course('Add');
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
        * 设置绑定下拉框，针对字段:[CourseTypeID]
        * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdlInDiv_TS4TabFeature)
        **/
        async SetDdl_CourseTypeIDInDiv() {
            await (0, clscc_CourseTypeWApi_js_1.cc_CourseType_BindDdl_CourseTypeIDInDiv_Cache)(this.divName4Edit, "ddlCourseTypeID"); //
        }
        /**
        * 设置绑定下拉框，针对字段:[id_XzMajor]
        * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdlInDiv_TS4TabFeature)
        **/
        async SetDdl_id_XzMajorInDiv() {
            await (0, clsXzMajorWApi_js_1.XzMajor_BindDdl_id_XzMajorInDiv_Cache)(this.divName4Edit, "ddlid_XzMajor"); //
        }
        /** 函数功能:为编辑区绑定下拉框
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegionInDiv)
        **/
        async BindDdl4EditRegionInDiv() {
            const strThisFuncName = this.BindDdl4EditRegionInDiv.name;
            // 在此处放置用户代码以初始化页面
            await this.SetDdl_CourseTypeIDInDiv(); //编辑区域
            await this.SetDdl_id_XzMajorInDiv(); //编辑区域
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
                    this.btnSubmit_cc_Course = "确认修改";
                    this.btnCancel_cc_Course = "取消修改";
                    this.UpdateRecord(strKeyId);
                    if (cc_Course_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_cc_Course('Update');
                    }
                }
                else {
                    this.opType = "Update";
                    this.btnSubmit_cc_Course = "确认修改";
                    this.btnCancel_cc_Course = "取消修改";
                    this.UpdateRecord(strKeyId);
                    if (cc_Course_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_cc_Course('Update');
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
                    this.btnSubmit_cc_Course = "确认修改";
                    this.btnCancel_cc_Course = "取消修改";
                    const update = await this.UpdateRecord(strKeyId);
                    if (update == false) {
                        const strMsg = (0, clsString_js_1.Format)("在修改记录时,显示记录数据不成功!");
                        console.error(strMsg);
                        alert(strMsg);
                        return;
                    }
                    if (cc_Course_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_cc_Course('Update');
                    }
                }
                else {
                    this.opType = "Update";
                    this.btnSubmit_cc_Course = "确认修改";
                    this.btnCancel_cc_Course = "取消修改";
                    const update = await this.UpdateRecord(strKeyId);
                    if (update == false) {
                        const strMsg = (0, clsString_js_1.Format)("在修改记录时,显示记录数据不成功!");
                        console.error(strMsg);
                        alert(strMsg);
                        return;
                    }
                    if (cc_Course_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_cc_Course('Update');
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
            const strCommandText = this.btnSubmit_cc_Course;
            try {
                let returnBool = false;
                let returnKeyId = "";
                let strInfo = "";
                let strMsg = "";
                switch (strCommandText) {
                    case "添加":
                        this.btnSubmit_cc_Course = "确认添加";
                        this.btnCancel_cc_Course = "取消添加";
                        await this.AddNewRecord();
                        break;
                    case "确认添加":
                        //这是一个单表的插入的代码,由于逻辑层太简单,
                        //就把逻辑层合并到控制层,
                        if (this.opType == "AddWithMaxId") {
                            returnKeyId = await this.AddNewRecordWithMaxIdSave();
                            if ((0, clsString_js_1.IsNullOrEmpty)(returnKeyId) == false) {
                                if (cc_Course_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                                    this.HideDialog_cc_Course();
                                }
                                this.iShowList.BindGv(clscc_CourseEN_js_1.clscc_CourseEN._CurrTabName, returnKeyId);
                            }
                        }
                        else {
                            returnBool = await this.AddNewRecordSave();
                            if (returnBool == true) {
                                if (cc_Course_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                                    this.HideDialog_cc_Course();
                                }
                                this.iShowList.BindGv(clscc_CourseEN_js_1.clscc_CourseEN._CurrTabName, returnBool.toString());
                            }
                        }
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        returnBool = await this.UpdateRecordSave();
                        strInfo = returnBool ? "修改成功！" : "修改不成功！";
                        strInfo += "(In cc_Course_Edit.btnSubmit_Click)";
                        //显示信息框
                        //console.log(strInfo);
                        alert(strInfo);
                        if (returnBool == true) {
                            if (cc_Course_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                                this.HideDialog_cc_Course();
                            }
                            this.iShowList.BindGv(clscc_CourseEN_js_1.clscc_CourseEN._CurrTabName, returnBool.toString());
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
         * 清除用户自定义控件中，所有控件的值
         * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_Clear)
         **/
        Clear() {
            const strThisFuncName = this.Clear.name;
            this.courseName = "";
            this.courseCode = "";
            this.courseDescription = "";
            $('#ddlCourseTypeID option[0]').attr("selected", "true");
            $('#ddlid_XzMajor option[0]').attr("selected", "true");
            this.isOpen = false;
            this.memo = "";
        }
        /** 为插入记录做准备工作
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
        **/
        async AddNewRecord() {
            const strThisFuncName = this.AddNewRecord.name;
            this.Clear();
            //wuccc_CourseB1.courseId = cc_Course_GetMaxStrId_S();
            try {
                const returnString = await (0, clscc_CourseWApi_js_1.cc_Course_GetMaxStrIdAsync)();
                if (returnString == "") {
                    const strInfo = (0, clsString_js_1.Format)("获取表cc_Course的最大关键字为空，不成功，请检查!");
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    $('#txtCourseId').val(returnString);
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
            //wuccc_CourseB1.courseId = cc_Course_GetMaxStrId_S();
        }
        /** 函数功能:把界面上的属性数据传到类对象中
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
        * @param pobjcc_CourseEN">数据传输的目的类对象</param>
        **/
        async PutDataTocc_CourseClass(pobjcc_CourseEN) {
            const strThisFuncName = this.PutDataTocc_CourseClass.name;
            pobjcc_CourseEN.SetCourseName(this.courseName); // 课程名称
            pobjcc_CourseEN.SetCourseCode(this.courseCode); // 课程代码
            pobjcc_CourseEN.SetCourseDescription(this.courseDescription); // 课程描述
            pobjcc_CourseEN.SetCourseTypeID(this.courseTypeID); // 课程类型
            pobjcc_CourseEN.Setid_XzMajor(this.id_XzMajor); // 专业
            pobjcc_CourseEN.SetIsOpen(this.isOpen); // 是否公开
            pobjcc_CourseEN.SetMemo(this.memo); // 备注
            pobjcc_CourseEN.SetUpdDate(clsDateTime_js_1.clsDateTime.getTodayDateTimeStr(1)); // 修改日期
            pobjcc_CourseEN.SetUpdUserId(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改用户Id
        }
        /** 添加新记录，保存函数
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
        **/
        async AddNewRecordSave() {
            const strThisFuncName = this.AddNewRecordSave.name;
            const objcc_CourseEN = new clscc_CourseEN_js_1.clscc_CourseEN();
            try {
                await this.PutDataTocc_CourseClass(objcc_CourseEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("从界面获取数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                (0, clscc_CourseWApi_js_2.cc_Course_CheckPropertyNew)(objcc_CourseEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("检查数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                //检查唯一性条件
                const bolIsExistCond_CourseId = await this.CheckUniCond4Add_CourseId(objcc_CourseEN);
                if (bolIsExistCond_CourseId == false) {
                    return false;
                }
                let returnBool = false;
                const returnKeyId = await (0, clscc_CourseWApi_js_3.cc_Course_AddNewRecordWithMaxIdAsync)(objcc_CourseEN);
                if ((0, clsString_js_1.IsNullOrEmpty)(returnKeyId) == false) {
                    returnBool = true;
                }
                if (returnBool == true) {
                    (0, clscc_CourseWApi_js_4.cc_Course_ReFreshCache)();
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
        async CheckUniCond4Add_CourseId(objcc_CourseEN) {
            const strThisFuncName = this.CheckUniCond4Add_CourseId.name;
            const strUniquenessCondition = (0, clscc_CourseWApi_js_5.cc_Course_GetUniCondStr_CourseId)(objcc_CourseEN);
            const bolIsExistCondition = await (0, clscc_CourseWApi_js_6.cc_Course_IsExistRecordAsync)(strUniquenessCondition);
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
        async CheckUniCond4Update_CourseId(objcc_CourseEN) {
            const strThisFuncName = this.CheckUniCond4Update_CourseId.name;
            const strUniquenessCondition = (0, clscc_CourseWApi_js_7.cc_Course_GetUniCondStr4Update_CourseId)(objcc_CourseEN);
            const bolIsExistCondition = await (0, clscc_CourseWApi_js_6.cc_Course_IsExistRecordAsync)(strUniquenessCondition);
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
            const objcc_CourseEN = new clscc_CourseEN_js_1.clscc_CourseEN();
            try {
                await this.PutDataTocc_CourseClass(objcc_CourseEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("从界面获取数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                throw (strMsg); //一定要有一个返回值，否则会出错！
            }
            try {
                (0, clscc_CourseWApi_js_2.cc_Course_CheckPropertyNew)(objcc_CourseEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("检查数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                throw (strMsg); //一定要有一个返回值，否则会出错！
            }
            try {
                //检查唯一性条件
                const bolIsExistCond_CourseId = await this.CheckUniCond4Add_CourseId(objcc_CourseEN);
                if (bolIsExistCond_CourseId == false) {
                    return "";
                }
                const responseKeyId = await (0, clscc_CourseWApi_js_3.cc_Course_AddNewRecordWithMaxIdAsync)(objcc_CourseEN);
                const returnKeyId = responseKeyId;
                if ((0, clsString_js_1.IsNullOrEmpty)(returnKeyId) == false) {
                    (0, clscc_CourseWApi_js_4.cc_Course_ReFreshCache)();
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
        * @param strCourseId: 表记录的关键字,显示该表关键字的内容
        **/
        async ShowData(strCourseId) {
            const strThisFuncName = this.ShowData.name;
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            let objcc_CourseEN = new clscc_CourseEN_js_1.clscc_CourseEN();
            try {
                const returnBool = await (0, clscc_CourseWApi_js_8.cc_Course_IsExistAsync)(strCourseId);
                if (returnBool == false) {
                    const strInfo = (0, clsString_js_1.Format)("关键字:[{0}] 的记录不存在!", strCourseId);
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
                const objcc_CourseEN_Const = await (0, clscc_CourseWApi_js_9.cc_Course_GetObjByCourseIdAsync)(strCourseId);
                if (objcc_CourseEN_Const == null) {
                    const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                    console.error(strMsg);
                    alert(strMsg);
                    return;
                }
                objcc_CourseEN = objcc_CourseEN_Const;
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
            //3、用提供的关键字初始化一个类对象；
            this.GetDataFromcc_CourseClass(objcc_CourseEN);
        }
        /** 函数功能:把类对象的属性内容显示到界面上
        * 注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
        * 如果在设置数据库时,就应该一级字段在前,二级字段在后
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
        * @param pobjcc_CourseEN">表实体类对象</param>
        **/
        async GetDataFromcc_CourseClass(pobjcc_CourseEN) {
            const strThisFuncName = this.GetDataFromcc_CourseClass.name;
            this.courseName = pobjcc_CourseEN.courseName; // 课程名称
            this.courseCode = pobjcc_CourseEN.courseCode; // 课程代码
            this.courseDescription = pobjcc_CourseEN.courseDescription; // 课程描述
            this.courseTypeID = pobjcc_CourseEN.courseTypeID; // 课程类型
            this.id_XzMajor = pobjcc_CourseEN.id_XzMajor; // 专业
            this.isOpen = pobjcc_CourseEN.isOpen; // 是否公开
            this.memo = pobjcc_CourseEN.memo; // 备注
        }
        /** 根据关键字获取相应的记录的对象
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
        * @param sender">参数列表</param>
        **/
        async UpdateRecord(strCourseId) {
            const strThisFuncName = this.UpdateRecord.name;
            this.keyId = strCourseId;
            try {
                const objcc_CourseEN_Const = await (0, clscc_CourseWApi_js_9.cc_Course_GetObjByCourseIdAsync)(strCourseId);
                if (objcc_CourseEN_Const == null) {
                    const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                    console.error(strMsg);
                    alert(strMsg);
                    return false;
                }
                this.objcc_Course = objcc_CourseEN_Const;
                const conGetDataFromClass = await this.GetDataFromcc_CourseClass(objcc_CourseEN_Const);
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
            const objcc_CourseEN = new clscc_CourseEN_js_1.clscc_CourseEN();
            objcc_CourseEN.SetCourseId(this.keyId);
            await this.PutDataTocc_CourseClass(objcc_CourseEN);
            objcc_CourseEN.sf_UpdFldSetStr = objcc_CourseEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objcc_CourseEN.courseId == "" || objcc_CourseEN.courseId == undefined) {
                console.error("关键字不能为空!");
                throw "关键字不能为空!";
            }
            try {
                (0, clscc_CourseWApi_js_10.cc_Course_CheckProperty4Update)(objcc_CourseEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("检查数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                //检查唯一性条件
                const bolIsExistCond_CourseId = await this.CheckUniCond4Update_CourseId(objcc_CourseEN);
                if (bolIsExistCond_CourseId == false) {
                    return false;
                }
                const returnBool = await (0, clscc_CourseWApi_js_11.cc_Course_UpdateRecordAsync)(objcc_CourseEN);
                if (returnBool == true) {
                    (0, clscc_CourseWApi_js_4.cc_Course_ReFreshCache)();
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
        set btnCancel_cc_Course(value) {
            (0, clsCommFunc4Ctrl_js_3.SetButtonHtmlByIdInDiv)(this.divName4Edit, "btnCancel_cc_Course", value);
        }
        /**
        * 获取按钮的标题
        **/
        get btnSubmit_cc_Course() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetButtonHtmlInDiv)(this.divName4Edit, "btnSubmit_cc_Course");
            return strValue;
        }
        /**
        * 设置确定按钮的标题(Used In AddNewRecord())
        **/
        set btnSubmit_cc_Course(value) {
            (0, clsCommFunc4Ctrl_js_3.SetButtonHtmlByIdInDiv)(this.divName4Edit, "btnSubmit_cc_Course", value);
        }
        /**
        * 课程代码 (Used In Clear())
        **/
        set courseCode(value) {
            (0, clsCommFunc4Ctrl_js_3.SetInputValueByIdInDiv)(this.divName4Edit, "txtCourseCode", value);
        }
        /**
        * 课程代码 (Used In PutDataToClass())
        **/
        get courseCode() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetInputValueInDiv)(this.divName4Edit, "txtCourseCode");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 课程描述 (Used In Clear())
        **/
        set courseDescription(value) {
            (0, clsCommFunc4Ctrl_js_3.SetInputValueByIdInDiv)(this.divName4Edit, "txtCourseDescription", value);
        }
        /**
        * 课程描述 (Used In PutDataToClass())
        **/
        get courseDescription() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetInputValueInDiv)(this.divName4Edit, "txtCourseDescription");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 课程名称 (Used In Clear())
        **/
        set courseName(value) {
            (0, clsCommFunc4Ctrl_js_3.SetInputValueByIdInDiv)(this.divName4Edit, "txtCourseName", value);
        }
        /**
        * 课程名称 (Used In PutDataToClass())
        **/
        get courseName() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetInputValueInDiv)(this.divName4Edit, "txtCourseName");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 课程类型ID (Used In Clear())
        **/
        set courseTypeID(value) {
            (0, clsCommFunc4Ctrl_js_3.SetSelectValueByIdInDiv)(this.divName4Edit, "ddlCourseTypeID", value);
        }
        /**
        * 课程类型ID (Used In PutDataToClass())
        **/
        get courseTypeID() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetSelectValueInDiv)(this.divName4Edit, "ddlCourseTypeID");
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
        * 是否公开 (Used In Clear())
        **/
        set isOpen(value) {
            (0, clsCommFunc4Ctrl_js_3.SetCheckBoxValueByIdInDiv)(this.divName4Edit, "chkIsOpen", value);
        }
        /**
        * 是否公开 (Used In PutDataToClass())
        **/
        get isOpen() {
            const bolValue = (0, clsCommFunc4Ctrl_js_3.GetCheckBoxValueInDiv)(this.divName4Edit, "chkIsOpen");
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
        * 修改用户Id (Used In PutDataToClass())
        **/
        get updUserId() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetInputValueInDiv)(this.divName4Edit, "txtUpdUserId");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
    }
    exports.cc_Course_Edit = cc_Course_Edit;
    cc_Course_Edit.strPageDispModeId = "01"; //PopupBox(弹出框)
});