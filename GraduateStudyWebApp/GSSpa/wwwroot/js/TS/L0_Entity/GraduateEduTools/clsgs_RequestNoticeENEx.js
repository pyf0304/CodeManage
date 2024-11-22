(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/GraduateEduTools/clsgs_RequestNoticeEN.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsgs_RequestNoticeENEx = void 0;
    const clsgs_RequestNoticeEN_js_1 = require("../../L0_Entity/GraduateEduTools/clsgs_RequestNoticeEN.js");
    class clsgs_RequestNoticeENEx extends clsgs_RequestNoticeEN_js_1.clsgs_RequestNoticeEN {
        //以下是属性变量
        /// <summary>
        /// 构造函数
        /// (AutoGCLib.EntityLayerEx4TypeScript:GenClassConstructor1)
        /// </summary>
        constructor() {
            super();
        }
    }
    exports.clsgs_RequestNoticeENEx = clsgs_RequestNoticeENEx;
    ;
});
