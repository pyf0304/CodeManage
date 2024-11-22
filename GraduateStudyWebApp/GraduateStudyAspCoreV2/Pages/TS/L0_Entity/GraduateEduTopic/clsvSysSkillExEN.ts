
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvSysSkillExEN
表名:vSysSkill(01120653)
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
/// 技能表视图(vSysSkill)
/// (AutoGCLib.EntityLayer4TypeScript:GeneCode)
/// </summary>
/// <reference path="../../PubFun/clsGeneralTab2.ts" />
import { clsGeneralTab2 } from '../../PubFun/clsGeneralTab2.js';
export class clsvSysSkillExEN extends clsGeneralTab2 {
    public static _CurrTabName: string = "vSysSkill"; //当前表名,与该类相关的表名
    public static _KeyFldName: string = "skillId"; //当前表中的关键字名称,与该类相关的表中关键字名
    public mintAttributeCount = 24;
    public AttributeName = new Array("skillId", "skillName", "operationTypeId", "process", "levelId", "levelName", "updUser", "updDate", "isSubmit", "citationId", "okCount", "appraiseCount", "score", "stuScore", "teaScore", "id_CurrEduCls", "pdfContent", "pdfPageNum", "citationCount", "versionCount", "memo", "operationTypeName", "createDate", "shareId", "mId", "RelaUpdDate", "RelaUpdUser", "RelaUserName");
    //以下是属性变量

    /// <summary>
    /// 构造函数
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
    /// </summary>
    constructor() {
        super();
    }

