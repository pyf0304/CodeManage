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
    /*
     * 功能:数据列，为绑定数据表定义列信息
     * 版本:2019-07-24-01
     * 作者:潘以锋
     * */
    class clsDataColumn {
        //以下是属性变量
        /// <summary>
        /// 构造函数
        /// (AutoGCLib.EntityLayer4TypeScript:GenClassConstructor1)
        /// </summary>
        constructor() {
            this.fldName = ""; //数据字段名
            this.sortBy = ""; //排序表达式
            this.sortFun = () => { }; //函数
            this.getDataSource = ""; //WebCache(Web缓存),WebApi(后台获取)
            this.colHeader = ""; //列头名
            this.text = ""; //Button Text
            this.tdClass = "text-left";
            this.orderNum = 0; //次序
            this.columnType = ""; //列类型:Label,TextBox,Button
            this.funcName = () => { }; //单击事件名
        }
    }
    exports.clsDataColumn = clsDataColumn;
    ;
});
