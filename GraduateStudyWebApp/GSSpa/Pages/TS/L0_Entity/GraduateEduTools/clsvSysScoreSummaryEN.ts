
 /**
 * 类名:clsvSysScoreSummaryEN
 * 表名:vSysScoreSummary(01120627)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 12:02:59
 * 生成者:pyf
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:研培设置(GraduateEduTools)
 * 框架-层名:实体层(TS)(EntityLayer)
 * 编程语言:TypeScript
 **/
 /**
 * v分数汇总视图(vSysScoreSummary)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTabV } from '../../PubFun/clsGeneralTabV.js';

export class clsvSysScoreSummaryEN extends clsGeneralTabV
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "02"; //客户端缓存
public static _CurrTabName= "vSysScoreSummary"; //当前表名,与该类相关的表名
public static _KeyFldName= "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 20;
public static AttributeName = ["mId", "userId", "schoolYear", "updDate", "memo", "userName", "id_XzCollege", "collegeName", "id_XzMajor", "majorName", "id_GradeBase", "gradeBaseName", "onlyId", "scoreTypeId", "scoreTypeName", "updUser", "score", "id_CurrEduCls", "eduClsName", "isSubmit"];
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
case clsvSysScoreSummaryEN.con_mId:
return this.mId;
case clsvSysScoreSummaryEN.con_UserId:
return this.userId;
case clsvSysScoreSummaryEN.con_SchoolYear:
return this.schoolYear;
case clsvSysScoreSummaryEN.con_UpdDate:
return this.updDate;
case clsvSysScoreSummaryEN.con_Memo:
return this.memo;
case clsvSysScoreSummaryEN.con_UserName:
return this.userName;
case clsvSysScoreSummaryEN.con_id_XzCollege:
return this.id_XzCollege;
case clsvSysScoreSummaryEN.con_CollegeName:
return this.collegeName;
case clsvSysScoreSummaryEN.con_id_XzMajor:
return this.id_XzMajor;
case clsvSysScoreSummaryEN.con_MajorName:
return this.majorName;
case clsvSysScoreSummaryEN.con_id_GradeBase:
return this.id_GradeBase;
case clsvSysScoreSummaryEN.con_GradeBaseName:
return this.gradeBaseName;
case clsvSysScoreSummaryEN.con_OnlyId:
return this.onlyId;
case clsvSysScoreSummaryEN.con_ScoreTypeId:
return this.scoreTypeId;
case clsvSysScoreSummaryEN.con_ScoreTypeName:
return this.scoreTypeName;
case clsvSysScoreSummaryEN.con_UpdUser:
return this.updUser;
case clsvSysScoreSummaryEN.con_score:
return this.score;
case clsvSysScoreSummaryEN.con_id_CurrEduCls:
return this.id_CurrEduCls;
case clsvSysScoreSummaryEN.con_EduClsName:
return this.eduClsName;
case clsvSysScoreSummaryEN.con_IsSubmit:
return this.isSubmit;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[vSysScoreSummary]中不存在！`;
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
case clsvSysScoreSummaryEN.con_mId:
this.mId = Number(strValue);
break;
case clsvSysScoreSummaryEN.con_UserId:
this.userId = strValue;
break;
case clsvSysScoreSummaryEN.con_SchoolYear:
this.schoolYear = strValue;
break;
case clsvSysScoreSummaryEN.con_UpdDate:
this.updDate = strValue;
break;
case clsvSysScoreSummaryEN.con_Memo:
this.memo = strValue;
break;
case clsvSysScoreSummaryEN.con_UserName:
this.userName = strValue;
break;
case clsvSysScoreSummaryEN.con_id_XzCollege:
this.id_XzCollege = strValue;
break;
case clsvSysScoreSummaryEN.con_CollegeName:
this.collegeName = strValue;
break;
case clsvSysScoreSummaryEN.con_id_XzMajor:
this.id_XzMajor = strValue;
break;
case clsvSysScoreSummaryEN.con_MajorName:
this.majorName = strValue;
break;
case clsvSysScoreSummaryEN.con_id_GradeBase:
this.id_GradeBase = strValue;
break;
case clsvSysScoreSummaryEN.con_GradeBaseName:
this.gradeBaseName = strValue;
break;
case clsvSysScoreSummaryEN.con_OnlyId:
this.onlyId = strValue;
break;
case clsvSysScoreSummaryEN.con_ScoreTypeId:
this.scoreTypeId = strValue;
break;
case clsvSysScoreSummaryEN.con_ScoreTypeName:
this.scoreTypeName = strValue;
break;
case clsvSysScoreSummaryEN.con_UpdUser:
this.updUser = strValue;
break;
case clsvSysScoreSummaryEN.con_score:
this.score = Number(strValue);
break;
case clsvSysScoreSummaryEN.con_id_CurrEduCls:
this.id_CurrEduCls = strValue;
break;
case clsvSysScoreSummaryEN.con_EduClsName:
this.eduClsName = strValue;
break;
case clsvSysScoreSummaryEN.con_IsSubmit:
this.isSubmit = Boolean(strValue);
break;
case "sf_FldComparisonOp":
this.sf_FldComparisonOp = strValue;
break;
default:
strMsg = `字段名:[${strFldName}]在表对象:[vSysScoreSummary]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
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
public schoolYear = "";    //学年
public updDate = "";    //修改日期
public memo = "";    //备注
public userName = "";    //用户名
public id_XzCollege = "";    //学院流水号
public collegeName = "";    //学院名称
public id_XzMajor = "";    //专业流水号
public majorName = "";    //专业名称
public id_GradeBase = "";    //年级流水号
public gradeBaseName = "";    //年级名称
public onlyId = "";    //OnlyId
public scoreTypeId = "";    //分数类型Id
public scoreTypeName = "";    //分数类型名称
public updUser = "";    //修改人
public score = 0.0;    //评分
public id_CurrEduCls = "";    //教学班流水号
public eduClsName = "";    //教学班名
public isSubmit = false;    //是否提交


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
 * 常量:"SchoolYear"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SchoolYear(): string {return "schoolYear";}    //学年

 /**
 * 常量:"UpdDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UpdDate(): string {return "updDate";}    //修改日期

 /**
 * 常量:"Memo"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Memo(): string {return "memo";}    //备注

 /**
 * 常量:"UserName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UserName(): string {return "userName";}    //用户名

 /**
 * 常量:"id_XzCollege"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_XzCollege(): string {return "id_XzCollege";}    //学院流水号

 /**
 * 常量:"CollegeName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CollegeName(): string {return "collegeName";}    //学院名称

 /**
 * 常量:"id_XzMajor"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_XzMajor(): string {return "id_XzMajor";}    //专业流水号

 /**
 * 常量:"MajorName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_MajorName(): string {return "majorName";}    //专业名称

 /**
 * 常量:"id_GradeBase"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_GradeBase(): string {return "id_GradeBase";}    //年级流水号

 /**
 * 常量:"GradeBaseName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_GradeBaseName(): string {return "gradeBaseName";}    //年级名称

 /**
 * 常量:"OnlyId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_OnlyId(): string {return "onlyId";}    //OnlyId

 /**
 * 常量:"ScoreTypeId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ScoreTypeId(): string {return "scoreTypeId";}    //分数类型Id

 /**
 * 常量:"ScoreTypeName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ScoreTypeName(): string {return "scoreTypeName";}    //分数类型名称

 /**
 * 常量:"UpdUser"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UpdUser(): string {return "updUser";}    //修改人

 /**
 * 常量:"score"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_score(): string {return "score";}    //评分

 /**
 * 常量:"id_CurrEduCls"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_CurrEduCls(): string {return "id_CurrEduCls";}    //教学班流水号

 /**
 * 常量:"EduClsName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_EduClsName(): string {return "eduClsName";}    //教学班名

 /**
 * 常量:"IsSubmit"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsSubmit(): string {return "isSubmit";}    //是否提交

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