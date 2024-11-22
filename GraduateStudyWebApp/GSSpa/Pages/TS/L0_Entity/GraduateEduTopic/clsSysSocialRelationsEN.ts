
 /**
 * 类名:clsSysSocialRelationsEN
 * 表名:SysSocialRelations(01120644)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:57
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
 * 社会关系表(SysSocialRelations)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTab } from '../../PubFun/clsGeneralTab.js';

export class clsSysSocialRelationsEN extends clsGeneralTab
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "04"; //sessionStorage
public static _CurrTabName= "SysSocialRelations"; //当前表名,与该类相关的表名
public static _KeyFldName= "SocialId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 25;
public static AttributeName = ["socialId", "fullName", "nationality", "workUnit", "major", "achievement", "detailedDescription", "levelId", "updUser", "updDate", "isSubmit", "okCount", "citationCount", "versionCount", "id_CurrEduCls", "memo", "appraiseCount", "score", "stuScore", "teaScore", "citationId", "createDate", "shareId", "pdfContent", "pdfPageNum"];
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
 * 设置对象中私有属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPrivateVar)
*/
private mstrSocialId = "";    //社会Id
private mstrFullName = "";    //姓名
private mstrNationality = "";    //国籍
private mstrWorkUnit = "";    //工作单位
private mstrMajor = "";    //专业
private mstrAchievement = "";    //成就
private mstrDetailedDescription = "";    //详细说明
private mstrLevelId = "";    //级别Id
private mstrUpdUser = "";    //修改人
private mstrUpdDate = "";    //修改日期
private mbolIsSubmit = false;    //是否提交
private mintOkCount = 0;    //点赞统计
private mintCitationCount = 0;    //引用统计
private mintVersionCount = 0;    //版本统计
private mstrid_CurrEduCls = "";    //教学班流水号
private mstrMemo = "";    //备注
private mintAppraiseCount = 0;    //评论数
private mfltscore = 0.0;    //评分
private mfltStuScore = 0.0;    //学生平均分
private mfltTeaScore = 0.0;    //教师评分
private mstrCitationId = "";    //引用Id
private mstrCreateDate = "";    //建立日期
private mstrShareId = "";    //分享Id
private mstrPdfContent = "";    //Pdf内容
private mintPdfPageNum = 0;    //Pdf页码

