
 /**
 * 类名:clsQxUsersEN
 * 表名:QxUsers(01120258)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:04
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
 * Qx用户(QxUsers)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTab } from '../../PubFun/clsGeneralTab.js';

export class clsQxUsersEN extends clsGeneralTab
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "02"; //客户端缓存
public static _CurrTabName= "QxUsers"; //当前表名,与该类相关的表名
public static _KeyFldName= "UserId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 34;
public static AttributeName = ["userId", "userName", "departmentId", "id_XzCollege", "userStateId", "id_GradeBase", "card_State", "isLeaved", "cardNo", "beginYearMonth", "endYearMonth", "optUser", "optDate", "memo", "password", "isGpUser", "schoolID1", "avatarsPicture", "email", "phoneNumber", "effectiveDate", "updDate", "updUser", "effitiveBeginDate", "effitiveEndDate", "id_College", "stuTeacherID", "identityID", "isArchive", "headimgUrl", "openId", "nickName", "isSynch", "synchDate"];
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
private mstrid_XzCollege = "";    //学院流水号
private mstrUserStateId = "";    //用户状态Id
private mstrid_GradeBase = "";    //年级流水号
private mstrCard_State = "";    //Card_State
private mbolIsLeaved = false;    //IsLeaved
private mstrCardNo = "";    //卡号
private mstrBeginYearMonth = "";    //开始年月
private mstrEndYearMonth = "";    //结束年月
private mstrOptUser = "";    //OptUser
private mstrOptDate = "";    //OptDate
private mstrMemo = "";    //备注
private mstrPassword = "";    //Password
private mbolIsGpUser = false;    //是否Gp用户
private mstrSchoolID1 = "";    //学校编号
private mstrAvatarsPicture = "";    //AvatarsPicture
private mstrEmail = "";    //电子邮箱
private mstrPhoneNumber = "";    //PhoneNumber
private mstrEffectiveDate = "";    //EffectiveDate
private mstrUpdDate = "";    //修改日期
private mstrUpdUser = "";    //修改人
private mstrEffitiveBeginDate = "";    //EffitiveBeginDate
private mstrEffitiveEndDate = "";    //EffitiveEndDate
private mstrid_College = "";    //学院流水号
private mstrStuTeacherID = "";    //学工号
private mstrIdentityID = "";    //身份编号
private mbolIsArchive = false;    //IsArchive
private mstrheadimgUrl = "";    //微信头像
private mstrOpenId = "";    //微信OpenId
private mstrNickName = "";    //昵称
private mbolIsSynch = false;    //是否同步
private mstrSynchDate = "";    //同步日期

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
 * Card_State(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetCard_State (value: string)
{
if (value  != undefined)
{
 this.card_State = value;
    this.hmProperty["card_State"] = true;
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
 * OptUser(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetOptUser (value: string)
{
if (value  != undefined)
{
 this.optUser = value;
    this.hmProperty["optUser"] = true;
}
}

/**
 * OptDate(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetOptDate (value: string)
{
if (value  != undefined)
{
 this.optDate = value;
    this.hmProperty["optDate"] = true;
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
 * EffectiveDate(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetEffectiveDate (value: string)
{
if (value  != undefined)
{
 this.effectiveDate = value;
    this.hmProperty["effectiveDate"] = true;
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
 * EffitiveBeginDate(说明:;字段类型:varchar;字段长度:14;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetEffitiveBeginDate (value: string)
{
if (value  != undefined)
{
 this.effitiveBeginDate = value;
    this.hmProperty["effitiveBeginDate"] = true;
}
}

/**
 * EffitiveEndDate(说明:;字段类型:varchar;字段长度:14;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetEffitiveEndDate (value: string)
{
if (value  != undefined)
{
 this.effitiveEndDate = value;
    this.hmProperty["effitiveEndDate"] = true;
}
}

/**
 * 学院流水号(说明:;字段类型:char;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setid_College (value: string)
{
if (value  != undefined)
{
 this.id_College = value;
    this.hmProperty["id_College"] = true;
}
}

/**
 * 学工号(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetStuTeacherID (value: string)
{
if (value  != undefined)
{
 this.stuTeacherID = value;
    this.hmProperty["stuTeacherID"] = true;
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
 * IsArchive(说明:;字段类型:bit;字段长度:1;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetIsArchive (value: boolean)
{
if (value  != undefined)
{
 this.isArchive = value;
    this.hmProperty["isArchive"] = true;
}
}

/**
 * 微信头像(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetheadimgUrl (value: string)
{
if (value  != undefined)
{
 this.headimgUrl = value;
    this.hmProperty["headimgUrl"] = true;
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
 * 昵称(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetNickName (value: string)
{
if (value  != undefined)
{
 this.nickName = value;
    this.hmProperty["nickName"] = true;
}
}

/**
 * 是否同步(说明:;字段类型:bit;字段长度:1;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetIsSynch (value: boolean)
{
if (value  != undefined)
{
 this.isSynch = value;
    this.hmProperty["isSynch"] = true;
}
}

/**
 * 同步日期(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetSynchDate (value: string)
{
if (value  != undefined)
{
 this.synchDate = value;
    this.hmProperty["synchDate"] = true;
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
case clsQxUsersEN.con_UserId:
return this.userId;
case clsQxUsersEN.con_UserName:
return this.userName;
case clsQxUsersEN.con_DepartmentId:
return this.departmentId;
case clsQxUsersEN.con_id_XzCollege:
return this.id_XzCollege;
case clsQxUsersEN.con_UserStateId:
return this.userStateId;
case clsQxUsersEN.con_id_GradeBase:
return this.id_GradeBase;
case clsQxUsersEN.con_Card_State:
return this.card_State;
case clsQxUsersEN.con_IsLeaved:
return this.isLeaved;
case clsQxUsersEN.con_CardNo:
return this.cardNo;
case clsQxUsersEN.con_BeginYearMonth:
return this.beginYearMonth;
case clsQxUsersEN.con_EndYearMonth:
return this.endYearMonth;
case clsQxUsersEN.con_OptUser:
return this.optUser;
case clsQxUsersEN.con_OptDate:
return this.optDate;
case clsQxUsersEN.con_Memo:
return this.memo;
case clsQxUsersEN.con_Password:
return this.password;
case clsQxUsersEN.con_IsGpUser:
return this.isGpUser;
case clsQxUsersEN.con_SchoolID1:
return this.schoolID1;
case clsQxUsersEN.con_AvatarsPicture:
return this.avatarsPicture;
case clsQxUsersEN.con_Email:
return this.email;
case clsQxUsersEN.con_PhoneNumber:
return this.phoneNumber;
case clsQxUsersEN.con_EffectiveDate:
return this.effectiveDate;
case clsQxUsersEN.con_UpdDate:
return this.updDate;
case clsQxUsersEN.con_UpdUser:
return this.updUser;
case clsQxUsersEN.con_EffitiveBeginDate:
return this.effitiveBeginDate;
case clsQxUsersEN.con_EffitiveEndDate:
return this.effitiveEndDate;
case clsQxUsersEN.con_id_College:
return this.id_College;
case clsQxUsersEN.con_StuTeacherID:
return this.stuTeacherID;
case clsQxUsersEN.con_IdentityID:
return this.identityID;
case clsQxUsersEN.con_IsArchive:
return this.isArchive;
case clsQxUsersEN.con_headimgUrl:
return this.headimgUrl;
case clsQxUsersEN.con_OpenId:
return this.openId;
case clsQxUsersEN.con_NickName:
return this.nickName;
case clsQxUsersEN.con_IsSynch:
return this.isSynch;
case clsQxUsersEN.con_SynchDate:
return this.synchDate;
case "sf_UpdFldSetStr":
return this.sf_UpdFldSetStr;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[QxUsers]中不存在！`;
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
case clsQxUsersEN.con_UserId:
this.userId = strValue;
    this.hmProperty["userId"] = true;
break;
case clsQxUsersEN.con_UserName:
this.userName = strValue;
    this.hmProperty["userName"] = true;
break;
case clsQxUsersEN.con_DepartmentId:
this.departmentId = strValue;
    this.hmProperty["departmentId"] = true;
break;
case clsQxUsersEN.con_id_XzCollege:
this.id_XzCollege = strValue;
    this.hmProperty["id_XzCollege"] = true;
break;
case clsQxUsersEN.con_UserStateId:
this.userStateId = strValue;
    this.hmProperty["userStateId"] = true;
break;
case clsQxUsersEN.con_id_GradeBase:
this.id_GradeBase = strValue;
    this.hmProperty["id_GradeBase"] = true;
break;
case clsQxUsersEN.con_Card_State:
this.card_State = strValue;
    this.hmProperty["card_State"] = true;
break;
case clsQxUsersEN.con_IsLeaved:
this.isLeaved = Boolean(strValue);
    this.hmProperty["isLeaved"] = true;
break;
case clsQxUsersEN.con_CardNo:
this.cardNo = strValue;
    this.hmProperty["cardNo"] = true;
break;
case clsQxUsersEN.con_BeginYearMonth:
this.beginYearMonth = strValue;
    this.hmProperty["beginYearMonth"] = true;
break;
case clsQxUsersEN.con_EndYearMonth:
this.endYearMonth = strValue;
    this.hmProperty["endYearMonth"] = true;
break;
case clsQxUsersEN.con_OptUser:
this.optUser = strValue;
    this.hmProperty["optUser"] = true;
break;
case clsQxUsersEN.con_OptDate:
this.optDate = strValue;
    this.hmProperty["optDate"] = true;
break;
case clsQxUsersEN.con_Memo:
this.memo = strValue;
    this.hmProperty["memo"] = true;
break;
case clsQxUsersEN.con_Password:
this.password = strValue;
    this.hmProperty["password"] = true;
break;
case clsQxUsersEN.con_IsGpUser:
this.isGpUser = Boolean(strValue);
    this.hmProperty["isGpUser"] = true;
break;
case clsQxUsersEN.con_SchoolID1:
this.schoolID1 = strValue;
    this.hmProperty["schoolID1"] = true;
break;
case clsQxUsersEN.con_AvatarsPicture:
this.avatarsPicture = strValue;
    this.hmProperty["avatarsPicture"] = true;
break;
case clsQxUsersEN.con_Email:
this.email = strValue;
    this.hmProperty["email"] = true;
break;
case clsQxUsersEN.con_PhoneNumber:
this.phoneNumber = strValue;
    this.hmProperty["phoneNumber"] = true;
break;
case clsQxUsersEN.con_EffectiveDate:
this.effectiveDate = strValue;
    this.hmProperty["effectiveDate"] = true;
break;
case clsQxUsersEN.con_UpdDate:
this.updDate = strValue;
    this.hmProperty["updDate"] = true;
break;
case clsQxUsersEN.con_UpdUser:
this.updUser = strValue;
    this.hmProperty["updUser"] = true;
break;
case clsQxUsersEN.con_EffitiveBeginDate:
this.effitiveBeginDate = strValue;
    this.hmProperty["effitiveBeginDate"] = true;
break;
case clsQxUsersEN.con_EffitiveEndDate:
this.effitiveEndDate = strValue;
    this.hmProperty["effitiveEndDate"] = true;
break;
case clsQxUsersEN.con_id_College:
this.id_College = strValue;
    this.hmProperty["id_College"] = true;
break;
case clsQxUsersEN.con_StuTeacherID:
this.stuTeacherID = strValue;
    this.hmProperty["stuTeacherID"] = true;
break;
case clsQxUsersEN.con_IdentityID:
this.identityID = strValue;
    this.hmProperty["identityID"] = true;
break;
case clsQxUsersEN.con_IsArchive:
this.isArchive = Boolean(strValue);
    this.hmProperty["isArchive"] = true;
break;
case clsQxUsersEN.con_headimgUrl:
this.headimgUrl = strValue;
    this.hmProperty["headimgUrl"] = true;
break;
case clsQxUsersEN.con_OpenId:
this.openId = strValue;
    this.hmProperty["openId"] = true;
break;
case clsQxUsersEN.con_NickName:
this.nickName = strValue;
    this.hmProperty["nickName"] = true;
break;
case clsQxUsersEN.con_IsSynch:
this.isSynch = Boolean(strValue);
    this.hmProperty["isSynch"] = true;
break;
case clsQxUsersEN.con_SynchDate:
this.synchDate = strValue;
    this.hmProperty["synchDate"] = true;
break;
case "sf_UpdFldSetStr":
this.sf_UpdFldSetStr = strValue;
break;
case "sf_FldComparisonOp":
this.sf_FldComparisonOp = strValue;
break;
default:
strMsg = `字段名:[${strFldName}]在表对象:[QxUsers]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
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
public id_XzCollege = "";    //学院流水号
public userStateId = "";    //用户状态Id
public id_GradeBase = "";    //年级流水号
public card_State = "";    //Card_State
public isLeaved = false;    //IsLeaved
public cardNo = "";    //卡号
public beginYearMonth = "";    //开始年月
public endYearMonth = "";    //结束年月
public optUser = "";    //OptUser
public optDate = "";    //OptDate
public memo = "";    //备注
public password = "";    //Password
public isGpUser = false;    //是否Gp用户
public schoolID1 = "";    //学校编号
public avatarsPicture = "";    //AvatarsPicture
public email = "";    //电子邮箱
public phoneNumber = "";    //PhoneNumber
public effectiveDate = "";    //EffectiveDate
public updDate = "";    //修改日期
public updUser = "";    //修改人
public effitiveBeginDate = "";    //EffitiveBeginDate
public effitiveEndDate = "";    //EffitiveEndDate
public id_College = "";    //学院流水号
public stuTeacherID = "";    //学工号
public identityID = "";    //身份编号
public isArchive = false;    //IsArchive
public headimgUrl = "";    //微信头像
public openId = "";    //微信OpenId
public nickName = "";    //昵称
public isSynch = false;    //是否同步
public synchDate = "";    //同步日期


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
 * 常量:"id_XzCollege"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_XzCollege(): string {return "id_XzCollege";}    //学院流水号

 /**
 * 常量:"UserStateId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UserStateId(): string {return "userStateId";}    //用户状态Id

 /**
 * 常量:"id_GradeBase"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_GradeBase(): string {return "id_GradeBase";}    //年级流水号

 /**
 * 常量:"Card_State"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Card_State(): string {return "card_State";}    //Card_State

 /**
 * 常量:"IsLeaved"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsLeaved(): string {return "isLeaved";}    //IsLeaved

 /**
 * 常量:"CardNo"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CardNo(): string {return "cardNo";}    //卡号

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
 * 常量:"OptUser"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_OptUser(): string {return "optUser";}    //OptUser

 /**
 * 常量:"OptDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_OptDate(): string {return "optDate";}    //OptDate

 /**
 * 常量:"Memo"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Memo(): string {return "memo";}    //备注

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
 * 常量:"AvatarsPicture"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_AvatarsPicture(): string {return "avatarsPicture";}    //AvatarsPicture

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
 * 常量:"EffectiveDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_EffectiveDate(): string {return "effectiveDate";}    //EffectiveDate

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
 * 常量:"EffitiveBeginDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_EffitiveBeginDate(): string {return "effitiveBeginDate";}    //EffitiveBeginDate

 /**
 * 常量:"EffitiveEndDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_EffitiveEndDate(): string {return "effitiveEndDate";}    //EffitiveEndDate

 /**
 * 常量:"id_College"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_College(): string {return "id_College";}    //学院流水号

 /**
 * 常量:"StuTeacherID"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_StuTeacherID(): string {return "stuTeacherID";}    //学工号

 /**
 * 常量:"IdentityID"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IdentityID(): string {return "identityID";}    //身份编号

 /**
 * 常量:"IsArchive"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsArchive(): string {return "isArchive";}    //IsArchive

 /**
 * 常量:"headimgUrl"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_headimgUrl(): string {return "headimgUrl";}    //微信头像

 /**
 * 常量:"OpenId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_OpenId(): string {return "openId";}    //微信OpenId

 /**
 * 常量:"nickName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_NickName(): string {return "nickName";}    //昵称

 /**
 * 常量:"IsSynch"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsSynch(): string {return "isSynch";}    //是否同步

 /**
 * 常量:"SynchDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SynchDate(): string {return "synchDate";}    //同步日期

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