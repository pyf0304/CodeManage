/*
 * 功能：用于跟踪的功能函数
 * 版本：2019-07-24-01
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
    exports.clsStackTrace = void 0;
    class clsStackTrace {
        constructor() {
        }
        static GetCurrClassFunction() {
            var result = '未知';
            return result;
        }
        static GetCurrClassFunctionByLevel(intLevel) {
            var result = `未知:${intLevel}`;
            return result;
        }
    }
    exports.clsStackTrace = clsStackTrace;
});
