/*
 * 功能:公共数据实体底层
 * 版本:2019-07-24-01
 * 作者:潘以锋
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
    exports.clsGeneralTabV = void 0;
    class clsGeneralTabV {
        //以下是属性变量
        ///该函数不存在:
        constructor() {
            this.whereCond = "";
            //this.intTag = 0;     //整型Tag
            //this.strTag = "";     //字符型标签
            this.isCheckProperty = false; //是否检查属性
            //this.hmProperty = {};
            this.dicFldComparisonOp = {};
            //this.sf_UpdFldSetStr = "";     //修改字符标志串
            this.sf_FldComparisonOp = ""; //修改字符标志串
            this.whereCond = "";
        }
        GetFldValue(strFldName) {
            return "";
        }
        SetFldValue(strFldName, strFldValue) {
        }
    }
    exports.clsGeneralTabV = clsGeneralTabV;
    clsGeneralTabV._CurrTabName = ""; //当前表名，与该类相关的表名
    clsGeneralTabV._KeyFldName = ""; //当前表的关键字字段的名称
});
