/*
 * 功能：调整序号的参数结构
 * 版本：2019-08-03-01
 * 作者：潘以锋
 * */
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsOrderByData = void 0;
    class clsOrderByData {
        constructor() {
            this.KeyIdLst = new Array();
            this.ClassificationFieldValue = "";
            this.ClassificationFieldValue2 = "";
            this.ClassificationFieldValueLst = "";
        }
    }
    exports.clsOrderByData = clsOrderByData;
});
