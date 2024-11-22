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
    exports.stuRoleMenuPara = void 0;
    const tzDictionary_js_1 = require("./tzDictionary.js");
    class stuRoleMenuPara {
        constructor() {
            /// <summary>
            /// 每页记录数
            /// </summary>
            this.qxPrjId = "";
            /// <summary>
            /// 页序号
            /// </summary>
            this.roleId = "";
            /// <summary>
            /// 条件串
            /// </summary>
            this.menuSetId = "";
            /// <summary>
            /// 排序表达式
            /// </summary>
            this.isUpMenuId = "";
        }
        ///// <summary>
        ///// 排除的检查字符串列表
        ///// </summary>
        //public QxPrjId: Array<string> = new Array<string>();
        ///// <summary>
        ///// 是否检查SQL攻击
        ///// </summary>
        //public IsCheckSQLAttack: boolean = false;
        static GetMapParam(objRoleMenuPara) {
            //List < string > arrLst = new List<string>(objRoleMenuPara.QxPrjId);
            var mapParam = new tzDictionary_js_1.Dictionary();
            mapParam.add("menuSetId", objRoleMenuPara.menuSetId);
            mapParam.add("isUpMenuId", objRoleMenuPara.isUpMenuId);
            mapParam.add("roleId", objRoleMenuPara.roleId);
            mapParam.add("QxPrjId", objRoleMenuPara.qxPrjId);
            return mapParam;
        }
        ;
    }
    exports.stuRoleMenuPara = stuRoleMenuPara;
    ;
});
