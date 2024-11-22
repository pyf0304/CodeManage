(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/LogManage/LoginLog_Detail.js", "./LoginLogCRUDEx.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.LoginLog_DetailEx = void 0;
    /**
    * 类名:LoginLog_DetailEx(界面:LoginLogCRUD)
    * 表名:LoginLog(01120357)
    * 版本:2023.01.09.1(服务器:WIN-SRV103-116)
    * 日期:2023/01/12 01:41:33
    * 生成者:
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:日志管理(LogManage)
    * 框架-层名:WA_详细信息后台Ex_TS(TS)(WA_ViewScript_DetailCSEx_TS)
    * 编程语言:TypeScript
    **/
    const LoginLog_Detail_js_1 = require("../PagesBase/LogManage/LoginLog_Detail.js");
    const LoginLogCRUDEx_js_1 = require("./LoginLogCRUDEx.js");
    /* LoginLog_DetailEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_DetailCSEx_TS4TypeScript:GeneCode)
   */
    class LoginLog_DetailEx extends LoginLog_Detail_js_1.LoginLog_Detail {
        /**
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScript_DetailCSEx_TS4TypeScript:Gen_WApi_TS_btnDetail_Click)
        **/
        btnDetail_Click(strCommandName, strKeyId) {
            const strThisFuncName = this.btnDetail_Click.name;
            const objLoginLogCRUD = new LoginLogCRUDEx_js_1.LoginLogCRUDEx();
            const objPage = new LoginLog_DetailEx(objLoginLogCRUD);
            switch (strCommandName) {
                case "AddNewRecordWithMaxId": //添加记录使用最大关键字
                    ////objPage.btnAddNewRecordWithMaxId_Click();
                    break;
                case "CreateWithMaxId": //添加记录使用最大关键字
                    //objPage.btnAddNewRecordWithMaxId_Click();
                    break;
                default:
                    const strMsg = '命令:' + strCommandName + "在函数(LoginLog_DetailExEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
            }
        }
    }
    exports.LoginLog_DetailEx = LoginLog_DetailEx;
});
