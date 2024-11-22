(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/GraduateEduPaper/JournalSubjectCategory_Detail.js", "./JournalSubjectCategoryCRUDEx.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.JournalSubjectCategory_DetailEx = void 0;
    /**
    * 类名:JournalSubjectCategory_DetailEx(界面:JournalSubjectCategoryCRUD)
    * 表名:JournalSubjectCategory(01120931)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/07 11:40:55
    * 生成者:
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:研培论文(GraduateEduPaper)
    * 框架-层名:WA_详细信息后台Ex_TS(TS)(WA_ViewScript_DetailCSEx_TS)
    * 编程语言:TypeScript
    **/
    const JournalSubjectCategory_Detail_js_1 = require("../PagesBase/GraduateEduPaper/JournalSubjectCategory_Detail.js");
    const JournalSubjectCategoryCRUDEx_js_1 = require("./JournalSubjectCategoryCRUDEx.js");
    /* JournalSubjectCategory_DetailEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_DetailCSEx_TS4TypeScript:GeneCode)
   */
    class JournalSubjectCategory_DetailEx extends JournalSubjectCategory_Detail_js_1.JournalSubjectCategory_Detail {
        /**
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScript_DetailCSEx_TS4TypeScript:Gen_WApi_TS_btnDetail_Click)
        **/
        btnDetail_Click(strCommandName, strKeyId) {
            const strThisFuncName = this.btnDetail_Click.name;
            const objJournalSubjectCategoryCRUD = new JournalSubjectCategoryCRUDEx_js_1.JournalSubjectCategoryCRUDEx();
            const objPage = new JournalSubjectCategory_DetailEx(objJournalSubjectCategoryCRUD);
            switch (strCommandName) {
                case "AddNewRecordWithMaxId": //添加记录使用最大关键字
                    //objPage.btnAddNewRecordWithMaxId_Click();
                    break;
                case "CreateWithMaxId": //添加记录使用最大关键字
                    //objPage.btnAddNewRecordWithMaxId_Click();
                    break;
                default:
                    const strMsg = '命令:' + strCommandName + "在函数(JournalSubjectCategory_DetailExEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
            }
        }
    }
    exports.JournalSubjectCategory_DetailEx = JournalSubjectCategory_DetailEx;
});
