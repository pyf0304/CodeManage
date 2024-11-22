
 /**
 * 类名:clsUsersEN
 * 表名:Users(01120034)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:45:58
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
 * 用户(Users)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTab } from '../../PubFun/clsGeneralTab.js';

export class clsUsersEN extends clsGeneralTab
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "02"; //客户端缓存
public static _CurrTabName= "Users"; //当前表名,与该类相关的表名
public static _KeyFldName= "UserId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 30;
public static AttributeName = ["userId", "userName", "departmentId", "userStateId", "password", "isGpUser", "schoolID1", "beginYearMonth", "endYearMonth", "id_GradeBase", "id_XzCollege", "id_XzMajor", "isLeaved", "stuIdTeacherId", "email", "phoneNumber", "avatarsPicture", "identityID", "auditDate", "auditUser", "isAudit", "isRegister", "registerDate", "mobilePhone", "openId", "updDate", "updUser", "memo", "headPic", "isGSuser"];
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
private mstrUserId = "";    //用户ID
private mstrUserName = "";    //用户名
private mstrDepartmentId = "";    //部门Id
private mstrUserStateId = "";    //用户状态Id
private mstrPassword = "";    //Password
private mbolIsGpUser = false;    //是否Gp用户
private mstrSchoolID1 = "";    //学校编号
private mstrBeginYearMonth = "";    //开始年月
private mstrEndYearMonth = "";    //结束年月
private mstrid_GradeBase = "";    //年级流水号
private mstrid_XzCollege = "";    //学院流水号
private mstrid_XzMajor = "";    //专业流水号
private mbolIsLeaved = false;    //IsLeaved
private mstrStuIdTeacherId = "";    //学工号
private mstrEmail = "";    //电子邮箱
private mstrPhoneNumber = "";    //PhoneNumber
private mstrAvatarsPicture = "";    //AvatarsPicture
private mstrIdentityID = "";    //身份编号
private mstrAuditDate = "";    //AuditDate
private mstrAuditUser = "";    //AuditUser
private mbolIsAudit = false;    //是否审核
private mbolIsRegister = false;    //IsRegister
private mstrRegisterDate = "";    //RegisterDate
private mstrMobilePhone = "";    //手机
private mstrOpenId = "";    //微信OpenId
private mstrUpdDate = "";    //修改日期
private mstrUpdUser = "";    //修改人
private mstrMemo = "";    //备注
private mstrHeadPic = "";    //头像
private mbolIsGSuser = false;    //是否GS用户

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
 * 用户名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetUserName (value: string)
{
if (value  != undefined)
{
 this.userName = value;
    this.hmProperty["userName"] = true;
}
}

/**
 * 部门Id(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetDepartmentId (value: string)
{
if (value  != undefined)
{
 this.departmentId = value;
    this.hmProperty["departmentId"] = true;
}
}

/**
 * 用户状态Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetUserStateId (value: string)
{
if (value  != undefined)
{
 this.userStateId = value;
    this.hmProperty["userStateId"] = true;
}
}

/**
 * Password(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetPassword (value: string)
{
if (value  != undefined)
{
 this.password = value;
    this.hmProperty["password"] = true;
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
 * 学校编号(说明:;字段类型:varchar;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetSchoolID1 (value: string)
{
if (value  != undefined)
{
 this.schoolID1 = value;
    this.hmProperty["schoolID1"] = true;
}
}

/**
 * 开始年月(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetBeginYearMonth (value: string)
{
if (value  != undefined)
{
 this.beginYearMonth = value;
    this.hmProperty["beginYearMonth"] = true;
}
}

/**
 * 结束年月(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetEndYearMonth (value: string)
{
if (value  != undefined)
{
 this.endYearMonth = value;
    this.hmProperty["endYearMonth"] = true;
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
 * 学工号(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetStuIdTeacherId (value: string)
{
if (value  != undefined)
{
 this.stuIdTeacherId = value;
    this.hmProperty["stuIdTeacherId"] = true;
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
 * AvatarsPicture(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetAvatarsPicture (value: string)
{
if (value  != undefined)
{
 this.avatarsPicture = value;
    this.hmProperty["avatarsPicture"] = true;
}
}

/**
 * 身份编号(说明:;字段类型:char;字段长度:2;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetIdentityID (value: string)
{
if (value  != undefined)
{
 this.identityID = value;
    this.hmProperty["identityID"] = true;
}
}

/**
 * AuditDate(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetAuditDate (value: string)
{
if (value  != undefined)
{
 this.auditDate = value;
    this.hmProperty["auditDate"] = true;
}
}

/**
 * AuditUser(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetAuditUser (value: string)
{
if (value  != undefined)
{
 this.auditUser = value;
    this.hmProperty["auditUser"] = true;
}
}

/**
 * 是否审核(说明:;字段类型:bit;字段长度:1;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetIsAudit (value: boolean)
{
if (value  != undefined)
{
 this.isAudit = value;
    this.hmProperty["isAudit"] = true;
}
}

/**
 * IsRegister(说明:;字段类型:bit;字段长度:1;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetIsRegister (value: boolean)
{
if (value  != undefined)
{
 this.isRegister = value;
    this.hmProperty["isRegister"] = true;
}
}

/**
 * RegisterDate(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetRegisterDate (value: string)
{
if (value  != undefined)
{
 this.registerDate = value;
    this.hmProperty["registerDate"] = true;
}
}

/**
 * 手机(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetMobilePhone (value: string)
{
if (value  != undefined)
{
 this.mobilePhone = value;
    this.hmProperty["mobilePhone"] = true;
}
}

/**
 * 微信OpenId(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetOpenId (value: string)
{
if (value  != undefined)
{
 this.openId = value;
    this.hmProperty["openId"] = true;
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
 * 头像(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetHeadPic (value: string)
{
if (value  != undefined)
{
 this.headPic = value;
    this.hmProperty["headPic"] = true;
}
}

/**
 * 是否GS用户(说明:;字段类型:bit;字段长度:1;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetIsGSuser (value: boolean)
{
if (value  != undefined)
{
 this.isGSuser = value;
    this.hmProperty["isGSuser"] = true;
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
case clsUsersEN.con_UserId:
return this.userId;
case clsUsersEN.con_UserName:
return this.userName;
case clsUsersEN.con_DepartmentId:
return this.departmentId;
case clsUsersEN.con_UserStateId:
return this.userStateId;
case clsUsersEN.con_Password:
return this.password;
case clsUsersEN.con_IsGpUser:
return this.isGpUser;
case clsUsersEN.con_SchoolID1:
return this.schoolID1;
case clsUsersEN.con_BeginYearMonth:
return this.beginYearMonth;
case clsUsersEN.con_EndYearMonth:
return this.endYearMonth;
case clsUsersEN.con_id_GradeBase:
return this.id_GradeBase;
case clsUsersEN.con_id_XzCollege:
return this.id_XzCollege;
case clsUsersEN.con_id_XzMajor:
return this.id_XzMajor;
case clsUsersEN.con_IsLeaved:
return this.isLeaved;
case clsUsersEN.con_StuIdTeacherId:
return this.stuIdTeacherId;
case clsUsersEN.con_Email:
return this.email;
case clsUsersEN.con_PhoneNumber:
return this.phoneNumber;
case clsUsersEN.con_AvatarsPicture:
return this.avatarsPicture;
case clsUsersEN.con_IdentityID:
return this.identityID;
case clsUsersEN.con_AuditDate:
return this.auditDate;
case clsUsersEN.con_AuditUser:
return this.auditUser;
case clsUsersEN.con_IsAudit:
return this.isAudit;
case clsUsersEN.con_IsRegister:
return this.isRegister;
case clsUsersEN.con_RegisterDate:
return this.registerDate;
case clsUsersEN.con_MobilePhone:
return this.mobilePhone;
case clsUsersEN.con_OpenId:
return this.openId;
case clsUsersEN.con_UpdDate:
return this.updDate;
case clsUsersEN.con_UpdUser:
return this.updUser;
case clsUsersEN.con_Memo:
return this.memo;
case clsUsersEN.con_HeadPic:
return this.headPic;
case clsUsersEN.con_IsGSuser:
return this.isGSuser;
case "sf_UpdFldSetStr":
return this.sf_UpdFldSetStr;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[Users]中不存在！`;
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
case clsUsersEN.con_UserId:
this.userId = strValue;
    this.hmProperty["userId"] = true;
break;
case clsUsersEN.con_UserName:
this.userName = strValue;
    this.hmProperty["userName"] = true;
break;
case clsUsersEN.con_DepartmentId:
this.departmentId = strValue;
    this.hmProperty["departmentId"] = true;
break;
case clsUsersEN.con_UserStateId:
this.userStateId = strValue;
    this.hmProperty["userStateId"] = true;
break;
case clsUsersEN.con_Password:
this.password = strValue;
    this.hmProperty["password"] = true;
break;
case clsUsersEN.con_IsGpUser:
this.isGpUser = Boolean(strValue);
    this.hmProperty["isGpUser"] = true;
break;
case clsUsersEN.con_SchoolID1:
this.schoolID1 = strValue;
    this.hmProperty["schoolID1"] = true;
break;
case clsUsersEN.con_BeginYearMonth:
this.beginYearMonth = strValue;
    this.hmProperty["beginYearMonth"] = true;
break;
case clsUsersEN.con_EndYearMonth:
this.endYearMonth = strValue;
    this.hmProperty["endYearMonth"] = true;
break;
case clsUsersEN.con_id_GradeBase:
this.id_GradeBase = strValue;
    this.hmProperty["id_GradeBase"] = true;
break;
case clsUsersEN.con_id_XzCollege:
this.id_XzCollege = strValue;
    this.hmProperty["id_XzCollege"] = true;
break;
case clsUsersEN.con_id_XzMajor:
this.id_XzMajor = strValue;
    this.hmProperty["id_XzMajor"] = true;
break;
case clsUsersEN.con_IsLeaved:
this.isLeaved = Boolean(strValue);
    this.hmProperty["isLeaved"] = true;
break;
case clsUsersEN.con_StuIdTeacherId:
this.stuIdTeacherId = strValue;
    this.hmProperty["stuIdTeacherId"] = true;
break;
case clsUsersEN.con_Email:
this.email = strValue;
    this.hmProperty["email"] = true;
break;
case clsUsersEN.con_PhoneNumber:
this.phoneNumber = strValue;
    this.hmProperty["phoneNumber"] = true;
break;
case clsUsersEN.con_AvatarsPicture:
this.avatarsPicture = strValue;
    this.hmProperty["avatarsPicture"] = true;
break;
case clsUsersEN.con_IdentityID:
this.identityID = strValue;
    this.hmProperty["identityID"] = true;
break;
case clsUsersEN.con_AuditDate:
this.auditDate = strValue;
    this.hmProperty["auditDate"] = true;
break;
case clsUsersEN.con_AuditUser:
this.auditUser = strValue;
    this.hmProperty["auditUser"] = true;
break;
case clsUsersEN.con_IsAudit:
this.isAudit = Boolean(strValue);
    this.hmProperty["isAudit"] = true;
break;
case clsUsersEN.con_IsRegister:
this.isRegister = Boolean(strValue);
    this.hmProperty["isRegister"] = true;
break;
case clsUsersEN.con_RegisterDate:
this.registerDate = strValue;
    this.hmProperty["registerDate"] = true;
break;
case clsUsersEN.con_MobilePhone:
this.mobilePhone = strValue;
    this.hmProperty["mobilePhone"] = true;
break;
case clsUsersEN.con_OpenId:
this.openId = strValue;
    this.hmProperty["openId"] = true;
break;
case clsUsersEN.con_UpdDate:
this.updDate = strValue;
    this.hmProperty["updDate"] = true;
break;
case clsUsersEN.con_UpdUser:
this.updUser = strValue;
    this.hmProperty["updUser"] = true;
break;
case clsUsersEN.con_Memo:
this.memo = strValue;
    this.hmProperty["memo"] = true;
break;
case clsUsersEN.con_HeadPic:
this.headPic = strValue;
    this.hmProperty["headPic"] = true;
break;
case clsUsersEN.con_IsGSuser:
this.isGSuser = Boolean(strValue);
    this.hmProperty["isGSuser"] = true;
break;
case "sf_UpdFldSetStr":
this.sf_UpdFldSetStr = strValue;
break;
case "sf_FldComparisonOp":
this.sf_FldComparisonOp = strValue;
break;
default:
strMsg = `字段名:[${strFldName}]在表对象:[Users]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
console.error(strMsg);
break;
}
}

/**
 * 设置对象中公共属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
*/
public userId = "";    //用户ID
public userName = "";    //用户名
public departmentId = "";    //部门Id
public userStateId = "";    //用户状态Id
public password = "";    //Password
public isGpUser = false;    //是否Gp用户
public schoolID1 = "";    //学校编号
public beginYearMonth = "";    //开始年月
public endYearMonth = "";    //结束年月
public id_GradeBase = "";    //年级流水号
public id_XzCollege = "";    //学院流水号
public id_XzMajor = "";    //专业流水号
public isLeaved = false;    //IsLeaved
public stuIdTeacherId = "";    //学工号
public email = "";    //电子邮箱
public phoneNumber = "";    //PhoneNumber
public avatarsPicture = "";    //AvatarsPicture
public identityID = "";    //身份编号
public auditDate = "";    //AuditDate
public auditUser = "";    //AuditUser
public isAudit = false;    //是否审核
public isRegister = false;    //IsRegister
public registerDate = "";    //RegisterDate
public mobilePhone = "";    //手机
public openId = "";    //微信OpenId
public updDate = "";    //修改日期
public updUser = "";    //修改人
public memo = "";    //备注
public headPic = "";    //头像
public isGSuser = false;    //是否GS用户


 /**
 * 常量:"UserId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UserId(): string {return "userId";}    //用户ID

 /**
 * 常量:"UserName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UserName(): string {return "userName";}    //用户名

 /**
 * 常量:"DepartmentId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_DepartmentId(): string {return "departmentId";}    //部门Id

 /**
 * 常量:"UserStateId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UserStateId(): string {return "userStateId";}    //用户状态Id

 /**
 * 常量:"Password"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Password(): string {return "password";}    //Password

 /**
 * 常量:"IsGpUser"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsGpUser(): string {return "isGpUser";}    //是否Gp用户

 /**
 * 常量:"SchoolID1"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SchoolID1(): string {return "schoolID1";}    //学校编号

 /**
 * 常量:"BeginYearMonth"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_BeginYearMonth(): string {return "beginYearMonth";}    //开始年月

 /**
 * 常量:"EndYearMonth"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_EndYearMonth(): string {return "endYearMonth";}    //结束年月

 /**
 * 常量:"id_GradeBase"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_GradeBase(): string {return "id_GradeBase";}    //年级流水号

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
 * 常量:"IsLeaved"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsLeaved(): string {return "isLeaved";}    //IsLeaved

 /**
 * 常量:"StuIdTeacherId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_StuIdTeacherId(): string {return "stuIdTeacherId";}    //学工号

 /**
 * 常量:"Email"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Email(): string {return "email";}    //电子邮箱

 /**
 * 常量:"PhoneNumber"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PhoneNumber(): string {return "phoneNumber";}    //PhoneNumber

 /**
 * 常量:"AvatarsPicture"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_AvatarsPicture(): string {return "avatarsPicture";}    //AvatarsPicture

 /**
 * 常量:"IdentityID"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IdentityID(): string {return "identityID";}    //身份编号

 /**
 * 常量:"AuditDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_AuditDate(): string {return "auditDate";}    //AuditDate

 /**
 * 常量:"AuditUser"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_AuditUser(): string {return "auditUser";}    //AuditUser

 /**
 * 常量:"IsAudit"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsAudit(): string {return "isAudit";}    //是否审核

 /**
 * 常量:"IsRegister"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsRegister(): string {return "isRegister";}    //IsRegister

 /**
 * 常量:"RegisterDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_RegisterDate(): string {return "registerDate";}    //RegisterDate

 /**
 * 常量:"MobilePhone"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_MobilePhone(): string {return "mobilePhone";}    //手机

 /**
 * 常量:"OpenId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_OpenId(): string {return "openId";}    //微信OpenId

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
 * 常量:"HeadPic"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_HeadPic(): string {return "headPic";}    //头像

 /**
 * 常量:"IsGSuser"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsGSuser(): string {return "isGSuser";}    //是否GS用户

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