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
    exports.stuViewInfo4Session = void 0;
    const tzDictionary_js_1 = require("../PubFun/tzDictionary.js");
    class stuViewInfo4Session {
        constructor() {
            /// <summary>
            /// 当前选择工程Id
            /// </summary>
            this.CurrSelPrjId = "";
            /// <summary>
            /// 当前选择工程
            /// </summary>
            this.CurrSelPrjName = "";
            ///// <summary>
            ///// 角色Id
            ///// </summary>
            //public roleId: string = "";
            ///// <summary>
            ///// 角色
            ///// </summary>
            //public roleName: string = "";
            /// <summary>
            /// 用户Id
            /// </summary>
            this.ViewId = "";
            /// <summary>
            /// 用户名
            /// </summary>
            this.ViewName = "";
            ///// <summary>
            ///// 数据库Id
            ///// </summary>
            //public CurrPrjDataBaseId: string = "";
            ///// <summary>
            ///// 数据库名
            ///// </summary>
            //public PrjDataBaseName: string = "";
            ///// <summary>
            ///// 当前数据库类型Id
            ///// </summary>
            //public CurrDataBaseTypeId: string = "";
            /// <summary>
            /// 应用类型Id
            /// </summary>        
            this.ApplicationTypeId = 0;
            /// <summary>
            /// 应用类型Id
            /// </summary>        
            this.ApplicationTypeName = "";
        }
        ///// <summary>
        ///// 排除的检查字符串列表
        ///// </summary>
        //public CurrSelPrjId: Array<string> = new Array<string>();
        ///// <summary>
        ///// 是否检查SQL攻击
        ///// </summary>
        //public IsCheckSQLAttack: boolean = false;
        static GetMapParam(objUserLoginInfo) {
            //List < string > arrLst = new List<string>(objUserLoginInfo.CurrSelPrjId);
            var mapParam = new tzDictionary_js_1.Dictionary();
            mapParam.add("ViewId", objUserLoginInfo.ViewId);
            mapParam.add("ViewName", objUserLoginInfo.ViewName);
            //mapParam.add("roleId", objUserLoginInfo.roleId);
            //mapParam.add("roleName", objUserLoginInfo.roleName);
            mapParam.add("CurrSelPrjId", objUserLoginInfo.CurrSelPrjId);
            mapParam.add("CurrSelPrjName", objUserLoginInfo.CurrSelPrjName);
            //mapParam.add("CurrPrjDataBaseId", objUserLoginInfo.CurrPrjDataBaseId);
            //mapParam.add("PrjDataBaseName", objUserLoginInfo.PrjDataBaseName);
            //mapParam.add("CurrDataBaseTypeId", objUserLoginInfo.CurrDataBaseTypeId);
            mapParam.add("ApplicationTypeId", objUserLoginInfo.ApplicationTypeId);
            mapParam.add("ApplicationTypeName", objUserLoginInfo.ApplicationTypeName);
            return mapParam;
        }
        /*
         *把Html string 转换成对象。先转换成JSON string , 然后再转换成对象
         */
        static GetObjByHtmlString(strUserLoginInfo) {
            var strUserLoginInfo2 = $.parseHTML(strUserLoginInfo);
            var objUserLoginInfo = JSON.parse(strUserLoginInfo2[0].wholeText);
            return objUserLoginInfo;
        }
    }
    exports.stuViewInfo4Session = stuViewInfo4Session;
});
