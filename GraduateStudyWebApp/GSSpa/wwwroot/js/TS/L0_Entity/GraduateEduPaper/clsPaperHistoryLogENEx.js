(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/GraduateEduPaper/clsPaperHistoryLogEN.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsPaperHistoryLogENEx = void 0;
    const clsPaperHistoryLogEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsPaperHistoryLogEN.js");
    class clsPaperHistoryLogENEx extends clsPaperHistoryLogEN_js_1.clsPaperHistoryLogEN {
        //以下是属性变量
        /// <summary>
        /// 构造函数
        /// (AutoGCLib.EntityLayerEx4TypeScript:GenClassConstructor1)
        /// </summary>
        constructor() {
            super();
        }
    }
    exports.clsPaperHistoryLogENEx = clsPaperHistoryLogENEx;
    ;
});
