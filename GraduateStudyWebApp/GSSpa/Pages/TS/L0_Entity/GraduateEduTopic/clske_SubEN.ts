
 /**
 * 类名:clske_SubEN
 * 表名:ke_Sub(01120660)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:56
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
 * 知识经济子类(ke_Sub)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTab } from '../../PubFun/clsGeneralTab.js';

export class clske_SubEN extends clsGeneralTab
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "04"; //sessionStorage
public static _CurrTabName= "ke_Sub"; //当前表名,与该类相关的表名
public static _KeyFldName= "ke_SubId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 10;
public static AttributeName = ["ke_SubId", "ke_SuperId", "ke_SubName_cn", "ke_SubName_en", "ke_SubDescribe_cn", "ke_SubDescribe_en", "updDate", "updUser", "memo", "link"];
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
private mstrke_SubId = "";    //知识子类Id
private mstrke_SuperId = "";    //知识分类Id
private mstrke_SubName_cn = "";    //知识子类名
private mstrke_SubName_en = "";    //知识子类英文名
private mstrke_SubDescribe_cn = "";    //知识子类描述
private mstrke_SubDescribe_en = "";    //知识子类英文描述
private mstrUpdDate = "";    //修改日期
private mstrUpdUser = "";    //修改人
private mstrMemo = "";    //备注
private mstrLink = "";    //相应链接

/**
 * 知识子类Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setke_SubId (value: string)
{
if (value  != undefined)
{
 this.ke_SubId = value;
    this.hmProperty["ke_SubId"] = true;
}
}

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
}
}

/**
 * 知识子类名(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setke_SubName_cn (value: string)
{
if (value  != undefined)
{
 this.ke_SubName_cn = value;
    this.hmProperty["ke_SubName_cn"] = true;
}
}

/**
 * 知识子类英文名(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setke_SubName_en (value: string)
{
if (value  != undefined)
{
 this.ke_SubName_en = value;
    this.hmProperty["ke_SubName_en"] = true;
}
}

/**
 * 知识子类描述(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setke_SubDescribe_cn (value: string)
{
if (value  != undefined)
{
 this.ke_SubDescribe_cn = value;
    this.hmProperty["ke_SubDescribe_cn"] = true;
}
}

/**
 * 知识子类英文描述(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setke_SubDescribe_en (value: string)
{
if (value  != undefined)
{
 this.ke_SubDescribe_en = value;
    this.hmProperty["ke_SubDescribe_en"] = true;
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
 * 相应链接(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetLink (value: string)
{
if (value  != undefined)
{
 this.link = value;
    this.hmProperty["link"] = true;
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
case clske_SubEN.con_ke_SubId:
return this.ke_SubId;
case clske_SubEN.con_ke_SuperId:
return this.ke_SuperId;
case clske_SubEN.con_ke_SubName_cn:
return this.ke_SubName_cn;
case clske_SubEN.con_ke_SubName_en:
return this.ke_SubName_en;
case clske_SubEN.con_ke_SubDescribe_cn:
return this.ke_SubDescribe_cn;
case clske_SubEN.con_ke_SubDescribe_en:
return this.ke_SubDescribe_en;
case clske_SubEN.con_UpdDate:
return this.updDate;
case clske_SubEN.con_UpdUser:
return this.updUser;
case clske_SubEN.con_Memo:
return this.memo;
case clske_SubEN.con_Link:
return this.link;
case "sf_UpdFldSetStr":
return this.sf_UpdFldSetStr;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[ke_Sub]中不存在！`;
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
case clske_SubEN.con_ke_SubId:
this.ke_SubId = strValue;
    this.hmProperty["ke_SubId"] = true;
break;
case clske_SubEN.con_ke_SuperId:
this.ke_SuperId = strValue;
    this.hmProperty["ke_SuperId"] = true;
break;
case clske_SubEN.con_ke_SubName_cn:
this.ke_SubName_cn = strValue;
    this.hmProperty["ke_SubName_cn"] = true;
break;
case clske_SubEN.con_ke_SubName_en:
this.ke_SubName_en = strValue;
    this.hmProperty["ke_SubName_en"] = true;
break;
case clske_SubEN.con_ke_SubDescribe_cn:
this.ke_SubDescribe_cn = strValue;
    this.hmProperty["ke_SubDescribe_cn"] = true;
break;
case clske_SubEN.con_ke_SubDescribe_en:
this.ke_SubDescribe_en = strValue;
    this.hmProperty["ke_SubDescribe_en"] = true;
break;
case clske_SubEN.con_UpdDate:
this.updDate = strValue;
    this.hmProperty["updDate"] = true;
break;
case clske_SubEN.con_UpdUser:
this.updUser = strValue;
    this.hmProperty["updUser"] = true;
break;
case clske_SubEN.con_Memo:
this.memo = strValue;
    this.hmProperty["memo"] = true;
break;
case clske_SubEN.con_Link:
this.link = strValue;
    this.hmProperty["link"] = true;
break;
case "sf_UpdFldSetStr":
this.sf_UpdFldSetStr = strValue;
break;
case "sf_FldComparisonOp":
this.sf_FldComparisonOp = strValue;
break;
default:
strMsg = `字段名:[${strFldName}]在表对象:[ke_Sub]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
console.error(strMsg);
break;
}
}

/**
 * 设置对象中公共属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
*/
public ke_SubId = "";    //知识子类Id
public ke_SuperId = "";    //知识分类Id
public ke_SubName_cn = "";    //知识子类名
public ke_SubName_en = "";    //知识子类英文名
public ke_SubDescribe_cn = "";    //知识子类描述
public ke_SubDescribe_en = "";    //知识子类英文描述
public updDate = "";    //修改日期
public updUser = "";    //修改人
public memo = "";    //备注
public link = "";    //相应链接


 /**
 * 常量:"ke_SubId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ke_SubId(): string {return "ke_SubId";}    //知识子类Id

 /**
 * 常量:"ke_SuperId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ke_SuperId(): string {return "ke_SuperId";}    //知识分类Id

 /**
 * 常量:"ke_SubName_cn"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ke_SubName_cn(): string {return "ke_SubName_cn";}    //知识子类名

 /**
 * 常量:"ke_SubName_en"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ke_SubName_en(): string {return "ke_SubName_en";}    //知识子类英文名

 /**
 * 常量:"ke_SubDescribe_cn"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ke_SubDescribe_cn(): string {return "ke_SubDescribe_cn";}    //知识子类描述

 /**
 * 常量:"ke_SubDescribe_en"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ke_SubDescribe_en(): string {return "ke_SubDescribe_en";}    //知识子类英文描述

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
 * 常量:"Link"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Link(): string {return "link";}    //相应链接

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