(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/GraduateEduPaper/gs_PaperAttention_Detail.js", "./gs_PaperAttentionCRUDEx.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_PaperAttention_DetailEx = void 0;
    /**
    * 类名:gs_PaperAttention_DetailEx(界面:gs_PaperAttentionCRUD)
    * 表名:gs_PaperAttention(01120748)
    * 版本:2023.02.18.1(服务器:WIN-SRV103-116)
    * 日期:2023/02/18 03:37:04
    * 生成者:
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:研培论文(GraduateEduPaper)
    * 框架-层名:WA_详细信息后台Ex_TS(TS)(WA_ViewScript_DetailCSEx_TS)
    * 编程语言:TypeScript
    **/
    const gs_PaperAttention_Detail_js_1 = require("../PagesBase/GraduateEduPaper/gs_PaperAttention_Detail.js");
    const gs_PaperAttentionCRUDEx_js_1 = require("./gs_PaperAttentionCRUDEx.js");
    /* gs_PaperAttention_DetailEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_DetailCSEx_TS4TypeScript:GeneCode)
   */
    class gs_PaperAttention_DetailEx extends gs_PaperAttention_Detail_js_1.gs_PaperAttention_Detail {
        /**
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScript_DetailCSEx_TS4TypeScript:Gen_WApi_TS_btnDetail_Click)
        **/
        btnDetail_Click(strCommandName, strKeyId) {
            const strThisFuncName = this.btnDetail_Click.name;
            const objgs_PaperAttentionCRUD = new gs_PaperAttentionCRUDEx_js_1.gs_PaperAttentionCRUDEx();
            const objPage = new gs_PaperAttention_DetailEx(objgs_PaperAttentionCRUD);
            switch (strCommandName) {
                case "AddNewRecordWithMaxId": //添加记录使用最大关键字
                    ////objPage.btnAddNewRecordWithMaxId_Click();
                    break;
                case "CreateWithMaxId": //添加记录使用最大关键字
                    //objPage.btnAddNewRecordWithMaxId_Click();
                    break;
                default:
                    const strMsg = '命令:' + strCommandName + "在函数(gs_PaperAttention_DetailExEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
            }
        }
    }
    exports.gs_PaperAttention_DetailEx = gs_PaperAttention_DetailEx;
});
