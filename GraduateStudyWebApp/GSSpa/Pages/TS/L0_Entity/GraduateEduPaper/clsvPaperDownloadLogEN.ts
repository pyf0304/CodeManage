
 /**
 * 类名:clsvPaperDownloadLogEN
 * 表名:vPaperDownloadLog(01120572)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 12:02:40
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
 * v论文下载记录(vPaperDownloadLog)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTabV } from '../../PubFun/clsGeneralTabV.js';

export class clsvPaperDownloadLogEN extends clsGeneralTabV
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "05"; //未知
public static _CurrTabName= "vPaperDownloadLog"; //当前表名,与该类相关的表名
public static _KeyFldName= "PaperDownloadId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 11;
public static AttributeName = ["paperDownloadId", "downloadFile", "downloadLink", "paperId", "updUser", "updDate", "memo", "paperTitle", "author", "keyword", "userName"];
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
case clsvPaperDownloadLogEN.con_PaperDownloadId:
return this.paperDownloadId;
case clsvPaperDownloadLogEN.con_DownloadFile:
return this.downloadFile;
case clsvPaperDownloadLogEN.con_DownloadLink:
return this.downloadLink;
case clsvPaperDownloadLogEN.con_PaperId:
return this.paperId;
case clsvPaperDownloadLogEN.con_UpdUser:
return this.updUser;
case clsvPaperDownloadLogEN.con_UpdDate:
return this.updDate;
case clsvPaperDownloadLogEN.con_Memo:
return this.memo;
case clsvPaperDownloadLogEN.con_PaperTitle:
return this.paperTitle;
case clsvPaperDownloadLogEN.con_Author:
return this.author;
case clsvPaperDownloadLogEN.con_Keyword:
return this.keyword;
case clsvPaperDownloadLogEN.con_UserName:
return this.userName;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[vPaperDownloadLog]中不存在！`;
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
case clsvPaperDownloadLogEN.con_PaperDownloadId:
this.paperDownloadId = Number(strValue);
break;
case clsvPaperDownloadLogEN.con_DownloadFile:
this.downloadFile = strValue;
break;
case clsvPaperDownloadLogEN.con_DownloadLink:
this.downloadLink = strValue;
break;
case clsvPaperDownloadLogEN.con_PaperId:
this.paperId = strValue;
break;
case clsvPaperDownloadLogEN.con_UpdUser:
this.updUser = strValue;
break;
case clsvPaperDownloadLogEN.con_UpdDate:
this.updDate = strValue;
break;
case clsvPaperDownloadLogEN.con_Memo:
this.memo = strValue;
break;
case clsvPaperDownloadLogEN.con_PaperTitle:
this.paperTitle = strValue;
break;
case clsvPaperDownloadLogEN.con_Author:
this.author = strValue;
break;
case clsvPaperDownloadLogEN.con_Keyword:
this.keyword = strValue;
break;
case clsvPaperDownloadLogEN.con_UserName:
this.userName = strValue;
break;
case "sf_FldComparisonOp":
this.sf_FldComparisonOp = strValue;
break;
default:
strMsg = `字段名:[${strFldName}]在表对象:[vPaperDownloadLog]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
console.error(strMsg);
break;
}
}

/**
 * 设置对象中公共属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
*/
public paperDownloadId = 0;    //PaperDownloadId
public downloadFile = "";    //DownloadFile
public downloadLink = "";    //DownloadLink
public paperId = "";    //论文Id
public updUser = "";    //修改人
public updDate = "";    //修改日期
public memo = "";    //备注
public paperTitle = "";    //论文标题
public author = "";    //作者
public keyword = "";    //关键字
public userName = "";    //用户名


 /**
 * 常量:"PaperDownloadId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PaperDownloadId(): string {return "paperDownloadId";}    //PaperDownloadId

 /**
 * 常量:"DownloadFile"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_DownloadFile(): string {return "downloadFile";}    //DownloadFile

 /**
 * 常量:"DownloadLink"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_DownloadLink(): string {return "downloadLink";}    //DownloadLink

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
 * 常量:"PaperTitle"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PaperTitle(): string {return "paperTitle";}    //论文标题

 /**
 * 常量:"Author"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Author(): string {return "author";}    //作者

 /**
 * 常量:"Keyword"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Keyword(): string {return "keyword";}    //关键字

 /**
 * 常量:"UserName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UserName(): string {return "userName";}    //用户名

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