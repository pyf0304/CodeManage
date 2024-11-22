/**
* 类名:QxUsers_EditEx(界面:QxUsersCRUD)
* 表名:QxUsers(01120258)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/08 13:34:04
* 生成者:
工程名称:问卷调查(0112)
CM工程:游戏化教育平台(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
* 模块中文名:基本信息维护(BaseInfo)
* 框架-层名:WA_编辑区后台Ex_TS(TS)(WA_ViewScript_EditCSEx_TS)
* 编程语言:TypeScript
**/
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/BaseInfo_Share/QxUsers_Edit"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.QxUsers_EditEx = void 0;
    const QxUsers_Edit_1 = require("../PagesBase/BaseInfo_Share/QxUsers_Edit");
    /* QxUsers_EditEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
   */
    class QxUsers_EditEx extends QxUsers_Edit_1.QxUsers_Edit {
        /**
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
        **/
        static btnEdit_Click(strCommandName, strKeyId) {
            const strThisFuncName = this.btnEdit_Click.name;
            const objPage = QxUsers_EditEx.objPage_Edit;
            switch (strCommandName) {
                case "Submit": //提交
                    objPage.btnSubmit_Click();
                    break;
                default:
                    const strMsg = '命令:' + strCommandName + "在函数(QxUsers_EditEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
            }
        }
    }
    exports.QxUsers_EditEx = QxUsers_EditEx;
});
