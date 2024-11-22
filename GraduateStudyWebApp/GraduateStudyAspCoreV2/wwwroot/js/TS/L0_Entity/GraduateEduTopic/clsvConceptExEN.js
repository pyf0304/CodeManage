(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../PubFun/clsGeneralTab2.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.clsvConceptExEN_Sim = exports.clsvConceptExEN = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:clsvConceptExEN
    表名:vConcept(01120619)
    生成代码版本:2020.06.27.2
    生成日期:2020/07/06 20:42:49
    生成者:
    工程名称:问卷调查
    工程ID:0112
    相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
    PrjDataBaseId:0122
    模块中文名:研培主题
    模块英文名:GraduateEduTopic
    框架-层名:实体层(EntityLayer)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    /// <summary>
    /// 概念视图(vConcept)
    /// (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    /// </summary>
    /// <reference path="../../PubFun/clsGeneralTab2.ts" />
    const clsGeneralTab2_js_1 = require("../../PubFun/clsGeneralTab2.js");
    class clsvConceptExEN extends clsGeneralTab2_js_1.clsGeneralTab2 {
        //以下是属性变量
        /// <summary>
        /// 构造函数
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
        /// </summary>
        constructor() {
            super();
            this.mintAttributeCount = 27;
            this.AttributeName = new Array("conceptContent", "conceptName", "isSubmit", "conceptId", "updDate", "updUser", "memo", "userName", "author", "citationId", "keyword", "paperTitle", "periodical", "researchQuestion", "citationCount", "appraiseCount", "score", "stuScore", "teaScore", "id_CurrEduCls", "pdfContent", "pdfPageNum", "okCount", "versionCount", "createDate", "shareId", "mId", "RelaUpdDate", "RelaUpdUser", "RelaUserName");
            this.mstrConceptContent = ""; //概念内容
            this.mstrConceptName = ""; //概念名称
            this.mbolIsSubmit = false; //是否提交
            this.mstrConceptId = ""; //概念Id
            this.mstrUpdDate = ""; //修改日期
            this.mstrUpdUser = ""; //修改用户Id
            this.mstrMemo = ""; //备注
            this.mstrUserName = ""; //用户名
            this.mstrAuthor = ""; //作者
            this.mstrCitationId = ""; //引用Id
            this.mstrKeyword = ""; //关键字
            this.mstrPaperTitle = ""; //论文标题
            this.mstrPeriodical = ""; //期刊
            this.mstrResearchQuestion = ""; //研究问题
            this.mintCitationCount = 0; //引用统计
            this.mintAppraiseCount = 0; //评论数
            this.mfltscore = 0.0; //评分
            this.mfltStuScore = 0.0; //学生平均分
            this.mfltTeaScore = 0.0; //教师评分
            this.mstrid_CurrEduCls = ""; //当前教学班流水号
            this.mstrPdfContent = ""; //Pdf内容
            this.mintPdfPageNum = 0; //Pdf页码
            this.mintOkCount = 0; //点赞统计
            this.mintVersionCount = 0; //版本统计
            this.mstrCreateDate = ""; //建立日期
            this.mstrShareId = ""; //分享Id
            this.mlngmId = 0; //关系Id
            this.mstrRelaUpdUser = ""; //关系用户名
            this.mstrRelaUserName = ""; //关系用户名
            this.mstrRelaUpdDate = ""; //关系编辑时间
        }
        /// <summary>
        /// 概念内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        get conceptContent() {
            return this.mstrConceptContent;
        }
        ;
        /// <summary>
        /// 概念内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        set conceptContent(value) {
            this.mstrConceptContent = value;
            this.hmProperty["conceptContent"] = true;
        }
        ;
        /// <summary>
        /// 概念名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        get conceptName() {
            return this.mstrConceptName;
        }
        ;
        /// <summary>
        /// 概念名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        set conceptName(value) {
            this.mstrConceptName = value;
            this.hmProperty["conceptName"] = true;
        }
        ;
        /// <summary>
        /// 是否提交(说明:;字段类型:bit;字段长度:1;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        get isSubmit() {
            return this.mbolIsSubmit;
        }
        ;
        /// <summary>
        /// 是否提交(说明:;字段类型:bit;字段长度:1;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        set isSubmit(value) {
            this.mbolIsSubmit = value;
            this.hmProperty["isSubmit"] = true;
        }
        ;
        /// <summary>
        /// 概念Id(说明:;字段类型:char;字段长度:8;是否可空:False)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        get conceptId() {
            return this.mstrConceptId;
        }
        ;
        /// <summary>
        /// 概念Id(说明:;字段类型:char;字段长度:8;是否可空:False)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        set conceptId(value) {
            this.mstrConceptId = value;
            this.hmProperty["conceptId"] = true;
        }
        ;
        /// <summary>
        /// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        get updDate() {
            return this.mstrUpdDate;
        }
        ;
        /// <summary>
        /// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        set updDate(value) {
            this.mstrUpdDate = value;
            this.hmProperty["updDate"] = true;
        }
        ;
        /// <summary>
        /// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        get updUser() {
            return this.mstrUpdUser;
        }
        ;
        /// <summary>
        /// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        set updUser(value) {
            this.mstrUpdUser = value;
            this.hmProperty["updUser"] = true;
        }
        ;
        /// <summary>
        /// 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        get memo() {
            return this.mstrMemo;
        }
        ;
        /// <summary>
        /// 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        set memo(value) {
            this.mstrMemo = value;
            this.hmProperty["memo"] = true;
        }
        ;
        /// <summary>
        /// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        get userName() {
            return this.mstrUserName;
        }
        ;
        /// <summary>
        /// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        set userName(value) {
            this.mstrUserName = value;
            this.hmProperty["userName"] = true;
        }
        ;
        /// <summary>
        /// 作者(说明:;字段类型:varchar;字段长度:50;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        get author() {
            return this.mstrAuthor;
        }
        ;
        /// <summary>
        /// 作者(说明:;字段类型:varchar;字段长度:50;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        set author(value) {
            this.mstrAuthor = value;
            this.hmProperty["author"] = true;
        }
        ;
        /// <summary>
        /// 引用Id(说明:;字段类型:char;字段长度:8;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        get citationId() {
            return this.mstrCitationId;
        }
        ;
        /// <summary>
        /// 引用Id(说明:;字段类型:char;字段长度:8;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        set citationId(value) {
            this.mstrCitationId = value;
            this.hmProperty["citationId"] = true;
        }
        ;
        /// <summary>
        /// 关键字(说明:;字段类型:varchar;字段长度:200;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        get keyword() {
            return this.mstrKeyword;
        }
        ;
        /// <summary>
        /// 关键字(说明:;字段类型:varchar;字段长度:200;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        set keyword(value) {
            this.mstrKeyword = value;
            this.hmProperty["keyword"] = true;
        }
        ;
        /// <summary>
        /// 论文标题(说明:;字段类型:varchar;字段长度:100;是否可空:False)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        get paperTitle() {
            return this.mstrPaperTitle;
        }
        ;
        /// <summary>
        /// 论文标题(说明:;字段类型:varchar;字段长度:100;是否可空:False)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        set paperTitle(value) {
            this.mstrPaperTitle = value;
            this.hmProperty["paperTitle"] = true;
        }
        ;
        /// <summary>
        /// 期刊(说明:;字段类型:varchar;字段长度:100;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        get periodical() {
            return this.mstrPeriodical;
        }
        ;
        /// <summary>
        /// 期刊(说明:;字段类型:varchar;字段长度:100;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        set periodical(value) {
            this.mstrPeriodical = value;
            this.hmProperty["periodical"] = true;
        }
        ;
        /// <summary>
        /// 研究问题(说明:;字段类型:varchar;字段长度:500;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        get researchQuestion() {
            return this.mstrResearchQuestion;
        }
        ;
        /// <summary>
        /// 研究问题(说明:;字段类型:varchar;字段长度:500;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        set researchQuestion(value) {
            this.mstrResearchQuestion = value;
            this.hmProperty["researchQuestion"] = true;
        }
        ;
        /// <summary>
        /// 引用统计(说明:;字段类型:int;字段长度:4;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        get citationCount() {
            return this.mintCitationCount;
        }
        ;
        /// <summary>
        /// 引用统计(说明:;字段类型:int;字段长度:4;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        set citationCount(value) {
            this.mintCitationCount = value;
            this.hmProperty["citationCount"] = true;
        }
        ;
        /// <summary>
        /// 评论数(说明:;字段类型:int;字段长度:4;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        get appraiseCount() {
            return this.mintAppraiseCount;
        }
        ;
        /// <summary>
        /// 评论数(说明:;字段类型:int;字段长度:4;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        set appraiseCount(value) {
            this.mintAppraiseCount = value;
            this.hmProperty["appraiseCount"] = true;
        }
        ;
        /// <summary>
        /// 评分(说明:;字段类型:float;字段长度:8;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        get score() {
            return this.mfltscore;
        }
        ;
        /// <summary>
        /// 评分(说明:;字段类型:float;字段长度:8;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        set score(value) {
            this.mfltscore = value;
            this.hmProperty["score"] = true;
        }
        ;
        /// <summary>
        /// 学生平均分(说明:;字段类型:float;字段长度:8;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        get stuScore() {
            return this.mfltStuScore;
        }
        ;
        /// <summary>
        /// 学生平均分(说明:;字段类型:float;字段长度:8;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        set stuScore(value) {
            this.mfltStuScore = value;
            this.hmProperty["stuScore"] = true;
        }
        ;
        /// <summary>
        /// 教师评分(说明:;字段类型:float;字段长度:8;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        get teaScore() {
            return this.mfltTeaScore;
        }
        ;
        /// <summary>
        /// 教师评分(说明:;字段类型:float;字段长度:8;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        set teaScore(value) {
            this.mfltTeaScore = value;
            this.hmProperty["teaScore"] = true;
        }
        ;
        /// <summary>
        /// 当前教学班流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        get id_CurrEduCls() {
            return this.mstrid_CurrEduCls;
        }
        ;
        /// <summary>
        /// 当前教学班流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        set id_CurrEduCls(value) {
            this.mstrid_CurrEduCls = value;
            this.hmProperty["id_CurrEduCls"] = true;
        }
        ;
        /// <summary>
        /// Pdf内容(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        get pdfContent() {
            return this.mstrPdfContent;
        }
        ;
        /// <summary>
        /// Pdf内容(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        set pdfContent(value) {
            this.mstrPdfContent = value;
            this.hmProperty["pdfContent"] = true;
        }
        ;
        /// <summary>
        /// Pdf页码(说明:;字段类型:int;字段长度:4;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        get pdfPageNum() {
            return this.mintPdfPageNum;
        }
        ;
        /// <summary>
        /// Pdf页码(说明:;字段类型:int;字段长度:4;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        set pdfPageNum(value) {
            this.mintPdfPageNum = value;
            this.hmProperty["pdfPageNum"] = true;
        }
        ;
        /// <summary>
        /// 点赞统计(说明:;字段类型:int;字段长度:4;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        get okCount() {
            return this.mintOkCount;
        }
        ;
        /// <summary>
        /// 点赞统计(说明:;字段类型:int;字段长度:4;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        set okCount(value) {
            this.mintOkCount = value;
            this.hmProperty["okCount"] = true;
        }
        ;
        /// <summary>
        /// 版本统计(说明:;字段类型:int;字段长度:4;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        get versionCount() {
            return this.mintVersionCount;
        }
        ;
        /// <summary>
        /// 版本统计(说明:;字段类型:int;字段长度:4;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        set versionCount(value) {
            this.mintVersionCount = value;
            this.hmProperty["versionCount"] = true;
        }
        ;
        /// <summary>
        /// 建立日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        get createDate() {
            return this.mstrCreateDate;
        }
        ;
        /// <summary>
        /// 建立日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        set createDate(value) {
            this.mstrCreateDate = value;
            this.hmProperty["createDate"] = true;
        }
        ;
        /// <summary>
        /// 分享Id(说明:;字段类型:char;字段长度:2;是否可空:False)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        get shareId() {
            return this.mstrShareId;
        }
        ;
        /// <summary>
        /// 分享Id(说明:;字段类型:char;字段长度:2;是否可空:False)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        set shareId(value) {
            this.mstrShareId = value;
            this.hmProperty["shareId"] = true;
        }
        ;
        /// <summary>
        /// mId(说明:;字段类型:bigint;字段长度:8;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        get mId() {
            return this.mlngmId;
        }
        ;
        /// <summary>
        /// mId(说明:;字段类型:bigint;字段长度:8;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        set mId(value) {
            this.mlngmId = value;
            this.hmProperty["mId"] = true;
        }
        ;
        /// <summary>
        /// 关系修改用户(说明:;字段类型:char;字段长度:2;是否可空:False)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        get RelaUpdUser() {
            return this.mstrRelaUpdUser;
        }
        ;
        /// <summary>
        /// 关系修改用户(说明:;字段类型:char;字段长度:2;是否可空:False)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        set RelaUpdUser(value) {
            this.mstrRelaUpdUser = value;
            this.hmProperty["RelaUpdUser"] = true;
        }
        ;
        /// <summary>
        /// 关系修改用户(说明:;字段类型:char;字段长度:2;是否可空:False)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        get RelaUserName() {
            return this.mstrRelaUserName;
        }
        ;
        /// <summary>
        /// 关系修改用户(说明:;字段类型:char;字段长度:2;是否可空:False)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        set RelaUserName(value) {
            this.mstrRelaUserName = value;
            this.hmProperty["RelaUserName"] = true;
        }
        ;
        /// <summary>
        /// 关系修改日期(说明:;字段类型:char;字段长度:2;是否可空:False)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        get RelaUpdDate() {
            return this.mstrRelaUpdDate;
        }
        ;
        /// <summary>
        /// 关系修改日期(说明:;字段类型:char;字段长度:2;是否可空:False)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        set RelaUpdDate(value) {
            this.mstrRelaUpdDate = value;
            this.hmProperty["RelaUpdDate"] = true;
        }
        ;
        /// <summary>
        /// 常量:"conceptContent"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_ConceptContent() { return "conceptContent"; } //概念内容
        /// <summary>
        /// 常量:"conceptName"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_ConceptName() { return "conceptName"; } //概念名称
        /// <summary>
        /// 常量:"isSubmit"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_IsSubmit() { return "isSubmit"; } //是否提交
        /// <summary>
        /// 常量:"conceptId"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_ConceptId() { return "conceptId"; } //概念Id
        /// <summary>
        /// 常量:"updDate"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_UpdDate() { return "updDate"; } //修改日期
        /// <summary>
        /// 常量:"updUser"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_UpdUser() { return "updUser"; } //修改用户Id
        /// <summary>
        /// 常量:"memo"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_Memo() { return "memo"; } //备注
        /// <summary>
        /// 常量:"userName"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_UserName() { return "userName"; } //用户名
        /// <summary>
        /// 常量:"author"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_Author() { return "author"; } //作者
        /// <summary>
        /// 常量:"citationId"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_CitationId() { return "citationId"; } //引用Id
        /// <summary>
        /// 常量:"keyword"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_Keyword() { return "keyword"; } //关键字
        /// <summary>
        /// 常量:"paperTitle"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_PaperTitle() { return "paperTitle"; } //论文标题
        /// <summary>
        /// 常量:"periodical"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_Periodical() { return "periodical"; } //期刊
        /// <summary>
        /// 常量:"researchQuestion"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_ResearchQuestion() { return "researchQuestion"; } //研究问题
        /// <summary>
        /// 常量:"citationCount"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_CitationCount() { return "citationCount"; } //引用统计
        /// <summary>
        /// 常量:"appraiseCount"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_AppraiseCount() { return "appraiseCount"; } //评论数
        /// <summary>
        /// 常量:"score"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_score() { return "score"; } //评分
        /// <summary>
        /// 常量:"stuScore"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_StuScore() { return "stuScore"; } //学生平均分
        /// <summary>
        /// 常量:"teaScore"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_TeaScore() { return "teaScore"; } //教师评分
        /// <summary>
        /// 常量:"id_CurrEduCls"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_id_CurrEduCls() { return "id_CurrEduCls"; } //当前教学班流水号
        /// <summary>
        /// 常量:"pdfContent"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_PdfContent() { return "pdfContent"; } //Pdf内容
        /// <summary>
        /// 常量:"pdfPageNum"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_PdfPageNum() { return "pdfPageNum"; } //Pdf页码
        /// <summary>
        /// 常量:"okCount"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_OkCount() { return "okCount"; } //点赞统计
        /// <summary>
        /// 常量:"versionCount"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_VersionCount() { return "versionCount"; } //版本统计
        /// <summary>
        /// 常量:"createDate"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_CreateDate() { return "createDate"; } //建立日期
        /// <summary>
        /// 常量:"shareId"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_ShareId() { return "shareId"; } //分享Id
        /// <summary>
        /// 常量:"mId"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_mId() { return "mId"; } //关系Id
        /// <summary>
        /// 常量:"RelaUpdUser"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_RelaUpdUser() { return "RelaUpdUser"; } //关系编辑用户
        /// <summary>
        /// 常量:"RelaUpdUser"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_RelaUserName() { return "RelaUserName"; } //关系编辑用户
        /// <summary>
        /// 常量:"RelaUpdDate"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_RelaUpdDate() { return "RelaUpdDate"; } //关系编辑时间
        SetCondFldValue(strFldName, strFldValue, strComparisonOp) {
            this[strFldName] = strFldValue;
            if (this.dicFldComparisonOp.hasOwnProperty(strFldName) == false) {
                this.dicFldComparisonOp[strFldName] = strComparisonOp;
            }
            else {
                this.dicFldComparisonOp[strFldName] = strComparisonOp;
            }
            this.sf_FldComparisonOp = JSON.stringify(this.dicFldComparisonOp);
        }
    }
    exports.clsvConceptExEN = clsvConceptExEN;
    clsvConceptExEN._CurrTabName = "vConcept"; //当前表名,与该类相关的表名
    clsvConceptExEN._KeyFldName = "conceptId"; //当前表中的关键字名称,与该类相关的表中关键字名
    ;
    /// <summary>
    /// 概念视图(vConcept)
    /// (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    /// </summary>
    class clsvConceptExEN_Sim {
        constructor() {
            //以下是属性变量
            /// <summary>
            /// 概念内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.conceptContent = "";
            /// <summary>
            /// 概念名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.conceptName = "";
            /// <summary>
            /// 是否提交(说明:;字段类型:bit;字段长度:1;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.isSubmit = false;
            /// <summary>
            /// 概念Id(说明:;字段类型:char;字段长度:8;是否可空:False)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.conceptId = "";
            /// <summary>
            /// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.updDate = "";
            /// <summary>
            /// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.updUser = "";
            /// <summary>
            /// 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.memo = "";
            /// <summary>
            /// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.userName = "";
            /// <summary>
            /// 作者(说明:;字段类型:varchar;字段长度:50;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.author = "";
            /// <summary>
            /// 引用Id(说明:;字段类型:char;字段长度:8;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.citationId = "";
            /// <summary>
            /// 关键字(说明:;字段类型:varchar;字段长度:200;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.keyword = "";
            /// <summary>
            /// 论文标题(说明:;字段类型:varchar;字段长度:100;是否可空:False)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.paperTitle = "";
            /// <summary>
            /// 期刊(说明:;字段类型:varchar;字段长度:100;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.periodical = "";
            /// <summary>
            /// 研究问题(说明:;字段类型:varchar;字段长度:500;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.researchQuestion = "";
            /// <summary>
            /// 引用统计(说明:;字段类型:int;字段长度:4;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.citationCount = 0;
            /// <summary>
            /// 评论数(说明:;字段类型:int;字段长度:4;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.appraiseCount = 0;
            /// <summary>
            /// 评分(说明:;字段类型:float;字段长度:8;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.score = 0.0;
            /// <summary>
            /// 学生平均分(说明:;字段类型:float;字段长度:8;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.stuScore = 0.0;
            /// <summary>
            /// 教师评分(说明:;字段类型:float;字段长度:8;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.teaScore = 0.0;
            /// <summary>
            /// 当前教学班流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.id_CurrEduCls = "";
            /// <summary>
            /// Pdf内容(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.pdfContent = "";
            /// <summary>
            /// Pdf页码(说明:;字段类型:int;字段长度:4;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.pdfPageNum = 0;
            /// <summary>
            /// 点赞统计(说明:;字段类型:int;字段长度:4;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.okCount = 0;
            /// <summary>
            /// 版本统计(说明:;字段类型:int;字段长度:4;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.versionCount = 0;
            /// <summary>
            /// 建立日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.createDate = "";
            /// <summary>
            /// 分享Id(说明:;字段类型:char;字段长度:2;是否可空:False)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.shareId = "";
            /// <summary>
            /// 关系主键(说明:;字段类型:int;字段长度:4;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.mId = 0;
            /// <summary>
            /// 关系用户(说明:;字段类型:varchar;字段长度:20;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.RelaUpdUser = "";
            /// <summary>
            /// 关系用户(说明:;字段类型:varchar;字段长度:20;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.RelaUserName = "";
            /// <summary>
            /// 关系日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.RelaUpdDate = "";
            this.sf_UpdFldSetStr = ""; //专门用于记录某字段属性是否修改
            this.sf_FldComparisonOp = ""; //专门用于记录条件对象某字段的比较运算符
        }
    }
    exports.clsvConceptExEN_Sim = clsvConceptExEN_Sim;
    ;
});
