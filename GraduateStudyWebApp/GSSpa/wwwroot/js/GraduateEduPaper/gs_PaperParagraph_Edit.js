(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L0_Entity/GraduateEduPaper/clsgs_PaperParagraphEN.js", "../TS/L0_Entity/GraduateEduPaper/clsvgs_PaperParagraphEN.js", "../TS/L0_Entity/ParameterTable/clsgs_ParagraphTypeEN.js", "../TS/L0_Entity/PrjMenu/clsPageDispModeEN.js", "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperParagraphWApi.js", "../TS/L3_ForWApi/ParameterTable/clsgs_ParagraphTypeWApi.js", "../TS/PubFun/clsCommonFunc4Web2.js", "../TS/PubFun/clsString2.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_PaperParagraph_Edit = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:gs_PaperParagraph_Edit(界面:gs_PaperParagraphCRUD)
    表名:gs_PaperParagraph(01120744)
    生成代码版本:2021.06.06.1
    生成日期:2021/06/10 18:15:56
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
    const clsgs_PaperParagraphEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsgs_PaperParagraphEN.js");
    const clsvgs_PaperParagraphEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsvgs_PaperParagraphEN.js");
    const clsgs_ParagraphTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsgs_ParagraphTypeEN.js");
    const clsPageDispModeEN_js_1 = require("../TS/L0_Entity/PrjMenu/clsPageDispModeEN.js");
    const clsgs_PaperParagraphWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperParagraphWApi.js");
    const clsgs_ParagraphTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsgs_ParagraphTypeWApi.js");
    const clsCommonFunc4Web2_js_1 = require("../TS/PubFun/clsCommonFunc4Web2.js");
    const clsString2_js_1 = require("../TS/PubFun/clsString2.js");
    /* gs_PaperParagraph_Edit 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:GeneCode)
   */
    class gs_PaperParagraph_Edit {
        constructor(objShowList) {
            this.bolIsLoadEditRegion = false; //记录是否导入编辑区的变量
            this.bolIsUseInDiv = true; //是否使用层来处理相关的控件，否则会出现同一界面控件Id同名而不能正确处理的情况
            this.divName4Edit = "divEdit"; //编辑区的Id
            this.iShowList = objShowList;
            gs_PaperParagraph_Edit.objPage_Edit = this;
            this.objgs_PaperParagraph = new clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN();
        }
        /// <summary>
        /// 在当前界面中，导入编辑区域
        /// (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Edit)
        /// </summary>
        /// <returns></returns>
        async AddDPV_Edit(divName4Edit) {
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckDivExist(divName4Edit);
            var strUrl = "./gs_PaperParagraph_Edit";
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
        ShowDialog_gs_PaperParagraph(strOp) {
            //检查相关控件是否存在
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "div", "divEditDialog_gs_PaperParagraph");
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "h4", "lblDialogTitle_gs_PaperParagraph");
            if (strOp === "Add") {
                $('#lblDialogTitle_gs_PaperParagraph').html('添加记录');
                //gs_PaperParagraph_EditEx.GetMaxStrId('#txtParagraphId');
            }
            else if (strOp === "Update") {
                $('#lblDialogTitle_gs_PaperParagraph').html('修改记录');
            }
            else if (strOp === "Detail") {
                $('#btnSubmit_gs_PaperParagraph').hide();
                $('#lblDialogTitle_gs_PaperParagraph').html('详细信息');
            }
            ShowDialog('#divEditDialog_gs_PaperParagraph');
        }
        /*
         隐藏对话框
        (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_TS_HideDialog)
        */
        HideDialog_gs_PaperParagraph() {
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "div", "divEditDialog_gs_PaperParagraph");
            HideDialog('#divEditDialog_gs_PaperParagraph');
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
                    if (gs_PaperParagraph_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_gs_PaperParagraph('Add');
                    }
                }
                else {
                    const responseText = await this.AddNewRecord();
                    if (gs_PaperParagraph_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_gs_PaperParagraph('Add');
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
            const ddlParagraphTypeId = await this.SetDdl_ParagraphTypeId(); //编辑区域
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
                    if (gs_PaperParagraph_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_gs_PaperParagraph('Add');
                    }
                }
                else {
                    const responseText = this.AddNewRecordWithMaxId();
                    if (gs_PaperParagraph_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_gs_PaperParagraph('Add');
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
        /// 设置绑定下拉框，针对字段:[paragraphTypeId]
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TS)
        /// </summary>
        async SetDdl_ParagraphTypeId() {
            var objgs_ParagraphType_Cond = new clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN(); //编辑区域
            const ddlParagraphTypeId = await (0, clsgs_ParagraphTypeWApi_js_1.gs_ParagraphType_BindDdl_ParagraphTypeIdInDiv_Cache)(this.divName4Edit, "ddlParagraphTypeId"); //编辑区域
        }
        /// <summary>
        /// 设置绑定下拉框，针对字段:[paragraphTypeId]
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TSInDiv)
        /// </summary>
        async SetDdl_ParagraphTypeIdInDiv() {
            var objgs_ParagraphType_Cond = new clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN(); //编辑区域
            const ddlParagraphTypeId = await (0, clsgs_ParagraphTypeWApi_js_1.gs_ParagraphType_BindDdl_ParagraphTypeIdInDiv_Cache)(this.divName4Edit, "ddlParagraphTypeId"); //编辑区域
        }
        /* 函数功能:为编辑区绑定下拉框
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegionInDiv)
       */
        async BindDdl4EditRegionInDiv() {
            // 在此处放置用户代码以初始化页面
            const ddlParagraphTypeId = await this.SetDdl_ParagraphTypeIdInDiv(); //编辑区域
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
                    if (gs_PaperParagraph_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_gs_PaperParagraph('Update');
                    }
                }
                else {
                    this.UpdateRecord(strKeyId);
                    if (gs_PaperParagraph_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_gs_PaperParagraph('Update');
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
                    if (gs_PaperParagraph_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_gs_PaperParagraph('Update');
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
                    if (gs_PaperParagraph_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_gs_PaperParagraph('Update');
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
            var strCommandText = this.btnSubmit_gs_PaperParagraph;
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
                                    if (gs_PaperParagraph_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                                        this.HideDialog_gs_PaperParagraph();
                                    }
                                    this.iShowList.BindGv(clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN._CurrTabName, "");
                                }
                            });
                        }
                        else {
                            const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    if (gs_PaperParagraph_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                                        this.HideDialog_gs_PaperParagraph();
                                    }
                                    this.iShowList.BindGv(clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN._CurrTabName, "");
                                }
                            });
                        }
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                            var returnBool = jsonData;
                            var strInfo = returnBool ? "修改成功！" : "修改不成功！";
                            strInfo += "(In gs_PaperParagraph_Edit.btnSubmit_Click)";
                            $('#lblResult51').val(strInfo);
                            //显示信息框
                            console.log(strInfo);
                            alert(strInfo);
                            if (returnBool == true) {
                                if (gs_PaperParagraph_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                                    this.HideDialog_gs_PaperParagraph();
                                }
                                this.iShowList.BindGv(clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN._CurrTabName, "");
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
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_Clear)
        /// </summary>	
        Clear() {
        }
        /* 为插入记录做准备工作
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
       */
        async AddNewRecord() {
            this.btnSubmit_gs_PaperParagraph = "确认添加";
            this.btnCancel_gs_PaperParagraph = "取消添加";
            this.Clear();
            //wucgs_PaperParagraphB1.paragraphId = clsgs_PaperParagraphBL.GetMaxStrId_S();
            try {
                const responseText = await (0, clsgs_PaperParagraphWApi_js_1.gs_PaperParagraph_GetMaxStrIdAsync)();
                var returnString = responseText;
                if (returnString == "") {
                    var strInfo = `获取表gs_PaperParagraph的最大关键字为空，不成功，请检查!`;
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    $('#txtParagraphId').val(returnString);
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
            this.btnSubmit_gs_PaperParagraph = "确认添加";
            this.btnCancel_gs_PaperParagraph = "取消添加";
            this.Clear();
            //wucgs_PaperParagraphB1.paragraphId = clsgs_PaperParagraphBL.GetMaxStrId_S();
        }
        /* 函数功能:把界面上的属性数据传到类对象中
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
         <param name = "pobjgs_PaperParagraphEN">数据传输的目的类对象</param>
       */
        PutDataTogs_PaperParagraphClass(pobjgs_PaperParagraphEN) {
            pobjgs_PaperParagraphEN.paragraphTypeId = this.paragraphTypeId; // 段落类型
            pobjgs_PaperParagraphEN.paragraphContent = this.paragraphContent; // 段落内容
            pobjgs_PaperParagraphEN.memo = this.memo; // 备注
        }
        /* 添加新记录，保存函数
        (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
       */
        async AddNewRecordSave() {
            this.DivName = "divAddNewRecordSave";
            var objgs_PaperParagraphEN = new clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN();
            this.PutDataTogs_PaperParagraphClass(objgs_PaperParagraphEN);
            try {
                (0, clsgs_PaperParagraphWApi_js_1.gs_PaperParagraph_CheckPropertyNew)(objgs_PaperParagraphEN);
            }
            catch (e) {
                var strMsg = `检查数据不成功,${e}.`;
                console.error(strMsg);
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                const responseText = await (0, clsgs_PaperParagraphWApi_js_1.gs_PaperParagraph_IsExistAsync)(objgs_PaperParagraphEN.paragraphId);
                var bolIsExist = responseText;
                if (bolIsExist == true) {
                    var strMsg = `添加记录时，关键字：${objgs_PaperParagraphEN.paragraphId}已经存在！`;
                    console.error(strMsg);
                    alert(strMsg);
                    return responseText; //一定要有一个返回值，否则会出错！
                }
                const responseText2 = await (0, clsgs_PaperParagraphWApi_js_1.gs_PaperParagraph_AddNewRecordAsync)(objgs_PaperParagraphEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    //gs_PaperParagraph_ReFreshCache();
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
            var objgs_PaperParagraphEN = new clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN();
            this.PutDataTogs_PaperParagraphClass(objgs_PaperParagraphEN);
            try {
                (0, clsgs_PaperParagraphWApi_js_1.gs_PaperParagraph_CheckPropertyNew)(objgs_PaperParagraphEN);
            }
            catch (e) {
                var strMsg = `检查数据不成功,${e}.`;
                console.error(strMsg);
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                const responseKeyId = await (0, clsgs_PaperParagraphWApi_js_1.gs_PaperParagraph_AddNewRecordWithMaxIdAsync)(objgs_PaperParagraphEN);
                var returnKeyId = responseKeyId;
                if (clsString2_js_1.clsString.IsNullOrEmpty(returnKeyId) == false) {
                    //gs_PaperParagraph_ReFreshCache();
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
         <param name = "strParagraphId">表记录的关键字,显示该表关键字的内容</param>
       */
        async ShowData(strParagraphId) {
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            var objgs_PaperParagraphEN = new clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN();
            try {
                const responseText = await (0, clsgs_PaperParagraphWApi_js_1.gs_PaperParagraph_IsExistAsync)(strParagraphId);
                var returnBool = responseText;
                if (returnBool == false) {
                    var strInfo = `关键字:[${strParagraphId}] 的记录不存在!`;
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
                const responseText = await (0, clsgs_PaperParagraphWApi_js_1.gs_PaperParagraph_GetObjByParagraphIdAsync)(strParagraphId);
                objgs_PaperParagraphEN = responseText;
            }
            catch (e) {
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                console.error(strMsg);
                alert(strMsg);
            }
            //3、用提供的关键字初始化一个类对象；
            this.GetDataFromgs_PaperParagraphClass(objgs_PaperParagraphEN);
        }
        /* 函数功能:把类对象的属性内容显示到界面上
        注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
         如果在设置数据库时,就应该一级字段在前,二级字段在后
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
         <param name = "pobjgs_PaperParagraphEN">表实体类对象</param>
       */
        GetDataFromgs_PaperParagraphClass(pobjgs_PaperParagraphEN) {
            this.paragraphTypeId = pobjgs_PaperParagraphEN.paragraphTypeId; // 段落类型
            this.paragraphContent = pobjgs_PaperParagraphEN.paragraphContent; // 段落内容
            this.memo = pobjgs_PaperParagraphEN.memo; // 备注
        }
        /* 根据关键字获取相应的记录的对象
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
         <param name = "sender">参数列表</param>
       */
        async UpdateRecord(strParagraphId) {
            this.btnSubmit_gs_PaperParagraph = "确认修改";
            this.btnCancel_gs_PaperParagraph = "取消修改";
            this.KeyId = strParagraphId;
            try {
                const responseText = await (0, clsgs_PaperParagraphWApi_js_1.gs_PaperParagraph_GetObjByParagraphIdAsync)(strParagraphId);
                var objgs_PaperParagraphEN = responseText;
                this.objgs_PaperParagraph = objgs_PaperParagraphEN;
                const conGetDataFromClass = await this.GetDataFromgs_PaperParagraphClass(objgs_PaperParagraphEN);
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
            var objgs_PaperParagraphEN = new clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN();
            objgs_PaperParagraphEN.paragraphId = this.KeyId;
            this.PutDataTogs_PaperParagraphClass(objgs_PaperParagraphEN);
            objgs_PaperParagraphEN.sf_UpdFldSetStr = objgs_PaperParagraphEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objgs_PaperParagraphEN.paragraphId == "" || objgs_PaperParagraphEN.paragraphId == undefined) {
                console.error("关键字不能为空!");
                throw "关键字不能为空!";
            }
            try {
                (0, clsgs_PaperParagraphWApi_js_1.gs_PaperParagraph_CheckProperty4Update)(objgs_PaperParagraphEN);
            }
            catch (e) {
                var strMsg = `检查数据不成功,${e}.`;
                console.error(strMsg);
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                const responseText = await (0, clsgs_PaperParagraphWApi_js_1.gs_PaperParagraph_UpdateRecordAsync)(objgs_PaperParagraphEN);
                var returnBool = !!responseText;
                if (returnBool == true) {
                    //gs_PaperParagraph_ReFreshCache();
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
        set btnCancel_gs_PaperParagraph(value) {
            $("#btnCancel_gs_PaperParagraph").html(value);
        }
        /*
        * 获取按钮的标题
       */
        get btnSubmit_gs_PaperParagraph() {
            return $("#btnSubmit_gs_PaperParagraph").html();
        }
        /*
        * 设置确定按钮的标题(Used In AddNewRecord())
       */
        set btnSubmit_gs_PaperParagraph(value) {
            $("#btnSubmit_gs_PaperParagraph").html(value);
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
        set hidSortvgs_PaperParagraphBy(value) {
            $("#hidSortvgs_PaperParagraphBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvgs_PaperParagraphBy() {
            return $("#hidSortvgs_PaperParagraphBy").val();
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
        * 段落内容 (Used In Clear())
       */
        set paragraphContent(value) {
            var objDiv = $(`#${this.divName4Edit}`);
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "input", "txtParagraphContent");
            var strId = `input[id ^= "txtParagraphContent"]`;
            objDiv.find(strId).val(value);
        }
        /*
        * 段落内容 (Used In PutDataToClass())
       */
        get paragraphContent() {
            var objDiv = $(`#${this.divName4Edit}`);
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "input", "txtParagraphContent");
            var strId = `input[id ^= "txtParagraphContent"]`;
            return objDiv.find(strId).val();
        }
        /*
        * 段落类型Id (Used In Clear())
       */
        set paragraphTypeId(value) {
            var objDiv = $(`#${this.divName4Edit}`);
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "select", "ddlParagraphTypeId");
            var strId = `select[id ^= "ddlParagraphTypeId"]`;
            objDiv.find(strId).val(value);
        }
        /*
        * 段落类型Id (Used In PutDataToClass())
       */
        get paragraphTypeId() {
            var objDiv = $(`#${this.divName4Edit}`);
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.CheckControlExist(this.divName4Edit, "select", "ddlParagraphTypeId");
            var strId = `select[id ^= "ddlParagraphTypeId"]`;
            if (objDiv.find(strId).val() == "0")
                return "";
            return objDiv.find(strId).val();
        }
    }
    exports.gs_PaperParagraph_Edit = gs_PaperParagraph_Edit;
    gs_PaperParagraph_Edit.strPageDispModeId = "01"; //PopupBox(弹出框)
});