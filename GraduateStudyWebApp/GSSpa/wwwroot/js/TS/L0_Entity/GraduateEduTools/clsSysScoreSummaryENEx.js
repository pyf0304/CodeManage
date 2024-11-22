(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/GraduateEduTools/clsSysScoreSummaryEN.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsSysScoreSummaryENEx = void 0;
    /**
    * 类名:clsSysScoreSummaryENEx
    * 表名:SysScoreSummary(01120628)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 11:47:16
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:研培设置(GraduateEduTools)
    * 框架-层名:实体扩展层(TS)(EntityLayerEx)
    * 编程语言:TypeScript
    **/
    /**
    * 系统分数汇总表(SysScoreSummary)
    * (AutoGCLib.EntityLayerEx4TypeScript:GeneCode)
    **/
    const clsSysScoreSummaryEN_js_1 = require("../../L0_Entity/GraduateEduTools/clsSysScoreSummaryEN.js");
    class clsSysScoreSummaryENEx extends clsSysScoreSummaryEN_js_1.clsSysScoreSummaryEN {
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
    exports.clsSysScoreSummaryENEx = clsSysScoreSummaryENEx;
});
