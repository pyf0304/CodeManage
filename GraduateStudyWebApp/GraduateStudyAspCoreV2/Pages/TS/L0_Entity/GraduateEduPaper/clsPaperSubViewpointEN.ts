
 /**
 * 类名:clsPaperSubViewpointEN
 * 表名:PaperSubViewpoint(01120534)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/13 00:54:22
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
 * 子观点表(PaperSubViewpoint)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTab } from '../../PubFun/clsGeneralTab.js';

export class clsPaperSubViewpointEN extends clsGeneralTab
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "04"; //sessionStorage
public static IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
public static WhereFormat = ""; //条件格式串
public static _CurrTabName= "PaperSubViewpoint"; //当前表名,与该类相关的表名
public static _KeyFldName= "SubViewpointId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 29;
public static AttributeName = ["subViewpointId", "paperRWId", "paperId", "id_CurrEduCls", "userId", "sectionId", "subViewpointTypeId", "rwTitle", "subViewpointContent", "explainTypeId", "explainContent", "isPublic", "literatureSourcesId", "pageNumber", "orderNum", "paperLineNum", "paperPageNum", "appraiseCount", "okCount", "score", "stuScore", "teaScore", "createDate", "shareId", "topicId", "attitudesId", "updDate", "updUser", "memo"];
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
private mstrSubViewpointId = "";    //子观点Id
private mstrPaperRWId = "";    //课文阅读
private mstrPaperId = "";    //论文Id
private mstrid_CurrEduCls = "";    //教学班流水号
private mstrUserId = "";    //用户ID
private mstrSectionId = "";    //节Id
private mstrSubViewpointTypeId = "";    //类型Id
private mstrRWTitle = "";    //读写标题
private mstrSubViewpointContent = "";    //详情内容
private mstrExplainTypeId = "";    //说明类型Id
private mstrExplainContent = "";    //说明内容
private mbolIsPublic = false;    //是否公开
private mstrLiteratureSourcesId = "";    //文献来源
private mintPageNumber = 0;    //页码
private mintOrderNum = 0;    //序号
private mintPaperLineNum = 0;    //论文行号
private mintPaperPageNum = 0;    //论文页码
private mintAppraiseCount = 0;    //评论数
private mintOkCount = 0;    //点赞统计
private mfltScore = 0.0;    //评分
private mfltStuScore = 0.0;    //学生平均分
private mfltTeaScore = 0.0;    //教师评分
private mstrCreateDate = "";    //建立日期
private mstrShareId = "";    //分享Id
private mstrTopicId = "";    //主题Id
private mstrAttitudesId = "";    //态度Id
private mstrUpdDate = "";    //修改日期
private mstrUpdUser = "";    //修改人
private mstrMemo = "";    //备注

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
 * 用户ID(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetUserId (value: string)
{
if (value  != undefined)
{
 this.userId = value;
    this.hmProperty["userId"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 节Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetSectionId (value: string)
{
if (value  != undefined)
{
 this.sectionId = value;
    this.hmProperty["sectionId"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 类型Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetSubViewpointTypeId (value: string)
{
if (value  != undefined)
{
 this.subViewpointTypeId = value;
    this.hmProperty["subViewpointTypeId"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 读写标题(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetRWTitle (value: string)
{
if (value  != undefined)
{
 this.rwTitle = value;
    this.hmProperty["rwTitle"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 详情内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetSubViewpointContent (value: string)
{
if (value  != undefined)
{
 this.subViewpointContent = value;
    this.hmProperty["subViewpointContent"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 说明类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetExplainTypeId (value: string)
{
if (value  != undefined)
{
 this.explainTypeId = value;
    this.hmProperty["explainTypeId"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 说明内容(说明:;字段类型:varchar;字段长度:5000;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetExplainContent (value: string)
{
if (value  != undefined)
{
 this.explainContent = value;
    this.hmProperty["explainContent"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 是否公开(说明:;字段类型:bit;字段长度:1;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetIsPublic (value: boolean)
{
if (value  != undefined)
{
 this.isPublic = value;
    this.hmProperty["isPublic"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 文献来源(说明:;字段类型:char;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetLiteratureSourcesId (value: string)
{
if (value  != undefined)
{
 this.literatureSourcesId = value;
    this.hmProperty["literatureSourcesId"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 页码(说明:;字段类型:int;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetPageNumber (value: number)
{
if (value  != undefined)
{
 this.pageNumber = value;
    this.hmProperty["pageNumber"] = true;
   this.sfUpdFldSetStr = this.updFldString;
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
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 论文行号(说明:;字段类型:int;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetPaperLineNum (value: number)
{
if (value  != undefined)
{
 this.paperLineNum = value;
    this.hmProperty["paperLineNum"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 论文页码(说明:;字段类型:int;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetPaperPageNum (value: number)
{
if (value  != undefined)
{
 this.paperPageNum = value;
    this.hmProperty["paperPageNum"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 评论数(说明:;字段类型:int;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetAppraiseCount (value: number)
{
if (value  != undefined)
{
 this.appraiseCount = value;
    this.hmProperty["appraiseCount"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 点赞统计(说明:;字段类型:int;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetOkCount (value: number)
{
if (value  != undefined)
{
 this.okCount = value;
    this.hmProperty["okCount"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 评分(说明:;字段类型:float;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetScore (value: number)
{
if (value  != undefined)
{
 this.score = value;
    this.hmProperty["score"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 学生平均分(说明:;字段类型:float;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetStuScore (value: number)
{
if (value  != undefined)
{
 this.stuScore = value;
    this.hmProperty["stuScore"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 教师评分(说明:;字段类型:float;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetTeaScore (value: number)
{
if (value  != undefined)
{
 this.teaScore = value;
    this.hmProperty["teaScore"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 建立日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetCreateDate (value: string)
{
if (value  != undefined)
{
 this.createDate = value;
    this.hmProperty["createDate"] = true;
   this.sfUpdFldSetStr = this.updFldString;
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
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 主题Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetTopicId (value: string)
{
if (value  != undefined)
{
 this.topicId = value;
    this.hmProperty["topicId"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 态度Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetAttitudesId (value: string)
{
if (value  != undefined)
{
 this.attitudesId = value;
    this.hmProperty["attitudesId"] = true;
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
case clsPaperSubViewpointEN.con_SubViewpointId:
return this.subViewpointId;
case clsPaperSubViewpointEN.con_PaperRWId:
return this.paperRWId;
case clsPaperSubViewpointEN.con_PaperId:
return this.paperId;
case clsPaperSubViewpointEN.con_id_CurrEduCls:
return this.id_CurrEduCls;
case clsPaperSubViewpointEN.con_UserId:
return this.userId;
case clsPaperSubViewpointEN.con_SectionId:
return this.sectionId;
case clsPaperSubViewpointEN.con_SubViewpointTypeId:
return this.subViewpointTypeId;
case clsPaperSubViewpointEN.con_RWTitle:
return this.rwTitle;
case clsPaperSubViewpointEN.con_SubViewpointContent:
return this.subViewpointContent;
case clsPaperSubViewpointEN.con_ExplainTypeId:
return this.explainTypeId;
case clsPaperSubViewpointEN.con_ExplainContent:
return this.explainContent;
case clsPaperSubViewpointEN.con_IsPublic:
return this.isPublic;
case clsPaperSubViewpointEN.con_LiteratureSourcesId:
return this.literatureSourcesId;
case clsPaperSubViewpointEN.con_PageNumber:
return this.pageNumber;
case clsPaperSubViewpointEN.con_OrderNum:
return this.orderNum;
case clsPaperSubViewpointEN.con_PaperLineNum:
return this.paperLineNum;
case clsPaperSubViewpointEN.con_PaperPageNum:
return this.paperPageNum;
case clsPaperSubViewpointEN.con_AppraiseCount:
return this.appraiseCount;
case clsPaperSubViewpointEN.con_OkCount:
return this.okCount;
case clsPaperSubViewpointEN.con_Score:
return this.score;
case clsPaperSubViewpointEN.con_StuScore:
return this.stuScore;
case clsPaperSubViewpointEN.con_TeaScore:
return this.teaScore;
case clsPaperSubViewpointEN.con_CreateDate:
return this.createDate;
case clsPaperSubViewpointEN.con_ShareId:
return this.shareId;
case clsPaperSubViewpointEN.con_TopicId:
return this.topicId;
case clsPaperSubViewpointEN.con_AttitudesId:
return this.attitudesId;
case clsPaperSubViewpointEN.con_UpdDate:
return this.updDate;
case clsPaperSubViewpointEN.con_UpdUser:
return this.updUser;
case clsPaperSubViewpointEN.con_Memo:
return this.memo;
case "sfUpdFldSetStr":
return this.sfUpdFldSetStr;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[PaperSubViewpoint]中不存在！`;
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
case clsPaperSubViewpointEN.con_SubViewpointId:
this.subViewpointId = strValue;
    this.hmProperty["subViewpointId"] = true;
break;
case clsPaperSubViewpointEN.con_PaperRWId:
this.paperRWId = strValue;
    this.hmProperty["paperRWId"] = true;
break;
case clsPaperSubViewpointEN.con_PaperId:
this.paperId = strValue;
    this.hmProperty["paperId"] = true;
break;
case clsPaperSubViewpointEN.con_id_CurrEduCls:
this.id_CurrEduCls = strValue;
    this.hmProperty["id_CurrEduCls"] = true;
break;
case clsPaperSubViewpointEN.con_UserId:
this.userId = strValue;
    this.hmProperty["userId"] = true;
break;
case clsPaperSubViewpointEN.con_SectionId:
this.sectionId = strValue;
    this.hmProperty["sectionId"] = true;
break;
case clsPaperSubViewpointEN.con_SubViewpointTypeId:
this.subViewpointTypeId = strValue;
    this.hmProperty["subViewpointTypeId"] = true;
break;
case clsPaperSubViewpointEN.con_RWTitle:
this.rwTitle = strValue;
    this.hmProperty["rwTitle"] = true;
break;
case clsPaperSubViewpointEN.con_SubViewpointContent:
this.subViewpointContent = strValue;
    this.hmProperty["subViewpointContent"] = true;
break;
case clsPaperSubViewpointEN.con_ExplainTypeId:
this.explainTypeId = strValue;
    this.hmProperty["explainTypeId"] = true;
break;
case clsPaperSubViewpointEN.con_ExplainContent:
this.explainContent = strValue;
    this.hmProperty["explainContent"] = true;
break;
case clsPaperSubViewpointEN.con_IsPublic:
this.isPublic = Boolean(strValue);
    this.hmProperty["isPublic"] = true;
break;
case clsPaperSubViewpointEN.con_LiteratureSourcesId:
this.literatureSourcesId = strValue;
    this.hmProperty["literatureSourcesId"] = true;
break;
case clsPaperSubViewpointEN.con_PageNumber:
this.pageNumber = Number(strValue);
    this.hmProperty["pageNumber"] = true;
break;
case clsPaperSubViewpointEN.con_OrderNum:
this.orderNum = Number(strValue);
    this.hmProperty["orderNum"] = true;
break;
case clsPaperSubViewpointEN.con_PaperLineNum:
this.paperLineNum = Number(strValue);
    this.hmProperty["paperLineNum"] = true;
break;
case clsPaperSubViewpointEN.con_PaperPageNum:
this.paperPageNum = Number(strValue);
    this.hmProperty["paperPageNum"] = true;
break;
case clsPaperSubViewpointEN.con_AppraiseCount:
this.appraiseCount = Number(strValue);
    this.hmProperty["appraiseCount"] = true;
break;
case clsPaperSubViewpointEN.con_OkCount:
this.okCount = Number(strValue);
    this.hmProperty["okCount"] = true;
break;
case clsPaperSubViewpointEN.con_Score:
this.score = Number(strValue);
    this.hmProperty["score"] = true;
break;
case clsPaperSubViewpointEN.con_StuScore:
this.stuScore = Number(strValue);
    this.hmProperty["stuScore"] = true;
break;
case clsPaperSubViewpointEN.con_TeaScore:
this.teaScore = Number(strValue);
    this.hmProperty["teaScore"] = true;
break;
case clsPaperSubViewpointEN.con_CreateDate:
this.createDate = strValue;
    this.hmProperty["createDate"] = true;
break;
case clsPaperSubViewpointEN.con_ShareId:
this.shareId = strValue;
    this.hmProperty["shareId"] = true;
break;
case clsPaperSubViewpointEN.con_TopicId:
this.topicId = strValue;
    this.hmProperty["topicId"] = true;
break;
case clsPaperSubViewpointEN.con_AttitudesId:
this.attitudesId = strValue;
    this.hmProperty["attitudesId"] = true;
break;
case clsPaperSubViewpointEN.con_UpdDate:
this.updDate = strValue;
    this.hmProperty["updDate"] = true;
break;
case clsPaperSubViewpointEN.con_UpdUser:
this.updUser = strValue;
    this.hmProperty["updUser"] = true;
break;
case clsPaperSubViewpointEN.con_Memo:
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
strMsg = `字段名:[${strFldName}]在表对象:[PaperSubViewpoint]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
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
public id_CurrEduCls = "";    //教学班流水号
public userId = "";    //用户ID
public sectionId = "";    //节Id
public subViewpointTypeId = "";    //类型Id
public rwTitle = "";    //读写标题
public subViewpointContent = "";    //详情内容
public explainTypeId = "";    //说明类型Id
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
public updDate = "";    //修改日期
public updUser = "";    //修改人
public memo = "";    //备注


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
 * 常量:"SubViewpointTypeId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SubViewpointTypeId(): string {return "subViewpointTypeId";}    //类型Id

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