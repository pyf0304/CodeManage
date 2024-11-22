(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "./clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.GetKeyFldStrByKeyLst = exports.GetKeyLstByKeyFldStr = exports.GetSqlInStrByArray = void 0;
    const clsString_js_1 = require("./clsString.js");
    /**
     * 根据列表获取SQL中的IN串
     * @param arrValues:关键字列表
     * @param bolIsHaveQuote:是否有引号
     */
    function GetSqlInStrByArray(arrValues, bolIsHaveQuote) {
        let sbInStr = "";
        if (bolIsHaveQuote == true) {
            let bolIsFirst = true;
            for (let strValue of arrValues) {
                if ((0, clsString_js_1.IsNullOrEmpty)(strValue) == false) {
                    if (bolIsFirst == true) {
                        sbInStr += (0, clsString_js_1.Format)("'{0}'", strValue);
                        bolIsFirst = false;
                    }
                    else {
                        sbInStr += (0, clsString_js_1.Format)(",'{0}'", strValue);
                    }
                }
            }
        }
        else {
            let bolIsFirst = true;
            for (let strValue of arrValues) {
                if (bolIsFirst == true) {
                    sbInStr += (0, clsString_js_1.Format)("{0}", strValue);
                    bolIsFirst = false;
                }
                else {
                    sbInStr += (0, clsString_js_1.Format)(",{0}", strValue);
                }
            }
        }
        return sbInStr;
    }
    exports.GetSqlInStrByArray = GetSqlInStrByArray;
    /**
     * 根据关键字连接串获取关键字列表，并按升序排序
     * @param strKeyFldStr:关键字连接串
     * @return 关键字列表
     */
    function GetKeyLstByKeyFldStr(strKeyFldStr) {
        const arrKeyLst = strKeyFldStr.split('|');
        const arrKeyLst_Sort = arrKeyLst.sort();
        return arrKeyLst_Sort;
    }
    exports.GetKeyLstByKeyFldStr = GetKeyLstByKeyFldStr;
    /**
     * 根据关键字列表获取关键字连接串
     * @param arrKeyLst:关键字列表
     * @return 关键字连接串
     */
    function GetKeyFldStrByKeyLst(arrKeyLst) {
        const arrKeyLst_Sort = arrKeyLst.sort();
        const strKeyFldStr = arrKeyLst_Sort.join('|');
        return strKeyFldStr;
    }
    exports.GetKeyFldStrByKeyLst = GetKeyFldStrByKeyLst;
});
