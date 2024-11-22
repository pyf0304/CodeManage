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
    exports.clsgs_ResearchResultEN = void 0;
    /**
    * 类名:clsgs_ResearchResultEN
    * 表名:gs_ResearchResult(01120780)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 11:47:06
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:研培主题(GraduateEduTopic)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 研究成果(gs_ResearchResult)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsgs_ResearchResultEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrResultId = ""; //成果Id
            this.mstrTopicId = ""; //主题Id
            this.mstrPaperId = ""; //论文Id
            this.mstrResultTypeId = ""; //成果类型Id
            this.mstrResultName = ""; //成果名称
            this.mstrResultContent = ""; //成果内容
            this.mstrAuthor = ""; //作者
            this.mstrDivision = ""; //分工
            this.mintVersionCount = 0; //版本统计
            this.mintOkCount = 0; //点赞统计
            this.mintAppraiseCount = 0; //评论数
            this.mfltscore = 0.0; //评分
            this.mfltStuScore = 0.0; //学生平均分
            this.mfltTeaScore = 0.0; //教师评分
            this.mstrid_CurrEduCls = ""; //教学班流水号
            this.mstrUpdDate = ""; //修改日期
            this.mstrUpdUser = ""; //修改人
            this.mstrMemo = ""; //备注
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.resultId = ""; //成果Id
            this.topicId = ""; //主题Id
            this.paperId = ""; //论文Id
            this.resultTypeId = ""; //成果类型Id
            this.resultName = ""; //成果名称
            this.resultContent = ""; //成果内容
            this.author = ""; //作者
            this.division = ""; //分工
            this.versionCount = 0; //版本统计
            this.okCount = 0; //点赞统计
            this.appraiseCount = 0; //评论数
            this.score = 0.0; //评分
            this.stuScore = 0.0; //学生平均分
            this.teaScore = 0.0; //教师评分
            this.id_CurrEduCls = ""; //教学班流水号
            this.updDate = ""; //修改日期
            this.updUser = ""; //修改人
            this.memo = ""; //备注
        }
        /**
         * 成果Id(说明:;字段类型:char;字段长度:10;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetResultId(value) {
            if (value != undefined) {
                this.resultId = value;
                this.hmProperty["resultId"] = true;
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
         * 论文Id(说明:;字段类型:char;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPaperId(value) {
            if (value != undefined) {
                this.paperId = value;
                this.hmProperty["paperId"] = true;
            }
        }
        /**
         * 成果类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetResultTypeId(value) {
            if (value != undefined) {
                this.resultTypeId = value;
                this.hmProperty["resultTypeId"] = true;
            }
        }
        /**
         * 成果名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetResultName(value) {
            if (value != undefined) {
                this.resultName = value;
                this.hmProperty["resultName"] = true;
            }
        }
        /**
         * 成果内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetResultContent(value) {
            if (value != undefined) {
                this.resultContent = value;
                this.hmProperty["resultContent"] = true;
            }
        }
        /**
         * 作者(说明:;字段类型:varchar;字段长度:200;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetAuthor(value) {
            if (value != undefined) {
                this.author = value;
                this.hmProperty["author"] = true;
            }
        }
        /**
         * 分工(说明:;字段类型:varchar;字段长度:500;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetDivision(value) {
            if (value != undefined) {
                this.division = value;
                this.hmProperty["division"] = true;
            }
        }
        /**
         * 版本统计(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetVersionCount(value) {
            if (value != undefined) {
                this.versionCount = value;
                this.hmProperty["versionCount"] = true;
            }
        }
        /**
         * 点赞统计(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetOkCount(value) {
            if (value != undefined) {
                this.okCount = value;
                this.hmProperty["okCount"] = true;
            }
        }
        /**
         * 评论数(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetAppraiseCount(value) {
            if (value != undefined) {
                this.appraiseCount = value;
                this.hmProperty["appraiseCount"] = true;
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
         * 学生平均分(说明:;字段类型:float;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetStuScore(value) {
            if (value != undefined) {
                this.stuScore = value;
                this.hmProperty["stuScore"] = true;
            }
        }
        /**
         * 教师评分(说明:;字段类型:float;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetTeaScore(value) {
            if (value != undefined) {
                this.teaScore = value;
                this.hmProperty["teaScore"] = true;
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
                case clsgs_ResearchResultEN.con_ResultId:
                    return this.resultId;
                case clsgs_ResearchResultEN.con_TopicId:
                    return this.topicId;
                case clsgs_ResearchResultEN.con_PaperId:
                    return this.paperId;
                case clsgs_ResearchResultEN.con_ResultTypeId:
                    return this.resultTypeId;
                case clsgs_ResearchResultEN.con_ResultName:
                    return this.resultName;
                case clsgs_ResearchResultEN.con_ResultContent:
                    return this.resultContent;
                case clsgs_ResearchResultEN.con_Author:
                    return this.author;
                case clsgs_ResearchResultEN.con_Division:
                    return this.division;
                case clsgs_ResearchResultEN.con_VersionCount:
                    return this.versionCount;
                case clsgs_ResearchResultEN.con_OkCount:
                    return this.okCount;
                case clsgs_ResearchResultEN.con_AppraiseCount:
                    return this.appraiseCount;
                case clsgs_ResearchResultEN.con_score:
                    return this.score;
                case clsgs_ResearchResultEN.con_StuScore:
                    return this.stuScore;
                case clsgs_ResearchResultEN.con_TeaScore:
                    return this.teaScore;
                case clsgs_ResearchResultEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clsgs_ResearchResultEN.con_UpdDate:
                    return this.updDate;
                case clsgs_ResearchResultEN.con_UpdUser:
                    return this.updUser;
                case clsgs_ResearchResultEN.con_Memo:
                    return this.memo;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[gs_ResearchResult]中不存在！`;
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
                case clsgs_ResearchResultEN.con_ResultId:
                    this.resultId = strValue;
                    this.hmProperty["resultId"] = true;
                    break;
                case clsgs_ResearchResultEN.con_TopicId:
                    this.topicId = strValue;
                    this.hmProperty["topicId"] = true;
                    break;
                case clsgs_ResearchResultEN.con_PaperId:
                    this.paperId = strValue;
                    this.hmProperty["paperId"] = true;
                    break;
                case clsgs_ResearchResultEN.con_ResultTypeId:
                    this.resultTypeId = strValue;
                    this.hmProperty["resultTypeId"] = true;
                    break;
                case clsgs_ResearchResultEN.con_ResultName:
                    this.resultName = strValue;
                    this.hmProperty["resultName"] = true;
                    break;
                case clsgs_ResearchResultEN.con_ResultContent:
                    this.resultContent = strValue;
                    this.hmProperty["resultContent"] = true;
                    break;
                case clsgs_ResearchResultEN.con_Author:
                    this.author = strValue;
                    this.hmProperty["author"] = true;
                    break;
                case clsgs_ResearchResultEN.con_Division:
                    this.division = strValue;
                    this.hmProperty["division"] = true;
                    break;
                case clsgs_ResearchResultEN.con_VersionCount:
                    this.versionCount = Number(strValue);
                    this.hmProperty["versionCount"] = true;
                    break;
                case clsgs_ResearchResultEN.con_OkCount:
                    this.okCount = Number(strValue);
                    this.hmProperty["okCount"] = true;
                    break;
                case clsgs_ResearchResultEN.con_AppraiseCount:
                    this.appraiseCount = Number(strValue);
                    this.hmProperty["appraiseCount"] = true;
                    break;
                case clsgs_ResearchResultEN.con_score:
                    this.score = Number(strValue);
                    this.hmProperty["score"] = true;
                    break;
                case clsgs_ResearchResultEN.con_StuScore:
                    this.stuScore = Number(strValue);
                    this.hmProperty["stuScore"] = true;
                    break;
                case clsgs_ResearchResultEN.con_TeaScore:
                    this.teaScore = Number(strValue);
                    this.hmProperty["teaScore"] = true;
                    break;
                case clsgs_ResearchResultEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    this.hmProperty["id_CurrEduCls"] = true;
                    break;
                case clsgs_ResearchResultEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsgs_ResearchResultEN.con_UpdUser:
                    this.updUser = strValue;
                    this.hmProperty["updUser"] = true;
                    break;
                case clsgs_ResearchResultEN.con_Memo:
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
                    strMsg = `字段名:[${strFldName}]在表对象:[gs_ResearchResult]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"ResultId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ResultId() { return "resultId"; } //成果Id
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
        * 常量:"ResultTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ResultTypeId() { return "resultTypeId"; } //成果类型Id
        /**
        * 常量:"ResultName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ResultName() { return "resultName"; } //成果名称
        /**
        * 常量:"ResultContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ResultContent() { return "resultContent"; } //成果内容
        /**
        * 常量:"Author"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Author() { return "author"; } //作者
        /**
        * 常量:"Division"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Division() { return "division"; } //分工
        /**
        * 常量:"VersionCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_VersionCount() { return "versionCount"; } //版本统计
        /**
        * 常量:"OkCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OkCount() { return "okCount"; } //点赞统计
        /**
        * 常量:"AppraiseCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AppraiseCount() { return "appraiseCount"; } //评论数
        /**
        * 常量:"score"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_score() { return "score"; } //评分
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
        * 常量:"id_CurrEduCls"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_CurrEduCls() { return "id_CurrEduCls"; } //教学班流水号
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
    exports.clsgs_ResearchResultEN = clsgs_ResearchResultEN;
    clsgs_ResearchResultEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsgs_ResearchResultEN.CacheModeId = ""; //
    clsgs_ResearchResultEN._CurrTabName = "gs_ResearchResult"; //当前表名,与该类相关的表名
    clsgs_ResearchResultEN._KeyFldName = "ResultId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsgs_ResearchResultEN.mintAttributeCount = 18;
    clsgs_ResearchResultEN.AttributeName = ["resultId", "topicId", "paperId", "resultTypeId", "resultName", "resultContent", "author", "division", "versionCount", "okCount", "appraiseCount", "score", "stuScore", "teaScore", "id_CurrEduCls", "updDate", "updUser", "memo"];
});
