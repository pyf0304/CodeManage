﻿
 /**
 * 类名:clsOperationTypeEN
 * 表名:OperationType(01120538)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:45:54
 * 生成者:pyf
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:系统参数(SysPara)
 * 框架-层名:实体层(TS)(EntityLayer)
 * 编程语言:TypeScript
 **/
 /**
 * 操作类型(OperationType)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTab } from '../../PubFun/clsGeneralTab.js';

export class clsOperationTypeEN extends clsGeneralTab
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "03"; //localStorage
public static _CurrTabName= "OperationType"; //当前表名,与该类相关的表名
public static _KeyFldName= "OperationTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 5;
public static AttributeName = ["operationTypeId", "operationTypeName", "updDate", "updUserId", "memo"];
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
private mstrOperationTypeId = "";    //操作类型ID
private mstrOperationTypeName = "";    //操作类型名
private mstrUpdDate = "";    //修改日期
private mstrUpdUserId = "";    //修改用户Id
private mstrMemo = "";    //备注

/**
 * 操作类型ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetOperationTypeId (value: string)
{
if (value  != undefined)
{
 this.operationTypeId = value;
    this.hmProperty["operationTypeId"] = true;
}
}

/**
 * 操作类型名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetOperationTypeName (value: string)
{
if (value  != undefined)
{
 this.operationTypeName = value;
    this.hmProperty["operationTypeName"] = true;
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
 * 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetUpdUserId (value: string)
{
if (value  != undefined)
{
 this.updUserId = value;
    this.hmProperty["updUserId"] = true;
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
case clsOperationTypeEN.con_OperationTypeId:
return this.operationTypeId;
case clsOperationTypeEN.con_OperationTypeName:
return this.operationTypeName;
case clsOperationTypeEN.con_UpdDate:
return this.updDate;
case clsOperationTypeEN.con_UpdUserId:
return this.updUserId;
case clsOperationTypeEN.con_Memo:
return this.memo;
case "sf_UpdFldSetStr":
return this.sf_UpdFldSetStr;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[OperationType]中不存在！`;
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
case clsOperationTypeEN.con_OperationTypeId:
this.operationTypeId = strValue;
    this.hmProperty["operationTypeId"] = true;
break;
case clsOperationTypeEN.con_OperationTypeName:
this.operationTypeName = strValue;
    this.hmProperty["operationTypeName"] = true;
break;
case clsOperationTypeEN.con_UpdDate:
this.updDate = strValue;
    this.hmProperty["updDate"] = true;
break;
case clsOperationTypeEN.con_UpdUserId:
this.updUserId = strValue;
    this.hmProperty["updUserId"] = true;
break;
case clsOperationTypeEN.con_Memo:
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
strMsg = `字段名:[${strFldName}]在表对象:[OperationType]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
console.error(strMsg);
break;
}
}

/**
 * 设置对象中公共属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
*/
public operationTypeId = "";    //操作类型ID
public operationTypeName = "";    //操作类型名
public updDate = "";    //修改日期
public updUserId = "";    //修改用户Id
public memo = "";    //备注


 /**
 * 常量:"OperationTypeId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_OperationTypeId(): string {return "operationTypeId";}    //操作类型ID

 /**
 * 常量:"OperationTypeName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_OperationTypeName(): string {return "operationTypeName";}    //操作类型名

 /**
 * 常量:"UpdDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UpdDate(): string {return "updDate";}    //修改日期

 /**
 * 常量:"UpdUserId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UpdUserId(): string {return "updUserId";}    //修改用户Id

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