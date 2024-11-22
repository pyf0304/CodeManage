
 /**
 * 类名:clsAcademicJournalsENEx
 * 表名:AcademicJournals(01120929)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:38
 * 生成者:pyf
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:研培论文(GraduateEduPaper)
 * 框架-层名:实体扩展层(TS)(EntityLayerEx)
 * 编程语言:TypeScript
 **/
 /**
 * 学术期刊(AcademicJournals)
 * (AutoGCLib.EntityLayerEx4TypeScript:GeneCode)
 **/
import { clsAcademicJournalsEN } from "../../L0_Entity/GraduateEduPaper/clsAcademicJournalsEN.js";

export class clsAcademicJournalsENEx extends clsAcademicJournalsEN
{
//以下是属性变量

/**
 * 构造函数
 * (AutoGCLib.EntityLayerEx4TypeScript:GenClassConstructor1)
 **/
 constructor()
 {
 super();
 }

/**
 * 根据字段名获取对象中某字段的值.
 * (AutoGCLib.EntityLayerEx4TypeScript:Gen_ENEx_GetFldValue)
 * @param strFldName:字段名
 * @returns 字段值
*/
public GetFldValue(strFldName: string):any
{
const strThisFuncName = "GetFldValue";
switch (strFldName)
{
case "CtrlId":
return "";
case clsAcademicJournalsENEx.con_JournalSubjectCategoryName:
return this.journalSubjectCategoryName;
case clsAcademicJournalsENEx.con_JournalSubjectName:
return this.journalSubjectName;
case clsAcademicJournalsENEx.con_JournalSubjectCode:
return this.journalSubjectCode;
default:
const strValue = super.GetFldValue(strFldName);
return strValue;
}
}


 /**
 * 常量:"JournalSubjectCategoryName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_JournalSubjectCategoryName(): string {return "journalSubjectCategoryName";}    //期刊学科门类名称

 /**
 * 常量:"JournalSubjectName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_JournalSubjectName(): string {return "journalSubjectName";}    //期刊学科名称

 /**
 * 常量:"JournalSubjectCode"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_JournalSubjectCode(): string {return "journalSubjectCode";}    //期刊学科代码

public journalSubjectCategoryName = "";    //期刊学科门类名称
public journalSubjectName = "";    //期刊学科名称
public journalSubjectCode = "";    //期刊学科代码
}