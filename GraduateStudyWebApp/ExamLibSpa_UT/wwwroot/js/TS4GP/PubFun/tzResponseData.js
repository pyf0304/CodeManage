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
    var tzResponseData = /** @class */ (function () {
        function tzResponseData() {
            this.data = "";
            this.what = 0;
            this.IsFinished = false;
            this.faultString = "";
            this.errorId = 0;
            this.returnBool = false;
            this.returnString = "";
            this.returnObject = null;
            this.returnObjectList = new Array();
        }
        return tzResponseData;
    }());
    exports.tzResponseData = tzResponseData;
});
