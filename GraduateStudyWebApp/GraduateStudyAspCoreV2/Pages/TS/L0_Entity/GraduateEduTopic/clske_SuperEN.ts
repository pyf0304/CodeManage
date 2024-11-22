
 /**
 * 类名:clske_SuperEN
 * 表名:ke_Super(01120661)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:49:34
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
 * 知识经济父类(ke_Super)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTab } from '../../PubFun/clsGeneralTab.js';

export class clske_SuperEN extends clsGeneralTab
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "04"; //sessionStorage
public static IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
public static WhereFormat = ""; //条件格式串
public static _CurrTabName= "ke_Super"; //当前表名,与该类相关的表名
public static _KeyFldName= "ke_SuperId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 8;
public static AttributeName = ["ke_SuperId", "ke_SuperName_cn", "ke_SuperName_en", "ke_SuperDescribe_cn", "ke_SuperDescribe_en", "updDate", "updUser", "memo"];
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
private mstrke_SuperId = "";    //知识分类Id
private mstrke_SuperName_cn = "";    //知识分类名
private mstrke_SuperName_en = "";    //知识分类英文名
private mstrke_SuperDescribe_cn = "";    //知识分类描述
private mstrke_SuperDescribe_en = "";    //知识分类英文描述
private mstrUpdDate = "";    //修改日期
private mstrUpdUser = "";    //修改人
private mstrMemo = "";    //备注

/**
 * 知识分类Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setke_SuperId (value: string)
{
if (value  != undefined)
{
 this.ke_SuperId = value;
    this.hmProperty["ke_SuperId"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 知识分类名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setke_SuperName_cn (value: string)
{
if (value  != undefined)
{
 this.ke_SuperName_cn = value;
    this.hmProperty["ke_SuperName_cn"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 知识分类英文名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setke_SuperName_en (value: string)
{
if (value  != undefined)
{
 this.ke_SuperName_en = value;
    this.hmProperty["ke_SuperName_en"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 知识分类描述(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setke_SuperDescribe_cn (value: string)
{
if (value  != undefined)
{
 this.ke_SuperDescribe_cn = value;
    this.hmProperty["ke_SuperDescribe_cn"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 知识分类英文描述(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setke_SuperDescribe_en (value: string)
{
if (value  != undefined)
{
 this.ke_SuperDescribe_en = value;
    this.hmProperty["ke_SuperDescribe_en"] = true;
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
case clske_SuperEN.con_ke_SuperId:
return this.ke_SuperId;
case clske_SuperEN.con_ke_SuperName_cn:
return this.ke_SuperName_cn;
case clske_SuperEN.con_ke_SuperName_en:
return this.ke_SuperName_en;
case clske_SuperEN.con_ke_SuperDescribe_cn:
return this.ke_SuperDescribe_cn;
case clske_SuperEN.con_ke_SuperDescribe_en:
return this.ke_SuperDescribe_en;
case clske_SuperEN.con_UpdDate:
return this.updDate;
case clske_SuperEN.con_UpdUser:
return this.updUser;
case clske_SuperEN.con_Memo:
return this.memo;
case "sfUpdFldSetStr":
return this.sfUpdFldSetStr;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[ke_Super]中不存在！`;
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
case clske_SuperEN.con_ke_SuperId:
this.ke_SuperId = strValue;
    this.hmProperty["ke_SuperId"] = true;
break;
case clske_SuperEN.con_ke_SuperName_cn:
this.ke_SuperName_cn = strValue;
    this.hmProperty["ke_SuperName_cn"] = true;
break;
case clske_SuperEN.con_ke_SuperName_en:
this.ke_SuperName_en = strValue;
    this.hmProperty["ke_SuperName_en"] = true;
break;
case clske_SuperEN.con_ke_SuperDescribe_cn:
this.ke_SuperDescribe_cn = strValue;
    this.hmProperty["ke_SuperDescribe_cn"] = true;
break;
case clske_SuperEN.con_ke_SuperDescribe_en:
this.ke_SuperDescribe_en = strValue;
    this.hmProperty["ke_SuperDescribe_en"] = true;
break;
case clske_SuperEN.con_UpdDate:
this.updDate = strValue;
    this.hmProperty["updDate"] = true;
break;
case clske_SuperEN.con_UpdUser:
this.updUser = strValue;
    this.hmProperty["updUser"] = true;
break;
case clske_SuperEN.con_Memo:
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
strMsg = `字段名:[${strFldName}]在表对象:[ke_Super]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
console.error(strMsg);
break;
}
}

/**
 * 设置对象中公共属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
*/
public ke_SuperId = "";    //知识分类Id
public ke_SuperName_cn = "";    //知识分类名
public ke_SuperName_en = "";    //知识分类英文名
public ke_SuperDescribe_cn = "";    //知识分类描述
public ke_SuperDescribe_en = "";    //知识分类英文描述
public updDate = "";    //修改日期
public updUser = "";    //修改人
public memo = "";    //备注


 /**
 * 常量:"ke_SuperId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ke_SuperId(): string {return "ke_SuperId";}    //知识分类Id

 /**
 * 常量:"ke_SuperName_cn"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ke_SuperName_cn(): string {return "ke_SuperName_cn";}    //知识分类名

 /**
 * 常量:"ke_SuperName_en"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ke_SuperName_en(): string {return "ke_SuperName_en";}    //知识分类英文名

 /**
 * 常量:"ke_SuperDescribe_cn"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ke_SuperDescribe_cn(): string {return "ke_SuperDescribe_cn";}    //知识分类描述

 /**
 * 常量:"ke_SuperDescribe_en"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ke_SuperDescribe_en(): string {return "ke_SuperDescribe_en";}    //知识分类英文描述

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