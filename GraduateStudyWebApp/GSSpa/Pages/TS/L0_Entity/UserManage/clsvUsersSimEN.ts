
 /**
 * 类名:clsvUsersSimEN
 * 表名:vUsersSim(01120699)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 12:02:22
 * 生成者:pyf
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:用户管理(UserManage)
 * 框架-层名:实体层(TS)(EntityLayer)
 * 编程语言:TypeScript
 **/
 /**
 * vUsersSim(vUsersSim)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTabV } from '../../PubFun/clsGeneralTabV.js';

export class clsvUsersSimEN extends clsGeneralTabV
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "03"; //localStorage
public static _CurrTabName= "vUsersSim"; //当前表名,与该类相关的表名
public static _KeyFldName= "UserId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 8;
public static AttributeName = ["userId", "userName", "isGSuser", "collegeName", "id_XzCollege", "id_XzMajor", "majorName", "headPic"];
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
case clsvUsersSimEN.con_UserId:
return this.userId;
case clsvUsersSimEN.con_UserName:
return this.userName;
case clsvUsersSimEN.con_IsGSuser:
return this.isGSuser;
case clsvUsersSimEN.con_CollegeName:
return this.collegeName;
case clsvUsersSimEN.con_id_XzCollege:
return this.id_XzCollege;
case clsvUsersSimEN.con_id_XzMajor:
return this.id_XzMajor;
case clsvUsersSimEN.con_MajorName:
return this.majorName;
case clsvUsersSimEN.con_HeadPic:
return this.headPic;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[vUsersSim]中不存在！`;
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
case clsvUsersSimEN.con_UserId:
this.userId = strValue;
break;
case clsvUsersSimEN.con_UserName:
this.userName = strValue;
break;
case clsvUsersSimEN.con_IsGSuser:
this.isGSuser = Boolean(strValue);
break;
case clsvUsersSimEN.con_CollegeName:
this.collegeName = strValue;
break;
case clsvUsersSimEN.con_id_XzCollege:
this.id_XzCollege = strValue;
break;
case clsvUsersSimEN.con_id_XzMajor:
this.id_XzMajor = strValue;
break;
case clsvUsersSimEN.con_MajorName:
this.majorName = strValue;
break;
case clsvUsersSimEN.con_HeadPic:
this.headPic = strValue;
break;
case "sf_FldComparisonOp":
this.sf_FldComparisonOp = strValue;
break;
default:
strMsg = `字段名:[${strFldName}]在表对象:[vUsersSim]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
console.error(strMsg);
break;
}
}

/**
 * 设置对象中公共属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
*/
public userId = "";    //用户ID
public userName = "";    //用户名
public isGSuser = false;    //是否GS用户
public collegeName = "";    //学院名称
public id_XzCollege = "";    //学院流水号
public id_XzMajor = "";    //专业流水号
public majorName = "";    //专业名称
public headPic = "";    //头像


 /**
 * 常量:"UserId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UserId(): string {return "userId";}    //用户ID

 /**
 * 常量:"UserName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UserName(): string {return "userName";}    //用户名

 /**
 * 常量:"IsGSuser"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsGSuser(): string {return "isGSuser";}    //是否GS用户

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
 * 常量:"HeadPic"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_HeadPic(): string {return "headPic";}    //头像

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