
 /**
 * 类名:clsUserTypeEN
 * 表名:UserType(01120309)
 * 生成代码版本:2021.09.26.2
 * 生成日期:2021/09/27 18:00:35
 * 生成者:pyf
 * 工程名称:问卷调查
 * 工程ID:0112
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 * 模块中文名:用户管理
 * 模块英文名:UserManage
 * 框架-层名:实体层(EntityLayer)
 * 编程语言:TypeScript
 **/
 /**
 * 用户类型(UserType)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTab2 } from '../../PubFun/clsGeneralTab2.js';
export class clsUserTypeEN extends clsGeneralTab2
{
[x: string]: any;//索引类型
public static _CurrTabName= "UserType"; //当前表名,与该类相关的表名
public static _KeyFldName= "userTypeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 4;
public static AttributeName = ["userTypeId", "userTypeName", "UserTypeName_Sim", "memo"];
//以下是属性变量

/**
 * 构造函数
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
*/
 constructor()
 {
 super();
 }

private mstrUserTypeId = "";    //用户类型Id
private mstrUserTypeName = "";    //用户类型名称
private mstrUserTypeName_Sim = "";    //用户类型名_Sim
private mstrMemo = "";    //备注

/**
 * 用户类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get userTypeId ()
{
return this.mstrUserTypeId;
}
/**
 * 用户类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set userTypeId (value: string)
{
if (value  != undefined)
{
 this.mstrUserTypeId = value;
    this.hmProperty["userTypeId"] = true;
}
}

/**
 * 用户类型名称(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get userTypeName ()
{
return this.mstrUserTypeName;
}
/**
 * 用户类型名称(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set userTypeName (value: string)
{
if (value  != undefined)
{
 this.mstrUserTypeName = value;
    this.hmProperty["userTypeName"] = true;
}
}

/**
 * 用户类型名_Sim(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get UserTypeName_Sim ()
{
return this.mstrUserTypeName_Sim;
}
/**
 * 用户类型名_Sim(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set UserTypeName_Sim (value: string)
{
if (value  != undefined)
{
 this.mstrUserTypeName_Sim = value;
    this.hmProperty["UserTypeName_Sim"] = true;
}
}

/**
 * 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get memo ()
{
return this.mstrMemo;
}
/**
 * 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set memo (value: string)
{
if (value  != undefined)
{
 this.mstrMemo = value;
    this.hmProperty["memo"] = true;
}
}



 /**
 * 常量:"userTypeId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UserTypeId(): string {return "userTypeId";}    //用户类型Id

 /**
 * 常量:"userTypeName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UserTypeName(): string {return "userTypeName";}    //用户类型名称

 /**
 * 常量:"UserTypeName_Sim"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UserTypeName_Sim(): string {return "UserTypeName_Sim";}    //用户类型名_Sim

 /**
 * 常量:"memo"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Memo(): string {return "memo";}    //备注

public SetCondFldValue(strFldName: string, strFldValue: any, strComparisonOp: string): void {                
this[strFldName] = strFldValue;
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
 /**
 * 用户类型(UserType)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
export class clsUserTypeEN_Sim
{
[x: string]: any;//索引类型
//以下是属性变量

/**
 * 用户类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public userTypeId = "";

/**
 * 用户类型名称(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public userTypeName = "";

/**
 * 用户类型名_Sim(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public UserTypeName_Sim = "";

/**
 * 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public memo = "";

public sfUpdFldSetStr = "";     //专门用于记录某字段属性是否修改
public sf_FldComparisonOp = "";     //专门用于记录条件对象某字段的比较运算符
}