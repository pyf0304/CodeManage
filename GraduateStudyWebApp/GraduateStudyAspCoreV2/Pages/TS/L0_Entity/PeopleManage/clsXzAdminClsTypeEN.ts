
 /**
 * 类名:clsXzAdminClsTypeEN
 * 表名:XzAdminClsType(01120195)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:52:40
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
 * 行政班类型(XzAdminClsType)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTab } from '../../PubFun/clsGeneralTab.js';

export class clsXzAdminClsTypeEN extends clsGeneralTab
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "04"; //sessionStorage
public static IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
public static WhereFormat = ""; //条件格式串
public static _CurrTabName= "XzAdminClsType"; //当前表名,与该类相关的表名
public static _KeyFldName= "id_AdminClsType"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 4;
public static AttributeName = ["id_AdminClsType", "adminClsTypeId", "adminClsTypeName", "memo"];
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
private mstrid_AdminClsType = "";    //行政班级类型流水号
private mstrAdminClsTypeId = "";    //行政班级类型ID
private mstrAdminClsTypeName = "";    //行政班级类型名称
private mstrMemo = "";    //备注

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
 * 行政班级类型ID(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetAdminClsTypeId (value: string)
{
if (value  != undefined)
{
 this.adminClsTypeId = value;
    this.hmProperty["adminClsTypeId"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 行政班级类型名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetAdminClsTypeName (value: string)
{
if (value  != undefined)
{
 this.adminClsTypeName = value;
    this.hmProperty["adminClsTypeName"] = true;
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
case clsXzAdminClsTypeEN.con_id_AdminClsType:
return this.id_AdminClsType;
case clsXzAdminClsTypeEN.con_AdminClsTypeId:
return this.adminClsTypeId;
case clsXzAdminClsTypeEN.con_AdminClsTypeName:
return this.adminClsTypeName;
case clsXzAdminClsTypeEN.con_Memo:
return this.memo;
case "sfUpdFldSetStr":
return this.sfUpdFldSetStr;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[XzAdminClsType]中不存在！`;
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
case clsXzAdminClsTypeEN.con_id_AdminClsType:
this.id_AdminClsType = strValue;
    this.hmProperty["id_AdminClsType"] = true;
break;
case clsXzAdminClsTypeEN.con_AdminClsTypeId:
this.adminClsTypeId = strValue;
    this.hmProperty["adminClsTypeId"] = true;
break;
case clsXzAdminClsTypeEN.con_AdminClsTypeName:
this.adminClsTypeName = strValue;
    this.hmProperty["adminClsTypeName"] = true;
break;
case clsXzAdminClsTypeEN.con_Memo:
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
strMsg = `字段名:[${strFldName}]在表对象:[XzAdminClsType]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
console.error(strMsg);
break;
}
}

/**
 * 设置对象中公共属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
*/
public id_AdminClsType = "";    //行政班级类型流水号
public adminClsTypeId = "";    //行政班级类型ID
public adminClsTypeName = "";    //行政班级类型名称
public memo = "";    //备注


 /**
 * 常量:"id_AdminClsType"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_AdminClsType(): string {return "id_AdminClsType";}    //行政班级类型流水号

 /**
 * 常量:"AdminClsTypeId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_AdminClsTypeId(): string {return "adminClsTypeId";}    //行政班级类型ID

 /**
 * 常量:"AdminClsTypeName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_AdminClsTypeName(): string {return "adminClsTypeName";}    //行政班级类型名称

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