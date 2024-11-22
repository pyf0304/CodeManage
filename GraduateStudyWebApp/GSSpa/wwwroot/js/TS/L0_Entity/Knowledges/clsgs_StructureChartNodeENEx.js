(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/Knowledges/clsgs_StructureChartNodeEN.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsgs_StructureChartNodeENEx = void 0;
    const clsgs_StructureChartNodeEN_js_1 = require("../../L0_Entity/Knowledges/clsgs_StructureChartNodeEN.js");
    class clsgs_StructureChartNodeENEx extends clsgs_StructureChartNodeEN_js_1.clsgs_StructureChartNodeEN {
        //以下是属性变量
        /// <summary>
        /// 构造函数
        /// (AutoGCLib.EntityLayerEx4TypeScript:GenClassConstructor1)
        /// </summary>
        constructor() {
            super();
        }
    }
    exports.clsgs_StructureChartNodeENEx = clsgs_StructureChartNodeENEx;
    ;
});
