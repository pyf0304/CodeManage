
 /**
 * 类名:clsXzAdminClsEN
 * 表名:XzAdminCls(01120194)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:52:36
 * 生成者:pyf
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:人员管理(PeopleManage)
 * 框架-层名:实体层(TS)(EntityLayer)
 * 编程语言:TypeScript
 **/
 /**
 * 行政班(XzAdminCls)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTab } from '../../PubFun/clsGeneralTab.js';

export class clsXzAdminClsEN extends clsGeneralTab
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "04"; //sessionStorage
public static IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
public static WhereFormat = ""; //条件格式串
public static _CurrTabName= "XzAdminCls"; //当前表名,与该类相关的表名
public static _KeyFldName= "id_AdminCls"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 13;
public static AttributeName = ["id_AdminCls", "adminClsName", "id_XzMajor", "id_XzCollege", "id_UniZone", "currentStuQty", "id_GradeBase", "adminClsId", "id_AdminClsType", "adminClsIndex", "memo", "modifyUserID", "modifyDate"];
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
private mstrid_AdminCls = "";    //行政班流水号
private mstrAdminClsName = "";    //行政班名称
private mstrid_XzMajor = "";    //专业流水号
private mstrid_XzCollege = "";    //学院流水号
private mstrid_UniZone = "";    //校区流水号
private mintCurrentStuQty = 0;    //当前学生数
private mstrid_GradeBase = "";    //年级流水号
private mstrAdminClsId = "";    //行政班代号
private mstrid_AdminClsType = "";    //行政班级类型流水号
private mintAdminClsIndex = 0;    //AdminClsIndex
private mstrMemo = "";    //备注
private mstrModifyUserID = "";    //修改人
private mstrModifyDate = "";    //修改日期

/**
 * 行政班流水号(说明:;字段类型:char;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setid_AdminCls (value: string)
{
if (value  != undefined)
{
 this.id_AdminCls = value;
    this.hmProperty["id_AdminCls"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 行政班名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetAdminClsName (value: string)
{
if (value  != undefined)
{
 this.adminClsName = value;
    this.hmProperty["adminClsName"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 专业流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setid_XzMajor (value: string)
{
if (value  != undefined)
{
 this.id_XzMajor = value;
    this.hmProperty["id_XzMajor"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

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
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 校区流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setid_UniZone (value: string)
{
if (value  != undefined)
{
 this.id_UniZone = value;
    this.hmProperty["id_UniZone"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 当前学生数(说明:;字段类型:int;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetCurrentStuQty (value: number)
{
if (value  != undefined)
{
 this.currentStuQty = value;
    this.hmProperty["currentStuQty"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 年级流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setid_GradeBase (value: string)
{
if (value  != undefined)
{
 this.id_GradeBase = value;
    this.hmProperty["id_GradeBase"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 行政班代号(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetAdminClsId (value: string)
{
if (value  != undefined)
{
 this.adminClsId = value;
    this.hmProperty["adminClsId"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 行政班级类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setid_AdminClsType (value: string)
{
if (value  != undefined)
{
 this.id_AdminClsType = value;
    this.hmProperty["id_AdminClsType"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * AdminClsIndex(说明:;字段类型:int;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetAdminClsIndex (value: number)
{
if (value  != undefined)
{
 this.adminClsIndex = value;
    this.hmProperty["adminClsIndex"] = true;
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
case clsXzAdminClsEN.con_id_AdminCls:
return this.id_AdminCls;
case clsXzAdminClsEN.con_AdminClsName:
return this.adminClsName;
case clsXzAdminClsEN.con_id_XzMajor:
return this.id_XzMajor;
case clsXzAdminClsEN.con_id_XzCollege:
return this.id_XzCollege;
case clsXzAdminClsEN.con_id_UniZone:
return this.id_UniZone;
case clsXzAdminClsEN.con_CurrentStuQty:
return this.currentStuQty;
case clsXzAdminClsEN.con_id_GradeBase:
return this.id_GradeBase;
case clsXzAdminClsEN.con_AdminClsId:
return this.adminClsId;
case clsXzAdminClsEN.con_id_AdminClsType:
return this.id_AdminClsType;
case clsXzAdminClsEN.con_AdminClsIndex:
return this.adminClsIndex;
case clsXzAdminClsEN.con_Memo:
return this.memo;
case clsXzAdminClsEN.con_ModifyUserID:
return this.modifyUserID;
case clsXzAdminClsEN.con_ModifyDate:
return this.modifyDate;
case "sfUpdFldSetStr":
return this.sfUpdFldSetStr;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[XzAdminCls]中不存在！`;
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
case clsXzAdminClsEN.con_id_AdminCls:
this.id_AdminCls = strValue;
    this.hmProperty["id_AdminCls"] = true;
break;
case clsXzAdminClsEN.con_AdminClsName:
this.adminClsName = strValue;
    this.hmProperty["adminClsName"] = true;
break;
case clsXzAdminClsEN.con_id_XzMajor:
this.id_XzMajor = strValue;
    this.hmProperty["id_XzMajor"] = true;
break;
case clsXzAdminClsEN.con_id_XzCollege:
this.id_XzCollege = strValue;
    this.hmProperty["id_XzCollege"] = true;
break;
case clsXzAdminClsEN.con_id_UniZone:
this.id_UniZone = strValue;
    this.hmProperty["id_UniZone"] = true;
break;
case clsXzAdminClsEN.con_CurrentStuQty:
this.currentStuQty = Number(strValue);
    this.hmProperty["currentStuQty"] = true;
break;
case clsXzAdminClsEN.con_id_GradeBase:
this.id_GradeBase = strValue;
    this.hmProperty["id_GradeBase"] = true;
break;
case clsXzAdminClsEN.con_AdminClsId:
this.adminClsId = strValue;
    this.hmProperty["adminClsId"] = true;
break;
case clsXzAdminClsEN.con_id_AdminClsType:
this.id_AdminClsType = strValue;
    this.hmProperty["id_AdminClsType"] = true;
break;
case clsXzAdminClsEN.con_AdminClsIndex:
this.adminClsIndex = Number(strValue);
    this.hmProperty["adminClsIndex"] = true;
break;
case clsXzAdminClsEN.con_Memo:
this.memo = strValue;
    this.hmProperty["memo"] = true;
break;
case clsXzAdminClsEN.con_ModifyUserID:
this.modifyUserID = strValue;
    this.hmProperty["modifyUserID"] = true;
break;
case clsXzAdminClsEN.con_ModifyDate:
this.modifyDate = strValue;
    this.hmProperty["modifyDate"] = true;
break;
case "sfUpdFldSetStr":
this.sfUpdFldSetStr = strValue;
break;
case "sf_FldComparisonOp":
this.sf_FldComparisonOp = strValue;
break;
default:
strMsg = `字段名:[${strFldName}]在表对象:[XzAdminCls]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
console.error(strMsg);
break;
}
}

/**
 * 设置对象中公共属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
*/
public id_AdminCls = "";    //行政班流水号
public adminClsName = "";    //行政班名称
public id_XzMajor = "";    //专业流水号
public id_XzCollege = "";    //学院流水号
public id_UniZone = "";    //校区流水号
public currentStuQty = 0;    //当前学生数
public id_GradeBase = "";    //年级流水号
public adminClsId = "";    //行政班代号
public id_AdminClsType = "";    //行政班级类型流水号
public adminClsIndex = 0;    //AdminClsIndex
public memo = "";    //备注
public modifyUserID = "";    //修改人
public modifyDate = "";    //修改日期


 /**
 * 常量:"id_AdminCls"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_AdminCls(): string {return "id_AdminCls";}    //行政班流水号

 /**
 * 常量:"AdminClsName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_AdminClsName(): string {return "adminClsName";}    //行政班名称

 /**
 * 常量:"id_XzMajor"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_XzMajor(): string {return "id_XzMajor";}    //专业流水号

 /**
 * 常量:"id_XzCollege"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_XzCollege(): string {return "id_XzCollege";}    //学院流水号

 /**
 * 常量:"id_UniZone"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_UniZone(): string {return "id_UniZone";}    //校区流水号

 /**
 * 常量:"CurrentStuQty"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CurrentStuQty(): string {return "currentStuQty";}    //当前学生数

 /**
 * 常量:"id_GradeBase"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_GradeBase(): string {return "id_GradeBase";}    //年级流水号

 /**
 * 常量:"AdminClsId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_AdminClsId(): string {return "adminClsId";}    //行政班代号

 /**
 * 常量:"id_AdminClsType"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_AdminClsType(): string {return "id_AdminClsType";}    //行政班级类型流水号

 /**
 * 常量:"AdminClsIndex"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_AdminClsIndex(): string {return "adminClsIndex";}    //AdminClsIndex

 /**
 * 常量:"Memo"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Memo(): string {return "memo";}    //备注

 /**
 * 常量:"ModifyUserID"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ModifyUserID(): string {return "modifyUserID";}    //修改人

 /**
 * 常量:"ModifyDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ModifyDate(): string {return "modifyDate";}    //修改日期

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