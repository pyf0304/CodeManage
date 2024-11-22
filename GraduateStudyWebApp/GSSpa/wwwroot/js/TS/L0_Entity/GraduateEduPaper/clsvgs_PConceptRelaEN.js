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
    exports.clsvgs_PConceptRelaEN = void 0;
    /**
    * 类名:clsvgs_PConceptRelaEN
    * 表名:vgs_PConceptRela(01120668)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 12:02:42
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
    * 论文概念关系视图(vgs_PConceptRela)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvgs_PConceptRelaEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.conceptId = ""; //概念Id
            this.conceptName = ""; //概念名称
            this.conceptContent = ""; //概念内容
            this.isSubmit = false; //是否提交
            this.teaScore = 0.0; //教师评分
            this.stuScore = 0.0; //学生平均分
            this.score = 0.0; //评分
            this.appraiseCount = 0; //评论数
            this.okCount = 0; //点赞统计
            this.versionCount = 0; //版本统计
            this.citationCount = 0; //引用统计
            this.updDate = ""; //修改日期
            this.updUser = ""; //修改人
            this.memo = ""; //备注
            this.concepUserId = ""; //ConcepUserId
            this.concepDate = ""; //ConcepDate
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
                case clsvgs_PConceptRelaEN.con_mId:
                    return this.mId;
                case clsvgs_PConceptRelaEN.con_PaperId:
                    return this.paperId;
                case clsvgs_PConceptRelaEN.con_PaperTitle:
                    return this.paperTitle;
                case clsvgs_PConceptRelaEN.con_PaperTypeId:
                    return this.paperTypeId;
                case clsvgs_PConceptRelaEN.con_SectionId:
                    return this.sectionId;
                case clsvgs_PConceptRelaEN.con_SectionName:
                    return this.sectionName;
                case clsvgs_PConceptRelaEN.con_ConceptId:
                    return this.conceptId;
                case clsvgs_PConceptRelaEN.con_ConceptName:
                    return this.conceptName;
                case clsvgs_PConceptRelaEN.con_ConceptContent:
                    return this.conceptContent;
                case clsvgs_PConceptRelaEN.con_IsSubmit:
                    return this.isSubmit;
                case clsvgs_PConceptRelaEN.con_TeaScore:
                    return this.teaScore;
                case clsvgs_PConceptRelaEN.con_StuScore:
                    return this.stuScore;
                case clsvgs_PConceptRelaEN.con_score:
                    return this.score;
                case clsvgs_PConceptRelaEN.con_AppraiseCount:
                    return this.appraiseCount;
                case clsvgs_PConceptRelaEN.con_OkCount:
                    return this.okCount;
                case clsvgs_PConceptRelaEN.con_VersionCount:
                    return this.versionCount;
                case clsvgs_PConceptRelaEN.con_CitationCount:
                    return this.citationCount;
                case clsvgs_PConceptRelaEN.con_UpdDate:
                    return this.updDate;
                case clsvgs_PConceptRelaEN.con_UpdUser:
                    return this.updUser;
                case clsvgs_PConceptRelaEN.con_Memo:
                    return this.memo;
                case clsvgs_PConceptRelaEN.con_ConcepUserId:
                    return this.concepUserId;
                case clsvgs_PConceptRelaEN.con_ConcepDate:
                    return this.concepDate;
                case clsvgs_PConceptRelaEN.con_CreateDate:
                    return this.createDate;
                case clsvgs_PConceptRelaEN.con_ShareId:
                    return this.shareId;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vgs_PConceptRela]中不存在！`;
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
                case clsvgs_PConceptRelaEN.con_mId:
                    this.mId = Number(strValue);
                    break;
                case clsvgs_PConceptRelaEN.con_PaperId:
                    this.paperId = strValue;
                    break;
                case clsvgs_PConceptRelaEN.con_PaperTitle:
                    this.paperTitle = strValue;
                    break;
                case clsvgs_PConceptRelaEN.con_PaperTypeId:
                    this.paperTypeId = strValue;
                    break;
                case clsvgs_PConceptRelaEN.con_SectionId:
                    this.sectionId = strValue;
                    break;
                case clsvgs_PConceptRelaEN.con_SectionName:
                    this.sectionName = strValue;
                    break;
                case clsvgs_PConceptRelaEN.con_ConceptId:
                    this.conceptId = strValue;
                    break;
                case clsvgs_PConceptRelaEN.con_ConceptName:
                    this.conceptName = strValue;
                    break;
                case clsvgs_PConceptRelaEN.con_ConceptContent:
                    this.conceptContent = strValue;
                    break;
                case clsvgs_PConceptRelaEN.con_IsSubmit:
                    this.isSubmit = Boolean(strValue);
                    break;
                case clsvgs_PConceptRelaEN.con_TeaScore:
                    this.teaScore = Number(strValue);
                    break;
                case clsvgs_PConceptRelaEN.con_StuScore:
                    this.stuScore = Number(strValue);
                    break;
                case clsvgs_PConceptRelaEN.con_score:
                    this.score = Number(strValue);
                    break;
                case clsvgs_PConceptRelaEN.con_AppraiseCount:
                    this.appraiseCount = Number(strValue);
                    break;
                case clsvgs_PConceptRelaEN.con_OkCount:
                    this.okCount = Number(strValue);
                    break;
                case clsvgs_PConceptRelaEN.con_VersionCount:
                    this.versionCount = Number(strValue);
                    break;
                case clsvgs_PConceptRelaEN.con_CitationCount:
                    this.citationCount = Number(strValue);
                    break;
                case clsvgs_PConceptRelaEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvgs_PConceptRelaEN.con_UpdUser:
                    this.updUser = strValue;
                    break;
                case clsvgs_PConceptRelaEN.con_Memo:
                    this.memo = strValue;
                    break;
                case clsvgs_PConceptRelaEN.con_ConcepUserId:
                    this.concepUserId = strValue;
                    break;
                case clsvgs_PConceptRelaEN.con_ConcepDate:
                    this.concepDate = strValue;
                    break;
                case clsvgs_PConceptRelaEN.con_CreateDate:
                    this.createDate = strValue;
                    break;
                case clsvgs_PConceptRelaEN.con_ShareId:
                    this.shareId = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vgs_PConceptRela]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
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
        * 常量:"ConceptId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ConceptId() { return "conceptId"; } //概念Id
        /**
        * 常量:"ConceptName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ConceptName() { return "conceptName"; } //概念名称
        /**
        * 常量:"ConceptContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ConceptContent() { return "conceptContent"; } //概念内容
        /**
        * 常量:"IsSubmit"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsSubmit() { return "isSubmit"; } //是否提交
        /**
        * 常量:"TeaScore"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_TeaScore() { return "teaScore"; } //教师评分
        /**
        * 常量:"StuScore"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_StuScore() { return "stuScore"; } //学生平均分
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
        * 常量:"OkCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_OkCount() { return "okCount"; } //点赞统计
        /**
        * 常量:"VersionCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_VersionCount() { return "versionCount"; } //版本统计
        /**
        * 常量:"CitationCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CitationCount() { return "citationCount"; } //引用统计
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
        * 常量:"ConcepUserId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ConcepUserId() { return "concepUserId"; } //ConcepUserId
        /**
        * 常量:"ConcepDate"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ConcepDate() { return "concepDate"; } //ConcepDate
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
    exports.clsvgs_PConceptRelaEN = clsvgs_PConceptRelaEN;
    clsvgs_PConceptRelaEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvgs_PConceptRelaEN.CacheModeId = "05"; //未知
    clsvgs_PConceptRelaEN._CurrTabName = "vgs_PConceptRela"; //当前表名,与该类相关的表名
    clsvgs_PConceptRelaEN._KeyFldName = "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvgs_PConceptRelaEN.mintAttributeCount = 24;
    clsvgs_PConceptRelaEN.AttributeName = ["mId", "paperId", "paperTitle", "paperTypeId", "sectionId", "sectionName", "conceptId", "conceptName", "conceptContent", "isSubmit", "teaScore", "stuScore", "score", "appraiseCount", "okCount", "versionCount", "citationCount", "updDate", "updUser", "memo", "concepUserId", "concepDate", "createDate", "shareId"];
});
