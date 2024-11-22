
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsQxUsersEN
 表名:QxUsers(00140015)
 生成代码版本:2019.07.15.2
 生成日期:2019/07/18 14:54:34
 生成者:
 工程名称:统一平台
 工程ID:0014
 相关数据库:101.251.68.133,9433GeneralPlatformTz
 PrjDataBaseId:0184
 模块中文名:用户管理
 模块英文名:UserManage
 框架-层名:实体层(EntityLayer)
 编程语言:TypeScript
 == == == == == == == == == == == == 
 */
 /// <summary>
 /// 用户(QxUsers)
 /// (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 /// </summary>
/// <reference path="../../PubFun/clsGeneralTab.ts" />
import { clsGeneralTab } from '../../PubFun/clsGeneralTab.js';
export class clsQxUsersEN extends clsGeneralTab
{
public mintAttributeCount = 20;
public AttributeName = new Array("UserId", "UserName", "DepartmentId", "UserStateId", "EffectiveDate", "Password", "id_College", "EffitiveBeginDate", "EffitiveEndDate", "StuTeacherId", "IdentityID", "IsArchive", "openid", "Email", "PhoneNumber", "IsSynch", "SynchDate", "UpdDate", "UpdUser", "Memo");
//以下是属性变量

/// <summary>
/// 构造函数
 /// (AutoGCLib.EntityLayer4TypeScript:GenClassConstructor1)
/// </summary>
 constructor()
 {
 super();
 this._CurrTabName = "QxUsers";
 this._KeyFldName = "UserId";
 }

private mstrUserId: string="";    //用户ID
private mstrUserName: string="";    //用户名
private mstrDepartmentId: string="";    //部门Id
private mstrUserStateId: string="";    //用户状态Id
private mstrEffectiveDate: string="";    //有效日期
private mstrPassword: string="";    //口令
private mstrid_College: string="";    //学院流水号
private mstrEffitiveBeginDate: string="";    //有效开始日期
private mstrEffitiveEndDate: string="";    //有效结束日期
private mstrStuTeacherId: string="";    //学工号
private mstrIdentityID: string="";    //身份编号
private mbolIsArchive: boolean=false;    //是否存档
private mstropenid: string="";    //微信openid
private mstrEmail: string="";    //邮箱
private mstrPhoneNumber: string="";    //电话号码
private mbolIsSynch: boolean=false;    //是否同步
private mstrSynchDate: string="";    //同步日期
private mstrUpdDate: string="";    //修改日期
private mstrUpdUser: string="";    //修改用户
private mstrMemo: string="";    //备注

/// <summary>
/// 用户ID(说明:;字段类型:varchar;字段长度:18;是否可空:False)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public get UserId ()
{
return this.mstrUserId;
};
/// <summary>
/// 用户ID(说明:;字段类型:varchar;字段长度:18;是否可空:False)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public set UserId (value: string)
{
 this.mstrUserId = value;
    this.hmProperty["UserId"] = true;
};

/// <summary>
/// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public get UserName ()
{
return this.mstrUserName;
};
/// <summary>
/// 用户名(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public set UserName (value: string)
{
 this.mstrUserName = value;
    this.hmProperty["UserName"] = true;
};

/// <summary>
/// 部门Id(说明:;字段类型:varchar;字段长度:8;是否可空:False)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public get DepartmentId ()
{
return this.mstrDepartmentId;
};
/// <summary>
/// 部门Id(说明:;字段类型:varchar;字段长度:8;是否可空:False)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public set DepartmentId (value: string)
{
 this.mstrDepartmentId = value;
    this.hmProperty["DepartmentId"] = true;
};

/// <summary>
/// 用户状态Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public get UserStateId ()
{
return this.mstrUserStateId;
};
/// <summary>
/// 用户状态Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public set UserStateId (value: string)
{
 this.mstrUserStateId = value;
    this.hmProperty["UserStateId"] = true;
};

/// <summary>
/// 有效日期(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public get EffectiveDate ()
{
return this.mstrEffectiveDate;
};
/// <summary>
/// 有效日期(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public set EffectiveDate (value: string)
{
 this.mstrEffectiveDate = value;
    this.hmProperty["EffectiveDate"] = true;
};

/// <summary>
/// 口令(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public get Password ()
{
return this.mstrPassword;
};
/// <summary>
/// 口令(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public set Password (value: string)
{
 this.mstrPassword = value;
    this.hmProperty["Password"] = true;
};

/// <summary>
/// 学院流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public get id_College ()
{
return this.mstrid_College;
};
/// <summary>
/// 学院流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public set id_College (value: string)
{
 this.mstrid_College = value;
    this.hmProperty["id_College"] = true;
};

/// <summary>
/// 有效开始日期(说明:;字段类型:varchar;字段长度:14;是否可空:False)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public get EffitiveBeginDate ()
{
return this.mstrEffitiveBeginDate;
};
/// <summary>
/// 有效开始日期(说明:;字段类型:varchar;字段长度:14;是否可空:False)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public set EffitiveBeginDate (value: string)
{
 this.mstrEffitiveBeginDate = value;
    this.hmProperty["EffitiveBeginDate"] = true;
};

/// <summary>
/// 有效结束日期(说明:;字段类型:varchar;字段长度:14;是否可空:False)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public get EffitiveEndDate ()
{
return this.mstrEffitiveEndDate;
};
/// <summary>
/// 有效结束日期(说明:;字段类型:varchar;字段长度:14;是否可空:False)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public set EffitiveEndDate (value: string)
{
 this.mstrEffitiveEndDate = value;
    this.hmProperty["EffitiveEndDate"] = true;
};

/// <summary>
/// 学工号(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public get StuTeacherId ()
{
return this.mstrStuTeacherId;
};
/// <summary>
/// 学工号(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public set StuTeacherId (value: string)
{
 this.mstrStuTeacherId = value;
    this.hmProperty["StuTeacherId"] = true;
};

/// <summary>
/// 身份编号(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public get IdentityID ()
{
return this.mstrIdentityID;
};
/// <summary>
/// 身份编号(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public set IdentityID (value: string)
{
 this.mstrIdentityID = value;
    this.hmProperty["IdentityID"] = true;
};

/// <summary>
/// 是否存档(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public get IsArchive ()
{
return this.mbolIsArchive;
};
/// <summary>
/// 是否存档(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public set IsArchive (value: boolean)
{
 this.mbolIsArchive = value;
    this.hmProperty["IsArchive"] = true;
};

/// <summary>
/// 微信openid(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public get openid ()
{
return this.mstropenid;
};
/// <summary>
/// 微信openid(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public set openid (value: string)
{
 this.mstropenid = value;
    this.hmProperty["openid"] = true;
};

/// <summary>
/// 邮箱(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public get Email ()
{
return this.mstrEmail;
};
/// <summary>
/// 邮箱(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public set Email (value: string)
{
 this.mstrEmail = value;
    this.hmProperty["Email"] = true;
};

/// <summary>
/// 电话号码(说明:;字段类型:varchar;字段长度:15;是否可空:True)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public get PhoneNumber ()
{
return this.mstrPhoneNumber;
};
/// <summary>
/// 电话号码(说明:;字段类型:varchar;字段长度:15;是否可空:True)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public set PhoneNumber (value: string)
{
 this.mstrPhoneNumber = value;
    this.hmProperty["PhoneNumber"] = true;
};

/// <summary>
/// 是否同步(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public get IsSynch ()
{
return this.mbolIsSynch;
};
/// <summary>
/// 是否同步(说明:;字段类型:bit;字段长度:1;是否可空:True)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public set IsSynch (value: boolean)
{
 this.mbolIsSynch = value;
    this.hmProperty["IsSynch"] = true;
};

/// <summary>
/// 同步日期(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public get SynchDate ()
{
return this.mstrSynchDate;
};
/// <summary>
/// 同步日期(说明:;字段类型:varchar;字段长度:14;是否可空:True)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public set SynchDate (value: string)
{
 this.mstrSynchDate = value;
    this.hmProperty["SynchDate"] = true;
};

/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:14;是否可空:False)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public get UpdDate ()
{
return this.mstrUpdDate;
};
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:14;是否可空:False)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public set UpdDate (value: string)
{
 this.mstrUpdDate = value;
    this.hmProperty["UpdDate"] = true;
};

