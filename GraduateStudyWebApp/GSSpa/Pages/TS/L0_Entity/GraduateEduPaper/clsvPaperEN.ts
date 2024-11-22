
 /**
 * 类名:clsvPaperEN
 * 表名:vPaper(01120549)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 12:02:37
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
 * v论文表(vPaper)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTabV } from '../../PubFun/clsGeneralTabV.js';

export class clsvPaperEN extends clsGeneralTabV
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "04"; //sessionStorage
public static _CurrTabName= "vPaper"; //当前表名,与该类相关的表名
public static _KeyFldName= "PaperId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 54;
public static AttributeName = ["paperId", "paperTitle", "paperContent", "periodical", "author", "researchQuestion", "keyword", "literatureSources", "literatureLink", "uploadfileUrl", "isQuotethesis", "quoteId", "isChecked", "checker", "literatureTypeId", "literatureTypeName", "browseNumber", "isSubmit", "appraiseCount", "attachmentCount", "collectionCount", "downloadCount", "okCount", "pcount", "score", "stuScore", "teaScore", "paperTypeId", "paperTypeName", "paperStatusId", "paperStatusName", "versionCount", "isPublic", "askQuestion", "researchStatus", "innovationPoints", "researchDesign", "dimensionDataProcess", "expectedConclusion", "shareId", "paperQCount", "subVCount", "tagsCount", "teaQCount", "createDate", "updUser", "userName", "isGSuser", "collegeName", "id_XzCollege", "id_XzMajor", "majorName", "updDate", "memo"];
//以下是属性变量

/**
 * 构造函数
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
*/
 constructor()
 {
 super();
 }

