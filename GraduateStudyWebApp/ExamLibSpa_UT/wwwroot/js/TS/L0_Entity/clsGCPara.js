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
    var clsGCPara = /** @class */ (function () {
        function clsGCPara() {
            /*
            代码类型Id
            */
            this.CodeTypeId = "";
            /*
        用户Id
        */
            this.GCUserId = "";
            /*
            数据库类型
            */
            this.DataBaseType = "";
            /*
            表Id
            */
            this.TabId = "";
            /*
             界面Id
            */
            this.ViewId = "";
            /*
            工程Id
            */
            this.PrjId = "";
            /*
            数据库Id
            */
            this.PrjDataBaseId = "";
            this.ClassName = "";
            this.LangType = "";
            /*
            类型参数
            */
            this.TypeParas = "";
        }
        return clsGCPara;
    }());
    exports.clsGCPara = clsGCPara;
});
