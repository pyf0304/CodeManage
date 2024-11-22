(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/LogManage/clsLoginLogEN.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsLoginLogENEx = void 0;
    /**
    * 类名:clsLoginLogENEx
    * 表名:LoginLog(01120357)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 11:45:58
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:日志管理(LogManage)
    * 框架-层名:实体扩展层(TS)(EntityLayerEx)
    * 编程语言:TypeScript
    **/
    /**
    * 登录日志(LoginLog)
    * (AutoGCLib.EntityLayerEx4TypeScript:GeneCode)
    **/
    const clsLoginLogEN_js_1 = require("../../L0_Entity/LogManage/clsLoginLogEN.js");
    class clsLoginLogENEx extends clsLoginLogEN_js_1.clsLoginLogEN {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayerEx4TypeScript:GenClassConstructor1)
         **/
        constructor() {
            super();
        }
        /**
         * 根据字段名获取对象中某字段的值.
         * (AutoGCLib.EntityLayerEx4TypeScript:Gen_ENEx_GetFldValue)
         * @param strFldName:字段名
         * @returns 字段值
        */
        GetFldValue(strFldName) {
            const strThisFuncName = "GetFldValue";
            switch (strFldName) {
                case "CtrlId":
                    return "";
                default:
                    const strValue = super.GetFldValue(strFldName);
                    return strValue;
            }
        }
    }
    exports.clsLoginLogENEx = clsLoginLogENEx;
});
