(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/Knowledges_Share/gs_KnowledgesGraph_Edit.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_KnowledgesGraph_EditEx = void 0;
    /**
    * 类名:gs_KnowledgesGraph_EditEx(界面:gs_KnowledgesGraphCRUD)
    * 表名:gs_KnowledgesGraph(01120873)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:59:25
    * 生成者:
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:知识点相关(Knowledges)
    * 框架-层名:WA_编辑区后台Ex_TS(TS)(WA_ViewScript_EditCSEx_TS)
    * 编程语言:TypeScript
    **/
    const gs_KnowledgesGraph_Edit_js_1 = require("../PagesBase/Knowledges_Share/gs_KnowledgesGraph_Edit.js");
    /* gs_KnowledgesGraph_EditEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
   */
    class gs_KnowledgesGraph_EditEx extends gs_KnowledgesGraph_Edit_js_1.gs_KnowledgesGraph_Edit {
        /**
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
        **/
        static btnEdit_Click(strCommandName, strKeyId) {
            const strThisFuncName = this.btnEdit_Click.name;
            const objPage = gs_KnowledgesGraph_EditEx.objPage_Edit;
            switch (strCommandName) {
                case "Submit": //提交
                    objPage.btnSubmit_Click();
                    break;
                default:
                    const strMsg = '命令:' + strCommandName + "在函数(gs_KnowledgesGraph_EditEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
            }
        }
    }
    exports.gs_KnowledgesGraph_EditEx = gs_KnowledgesGraph_EditEx;
});
