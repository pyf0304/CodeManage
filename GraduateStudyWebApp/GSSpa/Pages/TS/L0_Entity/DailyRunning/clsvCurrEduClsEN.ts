
 /**
 * 类名:clsvCurrEduClsEN
 * 表名:vCurrEduCls(01120126)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 12:02:28
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
 * v当前教学班(vCurrEduCls)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTabV } from '../../PubFun/clsGeneralTabV.js';

export class clsvCurrEduClsEN extends clsGeneralTabV
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "02"; //客户端缓存
public static _CurrTabName= "vCurrEduCls"; //当前表名,与该类相关的表名
public static _KeyFldName= "id_CurrEduCls"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 56;
public static AttributeName = ["id_CurrEduCls", "currEduClsId", "eduClsName", "eduClsTypeId", "eduClsTypeName", "courseId", "courseCode", "courseDescription", "courseName", "viewCount", "exampleImgPath", "teachingSolutionId", "teachingSolutionName", "id_Teacher", "teacherID", "teacherName", "id_XzCollege", "collegeID", "collegeName", "clgEnglishName", "phoneNumber", "id_XzMajor", "majorName", "id_EduWay", "id_ClassRoomType", "totalLessonQty", "maxStuQty", "weekQty", "scheUnitPW", "weekStatusID", "customerWeek", "lessonQtyPerWeek", "mark", "id_UniZone", "id_GradeBase", "gradeBaseID", "gradeBaseName", "gradeBaseNameA", "isEffective", "isForPaperReading", "schoolYear", "schoolTerm", "id_CourseType", "courseTypeID", "courseTypeName", "isDegree", "id_ScoreType", "getScoreWayId", "isProportionalCtrl", "id_ExamType", "beginWeek", "modifyDate", "modifyUserID", "memo", "currStuNum_Valid", "currStuNum"];
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
case clsvCurrEduClsEN.con_id_CurrEduCls:
return this.id_CurrEduCls;
case clsvCurrEduClsEN.con_CurrEduClsId:
return this.currEduClsId;
case clsvCurrEduClsEN.con_EduClsName:
return this.eduClsName;
case clsvCurrEduClsEN.con_EduClsTypeId:
return this.eduClsTypeId;
case clsvCurrEduClsEN.con_EduClsTypeName:
return this.eduClsTypeName;
case clsvCurrEduClsEN.con_CourseId:
return this.courseId;
case clsvCurrEduClsEN.con_CourseCode:
return this.courseCode;
case clsvCurrEduClsEN.con_CourseDescription:
return this.courseDescription;
case clsvCurrEduClsEN.con_CourseName:
return this.courseName;
case clsvCurrEduClsEN.con_ViewCount:
return this.viewCount;
case clsvCurrEduClsEN.con_ExampleImgPath:
return this.exampleImgPath;
case clsvCurrEduClsEN.con_TeachingSolutionId:
return this.teachingSolutionId;
case clsvCurrEduClsEN.con_TeachingSolutionName:
return this.teachingSolutionName;
case clsvCurrEduClsEN.con_id_Teacher:
return this.id_Teacher;
case clsvCurrEduClsEN.con_TeacherID:
return this.teacherID;
case clsvCurrEduClsEN.con_TeacherName:
return this.teacherName;
case clsvCurrEduClsEN.con_id_XzCollege:
return this.id_XzCollege;
case clsvCurrEduClsEN.con_CollegeID:
return this.collegeID;
case clsvCurrEduClsEN.con_CollegeName:
return this.collegeName;
case clsvCurrEduClsEN.con_ClgEnglishName:
return this.clgEnglishName;
case clsvCurrEduClsEN.con_PhoneNumber:
return this.phoneNumber;
case clsvCurrEduClsEN.con_id_XzMajor:
return this.id_XzMajor;
case clsvCurrEduClsEN.con_MajorName:
return this.majorName;
case clsvCurrEduClsEN.con_id_EduWay:
return this.id_EduWay;
case clsvCurrEduClsEN.con_id_ClassRoomType:
return this.id_ClassRoomType;
case clsvCurrEduClsEN.con_TotalLessonQty:
return this.totalLessonQty;
case clsvCurrEduClsEN.con_MaxStuQty:
return this.maxStuQty;
case clsvCurrEduClsEN.con_WeekQty:
return this.weekQty;
case clsvCurrEduClsEN.con_ScheUnitPW:
return this.scheUnitPW;
case clsvCurrEduClsEN.con_WeekStatusID:
return this.weekStatusID;
case clsvCurrEduClsEN.con_CustomerWeek:
return this.customerWeek;
case clsvCurrEduClsEN.con_LessonQtyPerWeek:
return this.lessonQtyPerWeek;
case clsvCurrEduClsEN.con_Mark:
return this.mark;
case clsvCurrEduClsEN.con_id_UniZone:
return this.id_UniZone;
case clsvCurrEduClsEN.con_id_GradeBase:
return this.id_GradeBase;
case clsvCurrEduClsEN.con_GradeBaseID:
return this.gradeBaseID;
case clsvCurrEduClsEN.con_GradeBaseName:
return this.gradeBaseName;
case clsvCurrEduClsEN.con_GradeBaseNameA:
return this.gradeBaseNameA;
case clsvCurrEduClsEN.con_IsEffective:
return this.isEffective;
case clsvCurrEduClsEN.con_IsForPaperReading:
return this.isForPaperReading;
case clsvCurrEduClsEN.con_SchoolYear:
return this.schoolYear;
case clsvCurrEduClsEN.con_SchoolTerm:
return this.schoolTerm;
case clsvCurrEduClsEN.con_id_CourseType:
return this.id_CourseType;
case clsvCurrEduClsEN.con_CourseTypeID:
return this.courseTypeID;
case clsvCurrEduClsEN.con_CourseTypeName:
return this.courseTypeName;
case clsvCurrEduClsEN.con_IsDegree:
return this.isDegree;
case clsvCurrEduClsEN.con_id_ScoreType:
return this.id_ScoreType;
case clsvCurrEduClsEN.con_GetScoreWayId:
return this.getScoreWayId;
case clsvCurrEduClsEN.con_IsProportionalCtrl:
return this.isProportionalCtrl;
case clsvCurrEduClsEN.con_id_ExamType:
return this.id_ExamType;
case clsvCurrEduClsEN.con_BeginWeek:
return this.beginWeek;
case clsvCurrEduClsEN.con_ModifyDate:
return this.modifyDate;
case clsvCurrEduClsEN.con_ModifyUserID:
return this.modifyUserID;
case clsvCurrEduClsEN.con_Memo:
return this.memo;
case clsvCurrEduClsEN.con_CurrStuNum_Valid:
return this.currStuNum_Valid;
case clsvCurrEduClsEN.con_CurrStuNum:
return this.currStuNum;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[vCurrEduCls]中不存在！`;
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
case clsvCurrEduClsEN.con_id_CurrEduCls:
this.id_CurrEduCls = strValue;
break;
case clsvCurrEduClsEN.con_CurrEduClsId:
this.currEduClsId = strValue;
break;
case clsvCurrEduClsEN.con_EduClsName:
this.eduClsName = strValue;
break;
case clsvCurrEduClsEN.con_EduClsTypeId:
this.eduClsTypeId = strValue;
break;
case clsvCurrEduClsEN.con_EduClsTypeName:
this.eduClsTypeName = strValue;
break;
case clsvCurrEduClsEN.con_CourseId:
this.courseId = strValue;
break;
case clsvCurrEduClsEN.con_CourseCode:
this.courseCode = strValue;
break;
case clsvCurrEduClsEN.con_CourseDescription:
this.courseDescription = strValue;
break;
case clsvCurrEduClsEN.con_CourseName:
this.courseName = strValue;
break;
case clsvCurrEduClsEN.con_ViewCount:
this.viewCount = Number(strValue);
break;
case clsvCurrEduClsEN.con_ExampleImgPath:
this.exampleImgPath = strValue;
break;
case clsvCurrEduClsEN.con_TeachingSolutionId:
this.teachingSolutionId = strValue;
break;
case clsvCurrEduClsEN.con_TeachingSolutionName:
this.teachingSolutionName = strValue;
break;
case clsvCurrEduClsEN.con_id_Teacher:
this.id_Teacher = strValue;
break;
case clsvCurrEduClsEN.con_TeacherID:
this.teacherID = strValue;
break;
case clsvCurrEduClsEN.con_TeacherName:
this.teacherName = strValue;
break;
case clsvCurrEduClsEN.con_id_XzCollege:
this.id_XzCollege = strValue;
break;
case clsvCurrEduClsEN.con_CollegeID:
this.collegeID = strValue;
break;
case clsvCurrEduClsEN.con_CollegeName:
this.collegeName = strValue;
break;
case clsvCurrEduClsEN.con_ClgEnglishName:
this.clgEnglishName = strValue;
break;
case clsvCurrEduClsEN.con_PhoneNumber:
this.phoneNumber = strValue;
break;
case clsvCurrEduClsEN.con_id_XzMajor:
this.id_XzMajor = strValue;
break;
case clsvCurrEduClsEN.con_MajorName:
this.majorName = strValue;
break;
case clsvCurrEduClsEN.con_id_EduWay:
this.id_EduWay = strValue;
break;
case clsvCurrEduClsEN.con_id_ClassRoomType:
this.id_ClassRoomType = strValue;
break;
case clsvCurrEduClsEN.con_TotalLessonQty:
this.totalLessonQty = Number(strValue);
break;
case clsvCurrEduClsEN.con_MaxStuQty:
this.maxStuQty = Number(strValue);
break;
case clsvCurrEduClsEN.con_WeekQty:
this.weekQty = Number(strValue);
break;
case clsvCurrEduClsEN.con_ScheUnitPW:
this.scheUnitPW = Number(strValue);
break;
case clsvCurrEduClsEN.con_WeekStatusID:
this.weekStatusID = strValue;
break;
case clsvCurrEduClsEN.con_CustomerWeek:
this.customerWeek = strValue;
break;
case clsvCurrEduClsEN.con_LessonQtyPerWeek:
this.lessonQtyPerWeek = Number(strValue);
break;
case clsvCurrEduClsEN.con_Mark:
this.mark = Number(strValue);
break;
case clsvCurrEduClsEN.con_id_UniZone:
this.id_UniZone = strValue;
break;
case clsvCurrEduClsEN.con_id_GradeBase:
this.id_GradeBase = strValue;
break;
case clsvCurrEduClsEN.con_GradeBaseID:
this.gradeBaseID = strValue;
break;
case clsvCurrEduClsEN.con_GradeBaseName:
this.gradeBaseName = strValue;
break;
case clsvCurrEduClsEN.con_GradeBaseNameA:
this.gradeBaseNameA = strValue;
break;
case clsvCurrEduClsEN.con_IsEffective:
this.isEffective = Boolean(strValue);
break;
case clsvCurrEduClsEN.con_IsForPaperReading:
this.isForPaperReading = Boolean(strValue);
break;
case clsvCurrEduClsEN.con_SchoolYear:
this.schoolYear = strValue;
break;
case clsvCurrEduClsEN.con_SchoolTerm:
this.schoolTerm = strValue;
break;
case clsvCurrEduClsEN.con_id_CourseType:
this.id_CourseType = strValue;
break;
case clsvCurrEduClsEN.con_CourseTypeID:
this.courseTypeID = strValue;
break;
case clsvCurrEduClsEN.con_CourseTypeName:
this.courseTypeName = strValue;
break;
case clsvCurrEduClsEN.con_IsDegree:
this.isDegree = Boolean(strValue);
break;
case clsvCurrEduClsEN.con_id_ScoreType:
this.id_ScoreType = strValue;
break;
case clsvCurrEduClsEN.con_GetScoreWayId:
this.getScoreWayId = strValue;
break;
case clsvCurrEduClsEN.con_IsProportionalCtrl:
this.isProportionalCtrl = Boolean(strValue);
break;
case clsvCurrEduClsEN.con_id_ExamType:
this.id_ExamType = strValue;
break;
case clsvCurrEduClsEN.con_BeginWeek:
this.beginWeek = Number(strValue);
break;
case clsvCurrEduClsEN.con_ModifyDate:
this.modifyDate = strValue;
break;
case clsvCurrEduClsEN.con_ModifyUserID:
this.modifyUserID = strValue;
break;
case clsvCurrEduClsEN.con_Memo:
this.memo = strValue;
break;
case clsvCurrEduClsEN.con_CurrStuNum_Valid:
this.currStuNum_Valid = Number(strValue);
break;
case clsvCurrEduClsEN.con_CurrStuNum:
this.currStuNum = Number(strValue);
break;
case "sf_FldComparisonOp":
this.sf_FldComparisonOp = strValue;
break;
default:
strMsg = `字段名:[${strFldName}]在表对象:[vCurrEduCls]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
console.error(strMsg);
break;
}
}

/**
 * 设置对象中公共属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
*/
public id_CurrEduCls = "";    //教学班流水号
public currEduClsId = "";    //教学班Id
public eduClsName = "";    //教学班名
public eduClsTypeId = "";    //教学班类型Id
public eduClsTypeName = "";    //教学班类型名称
public courseId = "";    //课程Id
public courseCode = "";    //课程代码
public courseDescription = "";    //课程描述
public courseName = "";    //课程名称
public viewCount = 0;    //浏览量
public exampleImgPath = "";    //示例图路径
public teachingSolutionId = "";    //教学方案Id
public teachingSolutionName = "";    //教学方案名称
public id_Teacher = "";    //教师流水号
public teacherID = "";    //教师工号
public teacherName = "";    //教师姓名
public id_XzCollege = "";    //学院流水号
public collegeID = "";    //学院ID
public collegeName = "";    //学院名称
public clgEnglishName = "";    //ClgEnglishName
public phoneNumber = "";    //PhoneNumber
public id_XzMajor = "";    //专业流水号
public majorName = "";    //专业名称
public id_EduWay = "";    //教学方式流水号
public id_ClassRoomType = "";    //教室类型流水号
public totalLessonQty = 0;    //总课时数
public maxStuQty = 0;    //最大学生数
public weekQty = 0;    //总周数
public scheUnitPW = 0;    //周排课次数
public weekStatusID = "";    //周状态编号(单,双,全周)
public customerWeek = "";    //自定义上课周
public lessonQtyPerWeek = 0;    //周课时数
public mark = 0;    //获得学分
public id_UniZone = "";    //校区流水号
public id_GradeBase = "";    //年级流水号
public gradeBaseID = "";    //年级代号
public gradeBaseName = "";    //年级名称
public gradeBaseNameA = "";    //年级名称缩写
public isEffective = false;    //是否有效
public isForPaperReading = false;    //是否参与论文阅读
public schoolYear = "";    //学年
public schoolTerm = "";    //学期
public id_CourseType = "";    //课程类型流水号
public courseTypeID = "";    //课程类型ID
public courseTypeName = "";    //课程类型名称
public isDegree = false;    //是否学位课
public id_ScoreType = "";    //成绩类型流水号
public getScoreWayId = "";    //获得成绩方式Id
public isProportionalCtrl = false;    //是否比例控制
public id_ExamType = "";    //考试方式流水号
public beginWeek = 0;    //开始周
public modifyDate = "";    //修改日期
public modifyUserID = "";    //修改人
public memo = "";    //备注
public currStuNum_Valid = 0;    //CurrStuNum_Valid
public currStuNum = 0;    //当前学生数


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
 * 常量:"CourseDescription"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CourseDescription(): string {return "courseDescription";}    //课程描述

 /**
 * 常量:"CourseName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CourseName(): string {return "courseName";}    //课程名称

 /**
 * 常量:"ViewCount"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ViewCount(): string {return "viewCount";}    //浏览量

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
 * 常量:"CollegeName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CollegeName(): string {return "collegeName";}    //学院名称

 /**
 * 常量:"ClgEnglishName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ClgEnglishName(): string {return "clgEnglishName";}    //ClgEnglishName

 /**
 * 常量:"PhoneNumber"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PhoneNumber(): string {return "phoneNumber";}    //PhoneNumber

 /**
 * 常量:"id_XzMajor"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_XzMajor(): string {return "id_XzMajor";}    //专业流水号

 /**
 * 常量:"MajorName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_MajorName(): string {return "majorName";}    //专业名称

 /**
 * 常量:"id_EduWay"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_EduWay(): string {return "id_EduWay";}    //教学方式流水号

 /**
 * 常量:"id_ClassRoomType"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_ClassRoomType(): string {return "id_ClassRoomType";}    //教室类型流水号

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
 * 常量:"Mark"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Mark(): string {return "mark";}    //获得学分

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
 * 常量:"GradeBaseNameA"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_GradeBaseNameA(): string {return "gradeBaseNameA";}    //年级名称缩写

 /**
 * 常量:"IsEffective"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsEffective(): string {return "isEffective";}    //是否有效

 /**
 * 常量:"IsForPaperReading"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsForPaperReading(): string {return "isForPaperReading";}    //是否参与论文阅读

 /**
 * 常量:"SchoolYear"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SchoolYear(): string {return "schoolYear";}    //学年

 /**
 * 常量:"SchoolTerm"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SchoolTerm(): string {return "schoolTerm";}    //学期

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
 * 常量:"GetScoreWayId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_GetScoreWayId(): string {return "getScoreWayId";}    //获得成绩方式Id

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
 * 常量:"ModifyDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ModifyDate(): string {return "modifyDate";}    //修改日期

 /**
 * 常量:"ModifyUserID"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ModifyUserID(): string {return "modifyUserID";}    //修改人

 /**
 * 常量:"Memo"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Memo(): string {return "memo";}    //备注

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