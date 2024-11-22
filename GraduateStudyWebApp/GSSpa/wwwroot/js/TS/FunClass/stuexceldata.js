(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PubFun/tzDictionary.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.stuExcelData = void 0;
    const tzDictionary_js_1 = require("../PubFun/tzDictionary.js");
    class stuExcelData {
        constructor() {
            /// <summary>
            /// 当前选择工程Id
            /// </summary>
            this.Csv = "";
            /// <summary>
            /// 当前用户
            /// </summary>
            this.userId = "";
            /// <summary>
            /// 年级流水号
            /// </summary>
            this.Id_Grade = "";
            /// <summary>
            /// 是否四舍五入
            /// </summary>
            this.bolRound = true;
        }
        static GetMapParam(objUserLoginInfo) {
            //Array < string > arrLst = new Array<string>(objUserLoginInfo.CurrSelPrjId);
            var mapParam = new tzDictionary_js_1.Dictionary();
            mapParam.add("userId", objUserLoginInfo.userId);
            mapParam.add("Csv", objUserLoginInfo.Csv);
            return mapParam;
        }
    }
    exports.stuExcelData = stuExcelData;
});
