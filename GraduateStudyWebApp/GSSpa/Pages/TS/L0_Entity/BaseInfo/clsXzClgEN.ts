
 /**
 * 类名:clsXzClgEN
 * 表名:XzClg(01120064)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:06
 * 生成者:pyf
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:基本信息维护(BaseInfo)
 * 框架-层名:实体层(TS)(EntityLayer)
 * 编程语言:TypeScript
 **/
 /**
 * 学院(XzClg)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTab } from '../../PubFun/clsGeneralTab.js';

export class clsXzClgEN extends clsGeneralTab
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "04"; //sessionStorage
public static _CurrTabName= "XzClg"; //当前表名,与该类相关的表名
public static _KeyFldName= "id_XzCollege"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 16;
public static AttributeName = ["id_XzCollege", "collegeID", "collegeName", "collegeIdInGP", "clgEnglishName", "collegeNameA", "phoneNumber", "webSite", "id_School", "id_Uni", "isVisible4Tea", "isVisible", "orderNum", "modifyDate", "modifyUserID", "memo"];
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
private mstrid_XzCollege = "";    //学院流水号
private mstrCollegeID = "";    //学院ID
private mstrCollegeName = "";    //学院名称
private mstrCollegeIdInGP = "";    //CollegeIdInGP
private mstrClgEnglishName = "";    //ClgEnglishName
private mstrCollegeNameA = "";    //学院名称简写
private mstrPhoneNumber = "";    //PhoneNumber
private mstrWebSite = "";    //个人主页
private mstrid_School = "";    //学校流水号
private mstrid_Uni = "";    //id_Uni
private mbolIsVisible4Tea = false;    //IsVisible4Tea
private mbolIsVisible = false;    //是否显示
private mintOrderNum = 0;    //序号
private mstrModifyDate = "";    //修改日期
private mstrModifyUserID = "";    //修改人
private mstrMemo = "";    //备注

/**
 * 学院流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setid_XzCollege (value: string)
{
if (value  != undefined)
{
 this.id_XzCollege = value;
    this.hmProperty["id_XzCollege"] = true;
}
}

/**
 * 学院ID(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetCollegeID (value: string)
{
if (value  != undefined)
{
 this.collegeID = value;
    this.hmProperty["collegeID"] = true;
}
}

/**
 * 学院名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetCollegeName (value: string)
{
if (value  != undefined)
{
 this.collegeName = value;
    this.hmProperty["collegeName"] = true;
}
}

/**
 * CollegeIdInGP(说明:;字段类型:varchar;字段长度:6;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetCollegeIdInGP (value: string)
{
if (value  != undefined)
{
 this.collegeIdInGP = value;
    this.hmProperty["collegeIdInGP"] = true;
}
}

/**
 * ClgEnglishName(说明:;字段类型:varchar;字段长度:60;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetClgEnglishName (value: string)
{
if (value  != undefined)
{
 this.clgEnglishName = value;
    this.hmProperty["clgEnglishName"] = true;
}
}

/**
 * 学院名称简写(说明:;字段类型:varchar;字段长度:12;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetCollegeNameA (value: string)
{
if (value  != undefined)
{
 this.collegeNameA = value;
    this.hmProperty["collegeNameA"] = true;
}
}

/**
 * PhoneNumber(说明:;字段类型:varchar;字段长度:15;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetPhoneNumber (value: string)
{
if (value  != undefined)
{
 this.phoneNumber = value;
    this.hmProperty["phoneNumber"] = true;
}
}

/**
 * 个人主页(说明:;字段类型:varchar;字段长度:60;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetWebSite (value: string)
{
if (value  != undefined)
{
 this.webSite = value;
    this.hmProperty["webSite"] = true;
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
 * id_Uni(说明:;字段类型:char;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setid_Uni (value: string)
{
if (value  != undefined)
{
 this.id_Uni = value;
    this.hmProperty["id_Uni"] = true;
}
}

/**
 * IsVisible4Tea(说明:;字段类型:bit;字段长度:1;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetIsVisible4Tea (value: boolean)
{
if (value  != undefined)
{
 this.isVisible4Tea = value;
    this.hmProperty["isVisible4Tea"] = true;
}
}

/**
 * 是否显示(说明:;字段类型:bit;字段长度:1;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetIsVisible (value: boolean)
{
if (value  != undefined)
{
 this.isVisible = value;
    this.hmProperty["isVisible"] = true;
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
 * 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetModifyDate (value: string)
{
if (value  != undefined)
{
 this.modifyDate = value;
    this.hmProperty["modifyDate"] = true;
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
case clsXzClgEN.con_id_XzCollege:
return this.id_XzCollege;
case clsXzClgEN.con_CollegeID:
return this.collegeID;
case clsXzClgEN.con_CollegeName:
return this.collegeName;
case clsXzClgEN.con_CollegeIdInGP:
return this.collegeIdInGP;
case clsXzClgEN.con_ClgEnglishName:
return this.clgEnglishName;
case clsXzClgEN.con_CollegeNameA:
return this.collegeNameA;
case clsXzClgEN.con_PhoneNumber:
return this.phoneNumber;
case clsXzClgEN.con_WebSite:
return this.webSite;
case clsXzClgEN.con_id_School:
return this.id_School;
case clsXzClgEN.con_id_Uni:
return this.id_Uni;
case clsXzClgEN.con_IsVisible4Tea:
return this.isVisible4Tea;
case clsXzClgEN.con_IsVisible:
return this.isVisible;
case clsXzClgEN.con_OrderNum:
return this.orderNum;
case clsXzClgEN.con_ModifyDate:
return this.modifyDate;
case clsXzClgEN.con_ModifyUserID:
return this.modifyUserID;
case clsXzClgEN.con_Memo:
return this.memo;
case "sf_UpdFldSetStr":
return this.sf_UpdFldSetStr;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[XzClg]中不存在！`;
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
case clsXzClgEN.con_id_XzCollege:
this.id_XzCollege = strValue;
    this.hmProperty["id_XzCollege"] = true;
break;
case clsXzClgEN.con_CollegeID:
this.collegeID = strValue;
    this.hmProperty["collegeID"] = true;
break;
case clsXzClgEN.con_CollegeName:
this.collegeName = strValue;
    this.hmProperty["collegeName"] = true;
break;
case clsXzClgEN.con_CollegeIdInGP:
this.collegeIdInGP = strValue;
    this.hmProperty["collegeIdInGP"] = true;
break;
case clsXzClgEN.con_ClgEnglishName:
this.clgEnglishName = strValue;
    this.hmProperty["clgEnglishName"] = true;
break;
case clsXzClgEN.con_CollegeNameA:
this.collegeNameA = strValue;
    this.hmProperty["collegeNameA"] = true;
break;
case clsXzClgEN.con_PhoneNumber:
this.phoneNumber = strValue;
    this.hmProperty["phoneNumber"] = true;
break;
case clsXzClgEN.con_WebSite:
this.webSite = strValue;
    this.hmProperty["webSite"] = true;
break;
case clsXzClgEN.con_id_School:
this.id_School = strValue;
    this.hmProperty["id_School"] = true;
break;
case clsXzClgEN.con_id_Uni:
this.id_Uni = strValue;
    this.hmProperty["id_Uni"] = true;
break;
case clsXzClgEN.con_IsVisible4Tea:
this.isVisible4Tea = Boolean(strValue);
    this.hmProperty["isVisible4Tea"] = true;
break;
case clsXzClgEN.con_IsVisible:
this.isVisible = Boolean(strValue);
    this.hmProperty["isVisible"] = true;
break;
case clsXzClgEN.con_OrderNum:
this.orderNum = Number(strValue);
    this.hmProperty["orderNum"] = true;
break;
case clsXzClgEN.con_ModifyDate:
this.modifyDate = strValue;
    this.hmProperty["modifyDate"] = true;
break;
case clsXzClgEN.con_ModifyUserID:
this.modifyUserID = strValue;
    this.hmProperty["modifyUserID"] = true;
break;
case clsXzClgEN.con_Memo:
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
strMsg = `字段名:[${strFldName}]在表对象:[XzClg]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
console.error(strMsg);
break;
}
}

/**
 * 设置对象中公共属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
*/
public id_XzCollege = "";    //学院流水号
public collegeID = "";    //学院ID
public collegeName = "";    //学院名称
public collegeIdInGP = "";    //CollegeIdInGP
public clgEnglishName = "";    //ClgEnglishName
public collegeNameA = "";    //学院名称简写
public phoneNumber = "";    //PhoneNumber
public webSite = "";    //个人主页
public id_School = "";    //学校流水号
public id_Uni = "";    //id_Uni
public isVisible4Tea = false;    //IsVisible4Tea
public isVisible = false;    //是否显示
public orderNum = 0;    //序号
public modifyDate = "";    //修改日期
public modifyUserID = "";    //修改人
public memo = "";    //备注


 /**
 * 常量:"id_XzCollege"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_XzCollege(): string {return "id_XzCollege";}    //学院流水号

 /**
 * 常量:"CollegeID"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CollegeID(): string {return "collegeID";}    //学院ID

 /**
 * 常量:"CollegeName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CollegeName(): string {return "collegeName";}    //学院名称

 /**
 * 常量:"CollegeIdInGP"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CollegeIdInGP(): string {return "collegeIdInGP";}    //CollegeIdInGP

 /**
 * 常量:"ClgEnglishName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ClgEnglishName(): string {return "clgEnglishName";}    //ClgEnglishName

 /**
 * 常量:"CollegeNameA"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CollegeNameA(): string {return "collegeNameA";}    //学院名称简写

 /**
 * 常量:"PhoneNumber"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PhoneNumber(): string {return "phoneNumber";}    //PhoneNumber

 /**
 * 常量:"WebSite"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_WebSite(): string {return "webSite";}    //个人主页

 /**
 * 常量:"id_School"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_School(): string {return "id_School";}    //学校流水号

 /**
 * 常量:"id_Uni"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_Uni(): string {return "id_Uni";}    //id_Uni

 /**
 * 常量:"IsVisible4Tea"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsVisible4Tea(): string {return "isVisible4Tea";}    //IsVisible4Tea

 /**
 * 常量:"IsVisible"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsVisible(): string {return "isVisible";}    //是否显示

 /**
 * 常量:"OrderNum"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_OrderNum(): string {return "orderNum";}    //序号

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