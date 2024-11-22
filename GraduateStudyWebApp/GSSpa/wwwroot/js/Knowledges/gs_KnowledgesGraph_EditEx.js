(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "./gs_KnowledgesGraph_Edit.js", "../TS/FunClass/clsPubFun4Web.js", "../TS/PubFun/clsPubSessionStorage.js", "../TS/PubFun/clsPublocalStorage.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_KnowledgesGraph_EditEx = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:gs_KnowledgesGraph_EditEx
    表名:gs_KnowledgesGraph(01120873)
    生成代码版本:2021.01.27.2
    生成日期:2021/01/27 23:31:45
    生成者:
    工程名称:问卷调查
    工程ID:0112
    相关数据库:103.116.76.183,9433EduHigh_Jsie
    PrjDataBaseId:0170
    模块中文名:知识点相关
    模块英文名:Knowledges
    框架-层名:WA_编辑区后台Ex_TS(WA_ViewScript_EditCSEx_TS)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //import * as $ from "jquery";
    //import * as QQ from "q";
    const gs_KnowledgesGraph_Edit_js_1 = require("./gs_KnowledgesGraph_Edit.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass/clsPubFun4Web.js");
    const clsPubSessionStorage_js_1 = require("../TS/PubFun/clsPubSessionStorage.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    /* gs_KnowledgesGraph_EditEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
    */
    class gs_KnowledgesGraph_EditEx extends gs_KnowledgesGraph_Edit_js_1.gs_KnowledgesGraph_Edit {
        /*
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
        */
        static btnEdit_Click(strCommandName, strKeyId) {
            var objPage = gs_KnowledgesGraph_EditEx.objPage_Edit;
            switch (strCommandName) {
                case "AddNewRecordWithMaxId": //添加记录使用最大关键字
                    objPage.btnAddNewRecordWithMaxId_Click();
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
                    var strMsg = '命令:' + strCommandName + "在函数(gs_KnowledgesGraph_EditExEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
            }
        }
        PutDataTogs_KnowledgesGraphClass(pobjgs_KnowledgesGraphEN) {
            pobjgs_KnowledgesGraphEN.knowledgeGraphName = this.knowledgeGraphName; // 知识点图名
            pobjgs_KnowledgesGraphEN.courseId = this.courseId; // 课程Id
            pobjgs_KnowledgesGraphEN.updDate = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate_ymd(); // 修改日期
            pobjgs_KnowledgesGraphEN.updUser = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId(); // 修改用户Id
            pobjgs_KnowledgesGraphEN.createUser = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId(); // 修改用户Id
            pobjgs_KnowledgesGraphEN.id_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls();
        }
    }
    exports.gs_KnowledgesGraph_EditEx = gs_KnowledgesGraph_EditEx;
});
