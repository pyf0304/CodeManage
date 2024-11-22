
 /**
 * 类名:clsvRTSysSkillEN
 * 表名:vRTSysSkill(01120656)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 12:02:54
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
 * vRTSysSkill(vRTSysSkill)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTabV } from '../../PubFun/clsGeneralTabV.js';

export class clsvRTSysSkillEN extends clsGeneralTabV
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "02"; //客户端缓存
public static _CurrTabName= "vRTSysSkill"; //当前表名,与该类相关的表名
public static _KeyFldName= "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 33;
public static AttributeName = ["topicName", "skillName", "operationTypeId", "process", "levelId", "levelName", "skillUpdUser", "skillUpdDate", "orderNum", "id_CurrEduCls", "topicProposePeople", "topicContent", "isSubmit", "appraiseCount", "score", "stuScore", "teaScore", "pdfContent", "pdfPageNum", "citationCount", "versionCount", "operationTypeName", "okCount", "citationId", "mId", "topicId", "skillId", "updDate", "memo", "updUser", "createDate", "shareId", "classificationId"];
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
case clsvRTSysSkillEN.con_TopicName:
return this.topicName;
case clsvRTSysSkillEN.con_SkillName:
return this.skillName;
case clsvRTSysSkillEN.con_OperationTypeId:
return this.operationTypeId;
case clsvRTSysSkillEN.con_Process:
return this.process;
case clsvRTSysSkillEN.con_LevelId:
return this.levelId;
case clsvRTSysSkillEN.con_LevelName:
return this.levelName;
case clsvRTSysSkillEN.con_SkillUpdUser:
return this.skillUpdUser;
case clsvRTSysSkillEN.con_SkillUpdDate:
return this.skillUpdDate;
case clsvRTSysSkillEN.con_OrderNum:
return this.orderNum;
case clsvRTSysSkillEN.con_id_CurrEduCls:
return this.id_CurrEduCls;
case clsvRTSysSkillEN.con_TopicProposePeople:
return this.topicProposePeople;
case clsvRTSysSkillEN.con_TopicContent:
return this.topicContent;
case clsvRTSysSkillEN.con_IsSubmit:
return this.isSubmit;
case clsvRTSysSkillEN.con_AppraiseCount:
return this.appraiseCount;
case clsvRTSysSkillEN.con_score:
return this.score;
case clsvRTSysSkillEN.con_StuScore:
return this.stuScore;
case clsvRTSysSkillEN.con_TeaScore:
return this.teaScore;
case clsvRTSysSkillEN.con_PdfContent:
return this.pdfContent;
case clsvRTSysSkillEN.con_PdfPageNum:
return this.pdfPageNum;
case clsvRTSysSkillEN.con_CitationCount:
return this.citationCount;
case clsvRTSysSkillEN.con_VersionCount:
return this.versionCount;
case clsvRTSysSkillEN.con_OperationTypeName:
return this.operationTypeName;
case clsvRTSysSkillEN.con_OkCount:
return this.okCount;
case clsvRTSysSkillEN.con_CitationId:
return this.citationId;
case clsvRTSysSkillEN.con_mId:
return this.mId;
case clsvRTSysSkillEN.con_TopicId:
return this.topicId;
case clsvRTSysSkillEN.con_SkillId:
return this.skillId;
case clsvRTSysSkillEN.con_UpdDate:
return this.updDate;
case clsvRTSysSkillEN.con_Memo:
return this.memo;
case clsvRTSysSkillEN.con_UpdUser:
return this.updUser;
case clsvRTSysSkillEN.con_CreateDate:
return this.createDate;
case clsvRTSysSkillEN.con_ShareId:
return this.shareId;
case clsvRTSysSkillEN.con_ClassificationId:
return this.classificationId;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[vRTSysSkill]中不存在！`;
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
case clsvRTSysSkillEN.con_TopicName:
this.topicName = strValue;
break;
case clsvRTSysSkillEN.con_SkillName:
this.skillName = strValue;
break;
case clsvRTSysSkillEN.con_OperationTypeId:
this.operationTypeId = strValue;
break;
case clsvRTSysSkillEN.con_Process:
this.process = strValue;
break;
case clsvRTSysSkillEN.con_LevelId:
this.levelId = strValue;
break;
case clsvRTSysSkillEN.con_LevelName:
this.levelName = strValue;
break;
case clsvRTSysSkillEN.con_SkillUpdUser:
this.skillUpdUser = strValue;
break;
case clsvRTSysSkillEN.con_SkillUpdDate:
this.skillUpdDate = strValue;
break;
case clsvRTSysSkillEN.con_OrderNum:
this.orderNum = Number(strValue);
break;
case clsvRTSysSkillEN.con_id_CurrEduCls:
this.id_CurrEduCls = strValue;
break;
case clsvRTSysSkillEN.con_TopicProposePeople:
this.topicProposePeople = strValue;
break;
case clsvRTSysSkillEN.con_TopicContent:
this.topicContent = strValue;
break;
case clsvRTSysSkillEN.con_IsSubmit:
this.isSubmit = Boolean(strValue);
break;
case clsvRTSysSkillEN.con_AppraiseCount:
this.appraiseCount = Number(strValue);
break;
case clsvRTSysSkillEN.con_score:
this.score = Number(strValue);
break;
case clsvRTSysSkillEN.con_StuScore:
this.stuScore = Number(strValue);
break;
case clsvRTSysSkillEN.con_TeaScore:
this.teaScore = Number(strValue);
break;
case clsvRTSysSkillEN.con_PdfContent:
this.pdfContent = strValue;
break;
case clsvRTSysSkillEN.con_PdfPageNum:
this.pdfPageNum = Number(strValue);
break;
case clsvRTSysSkillEN.con_CitationCount:
this.citationCount = Number(strValue);
break;
case clsvRTSysSkillEN.con_VersionCount:
this.versionCount = Number(strValue);
break;
case clsvRTSysSkillEN.con_OperationTypeName:
this.operationTypeName = strValue;
break;
case clsvRTSysSkillEN.con_OkCount:
this.okCount = Number(strValue);
break;
case clsvRTSysSkillEN.con_CitationId:
this.citationId = strValue;
break;
case clsvRTSysSkillEN.con_mId:
this.mId = Number(strValue);
break;
case clsvRTSysSkillEN.con_TopicId:
this.topicId = strValue;
break;
case clsvRTSysSkillEN.con_SkillId:
this.skillId = strValue;
break;
case clsvRTSysSkillEN.con_UpdDate:
this.updDate = strValue;
break;
case clsvRTSysSkillEN.con_Memo:
this.memo = strValue;
break;
case clsvRTSysSkillEN.con_UpdUser:
this.updUser = strValue;
break;
case clsvRTSysSkillEN.con_CreateDate:
this.createDate = strValue;
break;
case clsvRTSysSkillEN.con_ShareId:
this.shareId = strValue;
break;
case clsvRTSysSkillEN.con_ClassificationId:
this.classificationId = strValue;
break;
case "sf_FldComparisonOp":
this.sf_FldComparisonOp = strValue;
break;
default:
strMsg = `字段名:[${strFldName}]在表对象:[vRTSysSkill]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
console.error(strMsg);
break;
}
}

/**
 * 设置对象中公共属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
*/
public topicName = "";    //栏目主题
public skillName = "";    //技能名称
public operationTypeId = "";    //操作类型ID
public process = "";    //实施过程
public levelId = "";    //级别Id
public levelName = "";    //级别名称
public skillUpdUser = "";    //SkillUpdUser
public skillUpdDate = "";    //SkillUpdDate
public orderNum = 0;    //序号
public id_CurrEduCls = "";    //教学班流水号
public topicProposePeople = "";    //主题提出人
public topicContent = "";    //主题内容
public isSubmit = false;    //是否提交
public appraiseCount = 0;    //评论数
public score = 0.0;    //评分
public stuScore = 0.0;    //学生平均分
public teaScore = 0.0;    //教师评分
public pdfContent = "";    //Pdf内容
public pdfPageNum = 0;    //Pdf页码
public citationCount = 0;    //引用统计
public versionCount = 0;    //版本统计
public operationTypeName = "";    //操作类型名
public okCount = 0;    //点赞统计
public citationId = "";    //引用Id
public mId = 0;    //mId
public topicId = "";    //主题Id
public skillId = "";    //技能Id
public updDate = "";    //修改日期
public memo = "";    //备注
public updUser = "";    //修改人
public createDate = "";    //建立日期
public shareId = "";    //分享Id
public classificationId = "";    //分类Id


 /**
 * 常量:"TopicName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_TopicName(): string {return "topicName";}    //栏目主题

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
 * 常量:"LevelName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_LevelName(): string {return "levelName";}    //级别名称

 /**
 * 常量:"SkillUpdUser"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SkillUpdUser(): string {return "skillUpdUser";}    //SkillUpdUser

 /**
 * 常量:"SkillUpdDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SkillUpdDate(): string {return "skillUpdDate";}    //SkillUpdDate

 /**
 * 常量:"OrderNum"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_OrderNum(): string {return "orderNum";}    //序号

 /**
 * 常量:"id_CurrEduCls"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_CurrEduCls(): string {return "id_CurrEduCls";}    //教学班流水号

 /**
 * 常量:"TopicProposePeople"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_TopicProposePeople(): string {return "topicProposePeople";}    //主题提出人

 /**
 * 常量:"TopicContent"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_TopicContent(): string {return "topicContent";}    //主题内容

 /**
 * 常量:"IsSubmit"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsSubmit(): string {return "isSubmit";}    //是否提交

 /**
 * 常量:"AppraiseCount"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_AppraiseCount(): string {return "appraiseCount";}    //评论数

 /**
 * 常量:"score"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_score(): string {return "score";}    //评分

 /**
 * 常量:"StuScore"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_StuScore(): string {return "stuScore";}    //学生平均分

 /**
 * 常量:"TeaScore"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_TeaScore(): string {return "teaScore";}    //教师评分

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
 * 常量:"CitationCount"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CitationCount(): string {return "citationCount";}    //引用统计

 /**
 * 常量:"VersionCount"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_VersionCount(): string {return "versionCount";}    //版本统计

 /**
 * 常量:"OperationTypeName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_OperationTypeName(): string {return "operationTypeName";}    //操作类型名

 /**
 * 常量:"OkCount"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_OkCount(): string {return "okCount";}    //点赞统计

 /**
 * 常量:"CitationId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CitationId(): string {return "citationId";}    //引用Id

 /**
 * 常量:"mId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_mId(): string {return "mId";}    //mId

 /**
 * 常量:"TopicId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_TopicId(): string {return "topicId";}    //主题Id

 /**
 * 常量:"SkillId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SkillId(): string {return "skillId";}    //技能Id

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
 * 常量:"UpdUser"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UpdUser(): string {return "updUser";}    //修改人

 /**
 * 常量:"CreateDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CreateDate(): string {return "createDate";}    //建立日期

 /**
 * 常量:"ShareId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ShareId(): string {return "shareId";}    //分享Id

 /**
 * 常量:"ClassificationId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ClassificationId(): string {return "classificationId";}    //分类Id

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