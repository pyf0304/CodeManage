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
    exports.clsTopicObjectiveEN = void 0;
    /**
    * 类名:clsTopicObjectiveEN
    * 表名:TopicObjective(01120613)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:50:24
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
    * 主题客观表(TopicObjective)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTab_js_1 = require("../../PubFun/clsGeneralTab.js");
    class clsTopicObjectiveEN extends clsGeneralTab_js_1.clsGeneralTab {
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
            this.mstrTopicObjectiveId = ""; //客观Id
            this.mstrObjectiveName = ""; //客观名称
            this.mstrObjectiveContent = ""; //客观内容
            this.mstrObjectiveType = ""; //客观类型
            this.mstrSourceId = ""; //来源Id
            this.mstrConclusion = ""; //结论
            this.mbolIsSubmit = false; //是否提交
            this.mintAppraiseCount = 0; //评论数
            this.mintOkCount = 0; //点赞统计
            this.mfltScore = 0.0; //评分
            this.mfltStuScore = 0.0; //学生平均分
            this.mfltTeaScore = 0.0; //教师评分
            this.mstrid_CurrEduCls = ""; //教学班流水号
            this.mstrPdfContent = ""; //Pdf内容
            this.mintPdfPageNum = 0; //Pdf页码
            this.mintCitationCount = 0; //引用统计
            this.mintVersionCount = 0; //版本统计
            this.mstrCreateDate = ""; //建立日期
            this.mstrShareId = ""; //分享Id
            this.mstrUpdUser = ""; //修改人
            this.mstrUpdDate = ""; //修改日期
            this.mstrMemo = ""; //备注
            /**
             * 设置对象中公共属性.
             * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
            */
            this.topicObjectiveId = ""; //客观Id
            this.objectiveName = ""; //客观名称
            this.objectiveContent = ""; //客观内容
            this.objectiveType = ""; //客观类型
            this.sourceId = ""; //来源Id
            this.conclusion = ""; //结论
            this.isSubmit = false; //是否提交
            this.appraiseCount = 0; //评论数
            this.okCount = 0; //点赞统计
            this.score = 0.0; //评分
            this.stuScore = 0.0; //学生平均分
            this.teaScore = 0.0; //教师评分
            this.id_CurrEduCls = ""; //教学班流水号
            this.pdfContent = ""; //Pdf内容
            this.pdfPageNum = 0; //Pdf页码
            this.citationCount = 0; //引用统计
            this.versionCount = 0; //版本统计
            this.createDate = ""; //建立日期
            this.shareId = ""; //分享Id
            this.updUser = ""; //修改人
            this.updDate = ""; //修改日期
            this.memo = ""; //备注
        }
        /**
         * 客观Id(说明:;字段类型:char;字段长度:8;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetTopicObjectiveId(value) {
            if (value != undefined) {
                this.topicObjectiveId = value;
                this.hmProperty["topicObjectiveId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 客观名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetObjectiveName(value) {
            if (value != undefined) {
                this.objectiveName = value;
                this.hmProperty["objectiveName"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 客观内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetObjectiveContent(value) {
            if (value != undefined) {
                this.objectiveContent = value;
                this.hmProperty["objectiveContent"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 客观类型(说明:;字段类型:char;字段长度:2;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetObjectiveType(value) {
            if (value != undefined) {
                this.objectiveType = value;
                this.hmProperty["objectiveType"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 来源Id(说明:;字段类型:char;字段长度:10;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetSourceId(value) {
            if (value != undefined) {
                this.sourceId = value;
                this.hmProperty["sourceId"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 结论(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetConclusion(value) {
            if (value != undefined) {
                this.conclusion = value;
                this.hmProperty["conclusion"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
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
                this.sf_UpdFldSetStr = this.updFldString;
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
                this.sf_UpdFldSetStr = this.updFldString;
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
         * 学生平均分(说明:;字段类型:float;字段长度:8;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetStuScore(value) {
            if (value != undefined) {
                this.stuScore = value;
                this.hmProperty["stuScore"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
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
         * Pdf内容(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPdfContent(value) {
            if (value != undefined) {
                this.pdfContent = value;
                this.hmProperty["pdfContent"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * Pdf页码(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetPdfPageNum(value) {
            if (value != undefined) {
                this.pdfPageNum = value;
                this.hmProperty["pdfPageNum"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 引用统计(说明:;字段类型:int;字段长度:4;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCitationCount(value) {
            if (value != undefined) {
                this.citationCount = value;
                this.hmProperty["citationCount"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
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
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 建立日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetCreateDate(value) {
            if (value != undefined) {
                this.createDate = value;
                this.hmProperty["createDate"] = true;
                this.sf_UpdFldSetStr = this.updFldString;
            }
        }
        /**
         * 分享Id(说明:;字段类型:char;字段长度:2;是否可空:False)
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        */
        SetShareId(value) {
            if (value != undefined) {
                this.shareId = value;
                this.hmProperty["shareId"] = true;
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
         * 根据字段名获取对象中某字段的值.
         * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_GetFldValue)
         * @param strFldName:字段名
         * @returns 字段值
        */
        GetFldValue(strFldName) {
            const strThisFuncName = "GetFldValue";
            let strMsg = "";
            switch (strFldName) {
                case clsTopicObjectiveEN.con_TopicObjectiveId:
                    return this.topicObjectiveId;
                case clsTopicObjectiveEN.con_ObjectiveName:
                    return this.objectiveName;
                case clsTopicObjectiveEN.con_ObjectiveContent:
                    return this.objectiveContent;
                case clsTopicObjectiveEN.con_ObjectiveType:
                    return this.objectiveType;
                case clsTopicObjectiveEN.con_SourceId:
                    return this.sourceId;
                case clsTopicObjectiveEN.con_Conclusion:
                    return this.conclusion;
                case clsTopicObjectiveEN.con_IsSubmit:
                    return this.isSubmit;
                case clsTopicObjectiveEN.con_AppraiseCount:
                    return this.appraiseCount;
                case clsTopicObjectiveEN.con_OkCount:
                    return this.okCount;
                case clsTopicObjectiveEN.con_Score:
                    return this.score;
                case clsTopicObjectiveEN.con_StuScore:
                    return this.stuScore;
                case clsTopicObjectiveEN.con_TeaScore:
                    return this.teaScore;
                case clsTopicObjectiveEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clsTopicObjectiveEN.con_PdfContent:
                    return this.pdfContent;
                case clsTopicObjectiveEN.con_PdfPageNum:
                    return this.pdfPageNum;
                case clsTopicObjectiveEN.con_CitationCount:
                    return this.citationCount;
                case clsTopicObjectiveEN.con_VersionCount:
                    return this.versionCount;
                case clsTopicObjectiveEN.con_CreateDate:
                    return this.createDate;
                case clsTopicObjectiveEN.con_ShareId:
                    return this.shareId;
                case clsTopicObjectiveEN.con_UpdUser:
                    return this.updUser;
                case clsTopicObjectiveEN.con_UpdDate:
                    return this.updDate;
                case clsTopicObjectiveEN.con_Memo:
                    return this.memo;
                case "sf_UpdFldSetStr":
                    return this.sf_UpdFldSetStr;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[TopicObjective]中不存在！`;
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
                case clsTopicObjectiveEN.con_TopicObjectiveId:
                    this.topicObjectiveId = strValue;
                    this.hmProperty["topicObjectiveId"] = true;
                    break;
                case clsTopicObjectiveEN.con_ObjectiveName:
                    this.objectiveName = strValue;
                    this.hmProperty["objectiveName"] = true;
                    break;
                case clsTopicObjectiveEN.con_ObjectiveContent:
                    this.objectiveContent = strValue;
                    this.hmProperty["objectiveContent"] = true;
                    break;
                case clsTopicObjectiveEN.con_ObjectiveType:
                    this.objectiveType = strValue;
                    this.hmProperty["objectiveType"] = true;
                    break;
                case clsTopicObjectiveEN.con_SourceId:
                    this.sourceId = strValue;
                    this.hmProperty["sourceId"] = true;
                    break;
                case clsTopicObjectiveEN.con_Conclusion:
                    this.conclusion = strValue;
                    this.hmProperty["conclusion"] = true;
                    break;
                case clsTopicObjectiveEN.con_IsSubmit:
                    this.isSubmit = Boolean(strValue);
                    this.hmProperty["isSubmit"] = true;
                    break;
                case clsTopicObjectiveEN.con_AppraiseCount:
                    this.appraiseCount = Number(strValue);
                    this.hmProperty["appraiseCount"] = true;
                    break;
                case clsTopicObjectiveEN.con_OkCount:
                    this.okCount = Number(strValue);
                    this.hmProperty["okCount"] = true;
                    break;
                case clsTopicObjectiveEN.con_Score:
                    this.score = Number(strValue);
                    this.hmProperty["score"] = true;
                    break;
                case clsTopicObjectiveEN.con_StuScore:
                    this.stuScore = Number(strValue);
                    this.hmProperty["stuScore"] = true;
                    break;
                case clsTopicObjectiveEN.con_TeaScore:
                    this.teaScore = Number(strValue);
                    this.hmProperty["teaScore"] = true;
                    break;
                case clsTopicObjectiveEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    this.hmProperty["id_CurrEduCls"] = true;
                    break;
                case clsTopicObjectiveEN.con_PdfContent:
                    this.pdfContent = strValue;
                    this.hmProperty["pdfContent"] = true;
                    break;
                case clsTopicObjectiveEN.con_PdfPageNum:
                    this.pdfPageNum = Number(strValue);
                    this.hmProperty["pdfPageNum"] = true;
                    break;
                case clsTopicObjectiveEN.con_CitationCount:
                    this.citationCount = Number(strValue);
                    this.hmProperty["citationCount"] = true;
                    break;
                case clsTopicObjectiveEN.con_VersionCount:
                    this.versionCount = Number(strValue);
                    this.hmProperty["versionCount"] = true;
                    break;
                case clsTopicObjectiveEN.con_CreateDate:
                    this.createDate = strValue;
                    this.hmProperty["createDate"] = true;
                    break;
                case clsTopicObjectiveEN.con_ShareId:
                    this.shareId = strValue;
                    this.hmProperty["shareId"] = true;
                    break;
                case clsTopicObjectiveEN.con_UpdUser:
                    this.updUser = strValue;
                    this.hmProperty["updUser"] = true;
                    break;
                case clsTopicObjectiveEN.con_UpdDate:
                    this.updDate = strValue;
                    this.hmProperty["updDate"] = true;
                    break;
                case clsTopicObjectiveEN.con_Memo:
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
                    strMsg = `字段名:[${strFldName}]在表对象:[TopicObjective]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"TopicObjectiveId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TopicObjectiveId() { return "topicObjectiveId"; } //客观Id
        /**
        * 常量:"ObjectiveName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ObjectiveName() { return "objectiveName"; } //客观名称
        /**
        * 常量:"ObjectiveContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ObjectiveContent() { return "objectiveContent"; } //客观内容
        /**
        * 常量:"ObjectiveType"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ObjectiveType() { return "objectiveType"; } //客观类型
        /**
        * 常量:"SourceId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SourceId() { return "sourceId"; } //来源Id
        /**
        * 常量:"Conclusion"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Conclusion() { return "conclusion"; } //结论
        /**
        * 常量:"IsSubmit"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsSubmit() { return "isSubmit"; } //是否提交
        /**
        * 常量:"AppraiseCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AppraiseCount() { return "appraiseCount"; } //评论数
        /**
        * 常量:"OkCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OkCount() { return "okCount"; } //点赞统计
        /**
        * 常量:"Score"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Score() { return "score"; } //评分
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
        * 常量:"PdfContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PdfContent() { return "pdfContent"; } //Pdf内容
        /**
        * 常量:"PdfPageNum"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PdfPageNum() { return "pdfPageNum"; } //Pdf页码
        /**
        * 常量:"CitationCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CitationCount() { return "citationCount"; } //引用统计
        /**
        * 常量:"VersionCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_VersionCount() { return "versionCount"; } //版本统计
        /**
        * 常量:"CreateDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CreateDate() { return "createDate"; } //建立日期
        /**
        * 常量:"ShareId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ShareId() { return "shareId"; } //分享Id
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
    exports.clsTopicObjectiveEN = clsTopicObjectiveEN;
    clsTopicObjectiveEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsTopicObjectiveEN.CacheModeId = "04"; //sessionStorage
    clsTopicObjectiveEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsTopicObjectiveEN.WhereFormat = ""; //条件格式串
    clsTopicObjectiveEN._CurrTabName = "TopicObjective"; //当前表名,与该类相关的表名
    clsTopicObjectiveEN._KeyFldName = "TopicObjectiveId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsTopicObjectiveEN.mintAttributeCount = 22;
    clsTopicObjectiveEN.AttributeName = ["topicObjectiveId", "objectiveName", "objectiveContent", "objectiveType", "sourceId", "conclusion", "isSubmit", "appraiseCount", "okCount", "score", "stuScore", "teaScore", "id_CurrEduCls", "pdfContent", "pdfPageNum", "citationCount", "versionCount", "createDate", "shareId", "updUser", "updDate", "memo"];
});
