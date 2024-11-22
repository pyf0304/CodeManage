
 /**
 * 类名:clsgs_ParagraphTypeENEx
 * 表名:gs_ParagraphType(01120746)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 16:58:53
 * 生成者:pyf
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:研培参数(ParameterTable)
 * 框架-层名:实体扩展层(TS)(EntityLayerEx)
 * 编程语言:TypeScript
 **/
 /**
 * 段落类型(gs_ParagraphType)
 * (AutoGCLib.EntityLayerEx4TypeScript:GeneCode)
 **/
import { clsgs_ParagraphTypeEN } from "../../L0_Entity/ParameterTable/clsgs_ParagraphTypeEN.js";

export class clsgs_ParagraphTypeENEx extends clsgs_ParagraphTypeEN
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