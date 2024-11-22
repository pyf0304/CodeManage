
 /**
 * 类名:clsXzMajorTypeEN
 * 表名:XzMajorType(01120068)
 * 生成代码版本:2021.09.26.2
 * 生成日期:2021/09/27 18:01:11
 * 生成者:pyf
 * 工程名称:问卷调查
 * 工程ID:0112
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 * 模块中文名:课程学习
 * 模块英文名:CourseLearning
 * 框架-层名:实体层(EntityLayer)
 * 编程语言:TypeScript
 **/
 /**
 * 专业类型(XzMajorType)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTab2 } from '../../PubFun/clsGeneralTab2.js';
export class clsXzMajorTypeEN extends clsGeneralTab2
{
[x: string]: any;//索引类型
public static _CurrTabName= "XzMajorType"; //当前表名,与该类相关的表名
public static _KeyFldName= "id_MajorType"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 6;
public static AttributeName = ["id_MajorType", "MajorTypeID", "MajorTypeName", "modifyUserID", "modifyDate", "memo"];
//以下是属性变量

/**
 * 构造函数
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
*/
 constructor()
 {
 super();
 }

private mstrid_MajorType = "";    //专业类型(文理工)流水号
private mstrMajorTypeID = "";    //专业类型代号
private mstrMajorTypeName = "";    //专业类型名称
private mstrModifyUserID = "";    //修改人
private mstrModifyDate = "";    //修改日期
private mstrMemo = "";    //备注

/**
 * 专业类型(文理工)流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get id_MajorType ()
{
return this.mstrid_MajorType;
}
/**
 * 专业类型(文理工)流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set id_MajorType (value: string)
{
if (value  != undefined)
{
 this.mstrid_MajorType = value;
    this.hmProperty["id_MajorType"] = true;
}
}

/**
 * 专业类型代号(说明:;字段类型:varchar;字段长度:2;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get MajorTypeID ()
{
return this.mstrMajorTypeID;
}
/**
 * 专业类型代号(说明:;字段类型:varchar;字段长度:2;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set MajorTypeID (value: string)
{
if (value  != undefined)
{
 this.mstrMajorTypeID = value;
    this.hmProperty["MajorTypeID"] = true;
}
}

/**
 * 专业类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get MajorTypeName ()
{
return this.mstrMajorTypeName;
}
/**
 * 专业类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set MajorTypeName (value: string)
{
if (value  != undefined)
{
 this.mstrMajorTypeName = value;
    this.hmProperty["MajorTypeName"] = true;
}
}

/**
 * 修改人(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get modifyUserID ()
{
return this.mstrModifyUserID;
}
/**
 * 修改人(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set modifyUserID (value: string)
{
if (value  != undefined)
{
 this.mstrModifyUserID = value;
    this.hmProperty["modifyUserID"] = true;
}
}

/**
 * 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get modifyDate ()
{
return this.mstrModifyDate;
}
/**
 * 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set modifyDate (value: string)
{
if (value  != undefined)
{
 this.mstrModifyDate = value;
    this.hmProperty["modifyDate"] = true;
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
 * 常量:"id_MajorType"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_MajorType(): string {return "id_MajorType";}    //专业类型(文理工)流水号

 /**
 * 常量:"MajorTypeID"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_MajorTypeID(): string {return "MajorTypeID";}    //专业类型代号

 /**
 * 常量:"MajorTypeName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_MajorTypeName(): string {return "MajorTypeName";}    //专业类型名称

 /**
 * 常量:"modifyUserID"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ModifyUserID(): string {return "modifyUserID";}    //修改人

 /**
 * 常量:"modifyDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ModifyDate(): string {return "modifyDate";}    //修改日期

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
 * 专业类型(XzMajorType)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
export class clsXzMajorTypeEN_Sim
{
[x: string]: any;//索引类型
//以下是属性变量

/**
 * 专业类型(文理工)流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public id_MajorType = "";

/**
 * 专业类型代号(说明:;字段类型:varchar;字段长度:2;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public MajorTypeID = "";

/**
 * 专业类型名称(说明:;字段类型:varchar;字段长度:50;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public MajorTypeName = "";

/**
 * 修改人(说明:;字段类型:varchar;字段长度:18;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public modifyUserID = "";

/**
 * 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public modifyDate = "";

/**
 * 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public memo = "";

public sf_UpdFldSetStr = "";     //专门用于记录某字段属性是否修改
public sf_FldComparisonOp = "";     //专门用于记录条件对象某字段的比较运算符
}