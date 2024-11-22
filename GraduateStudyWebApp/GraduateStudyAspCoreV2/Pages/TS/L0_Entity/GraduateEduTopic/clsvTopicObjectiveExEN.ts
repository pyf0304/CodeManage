
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
import { clsGeneralTab2 } from '../../PubFun/clsGeneralTab2.js';
export class clsvTopicObjectiveExEN extends clsGeneralTab2 {
    public static _CurrTabName: string = "vTopicObjective"; //当前表名,与该类相关的表名
    public static _KeyFldName: string = "topicObjectiveId"; //当前表中的关键字名称,与该类相关的表中关键字名
    public mintAttributeCount = 29;
    public AttributeName = new Array("paperTitle", "paperContent", "author", "keyword", "topicObjectiveId", "objectiveName", "objectiveContent", "objectiveType", "sourceId", "conclusion", "isSubmit", "updDate", "updUser", "memo", "objectiveTypeName", "userName", "citationCount", "appraiseCount", "score", "stuScore", "teaScore", "id_CurrEduCls", "pdfContent", "pdfPageNum", "okCount", "versionCount", "createDate", "shareId", "mId", "RelaUpdDate", "RelaUpdUser", "RelaUserName");
    //以下是属性变量

    /// <summary>
    /// 构造函数
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
    /// </summary>
    constructor() {
        super();
    }

