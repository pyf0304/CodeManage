(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../TS/L3_ForWApiEx/GraduateEduPaper/clsvPaperSimProExWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js", "../../TS/PubFun/clsPublocalStorage.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperAttentionWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperAttentionWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperAttentionWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperAttentionWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperAttentionWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperAttentionWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperAttentionWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperAttentionWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperAttentionWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperAttentionWApi.js", "../../TS/L0_Entity/GraduateEduPaper/clsgs_PaperAttentionEN.js", "../../TS/PubFun/clsCommFunc4Ctrl.js", "../../TS/PubFun/clsString.js", "../../TS/PubFun/clsDateTime.js", "../../TS/L0_Entity/PrjMenu/clsPageDispModeEN.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_PaperAttention_Edit = void 0;
    /**
    * 类名:gs_PaperAttention_Edit(界面:gs_PaperAttentionCRUD)
    * 表名:gs_PaperAttention(01120748)
    * 版本:2023.02.18.1(服务器:LAPTOP-RAFT5SD9)
    * 日期:2023/02/18 23:31:15
    * 生成者:
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:研培论文(GraduateEduPaper)
    * 框架-层名:WA_编辑区后台_TS(TS)(WA_ViewScript_EditCS_TS)
    * 编程语言:TypeScript
    **/
    //import $ from "jquery";
    const clsvPaperSimProExWApi_js_1 = require("../../TS/L3_ForWApiEx/GraduateEduPaper/clsvPaperSimProExWApi.js");
    const clsgs_PaperGroupWApi_js_1 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js");
    const clsPublocalStorage_js_1 = require("../../TS/PubFun/clsPublocalStorage.js");
    const clsgs_PaperAttentionWApi_js_1 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperAttentionWApi.js");
    const clsgs_PaperAttentionWApi_js_2 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperAttentionWApi.js");
    const clsgs_PaperAttentionWApi_js_3 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperAttentionWApi.js");
    const clsgs_PaperAttentionWApi_js_4 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperAttentionWApi.js");
    const clsgs_PaperAttentionWApi_js_5 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperAttentionWApi.js");
    const clsgs_PaperAttentionWApi_js_6 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperAttentionWApi.js");
    const clsgs_PaperAttentionWApi_js_7 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperAttentionWApi.js");
    const clsgs_PaperAttentionWApi_js_8 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperAttentionWApi.js");
    const clsgs_PaperAttentionWApi_js_9 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperAttentionWApi.js");
    const clsgs_PaperAttentionWApi_js_10 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperAttentionWApi.js");
    const clsgs_PaperAttentionEN_js_1 = require("../../TS/L0_Entity/GraduateEduPaper/clsgs_PaperAttentionEN.js");
    const clsCommFunc4Ctrl_js_1 = require("../../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsString_js_1 = require("../../TS/PubFun/clsString.js");
    const clsDateTime_js_1 = require("../../TS/PubFun/clsDateTime.js");
    const clsPageDispModeEN_js_1 = require("../../TS/L0_Entity/PrjMenu/clsPageDispModeEN.js");
    /** gs_PaperAttention_Edit 的摘要说明。其中Q代表查询,U代表修改
    * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:GeneCode)
    **/
    class gs_PaperAttention_Edit {
        constructor(objShowList) {
            this.opType = "";
            this.keyId = "";
            this.bolIsLoadEditRegion = false; //记录是否导入编辑区的变量
            this.divName4Edit = "divEdit"; //编辑区的Id
            this.iShowList = objShowList;
            gs_PaperAttention_Edit.objPage_Edit = this;
            this.objgs_PaperAttention = new clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN();
        }
        /**
        * 在当前界面中，导入编辑区域
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Edit)
        * @returns
        **/
        async AddDPV_Edit(divName4Edit) {
            const strThisFuncName = this.AddDPV_Edit.name;
            (0, clsCommFunc4Ctrl_js_1.CheckDivExist)(divName4Edit);
            const strUrl = "../GraduateEduPaper/gs_PaperAttention_Edit";
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
        ShowDialog_gs_PaperAttention(strOp) {
            const strThisFuncName = this.ShowDialog_gs_PaperAttention.name;
            //检查相关控件是否存在
            (0, clsCommFunc4Ctrl_js_1.CheckControlExist)(this.divName4Edit, "div", "divEditDialog_gs_PaperAttention");
            (0, clsCommFunc4Ctrl_js_1.CheckControlExist)(this.divName4Edit, "h4", "lblDialogTitle_gs_PaperAttention");
            if (strOp === "Add" || strOp === "AddWithMaxId") {
                $('#lblDialogTitle_gs_PaperAttention').html('添加记录');
                //gs_PaperAttention_EditEx.GetMaxStrId('#txtPaperAttentionId');
            }
            else if (strOp === "Update") {
                $('#lblDialogTitle_gs_PaperAttention').html('修改记录');
            }
            else if (strOp === "Detail") {
                $('#btnSubmit_gs_PaperAttention').hide();
                $('#lblDialogTitle_gs_PaperAttention').html('详细信息');
            }
            ShowDialog('#divEditDialog_gs_PaperAttention');
        }
        /**
        * 隐藏对话框
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_TS_HideDialog)
        **/
        HideDialog_gs_PaperAttention() {
            const strThisFuncName = this.HideDialog_gs_PaperAttention.name;
            (0, clsCommFunc4Ctrl_js_1.CheckControlExist)(this.divName4Edit, "div", "divEditDialog_gs_PaperAttention");
            HideDialog('#divEditDialog_gs_PaperAttention');
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
                    this.btnSubmit_gs_PaperAttention = "确认添加";
                    this.btnCancel_gs_PaperAttention = "取消添加";
                    const responseText = this.AddNewRecord();
                    if (gs_PaperAttention_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_gs_PaperAttention('Add');
                    }
                }
                else {
                    this.opType = "Add";
                    this.btnSubmit_gs_PaperAttention = "确认添加";
                    this.btnCancel_gs_PaperAttention = "取消添加";
                    const responseText = await this.AddNewRecord();
                    if (gs_PaperAttention_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_gs_PaperAttention('Add');
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
                    this.btnSubmit_gs_PaperAttention = "确认添加";
                    this.btnCancel_gs_PaperAttention = "取消添加";
                    const responseText = this.AddNewRecordWithMaxId();
                    if (gs_PaperAttention_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_gs_PaperAttention('Add');
                    }
                }
                else {
                    this.opType = "AddWithMaxId";
                    this.btnSubmit_gs_PaperAttention = "确认添加";
                    this.btnCancel_gs_PaperAttention = "取消添加";
                    const responseText = this.AddNewRecordWithMaxId();
                    if (gs_PaperAttention_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_gs_PaperAttention('Add');
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
        * 设置绑定下拉框，针对字段:[PaperId]
        * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdlInDiv_TS4TabFeature)
        **/
        async SetDdl_PaperIdInDiv(Id_CurrEduCls) {
            await (0, clsvPaperSimProExWApi_js_1.vPaperSimProEx_BindDdl_PaperIdByid_CurrEduClsInDiv_Cache)(this.divName4Edit, "ddlPaperId", Id_CurrEduCls); //
        }
        /**
        * 设置绑定下拉框，针对字段:[PaperGroupId]
        * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdlInDiv_TS4TabFeature)
        **/
        async SetDdl_PaperGroupIdInDiv(UserId) {
            await (0, clsgs_PaperGroupWApi_js_1.gs_PaperGroup_BindDdl_PaperGroupIdByUpdUserInDiv_Cache)(this.divName4Edit, "ddlPaperGroupId", UserId); //
        }
        /** 函数功能:为编辑区绑定下拉框
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegionInDiv)
        **/
        async BindDdl4EditRegionInDiv() {
            const strThisFuncName = this.BindDdl4EditRegionInDiv.name;
            // 在此处放置用户代码以初始化页面
            const strid_CurrEduCls = gs_PaperAttention_Edit.id_CurrEduCls_Static;
            const strUpdUser = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            await this.SetDdl_PaperIdInDiv(strid_CurrEduCls); //编辑区域
            await this.SetDdl_PaperGroupIdInDiv(strUpdUser); //编辑区域
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
                    this.btnSubmit_gs_PaperAttention = "确认修改";
                    this.btnCancel_gs_PaperAttention = "取消修改";
                    const lngKeyId = Number(strKeyId);
                    this.UpdateRecord(lngKeyId);
                    if (gs_PaperAttention_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_gs_PaperAttention('Update');
                    }
                }
                else {
                    this.opType = "Update";
                    this.btnSubmit_gs_PaperAttention = "确认修改";
                    this.btnCancel_gs_PaperAttention = "取消修改";
                    const lngKeyId = Number(strKeyId);
                    this.UpdateRecord(lngKeyId);
                    if (gs_PaperAttention_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_gs_PaperAttention('Update');
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
                    this.btnSubmit_gs_PaperAttention = "确认修改";
                    this.btnCancel_gs_PaperAttention = "取消修改";
                    const lngKeyId = Number(strKeyId);
                    const update = await this.UpdateRecord(lngKeyId);
                    if (update == false) {
                        const strMsg = (0, clsString_js_1.Format)("在修改记录时,显示记录数据不成功!");
                        console.error(strMsg);
                        alert(strMsg);
                        return;
                    }
                    if (gs_PaperAttention_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_gs_PaperAttention('Update');
                    }
                }
                else {
                    this.opType = "Update";
                    this.btnSubmit_gs_PaperAttention = "确认修改";
                    this.btnCancel_gs_PaperAttention = "取消修改";
                    const lngKeyId = Number(strKeyId);
                    const update = await this.UpdateRecord(lngKeyId);
                    if (update == false) {
                        const strMsg = (0, clsString_js_1.Format)("在修改记录时,显示记录数据不成功!");
                        console.error(strMsg);
                        alert(strMsg);
                        return;
                    }
                    if (gs_PaperAttention_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_gs_PaperAttention('Update');
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
            const strCommandText = this.btnSubmit_gs_PaperAttention;
            try {
                let returnBool = false;
                const returnKeyId = 0;
                let strInfo = "";
                let strMsg = "";
                switch (strCommandText) {
                    case "添加":
                        this.btnSubmit_gs_PaperAttention = "确认添加";
                        this.btnCancel_gs_PaperAttention = "取消添加";
                        await this.AddNewRecord();
                        break;
                    case "确认添加":
                        //这是一个单表的插入的代码,由于逻辑层太简单,
                        //就把逻辑层合并到控制层,
                        if (this.opType == "AddWithMaxId") {
                            //const returnKeyId = await this.AddNewRecordWithMaxIdSave();
                            //if (IsNullOrEmpty(returnKeyId) == false)
                            //{
                            //HideDialog_gs_PaperAttention();
                            //this.iShowList.BindGv_Cache(clsgs_PaperAttentionEN._CurrTabName, "");
                            //}
                        }
                        else {
                            returnBool = await this.AddNewRecordSave();
                            if (returnBool == true) {
                                if (gs_PaperAttention_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                                    this.HideDialog_gs_PaperAttention();
                                }
                                this.iShowList.BindGv_Cache(clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN._CurrTabName, returnBool.toString());
                            }
                        }
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        returnBool = await this.UpdateRecordSave();
                        strInfo = returnBool ? "修改成功！" : "修改不成功！";
                        strInfo += "(In gs_PaperAttention_Edit.btnSubmit_Click)";
                        //显示信息框
                        //console.log(strInfo);
                        alert(strInfo);
                        if (returnBool == true) {
                            if (gs_PaperAttention_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                                this.HideDialog_gs_PaperAttention();
                            }
                            this.iShowList.BindGv_Cache(clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN._CurrTabName, returnBool.toString());
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
            $('#ddlPaperId option[0]').attr("selected", "true");
            this.userId = "";
            $('#ddlPaperGroupId option[0]').attr("selected", "true");
            this.meno = "";
        }
        /** 为插入记录做准备工作
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
        **/
        async AddNewRecord() {
            const strThisFuncName = this.AddNewRecord.name;
            this.Clear();
            //wucgs_PaperAttentionB1.paperAttentionId = gs_PaperAttention_GetMaxStrId_S();
        }
        /** 为插入记录做准备工作
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxId)
        **/
        AddNewRecordWithMaxId() {
            const strThisFuncName = this.AddNewRecordWithMaxId.name;
            this.Clear();
            //wucgs_PaperAttentionB1.paperAttentionId = gs_PaperAttention_GetMaxStrId_S();
        }
        /** 函数功能:把界面上的属性数据传到类对象中
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
        * @param pobjgs_PaperAttentionEN">数据传输的目的类对象</param>
        **/
        async PutDataTogs_PaperAttentionClass(pobjgs_PaperAttentionEN) {
            const strThisFuncName = this.PutDataTogs_PaperAttentionClass.name;
            pobjgs_PaperAttentionEN.SetPaperId(this.paperId); // 论文Id
            pobjgs_PaperAttentionEN.SetUserId(this.userId); // 用户ID
            pobjgs_PaperAttentionEN.SetPaperGroupId(this.paperGroupId); // 组Id
            pobjgs_PaperAttentionEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改人
            pobjgs_PaperAttentionEN.SetUpdDate(clsDateTime_js_1.clsDateTime.getTodayDateTimeStr(1)); // 修改日期
            pobjgs_PaperAttentionEN.SetMeno(this.meno); // 备注
        }
        /** 添加新记录，保存函数
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
        **/
        async AddNewRecordSave() {
            const strThisFuncName = this.AddNewRecordSave.name;
            const objgs_PaperAttentionEN = new clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN();
            try {
                await this.PutDataTogs_PaperAttentionClass(objgs_PaperAttentionEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("从界面获取数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                (0, clsgs_PaperAttentionWApi_js_1.gs_PaperAttention_CheckPropertyNew)(objgs_PaperAttentionEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("检查数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                //检查唯一性条件
                const bolIsExistCond_PaperId_UserId = await this.CheckUniCond4Add_PaperId_UserId(objgs_PaperAttentionEN);
                if (bolIsExistCond_PaperId_UserId == false) {
                    return false;
                }
                let returnBool = false;
                returnBool = await (0, clsgs_PaperAttentionWApi_js_2.gs_PaperAttention_AddNewRecordAsync)(objgs_PaperAttentionEN);
                if (returnBool == true) {
                    (0, clsgs_PaperAttentionWApi_js_3.gs_PaperAttention_ReFreshCache)(gs_PaperAttention_Edit.UserId_Cache);
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
        async CheckUniCond4Add_PaperId_UserId(objgs_PaperAttentionEN) {
            const strThisFuncName = this.CheckUniCond4Add_PaperId_UserId.name;
            const strUniquenessCondition = (0, clsgs_PaperAttentionWApi_js_4.gs_PaperAttention_GetUniCondStr_PaperId_UserId)(objgs_PaperAttentionEN);
            const bolIsExistCondition = await (0, clsgs_PaperAttentionWApi_js_5.gs_PaperAttention_IsExistRecordAsync)(strUniquenessCondition);
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
        async CheckUniCond4Update_PaperId_UserId(objgs_PaperAttentionEN) {
            const strThisFuncName = this.CheckUniCond4Update_PaperId_UserId.name;
            const strUniquenessCondition = (0, clsgs_PaperAttentionWApi_js_6.gs_PaperAttention_GetUniCondStr4Update_PaperId_UserId)(objgs_PaperAttentionEN);
            const bolIsExistCondition = await (0, clsgs_PaperAttentionWApi_js_5.gs_PaperAttention_IsExistRecordAsync)(strUniquenessCondition);
            if (bolIsExistCondition == true) {
                const strMsg = (0, clsString_js_1.Format)("不能满足唯一性条件。满足条件：{0}的记录已经存在！", strUniquenessCondition);
                console.error(strMsg);
                alert(strMsg);
                return false;
            }
            return true;
        }
        /** 函数功能:把以该关键字的记录内容显示在界面上,
       * 在这里是把值传到表控件中
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_ShowData)
        * @param lngPaperAttentionId: 表记录的关键字,显示该表关键字的内容
        **/
        async ShowData(lngPaperAttentionId) {
            const strThisFuncName = this.ShowData.name;
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            let objgs_PaperAttentionEN = new clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN();
            try {
                const returnBool = await (0, clsgs_PaperAttentionWApi_js_7.gs_PaperAttention_IsExistAsync)(lngPaperAttentionId);
                if (returnBool == false) {
                    const strInfo = (0, clsString_js_1.Format)("关键字:[{0}] 的记录不存在!", lngPaperAttentionId);
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
                const objgs_PaperAttentionEN_Const = await (0, clsgs_PaperAttentionWApi_js_8.gs_PaperAttention_GetObjByPaperAttentionIdAsync)(lngPaperAttentionId);
                if (objgs_PaperAttentionEN_Const == null) {
                    const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                    console.error(strMsg);
                    alert(strMsg);
                    return;
                }
                objgs_PaperAttentionEN = objgs_PaperAttentionEN_Const;
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
            //3、用提供的关键字初始化一个类对象；
            this.GetDataFromgs_PaperAttentionClass(objgs_PaperAttentionEN);
        }
        /** 函数功能:把类对象的属性内容显示到界面上
        * 注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
        * 如果在设置数据库时,就应该一级字段在前,二级字段在后
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
        * @param pobjgs_PaperAttentionEN">表实体类对象</param>
        **/
        async GetDataFromgs_PaperAttentionClass(pobjgs_PaperAttentionEN) {
            const strThisFuncName = this.GetDataFromgs_PaperAttentionClass.name;
            this.paperId = pobjgs_PaperAttentionEN.paperId; // 论文Id
            this.userId = pobjgs_PaperAttentionEN.userId; // 用户ID
            this.paperGroupId = pobjgs_PaperAttentionEN.paperGroupId; // 组Id
            this.meno = pobjgs_PaperAttentionEN.meno; // 备注
        }
        /** 根据关键字获取相应的记录的对象
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
        * @param sender">参数列表</param>
        **/
        async UpdateRecord(lngPaperAttentionId) {
            const strThisFuncName = this.UpdateRecord.name;
            this.keyId = lngPaperAttentionId.toString();
            try {
                const objgs_PaperAttentionEN_Const = await (0, clsgs_PaperAttentionWApi_js_8.gs_PaperAttention_GetObjByPaperAttentionIdAsync)(lngPaperAttentionId);
                if (objgs_PaperAttentionEN_Const == null) {
                    const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                    console.error(strMsg);
                    alert(strMsg);
                    return false;
                }
                this.objgs_PaperAttention = objgs_PaperAttentionEN_Const;
                const conGetDataFromClass = await this.GetDataFromgs_PaperAttentionClass(objgs_PaperAttentionEN_Const);
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
            const objgs_PaperAttentionEN = new clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN();
            objgs_PaperAttentionEN.SetPaperAttentionId(Number(this.keyId));
            await this.PutDataTogs_PaperAttentionClass(objgs_PaperAttentionEN);
            objgs_PaperAttentionEN.sf_UpdFldSetStr = objgs_PaperAttentionEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objgs_PaperAttentionEN.paperAttentionId == 0 || objgs_PaperAttentionEN.paperAttentionId == undefined) {
                console.error("关键字不能为空!");
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            try {
                (0, clsgs_PaperAttentionWApi_js_9.gs_PaperAttention_CheckProperty4Update)(objgs_PaperAttentionEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("检查数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                //检查唯一性条件
                const bolIsExistCond_PaperId_UserId = await this.CheckUniCond4Update_PaperId_UserId(objgs_PaperAttentionEN);
                if (bolIsExistCond_PaperId_UserId == false) {
                    return false;
                }
                const returnBool = await (0, clsgs_PaperAttentionWApi_js_10.gs_PaperAttention_UpdateRecordAsync)(objgs_PaperAttentionEN);
                if (returnBool == true) {
                    (0, clsgs_PaperAttentionWApi_js_3.gs_PaperAttention_ReFreshCache)(gs_PaperAttention_Edit.UserId_Cache);
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
        set btnCancel_gs_PaperAttention(value) {
            (0, clsCommFunc4Ctrl_js_1.SetButtonHtmlByIdInDiv)(this.divName4Edit, "btnCancel_gs_PaperAttention", value);
        }
        /**
        * 获取按钮的标题
        **/
        get btnSubmit_gs_PaperAttention() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetButtonHtmlInDiv)(this.divName4Edit, "btnSubmit_gs_PaperAttention");
            return strValue;
        }
        /**
        * 设置确定按钮的标题(Used In AddNewRecord())
        **/
        set btnSubmit_gs_PaperAttention(value) {
            (0, clsCommFunc4Ctrl_js_1.SetButtonHtmlByIdInDiv)(this.divName4Edit, "btnSubmit_gs_PaperAttention", value);
        }
        /**
        * 备注 (Used In Clear())
        **/
        set meno(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtMeno", value);
        }
        /**
        * 备注 (Used In PutDataToClass())
        **/
        get meno() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtMeno");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 组Id (Used In Clear())
        **/
        set paperGroupId(value) {
            (0, clsCommFunc4Ctrl_js_1.SetSelectValueByIdInDiv)(this.divName4Edit, "ddlPaperGroupId", value);
        }
        /**
        * 组Id (Used In PutDataToClass())
        **/
        get paperGroupId() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetSelectValueInDiv)(this.divName4Edit, "ddlPaperGroupId");
            if (strValue == undefined)
                return "";
            else if (strValue == "0")
                return "";
            else
                return strValue;
        }
        /**
        * 论文Id (Used In Clear())
        **/
        set paperId(value) {
            (0, clsCommFunc4Ctrl_js_1.SetSelectValueByIdInDiv)(this.divName4Edit, "ddlPaperId", value);
        }
        /**
        * 论文Id (Used In PutDataToClass())
        **/
        get paperId() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetSelectValueInDiv)(this.divName4Edit, "ddlPaperId");
            if (strValue == undefined)
                return "";
            else if (strValue == "0")
                return "";
            else
                return strValue;
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
    }
    exports.gs_PaperAttention_Edit = gs_PaperAttention_Edit;
    gs_PaperAttention_Edit.UserId_Cache = "";
    gs_PaperAttention_Edit.id_CurrEduCls_Static = ""; //定义下拉框条件变量1
    gs_PaperAttention_Edit.strPageDispModeId = "01"; //PopupBox(弹出框)
});
