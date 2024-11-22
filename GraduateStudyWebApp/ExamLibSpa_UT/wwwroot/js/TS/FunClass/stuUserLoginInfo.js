(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PubFun/tzDictionary.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    var tzDictionary_js_1 = require("../PubFun/tzDictionary.js");
    var stuUserLoginInfo = /** @class */ (function () {
        function stuUserLoginInfo() {
            /// <summary>
            /// 当前选择工程Id
            /// </summary>
            this.CurrSelPrjId = "";
            /// <summary>
            /// 当前选择工程
            /// </summary>
            this.CurrSelPrjName = "";
            /// <summary>
            /// 角色Id
            /// </summary>
            this.RoleId = "";
            /// <summary>
            /// 角色
            /// </summary>
            this.RoleName = "";
            /// <summary>
            /// 用户Id
            /// </summary>
            this.UserId = "";
            /// <summary>
            /// 用户名
            /// </summary>
            this.UserName = "";
            /// <summary>
            /// 数据库Id
            /// </summary>
            this.CurrPrjDataBaseId = "";
            /// <summary>
            /// 数据库名
            /// </summary>
            this.PrjDataBaseName = "";
            /// <summary>
            /// 当前数据库类型Id
            /// </summary>
            this.CurrDataBaseTypeId = "";
            /// <summary>
            /// 应用类型Id
            /// </summary>        
            this.ApplicationTypeId = 0;
        }
        ///// <summary>
        ///// 排除的检查字符串列表
        ///// </summary>
        //public CurrSelPrjId: Array<string> = new Array<string>();
        ///// <summary>
        ///// 是否检查SQL攻击
        ///// </summary>
        //public IsCheckSQLAttack: boolean = false;
        stuUserLoginInfo.GetMapParam = function (objUserLoginInfo) {
            //List < string > arrLst = new List<string>(objUserLoginInfo.CurrSelPrjId);
            var mapParam = new tzDictionary_js_1.Dictionary();
            mapParam.add("UserId", objUserLoginInfo.UserId);
            mapParam.add("UserName", objUserLoginInfo.UserName);
            mapParam.add("RoleId", objUserLoginInfo.RoleId);
            mapParam.add("RoleName", objUserLoginInfo.RoleName);
            mapParam.add("CurrSelPrjId", objUserLoginInfo.CurrSelPrjId);
            mapParam.add("CurrSelPrjName", objUserLoginInfo.CurrSelPrjName);
            mapParam.add("CurrPrjDataBaseId", objUserLoginInfo.CurrPrjDataBaseId);
            mapParam.add("PrjDataBaseName", objUserLoginInfo.PrjDataBaseName);
            mapParam.add("CurrDataBaseTypeId", objUserLoginInfo.CurrDataBaseTypeId);
            mapParam.add("ApplicationTypeId", objUserLoginInfo.ApplicationTypeId);
            return mapParam;
        };
        /*
         *把Html string 转换成对象。先转换成JSON string , 然后再转换成对象
         */
        stuUserLoginInfo.GetObjByHtmlString = function (strUserLoginInfo) {
            var strUserLoginInfo2 = $.parseHTML(strUserLoginInfo);
            var objUserLoginInfo = JSON.parse(strUserLoginInfo2[0].wholeText);
            return objUserLoginInfo;
        };
        return stuUserLoginInfo;
    }());
    exports.stuUserLoginInfo = stuUserLoginInfo;
});
