
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvAppraiseTypeKindSetBL
 表名:vAppraiseTypeKindSet(01120459)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:44:29
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:评价相关参数(SenateGaugePara)
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
public static class  clsvAppraiseTypeKindSetBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvAppraiseTypeKindSetEN GetObj(this K_mId_vAppraiseTypeKindSet myKey)
{
clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN = clsvAppraiseTypeKindSetBL.vAppraiseTypeKindSetDA.GetObjBymId(myKey.Value);
return objvAppraiseTypeKindSetEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppraiseTypeKindSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppraiseTypeKindSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppraiseTypeKindSetEN SetIdSchool(this clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN, string strIdSchool, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdSchool, 4, convAppraiseTypeKindSet.IdSchool);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdSchool, 4, convAppraiseTypeKindSet.IdSchool);
}
objvAppraiseTypeKindSetEN.IdSchool = strIdSchool; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppraiseTypeKindSetEN.dicFldComparisonOp.ContainsKey(convAppraiseTypeKindSet.IdSchool) == false)
{
objvAppraiseTypeKindSetEN.dicFldComparisonOp.Add(convAppraiseTypeKindSet.IdSchool, strComparisonOp);
}
else
{
objvAppraiseTypeKindSetEN.dicFldComparisonOp[convAppraiseTypeKindSet.IdSchool] = strComparisonOp;
}
}
return objvAppraiseTypeKindSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppraiseTypeKindSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppraiseTypeKindSetEN SetSchoolId(this clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN, string strSchoolId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolId, convAppraiseTypeKindSet.SchoolId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolId, 10, convAppraiseTypeKindSet.SchoolId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppraiseTypeKindSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppraiseTypeKindSetEN SetSchoolName(this clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN, string strSchoolName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolName, convAppraiseTypeKindSet.SchoolName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strSchoolName, 50, convAppraiseTypeKindSet.SchoolName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppraiseTypeKindSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppraiseTypeKindSetEN SetFuncModuleId(this clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convAppraiseTypeKindSet.FuncModuleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convAppraiseTypeKindSet.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convAppraiseTypeKindSet.FuncModuleId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppraiseTypeKindSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppraiseTypeKindSetEN SetFuncModuleName(this clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN, string strFuncModuleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convAppraiseTypeKindSet.FuncModuleName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppraiseTypeKindSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppraiseTypeKindSetEN SetFuncModuleNameSim(this clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN, string strFuncModuleNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleNameSim, 30, convAppraiseTypeKindSet.FuncModuleNameSim);
}
objvAppraiseTypeKindSetEN.FuncModuleNameSim = strFuncModuleNameSim; //功能模块简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppraiseTypeKindSetEN.dicFldComparisonOp.ContainsKey(convAppraiseTypeKindSet.FuncModuleNameSim) == false)
{
objvAppraiseTypeKindSetEN.dicFldComparisonOp.Add(convAppraiseTypeKindSet.FuncModuleNameSim, strComparisonOp);
}
else
{
objvAppraiseTypeKindSetEN.dicFldComparisonOp[convAppraiseTypeKindSet.FuncModuleNameSim] = strComparisonOp;
}
}
return objvAppraiseTypeKindSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppraiseTypeKindSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppraiseTypeKindSetEN SetIdAppraiseType(this clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN, string strIdAppraiseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdAppraiseType, convAppraiseTypeKindSet.IdAppraiseType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdAppraiseType, 4, convAppraiseTypeKindSet.IdAppraiseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdAppraiseType, 4, convAppraiseTypeKindSet.IdAppraiseType);
}
objvAppraiseTypeKindSetEN.IdAppraiseType = strIdAppraiseType; //评议类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvAppraiseTypeKindSetEN.dicFldComparisonOp.ContainsKey(convAppraiseTypeKindSet.IdAppraiseType) == false)
{
objvAppraiseTypeKindSetEN.dicFldComparisonOp.Add(convAppraiseTypeKindSet.IdAppraiseType, strComparisonOp);
}
else
{
objvAppraiseTypeKindSetEN.dicFldComparisonOp[convAppraiseTypeKindSet.IdAppraiseType] = strComparisonOp;
}
}
return objvAppraiseTypeKindSetEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppraiseTypeKindSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppraiseTypeKindSetEN SetAppraiseTypeName(this clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN, string strAppraiseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strAppraiseTypeName, convAppraiseTypeKindSet.AppraiseTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAppraiseTypeName, 50, convAppraiseTypeKindSet.AppraiseTypeName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppraiseTypeKindSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppraiseTypeKindSetEN SetAppraiseKindId(this clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN, string strAppraiseKindId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strAppraiseKindId, convAppraiseTypeKindSet.AppraiseKindId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAppraiseKindId, 2, convAppraiseTypeKindSet.AppraiseKindId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAppraiseKindId, 2, convAppraiseTypeKindSet.AppraiseKindId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppraiseTypeKindSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppraiseTypeKindSetEN SetAppraiseKindName(this clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN, string strAppraiseKindName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strAppraiseKindName, convAppraiseTypeKindSet.AppraiseKindName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAppraiseKindName, 20, convAppraiseTypeKindSet.AppraiseKindName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppraiseTypeKindSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppraiseTypeKindSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppraiseTypeKindSetEN SetUpdDate(this clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convAppraiseTypeKindSet.UpdDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppraiseTypeKindSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppraiseTypeKindSetEN SetUpdUserId(this clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convAppraiseTypeKindSet.UpdUserId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvAppraiseTypeKindSetEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvAppraiseTypeKindSetEN SetMemo(this clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convAppraiseTypeKindSet.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvAppraiseTypeKindSetENS">源对象</param>
 /// <param name = "objvAppraiseTypeKindSetENT">目标对象</param>
 public static void CopyTo(this clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetENS, clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetENT)
{
try
{
objvAppraiseTypeKindSetENT.mId = objvAppraiseTypeKindSetENS.mId; //mId
objvAppraiseTypeKindSetENT.IdSchool = objvAppraiseTypeKindSetENS.IdSchool; //学校流水号
objvAppraiseTypeKindSetENT.SchoolId = objvAppraiseTypeKindSetENS.SchoolId; //学校编号
objvAppraiseTypeKindSetENT.SchoolName = objvAppraiseTypeKindSetENS.SchoolName; //学校名称
objvAppraiseTypeKindSetENT.FuncModuleId = objvAppraiseTypeKindSetENS.FuncModuleId; //功能模块Id
objvAppraiseTypeKindSetENT.FuncModuleName = objvAppraiseTypeKindSetENS.FuncModuleName; //功能模块名称
objvAppraiseTypeKindSetENT.FuncModuleNameSim = objvAppraiseTypeKindSetENS.FuncModuleNameSim; //功能模块简称
objvAppraiseTypeKindSetENT.IdAppraiseType = objvAppraiseTypeKindSetENS.IdAppraiseType; //评议类型流水号
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
 /// <param name = "objvAppraiseTypeKindSetENS">源对象</param>
 /// <returns>目标对象=>clsvAppraiseTypeKindSetEN:objvAppraiseTypeKindSetENT</returns>
 public static clsvAppraiseTypeKindSetEN CopyTo(this clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetENS)
{
try
{
 clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetENT = new clsvAppraiseTypeKindSetEN()
{
mId = objvAppraiseTypeKindSetENS.mId, //mId
IdSchool = objvAppraiseTypeKindSetENS.IdSchool, //学校流水号
SchoolId = objvAppraiseTypeKindSetENS.SchoolId, //学校编号
SchoolName = objvAppraiseTypeKindSetENS.SchoolName, //学校名称
FuncModuleId = objvAppraiseTypeKindSetENS.FuncModuleId, //功能模块Id
FuncModuleName = objvAppraiseTypeKindSetENS.FuncModuleName, //功能模块名称
FuncModuleNameSim = objvAppraiseTypeKindSetENS.FuncModuleNameSim, //功能模块简称
IdAppraiseType = objvAppraiseTypeKindSetENS.IdAppraiseType, //评议类型流水号
AppraiseTypeName = objvAppraiseTypeKindSetENS.AppraiseTypeName, //评议类型名称
AppraiseKindId = objvAppraiseTypeKindSetENS.AppraiseKindId, //评议种类Id
AppraiseKindName = objvAppraiseTypeKindSetENS.AppraiseKindName, //评议种类名
InEffect = objvAppraiseTypeKindSetENS.InEffect, //是否有效
UpdDate = objvAppraiseTypeKindSetENS.UpdDate, //修改日期
UpdUserId = objvAppraiseTypeKindSetENS.UpdUserId, //修改用户Id
Memo = objvAppraiseTypeKindSetENS.Memo, //备注
};
 return objvAppraiseTypeKindSetENT;
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
public static void CheckProperty4Condition(this clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN)
{
 clsvAppraiseTypeKindSetBL.vAppraiseTypeKindSetDA.CheckProperty4Condition(objvAppraiseTypeKindSetEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvAppraiseTypeKindSetCond.IsUpdated(convAppraiseTypeKindSet.mId) == true)
{
string strComparisonOpmId = objvAppraiseTypeKindSetCond.dicFldComparisonOp[convAppraiseTypeKindSet.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convAppraiseTypeKindSet.mId, objvAppraiseTypeKindSetCond.mId, strComparisonOpmId);
}
if (objvAppraiseTypeKindSetCond.IsUpdated(convAppraiseTypeKindSet.IdSchool) == true)
{
string strComparisonOpIdSchool = objvAppraiseTypeKindSetCond.dicFldComparisonOp[convAppraiseTypeKindSet.IdSchool];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppraiseTypeKindSet.IdSchool, objvAppraiseTypeKindSetCond.IdSchool, strComparisonOpIdSchool);
}
if (objvAppraiseTypeKindSetCond.IsUpdated(convAppraiseTypeKindSet.SchoolId) == true)
{
string strComparisonOpSchoolId = objvAppraiseTypeKindSetCond.dicFldComparisonOp[convAppraiseTypeKindSet.SchoolId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppraiseTypeKindSet.SchoolId, objvAppraiseTypeKindSetCond.SchoolId, strComparisonOpSchoolId);
}
if (objvAppraiseTypeKindSetCond.IsUpdated(convAppraiseTypeKindSet.SchoolName) == true)
{
string strComparisonOpSchoolName = objvAppraiseTypeKindSetCond.dicFldComparisonOp[convAppraiseTypeKindSet.SchoolName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppraiseTypeKindSet.SchoolName, objvAppraiseTypeKindSetCond.SchoolName, strComparisonOpSchoolName);
}
if (objvAppraiseTypeKindSetCond.IsUpdated(convAppraiseTypeKindSet.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objvAppraiseTypeKindSetCond.dicFldComparisonOp[convAppraiseTypeKindSet.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppraiseTypeKindSet.FuncModuleId, objvAppraiseTypeKindSetCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objvAppraiseTypeKindSetCond.IsUpdated(convAppraiseTypeKindSet.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvAppraiseTypeKindSetCond.dicFldComparisonOp[convAppraiseTypeKindSet.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppraiseTypeKindSet.FuncModuleName, objvAppraiseTypeKindSetCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvAppraiseTypeKindSetCond.IsUpdated(convAppraiseTypeKindSet.FuncModuleNameSim) == true)
{
string strComparisonOpFuncModuleNameSim = objvAppraiseTypeKindSetCond.dicFldComparisonOp[convAppraiseTypeKindSet.FuncModuleNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppraiseTypeKindSet.FuncModuleNameSim, objvAppraiseTypeKindSetCond.FuncModuleNameSim, strComparisonOpFuncModuleNameSim);
}
if (objvAppraiseTypeKindSetCond.IsUpdated(convAppraiseTypeKindSet.IdAppraiseType) == true)
{
string strComparisonOpIdAppraiseType = objvAppraiseTypeKindSetCond.dicFldComparisonOp[convAppraiseTypeKindSet.IdAppraiseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppraiseTypeKindSet.IdAppraiseType, objvAppraiseTypeKindSetCond.IdAppraiseType, strComparisonOpIdAppraiseType);
}
if (objvAppraiseTypeKindSetCond.IsUpdated(convAppraiseTypeKindSet.AppraiseTypeName) == true)
{
string strComparisonOpAppraiseTypeName = objvAppraiseTypeKindSetCond.dicFldComparisonOp[convAppraiseTypeKindSet.AppraiseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppraiseTypeKindSet.AppraiseTypeName, objvAppraiseTypeKindSetCond.AppraiseTypeName, strComparisonOpAppraiseTypeName);
}
if (objvAppraiseTypeKindSetCond.IsUpdated(convAppraiseTypeKindSet.AppraiseKindId) == true)
{
string strComparisonOpAppraiseKindId = objvAppraiseTypeKindSetCond.dicFldComparisonOp[convAppraiseTypeKindSet.AppraiseKindId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppraiseTypeKindSet.AppraiseKindId, objvAppraiseTypeKindSetCond.AppraiseKindId, strComparisonOpAppraiseKindId);
}
if (objvAppraiseTypeKindSetCond.IsUpdated(convAppraiseTypeKindSet.AppraiseKindName) == true)
{
string strComparisonOpAppraiseKindName = objvAppraiseTypeKindSetCond.dicFldComparisonOp[convAppraiseTypeKindSet.AppraiseKindName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppraiseTypeKindSet.AppraiseKindName, objvAppraiseTypeKindSetCond.AppraiseKindName, strComparisonOpAppraiseKindName);
}
if (objvAppraiseTypeKindSetCond.IsUpdated(convAppraiseTypeKindSet.InEffect) == true)
{
if (objvAppraiseTypeKindSetCond.InEffect == true)
{
strWhereCond += string.Format(" And {0} = '1'", convAppraiseTypeKindSet.InEffect);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convAppraiseTypeKindSet.InEffect);
}
}
if (objvAppraiseTypeKindSetCond.IsUpdated(convAppraiseTypeKindSet.UpdDate) == true)
{
string strComparisonOpUpdDate = objvAppraiseTypeKindSetCond.dicFldComparisonOp[convAppraiseTypeKindSet.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppraiseTypeKindSet.UpdDate, objvAppraiseTypeKindSetCond.UpdDate, strComparisonOpUpdDate);
}
if (objvAppraiseTypeKindSetCond.IsUpdated(convAppraiseTypeKindSet.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvAppraiseTypeKindSetCond.dicFldComparisonOp[convAppraiseTypeKindSet.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppraiseTypeKindSet.UpdUserId, objvAppraiseTypeKindSetCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvAppraiseTypeKindSetCond.IsUpdated(convAppraiseTypeKindSet.Memo) == true)
{
string strComparisonOpMemo = objvAppraiseTypeKindSetCond.dicFldComparisonOp[convAppraiseTypeKindSet.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convAppraiseTypeKindSet.Memo, objvAppraiseTypeKindSetCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vAppraiseTypeKindSet
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v评议类型种类设置(vAppraiseTypeKindSet)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvAppraiseTypeKindSetBL
{
public static RelatedActions_vAppraiseTypeKindSet relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvAppraiseTypeKindSetDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvAppraiseTypeKindSetDA vAppraiseTypeKindSetDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvAppraiseTypeKindSetDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvAppraiseTypeKindSetBL()
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
if (string.IsNullOrEmpty(clsvAppraiseTypeKindSetEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvAppraiseTypeKindSetEN._ConnectString);
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
public static DataTable GetDataTable_vAppraiseTypeKindSet(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vAppraiseTypeKindSetDA.GetDataTable_vAppraiseTypeKindSet(strWhereCond);
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
objDT = vAppraiseTypeKindSetDA.GetDataTable(strWhereCond);
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
objDT = vAppraiseTypeKindSetDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vAppraiseTypeKindSetDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vAppraiseTypeKindSetDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vAppraiseTypeKindSetDA.GetDataTable_Top(objTopPara);
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
objDT = vAppraiseTypeKindSetDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vAppraiseTypeKindSetDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vAppraiseTypeKindSetDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvAppraiseTypeKindSetEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvAppraiseTypeKindSetEN> arrObjLst = new List<clsvAppraiseTypeKindSetEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMIdLst);
 string strWhereCond = string.Format("mId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN = new clsvAppraiseTypeKindSetEN();
try
{
objvAppraiseTypeKindSetEN.mId = Int32.Parse(objRow[convAppraiseTypeKindSet.mId].ToString().Trim()); //mId
objvAppraiseTypeKindSetEN.IdSchool = objRow[convAppraiseTypeKindSet.IdSchool] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.IdSchool].ToString().Trim(); //学校流水号
objvAppraiseTypeKindSetEN.SchoolId = objRow[convAppraiseTypeKindSet.SchoolId].ToString().Trim(); //学校编号
objvAppraiseTypeKindSetEN.SchoolName = objRow[convAppraiseTypeKindSet.SchoolName].ToString().Trim(); //学校名称
objvAppraiseTypeKindSetEN.FuncModuleId = objRow[convAppraiseTypeKindSet.FuncModuleId].ToString().Trim(); //功能模块Id
objvAppraiseTypeKindSetEN.FuncModuleName = objRow[convAppraiseTypeKindSet.FuncModuleName] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.FuncModuleName].ToString().Trim(); //功能模块名称
objvAppraiseTypeKindSetEN.FuncModuleNameSim = objRow[convAppraiseTypeKindSet.FuncModuleNameSim] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvAppraiseTypeKindSetEN.IdAppraiseType = objRow[convAppraiseTypeKindSet.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvAppraiseTypeKindSetEN.AppraiseTypeName = objRow[convAppraiseTypeKindSet.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvAppraiseTypeKindSetEN.AppraiseKindId = objRow[convAppraiseTypeKindSet.AppraiseKindId].ToString().Trim(); //评议种类Id
objvAppraiseTypeKindSetEN.AppraiseKindName = objRow[convAppraiseTypeKindSet.AppraiseKindName].ToString().Trim(); //评议种类名
objvAppraiseTypeKindSetEN.InEffect = clsEntityBase2.TransNullToBool_S(objRow[convAppraiseTypeKindSet.InEffect].ToString().Trim()); //是否有效
objvAppraiseTypeKindSetEN.UpdDate = objRow[convAppraiseTypeKindSet.UpdDate] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.UpdDate].ToString().Trim(); //修改日期
objvAppraiseTypeKindSetEN.UpdUserId = objRow[convAppraiseTypeKindSet.UpdUserId] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.UpdUserId].ToString().Trim(); //修改用户Id
objvAppraiseTypeKindSetEN.Memo = objRow[convAppraiseTypeKindSet.Memo] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvAppraiseTypeKindSetEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvAppraiseTypeKindSetEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvAppraiseTypeKindSetEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvAppraiseTypeKindSetEN._CurrTabName);
List<clsvAppraiseTypeKindSetEN> arrvAppraiseTypeKindSetObjLstCache = GetObjLstCache();
IEnumerable <clsvAppraiseTypeKindSetEN> arrvAppraiseTypeKindSetObjLst_Sel =
arrvAppraiseTypeKindSetObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvAppraiseTypeKindSetObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvAppraiseTypeKindSetEN> GetObjLst(string strWhereCond)
{
List<clsvAppraiseTypeKindSetEN> arrObjLst = new List<clsvAppraiseTypeKindSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN = new clsvAppraiseTypeKindSetEN();
try
{
objvAppraiseTypeKindSetEN.mId = Int32.Parse(objRow[convAppraiseTypeKindSet.mId].ToString().Trim()); //mId
objvAppraiseTypeKindSetEN.IdSchool = objRow[convAppraiseTypeKindSet.IdSchool] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.IdSchool].ToString().Trim(); //学校流水号
objvAppraiseTypeKindSetEN.SchoolId = objRow[convAppraiseTypeKindSet.SchoolId].ToString().Trim(); //学校编号
objvAppraiseTypeKindSetEN.SchoolName = objRow[convAppraiseTypeKindSet.SchoolName].ToString().Trim(); //学校名称
objvAppraiseTypeKindSetEN.FuncModuleId = objRow[convAppraiseTypeKindSet.FuncModuleId].ToString().Trim(); //功能模块Id
objvAppraiseTypeKindSetEN.FuncModuleName = objRow[convAppraiseTypeKindSet.FuncModuleName] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.FuncModuleName].ToString().Trim(); //功能模块名称
objvAppraiseTypeKindSetEN.FuncModuleNameSim = objRow[convAppraiseTypeKindSet.FuncModuleNameSim] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvAppraiseTypeKindSetEN.IdAppraiseType = objRow[convAppraiseTypeKindSet.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvAppraiseTypeKindSetEN.AppraiseTypeName = objRow[convAppraiseTypeKindSet.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvAppraiseTypeKindSetEN.AppraiseKindId = objRow[convAppraiseTypeKindSet.AppraiseKindId].ToString().Trim(); //评议种类Id
objvAppraiseTypeKindSetEN.AppraiseKindName = objRow[convAppraiseTypeKindSet.AppraiseKindName].ToString().Trim(); //评议种类名
objvAppraiseTypeKindSetEN.InEffect = clsEntityBase2.TransNullToBool_S(objRow[convAppraiseTypeKindSet.InEffect].ToString().Trim()); //是否有效
objvAppraiseTypeKindSetEN.UpdDate = objRow[convAppraiseTypeKindSet.UpdDate] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.UpdDate].ToString().Trim(); //修改日期
objvAppraiseTypeKindSetEN.UpdUserId = objRow[convAppraiseTypeKindSet.UpdUserId] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.UpdUserId].ToString().Trim(); //修改用户Id
objvAppraiseTypeKindSetEN.Memo = objRow[convAppraiseTypeKindSet.Memo] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvAppraiseTypeKindSetEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvAppraiseTypeKindSetEN);
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
public static List<clsvAppraiseTypeKindSetEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvAppraiseTypeKindSetEN> arrObjLst = new List<clsvAppraiseTypeKindSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN = new clsvAppraiseTypeKindSetEN();
try
{
objvAppraiseTypeKindSetEN.mId = Int32.Parse(objRow[convAppraiseTypeKindSet.mId].ToString().Trim()); //mId
objvAppraiseTypeKindSetEN.IdSchool = objRow[convAppraiseTypeKindSet.IdSchool] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.IdSchool].ToString().Trim(); //学校流水号
objvAppraiseTypeKindSetEN.SchoolId = objRow[convAppraiseTypeKindSet.SchoolId].ToString().Trim(); //学校编号
objvAppraiseTypeKindSetEN.SchoolName = objRow[convAppraiseTypeKindSet.SchoolName].ToString().Trim(); //学校名称
objvAppraiseTypeKindSetEN.FuncModuleId = objRow[convAppraiseTypeKindSet.FuncModuleId].ToString().Trim(); //功能模块Id
objvAppraiseTypeKindSetEN.FuncModuleName = objRow[convAppraiseTypeKindSet.FuncModuleName] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.FuncModuleName].ToString().Trim(); //功能模块名称
objvAppraiseTypeKindSetEN.FuncModuleNameSim = objRow[convAppraiseTypeKindSet.FuncModuleNameSim] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvAppraiseTypeKindSetEN.IdAppraiseType = objRow[convAppraiseTypeKindSet.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvAppraiseTypeKindSetEN.AppraiseTypeName = objRow[convAppraiseTypeKindSet.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvAppraiseTypeKindSetEN.AppraiseKindId = objRow[convAppraiseTypeKindSet.AppraiseKindId].ToString().Trim(); //评议种类Id
objvAppraiseTypeKindSetEN.AppraiseKindName = objRow[convAppraiseTypeKindSet.AppraiseKindName].ToString().Trim(); //评议种类名
objvAppraiseTypeKindSetEN.InEffect = clsEntityBase2.TransNullToBool_S(objRow[convAppraiseTypeKindSet.InEffect].ToString().Trim()); //是否有效
objvAppraiseTypeKindSetEN.UpdDate = objRow[convAppraiseTypeKindSet.UpdDate] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.UpdDate].ToString().Trim(); //修改日期
objvAppraiseTypeKindSetEN.UpdUserId = objRow[convAppraiseTypeKindSet.UpdUserId] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.UpdUserId].ToString().Trim(); //修改用户Id
objvAppraiseTypeKindSetEN.Memo = objRow[convAppraiseTypeKindSet.Memo] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvAppraiseTypeKindSetEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvAppraiseTypeKindSetEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvAppraiseTypeKindSetCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvAppraiseTypeKindSetEN> GetSubObjLstCache(clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetCond)
{
List<clsvAppraiseTypeKindSetEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvAppraiseTypeKindSetEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convAppraiseTypeKindSet.AttributeName)
{
if (objvAppraiseTypeKindSetCond.IsUpdated(strFldName) == false) continue;
if (objvAppraiseTypeKindSetCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvAppraiseTypeKindSetCond[strFldName].ToString());
}
else
{
if (objvAppraiseTypeKindSetCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvAppraiseTypeKindSetCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvAppraiseTypeKindSetCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvAppraiseTypeKindSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvAppraiseTypeKindSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvAppraiseTypeKindSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvAppraiseTypeKindSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvAppraiseTypeKindSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvAppraiseTypeKindSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvAppraiseTypeKindSetCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvAppraiseTypeKindSetCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvAppraiseTypeKindSetCond[strFldName]));
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
public static List<clsvAppraiseTypeKindSetEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvAppraiseTypeKindSetEN> arrObjLst = new List<clsvAppraiseTypeKindSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN = new clsvAppraiseTypeKindSetEN();
try
{
objvAppraiseTypeKindSetEN.mId = Int32.Parse(objRow[convAppraiseTypeKindSet.mId].ToString().Trim()); //mId
objvAppraiseTypeKindSetEN.IdSchool = objRow[convAppraiseTypeKindSet.IdSchool] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.IdSchool].ToString().Trim(); //学校流水号
objvAppraiseTypeKindSetEN.SchoolId = objRow[convAppraiseTypeKindSet.SchoolId].ToString().Trim(); //学校编号
objvAppraiseTypeKindSetEN.SchoolName = objRow[convAppraiseTypeKindSet.SchoolName].ToString().Trim(); //学校名称
objvAppraiseTypeKindSetEN.FuncModuleId = objRow[convAppraiseTypeKindSet.FuncModuleId].ToString().Trim(); //功能模块Id
objvAppraiseTypeKindSetEN.FuncModuleName = objRow[convAppraiseTypeKindSet.FuncModuleName] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.FuncModuleName].ToString().Trim(); //功能模块名称
objvAppraiseTypeKindSetEN.FuncModuleNameSim = objRow[convAppraiseTypeKindSet.FuncModuleNameSim] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvAppraiseTypeKindSetEN.IdAppraiseType = objRow[convAppraiseTypeKindSet.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvAppraiseTypeKindSetEN.AppraiseTypeName = objRow[convAppraiseTypeKindSet.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvAppraiseTypeKindSetEN.AppraiseKindId = objRow[convAppraiseTypeKindSet.AppraiseKindId].ToString().Trim(); //评议种类Id
objvAppraiseTypeKindSetEN.AppraiseKindName = objRow[convAppraiseTypeKindSet.AppraiseKindName].ToString().Trim(); //评议种类名
objvAppraiseTypeKindSetEN.InEffect = clsEntityBase2.TransNullToBool_S(objRow[convAppraiseTypeKindSet.InEffect].ToString().Trim()); //是否有效
objvAppraiseTypeKindSetEN.UpdDate = objRow[convAppraiseTypeKindSet.UpdDate] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.UpdDate].ToString().Trim(); //修改日期
objvAppraiseTypeKindSetEN.UpdUserId = objRow[convAppraiseTypeKindSet.UpdUserId] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.UpdUserId].ToString().Trim(); //修改用户Id
objvAppraiseTypeKindSetEN.Memo = objRow[convAppraiseTypeKindSet.Memo] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvAppraiseTypeKindSetEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvAppraiseTypeKindSetEN);
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
public static List<clsvAppraiseTypeKindSetEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvAppraiseTypeKindSetEN> arrObjLst = new List<clsvAppraiseTypeKindSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN = new clsvAppraiseTypeKindSetEN();
try
{
objvAppraiseTypeKindSetEN.mId = Int32.Parse(objRow[convAppraiseTypeKindSet.mId].ToString().Trim()); //mId
objvAppraiseTypeKindSetEN.IdSchool = objRow[convAppraiseTypeKindSet.IdSchool] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.IdSchool].ToString().Trim(); //学校流水号
objvAppraiseTypeKindSetEN.SchoolId = objRow[convAppraiseTypeKindSet.SchoolId].ToString().Trim(); //学校编号
objvAppraiseTypeKindSetEN.SchoolName = objRow[convAppraiseTypeKindSet.SchoolName].ToString().Trim(); //学校名称
objvAppraiseTypeKindSetEN.FuncModuleId = objRow[convAppraiseTypeKindSet.FuncModuleId].ToString().Trim(); //功能模块Id
objvAppraiseTypeKindSetEN.FuncModuleName = objRow[convAppraiseTypeKindSet.FuncModuleName] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.FuncModuleName].ToString().Trim(); //功能模块名称
objvAppraiseTypeKindSetEN.FuncModuleNameSim = objRow[convAppraiseTypeKindSet.FuncModuleNameSim] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvAppraiseTypeKindSetEN.IdAppraiseType = objRow[convAppraiseTypeKindSet.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvAppraiseTypeKindSetEN.AppraiseTypeName = objRow[convAppraiseTypeKindSet.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvAppraiseTypeKindSetEN.AppraiseKindId = objRow[convAppraiseTypeKindSet.AppraiseKindId].ToString().Trim(); //评议种类Id
objvAppraiseTypeKindSetEN.AppraiseKindName = objRow[convAppraiseTypeKindSet.AppraiseKindName].ToString().Trim(); //评议种类名
objvAppraiseTypeKindSetEN.InEffect = clsEntityBase2.TransNullToBool_S(objRow[convAppraiseTypeKindSet.InEffect].ToString().Trim()); //是否有效
objvAppraiseTypeKindSetEN.UpdDate = objRow[convAppraiseTypeKindSet.UpdDate] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.UpdDate].ToString().Trim(); //修改日期
objvAppraiseTypeKindSetEN.UpdUserId = objRow[convAppraiseTypeKindSet.UpdUserId] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.UpdUserId].ToString().Trim(); //修改用户Id
objvAppraiseTypeKindSetEN.Memo = objRow[convAppraiseTypeKindSet.Memo] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvAppraiseTypeKindSetEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvAppraiseTypeKindSetEN);
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
List<clsvAppraiseTypeKindSetEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvAppraiseTypeKindSetEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvAppraiseTypeKindSetEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvAppraiseTypeKindSetEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvAppraiseTypeKindSetEN> arrObjLst = new List<clsvAppraiseTypeKindSetEN>(); 
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
	clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN = new clsvAppraiseTypeKindSetEN();
try
{
objvAppraiseTypeKindSetEN.mId = Int32.Parse(objRow[convAppraiseTypeKindSet.mId].ToString().Trim()); //mId
objvAppraiseTypeKindSetEN.IdSchool = objRow[convAppraiseTypeKindSet.IdSchool] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.IdSchool].ToString().Trim(); //学校流水号
objvAppraiseTypeKindSetEN.SchoolId = objRow[convAppraiseTypeKindSet.SchoolId].ToString().Trim(); //学校编号
objvAppraiseTypeKindSetEN.SchoolName = objRow[convAppraiseTypeKindSet.SchoolName].ToString().Trim(); //学校名称
objvAppraiseTypeKindSetEN.FuncModuleId = objRow[convAppraiseTypeKindSet.FuncModuleId].ToString().Trim(); //功能模块Id
objvAppraiseTypeKindSetEN.FuncModuleName = objRow[convAppraiseTypeKindSet.FuncModuleName] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.FuncModuleName].ToString().Trim(); //功能模块名称
objvAppraiseTypeKindSetEN.FuncModuleNameSim = objRow[convAppraiseTypeKindSet.FuncModuleNameSim] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvAppraiseTypeKindSetEN.IdAppraiseType = objRow[convAppraiseTypeKindSet.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvAppraiseTypeKindSetEN.AppraiseTypeName = objRow[convAppraiseTypeKindSet.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvAppraiseTypeKindSetEN.AppraiseKindId = objRow[convAppraiseTypeKindSet.AppraiseKindId].ToString().Trim(); //评议种类Id
objvAppraiseTypeKindSetEN.AppraiseKindName = objRow[convAppraiseTypeKindSet.AppraiseKindName].ToString().Trim(); //评议种类名
objvAppraiseTypeKindSetEN.InEffect = clsEntityBase2.TransNullToBool_S(objRow[convAppraiseTypeKindSet.InEffect].ToString().Trim()); //是否有效
objvAppraiseTypeKindSetEN.UpdDate = objRow[convAppraiseTypeKindSet.UpdDate] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.UpdDate].ToString().Trim(); //修改日期
objvAppraiseTypeKindSetEN.UpdUserId = objRow[convAppraiseTypeKindSet.UpdUserId] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.UpdUserId].ToString().Trim(); //修改用户Id
objvAppraiseTypeKindSetEN.Memo = objRow[convAppraiseTypeKindSet.Memo] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvAppraiseTypeKindSetEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvAppraiseTypeKindSetEN);
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
public static List<clsvAppraiseTypeKindSetEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvAppraiseTypeKindSetEN> arrObjLst = new List<clsvAppraiseTypeKindSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN = new clsvAppraiseTypeKindSetEN();
try
{
objvAppraiseTypeKindSetEN.mId = Int32.Parse(objRow[convAppraiseTypeKindSet.mId].ToString().Trim()); //mId
objvAppraiseTypeKindSetEN.IdSchool = objRow[convAppraiseTypeKindSet.IdSchool] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.IdSchool].ToString().Trim(); //学校流水号
objvAppraiseTypeKindSetEN.SchoolId = objRow[convAppraiseTypeKindSet.SchoolId].ToString().Trim(); //学校编号
objvAppraiseTypeKindSetEN.SchoolName = objRow[convAppraiseTypeKindSet.SchoolName].ToString().Trim(); //学校名称
objvAppraiseTypeKindSetEN.FuncModuleId = objRow[convAppraiseTypeKindSet.FuncModuleId].ToString().Trim(); //功能模块Id
objvAppraiseTypeKindSetEN.FuncModuleName = objRow[convAppraiseTypeKindSet.FuncModuleName] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.FuncModuleName].ToString().Trim(); //功能模块名称
objvAppraiseTypeKindSetEN.FuncModuleNameSim = objRow[convAppraiseTypeKindSet.FuncModuleNameSim] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvAppraiseTypeKindSetEN.IdAppraiseType = objRow[convAppraiseTypeKindSet.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvAppraiseTypeKindSetEN.AppraiseTypeName = objRow[convAppraiseTypeKindSet.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvAppraiseTypeKindSetEN.AppraiseKindId = objRow[convAppraiseTypeKindSet.AppraiseKindId].ToString().Trim(); //评议种类Id
objvAppraiseTypeKindSetEN.AppraiseKindName = objRow[convAppraiseTypeKindSet.AppraiseKindName].ToString().Trim(); //评议种类名
objvAppraiseTypeKindSetEN.InEffect = clsEntityBase2.TransNullToBool_S(objRow[convAppraiseTypeKindSet.InEffect].ToString().Trim()); //是否有效
objvAppraiseTypeKindSetEN.UpdDate = objRow[convAppraiseTypeKindSet.UpdDate] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.UpdDate].ToString().Trim(); //修改日期
objvAppraiseTypeKindSetEN.UpdUserId = objRow[convAppraiseTypeKindSet.UpdUserId] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.UpdUserId].ToString().Trim(); //修改用户Id
objvAppraiseTypeKindSetEN.Memo = objRow[convAppraiseTypeKindSet.Memo] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvAppraiseTypeKindSetEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvAppraiseTypeKindSetEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvAppraiseTypeKindSetEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvAppraiseTypeKindSetEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvAppraiseTypeKindSetEN> arrObjLst = new List<clsvAppraiseTypeKindSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN = new clsvAppraiseTypeKindSetEN();
try
{
objvAppraiseTypeKindSetEN.mId = Int32.Parse(objRow[convAppraiseTypeKindSet.mId].ToString().Trim()); //mId
objvAppraiseTypeKindSetEN.IdSchool = objRow[convAppraiseTypeKindSet.IdSchool] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.IdSchool].ToString().Trim(); //学校流水号
objvAppraiseTypeKindSetEN.SchoolId = objRow[convAppraiseTypeKindSet.SchoolId].ToString().Trim(); //学校编号
objvAppraiseTypeKindSetEN.SchoolName = objRow[convAppraiseTypeKindSet.SchoolName].ToString().Trim(); //学校名称
objvAppraiseTypeKindSetEN.FuncModuleId = objRow[convAppraiseTypeKindSet.FuncModuleId].ToString().Trim(); //功能模块Id
objvAppraiseTypeKindSetEN.FuncModuleName = objRow[convAppraiseTypeKindSet.FuncModuleName] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.FuncModuleName].ToString().Trim(); //功能模块名称
objvAppraiseTypeKindSetEN.FuncModuleNameSim = objRow[convAppraiseTypeKindSet.FuncModuleNameSim] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvAppraiseTypeKindSetEN.IdAppraiseType = objRow[convAppraiseTypeKindSet.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvAppraiseTypeKindSetEN.AppraiseTypeName = objRow[convAppraiseTypeKindSet.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvAppraiseTypeKindSetEN.AppraiseKindId = objRow[convAppraiseTypeKindSet.AppraiseKindId].ToString().Trim(); //评议种类Id
objvAppraiseTypeKindSetEN.AppraiseKindName = objRow[convAppraiseTypeKindSet.AppraiseKindName].ToString().Trim(); //评议种类名
objvAppraiseTypeKindSetEN.InEffect = clsEntityBase2.TransNullToBool_S(objRow[convAppraiseTypeKindSet.InEffect].ToString().Trim()); //是否有效
objvAppraiseTypeKindSetEN.UpdDate = objRow[convAppraiseTypeKindSet.UpdDate] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.UpdDate].ToString().Trim(); //修改日期
objvAppraiseTypeKindSetEN.UpdUserId = objRow[convAppraiseTypeKindSet.UpdUserId] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.UpdUserId].ToString().Trim(); //修改用户Id
objvAppraiseTypeKindSetEN.Memo = objRow[convAppraiseTypeKindSet.Memo] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvAppraiseTypeKindSetEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvAppraiseTypeKindSetEN);
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
public static List<clsvAppraiseTypeKindSetEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvAppraiseTypeKindSetEN> arrObjLst = new List<clsvAppraiseTypeKindSetEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN = new clsvAppraiseTypeKindSetEN();
try
{
objvAppraiseTypeKindSetEN.mId = Int32.Parse(objRow[convAppraiseTypeKindSet.mId].ToString().Trim()); //mId
objvAppraiseTypeKindSetEN.IdSchool = objRow[convAppraiseTypeKindSet.IdSchool] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.IdSchool].ToString().Trim(); //学校流水号
objvAppraiseTypeKindSetEN.SchoolId = objRow[convAppraiseTypeKindSet.SchoolId].ToString().Trim(); //学校编号
objvAppraiseTypeKindSetEN.SchoolName = objRow[convAppraiseTypeKindSet.SchoolName].ToString().Trim(); //学校名称
objvAppraiseTypeKindSetEN.FuncModuleId = objRow[convAppraiseTypeKindSet.FuncModuleId].ToString().Trim(); //功能模块Id
objvAppraiseTypeKindSetEN.FuncModuleName = objRow[convAppraiseTypeKindSet.FuncModuleName] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.FuncModuleName].ToString().Trim(); //功能模块名称
objvAppraiseTypeKindSetEN.FuncModuleNameSim = objRow[convAppraiseTypeKindSet.FuncModuleNameSim] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvAppraiseTypeKindSetEN.IdAppraiseType = objRow[convAppraiseTypeKindSet.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvAppraiseTypeKindSetEN.AppraiseTypeName = objRow[convAppraiseTypeKindSet.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvAppraiseTypeKindSetEN.AppraiseKindId = objRow[convAppraiseTypeKindSet.AppraiseKindId].ToString().Trim(); //评议种类Id
objvAppraiseTypeKindSetEN.AppraiseKindName = objRow[convAppraiseTypeKindSet.AppraiseKindName].ToString().Trim(); //评议种类名
objvAppraiseTypeKindSetEN.InEffect = clsEntityBase2.TransNullToBool_S(objRow[convAppraiseTypeKindSet.InEffect].ToString().Trim()); //是否有效
objvAppraiseTypeKindSetEN.UpdDate = objRow[convAppraiseTypeKindSet.UpdDate] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.UpdDate].ToString().Trim(); //修改日期
objvAppraiseTypeKindSetEN.UpdUserId = objRow[convAppraiseTypeKindSet.UpdUserId] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.UpdUserId].ToString().Trim(); //修改用户Id
objvAppraiseTypeKindSetEN.Memo = objRow[convAppraiseTypeKindSet.Memo] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvAppraiseTypeKindSetEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvAppraiseTypeKindSetEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvAppraiseTypeKindSetEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvAppraiseTypeKindSetEN> arrObjLst = new List<clsvAppraiseTypeKindSetEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN = new clsvAppraiseTypeKindSetEN();
try
{
objvAppraiseTypeKindSetEN.mId = Int32.Parse(objRow[convAppraiseTypeKindSet.mId].ToString().Trim()); //mId
objvAppraiseTypeKindSetEN.IdSchool = objRow[convAppraiseTypeKindSet.IdSchool] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.IdSchool].ToString().Trim(); //学校流水号
objvAppraiseTypeKindSetEN.SchoolId = objRow[convAppraiseTypeKindSet.SchoolId].ToString().Trim(); //学校编号
objvAppraiseTypeKindSetEN.SchoolName = objRow[convAppraiseTypeKindSet.SchoolName].ToString().Trim(); //学校名称
objvAppraiseTypeKindSetEN.FuncModuleId = objRow[convAppraiseTypeKindSet.FuncModuleId].ToString().Trim(); //功能模块Id
objvAppraiseTypeKindSetEN.FuncModuleName = objRow[convAppraiseTypeKindSet.FuncModuleName] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.FuncModuleName].ToString().Trim(); //功能模块名称
objvAppraiseTypeKindSetEN.FuncModuleNameSim = objRow[convAppraiseTypeKindSet.FuncModuleNameSim] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvAppraiseTypeKindSetEN.IdAppraiseType = objRow[convAppraiseTypeKindSet.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvAppraiseTypeKindSetEN.AppraiseTypeName = objRow[convAppraiseTypeKindSet.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvAppraiseTypeKindSetEN.AppraiseKindId = objRow[convAppraiseTypeKindSet.AppraiseKindId].ToString().Trim(); //评议种类Id
objvAppraiseTypeKindSetEN.AppraiseKindName = objRow[convAppraiseTypeKindSet.AppraiseKindName].ToString().Trim(); //评议种类名
objvAppraiseTypeKindSetEN.InEffect = clsEntityBase2.TransNullToBool_S(objRow[convAppraiseTypeKindSet.InEffect].ToString().Trim()); //是否有效
objvAppraiseTypeKindSetEN.UpdDate = objRow[convAppraiseTypeKindSet.UpdDate] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.UpdDate].ToString().Trim(); //修改日期
objvAppraiseTypeKindSetEN.UpdUserId = objRow[convAppraiseTypeKindSet.UpdUserId] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.UpdUserId].ToString().Trim(); //修改用户Id
objvAppraiseTypeKindSetEN.Memo = objRow[convAppraiseTypeKindSet.Memo] == DBNull.Value ? null : objRow[convAppraiseTypeKindSet.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvAppraiseTypeKindSetEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvAppraiseTypeKindSetEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvAppraiseTypeKindSetEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvAppraiseTypeKindSet(ref clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN)
{
bool bolResult = vAppraiseTypeKindSetDA.GetvAppraiseTypeKindSet(ref objvAppraiseTypeKindSetEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvAppraiseTypeKindSetEN GetObjBymId(long lngmId)
{
clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN = vAppraiseTypeKindSetDA.GetObjBymId(lngmId);
return objvAppraiseTypeKindSetEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvAppraiseTypeKindSetEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN = vAppraiseTypeKindSetDA.GetFirstObj(strWhereCond);
 return objvAppraiseTypeKindSetEN;
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
public static clsvAppraiseTypeKindSetEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN = vAppraiseTypeKindSetDA.GetObjByDataRow(objRow);
 return objvAppraiseTypeKindSetEN;
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
public static clsvAppraiseTypeKindSetEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN = vAppraiseTypeKindSetDA.GetObjByDataRow(objRow);
 return objvAppraiseTypeKindSetEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "lstvAppraiseTypeKindSetObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvAppraiseTypeKindSetEN GetObjBymIdFromList(long lngmId, List<clsvAppraiseTypeKindSetEN> lstvAppraiseTypeKindSetObjLst)
{
foreach (clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN in lstvAppraiseTypeKindSetObjLst)
{
if (objvAppraiseTypeKindSetEN.mId == lngmId)
{
return objvAppraiseTypeKindSetEN;
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
public static long GetFirstID_S(string strWhereCond) 
{
 long lngmId;
 try
 {
 lngmId = new clsvAppraiseTypeKindSetDA().GetFirstID(strWhereCond);
 return lngmId;
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
 arrList = vAppraiseTypeKindSetDA.GetID(strWhereCond);
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
bool bolIsExist = vAppraiseTypeKindSetDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
bool bolIsExist = vAppraiseTypeKindSetDA.IsExist(lngmId);
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
 bolIsExist = clsvAppraiseTypeKindSetDA.IsExistTable();
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
 bolIsExist = vAppraiseTypeKindSetDA.IsExistTable(strTabName);
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
 /// <param name = "objvAppraiseTypeKindSetENS">源对象</param>
 /// <param name = "objvAppraiseTypeKindSetENT">目标对象</param>
 public static void CopyTo(clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetENS, clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetENT)
{
try
{
objvAppraiseTypeKindSetENT.mId = objvAppraiseTypeKindSetENS.mId; //mId
objvAppraiseTypeKindSetENT.IdSchool = objvAppraiseTypeKindSetENS.IdSchool; //学校流水号
objvAppraiseTypeKindSetENT.SchoolId = objvAppraiseTypeKindSetENS.SchoolId; //学校编号
objvAppraiseTypeKindSetENT.SchoolName = objvAppraiseTypeKindSetENS.SchoolName; //学校名称
objvAppraiseTypeKindSetENT.FuncModuleId = objvAppraiseTypeKindSetENS.FuncModuleId; //功能模块Id
objvAppraiseTypeKindSetENT.FuncModuleName = objvAppraiseTypeKindSetENS.FuncModuleName; //功能模块名称
objvAppraiseTypeKindSetENT.FuncModuleNameSim = objvAppraiseTypeKindSetENS.FuncModuleNameSim; //功能模块简称
objvAppraiseTypeKindSetENT.IdAppraiseType = objvAppraiseTypeKindSetENS.IdAppraiseType; //评议类型流水号
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
 /// <param name = "objvAppraiseTypeKindSetEN">源简化对象</param>
 public static void SetUpdFlag(clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN)
{
try
{
objvAppraiseTypeKindSetEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvAppraiseTypeKindSetEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convAppraiseTypeKindSet.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvAppraiseTypeKindSetEN.mId = objvAppraiseTypeKindSetEN.mId; //mId
}
if (arrFldSet.Contains(convAppraiseTypeKindSet.IdSchool, new clsStrCompareIgnoreCase())  ==  true)
{
objvAppraiseTypeKindSetEN.IdSchool = objvAppraiseTypeKindSetEN.IdSchool == "[null]" ? null :  objvAppraiseTypeKindSetEN.IdSchool; //学校流水号
}
if (arrFldSet.Contains(convAppraiseTypeKindSet.SchoolId, new clsStrCompareIgnoreCase())  ==  true)
{
objvAppraiseTypeKindSetEN.SchoolId = objvAppraiseTypeKindSetEN.SchoolId; //学校编号
}
if (arrFldSet.Contains(convAppraiseTypeKindSet.SchoolName, new clsStrCompareIgnoreCase())  ==  true)
{
objvAppraiseTypeKindSetEN.SchoolName = objvAppraiseTypeKindSetEN.SchoolName; //学校名称
}
if (arrFldSet.Contains(convAppraiseTypeKindSet.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvAppraiseTypeKindSetEN.FuncModuleId = objvAppraiseTypeKindSetEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(convAppraiseTypeKindSet.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvAppraiseTypeKindSetEN.FuncModuleName = objvAppraiseTypeKindSetEN.FuncModuleName == "[null]" ? null :  objvAppraiseTypeKindSetEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convAppraiseTypeKindSet.FuncModuleNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvAppraiseTypeKindSetEN.FuncModuleNameSim = objvAppraiseTypeKindSetEN.FuncModuleNameSim == "[null]" ? null :  objvAppraiseTypeKindSetEN.FuncModuleNameSim; //功能模块简称
}
if (arrFldSet.Contains(convAppraiseTypeKindSet.IdAppraiseType, new clsStrCompareIgnoreCase())  ==  true)
{
objvAppraiseTypeKindSetEN.IdAppraiseType = objvAppraiseTypeKindSetEN.IdAppraiseType; //评议类型流水号
}
if (arrFldSet.Contains(convAppraiseTypeKindSet.AppraiseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvAppraiseTypeKindSetEN.AppraiseTypeName = objvAppraiseTypeKindSetEN.AppraiseTypeName; //评议类型名称
}
if (arrFldSet.Contains(convAppraiseTypeKindSet.AppraiseKindId, new clsStrCompareIgnoreCase())  ==  true)
{
objvAppraiseTypeKindSetEN.AppraiseKindId = objvAppraiseTypeKindSetEN.AppraiseKindId; //评议种类Id
}
if (arrFldSet.Contains(convAppraiseTypeKindSet.AppraiseKindName, new clsStrCompareIgnoreCase())  ==  true)
{
objvAppraiseTypeKindSetEN.AppraiseKindName = objvAppraiseTypeKindSetEN.AppraiseKindName; //评议种类名
}
if (arrFldSet.Contains(convAppraiseTypeKindSet.InEffect, new clsStrCompareIgnoreCase())  ==  true)
{
objvAppraiseTypeKindSetEN.InEffect = objvAppraiseTypeKindSetEN.InEffect; //是否有效
}
if (arrFldSet.Contains(convAppraiseTypeKindSet.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvAppraiseTypeKindSetEN.UpdDate = objvAppraiseTypeKindSetEN.UpdDate == "[null]" ? null :  objvAppraiseTypeKindSetEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convAppraiseTypeKindSet.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvAppraiseTypeKindSetEN.UpdUserId = objvAppraiseTypeKindSetEN.UpdUserId == "[null]" ? null :  objvAppraiseTypeKindSetEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convAppraiseTypeKindSet.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvAppraiseTypeKindSetEN.Memo = objvAppraiseTypeKindSetEN.Memo == "[null]" ? null :  objvAppraiseTypeKindSetEN.Memo; //备注
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
 /// <param name = "objvAppraiseTypeKindSetEN">源简化对象</param>
 public static void AccessFldValueNull(clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN)
{
try
{
if (objvAppraiseTypeKindSetEN.IdSchool == "[null]") objvAppraiseTypeKindSetEN.IdSchool = null; //学校流水号
if (objvAppraiseTypeKindSetEN.FuncModuleName == "[null]") objvAppraiseTypeKindSetEN.FuncModuleName = null; //功能模块名称
if (objvAppraiseTypeKindSetEN.FuncModuleNameSim == "[null]") objvAppraiseTypeKindSetEN.FuncModuleNameSim = null; //功能模块简称
if (objvAppraiseTypeKindSetEN.UpdDate == "[null]") objvAppraiseTypeKindSetEN.UpdDate = null; //修改日期
if (objvAppraiseTypeKindSetEN.UpdUserId == "[null]") objvAppraiseTypeKindSetEN.UpdUserId = null; //修改用户Id
if (objvAppraiseTypeKindSetEN.Memo == "[null]") objvAppraiseTypeKindSetEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetEN)
{
 vAppraiseTypeKindSetDA.CheckProperty4Condition(objvAppraiseTypeKindSetEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框


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
if (clsXzSchoolBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzSchoolBL没有刷新缓存机制(clsXzSchoolBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModuleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleBL没有刷新缓存机制(clsFuncModuleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAppraiseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsAppraiseTypeBL没有刷新缓存机制(clsAppraiseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAppraiseTypeKindSetBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsAppraiseTypeKindSetBL没有刷新缓存机制(clsAppraiseTypeKindSetBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAppraiseKindBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsAppraiseKindBL没有刷新缓存机制(clsAppraiseKindBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvAppraiseTypeKindSetObjLstCache == null)
//{
//arrvAppraiseTypeKindSetObjLstCache = vAppraiseTypeKindSetDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvAppraiseTypeKindSetEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvAppraiseTypeKindSetEN._CurrTabName);
List<clsvAppraiseTypeKindSetEN> arrvAppraiseTypeKindSetObjLstCache = GetObjLstCache();
IEnumerable <clsvAppraiseTypeKindSetEN> arrvAppraiseTypeKindSetObjLst_Sel =
arrvAppraiseTypeKindSetObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvAppraiseTypeKindSetObjLst_Sel.Count() == 0)
{
   clsvAppraiseTypeKindSetEN obj = clsvAppraiseTypeKindSetBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvAppraiseTypeKindSetObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvAppraiseTypeKindSetEN> GetAllvAppraiseTypeKindSetObjLstCache()
{
//获取缓存中的对象列表
List<clsvAppraiseTypeKindSetEN> arrvAppraiseTypeKindSetObjLstCache = GetObjLstCache(); 
return arrvAppraiseTypeKindSetObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvAppraiseTypeKindSetEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvAppraiseTypeKindSetEN._CurrTabName);
List<clsvAppraiseTypeKindSetEN> arrvAppraiseTypeKindSetObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvAppraiseTypeKindSetObjLstCache;
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
string strKey = string.Format("{0}", clsvAppraiseTypeKindSetEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != convAppraiseTypeKindSet.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convAppraiseTypeKindSet.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convAppraiseTypeKindSet.AttributeName));
throw new Exception(strMsg);
}
var objvAppraiseTypeKindSet = clsvAppraiseTypeKindSetBL.GetObjBymIdCache(lngmId);
if (objvAppraiseTypeKindSet == null) return "";
return objvAppraiseTypeKindSet[strOutFldName].ToString();
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
int intRecCount = clsvAppraiseTypeKindSetDA.GetRecCount(strTabName);
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
int intRecCount = clsvAppraiseTypeKindSetDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvAppraiseTypeKindSetDA.GetRecCount();
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
int intRecCount = clsvAppraiseTypeKindSetDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvAppraiseTypeKindSetCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvAppraiseTypeKindSetEN objvAppraiseTypeKindSetCond)
{
List<clsvAppraiseTypeKindSetEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvAppraiseTypeKindSetEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convAppraiseTypeKindSet.AttributeName)
{
if (objvAppraiseTypeKindSetCond.IsUpdated(strFldName) == false) continue;
if (objvAppraiseTypeKindSetCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvAppraiseTypeKindSetCond[strFldName].ToString());
}
else
{
if (objvAppraiseTypeKindSetCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvAppraiseTypeKindSetCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvAppraiseTypeKindSetCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvAppraiseTypeKindSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvAppraiseTypeKindSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvAppraiseTypeKindSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvAppraiseTypeKindSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvAppraiseTypeKindSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvAppraiseTypeKindSetCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvAppraiseTypeKindSetCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvAppraiseTypeKindSetCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvAppraiseTypeKindSetCond[strFldName]));
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
 List<string> arrList = clsvAppraiseTypeKindSetDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vAppraiseTypeKindSetDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vAppraiseTypeKindSetDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}