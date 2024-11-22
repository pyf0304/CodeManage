
 /**
 * 类名:clsvgs_TeachingDateEN
 * 表名:vgs_TeachingDate(01120687)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 12:03:00
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
 * vgs_TeachingDate(vgs_TeachingDate)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTabV } from '../../PubFun/clsGeneralTabV.js';

export class clsvgs_TeachingDateEN extends clsGeneralTabV
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "02"; //客户端缓存
public static _CurrTabName= "vgs_TeachingDate"; //当前表名,与该类相关的表名
public static _KeyFldName= "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 9;
public static AttributeName = ["currEduClsId", "eduClsName", "memo", "updDate", "endDate", "startDate", "id_CurrEduCls", "updUser", "mId"];
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
case clsvgs_TeachingDateEN.con_CurrEduClsId:
return this.currEduClsId;
case clsvgs_TeachingDateEN.con_EduClsName:
return this.eduClsName;
case clsvgs_TeachingDateEN.con_Memo:
return this.memo;
case clsvgs_TeachingDateEN.con_UpdDate:
return this.updDate;
case clsvgs_TeachingDateEN.con_EndDate:
return this.endDate;
case clsvgs_TeachingDateEN.con_StartDate:
return this.startDate;
case clsvgs_TeachingDateEN.con_id_CurrEduCls:
return this.id_CurrEduCls;
case clsvgs_TeachingDateEN.con_UpdUser:
return this.updUser;
case clsvgs_TeachingDateEN.con_mId:
return this.mId;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[vgs_TeachingDate]中不存在！`;
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
case clsvgs_TeachingDateEN.con_CurrEduClsId:
this.currEduClsId = strValue;
break;
case clsvgs_TeachingDateEN.con_EduClsName:
this.eduClsName = strValue;
break;
case clsvgs_TeachingDateEN.con_Memo:
this.memo = strValue;
break;
case clsvgs_TeachingDateEN.con_UpdDate:
this.updDate = strValue;
break;
case clsvgs_TeachingDateEN.con_EndDate:
this.endDate = strValue;
break;
case clsvgs_TeachingDateEN.con_StartDate:
this.startDate = strValue;
break;
case clsvgs_TeachingDateEN.con_id_CurrEduCls:
this.id_CurrEduCls = strValue;
break;
case clsvgs_TeachingDateEN.con_UpdUser:
this.updUser = strValue;
break;
case clsvgs_TeachingDateEN.con_mId:
this.mId = Number(strValue);
break;
case "sf_FldComparisonOp":
this.sf_FldComparisonOp = strValue;
break;
default:
strMsg = `字段名:[${strFldName}]在表对象:[vgs_TeachingDate]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
console.error(strMsg);
break;
}
}

/**
 * 设置对象中公共属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
*/
public currEduClsId = "";    //教学班Id
public eduClsName = "";    //教学班名
public memo = "";    //备注
public updDate = "";    //修改日期
public endDate = "";    //截止日期
public startDate = "";    //开始日期
public id_CurrEduCls = "";    //教学班流水号
public updUser = "";    //修改人
public mId = 0;    //mId


 /**
 * 常量:"CurrEduClsId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CurrEduClsId(): string {return "currEduClsId";}    //教学班Id

 /**
 * 常量:"EduClsName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_EduClsName(): string {return "eduClsName";}    //教学班名

 /**
 * 常量:"Memo"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Memo(): string {return "memo";}    //备注

 /**
 * 常量:"UpdDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UpdDate(): string {return "updDate";}    //修改日期

 /**
 * 常量:"EndDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_EndDate(): string {return "endDate";}    //截止日期

 /**
 * 常量:"StartDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_StartDate(): string {return "startDate";}    //开始日期

 /**
 * 常量:"id_CurrEduCls"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_CurrEduCls(): string {return "id_CurrEduCls";}    //教学班流水号

 /**
 * 常量:"UpdUser"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UpdUser(): string {return "updUser";}    //修改人

 /**
 * 常量:"mId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_mId(): string {return "mId";}    //mId

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