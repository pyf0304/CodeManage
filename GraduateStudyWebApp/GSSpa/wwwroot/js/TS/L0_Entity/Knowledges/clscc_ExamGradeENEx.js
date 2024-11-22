(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/Knowledges/clscc_ExamGradeEN.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clscc_ExamGradeENEx = void 0;
    const clscc_ExamGradeEN_js_1 = require("../../L0_Entity/Knowledges/clscc_ExamGradeEN.js");
    class clscc_ExamGradeENEx extends clscc_ExamGradeEN_js_1.clscc_ExamGradeEN {
        //以下是属性变量
        /// <summary>
        /// 构造函数
        /// (AutoGCLib.EntityLayerEx4TypeScript:GenClassConstructor1)
        /// </summary>
        constructor() {
            super();
        }
    }
    exports.clscc_ExamGradeENEx = clscc_ExamGradeENEx;
    ;
});
