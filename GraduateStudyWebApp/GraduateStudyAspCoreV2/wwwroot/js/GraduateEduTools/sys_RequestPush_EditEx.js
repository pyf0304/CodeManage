/*-- -- -- -- -- -- -- -- -- -- --
类名:sys_RequestPush_EditEx
表名:sys_RequestPush(01120726)
生成代码版本:2020.09.01.1
生成日期:2020/09/01 17:03:50
生成者:
工程名称:问卷调查
工程ID:0112
相关数据库:101.251.68.133,9433EduHigh_Jsie
PrjDataBaseId:0170
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
        define(["require", "exports", "../PagesBase/GraduateEduTools/sys_RequestPush_Edit.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.sys_RequestPush_EditEx = void 0;
    const sys_RequestPush_Edit_js_1 = require("../PagesBase/GraduateEduTools/sys_RequestPush_Edit.js");
    /* sys_RequestPush_EditEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
   */
    class sys_RequestPush_EditEx extends sys_RequestPush_Edit_js_1.sys_RequestPush_Edit {
        /*
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
        */
        static btnEdit_Click(strCommandName, strKeyId) {
            var objPage = sys_RequestPush_EditEx.objPage_Edit;
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
                case "Submit": //提交
                    objPage.btnSubmit_Click();
                    break;
                default:
                    var strMsg = '命令:' + strCommandName + "在函数(sys_RequestPush_EditEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
            }
        }
    }
    exports.sys_RequestPush_EditEx = sys_RequestPush_EditEx;
});