    private mstrPaperTitle: string = "";    //论文标题
    private mstrPaperContent: string = "";    //主题内容
    private mstrAuthor: string = "";    //作者
    private mstrKeyword: string = "";    //关键字
    private mstrTopicObjectiveId: string = "";    //客观Id
    private mstrObjectiveName: string = "";    //客观名称
    private mstrObjectiveContent: string = "";    //客观内容
    private mstrObjectiveType: string = "";    //客观类型
    private mstrSourceId: string = "";    //来源Id
    private mstrConclusion: string = "";    //结论
    private mbolIsSubmit: boolean = false;    //是否提交
    private mstrUpdDate: string = "";    //修改日期
    private mstrUpdUser: string = "";    //修改用户Id
    private mstrMemo: string = "";    //备注
    private mstrObjectiveTypeName: string = "";    //objectiveTypeName
    private mstrUserName: string = "";    //用户名
    private mintCitationCount: number = 0;    //引用统计
    private mintAppraiseCount: number = 0;    //评论数
    private mfltscore: number = 0.0;    //评分
    private mfltStuScore: number = 0.0;    //学生平均分
    private mfltTeaScore: number = 0.0;    //教师评分
    private mstrid_CurrEduCls: string = "";    //当前教学班流水号
    private mstrPdfContent: string = "";    //Pdf内容
    private mintPdfPageNum: number = 0;    //Pdf页码
    private mintOkCount: number = 0;    //点赞统计
    private mintVersionCount: number = 0;    //版本统计
    private mstrCreateDate: string = "";    //建立日期
    private mstrShareId: string = "";    //分享Id
    private mlngmId: number = 0;    //关系Id
    private mstrRelaUpdUser: string = "";    //关系用户名
    private mstrRelaUserName: string = "";    //关系用户名
    private mstrRelaUpdDate: string = "";    //关系编辑时间
    /// <summary>
    /// 论文标题(说明:;字段类型:varchar;字段长度:100;是否可空:False)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get paperTitle() {
        return this.mstrPaperTitle;
    };
    /// <summary>
    /// 论文标题(说明:;字段类型:varchar;字段长度:100;是否可空:False)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set paperTitle(value: string) {
        this.mstrPaperTitle = value;
        this.hmProperty["paperTitle"] = true;
    };

    /// <summary>
    /// 主题内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get paperContent() {
        return this.mstrPaperContent;
    };
    /// <summary>
    /// 主题内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set paperContent(value: string) {
        this.mstrPaperContent = value;
        this.hmProperty["paperContent"] = true;
    };

    /// <summary>
    /// 作者(说明:;字段类型:varchar;字段长度:50;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get author() {
        return this.mstrAuthor;
    };
    /// <summary>
    /// 作者(说明:;字段类型:varchar;字段长度:50;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set author(value: string) {
        this.mstrAuthor = value;
        this.hmProperty["author"] = true;
    };

    /// <summary>
    /// 关键字(说明:;字段类型:varchar;字段长度:200;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get keyword() {
        return this.mstrKeyword;
    };
    /// <summary>
    /// 关键字(说明:;字段类型:varchar;字段长度:200;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set keyword(value: string) {
        this.mstrKeyword = value;
        this.hmProperty["keyword"] = true;
    };

    /// <summary>
    /// 客观Id(说明:;字段类型:char;字段长度:8;是否可空:False)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get topicObjectiveId() {
        return this.mstrTopicObjectiveId;
    };
    /// <summary>
    /// 客观Id(说明:;字段类型:char;字段长度:8;是否可空:False)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set topicObjectiveId(value: string) {
        this.mstrTopicObjectiveId = value;
        this.hmProperty["topicObjectiveId"] = true;
    };

    /// <summary>
    /// 客观名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get objectiveName() {
        return this.mstrObjectiveName;
    };
    /// <summary>
    /// 客观名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set objectiveName(value: string) {
        this.mstrObjectiveName = value;
        this.hmProperty["objectiveName"] = true;
    };

    /// <summary>
    /// 客观内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get objectiveContent() {
        return this.mstrObjectiveContent;
    };
    /// <summary>
    /// 客观内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set objectiveContent(value: string) {
        this.mstrObjectiveContent = value;
        this.hmProperty["objectiveContent"] = true;
    };

    /// <summary>
    /// 客观类型(说明:;字段类型:char;字段长度:2;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get objectiveType() {
        return this.mstrObjectiveType;
    };
    /// <summary>
    /// 客观类型(说明:;字段类型:char;字段长度:2;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set objectiveType(value: string) {
        this.mstrObjectiveType = value;
        this.hmProperty["objectiveType"] = true;
    };

    /// <summary>
    /// 来源Id(说明:;字段类型:char;字段长度:8;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get sourceId() {
        return this.mstrSourceId;
    };
    /// <summary>
    /// 来源Id(说明:;字段类型:char;字段长度:8;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set sourceId(value: string) {
        this.mstrSourceId = value;
        this.hmProperty["sourceId"] = true;
    };

    /// <summary>
    /// 结论(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get conclusion() {
        return this.mstrConclusion;
    };
    /// <summary>
    /// 结论(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set conclusion(value: string) {
        this.mstrConclusion = value;
        this.hmProperty["conclusion"] = true;
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
    /// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get updUser() {
        return this.mstrUpdUser;
    };
    /// <summary>
    /// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set updUser(value: string) {
        this.mstrUpdUser = value;
        this.hmProperty["updUser"] = true;
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
    /// objectiveTypeName(说明:;字段类型:varchar;字段长度:8;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get objectiveTypeName() {
        return this.mstrObjectiveTypeName;
    };
    /// <summary>
    /// objectiveTypeName(说明:;字段类型:varchar;字段长度:8;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set objectiveTypeName(value: string) {
        this.mstrObjectiveTypeName = value;
        this.hmProperty["objectiveTypeName"] = true;
    };

    /// <summary>
    /// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get userName() {
        return this.mstrUserName;
    };
    /// <summary>
    /// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set userName(value: string) {
        this.mstrUserName = value;
        this.hmProperty["userName"] = true;
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
    /// 常量:"paperTitle"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_PaperTitle(): string { return "paperTitle"; }    //论文标题

    /// <summary>
    /// 常量:"paperContent"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_PaperContent(): string { return "paperContent"; }    //主题内容

    /// <summary>
    /// 常量:"author"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_Author(): string { return "author"; }    //作者

    /// <summary>
    /// 常量:"keyword"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_Keyword(): string { return "keyword"; }    //关键字

    /// <summary>
    /// 常量:"topicObjectiveId"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_TopicObjectiveId(): string { return "topicObjectiveId"; }    //客观Id

    /// <summary>
    /// 常量:"objectiveName"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_ObjectiveName(): string { return "objectiveName"; }    //客观名称

    /// <summary>
    /// 常量:"objectiveContent"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_ObjectiveContent(): string { return "objectiveContent"; }    //客观内容

    /// <summary>
    /// 常量:"objectiveType"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_ObjectiveType(): string { return "objectiveType"; }    //客观类型

    /// <summary>
    /// 常量:"sourceId"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_SourceId(): string { return "sourceId"; }    //来源Id

    /// <summary>
    /// 常量:"conclusion"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_Conclusion(): string { return "conclusion"; }    //结论

    /// <summary>
    /// 常量:"isSubmit"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_IsSubmit(): string { return "isSubmit"; }    //是否提交

    /// <summary>
    /// 常量:"updDate"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_UpdDate(): string { return "updDate"; }    //修改日期

    /// <summary>
    /// 常量:"updUser"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_UpdUser(): string { return "updUser"; }    //修改用户Id

    /// <summary>
    /// 常量:"memo"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_Memo(): string { return "memo"; }    //备注

    /// <summary>
    /// 常量:"objectiveTypeName"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_ObjectiveTypeName(): string { return "objectiveTypeName"; }    //objectiveTypeName

    /// <summary>
    /// 常量:"userName"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_UserName(): string { return "userName"; }    //用户名

    /// <summary>
    /// 常量:"citationCount"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_CitationCount(): string { return "citationCount"; }    //引用统计

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
    /// 常量:"okCount"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_OkCount(): string { return "okCount"; }    //点赞统计

    /// <summary>
    /// 常量:"versionCount"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_VersionCount(): string { return "versionCount"; }    //版本统计

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
/// 客观表视图(vTopicObjective)
/// (AutoGCLib.EntityLayer4TypeScript:GeneCode)
/// </summary>
export class clsvTopicObjectiveExEN_Sim {
    //以下是属性变量

