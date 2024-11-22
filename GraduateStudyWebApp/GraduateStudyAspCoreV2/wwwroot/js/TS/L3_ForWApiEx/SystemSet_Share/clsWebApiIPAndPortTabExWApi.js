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
    exports.webApiIPAndPortTabEx_ConstructorName = exports.webApiIPAndPortTabEx_Controller = void 0;
    exports.webApiIPAndPortTabEx_Controller = "WebApiIPAndPortTabExApi";
    exports.webApiIPAndPortTabEx_ConstructorName = "webApiIPAndPortTabEx";
});
