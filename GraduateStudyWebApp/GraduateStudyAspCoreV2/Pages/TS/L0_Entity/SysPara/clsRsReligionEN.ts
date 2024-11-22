
 /**
 * 类名:clsRsReligionEN
 * 表名:RsReligion(01120108)
 * 生成代码版本:2021.09.26.2
 * 生成日期:2021/09/27 17:59:35
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
 * 宗教(RsReligion)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTab2 } from '../../PubFun/clsGeneralTab2.js';
export class clsRsReligionEN extends clsGeneralTab2
{
[x: string]: any;//索引类型
public static _CurrTabName= "RsReligion"; //当前表名,与该类相关的表名
public static _KeyFldName= "id_Religion"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 5;
public static AttributeName = ["modifyUserID", "modifyDate", "id_Religion", "ReligionName", "ReligionID"];
//以下是属性变量

/**
 * 构造函数
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
*/
 constructor()
 {
 super();
 }

private mstrModifyUserID = "";    //修改人
private mstrModifyDate = "";    //修改日期
private mstrid_Religion = "";    //id_Religion
private mstrReligionName = "";    //ReligionName
private mstrReligionID = "";    //ReligionID

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
 * id_Religion(说明:;字段类型:char;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get id_Religion ()
{
return this.mstrid_Religion;
}
/**
 * id_Religion(说明:;字段类型:char;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set id_Religion (value: string)
{
if (value  != undefined)
{
 this.mstrid_Religion = value;
    this.hmProperty["id_Religion"] = true;
}
}

/**
 * ReligionName(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get ReligionName ()
{
return this.mstrReligionName;
}
/**
 * ReligionName(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set ReligionName (value: string)
{
if (value  != undefined)
{
 this.mstrReligionName = value;
    this.hmProperty["ReligionName"] = true;
}
}

/**
 * ReligionID(说明:;字段类型:char;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get ReligionID ()
{
return this.mstrReligionID;
}
/**
 * ReligionID(说明:;字段类型:char;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set ReligionID (value: string)
{
if (value  != undefined)
{
 this.mstrReligionID = value;
    this.hmProperty["ReligionID"] = true;
}
}



 /**
 * 常量:"modifyUserID"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ModifyUserID(): string {return "modifyUserID";}    //修改人

 /**
 * 常量:"modifyDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ModifyDate(): string {return "modifyDate";}    //修改日期

 /**
 * 常量:"id_Religion"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_Religion(): string {return "id_Religion";}    //id_Religion

 /**
 * 常量:"ReligionName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ReligionName(): string {return "ReligionName";}    //ReligionName

 /**
 * 常量:"ReligionID"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ReligionID(): string {return "ReligionID";}    //ReligionID

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
 * 宗教(RsReligion)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
export class clsRsReligionEN_Sim
{
[x: string]: any;//索引类型
//以下是属性变量

/**
 * 修改人(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public modifyUserID = "";

/**
 * 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public modifyDate = "";

/**
 * id_Religion(说明:;字段类型:char;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public id_Religion = "";

/**
 * ReligionName(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public ReligionName = "";

/**
 * ReligionID(说明:;字段类型:char;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public ReligionID = "";

public sfUpdFldSetStr = "";     //专门用于记录某字段属性是否修改
public sf_FldComparisonOp = "";     //专门用于记录条件对象某字段的比较运算符
}