(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "./CacheUseStateCRUDEx.js", "../PagesBase/SystemSet_Share/vCacheUseState_Detail.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vCacheUseState_DetailEx = void 0;
    //import $ from "jquery";
    const CacheUseStateCRUDEx_js_1 = require("./CacheUseStateCRUDEx.js");
    const vCacheUseState_Detail_js_1 = require("../PagesBase/SystemSet_Share/vCacheUseState_Detail.js");
    /* vCacheUseState_DetailEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_DetailCSEx_TS4TypeScript:GeneCode)
   */
    class vCacheUseState_DetailEx extends vCacheUseState_Detail_js_1.vCacheUseState_Detail {
        /*
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScript_DetailCSEx_TS4TypeScript:Gen_WApi_TS_btnDetail_Click)
        */
        btnDetail_Click(strCommandName, strKeyId) {
            const objCacheUseStateCRUD = new CacheUseStateCRUDEx_js_1.CacheUseStateCRUDEx();
            const objPage = new vCacheUseState_DetailEx(objCacheUseStateCRUD);
            let strMsg = "";
            switch (strCommandName) {
                case "AddNewRecordWithMaxId": //添加记录使用最大关键字
                    //objPage_Edit.btnAddNewRecordWithMaxId_Click();
                    break;
                case "CreateWithMaxId": //添加记录使用最大关键字
                    //objPage_Edit.btnAddNewRecordWithMaxId_Click();
                    break;
                default:
                    strMsg = '命令:' + strCommandName + "在函数(vCacheUseState_DetailEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
            }
        }
    }
    exports.vCacheUseState_DetailEx = vCacheUseState_DetailEx;
});
