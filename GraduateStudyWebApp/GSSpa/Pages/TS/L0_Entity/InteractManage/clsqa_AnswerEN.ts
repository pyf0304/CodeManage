
 /**
 * 类名:clsqa_AnswerEN
 * 表名:qa_Answer(01120641)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:11
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
 * 答疑回答(qa_Answer)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTab } from '../../PubFun/clsGeneralTab.js';

export class clsqa_AnswerEN extends clsGeneralTab
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "04"; //sessionStorage
public static _CurrTabName= "qa_Answer"; //当前表名,与该类相关的表名
public static _KeyFldName= "AnswerId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 20;
public static AttributeName = ["answerId", "questionsId", "answerContent", "score", "scoreType", "isRight", "parentId", "voteCount", "isRecommend", "topicId", "answerTypeId", "isSubmit", "appraiseCount", "stuScore", "teaScore", "createDate", "id_CurrEduCls", "updUser", "updDate", "memo"];
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
private mstrAnswerId = "";    //回答Id
private mstrQuestionsId = "";    //提问Id
private mstrAnswerContent = "";    //答案内容
private mfltscore = 0.0;    //评分
private mstrScoreType = "";    //评分类型
private mbolIsRight = false;    //是否正确
private mstrParentId = "";    //父节点Id
private mintVoteCount = 0;    //点赞计数
private mbolIsRecommend = false;    //是否推荐
private mstrTopicId = "";    //主题Id
private mstrAnswerTypeId = "";    //答案类型ID
private mbolIsSubmit = false;    //是否提交
private mintAppraiseCount = 0;    //评论数
private mfltStuScore = 0.0;    //学生平均分
private mfltTeaScore = 0.0;    //教师评分
private mstrCreateDate = "";    //建立日期
private mstrid_CurrEduCls = "";    //教学班流水号
private mstrUpdUser = "";    //修改人
private mstrUpdDate = "";    //修改日期
private mstrMemo = "";    //备注

/**
 * 回答Id(说明:;字段类型:char;字段长度:10;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetAnswerId (value: string)
{
if (value  != undefined)
{
 this.answerId = value;
    this.hmProperty["answerId"] = true;
}
}

/**
 * 提问Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetQuestionsId (value: string)
{
if (value  != undefined)
{
 this.questionsId = value;
    this.hmProperty["questionsId"] = true;
}
}

/**
 * 答案内容(说明:;字段类型:text;字段长度:2147483647;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetAnswerContent (value: string)
{
if (value  != undefined)
{
 this.answerContent = value;
    this.hmProperty["answerContent"] = true;
}
}

/**
 * 评分(说明:;字段类型:float;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public Setscore (value: number)
{
if (value  != undefined)
{
 this.score = value;
    this.hmProperty["score"] = true;
}
}

/**
 * 评分类型(说明:;字段类型:char;字段长度:1;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetScoreType (value: string)
{
if (value  != undefined)
{
 this.scoreType = value;
    this.hmProperty["scoreType"] = true;
}
}

/**
 * 是否正确(说明:;字段类型:bit;字段长度:1;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetIsRight (value: boolean)
{
if (value  != undefined)
{
 this.isRight = value;
    this.hmProperty["isRight"] = true;
}
}

/**
 * 父节点Id(说明:;字段类型:char;字段长度:10;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetParentId (value: string)
{
if (value  != undefined)
{
 this.parentId = value;
    this.hmProperty["parentId"] = true;
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
 * 是否推荐(说明:;字段类型:bit;字段长度:1;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetIsRecommend (value: boolean)
{
if (value  != undefined)
{
 this.isRecommend = value;
    this.hmProperty["isRecommend"] = true;
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
}
}

/**
 * 答案类型ID(说明:;字段类型:char;字段长度:2;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetAnswerTypeId (value: string)
{
if (value  != undefined)
{
 this.answerTypeId = value;
    this.hmProperty["answerTypeId"] = true;
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
 * 评论数(说明:;字段类型:int;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetAppraiseCount (value: number)
{
if (value  != undefined)
{
 this.appraiseCount = value;
    this.hmProperty["appraiseCount"] = true;
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
case clsqa_AnswerEN.con_AnswerId:
return this.answerId;
case clsqa_AnswerEN.con_QuestionsId:
return this.questionsId;
case clsqa_AnswerEN.con_AnswerContent:
return this.answerContent;
case clsqa_AnswerEN.con_score:
return this.score;
case clsqa_AnswerEN.con_ScoreType:
return this.scoreType;
case clsqa_AnswerEN.con_IsRight:
return this.isRight;
case clsqa_AnswerEN.con_ParentId:
return this.parentId;
case clsqa_AnswerEN.con_VoteCount:
return this.voteCount;
case clsqa_AnswerEN.con_IsRecommend:
return this.isRecommend;
case clsqa_AnswerEN.con_TopicId:
return this.topicId;
case clsqa_AnswerEN.con_AnswerTypeId:
return this.answerTypeId;
case clsqa_AnswerEN.con_IsSubmit:
return this.isSubmit;
case clsqa_AnswerEN.con_AppraiseCount:
return this.appraiseCount;
case clsqa_AnswerEN.con_StuScore:
return this.stuScore;
case clsqa_AnswerEN.con_TeaScore:
return this.teaScore;
case clsqa_AnswerEN.con_CreateDate:
return this.createDate;
case clsqa_AnswerEN.con_id_CurrEduCls:
return this.id_CurrEduCls;
case clsqa_AnswerEN.con_UpdUser:
return this.updUser;
case clsqa_AnswerEN.con_UpdDate:
return this.updDate;
case clsqa_AnswerEN.con_Memo:
return this.memo;
case "sf_UpdFldSetStr":
return this.sf_UpdFldSetStr;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[qa_Answer]中不存在！`;
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
case clsqa_AnswerEN.con_AnswerId:
this.answerId = strValue;
    this.hmProperty["answerId"] = true;
break;
case clsqa_AnswerEN.con_QuestionsId:
this.questionsId = strValue;
    this.hmProperty["questionsId"] = true;
break;
case clsqa_AnswerEN.con_AnswerContent:
this.answerContent = strValue;
    this.hmProperty["answerContent"] = true;
break;
case clsqa_AnswerEN.con_score:
this.score = Number(strValue);
    this.hmProperty["score"] = true;
break;
case clsqa_AnswerEN.con_ScoreType:
this.scoreType = strValue;
    this.hmProperty["scoreType"] = true;
break;
case clsqa_AnswerEN.con_IsRight:
this.isRight = Boolean(strValue);
    this.hmProperty["isRight"] = true;
break;
case clsqa_AnswerEN.con_ParentId:
this.parentId = strValue;
    this.hmProperty["parentId"] = true;
break;
case clsqa_AnswerEN.con_VoteCount:
this.voteCount = Number(strValue);
    this.hmProperty["voteCount"] = true;
break;
case clsqa_AnswerEN.con_IsRecommend:
this.isRecommend = Boolean(strValue);
    this.hmProperty["isRecommend"] = true;
break;
case clsqa_AnswerEN.con_TopicId:
this.topicId = strValue;
    this.hmProperty["topicId"] = true;
break;
case clsqa_AnswerEN.con_AnswerTypeId:
this.answerTypeId = strValue;
    this.hmProperty["answerTypeId"] = true;
break;
case clsqa_AnswerEN.con_IsSubmit:
this.isSubmit = Boolean(strValue);
    this.hmProperty["isSubmit"] = true;
break;
case clsqa_AnswerEN.con_AppraiseCount:
this.appraiseCount = Number(strValue);
    this.hmProperty["appraiseCount"] = true;
break;
case clsqa_AnswerEN.con_StuScore:
this.stuScore = Number(strValue);
    this.hmProperty["stuScore"] = true;
break;
case clsqa_AnswerEN.con_TeaScore:
this.teaScore = Number(strValue);
    this.hmProperty["teaScore"] = true;
break;
case clsqa_AnswerEN.con_CreateDate:
this.createDate = strValue;
    this.hmProperty["createDate"] = true;
break;
case clsqa_AnswerEN.con_id_CurrEduCls:
this.id_CurrEduCls = strValue;
    this.hmProperty["id_CurrEduCls"] = true;
break;
case clsqa_AnswerEN.con_UpdUser:
this.updUser = strValue;
    this.hmProperty["updUser"] = true;
break;
case clsqa_AnswerEN.con_UpdDate:
this.updDate = strValue;
    this.hmProperty["updDate"] = true;
break;
case clsqa_AnswerEN.con_Memo:
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
strMsg = `字段名:[${strFldName}]在表对象:[qa_Answer]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
console.error(strMsg);
break;
}
}

/**
 * 设置对象中公共属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
*/
public answerId = "";    //回答Id
public questionsId = "";    //提问Id
public answerContent = "";    //答案内容
public score = 0.0;    //评分
public scoreType = "";    //评分类型
public isRight = false;    //是否正确
public parentId = "";    //父节点Id
public voteCount = 0;    //点赞计数
public isRecommend = false;    //是否推荐
public topicId = "";    //主题Id
public answerTypeId = "";    //答案类型ID
public isSubmit = false;    //是否提交
public appraiseCount = 0;    //评论数
public stuScore = 0.0;    //学生平均分
public teaScore = 0.0;    //教师评分
public createDate = "";    //建立日期
public id_CurrEduCls = "";    //教学班流水号
public updUser = "";    //修改人
public updDate = "";    //修改日期
public memo = "";    //备注


 /**
 * 常量:"AnswerId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_AnswerId(): string {return "answerId";}    //回答Id

 /**
 * 常量:"QuestionsId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_QuestionsId(): string {return "questionsId";}    //提问Id

 /**
 * 常量:"AnswerContent"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_AnswerContent(): string {return "answerContent";}    //答案内容

 /**
 * 常量:"score"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_score(): string {return "score";}    //评分

 /**
 * 常量:"ScoreType"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ScoreType(): string {return "scoreType";}    //评分类型

 /**
 * 常量:"IsRight"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsRight(): string {return "isRight";}    //是否正确

 /**
 * 常量:"ParentId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ParentId(): string {return "parentId";}    //父节点Id

 /**
 * 常量:"VoteCount"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_VoteCount(): string {return "voteCount";}    //点赞计数

 /**
 * 常量:"IsRecommend"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsRecommend(): string {return "isRecommend";}    //是否推荐

 /**
 * 常量:"TopicId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_TopicId(): string {return "topicId";}    //主题Id

 /**
 * 常量:"AnswerTypeId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_AnswerTypeId(): string {return "answerTypeId";}    //答案类型ID

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
 * 常量:"id_CurrEduCls"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_CurrEduCls(): string {return "id_CurrEduCls";}    //教学班流水号

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