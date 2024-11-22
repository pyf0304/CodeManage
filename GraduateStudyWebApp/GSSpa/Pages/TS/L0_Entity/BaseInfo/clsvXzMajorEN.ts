
 /**
 * 类名:clsvXzMajorEN
 * 表名:vXzMajor(01120066)
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
 * v专业(vXzMajor)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTabV } from '../../PubFun/clsGeneralTabV.js';

export class clsvXzMajorEN extends clsGeneralTabV
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "02"; //客户端缓存
public static _CurrTabName= "vXzMajor"; //当前表名,与该类相关的表名
public static _KeyFldName= "id_XzMajor"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 24;
public static AttributeName = ["id_XzMajor", "majorID", "majorName", "majorEnglishName", "majorExplain", "majorNationalID", "id_XzCollege", "collegeID", "collegeName", "collegeNameA", "id_MajorType", "majorTypeName", "id_DegreeType", "xwTypeDesc", "isMainMajor", "majorDirection", "isVisible", "isNormal", "modifyDate", "modifyUserID", "memo", "isVisible4XzClg", "typeName", "id_XzMajorShoolType"];
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
case clsvXzMajorEN.con_id_XzMajor:
return this.id_XzMajor;
case clsvXzMajorEN.con_MajorID:
return this.majorID;
case clsvXzMajorEN.con_MajorName:
return this.majorName;
case clsvXzMajorEN.con_MajorEnglishName:
return this.majorEnglishName;
case clsvXzMajorEN.con_MajorExplain:
return this.majorExplain;
case clsvXzMajorEN.con_MajorNationalID:
return this.majorNationalID;
case clsvXzMajorEN.con_id_XzCollege:
return this.id_XzCollege;
case clsvXzMajorEN.con_CollegeID:
return this.collegeID;
case clsvXzMajorEN.con_CollegeName:
return this.collegeName;
case clsvXzMajorEN.con_CollegeNameA:
return this.collegeNameA;
case clsvXzMajorEN.con_id_MajorType:
return this.id_MajorType;
case clsvXzMajorEN.con_MajorTypeName:
return this.majorTypeName;
case clsvXzMajorEN.con_id_DegreeType:
return this.id_DegreeType;
case clsvXzMajorEN.con_XwTypeDesc:
return this.xwTypeDesc;
case clsvXzMajorEN.con_IsMainMajor:
return this.isMainMajor;
case clsvXzMajorEN.con_MajorDirection:
return this.majorDirection;
case clsvXzMajorEN.con_IsVisible:
return this.isVisible;
case clsvXzMajorEN.con_IsNormal:
return this.isNormal;
case clsvXzMajorEN.con_ModifyDate:
return this.modifyDate;
case clsvXzMajorEN.con_ModifyUserID:
return this.modifyUserID;
case clsvXzMajorEN.con_Memo:
return this.memo;
case clsvXzMajorEN.con_IsVisible4XzClg:
return this.isVisible4XzClg;
case clsvXzMajorEN.con_TypeName:
return this.typeName;
case clsvXzMajorEN.con_id_XzMajorShoolType:
return this.id_XzMajorShoolType;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[vXzMajor]中不存在！`;
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
case clsvXzMajorEN.con_id_XzMajor:
this.id_XzMajor = strValue;
break;
case clsvXzMajorEN.con_MajorID:
this.majorID = strValue;
break;
case clsvXzMajorEN.con_MajorName:
this.majorName = strValue;
break;
case clsvXzMajorEN.con_MajorEnglishName:
this.majorEnglishName = strValue;
break;
case clsvXzMajorEN.con_MajorExplain:
this.majorExplain = strValue;
break;
case clsvXzMajorEN.con_MajorNationalID:
this.majorNationalID = strValue;
break;
case clsvXzMajorEN.con_id_XzCollege:
this.id_XzCollege = strValue;
break;
case clsvXzMajorEN.con_CollegeID:
this.collegeID = strValue;
break;
case clsvXzMajorEN.con_CollegeName:
this.collegeName = strValue;
break;
case clsvXzMajorEN.con_CollegeNameA:
this.collegeNameA = strValue;
break;
case clsvXzMajorEN.con_id_MajorType:
this.id_MajorType = strValue;
break;
case clsvXzMajorEN.con_MajorTypeName:
this.majorTypeName = strValue;
break;
case clsvXzMajorEN.con_id_DegreeType:
this.id_DegreeType = strValue;
break;
case clsvXzMajorEN.con_XwTypeDesc:
this.xwTypeDesc = strValue;
break;
case clsvXzMajorEN.con_IsMainMajor:
this.isMainMajor = Boolean(strValue);
break;
case clsvXzMajorEN.con_MajorDirection:
this.majorDirection = strValue;
break;
case clsvXzMajorEN.con_IsVisible:
this.isVisible = Boolean(strValue);
break;
case clsvXzMajorEN.con_IsNormal:
this.isNormal = Boolean(strValue);
break;
case clsvXzMajorEN.con_ModifyDate:
this.modifyDate = strValue;
break;
case clsvXzMajorEN.con_ModifyUserID:
this.modifyUserID = strValue;
break;
case clsvXzMajorEN.con_Memo:
this.memo = strValue;
break;
case clsvXzMajorEN.con_IsVisible4XzClg:
this.isVisible4XzClg = Boolean(strValue);
break;
case clsvXzMajorEN.con_TypeName:
this.typeName = strValue;
break;
case clsvXzMajorEN.con_id_XzMajorShoolType:
this.id_XzMajorShoolType = strValue;
break;
case "sf_FldComparisonOp":
this.sf_FldComparisonOp = strValue;
break;
default:
strMsg = `字段名:[${strFldName}]在表对象:[vXzMajor]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
console.error(strMsg);
break;
}
}

/**
 * 设置对象中公共属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
*/
public id_XzMajor = "";    //专业流水号
public majorID = "";    //专业ID
public majorName = "";    //专业名称
public majorEnglishName = "";    //专业英文名称
public majorExplain = "";    //专业说明
public majorNationalID = "";    //专业国家代码
public id_XzCollege = "";    //学院流水号
public collegeID = "";    //学院ID
public collegeName = "";    //学院名称
public collegeNameA = "";    //学院名称简写
public id_MajorType = "";    //专业类型(文理工)流水号
public majorTypeName = "";    //专业类型名称
public id_DegreeType = "";    //学位类型流水号
public xwTypeDesc = "";    //学位类型名称
public isMainMajor = false;    //是否重要专业
public majorDirection = "";    //专业方向
public isVisible = false;    //是否显示
public isNormal = false;    //IsNormal
public modifyDate = "";    //修改日期
public modifyUserID = "";    //修改人
public memo = "";    //备注
public isVisible4XzClg = false;    //IsVisible4XzClg
public typeName = "";    //类型名称
public id_XzMajorShoolType = "";    //专业学校类型流水号


 /**
 * 常量:"id_XzMajor"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_XzMajor(): string {return "id_XzMajor";}    //专业流水号

 /**
 * 常量:"MajorID"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_MajorID(): string {return "majorID";}    //专业ID

 /**
 * 常量:"MajorName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_MajorName(): string {return "majorName";}    //专业名称

 /**
 * 常量:"MajorEnglishName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_MajorEnglishName(): string {return "majorEnglishName";}    //专业英文名称

 /**
 * 常量:"MajorExplain"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_MajorExplain(): string {return "majorExplain";}    //专业说明

 /**
 * 常量:"MajorNationalID"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_MajorNationalID(): string {return "majorNationalID";}    //专业国家代码

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
 * 常量:"CollegeNameA"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CollegeNameA(): string {return "collegeNameA";}    //学院名称简写

 /**
 * 常量:"id_MajorType"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_MajorType(): string {return "id_MajorType";}    //专业类型(文理工)流水号

 /**
 * 常量:"MajorTypeName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_MajorTypeName(): string {return "majorTypeName";}    //专业类型名称

 /**
 * 常量:"id_DegreeType"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_DegreeType(): string {return "id_DegreeType";}    //学位类型流水号

 /**
 * 常量:"XwTypeDesc"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_XwTypeDesc(): string {return "xwTypeDesc";}    //学位类型名称

 /**
 * 常量:"IsMainMajor"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsMainMajor(): string {return "isMainMajor";}    //是否重要专业

 /**
 * 常量:"MajorDirection"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_MajorDirection(): string {return "majorDirection";}    //专业方向

 /**
 * 常量:"IsVisible"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsVisible(): string {return "isVisible";}    //是否显示

 /**
 * 常量:"IsNormal"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsNormal(): string {return "isNormal";}    //IsNormal

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
 * 常量:"IsVisible4XzClg"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsVisible4XzClg(): string {return "isVisible4XzClg";}    //IsVisible4XzClg

 /**
 * 常量:"TypeName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_TypeName(): string {return "typeName";}    //类型名称

 /**
 * 常量:"id_XzMajorShoolType"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_XzMajorShoolType(): string {return "id_XzMajorShoolType";}    //专业学校类型流水号

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