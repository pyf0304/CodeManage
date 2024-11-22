﻿
 /**
 * 类名:clsvRTConceptRelaEN
 * 表名:vRTConceptRela(01120607)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:46:30
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
 * vRTConceptRela(vRTConceptRela)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTabV } from '../../PubFun/clsGeneralTabV.js';

export class clsvRTConceptRelaEN extends clsGeneralTabV
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "02"; //客户端缓存
public static IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
public static WhereFormat = ""; //条件格式串
public static _CurrTabName= "vRTConceptRela"; //当前表名,与该类相关的表名
public static _KeyFldName= "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 29;
public static AttributeName = ["mId", "topicId", "conceptId", "updDate", "memo", "topicName", "topicContent", "orderNum", "topicProposePeople", "conceptContent", "conceptName", "appraiseCount", "citationCount", "citationId", "isSubmit", "score", "stuScore", "teaScore", "concepDate", "concepUserId", "id_CurrEduCls", "pdfContent", "pdfPageNum", "okCount", "versionCount", "createDate", "shareId", "updUser", "classificationId"];
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
case clsvRTConceptRelaEN.con_mId:
return this.mId;
case clsvRTConceptRelaEN.con_TopicId:
return this.topicId;
case clsvRTConceptRelaEN.con_ConceptId:
return this.conceptId;
case clsvRTConceptRelaEN.con_UpdDate:
return this.updDate;
case clsvRTConceptRelaEN.con_Memo:
return this.memo;
case clsvRTConceptRelaEN.con_TopicName:
return this.topicName;
case clsvRTConceptRelaEN.con_TopicContent:
return this.topicContent;
case clsvRTConceptRelaEN.con_OrderNum:
return this.orderNum;
case clsvRTConceptRelaEN.con_TopicProposePeople:
return this.topicProposePeople;
case clsvRTConceptRelaEN.con_ConceptContent:
return this.conceptContent;
case clsvRTConceptRelaEN.con_ConceptName:
return this.conceptName;
case clsvRTConceptRelaEN.con_AppraiseCount:
return this.appraiseCount;
case clsvRTConceptRelaEN.con_CitationCount:
return this.citationCount;
case clsvRTConceptRelaEN.con_CitationId:
return this.citationId;
case clsvRTConceptRelaEN.con_IsSubmit:
return this.isSubmit;
case clsvRTConceptRelaEN.con_Score:
return this.score;
case clsvRTConceptRelaEN.con_StuScore:
return this.stuScore;
case clsvRTConceptRelaEN.con_TeaScore:
return this.teaScore;
case clsvRTConceptRelaEN.con_ConcepDate:
return this.concepDate;
case clsvRTConceptRelaEN.con_ConcepUserId:
return this.concepUserId;
case clsvRTConceptRelaEN.con_id_CurrEduCls:
return this.id_CurrEduCls;
case clsvRTConceptRelaEN.con_PdfContent:
return this.pdfContent;
case clsvRTConceptRelaEN.con_PdfPageNum:
return this.pdfPageNum;
case clsvRTConceptRelaEN.con_OkCount:
return this.okCount;
case clsvRTConceptRelaEN.con_VersionCount:
return this.versionCount;
case clsvRTConceptRelaEN.con_CreateDate:
return this.createDate;
case clsvRTConceptRelaEN.con_ShareId:
return this.shareId;
case clsvRTConceptRelaEN.con_UpdUser:
return this.updUser;
case clsvRTConceptRelaEN.con_ClassificationId:
return this.classificationId;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[vRTConceptRela]中不存在！`;
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
case clsvRTConceptRelaEN.con_mId:
this.mId = Number(strValue);
break;
case clsvRTConceptRelaEN.con_TopicId:
this.topicId = strValue;
break;
case clsvRTConceptRelaEN.con_ConceptId:
this.conceptId = strValue;
break;
case clsvRTConceptRelaEN.con_UpdDate:
this.updDate = strValue;
break;
case clsvRTConceptRelaEN.con_Memo:
this.memo = strValue;
break;
case clsvRTConceptRelaEN.con_TopicName:
this.topicName = strValue;
break;
case clsvRTConceptRelaEN.con_TopicContent:
this.topicContent = strValue;
break;
case clsvRTConceptRelaEN.con_OrderNum:
this.orderNum = Number(strValue);
break;
case clsvRTConceptRelaEN.con_TopicProposePeople:
this.topicProposePeople = strValue;
break;
case clsvRTConceptRelaEN.con_ConceptContent:
this.conceptContent = strValue;
break;
case clsvRTConceptRelaEN.con_ConceptName:
this.conceptName = strValue;
break;
case clsvRTConceptRelaEN.con_AppraiseCount:
this.appraiseCount = Number(strValue);
break;
case clsvRTConceptRelaEN.con_CitationCount:
this.citationCount = Number(strValue);
break;
case clsvRTConceptRelaEN.con_CitationId:
this.citationId = strValue;
break;
case clsvRTConceptRelaEN.con_IsSubmit:
this.isSubmit = Boolean(strValue);
break;
case clsvRTConceptRelaEN.con_Score:
this.score = Number(strValue);
break;
case clsvRTConceptRelaEN.con_StuScore:
this.stuScore = Number(strValue);
break;
case clsvRTConceptRelaEN.con_TeaScore:
this.teaScore = Number(strValue);
break;
case clsvRTConceptRelaEN.con_ConcepDate:
this.concepDate = strValue;
break;
case clsvRTConceptRelaEN.con_ConcepUserId:
this.concepUserId = strValue;
break;
case clsvRTConceptRelaEN.con_id_CurrEduCls:
this.id_CurrEduCls = strValue;
break;
case clsvRTConceptRelaEN.con_PdfContent:
this.pdfContent = strValue;
break;
case clsvRTConceptRelaEN.con_PdfPageNum:
this.pdfPageNum = Number(strValue);
break;
case clsvRTConceptRelaEN.con_OkCount:
this.okCount = Number(strValue);
break;
case clsvRTConceptRelaEN.con_VersionCount:
this.versionCount = Number(strValue);
break;
case clsvRTConceptRelaEN.con_CreateDate:
this.createDate = strValue;
break;
case clsvRTConceptRelaEN.con_ShareId:
this.shareId = strValue;
break;
case clsvRTConceptRelaEN.con_UpdUser:
this.updUser = strValue;
break;
case clsvRTConceptRelaEN.con_ClassificationId:
this.classificationId = strValue;
break;
case "sf_FldComparisonOp":
this.sf_FldComparisonOp = strValue;
break;
default:
strMsg = `字段名:[${strFldName}]在表对象:[vRTConceptRela]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
console.error(strMsg);
break;
}
}

/**
 * 设置对象中公共属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
*/
public mId = 0;    //mId
public topicId = "";    //主题Id
public conceptId = "";    //概念Id
public updDate = "";    //修改日期
public memo = "";    //备注
public topicName = "";    //栏目主题
public topicContent = "";    //主题内容
public orderNum = 0;    //序号
public topicProposePeople = "";    //主题提出人
public conceptContent = "";    //概念内容
public conceptName = "";    //概念名称
public appraiseCount = 0;    //评论数
public citationCount = 0;    //引用统计
public citationId = "";    //引用Id
public isSubmit = false;    //是否提交
public score = 0.0;    //评分
public stuScore = 0.0;    //学生平均分
public teaScore = 0.0;    //教师评分
public concepDate = "";    //ConcepDate
public concepUserId = "";    //ConcepUserId
public id_CurrEduCls = "";    //教学班流水号
public pdfContent = "";    //Pdf内容
public pdfPageNum = 0;    //Pdf页码
public okCount = 0;    //点赞统计
public versionCount = 0;    //版本统计
public createDate = "";    //建立日期
public shareId = "";    //分享Id
public updUser = "";    //修改人
public classificationId = "";    //分类Id


 /**
 * 常量:"mId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_mId(): string {return "mId";}    //mId

 /**
 * 常量:"TopicId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_TopicId(): string {return "topicId";}    //主题Id

 /**
 * 常量:"ConceptId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ConceptId(): string {return "conceptId";}    //概念Id

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
 * 常量:"TopicName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_TopicName(): string {return "topicName";}    //栏目主题

 /**
 * 常量:"TopicContent"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_TopicContent(): string {return "topicContent";}    //主题内容

 /**
 * 常量:"OrderNum"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_OrderNum(): string {return "orderNum";}    //序号

 /**
 * 常量:"TopicProposePeople"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_TopicProposePeople(): string {return "topicProposePeople";}    //主题提出人

 /**
 * 常量:"ConceptContent"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ConceptContent(): string {return "conceptContent";}    //概念内容

 /**
 * 常量:"ConceptName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ConceptName(): string {return "conceptName";}    //概念名称

 /**
 * 常量:"AppraiseCount"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_AppraiseCount(): string {return "appraiseCount";}    //评论数

 /**
 * 常量:"CitationCount"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CitationCount(): string {return "citationCount";}    //引用统计

 /**
 * 常量:"CitationId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CitationId(): string {return "citationId";}    //引用Id

 /**
 * 常量:"IsSubmit"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsSubmit(): string {return "isSubmit";}    //是否提交

 /**
 * 常量:"Score"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Score(): string {return "score";}    //评分

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
 * 常量:"ConcepDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ConcepDate(): string {return "concepDate";}    //ConcepDate

 /**
 * 常量:"ConcepUserId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ConcepUserId(): string {return "concepUserId";}    //ConcepUserId

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
 * 常量:"OkCount"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_OkCount(): string {return "okCount";}    //点赞统计

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
 * 常量:"ClassificationId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ClassificationId(): string {return "classificationId";}    //分类Id

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