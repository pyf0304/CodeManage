/*
 * 功能：与字符串相关的功能函数
 * 版本：2019-08-01-01
 * 作者：潘以锋
 * */
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
    exports.tzDataTypeBak = void 0;
    //export function TransToBool(strValue: string) {
    //    var strValue_Lower = strValue.toLowerCase();
    //    if (strValue_Lower === "true") return true;
    //    if (strValue_Lower === "false") return false;
    //    if (strValue_Lower === "1") return true;
    //    if (strValue_Lower === "0") return false;
    //    return false;
    //}
    function TestDataType() {
        var gettype = Object.prototype.toString;
        console.log(gettype.call('aaaa')); // 输出      [object String]
        console.log(gettype.call(2222)); // 输出      [object Number]
        console.log(gettype.call(true)); //   输出      [object Boolean]
        console.log(gettype.call(undefined)); // 输出      [object Undefined]
        console.log(gettype.call(null)); //             输出   [object Null]
        console.log(gettype.call({})); //              输出   [object Object]
        console.log(gettype.call([])); //                 输出   [object Array]
        console.log(gettype.call(function () { })); //    输出   [object Function]
        //console.log(typeof s ===.isNumber(22));
        var ss = "AA";
        console.log(typeof ss === "number");
    }
    var gettype = Object.prototype.toString;
    exports.tzDataTypeBak = {
        isObj: function (o) {
            return gettype.call(o) == "[object Object]";
        },
        isArray: function (o) {
            return gettype.call(o) == "[object Array]";
        },
        isNULL: function (o) {
            return gettype.call(o) == "[object Null]";
        },
        isDocument: function (o) {
            return gettype.call(o) == "[object Document]" || "[object HTMLDocument]";
        },
        isNumber: function (o) {
            return gettype.call(o) == "[object Number]";
        },
        isString: function (o) {
            return gettype.call(o) == "[object String]";
        },
        isBoolean: function (o) {
            return gettype.call(o) == "[object Boolean]";
        }
        //         ........
    };
    function encodeHtml(str) {
        var encodedStr = "";
        if (str == "")
            return encodedStr;
        else {
            for (var i = 0; i < str.length; i++) {
                encodedStr += "&#" + str.substring(i, i + 1).charCodeAt(0).toString(10) + ";";
            }
        }
        return encodedStr;
    }
});
