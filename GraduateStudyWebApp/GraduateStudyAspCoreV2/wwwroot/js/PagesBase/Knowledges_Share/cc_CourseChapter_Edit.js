(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../TS/PubFun/clsCommFunc4Ctrl.js", "../../TS/PubFun/clsCommFunc4Ctrl.js", "../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js", "../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js", "../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js", "../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js", "../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js", "../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js", "../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js", "../../TS/L0_Entity/Knowledges_Share/clscc_CourseChapterEN.js", "../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js", "../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js", "../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js", "../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js", "../../TS/PubFun/clsCommFunc4Ctrl.js", "../../TS/PubFun/clsString.js", "../../TS/L0_Entity/PrjMenu/clsPageDispModeEN.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.cc_CourseChapter_Edit = void 0;
    /**
    * 类名:cc_CourseChapter_Edit(界面:cc_CourseChapterCRUD)
    * 表名:cc_CourseChapter(01120060)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 03:59:08
    * 生成者:
    工程名称:问卷调查(0112)
    CM工程:游戏化教育平台(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:知识点相关(Knowledges)
    * 框架-层名:WA_编辑区后台_TS(TS)(WA_ViewScript_EditCS_TS)
    * 编程语言:TypeScript
    **/
    //import $ from "jquery";
    const clsCommFunc4Ctrl_js_1 = require("../../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsCommFunc4Ctrl_js_2 = require("../../TS/PubFun/clsCommFunc4Ctrl.js");
    const clscc_CourseChapterWApi_js_1 = require("../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js");
    const clscc_CourseChapterWApi_js_2 = require("../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js");
    const clscc_CourseChapterWApi_js_3 = require("../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js");
    const clscc_CourseChapterWApi_js_4 = require("../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js");
    const clscc_CourseChapterWApi_js_5 = require("../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js");
    const clscc_CourseChapterWApi_js_6 = require("../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js");
    const clscc_CourseChapterWApi_js_7 = require("../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js");
    const clscc_CourseChapterEN_js_1 = require("../../TS/L0_Entity/Knowledges_Share/clscc_CourseChapterEN.js");
    const clscc_CourseChapterWApi_js_8 = require("../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js");
    const clscc_CourseChapterWApi_js_9 = require("../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js");
    const clscc_CourseChapterWApi_js_10 = require("../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js");
    const clscc_CourseChapterWApi_js_11 = require("../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js");
    const clsCommFunc4Ctrl_js_3 = require("../../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsString_js_1 = require("../../TS/PubFun/clsString.js");
    const clsPageDispModeEN_js_1 = require("../../TS/L0_Entity/PrjMenu/clsPageDispModeEN.js");
    /** cc_CourseChapter_Edit 的摘要说明。其中Q代表查询,U代表修改
    * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:GeneCode)
    **/
    class cc_CourseChapter_Edit {
        constructor(objShowList) {
            this.opType = "";
            this.keyId = "";
            this.bolIsLoadEditRegion = false; //记录是否导入编辑区的变量
            this.divName4Edit = "divEdit"; //编辑区的Id
            this.iShowList = objShowList;
            cc_CourseChapter_Edit.objPage_Edit = this;
            this.objcc_CourseChapter = new clscc_CourseChapterEN_js_1.clscc_CourseChapterEN();
        }
        /**
        * 在当前界面中，导入编辑区域
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Edit)
        * @returns
        **/
        async AddDPV_Edit(divName4Edit) {
            const strThisFuncName = this.AddDPV_Edit.name;
            (0, clsCommFunc4Ctrl_js_3.CheckDivExist)(divName4Edit);
            const strUrl = "../Knowledges/cc_CourseChapter_Edit";
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
        ShowDialog_cc_CourseChapter(strOp) {
            const strThisFuncName = this.ShowDialog_cc_CourseChapter.name;
            //检查相关控件是否存在
            (0, clsCommFunc4Ctrl_js_3.CheckControlExist)(this.divName4Edit, "div", "divEditDialog_cc_CourseChapter");
            (0, clsCommFunc4Ctrl_js_3.CheckControlExist)(this.divName4Edit, "h4", "lblDialogTitle_cc_CourseChapter");
            if (strOp === "Add" || strOp === "AddWithMaxId") {
                (0, clsCommFunc4Ctrl_js_1.SetH4HtmlByIdInDiv)(this.divName4Edit, 'lblDialogTitle_cc_CourseChapter', '添加记录');
                //cc_CourseChapter_EditEx.GetMaxStrId('#txtCourseChapterId');
            }
            else if (strOp === "Update") {
                (0, clsCommFunc4Ctrl_js_1.SetH4HtmlByIdInDiv)(this.divName4Edit, 'lblDialogTitle_cc_CourseChapter', '修改记录');
            }
            else if (strOp === "Detail") {
                const btnSubmit_cc_CourseChapter = (0, clsCommFunc4Ctrl_js_2.getButtonObjByIdInDiv)(this.divName4Edit, 'btnSubmit_cc_CourseChapter');
                btnSubmit_cc_CourseChapter.hidden = true;
                (0, clsCommFunc4Ctrl_js_1.SetH4HtmlByIdInDiv)(this.divName4Edit, 'lblDialogTitle_cc_CourseChapter', '详细信息');
            }
            ShowDialog('#divEditDialog_cc_CourseChapter');
        }
        /**
        * 隐藏对话框
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_TS_HideDialog)
        **/
        HideDialog_cc_CourseChapter() {
            const strThisFuncName = this.HideDialog_cc_CourseChapter.name;
            (0, clsCommFunc4Ctrl_js_3.CheckControlExist)(this.divName4Edit, "div", "divEditDialog_cc_CourseChapter");
            HideDialog('#divEditDialog_cc_CourseChapter');
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
                    this.btnSubmit_cc_CourseChapter = "确认添加";
                    this.btnCancel_cc_CourseChapter = "取消添加";
                    const responseText = this.AddNewRecord();
                    if (cc_CourseChapter_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_cc_CourseChapter('Add');
                    }
                }
                else {
                    this.opType = "Add";
                    this.btnSubmit_cc_CourseChapter = "确认添加";
                    this.btnCancel_cc_CourseChapter = "取消添加";
                    const responseText = await this.AddNewRecord();
                    if (cc_CourseChapter_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_cc_CourseChapter('Add');
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
                    this.btnSubmit_cc_CourseChapter = "确认添加";
                    this.btnCancel_cc_CourseChapter = "取消添加";
                    const responseText = this.AddNewRecordWithMaxId();
                    if (cc_CourseChapter_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_cc_CourseChapter('Add');
                    }
                }
                else {
                    this.opType = "AddWithMaxId";
                    this.btnSubmit_cc_CourseChapter = "确认添加";
                    this.btnCancel_cc_CourseChapter = "取消添加";
                    const responseText = this.AddNewRecordWithMaxId();
                    if (cc_CourseChapter_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_cc_CourseChapter('Add');
                    }
                }
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("添加新记录初始化不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /** 函数功能:为编辑区绑定下拉框
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegionInDiv)
        **/
        async BindDdl4EditRegionInDiv() {
            const strThisFuncName = this.BindDdl4EditRegionInDiv.name;
            // 在此处放置用户代码以初始化页面
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
                    this.btnSubmit_cc_CourseChapter = "确认修改";
                    this.btnCancel_cc_CourseChapter = "取消修改";
                    this.UpdateRecord(strKeyId);
                    if (cc_CourseChapter_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_cc_CourseChapter('Update');
                    }
                }
                else {
                    this.opType = "Update";
                    this.btnSubmit_cc_CourseChapter = "确认修改";
                    this.btnCancel_cc_CourseChapter = "取消修改";
                    this.UpdateRecord(strKeyId);
                    if (cc_CourseChapter_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_cc_CourseChapter('Update');
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
                    this.btnSubmit_cc_CourseChapter = "确认修改";
                    this.btnCancel_cc_CourseChapter = "取消修改";
                    const update = await this.UpdateRecord(strKeyId);
                    if (update == false) {
                        const strMsg = (0, clsString_js_1.Format)("在修改记录时,显示记录数据不成功!");
                        console.error(strMsg);
                        alert(strMsg);
                        return;
                    }
                    if (cc_CourseChapter_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_cc_CourseChapter('Update');
                    }
                }
                else {
                    this.opType = "Update";
                    this.btnSubmit_cc_CourseChapter = "确认修改";
                    this.btnCancel_cc_CourseChapter = "取消修改";
                    const update = await this.UpdateRecord(strKeyId);
                    if (update == false) {
                        const strMsg = (0, clsString_js_1.Format)("在修改记录时,显示记录数据不成功!");
                        console.error(strMsg);
                        alert(strMsg);
                        return;
                    }
                    if (cc_CourseChapter_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_cc_CourseChapter('Update');
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
            const strCommandText = this.btnSubmit_cc_CourseChapter;
            try {
                let returnBool = false;
                let returnKeyId = "";
                let strInfo = "";
                let strMsg = "";
                switch (strCommandText) {
                    case "添加":
                        this.btnSubmit_cc_CourseChapter = "确认添加";
                        this.btnCancel_cc_CourseChapter = "取消添加";
                        await this.AddNewRecord();
                        break;
                    case "确认添加":
                        //这是一个单表的插入的代码,由于逻辑层太简单,
                        //就把逻辑层合并到控制层,
                        if (this.opType == "AddWithMaxId") {
                            returnKeyId = await this.AddNewRecordWithMaxIdSave();
                            if ((0, clsString_js_1.IsNullOrEmpty)(returnKeyId) == false) {
                                if (cc_CourseChapter_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                                    this.HideDialog_cc_CourseChapter();
                                }
                                this.iShowList.BindGv(clscc_CourseChapterEN_js_1.clscc_CourseChapterEN._CurrTabName, returnKeyId);
                            }
                        }
                        else {
                            returnBool = await this.AddNewRecordSave();
                            if (returnBool == true) {
                                if (cc_CourseChapter_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                                    this.HideDialog_cc_CourseChapter();
                                }
                                this.iShowList.BindGv(clscc_CourseChapterEN_js_1.clscc_CourseChapterEN._CurrTabName, returnBool.toString());
                            }
                        }
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        returnBool = await this.UpdateRecordSave();
                        strInfo = returnBool ? "修改成功！" : "修改不成功！";
                        strInfo += "(In cc_CourseChapter_Edit.btnSubmit_Click)";
                        //显示信息框
                        //console.log(strInfo);
                        alert(strInfo);
                        if (returnBool == true) {
                            if (cc_CourseChapter_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                                this.HideDialog_cc_CourseChapter();
                            }
                            this.iShowList.BindGv(clscc_CourseChapterEN_js_1.clscc_CourseChapterEN._CurrTabName, returnBool.toString());
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
            this.courseChapterName = "";
            this.chapterName = "";
            this.sectionName = "";
            this.chapterName_Sim = "";
            this.sectionName_Sim = "";
            this.isUse = false;
            this.chapterContent = "";
            this.memo = "";
        }
        /** 为插入记录做准备工作
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
        **/
        async AddNewRecord() {
            const strThisFuncName = this.AddNewRecord.name;
            this.Clear();
            //wuccc_CourseChapterB1.courseChapterId = cc_CourseChapter_GetMaxStrId_S();
            try {
                const returnString = await (0, clscc_CourseChapterWApi_js_1.cc_CourseChapter_GetMaxStrIdAsync)();
                if (returnString == "") {
                    const strInfo = (0, clsString_js_1.Format)("获取表cc_CourseChapter的最大关键字为空，不成功，请检查!");
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    $('#txtCourseChapterId').val(returnString);
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
            //wuccc_CourseChapterB1.courseChapterId = cc_CourseChapter_GetMaxStrId_S();
        }
        /** 函数功能:把界面上的属性数据传到类对象中
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
        * @param pobjcc_CourseChapterEN">数据传输的目的类对象</param>
        **/
        async PutDataTocc_CourseChapterClass(pobjcc_CourseChapterEN) {
            const strThisFuncName = this.PutDataTocc_CourseChapterClass.name;
            pobjcc_CourseChapterEN.SetCourseChapterName(this.courseChapterName); // 课程章节名称
            pobjcc_CourseChapterEN.SetChapterName(this.chapterName); // 章名
            pobjcc_CourseChapterEN.SetSectionName(this.sectionName); // 节名
            pobjcc_CourseChapterEN.SetChapterName_Sim(this.chapterName_Sim); // 章名简称
            pobjcc_CourseChapterEN.SetSectionName_Sim(this.sectionName_Sim); // 节名简称
            pobjcc_CourseChapterEN.SetIsUse(this.isUse); // 是否使用
            pobjcc_CourseChapterEN.SetChapterContent(this.chapterContent); // 章节内容
            pobjcc_CourseChapterEN.SetMemo(this.memo); // 备注
        }
        /** 添加新记录，保存函数
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
        **/
        async AddNewRecordSave() {
            const strThisFuncName = this.AddNewRecordSave.name;
            const objcc_CourseChapterEN = new clscc_CourseChapterEN_js_1.clscc_CourseChapterEN();
            try {
                await this.PutDataTocc_CourseChapterClass(objcc_CourseChapterEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("从界面获取数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                (0, clscc_CourseChapterWApi_js_2.cc_CourseChapter_CheckPropertyNew)(objcc_CourseChapterEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("检查数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                //检查唯一性条件
                const bolIsExistCond_CourseId_CourseChapterName = await this.CheckUniCond4Add_CourseId_CourseChapterName(objcc_CourseChapterEN);
                if (bolIsExistCond_CourseId_CourseChapterName == false) {
                    return false;
                }
                let returnBool = false;
                const returnKeyId = await (0, clscc_CourseChapterWApi_js_3.cc_CourseChapter_AddNewRecordWithMaxIdAsync)(objcc_CourseChapterEN);
                if ((0, clsString_js_1.IsNullOrEmpty)(returnKeyId) == false) {
                    returnBool = true;
                }
                if (returnBool == true) {
                    (0, clscc_CourseChapterWApi_js_4.cc_CourseChapter_ReFreshCache)(cc_CourseChapter_Edit.CourseId_Cache);
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
        async CheckUniCond4Add_CourseId_CourseChapterName(objcc_CourseChapterEN) {
            const strThisFuncName = this.CheckUniCond4Add_CourseId_CourseChapterName.name;
            const strUniquenessCondition = (0, clscc_CourseChapterWApi_js_5.cc_CourseChapter_GetUniCondStr_CourseId_CourseChapterName)(objcc_CourseChapterEN);
            const bolIsExistCondition = await (0, clscc_CourseChapterWApi_js_6.cc_CourseChapter_IsExistRecordAsync)(strUniquenessCondition);
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
        async CheckUniCond4Update_CourseId_CourseChapterName(objcc_CourseChapterEN) {
            const strThisFuncName = this.CheckUniCond4Update_CourseId_CourseChapterName.name;
            const strUniquenessCondition = (0, clscc_CourseChapterWApi_js_7.cc_CourseChapter_GetUniCondStr4Update_CourseId_CourseChapterName)(objcc_CourseChapterEN);
            const bolIsExistCondition = await (0, clscc_CourseChapterWApi_js_6.cc_CourseChapter_IsExistRecordAsync)(strUniquenessCondition);
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
            const objcc_CourseChapterEN = new clscc_CourseChapterEN_js_1.clscc_CourseChapterEN();
            try {
                await this.PutDataTocc_CourseChapterClass(objcc_CourseChapterEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("从界面获取数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                throw (strMsg); //一定要有一个返回值，否则会出错！
            }
            try {
                (0, clscc_CourseChapterWApi_js_2.cc_CourseChapter_CheckPropertyNew)(objcc_CourseChapterEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("检查数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                throw (strMsg); //一定要有一个返回值，否则会出错！
            }
            try {
                //检查唯一性条件
                const bolIsExistCond_CourseId_CourseChapterName = await this.CheckUniCond4Add_CourseId_CourseChapterName(objcc_CourseChapterEN);
                if (bolIsExistCond_CourseId_CourseChapterName == false) {
                    return "";
                }
                const responseKeyId = await (0, clscc_CourseChapterWApi_js_3.cc_CourseChapter_AddNewRecordWithMaxIdAsync)(objcc_CourseChapterEN);
                const returnKeyId = responseKeyId;
                if ((0, clsString_js_1.IsNullOrEmpty)(returnKeyId) == false) {
                    (0, clscc_CourseChapterWApi_js_4.cc_CourseChapter_ReFreshCache)(cc_CourseChapter_Edit.CourseId_Cache);
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
        * @param strCourseChapterId: 表记录的关键字,显示该表关键字的内容
        **/
        async ShowData(strCourseChapterId) {
            const strThisFuncName = this.ShowData.name;
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            let objcc_CourseChapterEN = new clscc_CourseChapterEN_js_1.clscc_CourseChapterEN();
            try {
                const returnBool = await (0, clscc_CourseChapterWApi_js_8.cc_CourseChapter_IsExistAsync)(strCourseChapterId);
                if (returnBool == false) {
                    const strInfo = (0, clsString_js_1.Format)("关键字:[{0}] 的记录不存在!", strCourseChapterId);
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
                const objcc_CourseChapterEN_Const = await (0, clscc_CourseChapterWApi_js_9.cc_CourseChapter_GetObjByCourseChapterIdAsync)(strCourseChapterId);
                if (objcc_CourseChapterEN_Const == null) {
                    const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                    console.error(strMsg);
                    alert(strMsg);
                    return;
                }
                objcc_CourseChapterEN = objcc_CourseChapterEN_Const;
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
            //3、用提供的关键字初始化一个类对象；
            this.GetDataFromcc_CourseChapterClass(objcc_CourseChapterEN);
        }
        /** 函数功能:把类对象的属性内容显示到界面上
        * 注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
        * 如果在设置数据库时,就应该一级字段在前,二级字段在后
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
        * @param pobjcc_CourseChapterEN">表实体类对象</param>
        **/
        async GetDataFromcc_CourseChapterClass(pobjcc_CourseChapterEN) {
            const strThisFuncName = this.GetDataFromcc_CourseChapterClass.name;
            this.courseChapterName = pobjcc_CourseChapterEN.courseChapterName; // 课程章节名称
            this.chapterName = pobjcc_CourseChapterEN.chapterName; // 章名
            this.sectionName = pobjcc_CourseChapterEN.sectionName; // 节名
            this.chapterName_Sim = pobjcc_CourseChapterEN.chapterName_Sim; // 章名简称
            this.sectionName_Sim = pobjcc_CourseChapterEN.sectionName_Sim; // 节名简称
            this.isUse = pobjcc_CourseChapterEN.isUse; // 是否使用
            this.chapterContent = pobjcc_CourseChapterEN.chapterContent; // 章节内容
            this.memo = pobjcc_CourseChapterEN.memo; // 备注
        }
        /** 根据关键字获取相应的记录的对象
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
        * @param sender">参数列表</param>
        **/
        async UpdateRecord(strCourseChapterId) {
            const strThisFuncName = this.UpdateRecord.name;
            this.keyId = strCourseChapterId;
            try {
                const objcc_CourseChapterEN_Const = await (0, clscc_CourseChapterWApi_js_9.cc_CourseChapter_GetObjByCourseChapterIdAsync)(strCourseChapterId);
                if (objcc_CourseChapterEN_Const == null) {
                    const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                    console.error(strMsg);
                    alert(strMsg);
                    return false;
                }
                this.objcc_CourseChapter = objcc_CourseChapterEN_Const;
                const conGetDataFromClass = await this.GetDataFromcc_CourseChapterClass(objcc_CourseChapterEN_Const);
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
            const objcc_CourseChapterEN = new clscc_CourseChapterEN_js_1.clscc_CourseChapterEN();
            objcc_CourseChapterEN.SetCourseChapterId(this.keyId);
            await this.PutDataTocc_CourseChapterClass(objcc_CourseChapterEN);
            objcc_CourseChapterEN.sf_UpdFldSetStr = objcc_CourseChapterEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objcc_CourseChapterEN.courseChapterId == "" || objcc_CourseChapterEN.courseChapterId == undefined) {
                console.error("关键字不能为空!");
                throw "关键字不能为空!";
            }
            try {
                (0, clscc_CourseChapterWApi_js_10.cc_CourseChapter_CheckProperty4Update)(objcc_CourseChapterEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("检查数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                //检查唯一性条件
                const bolIsExistCond_CourseId_CourseChapterName = await this.CheckUniCond4Update_CourseId_CourseChapterName(objcc_CourseChapterEN);
                if (bolIsExistCond_CourseId_CourseChapterName == false) {
                    return false;
                }
                const returnBool = await (0, clscc_CourseChapterWApi_js_11.cc_CourseChapter_UpdateRecordAsync)(objcc_CourseChapterEN);
                if (returnBool == true) {
                    (0, clscc_CourseChapterWApi_js_4.cc_CourseChapter_ReFreshCache)(cc_CourseChapter_Edit.CourseId_Cache);
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
        set btnCancel_cc_CourseChapter(value) {
            (0, clsCommFunc4Ctrl_js_3.SetButtonHtmlByIdInDiv)(this.divName4Edit, "btnCancel_cc_CourseChapter", value);
        }
        /**
        * 获取按钮的标题
        **/
        get btnSubmit_cc_CourseChapter() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetButtonHtmlInDiv)(this.divName4Edit, "btnSubmit_cc_CourseChapter");
            return strValue;
        }
        /**
        * 设置确定按钮的标题(Used In AddNewRecord())
        **/
        set btnSubmit_cc_CourseChapter(value) {
            (0, clsCommFunc4Ctrl_js_3.SetButtonHtmlByIdInDiv)(this.divName4Edit, "btnSubmit_cc_CourseChapter", value);
        }
        /**
        * 章节内容 (Used In Clear())
        **/
        set chapterContent(value) {
            (0, clsCommFunc4Ctrl_js_3.SetInputValueByIdInDiv)(this.divName4Edit, "txtChapterContent", value);
        }
        /**
        * 章节内容 (Used In PutDataToClass())
        **/
        get chapterContent() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetInputValueInDiv)(this.divName4Edit, "txtChapterContent");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 章名 (Used In Clear())
        **/
        set chapterName(value) {
            (0, clsCommFunc4Ctrl_js_3.SetInputValueByIdInDiv)(this.divName4Edit, "txtChapterName", value);
        }
        /**
        * 章名 (Used In PutDataToClass())
        **/
        get chapterName() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetInputValueInDiv)(this.divName4Edit, "txtChapterName");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 章名简称 (Used In Clear())
        **/
        set chapterName_Sim(value) {
            (0, clsCommFunc4Ctrl_js_3.SetInputValueByIdInDiv)(this.divName4Edit, "txtChapterName_Sim", value);
        }
        /**
        * 章名简称 (Used In PutDataToClass())
        **/
        get chapterName_Sim() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetInputValueInDiv)(this.divName4Edit, "txtChapterName_Sim");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 课程章节名称 (Used In Clear())
        **/
        set courseChapterName(value) {
            (0, clsCommFunc4Ctrl_js_3.SetInputValueByIdInDiv)(this.divName4Edit, "txtCourseChapterName", value);
        }
        /**
        * 课程章节名称 (Used In PutDataToClass())
        **/
        get courseChapterName() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetInputValueInDiv)(this.divName4Edit, "txtCourseChapterName");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 是否使用 (Used In Clear())
        **/
        set isUse(value) {
            (0, clsCommFunc4Ctrl_js_3.SetCheckBoxValueByIdInDiv)(this.divName4Edit, "chkIsUse", value);
        }
        /**
        * 是否使用 (Used In PutDataToClass())
        **/
        get isUse() {
            const bolValue = (0, clsCommFunc4Ctrl_js_3.GetCheckBoxValueInDiv)(this.divName4Edit, "chkIsUse");
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
        * 节名 (Used In Clear())
        **/
        set sectionName(value) {
            (0, clsCommFunc4Ctrl_js_3.SetInputValueByIdInDiv)(this.divName4Edit, "txtSectionName", value);
        }
        /**
        * 节名 (Used In PutDataToClass())
        **/
        get sectionName() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetInputValueInDiv)(this.divName4Edit, "txtSectionName");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 节名简称 (Used In Clear())
        **/
        set sectionName_Sim(value) {
            (0, clsCommFunc4Ctrl_js_3.SetInputValueByIdInDiv)(this.divName4Edit, "txtSectionName_Sim", value);
        }
        /**
        * 节名简称 (Used In PutDataToClass())
        **/
        get sectionName_Sim() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetInputValueInDiv)(this.divName4Edit, "txtSectionName_Sim");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
    }
    exports.cc_CourseChapter_Edit = cc_CourseChapter_Edit;
    cc_CourseChapter_Edit.CourseId_Cache = "";
    cc_CourseChapter_Edit.strPageDispModeId = "01"; //PopupBox(弹出框)
});
