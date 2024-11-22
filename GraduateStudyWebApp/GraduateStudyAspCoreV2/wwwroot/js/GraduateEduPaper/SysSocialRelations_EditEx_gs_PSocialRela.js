(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/GraduateEduTopic/SysSocialRelations_Edit.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.SysSocialRelations_EditEx_gs_PSocialRela = void 0;
    /**
    * 类名:SysSocialRelations_EditEx(界面:SysSocialRelationsCRUD)
    * 表名:SysSocialRelations(01120644)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/08 00:26:19
    * 生成者:
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:研培主题(GraduateEduTopic)
    * 框架-层名:WA_编辑区后台Ex_TS(TS)(WA_ViewScript_EditCSEx_TS)
    * 编程语言:TypeScript
    **/
    const SysSocialRelations_Edit_js_1 = require("../PagesBase/GraduateEduTopic/SysSocialRelations_Edit.js");
    /* SysSocialRelations_EditEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
    */
    class SysSocialRelations_EditEx_gs_PSocialRela extends SysSocialRelations_Edit_js_1.SysSocialRelations_Edit {
        /**
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
        **/
        static btnEdit_Click(strCommandName, strKeyId) {
            const strThisFuncName = this.btnEdit_Click.name;
            const objPage = SysSocialRelations_EditEx_gs_PSocialRela.objPage_Edit;
            switch (strCommandName) {
                case "Submit": //提交
                    objPage.btnSubmit_Click();
                    break;
                default:
                    const strMsg = '命令:' + strCommandName + "在函数(SysSocialRelations_EditEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
            }
        }
    }
    exports.SysSocialRelations_EditEx_gs_PSocialRela = SysSocialRelations_EditEx_gs_PSocialRela;
});
