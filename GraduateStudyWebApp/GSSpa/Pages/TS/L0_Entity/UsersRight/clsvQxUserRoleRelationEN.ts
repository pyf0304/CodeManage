﻿
 /**
 * 类名:clsvQxUserRoleRelationEN
 * 表名:vQxUserRoleRelation(01120257)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 12:02:36
 * 生成者:pyf
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:权限管理(UsersRight)
 * 框架-层名:实体层(TS)(EntityLayer)
 * 编程语言:TypeScript
 **/
 /**
 * vQx用户角色关系(vQxUserRoleRelation)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTabV } from '../../PubFun/clsGeneralTabV.js';

export class clsvQxUserRoleRelationEN extends clsGeneralTabV
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "02"; //客户端缓存
public static _CurrTabName= "vQxUserRoleRelation"; //当前表名,与该类相关的表名
public static _KeyFldName= "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 20;
public static AttributeName = ["mId", "userId", "roleId", "qxPrjId", "memo", "prjName", "roleName", "userName", "departmentId", "userStateId", "departmentName", "userStateName", "identityDesc", "identityID", "stuTeacherID", "id_XzMajor", "collegeName", "id_XzCollege", "majorName", "password"];
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
case clsvQxUserRoleRelationEN.con_mId:
return this.mId;
case clsvQxUserRoleRelationEN.con_UserId:
return this.userId;
case clsvQxUserRoleRelationEN.con_RoleId:
return this.roleId;
case clsvQxUserRoleRelationEN.con_QxPrjId:
return this.qxPrjId;
case clsvQxUserRoleRelationEN.con_Memo:
return this.memo;
case clsvQxUserRoleRelationEN.con_PrjName:
return this.prjName;
case clsvQxUserRoleRelationEN.con_RoleName:
return this.roleName;
case clsvQxUserRoleRelationEN.con_UserName:
return this.userName;
case clsvQxUserRoleRelationEN.con_DepartmentId:
return this.departmentId;
case clsvQxUserRoleRelationEN.con_UserStateId:
return this.userStateId;
case clsvQxUserRoleRelationEN.con_DepartmentName:
return this.departmentName;
case clsvQxUserRoleRelationEN.con_UserStateName:
return this.userStateName;
case clsvQxUserRoleRelationEN.con_IdentityDesc:
return this.identityDesc;
case clsvQxUserRoleRelationEN.con_IdentityID:
return this.identityID;
case clsvQxUserRoleRelationEN.con_StuTeacherID:
return this.stuTeacherID;
case clsvQxUserRoleRelationEN.con_id_XzMajor:
return this.id_XzMajor;
case clsvQxUserRoleRelationEN.con_CollegeName:
return this.collegeName;
case clsvQxUserRoleRelationEN.con_id_XzCollege:
return this.id_XzCollege;
case clsvQxUserRoleRelationEN.con_MajorName:
return this.majorName;
case clsvQxUserRoleRelationEN.con_Password:
return this.password;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[vQxUserRoleRelation]中不存在！`;
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
case clsvQxUserRoleRelationEN.con_mId:
this.mId = Number(strValue);
break;
case clsvQxUserRoleRelationEN.con_UserId:
this.userId = strValue;
break;
case clsvQxUserRoleRelationEN.con_RoleId:
this.roleId = strValue;
break;
case clsvQxUserRoleRelationEN.con_QxPrjId:
this.qxPrjId = strValue;
break;
case clsvQxUserRoleRelationEN.con_Memo:
this.memo = strValue;
break;
case clsvQxUserRoleRelationEN.con_PrjName:
this.prjName = strValue;
break;
case clsvQxUserRoleRelationEN.con_RoleName:
this.roleName = strValue;
break;
case clsvQxUserRoleRelationEN.con_UserName:
this.userName = strValue;
break;
case clsvQxUserRoleRelationEN.con_DepartmentId:
this.departmentId = strValue;
break;
case clsvQxUserRoleRelationEN.con_UserStateId:
this.userStateId = strValue;
break;
case clsvQxUserRoleRelationEN.con_DepartmentName:
this.departmentName = strValue;
break;
case clsvQxUserRoleRelationEN.con_UserStateName:
this.userStateName = strValue;
break;
case clsvQxUserRoleRelationEN.con_IdentityDesc:
this.identityDesc = strValue;
break;
case clsvQxUserRoleRelationEN.con_IdentityID:
this.identityID = strValue;
break;
case clsvQxUserRoleRelationEN.con_StuTeacherID:
this.stuTeacherID = strValue;
break;
case clsvQxUserRoleRelationEN.con_id_XzMajor:
this.id_XzMajor = strValue;
break;
case clsvQxUserRoleRelationEN.con_CollegeName:
this.collegeName = strValue;
break;
case clsvQxUserRoleRelationEN.con_id_XzCollege:
this.id_XzCollege = strValue;
break;
case clsvQxUserRoleRelationEN.con_MajorName:
this.majorName = strValue;
break;
case clsvQxUserRoleRelationEN.con_Password:
this.password = strValue;
break;
case "sf_FldComparisonOp":
this.sf_FldComparisonOp = strValue;
break;
default:
strMsg = `字段名:[${strFldName}]在表对象:[vQxUserRoleRelation]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
console.error(strMsg);
break;
}
}

/**
 * 设置对象中公共属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
*/
public mId = 0;    //mId
public userId = "";    //用户ID
public roleId = "";    //角色Id
public qxPrjId = "";    //QxPrjId
public memo = "";    //备注
public prjName = "";    //PrjName
public roleName = "";    //角色名
public userName = "";    //用户名
public departmentId = "";    //部门Id
public userStateId = "";    //用户状态Id
public departmentName = "";    //部门名称
public userStateName = "";    //用户状态名
public identityDesc = "";    //身份描述
public identityID = "";    //身份编号
public stuTeacherID = "";    //学工号
public id_XzMajor = "";    //专业流水号
public collegeName = "";    //学院名称
public id_XzCollege = "";    //学院流水号
public majorName = "";    //专业名称
public password = "";    //Password


 /**
 * 常量:"mId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_mId(): string {return "mId";}    //mId

 /**
 * 常量:"UserId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UserId(): string {return "userId";}    //用户ID

 /**
 * 常量:"RoleId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_RoleId(): string {return "roleId";}    //角色Id

 /**
 * 常量:"QxPrjId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_QxPrjId(): string {return "qxPrjId";}    //QxPrjId

 /**
 * 常量:"Memo"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Memo(): string {return "memo";}    //备注

 /**
 * 常量:"PrjName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PrjName(): string {return "prjName";}    //PrjName

 /**
 * 常量:"RoleName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_RoleName(): string {return "roleName";}    //角色名

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
 * 常量:"DepartmentName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_DepartmentName(): string {return "departmentName";}    //部门名称

 /**
 * 常量:"UserStateName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UserStateName(): string {return "userStateName";}    //用户状态名

 /**
 * 常量:"IdentityDesc"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IdentityDesc(): string {return "identityDesc";}    //身份描述

 /**
 * 常量:"IdentityID"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IdentityID(): string {return "identityID";}    //身份编号

 /**
 * 常量:"StuTeacherID"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_StuTeacherID(): string {return "stuTeacherID";}    //学工号

 /**
 * 常量:"id_XzMajor"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_XzMajor(): string {return "id_XzMajor";}    //专业流水号

 /**
 * 常量:"CollegeName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CollegeName(): string {return "collegeName";}    //学院名称

 /**
 * 常量:"id_XzCollege"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_XzCollege(): string {return "id_XzCollege";}    //学院流水号

 /**
 * 常量:"MajorName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_MajorName(): string {return "majorName";}    //专业名称

 /**
 * 常量:"Password"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Password(): string {return "password";}    //Password

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