﻿
 /**
 * 类名:clsvXzMajorENEx
 * 表名:vXzMajor(01120066)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 12:02:25
 * 生成者:pyf
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:基本信息维护(BaseInfo)
 * 框架-层名:实体扩展层(TS)(EntityLayerEx)
 * 编程语言:TypeScript
 **/
 /**
 * v专业(vXzMajor)
 * (AutoGCLib.EntityLayerEx4TypeScript:GeneCode)
 **/
import { clsvXzMajorEN } from "../../L0_Entity/BaseInfo/clsvXzMajorEN.js";

export class clsvXzMajorENEx extends clsvXzMajorEN
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