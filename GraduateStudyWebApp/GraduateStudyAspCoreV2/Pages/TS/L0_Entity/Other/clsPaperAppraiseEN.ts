﻿
 /**
 * 类名:clsPaperAppraiseEN
 * 表名:PaperAppraise(01120567)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:54:13
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
 * 论文评论表(PaperAppraise)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTab } from '../../PubFun/clsGeneralTab.js';

export class clsPaperAppraiseEN extends clsGeneralTab
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "02"; //客户端缓存
public static IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
public static WhereFormat = ""; //条件格式串
public static _CurrTabName= "PaperAppraise"; //当前表名,与该类相关的表名
public static _KeyFldName= "PaperAppraiseId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 7;
public static AttributeName = ["paperAppraiseId", "paperAppraiseContent", "appraiseScore", "paperId", "updUser", "updDate", "memo"];
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
private mlngPaperAppraiseId = 0;    //论文评论Id
private mstrPaperAppraiseContent = "";    //论文评论内容
private mfltAppraiseScore = 0.0;    //打分
private mstrPaperId = "";    //论文Id
private mstrUpdUser = "";    //修改人
private mstrUpdDate = "";    //修改日期
private mstrMemo = "";    //备注

/**
 * 论文评论Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetPaperAppraiseId (value: number)
{
if (value  != undefined)
{
 this.paperAppraiseId = value;
    this.hmProperty["paperAppraiseId"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 论文评论内容(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetPaperAppraiseContent (value: string)
{
if (value  != undefined)
{
 this.paperAppraiseContent = value;
    this.hmProperty["paperAppraiseContent"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 打分(说明:;字段类型:float;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetAppraiseScore (value: number)
{
if (value  != undefined)
{
 this.appraiseScore = value;
    this.hmProperty["appraiseScore"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 论文Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetPaperId (value: string)
{
if (value  != undefined)
{
 this.paperId = value;
    this.hmProperty["paperId"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 修改人(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetUpdUser (value: string)
{
if (value  != undefined)
{
 this.updUser = value;
    this.hmProperty["updUser"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetUpdDate (value: string)
{
if (value  != undefined)
{
 this.updDate = value;
    this.hmProperty["updDate"] = true;
   this.sfUpdFldSetStr = this.updFldString;
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
   this.sfUpdFldSetStr = this.updFldString;
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
case clsPaperAppraiseEN.con_PaperAppraiseId:
return this.paperAppraiseId;
case clsPaperAppraiseEN.con_PaperAppraiseContent:
return this.paperAppraiseContent;
case clsPaperAppraiseEN.con_AppraiseScore:
return this.appraiseScore;
case clsPaperAppraiseEN.con_PaperId:
return this.paperId;
case clsPaperAppraiseEN.con_UpdUser:
return this.updUser;
case clsPaperAppraiseEN.con_UpdDate:
return this.updDate;
case clsPaperAppraiseEN.con_Memo:
return this.memo;
case "sfUpdFldSetStr":
return this.sfUpdFldSetStr;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[PaperAppraise]中不存在！`;
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
case clsPaperAppraiseEN.con_PaperAppraiseId:
this.paperAppraiseId = Number(strValue);
    this.hmProperty["paperAppraiseId"] = true;
break;
case clsPaperAppraiseEN.con_PaperAppraiseContent:
this.paperAppraiseContent = strValue;
    this.hmProperty["paperAppraiseContent"] = true;
break;
case clsPaperAppraiseEN.con_AppraiseScore:
this.appraiseScore = Number(strValue);
    this.hmProperty["appraiseScore"] = true;
break;
case clsPaperAppraiseEN.con_PaperId:
this.paperId = strValue;
    this.hmProperty["paperId"] = true;
break;
case clsPaperAppraiseEN.con_UpdUser:
this.updUser = strValue;
    this.hmProperty["updUser"] = true;
break;
case clsPaperAppraiseEN.con_UpdDate:
this.updDate = strValue;
    this.hmProperty["updDate"] = true;
break;
case clsPaperAppraiseEN.con_Memo:
this.memo = strValue;
    this.hmProperty["memo"] = true;
break;
case "sfUpdFldSetStr":
this.sfUpdFldSetStr = strValue;
break;
case "sf_FldComparisonOp":
this.sf_FldComparisonOp = strValue;
break;
default:
strMsg = `字段名:[${strFldName}]在表对象:[PaperAppraise]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
console.error(strMsg);
break;
}
}

/**
 * 设置对象中公共属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
*/
public paperAppraiseId = 0;    //论文评论Id
public paperAppraiseContent = "";    //论文评论内容
public appraiseScore = 0.0;    //打分
public paperId = "";    //论文Id
public updUser = "";    //修改人
public updDate = "";    //修改日期
public memo = "";    //备注


 /**
 * 常量:"PaperAppraiseId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PaperAppraiseId(): string {return "paperAppraiseId";}    //论文评论Id

 /**
 * 常量:"PaperAppraiseContent"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PaperAppraiseContent(): string {return "paperAppraiseContent";}    //论文评论内容

 /**
 * 常量:"AppraiseScore"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_AppraiseScore(): string {return "appraiseScore";}    //打分

 /**
 * 常量:"PaperId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PaperId(): string {return "paperId";}    //论文Id

 /**
 * 常量:"UpdUser"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UpdUser(): string {return "updUser";}    //修改人

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