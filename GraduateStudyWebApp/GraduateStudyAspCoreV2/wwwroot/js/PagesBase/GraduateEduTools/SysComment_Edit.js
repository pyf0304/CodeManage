(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../TS/L3_ForWApi/GraduateEduTools/clsSysCommentWApi.js", "../../TS/L3_ForWApi/GraduateEduTools/clsSysCommentWApi.js", "../../TS/L3_ForWApi/GraduateEduTools/clsSysCommentWApi.js", "../../TS/L3_ForWApi/GraduateEduTools/clsSysCommentWApi.js", "../../TS/L3_ForWApi/GraduateEduTools/clsSysCommentWApi.js", "../../TS/L3_ForWApi/GraduateEduTools/clsSysCommentWApi.js", "../../TS/L3_ForWApi/GraduateEduTools/clsSysCommentWApi.js", "../../TS/L0_Entity/GraduateEduTools/clsSysCommentEN.js", "../../TS/L3_ForWApi/GraduateEduTools/clsSysCommentWApi.js", "../../TS/L3_ForWApi/GraduateEduTools/clsSysCommentWApi.js", "../../TS/L3_ForWApi/GraduateEduTools/clsSysCommentWApi.js", "../../TS/L3_ForWApi/GraduateEduTools/clsSysCommentWApi.js", "../../TS/PubFun/clsCommFunc4Ctrl.js", "../../TS/PubFun/clsString.js", "../../TS/L0_Entity/PrjMenu/clsPageDispModeEN.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.SysComment_Edit = void 0;
    /**
    * 类名:SysComment_Edit(界面:SysCommentCRUD)
    * 表名:SysComment(01120622)
    * 版本:2023.01.12.1(服务器:WIN-SRV103-116)
    * 日期:2023/01/12 16:39:26
    * 生成者:
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:研培设置(GraduateEduTools)
    * 框架-层名:WA_编辑区后台_TS(TS)(WA_ViewScript_EditCS_TS)
    * 编程语言:TypeScript
    **/
    //import $ from "jquery";
    const clsSysCommentWApi_js_1 = require("../../TS/L3_ForWApi/GraduateEduTools/clsSysCommentWApi.js");
    const clsSysCommentWApi_js_2 = require("../../TS/L3_ForWApi/GraduateEduTools/clsSysCommentWApi.js");
    const clsSysCommentWApi_js_3 = require("../../TS/L3_ForWApi/GraduateEduTools/clsSysCommentWApi.js");
    const clsSysCommentWApi_js_4 = require("../../TS/L3_ForWApi/GraduateEduTools/clsSysCommentWApi.js");
    const clsSysCommentWApi_js_5 = require("../../TS/L3_ForWApi/GraduateEduTools/clsSysCommentWApi.js");
    const clsSysCommentWApi_js_6 = require("../../TS/L3_ForWApi/GraduateEduTools/clsSysCommentWApi.js");
    const clsSysCommentWApi_js_7 = require("../../TS/L3_ForWApi/GraduateEduTools/clsSysCommentWApi.js");
    const clsSysCommentEN_js_1 = require("../../TS/L0_Entity/GraduateEduTools/clsSysCommentEN.js");
    const clsSysCommentWApi_js_8 = require("../../TS/L3_ForWApi/GraduateEduTools/clsSysCommentWApi.js");
    const clsSysCommentWApi_js_9 = require("../../TS/L3_ForWApi/GraduateEduTools/clsSysCommentWApi.js");
    const clsSysCommentWApi_js_10 = require("../../TS/L3_ForWApi/GraduateEduTools/clsSysCommentWApi.js");
    const clsSysCommentWApi_js_11 = require("../../TS/L3_ForWApi/GraduateEduTools/clsSysCommentWApi.js");
    const clsCommFunc4Ctrl_js_1 = require("../../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsString_js_1 = require("../../TS/PubFun/clsString.js");
    const clsPageDispModeEN_js_1 = require("../../TS/L0_Entity/PrjMenu/clsPageDispModeEN.js");
    /** SysComment_Edit 的摘要说明。其中Q代表查询,U代表修改
    * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:GeneCode)
    **/
    class SysComment_Edit {
        constructor(objShowList) {
            this.opType = "";
            this.keyId = "";
            this.bolIsLoadEditRegion = false; //记录是否导入编辑区的变量
            this.divName4Edit = "divEdit"; //编辑区的Id
            this.iShowList = objShowList;
            SysComment_Edit.objPage_Edit = this;
            this.objSysComment = new clsSysCommentEN_js_1.clsSysCommentEN();
        }
        /**
        * 在当前界面中，导入编辑区域
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Edit)
        * @returns
        **/
        async AddDPV_Edit(divName4Edit) {
            const strThisFuncName = this.AddDPV_Edit.name;
            (0, clsCommFunc4Ctrl_js_1.CheckDivExist)(divName4Edit);
            const strUrl = "../GraduateEduTools/SysComment_Edit";
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
        ShowDialog_SysComment(strOp) {
            const strThisFuncName = this.ShowDialog_SysComment.name;
            //检查相关控件是否存在
            (0, clsCommFunc4Ctrl_js_1.CheckControlExist)(this.divName4Edit, "div", "divEditDialog_SysComment");
            (0, clsCommFunc4Ctrl_js_1.CheckControlExist)(this.divName4Edit, "h4", "lblDialogTitle_SysComment");
            if (strOp === "Add" || strOp === "AddWithMaxId") {
                $('#lblDialogTitle_SysComment').html('添加记录');
                //SysComment_EditEx.GetMaxStrId('#txtCommentId');
            }
            else if (strOp === "Update") {
                $('#lblDialogTitle_SysComment').html('修改记录');
            }
            else if (strOp === "Detail") {
                $('#btnSubmit_SysComment').hide();
                $('#lblDialogTitle_SysComment').html('详细信息');
            }
            ShowDialog('#divEditDialog_SysComment');
        }
        /**
        * 隐藏对话框
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_TS_HideDialog)
        **/
        HideDialog_SysComment() {
            const strThisFuncName = this.HideDialog_SysComment.name;
            (0, clsCommFunc4Ctrl_js_1.CheckControlExist)(this.divName4Edit, "div", "divEditDialog_SysComment");
            HideDialog('#divEditDialog_SysComment');
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
                    this.btnSubmit_SysComment = "确认添加";
                    this.btnCancel_SysComment = "取消添加";
                    const responseText = this.AddNewRecord();
                    if (SysComment_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_SysComment('Add');
                    }
                }
                else {
                    this.opType = "Add";
                    this.btnSubmit_SysComment = "确认添加";
                    this.btnCancel_SysComment = "取消添加";
                    const responseText = await this.AddNewRecord();
                    if (SysComment_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_SysComment('Add');
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
                    this.btnSubmit_SysComment = "确认添加";
                    this.btnCancel_SysComment = "取消添加";
                    const responseText = this.AddNewRecordWithMaxId();
                    if (SysComment_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_SysComment('Add');
                    }
                }
                else {
                    this.opType = "AddWithMaxId";
                    this.btnSubmit_SysComment = "确认添加";
                    this.btnCancel_SysComment = "取消添加";
                    const responseText = this.AddNewRecordWithMaxId();
                    if (SysComment_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_SysComment('Add');
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
                    this.btnSubmit_SysComment = "确认修改";
                    this.btnCancel_SysComment = "取消修改";
                    this.UpdateRecord(strKeyId);
                    if (SysComment_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_SysComment('Update');
                    }
                }
                else {
                    this.opType = "Update";
                    this.btnSubmit_SysComment = "确认修改";
                    this.btnCancel_SysComment = "取消修改";
                    this.UpdateRecord(strKeyId);
                    if (SysComment_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_SysComment('Update');
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
                    this.btnSubmit_SysComment = "确认修改";
                    this.btnCancel_SysComment = "取消修改";
                    const update = await this.UpdateRecord(strKeyId);
                    if (update == false) {
                        const strMsg = (0, clsString_js_1.Format)("在修改记录时,显示记录数据不成功!");
                        console.error(strMsg);
                        alert(strMsg);
                        return;
                    }
                    if (SysComment_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_SysComment('Update');
                    }
                }
                else {
                    this.opType = "Update";
                    this.btnSubmit_SysComment = "确认修改";
                    this.btnCancel_SysComment = "取消修改";
                    const update = await this.UpdateRecord(strKeyId);
                    if (update == false) {
                        const strMsg = (0, clsString_js_1.Format)("在修改记录时,显示记录数据不成功!");
                        console.error(strMsg);
                        alert(strMsg);
                        return;
                    }
                    if (SysComment_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_SysComment('Update');
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
            const strCommandText = this.btnSubmit_SysComment;
            try {
                let returnBool = false;
                let returnKeyId = "";
                let strInfo = "";
                let strMsg = "";
                switch (strCommandText) {
                    case "添加":
                        this.btnSubmit_SysComment = "确认添加";
                        this.btnCancel_SysComment = "取消添加";
                        await this.AddNewRecord();
                        break;
                    case "确认添加":
                        //这是一个单表的插入的代码,由于逻辑层太简单,
                        //就把逻辑层合并到控制层,
                        if (this.opType == "AddWithMaxId") {
                            returnKeyId = await this.AddNewRecordWithMaxIdSave();
                            if ((0, clsString_js_1.IsNullOrEmpty)(returnKeyId) == false) {
                                if (SysComment_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                                    this.HideDialog_SysComment();
                                }
                                this.iShowList.BindGv(clsSysCommentEN_js_1.clsSysCommentEN._CurrTabName, returnKeyId);
                            }
                        }
                        else {
                            returnBool = await this.AddNewRecordSave();
                            if (returnBool == true) {
                                if (SysComment_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                                    this.HideDialog_SysComment();
                                }
                                this.iShowList.BindGv(clsSysCommentEN_js_1.clsSysCommentEN._CurrTabName, returnBool.toString());
                            }
                        }
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        returnBool = await this.UpdateRecordSave();
                        strInfo = returnBool ? "修改成功！" : "修改不成功！";
                        strInfo += "(In SysComment_Edit.btnSubmit_Click)";
                        //显示信息框
                        //console.log(strInfo);
                        alert(strInfo);
                        if (returnBool == true) {
                            if (SysComment_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                                this.HideDialog_SysComment();
                            }
                            this.iShowList.BindGv(clsSysCommentEN_js_1.clsSysCommentEN._CurrTabName, returnBool.toString());
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
            $('#txtCommentId').attr('ReadOnly', bolReadonly.toString());
        }
        /**
         * 清除用户自定义控件中，所有控件的值
         * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_Clear)
         **/
        Clear() {
            const strThisFuncName = this.Clear.name;
            this.commentId = "";
            this.comment = "";
            this.score = 0;
            this.commentTypeId = "";
            this.scoreType = "";
            this.parentId = "";
            this.tableKey = "";
            this.updUser = "";
            this.updDate = "";
            this.memo = "";
        }
        /** 为插入记录做准备工作
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
        **/
        async AddNewRecord() {
            const strThisFuncName = this.AddNewRecord.name;
            this.Clear();
            //wucSysCommentB1.commentId = SysComment_GetMaxStrId_S();
            try {
                const returnString = await (0, clsSysCommentWApi_js_1.SysComment_GetMaxStrIdAsync)();
                if (returnString == "") {
                    const strInfo = (0, clsString_js_1.Format)("获取表SysComment的最大关键字为空，不成功，请检查!");
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    $('#txtCommentId').val(returnString);
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
            //wucSysCommentB1.commentId = SysComment_GetMaxStrId_S();
        }
        /** 函数功能:把界面上的属性数据传到类对象中
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
        * @param pobjSysCommentEN">数据传输的目的类对象</param>
        **/
        async PutDataToSysCommentClass(pobjSysCommentEN) {
            const strThisFuncName = this.PutDataToSysCommentClass.name;
            pobjSysCommentEN.SetCommentId(this.commentId); // 评论Id
            pobjSysCommentEN.SetComment(this.comment); // 评论
            pobjSysCommentEN.SetScore(this.score); // 评分
            pobjSysCommentEN.SetCommentTypeId(this.commentTypeId); // 评论类型Id
            pobjSysCommentEN.SetScoreType(this.scoreType); // 评分类型
            pobjSysCommentEN.SetParentId(this.parentId); // 父Id
            pobjSysCommentEN.SetTableKey(this.tableKey); // 表主键
            pobjSysCommentEN.SetUpdUser(this.updUser); // 修改人
            pobjSysCommentEN.SetUpdDate(this.updDate); // 修改日期
            pobjSysCommentEN.SetMemo(this.memo); // 备注
        }
        /** 添加新记录，保存函数
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
        **/
        async AddNewRecordSave() {
            const strThisFuncName = this.AddNewRecordSave.name;
            const objSysCommentEN = new clsSysCommentEN_js_1.clsSysCommentEN();
            try {
                await this.PutDataToSysCommentClass(objSysCommentEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("从界面获取数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                (0, clsSysCommentWApi_js_2.SysComment_CheckPropertyNew)(objSysCommentEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("检查数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                //检查唯一性条件
                const bolIsExistCond_CommentId = await this.CheckUniCond4Add_CommentId(objSysCommentEN);
                if (bolIsExistCond_CommentId == false) {
                    return false;
                }
                let returnBool = false;
                const returnKeyId = await (0, clsSysCommentWApi_js_3.SysComment_AddNewRecordWithMaxIdAsync)(objSysCommentEN);
                if ((0, clsString_js_1.IsNullOrEmpty)(returnKeyId) == false) {
                    returnBool = true;
                }
                if (returnBool == true) {
                    (0, clsSysCommentWApi_js_4.SysComment_ReFreshCache)(SysComment_Edit.id_CurrEduCls_Cache);
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
        async CheckUniCond4Add_CommentId(objSysCommentEN) {
            const strThisFuncName = this.CheckUniCond4Add_CommentId.name;
            const strUniquenessCondition = (0, clsSysCommentWApi_js_5.SysComment_GetUniCondStr_CommentId)(objSysCommentEN);
            const bolIsExistCondition = await (0, clsSysCommentWApi_js_6.SysComment_IsExistRecordAsync)(strUniquenessCondition);
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
        async CheckUniCond4Update_CommentId(objSysCommentEN) {
            const strThisFuncName = this.CheckUniCond4Update_CommentId.name;
            const strUniquenessCondition = (0, clsSysCommentWApi_js_7.SysComment_GetUniCondStr4Update_CommentId)(objSysCommentEN);
            const bolIsExistCondition = await (0, clsSysCommentWApi_js_6.SysComment_IsExistRecordAsync)(strUniquenessCondition);
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
            const objSysCommentEN = new clsSysCommentEN_js_1.clsSysCommentEN();
            try {
                await this.PutDataToSysCommentClass(objSysCommentEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("从界面获取数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                throw (strMsg); //一定要有一个返回值，否则会出错！
            }
            try {
                (0, clsSysCommentWApi_js_2.SysComment_CheckPropertyNew)(objSysCommentEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("检查数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                throw (strMsg); //一定要有一个返回值，否则会出错！
            }
            try {
                //检查唯一性条件
                const bolIsExistCond_CommentId = await this.CheckUniCond4Add_CommentId(objSysCommentEN);
                if (bolIsExistCond_CommentId == false) {
                    return "";
                }
                const responseKeyId = await (0, clsSysCommentWApi_js_3.SysComment_AddNewRecordWithMaxIdAsync)(objSysCommentEN);
                const returnKeyId = responseKeyId;
                if ((0, clsString_js_1.IsNullOrEmpty)(returnKeyId) == false) {
                    (0, clsSysCommentWApi_js_4.SysComment_ReFreshCache)(SysComment_Edit.id_CurrEduCls_Cache);
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
        * @param strCommentId: 表记录的关键字,显示该表关键字的内容
        **/
        async ShowData(strCommentId) {
            const strThisFuncName = this.ShowData.name;
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            let objSysCommentEN = new clsSysCommentEN_js_1.clsSysCommentEN();
            try {
                const returnBool = await (0, clsSysCommentWApi_js_8.SysComment_IsExistAsync)(strCommentId);
                if (returnBool == false) {
                    const strInfo = (0, clsString_js_1.Format)("关键字:[{0}] 的记录不存在!", strCommentId);
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
                const objSysCommentEN_Const = await (0, clsSysCommentWApi_js_9.SysComment_GetObjByCommentIdAsync)(strCommentId);
                if (objSysCommentEN_Const == null) {
                    const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                    console.error(strMsg);
                    alert(strMsg);
                    return;
                }
                objSysCommentEN = objSysCommentEN_Const;
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
            //3、用提供的关键字初始化一个类对象；
            this.GetDataFromSysCommentClass(objSysCommentEN);
        }
        /** 函数功能:把类对象的属性内容显示到界面上
        * 注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
        * 如果在设置数据库时,就应该一级字段在前,二级字段在后
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
        * @param pobjSysCommentEN">表实体类对象</param>
        **/
        GetDataFromSysCommentClass(pobjSysCommentEN) {
            const strThisFuncName = this.GetDataFromSysCommentClass.name;
            this.commentId = pobjSysCommentEN.commentId; // 评论Id
            this.comment = pobjSysCommentEN.comment; // 评论
            this.score = pobjSysCommentEN.score; // 评分
            this.commentTypeId = pobjSysCommentEN.commentTypeId; // 评论类型Id
            this.scoreType = pobjSysCommentEN.scoreType; // 评分类型
            this.parentId = pobjSysCommentEN.parentId; // 父Id
            this.tableKey = pobjSysCommentEN.tableKey; // 表主键
            this.updUser = pobjSysCommentEN.updUser; // 修改人
            this.updDate = pobjSysCommentEN.updDate; // 修改日期
            this.memo = pobjSysCommentEN.memo; // 备注
        }
        /** 根据关键字获取相应的记录的对象
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
        * @param sender">参数列表</param>
        **/
        async UpdateRecord(strCommentId) {
            const strThisFuncName = this.UpdateRecord.name;
            this.keyId = strCommentId;
            try {
                const objSysCommentEN_Const = await (0, clsSysCommentWApi_js_9.SysComment_GetObjByCommentIdAsync)(strCommentId);
                if (objSysCommentEN_Const == null) {
                    const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                    console.error(strMsg);
                    alert(strMsg);
                    return false;
                }
                this.objSysComment = objSysCommentEN_Const;
                const conGetDataFromClass = await this.GetDataFromSysCommentClass(objSysCommentEN_Const);
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
            const objSysCommentEN = new clsSysCommentEN_js_1.clsSysCommentEN();
            objSysCommentEN.commentId = this.keyId;
            await this.PutDataToSysCommentClass(objSysCommentEN);
            objSysCommentEN.sf_UpdFldSetStr = objSysCommentEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objSysCommentEN.commentId == "" || objSysCommentEN.commentId == undefined) {
                console.error("关键字不能为空!");
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            try {
                (0, clsSysCommentWApi_js_10.SysComment_CheckProperty4Update)(objSysCommentEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("检查数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                //检查唯一性条件
                const bolIsExistCond_CommentId = await this.CheckUniCond4Update_CommentId(objSysCommentEN);
                if (bolIsExistCond_CommentId == false) {
                    return false;
                }
                const returnBool = await (0, clsSysCommentWApi_js_11.SysComment_UpdateRecordAsync)(objSysCommentEN);
                if (returnBool == true) {
                    (0, clsSysCommentWApi_js_4.SysComment_ReFreshCache)(SysComment_Edit.id_CurrEduCls_Cache);
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
        set btnCancel_SysComment(value) {
            (0, clsCommFunc4Ctrl_js_1.SetButtonHtmlByIdInDiv)(this.divName4Edit, "btnCancel_SysComment", value);
        }
        /**
        * 获取按钮的标题
        **/
        get btnSubmit_SysComment() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetButtonHtmlInDiv)(this.divName4Edit, "btnSubmit_SysComment");
            return strValue;
        }
        /**
        * 设置确定按钮的标题(Used In AddNewRecord())
        **/
        set btnSubmit_SysComment(value) {
            (0, clsCommFunc4Ctrl_js_1.SetButtonHtmlByIdInDiv)(this.divName4Edit, "btnSubmit_SysComment", value);
        }
        /**
        * 评论 (Used In Clear())
        **/
        set comment(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtComment", value);
        }
        /**
        * 评论 (Used In PutDataToClass())
        **/
        get comment() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtComment");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 评论Id (Used In Clear())
        **/
        set commentId(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtCommentId", value);
        }
        /**
        * 评论Id (Used In PutDataToClass())
        **/
        get commentId() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtCommentId");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 评论类型Id (Used In Clear())
        **/
        set commentTypeId(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtCommentTypeId", value);
        }
        /**
        * 评论类型Id (Used In PutDataToClass())
        **/
        get commentTypeId() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtCommentTypeId");
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
        * 父Id (Used In Clear())
        **/
        set parentId(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtParentId", value);
        }
        /**
        * 父Id (Used In PutDataToClass())
        **/
        get parentId() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtParentId");
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
        * 评分类型 (Used In Clear())
        **/
        set scoreType(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtScoreType", value);
        }
        /**
        * 评分类型 (Used In PutDataToClass())
        **/
        get scoreType() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtScoreType");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 表主键 (Used In Clear())
        **/
        set tableKey(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtTableKey", value);
        }
        /**
        * 表主键 (Used In PutDataToClass())
        **/
        get tableKey() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtTableKey");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
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
    }
    exports.SysComment_Edit = SysComment_Edit;
    SysComment_Edit.id_CurrEduCls_Cache = "";
    SysComment_Edit.strPageDispModeId = "01"; //PopupBox(弹出框)
});
