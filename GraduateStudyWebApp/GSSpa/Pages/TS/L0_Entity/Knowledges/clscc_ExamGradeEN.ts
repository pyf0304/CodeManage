
 /**
 * 类名:clscc_ExamGradeEN
 * 表名:cc_ExamGrade(01120070)
 * 生成代码版本:2021.09.26.2
 * 生成日期:2021/09/27 23:49:35
 * 生成者:pyf
 * 工程名称:问卷调查
 * 工程ID:0112
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 * 模块中文名:知识点相关
 * 模块英文名:Knowledges
 * 框架-层名:实体层(EntityLayer)
 * 编程语言:TypeScript
 **/
 /**
 * 题库等级(cc_ExamGrade)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
import { clsGeneralTab2 } from '../../PubFun/clsGeneralTab2.js';
export class clscc_ExamGradeEN extends clsGeneralTab2
{
[x: string]: any;//索引类型
public static _CurrTabName= "cc_ExamGrade"; //当前表名,与该类相关的表名
public static _KeyFldName= "ExamGradeId"; //当前表中的关键字名称,与该类相关的表中关键字名
public static mintAttributeCount = 3;
public static AttributeName = ["ExamGradeId", "ExamGradeName", "memo"];
//以下是属性变量

/**
 * 构造函数
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClassConstructor1)
*/
 constructor()
 {
 super();
 }

private mstrExamGradeId = "";    //题库等级ID
private mstrExamGradeName = "";    //题库等级名
private mstrMemo = "";    //备注

/**
 * 题库等级ID(说明:;字段类型:char;字段长度:2;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get ExamGradeId ()
{
return this.mstrExamGradeId;
}
/**
 * 题库等级ID(说明:;字段类型:char;字段长度:2;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set ExamGradeId (value: string)
{
if (value  != undefined)
{
 this.mstrExamGradeId = value;
    this.hmProperty["ExamGradeId"] = true;
}
}

/**
 * 题库等级名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public get ExamGradeName ()
{
return this.mstrExamGradeName;
}
/**
 * 题库等级名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_EN_ClsProperty)
*/
 public set ExamGradeName (value: string)
{
if (value  != undefined)
{
 this.mstrExamGradeName = value;
    this.hmProperty["ExamGradeName"] = true;
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
 * 常量:"ExamGradeId"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ExamGradeId(): string {return "ExamGradeId";}    //题库等级ID

 /**
 * 常量:"ExamGradeName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_ExamGradeName(): string {return "ExamGradeName";}    //题库等级名

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
 * 题库等级(cc_ExamGrade)
 * (AutoGCLib.EntityLayer4TypeScript:GeneCode)
 **/
export class clscc_ExamGradeEN_Sim
{
[x: string]: any;//索引类型
//以下是属性变量

/**
 * 题库等级ID(说明:;字段类型:char;字段长度:2;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public ExamGradeId = "";

/**
 * 题库等级名(说明:;字段类型:varchar;字段长度:50;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public ExamGradeName = "";

/**
 * 备注(说明:;字段类型:varchar;字段长度:1000;是否可空:True)
 * (AutoGCLib.EntityLayer4TypeScript:Gen_SimEN_ClsProperty)
*/
 public memo = "";

public sf_UpdFldSetStr = "";     //专门用于记录某字段属性是否修改
public sf_FldComparisonOp = "";     //专门用于记录条件对象某字段的比较运算符
}