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
    exports.clsvSysSocialRelationsEN = void 0;
    /**
    * 类名:clsvSysSocialRelationsEN
    * 表名:vSysSocialRelations(01120654)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:45:40
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
    * 社会关系表视图(vSysSocialRelations)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvSysSocialRelationsEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.socialId = ""; //社会Id
            this.fullName = ""; //姓名
            this.nationality = ""; //国籍
            this.workUnit = ""; //工作单位
            this.major = ""; //专业
            this.achievement = ""; //成就
            this.detailedDescription = ""; //详细说明
            this.levelId = ""; //级别Id
            this.levelName = ""; //级别名称
            this.updUser = ""; //修改人
            this.updDate = ""; //修改日期
            this.isSubmit = false; //是否提交
            this.okCount = 0; //点赞统计
            this.citationCount = 0; //引用统计
            this.versionCount = 0; //版本统计
            this.id_CurrEduCls = ""; //教学班流水号
            this.memo = ""; //备注
            this.appraiseCount = 0; //评论数
            this.score = 0.0; //评分
            this.stuScore = 0.0; //学生平均分
            this.teaScore = 0.0; //教师评分
            this.citationId = ""; //引用Id
            this.createDate = ""; //建立日期
            this.shareId = ""; //分享Id
            this.pdfContent = ""; //Pdf内容
            this.pdfPageNum = 0; //Pdf页码
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
                case clsvSysSocialRelationsEN.con_SocialId:
                    return this.socialId;
                case clsvSysSocialRelationsEN.con_FullName:
                    return this.fullName;
                case clsvSysSocialRelationsEN.con_Nationality:
                    return this.nationality;
                case clsvSysSocialRelationsEN.con_WorkUnit:
                    return this.workUnit;
                case clsvSysSocialRelationsEN.con_Major:
                    return this.major;
                case clsvSysSocialRelationsEN.con_Achievement:
                    return this.achievement;
                case clsvSysSocialRelationsEN.con_DetailedDescription:
                    return this.detailedDescription;
                case clsvSysSocialRelationsEN.con_LevelId:
                    return this.levelId;
                case clsvSysSocialRelationsEN.con_LevelName:
                    return this.levelName;
                case clsvSysSocialRelationsEN.con_UpdUser:
                    return this.updUser;
                case clsvSysSocialRelationsEN.con_UpdDate:
                    return this.updDate;
                case clsvSysSocialRelationsEN.con_IsSubmit:
                    return this.isSubmit;
                case clsvSysSocialRelationsEN.con_OkCount:
                    return this.okCount;
                case clsvSysSocialRelationsEN.con_CitationCount:
                    return this.citationCount;
                case clsvSysSocialRelationsEN.con_VersionCount:
                    return this.versionCount;
                case clsvSysSocialRelationsEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clsvSysSocialRelationsEN.con_Memo:
                    return this.memo;
                case clsvSysSocialRelationsEN.con_AppraiseCount:
                    return this.appraiseCount;
                case clsvSysSocialRelationsEN.con_Score:
                    return this.score;
                case clsvSysSocialRelationsEN.con_StuScore:
                    return this.stuScore;
                case clsvSysSocialRelationsEN.con_TeaScore:
                    return this.teaScore;
                case clsvSysSocialRelationsEN.con_CitationId:
                    return this.citationId;
                case clsvSysSocialRelationsEN.con_CreateDate:
                    return this.createDate;
                case clsvSysSocialRelationsEN.con_ShareId:
                    return this.shareId;
                case clsvSysSocialRelationsEN.con_PdfContent:
                    return this.pdfContent;
                case clsvSysSocialRelationsEN.con_PdfPageNum:
                    return this.pdfPageNum;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vSysSocialRelations]中不存在！`;
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
                case clsvSysSocialRelationsEN.con_SocialId:
                    this.socialId = strValue;
                    break;
                case clsvSysSocialRelationsEN.con_FullName:
                    this.fullName = strValue;
                    break;
                case clsvSysSocialRelationsEN.con_Nationality:
                    this.nationality = strValue;
                    break;
                case clsvSysSocialRelationsEN.con_WorkUnit:
                    this.workUnit = strValue;
                    break;
                case clsvSysSocialRelationsEN.con_Major:
                    this.major = strValue;
                    break;
                case clsvSysSocialRelationsEN.con_Achievement:
                    this.achievement = strValue;
                    break;
                case clsvSysSocialRelationsEN.con_DetailedDescription:
                    this.detailedDescription = strValue;
                    break;
                case clsvSysSocialRelationsEN.con_LevelId:
                    this.levelId = strValue;
                    break;
                case clsvSysSocialRelationsEN.con_LevelName:
                    this.levelName = strValue;
                    break;
                case clsvSysSocialRelationsEN.con_UpdUser:
                    this.updUser = strValue;
                    break;
                case clsvSysSocialRelationsEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvSysSocialRelationsEN.con_IsSubmit:
                    this.isSubmit = Boolean(strValue);
                    break;
                case clsvSysSocialRelationsEN.con_OkCount:
                    this.okCount = Number(strValue);
                    break;
                case clsvSysSocialRelationsEN.con_CitationCount:
                    this.citationCount = Number(strValue);
                    break;
                case clsvSysSocialRelationsEN.con_VersionCount:
                    this.versionCount = Number(strValue);
                    break;
                case clsvSysSocialRelationsEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    break;
                case clsvSysSocialRelationsEN.con_Memo:
                    this.memo = strValue;
                    break;
                case clsvSysSocialRelationsEN.con_AppraiseCount:
                    this.appraiseCount = Number(strValue);
                    break;
                case clsvSysSocialRelationsEN.con_Score:
                    this.score = Number(strValue);
                    break;
                case clsvSysSocialRelationsEN.con_StuScore:
                    this.stuScore = Number(strValue);
                    break;
                case clsvSysSocialRelationsEN.con_TeaScore:
                    this.teaScore = Number(strValue);
                    break;
                case clsvSysSocialRelationsEN.con_CitationId:
                    this.citationId = strValue;
                    break;
                case clsvSysSocialRelationsEN.con_CreateDate:
                    this.createDate = strValue;
                    break;
                case clsvSysSocialRelationsEN.con_ShareId:
                    this.shareId = strValue;
                    break;
                case clsvSysSocialRelationsEN.con_PdfContent:
                    this.pdfContent = strValue;
                    break;
                case clsvSysSocialRelationsEN.con_PdfPageNum:
                    this.pdfPageNum = Number(strValue);
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vSysSocialRelations]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
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
        * 常量:"id_CurrEduCls"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_id_CurrEduCls() { return "id_CurrEduCls"; } //教学班流水号
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
        * 常量:"CitationId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CitationId() { return "citationId"; } //引用Id
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
    exports.clsvSysSocialRelationsEN = clsvSysSocialRelationsEN;
    clsvSysSocialRelationsEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvSysSocialRelationsEN.CacheModeId = "04"; //sessionStorage
    clsvSysSocialRelationsEN.IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
    clsvSysSocialRelationsEN.WhereFormat = ""; //条件格式串
    clsvSysSocialRelationsEN._CurrTabName = "vSysSocialRelations"; //当前表名,与该类相关的表名
    clsvSysSocialRelationsEN._KeyFldName = "SocialId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvSysSocialRelationsEN.mintAttributeCount = 26;
    clsvSysSocialRelationsEN.AttributeName = ["socialId", "fullName", "nationality", "workUnit", "major", "achievement", "detailedDescription", "levelId", "levelName", "updUser", "updDate", "isSubmit", "okCount", "citationCount", "versionCount", "id_CurrEduCls", "memo", "appraiseCount", "score", "stuScore", "teaScore", "citationId", "createDate", "shareId", "pdfContent", "pdfPageNum"];
});
