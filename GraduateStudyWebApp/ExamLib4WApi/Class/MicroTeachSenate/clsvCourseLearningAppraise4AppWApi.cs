
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCourseLearningAppraise4AppWApi
 表名:vCourseLearningAppraise4App(01120273)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:39:35
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议
 模块英文名:MicroTeachSenate
 框架-层名:WA_访问层_CS(WA_Access)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Data; 
using System.Data.SqlClient;
using System.Text; 
using System.Web;
using System.Collections; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using com.taishsoft.common;
using com.taishsoft.comm_db_obj;
using com.taishsoft.dynamiccompiler;
using com.taishsoft.json;
using ExamLib.Entity;

namespace ExamLib4WApi
{
public static class clsvCourseLearningAppraise4AppWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraise4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraise4AppEN Setid_MicroteachAppraise(this clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppEN, long lngid_MicroteachAppraise, string strComparisonOp="")
	{
objvCourseLearningAppraise4AppEN.id_MicroteachAppraise = lngid_MicroteachAppraise; //评议流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraise4AppEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise4App.id_MicroteachAppraise) == false)
{
objvCourseLearningAppraise4AppEN.dicFldComparisonOp.Add(convCourseLearningAppraise4App.id_MicroteachAppraise, strComparisonOp);
}
else
{
objvCourseLearningAppraise4AppEN.dicFldComparisonOp[convCourseLearningAppraise4App.id_MicroteachAppraise] = strComparisonOp;
}
}
return objvCourseLearningAppraise4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraise4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraise4AppEN SetFuncModuleId(this clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convCourseLearningAppraise4App.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convCourseLearningAppraise4App.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convCourseLearningAppraise4App.FuncModuleId);
objvCourseLearningAppraise4AppEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraise4AppEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise4App.FuncModuleId) == false)
{
objvCourseLearningAppraise4AppEN.dicFldComparisonOp.Add(convCourseLearningAppraise4App.FuncModuleId, strComparisonOp);
}
else
{
objvCourseLearningAppraise4AppEN.dicFldComparisonOp[convCourseLearningAppraise4App.FuncModuleId] = strComparisonOp;
}
}
return objvCourseLearningAppraise4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraise4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraise4AppEN SetFuncModuleName(this clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convCourseLearningAppraise4App.FuncModuleName);
objvCourseLearningAppraise4AppEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraise4AppEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise4App.FuncModuleName) == false)
{
objvCourseLearningAppraise4AppEN.dicFldComparisonOp.Add(convCourseLearningAppraise4App.FuncModuleName, strComparisonOp);
}
else
{
objvCourseLearningAppraise4AppEN.dicFldComparisonOp[convCourseLearningAppraise4App.FuncModuleName] = strComparisonOp;
}
}
return objvCourseLearningAppraise4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraise4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraise4AppEN Setid_MicroteachCase(this clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCase, convCourseLearningAppraise4App.id_MicroteachCase);
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convCourseLearningAppraise4App.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convCourseLearningAppraise4App.id_MicroteachCase);
objvCourseLearningAppraise4AppEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraise4AppEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise4App.id_MicroteachCase) == false)
{
objvCourseLearningAppraise4AppEN.dicFldComparisonOp.Add(convCourseLearningAppraise4App.id_MicroteachCase, strComparisonOp);
}
else
{
objvCourseLearningAppraise4AppEN.dicFldComparisonOp[convCourseLearningAppraise4App.id_MicroteachCase] = strComparisonOp;
}
}
return objvCourseLearningAppraise4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraise4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraise4AppEN SetId_CourseLearningCase(this clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppEN, string strId_CourseLearningCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_CourseLearningCase, 8, convCourseLearningAppraise4App.Id_CourseLearningCase);
clsCheckSql.CheckFieldForeignKey(strId_CourseLearningCase, 8, convCourseLearningAppraise4App.Id_CourseLearningCase);
objvCourseLearningAppraise4AppEN.Id_CourseLearningCase = strId_CourseLearningCase; //课程学习案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraise4AppEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise4App.Id_CourseLearningCase) == false)
{
objvCourseLearningAppraise4AppEN.dicFldComparisonOp.Add(convCourseLearningAppraise4App.Id_CourseLearningCase, strComparisonOp);
}
else
{
objvCourseLearningAppraise4AppEN.dicFldComparisonOp[convCourseLearningAppraise4App.Id_CourseLearningCase] = strComparisonOp;
}
}
return objvCourseLearningAppraise4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraise4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraise4AppEN SetCourseLearningCaseName(this clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppEN, string strCourseLearningCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseLearningCaseName, convCourseLearningAppraise4App.CourseLearningCaseName);
clsCheckSql.CheckFieldLen(strCourseLearningCaseName, 100, convCourseLearningAppraise4App.CourseLearningCaseName);
objvCourseLearningAppraise4AppEN.CourseLearningCaseName = strCourseLearningCaseName; //课程学习案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraise4AppEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise4App.CourseLearningCaseName) == false)
{
objvCourseLearningAppraise4AppEN.dicFldComparisonOp.Add(convCourseLearningAppraise4App.CourseLearningCaseName, strComparisonOp);
}
else
{
objvCourseLearningAppraise4AppEN.dicFldComparisonOp[convCourseLearningAppraise4App.CourseLearningCaseName] = strComparisonOp;
}
}
return objvCourseLearningAppraise4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraise4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraise4AppEN Setid_AppraiseType(this clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppEN, string strid_AppraiseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_AppraiseType, convCourseLearningAppraise4App.id_AppraiseType);
clsCheckSql.CheckFieldLen(strid_AppraiseType, 4, convCourseLearningAppraise4App.id_AppraiseType);
clsCheckSql.CheckFieldForeignKey(strid_AppraiseType, 4, convCourseLearningAppraise4App.id_AppraiseType);
objvCourseLearningAppraise4AppEN.id_AppraiseType = strid_AppraiseType; //评议类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraise4AppEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise4App.id_AppraiseType) == false)
{
objvCourseLearningAppraise4AppEN.dicFldComparisonOp.Add(convCourseLearningAppraise4App.id_AppraiseType, strComparisonOp);
}
else
{
objvCourseLearningAppraise4AppEN.dicFldComparisonOp[convCourseLearningAppraise4App.id_AppraiseType] = strComparisonOp;
}
}
return objvCourseLearningAppraise4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraise4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraise4AppEN SetAppraiseTypeName(this clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppEN, string strAppraiseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAppraiseTypeName, 50, convCourseLearningAppraise4App.AppraiseTypeName);
objvCourseLearningAppraise4AppEN.AppraiseTypeName = strAppraiseTypeName; //评议类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraise4AppEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise4App.AppraiseTypeName) == false)
{
objvCourseLearningAppraise4AppEN.dicFldComparisonOp.Add(convCourseLearningAppraise4App.AppraiseTypeName, strComparisonOp);
}
else
{
objvCourseLearningAppraise4AppEN.dicFldComparisonOp[convCourseLearningAppraise4App.AppraiseTypeName] = strComparisonOp;
}
}
return objvCourseLearningAppraise4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraise4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraise4AppEN SetAppraiseContent(this clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppEN, string strAppraiseContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAppraiseContent, 2000, convCourseLearningAppraise4App.AppraiseContent);
objvCourseLearningAppraise4AppEN.AppraiseContent = strAppraiseContent; //评议内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraise4AppEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise4App.AppraiseContent) == false)
{
objvCourseLearningAppraise4AppEN.dicFldComparisonOp.Add(convCourseLearningAppraise4App.AppraiseContent, strComparisonOp);
}
else
{
objvCourseLearningAppraise4AppEN.dicFldComparisonOp[convCourseLearningAppraise4App.AppraiseContent] = strComparisonOp;
}
}
return objvCourseLearningAppraise4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraise4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraise4AppEN SetAppraiseDate(this clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppEN, string strAppraiseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAppraiseDate, 8, convCourseLearningAppraise4App.AppraiseDate);
clsCheckSql.CheckFieldForeignKey(strAppraiseDate, 8, convCourseLearningAppraise4App.AppraiseDate);
objvCourseLearningAppraise4AppEN.AppraiseDate = strAppraiseDate; //评议日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraise4AppEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise4App.AppraiseDate) == false)
{
objvCourseLearningAppraise4AppEN.dicFldComparisonOp.Add(convCourseLearningAppraise4App.AppraiseDate, strComparisonOp);
}
else
{
objvCourseLearningAppraise4AppEN.dicFldComparisonOp[convCourseLearningAppraise4App.AppraiseDate] = strComparisonOp;
}
}
return objvCourseLearningAppraise4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraise4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraise4AppEN SetAppraiseTime(this clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppEN, string strAppraiseTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAppraiseTime, 6, convCourseLearningAppraise4App.AppraiseTime);
clsCheckSql.CheckFieldForeignKey(strAppraiseTime, 6, convCourseLearningAppraise4App.AppraiseTime);
objvCourseLearningAppraise4AppEN.AppraiseTime = strAppraiseTime; //评议时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraise4AppEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise4App.AppraiseTime) == false)
{
objvCourseLearningAppraise4AppEN.dicFldComparisonOp.Add(convCourseLearningAppraise4App.AppraiseTime, strComparisonOp);
}
else
{
objvCourseLearningAppraise4AppEN.dicFldComparisonOp[convCourseLearningAppraise4App.AppraiseTime] = strComparisonOp;
}
}
return objvCourseLearningAppraise4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraise4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningAppraise4AppEN SetUserId(this clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convCourseLearningAppraise4App.UserId);
clsCheckSql.CheckFieldLen(strUserId, 20, convCourseLearningAppraise4App.UserId);
objvCourseLearningAppraise4AppEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraise4AppEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise4App.UserId) == false)
{
objvCourseLearningAppraise4AppEN.dicFldComparisonOp.Add(convCourseLearningAppraise4App.UserId, strComparisonOp);
}
else
{
objvCourseLearningAppraise4AppEN.dicFldComparisonOp[convCourseLearningAppraise4App.UserId] = strComparisonOp;
}
}
return objvCourseLearningAppraise4AppEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4App_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCourseLearningAppraise4App_Cond.IsUpdated(convCourseLearningAppraise4App.id_MicroteachAppraise) == true)
{
string strComparisonOp_id_MicroteachAppraise = objvCourseLearningAppraise4App_Cond.dicFldComparisonOp[convCourseLearningAppraise4App.id_MicroteachAppraise];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningAppraise4App.id_MicroteachAppraise, objvCourseLearningAppraise4App_Cond.id_MicroteachAppraise, strComparisonOp_id_MicroteachAppraise);
}
if (objvCourseLearningAppraise4App_Cond.IsUpdated(convCourseLearningAppraise4App.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvCourseLearningAppraise4App_Cond.dicFldComparisonOp[convCourseLearningAppraise4App.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise4App.FuncModuleId, objvCourseLearningAppraise4App_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvCourseLearningAppraise4App_Cond.IsUpdated(convCourseLearningAppraise4App.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvCourseLearningAppraise4App_Cond.dicFldComparisonOp[convCourseLearningAppraise4App.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise4App.FuncModuleName, objvCourseLearningAppraise4App_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvCourseLearningAppraise4App_Cond.IsUpdated(convCourseLearningAppraise4App.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvCourseLearningAppraise4App_Cond.dicFldComparisonOp[convCourseLearningAppraise4App.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise4App.id_MicroteachCase, objvCourseLearningAppraise4App_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvCourseLearningAppraise4App_Cond.IsUpdated(convCourseLearningAppraise4App.Id_CourseLearningCase) == true)
{
string strComparisonOp_Id_CourseLearningCase = objvCourseLearningAppraise4App_Cond.dicFldComparisonOp[convCourseLearningAppraise4App.Id_CourseLearningCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise4App.Id_CourseLearningCase, objvCourseLearningAppraise4App_Cond.Id_CourseLearningCase, strComparisonOp_Id_CourseLearningCase);
}
if (objvCourseLearningAppraise4App_Cond.IsUpdated(convCourseLearningAppraise4App.CourseLearningCaseName) == true)
{
string strComparisonOp_CourseLearningCaseName = objvCourseLearningAppraise4App_Cond.dicFldComparisonOp[convCourseLearningAppraise4App.CourseLearningCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise4App.CourseLearningCaseName, objvCourseLearningAppraise4App_Cond.CourseLearningCaseName, strComparisonOp_CourseLearningCaseName);
}
if (objvCourseLearningAppraise4App_Cond.IsUpdated(convCourseLearningAppraise4App.id_AppraiseType) == true)
{
string strComparisonOp_id_AppraiseType = objvCourseLearningAppraise4App_Cond.dicFldComparisonOp[convCourseLearningAppraise4App.id_AppraiseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise4App.id_AppraiseType, objvCourseLearningAppraise4App_Cond.id_AppraiseType, strComparisonOp_id_AppraiseType);
}
if (objvCourseLearningAppraise4App_Cond.IsUpdated(convCourseLearningAppraise4App.AppraiseTypeName) == true)
{
string strComparisonOp_AppraiseTypeName = objvCourseLearningAppraise4App_Cond.dicFldComparisonOp[convCourseLearningAppraise4App.AppraiseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise4App.AppraiseTypeName, objvCourseLearningAppraise4App_Cond.AppraiseTypeName, strComparisonOp_AppraiseTypeName);
}
if (objvCourseLearningAppraise4App_Cond.IsUpdated(convCourseLearningAppraise4App.AppraiseContent) == true)
{
string strComparisonOp_AppraiseContent = objvCourseLearningAppraise4App_Cond.dicFldComparisonOp[convCourseLearningAppraise4App.AppraiseContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise4App.AppraiseContent, objvCourseLearningAppraise4App_Cond.AppraiseContent, strComparisonOp_AppraiseContent);
}
if (objvCourseLearningAppraise4App_Cond.IsUpdated(convCourseLearningAppraise4App.AppraiseDate) == true)
{
string strComparisonOp_AppraiseDate = objvCourseLearningAppraise4App_Cond.dicFldComparisonOp[convCourseLearningAppraise4App.AppraiseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise4App.AppraiseDate, objvCourseLearningAppraise4App_Cond.AppraiseDate, strComparisonOp_AppraiseDate);
}
if (objvCourseLearningAppraise4App_Cond.IsUpdated(convCourseLearningAppraise4App.AppraiseTime) == true)
{
string strComparisonOp_AppraiseTime = objvCourseLearningAppraise4App_Cond.dicFldComparisonOp[convCourseLearningAppraise4App.AppraiseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise4App.AppraiseTime, objvCourseLearningAppraise4App_Cond.AppraiseTime, strComparisonOp_AppraiseTime);
}
if (objvCourseLearningAppraise4App_Cond.IsUpdated(convCourseLearningAppraise4App.UserId) == true)
{
string strComparisonOp_UserId = objvCourseLearningAppraise4App_Cond.dicFldComparisonOp[convCourseLearningAppraise4App.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise4App.UserId, objvCourseLearningAppraise4App_Cond.UserId, strComparisonOp_UserId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v课程学习定性评议_App(vCourseLearningAppraise4App)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCourseLearningAppraise4AppWApi
{
private static readonly string mstrApiControllerName = "vCourseLearningAppraise4AppApi";

 public clsvCourseLearningAppraise4AppWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_MicroteachAppraise">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCourseLearningAppraise4AppEN GetObjByid_MicroteachAppraise(long lngid_MicroteachAppraise)
{
string strAction = "GetObjByid_MicroteachAppraise";
string strErrMsg = string.Empty;
string strResult = "";
clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroteachAppraise"] = lngid_MicroteachAppraise.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvCourseLearningAppraise4AppEN = JsonConvert.DeserializeObject<clsvCourseLearningAppraise4AppEN>((string)jobjReturn["ReturnObj"]);
return objvCourseLearningAppraise4AppEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId_WA_Cache)
 /// </summary>
 /// <param name = "lngid_MicroteachAppraise">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCourseLearningAppraise4AppEN GetObjByid_MicroteachAppraise_WA_Cache(long lngid_MicroteachAppraise)
{
string strAction = "GetObjByid_MicroteachAppraise_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroteachAppraise"] = lngid_MicroteachAppraise.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvCourseLearningAppraise4AppEN = JsonConvert.DeserializeObject<clsvCourseLearningAppraise4AppEN>((string)jobjReturn["ReturnObj"]);
return objvCourseLearningAppraise4AppEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstID)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static long GetFirstID(string strWhereCond)
{
string strAction = "GetFirstID";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var strReturnStr = (string)jobjReturn["ReturnStr"];
return long.Parse(strReturnStr);
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFirstObj)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static clsvCourseLearningAppraise4AppEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvCourseLearningAppraise4AppEN = JsonConvert.DeserializeObject<clsvCourseLearningAppraise4AppEN>((string)jobjReturn["ReturnObj"]);
return objvCourseLearningAppraise4AppEN;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKey_Cache)
 /// </summary>
 /// <param name = "lngid_MicroteachAppraise">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCourseLearningAppraise4AppEN GetObjByid_MicroteachAppraise_Cache(long lngid_MicroteachAppraise)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCourseLearningAppraise4AppEN._CurrTabName_S);
List<clsvCourseLearningAppraise4AppEN> arrvCourseLearningAppraise4AppObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCourseLearningAppraise4AppEN> arrvCourseLearningAppraise4AppObjLst_Sel =
from objvCourseLearningAppraise4AppEN in arrvCourseLearningAppraise4AppObjLst_Cache
where objvCourseLearningAppraise4AppEN.id_MicroteachAppraise == lngid_MicroteachAppraise
select objvCourseLearningAppraise4AppEN;
if (arrvCourseLearningAppraise4AppObjLst_Sel.Count() == 0)
{
   clsvCourseLearningAppraise4AppEN obj = clsvCourseLearningAppraise4AppWApi.GetObjByid_MicroteachAppraise(lngid_MicroteachAppraise);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCourseLearningAppraise4AppObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningAppraise4AppEN> GetObjLst(string strWhereCond)
{
 List<clsvCourseLearningAppraise4AppEN> arrObjLst = null; 
string strAction = "GetObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningAppraise4AppEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningAppraise4AppEN> GetObjLstById_MicroteachAppraiseLst(List<long> arrId_MicroteachAppraise)
{
 List<clsvCourseLearningAppraise4AppEN> arrObjLst = null; 
string strAction = "GetObjLstById_MicroteachAppraiseLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_MicroteachAppraise);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningAppraise4AppEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据关键字列表获取对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_Cache)
 /// </summary>
 /// <param name = "lngid_MicroteachAppraise">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvCourseLearningAppraise4AppEN> GetObjLstById_MicroteachAppraiseLst_Cache(List<long> arrId_MicroteachAppraise)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCourseLearningAppraise4AppEN._CurrTabName_S);
List<clsvCourseLearningAppraise4AppEN> arrvCourseLearningAppraise4AppObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCourseLearningAppraise4AppEN> arrvCourseLearningAppraise4AppObjLst_Sel =
from objvCourseLearningAppraise4AppEN in arrvCourseLearningAppraise4AppObjLst_Cache
where arrId_MicroteachAppraise.Contains(objvCourseLearningAppraise4AppEN.id_MicroteachAppraise)
select objvCourseLearningAppraise4AppEN;
return arrvCourseLearningAppraise4AppObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningAppraise4AppEN> GetObjLstById_MicroteachAppraiseLst_WA_Cache(List<long> arrId_MicroteachAppraise)
{
 List<clsvCourseLearningAppraise4AppEN> arrObjLst = null; 
string strAction = "GetObjLstById_MicroteachAppraiseLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_MicroteachAppraise);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningAppraise4AppEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据关键字列表获取对象列表出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取顶部对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningAppraise4AppEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCourseLearningAppraise4AppEN> arrObjLst = null; 
string strAction = "GetTopObjLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objTopPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuTopPara>(objTopPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningAppraise4AppEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("根据条件获取顶部对象列表,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取范围内的对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByRange)
 /// </summary>
 /// <param name = "objRangePara">根据范围获取记录的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningAppraise4AppEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCourseLearningAppraise4AppEN> arrObjLst = null; 
string strAction = "GetObjLstByRange";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam =  objRangePara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuRangePara>(objRangePara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningAppraise4AppEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件分页获取JSON对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clsvCourseLearningAppraise4AppEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCourseLearningAppraise4AppEN> arrObjLst = null; 
string strAction = "GetObjLstByPager";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningAppraise4AppEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件分页获取JSON对象列表, 使用缓存
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByPager_Cache)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回JSON对象列表</returns>
public static List<clsvCourseLearningAppraise4AppEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvCourseLearningAppraise4AppEN> arrObjLst = null; 
string strAction = "GetObjLstByPager_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = objPagerPara.GetDictParam();
try
{
string strJSON = clsJSON.GetJsonFromObj<stuPagerPara>(objPagerPara);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningAppraise4AppEN>>((string)jobjReturn["ReturnObjLst"]);
return arrObjLst;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件判断是否存在记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_IsExistRecord)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExistRecord(string strWhereCond)
{
//检测记录是否存在
string strAction = "IsExistRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字判断是否存在记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_IsExist)
 /// </summary>
 /// <returns>是否存在?存在返回True</returns>
public static bool IsExist(long lngid_MicroteachAppraise)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroteachAppraise"] = lngid_MicroteachAppraise.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var bolReturnBool = (bool)jobjReturn["ReturnBool"];
return bolReturnBool;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return false;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相关记录数
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int GetRecCountByCond(string strWhereCond)
{
string strAction = "GetRecCountByCond";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var intReturnInt = (int)jobjReturn["ReturnInt"];
return intReturnInt;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return 0;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件获取相关记录数
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetFldValue)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static List<string> GetFldValue(string strFldName, string strWhereCond)
{
string strAction = "GetFldValue";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strWhereCond"] = strWhereCond
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
string strReturnStrLst = (string)jobjReturn["ReturnStrLst"];
var arrReturnStrLst = strReturnStrLst.Split(",".ToCharArray());
return arrReturnStrLst.Select(x => x).ToList();
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return null;
}
catch (Exception objException)
{
string strMsg = string.Format("获取条件记录出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objvCourseLearningAppraise4AppENS">源对象</param>
 /// <param name = "objvCourseLearningAppraise4AppENT">目标对象</param>
 public static void CopyTo(clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppENS, clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppENT)
{
try
{
objvCourseLearningAppraise4AppENT.id_MicroteachAppraise = objvCourseLearningAppraise4AppENS.id_MicroteachAppraise; //评议流水号
objvCourseLearningAppraise4AppENT.FuncModuleId = objvCourseLearningAppraise4AppENS.FuncModuleId; //功能模块Id
objvCourseLearningAppraise4AppENT.FuncModuleName = objvCourseLearningAppraise4AppENS.FuncModuleName; //功能模块名称
objvCourseLearningAppraise4AppENT.id_MicroteachCase = objvCourseLearningAppraise4AppENS.id_MicroteachCase; //微格教学案例流水号
objvCourseLearningAppraise4AppENT.Id_CourseLearningCase = objvCourseLearningAppraise4AppENS.Id_CourseLearningCase; //课程学习案例流水号
objvCourseLearningAppraise4AppENT.CourseLearningCaseName = objvCourseLearningAppraise4AppENS.CourseLearningCaseName; //课程学习案例名称
objvCourseLearningAppraise4AppENT.id_AppraiseType = objvCourseLearningAppraise4AppENS.id_AppraiseType; //评议类型流水号
objvCourseLearningAppraise4AppENT.AppraiseTypeName = objvCourseLearningAppraise4AppENS.AppraiseTypeName; //评议类型名称
objvCourseLearningAppraise4AppENT.AppraiseContent = objvCourseLearningAppraise4AppENS.AppraiseContent; //评议内容
objvCourseLearningAppraise4AppENT.AppraiseDate = objvCourseLearningAppraise4AppENS.AppraiseDate; //评议日期
objvCourseLearningAppraise4AppENT.AppraiseTime = objvCourseLearningAppraise4AppENS.AppraiseTime; //评议时间
objvCourseLearningAppraise4AppENT.UserId = objvCourseLearningAppraise4AppENS.UserId; //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000001)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

/// <summary>
/// 对象列表 转换为 DataTable数据集合
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ToDataTable)
/// </summary>
/// <param name="arrObj">原对象列表</param>
/// <returns>返回的DataTable</returns>
public static DataTable ToDataTable(List<clsvCourseLearningAppraise4AppEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCourseLearningAppraise4AppEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCourseLearningAppraise4AppEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCourseLearningAppraise4AppEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCourseLearningAppraise4AppEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCourseLearningAppraise4AppEN.AttributeName)
{
dataRow[strAttrName] = objInFor[strAttrName];
}
dataTable.Rows.Add(dataRow); //循环添加行到DataTable中
}
}
catch (Exception objExceptoin)
{
throw objExceptoin;
}
result = dataTable;
return result;
}

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg = "";
if (clsFuncModuleWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleWApi没有刷新缓存机制(clsFuncModuleWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroteachAppraiseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachAppraiseWApi没有刷新缓存机制(clsMicroteachAppraiseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCourseLearningCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCourseLearningCaseWApi没有刷新缓存机制(clsCourseLearningCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAppraiseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsAppraiseTypeWApi没有刷新缓存机制(clsAppraiseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_MicroteachAppraise");
//if (arrvCourseLearningAppraise4AppObjLst_Cache == null)
//{
//arrvCourseLearningAppraise4AppObjLst_Cache = await clsvCourseLearningAppraise4AppWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvCourseLearningAppraise4AppEN._CurrTabName_S);
CacheHelper.Remove(strKey);
}
else
{
strMsg = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg);
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCourseLearningAppraise4AppEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvCourseLearningAppraise4AppEN._CurrTabName_S);
List<clsvCourseLearningAppraise4AppEN> arrvCourseLearningAppraise4AppObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCourseLearningAppraise4AppObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCourseLearningAppraise4AppEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCourseLearningAppraise4App.id_MicroteachAppraise, Type.GetType("System.Int64"));
objDT.Columns.Add(convCourseLearningAppraise4App.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningAppraise4App.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningAppraise4App.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningAppraise4App.Id_CourseLearningCase, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningAppraise4App.CourseLearningCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningAppraise4App.id_AppraiseType, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningAppraise4App.AppraiseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningAppraise4App.AppraiseContent, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningAppraise4App.AppraiseDate, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningAppraise4App.AppraiseTime, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningAppraise4App.UserId, Type.GetType("System.String"));
foreach (clsvCourseLearningAppraise4AppEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCourseLearningAppraise4App.id_MicroteachAppraise] = objInFor[convCourseLearningAppraise4App.id_MicroteachAppraise];
objDR[convCourseLearningAppraise4App.FuncModuleId] = objInFor[convCourseLearningAppraise4App.FuncModuleId];
objDR[convCourseLearningAppraise4App.FuncModuleName] = objInFor[convCourseLearningAppraise4App.FuncModuleName];
objDR[convCourseLearningAppraise4App.id_MicroteachCase] = objInFor[convCourseLearningAppraise4App.id_MicroteachCase];
objDR[convCourseLearningAppraise4App.Id_CourseLearningCase] = objInFor[convCourseLearningAppraise4App.Id_CourseLearningCase];
objDR[convCourseLearningAppraise4App.CourseLearningCaseName] = objInFor[convCourseLearningAppraise4App.CourseLearningCaseName];
objDR[convCourseLearningAppraise4App.id_AppraiseType] = objInFor[convCourseLearningAppraise4App.id_AppraiseType];
objDR[convCourseLearningAppraise4App.AppraiseTypeName] = objInFor[convCourseLearningAppraise4App.AppraiseTypeName];
objDR[convCourseLearningAppraise4App.AppraiseContent] = objInFor[convCourseLearningAppraise4App.AppraiseContent];
objDR[convCourseLearningAppraise4App.AppraiseDate] = objInFor[convCourseLearningAppraise4App.AppraiseDate];
objDR[convCourseLearningAppraise4App.AppraiseTime] = objInFor[convCourseLearningAppraise4App.AppraiseTime];
objDR[convCourseLearningAppraise4App.UserId] = objInFor[convCourseLearningAppraise4App.UserId];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}