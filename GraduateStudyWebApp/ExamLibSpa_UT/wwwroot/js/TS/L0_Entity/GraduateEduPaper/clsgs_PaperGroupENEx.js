var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/GraduateEduPaper/clsgs_PaperGroupEN.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    var clsgs_PaperGroupEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsgs_PaperGroupEN.js");
    var clsgs_PaperGroupENEx = /** @class */ (function (_super) {
        __extends(clsgs_PaperGroupENEx, _super);
        //以下是属性变量
        /// <summary>
        /// 构造函数
        /// (AutoGCLib.EntityLayerEx4TypeScript:GenClassConstructor1)
        /// </summary>
        function clsgs_PaperGroupENEx() {
            return _super.call(this) || this;
        }
        return clsgs_PaperGroupENEx;
    }(clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN));
    exports.clsgs_PaperGroupENEx = clsgs_PaperGroupENEx;
    ;
});
