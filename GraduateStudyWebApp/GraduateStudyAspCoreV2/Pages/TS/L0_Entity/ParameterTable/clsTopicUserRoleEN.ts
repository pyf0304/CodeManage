﻿
 /**
 * 类名:clsTopicUserRoleEN
 * 表名:TopicUserRole(01120590)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:54:48
 * 生成者:pyf
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:研培参数(ParameterTable)
 * 框架-层名:实体层(TS)(EntityLayer)
 * 编程语言:TypeScript
 **/
 /**
 * 主题用户角色(TopicUserRole)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTab } from '../../PubFun/clsGeneralTab.js';

export class clsTopicUserRoleEN extends clsGeneralTab
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "03"; //localStorage
public static IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
public static WhereFormat = ""; //条件格式串
public static _CurrTabName= "TopicUserRole"; //当前表名,与该类相关的表名
public static _KeyFldName= "TopicUserRoleId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 6;
public static AttributeName = ["topicUserRoleId", "topicUserRoleName", "topicUserRoleENName", "updUserId", "updDate", "memo"];
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
private mstrTopicUserRoleId = "";    //主键Id
private mstrTopicUserRoleName = "";    //主题用户角色
private mstrTopicUserRoleENName = "";    //主题用户角色英文名
private mstrUpdUserId = "";    //修改用户Id
private mstrUpdDate = "";    //修改日期
private mstrMemo = "";    //备注

/**
 * 主键Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetTopicUserRoleId (value: string)
{
if (value  != undefined)
{
 this.topicUserRoleId = value;
    this.hmProperty["topicUserRoleId"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 主题用户角色(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetTopicUserRoleName (value: string)
{
if (value  != undefined)
{
 this.topicUserRoleName = value;
    this.hmProperty["topicUserRoleName"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 主题用户角色英文名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetTopicUserRoleENName (value: string)
{
if (value  != undefined)
{
 this.topicUserRoleENName = value;
    this.hmProperty["topicUserRoleENName"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetUpdUserId (value: string)
{
if (value  != undefined)
{
 this.updUserId = value;
    this.hmProperty["updUserId"] = true;
   this.sfUpdFldSetStr = this.updFldString;
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
   this.sfUpdFldSetStr = this.updFldString;
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
   this.sfUpdFldSetStr = this.updFldString;
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
case clsTopicUserRoleEN.con_TopicUserRoleId:
return this.topicUserRoleId;
case clsTopicUserRoleEN.con_TopicUserRoleName:
return this.topicUserRoleName;
case clsTopicUserRoleEN.con_TopicUserRoleENName:
return this.topicUserRoleENName;
case clsTopicUserRoleEN.con_UpdUserId:
return this.updUserId;
case clsTopicUserRoleEN.con_UpdDate:
return this.updDate;
case clsTopicUserRoleEN.con_Memo:
return this.memo;
case "sfUpdFldSetStr":
return this.sfUpdFldSetStr;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[TopicUserRole]中不存在！`;
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
case clsTopicUserRoleEN.con_TopicUserRoleId:
this.topicUserRoleId = strValue;
    this.hmProperty["topicUserRoleId"] = true;
break;
case clsTopicUserRoleEN.con_TopicUserRoleName:
this.topicUserRoleName = strValue;
    this.hmProperty["topicUserRoleName"] = true;
break;
case clsTopicUserRoleEN.con_TopicUserRoleENName:
this.topicUserRoleENName = strValue;
    this.hmProperty["topicUserRoleENName"] = true;
break;
case clsTopicUserRoleEN.con_UpdUserId:
this.updUserId = strValue;
    this.hmProperty["updUserId"] = true;
break;
case clsTopicUserRoleEN.con_UpdDate:
this.updDate = strValue;
    this.hmProperty["updDate"] = true;
break;
case clsTopicUserRoleEN.con_Memo:
this.memo = strValue;
    this.hmProperty["memo"] = true;
break;
case "sfUpdFldSetStr":
this.sfUpdFldSetStr = strValue;
break;
case "sf_FldComparisonOp":
this.sf_FldComparisonOp = strValue;
break;
default:
strMsg = `字段名:[${strFldName}]在表对象:[TopicUserRole]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
console.error(strMsg);
break;
}
}

/**
 * 设置对象中公共属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
*/
public topicUserRoleId = "";    //主键Id
public topicUserRoleName = "";    //主题用户角色
public topicUserRoleENName = "";    //主题用户角色英文名
public updUserId = "";    //修改用户Id
public updDate = "";    //修改日期
public memo = "";    //备注


 /**
 * 常量:"TopicUserRoleId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_TopicUserRoleId(): string {return "topicUserRoleId";}    //主键Id

 /**
 * 常量:"TopicUserRoleName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_TopicUserRoleName(): string {return "topicUserRoleName";}    //主题用户角色

 /**
 * 常量:"TopicUserRoleENName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_TopicUserRoleENName(): string {return "topicUserRoleENName";}    //主题用户角色英文名

 /**
 * 常量:"UpdUserId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UpdUserId(): string {return "updUserId";}    //修改用户Id

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
 /**
 * 根据表内容设置enum列表
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_GeneEnumConstList)
 **/
 export class enumTopicUserRole
{
 /**
 * 指导者
 **/
static readonly Director_0001 = "0001";
 /**
 * 组长
 **/
static readonly TeamLeader_0002 = "0002";
 /**
 * 成员
 **/
static readonly Member_0003 = "0003";
}