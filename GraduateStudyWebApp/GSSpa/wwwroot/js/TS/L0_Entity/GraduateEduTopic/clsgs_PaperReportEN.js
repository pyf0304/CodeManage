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
    exports.clsgs_PaperReportEN = void 0;
    /**
    * 类名:clsgs_PaperReportEN
    * 表名:gs_PaperReport(01120772)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 11:47:05
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
    * 论文汇报表(gs_PaperReport)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsgs_PaperReportEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrReportId = ""; //汇报Id
            this.mstrTopicId = ""; //主题Id
            this.mstrPaperId = ""; //论文Id
            this.mstrReportContent = ""; //汇报内容
            this.mbolIsSubmit = false; //是否提交
            this.mstrReportUser = ""; //汇报用户
            this.mstrReportDate = ""; //汇报日期
            this.mintVersionCount = 0; //版本统计
            this.mintOkCount = 0; //点赞统计
            this.mintAppraiseCount = 0; //评论数
            this.mfltscore = 0.0; //评分
            this.mfltStuScore = 0.0; //学生平均分
            this.mfltTeaScore = 0.0; //教师评分
            this.mstrPDFUrl = ""; //PDFUrl
            this.mstrPPTUrl = ""; //PPTUrl
            this.mstrMonth = ""; //月
            this.mintWeek = 0; //周
            this.mstrYear = ""; //年
            this.mstrid_CurrEduCls = ""; //教学班流水号
            this.mstrUpdUser = ""; //修改人
            this.mstrUpdDate = ""; //修改日期
            this.mstrMemo = ""; //备注
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.reportId = ""; //汇报Id
            this.topicId = ""; //主题Id
            this.paperId = ""; //论文Id
            this.reportContent = ""; //汇报内容
            this.isSubmit = false; //是否提交
            this.reportUser = ""; //汇报用户
            this.reportDate = ""; //汇报日期
            this.versionCount = 0; //版本统计
            this.okCount = 0; //点赞统计
            this.appraiseCount = 0; //评论数
            this.score = 0.0; //评分
            this.stuScore = 0.0; //学生平均分
            this.teaScore = 0.0; //教师评分
            this.pdFUrl = ""; //PDFUrl
            this.ppTUrl = ""; //PPTUrl
            this.month = ""; //月
            this.week = 0; //周
            this.year = ""; //年
            this.id_CurrEduCls = ""; //教学班流水号
            this.updUser = ""; //修改人
            this.updDate = ""; //修改日期
            this.memo = ""; //备注
        }
        /**
         * 汇报Id(说明:;字段类型:char;字段长度:10;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetReportId(value) {
            if (value != undefined) {
                this.reportId = value;
                this.hmProperty["reportId"] = true;
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
         * 汇报内容(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetReportContent(value) {
            if (value != undefined) {
                this.reportContent = value;
                this.hmProperty["reportContent"] = true;
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
         * 汇报用户(说明:;字段类型:varchar;字段长度:500;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetReportUser(value) {
            if (value != undefined) {
                this.reportUser = value;
                this.hmProperty["reportUser"] = true;
            }
        }
        /**
         * 汇报日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetReportDate(value) {
            if (value != undefined) {
                this.reportDate = value;
                this.hmProperty["reportDate"] = true;
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
         * PDFUrl(说明:;字段类型:varchar;字段长度:500;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPDFUrl(value) {
            if (value != undefined) {
                this.pdFUrl = value;
                this.hmProperty["pdFUrl"] = true;
            }
        }
        /**
         * PPTUrl(说明:;字段类型:varchar;字段长度:500;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPPTUrl(value) {
            if (value != undefined) {
                this.ppTUrl = value;
                this.hmProperty["ppTUrl"] = true;
            }
        }
        /**
         * 月(说明:;字段类型:char;字段长度:2;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetMonth(value) {
            if (value != undefined) {
                this.month = value;
                this.hmProperty["month"] = true;
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
            }
        }
        /**
         * 年(说明:;字段类型:char;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetYear(value) {
            if (value != undefined) {
                this.year = value;
                this.hmProperty["year"] = true;
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
                case clsgs_PaperReportEN.con_ReportId:
                    return this.reportId;
                case clsgs_PaperReportEN.con_TopicId:
                    return this.topicId;
                case clsgs_PaperReportEN.con_PaperId:
                    return this.paperId;
                case clsgs_PaperReportEN.con_ReportContent:
                    return this.reportContent;
                case clsgs_PaperReportEN.con_IsSubmit:
                    return this.isSubmit;
                case clsgs_PaperReportEN.con_ReportUser:
                    return this.reportUser;
                case clsgs_PaperReportEN.con_ReportDate:
                    return this.reportDate;
                case clsgs_PaperReportEN.con_VersionCount:
                    return this.versionCount;
                case clsgs_PaperReportEN.con_OkCount:
                    return this.okCount;
                case clsgs_PaperReportEN.con_AppraiseCount:
                    return this.appraiseCount;
                case clsgs_PaperReportEN.con_score:
                    return this.score;
                case clsgs_PaperReportEN.con_StuScore:
                    return this.stuScore;
                case clsgs_PaperReportEN.con_TeaScore:
                    return this.teaScore;
                case clsgs_PaperReportEN.con_PDFUrl:
                    return this.pdFUrl;
                case clsgs_PaperReportEN.con_PPTUrl:
                    return this.ppTUrl;
                case clsgs_PaperReportEN.con_Month:
                    return this.month;
                case clsgs_PaperReportEN.con_Week:
                    return this.week;
                case clsgs_PaperReportEN.con_Year:
                    return this.year;
                case clsgs_PaperReportEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clsgs_PaperReportEN.con_UpdUser:
                    return this.updUser;
                case clsgs_PaperReportEN.con_UpdDate:
                    return this.updDate;
                case clsgs_PaperReportEN.con_Memo:
                    return this.memo;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[gs_PaperReport]中不存在！`;
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
                case clsgs_PaperReportEN.con_ReportId:
                    this.reportId = strValue;
                    this.hmProperty["reportId"] = true;
                    break;
                case clsgs_PaperReportEN.con_TopicId:
                    this.topicId = strValue;
                    this.hmProperty["topicId"] = true;
                    break;
                case clsgs_PaperReportEN.con_PaperId:
                    this.paperId = strValue;
                    this.hmProperty["paperId"] = true;
                    break;
                case clsgs_PaperReportEN.con_ReportContent:
                    this.reportContent = strValue;
                    this.hmProperty["reportContent"] = true;
                    break;
                case clsgs_PaperReportEN.con_IsSubmit:
                    this.isSubmit = Boolean(strValue);
                    this.hmProperty["isSubmit"] = true;
                    break;
                case clsgs_PaperReportEN.con_ReportUser:
                    this.reportUser = strValue;
                    this.hmProperty["reportUser"] = true;
                    break;
                case clsgs_PaperReportEN.con_ReportDate:
                    this.reportDate = strValue;
                    this.hmProperty["reportDate"] = true;
                    break;
                case clsgs_PaperReportEN.con_VersionCount:
                    this.versionCount = Number(strValue);
                    this.hmProperty["versionCount"] = true;
                    break;
                case clsgs_PaperReportEN.con_OkCount:
                    this.okCount = Number(strValue);
                    this.hmProperty["okCount"] = true;
                    break;
                case clsgs_PaperReportEN.con_AppraiseCount:
                    this.appraiseCount = Number(strValue);
                    this.hmProperty["appraiseCount"] = true;
                    break;
                case clsgs_PaperReportEN.con_score:
                    this.score = Number(strValue);
                    this.hmProperty["score"] = true;
                    break;
                case clsgs_PaperReportEN.con_StuScore:
                    this.stuScore = Number(strValue);
                    this.hmProperty["stuScore"] = true;
                    break;
                case clsgs_PaperReportEN.con_TeaScore:
                    this.teaScore = Number(strValue);
                    this.hmProperty["teaScore"] = true;
                    break;
                case clsgs_PaperReportEN.con_PDFUrl:
                    this.pdFUrl = strValue;
                    this.hmProperty["pdFUrl"] = true;
                    break;
                case clsgs_PaperReportEN.con_PPTUrl:
                    this.ppTUrl = strValue;
                    this.hmProperty["ppTUrl"] = true;
                    break;
                case clsgs_PaperReportEN.con_Month:
                    this.month = strValue;
                    this.hmProperty["month"] = true;
                    break;
                case clsgs_PaperReportEN.con_Week:
                    this.week = Number(strValue);
                    this.hmProperty["week"] = true;
                    break;
                case clsgs_PaperReportEN.con_Year:
                    this.year = strValue;
                    this.hmProperty["year"] = true;
                    break;
                case clsgs_PaperReportEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    this.hmProperty["id_CurrEduCls"] = true;
                    break;
                case clsgs_PaperReportEN.con_UpdUser:
                    this.updUser = strValue;
                    this.hmProperty["updUser"] = true;
                    break;
                case clsgs_PaperReportEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsgs_PaperReportEN.con_Memo:
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
                    strMsg = `字段名:[${strFldName}]在表对象:[gs_PaperReport]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"ReportId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ReportId() { return "reportId"; } //汇报Id
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
        * 常量:"ReportContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ReportContent() { return "reportContent"; } //汇报内容
        /**
        * 常量:"IsSubmit"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsSubmit() { return "isSubmit"; } //是否提交
        /**
        * 常量:"ReportUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ReportUser() { return "reportUser"; } //汇报用户
        /**
        * 常量:"ReportDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ReportDate() { return "reportDate"; } //汇报日期
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
        * 常量:"PDFUrl"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PDFUrl() { return "pdFUrl"; } //PDFUrl
        /**
        * 常量:"PPTUrl"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PPTUrl() { return "ppTUrl"; } //PPTUrl
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
        * 常量:"Year"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Year() { return "year"; } //年
        /**
        * 常量:"id_CurrEduCls"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_CurrEduCls() { return "id_CurrEduCls"; } //教学班流水号
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
    exports.clsgs_PaperReportEN = clsgs_PaperReportEN;
    clsgs_PaperReportEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsgs_PaperReportEN.CacheModeId = "02"; //客户端缓存
    clsgs_PaperReportEN._CurrTabName = "gs_PaperReport"; //当前表名,与该类相关的表名
    clsgs_PaperReportEN._KeyFldName = "ReportId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsgs_PaperReportEN.mintAttributeCount = 22;
    clsgs_PaperReportEN.AttributeName = ["reportId", "topicId", "paperId", "reportContent", "isSubmit", "reportUser", "reportDate", "versionCount", "okCount", "appraiseCount", "score", "stuScore", "teaScore", "pdFUrl", "ppTUrl", "month", "week", "year", "id_CurrEduCls", "updUser", "updDate", "memo"];
});
