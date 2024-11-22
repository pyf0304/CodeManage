/*
 * 功能：数据列，为绑定数据表定义列信息
 * 版本：2019-07-24-01
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
    exports.clsDataColumn = void 0;
    class clsDataColumn {
        //以下是属性变量
        /// <summary>
        /// 构造函数
        /// (AutoGCLib.EntityLayer4TypeScript:GenClassConstructor1)
        /// </summary>
        constructor() {
            this.FldName = ""; //考试类型Id
            this.ColHeader = ""; //考试类型名
            this.Text = ""; //Button Text
            this.TdClass = "text-left";
            this.SortBy = ""; //排序字段
            this.orderNum = 0; //是否删除
            this.ColumnType = ""; //列类型：Label,TextBox,Button
            this.FuncName = () => { }; //备注
        }
    }
    exports.clsDataColumn = clsDataColumn;
    ;
});