/**
 * 根据字段名获取对象中某字段的值.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_GetFldValue)
 * @param strFldName:字段名
 * @returns 字段值
*/
public GetFldValue(strFldName: string):any
{
const strThisFuncName = "GetFldValue";
let strMsg = "";
switch (strFldName)
{
case clsvPaperEN.con_PaperId:
return this.paperId;
case clsvPaperEN.con_PaperTitle:
return this.paperTitle;
case clsvPaperEN.con_PaperContent:
return this.paperContent;
case clsvPaperEN.con_Periodical:
return this.periodical;
case clsvPaperEN.con_Author:
return this.author;
case clsvPaperEN.con_ResearchQuestion:
return this.researchQuestion;
case clsvPaperEN.con_Keyword:
return this.keyword;
case clsvPaperEN.con_LiteratureSources:
return this.literatureSources;
case clsvPaperEN.con_LiteratureLink:
return this.literatureLink;
case clsvPaperEN.con_UploadfileUrl:
return this.uploadfileUrl;
case clsvPaperEN.con_IsQuotethesis:
return this.isQuotethesis;
case clsvPaperEN.con_QuoteId:
return this.quoteId;
case clsvPaperEN.con_IsChecked:
return this.isChecked;
case clsvPaperEN.con_Checker:
return this.checker;
case clsvPaperEN.con_LiteratureTypeId:
return this.literatureTypeId;
case clsvPaperEN.con_LiteratureTypeName:
return this.literatureTypeName;
case clsvPaperEN.con_BrowseNumber:
return this.browseNumber;
case clsvPaperEN.con_IsSubmit:
return this.isSubmit;
case clsvPaperEN.con_AppraiseCount:
return this.appraiseCount;
case clsvPaperEN.con_AttachmentCount:
return this.attachmentCount;
case clsvPaperEN.con_CollectionCount:
return this.collectionCount;
case clsvPaperEN.con_DownloadCount:
return this.downloadCount;
case clsvPaperEN.con_OkCount:
return this.okCount;
case clsvPaperEN.con_Pcount:
return this.pcount;
case clsvPaperEN.con_score:
return this.score;
case clsvPaperEN.con_StuScore:
return this.stuScore;
case clsvPaperEN.con_TeaScore:
return this.teaScore;
case clsvPaperEN.con_PaperTypeId:
return this.paperTypeId;
case clsvPaperEN.con_PaperTypeName:
return this.paperTypeName;
case clsvPaperEN.con_PaperStatusId:
return this.paperStatusId;
case clsvPaperEN.con_PaperStatusName:
return this.paperStatusName;
case clsvPaperEN.con_VersionCount:
return this.versionCount;
case clsvPaperEN.con_IsPublic:
return this.isPublic;
case clsvPaperEN.con_AskQuestion:
return this.askQuestion;
case clsvPaperEN.con_ResearchStatus:
return this.researchStatus;
case clsvPaperEN.con_InnovationPoints:
return this.innovationPoints;
case clsvPaperEN.con_ResearchDesign:
return this.researchDesign;
case clsvPaperEN.con_DimensionDataProcess:
return this.dimensionDataProcess;
case clsvPaperEN.con_ExpectedConclusion:
return this.expectedConclusion;
case clsvPaperEN.con_ShareId:
return this.shareId;
case clsvPaperEN.con_PaperQCount:
return this.paperQCount;
case clsvPaperEN.con_SubVCount:
return this.subVCount;
case clsvPaperEN.con_TagsCount:
return this.tagsCount;
case clsvPaperEN.con_TeaQCount:
return this.teaQCount;
case clsvPaperEN.con_CreateDate:
return this.createDate;
case clsvPaperEN.con_UpdUser:
return this.updUser;
case clsvPaperEN.con_UserName:
return this.userName;
case clsvPaperEN.con_IsGSuser:
return this.isGSuser;
case clsvPaperEN.con_CollegeName:
return this.collegeName;
case clsvPaperEN.con_id_XzCollege:
return this.id_XzCollege;
case clsvPaperEN.con_id_XzMajor:
return this.id_XzMajor;
case clsvPaperEN.con_MajorName:
return this.majorName;
case clsvPaperEN.con_UpdDate:
return this.updDate;
case clsvPaperEN.con_Memo:
return this.memo;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[vPaper]中不存在！`;
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
public SetFldValue(strFldName: string, strValue:string)
{
const strThisFuncName = "SetFldValue";
let strMsg = "";
switch (strFldName)
{
case clsvPaperEN.con_PaperId:
this.paperId = strValue;
break;
case clsvPaperEN.con_PaperTitle:
this.paperTitle = strValue;
break;
case clsvPaperEN.con_PaperContent:
this.paperContent = strValue;
break;
case clsvPaperEN.con_Periodical:
this.periodical = strValue;
break;
case clsvPaperEN.con_Author:
this.author = strValue;
break;
case clsvPaperEN.con_ResearchQuestion:
this.researchQuestion = strValue;
break;
case clsvPaperEN.con_Keyword:
this.keyword = strValue;
break;
case clsvPaperEN.con_LiteratureSources:
this.literatureSources = strValue;
break;
case clsvPaperEN.con_LiteratureLink:
this.literatureLink = strValue;
break;
case clsvPaperEN.con_UploadfileUrl:
this.uploadfileUrl = strValue;
break;
case clsvPaperEN.con_IsQuotethesis:
this.isQuotethesis = Boolean(strValue);
break;
case clsvPaperEN.con_QuoteId:
this.quoteId = strValue;
break;
case clsvPaperEN.con_IsChecked:
this.isChecked = Boolean(strValue);
break;
case clsvPaperEN.con_Checker:
this.checker = strValue;
break;
case clsvPaperEN.con_LiteratureTypeId:
this.literatureTypeId = strValue;
break;
case clsvPaperEN.con_LiteratureTypeName:
this.literatureTypeName = strValue;
break;
case clsvPaperEN.con_BrowseNumber:
this.browseNumber = Number(strValue);
break;
case clsvPaperEN.con_IsSubmit:
this.isSubmit = Boolean(strValue);
break;
case clsvPaperEN.con_AppraiseCount:
this.appraiseCount = Number(strValue);
break;
case clsvPaperEN.con_AttachmentCount:
this.attachmentCount = Number(strValue);
break;
case clsvPaperEN.con_CollectionCount:
this.collectionCount = Number(strValue);
break;
case clsvPaperEN.con_DownloadCount:
this.downloadCount = Number(strValue);
break;
case clsvPaperEN.con_OkCount:
this.okCount = Number(strValue);
break;
case clsvPaperEN.con_Pcount:
this.pcount = Number(strValue);
break;
case clsvPaperEN.con_score:
this.score = Number(strValue);
break;
case clsvPaperEN.con_StuScore:
this.stuScore = Number(strValue);
break;
case clsvPaperEN.con_TeaScore:
this.teaScore = Number(strValue);
break;
case clsvPaperEN.con_PaperTypeId:
this.paperTypeId = strValue;
break;
case clsvPaperEN.con_PaperTypeName:
this.paperTypeName = strValue;
break;
case clsvPaperEN.con_PaperStatusId:
this.paperStatusId = strValue;
break;
case clsvPaperEN.con_PaperStatusName:
this.paperStatusName = strValue;
break;
case clsvPaperEN.con_VersionCount:
this.versionCount = Number(strValue);
break;
case clsvPaperEN.con_IsPublic:
this.isPublic = Boolean(strValue);
break;
case clsvPaperEN.con_AskQuestion:
this.askQuestion = strValue;
break;
case clsvPaperEN.con_ResearchStatus:
this.researchStatus = strValue;
break;
case clsvPaperEN.con_InnovationPoints:
this.innovationPoints = strValue;
break;
case clsvPaperEN.con_ResearchDesign:
this.researchDesign = strValue;
break;
case clsvPaperEN.con_DimensionDataProcess:
this.dimensionDataProcess = strValue;
break;
case clsvPaperEN.con_ExpectedConclusion:
this.expectedConclusion = strValue;
break;
case clsvPaperEN.con_ShareId:
this.shareId = strValue;
break;
case clsvPaperEN.con_PaperQCount:
this.paperQCount = Number(strValue);
break;
case clsvPaperEN.con_SubVCount:
this.subVCount = Number(strValue);
break;
case clsvPaperEN.con_TagsCount:
this.tagsCount = Number(strValue);
break;
case clsvPaperEN.con_TeaQCount:
this.teaQCount = Number(strValue);
break;
case clsvPaperEN.con_CreateDate:
this.createDate = strValue;
break;
case clsvPaperEN.con_UpdUser:
this.updUser = strValue;
break;
case clsvPaperEN.con_UserName:
this.userName = strValue;
break;
case clsvPaperEN.con_IsGSuser:
this.isGSuser = Boolean(strValue);
break;
case clsvPaperEN.con_CollegeName:
this.collegeName = strValue;
break;
case clsvPaperEN.con_id_XzCollege:
this.id_XzCollege = strValue;
break;
case clsvPaperEN.con_id_XzMajor:
this.id_XzMajor = strValue;
break;
case clsvPaperEN.con_MajorName:
this.majorName = strValue;
break;
case clsvPaperEN.con_UpdDate:
this.updDate = strValue;
break;
case clsvPaperEN.con_Memo:
this.memo = strValue;
break;
case "sf_FldComparisonOp":
this.sf_FldComparisonOp = strValue;
break;
default:
strMsg = `字段名:[${strFldName}]在表对象:[vPaper]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
console.error(strMsg);
break;
}
}

