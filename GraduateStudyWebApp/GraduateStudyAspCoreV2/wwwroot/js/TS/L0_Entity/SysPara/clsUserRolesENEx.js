(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/SysPara/clsUserRolesEN.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsUserRolesENEx = void 0;
    const clsUserRolesEN_js_1 = require("../../L0_Entity/SysPara/clsUserRolesEN.js");
    class clsUserRolesENEx extends clsUserRolesEN_js_1.clsUserRolesEN {
        //以下是属性变量
        /// <summary>
        /// 构造函数
        /// (AutoGCLib.EntityLayerEx4TypeScript:GenClassConstructor1)
        /// </summary>
        constructor() {
            super();
        }
    }
    exports.clsUserRolesENEx = clsUserRolesENEx;
    ;
});
