
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUsersEN
 表名:vUsers(01160035)
 生成代码版本:2019.07.10.1
 生成日期:2019/07/11 01:24:46
 生成者:
 工程名称:简单工程样例
 工程ID:0116
 相关数据库:101.251.68.133,9433AGC
 PrjDataBaseId:0111
 模块中文名:基本信息
 模块英文名:BaseInfo
 框架-层名:实体层(EntityLayer)
 编程语言:TypeScript
 == == == == == == == == == == == == 
 */
 /// <summary>
 /// vUsers(vUsers)
 /// (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 /// </summary>
/// <reference path="../../PubFun/clsGeneralTab.ts" />
import { clsGeneralTab } from '../../PubFun/clsGeneralTab.js';
export class clsvUsersEN extends clsGeneralTab
{
public mintAttributeCount = 9;
public AttributeName = new Array("UserId", "UserName", "UserStateId", "UserStateName", "Password", "DepartmentId", "DepartmentName", "OrderNum", "Memo");
//以下是属性变量

/// <summary>
/// 构造函数
 /// (AutoGCLib.EntityLayer4TypeScript:GenClassConstructor1)
/// </summary>
 constructor()
 {
 super();
 this._CurrTabName = "vUsers";
 this._KeyFldName = "UserId";
 }

private mstrUserId: string="";    //用户ID
private mstrUserName: string="";    //用户名
private mstrUserStateId: string="";    //用户状态号
private mstrUserStateName: string="";    //用户状态名
private mstrPassword: string="";    //密码
private mstrDepartmentId: string="";    //部门ID
private mstrDepartmentName: string="";    //部门名称
private mintOrderNum: number=0;    //排序
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
/// 用户状态号(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public get UserStateId ()
{
return this.mstrUserStateId;
};
/// <summary>
/// 用户状态号(说明:;字段类型:char;字段长度:2;是否可空:False)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public set UserStateId (value: string)
{
 this.mstrUserStateId = value;
    this.hmProperty["UserStateId"] = true;
};

/// <summary>
/// 用户状态名(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public get UserStateName ()
{
return this.mstrUserStateName;
};
/// <summary>
/// 用户状态名(说明:;字段类型:varchar;字段长度:20;是否可空:False)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public set UserStateName (value: string)
{
 this.mstrUserStateName = value;
    this.hmProperty["UserStateName"] = true;
};

/// <summary>
/// 密码(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public get Password ()
{
return this.mstrPassword;
};
/// <summary>
/// 密码(说明:;字段类型:varchar;字段长度:100;是否可空:False)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public set Password (value: string)
{
 this.mstrPassword = value;
    this.hmProperty["Password"] = true;
};

/// <summary>
/// 部门ID(说明:;字段类型:varchar;字段长度:6;是否可空:True)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public get DepartmentId ()
{
return this.mstrDepartmentId;
};
/// <summary>
/// 部门ID(说明:;字段类型:varchar;字段长度:6;是否可空:True)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public set DepartmentId (value: string)
{
 this.mstrDepartmentId = value;
    this.hmProperty["DepartmentId"] = true;
};

/// <summary>
/// 部门名称(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public get DepartmentName ()
{
return this.mstrDepartmentName;
};
/// <summary>
/// 部门名称(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public set DepartmentName (value: string)
{
 this.mstrDepartmentName = value;
    this.hmProperty["DepartmentName"] = true;
};

/// <summary>
/// 排序(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public get OrderNum ()
{
return this.mintOrderNum;
};
/// <summary>
/// 排序(说明:;字段类型:int;字段长度:4;是否可空:True)
 /// (AutoGCLib.EntityLayer4TypeScript:GenClsProperty)
/// </summary>
 public set OrderNum (value: number)
{
 this.mintOrderNum = value;
    this.hmProperty["OrderNum"] = true;
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
 /// 常量:"UserStateId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public static get con_UserStateId(): string {return "UserStateId";}    //用户状态号

 /// <summary>
 /// 常量:"UserStateName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public static get con_UserStateName(): string {return "UserStateName";}    //用户状态名

 /// <summary>
 /// 常量:"Password"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public static get con_Password(): string {return "Password";}    //密码

 /// <summary>
 /// 常量:"DepartmentId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public static get con_DepartmentId(): string {return "DepartmentId";}    //部门ID

 /// <summary>
 /// 常量:"DepartmentName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public static get con_DepartmentName(): string {return "DepartmentName";}    //部门名称

 /// <summary>
 /// 常量:"OrderNum"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public static get con_OrderNum(): string {return "OrderNum";}    //排序

 /// <summary>
 /// 常量:"Memo"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public static get con_Memo(): string {return "Memo";}    //备注
};