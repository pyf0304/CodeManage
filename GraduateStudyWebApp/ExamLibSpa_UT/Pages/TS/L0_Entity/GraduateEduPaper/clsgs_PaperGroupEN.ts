
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsgs_PaperGroupEN
 表名:gs_PaperGroup(01120749)
 生成代码版本:2020.09.24.1
 生成日期:2020/09/28 18:28:55
 生成者:pyf2
 工程名称:问卷调查
 工程ID:0112
 相关数据库:101.251.68.133,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:研培论文
 模块英文名:GraduateEduPaper
 框架-层名:实体层(EntityLayer)
 编程语言:TypeScript
 == == == == == == == == == == == == 
 */
 /// <summary>
 /// 论文分组(gs_PaperGroup)
 /// (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 /// </summary>
/// <reference path="../../PubFun/clsGeneralTab.ts" />
import { clsGeneralTab } from '../../PubFun/clsGeneralTab.js';
export class clsgs_PaperGroupEN extends clsGeneralTab
{
public static _CurrTabName:string = "gs_PaperGroup"; //当前表名,与该类相关的表名
public static _KeyFldName:string = "PaperGroupId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 5;
public static AttributeName = new Array("PaperGroupId", "PaperGroupName", "UpdUser", "UpdDate", "Meno");
//以下是属性变量

/// <summary>
/// 构造函数
 /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
/// </summary>
 constructor()
 {
 super();
 }

private mstrPaperGroupId: string="";    //组Id
private mstrPaperGroupName: string="";    //组名
private mstrUpdUser: string="";    //修改人
private mstrUpdDate: string="";    //修改日期
private mstrMeno: string="";    //备注

/// <summary>
/// 组Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
/// </summary>
 public get PaperGroupId ()
{
return this.mstrPaperGroupId;
};
/// <summary>
/// 组Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
/// </summary>
 public set PaperGroupId (value: string)
{
 this.mstrPaperGroupId = value;
    this.hmProperty["PaperGroupId"] = true;
};

/// <summary>
/// 组名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
/// </summary>
 public get PaperGroupName ()
{
return this.mstrPaperGroupName;
};
/// <summary>
/// 组名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
/// </summary>
 public set PaperGroupName (value: string)
{
 this.mstrPaperGroupName = value;
    this.hmProperty["PaperGroupName"] = true;
};

/// <summary>
/// 修改人(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
/// </summary>
 public get UpdUser ()
{
return this.mstrUpdUser;
};
/// <summary>
/// 修改人(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
/// </summary>
 public set UpdUser (value: string)
{
 this.mstrUpdUser = value;
    this.hmProperty["UpdUser"] = true;
};

/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
/// </summary>
 public get UpdDate ()
{
return this.mstrUpdDate;
};
/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
/// </summary>
 public set UpdDate (value: string)
{
 this.mstrUpdDate = value;
    this.hmProperty["UpdDate"] = true;
};

/// <summary>
/// 备注(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
/// </summary>
 public get Meno ()
{
return this.mstrMeno;
};
/// <summary>
/// 备注(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
/// </summary>
 public set Meno (value: string)
{
 this.mstrMeno = value;
    this.hmProperty["Meno"] = true;
};



 /// <summary>
 /// 常量:"PaperGroupId"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public static get con_PaperGroupId(): string {return "PaperGroupId";}    //组Id

 /// <summary>
 /// 常量:"PaperGroupName"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public static get con_PaperGroupName(): string {return "PaperGroupName";}    //组名

 /// <summary>
 /// 常量:"UpdUser"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public static get con_UpdUser(): string {return "UpdUser";}    //修改人

 /// <summary>
 /// 常量:"UpdDate"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public static get con_UpdDate(): string {return "UpdDate";}    //修改日期

 /// <summary>
 /// 常量:"Meno"
 /// (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 /// </summary>
 public static get con_Meno(): string {return "Meno";}    //备注

public SetCondFldValue(strFldName: string, strFldValue: any, strComparisonOp: string): void {                
this[strFldName] = strFldValue;
if (this.dicFldComparisonOp.hasOwnProperty(strFldName) == false)
{
this.dicFldComparisonOp[strFldName] = strComparisonOp;
}
else
{
this.dicFldComparisonOp[strFldName] = strComparisonOp;
}
this.sf_FldComparisonOp = JSON.stringify(this.dicFldComparisonOp);
}
};
 /// <summary>
 /// 论文分组(gs_PaperGroup)
 /// (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 /// </summary>
export class clsgs_PaperGroupEN_Sim
{
//以下是属性变量

/// <summary>
/// 组Id(说明:;字段类型:char;字段长度:8;是否可空:True)
 /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
/// </summary>
 public PaperGroupId: string = "";

/// <summary>
/// 组名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
/// </summary>
 public PaperGroupName: string = "";

/// <summary>
/// 修改人(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
/// </summary>
 public UpdUser: string = "";

/// <summary>
/// 修改日期(说明:;字段类型:varchar;字段长度:20;是否可空:True)
 /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
/// </summary>
 public UpdDate: string = "";

/// <summary>
/// 备注(说明:;字段类型:varchar;字段长度:2000;是否可空:True)
 /// (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
/// </summary>
 public Meno: string = "";

public sf_UpdFldSetStr: string = "";     //专门用于记录某字段属性是否修改
public sf_FldComparisonOp: string = "";     //专门用于记录条件对象某字段的比较运算符
};