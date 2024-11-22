
 /**
 * 类名:clsSexEN
 * 表名:Sex(01120103)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:53:34
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
 * 性别(Sex)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTab } from '../../PubFun/clsGeneralTab.js';

export class clsSexEN extends clsGeneralTab
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "04"; //sessionStorage
public static IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
public static WhereFormat = ""; //条件格式串
public static _CurrTabName= "Sex"; //当前表名,与该类相关的表名
public static _KeyFldName= "id_Sex"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 7;
public static AttributeName = ["id_Sex", "sexID", "sexDesc", "sexDesc_EN", "modifyDate", "modifyUserID", "memo"];
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
private mstrid_Sex = "";    //性别流水号
private mstrSexID = "";    //性别ID
private mstrSexDesc = "";    //性别名称
private mstrSexDesc_EN = "";    //SexDesc_EN
private mstrModifyDate = "";    //修改日期
private mstrModifyUserID = "";    //修改人
private mstrMemo = "";    //备注

/**
 * 性别流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setid_Sex (value: string)
{
if (value  != undefined)
{
 this.id_Sex = value;
    this.hmProperty["id_Sex"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 性别ID(说明:;字段类型:varchar;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetSexID (value: string)
{
if (value  != undefined)
{
 this.sexID = value;
    this.hmProperty["sexID"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 性别名称(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetSexDesc (value: string)
{
if (value  != undefined)
{
 this.sexDesc = value;
    this.hmProperty["sexDesc"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * SexDesc_EN(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetSexDesc_EN (value: string)
{
if (value  != undefined)
{
 this.sexDesc_EN = value;
    this.hmProperty["sexDesc_EN"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetModifyDate (value: string)
{
if (value  != undefined)
{
 this.modifyDate = value;
    this.hmProperty["modifyDate"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 修改人(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetModifyUserID (value: string)
{
if (value  != undefined)
{
 this.modifyUserID = value;
    this.hmProperty["modifyUserID"] = true;
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
case clsSexEN.con_id_Sex:
return this.id_Sex;
case clsSexEN.con_SexID:
return this.sexID;
case clsSexEN.con_SexDesc:
return this.sexDesc;
case clsSexEN.con_SexDesc_EN:
return this.sexDesc_EN;
case clsSexEN.con_ModifyDate:
return this.modifyDate;
case clsSexEN.con_ModifyUserID:
return this.modifyUserID;
case clsSexEN.con_Memo:
return this.memo;
case "sfUpdFldSetStr":
return this.sfUpdFldSetStr;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[Sex]中不存在！`;
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
case clsSexEN.con_id_Sex:
this.id_Sex = strValue;
    this.hmProperty["id_Sex"] = true;
break;
case clsSexEN.con_SexID:
this.sexID = strValue;
    this.hmProperty["sexID"] = true;
break;
case clsSexEN.con_SexDesc:
this.sexDesc = strValue;
    this.hmProperty["sexDesc"] = true;
break;
case clsSexEN.con_SexDesc_EN:
this.sexDesc_EN = strValue;
    this.hmProperty["sexDesc_EN"] = true;
break;
case clsSexEN.con_ModifyDate:
this.modifyDate = strValue;
    this.hmProperty["modifyDate"] = true;
break;
case clsSexEN.con_ModifyUserID:
this.modifyUserID = strValue;
    this.hmProperty["modifyUserID"] = true;
break;
case clsSexEN.con_Memo:
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
strMsg = `字段名:[${strFldName}]在表对象:[Sex]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
console.error(strMsg);
break;
}
}

/**
 * 设置对象中公共属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
*/
public id_Sex = "";    //性别流水号
public sexID = "";    //性别ID
public sexDesc = "";    //性别名称
public sexDesc_EN = "";    //SexDesc_EN
public modifyDate = "";    //修改日期
public modifyUserID = "";    //修改人
public memo = "";    //备注


 /**
 * 常量:"id_Sex"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_Sex(): string {return "id_Sex";}    //性别流水号

 /**
 * 常量:"SexID"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SexID(): string {return "sexID";}    //性别ID

 /**
 * 常量:"SexDesc"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SexDesc(): string {return "sexDesc";}    //性别名称

 /**
 * 常量:"SexDesc_EN"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SexDesc_EN(): string {return "sexDesc_EN";}    //SexDesc_EN

 /**
 * 常量:"ModifyDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ModifyDate(): string {return "modifyDate";}    //修改日期

 /**
 * 常量:"ModifyUserID"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ModifyUserID(): string {return "modifyUserID";}    //修改人

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