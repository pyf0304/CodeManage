
/*-- -- -- -- -- -- -- -- -- -- --
类名:clsvViewpointExEN
表名:vViewpoint(01120543)
生成代码版本:2020.06.27.2
生成日期:2020/07/06 20:42:50
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
/// v观点表视图(vViewpoint)
/// (AutoGCLib.EntityLayer4TypeScript:GeneCode)
/// </summary>
/// <reference path="../../PubFun/clsGeneralTab2.ts" />
import { clsGeneralTab2 } from '../../PubFun/clsGeneralTab2.js';
export class clsvViewpointExEN extends clsGeneralTab2 {
    public static _CurrTabName: string = "vViewpoint"; //当前表名,与该类相关的表名
    public static _KeyFldName: string = "viewpointId"; //当前表中的关键字名称,与该类相关的表中关键字名
    public mintAttributeCount = 40;
    public AttributeName = new Array("viewpointId", "viewpointName", "viewpointContent", "viewpointTypeId", "viewpointTypeName", "reason", "source", "vpProposePeople", "updDate", "updUser", "memo", "isSubmit", "appraiseCount", "score", "okCount", "userTypeId", "userTypeName", "userName", "author", "citationId", "keyword", "paperTitle", "periodical", "researchQuestion", "uploadfileUrl", "citationCount", "stuScore", "teaScore", "id_CurrEduCls", "pdfContent", "pdfPageNum", "versionCount", "createDate", "shareId", "mId", "RelaUpdDate", "RelaUpdUser", "RelaUserName", "isRecommend", "classificationId");
    //以下是属性变量

    /// <summary>
    /// 构造函数
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
    /// </summary>
    constructor() {
        super();
    }

    private mstrViewpointId: string = "";    //观点Id
    private mstrViewpointName: string = "";    //观点名称
    private mstrViewpointContent: string = "";    //观点内容
    private mstrViewpointTypeId: string = "";    //观点类型Id
    private mstrViewpointTypeName: string = "";    //观点类型名
    private mstrReason: string = "";    //理由
    private mstrSource: string = "";    //来源
    private mstrVPProposePeople: string = "";    //观点提出人
    private mstrUpdDate: string = "";    //修改日期
    private mstrUpdUser: string = "";    //修改人
    private mstrMemo: string = "";    //备注
    private mbolIsSubmit: boolean = false;    //是否提交
    private mintAppraiseCount: number = 0;    //评论数
    private mfltscore: number = 0.0;    //评分
    private mintOkCount: number = 0;    //点赞统计
    private mstrUserTypeId: string = "";    //用户类型Id
    private mstrUserTypeName: string = "";    //用户类型名称
    private mstrUserName: string = "";    //用户名
    private mstrAuthor: string = "";    //作者
    private mstrCitationId: string = "";    //引用Id
    private mstrKeyword: string = "";    //关键字
    private mstrPaperTitle: string = "";    //论文标题
    private mstrPeriodical: string = "";    //期刊
    private mstrResearchQuestion: string = "";    //研究问题
    private mstrUploadfileUrl: string = "";    //文件地址
    private mintCitationCount: number = 0;    //引用统计
    private mfltStuScore: number = 0.0;    //学生平均分
    private mfltTeaScore: number = 0.0;    //教师评分
    private mstrid_CurrEduCls: string = "";    //当前教学班流水号
    private mstrPdfContent: string = "";    //Pdf内容
    private mintPdfPageNum: number = 0;    //Pdf页码
    private mintVersionCount: number = 0;    //版本统计
    private mstrCreateDate: string = "";    //建立日期
    private mstrShareId: string = "";    //分享Id
    private mlngmId: number = 0;    //关系Id
    private mstrRelaUpdUser: string = "";    //关系用户名
    private mstrRelaUserName: string = "";    //关系用户名
    private mstrRelaUpdDate: string = "";    //关系编辑时间
    private mbolIsRecommend: boolean = false;    //isRecommend
    private mstrClassificationId: string = "";    //分类Id
    /// <summary>
    /// 观点Id(说明:;字段类型:char;字段长度:8;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get viewpointId() {
        return this.mstrViewpointId;
    };
    /// <summary>
    /// 观点Id(说明:;字段类型:char;字段长度:8;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set viewpointId(value: string) {
        this.mstrViewpointId = value;
        this.hmProperty["viewpointId"] = true;
    };

    /// <summary>
    /// 观点名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get viewpointName() {
        return this.mstrViewpointName;
    };
    /// <summary>
    /// 观点名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set viewpointName(value: string) {
        this.mstrViewpointName = value;
        this.hmProperty["viewpointName"] = true;
    };

    /// <summary>
    /// 观点内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get viewpointContent() {
        return this.mstrViewpointContent;
    };
    /// <summary>
    /// 观点内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set viewpointContent(value: string) {
        this.mstrViewpointContent = value;
        this.hmProperty["viewpointContent"] = true;
    };

    /// <summary>
    /// 观点类型Id(说明:;字段类型:char;字段长度:4;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get viewpointTypeId() {
        return this.mstrViewpointTypeId;
    };
    /// <summary>
    /// 观点类型Id(说明:;字段类型:char;字段长度:4;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set viewpointTypeId(value: string) {
        this.mstrViewpointTypeId = value;
        this.hmProperty["viewpointTypeId"] = true;
    };

    /// <summary>
    /// 观点类型名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get viewpointTypeName() {
        return this.mstrViewpointTypeName;
    };
    /// <summary>
    /// 观点类型名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set viewpointTypeName(value: string) {
        this.mstrViewpointTypeName = value;
        this.hmProperty["viewpointTypeName"] = true;
    };

    /// <summary>
    /// 理由(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get reason() {
        return this.mstrReason;
    };
    /// <summary>
    /// 理由(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set reason(value: string) {
        this.mstrReason = value;
        this.hmProperty["reason"] = true;
    };

    /// <summary>
    /// 来源(说明:;字段类型:varchar;字段长度:500;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get source() {
        return this.mstrSource;
    };
    /// <summary>
    /// 来源(说明:;字段类型:varchar;字段长度:500;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set source(value: string) {
        this.mstrSource = value;
        this.hmProperty["source"] = true;
    };

    /// <summary>
    /// 观点提出人(说明:;字段类型:varchar;字段长度:50;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get vpProposePeople() {
        return this.mstrVPProposePeople;
    };
    /// <summary>
    /// 观点提出人(说明:;字段类型:varchar;字段长度:50;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set vpProposePeople(value: string) {
        this.mstrVPProposePeople = value;
        this.hmProperty["vpProposePeople"] = true;
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
    /// 用户类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get userTypeId() {
        return this.mstrUserTypeId;
    };
    /// <summary>
    /// 用户类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set userTypeId(value: string) {
        this.mstrUserTypeId = value;
        this.hmProperty["userTypeId"] = true;
    };

    /// <summary>
    /// 用户类型名称(说明:;字段类型:varchar;字段长度:20;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get userTypeName() {
        return this.mstrUserTypeName;
    };
    /// <summary>
    /// 用户类型名称(说明:;字段类型:varchar;字段长度:20;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set userTypeName(value: string) {
        this.mstrUserTypeName = value;
        this.hmProperty["userTypeName"] = true;
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
    /// 期刊(说明:;字段类型:varchar;字段长度:100;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get periodical() {
        return this.mstrPeriodical;
    };
    /// <summary>
    /// 期刊(说明:;字段类型:varchar;字段长度:100;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set periodical(value: string) {
        this.mstrPeriodical = value;
        this.hmProperty["periodical"] = true;
    };

    /// <summary>
    /// 研究问题(说明:;字段类型:varchar;字段长度:500;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get researchQuestion() {
        return this.mstrResearchQuestion;
    };
    /// <summary>
    /// 研究问题(说明:;字段类型:varchar;字段长度:500;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set researchQuestion(value: string) {
        this.mstrResearchQuestion = value;
        this.hmProperty["researchQuestion"] = true;
    };

    /// <summary>
    /// 文件地址(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get uploadfileUrl() {
        return this.mstrUploadfileUrl;
    };
    /// <summary>
    /// 文件地址(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set uploadfileUrl(value: string) {
        this.mstrUploadfileUrl = value;
        this.hmProperty["uploadfileUrl"] = true;
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
    /// isRecommend(说明:;字段类型:bit;字段长度:1;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get isRecommend() {
        return this.mbolIsRecommend;
    };
    /// <summary>
    /// isRecommend(说明:;字段类型:bit;字段长度:1;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set isRecommend(value: boolean) {
        this.mbolIsRecommend = value;
        this.hmProperty["isRecommend"] = true;
    };


    /// <summary>
    /// 关系修改日期(说明:;字段类型:char;字段长度:2;是否可空:False)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public get classificationId() {
        return this.mstrClassificationId;
    };
    /// <summary>
    /// 关系修改日期(说明:;字段类型:char;字段长度:2;是否可空:False)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
    /// </summary>
    public set classificationId(value: string) {
        this.mstrClassificationId = value;
        this.hmProperty["classificationId"] = true;
    };

    /// <summary>
    /// 常量:"viewpointId"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_ViewpointId(): string { return "viewpointId"; }    //观点Id

    /// <summary>
    /// 常量:"viewpointName"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_ViewpointName(): string { return "viewpointName"; }    //观点名称

    /// <summary>
    /// 常量:"viewpointContent"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_ViewpointContent(): string { return "viewpointContent"; }    //观点内容

    /// <summary>
    /// 常量:"viewpointTypeId"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_ViewpointTypeId(): string { return "viewpointTypeId"; }    //观点类型Id

    /// <summary>
    /// 常量:"viewpointTypeName"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_ViewpointTypeName(): string { return "viewpointTypeName"; }    //观点类型名

    /// <summary>
    /// 常量:"reason"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_Reason(): string { return "reason"; }    //理由

    /// <summary>
    /// 常量:"source"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_Source(): string { return "source"; }    //来源

    /// <summary>
    /// 常量:"vpProposePeople"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_VPProposePeople(): string { return "vpProposePeople"; }    //观点提出人

    /// <summary>
    /// 常量:"updDate"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_UpdDate(): string { return "updDate"; }    //修改日期

    /// <summary>
    /// 常量:"updUser"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_UpdUser(): string { return "updUser"; }    //修改人

    /// <summary>
    /// 常量:"memo"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_Memo(): string { return "memo"; }    //备注

    /// <summary>
    /// 常量:"isSubmit"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_IsSubmit(): string { return "isSubmit"; }    //是否提交

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
    /// 常量:"okCount"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_OkCount(): string { return "okCount"; }    //点赞统计

    /// <summary>
    /// 常量:"userTypeId"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_UserTypeId(): string { return "userTypeId"; }    //用户类型Id

    /// <summary>
    /// 常量:"userTypeName"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_UserTypeName(): string { return "userTypeName"; }    //用户类型名称

    /// <summary>
    /// 常量:"userName"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_UserName(): string { return "userName"; }    //用户名

    /// <summary>
    /// 常量:"author"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_Author(): string { return "author"; }    //作者

    /// <summary>
    /// 常量:"citationId"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_CitationId(): string { return "citationId"; }    //引用Id

    /// <summary>
    /// 常量:"keyword"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_Keyword(): string { return "keyword"; }    //关键字

   
    /// <summary>
    /// 常量:"paperTitle"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_PaperTitle(): string { return "paperTitle"; }    //论文标题

    /// <summary>
    /// 常量:"periodical"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_Periodical(): string { return "periodical"; }    //期刊

    /// <summary>
    /// 常量:"researchQuestion"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_ResearchQuestion(): string { return "researchQuestion"; }    //研究问题

    /// <summary>
    /// 常量:"uploadfileUrl"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_UploadfileUrl(): string { return "uploadfileUrl"; }    //文件地址

    /// <summary>
    /// 常量:"citationCount"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_CitationCount(): string { return "citationCount"; }    //引用统计

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


    /// <summary>
    /// 常量:"isRecommend"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_IsRecommend(): string { return "isRecommend"; }    //isRecommend
    /// <summary>
    /// 常量:"isRecommend"
    /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
    /// </summary>
    public static get con_ClassificationId(): string { return "classificationId"; }    //classificationId


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
/// v观点表视图(vViewpoint)
/// (AutoGCLib.EntityLayer4TypeScript:GeneCode)
/// </summary>
export class clsvViewpointExEN_Sim {
    //以下是属性变量

    /// <summary>
    /// 观点Id(说明:;字段类型:char;字段长度:8;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public viewpointId: string = "";

    /// <summary>
    /// 观点名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public viewpointName: string = "";

    /// <summary>
    /// 观点内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public viewpointContent: string = "";

    /// <summary>
    /// 观点类型Id(说明:;字段类型:char;字段长度:4;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public viewpointTypeId: string = "";

    /// <summary>
    /// 观点类型名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public viewpointTypeName: string = "";

    /// <summary>
    /// 理由(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public reason: string = "";

    /// <summary>
    /// 来源(说明:;字段类型:varchar;字段长度:500;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public source: string = "";

    /// <summary>
    /// 观点提出人(说明:;字段类型:varchar;字段长度:50;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public vpProposePeople: string = "";

    /// <summary>
    /// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public updDate: string = "";

    /// <summary>
    /// 修改人(说明:;字段类型:varchar;字段长度:20;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public updUser: string = "";

    /// <summary>
    /// 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public memo: string = "";

    /// <summary>
    /// 是否提交(说明:;字段类型:bit;字段长度:1;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public isSubmit: boolean = false;

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
    /// 点赞统计(说明:;字段类型:int;字段长度:4;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public okCount: number = 0;

    /// <summary>
    /// 用户类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public userTypeId: string = "";

    /// <summary>
    /// 用户类型名称(说明:;字段类型:varchar;字段长度:20;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public userTypeName: string = "";

    /// <summary>
    /// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public userName: string = "";

    /// <summary>
    /// 作者(说明:;字段类型:varchar;字段长度:50;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public author: string = "";

    /// <summary>
    /// 引用Id(说明:;字段类型:char;字段长度:8;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public citationId: string = "";

    /// <summary>
    /// 关键字(说明:;字段类型:varchar;字段长度:200;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public keyword: string = "";

    /// <summary>
    /// 论文标题(说明:;字段类型:varchar;字段长度:100;是否可空:False)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public paperTitle: string = "";

    /// <summary>
    /// 期刊(说明:;字段类型:varchar;字段长度:100;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public periodical: string = "";

    /// <summary>
    /// 研究问题(说明:;字段类型:varchar;字段长度:500;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public researchQuestion: string = "";

    /// <summary>
    /// 文件地址(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public uploadfileUrl: string = "";

    /// <summary>
    /// 引用统计(说明:;字段类型:int;字段长度:4;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public citationCount: number = 0;

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


    /// <summary>
    /// isRecommend(说明:;字段类型:bit;字段长度:1;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public isRecommend: boolean = false;
    /// <summary>
    /// 关系日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
    /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
    /// </summary>
    public classificationId: string = "";

    public sfUpdFldSetStr: string = "";     //专门用于记录某字段属性是否修改
    public sf_FldComparisonOp: string = "";     //专门用于记录条件对象某字段的比较运算符
};