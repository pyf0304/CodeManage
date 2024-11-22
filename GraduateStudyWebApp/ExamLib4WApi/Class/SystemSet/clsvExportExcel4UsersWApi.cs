
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvExportExcel4UsersWApi
 表名:vExportExcel4Users(01120118)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:37:48
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
public static class clsvExportExcel4UsersWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvExportExcel4UsersEN SetmId(this clsvExportExcel4UsersEN objvExportExcel4UsersEN, long lngmId, string strComparisonOp="")
	{
objvExportExcel4UsersEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(convExportExcel4Users.mId) == false)
{
objvExportExcel4UsersEN.dicFldComparisonOp.Add(convExportExcel4Users.mId, strComparisonOp);
}
else
{
objvExportExcel4UsersEN.dicFldComparisonOp[convExportExcel4Users.mId] = strComparisonOp;
}
}
return objvExportExcel4UsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvExportExcel4UsersEN Setid_ExportExcel4Users(this clsvExportExcel4UsersEN objvExportExcel4UsersEN, string strid_ExportExcel4Users, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_ExportExcel4Users, 8, convExportExcel4Users.id_ExportExcel4Users);
clsCheckSql.CheckFieldForeignKey(strid_ExportExcel4Users, 8, convExportExcel4Users.id_ExportExcel4Users);
objvExportExcel4UsersEN.id_ExportExcel4Users = strid_ExportExcel4Users; //导出Excel用户字段流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(convExportExcel4Users.id_ExportExcel4Users) == false)
{
objvExportExcel4UsersEN.dicFldComparisonOp.Add(convExportExcel4Users.id_ExportExcel4Users, strComparisonOp);
}
else
{
objvExportExcel4UsersEN.dicFldComparisonOp[convExportExcel4Users.id_ExportExcel4Users] = strComparisonOp;
}
}
return objvExportExcel4UsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvExportExcel4UsersEN SetViewName(this clsvExportExcel4UsersEN objvExportExcel4UsersEN, string strViewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strViewName, 50, convExportExcel4Users.ViewName);
objvExportExcel4UsersEN.ViewName = strViewName; //界面名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(convExportExcel4Users.ViewName) == false)
{
objvExportExcel4UsersEN.dicFldComparisonOp.Add(convExportExcel4Users.ViewName, strComparisonOp);
}
else
{
objvExportExcel4UsersEN.dicFldComparisonOp[convExportExcel4Users.ViewName] = strComparisonOp;
}
}
return objvExportExcel4UsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvExportExcel4UsersEN SetTabName(this clsvExportExcel4UsersEN objvExportExcel4UsersEN, string strTabName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTabName, 50, convExportExcel4Users.TabName);
objvExportExcel4UsersEN.TabName = strTabName; //表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(convExportExcel4Users.TabName) == false)
{
objvExportExcel4UsersEN.dicFldComparisonOp.Add(convExportExcel4Users.TabName, strComparisonOp);
}
else
{
objvExportExcel4UsersEN.dicFldComparisonOp[convExportExcel4Users.TabName] = strComparisonOp;
}
}
return objvExportExcel4UsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvExportExcel4UsersEN SetUserId(this clsvExportExcel4UsersEN objvExportExcel4UsersEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convExportExcel4Users.UserId);
clsCheckSql.CheckFieldLen(strUserId, 20, convExportExcel4Users.UserId);
objvExportExcel4UsersEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(convExportExcel4Users.UserId) == false)
{
objvExportExcel4UsersEN.dicFldComparisonOp.Add(convExportExcel4Users.UserId, strComparisonOp);
}
else
{
objvExportExcel4UsersEN.dicFldComparisonOp[convExportExcel4Users.UserId] = strComparisonOp;
}
}
return objvExportExcel4UsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvExportExcel4UsersEN SetUserName(this clsvExportExcel4UsersEN objvExportExcel4UsersEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserName, convExportExcel4Users.UserName);
clsCheckSql.CheckFieldLen(strUserName, 50, convExportExcel4Users.UserName);
objvExportExcel4UsersEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(convExportExcel4Users.UserName) == false)
{
objvExportExcel4UsersEN.dicFldComparisonOp.Add(convExportExcel4Users.UserName, strComparisonOp);
}
else
{
objvExportExcel4UsersEN.dicFldComparisonOp[convExportExcel4Users.UserName] = strComparisonOp;
}
}
return objvExportExcel4UsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvExportExcel4UsersEN SetIsDefaultUser(this clsvExportExcel4UsersEN objvExportExcel4UsersEN, bool bolIsDefaultUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsDefaultUser, convExportExcel4Users.IsDefaultUser);
objvExportExcel4UsersEN.IsDefaultUser = bolIsDefaultUser; //是否默认用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(convExportExcel4Users.IsDefaultUser) == false)
{
objvExportExcel4UsersEN.dicFldComparisonOp.Add(convExportExcel4Users.IsDefaultUser, strComparisonOp);
}
else
{
objvExportExcel4UsersEN.dicFldComparisonOp[convExportExcel4Users.IsDefaultUser] = strComparisonOp;
}
}
return objvExportExcel4UsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvExportExcel4UsersEN SetExportFileName(this clsvExportExcel4UsersEN objvExportExcel4UsersEN, string strExportFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strExportFileName, convExportExcel4Users.ExportFileName);
clsCheckSql.CheckFieldLen(strExportFileName, 100, convExportExcel4Users.ExportFileName);
objvExportExcel4UsersEN.ExportFileName = strExportFileName; //导出文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(convExportExcel4Users.ExportFileName) == false)
{
objvExportExcel4UsersEN.dicFldComparisonOp.Add(convExportExcel4Users.ExportFileName, strComparisonOp);
}
else
{
objvExportExcel4UsersEN.dicFldComparisonOp[convExportExcel4Users.ExportFileName] = strComparisonOp;
}
}
return objvExportExcel4UsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvExportExcel4UsersEN SetFieldName(this clsvExportExcel4UsersEN objvExportExcel4UsersEN, string strFieldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFieldName, 50, convExportExcel4Users.FieldName);
objvExportExcel4UsersEN.FieldName = strFieldName; //字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(convExportExcel4Users.FieldName) == false)
{
objvExportExcel4UsersEN.dicFldComparisonOp.Add(convExportExcel4Users.FieldName, strComparisonOp);
}
else
{
objvExportExcel4UsersEN.dicFldComparisonOp[convExportExcel4Users.FieldName] = strComparisonOp;
}
}
return objvExportExcel4UsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvExportExcel4UsersEN SetFieldCnName(this clsvExportExcel4UsersEN objvExportExcel4UsersEN, string strFieldCnName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFieldCnName, convExportExcel4Users.FieldCnName);
clsCheckSql.CheckFieldLen(strFieldCnName, 50, convExportExcel4Users.FieldCnName);
objvExportExcel4UsersEN.FieldCnName = strFieldCnName; //字段中文名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(convExportExcel4Users.FieldCnName) == false)
{
objvExportExcel4UsersEN.dicFldComparisonOp.Add(convExportExcel4Users.FieldCnName, strComparisonOp);
}
else
{
objvExportExcel4UsersEN.dicFldComparisonOp[convExportExcel4Users.FieldCnName] = strComparisonOp;
}
}
return objvExportExcel4UsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvExportExcel4UsersEN SetIsExport(this clsvExportExcel4UsersEN objvExportExcel4UsersEN, bool bolIsExport, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsExport, convExportExcel4Users.IsExport);
objvExportExcel4UsersEN.IsExport = bolIsExport; //是否导出
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(convExportExcel4Users.IsExport) == false)
{
objvExportExcel4UsersEN.dicFldComparisonOp.Add(convExportExcel4Users.IsExport, strComparisonOp);
}
else
{
objvExportExcel4UsersEN.dicFldComparisonOp[convExportExcel4Users.IsExport] = strComparisonOp;
}
}
return objvExportExcel4UsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvExportExcel4UsersEN SetOrderNum(this clsvExportExcel4UsersEN objvExportExcel4UsersEN, int intOrderNum, string strComparisonOp="")
	{
objvExportExcel4UsersEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(convExportExcel4Users.OrderNum) == false)
{
objvExportExcel4UsersEN.dicFldComparisonOp.Add(convExportExcel4Users.OrderNum, strComparisonOp);
}
else
{
objvExportExcel4UsersEN.dicFldComparisonOp[convExportExcel4Users.OrderNum] = strComparisonOp;
}
}
return objvExportExcel4UsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvExportExcel4UsersEN SetUpdDate(this clsvExportExcel4UsersEN objvExportExcel4UsersEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convExportExcel4Users.UpdDate);
objvExportExcel4UsersEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(convExportExcel4Users.UpdDate) == false)
{
objvExportExcel4UsersEN.dicFldComparisonOp.Add(convExportExcel4Users.UpdDate, strComparisonOp);
}
else
{
objvExportExcel4UsersEN.dicFldComparisonOp[convExportExcel4Users.UpdDate] = strComparisonOp;
}
}
return objvExportExcel4UsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvExportExcel4UsersEN SetUpdUserId(this clsvExportExcel4UsersEN objvExportExcel4UsersEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convExportExcel4Users.UpdUserId);
objvExportExcel4UsersEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(convExportExcel4Users.UpdUserId) == false)
{
objvExportExcel4UsersEN.dicFldComparisonOp.Add(convExportExcel4Users.UpdUserId, strComparisonOp);
}
else
{
objvExportExcel4UsersEN.dicFldComparisonOp[convExportExcel4Users.UpdUserId] = strComparisonOp;
}
}
return objvExportExcel4UsersEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvExportExcel4UsersEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvExportExcel4UsersEN SetMemo(this clsvExportExcel4UsersEN objvExportExcel4UsersEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convExportExcel4Users.Memo);
objvExportExcel4UsersEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvExportExcel4UsersEN.dicFldComparisonOp.ContainsKey(convExportExcel4Users.Memo) == false)
{
objvExportExcel4UsersEN.dicFldComparisonOp.Add(convExportExcel4Users.Memo, strComparisonOp);
}
else
{
objvExportExcel4UsersEN.dicFldComparisonOp[convExportExcel4Users.Memo] = strComparisonOp;
}
}
return objvExportExcel4UsersEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvExportExcel4UsersEN objvExportExcel4Users_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvExportExcel4Users_Cond.IsUpdated(convExportExcel4Users.mId) == true)
{
string strComparisonOp_mId = objvExportExcel4Users_Cond.dicFldComparisonOp[convExportExcel4Users.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convExportExcel4Users.mId, objvExportExcel4Users_Cond.mId, strComparisonOp_mId);
}
if (objvExportExcel4Users_Cond.IsUpdated(convExportExcel4Users.id_ExportExcel4Users) == true)
{
string strComparisonOp_id_ExportExcel4Users = objvExportExcel4Users_Cond.dicFldComparisonOp[convExportExcel4Users.id_ExportExcel4Users];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExportExcel4Users.id_ExportExcel4Users, objvExportExcel4Users_Cond.id_ExportExcel4Users, strComparisonOp_id_ExportExcel4Users);
}
if (objvExportExcel4Users_Cond.IsUpdated(convExportExcel4Users.ViewName) == true)
{
string strComparisonOp_ViewName = objvExportExcel4Users_Cond.dicFldComparisonOp[convExportExcel4Users.ViewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExportExcel4Users.ViewName, objvExportExcel4Users_Cond.ViewName, strComparisonOp_ViewName);
}
if (objvExportExcel4Users_Cond.IsUpdated(convExportExcel4Users.TabName) == true)
{
string strComparisonOp_TabName = objvExportExcel4Users_Cond.dicFldComparisonOp[convExportExcel4Users.TabName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExportExcel4Users.TabName, objvExportExcel4Users_Cond.TabName, strComparisonOp_TabName);
}
if (objvExportExcel4Users_Cond.IsUpdated(convExportExcel4Users.UserId) == true)
{
string strComparisonOp_UserId = objvExportExcel4Users_Cond.dicFldComparisonOp[convExportExcel4Users.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExportExcel4Users.UserId, objvExportExcel4Users_Cond.UserId, strComparisonOp_UserId);
}
if (objvExportExcel4Users_Cond.IsUpdated(convExportExcel4Users.UserName) == true)
{
string strComparisonOp_UserName = objvExportExcel4Users_Cond.dicFldComparisonOp[convExportExcel4Users.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExportExcel4Users.UserName, objvExportExcel4Users_Cond.UserName, strComparisonOp_UserName);
}
if (objvExportExcel4Users_Cond.IsUpdated(convExportExcel4Users.IsDefaultUser) == true)
{
if (objvExportExcel4Users_Cond.IsDefaultUser == true)
{
strWhereCond += string.Format(" And {0} = '1'", convExportExcel4Users.IsDefaultUser);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convExportExcel4Users.IsDefaultUser);
}
}
if (objvExportExcel4Users_Cond.IsUpdated(convExportExcel4Users.ExportFileName) == true)
{
string strComparisonOp_ExportFileName = objvExportExcel4Users_Cond.dicFldComparisonOp[convExportExcel4Users.ExportFileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExportExcel4Users.ExportFileName, objvExportExcel4Users_Cond.ExportFileName, strComparisonOp_ExportFileName);
}
if (objvExportExcel4Users_Cond.IsUpdated(convExportExcel4Users.FieldName) == true)
{
string strComparisonOp_FieldName = objvExportExcel4Users_Cond.dicFldComparisonOp[convExportExcel4Users.FieldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExportExcel4Users.FieldName, objvExportExcel4Users_Cond.FieldName, strComparisonOp_FieldName);
}
if (objvExportExcel4Users_Cond.IsUpdated(convExportExcel4Users.FieldCnName) == true)
{
string strComparisonOp_FieldCnName = objvExportExcel4Users_Cond.dicFldComparisonOp[convExportExcel4Users.FieldCnName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExportExcel4Users.FieldCnName, objvExportExcel4Users_Cond.FieldCnName, strComparisonOp_FieldCnName);
}
if (objvExportExcel4Users_Cond.IsUpdated(convExportExcel4Users.IsExport) == true)
{
if (objvExportExcel4Users_Cond.IsExport == true)
{
strWhereCond += string.Format(" And {0} = '1'", convExportExcel4Users.IsExport);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convExportExcel4Users.IsExport);
}
}
if (objvExportExcel4Users_Cond.IsUpdated(convExportExcel4Users.OrderNum) == true)
{
string strComparisonOp_OrderNum = objvExportExcel4Users_Cond.dicFldComparisonOp[convExportExcel4Users.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convExportExcel4Users.OrderNum, objvExportExcel4Users_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objvExportExcel4Users_Cond.IsUpdated(convExportExcel4Users.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvExportExcel4Users_Cond.dicFldComparisonOp[convExportExcel4Users.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExportExcel4Users.UpdDate, objvExportExcel4Users_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvExportExcel4Users_Cond.IsUpdated(convExportExcel4Users.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvExportExcel4Users_Cond.dicFldComparisonOp[convExportExcel4Users.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExportExcel4Users.UpdUserId, objvExportExcel4Users_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvExportExcel4Users_Cond.IsUpdated(convExportExcel4Users.Memo) == true)
{
string strComparisonOp_Memo = objvExportExcel4Users_Cond.dicFldComparisonOp[convExportExcel4Users.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convExportExcel4Users.Memo, objvExportExcel4Users_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v导出Excel用户字段(vExportExcel4Users)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvExportExcel4UsersWApi
{
private static readonly string mstrApiControllerName = "vExportExcel4UsersApi";

 public clsvExportExcel4UsersWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvExportExcel4UsersEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsvExportExcel4UsersEN objvExportExcel4UsersEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvExportExcel4UsersEN = JsonConvert.DeserializeObject<clsvExportExcel4UsersEN>((string)jobjReturn["ReturnObj"]);
return objvExportExcel4UsersEN;
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
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvExportExcel4UsersEN GetObjBymId_WA_Cache(long lngmId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvExportExcel4UsersEN objvExportExcel4UsersEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvExportExcel4UsersEN = JsonConvert.DeserializeObject<clsvExportExcel4UsersEN>((string)jobjReturn["ReturnObj"]);
return objvExportExcel4UsersEN;
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
public static clsvExportExcel4UsersEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvExportExcel4UsersEN objvExportExcel4UsersEN = null;
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
objvExportExcel4UsersEN = JsonConvert.DeserializeObject<clsvExportExcel4UsersEN>((string)jobjReturn["ReturnObj"]);
return objvExportExcel4UsersEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvExportExcel4UsersEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvExportExcel4UsersEN._CurrTabName_S);
List<clsvExportExcel4UsersEN> arrvExportExcel4UsersObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvExportExcel4UsersEN> arrvExportExcel4UsersObjLst_Sel =
from objvExportExcel4UsersEN in arrvExportExcel4UsersObjLst_Cache
where objvExportExcel4UsersEN.mId == lngmId
select objvExportExcel4UsersEN;
if (arrvExportExcel4UsersObjLst_Sel.Count() == 0)
{
   clsvExportExcel4UsersEN obj = clsvExportExcel4UsersWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvExportExcel4UsersObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvExportExcel4UsersEN> GetObjLst(string strWhereCond)
{
 List<clsvExportExcel4UsersEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvExportExcel4UsersEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvExportExcel4UsersEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvExportExcel4UsersEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvExportExcel4UsersEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvExportExcel4UsersEN> GetObjLstByMIdLst_Cache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvExportExcel4UsersEN._CurrTabName_S);
List<clsvExportExcel4UsersEN> arrvExportExcel4UsersObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvExportExcel4UsersEN> arrvExportExcel4UsersObjLst_Sel =
from objvExportExcel4UsersEN in arrvExportExcel4UsersObjLst_Cache
where arrMId.Contains(objvExportExcel4UsersEN.mId)
select objvExportExcel4UsersEN;
return arrvExportExcel4UsersObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvExportExcel4UsersEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId)
{
 List<clsvExportExcel4UsersEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvExportExcel4UsersEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvExportExcel4UsersEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvExportExcel4UsersEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvExportExcel4UsersEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvExportExcel4UsersEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvExportExcel4UsersEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvExportExcel4UsersEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvExportExcel4UsersEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvExportExcel4UsersEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvExportExcel4UsersEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvExportExcel4UsersEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvExportExcel4UsersEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvExportExcel4UsersEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngmId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
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
 /// <param name = "objvExportExcel4UsersENS">源对象</param>
 /// <param name = "objvExportExcel4UsersENT">目标对象</param>
 public static void CopyTo(clsvExportExcel4UsersEN objvExportExcel4UsersENS, clsvExportExcel4UsersEN objvExportExcel4UsersENT)
{
try
{
objvExportExcel4UsersENT.mId = objvExportExcel4UsersENS.mId; //mId
objvExportExcel4UsersENT.id_ExportExcel4Users = objvExportExcel4UsersENS.id_ExportExcel4Users; //导出Excel用户字段流水号
objvExportExcel4UsersENT.ViewName = objvExportExcel4UsersENS.ViewName; //界面名称
objvExportExcel4UsersENT.TabName = objvExportExcel4UsersENS.TabName; //表名
objvExportExcel4UsersENT.UserId = objvExportExcel4UsersENS.UserId; //用户ID
objvExportExcel4UsersENT.UserName = objvExportExcel4UsersENS.UserName; //用户名
objvExportExcel4UsersENT.IsDefaultUser = objvExportExcel4UsersENS.IsDefaultUser; //是否默认用户
objvExportExcel4UsersENT.ExportFileName = objvExportExcel4UsersENS.ExportFileName; //导出文件名
objvExportExcel4UsersENT.FieldName = objvExportExcel4UsersENS.FieldName; //字段名
objvExportExcel4UsersENT.FieldCnName = objvExportExcel4UsersENS.FieldCnName; //字段中文名称
objvExportExcel4UsersENT.IsExport = objvExportExcel4UsersENS.IsExport; //是否导出
objvExportExcel4UsersENT.OrderNum = objvExportExcel4UsersENS.OrderNum; //序号
objvExportExcel4UsersENT.UpdDate = objvExportExcel4UsersENS.UpdDate; //修改日期
objvExportExcel4UsersENT.UpdUserId = objvExportExcel4UsersENS.UpdUserId; //修改用户Id
objvExportExcel4UsersENT.Memo = objvExportExcel4UsersENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvExportExcel4UsersEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvExportExcel4UsersEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvExportExcel4UsersEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvExportExcel4UsersEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvExportExcel4UsersEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvExportExcel4UsersEN.AttributeName)
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
if (clsExportExcel4UsersWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsExportExcel4UsersWApi没有刷新缓存机制(clsExportExcel4UsersWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUsersWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersWApi没有刷新缓存机制(clsUsersWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsExportExcelSetWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsExportExcelSetWApi没有刷新缓存机制(clsExportExcelSetWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvExportExcel4UsersObjLst_Cache == null)
//{
//arrvExportExcel4UsersObjLst_Cache = await clsvExportExcel4UsersWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvExportExcel4UsersEN._CurrTabName_S);
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
public static List<clsvExportExcel4UsersEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvExportExcel4UsersEN._CurrTabName_S);
List<clsvExportExcel4UsersEN> arrvExportExcel4UsersObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvExportExcel4UsersObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvExportExcel4UsersEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convExportExcel4Users.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convExportExcel4Users.id_ExportExcel4Users, Type.GetType("System.String"));
objDT.Columns.Add(convExportExcel4Users.ViewName, Type.GetType("System.String"));
objDT.Columns.Add(convExportExcel4Users.TabName, Type.GetType("System.String"));
objDT.Columns.Add(convExportExcel4Users.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convExportExcel4Users.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convExportExcel4Users.IsDefaultUser, Type.GetType("System.Boolean"));
objDT.Columns.Add(convExportExcel4Users.ExportFileName, Type.GetType("System.String"));
objDT.Columns.Add(convExportExcel4Users.FieldName, Type.GetType("System.String"));
objDT.Columns.Add(convExportExcel4Users.FieldCnName, Type.GetType("System.String"));
objDT.Columns.Add(convExportExcel4Users.IsExport, Type.GetType("System.Boolean"));
objDT.Columns.Add(convExportExcel4Users.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convExportExcel4Users.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convExportExcel4Users.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convExportExcel4Users.Memo, Type.GetType("System.String"));
foreach (clsvExportExcel4UsersEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convExportExcel4Users.mId] = objInFor[convExportExcel4Users.mId];
objDR[convExportExcel4Users.id_ExportExcel4Users] = objInFor[convExportExcel4Users.id_ExportExcel4Users];
objDR[convExportExcel4Users.ViewName] = objInFor[convExportExcel4Users.ViewName];
objDR[convExportExcel4Users.TabName] = objInFor[convExportExcel4Users.TabName];
objDR[convExportExcel4Users.UserId] = objInFor[convExportExcel4Users.UserId];
objDR[convExportExcel4Users.UserName] = objInFor[convExportExcel4Users.UserName];
objDR[convExportExcel4Users.IsDefaultUser] = objInFor[convExportExcel4Users.IsDefaultUser];
objDR[convExportExcel4Users.ExportFileName] = objInFor[convExportExcel4Users.ExportFileName];
objDR[convExportExcel4Users.FieldName] = objInFor[convExportExcel4Users.FieldName];
objDR[convExportExcel4Users.FieldCnName] = objInFor[convExportExcel4Users.FieldCnName];
objDR[convExportExcel4Users.IsExport] = objInFor[convExportExcel4Users.IsExport];
objDR[convExportExcel4Users.OrderNum] = objInFor[convExportExcel4Users.OrderNum];
objDR[convExportExcel4Users.UpdDate] = objInFor[convExportExcel4Users.UpdDate];
objDR[convExportExcel4Users.UpdUserId] = objInFor[convExportExcel4Users.UpdUserId];
objDR[convExportExcel4Users.Memo] = objInFor[convExportExcel4Users.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}