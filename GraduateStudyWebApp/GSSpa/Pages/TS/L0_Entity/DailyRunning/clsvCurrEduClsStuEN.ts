
 /**
 * 类名:clsvCurrEduClsStuEN
 * 表名:vCurrEduClsStu(01120127)
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
 * v教学班与学生关系(vCurrEduClsStu)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTabV } from '../../PubFun/clsGeneralTabV.js';

export class clsvCurrEduClsStuEN extends clsGeneralTabV
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "02"; //客户端缓存
public static _CurrTabName= "vCurrEduClsStu"; //当前表名,与该类相关的表名
public static _KeyFldName= "id_EduClsStu"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 49;
public static AttributeName = ["id_EduClsStu", "id_CurrEduCls", "currEduClsId", "eduClsName", "courseId", "courseCode", "courseName", "teachingSolutionId", "teachingSolutionName", "id_XzCollege", "collegeID", "collegeName", "lessonQtyPerWeek", "mark", "id_UniZone", "gradeBaseName", "isEffective", "id_CourseType", "courseTypeID", "courseTypeName", "isDegree", "currStuNum", "id_Stu", "stuID", "stuName", "id_Sex", "sexDesc", "majorID", "majorName", "id_AdminCls", "birthday", "eduClsStuStateID", "getScoreTimes", "score", "totalScores", "ranking", "percentile", "confirmed", "schoolTerm", "schoolYear", "signInDate", "signInStateID", "signInUser", "modifyDate", "modifyUserID", "collegeName4Stu", "eduClsTypeName", "isSynScore", "eduClsTypeId"];
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
case clsvCurrEduClsStuEN.con_id_EduClsStu:
return this.id_EduClsStu;
case clsvCurrEduClsStuEN.con_id_CurrEduCls:
return this.id_CurrEduCls;
case clsvCurrEduClsStuEN.con_CurrEduClsId:
return this.currEduClsId;
case clsvCurrEduClsStuEN.con_EduClsName:
return this.eduClsName;
case clsvCurrEduClsStuEN.con_CourseId:
return this.courseId;
case clsvCurrEduClsStuEN.con_CourseCode:
return this.courseCode;
case clsvCurrEduClsStuEN.con_CourseName:
return this.courseName;
case clsvCurrEduClsStuEN.con_TeachingSolutionId:
return this.teachingSolutionId;
case clsvCurrEduClsStuEN.con_TeachingSolutionName:
return this.teachingSolutionName;
case clsvCurrEduClsStuEN.con_id_XzCollege:
return this.id_XzCollege;
case clsvCurrEduClsStuEN.con_CollegeID:
return this.collegeID;
case clsvCurrEduClsStuEN.con_CollegeName:
return this.collegeName;
case clsvCurrEduClsStuEN.con_LessonQtyPerWeek:
return this.lessonQtyPerWeek;
case clsvCurrEduClsStuEN.con_Mark:
return this.mark;
case clsvCurrEduClsStuEN.con_id_UniZone:
return this.id_UniZone;
case clsvCurrEduClsStuEN.con_GradeBaseName:
return this.gradeBaseName;
case clsvCurrEduClsStuEN.con_IsEffective:
return this.isEffective;
case clsvCurrEduClsStuEN.con_id_CourseType:
return this.id_CourseType;
case clsvCurrEduClsStuEN.con_CourseTypeID:
return this.courseTypeID;
case clsvCurrEduClsStuEN.con_CourseTypeName:
return this.courseTypeName;
case clsvCurrEduClsStuEN.con_IsDegree:
return this.isDegree;
case clsvCurrEduClsStuEN.con_CurrStuNum:
return this.currStuNum;
case clsvCurrEduClsStuEN.con_id_Stu:
return this.id_Stu;
case clsvCurrEduClsStuEN.con_StuID:
return this.stuID;
case clsvCurrEduClsStuEN.con_StuName:
return this.stuName;
case clsvCurrEduClsStuEN.con_id_Sex:
return this.id_Sex;
case clsvCurrEduClsStuEN.con_SexDesc:
return this.sexDesc;
case clsvCurrEduClsStuEN.con_MajorID:
return this.majorID;
case clsvCurrEduClsStuEN.con_MajorName:
return this.majorName;
case clsvCurrEduClsStuEN.con_id_AdminCls:
return this.id_AdminCls;
case clsvCurrEduClsStuEN.con_Birthday:
return this.birthday;
case clsvCurrEduClsStuEN.con_EduClsStuStateID:
return this.eduClsStuStateID;
case clsvCurrEduClsStuEN.con_GetScoreTimes:
return this.getScoreTimes;
case clsvCurrEduClsStuEN.con_Score:
return this.score;
case clsvCurrEduClsStuEN.con_TotalScores:
return this.totalScores;
case clsvCurrEduClsStuEN.con_Ranking:
return this.ranking;
case clsvCurrEduClsStuEN.con_Percentile:
return this.percentile;
case clsvCurrEduClsStuEN.con_Confirmed:
return this.confirmed;
case clsvCurrEduClsStuEN.con_SchoolTerm:
return this.schoolTerm;
case clsvCurrEduClsStuEN.con_SchoolYear:
return this.schoolYear;
case clsvCurrEduClsStuEN.con_SignInDate:
return this.signInDate;
case clsvCurrEduClsStuEN.con_SignInStateID:
return this.signInStateID;
case clsvCurrEduClsStuEN.con_SignInUser:
return this.signInUser;
case clsvCurrEduClsStuEN.con_ModifyDate:
return this.modifyDate;
case clsvCurrEduClsStuEN.con_ModifyUserID:
return this.modifyUserID;
case clsvCurrEduClsStuEN.con_CollegeName4Stu:
return this.collegeName4Stu;
case clsvCurrEduClsStuEN.con_EduClsTypeName:
return this.eduClsTypeName;
case clsvCurrEduClsStuEN.con_IsSynScore:
return this.isSynScore;
case clsvCurrEduClsStuEN.con_EduClsTypeId:
return this.eduClsTypeId;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[vCurrEduClsStu]中不存在！`;
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
case clsvCurrEduClsStuEN.con_id_EduClsStu:
this.id_EduClsStu = Number(strValue);
break;
case clsvCurrEduClsStuEN.con_id_CurrEduCls:
this.id_CurrEduCls = strValue;
break;
case clsvCurrEduClsStuEN.con_CurrEduClsId:
this.currEduClsId = strValue;
break;
case clsvCurrEduClsStuEN.con_EduClsName:
this.eduClsName = strValue;
break;
case clsvCurrEduClsStuEN.con_CourseId:
this.courseId = strValue;
break;
case clsvCurrEduClsStuEN.con_CourseCode:
this.courseCode = strValue;
break;
case clsvCurrEduClsStuEN.con_CourseName:
this.courseName = strValue;
break;
case clsvCurrEduClsStuEN.con_TeachingSolutionId:
this.teachingSolutionId = strValue;
break;
case clsvCurrEduClsStuEN.con_TeachingSolutionName:
this.teachingSolutionName = strValue;
break;
case clsvCurrEduClsStuEN.con_id_XzCollege:
this.id_XzCollege = strValue;
break;
case clsvCurrEduClsStuEN.con_CollegeID:
this.collegeID = strValue;
break;
case clsvCurrEduClsStuEN.con_CollegeName:
this.collegeName = strValue;
break;
case clsvCurrEduClsStuEN.con_LessonQtyPerWeek:
this.lessonQtyPerWeek = Number(strValue);
break;
case clsvCurrEduClsStuEN.con_Mark:
this.mark = Number(strValue);
break;
case clsvCurrEduClsStuEN.con_id_UniZone:
this.id_UniZone = strValue;
break;
case clsvCurrEduClsStuEN.con_GradeBaseName:
this.gradeBaseName = strValue;
break;
case clsvCurrEduClsStuEN.con_IsEffective:
this.isEffective = Boolean(strValue);
break;
case clsvCurrEduClsStuEN.con_id_CourseType:
this.id_CourseType = strValue;
break;
case clsvCurrEduClsStuEN.con_CourseTypeID:
this.courseTypeID = strValue;
break;
case clsvCurrEduClsStuEN.con_CourseTypeName:
this.courseTypeName = strValue;
break;
case clsvCurrEduClsStuEN.con_IsDegree:
this.isDegree = Boolean(strValue);
break;
case clsvCurrEduClsStuEN.con_CurrStuNum:
this.currStuNum = Number(strValue);
break;
case clsvCurrEduClsStuEN.con_id_Stu:
this.id_Stu = strValue;
break;
case clsvCurrEduClsStuEN.con_StuID:
this.stuID = strValue;
break;
case clsvCurrEduClsStuEN.con_StuName:
this.stuName = strValue;
break;
case clsvCurrEduClsStuEN.con_id_Sex:
this.id_Sex = strValue;
break;
case clsvCurrEduClsStuEN.con_SexDesc:
this.sexDesc = strValue;
break;
case clsvCurrEduClsStuEN.con_MajorID:
this.majorID = strValue;
break;
case clsvCurrEduClsStuEN.con_MajorName:
this.majorName = strValue;
break;
case clsvCurrEduClsStuEN.con_id_AdminCls:
this.id_AdminCls = strValue;
break;
case clsvCurrEduClsStuEN.con_Birthday:
this.birthday = strValue;
break;
case clsvCurrEduClsStuEN.con_EduClsStuStateID:
this.eduClsStuStateID = strValue;
break;
case clsvCurrEduClsStuEN.con_GetScoreTimes:
this.getScoreTimes = Number(strValue);
break;
case clsvCurrEduClsStuEN.con_Score:
this.score = Number(strValue);
break;
case clsvCurrEduClsStuEN.con_TotalScores:
this.totalScores = Number(strValue);
break;
case clsvCurrEduClsStuEN.con_Ranking:
this.ranking = Number(strValue);
break;
case clsvCurrEduClsStuEN.con_Percentile:
this.percentile = Number(strValue);
break;
case clsvCurrEduClsStuEN.con_Confirmed:
this.confirmed = Boolean(strValue);
break;
case clsvCurrEduClsStuEN.con_SchoolTerm:
this.schoolTerm = strValue;
break;
case clsvCurrEduClsStuEN.con_SchoolYear:
this.schoolYear = strValue;
break;
case clsvCurrEduClsStuEN.con_SignInDate:
this.signInDate = strValue;
break;
case clsvCurrEduClsStuEN.con_SignInStateID:
this.signInStateID = strValue;
break;
case clsvCurrEduClsStuEN.con_SignInUser:
this.signInUser = strValue;
break;
case clsvCurrEduClsStuEN.con_ModifyDate:
this.modifyDate = strValue;
break;
case clsvCurrEduClsStuEN.con_ModifyUserID:
this.modifyUserID = strValue;
break;
case clsvCurrEduClsStuEN.con_CollegeName4Stu:
this.collegeName4Stu = strValue;
break;
case clsvCurrEduClsStuEN.con_EduClsTypeName:
this.eduClsTypeName = strValue;
break;
case clsvCurrEduClsStuEN.con_IsSynScore:
this.isSynScore = Boolean(strValue);
break;
case clsvCurrEduClsStuEN.con_EduClsTypeId:
this.eduClsTypeId = strValue;
break;
case "sf_FldComparisonOp":
this.sf_FldComparisonOp = strValue;
break;
default:
strMsg = `字段名:[${strFldName}]在表对象:[vCurrEduClsStu]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
console.error(strMsg);
break;
}
}

/**
 * 设置对象中公共属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
*/
public id_EduClsStu = 0;    //教学班学生流水号
public id_CurrEduCls = "";    //教学班流水号
public currEduClsId = "";    //教学班Id
public eduClsName = "";    //教学班名
public courseId = "";    //课程Id
public courseCode = "";    //课程代码
public courseName = "";    //课程名称
public teachingSolutionId = "";    //教学方案Id
public teachingSolutionName = "";    //教学方案名称
public id_XzCollege = "";    //学院流水号
public collegeID = "";    //学院ID
public collegeName = "";    //学院名称
public lessonQtyPerWeek = 0;    //周课时数
public mark = 0;    //获得学分
public id_UniZone = "";    //校区流水号
public gradeBaseName = "";    //年级名称
public isEffective = false;    //是否有效
public id_CourseType = "";    //课程类型流水号
public courseTypeID = "";    //课程类型ID
public courseTypeName = "";    //课程类型名称
public isDegree = false;    //是否学位课
public currStuNum = 0;    //当前学生数
public id_Stu = "";    //学生流水号
public stuID = "";    //学号
public stuName = "";    //姓名
public id_Sex = "";    //性别流水号
public sexDesc = "";    //性别名称
public majorID = "";    //专业ID
public majorName = "";    //专业名称
public id_AdminCls = "";    //行政班流水号
public birthday = "";    //出生日期
public eduClsStuStateID = "";    //教学班学生状态编号
public getScoreTimes = 0;    //获得成绩次数
public score = 0;    //得分
public totalScores = 0;    //总分值
public ranking = 0;    //名次
public percentile = 0;    //百分位
public confirmed = false;    //是否确认
public schoolTerm = "";    //学期
public schoolYear = "";    //学年
public signInDate = "";    //签入时间
public signInStateID = "";    //签入状态表流水号
public signInUser = "";    //签入人
public modifyDate = "";    //修改日期
public modifyUserID = "";    //修改人
public collegeName4Stu = "";    //CollegeName4Stu
public eduClsTypeName = "";    //教学班类型名称
public isSynScore = false;    //是否同步成绩
public eduClsTypeId = "";    //教学班类型Id


 /**
 * 常量:"id_EduClsStu"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_EduClsStu(): string {return "id_EduClsStu";}    //教学班学生流水号

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
 * 常量:"CollegeName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CollegeName(): string {return "collegeName";}    //学院名称

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
 * 常量:"CurrStuNum"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CurrStuNum(): string {return "currStuNum";}    //当前学生数

 /**
 * 常量:"id_Stu"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_Stu(): string {return "id_Stu";}    //学生流水号

 /**
 * 常量:"StuID"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_StuID(): string {return "stuID";}    //学号

 /**
 * 常量:"StuName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_StuName(): string {return "stuName";}    //姓名

 /**
 * 常量:"id_Sex"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_Sex(): string {return "id_Sex";}    //性别流水号

 /**
 * 常量:"SexDesc"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SexDesc(): string {return "sexDesc";}    //性别名称

 /**
 * 常量:"MajorID"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_MajorID(): string {return "majorID";}    //专业ID

 /**
 * 常量:"MajorName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_MajorName(): string {return "majorName";}    //专业名称

 /**
 * 常量:"id_AdminCls"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_AdminCls(): string {return "id_AdminCls";}    //行政班流水号

 /**
 * 常量:"Birthday"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Birthday(): string {return "birthday";}    //出生日期

 /**
 * 常量:"EduClsStuStateID"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_EduClsStuStateID(): string {return "eduClsStuStateID";}    //教学班学生状态编号

 /**
 * 常量:"GetScoreTimes"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_GetScoreTimes(): string {return "getScoreTimes";}    //获得成绩次数

 /**
 * 常量:"Score"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Score(): string {return "score";}    //得分

 /**
 * 常量:"TotalScores"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_TotalScores(): string {return "totalScores";}    //总分值

 /**
 * 常量:"Ranking"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Ranking(): string {return "ranking";}    //名次

 /**
 * 常量:"Percentile"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Percentile(): string {return "percentile";}    //百分位

 /**
 * 常量:"Confirmed"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Confirmed(): string {return "confirmed";}    //是否确认

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
 * 常量:"SignInDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SignInDate(): string {return "signInDate";}    //签入时间

 /**
 * 常量:"SignInStateID"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SignInStateID(): string {return "signInStateID";}    //签入状态表流水号

 /**
 * 常量:"SignInUser"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SignInUser(): string {return "signInUser";}    //签入人

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
 * 常量:"CollegeName4Stu"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CollegeName4Stu(): string {return "collegeName4Stu";}    //CollegeName4Stu

 /**
 * 常量:"EduClsTypeName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_EduClsTypeName(): string {return "eduClsTypeName";}    //教学班类型名称

 /**
 * 常量:"IsSynScore"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsSynScore(): string {return "isSynScore";}    //是否同步成绩

 /**
 * 常量:"EduClsTypeId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_EduClsTypeId(): string {return "eduClsTypeId";}    //教学班类型Id

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