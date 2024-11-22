(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L0_Entity/GraduateEduPaper/clsAcademicJournalsEN.js", "../TS/L0_Entity/GraduateEduPaper/clsJournalSubjectCategoryEN.js", "../TS/L0_Entity/GraduateEduPaper/clsJournalSubjectEN.js", "../TS/L0_Entity/PrjMenu/clsPageDispModeEN.js", "../TS/L3_ForWApi/GraduateEduPaper/clsAcademicJournalsWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsJournalSubjectCategoryWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsJournalSubjectWApi.js", "../TS/PubFun/clsCommonFunc4Web2.js", "../TS/PubFun/clsString2.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.AcademicJournals_Edit = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:AcademicJournals_Edit(界面:AcademicJournalsCRUD)
    表名:AcademicJournals(01120929)
    生成代码版本:2021.06.20.1
    生成日期:2021/06/20 17:34:12
    生成者:
    工程名称:问卷调查
    工程ID:0112
    相关数据库:103.116.76.183,9433EduHigh_Jsie
    PrjDataBaseId:0170
    模块中文名:研培论文
    模块英文名:GraduateEduPaper
    框架-层名:WA_编辑区后台_TS(WA_ViewScript_EditCS_TS)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //import * as $ from "jquery";
    //import * as QQ from "q";
    const clsAcademicJournalsEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsAcademicJournalsEN.js");
    const clsJournalSubjectCategoryEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsJournalSubjectCategoryEN.js");
    const clsJournalSubjectEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsJournalSubjectEN.js");
    const clsPageDispModeEN_js_1 = require("../TS/L0_Entity/PrjMenu/clsPageDispModeEN.js");
    const clsAcademicJournalsWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsAcademicJournalsWApi.js");
    const clsJournalSubjectCategoryWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsJournalSubjectCategoryWApi.js");
    const clsJournalSubjectWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsJournalSubjectWApi.js");
    const clsCommonFunc4Web2_js_1 = require("../TS/PubFun/clsCommonFunc4Web2.js");
    const clsString2_js_1 = require("../TS/PubFun/clsString2.js");
    /* AcademicJournals_Edit 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:GeneCode)
   */
    class AcademicJournals_Edit {
        constructor(objShowList) {
            this.bolIsLoadEditRegion = false; //记录是否导入编辑区的变量
            this.bolIsUseInDiv = true; //是否使用层来处理相关的控件，否则会出现同一界面控件Id同名而不能正确处理的情况
            this.divName4Edit = "divEdit"; //编辑区的Id
            this.iShowList = objShowList;
            AcademicJournals_Edit.objPage_Edit = this;
            this.objAcademicJournals = new clsAcademicJournalsEN_js_1.clsAcademicJournalsEN();
        }
        /// <summary>
        /// 在当前界面中，导入编辑区域
        /// (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Edit)
        /// </summary>
        /// <returns></returns>
        async AddDPV_Edit(divName4Edit) {
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckDivExist(divName4Edit);
            var strUrl = "./AcademicJournals_Edit";
            console.log("divName4Edit:(In AddDPV_Edit)" + divName4Edit);
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
        ;
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
       */
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                this.SetEventFunc();
            }
            catch (e) {
                var strMsg = `页面启动不成功,${e}.`;
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /* 函数功能:设置事件函数
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_SetEventFunc)
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
        /*
         显示对话框
        (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_TS_ShowDialog)
        */
        ShowDialog_AcademicJournals(strOp) {
            //检查相关控件是否存在
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "div", "divEditDialog_AcademicJournals");
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "h4", "lblDialogTitle_AcademicJournals");
            if (strOp === "Add") {
                $('#lblDialogTitle_AcademicJournals').html('添加记录');
                //AcademicJournals_EditEx.GetMaxStrId('#txtJournalId');
            }
            else if (strOp === "Update") {
                $('#lblDialogTitle_AcademicJournals').html('修改记录');
            }
            else if (strOp === "Detail") {
                $('#btnSubmit_AcademicJournals').hide();
                $('#lblDialogTitle_AcademicJournals').html('详细信息');
            }
            ShowDialog('#divEditDialog_AcademicJournals');
        }
        /*
         隐藏对话框
        (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_TS_HideDialog)
        */
        HideDialog_AcademicJournals() {
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "div", "divEditDialog_AcademicJournals");
            HideDialog('#divEditDialog_AcademicJournals');
        }
        /* 添加新记录
        (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
       */
        async btnAddNewRecord_Click() {
            this.OpType = "Add";
            try {
                if (this.bolIsLoadEditRegion == false) //
                 {
                    const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                    // 为编辑区绑定下拉框
                    if (this.bolIsUseInDiv == true) {
                        const conBindDdl = await this.BindDdl4EditRegionInDiv();
                    }
                    else {
                        const conBindDdl = await this.BindDdl4EditRegion();
                    }
                    this.SetEventFunc();
                    this.bolIsLoadEditRegion = true; //
                    const responseText = this.AddNewRecord();
                    if (AcademicJournals_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_AcademicJournals('Add');
                    }
                }
                else {
                    const responseText = await this.AddNewRecord();
                    if (AcademicJournals_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_AcademicJournals('Add');
                    }
                }
            }
            catch (e) {
                var strMsg = `添加新记录初始化不成功,${e}.`;
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /* 函数功能:为编辑区绑定下拉框
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegion)
       */
        async BindDdl4EditRegion() {
            // 在此处放置用户代码以初始化页面
            const ddlJournalSubjectCategoryId = await this.SetDdl_JournalSubjectCategoryId(); //编辑区域
            const ddlJournalSubjectId = await this.SetDdl_JournalSubjectId(); //编辑区域
        }
        /* 添加新记录
        (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecordWithMaxId_Click)
       */
        async btnAddNewRecordWithMaxId_Click() {
            this.OpType = "AddWithMaxId";
            try {
                if (this.bolIsLoadEditRegion == false) //
                 {
                    const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                    // 为编辑区绑定下拉框
                    if (this.bolIsUseInDiv == true) {
                        const conBindDdl = await this.BindDdl4EditRegionInDiv();
                    }
                    else {
                        const conBindDdl = await this.BindDdl4EditRegion();
                    }
                    this.SetEventFunc();
                    this.bolIsLoadEditRegion = true; //
                    const responseText = this.AddNewRecordWithMaxId();
                    if (AcademicJournals_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_AcademicJournals('Add');
                    }
                }
                else {
                    const responseText = this.AddNewRecordWithMaxId();
                    if (AcademicJournals_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_AcademicJournals('Add');
                    }
                }
            }
            catch (e) {
                var strMsg = `添加新记录初始化不成功,${e}.`;
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /// <summary>
        /// 设置绑定下拉框，针对字段:[journalSubjectCategoryId]
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TS)
        /// </summary>
        async SetDdl_JournalSubjectCategoryId() {
            var objJournalSubjectCategory_Cond = new clsJournalSubjectCategoryEN_js_1.clsJournalSubjectCategoryEN(); //编辑区域
            const ddlJournalSubjectCategoryId = await (0, clsJournalSubjectCategoryWApi_js_1.JournalSubjectCategory_BindDdl_JournalSubjectCategoryIdInDiv_Cache)(this.divName4Edit, "ddlJournalSubjectCategoryId"); //编辑区域
        }
        /// <summary>
        /// 设置绑定下拉框，针对字段:[journalSubjectCategoryId]
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TSInDiv)
        /// </summary>
        async SetDdl_JournalSubjectCategoryIdInDiv() {
            var objJournalSubjectCategory_Cond = new clsJournalSubjectCategoryEN_js_1.clsJournalSubjectCategoryEN(); //编辑区域
            const ddlJournalSubjectCategoryId = await (0, clsJournalSubjectCategoryWApi_js_1.JournalSubjectCategory_BindDdl_JournalSubjectCategoryIdInDiv_Cache)(this.divName4Edit, "ddlJournalSubjectCategoryId"); //编辑区域
        }
        /// <summary>
        /// 设置绑定下拉框，针对字段:[journalSubjectId]
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TS)
        /// </summary>
        async SetDdl_JournalSubjectId() {
            var objJournalSubject_Cond = new clsJournalSubjectEN_js_1.clsJournalSubjectEN(); //编辑区域
            const ddlJournalSubjectId = await (0, clsJournalSubjectCategoryWApi_js_1.JournalSubjectCategory_BindDdl_JournalSubjectCategoryIdInDiv_Cache)(this.divName4Edit, "ddlJournalSubjectId"); //编辑区域
        }
        /// <summary>
        /// 设置绑定下拉框，针对字段:[journalSubjectId]
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TSInDiv)
        /// </summary>
        async SetDdl_JournalSubjectIdInDiv() {
            var objJournalSubject_Cond = new clsJournalSubjectEN_js_1.clsJournalSubjectEN(); //编辑区域
            const ddlJournalSubjectId = await (0, clsJournalSubjectWApi_js_1.JournalSubject_BindDdl_JournalSubjectIdInDiv_Cache)(this.divName4Edit, "ddlJournalSubjectId"); //编辑区域
        }
        /* 函数功能:为编辑区绑定下拉框
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegionInDiv)
       */
        async BindDdl4EditRegionInDiv() {
            // 在此处放置用户代码以初始化页面
            const ddlJournalSubjectCategoryId = await this.SetDdl_JournalSubjectCategoryIdInDiv(); //编辑区域
            const ddlJournalSubjectId = await this.SetDdl_JournalSubjectIdInDiv(); //编辑区域
        }
        /* 在数据表里修改记录
        (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecordInTab_Click)
       */
        async btnUpdateRecordInTab_Click(strKeyId) {
            this.OpType = "Update";
            if (strKeyId == "") {
                alert("请选择需要修改的记录！");
                return;
            }
            try {
                if (this.bolIsLoadEditRegion == false) //
                 {
                    const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                    // 为编辑区绑定下拉框
                    if (this.bolIsUseInDiv == true) {
                        const conBindDdl = await this.BindDdl4EditRegionInDiv();
                    }
                    else {
                        const conBindDdl = await this.BindDdl4EditRegion();
                    }
                    this.SetEventFunc();
                    this.bolIsLoadEditRegion = true; //
                    this.UpdateRecord(strKeyId);
                    if (AcademicJournals_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_AcademicJournals('Update');
                    }
                }
                else {
                    this.UpdateRecord(strKeyId);
                    if (AcademicJournals_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_AcademicJournals('Update');
                    }
                }
            }
            catch (e) {
                var strMsg = `(errid: WiTsCs0034)在修改记录时出错!请联系管理员!${e}`;
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /* 修改记录
        (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
       */
        async btnUpdateRecord_Click(strKeyId) {
            this.OpType = "Update";
            if (clsString2_js_1.clsString.IsNullOrEmpty(strKeyId) == true) {
                var strMsg = "修改记录的关键字为空，请检查！";
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            try {
                if (this.bolIsLoadEditRegion == false) //
                 {
                    const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                    // 为编辑区绑定下拉框
                    if (this.bolIsUseInDiv == true) {
                        const conBindDdl = await this.BindDdl4EditRegionInDiv();
                    }
                    else {
                        const conBindDdl = await this.BindDdl4EditRegion();
                    }
                    this.SetEventFunc();
                    this.bolIsLoadEditRegion = true; //
                    const update = await this.UpdateRecord(strKeyId);
                    if (update == false) {
                        var strMsg = `在修改记录时,显示记录数据不成功!`;
                        console.error(strMsg);
                        alert(strMsg);
                        return;
                    }
                    if (AcademicJournals_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_AcademicJournals('Update');
                    }
                }
                else {
                    const update = await this.UpdateRecord(strKeyId);
                    if (update == false) {
                        var strMsg = `在修改记录时,显示记录数据不成功!`;
                        console.error(strMsg);
                        alert(strMsg);
                        return;
                    }
                    if (AcademicJournals_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_AcademicJournals('Update');
                    }
                }
            }
            catch (e) {
                var strMsg = `(errid: WiTsCs0034)在修改记录时出错!请联系管理员!${e}`;
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
         具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
       */
        async btnSubmit_Click() {
            var strCommandText = this.btnSubmit_AcademicJournals;
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
                                var returnKeyId = jsonData;
                                if (clsString2_js_1.clsString.IsNullOrEmpty(returnKeyId) == false) {
                                    if (AcademicJournals_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                                        this.HideDialog_AcademicJournals();
                                    }
                                    this.iShowList.BindGv_Cache(clsAcademicJournalsEN_js_1.clsAcademicJournalsEN._CurrTabName, "");
                                }
                            });
                        }
                        else {
                            const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    if (AcademicJournals_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                                        this.HideDialog_AcademicJournals();
                                    }
                                    this.iShowList.BindGv_Cache(clsAcademicJournalsEN_js_1.clsAcademicJournalsEN._CurrTabName, "");
                                }
                            });
                        }
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                            var returnBool = jsonData;
                            var strInfo = returnBool ? "修改成功！" : "修改不成功！";
                            strInfo += "(In AcademicJournals_Edit.btnSubmit_Click)";
                            $('#lblResult51').val(strInfo);
                            //显示信息框
                            console.log(strInfo);
                            alert(strInfo);
                            if (returnBool == true) {
                                if (AcademicJournals_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                                    this.HideDialog_AcademicJournals();
                                }
                                this.iShowList.BindGv_Cache(clsAcademicJournalsEN_js_1.clsAcademicJournalsEN._CurrTabName, "");
                            }
                        });
                        break;
                    default:
                        var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnSubmit_Click())`;
                        console.error(strMsg);
                        alert(strMsg);
                        break;
                }
            }
            catch (e) {
                var strMsg = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /// <summary>
        /// 在用户自定义控件中，设置关键字的值，是否只读
        /// (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_SetKeyReadOnly)
        /// </summary>
        /// <param name = "bolReadonly">是否只读</param>
        SetKeyReadOnly(bolReadonly) {
            $('#txtJournalId').prop['ReadOnly'] = bolReadonly;
        }
        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_Clear)
        /// </summary>	
        Clear() {
        }
        /* 为插入记录做准备工作
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
       */
        async AddNewRecord() {
            this.btnSubmit_AcademicJournals = "确认添加";
            this.btnCancel_AcademicJournals = "取消添加";
            this.Clear();
            //wucAcademicJournalsB1.journalId = clsAcademicJournalsBL.GetMaxStrId_S();
            try {
                const responseText = await (0, clsAcademicJournalsWApi_js_1.AcademicJournals_GetMaxStrIdAsync)();
                var returnString = responseText;
                if (returnString == "") {
                    var strInfo = `获取表AcademicJournals的最大关键字为空，不成功，请检查!`;
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    $('#txtJournalId').val(returnString);
                }
            }
            catch (e) {
                var strMsg = `获取表关键字的最大值不成功,${e}.`;
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /* 为插入记录做准备工作
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxId)
       */
        AddNewRecordWithMaxId() {
            this.btnSubmit_AcademicJournals = "确认添加";
            this.btnCancel_AcademicJournals = "取消添加";
            this.Clear();
            //wucAcademicJournalsB1.journalId = clsAcademicJournalsBL.GetMaxStrId_S();
        }
        /* 函数功能:把界面上的属性数据传到类对象中
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
         <param name = "pobjAcademicJournalsEN">数据传输的目的类对象</param>
       */
        PutDataToAcademicJournalsClass(pobjAcademicJournalsEN) {
            pobjAcademicJournalsEN.journalId = this.journalId; // 期刊Id
            pobjAcademicJournalsEN.journalName = this.journalName; // 期刊名称
            pobjAcademicJournalsEN.journalSubjectCategoryId = this.journalSubjectCategoryId; // 学科门类
            pobjAcademicJournalsEN.journalSubjectId = this.journalSubjectId; // 学科
            pobjAcademicJournalsEN.memo = this.memo; // 备注
        }
        /* 添加新记录，保存函数
        (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
       */
        async AddNewRecordSave() {
            this.DivName = "divAddNewRecordSave";
            var objAcademicJournalsEN = new clsAcademicJournalsEN_js_1.clsAcademicJournalsEN();
            this.PutDataToAcademicJournalsClass(objAcademicJournalsEN);
            try {
                (0, clsAcademicJournalsWApi_js_1.AcademicJournals_CheckPropertyNew)(objAcademicJournalsEN);
            }
            catch (e) {
                var strMsg = `检查数据不成功,${e}.`;
                console.error(strMsg);
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                const responseText = await (0, clsAcademicJournalsWApi_js_1.AcademicJournals_IsExistAsync)(objAcademicJournalsEN.journalId);
                var bolIsExist = responseText;
                if (bolIsExist == true) {
                    var strMsg = `添加记录时，关键字：${objAcademicJournalsEN.journalId}已经存在！`;
                    console.error(strMsg);
                    alert(strMsg);
                    return responseText; //一定要有一个返回值，否则会出错！
                }
                const responseText2 = await (0, clsAcademicJournalsWApi_js_1.AcademicJournals_AddNewRecordAsync)(objAcademicJournalsEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    (0, clsAcademicJournalsWApi_js_1.AcademicJournals_ReFreshCache)();
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
                var strMsg = `添加记录不成功,${e}.`;
                console.error(strMsg);
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
        }
        /* 添加新记录，由后台自动获取最大值的关键字。保存函数
        (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxIdSave)
       */
        async AddNewRecordWithMaxIdSave() {
            this.DivName = "divAddNewRecordWithMaxIdSave";
            var objAcademicJournalsEN = new clsAcademicJournalsEN_js_1.clsAcademicJournalsEN();
            this.PutDataToAcademicJournalsClass(objAcademicJournalsEN);
            try {
                (0, clsAcademicJournalsWApi_js_1.AcademicJournals_CheckPropertyNew)(objAcademicJournalsEN);
            }
            catch (e) {
                var strMsg = `检查数据不成功,${e}.`;
                console.error(strMsg);
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                const responseKeyId = await (0, clsAcademicJournalsWApi_js_1.AcademicJournals_AddNewRecordWithMaxIdAsync)(objAcademicJournalsEN);
                var returnKeyId = responseKeyId;
                if (clsString2_js_1.clsString.IsNullOrEmpty(returnKeyId) == false) {
                    (0, clsAcademicJournalsWApi_js_1.AcademicJournals_ReFreshCache)();
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
                return responseKeyId; //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                var strMsg = `添加记录不成功,${e}.`;
                console.error(strMsg);
                alert(strMsg);
                return false;
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        /* 函数功能:把以该关键字的记录内容显示在界面上,
              在这里是把值传到表控件中
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_ShowData)
         <param name = "strJournalId">表记录的关键字,显示该表关键字的内容</param>
       */
        async ShowData(strJournalId) {
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            var objAcademicJournalsEN = new clsAcademicJournalsEN_js_1.clsAcademicJournalsEN();
            try {
                const responseText = await (0, clsAcademicJournalsWApi_js_1.AcademicJournals_IsExistAsync)(strJournalId);
                var returnBool = responseText;
                if (returnBool == false) {
                    var strInfo = `关键字:[${strJournalId}] 的记录不存在!`;
                    //$('#lblResult1').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                else {
                }
            }
            catch (e) {
                var strMsg = `检查相应关键字的记录存在不成功, ${e}.`;
                console.error(strMsg);
                alert(strMsg);
            }
            try {
                const responseText = await (0, clsAcademicJournalsWApi_js_1.AcademicJournals_GetObjByJournalIdAsync)(strJournalId);
                objAcademicJournalsEN = responseText;
            }
            catch (e) {
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                console.error(strMsg);
                alert(strMsg);
            }
            //3、用提供的关键字初始化一个类对象；
            this.GetDataFromAcademicJournalsClass(objAcademicJournalsEN);
        }
        /* 函数功能:把类对象的属性内容显示到界面上
        注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
         如果在设置数据库时,就应该一级字段在前,二级字段在后
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
         <param name = "pobjAcademicJournalsEN">表实体类对象</param>
       */
        GetDataFromAcademicJournalsClass(pobjAcademicJournalsEN) {
            this.journalId = pobjAcademicJournalsEN.journalId; // 期刊Id
            this.journalName = pobjAcademicJournalsEN.journalName; // 期刊名称
            this.journalSubjectCategoryId = pobjAcademicJournalsEN.journalSubjectCategoryId; // 学科门类
            this.journalSubjectId = pobjAcademicJournalsEN.journalSubjectId; // 学科
            this.memo = pobjAcademicJournalsEN.memo; // 备注
        }
        /* 根据关键字获取相应的记录的对象
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
         <param name = "sender">参数列表</param>
       */
        async UpdateRecord(strJournalId) {
            this.btnSubmit_AcademicJournals = "确认修改";
            this.btnCancel_AcademicJournals = "取消修改";
            this.KeyId = strJournalId;
            try {
                const responseText = await (0, clsAcademicJournalsWApi_js_1.AcademicJournals_GetObjByJournalIdAsync)(strJournalId);
                var objAcademicJournalsEN = responseText;
                this.objAcademicJournals = objAcademicJournalsEN;
                const conGetDataFromClass = await this.GetDataFromAcademicJournalsClass(objAcademicJournalsEN);
                console.log("完成UpdateRecord!");
                return true;
            }
            catch (e) {
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                console.error(strMsg);
                alert(strMsg);
                return false;
            }
        }
        /* 修改记录
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
       */
        async UpdateRecordSave() {
            this.DivName = "divUpdateRecordSave";
            var objAcademicJournalsEN = new clsAcademicJournalsEN_js_1.clsAcademicJournalsEN();
            objAcademicJournalsEN.journalId = this.KeyId;
            this.PutDataToAcademicJournalsClass(objAcademicJournalsEN);
            objAcademicJournalsEN.sf_UpdFldSetStr = objAcademicJournalsEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objAcademicJournalsEN.journalId == "" || objAcademicJournalsEN.journalId == undefined) {
                console.error("关键字不能为空!");
                throw "关键字不能为空!";
            }
            try {
                (0, clsAcademicJournalsWApi_js_1.AcademicJournals_CheckProperty4Update)(objAcademicJournalsEN);
            }
            catch (e) {
                var strMsg = `检查数据不成功,${e}.`;
                console.error(strMsg);
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                const responseText = await (0, clsAcademicJournalsWApi_js_1.AcademicJournals_UpdateRecordAsync)(objAcademicJournalsEN);
                var returnBool = !!responseText;
                if (returnBool == true) {
                    (0, clsAcademicJournalsWApi_js_1.AcademicJournals_ReFreshCache)();
                }
                return returnBool;
            }
            catch (e) {
                var strMsg = `修改记录不成功,${e}.`;
                console.error(strMsg);
                alert(strMsg);
                return false;
            }
        }
        /*
        * 设置取消按钮的标题(Used In AddNewRecord())
       */
        set btnCancel_AcademicJournals(value) {
            $("#btnCancel_AcademicJournals").html(value);
        }
        /*
        * 获取按钮的标题
       */
        get btnSubmit_AcademicJournals() {
            return $("#btnSubmit_AcademicJournals").html();
        }
        /*
        * 设置确定按钮的标题(Used In AddNewRecord())
       */
        set btnSubmit_AcademicJournals(value) {
            $("#btnSubmit_AcademicJournals").html(value);
        }
        /*
        * 添加、修改用的层名
       */
        set DivName(value) {
            $("#hidDivName").val(value);
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
        * 期刊Id (Used In Clear())
       */
        set journalId(value) {
            var objDiv = $(`#${this.divName4Edit}`);
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "input", "txtJournalId");
            var strId = `input[id ^= "txtJournalId"]`;
            objDiv.find(strId).val(value);
        }
        /*
        * 期刊Id (Used In PutDataToClass())
       */
        get journalId() {
            var objDiv = $(`#${this.divName4Edit}`);
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "input", "txtJournalId");
            var strId = `input[id ^= "txtJournalId"]`;
            return objDiv.find(strId).val();
        }
        /*
        * 期刊名称 (Used In Clear())
       */
        set journalName(value) {
            var objDiv = $(`#${this.divName4Edit}`);
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "input", "txtJournalName");
            var strId = `input[id ^= "txtJournalName"]`;
            objDiv.find(strId).val(value);
        }
        /*
        * 期刊名称 (Used In PutDataToClass())
       */
        get journalName() {
            var objDiv = $(`#${this.divName4Edit}`);
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "input", "txtJournalName");
            var strId = `input[id ^= "txtJournalName"]`;
            return objDiv.find(strId).val();
        }
        /*
        * 期刊学科门类Id (Used In Clear())
       */
        set journalSubjectCategoryId(value) {
            var objDiv = $(`#${this.divName4Edit}`);
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "select", "ddlJournalSubjectCategoryId");
            var strId = `select[id ^= "ddlJournalSubjectCategoryId"]`;
            objDiv.find(strId).val(value);
        }
        /*
        * 期刊学科门类Id (Used In PutDataToClass())
       */
        get journalSubjectCategoryId() {
            var objDiv = $(`#${this.divName4Edit}`);
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "select", "ddlJournalSubjectCategoryId");
            var strId = `select[id ^= "ddlJournalSubjectCategoryId"]`;
            if (objDiv.find(strId).val() == "0")
                return "";
            return objDiv.find(strId).val();
        }
        /*
        * 期刊学科Id (Used In Clear())
       */
        set journalSubjectId(value) {
            var objDiv = $(`#${this.divName4Edit}`);
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "select", "ddlJournalSubjectId");
            var strId = `select[id ^= "ddlJournalSubjectId"]`;
            objDiv.find(strId).val(value);
        }
        /*
        * 期刊学科Id (Used In PutDataToClass())
       */
        get journalSubjectId() {
            var objDiv = $(`#${this.divName4Edit}`);
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "select", "ddlJournalSubjectId");
            var strId = `select[id ^= "ddlJournalSubjectId"]`;
            if (objDiv.find(strId).val() == "0")
                return "";
            return objDiv.find(strId).val();
        }
        /*
        * 设置关键字的值(Used In UpdateRecord())
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
        * 备注 (Used In Clear())
       */
        set memo(value) {
            var objDiv = $(`#${this.divName4Edit}`);
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "input", "txtMemo");
            var strId = `input[id ^= "txtMemo"]`;
            objDiv.find(strId).val(value);
        }
        /*
        * 备注 (Used In PutDataToClass())
       */
        get memo() {
            var objDiv = $(`#${this.divName4Edit}`);
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "input", "txtMemo");
            var strId = `input[id ^= "txtMemo"]`;
            return objDiv.find(strId).val();
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
    }
    exports.AcademicJournals_Edit = AcademicJournals_Edit;
    AcademicJournals_Edit.strPageDispModeId = "01"; //PopupBox(弹出框)
});
