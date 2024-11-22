(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/GraduateEduTopic/clsgs_TobeStudiedProblemVEN.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsgs_TobeStudiedProblemVENEx = void 0;
    /**
    * 类名:clsgs_TobeStudiedProblemVENEx
    * 表名:gs_TobeStudiedProblemV(01120775)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 11:47:12
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:研培主题(GraduateEduTopic)
    * 框架-层名:实体扩展层(TS)(EntityLayerEx)
    * 编程语言:TypeScript
    **/
    /**
    * 待研究问题历史版本表(gs_TobeStudiedProblemV)
    * (AutoGCLib.EntityLayerEx4TypeScript:GeneCode)
    **/
    const clsgs_TobeStudiedProblemVEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsgs_TobeStudiedProblemVEN.js");
    class clsgs_TobeStudiedProblemVENEx extends clsgs_TobeStudiedProblemVEN_js_1.clsgs_TobeStudiedProblemVEN {
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
    exports.clsgs_TobeStudiedProblemVENEx = clsgs_TobeStudiedProblemVENEx;
});