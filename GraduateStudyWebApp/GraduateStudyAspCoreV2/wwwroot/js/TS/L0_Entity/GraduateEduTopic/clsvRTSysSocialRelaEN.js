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
    exports.clsvRTSysSocialRelaEN = void 0;
    /**
    * 类名:clsvRTSysSocialRelaEN
    * 表名:vRTSysSocialRela(01120655)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:47:09
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
    * vRTSysSocialRela(vRTSysSocialRela)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvRTSysSocialRelaEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.mId = 0; //mId
            this.topicId = ""; //主题Id
            this.topicName = ""; //栏目主题
            this.topicContent = ""; //主题内容
            this.topicProposePeople = ""; //主题提出人
            this.orderNum = 0; //序号
            this.id_CurrEduCls = ""; //教学班流水号
            this.socialId = ""; //社会Id
            this.fullName = ""; //姓名
            this.nationality = ""; //国籍
            this.workUnit = ""; //工作单位
            this.major = ""; //专业
            this.achievement = ""; //成就
            this.detailedDescription = ""; //详细说明
            this.levelId = ""; //级别Id
            this.levelName = ""; //级别名称
            this.socialUpdUser = ""; //SocialUpdUser
            this.socialUpdDate = ""; //SocialUpdDate
            this.isSubmit = false; //是否提交
            this.okCount = 0; //点赞统计
            this.citationCount = 0; //引用统计
            this.versionCount = 0; //版本统计
            this.updDate = ""; //修改日期
            this.updUser = ""; //修改人
            this.memo = ""; //备注
            this.appraiseCount = 0; //评论数
            this.score = 0.0; //评分
            this.stuScore = 0.0; //学生平均分
            this.teaScore = 0.0; //教师评分
            this.createDate = ""; //建立日期
            this.shareId = ""; //分享Id
            this.pdfContent = ""; //Pdf内容
            this.pdfPageNum = 0; //Pdf页码
            this.citationId = ""; //引用Id
            this.classificationId = ""; //分类Id
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
                case clsvRTSysSocialRelaEN.con_mId:
                    return this.mId;
                case clsvRTSysSocialRelaEN.con_TopicId:
                    return this.topicId;
                case clsvRTSysSocialRelaEN.con_TopicName:
                    return this.topicName;
                case clsvRTSysSocialRelaEN.con_TopicContent:
                    return this.topicContent;
                case clsvRTSysSocialRelaEN.con_TopicProposePeople:
                    return this.topicProposePeople;
                case clsvRTSysSocialRelaEN.con_OrderNum:
                    return this.orderNum;
                case clsvRTSysSocialRelaEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clsvRTSysSocialRelaEN.con_SocialId:
                    return this.socialId;
                case clsvRTSysSocialRelaEN.con_FullName:
                    return this.fullName;
                case clsvRTSysSocialRelaEN.con_Nationality:
                    return this.nationality;
                case clsvRTSysSocialRelaEN.con_WorkUnit:
                    return this.workUnit;
                case clsvRTSysSocialRelaEN.con_Major:
                    return this.major;
                case clsvRTSysSocialRelaEN.con_Achievement:
                    return this.achievement;
                case clsvRTSysSocialRelaEN.con_DetailedDescription:
                    return this.detailedDescription;
                case clsvRTSysSocialRelaEN.con_LevelId:
                    return this.levelId;
                case clsvRTSysSocialRelaEN.con_LevelName:
                    return this.levelName;
                case clsvRTSysSocialRelaEN.con_SocialUpdUser:
                    return this.socialUpdUser;
                case clsvRTSysSocialRelaEN.con_SocialUpdDate:
                    return this.socialUpdDate;
                case clsvRTSysSocialRelaEN.con_IsSubmit:
                    return this.isSubmit;
                case clsvRTSysSocialRelaEN.con_OkCount:
                    return this.okCount;
                case clsvRTSysSocialRelaEN.con_CitationCount:
                    return this.citationCount;
                case clsvRTSysSocialRelaEN.con_VersionCount:
                    return this.versionCount;
                case clsvRTSysSocialRelaEN.con_UpdDate:
                    return this.updDate;
                case clsvRTSysSocialRelaEN.con_UpdUser:
                    return this.updUser;
                case clsvRTSysSocialRelaEN.con_Memo:
                    return this.memo;
                case clsvRTSysSocialRelaEN.con_AppraiseCount:
                    return this.appraiseCount;
                case clsvRTSysSocialRelaEN.con_Score:
                    return this.score;
                case clsvRTSysSocialRelaEN.con_StuScore:
                    return this.stuScore;
                case clsvRTSysSocialRelaEN.con_TeaScore:
                    return this.teaScore;
                case clsvRTSysSocialRelaEN.con_CreateDate:
                    return this.createDate;
                case clsvRTSysSocialRelaEN.con_ShareId:
                    return this.shareId;
                case clsvRTSysSocialRelaEN.con_PdfContent:
                    return this.pdfContent;
                case clsvRTSysSocialRelaEN.con_PdfPageNum:
                    return this.pdfPageNum;
                case clsvRTSysSocialRelaEN.con_CitationId:
                    return this.citationId;
                case clsvRTSysSocialRelaEN.con_ClassificationId:
                    return this.classificationId;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vRTSysSocialRela]中不存在！`;
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
                case clsvRTSysSocialRelaEN.con_mId:
                    this.mId = Number(strValue);
                    break;
                case clsvRTSysSocialRelaEN.con_TopicId:
                    this.topicId = strValue;
                    break;
                case clsvRTSysSocialRelaEN.con_TopicName:
                    this.topicName = strValue;
                    break;
                case clsvRTSysSocialRelaEN.con_TopicContent:
                    this.topicContent = strValue;
                    break;
                case clsvRTSysSocialRelaEN.con_TopicProposePeople:
                    this.topicProposePeople = strValue;
                    break;
                case clsvRTSysSocialRelaEN.con_OrderNum:
                    this.orderNum = Number(strValue);
                    break;
                case clsvRTSysSocialRelaEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    break;
                case clsvRTSysSocialRelaEN.con_SocialId:
                    this.socialId = strValue;
                    break;
                case clsvRTSysSocialRelaEN.con_FullName:
                    this.fullName = strValue;
                    break;
                case clsvRTSysSocialRelaEN.con_Nationality:
                    this.nationality = strValue;
                    break;
                case clsvRTSysSocialRelaEN.con_WorkUnit:
                    this.workUnit = strValue;
                    break;
                case clsvRTSysSocialRelaEN.con_Major:
                    this.major = strValue;
                    break;
                case clsvRTSysSocialRelaEN.con_Achievement:
                    this.achievement = strValue;
                    break;
                case clsvRTSysSocialRelaEN.con_DetailedDescription:
                    this.detailedDescription = strValue;
                    break;
                case clsvRTSysSocialRelaEN.con_LevelId:
                    this.levelId = strValue;
                    break;
                case clsvRTSysSocialRelaEN.con_LevelName:
                    this.levelName = strValue;
                    break;
                case clsvRTSysSocialRelaEN.con_SocialUpdUser:
                    this.socialUpdUser = strValue;
                    break;
                case clsvRTSysSocialRelaEN.con_SocialUpdDate:
                    this.socialUpdDate = strValue;
                    break;
                case clsvRTSysSocialRelaEN.con_IsSubmit:
                    this.isSubmit = Boolean(strValue);
                    break;
                case clsvRTSysSocialRelaEN.con_OkCount:
                    this.okCount = Number(strValue);
                    break;
                case clsvRTSysSocialRelaEN.con_CitationCount:
                    this.citationCount = Number(strValue);
                    break;
                case clsvRTSysSocialRelaEN.con_VersionCount:
                    this.versionCount = Number(strValue);
                    break;
                case clsvRTSysSocialRelaEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvRTSysSocialRelaEN.con_UpdUser:
                    this.updUser = strValue;
                    break;
                case clsvRTSysSocialRelaEN.con_Memo:
                    this.memo = strValue;
                    break;
                case clsvRTSysSocialRelaEN.con_AppraiseCount:
                    this.appraiseCount = Number(strValue);
                    break;
                case clsvRTSysSocialRelaEN.con_Score:
                    this.score = Number(strValue);
                    break;
                case clsvRTSysSocialRelaEN.con_StuScore:
                    this.stuScore = Number(strValue);
                    break;
                case clsvRTSysSocialRelaEN.con_TeaScore:
                    this.teaScore = Number(strValue);
                    break;
                case clsvRTSysSocialRelaEN.con_CreateDate:
                    this.createDate = strValue;
                    break;
                case clsvRTSysSocialRelaEN.con_ShareId:
                    this.shareId = strValue;
                    break;
                case clsvRTSysSocialRelaEN.con_PdfContent:
                    this.pdfContent = strValue;
                    break;
                case clsvRTSysSocialRelaEN.con_PdfPageNum:
                    this.pdfPageNum = Number(strValue);
                    break;
                case clsvRTSysSocialRelaEN.con_CitationId:
                    this.citationId = strValue;
                    break;
                case clsvRTSysSocialRelaEN.con_ClassificationId:
                    this.classificationId = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vRTSysSocialRela]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"mId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_mId() { return "mId"; } //mId
        /**
        * 常量:"TopicId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TopicId() { return "topicId"; } //主题Id
        /**
        * 常量:"TopicName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TopicName() { return "topicName"; } //栏目主题
        /**
        * 常量:"TopicContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TopicContent() { return "topicContent"; } //主题内容
        /**
        * 常量:"TopicProposePeople"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TopicProposePeople() { return "topicProposePeople"; } //主题提出人
        /**
        * 常量:"OrderNum"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OrderNum() { return "orderNum"; } //序号
        /**
        * 常量:"id_CurrEduCls"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_CurrEduCls() { return "id_CurrEduCls"; } //教学班流水号
        /**
        * 常量:"SocialId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SocialId() { return "socialId"; } //社会Id
        /**
        * 常量:"FullName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_FullName() { return "fullName"; } //姓名
        /**
        * 常量:"Nationality"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Nationality() { return "nationality"; } //国籍
        /**
        * 常量:"WorkUnit"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_WorkUnit() { return "workUnit"; } //工作单位
        /**
        * 常量:"Major"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Major() { return "major"; } //专业
        /**
        * 常量:"Achievement"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Achievement() { return "achievement"; } //成就
        /**
        * 常量:"DetailedDescription"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_DetailedDescription() { return "detailedDescription"; } //详细说明
        /**
        * 常量:"LevelId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_LevelId() { return "levelId"; } //级别Id
        /**
        * 常量:"LevelName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_LevelName() { return "levelName"; } //级别名称
        /**
        * 常量:"SocialUpdUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SocialUpdUser() { return "socialUpdUser"; } //SocialUpdUser
        /**
        * 常量:"SocialUpdDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SocialUpdDate() { return "socialUpdDate"; } //SocialUpdDate
        /**
        * 常量:"IsSubmit"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsSubmit() { return "isSubmit"; } //是否提交
        /**
        * 常量:"OkCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OkCount() { return "okCount"; } //点赞统计
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
        * 常量:"AppraiseCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_AppraiseCount() { return "appraiseCount"; } //评论数
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
        * 常量:"CitationId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CitationId() { return "citationId"; } //引用Id
        /**
        * 常量:"ClassificationId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ClassificationId() { return "classificationId"; } //分类Id
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
    exports.clsvRTSysSocialRelaEN = clsvRTSysSocialRelaEN;
    clsvRTSysSocialRelaEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvRTSysSocialRelaEN.CacheModeId = "02"; //客户端缓存
    clsvRTSysSocialRelaEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsvRTSysSocialRelaEN.WhereFormat = ""; //条件格式串
    clsvRTSysSocialRelaEN._CurrTabName = "vRTSysSocialRela"; //当前表名,与该类相关的表名
    clsvRTSysSocialRelaEN._KeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvRTSysSocialRelaEN.mintAttributeCount = 35;
    clsvRTSysSocialRelaEN.AttributeName = ["mId", "topicId", "topicName", "topicContent", "topicProposePeople", "orderNum", "id_CurrEduCls", "socialId", "fullName", "nationality", "workUnit", "major", "achievement", "detailedDescription", "levelId", "levelName", "socialUpdUser", "socialUpdDate", "isSubmit", "okCount", "citationCount", "versionCount", "updDate", "updUser", "memo", "appraiseCount", "score", "stuScore", "teaScore", "createDate", "shareId", "pdfContent", "pdfPageNum", "citationId", "classificationId"];
});