/// <summary>
/// 修改用户(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public get UpdUser ()
{
return this.mstrUpdUser;
};
/// <summary>
/// 修改用户(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public set UpdUser (value: string)
{
 this.mstrUpdUser = value;
    this.hmProperty["UpdUser"] = true;
};

/// <summary>
/// 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public get Memo ()
{
return this.mstrMemo;
};
/// <summary>
/// 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public set Memo (value: string)
{
 this.mstrMemo = value;
    this.hmProperty["Memo"] = true;
};



 /// <summary>
 /// 常量:"UserId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public static get con_UserId(): string {return "UserId";}    //用户ID

 /// <summary>
 /// 常量:"UserName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public static get con_UserName(): string {return "UserName";}    //用户名

 /// <summary>
 /// 常量:"DepartmentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public static get con_DepartmentId(): string {return "DepartmentId";}    //部门Id

 /// <summary>
 /// 常量:"UserStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public static get con_UserStateId(): string {return "UserStateId";}    //用户状态Id

 /// <summary>
 /// 常量:"EffectiveDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public static get con_EffectiveDate(): string {return "EffectiveDate";}    //有效日期

 /// <summary>
 /// 常量:"Password"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public static get con_Password(): string {return "Password";}    //口令

 /// <summary>
 /// 常量:"id_College"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public static get con_id_College(): string {return "id_College";}    //学院流水号

 /// <summary>
 /// 常量:"EffitiveBeginDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public static get con_EffitiveBeginDate(): string {return "EffitiveBeginDate";}    //有效开始日期

 /// <summary>
 /// 常量:"EffitiveEndDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public static get con_EffitiveEndDate(): string {return "EffitiveEndDate";}    //有效结束日期

 /// <summary>
 /// 常量:"StuTeacherId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public static get con_StuTeacherId(): string {return "StuTeacherId";}    //学工号

 /// <summary>
 /// 常量:"IdentityID"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public static get con_IdentityID(): string {return "IdentityID";}    //身份编号

 /// <summary>
 /// 常量:"IsArchive"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public static get con_IsArchive(): string {return "IsArchive";}    //是否存档

 /// <summary>
 /// 常量:"openid"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public static get con_openid(): string {return "openid";}    //微信openid

 /// <summary>
 /// 常量:"Email"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public static get con_Email(): string {return "Email";}    //邮箱

 /// <summary>
 /// 常量:"PhoneNumber"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public static get con_PhoneNumber(): string {return "PhoneNumber";}    //电话号码

 /// <summary>
 /// 常量:"IsSynch"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public static get con_IsSynch(): string {return "IsSynch";}    //是否同步

 /// <summary>
 /// 常量:"SynchDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public static get con_SynchDate(): string {return "SynchDate";}    //同步日期

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public static get con_UpdDate(): string {return "UpdDate";}    //修改日期

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public static get con_UpdUser(): string {return "UpdUser";}    //修改用户

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public static get con_Memo(): string {return "Memo";}    //备注
};