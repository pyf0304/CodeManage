
 /**
 * 类名:clsvTeacherInfoEN
 * 表名:vTeacherInfo(01120094)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 12:02:27
 * 生成者:pyf
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:人员管理(PeopleManage)
 * 框架-层名:实体层(TS)(EntityLayer)
 * 编程语言:TypeScript
 **/
 /**
 * v教师(vTeacherInfo)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTabV } from '../../PubFun/clsGeneralTabV.js';

export class clsvTeacherInfoEN extends clsGeneralTabV
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "05"; //未知
public static _CurrTabName= "vTeacherInfo"; //当前表名,与该类相关的表名
public static _KeyFldName= "id_Teacher"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 65;
public static AttributeName = ["id_Teacher", "teacherID", "teacherName", "id_Sex", "sexDesc", "id_School_Ps", "schoolId", "schoolName", "id_Discipline_Ps", "id_UniZone", "uniZoneDesc", "id_Ethnic", "ethnicName", "id_Politics", "politicsName", "id_AdminGrade", "adminGradeDesc", "id_ProfGrade", "profenssionalGradeName", "id_Qualif", "qualifDesc", "id_Degree", "degreeName", "id_StaffType", "staffTypeName", "id_Province", "provinceName", "citizenID", "cardNo", "birthday", "graduationMajor", "telNo", "email", "webSite", "personBlog", "entryDate", "offed", "id_CardNo", "isAvconUser", "isGpUser", "isLocalUser", "fromUnit", "memo", "id_XzCollege", "collegeID", "collegeName", "collegeNameA", "id_XzMajor", "entryDay", "id_Photo", "id_Religion", "religionName", "isMessage", "microblog", "modifyUserID", "offedBak", "phoneNumber", "qQ", "teach_id_College", "teach_id_Major", "tel", "modifyDate", "registerPassword", "entryYear", "disciplineName_ps"];
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
case clsvTeacherInfoEN.con_id_Teacher:
return this.id_Teacher;
case clsvTeacherInfoEN.con_TeacherID:
return this.teacherID;
case clsvTeacherInfoEN.con_TeacherName:
return this.teacherName;
case clsvTeacherInfoEN.con_id_Sex:
return this.id_Sex;
case clsvTeacherInfoEN.con_SexDesc:
return this.sexDesc;
case clsvTeacherInfoEN.con_id_School_Ps:
return this.id_School_Ps;
case clsvTeacherInfoEN.con_SchoolId:
return this.schoolId;
case clsvTeacherInfoEN.con_SchoolName:
return this.schoolName;
case clsvTeacherInfoEN.con_id_Discipline_Ps:
return this.id_Discipline_Ps;
case clsvTeacherInfoEN.con_id_UniZone:
return this.id_UniZone;
case clsvTeacherInfoEN.con_UniZoneDesc:
return this.uniZoneDesc;
case clsvTeacherInfoEN.con_id_Ethnic:
return this.id_Ethnic;
case clsvTeacherInfoEN.con_EthnicName:
return this.ethnicName;
case clsvTeacherInfoEN.con_id_Politics:
return this.id_Politics;
case clsvTeacherInfoEN.con_PoliticsName:
return this.politicsName;
case clsvTeacherInfoEN.con_id_AdminGrade:
return this.id_AdminGrade;
case clsvTeacherInfoEN.con_AdminGradeDesc:
return this.adminGradeDesc;
case clsvTeacherInfoEN.con_id_ProfGrade:
return this.id_ProfGrade;
case clsvTeacherInfoEN.con_ProfenssionalGradeName:
return this.profenssionalGradeName;
case clsvTeacherInfoEN.con_id_Qualif:
return this.id_Qualif;
case clsvTeacherInfoEN.con_QualifDesc:
return this.qualifDesc;
case clsvTeacherInfoEN.con_id_Degree:
return this.id_Degree;
case clsvTeacherInfoEN.con_DegreeName:
return this.degreeName;
case clsvTeacherInfoEN.con_id_StaffType:
return this.id_StaffType;
case clsvTeacherInfoEN.con_StaffTypeName:
return this.staffTypeName;
case clsvTeacherInfoEN.con_id_Province:
return this.id_Province;
case clsvTeacherInfoEN.con_ProvinceName:
return this.provinceName;
case clsvTeacherInfoEN.con_CitizenID:
return this.citizenID;
case clsvTeacherInfoEN.con_CardNo:
return this.cardNo;
case clsvTeacherInfoEN.con_Birthday:
return this.birthday;
case clsvTeacherInfoEN.con_GraduationMajor:
return this.graduationMajor;
case clsvTeacherInfoEN.con_TelNo:
return this.telNo;
case clsvTeacherInfoEN.con_Email:
return this.email;
case clsvTeacherInfoEN.con_WebSite:
return this.webSite;
case clsvTeacherInfoEN.con_PersonBlog:
return this.personBlog;
case clsvTeacherInfoEN.con_EntryDate:
return this.entryDate;
case clsvTeacherInfoEN.con_Offed:
return this.offed;
case clsvTeacherInfoEN.con_Id_CardNo:
return this.id_CardNo;
case clsvTeacherInfoEN.con_IsAvconUser:
return this.isAvconUser;
case clsvTeacherInfoEN.con_IsGpUser:
return this.isGpUser;
case clsvTeacherInfoEN.con_IsLocalUser:
return this.isLocalUser;
case clsvTeacherInfoEN.con_FromUnit:
return this.fromUnit;
case clsvTeacherInfoEN.con_Memo:
return this.memo;
case clsvTeacherInfoEN.con_id_XzCollege:
return this.id_XzCollege;
case clsvTeacherInfoEN.con_CollegeID:
return this.collegeID;
case clsvTeacherInfoEN.con_CollegeName:
return this.collegeName;
case clsvTeacherInfoEN.con_CollegeNameA:
return this.collegeNameA;
case clsvTeacherInfoEN.con_id_XzMajor:
return this.id_XzMajor;
case clsvTeacherInfoEN.con_EntryDay:
return this.entryDay;
case clsvTeacherInfoEN.con_id_Photo:
return this.id_Photo;
case clsvTeacherInfoEN.con_id_Religion:
return this.id_Religion;
case clsvTeacherInfoEN.con_ReligionName:
return this.religionName;
case clsvTeacherInfoEN.con_IsMessage:
return this.isMessage;
case clsvTeacherInfoEN.con_Microblog:
return this.microblog;
case clsvTeacherInfoEN.con_ModifyUserID:
return this.modifyUserID;
case clsvTeacherInfoEN.con_OffedBak:
return this.offedBak;
case clsvTeacherInfoEN.con_PhoneNumber:
return this.phoneNumber;
case clsvTeacherInfoEN.con_QQ:
return this.qQ;
case clsvTeacherInfoEN.con_Teach_id_College:
return this.teach_id_College;
case clsvTeacherInfoEN.con_Teach_id_Major:
return this.teach_id_Major;
case clsvTeacherInfoEN.con_Tel:
return this.tel;
case clsvTeacherInfoEN.con_ModifyDate:
return this.modifyDate;
case clsvTeacherInfoEN.con_RegisterPassword:
return this.registerPassword;
case clsvTeacherInfoEN.con_EntryYear:
return this.entryYear;
case clsvTeacherInfoEN.con_DisciplineName_ps:
return this.disciplineName_ps;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[vTeacherInfo]中不存在！`;
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
case clsvTeacherInfoEN.con_id_Teacher:
this.id_Teacher = strValue;
break;
case clsvTeacherInfoEN.con_TeacherID:
this.teacherID = strValue;
break;
case clsvTeacherInfoEN.con_TeacherName:
this.teacherName = strValue;
break;
case clsvTeacherInfoEN.con_id_Sex:
this.id_Sex = strValue;
break;
case clsvTeacherInfoEN.con_SexDesc:
this.sexDesc = strValue;
break;
case clsvTeacherInfoEN.con_id_School_Ps:
this.id_School_Ps = strValue;
break;
case clsvTeacherInfoEN.con_SchoolId:
this.schoolId = strValue;
break;
case clsvTeacherInfoEN.con_SchoolName:
this.schoolName = strValue;
break;
case clsvTeacherInfoEN.con_id_Discipline_Ps:
this.id_Discipline_Ps = strValue;
break;
case clsvTeacherInfoEN.con_id_UniZone:
this.id_UniZone = strValue;
break;
case clsvTeacherInfoEN.con_UniZoneDesc:
this.uniZoneDesc = strValue;
break;
case clsvTeacherInfoEN.con_id_Ethnic:
this.id_Ethnic = strValue;
break;
case clsvTeacherInfoEN.con_EthnicName:
this.ethnicName = strValue;
break;
case clsvTeacherInfoEN.con_id_Politics:
this.id_Politics = strValue;
break;
case clsvTeacherInfoEN.con_PoliticsName:
this.politicsName = strValue;
break;
case clsvTeacherInfoEN.con_id_AdminGrade:
this.id_AdminGrade = strValue;
break;
case clsvTeacherInfoEN.con_AdminGradeDesc:
this.adminGradeDesc = strValue;
break;
case clsvTeacherInfoEN.con_id_ProfGrade:
this.id_ProfGrade = strValue;
break;
case clsvTeacherInfoEN.con_ProfenssionalGradeName:
this.profenssionalGradeName = strValue;
break;
case clsvTeacherInfoEN.con_id_Qualif:
this.id_Qualif = strValue;
break;
case clsvTeacherInfoEN.con_QualifDesc:
this.qualifDesc = strValue;
break;
case clsvTeacherInfoEN.con_id_Degree:
this.id_Degree = strValue;
break;
case clsvTeacherInfoEN.con_DegreeName:
this.degreeName = strValue;
break;
case clsvTeacherInfoEN.con_id_StaffType:
this.id_StaffType = strValue;
break;
case clsvTeacherInfoEN.con_StaffTypeName:
this.staffTypeName = strValue;
break;
case clsvTeacherInfoEN.con_id_Province:
this.id_Province = strValue;
break;
case clsvTeacherInfoEN.con_ProvinceName:
this.provinceName = strValue;
break;
case clsvTeacherInfoEN.con_CitizenID:
this.citizenID = strValue;
break;
case clsvTeacherInfoEN.con_CardNo:
this.cardNo = strValue;
break;
case clsvTeacherInfoEN.con_Birthday:
this.birthday = strValue;
break;
case clsvTeacherInfoEN.con_GraduationMajor:
this.graduationMajor = strValue;
break;
case clsvTeacherInfoEN.con_TelNo:
this.telNo = strValue;
break;
case clsvTeacherInfoEN.con_Email:
this.email = strValue;
break;
case clsvTeacherInfoEN.con_WebSite:
this.webSite = strValue;
break;
case clsvTeacherInfoEN.con_PersonBlog:
this.personBlog = strValue;
break;
case clsvTeacherInfoEN.con_EntryDate:
this.entryDate = strValue;
break;
case clsvTeacherInfoEN.con_Offed:
this.offed = Boolean(strValue);
break;
case clsvTeacherInfoEN.con_Id_CardNo:
this.id_CardNo = strValue;
break;
case clsvTeacherInfoEN.con_IsAvconUser:
this.isAvconUser = Boolean(strValue);
break;
case clsvTeacherInfoEN.con_IsGpUser:
this.isGpUser = Boolean(strValue);
break;
case clsvTeacherInfoEN.con_IsLocalUser:
this.isLocalUser = Boolean(strValue);
break;
case clsvTeacherInfoEN.con_FromUnit:
this.fromUnit = strValue;
break;
case clsvTeacherInfoEN.con_Memo:
this.memo = strValue;
break;
case clsvTeacherInfoEN.con_id_XzCollege:
this.id_XzCollege = strValue;
break;
case clsvTeacherInfoEN.con_CollegeID:
this.collegeID = strValue;
break;
case clsvTeacherInfoEN.con_CollegeName:
this.collegeName = strValue;
break;
case clsvTeacherInfoEN.con_CollegeNameA:
this.collegeNameA = strValue;
break;
case clsvTeacherInfoEN.con_id_XzMajor:
this.id_XzMajor = strValue;
break;
case clsvTeacherInfoEN.con_EntryDay:
this.entryDay = strValue;
break;
case clsvTeacherInfoEN.con_id_Photo:
this.id_Photo = strValue;
break;
case clsvTeacherInfoEN.con_id_Religion:
this.id_Religion = strValue;
break;
case clsvTeacherInfoEN.con_ReligionName:
this.religionName = strValue;
break;
case clsvTeacherInfoEN.con_IsMessage:
this.isMessage = Boolean(strValue);
break;
case clsvTeacherInfoEN.con_Microblog:
this.microblog = strValue;
break;
case clsvTeacherInfoEN.con_ModifyUserID:
this.modifyUserID = strValue;
break;
case clsvTeacherInfoEN.con_OffedBak:
this.offedBak = Boolean(strValue);
break;
case clsvTeacherInfoEN.con_PhoneNumber:
this.phoneNumber = strValue;
break;
case clsvTeacherInfoEN.con_QQ:
this.qQ = strValue;
break;
case clsvTeacherInfoEN.con_Teach_id_College:
this.teach_id_College = strValue;
break;
case clsvTeacherInfoEN.con_Teach_id_Major:
this.teach_id_Major = strValue;
break;
case clsvTeacherInfoEN.con_Tel:
this.tel = strValue;
break;
case clsvTeacherInfoEN.con_ModifyDate:
this.modifyDate = strValue;
break;
case clsvTeacherInfoEN.con_RegisterPassword:
this.registerPassword = strValue;
break;
case clsvTeacherInfoEN.con_EntryYear:
this.entryYear = strValue;
break;
case clsvTeacherInfoEN.con_DisciplineName_ps:
this.disciplineName_ps = strValue;
break;
case "sf_FldComparisonOp":
this.sf_FldComparisonOp = strValue;
break;
default:
strMsg = `字段名:[${strFldName}]在表对象:[vTeacherInfo]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
console.error(strMsg);
break;
}
}

/**
 * 设置对象中公共属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
*/
public id_Teacher = "";    //教师流水号
public teacherID = "";    //教师工号
public teacherName = "";    //教师姓名
public id_Sex = "";    //性别流水号
public sexDesc = "";    //性别名称
public id_School_Ps = "";    //学校流水号
public schoolId = "";    //学校编号
public schoolName = "";    //学校名称
public id_Discipline_Ps = "";    //学科流水号
public id_UniZone = "";    //校区流水号
public uniZoneDesc = "";    //校区名称
public id_Ethnic = "";    //民族流水号
public ethnicName = "";    //民族名称
public id_Politics = "";    //政治面貌流水号
public politicsName = "";    //政治面貌
public id_AdminGrade = "";    //行政职务流水号
public adminGradeDesc = "";    //行政职务描述
public id_ProfGrade = "";    //专业职称流水号
public profenssionalGradeName = "";    //专业职称
public id_Qualif = "";    //学历流水号
public qualifDesc = "";    //QualifDesc
public id_Degree = "";    //学位流水号
public degreeName = "";    //学位名称
public id_StaffType = "";    //职工类型流水号
public staffTypeName = "";    //职工类型名称
public id_Province = "";    //省份流水号
public provinceName = "";    //ProvinceName
public citizenID = "";    //身份证号
public cardNo = "";    //卡号
public birthday = "";    //出生日期
public graduationMajor = "";    //毕业专业
public telNo = "";    //电话
public email = "";    //电子邮箱
public webSite = "";    //个人主页
public personBlog = "";    //个人博客
public entryDate = "";    //进校日期
public offed = false;    //是否离校
public id_CardNo = "";    //内卡号
public isAvconUser = false;    //IsAvconUser
public isGpUser = false;    //是否Gp用户
public isLocalUser = false;    //是否本地用户
public fromUnit = "";    //来自单位
public memo = "";    //备注
public id_XzCollege = "";    //学院流水号
public collegeID = "";    //学院ID
public collegeName = "";    //学院名称
public collegeNameA = "";    //学院名称简写
public id_XzMajor = "";    //专业流水号
public entryDay = "";    //EntryDay
public id_Photo = "";    //id_Photo
public id_Religion = "";    //id_Religion
public religionName = "";    //ReligionName
public isMessage = false;    //IsMessage
public microblog = "";    //Microblog
public modifyUserID = "";    //修改人
public offedBak = false;    //OffedBak
public phoneNumber = "";    //PhoneNumber
public qQ = "";    //QQ
public teach_id_College = "";    //Teach_id_College
public teach_id_Major = "";    //Teach_id_Major
public tel = "";    //Tel
public modifyDate = "";    //修改日期
public registerPassword = "";    //RegisterPassword
public entryYear = "";    //EntryYear
public disciplineName_ps = "";    //学科


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
 * 常量:"id_School_Ps"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_School_Ps(): string {return "id_School_Ps";}    //学校流水号

 /**
 * 常量:"SchoolId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SchoolId(): string {return "schoolId";}    //学校编号

 /**
 * 常量:"SchoolName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SchoolName(): string {return "schoolName";}    //学校名称

 /**
 * 常量:"id_Discipline_Ps"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_Discipline_Ps(): string {return "id_Discipline_Ps";}    //学科流水号

 /**
 * 常量:"id_UniZone"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_UniZone(): string {return "id_UniZone";}    //校区流水号

 /**
 * 常量:"UniZoneDesc"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UniZoneDesc(): string {return "uniZoneDesc";}    //校区名称

 /**
 * 常量:"id_Ethnic"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_Ethnic(): string {return "id_Ethnic";}    //民族流水号

 /**
 * 常量:"EthnicName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_EthnicName(): string {return "ethnicName";}    //民族名称

 /**
 * 常量:"id_Politics"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_Politics(): string {return "id_Politics";}    //政治面貌流水号

 /**
 * 常量:"PoliticsName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PoliticsName(): string {return "politicsName";}    //政治面貌

 /**
 * 常量:"id_AdminGrade"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_AdminGrade(): string {return "id_AdminGrade";}    //行政职务流水号

 /**
 * 常量:"AdminGradeDesc"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_AdminGradeDesc(): string {return "adminGradeDesc";}    //行政职务描述

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
 * 常量:"id_Qualif"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_Qualif(): string {return "id_Qualif";}    //学历流水号

 /**
 * 常量:"QualifDesc"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_QualifDesc(): string {return "qualifDesc";}    //QualifDesc

 /**
 * 常量:"id_Degree"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_Degree(): string {return "id_Degree";}    //学位流水号

 /**
 * 常量:"DegreeName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_DegreeName(): string {return "degreeName";}    //学位名称

 /**
 * 常量:"id_StaffType"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_StaffType(): string {return "id_StaffType";}    //职工类型流水号

 /**
 * 常量:"StaffTypeName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_StaffTypeName(): string {return "staffTypeName";}    //职工类型名称

 /**
 * 常量:"id_Province"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_Province(): string {return "id_Province";}    //省份流水号

 /**
 * 常量:"ProvinceName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ProvinceName(): string {return "provinceName";}    //ProvinceName

 /**
 * 常量:"CitizenID"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CitizenID(): string {return "citizenID";}    //身份证号

 /**
 * 常量:"CardNo"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CardNo(): string {return "cardNo";}    //卡号

 /**
 * 常量:"Birthday"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Birthday(): string {return "birthday";}    //出生日期

 /**
 * 常量:"GraduationMajor"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_GraduationMajor(): string {return "graduationMajor";}    //毕业专业

 /**
 * 常量:"TelNo"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_TelNo(): string {return "telNo";}    //电话

 /**
 * 常量:"Email"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Email(): string {return "email";}    //电子邮箱

 /**
 * 常量:"WebSite"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_WebSite(): string {return "webSite";}    //个人主页

 /**
 * 常量:"PersonBlog"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PersonBlog(): string {return "personBlog";}    //个人博客

 /**
 * 常量:"EntryDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_EntryDate(): string {return "entryDate";}    //进校日期

 /**
 * 常量:"Offed"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Offed(): string {return "offed";}    //是否离校

 /**
 * 常量:"Id_CardNo"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Id_CardNo(): string {return "id_CardNo";}    //内卡号

 /**
 * 常量:"IsAvconUser"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsAvconUser(): string {return "isAvconUser";}    //IsAvconUser

 /**
 * 常量:"IsGpUser"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsGpUser(): string {return "isGpUser";}    //是否Gp用户

 /**
 * 常量:"IsLocalUser"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsLocalUser(): string {return "isLocalUser";}    //是否本地用户

 /**
 * 常量:"FromUnit"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_FromUnit(): string {return "fromUnit";}    //来自单位

 /**
 * 常量:"Memo"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Memo(): string {return "memo";}    //备注

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
 * 常量:"CollegeNameA"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CollegeNameA(): string {return "collegeNameA";}    //学院名称简写

 /**
 * 常量:"id_XzMajor"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_XzMajor(): string {return "id_XzMajor";}    //专业流水号

 /**
 * 常量:"EntryDay"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_EntryDay(): string {return "entryDay";}    //EntryDay

 /**
 * 常量:"id_Photo"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_Photo(): string {return "id_Photo";}    //id_Photo

 /**
 * 常量:"id_Religion"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_Religion(): string {return "id_Religion";}    //id_Religion

 /**
 * 常量:"ReligionName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ReligionName(): string {return "religionName";}    //ReligionName

 /**
 * 常量:"IsMessage"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsMessage(): string {return "isMessage";}    //IsMessage

 /**
 * 常量:"Microblog"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Microblog(): string {return "microblog";}    //Microblog

 /**
 * 常量:"ModifyUserID"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ModifyUserID(): string {return "modifyUserID";}    //修改人

 /**
 * 常量:"OffedBak"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_OffedBak(): string {return "offedBak";}    //OffedBak

 /**
 * 常量:"PhoneNumber"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PhoneNumber(): string {return "phoneNumber";}    //PhoneNumber

 /**
 * 常量:"QQ"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_QQ(): string {return "qQ";}    //QQ

 /**
 * 常量:"Teach_id_College"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Teach_id_College(): string {return "teach_id_College";}    //Teach_id_College

 /**
 * 常量:"Teach_id_Major"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Teach_id_Major(): string {return "teach_id_Major";}    //Teach_id_Major

 /**
 * 常量:"Tel"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Tel(): string {return "tel";}    //Tel

 /**
 * 常量:"ModifyDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ModifyDate(): string {return "modifyDate";}    //修改日期

 /**
 * 常量:"RegisterPassword"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_RegisterPassword(): string {return "registerPassword";}    //RegisterPassword

 /**
 * 常量:"EntryYear"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_EntryYear(): string {return "entryYear";}    //EntryYear

 /**
 * 常量:"DisciplineName_ps"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_DisciplineName_ps(): string {return "disciplineName_ps";}    //学科

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