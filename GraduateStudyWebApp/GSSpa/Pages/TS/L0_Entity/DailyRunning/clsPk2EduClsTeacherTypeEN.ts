
 /**
 * 类名:clsPk2EduClsTeacherTypeEN
 * 表名:Pk2EduClsTeacherType(01120133)
 * 生成代码版本:2021.09.26.2
 * 生成日期:2021/09/27 18:02:41
 * 生成者:pyf
 * 工程名称:问卷调查
 * 工程ID:0112
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 * 模块中文名:日常运行
 * 模块英文名:DailyRunning
 * 框架-层名:实体层(EntityLayer)
 * 编程语言:TypeScript
 **/
 /**
 * 教学班教师角色表2(Pk2EduClsTeacherType)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTab2 } from '../../PubFun/clsGeneralTab2.js';
export class clsPk2EduClsTeacherTypeEN extends clsGeneralTab2
{
[x: string]: any;//索引类型
public static _CurrTabName= "Pk2EduClsTeacherType"; //当前表名,与该类相关的表名
public static _KeyFldName= "id_Pk2EduClsTeacherType"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 3;
public static AttributeName = ["id_Pk2EduClsTeacherType", "EduClsTeacherTypeID", "EduClsTeacherTypeDesc"];
//以下是属性变量

/**
 * 构造函数
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
*/
 constructor()
 {
 super();
 }

private mstrid_Pk2EduClsTeacherType = "";    //教学班老师角色(主讲,辅导)流水号
private mstrEduClsTeacherTypeID = "";    //教学班教学类型ID
private mstrEduClsTeacherTypeDesc = "";    //教学班教师类型名

/**
 * 教学班老师角色(主讲,辅导)流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get id_Pk2EduClsTeacherType ()
{
return this.mstrid_Pk2EduClsTeacherType;
}
/**
 * 教学班老师角色(主讲,辅导)流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set id_Pk2EduClsTeacherType (value: string)
{
if (value  != undefined)
{
 this.mstrid_Pk2EduClsTeacherType = value;
    this.hmProperty["id_Pk2EduClsTeacherType"] = true;
}
}

/**
 * 教学班教学类型ID(说明:;字段类型:char;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get EduClsTeacherTypeID ()
{
return this.mstrEduClsTeacherTypeID;
}
/**
 * 教学班教学类型ID(说明:;字段类型:char;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set EduClsTeacherTypeID (value: string)
{
if (value  != undefined)
{
 this.mstrEduClsTeacherTypeID = value;
    this.hmProperty["EduClsTeacherTypeID"] = true;
}
}

/**
 * 教学班教师类型名(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get EduClsTeacherTypeDesc ()
{
return this.mstrEduClsTeacherTypeDesc;
}
/**
 * 教学班教师类型名(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set EduClsTeacherTypeDesc (value: string)
{
if (value  != undefined)
{
 this.mstrEduClsTeacherTypeDesc = value;
    this.hmProperty["EduClsTeacherTypeDesc"] = true;
}
}



 /**
 * 常量:"id_Pk2EduClsTeacherType"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_Pk2EduClsTeacherType(): string {return "id_Pk2EduClsTeacherType";}    //教学班老师角色(主讲,辅导)流水号

 /**
 * 常量:"EduClsTeacherTypeID"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_EduClsTeacherTypeID(): string {return "EduClsTeacherTypeID";}    //教学班教学类型ID

 /**
 * 常量:"EduClsTeacherTypeDesc"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_EduClsTeacherTypeDesc(): string {return "EduClsTeacherTypeDesc";}    //教学班教师类型名

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
 * 教学班教师角色表2(Pk2EduClsTeacherType)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
export class clsPk2EduClsTeacherTypeEN_Sim
{
[x: string]: any;//索引类型
//以下是属性变量

/**
 * 教学班老师角色(主讲,辅导)流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public id_Pk2EduClsTeacherType = "";

/**
 * 教学班教学类型ID(说明:;字段类型:char;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public EduClsTeacherTypeID = "";

/**
 * 教学班教师类型名(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public EduClsTeacherTypeDesc = "";

public sf_UpdFldSetStr = "";     //专门用于记录某字段属性是否修改
public sf_FldComparisonOp = "";     //专门用于记录条件对象某字段的比较运算符
}