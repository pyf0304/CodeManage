
 /**
 * 类名:clsvTeachingSolutionEN
 * 表名:vTeachingSolution(01120138)
 * 生成代码版本:2021.09.26.2
 * 生成日期:2021/09/27 18:17:46
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
 * v教学方案(vTeachingSolution)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTab2 } from '../../PubFun/clsGeneralTab2.js';
export class clsvTeachingSolutionEN extends clsGeneralTab2
{
[x: string]: any;//索引类型
public static _CurrTabName= "vTeachingSolution"; //当前表名,与该类相关的表名
public static _KeyFldName= "TeachingSolutionId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 20;
public static AttributeName = ["TeachingSolutionId", "TeachingSolutionName", "courseId", "courseCode", "courseDescription", "id_Teacher", "teacherID", "teacherName", "id_Sex", "SexDesc", "collegeName", "id_ProfGrade", "ProfenssionalGradeName", "CollegeID", "id_XzCollege", "id_XzMajor", "BriefIntroduction", "updDate", "updUser", "memo"];
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
private mstrCourseCode = "";    //课程代码
private mstrCourseDescription = "";    //课程描述
private mstrid_Teacher = "";    //教师流水号
private mstrTeacherID = "";    //教师工号
private mstrTeacherName = "";    //教师姓名
private mstrid_Sex = "";    //性别流水号
private mstrSexDesc = "";    //性别名称
private mstrcollegeName = "";    //学院名称
private mstrid_ProfGrade = "";    //专业职称流水号
private mstrProfenssionalGradeName = "";    //专业职称
private mstrCollegeID = "";    //学院ID
private mstrid_XzCollege = "";    //学院流水号
private mstrid_XzMajor = "";    //专业流水号
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
 * 课程代码(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get courseCode ()
{
return this.mstrCourseCode;
}
/**
 * 课程代码(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set courseCode (value: string)
{
if (value  != undefined)
{
 this.mstrCourseCode = value;
    this.hmProperty["courseCode"] = true;
}
}

/**
 * 课程描述(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get courseDescription ()
{
return this.mstrCourseDescription;
}
/**
 * 课程描述(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set courseDescription (value: string)
{
if (value  != undefined)
{
 this.mstrCourseDescription = value;
    this.hmProperty["courseDescription"] = true;
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
 * 教师工号(说明:;字段类型:varchar;字段长度:12;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get teacherID ()
{
return this.mstrTeacherID;
}
/**
 * 教师工号(说明:;字段类型:varchar;字段长度:12;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set teacherID (value: string)
{
if (value  != undefined)
{
 this.mstrTeacherID = value;
    this.hmProperty["teacherID"] = true;
}
}

/**
 * 教师姓名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get teacherName ()
{
return this.mstrTeacherName;
}
/**
 * 教师姓名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set teacherName (value: string)
{
if (value  != undefined)
{
 this.mstrTeacherName = value;
    this.hmProperty["teacherName"] = true;
}
}

/**
 * 性别流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get id_Sex ()
{
return this.mstrid_Sex;
}
/**
 * 性别流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set id_Sex (value: string)
{
if (value  != undefined)
{
 this.mstrid_Sex = value;
    this.hmProperty["id_Sex"] = true;
}
}

/**
 * 性别名称(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get SexDesc ()
{
return this.mstrSexDesc;
}
/**
 * 性别名称(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set SexDesc (value: string)
{
if (value  != undefined)
{
 this.mstrSexDesc = value;
    this.hmProperty["SexDesc"] = true;
}
}

/**
 * 学院名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get collegeName ()
{
return this.mstrcollegeName;
}
/**
 * 学院名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set collegeName (value: string)
{
if (value  != undefined)
{
 this.mstrcollegeName = value;
    this.hmProperty["collegeName"] = true;
}
}

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
 * 学院ID(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get CollegeID ()
{
return this.mstrCollegeID;
}
/**
 * 学院ID(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set CollegeID (value: string)
{
if (value  != undefined)
{
 this.mstrCollegeID = value;
    this.hmProperty["CollegeID"] = true;
}
}

/**
 * 学院流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get id_XzCollege ()
{
return this.mstrid_XzCollege;
}
/**
 * 学院流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set id_XzCollege (value: string)
{
if (value  != undefined)
{
 this.mstrid_XzCollege = value;
    this.hmProperty["id_XzCollege"] = true;
}
}

/**
 * 专业流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get id_XzMajor ()
{
return this.mstrid_XzMajor;
}
/**
 * 专业流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set id_XzMajor (value: string)
{
if (value  != undefined)
{
 this.mstrid_XzMajor = value;
    this.hmProperty["id_XzMajor"] = true;
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
 * 常量:"courseCode"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CourseCode(): string {return "courseCode";}    //课程代码

 /**
 * 常量:"courseDescription"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CourseDescription(): string {return "courseDescription";}    //课程描述

 /**
 * 常量:"id_Teacher"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_Teacher(): string {return "id_Teacher";}    //教师流水号

 /**
 * 常量:"teacherID"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_TeacherID(): string {return "teacherID";}    //教师工号

 /**
 * 常量:"teacherName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_TeacherName(): string {return "teacherName";}    //教师姓名

 /**
 * 常量:"id_Sex"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_Sex(): string {return "id_Sex";}    //性别流水号

 /**
 * 常量:"SexDesc"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SexDesc(): string {return "SexDesc";}    //性别名称

 /**
 * 常量:"collegeName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CollegeName(): string {return "collegeName";}    //学院名称

 /**
 * 常量:"id_ProfGrade"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_ProfGrade(): string {return "id_ProfGrade";}    //专业职称流水号

 /**
 * 常量:"ProfenssionalGradeName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ProfenssionalGradeName(): string {return "ProfenssionalGradeName";}    //专业职称

 /**
 * 常量:"CollegeID"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CollegeID(): string {return "CollegeID";}    //学院ID

 /**
 * 常量:"id_XzCollege"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_XzCollege(): string {return "id_XzCollege";}    //学院流水号

 /**
 * 常量:"id_XzMajor"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_XzMajor(): string {return "id_XzMajor";}    //专业流水号

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
 * v教学方案(vTeachingSolution)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
export class clsvTeachingSolutionEN_Sim
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
 * 课程代码(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public courseCode = "";

/**
 * 课程描述(说明:;字段类型:varchar;字段长度:8000;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public courseDescription = "";

/**
 * 教师流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public id_Teacher = "";

/**
 * 教师工号(说明:;字段类型:varchar;字段长度:12;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public teacherID = "";

/**
 * 教师姓名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public teacherName = "";

/**
 * 性别流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public id_Sex = "";

/**
 * 性别名称(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public SexDesc = "";

/**
 * 学院名称(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public collegeName = "";

/**
 * 专业职称流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public id_ProfGrade = "";

/**
 * 专业职称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public ProfenssionalGradeName = "";

/**
 * 学院ID(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public CollegeID = "";

/**
 * 学院流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public id_XzCollege = "";

/**
 * 专业流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public id_XzMajor = "";

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