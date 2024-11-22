/*
 * 功能:用于分页获取对象列表的参数结构
 * 版本:2019-07-24-01
 * 作者:潘以锋
 * */
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
    exports.stuPagerPara = void 0;
    const tzDictionary_js_1 = require("./tzDictionary.js");
    class stuPagerPara {
        constructor() {
            /// <summary>
            /// 每页记录数
            /// </summary>
            this.pageSize = 0;
            /// <summary>
            /// 页序号
            /// </summary>
            this.pageIndex = 0;
            /// <summary>
            /// 条件串
            /// </summary>
            this.whereCond = "";
            /// <summary>
            /// 排序表达式
            /// </summary>
            this.orderBy = "";
            /*
             * 用于排序的函数
             * */
            this.sortFun = (x, y) => { return 0; };
        }
        ///// <summary>
        ///// 排除的检查字符串列表
        ///// </summary>
        //public pageSize: Array<string> = new Array<string>();
        ///// <summary>
        ///// 是否检查SQL攻击
        ///// </summary>
        //public IsCheckSQLAttack: boolean = false;
        static GetMapParam(objPagerPara) {
            //Array < string > arrLst = new Array<string>(objPagerPara.pageSize);
            var mapParam = new tzDictionary_js_1.Dictionary();
            mapParam.add("strWhereCond", objPagerPara.whereCond);
            mapParam.add("strOrderBy", objPagerPara.orderBy);
            mapParam.add("intPageIndex", objPagerPara.pageIndex.toString());
            mapParam.add("intPageSize", objPagerPara.pageSize.toString());
            return mapParam;
            //var mapParam: Dictionary = new Dictionary()
            //{
            //    "strWhereCond" = objPagerPara.whereCond,
            //        "strOrderBy" = objPagerPara.orderBy,
            //        "intPageIndex" = objPagerPara.pageIndex.toString(),
            //        ["arrPageSize"] = clsArray.GetSqlInStrByArray(arrLst, false),
            //        ["bolIsCheckSQLAttack"] = objPagerPara.IsCheckSQLAttack.ToString(),
            //    };
            //return dictParam;
        }
    }
    exports.stuPagerPara = stuPagerPara;
});
