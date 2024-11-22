/**
* 类名:gs_PaperGroup_EditEx(界面:gs_PaperGroupCRUD)
* 表名:gs_PaperGroup(01120749)
* 生成代码版本:2021.10.18.1
* 生成日期:2021/10/21 12:10:24
* 生成者:
* 工程名称:问卷调查
* 工程ID:0112
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
* 模块中文名:研培论文
* 模块英文名:GraduateEduPaper
* 框架-层名:WA_编辑区后台Ex_TS(WA_ViewScript_EditCSEx_TS)
* 编程语言:TypeScript
**/
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
        define(["require", "exports", "../PagesBase/GraduateEduPaper/gs_PaperGroup_Edit.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_PaperGroup_EditEx = void 0;
    const gs_PaperGroup_Edit_js_1 = require("../PagesBase/GraduateEduPaper/gs_PaperGroup_Edit.js");
    /* gs_PaperGroup_EditEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
   */
    class gs_PaperGroup_EditEx extends gs_PaperGroup_Edit_js_1.gs_PaperGroup_Edit {
        /**
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
        **/
        static btnEdit_Click(strCommandName, strKeyId) {
            const strThisFuncName = this.btnEdit_Click.name;
            var objPage = gs_PaperGroup_EditEx.objPage_Edit;
            switch (strCommandName) {
                case "Submit": //提交
                    objPage.btnSubmit_Click();
                    break;
                default:
                    var strMsg = '命令:' + strCommandName + "在函数(gs_PaperGroup_EditEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
            }
        }
    }
    exports.gs_PaperGroup_EditEx = gs_PaperGroup_EditEx;
});