
 /**
 * 类名:clsXzUniZoneEN
 * 表名:XzUniZone(01120095)
 * 生成代码版本:2021.09.26.2
 * 生成日期:2021/09/27 18:00:01
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
 * 校区(XzUniZone)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTab2 } from '../../PubFun/clsGeneralTab2.js';
export class clsXzUniZoneEN extends clsGeneralTab2
{
[x: string]: any;//索引类型
public static _CurrTabName= "XzUniZone"; //当前表名,与该类相关的表名
public static _KeyFldName= "id_UniZone"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 9;
public static AttributeName = ["id_UniZone", "UniZoneID", "UniZoneDesc", "UniZoneDescA", "id_School", "id_Uni", "modifyUserID", "modifyDate", "memo"];
//以下是属性变量

/**
 * 构造函数
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
*/
 constructor()
 {
 super();
 }

private mstrid_UniZone = "";    //校区流水号
private mstrUniZoneID = "";    //校区编号
private mstrUniZoneDesc = "";    //校区名称
private mstrUniZoneDescA = "";    //UniZoneDescA
private mstrid_School = "";    //学校流水号
private mstrid_Uni = "";    //id_Uni
private mstrModifyUserID = "";    //修改人
private mstrModifyDate = "";    //修改日期
private mstrMemo = "";    //备注

/**
 * 校区流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get id_UniZone ()
{
return this.mstrid_UniZone;
}
/**
 * 校区流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set id_UniZone (value: string)
{
if (value  != undefined)
{
 this.mstrid_UniZone = value;
    this.hmProperty["id_UniZone"] = true;
}
}

/**
 * 校区编号(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get UniZoneID ()
{
return this.mstrUniZoneID;
}
/**
 * 校区编号(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set UniZoneID (value: string)
{
if (value  != undefined)
{
 this.mstrUniZoneID = value;
    this.hmProperty["UniZoneID"] = true;
}
}

/**
 * 校区名称(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get UniZoneDesc ()
{
return this.mstrUniZoneDesc;
}
/**
 * 校区名称(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set UniZoneDesc (value: string)
{
if (value  != undefined)
{
 this.mstrUniZoneDesc = value;
    this.hmProperty["UniZoneDesc"] = true;
}
}

/**
 * UniZoneDescA(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get UniZoneDescA ()
{
return this.mstrUniZoneDescA;
}
/**
 * UniZoneDescA(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set UniZoneDescA (value: string)
{
if (value  != undefined)
{
 this.mstrUniZoneDescA = value;
    this.hmProperty["UniZoneDescA"] = true;
}
}

/**
 * 学校流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get id_School ()
{
return this.mstrid_School;
}
/**
 * 学校流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set id_School (value: string)
{
if (value  != undefined)
{
 this.mstrid_School = value;
    this.hmProperty["id_School"] = true;
}
}

/**
 * id_Uni(说明:;字段类型:char;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get id_Uni ()
{
return this.mstrid_Uni;
}
/**
 * id_Uni(说明:;字段类型:char;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set id_Uni (value: string)
{
if (value  != undefined)
{
 this.mstrid_Uni = value;
    this.hmProperty["id_Uni"] = true;
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
 * 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get memo ()
{
return this.mstrMemo;
}
/**
 * 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set memo (value: string)
{
if (value  != undefined)
{
 this.mstrMemo = value;
    this.hmProperty["memo"] = true;
}
}



 /**
 * 常量:"id_UniZone"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_UniZone(): string {return "id_UniZone";}    //校区流水号

 /**
 * 常量:"UniZoneID"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UniZoneID(): string {return "UniZoneID";}    //校区编号

 /**
 * 常量:"UniZoneDesc"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UniZoneDesc(): string {return "UniZoneDesc";}    //校区名称

 /**
 * 常量:"UniZoneDescA"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UniZoneDescA(): string {return "UniZoneDescA";}    //UniZoneDescA

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
 * 常量:"memo"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Memo(): string {return "memo";}    //备注

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
 * 校区(XzUniZone)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
export class clsXzUniZoneEN_Sim
{
[x: string]: any;//索引类型
//以下是属性变量

/**
 * 校区流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public id_UniZone = "";

/**
 * 校区编号(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public UniZoneID = "";

/**
 * 校区名称(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public UniZoneDesc = "";

/**
 * UniZoneDescA(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public UniZoneDescA = "";

/**
 * 学校流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public id_School = "";

/**
 * id_Uni(说明:;字段类型:char;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public id_Uni = "";

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
 * 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public memo = "";

public sf_UpdFldSetStr = "";     //专门用于记录某字段属性是否修改
public sf_FldComparisonOp = "";     //专门用于记录条件对象某字段的比较运算符
}