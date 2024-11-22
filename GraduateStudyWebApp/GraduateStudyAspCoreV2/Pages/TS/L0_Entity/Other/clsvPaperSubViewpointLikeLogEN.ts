﻿
 /**
 * 类名:clsvPaperSubViewpointLikeLogEN
 * 表名:vPaperSubViewpointLikeLog(01120563)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:44:17
 * 生成者:pyf
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:其他(Other)
 * 框架-层名:实体层(TS)(EntityLayer)
 * 编程语言:TypeScript
 **/
 /**
 * v子观点点赞表(vPaperSubViewpointLikeLog)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTabV } from '../../PubFun/clsGeneralTabV.js';

export class clsvPaperSubViewpointLikeLogEN extends clsGeneralTabV
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "02"; //客户端缓存
public static IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
public static WhereFormat = ""; //条件格式串
public static _CurrTabName= "vPaperSubViewpointLikeLog"; //当前表名,与该类相关的表名
public static _KeyFldName= "PaperSubViewpointLikeLogId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 9;
public static AttributeName = ["paperSubViewpointLikeLogId", "subViewpointId", "updDate", "memo", "rwTitle", "subViewpointContent", "explainContent", "paperRWId", "updUser"];
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
case clsvPaperSubViewpointLikeLogEN.con_PaperSubViewpointLikeLogId:
return this.paperSubViewpointLikeLogId;
case clsvPaperSubViewpointLikeLogEN.con_SubViewpointId:
return this.subViewpointId;
case clsvPaperSubViewpointLikeLogEN.con_UpdDate:
return this.updDate;
case clsvPaperSubViewpointLikeLogEN.con_Memo:
return this.memo;
case clsvPaperSubViewpointLikeLogEN.con_RWTitle:
return this.rwTitle;
case clsvPaperSubViewpointLikeLogEN.con_SubViewpointContent:
return this.subViewpointContent;
case clsvPaperSubViewpointLikeLogEN.con_ExplainContent:
return this.explainContent;
case clsvPaperSubViewpointLikeLogEN.con_PaperRWId:
return this.paperRWId;
case clsvPaperSubViewpointLikeLogEN.con_UpdUser:
return this.updUser;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[vPaperSubViewpointLikeLog]中不存在！`;
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
case clsvPaperSubViewpointLikeLogEN.con_PaperSubViewpointLikeLogId:
this.paperSubViewpointLikeLogId = Number(strValue);
break;
case clsvPaperSubViewpointLikeLogEN.con_SubViewpointId:
this.subViewpointId = strValue;
break;
case clsvPaperSubViewpointLikeLogEN.con_UpdDate:
this.updDate = strValue;
break;
case clsvPaperSubViewpointLikeLogEN.con_Memo:
this.memo = strValue;
break;
case clsvPaperSubViewpointLikeLogEN.con_RWTitle:
this.rwTitle = strValue;
break;
case clsvPaperSubViewpointLikeLogEN.con_SubViewpointContent:
this.subViewpointContent = strValue;
break;
case clsvPaperSubViewpointLikeLogEN.con_ExplainContent:
this.explainContent = strValue;
break;
case clsvPaperSubViewpointLikeLogEN.con_PaperRWId:
this.paperRWId = strValue;
break;
case clsvPaperSubViewpointLikeLogEN.con_UpdUser:
this.updUser = strValue;
break;
case "sf_FldComparisonOp":
this.sf_FldComparisonOp = strValue;
break;
default:
strMsg = `字段名:[${strFldName}]在表对象:[vPaperSubViewpointLikeLog]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
console.error(strMsg);
break;
}
}

/**
 * 设置对象中公共属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
*/
public paperSubViewpointLikeLogId = 0;    //点赞Id
public subViewpointId = "";    //子观点Id
public updDate = "";    //修改日期
public memo = "";    //备注
public rwTitle = "";    //读写标题
public subViewpointContent = "";    //详情内容
public explainContent = "";    //说明内容
public paperRWId = "";    //课文阅读
public updUser = "";    //修改人


 /**
 * 常量:"PaperSubViewpointLikeLogId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PaperSubViewpointLikeLogId(): string {return "paperSubViewpointLikeLogId";}    //点赞Id

 /**
 * 常量:"SubViewpointId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SubViewpointId(): string {return "subViewpointId";}    //子观点Id

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
 * 常量:"RWTitle"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_RWTitle(): string {return "rwTitle";}    //读写标题

 /**
 * 常量:"SubViewpointContent"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SubViewpointContent(): string {return "subViewpointContent";}    //详情内容

 /**
 * 常量:"ExplainContent"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ExplainContent(): string {return "explainContent";}    //说明内容

 /**
 * 常量:"PaperRWId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PaperRWId(): string {return "paperRWId";}    //课文阅读

 /**
 * 常量:"UpdUser"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UpdUser(): string {return "updUser";}    //修改人

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