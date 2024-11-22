
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxRightWApi
 表名:vQxRight(01120174)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:50:58
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:权限管理
 模块英文名:UsersRight
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
public static class clsvQxRightWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxRightEN SetRightId(this clsvQxRightEN objvQxRightEN, string strRightId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRightId, 8, convQxRight.RightId);
clsCheckSql.CheckFieldForeignKey(strRightId, 8, convQxRight.RightId);
objvQxRightEN.RightId = strRightId; //权限编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRightEN.dicFldComparisonOp.ContainsKey(convQxRight.RightId) == false)
{
objvQxRightEN.dicFldComparisonOp.Add(convQxRight.RightId, strComparisonOp);
}
else
{
objvQxRightEN.dicFldComparisonOp[convQxRight.RightId] = strComparisonOp;
}
}
return objvQxRightEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxRightEN SetRightName(this clsvQxRightEN objvQxRightEN, string strRightName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRightName, convQxRight.RightName);
clsCheckSql.CheckFieldLen(strRightName, 200, convQxRight.RightName);
objvQxRightEN.RightName = strRightName; //权限名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRightEN.dicFldComparisonOp.ContainsKey(convQxRight.RightName) == false)
{
objvQxRightEN.dicFldComparisonOp.Add(convQxRight.RightName, strComparisonOp);
}
else
{
objvQxRightEN.dicFldComparisonOp[convQxRight.RightName] = strComparisonOp;
}
}
return objvQxRightEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxRightEN SetRightTypeId(this clsvQxRightEN objvQxRightEN, string strRightTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRightTypeId, convQxRight.RightTypeId);
clsCheckSql.CheckFieldLen(strRightTypeId, 4, convQxRight.RightTypeId);
clsCheckSql.CheckFieldForeignKey(strRightTypeId, 4, convQxRight.RightTypeId);
objvQxRightEN.RightTypeId = strRightTypeId; //权限类型编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRightEN.dicFldComparisonOp.ContainsKey(convQxRight.RightTypeId) == false)
{
objvQxRightEN.dicFldComparisonOp.Add(convQxRight.RightTypeId, strComparisonOp);
}
else
{
objvQxRightEN.dicFldComparisonOp[convQxRight.RightTypeId] = strComparisonOp;
}
}
return objvQxRightEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxRightEN SetRightTypeName(this clsvQxRightEN objvQxRightEN, string strRightTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRightTypeName, 50, convQxRight.RightTypeName);
objvQxRightEN.RightTypeName = strRightTypeName; //权限类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRightEN.dicFldComparisonOp.ContainsKey(convQxRight.RightTypeName) == false)
{
objvQxRightEN.dicFldComparisonOp.Add(convQxRight.RightTypeName, strComparisonOp);
}
else
{
objvQxRightEN.dicFldComparisonOp[convQxRight.RightTypeName] = strComparisonOp;
}
}
return objvQxRightEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxRightEN SetMenuId(this clsvQxRightEN objvQxRightEN, string strMenuId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMenuId, 8, convQxRight.MenuId);
objvQxRightEN.MenuId = strMenuId; //菜单编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRightEN.dicFldComparisonOp.ContainsKey(convQxRight.MenuId) == false)
{
objvQxRightEN.dicFldComparisonOp.Add(convQxRight.MenuId, strComparisonOp);
}
else
{
objvQxRightEN.dicFldComparisonOp[convQxRight.MenuId] = strComparisonOp;
}
}
return objvQxRightEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxRightEN SetFuncModuleId(this clsvQxRightEN objvQxRightEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convQxRight.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convQxRight.FuncModuleId);
objvQxRightEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRightEN.dicFldComparisonOp.ContainsKey(convQxRight.FuncModuleId) == false)
{
objvQxRightEN.dicFldComparisonOp.Add(convQxRight.FuncModuleId, strComparisonOp);
}
else
{
objvQxRightEN.dicFldComparisonOp[convQxRight.FuncModuleId] = strComparisonOp;
}
}
return objvQxRightEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxRightEN SetFuncModuleName(this clsvQxRightEN objvQxRightEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convQxRight.FuncModuleName);
objvQxRightEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRightEN.dicFldComparisonOp.ContainsKey(convQxRight.FuncModuleName) == false)
{
objvQxRightEN.dicFldComparisonOp.Add(convQxRight.FuncModuleName, strComparisonOp);
}
else
{
objvQxRightEN.dicFldComparisonOp[convQxRight.FuncModuleName] = strComparisonOp;
}
}
return objvQxRightEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxRightEN SetFuncModuleName_Sim(this clsvQxRightEN objvQxRightEN, string strFuncModuleName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName_Sim, 30, convQxRight.FuncModuleName_Sim);
objvQxRightEN.FuncModuleName_Sim = strFuncModuleName_Sim; //功能模块简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRightEN.dicFldComparisonOp.ContainsKey(convQxRight.FuncModuleName_Sim) == false)
{
objvQxRightEN.dicFldComparisonOp.Add(convQxRight.FuncModuleName_Sim, strComparisonOp);
}
else
{
objvQxRightEN.dicFldComparisonOp[convQxRight.FuncModuleName_Sim] = strComparisonOp;
}
}
return objvQxRightEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxRightEN SetOrderNum(this clsvQxRightEN objvQxRightEN, int intOrderNum, string strComparisonOp="")
	{
objvQxRightEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRightEN.dicFldComparisonOp.ContainsKey(convQxRight.OrderNum) == false)
{
objvQxRightEN.dicFldComparisonOp.Add(convQxRight.OrderNum, strComparisonOp);
}
else
{
objvQxRightEN.dicFldComparisonOp[convQxRight.OrderNum] = strComparisonOp;
}
}
return objvQxRightEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxRightEN SetRightRangeLevelId(this clsvQxRightEN objvQxRightEN, string strRightRangeLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRightRangeLevelId, convQxRight.RightRangeLevelId);
clsCheckSql.CheckFieldLen(strRightRangeLevelId, 2, convQxRight.RightRangeLevelId);
clsCheckSql.CheckFieldForeignKey(strRightRangeLevelId, 2, convQxRight.RightRangeLevelId);
objvQxRightEN.RightRangeLevelId = strRightRangeLevelId; //权限范围等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRightEN.dicFldComparisonOp.ContainsKey(convQxRight.RightRangeLevelId) == false)
{
objvQxRightEN.dicFldComparisonOp.Add(convQxRight.RightRangeLevelId, strComparisonOp);
}
else
{
objvQxRightEN.dicFldComparisonOp[convQxRight.RightRangeLevelId] = strComparisonOp;
}
}
return objvQxRightEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxRightEN SetRightRangeLevelName(this clsvQxRightEN objvQxRightEN, string strRightRangeLevelName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRightRangeLevelName, 30, convQxRight.RightRangeLevelName);
objvQxRightEN.RightRangeLevelName = strRightRangeLevelName; //权限范围等级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRightEN.dicFldComparisonOp.ContainsKey(convQxRight.RightRangeLevelName) == false)
{
objvQxRightEN.dicFldComparisonOp.Add(convQxRight.RightRangeLevelName, strComparisonOp);
}
else
{
objvQxRightEN.dicFldComparisonOp[convQxRight.RightRangeLevelName] = strComparisonOp;
}
}
return objvQxRightEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxRightEN SetUpdDate(this clsvQxRightEN objvQxRightEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxRight.UpdDate);
objvQxRightEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRightEN.dicFldComparisonOp.ContainsKey(convQxRight.UpdDate) == false)
{
objvQxRightEN.dicFldComparisonOp.Add(convQxRight.UpdDate, strComparisonOp);
}
else
{
objvQxRightEN.dicFldComparisonOp[convQxRight.UpdDate] = strComparisonOp;
}
}
return objvQxRightEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxRightEN SetUpdUser(this clsvQxRightEN objvQxRightEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convQxRight.UpdUser);
objvQxRightEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRightEN.dicFldComparisonOp.ContainsKey(convQxRight.UpdUser) == false)
{
objvQxRightEN.dicFldComparisonOp.Add(convQxRight.UpdUser, strComparisonOp);
}
else
{
objvQxRightEN.dicFldComparisonOp[convQxRight.UpdUser] = strComparisonOp;
}
}
return objvQxRightEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQxRightEN SetMemo(this clsvQxRightEN objvQxRightEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxRight.Memo);
objvQxRightEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRightEN.dicFldComparisonOp.ContainsKey(convQxRight.Memo) == false)
{
objvQxRightEN.dicFldComparisonOp.Add(convQxRight.Memo, strComparisonOp);
}
else
{
objvQxRightEN.dicFldComparisonOp[convQxRight.Memo] = strComparisonOp;
}
}
return objvQxRightEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxRightEN objvQxRight_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxRight_Cond.IsUpdated(convQxRight.RightId) == true)
{
string strComparisonOp_RightId = objvQxRight_Cond.dicFldComparisonOp[convQxRight.RightId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRight.RightId, objvQxRight_Cond.RightId, strComparisonOp_RightId);
}
if (objvQxRight_Cond.IsUpdated(convQxRight.RightName) == true)
{
string strComparisonOp_RightName = objvQxRight_Cond.dicFldComparisonOp[convQxRight.RightName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRight.RightName, objvQxRight_Cond.RightName, strComparisonOp_RightName);
}
if (objvQxRight_Cond.IsUpdated(convQxRight.RightTypeId) == true)
{
string strComparisonOp_RightTypeId = objvQxRight_Cond.dicFldComparisonOp[convQxRight.RightTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRight.RightTypeId, objvQxRight_Cond.RightTypeId, strComparisonOp_RightTypeId);
}
if (objvQxRight_Cond.IsUpdated(convQxRight.RightTypeName) == true)
{
string strComparisonOp_RightTypeName = objvQxRight_Cond.dicFldComparisonOp[convQxRight.RightTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRight.RightTypeName, objvQxRight_Cond.RightTypeName, strComparisonOp_RightTypeName);
}
if (objvQxRight_Cond.IsUpdated(convQxRight.MenuId) == true)
{
string strComparisonOp_MenuId = objvQxRight_Cond.dicFldComparisonOp[convQxRight.MenuId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRight.MenuId, objvQxRight_Cond.MenuId, strComparisonOp_MenuId);
}
if (objvQxRight_Cond.IsUpdated(convQxRight.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvQxRight_Cond.dicFldComparisonOp[convQxRight.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRight.FuncModuleId, objvQxRight_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvQxRight_Cond.IsUpdated(convQxRight.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvQxRight_Cond.dicFldComparisonOp[convQxRight.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRight.FuncModuleName, objvQxRight_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvQxRight_Cond.IsUpdated(convQxRight.FuncModuleName_Sim) == true)
{
string strComparisonOp_FuncModuleName_Sim = objvQxRight_Cond.dicFldComparisonOp[convQxRight.FuncModuleName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRight.FuncModuleName_Sim, objvQxRight_Cond.FuncModuleName_Sim, strComparisonOp_FuncModuleName_Sim);
}
if (objvQxRight_Cond.IsUpdated(convQxRight.OrderNum) == true)
{
string strComparisonOp_OrderNum = objvQxRight_Cond.dicFldComparisonOp[convQxRight.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQxRight.OrderNum, objvQxRight_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objvQxRight_Cond.IsUpdated(convQxRight.RightRangeLevelId) == true)
{
string strComparisonOp_RightRangeLevelId = objvQxRight_Cond.dicFldComparisonOp[convQxRight.RightRangeLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRight.RightRangeLevelId, objvQxRight_Cond.RightRangeLevelId, strComparisonOp_RightRangeLevelId);
}
if (objvQxRight_Cond.IsUpdated(convQxRight.RightRangeLevelName) == true)
{
string strComparisonOp_RightRangeLevelName = objvQxRight_Cond.dicFldComparisonOp[convQxRight.RightRangeLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRight.RightRangeLevelName, objvQxRight_Cond.RightRangeLevelName, strComparisonOp_RightRangeLevelName);
}
if (objvQxRight_Cond.IsUpdated(convQxRight.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvQxRight_Cond.dicFldComparisonOp[convQxRight.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRight.UpdDate, objvQxRight_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvQxRight_Cond.IsUpdated(convQxRight.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvQxRight_Cond.dicFldComparisonOp[convQxRight.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRight.UpdUser, objvQxRight_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvQxRight_Cond.IsUpdated(convQxRight.Memo) == true)
{
string strComparisonOp_Memo = objvQxRight_Cond.dicFldComparisonOp[convQxRight.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRight.Memo, objvQxRight_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v用户权限(vQxRight)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQxRightWApi
{
private static readonly string mstrApiControllerName = "vQxRightApi";

 public clsvQxRightWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_RightId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v用户权限]...","0");
List<clsvQxRightEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="RightId";
objDDL.DataTextField="RightName";
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
public static void BindCbo_RightId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convQxRight.RightId); 
List<clsvQxRightEN> arrObjLst = clsvQxRightWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvQxRightEN objvQxRightEN = new clsvQxRightEN()
{
RightId = "0",
RightName = "选[v用户权限]..."
};
arrObjLst.Insert(0, objvQxRightEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convQxRight.RightId;
objComboBox.DisplayMember = convQxRight.RightName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strRightId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxRightEN GetObjByRightId(string strRightId)
{
string strAction = "GetObjByRightId";
string strErrMsg = string.Empty;
string strResult = "";
clsvQxRightEN objvQxRightEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["RightId"] = strRightId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvQxRightEN = JsonConvert.DeserializeObject<clsvQxRightEN>((string)jobjReturn["ReturnObj"]);
return objvQxRightEN;
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
 /// <param name = "strRightId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxRightEN GetObjByRightId_WA_Cache(string strRightId)
{
string strAction = "GetObjByRightId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvQxRightEN objvQxRightEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["RightId"] = strRightId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvQxRightEN = JsonConvert.DeserializeObject<clsvQxRightEN>((string)jobjReturn["ReturnObj"]);
return objvQxRightEN;
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
public static clsvQxRightEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvQxRightEN objvQxRightEN = null;
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
objvQxRightEN = JsonConvert.DeserializeObject<clsvQxRightEN>((string)jobjReturn["ReturnObj"]);
return objvQxRightEN;
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
 /// <param name = "strRightId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxRightEN GetObjByRightId_Cache(string strRightId)
{
if (string.IsNullOrEmpty(strRightId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvQxRightEN._CurrTabName_S);
List<clsvQxRightEN> arrvQxRightObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvQxRightEN> arrvQxRightObjLst_Sel =
from objvQxRightEN in arrvQxRightObjLst_Cache
where objvQxRightEN.RightId == strRightId
select objvQxRightEN;
if (arrvQxRightObjLst_Sel.Count() == 0)
{
   clsvQxRightEN obj = clsvQxRightWApi.GetObjByRightId(strRightId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvQxRightObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strRightId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetRightNameByRightId_Cache(string strRightId)
{
if (string.IsNullOrEmpty(strRightId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvQxRightEN._CurrTabName_S);
List<clsvQxRightEN> arrvQxRightObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvQxRightEN> arrvQxRightObjLst_Sel1 =
from objvQxRightEN in arrvQxRightObjLst_Cache
where objvQxRightEN.RightId == strRightId
select objvQxRightEN;
List <clsvQxRightEN> arrvQxRightObjLst_Sel = new List<clsvQxRightEN>();
foreach (clsvQxRightEN obj in arrvQxRightObjLst_Sel1)
{
arrvQxRightObjLst_Sel.Add(obj);
}
if (arrvQxRightObjLst_Sel.Count > 0)
{
return arrvQxRightObjLst_Sel[0].RightName;
}
string strErrMsgForGetObjById = string.Format("在vQxRight对象缓存列表中,找不到记录[RightId = {0}](函数:{1})", strRightId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvQxRightBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strRightId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByRightId_Cache(string strRightId)
{
if (string.IsNullOrEmpty(strRightId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvQxRightEN._CurrTabName_S);
List<clsvQxRightEN> arrvQxRightObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvQxRightEN> arrvQxRightObjLst_Sel1 =
from objvQxRightEN in arrvQxRightObjLst_Cache
where objvQxRightEN.RightId == strRightId
select objvQxRightEN;
List <clsvQxRightEN> arrvQxRightObjLst_Sel = new List<clsvQxRightEN>();
foreach (clsvQxRightEN obj in arrvQxRightObjLst_Sel1)
{
arrvQxRightObjLst_Sel.Add(obj);
}
if (arrvQxRightObjLst_Sel.Count > 0)
{
return arrvQxRightObjLst_Sel[0].RightName;
}
string strErrMsgForGetObjById = string.Format("在vQxRight对象缓存列表中,找不到记录的相关名称[RightId = {0}](函数:{1})", strRightId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvQxRightBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxRightEN> GetObjLst(string strWhereCond)
{
 List<clsvQxRightEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxRightEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQxRightEN> GetObjLstByRightIdLst(List<string> arrRightId)
{
 List<clsvQxRightEN> arrObjLst = null; 
string strAction = "GetObjLstByRightIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrRightId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxRightEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strRightId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvQxRightEN> GetObjLstByRightIdLst_Cache(List<string> arrRightId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvQxRightEN._CurrTabName_S);
List<clsvQxRightEN> arrvQxRightObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvQxRightEN> arrvQxRightObjLst_Sel =
from objvQxRightEN in arrvQxRightObjLst_Cache
where arrRightId.Contains(objvQxRightEN.RightId)
select objvQxRightEN;
return arrvQxRightObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxRightEN> GetObjLstByRightIdLst_WA_Cache(List<string> arrRightId)
{
 List<clsvQxRightEN> arrObjLst = null; 
string strAction = "GetObjLstByRightIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrRightId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxRightEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQxRightEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQxRightEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxRightEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQxRightEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQxRightEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxRightEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQxRightEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQxRightEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxRightEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQxRightEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvQxRightEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQxRightEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strRightId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["RightId"] = strRightId
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
 /// <param name = "objvQxRightENS">源对象</param>
 /// <param name = "objvQxRightENT">目标对象</param>
 public static void CopyTo(clsvQxRightEN objvQxRightENS, clsvQxRightEN objvQxRightENT)
{
try
{
objvQxRightENT.RightId = objvQxRightENS.RightId; //权限编号
objvQxRightENT.RightName = objvQxRightENS.RightName; //权限名称
objvQxRightENT.RightTypeId = objvQxRightENS.RightTypeId; //权限类型编号
objvQxRightENT.RightTypeName = objvQxRightENS.RightTypeName; //权限类型名
objvQxRightENT.MenuId = objvQxRightENS.MenuId; //菜单编号
objvQxRightENT.FuncModuleId = objvQxRightENS.FuncModuleId; //功能模块Id
objvQxRightENT.FuncModuleName = objvQxRightENS.FuncModuleName; //功能模块名称
objvQxRightENT.FuncModuleName_Sim = objvQxRightENS.FuncModuleName_Sim; //功能模块简称
objvQxRightENT.OrderNum = objvQxRightENS.OrderNum; //序号
objvQxRightENT.RightRangeLevelId = objvQxRightENS.RightRangeLevelId; //权限范围等级Id
objvQxRightENT.RightRangeLevelName = objvQxRightENS.RightRangeLevelName; //权限范围等级名称
objvQxRightENT.UpdDate = objvQxRightENS.UpdDate; //修改日期
objvQxRightENT.UpdUser = objvQxRightENS.UpdUser; //修改人
objvQxRightENT.Memo = objvQxRightENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvQxRightEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQxRightEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQxRightEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQxRightEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQxRightEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQxRightEN.AttributeName)
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
if (clsQxRightWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxRightWApi没有刷新缓存机制(clsQxRightWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxRightRangeLevelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxRightRangeLevelWApi没有刷新缓存机制(clsQxRightRangeLevelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxRightTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxRightTypeWApi没有刷新缓存机制(clsQxRightTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by RightId");
//if (arrvQxRightObjLst_Cache == null)
//{
//arrvQxRightObjLst_Cache = await clsvQxRightWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvQxRightEN._CurrTabName_S);
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
public static List<clsvQxRightEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvQxRightEN._CurrTabName_S);
List<clsvQxRightEN> arrvQxRightObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQxRightObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvQxRightEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQxRight.RightId, Type.GetType("System.String"));
objDT.Columns.Add(convQxRight.RightName, Type.GetType("System.String"));
objDT.Columns.Add(convQxRight.RightTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convQxRight.RightTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convQxRight.MenuId, Type.GetType("System.String"));
objDT.Columns.Add(convQxRight.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convQxRight.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convQxRight.FuncModuleName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convQxRight.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convQxRight.RightRangeLevelId, Type.GetType("System.String"));
objDT.Columns.Add(convQxRight.RightRangeLevelName, Type.GetType("System.String"));
objDT.Columns.Add(convQxRight.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convQxRight.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convQxRight.Memo, Type.GetType("System.String"));
foreach (clsvQxRightEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQxRight.RightId] = objInFor[convQxRight.RightId];
objDR[convQxRight.RightName] = objInFor[convQxRight.RightName];
objDR[convQxRight.RightTypeId] = objInFor[convQxRight.RightTypeId];
objDR[convQxRight.RightTypeName] = objInFor[convQxRight.RightTypeName];
objDR[convQxRight.MenuId] = objInFor[convQxRight.MenuId];
objDR[convQxRight.FuncModuleId] = objInFor[convQxRight.FuncModuleId];
objDR[convQxRight.FuncModuleName] = objInFor[convQxRight.FuncModuleName];
objDR[convQxRight.FuncModuleName_Sim] = objInFor[convQxRight.FuncModuleName_Sim];
objDR[convQxRight.OrderNum] = objInFor[convQxRight.OrderNum];
objDR[convQxRight.RightRangeLevelId] = objInFor[convQxRight.RightRangeLevelId];
objDR[convQxRight.RightRangeLevelName] = objInFor[convQxRight.RightRangeLevelName];
objDR[convQxRight.UpdDate] = objInFor[convQxRight.UpdDate];
objDR[convQxRight.UpdUser] = objInFor[convQxRight.UpdUser];
objDR[convQxRight.Memo] = objInFor[convQxRight.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}