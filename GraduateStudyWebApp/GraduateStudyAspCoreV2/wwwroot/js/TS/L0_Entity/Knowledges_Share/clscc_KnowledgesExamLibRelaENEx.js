(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/Knowledges_Share/clscc_KnowledgesExamLibRelaEN.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clscc_KnowledgesExamLibRelaENEx = void 0;
    /**
    * 类名:clscc_KnowledgesExamLibRelaENEx
    * 表名:cc_KnowledgesExamLibRela(01120140)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 03:26:23
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:游戏化教育平台(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:知识点相关(Knowledges)
    * 框架-层名:实体扩展层(TS)(EntityLayerEx)
    * 编程语言:TypeScript
    **/
    /**
    * 知识点习题关系(cc_KnowledgesExamLibRela)
    * (AutoGCLib.EntityLayerEx4TypeScript:GeneCode)
    **/
    const clscc_KnowledgesExamLibRelaEN_js_1 = require("../../L0_Entity/Knowledges_Share/clscc_KnowledgesExamLibRelaEN.js");
    class clscc_KnowledgesExamLibRelaENEx extends clscc_KnowledgesExamLibRelaEN_js_1.clscc_KnowledgesExamLibRelaEN {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayerEx4TypeScript:GenClassConstructor1)
         **/
        constructor() {
            super();
            this.questionName = ""; //题目名称
            this.knowledgeName = ""; //知识点名称
            this.courseName = ""; //课程名称
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
                case clscc_KnowledgesExamLibRelaENEx.con_QuestionName:
                    return this.questionName;
                case clscc_KnowledgesExamLibRelaENEx.con_KnowledgeName:
                    return this.knowledgeName;
                case clscc_KnowledgesExamLibRelaENEx.con_CourseName:
                    return this.courseName;
                default:
                    const strValue = super.GetFldValue(strFldName);
                    return strValue;
            }
        }
        /**
        * 常量:"QuestionName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionName() { return "questionName"; } //题目名称
        /**
        * 常量:"KnowledgeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_KnowledgeName() { return "knowledgeName"; } //知识点名称
        /**
        * 常量:"CourseName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseName() { return "courseName"; } //课程名称
        /**
         * 设置对象中某字段名的值.
         * (AutoGCLib.EntityLayerEx4TypeScript:Gen_ENEx_SetFldValue)
         * @param strFldName:字段名
         * @param strValue:字段值
         * @returns 字段值
        */
        SetFldValue(strFldName, strValue) {
            const strThisFuncName = "SetFldValue";
            let strMsg = "";
            switch (strFldName) {
                case clscc_KnowledgesExamLibRelaENEx.con_QuestionName:
                    this.questionName = strValue;
                    this.hmProperty["questionName"] = true;
                    break;
                case clscc_KnowledgesExamLibRelaENEx.con_KnowledgeName:
                    this.knowledgeName = strValue;
                    this.hmProperty["knowledgeName"] = true;
                    break;
                case clscc_KnowledgesExamLibRelaENEx.con_CourseName:
                    this.courseName = strValue;
                    this.hmProperty["courseName"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[cc_KnowledgesExamLibRela]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.clscc_KnowledgesExamLibRelaENEx = clscc_KnowledgesExamLibRelaENEx;
});
