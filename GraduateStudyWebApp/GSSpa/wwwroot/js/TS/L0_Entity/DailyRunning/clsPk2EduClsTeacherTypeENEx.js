(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/DailyRunning/clsPk2EduClsTeacherTypeEN.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsPk2EduClsTeacherTypeENEx = void 0;
    const clsPk2EduClsTeacherTypeEN_js_1 = require("../../L0_Entity/DailyRunning/clsPk2EduClsTeacherTypeEN.js");
    class clsPk2EduClsTeacherTypeENEx extends clsPk2EduClsTeacherTypeEN_js_1.clsPk2EduClsTeacherTypeEN {
        //以下是属性变量
        /// <summary>
        /// 构造函数
        /// (AutoGCLib.EntityLayerEx4TypeScript:GenClassConstructor1)
        /// </summary>
        constructor() {
            super();
        }
    }
    exports.clsPk2EduClsTeacherTypeENEx = clsPk2EduClsTeacherTypeENEx;
    ;
});
