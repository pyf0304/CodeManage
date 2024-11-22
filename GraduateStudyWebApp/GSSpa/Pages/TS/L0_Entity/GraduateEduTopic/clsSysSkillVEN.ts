
 /**
 * 类名:clsSysSkillVEN
 * 表名:SysSkillV(01120647)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:58
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
 * SysSkillV(SysSkillV)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTab } from '../../PubFun/clsGeneralTab.js';

export class clsSysSkillVEN extends clsGeneralTab
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "05"; //未知
public static _CurrTabName= "SysSkillV"; //当前表名,与该类相关的表名
public static _KeyFldName= "SkillVId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 13;
public static AttributeName = ["skillVId", "skillId", "skillName", "operationTypeId", "process", "levelId", "updUser", "updDate", "citationId", "id_CurrEduCls", "pdfContent", "pdfPageNum", "memo"];
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
private mlngSkillVId = 0;    //SkillVId
private mstrSkillId = "";    //技能Id
private mstrSkillName = "";    //技能名称
private mstrOperationTypeId = "";    //操作类型ID
private mstrProcess = "";    //实施过程
private mstrLevelId = "";    //级别Id
private mstrUpdUser = "";    //修改人
private mstrUpdDate = "";    //修改日期
private mstrCitationId = "";    //引用Id
private mstrid_CurrEduCls = "";    //教学班流水号
private mstrPdfContent = "";    //Pdf内容
private mintPdfPageNum = 0;    //Pdf页码
private mstrMemo = "";    //备注

/**
 * SkillVId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetSkillVId (value: number)
{
if (value  != undefined)
{
 this.skillVId = value;
    this.hmProperty["skillVId"] = true;
}
}

/**
 * 技能Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetSkillId (value: string)
{
if (value  != undefined)
{
 this.skillId = value;
    this.hmProperty["skillId"] = true;
}
}

/**
 * 技能名称(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetSkillName (value: string)
{
if (value  != undefined)
{
 this.skillName = value;
    this.hmProperty["skillName"] = true;
}
}

/**
 * 操作类型ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetOperationTypeId (value: string)
{
if (value  != undefined)
{
 this.operationTypeId = value;
    this.hmProperty["operationTypeId"] = true;
}
}

/**
 * 实施过程(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetProcess (value: string)
{
if (value  != undefined)
{
 this.process = value;
    this.hmProperty["process"] = true;
}
}

/**
 * 级别Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetLevelId (value: string)
{
if (value  != undefined)
{
 this.levelId = value;
    this.hmProperty["levelId"] = true;
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
case clsSysSkillVEN.con_SkillVId:
return this.skillVId;
case clsSysSkillVEN.con_SkillId:
return this.skillId;
case clsSysSkillVEN.con_SkillName:
return this.skillName;
case clsSysSkillVEN.con_OperationTypeId:
return this.operationTypeId;
case clsSysSkillVEN.con_Process:
return this.process;
case clsSysSkillVEN.con_LevelId:
return this.levelId;
case clsSysSkillVEN.con_UpdUser:
return this.updUser;
case clsSysSkillVEN.con_UpdDate:
return this.updDate;
case clsSysSkillVEN.con_CitationId:
return this.citationId;
case clsSysSkillVEN.con_id_CurrEduCls:
return this.id_CurrEduCls;
case clsSysSkillVEN.con_PdfContent:
return this.pdfContent;
case clsSysSkillVEN.con_PdfPageNum:
return this.pdfPageNum;
case clsSysSkillVEN.con_Memo:
return this.memo;
case "sf_UpdFldSetStr":
return this.sf_UpdFldSetStr;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[SysSkillV]中不存在！`;
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
case clsSysSkillVEN.con_SkillVId:
this.skillVId = Number(strValue);
    this.hmProperty["skillVId"] = true;
break;
case clsSysSkillVEN.con_SkillId:
this.skillId = strValue;
    this.hmProperty["skillId"] = true;
break;
case clsSysSkillVEN.con_SkillName:
this.skillName = strValue;
    this.hmProperty["skillName"] = true;
break;
case clsSysSkillVEN.con_OperationTypeId:
this.operationTypeId = strValue;
    this.hmProperty["operationTypeId"] = true;
break;
case clsSysSkillVEN.con_Process:
this.process = strValue;
    this.hmProperty["process"] = true;
break;
case clsSysSkillVEN.con_LevelId:
this.levelId = strValue;
    this.hmProperty["levelId"] = true;
break;
case clsSysSkillVEN.con_UpdUser:
this.updUser = strValue;
    this.hmProperty["updUser"] = true;
break;
case clsSysSkillVEN.con_UpdDate:
this.updDate = strValue;
    this.hmProperty["updDate"] = true;
break;
case clsSysSkillVEN.con_CitationId:
this.citationId = strValue;
    this.hmProperty["citationId"] = true;
break;
case clsSysSkillVEN.con_id_CurrEduCls:
this.id_CurrEduCls = strValue;
    this.hmProperty["id_CurrEduCls"] = true;
break;
case clsSysSkillVEN.con_PdfContent:
this.pdfContent = strValue;
    this.hmProperty["pdfContent"] = true;
break;
case clsSysSkillVEN.con_PdfPageNum:
this.pdfPageNum = Number(strValue);
    this.hmProperty["pdfPageNum"] = true;
break;
case clsSysSkillVEN.con_Memo:
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
strMsg = `字段名:[${strFldName}]在表对象:[SysSkillV]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
console.error(strMsg);
break;
}
}

/**
 * 设置对象中公共属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
*/
public skillVId = 0;    //SkillVId
public skillId = "";    //技能Id
public skillName = "";    //技能名称
public operationTypeId = "";    //操作类型ID
public process = "";    //实施过程
public levelId = "";    //级别Id
public updUser = "";    //修改人
public updDate = "";    //修改日期
public citationId = "";    //引用Id
public id_CurrEduCls = "";    //教学班流水号
public pdfContent = "";    //Pdf内容
public pdfPageNum = 0;    //Pdf页码
public memo = "";    //备注


 /**
 * 常量:"SkillVId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SkillVId(): string {return "skillVId";}    //SkillVId

 /**
 * 常量:"SkillId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SkillId(): string {return "skillId";}    //技能Id

 /**
 * 常量:"SkillName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SkillName(): string {return "skillName";}    //技能名称

 /**
 * 常量:"OperationTypeId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_OperationTypeId(): string {return "operationTypeId";}    //操作类型ID

 /**
 * 常量:"Process"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Process(): string {return "process";}    //实施过程

 /**
 * 常量:"LevelId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_LevelId(): string {return "levelId";}    //级别Id

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
 * 常量:"CitationId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CitationId(): string {return "citationId";}    //引用Id

 /**
 * 常量:"id_CurrEduCls"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_CurrEduCls(): string {return "id_CurrEduCls";}    //教学班流水号

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