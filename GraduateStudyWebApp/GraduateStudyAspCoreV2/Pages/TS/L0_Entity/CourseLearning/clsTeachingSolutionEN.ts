
 /**
 * 类名:clsTeachingSolutionEN
 * 表名:TeachingSolution(01120137)
 * 生成代码版本:2021.09.26.2
 * 生成日期:2021/09/27 23:55:42
 * 生成者:pyf
 * 工程名称:问卷调查
 * 工程ID:0112
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 * 模块中文名:课程学习
 * 模块英文名:CourseLearning
 * 框架-层名:实体层(EntityLayer)
 * 编程语言:TypeScript
 **/
 /**
 * 教学方案(TeachingSolution)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTab2 } from '../../PubFun/clsGeneralTab2.js';
export class clsTeachingSolutionEN extends clsGeneralTab2
{
[x: string]: any;//索引类型
public static _CurrTabName= "TeachingSolution"; //当前表名,与该类相关的表名
public static _KeyFldName= "TeachingSolutionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 8;
public static AttributeName = ["TeachingSolutionId", "TeachingSolutionName", "courseId", "id_Teacher", "BriefIntroduction", "updDate", "updUser", "memo"];
//以下是属性变量

/**
 * 构造函数
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
*/
 constructor()
 {
 super();
 }

private mstrTeachingSolutionId = "";    //教学方案Id
private mstrTeachingSolutionName = "";    //教学方案名称
private mstrCourseId = "";    //课程Id
private mstrid_Teacher = "";    //教师流水号
private mstrBriefIntroduction = "";    //简介
private mstrUpdDate = "";    //修改日期
private mstrUpdUser = "";    //修改人
private mstrMemo = "";    //备注

/**
 * 教学方案Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get TeachingSolutionId ()
{
return this.mstrTeachingSolutionId;
}
/**
 * 教学方案Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set TeachingSolutionId (value: string)
{
if (value  != undefined)
{
 this.mstrTeachingSolutionId = value;
    this.hmProperty["TeachingSolutionId"] = true;
}
}

/**
 * 教学方案名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get TeachingSolutionName ()
{
return this.mstrTeachingSolutionName;
}
/**
 * 教学方案名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set TeachingSolutionName (value: string)
{
if (value  != undefined)
{
 this.mstrTeachingSolutionName = value;
    this.hmProperty["TeachingSolutionName"] = true;
}
}

/**
 * 课程Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get courseId ()
{
return this.mstrCourseId;
}
/**
 * 课程Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set courseId (value: string)
{
if (value  != undefined)
{
 this.mstrCourseId = value;
    this.hmProperty["courseId"] = true;
}
}

/**
 * 教师流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get id_Teacher ()
{
return this.mstrid_Teacher;
}
/**
 * 教师流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set id_Teacher (value: string)
{
if (value  != undefined)
{
 this.mstrid_Teacher = value;
    this.hmProperty["id_Teacher"] = true;
}
}

/**
 * 简介(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get BriefIntroduction ()
{
return this.mstrBriefIntroduction;
}
/**
 * 简介(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set BriefIntroduction (value: string)
{
if (value  != undefined)
{
 this.mstrBriefIntroduction = value;
    this.hmProperty["BriefIntroduction"] = true;
}
}

/**
 * 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get updDate ()
{
return this.mstrUpdDate;
}
/**
 * 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set updDate (value: string)
{
if (value  != undefined)
{
 this.mstrUpdDate = value;
    this.hmProperty["updDate"] = true;
}
}

/**
 * 修改人(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get updUser ()
{
return this.mstrUpdUser;
}
/**
 * 修改人(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set updUser (value: string)
{
if (value  != undefined)
{
 this.mstrUpdUser = value;
    this.hmProperty["updUser"] = true;
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
 * 常量:"TeachingSolutionId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_TeachingSolutionId(): string {return "TeachingSolutionId";}    //教学方案Id

 /**
 * 常量:"TeachingSolutionName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_TeachingSolutionName(): string {return "TeachingSolutionName";}    //教学方案名称

 /**
 * 常量:"courseId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CourseId(): string {return "courseId";}    //课程Id

 /**
 * 常量:"id_Teacher"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_Teacher(): string {return "id_Teacher";}    //教师流水号

 /**
 * 常量:"BriefIntroduction"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_BriefIntroduction(): string {return "BriefIntroduction";}    //简介

 /**
 * 常量:"updDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UpdDate(): string {return "updDate";}    //修改日期

 /**
 * 常量:"updUser"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UpdUser(): string {return "updUser";}    //修改人

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
 * 教学方案(TeachingSolution)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
export class clsTeachingSolutionEN_Sim
{
[x: string]: any;//索引类型
//以下是属性变量

/**
 * 教学方案Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public TeachingSolutionId = "";

/**
 * 教学方案名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public TeachingSolutionName = "";

/**
 * 课程Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public courseId = "";

/**
 * 教师流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public id_Teacher = "";

/**
 * 简介(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public BriefIntroduction = "";

/**
 * 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public updDate = "";

/**
 * 修改人(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public updUser = "";

/**
 * 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public memo = "";

public sfUpdFldSetStr = "";     //专门用于记录某字段属性是否修改
public sf_FldComparisonOp = "";     //专门用于记录条件对象某字段的比较运算符
}