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
    exports.ParameterAttribute = void 0;
    const tzDictionary_js_1 = require("../PubFun/tzDictionary.js");
    class ParameterAttribute {
        constructor() {
            /// <summary>
            /// 论文id
            /// </summary>
            this.ThesisId = "";
            /// <summary>
            /// 子论文类型Id
            /// </summary>
            this.SubviewPointTypeId = "";
        }
        static GetMapParam(objParameterAttribute) {
            //List < string > arrLst = new List<string>(objUserLoginInfo.CurrSelPrjId);
            var mapParam = new tzDictionary_js_1.Dictionary();
            mapParam.add("ThesisId", objParameterAttribute.ThesisId);
            mapParam.add("SubviewPointTypeId", objParameterAttribute.SubviewPointTypeId);
            return mapParam;
        }
        /*
         *把Html string 转换成对象。先转换成JSON string , 然后再转换成对象
         */
        static GetObjByHtmlString(strParameterAttribute) {
            var strParameterAttribute2 = $.parseHTML(strParameterAttribute);
            var objParameterAttribute = JSON.parse(strParameterAttribute2[0].wholeText);
            return objParameterAttribute;
        }
    }
    exports.ParameterAttribute = ParameterAttribute;
});
