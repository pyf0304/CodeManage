
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFunctionNameTabWApi
 表名:FunctionNameTab(01120204)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:39:57
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统设置
 模块英文名:SystemSet
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
public static class clsFunctionNameTabWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionNameTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFunctionNameTabEN SetFunctionId(this clsFunctionNameTabEN objFunctionNameTabEN, string strFunctionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFunctionId, 4, conFunctionNameTab.FunctionId);
clsCheckSql.CheckFieldForeignKey(strFunctionId, 4, conFunctionNameTab.FunctionId);
objFunctionNameTabEN.FunctionId = strFunctionId; //功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionNameTabEN.dicFldComparisonOp.ContainsKey(conFunctionNameTab.FunctionId) == false)
{
objFunctionNameTabEN.dicFldComparisonOp.Add(conFunctionNameTab.FunctionId, strComparisonOp);
}
else
{
objFunctionNameTabEN.dicFldComparisonOp[conFunctionNameTab.FunctionId] = strComparisonOp;
}
}
return objFunctionNameTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionNameTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFunctionNameTabEN SetFunctionName(this clsFunctionNameTabEN objFunctionNameTabEN, string strFunctionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionName, conFunctionNameTab.FunctionName);
clsCheckSql.CheckFieldLen(strFunctionName, 100, conFunctionNameTab.FunctionName);
objFunctionNameTabEN.FunctionName = strFunctionName; //函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionNameTabEN.dicFldComparisonOp.ContainsKey(conFunctionNameTab.FunctionName) == false)
{
objFunctionNameTabEN.dicFldComparisonOp.Add(conFunctionNameTab.FunctionName, strComparisonOp);
}
else
{
objFunctionNameTabEN.dicFldComparisonOp[conFunctionNameTab.FunctionName] = strComparisonOp;
}
}
return objFunctionNameTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionNameTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFunctionNameTabEN SetFunctionNameCH(this clsFunctionNameTabEN objFunctionNameTabEN, string strFunctionNameCH, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFunctionNameCH, 255, conFunctionNameTab.FunctionNameCH);
objFunctionNameTabEN.FunctionNameCH = strFunctionNameCH; //功能中文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionNameTabEN.dicFldComparisonOp.ContainsKey(conFunctionNameTab.FunctionNameCH) == false)
{
objFunctionNameTabEN.dicFldComparisonOp.Add(conFunctionNameTab.FunctionNameCH, strComparisonOp);
}
else
{
objFunctionNameTabEN.dicFldComparisonOp[conFunctionNameTab.FunctionNameCH] = strComparisonOp;
}
}
return objFunctionNameTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionNameTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFunctionNameTabEN SetModuleName(this clsFunctionNameTabEN objFunctionNameTabEN, string strModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModuleName, 255, conFunctionNameTab.ModuleName);
objFunctionNameTabEN.ModuleName = strModuleName; //模块名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionNameTabEN.dicFldComparisonOp.ContainsKey(conFunctionNameTab.ModuleName) == false)
{
objFunctionNameTabEN.dicFldComparisonOp.Add(conFunctionNameTab.ModuleName, strComparisonOp);
}
else
{
objFunctionNameTabEN.dicFldComparisonOp[conFunctionNameTab.ModuleName] = strComparisonOp;
}
}
return objFunctionNameTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionNameTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFunctionNameTabEN SetIsStudent(this clsFunctionNameTabEN objFunctionNameTabEN, bool bolIsStudent, string strComparisonOp="")
	{
objFunctionNameTabEN.IsStudent = bolIsStudent; //是否学生
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionNameTabEN.dicFldComparisonOp.ContainsKey(conFunctionNameTab.IsStudent) == false)
{
objFunctionNameTabEN.dicFldComparisonOp.Add(conFunctionNameTab.IsStudent, strComparisonOp);
}
else
{
objFunctionNameTabEN.dicFldComparisonOp[conFunctionNameTab.IsStudent] = strComparisonOp;
}
}
return objFunctionNameTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionNameTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFunctionNameTabEN SetIsTeacher(this clsFunctionNameTabEN objFunctionNameTabEN, bool bolIsTeacher, string strComparisonOp="")
	{
objFunctionNameTabEN.IsTeacher = bolIsTeacher; //是否教师
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionNameTabEN.dicFldComparisonOp.ContainsKey(conFunctionNameTab.IsTeacher) == false)
{
objFunctionNameTabEN.dicFldComparisonOp.Add(conFunctionNameTab.IsTeacher, strComparisonOp);
}
else
{
objFunctionNameTabEN.dicFldComparisonOp[conFunctionNameTab.IsTeacher] = strComparisonOp;
}
}
return objFunctionNameTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionNameTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFunctionNameTabEN SetIsQuestion(this clsFunctionNameTabEN objFunctionNameTabEN, bool bolIsQuestion, string strComparisonOp="")
	{
objFunctionNameTabEN.IsQuestion = bolIsQuestion; //是否题目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionNameTabEN.dicFldComparisonOp.ContainsKey(conFunctionNameTab.IsQuestion) == false)
{
objFunctionNameTabEN.dicFldComparisonOp.Add(conFunctionNameTab.IsQuestion, strComparisonOp);
}
else
{
objFunctionNameTabEN.dicFldComparisonOp[conFunctionNameTab.IsQuestion] = strComparisonOp;
}
}
return objFunctionNameTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionNameTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFunctionNameTabEN SetConstName(this clsFunctionNameTabEN objFunctionNameTabEN, string strConstName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strConstName, 255, conFunctionNameTab.ConstName);
objFunctionNameTabEN.ConstName = strConstName; //常量名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionNameTabEN.dicFldComparisonOp.ContainsKey(conFunctionNameTab.ConstName) == false)
{
objFunctionNameTabEN.dicFldComparisonOp.Add(conFunctionNameTab.ConstName, strComparisonOp);
}
else
{
objFunctionNameTabEN.dicFldComparisonOp[conFunctionNameTab.ConstName] = strComparisonOp;
}
}
return objFunctionNameTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionNameTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFunctionNameTabEN SetPagePath(this clsFunctionNameTabEN objFunctionNameTabEN, string strPagePath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPagePath, 50, conFunctionNameTab.PagePath);
objFunctionNameTabEN.PagePath = strPagePath; //页面路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionNameTabEN.dicFldComparisonOp.ContainsKey(conFunctionNameTab.PagePath) == false)
{
objFunctionNameTabEN.dicFldComparisonOp.Add(conFunctionNameTab.PagePath, strComparisonOp);
}
else
{
objFunctionNameTabEN.dicFldComparisonOp[conFunctionNameTab.PagePath] = strComparisonOp;
}
}
return objFunctionNameTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionNameTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFunctionNameTabEN SetPageName(this clsFunctionNameTabEN objFunctionNameTabEN, string strPageName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPageName, 100, conFunctionNameTab.PageName);
objFunctionNameTabEN.PageName = strPageName; //页面名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionNameTabEN.dicFldComparisonOp.ContainsKey(conFunctionNameTab.PageName) == false)
{
objFunctionNameTabEN.dicFldComparisonOp.Add(conFunctionNameTab.PageName, strComparisonOp);
}
else
{
objFunctionNameTabEN.dicFldComparisonOp[conFunctionNameTab.PageName] = strComparisonOp;
}
}
return objFunctionNameTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionNameTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFunctionNameTabEN SetOrderNum(this clsFunctionNameTabEN objFunctionNameTabEN, int intOrderNum, string strComparisonOp="")
	{
objFunctionNameTabEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionNameTabEN.dicFldComparisonOp.ContainsKey(conFunctionNameTab.OrderNum) == false)
{
objFunctionNameTabEN.dicFldComparisonOp.Add(conFunctionNameTab.OrderNum, strComparisonOp);
}
else
{
objFunctionNameTabEN.dicFldComparisonOp[conFunctionNameTab.OrderNum] = strComparisonOp;
}
}
return objFunctionNameTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionNameTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFunctionNameTabEN SetUpdDate(this clsFunctionNameTabEN objFunctionNameTabEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conFunctionNameTab.UpdDate);
objFunctionNameTabEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionNameTabEN.dicFldComparisonOp.ContainsKey(conFunctionNameTab.UpdDate) == false)
{
objFunctionNameTabEN.dicFldComparisonOp.Add(conFunctionNameTab.UpdDate, strComparisonOp);
}
else
{
objFunctionNameTabEN.dicFldComparisonOp[conFunctionNameTab.UpdDate] = strComparisonOp;
}
}
return objFunctionNameTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionNameTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFunctionNameTabEN SetUpdUser(this clsFunctionNameTabEN objFunctionNameTabEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, conFunctionNameTab.UpdUser);
objFunctionNameTabEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionNameTabEN.dicFldComparisonOp.ContainsKey(conFunctionNameTab.UpdUser) == false)
{
objFunctionNameTabEN.dicFldComparisonOp.Add(conFunctionNameTab.UpdUser, strComparisonOp);
}
else
{
objFunctionNameTabEN.dicFldComparisonOp[conFunctionNameTab.UpdUser] = strComparisonOp;
}
}
return objFunctionNameTabEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionNameTabEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFunctionNameTabEN SetMemo(this clsFunctionNameTabEN objFunctionNameTabEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conFunctionNameTab.Memo);
objFunctionNameTabEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionNameTabEN.dicFldComparisonOp.ContainsKey(conFunctionNameTab.Memo) == false)
{
objFunctionNameTabEN.dicFldComparisonOp.Add(conFunctionNameTab.Memo, strComparisonOp);
}
else
{
objFunctionNameTabEN.dicFldComparisonOp[conFunctionNameTab.Memo] = strComparisonOp;
}
}
return objFunctionNameTabEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFunctionNameTabEN objFunctionNameTab_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFunctionNameTab_Cond.IsUpdated(conFunctionNameTab.FunctionId) == true)
{
string strComparisonOp_FunctionId = objFunctionNameTab_Cond.dicFldComparisonOp[conFunctionNameTab.FunctionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionNameTab.FunctionId, objFunctionNameTab_Cond.FunctionId, strComparisonOp_FunctionId);
}
if (objFunctionNameTab_Cond.IsUpdated(conFunctionNameTab.FunctionName) == true)
{
string strComparisonOp_FunctionName = objFunctionNameTab_Cond.dicFldComparisonOp[conFunctionNameTab.FunctionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionNameTab.FunctionName, objFunctionNameTab_Cond.FunctionName, strComparisonOp_FunctionName);
}
if (objFunctionNameTab_Cond.IsUpdated(conFunctionNameTab.FunctionNameCH) == true)
{
string strComparisonOp_FunctionNameCH = objFunctionNameTab_Cond.dicFldComparisonOp[conFunctionNameTab.FunctionNameCH];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionNameTab.FunctionNameCH, objFunctionNameTab_Cond.FunctionNameCH, strComparisonOp_FunctionNameCH);
}
if (objFunctionNameTab_Cond.IsUpdated(conFunctionNameTab.ModuleName) == true)
{
string strComparisonOp_ModuleName = objFunctionNameTab_Cond.dicFldComparisonOp[conFunctionNameTab.ModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionNameTab.ModuleName, objFunctionNameTab_Cond.ModuleName, strComparisonOp_ModuleName);
}
if (objFunctionNameTab_Cond.IsUpdated(conFunctionNameTab.IsStudent) == true)
{
if (objFunctionNameTab_Cond.IsStudent == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFunctionNameTab.IsStudent);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFunctionNameTab.IsStudent);
}
}
if (objFunctionNameTab_Cond.IsUpdated(conFunctionNameTab.IsTeacher) == true)
{
if (objFunctionNameTab_Cond.IsTeacher == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFunctionNameTab.IsTeacher);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFunctionNameTab.IsTeacher);
}
}
if (objFunctionNameTab_Cond.IsUpdated(conFunctionNameTab.IsQuestion) == true)
{
if (objFunctionNameTab_Cond.IsQuestion == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFunctionNameTab.IsQuestion);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFunctionNameTab.IsQuestion);
}
}
if (objFunctionNameTab_Cond.IsUpdated(conFunctionNameTab.ConstName) == true)
{
string strComparisonOp_ConstName = objFunctionNameTab_Cond.dicFldComparisonOp[conFunctionNameTab.ConstName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionNameTab.ConstName, objFunctionNameTab_Cond.ConstName, strComparisonOp_ConstName);
}
if (objFunctionNameTab_Cond.IsUpdated(conFunctionNameTab.PagePath) == true)
{
string strComparisonOp_PagePath = objFunctionNameTab_Cond.dicFldComparisonOp[conFunctionNameTab.PagePath];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionNameTab.PagePath, objFunctionNameTab_Cond.PagePath, strComparisonOp_PagePath);
}
if (objFunctionNameTab_Cond.IsUpdated(conFunctionNameTab.PageName) == true)
{
string strComparisonOp_PageName = objFunctionNameTab_Cond.dicFldComparisonOp[conFunctionNameTab.PageName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionNameTab.PageName, objFunctionNameTab_Cond.PageName, strComparisonOp_PageName);
}
if (objFunctionNameTab_Cond.IsUpdated(conFunctionNameTab.OrderNum) == true)
{
string strComparisonOp_OrderNum = objFunctionNameTab_Cond.dicFldComparisonOp[conFunctionNameTab.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conFunctionNameTab.OrderNum, objFunctionNameTab_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objFunctionNameTab_Cond.IsUpdated(conFunctionNameTab.UpdDate) == true)
{
string strComparisonOp_UpdDate = objFunctionNameTab_Cond.dicFldComparisonOp[conFunctionNameTab.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionNameTab.UpdDate, objFunctionNameTab_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objFunctionNameTab_Cond.IsUpdated(conFunctionNameTab.UpdUser) == true)
{
string strComparisonOp_UpdUser = objFunctionNameTab_Cond.dicFldComparisonOp[conFunctionNameTab.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionNameTab.UpdUser, objFunctionNameTab_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objFunctionNameTab_Cond.IsUpdated(conFunctionNameTab.Memo) == true)
{
string strComparisonOp_Memo = objFunctionNameTab_Cond.dicFldComparisonOp[conFunctionNameTab.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionNameTab.Memo, objFunctionNameTab_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objFunctionNameTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFunctionNameTabEN objFunctionNameTabEN)
{
 if (string.IsNullOrEmpty(objFunctionNameTabEN.FunctionId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objFunctionNameTabEN.sf_UpdFldSetStr = objFunctionNameTabEN.getsf_UpdFldSetStr();
clsFunctionNameTabWApi.CheckPropertyNew(objFunctionNameTabEN); 
bool bolResult = clsFunctionNameTabWApi.UpdateRecord(objFunctionNameTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionNameTabWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000004)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objFunctionNameTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFunctionNameTabEN objFunctionNameTabEN)
{
 if (string.IsNullOrEmpty(objFunctionNameTabEN.FunctionId) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsFunctionNameTabWApi.IsExist(objFunctionNameTabEN.FunctionId) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objFunctionNameTabEN.FunctionId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsFunctionNameTabWApi.CheckPropertyNew(objFunctionNameTabEN); 
bool bolResult = clsFunctionNameTabWApi.AddNewRecord(objFunctionNameTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionNameTabWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000008)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objFunctionNameTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsFunctionNameTabEN objFunctionNameTabEN)
{
try
{
clsFunctionNameTabWApi.CheckPropertyNew(objFunctionNameTabEN); 
string strFunctionId = clsFunctionNameTabWApi.AddNewRecordWithMaxId(objFunctionNameTabEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionNameTabWApi.ReFreshCache();
return strFunctionId;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000009)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objFunctionNameTabEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFunctionNameTabEN objFunctionNameTabEN, string strWhereCond)
{
try
{
clsFunctionNameTabWApi.CheckPropertyNew(objFunctionNameTabEN); 
bool bolResult = clsFunctionNameTabWApi.UpdateWithCondition(objFunctionNameTabEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionNameTabWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000007)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 函数名表(FunctionNameTab)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsFunctionNameTabWApi
{
private static readonly string mstrApiControllerName = "FunctionNameTabApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsFunctionNameTabWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_FunctionId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[函数名表]...","0");
List<clsFunctionNameTabEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="FunctionId";
objDDL.DataTextField="FunctionName";
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>
public static void BindCbo_FunctionId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", conFunctionNameTab.FunctionId); 
List<clsFunctionNameTabEN> arrObjLst = clsFunctionNameTabWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsFunctionNameTabEN objFunctionNameTabEN = new clsFunctionNameTabEN()
{
FunctionId = "0",
FunctionName = "选[函数名表]..."
};
arrObjLst.Insert(0, objFunctionNameTabEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = conFunctionNameTab.FunctionId;
objComboBox.DisplayMember = conFunctionNameTab.FunctionName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsFunctionNameTabEN objFunctionNameTabEN)
{
if (!Object.Equals(null, objFunctionNameTabEN.FunctionId) && GetStrLen(objFunctionNameTabEN.FunctionId) > 4)
{
 throw new Exception("字段[功能Id]的长度不能超过4!");
}
if (!Object.Equals(null, objFunctionNameTabEN.FunctionName) && GetStrLen(objFunctionNameTabEN.FunctionName) > 100)
{
 throw new Exception("字段[函数名]的长度不能超过100!");
}
if (!Object.Equals(null, objFunctionNameTabEN.FunctionNameCH) && GetStrLen(objFunctionNameTabEN.FunctionNameCH) > 255)
{
 throw new Exception("字段[功能中文名]的长度不能超过255!");
}
if (!Object.Equals(null, objFunctionNameTabEN.ModuleName) && GetStrLen(objFunctionNameTabEN.ModuleName) > 255)
{
 throw new Exception("字段[模块名]的长度不能超过255!");
}
if (!Object.Equals(null, objFunctionNameTabEN.ConstName) && GetStrLen(objFunctionNameTabEN.ConstName) > 255)
{
 throw new Exception("字段[常量名]的长度不能超过255!");
}
if (!Object.Equals(null, objFunctionNameTabEN.PagePath) && GetStrLen(objFunctionNameTabEN.PagePath) > 50)
{
 throw new Exception("字段[页面路径]的长度不能超过50!");
}
if (!Object.Equals(null, objFunctionNameTabEN.PageName) && GetStrLen(objFunctionNameTabEN.PageName) > 100)
{
 throw new Exception("字段[页面名称]的长度不能超过100!");
}
if (!Object.Equals(null, objFunctionNameTabEN.UpdDate) && GetStrLen(objFunctionNameTabEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objFunctionNameTabEN.UpdUser) && GetStrLen(objFunctionNameTabEN.UpdUser) > 20)
{
 throw new Exception("字段[修改人]的长度不能超过20!");
}
if (!Object.Equals(null, objFunctionNameTabEN.Memo) && GetStrLen(objFunctionNameTabEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objFunctionNameTabEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFunctionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFunctionNameTabEN GetObjByFunctionId(string strFunctionId)
{
string strAction = "GetObjByFunctionId";
string strErrMsg = string.Empty;
string strResult = "";
clsFunctionNameTabEN objFunctionNameTabEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["FunctionId"] = strFunctionId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objFunctionNameTabEN = JsonConvert.DeserializeObject<clsFunctionNameTabEN>((string)jobjReturn["ReturnObj"]);
return objFunctionNameTabEN;
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
 /// <param name = "strFunctionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFunctionNameTabEN GetObjByFunctionId_WA_Cache(string strFunctionId)
{
string strAction = "GetObjByFunctionId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsFunctionNameTabEN objFunctionNameTabEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["FunctionId"] = strFunctionId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objFunctionNameTabEN = JsonConvert.DeserializeObject<clsFunctionNameTabEN>((string)jobjReturn["ReturnObj"]);
return objFunctionNameTabEN;
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
public static string GetFirstID(string strWhereCond)
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
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
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
public static clsFunctionNameTabEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsFunctionNameTabEN objFunctionNameTabEN = null;
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
objFunctionNameTabEN = JsonConvert.DeserializeObject<clsFunctionNameTabEN>((string)jobjReturn["ReturnObj"]);
return objFunctionNameTabEN;
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
 /// <param name = "strFunctionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFunctionNameTabEN GetObjByFunctionId_Cache(string strFunctionId)
{
if (string.IsNullOrEmpty(strFunctionId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsFunctionNameTabEN._CurrTabName_S);
List<clsFunctionNameTabEN> arrFunctionNameTabObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsFunctionNameTabEN> arrFunctionNameTabObjLst_Sel =
from objFunctionNameTabEN in arrFunctionNameTabObjLst_Cache
where objFunctionNameTabEN.FunctionId == strFunctionId
select objFunctionNameTabEN;
if (arrFunctionNameTabObjLst_Sel.Count() == 0)
{
   clsFunctionNameTabEN obj = clsFunctionNameTabWApi.GetObjByFunctionId(strFunctionId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrFunctionNameTabObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strFunctionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetFunctionNameByFunctionId_Cache(string strFunctionId)
{
if (string.IsNullOrEmpty(strFunctionId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsFunctionNameTabEN._CurrTabName_S);
List<clsFunctionNameTabEN> arrFunctionNameTabObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsFunctionNameTabEN> arrFunctionNameTabObjLst_Sel1 =
from objFunctionNameTabEN in arrFunctionNameTabObjLst_Cache
where objFunctionNameTabEN.FunctionId == strFunctionId
select objFunctionNameTabEN;
List <clsFunctionNameTabEN> arrFunctionNameTabObjLst_Sel = new List<clsFunctionNameTabEN>();
foreach (clsFunctionNameTabEN obj in arrFunctionNameTabObjLst_Sel1)
{
arrFunctionNameTabObjLst_Sel.Add(obj);
}
if (arrFunctionNameTabObjLst_Sel.Count > 0)
{
return arrFunctionNameTabObjLst_Sel[0].FunctionName;
}
string strErrMsgForGetObjById = string.Format("在FunctionNameTab对象缓存列表中,找不到记录[FunctionId = {0}](函数:{1})", strFunctionId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsFunctionNameTabBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strFunctionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByFunctionId_Cache(string strFunctionId)
{
if (string.IsNullOrEmpty(strFunctionId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsFunctionNameTabEN._CurrTabName_S);
List<clsFunctionNameTabEN> arrFunctionNameTabObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsFunctionNameTabEN> arrFunctionNameTabObjLst_Sel1 =
from objFunctionNameTabEN in arrFunctionNameTabObjLst_Cache
where objFunctionNameTabEN.FunctionId == strFunctionId
select objFunctionNameTabEN;
List <clsFunctionNameTabEN> arrFunctionNameTabObjLst_Sel = new List<clsFunctionNameTabEN>();
foreach (clsFunctionNameTabEN obj in arrFunctionNameTabObjLst_Sel1)
{
arrFunctionNameTabObjLst_Sel.Add(obj);
}
if (arrFunctionNameTabObjLst_Sel.Count > 0)
{
return arrFunctionNameTabObjLst_Sel[0].FunctionName;
}
string strErrMsgForGetObjById = string.Format("在FunctionNameTab对象缓存列表中,找不到记录的相关名称[FunctionId = {0}](函数:{1})", strFunctionId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsFunctionNameTabBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFunctionNameTabEN> GetObjLst(string strWhereCond)
{
 List<clsFunctionNameTabEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFunctionNameTabEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsFunctionNameTabEN> GetObjLstByFunctionIdLst(List<string> arrFunctionId)
{
 List<clsFunctionNameTabEN> arrObjLst = null; 
string strAction = "GetObjLstByFunctionIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFunctionId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsFunctionNameTabEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strFunctionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsFunctionNameTabEN> GetObjLstByFunctionIdLst_Cache(List<string> arrFunctionId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsFunctionNameTabEN._CurrTabName_S);
List<clsFunctionNameTabEN> arrFunctionNameTabObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsFunctionNameTabEN> arrFunctionNameTabObjLst_Sel =
from objFunctionNameTabEN in arrFunctionNameTabObjLst_Cache
where arrFunctionId.Contains(objFunctionNameTabEN.FunctionId)
select objFunctionNameTabEN;
return arrFunctionNameTabObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFunctionNameTabEN> GetObjLstByFunctionIdLst_WA_Cache(List<string> arrFunctionId)
{
 List<clsFunctionNameTabEN> arrObjLst = null; 
string strAction = "GetObjLstByFunctionIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFunctionId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsFunctionNameTabEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsFunctionNameTabEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsFunctionNameTabEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFunctionNameTabEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsFunctionNameTabEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsFunctionNameTabEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFunctionNameTabEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsFunctionNameTabEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsFunctionNameTabEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFunctionNameTabEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsFunctionNameTabEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsFunctionNameTabEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFunctionNameTabEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// 根据关键字删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecord(string strFunctionId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsFunctionNameTabEN objFunctionNameTabEN = clsFunctionNameTabWApi.GetObjByFunctionId(strFunctionId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strFunctionId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsFunctionNameTabWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecords)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecords(string strKeyIdLst)
{
string strAction = "DelRecords";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out strResult, out strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelFunctionNameTabs(List<string> arrFunctionId)
{
string strAction = "DelFunctionNameTabs";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFunctionId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsFunctionNameTabWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelFunctionNameTabsByCond(string strWhereCond)
{
string strAction = "DelFunctionNameTabsByCond";
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool AddNewRecord(clsFunctionNameTabEN objFunctionNameTabEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFunctionNameTabEN>(objFunctionNameTabEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionNameTabWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>是否成功?</returns>
public static string AddNewRecordWithMaxId(clsFunctionNameTabEN objFunctionNameTabEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFunctionNameTabEN>(objFunctionNameTabEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionNameTabWApi.ReFreshCache();
var strFunctionId = (string)jobjReturn["ReturnStr"];
return strFunctionId;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsFunctionNameTabEN objFunctionNameTabEN)
{
if (string.IsNullOrEmpty(objFunctionNameTabEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objFunctionNameTabEN.FunctionId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFunctionNameTabEN>(objFunctionNameTabEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateWithCondition)
 /// </summary>
 /// <param name = "objFunctionNameTabEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsFunctionNameTabEN objFunctionNameTabEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objFunctionNameTabEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objFunctionNameTabEN.FunctionId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objFunctionNameTabEN.FunctionId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFunctionNameTabEN>(objFunctionNameTabEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
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
public static bool IsExist(string strFunctionId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["FunctionId"] = strFunctionId
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
 /// 根据条件设置字段值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_funSetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int SetFldValue(string strFldName, string strValue, string strWhereCond)
{
string strAction = "SetFldValue";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
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
string strMsg = string.Format("根据条件设置字段值,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId()
{
string strAction = "GetMaxStrId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var strReturnStr = (string)jobjReturn["ReturnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
}
catch (Exception objException)
{
string strMsg = string.Format("获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix(string strPrefix)
{
//检测记录是否存在
string strAction = "GetMaxStrIdByPrefix";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strPrefix", strPrefix);
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
var strReturnStr = (string)jobjReturn["ReturnStr"];
return strReturnStr;
}
else
{
string strMsg = string.Format("{0}", jobjReturn["ErrorMsg"]);
throw new Exception(strMsg);
}
}
else return "";
}
catch (Exception objException)
{
string strMsg = string.Format("根据前缀获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AutoGCLib.clsGeneCodeBase:GengetStrLen)
 /// </summary>
 /// <param name = "strTemp">给定的原字符串</param>
 /// <returns>返回字符串长度</returns>
public static int GetStrLen(string strTemp)
{
int len ;
byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
len = sarr.Length;//will output as 3+3*2 = 9
return len;
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objFunctionNameTabENS">源对象</param>
 /// <param name = "objFunctionNameTabENT">目标对象</param>
 public static void CopyTo(clsFunctionNameTabEN objFunctionNameTabENS, clsFunctionNameTabEN objFunctionNameTabENT)
{
try
{
objFunctionNameTabENT.FunctionId = objFunctionNameTabENS.FunctionId; //功能Id
objFunctionNameTabENT.FunctionName = objFunctionNameTabENS.FunctionName; //函数名
objFunctionNameTabENT.FunctionNameCH = objFunctionNameTabENS.FunctionNameCH; //功能中文名
objFunctionNameTabENT.ModuleName = objFunctionNameTabENS.ModuleName; //模块名
objFunctionNameTabENT.IsStudent = objFunctionNameTabENS.IsStudent; //是否学生
objFunctionNameTabENT.IsTeacher = objFunctionNameTabENS.IsTeacher; //是否教师
objFunctionNameTabENT.IsQuestion = objFunctionNameTabENS.IsQuestion; //是否题目
objFunctionNameTabENT.ConstName = objFunctionNameTabENS.ConstName; //常量名
objFunctionNameTabENT.PagePath = objFunctionNameTabENS.PagePath; //页面路径
objFunctionNameTabENT.PageName = objFunctionNameTabENS.PageName; //页面名称
objFunctionNameTabENT.OrderNum = objFunctionNameTabENS.OrderNum; //序号
objFunctionNameTabENT.UpdDate = objFunctionNameTabENS.UpdDate; //修改日期
objFunctionNameTabENT.UpdUser = objFunctionNameTabENS.UpdUser; //修改人
objFunctionNameTabENT.Memo = objFunctionNameTabENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsFunctionNameTabEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsFunctionNameTabEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsFunctionNameTabEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsFunctionNameTabEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsFunctionNameTabEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsFunctionNameTabEN.AttributeName)
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
if (clsFunctionNameTabWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunctionNameTabWApi没有刷新缓存机制(clsFunctionNameTabWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by FunctionId");
//if (arrFunctionNameTabObjLst_Cache == null)
//{
//arrFunctionNameTabObjLst_Cache = await clsFunctionNameTabWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsFunctionNameTabEN._CurrTabName_S);
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
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsFunctionNameTabWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsFunctionNameTabEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsFunctionNameTabWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFunctionNameTabEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsFunctionNameTabEN._CurrTabName_S);
List<clsFunctionNameTabEN> arrFunctionNameTabObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrFunctionNameTabObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsFunctionNameTabEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conFunctionNameTab.FunctionId, Type.GetType("System.String"));
objDT.Columns.Add(conFunctionNameTab.FunctionName, Type.GetType("System.String"));
objDT.Columns.Add(conFunctionNameTab.FunctionNameCH, Type.GetType("System.String"));
objDT.Columns.Add(conFunctionNameTab.ModuleName, Type.GetType("System.String"));
objDT.Columns.Add(conFunctionNameTab.IsStudent, Type.GetType("System.Boolean"));
objDT.Columns.Add(conFunctionNameTab.IsTeacher, Type.GetType("System.Boolean"));
objDT.Columns.Add(conFunctionNameTab.IsQuestion, Type.GetType("System.Boolean"));
objDT.Columns.Add(conFunctionNameTab.ConstName, Type.GetType("System.String"));
objDT.Columns.Add(conFunctionNameTab.PagePath, Type.GetType("System.String"));
objDT.Columns.Add(conFunctionNameTab.PageName, Type.GetType("System.String"));
objDT.Columns.Add(conFunctionNameTab.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conFunctionNameTab.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conFunctionNameTab.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(conFunctionNameTab.Memo, Type.GetType("System.String"));
foreach (clsFunctionNameTabEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conFunctionNameTab.FunctionId] = objInFor[conFunctionNameTab.FunctionId];
objDR[conFunctionNameTab.FunctionName] = objInFor[conFunctionNameTab.FunctionName];
objDR[conFunctionNameTab.FunctionNameCH] = objInFor[conFunctionNameTab.FunctionNameCH];
objDR[conFunctionNameTab.ModuleName] = objInFor[conFunctionNameTab.ModuleName];
objDR[conFunctionNameTab.IsStudent] = objInFor[conFunctionNameTab.IsStudent];
objDR[conFunctionNameTab.IsTeacher] = objInFor[conFunctionNameTab.IsTeacher];
objDR[conFunctionNameTab.IsQuestion] = objInFor[conFunctionNameTab.IsQuestion];
objDR[conFunctionNameTab.ConstName] = objInFor[conFunctionNameTab.ConstName];
objDR[conFunctionNameTab.PagePath] = objInFor[conFunctionNameTab.PagePath];
objDR[conFunctionNameTab.PageName] = objInFor[conFunctionNameTab.PageName];
objDR[conFunctionNameTab.OrderNum] = objInFor[conFunctionNameTab.OrderNum];
objDR[conFunctionNameTab.UpdDate] = objInFor[conFunctionNameTab.UpdDate];
objDR[conFunctionNameTab.UpdUser] = objInFor[conFunctionNameTab.UpdUser];
objDR[conFunctionNameTab.Memo] = objInFor[conFunctionNameTab.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 函数名表(FunctionNameTab)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4FunctionNameTab : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == false)
{
strMsg = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg);
return;
}
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionNameTabWApi.ReFreshThisCache();
}
}

}