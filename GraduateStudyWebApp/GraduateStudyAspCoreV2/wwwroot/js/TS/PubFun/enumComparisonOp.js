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
    exports.enumComparisonOp = void 0;
    /// <summary>
    /// 根据表内容设置enum列表
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_GeneEnumConstList)
    /// </summary>
    class enumComparisonOp {
    }
    exports.enumComparisonOp = enumComparisonOp;
    /// <summary>
    /// 等于
    /// </summary>
    enumComparisonOp.Equal_01 = "=";
    /// <summary>
    /// 不等于
    /// </summary>
    enumComparisonOp.NotEqual_02 = "!=";
    /// <summary>
    /// like
    /// </summary>
    enumComparisonOp.Like_03 = "like";
    /// <summary>
    /// in
    /// </summary>
    enumComparisonOp.In_04 = "in";
    /// <summary>
    /// 不小于
    /// </summary>
    enumComparisonOp.NotLessThan_05 = ">=";
    /// <summary>
    /// 不大于
    /// </summary>
    enumComparisonOp.NotGreaterThan_06 = "<=";
    /// <summary>
    /// 大于
    /// </summary>    
    enumComparisonOp.GreaterThan_07 = ">";
    /// <summary>
    /// 小于
    /// </summary>    
    enumComparisonOp.LessThan_08 = "<";
});
