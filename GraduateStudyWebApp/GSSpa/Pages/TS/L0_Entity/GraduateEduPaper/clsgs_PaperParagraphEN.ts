﻿
 /**
 * 类名:clsgs_PaperParagraphEN
 * 表名:gs_PaperParagraph(01120744)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:39
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
 * 论文段落表(gs_PaperParagraph)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTab } from '../../PubFun/clsGeneralTab.js';

export class clsgs_PaperParagraphEN extends clsGeneralTab
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "02"; //客户端缓存
public static _CurrTabName= "gs_PaperParagraph"; //当前表名,与该类相关的表名
public static _KeyFldName= "ParagraphId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 15;
public static AttributeName = ["paragraphId", "paperId", "sectionId", "paragraphStateId", "paragraphTypeId", "paragraphContent", "voteCount", "commentCount", "versionCount", "createDate", "createUser", "updDate", "updUser", "memo", "orderNum"];
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
private mstrParagraphId = "";    //段落Id
private mstrPaperId = "";    //论文Id
private mstrSectionId = "";    //节Id
private mstrParagraphStateId = "";    //段落状态Id
private mstrParagraphTypeId = "";    //段落类型Id
private mstrParagraphContent = "";    //段落内容
private mintVoteCount = 0;    //点赞计数
private mintCommentCount = 0;    //评论数
private mintVersionCount = 0;    //版本统计
private mstrCreateDate = "";    //建立日期
private mstrCreateUser = "";    //建立用户
private mstrUpdDate = "";    //修改日期
private mstrUpdUser = "";    //修改人
private mstrMemo = "";    //备注
private mintOrderNum = 0;    //序号

/**
 * 段落Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetParagraphId (value: string)
{
if (value  != undefined)
{
 this.paragraphId = value;
    this.hmProperty["paragraphId"] = true;
}
}

/**
 * 论文Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetPaperId (value: string)
{
if (value  != undefined)
{
 this.paperId = value;
    this.hmProperty["paperId"] = true;
}
}

/**
 * 节Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetSectionId (value: string)
{
if (value  != undefined)
{
 this.sectionId = value;
    this.hmProperty["sectionId"] = true;
}
}

/**
 * 段落状态Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetParagraphStateId (value: string)
{
if (value  != undefined)
{
 this.paragraphStateId = value;
    this.hmProperty["paragraphStateId"] = true;
}
}

/**
 * 段落类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetParagraphTypeId (value: string)
{
if (value  != undefined)
{
 this.paragraphTypeId = value;
    this.hmProperty["paragraphTypeId"] = true;
}
}

/**
 * 段落内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetParagraphContent (value: string)
{
if (value  != undefined)
{
 this.paragraphContent = value;
    this.hmProperty["paragraphContent"] = true;
}
}

/**
 * 点赞计数(说明:;字段类型:int;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetVoteCount (value: number)
{
if (value  != undefined)
{
 this.voteCount = value;
    this.hmProperty["voteCount"] = true;
}
}

/**
 * 评论数(说明:;字段类型:int;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetCommentCount (value: number)
{
if (value  != undefined)
{
 this.commentCount = value;
    this.hmProperty["commentCount"] = true;
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
 * 建立用户(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetCreateUser (value: string)
{
if (value  != undefined)
{
 this.createUser = value;
    this.hmProperty["createUser"] = true;
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
 * 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetOrderNum (value: number)
{
if (value  != undefined)
{
 this.orderNum = value;
    this.hmProperty["orderNum"] = true;
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
case clsgs_PaperParagraphEN.con_ParagraphId:
return this.paragraphId;
case clsgs_PaperParagraphEN.con_PaperId:
return this.paperId;
case clsgs_PaperParagraphEN.con_SectionId:
return this.sectionId;
case clsgs_PaperParagraphEN.con_ParagraphStateId:
return this.paragraphStateId;
case clsgs_PaperParagraphEN.con_ParagraphTypeId:
return this.paragraphTypeId;
case clsgs_PaperParagraphEN.con_ParagraphContent:
return this.paragraphContent;
case clsgs_PaperParagraphEN.con_VoteCount:
return this.voteCount;
case clsgs_PaperParagraphEN.con_CommentCount:
return this.commentCount;
case clsgs_PaperParagraphEN.con_VersionCount:
return this.versionCount;
case clsgs_PaperParagraphEN.con_CreateDate:
return this.createDate;
case clsgs_PaperParagraphEN.con_CreateUser:
return this.createUser;
case clsgs_PaperParagraphEN.con_UpdDate:
return this.updDate;
case clsgs_PaperParagraphEN.con_UpdUser:
return this.updUser;
case clsgs_PaperParagraphEN.con_Memo:
return this.memo;
case clsgs_PaperParagraphEN.con_OrderNum:
return this.orderNum;
case "sf_UpdFldSetStr":
return this.sf_UpdFldSetStr;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[gs_PaperParagraph]中不存在！`;
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
case clsgs_PaperParagraphEN.con_ParagraphId:
this.paragraphId = strValue;
    this.hmProperty["paragraphId"] = true;
break;
case clsgs_PaperParagraphEN.con_PaperId:
this.paperId = strValue;
    this.hmProperty["paperId"] = true;
break;
case clsgs_PaperParagraphEN.con_SectionId:
this.sectionId = strValue;
    this.hmProperty["sectionId"] = true;
break;
case clsgs_PaperParagraphEN.con_ParagraphStateId:
this.paragraphStateId = strValue;
    this.hmProperty["paragraphStateId"] = true;
break;
case clsgs_PaperParagraphEN.con_ParagraphTypeId:
this.paragraphTypeId = strValue;
    this.hmProperty["paragraphTypeId"] = true;
break;
case clsgs_PaperParagraphEN.con_ParagraphContent:
this.paragraphContent = strValue;
    this.hmProperty["paragraphContent"] = true;
break;
case clsgs_PaperParagraphEN.con_VoteCount:
this.voteCount = Number(strValue);
    this.hmProperty["voteCount"] = true;
break;
case clsgs_PaperParagraphEN.con_CommentCount:
this.commentCount = Number(strValue);
    this.hmProperty["commentCount"] = true;
break;
case clsgs_PaperParagraphEN.con_VersionCount:
this.versionCount = Number(strValue);
    this.hmProperty["versionCount"] = true;
break;
case clsgs_PaperParagraphEN.con_CreateDate:
this.createDate = strValue;
    this.hmProperty["createDate"] = true;
break;
case clsgs_PaperParagraphEN.con_CreateUser:
this.createUser = strValue;
    this.hmProperty["createUser"] = true;
break;
case clsgs_PaperParagraphEN.con_UpdDate:
this.updDate = strValue;
    this.hmProperty["updDate"] = true;
break;
case clsgs_PaperParagraphEN.con_UpdUser:
this.updUser = strValue;
    this.hmProperty["updUser"] = true;
break;
case clsgs_PaperParagraphEN.con_Memo:
this.memo = strValue;
    this.hmProperty["memo"] = true;
break;
case clsgs_PaperParagraphEN.con_OrderNum:
this.orderNum = Number(strValue);
    this.hmProperty["orderNum"] = true;
break;
case "sf_UpdFldSetStr":
this.sf_UpdFldSetStr = strValue;
break;
case "sf_FldComparisonOp":
this.sf_FldComparisonOp = strValue;
break;
default:
strMsg = `字段名:[${strFldName}]在表对象:[gs_PaperParagraph]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
console.error(strMsg);
break;
}
}

/**
 * 设置对象中公共属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
*/
public paragraphId = "";    //段落Id
public paperId = "";    //论文Id
public sectionId = "";    //节Id
public paragraphStateId = "";    //段落状态Id
public paragraphTypeId = "";    //段落类型Id
public paragraphContent = "";    //段落内容
public voteCount = 0;    //点赞计数
public commentCount = 0;    //评论数
public versionCount = 0;    //版本统计
public createDate = "";    //建立日期
public createUser = "";    //建立用户
public updDate = "";    //修改日期
public updUser = "";    //修改人
public memo = "";    //备注
public orderNum = 0;    //序号


 /**
 * 常量:"ParagraphId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ParagraphId(): string {return "paragraphId";}    //段落Id

 /**
 * 常量:"PaperId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PaperId(): string {return "paperId";}    //论文Id

 /**
 * 常量:"SectionId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SectionId(): string {return "sectionId";}    //节Id

 /**
 * 常量:"ParagraphStateId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ParagraphStateId(): string {return "paragraphStateId";}    //段落状态Id

 /**
 * 常量:"ParagraphTypeId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ParagraphTypeId(): string {return "paragraphTypeId";}    //段落类型Id

 /**
 * 常量:"ParagraphContent"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ParagraphContent(): string {return "paragraphContent";}    //段落内容

 /**
 * 常量:"VoteCount"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_VoteCount(): string {return "voteCount";}    //点赞计数

 /**
 * 常量:"CommentCount"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CommentCount(): string {return "commentCount";}    //评论数

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
 * 常量:"CreateUser"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CreateUser(): string {return "createUser";}    //建立用户

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
 * 常量:"OrderNum"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_OrderNum(): string {return "orderNum";}    //序号

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