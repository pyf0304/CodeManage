(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../TS/L3_ForWApi/CourseLearning_Share/clscc_CourseWApi.js", "../../TS/L3_ForWApi/BaseInfo_Share/clsXzClgWApi.js", "../../TS/L3_ForWApi/SysPara/clsXzGradeBaseWApi.js", "../../TS/L3_ForWApi/SysPara/clsSchoolYearWApi.js", "../../TS/L3_ForWApi/SysPara/clsSchoolTermWApi.js", "../../TS/L3_ForWApi/DailyRunning/clsCurrEduClsWApi.js", "../../TS/L3_ForWApi/DailyRunning/clsCurrEduClsWApi.js", "../../TS/L3_ForWApi/DailyRunning/clsCurrEduClsWApi.js", "../../TS/L3_ForWApi/DailyRunning/clsCurrEduClsWApi.js", "../../TS/L3_ForWApi/DailyRunning/clsCurrEduClsWApi.js", "../../TS/L3_ForWApi/DailyRunning/clsCurrEduClsWApi.js", "../../TS/L3_ForWApi/DailyRunning/clsCurrEduClsWApi.js", "../../TS/L0_Entity/DailyRunning/clsCurrEduClsEN.js", "../../TS/L3_ForWApi/DailyRunning/clsCurrEduClsWApi.js", "../../TS/L3_ForWApi/DailyRunning/clsCurrEduClsWApi.js", "../../TS/L3_ForWApi/DailyRunning/clsCurrEduClsWApi.js", "../../TS/L3_ForWApi/DailyRunning/clsCurrEduClsWApi.js", "../../TS/PubFun/clsCommFunc4Ctrl.js", "../../TS/PubFun/clsString.js", "../../TS/PubFun/clsDateTime.js", "../../TS/L0_Entity/PrjMenu/clsPageDispModeEN.js", "../../TS/PubFun/clsPublocalStorage.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.CurrEduCls_Edit = void 0;
    /**
    * 类名:CurrEduCls_Edit(界面:CurrEduClsCRUD)
    * 表名:CurrEduCls(01120123)
    * 版本:2023.01.12.1(服务器:WIN-SRV103-116)
    * 日期:2023/01/12 16:39:56
    * 生成者:
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:日常运行(DailyRunning)
    * 框架-层名:WA_编辑区后台_TS(TS)(WA_ViewScript_EditCS_TS)
    * 编程语言:TypeScript
    **/
    //import $ from "jquery";
    const clscc_CourseWApi_js_1 = require("../../TS/L3_ForWApi/CourseLearning_Share/clscc_CourseWApi.js");
    const clsXzClgWApi_js_1 = require("../../TS/L3_ForWApi/BaseInfo_Share/clsXzClgWApi.js");
    const clsXzGradeBaseWApi_js_1 = require("../../TS/L3_ForWApi/SysPara/clsXzGradeBaseWApi.js");
    const clsSchoolYearWApi_js_1 = require("../../TS/L3_ForWApi/SysPara/clsSchoolYearWApi.js");
    const clsSchoolTermWApi_js_1 = require("../../TS/L3_ForWApi/SysPara/clsSchoolTermWApi.js");
    const clsCurrEduClsWApi_js_1 = require("../../TS/L3_ForWApi/DailyRunning/clsCurrEduClsWApi.js");
    const clsCurrEduClsWApi_js_2 = require("../../TS/L3_ForWApi/DailyRunning/clsCurrEduClsWApi.js");
    const clsCurrEduClsWApi_js_3 = require("../../TS/L3_ForWApi/DailyRunning/clsCurrEduClsWApi.js");
    const clsCurrEduClsWApi_js_4 = require("../../TS/L3_ForWApi/DailyRunning/clsCurrEduClsWApi.js");
    const clsCurrEduClsWApi_js_5 = require("../../TS/L3_ForWApi/DailyRunning/clsCurrEduClsWApi.js");
    const clsCurrEduClsWApi_js_6 = require("../../TS/L3_ForWApi/DailyRunning/clsCurrEduClsWApi.js");
    const clsCurrEduClsWApi_js_7 = require("../../TS/L3_ForWApi/DailyRunning/clsCurrEduClsWApi.js");
    const clsCurrEduClsEN_js_1 = require("../../TS/L0_Entity/DailyRunning/clsCurrEduClsEN.js");
    const clsCurrEduClsWApi_js_8 = require("../../TS/L3_ForWApi/DailyRunning/clsCurrEduClsWApi.js");
    const clsCurrEduClsWApi_js_9 = require("../../TS/L3_ForWApi/DailyRunning/clsCurrEduClsWApi.js");
    const clsCurrEduClsWApi_js_10 = require("../../TS/L3_ForWApi/DailyRunning/clsCurrEduClsWApi.js");
    const clsCurrEduClsWApi_js_11 = require("../../TS/L3_ForWApi/DailyRunning/clsCurrEduClsWApi.js");
    const clsCommFunc4Ctrl_js_1 = require("../../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsString_js_1 = require("../../TS/PubFun/clsString.js");
    const clsDateTime_js_1 = require("../../TS/PubFun/clsDateTime.js");
    const clsPageDispModeEN_js_1 = require("../../TS/L0_Entity/PrjMenu/clsPageDispModeEN.js");
    const clsPublocalStorage_js_1 = require("../../TS/PubFun/clsPublocalStorage.js");
    /** CurrEduCls_Edit 的摘要说明。其中Q代表查询,U代表修改
    * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:GeneCode)
    **/
    class CurrEduCls_Edit {
        constructor(objShowList) {
            this.opType = "";
            this.keyId = "";
            this.bolIsLoadEditRegion = false; //记录是否导入编辑区的变量
            this.divName4Edit = "divEdit"; //编辑区的Id
            this.iShowList = objShowList;
            CurrEduCls_Edit.objPage_Edit = this;
            this.objCurrEduCls = new clsCurrEduClsEN_js_1.clsCurrEduClsEN();
        }
        /**
        * 在当前界面中，导入编辑区域
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Edit)
        * @returns
        **/
        async AddDPV_Edit(divName4Edit) {
            const strThisFuncName = this.AddDPV_Edit.name;
            (0, clsCommFunc4Ctrl_js_1.CheckDivExist)(divName4Edit);
            const strUrl = "../DailyRunning/CurrEduCls_Edit";
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
        ShowDialog_CurrEduCls(strOp) {
            const strThisFuncName = this.ShowDialog_CurrEduCls.name;
            //检查相关控件是否存在
            (0, clsCommFunc4Ctrl_js_1.CheckControlExist)(this.divName4Edit, "div", "divEditDialog_CurrEduCls");
            (0, clsCommFunc4Ctrl_js_1.CheckControlExist)(this.divName4Edit, "h4", "lblDialogTitle_CurrEduCls");
            if (strOp === "Add" || strOp === "AddWithMaxId") {
                $('#lblDialogTitle_CurrEduCls').html('添加记录');
                //CurrEduCls_EditEx.GetMaxStrId('#txtid_CurrEduCls');
            }
            else if (strOp === "Update") {
                $('#lblDialogTitle_CurrEduCls').html('修改记录');
            }
            else if (strOp === "Detail") {
                $('#btnSubmit_CurrEduCls').hide();
                $('#lblDialogTitle_CurrEduCls').html('详细信息');
            }
            ShowDialog('#divEditDialog_CurrEduCls');
        }
        /**
        * 隐藏对话框
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_TS_HideDialog)
        **/
        HideDialog_CurrEduCls() {
            const strThisFuncName = this.HideDialog_CurrEduCls.name;
            (0, clsCommFunc4Ctrl_js_1.CheckControlExist)(this.divName4Edit, "div", "divEditDialog_CurrEduCls");
            HideDialog('#divEditDialog_CurrEduCls');
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
                    this.btnSubmit_CurrEduCls = "确认添加";
                    this.btnCancel_CurrEduCls = "取消添加";
                    const responseText = this.AddNewRecord();
                    if (CurrEduCls_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_CurrEduCls('Add');
                    }
                }
                else {
                    this.opType = "Add";
                    this.btnSubmit_CurrEduCls = "确认添加";
                    this.btnCancel_CurrEduCls = "取消添加";
                    const responseText = await this.AddNewRecord();
                    if (CurrEduCls_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_CurrEduCls('Add');
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
                    this.btnSubmit_CurrEduCls = "确认添加";
                    this.btnCancel_CurrEduCls = "取消添加";
                    const responseText = this.AddNewRecordWithMaxId();
                    if (CurrEduCls_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_CurrEduCls('Add');
                    }
                }
                else {
                    this.opType = "AddWithMaxId";
                    this.btnSubmit_CurrEduCls = "确认添加";
                    this.btnCancel_CurrEduCls = "取消添加";
                    const responseText = this.AddNewRecordWithMaxId();
                    if (CurrEduCls_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_CurrEduCls('Add');
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
        * 设置绑定下拉框，针对字段:[courseId]
        * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdlInDiv_TS4TabFeature)
        **/
        async SetDdl_CourseIdInDiv() {
            await (0, clscc_CourseWApi_js_1.cc_Course_BindDdl_CourseIdInDiv_Cache)(this.divName4Edit, "ddlCourseId"); //
        }
        /**
        * 设置绑定下拉框，针对字段:[id_XzCollege]
        * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdlInDiv_TS4TabFeature)
        **/
        async SetDdl_id_XzCollegeInDiv() {
            await (0, clsXzClgWApi_js_1.XzClg_BindDdl_id_XzCollegeInDiv_Cache)(this.divName4Edit, "ddlid_XzCollege"); //
        }
        /**
        * 设置绑定下拉框，针对字段:[id_GradeBase]
        * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdlInDiv_TS4TabFeature)
        **/
        async SetDdl_id_GradeBaseInDiv() {
            await (0, clsXzGradeBaseWApi_js_1.XzGradeBase_BindDdl_id_GradeBaseInDiv_Cache)(this.divName4Edit, "ddlid_GradeBase"); //
        }
        /**
        * 设置绑定下拉框，针对字段:[SchoolYear]
        * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdlInDiv_TS4TabFeature)
        **/
        async SetDdl_SchoolYearInDiv() {
            await (0, clsSchoolYearWApi_js_1.SchoolYear_BindDdl_SchoolYearInDiv_Cache)(this.divName4Edit, "ddlSchoolYear"); //
        }
        /**
        * 设置绑定下拉框，针对字段:[SchoolTerm]
        * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdlInDiv_TS4TabFeature)
        **/
        async SetDdl_SchoolTermInDiv() {
            await (0, clsSchoolTermWApi_js_1.SchoolTerm_BindDdl_SchoolTermInDiv_Cache)(this.divName4Edit, "ddlSchoolTerm"); //
        }
        /** 函数功能:为编辑区绑定下拉框
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegionInDiv)
        **/
        async BindDdl4EditRegionInDiv() {
            const strThisFuncName = this.BindDdl4EditRegionInDiv.name;
            // 在此处放置用户代码以初始化页面
            await this.SetDdl_CourseIdInDiv(); //编辑区域
            await this.SetDdl_id_XzCollegeInDiv(); //编辑区域
            await this.SetDdl_id_GradeBaseInDiv(); //编辑区域
            await this.SetDdl_SchoolYearInDiv(); //编辑区域
            await this.SetDdl_SchoolTermInDiv(); //编辑区域
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
                    this.btnSubmit_CurrEduCls = "确认修改";
                    this.btnCancel_CurrEduCls = "取消修改";
                    this.UpdateRecord(strKeyId);
                    if (CurrEduCls_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_CurrEduCls('Update');
                    }
                }
                else {
                    this.opType = "Update";
                    this.btnSubmit_CurrEduCls = "确认修改";
                    this.btnCancel_CurrEduCls = "取消修改";
                    this.UpdateRecord(strKeyId);
                    if (CurrEduCls_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_CurrEduCls('Update');
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
                    this.btnSubmit_CurrEduCls = "确认修改";
                    this.btnCancel_CurrEduCls = "取消修改";
                    const update = await this.UpdateRecord(strKeyId);
                    if (update == false) {
                        const strMsg = (0, clsString_js_1.Format)("在修改记录时,显示记录数据不成功!");
                        console.error(strMsg);
                        alert(strMsg);
                        return;
                    }
                    if (CurrEduCls_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_CurrEduCls('Update');
                    }
                }
                else {
                    this.opType = "Update";
                    this.btnSubmit_CurrEduCls = "确认修改";
                    this.btnCancel_CurrEduCls = "取消修改";
                    const update = await this.UpdateRecord(strKeyId);
                    if (update == false) {
                        const strMsg = (0, clsString_js_1.Format)("在修改记录时,显示记录数据不成功!");
                        console.error(strMsg);
                        alert(strMsg);
                        return;
                    }
                    if (CurrEduCls_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_CurrEduCls('Update');
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
            const strCommandText = this.btnSubmit_CurrEduCls;
            try {
                let returnBool = false;
                let returnKeyId = "";
                let strInfo = "";
                let strMsg = "";
                switch (strCommandText) {
                    case "添加":
                        this.btnSubmit_CurrEduCls = "确认添加";
                        this.btnCancel_CurrEduCls = "取消添加";
                        await this.AddNewRecord();
                        break;
                    case "确认添加":
                        //这是一个单表的插入的代码,由于逻辑层太简单,
                        //就把逻辑层合并到控制层,
                        if (this.opType == "AddWithMaxId") {
                            returnKeyId = await this.AddNewRecordWithMaxIdSave();
                            if ((0, clsString_js_1.IsNullOrEmpty)(returnKeyId) == false) {
                                if (CurrEduCls_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                                    this.HideDialog_CurrEduCls();
                                }
                                this.iShowList.BindGv(clsCurrEduClsEN_js_1.clsCurrEduClsEN._CurrTabName, returnKeyId);
                            }
                        }
                        else {
                            returnBool = await this.AddNewRecordSave();
                            if (returnBool == true) {
                                if (CurrEduCls_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                                    this.HideDialog_CurrEduCls();
                                }
                                this.iShowList.BindGv(clsCurrEduClsEN_js_1.clsCurrEduClsEN._CurrTabName, returnBool.toString());
                            }
                        }
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        returnBool = await this.UpdateRecordSave();
                        strInfo = returnBool ? "修改成功！" : "修改不成功！";
                        strInfo += "(In CurrEduCls_Edit.btnSubmit_Click)";
                        //显示信息框
                        //console.log(strInfo);
                        alert(strInfo);
                        if (returnBool == true) {
                            if (CurrEduCls_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                                this.HideDialog_CurrEduCls();
                            }
                            this.iShowList.BindGv(clsCurrEduClsEN_js_1.clsCurrEduClsEN._CurrTabName, returnBool.toString());
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
            this.currEduClsId = "";
            this.eduClsName = "";
            $('#ddlCourseId option[0]').attr("selected", "true");
            $('#ddlid_XzCollege option[0]').attr("selected", "true");
            $('#ddlid_GradeBase option[0]').attr("selected", "true");
            this.isEffective = false;
            $('#ddlSchoolYear option[0]').attr("selected", "true");
            $('#ddlSchoolTerm option[0]').attr("selected", "true");
            this.memo = "";
        }
        /** 为插入记录做准备工作
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
        **/
        async AddNewRecord() {
            const strThisFuncName = this.AddNewRecord.name;
            this.Clear();
            //wucCurrEduClsB1.id_CurrEduCls = CurrEduCls_GetMaxStrId_S();
            try {
                const returnString = await (0, clsCurrEduClsWApi_js_1.CurrEduCls_GetMaxStrIdAsync)();
                if (returnString == "") {
                    const strInfo = (0, clsString_js_1.Format)("获取表CurrEduCls的最大关键字为空，不成功，请检查!");
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    $('#txtid_CurrEduCls').val(returnString);
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
            //wucCurrEduClsB1.id_CurrEduCls = CurrEduCls_GetMaxStrId_S();
        }
        /** 函数功能:把界面上的属性数据传到类对象中
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
        * @param pobjCurrEduClsEN">数据传输的目的类对象</param>
        **/
        async PutDataToCurrEduClsClass(pobjCurrEduClsEN) {
            const strThisFuncName = this.PutDataToCurrEduClsClass.name;
            pobjCurrEduClsEN.SetCurrEduClsId(this.currEduClsId); // 教学班Id
            pobjCurrEduClsEN.SetEduClsName(this.eduClsName); // 教学班名称
            pobjCurrEduClsEN.SetCourseId(this.courseId); // 课程
            pobjCurrEduClsEN.Setid_XzCollege(this.id_XzCollege); // 学院
            pobjCurrEduClsEN.Setid_GradeBase(this.id_GradeBase); // 年级
            pobjCurrEduClsEN.SetIsEffective(this.isEffective); // 是否有效
            pobjCurrEduClsEN.SetSchoolYear(this.schoolYear); // 学年
            pobjCurrEduClsEN.SetSchoolTerm(this.schoolTerm); // 学期
            pobjCurrEduClsEN.SetMemo(this.memo); // 备注
            pobjCurrEduClsEN.SetModifyDate(clsDateTime_js_1.clsDateTime.getTodayDateTimeStr(1)); // 修改日期
            pobjCurrEduClsEN.SetModifyUserID(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改人
        }
        /** 添加新记录，保存函数
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
        **/
        async AddNewRecordSave() {
            const strThisFuncName = this.AddNewRecordSave.name;
            const objCurrEduClsEN = new clsCurrEduClsEN_js_1.clsCurrEduClsEN();
            try {
                await this.PutDataToCurrEduClsClass(objCurrEduClsEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("从界面获取数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                (0, clsCurrEduClsWApi_js_2.CurrEduCls_CheckPropertyNew)(objCurrEduClsEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("检查数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                //检查唯一性条件
                const bolIsExistCond_EduClsName = await this.CheckUniCond4Add_EduClsName(objCurrEduClsEN);
                if (bolIsExistCond_EduClsName == false) {
                    return false;
                }
                let returnBool = false;
                const returnKeyId = await (0, clsCurrEduClsWApi_js_3.CurrEduCls_AddNewRecordWithMaxIdAsync)(objCurrEduClsEN);
                if ((0, clsString_js_1.IsNullOrEmpty)(returnKeyId) == false) {
                    returnBool = true;
                }
                if (returnBool == true) {
                    (0, clsCurrEduClsWApi_js_4.CurrEduCls_ReFreshCache)(CurrEduCls_Edit.CourseId_Cache);
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
        async CheckUniCond4Add_EduClsName(objCurrEduClsEN) {
            const strThisFuncName = this.CheckUniCond4Add_EduClsName.name;
            const strUniquenessCondition = (0, clsCurrEduClsWApi_js_5.CurrEduCls_GetUniCondStr_EduClsName)(objCurrEduClsEN);
            const bolIsExistCondition = await (0, clsCurrEduClsWApi_js_6.CurrEduCls_IsExistRecordAsync)(strUniquenessCondition);
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
        async CheckUniCond4Update_EduClsName(objCurrEduClsEN) {
            const strThisFuncName = this.CheckUniCond4Update_EduClsName.name;
            const strUniquenessCondition = (0, clsCurrEduClsWApi_js_7.CurrEduCls_GetUniCondStr4Update_EduClsName)(objCurrEduClsEN);
            const bolIsExistCondition = await (0, clsCurrEduClsWApi_js_6.CurrEduCls_IsExistRecordAsync)(strUniquenessCondition);
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
            const objCurrEduClsEN = new clsCurrEduClsEN_js_1.clsCurrEduClsEN();
            try {
                await this.PutDataToCurrEduClsClass(objCurrEduClsEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("从界面获取数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                throw (strMsg); //一定要有一个返回值，否则会出错！
            }
            try {
                (0, clsCurrEduClsWApi_js_2.CurrEduCls_CheckPropertyNew)(objCurrEduClsEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("检查数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                throw (strMsg); //一定要有一个返回值，否则会出错！
            }
            try {
                //检查唯一性条件
                const bolIsExistCond_EduClsName = await this.CheckUniCond4Add_EduClsName(objCurrEduClsEN);
                if (bolIsExistCond_EduClsName == false) {
                    return "";
                }
                const responseKeyId = await (0, clsCurrEduClsWApi_js_3.CurrEduCls_AddNewRecordWithMaxIdAsync)(objCurrEduClsEN);
                const returnKeyId = responseKeyId;
                if ((0, clsString_js_1.IsNullOrEmpty)(returnKeyId) == false) {
                    (0, clsCurrEduClsWApi_js_4.CurrEduCls_ReFreshCache)(CurrEduCls_Edit.CourseId_Cache);
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
        * @param strid_CurrEduCls: 表记录的关键字,显示该表关键字的内容
        **/
        async ShowData(strid_CurrEduCls) {
            const strThisFuncName = this.ShowData.name;
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            let objCurrEduClsEN = new clsCurrEduClsEN_js_1.clsCurrEduClsEN();
            try {
                const returnBool = await (0, clsCurrEduClsWApi_js_8.CurrEduCls_IsExistAsync)(strid_CurrEduCls);
                if (returnBool == false) {
                    const strInfo = (0, clsString_js_1.Format)("关键字:[{0}] 的记录不存在!", strid_CurrEduCls);
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
                const objCurrEduClsEN_Const = await (0, clsCurrEduClsWApi_js_9.CurrEduCls_GetObjByid_CurrEduClsAsync)(strid_CurrEduCls);
                if (objCurrEduClsEN_Const == null) {
                    const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                    console.error(strMsg);
                    alert(strMsg);
                    return;
                }
                objCurrEduClsEN = objCurrEduClsEN_Const;
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
            //3、用提供的关键字初始化一个类对象；
            this.GetDataFromCurrEduClsClass(objCurrEduClsEN);
        }
        /** 函数功能:把类对象的属性内容显示到界面上
        * 注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
        * 如果在设置数据库时,就应该一级字段在前,二级字段在后
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
        * @param pobjCurrEduClsEN">表实体类对象</param>
        **/
        GetDataFromCurrEduClsClass(pobjCurrEduClsEN) {
            const strThisFuncName = this.GetDataFromCurrEduClsClass.name;
            this.currEduClsId = pobjCurrEduClsEN.currEduClsId; // 教学班Id
            this.eduClsName = pobjCurrEduClsEN.eduClsName; // 教学班名称
            this.courseId = pobjCurrEduClsEN.courseId; // 课程
            this.id_XzCollege = pobjCurrEduClsEN.id_XzCollege; // 学院
            this.id_GradeBase = pobjCurrEduClsEN.id_GradeBase; // 年级
            this.isEffective = pobjCurrEduClsEN.isEffective; // 是否有效
            this.schoolYear = pobjCurrEduClsEN.schoolYear; // 学年
            this.schoolTerm = pobjCurrEduClsEN.schoolTerm; // 学期
            this.memo = pobjCurrEduClsEN.memo; // 备注
        }
        /** 根据关键字获取相应的记录的对象
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
        * @param sender">参数列表</param>
        **/
        async UpdateRecord(strid_CurrEduCls) {
            const strThisFuncName = this.UpdateRecord.name;
            this.keyId = strid_CurrEduCls;
            try {
                const objCurrEduClsEN_Const = await (0, clsCurrEduClsWApi_js_9.CurrEduCls_GetObjByid_CurrEduClsAsync)(strid_CurrEduCls);
                if (objCurrEduClsEN_Const == null) {
                    const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                    console.error(strMsg);
                    alert(strMsg);
                    return false;
                }
                this.objCurrEduCls = objCurrEduClsEN_Const;
                const conGetDataFromClass = await this.GetDataFromCurrEduClsClass(objCurrEduClsEN_Const);
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
            const objCurrEduClsEN = new clsCurrEduClsEN_js_1.clsCurrEduClsEN();
            objCurrEduClsEN.Setid_CurrEduCls(this.keyId);
            await this.PutDataToCurrEduClsClass(objCurrEduClsEN);
            objCurrEduClsEN.sf_UpdFldSetStr = objCurrEduClsEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objCurrEduClsEN.id_CurrEduCls == "" || objCurrEduClsEN.id_CurrEduCls == undefined) {
                console.error("关键字不能为空!");
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            try {
                (0, clsCurrEduClsWApi_js_10.CurrEduCls_CheckProperty4Update)(objCurrEduClsEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("检查数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                //检查唯一性条件
                const bolIsExistCond_EduClsName = await this.CheckUniCond4Update_EduClsName(objCurrEduClsEN);
                if (bolIsExistCond_EduClsName == false) {
                    return false;
                }
                const returnBool = await (0, clsCurrEduClsWApi_js_11.CurrEduCls_UpdateRecordAsync)(objCurrEduClsEN);
                if (returnBool == true) {
                    (0, clsCurrEduClsWApi_js_4.CurrEduCls_ReFreshCache)(CurrEduCls_Edit.CourseId_Cache);
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
        set btnCancel_CurrEduCls(value) {
            (0, clsCommFunc4Ctrl_js_1.SetButtonHtmlByIdInDiv)(this.divName4Edit, "btnCancel_CurrEduCls", value);
        }
        /**
        * 获取按钮的标题
        **/
        get btnSubmit_CurrEduCls() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetButtonHtmlInDiv)(this.divName4Edit, "btnSubmit_CurrEduCls");
            return strValue;
        }
        /**
        * 设置确定按钮的标题(Used In AddNewRecord())
        **/
        set btnSubmit_CurrEduCls(value) {
            (0, clsCommFunc4Ctrl_js_1.SetButtonHtmlByIdInDiv)(this.divName4Edit, "btnSubmit_CurrEduCls", value);
        }
        /**
        * 课程Id (Used In Clear())
        **/
        set courseId(value) {
            (0, clsCommFunc4Ctrl_js_1.SetSelectValueByIdInDiv)(this.divName4Edit, "ddlCourseId", value);
        }
        /**
        * 课程Id (Used In PutDataToClass())
        **/
        get courseId() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetSelectValueInDiv)(this.divName4Edit, "ddlCourseId");
            if (strValue == undefined)
                return "";
            else if (strValue == "0")
                return "";
            else
                return strValue;
        }
        /**
        * 教学班Id (Used In Clear())
        **/
        set currEduClsId(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtCurrEduClsId", value);
        }
        /**
        * 教学班Id (Used In PutDataToClass())
        **/
        get currEduClsId() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtCurrEduClsId");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 教学班名 (Used In Clear())
        **/
        set eduClsName(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtEduClsName", value);
        }
        /**
        * 教学班名 (Used In PutDataToClass())
        **/
        get eduClsName() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtEduClsName");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 年级流水号 (Used In Clear())
        **/
        set id_GradeBase(value) {
            (0, clsCommFunc4Ctrl_js_1.SetSelectValueByIdInDiv)(this.divName4Edit, "ddlid_GradeBase", value);
        }
        /**
        * 年级流水号 (Used In PutDataToClass())
        **/
        get id_GradeBase() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetSelectValueInDiv)(this.divName4Edit, "ddlid_GradeBase");
            if (strValue == undefined)
                return "";
            else if (strValue == "0")
                return "";
            else
                return strValue;
        }
        /**
        * 学院流水号 (Used In Clear())
        **/
        set id_XzCollege(value) {
            (0, clsCommFunc4Ctrl_js_1.SetSelectValueByIdInDiv)(this.divName4Edit, "ddlid_XzCollege", value);
        }
        /**
        * 学院流水号 (Used In PutDataToClass())
        **/
        get id_XzCollege() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetSelectValueInDiv)(this.divName4Edit, "ddlid_XzCollege");
            if (strValue == undefined)
                return "";
            else if (strValue == "0")
                return "";
            else
                return strValue;
        }
        /**
        * 是否有效 (Used In Clear())
        **/
        set isEffective(value) {
            (0, clsCommFunc4Ctrl_js_1.SetCheckBoxValueByIdInDiv)(this.divName4Edit, "chkIsEffective", value);
        }
        /**
        * 是否有效 (Used In PutDataToClass())
        **/
        get isEffective() {
            const bolValue = (0, clsCommFunc4Ctrl_js_1.GetCheckBoxValueInDiv)(this.divName4Edit, "chkIsEffective");
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
        * 修改日期 (Used In PutDataToClass())
        **/
        get modifyDate() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtModifyDate");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 修改人 (Used In PutDataToClass())
        **/
        get modifyUserID() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtModifyUserID");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 学期 (Used In Clear())
        **/
        set schoolTerm(value) {
            (0, clsCommFunc4Ctrl_js_1.SetSelectValueByIdInDiv)(this.divName4Edit, "ddlSchoolTerm", value);
        }
        /**
        * 学期 (Used In PutDataToClass())
        **/
        get schoolTerm() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetSelectValueInDiv)(this.divName4Edit, "ddlSchoolTerm");
            if (strValue == undefined)
                return "";
            else if (strValue == "0")
                return "";
            else
                return strValue;
        }
        /**
        * 学年 (Used In Clear())
        **/
        set schoolYear(value) {
            (0, clsCommFunc4Ctrl_js_1.SetSelectValueByIdInDiv)(this.divName4Edit, "ddlSchoolYear", value);
        }
        /**
        * 学年 (Used In PutDataToClass())
        **/
        get schoolYear() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetSelectValueInDiv)(this.divName4Edit, "ddlSchoolYear");
            if (strValue == undefined)
                return "";
            else if (strValue == "0")
                return "";
            else
                return strValue;
        }
    }
    exports.CurrEduCls_Edit = CurrEduCls_Edit;
    CurrEduCls_Edit.CourseId_Cache = "";
    CurrEduCls_Edit.strPageDispModeId = "01"; //PopupBox(弹出框)
});
