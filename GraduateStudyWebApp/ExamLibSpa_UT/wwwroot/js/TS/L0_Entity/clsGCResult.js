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
    var clsGCResult = /** @class */ (function () {
        function clsGCResult() {
            /*
             代码类型Id
            */
            this.CodeTypeId = "";
            /*
             生成的代码文本
            */
            this.CodeText = "";
            /*
             返回的-类名
            */
            this.Re_ClsName = "";
            /*
             返回的-文件名(带模块名)
            */
            this.Re_FileNameWithModuleName = "";
            /*
             代码类型Id
            */
            this.CodeTypeId2 = "";
            /*
             生成的代码文本
            */
            this.CodeText2 = "";
            /*
             返回的-类名
            */
            this.Re_ClsName2 = "";
            /*
             返回的-文件名(带模块名)
            */
            this.Re_FileNameWithModuleName2 = "";
            this.CodeTypeName = "";
            this.CodeTypeENName = "";
            this.LangType = "";
            this.DataBaseType = "";
            this.TabName = "";
            this.ViewName = "";
            this.PrjName = "";
            this.PrjDataBaseName = "";
            this.GCUserId = "";
        }
        return clsGCResult;
    }());
    exports.clsGCResult = clsGCResult;
});
