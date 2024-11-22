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
    exports.clsvSysSocialRelationsExEN_Sim = exports.clsvSysSocialRelationsExEN = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:clsvSysSocialRelationsExEN
    表名:vSysSocialRelations(01120654)
    生成代码版本:2020.06.27.2
    生成日期:2020/07/06 20:42:47
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
    /// 社会关系表视图(vSysSocialRelations)
    /// (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    /// </summary>
    /// <reference path="../../PubFun/clsGeneralTab2.ts" />
    const clsGeneralTab2_js_1 = require("../../PubFun/clsGeneralTab2.js");
    class clsvSysSocialRelationsExEN extends clsGeneralTab2_js_1.clsGeneralTab2 {
        //以下是属性变量
        /// <summary>
        /// 构造函数
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
        /// </summary>
        constructor() {
            super();
            this.mintAttributeCount = 24;
            this.AttributeName = new Array("socialId", "fullName", "nationality", "workUnit", "major", "achievement", "detailedDescription", "levelId", "levelName", "updUser", "updDate", "isSubmit", "okCount", "citationCount", "versionCount", "id_CurrEduCls", "memo", "appraiseCount", "score", "stuScore", "teaScore", "citationId", "createDate", "shareId", "mId", "RelaUpdDate", "RelaUpdUser", "RelaUserName");
            this.mstrSocialId = ""; //社会Id
            this.mstrFullName = ""; //姓名
            this.mstrNationality = ""; //国籍
            this.mstrWorkUnit = ""; //工作单位
            this.mstrMajor = ""; //专业
            this.mstrAchievement = ""; //成就
            this.mstrDetailedDescription = ""; //详细说明
            this.mstrLevelId = ""; //级别Id
            this.mstrLevelName = ""; //级别名称
            this.mstrUpdUser = ""; //修改人
            this.mstrUpdDate = ""; //修改日期
            this.mbolIsSubmit = false; //是否提交
            this.mintOkCount = 0; //点赞统计
            this.mintCitationCount = 0; //引用统计
            this.mintVersionCount = 0; //版本统计
            this.mstrid_CurrEduCls = ""; //当前教学班流水号
            this.mstrMemo = ""; //备注
            this.mintAppraiseCount = 0; //评论数
            this.mfltscore = 0.0; //评分
            this.mfltStuScore = 0.0; //学生平均分
            this.mfltTeaScore = 0.0; //教师评分
            this.mstrCitationId = ""; //引用Id
            this.mstrCreateDate = ""; //建立日期
            this.mstrShareId = ""; //分享Id
            this.mlngmId = 0; //关系Id
            this.mstrRelaUpdUser = ""; //关系用户名
            this.mstrRelaUserName = ""; //关系用户名
            this.mstrRelaUpdDate = ""; //关系编辑时间
        }
        /// <summary>
        /// 社会Id(说明:;字段类型:char;字段长度:10;是否可空:False)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        get socialId() {
            return this.mstrSocialId;
        }
        ;
        /// <summary>
        /// 社会Id(说明:;字段类型:char;字段长度:10;是否可空:False)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        set socialId(value) {
            this.mstrSocialId = value;
            this.hmProperty["socialId"] = true;
        }
        ;
        /// <summary>
        /// 姓名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        get fullName() {
            return this.mstrFullName;
        }
        ;
        /// <summary>
        /// 姓名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        set fullName(value) {
            this.mstrFullName = value;
            this.hmProperty["fullName"] = true;
        }
        ;
        /// <summary>
        /// 国籍(说明:;字段类型:varchar;字段长度:50;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        get nationality() {
            return this.mstrNationality;
        }
        ;
        /// <summary>
        /// 国籍(说明:;字段类型:varchar;字段长度:50;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        set nationality(value) {
            this.mstrNationality = value;
            this.hmProperty["nationality"] = true;
        }
        ;
        /// <summary>
        /// 工作单位(说明:;字段类型:varchar;字段长度:100;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        get workUnit() {
            return this.mstrWorkUnit;
        }
        ;
        /// <summary>
        /// 工作单位(说明:;字段类型:varchar;字段长度:100;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        set workUnit(value) {
            this.mstrWorkUnit = value;
            this.hmProperty["workUnit"] = true;
        }
        ;
        /// <summary>
        /// 专业(说明:;字段类型:varchar;字段长度:50;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        get major() {
            return this.mstrMajor;
        }
        ;
        /// <summary>
        /// 专业(说明:;字段类型:varchar;字段长度:50;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        set major(value) {
            this.mstrMajor = value;
            this.hmProperty["major"] = true;
        }
        ;
        /// <summary>
        /// 成就(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        get achievement() {
            return this.mstrAchievement;
        }
        ;
        /// <summary>
        /// 成就(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        set achievement(value) {
            this.mstrAchievement = value;
            this.hmProperty["achievement"] = true;
        }
        ;
        /// <summary>
        /// 详细说明(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        get detailedDescription() {
            return this.mstrDetailedDescription;
        }
        ;
        /// <summary>
        /// 详细说明(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        set detailedDescription(value) {
            this.mstrDetailedDescription = value;
            this.hmProperty["detailedDescription"] = true;
        }
        ;
        /// <summary>
        /// 级别Id(说明:;字段类型:char;字段长度:2;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        get levelId() {
            return this.mstrLevelId;
        }
        ;
        /// <summary>
        /// 级别Id(说明:;字段类型:char;字段长度:2;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        set levelId(value) {
            this.mstrLevelId = value;
            this.hmProperty["levelId"] = true;
        }
        ;
        /// <summary>
        /// 级别名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        get levelName() {
            return this.mstrLevelName;
        }
        ;
        /// <summary>
        /// 级别名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        set levelName(value) {
            this.mstrLevelName = value;
            this.hmProperty["levelName"] = true;
        }
        ;
        /// <summary>
        /// 修改人(说明:;字段类型:varchar;字段长度:20;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        get updUser() {
            return this.mstrUpdUser;
        }
        ;
        /// <summary>
        /// 修改人(说明:;字段类型:varchar;字段长度:20;是否可空:True)
        /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
        /// </summary>
        set updUser(value) {
            this.mstrUpdUser = value;
            this.hmProperty["updUser"] = true;
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
        /// 常量:"socialId"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_SocialId() { return "socialId"; } //社会Id
        /// <summary>
        /// 常量:"fullName"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_FullName() { return "fullName"; } //姓名
        /// <summary>
        /// 常量:"nationality"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_Nationality() { return "nationality"; } //国籍
        /// <summary>
        /// 常量:"workUnit"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_WorkUnit() { return "workUnit"; } //工作单位
        /// <summary>
        /// 常量:"major"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_Major() { return "major"; } //专业
        /// <summary>
        /// 常量:"achievement"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_Achievement() { return "achievement"; } //成就
        /// <summary>
        /// 常量:"detailedDescription"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_DetailedDescription() { return "detailedDescription"; } //详细说明
        /// <summary>
        /// 常量:"levelId"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_LevelId() { return "levelId"; } //级别Id
        /// <summary>
        /// 常量:"levelName"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_LevelName() { return "levelName"; } //级别名称
        /// <summary>
        /// 常量:"updUser"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_UpdUser() { return "updUser"; } //修改人
        /// <summary>
        /// 常量:"updDate"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_UpdDate() { return "updDate"; } //修改日期
        /// <summary>
        /// 常量:"isSubmit"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_IsSubmit() { return "isSubmit"; } //是否提交
        /// <summary>
        /// 常量:"okCount"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_OkCount() { return "okCount"; } //点赞统计
        /// <summary>
        /// 常量:"citationCount"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_CitationCount() { return "citationCount"; } //引用统计
        /// <summary>
        /// 常量:"versionCount"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_VersionCount() { return "versionCount"; } //版本统计
        /// <summary>
        /// 常量:"id_CurrEduCls"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_id_CurrEduCls() { return "id_CurrEduCls"; } //当前教学班流水号
        /// <summary>
        /// 常量:"memo"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_Memo() { return "memo"; } //备注
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
        /// 常量:"citationId"
        /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
        /// </summary>
        static get con_CitationId() { return "citationId"; } //引用Id
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
    exports.clsvSysSocialRelationsExEN = clsvSysSocialRelationsExEN;
    clsvSysSocialRelationsExEN._CurrTabName = "vSysSocialRelations"; //当前表名,与该类相关的表名
    clsvSysSocialRelationsExEN._KeyFldName = "socialId"; //当前表中的关键字名称,与该类相关的表中关键字名
    ;
    /// <summary>
    /// 社会关系表视图(vSysSocialRelations)
    /// (AutoGCLib.EntityLayer4TypeScript:GeneCode)
    /// </summary>
    class clsvSysSocialRelationsExEN_Sim {
        constructor() {
            //以下是属性变量
            /// <summary>
            /// 社会Id(说明:;字段类型:char;字段长度:10;是否可空:False)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.socialId = "";
            /// <summary>
            /// 姓名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.fullName = "";
            /// <summary>
            /// 国籍(说明:;字段类型:varchar;字段长度:50;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.nationality = "";
            /// <summary>
            /// 工作单位(说明:;字段类型:varchar;字段长度:100;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.workUnit = "";
            /// <summary>
            /// 专业(说明:;字段类型:varchar;字段长度:50;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.major = "";
            /// <summary>
            /// 成就(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.achievement = "";
            /// <summary>
            /// 详细说明(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.detailedDescription = "";
            /// <summary>
            /// 级别Id(说明:;字段类型:char;字段长度:2;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.levelId = "";
            /// <summary>
            /// 级别名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.levelName = "";
            /// <summary>
            /// 修改人(说明:;字段类型:varchar;字段长度:20;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.updUser = "";
            /// <summary>
            /// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.updDate = "";
            /// <summary>
            /// 是否提交(说明:;字段类型:bit;字段长度:1;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.isSubmit = false;
            /// <summary>
            /// 点赞统计(说明:;字段类型:int;字段长度:4;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.okCount = 0;
            /// <summary>
            /// 引用统计(说明:;字段类型:int;字段长度:4;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.citationCount = 0;
            /// <summary>
            /// 版本统计(说明:;字段类型:int;字段长度:4;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.versionCount = 0;
            /// <summary>
            /// 当前教学班流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.id_CurrEduCls = "";
            /// <summary>
            /// 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.memo = "";
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
            /// 引用Id(说明:;字段类型:char;字段长度:8;是否可空:True)
            /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
            /// </summary>
            this.citationId = "";
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
    exports.clsvSysSocialRelationsExEN_Sim = clsvSysSocialRelationsExEN_Sim;
    ;
});
