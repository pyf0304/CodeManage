﻿
 /**
 * 类名:clsFeedBackEN
 * 表名:FeedBack(01120279)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:17
 * 生成者:pyf
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:新闻公告(NewsAnnouncement)
 * 框架-层名:实体层(TS)(EntityLayer)
 * 编程语言:TypeScript
 **/
 /**
 * 反馈意见(FeedBack)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTab } from '../../PubFun/clsGeneralTab.js';

export class clsFeedBackEN extends clsGeneralTab
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "05"; //未知
public static _CurrTabName= "FeedBack"; //当前表名,与该类相关的表名
public static _KeyFldName= "feedBackId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 9;
public static AttributeName = ["feedBackId", "nickName", "feedBackNumber", "feedBackContent", "email", "telephone", "updDate", "memo", "updUser"];
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
private mlngFeedBackId = 0;    //feedBackId
private mstrNickName = "";    //昵称
private mstrFeedBackNumber = "";    //feedBackNumber
private mstrFeedBackContent = "";    //feedBackContent
private mstrEmail = "";    //电子邮箱
private mstrTelephone = "";    //telephone
private mstrUpdDate = "";    //修改日期
private mstrMemo = "";    //备注
private mstrUpdUser = "";    //修改人

/**
 * feedBackId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetFeedBackId (value: number)
{
if (value  != undefined)
{
 this.feedBackId = value;
    this.hmProperty["feedBackId"] = true;
}
}

/**
 * 昵称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetNickName (value: string)
{
if (value  != undefined)
{
 this.nickName = value;
    this.hmProperty["nickName"] = true;
}
}

/**
 * feedBackNumber(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetFeedBackNumber (value: string)
{
if (value  != undefined)
{
 this.feedBackNumber = value;
    this.hmProperty["feedBackNumber"] = true;
}
}

/**
 * feedBackContent(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetFeedBackContent (value: string)
{
if (value  != undefined)
{
 this.feedBackContent = value;
    this.hmProperty["feedBackContent"] = true;
}
}

/**
 * 电子邮箱(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetEmail (value: string)
{
if (value  != undefined)
{
 this.email = value;
    this.hmProperty["email"] = true;
}
}

/**
 * telephone(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetTelephone (value: string)
{
if (value  != undefined)
{
 this.telephone = value;
    this.hmProperty["telephone"] = true;
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
case clsFeedBackEN.con_FeedBackId:
return this.feedBackId;
case clsFeedBackEN.con_NickName:
return this.nickName;
case clsFeedBackEN.con_FeedBackNumber:
return this.feedBackNumber;
case clsFeedBackEN.con_FeedBackContent:
return this.feedBackContent;
case clsFeedBackEN.con_Email:
return this.email;
case clsFeedBackEN.con_Telephone:
return this.telephone;
case clsFeedBackEN.con_UpdDate:
return this.updDate;
case clsFeedBackEN.con_Memo:
return this.memo;
case clsFeedBackEN.con_UpdUser:
return this.updUser;
case "sf_UpdFldSetStr":
return this.sf_UpdFldSetStr;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[FeedBack]中不存在！`;
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
case clsFeedBackEN.con_FeedBackId:
this.feedBackId = Number(strValue);
    this.hmProperty["feedBackId"] = true;
break;
case clsFeedBackEN.con_NickName:
this.nickName = strValue;
    this.hmProperty["nickName"] = true;
break;
case clsFeedBackEN.con_FeedBackNumber:
this.feedBackNumber = strValue;
    this.hmProperty["feedBackNumber"] = true;
break;
case clsFeedBackEN.con_FeedBackContent:
this.feedBackContent = strValue;
    this.hmProperty["feedBackContent"] = true;
break;
case clsFeedBackEN.con_Email:
this.email = strValue;
    this.hmProperty["email"] = true;
break;
case clsFeedBackEN.con_Telephone:
this.telephone = strValue;
    this.hmProperty["telephone"] = true;
break;
case clsFeedBackEN.con_UpdDate:
this.updDate = strValue;
    this.hmProperty["updDate"] = true;
break;
case clsFeedBackEN.con_Memo:
this.memo = strValue;
    this.hmProperty["memo"] = true;
break;
case clsFeedBackEN.con_UpdUser:
this.updUser = strValue;
    this.hmProperty["updUser"] = true;
break;
case "sf_UpdFldSetStr":
this.sf_UpdFldSetStr = strValue;
break;
case "sf_FldComparisonOp":
this.sf_FldComparisonOp = strValue;
break;
default:
strMsg = `字段名:[${strFldName}]在表对象:[FeedBack]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
console.error(strMsg);
break;
}
}

/**
 * 设置对象中公共属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
*/
public feedBackId = 0;    //feedBackId
public nickName = "";    //昵称
public feedBackNumber = "";    //feedBackNumber
public feedBackContent = "";    //feedBackContent
public email = "";    //电子邮箱
public telephone = "";    //telephone
public updDate = "";    //修改日期
public memo = "";    //备注
public updUser = "";    //修改人


 /**
 * 常量:"feedBackId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_FeedBackId(): string {return "feedBackId";}    //feedBackId

 /**
 * 常量:"nickName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_NickName(): string {return "nickName";}    //昵称

 /**
 * 常量:"feedBackNumber"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_FeedBackNumber(): string {return "feedBackNumber";}    //feedBackNumber

 /**
 * 常量:"feedBackContent"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_FeedBackContent(): string {return "feedBackContent";}    //feedBackContent

 /**
 * 常量:"Email"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Email(): string {return "email";}    //电子邮箱

 /**
 * 常量:"telephone"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Telephone(): string {return "telephone";}    //telephone

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
 * 常量:"UpdUser"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UpdUser(): string {return "updUser";}    //修改人

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