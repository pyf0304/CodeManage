(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "./FeedBack_QUDI_TS.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.FeedBack_QUDI_TSEx = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:FeedBack_QUDI_TSEx
    表名:FeedBack(00420706)
    生成代码版本:2019.10.18.1
    生成日期:2019/10/21 17:05:52
    生成者:
    工程名称:教育高地
    工程ID:0042
    相关数据库:101.251.68.133,9433EduHigh_Jsie
    PrjDataBaseId:0170
    模块中文名:新闻公告
    模块英文名:NewsAnnouncement
    框架-层名:WA_界面脚本后台Ex_TS(WA_ViewScriptCSEx_TS)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //import * as $ from "jquery";
    //import * as QQ from "q";
    const FeedBack_QUDI_TS_js_1 = require("./FeedBack_QUDI_TS.js");
    /* FeedBack_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class FeedBack_QUDI_TSEx extends FeedBack_QUDI_TS_js_1.FeedBack_QUDI_TS {
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortFeedBackBy: string = "feedBackId";
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 10;
        }
    }
    exports.FeedBack_QUDI_TSEx = FeedBack_QUDI_TSEx;
});
