﻿
 /**
 * 类名:clscc_ThemesEN
 * 表名:cc_Themes(01120069)
 * 生成代码版本:2021.09.26.2
 * 生成日期:2021/09/27 18:01:15
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
 * 课程主题(cc_Themes)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTab2 } from '../../PubFun/clsGeneralTab2.js';
export class clscc_ThemesEN extends clsGeneralTab2
{
[x: string]: any;//索引类型
public static _CurrTabName= "cc_Themes"; //当前表名,与该类相关的表名
public static _KeyFldName= "ThemeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 10;
public static AttributeName = ["ThemeId", "ThemeName", "ThemeDesc", "PageName", "ExampleImgPath", "orderNum", "IsUse", "updDate", "updUserId", "memo"];
//以下是属性变量

/**
 * 构造函数
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
*/
 constructor()
 {
 super();
 }

private mstrThemeId = "";    //主题Id
private mstrThemeName = "";    //主题名
private mstrThemeDesc = "";    //主题描述
private mstrPageName = "";    //页面名称
private mstrExampleImgPath = "";    //示例图路径
private mintOrderNum = 0;    //序号
private mbolIsUse = false;    //是否使用
private mstrUpdDate = "";    //修改日期
private mstrUpdUserId = "";    //修改用户Id
private mstrMemo = "";    //备注

/**
 * 主题Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get ThemeId ()
{
return this.mstrThemeId;
}
/**
 * 主题Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set ThemeId (value: string)
{
if (value  != undefined)
{
 this.mstrThemeId = value;
    this.hmProperty["ThemeId"] = true;
}
}

/**
 * 主题名(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get ThemeName ()
{
return this.mstrThemeName;
}
/**
 * 主题名(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set ThemeName (value: string)
{
if (value  != undefined)
{
 this.mstrThemeName = value;
    this.hmProperty["ThemeName"] = true;
}
}

/**
 * 主题描述(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get ThemeDesc ()
{
return this.mstrThemeDesc;
}
/**
 * 主题描述(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set ThemeDesc (value: string)
{
if (value  != undefined)
{
 this.mstrThemeDesc = value;
    this.hmProperty["ThemeDesc"] = true;
}
}

/**
 * 页面名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get PageName ()
{
return this.mstrPageName;
}
/**
 * 页面名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set PageName (value: string)
{
if (value  != undefined)
{
 this.mstrPageName = value;
    this.hmProperty["PageName"] = true;
}
}

/**
 * 示例图路径(说明:;字段类型:varchar;字段长度:300;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get ExampleImgPath ()
{
return this.mstrExampleImgPath;
}
/**
 * 示例图路径(说明:;字段类型:varchar;字段长度:300;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set ExampleImgPath (value: string)
{
if (value  != undefined)
{
 this.mstrExampleImgPath = value;
    this.hmProperty["ExampleImgPath"] = true;
}
}

/**
 * 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get orderNum ()
{
return this.mintOrderNum;
}
/**
 * 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set orderNum (value: number)
{
if (value  != undefined)
{
 this.mintOrderNum = value;
    this.hmProperty["orderNum"] = true;
}
}

/**
 * 是否使用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get IsUse ()
{
return this.mbolIsUse;
}
/**
 * 是否使用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set IsUse (value: boolean)
{
if (value  != undefined)
{
 this.mbolIsUse = value;
    this.hmProperty["IsUse"] = true;
}
}

/**
 * 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get updDate ()
{
return this.mstrUpdDate;
}
/**
 * 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set updDate (value: string)
{
if (value  != undefined)
{
 this.mstrUpdDate = value;
    this.hmProperty["updDate"] = true;
}
}

/**
 * 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get updUserId ()
{
return this.mstrUpdUserId;
}
/**
 * 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set updUserId (value: string)
{
if (value  != undefined)
{
 this.mstrUpdUserId = value;
    this.hmProperty["updUserId"] = true;
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
 * 常量:"ThemeId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ThemeId(): string {return "ThemeId";}    //主题Id

 /**
 * 常量:"ThemeName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ThemeName(): string {return "ThemeName";}    //主题名

 /**
 * 常量:"ThemeDesc"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ThemeDesc(): string {return "ThemeDesc";}    //主题描述

 /**
 * 常量:"PageName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_PageName(): string {return "PageName";}    //页面名称

 /**
 * 常量:"ExampleImgPath"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ExampleImgPath(): string {return "ExampleImgPath";}    //示例图路径

 /**
 * 常量:"orderNum"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_OrderNum(): string {return "orderNum";}    //序号

 /**
 * 常量:"IsUse"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_IsUse(): string {return "IsUse";}    //是否使用

 /**
 * 常量:"updDate"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UpdDate(): string {return "updDate";}    //修改日期

 /**
 * 常量:"updUserId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UpdUserId(): string {return "updUserId";}    //修改用户Id

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
 * 课程主题(cc_Themes)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
export class clscc_ThemesEN_Sim
{
[x: string]: any;//索引类型
//以下是属性变量

/**
 * 主题Id(说明:;字段类型:char;字段长度:4;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public ThemeId = "";

/**
 * 主题名(说明:;字段类型:varchar;字段长度:200;是否可空:False)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public ThemeName = "";

/**
 * 主题描述(说明:;字段类型:varchar;字段长度:500;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public ThemeDesc = "";

/**
 * 页面名称(说明:;字段类型:varchar;字段长度:100;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public PageName = "";

/**
 * 示例图路径(说明:;字段类型:varchar;字段长度:300;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public ExampleImgPath = "";

/**
 * 序号(说明:;字段类型:int;字段长度:4;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public orderNum = 0;

/**
 * 是否使用(说明:;字段类型:bit;字段长度:1;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public IsUse = false;

/**
 * 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public updDate = "";

/**
 * 修改用户Id(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public updUserId = "";

/**
 * 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public memo = "";

public sfUpdFldSetStr = "";     //专门用于记录某字段属性是否修改
public sf_FldComparisonOp = "";     //专门用于记录条件对象某字段的比较运算符
}