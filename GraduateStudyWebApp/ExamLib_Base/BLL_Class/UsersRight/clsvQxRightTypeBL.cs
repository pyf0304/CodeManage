
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxRightTypeBL
 表名:vQxRightType(01120171)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:17
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:权限管理(UsersRight)
 框架-层名:业务逻辑层(CS)(BusinessLogic)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using Newtonsoft.Json;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.json;
using com.taishsoft.dynamiccompiler;
using com.taishsoft.datetime;
using ExamLib.Entity;
using System.Data; 
using System.Data.SqlClient; 
using ExamLib.DAL;

namespace ExamLib.BusinessLogic
{
public static class  clsvQxRightTypeBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strRightTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxRightTypeEN GetObj(this K_RightTypeId_vQxRightType myKey)
{
clsvQxRightTypeEN objvQxRightTypeEN = clsvQxRightTypeBL.vQxRightTypeDA.GetObjByRightTypeId(myKey.Value);
return objvQxRightTypeEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRightTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRightTypeEN SetRightTypeId(this clsvQxRightTypeEN objvQxRightTypeEN, string strRightTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRightTypeId, 4, convQxRightType.RightTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRightTypeId, 4, convQxRightType.RightTypeId);
}
objvQxRightTypeEN.RightTypeId = strRightTypeId; //权限类型编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRightTypeEN.dicFldComparisonOp.ContainsKey(convQxRightType.RightTypeId) == false)
{
objvQxRightTypeEN.dicFldComparisonOp.Add(convQxRightType.RightTypeId, strComparisonOp);
}
else
{
objvQxRightTypeEN.dicFldComparisonOp[convQxRightType.RightTypeId] = strComparisonOp;
}
}
return objvQxRightTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRightTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRightTypeEN SetRightTypeName(this clsvQxRightTypeEN objvQxRightTypeEN, string strRightTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRightTypeName, convQxRightType.RightTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRightTypeName, 50, convQxRightType.RightTypeName);
}
objvQxRightTypeEN.RightTypeName = strRightTypeName; //权限类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRightTypeEN.dicFldComparisonOp.ContainsKey(convQxRightType.RightTypeName) == false)
{
objvQxRightTypeEN.dicFldComparisonOp.Add(convQxRightType.RightTypeName, strComparisonOp);
}
else
{
objvQxRightTypeEN.dicFldComparisonOp[convQxRightType.RightTypeName] = strComparisonOp;
}
}
return objvQxRightTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRightTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRightTypeEN SetFuncModuleId(this clsvQxRightTypeEN objvQxRightTypeEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convQxRightType.FuncModuleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convQxRightType.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convQxRightType.FuncModuleId);
}
objvQxRightTypeEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRightTypeEN.dicFldComparisonOp.ContainsKey(convQxRightType.FuncModuleId) == false)
{
objvQxRightTypeEN.dicFldComparisonOp.Add(convQxRightType.FuncModuleId, strComparisonOp);
}
else
{
objvQxRightTypeEN.dicFldComparisonOp[convQxRightType.FuncModuleId] = strComparisonOp;
}
}
return objvQxRightTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRightTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRightTypeEN SetFuncModuleName(this clsvQxRightTypeEN objvQxRightTypeEN, string strFuncModuleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convQxRightType.FuncModuleName);
}
objvQxRightTypeEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRightTypeEN.dicFldComparisonOp.ContainsKey(convQxRightType.FuncModuleName) == false)
{
objvQxRightTypeEN.dicFldComparisonOp.Add(convQxRightType.FuncModuleName, strComparisonOp);
}
else
{
objvQxRightTypeEN.dicFldComparisonOp[convQxRightType.FuncModuleName] = strComparisonOp;
}
}
return objvQxRightTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRightTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRightTypeEN SetFuncModuleNameSim(this clsvQxRightTypeEN objvQxRightTypeEN, string strFuncModuleNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleNameSim, 30, convQxRightType.FuncModuleNameSim);
}
objvQxRightTypeEN.FuncModuleNameSim = strFuncModuleNameSim; //功能模块简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRightTypeEN.dicFldComparisonOp.ContainsKey(convQxRightType.FuncModuleNameSim) == false)
{
objvQxRightTypeEN.dicFldComparisonOp.Add(convQxRightType.FuncModuleNameSim, strComparisonOp);
}
else
{
objvQxRightTypeEN.dicFldComparisonOp[convQxRightType.FuncModuleNameSim] = strComparisonOp;
}
}
return objvQxRightTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRightTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRightTypeEN SetMenuId(this clsvQxRightTypeEN objvQxRightTypeEN, string strMenuId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMenuId, convQxRightType.MenuId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuId, 8, convQxRightType.MenuId);
}
objvQxRightTypeEN.MenuId = strMenuId; //菜单编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRightTypeEN.dicFldComparisonOp.ContainsKey(convQxRightType.MenuId) == false)
{
objvQxRightTypeEN.dicFldComparisonOp.Add(convQxRightType.MenuId, strComparisonOp);
}
else
{
objvQxRightTypeEN.dicFldComparisonOp[convQxRightType.MenuId] = strComparisonOp;
}
}
return objvQxRightTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRightTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRightTypeEN SetViewId(this clsvQxRightTypeEN objvQxRightTypeEN, string strViewId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strViewId, convQxRightType.ViewId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strViewId, 8, convQxRightType.ViewId);
}
objvQxRightTypeEN.ViewId = strViewId; //界面编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRightTypeEN.dicFldComparisonOp.ContainsKey(convQxRightType.ViewId) == false)
{
objvQxRightTypeEN.dicFldComparisonOp.Add(convQxRightType.ViewId, strComparisonOp);
}
else
{
objvQxRightTypeEN.dicFldComparisonOp[convQxRightType.ViewId] = strComparisonOp;
}
}
return objvQxRightTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRightTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRightTypeEN SetUpdDate(this clsvQxRightTypeEN objvQxRightTypeEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxRightType.UpdDate);
}
objvQxRightTypeEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRightTypeEN.dicFldComparisonOp.ContainsKey(convQxRightType.UpdDate) == false)
{
objvQxRightTypeEN.dicFldComparisonOp.Add(convQxRightType.UpdDate, strComparisonOp);
}
else
{
objvQxRightTypeEN.dicFldComparisonOp[convQxRightType.UpdDate] = strComparisonOp;
}
}
return objvQxRightTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRightTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRightTypeEN SetUpdUser(this clsvQxRightTypeEN objvQxRightTypeEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convQxRightType.UpdUser);
}
objvQxRightTypeEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRightTypeEN.dicFldComparisonOp.ContainsKey(convQxRightType.UpdUser) == false)
{
objvQxRightTypeEN.dicFldComparisonOp.Add(convQxRightType.UpdUser, strComparisonOp);
}
else
{
objvQxRightTypeEN.dicFldComparisonOp[convQxRightType.UpdUser] = strComparisonOp;
}
}
return objvQxRightTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRightTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRightTypeEN SetMemo(this clsvQxRightTypeEN objvQxRightTypeEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxRightType.Memo);
}
objvQxRightTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRightTypeEN.dicFldComparisonOp.ContainsKey(convQxRightType.Memo) == false)
{
objvQxRightTypeEN.dicFldComparisonOp.Add(convQxRightType.Memo, strComparisonOp);
}
else
{
objvQxRightTypeEN.dicFldComparisonOp[convQxRightType.Memo] = strComparisonOp;
}
}
return objvQxRightTypeEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQxRightTypeENS">源对象</param>
 /// <param name = "objvQxRightTypeENT">目标对象</param>
 public static void CopyTo(this clsvQxRightTypeEN objvQxRightTypeENS, clsvQxRightTypeEN objvQxRightTypeENT)
{
try
{
objvQxRightTypeENT.RightTypeId = objvQxRightTypeENS.RightTypeId; //权限类型编号
objvQxRightTypeENT.RightTypeName = objvQxRightTypeENS.RightTypeName; //权限类型名
objvQxRightTypeENT.FuncModuleId = objvQxRightTypeENS.FuncModuleId; //功能模块Id
objvQxRightTypeENT.FuncModuleName = objvQxRightTypeENS.FuncModuleName; //功能模块名称
objvQxRightTypeENT.FuncModuleNameSim = objvQxRightTypeENS.FuncModuleNameSim; //功能模块简称
objvQxRightTypeENT.MenuId = objvQxRightTypeENS.MenuId; //菜单编号
objvQxRightTypeENT.ViewId = objvQxRightTypeENS.ViewId; //界面编号
objvQxRightTypeENT.UpdDate = objvQxRightTypeENS.UpdDate; //修改日期
objvQxRightTypeENT.UpdUser = objvQxRightTypeENS.UpdUser; //修改人
objvQxRightTypeENT.Memo = objvQxRightTypeENS.Memo; //备注
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000166)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyTo)
 /// </summary>
 /// <param name = "objvQxRightTypeENS">源对象</param>
 /// <returns>目标对象=>clsvQxRightTypeEN:objvQxRightTypeENT</returns>
 public static clsvQxRightTypeEN CopyTo(this clsvQxRightTypeEN objvQxRightTypeENS)
{
try
{
 clsvQxRightTypeEN objvQxRightTypeENT = new clsvQxRightTypeEN()
{
RightTypeId = objvQxRightTypeENS.RightTypeId, //权限类型编号
RightTypeName = objvQxRightTypeENS.RightTypeName, //权限类型名
FuncModuleId = objvQxRightTypeENS.FuncModuleId, //功能模块Id
FuncModuleName = objvQxRightTypeENS.FuncModuleName, //功能模块名称
FuncModuleNameSim = objvQxRightTypeENS.FuncModuleNameSim, //功能模块简称
MenuId = objvQxRightTypeENS.MenuId, //菜单编号
ViewId = objvQxRightTypeENS.ViewId, //界面编号
UpdDate = objvQxRightTypeENS.UpdDate, //修改日期
UpdUser = objvQxRightTypeENS.UpdUser, //修改人
Memo = objvQxRightTypeENS.Memo, //备注
};
 return objvQxRightTypeENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000167)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsvQxRightTypeEN objvQxRightTypeEN)
{
 clsvQxRightTypeBL.vQxRightTypeDA.CheckProperty4Condition(objvQxRightTypeEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxRightTypeEN objvQxRightTypeCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxRightTypeCond.IsUpdated(convQxRightType.RightTypeId) == true)
{
string strComparisonOpRightTypeId = objvQxRightTypeCond.dicFldComparisonOp[convQxRightType.RightTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRightType.RightTypeId, objvQxRightTypeCond.RightTypeId, strComparisonOpRightTypeId);
}
if (objvQxRightTypeCond.IsUpdated(convQxRightType.RightTypeName) == true)
{
string strComparisonOpRightTypeName = objvQxRightTypeCond.dicFldComparisonOp[convQxRightType.RightTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRightType.RightTypeName, objvQxRightTypeCond.RightTypeName, strComparisonOpRightTypeName);
}
if (objvQxRightTypeCond.IsUpdated(convQxRightType.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objvQxRightTypeCond.dicFldComparisonOp[convQxRightType.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRightType.FuncModuleId, objvQxRightTypeCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objvQxRightTypeCond.IsUpdated(convQxRightType.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvQxRightTypeCond.dicFldComparisonOp[convQxRightType.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRightType.FuncModuleName, objvQxRightTypeCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvQxRightTypeCond.IsUpdated(convQxRightType.FuncModuleNameSim) == true)
{
string strComparisonOpFuncModuleNameSim = objvQxRightTypeCond.dicFldComparisonOp[convQxRightType.FuncModuleNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRightType.FuncModuleNameSim, objvQxRightTypeCond.FuncModuleNameSim, strComparisonOpFuncModuleNameSim);
}
if (objvQxRightTypeCond.IsUpdated(convQxRightType.MenuId) == true)
{
string strComparisonOpMenuId = objvQxRightTypeCond.dicFldComparisonOp[convQxRightType.MenuId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRightType.MenuId, objvQxRightTypeCond.MenuId, strComparisonOpMenuId);
}
if (objvQxRightTypeCond.IsUpdated(convQxRightType.ViewId) == true)
{
string strComparisonOpViewId = objvQxRightTypeCond.dicFldComparisonOp[convQxRightType.ViewId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRightType.ViewId, objvQxRightTypeCond.ViewId, strComparisonOpViewId);
}
if (objvQxRightTypeCond.IsUpdated(convQxRightType.UpdDate) == true)
{
string strComparisonOpUpdDate = objvQxRightTypeCond.dicFldComparisonOp[convQxRightType.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRightType.UpdDate, objvQxRightTypeCond.UpdDate, strComparisonOpUpdDate);
}
if (objvQxRightTypeCond.IsUpdated(convQxRightType.UpdUser) == true)
{
string strComparisonOpUpdUser = objvQxRightTypeCond.dicFldComparisonOp[convQxRightType.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRightType.UpdUser, objvQxRightTypeCond.UpdUser, strComparisonOpUpdUser);
}
if (objvQxRightTypeCond.IsUpdated(convQxRightType.Memo) == true)
{
string strComparisonOpMemo = objvQxRightTypeCond.dicFldComparisonOp[convQxRightType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRightType.Memo, objvQxRightTypeCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQxRightType
{
public virtual bool UpdRelaTabDate(string strRightTypeId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v权限类型(vQxRightType)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQxRightTypeBL
{
public static RelatedActions_vQxRightType relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQxRightTypeDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQxRightTypeDA vQxRightTypeDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQxRightTypeDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQxRightTypeBL()
 {
 }

 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSpecSQLObj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public static clsSpecSQLforSql GetSpecSQLObj() 
{
if (clsSysParaEN.objLog == null)
{
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象!");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象!");
}
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName == true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
if (string.IsNullOrEmpty(clsvQxRightTypeEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxRightTypeEN._ConnectString);
}
return objSQL;
}



 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_vQxRightType(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQxRightTypeDA.GetDataTable_vQxRightType(strWhereCond);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000005)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQxRightTypeDA.GetDataTable(strWhereCond);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vQxRightTypeDA.GetDataTable(strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000007)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName)
{
DataTable objDT;
try
{
objDT = vQxRightTypeDA.GetDataTable(strWhereCond, strTabName);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000061)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vQxRightTypeDA.GetDataTable(strWhereCond, strTabName, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000062)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_Top(stuTopPara objTopPara)
{
DataTable objDT;
try
{
objDT = vQxRightTypeDA.GetDataTable_Top(objTopPara);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000009)获取表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
objTopPara.whereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vQxRightTypeDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000010)获取表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
DataTable objDT;
try
{
objDT = vQxRightTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000012)获取分页表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vQxRightTypeDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000013)获取分页表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 获取数据表的DataTable


 #region 获取数据表的多个对象列表

 /// <summary>
 /// 根据关键字列表获取相关对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "arrRightTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvQxRightTypeEN> GetObjLstByRightTypeIdLst(List<string> arrRightTypeIdLst)
{
List<clsvQxRightTypeEN> arrObjLst = new List<clsvQxRightTypeEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrRightTypeIdLst, true);
 string strWhereCond = string.Format("RightTypeId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRightTypeEN objvQxRightTypeEN = new clsvQxRightTypeEN();
try
{
objvQxRightTypeEN.RightTypeId = objRow[convQxRightType.RightTypeId].ToString().Trim(); //权限类型编号
objvQxRightTypeEN.RightTypeName = objRow[convQxRightType.RightTypeName].ToString().Trim(); //权限类型名
objvQxRightTypeEN.FuncModuleId = objRow[convQxRightType.FuncModuleId].ToString().Trim(); //功能模块Id
objvQxRightTypeEN.FuncModuleName = objRow[convQxRightType.FuncModuleName] == DBNull.Value ? null : objRow[convQxRightType.FuncModuleName].ToString().Trim(); //功能模块名称
objvQxRightTypeEN.FuncModuleNameSim = objRow[convQxRightType.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxRightType.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvQxRightTypeEN.MenuId = objRow[convQxRightType.MenuId].ToString().Trim(); //菜单编号
objvQxRightTypeEN.ViewId = objRow[convQxRightType.ViewId].ToString().Trim(); //界面编号
objvQxRightTypeEN.UpdDate = objRow[convQxRightType.UpdDate] == DBNull.Value ? null : objRow[convQxRightType.UpdDate].ToString().Trim(); //修改日期
objvQxRightTypeEN.UpdUser = objRow[convQxRightType.UpdUser] == DBNull.Value ? null : objRow[convQxRightType.UpdUser].ToString().Trim(); //修改人
objvQxRightTypeEN.Memo = objRow[convQxRightType.Memo] == DBNull.Value ? null : objRow[convQxRightType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRightTypeEN.RightTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRightTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrRightTypeIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQxRightTypeEN> GetObjLstByRightTypeIdLstCache(List<string> arrRightTypeIdLst)
{
string strKey = string.Format("{0}", clsvQxRightTypeEN._CurrTabName);
List<clsvQxRightTypeEN> arrvQxRightTypeObjLstCache = GetObjLstCache();
IEnumerable <clsvQxRightTypeEN> arrvQxRightTypeObjLst_Sel =
arrvQxRightTypeObjLstCache
.Where(x => arrRightTypeIdLst.Contains(x.RightTypeId));
return arrvQxRightTypeObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxRightTypeEN> GetObjLst(string strWhereCond)
{
List<clsvQxRightTypeEN> arrObjLst = new List<clsvQxRightTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRightTypeEN objvQxRightTypeEN = new clsvQxRightTypeEN();
try
{
objvQxRightTypeEN.RightTypeId = objRow[convQxRightType.RightTypeId].ToString().Trim(); //权限类型编号
objvQxRightTypeEN.RightTypeName = objRow[convQxRightType.RightTypeName].ToString().Trim(); //权限类型名
objvQxRightTypeEN.FuncModuleId = objRow[convQxRightType.FuncModuleId].ToString().Trim(); //功能模块Id
objvQxRightTypeEN.FuncModuleName = objRow[convQxRightType.FuncModuleName] == DBNull.Value ? null : objRow[convQxRightType.FuncModuleName].ToString().Trim(); //功能模块名称
objvQxRightTypeEN.FuncModuleNameSim = objRow[convQxRightType.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxRightType.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvQxRightTypeEN.MenuId = objRow[convQxRightType.MenuId].ToString().Trim(); //菜单编号
objvQxRightTypeEN.ViewId = objRow[convQxRightType.ViewId].ToString().Trim(); //界面编号
objvQxRightTypeEN.UpdDate = objRow[convQxRightType.UpdDate] == DBNull.Value ? null : objRow[convQxRightType.UpdDate].ToString().Trim(); //修改日期
objvQxRightTypeEN.UpdUser = objRow[convQxRightType.UpdUser] == DBNull.Value ? null : objRow[convQxRightType.UpdUser].ToString().Trim(); //修改人
objvQxRightTypeEN.Memo = objRow[convQxRightType.Memo] == DBNull.Value ? null : objRow[convQxRightType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRightTypeEN.RightTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRightTypeEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxRightTypeEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQxRightTypeEN> arrObjLst = new List<clsvQxRightTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRightTypeEN objvQxRightTypeEN = new clsvQxRightTypeEN();
try
{
objvQxRightTypeEN.RightTypeId = objRow[convQxRightType.RightTypeId].ToString().Trim(); //权限类型编号
objvQxRightTypeEN.RightTypeName = objRow[convQxRightType.RightTypeName].ToString().Trim(); //权限类型名
objvQxRightTypeEN.FuncModuleId = objRow[convQxRightType.FuncModuleId].ToString().Trim(); //功能模块Id
objvQxRightTypeEN.FuncModuleName = objRow[convQxRightType.FuncModuleName] == DBNull.Value ? null : objRow[convQxRightType.FuncModuleName].ToString().Trim(); //功能模块名称
objvQxRightTypeEN.FuncModuleNameSim = objRow[convQxRightType.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxRightType.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvQxRightTypeEN.MenuId = objRow[convQxRightType.MenuId].ToString().Trim(); //菜单编号
objvQxRightTypeEN.ViewId = objRow[convQxRightType.ViewId].ToString().Trim(); //界面编号
objvQxRightTypeEN.UpdDate = objRow[convQxRightType.UpdDate] == DBNull.Value ? null : objRow[convQxRightType.UpdDate].ToString().Trim(); //修改日期
objvQxRightTypeEN.UpdUser = objRow[convQxRightType.UpdUser] == DBNull.Value ? null : objRow[convQxRightType.UpdUser].ToString().Trim(); //修改人
objvQxRightTypeEN.Memo = objRow[convQxRightType.Memo] == DBNull.Value ? null : objRow[convQxRightType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRightTypeEN.RightTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRightTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQxRightTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQxRightTypeEN> GetSubObjLstCache(clsvQxRightTypeEN objvQxRightTypeCond)
{
List<clsvQxRightTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxRightTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxRightType.AttributeName)
{
if (objvQxRightTypeCond.IsUpdated(strFldName) == false) continue;
if (objvQxRightTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxRightTypeCond[strFldName].ToString());
}
else
{
if (objvQxRightTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxRightTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxRightTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxRightTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxRightTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxRightTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxRightTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxRightTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxRightTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxRightTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxRightTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxRightTypeCond[strFldName]));
}
}
}
return arrObjLstSel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxRightTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQxRightTypeEN> arrObjLst = new List<clsvQxRightTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRightTypeEN objvQxRightTypeEN = new clsvQxRightTypeEN();
try
{
objvQxRightTypeEN.RightTypeId = objRow[convQxRightType.RightTypeId].ToString().Trim(); //权限类型编号
objvQxRightTypeEN.RightTypeName = objRow[convQxRightType.RightTypeName].ToString().Trim(); //权限类型名
objvQxRightTypeEN.FuncModuleId = objRow[convQxRightType.FuncModuleId].ToString().Trim(); //功能模块Id
objvQxRightTypeEN.FuncModuleName = objRow[convQxRightType.FuncModuleName] == DBNull.Value ? null : objRow[convQxRightType.FuncModuleName].ToString().Trim(); //功能模块名称
objvQxRightTypeEN.FuncModuleNameSim = objRow[convQxRightType.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxRightType.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvQxRightTypeEN.MenuId = objRow[convQxRightType.MenuId].ToString().Trim(); //菜单编号
objvQxRightTypeEN.ViewId = objRow[convQxRightType.ViewId].ToString().Trim(); //界面编号
objvQxRightTypeEN.UpdDate = objRow[convQxRightType.UpdDate] == DBNull.Value ? null : objRow[convQxRightType.UpdDate].ToString().Trim(); //修改日期
objvQxRightTypeEN.UpdUser = objRow[convQxRightType.UpdUser] == DBNull.Value ? null : objRow[convQxRightType.UpdUser].ToString().Trim(); //修改人
objvQxRightTypeEN.Memo = objRow[convQxRightType.Memo] == DBNull.Value ? null : objRow[convQxRightType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRightTypeEN.RightTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRightTypeEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxRightTypeEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQxRightTypeEN> arrObjLst = new List<clsvQxRightTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRightTypeEN objvQxRightTypeEN = new clsvQxRightTypeEN();
try
{
objvQxRightTypeEN.RightTypeId = objRow[convQxRightType.RightTypeId].ToString().Trim(); //权限类型编号
objvQxRightTypeEN.RightTypeName = objRow[convQxRightType.RightTypeName].ToString().Trim(); //权限类型名
objvQxRightTypeEN.FuncModuleId = objRow[convQxRightType.FuncModuleId].ToString().Trim(); //功能模块Id
objvQxRightTypeEN.FuncModuleName = objRow[convQxRightType.FuncModuleName] == DBNull.Value ? null : objRow[convQxRightType.FuncModuleName].ToString().Trim(); //功能模块名称
objvQxRightTypeEN.FuncModuleNameSim = objRow[convQxRightType.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxRightType.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvQxRightTypeEN.MenuId = objRow[convQxRightType.MenuId].ToString().Trim(); //菜单编号
objvQxRightTypeEN.ViewId = objRow[convQxRightType.ViewId].ToString().Trim(); //界面编号
objvQxRightTypeEN.UpdDate = objRow[convQxRightType.UpdDate] == DBNull.Value ? null : objRow[convQxRightType.UpdDate].ToString().Trim(); //修改日期
objvQxRightTypeEN.UpdUser = objRow[convQxRightType.UpdUser] == DBNull.Value ? null : objRow[convQxRightType.UpdUser].ToString().Trim(); //修改人
objvQxRightTypeEN.Memo = objRow[convQxRightType.Memo] == DBNull.Value ? null : objRow[convQxRightType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRightTypeEN.RightTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRightTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static string GetJSONObjLst(string strWhereCond)
{
List<clsvQxRightTypeEN> arrObjLst = GetObjLst(strWhereCond);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}
 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static string GetJSONObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQxRightTypeEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxRightTypeEN> GetTopObjLst(stuTopPara objTopPara)
{
 return GetTopObjLst( objTopPara.topSize, objTopPara.whereCond, objTopPara.orderBy);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxRightTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQxRightTypeEN> arrObjLst = new List<clsvQxRightTypeEN>(); 
System.Data.DataTable objDT; 
 stuTopPara objTopPara = new stuTopPara()
 {
 topSize = intTopSize,
 whereCond = strWhereCond,
 orderBy = strOrderBy
 };
 objDT = GetDataTable_Top(objTopPara);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRightTypeEN objvQxRightTypeEN = new clsvQxRightTypeEN();
try
{
objvQxRightTypeEN.RightTypeId = objRow[convQxRightType.RightTypeId].ToString().Trim(); //权限类型编号
objvQxRightTypeEN.RightTypeName = objRow[convQxRightType.RightTypeName].ToString().Trim(); //权限类型名
objvQxRightTypeEN.FuncModuleId = objRow[convQxRightType.FuncModuleId].ToString().Trim(); //功能模块Id
objvQxRightTypeEN.FuncModuleName = objRow[convQxRightType.FuncModuleName] == DBNull.Value ? null : objRow[convQxRightType.FuncModuleName].ToString().Trim(); //功能模块名称
objvQxRightTypeEN.FuncModuleNameSim = objRow[convQxRightType.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxRightType.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvQxRightTypeEN.MenuId = objRow[convQxRightType.MenuId].ToString().Trim(); //菜单编号
objvQxRightTypeEN.ViewId = objRow[convQxRightType.ViewId].ToString().Trim(); //界面编号
objvQxRightTypeEN.UpdDate = objRow[convQxRightType.UpdDate] == DBNull.Value ? null : objRow[convQxRightType.UpdDate].ToString().Trim(); //修改日期
objvQxRightTypeEN.UpdUser = objRow[convQxRightType.UpdUser] == DBNull.Value ? null : objRow[convQxRightType.UpdUser].ToString().Trim(); //修改人
objvQxRightTypeEN.Memo = objRow[convQxRightType.Memo] == DBNull.Value ? null : objRow[convQxRightType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRightTypeEN.RightTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRightTypeEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxRightTypeEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQxRightTypeEN> arrObjLst = new List<clsvQxRightTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRightTypeEN objvQxRightTypeEN = new clsvQxRightTypeEN();
try
{
objvQxRightTypeEN.RightTypeId = objRow[convQxRightType.RightTypeId].ToString().Trim(); //权限类型编号
objvQxRightTypeEN.RightTypeName = objRow[convQxRightType.RightTypeName].ToString().Trim(); //权限类型名
objvQxRightTypeEN.FuncModuleId = objRow[convQxRightType.FuncModuleId].ToString().Trim(); //功能模块Id
objvQxRightTypeEN.FuncModuleName = objRow[convQxRightType.FuncModuleName] == DBNull.Value ? null : objRow[convQxRightType.FuncModuleName].ToString().Trim(); //功能模块名称
objvQxRightTypeEN.FuncModuleNameSim = objRow[convQxRightType.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxRightType.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvQxRightTypeEN.MenuId = objRow[convQxRightType.MenuId].ToString().Trim(); //菜单编号
objvQxRightTypeEN.ViewId = objRow[convQxRightType.ViewId].ToString().Trim(); //界面编号
objvQxRightTypeEN.UpdDate = objRow[convQxRightType.UpdDate] == DBNull.Value ? null : objRow[convQxRightType.UpdDate].ToString().Trim(); //修改日期
objvQxRightTypeEN.UpdUser = objRow[convQxRightType.UpdUser] == DBNull.Value ? null : objRow[convQxRightType.UpdUser].ToString().Trim(); //修改人
objvQxRightTypeEN.Memo = objRow[convQxRightType.Memo] == DBNull.Value ? null : objRow[convQxRightType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRightTypeEN.RightTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRightTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQxRightTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 return GetObjLstByPager(objPagerPara.pageIndex, objPagerPara.pageSize, objPagerPara.whereCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQxRightTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQxRightTypeEN> arrObjLst = new List<clsvQxRightTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRightTypeEN objvQxRightTypeEN = new clsvQxRightTypeEN();
try
{
objvQxRightTypeEN.RightTypeId = objRow[convQxRightType.RightTypeId].ToString().Trim(); //权限类型编号
objvQxRightTypeEN.RightTypeName = objRow[convQxRightType.RightTypeName].ToString().Trim(); //权限类型名
objvQxRightTypeEN.FuncModuleId = objRow[convQxRightType.FuncModuleId].ToString().Trim(); //功能模块Id
objvQxRightTypeEN.FuncModuleName = objRow[convQxRightType.FuncModuleName] == DBNull.Value ? null : objRow[convQxRightType.FuncModuleName].ToString().Trim(); //功能模块名称
objvQxRightTypeEN.FuncModuleNameSim = objRow[convQxRightType.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxRightType.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvQxRightTypeEN.MenuId = objRow[convQxRightType.MenuId].ToString().Trim(); //菜单编号
objvQxRightTypeEN.ViewId = objRow[convQxRightType.ViewId].ToString().Trim(); //界面编号
objvQxRightTypeEN.UpdDate = objRow[convQxRightType.UpdDate] == DBNull.Value ? null : objRow[convQxRightType.UpdDate].ToString().Trim(); //修改日期
objvQxRightTypeEN.UpdUser = objRow[convQxRightType.UpdUser] == DBNull.Value ? null : objRow[convQxRightType.UpdUser].ToString().Trim(); //修改人
objvQxRightTypeEN.Memo = objRow[convQxRightType.Memo] == DBNull.Value ? null : objRow[convQxRightType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRightTypeEN.RightTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRightTypeEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxRightTypeEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQxRightTypeEN> arrObjLst = new List<clsvQxRightTypeEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRightTypeEN objvQxRightTypeEN = new clsvQxRightTypeEN();
try
{
objvQxRightTypeEN.RightTypeId = objRow[convQxRightType.RightTypeId].ToString().Trim(); //权限类型编号
objvQxRightTypeEN.RightTypeName = objRow[convQxRightType.RightTypeName].ToString().Trim(); //权限类型名
objvQxRightTypeEN.FuncModuleId = objRow[convQxRightType.FuncModuleId].ToString().Trim(); //功能模块Id
objvQxRightTypeEN.FuncModuleName = objRow[convQxRightType.FuncModuleName] == DBNull.Value ? null : objRow[convQxRightType.FuncModuleName].ToString().Trim(); //功能模块名称
objvQxRightTypeEN.FuncModuleNameSim = objRow[convQxRightType.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxRightType.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvQxRightTypeEN.MenuId = objRow[convQxRightType.MenuId].ToString().Trim(); //菜单编号
objvQxRightTypeEN.ViewId = objRow[convQxRightType.ViewId].ToString().Trim(); //界面编号
objvQxRightTypeEN.UpdDate = objRow[convQxRightType.UpdDate] == DBNull.Value ? null : objRow[convQxRightType.UpdDate].ToString().Trim(); //修改日期
objvQxRightTypeEN.UpdUser = objRow[convQxRightType.UpdUser] == DBNull.Value ? null : objRow[convQxRightType.UpdUser].ToString().Trim(); //修改人
objvQxRightTypeEN.Memo = objRow[convQxRightType.Memo] == DBNull.Value ? null : objRow[convQxRightType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRightTypeEN.RightTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRightTypeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxRightTypeEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQxRightTypeEN> arrObjLst = new List<clsvQxRightTypeEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRightTypeEN objvQxRightTypeEN = new clsvQxRightTypeEN();
try
{
objvQxRightTypeEN.RightTypeId = objRow[convQxRightType.RightTypeId].ToString().Trim(); //权限类型编号
objvQxRightTypeEN.RightTypeName = objRow[convQxRightType.RightTypeName].ToString().Trim(); //权限类型名
objvQxRightTypeEN.FuncModuleId = objRow[convQxRightType.FuncModuleId].ToString().Trim(); //功能模块Id
objvQxRightTypeEN.FuncModuleName = objRow[convQxRightType.FuncModuleName] == DBNull.Value ? null : objRow[convQxRightType.FuncModuleName].ToString().Trim(); //功能模块名称
objvQxRightTypeEN.FuncModuleNameSim = objRow[convQxRightType.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxRightType.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvQxRightTypeEN.MenuId = objRow[convQxRightType.MenuId].ToString().Trim(); //菜单编号
objvQxRightTypeEN.ViewId = objRow[convQxRightType.ViewId].ToString().Trim(); //界面编号
objvQxRightTypeEN.UpdDate = objRow[convQxRightType.UpdDate] == DBNull.Value ? null : objRow[convQxRightType.UpdDate].ToString().Trim(); //修改日期
objvQxRightTypeEN.UpdUser = objRow[convQxRightType.UpdUser] == DBNull.Value ? null : objRow[convQxRightType.UpdUser].ToString().Trim(); //修改人
objvQxRightTypeEN.Memo = objRow[convQxRightType.Memo] == DBNull.Value ? null : objRow[convQxRightType.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRightTypeEN.RightTypeId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRightTypeEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQxRightTypeEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxRightType(ref clsvQxRightTypeEN objvQxRightTypeEN)
{
bool bolResult = vQxRightTypeDA.GetvQxRightType(ref objvQxRightTypeEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strRightTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxRightTypeEN GetObjByRightTypeId(string strRightTypeId)
{
if (strRightTypeId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strRightTypeId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strRightTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strRightTypeId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvQxRightTypeEN objvQxRightTypeEN = vQxRightTypeDA.GetObjByRightTypeId(strRightTypeId);
return objvQxRightTypeEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQxRightTypeEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQxRightTypeEN objvQxRightTypeEN = vQxRightTypeDA.GetFirstObj(strWhereCond);
 return objvQxRightTypeEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000022)获取当前表满足条件的第一条记录数据出错!(strWhereCond = {1}),{2}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 把DataRow转换成相关实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecValueObjByDataRow_S)
 /// </summary>
 /// <param name = "objRow">给定的DataRow</param>
 /// <returns>返回相关的实体对象</returns>
public static clsvQxRightTypeEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQxRightTypeEN objvQxRightTypeEN = vQxRightTypeDA.GetObjByDataRow(objRow);
 return objvQxRightTypeEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000051)根据DataRow记录获取对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}
 /// <summary>
 /// 把DataRowView转换成相关实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecValueObjByDataRow_S)
 /// </summary>
 /// <param name = "objRow">给定的DataRowView</param>
 /// <returns>返回相关的实体对象</returns>
public static clsvQxRightTypeEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQxRightTypeEN objvQxRightTypeEN = vQxRightTypeDA.GetObjByDataRow(objRow);
 return objvQxRightTypeEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000052)通过DataRowView记录对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 根据关键字获取相关对象, 从给定的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyFromList)
 /// </summary>
 /// <param name = "strRightTypeId">所给的关键字</param>
 /// <param name = "lstvQxRightTypeObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxRightTypeEN GetObjByRightTypeIdFromList(string strRightTypeId, List<clsvQxRightTypeEN> lstvQxRightTypeObjLst)
{
foreach (clsvQxRightTypeEN objvQxRightTypeEN in lstvQxRightTypeObjLst)
{
if (objvQxRightTypeEN.RightTypeId == strRightTypeId)
{
return objvQxRightTypeEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond) 
{
 string strRightTypeId;
 try
 {
 strRightTypeId = new clsvQxRightTypeDA().GetFirstID(strWhereCond);
 return strRightTypeId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000023)获取First关键字出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 获取一个关键字值


 #region 获取多个关键字值列表

 /// <summary>
 /// 获取当前表满足条件的关键字值列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetPrimaryKeyID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件的关键字列表值</returns>
public static List<string> GetPrimaryKeyID_S(string strWhereCond) 
{
 List<string> arrList;
 try
 {
 arrList = vQxRightTypeDA.GetID(strWhereCond);
 return arrList;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000026)获取关键字列表出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 获取多个关键字值列表


 #region 判断记录是否存在

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistRecord)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
public static bool IsExistRecord(string strWhereCond)
{
//检测记录是否存在
bool bolIsExist = vQxRightTypeDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strRightTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strRightTypeId)
{
if (string.IsNullOrEmpty(strRightTypeId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strRightTypeId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vQxRightTypeDA.IsExist(strRightTypeId);
return bolIsExist;
}

 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable() 
{
 bool bolIsExist;
 try
 {
 bolIsExist = clsvQxRightTypeDA.IsExistTable();
 return bolIsExist;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000028)检查是否存在当前表(IsExistTable)出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}
 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <param name = "strTabName">给定表</param>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable(string strTabName) 
{
 bool bolIsExist;
 try
 {
 bolIsExist = vQxRightTypeDA.IsExistTable(strTabName);
 return bolIsExist;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000029)检查是否存在指定表(IsExistTable)出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 判断记录是否存在


 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
 /// </summary>
 /// <param name = "objvQxRightTypeENS">源对象</param>
 /// <param name = "objvQxRightTypeENT">目标对象</param>
 public static void CopyTo(clsvQxRightTypeEN objvQxRightTypeENS, clsvQxRightTypeEN objvQxRightTypeENT)
{
try
{
objvQxRightTypeENT.RightTypeId = objvQxRightTypeENS.RightTypeId; //权限类型编号
objvQxRightTypeENT.RightTypeName = objvQxRightTypeENS.RightTypeName; //权限类型名
objvQxRightTypeENT.FuncModuleId = objvQxRightTypeENS.FuncModuleId; //功能模块Id
objvQxRightTypeENT.FuncModuleName = objvQxRightTypeENS.FuncModuleName; //功能模块名称
objvQxRightTypeENT.FuncModuleNameSim = objvQxRightTypeENS.FuncModuleNameSim; //功能模块简称
objvQxRightTypeENT.MenuId = objvQxRightTypeENS.MenuId; //菜单编号
objvQxRightTypeENT.ViewId = objvQxRightTypeENS.ViewId; //界面编号
objvQxRightTypeENT.UpdDate = objvQxRightTypeENS.UpdDate; //修改日期
objvQxRightTypeENT.UpdUser = objvQxRightTypeENS.UpdUser; //修改人
objvQxRightTypeENT.Memo = objvQxRightTypeENS.Memo; //备注
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000045)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 设置修改标志,即根据字段修改标志字符串获取哪一个字段已经被修改
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SetUpdFlag_S)
 /// </summary>
 /// <param name = "objvQxRightTypeEN">源简化对象</param>
 public static void SetUpdFlag(clsvQxRightTypeEN objvQxRightTypeEN)
{
try
{
objvQxRightTypeEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQxRightTypeEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQxRightType.RightTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRightTypeEN.RightTypeId = objvQxRightTypeEN.RightTypeId; //权限类型编号
}
if (arrFldSet.Contains(convQxRightType.RightTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRightTypeEN.RightTypeName = objvQxRightTypeEN.RightTypeName; //权限类型名
}
if (arrFldSet.Contains(convQxRightType.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRightTypeEN.FuncModuleId = objvQxRightTypeEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(convQxRightType.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRightTypeEN.FuncModuleName = objvQxRightTypeEN.FuncModuleName == "[null]" ? null :  objvQxRightTypeEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convQxRightType.FuncModuleNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRightTypeEN.FuncModuleNameSim = objvQxRightTypeEN.FuncModuleNameSim == "[null]" ? null :  objvQxRightTypeEN.FuncModuleNameSim; //功能模块简称
}
if (arrFldSet.Contains(convQxRightType.MenuId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRightTypeEN.MenuId = objvQxRightTypeEN.MenuId; //菜单编号
}
if (arrFldSet.Contains(convQxRightType.ViewId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRightTypeEN.ViewId = objvQxRightTypeEN.ViewId; //界面编号
}
if (arrFldSet.Contains(convQxRightType.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRightTypeEN.UpdDate = objvQxRightTypeEN.UpdDate == "[null]" ? null :  objvQxRightTypeEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convQxRightType.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRightTypeEN.UpdUser = objvQxRightTypeEN.UpdUser == "[null]" ? null :  objvQxRightTypeEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convQxRightType.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRightTypeEN.Memo = objvQxRightTypeEN.Memo == "[null]" ? null :  objvQxRightTypeEN.Memo; //备注
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:001)设置表的修改标志出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 处理从Web端传来的[null]的字段值,在WebApi端设置成null
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AccessFldValueNull)
 /// </summary>
 /// <param name = "objvQxRightTypeEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQxRightTypeEN objvQxRightTypeEN)
{
try
{
if (objvQxRightTypeEN.FuncModuleName == "[null]") objvQxRightTypeEN.FuncModuleName = null; //功能模块名称
if (objvQxRightTypeEN.FuncModuleNameSim == "[null]") objvQxRightTypeEN.FuncModuleNameSim = null; //功能模块简称
if (objvQxRightTypeEN.UpdDate == "[null]") objvQxRightTypeEN.UpdDate = null; //修改日期
if (objvQxRightTypeEN.UpdUser == "[null]") objvQxRightTypeEN.UpdUser = null; //修改人
if (objvQxRightTypeEN.Memo == "[null]") objvQxRightTypeEN.Memo = null; //备注
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:002)处理从Web端传来的[null]的字段值出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 克隆复制对象


 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsvQxRightTypeEN objvQxRightTypeEN)
{
 vQxRightTypeDA.CheckProperty4Condition(objvQxRightTypeEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_RightTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convQxRightType.RightTypeId); 
List<clsvQxRightTypeEN> arrObjLst = clsvQxRightTypeBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvQxRightTypeEN objvQxRightTypeEN = new clsvQxRightTypeEN()
{
RightTypeId = "0",
RightTypeName = "选[v权限类型]..."
};
arrObjLst.Insert(0, objvQxRightTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convQxRightType.RightTypeId;
objComboBox.DisplayMember = convQxRightType.RightTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_RightTypeId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v权限类型]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convQxRightType.RightTypeId); 
IEnumerable<clsvQxRightTypeEN> arrObjLst = clsvQxRightTypeBL.GetObjLst(strCondition);
objDDL.DataValueField = convQxRightType.RightTypeId;
objDDL.DataTextField = convQxRightType.RightTypeName;
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_RightTypeIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v权限类型]...","0");
List<clsvQxRightTypeEN> arrvQxRightTypeObjLst = GetAllvQxRightTypeObjLstCache(); 
objDDL.DataValueField = convQxRightType.RightTypeId;
objDDL.DataTextField = convQxRightType.RightTypeName;
objDDL.DataSource = arrvQxRightTypeObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}


 #endregion 绑定下拉框


 #region 缓存操作

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg;
if (clsFuncModuleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleBL没有刷新缓存机制(clsFuncModuleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxRightTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxRightTypeBL没有刷新缓存机制(clsQxRightTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by RightTypeId");
//if (arrvQxRightTypeObjLstCache == null)
//{
//arrvQxRightTypeObjLstCache = vQxRightTypeDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strRightTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxRightTypeEN GetObjByRightTypeIdCache(string strRightTypeId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvQxRightTypeEN._CurrTabName);
List<clsvQxRightTypeEN> arrvQxRightTypeObjLstCache = GetObjLstCache();
IEnumerable <clsvQxRightTypeEN> arrvQxRightTypeObjLst_Sel =
arrvQxRightTypeObjLstCache
.Where(x=> x.RightTypeId == strRightTypeId 
);
if (arrvQxRightTypeObjLst_Sel.Count() == 0)
{
   clsvQxRightTypeEN obj = clsvQxRightTypeBL.GetObjByRightTypeId(strRightTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvQxRightTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strRightTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetRightTypeNameByRightTypeIdCache(string strRightTypeId)
{
if (string.IsNullOrEmpty(strRightTypeId) == true) return "";
//获取缓存中的对象列表
clsvQxRightTypeEN objvQxRightType = GetObjByRightTypeIdCache(strRightTypeId);
if (objvQxRightType == null) return "";
return objvQxRightType.RightTypeName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strRightTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByRightTypeIdCache(string strRightTypeId)
{
if (string.IsNullOrEmpty(strRightTypeId) == true) return "";
//获取缓存中的对象列表
clsvQxRightTypeEN objvQxRightType = GetObjByRightTypeIdCache(strRightTypeId);
if (objvQxRightType == null) return "";
return objvQxRightType.RightTypeName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxRightTypeEN> GetAllvQxRightTypeObjLstCache()
{
//获取缓存中的对象列表
List<clsvQxRightTypeEN> arrvQxRightTypeObjLstCache = GetObjLstCache(); 
return arrvQxRightTypeObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxRightTypeEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvQxRightTypeEN._CurrTabName);
List<clsvQxRightTypeEN> arrvQxRightTypeObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQxRightTypeObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvQxRightTypeEN._CurrTabName);
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


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2023-08-24
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strRightTypeId)
{
if (strInFldName != convQxRightType.RightTypeId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQxRightType.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQxRightType.AttributeName));
throw new Exception(strMsg);
}
var objvQxRightType = clsvQxRightTypeBL.GetObjByRightTypeIdCache(strRightTypeId);
if (objvQxRightType == null) return "";
return objvQxRightType[strOutFldName].ToString();
}


 #region 有关JSON操作


 #endregion 有关JSON操作


 #region 表操作常用函数

 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount(string strTabName)
{
int intRecCount = clsvQxRightTypeDA.GetRecCount(strTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCond_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond(string strTabName, string strWhereCond)
{
int intRecCount = clsvQxRightTypeDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQxRightTypeDA.GetRecCount();
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond( string strWhereCond)
{
int intRecCount = clsvQxRightTypeDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQxRightTypeCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQxRightTypeEN objvQxRightTypeCond)
{
List<clsvQxRightTypeEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxRightTypeEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxRightType.AttributeName)
{
if (objvQxRightTypeCond.IsUpdated(strFldName) == false) continue;
if (objvQxRightTypeCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxRightTypeCond[strFldName].ToString());
}
else
{
if (objvQxRightTypeCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxRightTypeCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxRightTypeCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxRightTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxRightTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxRightTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxRightTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxRightTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxRightTypeCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxRightTypeCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxRightTypeCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxRightTypeCond[strFldName]));
}
}
}
return arrObjLstSel.Count();
}

 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strTabName, string strFldName, string strWhereCond)
{
 List<string> arrList = clsvQxRightTypeDA.GetFldValue(strTabName, strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strFldName, string strWhereCond)
{
 List<string> arrList = vQxRightTypeDA.GetFldValue(strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValueNoDistinct)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValueNoDistinct(string strFldName, string strWhereCond)
{
 List<string> arrList = vQxRightTypeDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}