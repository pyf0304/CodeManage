﻿
 /**
 * 类名:clsgs_PaperGroupEN
 * 表名:gs_PaperGroup(01120749)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:45:20
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
 * 论文分组(gs_PaperGroup)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTab } from '../../PubFun/clsGeneralTab.js';

export class clsgs_PaperGroupEN extends clsGeneralTab
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "04"; //sessionStorage
public static IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
public static WhereFormat = ""; //条件格式串
public static _CurrTabName= "gs_PaperGroup"; //当前表名,与该类相关的表名
public static _KeyFldName= "PaperGroupId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 6;
public static AttributeName = ["paperGroupId", "paperGroupName", "updUser", "orderNum", "updDate", "meno"];
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
private mstrPaperGroupId = "";    //组Id
private mstrPaperGroupName = "";    //组名
private mstrUpdUser = "";    //修改人
private mintOrderNum = 0;    //序号
private mstrUpdDate = "";    //修改日期
private mstrMeno = "";    //备注

/**
 * 组Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetPaperGroupId (value: string)
{
if (value  != undefined)
{
 this.paperGroupId = value;
    this.hmProperty["paperGroupId"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 组名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetPaperGroupName (value: string)
{
if (value  != undefined)
{
 this.paperGroupName = value;
    this.hmProperty["paperGroupName"] = true;
   this.sfUpdFldSetStr = this.updFldString;
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
   this.sfUpdFldSetStr = this.updFldString;
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
 * 备注(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetMeno (value: string)
{
if (value  != undefined)
{
 this.meno = value;
    this.hmProperty["meno"] = true;
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
case clsgs_PaperGroupEN.con_PaperGroupId:
return this.paperGroupId;
case clsgs_PaperGroupEN.con_PaperGroupName:
return this.paperGroupName;
case clsgs_PaperGroupEN.con_UpdUser:
return this.updUser;
case clsgs_PaperGroupEN.con_OrderNum:
return this.orderNum;
case clsgs_PaperGroupEN.con_UpdDate:
return this.updDate;
case clsgs_PaperGroupEN.con_Meno:
return this.meno;
case "sfUpdFldSetStr":
return this.sfUpdFldSetStr;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[gs_PaperGroup]中不存在！`;
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
case clsgs_PaperGroupEN.con_PaperGroupId:
this.paperGroupId = strValue;
    this.hmProperty["paperGroupId"] = true;
break;
case clsgs_PaperGroupEN.con_PaperGroupName:
this.paperGroupName = strValue;
    this.hmProperty["paperGroupName"] = true;
break;
case clsgs_PaperGroupEN.con_UpdUser:
this.updUser = strValue;
    this.hmProperty["updUser"] = true;
break;
case clsgs_PaperGroupEN.con_OrderNum:
this.orderNum = Number(strValue);
    this.hmProperty["orderNum"] = true;
break;
case clsgs_PaperGroupEN.con_UpdDate:
this.updDate = strValue;
    this.hmProperty["updDate"] = true;
break;
case clsgs_PaperGroupEN.con_Meno:
this.meno = strValue;
    this.hmProperty["meno"] = true;
break;
case "sfUpdFldSetStr":
this.sfUpdFldSetStr = strValue;
break;
case "sf_FldComparisonOp":
this.sf_FldComparisonOp = strValue;
break;
default:
strMsg = `字段名:[${strFldName}]在表对象:[gs_PaperGroup]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
console.error(strMsg);
break;
}
}

/**
 * 设置对象中公共属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
*/
public paperGroupId = "";    //组Id
public paperGroupName = "";    //组名
public updUser = "";    //修改人
public orderNum = 0;    //序号
public updDate = "";    //修改日期
public meno = "";    //备注


 /**
 * 常量:"PaperGroupId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PaperGroupId(): string {return "paperGroupId";}    //组Id

 /**
 * 常量:"PaperGroupName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PaperGroupName(): string {return "paperGroupName";}    //组名

 /**
 * 常量:"UpdUser"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UpdUser(): string {return "updUser";}    //修改人

 /**
 * 常量:"OrderNum"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_OrderNum(): string {return "orderNum";}    //序号

 /**
 * 常量:"UpdDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UpdDate(): string {return "updDate";}    //修改日期

 /**
 * 常量:"Meno"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Meno(): string {return "meno";}    //备注

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