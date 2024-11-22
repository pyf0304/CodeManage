
 /**
 * 类名:clsvCurrEduClsTeacherEN
 * 表名:vCurrEduClsTeacher(01120128)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 12:02:29
 * 生成者:pyf
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:日常运行(DailyRunning)
 * 框架-层名:实体层(TS)(EntityLayer)
 * 编程语言:TypeScript
 **/
 /**
 * v当前教学班教师(vCurrEduClsTeacher)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTabV } from '../../PubFun/clsGeneralTabV.js';

export class clsvCurrEduClsTeacherEN extends clsGeneralTabV
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "02"; //客户端缓存
public static _CurrTabName= "vCurrEduClsTeacher"; //当前表名,与该类相关的表名
public static _KeyFldName= "id_EduClsTeacher"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 59;
public static AttributeName = ["id_EduClsTeacher", "id_CurrEduCls", "currEduClsId", "eduClsName", "eduClsTypeId", "eduClsTypeName", "courseId", "courseCode", "courseName", "exampleImgPath", "teachingSolutionId", "teachingSolutionName", "id_XzCollege", "collegeID", "id_EduWay", "totalLessonQty", "maxStuQty", "weekQty", "scheUnitPW", "weekStatusID", "customerWeek", "lessonQtyPerWeek", "id_UniZone", "id_GradeBase", "gradeBaseID", "gradeBaseName", "isEffective", "id_CourseType", "courseTypeID", "courseTypeName", "isDegree", "id_ScoreType", "isProportionalCtrl", "id_ExamType", "beginWeek", "currStuNum_Valid", "currStuNum", "id_Teacher", "teacherID", "teacherName", "id_ProfGrade", "profenssionalGradeName", "degreeName", "birthday", "isGpUser", "collegeName", "id_Pk2EduClsTeacherType", "eduClsTeacherTypeID", "eduClsTeacherTypeDesc", "schoolTerm", "schoolYear", "openBeginDate", "openEndDate", "orderNum", "updDate", "updUser", "memo", "collegeName4EduCls", "collegeName4Teacher"];
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
case clsvCurrEduClsTeacherEN.con_id_EduClsTeacher:
return this.id_EduClsTeacher;
case clsvCurrEduClsTeacherEN.con_id_CurrEduCls:
return this.id_CurrEduCls;
case clsvCurrEduClsTeacherEN.con_CurrEduClsId:
return this.currEduClsId;
case clsvCurrEduClsTeacherEN.con_EduClsName:
return this.eduClsName;
case clsvCurrEduClsTeacherEN.con_EduClsTypeId:
return this.eduClsTypeId;
case clsvCurrEduClsTeacherEN.con_EduClsTypeName:
return this.eduClsTypeName;
case clsvCurrEduClsTeacherEN.con_CourseId:
return this.courseId;
case clsvCurrEduClsTeacherEN.con_CourseCode:
return this.courseCode;
case clsvCurrEduClsTeacherEN.con_CourseName:
return this.courseName;
case clsvCurrEduClsTeacherEN.con_ExampleImgPath:
return this.exampleImgPath;
case clsvCurrEduClsTeacherEN.con_TeachingSolutionId:
return this.teachingSolutionId;
case clsvCurrEduClsTeacherEN.con_TeachingSolutionName:
return this.teachingSolutionName;
case clsvCurrEduClsTeacherEN.con_id_XzCollege:
return this.id_XzCollege;
case clsvCurrEduClsTeacherEN.con_CollegeID:
return this.collegeID;
case clsvCurrEduClsTeacherEN.con_id_EduWay:
return this.id_EduWay;
case clsvCurrEduClsTeacherEN.con_TotalLessonQty:
return this.totalLessonQty;
case clsvCurrEduClsTeacherEN.con_MaxStuQty:
return this.maxStuQty;
case clsvCurrEduClsTeacherEN.con_WeekQty:
return this.weekQty;
case clsvCurrEduClsTeacherEN.con_ScheUnitPW:
return this.scheUnitPW;
case clsvCurrEduClsTeacherEN.con_WeekStatusID:
return this.weekStatusID;
case clsvCurrEduClsTeacherEN.con_CustomerWeek:
return this.customerWeek;
case clsvCurrEduClsTeacherEN.con_LessonQtyPerWeek:
return this.lessonQtyPerWeek;
case clsvCurrEduClsTeacherEN.con_id_UniZone:
return this.id_UniZone;
case clsvCurrEduClsTeacherEN.con_id_GradeBase:
return this.id_GradeBase;
case clsvCurrEduClsTeacherEN.con_GradeBaseID:
return this.gradeBaseID;
case clsvCurrEduClsTeacherEN.con_GradeBaseName:
return this.gradeBaseName;
case clsvCurrEduClsTeacherEN.con_IsEffective:
return this.isEffective;
case clsvCurrEduClsTeacherEN.con_id_CourseType:
return this.id_CourseType;
case clsvCurrEduClsTeacherEN.con_CourseTypeID:
return this.courseTypeID;
case clsvCurrEduClsTeacherEN.con_CourseTypeName:
return this.courseTypeName;
case clsvCurrEduClsTeacherEN.con_IsDegree:
return this.isDegree;
case clsvCurrEduClsTeacherEN.con_id_ScoreType:
return this.id_ScoreType;
case clsvCurrEduClsTeacherEN.con_IsProportionalCtrl:
return this.isProportionalCtrl;
case clsvCurrEduClsTeacherEN.con_id_ExamType:
return this.id_ExamType;
case clsvCurrEduClsTeacherEN.con_BeginWeek:
return this.beginWeek;
case clsvCurrEduClsTeacherEN.con_CurrStuNum_Valid:
return this.currStuNum_Valid;
case clsvCurrEduClsTeacherEN.con_CurrStuNum:
return this.currStuNum;
case clsvCurrEduClsTeacherEN.con_id_Teacher:
return this.id_Teacher;
case clsvCurrEduClsTeacherEN.con_TeacherID:
return this.teacherID;
case clsvCurrEduClsTeacherEN.con_TeacherName:
return this.teacherName;
case clsvCurrEduClsTeacherEN.con_id_ProfGrade:
return this.id_ProfGrade;
case clsvCurrEduClsTeacherEN.con_ProfenssionalGradeName:
return this.profenssionalGradeName;
case clsvCurrEduClsTeacherEN.con_DegreeName:
return this.degreeName;
case clsvCurrEduClsTeacherEN.con_Birthday:
return this.birthday;
case clsvCurrEduClsTeacherEN.con_IsGpUser:
return this.isGpUser;
case clsvCurrEduClsTeacherEN.con_CollegeName:
return this.collegeName;
case clsvCurrEduClsTeacherEN.con_id_Pk2EduClsTeacherType:
return this.id_Pk2EduClsTeacherType;
case clsvCurrEduClsTeacherEN.con_EduClsTeacherTypeID:
return this.eduClsTeacherTypeID;
case clsvCurrEduClsTeacherEN.con_EduClsTeacherTypeDesc:
return this.eduClsTeacherTypeDesc;
case clsvCurrEduClsTeacherEN.con_SchoolTerm:
return this.schoolTerm;
case clsvCurrEduClsTeacherEN.con_SchoolYear:
return this.schoolYear;
case clsvCurrEduClsTeacherEN.con_OpenBeginDate:
return this.openBeginDate;
case clsvCurrEduClsTeacherEN.con_OpenEndDate:
return this.openEndDate;
case clsvCurrEduClsTeacherEN.con_OrderNum:
return this.orderNum;
case clsvCurrEduClsTeacherEN.con_UpdDate:
return this.updDate;
case clsvCurrEduClsTeacherEN.con_UpdUser:
return this.updUser;
case clsvCurrEduClsTeacherEN.con_Memo:
return this.memo;
case clsvCurrEduClsTeacherEN.con_CollegeName4EduCls:
return this.collegeName4EduCls;
case clsvCurrEduClsTeacherEN.con_CollegeName4Teacher:
return this.collegeName4Teacher;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[vCurrEduClsTeacher]中不存在！`;
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
case clsvCurrEduClsTeacherEN.con_id_EduClsTeacher:
this.id_EduClsTeacher = Number(strValue);
break;
case clsvCurrEduClsTeacherEN.con_id_CurrEduCls:
this.id_CurrEduCls = strValue;
break;
case clsvCurrEduClsTeacherEN.con_CurrEduClsId:
this.currEduClsId = strValue;
break;
case clsvCurrEduClsTeacherEN.con_EduClsName:
this.eduClsName = strValue;
break;
case clsvCurrEduClsTeacherEN.con_EduClsTypeId:
this.eduClsTypeId = strValue;
break;
case clsvCurrEduClsTeacherEN.con_EduClsTypeName:
this.eduClsTypeName = strValue;
break;
case clsvCurrEduClsTeacherEN.con_CourseId:
this.courseId = strValue;
break;
case clsvCurrEduClsTeacherEN.con_CourseCode:
this.courseCode = strValue;
break;
case clsvCurrEduClsTeacherEN.con_CourseName:
this.courseName = strValue;
break;
case clsvCurrEduClsTeacherEN.con_ExampleImgPath:
this.exampleImgPath = strValue;
break;
case clsvCurrEduClsTeacherEN.con_TeachingSolutionId:
this.teachingSolutionId = strValue;
break;
case clsvCurrEduClsTeacherEN.con_TeachingSolutionName:
this.teachingSolutionName = strValue;
break;
case clsvCurrEduClsTeacherEN.con_id_XzCollege:
this.id_XzCollege = strValue;
break;
case clsvCurrEduClsTeacherEN.con_CollegeID:
this.collegeID = strValue;
break;
case clsvCurrEduClsTeacherEN.con_id_EduWay:
this.id_EduWay = strValue;
break;
case clsvCurrEduClsTeacherEN.con_TotalLessonQty:
this.totalLessonQty = Number(strValue);
break;
case clsvCurrEduClsTeacherEN.con_MaxStuQty:
this.maxStuQty = Number(strValue);
break;
case clsvCurrEduClsTeacherEN.con_WeekQty:
this.weekQty = Number(strValue);
break;
case clsvCurrEduClsTeacherEN.con_ScheUnitPW:
this.scheUnitPW = Number(strValue);
break;
case clsvCurrEduClsTeacherEN.con_WeekStatusID:
this.weekStatusID = strValue;
break;
case clsvCurrEduClsTeacherEN.con_CustomerWeek:
this.customerWeek = strValue;
break;
case clsvCurrEduClsTeacherEN.con_LessonQtyPerWeek:
this.lessonQtyPerWeek = Number(strValue);
break;
case clsvCurrEduClsTeacherEN.con_id_UniZone:
this.id_UniZone = strValue;
break;
case clsvCurrEduClsTeacherEN.con_id_GradeBase:
this.id_GradeBase = strValue;
break;
case clsvCurrEduClsTeacherEN.con_GradeBaseID:
this.gradeBaseID = strValue;
break;
case clsvCurrEduClsTeacherEN.con_GradeBaseName:
this.gradeBaseName = strValue;
break;
case clsvCurrEduClsTeacherEN.con_IsEffective:
this.isEffective = Boolean(strValue);
break;
case clsvCurrEduClsTeacherEN.con_id_CourseType:
this.id_CourseType = strValue;
break;
case clsvCurrEduClsTeacherEN.con_CourseTypeID:
this.courseTypeID = strValue;
break;
case clsvCurrEduClsTeacherEN.con_CourseTypeName:
this.courseTypeName = strValue;
break;
case clsvCurrEduClsTeacherEN.con_IsDegree:
this.isDegree = Boolean(strValue);
break;
case clsvCurrEduClsTeacherEN.con_id_ScoreType:
this.id_ScoreType = strValue;
break;
case clsvCurrEduClsTeacherEN.con_IsProportionalCtrl:
this.isProportionalCtrl = Boolean(strValue);
break;
case clsvCurrEduClsTeacherEN.con_id_ExamType:
this.id_ExamType = strValue;
break;
case clsvCurrEduClsTeacherEN.con_BeginWeek:
this.beginWeek = Number(strValue);
break;
case clsvCurrEduClsTeacherEN.con_CurrStuNum_Valid:
this.currStuNum_Valid = Number(strValue);
break;
case clsvCurrEduClsTeacherEN.con_CurrStuNum:
this.currStuNum = Number(strValue);
break;
case clsvCurrEduClsTeacherEN.con_id_Teacher:
this.id_Teacher = strValue;
break;
case clsvCurrEduClsTeacherEN.con_TeacherID:
this.teacherID = strValue;
break;
case clsvCurrEduClsTeacherEN.con_TeacherName:
this.teacherName = strValue;
break;
case clsvCurrEduClsTeacherEN.con_id_ProfGrade:
this.id_ProfGrade = strValue;
break;
case clsvCurrEduClsTeacherEN.con_ProfenssionalGradeName:
this.profenssionalGradeName = strValue;
break;
case clsvCurrEduClsTeacherEN.con_DegreeName:
this.degreeName = strValue;
break;
case clsvCurrEduClsTeacherEN.con_Birthday:
this.birthday = strValue;
break;
case clsvCurrEduClsTeacherEN.con_IsGpUser:
this.isGpUser = Boolean(strValue);
break;
case clsvCurrEduClsTeacherEN.con_CollegeName:
this.collegeName = strValue;
break;
case clsvCurrEduClsTeacherEN.con_id_Pk2EduClsTeacherType:
this.id_Pk2EduClsTeacherType = strValue;
break;
case clsvCurrEduClsTeacherEN.con_EduClsTeacherTypeID:
this.eduClsTeacherTypeID = strValue;
break;
case clsvCurrEduClsTeacherEN.con_EduClsTeacherTypeDesc:
this.eduClsTeacherTypeDesc = strValue;
break;
case clsvCurrEduClsTeacherEN.con_SchoolTerm:
this.schoolTerm = strValue;
break;
case clsvCurrEduClsTeacherEN.con_SchoolYear:
this.schoolYear = strValue;
break;
case clsvCurrEduClsTeacherEN.con_OpenBeginDate:
this.openBeginDate = strValue;
break;
case clsvCurrEduClsTeacherEN.con_OpenEndDate:
this.openEndDate = strValue;
break;
case clsvCurrEduClsTeacherEN.con_OrderNum:
this.orderNum = Number(strValue);
break;
case clsvCurrEduClsTeacherEN.con_UpdDate:
this.updDate = strValue;
break;
case clsvCurrEduClsTeacherEN.con_UpdUser:
this.updUser = strValue;
break;
case clsvCurrEduClsTeacherEN.con_Memo:
this.memo = strValue;
break;
case clsvCurrEduClsTeacherEN.con_CollegeName4EduCls:
this.collegeName4EduCls = strValue;
break;
case clsvCurrEduClsTeacherEN.con_CollegeName4Teacher:
this.collegeName4Teacher = strValue;
break;
case "sf_FldComparisonOp":
this.sf_FldComparisonOp = strValue;
break;
default:
strMsg = `字段名:[${strFldName}]在表对象:[vCurrEduClsTeacher]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
console.error(strMsg);
break;
}
}

/**
 * 设置对象中公共属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
*/
public id_EduClsTeacher = 0;    //教学班老师流水号
public id_CurrEduCls = "";    //教学班流水号
public currEduClsId = "";    //教学班Id
public eduClsName = "";    //教学班名
public eduClsTypeId = "";    //教学班类型Id
public eduClsTypeName = "";    //教学班类型名称
public courseId = "";    //课程Id
public courseCode = "";    //课程代码
public courseName = "";    //课程名称
public exampleImgPath = "";    //示例图路径
public teachingSolutionId = "";    //教学方案Id
public teachingSolutionName = "";    //教学方案名称
public id_XzCollege = "";    //学院流水号
public collegeID = "";    //学院ID
public id_EduWay = "";    //教学方式流水号
public totalLessonQty = 0;    //总课时数
public maxStuQty = 0;    //最大学生数
public weekQty = 0;    //总周数
public scheUnitPW = 0;    //周排课次数
public weekStatusID = "";    //周状态编号(单,双,全周)
public customerWeek = "";    //自定义上课周
public lessonQtyPerWeek = 0;    //周课时数
public id_UniZone = "";    //校区流水号
public id_GradeBase = "";    //年级流水号
public gradeBaseID = "";    //年级代号
public gradeBaseName = "";    //年级名称
public isEffective = false;    //是否有效
public id_CourseType = "";    //课程类型流水号
public courseTypeID = "";    //课程类型ID
public courseTypeName = "";    //课程类型名称
public isDegree = false;    //是否学位课
public id_ScoreType = "";    //成绩类型流水号
public isProportionalCtrl = false;    //是否比例控制
public id_ExamType = "";    //考试方式流水号
public beginWeek = 0;    //开始周
public currStuNum_Valid = 0;    //CurrStuNum_Valid
public currStuNum = 0;    //当前学生数
public id_Teacher = "";    //教师流水号
public teacherID = "";    //教师工号
public teacherName = "";    //教师姓名
public id_ProfGrade = "";    //专业职称流水号
public profenssionalGradeName = "";    //专业职称
public degreeName = "";    //学位名称
public birthday = "";    //出生日期
public isGpUser = false;    //是否Gp用户
public collegeName = "";    //学院名称
public id_Pk2EduClsTeacherType = "";    //教学班老师角色(主讲,辅导)流水号
public eduClsTeacherTypeID = "";    //教学班教学类型ID
public eduClsTeacherTypeDesc = "";    //教学班教师类型名
public schoolTerm = "";    //学期
public schoolYear = "";    //学年
public openBeginDate = "";    //开放开始日期
public openEndDate = "";    //开放结束日期
public orderNum = 0;    //序号
public updDate = "";    //修改日期
public updUser = "";    //修改人
public memo = "";    //备注
public collegeName4EduCls = "";    //学院名_教学班
public collegeName4Teacher = "";    //学院名_教师


 /**
 * 常量:"id_EduClsTeacher"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_EduClsTeacher(): string {return "id_EduClsTeacher";}    //教学班老师流水号

 /**
 * 常量:"id_CurrEduCls"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_CurrEduCls(): string {return "id_CurrEduCls";}    //教学班流水号

 /**
 * 常量:"CurrEduClsId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CurrEduClsId(): string {return "currEduClsId";}    //教学班Id

 /**
 * 常量:"EduClsName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_EduClsName(): string {return "eduClsName";}    //教学班名

 /**
 * 常量:"EduClsTypeId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_EduClsTypeId(): string {return "eduClsTypeId";}    //教学班类型Id

 /**
 * 常量:"EduClsTypeName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_EduClsTypeName(): string {return "eduClsTypeName";}    //教学班类型名称

 /**
 * 常量:"CourseId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CourseId(): string {return "courseId";}    //课程Id

 /**
 * 常量:"CourseCode"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CourseCode(): string {return "courseCode";}    //课程代码

 /**
 * 常量:"CourseName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CourseName(): string {return "courseName";}    //课程名称

 /**
 * 常量:"ExampleImgPath"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ExampleImgPath(): string {return "exampleImgPath";}    //示例图路径

 /**
 * 常量:"TeachingSolutionId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_TeachingSolutionId(): string {return "teachingSolutionId";}    //教学方案Id

 /**
 * 常量:"TeachingSolutionName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_TeachingSolutionName(): string {return "teachingSolutionName";}    //教学方案名称

 /**
 * 常量:"id_XzCollege"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_XzCollege(): string {return "id_XzCollege";}    //学院流水号

 /**
 * 常量:"CollegeID"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CollegeID(): string {return "collegeID";}    //学院ID

 /**
 * 常量:"id_EduWay"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_EduWay(): string {return "id_EduWay";}    //教学方式流水号

 /**
 * 常量:"TotalLessonQty"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_TotalLessonQty(): string {return "totalLessonQty";}    //总课时数

 /**
 * 常量:"MaxStuQty"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_MaxStuQty(): string {return "maxStuQty";}    //最大学生数

 /**
 * 常量:"WeekQty"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_WeekQty(): string {return "weekQty";}    //总周数

 /**
 * 常量:"ScheUnitPW"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ScheUnitPW(): string {return "scheUnitPW";}    //周排课次数

 /**
 * 常量:"WeekStatusID"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_WeekStatusID(): string {return "weekStatusID";}    //周状态编号(单,双,全周)

 /**
 * 常量:"CustomerWeek"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CustomerWeek(): string {return "customerWeek";}    //自定义上课周

 /**
 * 常量:"LessonQtyPerWeek"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_LessonQtyPerWeek(): string {return "lessonQtyPerWeek";}    //周课时数

 /**
 * 常量:"id_UniZone"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_UniZone(): string {return "id_UniZone";}    //校区流水号

 /**
 * 常量:"id_GradeBase"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_GradeBase(): string {return "id_GradeBase";}    //年级流水号

 /**
 * 常量:"GradeBaseID"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_GradeBaseID(): string {return "gradeBaseID";}    //年级代号

 /**
 * 常量:"GradeBaseName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_GradeBaseName(): string {return "gradeBaseName";}    //年级名称

 /**
 * 常量:"IsEffective"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsEffective(): string {return "isEffective";}    //是否有效

 /**
 * 常量:"id_CourseType"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_CourseType(): string {return "id_CourseType";}    //课程类型流水号

 /**
 * 常量:"CourseTypeID"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CourseTypeID(): string {return "courseTypeID";}    //课程类型ID

 /**
 * 常量:"CourseTypeName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CourseTypeName(): string {return "courseTypeName";}    //课程类型名称

 /**
 * 常量:"IsDegree"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsDegree(): string {return "isDegree";}    //是否学位课

 /**
 * 常量:"id_ScoreType"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_ScoreType(): string {return "id_ScoreType";}    //成绩类型流水号

 /**
 * 常量:"IsProportionalCtrl"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsProportionalCtrl(): string {return "isProportionalCtrl";}    //是否比例控制

 /**
 * 常量:"id_ExamType"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_ExamType(): string {return "id_ExamType";}    //考试方式流水号

 /**
 * 常量:"BeginWeek"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_BeginWeek(): string {return "beginWeek";}    //开始周

 /**
 * 常量:"CurrStuNum_Valid"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CurrStuNum_Valid(): string {return "currStuNum_Valid";}    //CurrStuNum_Valid

 /**
 * 常量:"CurrStuNum"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CurrStuNum(): string {return "currStuNum";}    //当前学生数

 /**
 * 常量:"id_Teacher"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_Teacher(): string {return "id_Teacher";}    //教师流水号

 /**
 * 常量:"TeacherID"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_TeacherID(): string {return "teacherID";}    //教师工号

 /**
 * 常量:"TeacherName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_TeacherName(): string {return "teacherName";}    //教师姓名

 /**
 * 常量:"id_ProfGrade"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_ProfGrade(): string {return "id_ProfGrade";}    //专业职称流水号

 /**
 * 常量:"ProfenssionalGradeName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ProfenssionalGradeName(): string {return "profenssionalGradeName";}    //专业职称

 /**
 * 常量:"DegreeName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_DegreeName(): string {return "degreeName";}    //学位名称

 /**
 * 常量:"Birthday"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Birthday(): string {return "birthday";}    //出生日期

 /**
 * 常量:"IsGpUser"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsGpUser(): string {return "isGpUser";}    //是否Gp用户

 /**
 * 常量:"CollegeName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CollegeName(): string {return "collegeName";}    //学院名称

 /**
 * 常量:"id_Pk2EduClsTeacherType"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_Pk2EduClsTeacherType(): string {return "id_Pk2EduClsTeacherType";}    //教学班老师角色(主讲,辅导)流水号

 /**
 * 常量:"EduClsTeacherTypeID"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_EduClsTeacherTypeID(): string {return "eduClsTeacherTypeID";}    //教学班教学类型ID

 /**
 * 常量:"EduClsTeacherTypeDesc"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_EduClsTeacherTypeDesc(): string {return "eduClsTeacherTypeDesc";}    //教学班教师类型名

 /**
 * 常量:"SchoolTerm"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SchoolTerm(): string {return "schoolTerm";}    //学期

 /**
 * 常量:"SchoolYear"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SchoolYear(): string {return "schoolYear";}    //学年

 /**
 * 常量:"OpenBeginDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_OpenBeginDate(): string {return "openBeginDate";}    //开放开始日期

 /**
 * 常量:"OpenEndDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_OpenEndDate(): string {return "openEndDate";}    //开放结束日期

 /**
 * 常量:"OrderNum"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_OrderNum(): string {return "orderNum";}    //序号

 /**
 * 常量:"UpdDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UpdDate(): string {return "updDate";}    //修改日期

 /**
 * 常量:"UpdUser"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UpdUser(): string {return "updUser";}    //修改人

 /**
 * 常量:"Memo"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Memo(): string {return "memo";}    //备注

 /**
 * 常量:"CollegeName4EduCls"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CollegeName4EduCls(): string {return "collegeName4EduCls";}    //学院名_教学班

 /**
 * 常量:"CollegeName4Teacher"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CollegeName4Teacher(): string {return "collegeName4Teacher";}    //学院名_教师

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