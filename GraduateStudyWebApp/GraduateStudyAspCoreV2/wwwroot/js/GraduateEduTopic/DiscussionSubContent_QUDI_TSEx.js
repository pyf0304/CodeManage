/*-- -- -- -- -- -- -- -- -- -- --
类名:DiscussionSubContent_QUDI_TSEx
表名:DiscussionSubContent(01120587)
生成代码版本:2020.02.19.1
生成日期:2020/02/20 16:41:19
生成者:
工程名称:问卷调查
工程ID:0112
相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
PrjDataBaseId:0122
模块中文名:研究生培养
模块英文名:GraduateEdu
框架-层名:WA_界面脚本后台Ex_TS(WA_ViewScriptCSEx_TS)
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
        define(["require", "exports", "../PagesBase/GraduateEduTools/DiscussionSubContentCRUD"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.DiscussionSubContent_QUDI_TSEx = void 0;
    const DiscussionSubContentCRUD_1 = require("../PagesBase/GraduateEduTools/DiscussionSubContentCRUD");
    /* DiscussionSubContent_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class DiscussionSubContent_QUDI_TSEx extends DiscussionSubContentCRUD_1.DiscussionSubContentCRUD {
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortvDiscussionSubContentBy: string = "subContentId";
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 10;
        }
    }
    exports.DiscussionSubContent_QUDI_TSEx = DiscussionSubContent_QUDI_TSEx;
});
