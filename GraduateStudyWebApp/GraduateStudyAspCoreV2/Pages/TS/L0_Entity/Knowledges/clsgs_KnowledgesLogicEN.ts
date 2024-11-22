
 /**
 * 类名:clsgs_KnowledgesLogicEN
 * 表名:gs_KnowledgesLogic(01120872)
 * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
 * 日期:2023/03/15 23:43:52
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
 * 知识点逻辑(gs_KnowledgesLogic)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTab } from '../../PubFun/clsGeneralTab.js';

export class clsgs_KnowledgesLogicEN extends clsGeneralTab
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "02"; //客户端缓存
public static IsUseDelSign = false; //使用删除标志，记录不能删除，仅设置删除标志
public static WhereFormat = ""; //条件格式串
public static _CurrTabName= "gs_KnowledgesLogic"; //当前表名,与该类相关的表名
public static _KeyFldName= "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 13;
public static AttributeName = ["mId", "courseKnowledgeId", "courseKnowledgeTitle", "x_Position", "y_Position", "knowledgeGraphId", "nodeColor", "logicNodeId", "className", "courseId", "updDate", "updUser", "memo"];
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
private mlngmId = 0;    //mId
private mstrCourseKnowledgeId = "";    //知识点Id
private mstrCourseKnowledgeTitle = "";    //知识点标题
private mfltX_Position = 0.0;    //X_坐标
private mfltY_Position = 0.0;    //Y_坐标
private mstrKnowledgeGraphId = "";    //知识点图Id
private mstrNodeColor = "";    //结点颜色
private mstrLogicNodeId = "";    //逻辑节点Id
private mstrClassName = "";    //样式名称
private mstrCourseId = "";    //课程Id
private mstrUpdDate = "";    //修改日期
private mstrUpdUser = "";    //修改人
private mstrMemo = "";    //备注

/**
 * mId(说明:;字段类型:bigint;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetmId (value: number)
{
if (value  != undefined)
{
 this.mId = value;
    this.hmProperty["mId"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 知识点Id(说明:;字段类型:char;字段长度:8;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetCourseKnowledgeId (value: string)
{
if (value  != undefined)
{
 this.courseKnowledgeId = value;
    this.hmProperty["courseKnowledgeId"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 知识点标题(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetCourseKnowledgeTitle (value: string)
{
if (value  != undefined)
{
 this.courseKnowledgeTitle = value;
    this.hmProperty["courseKnowledgeTitle"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * X_坐标(说明:;字段类型:float;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetX_Position (value: number)
{
if (value  != undefined)
{
 this.x_Position = value;
    this.hmProperty["x_Position"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * Y_坐标(说明:;字段类型:float;字段长度:8;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetY_Position (value: number)
{
if (value  != undefined)
{
 this.y_Position = value;
    this.hmProperty["y_Position"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

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
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 结点颜色(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetNodeColor (value: string)
{
if (value  != undefined)
{
 this.nodeColor = value;
    this.hmProperty["nodeColor"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 逻辑节点Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetLogicNodeId (value: string)
{
if (value  != undefined)
{
 this.logicNodeId = value;
    this.hmProperty["logicNodeId"] = true;
   this.sfUpdFldSetStr = this.updFldString;
}
}

/**
 * 样式名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetClassName (value: string)
{
if (value  != undefined)
{
 this.className = value;
    this.hmProperty["className"] = true;
   this.sfUpdFldSetStr = this.updFldString;
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
case clsgs_KnowledgesLogicEN.con_mId:
return this.mId;
case clsgs_KnowledgesLogicEN.con_CourseKnowledgeId:
return this.courseKnowledgeId;
case clsgs_KnowledgesLogicEN.con_CourseKnowledgeTitle:
return this.courseKnowledgeTitle;
case clsgs_KnowledgesLogicEN.con_X_Position:
return this.x_Position;
case clsgs_KnowledgesLogicEN.con_Y_Position:
return this.y_Position;
case clsgs_KnowledgesLogicEN.con_KnowledgeGraphId:
return this.knowledgeGraphId;
case clsgs_KnowledgesLogicEN.con_NodeColor:
return this.nodeColor;
case clsgs_KnowledgesLogicEN.con_LogicNodeId:
return this.logicNodeId;
case clsgs_KnowledgesLogicEN.con_ClassName:
return this.className;
case clsgs_KnowledgesLogicEN.con_CourseId:
return this.courseId;
case clsgs_KnowledgesLogicEN.con_UpdDate:
return this.updDate;
case clsgs_KnowledgesLogicEN.con_UpdUser:
return this.updUser;
case clsgs_KnowledgesLogicEN.con_Memo:
return this.memo;
case "sfUpdFldSetStr":
return this.sfUpdFldSetStr;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[gs_KnowledgesLogic]中不存在！`;
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
case clsgs_KnowledgesLogicEN.con_mId:
this.mId = Number(strValue);
    this.hmProperty["mId"] = true;
break;
case clsgs_KnowledgesLogicEN.con_CourseKnowledgeId:
this.courseKnowledgeId = strValue;
    this.hmProperty["courseKnowledgeId"] = true;
break;
case clsgs_KnowledgesLogicEN.con_CourseKnowledgeTitle:
this.courseKnowledgeTitle = strValue;
    this.hmProperty["courseKnowledgeTitle"] = true;
break;
case clsgs_KnowledgesLogicEN.con_X_Position:
this.x_Position = Number(strValue);
    this.hmProperty["x_Position"] = true;
break;
case clsgs_KnowledgesLogicEN.con_Y_Position:
this.y_Position = Number(strValue);
    this.hmProperty["y_Position"] = true;
break;
case clsgs_KnowledgesLogicEN.con_KnowledgeGraphId:
this.knowledgeGraphId = strValue;
    this.hmProperty["knowledgeGraphId"] = true;
break;
case clsgs_KnowledgesLogicEN.con_NodeColor:
this.nodeColor = strValue;
    this.hmProperty["nodeColor"] = true;
break;
case clsgs_KnowledgesLogicEN.con_LogicNodeId:
this.logicNodeId = strValue;
    this.hmProperty["logicNodeId"] = true;
break;
case clsgs_KnowledgesLogicEN.con_ClassName:
this.className = strValue;
    this.hmProperty["className"] = true;
break;
case clsgs_KnowledgesLogicEN.con_CourseId:
this.courseId = strValue;
    this.hmProperty["courseId"] = true;
break;
case clsgs_KnowledgesLogicEN.con_UpdDate:
this.updDate = strValue;
    this.hmProperty["updDate"] = true;
break;
case clsgs_KnowledgesLogicEN.con_UpdUser:
this.updUser = strValue;
    this.hmProperty["updUser"] = true;
break;
case clsgs_KnowledgesLogicEN.con_Memo:
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
strMsg = `字段名:[${strFldName}]在表对象:[gs_KnowledgesLogic]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
console.error(strMsg);
break;
}
}

/**
 * 设置对象中公共属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
*/
public mId = 0;    //mId
public courseKnowledgeId = "";    //知识点Id
public courseKnowledgeTitle = "";    //知识点标题
public x_Position = 0.0;    //X_坐标
public y_Position = 0.0;    //Y_坐标
public knowledgeGraphId = "";    //知识点图Id
public nodeColor = "";    //结点颜色
public logicNodeId = "";    //逻辑节点Id
public className = "";    //样式名称
public courseId = "";    //课程Id
public updDate = "";    //修改日期
public updUser = "";    //修改人
public memo = "";    //备注


 /**
 * 常量:"mId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_mId(): string {return "mId";}    //mId

 /**
 * 常量:"CourseKnowledgeId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CourseKnowledgeId(): string {return "courseKnowledgeId";}    //知识点Id

 /**
 * 常量:"CourseKnowledgeTitle"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CourseKnowledgeTitle(): string {return "courseKnowledgeTitle";}    //知识点标题

 /**
 * 常量:"X_Position"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_X_Position(): string {return "x_Position";}    //X_坐标

 /**
 * 常量:"Y_Position"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Y_Position(): string {return "y_Position";}    //Y_坐标

 /**
 * 常量:"KnowledgeGraphId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_KnowledgeGraphId(): string {return "knowledgeGraphId";}    //知识点图Id

 /**
 * 常量:"NodeColor"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_NodeColor(): string {return "nodeColor";}    //结点颜色

 /**
 * 常量:"LogicNodeId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_LogicNodeId(): string {return "logicNodeId";}    //逻辑节点Id

 /**
 * 常量:"ClassName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ClassName(): string {return "className";}    //样式名称

 /**
 * 常量:"CourseId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_CourseId(): string {return "courseId";}    //课程Id

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