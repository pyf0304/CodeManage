
 /**
 * 类名:clsRsQualifEN
 * 表名:RsQualif(01120109)
 * 生成代码版本:2021.09.26.2
 * 生成日期:2021/09/27 17:59:38
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
 * 学历(RsQualif)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTab2 } from '../../PubFun/clsGeneralTab2.js';
export class clsRsQualifEN extends clsGeneralTab2
{
[x: string]: any;//索引类型
public static _CurrTabName= "RsQualif"; //当前表名,与该类相关的表名
public static _KeyFldName= "id_Qualif"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 5;
public static AttributeName = ["id_Qualif", "QualifID", "QualifDesc", "modifyDate", "modifyUserID"];
//以下是属性变量

/**
 * 构造函数
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
*/
 constructor()
 {
 super();
 }

private mstrid_Qualif = "";    //学历流水号
private mstrQualifID = "";    //学历
private mstrQualifDesc = "";    //QualifDesc
private mstrModifyDate = "";    //修改日期
private mstrModifyUserID = "";    //修改人

/**
 * 学历流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get id_Qualif ()
{
return this.mstrid_Qualif;
}
/**
 * 学历流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set id_Qualif (value: string)
{
if (value  != undefined)
{
 this.mstrid_Qualif = value;
    this.hmProperty["id_Qualif"] = true;
}
}

/**
 * 学历(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get QualifID ()
{
return this.mstrQualifID;
}
/**
 * 学历(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set QualifID (value: string)
{
if (value  != undefined)
{
 this.mstrQualifID = value;
    this.hmProperty["QualifID"] = true;
}
}

/**
 * QualifDesc(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get QualifDesc ()
{
return this.mstrQualifDesc;
}
/**
 * QualifDesc(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set QualifDesc (value: string)
{
if (value  != undefined)
{
 this.mstrQualifDesc = value;
    this.hmProperty["QualifDesc"] = true;
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
 * 常量:"id_Qualif"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_Qualif(): string {return "id_Qualif";}    //学历流水号

 /**
 * 常量:"QualifID"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_QualifID(): string {return "QualifID";}    //学历

 /**
 * 常量:"QualifDesc"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_QualifDesc(): string {return "QualifDesc";}    //QualifDesc

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
 * 学历(RsQualif)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
export class clsRsQualifEN_Sim
{
[x: string]: any;//索引类型
//以下是属性变量

/**
 * 学历流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public id_Qualif = "";

/**
 * 学历(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public QualifID = "";

/**
 * QualifDesc(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public QualifDesc = "";

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