    /// <summary>
    /// 论文标题(说明:;字段类型:varchar;字段长度:100;是否可空:False)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public paperTitle: string = "";

    
    /// <summary>
    /// 主题内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public paperContent: string = "";

    /// <summary>
    /// 作者(说明:;字段类型:varchar;字段长度:50;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public author: string = "";

    /// <summary>
    /// 关键字(说明:;字段类型:varchar;字段长度:200;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public keyword: string = "";

    /// <summary>
    /// 客观Id(说明:;字段类型:char;字段长度:8;是否可空:False)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public topicObjectiveId: string = "";

    /// <summary>
    /// 客观名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public objectiveName: string = "";

    /// <summary>
    /// 客观内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public objectiveContent: string = "";

    /// <summary>
    /// 客观类型(说明:;字段类型:char;字段长度:2;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public objectiveType: string = "";

    /// <summary>
    /// 来源Id(说明:;字段类型:char;字段长度:8;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public sourceId: string = "";

    /// <summary>
    /// 结论(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public conclusion: string = "";

    /// <summary>
    /// 是否提交(说明:;字段类型:bit;字段长度:1;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public isSubmit: boolean = false;

    /// <summary>
    /// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public updDate: string = "";

    /// <summary>
    /// 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public updUser: string = "";

    /// <summary>
    /// 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public memo: string = "";

    /// <summary>
    /// objectiveTypeName(说明:;字段类型:varchar;字段长度:8;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public objectiveTypeName: string = "";

    /// <summary>
    /// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public userName: string = "";

    /// <summary>
    /// 引用统计(说明:;字段类型:int;字段长度:4;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public citationCount: number = 0;

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
    /// 点赞统计(说明:;字段类型:int;字段长度:4;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public okCount: number = 0;

    /// <summary>
    /// 版本统计(说明:;字段类型:int;字段长度:4;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public versionCount: number = 0;

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