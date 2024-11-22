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
    exports.clsvRTViewpointRelaEN = void 0;
    /**
    * 类名:clsvRTViewpointRelaEN
    * 表名:vRTViewpointRela(01120541)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 12:02:44
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
    * v主题观点关系(vRTViewpointRela)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvRTViewpointRelaEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.viewpointName = ""; //观点名称
            this.viewpointContent = ""; //观点内容
            this.viewpointId = ""; //观点Id
            this.proposePeople = ""; //提出人
            this.viewpointTypeId = ""; //观点类型Id
            this.viewpointTypeName = ""; //观点类型名
            this.reason = ""; //理由
            this.source = ""; //来源
            this.topicId = ""; //主题Id
            this.topicName = ""; //栏目主题
            this.topicContent = ""; //主题内容
            this.topicProposePeople = ""; //主题提出人
            this.updDate = ""; //修改日期
            this.updUser = ""; //修改人
            this.memo = ""; //备注
            this.isSubmit = false; //是否提交
            this.appraiseCount = 0; //评论数
            this.okCount = 0; //点赞统计
            this.score = 0.0; //评分
            this.userTypeId = ""; //用户类型Id
            this.userTypeName = ""; //用户类型名称
            this.citationCount = 0; //引用统计
            this.citationId = ""; //引用Id
            this.stuScore = 0.0; //学生平均分
            this.teaScore = 0.0; //教师评分
            this.viewsDate = ""; //ViewsDate
            this.viewsUserId = ""; //ViewsUserId
            this.id_CurrEduCls = ""; //教学班流水号
            this.pdfContent = ""; //Pdf内容
            this.pdfPageNum = 0; //Pdf页码
            this.versionCount = 0; //版本统计
            this.createDate = ""; //建立日期
            this.shareId = ""; //分享Id
            this.isRecommend = false; //是否推荐
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
                case clsvRTViewpointRelaEN.con_mId:
                    return this.mId;
                case clsvRTViewpointRelaEN.con_ViewpointName:
                    return this.viewpointName;
                case clsvRTViewpointRelaEN.con_ViewpointContent:
                    return this.viewpointContent;
                case clsvRTViewpointRelaEN.con_ViewpointId:
                    return this.viewpointId;
                case clsvRTViewpointRelaEN.con_ProposePeople:
                    return this.proposePeople;
                case clsvRTViewpointRelaEN.con_ViewpointTypeId:
                    return this.viewpointTypeId;
                case clsvRTViewpointRelaEN.con_ViewpointTypeName:
                    return this.viewpointTypeName;
                case clsvRTViewpointRelaEN.con_Reason:
                    return this.reason;
                case clsvRTViewpointRelaEN.con_Source:
                    return this.source;
                case clsvRTViewpointRelaEN.con_TopicId:
                    return this.topicId;
                case clsvRTViewpointRelaEN.con_TopicName:
                    return this.topicName;
                case clsvRTViewpointRelaEN.con_TopicContent:
                    return this.topicContent;
                case clsvRTViewpointRelaEN.con_TopicProposePeople:
                    return this.topicProposePeople;
                case clsvRTViewpointRelaEN.con_UpdDate:
                    return this.updDate;
                case clsvRTViewpointRelaEN.con_UpdUser:
                    return this.updUser;
                case clsvRTViewpointRelaEN.con_Memo:
                    return this.memo;
                case clsvRTViewpointRelaEN.con_IsSubmit:
                    return this.isSubmit;
                case clsvRTViewpointRelaEN.con_AppraiseCount:
                    return this.appraiseCount;
                case clsvRTViewpointRelaEN.con_OkCount:
                    return this.okCount;
                case clsvRTViewpointRelaEN.con_score:
                    return this.score;
                case clsvRTViewpointRelaEN.con_UserTypeId:
                    return this.userTypeId;
                case clsvRTViewpointRelaEN.con_UserTypeName:
                    return this.userTypeName;
                case clsvRTViewpointRelaEN.con_CitationCount:
                    return this.citationCount;
                case clsvRTViewpointRelaEN.con_CitationId:
                    return this.citationId;
                case clsvRTViewpointRelaEN.con_StuScore:
                    return this.stuScore;
                case clsvRTViewpointRelaEN.con_TeaScore:
                    return this.teaScore;
                case clsvRTViewpointRelaEN.con_ViewsDate:
                    return this.viewsDate;
                case clsvRTViewpointRelaEN.con_ViewsUserId:
                    return this.viewsUserId;
                case clsvRTViewpointRelaEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clsvRTViewpointRelaEN.con_PdfContent:
                    return this.pdfContent;
                case clsvRTViewpointRelaEN.con_PdfPageNum:
                    return this.pdfPageNum;
                case clsvRTViewpointRelaEN.con_VersionCount:
                    return this.versionCount;
                case clsvRTViewpointRelaEN.con_CreateDate:
                    return this.createDate;
                case clsvRTViewpointRelaEN.con_ShareId:
                    return this.shareId;
                case clsvRTViewpointRelaEN.con_IsRecommend:
                    return this.isRecommend;
                case clsvRTViewpointRelaEN.con_ClassificationId:
                    return this.classificationId;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vRTViewpointRela]中不存在！`;
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
                case clsvRTViewpointRelaEN.con_mId:
                    this.mId = Number(strValue);
                    break;
                case clsvRTViewpointRelaEN.con_ViewpointName:
                    this.viewpointName = strValue;
                    break;
                case clsvRTViewpointRelaEN.con_ViewpointContent:
                    this.viewpointContent = strValue;
                    break;
                case clsvRTViewpointRelaEN.con_ViewpointId:
                    this.viewpointId = strValue;
                    break;
                case clsvRTViewpointRelaEN.con_ProposePeople:
                    this.proposePeople = strValue;
                    break;
                case clsvRTViewpointRelaEN.con_ViewpointTypeId:
                    this.viewpointTypeId = strValue;
                    break;
                case clsvRTViewpointRelaEN.con_ViewpointTypeName:
                    this.viewpointTypeName = strValue;
                    break;
                case clsvRTViewpointRelaEN.con_Reason:
                    this.reason = strValue;
                    break;
                case clsvRTViewpointRelaEN.con_Source:
                    this.source = strValue;
                    break;
                case clsvRTViewpointRelaEN.con_TopicId:
                    this.topicId = strValue;
                    break;
                case clsvRTViewpointRelaEN.con_TopicName:
                    this.topicName = strValue;
                    break;
                case clsvRTViewpointRelaEN.con_TopicContent:
                    this.topicContent = strValue;
                    break;
                case clsvRTViewpointRelaEN.con_TopicProposePeople:
                    this.topicProposePeople = strValue;
                    break;
                case clsvRTViewpointRelaEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvRTViewpointRelaEN.con_UpdUser:
                    this.updUser = strValue;
                    break;
                case clsvRTViewpointRelaEN.con_Memo:
                    this.memo = strValue;
                    break;
                case clsvRTViewpointRelaEN.con_IsSubmit:
                    this.isSubmit = Boolean(strValue);
                    break;
                case clsvRTViewpointRelaEN.con_AppraiseCount:
                    this.appraiseCount = Number(strValue);
                    break;
                case clsvRTViewpointRelaEN.con_OkCount:
                    this.okCount = Number(strValue);
                    break;
                case clsvRTViewpointRelaEN.con_score:
                    this.score = Number(strValue);
                    break;
                case clsvRTViewpointRelaEN.con_UserTypeId:
                    this.userTypeId = strValue;
                    break;
                case clsvRTViewpointRelaEN.con_UserTypeName:
                    this.userTypeName = strValue;
                    break;
                case clsvRTViewpointRelaEN.con_CitationCount:
                    this.citationCount = Number(strValue);
                    break;
                case clsvRTViewpointRelaEN.con_CitationId:
                    this.citationId = strValue;
                    break;
                case clsvRTViewpointRelaEN.con_StuScore:
                    this.stuScore = Number(strValue);
                    break;
                case clsvRTViewpointRelaEN.con_TeaScore:
                    this.teaScore = Number(strValue);
                    break;
                case clsvRTViewpointRelaEN.con_ViewsDate:
                    this.viewsDate = strValue;
                    break;
                case clsvRTViewpointRelaEN.con_ViewsUserId:
                    this.viewsUserId = strValue;
                    break;
                case clsvRTViewpointRelaEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    break;
                case clsvRTViewpointRelaEN.con_PdfContent:
                    this.pdfContent = strValue;
                    break;
                case clsvRTViewpointRelaEN.con_PdfPageNum:
                    this.pdfPageNum = Number(strValue);
                    break;
                case clsvRTViewpointRelaEN.con_VersionCount:
                    this.versionCount = Number(strValue);
                    break;
                case clsvRTViewpointRelaEN.con_CreateDate:
                    this.createDate = strValue;
                    break;
                case clsvRTViewpointRelaEN.con_ShareId:
                    this.shareId = strValue;
                    break;
                case clsvRTViewpointRelaEN.con_IsRecommend:
                    this.isRecommend = Boolean(strValue);
                    break;
                case clsvRTViewpointRelaEN.con_ClassificationId:
                    this.classificationId = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vRTViewpointRela]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
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
        * 常量:"ViewpointName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ViewpointName() { return "viewpointName"; } //观点名称
        /**
        * 常量:"ViewpointContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ViewpointContent() { return "viewpointContent"; } //观点内容
        /**
        * 常量:"ViewpointId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ViewpointId() { return "viewpointId"; } //观点Id
        /**
        * 常量:"ProposePeople"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ProposePeople() { return "proposePeople"; } //提出人
        /**
        * 常量:"ViewpointTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ViewpointTypeId() { return "viewpointTypeId"; } //观点类型Id
        /**
        * 常量:"ViewpointTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ViewpointTypeName() { return "viewpointTypeName"; } //观点类型名
        /**
        * 常量:"Reason"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Reason() { return "reason"; } //理由
        /**
        * 常量:"Source"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Source() { return "source"; } //来源
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
        * 常量:"score"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_score() { return "score"; } //评分
        /**
        * 常量:"UserTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserTypeId() { return "userTypeId"; } //用户类型Id
        /**
        * 常量:"UserTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UserTypeName() { return "userTypeName"; } //用户类型名称
        /**
        * 常量:"CitationCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CitationCount() { return "citationCount"; } //引用统计
        /**
        * 常量:"CitationId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CitationId() { return "citationId"; } //引用Id
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
        * 常量:"ViewsDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ViewsDate() { return "viewsDate"; } //ViewsDate
        /**
        * 常量:"ViewsUserId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ViewsUserId() { return "viewsUserId"; } //ViewsUserId
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
        * 常量:"IsRecommend"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsRecommend() { return "isRecommend"; } //是否推荐
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
    exports.clsvRTViewpointRelaEN = clsvRTViewpointRelaEN;
    clsvRTViewpointRelaEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvRTViewpointRelaEN.CacheModeId = "05"; //未知
    clsvRTViewpointRelaEN._CurrTabName = "vRTViewpointRela"; //当前表名,与该类相关的表名
    clsvRTViewpointRelaEN._KeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvRTViewpointRelaEN.mintAttributeCount = 36;
    clsvRTViewpointRelaEN.AttributeName = ["mId", "viewpointName", "viewpointContent", "viewpointId", "proposePeople", "viewpointTypeId", "viewpointTypeName", "reason", "source", "topicId", "topicName", "topicContent", "topicProposePeople", "updDate", "updUser", "memo", "isSubmit", "appraiseCount", "okCount", "score", "userTypeId", "userTypeName", "citationCount", "citationId", "stuScore", "teaScore", "viewsDate", "viewsUserId", "id_CurrEduCls", "pdfContent", "pdfPageNum", "versionCount", "createDate", "shareId", "isRecommend", "classificationId"];
});