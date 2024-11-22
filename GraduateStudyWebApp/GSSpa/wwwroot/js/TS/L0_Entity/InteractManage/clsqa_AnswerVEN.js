(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../PubFun/clsGeneralTab.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsqa_AnswerVEN = void 0;
    /**
    * 类名:clsqa_AnswerVEN
    * 表名:qa_AnswerV(01120756)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 11:46:12
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
    * 答疑回答历史V(qa_AnswerV)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsqa_AnswerVEN extends clsGeneralTab_js_1.clsGeneralTab {
        //以下是属性变量
        /**
         * 构造函数
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
        */
        constructor() {
            super();
            /**
             * 设置对象中私有属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPrivateVar)
            */
            this.mlngAnswerVId = 0; //问答历史主键
            this.mstrAnswerId = ""; //回答Id
            this.mstrQuestionsId = ""; //提问Id
            this.mstrAnswerContent = ""; //答案内容
            this.mfltscore = 0.0; //评分
            this.mstrScoreType = ""; //评分类型
            this.mbolIsRight = false; //是否正确
            this.mstrParentId = ""; //父节点Id
            this.mintVoteCount = 0; //点赞计数
            this.mbolIsRecommend = false; //是否推荐
            this.mstrTopicId = ""; //主题Id
            this.mstrAnswerTypeId = ""; //答案类型ID
            this.mbolIsSubmit = false; //是否提交
            this.mstrUpdUser = ""; //修改人
            this.mstrUpdDate = ""; //修改日期
            this.mstrMemo = ""; //备注
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.answerVId = 0; //问答历史主键
            this.answerId = ""; //回答Id
            this.questionsId = ""; //提问Id
            this.answerContent = ""; //答案内容
            this.score = 0.0; //评分
            this.scoreType = ""; //评分类型
            this.isRight = false; //是否正确
            this.parentId = ""; //父节点Id
            this.voteCount = 0; //点赞计数
            this.isRecommend = false; //是否推荐
            this.topicId = ""; //主题Id
            this.answerTypeId = ""; //答案类型ID
            this.isSubmit = false; //是否提交
            this.updUser = ""; //修改人
            this.updDate = ""; //修改日期
            this.memo = ""; //备注
        }
        /**
         * 问答历史主键(说明:;字段类型:bigint;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetAnswerVId(value) {
            if (value != undefined) {
                this.answerVId = value;
                this.hmProperty["answerVId"] = true;
            }
        }
        /**
         * 回答Id(说明:;字段类型:char;字段长度:10;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetAnswerId(value) {
            if (value != undefined) {
                this.answerId = value;
                this.hmProperty["answerId"] = true;
            }
        }
        /**
         * 提问Id(说明:;字段类型:char;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetQuestionsId(value) {
            if (value != undefined) {
                this.questionsId = value;
                this.hmProperty["questionsId"] = true;
            }
        }
        /**
         * 答案内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetAnswerContent(value) {
            if (value != undefined) {
                this.answerContent = value;
                this.hmProperty["answerContent"] = true;
            }
        }
        /**
         * 评分(说明:;字段类型:float;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setscore(value) {
            if (value != undefined) {
                this.score = value;
                this.hmProperty["score"] = true;
            }
        }
        /**
         * 评分类型(说明:;字段类型:char;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetScoreType(value) {
            if (value != undefined) {
                this.scoreType = value;
                this.hmProperty["scoreType"] = true;
            }
        }
        /**
         * 是否正确(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsRight(value) {
            if (value != undefined) {
                this.isRight = value;
                this.hmProperty["isRight"] = true;
            }
        }
        /**
         * 父节点Id(说明:;字段类型:char;字段长度:10;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetParentId(value) {
            if (value != undefined) {
                this.parentId = value;
                this.hmProperty["parentId"] = true;
            }
        }
        /**
         * 点赞计数(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetVoteCount(value) {
            if (value != undefined) {
                this.voteCount = value;
                this.hmProperty["voteCount"] = true;
            }
        }
        /**
         * 是否推荐(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsRecommend(value) {
            if (value != undefined) {
                this.isRecommend = value;
                this.hmProperty["isRecommend"] = true;
            }
        }
        /**
         * 主题Id(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetTopicId(value) {
            if (value != undefined) {
                this.topicId = value;
                this.hmProperty["topicId"] = true;
            }
        }
        /**
         * 答案类型ID(说明:;字段类型:char;字段长度:2;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetAnswerTypeId(value) {
            if (value != undefined) {
                this.answerTypeId = value;
                this.hmProperty["answerTypeId"] = true;
            }
        }
        /**
         * 是否提交(说明:;字段类型:bit;字段长度:1;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetIsSubmit(value) {
            if (value != undefined) {
                this.isSubmit = value;
                this.hmProperty["isSubmit"] = true;
            }
        }
        /**
         * 修改人(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetUpdUser(value) {
            if (value != undefined) {
                this.updUser = value;
                this.hmProperty["updUser"] = true;
            }
        }
        /**
         * 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetUpdDate(value) {
            if (value != undefined) {
                this.updDate = value;
                this.hmProperty["updDate"] = true;
            }
        }
        /**
         * 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetMemo(value) {
            if (value != undefined) {
                this.memo = value;
                this.hmProperty["memo"] = true;
            }
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
                case clsqa_AnswerVEN.con_AnswerVId:
                    return this.answerVId;
                case clsqa_AnswerVEN.con_AnswerId:
                    return this.answerId;
                case clsqa_AnswerVEN.con_QuestionsId:
                    return this.questionsId;
                case clsqa_AnswerVEN.con_AnswerContent:
                    return this.answerContent;
                case clsqa_AnswerVEN.con_score:
                    return this.score;
                case clsqa_AnswerVEN.con_ScoreType:
                    return this.scoreType;
                case clsqa_AnswerVEN.con_IsRight:
                    return this.isRight;
                case clsqa_AnswerVEN.con_ParentId:
                    return this.parentId;
                case clsqa_AnswerVEN.con_VoteCount:
                    return this.voteCount;
                case clsqa_AnswerVEN.con_IsRecommend:
                    return this.isRecommend;
                case clsqa_AnswerVEN.con_TopicId:
                    return this.topicId;
                case clsqa_AnswerVEN.con_AnswerTypeId:
                    return this.answerTypeId;
                case clsqa_AnswerVEN.con_IsSubmit:
                    return this.isSubmit;
                case clsqa_AnswerVEN.con_UpdUser:
                    return this.updUser;
                case clsqa_AnswerVEN.con_UpdDate:
                    return this.updDate;
                case clsqa_AnswerVEN.con_Memo:
                    return this.memo;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[qa_AnswerV]中不存在！`;
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
                case clsqa_AnswerVEN.con_AnswerVId:
                    this.answerVId = Number(strValue);
                    this.hmProperty["answerVId"] = true;
                    break;
                case clsqa_AnswerVEN.con_AnswerId:
                    this.answerId = strValue;
                    this.hmProperty["answerId"] = true;
                    break;
                case clsqa_AnswerVEN.con_QuestionsId:
                    this.questionsId = strValue;
                    this.hmProperty["questionsId"] = true;
                    break;
                case clsqa_AnswerVEN.con_AnswerContent:
                    this.answerContent = strValue;
                    this.hmProperty["answerContent"] = true;
                    break;
                case clsqa_AnswerVEN.con_score:
                    this.score = Number(strValue);
                    this.hmProperty["score"] = true;
                    break;
                case clsqa_AnswerVEN.con_ScoreType:
                    this.scoreType = strValue;
                    this.hmProperty["scoreType"] = true;
                    break;
                case clsqa_AnswerVEN.con_IsRight:
                    this.isRight = Boolean(strValue);
                    this.hmProperty["isRight"] = true;
                    break;
                case clsqa_AnswerVEN.con_ParentId:
                    this.parentId = strValue;
                    this.hmProperty["parentId"] = true;
                    break;
                case clsqa_AnswerVEN.con_VoteCount:
                    this.voteCount = Number(strValue);
                    this.hmProperty["voteCount"] = true;
                    break;
                case clsqa_AnswerVEN.con_IsRecommend:
                    this.isRecommend = Boolean(strValue);
                    this.hmProperty["isRecommend"] = true;
                    break;
                case clsqa_AnswerVEN.con_TopicId:
                    this.topicId = strValue;
                    this.hmProperty["topicId"] = true;
                    break;
                case clsqa_AnswerVEN.con_AnswerTypeId:
                    this.answerTypeId = strValue;
                    this.hmProperty["answerTypeId"] = true;
                    break;
                case clsqa_AnswerVEN.con_IsSubmit:
                    this.isSubmit = Boolean(strValue);
                    this.hmProperty["isSubmit"] = true;
                    break;
                case clsqa_AnswerVEN.con_UpdUser:
                    this.updUser = strValue;
                    this.hmProperty["updUser"] = true;
                    break;
                case clsqa_AnswerVEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsqa_AnswerVEN.con_Memo:
                    this.memo = strValue;
                    this.hmProperty["memo"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[qa_AnswerV]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"AnswerVId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AnswerVId() { return "answerVId"; } //问答历史主键
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
        * 常量:"score"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_score() { return "score"; } //评分
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
        * 常量:"UpdUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdUser() { return "updUser"; } //修改人
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
    exports.clsqa_AnswerVEN = clsqa_AnswerVEN;
    clsqa_AnswerVEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsqa_AnswerVEN.CacheModeId = "04"; //sessionStorage
    clsqa_AnswerVEN._CurrTabName = "qa_AnswerV"; //当前表名,与该类相关的表名
    clsqa_AnswerVEN._KeyFldName = "AnswerVId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsqa_AnswerVEN.mintAttributeCount = 16;
    clsqa_AnswerVEN.AttributeName = ["answerVId", "answerId", "questionsId", "answerContent", "score", "scoreType", "isRight", "parentId", "voteCount", "isRecommend", "topicId", "answerTypeId", "isSubmit", "updUser", "updDate", "memo"];
});
