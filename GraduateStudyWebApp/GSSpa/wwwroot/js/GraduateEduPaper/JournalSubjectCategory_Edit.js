(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L0_Entity/GraduateEduPaper/clsJournalSubjectCategoryEN.js", "../TS/L3_ForWApi/GraduateEduPaper/clsJournalSubjectCategoryWApi.js", "../TS/PubFun/clsCommonFunc4Web2.js", "../TS/PubFun/clsPubSessionStorage.js", "../TS/PubFun/clsString2.js", "../TS/PubFun/clsDateTime.js", "../TS/L0_Entity/PrjMenu/clsPageDispModeEN.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.JournalSubjectCategory_Edit = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:JournalSubjectCategory_Edit(界面:JournalSubjectCategoryCRUD)
    表名:JournalSubjectCategory(01120931)
    生成代码版本:2021.06.19.1
    生成日期:2021/06/20 00:12:22
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
    const clsJournalSubjectCategoryEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsJournalSubjectCategoryEN.js");
    const clsJournalSubjectCategoryWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsJournalSubjectCategoryWApi.js");
    const clsCommonFunc4Web2_js_1 = require("../TS/PubFun/clsCommonFunc4Web2.js");
    const clsPubSessionStorage_js_1 = require("../TS/PubFun/clsPubSessionStorage.js");
    const clsString2_js_1 = require("../TS/PubFun/clsString2.js");
    const clsDateTime_js_1 = require("../TS/PubFun/clsDateTime.js");
    const clsPageDispModeEN_js_1 = require("../TS/L0_Entity/PrjMenu/clsPageDispModeEN.js");
    /* JournalSubjectCategory_Edit 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:GeneCode)
   */
    class JournalSubjectCategory_Edit {
        constructor(objShowList) {
            this.bolIsLoadEditRegion = false; //记录是否导入编辑区的变量
            this.bolIsUseInDiv = true; //是否使用层来处理相关的控件，否则会出现同一界面控件Id同名而不能正确处理的情况
            this.divName4Edit = "divEdit"; //编辑区的Id
            this.iShowList = objShowList;
            JournalSubjectCategory_Edit.objPage_Edit = this;
            this.objJournalSubjectCategory = new clsJournalSubjectCategoryEN_js_1.clsJournalSubjectCategoryEN();
        }
        /// <summary>
        /// 在当前界面中，导入编辑区域
        /// (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Edit)
        /// </summary>
        /// <returns></returns>
        async AddDPV_Edit(divName4Edit) {
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckDivExist(divName4Edit);
            var strUrl = "./JournalSubjectCategory_Edit";
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
        ShowDialog_JournalSubjectCategory(strOp) {
            //检查相关控件是否存在
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "div", "divEditDialog_JournalSubjectCategory");
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "h4", "lblDialogTitle_JournalSubjectCategory");
            if (strOp === "Add") {
                $('#lblDialogTitle_JournalSubjectCategory').html('添加记录');
                //JournalSubjectCategory_EditEx.GetMaxStrId('#txtJournalSubjectCategoryId');
            }
            else if (strOp === "Update") {
                $('#lblDialogTitle_JournalSubjectCategory').html('修改记录');
            }
            else if (strOp === "Detail") {
                $('#btnSubmit_JournalSubjectCategory').hide();
                $('#lblDialogTitle_JournalSubjectCategory').html('详细信息');
            }
            ShowDialog('#divEditDialog_JournalSubjectCategory');
        }
        /*
         隐藏对话框
        (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_TS_HideDialog)
        */
        HideDialog_JournalSubjectCategory() {
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "div", "divEditDialog_JournalSubjectCategory");
            HideDialog('#divEditDialog_JournalSubjectCategory');
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
                    if (JournalSubjectCategory_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_JournalSubjectCategory('Add');
                    }
                }
                else {
                    const responseText = await this.AddNewRecord();
                    if (JournalSubjectCategory_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_JournalSubjectCategory('Add');
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
                    if (JournalSubjectCategory_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_JournalSubjectCategory('Add');
                    }
                }
                else {
                    const responseText = this.AddNewRecordWithMaxId();
                    if (JournalSubjectCategory_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_JournalSubjectCategory('Add');
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
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegionInDiv)
       */
        async BindDdl4EditRegionInDiv() {
            // 在此处放置用户代码以初始化页面
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
                    if (JournalSubjectCategory_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_JournalSubjectCategory('Update');
                    }
                }
                else {
                    this.UpdateRecord(strKeyId);
                    if (JournalSubjectCategory_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_JournalSubjectCategory('Update');
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
                    if (JournalSubjectCategory_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_JournalSubjectCategory('Update');
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
                    if (JournalSubjectCategory_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_JournalSubjectCategory('Update');
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
            var strCommandText = this.btnSubmit_JournalSubjectCategory;
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
                                    if (JournalSubjectCategory_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                                        this.HideDialog_JournalSubjectCategory();
                                    }
                                    this.iShowList.BindGv_Cache(clsJournalSubjectCategoryEN_js_1.clsJournalSubjectCategoryEN._CurrTabName, "");
                                }
                            });
                        }
                        else {
                            const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    if (JournalSubjectCategory_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                                        this.HideDialog_JournalSubjectCategory();
                                    }
                                    this.iShowList.BindGv_Cache(clsJournalSubjectCategoryEN_js_1.clsJournalSubjectCategoryEN._CurrTabName, "");
                                }
                            });
                        }
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                            var returnBool = jsonData;
                            var strInfo = returnBool ? "修改成功！" : "修改不成功！";
                            strInfo += "(In JournalSubjectCategory_Edit.btnSubmit_Click)";
                            $('#lblResult51').val(strInfo);
                            //显示信息框
                            console.log(strInfo);
                            alert(strInfo);
                            if (returnBool == true) {
                                if (JournalSubjectCategory_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                                    this.HideDialog_JournalSubjectCategory();
                                }
                                this.iShowList.BindGv_Cache(clsJournalSubjectCategoryEN_js_1.clsJournalSubjectCategoryEN._CurrTabName, "");
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
            $('#txtJournalSubjectCategoryId').prop['ReadOnly'] = bolReadonly;
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
            this.btnSubmit_JournalSubjectCategory = "确认添加";
            this.btnCancel_JournalSubjectCategory = "取消添加";
            this.Clear();
            //wucJournalSubjectCategoryB1.journalSubjectCategoryId = clsJournalSubjectCategoryBL.GetMaxStrId_S();
            try {
                const responseText = await (0, clsJournalSubjectCategoryWApi_js_1.JournalSubjectCategory_GetMaxStrIdAsync)();
                var returnString = responseText;
                if (returnString == "") {
                    var strInfo = `获取表JournalSubjectCategory的最大关键字为空，不成功，请检查!`;
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    $('#txtJournalSubjectCategoryId').val(returnString);
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
            this.btnSubmit_JournalSubjectCategory = "确认添加";
            this.btnCancel_JournalSubjectCategory = "取消添加";
            this.Clear();
            //wucJournalSubjectCategoryB1.journalSubjectCategoryId = clsJournalSubjectCategoryBL.GetMaxStrId_S();
        }
        /* 函数功能:把界面上的属性数据传到类对象中
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
         <param name = "pobjJournalSubjectCategoryEN">数据传输的目的类对象</param>
       */
        PutDataToJournalSubjectCategoryClass(pobjJournalSubjectCategoryEN) {
            pobjJournalSubjectCategoryEN.journalSubjectCategoryId = this.journalSubjectCategoryId; // 期刊学科门类Id
            pobjJournalSubjectCategoryEN.journalSubjectCategoryName = this.journalSubjectCategoryName; // 期刊学科门类名称
            pobjJournalSubjectCategoryEN.memo = this.memo; // 备注
            pobjJournalSubjectCategoryEN.updDate = clsDateTime_js_1.clsDateTime.getTodayDateTimeStr(1); // 修改日期
            pobjJournalSubjectCategoryEN.updUser = clsPubSessionStorage_js_1.clsPubSessionStorage.userId; // 修改人
        }
        /* 添加新记录，保存函数
        (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
       */
        async AddNewRecordSave() {
            this.DivName = "divAddNewRecordSave";
            var objJournalSubjectCategoryEN = new clsJournalSubjectCategoryEN_js_1.clsJournalSubjectCategoryEN();
            this.PutDataToJournalSubjectCategoryClass(objJournalSubjectCategoryEN);
            try {
                (0, clsJournalSubjectCategoryWApi_js_1.JournalSubjectCategory_CheckPropertyNew)(objJournalSubjectCategoryEN);
            }
            catch (e) {
                var strMsg = `检查数据不成功,${e}.`;
                console.error(strMsg);
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                const responseText = await (0, clsJournalSubjectCategoryWApi_js_1.JournalSubjectCategory_IsExistAsync)(objJournalSubjectCategoryEN.journalSubjectCategoryId);
                var bolIsExist = responseText;
                if (bolIsExist == true) {
                    var strMsg = `添加记录时，关键字：${objJournalSubjectCategoryEN.journalSubjectCategoryId}已经存在！`;
                    console.error(strMsg);
                    alert(strMsg);
                    return responseText; //一定要有一个返回值，否则会出错！
                }
                const responseText2 = await (0, clsJournalSubjectCategoryWApi_js_1.JournalSubjectCategory_AddNewRecordAsync)(objJournalSubjectCategoryEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    (0, clsJournalSubjectCategoryWApi_js_1.JournalSubjectCategory_ReFreshCache)();
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
            var objJournalSubjectCategoryEN = new clsJournalSubjectCategoryEN_js_1.clsJournalSubjectCategoryEN();
            this.PutDataToJournalSubjectCategoryClass(objJournalSubjectCategoryEN);
            try {
                (0, clsJournalSubjectCategoryWApi_js_1.JournalSubjectCategory_CheckPropertyNew)(objJournalSubjectCategoryEN);
            }
            catch (e) {
                var strMsg = `检查数据不成功,${e}.`;
                console.error(strMsg);
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                const responseKeyId = await (0, clsJournalSubjectCategoryWApi_js_1.JournalSubjectCategory_AddNewRecordWithMaxIdAsync)(objJournalSubjectCategoryEN);
                var returnKeyId = responseKeyId;
                if (clsString2_js_1.clsString.IsNullOrEmpty(returnKeyId) == false) {
                    (0, clsJournalSubjectCategoryWApi_js_1.JournalSubjectCategory_ReFreshCache)();
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
         <param name = "strJournalSubjectCategoryId">表记录的关键字,显示该表关键字的内容</param>
       */
        async ShowData(strJournalSubjectCategoryId) {
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            var objJournalSubjectCategoryEN = new clsJournalSubjectCategoryEN_js_1.clsJournalSubjectCategoryEN();
            try {
                const responseText = await (0, clsJournalSubjectCategoryWApi_js_1.JournalSubjectCategory_IsExistAsync)(strJournalSubjectCategoryId);
                var returnBool = responseText;
                if (returnBool == false) {
                    var strInfo = `关键字:[${strJournalSubjectCategoryId}] 的记录不存在!`;
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
                const responseText = await (0, clsJournalSubjectCategoryWApi_js_1.JournalSubjectCategory_GetObjByJournalSubjectCategoryIdAsync)(strJournalSubjectCategoryId);
                objJournalSubjectCategoryEN = responseText;
            }
            catch (e) {
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                console.error(strMsg);
                alert(strMsg);
            }
            //3、用提供的关键字初始化一个类对象；
            this.GetDataFromJournalSubjectCategoryClass(objJournalSubjectCategoryEN);
        }
        /* 函数功能:把类对象的属性内容显示到界面上
        注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
         如果在设置数据库时,就应该一级字段在前,二级字段在后
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
         <param name = "pobjJournalSubjectCategoryEN">表实体类对象</param>
       */
        GetDataFromJournalSubjectCategoryClass(pobjJournalSubjectCategoryEN) {
            this.journalSubjectCategoryId = pobjJournalSubjectCategoryEN.journalSubjectCategoryId; // 期刊学科门类Id
            this.journalSubjectCategoryName = pobjJournalSubjectCategoryEN.journalSubjectCategoryName; // 期刊学科门类名称
            this.memo = pobjJournalSubjectCategoryEN.memo; // 备注
        }
        /* 根据关键字获取相应的记录的对象
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
         <param name = "sender">参数列表</param>
       */
        async UpdateRecord(strJournalSubjectCategoryId) {
            this.btnSubmit_JournalSubjectCategory = "确认修改";
            this.btnCancel_JournalSubjectCategory = "取消修改";
            this.KeyId = strJournalSubjectCategoryId;
            try {
                const responseText = await (0, clsJournalSubjectCategoryWApi_js_1.JournalSubjectCategory_GetObjByJournalSubjectCategoryIdAsync)(strJournalSubjectCategoryId);
                var objJournalSubjectCategoryEN = responseText;
                this.objJournalSubjectCategory = objJournalSubjectCategoryEN;
                const conGetDataFromClass = await this.GetDataFromJournalSubjectCategoryClass(objJournalSubjectCategoryEN);
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
            var objJournalSubjectCategoryEN = new clsJournalSubjectCategoryEN_js_1.clsJournalSubjectCategoryEN();
            objJournalSubjectCategoryEN.journalSubjectCategoryId = this.KeyId;
            this.PutDataToJournalSubjectCategoryClass(objJournalSubjectCategoryEN);
            objJournalSubjectCategoryEN.sf_UpdFldSetStr = objJournalSubjectCategoryEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objJournalSubjectCategoryEN.journalSubjectCategoryId == "" || objJournalSubjectCategoryEN.journalSubjectCategoryId == undefined) {
                console.error("关键字不能为空!");
                throw "关键字不能为空!";
            }
            try {
                (0, clsJournalSubjectCategoryWApi_js_1.JournalSubjectCategory_CheckProperty4Update)(objJournalSubjectCategoryEN);
            }
            catch (e) {
                var strMsg = `检查数据不成功,${e}.`;
                console.error(strMsg);
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                const responseText = await (0, clsJournalSubjectCategoryWApi_js_1.JournalSubjectCategory_UpdateRecordAsync)(objJournalSubjectCategoryEN);
                var returnBool = !!responseText;
                if (returnBool == true) {
                    (0, clsJournalSubjectCategoryWApi_js_1.JournalSubjectCategory_ReFreshCache)();
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
        set btnCancel_JournalSubjectCategory(value) {
            $("#btnCancel_JournalSubjectCategory").html(value);
        }
        /*
        * 获取按钮的标题
       */
        get btnSubmit_JournalSubjectCategory() {
            return $("#btnSubmit_JournalSubjectCategory").html();
        }
        /*
        * 设置确定按钮的标题(Used In AddNewRecord())
       */
        set btnSubmit_JournalSubjectCategory(value) {
            $("#btnSubmit_JournalSubjectCategory").html(value);
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
        set hidSortJournalSubjectCategoryBy(value) {
            $("#hidSortJournalSubjectCategoryBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortJournalSubjectCategoryBy() {
            return $("#hidSortJournalSubjectCategoryBy").val();
        }
        /*
        * 期刊学科门类Id (Used In Clear())
       */
        set journalSubjectCategoryId(value) {
            var objDiv = $(`#${this.divName4Edit}`);
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "input", "txtJournalSubjectCategoryId");
            var strId = `input[id ^= "txtJournalSubjectCategoryId"]`;
            objDiv.find(strId).val(value);
        }
        /*
        * 期刊学科门类Id (Used In PutDataToClass())
       */
        get journalSubjectCategoryId() {
            var objDiv = $(`#${this.divName4Edit}`);
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "input", "txtJournalSubjectCategoryId");
            var strId = `input[id ^= "txtJournalSubjectCategoryId"]`;
            return objDiv.find(strId).val();
        }
        /*
        * 期刊学科门类名称 (Used In Clear())
       */
        set journalSubjectCategoryName(value) {
            var objDiv = $(`#${this.divName4Edit}`);
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "input", "txtJournalSubjectCategoryName");
            var strId = `input[id ^= "txtJournalSubjectCategoryName"]`;
            objDiv.find(strId).val(value);
        }
        /*
        * 期刊学科门类名称 (Used In PutDataToClass())
       */
        get journalSubjectCategoryName() {
            var objDiv = $(`#${this.divName4Edit}`);
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "input", "txtJournalSubjectCategoryName");
            var strId = `input[id ^= "txtJournalSubjectCategoryName"]`;
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
        /*
        * 修改日期 (Used In PutDataToClass())
       */
        get updDate() {
            var objDiv = $(`#${this.divName4Edit}`);
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "input", "txtUpdDate");
            var strId = `input[id ^= "txtUpdDate"]`;
            return objDiv.find(strId).val();
        }
        /*
        * 修改人 (Used In PutDataToClass())
       */
        get updUser() {
            var objDiv = $(`#${this.divName4Edit}`);
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "input", "txtUpdUser");
            var strId = `input[id ^= "txtUpdUser"]`;
            return objDiv.find(strId).val();
        }
    }
    exports.JournalSubjectCategory_Edit = JournalSubjectCategory_Edit;
    JournalSubjectCategory_Edit.strPageDispModeId = "01"; //PopupBox(弹出框)
});
