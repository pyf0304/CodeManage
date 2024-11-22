/*
 * 功能：为Web提供一些几个公共的功能函数
 * 版本：2019-08-07-01
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
    var clsPubFun4Web = /** @class */ (function () {
        function clsPubFun4Web() {
        }
        /*
        * 重新转向本项目新的Url地址
        */
        clsPubFun4Web.GetRegionId = function (strViewId, strRegionTypeId) {
            return 0;
        };
        return clsPubFun4Web;
    }());
    exports.clsPubFun4Web = clsPubFun4Web;
});
