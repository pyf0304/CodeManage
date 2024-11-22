
 /**
 * 类名:clsvXzClgEN
 * 表名:vXzClg(01120139)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 12:02:25
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
 * v学院(vXzClg)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTabV } from '../../PubFun/clsGeneralTabV.js';

export class clsvXzClgEN extends clsGeneralTabV
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "05"; //未知
public static _CurrTabName= "vXzClg"; //当前表名,与该类相关的表名
public static _KeyFldName= "id_XzCollege"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 19;
public static AttributeName = ["id_XzCollege", "collegeID", "collegeName", "collegeIdInGP", "clgEnglishName", "collegeNameA", "phoneNumber", "webSite", "id_School", "schoolId", "schoolName", "schoolNameA", "id_Uni", "isVisible", "orderNum", "modifyDate", "modifyUserID", "memo", "majorNum"];
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
case clsvXzClgEN.con_id_XzCollege:
return this.id_XzCollege;
case clsvXzClgEN.con_CollegeID:
return this.collegeID;
case clsvXzClgEN.con_CollegeName:
return this.collegeName;
case clsvXzClgEN.con_CollegeIdInGP:
return this.collegeIdInGP;
case clsvXzClgEN.con_ClgEnglishName:
return this.clgEnglishName;
case clsvXzClgEN.con_CollegeNameA:
return this.collegeNameA;
case clsvXzClgEN.con_PhoneNumber:
return this.phoneNumber;
case clsvXzClgEN.con_WebSite:
return this.webSite;
case clsvXzClgEN.con_id_School:
return this.id_School;
case clsvXzClgEN.con_SchoolId:
return this.schoolId;
case clsvXzClgEN.con_SchoolName:
return this.schoolName;
case clsvXzClgEN.con_SchoolNameA:
return this.schoolNameA;
case clsvXzClgEN.con_id_Uni:
return this.id_Uni;
case clsvXzClgEN.con_IsVisible:
return this.isVisible;
case clsvXzClgEN.con_OrderNum:
return this.orderNum;
case clsvXzClgEN.con_ModifyDate:
return this.modifyDate;
case clsvXzClgEN.con_ModifyUserID:
return this.modifyUserID;
case clsvXzClgEN.con_Memo:
return this.memo;
case clsvXzClgEN.con_MajorNum:
return this.majorNum;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[vXzClg]中不存在！`;
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
case clsvXzClgEN.con_id_XzCollege:
this.id_XzCollege = strValue;
break;
case clsvXzClgEN.con_CollegeID:
this.collegeID = strValue;
break;
case clsvXzClgEN.con_CollegeName:
this.collegeName = strValue;
break;
case clsvXzClgEN.con_CollegeIdInGP:
this.collegeIdInGP = strValue;
break;
case clsvXzClgEN.con_ClgEnglishName:
this.clgEnglishName = strValue;
break;
case clsvXzClgEN.con_CollegeNameA:
this.collegeNameA = strValue;
break;
case clsvXzClgEN.con_PhoneNumber:
this.phoneNumber = strValue;
break;
case clsvXzClgEN.con_WebSite:
this.webSite = strValue;
break;
case clsvXzClgEN.con_id_School:
this.id_School = strValue;
break;
case clsvXzClgEN.con_SchoolId:
this.schoolId = strValue;
break;
case clsvXzClgEN.con_SchoolName:
this.schoolName = strValue;
break;
case clsvXzClgEN.con_SchoolNameA:
this.schoolNameA = strValue;
break;
case clsvXzClgEN.con_id_Uni:
this.id_Uni = strValue;
break;
case clsvXzClgEN.con_IsVisible:
this.isVisible = Boolean(strValue);
break;
case clsvXzClgEN.con_OrderNum:
this.orderNum = Number(strValue);
break;
case clsvXzClgEN.con_ModifyDate:
this.modifyDate = strValue;
break;
case clsvXzClgEN.con_ModifyUserID:
this.modifyUserID = strValue;
break;
case clsvXzClgEN.con_Memo:
this.memo = strValue;
break;
case clsvXzClgEN.con_MajorNum:
this.majorNum = Number(strValue);
break;
case "sf_FldComparisonOp":
this.sf_FldComparisonOp = strValue;
break;
default:
strMsg = `字段名:[${strFldName}]在表对象:[vXzClg]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
console.error(strMsg);
break;
}
}

/**
 * 设置对象中公共属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
*/
public id_XzCollege = "";    //学院流水号
public collegeID = "";    //学院ID
public collegeName = "";    //学院名称
public collegeIdInGP = "";    //CollegeIdInGP
public clgEnglishName = "";    //ClgEnglishName
public collegeNameA = "";    //学院名称简写
public phoneNumber = "";    //PhoneNumber
public webSite = "";    //个人主页
public id_School = "";    //学校流水号
public schoolId = "";    //学校编号
public schoolName = "";    //学校名称
public schoolNameA = "";    //学校简称
public id_Uni = "";    //id_Uni
public isVisible = false;    //是否显示
public orderNum = 0;    //序号
public modifyDate = "";    //修改日期
public modifyUserID = "";    //修改人
public memo = "";    //备注
public majorNum = 0;    //MajorNum


 /**
 * 常量:"id_XzCollege"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_XzCollege(): string {return "id_XzCollege";}    //学院流水号

 /**
 * 常量:"CollegeID"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CollegeID(): string {return "collegeID";}    //学院ID

 /**
 * 常量:"CollegeName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CollegeName(): string {return "collegeName";}    //学院名称

 /**
 * 常量:"CollegeIdInGP"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CollegeIdInGP(): string {return "collegeIdInGP";}    //CollegeIdInGP

 /**
 * 常量:"ClgEnglishName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ClgEnglishName(): string {return "clgEnglishName";}    //ClgEnglishName

 /**
 * 常量:"CollegeNameA"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CollegeNameA(): string {return "collegeNameA";}    //学院名称简写

 /**
 * 常量:"PhoneNumber"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PhoneNumber(): string {return "phoneNumber";}    //PhoneNumber

 /**
 * 常量:"WebSite"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_WebSite(): string {return "webSite";}    //个人主页

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
 * 常量:"SchoolNameA"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SchoolNameA(): string {return "schoolNameA";}    //学校简称

 /**
 * 常量:"id_Uni"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_Uni(): string {return "id_Uni";}    //id_Uni

 /**
 * 常量:"IsVisible"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsVisible(): string {return "isVisible";}    //是否显示

 /**
 * 常量:"OrderNum"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_OrderNum(): string {return "orderNum";}    //序号

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
 * 常量:"MajorNum"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_MajorNum(): string {return "majorNum";}    //MajorNum

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