/**
 * 社会Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetSocialId (value: string)
{
if (value  != undefined)
{
 this.socialId = value;
    this.hmProperty["socialId"] = true;
}
}

/**
 * 姓名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetFullName (value: string)
{
if (value  != undefined)
{
 this.fullName = value;
    this.hmProperty["fullName"] = true;
}
}

/**
 * 国籍(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetNationality (value: string)
{
if (value  != undefined)
{
 this.nationality = value;
    this.hmProperty["nationality"] = true;
}
}

/**
 * 工作单位(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetWorkUnit (value: string)
{
if (value  != undefined)
{
 this.workUnit = value;
    this.hmProperty["workUnit"] = true;
}
}

/**
 * 专业(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetMajor (value: string)
{
if (value  != undefined)
{
 this.major = value;
    this.hmProperty["major"] = true;
}
}

/**
 * 成就(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetAchievement (value: string)
{
if (value  != undefined)
{
 this.achievement = value;
    this.hmProperty["achievement"] = true;
}
}

/**
 * 详细说明(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetDetailedDescription (value: string)
{
if (value  != undefined)
{
 this.detailedDescription = value;
    this.hmProperty["detailedDescription"] = true;
}
}

/**
 * 级别Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetLevelId (value: string)
{
if (value  != undefined)
{
 this.levelId = value;
    this.hmProperty["levelId"] = true;
}
}

/**
 * 修改人(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetUpdUser (value: string)
{
if (value  != undefined)
{
 this.updUser = value;
    this.hmProperty["updUser"] = true;
}
}

/**
 * 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetUpdDate (value: string)
{
if (value  != undefined)
{
 this.updDate = value;
    this.hmProperty["updDate"] = true;
}
}

/**
 * 是否提交(说明:;字段类型:bit;字段长度:1;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetIsSubmit (value: boolean)
{
if (value  != undefined)
{
 this.isSubmit = value;
    this.hmProperty["isSubmit"] = true;
}
}

/**
 * 点赞统计(说明:;字段类型:int;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetOkCount (value: number)
{
if (value  != undefined)
{
 this.okCount = value;
    this.hmProperty["okCount"] = true;
}
}

/**
 * 引用统计(说明:;字段类型:int;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetCitationCount (value: number)
{
if (value  != undefined)
{
 this.citationCount = value;
    this.hmProperty["citationCount"] = true;
}
}

/**
 * 版本统计(说明:;字段类型:int;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetVersionCount (value: number)
{
if (value  != undefined)
{
 this.versionCount = value;
    this.hmProperty["versionCount"] = true;
}
}

/**
 * 教学班流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setid_CurrEduCls (value: string)
{
if (value  != undefined)
{
 this.id_CurrEduCls = value;
    this.hmProperty["id_CurrEduCls"] = true;
}
}

/**
 * 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetMemo (value: string)
{
if (value  != undefined)
{
 this.memo = value;
    this.hmProperty["memo"] = true;
}
}

/**
 * 评论数(说明:;字段类型:int;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetAppraiseCount (value: number)
{
if (value  != undefined)
{
 this.appraiseCount = value;
    this.hmProperty["appraiseCount"] = true;
}
}

/**
 * 评分(说明:;字段类型:float;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setscore (value: number)
{
if (value  != undefined)
{
 this.score = value;
    this.hmProperty["score"] = true;
}
}

/**
 * 学生平均分(说明:;字段类型:float;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetStuScore (value: number)
{
if (value  != undefined)
{
 this.stuScore = value;
    this.hmProperty["stuScore"] = true;
}
}

/**
 * 教师评分(说明:;字段类型:float;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetTeaScore (value: number)
{
if (value  != undefined)
{
 this.teaScore = value;
    this.hmProperty["teaScore"] = true;
}
}

/**
 * 引用Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetCitationId (value: string)
{
if (value  != undefined)
{
 this.citationId = value;
    this.hmProperty["citationId"] = true;
}
}

/**
 * 建立日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetCreateDate (value: string)
{
if (value  != undefined)
{
 this.createDate = value;
    this.hmProperty["createDate"] = true;
}
}

/**
 * 分享Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetShareId (value: string)
{
if (value  != undefined)
{
 this.shareId = value;
    this.hmProperty["shareId"] = true;
}
}

/**
 * Pdf内容(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetPdfContent (value: string)
{
if (value  != undefined)
{
 this.pdfContent = value;
    this.hmProperty["pdfContent"] = true;
}
}

/**
 * Pdf页码(说明:;字段类型:int;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetPdfPageNum (value: number)
{
if (value  != undefined)
{
 this.pdfPageNum = value;
    this.hmProperty["pdfPageNum"] = true;
}
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
case clsSysSocialRelationsEN.con_SocialId:
return this.socialId;
case clsSysSocialRelationsEN.con_FullName:
return this.fullName;
case clsSysSocialRelationsEN.con_Nationality:
return this.nationality;
case clsSysSocialRelationsEN.con_WorkUnit:
return this.workUnit;
case clsSysSocialRelationsEN.con_Major:
return this.major;
case clsSysSocialRelationsEN.con_Achievement:
return this.achievement;
case clsSysSocialRelationsEN.con_DetailedDescription:
return this.detailedDescription;
case clsSysSocialRelationsEN.con_LevelId:
return this.levelId;
case clsSysSocialRelationsEN.con_UpdUser:
return this.updUser;
case clsSysSocialRelationsEN.con_UpdDate:
return this.updDate;
case clsSysSocialRelationsEN.con_IsSubmit:
return this.isSubmit;
case clsSysSocialRelationsEN.con_OkCount:
return this.okCount;
case clsSysSocialRelationsEN.con_CitationCount:
return this.citationCount;
case clsSysSocialRelationsEN.con_VersionCount:
return this.versionCount;
case clsSysSocialRelationsEN.con_id_CurrEduCls:
return this.id_CurrEduCls;
case clsSysSocialRelationsEN.con_Memo:
return this.memo;
case clsSysSocialRelationsEN.con_AppraiseCount:
return this.appraiseCount;
case clsSysSocialRelationsEN.con_score:
return this.score;
case clsSysSocialRelationsEN.con_StuScore:
return this.stuScore;
case clsSysSocialRelationsEN.con_TeaScore:
return this.teaScore;
case clsSysSocialRelationsEN.con_CitationId:
return this.citationId;
case clsSysSocialRelationsEN.con_CreateDate:
return this.createDate;
case clsSysSocialRelationsEN.con_ShareId:
return this.shareId;
case clsSysSocialRelationsEN.con_PdfContent:
return this.pdfContent;
case clsSysSocialRelationsEN.con_PdfPageNum:
return this.pdfPageNum;
case "sf_UpdFldSetStr":
return this.sf_UpdFldSetStr;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[SysSocialRelations]中不存在！`;
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
case clsSysSocialRelationsEN.con_SocialId:
this.socialId = strValue;
    this.hmProperty["socialId"] = true;
break;
case clsSysSocialRelationsEN.con_FullName:
this.fullName = strValue;
    this.hmProperty["fullName"] = true;
break;
case clsSysSocialRelationsEN.con_Nationality:
this.nationality = strValue;
    this.hmProperty["nationality"] = true;
break;
case clsSysSocialRelationsEN.con_WorkUnit:
this.workUnit = strValue;
    this.hmProperty["workUnit"] = true;
break;
case clsSysSocialRelationsEN.con_Major:
this.major = strValue;
    this.hmProperty["major"] = true;
break;
case clsSysSocialRelationsEN.con_Achievement:
this.achievement = strValue;
    this.hmProperty["achievement"] = true;
break;
case clsSysSocialRelationsEN.con_DetailedDescription:
this.detailedDescription = strValue;
    this.hmProperty["detailedDescription"] = true;
break;
case clsSysSocialRelationsEN.con_LevelId:
this.levelId = strValue;
    this.hmProperty["levelId"] = true;
break;
case clsSysSocialRelationsEN.con_UpdUser:
this.updUser = strValue;
    this.hmProperty["updUser"] = true;
break;
case clsSysSocialRelationsEN.con_UpdDate:
this.updDate = strValue;
    this.hmProperty["updDate"] = true;
break;
case clsSysSocialRelationsEN.con_IsSubmit:
this.isSubmit = Boolean(strValue);
    this.hmProperty["isSubmit"] = true;
break;
case clsSysSocialRelationsEN.con_OkCount:
this.okCount = Number(strValue);
    this.hmProperty["okCount"] = true;
break;
case clsSysSocialRelationsEN.con_CitationCount:
this.citationCount = Number(strValue);
    this.hmProperty["citationCount"] = true;
break;
case clsSysSocialRelationsEN.con_VersionCount:
this.versionCount = Number(strValue);
    this.hmProperty["versionCount"] = true;
break;
case clsSysSocialRelationsEN.con_id_CurrEduCls:
this.id_CurrEduCls = strValue;
    this.hmProperty["id_CurrEduCls"] = true;
break;
case clsSysSocialRelationsEN.con_Memo:
this.memo = strValue;
    this.hmProperty["memo"] = true;
break;
case clsSysSocialRelationsEN.con_AppraiseCount:
this.appraiseCount = Number(strValue);
    this.hmProperty["appraiseCount"] = true;
break;
case clsSysSocialRelationsEN.con_score:
this.score = Number(strValue);
    this.hmProperty["score"] = true;
break;
case clsSysSocialRelationsEN.con_StuScore:
this.stuScore = Number(strValue);
    this.hmProperty["stuScore"] = true;
break;
case clsSysSocialRelationsEN.con_TeaScore:
this.teaScore = Number(strValue);
    this.hmProperty["teaScore"] = true;
break;
case clsSysSocialRelationsEN.con_CitationId:
this.citationId = strValue;
    this.hmProperty["citationId"] = true;
break;
case clsSysSocialRelationsEN.con_CreateDate:
this.createDate = strValue;
    this.hmProperty["createDate"] = true;
break;
case clsSysSocialRelationsEN.con_ShareId:
this.shareId = strValue;
    this.hmProperty["shareId"] = true;
break;
case clsSysSocialRelationsEN.con_PdfContent:
this.pdfContent = strValue;
    this.hmProperty["pdfContent"] = true;
break;
case clsSysSocialRelationsEN.con_PdfPageNum:
this.pdfPageNum = Number(strValue);
    this.hmProperty["pdfPageNum"] = true;
break;
case "sf_UpdFldSetStr":
this.sf_UpdFldSetStr = strValue;
break;
case "sf_FldComparisonOp":
this.sf_FldComparisonOp = strValue;
break;
default:
strMsg = `字段名:[${strFldName}]在表对象:[SysSocialRelations]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
console.error(strMsg);
break;
}
}

/**
 * 设置对象中公共属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
*/
public socialId = "";    //社会Id
public fullName = "";    //姓名
public nationality = "";    //国籍
public workUnit = "";    //工作单位
public major = "";    //专业
public achievement = "";    //成就
public detailedDescription = "";    //详细说明
public levelId = "";    //级别Id
public updUser = "";    //修改人
public updDate = "";    //修改日期
public isSubmit = false;    //是否提交
public okCount = 0;    //点赞统计
public citationCount = 0;    //引用统计
public versionCount = 0;    //版本统计
public id_CurrEduCls = "";    //教学班流水号
public memo = "";    //备注
public appraiseCount = 0;    //评论数
public score = 0.0;    //评分
public stuScore = 0.0;    //学生平均分
public teaScore = 0.0;    //教师评分
public citationId = "";    //引用Id
public createDate = "";    //建立日期
public shareId = "";    //分享Id
public pdfContent = "";    //Pdf内容
public pdfPageNum = 0;    //Pdf页码


 /**
 * 常量:"SocialId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SocialId(): string {return "socialId";}    //社会Id

 /**
 * 常量:"FullName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_FullName(): string {return "fullName";}    //姓名

 /**
 * 常量:"Nationality"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Nationality(): string {return "nationality";}    //国籍

 /**
 * 常量:"WorkUnit"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_WorkUnit(): string {return "workUnit";}    //工作单位

 /**
 * 常量:"Major"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Major(): string {return "major";}    //专业

 /**
 * 常量:"Achievement"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Achievement(): string {return "achievement";}    //成就

 /**
 * 常量:"DetailedDescription"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_DetailedDescription(): string {return "detailedDescription";}    //详细说明

 /**
 * 常量:"LevelId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_LevelId(): string {return "levelId";}    //级别Id

 /**
 * 常量:"UpdUser"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UpdUser(): string {return "updUser";}    //修改人

 /**
 * 常量:"UpdDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UpdDate(): string {return "updDate";}    //修改日期

 /**
 * 常量:"IsSubmit"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsSubmit(): string {return "isSubmit";}    //是否提交

 /**
 * 常量:"OkCount"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_OkCount(): string {return "okCount";}    //点赞统计

 /**
 * 常量:"CitationCount"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CitationCount(): string {return "citationCount";}    //引用统计

 /**
 * 常量:"VersionCount"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_VersionCount(): string {return "versionCount";}    //版本统计

 /**
 * 常量:"id_CurrEduCls"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_CurrEduCls(): string {return "id_CurrEduCls";}    //教学班流水号

 /**
 * 常量:"Memo"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Memo(): string {return "memo";}    //备注

 /**
 * 常量:"AppraiseCount"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_AppraiseCount(): string {return "appraiseCount";}    //评论数

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
 * 常量:"CitationId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CitationId(): string {return "citationId";}    //引用Id

 /**
 * 常量:"CreateDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CreateDate(): string {return "createDate";}    //建立日期

 /**
 * 常量:"ShareId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ShareId(): string {return "shareId";}    //分享Id

 /**
 * 常量:"PdfContent"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PdfContent(): string {return "pdfContent";}    //Pdf内容

 /**
 * 常量:"PdfPageNum"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PdfPageNum(): string {return "pdfPageNum";}    //Pdf页码

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