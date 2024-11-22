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
    exports.clsvConceptEN = void 0;
    /**
    * 类名:clsvConceptEN
    * 表名:vConcept(01120619)
    * 生成代码版本:2022.11.02.1
    * 生成日期:2022/11/02 12:02:52
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
    * 概念视图(vConcept)
    * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    **/
    const clsGeneralTabV_js_1 = require("../../PubFun/clsGeneralTabV.js");
    class clsvConceptEN extends clsGeneralTabV_js_1.clsGeneralTabV {
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
            this.conceptContent = ""; //概念内容
            this.conceptName = ""; //概念名称
            this.isSubmit = false; //是否提交
            this.conceptId = ""; //概念Id
            this.updDate = ""; //修改日期
            this.memo = ""; //备注
            this.author = ""; //作者
            this.citationId = ""; //引用Id
            this.keyword = ""; //关键字
            this.paperTitle = ""; //论文标题
            this.periodical = ""; //期刊
            this.researchQuestion = ""; //研究问题
            this.citationCount = 0; //引用统计
            this.appraiseCount = 0; //评论数
            this.score = 0.0; //评分
            this.stuScore = 0.0; //学生平均分
            this.teaScore = 0.0; //教师评分
            this.id_CurrEduCls = ""; //教学班流水号
            this.pdfPageNum = 0; //Pdf页码
            this.okCount = 0; //点赞统计
            this.versionCount = 0; //版本统计
            this.createDate = ""; //建立日期
            this.shareId = ""; //分享Id
            this.updUser = ""; //修改人
            this.pdfContent = ""; //Pdf内容
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
                case clsvConceptEN.con_ConceptContent:
                    return this.conceptContent;
                case clsvConceptEN.con_ConceptName:
                    return this.conceptName;
                case clsvConceptEN.con_IsSubmit:
                    return this.isSubmit;
                case clsvConceptEN.con_ConceptId:
                    return this.conceptId;
                case clsvConceptEN.con_UpdDate:
                    return this.updDate;
                case clsvConceptEN.con_Memo:
                    return this.memo;
                case clsvConceptEN.con_Author:
                    return this.author;
                case clsvConceptEN.con_CitationId:
                    return this.citationId;
                case clsvConceptEN.con_Keyword:
                    return this.keyword;
                case clsvConceptEN.con_PaperTitle:
                    return this.paperTitle;
                case clsvConceptEN.con_Periodical:
                    return this.periodical;
                case clsvConceptEN.con_ResearchQuestion:
                    return this.researchQuestion;
                case clsvConceptEN.con_CitationCount:
                    return this.citationCount;
                case clsvConceptEN.con_AppraiseCount:
                    return this.appraiseCount;
                case clsvConceptEN.con_score:
                    return this.score;
                case clsvConceptEN.con_StuScore:
                    return this.stuScore;
                case clsvConceptEN.con_TeaScore:
                    return this.teaScore;
                case clsvConceptEN.con_id_CurrEduCls:
                    return this.id_CurrEduCls;
                case clsvConceptEN.con_PdfPageNum:
                    return this.pdfPageNum;
                case clsvConceptEN.con_OkCount:
                    return this.okCount;
                case clsvConceptEN.con_VersionCount:
                    return this.versionCount;
                case clsvConceptEN.con_CreateDate:
                    return this.createDate;
                case clsvConceptEN.con_ShareId:
                    return this.shareId;
                case clsvConceptEN.con_UpdUser:
                    return this.updUser;
                case clsvConceptEN.con_PdfContent:
                    return this.pdfContent;
                case "sf_FldComparisonOp":
                    return this.sf_FldComparisonOp;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vConcept]中不存在！`;
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
                case clsvConceptEN.con_ConceptContent:
                    this.conceptContent = strValue;
                    break;
                case clsvConceptEN.con_ConceptName:
                    this.conceptName = strValue;
                    break;
                case clsvConceptEN.con_IsSubmit:
                    this.isSubmit = Boolean(strValue);
                    break;
                case clsvConceptEN.con_ConceptId:
                    this.conceptId = strValue;
                    break;
                case clsvConceptEN.con_UpdDate:
                    this.updDate = strValue;
                    break;
                case clsvConceptEN.con_Memo:
                    this.memo = strValue;
                    break;
                case clsvConceptEN.con_Author:
                    this.author = strValue;
                    break;
                case clsvConceptEN.con_CitationId:
                    this.citationId = strValue;
                    break;
                case clsvConceptEN.con_Keyword:
                    this.keyword = strValue;
                    break;
                case clsvConceptEN.con_PaperTitle:
                    this.paperTitle = strValue;
                    break;
                case clsvConceptEN.con_Periodical:
                    this.periodical = strValue;
                    break;
                case clsvConceptEN.con_ResearchQuestion:
                    this.researchQuestion = strValue;
                    break;
                case clsvConceptEN.con_CitationCount:
                    this.citationCount = Number(strValue);
                    break;
                case clsvConceptEN.con_AppraiseCount:
                    this.appraiseCount = Number(strValue);
                    break;
                case clsvConceptEN.con_score:
                    this.score = Number(strValue);
                    break;
                case clsvConceptEN.con_StuScore:
                    this.stuScore = Number(strValue);
                    break;
                case clsvConceptEN.con_TeaScore:
                    this.teaScore = Number(strValue);
                    break;
                case clsvConceptEN.con_id_CurrEduCls:
                    this.id_CurrEduCls = strValue;
                    break;
                case clsvConceptEN.con_PdfPageNum:
                    this.pdfPageNum = Number(strValue);
                    break;
                case clsvConceptEN.con_OkCount:
                    this.okCount = Number(strValue);
                    break;
                case clsvConceptEN.con_VersionCount:
                    this.versionCount = Number(strValue);
                    break;
                case clsvConceptEN.con_CreateDate:
                    this.createDate = strValue;
                    break;
                case clsvConceptEN.con_ShareId:
                    this.shareId = strValue;
                    break;
                case clsvConceptEN.con_UpdUser:
                    this.updUser = strValue;
                    break;
                case clsvConceptEN.con_PdfContent:
                    this.pdfContent = strValue;
                    break;
                case "sf_FldComparisonOp":
                    this.sf_FldComparisonOp = strValue;
                    break;
                default:
                    strMsg = `字段名:[${strFldName}]在表对象:[vConcept]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        /**
        * 常量:"ConceptContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ConceptContent() { return "conceptContent"; } //概念内容
        /**
        * 常量:"ConceptName"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ConceptName() { return "conceptName"; } //概念名称
        /**
        * 常量:"IsSubmit"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_IsSubmit() { return "isSubmit"; } //是否提交
        /**
        * 常量:"ConceptId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ConceptId() { return "conceptId"; } //概念Id
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
        * 常量:"Author"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Author() { return "author"; } //作者
        /**
        * 常量:"CitationId"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CitationId() { return "citationId"; } //引用Id
        /**
        * 常量:"Keyword"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Keyword() { return "keyword"; } //关键字
        /**
        * 常量:"PaperTitle"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PaperTitle() { return "paperTitle"; } //论文标题
        /**
        * 常量:"Periodical"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_Periodical() { return "periodical"; } //期刊
        /**
        * 常量:"ResearchQuestion"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_ResearchQuestion() { return "researchQuestion"; } //研究问题
        /**
        * 常量:"CitationCount"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_CitationCount() { return "citationCount"; } //引用统计
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
        * 常量:"PdfPageNum"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PdfPageNum() { return "pdfPageNum"; } //Pdf页码
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
        * 常量:"PdfContent"
        * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        */
        static get con_PdfContent() { return "pdfContent"; } //Pdf内容
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
    exports.clsvConceptEN = clsvConceptEN;
    clsvConceptEN.CacheAddiCondition = ""; //缓存附加条件，作为向后台调取数据的附加条件
    clsvConceptEN.CacheModeId = "04"; //sessionStorage
    clsvConceptEN._CurrTabName = "vConcept"; //当前表名,与该类相关的表名
    clsvConceptEN._KeyFldName = "ConceptId"; //当前表中的关键字名称,与该类相关的表中关键字名
    clsvConceptEN.mintAttributeCount = 25;
    clsvConceptEN.AttributeName = ["conceptContent", "conceptName", "isSubmit", "conceptId", "updDate", "memo", "author", "citationId", "keyword", "paperTitle", "periodical", "researchQuestion", "citationCount", "appraiseCount", "score", "stuScore", "teaScore", "id_CurrEduCls", "pdfPageNum", "okCount", "versionCount", "createDate", "shareId", "updUser", "pdfContent"];
});
