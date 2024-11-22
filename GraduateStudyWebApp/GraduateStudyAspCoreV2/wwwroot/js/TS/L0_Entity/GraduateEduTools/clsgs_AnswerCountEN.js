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
    exports.clsgs_AnswerCountEN = void 0;
    /**
    * 类名:clsgs_AnswerCountEN
    * 表名:gs_AnswerCount(01120767)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:47:38
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:研培设置(GraduateEduTools)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 问题讨论回答统计(gs_AnswerCount)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsgs_AnswerCountEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrMemo = ""; //备注
            this.mstrAnswerCountId = ""; //AnswerCountId
            this.mstrDataUser = ""; //数据用户
            this.mstrDataAddDate = ""; //数据添加日期
            this.mintMonth = 0; //月
            this.mintWeek = 0; //周
            this.mstrWeekTimeRange = ""; //WeekTimeRange
            this.mbolIsRecommend = false; //是否推荐
            this.mstrAnswerId = ""; //回答Id
            this.mstrAnswerTypeId = ""; //答案类型ID
            this.mstrQuestionsId = ""; //提问Id
            this.mstrTopicId = ""; //主题Id
            this.mstrPaperId = ""; //论文Id
            this.mstrid_CurrEduCls = ""; //教学班流水号
            this.mstrAnswerContent = ""; //答案内容
            this.mfltScore = 0.0; //评分
            this.mstrScoreType = ""; //评分类型
            this.mstrUpdUser = ""; //修改人
            this.mstrUpdDate = ""; //修改日期
            this.mstrUserName = ""; //用户名
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.memo = ""; //备注
            this.answerCountId = ""; //AnswerCountId
            this.dataUser = ""; //数据用户
            this.dataAddDate = ""; //数据添加日期
            this.month = 0; //月
            this.week = 0; //周
            this.weekTimeRange = ""; //WeekTimeRange
            this.isRecommend = false; //是否推荐
            this.answerId = ""; //回答Id
            this.answerTypeId = ""; //答案类型ID
            this.questionsId = ""; //提问Id
            this.topicId = ""; //主题Id
            this.paperId = ""; //论文Id
            this.id_CurrEduCls = ""; //教学班流水号
            this.answerContent = ""; //答案内容
            this.score = 0.0; //评分
            this.scoreType = ""; //评分类型
            this.updUser = ""; //修改人
            this.updDate = ""; //修改日期
            this.userName = ""; //用户名
        }
        /**
         * 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetMemo(value) {
            if (value != undefined) {
                this.memo = value;
                this.hmProperty["memo"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * AnswerCountId(说明:;字段类型:char;字段长度:10;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetAnswerCountId(value) {
            if (value != undefined) {
                this.answerCountId = value;
                this.hmProperty["answerCountId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 数据用户(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetDataUser(value) {
            if (value != undefined) {
                this.dataUser = value;
                this.hmProperty["dataUser"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 数据添加日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetDataAddDate(value) {
            if (value != undefined) {
                this.dataAddDate = value;
                this.hmProperty["dataAddDate"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 月(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetMonth(value) {
            if (value != undefined) {
                this.month = value;
                this.hmProperty["month"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 周(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetWeek(value) {
            if (value != undefined) {
                this.week = value;
                this.hmProperty["week"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * WeekTimeRange(说明:;字段类型:varchar;字段长度:100;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetWeekTimeRange(value) {
            if (value != undefined) {
                this.weekTimeRange = value;
                this.hmProperty["weekTimeRange"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
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
                this.sf_UpdFldSetStr = this.updFldString;
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
                this.sf_UpdFldSetStr = this.updFldString;
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
                this.sf_UpdFldSetStr = this.updFldString;
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
                this.sf_UpdFldSetStr = this.updFldString;
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
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 论文Id(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPaperId(value) {
            if (value != undefined) {
                this.paperId = value;
                this.hmProperty["paperId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 教学班流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        Setid_CurrEduCls(value) {
            if (value != undefined) {
                this.id_CurrEduCls = value;
                this.hmProperty["id_CurrEduCls"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
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
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 评分(说明:;字段类型:float;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetScore(value) {
            if (value != undefined) {
                this.score = value;
                this.hmProperty["score"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
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
                this.sf_UpdFldSetStr = this.updFldString;
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
                this.sf_UpdFldSetStr = this.updFldString;
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
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetUserName(value) {
            if (value != undefined) {
                this.userName = value;
                this.hmProperty["userName"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
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
                case clsgs_AnswerCountEN.con_Memo:
                    return this.memo;
                case clsgs_AnswerCountEN.con_AnswerCountId:
                    return this.answerCountId;
                case clsgs_AnswerCountEN.con_DataUser:
                    return this.dataUser;
                case clsgs_AnswerCountEN.con_DataAddDate:
                    return this.dataAddDate;
                case clsgs_AnswerCountEN.con_Month:
                    return this.month;
                case clsgs_AnswerCountEN.con_Week:
                    return this.week;
                case clsgs_AnswerCountEN.con_WeekTimeRange:
                    return this.weekTimeRange;
                case clsgs_AnswerCountEN.con_IsRecommend:
                    return this.isRecommend;
                case clsgs_AnswerCountEN.con_AnswerId:
                    return this.answerId;
                case clsgs_AnswerCountEN.con_AnswerTypeId:
                    return this.answerTypeId;
                case clsgs_AnswerCountEN.con_QuestionsId:
                    return this.questionsId;
                case clsgs_AnswerCountEN.con_TopicId:
                    return this.topicId;
                case clsgs_AnswerCountEN.con_PaperId:
                    return this.paperId;
                case clsgs_AnswerCountEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clsgs_AnswerCountEN.con_AnswerContent:
                    return this.answerContent;
                case clsgs_AnswerCountEN.con_Score:
                    return this.score;
                case clsgs_AnswerCountEN.con_ScoreType:
                    return this.scoreType;
                case clsgs_AnswerCountEN.con_UpdUser:
                    return this.updUser;
                case clsgs_AnswerCountEN.con_UpdDate:
                    return this.updDate;
                case clsgs_AnswerCountEN.con_UserName:
                    return this.userName;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[gs_AnswerCount]中不存在！`;
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
                case clsgs_AnswerCountEN.con_Memo:
                    this.memo = strValue;
                    this.hmProperty["memo"] = true;
                    break;
                case clsgs_AnswerCountEN.con_AnswerCountId:
                    this.answerCountId = strValue;
                    this.hmProperty["answerCountId"] = true;
                    break;
                case clsgs_AnswerCountEN.con_DataUser:
                    this.dataUser = strValue;
                    this.hmProperty["dataUser"] = true;
                    break;
                case clsgs_AnswerCountEN.con_DataAddDate:
                    this.dataAddDate = strValue;
                    this.hmProperty["dataAddDate"] = true;
                    break;
                case clsgs_AnswerCountEN.con_Month:
                    this.month = Number(strValue);
                    this.hmProperty["month"] = true;
                    break;
                case clsgs_AnswerCountEN.con_Week:
                    this.week = Number(strValue);
                    this.hmProperty["week"] = true;
                    break;
                case clsgs_AnswerCountEN.con_WeekTimeRange:
                    this.weekTimeRange = strValue;
                    this.hmProperty["weekTimeRange"] = true;
                    break;
                case clsgs_AnswerCountEN.con_IsRecommend:
                    this.isRecommend = Boolean(strValue);
                    this.hmProperty["isRecommend"] = true;
                    break;
                case clsgs_AnswerCountEN.con_AnswerId:
                    this.answerId = strValue;
                    this.hmProperty["answerId"] = true;
                    break;
                case clsgs_AnswerCountEN.con_AnswerTypeId:
                    this.answerTypeId = strValue;
                    this.hmProperty["answerTypeId"] = true;
                    break;
                case clsgs_AnswerCountEN.con_QuestionsId:
                    this.questionsId = strValue;
                    this.hmProperty["questionsId"] = true;
                    break;
                case clsgs_AnswerCountEN.con_TopicId:
                    this.topicId = strValue;
                    this.hmProperty["topicId"] = true;
                    break;
                case clsgs_AnswerCountEN.con_PaperId:
                    this.paperId = strValue;
                    this.hmProperty["paperId"] = true;
                    break;
                case clsgs_AnswerCountEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    this.hmProperty["id_CurrEduCls"] = true;
                    break;
                case clsgs_AnswerCountEN.con_AnswerContent:
                    this.answerContent = strValue;
                    this.hmProperty["answerContent"] = true;
                    break;
                case clsgs_AnswerCountEN.con_Score:
                    this.score = Number(strValue);
                    this.hmProperty["score"] = true;
                    break;
                case clsgs_AnswerCountEN.con_ScoreType:
                    this.scoreType = strValue;
                    this.hmProperty["scoreType"] = true;
                    break;
                case clsgs_AnswerCountEN.con_UpdUser:
                    this.updUser = strValue;
                    this.hmProperty["updUser"] = true;
                    break;
                case clsgs_AnswerCountEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsgs_AnswerCountEN.con_UserName:
                    this.userName = strValue;
                    this.hmProperty["userName"] = true;
                    break;
                case "sf_UpdFldSetStr":
                    this.sf_UpdFldSetStr = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[gs_AnswerCount]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"Memo"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Memo() { return "memo"; } //备注
        /**
        * 常量:"AnswerCountId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AnswerCountId() { return "answerCountId"; } //AnswerCountId
        /**
        * 常量:"DataUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DataUser() { return "dataUser"; } //数据用户
        /**
        * 常量:"DataAddDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DataAddDate() { return "dataAddDate"; } //数据添加日期
        /**
        * 常量:"Month"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Month() { return "month"; } //月
        /**
        * 常量:"Week"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Week() { return "week"; } //周
        /**
        * 常量:"WeekTimeRange"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_WeekTimeRange() { return "weekTimeRange"; } //WeekTimeRange
        /**
        * 常量:"IsRecommend"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsRecommend() { return "isRecommend"; } //是否推荐
        /**
        * 常量:"AnswerId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AnswerId() { return "answerId"; } //回答Id
        /**
        * 常量:"AnswerTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AnswerTypeId() { return "answerTypeId"; } //答案类型ID
        /**
        * 常量:"QuestionsId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_QuestionsId() { return "questionsId"; } //提问Id
        /**
        * 常量:"TopicId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TopicId() { return "topicId"; } //主题Id
        /**
        * 常量:"PaperId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperId() { return "paperId"; } //论文Id
        /**
        * 常量:"id_CurrEduCls"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_CurrEduCls() { return "id_CurrEduCls"; } //教学班流水号
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
        * 常量:"UserName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserName() { return "userName"; } //用户名
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
    exports.clsgs_AnswerCountEN = clsgs_AnswerCountEN;
    clsgs_AnswerCountEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsgs_AnswerCountEN.CacheModeId = "02"; //客户端缓存
    clsgs_AnswerCountEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsgs_AnswerCountEN.WhereFormat = ""; //条件格式串
    clsgs_AnswerCountEN._CurrTabName = "gs_AnswerCount"; //当前表名,与该类相关的表名
    clsgs_AnswerCountEN._KeyFldName = "AnswerCountId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsgs_AnswerCountEN.mintAttributeCount = 20;
    clsgs_AnswerCountEN.AttributeName = ["memo", "answerCountId", "dataUser", "dataAddDate", "month", "week", "weekTimeRange", "isRecommend", "answerId", "answerTypeId", "questionsId", "topicId", "paperId", "id_CurrEduCls", "answerContent", "score", "scoreType", "updUser", "updDate", "userName"];
});
