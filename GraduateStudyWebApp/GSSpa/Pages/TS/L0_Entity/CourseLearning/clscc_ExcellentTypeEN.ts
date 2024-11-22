
 /**
 * 类名:clscc_ExcellentTypeEN
 * 表名:cc_ExcellentType(01120062)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:45:59
 * 生成者:pyf
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
 * 框架-层名:实体层(TS)(EntityLayer)
 * 编程语言:TypeScript
 **/
 /**
 * 精品课程类型(cc_ExcellentType)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTab } from '../../PubFun/clsGeneralTab.js';

export class clscc_ExcellentTypeEN extends clsGeneralTab
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "04"; //sessionStorage
public static _CurrTabName= "cc_ExcellentType"; //当前表名,与该类相关的表名
public static _KeyFldName= "ExcellentTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 7;
public static AttributeName = ["excellentTypeId", "excellentTypeName", "id_School", "isUse", "updDate", "updUserId", "memo"];
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
private mstrExcellentTypeId = "";    //精品课程类型Id
private mstrExcellentTypeName = "";    //精品课程类型名称
private mstrid_School = "";    //学校流水号
private mbolIsUse = false;    //是否使用
private mstrUpdDate = "";    //修改日期
private mstrUpdUserId = "";    //修改用户Id
private mstrMemo = "";    //备注

/**
 * 精品课程类型Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetExcellentTypeId (value: string)
{
if (value  != undefined)
{
 this.excellentTypeId = value;
    this.hmProperty["excellentTypeId"] = true;
}
}

/**
 * 精品课程类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetExcellentTypeName (value: string)
{
if (value  != undefined)
{
 this.excellentTypeName = value;
    this.hmProperty["excellentTypeName"] = true;
}
}

/**
 * 学校流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setid_School (value: string)
{
if (value  != undefined)
{
 this.id_School = value;
    this.hmProperty["id_School"] = true;
}
}

/**
 * 是否使用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetIsUse (value: boolean)
{
if (value  != undefined)
{
 this.isUse = value;
    this.hmProperty["isUse"] = true;
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
case clscc_ExcellentTypeEN.con_ExcellentTypeId:
return this.excellentTypeId;
case clscc_ExcellentTypeEN.con_ExcellentTypeName:
return this.excellentTypeName;
case clscc_ExcellentTypeEN.con_id_School:
return this.id_School;
case clscc_ExcellentTypeEN.con_IsUse:
return this.isUse;
case clscc_ExcellentTypeEN.con_UpdDate:
return this.updDate;
case clscc_ExcellentTypeEN.con_UpdUserId:
return this.updUserId;
case clscc_ExcellentTypeEN.con_Memo:
return this.memo;
case "sf_UpdFldSetStr":
return this.sf_UpdFldSetStr;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[cc_ExcellentType]中不存在！`;
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
case clscc_ExcellentTypeEN.con_ExcellentTypeId:
this.excellentTypeId = strValue;
    this.hmProperty["excellentTypeId"] = true;
break;
case clscc_ExcellentTypeEN.con_ExcellentTypeName:
this.excellentTypeName = strValue;
    this.hmProperty["excellentTypeName"] = true;
break;
case clscc_ExcellentTypeEN.con_id_School:
this.id_School = strValue;
    this.hmProperty["id_School"] = true;
break;
case clscc_ExcellentTypeEN.con_IsUse:
this.isUse = Boolean(strValue);
    this.hmProperty["isUse"] = true;
break;
case clscc_ExcellentTypeEN.con_UpdDate:
this.updDate = strValue;
    this.hmProperty["updDate"] = true;
break;
case clscc_ExcellentTypeEN.con_UpdUserId:
this.updUserId = strValue;
    this.hmProperty["updUserId"] = true;
break;
case clscc_ExcellentTypeEN.con_Memo:
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
strMsg = `字段名:[${strFldName}]在表对象:[cc_ExcellentType]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
console.error(strMsg);
break;
}
}

/**
 * 设置对象中公共属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
*/
public excellentTypeId = "";    //精品课程类型Id
public excellentTypeName = "";    //精品课程类型名称
public id_School = "";    //学校流水号
public isUse = false;    //是否使用
public updDate = "";    //修改日期
public updUserId = "";    //修改用户Id
public memo = "";    //备注


 /**
 * 常量:"ExcellentTypeId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ExcellentTypeId(): string {return "excellentTypeId";}    //精品课程类型Id

 /**
 * 常量:"ExcellentTypeName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ExcellentTypeName(): string {return "excellentTypeName";}    //精品课程类型名称

 /**
 * 常量:"id_School"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_School(): string {return "id_School";}    //学校流水号

 /**
 * 常量:"IsUse"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsUse(): string {return "isUse";}    //是否使用

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