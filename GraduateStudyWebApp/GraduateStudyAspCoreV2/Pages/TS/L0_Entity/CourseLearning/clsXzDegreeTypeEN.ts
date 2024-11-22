
 /**
 * 类名:clsXzDegreeTypeEN
 * 表名:XzDegreeType(01120067)
 * 生成代码版本:2021.09.26.2
 * 生成日期:2021/09/27 18:01:08
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
 * 行政学位类型(XzDegreeType)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTab2 } from '../../PubFun/clsGeneralTab2.js';
export class clsXzDegreeTypeEN extends clsGeneralTab2
{
[x: string]: any;//索引类型
public static _CurrTabName= "XzDegreeType"; //当前表名,与该类相关的表名
public static _KeyFldName= "id_DegreeType"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 5;
public static AttributeName = ["id_DegreeType", "XwTypeID", "XwTypeDesc", "XwTypeDesc_EN", "memo"];
//以下是属性变量

/**
 * 构造函数
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
*/
 constructor()
 {
 super();
 }

private mstrid_DegreeType = "";    //学位类型流水号
private mstrXwTypeID = "";    //学位类型ID
private mstrXwTypeDesc = "";    //学位类型名称
private mstrXwTypeDesc_EN = "";    //学位类型名称_EN
private mstrMemo = "";    //备注

/**
 * 学位类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get id_DegreeType ()
{
return this.mstrid_DegreeType;
}
/**
 * 学位类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set id_DegreeType (value: string)
{
if (value  != undefined)
{
 this.mstrid_DegreeType = value;
    this.hmProperty["id_DegreeType"] = true;
}
}

/**
 * 学位类型ID(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get XwTypeID ()
{
return this.mstrXwTypeID;
}
/**
 * 学位类型ID(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set XwTypeID (value: string)
{
if (value  != undefined)
{
 this.mstrXwTypeID = value;
    this.hmProperty["XwTypeID"] = true;
}
}

/**
 * 学位类型名称(说明:;字段类型:varchar;字段长度:60;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get XwTypeDesc ()
{
return this.mstrXwTypeDesc;
}
/**
 * 学位类型名称(说明:;字段类型:varchar;字段长度:60;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set XwTypeDesc (value: string)
{
if (value  != undefined)
{
 this.mstrXwTypeDesc = value;
    this.hmProperty["XwTypeDesc"] = true;
}
}

/**
 * 学位类型名称_EN(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get XwTypeDesc_EN ()
{
return this.mstrXwTypeDesc_EN;
}
/**
 * 学位类型名称_EN(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set XwTypeDesc_EN (value: string)
{
if (value  != undefined)
{
 this.mstrXwTypeDesc_EN = value;
    this.hmProperty["XwTypeDesc_EN"] = true;
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
 * 常量:"id_DegreeType"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_id_DegreeType(): string {return "id_DegreeType";}    //学位类型流水号

 /**
 * 常量:"XwTypeID"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_XwTypeID(): string {return "XwTypeID";}    //学位类型ID

 /**
 * 常量:"XwTypeDesc"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_XwTypeDesc(): string {return "XwTypeDesc";}    //学位类型名称

 /**
 * 常量:"XwTypeDesc_EN"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_XwTypeDesc_EN(): string {return "XwTypeDesc_EN";}    //学位类型名称_EN

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
 * 行政学位类型(XzDegreeType)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
export class clsXzDegreeTypeEN_Sim
{
[x: string]: any;//索引类型
//以下是属性变量

/**
 * 学位类型流水号(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public id_DegreeType = "";

/**
 * 学位类型ID(说明:;字段类型:varchar;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public XwTypeID = "";

/**
 * 学位类型名称(说明:;字段类型:varchar;字段长度:60;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public XwTypeDesc = "";

/**
 * 学位类型名称_EN(说明:;字段类型:varchar;字段长度:200;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public XwTypeDesc_EN = "";

/**
 * 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public memo = "";

public sfUpdFldSetStr = "";     //专门用于记录某字段属性是否修改
public sf_FldComparisonOp = "";     //专门用于记录条件对象某字段的比较运算符
}