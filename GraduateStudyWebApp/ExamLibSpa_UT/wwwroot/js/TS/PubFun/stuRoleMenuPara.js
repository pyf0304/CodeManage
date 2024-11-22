(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "./tzDictionary"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    var tzDictionary_1 = require("./tzDictionary");
    var stuRoleMenuPara = /** @class */ (function () {
        function stuRoleMenuPara() {
            /// <summary>
            /// 每页记录数
            /// </summary>
            this.QxPrjId = "";
            /// <summary>
            /// 页序号
            /// </summary>
            this.RoleId = "";
            /// <summary>
            /// 条件串
            /// </summary>
            this.MenuSetId = "";
            /// <summary>
            /// 排序表达式
            /// </summary>
            this.IsUpMenuId = "";
        }
        ///// <summary>
        ///// 排除的检查字符串列表
        ///// </summary>
        //public QxPrjId: Array<string> = new Array<string>();
        ///// <summary>
        ///// 是否检查SQL攻击
        ///// </summary>
        //public IsCheckSQLAttack: boolean = false;
        stuRoleMenuPara.GetMapParam = function (objRoleMenuPara) {
            //List < string > arrLst = new List<string>(objRoleMenuPara.QxPrjId);
            var mapParam = new tzDictionary_1.Dictionary();
            mapParam.add("MenuSetId", objRoleMenuPara.MenuSetId);
            mapParam.add("IsUpMenuId", objRoleMenuPara.IsUpMenuId);
            mapParam.add("RoleId", objRoleMenuPara.RoleId);
            mapParam.add("QxPrjId", objRoleMenuPara.QxPrjId);
            return mapParam;
        };
        ;
        return stuRoleMenuPara;
    }());
    exports.stuRoleMenuPara = stuRoleMenuPara;
    ;
});
