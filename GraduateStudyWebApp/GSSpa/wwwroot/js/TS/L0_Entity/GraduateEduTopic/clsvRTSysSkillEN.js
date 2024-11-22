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
    exports.clsvRTSysSkillEN = void 0;
    /**
    * 类名:clsvRTSysSkillEN
    * 表名:vRTSysSkill(01120656)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 12:02:54
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
    * vRTSysSkill(vRTSysSkill)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvRTSysSkillEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.topicName = ""; //栏目主题
            this.skillName = ""; //技能名称
            this.operationTypeId = ""; //操作类型ID
            this.process = ""; //实施过程
            this.levelId = ""; //级别Id
            this.levelName = ""; //级别名称
            this.skillUpdUser = ""; //SkillUpdUser
            this.skillUpdDate = ""; //SkillUpdDate
            this.orderNum = 0; //序号
            this.id_CurrEduCls = ""; //教学班流水号
            this.topicProposePeople = ""; //主题提出人
            this.topicContent = ""; //主题内容
            this.isSubmit = false; //是否提交
            this.appraiseCount = 0; //评论数
            this.score = 0.0; //评分
            this.stuScore = 0.0; //学生平均分
            this.teaScore = 0.0; //教师评分
            this.pdfContent = ""; //Pdf内容
            this.pdfPageNum = 0; //Pdf页码
            this.citationCount = 0; //引用统计
            this.versionCount = 0; //版本统计
            this.operationTypeName = ""; //操作类型名
            this.okCount = 0; //点赞统计
            this.citationId = ""; //引用Id
            this.mId = 0; //mId
            this.topicId = ""; //主题Id
            this.skillId = ""; //技能Id
            this.updDate = ""; //修改日期
            this.memo = ""; //备注
            this.updUser = ""; //修改人
            this.createDate = ""; //建立日期
            this.shareId = ""; //分享Id
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
                case clsvRTSysSkillEN.con_TopicName:
                    return this.topicName;
                case clsvRTSysSkillEN.con_SkillName:
                    return this.skillName;
                case clsvRTSysSkillEN.con_OperationTypeId:
                    return this.operationTypeId;
                case clsvRTSysSkillEN.con_Process:
                    return this.process;
                case clsvRTSysSkillEN.con_LevelId:
                    return this.levelId;
                case clsvRTSysSkillEN.con_LevelName:
                    return this.levelName;
                case clsvRTSysSkillEN.con_SkillUpdUser:
                    return this.skillUpdUser;
                case clsvRTSysSkillEN.con_SkillUpdDate:
                    return this.skillUpdDate;
                case clsvRTSysSkillEN.con_OrderNum:
                    return this.orderNum;
                case clsvRTSysSkillEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clsvRTSysSkillEN.con_TopicProposePeople:
                    return this.topicProposePeople;
                case clsvRTSysSkillEN.con_TopicContent:
                    return this.topicContent;
                case clsvRTSysSkillEN.con_IsSubmit:
                    return this.isSubmit;
                case clsvRTSysSkillEN.con_AppraiseCount:
                    return this.appraiseCount;
                case clsvRTSysSkillEN.con_score:
                    return this.score;
                case clsvRTSysSkillEN.con_StuScore:
                    return this.stuScore;
                case clsvRTSysSkillEN.con_TeaScore:
                    return this.teaScore;
                case clsvRTSysSkillEN.con_PdfContent:
                    return this.pdfContent;
                case clsvRTSysSkillEN.con_PdfPageNum:
                    return this.pdfPageNum;
                case clsvRTSysSkillEN.con_CitationCount:
                    return this.citationCount;
                case clsvRTSysSkillEN.con_VersionCount:
                    return this.versionCount;
                case clsvRTSysSkillEN.con_OperationTypeName:
                    return this.operationTypeName;
                case clsvRTSysSkillEN.con_OkCount:
                    return this.okCount;
                case clsvRTSysSkillEN.con_CitationId:
                    return this.citationId;
                case clsvRTSysSkillEN.con_mId:
                    return this.mId;
                case clsvRTSysSkillEN.con_TopicId:
                    return this.topicId;
                case clsvRTSysSkillEN.con_SkillId:
                    return this.skillId;
                case clsvRTSysSkillEN.con_UpdDate:
                    return this.updDate;
                case clsvRTSysSkillEN.con_Memo:
                    return this.memo;
                case clsvRTSysSkillEN.con_UpdUser:
                    return this.updUser;
                case clsvRTSysSkillEN.con_CreateDate:
                    return this.createDate;
                case clsvRTSysSkillEN.con_ShareId:
                    return this.shareId;
                case clsvRTSysSkillEN.con_ClassificationId:
                    return this.classificationId;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vRTSysSkill]中不存在！`;
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
                case clsvRTSysSkillEN.con_TopicName:
                    this.topicName = strValue;
                    break;
                case clsvRTSysSkillEN.con_SkillName:
                    this.skillName = strValue;
                    break;
                case clsvRTSysSkillEN.con_OperationTypeId:
                    this.operationTypeId = strValue;
                    break;
                case clsvRTSysSkillEN.con_Process:
                    this.process = strValue;
                    break;
                case clsvRTSysSkillEN.con_LevelId:
                    this.levelId = strValue;
                    break;
                case clsvRTSysSkillEN.con_LevelName:
                    this.levelName = strValue;
                    break;
                case clsvRTSysSkillEN.con_SkillUpdUser:
                    this.skillUpdUser = strValue;
                    break;
                case clsvRTSysSkillEN.con_SkillUpdDate:
                    this.skillUpdDate = strValue;
                    break;
                case clsvRTSysSkillEN.con_OrderNum:
                    this.orderNum = Number(strValue);
                    break;
                case clsvRTSysSkillEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    break;
                case clsvRTSysSkillEN.con_TopicProposePeople:
                    this.topicProposePeople = strValue;
                    break;
                case clsvRTSysSkillEN.con_TopicContent:
                    this.topicContent = strValue;
                    break;
                case clsvRTSysSkillEN.con_IsSubmit:
                    this.isSubmit = Boolean(strValue);
                    break;
                case clsvRTSysSkillEN.con_AppraiseCount:
                    this.appraiseCount = Number(strValue);
                    break;
                case clsvRTSysSkillEN.con_score:
                    this.score = Number(strValue);
                    break;
                case clsvRTSysSkillEN.con_StuScore:
                    this.stuScore = Number(strValue);
                    break;
                case clsvRTSysSkillEN.con_TeaScore:
                    this.teaScore = Number(strValue);
                    break;
                case clsvRTSysSkillEN.con_PdfContent:
                    this.pdfContent = strValue;
                    break;
                case clsvRTSysSkillEN.con_PdfPageNum:
                    this.pdfPageNum = Number(strValue);
                    break;
                case clsvRTSysSkillEN.con_CitationCount:
                    this.citationCount = Number(strValue);
                    break;
                case clsvRTSysSkillEN.con_VersionCount:
                    this.versionCount = Number(strValue);
                    break;
                case clsvRTSysSkillEN.con_OperationTypeName:
                    this.operationTypeName = strValue;
                    break;
                case clsvRTSysSkillEN.con_OkCount:
                    this.okCount = Number(strValue);
                    break;
                case clsvRTSysSkillEN.con_CitationId:
                    this.citationId = strValue;
                    break;
                case clsvRTSysSkillEN.con_mId:
                    this.mId = Number(strValue);
                    break;
                case clsvRTSysSkillEN.con_TopicId:
                    this.topicId = strValue;
                    break;
                case clsvRTSysSkillEN.con_SkillId:
                    this.skillId = strValue;
                    break;
                case clsvRTSysSkillEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvRTSysSkillEN.con_Memo:
                    this.memo = strValue;
                    break;
                case clsvRTSysSkillEN.con_UpdUser:
                    this.updUser = strValue;
                    break;
                case clsvRTSysSkillEN.con_CreateDate:
                    this.createDate = strValue;
                    break;
                case clsvRTSysSkillEN.con_ShareId:
                    this.shareId = strValue;
                    break;
                case clsvRTSysSkillEN.con_ClassificationId:
                    this.classificationId = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vRTSysSkill]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"TopicName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TopicName() { return "topicName"; } //栏目主题
        /**
        * 常量:"SkillName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SkillName() { return "skillName"; } //技能名称
        /**
        * 常量:"OperationTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OperationTypeId() { return "operationTypeId"; } //操作类型ID
        /**
        * 常量:"Process"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Process() { return "process"; } //实施过程
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
        * 常量:"SkillUpdUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SkillUpdUser() { return "skillUpdUser"; } //SkillUpdUser
        /**
        * 常量:"SkillUpdDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SkillUpdDate() { return "skillUpdDate"; } //SkillUpdDate
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
        * 常量:"TopicProposePeople"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TopicProposePeople() { return "topicProposePeople"; } //主题提出人
        /**
        * 常量:"TopicContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TopicContent() { return "topicContent"; } //主题内容
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
        * 常量:"OperationTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OperationTypeName() { return "operationTypeName"; } //操作类型名
        /**
        * 常量:"OkCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OkCount() { return "okCount"; } //点赞统计
        /**
        * 常量:"CitationId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CitationId() { return "citationId"; } //引用Id
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
        * 常量:"SkillId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SkillId() { return "skillId"; } //技能Id
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
        * 常量:"UpdUser"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_UpdUser() { return "updUser"; } //修改人
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
    exports.clsvRTSysSkillEN = clsvRTSysSkillEN;
    clsvRTSysSkillEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvRTSysSkillEN.CacheModeId = "02"; //客户端缓存
    clsvRTSysSkillEN._CurrTabName = "vRTSysSkill"; //当前表名,与该类相关的表名
    clsvRTSysSkillEN._KeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvRTSysSkillEN.mintAttributeCount = 33;
    clsvRTSysSkillEN.AttributeName = ["topicName", "skillName", "operationTypeId", "process", "levelId", "levelName", "skillUpdUser", "skillUpdDate", "orderNum", "id_CurrEduCls", "topicProposePeople", "topicContent", "isSubmit", "appraiseCount", "score", "stuScore", "teaScore", "pdfContent", "pdfPageNum", "citationCount", "versionCount", "operationTypeName", "okCount", "citationId", "mId", "topicId", "skillId", "updDate", "memo", "updUser", "createDate", "shareId", "classificationId"];
});
