
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
import { clsGeneralTab2 } from '../../PubFun/clsGeneralTab2.js';
export class clsvSysSocialRelationsExEN extends clsGeneralTab2 {
    public static _CurrTabName: string = "vSysSocialRelations"; //当前表名,与该类相关的表名
    public static _KeyFldName: string = "socialId"; //当前表中的关键字名称,与该类相关的表中关键字名
    public mintAttributeCount = 24;
    public AttributeName = new Array("socialId", "fullName", "nationality", "workUnit", "major", "achievement", "detailedDescription", "levelId", "levelName", "updUser", "updDate", "isSubmit", "okCount", "citationCount", "versionCount", "id_CurrEduCls", "memo", "appraiseCount", "score", "stuScore", "teaScore", "citationId", "createDate", "shareId", "mId", "RelaUpdDate", "RelaUpdUser", "RelaUserName");
    //以下是属性变量

    /// <summary>
    /// 构造函数
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
    /// </summary>
    constructor() {
        super();
    }

    private mstrSocialId: string = "";    //社会Id
    private mstrFullName: string = "";    //姓名
    private mstrNationality: string = "";    //国籍
    private mstrWorkUnit: string = "";    //工作单位
    private mstrMajor: string = "";    //专业
    private mstrAchievement: string = "";    //成就
    private mstrDetailedDescription: string = "";    //详细说明
    private mstrLevelId: string = "";    //级别Id
    private mstrLevelName: string = "";    //级别名称
    private mstrUpdUser: string = "";    //修改人
    private mstrUpdDate: string = "";    //修改日期
    private mbolIsSubmit: boolean = false;    //是否提交
    private mintOkCount: number = 0;    //点赞统计
    private mintCitationCount: number = 0;    //引用统计
    private mintVersionCount: number = 0;    //版本统计
    private mstrid_CurrEduCls: string = "";    //当前教学班流水号
    private mstrMemo: string = "";    //备注
    private mintAppraiseCount: number = 0;    //评论数
    private mfltscore: number = 0.0;    //评分
    private mfltStuScore: number = 0.0;    //学生平均分
    private mfltTeaScore: number = 0.0;    //教师评分
    private mstrCitationId: string = "";    //引用Id
    private mstrCreateDate: string = "";    //建立日期
    private mstrShareId: string = "";    //分享Id
    private mlngmId: number = 0;    //关系Id
    private mstrRelaUpdUser: string = "";    //关系用户名
    private mstrRelaUserName: string = "";    //关系用户名
    private mstrRelaUpdDate: string = "";    //关系编辑时间
    /// <summary>
    /// 社会Id(说明:;字段类型:char;字段长度:10;是否可空:False)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get socialId() {
        return this.mstrSocialId;
    };
    /// <summary>
    /// 社会Id(说明:;字段类型:char;字段长度:10;是否可空:False)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set socialId(value: string) {
        this.mstrSocialId = value;
        this.hmProperty["socialId"] = true;
    };

    /// <summary>
    /// 姓名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get fullName() {
        return this.mstrFullName;
    };
    /// <summary>
    /// 姓名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set fullName(value: string) {
        this.mstrFullName = value;
        this.hmProperty["fullName"] = true;
    };

    /// <summary>
    /// 国籍(说明:;字段类型:varchar;字段长度:50;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get nationality() {
        return this.mstrNationality;
    };
    /// <summary>
    /// 国籍(说明:;字段类型:varchar;字段长度:50;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set nationality(value: string) {
        this.mstrNationality = value;
        this.hmProperty["nationality"] = true;
    };

    /// <summary>
    /// 工作单位(说明:;字段类型:varchar;字段长度:100;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get workUnit() {
        return this.mstrWorkUnit;
    };
    /// <summary>
    /// 工作单位(说明:;字段类型:varchar;字段长度:100;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set workUnit(value: string) {
        this.mstrWorkUnit = value;
        this.hmProperty["workUnit"] = true;
    };

    /// <summary>
    /// 专业(说明:;字段类型:varchar;字段长度:50;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get major() {
        return this.mstrMajor;
    };
    /// <summary>
    /// 专业(说明:;字段类型:varchar;字段长度:50;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set major(value: string) {
        this.mstrMajor = value;
        this.hmProperty["major"] = true;
    };

    /// <summary>
    /// 成就(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get achievement() {
        return this.mstrAchievement;
    };
    /// <summary>
    /// 成就(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set achievement(value: string) {
        this.mstrAchievement = value;
        this.hmProperty["achievement"] = true;
    };

    /// <summary>
    /// 详细说明(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get detailedDescription() {
        return this.mstrDetailedDescription;
    };
    /// <summary>
    /// 详细说明(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set detailedDescription(value: string) {
        this.mstrDetailedDescription = value;
        this.hmProperty["detailedDescription"] = true;
    };

    /// <summary>
    /// 级别Id(说明:;字段类型:char;字段长度:2;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get levelId() {
        return this.mstrLevelId;
    };
    /// <summary>
    /// 级别Id(说明:;字段类型:char;字段长度:2;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set levelId(value: string) {
        this.mstrLevelId = value;
        this.hmProperty["levelId"] = true;
    };

    /// <summary>
    /// 级别名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get levelName() {
        return this.mstrLevelName;
    };
    /// <summary>
    /// 级别名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set levelName(value: string) {
        this.mstrLevelName = value;
        this.hmProperty["levelName"] = true;
    };

    /// <summary>
    /// 修改人(说明:;字段类型:varchar;字段长度:20;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get updUser() {
        return this.mstrUpdUser;
    };
    /// <summary>
    /// 修改人(说明:;字段类型:varchar;字段长度:20;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set updUser(value: string) {
        this.mstrUpdUser = value;
        this.hmProperty["updUser"] = true;
    };

    /// <summary>
    /// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get updDate() {
        return this.mstrUpdDate;
    };
    /// <summary>
    /// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set updDate(value: string) {
        this.mstrUpdDate = value;
        this.hmProperty["updDate"] = true;
    };

    /// <summary>
    /// 是否提交(说明:;字段类型:bit;字段长度:1;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get isSubmit() {
        return this.mbolIsSubmit;
    };
    /// <summary>
    /// 是否提交(说明:;字段类型:bit;字段长度:1;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set isSubmit(value: boolean) {
        this.mbolIsSubmit = value;
        this.hmProperty["isSubmit"] = true;
    };

    /// <summary>
    /// 点赞统计(说明:;字段类型:int;字段长度:4;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get okCount() {
        return this.mintOkCount;
    };
    /// <summary>
    /// 点赞统计(说明:;字段类型:int;字段长度:4;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set okCount(value: number) {
        this.mintOkCount = value;
        this.hmProperty["okCount"] = true;
    };

    /// <summary>
    /// 引用统计(说明:;字段类型:int;字段长度:4;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get citationCount() {
        return this.mintCitationCount;
    };
    /// <summary>
    /// 引用统计(说明:;字段类型:int;字段长度:4;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set citationCount(value: number) {
        this.mintCitationCount = value;
        this.hmProperty["citationCount"] = true;
    };

    /// <summary>
    /// 版本统计(说明:;字段类型:int;字段长度:4;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get versionCount() {
        return this.mintVersionCount;
    };
    /// <summary>
    /// 版本统计(说明:;字段类型:int;字段长度:4;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set versionCount(value: number) {
        this.mintVersionCount = value;
        this.hmProperty["versionCount"] = true;
    };

    /// <summary>
    /// 当前教学班流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get id_CurrEduCls() {
        return this.mstrid_CurrEduCls;
    };
    /// <summary>
    /// 当前教学班流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set id_CurrEduCls(value: string) {
        this.mstrid_CurrEduCls = value;
        this.hmProperty["id_CurrEduCls"] = true;
    };

    /// <summary>
    /// 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get memo() {
        return this.mstrMemo;
    };
    /// <summary>
    /// 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set memo(value: string) {
        this.mstrMemo = value;
        this.hmProperty["memo"] = true;
    };

    /// <summary>
    /// 评论数(说明:;字段类型:int;字段长度:4;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get appraiseCount() {
        return this.mintAppraiseCount;
    };
    /// <summary>
    /// 评论数(说明:;字段类型:int;字段长度:4;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set appraiseCount(value: number) {
        this.mintAppraiseCount = value;
        this.hmProperty["appraiseCount"] = true;
    };

    /// <summary>
    /// 评分(说明:;字段类型:float;字段长度:8;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get score() {
        return this.mfltscore;
    };
    /// <summary>
    /// 评分(说明:;字段类型:float;字段长度:8;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set score(value: number) {
        this.mfltscore = value;
        this.hmProperty["score"] = true;
    };

    /// <summary>
    /// 学生平均分(说明:;字段类型:float;字段长度:8;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get stuScore() {
        return this.mfltStuScore;
    };
    /// <summary>
    /// 学生平均分(说明:;字段类型:float;字段长度:8;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set stuScore(value: number) {
        this.mfltStuScore = value;
        this.hmProperty["stuScore"] = true;
    };

    /// <summary>
    /// 教师评分(说明:;字段类型:float;字段长度:8;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get teaScore() {
        return this.mfltTeaScore;
    };
    /// <summary>
    /// 教师评分(说明:;字段类型:float;字段长度:8;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set teaScore(value: number) {
        this.mfltTeaScore = value;
        this.hmProperty["teaScore"] = true;
    };

    /// <summary>
    /// 引用Id(说明:;字段类型:char;字段长度:8;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get citationId() {
        return this.mstrCitationId;
    };
    /// <summary>
    /// 引用Id(说明:;字段类型:char;字段长度:8;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set citationId(value: string) {
        this.mstrCitationId = value;
        this.hmProperty["citationId"] = true;
    };

    /// <summary>
    /// 建立日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get createDate() {
        return this.mstrCreateDate;
    };
    /// <summary>
    /// 建立日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set createDate(value: string) {
        this.mstrCreateDate = value;
        this.hmProperty["createDate"] = true;
    };

    /// <summary>
    /// 分享Id(说明:;字段类型:char;字段长度:2;是否可空:False)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get shareId() {
        return this.mstrShareId;
    };
    /// <summary>
    /// 分享Id(说明:;字段类型:char;字段长度:2;是否可空:False)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set shareId(value: string) {
        this.mstrShareId = value;
        this.hmProperty["shareId"] = true;
    };

    /// <summary>
    /// mId(说明:;字段类型:bigint;字段长度:8;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get mId() {
        return this.mlngmId;
    };
    /// <summary>
    /// mId(说明:;字段类型:bigint;字段长度:8;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set mId(value: number) {
        this.mlngmId = value;
        this.hmProperty["mId"] = true;
    };

    /// <summary>
    /// 关系修改用户(说明:;字段类型:char;字段长度:2;是否可空:False)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get RelaUpdUser() {
        return this.mstrRelaUpdUser;
    };
    /// <summary>
    /// 关系修改用户(说明:;字段类型:char;字段长度:2;是否可空:False)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set RelaUpdUser(value: string) {
        this.mstrRelaUpdUser = value;
        this.hmProperty["RelaUpdUser"] = true;
    };

    /// <summary>
    /// 关系修改用户(说明:;字段类型:char;字段长度:2;是否可空:False)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get RelaUserName() {
        return this.mstrRelaUserName;
    };
    /// <summary>
    /// 关系修改用户(说明:;字段类型:char;字段长度:2;是否可空:False)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set RelaUserName(value: string) {
        this.mstrRelaUserName = value;
        this.hmProperty["RelaUserName"] = true;
    };

    /// <summary>
    /// 关系修改日期(说明:;字段类型:char;字段长度:2;是否可空:False)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get RelaUpdDate() {
        return this.mstrRelaUpdDate;
    };
    /// <summary>
    /// 关系修改日期(说明:;字段类型:char;字段长度:2;是否可空:False)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set RelaUpdDate(value: string) {
        this.mstrRelaUpdDate = value;
        this.hmProperty["RelaUpdDate"] = true;
    };



    /// <summary>
    /// 常量:"socialId"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_SocialId(): string { return "socialId"; }    //社会Id

    /// <summary>
    /// 常量:"fullName"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_FullName(): string { return "fullName"; }    //姓名

    /// <summary>
    /// 常量:"nationality"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_Nationality(): string { return "nationality"; }    //国籍

    /// <summary>
    /// 常量:"workUnit"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_WorkUnit(): string { return "workUnit"; }    //工作单位

    /// <summary>
    /// 常量:"major"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_Major(): string { return "major"; }    //专业

    /// <summary>
    /// 常量:"achievement"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_Achievement(): string { return "achievement"; }    //成就

    /// <summary>
    /// 常量:"detailedDescription"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_DetailedDescription(): string { return "detailedDescription"; }    //详细说明

    /// <summary>
    /// 常量:"levelId"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_LevelId(): string { return "levelId"; }    //级别Id

    /// <summary>
    /// 常量:"levelName"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_LevelName(): string { return "levelName"; }    //级别名称

    /// <summary>
    /// 常量:"updUser"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_UpdUser(): string { return "updUser"; }    //修改人

    /// <summary>
    /// 常量:"updDate"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_UpdDate(): string { return "updDate"; }    //修改日期

    /// <summary>
    /// 常量:"isSubmit"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_IsSubmit(): string { return "isSubmit"; }    //是否提交

    /// <summary>
    /// 常量:"okCount"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_OkCount(): string { return "okCount"; }    //点赞统计

    /// <summary>
    /// 常量:"citationCount"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_CitationCount(): string { return "citationCount"; }    //引用统计

    /// <summary>
    /// 常量:"versionCount"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_VersionCount(): string { return "versionCount"; }    //版本统计

    /// <summary>
    /// 常量:"id_CurrEduCls"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_id_CurrEduCls(): string { return "id_CurrEduCls"; }    //当前教学班流水号

    /// <summary>
    /// 常量:"memo"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_Memo(): string { return "memo"; }    //备注

    /// <summary>
    /// 常量:"appraiseCount"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_AppraiseCount(): string { return "appraiseCount"; }    //评论数

    /// <summary>
    /// 常量:"score"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_score(): string { return "score"; }    //评分

    /// <summary>
    /// 常量:"stuScore"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_StuScore(): string { return "stuScore"; }    //学生平均分

    /// <summary>
    /// 常量:"teaScore"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_TeaScore(): string { return "teaScore"; }    //教师评分

    /// <summary>
    /// 常量:"citationId"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_CitationId(): string { return "citationId"; }    //引用Id

    /// <summary>
    /// 常量:"createDate"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_CreateDate(): string { return "createDate"; }    //建立日期

    /// <summary>
    /// 常量:"shareId"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_ShareId(): string { return "shareId"; }    //分享Id

    /// <summary>
    /// 常量:"mId"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_mId(): string { return "mId"; }    //关系Id
    /// <summary>
    /// 常量:"RelaUpdUser"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_RelaUpdUser(): string { return "RelaUpdUser"; }    //关系编辑用户
    /// <summary>
    /// 常量:"RelaUpdUser"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_RelaUserName(): string { return "RelaUserName"; }    //关系编辑用户
    /// <summary>
    /// 常量:"RelaUpdDate"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_RelaUpdDate(): string { return "RelaUpdDate"; }    //关系编辑时间


    public SetCondFldValue(strFldName: string, strFldValue: any, strComparisonOp: string): void {
        this[strFldName] = strFldValue;
        if (this.dicFldComparisonOp.hasOwnProperty(strFldName) == false) {
            this.dicFldComparisonOp[strFldName] = strComparisonOp;
        }
        else {
            this.dicFldComparisonOp[strFldName] = strComparisonOp;
        }
        this.sf_FldComparisonOp = JSON.stringify(this.dicFldComparisonOp);
    }
};
/// <summary>
/// 社会关系表视图(vSysSocialRelations)
/// (AutoGCLib.EntityLayer4TypeScript:GeneCode)
/// </summary>
export class clsvSysSocialRelationsExEN_Sim {
    //以下是属性变量

