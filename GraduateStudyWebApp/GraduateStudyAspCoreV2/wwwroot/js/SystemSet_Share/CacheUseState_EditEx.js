(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/SystemSet_Share/CacheUseState_Edit.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.CacheUseState_EditEx = void 0;
    //import $ from "jquery";
    const CacheUseState_Edit_js_1 = require("../PagesBase/SystemSet_Share/CacheUseState_Edit.js");
    /* CacheUseState_EditEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:GeneCode)
    */
    class CacheUseState_EditEx extends CacheUseState_Edit_js_1.CacheUseState_Edit {
        /*
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScript_EditCSEx_TS4TypeScript:Gen_WApi_TS_btnEdit_Click)
        */
        static btnEdit_Click(strCommandName, strKeyId) {
            const objPage = CacheUseState_EditEx.objPage_Edit;
            let strMsg = "";
            switch (strCommandName) {
                case "Submit": //提交
                    objPage.btnSubmit_Click();
                    break;
                default:
                    strMsg = '命令:' + strCommandName + "在函数(CacheUseState_EditEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
            }
        }
    }
    exports.CacheUseState_EditEx = CacheUseState_EditEx;
});
