(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js", "../../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js", "../../TS/PubFun/clsCommFunc4Ctrl.js", "../../TS/PubFun/clsString.js", "../../TS/L0_Entity/PrjMenu/clsPageDispModeEN.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.Paper_Edit = void 0;
    /**
    * 类名:Paper_Edit(界面:PaperCRUD1)
    * 表名:Paper(01120535)
    * 版本:2023.02.24.1(服务器:WIN-SRV103-116)
    * 日期:2023/02/24 18:12:05
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
    const clsgs_ShareWApi_js_1 = require("../../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js");
    const clsPaperWApi_js_1 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js");
    const clsPaperWApi_js_2 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js");
    const clsPaperWApi_js_3 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js");
    const clsPaperWApi_js_4 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js");
    const clsPaperWApi_js_5 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js");
    const clsPaperWApi_js_6 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js");
    const clsPaperEN_js_1 = require("../../TS/L0_Entity/GraduateEduPaper/clsPaperEN.js");
    const clsPaperWApi_js_7 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js");
    const clsPaperWApi_js_8 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js");
    const clsPaperWApi_js_9 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js");
    const clsPaperWApi_js_10 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsPaperWApi.js");
    const clsCommFunc4Ctrl_js_1 = require("../../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsString_js_1 = require("../../TS/PubFun/clsString.js");
    const clsPageDispModeEN_js_1 = require("../../TS/L0_Entity/PrjMenu/clsPageDispModeEN.js");
    /** Paper_Edit 的摘要说明。其中Q代表查询,U代表修改
    * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:GeneCode)
    **/
    class Paper_Edit {
        constructor(objShowList) {
            this.opType = "";
            this.keyId = "";
            this.bolIsLoadEditRegion = false; //记录是否导入编辑区的变量
            this.divName4Edit = "divEdit"; //编辑区的Id
            this.iShowList = objShowList;
            Paper_Edit.objPage_Edit = this;
            this.objPaper = new clsPaperEN_js_1.clsPaperEN();
        }
        /**
        * 在当前界面中，导入编辑区域
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Edit)
        * @returns
        **/
        async AddDPV_Edit(divName4Edit) {
            const strThisFuncName = this.AddDPV_Edit.name;
            (0, clsCommFunc4Ctrl_js_1.CheckDivExist)(divName4Edit);
            const strUrl = "../GraduateEduPaper/Paper_Edit";
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
        ShowDialog_Paper(strOp) {
            const strThisFuncName = this.ShowDialog_Paper.name;
            //检查相关控件是否存在
            (0, clsCommFunc4Ctrl_js_1.CheckControlExist)(this.divName4Edit, "div", "divEditDialog_Paper");
            (0, clsCommFunc4Ctrl_js_1.CheckControlExist)(this.divName4Edit, "h4", "lblDialogTitle_Paper");
            if (strOp === "Add" || strOp === "AddWithMaxId") {
                $('#lblDialogTitle_Paper').html('添加记录');
                //Paper_EditEx.GetMaxStrId('#txtPaperId');
            }
            else if (strOp === "Update") {
                $('#lblDialogTitle_Paper').html('修改记录');
            }
            else if (strOp === "Detail") {
                $('#btnSubmit_Paper').hide();
                $('#lblDialogTitle_Paper').html('详细信息');
            }
            ShowDialog('#divEditDialog_Paper');
        }
        /**
        * 隐藏对话框
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_TS_HideDialog)
        **/
        HideDialog_Paper() {
            const strThisFuncName = this.HideDialog_Paper.name;
            (0, clsCommFunc4Ctrl_js_1.CheckControlExist)(this.divName4Edit, "div", "divEditDialog_Paper");
            HideDialog('#divEditDialog_Paper');
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
                    this.btnSubmit_Paper = "确认添加";
                    this.btnCancel_Paper = "取消添加";
                    const responseText = this.AddNewRecord();
                    if (Paper_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_Paper('Add');
                    }
                }
                else {
                    this.opType = "Add";
                    this.btnSubmit_Paper = "确认添加";
                    this.btnCancel_Paper = "取消添加";
                    const responseText = await this.AddNewRecord();
                    if (Paper_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_Paper('Add');
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
                    this.btnSubmit_Paper = "确认添加";
                    this.btnCancel_Paper = "取消添加";
                    const responseText = this.AddNewRecordWithMaxId();
                    if (Paper_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_Paper('Add');
                    }
                }
                else {
                    this.opType = "AddWithMaxId";
                    this.btnSubmit_Paper = "确认添加";
                    this.btnCancel_Paper = "取消添加";
                    const responseText = this.AddNewRecordWithMaxId();
                    if (Paper_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_Paper('Add');
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
        * 设置绑定下拉框，针对字段:[ShareId]
        * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdlInDiv_TS4TabFeature)
        **/
        async SetDdl_ShareIdInDiv() {
            await (0, clsgs_ShareWApi_js_1.gs_Share_BindDdl_ShareIdInDiv_Cache)(this.divName4Edit, "ddlShareId"); //
        }
        /** 函数功能:为编辑区绑定下拉框
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegionInDiv)
        **/
        async BindDdl4EditRegionInDiv() {
            const strThisFuncName = this.BindDdl4EditRegionInDiv.name;
            // 在此处放置用户代码以初始化页面
            await this.SetDdl_ShareIdInDiv(); //编辑区域
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
                    this.btnSubmit_Paper = "确认修改";
                    this.btnCancel_Paper = "取消修改";
                    this.UpdateRecord(strKeyId);
                    if (Paper_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_Paper('Update');
                    }
                }
                else {
                    this.opType = "Update";
                    this.btnSubmit_Paper = "确认修改";
                    this.btnCancel_Paper = "取消修改";
                    this.UpdateRecord(strKeyId);
                    if (Paper_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_Paper('Update');
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
                    this.btnSubmit_Paper = "确认修改";
                    this.btnCancel_Paper = "取消修改";
                    const update = await this.UpdateRecord(strKeyId);
                    if (update == false) {
                        const strMsg = (0, clsString_js_1.Format)("在修改记录时,显示记录数据不成功!");
                        console.error(strMsg);
                        alert(strMsg);
                        return;
                    }
                    if (Paper_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_Paper('Update');
                    }
                }
                else {
                    this.opType = "Update";
                    this.btnSubmit_Paper = "确认修改";
                    this.btnCancel_Paper = "取消修改";
                    const update = await this.UpdateRecord(strKeyId);
                    if (update == false) {
                        const strMsg = (0, clsString_js_1.Format)("在修改记录时,显示记录数据不成功!");
                        console.error(strMsg);
                        alert(strMsg);
                        return;
                    }
                    if (Paper_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_Paper('Update');
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
            const strCommandText = this.btnSubmit_Paper;
            try {
                let returnBool = false;
                let returnKeyId = "";
                let strInfo = "";
                let strMsg = "";
                switch (strCommandText) {
                    case "添加":
                        this.btnSubmit_Paper = "确认添加";
                        this.btnCancel_Paper = "取消添加";
                        await this.AddNewRecord();
                        break;
                    case "确认添加":
                        //这是一个单表的插入的代码,由于逻辑层太简单,
                        //就把逻辑层合并到控制层,
                        if (this.opType == "AddWithMaxId") {
                            returnKeyId = await this.AddNewRecordWithMaxIdSave();
                            if ((0, clsString_js_1.IsNullOrEmpty)(returnKeyId) == false) {
                                if (Paper_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                                    this.HideDialog_Paper();
                                }
                                this.iShowList.BindGv(clsPaperEN_js_1.clsPaperEN._CurrTabName, returnKeyId);
                            }
                        }
                        else {
                            returnBool = await this.AddNewRecordSave();
                            if (returnBool == true) {
                                if (Paper_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                                    this.HideDialog_Paper();
                                }
                                this.iShowList.BindGv(clsPaperEN_js_1.clsPaperEN._CurrTabName, returnBool.toString());
                            }
                        }
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        returnBool = await this.UpdateRecordSave();
                        strInfo = returnBool ? "修改成功！" : "修改不成功！";
                        strInfo += "(In Paper_Edit.btnSubmit_Click)";
                        //显示信息框
                        //console.log(strInfo);
                        alert(strInfo);
                        if (returnBool == true) {
                            if (Paper_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                                this.HideDialog_Paper();
                            }
                            this.iShowList.BindGv(clsPaperEN_js_1.clsPaperEN._CurrTabName, returnBool.toString());
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
            $('#txtPaperId').attr('ReadOnly', bolReadonly.toString());
        }
        /**
         * 清除用户自定义控件中，所有控件的值
         * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_Clear)
         **/
        Clear() {
            const strThisFuncName = this.Clear.name;
            this.paperId = "";
            this.paperTitle = "";
            this.paperContent = "";
            this.periodical = "";
            this.author = "";
            this.researchQuestion = "";
            this.memo = "";
            this.keyword = "";
            this.literatureSources = "";
            this.literatureLink = "";
            this.uploadfileUrl = "";
            this.isQuotethesis = false;
            this.quoteId = "";
            this.isChecked = false;
            this.checker = "";
            this.literatureTypeId = "";
            this.browseNumber = 0;
            this.isSubmit = false;
            this.appraiseCount = 0;
            this.attachmentCount = 0;
            this.collectionCount = 0;
            this.downloadCount = 0;
            this.okCount = 0;
            this.pcount = 0;
            this.score = 0;
            this.stuScore = 0;
            this.paperTypeId = "";
            this.teaScore = 0;
            this.paperStatusId = "";
            this.versionCount = 0;
            this.isPublic = false;
            this.askQuestion = "";
            this.researchStatus = "";
            this.innovationPoints = "";
            this.researchDesign = "";
            this.dimensionDataProcess = "";
            this.expectedConclusion = "";
            $('#ddlShareId option[0]').attr("selected", "true");
            this.paperQCount = 0;
            this.subVCount = 0;
            this.tagsCount = 0;
            this.teaQCount = 0;
            this.createDate = "";
            this.updUser = "";
        }
        /** 为插入记录做准备工作
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
        **/
        async AddNewRecord() {
            const strThisFuncName = this.AddNewRecord.name;
            this.Clear();
            //wucPaperB1.paperId = Paper_GetMaxStrId_S();
            try {
                const returnString = await (0, clsPaperWApi_js_1.Paper_GetMaxStrIdAsync)();
                if (returnString == "") {
                    const strInfo = (0, clsString_js_1.Format)("获取表Paper的最大关键字为空，不成功，请检查!");
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    $('#txtPaperId').val(returnString);
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
            //wucPaperB1.paperId = Paper_GetMaxStrId_S();
        }
        /** 函数功能:把界面上的属性数据传到类对象中
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
        * @param pobjPaperEN">数据传输的目的类对象</param>
        **/
        async PutDataToPaperClass(pobjPaperEN) {
            const strThisFuncName = this.PutDataToPaperClass.name;
            pobjPaperEN.SetPaperId(this.paperId); // 论文Id
            pobjPaperEN.SetPaperTitle(this.paperTitle); // 论文标题
            pobjPaperEN.SetPaperContent(this.paperContent); // 主题内容
            pobjPaperEN.SetPeriodical(this.periodical); // 期刊
            pobjPaperEN.SetAuthor(this.author); // 作者
            pobjPaperEN.SetResearchQuestion(this.researchQuestion); // 研究问题
            pobjPaperEN.SetMemo(this.memo); // 备注
            pobjPaperEN.SetKeyword(this.keyword); // 关键字
            pobjPaperEN.SetLiteratureSources(this.literatureSources); // 文献来源
            pobjPaperEN.SetLiteratureLink(this.literatureLink); // 文献链接
            pobjPaperEN.SetUploadfileUrl(this.uploadfileUrl); // 文件地址
            pobjPaperEN.SetIsQuotethesis(this.isQuotethesis); // 是否引用论文
            pobjPaperEN.SetQuoteId(this.quoteId); // 引用Id
            pobjPaperEN.SetIsChecked(this.isChecked); // 是否检查
            pobjPaperEN.SetChecker(this.checker); // 审核人
            pobjPaperEN.SetLiteratureTypeId(this.literatureTypeId); // 文献类型Id
            pobjPaperEN.SetBrowseNumber(this.browseNumber); // 浏览量
            pobjPaperEN.SetIsSubmit(this.isSubmit); // 是否提交
            pobjPaperEN.SetAppraiseCount(this.appraiseCount); // 评论数
            pobjPaperEN.SetAttachmentCount(this.attachmentCount); // 附件计数
            pobjPaperEN.SetCollectionCount(this.collectionCount); // CollectionCount
            pobjPaperEN.SetDownloadCount(this.downloadCount); // DownloadCount
            pobjPaperEN.SetOkCount(this.okCount); // 点赞统计
            pobjPaperEN.SetPcount(this.pcount); // Pcount
            pobjPaperEN.SetScore(this.score); // 评分
            pobjPaperEN.SetStuScore(this.stuScore); // 学生平均分
            pobjPaperEN.SetPaperTypeId(this.paperTypeId); // 论文类型Id
            pobjPaperEN.SetTeaScore(this.teaScore); // 教师评分
            pobjPaperEN.SetPaperStatusId(this.paperStatusId); // 论文状态Id
            pobjPaperEN.SetVersionCount(this.versionCount); // 版本统计
            pobjPaperEN.SetIsPublic(this.isPublic); // 是否公开
            pobjPaperEN.SetAskQuestion(this.askQuestion); // 问题提出
            pobjPaperEN.SetResearchStatus(this.researchStatus); // 目前研究的现状
            pobjPaperEN.SetInnovationPoints(this.innovationPoints); // 创新点
            pobjPaperEN.SetResearchDesign(this.researchDesign); // 研究设计
            pobjPaperEN.SetDimensionDataProcess(this.dimensionDataProcess); // 数据处理的维度
            pobjPaperEN.SetExpectedConclusion(this.expectedConclusion); // 预期结论
            pobjPaperEN.SetShareId(this.shareId); // 分享Id
            pobjPaperEN.SetPaperQCount(this.paperQCount); // 论文答疑数
            pobjPaperEN.SetSubVCount(this.subVCount); // 论文子观点数
            pobjPaperEN.SetTagsCount(this.tagsCount); // 论文标注数
            pobjPaperEN.SetTeaQCount(this.teaQCount); // 教师提问数
            pobjPaperEN.SetCreateDate(this.createDate); // 建立日期
            pobjPaperEN.SetUpdUser(this.updUser); // 修改人
        }
        /** 添加新记录，保存函数
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
        **/
        async AddNewRecordSave() {
            const strThisFuncName = this.AddNewRecordSave.name;
            const objPaperEN = new clsPaperEN_js_1.clsPaperEN();
            try {
                await this.PutDataToPaperClass(objPaperEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("从界面获取数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                (0, clsPaperWApi_js_2.Paper_CheckPropertyNew)(objPaperEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("检查数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                //检查唯一性条件
                const bolIsExistCond_PaperTitle_Author = await this.CheckUniCond4Add_PaperTitle_Author(objPaperEN);
                if (bolIsExistCond_PaperTitle_Author == false) {
                    return false;
                }
                let returnBool = false;
                const returnKeyId = await (0, clsPaperWApi_js_3.Paper_AddNewRecordWithMaxIdAsync)(objPaperEN);
                if ((0, clsString_js_1.IsNullOrEmpty)(returnKeyId) == false) {
                    returnBool = true;
                }
                if (returnBool == true) {
                    //Paper_ReFreshCache();
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
        async CheckUniCond4Add_PaperTitle_Author(objPaperEN) {
            const strThisFuncName = this.CheckUniCond4Add_PaperTitle_Author.name;
            const strUniquenessCondition = (0, clsPaperWApi_js_4.Paper_GetUniCondStr_PaperTitle_Author)(objPaperEN);
            const bolIsExistCondition = await (0, clsPaperWApi_js_5.Paper_IsExistRecordAsync)(strUniquenessCondition);
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
        async CheckUniCond4Update_PaperTitle_Author(objPaperEN) {
            const strThisFuncName = this.CheckUniCond4Update_PaperTitle_Author.name;
            const strUniquenessCondition = (0, clsPaperWApi_js_6.Paper_GetUniCondStr4Update_PaperTitle_Author)(objPaperEN);
            const bolIsExistCondition = await (0, clsPaperWApi_js_5.Paper_IsExistRecordAsync)(strUniquenessCondition);
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
            const objPaperEN = new clsPaperEN_js_1.clsPaperEN();
            try {
                await this.PutDataToPaperClass(objPaperEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("从界面获取数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                throw (strMsg); //一定要有一个返回值，否则会出错！
            }
            try {
                (0, clsPaperWApi_js_2.Paper_CheckPropertyNew)(objPaperEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("检查数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                throw (strMsg); //一定要有一个返回值，否则会出错！
            }
            try {
                //检查唯一性条件
                const bolIsExistCond_PaperTitle_Author = await this.CheckUniCond4Add_PaperTitle_Author(objPaperEN);
                if (bolIsExistCond_PaperTitle_Author == false) {
                    return "";
                }
                const responseKeyId = await (0, clsPaperWApi_js_3.Paper_AddNewRecordWithMaxIdAsync)(objPaperEN);
                const returnKeyId = responseKeyId;
                if ((0, clsString_js_1.IsNullOrEmpty)(returnKeyId) == false) {
                    //Paper_ReFreshCache();
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
        * @param strPaperId: 表记录的关键字,显示该表关键字的内容
        **/
        async ShowData(strPaperId) {
            const strThisFuncName = this.ShowData.name;
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            let objPaperEN = new clsPaperEN_js_1.clsPaperEN();
            try {
                const returnBool = await (0, clsPaperWApi_js_7.Paper_IsExistAsync)(strPaperId);
                if (returnBool == false) {
                    const strInfo = (0, clsString_js_1.Format)("关键字:[{0}] 的记录不存在!", strPaperId);
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
                const objPaperEN_Const = await (0, clsPaperWApi_js_8.Paper_GetObjByPaperIdAsync)(strPaperId);
                if (objPaperEN_Const == null) {
                    const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                    console.error(strMsg);
                    alert(strMsg);
                    return;
                }
                objPaperEN = objPaperEN_Const;
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
            //3、用提供的关键字初始化一个类对象；
            this.GetDataFromPaperClass(objPaperEN);
        }
        /** 函数功能:把类对象的属性内容显示到界面上
        * 注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
        * 如果在设置数据库时,就应该一级字段在前,二级字段在后
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
        * @param pobjPaperEN">表实体类对象</param>
        **/
        async GetDataFromPaperClass(pobjPaperEN) {
            const strThisFuncName = this.GetDataFromPaperClass.name;
            this.paperId = pobjPaperEN.paperId; // 论文Id
            this.paperTitle = pobjPaperEN.paperTitle; // 论文标题
            this.paperContent = pobjPaperEN.paperContent; // 主题内容
            this.periodical = pobjPaperEN.periodical; // 期刊
            this.author = pobjPaperEN.author; // 作者
            this.researchQuestion = pobjPaperEN.researchQuestion; // 研究问题
            this.memo = pobjPaperEN.memo; // 备注
            this.keyword = pobjPaperEN.keyword; // 关键字
            this.literatureSources = pobjPaperEN.literatureSources; // 文献来源
            this.literatureLink = pobjPaperEN.literatureLink; // 文献链接
            this.uploadfileUrl = pobjPaperEN.uploadfileUrl; // 文件地址
            this.isQuotethesis = pobjPaperEN.isQuotethesis; // 是否引用论文
            this.quoteId = pobjPaperEN.quoteId; // 引用Id
            this.isChecked = pobjPaperEN.isChecked; // 是否检查
            this.checker = pobjPaperEN.checker; // 审核人
            this.literatureTypeId = pobjPaperEN.literatureTypeId; // 文献类型Id
            this.browseNumber = pobjPaperEN.browseNumber; // 浏览量
            this.isSubmit = pobjPaperEN.isSubmit; // 是否提交
            this.appraiseCount = pobjPaperEN.appraiseCount; // 评论数
            this.attachmentCount = pobjPaperEN.attachmentCount; // 附件计数
            this.collectionCount = pobjPaperEN.collectionCount; // CollectionCount
            this.downloadCount = pobjPaperEN.downloadCount; // DownloadCount
            this.okCount = pobjPaperEN.okCount; // 点赞统计
            this.pcount = pobjPaperEN.pcount; // Pcount
            this.score = pobjPaperEN.score; // 评分
            this.stuScore = pobjPaperEN.stuScore; // 学生平均分
            this.paperTypeId = pobjPaperEN.paperTypeId; // 论文类型Id
            this.teaScore = pobjPaperEN.teaScore; // 教师评分
            this.paperStatusId = pobjPaperEN.paperStatusId; // 论文状态Id
            this.versionCount = pobjPaperEN.versionCount; // 版本统计
            this.isPublic = pobjPaperEN.isPublic; // 是否公开
            this.askQuestion = pobjPaperEN.askQuestion; // 问题提出
            this.researchStatus = pobjPaperEN.researchStatus; // 目前研究的现状
            this.innovationPoints = pobjPaperEN.innovationPoints; // 创新点
            this.researchDesign = pobjPaperEN.researchDesign; // 研究设计
            this.dimensionDataProcess = pobjPaperEN.dimensionDataProcess; // 数据处理的维度
            this.expectedConclusion = pobjPaperEN.expectedConclusion; // 预期结论
            this.shareId = pobjPaperEN.shareId; // 分享Id
            this.paperQCount = pobjPaperEN.paperQCount; // 论文答疑数
            this.subVCount = pobjPaperEN.subVCount; // 论文子观点数
            this.tagsCount = pobjPaperEN.tagsCount; // 论文标注数
            this.teaQCount = pobjPaperEN.teaQCount; // 教师提问数
            this.createDate = pobjPaperEN.createDate; // 建立日期
            this.updUser = pobjPaperEN.updUser; // 修改人
        }
        /** 根据关键字获取相应的记录的对象
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
        * @param sender">参数列表</param>
        **/
        async UpdateRecord(strPaperId) {
            const strThisFuncName = this.UpdateRecord.name;
            this.keyId = strPaperId;
            try {
                const objPaperEN_Const = await (0, clsPaperWApi_js_8.Paper_GetObjByPaperIdAsync)(strPaperId);
                if (objPaperEN_Const == null) {
                    const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                    console.error(strMsg);
                    alert(strMsg);
                    return false;
                }
                this.objPaper = objPaperEN_Const;
                const conGetDataFromClass = await this.GetDataFromPaperClass(objPaperEN_Const);
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
            const objPaperEN = new clsPaperEN_js_1.clsPaperEN();
            objPaperEN.SetPaperId(this.keyId);
            await this.PutDataToPaperClass(objPaperEN);
            objPaperEN.sfUpdFldSetStr = objPaperEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objPaperEN.paperId == "" || objPaperEN.paperId == undefined) {
                console.error("关键字不能为空!");
                throw "关键字不能为空!";
            }
            try {
                (0, clsPaperWApi_js_9.Paper_CheckProperty4Update)(objPaperEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("检查数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                //检查唯一性条件
                const bolIsExistCond_PaperTitle_Author = await this.CheckUniCond4Update_PaperTitle_Author(objPaperEN);
                if (bolIsExistCond_PaperTitle_Author == false) {
                    return false;
                }
                const returnBool = await (0, clsPaperWApi_js_10.Paper_UpdateRecordAsync)(objPaperEN);
                if (returnBool == true) {
                    //Paper_ReFreshCache();
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
        * 问题提出 (Used In Clear())
        **/
        set askQuestion(value) {
            (0, clsCommFunc4Ctrl_js_1.SetTextAreaValueByIdInDiv)(this.divName4Edit, "txtAskQuestion", value);
        }
        /**
        * 问题提出 (Used In PutDataToClass())
        **/
        get askQuestion() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetTextAreaValueInDiv)(this.divName4Edit, "txtAskQuestion");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 附件计数 (Used In Clear())
        **/
        set attachmentCount(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtAttachmentCount", value.toString());
        }
        /**
        * 附件计数 (Used In PutDataToClass())
        **/
        get attachmentCount() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtAttachmentCount");
            if (strValue == undefined)
                return 0;
            else if ((0, clsString_js_1.IsNullOrEmpty)(strValue) == true)
                return 0;
            else
                return Number(strValue);
        }
        /**
        * 作者 (Used In Clear())
        **/
        set author(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtAuthor", value);
        }
        /**
        * 作者 (Used In PutDataToClass())
        **/
        get author() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtAuthor");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 浏览量 (Used In Clear())
        **/
        set browseNumber(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtBrowseNumber", value.toString());
        }
        /**
        * 浏览量 (Used In PutDataToClass())
        **/
        get browseNumber() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtBrowseNumber");
            if (strValue == undefined)
                return 0;
            else if ((0, clsString_js_1.IsNullOrEmpty)(strValue) == true)
                return 0;
            else
                return Number(strValue);
        }
        /**
        * 设置取消按钮的标题(Used In AddNewRecord())
        **/
        set btnCancel_Paper(value) {
            (0, clsCommFunc4Ctrl_js_1.SetButtonHtmlByIdInDiv)(this.divName4Edit, "btnCancel_Paper", value);
        }
        /**
        * 获取按钮的标题
        **/
        get btnSubmit_Paper() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetButtonHtmlInDiv)(this.divName4Edit, "btnSubmit_Paper");
            return strValue;
        }
        /**
        * 设置确定按钮的标题(Used In AddNewRecord())
        **/
        set btnSubmit_Paper(value) {
            (0, clsCommFunc4Ctrl_js_1.SetButtonHtmlByIdInDiv)(this.divName4Edit, "btnSubmit_Paper", value);
        }
        /**
        * 审核人 (Used In Clear())
        **/
        set checker(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtChecker", value);
        }
        /**
        * 审核人 (Used In PutDataToClass())
        **/
        get checker() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtChecker");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 收藏数 (Used In Clear())
        **/
        set collectionCount(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtCollectionCount", value.toString());
        }
        /**
        * 收藏数 (Used In PutDataToClass())
        **/
        get collectionCount() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtCollectionCount");
            if (strValue == undefined)
                return 0;
            else if ((0, clsString_js_1.IsNullOrEmpty)(strValue) == true)
                return 0;
            else
                return Number(strValue);
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
        * 数据处理的维度 (Used In Clear())
        **/
        set dimensionDataProcess(value) {
            (0, clsCommFunc4Ctrl_js_1.SetTextAreaValueByIdInDiv)(this.divName4Edit, "txtDimensionDataProcess", value);
        }
        /**
        * 数据处理的维度 (Used In PutDataToClass())
        **/
        get dimensionDataProcess() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetTextAreaValueInDiv)(this.divName4Edit, "txtDimensionDataProcess");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 下载数 (Used In Clear())
        **/
        set downloadCount(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtDownloadCount", value.toString());
        }
        /**
        * 下载数 (Used In PutDataToClass())
        **/
        get downloadCount() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtDownloadCount");
            if (strValue == undefined)
                return 0;
            else if ((0, clsString_js_1.IsNullOrEmpty)(strValue) == true)
                return 0;
            else
                return Number(strValue);
        }
        /**
        * 预期结论 (Used In Clear())
        **/
        set expectedConclusion(value) {
            (0, clsCommFunc4Ctrl_js_1.SetTextAreaValueByIdInDiv)(this.divName4Edit, "txtExpectedConclusion", value);
        }
        /**
        * 预期结论 (Used In PutDataToClass())
        **/
        get expectedConclusion() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetTextAreaValueInDiv)(this.divName4Edit, "txtExpectedConclusion");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 创新点 (Used In Clear())
        **/
        set innovationPoints(value) {
            (0, clsCommFunc4Ctrl_js_1.SetTextAreaValueByIdInDiv)(this.divName4Edit, "txtInnovationPoints", value);
        }
        /**
        * 创新点 (Used In PutDataToClass())
        **/
        get innovationPoints() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetTextAreaValueInDiv)(this.divName4Edit, "txtInnovationPoints");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 是否检查 (Used In Clear())
        **/
        set isChecked(value) {
            (0, clsCommFunc4Ctrl_js_1.SetCheckBoxValueByIdInDiv)(this.divName4Edit, "chkIsChecked", value);
        }
        /**
        * 是否检查 (Used In PutDataToClass())
        **/
        get isChecked() {
            const bolValue = (0, clsCommFunc4Ctrl_js_1.GetCheckBoxValueInDiv)(this.divName4Edit, "chkIsChecked");
            return bolValue;
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
        * 是否引用论文 (Used In Clear())
        **/
        set isQuotethesis(value) {
            (0, clsCommFunc4Ctrl_js_1.SetCheckBoxValueByIdInDiv)(this.divName4Edit, "chkIsQuotethesis", value);
        }
        /**
        * 是否引用论文 (Used In PutDataToClass())
        **/
        get isQuotethesis() {
            const bolValue = (0, clsCommFunc4Ctrl_js_1.GetCheckBoxValueInDiv)(this.divName4Edit, "chkIsQuotethesis");
            return bolValue;
        }
        /**
        * 是否提交 (Used In Clear())
        **/
        set isSubmit(value) {
            (0, clsCommFunc4Ctrl_js_1.SetCheckBoxValueByIdInDiv)(this.divName4Edit, "chkIsSubmit", value);
        }
        /**
        * 是否提交 (Used In PutDataToClass())
        **/
        get isSubmit() {
            const bolValue = (0, clsCommFunc4Ctrl_js_1.GetCheckBoxValueInDiv)(this.divName4Edit, "chkIsSubmit");
            return bolValue;
        }
        /**
        * 关键字 (Used In Clear())
        **/
        set keyword(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtKeyword", value);
        }
        /**
        * 关键字 (Used In PutDataToClass())
        **/
        get keyword() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtKeyword");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 文献链接 (Used In Clear())
        **/
        set literatureLink(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtLiteratureLink", value);
        }
        /**
        * 文献链接 (Used In PutDataToClass())
        **/
        get literatureLink() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtLiteratureLink");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 文献来源 (Used In Clear())
        **/
        set literatureSources(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtLiteratureSources", value);
        }
        /**
        * 文献来源 (Used In PutDataToClass())
        **/
        get literatureSources() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtLiteratureSources");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 作文类型Id (Used In Clear())
        **/
        set literatureTypeId(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtLiteratureTypeId", value);
        }
        /**
        * 作文类型Id (Used In PutDataToClass())
        **/
        get literatureTypeId() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtLiteratureTypeId");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
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
        * 主题内容 (Used In Clear())
        **/
        set paperContent(value) {
            (0, clsCommFunc4Ctrl_js_1.SetTextAreaValueByIdInDiv)(this.divName4Edit, "txtPaperContent", value);
        }
        /**
        * 主题内容 (Used In PutDataToClass())
        **/
        get paperContent() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetTextAreaValueInDiv)(this.divName4Edit, "txtPaperContent");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 论文Id (Used In Clear())
        **/
        set paperId(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtPaperId", value);
        }
        /**
        * 论文Id (Used In PutDataToClass())
        **/
        get paperId() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtPaperId");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 论文答疑数 (Used In Clear())
        **/
        set paperQCount(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtPaperQCount", value.toString());
        }
        /**
        * 论文答疑数 (Used In PutDataToClass())
        **/
        get paperQCount() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtPaperQCount");
            if (strValue == undefined)
                return 0;
            else if ((0, clsString_js_1.IsNullOrEmpty)(strValue) == true)
                return 0;
            else
                return Number(strValue);
        }
        /**
        * 论文状态Id (Used In Clear())
        **/
        set paperStatusId(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtPaperStatusId", value);
        }
        /**
        * 论文状态Id (Used In PutDataToClass())
        **/
        get paperStatusId() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtPaperStatusId");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 论文标题 (Used In Clear())
        **/
        set paperTitle(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtPaperTitle", value);
        }
        /**
        * 论文标题 (Used In PutDataToClass())
        **/
        get paperTitle() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtPaperTitle");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 论文类型Id (Used In Clear())
        **/
        set paperTypeId(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtPaperTypeId", value);
        }
        /**
        * 论文类型Id (Used In PutDataToClass())
        **/
        get paperTypeId() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtPaperTypeId");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 读写数 (Used In Clear())
        **/
        set pcount(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtPcount", value.toString());
        }
        /**
        * 读写数 (Used In PutDataToClass())
        **/
        get pcount() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtPcount");
            if (strValue == undefined)
                return 0;
            else if ((0, clsString_js_1.IsNullOrEmpty)(strValue) == true)
                return 0;
            else
                return Number(strValue);
        }
        /**
        * 期刊 (Used In Clear())
        **/
        set periodical(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtPeriodical", value);
        }
        /**
        * 期刊 (Used In PutDataToClass())
        **/
        get periodical() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtPeriodical");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 引用Id (Used In Clear())
        **/
        set quoteId(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtQuoteId", value);
        }
        /**
        * 引用Id (Used In PutDataToClass())
        **/
        get quoteId() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtQuoteId");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 研究设计 (Used In Clear())
        **/
        set researchDesign(value) {
            (0, clsCommFunc4Ctrl_js_1.SetTextAreaValueByIdInDiv)(this.divName4Edit, "txtResearchDesign", value);
        }
        /**
        * 研究设计 (Used In PutDataToClass())
        **/
        get researchDesign() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetTextAreaValueInDiv)(this.divName4Edit, "txtResearchDesign");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 研究问题 (Used In Clear())
        **/
        set researchQuestion(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtResearchQuestion", value);
        }
        /**
        * 研究问题 (Used In PutDataToClass())
        **/
        get researchQuestion() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtResearchQuestion");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 目前研究的现状 (Used In Clear())
        **/
        set researchStatus(value) {
            (0, clsCommFunc4Ctrl_js_1.SetTextAreaValueByIdInDiv)(this.divName4Edit, "txtResearchStatus", value);
        }
        /**
        * 目前研究的现状 (Used In PutDataToClass())
        **/
        get researchStatus() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetTextAreaValueInDiv)(this.divName4Edit, "txtResearchStatus");
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
        * 论文子观点数 (Used In Clear())
        **/
        set subVCount(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtSubVCount", value.toString());
        }
        /**
        * 论文子观点数 (Used In PutDataToClass())
        **/
        get subVCount() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtSubVCount");
            if (strValue == undefined)
                return 0;
            else if ((0, clsString_js_1.IsNullOrEmpty)(strValue) == true)
                return 0;
            else
                return Number(strValue);
        }
        /**
        * 论文标注数 (Used In Clear())
        **/
        set tagsCount(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtTagsCount", value.toString());
        }
        /**
        * 论文标注数 (Used In PutDataToClass())
        **/
        get tagsCount() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtTagsCount");
            if (strValue == undefined)
                return 0;
            else if ((0, clsString_js_1.IsNullOrEmpty)(strValue) == true)
                return 0;
            else
                return Number(strValue);
        }
        /**
        * 教师提问数 (Used In Clear())
        **/
        set teaQCount(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtTeaQCount", value.toString());
        }
        /**
        * 教师提问数 (Used In PutDataToClass())
        **/
        get teaQCount() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtTeaQCount");
            if (strValue == undefined)
                return 0;
            else if ((0, clsString_js_1.IsNullOrEmpty)(strValue) == true)
                return 0;
            else
                return Number(strValue);
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
        * 文件地址 (Used In Clear())
        **/
        set uploadfileUrl(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtUploadfileUrl", value);
        }
        /**
        * 文件地址 (Used In PutDataToClass())
        **/
        get uploadfileUrl() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtUploadfileUrl");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 版本统计 (Used In Clear())
        **/
        set versionCount(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtVersionCount", value.toString());
        }
        /**
        * 版本统计 (Used In PutDataToClass())
        **/
        get versionCount() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtVersionCount");
            if (strValue == undefined)
                return 0;
            else if ((0, clsString_js_1.IsNullOrEmpty)(strValue) == true)
                return 0;
            else
                return Number(strValue);
        }
    }
    exports.Paper_Edit = Paper_Edit;
    Paper_Edit.strPageDispModeId = "01"; //PopupBox(弹出框)
});