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
    exports.clsvgs_PSkillRelaEN = void 0;
    /**
    * 类名:clsvgs_PSkillRelaEN
    * 表名:vgs_PSkillRela(01120666)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 12:02:41
    * 生成者:pyf
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    模块中文名:研培论文(GraduateEduPaper)
    * 框架-层名:实体层(TS)(EntityLayer)
    * 编程语言:TypeScript
    **/
    /**
    * 论文技能关系视图(vgs_PSkillRela)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvgs_PSkillRelaEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.paperId = ""; //论文Id
            this.paperTitle = ""; //论文标题
            this.paperTypeId = ""; //论文类型Id
            this.sectionId = ""; //节Id
            this.sectionName = ""; //节名
            this.skillId = ""; //技能Id
            this.updDate = ""; //修改日期
            this.updUser = ""; //修改人
            this.memo = ""; //备注
            this.skillName = ""; //技能名称
            this.operationTypeId = ""; //操作类型ID
            this.operationTypeName = ""; //操作类型名
            this.levelName = ""; //级别名称
            this.levelId = ""; //级别Id
            this.process = ""; //实施过程
            this.isSubmit = false; //是否提交
            this.okCount = 0; //点赞统计
            this.score = 0.0; //评分
            this.appraiseCount = 0; //评论数
            this.stuScore = 0.0; //学生平均分
            this.teaScore = 0.0; //教师评分
            this.citationCount = 0; //引用统计
            this.versionCount = 0; //版本统计
            this.skillUserId = ""; //SkillUserId
            this.skillDate = ""; //SkillDate
            this.createDate = ""; //建立日期
            this.shareId = ""; //分享Id
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
                case clsvgs_PSkillRelaEN.con_mId:
                    return this.mId;
                case clsvgs_PSkillRelaEN.con_PaperId:
                    return this.paperId;
                case clsvgs_PSkillRelaEN.con_PaperTitle:
                    return this.paperTitle;
                case clsvgs_PSkillRelaEN.con_PaperTypeId:
                    return this.paperTypeId;
                case clsvgs_PSkillRelaEN.con_SectionId:
                    return this.sectionId;
                case clsvgs_PSkillRelaEN.con_SectionName:
                    return this.sectionName;
                case clsvgs_PSkillRelaEN.con_SkillId:
                    return this.skillId;
                case clsvgs_PSkillRelaEN.con_UpdDate:
                    return this.updDate;
                case clsvgs_PSkillRelaEN.con_UpdUser:
                    return this.updUser;
                case clsvgs_PSkillRelaEN.con_Memo:
                    return this.memo;
                case clsvgs_PSkillRelaEN.con_SkillName:
                    return this.skillName;
                case clsvgs_PSkillRelaEN.con_OperationTypeId:
                    return this.operationTypeId;
                case clsvgs_PSkillRelaEN.con_OperationTypeName:
                    return this.operationTypeName;
                case clsvgs_PSkillRelaEN.con_LevelName:
                    return this.levelName;
                case clsvgs_PSkillRelaEN.con_LevelId:
                    return this.levelId;
                case clsvgs_PSkillRelaEN.con_Process:
                    return this.process;
                case clsvgs_PSkillRelaEN.con_IsSubmit:
                    return this.isSubmit;
                case clsvgs_PSkillRelaEN.con_OkCount:
                    return this.okCount;
                case clsvgs_PSkillRelaEN.con_score:
                    return this.score;
                case clsvgs_PSkillRelaEN.con_AppraiseCount:
                    return this.appraiseCount;
                case clsvgs_PSkillRelaEN.con_StuScore:
                    return this.stuScore;
                case clsvgs_PSkillRelaEN.con_TeaScore:
                    return this.teaScore;
                case clsvgs_PSkillRelaEN.con_CitationCount:
                    return this.citationCount;
                case clsvgs_PSkillRelaEN.con_VersionCount:
                    return this.versionCount;
                case clsvgs_PSkillRelaEN.con_SkillUserId:
                    return this.skillUserId;
                case clsvgs_PSkillRelaEN.con_SkillDate:
                    return this.skillDate;
                case clsvgs_PSkillRelaEN.con_CreateDate:
                    return this.createDate;
                case clsvgs_PSkillRelaEN.con_ShareId:
                    return this.shareId;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vgs_PSkillRela]中不存在！`;
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
                case clsvgs_PSkillRelaEN.con_mId:
                    this.mId = Number(strValue);
                    break;
                case clsvgs_PSkillRelaEN.con_PaperId:
                    this.paperId = strValue;
                    break;
                case clsvgs_PSkillRelaEN.con_PaperTitle:
                    this.paperTitle = strValue;
                    break;
                case clsvgs_PSkillRelaEN.con_PaperTypeId:
                    this.paperTypeId = strValue;
                    break;
                case clsvgs_PSkillRelaEN.con_SectionId:
                    this.sectionId = strValue;
                    break;
                case clsvgs_PSkillRelaEN.con_SectionName:
                    this.sectionName = strValue;
                    break;
                case clsvgs_PSkillRelaEN.con_SkillId:
                    this.skillId = strValue;
                    break;
                case clsvgs_PSkillRelaEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvgs_PSkillRelaEN.con_UpdUser:
                    this.updUser = strValue;
                    break;
                case clsvgs_PSkillRelaEN.con_Memo:
                    this.memo = strValue;
                    break;
                case clsvgs_PSkillRelaEN.con_SkillName:
                    this.skillName = strValue;
                    break;
                case clsvgs_PSkillRelaEN.con_OperationTypeId:
                    this.operationTypeId = strValue;
                    break;
                case clsvgs_PSkillRelaEN.con_OperationTypeName:
                    this.operationTypeName = strValue;
                    break;
                case clsvgs_PSkillRelaEN.con_LevelName:
                    this.levelName = strValue;
                    break;
                case clsvgs_PSkillRelaEN.con_LevelId:
                    this.levelId = strValue;
                    break;
                case clsvgs_PSkillRelaEN.con_Process:
                    this.process = strValue;
                    break;
                case clsvgs_PSkillRelaEN.con_IsSubmit:
                    this.isSubmit = Boolean(strValue);
                    break;
                case clsvgs_PSkillRelaEN.con_OkCount:
                    this.okCount = Number(strValue);
                    break;
                case clsvgs_PSkillRelaEN.con_score:
                    this.score = Number(strValue);
                    break;
                case clsvgs_PSkillRelaEN.con_AppraiseCount:
                    this.appraiseCount = Number(strValue);
                    break;
                case clsvgs_PSkillRelaEN.con_StuScore:
                    this.stuScore = Number(strValue);
                    break;
                case clsvgs_PSkillRelaEN.con_TeaScore:
                    this.teaScore = Number(strValue);
                    break;
                case clsvgs_PSkillRelaEN.con_CitationCount:
                    this.citationCount = Number(strValue);
                    break;
                case clsvgs_PSkillRelaEN.con_VersionCount:
                    this.versionCount = Number(strValue);
                    break;
                case clsvgs_PSkillRelaEN.con_SkillUserId:
                    this.skillUserId = strValue;
                    break;
                case clsvgs_PSkillRelaEN.con_SkillDate:
                    this.skillDate = strValue;
                    break;
                case clsvgs_PSkillRelaEN.con_CreateDate:
                    this.createDate = strValue;
                    break;
                case clsvgs_PSkillRelaEN.con_ShareId:
                    this.shareId = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vgs_PSkillRela]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
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
        * 常量:"PaperId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperId() { return "paperId"; } //论文Id
        /**
        * 常量:"PaperTitle"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperTitle() { return "paperTitle"; } //论文标题
        /**
        * 常量:"PaperTypeId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperTypeId() { return "paperTypeId"; } //论文类型Id
        /**
        * 常量:"SectionId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SectionId() { return "sectionId"; } //节Id
        /**
        * 常量:"SectionName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SectionName() { return "sectionName"; } //节名
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
        * 常量:"OperationTypeName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OperationTypeName() { return "operationTypeName"; } //操作类型名
        /**
        * 常量:"LevelName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_LevelName() { return "levelName"; } //级别名称
        /**
        * 常量:"LevelId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_LevelId() { return "levelId"; } //级别Id
        /**
        * 常量:"Process"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Process() { return "process"; } //实施过程
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
        * 常量:"score"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_score() { return "score"; } //评分
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
        * 常量:"SkillUserId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SkillUserId() { return "skillUserId"; } //SkillUserId
        /**
        * 常量:"SkillDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_SkillDate() { return "skillDate"; } //SkillDate
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
    exports.clsvgs_PSkillRelaEN = clsvgs_PSkillRelaEN;
    clsvgs_PSkillRelaEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvgs_PSkillRelaEN.CacheModeId = "05"; //未知
    clsvgs_PSkillRelaEN._CurrTabName = "vgs_PSkillRela"; //当前表名,与该类相关的表名
    clsvgs_PSkillRelaEN._KeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvgs_PSkillRelaEN.mintAttributeCount = 28;
    clsvgs_PSkillRelaEN.AttributeName = ["mId", "paperId", "paperTitle", "paperTypeId", "sectionId", "sectionName", "skillId", "updDate", "updUser", "memo", "skillName", "operationTypeId", "operationTypeName", "levelName", "levelId", "process", "isSubmit", "okCount", "score", "appraiseCount", "stuScore", "teaScore", "citationCount", "versionCount", "skillUserId", "skillDate", "createDate", "shareId"];
});
