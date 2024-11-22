﻿
 /**
 * 类名:clsCurrEduClsStuEN
 * 表名:CurrEduClsStu(01120125)
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
 * 教学班与学生关系(CurrEduClsStu)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTab } from '../../PubFun/clsGeneralTab.js';

export class clsCurrEduClsStuEN extends clsGeneralTab
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "02"; //客户端缓存
public static _CurrTabName= "CurrEduClsStu"; //当前表名,与该类相关的表名
public static _KeyFldName= "id_EduClsStu"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 25;
public static AttributeName = ["id_EduClsStu", "id_CurrEduCls", "id_Stu", "eduClsStuStateID", "getScoreTimes", "score", "totalScores", "ranking", "percentile", "ranking2", "percentile2", "ranking3", "percentile3", "confirmed", "schoolTerm", "schoolYear", "exportDate", "signInDate", "signInStateID", "signInUser", "isOpByTeacher", "isSynScore", "modifyDate", "modifyUserID", "memo"];
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
private mlngid_EduClsStu = 0;    //教学班学生流水号
private mstrid_CurrEduCls = "";    //教学班流水号
private mstrid_Stu = "";    //学生流水号
private mstrEduClsStuStateID = "";    //教学班学生状态编号
private mshtGetScoreTimes = 0;    //获得成绩次数
private mdblScore = 0;    //得分
private mdblTotalScores = 0;    //总分值
private mintRanking = 0;    //名次
private mdblPercentile = 0;    //百分位
private mintRanking2 = 0;    //Ranking2
private mdblPercentile2 = 0;    //Percentile2
private mintRanking3 = 0;    //Ranking3
private mdblPercentile3 = 0;    //Percentile3
private mbolConfirmed = false;    //是否确认
private mstrSchoolTerm = "";    //学期
private mstrSchoolYear = "";    //学年
private mstrExportDate = "";    //导出日期
private mstrSignInDate = "";    //签入时间
private mstrSignInStateID = "";    //签入状态表流水号
private mstrSignInUser = "";    //签入人
private mbolIsOpByTeacher = false;    //是否教师操作
private mbolIsSynScore = false;    //是否同步成绩
private mstrModifyDate = "";    //修改日期
private mstrModifyUserID = "";    //修改人
private mstrMemo = "";    //备注

/**
 * 教学班学生流水号(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setid_EduClsStu (value: number)
{
if (value  != undefined)
{
 this.id_EduClsStu = value;
    this.hmProperty["id_EduClsStu"] = true;
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
 * 学生流水号(说明:;字段类型:char;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setid_Stu (value: string)
{
if (value  != undefined)
{
 this.id_Stu = value;
    this.hmProperty["id_Stu"] = true;
}
}

/**
 * 教学班学生状态编号(说明:;字段类型:char;字段长度:2;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetEduClsStuStateID (value: string)
{
if (value  != undefined)
{
 this.eduClsStuStateID = value;
    this.hmProperty["eduClsStuStateID"] = true;
}
}

/**
 * 获得成绩次数(说明:;字段类型:tinyint;字段长度:1;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetGetScoreTimes (value: number)
{
if (value  != undefined)
{
 this.getScoreTimes = value;
    this.hmProperty["getScoreTimes"] = true;
}
}

/**
 * 得分(说明:;字段类型:decimal;字段长度:6;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetScore (value: number)
{
if (value  != undefined)
{
 this.score = value;
    this.hmProperty["score"] = true;
}
}

/**
 * 总分值(说明:;字段类型:decimal;字段长度:10;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetTotalScores (value: number)
{
if (value  != undefined)
{
 this.totalScores = value;
    this.hmProperty["totalScores"] = true;
}
}

/**
 * 名次(说明:;字段类型:int;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetRanking (value: number)
{
if (value  != undefined)
{
 this.ranking = value;
    this.hmProperty["ranking"] = true;
}
}

/**
 * 百分位(说明:;字段类型:decimal;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetPercentile (value: number)
{
if (value  != undefined)
{
 this.percentile = value;
    this.hmProperty["percentile"] = true;
}
}

/**
 * Ranking2(说明:;字段类型:int;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetRanking2 (value: number)
{
if (value  != undefined)
{
 this.ranking2 = value;
    this.hmProperty["ranking2"] = true;
}
}

/**
 * Percentile2(说明:;字段类型:decimal;字段长度:10;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetPercentile2 (value: number)
{
if (value  != undefined)
{
 this.percentile2 = value;
    this.hmProperty["percentile2"] = true;
}
}

/**
 * Ranking3(说明:;字段类型:int;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetRanking3 (value: number)
{
if (value  != undefined)
{
 this.ranking3 = value;
    this.hmProperty["ranking3"] = true;
}
}

/**
 * Percentile3(说明:;字段类型:decimal;字段长度:10;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetPercentile3 (value: number)
{
if (value  != undefined)
{
 this.percentile3 = value;
    this.hmProperty["percentile3"] = true;
}
}

/**
 * 是否确认(说明:;字段类型:bit;字段长度:1;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetConfirmed (value: boolean)
{
if (value  != undefined)
{
 this.confirmed = value;
    this.hmProperty["confirmed"] = true;
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
 * 导出日期(说明:;字段类型:varchar;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetExportDate (value: string)
{
if (value  != undefined)
{
 this.exportDate = value;
    this.hmProperty["exportDate"] = true;
}
}

/**
 * 签入时间(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetSignInDate (value: string)
{
if (value  != undefined)
{
 this.signInDate = value;
    this.hmProperty["signInDate"] = true;
}
}

/**
 * 签入状态表流水号(说明:;字段类型:char;字段长度:2;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetSignInStateID (value: string)
{
if (value  != undefined)
{
 this.signInStateID = value;
    this.hmProperty["signInStateID"] = true;
}
}

/**
 * 签入人(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetSignInUser (value: string)
{
if (value  != undefined)
{
 this.signInUser = value;
    this.hmProperty["signInUser"] = true;
}
}

/**
 * 是否教师操作(说明:;字段类型:bit;字段长度:1;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetIsOpByTeacher (value: boolean)
{
if (value  != undefined)
{
 this.isOpByTeacher = value;
    this.hmProperty["isOpByTeacher"] = true;
}
}

/**
 * 是否同步成绩(说明:;字段类型:bit;字段长度:1;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetIsSynScore (value: boolean)
{
if (value  != undefined)
{
 this.isSynScore = value;
    this.hmProperty["isSynScore"] = true;
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
case clsCurrEduClsStuEN.con_id_EduClsStu:
return this.id_EduClsStu;
case clsCurrEduClsStuEN.con_id_CurrEduCls:
return this.id_CurrEduCls;
case clsCurrEduClsStuEN.con_id_Stu:
return this.id_Stu;
case clsCurrEduClsStuEN.con_EduClsStuStateID:
return this.eduClsStuStateID;
case clsCurrEduClsStuEN.con_GetScoreTimes:
return this.getScoreTimes;
case clsCurrEduClsStuEN.con_Score:
return this.score;
case clsCurrEduClsStuEN.con_TotalScores:
return this.totalScores;
case clsCurrEduClsStuEN.con_Ranking:
return this.ranking;
case clsCurrEduClsStuEN.con_Percentile:
return this.percentile;
case clsCurrEduClsStuEN.con_Ranking2:
return this.ranking2;
case clsCurrEduClsStuEN.con_Percentile2:
return this.percentile2;
case clsCurrEduClsStuEN.con_Ranking3:
return this.ranking3;
case clsCurrEduClsStuEN.con_Percentile3:
return this.percentile3;
case clsCurrEduClsStuEN.con_Confirmed:
return this.confirmed;
case clsCurrEduClsStuEN.con_SchoolTerm:
return this.schoolTerm;
case clsCurrEduClsStuEN.con_SchoolYear:
return this.schoolYear;
case clsCurrEduClsStuEN.con_ExportDate:
return this.exportDate;
case clsCurrEduClsStuEN.con_SignInDate:
return this.signInDate;
case clsCurrEduClsStuEN.con_SignInStateID:
return this.signInStateID;
case clsCurrEduClsStuEN.con_SignInUser:
return this.signInUser;
case clsCurrEduClsStuEN.con_IsOpByTeacher:
return this.isOpByTeacher;
case clsCurrEduClsStuEN.con_IsSynScore:
return this.isSynScore;
case clsCurrEduClsStuEN.con_ModifyDate:
return this.modifyDate;
case clsCurrEduClsStuEN.con_ModifyUserID:
return this.modifyUserID;
case clsCurrEduClsStuEN.con_Memo:
return this.memo;
case "sf_UpdFldSetStr":
return this.sf_UpdFldSetStr;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[CurrEduClsStu]中不存在！`;
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
case clsCurrEduClsStuEN.con_id_EduClsStu:
this.id_EduClsStu = Number(strValue);
    this.hmProperty["id_EduClsStu"] = true;
break;
case clsCurrEduClsStuEN.con_id_CurrEduCls:
this.id_CurrEduCls = strValue;
    this.hmProperty["id_CurrEduCls"] = true;
break;
case clsCurrEduClsStuEN.con_id_Stu:
this.id_Stu = strValue;
    this.hmProperty["id_Stu"] = true;
break;
case clsCurrEduClsStuEN.con_EduClsStuStateID:
this.eduClsStuStateID = strValue;
    this.hmProperty["eduClsStuStateID"] = true;
break;
case clsCurrEduClsStuEN.con_GetScoreTimes:
this.getScoreTimes = Number(strValue);
    this.hmProperty["getScoreTimes"] = true;
break;
case clsCurrEduClsStuEN.con_Score:
this.score = Number(strValue);
    this.hmProperty["score"] = true;
break;
case clsCurrEduClsStuEN.con_TotalScores:
this.totalScores = Number(strValue);
    this.hmProperty["totalScores"] = true;
break;
case clsCurrEduClsStuEN.con_Ranking:
this.ranking = Number(strValue);
    this.hmProperty["ranking"] = true;
break;
case clsCurrEduClsStuEN.con_Percentile:
this.percentile = Number(strValue);
    this.hmProperty["percentile"] = true;
break;
case clsCurrEduClsStuEN.con_Ranking2:
this.ranking2 = Number(strValue);
    this.hmProperty["ranking2"] = true;
break;
case clsCurrEduClsStuEN.con_Percentile2:
this.percentile2 = Number(strValue);
    this.hmProperty["percentile2"] = true;
break;
case clsCurrEduClsStuEN.con_Ranking3:
this.ranking3 = Number(strValue);
    this.hmProperty["ranking3"] = true;
break;
case clsCurrEduClsStuEN.con_Percentile3:
this.percentile3 = Number(strValue);
    this.hmProperty["percentile3"] = true;
break;
case clsCurrEduClsStuEN.con_Confirmed:
this.confirmed = Boolean(strValue);
    this.hmProperty["confirmed"] = true;
break;
case clsCurrEduClsStuEN.con_SchoolTerm:
this.schoolTerm = strValue;
    this.hmProperty["schoolTerm"] = true;
break;
case clsCurrEduClsStuEN.con_SchoolYear:
this.schoolYear = strValue;
    this.hmProperty["schoolYear"] = true;
break;
case clsCurrEduClsStuEN.con_ExportDate:
this.exportDate = strValue;
    this.hmProperty["exportDate"] = true;
break;
case clsCurrEduClsStuEN.con_SignInDate:
this.signInDate = strValue;
    this.hmProperty["signInDate"] = true;
break;
case clsCurrEduClsStuEN.con_SignInStateID:
this.signInStateID = strValue;
    this.hmProperty["signInStateID"] = true;
break;
case clsCurrEduClsStuEN.con_SignInUser:
this.signInUser = strValue;
    this.hmProperty["signInUser"] = true;
break;
case clsCurrEduClsStuEN.con_IsOpByTeacher:
this.isOpByTeacher = Boolean(strValue);
    this.hmProperty["isOpByTeacher"] = true;
break;
case clsCurrEduClsStuEN.con_IsSynScore:
this.isSynScore = Boolean(strValue);
    this.hmProperty["isSynScore"] = true;
break;
case clsCurrEduClsStuEN.con_ModifyDate:
this.modifyDate = strValue;
    this.hmProperty["modifyDate"] = true;
break;
case clsCurrEduClsStuEN.con_ModifyUserID:
this.modifyUserID = strValue;
    this.hmProperty["modifyUserID"] = true;
break;
case clsCurrEduClsStuEN.con_Memo:
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
strMsg = `字段名:[${strFldName}]在表对象:[CurrEduClsStu]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
console.error(strMsg);
break;
}
}

/**
 * 设置对象中公共属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
*/
public id_EduClsStu = 0;    //教学班学生流水号
public id_CurrEduCls = "";    //教学班流水号
public id_Stu = "";    //学生流水号
public eduClsStuStateID = "";    //教学班学生状态编号
public getScoreTimes = 0;    //获得成绩次数
public score = 0;    //得分
public totalScores = 0;    //总分值
public ranking = 0;    //名次
public percentile = 0;    //百分位
public ranking2 = 0;    //Ranking2
public percentile2 = 0;    //Percentile2
public ranking3 = 0;    //Ranking3
public percentile3 = 0;    //Percentile3
public confirmed = false;    //是否确认
public schoolTerm = "";    //学期
public schoolYear = "";    //学年
public exportDate = "";    //导出日期
public signInDate = "";    //签入时间
public signInStateID = "";    //签入状态表流水号
public signInUser = "";    //签入人
public isOpByTeacher = false;    //是否教师操作
public isSynScore = false;    //是否同步成绩
public modifyDate = "";    //修改日期
public modifyUserID = "";    //修改人
public memo = "";    //备注


 /**
 * 常量:"id_EduClsStu"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_EduClsStu(): string {return "id_EduClsStu";}    //教学班学生流水号

 /**
 * 常量:"id_CurrEduCls"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_CurrEduCls(): string {return "id_CurrEduCls";}    //教学班流水号

 /**
 * 常量:"id_Stu"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_Stu(): string {return "id_Stu";}    //学生流水号

 /**
 * 常量:"EduClsStuStateID"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_EduClsStuStateID(): string {return "eduClsStuStateID";}    //教学班学生状态编号

 /**
 * 常量:"GetScoreTimes"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_GetScoreTimes(): string {return "getScoreTimes";}    //获得成绩次数

 /**
 * 常量:"Score"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Score(): string {return "score";}    //得分

 /**
 * 常量:"TotalScores"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_TotalScores(): string {return "totalScores";}    //总分值

 /**
 * 常量:"Ranking"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Ranking(): string {return "ranking";}    //名次

 /**
 * 常量:"Percentile"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Percentile(): string {return "percentile";}    //百分位

 /**
 * 常量:"Ranking2"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Ranking2(): string {return "ranking2";}    //Ranking2

 /**
 * 常量:"Percentile2"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Percentile2(): string {return "percentile2";}    //Percentile2

 /**
 * 常量:"Ranking3"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Ranking3(): string {return "ranking3";}    //Ranking3

 /**
 * 常量:"Percentile3"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Percentile3(): string {return "percentile3";}    //Percentile3

 /**
 * 常量:"Confirmed"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Confirmed(): string {return "confirmed";}    //是否确认

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
 * 常量:"ExportDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ExportDate(): string {return "exportDate";}    //导出日期

 /**
 * 常量:"SignInDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SignInDate(): string {return "signInDate";}    //签入时间

 /**
 * 常量:"SignInStateID"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SignInStateID(): string {return "signInStateID";}    //签入状态表流水号

 /**
 * 常量:"SignInUser"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SignInUser(): string {return "signInUser";}    //签入人

 /**
 * 常量:"IsOpByTeacher"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsOpByTeacher(): string {return "isOpByTeacher";}    //是否教师操作

 /**
 * 常量:"IsSynScore"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsSynScore(): string {return "isSynScore";}    //是否同步成绩

 /**
 * 常量:"ModifyDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ModifyDate(): string {return "modifyDate";}    //修改日期

 /**
 * 常量:"ModifyUserID"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ModifyUserID(): string {return "modifyUserID";}    //修改人

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