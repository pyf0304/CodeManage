
 /**
 * 类名:clsRsProvinceEN
 * 表名:RsProvince(01120107)
 * 生成代码版本:2021.09.26.2
 * 生成日期:2021/09/27 17:59:31
 * 生成者:pyf
 * 工程名称:问卷调查
 * 工程ID:0112
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 * 模块中文名:系统参数
 * 模块英文名:SysPara
 * 框架-层名:实体层(EntityLayer)
 * 编程语言:TypeScript
 **/
 /**
 * 省份(RsProvince)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTab2 } from '../../PubFun/clsGeneralTab2.js';
export class clsRsProvinceEN extends clsGeneralTab2
{
[x: string]: any;//索引类型
public static _CurrTabName= "RsProvince"; //当前表名,与该类相关的表名
public static _KeyFldName= "id_Province"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 6;
public static AttributeName = ["id_Province", "ProvinceID", "ProvinceName", "ProvinceRecuitID", "modifyDate", "modifyUserID"];
//以下是属性变量

/**
 * 构造函数
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
*/
 constructor()
 {
 super();
 }

private mstrid_Province = "";    //省份流水号
private mstrProvinceID = "";    //ProvinceID
private mstrProvinceName = "";    //ProvinceName
private mstrProvinceRecuitID = "";    //ProvinceRecuitID
private mstrModifyDate = "";    //修改日期
private mstrModifyUserID = "";    //修改人

/**
 * 省份流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get id_Province ()
{
return this.mstrid_Province;
}
/**
 * 省份流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set id_Province (value: string)
{
if (value  != undefined)
{
 this.mstrid_Province = value;
    this.hmProperty["id_Province"] = true;
}
}

/**
 * ProvinceID(说明:;字段类型:varchar;字段长度:6;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get ProvinceID ()
{
return this.mstrProvinceID;
}
/**
 * ProvinceID(说明:;字段类型:varchar;字段长度:6;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set ProvinceID (value: string)
{
if (value  != undefined)
{
 this.mstrProvinceID = value;
    this.hmProperty["ProvinceID"] = true;
}
}

/**
 * ProvinceName(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get ProvinceName ()
{
return this.mstrProvinceName;
}
/**
 * ProvinceName(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set ProvinceName (value: string)
{
if (value  != undefined)
{
 this.mstrProvinceName = value;
    this.hmProperty["ProvinceName"] = true;
}
}

/**
 * ProvinceRecuitID(说明:;字段类型:char;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get ProvinceRecuitID ()
{
return this.mstrProvinceRecuitID;
}
/**
 * ProvinceRecuitID(说明:;字段类型:char;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set ProvinceRecuitID (value: string)
{
if (value  != undefined)
{
 this.mstrProvinceRecuitID = value;
    this.hmProperty["ProvinceRecuitID"] = true;
}
}

/**
 * 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get modifyDate ()
{
return this.mstrModifyDate;
}
/**
 * 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set modifyDate (value: string)
{
if (value  != undefined)
{
 this.mstrModifyDate = value;
    this.hmProperty["modifyDate"] = true;
}
}

/**
 * 修改人(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get modifyUserID ()
{
return this.mstrModifyUserID;
}
/**
 * 修改人(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set modifyUserID (value: string)
{
if (value  != undefined)
{
 this.mstrModifyUserID = value;
    this.hmProperty["modifyUserID"] = true;
}
}



 /**
 * 常量:"id_Province"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_Province(): string {return "id_Province";}    //省份流水号

 /**
 * 常量:"ProvinceID"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ProvinceID(): string {return "ProvinceID";}    //ProvinceID

 /**
 * 常量:"ProvinceName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ProvinceName(): string {return "ProvinceName";}    //ProvinceName

 /**
 * 常量:"ProvinceRecuitID"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ProvinceRecuitID(): string {return "ProvinceRecuitID";}    //ProvinceRecuitID

 /**
 * 常量:"modifyDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ModifyDate(): string {return "modifyDate";}    //修改日期

 /**
 * 常量:"modifyUserID"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ModifyUserID(): string {return "modifyUserID";}    //修改人

public SetCondFldValue(strFldName: string, strFldValue: any, strComparisonOp: string): void {                
this[strFldName] = strFldValue;
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
 * 省份(RsProvince)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
export class clsRsProvinceEN_Sim
{
[x: string]: any;//索引类型
//以下是属性变量

/**
 * 省份流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public id_Province = "";

/**
 * ProvinceID(说明:;字段类型:varchar;字段长度:6;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public ProvinceID = "";

/**
 * ProvinceName(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public ProvinceName = "";

/**
 * ProvinceRecuitID(说明:;字段类型:char;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public ProvinceRecuitID = "";

/**
 * 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public modifyDate = "";

/**
 * 修改人(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public modifyUserID = "";

public sf_UpdFldSetStr = "";     //专门用于记录某字段属性是否修改
public sf_FldComparisonOp = "";     //专门用于记录条件对象某字段的比较运算符
}