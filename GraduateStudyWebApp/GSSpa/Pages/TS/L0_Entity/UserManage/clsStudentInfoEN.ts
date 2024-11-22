
 /**
 * 类名:clsStudentInfoEN
 * 表名:StudentInfo(01120131)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:45:57
 * 生成者:pyf
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:用户管理(UserManage)
 * 框架-层名:实体层(TS)(EntityLayer)
 * 编程语言:TypeScript
 **/
 /**
 * 学生(StudentInfo)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTab } from '../../PubFun/clsGeneralTab.js';

export class clsStudentInfoEN extends clsGeneralTab
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "02"; //客户端缓存
public static _CurrTabName= "StudentInfo"; //当前表名,与该类相关的表名
public static _KeyFldName= "id_StudentInfo"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 40;
public static AttributeName = ["id_StudentInfo", "stuID", "stuName", "id_Politics", "id_Sex", "id_Ethnic", "id_UniZone", "id_StuType", "id_XzCollege", "id_XzMajor", "id_GradeBase", "id_AdminCls", "birthday", "nativePlace", "duty", "idCardNo", "stuCardNo", "liveAddress", "homePhone", "id_CardNo", "cardNo", "isAvconClassUser", "isAvconUser", "isGpUser", "isLocalUser", "isLeaved", "userId", "userID4Avcon", "enrollmentDate", "postCode", "email", "isMessage", "microblog", "phoneNumber", "headphoto", "qQ", "registerPassword", "updDate", "updUser", "memo"];
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
private mstrid_StudentInfo = "";    //学生流水号
private mstrStuID = "";    //学号
private mstrStuName = "";    //姓名
private mstrid_Politics = "";    //政治面貌流水号
private mstrid_Sex = "";    //性别流水号
private mstrid_Ethnic = "";    //民族流水号
private mstrid_UniZone = "";    //校区流水号
private mstrid_StuType = "";    //学生类别流水号
private mstrid_XzCollege = "";    //学院流水号
private mstrid_XzMajor = "";    //专业流水号
private mstrid_GradeBase = "";    //年级流水号
private mstrid_AdminCls = "";    //行政班流水号
private mstrBirthday = "";    //出生日期
private mstrNativePlace = "";    //籍贯
private mstrDuty = "";    //职位
private mstrIDCardNo = "";    //身份证号
private mstrStuCardNo = "";    //学生证号
private mstrLiveAddress = "";    //居住地址
private mstrHomePhone = "";    //住宅电话
private mstrId_CardNo = "";    //内卡号
private mstrCardNo = "";    //卡号
private mbolIsAvconClassUser = false;    //IsAvconClassUser
private mbolIsAvconUser = false;    //IsAvconUser
private mbolIsGpUser = false;    //是否Gp用户
private mbolIsLocalUser = false;    //是否本地用户
private mbolIsLeaved = false;    //IsLeaved
private mstrUserId = "";    //用户ID
private mstrUserID4Avcon = "";    //UserID4Avcon
private mstrEnrollmentDate = "";    //入校日期
private mstrPostCode = "";    //邮编
private mstrEmail = "";    //电子邮箱
private mbolIsMessage = false;    //IsMessage
private mstrMicroblog = "";    //Microblog
private mstrPhoneNumber = "";    //PhoneNumber
private mstrHeadphoto = "";    //Headphoto
private mstrQQ = "";    //QQ
private mstrRegisterPassword = "";    //RegisterPassword
private mstrUpdDate = "";    //修改日期
private mstrUpdUser = "";    //修改人
private mstrMemo = "";    //备注

/**
 * 学生流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setid_StudentInfo (value: string)
{
if (value  != undefined)
{
 this.id_StudentInfo = value;
    this.hmProperty["id_StudentInfo"] = true;
}
}

/**
 * 学号(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetStuID (value: string)
{
if (value  != undefined)
{
 this.stuID = value;
    this.hmProperty["stuID"] = true;
}
}

/**
 * 姓名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetStuName (value: string)
{
if (value  != undefined)
{
 this.stuName = value;
    this.hmProperty["stuName"] = true;
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
 * 学生类别流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setid_StuType (value: string)
{
if (value  != undefined)
{
 this.id_StuType = value;
    this.hmProperty["id_StuType"] = true;
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
 * 年级流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setid_GradeBase (value: string)
{
if (value  != undefined)
{
 this.id_GradeBase = value;
    this.hmProperty["id_GradeBase"] = true;
}
}

/**
 * 行政班流水号(说明:;字段类型:char;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setid_AdminCls (value: string)
{
if (value  != undefined)
{
 this.id_AdminCls = value;
    this.hmProperty["id_AdminCls"] = true;
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
 * 籍贯(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetNativePlace (value: string)
{
if (value  != undefined)
{
 this.nativePlace = value;
    this.hmProperty["nativePlace"] = true;
}
}

/**
 * 职位(说明:;字段类型:varchar;字段长度:30;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetDuty (value: string)
{
if (value  != undefined)
{
 this.duty = value;
    this.hmProperty["duty"] = true;
}
}

/**
 * 身份证号(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetIDCardNo (value: string)
{
if (value  != undefined)
{
 this.idCardNo = value;
    this.hmProperty["idCardNo"] = true;
}
}

/**
 * 学生证号(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetStuCardNo (value: string)
{
if (value  != undefined)
{
 this.stuCardNo = value;
    this.hmProperty["stuCardNo"] = true;
}
}

/**
 * 居住地址(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetLiveAddress (value: string)
{
if (value  != undefined)
{
 this.liveAddress = value;
    this.hmProperty["liveAddress"] = true;
}
}

/**
 * 住宅电话(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetHomePhone (value: string)
{
if (value  != undefined)
{
 this.homePhone = value;
    this.hmProperty["homePhone"] = true;
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
 * IsAvconClassUser(说明:;字段类型:bit;字段长度:1;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetIsAvconClassUser (value: boolean)
{
if (value  != undefined)
{
 this.isAvconClassUser = value;
    this.hmProperty["isAvconClassUser"] = true;
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
 * IsLeaved(说明:;字段类型:bit;字段长度:1;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetIsLeaved (value: boolean)
{
if (value  != undefined)
{
 this.isLeaved = value;
    this.hmProperty["isLeaved"] = true;
}
}

/**
 * 用户ID(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetUserId (value: string)
{
if (value  != undefined)
{
 this.userId = value;
    this.hmProperty["userId"] = true;
}
}

/**
 * UserID4Avcon(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetUserID4Avcon (value: string)
{
if (value  != undefined)
{
 this.userID4Avcon = value;
    this.hmProperty["userID4Avcon"] = true;
}
}

/**
 * 入校日期(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetEnrollmentDate (value: string)
{
if (value  != undefined)
{
 this.enrollmentDate = value;
    this.hmProperty["enrollmentDate"] = true;
}
}

/**
 * 邮编(说明:;字段类型:char;字段长度:6;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetPostCode (value: string)
{
if (value  != undefined)
{
 this.postCode = value;
    this.hmProperty["postCode"] = true;
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
 * 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetUpdDate (value: string)
{
if (value  != undefined)
{
 this.updDate = value;
    this.hmProperty["updDate"] = true;
}
}

/**
 * 修改人(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetUpdUser (value: string)
{
if (value  != undefined)
{
 this.updUser = value;
    this.hmProperty["updUser"] = true;
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
case clsStudentInfoEN.con_id_StudentInfo:
return this.id_StudentInfo;
case clsStudentInfoEN.con_StuID:
return this.stuID;
case clsStudentInfoEN.con_StuName:
return this.stuName;
case clsStudentInfoEN.con_id_Politics:
return this.id_Politics;
case clsStudentInfoEN.con_id_Sex:
return this.id_Sex;
case clsStudentInfoEN.con_id_Ethnic:
return this.id_Ethnic;
case clsStudentInfoEN.con_id_UniZone:
return this.id_UniZone;
case clsStudentInfoEN.con_id_StuType:
return this.id_StuType;
case clsStudentInfoEN.con_id_XzCollege:
return this.id_XzCollege;
case clsStudentInfoEN.con_id_XzMajor:
return this.id_XzMajor;
case clsStudentInfoEN.con_id_GradeBase:
return this.id_GradeBase;
case clsStudentInfoEN.con_id_AdminCls:
return this.id_AdminCls;
case clsStudentInfoEN.con_Birthday:
return this.birthday;
case clsStudentInfoEN.con_NativePlace:
return this.nativePlace;
case clsStudentInfoEN.con_Duty:
return this.duty;
case clsStudentInfoEN.con_IDCardNo:
return this.idCardNo;
case clsStudentInfoEN.con_StuCardNo:
return this.stuCardNo;
case clsStudentInfoEN.con_LiveAddress:
return this.liveAddress;
case clsStudentInfoEN.con_HomePhone:
return this.homePhone;
case clsStudentInfoEN.con_Id_CardNo:
return this.id_CardNo;
case clsStudentInfoEN.con_CardNo:
return this.cardNo;
case clsStudentInfoEN.con_IsAvconClassUser:
return this.isAvconClassUser;
case clsStudentInfoEN.con_IsAvconUser:
return this.isAvconUser;
case clsStudentInfoEN.con_IsGpUser:
return this.isGpUser;
case clsStudentInfoEN.con_IsLocalUser:
return this.isLocalUser;
case clsStudentInfoEN.con_IsLeaved:
return this.isLeaved;
case clsStudentInfoEN.con_UserId:
return this.userId;
case clsStudentInfoEN.con_UserID4Avcon:
return this.userID4Avcon;
case clsStudentInfoEN.con_EnrollmentDate:
return this.enrollmentDate;
case clsStudentInfoEN.con_PostCode:
return this.postCode;
case clsStudentInfoEN.con_Email:
return this.email;
case clsStudentInfoEN.con_IsMessage:
return this.isMessage;
case clsStudentInfoEN.con_Microblog:
return this.microblog;
case clsStudentInfoEN.con_PhoneNumber:
return this.phoneNumber;
case clsStudentInfoEN.con_Headphoto:
return this.headphoto;
case clsStudentInfoEN.con_QQ:
return this.qQ;
case clsStudentInfoEN.con_RegisterPassword:
return this.registerPassword;
case clsStudentInfoEN.con_UpdDate:
return this.updDate;
case clsStudentInfoEN.con_UpdUser:
return this.updUser;
case clsStudentInfoEN.con_Memo:
return this.memo;
case "sf_UpdFldSetStr":
return this.sf_UpdFldSetStr;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[StudentInfo]中不存在！`;
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
case clsStudentInfoEN.con_id_StudentInfo:
this.id_StudentInfo = strValue;
    this.hmProperty["id_StudentInfo"] = true;
break;
case clsStudentInfoEN.con_StuID:
this.stuID = strValue;
    this.hmProperty["stuID"] = true;
break;
case clsStudentInfoEN.con_StuName:
this.stuName = strValue;
    this.hmProperty["stuName"] = true;
break;
case clsStudentInfoEN.con_id_Politics:
this.id_Politics = strValue;
    this.hmProperty["id_Politics"] = true;
break;
case clsStudentInfoEN.con_id_Sex:
this.id_Sex = strValue;
    this.hmProperty["id_Sex"] = true;
break;
case clsStudentInfoEN.con_id_Ethnic:
this.id_Ethnic = strValue;
    this.hmProperty["id_Ethnic"] = true;
break;
case clsStudentInfoEN.con_id_UniZone:
this.id_UniZone = strValue;
    this.hmProperty["id_UniZone"] = true;
break;
case clsStudentInfoEN.con_id_StuType:
this.id_StuType = strValue;
    this.hmProperty["id_StuType"] = true;
break;
case clsStudentInfoEN.con_id_XzCollege:
this.id_XzCollege = strValue;
    this.hmProperty["id_XzCollege"] = true;
break;
case clsStudentInfoEN.con_id_XzMajor:
this.id_XzMajor = strValue;
    this.hmProperty["id_XzMajor"] = true;
break;
case clsStudentInfoEN.con_id_GradeBase:
this.id_GradeBase = strValue;
    this.hmProperty["id_GradeBase"] = true;
break;
case clsStudentInfoEN.con_id_AdminCls:
this.id_AdminCls = strValue;
    this.hmProperty["id_AdminCls"] = true;
break;
case clsStudentInfoEN.con_Birthday:
this.birthday = strValue;
    this.hmProperty["birthday"] = true;
break;
case clsStudentInfoEN.con_NativePlace:
this.nativePlace = strValue;
    this.hmProperty["nativePlace"] = true;
break;
case clsStudentInfoEN.con_Duty:
this.duty = strValue;
    this.hmProperty["duty"] = true;
break;
case clsStudentInfoEN.con_IDCardNo:
this.idCardNo = strValue;
    this.hmProperty["idCardNo"] = true;
break;
case clsStudentInfoEN.con_StuCardNo:
this.stuCardNo = strValue;
    this.hmProperty["stuCardNo"] = true;
break;
case clsStudentInfoEN.con_LiveAddress:
this.liveAddress = strValue;
    this.hmProperty["liveAddress"] = true;
break;
case clsStudentInfoEN.con_HomePhone:
this.homePhone = strValue;
    this.hmProperty["homePhone"] = true;
break;
case clsStudentInfoEN.con_Id_CardNo:
this.id_CardNo = strValue;
    this.hmProperty["id_CardNo"] = true;
break;
case clsStudentInfoEN.con_CardNo:
this.cardNo = strValue;
    this.hmProperty["cardNo"] = true;
break;
case clsStudentInfoEN.con_IsAvconClassUser:
this.isAvconClassUser = Boolean(strValue);
    this.hmProperty["isAvconClassUser"] = true;
break;
case clsStudentInfoEN.con_IsAvconUser:
this.isAvconUser = Boolean(strValue);
    this.hmProperty["isAvconUser"] = true;
break;
case clsStudentInfoEN.con_IsGpUser:
this.isGpUser = Boolean(strValue);
    this.hmProperty["isGpUser"] = true;
break;
case clsStudentInfoEN.con_IsLocalUser:
this.isLocalUser = Boolean(strValue);
    this.hmProperty["isLocalUser"] = true;
break;
case clsStudentInfoEN.con_IsLeaved:
this.isLeaved = Boolean(strValue);
    this.hmProperty["isLeaved"] = true;
break;
case clsStudentInfoEN.con_UserId:
this.userId = strValue;
    this.hmProperty["userId"] = true;
break;
case clsStudentInfoEN.con_UserID4Avcon:
this.userID4Avcon = strValue;
    this.hmProperty["userID4Avcon"] = true;
break;
case clsStudentInfoEN.con_EnrollmentDate:
this.enrollmentDate = strValue;
    this.hmProperty["enrollmentDate"] = true;
break;
case clsStudentInfoEN.con_PostCode:
this.postCode = strValue;
    this.hmProperty["postCode"] = true;
break;
case clsStudentInfoEN.con_Email:
this.email = strValue;
    this.hmProperty["email"] = true;
break;
case clsStudentInfoEN.con_IsMessage:
this.isMessage = Boolean(strValue);
    this.hmProperty["isMessage"] = true;
break;
case clsStudentInfoEN.con_Microblog:
this.microblog = strValue;
    this.hmProperty["microblog"] = true;
break;
case clsStudentInfoEN.con_PhoneNumber:
this.phoneNumber = strValue;
    this.hmProperty["phoneNumber"] = true;
break;
case clsStudentInfoEN.con_Headphoto:
this.headphoto = strValue;
    this.hmProperty["headphoto"] = true;
break;
case clsStudentInfoEN.con_QQ:
this.qQ = strValue;
    this.hmProperty["qQ"] = true;
break;
case clsStudentInfoEN.con_RegisterPassword:
this.registerPassword = strValue;
    this.hmProperty["registerPassword"] = true;
break;
case clsStudentInfoEN.con_UpdDate:
this.updDate = strValue;
    this.hmProperty["updDate"] = true;
break;
case clsStudentInfoEN.con_UpdUser:
this.updUser = strValue;
    this.hmProperty["updUser"] = true;
break;
case clsStudentInfoEN.con_Memo:
this.memo = strValue;
    this.hmProperty["memo"] = true;
break;
case "sf_UpdFldSetStr":
this.sf_UpdFldSetStr = strValue;
break;
case "sf_FldComparisonOp":
this.sf_FldComparisonOp = strValue;
break;
default:
strMsg = `字段名:[${strFldName}]在表对象:[StudentInfo]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
console.error(strMsg);
break;
}
}

/**
 * 设置对象中公共属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
*/
public id_StudentInfo = "";    //学生流水号
public stuID = "";    //学号
public stuName = "";    //姓名
public id_Politics = "";    //政治面貌流水号
public id_Sex = "";    //性别流水号
public id_Ethnic = "";    //民族流水号
public id_UniZone = "";    //校区流水号
public id_StuType = "";    //学生类别流水号
public id_XzCollege = "";    //学院流水号
public id_XzMajor = "";    //专业流水号
public id_GradeBase = "";    //年级流水号
public id_AdminCls = "";    //行政班流水号
public birthday = "";    //出生日期
public nativePlace = "";    //籍贯
public duty = "";    //职位
public idCardNo = "";    //身份证号
public stuCardNo = "";    //学生证号
public liveAddress = "";    //居住地址
public homePhone = "";    //住宅电话
public id_CardNo = "";    //内卡号
public cardNo = "";    //卡号
public isAvconClassUser = false;    //IsAvconClassUser
public isAvconUser = false;    //IsAvconUser
public isGpUser = false;    //是否Gp用户
public isLocalUser = false;    //是否本地用户
public isLeaved = false;    //IsLeaved
public userId = "";    //用户ID
public userID4Avcon = "";    //UserID4Avcon
public enrollmentDate = "";    //入校日期
public postCode = "";    //邮编
public email = "";    //电子邮箱
public isMessage = false;    //IsMessage
public microblog = "";    //Microblog
public phoneNumber = "";    //PhoneNumber
public headphoto = "";    //Headphoto
public qQ = "";    //QQ
public registerPassword = "";    //RegisterPassword
public updDate = "";    //修改日期
public updUser = "";    //修改人
public memo = "";    //备注


 /**
 * 常量:"id_StudentInfo"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_StudentInfo(): string {return "id_StudentInfo";}    //学生流水号

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
 * 常量:"id_Politics"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_Politics(): string {return "id_Politics";}    //政治面貌流水号

 /**
 * 常量:"id_Sex"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_Sex(): string {return "id_Sex";}    //性别流水号

 /**
 * 常量:"id_Ethnic"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_Ethnic(): string {return "id_Ethnic";}    //民族流水号

 /**
 * 常量:"id_UniZone"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_UniZone(): string {return "id_UniZone";}    //校区流水号

 /**
 * 常量:"id_StuType"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_StuType(): string {return "id_StuType";}    //学生类别流水号

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
 * 常量:"id_GradeBase"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_GradeBase(): string {return "id_GradeBase";}    //年级流水号

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
 * 常量:"NativePlace"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_NativePlace(): string {return "nativePlace";}    //籍贯

 /**
 * 常量:"Duty"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Duty(): string {return "duty";}    //职位

 /**
 * 常量:"IDCardNo"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IDCardNo(): string {return "idCardNo";}    //身份证号

 /**
 * 常量:"StuCardNo"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_StuCardNo(): string {return "stuCardNo";}    //学生证号

 /**
 * 常量:"LiveAddress"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_LiveAddress(): string {return "liveAddress";}    //居住地址

 /**
 * 常量:"HomePhone"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_HomePhone(): string {return "homePhone";}    //住宅电话

 /**
 * 常量:"Id_CardNo"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Id_CardNo(): string {return "id_CardNo";}    //内卡号

 /**
 * 常量:"CardNo"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CardNo(): string {return "cardNo";}    //卡号

 /**
 * 常量:"IsAvconClassUser"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsAvconClassUser(): string {return "isAvconClassUser";}    //IsAvconClassUser

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
 * 常量:"IsLeaved"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsLeaved(): string {return "isLeaved";}    //IsLeaved

 /**
 * 常量:"UserId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UserId(): string {return "userId";}    //用户ID

 /**
 * 常量:"UserID4Avcon"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UserID4Avcon(): string {return "userID4Avcon";}    //UserID4Avcon

 /**
 * 常量:"EnrollmentDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_EnrollmentDate(): string {return "enrollmentDate";}    //入校日期

 /**
 * 常量:"PostCode"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PostCode(): string {return "postCode";}    //邮编

 /**
 * 常量:"Email"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Email(): string {return "email";}    //电子邮箱

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
 * 常量:"PhoneNumber"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PhoneNumber(): string {return "phoneNumber";}    //PhoneNumber

 /**
 * 常量:"Headphoto"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Headphoto(): string {return "headphoto";}    //Headphoto

 /**
 * 常量:"QQ"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_QQ(): string {return "qQ";}    //QQ

 /**
 * 常量:"RegisterPassword"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_RegisterPassword(): string {return "registerPassword";}    //RegisterPassword

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