﻿
 /**
 * 类名:clsPaperSubAttachmentEN
 * 表名:PaperSubAttachment(01120579)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:54:32
 * 生成者:pyf
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:研培论文(GraduateEduPaper)
 * 框架-层名:实体层(TS)(EntityLayer)
 * 编程语言:TypeScript
 **/
 /**
 * 子观点附件(PaperSubAttachment)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTab } from '../../PubFun/clsGeneralTab.js';

export class clsPaperSubAttachmentEN extends clsGeneralTab
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "04"; //sessionStorage
public static IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
public static WhereFormat = ""; //条件格式串
public static _CurrTabName= "PaperSubAttachment"; //当前表名,与该类相关的表名
public static _KeyFldName= "PaperSubAttachmentId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 9;
public static AttributeName = ["paperSubAttachmentId", "paperSubAttachmentName", "filePath", "updUserId", "updDate", "memo", "id_CurrEduCls", "paperRWId", "subViewpointId"];
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
private mlngPaperSubAttachmentId = 0;    //子观点附件Id
private mstrPaperSubAttachmentName = "";    //附件名称
private mstrFilePath = "";    //文件路径
private mstrUpdUserId = "";    //修改用户Id
private mstrUpdDate = "";    //修改日期
private mstrMemo = "";    //备注
private mstrid_CurrEduCls = "";    //教学班流水号
private mstrPaperRWId = "";    //课文阅读
private mstrSubViewpointId = "";    //子观点Id

/**
 * 子观点附件Id(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetPaperSubAttachmentId (value: number)
{
if (value  != undefined)
{
 this.paperSubAttachmentId = value;
    this.hmProperty["paperSubAttachmentId"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 附件名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetPaperSubAttachmentName (value: string)
{
if (value  != undefined)
{
 this.paperSubAttachmentName = value;
    this.hmProperty["paperSubAttachmentName"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 文件路径(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetFilePath (value: string)
{
if (value  != undefined)
{
 this.filePath = value;
    this.hmProperty["filePath"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetUpdUserId (value: string)
{
if (value  != undefined)
{
 this.updUserId = value;
    this.hmProperty["updUserId"] = true;
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
 * 教学班流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setid_CurrEduCls (value: string)
{
if (value  != undefined)
{
 this.id_CurrEduCls = value;
    this.hmProperty["id_CurrEduCls"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 课文阅读(说明:;字段类型:char;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetPaperRWId (value: string)
{
if (value  != undefined)
{
 this.paperRWId = value;
    this.hmProperty["paperRWId"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 子观点Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetSubViewpointId (value: string)
{
if (value  != undefined)
{
 this.subViewpointId = value;
    this.hmProperty["subViewpointId"] = true;
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
case clsPaperSubAttachmentEN.con_PaperSubAttachmentId:
return this.paperSubAttachmentId;
case clsPaperSubAttachmentEN.con_PaperSubAttachmentName:
return this.paperSubAttachmentName;
case clsPaperSubAttachmentEN.con_FilePath:
return this.filePath;
case clsPaperSubAttachmentEN.con_UpdUserId:
return this.updUserId;
case clsPaperSubAttachmentEN.con_UpdDate:
return this.updDate;
case clsPaperSubAttachmentEN.con_Memo:
return this.memo;
case clsPaperSubAttachmentEN.con_id_CurrEduCls:
return this.id_CurrEduCls;
case clsPaperSubAttachmentEN.con_PaperRWId:
return this.paperRWId;
case clsPaperSubAttachmentEN.con_SubViewpointId:
return this.subViewpointId;
case "sfUpdFldSetStr":
return this.sfUpdFldSetStr;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[PaperSubAttachment]中不存在！`;
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
case clsPaperSubAttachmentEN.con_PaperSubAttachmentId:
this.paperSubAttachmentId = Number(strValue);
    this.hmProperty["paperSubAttachmentId"] = true;
break;
case clsPaperSubAttachmentEN.con_PaperSubAttachmentName:
this.paperSubAttachmentName = strValue;
    this.hmProperty["paperSubAttachmentName"] = true;
break;
case clsPaperSubAttachmentEN.con_FilePath:
this.filePath = strValue;
    this.hmProperty["filePath"] = true;
break;
case clsPaperSubAttachmentEN.con_UpdUserId:
this.updUserId = strValue;
    this.hmProperty["updUserId"] = true;
break;
case clsPaperSubAttachmentEN.con_UpdDate:
this.updDate = strValue;
    this.hmProperty["updDate"] = true;
break;
case clsPaperSubAttachmentEN.con_Memo:
this.memo = strValue;
    this.hmProperty["memo"] = true;
break;
case clsPaperSubAttachmentEN.con_id_CurrEduCls:
this.id_CurrEduCls = strValue;
    this.hmProperty["id_CurrEduCls"] = true;
break;
case clsPaperSubAttachmentEN.con_PaperRWId:
this.paperRWId = strValue;
    this.hmProperty["paperRWId"] = true;
break;
case clsPaperSubAttachmentEN.con_SubViewpointId:
this.subViewpointId = strValue;
    this.hmProperty["subViewpointId"] = true;
break;
case "sfUpdFldSetStr":
this.sfUpdFldSetStr = strValue;
break;
case "sf_FldComparisonOp":
this.sf_FldComparisonOp = strValue;
break;
default:
strMsg = `字段名:[${strFldName}]在表对象:[PaperSubAttachment]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
console.error(strMsg);
break;
}
}

/**
 * 设置对象中公共属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
*/
public paperSubAttachmentId = 0;    //子观点附件Id
public paperSubAttachmentName = "";    //附件名称
public filePath = "";    //文件路径
public updUserId = "";    //修改用户Id
public updDate = "";    //修改日期
public memo = "";    //备注
public id_CurrEduCls = "";    //教学班流水号
public paperRWId = "";    //课文阅读
public subViewpointId = "";    //子观点Id


 /**
 * 常量:"PaperSubAttachmentId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PaperSubAttachmentId(): string {return "paperSubAttachmentId";}    //子观点附件Id

 /**
 * 常量:"PaperSubAttachmentName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PaperSubAttachmentName(): string {return "paperSubAttachmentName";}    //附件名称

 /**
 * 常量:"FilePath"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_FilePath(): string {return "filePath";}    //文件路径

 /**
 * 常量:"UpdUserId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UpdUserId(): string {return "updUserId";}    //修改用户Id

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
 * 常量:"id_CurrEduCls"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_CurrEduCls(): string {return "id_CurrEduCls";}    //教学班流水号

 /**
 * 常量:"PaperRWId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PaperRWId(): string {return "paperRWId";}    //课文阅读

 /**
 * 常量:"SubViewpointId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SubViewpointId(): string {return "subViewpointId";}    //子观点Id

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