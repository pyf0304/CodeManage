
 /**
 * 类名:clsvke_SubEN
 * 表名:vke_Sub(01120659)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:47:07
 * 生成者:pyf
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:研培主题(GraduateEduTopic)
 * 框架-层名:实体层(TS)(EntityLayer)
 * 编程语言:TypeScript
 **/
 /**
 * 知识经济子类视图(vke_Sub)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTabV } from '../../PubFun/clsGeneralTabV.js';

export class clsvke_SubEN extends clsGeneralTabV
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "04"; //sessionStorage
public static IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
public static WhereFormat = ""; //条件格式串
public static _CurrTabName= "vke_Sub"; //当前表名,与该类相关的表名
public static _KeyFldName= "ke_SubId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 14;
public static AttributeName = ["ke_SubId", "ke_SuperId", "ke_SuperName_cn", "ke_SuperName_en", "ke_SubName_cn", "ke_SubName_en", "ke_SuperDescribe_cn", "ke_SubDescribe_cn", "ke_SuperDescribe_en", "ke_SubDescribe_en", "updDate", "updUser", "memo", "link"];
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
case clsvke_SubEN.con_ke_SubId:
return this.ke_SubId;
case clsvke_SubEN.con_ke_SuperId:
return this.ke_SuperId;
case clsvke_SubEN.con_ke_SuperName_cn:
return this.ke_SuperName_cn;
case clsvke_SubEN.con_ke_SuperName_en:
return this.ke_SuperName_en;
case clsvke_SubEN.con_ke_SubName_cn:
return this.ke_SubName_cn;
case clsvke_SubEN.con_ke_SubName_en:
return this.ke_SubName_en;
case clsvke_SubEN.con_ke_SuperDescribe_cn:
return this.ke_SuperDescribe_cn;
case clsvke_SubEN.con_ke_SubDescribe_cn:
return this.ke_SubDescribe_cn;
case clsvke_SubEN.con_ke_SuperDescribe_en:
return this.ke_SuperDescribe_en;
case clsvke_SubEN.con_ke_SubDescribe_en:
return this.ke_SubDescribe_en;
case clsvke_SubEN.con_UpdDate:
return this.updDate;
case clsvke_SubEN.con_UpdUser:
return this.updUser;
case clsvke_SubEN.con_Memo:
return this.memo;
case clsvke_SubEN.con_Link:
return this.link;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[vke_Sub]中不存在！`;
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
case clsvke_SubEN.con_ke_SubId:
this.ke_SubId = strValue;
break;
case clsvke_SubEN.con_ke_SuperId:
this.ke_SuperId = strValue;
break;
case clsvke_SubEN.con_ke_SuperName_cn:
this.ke_SuperName_cn = strValue;
break;
case clsvke_SubEN.con_ke_SuperName_en:
this.ke_SuperName_en = strValue;
break;
case clsvke_SubEN.con_ke_SubName_cn:
this.ke_SubName_cn = strValue;
break;
case clsvke_SubEN.con_ke_SubName_en:
this.ke_SubName_en = strValue;
break;
case clsvke_SubEN.con_ke_SuperDescribe_cn:
this.ke_SuperDescribe_cn = strValue;
break;
case clsvke_SubEN.con_ke_SubDescribe_cn:
this.ke_SubDescribe_cn = strValue;
break;
case clsvke_SubEN.con_ke_SuperDescribe_en:
this.ke_SuperDescribe_en = strValue;
break;
case clsvke_SubEN.con_ke_SubDescribe_en:
this.ke_SubDescribe_en = strValue;
break;
case clsvke_SubEN.con_UpdDate:
this.updDate = strValue;
break;
case clsvke_SubEN.con_UpdUser:
this.updUser = strValue;
break;
case clsvke_SubEN.con_Memo:
this.memo = strValue;
break;
case clsvke_SubEN.con_Link:
this.link = strValue;
break;
case "sf_FldComparisonOp":
this.sf_FldComparisonOp = strValue;
break;
default:
strMsg = `字段名:[${strFldName}]在表对象:[vke_Sub]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
console.error(strMsg);
break;
}
}

/**
 * 设置对象中公共属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
*/
public ke_SubId = "";    //知识子类Id
public ke_SuperId = "";    //知识分类Id
public ke_SuperName_cn = "";    //知识分类名
public ke_SuperName_en = "";    //知识分类英文名
public ke_SubName_cn = "";    //知识子类名
public ke_SubName_en = "";    //知识子类英文名
public ke_SuperDescribe_cn = "";    //知识分类描述
public ke_SubDescribe_cn = "";    //知识子类描述
public ke_SuperDescribe_en = "";    //知识分类英文描述
public ke_SubDescribe_en = "";    //知识子类英文描述
public updDate = "";    //修改日期
public updUser = "";    //修改人
public memo = "";    //备注
public link = "";    //相应链接


 /**
 * 常量:"ke_SubId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ke_SubId(): string {return "ke_SubId";}    //知识子类Id

 /**
 * 常量:"ke_SuperId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ke_SuperId(): string {return "ke_SuperId";}    //知识分类Id

 /**
 * 常量:"ke_SuperName_cn"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ke_SuperName_cn(): string {return "ke_SuperName_cn";}    //知识分类名

 /**
 * 常量:"ke_SuperName_en"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ke_SuperName_en(): string {return "ke_SuperName_en";}    //知识分类英文名

 /**
 * 常量:"ke_SubName_cn"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ke_SubName_cn(): string {return "ke_SubName_cn";}    //知识子类名

 /**
 * 常量:"ke_SubName_en"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ke_SubName_en(): string {return "ke_SubName_en";}    //知识子类英文名

 /**
 * 常量:"ke_SuperDescribe_cn"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ke_SuperDescribe_cn(): string {return "ke_SuperDescribe_cn";}    //知识分类描述

 /**
 * 常量:"ke_SubDescribe_cn"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ke_SubDescribe_cn(): string {return "ke_SubDescribe_cn";}    //知识子类描述

 /**
 * 常量:"ke_SuperDescribe_en"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ke_SuperDescribe_en(): string {return "ke_SuperDescribe_en";}    //知识分类英文描述

 /**
 * 常量:"ke_SubDescribe_en"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ke_SubDescribe_en(): string {return "ke_SubDescribe_en";}    //知识子类英文描述

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
 * 常量:"Link"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Link(): string {return "link";}    //相应链接

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