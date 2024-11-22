(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/Knowledges_Share/clscc_CourseKnowledgesEN.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clscc_CourseKnowledgesENEx = void 0;
    /**
    * 类名:clscc_CourseKnowledgesENEx
    * 表名:cc_CourseKnowledges(01120082)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:13:56
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
    * 知识点(cc_CourseKnowledges)
    * (AutoGCLib.EntityLayerEx4TypeScript:GeneCode)
    **/
    const clscc_CourseKnowledgesEN_js_1 = require("../../L0_Entity/Knowledges_Share/clscc_CourseKnowledgesEN.js");
    class clscc_CourseKnowledgesENEx extends clscc_CourseKnowledgesEN_js_1.clscc_CourseKnowledgesEN {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayerEx4TypeScript:GenClassConstructor1)
         **/
        constructor() {
            super();
            this.courseChapterName = ""; //课程章节名称
            this.courseName = ""; //课程名称
            this.knowledgeTypeName = ""; //知识点类型名
            this.questionNum = 0; //题目数
            this.chapterName = ""; //章名
            this.userName = ""; //用户名
            this.courseCode = ""; //课程代码
            this.sectionName_Sim = ""; //节名简称
            this.chapterName_Sim = ""; //章名简称
            this.sectionName = ""; //节名
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
                case clscc_CourseKnowledgesENEx.con_CourseChapterName:
                    return this.courseChapterName;
                case clscc_CourseKnowledgesENEx.con_CourseName:
                    return this.courseName;
                case clscc_CourseKnowledgesENEx.con_KnowledgeTypeName:
                    return this.knowledgeTypeName;
                case clscc_CourseKnowledgesENEx.con_QuestionNum:
                    return this.questionNum;
                case clscc_CourseKnowledgesENEx.con_ChapterName:
                    return this.chapterName;
                case clscc_CourseKnowledgesENEx.con_UserName:
                    return this.userName;
                case clscc_CourseKnowledgesENEx.con_CourseCode:
                    return this.courseCode;
                case clscc_CourseKnowledgesENEx.con_SectionName_Sim:
                    return this.sectionName_Sim;
                case clscc_CourseKnowledgesENEx.con_ChapterName_Sim:
                    return this.chapterName_Sim;
                case clscc_CourseKnowledgesENEx.con_SectionName:
                    return this.sectionName;
                default:
                    const strValue = super.GetFldValue(strFldName);
                    return strValue;
            }
        }
        /**
        * 常量:"CourseChapterName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseChapterName() { return "courseChapterName"; } //课程章节名称
        /**
        * 常量:"CourseName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseName() { return "courseName"; } //课程名称
        /**
        * 常量:"KnowledgeTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_KnowledgeTypeName() { return "knowledgeTypeName"; } //知识点类型名
        /**
        * 常量:"QuestionNum"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionNum() { return "questionNum"; } //题目数
        /**
        * 常量:"ChapterName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ChapterName() { return "chapterName"; } //章名
        /**
        * 常量:"UserName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserName() { return "userName"; } //用户名
        /**
        * 常量:"CourseCode"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseCode() { return "courseCode"; } //课程代码
        /**
        * 常量:"SectionName_Sim"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SectionName_Sim() { return "sectionName_Sim"; } //节名简称
        /**
        * 常量:"ChapterName_Sim"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ChapterName_Sim() { return "chapterName_Sim"; } //章名简称
        /**
        * 常量:"SectionName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SectionName() { return "sectionName"; } //节名
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
                case clscc_CourseKnowledgesENEx.con_CourseChapterName:
                    this.courseChapterName = strValue;
                    this.hmProperty["courseChapterName"] = true;
                    break;
                case clscc_CourseKnowledgesENEx.con_CourseName:
                    this.courseName = strValue;
                    this.hmProperty["courseName"] = true;
                    break;
                case clscc_CourseKnowledgesENEx.con_KnowledgeTypeName:
                    this.knowledgeTypeName = strValue;
                    this.hmProperty["knowledgeTypeName"] = true;
                    break;
                case clscc_CourseKnowledgesENEx.con_QuestionNum:
                    this.questionNum = Number(strValue);
                    this.hmProperty["questionNum"] = true;
                    break;
                case clscc_CourseKnowledgesENEx.con_ChapterName:
                    this.chapterName = strValue;
                    this.hmProperty["chapterName"] = true;
                    break;
                case clscc_CourseKnowledgesENEx.con_UserName:
                    this.userName = strValue;
                    this.hmProperty["userName"] = true;
                    break;
                case clscc_CourseKnowledgesENEx.con_CourseCode:
                    this.courseCode = strValue;
                    this.hmProperty["courseCode"] = true;
                    break;
                case clscc_CourseKnowledgesENEx.con_SectionName_Sim:
                    this.sectionName_Sim = strValue;
                    this.hmProperty["sectionName_Sim"] = true;
                    break;
                case clscc_CourseKnowledgesENEx.con_ChapterName_Sim:
                    this.chapterName_Sim = strValue;
                    this.hmProperty["chapterName_Sim"] = true;
                    break;
                case clscc_CourseKnowledgesENEx.con_SectionName:
                    this.sectionName = strValue;
                    this.hmProperty["sectionName"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[cc_CourseKnowledges]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.clscc_CourseKnowledgesENEx = clscc_CourseKnowledgesENEx;
});