    private mstrSkillId: string = "";    //技能Id
    private mstrSkillName: string = "";    //技能名称
    private mstrOperationTypeId: string = "";    //操作类型ID
    private mstrProcess: string = "";    //实施过程
    private mstrLevelId: string = "";    //级别Id
    private mstrLevelName: string = "";    //级别名称
    private mstrUpdUser: string = "";    //修改人
    private mstrUpdDate: string = "";    //修改日期
    private mbolIsSubmit: boolean = false;    //是否提交
    private mstrCitationId: string = "";    //引用Id
    private mintOkCount: number = 0;    //点赞统计
    private mintAppraiseCount: number = 0;    //评论数
    private mfltscore: number = 0.0;    //评分
    private mfltStuScore: number = 0.0;    //学生平均分
    private mfltTeaScore: number = 0.0;    //教师评分
    private mstrid_CurrEduCls: string = "";    //当前教学班流水号
    private mstrPdfContent: string = "";    //Pdf内容
    private mintPdfPageNum: number = 0;    //Pdf页码
    private mintCitationCount: number = 0;    //引用统计
    private mintVersionCount: number = 0;    //版本统计
    private mstrMemo: string = "";    //备注
    private mstrOperationTypeName: string = "";    //操作类型名
    private mstrCreateDate: string = "";    //建立日期
    private mstrShareId: string = "";    //分享Id
    private mlngmId: number = 0;    //关系Id
    private mstrRelaUpdUser: string = "";    //关系用户名
    private mstrRelaUserName: string = "";    //关系用户名
    private mstrRelaUpdDate: string = "";    //关系编辑时间
    /// <summary>
    /// 技能Id(说明:;字段类型:char;字段长度:10;是否可空:False)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get skillId() {
        return this.mstrSkillId;
    };
    /// <summary>
    /// 技能Id(说明:;字段类型:char;字段长度:10;是否可空:False)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set skillId(value: string) {
        this.mstrSkillId = value;
        this.hmProperty["skillId"] = true;
    };

    /// <summary>
    /// 技能名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get skillName() {
        return this.mstrSkillName;
    };
    /// <summary>
    /// 技能名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set skillName(value: string) {
        this.mstrSkillName = value;
        this.hmProperty["skillName"] = true;
    };

    /// <summary>
    /// 操作类型ID(说明:;字段类型:char;字段长度:2;是否可空:False)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get operationTypeId() {
        return this.mstrOperationTypeId;
    };
    /// <summary>
    /// 操作类型ID(说明:;字段类型:char;字段长度:2;是否可空:False)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set operationTypeId(value: string) {
        this.mstrOperationTypeId = value;
        this.hmProperty["operationTypeId"] = true;
    };

    /// <summary>
    /// 实施过程(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get process() {
        return this.mstrProcess;
    };
    /// <summary>
    /// 实施过程(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set process(value: string) {
        this.mstrProcess = value;
        this.hmProperty["process"] = true;
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
    /// Pdf内容(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get pdfContent() {
        return this.mstrPdfContent;
    };
    /// <summary>
    /// Pdf内容(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set pdfContent(value: string) {
        this.mstrPdfContent = value;
        this.hmProperty["pdfContent"] = true;
    };

    /// <summary>
    /// Pdf页码(说明:;字段类型:int;字段长度:4;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get pdfPageNum() {
        return this.mintPdfPageNum;
    };
    /// <summary>
    /// Pdf页码(说明:;字段类型:int;字段长度:4;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set pdfPageNum(value: number) {
        this.mintPdfPageNum = value;
        this.hmProperty["pdfPageNum"] = true;
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
    /// 操作类型名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get operationTypeName() {
        return this.mstrOperationTypeName;
    };
    /// <summary>
    /// 操作类型名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set operationTypeName(value: string) {
        this.mstrOperationTypeName = value;
        this.hmProperty["operationTypeName"] = true;
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
    /// 常量:"skillId"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_SkillId(): string { return "skillId"; }    //技能Id

    /// <summary>
    /// 常量:"skillName"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_SkillName(): string { return "skillName"; }    //技能名称

    /// <summary>
    /// 常量:"operationTypeId"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_OperationTypeId(): string { return "operationTypeId"; }    //操作类型ID

    /// <summary>
    /// 常量:"process"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_Process(): string { return "process"; }    //实施过程

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
    /// 常量:"citationId"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_CitationId(): string { return "citationId"; }    //引用Id

    /// <summary>
    /// 常量:"okCount"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_OkCount(): string { return "okCount"; }    //点赞统计

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
    /// 常量:"id_CurrEduCls"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_id_CurrEduCls(): string { return "id_CurrEduCls"; }    //当前教学班流水号

    /// <summary>
    /// 常量:"pdfContent"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_PdfContent(): string { return "pdfContent"; }    //Pdf内容

    /// <summary>
    /// 常量:"pdfPageNum"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_PdfPageNum(): string { return "pdfPageNum"; }    //Pdf页码

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
    /// 常量:"memo"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_Memo(): string { return "memo"; }    //备注

    /// <summary>
    /// 常量:"operationTypeName"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_OperationTypeName(): string { return "operationTypeName"; }    //操作类型名

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
/// 技能表视图(vSysSkill)
/// (AutoGCLib.EntityLayer4TypeScript:GeneCode)
/// </summary>
export class clsvSysSkillExEN_Sim {
    //以下是属性变量

    /// <summary>
    /// 技能Id(说明:;字段类型:char;字段长度:10;是否可空:False)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public skillId: string = "";

    /// <summary>
    /// 技能名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public skillName: string = "";

    /// <summary>
    /// 操作类型ID(说明:;字段类型:char;字段长度:2;是否可空:False)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public operationTypeId: string = "";

    /// <summary>
    /// 实施过程(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public process: string = "";

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
    /// 引用Id(说明:;字段类型:char;字段长度:8;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public citationId: string = "";

    /// <summary>
    /// 点赞统计(说明:;字段类型:int;字段长度:4;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public okCount: number = 0;

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
    /// 当前教学班流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public id_CurrEduCls: string = "";

    /// <summary>
    /// Pdf内容(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public pdfContent: string = "";

    /// <summary>
    /// Pdf页码(说明:;字段类型:int;字段长度:4;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public pdfPageNum: number = 0;

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
    /// 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public memo: string = "";

    /// <summary>
    /// 操作类型名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public operationTypeName: string = "";

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