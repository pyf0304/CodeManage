/*-- -- -- -- -- -- -- -- -- -- --
类名:gs_TeachingDate_EditEx
表名:gs_TeachingDate(01120684)
生成代码版本:2020.07.25.1
生成日期:2020/07/27 14:20:26
生成者:
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:研培设置
模块英文名:GraduateEduTools
框架-层名:WA_编辑区后台Ex_TS(WA_ViewScript_EditCSEx_TS)
编程语言:TypeScript
== == == == == == == == == == == ==
*/
///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//
//import * as QQ from "q";
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/L0_Entity/GraduateEduTools/clsgs_TeachingDateEN.js", "../TS/L0_Entity/GraduateEduTools/clsvgs_TeachingDateEN.js", "../TS/L3_ForWApi/GraduateEduTools/clsgs_TeachingDateWApi.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js", "../TS/L3_ForWApiEx/GraduateEdu/clsSysCommentExWApi.js", "../PagesBase/GraduateEduTools/gs_TeachingDate_Edit.js", "../TS/PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_TeachingDate_EditEx = void 0;
    //import { gs_TeachingDateCRUDEx } from "./gs_TeachingDateCRUDEx.js";
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    const clsgs_TeachingDateEN_js_1 = require("../TS/L0_Entity/GraduateEduTools/clsgs_TeachingDateEN.js");
    const clsvgs_TeachingDateEN_js_1 = require("../TS/L0_Entity/GraduateEduTools/clsvgs_TeachingDateEN.js");
    const clsgs_TeachingDateWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTools/clsgs_TeachingDateWApi.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsgs_TotalDataStatisticsExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js");
    const clsSysCommentExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEdu/clsSysCommentExWApi.js");
    const gs_TeachingDate_Edit_js_1 = require("../PagesBase/GraduateEduTools/gs_TeachingDate_Edit.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    /* gs_TeachingDate_EditEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
    */
    class gs_TeachingDate_EditEx extends gs_TeachingDate_Edit_js_1.gs_TeachingDate_Edit {
        /*
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
        */
        static btnEdit_Click(strCommandName, strKeyId) {
            var objPage = gs_TeachingDate_Edit_js_1.gs_TeachingDate_Edit.objPage_Edit;
            //if (objPage == null) {
            //    var objgs_TeachingDateCRUD: gs_TeachingDateCRUDEx = new gs_TeachingDateCRUDEx();
            //    objPage = new gs_TeachingDate_EditEx(objgs_TeachingDateCRUD);
            //}
            switch (strCommandName) {
                case "AddNewRecordWithMaxId": //添加记录使用最大关键字
                    //objPage.btnAddNewRecordWithMaxId_Click();
                    break;
                case "CreateWithMaxId": //添加记录使用最大关键字
                    //objPage.btnAddNewRecordWithMaxId_Click();
                    break;
                case "AddNewRecord": //添加记录
                case "Create": //添加记录
                    objPage.btnAddNewRecord_Click();
                    break;
                case "UpdateRecordInTab": //修改记录InTab
                    objPage.btnUpdateRecordInTab_Click(strKeyId);
                    break;
                case "Submit": //提交
                    objPage.btnSubmit_Click();
                    break;
                default:
                    var strMsg = '命令:' + strCommandName + "在函数(gs_TeachingDate_EditEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
            }
        }
        /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
     具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
    */
        async btnSubmit_Click() {
            var strCommandText = this.btnSubmit_gs_TeachingDate;
            //判断如果教学班文本框没有数据，那么就取标题栏下拉框的缓存数据
            if ($("#txtid_CurrEduCls").val() == "") {
                var strId_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
            }
            else {
                var strId_CurrEduCls = $("#txtid_CurrEduCls").val();
            }
            try {
                //判断session是否失效
                if (clsPublocalStorage_js_1.clsPublocalStorage.userId != "") {
                    switch (strCommandText) {
                        case "添加":
                            const responseText1 = await this.AddNewRecord();
                            break;
                        case "确认添加":
                            //这是一个单表的插入的代码,由于逻辑层太简单,
                            //就把逻辑层合并到控制层,
                            if (this.opType == "AddWithMaxId") {
                                //const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData)=>{
                                //var returnKeyId: string = <string>jsonData;
                                //if (IsNullOrEmpty(returnKeyId) == false)
                                //{
                                //HideDialog_gs_TeachingDate();
                                //this.iShowList.BindGv_Cache(clsvgs_TeachingDateEN._CurrTabName);
                                //}
                                //});
                            }
                            else {
                                const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                                    var returnBool = jsonData;
                                    if (returnBool == true) {
                                        this.HideDialog_gs_TeachingDate();
                                        this.iShowList.BindGv(clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN._CurrTabName, "");
                                        //数据同步；
                                        const responseText4 = (0, clsgs_TotalDataStatisticsExWApi_js_1.gs_TotalDataStatisticsEx_GetTotalStatisticsByTableAsync)(strId_CurrEduCls, clsPublocalStorage_js_1.clsPublocalStorage.userId);
                                        var returnBool3 = !!responseText4;
                                        if (returnBool3 == true) {
                                            const responseText5 = (0, clsSysCommentExWApi_js_1.SysCommentEx_UpdateCommentWeekAsync)(strId_CurrEduCls, clsPublocalStorage_js_1.clsPublocalStorage.userId);
                                            var returnBool5 = !!responseText5;
                                            if (returnBool5 == true) {
                                                console.log("同步成功");
                                            }
                                            else {
                                                console.log("同步数据成功,但同步评论出错");
                                            }
                                        }
                                        else {
                                            console.log("同步失败");
                                        }
                                    }
                                });
                            }
                            break;
                        case "确认修改":
                            //这是一个单表的修改的代码,由于逻辑层太简单,
                            const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                var strInfo = returnBool ? "修改成功！" : "修改不成功！";
                                strInfo += "(In gs_TeachingDate_Edit.btnSubmit_Click)";
                                $('#lblResult51').val(strInfo);
                                //显示信息框
                                console.log(strInfo);
                                alert(strInfo);
                                if (returnBool == true) {
                                    this.HideDialog_gs_TeachingDate();
                                    this.iShowList.BindGv(clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN._CurrTabName, "");
                                    //数据同步；
                                    const responseText4 = (0, clsgs_TotalDataStatisticsExWApi_js_1.gs_TotalDataStatisticsEx_GetTotalStatisticsByTableAsync)(strId_CurrEduCls, clsPublocalStorage_js_1.clsPublocalStorage.userId);
                                    var returnBool3 = !!responseText4;
                                    if (returnBool3 == true) {
                                        console.log("同步成功");
                                    }
                                    else {
                                        console.log("同步失败");
                                    }
                                }
                            });
                            break;
                        default:
                            var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnSubmit_Click())`;
                            alert(strMsg);
                            break;
                    }
                }
                else {
                    alert("登录超时，请重新登录");
                    window.top.location.href = "../Web/Login";
                }
                $("#divLoading").hide();
                //去掉提交按钮不可用状态
                $('#btnOKUpd').attr("disabled", false);
            }
            catch (e) {
                var strMsg = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
                alert(strMsg);
            }
        }
        /* 在数据表里修改记录
       (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecordInTab_Click)
      */
        async btnUpdateRecordInTab_Click(strKeyId) {
            this.keyId = strKeyId;
            this.opType = "Update";
            if (strKeyId == "") {
                alert("请选择需要修改的记录！");
                return;
            }
            if (this.bolIsLoadEditRegion == false) //
             {
                const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                // 为编辑区绑定下拉框
                const conBindDdl = await this.BindDdl4EditRegionInDiv();
                this.SetEventFunc();
                this.ShowDialog_gs_TeachingDate('Update');
                this.bolIsLoadEditRegion = true; //
                var lngKeyId = Number(strKeyId);
                this.UpdateRecord(lngKeyId);
            }
            else {
                this.ShowDialog_gs_TeachingDate('Update');
                var lngKeyId = Number(strKeyId);
                this.UpdateRecord(lngKeyId);
            }
            //关键字存放
            $("#hidgs_DateId").val(strKeyId);
        }
        /* 修改记录
       (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
     */
        async UpdateRecordSave() {
            const strThisFuncName = this.UpdateRecordSave.name;
            //
            var objgs_TeachingDateEN = new clsgs_TeachingDateEN_js_1.clsgs_TeachingDateEN();
            var strKeyId = $("#hidgs_DateId").val();
            objgs_TeachingDateEN.SetmId(Number(strKeyId));
            this.PutDataTogs_TeachingDateClass(objgs_TeachingDateEN);
            objgs_TeachingDateEN.sf_UpdFldSetStr = objgs_TeachingDateEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objgs_TeachingDateEN.mId == 0 || objgs_TeachingDateEN.mId == undefined) {
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            try {
                const responseText = await (0, clsgs_TeachingDateWApi_js_1.gs_TeachingDate_UpdateRecordAsync)(objgs_TeachingDateEN);
                var returnBool = !!responseText;
                if (returnBool == true) {
                    //gs_TeachingDate_ReFreshCache(gs_TeachingDate_Edit.strid_CurrEduCls_Cache);
                }
                return returnBool;
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `修改记录不成功,${e}.`;
                alert(strMsg);
                return false;
            }
        }
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
      (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
    */
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                this.SetEventFunc();
                $("#divLoading").hide();
            }
            catch (e) {
                var strMsg = `页面启动不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 函数功能:把界面上的属性数据传到类对象中
        (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
        <param name = "pobjgs_TeachingDateEN">数据传输的目的类对象</param>
      */
        async PutDataTogs_TeachingDateClass(pobjgs_TeachingDateEN) {
            pobjgs_TeachingDateEN.Setid_CurrEduCls(this.id_CurrEduCls); // 当前教学班流水号
            pobjgs_TeachingDateEN.SetStartDate(this.startDate); // 开始日期
            pobjgs_TeachingDateEN.SetEndDate(this.endDate); // 截止日期
            pobjgs_TeachingDateEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate_ymd()); // 修改日期
            pobjgs_TeachingDateEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId);
            pobjgs_TeachingDateEN.SetMemo(this.memo); // 备注
        }
    }
    exports.gs_TeachingDate_EditEx = gs_TeachingDate_EditEx;
});
