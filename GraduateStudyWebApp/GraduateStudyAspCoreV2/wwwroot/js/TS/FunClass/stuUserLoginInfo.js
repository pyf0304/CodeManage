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
    exports.stuUserLoginInfo = void 0;
    const tzDictionary_js_1 = require("../PubFun/tzDictionary.js");
    class stuUserLoginInfo {
        constructor() {
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
            this.roleId = "";
            /// <summary>
            /// 角色
            /// </summary>
            this.roleName = "";
            /// <summary>
            /// 用户Id
            /// </summary>
            this.userId = "";
            /// <summary>
            /// 用户名
            /// </summary>
            this.userName = "";
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
            /// <summary>
            /// 课程Id
            /// </summary>        
            this.courseId = "";
            /// <summary>
            /// 论文Id
            /// </summary>        
            this.ThesisId = "";
            /// <summary>
            /// 专业id
            /// </summary>        
            this.id_XzMajor = "";
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
            mapParam.add("userId", objUserLoginInfo.userId);
            mapParam.add("userName", objUserLoginInfo.userName);
            mapParam.add("roleId", objUserLoginInfo.roleId);
            mapParam.add("roleName", objUserLoginInfo.roleName);
            mapParam.add("CurrSelPrjId", objUserLoginInfo.CurrSelPrjId);
            mapParam.add("CurrSelPrjName", objUserLoginInfo.CurrSelPrjName);
            mapParam.add("courseId", objUserLoginInfo.courseId);
            mapParam.add("ThesisId", objUserLoginInfo.ThesisId);
            mapParam.add("CurrPrjDataBaseId", objUserLoginInfo.CurrPrjDataBaseId);
            mapParam.add("PrjDataBaseName", objUserLoginInfo.PrjDataBaseName);
            mapParam.add("CurrDataBaseTypeId", objUserLoginInfo.CurrDataBaseTypeId);
            mapParam.add("ApplicationTypeId", objUserLoginInfo.ApplicationTypeId);
            mapParam.add("id_XzMajor", objUserLoginInfo.id_XzMajor);
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
        static GetObjByHtmlString2(strvUserRoleRelation) {
            var strUserLoginInfo2 = $.parseHTML(strvUserRoleRelation);
            var objvUserRoleRelation = JSON.parse(strUserLoginInfo2[0].wholeText);
            return objvUserRoleRelation;
        }
    }
    exports.stuUserLoginInfo = stuUserLoginInfo;
});
