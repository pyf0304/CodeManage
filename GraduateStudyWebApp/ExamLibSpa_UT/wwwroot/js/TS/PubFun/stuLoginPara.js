(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "./tzDictionary.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    var tzDictionary_js_1 = require("./tzDictionary.js");
    var stuLoginPara = /** @class */ (function () {
        function stuLoginPara() {
            /// <summary>
            /// 每页记录数
            /// </summary>
            this.QxPrjId = "";
            /// <summary>
            /// 页序号
            /// </summary>
            this.EffectiveDate = "";
            /// <summary>
            /// 条件串
            /// </summary>
            this.LoginName = "";
            /// <summary>
            /// 排序表达式
            /// </summary>
            this.UserPassword = "";
        }
        ///// <summary>
        ///// 排除的检查字符串列表
        ///// </summary>
        //public QxPrjId: Array<string> = new Array<string>();
        ///// <summary>
        ///// 是否检查SQL攻击
        ///// </summary>
        //public IsCheckSQLAttack: boolean = false;
        stuLoginPara.GetMapParam = function (objLoginPara) {
            //List < string > arrLst = new List<string>(objLoginPara.QxPrjId);
            var mapParam = new tzDictionary_js_1.Dictionary();
            mapParam.add("strLoginName", objLoginPara.LoginName);
            mapParam.add("strUserPassword", objLoginPara.UserPassword);
            mapParam.add("intEffectiveDate", objLoginPara.EffectiveDate);
            mapParam.add("intQxPrjId", objLoginPara.QxPrjId);
            return mapParam;
        };
        return stuLoginPara;
    }());
    exports.stuLoginPara = stuLoginPara;
});
