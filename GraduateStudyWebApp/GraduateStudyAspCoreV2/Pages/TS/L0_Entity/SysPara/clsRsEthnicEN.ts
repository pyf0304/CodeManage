
 /**
 * 类名:clsRsEthnicEN
 * 表名:RsEthnic(01120105)
 * 生成代码版本:2021.09.26.2
 * 生成日期:2021/09/27 17:59:23
 * 生成者:pyf
 * 工程名称:问卷调查
 * 工程ID:0112
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 * 模块中文名:系统参数
 * 模块英文名:SysPara
 * 框架-层名:实体层(EntityLayer)
 * 编程语言:TypeScript
 **/
 /**
 * 民族(RsEthnic)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTab2 } from '../../PubFun/clsGeneralTab2.js';
export class clsRsEthnicEN extends clsGeneralTab2
{
[x: string]: any;//索引类型
public static _CurrTabName= "RsEthnic"; //当前表名,与该类相关的表名
public static _KeyFldName= "id_Ethnic"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 4;
public static AttributeName = ["id_Ethnic", "EthnicID", "EthnicName", "memo"];
//以下是属性变量

/**
 * 构造函数
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
*/
 constructor()
 {
 super();
 }

private mstrid_Ethnic = "";    //民族流水号
private mstrEthnicID = "";    //民族ID
private mstrEthnicName = "";    //民族名称
private mstrMemo = "";    //备注

/**
 * 民族流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get id_Ethnic ()
{
return this.mstrid_Ethnic;
}
/**
 * 民族流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set id_Ethnic (value: string)
{
if (value  != undefined)
{
 this.mstrid_Ethnic = value;
    this.hmProperty["id_Ethnic"] = true;
}
}

/**
 * 民族ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get EthnicID ()
{
return this.mstrEthnicID;
}
/**
 * 民族ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set EthnicID (value: string)
{
if (value  != undefined)
{
 this.mstrEthnicID = value;
    this.hmProperty["EthnicID"] = true;
}
}

/**
 * 民族名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get EthnicName ()
{
return this.mstrEthnicName;
}
/**
 * 民族名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set EthnicName (value: string)
{
if (value  != undefined)
{
 this.mstrEthnicName = value;
    this.hmProperty["EthnicName"] = true;
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
 * 常量:"id_Ethnic"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_Ethnic(): string {return "id_Ethnic";}    //民族流水号

 /**
 * 常量:"EthnicID"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_EthnicID(): string {return "EthnicID";}    //民族ID

 /**
 * 常量:"EthnicName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_EthnicName(): string {return "EthnicName";}    //民族名称

 /**
 * 常量:"memo"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_Memo(): string {return "memo";}    //备注

public SetCondFldValue(strFldName: string, strFldValue: any, strComparisonOp: string): void {                
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
 * 民族(RsEthnic)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
export class clsRsEthnicEN_Sim
{
[x: string]: any;//索引类型
//以下是属性变量

/**
 * 民族流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public id_Ethnic = "";

/**
 * 民族ID(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public EthnicID = "";

/**
 * 民族名称(说明:;字段类型:varchar;字段长度:30;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public EthnicName = "";

/**
 * 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public memo = "";

public sfUpdFldSetStr = "";     //专门用于记录某字段属性是否修改
public sf_FldComparisonOp = "";     //专门用于记录条件对象某字段的比较运算符
}