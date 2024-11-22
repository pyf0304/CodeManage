
 /**
 * 类名:clsgs_RequestNoticeEN
 * 表名:gs_RequestNotice(01120724)
 * 生成代码版本:2021.10.17.1
 * 生成日期:2021/10/17 11:34:21
 * 生成者:pyf
 * 工程名称:问卷调查
 * 工程ID:0112
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 * 模块中文名:研培设置
 * 模块英文名:GraduateEduTools
 * 框架-层名:实体层(EntityLayer)
 * 编程语言:TypeScript
 **/
 /**
 * 请求通知表(gs_RequestNotice)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTab2 } from '../../PubFun/clsGeneralTab2.js';

export class clsgs_RequestNoticeEN extends clsGeneralTab2
{
[x: string]: any;//索引类型
public static _CurrTabName= "gs_RequestNotice"; //当前表名,与该类相关的表名
public static _KeyFldName= "requestId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 12;
public static AttributeName = ["requestId", "requesTypeId", "tableKey", "receiveUser", "isReply", "replyDate", "requestUser", "requestDate", "requestStata", "pushTypeId", "id_CurrEduCls", "memo"];
//以下是属性变量

/**
 * 构造函数
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
*/
 constructor()
 {
 super();
 }

private mlngRequestId = 0;    //requestId
private mstrRequesTypeId = "";    //请求类型Id
private mstrTableKey = "";    //表主键
private mstrReceiveUser = "";    //接收用户
private mbolIsReply = false;    //是否回复
private mstrReplyDate = "";    //回复日期
private mstrRequestUser = "";    //requestUser
private mstrRequestDate = "";    //requestDate
private mstrRequestStata = "";    //requestStata
private mstrPushTypeId = "";    //推送类型Id
private mstrid_CurrEduCls = "";    //教学班流水号
private mstrMemo = "";    //备注

