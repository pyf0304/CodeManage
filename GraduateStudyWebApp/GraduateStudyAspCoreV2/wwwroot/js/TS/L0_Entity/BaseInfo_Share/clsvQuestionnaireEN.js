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
    exports.clsvQuestionnaireEN = void 0;
    /**
    * 类名:clsvQuestionnaireEN
    * 表名:vQuestionnaire(01120019)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/14 18:31:38
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
    * v题目(vQuestionnaire)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvQuestionnaireEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.questionIndex = 0; //题目序号
            this.questionName = ""; //题目名称
            this.questionContent = ""; //题目内容
            this.questionMemo = ""; //题目说明
            this.questionNo = ""; //题目编号
            this.parentQuestionId = ""; //父题目Id
            this.examAnswer = ""; //题目答案
            this.courseId = ""; //课程Id
            this.courseCode = ""; //课程代码
            this.courseName = ""; //课程名称
            this.levelNo = 0; //学习关号2
            this.courseChapterId = ""; //课程章节ID
            this.courseChapterName = ""; //课程章节名称
            this.chapterId = ""; //章Id
            this.sectionId = ""; //节Id
            this.chapterName = ""; //章名
            this.sectionName = ""; //节名
            this.chapterName_Sim = ""; //章名简称
            this.sectionName_Sim = ""; //节名简称
            this.parentNodeID = ""; //父节点编号
            this.courseChapterReferred = ""; //节简称
            this.parentNodeName = ""; //父节点名称
            this.parentNodeReferred = ""; //章简称
            this.questionTypeId = ""; //题目类型Id
            this.questionTypeName = ""; //题目类型名
            this.questionTypeId4Course = ""; //题目类型Id4课程
            this.questionTypeName4Course = ""; //题目类型名4课程
            this.answerTypeId = ""; //答案类型ID
            this.answerTypeName = ""; //答案类型名
            this.gridTitle = ""; //表格标题
            this.answerModeId = ""; //答案模式Id
            this.answerModeName = ""; //答案模式名称
            this.questionScore = 0.0; //题目得分
            this.defaultValue = ""; //缺省值
            this.defaultSelectItem = ""; //默认选项
            this.isShow = false; //是否启用
            this.isCast = false; //是否播放
            this.likeCount = 0; //资源喜欢数量
            this.answerAttLimitSize = 0; //回答附件限制大小
            this.limitedResourceType = ""; //限制资源类型
            this.isEffective = false; //是否有效
            this.isCanInPaper = false; //是否可在Paper
            this.examGradeId = ""; //题库等级ID
            this.examGradeName = ""; //题库等级名
            this.textDirectId = ""; //文本方向ID
            this.updDate = ""; //修改日期
            this.updUser = ""; //修改人
            this.memo = ""; //备注
            this.firstIndent = false; //首行缩进
            this.codeTab = ""; //代码表
            this.codeTab_Code = ""; //CodeTab_Code
            this.codeTab_Condition = ""; //代码表_条件
            this.codeTab_Name = ""; //CodeTab_Name
            this.courseId_Chapter = ""; //CourseId_Chapter
            this.optionNum = 0; //选项数
            this.chapterOrderNum = 0; //章排序号
            this.questionName_Add = ""; //题目补充
            this.difficultyLevelId = ""; //难度等级Id
            this.fillInTextHeight = 0; //填空框高度
            this.fillInTextWidth = 0; //填空框宽度
            this.isHaveAdditionalMemo = false; //是否有附加说明
            this.isJs = false; //是否是JS
            this.isMulti4FillInText = false; //是否填空框多行
            this.knowledgeGraphId = ""; //知识点图Id
            this.memoTextWidth = 0; //备注框宽度
            this.questionCode = ""; //html代码
            this.sectionTypeId = ""; //节点类型Id
            this.checkBoxLimitCount = 0; //复选框限制数
            this.relaEvent = ""; //相关事件
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
                case clsvQuestionnaireEN.con_QuestionID:
                    return this.questionID;
                case clsvQuestionnaireEN.con_QuestionIndex:
                    return this.questionIndex;
                case clsvQuestionnaireEN.con_QuestionName:
                    return this.questionName;
                case clsvQuestionnaireEN.con_QuestionContent:
                    return this.questionContent;
                case clsvQuestionnaireEN.con_QuestionMemo:
                    return this.questionMemo;
                case clsvQuestionnaireEN.con_QuestionNo:
                    return this.questionNo;
                case clsvQuestionnaireEN.con_ParentQuestionId:
                    return this.parentQuestionId;
                case clsvQuestionnaireEN.con_ExamAnswer:
                    return this.examAnswer;
                case clsvQuestionnaireEN.con_CourseId:
                    return this.courseId;
                case clsvQuestionnaireEN.con_CourseCode:
                    return this.courseCode;
                case clsvQuestionnaireEN.con_CourseName:
                    return this.courseName;
                case clsvQuestionnaireEN.con_LevelNo:
                    return this.levelNo;
                case clsvQuestionnaireEN.con_CourseChapterId:
                    return this.courseChapterId;
                case clsvQuestionnaireEN.con_CourseChapterName:
                    return this.courseChapterName;
                case clsvQuestionnaireEN.con_ChapterId:
                    return this.chapterId;
                case clsvQuestionnaireEN.con_SectionId:
                    return this.sectionId;
                case clsvQuestionnaireEN.con_ChapterName:
                    return this.chapterName;
                case clsvQuestionnaireEN.con_SectionName:
                    return this.sectionName;
                case clsvQuestionnaireEN.con_ChapterName_Sim:
                    return this.chapterName_Sim;
                case clsvQuestionnaireEN.con_SectionName_Sim:
                    return this.sectionName_Sim;
                case clsvQuestionnaireEN.con_ParentNodeID:
                    return this.parentNodeID;
                case clsvQuestionnaireEN.con_CourseChapterReferred:
                    return this.courseChapterReferred;
                case clsvQuestionnaireEN.con_ParentNodeName:
                    return this.parentNodeName;
                case clsvQuestionnaireEN.con_ParentNodeReferred:
                    return this.parentNodeReferred;
                case clsvQuestionnaireEN.con_QuestionTypeId:
                    return this.questionTypeId;
                case clsvQuestionnaireEN.con_QuestionTypeName:
                    return this.questionTypeName;
                case clsvQuestionnaireEN.con_QuestionTypeId4Course:
                    return this.questionTypeId4Course;
                case clsvQuestionnaireEN.con_QuestionTypeName4Course:
                    return this.questionTypeName4Course;
                case clsvQuestionnaireEN.con_AnswerTypeId:
                    return this.answerTypeId;
                case clsvQuestionnaireEN.con_AnswerTypeName:
                    return this.answerTypeName;
                case clsvQuestionnaireEN.con_GridTitle:
                    return this.gridTitle;
                case clsvQuestionnaireEN.con_AnswerModeId:
                    return this.answerModeId;
                case clsvQuestionnaireEN.con_AnswerModeName:
                    return this.answerModeName;
                case clsvQuestionnaireEN.con_QuestionScore:
                    return this.questionScore;
                case clsvQuestionnaireEN.con_DefaultValue:
                    return this.defaultValue;
                case clsvQuestionnaireEN.con_DefaultSelectItem:
                    return this.defaultSelectItem;
                case clsvQuestionnaireEN.con_IsShow:
                    return this.isShow;
                case clsvQuestionnaireEN.con_IsCast:
                    return this.isCast;
                case clsvQuestionnaireEN.con_LikeCount:
                    return this.likeCount;
                case clsvQuestionnaireEN.con_AnswerAttLimitSize:
                    return this.answerAttLimitSize;
                case clsvQuestionnaireEN.con_LimitedResourceType:
                    return this.limitedResourceType;
                case clsvQuestionnaireEN.con_IsEffective:
                    return this.isEffective;
                case clsvQuestionnaireEN.con_IsCanInPaper:
                    return this.isCanInPaper;
                case clsvQuestionnaireEN.con_ExamGradeId:
                    return this.examGradeId;
                case clsvQuestionnaireEN.con_ExamGradeName:
                    return this.examGradeName;
                case clsvQuestionnaireEN.con_TextDirectId:
                    return this.textDirectId;
                case clsvQuestionnaireEN.con_UpdDate:
                    return this.updDate;
                case clsvQuestionnaireEN.con_UpdUser:
                    return this.updUser;
                case clsvQuestionnaireEN.con_Memo:
                    return this.memo;
                case clsvQuestionnaireEN.con_FirstIndent:
                    return this.firstIndent;
                case clsvQuestionnaireEN.con_CodeTab:
                    return this.codeTab;
                case clsvQuestionnaireEN.con_CodeTab_Code:
                    return this.codeTab_Code;
                case clsvQuestionnaireEN.con_CodeTab_Condition:
                    return this.codeTab_Condition;
                case clsvQuestionnaireEN.con_CodeTab_Name:
                    return this.codeTab_Name;
                case clsvQuestionnaireEN.con_CourseId_Chapter:
                    return this.courseId_Chapter;
                case clsvQuestionnaireEN.con_OptionNum:
                    return this.optionNum;
                case clsvQuestionnaireEN.con_ChapterOrderNum:
                    return this.chapterOrderNum;
                case clsvQuestionnaireEN.con_QuestionName_Add:
                    return this.questionName_Add;
                case clsvQuestionnaireEN.con_DifficultyLevelId:
                    return this.difficultyLevelId;
                case clsvQuestionnaireEN.con_FillInTextHeight:
                    return this.fillInTextHeight;
                case clsvQuestionnaireEN.con_FillInTextWidth:
                    return this.fillInTextWidth;
                case clsvQuestionnaireEN.con_IsHaveAdditionalMemo:
                    return this.isHaveAdditionalMemo;
                case clsvQuestionnaireEN.con_IsJs:
                    return this.isJs;
                case clsvQuestionnaireEN.con_IsMulti4FillInText:
                    return this.isMulti4FillInText;
                case clsvQuestionnaireEN.con_KnowledgeGraphId:
                    return this.knowledgeGraphId;
                case clsvQuestionnaireEN.con_MemoTextWidth:
                    return this.memoTextWidth;
                case clsvQuestionnaireEN.con_QuestionCode:
                    return this.questionCode;
                case clsvQuestionnaireEN.con_SectionTypeId:
                    return this.sectionTypeId;
                case clsvQuestionnaireEN.con_CheckBoxLimitCount:
                    return this.checkBoxLimitCount;
                case clsvQuestionnaireEN.con_RelaEvent:
                    return this.relaEvent;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vQuestionnaire]中不存在！`;
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
                case clsvQuestionnaireEN.con_QuestionID:
                    this.questionID = strValue;
                    break;
                case clsvQuestionnaireEN.con_QuestionIndex:
                    this.questionIndex = Number(strValue);
                    break;
                case clsvQuestionnaireEN.con_QuestionName:
                    this.questionName = strValue;
                    break;
                case clsvQuestionnaireEN.con_QuestionContent:
                    this.questionContent = strValue;
                    break;
                case clsvQuestionnaireEN.con_QuestionMemo:
                    this.questionMemo = strValue;
                    break;
                case clsvQuestionnaireEN.con_QuestionNo:
                    this.questionNo = strValue;
                    break;
                case clsvQuestionnaireEN.con_ParentQuestionId:
                    this.parentQuestionId = strValue;
                    break;
                case clsvQuestionnaireEN.con_ExamAnswer:
                    this.examAnswer = strValue;
                    break;
                case clsvQuestionnaireEN.con_CourseId:
                    this.courseId = strValue;
                    break;
                case clsvQuestionnaireEN.con_CourseCode:
                    this.courseCode = strValue;
                    break;
                case clsvQuestionnaireEN.con_CourseName:
                    this.courseName = strValue;
                    break;
                case clsvQuestionnaireEN.con_LevelNo:
                    this.levelNo = Number(strValue);
                    break;
                case clsvQuestionnaireEN.con_CourseChapterId:
                    this.courseChapterId = strValue;
                    break;
                case clsvQuestionnaireEN.con_CourseChapterName:
                    this.courseChapterName = strValue;
                    break;
                case clsvQuestionnaireEN.con_ChapterId:
                    this.chapterId = strValue;
                    break;
                case clsvQuestionnaireEN.con_SectionId:
                    this.sectionId = strValue;
                    break;
                case clsvQuestionnaireEN.con_ChapterName:
                    this.chapterName = strValue;
                    break;
                case clsvQuestionnaireEN.con_SectionName:
                    this.sectionName = strValue;
                    break;
                case clsvQuestionnaireEN.con_ChapterName_Sim:
                    this.chapterName_Sim = strValue;
                    break;
                case clsvQuestionnaireEN.con_SectionName_Sim:
                    this.sectionName_Sim = strValue;
                    break;
                case clsvQuestionnaireEN.con_ParentNodeID:
                    this.parentNodeID = strValue;
                    break;
                case clsvQuestionnaireEN.con_CourseChapterReferred:
                    this.courseChapterReferred = strValue;
                    break;
                case clsvQuestionnaireEN.con_ParentNodeName:
                    this.parentNodeName = strValue;
                    break;
                case clsvQuestionnaireEN.con_ParentNodeReferred:
                    this.parentNodeReferred = strValue;
                    break;
                case clsvQuestionnaireEN.con_QuestionTypeId:
                    this.questionTypeId = strValue;
                    break;
                case clsvQuestionnaireEN.con_QuestionTypeName:
                    this.questionTypeName = strValue;
                    break;
                case clsvQuestionnaireEN.con_QuestionTypeId4Course:
                    this.questionTypeId4Course = strValue;
                    break;
                case clsvQuestionnaireEN.con_QuestionTypeName4Course:
                    this.questionTypeName4Course = strValue;
                    break;
                case clsvQuestionnaireEN.con_AnswerTypeId:
                    this.answerTypeId = strValue;
                    break;
                case clsvQuestionnaireEN.con_AnswerTypeName:
                    this.answerTypeName = strValue;
                    break;
                case clsvQuestionnaireEN.con_GridTitle:
                    this.gridTitle = strValue;
                    break;
                case clsvQuestionnaireEN.con_AnswerModeId:
                    this.answerModeId = strValue;
                    break;
                case clsvQuestionnaireEN.con_AnswerModeName:
                    this.answerModeName = strValue;
                    break;
                case clsvQuestionnaireEN.con_QuestionScore:
                    this.questionScore = Number(strValue);
                    break;
                case clsvQuestionnaireEN.con_DefaultValue:
                    this.defaultValue = strValue;
                    break;
                case clsvQuestionnaireEN.con_DefaultSelectItem:
                    this.defaultSelectItem = strValue;
                    break;
                case clsvQuestionnaireEN.con_IsShow:
                    this.isShow = Boolean(strValue);
                    break;
                case clsvQuestionnaireEN.con_IsCast:
                    this.isCast = Boolean(strValue);
                    break;
                case clsvQuestionnaireEN.con_LikeCount:
                    this.likeCount = Number(strValue);
                    break;
                case clsvQuestionnaireEN.con_AnswerAttLimitSize:
                    this.answerAttLimitSize = Number(strValue);
                    break;
                case clsvQuestionnaireEN.con_LimitedResourceType:
                    this.limitedResourceType = strValue;
                    break;
                case clsvQuestionnaireEN.con_IsEffective:
                    this.isEffective = Boolean(strValue);
                    break;
                case clsvQuestionnaireEN.con_IsCanInPaper:
                    this.isCanInPaper = Boolean(strValue);
                    break;
                case clsvQuestionnaireEN.con_ExamGradeId:
                    this.examGradeId = strValue;
                    break;
                case clsvQuestionnaireEN.con_ExamGradeName:
                    this.examGradeName = strValue;
                    break;
                case clsvQuestionnaireEN.con_TextDirectId:
                    this.textDirectId = strValue;
                    break;
                case clsvQuestionnaireEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvQuestionnaireEN.con_UpdUser:
                    this.updUser = strValue;
                    break;
                case clsvQuestionnaireEN.con_Memo:
                    this.memo = strValue;
                    break;
                case clsvQuestionnaireEN.con_FirstIndent:
                    this.firstIndent = Boolean(strValue);
                    break;
                case clsvQuestionnaireEN.con_CodeTab:
                    this.codeTab = strValue;
                    break;
                case clsvQuestionnaireEN.con_CodeTab_Code:
                    this.codeTab_Code = strValue;
                    break;
                case clsvQuestionnaireEN.con_CodeTab_Condition:
                    this.codeTab_Condition = strValue;
                    break;
                case clsvQuestionnaireEN.con_CodeTab_Name:
                    this.codeTab_Name = strValue;
                    break;
                case clsvQuestionnaireEN.con_CourseId_Chapter:
                    this.courseId_Chapter = strValue;
                    break;
                case clsvQuestionnaireEN.con_OptionNum:
                    this.optionNum = Number(strValue);
                    break;
                case clsvQuestionnaireEN.con_ChapterOrderNum:
                    this.chapterOrderNum = Number(strValue);
                    break;
                case clsvQuestionnaireEN.con_QuestionName_Add:
                    this.questionName_Add = strValue;
                    break;
                case clsvQuestionnaireEN.con_DifficultyLevelId:
                    this.difficultyLevelId = strValue;
                    break;
                case clsvQuestionnaireEN.con_FillInTextHeight:
                    this.fillInTextHeight = Number(strValue);
                    break;
                case clsvQuestionnaireEN.con_FillInTextWidth:
                    this.fillInTextWidth = Number(strValue);
                    break;
                case clsvQuestionnaireEN.con_IsHaveAdditionalMemo:
                    this.isHaveAdditionalMemo = Boolean(strValue);
                    break;
                case clsvQuestionnaireEN.con_IsJs:
                    this.isJs = Boolean(strValue);
                    break;
                case clsvQuestionnaireEN.con_IsMulti4FillInText:
                    this.isMulti4FillInText = Boolean(strValue);
                    break;
                case clsvQuestionnaireEN.con_KnowledgeGraphId:
                    this.knowledgeGraphId = strValue;
                    break;
                case clsvQuestionnaireEN.con_MemoTextWidth:
                    this.memoTextWidth = Number(strValue);
                    break;
                case clsvQuestionnaireEN.con_QuestionCode:
                    this.questionCode = strValue;
                    break;
                case clsvQuestionnaireEN.con_SectionTypeId:
                    this.sectionTypeId = strValue;
                    break;
                case clsvQuestionnaireEN.con_CheckBoxLimitCount:
                    this.checkBoxLimitCount = Number(strValue);
                    break;
                case clsvQuestionnaireEN.con_RelaEvent:
                    this.relaEvent = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vQuestionnaire]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
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
        * 常量:"QuestionIndex"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionIndex() { return "questionIndex"; } //题目序号
        /**
        * 常量:"QuestionName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionName() { return "questionName"; } //题目名称
        /**
        * 常量:"QuestionContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionContent() { return "questionContent"; } //题目内容
        /**
        * 常量:"QuestionMemo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionMemo() { return "questionMemo"; } //题目说明
        /**
        * 常量:"QuestionNo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionNo() { return "questionNo"; } //题目编号
        /**
        * 常量:"ParentQuestionId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ParentQuestionId() { return "parentQuestionId"; } //父题目Id
        /**
        * 常量:"ExamAnswer"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ExamAnswer() { return "examAnswer"; } //题目答案
        /**
        * 常量:"CourseId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseId() { return "courseId"; } //课程Id
        /**
        * 常量:"CourseCode"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseCode() { return "courseCode"; } //课程代码
        /**
        * 常量:"CourseName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseName() { return "courseName"; } //课程名称
        /**
        * 常量:"LevelNo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_LevelNo() { return "levelNo"; } //学习关号2
        /**
        * 常量:"CourseChapterId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseChapterId() { return "courseChapterId"; } //课程章节ID
        /**
        * 常量:"CourseChapterName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseChapterName() { return "courseChapterName"; } //课程章节名称
        /**
        * 常量:"ChapterId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ChapterId() { return "chapterId"; } //章Id
        /**
        * 常量:"SectionId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SectionId() { return "sectionId"; } //节Id
        /**
        * 常量:"ChapterName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ChapterName() { return "chapterName"; } //章名
        /**
        * 常量:"SectionName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SectionName() { return "sectionName"; } //节名
        /**
        * 常量:"ChapterName_Sim"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ChapterName_Sim() { return "chapterName_Sim"; } //章名简称
        /**
        * 常量:"SectionName_Sim"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SectionName_Sim() { return "sectionName_Sim"; } //节名简称
        /**
        * 常量:"ParentNodeID"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ParentNodeID() { return "parentNodeID"; } //父节点编号
        /**
        * 常量:"CourseChapterReferred"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseChapterReferred() { return "courseChapterReferred"; } //节简称
        /**
        * 常量:"ParentNodeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ParentNodeName() { return "parentNodeName"; } //父节点名称
        /**
        * 常量:"ParentNodeReferred"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ParentNodeReferred() { return "parentNodeReferred"; } //章简称
        /**
        * 常量:"QuestionTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionTypeId() { return "questionTypeId"; } //题目类型Id
        /**
        * 常量:"QuestionTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionTypeName() { return "questionTypeName"; } //题目类型名
        /**
        * 常量:"QuestionTypeId4Course"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionTypeId4Course() { return "questionTypeId4Course"; } //题目类型Id4课程
        /**
        * 常量:"QuestionTypeName4Course"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionTypeName4Course() { return "questionTypeName4Course"; } //题目类型名4课程
        /**
        * 常量:"AnswerTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AnswerTypeId() { return "answerTypeId"; } //答案类型ID
        /**
        * 常量:"AnswerTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AnswerTypeName() { return "answerTypeName"; } //答案类型名
        /**
        * 常量:"GridTitle"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_GridTitle() { return "gridTitle"; } //表格标题
        /**
        * 常量:"AnswerModeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AnswerModeId() { return "answerModeId"; } //答案模式Id
        /**
        * 常量:"AnswerModeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AnswerModeName() { return "answerModeName"; } //答案模式名称
        /**
        * 常量:"QuestionScore"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionScore() { return "questionScore"; } //题目得分
        /**
        * 常量:"DefaultValue"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DefaultValue() { return "defaultValue"; } //缺省值
        /**
        * 常量:"DefaultSelectItem"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DefaultSelectItem() { return "defaultSelectItem"; } //默认选项
        /**
        * 常量:"IsShow"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsShow() { return "isShow"; } //是否启用
        /**
        * 常量:"IsCast"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsCast() { return "isCast"; } //是否播放
        /**
        * 常量:"LikeCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_LikeCount() { return "likeCount"; } //资源喜欢数量
        /**
        * 常量:"AnswerAttLimitSize"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AnswerAttLimitSize() { return "answerAttLimitSize"; } //回答附件限制大小
        /**
        * 常量:"LimitedResourceType"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_LimitedResourceType() { return "limitedResourceType"; } //限制资源类型
        /**
        * 常量:"IsEffective"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsEffective() { return "isEffective"; } //是否有效
        /**
        * 常量:"IsCanInPaper"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsCanInPaper() { return "isCanInPaper"; } //是否可在Paper
        /**
        * 常量:"ExamGradeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ExamGradeId() { return "examGradeId"; } //题库等级ID
        /**
        * 常量:"ExamGradeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ExamGradeName() { return "examGradeName"; } //题库等级名
        /**
        * 常量:"TextDirectId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TextDirectId() { return "textDirectId"; } //文本方向ID
        /**
        * 常量:"UpdDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdDate() { return "updDate"; } //修改日期
        /**
        * 常量:"UpdUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdUser() { return "updUser"; } //修改人
        /**
        * 常量:"Memo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Memo() { return "memo"; } //备注
        /**
        * 常量:"FirstIndent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_FirstIndent() { return "firstIndent"; } //首行缩进
        /**
        * 常量:"CodeTab"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CodeTab() { return "codeTab"; } //代码表
        /**
        * 常量:"CodeTab_Code"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CodeTab_Code() { return "codeTab_Code"; } //CodeTab_Code
        /**
        * 常量:"CodeTab_Condition"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CodeTab_Condition() { return "codeTab_Condition"; } //代码表_条件
        /**
        * 常量:"CodeTab_Name"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CodeTab_Name() { return "codeTab_Name"; } //CodeTab_Name
        /**
        * 常量:"CourseId_Chapter"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CourseId_Chapter() { return "courseId_Chapter"; } //CourseId_Chapter
        /**
        * 常量:"OptionNum"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OptionNum() { return "optionNum"; } //选项数
        /**
        * 常量:"ChapterOrderNum"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ChapterOrderNum() { return "chapterOrderNum"; } //章排序号
        /**
        * 常量:"QuestionName_Add"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionName_Add() { return "questionName_Add"; } //题目补充
        /**
        * 常量:"DifficultyLevelId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DifficultyLevelId() { return "difficultyLevelId"; } //难度等级Id
        /**
        * 常量:"FillInTextHeight"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_FillInTextHeight() { return "fillInTextHeight"; } //填空框高度
        /**
        * 常量:"FillInTextWidth"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_FillInTextWidth() { return "fillInTextWidth"; } //填空框宽度
        /**
        * 常量:"IsHaveAdditionalMemo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsHaveAdditionalMemo() { return "isHaveAdditionalMemo"; } //是否有附加说明
        /**
        * 常量:"IsJs"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsJs() { return "isJs"; } //是否是JS
        /**
        * 常量:"IsMulti4FillInText"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsMulti4FillInText() { return "isMulti4FillInText"; } //是否填空框多行
        /**
        * 常量:"KnowledgeGraphId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_KnowledgeGraphId() { return "knowledgeGraphId"; } //知识点图Id
        /**
        * 常量:"MemoTextWidth"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_MemoTextWidth() { return "memoTextWidth"; } //备注框宽度
        /**
        * 常量:"QuestionCode"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionCode() { return "questionCode"; } //html代码
        /**
        * 常量:"SectionTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SectionTypeId() { return "sectionTypeId"; } //节点类型Id
        /**
        * 常量:"CheckBoxLimitCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CheckBoxLimitCount() { return "checkBoxLimitCount"; } //复选框限制数
        /**
        * 常量:"RelaEvent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_RelaEvent() { return "relaEvent"; } //相关事件
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
    exports.clsvQuestionnaireEN = clsvQuestionnaireEN;
    clsvQuestionnaireEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvQuestionnaireEN.CacheModeId = "02"; //客户端缓存
    clsvQuestionnaireEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsvQuestionnaireEN.WhereFormat = ""; //条件格式串
    clsvQuestionnaireEN._CurrTabName = "vQuestionnaire"; //当前表名,与该类相关的表名
    clsvQuestionnaireEN._KeyFldName = "QuestionID"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvQuestionnaireEN.mintAttributeCount = 70;
    clsvQuestionnaireEN.AttributeName = ["questionID", "questionIndex", "questionName", "questionContent", "questionMemo", "questionNo", "parentQuestionId", "examAnswer", "courseId", "courseCode", "courseName", "levelNo", "courseChapterId", "courseChapterName", "chapterId", "sectionId", "chapterName", "sectionName", "chapterName_Sim", "sectionName_Sim", "parentNodeID", "courseChapterReferred", "parentNodeName", "parentNodeReferred", "questionTypeId", "questionTypeName", "questionTypeId4Course", "questionTypeName4Course", "answerTypeId", "answerTypeName", "gridTitle", "answerModeId", "answerModeName", "questionScore", "defaultValue", "defaultSelectItem", "isShow", "isCast", "likeCount", "answerAttLimitSize", "limitedResourceType", "isEffective", "isCanInPaper", "examGradeId", "examGradeName", "textDirectId", "updDate", "updUser", "memo", "firstIndent", "codeTab", "codeTab_Code", "codeTab_Condition", "codeTab_Name", "courseId_Chapter", "optionNum", "chapterOrderNum", "questionName_Add", "difficultyLevelId", "fillInTextHeight", "fillInTextWidth", "isHaveAdditionalMemo", "isJs", "isMulti4FillInText", "knowledgeGraphId", "memoTextWidth", "questionCode", "sectionTypeId", "checkBoxLimitCount", "relaEvent"];
});
