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
    exports.clsvTopicObjectiveExEN_Sim = exports.clsvTopicObjectiveExEN = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:clsvTopicObjectiveExEN
    表名:vTopicObjective(01120617)
    生成代码版本:2020.06.27.2
    生成日期:2020/07/06 20:42:48
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
    /// 客观表视图(vTopicObjective)
    /// (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    /// </summary>
    /// <reference path="../../PubFun/clsGeneralTab2.ts" />
    const clsGeneralTab2_js_1 = require("../../PubFun/clsGeneralTab2.js");
    class clsvTopicObjectiveExEN extends clsGeneralTab2_js_1.clsGeneralTab2 {
        //以下是属性变量
        /// <summary>
        /// 构造函数
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
        /// </summary>
        constructor() {
            super();
            this.mintAttributeCount = 29;
            this.AttributeName = new Array("paperTitle", "paperContent", "author", "keyword", "topicObjectiveId", "objectiveName", "objectiveContent", "objectiveType", "sourceId", "conclusion", "isSubmit", "updDate", "updUser", "memo", "objectiveTypeName", "userName", "citationCount", "appraiseCount", "score", "stuScore", "teaScore", "id_CurrEduCls", "pdfContent", "pdfPageNum", "okCount", "versionCount", "createDate", "shareId", "mId", "RelaUpdDate", "RelaUpdUser", "RelaUserName");
            this.mstrPaperTitle = ""; //论文标题
            this.mstrPaperContent = ""; //主题内容
            this.mstrAuthor = ""; //作者
            this.mstrKeyword = ""; //关键字
            this.mstrTopicObjectiveId = ""; //客观Id
            this.mstrObjectiveName = ""; //客观名称
            this.mstrObjectiveContent = ""; //客观内容
            this.mstrObjectiveType = ""; //客观类型
            this.mstrSourceId = ""; //来源Id
            this.mstrConclusion = ""; //结论
            this.mbolIsSubmit = false; //是否提交
            this.mstrUpdDate = ""; //修改日期
            this.mstrUpdUser = ""; //修改用户Id
            this.mstrMemo = ""; //备注
            this.mstrObjectiveTypeName = ""; //objectiveTypeName
            this.mstrUserName = ""; //用户名
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
        /// 主题内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        get paperContent() {
            return this.mstrPaperContent;
        }
        ;
        /// <summary>
        /// 主题内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        set paperContent(value) {
            this.mstrPaperContent = value;
            this.hmProperty["paperContent"] = true;
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
        /// 客观Id(说明:;字段类型:char;字段长度:8;是否可空:False)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        get topicObjectiveId() {
            return this.mstrTopicObjectiveId;
        }
        ;
        /// <summary>
        /// 客观Id(说明:;字段类型:char;字段长度:8;是否可空:False)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        set topicObjectiveId(value) {
            this.mstrTopicObjectiveId = value;
            this.hmProperty["topicObjectiveId"] = true;
        }
        ;
        /// <summary>
        /// 客观名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        get objectiveName() {
            return this.mstrObjectiveName;
        }
        ;
        /// <summary>
        /// 客观名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        set objectiveName(value) {
            this.mstrObjectiveName = value;
            this.hmProperty["objectiveName"] = true;
        }
        ;
        /// <summary>
        /// 客观内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        get objectiveContent() {
            return this.mstrObjectiveContent;
        }
        ;
        /// <summary>
        /// 客观内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        set objectiveContent(value) {
            this.mstrObjectiveContent = value;
            this.hmProperty["objectiveContent"] = true;
        }
        ;
        /// <summary>
        /// 客观类型(说明:;字段类型:char;字段长度:2;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        get objectiveType() {
            return this.mstrObjectiveType;
        }
        ;
        /// <summary>
        /// 客观类型(说明:;字段类型:char;字段长度:2;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        set objectiveType(value) {
            this.mstrObjectiveType = value;
            this.hmProperty["objectiveType"] = true;
        }
        ;
        /// <summary>
        /// 来源Id(说明:;字段类型:char;字段长度:8;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        get sourceId() {
            return this.mstrSourceId;
        }
        ;
        /// <summary>
        /// 来源Id(说明:;字段类型:char;字段长度:8;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        set sourceId(value) {
            this.mstrSourceId = value;
            this.hmProperty["sourceId"] = true;
        }
        ;
        /// <summary>
        /// 结论(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        get conclusion() {
            return this.mstrConclusion;
        }
        ;
        /// <summary>
        /// 结论(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        set conclusion(value) {
            this.mstrConclusion = value;
            this.hmProperty["conclusion"] = true;
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
        /// objectiveTypeName(说明:;字段类型:varchar;字段长度:8;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        get objectiveTypeName() {
            return this.mstrObjectiveTypeName;
        }
        ;
        /// <summary>
        /// objectiveTypeName(说明:;字段类型:varchar;字段长度:8;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        set objectiveTypeName(value) {
            this.mstrObjectiveTypeName = value;
            this.hmProperty["objectiveTypeName"] = true;
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
        /// 常量:"paperTitle"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_PaperTitle() { return "paperTitle"; } //论文标题
        /// <summary>
        /// 常量:"paperContent"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_PaperContent() { return "paperContent"; } //主题内容
        /// <summary>
        /// 常量:"author"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_Author() { return "author"; } //作者
        /// <summary>
        /// 常量:"keyword"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_Keyword() { return "keyword"; } //关键字
        /// <summary>
        /// 常量:"topicObjectiveId"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_TopicObjectiveId() { return "topicObjectiveId"; } //客观Id
        /// <summary>
        /// 常量:"objectiveName"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_ObjectiveName() { return "objectiveName"; } //客观名称
        /// <summary>
        /// 常量:"objectiveContent"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_ObjectiveContent() { return "objectiveContent"; } //客观内容
        /// <summary>
        /// 常量:"objectiveType"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_ObjectiveType() { return "objectiveType"; } //客观类型
        /// <summary>
        /// 常量:"sourceId"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_SourceId() { return "sourceId"; } //来源Id
        /// <summary>
        /// 常量:"conclusion"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_Conclusion() { return "conclusion"; } //结论
        /// <summary>
        /// 常量:"isSubmit"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_IsSubmit() { return "isSubmit"; } //是否提交
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
        /// 常量:"objectiveTypeName"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_ObjectiveTypeName() { return "objectiveTypeName"; } //objectiveTypeName
        /// <summary>
        /// 常量:"userName"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_UserName() { return "userName"; } //用户名
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
    exports.clsvTopicObjectiveExEN = clsvTopicObjectiveExEN;
    clsvTopicObjectiveExEN._CurrTabName = "vTopicObjective"; //当前表名,与该类相关的表名
    clsvTopicObjectiveExEN._KeyFldName = "topicObjectiveId"; //当前表中的关键字名称,与该类相关的表中关键字名
    ;
    /// <summary>
    /// 客观表视图(vTopicObjective)
    /// (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    /// </summary>
    class clsvTopicObjectiveExEN_Sim {
        constructor() {
            //以下是属性变量
            /// <summary>
            /// 论文标题(说明:;字段类型:varchar;字段长度:100;是否可空:False)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.paperTitle = "";
            /// <summary>
            /// 主题内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.paperContent = "";
            /// <summary>
            /// 作者(说明:;字段类型:varchar;字段长度:50;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.author = "";
            /// <summary>
            /// 关键字(说明:;字段类型:varchar;字段长度:200;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.keyword = "";
            /// <summary>
            /// 客观Id(说明:;字段类型:char;字段长度:8;是否可空:False)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.topicObjectiveId = "";
            /// <summary>
            /// 客观名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.objectiveName = "";
            /// <summary>
            /// 客观内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.objectiveContent = "";
            /// <summary>
            /// 客观类型(说明:;字段类型:char;字段长度:2;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.objectiveType = "";
            /// <summary>
            /// 来源Id(说明:;字段类型:char;字段长度:8;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.sourceId = "";
            /// <summary>
            /// 结论(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.conclusion = "";
            /// <summary>
            /// 是否提交(说明:;字段类型:bit;字段长度:1;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.isSubmit = false;
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
            /// objectiveTypeName(说明:;字段类型:varchar;字段长度:8;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.objectiveTypeName = "";
            /// <summary>
            /// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.userName = "";
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
    exports.clsvTopicObjectiveExEN_Sim = clsvTopicObjectiveExEN_Sim;
    ;
});
