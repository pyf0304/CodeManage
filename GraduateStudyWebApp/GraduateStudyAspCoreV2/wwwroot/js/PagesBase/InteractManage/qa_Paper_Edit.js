(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../TS/L3_ForWApiEx/GraduateEduPaper/clsvPaperSimProExWApi.js", "../../TS/L3_ForWApi/InteractManage/clsqa_PaperWApi.js", "../../TS/L3_ForWApi/InteractManage/clsqa_PaperWApi.js", "../../TS/L3_ForWApi/InteractManage/clsqa_PaperWApi.js", "../../TS/L3_ForWApi/InteractManage/clsqa_PaperWApi.js", "../../TS/L3_ForWApi/InteractManage/clsqa_PaperWApi.js", "../../TS/L3_ForWApi/InteractManage/clsqa_PaperWApi.js", "../../TS/L3_ForWApi/InteractManage/clsqa_PaperWApi.js", "../../TS/L0_Entity/InteractManage/clsqa_PaperEN.js", "../../TS/L3_ForWApi/InteractManage/clsqa_PaperWApi.js", "../../TS/L3_ForWApi/InteractManage/clsqa_PaperWApi.js", "../../TS/L3_ForWApi/InteractManage/clsqa_PaperWApi.js", "../../TS/L3_ForWApi/InteractManage/clsqa_PaperWApi.js", "../../TS/PubFun/clsCommFunc4Ctrl.js", "../../TS/PubFun/clsString.js", "../../TS/L0_Entity/PrjMenu/clsPageDispModeEN.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.qa_Paper_Edit = void 0;
    /**
    * 类名:qa_Paper_Edit(界面:qa_PaperCRUD)
    * 表名:qa_Paper(01120643)
    * 版本:2023.01.12.1(服务器:WIN-SRV103-116)
    * 日期:2023/01/12 16:38:09
    * 生成者:
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:互动管理(InteractManage)
    * 框架-层名:WA_编辑区后台_TS(TS)(WA_ViewScript_EditCS_TS)
    * 编程语言:TypeScript
    **/
    //import $ from "jquery";
    const clsvPaperSimProExWApi_js_1 = require("../../TS/L3_ForWApiEx/GraduateEduPaper/clsvPaperSimProExWApi.js");
    const clsqa_PaperWApi_js_1 = require("../../TS/L3_ForWApi/InteractManage/clsqa_PaperWApi.js");
    const clsqa_PaperWApi_js_2 = require("../../TS/L3_ForWApi/InteractManage/clsqa_PaperWApi.js");
    const clsqa_PaperWApi_js_3 = require("../../TS/L3_ForWApi/InteractManage/clsqa_PaperWApi.js");
    const clsqa_PaperWApi_js_4 = require("../../TS/L3_ForWApi/InteractManage/clsqa_PaperWApi.js");
    const clsqa_PaperWApi_js_5 = require("../../TS/L3_ForWApi/InteractManage/clsqa_PaperWApi.js");
    const clsqa_PaperWApi_js_6 = require("../../TS/L3_ForWApi/InteractManage/clsqa_PaperWApi.js");
    const clsqa_PaperWApi_js_7 = require("../../TS/L3_ForWApi/InteractManage/clsqa_PaperWApi.js");
    const clsqa_PaperEN_js_1 = require("../../TS/L0_Entity/InteractManage/clsqa_PaperEN.js");
    const clsqa_PaperWApi_js_8 = require("../../TS/L3_ForWApi/InteractManage/clsqa_PaperWApi.js");
    const clsqa_PaperWApi_js_9 = require("../../TS/L3_ForWApi/InteractManage/clsqa_PaperWApi.js");
    const clsqa_PaperWApi_js_10 = require("../../TS/L3_ForWApi/InteractManage/clsqa_PaperWApi.js");
    const clsqa_PaperWApi_js_11 = require("../../TS/L3_ForWApi/InteractManage/clsqa_PaperWApi.js");
    const clsCommFunc4Ctrl_js_1 = require("../../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsString_js_1 = require("../../TS/PubFun/clsString.js");
    const clsPageDispModeEN_js_1 = require("../../TS/L0_Entity/PrjMenu/clsPageDispModeEN.js");
    /** qa_Paper_Edit 的摘要说明。其中Q代表查询,U代表修改
    * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:GeneCode)
    **/
    class qa_Paper_Edit {
        constructor(objShowList) {
            this.opType = "";
            this.keyId = "";
            this.bolIsLoadEditRegion = false; //记录是否导入编辑区的变量
            this.divName4Edit = "divEdit"; //编辑区的Id
            this.iShowList = objShowList;
            qa_Paper_Edit.objPage_Edit = this;
            this.objqa_Paper = new clsqa_PaperEN_js_1.clsqa_PaperEN();
        }
        /**
        * 在当前界面中，导入编辑区域
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Edit)
        * @returns
        **/
        async AddDPV_Edit(divName4Edit) {
            const strThisFuncName = this.AddDPV_Edit.name;
            (0, clsCommFunc4Ctrl_js_1.CheckDivExist)(divName4Edit);
            const strUrl = "../InteractManage/qa_Paper_Edit";
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
        ShowDialog_qa_Paper(strOp) {
            const strThisFuncName = this.ShowDialog_qa_Paper.name;
            //检查相关控件是否存在
            (0, clsCommFunc4Ctrl_js_1.CheckControlExist)(this.divName4Edit, "div", "divEditDialog_qa_Paper");
            (0, clsCommFunc4Ctrl_js_1.CheckControlExist)(this.divName4Edit, "h4", "lblDialogTitle_qa_Paper");
            if (strOp === "Add" || strOp === "AddWithMaxId") {
                $('#lblDialogTitle_qa_Paper').html('添加记录');
                //qa_Paper_EditEx.GetMaxStrId('#txtqa_PaperId');
            }
            else if (strOp === "Update") {
                $('#lblDialogTitle_qa_Paper').html('修改记录');
            }
            else if (strOp === "Detail") {
                $('#btnSubmit_qa_Paper').hide();
                $('#lblDialogTitle_qa_Paper').html('详细信息');
            }
            ShowDialog('#divEditDialog_qa_Paper');
        }
        /**
        * 隐藏对话框
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_TS_HideDialog)
        **/
        HideDialog_qa_Paper() {
            const strThisFuncName = this.HideDialog_qa_Paper.name;
            (0, clsCommFunc4Ctrl_js_1.CheckControlExist)(this.divName4Edit, "div", "divEditDialog_qa_Paper");
            HideDialog('#divEditDialog_qa_Paper');
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
                    this.btnSubmit_qa_Paper = "确认添加";
                    this.btnCancel_qa_Paper = "取消添加";
                    const responseText = this.AddNewRecord();
                    if (qa_Paper_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_qa_Paper('Add');
                    }
                }
                else {
                    this.opType = "Add";
                    this.btnSubmit_qa_Paper = "确认添加";
                    this.btnCancel_qa_Paper = "取消添加";
                    const responseText = await this.AddNewRecord();
                    if (qa_Paper_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_qa_Paper('Add');
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
                    this.btnSubmit_qa_Paper = "确认添加";
                    this.btnCancel_qa_Paper = "取消添加";
                    const responseText = this.AddNewRecordWithMaxId();
                    if (qa_Paper_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_qa_Paper('Add');
                    }
                }
                else {
                    this.opType = "AddWithMaxId";
                    this.btnSubmit_qa_Paper = "确认添加";
                    this.btnCancel_qa_Paper = "取消添加";
                    const responseText = this.AddNewRecordWithMaxId();
                    if (qa_Paper_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_qa_Paper('Add');
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
        /** 函数功能:为编辑区绑定下拉框
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegionInDiv)
        **/
        async BindDdl4EditRegionInDiv() {
            const strThisFuncName = this.BindDdl4EditRegionInDiv.name;
            // 在此处放置用户代码以初始化页面
            const strid_CurrEduCls = qa_Paper_Edit.id_CurrEduCls_Static;
            await this.SetDdl_PaperIdInDiv(strid_CurrEduCls); //编辑区域
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
                    this.btnSubmit_qa_Paper = "确认修改";
                    this.btnCancel_qa_Paper = "取消修改";
                    this.UpdateRecord(strKeyId);
                    if (qa_Paper_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_qa_Paper('Update');
                    }
                }
                else {
                    this.opType = "Update";
                    this.btnSubmit_qa_Paper = "确认修改";
                    this.btnCancel_qa_Paper = "取消修改";
                    this.UpdateRecord(strKeyId);
                    if (qa_Paper_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_qa_Paper('Update');
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
                    this.btnSubmit_qa_Paper = "确认修改";
                    this.btnCancel_qa_Paper = "取消修改";
                    const update = await this.UpdateRecord(strKeyId);
                    if (update == false) {
                        const strMsg = (0, clsString_js_1.Format)("在修改记录时,显示记录数据不成功!");
                        console.error(strMsg);
                        alert(strMsg);
                        return;
                    }
                    if (qa_Paper_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_qa_Paper('Update');
                    }
                }
                else {
                    this.opType = "Update";
                    this.btnSubmit_qa_Paper = "确认修改";
                    this.btnCancel_qa_Paper = "取消修改";
                    const update = await this.UpdateRecord(strKeyId);
                    if (update == false) {
                        const strMsg = (0, clsString_js_1.Format)("在修改记录时,显示记录数据不成功!");
                        console.error(strMsg);
                        alert(strMsg);
                        return;
                    }
                    if (qa_Paper_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_qa_Paper('Update');
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
            const strCommandText = this.btnSubmit_qa_Paper;
            try {
                let returnBool = false;
                let returnKeyId = "";
                let strInfo = "";
                let strMsg = "";
                switch (strCommandText) {
                    case "添加":
                        this.btnSubmit_qa_Paper = "确认添加";
                        this.btnCancel_qa_Paper = "取消添加";
                        await this.AddNewRecord();
                        break;
                    case "确认添加":
                        //这是一个单表的插入的代码,由于逻辑层太简单,
                        //就把逻辑层合并到控制层,
                        if (this.opType == "AddWithMaxId") {
                            returnKeyId = await this.AddNewRecordWithMaxIdSave();
                            if ((0, clsString_js_1.IsNullOrEmpty)(returnKeyId) == false) {
                                if (qa_Paper_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                                    this.HideDialog_qa_Paper();
                                }
                                this.iShowList.BindGv(clsqa_PaperEN_js_1.clsqa_PaperEN._CurrTabName, returnKeyId);
                            }
                        }
                        else {
                            returnBool = await this.AddNewRecordSave();
                            if (returnBool == true) {
                                if (qa_Paper_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                                    this.HideDialog_qa_Paper();
                                }
                                this.iShowList.BindGv(clsqa_PaperEN_js_1.clsqa_PaperEN._CurrTabName, returnBool.toString());
                            }
                        }
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        returnBool = await this.UpdateRecordSave();
                        strInfo = returnBool ? "修改成功！" : "修改不成功！";
                        strInfo += "(In qa_Paper_Edit.btnSubmit_Click)";
                        //显示信息框
                        //console.log(strInfo);
                        alert(strInfo);
                        if (returnBool == true) {
                            if (qa_Paper_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                                this.HideDialog_qa_Paper();
                            }
                            this.iShowList.BindGv(clsqa_PaperEN_js_1.clsqa_PaperEN._CurrTabName, returnBool.toString());
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
            this.isPublic = false;
            this.memo = "";
        }
        /** 为插入记录做准备工作
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
        **/
        async AddNewRecord() {
            const strThisFuncName = this.AddNewRecord.name;
            this.Clear();
            //wucqa_PaperB1.qa_PaperId = qa_Paper_GetMaxStrId_S();
            try {
                const returnString = await (0, clsqa_PaperWApi_js_1.qa_Paper_GetMaxStrIdAsync)();
                if (returnString == "") {
                    const strInfo = (0, clsString_js_1.Format)("获取表qa_Paper的最大关键字为空，不成功，请检查!");
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    $('#txtqa_PaperId').val(returnString);
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
            //wucqa_PaperB1.qa_PaperId = qa_Paper_GetMaxStrId_S();
        }
        /** 函数功能:把界面上的属性数据传到类对象中
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
        * @param pobjqa_PaperEN">数据传输的目的类对象</param>
        **/
        async PutDataToqa_PaperClass(pobjqa_PaperEN) {
            const strThisFuncName = this.PutDataToqa_PaperClass.name;
            pobjqa_PaperEN.SetPaperId(this.paperId); // 论文Id
            pobjqa_PaperEN.SetIsPublic(this.isPublic); // 是否公开
            pobjqa_PaperEN.SetMemo(this.memo); // 备注
        }
        /** 添加新记录，保存函数
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
        **/
        async AddNewRecordSave() {
            const strThisFuncName = this.AddNewRecordSave.name;
            const objqa_PaperEN = new clsqa_PaperEN_js_1.clsqa_PaperEN();
            try {
                await this.PutDataToqa_PaperClass(objqa_PaperEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("从界面获取数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                (0, clsqa_PaperWApi_js_2.qa_Paper_CheckPropertyNew)(objqa_PaperEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("检查数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                //检查唯一性条件
                const bolIsExistCond_qa_PaperId = await this.CheckUniCond4Add_qa_PaperId(objqa_PaperEN);
                if (bolIsExistCond_qa_PaperId == false) {
                    return false;
                }
                let returnBool = false;
                const returnKeyId = await (0, clsqa_PaperWApi_js_3.qa_Paper_AddNewRecordWithMaxIdAsync)(objqa_PaperEN);
                if ((0, clsString_js_1.IsNullOrEmpty)(returnKeyId) == false) {
                    returnBool = true;
                }
                if (returnBool == true) {
                    (0, clsqa_PaperWApi_js_4.qa_Paper_ReFreshCache)(qa_Paper_Edit.id_CurrEduCls_Cache);
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
        async CheckUniCond4Add_qa_PaperId(objqa_PaperEN) {
            const strThisFuncName = this.CheckUniCond4Add_qa_PaperId.name;
            const strUniquenessCondition = (0, clsqa_PaperWApi_js_5.qa_Paper_GetUniCondStr_qa_PaperId)(objqa_PaperEN);
            const bolIsExistCondition = await (0, clsqa_PaperWApi_js_6.qa_Paper_IsExistRecordAsync)(strUniquenessCondition);
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
        async CheckUniCond4Update_qa_PaperId(objqa_PaperEN) {
            const strThisFuncName = this.CheckUniCond4Update_qa_PaperId.name;
            const strUniquenessCondition = (0, clsqa_PaperWApi_js_7.qa_Paper_GetUniCondStr4Update_qa_PaperId)(objqa_PaperEN);
            const bolIsExistCondition = await (0, clsqa_PaperWApi_js_6.qa_Paper_IsExistRecordAsync)(strUniquenessCondition);
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
            const objqa_PaperEN = new clsqa_PaperEN_js_1.clsqa_PaperEN();
            try {
                await this.PutDataToqa_PaperClass(objqa_PaperEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("从界面获取数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                throw (strMsg); //一定要有一个返回值，否则会出错！
            }
            try {
                (0, clsqa_PaperWApi_js_2.qa_Paper_CheckPropertyNew)(objqa_PaperEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("检查数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                throw (strMsg); //一定要有一个返回值，否则会出错！
            }
            try {
                //检查唯一性条件
                const bolIsExistCond_qa_PaperId = await this.CheckUniCond4Add_qa_PaperId(objqa_PaperEN);
                if (bolIsExistCond_qa_PaperId == false) {
                    return "";
                }
                const responseKeyId = await (0, clsqa_PaperWApi_js_3.qa_Paper_AddNewRecordWithMaxIdAsync)(objqa_PaperEN);
                const returnKeyId = responseKeyId;
                if ((0, clsString_js_1.IsNullOrEmpty)(returnKeyId) == false) {
                    (0, clsqa_PaperWApi_js_4.qa_Paper_ReFreshCache)(qa_Paper_Edit.id_CurrEduCls_Cache);
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
        * @param strqa_PaperId: 表记录的关键字,显示该表关键字的内容
        **/
        async ShowData(strqa_PaperId) {
            const strThisFuncName = this.ShowData.name;
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            let objqa_PaperEN = new clsqa_PaperEN_js_1.clsqa_PaperEN();
            try {
                const returnBool = await (0, clsqa_PaperWApi_js_8.qa_Paper_IsExistAsync)(strqa_PaperId);
                if (returnBool == false) {
                    const strInfo = (0, clsString_js_1.Format)("关键字:[{0}] 的记录不存在!", strqa_PaperId);
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
                const objqa_PaperEN_Const = await (0, clsqa_PaperWApi_js_9.qa_Paper_GetObjByqa_PaperIdAsync)(strqa_PaperId);
                if (objqa_PaperEN_Const == null) {
                    const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                    console.error(strMsg);
                    alert(strMsg);
                    return;
                }
                objqa_PaperEN = objqa_PaperEN_Const;
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
            //3、用提供的关键字初始化一个类对象；
            this.GetDataFromqa_PaperClass(objqa_PaperEN);
        }
        /** 函数功能:把类对象的属性内容显示到界面上
        * 注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
        * 如果在设置数据库时,就应该一级字段在前,二级字段在后
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
        * @param pobjqa_PaperEN">表实体类对象</param>
        **/
        GetDataFromqa_PaperClass(pobjqa_PaperEN) {
            const strThisFuncName = this.GetDataFromqa_PaperClass.name;
            this.paperId = pobjqa_PaperEN.paperId; // 论文Id
            this.isPublic = pobjqa_PaperEN.isPublic; // 是否公开
            this.memo = pobjqa_PaperEN.memo; // 备注
        }
        /** 根据关键字获取相应的记录的对象
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
        * @param sender">参数列表</param>
        **/
        async UpdateRecord(strqa_PaperId) {
            const strThisFuncName = this.UpdateRecord.name;
            this.keyId = strqa_PaperId;
            try {
                const objqa_PaperEN_Const = await (0, clsqa_PaperWApi_js_9.qa_Paper_GetObjByqa_PaperIdAsync)(strqa_PaperId);
                if (objqa_PaperEN_Const == null) {
                    const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                    console.error(strMsg);
                    alert(strMsg);
                    return false;
                }
                this.objqa_Paper = objqa_PaperEN_Const;
                const conGetDataFromClass = await this.GetDataFromqa_PaperClass(objqa_PaperEN_Const);
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
            const objqa_PaperEN = new clsqa_PaperEN_js_1.clsqa_PaperEN();
            objqa_PaperEN.Setqa_PaperId(this.keyId);
            await this.PutDataToqa_PaperClass(objqa_PaperEN);
            objqa_PaperEN.sf_UpdFldSetStr = objqa_PaperEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objqa_PaperEN.qa_PaperId == "" || objqa_PaperEN.qa_PaperId == undefined) {
                console.error("关键字不能为空!");
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            try {
                (0, clsqa_PaperWApi_js_10.qa_Paper_CheckProperty4Update)(objqa_PaperEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("检查数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                //检查唯一性条件
                const bolIsExistCond_qa_PaperId = await this.CheckUniCond4Update_qa_PaperId(objqa_PaperEN);
                if (bolIsExistCond_qa_PaperId == false) {
                    return false;
                }
                const returnBool = await (0, clsqa_PaperWApi_js_11.qa_Paper_UpdateRecordAsync)(objqa_PaperEN);
                if (returnBool == true) {
                    (0, clsqa_PaperWApi_js_4.qa_Paper_ReFreshCache)(qa_Paper_Edit.id_CurrEduCls_Cache);
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
        set btnCancel_qa_Paper(value) {
            (0, clsCommFunc4Ctrl_js_1.SetButtonHtmlByIdInDiv)(this.divName4Edit, "btnCancel_qa_Paper", value);
        }
        /**
        * 获取按钮的标题
        **/
        get btnSubmit_qa_Paper() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetButtonHtmlInDiv)(this.divName4Edit, "btnSubmit_qa_Paper");
            return strValue;
        }
        /**
        * 设置确定按钮的标题(Used In AddNewRecord())
        **/
        set btnSubmit_qa_Paper(value) {
            (0, clsCommFunc4Ctrl_js_1.SetButtonHtmlByIdInDiv)(this.divName4Edit, "btnSubmit_qa_Paper", value);
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
    }
    exports.qa_Paper_Edit = qa_Paper_Edit;
    qa_Paper_Edit.id_CurrEduCls_Cache = "";
    qa_Paper_Edit.id_CurrEduCls_Static = ""; //定义下拉框条件变量1
    qa_Paper_Edit.strPageDispModeId = "01"; //PopupBox(弹出框)
});
