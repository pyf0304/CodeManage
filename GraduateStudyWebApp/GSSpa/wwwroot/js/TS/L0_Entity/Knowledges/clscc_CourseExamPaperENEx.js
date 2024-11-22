(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/Knowledges/clscc_CourseExamPaperEN.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clscc_CourseExamPaperENEx = void 0;
    /**
    * 类名:clscc_CourseExamPaperENEx
    * 表名:cc_CourseExamPaper(01120071)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 11:46:00
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:知识点相关(Knowledges)
    * 框架-层名:实体扩展层(TS)(EntityLayerEx)
    * 编程语言:TypeScript
    **/
    /**
    * 考卷(cc_CourseExamPaper)
    * (AutoGCLib.EntityLayerEx4TypeScript:GeneCode)
    **/
    const clscc_CourseExamPaperEN_js_1 = require("../../L0_Entity/Knowledges/clscc_CourseExamPaperEN.js");
    class clscc_CourseExamPaperENEx extends clscc_CourseExamPaperEN_js_1.clscc_CourseExamPaperEN {
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
    exports.clscc_CourseExamPaperENEx = clscc_CourseExamPaperENEx;
});
