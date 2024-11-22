(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../TS/L3_ForWApi/GraduateEduPaper/clsSectionWApi.js", "../../TS/L3_ForWApi/ParameterTable/clsSubViewpointTypeWApi.js", "../../TS/L3_ForWApi/ParameterTable/clsExplainTypeWApi.js", "../../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js", "../../TS/L3_ForWApi/ParameterTable/clsgs_PaperSubViewsAttitudesWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubViewpointWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubViewpointWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubViewpointWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubViewpointWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubViewpointWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubViewpointWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubViewpointWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubViewpointWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubViewpointWApi.js", "../../TS/L0_Entity/GraduateEduPaper/clsPaperSubViewpointEN.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubViewpointWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubViewpointWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubViewpointWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubViewpointWApi.js", "../../TS/PubFun/clsCommFunc4Ctrl.js", "../../TS/PubFun/clsString.js", "../../TS/L0_Entity/PrjMenu/clsPageDispModeEN.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.PaperSubViewpoint_Edit = void 0;
    /**
    * 类名:PaperSubViewpoint_Edit(界面:PaperSubViewpointCRUD)
    * 表名:PaperSubViewpoint(01120534)
    * 版本:2023.02.22.1(服务器:WIN-SRV103-116)
    * 日期:2023/02/24 03:27:01
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
    const clsSectionWApi_js_1 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsSectionWApi.js");
    const clsSubViewpointTypeWApi_js_1 = require("../../TS/L3_ForWApi/ParameterTable/clsSubViewpointTypeWApi.js");
    const clsExplainTypeWApi_js_1 = require("../../TS/L3_ForWApi/ParameterTable/clsExplainTypeWApi.js");
    const clsgs_ShareWApi_js_1 = require("../../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js");
    const clsgs_PaperSubViewsAttitudesWApi_js_1 = require("../../TS/L3_ForWApi/ParameterTable/clsgs_PaperSubViewsAttitudesWApi.js");
    const clsPaperSubViewpointWApi_js_1 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubViewpointWApi.js");
    const clsPaperSubViewpointWApi_js_2 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubViewpointWApi.js");
    const clsPaperSubViewpointWApi_js_3 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubViewpointWApi.js");
    const clsPaperSubViewpointWApi_js_4 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubViewpointWApi.js");
    const clsPaperSubViewpointWApi_js_5 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubViewpointWApi.js");
    const clsPaperSubViewpointWApi_js_6 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubViewpointWApi.js");
    const clsPaperSubViewpointWApi_js_7 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubViewpointWApi.js");
    const clsPaperSubViewpointWApi_js_8 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubViewpointWApi.js");
    const clsPaperSubViewpointWApi_js_9 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubViewpointWApi.js");
    const clsPaperSubViewpointEN_js_1 = require("../../TS/L0_Entity/GraduateEduPaper/clsPaperSubViewpointEN.js");
    const clsPaperSubViewpointWApi_js_10 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubViewpointWApi.js");
    const clsPaperSubViewpointWApi_js_11 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubViewpointWApi.js");
    const clsPaperSubViewpointWApi_js_12 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubViewpointWApi.js");
    const clsPaperSubViewpointWApi_js_13 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubViewpointWApi.js");
    const clsCommFunc4Ctrl_js_1 = require("../../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsString_js_1 = require("../../TS/PubFun/clsString.js");
    const clsPageDispModeEN_js_1 = require("../../TS/L0_Entity/PrjMenu/clsPageDispModeEN.js");
    /** PaperSubViewpoint_Edit 的摘要说明。其中Q代表查询,U代表修改
    * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:GeneCode)
    **/
    class PaperSubViewpoint_Edit {
        constructor(objShowList) {
            this.opType = "";
            this.keyId = "";
            this.bolIsLoadEditRegion = false; //记录是否导入编辑区的变量
            this.divName4Edit = "divEdit"; //编辑区的Id
            this.iShowList = objShowList;
            PaperSubViewpoint_Edit.objPage_Edit = this;
            this.objPaperSubViewpoint = new clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN();
        }
        /**
        * 在当前界面中，导入编辑区域
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Edit)
        * @returns
        **/
        async AddDPV_Edit(divName4Edit) {
            const strThisFuncName = this.AddDPV_Edit.name;
            (0, clsCommFunc4Ctrl_js_1.CheckDivExist)(divName4Edit);
            const strUrl = "../GraduateEduPaper/PaperSubViewpoint_Edit";
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
                const ddlSubViewpointTypeId = (0, clsCommFunc4Ctrl_js_1.GetSelectObjInDiv)(this.divName4Edit, 'ddlSubViewpointTypeId');
                ddlSubViewpointTypeId.addEventListener('change', e => { this.ddlSubViewpointTypeId_SelectedIndexChanged(ddlSubViewpointTypeId); });
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
        ShowDialog_PaperSubViewpoint(strOp) {
            const strThisFuncName = this.ShowDialog_PaperSubViewpoint.name;
            //检查相关控件是否存在
            (0, clsCommFunc4Ctrl_js_1.CheckControlExist)(this.divName4Edit, "div", "divEditDialog_PaperSubViewpoint");
            (0, clsCommFunc4Ctrl_js_1.CheckControlExist)(this.divName4Edit, "h4", "lblDialogTitle_PaperSubViewpoint");
            if (strOp === "Add" || strOp === "AddWithMaxId") {
                $('#lblDialogTitle_PaperSubViewpoint').html('添加记录');
                //PaperSubViewpoint_EditEx.GetMaxStrId('#txtSubViewpointId');
            }
            else if (strOp === "Update") {
                $('#lblDialogTitle_PaperSubViewpoint').html('修改记录');
            }
            else if (strOp === "Detail") {
                $('#btnSubmit_PaperSubViewpoint').hide();
                $('#lblDialogTitle_PaperSubViewpoint').html('详细信息');
            }
            ShowDialog('#divEditDialog_PaperSubViewpoint');
        }
        /**
        * 隐藏对话框
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_TS_HideDialog)
        **/
        HideDialog_PaperSubViewpoint() {
            const strThisFuncName = this.HideDialog_PaperSubViewpoint.name;
            (0, clsCommFunc4Ctrl_js_1.CheckControlExist)(this.divName4Edit, "div", "divEditDialog_PaperSubViewpoint");
            HideDialog('#divEditDialog_PaperSubViewpoint');
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
                    this.btnSubmit_PaperSubViewpoint = "确认添加";
                    this.btnCancel_PaperSubViewpoint = "取消添加";
                    const responseText = this.AddNewRecord();
                    if (PaperSubViewpoint_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_PaperSubViewpoint('Add');
                    }
                }
                else {
                    this.opType = "Add";
                    this.btnSubmit_PaperSubViewpoint = "确认添加";
                    this.btnCancel_PaperSubViewpoint = "取消添加";
                    const responseText = await this.AddNewRecord();
                    if (PaperSubViewpoint_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_PaperSubViewpoint('Add');
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
                    this.btnSubmit_PaperSubViewpoint = "确认添加";
                    this.btnCancel_PaperSubViewpoint = "取消添加";
                    const responseText = this.AddNewRecordWithMaxId();
                    if (PaperSubViewpoint_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_PaperSubViewpoint('Add');
                    }
                }
                else {
                    this.opType = "AddWithMaxId";
                    this.btnSubmit_PaperSubViewpoint = "确认添加";
                    this.btnCancel_PaperSubViewpoint = "取消添加";
                    const responseText = this.AddNewRecordWithMaxId();
                    if (PaperSubViewpoint_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_PaperSubViewpoint('Add');
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
        * 设置绑定下拉框，针对字段:[SectionId]
        * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdlInDiv_TS4TabFeature)
        **/
        async SetDdl_SectionIdInDiv(PaperId) {
            await (0, clsSectionWApi_js_1.Section_BindDdl_SectionIdByPaperIdInDiv_Cache)(this.divName4Edit, "ddlSectionId", PaperId); //
        }
        /**
        * 设置绑定下拉框，针对字段:[SubViewpointTypeId]
        * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdlInDiv_TS4TabFeature)
        **/
        async SetDdl_SubViewpointTypeIdInDiv() {
            await (0, clsSubViewpointTypeWApi_js_1.SubViewpointType_BindDdl_SubViewpointTypeIdInDiv_Cache)(this.divName4Edit, "ddlSubViewpointTypeId"); //
        }
        /**
        * 设置绑定下拉框，针对字段:[ExplainTypeId]
        * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdlInDiv_TS4TabFeature)
        **/
        async SetDdl_ExplainTypeIdInDiv() {
            await (0, clsExplainTypeWApi_js_1.ExplainType_BindDdl_ExplainTypeIdInDiv_Cache)(this.divName4Edit, "ddlExplainTypeId"); //
        }
        /**
        * 设置绑定下拉框，针对字段:[ShareId]
        * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdlInDiv_TS4TabFeature)
        **/
        async SetDdl_ShareIdInDiv() {
            await (0, clsgs_ShareWApi_js_1.gs_Share_BindDdl_ShareIdInDiv_Cache)(this.divName4Edit, "ddlShareId"); //
        }
        /**
        * 设置绑定下拉框，针对字段:[AttitudesId]
        * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdlInDiv_TS4TabFeature)
        **/
        async SetDdl_AttitudesIdInDiv() {
            await (0, clsgs_PaperSubViewsAttitudesWApi_js_1.gs_PaperSubViewsAttitudes_BindDdl_AttitudesIdInDiv_Cache)(this.divName4Edit, "ddlAttitudesId"); //
        }
        /** 函数功能:为编辑区绑定下拉框
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegionInDiv)
        **/
        async BindDdl4EditRegionInDiv() {
            const strThisFuncName = this.BindDdl4EditRegionInDiv.name;
            // 在此处放置用户代码以初始化页面
            const strPaperId = PaperSubViewpoint_Edit.PaperId_Static;
            await this.SetDdl_SectionIdInDiv(strPaperId); //编辑区域
            await this.SetDdl_SubViewpointTypeIdInDiv(); //编辑区域
            await this.SetDdl_ExplainTypeIdInDiv(); //编辑区域
            await this.SetDdl_ShareIdInDiv(); //编辑区域
            await this.SetDdl_AttitudesIdInDiv(); //编辑区域
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
                    this.btnSubmit_PaperSubViewpoint = "确认修改";
                    this.btnCancel_PaperSubViewpoint = "取消修改";
                    this.UpdateRecord(strKeyId);
                    if (PaperSubViewpoint_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_PaperSubViewpoint('Update');
                    }
                }
                else {
                    this.opType = "Update";
                    this.btnSubmit_PaperSubViewpoint = "确认修改";
                    this.btnCancel_PaperSubViewpoint = "取消修改";
                    this.UpdateRecord(strKeyId);
                    if (PaperSubViewpoint_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_PaperSubViewpoint('Update');
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
                    this.btnSubmit_PaperSubViewpoint = "确认修改";
                    this.btnCancel_PaperSubViewpoint = "取消修改";
                    const update = await this.UpdateRecord(strKeyId);
                    if (update == false) {
                        const strMsg = (0, clsString_js_1.Format)("在修改记录时,显示记录数据不成功!");
                        console.error(strMsg);
                        alert(strMsg);
                        return;
                    }
                    if (PaperSubViewpoint_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_PaperSubViewpoint('Update');
                    }
                }
                else {
                    this.opType = "Update";
                    this.btnSubmit_PaperSubViewpoint = "确认修改";
                    this.btnCancel_PaperSubViewpoint = "取消修改";
                    const update = await this.UpdateRecord(strKeyId);
                    if (update == false) {
                        const strMsg = (0, clsString_js_1.Format)("在修改记录时,显示记录数据不成功!");
                        console.error(strMsg);
                        alert(strMsg);
                        return;
                    }
                    if (PaperSubViewpoint_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_PaperSubViewpoint('Update');
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
            const strCommandText = this.btnSubmit_PaperSubViewpoint;
            try {
                let returnBool = false;
                let returnKeyId = "";
                let strInfo = "";
                let strMsg = "";
                switch (strCommandText) {
                    case "添加":
                        this.btnSubmit_PaperSubViewpoint = "确认添加";
                        this.btnCancel_PaperSubViewpoint = "取消添加";
                        await this.AddNewRecord();
                        break;
                    case "确认添加":
                        //这是一个单表的插入的代码,由于逻辑层太简单,
                        //就把逻辑层合并到控制层,
                        if (this.opType == "AddWithMaxId") {
                            returnKeyId = await this.AddNewRecordWithMaxIdSave();
                            if ((0, clsString_js_1.IsNullOrEmpty)(returnKeyId) == false) {
                                if (PaperSubViewpoint_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                                    this.HideDialog_PaperSubViewpoint();
                                }
                                this.iShowList.BindGv(clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN._CurrTabName, returnKeyId);
                            }
                        }
                        else {
                            returnBool = await this.AddNewRecordSave();
                            if (returnBool == true) {
                                if (PaperSubViewpoint_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                                    this.HideDialog_PaperSubViewpoint();
                                }
                                this.iShowList.BindGv(clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN._CurrTabName, returnBool.toString());
                            }
                        }
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        returnBool = await this.UpdateRecordSave();
                        strInfo = returnBool ? "修改成功！" : "修改不成功！";
                        strInfo += "(In PaperSubViewpoint_Edit.btnSubmit_Click)";
                        //显示信息框
                        //console.log(strInfo);
                        alert(strInfo);
                        if (returnBool == true) {
                            if (PaperSubViewpoint_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                                this.HideDialog_PaperSubViewpoint();
                            }
                            this.iShowList.BindGv(clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN._CurrTabName, returnBool.toString());
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
            $('#txtSubViewpointId').attr('ReadOnly', bolReadonly.toString());
        }
        /**
         * 清除用户自定义控件中，所有控件的值
         * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_Clear)
         **/
        Clear() {
            const strThisFuncName = this.Clear.name;
            this.paperRWId = "";
            $('#ddlSectionId option[0]').attr("selected", "true");
            $('#ddlSubViewpointTypeId option[0]').attr("selected", "true");
            this.rwTitle = "";
            this.subViewpointContent = "";
            $('#ddlExplainTypeId option[0]').attr("selected", "true");
            this.explainContent = "";
            this.isPublic = false;
            this.literatureSourcesId = "";
            this.pageNumber = 0;
            this.orderNum = 0;
            this.updDate = "";
            this.memo = "";
            this.subViewpointId = "";
            this.userId = "";
            this.paperLineNum = 0;
            this.paperPageNum = 0;
            this.appraiseCount = 0;
            this.okCount = 0;
            this.score = 0;
            this.stuScore = 0;
            this.teaScore = 0;
            this.createDate = "";
            $('#ddlShareId option[0]').attr("selected", "true");
            this.updUser = "";
            $('#ddlAttitudesId option[0]').attr("selected", "true");
        }
        /** 为插入记录做准备工作
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
        **/
        async AddNewRecord() {
            const strThisFuncName = this.AddNewRecord.name;
            this.Clear();
            //wucPaperSubViewpointB1.subViewpointId = PaperSubViewpoint_GetMaxStrId_S();
            try {
                const returnString = await (0, clsPaperSubViewpointWApi_js_1.PaperSubViewpoint_GetMaxStrIdAsync)();
                if (returnString == "") {
                    const strInfo = (0, clsString_js_1.Format)("获取表PaperSubViewpoint的最大关键字为空，不成功，请检查!");
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    $('#txtSubViewpointId').val(returnString);
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
            //wucPaperSubViewpointB1.subViewpointId = PaperSubViewpoint_GetMaxStrId_S();
        }
        /** 函数功能:把界面上的属性数据传到类对象中
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
        * @param pobjPaperSubViewpointEN">数据传输的目的类对象</param>
        **/
        async PutDataToPaperSubViewpointClass(pobjPaperSubViewpointEN) {
            const strThisFuncName = this.PutDataToPaperSubViewpointClass.name;
            pobjPaperSubViewpointEN.SetPaperRWId(this.paperRWId); // 论文读写Id
            pobjPaperSubViewpointEN.SetSectionId(this.sectionId); // 节Id
            pobjPaperSubViewpointEN.SetSubViewpointTypeId(this.subViewpointTypeId); // 类型Id
            pobjPaperSubViewpointEN.SetRWTitle(this.rwTitle); // 读写标题
            pobjPaperSubViewpointEN.SetSubViewpointContent(this.subViewpointContent); // 详情内容
            pobjPaperSubViewpointEN.SetExplainTypeId(this.explainTypeId); // 说明类型Id
            pobjPaperSubViewpointEN.SetExplainContent(this.explainContent); // 说明内容
            pobjPaperSubViewpointEN.SetIsPublic(this.isPublic); // 是否公开
            pobjPaperSubViewpointEN.SetLiteratureSourcesId(this.literatureSourcesId); // 文献来源
            pobjPaperSubViewpointEN.SetPageNumber(this.pageNumber); // 页码
            pobjPaperSubViewpointEN.SetOrderNum(this.orderNum); // 序号
            pobjPaperSubViewpointEN.SetUpdDate(this.updDate); // 修改日期
            pobjPaperSubViewpointEN.SetMemo(this.memo); // 备注
            pobjPaperSubViewpointEN.SetSubViewpointId(this.subViewpointId); // 子观点Id
            pobjPaperSubViewpointEN.SetUserId(this.userId); // 用户ID
            pobjPaperSubViewpointEN.SetPaperLineNum(this.paperLineNum); // 论文行号
            pobjPaperSubViewpointEN.SetPaperPageNum(this.paperPageNum); // 论文页码
            pobjPaperSubViewpointEN.SetAppraiseCount(this.appraiseCount); // 评论数
            pobjPaperSubViewpointEN.SetOkCount(this.okCount); // 点赞统计
            pobjPaperSubViewpointEN.SetScore(this.score); // 评分
            pobjPaperSubViewpointEN.SetStuScore(this.stuScore); // 学生平均分
            pobjPaperSubViewpointEN.SetTeaScore(this.teaScore); // 教师评分
            pobjPaperSubViewpointEN.SetCreateDate(this.createDate); // 建立日期
            pobjPaperSubViewpointEN.SetShareId(this.shareId); // 分享Id
            pobjPaperSubViewpointEN.SetUpdUser(this.updUser); // 修改人
            pobjPaperSubViewpointEN.SetAttitudesId(this.attitudesId); // 态度Id
        }
        /** 添加新记录，保存函数
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
        **/
        async AddNewRecordSave() {
            const strThisFuncName = this.AddNewRecordSave.name;
            const objPaperSubViewpointEN = new clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN();
            try {
                await this.PutDataToPaperSubViewpointClass(objPaperSubViewpointEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("从界面获取数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                (0, clsPaperSubViewpointWApi_js_2.PaperSubViewpoint_CheckPropertyNew)(objPaperSubViewpointEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("检查数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                //检查唯一性条件
                const bolIsExistCond_PaperRWId_SubViewpointTypeId_SubViewpointContent = await this.CheckUniCond4Add_PaperRWId_SubViewpointTypeId_SubViewpointContent(objPaperSubViewpointEN);
                if (bolIsExistCond_PaperRWId_SubViewpointTypeId_SubViewpointContent == false) {
                    return false;
                }
                const bolIsExistCond_SubViewpointId = await this.CheckUniCond4Add_SubViewpointId(objPaperSubViewpointEN);
                if (bolIsExistCond_SubViewpointId == false) {
                    return false;
                }
                let returnBool = false;
                const returnKeyId = await (0, clsPaperSubViewpointWApi_js_3.PaperSubViewpoint_AddNewRecordWithMaxIdAsync)(objPaperSubViewpointEN);
                if ((0, clsString_js_1.IsNullOrEmpty)(returnKeyId) == false) {
                    returnBool = true;
                }
                if (returnBool == true) {
                    (0, clsPaperSubViewpointWApi_js_4.PaperSubViewpoint_ReFreshCache)(PaperSubViewpoint_Edit.id_CurrEduCls_Cache);
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
        async CheckUniCond4Add_PaperRWId_SubViewpointTypeId_SubViewpointContent(objPaperSubViewpointEN) {
            const strThisFuncName = this.CheckUniCond4Add_PaperRWId_SubViewpointTypeId_SubViewpointContent.name;
            const strUniquenessCondition = (0, clsPaperSubViewpointWApi_js_5.PaperSubViewpoint_GetUniCondStr_PaperRWId_SubViewpointTypeId_SubViewpointContent)(objPaperSubViewpointEN);
            const bolIsExistCondition = await (0, clsPaperSubViewpointWApi_js_6.PaperSubViewpoint_IsExistRecordAsync)(strUniquenessCondition);
            if (bolIsExistCondition == true) {
                const strMsg = (0, clsString_js_1.Format)("不能满足唯一性条件。满足条件：{0}的记录已经存在！", strUniquenessCondition);
                console.error(strMsg);
                alert(strMsg);
                return false;
            }
            return true;
        }
        /** 为添加记录检查唯一性条件
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_CheckUniCondition4Add)
        **/
        async CheckUniCond4Add_SubViewpointId(objPaperSubViewpointEN) {
            const strThisFuncName = this.CheckUniCond4Add_SubViewpointId.name;
            const strUniquenessCondition = (0, clsPaperSubViewpointWApi_js_7.PaperSubViewpoint_GetUniCondStr_SubViewpointId)(objPaperSubViewpointEN);
            const bolIsExistCondition = await (0, clsPaperSubViewpointWApi_js_6.PaperSubViewpoint_IsExistRecordAsync)(strUniquenessCondition);
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
        async CheckUniCond4Update_PaperRWId_SubViewpointTypeId_SubViewpointContent(objPaperSubViewpointEN) {
            const strThisFuncName = this.CheckUniCond4Update_PaperRWId_SubViewpointTypeId_SubViewpointContent.name;
            const strUniquenessCondition = (0, clsPaperSubViewpointWApi_js_8.PaperSubViewpoint_GetUniCondStr4Update_PaperRWId_SubViewpointTypeId_SubViewpointContent)(objPaperSubViewpointEN);
            const bolIsExistCondition = await (0, clsPaperSubViewpointWApi_js_6.PaperSubViewpoint_IsExistRecordAsync)(strUniquenessCondition);
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
        async CheckUniCond4Update_SubViewpointId(objPaperSubViewpointEN) {
            const strThisFuncName = this.CheckUniCond4Update_SubViewpointId.name;
            const strUniquenessCondition = (0, clsPaperSubViewpointWApi_js_9.PaperSubViewpoint_GetUniCondStr4Update_SubViewpointId)(objPaperSubViewpointEN);
            const bolIsExistCondition = await (0, clsPaperSubViewpointWApi_js_6.PaperSubViewpoint_IsExistRecordAsync)(strUniquenessCondition);
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
            const objPaperSubViewpointEN = new clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN();
            try {
                await this.PutDataToPaperSubViewpointClass(objPaperSubViewpointEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("从界面获取数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                throw (strMsg); //一定要有一个返回值，否则会出错！
            }
            try {
                (0, clsPaperSubViewpointWApi_js_2.PaperSubViewpoint_CheckPropertyNew)(objPaperSubViewpointEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("检查数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                throw (strMsg); //一定要有一个返回值，否则会出错！
            }
            try {
                //检查唯一性条件
                const bolIsExistCond_PaperRWId_SubViewpointTypeId_SubViewpointContent = await this.CheckUniCond4Add_PaperRWId_SubViewpointTypeId_SubViewpointContent(objPaperSubViewpointEN);
                if (bolIsExistCond_PaperRWId_SubViewpointTypeId_SubViewpointContent == false) {
                    return "";
                }
                const bolIsExistCond_SubViewpointId = await this.CheckUniCond4Add_SubViewpointId(objPaperSubViewpointEN);
                if (bolIsExistCond_SubViewpointId == false) {
                    return "";
                }
                const responseKeyId = await (0, clsPaperSubViewpointWApi_js_3.PaperSubViewpoint_AddNewRecordWithMaxIdAsync)(objPaperSubViewpointEN);
                const returnKeyId = responseKeyId;
                if ((0, clsString_js_1.IsNullOrEmpty)(returnKeyId) == false) {
                    (0, clsPaperSubViewpointWApi_js_4.PaperSubViewpoint_ReFreshCache)(PaperSubViewpoint_Edit.id_CurrEduCls_Cache);
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
        * @param strSubViewpointId: 表记录的关键字,显示该表关键字的内容
        **/
        async ShowData(strSubViewpointId) {
            const strThisFuncName = this.ShowData.name;
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            let objPaperSubViewpointEN = new clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN();
            try {
                const returnBool = await (0, clsPaperSubViewpointWApi_js_10.PaperSubViewpoint_IsExistAsync)(strSubViewpointId);
                if (returnBool == false) {
                    const strInfo = (0, clsString_js_1.Format)("关键字:[{0}] 的记录不存在!", strSubViewpointId);
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
                const objPaperSubViewpointEN_Const = await (0, clsPaperSubViewpointWApi_js_11.PaperSubViewpoint_GetObjBySubViewpointIdAsync)(strSubViewpointId);
                if (objPaperSubViewpointEN_Const == null) {
                    const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                    console.error(strMsg);
                    alert(strMsg);
                    return;
                }
                objPaperSubViewpointEN = objPaperSubViewpointEN_Const;
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
            //3、用提供的关键字初始化一个类对象；
            this.GetDataFromPaperSubViewpointClass(objPaperSubViewpointEN);
        }
        /** 函数功能:把类对象的属性内容显示到界面上
        * 注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
        * 如果在设置数据库时,就应该一级字段在前,二级字段在后
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
        * @param pobjPaperSubViewpointEN">表实体类对象</param>
        **/
        async GetDataFromPaperSubViewpointClass(pobjPaperSubViewpointEN) {
            const strThisFuncName = this.GetDataFromPaperSubViewpointClass.name;
            this.paperRWId = pobjPaperSubViewpointEN.paperRWId; // 论文读写Id
            this.sectionId = pobjPaperSubViewpointEN.sectionId; // 节Id
            this.subViewpointTypeId = pobjPaperSubViewpointEN.subViewpointTypeId; // 类型Id
            this.rwTitle = pobjPaperSubViewpointEN.rwTitle; // 读写标题
            this.subViewpointContent = pobjPaperSubViewpointEN.subViewpointContent; // 详情内容
            this.explainTypeId = pobjPaperSubViewpointEN.explainTypeId; // 说明类型Id
            this.explainContent = pobjPaperSubViewpointEN.explainContent; // 说明内容
            this.isPublic = pobjPaperSubViewpointEN.isPublic; // 是否公开
            this.literatureSourcesId = pobjPaperSubViewpointEN.literatureSourcesId; // 文献来源
            this.pageNumber = pobjPaperSubViewpointEN.pageNumber; // 页码
            this.orderNum = pobjPaperSubViewpointEN.orderNum; // 序号
            this.updDate = pobjPaperSubViewpointEN.updDate; // 修改日期
            this.memo = pobjPaperSubViewpointEN.memo; // 备注
            this.subViewpointId = pobjPaperSubViewpointEN.subViewpointId; // 子观点Id
            this.userId = pobjPaperSubViewpointEN.userId; // 用户ID
            this.paperLineNum = pobjPaperSubViewpointEN.paperLineNum; // 论文行号
            this.paperPageNum = pobjPaperSubViewpointEN.paperPageNum; // 论文页码
            this.appraiseCount = pobjPaperSubViewpointEN.appraiseCount; // 评论数
            this.okCount = pobjPaperSubViewpointEN.okCount; // 点赞统计
            this.score = pobjPaperSubViewpointEN.score; // 评分
            this.stuScore = pobjPaperSubViewpointEN.stuScore; // 学生平均分
            this.teaScore = pobjPaperSubViewpointEN.teaScore; // 教师评分
            this.createDate = pobjPaperSubViewpointEN.createDate; // 建立日期
            this.shareId = pobjPaperSubViewpointEN.shareId; // 分享Id
            this.updUser = pobjPaperSubViewpointEN.updUser; // 修改人
            this.attitudesId = pobjPaperSubViewpointEN.attitudesId; // 态度Id
        }
        /** 根据关键字获取相应的记录的对象
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
        * @param sender">参数列表</param>
        **/
        async UpdateRecord(strSubViewpointId) {
            const strThisFuncName = this.UpdateRecord.name;
            this.keyId = strSubViewpointId;
            try {
                const objPaperSubViewpointEN_Const = await (0, clsPaperSubViewpointWApi_js_11.PaperSubViewpoint_GetObjBySubViewpointIdAsync)(strSubViewpointId);
                if (objPaperSubViewpointEN_Const == null) {
                    const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                    console.error(strMsg);
                    alert(strMsg);
                    return false;
                }
                this.objPaperSubViewpoint = objPaperSubViewpointEN_Const;
                const conGetDataFromClass = await this.GetDataFromPaperSubViewpointClass(objPaperSubViewpointEN_Const);
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
            const objPaperSubViewpointEN = new clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN();
            objPaperSubViewpointEN.SetSubViewpointId(this.keyId);
            await this.PutDataToPaperSubViewpointClass(objPaperSubViewpointEN);
            objPaperSubViewpointEN.sf_UpdFldSetStr = objPaperSubViewpointEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objPaperSubViewpointEN.subViewpointId == "" || objPaperSubViewpointEN.subViewpointId == undefined) {
                console.error("关键字不能为空!");
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            try {
                (0, clsPaperSubViewpointWApi_js_12.PaperSubViewpoint_CheckProperty4Update)(objPaperSubViewpointEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("检查数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                //检查唯一性条件
                const bolIsExistCond_PaperRWId_SubViewpointTypeId_SubViewpointContent = await this.CheckUniCond4Update_PaperRWId_SubViewpointTypeId_SubViewpointContent(objPaperSubViewpointEN);
                if (bolIsExistCond_PaperRWId_SubViewpointTypeId_SubViewpointContent == false) {
                    return false;
                }
                const bolIsExistCond_SubViewpointId = await this.CheckUniCond4Update_SubViewpointId(objPaperSubViewpointEN);
                if (bolIsExistCond_SubViewpointId == false) {
                    return false;
                }
                const returnBool = await (0, clsPaperSubViewpointWApi_js_13.PaperSubViewpoint_UpdateRecordAsync)(objPaperSubViewpointEN);
                if (returnBool == true) {
                    (0, clsPaperSubViewpointWApi_js_4.PaperSubViewpoint_ReFreshCache)(PaperSubViewpoint_Edit.id_CurrEduCls_Cache);
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
        * 评论数 (Used In Clear())
        **/
        set appraiseCount(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtAppraiseCount", value.toString());
        }
        /**
        * 评论数 (Used In PutDataToClass())
        **/
        get appraiseCount() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtAppraiseCount");
            if (strValue == undefined)
                return 0;
            else if ((0, clsString_js_1.IsNullOrEmpty)(strValue) == true)
                return 0;
            else
                return Number(strValue);
        }
        /**
        * 态度Id (Used In Clear())
        **/
        set attitudesId(value) {
            (0, clsCommFunc4Ctrl_js_1.SetSelectValueByIdInDiv)(this.divName4Edit, "ddlAttitudesId", value);
        }
        /**
        * 态度Id (Used In PutDataToClass())
        **/
        get attitudesId() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetSelectValueInDiv)(this.divName4Edit, "ddlAttitudesId");
            if (strValue == undefined)
                return "";
            else if (strValue == "0")
                return "";
            else
                return strValue;
        }
        /**
        * 设置取消按钮的标题(Used In AddNewRecord())
        **/
        set btnCancel_PaperSubViewpoint(value) {
            (0, clsCommFunc4Ctrl_js_1.SetButtonHtmlByIdInDiv)(this.divName4Edit, "btnCancel_PaperSubViewpoint", value);
        }
        /**
        * 获取按钮的标题
        **/
        get btnSubmit_PaperSubViewpoint() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetButtonHtmlInDiv)(this.divName4Edit, "btnSubmit_PaperSubViewpoint");
            return strValue;
        }
        /**
        * 设置确定按钮的标题(Used In AddNewRecord())
        **/
        set btnSubmit_PaperSubViewpoint(value) {
            (0, clsCommFunc4Ctrl_js_1.SetButtonHtmlByIdInDiv)(this.divName4Edit, "btnSubmit_PaperSubViewpoint", value);
        }
        /**
        * 建立日期 (Used In Clear())
        **/
        set createDate(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtCreateDate", value);
        }
        /**
        * 建立日期 (Used In PutDataToClass())
        **/
        get createDate() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtCreateDate");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 说明内容 (Used In Clear())
        **/
        set explainContent(value) {
            (0, clsCommFunc4Ctrl_js_1.SetTextAreaValueByIdInDiv)(this.divName4Edit, "txtExplainContent", value);
        }
        /**
        * 说明内容 (Used In PutDataToClass())
        **/
        get explainContent() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetTextAreaValueInDiv)(this.divName4Edit, "txtExplainContent");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 说明类型Id (Used In Clear())
        **/
        set explainTypeId(value) {
            (0, clsCommFunc4Ctrl_js_1.SetSelectValueByIdInDiv)(this.divName4Edit, "ddlExplainTypeId", value);
        }
        /**
        * 说明类型Id (Used In PutDataToClass())
        **/
        get explainTypeId() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetSelectValueInDiv)(this.divName4Edit, "ddlExplainTypeId");
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
        set isPublic(value) {
            (0, clsCommFunc4Ctrl_js_1.SetCheckBoxValueByIdInDiv)(this.divName4Edit, "chkIsPublic", value);
        }
        /**
        * 是否公开 (Used In PutDataToClass())
        **/
        get isPublic() {
            const bolValue = (0, clsCommFunc4Ctrl_js_1.GetCheckBoxValueInDiv)(this.divName4Edit, "chkIsPublic");
            return bolValue;
        }
        /**
        * 文献来源 (Used In Clear())
        **/
        set literatureSourcesId(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtLiteratureSourcesId", value);
        }
        /**
        * 文献来源 (Used In PutDataToClass())
        **/
        get literatureSourcesId() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtLiteratureSourcesId");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 备注 (Used In Clear())
        **/
        set memo(value) {
            (0, clsCommFunc4Ctrl_js_1.SetTextAreaValueByIdInDiv)(this.divName4Edit, "txtMemo", value);
        }
        /**
        * 备注 (Used In PutDataToClass())
        **/
        get memo() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetTextAreaValueInDiv)(this.divName4Edit, "txtMemo");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 点赞统计 (Used In Clear())
        **/
        set okCount(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtOkCount", value.toString());
        }
        /**
        * 点赞统计 (Used In PutDataToClass())
        **/
        get okCount() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtOkCount");
            if (strValue == undefined)
                return 0;
            else if ((0, clsString_js_1.IsNullOrEmpty)(strValue) == true)
                return 0;
            else
                return Number(strValue);
        }
        /**
        * 序号 (Used In Clear())
        **/
        set orderNum(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtOrderNum", value.toString());
        }
        /**
        * 序号 (Used In PutDataToClass())
        **/
        get orderNum() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtOrderNum");
            if (strValue == undefined)
                return 0;
            else if ((0, clsString_js_1.IsNullOrEmpty)(strValue) == true)
                return 0;
            else
                return Number(strValue);
        }
        /**
        * 页码 (Used In Clear())
        **/
        set pageNumber(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtPageNumber", value.toString());
        }
        /**
        * 页码 (Used In PutDataToClass())
        **/
        get pageNumber() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtPageNumber");
            if (strValue == undefined)
                return 0;
            else if ((0, clsString_js_1.IsNullOrEmpty)(strValue) == true)
                return 0;
            else
                return Number(strValue);
        }
        /**
        * 论文行号 (Used In Clear())
        **/
        set paperLineNum(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtPaperLineNum", value.toString());
        }
        /**
        * 论文行号 (Used In PutDataToClass())
        **/
        get paperLineNum() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtPaperLineNum");
            if (strValue == undefined)
                return 0;
            else if ((0, clsString_js_1.IsNullOrEmpty)(strValue) == true)
                return 0;
            else
                return Number(strValue);
        }
        /**
        * 论文页码 (Used In Clear())
        **/
        set paperPageNum(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtPaperPageNum", value.toString());
        }
        /**
        * 论文页码 (Used In PutDataToClass())
        **/
        get paperPageNum() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtPaperPageNum");
            if (strValue == undefined)
                return 0;
            else if ((0, clsString_js_1.IsNullOrEmpty)(strValue) == true)
                return 0;
            else
                return Number(strValue);
        }
        /**
        * 课文阅读 (Used In Clear())
        **/
        set paperRWId(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtPaperRWId", value);
        }
        /**
        * 课文阅读 (Used In PutDataToClass())
        **/
        get paperRWId() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtPaperRWId");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 读写标题 (Used In Clear())
        **/
        set rwTitle(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtRWTitle", value);
        }
        /**
        * 读写标题 (Used In PutDataToClass())
        **/
        get rwTitle() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtRWTitle");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 评分 (Used In Clear())
        **/
        set score(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtScore", value.toString());
        }
        /**
        * 评分 (Used In PutDataToClass())
        **/
        get score() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtScore");
            if (strValue == undefined)
                return 0;
            else if ((0, clsString_js_1.IsNullOrEmpty)(strValue) == true)
                return 0;
            else
                return Number(strValue);
        }
        /**
        * 节Id (Used In Clear())
        **/
        set sectionId(value) {
            (0, clsCommFunc4Ctrl_js_1.SetSelectValueByIdInDiv)(this.divName4Edit, "ddlSectionId", value);
        }
        /**
        * 节Id (Used In PutDataToClass())
        **/
        get sectionId() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetSelectValueInDiv)(this.divName4Edit, "ddlSectionId");
            if (strValue == undefined)
                return "";
            else if (strValue == "0")
                return "";
            else
                return strValue;
        }
        /**
        * 分享Id (Used In Clear())
        **/
        set shareId(value) {
            (0, clsCommFunc4Ctrl_js_1.SetSelectValueByIdInDiv)(this.divName4Edit, "ddlShareId", value);
        }
        /**
        * 分享Id (Used In PutDataToClass())
        **/
        get shareId() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetSelectValueInDiv)(this.divName4Edit, "ddlShareId");
            if (strValue == undefined)
                return "";
            else if (strValue == "0")
                return "";
            else
                return strValue;
        }
        /**
        * 学生平均分 (Used In Clear())
        **/
        set stuScore(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtStuScore", value.toString());
        }
        /**
        * 学生平均分 (Used In PutDataToClass())
        **/
        get stuScore() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtStuScore");
            if (strValue == undefined)
                return 0;
            else if ((0, clsString_js_1.IsNullOrEmpty)(strValue) == true)
                return 0;
            else
                return Number(strValue);
        }
        /**
        * 详情内容 (Used In Clear())
        **/
        set subViewpointContent(value) {
            (0, clsCommFunc4Ctrl_js_1.SetTextAreaValueByIdInDiv)(this.divName4Edit, "txtSubViewpointContent", value);
        }
        /**
        * 详情内容 (Used In PutDataToClass())
        **/
        get subViewpointContent() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetTextAreaValueInDiv)(this.divName4Edit, "txtSubViewpointContent");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 子观点Id (Used In Clear())
        **/
        set subViewpointId(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtSubViewpointId", value);
        }
        /**
        * 子观点Id (Used In PutDataToClass())
        **/
        get subViewpointId() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtSubViewpointId");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 类型Id (Used In Clear())
        **/
        set subViewpointTypeId(value) {
            (0, clsCommFunc4Ctrl_js_1.SetSelectValueByIdInDiv)(this.divName4Edit, "ddlSubViewpointTypeId", value);
        }
        /**
        * 类型Id (Used In PutDataToClass())
        **/
        get subViewpointTypeId() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetSelectValueInDiv)(this.divName4Edit, "ddlSubViewpointTypeId");
            if (strValue == undefined)
                return "";
            else if (strValue == "0")
                return "";
            else
                return strValue;
        }
        /**
        * 教师评分 (Used In Clear())
        **/
        set teaScore(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtTeaScore", value.toString());
        }
        /**
        * 教师评分 (Used In PutDataToClass())
        **/
        get teaScore() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtTeaScore");
            if (strValue == undefined)
                return 0;
            else if ((0, clsString_js_1.IsNullOrEmpty)(strValue) == true)
                return 0;
            else
                return Number(strValue);
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
    }
    exports.PaperSubViewpoint_Edit = PaperSubViewpoint_Edit;
    PaperSubViewpoint_Edit.id_CurrEduCls_Cache = "";
    PaperSubViewpoint_Edit.PaperId_Static = ""; //定义下拉框条件变量1
    PaperSubViewpoint_Edit.strPageDispModeId = "01"; //PopupBox(弹出框)
});