    /// <summary>
    /// 社会Id(说明:;字段类型:char;字段长度:10;是否可空:False)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public socialId: string = "";

    /// <summary>
    /// 姓名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public fullName: string = "";

    /// <summary>
    /// 国籍(说明:;字段类型:varchar;字段长度:50;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public nationality: string = "";

    /// <summary>
    /// 工作单位(说明:;字段类型:varchar;字段长度:100;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public workUnit: string = "";

    /// <summary>
    /// 专业(说明:;字段类型:varchar;字段长度:50;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public major: string = "";

    /// <summary>
    /// 成就(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public achievement: string = "";

    /// <summary>
    /// 详细说明(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public detailedDescription: string = "";

    /// <summary>
    /// 级别Id(说明:;字段类型:char;字段长度:2;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public levelId: string = "";

    /// <summary>
    /// 级别名称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public levelName: string = "";

    /// <summary>
    /// 修改人(说明:;字段类型:varchar;字段长度:20;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public updUser: string = "";

    /// <summary>
    /// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public updDate: string = "";

    /// <summary>
    /// 是否提交(说明:;字段类型:bit;字段长度:1;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public isSubmit: boolean = false;

    /// <summary>
    /// 点赞统计(说明:;字段类型:int;字段长度:4;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public okCount: number = 0;

