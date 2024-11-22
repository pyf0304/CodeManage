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
    exports.tz_CommKeyWordsEx_ConstructorName = exports.tz_CommKeyWordsEx_Controller = void 0;
    exports.tz_CommKeyWordsEx_Controller = "tz_CommKeyWordsExApi";
    exports.tz_CommKeyWordsEx_ConstructorName = "tz_CommKeyWordsEx";
});
