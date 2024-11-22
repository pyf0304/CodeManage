/*
 * 功能：为Web提供下拉框对象类
 * 版本：2019-08-03-01
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
    exports.clsCboObject = void 0;
    /// <summary>
    /// 下拉框对象类
    /// </summary>
    class clsCboObject {
        /*
        /// <param name="strValue"></param>
        /// <param name="strText"></param>
        */
        constructor(strValue, strText) {
            /// <summary>
            /// 值
            /// </summary>
            this.Value = "";
            /// <summary>
            /// 文本
            /// </summary>
            this.Text = "";
            this.Value = strValue;
            this.Text = strText;
        }
        /// <summary>
        /// 常量:"Text"
        /// </summary>
        static get con_Text() { return "Text"; }
        ; //文本
        /// <summary>
        /// 常量:"Value"
        /// </summary>
        static get con_Value() { return "Value"; } //值
    }
    exports.clsCboObject = clsCboObject;
});
