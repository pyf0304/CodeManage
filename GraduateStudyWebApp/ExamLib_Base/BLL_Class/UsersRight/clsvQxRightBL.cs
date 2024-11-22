
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQxRightBL
 表名:vQxRight(01120174)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:15
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
public static class  clsvQxRightBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strRightId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxRightEN GetObj(this K_RightId_vQxRight myKey)
{
clsvQxRightEN objvQxRightEN = clsvQxRightBL.vQxRightDA.GetObjByRightId(myKey.Value);
return objvQxRightEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRightEN SetRightId(this clsvQxRightEN objvQxRightEN, string strRightId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRightId, 8, convQxRight.RightId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRightId, 8, convQxRight.RightId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRightEN SetRightName(this clsvQxRightEN objvQxRightEN, string strRightName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRightName, convQxRight.RightName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRightName, 200, convQxRight.RightName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRightEN SetRightTypeId(this clsvQxRightEN objvQxRightEN, string strRightTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRightTypeId, convQxRight.RightTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRightTypeId, 4, convQxRight.RightTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRightTypeId, 4, convQxRight.RightTypeId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRightEN SetRightTypeName(this clsvQxRightEN objvQxRightEN, string strRightTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRightTypeName, 50, convQxRight.RightTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRightEN SetMenuId(this clsvQxRightEN objvQxRightEN, string strMenuId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMenuId, 8, convQxRight.MenuId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRightEN SetFuncModuleId(this clsvQxRightEN objvQxRightEN, string strFuncModuleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convQxRight.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convQxRight.FuncModuleId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRightEN SetFuncModuleName(this clsvQxRightEN objvQxRightEN, string strFuncModuleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convQxRight.FuncModuleName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRightEN SetFuncModuleNameSim(this clsvQxRightEN objvQxRightEN, string strFuncModuleNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleNameSim, 30, convQxRight.FuncModuleNameSim);
}
objvQxRightEN.FuncModuleNameSim = strFuncModuleNameSim; //功能模块简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQxRightEN.dicFldComparisonOp.ContainsKey(convQxRight.FuncModuleNameSim) == false)
{
objvQxRightEN.dicFldComparisonOp.Add(convQxRight.FuncModuleNameSim, strComparisonOp);
}
else
{
objvQxRightEN.dicFldComparisonOp[convQxRight.FuncModuleNameSim] = strComparisonOp;
}
}
return objvQxRightEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRightEN SetOrderNum(this clsvQxRightEN objvQxRightEN, int? intOrderNum, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRightEN SetRightRangeLevelId(this clsvQxRightEN objvQxRightEN, string strRightRangeLevelId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRightRangeLevelId, convQxRight.RightRangeLevelId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRightRangeLevelId, 2, convQxRight.RightRangeLevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRightRangeLevelId, 2, convQxRight.RightRangeLevelId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRightEN SetRightRangeLevelName(this clsvQxRightEN objvQxRightEN, string strRightRangeLevelName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRightRangeLevelName, 30, convQxRight.RightRangeLevelName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRightEN SetUpdDate(this clsvQxRightEN objvQxRightEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQxRight.UpdDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRightEN SetUpdUser(this clsvQxRightEN objvQxRightEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convQxRight.UpdUser);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQxRightEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQxRightEN SetMemo(this clsvQxRightEN objvQxRightEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQxRight.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQxRightENS">源对象</param>
 /// <param name = "objvQxRightENT">目标对象</param>
 public static void CopyTo(this clsvQxRightEN objvQxRightENS, clsvQxRightEN objvQxRightENT)
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
objvQxRightENT.FuncModuleNameSim = objvQxRightENS.FuncModuleNameSim; //功能模块简称
objvQxRightENT.OrderNum = objvQxRightENS.OrderNum; //序号
objvQxRightENT.RightRangeLevelId = objvQxRightENS.RightRangeLevelId; //权限范围等级Id
objvQxRightENT.RightRangeLevelName = objvQxRightENS.RightRangeLevelName; //权限范围等级名称
objvQxRightENT.UpdDate = objvQxRightENS.UpdDate; //修改日期
objvQxRightENT.UpdUser = objvQxRightENS.UpdUser; //修改人
objvQxRightENT.Memo = objvQxRightENS.Memo; //备注
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
 /// <param name = "objvQxRightENS">源对象</param>
 /// <returns>目标对象=>clsvQxRightEN:objvQxRightENT</returns>
 public static clsvQxRightEN CopyTo(this clsvQxRightEN objvQxRightENS)
{
try
{
 clsvQxRightEN objvQxRightENT = new clsvQxRightEN()
{
RightId = objvQxRightENS.RightId, //权限编号
RightName = objvQxRightENS.RightName, //权限名称
RightTypeId = objvQxRightENS.RightTypeId, //权限类型编号
RightTypeName = objvQxRightENS.RightTypeName, //权限类型名
MenuId = objvQxRightENS.MenuId, //菜单编号
FuncModuleId = objvQxRightENS.FuncModuleId, //功能模块Id
FuncModuleName = objvQxRightENS.FuncModuleName, //功能模块名称
FuncModuleNameSim = objvQxRightENS.FuncModuleNameSim, //功能模块简称
OrderNum = objvQxRightENS.OrderNum, //序号
RightRangeLevelId = objvQxRightENS.RightRangeLevelId, //权限范围等级Id
RightRangeLevelName = objvQxRightENS.RightRangeLevelName, //权限范围等级名称
UpdDate = objvQxRightENS.UpdDate, //修改日期
UpdUser = objvQxRightENS.UpdUser, //修改人
Memo = objvQxRightENS.Memo, //备注
};
 return objvQxRightENT;
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
public static void CheckProperty4Condition(this clsvQxRightEN objvQxRightEN)
{
 clsvQxRightBL.vQxRightDA.CheckProperty4Condition(objvQxRightEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQxRightEN objvQxRightCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQxRightCond.IsUpdated(convQxRight.RightId) == true)
{
string strComparisonOpRightId = objvQxRightCond.dicFldComparisonOp[convQxRight.RightId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRight.RightId, objvQxRightCond.RightId, strComparisonOpRightId);
}
if (objvQxRightCond.IsUpdated(convQxRight.RightName) == true)
{
string strComparisonOpRightName = objvQxRightCond.dicFldComparisonOp[convQxRight.RightName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRight.RightName, objvQxRightCond.RightName, strComparisonOpRightName);
}
if (objvQxRightCond.IsUpdated(convQxRight.RightTypeId) == true)
{
string strComparisonOpRightTypeId = objvQxRightCond.dicFldComparisonOp[convQxRight.RightTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRight.RightTypeId, objvQxRightCond.RightTypeId, strComparisonOpRightTypeId);
}
if (objvQxRightCond.IsUpdated(convQxRight.RightTypeName) == true)
{
string strComparisonOpRightTypeName = objvQxRightCond.dicFldComparisonOp[convQxRight.RightTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRight.RightTypeName, objvQxRightCond.RightTypeName, strComparisonOpRightTypeName);
}
if (objvQxRightCond.IsUpdated(convQxRight.MenuId) == true)
{
string strComparisonOpMenuId = objvQxRightCond.dicFldComparisonOp[convQxRight.MenuId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRight.MenuId, objvQxRightCond.MenuId, strComparisonOpMenuId);
}
if (objvQxRightCond.IsUpdated(convQxRight.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objvQxRightCond.dicFldComparisonOp[convQxRight.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRight.FuncModuleId, objvQxRightCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objvQxRightCond.IsUpdated(convQxRight.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvQxRightCond.dicFldComparisonOp[convQxRight.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRight.FuncModuleName, objvQxRightCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvQxRightCond.IsUpdated(convQxRight.FuncModuleNameSim) == true)
{
string strComparisonOpFuncModuleNameSim = objvQxRightCond.dicFldComparisonOp[convQxRight.FuncModuleNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRight.FuncModuleNameSim, objvQxRightCond.FuncModuleNameSim, strComparisonOpFuncModuleNameSim);
}
if (objvQxRightCond.IsUpdated(convQxRight.OrderNum) == true)
{
string strComparisonOpOrderNum = objvQxRightCond.dicFldComparisonOp[convQxRight.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQxRight.OrderNum, objvQxRightCond.OrderNum, strComparisonOpOrderNum);
}
if (objvQxRightCond.IsUpdated(convQxRight.RightRangeLevelId) == true)
{
string strComparisonOpRightRangeLevelId = objvQxRightCond.dicFldComparisonOp[convQxRight.RightRangeLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRight.RightRangeLevelId, objvQxRightCond.RightRangeLevelId, strComparisonOpRightRangeLevelId);
}
if (objvQxRightCond.IsUpdated(convQxRight.RightRangeLevelName) == true)
{
string strComparisonOpRightRangeLevelName = objvQxRightCond.dicFldComparisonOp[convQxRight.RightRangeLevelName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRight.RightRangeLevelName, objvQxRightCond.RightRangeLevelName, strComparisonOpRightRangeLevelName);
}
if (objvQxRightCond.IsUpdated(convQxRight.UpdDate) == true)
{
string strComparisonOpUpdDate = objvQxRightCond.dicFldComparisonOp[convQxRight.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRight.UpdDate, objvQxRightCond.UpdDate, strComparisonOpUpdDate);
}
if (objvQxRightCond.IsUpdated(convQxRight.UpdUser) == true)
{
string strComparisonOpUpdUser = objvQxRightCond.dicFldComparisonOp[convQxRight.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRight.UpdUser, objvQxRightCond.UpdUser, strComparisonOpUpdUser);
}
if (objvQxRightCond.IsUpdated(convQxRight.Memo) == true)
{
string strComparisonOpMemo = objvQxRightCond.dicFldComparisonOp[convQxRight.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQxRight.Memo, objvQxRightCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQxRight
{
public virtual bool UpdRelaTabDate(string strRightId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v用户权限(vQxRight)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQxRightBL
{
public static RelatedActions_vQxRight relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQxRightDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQxRightDA vQxRightDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQxRightDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQxRightBL()
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
if (string.IsNullOrEmpty(clsvQxRightEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQxRightEN._ConnectString);
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
public static DataTable GetDataTable_vQxRight(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQxRightDA.GetDataTable_vQxRight(strWhereCond);
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
objDT = vQxRightDA.GetDataTable(strWhereCond);
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
objDT = vQxRightDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQxRightDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQxRightDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQxRightDA.GetDataTable_Top(objTopPara);
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
objDT = vQxRightDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQxRightDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQxRightDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrRightIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvQxRightEN> GetObjLstByRightIdLst(List<string> arrRightIdLst)
{
List<clsvQxRightEN> arrObjLst = new List<clsvQxRightEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrRightIdLst, true);
 string strWhereCond = string.Format("RightId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRightEN objvQxRightEN = new clsvQxRightEN();
try
{
objvQxRightEN.RightId = objRow[convQxRight.RightId].ToString().Trim(); //权限编号
objvQxRightEN.RightName = objRow[convQxRight.RightName].ToString().Trim(); //权限名称
objvQxRightEN.RightTypeId = objRow[convQxRight.RightTypeId].ToString().Trim(); //权限类型编号
objvQxRightEN.RightTypeName = objRow[convQxRight.RightTypeName] == DBNull.Value ? null : objRow[convQxRight.RightTypeName].ToString().Trim(); //权限类型名
objvQxRightEN.MenuId = objRow[convQxRight.MenuId] == DBNull.Value ? null : objRow[convQxRight.MenuId].ToString().Trim(); //菜单编号
objvQxRightEN.FuncModuleId = objRow[convQxRight.FuncModuleId] == DBNull.Value ? null : objRow[convQxRight.FuncModuleId].ToString().Trim(); //功能模块Id
objvQxRightEN.FuncModuleName = objRow[convQxRight.FuncModuleName] == DBNull.Value ? null : objRow[convQxRight.FuncModuleName].ToString().Trim(); //功能模块名称
objvQxRightEN.FuncModuleNameSim = objRow[convQxRight.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxRight.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvQxRightEN.OrderNum = objRow[convQxRight.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRight.OrderNum].ToString().Trim()); //序号
objvQxRightEN.RightRangeLevelId = objRow[convQxRight.RightRangeLevelId].ToString().Trim(); //权限范围等级Id
objvQxRightEN.RightRangeLevelName = objRow[convQxRight.RightRangeLevelName] == DBNull.Value ? null : objRow[convQxRight.RightRangeLevelName].ToString().Trim(); //权限范围等级名称
objvQxRightEN.UpdDate = objRow[convQxRight.UpdDate] == DBNull.Value ? null : objRow[convQxRight.UpdDate].ToString().Trim(); //修改日期
objvQxRightEN.UpdUser = objRow[convQxRight.UpdUser] == DBNull.Value ? null : objRow[convQxRight.UpdUser].ToString().Trim(); //修改人
objvQxRightEN.Memo = objRow[convQxRight.Memo] == DBNull.Value ? null : objRow[convQxRight.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRightEN.RightId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRightEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrRightIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQxRightEN> GetObjLstByRightIdLstCache(List<string> arrRightIdLst)
{
string strKey = string.Format("{0}", clsvQxRightEN._CurrTabName);
List<clsvQxRightEN> arrvQxRightObjLstCache = GetObjLstCache();
IEnumerable <clsvQxRightEN> arrvQxRightObjLst_Sel =
arrvQxRightObjLstCache
.Where(x => arrRightIdLst.Contains(x.RightId));
return arrvQxRightObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxRightEN> GetObjLst(string strWhereCond)
{
List<clsvQxRightEN> arrObjLst = new List<clsvQxRightEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRightEN objvQxRightEN = new clsvQxRightEN();
try
{
objvQxRightEN.RightId = objRow[convQxRight.RightId].ToString().Trim(); //权限编号
objvQxRightEN.RightName = objRow[convQxRight.RightName].ToString().Trim(); //权限名称
objvQxRightEN.RightTypeId = objRow[convQxRight.RightTypeId].ToString().Trim(); //权限类型编号
objvQxRightEN.RightTypeName = objRow[convQxRight.RightTypeName] == DBNull.Value ? null : objRow[convQxRight.RightTypeName].ToString().Trim(); //权限类型名
objvQxRightEN.MenuId = objRow[convQxRight.MenuId] == DBNull.Value ? null : objRow[convQxRight.MenuId].ToString().Trim(); //菜单编号
objvQxRightEN.FuncModuleId = objRow[convQxRight.FuncModuleId] == DBNull.Value ? null : objRow[convQxRight.FuncModuleId].ToString().Trim(); //功能模块Id
objvQxRightEN.FuncModuleName = objRow[convQxRight.FuncModuleName] == DBNull.Value ? null : objRow[convQxRight.FuncModuleName].ToString().Trim(); //功能模块名称
objvQxRightEN.FuncModuleNameSim = objRow[convQxRight.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxRight.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvQxRightEN.OrderNum = objRow[convQxRight.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRight.OrderNum].ToString().Trim()); //序号
objvQxRightEN.RightRangeLevelId = objRow[convQxRight.RightRangeLevelId].ToString().Trim(); //权限范围等级Id
objvQxRightEN.RightRangeLevelName = objRow[convQxRight.RightRangeLevelName] == DBNull.Value ? null : objRow[convQxRight.RightRangeLevelName].ToString().Trim(); //权限范围等级名称
objvQxRightEN.UpdDate = objRow[convQxRight.UpdDate] == DBNull.Value ? null : objRow[convQxRight.UpdDate].ToString().Trim(); //修改日期
objvQxRightEN.UpdUser = objRow[convQxRight.UpdUser] == DBNull.Value ? null : objRow[convQxRight.UpdUser].ToString().Trim(); //修改人
objvQxRightEN.Memo = objRow[convQxRight.Memo] == DBNull.Value ? null : objRow[convQxRight.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRightEN.RightId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRightEN);
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
public static List<clsvQxRightEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQxRightEN> arrObjLst = new List<clsvQxRightEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRightEN objvQxRightEN = new clsvQxRightEN();
try
{
objvQxRightEN.RightId = objRow[convQxRight.RightId].ToString().Trim(); //权限编号
objvQxRightEN.RightName = objRow[convQxRight.RightName].ToString().Trim(); //权限名称
objvQxRightEN.RightTypeId = objRow[convQxRight.RightTypeId].ToString().Trim(); //权限类型编号
objvQxRightEN.RightTypeName = objRow[convQxRight.RightTypeName] == DBNull.Value ? null : objRow[convQxRight.RightTypeName].ToString().Trim(); //权限类型名
objvQxRightEN.MenuId = objRow[convQxRight.MenuId] == DBNull.Value ? null : objRow[convQxRight.MenuId].ToString().Trim(); //菜单编号
objvQxRightEN.FuncModuleId = objRow[convQxRight.FuncModuleId] == DBNull.Value ? null : objRow[convQxRight.FuncModuleId].ToString().Trim(); //功能模块Id
objvQxRightEN.FuncModuleName = objRow[convQxRight.FuncModuleName] == DBNull.Value ? null : objRow[convQxRight.FuncModuleName].ToString().Trim(); //功能模块名称
objvQxRightEN.FuncModuleNameSim = objRow[convQxRight.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxRight.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvQxRightEN.OrderNum = objRow[convQxRight.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRight.OrderNum].ToString().Trim()); //序号
objvQxRightEN.RightRangeLevelId = objRow[convQxRight.RightRangeLevelId].ToString().Trim(); //权限范围等级Id
objvQxRightEN.RightRangeLevelName = objRow[convQxRight.RightRangeLevelName] == DBNull.Value ? null : objRow[convQxRight.RightRangeLevelName].ToString().Trim(); //权限范围等级名称
objvQxRightEN.UpdDate = objRow[convQxRight.UpdDate] == DBNull.Value ? null : objRow[convQxRight.UpdDate].ToString().Trim(); //修改日期
objvQxRightEN.UpdUser = objRow[convQxRight.UpdUser] == DBNull.Value ? null : objRow[convQxRight.UpdUser].ToString().Trim(); //修改人
objvQxRightEN.Memo = objRow[convQxRight.Memo] == DBNull.Value ? null : objRow[convQxRight.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRightEN.RightId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRightEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQxRightCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQxRightEN> GetSubObjLstCache(clsvQxRightEN objvQxRightCond)
{
List<clsvQxRightEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxRightEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxRight.AttributeName)
{
if (objvQxRightCond.IsUpdated(strFldName) == false) continue;
if (objvQxRightCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxRightCond[strFldName].ToString());
}
else
{
if (objvQxRightCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxRightCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxRightCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxRightCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxRightCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxRightCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxRightCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxRightCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxRightCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxRightCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxRightCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxRightCond[strFldName]));
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
public static List<clsvQxRightEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQxRightEN> arrObjLst = new List<clsvQxRightEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRightEN objvQxRightEN = new clsvQxRightEN();
try
{
objvQxRightEN.RightId = objRow[convQxRight.RightId].ToString().Trim(); //权限编号
objvQxRightEN.RightName = objRow[convQxRight.RightName].ToString().Trim(); //权限名称
objvQxRightEN.RightTypeId = objRow[convQxRight.RightTypeId].ToString().Trim(); //权限类型编号
objvQxRightEN.RightTypeName = objRow[convQxRight.RightTypeName] == DBNull.Value ? null : objRow[convQxRight.RightTypeName].ToString().Trim(); //权限类型名
objvQxRightEN.MenuId = objRow[convQxRight.MenuId] == DBNull.Value ? null : objRow[convQxRight.MenuId].ToString().Trim(); //菜单编号
objvQxRightEN.FuncModuleId = objRow[convQxRight.FuncModuleId] == DBNull.Value ? null : objRow[convQxRight.FuncModuleId].ToString().Trim(); //功能模块Id
objvQxRightEN.FuncModuleName = objRow[convQxRight.FuncModuleName] == DBNull.Value ? null : objRow[convQxRight.FuncModuleName].ToString().Trim(); //功能模块名称
objvQxRightEN.FuncModuleNameSim = objRow[convQxRight.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxRight.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvQxRightEN.OrderNum = objRow[convQxRight.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRight.OrderNum].ToString().Trim()); //序号
objvQxRightEN.RightRangeLevelId = objRow[convQxRight.RightRangeLevelId].ToString().Trim(); //权限范围等级Id
objvQxRightEN.RightRangeLevelName = objRow[convQxRight.RightRangeLevelName] == DBNull.Value ? null : objRow[convQxRight.RightRangeLevelName].ToString().Trim(); //权限范围等级名称
objvQxRightEN.UpdDate = objRow[convQxRight.UpdDate] == DBNull.Value ? null : objRow[convQxRight.UpdDate].ToString().Trim(); //修改日期
objvQxRightEN.UpdUser = objRow[convQxRight.UpdUser] == DBNull.Value ? null : objRow[convQxRight.UpdUser].ToString().Trim(); //修改人
objvQxRightEN.Memo = objRow[convQxRight.Memo] == DBNull.Value ? null : objRow[convQxRight.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRightEN.RightId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRightEN);
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
public static List<clsvQxRightEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQxRightEN> arrObjLst = new List<clsvQxRightEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRightEN objvQxRightEN = new clsvQxRightEN();
try
{
objvQxRightEN.RightId = objRow[convQxRight.RightId].ToString().Trim(); //权限编号
objvQxRightEN.RightName = objRow[convQxRight.RightName].ToString().Trim(); //权限名称
objvQxRightEN.RightTypeId = objRow[convQxRight.RightTypeId].ToString().Trim(); //权限类型编号
objvQxRightEN.RightTypeName = objRow[convQxRight.RightTypeName] == DBNull.Value ? null : objRow[convQxRight.RightTypeName].ToString().Trim(); //权限类型名
objvQxRightEN.MenuId = objRow[convQxRight.MenuId] == DBNull.Value ? null : objRow[convQxRight.MenuId].ToString().Trim(); //菜单编号
objvQxRightEN.FuncModuleId = objRow[convQxRight.FuncModuleId] == DBNull.Value ? null : objRow[convQxRight.FuncModuleId].ToString().Trim(); //功能模块Id
objvQxRightEN.FuncModuleName = objRow[convQxRight.FuncModuleName] == DBNull.Value ? null : objRow[convQxRight.FuncModuleName].ToString().Trim(); //功能模块名称
objvQxRightEN.FuncModuleNameSim = objRow[convQxRight.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxRight.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvQxRightEN.OrderNum = objRow[convQxRight.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRight.OrderNum].ToString().Trim()); //序号
objvQxRightEN.RightRangeLevelId = objRow[convQxRight.RightRangeLevelId].ToString().Trim(); //权限范围等级Id
objvQxRightEN.RightRangeLevelName = objRow[convQxRight.RightRangeLevelName] == DBNull.Value ? null : objRow[convQxRight.RightRangeLevelName].ToString().Trim(); //权限范围等级名称
objvQxRightEN.UpdDate = objRow[convQxRight.UpdDate] == DBNull.Value ? null : objRow[convQxRight.UpdDate].ToString().Trim(); //修改日期
objvQxRightEN.UpdUser = objRow[convQxRight.UpdUser] == DBNull.Value ? null : objRow[convQxRight.UpdUser].ToString().Trim(); //修改人
objvQxRightEN.Memo = objRow[convQxRight.Memo] == DBNull.Value ? null : objRow[convQxRight.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRightEN.RightId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRightEN);
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
List<clsvQxRightEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQxRightEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxRightEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQxRightEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQxRightEN> arrObjLst = new List<clsvQxRightEN>(); 
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
	clsvQxRightEN objvQxRightEN = new clsvQxRightEN();
try
{
objvQxRightEN.RightId = objRow[convQxRight.RightId].ToString().Trim(); //权限编号
objvQxRightEN.RightName = objRow[convQxRight.RightName].ToString().Trim(); //权限名称
objvQxRightEN.RightTypeId = objRow[convQxRight.RightTypeId].ToString().Trim(); //权限类型编号
objvQxRightEN.RightTypeName = objRow[convQxRight.RightTypeName] == DBNull.Value ? null : objRow[convQxRight.RightTypeName].ToString().Trim(); //权限类型名
objvQxRightEN.MenuId = objRow[convQxRight.MenuId] == DBNull.Value ? null : objRow[convQxRight.MenuId].ToString().Trim(); //菜单编号
objvQxRightEN.FuncModuleId = objRow[convQxRight.FuncModuleId] == DBNull.Value ? null : objRow[convQxRight.FuncModuleId].ToString().Trim(); //功能模块Id
objvQxRightEN.FuncModuleName = objRow[convQxRight.FuncModuleName] == DBNull.Value ? null : objRow[convQxRight.FuncModuleName].ToString().Trim(); //功能模块名称
objvQxRightEN.FuncModuleNameSim = objRow[convQxRight.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxRight.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvQxRightEN.OrderNum = objRow[convQxRight.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRight.OrderNum].ToString().Trim()); //序号
objvQxRightEN.RightRangeLevelId = objRow[convQxRight.RightRangeLevelId].ToString().Trim(); //权限范围等级Id
objvQxRightEN.RightRangeLevelName = objRow[convQxRight.RightRangeLevelName] == DBNull.Value ? null : objRow[convQxRight.RightRangeLevelName].ToString().Trim(); //权限范围等级名称
objvQxRightEN.UpdDate = objRow[convQxRight.UpdDate] == DBNull.Value ? null : objRow[convQxRight.UpdDate].ToString().Trim(); //修改日期
objvQxRightEN.UpdUser = objRow[convQxRight.UpdUser] == DBNull.Value ? null : objRow[convQxRight.UpdUser].ToString().Trim(); //修改人
objvQxRightEN.Memo = objRow[convQxRight.Memo] == DBNull.Value ? null : objRow[convQxRight.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRightEN.RightId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRightEN);
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
public static List<clsvQxRightEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQxRightEN> arrObjLst = new List<clsvQxRightEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRightEN objvQxRightEN = new clsvQxRightEN();
try
{
objvQxRightEN.RightId = objRow[convQxRight.RightId].ToString().Trim(); //权限编号
objvQxRightEN.RightName = objRow[convQxRight.RightName].ToString().Trim(); //权限名称
objvQxRightEN.RightTypeId = objRow[convQxRight.RightTypeId].ToString().Trim(); //权限类型编号
objvQxRightEN.RightTypeName = objRow[convQxRight.RightTypeName] == DBNull.Value ? null : objRow[convQxRight.RightTypeName].ToString().Trim(); //权限类型名
objvQxRightEN.MenuId = objRow[convQxRight.MenuId] == DBNull.Value ? null : objRow[convQxRight.MenuId].ToString().Trim(); //菜单编号
objvQxRightEN.FuncModuleId = objRow[convQxRight.FuncModuleId] == DBNull.Value ? null : objRow[convQxRight.FuncModuleId].ToString().Trim(); //功能模块Id
objvQxRightEN.FuncModuleName = objRow[convQxRight.FuncModuleName] == DBNull.Value ? null : objRow[convQxRight.FuncModuleName].ToString().Trim(); //功能模块名称
objvQxRightEN.FuncModuleNameSim = objRow[convQxRight.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxRight.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvQxRightEN.OrderNum = objRow[convQxRight.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRight.OrderNum].ToString().Trim()); //序号
objvQxRightEN.RightRangeLevelId = objRow[convQxRight.RightRangeLevelId].ToString().Trim(); //权限范围等级Id
objvQxRightEN.RightRangeLevelName = objRow[convQxRight.RightRangeLevelName] == DBNull.Value ? null : objRow[convQxRight.RightRangeLevelName].ToString().Trim(); //权限范围等级名称
objvQxRightEN.UpdDate = objRow[convQxRight.UpdDate] == DBNull.Value ? null : objRow[convQxRight.UpdDate].ToString().Trim(); //修改日期
objvQxRightEN.UpdUser = objRow[convQxRight.UpdUser] == DBNull.Value ? null : objRow[convQxRight.UpdUser].ToString().Trim(); //修改人
objvQxRightEN.Memo = objRow[convQxRight.Memo] == DBNull.Value ? null : objRow[convQxRight.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRightEN.RightId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRightEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQxRightEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQxRightEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQxRightEN> arrObjLst = new List<clsvQxRightEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRightEN objvQxRightEN = new clsvQxRightEN();
try
{
objvQxRightEN.RightId = objRow[convQxRight.RightId].ToString().Trim(); //权限编号
objvQxRightEN.RightName = objRow[convQxRight.RightName].ToString().Trim(); //权限名称
objvQxRightEN.RightTypeId = objRow[convQxRight.RightTypeId].ToString().Trim(); //权限类型编号
objvQxRightEN.RightTypeName = objRow[convQxRight.RightTypeName] == DBNull.Value ? null : objRow[convQxRight.RightTypeName].ToString().Trim(); //权限类型名
objvQxRightEN.MenuId = objRow[convQxRight.MenuId] == DBNull.Value ? null : objRow[convQxRight.MenuId].ToString().Trim(); //菜单编号
objvQxRightEN.FuncModuleId = objRow[convQxRight.FuncModuleId] == DBNull.Value ? null : objRow[convQxRight.FuncModuleId].ToString().Trim(); //功能模块Id
objvQxRightEN.FuncModuleName = objRow[convQxRight.FuncModuleName] == DBNull.Value ? null : objRow[convQxRight.FuncModuleName].ToString().Trim(); //功能模块名称
objvQxRightEN.FuncModuleNameSim = objRow[convQxRight.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxRight.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvQxRightEN.OrderNum = objRow[convQxRight.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRight.OrderNum].ToString().Trim()); //序号
objvQxRightEN.RightRangeLevelId = objRow[convQxRight.RightRangeLevelId].ToString().Trim(); //权限范围等级Id
objvQxRightEN.RightRangeLevelName = objRow[convQxRight.RightRangeLevelName] == DBNull.Value ? null : objRow[convQxRight.RightRangeLevelName].ToString().Trim(); //权限范围等级名称
objvQxRightEN.UpdDate = objRow[convQxRight.UpdDate] == DBNull.Value ? null : objRow[convQxRight.UpdDate].ToString().Trim(); //修改日期
objvQxRightEN.UpdUser = objRow[convQxRight.UpdUser] == DBNull.Value ? null : objRow[convQxRight.UpdUser].ToString().Trim(); //修改人
objvQxRightEN.Memo = objRow[convQxRight.Memo] == DBNull.Value ? null : objRow[convQxRight.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRightEN.RightId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRightEN);
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
public static List<clsvQxRightEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQxRightEN> arrObjLst = new List<clsvQxRightEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRightEN objvQxRightEN = new clsvQxRightEN();
try
{
objvQxRightEN.RightId = objRow[convQxRight.RightId].ToString().Trim(); //权限编号
objvQxRightEN.RightName = objRow[convQxRight.RightName].ToString().Trim(); //权限名称
objvQxRightEN.RightTypeId = objRow[convQxRight.RightTypeId].ToString().Trim(); //权限类型编号
objvQxRightEN.RightTypeName = objRow[convQxRight.RightTypeName] == DBNull.Value ? null : objRow[convQxRight.RightTypeName].ToString().Trim(); //权限类型名
objvQxRightEN.MenuId = objRow[convQxRight.MenuId] == DBNull.Value ? null : objRow[convQxRight.MenuId].ToString().Trim(); //菜单编号
objvQxRightEN.FuncModuleId = objRow[convQxRight.FuncModuleId] == DBNull.Value ? null : objRow[convQxRight.FuncModuleId].ToString().Trim(); //功能模块Id
objvQxRightEN.FuncModuleName = objRow[convQxRight.FuncModuleName] == DBNull.Value ? null : objRow[convQxRight.FuncModuleName].ToString().Trim(); //功能模块名称
objvQxRightEN.FuncModuleNameSim = objRow[convQxRight.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxRight.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvQxRightEN.OrderNum = objRow[convQxRight.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRight.OrderNum].ToString().Trim()); //序号
objvQxRightEN.RightRangeLevelId = objRow[convQxRight.RightRangeLevelId].ToString().Trim(); //权限范围等级Id
objvQxRightEN.RightRangeLevelName = objRow[convQxRight.RightRangeLevelName] == DBNull.Value ? null : objRow[convQxRight.RightRangeLevelName].ToString().Trim(); //权限范围等级名称
objvQxRightEN.UpdDate = objRow[convQxRight.UpdDate] == DBNull.Value ? null : objRow[convQxRight.UpdDate].ToString().Trim(); //修改日期
objvQxRightEN.UpdUser = objRow[convQxRight.UpdUser] == DBNull.Value ? null : objRow[convQxRight.UpdUser].ToString().Trim(); //修改人
objvQxRightEN.Memo = objRow[convQxRight.Memo] == DBNull.Value ? null : objRow[convQxRight.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRightEN.RightId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRightEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQxRightEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQxRightEN> arrObjLst = new List<clsvQxRightEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQxRightEN objvQxRightEN = new clsvQxRightEN();
try
{
objvQxRightEN.RightId = objRow[convQxRight.RightId].ToString().Trim(); //权限编号
objvQxRightEN.RightName = objRow[convQxRight.RightName].ToString().Trim(); //权限名称
objvQxRightEN.RightTypeId = objRow[convQxRight.RightTypeId].ToString().Trim(); //权限类型编号
objvQxRightEN.RightTypeName = objRow[convQxRight.RightTypeName] == DBNull.Value ? null : objRow[convQxRight.RightTypeName].ToString().Trim(); //权限类型名
objvQxRightEN.MenuId = objRow[convQxRight.MenuId] == DBNull.Value ? null : objRow[convQxRight.MenuId].ToString().Trim(); //菜单编号
objvQxRightEN.FuncModuleId = objRow[convQxRight.FuncModuleId] == DBNull.Value ? null : objRow[convQxRight.FuncModuleId].ToString().Trim(); //功能模块Id
objvQxRightEN.FuncModuleName = objRow[convQxRight.FuncModuleName] == DBNull.Value ? null : objRow[convQxRight.FuncModuleName].ToString().Trim(); //功能模块名称
objvQxRightEN.FuncModuleNameSim = objRow[convQxRight.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQxRight.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvQxRightEN.OrderNum = objRow[convQxRight.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQxRight.OrderNum].ToString().Trim()); //序号
objvQxRightEN.RightRangeLevelId = objRow[convQxRight.RightRangeLevelId].ToString().Trim(); //权限范围等级Id
objvQxRightEN.RightRangeLevelName = objRow[convQxRight.RightRangeLevelName] == DBNull.Value ? null : objRow[convQxRight.RightRangeLevelName].ToString().Trim(); //权限范围等级名称
objvQxRightEN.UpdDate = objRow[convQxRight.UpdDate] == DBNull.Value ? null : objRow[convQxRight.UpdDate].ToString().Trim(); //修改日期
objvQxRightEN.UpdUser = objRow[convQxRight.UpdUser] == DBNull.Value ? null : objRow[convQxRight.UpdUser].ToString().Trim(); //修改人
objvQxRightEN.Memo = objRow[convQxRight.Memo] == DBNull.Value ? null : objRow[convQxRight.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQxRightEN.RightId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQxRightEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQxRightEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQxRight(ref clsvQxRightEN objvQxRightEN)
{
bool bolResult = vQxRightDA.GetvQxRight(ref objvQxRightEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strRightId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQxRightEN GetObjByRightId(string strRightId)
{
if (strRightId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strRightId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strRightId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strRightId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvQxRightEN objvQxRightEN = vQxRightDA.GetObjByRightId(strRightId);
return objvQxRightEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQxRightEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQxRightEN objvQxRightEN = vQxRightDA.GetFirstObj(strWhereCond);
 return objvQxRightEN;
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
public static clsvQxRightEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQxRightEN objvQxRightEN = vQxRightDA.GetObjByDataRow(objRow);
 return objvQxRightEN;
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
public static clsvQxRightEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQxRightEN objvQxRightEN = vQxRightDA.GetObjByDataRow(objRow);
 return objvQxRightEN;
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
 /// <param name = "strRightId">所给的关键字</param>
 /// <param name = "lstvQxRightObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxRightEN GetObjByRightIdFromList(string strRightId, List<clsvQxRightEN> lstvQxRightObjLst)
{
foreach (clsvQxRightEN objvQxRightEN in lstvQxRightObjLst)
{
if (objvQxRightEN.RightId == strRightId)
{
return objvQxRightEN;
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
 string strRightId;
 try
 {
 strRightId = new clsvQxRightDA().GetFirstID(strWhereCond);
 return strRightId;
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
 arrList = vQxRightDA.GetID(strWhereCond);
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
bool bolIsExist = vQxRightDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strRightId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strRightId)
{
if (string.IsNullOrEmpty(strRightId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strRightId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vQxRightDA.IsExist(strRightId);
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
 bolIsExist = clsvQxRightDA.IsExistTable();
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
 bolIsExist = vQxRightDA.IsExistTable(strTabName);
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
objvQxRightENT.FuncModuleNameSim = objvQxRightENS.FuncModuleNameSim; //功能模块简称
objvQxRightENT.OrderNum = objvQxRightENS.OrderNum; //序号
objvQxRightENT.RightRangeLevelId = objvQxRightENS.RightRangeLevelId; //权限范围等级Id
objvQxRightENT.RightRangeLevelName = objvQxRightENS.RightRangeLevelName; //权限范围等级名称
objvQxRightENT.UpdDate = objvQxRightENS.UpdDate; //修改日期
objvQxRightENT.UpdUser = objvQxRightENS.UpdUser; //修改人
objvQxRightENT.Memo = objvQxRightENS.Memo; //备注
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
 /// <param name = "objvQxRightEN">源简化对象</param>
 public static void SetUpdFlag(clsvQxRightEN objvQxRightEN)
{
try
{
objvQxRightEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQxRightEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQxRight.RightId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRightEN.RightId = objvQxRightEN.RightId; //权限编号
}
if (arrFldSet.Contains(convQxRight.RightName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRightEN.RightName = objvQxRightEN.RightName; //权限名称
}
if (arrFldSet.Contains(convQxRight.RightTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRightEN.RightTypeId = objvQxRightEN.RightTypeId; //权限类型编号
}
if (arrFldSet.Contains(convQxRight.RightTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRightEN.RightTypeName = objvQxRightEN.RightTypeName == "[null]" ? null :  objvQxRightEN.RightTypeName; //权限类型名
}
if (arrFldSet.Contains(convQxRight.MenuId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRightEN.MenuId = objvQxRightEN.MenuId == "[null]" ? null :  objvQxRightEN.MenuId; //菜单编号
}
if (arrFldSet.Contains(convQxRight.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRightEN.FuncModuleId = objvQxRightEN.FuncModuleId == "[null]" ? null :  objvQxRightEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(convQxRight.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRightEN.FuncModuleName = objvQxRightEN.FuncModuleName == "[null]" ? null :  objvQxRightEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convQxRight.FuncModuleNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRightEN.FuncModuleNameSim = objvQxRightEN.FuncModuleNameSim == "[null]" ? null :  objvQxRightEN.FuncModuleNameSim; //功能模块简称
}
if (arrFldSet.Contains(convQxRight.OrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRightEN.OrderNum = objvQxRightEN.OrderNum; //序号
}
if (arrFldSet.Contains(convQxRight.RightRangeLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRightEN.RightRangeLevelId = objvQxRightEN.RightRangeLevelId; //权限范围等级Id
}
if (arrFldSet.Contains(convQxRight.RightRangeLevelName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRightEN.RightRangeLevelName = objvQxRightEN.RightRangeLevelName == "[null]" ? null :  objvQxRightEN.RightRangeLevelName; //权限范围等级名称
}
if (arrFldSet.Contains(convQxRight.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRightEN.UpdDate = objvQxRightEN.UpdDate == "[null]" ? null :  objvQxRightEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convQxRight.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRightEN.UpdUser = objvQxRightEN.UpdUser == "[null]" ? null :  objvQxRightEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convQxRight.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQxRightEN.Memo = objvQxRightEN.Memo == "[null]" ? null :  objvQxRightEN.Memo; //备注
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
 /// <param name = "objvQxRightEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQxRightEN objvQxRightEN)
{
try
{
if (objvQxRightEN.RightTypeName == "[null]") objvQxRightEN.RightTypeName = null; //权限类型名
if (objvQxRightEN.MenuId == "[null]") objvQxRightEN.MenuId = null; //菜单编号
if (objvQxRightEN.FuncModuleId == "[null]") objvQxRightEN.FuncModuleId = null; //功能模块Id
if (objvQxRightEN.FuncModuleName == "[null]") objvQxRightEN.FuncModuleName = null; //功能模块名称
if (objvQxRightEN.FuncModuleNameSim == "[null]") objvQxRightEN.FuncModuleNameSim = null; //功能模块简称
if (objvQxRightEN.RightRangeLevelName == "[null]") objvQxRightEN.RightRangeLevelName = null; //权限范围等级名称
if (objvQxRightEN.UpdDate == "[null]") objvQxRightEN.UpdDate = null; //修改日期
if (objvQxRightEN.UpdUser == "[null]") objvQxRightEN.UpdUser = null; //修改人
if (objvQxRightEN.Memo == "[null]") objvQxRightEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvQxRightEN objvQxRightEN)
{
 vQxRightDA.CheckProperty4Condition(objvQxRightEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_RightId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convQxRight.RightId); 
List<clsvQxRightEN> arrObjLst = clsvQxRightBL.GetObjLst(strCondition);
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
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_RightId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v用户权限]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convQxRight.RightId); 
IEnumerable<clsvQxRightEN> arrObjLst = clsvQxRightBL.GetObjLst(strCondition);
objDDL.DataValueField = convQxRight.RightId;
objDDL.DataTextField = convQxRight.RightName;
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
public static void BindDdl_RightIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v用户权限]...","0");
List<clsvQxRightEN> arrvQxRightObjLst = GetAllvQxRightObjLstCache(); 
objDDL.DataValueField = convQxRight.RightId;
objDDL.DataTextField = convQxRight.RightName;
objDDL.DataSource = arrvQxRightObjLst;
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
if (clsQxRightBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxRightBL没有刷新缓存机制(clsQxRightBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxRightRangeLevelBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxRightRangeLevelBL没有刷新缓存机制(clsQxRightRangeLevelBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQxRightTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQxRightTypeBL没有刷新缓存机制(clsQxRightTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by RightId");
//if (arrvQxRightObjLstCache == null)
//{
//arrvQxRightObjLstCache = vQxRightDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strRightId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQxRightEN GetObjByRightIdCache(string strRightId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvQxRightEN._CurrTabName);
List<clsvQxRightEN> arrvQxRightObjLstCache = GetObjLstCache();
IEnumerable <clsvQxRightEN> arrvQxRightObjLst_Sel =
arrvQxRightObjLstCache
.Where(x=> x.RightId == strRightId 
);
if (arrvQxRightObjLst_Sel.Count() == 0)
{
   clsvQxRightEN obj = clsvQxRightBL.GetObjByRightId(strRightId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvQxRightObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strRightId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetRightNameByRightIdCache(string strRightId)
{
if (string.IsNullOrEmpty(strRightId) == true) return "";
//获取缓存中的对象列表
clsvQxRightEN objvQxRight = GetObjByRightIdCache(strRightId);
if (objvQxRight == null) return "";
return objvQxRight.RightName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strRightId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByRightIdCache(string strRightId)
{
if (string.IsNullOrEmpty(strRightId) == true) return "";
//获取缓存中的对象列表
clsvQxRightEN objvQxRight = GetObjByRightIdCache(strRightId);
if (objvQxRight == null) return "";
return objvQxRight.RightName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxRightEN> GetAllvQxRightObjLstCache()
{
//获取缓存中的对象列表
List<clsvQxRightEN> arrvQxRightObjLstCache = GetObjLstCache(); 
return arrvQxRightObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQxRightEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvQxRightEN._CurrTabName);
List<clsvQxRightEN> arrvQxRightObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQxRightObjLstCache;
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
string strKey = string.Format("{0}", clsvQxRightEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, string strRightId)
{
if (strInFldName != convQxRight.RightId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQxRight.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQxRight.AttributeName));
throw new Exception(strMsg);
}
var objvQxRight = clsvQxRightBL.GetObjByRightIdCache(strRightId);
if (objvQxRight == null) return "";
return objvQxRight[strOutFldName].ToString();
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
int intRecCount = clsvQxRightDA.GetRecCount(strTabName);
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
int intRecCount = clsvQxRightDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQxRightDA.GetRecCount();
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
int intRecCount = clsvQxRightDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQxRightCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQxRightEN objvQxRightCond)
{
List<clsvQxRightEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQxRightEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQxRight.AttributeName)
{
if (objvQxRightCond.IsUpdated(strFldName) == false) continue;
if (objvQxRightCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxRightCond[strFldName].ToString());
}
else
{
if (objvQxRightCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQxRightCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQxRightCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQxRightCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQxRightCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQxRightCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQxRightCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQxRightCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQxRightCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQxRightCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQxRightCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQxRightCond[strFldName]));
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
 List<string> arrList = clsvQxRightDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQxRightDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQxRightDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}