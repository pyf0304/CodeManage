
 /**
 * 类名:clsRsProfGradeEN
 * 表名:RsProfGrade(01120104)
 * 生成代码版本:2021.09.26.2
 * 生成日期:2021/09/27 17:59:20
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
 * 专业职称(RsProfGrade)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTab2 } from '../../PubFun/clsGeneralTab2.js';
export class clsRsProfGradeEN extends clsGeneralTab2
{
[x: string]: any;//索引类型
public static _CurrTabName= "RsProfGrade"; //当前表名,与该类相关的表名
public static _KeyFldName= "id_ProfGrade"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 3;
public static AttributeName = ["id_ProfGrade", "ProfenssionalGradeID", "ProfenssionalGradeName"];
//以下是属性变量

/**
 * 构造函数
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
*/
 constructor()
 {
 super();
 }

private mstrid_ProfGrade = "";    //专业职称流水号
private mstrProfenssionalGradeID = "";    //专业职称ID
private mstrProfenssionalGradeName = "";    //专业职称

/**
 * 专业职称流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get id_ProfGrade ()
{
return this.mstrid_ProfGrade;
}
/**
 * 专业职称流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set id_ProfGrade (value: string)
{
if (value  != undefined)
{
 this.mstrid_ProfGrade = value;
    this.hmProperty["id_ProfGrade"] = true;
}
}

/**
 * 专业职称ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get ProfenssionalGradeID ()
{
return this.mstrProfenssionalGradeID;
}
/**
 * 专业职称ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set ProfenssionalGradeID (value: string)
{
if (value  != undefined)
{
 this.mstrProfenssionalGradeID = value;
    this.hmProperty["ProfenssionalGradeID"] = true;
}
}

/**
 * 专业职称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get ProfenssionalGradeName ()
{
return this.mstrProfenssionalGradeName;
}
/**
 * 专业职称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set ProfenssionalGradeName (value: string)
{
if (value  != undefined)
{
 this.mstrProfenssionalGradeName = value;
    this.hmProperty["ProfenssionalGradeName"] = true;
}
}



 /**
 * 常量:"id_ProfGrade"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_ProfGrade(): string {return "id_ProfGrade";}    //专业职称流水号

 /**
 * 常量:"ProfenssionalGradeID"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ProfenssionalGradeID(): string {return "ProfenssionalGradeID";}    //专业职称ID

 /**
 * 常量:"ProfenssionalGradeName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ProfenssionalGradeName(): string {return "ProfenssionalGradeName";}    //专业职称

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
 * 专业职称(RsProfGrade)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
export class clsRsProfGradeEN_Sim
{
[x: string]: any;//索引类型
//以下是属性变量

/**
 * 专业职称流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public id_ProfGrade = "";

/**
 * 专业职称ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public ProfenssionalGradeID = "";

/**
 * 专业职称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public ProfenssionalGradeName = "";

public sf_UpdFldSetStr = "";     //专门用于记录某字段属性是否修改
public sf_FldComparisonOp = "";     //专门用于记录条件对象某字段的比较运算符
}