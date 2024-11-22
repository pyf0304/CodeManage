
 /**
 * 类名:clsTeacherInfoEN
 * 表名:TeacherInfo(01120093)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:05
 * 生成者:pyf
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:基本信息维护(BaseInfo)
 * 框架-层名:实体层(TS)(EntityLayer)
 * 编程语言:TypeScript
 **/
 /**
 * 教师(TeacherInfo)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTab } from '../../PubFun/clsGeneralTab.js';

export class clsTeacherInfoEN extends clsGeneralTab
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "02"; //客户端缓存
public static _CurrTabName= "TeacherInfo"; //当前表名,与该类相关的表名
public static _KeyFldName= "id_Teacher"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 49;
public static AttributeName = ["id_Teacher", "teacherID", "teacherName", "id_Sex", "id_School_Ps", "id_Discipline_Ps", "id_UniZone", "id_Ethnic", "id_Politics", "id_AdminGrade", "id_ProfGrade", "id_Qualif", "id_Degree", "id_StaffType", "id_Province", "citizenID", "cardNo", "birthday", "graduationMajor", "telNo", "email", "webSite", "personBlog", "entryDate", "offed", "id_CardNo", "isAvconUser", "isGpUser", "isLocalUser", "fromUnit", "memo", "id_XzCollege", "id_XzMajor", "entryDay", "id_Photo", "id_Religion", "isMessage", "microblog", "modifyUserID", "offedBak", "phoneNumber", "qQ", "teach_id_College", "teach_id_Major", "tel", "headphoto", "modifyDate", "registerPassword", "teacherPhoto"];
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
 * 设置对象中私有属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPrivateVar)
*/
private mstrid_Teacher = "";    //教师流水号
private mstrTeacherID = "";    //教师工号
private mstrTeacherName = "";    //教师姓名
private mstrid_Sex = "";    //性别流水号
private mstrid_School_Ps = "";    //学校流水号
private mstrid_Discipline_Ps = "";    //学科流水号
private mstrid_UniZone = "";    //校区流水号
private mstrid_Ethnic = "";    //民族流水号
private mstrid_Politics = "";    //政治面貌流水号
private mstrid_AdminGrade = "";    //行政职务流水号
private mstrid_ProfGrade = "";    //专业职称流水号
private mstrid_Qualif = "";    //学历流水号
private mstrid_Degree = "";    //学位流水号
private mstrid_StaffType = "";    //职工类型流水号
private mstrid_Province = "";    //省份流水号
private mstrCitizenID = "";    //身份证号
private mstrCardNo = "";    //卡号
private mstrBirthday = "";    //出生日期
private mstrGraduationMajor = "";    //毕业专业
private mstrTelNo = "";    //电话
private mstrEmail = "";    //电子邮箱
private mstrWebSite = "";    //个人主页
private mstrPersonBlog = "";    //个人博客
private mstrEntryDate = "";    //进校日期
private mbolOffed = false;    //是否离校
private mstrId_CardNo = "";    //内卡号
private mbolIsAvconUser = false;    //IsAvconUser
private mbolIsGpUser = false;    //是否Gp用户
private mbolIsLocalUser = false;    //是否本地用户
private mstrFromUnit = "";    //来自单位
private mstrMemo = "";    //备注
private mstrid_XzCollege = "";    //学院流水号
private mstrid_XzMajor = "";    //专业流水号
private mstrEntryDay = "";    //EntryDay
private mstrid_Photo = "";    //id_Photo
private mstrid_Religion = "";    //id_Religion
private mbolIsMessage = false;    //IsMessage
private mstrMicroblog = "";    //Microblog
private mstrModifyUserID = "";    //修改人
private mbolOffedBak = false;    //OffedBak
private mstrPhoneNumber = "";    //PhoneNumber
private mstrQQ = "";    //QQ
private mstrTeach_id_College = "";    //Teach_id_College
private mstrTeach_id_Major = "";    //Teach_id_Major
private mstrTel = "";    //Tel
private mstrHeadphoto = "";    //Headphoto
private mstrModifyDate = "";    //修改日期
private mstrRegisterPassword = "";    //RegisterPassword
private mstrTeacherPhoto = "";    //TeacherPhoto