/**
 * requestId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get requestId ()
{
return this.mlngRequestId;
}
/**
 * requestId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set requestId (value: number)
{
if (value  != undefined)
{
 this.mlngRequestId = value;
    this.hmProperty["requestId"] = true;
}
}

/**
 * 请求类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get requesTypeId ()
{
return this.mstrRequesTypeId;
}
/**
 * 请求类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set requesTypeId (value: string)
{
if (value  != undefined)
{
 this.mstrRequesTypeId = value;
    this.hmProperty["requesTypeId"] = true;
}
}

/**
 * 表主键(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get tableKey ()
{
return this.mstrTableKey;
}
/**
 * 表主键(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set tableKey (value: string)
{
if (value  != undefined)
{
 this.mstrTableKey = value;
    this.hmProperty["tableKey"] = true;
}
}

/**
 * 接收用户(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get receiveUser ()
{
return this.mstrReceiveUser;
}
/**
 * 接收用户(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set receiveUser (value: string)
{
if (value  != undefined)
{
 this.mstrReceiveUser = value;
    this.hmProperty["receiveUser"] = true;
}
}

/**
 * 是否回复(说明:;字段类型:bit;字段长度:1;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get isReply ()
{
return this.mbolIsReply;
}
/**
 * 是否回复(说明:;字段类型:bit;字段长度:1;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set isReply (value: boolean)
{
if (value  != undefined)
{
 this.mbolIsReply = value;
    this.hmProperty["isReply"] = true;
}
}

/**
 * 回复日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get replyDate ()
{
return this.mstrReplyDate;
}
/**
 * 回复日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set replyDate (value: string)
{
if (value  != undefined)
{
 this.mstrReplyDate = value;
    this.hmProperty["replyDate"] = true;
}
}

/**
 * requestUser(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get requestUser ()
{
return this.mstrRequestUser;
}
/**
 * requestUser(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set requestUser (value: string)
{
if (value  != undefined)
{
 this.mstrRequestUser = value;
    this.hmProperty["requestUser"] = true;
}
}

/**
 * requestDate(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get requestDate ()
{
return this.mstrRequestDate;
}
/**
 * requestDate(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set requestDate (value: string)
{
if (value  != undefined)
{
 this.mstrRequestDate = value;
    this.hmProperty["requestDate"] = true;
}
}

/**
 * requestStata(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get requestStata ()
{
return this.mstrRequestStata;
}
/**
 * requestStata(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set requestStata (value: string)
{
if (value  != undefined)
{
 this.mstrRequestStata = value;
    this.hmProperty["requestStata"] = true;
}
}

/**
 * 推送类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get pushTypeId ()
{
return this.mstrPushTypeId;
}
/**
 * 推送类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set pushTypeId (value: string)
{
if (value  != undefined)
{
 this.mstrPushTypeId = value;
    this.hmProperty["pushTypeId"] = true;
}
}

/**
 * 教学班流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get id_CurrEduCls ()
{
return this.mstrid_CurrEduCls;
}
/**
 * 教学班流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set id_CurrEduCls (value: string)
{
if (value  != undefined)
{
 this.mstrid_CurrEduCls = value;
    this.hmProperty["id_CurrEduCls"] = true;
}
}

/**
 * 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get memo ()
{
return this.mstrMemo;
}
/**
 * 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set memo (value: string)
{
if (value  != undefined)
{
 this.mstrMemo = value;
    this.hmProperty["memo"] = true;
}
}



 /**
 * 常量:"requestId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_RequestId(): string {return "requestId";}    //requestId

 /**
 * 常量:"requesTypeId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_RequesTypeId(): string {return "requesTypeId";}    //请求类型Id

 /**
 * 常量:"tableKey"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_TableKey(): string {return "tableKey";}    //表主键

 /**
 * 常量:"receiveUser"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ReceiveUser(): string {return "receiveUser";}    //接收用户

 /**
 * 常量:"isReply"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsReply(): string {return "isReply";}    //是否回复

 /**
 * 常量:"replyDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ReplyDate(): string {return "replyDate";}    //回复日期

 /**
 * 常量:"requestUser"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_RequestUser(): string {return "requestUser";}    //requestUser

 /**
 * 常量:"requestDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_RequestDate(): string {return "requestDate";}    //requestDate

 /**
 * 常量:"requestStata"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_RequestStata(): string {return "requestStata";}    //requestStata

 /**
 * 常量:"pushTypeId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PushTypeId(): string {return "pushTypeId";}    //推送类型Id

 /**
 * 常量:"id_CurrEduCls"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_CurrEduCls(): string {return "id_CurrEduCls";}    //教学班流水号

 /**
 * 常量:"memo"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Memo(): string {return "memo";}    //备注

public SetCondFldValue(strFldName: string, strFldValue: any, strComparisonOp: string): void {                
const strThisFuncName = this.SetCondFldValue.name;
console.log('strThisFuncName', strThisFuncName);
this[strFldName] = strFldValue;
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
 /**
 * 请求通知表(gs_RequestNotice)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
export class clsgs_RequestNoticeEN_Sim
{
[x: string]: any;//索引类型
//以下是属性变量

/**
 * requestId(说明:;字段类型:bigint;字段长度:8;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public requestId = 0;

/**
 * 请求类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public requesTypeId = "";

/**
 * 表主键(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public tableKey = "";

/**
 * 接收用户(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public receiveUser = "";

/**
 * 是否回复(说明:;字段类型:bit;字段长度:1;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public isReply = false;

/**
 * 回复日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public replyDate = "";

/**
 * requestUser(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public requestUser = "";

/**
 * requestDate(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public requestDate = "";

/**
 * requestStata(说明:;字段类型:varchar;字段长度:10;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public requestStata = "";

/**
 * 推送类型Id(说明:;字段类型:char;字段长度:2;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public pushTypeId = "";

/**
 * 教学班流水号(说明:;字段类型:char;字段长度:8;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public id_CurrEduCls = "";

/**
 * 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public memo = "";

public sf_UpdFldSetStr = "";     //专门用于记录某字段属性是否修改
public sf_FldComparisonOp = "";     //专门用于记录条件对象某字段的比较运算符
}