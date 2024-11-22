(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../PubFun/clsGeneralTabV.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsvQuestionnaire_SimEN = void 0;
    /**
    * 类名:clsvQuestionnaire_SimEN
    * 表名:vQuestionnaire_Sim(01120949)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/14 18:31:51
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:基本信息(BaseInfo)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * vQuestionnaire_Sim(vQuestionnaire_Sim)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvQuestionnaire_SimEN extends clsGeneralTabV_js_1.clsGeneralTabV {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
        */
        constructor() {
            super();
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.questionID = ""; //题目ID
            this.questionName = ""; //题目名称
            this.questionIndex = 0; //题目序号
            this.questionNo = ""; //题目编号
            this.courseId = ""; //课程Id
            this.courseChapterId = ""; //课程章节ID
            this.parentQuestionId = ""; //父题目Id
            this.questionTypeId = ""; //题目类型Id
            this.questionTypeId4Course = ""; //题目类型Id4课程
            this.answerTypeId = ""; //答案类型ID
            this.isShow = false; //是否启用
        }
        /**
         * 根据字段名获取对象中某字段的值.
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_GetFldValue)
         * @param strFldName:字段名
         * @returns 字段值
        */
        GetFldValue(strFldName) {
            const strThisFuncName = "GetFldValue";
            let strMsg = "";
            switch (strFldName) {
                case clsvQuestionnaire_SimEN.con_QuestionID:
                    return this.questionID;
                case clsvQuestionnaire_SimEN.con_QuestionName:
                    return this.questionName;
                case clsvQuestionnaire_SimEN.con_QuestionIndex:
                    return this.questionIndex;
                case clsvQuestionnaire_SimEN.con_QuestionNo:
                    return this.questionNo;
                case clsvQuestionnaire_SimEN.con_CourseId:
                    return this.courseId;
                case clsvQuestionnaire_SimEN.con_CourseChapterId:
                    return this.courseChapterId;
                case clsvQuestionnaire_SimEN.con_ParentQuestionId:
                    return this.parentQuestionId;
                case clsvQuestionnaire_SimEN.con_QuestionTypeId:
                    return this.questionTypeId;
                case clsvQuestionnaire_SimEN.con_QuestionTypeId4Course:
                    return this.questionTypeId4Course;
                case clsvQuestionnaire_SimEN.con_AnswerTypeId:
                    return this.answerTypeId;
                case clsvQuestionnaire_SimEN.con_IsShow:
                    return this.isShow;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vQuestionnaire_Sim]中不存在！`;
                    console.error(strMsg);
                    return "";
            }
        }
        /**
         * 设置对象中某字段名的值.
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_SetFldValue)
         * @param strFldName:字段名
         * @param strValue:字段值
         * @returns 字段值
        */
        SetFldValue(strFldName, strValue) {
            const strThisFuncName = "SetFldValue";
            let strMsg = "";
            switch (strFldName) {
                case clsvQuestionnaire_SimEN.con_QuestionID:
                    this.questionID = strValue;
                    break;
                case clsvQuestionnaire_SimEN.con_QuestionName:
                    this.questionName = strValue;
                    break;
                case clsvQuestionnaire_SimEN.con_QuestionIndex:
                    this.questionIndex = Number(strValue);
                    break;
                case clsvQuestionnaire_SimEN.con_QuestionNo:
                    this.questionNo = strValue;
                    break;
                case clsvQuestionnaire_SimEN.con_CourseId:
                    this.courseId = strValue;
                    break;
                case clsvQuestionnaire_SimEN.con_CourseChapterId:
                    this.courseChapterId = strValue;
                    break;
                case clsvQuestionnaire_SimEN.con_ParentQuestionId:
                    this.parentQuestionId = strValue;
                    break;
                case clsvQuestionnaire_SimEN.con_QuestionTypeId:
                    this.questionTypeId = strValue;
                    break;
                case clsvQuestionnaire_SimEN.con_QuestionTypeId4Course:
                    this.questionTypeId4Course = strValue;
                    break;
                case clsvQuestionnaire_SimEN.con_AnswerTypeId:
                    this.answerTypeId = strValue;
                    break;
                case clsvQuestionnaire_SimEN.con_IsShow:
                    this.isShow = Boolean(strValue);
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vQuestionnaire_Sim]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"QuestionID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionID() { return "questionID"; } //题目ID
        /**
        * 常量:"QuestionName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionName() { return "questionName"; } //题目名称
        /**
        * 常量:"QuestionIndex"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionIndex() { return "questionIndex"; } //题目序号
        /**
        * 常量:"QuestionNo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionNo() { return "questionNo"; } //题目编号
        /**
        * 常量:"CourseId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseId() { return "courseId"; } //课程Id
        /**
        * 常量:"CourseChapterId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseChapterId() { return "courseChapterId"; } //课程章节ID
        /**
        * 常量:"ParentQuestionId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ParentQuestionId() { return "parentQuestionId"; } //父题目Id
        /**
        * 常量:"QuestionTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionTypeId() { return "questionTypeId"; } //题目类型Id
        /**
        * 常量:"QuestionTypeId4Course"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionTypeId4Course() { return "questionTypeId4Course"; } //题目类型Id4课程
        /**
        * 常量:"AnswerTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AnswerTypeId() { return "answerTypeId"; } //答案类型ID
        /**
        * 常量:"IsShow"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsShow() { return "isShow"; } //是否启用
        /**
        * 设置条件字段值.
        * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_SetCondFldValue)
        * @param strFldName:字段名
        * @param strFldValue:字段值
        * @param strComparisonOp:比较操作条符
        * @returns 根据关键字获取的名称
        **/
        SetCondFldValue(strFldName, strFldValue, strComparisonOp) {
            const strThisFuncName = this.SetCondFldValue.name;
            this.SetFldValue(strFldName, strFldValue);
            if (Object.prototype.hasOwnProperty.call(this.dicFldComparisonOp, strFldName) == false) {
                this.dicFldComparisonOp[strFldName] = strComparisonOp;
            }
            else {
                this.dicFldComparisonOp[strFldName] = strComparisonOp;
            }
            this.sf_FldComparisonOp = JSON.stringify(this.dicFldComparisonOp);
        }
    }
    exports.clsvQuestionnaire_SimEN = clsvQuestionnaire_SimEN;
    clsvQuestionnaire_SimEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvQuestionnaire_SimEN.CacheModeId = "04"; //sessionStorage
    clsvQuestionnaire_SimEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsvQuestionnaire_SimEN.WhereFormat = ""; //条件格式串
    clsvQuestionnaire_SimEN._CurrTabName = "vQuestionnaire_Sim"; //当前表名,与该类相关的表名
    clsvQuestionnaire_SimEN._KeyFldName = "QuestionID"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvQuestionnaire_SimEN.mintAttributeCount = 11;
    clsvQuestionnaire_SimEN.AttributeName = ["questionID", "questionName", "questionIndex", "questionNo", "courseId", "courseChapterId", "parentQuestionId", "questionTypeId", "questionTypeId4Course", "answerTypeId", "isShow"];
});
