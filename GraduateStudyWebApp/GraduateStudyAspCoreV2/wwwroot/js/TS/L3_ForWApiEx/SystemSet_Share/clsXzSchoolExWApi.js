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
    exports.xzSchoolEx_ConstructorName = exports.xzSchoolEx_Controller = void 0;
    exports.xzSchoolEx_Controller = "XzSchoolExApi";
    exports.xzSchoolEx_ConstructorName = "xzSchoolEx";
});
