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
    exports.stuRoleMenuByRoleIdsPara = void 0;
    const tzDictionary_1 = require("./tzDictionary");
    class stuRoleMenuByRoleIdsPara {
        constructor() {
            /// <summary>
            /// 工程id
            /// </summary>
            this.qxPrjId = "";
            /// <summary>
            /// 角色Id列表
            /// </summary>
            this.roleIdLst = [];
            /// <summary>
            /// 菜单集Id
            /// </summary>
            this.menuSetId = "";
            /// <summary>
            /// 是否是上级菜单
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
        static GetMapParam(objRoleMenuByRoleIdsPara) {
            //List < string > arrLst = new List<string>(objRoleMenuByRoleIdsPara.QxPrjId);
            var mapParam = new tzDictionary_1.Dictionary();
            mapParam.add("menuSetId", objRoleMenuByRoleIdsPara.menuSetId);
            mapParam.add("isUpMenuId", objRoleMenuByRoleIdsPara.isUpMenuId);
            mapParam.add("roleIdLst", objRoleMenuByRoleIdsPara.roleIdLst.join(','));
            mapParam.add("QxPrjId", objRoleMenuByRoleIdsPara.qxPrjId);
            return mapParam;
        }
    }
    exports.stuRoleMenuByRoleIdsPara = stuRoleMenuByRoleIdsPara;
});
