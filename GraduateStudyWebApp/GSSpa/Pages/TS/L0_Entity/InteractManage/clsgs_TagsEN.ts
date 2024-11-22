﻿
 /**
 * 类名:clsgs_TagsEN
 * 表名:gs_Tags(01120714)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:13
 * 生成者:pyf
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
 * 框架-层名:实体层(TS)(EntityLayer)
 * 编程语言:TypeScript
 **/
 /**
 * 标注(gs_Tags)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTab } from '../../PubFun/clsGeneralTab.js';

export class clsgs_TagsEN extends clsGeneralTab
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "02"; //客户端缓存
public static _CurrTabName= "gs_Tags"; //当前表名,与该类相关的表名
public static _KeyFldName= "TagsId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 21;
public static AttributeName = ["tagsId", "tagsContent", "pdfContent", "pdfPageNum", "voteCount", "orderNum", "updUser", "updDate", "pdfLineNum", "pdfX", "pdfY", "memo", "id_CurrEduCls", "paperId", "shareId", "pdfPageNumIn", "pdfPageTop", "pdfDivLet", "pdfDivTop", "pdfZoom", "tagsTypeId"];
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
private mstrTagsId = "";    //标注Id
private mstrTagsContent = "";    //标注内容
private mstrPdfContent = "";    //Pdf内容
private mintPdfPageNum = 0;    //Pdf页码
private mintVoteCount = 0;    //点赞计数
private mintOrderNum = 0;    //序号
private mstrUpdUser = "";    //修改人
private mstrUpdDate = "";    //修改日期
private mintPdfLineNum = 0;    //pdf行号
private mstrPdfX = "";    //PdfX
private mstrPdfY = "";    //PdfY
private mstrMemo = "";    //备注
private mstrid_CurrEduCls = "";    //教学班流水号
private mstrPaperId = "";    //论文Id
private mstrShareId = "";    //分享Id
private mstrPdfPageNumIn = "";    //PdfPageNumIn
private mintPdfPageTop = 0;    //pdf页面顶部位置
private mstrPdfDivLet = "";    //PdfDivLet
private mstrPdfDivTop = "";    //PdfDivTop
private mstrPdfZoom = "";    //PdfZoom
private mstrTagsTypeId = "";    //标注类型ID

/**
 * 标注Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetTagsId (value: string)
{
if (value  != undefined)
{
 this.tagsId = value;
    this.hmProperty["tagsId"] = true;
}
}

/**
 * 标注内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetTagsContent (value: string)
{
if (value  != undefined)
{
 this.tagsContent = value;
    this.hmProperty["tagsContent"] = true;
}
}

/**
 * Pdf内容(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetPdfContent (value: string)
{
if (value  != undefined)
{
 this.pdfContent = value;
    this.hmProperty["pdfContent"] = true;
}
}

/**
 * Pdf页码(说明:;字段类型:int;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetPdfPageNum (value: number)
{
if (value  != undefined)
{
 this.pdfPageNum = value;
    this.hmProperty["pdfPageNum"] = true;
}
}

/**
 * 点赞计数(说明:;字段类型:int;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetVoteCount (value: number)
{
if (value  != undefined)
{
 this.voteCount = value;
    this.hmProperty["voteCount"] = true;
}
}

/**
 * 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetOrderNum (value: number)
{
if (value  != undefined)
{
 this.orderNum = value;
    this.hmProperty["orderNum"] = true;
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
}
}

/**
 * pdf行号(说明:;字段类型:int;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetPdfLineNum (value: number)
{
if (value  != undefined)
{
 this.pdfLineNum = value;
    this.hmProperty["pdfLineNum"] = true;
}
}

/**
 * PdfX(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetPdfX (value: string)
{
if (value  != undefined)
{
 this.pdfX = value;
    this.hmProperty["pdfX"] = true;
}
}

/**
 * PdfY(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetPdfY (value: string)
{
if (value  != undefined)
{
 this.pdfY = value;
    this.hmProperty["pdfY"] = true;
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
}
}

/**
 * 分享Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetShareId (value: string)
{
if (value  != undefined)
{
 this.shareId = value;
    this.hmProperty["shareId"] = true;
}
}

/**
 * PdfPageNumIn(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetPdfPageNumIn (value: string)
{
if (value  != undefined)
{
 this.pdfPageNumIn = value;
    this.hmProperty["pdfPageNumIn"] = true;
}
}

/**
 * pdf页面顶部位置(说明:;字段类型:int;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetPdfPageTop (value: number)
{
if (value  != undefined)
{
 this.pdfPageTop = value;
    this.hmProperty["pdfPageTop"] = true;
}
}

/**
 * PdfDivLet(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetPdfDivLet (value: string)
{
if (value  != undefined)
{
 this.pdfDivLet = value;
    this.hmProperty["pdfDivLet"] = true;
}
}

/**
 * PdfDivTop(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetPdfDivTop (value: string)
{
if (value  != undefined)
{
 this.pdfDivTop = value;
    this.hmProperty["pdfDivTop"] = true;
}
}

/**
 * PdfZoom(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetPdfZoom (value: string)
{
if (value  != undefined)
{
 this.pdfZoom = value;
    this.hmProperty["pdfZoom"] = true;
}
}

/**
 * 标注类型ID(说明:;字段类型:char;字段长度:2;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetTagsTypeId (value: string)
{
if (value  != undefined)
{
 this.tagsTypeId = value;
    this.hmProperty["tagsTypeId"] = true;
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
case clsgs_TagsEN.con_TagsId:
return this.tagsId;
case clsgs_TagsEN.con_TagsContent:
return this.tagsContent;
case clsgs_TagsEN.con_PdfContent:
return this.pdfContent;
case clsgs_TagsEN.con_PdfPageNum:
return this.pdfPageNum;
case clsgs_TagsEN.con_VoteCount:
return this.voteCount;
case clsgs_TagsEN.con_OrderNum:
return this.orderNum;
case clsgs_TagsEN.con_UpdUser:
return this.updUser;
case clsgs_TagsEN.con_UpdDate:
return this.updDate;
case clsgs_TagsEN.con_PdfLineNum:
return this.pdfLineNum;
case clsgs_TagsEN.con_PdfX:
return this.pdfX;
case clsgs_TagsEN.con_PdfY:
return this.pdfY;
case clsgs_TagsEN.con_Memo:
return this.memo;
case clsgs_TagsEN.con_id_CurrEduCls:
return this.id_CurrEduCls;
case clsgs_TagsEN.con_PaperId:
return this.paperId;
case clsgs_TagsEN.con_ShareId:
return this.shareId;
case clsgs_TagsEN.con_PdfPageNumIn:
return this.pdfPageNumIn;
case clsgs_TagsEN.con_PdfPageTop:
return this.pdfPageTop;
case clsgs_TagsEN.con_PdfDivLet:
return this.pdfDivLet;
case clsgs_TagsEN.con_PdfDivTop:
return this.pdfDivTop;
case clsgs_TagsEN.con_PdfZoom:
return this.pdfZoom;
case clsgs_TagsEN.con_TagsTypeId:
return this.tagsTypeId;
case "sf_UpdFldSetStr":
return this.sf_UpdFldSetStr;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[gs_Tags]中不存在！`;
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
case clsgs_TagsEN.con_TagsId:
this.tagsId = strValue;
    this.hmProperty["tagsId"] = true;
break;
case clsgs_TagsEN.con_TagsContent:
this.tagsContent = strValue;
    this.hmProperty["tagsContent"] = true;
break;
case clsgs_TagsEN.con_PdfContent:
this.pdfContent = strValue;
    this.hmProperty["pdfContent"] = true;
break;
case clsgs_TagsEN.con_PdfPageNum:
this.pdfPageNum = Number(strValue);
    this.hmProperty["pdfPageNum"] = true;
break;
case clsgs_TagsEN.con_VoteCount:
this.voteCount = Number(strValue);
    this.hmProperty["voteCount"] = true;
break;
case clsgs_TagsEN.con_OrderNum:
this.orderNum = Number(strValue);
    this.hmProperty["orderNum"] = true;
break;
case clsgs_TagsEN.con_UpdUser:
this.updUser = strValue;
    this.hmProperty["updUser"] = true;
break;
case clsgs_TagsEN.con_UpdDate:
this.updDate = strValue;
    this.hmProperty["updDate"] = true;
break;
case clsgs_TagsEN.con_PdfLineNum:
this.pdfLineNum = Number(strValue);
    this.hmProperty["pdfLineNum"] = true;
break;
case clsgs_TagsEN.con_PdfX:
this.pdfX = strValue;
    this.hmProperty["pdfX"] = true;
break;
case clsgs_TagsEN.con_PdfY:
this.pdfY = strValue;
    this.hmProperty["pdfY"] = true;
break;
case clsgs_TagsEN.con_Memo:
this.memo = strValue;
    this.hmProperty["memo"] = true;
break;
case clsgs_TagsEN.con_id_CurrEduCls:
this.id_CurrEduCls = strValue;
    this.hmProperty["id_CurrEduCls"] = true;
break;
case clsgs_TagsEN.con_PaperId:
this.paperId = strValue;
    this.hmProperty["paperId"] = true;
break;
case clsgs_TagsEN.con_ShareId:
this.shareId = strValue;
    this.hmProperty["shareId"] = true;
break;
case clsgs_TagsEN.con_PdfPageNumIn:
this.pdfPageNumIn = strValue;
    this.hmProperty["pdfPageNumIn"] = true;
break;
case clsgs_TagsEN.con_PdfPageTop:
this.pdfPageTop = Number(strValue);
    this.hmProperty["pdfPageTop"] = true;
break;
case clsgs_TagsEN.con_PdfDivLet:
this.pdfDivLet = strValue;
    this.hmProperty["pdfDivLet"] = true;
break;
case clsgs_TagsEN.con_PdfDivTop:
this.pdfDivTop = strValue;
    this.hmProperty["pdfDivTop"] = true;
break;
case clsgs_TagsEN.con_PdfZoom:
this.pdfZoom = strValue;
    this.hmProperty["pdfZoom"] = true;
break;
case clsgs_TagsEN.con_TagsTypeId:
this.tagsTypeId = strValue;
    this.hmProperty["tagsTypeId"] = true;
break;
case "sf_UpdFldSetStr":
this.sf_UpdFldSetStr = strValue;
break;
case "sf_FldComparisonOp":
this.sf_FldComparisonOp = strValue;
break;
default:
strMsg = `字段名:[${strFldName}]在表对象:[gs_Tags]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
console.error(strMsg);
break;
}
}

/**
 * 设置对象中公共属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
*/
public tagsId = "";    //标注Id
public tagsContent = "";    //标注内容
public pdfContent = "";    //Pdf内容
public pdfPageNum = 0;    //Pdf页码
public voteCount = 0;    //点赞计数
public orderNum = 0;    //序号
public updUser = "";    //修改人
public updDate = "";    //修改日期
public pdfLineNum = 0;    //pdf行号
public pdfX = "";    //PdfX
public pdfY = "";    //PdfY
public memo = "";    //备注
public id_CurrEduCls = "";    //教学班流水号
public paperId = "";    //论文Id
public shareId = "";    //分享Id
public pdfPageNumIn = "";    //PdfPageNumIn
public pdfPageTop = 0;    //pdf页面顶部位置
public pdfDivLet = "";    //PdfDivLet
public pdfDivTop = "";    //PdfDivTop
public pdfZoom = "";    //PdfZoom
public tagsTypeId = "";    //标注类型ID


 /**
 * 常量:"TagsId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_TagsId(): string {return "tagsId";}    //标注Id

 /**
 * 常量:"TagsContent"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_TagsContent(): string {return "tagsContent";}    //标注内容

 /**
 * 常量:"PdfContent"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PdfContent(): string {return "pdfContent";}    //Pdf内容

 /**
 * 常量:"PdfPageNum"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PdfPageNum(): string {return "pdfPageNum";}    //Pdf页码

 /**
 * 常量:"VoteCount"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_VoteCount(): string {return "voteCount";}    //点赞计数

 /**
 * 常量:"OrderNum"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_OrderNum(): string {return "orderNum";}    //序号

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
 * 常量:"PdfLineNum"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PdfLineNum(): string {return "pdfLineNum";}    //pdf行号

 /**
 * 常量:"PdfX"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PdfX(): string {return "pdfX";}    //PdfX

 /**
 * 常量:"PdfY"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PdfY(): string {return "pdfY";}    //PdfY

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
 * 常量:"PaperId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PaperId(): string {return "paperId";}    //论文Id

 /**
 * 常量:"ShareId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ShareId(): string {return "shareId";}    //分享Id

 /**
 * 常量:"PdfPageNumIn"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PdfPageNumIn(): string {return "pdfPageNumIn";}    //PdfPageNumIn

 /**
 * 常量:"PdfPageTop"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PdfPageTop(): string {return "pdfPageTop";}    //pdf页面顶部位置

 /**
 * 常量:"PdfDivLet"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PdfDivLet(): string {return "pdfDivLet";}    //PdfDivLet

 /**
 * 常量:"PdfDivTop"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PdfDivTop(): string {return "pdfDivTop";}    //PdfDivTop

 /**
 * 常量:"PdfZoom"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PdfZoom(): string {return "pdfZoom";}    //PdfZoom

 /**
 * 常量:"TagsTypeId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_TagsTypeId(): string {return "tagsTypeId";}    //标注类型ID

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