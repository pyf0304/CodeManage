
 /**
 * 类名:clsvcc_CourseTypeEN
 * 表名:vcc_CourseType(01120059)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 12:02:23
 * 生成者:pyf
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
 * 框架-层名:实体层(TS)(EntityLayer)
 * 编程语言:TypeScript
 **/
 /**
 * v课程类型(vcc_CourseType)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTabV } from '../../PubFun/clsGeneralTabV.js';

export class clsvcc_CourseTypeEN extends clsGeneralTabV
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "05"; //未知
public static _CurrTabName= "vcc_CourseType"; //当前表名,与该类相关的表名
public static _KeyFldName= "CourseTypeID"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 9;
public static AttributeName = ["courseTypeID", "courseTypeName", "id_School", "schoolId", "schoolName", "isUse", "updDate", "updUserId", "memo"];
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
case clsvcc_CourseTypeEN.con_CourseTypeID:
return this.courseTypeID;
case clsvcc_CourseTypeEN.con_CourseTypeName:
return this.courseTypeName;
case clsvcc_CourseTypeEN.con_id_School:
return this.id_School;
case clsvcc_CourseTypeEN.con_SchoolId:
return this.schoolId;
case clsvcc_CourseTypeEN.con_SchoolName:
return this.schoolName;
case clsvcc_CourseTypeEN.con_IsUse:
return this.isUse;
case clsvcc_CourseTypeEN.con_UpdDate:
return this.updDate;
case clsvcc_CourseTypeEN.con_UpdUserId:
return this.updUserId;
case clsvcc_CourseTypeEN.con_Memo:
return this.memo;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[vcc_CourseType]中不存在！`;
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
case clsvcc_CourseTypeEN.con_CourseTypeID:
this.courseTypeID = strValue;
break;
case clsvcc_CourseTypeEN.con_CourseTypeName:
this.courseTypeName = strValue;
break;
case clsvcc_CourseTypeEN.con_id_School:
this.id_School = strValue;
break;
case clsvcc_CourseTypeEN.con_SchoolId:
this.schoolId = strValue;
break;
case clsvcc_CourseTypeEN.con_SchoolName:
this.schoolName = strValue;
break;
case clsvcc_CourseTypeEN.con_IsUse:
this.isUse = Boolean(strValue);
break;
case clsvcc_CourseTypeEN.con_UpdDate:
this.updDate = strValue;
break;
case clsvcc_CourseTypeEN.con_UpdUserId:
this.updUserId = strValue;
break;
case clsvcc_CourseTypeEN.con_Memo:
this.memo = strValue;
break;
case "sf_FldComparisonOp":
this.sf_FldComparisonOp = strValue;
break;
default:
strMsg = `字段名:[${strFldName}]在表对象:[vcc_CourseType]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
console.error(strMsg);
break;
}
}

/**
 * 设置对象中公共属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
*/
public courseTypeID = "";    //课程类型ID
public courseTypeName = "";    //课程类型名称
public id_School = "";    //学校流水号
public schoolId = "";    //学校编号
public schoolName = "";    //学校名称
public isUse = false;    //是否使用
public updDate = "";    //修改日期
public updUserId = "";    //修改用户Id
public memo = "";    //备注


 /**
 * 常量:"CourseTypeID"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CourseTypeID(): string {return "courseTypeID";}    //课程类型ID

 /**
 * 常量:"CourseTypeName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CourseTypeName(): string {return "courseTypeName";}    //课程类型名称

 /**
 * 常量:"id_School"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_School(): string {return "id_School";}    //学校流水号

 /**
 * 常量:"SchoolId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SchoolId(): string {return "schoolId";}    //学校编号

 /**
 * 常量:"SchoolName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SchoolName(): string {return "schoolName";}    //学校名称

 /**
 * 常量:"IsUse"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsUse(): string {return "isUse";}    //是否使用

 /**
 * 常量:"UpdDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UpdDate(): string {return "updDate";}    //修改日期

 /**
 * 常量:"UpdUserId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UpdUserId(): string {return "updUserId";}    //修改用户Id

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