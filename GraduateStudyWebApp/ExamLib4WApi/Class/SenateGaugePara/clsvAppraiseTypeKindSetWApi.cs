
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvAppraiseTypeKindSetWApi
 表名:vAppraiseTypeKindSet(01120459)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:49:33
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:评价相关参数
 模块英文名:SenateGaugePara
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
public static class clsvAppraiseTypeKindSetWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppraiseTypeKindSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvAppraiseTypeKindSetEN SetmId(this clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN, long lngmId, string strComparisonOp="")
	{
objvAppraiseTypeKindSetEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppraiseTypeKindSetEN.dicFldComparisonOp.ContainsKey(convAppraiseTypeKindSet.mId) == false)
{
objvAppraiseTypeKindSetEN.dicFldComparisonOp.Add(convAppraiseTypeKindSet.mId, strComparisonOp);
}
else
{
objvAppraiseTypeKindSetEN.dicFldComparisonOp[convAppraiseTypeKindSet.mId] = strComparisonOp;
}
}
return objvAppraiseTypeKindSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppraiseTypeKindSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvAppraiseTypeKindSetEN Setid_School(this clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN, string strid_School, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_School, 4, convAppraiseTypeKindSet.id_School);
clsCheckSql.CheckFieldForeignKey(strid_School, 4, convAppraiseTypeKindSet.id_School);
objvAppraiseTypeKindSetEN.id_School = strid_School; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppraiseTypeKindSetEN.dicFldComparisonOp.ContainsKey(convAppraiseTypeKindSet.id_School) == false)
{
objvAppraiseTypeKindSetEN.dicFldComparisonOp.Add(convAppraiseTypeKindSet.id_School, strComparisonOp);
}
else
{
objvAppraiseTypeKindSetEN.dicFldComparisonOp[convAppraiseTypeKindSet.id_School] = strComparisonOp;
}
}
return objvAppraiseTypeKindSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppraiseTypeKindSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvAppraiseTypeKindSetEN SetSchoolId(this clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN, string strSchoolId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolId, convAppraiseTypeKindSet.SchoolId);
clsCheckSql.CheckFieldLen(strSchoolId, 10, convAppraiseTypeKindSet.SchoolId);
objvAppraiseTypeKindSetEN.SchoolId = strSchoolId; //学校编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppraiseTypeKindSetEN.dicFldComparisonOp.ContainsKey(convAppraiseTypeKindSet.SchoolId) == false)
{
objvAppraiseTypeKindSetEN.dicFldComparisonOp.Add(convAppraiseTypeKindSet.SchoolId, strComparisonOp);
}
else
{
objvAppraiseTypeKindSetEN.dicFldComparisonOp[convAppraiseTypeKindSet.SchoolId] = strComparisonOp;
}
}
return objvAppraiseTypeKindSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppraiseTypeKindSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvAppraiseTypeKindSetEN SetSchoolName(this clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN, string strSchoolName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolName, convAppraiseTypeKindSet.SchoolName);
clsCheckSql.CheckFieldLen(strSchoolName, 50, convAppraiseTypeKindSet.SchoolName);
objvAppraiseTypeKindSetEN.SchoolName = strSchoolName; //学校名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppraiseTypeKindSetEN.dicFldComparisonOp.ContainsKey(convAppraiseTypeKindSet.SchoolName) == false)
{
objvAppraiseTypeKindSetEN.dicFldComparisonOp.Add(convAppraiseTypeKindSet.SchoolName, strComparisonOp);
}
else
{
objvAppraiseTypeKindSetEN.dicFldComparisonOp[convAppraiseTypeKindSet.SchoolName] = strComparisonOp;
}
}
return objvAppraiseTypeKindSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppraiseTypeKindSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvAppraiseTypeKindSetEN SetFuncModuleId(this clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convAppraiseTypeKindSet.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convAppraiseTypeKindSet.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convAppraiseTypeKindSet.FuncModuleId);
objvAppraiseTypeKindSetEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppraiseTypeKindSetEN.dicFldComparisonOp.ContainsKey(convAppraiseTypeKindSet.FuncModuleId) == false)
{
objvAppraiseTypeKindSetEN.dicFldComparisonOp.Add(convAppraiseTypeKindSet.FuncModuleId, strComparisonOp);
}
else
{
objvAppraiseTypeKindSetEN.dicFldComparisonOp[convAppraiseTypeKindSet.FuncModuleId] = strComparisonOp;
}
}
return objvAppraiseTypeKindSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppraiseTypeKindSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvAppraiseTypeKindSetEN SetFuncModuleName(this clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convAppraiseTypeKindSet.FuncModuleName);
objvAppraiseTypeKindSetEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppraiseTypeKindSetEN.dicFldComparisonOp.ContainsKey(convAppraiseTypeKindSet.FuncModuleName) == false)
{
objvAppraiseTypeKindSetEN.dicFldComparisonOp.Add(convAppraiseTypeKindSet.FuncModuleName, strComparisonOp);
}
else
{
objvAppraiseTypeKindSetEN.dicFldComparisonOp[convAppraiseTypeKindSet.FuncModuleName] = strComparisonOp;
}
}
return objvAppraiseTypeKindSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppraiseTypeKindSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvAppraiseTypeKindSetEN SetFuncModuleName_Sim(this clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN, string strFuncModuleName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName_Sim, 30, convAppraiseTypeKindSet.FuncModuleName_Sim);
objvAppraiseTypeKindSetEN.FuncModuleName_Sim = strFuncModuleName_Sim; //功能模块简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppraiseTypeKindSetEN.dicFldComparisonOp.ContainsKey(convAppraiseTypeKindSet.FuncModuleName_Sim) == false)
{
objvAppraiseTypeKindSetEN.dicFldComparisonOp.Add(convAppraiseTypeKindSet.FuncModuleName_Sim, strComparisonOp);
}
else
{
objvAppraiseTypeKindSetEN.dicFldComparisonOp[convAppraiseTypeKindSet.FuncModuleName_Sim] = strComparisonOp;
}
}
return objvAppraiseTypeKindSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppraiseTypeKindSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvAppraiseTypeKindSetEN Setid_AppraiseType(this clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN, string strid_AppraiseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_AppraiseType, convAppraiseTypeKindSet.id_AppraiseType);
clsCheckSql.CheckFieldLen(strid_AppraiseType, 4, convAppraiseTypeKindSet.id_AppraiseType);
clsCheckSql.CheckFieldForeignKey(strid_AppraiseType, 4, convAppraiseTypeKindSet.id_AppraiseType);
objvAppraiseTypeKindSetEN.id_AppraiseType = strid_AppraiseType; //评议类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppraiseTypeKindSetEN.dicFldComparisonOp.ContainsKey(convAppraiseTypeKindSet.id_AppraiseType) == false)
{
objvAppraiseTypeKindSetEN.dicFldComparisonOp.Add(convAppraiseTypeKindSet.id_AppraiseType, strComparisonOp);
}
else
{
objvAppraiseTypeKindSetEN.dicFldComparisonOp[convAppraiseTypeKindSet.id_AppraiseType] = strComparisonOp;
}
}
return objvAppraiseTypeKindSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppraiseTypeKindSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvAppraiseTypeKindSetEN SetAppraiseTypeName(this clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN, string strAppraiseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strAppraiseTypeName, convAppraiseTypeKindSet.AppraiseTypeName);
clsCheckSql.CheckFieldLen(strAppraiseTypeName, 50, convAppraiseTypeKindSet.AppraiseTypeName);
objvAppraiseTypeKindSetEN.AppraiseTypeName = strAppraiseTypeName; //评议类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppraiseTypeKindSetEN.dicFldComparisonOp.ContainsKey(convAppraiseTypeKindSet.AppraiseTypeName) == false)
{
objvAppraiseTypeKindSetEN.dicFldComparisonOp.Add(convAppraiseTypeKindSet.AppraiseTypeName, strComparisonOp);
}
else
{
objvAppraiseTypeKindSetEN.dicFldComparisonOp[convAppraiseTypeKindSet.AppraiseTypeName] = strComparisonOp;
}
}
return objvAppraiseTypeKindSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppraiseTypeKindSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvAppraiseTypeKindSetEN SetAppraiseKindId(this clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN, string strAppraiseKindId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strAppraiseKindId, convAppraiseTypeKindSet.AppraiseKindId);
clsCheckSql.CheckFieldLen(strAppraiseKindId, 2, convAppraiseTypeKindSet.AppraiseKindId);
clsCheckSql.CheckFieldForeignKey(strAppraiseKindId, 2, convAppraiseTypeKindSet.AppraiseKindId);
objvAppraiseTypeKindSetEN.AppraiseKindId = strAppraiseKindId; //评议种类Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppraiseTypeKindSetEN.dicFldComparisonOp.ContainsKey(convAppraiseTypeKindSet.AppraiseKindId) == false)
{
objvAppraiseTypeKindSetEN.dicFldComparisonOp.Add(convAppraiseTypeKindSet.AppraiseKindId, strComparisonOp);
}
else
{
objvAppraiseTypeKindSetEN.dicFldComparisonOp[convAppraiseTypeKindSet.AppraiseKindId] = strComparisonOp;
}
}
return objvAppraiseTypeKindSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppraiseTypeKindSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvAppraiseTypeKindSetEN SetAppraiseKindName(this clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN, string strAppraiseKindName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strAppraiseKindName, convAppraiseTypeKindSet.AppraiseKindName);
clsCheckSql.CheckFieldLen(strAppraiseKindName, 20, convAppraiseTypeKindSet.AppraiseKindName);
objvAppraiseTypeKindSetEN.AppraiseKindName = strAppraiseKindName; //评议种类名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppraiseTypeKindSetEN.dicFldComparisonOp.ContainsKey(convAppraiseTypeKindSet.AppraiseKindName) == false)
{
objvAppraiseTypeKindSetEN.dicFldComparisonOp.Add(convAppraiseTypeKindSet.AppraiseKindName, strComparisonOp);
}
else
{
objvAppraiseTypeKindSetEN.dicFldComparisonOp[convAppraiseTypeKindSet.AppraiseKindName] = strComparisonOp;
}
}
return objvAppraiseTypeKindSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppraiseTypeKindSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvAppraiseTypeKindSetEN SetInEffect(this clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN, bool bolInEffect, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolInEffect, convAppraiseTypeKindSet.InEffect);
objvAppraiseTypeKindSetEN.InEffect = bolInEffect; //是否有效
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppraiseTypeKindSetEN.dicFldComparisonOp.ContainsKey(convAppraiseTypeKindSet.InEffect) == false)
{
objvAppraiseTypeKindSetEN.dicFldComparisonOp.Add(convAppraiseTypeKindSet.InEffect, strComparisonOp);
}
else
{
objvAppraiseTypeKindSetEN.dicFldComparisonOp[convAppraiseTypeKindSet.InEffect] = strComparisonOp;
}
}
return objvAppraiseTypeKindSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppraiseTypeKindSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvAppraiseTypeKindSetEN SetUpdDate(this clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convAppraiseTypeKindSet.UpdDate);
objvAppraiseTypeKindSetEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppraiseTypeKindSetEN.dicFldComparisonOp.ContainsKey(convAppraiseTypeKindSet.UpdDate) == false)
{
objvAppraiseTypeKindSetEN.dicFldComparisonOp.Add(convAppraiseTypeKindSet.UpdDate, strComparisonOp);
}
else
{
objvAppraiseTypeKindSetEN.dicFldComparisonOp[convAppraiseTypeKindSet.UpdDate] = strComparisonOp;
}
}
return objvAppraiseTypeKindSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppraiseTypeKindSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvAppraiseTypeKindSetEN SetUpdUserId(this clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convAppraiseTypeKindSet.UpdUserId);
objvAppraiseTypeKindSetEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppraiseTypeKindSetEN.dicFldComparisonOp.ContainsKey(convAppraiseTypeKindSet.UpdUserId) == false)
{
objvAppraiseTypeKindSetEN.dicFldComparisonOp.Add(convAppraiseTypeKindSet.UpdUserId, strComparisonOp);
}
else
{
objvAppraiseTypeKindSetEN.dicFldComparisonOp[convAppraiseTypeKindSet.UpdUserId] = strComparisonOp;
}
}
return objvAppraiseTypeKindSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppraiseTypeKindSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvAppraiseTypeKindSetEN SetMemo(this clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convAppraiseTypeKindSet.Memo);
objvAppraiseTypeKindSetEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppraiseTypeKindSetEN.dicFldComparisonOp.ContainsKey(convAppraiseTypeKindSet.Memo) == false)
{
objvAppraiseTypeKindSetEN.dicFldComparisonOp.Add(convAppraiseTypeKindSet.Memo, strComparisonOp);
}
else
{
objvAppraiseTypeKindSetEN.dicFldComparisonOp[convAppraiseTypeKindSet.Memo] = strComparisonOp;
}
}
return objvAppraiseTypeKindSetEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSet_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvAppraiseTypeKindSet_Cond.IsUpdated(convAppraiseTypeKindSet.mId) == true)
{
string strComparisonOp_mId = objvAppraiseTypeKindSet_Cond.dicFldComparisonOp[convAppraiseTypeKindSet.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convAppraiseTypeKindSet.mId, objvAppraiseTypeKindSet_Cond.mId, strComparisonOp_mId);
}
if (objvAppraiseTypeKindSet_Cond.IsUpdated(convAppraiseTypeKindSet.id_School) == true)
{
string strComparisonOp_id_School = objvAppraiseTypeKindSet_Cond.dicFldComparisonOp[convAppraiseTypeKindSet.id_School];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppraiseTypeKindSet.id_School, objvAppraiseTypeKindSet_Cond.id_School, strComparisonOp_id_School);
}
if (objvAppraiseTypeKindSet_Cond.IsUpdated(convAppraiseTypeKindSet.SchoolId) == true)
{
string strComparisonOp_SchoolId = objvAppraiseTypeKindSet_Cond.dicFldComparisonOp[convAppraiseTypeKindSet.SchoolId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppraiseTypeKindSet.SchoolId, objvAppraiseTypeKindSet_Cond.SchoolId, strComparisonOp_SchoolId);
}
if (objvAppraiseTypeKindSet_Cond.IsUpdated(convAppraiseTypeKindSet.SchoolName) == true)
{
string strComparisonOp_SchoolName = objvAppraiseTypeKindSet_Cond.dicFldComparisonOp[convAppraiseTypeKindSet.SchoolName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppraiseTypeKindSet.SchoolName, objvAppraiseTypeKindSet_Cond.SchoolName, strComparisonOp_SchoolName);
}
if (objvAppraiseTypeKindSet_Cond.IsUpdated(convAppraiseTypeKindSet.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvAppraiseTypeKindSet_Cond.dicFldComparisonOp[convAppraiseTypeKindSet.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppraiseTypeKindSet.FuncModuleId, objvAppraiseTypeKindSet_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvAppraiseTypeKindSet_Cond.IsUpdated(convAppraiseTypeKindSet.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvAppraiseTypeKindSet_Cond.dicFldComparisonOp[convAppraiseTypeKindSet.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppraiseTypeKindSet.FuncModuleName, objvAppraiseTypeKindSet_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvAppraiseTypeKindSet_Cond.IsUpdated(convAppraiseTypeKindSet.FuncModuleName_Sim) == true)
{
string strComparisonOp_FuncModuleName_Sim = objvAppraiseTypeKindSet_Cond.dicFldComparisonOp[convAppraiseTypeKindSet.FuncModuleName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppraiseTypeKindSet.FuncModuleName_Sim, objvAppraiseTypeKindSet_Cond.FuncModuleName_Sim, strComparisonOp_FuncModuleName_Sim);
}
if (objvAppraiseTypeKindSet_Cond.IsUpdated(convAppraiseTypeKindSet.id_AppraiseType) == true)
{
string strComparisonOp_id_AppraiseType = objvAppraiseTypeKindSet_Cond.dicFldComparisonOp[convAppraiseTypeKindSet.id_AppraiseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppraiseTypeKindSet.id_AppraiseType, objvAppraiseTypeKindSet_Cond.id_AppraiseType, strComparisonOp_id_AppraiseType);
}
if (objvAppraiseTypeKindSet_Cond.IsUpdated(convAppraiseTypeKindSet.AppraiseTypeName) == true)
{
string strComparisonOp_AppraiseTypeName = objvAppraiseTypeKindSet_Cond.dicFldComparisonOp[convAppraiseTypeKindSet.AppraiseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppraiseTypeKindSet.AppraiseTypeName, objvAppraiseTypeKindSet_Cond.AppraiseTypeName, strComparisonOp_AppraiseTypeName);
}
if (objvAppraiseTypeKindSet_Cond.IsUpdated(convAppraiseTypeKindSet.AppraiseKindId) == true)
{
string strComparisonOp_AppraiseKindId = objvAppraiseTypeKindSet_Cond.dicFldComparisonOp[convAppraiseTypeKindSet.AppraiseKindId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppraiseTypeKindSet.AppraiseKindId, objvAppraiseTypeKindSet_Cond.AppraiseKindId, strComparisonOp_AppraiseKindId);
}
if (objvAppraiseTypeKindSet_Cond.IsUpdated(convAppraiseTypeKindSet.AppraiseKindName) == true)
{
string strComparisonOp_AppraiseKindName = objvAppraiseTypeKindSet_Cond.dicFldComparisonOp[convAppraiseTypeKindSet.AppraiseKindName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppraiseTypeKindSet.AppraiseKindName, objvAppraiseTypeKindSet_Cond.AppraiseKindName, strComparisonOp_AppraiseKindName);
}
if (objvAppraiseTypeKindSet_Cond.IsUpdated(convAppraiseTypeKindSet.InEffect) == true)
{
if (objvAppraiseTypeKindSet_Cond.InEffect == true)
{
strWhereCond += string.Format(" And {0} = '1'", convAppraiseTypeKindSet.InEffect);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convAppraiseTypeKindSet.InEffect);
}
}
if (objvAppraiseTypeKindSet_Cond.IsUpdated(convAppraiseTypeKindSet.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvAppraiseTypeKindSet_Cond.dicFldComparisonOp[convAppraiseTypeKindSet.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppraiseTypeKindSet.UpdDate, objvAppraiseTypeKindSet_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvAppraiseTypeKindSet_Cond.IsUpdated(convAppraiseTypeKindSet.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvAppraiseTypeKindSet_Cond.dicFldComparisonOp[convAppraiseTypeKindSet.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppraiseTypeKindSet.UpdUserId, objvAppraiseTypeKindSet_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvAppraiseTypeKindSet_Cond.IsUpdated(convAppraiseTypeKindSet.Memo) == true)
{
string strComparisonOp_Memo = objvAppraiseTypeKindSet_Cond.dicFldComparisonOp[convAppraiseTypeKindSet.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppraiseTypeKindSet.Memo, objvAppraiseTypeKindSet_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v评议类型种类设置(vAppraiseTypeKindSet)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvAppraiseTypeKindSetWApi
{
private static readonly string mstrApiControllerName = "vAppraiseTypeKindSetApi";

 public clsvAppraiseTypeKindSetWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvAppraiseTypeKindSetEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN = null;
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
objvAppraiseTypeKindSetEN = JsonConvert.DeserializeObject<clsvAppraiseTypeKindSetEN>((string)jobjReturn["ReturnObj"]);
return objvAppraiseTypeKindSetEN;
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
public static clsvAppraiseTypeKindSetEN GetObjBymId_WA_Cache(long lngmId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN = null;
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
objvAppraiseTypeKindSetEN = JsonConvert.DeserializeObject<clsvAppraiseTypeKindSetEN>((string)jobjReturn["ReturnObj"]);
return objvAppraiseTypeKindSetEN;
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
public static clsvAppraiseTypeKindSetEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN = null;
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
objvAppraiseTypeKindSetEN = JsonConvert.DeserializeObject<clsvAppraiseTypeKindSetEN>((string)jobjReturn["ReturnObj"]);
return objvAppraiseTypeKindSetEN;
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
public static clsvAppraiseTypeKindSetEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvAppraiseTypeKindSetEN._CurrTabName_S);
List<clsvAppraiseTypeKindSetEN> arrvAppraiseTypeKindSetObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvAppraiseTypeKindSetEN> arrvAppraiseTypeKindSetObjLst_Sel =
from objvAppraiseTypeKindSetEN in arrvAppraiseTypeKindSetObjLst_Cache
where objvAppraiseTypeKindSetEN.mId == lngmId
select objvAppraiseTypeKindSetEN;
if (arrvAppraiseTypeKindSetObjLst_Sel.Count() == 0)
{
   clsvAppraiseTypeKindSetEN obj = clsvAppraiseTypeKindSetWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvAppraiseTypeKindSetObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvAppraiseTypeKindSetEN> GetObjLst(string strWhereCond)
{
 List<clsvAppraiseTypeKindSetEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvAppraiseTypeKindSetEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvAppraiseTypeKindSetEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvAppraiseTypeKindSetEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvAppraiseTypeKindSetEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvAppraiseTypeKindSetEN> GetObjLstByMIdLst_Cache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvAppraiseTypeKindSetEN._CurrTabName_S);
List<clsvAppraiseTypeKindSetEN> arrvAppraiseTypeKindSetObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvAppraiseTypeKindSetEN> arrvAppraiseTypeKindSetObjLst_Sel =
from objvAppraiseTypeKindSetEN in arrvAppraiseTypeKindSetObjLst_Cache
where arrMId.Contains(objvAppraiseTypeKindSetEN.mId)
select objvAppraiseTypeKindSetEN;
return arrvAppraiseTypeKindSetObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvAppraiseTypeKindSetEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId)
{
 List<clsvAppraiseTypeKindSetEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvAppraiseTypeKindSetEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvAppraiseTypeKindSetEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvAppraiseTypeKindSetEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvAppraiseTypeKindSetEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvAppraiseTypeKindSetEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvAppraiseTypeKindSetEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvAppraiseTypeKindSetEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvAppraiseTypeKindSetEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvAppraiseTypeKindSetEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvAppraiseTypeKindSetEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvAppraiseTypeKindSetEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvAppraiseTypeKindSetEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvAppraiseTypeKindSetEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvAppraiseTypeKindSetENS">源对象</param>
 /// <param name = "objvAppraiseTypeKindSetENT">目标对象</param>
 public static void CopyTo(clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetENS, clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetENT)
{
try
{
objvAppraiseTypeKindSetENT.mId = objvAppraiseTypeKindSetENS.mId; //mId
objvAppraiseTypeKindSetENT.id_School = objvAppraiseTypeKindSetENS.id_School; //学校流水号
objvAppraiseTypeKindSetENT.SchoolId = objvAppraiseTypeKindSetENS.SchoolId; //学校编号
objvAppraiseTypeKindSetENT.SchoolName = objvAppraiseTypeKindSetENS.SchoolName; //学校名称
objvAppraiseTypeKindSetENT.FuncModuleId = objvAppraiseTypeKindSetENS.FuncModuleId; //功能模块Id
objvAppraiseTypeKindSetENT.FuncModuleName = objvAppraiseTypeKindSetENS.FuncModuleName; //功能模块名称
objvAppraiseTypeKindSetENT.FuncModuleName_Sim = objvAppraiseTypeKindSetENS.FuncModuleName_Sim; //功能模块简称
objvAppraiseTypeKindSetENT.id_AppraiseType = objvAppraiseTypeKindSetENS.id_AppraiseType; //评议类型流水号
objvAppraiseTypeKindSetENT.AppraiseTypeName = objvAppraiseTypeKindSetENS.AppraiseTypeName; //评议类型名称
objvAppraiseTypeKindSetENT.AppraiseKindId = objvAppraiseTypeKindSetENS.AppraiseKindId; //评议种类Id
objvAppraiseTypeKindSetENT.AppraiseKindName = objvAppraiseTypeKindSetENS.AppraiseKindName; //评议种类名
objvAppraiseTypeKindSetENT.InEffect = objvAppraiseTypeKindSetENS.InEffect; //是否有效
objvAppraiseTypeKindSetENT.UpdDate = objvAppraiseTypeKindSetENS.UpdDate; //修改日期
objvAppraiseTypeKindSetENT.UpdUserId = objvAppraiseTypeKindSetENS.UpdUserId; //修改用户Id
objvAppraiseTypeKindSetENT.Memo = objvAppraiseTypeKindSetENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvAppraiseTypeKindSetEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvAppraiseTypeKindSetEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvAppraiseTypeKindSetEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvAppraiseTypeKindSetEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvAppraiseTypeKindSetEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvAppraiseTypeKindSetEN.AttributeName)
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
if (clsXzSchoolWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzSchoolWApi没有刷新缓存机制(clsXzSchoolWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModuleWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleWApi没有刷新缓存机制(clsFuncModuleWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAppraiseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsAppraiseTypeWApi没有刷新缓存机制(clsAppraiseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAppraiseTypeKindSetWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsAppraiseTypeKindSetWApi没有刷新缓存机制(clsAppraiseTypeKindSetWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAppraiseKindWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsAppraiseKindWApi没有刷新缓存机制(clsAppraiseKindWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvAppraiseTypeKindSetObjLst_Cache == null)
//{
//arrvAppraiseTypeKindSetObjLst_Cache = await clsvAppraiseTypeKindSetWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvAppraiseTypeKindSetEN._CurrTabName_S);
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
public static List<clsvAppraiseTypeKindSetEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvAppraiseTypeKindSetEN._CurrTabName_S);
List<clsvAppraiseTypeKindSetEN> arrvAppraiseTypeKindSetObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvAppraiseTypeKindSetObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvAppraiseTypeKindSetEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convAppraiseTypeKindSet.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convAppraiseTypeKindSet.id_School, Type.GetType("System.String"));
objDT.Columns.Add(convAppraiseTypeKindSet.SchoolId, Type.GetType("System.String"));
objDT.Columns.Add(convAppraiseTypeKindSet.SchoolName, Type.GetType("System.String"));
objDT.Columns.Add(convAppraiseTypeKindSet.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convAppraiseTypeKindSet.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convAppraiseTypeKindSet.FuncModuleName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convAppraiseTypeKindSet.id_AppraiseType, Type.GetType("System.String"));
objDT.Columns.Add(convAppraiseTypeKindSet.AppraiseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convAppraiseTypeKindSet.AppraiseKindId, Type.GetType("System.String"));
objDT.Columns.Add(convAppraiseTypeKindSet.AppraiseKindName, Type.GetType("System.String"));
objDT.Columns.Add(convAppraiseTypeKindSet.InEffect, Type.GetType("System.Boolean"));
objDT.Columns.Add(convAppraiseTypeKindSet.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convAppraiseTypeKindSet.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convAppraiseTypeKindSet.Memo, Type.GetType("System.String"));
foreach (clsvAppraiseTypeKindSetEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convAppraiseTypeKindSet.mId] = objInFor[convAppraiseTypeKindSet.mId];
objDR[convAppraiseTypeKindSet.id_School] = objInFor[convAppraiseTypeKindSet.id_School];
objDR[convAppraiseTypeKindSet.SchoolId] = objInFor[convAppraiseTypeKindSet.SchoolId];
objDR[convAppraiseTypeKindSet.SchoolName] = objInFor[convAppraiseTypeKindSet.SchoolName];
objDR[convAppraiseTypeKindSet.FuncModuleId] = objInFor[convAppraiseTypeKindSet.FuncModuleId];
objDR[convAppraiseTypeKindSet.FuncModuleName] = objInFor[convAppraiseTypeKindSet.FuncModuleName];
objDR[convAppraiseTypeKindSet.FuncModuleName_Sim] = objInFor[convAppraiseTypeKindSet.FuncModuleName_Sim];
objDR[convAppraiseTypeKindSet.id_AppraiseType] = objInFor[convAppraiseTypeKindSet.id_AppraiseType];
objDR[convAppraiseTypeKindSet.AppraiseTypeName] = objInFor[convAppraiseTypeKindSet.AppraiseTypeName];
objDR[convAppraiseTypeKindSet.AppraiseKindId] = objInFor[convAppraiseTypeKindSet.AppraiseKindId];
objDR[convAppraiseTypeKindSet.AppraiseKindName] = objInFor[convAppraiseTypeKindSet.AppraiseKindName];
objDR[convAppraiseTypeKindSet.InEffect] = objInFor[convAppraiseTypeKindSet.InEffect];
objDR[convAppraiseTypeKindSet.UpdDate] = objInFor[convAppraiseTypeKindSet.UpdDate];
objDR[convAppraiseTypeKindSet.UpdUserId] = objInFor[convAppraiseTypeKindSet.UpdUserId];
objDR[convAppraiseTypeKindSet.Memo] = objInFor[convAppraiseTypeKindSet.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}