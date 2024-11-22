/*
 * 功能:为Web提供下拉框对象类
 * 版本:2019-08-03-01
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
    exports.clsCboObject = void 0;
    /// <summary>
    /// 下拉框对象类
    /// </summary>
    class clsCboObject {
        /*[Index: string]: string;*/
        /*
        /// <param name="strValue"></param>
        /// <param name="strText"></param>
        */
        constructor(strValue, strText) {
            /// <summary>
            /// 值
            /// </summary>
            this.value = "";
            /// <summary>
            /// 文本
            /// </summary>
            this.text = "";
            this.value = strValue;
            this.text = strText;
        }
        /// <summary>
        /// 常量:"Text"
        /// </summary>
        static get con_Text() { return "text"; }
        ; //文本
        /// <summary>
        /// 常量:"Value"
        /// </summary>
        static get con_Value() { return "value"; } //值
        static GetFldValue(objCbo, strFldName) {
            const strThisFuncName = "GetFldValue";
            let strMsg = "";
            switch (strFldName) {
                case clsCboObject.con_Text:
                    return objCbo.text;
                case clsCboObject.con_Value:
                    return objCbo.value;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[clsCboObject]中不存在！`;
                    console.error(strMsg);
                    return "";
            }
        }
    }
    exports.clsCboObject = clsCboObject;
});
