
 /**
 * 类名:clsgs_UserRelaEN
 * 表名:gs_UserRela(01120773)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:47:08
 * 生成者:pyf
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:研培设置(GraduateEduTools)
 * 框架-层名:实体层(TS)(EntityLayer)
 * 编程语言:TypeScript
 **/
 /**
 * 用户关系(gs_UserRela)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTab } from '../../PubFun/clsGeneralTab.js';

export class clsgs_UserRelaEN extends clsGeneralTab
{
public static CacheAddiCondition = "";//缓存附加条件，作为向后台调取数据的附加条件
public static CacheModeId = "02"; //客户端缓存
public static _CurrTabName= "gs_UserRela"; //当前表名,与该类相关的表名
public static _KeyFldName= "mId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 12;
public static AttributeName = ["mId", "userId", "userRelaId", "updUser", "updDate", "memo", "updUserName", "userRelaName", "id_CurrEduCls", "orderNum", "x_Position", "y_Position"];
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
private mstrUserId = "";    //用户ID
private mstrUserRelaId = "";    //关系用户Id
private mstrUpdUser = "";    //修改人
private mstrUpdDate = "";    //修改日期
private mstrMemo = "";    //备注
private mstrUpdUserName = "";    //UpdUserName
private mstrUserRelaName = "";    //UserRelaName
private mstrid_CurrEduCls = "";    //教学班流水号
private mintOrderNum = 0;    //序号
private mfltX_Position = 0.0;    //X_坐标
private mfltY_Position = 0.0;    //Y_坐标

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
}
}

/**
 * 用户ID(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetUserId (value: string)
{
if (value  != undefined)
{
 this.userId = value;
    this.hmProperty["userId"] = true;
}
}

/**
 * 关系用户Id(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetUserRelaId (value: string)
{
if (value  != undefined)
{
 this.userRelaId = value;
    this.hmProperty["userRelaId"] = true;
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
 * UpdUserName(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetUpdUserName (value: string)
{
if (value  != undefined)
{
 this.updUserName = value;
    this.hmProperty["updUserName"] = true;
}
}

/**
 * UserRelaName(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetUserRelaName (value: string)
{
if (value  != undefined)
{
 this.userRelaName = value;
    this.hmProperty["userRelaName"] = true;
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
 * 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public SetOrderNum (value: number)
{
if (value  != undefined)
{
 this.orderNum = value;
    this.hmProperty["orderNum"] = true;
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
case clsgs_UserRelaEN.con_mId:
return this.mId;
case clsgs_UserRelaEN.con_UserId:
return this.userId;
case clsgs_UserRelaEN.con_UserRelaId:
return this.userRelaId;
case clsgs_UserRelaEN.con_UpdUser:
return this.updUser;
case clsgs_UserRelaEN.con_UpdDate:
return this.updDate;
case clsgs_UserRelaEN.con_Memo:
return this.memo;
case clsgs_UserRelaEN.con_UpdUserName:
return this.updUserName;
case clsgs_UserRelaEN.con_UserRelaName:
return this.userRelaName;
case clsgs_UserRelaEN.con_id_CurrEduCls:
return this.id_CurrEduCls;
case clsgs_UserRelaEN.con_OrderNum:
return this.orderNum;
case clsgs_UserRelaEN.con_X_Position:
return this.x_Position;
case clsgs_UserRelaEN.con_Y_Position:
return this.y_Position;
case "sf_UpdFldSetStr":
return this.sf_UpdFldSetStr;
case "sf_FldComparisonOp":
return this.sf_FldComparisonOp;
default:
strMsg = `字段名:[${strFldName}]在表对象:[gs_UserRela]中不存在！`;
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
case clsgs_UserRelaEN.con_mId:
this.mId = Number(strValue);
    this.hmProperty["mId"] = true;
break;
case clsgs_UserRelaEN.con_UserId:
this.userId = strValue;
    this.hmProperty["userId"] = true;
break;
case clsgs_UserRelaEN.con_UserRelaId:
this.userRelaId = strValue;
    this.hmProperty["userRelaId"] = true;
break;
case clsgs_UserRelaEN.con_UpdUser:
this.updUser = strValue;
    this.hmProperty["updUser"] = true;
break;
case clsgs_UserRelaEN.con_UpdDate:
this.updDate = strValue;
    this.hmProperty["updDate"] = true;
break;
case clsgs_UserRelaEN.con_Memo:
this.memo = strValue;
    this.hmProperty["memo"] = true;
break;
case clsgs_UserRelaEN.con_UpdUserName:
this.updUserName = strValue;
    this.hmProperty["updUserName"] = true;
break;
case clsgs_UserRelaEN.con_UserRelaName:
this.userRelaName = strValue;
    this.hmProperty["userRelaName"] = true;
break;
case clsgs_UserRelaEN.con_id_CurrEduCls:
this.id_CurrEduCls = strValue;
    this.hmProperty["id_CurrEduCls"] = true;
break;
case clsgs_UserRelaEN.con_OrderNum:
this.orderNum = Number(strValue);
    this.hmProperty["orderNum"] = true;
break;
case clsgs_UserRelaEN.con_X_Position:
this.x_Position = Number(strValue);
    this.hmProperty["x_Position"] = true;
break;
case clsgs_UserRelaEN.con_Y_Position:
this.y_Position = Number(strValue);
    this.hmProperty["y_Position"] = true;
break;
case "sf_UpdFldSetStr":
this.sf_UpdFldSetStr = strValue;
break;
case "sf_FldComparisonOp":
this.sf_FldComparisonOp = strValue;
break;
default:
strMsg = `字段名:[${strFldName}]在表对象:[gs_UserRela]中不存在！(in ${this.constructor.name}.${strThisFuncName})`;
console.error(strMsg);
break;
}
}

/**
 * 设置对象中公共属性.
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsPublicVar)
*/
public mId = 0;    //mId
public userId = "";    //用户ID
public userRelaId = "";    //关系用户Id
public updUser = "";    //修改人
public updDate = "";    //修改日期
public memo = "";    //备注
public updUserName = "";    //UpdUserName
public userRelaName = "";    //UserRelaName
public id_CurrEduCls = "";    //教学班流水号
public orderNum = 0;    //序号
public x_Position = 0.0;    //X_坐标
public y_Position = 0.0;    //Y_坐标


 /**
 * 常量:"mId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_mId(): string {return "mId";}    //mId

 /**
 * 常量:"UserId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UserId(): string {return "userId";}    //用户ID

 /**
 * 常量:"UserRelaId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UserRelaId(): string {return "userRelaId";}    //关系用户Id

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
 * 常量:"UpdUserName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UpdUserName(): string {return "updUserName";}    //UpdUserName

 /**
 * 常量:"UserRelaName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UserRelaName(): string {return "userRelaName";}    //UserRelaName

 /**
 * 常量:"id_CurrEduCls"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_CurrEduCls(): string {return "id_CurrEduCls";}    //教学班流水号

 /**
 * 常量:"OrderNum"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_OrderNum(): string {return "orderNum";}    //序号

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