    /// <summary>
    /// 引用统计(说明:;字段类型:int;字段长度:4;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public citationCount: number = 0;

    /// <summary>
    /// 版本统计(说明:;字段类型:int;字段长度:4;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public versionCount: number = 0;

    /// <summary>
    /// 当前教学班流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public id_CurrEduCls: string = "";

    /// <summary>
    /// 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public memo: string = "";

    /// <summary>
    /// 评论数(说明:;字段类型:int;字段长度:4;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public appraiseCount: number = 0;

    /// <summary>
    /// 评分(说明:;字段类型:float;字段长度:8;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public score: number = 0.0;

    /// <summary>
    /// 学生平均分(说明:;字段类型:float;字段长度:8;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public stuScore: number = 0.0;

    /// <summary>
    /// 教师评分(说明:;字段类型:float;字段长度:8;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public teaScore: number = 0.0;

    /// <summary>
    /// 引用Id(说明:;字段类型:char;字段长度:8;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public citationId: string = "";

    /// <summary>
    /// 建立日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public createDate: string = "";

    /// <summary>
    /// 分享Id(说明:;字段类型:char;字段长度:2;是否可空:False)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public shareId: string = "";

    /// <summary>
    /// 关系主键(说明:;字段类型:int;字段长度:4;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public mId: number = 0;

    /// <summary>
    /// 关系用户(说明:;字段类型:varchar;字段长度:20;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public RelaUpdUser: string = "";
    /// <summary>
    /// 关系用户(说明:;字段类型:varchar;字段长度:20;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public RelaUserName: string = "";
    /// <summary>
    /// 关系日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public RelaUpdDate: string = "";

    public sfUpdFldSetStr: string = "";     //专门用于记录某字段属性是否修改
    public sf_FldComparisonOp: string = "";     //专门用于记录条件对象某字段的比较运算符
};