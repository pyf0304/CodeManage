﻿
 /**
 * 类名:clsDiscussionTopicsEN
 * 表名:DiscussionTopics(01120588)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:47:14
 * 生成者:pyf
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:研培设置(GraduateEduTools)
 * 框架-层名:实体层(TS)(EntityLayer)
 * 编程语言:TypeScript
 **/
 /**
 * 讨论主题(DiscussionTopics)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTab } from '../../PubFun/clsGeneralTab.js';

export class clsDiscussionTopicsEN extends clsGeneralTab
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "04"; //sessionStorage
public static _CurrTabName= "DiscussionTopics"; //当前表名,与该类相关的表名
public static _KeyFldName= "topicsId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 12;
public static AttributeName = ["topicsId", "discussionTypeId", "topicsTitle", "topicsContent", "isAudit", "isTop", "browseNumber", "updDate", "updUser", "memo", "id_CurrEduCls", "subCount"];
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
private mstrTopicsId = "";    //主题Id
private mstrDiscussionTypeId = "";    //讨论类型Id
private mstrtopicsTitle = "";    //主题标题
private mstrTopicsContent = "";    //主题内容
private mbolIsAudit = false;    //是否审核
private mbolIsTop = false;    //是否置顶
private mintBrowseNumber = 0;    //浏览量
private mstrUpdDate = "";    //修改日期
private mstrUpdUser = "";    //修改人
private mstrMemo = "";    //备注
private mstrid_CurrEduCls = "";    //教学班流水号
private mintSubCount = 0;    //SubCount

/**
 * 主题Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetTopicsId (value: string)
{
if (value  != undefined)
{
 this.topicsId = value;
    this.hmProperty["topicsId"] = true;
}
}

/**
 * 讨论类型Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetDiscussionTypeId (value: string)
{
if (value  != undefined)
{
 this.discussionTypeId = value;
    this.hmProperty["discussionTypeId"] = true;
}
}

/**
 * 主题标题(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SettopicsTitle (value: string)
{
if (value  != undefined)
{
 this.topicsTitle = value;
    this.hmProperty["topicsTitle"] = true;
}
}

/**
 * 主题内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetTopicsContent (value: string)
{
if (value  != undefined)
{
 this.topicsContent = value;
    this.hmProperty["topicsContent"] = true;
}
}

/**
 * 是否审核(说明:;字段类型:bit;字段长度:1;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetIsAudit (value: boolean)
{
if (value  != undefined)
{
 this.isAudit = value;
    this.hmProperty["isAudit"] = true;
}
}

/**
 * 是否置顶(说明:;字段类型:bit;字段长度:1;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetIsTop (value: boolean)
{
if (value  != undefined)
{
 this.isTop = value;
    this.hmProperty["isTop"] = true;
}
}

/**
 * 浏览量(说明:;字段类型:int;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetBrowseNumber (value: number)
{
if (value  != undefined)
{
 this.browseNumber = value;
    this.hmProperty["browseNumber"] = true;
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
 * SubCount(说明:;字段类型:int;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetSubCount (value: number)
{
if (value  != undefined)
{
 this.subCount = value;
    this.hmProperty["subCount"] = true;
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
case clsDiscussionTopicsEN.con_TopicsId:
return this.topicsId;
case clsDiscussionTopicsEN.con_DiscussionTypeId:
return this.discussionTypeId;
case clsDiscussionTopicsEN.con_topicsTitle:
return this.topicsTitle;
case clsDiscussionTopicsEN.con_TopicsContent:
return this.topicsContent;
case clsDiscussionTopicsEN.con_IsAudit:
return this.isAudit;
case clsDiscussionTopicsEN.con_IsTop:
return this.isTop;
case clsDiscussionTopicsEN.con_BrowseNumber:
return this.browseNumber;
case clsDiscussionTopicsEN.con_UpdDate:
return this.updDate;
case clsDiscussionTopicsEN.con_UpdUser:
return this.updUser;
case clsDiscussionTopicsEN.con_Memo:
return this.memo;
case clsDiscussionTopicsEN.con_id_CurrEduCls:
return this.id_CurrEduCls;
case clsDiscussionTopicsEN.con_SubCount:
return this.subCount;
case "sf_UpdFldSetStr":
return this.sf_UpdFldSetStr;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[DiscussionTopics]中不存在！`;
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
case clsDiscussionTopicsEN.con_TopicsId:
this.topicsId = strValue;
    this.hmProperty["topicsId"] = true;
break;
case clsDiscussionTopicsEN.con_DiscussionTypeId:
this.discussionTypeId = strValue;
    this.hmProperty["discussionTypeId"] = true;
break;
case clsDiscussionTopicsEN.con_topicsTitle:
this.topicsTitle = strValue;
    this.hmProperty["topicsTitle"] = true;
break;
case clsDiscussionTopicsEN.con_TopicsContent:
this.topicsContent = strValue;
    this.hmProperty["topicsContent"] = true;
break;
case clsDiscussionTopicsEN.con_IsAudit:
this.isAudit = Boolean(strValue);
    this.hmProperty["isAudit"] = true;
break;
case clsDiscussionTopicsEN.con_IsTop:
this.isTop = Boolean(strValue);
    this.hmProperty["isTop"] = true;
break;
case clsDiscussionTopicsEN.con_BrowseNumber:
this.browseNumber = Number(strValue);
    this.hmProperty["browseNumber"] = true;
break;
case clsDiscussionTopicsEN.con_UpdDate:
this.updDate = strValue;
    this.hmProperty["updDate"] = true;
break;
case clsDiscussionTopicsEN.con_UpdUser:
this.updUser = strValue;
    this.hmProperty["updUser"] = true;
break;
case clsDiscussionTopicsEN.con_Memo:
this.memo = strValue;
    this.hmProperty["memo"] = true;
break;
case clsDiscussionTopicsEN.con_id_CurrEduCls:
this.id_CurrEduCls = strValue;
    this.hmProperty["id_CurrEduCls"] = true;
break;
case clsDiscussionTopicsEN.con_SubCount:
this.subCount = Number(strValue);
    this.hmProperty["subCount"] = true;
break;
case "sf_UpdFldSetStr":
this.sf_UpdFldSetStr = strValue;
break;
case "sf_FldComparisonOp":
this.sf_FldComparisonOp = strValue;
break;
default:
strMsg = `字段名:[${strFldName}]在表对象:[DiscussionTopics]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
console.error(strMsg);
break;
}
}

/**
 * 设置对象中公共属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
*/
public topicsId = "";    //主题Id
public discussionTypeId = "";    //讨论类型Id
public topicsTitle = "";    //主题标题
public topicsContent = "";    //主题内容
public isAudit = false;    //是否审核
public isTop = false;    //是否置顶
public browseNumber = 0;    //浏览量
public updDate = "";    //修改日期
public updUser = "";    //修改人
public memo = "";    //备注
public id_CurrEduCls = "";    //教学班流水号
public subCount = 0;    //SubCount


 /**
 * 常量:"topicsId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_TopicsId(): string {return "topicsId";}    //主题Id

 /**
 * 常量:"DiscussionTypeId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_DiscussionTypeId(): string {return "discussionTypeId";}    //讨论类型Id

 /**
 * 常量:"topicsTitle"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_topicsTitle(): string {return "topicsTitle";}    //主题标题

 /**
 * 常量:"TopicsContent"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_TopicsContent(): string {return "topicsContent";}    //主题内容

 /**
 * 常量:"IsAudit"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsAudit(): string {return "isAudit";}    //是否审核

 /**
 * 常量:"isTop"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsTop(): string {return "isTop";}    //是否置顶

 /**
 * 常量:"BrowseNumber"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_BrowseNumber(): string {return "browseNumber";}    //浏览量

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
 * 常量:"id_CurrEduCls"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_CurrEduCls(): string {return "id_CurrEduCls";}    //教学班流水号

 /**
 * 常量:"SubCount"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SubCount(): string {return "subCount";}    //SubCount

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