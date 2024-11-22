
 /**
 * 类名:clsXzGradeBaseEN
 * 表名:XzGradeBase(01120129)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:07
 * 生成者:pyf
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:系统参数(SysPara)
 * 框架-层名:实体层(TS)(EntityLayer)
 * 编程语言:TypeScript
 **/
 /**
 * 年级(XzGradeBase)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTab } from '../../PubFun/clsGeneralTab.js';

export class clsXzGradeBaseEN extends clsGeneralTab
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "04"; //sessionStorage
public static _CurrTabName= "XzGradeBase"; //当前表名,与该类相关的表名
public static _KeyFldName= "id_GradeBase"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 22;
public static AttributeName = ["id_GradeBase", "gradeBaseID", "gradeBaseName", "gradeBaseNameA", "schoolYear", "schoolTerm", "enterSchoolDate", "currentTermSeq", "execPlanTermIndex", "setEPTermIndexDate", "isOffed", "gradeIndex", "beginYearMonth", "endYearMonth", "allowUpBaseInfo", "prefix", "pointCalcVersionId", "modifyUserID", "modifyDate", "id_StudyLevel", "isVisible", "memo"];
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
private mstrid_GradeBase = "";    //年级流水号
private mstrGradeBaseID = "";    //年级代号
private mstrGradeBaseName = "";    //年级名称
private mstrGradeBaseNameA = "";    //年级名称缩写
private mstrSchoolYear = "";    //学年
private mstrSchoolTerm = "";    //学期
private mstrEnterSchoolDate = "";    //进校日期
private mintCurrentTermSeq = 0;    //当前学期
private mshtExecPlanTermIndex = 0;    //生成执行计划学期
private mstrSetEPTermIndexDate = "";    //设定执行计划学期日期
private mbolIsOffed = false;    //是否毕业
private mintGradeIndex = 0;    //年级序号
private mstrBeginYearMonth = "";    //开始年月
private mstrEndYearMonth = "";    //结束年月
private mbolAllowUpBaseInfo = false;    //允许修改基本信息
private mstrPrefix = "";    //前缀
private mstrPointCalcVersionId = "";    //绩点计算版本Id
private mstrModifyUserID = "";    //修改人
private mstrModifyDate = "";    //修改日期
private mstrid_StudyLevel = "";    //id_StudyLevel
private mbolIsVisible = false;    //是否显示
private mstrMemo = "";    //备注

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
 * 年级代号(说明:;字段类型:char;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetGradeBaseID (value: string)
{
if (value  != undefined)
{
 this.gradeBaseID = value;
    this.hmProperty["gradeBaseID"] = true;
}
}

/**
 * 年级名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetGradeBaseName (value: string)
{
if (value  != undefined)
{
 this.gradeBaseName = value;
    this.hmProperty["gradeBaseName"] = true;
}
}

/**
 * 年级名称缩写(说明:;字段类型:varchar;字段长度:10;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetGradeBaseNameA (value: string)
{
if (value  != undefined)
{
 this.gradeBaseNameA = value;
    this.hmProperty["gradeBaseNameA"] = true;
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
 * 进校日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetEnterSchoolDate (value: string)
{
if (value  != undefined)
{
 this.enterSchoolDate = value;
    this.hmProperty["enterSchoolDate"] = true;
}
}

/**
 * 当前学期(说明:;字段类型:int;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetCurrentTermSeq (value: number)
{
if (value  != undefined)
{
 this.currentTermSeq = value;
    this.hmProperty["currentTermSeq"] = true;
}
}

/**
 * 生成执行计划学期(说明:;字段类型:smallint;字段长度:2;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetExecPlanTermIndex (value: number)
{
if (value  != undefined)
{
 this.execPlanTermIndex = value;
    this.hmProperty["execPlanTermIndex"] = true;
}
}

/**
 * 设定执行计划学期日期(说明:;字段类型:char;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetSetEPTermIndexDate (value: string)
{
if (value  != undefined)
{
 this.setEPTermIndexDate = value;
    this.hmProperty["setEPTermIndexDate"] = true;
}
}

/**
 * 是否毕业(说明:;字段类型:bit;字段长度:1;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetIsOffed (value: boolean)
{
if (value  != undefined)
{
 this.isOffed = value;
    this.hmProperty["isOffed"] = true;
}
}

/**
 * 年级序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetGradeIndex (value: number)
{
if (value  != undefined)
{
 this.gradeIndex = value;
    this.hmProperty["gradeIndex"] = true;
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
 * 允许修改基本信息(说明:;字段类型:bit;字段长度:1;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetAllowUpBaseInfo (value: boolean)
{
if (value  != undefined)
{
 this.allowUpBaseInfo = value;
    this.hmProperty["allowUpBaseInfo"] = true;
}
}

/**
 * 前缀(说明:;字段类型:char;字段长度:3;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetPrefix (value: string)
{
if (value  != undefined)
{
 this.prefix = value;
    this.hmProperty["prefix"] = true;
}
}

/**
 * 绩点计算版本Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetPointCalcVersionId (value: string)
{
if (value  != undefined)
{
 this.pointCalcVersionId = value;
    this.hmProperty["pointCalcVersionId"] = true;
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
 * id_StudyLevel(说明:;字段类型:char;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setid_StudyLevel (value: string)
{
if (value  != undefined)
{
 this.id_StudyLevel = value;
    this.hmProperty["id_StudyLevel"] = true;
}
}

/**
 * 是否显示(说明:;字段类型:bit;字段长度:1;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetIsVisible (value: boolean)
{
if (value  != undefined)
{
 this.isVisible = value;
    this.hmProperty["isVisible"] = true;
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
case clsXzGradeBaseEN.con_id_GradeBase:
return this.id_GradeBase;
case clsXzGradeBaseEN.con_GradeBaseID:
return this.gradeBaseID;
case clsXzGradeBaseEN.con_GradeBaseName:
return this.gradeBaseName;
case clsXzGradeBaseEN.con_GradeBaseNameA:
return this.gradeBaseNameA;
case clsXzGradeBaseEN.con_SchoolYear:
return this.schoolYear;
case clsXzGradeBaseEN.con_SchoolTerm:
return this.schoolTerm;
case clsXzGradeBaseEN.con_EnterSchoolDate:
return this.enterSchoolDate;
case clsXzGradeBaseEN.con_CurrentTermSeq:
return this.currentTermSeq;
case clsXzGradeBaseEN.con_ExecPlanTermIndex:
return this.execPlanTermIndex;
case clsXzGradeBaseEN.con_SetEPTermIndexDate:
return this.setEPTermIndexDate;
case clsXzGradeBaseEN.con_IsOffed:
return this.isOffed;
case clsXzGradeBaseEN.con_GradeIndex:
return this.gradeIndex;
case clsXzGradeBaseEN.con_BeginYearMonth:
return this.beginYearMonth;
case clsXzGradeBaseEN.con_EndYearMonth:
return this.endYearMonth;
case clsXzGradeBaseEN.con_AllowUpBaseInfo:
return this.allowUpBaseInfo;
case clsXzGradeBaseEN.con_Prefix:
return this.prefix;
case clsXzGradeBaseEN.con_PointCalcVersionId:
return this.pointCalcVersionId;
case clsXzGradeBaseEN.con_ModifyUserID:
return this.modifyUserID;
case clsXzGradeBaseEN.con_ModifyDate:
return this.modifyDate;
case clsXzGradeBaseEN.con_id_StudyLevel:
return this.id_StudyLevel;
case clsXzGradeBaseEN.con_IsVisible:
return this.isVisible;
case clsXzGradeBaseEN.con_Memo:
return this.memo;
case "sf_UpdFldSetStr":
return this.sf_UpdFldSetStr;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[XzGradeBase]中不存在！`;
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
case clsXzGradeBaseEN.con_id_GradeBase:
this.id_GradeBase = strValue;
    this.hmProperty["id_GradeBase"] = true;
break;
case clsXzGradeBaseEN.con_GradeBaseID:
this.gradeBaseID = strValue;
    this.hmProperty["gradeBaseID"] = true;
break;
case clsXzGradeBaseEN.con_GradeBaseName:
this.gradeBaseName = strValue;
    this.hmProperty["gradeBaseName"] = true;
break;
case clsXzGradeBaseEN.con_GradeBaseNameA:
this.gradeBaseNameA = strValue;
    this.hmProperty["gradeBaseNameA"] = true;
break;
case clsXzGradeBaseEN.con_SchoolYear:
this.schoolYear = strValue;
    this.hmProperty["schoolYear"] = true;
break;
case clsXzGradeBaseEN.con_SchoolTerm:
this.schoolTerm = strValue;
    this.hmProperty["schoolTerm"] = true;
break;
case clsXzGradeBaseEN.con_EnterSchoolDate:
this.enterSchoolDate = strValue;
    this.hmProperty["enterSchoolDate"] = true;
break;
case clsXzGradeBaseEN.con_CurrentTermSeq:
this.currentTermSeq = Number(strValue);
    this.hmProperty["currentTermSeq"] = true;
break;
case clsXzGradeBaseEN.con_ExecPlanTermIndex:
this.execPlanTermIndex = Number(strValue);
    this.hmProperty["execPlanTermIndex"] = true;
break;
case clsXzGradeBaseEN.con_SetEPTermIndexDate:
this.setEPTermIndexDate = strValue;
    this.hmProperty["setEPTermIndexDate"] = true;
break;
case clsXzGradeBaseEN.con_IsOffed:
this.isOffed = Boolean(strValue);
    this.hmProperty["isOffed"] = true;
break;
case clsXzGradeBaseEN.con_GradeIndex:
this.gradeIndex = Number(strValue);
    this.hmProperty["gradeIndex"] = true;
break;
case clsXzGradeBaseEN.con_BeginYearMonth:
this.beginYearMonth = strValue;
    this.hmProperty["beginYearMonth"] = true;
break;
case clsXzGradeBaseEN.con_EndYearMonth:
this.endYearMonth = strValue;
    this.hmProperty["endYearMonth"] = true;
break;
case clsXzGradeBaseEN.con_AllowUpBaseInfo:
this.allowUpBaseInfo = Boolean(strValue);
    this.hmProperty["allowUpBaseInfo"] = true;
break;
case clsXzGradeBaseEN.con_Prefix:
this.prefix = strValue;
    this.hmProperty["prefix"] = true;
break;
case clsXzGradeBaseEN.con_PointCalcVersionId:
this.pointCalcVersionId = strValue;
    this.hmProperty["pointCalcVersionId"] = true;
break;
case clsXzGradeBaseEN.con_ModifyUserID:
this.modifyUserID = strValue;
    this.hmProperty["modifyUserID"] = true;
break;
case clsXzGradeBaseEN.con_ModifyDate:
this.modifyDate = strValue;
    this.hmProperty["modifyDate"] = true;
break;
case clsXzGradeBaseEN.con_id_StudyLevel:
this.id_StudyLevel = strValue;
    this.hmProperty["id_StudyLevel"] = true;
break;
case clsXzGradeBaseEN.con_IsVisible:
this.isVisible = Boolean(strValue);
    this.hmProperty["isVisible"] = true;
break;
case clsXzGradeBaseEN.con_Memo:
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
strMsg = `字段名:[${strFldName}]在表对象:[XzGradeBase]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
console.error(strMsg);
break;
}
}

/**
 * 设置对象中公共属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
*/
public id_GradeBase = "";    //年级流水号
public gradeBaseID = "";    //年级代号
public gradeBaseName = "";    //年级名称
public gradeBaseNameA = "";    //年级名称缩写
public schoolYear = "";    //学年
public schoolTerm = "";    //学期
public enterSchoolDate = "";    //进校日期
public currentTermSeq = 0;    //当前学期
public execPlanTermIndex = 0;    //生成执行计划学期
public setEPTermIndexDate = "";    //设定执行计划学期日期
public isOffed = false;    //是否毕业
public gradeIndex = 0;    //年级序号
public beginYearMonth = "";    //开始年月
public endYearMonth = "";    //结束年月
public allowUpBaseInfo = false;    //允许修改基本信息
public prefix = "";    //前缀
public pointCalcVersionId = "";    //绩点计算版本Id
public modifyUserID = "";    //修改人
public modifyDate = "";    //修改日期
public id_StudyLevel = "";    //id_StudyLevel
public isVisible = false;    //是否显示
public memo = "";    //备注


 /**
 * 常量:"id_GradeBase"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_GradeBase(): string {return "id_GradeBase";}    //年级流水号

 /**
 * 常量:"GradeBaseID"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_GradeBaseID(): string {return "gradeBaseID";}    //年级代号

 /**
 * 常量:"GradeBaseName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_GradeBaseName(): string {return "gradeBaseName";}    //年级名称

 /**
 * 常量:"GradeBaseNameA"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_GradeBaseNameA(): string {return "gradeBaseNameA";}    //年级名称缩写

 /**
 * 常量:"SchoolYear"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SchoolYear(): string {return "schoolYear";}    //学年

 /**
 * 常量:"SchoolTerm"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SchoolTerm(): string {return "schoolTerm";}    //学期

 /**
 * 常量:"EnterSchoolDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_EnterSchoolDate(): string {return "enterSchoolDate";}    //进校日期

 /**
 * 常量:"CurrentTermSeq"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CurrentTermSeq(): string {return "currentTermSeq";}    //当前学期

 /**
 * 常量:"ExecPlanTermIndex"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ExecPlanTermIndex(): string {return "execPlanTermIndex";}    //生成执行计划学期

 /**
 * 常量:"SetEPTermIndexDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SetEPTermIndexDate(): string {return "setEPTermIndexDate";}    //设定执行计划学期日期

 /**
 * 常量:"IsOffed"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsOffed(): string {return "isOffed";}    //是否毕业

 /**
 * 常量:"GradeIndex"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_GradeIndex(): string {return "gradeIndex";}    //年级序号

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
 * 常量:"AllowUpBaseInfo"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_AllowUpBaseInfo(): string {return "allowUpBaseInfo";}    //允许修改基本信息

 /**
 * 常量:"Prefix"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Prefix(): string {return "prefix";}    //前缀

 /**
 * 常量:"PointCalcVersionId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PointCalcVersionId(): string {return "pointCalcVersionId";}    //绩点计算版本Id

 /**
 * 常量:"ModifyUserID"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ModifyUserID(): string {return "modifyUserID";}    //修改人

 /**
 * 常量:"ModifyDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ModifyDate(): string {return "modifyDate";}    //修改日期

 /**
 * 常量:"id_StudyLevel"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_StudyLevel(): string {return "id_StudyLevel";}    //id_StudyLevel

 /**
 * 常量:"IsVisible"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsVisible(): string {return "isVisible";}    //是否显示

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