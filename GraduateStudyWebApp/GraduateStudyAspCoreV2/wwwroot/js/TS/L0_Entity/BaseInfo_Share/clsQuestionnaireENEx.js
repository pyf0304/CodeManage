(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../L0_Entity/BaseInfo_Share/clsQuestionnaireEN.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsQuestionnaireENEx = void 0;
    /**
    * 类名:clsQuestionnaireENEx
    * 表名:Questionnaire(01120001)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/14 18:31:36
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:基本信息(BaseInfo)
    * 框架-层名:实体扩展层(TS)(EntityLayerEx)
    * 编程语言:TypeScript
    **/
    /**
    * 题目(Questionnaire)
    * (AutoGCLib.EntityLayerEx4TypeScript:GeneCode)
    **/
    const clsQuestionnaireEN_js_1 = require("../../L0_Entity/BaseInfo_Share/clsQuestionnaireEN.js");
    class clsQuestionnaireENEx extends clsQuestionnaireEN_js_1.clsQuestionnaireEN {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayerEx4TypeScript:GenClassConstructor1)
         **/
        constructor() {
            super();
            this.levelModeTypeName = ""; //模式名
            this.difficultyLevelName = ""; //难度等级名称
            this.chapterName = ""; //章名
            this.courseName = ""; //课程名称
            this.questionTypeName = ""; //题目类型名
            this.answerContent = ""; //答案内容
            this.updDate_Sim = ""; //修改日期
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
                case clsQuestionnaireENEx.con_LevelModeTypeName:
                    return this.levelModeTypeName;
                case clsQuestionnaireENEx.con_DifficultyLevelName:
                    return this.difficultyLevelName;
                case clsQuestionnaireENEx.con_ChapterName:
                    return this.chapterName;
                case clsQuestionnaireENEx.con_CourseName:
                    return this.courseName;
                case clsQuestionnaireENEx.con_QuestionTypeName:
                    return this.questionTypeName;
                case clsQuestionnaireENEx.con_AnswerContent:
                    return this.answerContent;
                case clsQuestionnaireENEx.con_UpdDate_Sim:
                    return this.updDate_Sim;
                default:
                    const strValue = super.GetFldValue(strFldName);
                    return strValue;
            }
        }
        /**
        * 常量:"LevelModeTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_LevelModeTypeName() { return "levelModeTypeName"; } //模式名
        /**
        * 常量:"DifficultyLevelName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DifficultyLevelName() { return "difficultyLevelName"; } //难度等级名称
        /**
        * 常量:"ChapterName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ChapterName() { return "chapterName"; } //章名
        /**
        * 常量:"CourseName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseName() { return "courseName"; } //课程名称
        /**
        * 常量:"QuestionTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionTypeName() { return "questionTypeName"; } //题目类型名
        /**
        * 常量:"AnswerContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AnswerContent() { return "answerContent"; } //答案内容
        /**
        * 常量:"UpdDate_Sim"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdDate_Sim() { return "updDate_Sim"; } //修改日期
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
                case clsQuestionnaireENEx.con_LevelModeTypeName:
                    this.levelModeTypeName = strValue;
                    this.hmProperty["levelModeTypeName"] = true;
                    break;
                case clsQuestionnaireENEx.con_DifficultyLevelName:
                    this.difficultyLevelName = strValue;
                    this.hmProperty["difficultyLevelName"] = true;
                    break;
                case clsQuestionnaireENEx.con_ChapterName:
                    this.chapterName = strValue;
                    this.hmProperty["chapterName"] = true;
                    break;
                case clsQuestionnaireENEx.con_CourseName:
                    this.courseName = strValue;
                    this.hmProperty["courseName"] = true;
                    break;
                case clsQuestionnaireENEx.con_QuestionTypeName:
                    this.questionTypeName = strValue;
                    this.hmProperty["questionTypeName"] = true;
                    break;
                case clsQuestionnaireENEx.con_AnswerContent:
                    this.answerContent = strValue;
                    this.hmProperty["answerContent"] = true;
                    break;
                case clsQuestionnaireENEx.con_UpdDate_Sim:
                    this.updDate_Sim = strValue;
                    this.hmProperty["updDate_Sim"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[Questionnaire]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.clsQuestionnaireENEx = clsQuestionnaireENEx;
});
