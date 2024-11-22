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
    exports.clsvqa_AnswerEN = void 0;
    /**
    * 类名:clsvqa_AnswerEN
    * 表名:vqa_Answer(01120635)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:45:05
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:互动管理(InteractManage)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * v答疑回答(vqa_Answer)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvqa_AnswerEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.answerId = ""; //回答Id
            this.questionsId = ""; //提问Id
            this.answerContent = ""; //答案内容
            this.score = 0.0; //评分
            this.scoreType = ""; //评分类型
            this.isRight = false; //是否正确
            this.parentId = ""; //父节点Id
            this.voteCount = 0; //点赞计数
            this.updUser = ""; //修改人
            this.userName = ""; //用户名
            this.updDate = ""; //修改日期
            this.memo = ""; //备注
            this.qa_PaperId = ""; //论文答疑Id
            this.questionsContent = ""; //提问内容
            this.paperId = ""; //论文Id
            this.questionsTypeId = ""; //问题类型Id
            this.questionsTypeName = ""; //问题类型名称
            this.isRecommend = false; //是否推荐
            this.topicId = ""; //主题Id
            this.answerTypeId = ""; //答案类型ID
            this.isSubmit = false; //是否提交
            this.answerCount = 0; //回答计数
            this.paperTitle = ""; //论文标题
            this.questUserName = ""; //QuestUserName
            this.appraiseCount = 0; //评论数
            this.stuScore = 0.0; //学生平均分
            this.teaScore = 0.0; //教师评分
            this.userId = ""; //用户ID
            this.id_CurrEduCls = ""; //教学班流水号
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
                case clsvqa_AnswerEN.con_AnswerId:
                    return this.answerId;
                case clsvqa_AnswerEN.con_QuestionsId:
                    return this.questionsId;
                case clsvqa_AnswerEN.con_AnswerContent:
                    return this.answerContent;
                case clsvqa_AnswerEN.con_Score:
                    return this.score;
                case clsvqa_AnswerEN.con_ScoreType:
                    return this.scoreType;
                case clsvqa_AnswerEN.con_IsRight:
                    return this.isRight;
                case clsvqa_AnswerEN.con_ParentId:
                    return this.parentId;
                case clsvqa_AnswerEN.con_VoteCount:
                    return this.voteCount;
                case clsvqa_AnswerEN.con_UpdUser:
                    return this.updUser;
                case clsvqa_AnswerEN.con_UserName:
                    return this.userName;
                case clsvqa_AnswerEN.con_UpdDate:
                    return this.updDate;
                case clsvqa_AnswerEN.con_Memo:
                    return this.memo;
                case clsvqa_AnswerEN.con_qa_PaperId:
                    return this.qa_PaperId;
                case clsvqa_AnswerEN.con_QuestionsContent:
                    return this.questionsContent;
                case clsvqa_AnswerEN.con_PaperId:
                    return this.paperId;
                case clsvqa_AnswerEN.con_QuestionsTypeId:
                    return this.questionsTypeId;
                case clsvqa_AnswerEN.con_QuestionsTypeName:
                    return this.questionsTypeName;
                case clsvqa_AnswerEN.con_IsRecommend:
                    return this.isRecommend;
                case clsvqa_AnswerEN.con_TopicId:
                    return this.topicId;
                case clsvqa_AnswerEN.con_AnswerTypeId:
                    return this.answerTypeId;
                case clsvqa_AnswerEN.con_IsSubmit:
                    return this.isSubmit;
                case clsvqa_AnswerEN.con_AnswerCount:
                    return this.answerCount;
                case clsvqa_AnswerEN.con_PaperTitle:
                    return this.paperTitle;
                case clsvqa_AnswerEN.con_QuestUserName:
                    return this.questUserName;
                case clsvqa_AnswerEN.con_AppraiseCount:
                    return this.appraiseCount;
                case clsvqa_AnswerEN.con_StuScore:
                    return this.stuScore;
                case clsvqa_AnswerEN.con_TeaScore:
                    return this.teaScore;
                case clsvqa_AnswerEN.con_UserId:
                    return this.userId;
                case clsvqa_AnswerEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vqa_Answer]中不存在！`;
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
                case clsvqa_AnswerEN.con_AnswerId:
                    this.answerId = strValue;
                    break;
                case clsvqa_AnswerEN.con_QuestionsId:
                    this.questionsId = strValue;
                    break;
                case clsvqa_AnswerEN.con_AnswerContent:
                    this.answerContent = strValue;
                    break;
                case clsvqa_AnswerEN.con_Score:
                    this.score = Number(strValue);
                    break;
                case clsvqa_AnswerEN.con_ScoreType:
                    this.scoreType = strValue;
                    break;
                case clsvqa_AnswerEN.con_IsRight:
                    this.isRight = Boolean(strValue);
                    break;
                case clsvqa_AnswerEN.con_ParentId:
                    this.parentId = strValue;
                    break;
                case clsvqa_AnswerEN.con_VoteCount:
                    this.voteCount = Number(strValue);
                    break;
                case clsvqa_AnswerEN.con_UpdUser:
                    this.updUser = strValue;
                    break;
                case clsvqa_AnswerEN.con_UserName:
                    this.userName = strValue;
                    break;
                case clsvqa_AnswerEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvqa_AnswerEN.con_Memo:
                    this.memo = strValue;
                    break;
                case clsvqa_AnswerEN.con_qa_PaperId:
                    this.qa_PaperId = strValue;
                    break;
                case clsvqa_AnswerEN.con_QuestionsContent:
                    this.questionsContent = strValue;
                    break;
                case clsvqa_AnswerEN.con_PaperId:
                    this.paperId = strValue;
                    break;
                case clsvqa_AnswerEN.con_QuestionsTypeId:
                    this.questionsTypeId = strValue;
                    break;
                case clsvqa_AnswerEN.con_QuestionsTypeName:
                    this.questionsTypeName = strValue;
                    break;
                case clsvqa_AnswerEN.con_IsRecommend:
                    this.isRecommend = Boolean(strValue);
                    break;
                case clsvqa_AnswerEN.con_TopicId:
                    this.topicId = strValue;
                    break;
                case clsvqa_AnswerEN.con_AnswerTypeId:
                    this.answerTypeId = strValue;
                    break;
                case clsvqa_AnswerEN.con_IsSubmit:
                    this.isSubmit = Boolean(strValue);
                    break;
                case clsvqa_AnswerEN.con_AnswerCount:
                    this.answerCount = Number(strValue);
                    break;
                case clsvqa_AnswerEN.con_PaperTitle:
                    this.paperTitle = strValue;
                    break;
                case clsvqa_AnswerEN.con_QuestUserName:
                    this.questUserName = strValue;
                    break;
                case clsvqa_AnswerEN.con_AppraiseCount:
                    this.appraiseCount = Number(strValue);
                    break;
                case clsvqa_AnswerEN.con_StuScore:
                    this.stuScore = Number(strValue);
                    break;
                case clsvqa_AnswerEN.con_TeaScore:
                    this.teaScore = Number(strValue);
                    break;
                case clsvqa_AnswerEN.con_UserId:
                    this.userId = strValue;
                    break;
                case clsvqa_AnswerEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vqa_Answer]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"AnswerId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AnswerId() { return "answerId"; } //回答Id
        /**
        * 常量:"QuestionsId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionsId() { return "questionsId"; } //提问Id
        /**
        * 常量:"AnswerContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AnswerContent() { return "answerContent"; } //答案内容
        /**
        * 常量:"Score"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Score() { return "score"; } //评分
        /**
        * 常量:"ScoreType"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ScoreType() { return "scoreType"; } //评分类型
        /**
        * 常量:"IsRight"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsRight() { return "isRight"; } //是否正确
        /**
        * 常量:"ParentId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ParentId() { return "parentId"; } //父节点Id
        /**
        * 常量:"VoteCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_VoteCount() { return "voteCount"; } //点赞计数
        /**
        * 常量:"UpdUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdUser() { return "updUser"; } //修改人
        /**
        * 常量:"UserName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserName() { return "userName"; } //用户名
        /**
        * 常量:"UpdDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdDate() { return "updDate"; } //修改日期
        /**
        * 常量:"Memo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Memo() { return "memo"; } //备注
        /**
        * 常量:"qa_PaperId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_qa_PaperId() { return "qa_PaperId"; } //论文答疑Id
        /**
        * 常量:"QuestionsContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionsContent() { return "questionsContent"; } //提问内容
        /**
        * 常量:"PaperId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperId() { return "paperId"; } //论文Id
        /**
        * 常量:"QuestionsTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionsTypeId() { return "questionsTypeId"; } //问题类型Id
        /**
        * 常量:"QuestionsTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionsTypeName() { return "questionsTypeName"; } //问题类型名称
        /**
        * 常量:"IsRecommend"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsRecommend() { return "isRecommend"; } //是否推荐
        /**
        * 常量:"TopicId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TopicId() { return "topicId"; } //主题Id
        /**
        * 常量:"AnswerTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AnswerTypeId() { return "answerTypeId"; } //答案类型ID
        /**
        * 常量:"IsSubmit"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsSubmit() { return "isSubmit"; } //是否提交
        /**
        * 常量:"AnswerCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AnswerCount() { return "answerCount"; } //回答计数
        /**
        * 常量:"PaperTitle"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperTitle() { return "paperTitle"; } //论文标题
        /**
        * 常量:"QuestUserName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestUserName() { return "questUserName"; } //QuestUserName
        /**
        * 常量:"AppraiseCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AppraiseCount() { return "appraiseCount"; } //评论数
        /**
        * 常量:"StuScore"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_StuScore() { return "stuScore"; } //学生平均分
        /**
        * 常量:"TeaScore"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TeaScore() { return "teaScore"; } //教师评分
        /**
        * 常量:"UserId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserId() { return "userId"; } //用户ID
        /**
        * 常量:"id_CurrEduCls"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_CurrEduCls() { return "id_CurrEduCls"; } //教学班流水号
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
    exports.clsvqa_AnswerEN = clsvqa_AnswerEN;
    clsvqa_AnswerEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvqa_AnswerEN.CacheModeId = "04"; //sessionStorage
    clsvqa_AnswerEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsvqa_AnswerEN.WhereFormat = ""; //条件格式串
    clsvqa_AnswerEN._CurrTabName = "vqa_Answer"; //当前表名,与该类相关的表名
    clsvqa_AnswerEN._KeyFldName = "AnswerId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvqa_AnswerEN.mintAttributeCount = 29;
    clsvqa_AnswerEN.AttributeName = ["answerId", "questionsId", "answerContent", "score", "scoreType", "isRight", "parentId", "voteCount", "updUser", "userName", "updDate", "memo", "qa_PaperId", "questionsContent", "paperId", "questionsTypeId", "questionsTypeName", "isRecommend", "topicId", "answerTypeId", "isSubmit", "answerCount", "paperTitle", "questUserName", "appraiseCount", "stuScore", "teaScore", "userId", "id_CurrEduCls"];
});
