﻿
 /**
 * 类名:clsgs_KnowledgesGraphEN
 * 表名:gs_KnowledgesGraph(01120873)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:02
 * 生成者:pyf
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:知识点相关(Knowledges)
 * 框架-层名:实体层(TS)(EntityLayer)
 * 编程语言:TypeScript
 **/
 /**
 * 知识点逻辑图(gs_KnowledgesGraph)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTab } from '../../PubFun/clsGeneralTab.js';

export class clsgs_KnowledgesGraphEN extends clsGeneralTab
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "02"; //客户端缓存
public static _CurrTabName= "gs_KnowledgesGraph"; //当前表名,与该类相关的表名
public static _KeyFldName= "KnowledgeGraphId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 18;
public static AttributeName = ["knowledgeGraphId", "knowledgeGraphName", "id_CurrEduCls", "courseId", "createUser", "updDate", "updUser", "memo", "graphTypeId", "isDisplay", "isExtend", "isRecommend", "isAnswer", "isSubmit", "startTime", "submitTime", "eduClassName", "courseName"];
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
private mstrKnowledgeGraphId = "";    //知识点图Id
private mstrKnowledgeGraphName = "";    //连连看图名
private mstrid_CurrEduCls = "";    //教学班流水号
private mstrCourseId = "";    //课程Id
private mstrCreateUser = "";    //建立用户
private mstrUpdDate = "";    //修改日期
private mstrUpdUser = "";    //修改人
private mstrMemo = "";    //备注
private mstrGraphTypeId = "";    //图谱类型Id
private mbolIsDisplay = false;    //是否显示
private mbolIsExtend = false;    //是否扩展
private mbolIsRecommend = false;    //是否推荐
private mbolIsAnswer = false;    //是否回答
private mbolIsSubmit = false;    //是否提交
private mstrStartTime = "";    //开始时间
private mstrSubmitTime = "";    //提交时间
private mstrEduClassName = "";    //教学班
private mstrCourseName = "";    //课程名称

/**
 * 知识点图Id(说明:;字段类型:char;字段长度:10;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetKnowledgeGraphId (value: string)
{
if (value  != undefined)
{
 this.knowledgeGraphId = value;
    this.hmProperty["knowledgeGraphId"] = true;
}
}

/**
 * 连连看图名(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetKnowledgeGraphName (value: string)
{
if (value  != undefined)
{
 this.knowledgeGraphName = value;
    this.hmProperty["knowledgeGraphName"] = true;
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
 * 课程Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetCourseId (value: string)
{
if (value  != undefined)
{
 this.courseId = value;
    this.hmProperty["courseId"] = true;
}
}

/**
 * 建立用户(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetCreateUser (value: string)
{
if (value  != undefined)
{
 this.createUser = value;
    this.hmProperty["createUser"] = true;
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
 * 图谱类型Id(说明:;字段类型:char;字段长度:2;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetGraphTypeId (value: string)
{
if (value  != undefined)
{
 this.graphTypeId = value;
    this.hmProperty["graphTypeId"] = true;
}
}

/**
 * 是否显示(说明:;字段类型:bit;字段长度:1;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetIsDisplay (value: boolean)
{
if (value  != undefined)
{
 this.isDisplay = value;
    this.hmProperty["isDisplay"] = true;
}
}

/**
 * 是否扩展(说明:;字段类型:bit;字段长度:1;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetIsExtend (value: boolean)
{
if (value  != undefined)
{
 this.isExtend = value;
    this.hmProperty["isExtend"] = true;
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
 * 是否回答(说明:;字段类型:bit;字段长度:1;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetIsAnswer (value: boolean)
{
if (value  != undefined)
{
 this.isAnswer = value;
    this.hmProperty["isAnswer"] = true;
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
 * 开始时间(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetStartTime (value: string)
{
if (value  != undefined)
{
 this.startTime = value;
    this.hmProperty["startTime"] = true;
}
}

/**
 * 提交时间(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetSubmitTime (value: string)
{
if (value  != undefined)
{
 this.submitTime = value;
    this.hmProperty["submitTime"] = true;
}
}

/**
 * 教学班(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetEduClassName (value: string)
{
if (value  != undefined)
{
 this.eduClassName = value;
    this.hmProperty["eduClassName"] = true;
}
}

/**
 * 课程名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetCourseName (value: string)
{
if (value  != undefined)
{
 this.courseName = value;
    this.hmProperty["courseName"] = true;
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
case clsgs_KnowledgesGraphEN.con_KnowledgeGraphId:
return this.knowledgeGraphId;
case clsgs_KnowledgesGraphEN.con_KnowledgeGraphName:
return this.knowledgeGraphName;
case clsgs_KnowledgesGraphEN.con_id_CurrEduCls:
return this.id_CurrEduCls;
case clsgs_KnowledgesGraphEN.con_CourseId:
return this.courseId;
case clsgs_KnowledgesGraphEN.con_CreateUser:
return this.createUser;
case clsgs_KnowledgesGraphEN.con_UpdDate:
return this.updDate;
case clsgs_KnowledgesGraphEN.con_UpdUser:
return this.updUser;
case clsgs_KnowledgesGraphEN.con_Memo:
return this.memo;
case clsgs_KnowledgesGraphEN.con_GraphTypeId:
return this.graphTypeId;
case clsgs_KnowledgesGraphEN.con_IsDisplay:
return this.isDisplay;
case clsgs_KnowledgesGraphEN.con_IsExtend:
return this.isExtend;
case clsgs_KnowledgesGraphEN.con_IsRecommend:
return this.isRecommend;
case clsgs_KnowledgesGraphEN.con_IsAnswer:
return this.isAnswer;
case clsgs_KnowledgesGraphEN.con_IsSubmit:
return this.isSubmit;
case clsgs_KnowledgesGraphEN.con_StartTime:
return this.startTime;
case clsgs_KnowledgesGraphEN.con_SubmitTime:
return this.submitTime;
case clsgs_KnowledgesGraphEN.con_EduClassName:
return this.eduClassName;
case clsgs_KnowledgesGraphEN.con_CourseName:
return this.courseName;
case "sf_UpdFldSetStr":
return this.sf_UpdFldSetStr;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[gs_KnowledgesGraph]中不存在！`;
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
case clsgs_KnowledgesGraphEN.con_KnowledgeGraphId:
this.knowledgeGraphId = strValue;
    this.hmProperty["knowledgeGraphId"] = true;
break;
case clsgs_KnowledgesGraphEN.con_KnowledgeGraphName:
this.knowledgeGraphName = strValue;
    this.hmProperty["knowledgeGraphName"] = true;
break;
case clsgs_KnowledgesGraphEN.con_id_CurrEduCls:
this.id_CurrEduCls = strValue;
    this.hmProperty["id_CurrEduCls"] = true;
break;
case clsgs_KnowledgesGraphEN.con_CourseId:
this.courseId = strValue;
    this.hmProperty["courseId"] = true;
break;
case clsgs_KnowledgesGraphEN.con_CreateUser:
this.createUser = strValue;
    this.hmProperty["createUser"] = true;
break;
case clsgs_KnowledgesGraphEN.con_UpdDate:
this.updDate = strValue;
    this.hmProperty["updDate"] = true;
break;
case clsgs_KnowledgesGraphEN.con_UpdUser:
this.updUser = strValue;
    this.hmProperty["updUser"] = true;
break;
case clsgs_KnowledgesGraphEN.con_Memo:
this.memo = strValue;
    this.hmProperty["memo"] = true;
break;
case clsgs_KnowledgesGraphEN.con_GraphTypeId:
this.graphTypeId = strValue;
    this.hmProperty["graphTypeId"] = true;
break;
case clsgs_KnowledgesGraphEN.con_IsDisplay:
this.isDisplay = Boolean(strValue);
    this.hmProperty["isDisplay"] = true;
break;
case clsgs_KnowledgesGraphEN.con_IsExtend:
this.isExtend = Boolean(strValue);
    this.hmProperty["isExtend"] = true;
break;
case clsgs_KnowledgesGraphEN.con_IsRecommend:
this.isRecommend = Boolean(strValue);
    this.hmProperty["isRecommend"] = true;
break;
case clsgs_KnowledgesGraphEN.con_IsAnswer:
this.isAnswer = Boolean(strValue);
    this.hmProperty["isAnswer"] = true;
break;
case clsgs_KnowledgesGraphEN.con_IsSubmit:
this.isSubmit = Boolean(strValue);
    this.hmProperty["isSubmit"] = true;
break;
case clsgs_KnowledgesGraphEN.con_StartTime:
this.startTime = strValue;
    this.hmProperty["startTime"] = true;
break;
case clsgs_KnowledgesGraphEN.con_SubmitTime:
this.submitTime = strValue;
    this.hmProperty["submitTime"] = true;
break;
case clsgs_KnowledgesGraphEN.con_EduClassName:
this.eduClassName = strValue;
    this.hmProperty["eduClassName"] = true;
break;
case clsgs_KnowledgesGraphEN.con_CourseName:
this.courseName = strValue;
    this.hmProperty["courseName"] = true;
break;
case "sf_UpdFldSetStr":
this.sf_UpdFldSetStr = strValue;
break;
case "sf_FldComparisonOp":
this.sf_FldComparisonOp = strValue;
break;
default:
strMsg = `字段名:[${strFldName}]在表对象:[gs_KnowledgesGraph]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
console.error(strMsg);
break;
}
}

/**
 * 设置对象中公共属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
*/
public knowledgeGraphId = "";    //知识点图Id
public knowledgeGraphName = "";    //连连看图名
public id_CurrEduCls = "";    //教学班流水号
public courseId = "";    //课程Id
public createUser = "";    //建立用户
public updDate = "";    //修改日期
public updUser = "";    //修改人
public memo = "";    //备注
public graphTypeId = "";    //图谱类型Id
public isDisplay = false;    //是否显示
public isExtend = false;    //是否扩展
public isRecommend = false;    //是否推荐
public isAnswer = false;    //是否回答
public isSubmit = false;    //是否提交
public startTime = "";    //开始时间
public submitTime = "";    //提交时间
public eduClassName = "";    //教学班
public courseName = "";    //课程名称


 /**
 * 常量:"KnowledgeGraphId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_KnowledgeGraphId(): string {return "knowledgeGraphId";}    //知识点图Id

 /**
 * 常量:"KnowledgeGraphName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_KnowledgeGraphName(): string {return "knowledgeGraphName";}    //连连看图名

 /**
 * 常量:"id_CurrEduCls"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_CurrEduCls(): string {return "id_CurrEduCls";}    //教学班流水号

 /**
 * 常量:"CourseId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CourseId(): string {return "courseId";}    //课程Id

 /**
 * 常量:"CreateUser"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CreateUser(): string {return "createUser";}    //建立用户

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
 * 常量:"GraphTypeId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_GraphTypeId(): string {return "graphTypeId";}    //图谱类型Id

 /**
 * 常量:"IsDisplay"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsDisplay(): string {return "isDisplay";}    //是否显示

 /**
 * 常量:"IsExtend"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsExtend(): string {return "isExtend";}    //是否扩展

 /**
 * 常量:"IsRecommend"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsRecommend(): string {return "isRecommend";}    //是否推荐

 /**
 * 常量:"IsAnswer"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsAnswer(): string {return "isAnswer";}    //是否回答

 /**
 * 常量:"IsSubmit"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsSubmit(): string {return "isSubmit";}    //是否提交

 /**
 * 常量:"StartTime"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_StartTime(): string {return "startTime";}    //开始时间

 /**
 * 常量:"SubmitTime"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_SubmitTime(): string {return "submitTime";}    //提交时间

 /**
 * 常量:"EduClassName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_EduClassName(): string {return "eduClassName";}    //教学班

 /**
 * 常量:"CourseName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CourseName(): string {return "courseName";}    //课程名称

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