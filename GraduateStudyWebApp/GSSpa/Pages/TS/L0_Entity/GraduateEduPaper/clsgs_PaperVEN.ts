﻿
 /**
 * 类名:clsgs_PaperVEN
 * 表名:gs_PaperV(01120678)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:46
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
 * 论文历史版本表(gs_PaperV)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTab } from '../../PubFun/clsGeneralTab.js';

export class clsgs_PaperVEN extends clsGeneralTab
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "05"; //未知
public static _CurrTabName= "gs_PaperV"; //当前表名,与该类相关的表名
public static _KeyFldName= "PaperVId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 23;
public static AttributeName = ["paperVId", "paperId", "paperTitle", "paperContent", "periodical", "author", "researchQuestion", "keyword", "literatureSources", "literatureLink", "uploadfileUrl", "isQuotethesis", "isSubmit", "isChecked", "quoteId", "checker", "literatureTypeId", "updUser", "updDate", "id_CurrEduCls", "paperTypeId", "paperStatusId", "memo"];
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
private mlngPaperVId = 0;    //PaperVId
private mstrPaperId = "";    //论文Id
private mstrPaperTitle = "";    //论文标题
private mstrPaperContent = "";    //主题内容
private mstrPeriodical = "";    //期刊
private mstrAuthor = "";    //作者
private mstrResearchQuestion = "";    //研究问题
private mstrKeyword = "";    //关键字
private mstrLiteratureSources = "";    //文献来源
private mstrLiteratureLink = "";    //文献链接
private mstrUploadfileUrl = "";    //文件地址
private mbolIsQuotethesis = false;    //是否引用论文
private mbolIsSubmit = false;    //是否提交
private mbolIsChecked = false;    //是否检查
private mstrQuoteId = "";    //引用Id
private mstrChecker = "";    //审核人
private mstrLiteratureTypeId = "";    //作文类型Id
private mstrUpdUser = "";    //修改人
private mstrUpdDate = "";    //修改日期
private mstrid_CurrEduCls = "";    //教学班流水号
private mstrPaperTypeId = "";    //论文类型Id
private mstrPaperStatusId = "";    //论文状态Id
private mstrMemo = "";    //备注

/**
 * PaperVId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetPaperVId (value: number)
{
if (value  != undefined)
{
 this.paperVId = value;
    this.hmProperty["paperVId"] = true;
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
 * 论文标题(说明:;字段类型:varchar;字段长度:500;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetPaperTitle (value: string)
{
if (value  != undefined)
{
 this.paperTitle = value;
    this.hmProperty["paperTitle"] = true;
}
}

/**
 * 主题内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetPaperContent (value: string)
{
if (value  != undefined)
{
 this.paperContent = value;
    this.hmProperty["paperContent"] = true;
}
}

/**
 * 期刊(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetPeriodical (value: string)
{
if (value  != undefined)
{
 this.periodical = value;
    this.hmProperty["periodical"] = true;
}
}

/**
 * 作者(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetAuthor (value: string)
{
if (value  != undefined)
{
 this.author = value;
    this.hmProperty["author"] = true;
}
}

/**
 * 研究问题(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetResearchQuestion (value: string)
{
if (value  != undefined)
{
 this.researchQuestion = value;
    this.hmProperty["researchQuestion"] = true;
}
}

/**
 * 关键字(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetKeyword (value: string)
{
if (value  != undefined)
{
 this.keyword = value;
    this.hmProperty["keyword"] = true;
}
}

/**
 * 文献来源(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetLiteratureSources (value: string)
{
if (value  != undefined)
{
 this.literatureSources = value;
    this.hmProperty["literatureSources"] = true;
}
}

/**
 * 文献链接(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetLiteratureLink (value: string)
{
if (value  != undefined)
{
 this.literatureLink = value;
    this.hmProperty["literatureLink"] = true;
}
}

/**
 * 文件地址(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetUploadfileUrl (value: string)
{
if (value  != undefined)
{
 this.uploadfileUrl = value;
    this.hmProperty["uploadfileUrl"] = true;
}
}

/**
 * 是否引用论文(说明:;字段类型:bit;字段长度:1;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetIsQuotethesis (value: boolean)
{
if (value  != undefined)
{
 this.isQuotethesis = value;
    this.hmProperty["isQuotethesis"] = true;
}
}

/**
 * 是否提交(说明:;字段类型:bit;字段长度:1;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetIsSubmit (value: boolean)
{
if (value  != undefined)
{
 this.isSubmit = value;
    this.hmProperty["isSubmit"] = true;
}
}

/**
 * 是否检查(说明:;字段类型:bit;字段长度:1;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetIsChecked (value: boolean)
{
if (value  != undefined)
{
 this.isChecked = value;
    this.hmProperty["isChecked"] = true;
}
}

/**
 * 引用Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetQuoteId (value: string)
{
if (value  != undefined)
{
 this.quoteId = value;
    this.hmProperty["quoteId"] = true;
}
}

/**
 * 审核人(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetChecker (value: string)
{
if (value  != undefined)
{
 this.checker = value;
    this.hmProperty["checker"] = true;
}
}

/**
 * 作文类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetLiteratureTypeId (value: string)
{
if (value  != undefined)
{
 this.literatureTypeId = value;
    this.hmProperty["literatureTypeId"] = true;
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
 * 论文类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetPaperTypeId (value: string)
{
if (value  != undefined)
{
 this.paperTypeId = value;
    this.hmProperty["paperTypeId"] = true;
}
}

/**
 * 论文状态Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetPaperStatusId (value: string)
{
if (value  != undefined)
{
 this.paperStatusId = value;
    this.hmProperty["paperStatusId"] = true;
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
case clsgs_PaperVEN.con_PaperVId:
return this.paperVId;
case clsgs_PaperVEN.con_PaperId:
return this.paperId;
case clsgs_PaperVEN.con_PaperTitle:
return this.paperTitle;
case clsgs_PaperVEN.con_PaperContent:
return this.paperContent;
case clsgs_PaperVEN.con_Periodical:
return this.periodical;
case clsgs_PaperVEN.con_Author:
return this.author;
case clsgs_PaperVEN.con_ResearchQuestion:
return this.researchQuestion;
case clsgs_PaperVEN.con_Keyword:
return this.keyword;
case clsgs_PaperVEN.con_LiteratureSources:
return this.literatureSources;
case clsgs_PaperVEN.con_LiteratureLink:
return this.literatureLink;
case clsgs_PaperVEN.con_UploadfileUrl:
return this.uploadfileUrl;
case clsgs_PaperVEN.con_IsQuotethesis:
return this.isQuotethesis;
case clsgs_PaperVEN.con_IsSubmit:
return this.isSubmit;
case clsgs_PaperVEN.con_IsChecked:
return this.isChecked;
case clsgs_PaperVEN.con_QuoteId:
return this.quoteId;
case clsgs_PaperVEN.con_Checker:
return this.checker;
case clsgs_PaperVEN.con_LiteratureTypeId:
return this.literatureTypeId;
case clsgs_PaperVEN.con_UpdUser:
return this.updUser;
case clsgs_PaperVEN.con_UpdDate:
return this.updDate;
case clsgs_PaperVEN.con_id_CurrEduCls:
return this.id_CurrEduCls;
case clsgs_PaperVEN.con_PaperTypeId:
return this.paperTypeId;
case clsgs_PaperVEN.con_PaperStatusId:
return this.paperStatusId;
case clsgs_PaperVEN.con_Memo:
return this.memo;
case "sf_UpdFldSetStr":
return this.sf_UpdFldSetStr;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[gs_PaperV]中不存在！`;
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
case clsgs_PaperVEN.con_PaperVId:
this.paperVId = Number(strValue);
    this.hmProperty["paperVId"] = true;
break;
case clsgs_PaperVEN.con_PaperId:
this.paperId = strValue;
    this.hmProperty["paperId"] = true;
break;
case clsgs_PaperVEN.con_PaperTitle:
this.paperTitle = strValue;
    this.hmProperty["paperTitle"] = true;
break;
case clsgs_PaperVEN.con_PaperContent:
this.paperContent = strValue;
    this.hmProperty["paperContent"] = true;
break;
case clsgs_PaperVEN.con_Periodical:
this.periodical = strValue;
    this.hmProperty["periodical"] = true;
break;
case clsgs_PaperVEN.con_Author:
this.author = strValue;
    this.hmProperty["author"] = true;
break;
case clsgs_PaperVEN.con_ResearchQuestion:
this.researchQuestion = strValue;
    this.hmProperty["researchQuestion"] = true;
break;
case clsgs_PaperVEN.con_Keyword:
this.keyword = strValue;
    this.hmProperty["keyword"] = true;
break;
case clsgs_PaperVEN.con_LiteratureSources:
this.literatureSources = strValue;
    this.hmProperty["literatureSources"] = true;
break;
case clsgs_PaperVEN.con_LiteratureLink:
this.literatureLink = strValue;
    this.hmProperty["literatureLink"] = true;
break;
case clsgs_PaperVEN.con_UploadfileUrl:
this.uploadfileUrl = strValue;
    this.hmProperty["uploadfileUrl"] = true;
break;
case clsgs_PaperVEN.con_IsQuotethesis:
this.isQuotethesis = Boolean(strValue);
    this.hmProperty["isQuotethesis"] = true;
break;
case clsgs_PaperVEN.con_IsSubmit:
this.isSubmit = Boolean(strValue);
    this.hmProperty["isSubmit"] = true;
break;
case clsgs_PaperVEN.con_IsChecked:
this.isChecked = Boolean(strValue);
    this.hmProperty["isChecked"] = true;
break;
case clsgs_PaperVEN.con_QuoteId:
this.quoteId = strValue;
    this.hmProperty["quoteId"] = true;
break;
case clsgs_PaperVEN.con_Checker:
this.checker = strValue;
    this.hmProperty["checker"] = true;
break;
case clsgs_PaperVEN.con_LiteratureTypeId:
this.literatureTypeId = strValue;
    this.hmProperty["literatureTypeId"] = true;
break;
case clsgs_PaperVEN.con_UpdUser:
this.updUser = strValue;
    this.hmProperty["updUser"] = true;
break;
case clsgs_PaperVEN.con_UpdDate:
this.updDate = strValue;
    this.hmProperty["updDate"] = true;
break;
case clsgs_PaperVEN.con_id_CurrEduCls:
this.id_CurrEduCls = strValue;
    this.hmProperty["id_CurrEduCls"] = true;
break;
case clsgs_PaperVEN.con_PaperTypeId:
this.paperTypeId = strValue;
    this.hmProperty["paperTypeId"] = true;
break;
case clsgs_PaperVEN.con_PaperStatusId:
this.paperStatusId = strValue;
    this.hmProperty["paperStatusId"] = true;
break;
case clsgs_PaperVEN.con_Memo:
this.memo = strValue;
    this.hmProperty["memo"] = true;
break;
case "sf_UpdFldSetStr":
this.sf_UpdFldSetStr = strValue;
break;
case "sf_FldComparisonOp":
this.sf_FldComparisonOp = strValue;
break;
default:
strMsg = `字段名:[${strFldName}]在表对象:[gs_PaperV]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
console.error(strMsg);
break;
}
}

/**
 * 设置对象中公共属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
*/
public paperVId = 0;    //PaperVId
public paperId = "";    //论文Id
public paperTitle = "";    //论文标题
public paperContent = "";    //主题内容
public periodical = "";    //期刊
public author = "";    //作者
public researchQuestion = "";    //研究问题
public keyword = "";    //关键字
public literatureSources = "";    //文献来源
public literatureLink = "";    //文献链接
public uploadfileUrl = "";    //文件地址
public isQuotethesis = false;    //是否引用论文
public isSubmit = false;    //是否提交
public isChecked = false;    //是否检查
public quoteId = "";    //引用Id
public checker = "";    //审核人
public literatureTypeId = "";    //作文类型Id
public updUser = "";    //修改人
public updDate = "";    //修改日期
public id_CurrEduCls = "";    //教学班流水号
public paperTypeId = "";    //论文类型Id
public paperStatusId = "";    //论文状态Id
public memo = "";    //备注


 /**
 * 常量:"PaperVId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PaperVId(): string {return "paperVId";}    //PaperVId

 /**
 * 常量:"PaperId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PaperId(): string {return "paperId";}    //论文Id

 /**
 * 常量:"PaperTitle"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PaperTitle(): string {return "paperTitle";}    //论文标题

 /**
 * 常量:"PaperContent"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PaperContent(): string {return "paperContent";}    //主题内容

 /**
 * 常量:"Periodical"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Periodical(): string {return "periodical";}    //期刊

 /**
 * 常量:"Author"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Author(): string {return "author";}    //作者

 /**
 * 常量:"ResearchQuestion"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ResearchQuestion(): string {return "researchQuestion";}    //研究问题

 /**
 * 常量:"Keyword"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Keyword(): string {return "keyword";}    //关键字

 /**
 * 常量:"LiteratureSources"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_LiteratureSources(): string {return "literatureSources";}    //文献来源

 /**
 * 常量:"LiteratureLink"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_LiteratureLink(): string {return "literatureLink";}    //文献链接

 /**
 * 常量:"UploadfileUrl"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UploadfileUrl(): string {return "uploadfileUrl";}    //文件地址

 /**
 * 常量:"IsQuotethesis"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsQuotethesis(): string {return "isQuotethesis";}    //是否引用论文

 /**
 * 常量:"IsSubmit"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsSubmit(): string {return "isSubmit";}    //是否提交

 /**
 * 常量:"IsChecked"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsChecked(): string {return "isChecked";}    //是否检查

 /**
 * 常量:"QuoteId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_QuoteId(): string {return "quoteId";}    //引用Id

 /**
 * 常量:"Checker"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Checker(): string {return "checker";}    //审核人

 /**
 * 常量:"LiteratureTypeId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_LiteratureTypeId(): string {return "literatureTypeId";}    //作文类型Id

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
 * 常量:"id_CurrEduCls"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_CurrEduCls(): string {return "id_CurrEduCls";}    //教学班流水号

 /**
 * 常量:"PaperTypeId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PaperTypeId(): string {return "paperTypeId";}    //论文类型Id

 /**
 * 常量:"PaperStatusId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PaperStatusId(): string {return "paperStatusId";}    //论文状态Id

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