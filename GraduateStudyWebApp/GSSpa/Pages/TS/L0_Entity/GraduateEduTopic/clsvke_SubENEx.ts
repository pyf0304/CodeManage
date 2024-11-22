﻿
 /**
 * 类名:clsvke_SubENEx
 * 表名:vke_Sub(01120659)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 12:02:55
 * 生成者:pyf
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:研培主题(GraduateEduTopic)
 * 框架-层名:实体扩展层(TS)(EntityLayerEx)
 * 编程语言:TypeScript
 **/
 /**
 * 知识经济子类视图(vke_Sub)
 * (AutoGCLib.EntityLayerEx4TypeScript:GeneCode)
 **/
import { clsvke_SubEN } from "../../L0_Entity/GraduateEduTopic/clsvke_SubEN.js";

export class clsvke_SubENEx extends clsvke_SubEN
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