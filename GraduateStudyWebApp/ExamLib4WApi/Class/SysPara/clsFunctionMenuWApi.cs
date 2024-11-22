
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFunctionMenuWApi
 表名:FunctionMenu(01120475)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:40:58
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:系统参数
 模块英文名:SysPara
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
public static class clsFunctionMenuWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionMenuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFunctionMenuEN SetFunctionMenuId(this clsFunctionMenuEN objFunctionMenuEN, string strFunctionMenuId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFunctionMenuId, 4, conFunctionMenu.FunctionMenuId);
clsCheckSql.CheckFieldForeignKey(strFunctionMenuId, 4, conFunctionMenu.FunctionMenuId);
objFunctionMenuEN.FunctionMenuId = strFunctionMenuId; //功能菜单ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionMenuEN.dicFldComparisonOp.ContainsKey(conFunctionMenu.FunctionMenuId) == false)
{
objFunctionMenuEN.dicFldComparisonOp.Add(conFunctionMenu.FunctionMenuId, strComparisonOp);
}
else
{
objFunctionMenuEN.dicFldComparisonOp[conFunctionMenu.FunctionMenuId] = strComparisonOp;
}
}
return objFunctionMenuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionMenuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFunctionMenuEN SetFunctionName(this clsFunctionMenuEN objFunctionMenuEN, string strFunctionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFunctionName, 100, conFunctionMenu.FunctionName);
objFunctionMenuEN.FunctionName = strFunctionName; //函数名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionMenuEN.dicFldComparisonOp.ContainsKey(conFunctionMenu.FunctionName) == false)
{
objFunctionMenuEN.dicFldComparisonOp.Add(conFunctionMenu.FunctionName, strComparisonOp);
}
else
{
objFunctionMenuEN.dicFldComparisonOp[conFunctionMenu.FunctionName] = strComparisonOp;
}
}
return objFunctionMenuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionMenuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFunctionMenuEN SetTitleName(this clsFunctionMenuEN objFunctionMenuEN, string strTitleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTitleName, 200, conFunctionMenu.TitleName);
objFunctionMenuEN.TitleName = strTitleName; //功能菜单标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionMenuEN.dicFldComparisonOp.ContainsKey(conFunctionMenu.TitleName) == false)
{
objFunctionMenuEN.dicFldComparisonOp.Add(conFunctionMenu.TitleName, strComparisonOp);
}
else
{
objFunctionMenuEN.dicFldComparisonOp[conFunctionMenu.TitleName] = strComparisonOp;
}
}
return objFunctionMenuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionMenuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFunctionMenuEN SetIsVisible(this clsFunctionMenuEN objFunctionMenuEN, bool bolIsVisible, string strComparisonOp="")
	{
objFunctionMenuEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionMenuEN.dicFldComparisonOp.ContainsKey(conFunctionMenu.IsVisible) == false)
{
objFunctionMenuEN.dicFldComparisonOp.Add(conFunctionMenu.IsVisible, strComparisonOp);
}
else
{
objFunctionMenuEN.dicFldComparisonOp[conFunctionMenu.IsVisible] = strComparisonOp;
}
}
return objFunctionMenuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionMenuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFunctionMenuEN SetDispPageMode(this clsFunctionMenuEN objFunctionMenuEN, string strDispPageMode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strDispPageMode, 50, conFunctionMenu.DispPageMode);
objFunctionMenuEN.DispPageMode = strDispPageMode; //显示页面方式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionMenuEN.dicFldComparisonOp.ContainsKey(conFunctionMenu.DispPageMode) == false)
{
objFunctionMenuEN.dicFldComparisonOp.Add(conFunctionMenu.DispPageMode, strComparisonOp);
}
else
{
objFunctionMenuEN.dicFldComparisonOp[conFunctionMenu.DispPageMode] = strComparisonOp;
}
}
return objFunctionMenuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionMenuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFunctionMenuEN SetIsTransUserBySingleSignOn(this clsFunctionMenuEN objFunctionMenuEN, bool bolIsTransUserBySingleSignOn, string strComparisonOp="")
	{
objFunctionMenuEN.IsTransUserBySingleSignOn = bolIsTransUserBySingleSignOn; //是否单点登录传用户信息
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionMenuEN.dicFldComparisonOp.ContainsKey(conFunctionMenu.IsTransUserBySingleSignOn) == false)
{
objFunctionMenuEN.dicFldComparisonOp.Add(conFunctionMenu.IsTransUserBySingleSignOn, strComparisonOp);
}
else
{
objFunctionMenuEN.dicFldComparisonOp[conFunctionMenu.IsTransUserBySingleSignOn] = strComparisonOp;
}
}
return objFunctionMenuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionMenuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFunctionMenuEN SetIsWithParameter(this clsFunctionMenuEN objFunctionMenuEN, bool bolIsWithParameter, string strComparisonOp="")
	{
objFunctionMenuEN.IsWithParameter = bolIsWithParameter; //是否带参数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionMenuEN.dicFldComparisonOp.ContainsKey(conFunctionMenu.IsWithParameter) == false)
{
objFunctionMenuEN.dicFldComparisonOp.Add(conFunctionMenu.IsWithParameter, strComparisonOp);
}
else
{
objFunctionMenuEN.dicFldComparisonOp[conFunctionMenu.IsWithParameter] = strComparisonOp;
}
}
return objFunctionMenuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionMenuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFunctionMenuEN SetHyperLink(this clsFunctionMenuEN objFunctionMenuEN, string strHyperLink, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strHyperLink, 200, conFunctionMenu.HyperLink);
objFunctionMenuEN.HyperLink = strHyperLink; //超链接
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionMenuEN.dicFldComparisonOp.ContainsKey(conFunctionMenu.HyperLink) == false)
{
objFunctionMenuEN.dicFldComparisonOp.Add(conFunctionMenu.HyperLink, strComparisonOp);
}
else
{
objFunctionMenuEN.dicFldComparisonOp[conFunctionMenu.HyperLink] = strComparisonOp;
}
}
return objFunctionMenuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionMenuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFunctionMenuEN SetHyperLink4NoUser(this clsFunctionMenuEN objFunctionMenuEN, string strHyperLink4NoUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strHyperLink4NoUser, 200, conFunctionMenu.HyperLink4NoUser);
objFunctionMenuEN.HyperLink4NoUser = strHyperLink4NoUser; //超链接针对无用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionMenuEN.dicFldComparisonOp.ContainsKey(conFunctionMenu.HyperLink4NoUser) == false)
{
objFunctionMenuEN.dicFldComparisonOp.Add(conFunctionMenu.HyperLink4NoUser, strComparisonOp);
}
else
{
objFunctionMenuEN.dicFldComparisonOp[conFunctionMenu.HyperLink4NoUser] = strComparisonOp;
}
}
return objFunctionMenuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionMenuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFunctionMenuEN SetSingleSignOnKey(this clsFunctionMenuEN objFunctionMenuEN, string strSingleSignOnKey, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSingleSignOnKey, 50, conFunctionMenu.SingleSignOnKey);
objFunctionMenuEN.SingleSignOnKey = strSingleSignOnKey; //单点登录关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionMenuEN.dicFldComparisonOp.ContainsKey(conFunctionMenu.SingleSignOnKey) == false)
{
objFunctionMenuEN.dicFldComparisonOp.Add(conFunctionMenu.SingleSignOnKey, strComparisonOp);
}
else
{
objFunctionMenuEN.dicFldComparisonOp[conFunctionMenu.SingleSignOnKey] = strComparisonOp;
}
}
return objFunctionMenuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionMenuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFunctionMenuEN SetSchoolId(this clsFunctionMenuEN objFunctionMenuEN, string strSchoolId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolId, conFunctionMenu.SchoolId);
clsCheckSql.CheckFieldLen(strSchoolId, 10, conFunctionMenu.SchoolId);
objFunctionMenuEN.SchoolId = strSchoolId; //学校编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionMenuEN.dicFldComparisonOp.ContainsKey(conFunctionMenu.SchoolId) == false)
{
objFunctionMenuEN.dicFldComparisonOp.Add(conFunctionMenu.SchoolId, strComparisonOp);
}
else
{
objFunctionMenuEN.dicFldComparisonOp[conFunctionMenu.SchoolId] = strComparisonOp;
}
}
return objFunctionMenuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionMenuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFunctionMenuEN SetUpdDate(this clsFunctionMenuEN objFunctionMenuEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conFunctionMenu.UpdDate);
objFunctionMenuEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionMenuEN.dicFldComparisonOp.ContainsKey(conFunctionMenu.UpdDate) == false)
{
objFunctionMenuEN.dicFldComparisonOp.Add(conFunctionMenu.UpdDate, strComparisonOp);
}
else
{
objFunctionMenuEN.dicFldComparisonOp[conFunctionMenu.UpdDate] = strComparisonOp;
}
}
return objFunctionMenuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionMenuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFunctionMenuEN SetUpdUserId(this clsFunctionMenuEN objFunctionMenuEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conFunctionMenu.UpdUserId);
objFunctionMenuEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionMenuEN.dicFldComparisonOp.ContainsKey(conFunctionMenu.UpdUserId) == false)
{
objFunctionMenuEN.dicFldComparisonOp.Add(conFunctionMenu.UpdUserId, strComparisonOp);
}
else
{
objFunctionMenuEN.dicFldComparisonOp[conFunctionMenu.UpdUserId] = strComparisonOp;
}
}
return objFunctionMenuEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objFunctionMenuEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsFunctionMenuEN SetMemo(this clsFunctionMenuEN objFunctionMenuEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conFunctionMenu.Memo);
objFunctionMenuEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objFunctionMenuEN.dicFldComparisonOp.ContainsKey(conFunctionMenu.Memo) == false)
{
objFunctionMenuEN.dicFldComparisonOp.Add(conFunctionMenu.Memo, strComparisonOp);
}
else
{
objFunctionMenuEN.dicFldComparisonOp[conFunctionMenu.Memo] = strComparisonOp;
}
}
return objFunctionMenuEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsFunctionMenuEN objFunctionMenu_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objFunctionMenu_Cond.IsUpdated(conFunctionMenu.FunctionMenuId) == true)
{
string strComparisonOp_FunctionMenuId = objFunctionMenu_Cond.dicFldComparisonOp[conFunctionMenu.FunctionMenuId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionMenu.FunctionMenuId, objFunctionMenu_Cond.FunctionMenuId, strComparisonOp_FunctionMenuId);
}
if (objFunctionMenu_Cond.IsUpdated(conFunctionMenu.FunctionName) == true)
{
string strComparisonOp_FunctionName = objFunctionMenu_Cond.dicFldComparisonOp[conFunctionMenu.FunctionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionMenu.FunctionName, objFunctionMenu_Cond.FunctionName, strComparisonOp_FunctionName);
}
if (objFunctionMenu_Cond.IsUpdated(conFunctionMenu.TitleName) == true)
{
string strComparisonOp_TitleName = objFunctionMenu_Cond.dicFldComparisonOp[conFunctionMenu.TitleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionMenu.TitleName, objFunctionMenu_Cond.TitleName, strComparisonOp_TitleName);
}
if (objFunctionMenu_Cond.IsUpdated(conFunctionMenu.IsVisible) == true)
{
if (objFunctionMenu_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFunctionMenu.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFunctionMenu.IsVisible);
}
}
if (objFunctionMenu_Cond.IsUpdated(conFunctionMenu.DispPageMode) == true)
{
string strComparisonOp_DispPageMode = objFunctionMenu_Cond.dicFldComparisonOp[conFunctionMenu.DispPageMode];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionMenu.DispPageMode, objFunctionMenu_Cond.DispPageMode, strComparisonOp_DispPageMode);
}
if (objFunctionMenu_Cond.IsUpdated(conFunctionMenu.IsTransUserBySingleSignOn) == true)
{
if (objFunctionMenu_Cond.IsTransUserBySingleSignOn == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFunctionMenu.IsTransUserBySingleSignOn);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFunctionMenu.IsTransUserBySingleSignOn);
}
}
if (objFunctionMenu_Cond.IsUpdated(conFunctionMenu.IsWithParameter) == true)
{
if (objFunctionMenu_Cond.IsWithParameter == true)
{
strWhereCond += string.Format(" And {0} = '1'", conFunctionMenu.IsWithParameter);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", conFunctionMenu.IsWithParameter);
}
}
if (objFunctionMenu_Cond.IsUpdated(conFunctionMenu.HyperLink) == true)
{
string strComparisonOp_HyperLink = objFunctionMenu_Cond.dicFldComparisonOp[conFunctionMenu.HyperLink];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionMenu.HyperLink, objFunctionMenu_Cond.HyperLink, strComparisonOp_HyperLink);
}
if (objFunctionMenu_Cond.IsUpdated(conFunctionMenu.HyperLink4NoUser) == true)
{
string strComparisonOp_HyperLink4NoUser = objFunctionMenu_Cond.dicFldComparisonOp[conFunctionMenu.HyperLink4NoUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionMenu.HyperLink4NoUser, objFunctionMenu_Cond.HyperLink4NoUser, strComparisonOp_HyperLink4NoUser);
}
if (objFunctionMenu_Cond.IsUpdated(conFunctionMenu.SingleSignOnKey) == true)
{
string strComparisonOp_SingleSignOnKey = objFunctionMenu_Cond.dicFldComparisonOp[conFunctionMenu.SingleSignOnKey];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionMenu.SingleSignOnKey, objFunctionMenu_Cond.SingleSignOnKey, strComparisonOp_SingleSignOnKey);
}
if (objFunctionMenu_Cond.IsUpdated(conFunctionMenu.SchoolId) == true)
{
string strComparisonOp_SchoolId = objFunctionMenu_Cond.dicFldComparisonOp[conFunctionMenu.SchoolId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionMenu.SchoolId, objFunctionMenu_Cond.SchoolId, strComparisonOp_SchoolId);
}
if (objFunctionMenu_Cond.IsUpdated(conFunctionMenu.UpdDate) == true)
{
string strComparisonOp_UpdDate = objFunctionMenu_Cond.dicFldComparisonOp[conFunctionMenu.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionMenu.UpdDate, objFunctionMenu_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objFunctionMenu_Cond.IsUpdated(conFunctionMenu.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objFunctionMenu_Cond.dicFldComparisonOp[conFunctionMenu.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionMenu.UpdUserId, objFunctionMenu_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objFunctionMenu_Cond.IsUpdated(conFunctionMenu.Memo) == true)
{
string strComparisonOp_Memo = objFunctionMenu_Cond.dicFldComparisonOp[conFunctionMenu.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conFunctionMenu.Memo, objFunctionMenu_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objFunctionMenuEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsFunctionMenuEN objFunctionMenuEN)
{
 if (string.IsNullOrEmpty(objFunctionMenuEN.FunctionMenuId) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objFunctionMenuEN.sf_UpdFldSetStr = objFunctionMenuEN.getsf_UpdFldSetStr();
clsFunctionMenuWApi.CheckPropertyNew(objFunctionMenuEN); 
bool bolResult = clsFunctionMenuWApi.UpdateRecord(objFunctionMenuEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionMenuWApi.ReFreshCache();
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
 /// <param name = "objFunctionMenuEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsFunctionMenuEN objFunctionMenuEN)
{
 if (string.IsNullOrEmpty(objFunctionMenuEN.FunctionMenuId) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsFunctionMenuWApi.IsExist(objFunctionMenuEN.FunctionMenuId) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objFunctionMenuEN.FunctionMenuId, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsFunctionMenuWApi.CheckPropertyNew(objFunctionMenuEN); 
bool bolResult = clsFunctionMenuWApi.AddNewRecord(objFunctionMenuEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionMenuWApi.ReFreshCache();
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
 /// <param name = "objFunctionMenuEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsFunctionMenuEN objFunctionMenuEN)
{
try
{
clsFunctionMenuWApi.CheckPropertyNew(objFunctionMenuEN); 
string strFunctionMenuId = clsFunctionMenuWApi.AddNewRecordWithMaxId(objFunctionMenuEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionMenuWApi.ReFreshCache();
return strFunctionMenuId;
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
 /// <param name = "objFunctionMenuEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsFunctionMenuEN objFunctionMenuEN, string strWhereCond)
{
try
{
clsFunctionMenuWApi.CheckPropertyNew(objFunctionMenuEN); 
bool bolResult = clsFunctionMenuWApi.UpdateWithCondition(objFunctionMenuEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionMenuWApi.ReFreshCache();
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
 /// 功能菜单(FunctionMenu)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsFunctionMenuWApi
{
private static readonly string mstrApiControllerName = "FunctionMenuApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsFunctionMenuWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsFunctionMenuEN objFunctionMenuEN)
{
if (!Object.Equals(null, objFunctionMenuEN.FunctionMenuId) && GetStrLen(objFunctionMenuEN.FunctionMenuId) > 4)
{
 throw new Exception("字段[功能菜单ID]的长度不能超过4!");
}
if (!Object.Equals(null, objFunctionMenuEN.FunctionName) && GetStrLen(objFunctionMenuEN.FunctionName) > 100)
{
 throw new Exception("字段[函数名]的长度不能超过100!");
}
if (!Object.Equals(null, objFunctionMenuEN.TitleName) && GetStrLen(objFunctionMenuEN.TitleName) > 200)
{
 throw new Exception("字段[功能菜单标题]的长度不能超过200!");
}
if (!Object.Equals(null, objFunctionMenuEN.DispPageMode) && GetStrLen(objFunctionMenuEN.DispPageMode) > 50)
{
 throw new Exception("字段[显示页面方式]的长度不能超过50!");
}
if (!Object.Equals(null, objFunctionMenuEN.HyperLink) && GetStrLen(objFunctionMenuEN.HyperLink) > 200)
{
 throw new Exception("字段[超链接]的长度不能超过200!");
}
if (!Object.Equals(null, objFunctionMenuEN.HyperLink4NoUser) && GetStrLen(objFunctionMenuEN.HyperLink4NoUser) > 200)
{
 throw new Exception("字段[超链接针对无用户]的长度不能超过200!");
}
if (!Object.Equals(null, objFunctionMenuEN.SingleSignOnKey) && GetStrLen(objFunctionMenuEN.SingleSignOnKey) > 50)
{
 throw new Exception("字段[单点登录关键字]的长度不能超过50!");
}
if (!Object.Equals(null, objFunctionMenuEN.SchoolId) && GetStrLen(objFunctionMenuEN.SchoolId) > 10)
{
 throw new Exception("字段[学校编号]的长度不能超过10!");
}
if (!Object.Equals(null, objFunctionMenuEN.UpdDate) && GetStrLen(objFunctionMenuEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objFunctionMenuEN.UpdUserId) && GetStrLen(objFunctionMenuEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objFunctionMenuEN.Memo) && GetStrLen(objFunctionMenuEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objFunctionMenuEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFunctionMenuId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFunctionMenuEN GetObjByFunctionMenuId(string strFunctionMenuId)
{
string strAction = "GetObjByFunctionMenuId";
string strErrMsg = string.Empty;
string strResult = "";
clsFunctionMenuEN objFunctionMenuEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["FunctionMenuId"] = strFunctionMenuId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objFunctionMenuEN = JsonConvert.DeserializeObject<clsFunctionMenuEN>((string)jobjReturn["ReturnObj"]);
return objFunctionMenuEN;
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
 /// <param name = "strFunctionMenuId">表关键字</param>
 /// <returns>表对象</returns>
public static clsFunctionMenuEN GetObjByFunctionMenuId_WA_Cache(string strFunctionMenuId)
{
string strAction = "GetObjByFunctionMenuId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsFunctionMenuEN objFunctionMenuEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["FunctionMenuId"] = strFunctionMenuId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objFunctionMenuEN = JsonConvert.DeserializeObject<clsFunctionMenuEN>((string)jobjReturn["ReturnObj"]);
return objFunctionMenuEN;
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
public static clsFunctionMenuEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsFunctionMenuEN objFunctionMenuEN = null;
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
objFunctionMenuEN = JsonConvert.DeserializeObject<clsFunctionMenuEN>((string)jobjReturn["ReturnObj"]);
return objFunctionMenuEN;
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
 /// <param name = "strFunctionMenuId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsFunctionMenuEN GetObjByFunctionMenuId_Cache(string strFunctionMenuId)
{
if (string.IsNullOrEmpty(strFunctionMenuId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsFunctionMenuEN._CurrTabName_S);
List<clsFunctionMenuEN> arrFunctionMenuObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsFunctionMenuEN> arrFunctionMenuObjLst_Sel =
from objFunctionMenuEN in arrFunctionMenuObjLst_Cache
where objFunctionMenuEN.FunctionMenuId == strFunctionMenuId
select objFunctionMenuEN;
if (arrFunctionMenuObjLst_Sel.Count() == 0)
{
   clsFunctionMenuEN obj = clsFunctionMenuWApi.GetObjByFunctionMenuId(strFunctionMenuId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrFunctionMenuObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFunctionMenuEN> GetObjLst(string strWhereCond)
{
 List<clsFunctionMenuEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFunctionMenuEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsFunctionMenuEN> GetObjLstByFunctionMenuIdLst(List<string> arrFunctionMenuId)
{
 List<clsFunctionMenuEN> arrObjLst = null; 
string strAction = "GetObjLstByFunctionMenuIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFunctionMenuId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsFunctionMenuEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strFunctionMenuId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsFunctionMenuEN> GetObjLstByFunctionMenuIdLst_Cache(List<string> arrFunctionMenuId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsFunctionMenuEN._CurrTabName_S);
List<clsFunctionMenuEN> arrFunctionMenuObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsFunctionMenuEN> arrFunctionMenuObjLst_Sel =
from objFunctionMenuEN in arrFunctionMenuObjLst_Cache
where arrFunctionMenuId.Contains(objFunctionMenuEN.FunctionMenuId)
select objFunctionMenuEN;
return arrFunctionMenuObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsFunctionMenuEN> GetObjLstByFunctionMenuIdLst_WA_Cache(List<string> arrFunctionMenuId)
{
 List<clsFunctionMenuEN> arrObjLst = null; 
string strAction = "GetObjLstByFunctionMenuIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFunctionMenuId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsFunctionMenuEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsFunctionMenuEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsFunctionMenuEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFunctionMenuEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsFunctionMenuEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsFunctionMenuEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFunctionMenuEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsFunctionMenuEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsFunctionMenuEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFunctionMenuEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsFunctionMenuEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsFunctionMenuEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsFunctionMenuEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(string strFunctionMenuId)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsFunctionMenuEN objFunctionMenuEN = clsFunctionMenuWApi.GetObjByFunctionMenuId(strFunctionMenuId);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strFunctionMenuId.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsFunctionMenuWApi.ReFreshCache();
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
public static int DelFunctionMenus(List<string> arrFunctionMenuId)
{
string strAction = "DelFunctionMenus";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrFunctionMenuId);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsFunctionMenuWApi.ReFreshCache();
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
public static int DelFunctionMenusByCond(string strWhereCond)
{
string strAction = "DelFunctionMenusByCond";
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
public static bool AddNewRecord(clsFunctionMenuEN objFunctionMenuEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFunctionMenuEN>(objFunctionMenuEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionMenuWApi.ReFreshCache();
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
public static string AddNewRecordWithMaxId(clsFunctionMenuEN objFunctionMenuEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFunctionMenuEN>(objFunctionMenuEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsFunctionMenuWApi.ReFreshCache();
var strFunctionMenuId = (string)jobjReturn["ReturnStr"];
return strFunctionMenuId;
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
public static bool UpdateRecord(clsFunctionMenuEN objFunctionMenuEN)
{
if (string.IsNullOrEmpty(objFunctionMenuEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objFunctionMenuEN.FunctionMenuId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFunctionMenuEN>(objFunctionMenuEN);
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
 /// <param name = "objFunctionMenuEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsFunctionMenuEN objFunctionMenuEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objFunctionMenuEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objFunctionMenuEN.FunctionMenuId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objFunctionMenuEN.FunctionMenuId, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsFunctionMenuEN>(objFunctionMenuEN);
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
public static bool IsExist(string strFunctionMenuId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["FunctionMenuId"] = strFunctionMenuId
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
 /// <param name = "objFunctionMenuENS">源对象</param>
 /// <param name = "objFunctionMenuENT">目标对象</param>
 public static void CopyTo(clsFunctionMenuEN objFunctionMenuENS, clsFunctionMenuEN objFunctionMenuENT)
{
try
{
objFunctionMenuENT.FunctionMenuId = objFunctionMenuENS.FunctionMenuId; //功能菜单ID
objFunctionMenuENT.FunctionName = objFunctionMenuENS.FunctionName; //函数名
objFunctionMenuENT.TitleName = objFunctionMenuENS.TitleName; //功能菜单标题
objFunctionMenuENT.IsVisible = objFunctionMenuENS.IsVisible; //是否显示
objFunctionMenuENT.DispPageMode = objFunctionMenuENS.DispPageMode; //显示页面方式
objFunctionMenuENT.IsTransUserBySingleSignOn = objFunctionMenuENS.IsTransUserBySingleSignOn; //是否单点登录传用户信息
objFunctionMenuENT.IsWithParameter = objFunctionMenuENS.IsWithParameter; //是否带参数
objFunctionMenuENT.HyperLink = objFunctionMenuENS.HyperLink; //超链接
objFunctionMenuENT.HyperLink4NoUser = objFunctionMenuENS.HyperLink4NoUser; //超链接针对无用户
objFunctionMenuENT.SingleSignOnKey = objFunctionMenuENS.SingleSignOnKey; //单点登录关键字
objFunctionMenuENT.SchoolId = objFunctionMenuENS.SchoolId; //学校编号
objFunctionMenuENT.UpdDate = objFunctionMenuENS.UpdDate; //修改日期
objFunctionMenuENT.UpdUserId = objFunctionMenuENS.UpdUserId; //修改用户Id
objFunctionMenuENT.Memo = objFunctionMenuENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsFunctionMenuEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsFunctionMenuEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsFunctionMenuEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsFunctionMenuEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsFunctionMenuEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsFunctionMenuEN.AttributeName)
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
if (clsFunctionMenuWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunctionMenuWApi没有刷新缓存机制(clsFunctionMenuWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by FunctionMenuId");
//if (arrFunctionMenuObjLst_Cache == null)
//{
//arrFunctionMenuObjLst_Cache = await clsFunctionMenuWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsFunctionMenuEN._CurrTabName_S);
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
if (clsFunctionMenuWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsFunctionMenuEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsFunctionMenuWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsFunctionMenuEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsFunctionMenuEN._CurrTabName_S);
List<clsFunctionMenuEN> arrFunctionMenuObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrFunctionMenuObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsFunctionMenuEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conFunctionMenu.FunctionMenuId, Type.GetType("System.String"));
objDT.Columns.Add(conFunctionMenu.FunctionName, Type.GetType("System.String"));
objDT.Columns.Add(conFunctionMenu.TitleName, Type.GetType("System.String"));
objDT.Columns.Add(conFunctionMenu.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(conFunctionMenu.DispPageMode, Type.GetType("System.String"));
objDT.Columns.Add(conFunctionMenu.IsTransUserBySingleSignOn, Type.GetType("System.Boolean"));
objDT.Columns.Add(conFunctionMenu.IsWithParameter, Type.GetType("System.Boolean"));
objDT.Columns.Add(conFunctionMenu.HyperLink, Type.GetType("System.String"));
objDT.Columns.Add(conFunctionMenu.HyperLink4NoUser, Type.GetType("System.String"));
objDT.Columns.Add(conFunctionMenu.SingleSignOnKey, Type.GetType("System.String"));
objDT.Columns.Add(conFunctionMenu.SchoolId, Type.GetType("System.String"));
objDT.Columns.Add(conFunctionMenu.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conFunctionMenu.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conFunctionMenu.Memo, Type.GetType("System.String"));
foreach (clsFunctionMenuEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conFunctionMenu.FunctionMenuId] = objInFor[conFunctionMenu.FunctionMenuId];
objDR[conFunctionMenu.FunctionName] = objInFor[conFunctionMenu.FunctionName];
objDR[conFunctionMenu.TitleName] = objInFor[conFunctionMenu.TitleName];
objDR[conFunctionMenu.IsVisible] = objInFor[conFunctionMenu.IsVisible];
objDR[conFunctionMenu.DispPageMode] = objInFor[conFunctionMenu.DispPageMode];
objDR[conFunctionMenu.IsTransUserBySingleSignOn] = objInFor[conFunctionMenu.IsTransUserBySingleSignOn];
objDR[conFunctionMenu.IsWithParameter] = objInFor[conFunctionMenu.IsWithParameter];
objDR[conFunctionMenu.HyperLink] = objInFor[conFunctionMenu.HyperLink];
objDR[conFunctionMenu.HyperLink4NoUser] = objInFor[conFunctionMenu.HyperLink4NoUser];
objDR[conFunctionMenu.SingleSignOnKey] = objInFor[conFunctionMenu.SingleSignOnKey];
objDR[conFunctionMenu.SchoolId] = objInFor[conFunctionMenu.SchoolId];
objDR[conFunctionMenu.UpdDate] = objInFor[conFunctionMenu.UpdDate];
objDR[conFunctionMenu.UpdUserId] = objInFor[conFunctionMenu.UpdUserId];
objDR[conFunctionMenu.Memo] = objInFor[conFunctionMenu.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 功能菜单(FunctionMenu)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4FunctionMenu : clsCommFun4BL
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
clsFunctionMenuWApi.ReFreshThisCache();
}
}

}