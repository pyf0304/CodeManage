﻿
 /**
 * 类名:clsvPaperSubViewpointEN
 * 表名:vPaperSubViewpoint(01120551)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:54:35
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
 * v子观点表(vPaperSubViewpoint)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTabV } from '../../PubFun/clsGeneralTabV.js';

export class clsvPaperSubViewpointEN extends clsGeneralTabV
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "04"; //sessionStorage
public static IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
public static WhereFormat = ""; //条件格式串
public static _CurrTabName= "vPaperSubViewpoint"; //当前表名,与该类相关的表名
public static _KeyFldName= "SubViewpointId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 38;
public static AttributeName = ["subViewpointId", "paperRWId", "paperId", "paperTitle", "isSubmit", "id_CurrEduCls", "userId", "sectionId", "sectionName", "subViewpointTypeId", "subViewpointTypeName", "defaTitle", "rwTitle", "subViewpointContent", "explainTypeId", "explainTypeName", "explainContent", "isPublic", "literatureSourcesId", "pageNumber", "orderNum", "paperLineNum", "paperPageNum", "appraiseCount", "okCount", "score", "stuScore", "teaScore", "createDate", "shareId", "topicId", "attitudesId", "attitudesName", "updDate", "updUser", "memo", "sectionOrderNum", "subViewpointTypeOrderNum"];
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
case clsvPaperSubViewpointEN.con_SubViewpointId:
return this.subViewpointId;
case clsvPaperSubViewpointEN.con_PaperRWId:
return this.paperRWId;
case clsvPaperSubViewpointEN.con_PaperId:
return this.paperId;
case clsvPaperSubViewpointEN.con_PaperTitle:
return this.paperTitle;
case clsvPaperSubViewpointEN.con_IsSubmit:
return this.isSubmit;
case clsvPaperSubViewpointEN.con_id_CurrEduCls:
return this.id_CurrEduCls;
case clsvPaperSubViewpointEN.con_UserId:
return this.userId;
case clsvPaperSubViewpointEN.con_SectionId:
return this.sectionId;
case clsvPaperSubViewpointEN.con_SectionName:
return this.sectionName;
case clsvPaperSubViewpointEN.con_SubViewpointTypeId:
return this.subViewpointTypeId;
case clsvPaperSubViewpointEN.con_SubViewpointTypeName:
return this.subViewpointTypeName;
case clsvPaperSubViewpointEN.con_DefaTitle:
return this.defaTitle;
case clsvPaperSubViewpointEN.con_RWTitle:
return this.rwTitle;
case clsvPaperSubViewpointEN.con_SubViewpointContent:
return this.subViewpointContent;
case clsvPaperSubViewpointEN.con_ExplainTypeId:
return this.explainTypeId;
case clsvPaperSubViewpointEN.con_ExplainTypeName:
return this.explainTypeName;
case clsvPaperSubViewpointEN.con_ExplainContent:
return this.explainContent;
case clsvPaperSubViewpointEN.con_IsPublic:
return this.isPublic;
case clsvPaperSubViewpointEN.con_LiteratureSourcesId:
return this.literatureSourcesId;
case clsvPaperSubViewpointEN.con_PageNumber:
return this.pageNumber;
case clsvPaperSubViewpointEN.con_OrderNum:
return this.orderNum;
case clsvPaperSubViewpointEN.con_PaperLineNum:
return this.paperLineNum;
case clsvPaperSubViewpointEN.con_PaperPageNum:
return this.paperPageNum;
case clsvPaperSubViewpointEN.con_AppraiseCount:
return this.appraiseCount;
case clsvPaperSubViewpointEN.con_OkCount:
return this.okCount;
case clsvPaperSubViewpointEN.con_Score:
return this.score;
case clsvPaperSubViewpointEN.con_StuScore:
return this.stuScore;
case clsvPaperSubViewpointEN.con_TeaScore:
return this.teaScore;
case clsvPaperSubViewpointEN.con_CreateDate:
return this.createDate;
case clsvPaperSubViewpointEN.con_ShareId:
return this.shareId;
case clsvPaperSubViewpointEN.con_TopicId:
return this.topicId;
case clsvPaperSubViewpointEN.con_AttitudesId:
return this.attitudesId;
case clsvPaperSubViewpointEN.con_AttitudesName:
return this.attitudesName;
case clsvPaperSubViewpointEN.con_UpdDate:
return this.updDate;
case clsvPaperSubViewpointEN.con_UpdUser:
return this.updUser;
case clsvPaperSubViewpointEN.con_Memo:
return this.memo;
case clsvPaperSubViewpointEN.con_SectionOrderNum:
return this.sectionOrderNum;
case clsvPaperSubViewpointEN.con_SubViewpointTypeOrderNum:
return this.subViewpointTypeOrderNum;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[vPaperSubViewpoint]中不存在！`;
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
case clsvPaperSubViewpointEN.con_SubViewpointId:
this.subViewpointId = strValue;
break;
case clsvPaperSubViewpointEN.con_PaperRWId:
this.paperRWId = strValue;
break;
case clsvPaperSubViewpointEN.con_PaperId:
this.paperId = strValue;
break;
case clsvPaperSubViewpointEN.con_PaperTitle:
this.paperTitle = strValue;
break;
case clsvPaperSubViewpointEN.con_IsSubmit:
this.isSubmit = Boolean(strValue);
break;
case clsvPaperSubViewpointEN.con_id_CurrEduCls:
this.id_CurrEduCls = strValue;
break;
case clsvPaperSubViewpointEN.con_UserId:
this.userId = strValue;
break;
case clsvPaperSubViewpointEN.con_SectionId:
this.sectionId = strValue;
break;
case clsvPaperSubViewpointEN.con_SectionName:
this.sectionName = strValue;
break;
case clsvPaperSubViewpointEN.con_SubViewpointTypeId:
this.subViewpointTypeId = strValue;
break;
case clsvPaperSubViewpointEN.con_SubViewpointTypeName:
this.subViewpointTypeName = strValue;
break;
case clsvPaperSubViewpointEN.con_DefaTitle:
this.defaTitle = strValue;
break;
case clsvPaperSubViewpointEN.con_RWTitle:
this.rwTitle = strValue;
break;
case clsvPaperSubViewpointEN.con_SubViewpointContent:
this.subViewpointContent = strValue;
break;
case clsvPaperSubViewpointEN.con_ExplainTypeId:
this.explainTypeId = strValue;
break;
case clsvPaperSubViewpointEN.con_ExplainTypeName:
this.explainTypeName = strValue;
break;
case clsvPaperSubViewpointEN.con_ExplainContent:
this.explainContent = strValue;
break;
case clsvPaperSubViewpointEN.con_IsPublic:
this.isPublic = Boolean(strValue);
break;
case clsvPaperSubViewpointEN.con_LiteratureSourcesId:
this.literatureSourcesId = strValue;
break;
case clsvPaperSubViewpointEN.con_PageNumber:
this.pageNumber = Number(strValue);
break;
case clsvPaperSubViewpointEN.con_OrderNum:
this.orderNum = Number(strValue);
break;
case clsvPaperSubViewpointEN.con_PaperLineNum:
this.paperLineNum = Number(strValue);
break;
case clsvPaperSubViewpointEN.con_PaperPageNum:
this.paperPageNum = Number(strValue);
break;
case clsvPaperSubViewpointEN.con_AppraiseCount:
this.appraiseCount = Number(strValue);
break;
case clsvPaperSubViewpointEN.con_OkCount:
this.okCount = Number(strValue);
break;
case clsvPaperSubViewpointEN.con_Score:
this.score = Number(strValue);
break;
case clsvPaperSubViewpointEN.con_StuScore:
this.stuScore = Number(strValue);
break;
case clsvPaperSubViewpointEN.con_TeaScore:
this.teaScore = Number(strValue);
break;
case clsvPaperSubViewpointEN.con_CreateDate:
this.createDate = strValue;
break;
case clsvPaperSubViewpointEN.con_ShareId:
this.shareId = strValue;
break;
case clsvPaperSubViewpointEN.con_TopicId:
this.topicId = strValue;
break;
case clsvPaperSubViewpointEN.con_AttitudesId:
this.attitudesId = strValue;
break;
case clsvPaperSubViewpointEN.con_AttitudesName:
this.attitudesName = strValue;
break;
case clsvPaperSubViewpointEN.con_UpdDate:
this.updDate = strValue;
break;
case clsvPaperSubViewpointEN.con_UpdUser:
this.updUser = strValue;
break;
case clsvPaperSubViewpointEN.con_Memo:
this.memo = strValue;
break;
case clsvPaperSubViewpointEN.con_SectionOrderNum:
this.sectionOrderNum = Number(strValue);
break;
case clsvPaperSubViewpointEN.con_SubViewpointTypeOrderNum:
this.subViewpointTypeOrderNum = Number(strValue);
break;
case "sf_FldComparisonOp":
this.sf_FldComparisonOp = strValue;
break;
default:
strMsg = `字段名:[${strFldName}]在表对象:[vPaperSubViewpoint]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
console.error(strMsg);
break;
}
}

/**
 * 设置对象中公共属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
*/
public subViewpointId = "";    //子观点Id
public paperRWId = "";    //课文阅读
public paperId = "";    //论文Id
public paperTitle = "";    //论文标题
public isSubmit = false;    //是否提交
public id_CurrEduCls = "";    //教学班流水号
public userId = "";    //用户ID
public sectionId = "";    //节Id
public sectionName = "";    //节名
public subViewpointTypeId = "";    //类型Id
public subViewpointTypeName = "";    //类型名称
public defaTitle = "";    //默认标题
public rwTitle = "";    //读写标题
public subViewpointContent = "";    //详情内容
public explainTypeId = "";    //说明类型Id
public explainTypeName = "";    //说明类型名
public explainContent = "";    //说明内容
public isPublic = false;    //是否公开
public literatureSourcesId = "";    //文献来源
public pageNumber = 0;    //页码
public orderNum = 0;    //序号
public paperLineNum = 0;    //论文行号
public paperPageNum = 0;    //论文页码
public appraiseCount = 0;    //评论数
public okCount = 0;    //点赞统计
public score = 0.0;    //评分
public stuScore = 0.0;    //学生平均分
public teaScore = 0.0;    //教师评分
public createDate = "";    //建立日期
public shareId = "";    //分享Id
public topicId = "";    //主题Id
public attitudesId = "";    //态度Id
public attitudesName = "";    //名称
public updDate = "";    //修改日期
public updUser = "";    //修改人
public memo = "";    //备注
public sectionOrderNum = 0;    //SectionOrderNum
public subViewpointTypeOrderNum = 0;    //子观点类型序号


 /**
 * 常量:"SubViewpointId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SubViewpointId(): string {return "subViewpointId";}    //子观点Id

 /**
 * 常量:"PaperRWId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PaperRWId(): string {return "paperRWId";}    //课文阅读

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
 * 常量:"IsSubmit"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsSubmit(): string {return "isSubmit";}    //是否提交

 /**
 * 常量:"id_CurrEduCls"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_CurrEduCls(): string {return "id_CurrEduCls";}    //教学班流水号

 /**
 * 常量:"UserId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UserId(): string {return "userId";}    //用户ID

 /**
 * 常量:"SectionId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SectionId(): string {return "sectionId";}    //节Id

 /**
 * 常量:"SectionName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SectionName(): string {return "sectionName";}    //节名

 /**
 * 常量:"SubViewpointTypeId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SubViewpointTypeId(): string {return "subViewpointTypeId";}    //类型Id

 /**
 * 常量:"SubViewpointTypeName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SubViewpointTypeName(): string {return "subViewpointTypeName";}    //类型名称

 /**
 * 常量:"DefaTitle"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_DefaTitle(): string {return "defaTitle";}    //默认标题

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
 * 常量:"ExplainTypeId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ExplainTypeId(): string {return "explainTypeId";}    //说明类型Id

 /**
 * 常量:"ExplainTypeName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ExplainTypeName(): string {return "explainTypeName";}    //说明类型名

 /**
 * 常量:"ExplainContent"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ExplainContent(): string {return "explainContent";}    //说明内容

 /**
 * 常量:"IsPublic"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsPublic(): string {return "isPublic";}    //是否公开

 /**
 * 常量:"LiteratureSourcesId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_LiteratureSourcesId(): string {return "literatureSourcesId";}    //文献来源

 /**
 * 常量:"PageNumber"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PageNumber(): string {return "pageNumber";}    //页码

 /**
 * 常量:"OrderNum"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_OrderNum(): string {return "orderNum";}    //序号

 /**
 * 常量:"PaperLineNum"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PaperLineNum(): string {return "paperLineNum";}    //论文行号

 /**
 * 常量:"PaperPageNum"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PaperPageNum(): string {return "paperPageNum";}    //论文页码

 /**
 * 常量:"AppraiseCount"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_AppraiseCount(): string {return "appraiseCount";}    //评论数

 /**
 * 常量:"OkCount"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_OkCount(): string {return "okCount";}    //点赞统计

 /**
 * 常量:"Score"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Score(): string {return "score";}    //评分

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
 * 常量:"TopicId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_TopicId(): string {return "topicId";}    //主题Id

 /**
 * 常量:"AttitudesId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_AttitudesId(): string {return "attitudesId";}    //态度Id

 /**
 * 常量:"AttitudesName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_AttitudesName(): string {return "attitudesName";}    //名称

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
 * 常量:"Memo"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Memo(): string {return "memo";}    //备注

 /**
 * 常量:"SectionOrderNum"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SectionOrderNum(): string {return "sectionOrderNum";}    //SectionOrderNum

 /**
 * 常量:"SubViewpointTypeOrderNum"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SubViewpointTypeOrderNum(): string {return "subViewpointTypeOrderNum";}    //子观点类型序号

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