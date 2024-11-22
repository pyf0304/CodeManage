﻿
 /**
 * 类名:clsvRTPaperRelaEN
 * 表名:vRTPaperRela(01120583)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:55:12
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
 * vRTPaperRela(vRTPaperRela)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTabV } from '../../PubFun/clsGeneralTabV.js';

export class clsvRTPaperRelaEN extends clsGeneralTabV
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "02"; //客户端缓存
public static IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
public static WhereFormat = ""; //条件格式串
public static _CurrTabName= "vRTPaperRela"; //当前表名,与该类相关的表名
public static _KeyFldName= "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 20;
public static AttributeName = ["mId", "topicId", "paperId", "updDate", "updUser", "memo", "topicName", "topicContent", "topicProposePeople", "paperTitle", "paperContent", "author", "periodical", "isSubmit", "id_CurrEduCls", "paperDate", "paperStatusId", "paperTypeId", "paperUserId", "versionCount"];
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
case clsvRTPaperRelaEN.con_mId:
return this.mId;
case clsvRTPaperRelaEN.con_TopicId:
return this.topicId;
case clsvRTPaperRelaEN.con_PaperId:
return this.paperId;
case clsvRTPaperRelaEN.con_UpdDate:
return this.updDate;
case clsvRTPaperRelaEN.con_UpdUser:
return this.updUser;
case clsvRTPaperRelaEN.con_Memo:
return this.memo;
case clsvRTPaperRelaEN.con_TopicName:
return this.topicName;
case clsvRTPaperRelaEN.con_TopicContent:
return this.topicContent;
case clsvRTPaperRelaEN.con_TopicProposePeople:
return this.topicProposePeople;
case clsvRTPaperRelaEN.con_PaperTitle:
return this.paperTitle;
case clsvRTPaperRelaEN.con_PaperContent:
return this.paperContent;
case clsvRTPaperRelaEN.con_Author:
return this.author;
case clsvRTPaperRelaEN.con_Periodical:
return this.periodical;
case clsvRTPaperRelaEN.con_IsSubmit:
return this.isSubmit;
case clsvRTPaperRelaEN.con_id_CurrEduCls:
return this.id_CurrEduCls;
case clsvRTPaperRelaEN.con_PaperDate:
return this.paperDate;
case clsvRTPaperRelaEN.con_PaperStatusId:
return this.paperStatusId;
case clsvRTPaperRelaEN.con_PaperTypeId:
return this.paperTypeId;
case clsvRTPaperRelaEN.con_PaperUserId:
return this.paperUserId;
case clsvRTPaperRelaEN.con_VersionCount:
return this.versionCount;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[vRTPaperRela]中不存在！`;
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
case clsvRTPaperRelaEN.con_mId:
this.mId = Number(strValue);
break;
case clsvRTPaperRelaEN.con_TopicId:
this.topicId = strValue;
break;
case clsvRTPaperRelaEN.con_PaperId:
this.paperId = strValue;
break;
case clsvRTPaperRelaEN.con_UpdDate:
this.updDate = strValue;
break;
case clsvRTPaperRelaEN.con_UpdUser:
this.updUser = strValue;
break;
case clsvRTPaperRelaEN.con_Memo:
this.memo = strValue;
break;
case clsvRTPaperRelaEN.con_TopicName:
this.topicName = strValue;
break;
case clsvRTPaperRelaEN.con_TopicContent:
this.topicContent = strValue;
break;
case clsvRTPaperRelaEN.con_TopicProposePeople:
this.topicProposePeople = strValue;
break;
case clsvRTPaperRelaEN.con_PaperTitle:
this.paperTitle = strValue;
break;
case clsvRTPaperRelaEN.con_PaperContent:
this.paperContent = strValue;
break;
case clsvRTPaperRelaEN.con_Author:
this.author = strValue;
break;
case clsvRTPaperRelaEN.con_Periodical:
this.periodical = strValue;
break;
case clsvRTPaperRelaEN.con_IsSubmit:
this.isSubmit = Boolean(strValue);
break;
case clsvRTPaperRelaEN.con_id_CurrEduCls:
this.id_CurrEduCls = strValue;
break;
case clsvRTPaperRelaEN.con_PaperDate:
this.paperDate = strValue;
break;
case clsvRTPaperRelaEN.con_PaperStatusId:
this.paperStatusId = strValue;
break;
case clsvRTPaperRelaEN.con_PaperTypeId:
this.paperTypeId = strValue;
break;
case clsvRTPaperRelaEN.con_PaperUserId:
this.paperUserId = strValue;
break;
case clsvRTPaperRelaEN.con_VersionCount:
this.versionCount = Number(strValue);
break;
case "sf_FldComparisonOp":
this.sf_FldComparisonOp = strValue;
break;
default:
strMsg = `字段名:[${strFldName}]在表对象:[vRTPaperRela]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
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
public paperId = "";    //论文Id
public updDate = "";    //修改日期
public updUser = "";    //修改人
public memo = "";    //备注
public topicName = "";    //栏目主题
public topicContent = "";    //主题内容
public topicProposePeople = "";    //主题提出人
public paperTitle = "";    //论文标题
public paperContent = "";    //主题内容
public author = "";    //作者
public periodical = "";    //期刊
public isSubmit = false;    //是否提交
public id_CurrEduCls = "";    //教学班流水号
public paperDate = "";    //PaperDate
public paperStatusId = "";    //论文状态Id
public paperTypeId = "";    //论文类型Id
public paperUserId = "";    //PaperUserId
public versionCount = 0;    //版本统计


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
 * 常量:"PaperId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PaperId(): string {return "paperId";}    //论文Id

 /**
 * 常量:"UpdDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UpdDate(): string {return "updDate";}    //修改日期

 /**
 * 常量:"UpdUser"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UpdUser(): string {return "updUser";}    //修改人

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
 * 常量:"TopicProposePeople"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_TopicProposePeople(): string {return "topicProposePeople";}    //主题提出人

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
 * 常量:"Author"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Author(): string {return "author";}    //作者

 /**
 * 常量:"Periodical"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Periodical(): string {return "periodical";}    //期刊

 /**
 * 常量:"IsSubmit"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsSubmit(): string {return "isSubmit";}    //是否提交

 /**
 * 常量:"id_CurrEduCls"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_CurrEduCls(): string {return "id_CurrEduCls";}    //教学班流水号

 /**
 * 常量:"PaperDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PaperDate(): string {return "paperDate";}    //PaperDate

 /**
 * 常量:"PaperStatusId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PaperStatusId(): string {return "paperStatusId";}    //论文状态Id

 /**
 * 常量:"PaperTypeId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PaperTypeId(): string {return "paperTypeId";}    //论文类型Id

 /**
 * 常量:"PaperUserId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PaperUserId(): string {return "paperUserId";}    //PaperUserId

 /**
 * 常量:"VersionCount"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_VersionCount(): string {return "versionCount";}    //版本统计

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