/**
 * 教师流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setid_Teacher (value: string)
{
if (value  != undefined)
{
 this.id_Teacher = value;
    this.hmProperty["id_Teacher"] = true;
}
}

/**
 * 教师工号(说明:;字段类型:varchar;字段长度:12;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetTeacherID (value: string)
{
if (value  != undefined)
{
 this.teacherID = value;
    this.hmProperty["teacherID"] = true;
}
}

/**
 * 教师姓名(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetTeacherName (value: string)
{
if (value  != undefined)
{
 this.teacherName = value;
    this.hmProperty["teacherName"] = true;
}
}

/**
 * 性别流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setid_Sex (value: string)
{
if (value  != undefined)
{
 this.id_Sex = value;
    this.hmProperty["id_Sex"] = true;
}
}

/**
 * 学校流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setid_School_Ps (value: string)
{
if (value  != undefined)
{
 this.id_School_Ps = value;
    this.hmProperty["id_School_Ps"] = true;
}
}

/**
 * 学科流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setid_Discipline_Ps (value: string)
{
if (value  != undefined)
{
 this.id_Discipline_Ps = value;
    this.hmProperty["id_Discipline_Ps"] = true;
}
}

/**
 * 校区流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setid_UniZone (value: string)
{
if (value  != undefined)
{
 this.id_UniZone = value;
    this.hmProperty["id_UniZone"] = true;
}
}

/**
 * 民族流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setid_Ethnic (value: string)
{
if (value  != undefined)
{
 this.id_Ethnic = value;
    this.hmProperty["id_Ethnic"] = true;
}
}

/**
 * 政治面貌流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setid_Politics (value: string)
{
if (value  != undefined)
{
 this.id_Politics = value;
    this.hmProperty["id_Politics"] = true;
}
}

/**
 * 行政职务流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setid_AdminGrade (value: string)
{
if (value  != undefined)
{
 this.id_AdminGrade = value;
    this.hmProperty["id_AdminGrade"] = true;
}
}

/**
 * 专业职称流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setid_ProfGrade (value: string)
{
if (value  != undefined)
{
 this.id_ProfGrade = value;
    this.hmProperty["id_ProfGrade"] = true;
}
}

/**
 * 学历流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setid_Qualif (value: string)
{
if (value  != undefined)
{
 this.id_Qualif = value;
    this.hmProperty["id_Qualif"] = true;
}
}

/**
 * 学位流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setid_Degree (value: string)
{
if (value  != undefined)
{
 this.id_Degree = value;
    this.hmProperty["id_Degree"] = true;
}
}

/**
 * 职工类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setid_StaffType (value: string)
{
if (value  != undefined)
{
 this.id_StaffType = value;
    this.hmProperty["id_StaffType"] = true;
}
}

/**
 * 省份流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setid_Province (value: string)
{
if (value  != undefined)
{
 this.id_Province = value;
    this.hmProperty["id_Province"] = true;
}
}

/**
 * 身份证号(说明:;字段类型:varchar;字段长度:25;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetCitizenID (value: string)
{
if (value  != undefined)
{
 this.citizenID = value;
    this.hmProperty["citizenID"] = true;
}
}

/**
 * 卡号(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetCardNo (value: string)
{
if (value  != undefined)
{
 this.cardNo = value;
    this.hmProperty["cardNo"] = true;
}
}

/**
 * 出生日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetBirthday (value: string)
{
if (value  != undefined)
{
 this.birthday = value;
    this.hmProperty["birthday"] = true;
}
}

/**
 * 毕业专业(说明:;字段类型:varchar;字段长度:40;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetGraduationMajor (value: string)
{
if (value  != undefined)
{
 this.graduationMajor = value;
    this.hmProperty["graduationMajor"] = true;
}
}

/**
 * 电话(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetTelNo (value: string)
{
if (value  != undefined)
{
 this.telNo = value;
    this.hmProperty["telNo"] = true;
}
}

/**
 * 电子邮箱(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetEmail (value: string)
{
if (value  != undefined)
{
 this.email = value;
    this.hmProperty["email"] = true;
}
}

/**
 * 个人主页(说明:;字段类型:varchar;字段长度:60;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetWebSite (value: string)
{
if (value  != undefined)
{
 this.webSite = value;
    this.hmProperty["webSite"] = true;
}
}

/**
 * 个人博客(说明:;字段类型:varchar;字段长度:60;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetPersonBlog (value: string)
{
if (value  != undefined)
{
 this.personBlog = value;
    this.hmProperty["personBlog"] = true;
}
}

/**
 * 进校日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetEntryDate (value: string)
{
if (value  != undefined)
{
 this.entryDate = value;
    this.hmProperty["entryDate"] = true;
}
}

/**
 * 是否离校(说明:;字段类型:bit;字段长度:1;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetOffed (value: boolean)
{
if (value  != undefined)
{
 this.offed = value;
    this.hmProperty["offed"] = true;
}
}

/**
 * 内卡号(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetId_CardNo (value: string)
{
if (value  != undefined)
{
 this.id_CardNo = value;
    this.hmProperty["id_CardNo"] = true;
}
}

/**
 * IsAvconUser(说明:;字段类型:bit;字段长度:1;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetIsAvconUser (value: boolean)
{
if (value  != undefined)
{
 this.isAvconUser = value;
    this.hmProperty["isAvconUser"] = true;
}
}

/**
 * 是否Gp用户(说明:;字段类型:bit;字段长度:1;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetIsGpUser (value: boolean)
{
if (value  != undefined)
{
 this.isGpUser = value;
    this.hmProperty["isGpUser"] = true;
}
}

/**
 * 是否本地用户(说明:;字段类型:bit;字段长度:1;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetIsLocalUser (value: boolean)
{
if (value  != undefined)
{
 this.isLocalUser = value;
    this.hmProperty["isLocalUser"] = true;
}
}

/**
 * 来自单位(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetFromUnit (value: string)
{
if (value  != undefined)
{
 this.fromUnit = value;
    this.hmProperty["fromUnit"] = true;
}
}

/**
 * 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetMemo (value: string)
{
if (value  != undefined)
{
 this.memo = value;
    this.hmProperty["memo"] = true;
}
}

/**
 * 学院流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setid_XzCollege (value: string)
{
if (value  != undefined)
{
 this.id_XzCollege = value;
    this.hmProperty["id_XzCollege"] = true;
}
}

/**
 * 专业流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setid_XzMajor (value: string)
{
if (value  != undefined)
{
 this.id_XzMajor = value;
    this.hmProperty["id_XzMajor"] = true;
}
}

/**
 * EntryDay(说明:;字段类型:char;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetEntryDay (value: string)
{
if (value  != undefined)
{
 this.entryDay = value;
    this.hmProperty["entryDay"] = true;
}
}

/**
 * id_Photo(说明:;字段类型:char;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setid_Photo (value: string)
{
if (value  != undefined)
{
 this.id_Photo = value;
    this.hmProperty["id_Photo"] = true;
}
}

/**
 * id_Religion(说明:;字段类型:char;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setid_Religion (value: string)
{
if (value  != undefined)
{
 this.id_Religion = value;
    this.hmProperty["id_Religion"] = true;
}
}

/**
 * IsMessage(说明:;字段类型:bit;字段长度:1;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetIsMessage (value: boolean)
{
if (value  != undefined)
{
 this.isMessage = value;
    this.hmProperty["isMessage"] = true;
}
}

/**
 * Microblog(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetMicroblog (value: string)
{
if (value  != undefined)
{
 this.microblog = value;
    this.hmProperty["microblog"] = true;
}
}

/**
 * 修改人(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetModifyUserID (value: string)
{
if (value  != undefined)
{
 this.modifyUserID = value;
    this.hmProperty["modifyUserID"] = true;
}
}

/**
 * OffedBak(说明:;字段类型:bit;字段长度:1;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetOffedBak (value: boolean)
{
if (value  != undefined)
{
 this.offedBak = value;
    this.hmProperty["offedBak"] = true;
}
}

/**
 * PhoneNumber(说明:;字段类型:varchar;字段长度:15;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetPhoneNumber (value: string)
{
if (value  != undefined)
{
 this.phoneNumber = value;
    this.hmProperty["phoneNumber"] = true;
}
}

/**
 * QQ(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetQQ (value: string)
{
if (value  != undefined)
{
 this.qQ = value;
    this.hmProperty["qQ"] = true;
}
}

/**
 * Teach_id_College(说明:;字段类型:varchar;字段长度:6;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetTeach_id_College (value: string)
{
if (value  != undefined)
{
 this.teach_id_College = value;
    this.hmProperty["teach_id_College"] = true;
}
}

/**
 * Teach_id_Major(说明:;字段类型:char;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetTeach_id_Major (value: string)
{
if (value  != undefined)
{
 this.teach_id_Major = value;
    this.hmProperty["teach_id_Major"] = true;
}
}

/**
 * Tel(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetTel (value: string)
{
if (value  != undefined)
{
 this.tel = value;
    this.hmProperty["tel"] = true;
}
}

/**
 * Headphoto(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetHeadphoto (value: string)
{
if (value  != undefined)
{
 this.headphoto = value;
    this.hmProperty["headphoto"] = true;
}
}

/**
 * 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetModifyDate (value: string)
{
if (value  != undefined)
{
 this.modifyDate = value;
    this.hmProperty["modifyDate"] = true;
}
}

/**
 * RegisterPassword(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetRegisterPassword (value: string)
{
if (value  != undefined)
{
 this.registerPassword = value;
    this.hmProperty["registerPassword"] = true;
}
}

/**
 * TeacherPhoto(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetTeacherPhoto (value: string)
{
if (value  != undefined)
{
 this.teacherPhoto = value;
    this.hmProperty["teacherPhoto"] = true;
}
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
case clsTeacherInfoEN.con_id_Teacher:
return this.id_Teacher;
case clsTeacherInfoEN.con_TeacherID:
return this.teacherID;
case clsTeacherInfoEN.con_TeacherName:
return this.teacherName;
case clsTeacherInfoEN.con_id_Sex:
return this.id_Sex;
case clsTeacherInfoEN.con_id_School_Ps:
return this.id_School_Ps;
case clsTeacherInfoEN.con_id_Discipline_Ps:
return this.id_Discipline_Ps;
case clsTeacherInfoEN.con_id_UniZone:
return this.id_UniZone;
case clsTeacherInfoEN.con_id_Ethnic:
return this.id_Ethnic;
case clsTeacherInfoEN.con_id_Politics:
return this.id_Politics;
case clsTeacherInfoEN.con_id_AdminGrade:
return this.id_AdminGrade;
case clsTeacherInfoEN.con_id_ProfGrade:
return this.id_ProfGrade;
case clsTeacherInfoEN.con_id_Qualif:
return this.id_Qualif;
case clsTeacherInfoEN.con_id_Degree:
return this.id_Degree;
case clsTeacherInfoEN.con_id_StaffType:
return this.id_StaffType;
case clsTeacherInfoEN.con_id_Province:
return this.id_Province;
case clsTeacherInfoEN.con_CitizenID:
return this.citizenID;
case clsTeacherInfoEN.con_CardNo:
return this.cardNo;
case clsTeacherInfoEN.con_Birthday:
return this.birthday;
case clsTeacherInfoEN.con_GraduationMajor:
return this.graduationMajor;
case clsTeacherInfoEN.con_TelNo:
return this.telNo;
case clsTeacherInfoEN.con_Email:
return this.email;
case clsTeacherInfoEN.con_WebSite:
return this.webSite;
case clsTeacherInfoEN.con_PersonBlog:
return this.personBlog;
case clsTeacherInfoEN.con_EntryDate:
return this.entryDate;
case clsTeacherInfoEN.con_Offed:
return this.offed;
case clsTeacherInfoEN.con_Id_CardNo:
return this.id_CardNo;
case clsTeacherInfoEN.con_IsAvconUser:
return this.isAvconUser;
case clsTeacherInfoEN.con_IsGpUser:
return this.isGpUser;
case clsTeacherInfoEN.con_IsLocalUser:
return this.isLocalUser;
case clsTeacherInfoEN.con_FromUnit:
return this.fromUnit;
case clsTeacherInfoEN.con_Memo:
return this.memo;
case clsTeacherInfoEN.con_id_XzCollege:
return this.id_XzCollege;
case clsTeacherInfoEN.con_id_XzMajor:
return this.id_XzMajor;
case clsTeacherInfoEN.con_EntryDay:
return this.entryDay;
case clsTeacherInfoEN.con_id_Photo:
return this.id_Photo;
case clsTeacherInfoEN.con_id_Religion:
return this.id_Religion;
case clsTeacherInfoEN.con_IsMessage:
return this.isMessage;
case clsTeacherInfoEN.con_Microblog:
return this.microblog;
case clsTeacherInfoEN.con_ModifyUserID:
return this.modifyUserID;
case clsTeacherInfoEN.con_OffedBak:
return this.offedBak;
case clsTeacherInfoEN.con_PhoneNumber:
return this.phoneNumber;
case clsTeacherInfoEN.con_QQ:
return this.qQ;
case clsTeacherInfoEN.con_Teach_id_College:
return this.teach_id_College;
case clsTeacherInfoEN.con_Teach_id_Major:
return this.teach_id_Major;
case clsTeacherInfoEN.con_Tel:
return this.tel;
case clsTeacherInfoEN.con_Headphoto:
return this.headphoto;
case clsTeacherInfoEN.con_ModifyDate:
return this.modifyDate;
case clsTeacherInfoEN.con_RegisterPassword:
return this.registerPassword;
case clsTeacherInfoEN.con_TeacherPhoto:
return this.teacherPhoto;
case "sf_UpdFldSetStr":
return this.sf_UpdFldSetStr;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[TeacherInfo]中不存在！`;
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
case clsTeacherInfoEN.con_id_Teacher:
this.id_Teacher = strValue;
    this.hmProperty["id_Teacher"] = true;
break;
case clsTeacherInfoEN.con_TeacherID:
this.teacherID = strValue;
    this.hmProperty["teacherID"] = true;
break;
case clsTeacherInfoEN.con_TeacherName:
this.teacherName = strValue;
    this.hmProperty["teacherName"] = true;
break;
case clsTeacherInfoEN.con_id_Sex:
this.id_Sex = strValue;
    this.hmProperty["id_Sex"] = true;
break;
case clsTeacherInfoEN.con_id_School_Ps:
this.id_School_Ps = strValue;
    this.hmProperty["id_School_Ps"] = true;
break;
case clsTeacherInfoEN.con_id_Discipline_Ps:
this.id_Discipline_Ps = strValue;
    this.hmProperty["id_Discipline_Ps"] = true;
break;
case clsTeacherInfoEN.con_id_UniZone:
this.id_UniZone = strValue;
    this.hmProperty["id_UniZone"] = true;
break;
case clsTeacherInfoEN.con_id_Ethnic:
this.id_Ethnic = strValue;
    this.hmProperty["id_Ethnic"] = true;
break;
case clsTeacherInfoEN.con_id_Politics:
this.id_Politics = strValue;
    this.hmProperty["id_Politics"] = true;
break;
case clsTeacherInfoEN.con_id_AdminGrade:
this.id_AdminGrade = strValue;
    this.hmProperty["id_AdminGrade"] = true;
break;
case clsTeacherInfoEN.con_id_ProfGrade:
this.id_ProfGrade = strValue;
    this.hmProperty["id_ProfGrade"] = true;
break;
case clsTeacherInfoEN.con_id_Qualif:
this.id_Qualif = strValue;
    this.hmProperty["id_Qualif"] = true;
break;
case clsTeacherInfoEN.con_id_Degree:
this.id_Degree = strValue;
    this.hmProperty["id_Degree"] = true;
break;
case clsTeacherInfoEN.con_id_StaffType:
this.id_StaffType = strValue;
    this.hmProperty["id_StaffType"] = true;
break;
case clsTeacherInfoEN.con_id_Province:
this.id_Province = strValue;
    this.hmProperty["id_Province"] = true;
break;
case clsTeacherInfoEN.con_CitizenID:
this.citizenID = strValue;
    this.hmProperty["citizenID"] = true;
break;
case clsTeacherInfoEN.con_CardNo:
this.cardNo = strValue;
    this.hmProperty["cardNo"] = true;
break;
case clsTeacherInfoEN.con_Birthday:
this.birthday = strValue;
    this.hmProperty["birthday"] = true;
break;
case clsTeacherInfoEN.con_GraduationMajor:
this.graduationMajor = strValue;
    this.hmProperty["graduationMajor"] = true;
break;
case clsTeacherInfoEN.con_TelNo:
this.telNo = strValue;
    this.hmProperty["telNo"] = true;
break;
case clsTeacherInfoEN.con_Email:
this.email = strValue;
    this.hmProperty["email"] = true;
break;
case clsTeacherInfoEN.con_WebSite:
this.webSite = strValue;
    this.hmProperty["webSite"] = true;
break;
case clsTeacherInfoEN.con_PersonBlog:
this.personBlog = strValue;
    this.hmProperty["personBlog"] = true;
break;
case clsTeacherInfoEN.con_EntryDate:
this.entryDate = strValue;
    this.hmProperty["entryDate"] = true;
break;
case clsTeacherInfoEN.con_Offed:
this.offed = Boolean(strValue);
    this.hmProperty["offed"] = true;
break;
case clsTeacherInfoEN.con_Id_CardNo:
this.id_CardNo = strValue;
    this.hmProperty["id_CardNo"] = true;
break;
case clsTeacherInfoEN.con_IsAvconUser:
this.isAvconUser = Boolean(strValue);
    this.hmProperty["isAvconUser"] = true;
break;
case clsTeacherInfoEN.con_IsGpUser:
this.isGpUser = Boolean(strValue);
    this.hmProperty["isGpUser"] = true;
break;
case clsTeacherInfoEN.con_IsLocalUser:
this.isLocalUser = Boolean(strValue);
    this.hmProperty["isLocalUser"] = true;
break;
case clsTeacherInfoEN.con_FromUnit:
this.fromUnit = strValue;
    this.hmProperty["fromUnit"] = true;
break;
case clsTeacherInfoEN.con_Memo:
this.memo = strValue;
    this.hmProperty["memo"] = true;
break;
case clsTeacherInfoEN.con_id_XzCollege:
this.id_XzCollege = strValue;
    this.hmProperty["id_XzCollege"] = true;
break;
case clsTeacherInfoEN.con_id_XzMajor:
this.id_XzMajor = strValue;
    this.hmProperty["id_XzMajor"] = true;
break;
case clsTeacherInfoEN.con_EntryDay:
this.entryDay = strValue;
    this.hmProperty["entryDay"] = true;
break;
case clsTeacherInfoEN.con_id_Photo:
this.id_Photo = strValue;
    this.hmProperty["id_Photo"] = true;
break;
case clsTeacherInfoEN.con_id_Religion:
this.id_Religion = strValue;
    this.hmProperty["id_Religion"] = true;
break;
case clsTeacherInfoEN.con_IsMessage:
this.isMessage = Boolean(strValue);
    this.hmProperty["isMessage"] = true;
break;
case clsTeacherInfoEN.con_Microblog:
this.microblog = strValue;
    this.hmProperty["microblog"] = true;
break;
case clsTeacherInfoEN.con_ModifyUserID:
this.modifyUserID = strValue;
    this.hmProperty["modifyUserID"] = true;
break;
case clsTeacherInfoEN.con_OffedBak:
this.offedBak = Boolean(strValue);
    this.hmProperty["offedBak"] = true;
break;
case clsTeacherInfoEN.con_PhoneNumber:
this.phoneNumber = strValue;
    this.hmProperty["phoneNumber"] = true;
break;
case clsTeacherInfoEN.con_QQ:
this.qQ = strValue;
    this.hmProperty["qQ"] = true;
break;
case clsTeacherInfoEN.con_Teach_id_College:
this.teach_id_College = strValue;
    this.hmProperty["teach_id_College"] = true;
break;
case clsTeacherInfoEN.con_Teach_id_Major:
this.teach_id_Major = strValue;
    this.hmProperty["teach_id_Major"] = true;
break;
case clsTeacherInfoEN.con_Tel:
this.tel = strValue;
    this.hmProperty["tel"] = true;
break;
case clsTeacherInfoEN.con_Headphoto:
this.headphoto = strValue;
    this.hmProperty["headphoto"] = true;
break;
case clsTeacherInfoEN.con_ModifyDate:
this.modifyDate = strValue;
    this.hmProperty["modifyDate"] = true;
break;
case clsTeacherInfoEN.con_RegisterPassword:
this.registerPassword = strValue;
    this.hmProperty["registerPassword"] = true;
break;
case clsTeacherInfoEN.con_TeacherPhoto:
this.teacherPhoto = strValue;
    this.hmProperty["teacherPhoto"] = true;
break;
case "sf_UpdFldSetStr":
this.sf_UpdFldSetStr = strValue;
break;
case "sf_FldComparisonOp":
this.sf_FldComparisonOp = strValue;
break;
default:
strMsg = `字段名:[${strFldName}]在表对象:[TeacherInfo]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
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
public id_School_Ps = "";    //学校流水号
public id_Discipline_Ps = "";    //学科流水号
public id_UniZone = "";    //校区流水号
public id_Ethnic = "";    //民族流水号
public id_Politics = "";    //政治面貌流水号
public id_AdminGrade = "";    //行政职务流水号
public id_ProfGrade = "";    //专业职称流水号
public id_Qualif = "";    //学历流水号
public id_Degree = "";    //学位流水号
public id_StaffType = "";    //职工类型流水号
public id_Province = "";    //省份流水号
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
public id_XzMajor = "";    //专业流水号
public entryDay = "";    //EntryDay
public id_Photo = "";    //id_Photo
public id_Religion = "";    //id_Religion
public isMessage = false;    //IsMessage
public microblog = "";    //Microblog
public modifyUserID = "";    //修改人
public offedBak = false;    //OffedBak
public phoneNumber = "";    //PhoneNumber
public qQ = "";    //QQ
public teach_id_College = "";    //Teach_id_College
public teach_id_Major = "";    //Teach_id_Major
public tel = "";    //Tel
public headphoto = "";    //Headphoto
public modifyDate = "";    //修改日期
public registerPassword = "";    //RegisterPassword
public teacherPhoto = "";    //TeacherPhoto


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
 * 常量:"id_School_Ps"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_School_Ps(): string {return "id_School_Ps";}    //学校流水号

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
 * 常量:"id_Ethnic"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_Ethnic(): string {return "id_Ethnic";}    //民族流水号

 /**
 * 常量:"id_Politics"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_Politics(): string {return "id_Politics";}    //政治面貌流水号

 /**
 * 常量:"id_AdminGrade"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_AdminGrade(): string {return "id_AdminGrade";}    //行政职务流水号

 /**
 * 常量:"id_ProfGrade"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_ProfGrade(): string {return "id_ProfGrade";}    //专业职称流水号

 /**
 * 常量:"id_Qualif"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_Qualif(): string {return "id_Qualif";}    //学历流水号

 /**
 * 常量:"id_Degree"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_Degree(): string {return "id_Degree";}    //学位流水号

 /**
 * 常量:"id_StaffType"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_StaffType(): string {return "id_StaffType";}    //职工类型流水号

 /**
 * 常量:"id_Province"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_Province(): string {return "id_Province";}    //省份流水号

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
 * 常量:"Headphoto"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Headphoto(): string {return "headphoto";}    //Headphoto

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
 * 常量:"TeacherPhoto"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_TeacherPhoto(): string {return "teacherPhoto";}    //TeacherPhoto

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