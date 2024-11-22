
 /**
 * 类名:clsViewpointVEN
 * 表名:ViewpointV(01120650)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:47:00
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
 * 观点版本表(ViewpointV)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTab } from '../../PubFun/clsGeneralTab.js';

export class clsViewpointVEN extends clsGeneralTab
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "05"; //未知
public static _CurrTabName= "ViewpointV"; //当前表名,与该类相关的表名
public static _KeyFldName= "ViewpointVId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 16;
public static AttributeName = ["viewpointVId", "viewpointId", "viewpointName", "viewpointContent", "viewpointTypeId", "reason", "source", "vpProposePeople", "userTypeId", "citationId", "updDate", "updUser", "pdfContent", "pdfPageNum", "id_CurrEduCls", "memo"];
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
private mlngViewpointVId = 0;    //ViewpointVId
private mstrViewpointId = "";    //观点Id
private mstrViewpointName = "";    //观点名称
private mstrViewpointContent = "";    //观点内容
private mstrViewpointTypeId = "";    //观点类型Id
private mstrReason = "";    //理由
private mstrSource = "";    //来源
private mstrVPProposePeople = "";    //观点提出人
private mstrUserTypeId = "";    //用户类型Id
private mstrCitationId = "";    //引用Id
private mstrUpdDate = "";    //修改日期
private mstrUpdUser = "";    //修改人
private mstrPdfContent = "";    //Pdf内容
private mintPdfPageNum = 0;    //Pdf页码
private mstrid_CurrEduCls = "";    //教学班流水号
private mstrMemo = "";    //备注

/**
 * ViewpointVId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetViewpointVId (value: number)
{
if (value  != undefined)
{
 this.viewpointVId = value;
    this.hmProperty["viewpointVId"] = true;
}
}

/**
 * 观点Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetViewpointId (value: string)
{
if (value  != undefined)
{
 this.viewpointId = value;
    this.hmProperty["viewpointId"] = true;
}
}

/**
 * 观点名称(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetViewpointName (value: string)
{
if (value  != undefined)
{
 this.viewpointName = value;
    this.hmProperty["viewpointName"] = true;
}
}

/**
 * 观点内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetViewpointContent (value: string)
{
if (value  != undefined)
{
 this.viewpointContent = value;
    this.hmProperty["viewpointContent"] = true;
}
}

/**
 * 观点类型Id(说明:;字段类型:char;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetViewpointTypeId (value: string)
{
if (value  != undefined)
{
 this.viewpointTypeId = value;
    this.hmProperty["viewpointTypeId"] = true;
}
}

/**
 * 理由(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetReason (value: string)
{
if (value  != undefined)
{
 this.reason = value;
    this.hmProperty["reason"] = true;
}
}

/**
 * 来源(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetSource (value: string)
{
if (value  != undefined)
{
 this.source = value;
    this.hmProperty["source"] = true;
}
}

/**
 * 观点提出人(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetVPProposePeople (value: string)
{
if (value  != undefined)
{
 this.vpProposePeople = value;
    this.hmProperty["vpProposePeople"] = true;
}
}

/**
 * 用户类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetUserTypeId (value: string)
{
if (value  != undefined)
{
 this.userTypeId = value;
    this.hmProperty["userTypeId"] = true;
}
}

/**
 * 引用Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetCitationId (value: string)
{
if (value  != undefined)
{
 this.citationId = value;
    this.hmProperty["citationId"] = true;
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
case clsViewpointVEN.con_ViewpointVId:
return this.viewpointVId;
case clsViewpointVEN.con_ViewpointId:
return this.viewpointId;
case clsViewpointVEN.con_ViewpointName:
return this.viewpointName;
case clsViewpointVEN.con_ViewpointContent:
return this.viewpointContent;
case clsViewpointVEN.con_ViewpointTypeId:
return this.viewpointTypeId;
case clsViewpointVEN.con_Reason:
return this.reason;
case clsViewpointVEN.con_Source:
return this.source;
case clsViewpointVEN.con_VPProposePeople:
return this.vpProposePeople;
case clsViewpointVEN.con_UserTypeId:
return this.userTypeId;
case clsViewpointVEN.con_CitationId:
return this.citationId;
case clsViewpointVEN.con_UpdDate:
return this.updDate;
case clsViewpointVEN.con_UpdUser:
return this.updUser;
case clsViewpointVEN.con_PdfContent:
return this.pdfContent;
case clsViewpointVEN.con_PdfPageNum:
return this.pdfPageNum;
case clsViewpointVEN.con_id_CurrEduCls:
return this.id_CurrEduCls;
case clsViewpointVEN.con_Memo:
return this.memo;
case "sf_UpdFldSetStr":
return this.sf_UpdFldSetStr;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[ViewpointV]中不存在！`;
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
case clsViewpointVEN.con_ViewpointVId:
this.viewpointVId = Number(strValue);
    this.hmProperty["viewpointVId"] = true;
break;
case clsViewpointVEN.con_ViewpointId:
this.viewpointId = strValue;
    this.hmProperty["viewpointId"] = true;
break;
case clsViewpointVEN.con_ViewpointName:
this.viewpointName = strValue;
    this.hmProperty["viewpointName"] = true;
break;
case clsViewpointVEN.con_ViewpointContent:
this.viewpointContent = strValue;
    this.hmProperty["viewpointContent"] = true;
break;
case clsViewpointVEN.con_ViewpointTypeId:
this.viewpointTypeId = strValue;
    this.hmProperty["viewpointTypeId"] = true;
break;
case clsViewpointVEN.con_Reason:
this.reason = strValue;
    this.hmProperty["reason"] = true;
break;
case clsViewpointVEN.con_Source:
this.source = strValue;
    this.hmProperty["source"] = true;
break;
case clsViewpointVEN.con_VPProposePeople:
this.vpProposePeople = strValue;
    this.hmProperty["vpProposePeople"] = true;
break;
case clsViewpointVEN.con_UserTypeId:
this.userTypeId = strValue;
    this.hmProperty["userTypeId"] = true;
break;
case clsViewpointVEN.con_CitationId:
this.citationId = strValue;
    this.hmProperty["citationId"] = true;
break;
case clsViewpointVEN.con_UpdDate:
this.updDate = strValue;
    this.hmProperty["updDate"] = true;
break;
case clsViewpointVEN.con_UpdUser:
this.updUser = strValue;
    this.hmProperty["updUser"] = true;
break;
case clsViewpointVEN.con_PdfContent:
this.pdfContent = strValue;
    this.hmProperty["pdfContent"] = true;
break;
case clsViewpointVEN.con_PdfPageNum:
this.pdfPageNum = Number(strValue);
    this.hmProperty["pdfPageNum"] = true;
break;
case clsViewpointVEN.con_id_CurrEduCls:
this.id_CurrEduCls = strValue;
    this.hmProperty["id_CurrEduCls"] = true;
break;
case clsViewpointVEN.con_Memo:
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
strMsg = `字段名:[${strFldName}]在表对象:[ViewpointV]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
console.error(strMsg);
break;
}
}

/**
 * 设置对象中公共属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
*/
public viewpointVId = 0;    //ViewpointVId
public viewpointId = "";    //观点Id
public viewpointName = "";    //观点名称
public viewpointContent = "";    //观点内容
public viewpointTypeId = "";    //观点类型Id
public reason = "";    //理由
public source = "";    //来源
public vpProposePeople = "";    //观点提出人
public userTypeId = "";    //用户类型Id
public citationId = "";    //引用Id
public updDate = "";    //修改日期
public updUser = "";    //修改人
public pdfContent = "";    //Pdf内容
public pdfPageNum = 0;    //Pdf页码
public id_CurrEduCls = "";    //教学班流水号
public memo = "";    //备注


 /**
 * 常量:"ViewpointVId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ViewpointVId(): string {return "viewpointVId";}    //ViewpointVId

 /**
 * 常量:"ViewpointId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ViewpointId(): string {return "viewpointId";}    //观点Id

 /**
 * 常量:"ViewpointName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ViewpointName(): string {return "viewpointName";}    //观点名称

 /**
 * 常量:"ViewpointContent"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ViewpointContent(): string {return "viewpointContent";}    //观点内容

 /**
 * 常量:"ViewpointTypeId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ViewpointTypeId(): string {return "viewpointTypeId";}    //观点类型Id

 /**
 * 常量:"Reason"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Reason(): string {return "reason";}    //理由

 /**
 * 常量:"Source"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Source(): string {return "source";}    //来源

 /**
 * 常量:"VPProposePeople"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_VPProposePeople(): string {return "vpProposePeople";}    //观点提出人

 /**
 * 常量:"UserTypeId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UserTypeId(): string {return "userTypeId";}    //用户类型Id

 /**
 * 常量:"CitationId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CitationId(): string {return "citationId";}    //引用Id

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
 * 常量:"id_CurrEduCls"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_CurrEduCls(): string {return "id_CurrEduCls";}    //教学班流水号

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