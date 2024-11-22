
 /**
 * 类名:clssys_RequestPushENEx
 * 表名:sys_RequestPush(01120726)
 * 生成代码版本:2022.11.02.1
 * 生成日期:2022/11/02 11:47:11
 * 生成者:pyf
 工程名称:问卷调查(0112)
 CM工程:研究生论文学习(变量首字母小写)-全部函数集
 * 相关数据库:103.116.76.183,9433EduHigh_Jsie
 * PrjDataBaseId:0170
 模块中文名:研培设置(GraduateEduTools)
 * 框架-层名:实体扩展层(TS)(EntityLayerEx)
 * 编程语言:TypeScript
 **/
 /**
 * 请求推送表(sys_RequestPush)
 * (AutoGCLib.EntityLayerEx4TypeScript:GeneCode)
 **/
import { clssys_RequestPushEN } from "../../L0_Entity/GraduateEduTools/clssys_RequestPushEN.js";

export class clssys_RequestPushENEx extends clssys_RequestPushEN
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
case clssys_RequestPushENEx.con_UserName:
return this.userName;
case clssys_RequestPushENEx.con_EduClsName:
return this.eduClsName;
default:
const strValue = super.GetFldValue(strFldName);
return strValue;
}
}


 /**
 * 常量:"UserName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_UserName(): string {return "userName";}    //用户名

 /**
 * 常量:"EduClsName"
 * (AGC.BusinessLogicEx.clsPrjTabFldBLEx:DefPropertyNameConst)
 */
 public static get con_EduClsName(): string {return "eduClsName";}    //教学班名

public userName = "";    //用户名
public eduClsName = "";    //教学班名
}