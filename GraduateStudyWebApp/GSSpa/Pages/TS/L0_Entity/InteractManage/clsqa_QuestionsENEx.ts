
 /**
 * 类名:clsqa_QuestionsENEx
 * 表名:qa_Questions(01120642)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:46:11
 * 生成者:pyf
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:互动管理(InteractManage)
 * 框架-层名:实体扩展层(TS)(EntityLayerEx)
 * 编程语言:TypeScript
 **/
 /**
 * 答疑提问表(qa_Questions)
 * (AutoGCLib.EntityLayerEx4TypeScript:GeneCode)
 **/
import { clsqa_QuestionsEN } from "../../L0_Entity/InteractManage/clsqa_QuestionsEN.js";

export class clsqa_QuestionsENEx extends clsqa_QuestionsEN
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
default:
const strValue = super.GetFldValue(strFldName);
return strValue;
}
}
}