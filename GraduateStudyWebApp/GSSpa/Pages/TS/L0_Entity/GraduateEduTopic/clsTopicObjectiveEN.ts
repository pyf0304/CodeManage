
 /**
 * 类名:clsTopicObjectiveEN
 * 表名:TopicObjective(01120613)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:51
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
 * 主题客观表(TopicObjective)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTab } from '../../PubFun/clsGeneralTab.js';

export class clsTopicObjectiveEN extends clsGeneralTab
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "04"; //sessionStorage
public static _CurrTabName= "TopicObjective"; //当前表名,与该类相关的表名
public static _KeyFldName= "TopicObjectiveId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 22;
public static AttributeName = ["topicObjectiveId", "objectiveName", "objectiveContent", "objectiveType", "sourceId", "conclusion", "isSubmit", "appraiseCount", "okCount", "score", "stuScore", "teaScore", "id_CurrEduCls", "pdfContent", "pdfPageNum", "citationCount", "versionCount", "createDate", "shareId", "updUser", "updDate", "memo"];
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
private mstrTopicObjectiveId = "";    //客观Id
private mstrObjectiveName = "";    //客观名称
private mstrObjectiveContent = "";    //客观内容
private mstrObjectiveType = "";    //客观类型
private mstrSourceId = "";    //来源Id
private mstrConclusion = "";    //结论
private mbolIsSubmit = false;    //是否提交
private mintAppraiseCount = 0;    //评论数
private mintOkCount = 0;    //点赞统计
private mfltscore = 0.0;    //评分
private mfltStuScore = 0.0;    //学生平均分
private mfltTeaScore = 0.0;    //教师评分
private mstrid_CurrEduCls = "";    //教学班流水号
private mstrPdfContent = "";    //Pdf内容
private mintPdfPageNum = 0;    //Pdf页码
private mintCitationCount = 0;    //引用统计
private mintVersionCount = 0;    //版本统计
private mstrCreateDate = "";    //建立日期
private mstrShareId = "";    //分享Id
private mstrUpdUser = "";    //修改人
private mstrUpdDate = "";    //修改日期
private mstrMemo = "";    //备注

/**
 * 客观Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetTopicObjectiveId (value: string)
{
if (value  != undefined)
{
 this.topicObjectiveId = value;
    this.hmProperty["topicObjectiveId"] = true;
}
}

/**
 * 客观名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetObjectiveName (value: string)
{
if (value  != undefined)
{
 this.objectiveName = value;
    this.hmProperty["objectiveName"] = true;
}
}

/**
 * 客观内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetObjectiveContent (value: string)
{
if (value  != undefined)
{
 this.objectiveContent = value;
    this.hmProperty["objectiveContent"] = true;
}
}

/**
 * 客观类型(说明:;字段类型:char;字段长度:2;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetObjectiveType (value: string)
{
if (value  != undefined)
{
 this.objectiveType = value;
    this.hmProperty["objectiveType"] = true;
}
}

/**
 * 来源Id(说明:;字段类型:char;字段长度:10;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetSourceId (value: string)
{
if (value  != undefined)
{
 this.sourceId = value;
    this.hmProperty["sourceId"] = true;
}
}

/**
 * 结论(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetConclusion (value: string)
{
if (value  != undefined)
{
 this.conclusion = value;
    this.hmProperty["conclusion"] = true;
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
case clsTopicObjectiveEN.con_TopicObjectiveId:
return this.topicObjectiveId;
case clsTopicObjectiveEN.con_ObjectiveName:
return this.objectiveName;
case clsTopicObjectiveEN.con_ObjectiveContent:
return this.objectiveContent;
case clsTopicObjectiveEN.con_ObjectiveType:
return this.objectiveType;
case clsTopicObjectiveEN.con_SourceId:
return this.sourceId;
case clsTopicObjectiveEN.con_Conclusion:
return this.conclusion;
case clsTopicObjectiveEN.con_IsSubmit:
return this.isSubmit;
case clsTopicObjectiveEN.con_AppraiseCount:
return this.appraiseCount;
case clsTopicObjectiveEN.con_OkCount:
return this.okCount;
case clsTopicObjectiveEN.con_score:
return this.score;
case clsTopicObjectiveEN.con_StuScore:
return this.stuScore;
case clsTopicObjectiveEN.con_TeaScore:
return this.teaScore;
case clsTopicObjectiveEN.con_id_CurrEduCls:
return this.id_CurrEduCls;
case clsTopicObjectiveEN.con_PdfContent:
return this.pdfContent;
case clsTopicObjectiveEN.con_PdfPageNum:
return this.pdfPageNum;
case clsTopicObjectiveEN.con_CitationCount:
return this.citationCount;
case clsTopicObjectiveEN.con_VersionCount:
return this.versionCount;
case clsTopicObjectiveEN.con_CreateDate:
return this.createDate;
case clsTopicObjectiveEN.con_ShareId:
return this.shareId;
case clsTopicObjectiveEN.con_UpdUser:
return this.updUser;
case clsTopicObjectiveEN.con_UpdDate:
return this.updDate;
case clsTopicObjectiveEN.con_Memo:
return this.memo;
case "sf_UpdFldSetStr":
return this.sf_UpdFldSetStr;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[TopicObjective]中不存在！`;
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
case clsTopicObjectiveEN.con_TopicObjectiveId:
this.topicObjectiveId = strValue;
    this.hmProperty["topicObjectiveId"] = true;
break;
case clsTopicObjectiveEN.con_ObjectiveName:
this.objectiveName = strValue;
    this.hmProperty["objectiveName"] = true;
break;
case clsTopicObjectiveEN.con_ObjectiveContent:
this.objectiveContent = strValue;
    this.hmProperty["objectiveContent"] = true;
break;
case clsTopicObjectiveEN.con_ObjectiveType:
this.objectiveType = strValue;
    this.hmProperty["objectiveType"] = true;
break;
case clsTopicObjectiveEN.con_SourceId:
this.sourceId = strValue;
    this.hmProperty["sourceId"] = true;
break;
case clsTopicObjectiveEN.con_Conclusion:
this.conclusion = strValue;
    this.hmProperty["conclusion"] = true;
break;
case clsTopicObjectiveEN.con_IsSubmit:
this.isSubmit = Boolean(strValue);
    this.hmProperty["isSubmit"] = true;
break;
case clsTopicObjectiveEN.con_AppraiseCount:
this.appraiseCount = Number(strValue);
    this.hmProperty["appraiseCount"] = true;
break;
case clsTopicObjectiveEN.con_OkCount:
this.okCount = Number(strValue);
    this.hmProperty["okCount"] = true;
break;
case clsTopicObjectiveEN.con_score:
this.score = Number(strValue);
    this.hmProperty["score"] = true;
break;
case clsTopicObjectiveEN.con_StuScore:
this.stuScore = Number(strValue);
    this.hmProperty["stuScore"] = true;
break;
case clsTopicObjectiveEN.con_TeaScore:
this.teaScore = Number(strValue);
    this.hmProperty["teaScore"] = true;
break;
case clsTopicObjectiveEN.con_id_CurrEduCls:
this.id_CurrEduCls = strValue;
    this.hmProperty["id_CurrEduCls"] = true;
break;
case clsTopicObjectiveEN.con_PdfContent:
this.pdfContent = strValue;
    this.hmProperty["pdfContent"] = true;
break;
case clsTopicObjectiveEN.con_PdfPageNum:
this.pdfPageNum = Number(strValue);
    this.hmProperty["pdfPageNum"] = true;
break;
case clsTopicObjectiveEN.con_CitationCount:
this.citationCount = Number(strValue);
    this.hmProperty["citationCount"] = true;
break;
case clsTopicObjectiveEN.con_VersionCount:
this.versionCount = Number(strValue);
    this.hmProperty["versionCount"] = true;
break;
case clsTopicObjectiveEN.con_CreateDate:
this.createDate = strValue;
    this.hmProperty["createDate"] = true;
break;
case clsTopicObjectiveEN.con_ShareId:
this.shareId = strValue;
    this.hmProperty["shareId"] = true;
break;
case clsTopicObjectiveEN.con_UpdUser:
this.updUser = strValue;
    this.hmProperty["updUser"] = true;
break;
case clsTopicObjectiveEN.con_UpdDate:
this.updDate = strValue;
    this.hmProperty["updDate"] = true;
break;
case clsTopicObjectiveEN.con_Memo:
this.memo = strValue;
    this.hmProperty["memo"] = true;
break;
case "sf_UpdFldSetStr":
this.sf_UpdFldSetStr = strValue;
break;
case "sf_FldComparisonOp":
this.sf_FldComparisonOp = strValue;
break;
default:
strMsg = `字段名:[${strFldName}]在表对象:[TopicObjective]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
console.error(strMsg);
break;
}
}

/**
 * 设置对象中公共属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
*/
public topicObjectiveId = "";    //客观Id
public objectiveName = "";    //客观名称
public objectiveContent = "";    //客观内容
public objectiveType = "";    //客观类型
public sourceId = "";    //来源Id
public conclusion = "";    //结论
public isSubmit = false;    //是否提交
public appraiseCount = 0;    //评论数
public okCount = 0;    //点赞统计
public score = 0.0;    //评分
public stuScore = 0.0;    //学生平均分
public teaScore = 0.0;    //教师评分
public id_CurrEduCls = "";    //教学班流水号
public pdfContent = "";    //Pdf内容
public pdfPageNum = 0;    //Pdf页码
public citationCount = 0;    //引用统计
public versionCount = 0;    //版本统计
public createDate = "";    //建立日期
public shareId = "";    //分享Id
public updUser = "";    //修改人
public updDate = "";    //修改日期
public memo = "";    //备注


 /**
 * 常量:"TopicObjectiveId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_TopicObjectiveId(): string {return "topicObjectiveId";}    //客观Id

 /**
 * 常量:"ObjectiveName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ObjectiveName(): string {return "objectiveName";}    //客观名称

 /**
 * 常量:"ObjectiveContent"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ObjectiveContent(): string {return "objectiveContent";}    //客观内容

 /**
 * 常量:"ObjectiveType"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ObjectiveType(): string {return "objectiveType";}    //客观类型

 /**
 * 常量:"SourceId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SourceId(): string {return "sourceId";}    //来源Id

 /**
 * 常量:"Conclusion"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Conclusion(): string {return "conclusion";}    //结论

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
 * 常量:"OkCount"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_OkCount(): string {return "okCount";}    //点赞统计

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
 * 常量:"id_CurrEduCls"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_CurrEduCls(): string {return "id_CurrEduCls";}    //教学班流水号

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