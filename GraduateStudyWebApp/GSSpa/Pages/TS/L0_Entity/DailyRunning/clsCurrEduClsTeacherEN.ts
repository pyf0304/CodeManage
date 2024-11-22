﻿
 /**
 * 类名:clsCurrEduClsTeacherEN
 * 表名:CurrEduClsTeacher(01120124)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:09
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
 * 当前教学班教师(CurrEduClsTeacher)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTab } from '../../PubFun/clsGeneralTab.js';

export class clsCurrEduClsTeacherEN extends clsGeneralTab
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "02"; //客户端缓存
public static _CurrTabName= "CurrEduClsTeacher"; //当前表名,与该类相关的表名
public static _KeyFldName= "id_EduClsTeacher"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 12;
public static AttributeName = ["id_EduClsTeacher", "id_CurrEduCls", "id_Teacher", "id_Pk2EduClsTeacherType", "schoolTerm", "schoolYear", "openBeginDate", "openEndDate", "orderNum", "updDate", "updUser", "memo"];
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
private mlngid_EduClsTeacher = 0;    //教学班老师流水号
private mstrid_CurrEduCls = "";    //教学班流水号
private mstrid_Teacher = "";    //教师流水号
private mstrid_Pk2EduClsTeacherType = "";    //教学班老师角色(主讲,辅导)流水号
private mstrSchoolTerm = "";    //学期
private mstrSchoolYear = "";    //学年
private mstrOpenBeginDate = "";    //开放开始日期
private mstrOpenEndDate = "";    //开放结束日期
private mintOrderNum = 0;    //序号
private mstrUpdDate = "";    //修改日期
private mstrUpdUser = "";    //修改人
private mstrMemo = "";    //备注

/**
 * 教学班老师流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setid_EduClsTeacher (value: number)
{
if (value  != undefined)
{
 this.id_EduClsTeacher = value;
    this.hmProperty["id_EduClsTeacher"] = true;
}
}

/**
 * 教学班流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setid_CurrEduCls (value: string)
{
if (value  != undefined)
{
 this.id_CurrEduCls = value;
    this.hmProperty["id_CurrEduCls"] = true;
}
}

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
 * 教学班老师角色(主讲,辅导)流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setid_Pk2EduClsTeacherType (value: string)
{
if (value  != undefined)
{
 this.id_Pk2EduClsTeacherType = value;
    this.hmProperty["id_Pk2EduClsTeacherType"] = true;
}
}

/**
 * 学期(说明:;字段类型:char;字段长度:1;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetSchoolTerm (value: string)
{
if (value  != undefined)
{
 this.schoolTerm = value;
    this.hmProperty["schoolTerm"] = true;
}
}

/**
 * 学年(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetSchoolYear (value: string)
{
if (value  != undefined)
{
 this.schoolYear = value;
    this.hmProperty["schoolYear"] = true;
}
}

/**
 * 开放开始日期(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetOpenBeginDate (value: string)
{
if (value  != undefined)
{
 this.openBeginDate = value;
    this.hmProperty["openBeginDate"] = true;
}
}

/**
 * 开放结束日期(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetOpenEndDate (value: string)
{
if (value  != undefined)
{
 this.openEndDate = value;
    this.hmProperty["openEndDate"] = true;
}
}

/**
 * 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetOrderNum (value: number)
{
if (value  != undefined)
{
 this.orderNum = value;
    this.hmProperty["orderNum"] = true;
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
case clsCurrEduClsTeacherEN.con_id_EduClsTeacher:
return this.id_EduClsTeacher;
case clsCurrEduClsTeacherEN.con_id_CurrEduCls:
return this.id_CurrEduCls;
case clsCurrEduClsTeacherEN.con_id_Teacher:
return this.id_Teacher;
case clsCurrEduClsTeacherEN.con_id_Pk2EduClsTeacherType:
return this.id_Pk2EduClsTeacherType;
case clsCurrEduClsTeacherEN.con_SchoolTerm:
return this.schoolTerm;
case clsCurrEduClsTeacherEN.con_SchoolYear:
return this.schoolYear;
case clsCurrEduClsTeacherEN.con_OpenBeginDate:
return this.openBeginDate;
case clsCurrEduClsTeacherEN.con_OpenEndDate:
return this.openEndDate;
case clsCurrEduClsTeacherEN.con_OrderNum:
return this.orderNum;
case clsCurrEduClsTeacherEN.con_UpdDate:
return this.updDate;
case clsCurrEduClsTeacherEN.con_UpdUser:
return this.updUser;
case clsCurrEduClsTeacherEN.con_Memo:
return this.memo;
case "sf_UpdFldSetStr":
return this.sf_UpdFldSetStr;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[CurrEduClsTeacher]中不存在！`;
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
case clsCurrEduClsTeacherEN.con_id_EduClsTeacher:
this.id_EduClsTeacher = Number(strValue);
    this.hmProperty["id_EduClsTeacher"] = true;
break;
case clsCurrEduClsTeacherEN.con_id_CurrEduCls:
this.id_CurrEduCls = strValue;
    this.hmProperty["id_CurrEduCls"] = true;
break;
case clsCurrEduClsTeacherEN.con_id_Teacher:
this.id_Teacher = strValue;
    this.hmProperty["id_Teacher"] = true;
break;
case clsCurrEduClsTeacherEN.con_id_Pk2EduClsTeacherType:
this.id_Pk2EduClsTeacherType = strValue;
    this.hmProperty["id_Pk2EduClsTeacherType"] = true;
break;
case clsCurrEduClsTeacherEN.con_SchoolTerm:
this.schoolTerm = strValue;
    this.hmProperty["schoolTerm"] = true;
break;
case clsCurrEduClsTeacherEN.con_SchoolYear:
this.schoolYear = strValue;
    this.hmProperty["schoolYear"] = true;
break;
case clsCurrEduClsTeacherEN.con_OpenBeginDate:
this.openBeginDate = strValue;
    this.hmProperty["openBeginDate"] = true;
break;
case clsCurrEduClsTeacherEN.con_OpenEndDate:
this.openEndDate = strValue;
    this.hmProperty["openEndDate"] = true;
break;
case clsCurrEduClsTeacherEN.con_OrderNum:
this.orderNum = Number(strValue);
    this.hmProperty["orderNum"] = true;
break;
case clsCurrEduClsTeacherEN.con_UpdDate:
this.updDate = strValue;
    this.hmProperty["updDate"] = true;
break;
case clsCurrEduClsTeacherEN.con_UpdUser:
this.updUser = strValue;
    this.hmProperty["updUser"] = true;
break;
case clsCurrEduClsTeacherEN.con_Memo:
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
strMsg = `字段名:[${strFldName}]在表对象:[CurrEduClsTeacher]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
console.error(strMsg);
break;
}
}

/**
 * 设置对象中公共属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
*/
public id_EduClsTeacher = 0;    //教学班老师流水号
public id_CurrEduCls = "";    //教学班流水号
public id_Teacher = "";    //教师流水号
public id_Pk2EduClsTeacherType = "";    //教学班老师角色(主讲,辅导)流水号
public schoolTerm = "";    //学期
public schoolYear = "";    //学年
public openBeginDate = "";    //开放开始日期
public openEndDate = "";    //开放结束日期
public orderNum = 0;    //序号
public updDate = "";    //修改日期
public updUser = "";    //修改人
public memo = "";    //备注


 /**
 * 常量:"id_EduClsTeacher"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_EduClsTeacher(): string {return "id_EduClsTeacher";}    //教学班老师流水号

 /**
 * 常量:"id_CurrEduCls"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_CurrEduCls(): string {return "id_CurrEduCls";}    //教学班流水号

 /**
 * 常量:"id_Teacher"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_Teacher(): string {return "id_Teacher";}    //教师流水号

 /**
 * 常量:"id_Pk2EduClsTeacherType"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_Pk2EduClsTeacherType(): string {return "id_Pk2EduClsTeacherType";}    //教学班老师角色(主讲,辅导)流水号

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
 * 常量:"OpenBeginDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_OpenBeginDate(): string {return "openBeginDate";}    //开放开始日期

 /**
 * 常量:"OpenEndDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_OpenEndDate(): string {return "openEndDate";}    //开放结束日期

 /**
 * 常量:"OrderNum"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_OrderNum(): string {return "orderNum";}    //序号

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