/**
 * 设置对象中公共属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
*/
public paperId = "";    //论文Id
public paperTitle = "";    //论文标题
public paperContent = "";    //主题内容
public periodical = "";    //期刊
public author = "";    //作者
public researchQuestion = "";    //研究问题
public keyword = "";    //关键字
public literatureSources = "";    //文献来源
public literatureLink = "";    //文献链接
public uploadfileUrl = "";    //文件地址
public isQuotethesis = false;    //是否引用论文
public quoteId = "";    //引用Id
public isChecked = false;    //是否检查
public checker = "";    //审核人
public literatureTypeId = "";    //作文类型Id
public literatureTypeName = "";    //作文类型名
public browseNumber = 0;    //浏览量
public isSubmit = false;    //是否提交
public appraiseCount = 0;    //评论数
public attachmentCount = 0;    //附件计数
public collectionCount = 0;    //收藏数
public downloadCount = 0;    //下载数
public okCount = 0;    //点赞统计
public pcount = 0;    //读写数
public score = 0.0;    //评分
public stuScore = 0.0;    //学生平均分
public teaScore = 0.0;    //教师评分
public paperTypeId = "";    //论文类型Id
public paperTypeName = "";    //论文类型名
public paperStatusId = "";    //论文状态Id
public paperStatusName = "";    //论文状态名
public versionCount = 0;    //版本统计
public isPublic = false;    //是否公开
public askQuestion = "";    //问题提出
public researchStatus = "";    //目前研究的现状
public innovationPoints = "";    //创新点
public researchDesign = "";    //研究设计
public dimensionDataProcess = "";    //数据处理的维度
public expectedConclusion = "";    //预期结论
public shareId = "";    //分享Id
public paperQCount = 0;    //论文答疑数
public subVCount = 0;    //论文子观点数
public tagsCount = 0;    //论文标注数
public teaQCount = 0;    //教师提问数
public createDate = "";    //建立日期
public updUser = "";    //修改人
public userName = "";    //用户名
public isGSuser = false;    //是否GS用户
public collegeName = "";    //学院名称
public id_XzCollege = "";    //学院流水号
public id_XzMajor = "";    //专业流水号
public majorName = "";    //专业名称
public updDate = "";    //修改日期
public memo = "";    //备注


 /**
 * 常量:"PaperId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PaperId(): string {return "paperId";}    //论文Id

 /**
 * 常量:"PaperTitle"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PaperTitle(): string {return "paperTitle";}    //论文标题

 /**
 * 常量:"PaperContent"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PaperContent(): string {return "paperContent";}    //主题内容

 /**
 * 常量:"Periodical"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Periodical(): string {return "periodical";}    //期刊

 /**
 * 常量:"Author"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Author(): string {return "author";}    //作者

 /**
 * 常量:"ResearchQuestion"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ResearchQuestion(): string {return "researchQuestion";}    //研究问题

 /**
 * 常量:"Keyword"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Keyword(): string {return "keyword";}    //关键字

 /**
 * 常量:"LiteratureSources"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_LiteratureSources(): string {return "literatureSources";}    //文献来源

 /**
 * 常量:"LiteratureLink"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_LiteratureLink(): string {return "literatureLink";}    //文献链接

 /**
 * 常量:"UploadfileUrl"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UploadfileUrl(): string {return "uploadfileUrl";}    //文件地址

 /**
 * 常量:"IsQuotethesis"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsQuotethesis(): string {return "isQuotethesis";}    //是否引用论文

 /**
 * 常量:"QuoteId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_QuoteId(): string {return "quoteId";}    //引用Id

 /**
 * 常量:"IsChecked"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsChecked(): string {return "isChecked";}    //是否检查

 /**
 * 常量:"Checker"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Checker(): string {return "checker";}    //审核人

 /**
 * 常量:"LiteratureTypeId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_LiteratureTypeId(): string {return "literatureTypeId";}    //作文类型Id

 /**
 * 常量:"LiteratureTypeName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_LiteratureTypeName(): string {return "literatureTypeName";}    //作文类型名

 /**
 * 常量:"BrowseNumber"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_BrowseNumber(): string {return "browseNumber";}    //浏览量

 /**
 * 常量:"IsSubmit"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsSubmit(): string {return "isSubmit";}    //是否提交

 /**
 * 常量:"AppraiseCount"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_AppraiseCount(): string {return "appraiseCount";}    //评论数

 /**
 * 常量:"AttachmentCount"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_AttachmentCount(): string {return "attachmentCount";}    //附件计数

 /**
 * 常量:"CollectionCount"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CollectionCount(): string {return "collectionCount";}    //收藏数

 /**
 * 常量:"DownloadCount"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_DownloadCount(): string {return "downloadCount";}    //下载数

 /**
 * 常量:"OkCount"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_OkCount(): string {return "okCount";}    //点赞统计

 /**
 * 常量:"Pcount"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Pcount(): string {return "pcount";}    //读写数

 /**
 * 常量:"score"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_score(): string {return "score";}    //评分

 /**
 * 常量:"StuScore"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_StuScore(): string {return "stuScore";}    //学生平均分

 /**
 * 常量:"TeaScore"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_TeaScore(): string {return "teaScore";}    //教师评分

 /**
 * 常量:"PaperTypeId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PaperTypeId(): string {return "paperTypeId";}    //论文类型Id

 /**
 * 常量:"PaperTypeName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PaperTypeName(): string {return "paperTypeName";}    //论文类型名

 /**
 * 常量:"PaperStatusId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PaperStatusId(): string {return "paperStatusId";}    //论文状态Id

 /**
 * 常量:"PaperStatusName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PaperStatusName(): string {return "paperStatusName";}    //论文状态名

 /**
 * 常量:"VersionCount"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_VersionCount(): string {return "versionCount";}    //版本统计

 /**
 * 常量:"IsPublic"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsPublic(): string {return "isPublic";}    //是否公开

 /**
 * 常量:"AskQuestion"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_AskQuestion(): string {return "askQuestion";}    //问题提出

 /**
 * 常量:"ResearchStatus"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ResearchStatus(): string {return "researchStatus";}    //目前研究的现状

 /**
 * 常量:"InnovationPoints"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_InnovationPoints(): string {return "innovationPoints";}    //创新点

 /**
 * 常量:"ResearchDesign"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ResearchDesign(): string {return "researchDesign";}    //研究设计

 /**
 * 常量:"DimensionDataProcess"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_DimensionDataProcess(): string {return "dimensionDataProcess";}    //数据处理的维度

 /**
 * 常量:"ExpectedConclusion"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ExpectedConclusion(): string {return "expectedConclusion";}    //预期结论

 /**
 * 常量:"ShareId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ShareId(): string {return "shareId";}    //分享Id

 /**
 * 常量:"PaperQCount"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PaperQCount(): string {return "paperQCount";}    //论文答疑数

 /**
 * 常量:"SubVCount"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SubVCount(): string {return "subVCount";}    //论文子观点数

 /**
 * 常量:"TagsCount"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_TagsCount(): string {return "tagsCount";}    //论文标注数

 /**
 * 常量:"TeaQCount"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_TeaQCount(): string {return "teaQCount";}    //教师提问数

 /**
 * 常量:"CreateDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CreateDate(): string {return "createDate";}    //建立日期

 /**
 * 常量:"UpdUser"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UpdUser(): string {return "updUser";}    //修改人

 /**
 * 常量:"UserName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UserName(): string {return "userName";}    //用户名

 /**
 * 常量:"IsGSuser"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsGSuser(): string {return "isGSuser";}    //是否GS用户

 /**
 * 常量:"CollegeName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CollegeName(): string {return "collegeName";}    //学院名称

 /**
 * 常量:"id_XzCollege"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_XzCollege(): string {return "id_XzCollege";}    //学院流水号

 /**
 * 常量:"id_XzMajor"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_XzMajor(): string {return "id_XzMajor";}    //专业流水号

 /**
 * 常量:"MajorName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_MajorName(): string {return "majorName";}    //专业名称

 /**
 * 常量:"UpdDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UpdDate(): string {return "updDate";}    //修改日期

 /**
 * 常量:"Memo"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Memo(): string {return "memo";}    //备注

 /**
 * 设置条件字段值.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_SetCondFldValue)
 * @param strFldName:字段名
 * @param strFldValue:字段值
 * @param strComparisonOp:比较操作条符
 * @returns 根据关键字获取的名称
 **/
public SetCondFldValue(strFldName: string, strFldValue: any, strComparisonOp: string): void {                
const strThisFuncName = this.SetCondFldValue.name;
this.SetFldValue(strFldName, strFldValue);
if (Object.prototype.hasOwnProperty.call(this.dicFldComparisonOp, strFldName) == false)
{
this.dicFldComparisonOp[strFldName] = strComparisonOp;
}
else
{
this.dicFldComparisonOp[strFldName] = strComparisonOp;
}
this.sf_FldComparisonOp = JSON.stringify(this.dicFldComparisonOp);
}
}