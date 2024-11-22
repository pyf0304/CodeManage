
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvEduMSTRGiftedClsCaseQuantitySenateWApi
 表名:vEduMSTRGiftedClsCaseQuantitySenate(01120452)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:40:54
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:教育硕士优课点评
 模块英文名:EduMSTRGiftedCls
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
public static class clsvEduMSTRGiftedClsCaseQuantitySenateWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseQuantitySenateEN Setid_microteachCaseQuantitySenate(this clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN, long lngid_microteachCaseQuantitySenate, string strComparisonOp="")
	{
objvEduMSTRGiftedClsCaseQuantitySenateEN.id_microteachCaseQuantitySenate = lngid_microteachCaseQuantitySenate; //微格量化评价流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseQuantitySenate.id_microteachCaseQuantitySenate) == false)
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseQuantitySenate.id_microteachCaseQuantitySenate, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.id_microteachCaseQuantitySenate] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseQuantitySenateEN SetFuncModuleId(this clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleId);
objvEduMSTRGiftedClsCaseQuantitySenateEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleId) == false)
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleId, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleId] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseQuantitySenateEN SetFuncModuleName(this clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleName);
objvEduMSTRGiftedClsCaseQuantitySenateEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleName) == false)
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseQuantitySenateEN Setid_MicroteachCase(this clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCase, convEduMSTRGiftedClsCaseQuantitySenate.id_MicroteachCase);
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convEduMSTRGiftedClsCaseQuantitySenate.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convEduMSTRGiftedClsCaseQuantitySenate.id_MicroteachCase);
objvEduMSTRGiftedClsCaseQuantitySenateEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseQuantitySenate.id_MicroteachCase) == false)
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseQuantitySenate.id_MicroteachCase, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.id_MicroteachCase] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseQuantitySenateEN Setid_EduMSTRGiftedClsCase(this clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN, string strid_EduMSTRGiftedClsCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_EduMSTRGiftedClsCase, 8, convEduMSTRGiftedClsCaseQuantitySenate.id_EduMSTRGiftedClsCase);
clsCheckSql.CheckFieldForeignKey(strid_EduMSTRGiftedClsCase, 8, convEduMSTRGiftedClsCaseQuantitySenate.id_EduMSTRGiftedClsCase);
objvEduMSTRGiftedClsCaseQuantitySenateEN.id_EduMSTRGiftedClsCase = strid_EduMSTRGiftedClsCase; //教育硕士优课案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseQuantitySenate.id_EduMSTRGiftedClsCase) == false)
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseQuantitySenate.id_EduMSTRGiftedClsCase, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.id_EduMSTRGiftedClsCase] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseQuantitySenateEN SetEduMSTRGiftedClsCaseID(this clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN, string strEduMSTRGiftedClsCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseID, 8, convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseID);
clsCheckSql.CheckFieldForeignKey(strEduMSTRGiftedClsCaseID, 8, convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseID);
objvEduMSTRGiftedClsCaseQuantitySenateEN.EduMSTRGiftedClsCaseID = strEduMSTRGiftedClsCaseID; //教育硕士优课案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseID) == false)
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseID, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseID] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseQuantitySenateEN SetEduMSTRGiftedClsCaseName(this clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN, string strEduMSTRGiftedClsCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseName, 100, convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseName);
objvEduMSTRGiftedClsCaseQuantitySenateEN.EduMSTRGiftedClsCaseName = strEduMSTRGiftedClsCaseName; //教育硕士优课案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseName) == false)
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseQuantitySenateEN SetEduMSTRGiftedClsCaseDate(this clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN, string strEduMSTRGiftedClsCaseDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseDate, 8, convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseDate);
clsCheckSql.CheckFieldForeignKey(strEduMSTRGiftedClsCaseDate, 8, convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseDate);
objvEduMSTRGiftedClsCaseQuantitySenateEN.EduMSTRGiftedClsCaseDate = strEduMSTRGiftedClsCaseDate; //教育硕士优课案例日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseDate) == false)
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseDate, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseDate] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseQuantitySenateEN SetEduMSTRGiftedClsCaseTypeName(this clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN, string strEduMSTRGiftedClsCaseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strEduMSTRGiftedClsCaseTypeName, 50, convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseTypeName);
objvEduMSTRGiftedClsCaseQuantitySenateEN.EduMSTRGiftedClsCaseTypeName = strEduMSTRGiftedClsCaseTypeName; //教育硕士优课案例类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseTypeName) == false)
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseTypeName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseTypeName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseQuantitySenateEN SetsenateGaugeVersionTtlScore(this clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN, float fltsenateGaugeVersionTtlScore, string strComparisonOp="")
	{
objvEduMSTRGiftedClsCaseQuantitySenateEN.senateGaugeVersionTtlScore = fltsenateGaugeVersionTtlScore; //评价量表版本总分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionTtlScore) == false)
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionTtlScore, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionTtlScore] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseQuantitySenateEN SetOwnerId(this clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convEduMSTRGiftedClsCaseQuantitySenate.OwnerId);
objvEduMSTRGiftedClsCaseQuantitySenateEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseQuantitySenate.OwnerId) == false)
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseQuantitySenate.OwnerId, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.OwnerId] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseQuantitySenateEN SetStuName(this clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN, string strStuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuName, 50, convEduMSTRGiftedClsCaseQuantitySenate.StuName);
objvEduMSTRGiftedClsCaseQuantitySenateEN.StuName = strStuName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseQuantitySenate.StuName) == false)
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseQuantitySenate.StuName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.StuName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseQuantitySenateEN SetStuID(this clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN, string strStuID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuID, 20, convEduMSTRGiftedClsCaseQuantitySenate.StuID);
objvEduMSTRGiftedClsCaseQuantitySenateEN.StuID = strStuID; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseQuantitySenate.StuID) == false)
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseQuantitySenate.StuID, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.StuID] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseQuantitySenateEN Setid_XzCollege(this clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convEduMSTRGiftedClsCaseQuantitySenate.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convEduMSTRGiftedClsCaseQuantitySenate.id_XzCollege);
objvEduMSTRGiftedClsCaseQuantitySenateEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseQuantitySenate.id_XzCollege) == false)
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseQuantitySenate.id_XzCollege, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.id_XzCollege] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseQuantitySenateEN SetUserKindName(this clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN, string strUserKindName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserKindName, 30, convEduMSTRGiftedClsCaseQuantitySenate.UserKindName);
objvEduMSTRGiftedClsCaseQuantitySenateEN.UserKindName = strUserKindName; //用户类别名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseQuantitySenate.UserKindName) == false)
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseQuantitySenate.UserKindName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.UserKindName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseQuantitySenateEN SetUserTypeName(this clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN, string strUserTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeName, 20, convEduMSTRGiftedClsCaseQuantitySenate.UserTypeName);
objvEduMSTRGiftedClsCaseQuantitySenateEN.UserTypeName = strUserTypeName; //用户类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseQuantitySenate.UserTypeName) == false)
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseQuantitySenate.UserTypeName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.UserTypeName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseQuantitySenateEN SetOwnerName(this clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN, string strOwnerName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerName, 30, convEduMSTRGiftedClsCaseQuantitySenate.OwnerName);
objvEduMSTRGiftedClsCaseQuantitySenateEN.OwnerName = strOwnerName; //拥有者姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseQuantitySenate.OwnerName) == false)
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseQuantitySenate.OwnerName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.OwnerName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseQuantitySenateEN Setid_AppraiseType(this clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN, string strid_AppraiseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_AppraiseType, convEduMSTRGiftedClsCaseQuantitySenate.id_AppraiseType);
clsCheckSql.CheckFieldLen(strid_AppraiseType, 4, convEduMSTRGiftedClsCaseQuantitySenate.id_AppraiseType);
clsCheckSql.CheckFieldForeignKey(strid_AppraiseType, 4, convEduMSTRGiftedClsCaseQuantitySenate.id_AppraiseType);
objvEduMSTRGiftedClsCaseQuantitySenateEN.id_AppraiseType = strid_AppraiseType; //评议类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseQuantitySenate.id_AppraiseType) == false)
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseQuantitySenate.id_AppraiseType, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.id_AppraiseType] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseQuantitySenateEN SetAppraiseTypeName(this clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN, string strAppraiseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAppraiseTypeName, 50, convEduMSTRGiftedClsCaseQuantitySenate.AppraiseTypeName);
objvEduMSTRGiftedClsCaseQuantitySenateEN.AppraiseTypeName = strAppraiseTypeName; //评议类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseQuantitySenate.AppraiseTypeName) == false)
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseQuantitySenate.AppraiseTypeName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.AppraiseTypeName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseQuantitySenateEN SetSenateTheme(this clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN, string strSenateTheme, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateTheme, 200, convEduMSTRGiftedClsCaseQuantitySenate.SenateTheme);
objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateTheme = strSenateTheme; //量化评价主题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseQuantitySenate.SenateTheme) == false)
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseQuantitySenate.SenateTheme, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.SenateTheme] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseQuantitySenateEN SetSenateContent(this clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN, string strSenateContent, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateContent, 2000, convEduMSTRGiftedClsCaseQuantitySenate.SenateContent);
objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateContent = strSenateContent; //评价内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseQuantitySenate.SenateContent) == false)
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseQuantitySenate.SenateContent, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.SenateContent] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseQuantitySenateEN SetSenateTotalScore(this clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN, float fltSenateTotalScore, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(fltSenateTotalScore, convEduMSTRGiftedClsCaseQuantitySenate.SenateTotalScore);
objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateTotalScore = fltSenateTotalScore; //评价分数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseQuantitySenate.SenateTotalScore) == false)
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseQuantitySenate.SenateTotalScore, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.SenateTotalScore] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseQuantitySenateEN SetSenateDate(this clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN, string strSenateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateDate, 8, convEduMSTRGiftedClsCaseQuantitySenate.SenateDate);
clsCheckSql.CheckFieldForeignKey(strSenateDate, 8, convEduMSTRGiftedClsCaseQuantitySenate.SenateDate);
objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateDate = strSenateDate; //评价日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseQuantitySenate.SenateDate) == false)
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseQuantitySenate.SenateDate, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.SenateDate] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseQuantitySenateEN SetSenateTime(this clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN, string strSenateTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateTime, 6, convEduMSTRGiftedClsCaseQuantitySenate.SenateTime);
clsCheckSql.CheckFieldForeignKey(strSenateTime, 6, convEduMSTRGiftedClsCaseQuantitySenate.SenateTime);
objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateTime = strSenateTime; //评价时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseQuantitySenate.SenateTime) == false)
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseQuantitySenate.SenateTime, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.SenateTime] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseQuantitySenateEN SetSenateIp(this clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN, string strSenateIp, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateIp, 50, convEduMSTRGiftedClsCaseQuantitySenate.SenateIp);
objvEduMSTRGiftedClsCaseQuantitySenateEN.SenateIp = strSenateIp; //评议Ip
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseQuantitySenate.SenateIp) == false)
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseQuantitySenate.SenateIp, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.SenateIp] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseQuantitySenateEN SetBrowseCount(this clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN, int intBrowseCount, string strComparisonOp="")
	{
objvEduMSTRGiftedClsCaseQuantitySenateEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseQuantitySenate.BrowseCount) == false)
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseQuantitySenate.BrowseCount, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.BrowseCount] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseQuantitySenateEN Setid_SenateGaugeVersion(this clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN, string strid_SenateGaugeVersion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_SenateGaugeVersion, 4, convEduMSTRGiftedClsCaseQuantitySenate.id_SenateGaugeVersion);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeVersion, 4, convEduMSTRGiftedClsCaseQuantitySenate.id_SenateGaugeVersion);
objvEduMSTRGiftedClsCaseQuantitySenateEN.id_SenateGaugeVersion = strid_SenateGaugeVersion; //评价量表版本流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseQuantitySenate.id_SenateGaugeVersion) == false)
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseQuantitySenate.id_SenateGaugeVersion, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.id_SenateGaugeVersion] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseQuantitySenateEN SetsenateGaugeVersionID(this clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN, string strsenateGaugeVersionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionID, 4, convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionID);
clsCheckSql.CheckFieldForeignKey(strsenateGaugeVersionID, 4, convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionID);
objvEduMSTRGiftedClsCaseQuantitySenateEN.senateGaugeVersionID = strsenateGaugeVersionID; //评价量表版本ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionID) == false)
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionID, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionID] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseQuantitySenateEN SetsenateGaugeVersionName(this clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionName);
objvEduMSTRGiftedClsCaseQuantitySenateEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionName) == false)
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseQuantitySenateEN SetUserId(this clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convEduMSTRGiftedClsCaseQuantitySenate.UserId);
clsCheckSql.CheckFieldLen(strUserId, 20, convEduMSTRGiftedClsCaseQuantitySenate.UserId);
objvEduMSTRGiftedClsCaseQuantitySenateEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseQuantitySenate.UserId) == false)
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseQuantitySenate.UserId, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.UserId] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseQuantitySenateEN SetCollegeID(this clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convEduMSTRGiftedClsCaseQuantitySenate.CollegeID);
objvEduMSTRGiftedClsCaseQuantitySenateEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseQuantitySenate.CollegeID) == false)
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseQuantitySenate.CollegeID, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.CollegeID] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseQuantitySenateEN SetCollegeName(this clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convEduMSTRGiftedClsCaseQuantitySenate.CollegeName);
objvEduMSTRGiftedClsCaseQuantitySenateEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseQuantitySenate.CollegeName) == false)
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseQuantitySenate.CollegeName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.CollegeName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseQuantitySenateEN SetIsLeaved(this clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN, bool bolIsLeaved, string strComparisonOp="")
	{
objvEduMSTRGiftedClsCaseQuantitySenateEN.IsLeaved = bolIsLeaved; //IsLeaved
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseQuantitySenate.IsLeaved) == false)
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseQuantitySenate.IsLeaved, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.IsLeaved] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseQuantitySenateEN SetStuIdTeacherId(this clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN, string strStuIdTeacherId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuIdTeacherId, 20, convEduMSTRGiftedClsCaseQuantitySenate.StuIdTeacherId);
objvEduMSTRGiftedClsCaseQuantitySenateEN.StuIdTeacherId = strStuIdTeacherId; //学工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseQuantitySenate.StuIdTeacherId) == false)
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseQuantitySenate.StuIdTeacherId, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.StuIdTeacherId] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseQuantitySenateEN SetUserNameWithUserId(this clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN, string strUserNameWithUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserNameWithUserId, 51, convEduMSTRGiftedClsCaseQuantitySenate.UserNameWithUserId);
objvEduMSTRGiftedClsCaseQuantitySenateEN.UserNameWithUserId = strUserNameWithUserId; //UserNameWithUserId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseQuantitySenate.UserNameWithUserId) == false)
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseQuantitySenate.UserNameWithUserId, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.UserNameWithUserId] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseQuantitySenateEN SetCollegeNameA(this clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convEduMSTRGiftedClsCaseQuantitySenate.CollegeNameA);
objvEduMSTRGiftedClsCaseQuantitySenateEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseQuantitySenate.CollegeNameA) == false)
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseQuantitySenate.CollegeNameA, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.CollegeNameA] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseQuantitySenateEN SetUserName(this clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserName, 50, convEduMSTRGiftedClsCaseQuantitySenate.UserName);
objvEduMSTRGiftedClsCaseQuantitySenateEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseQuantitySenate.UserName) == false)
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseQuantitySenate.UserName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.UserName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseQuantitySenateEN SetUserKindId(this clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN, string strUserKindId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserKindId, convEduMSTRGiftedClsCaseQuantitySenate.UserKindId);
clsCheckSql.CheckFieldLen(strUserKindId, 2, convEduMSTRGiftedClsCaseQuantitySenate.UserKindId);
clsCheckSql.CheckFieldForeignKey(strUserKindId, 2, convEduMSTRGiftedClsCaseQuantitySenate.UserKindId);
objvEduMSTRGiftedClsCaseQuantitySenateEN.UserKindId = strUserKindId; //用户类别Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseQuantitySenate.UserKindId) == false)
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseQuantitySenate.UserKindId, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.UserKindId] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseQuantitySenateEN SetUserTypeId(this clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN, string strUserTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserTypeId, 2, convEduMSTRGiftedClsCaseQuantitySenate.UserTypeId);
clsCheckSql.CheckFieldForeignKey(strUserTypeId, 2, convEduMSTRGiftedClsCaseQuantitySenate.UserTypeId);
objvEduMSTRGiftedClsCaseQuantitySenateEN.UserTypeId = strUserTypeId; //用户类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseQuantitySenate.UserTypeId) == false)
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseQuantitySenate.UserTypeId, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.UserTypeId] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseQuantitySenateEN SetUpdUser(this clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convEduMSTRGiftedClsCaseQuantitySenate.UpdUser);
objvEduMSTRGiftedClsCaseQuantitySenateEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseQuantitySenate.UpdUser) == false)
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseQuantitySenate.UpdUser, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.UpdUser] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseQuantitySenateEN SetUpdUserName(this clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN, string strUpdUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserName, 20, convEduMSTRGiftedClsCaseQuantitySenate.UpdUserName);
objvEduMSTRGiftedClsCaseQuantitySenateEN.UpdUserName = strUpdUserName; //UpdUserName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseQuantitySenate.UpdUserName) == false)
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseQuantitySenate.UpdUserName, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.UpdUserName] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvEduMSTRGiftedClsCaseQuantitySenateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvEduMSTRGiftedClsCaseQuantitySenateEN SetOwnerNameWithId(this clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN, string strOwnerNameWithId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerNameWithId, 51, convEduMSTRGiftedClsCaseQuantitySenate.OwnerNameWithId);
objvEduMSTRGiftedClsCaseQuantitySenateEN.OwnerNameWithId = strOwnerNameWithId; //拥有者名称附Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.ContainsKey(convEduMSTRGiftedClsCaseQuantitySenate.OwnerNameWithId) == false)
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp.Add(convEduMSTRGiftedClsCaseQuantitySenate.OwnerNameWithId, strComparisonOp);
}
else
{
objvEduMSTRGiftedClsCaseQuantitySenateEN.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.OwnerNameWithId] = strComparisonOp;
}
}
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenate_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvEduMSTRGiftedClsCaseQuantitySenate_Cond.IsUpdated(convEduMSTRGiftedClsCaseQuantitySenate.id_microteachCaseQuantitySenate) == true)
{
string strComparisonOp_id_microteachCaseQuantitySenate = objvEduMSTRGiftedClsCaseQuantitySenate_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.id_microteachCaseQuantitySenate];
strWhereCond += string.Format(" And {0} {2} {1}", convEduMSTRGiftedClsCaseQuantitySenate.id_microteachCaseQuantitySenate, objvEduMSTRGiftedClsCaseQuantitySenate_Cond.id_microteachCaseQuantitySenate, strComparisonOp_id_microteachCaseQuantitySenate);
}
if (objvEduMSTRGiftedClsCaseQuantitySenate_Cond.IsUpdated(convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvEduMSTRGiftedClsCaseQuantitySenate_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleId, objvEduMSTRGiftedClsCaseQuantitySenate_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvEduMSTRGiftedClsCaseQuantitySenate_Cond.IsUpdated(convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvEduMSTRGiftedClsCaseQuantitySenate_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleName, objvEduMSTRGiftedClsCaseQuantitySenate_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvEduMSTRGiftedClsCaseQuantitySenate_Cond.IsUpdated(convEduMSTRGiftedClsCaseQuantitySenate.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvEduMSTRGiftedClsCaseQuantitySenate_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseQuantitySenate.id_MicroteachCase, objvEduMSTRGiftedClsCaseQuantitySenate_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvEduMSTRGiftedClsCaseQuantitySenate_Cond.IsUpdated(convEduMSTRGiftedClsCaseQuantitySenate.id_EduMSTRGiftedClsCase) == true)
{
string strComparisonOp_id_EduMSTRGiftedClsCase = objvEduMSTRGiftedClsCaseQuantitySenate_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.id_EduMSTRGiftedClsCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseQuantitySenate.id_EduMSTRGiftedClsCase, objvEduMSTRGiftedClsCaseQuantitySenate_Cond.id_EduMSTRGiftedClsCase, strComparisonOp_id_EduMSTRGiftedClsCase);
}
if (objvEduMSTRGiftedClsCaseQuantitySenate_Cond.IsUpdated(convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseID) == true)
{
string strComparisonOp_EduMSTRGiftedClsCaseID = objvEduMSTRGiftedClsCaseQuantitySenate_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseID, objvEduMSTRGiftedClsCaseQuantitySenate_Cond.EduMSTRGiftedClsCaseID, strComparisonOp_EduMSTRGiftedClsCaseID);
}
if (objvEduMSTRGiftedClsCaseQuantitySenate_Cond.IsUpdated(convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseName) == true)
{
string strComparisonOp_EduMSTRGiftedClsCaseName = objvEduMSTRGiftedClsCaseQuantitySenate_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseName, objvEduMSTRGiftedClsCaseQuantitySenate_Cond.EduMSTRGiftedClsCaseName, strComparisonOp_EduMSTRGiftedClsCaseName);
}
if (objvEduMSTRGiftedClsCaseQuantitySenate_Cond.IsUpdated(convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseDate) == true)
{
string strComparisonOp_EduMSTRGiftedClsCaseDate = objvEduMSTRGiftedClsCaseQuantitySenate_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseDate, objvEduMSTRGiftedClsCaseQuantitySenate_Cond.EduMSTRGiftedClsCaseDate, strComparisonOp_EduMSTRGiftedClsCaseDate);
}
if (objvEduMSTRGiftedClsCaseQuantitySenate_Cond.IsUpdated(convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseTypeName) == true)
{
string strComparisonOp_EduMSTRGiftedClsCaseTypeName = objvEduMSTRGiftedClsCaseQuantitySenate_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseTypeName, objvEduMSTRGiftedClsCaseQuantitySenate_Cond.EduMSTRGiftedClsCaseTypeName, strComparisonOp_EduMSTRGiftedClsCaseTypeName);
}
if (objvEduMSTRGiftedClsCaseQuantitySenate_Cond.IsUpdated(convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionTtlScore) == true)
{
string strComparisonOp_senateGaugeVersionTtlScore = objvEduMSTRGiftedClsCaseQuantitySenate_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionTtlScore];
strWhereCond += string.Format(" And {0} {2} {1}", convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionTtlScore, objvEduMSTRGiftedClsCaseQuantitySenate_Cond.senateGaugeVersionTtlScore, strComparisonOp_senateGaugeVersionTtlScore);
}
if (objvEduMSTRGiftedClsCaseQuantitySenate_Cond.IsUpdated(convEduMSTRGiftedClsCaseQuantitySenate.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvEduMSTRGiftedClsCaseQuantitySenate_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseQuantitySenate.OwnerId, objvEduMSTRGiftedClsCaseQuantitySenate_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvEduMSTRGiftedClsCaseQuantitySenate_Cond.IsUpdated(convEduMSTRGiftedClsCaseQuantitySenate.StuName) == true)
{
string strComparisonOp_StuName = objvEduMSTRGiftedClsCaseQuantitySenate_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseQuantitySenate.StuName, objvEduMSTRGiftedClsCaseQuantitySenate_Cond.StuName, strComparisonOp_StuName);
}
if (objvEduMSTRGiftedClsCaseQuantitySenate_Cond.IsUpdated(convEduMSTRGiftedClsCaseQuantitySenate.StuID) == true)
{
string strComparisonOp_StuID = objvEduMSTRGiftedClsCaseQuantitySenate_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseQuantitySenate.StuID, objvEduMSTRGiftedClsCaseQuantitySenate_Cond.StuID, strComparisonOp_StuID);
}
if (objvEduMSTRGiftedClsCaseQuantitySenate_Cond.IsUpdated(convEduMSTRGiftedClsCaseQuantitySenate.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvEduMSTRGiftedClsCaseQuantitySenate_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseQuantitySenate.id_XzCollege, objvEduMSTRGiftedClsCaseQuantitySenate_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvEduMSTRGiftedClsCaseQuantitySenate_Cond.IsUpdated(convEduMSTRGiftedClsCaseQuantitySenate.UserKindName) == true)
{
string strComparisonOp_UserKindName = objvEduMSTRGiftedClsCaseQuantitySenate_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.UserKindName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseQuantitySenate.UserKindName, objvEduMSTRGiftedClsCaseQuantitySenate_Cond.UserKindName, strComparisonOp_UserKindName);
}
if (objvEduMSTRGiftedClsCaseQuantitySenate_Cond.IsUpdated(convEduMSTRGiftedClsCaseQuantitySenate.UserTypeName) == true)
{
string strComparisonOp_UserTypeName = objvEduMSTRGiftedClsCaseQuantitySenate_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.UserTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseQuantitySenate.UserTypeName, objvEduMSTRGiftedClsCaseQuantitySenate_Cond.UserTypeName, strComparisonOp_UserTypeName);
}
if (objvEduMSTRGiftedClsCaseQuantitySenate_Cond.IsUpdated(convEduMSTRGiftedClsCaseQuantitySenate.OwnerName) == true)
{
string strComparisonOp_OwnerName = objvEduMSTRGiftedClsCaseQuantitySenate_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.OwnerName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseQuantitySenate.OwnerName, objvEduMSTRGiftedClsCaseQuantitySenate_Cond.OwnerName, strComparisonOp_OwnerName);
}
if (objvEduMSTRGiftedClsCaseQuantitySenate_Cond.IsUpdated(convEduMSTRGiftedClsCaseQuantitySenate.id_AppraiseType) == true)
{
string strComparisonOp_id_AppraiseType = objvEduMSTRGiftedClsCaseQuantitySenate_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.id_AppraiseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseQuantitySenate.id_AppraiseType, objvEduMSTRGiftedClsCaseQuantitySenate_Cond.id_AppraiseType, strComparisonOp_id_AppraiseType);
}
if (objvEduMSTRGiftedClsCaseQuantitySenate_Cond.IsUpdated(convEduMSTRGiftedClsCaseQuantitySenate.AppraiseTypeName) == true)
{
string strComparisonOp_AppraiseTypeName = objvEduMSTRGiftedClsCaseQuantitySenate_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.AppraiseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseQuantitySenate.AppraiseTypeName, objvEduMSTRGiftedClsCaseQuantitySenate_Cond.AppraiseTypeName, strComparisonOp_AppraiseTypeName);
}
if (objvEduMSTRGiftedClsCaseQuantitySenate_Cond.IsUpdated(convEduMSTRGiftedClsCaseQuantitySenate.SenateTheme) == true)
{
string strComparisonOp_SenateTheme = objvEduMSTRGiftedClsCaseQuantitySenate_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.SenateTheme];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseQuantitySenate.SenateTheme, objvEduMSTRGiftedClsCaseQuantitySenate_Cond.SenateTheme, strComparisonOp_SenateTheme);
}
if (objvEduMSTRGiftedClsCaseQuantitySenate_Cond.IsUpdated(convEduMSTRGiftedClsCaseQuantitySenate.SenateContent) == true)
{
string strComparisonOp_SenateContent = objvEduMSTRGiftedClsCaseQuantitySenate_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.SenateContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseQuantitySenate.SenateContent, objvEduMSTRGiftedClsCaseQuantitySenate_Cond.SenateContent, strComparisonOp_SenateContent);
}
if (objvEduMSTRGiftedClsCaseQuantitySenate_Cond.IsUpdated(convEduMSTRGiftedClsCaseQuantitySenate.SenateTotalScore) == true)
{
string strComparisonOp_SenateTotalScore = objvEduMSTRGiftedClsCaseQuantitySenate_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.SenateTotalScore];
strWhereCond += string.Format(" And {0} {2} {1}", convEduMSTRGiftedClsCaseQuantitySenate.SenateTotalScore, objvEduMSTRGiftedClsCaseQuantitySenate_Cond.SenateTotalScore, strComparisonOp_SenateTotalScore);
}
if (objvEduMSTRGiftedClsCaseQuantitySenate_Cond.IsUpdated(convEduMSTRGiftedClsCaseQuantitySenate.SenateDate) == true)
{
string strComparisonOp_SenateDate = objvEduMSTRGiftedClsCaseQuantitySenate_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.SenateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseQuantitySenate.SenateDate, objvEduMSTRGiftedClsCaseQuantitySenate_Cond.SenateDate, strComparisonOp_SenateDate);
}
if (objvEduMSTRGiftedClsCaseQuantitySenate_Cond.IsUpdated(convEduMSTRGiftedClsCaseQuantitySenate.SenateTime) == true)
{
string strComparisonOp_SenateTime = objvEduMSTRGiftedClsCaseQuantitySenate_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.SenateTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseQuantitySenate.SenateTime, objvEduMSTRGiftedClsCaseQuantitySenate_Cond.SenateTime, strComparisonOp_SenateTime);
}
if (objvEduMSTRGiftedClsCaseQuantitySenate_Cond.IsUpdated(convEduMSTRGiftedClsCaseQuantitySenate.SenateIp) == true)
{
string strComparisonOp_SenateIp = objvEduMSTRGiftedClsCaseQuantitySenate_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.SenateIp];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseQuantitySenate.SenateIp, objvEduMSTRGiftedClsCaseQuantitySenate_Cond.SenateIp, strComparisonOp_SenateIp);
}
if (objvEduMSTRGiftedClsCaseQuantitySenate_Cond.IsUpdated(convEduMSTRGiftedClsCaseQuantitySenate.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvEduMSTRGiftedClsCaseQuantitySenate_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convEduMSTRGiftedClsCaseQuantitySenate.BrowseCount, objvEduMSTRGiftedClsCaseQuantitySenate_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvEduMSTRGiftedClsCaseQuantitySenate_Cond.IsUpdated(convEduMSTRGiftedClsCaseQuantitySenate.id_SenateGaugeVersion) == true)
{
string strComparisonOp_id_SenateGaugeVersion = objvEduMSTRGiftedClsCaseQuantitySenate_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.id_SenateGaugeVersion];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseQuantitySenate.id_SenateGaugeVersion, objvEduMSTRGiftedClsCaseQuantitySenate_Cond.id_SenateGaugeVersion, strComparisonOp_id_SenateGaugeVersion);
}
if (objvEduMSTRGiftedClsCaseQuantitySenate_Cond.IsUpdated(convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionID) == true)
{
string strComparisonOp_senateGaugeVersionID = objvEduMSTRGiftedClsCaseQuantitySenate_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionID, objvEduMSTRGiftedClsCaseQuantitySenate_Cond.senateGaugeVersionID, strComparisonOp_senateGaugeVersionID);
}
if (objvEduMSTRGiftedClsCaseQuantitySenate_Cond.IsUpdated(convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvEduMSTRGiftedClsCaseQuantitySenate_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionName, objvEduMSTRGiftedClsCaseQuantitySenate_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvEduMSTRGiftedClsCaseQuantitySenate_Cond.IsUpdated(convEduMSTRGiftedClsCaseQuantitySenate.UserId) == true)
{
string strComparisonOp_UserId = objvEduMSTRGiftedClsCaseQuantitySenate_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseQuantitySenate.UserId, objvEduMSTRGiftedClsCaseQuantitySenate_Cond.UserId, strComparisonOp_UserId);
}
if (objvEduMSTRGiftedClsCaseQuantitySenate_Cond.IsUpdated(convEduMSTRGiftedClsCaseQuantitySenate.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvEduMSTRGiftedClsCaseQuantitySenate_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseQuantitySenate.CollegeID, objvEduMSTRGiftedClsCaseQuantitySenate_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvEduMSTRGiftedClsCaseQuantitySenate_Cond.IsUpdated(convEduMSTRGiftedClsCaseQuantitySenate.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvEduMSTRGiftedClsCaseQuantitySenate_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseQuantitySenate.CollegeName, objvEduMSTRGiftedClsCaseQuantitySenate_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvEduMSTRGiftedClsCaseQuantitySenate_Cond.IsUpdated(convEduMSTRGiftedClsCaseQuantitySenate.IsLeaved) == true)
{
if (objvEduMSTRGiftedClsCaseQuantitySenate_Cond.IsLeaved == true)
{
strWhereCond += string.Format(" And {0} = '1'", convEduMSTRGiftedClsCaseQuantitySenate.IsLeaved);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convEduMSTRGiftedClsCaseQuantitySenate.IsLeaved);
}
}
if (objvEduMSTRGiftedClsCaseQuantitySenate_Cond.IsUpdated(convEduMSTRGiftedClsCaseQuantitySenate.StuIdTeacherId) == true)
{
string strComparisonOp_StuIdTeacherId = objvEduMSTRGiftedClsCaseQuantitySenate_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.StuIdTeacherId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseQuantitySenate.StuIdTeacherId, objvEduMSTRGiftedClsCaseQuantitySenate_Cond.StuIdTeacherId, strComparisonOp_StuIdTeacherId);
}
if (objvEduMSTRGiftedClsCaseQuantitySenate_Cond.IsUpdated(convEduMSTRGiftedClsCaseQuantitySenate.UserNameWithUserId) == true)
{
string strComparisonOp_UserNameWithUserId = objvEduMSTRGiftedClsCaseQuantitySenate_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.UserNameWithUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseQuantitySenate.UserNameWithUserId, objvEduMSTRGiftedClsCaseQuantitySenate_Cond.UserNameWithUserId, strComparisonOp_UserNameWithUserId);
}
if (objvEduMSTRGiftedClsCaseQuantitySenate_Cond.IsUpdated(convEduMSTRGiftedClsCaseQuantitySenate.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvEduMSTRGiftedClsCaseQuantitySenate_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseQuantitySenate.CollegeNameA, objvEduMSTRGiftedClsCaseQuantitySenate_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvEduMSTRGiftedClsCaseQuantitySenate_Cond.IsUpdated(convEduMSTRGiftedClsCaseQuantitySenate.UserName) == true)
{
string strComparisonOp_UserName = objvEduMSTRGiftedClsCaseQuantitySenate_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseQuantitySenate.UserName, objvEduMSTRGiftedClsCaseQuantitySenate_Cond.UserName, strComparisonOp_UserName);
}
if (objvEduMSTRGiftedClsCaseQuantitySenate_Cond.IsUpdated(convEduMSTRGiftedClsCaseQuantitySenate.UserKindId) == true)
{
string strComparisonOp_UserKindId = objvEduMSTRGiftedClsCaseQuantitySenate_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.UserKindId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseQuantitySenate.UserKindId, objvEduMSTRGiftedClsCaseQuantitySenate_Cond.UserKindId, strComparisonOp_UserKindId);
}
if (objvEduMSTRGiftedClsCaseQuantitySenate_Cond.IsUpdated(convEduMSTRGiftedClsCaseQuantitySenate.UserTypeId) == true)
{
string strComparisonOp_UserTypeId = objvEduMSTRGiftedClsCaseQuantitySenate_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.UserTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseQuantitySenate.UserTypeId, objvEduMSTRGiftedClsCaseQuantitySenate_Cond.UserTypeId, strComparisonOp_UserTypeId);
}
if (objvEduMSTRGiftedClsCaseQuantitySenate_Cond.IsUpdated(convEduMSTRGiftedClsCaseQuantitySenate.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvEduMSTRGiftedClsCaseQuantitySenate_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseQuantitySenate.UpdUser, objvEduMSTRGiftedClsCaseQuantitySenate_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvEduMSTRGiftedClsCaseQuantitySenate_Cond.IsUpdated(convEduMSTRGiftedClsCaseQuantitySenate.UpdUserName) == true)
{
string strComparisonOp_UpdUserName = objvEduMSTRGiftedClsCaseQuantitySenate_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.UpdUserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseQuantitySenate.UpdUserName, objvEduMSTRGiftedClsCaseQuantitySenate_Cond.UpdUserName, strComparisonOp_UpdUserName);
}
if (objvEduMSTRGiftedClsCaseQuantitySenate_Cond.IsUpdated(convEduMSTRGiftedClsCaseQuantitySenate.OwnerNameWithId) == true)
{
string strComparisonOp_OwnerNameWithId = objvEduMSTRGiftedClsCaseQuantitySenate_Cond.dicFldComparisonOp[convEduMSTRGiftedClsCaseQuantitySenate.OwnerNameWithId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convEduMSTRGiftedClsCaseQuantitySenate.OwnerNameWithId, objvEduMSTRGiftedClsCaseQuantitySenate_Cond.OwnerNameWithId, strComparisonOp_OwnerNameWithId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v教育硕士优课教师量化评价(vEduMSTRGiftedClsCaseQuantitySenate)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvEduMSTRGiftedClsCaseQuantitySenateWApi
{
private static readonly string mstrApiControllerName = "vEduMSTRGiftedClsCaseQuantitySenateApi";

 public clsvEduMSTRGiftedClsCaseQuantitySenateWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_microteachCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsvEduMSTRGiftedClsCaseQuantitySenateEN GetObjByid_microteachCaseQuantitySenate(long lngid_microteachCaseQuantitySenate)
{
string strAction = "GetObjByid_microteachCaseQuantitySenate";
string strErrMsg = string.Empty;
string strResult = "";
clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_microteachCaseQuantitySenate"] = lngid_microteachCaseQuantitySenate.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvEduMSTRGiftedClsCaseQuantitySenateEN = JsonConvert.DeserializeObject<clsvEduMSTRGiftedClsCaseQuantitySenateEN>((string)jobjReturn["ReturnObj"]);
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
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
 /// <param name = "lngid_microteachCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsvEduMSTRGiftedClsCaseQuantitySenateEN GetObjByid_microteachCaseQuantitySenate_WA_Cache(long lngid_microteachCaseQuantitySenate)
{
string strAction = "GetObjByid_microteachCaseQuantitySenate_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_microteachCaseQuantitySenate"] = lngid_microteachCaseQuantitySenate.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvEduMSTRGiftedClsCaseQuantitySenateEN = JsonConvert.DeserializeObject<clsvEduMSTRGiftedClsCaseQuantitySenateEN>((string)jobjReturn["ReturnObj"]);
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
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
public static clsvEduMSTRGiftedClsCaseQuantitySenateEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateEN = null;
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
objvEduMSTRGiftedClsCaseQuantitySenateEN = JsonConvert.DeserializeObject<clsvEduMSTRGiftedClsCaseQuantitySenateEN>((string)jobjReturn["ReturnObj"]);
return objvEduMSTRGiftedClsCaseQuantitySenateEN;
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
 /// <param name = "lngid_microteachCaseQuantitySenate">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvEduMSTRGiftedClsCaseQuantitySenateEN GetObjByid_microteachCaseQuantitySenate_Cache(long lngid_microteachCaseQuantitySenate)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvEduMSTRGiftedClsCaseQuantitySenateEN._CurrTabName_S);
List<clsvEduMSTRGiftedClsCaseQuantitySenateEN> arrvEduMSTRGiftedClsCaseQuantitySenateObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvEduMSTRGiftedClsCaseQuantitySenateEN> arrvEduMSTRGiftedClsCaseQuantitySenateObjLst_Sel =
from objvEduMSTRGiftedClsCaseQuantitySenateEN in arrvEduMSTRGiftedClsCaseQuantitySenateObjLst_Cache
where objvEduMSTRGiftedClsCaseQuantitySenateEN.id_microteachCaseQuantitySenate == lngid_microteachCaseQuantitySenate
select objvEduMSTRGiftedClsCaseQuantitySenateEN;
if (arrvEduMSTRGiftedClsCaseQuantitySenateObjLst_Sel.Count() == 0)
{
   clsvEduMSTRGiftedClsCaseQuantitySenateEN obj = clsvEduMSTRGiftedClsCaseQuantitySenateWApi.GetObjByid_microteachCaseQuantitySenate(lngid_microteachCaseQuantitySenate);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvEduMSTRGiftedClsCaseQuantitySenateObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvEduMSTRGiftedClsCaseQuantitySenateEN> GetObjLst(string strWhereCond)
{
 List<clsvEduMSTRGiftedClsCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvEduMSTRGiftedClsCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvEduMSTRGiftedClsCaseQuantitySenateEN> GetObjLstById_microteachCaseQuantitySenateLst(List<long> arrId_microteachCaseQuantitySenate)
{
 List<clsvEduMSTRGiftedClsCaseQuantitySenateEN> arrObjLst = null; 
string strAction = "GetObjLstById_microteachCaseQuantitySenateLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_microteachCaseQuantitySenate);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvEduMSTRGiftedClsCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngid_microteachCaseQuantitySenate">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvEduMSTRGiftedClsCaseQuantitySenateEN> GetObjLstById_microteachCaseQuantitySenateLst_Cache(List<long> arrId_microteachCaseQuantitySenate)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvEduMSTRGiftedClsCaseQuantitySenateEN._CurrTabName_S);
List<clsvEduMSTRGiftedClsCaseQuantitySenateEN> arrvEduMSTRGiftedClsCaseQuantitySenateObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvEduMSTRGiftedClsCaseQuantitySenateEN> arrvEduMSTRGiftedClsCaseQuantitySenateObjLst_Sel =
from objvEduMSTRGiftedClsCaseQuantitySenateEN in arrvEduMSTRGiftedClsCaseQuantitySenateObjLst_Cache
where arrId_microteachCaseQuantitySenate.Contains(objvEduMSTRGiftedClsCaseQuantitySenateEN.id_microteachCaseQuantitySenate)
select objvEduMSTRGiftedClsCaseQuantitySenateEN;
return arrvEduMSTRGiftedClsCaseQuantitySenateObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvEduMSTRGiftedClsCaseQuantitySenateEN> GetObjLstById_microteachCaseQuantitySenateLst_WA_Cache(List<long> arrId_microteachCaseQuantitySenate)
{
 List<clsvEduMSTRGiftedClsCaseQuantitySenateEN> arrObjLst = null; 
string strAction = "GetObjLstById_microteachCaseQuantitySenateLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_microteachCaseQuantitySenate);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvEduMSTRGiftedClsCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvEduMSTRGiftedClsCaseQuantitySenateEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvEduMSTRGiftedClsCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvEduMSTRGiftedClsCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvEduMSTRGiftedClsCaseQuantitySenateEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvEduMSTRGiftedClsCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvEduMSTRGiftedClsCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvEduMSTRGiftedClsCaseQuantitySenateEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvEduMSTRGiftedClsCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvEduMSTRGiftedClsCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvEduMSTRGiftedClsCaseQuantitySenateEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvEduMSTRGiftedClsCaseQuantitySenateEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvEduMSTRGiftedClsCaseQuantitySenateEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngid_microteachCaseQuantitySenate)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_microteachCaseQuantitySenate"] = lngid_microteachCaseQuantitySenate.ToString()
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
 /// <param name = "objvEduMSTRGiftedClsCaseQuantitySenateENS">源对象</param>
 /// <param name = "objvEduMSTRGiftedClsCaseQuantitySenateENT">目标对象</param>
 public static void CopyTo(clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateENS, clsvEduMSTRGiftedClsCaseQuantitySenateEN objvEduMSTRGiftedClsCaseQuantitySenateENT)
{
try
{
objvEduMSTRGiftedClsCaseQuantitySenateENT.id_microteachCaseQuantitySenate = objvEduMSTRGiftedClsCaseQuantitySenateENS.id_microteachCaseQuantitySenate; //微格量化评价流水号
objvEduMSTRGiftedClsCaseQuantitySenateENT.FuncModuleId = objvEduMSTRGiftedClsCaseQuantitySenateENS.FuncModuleId; //功能模块Id
objvEduMSTRGiftedClsCaseQuantitySenateENT.FuncModuleName = objvEduMSTRGiftedClsCaseQuantitySenateENS.FuncModuleName; //功能模块名称
objvEduMSTRGiftedClsCaseQuantitySenateENT.id_MicroteachCase = objvEduMSTRGiftedClsCaseQuantitySenateENS.id_MicroteachCase; //微格教学案例流水号
objvEduMSTRGiftedClsCaseQuantitySenateENT.id_EduMSTRGiftedClsCase = objvEduMSTRGiftedClsCaseQuantitySenateENS.id_EduMSTRGiftedClsCase; //教育硕士优课案例流水号
objvEduMSTRGiftedClsCaseQuantitySenateENT.EduMSTRGiftedClsCaseID = objvEduMSTRGiftedClsCaseQuantitySenateENS.EduMSTRGiftedClsCaseID; //教育硕士优课案例ID
objvEduMSTRGiftedClsCaseQuantitySenateENT.EduMSTRGiftedClsCaseName = objvEduMSTRGiftedClsCaseQuantitySenateENS.EduMSTRGiftedClsCaseName; //教育硕士优课案例名称
objvEduMSTRGiftedClsCaseQuantitySenateENT.EduMSTRGiftedClsCaseDate = objvEduMSTRGiftedClsCaseQuantitySenateENS.EduMSTRGiftedClsCaseDate; //教育硕士优课案例日期
objvEduMSTRGiftedClsCaseQuantitySenateENT.EduMSTRGiftedClsCaseTypeName = objvEduMSTRGiftedClsCaseQuantitySenateENS.EduMSTRGiftedClsCaseTypeName; //教育硕士优课案例类型名称
objvEduMSTRGiftedClsCaseQuantitySenateENT.senateGaugeVersionTtlScore = objvEduMSTRGiftedClsCaseQuantitySenateENS.senateGaugeVersionTtlScore; //评价量表版本总分
objvEduMSTRGiftedClsCaseQuantitySenateENT.OwnerId = objvEduMSTRGiftedClsCaseQuantitySenateENS.OwnerId; //拥有者Id
objvEduMSTRGiftedClsCaseQuantitySenateENT.StuName = objvEduMSTRGiftedClsCaseQuantitySenateENS.StuName; //姓名
objvEduMSTRGiftedClsCaseQuantitySenateENT.StuID = objvEduMSTRGiftedClsCaseQuantitySenateENS.StuID; //学号
objvEduMSTRGiftedClsCaseQuantitySenateENT.id_XzCollege = objvEduMSTRGiftedClsCaseQuantitySenateENS.id_XzCollege; //学院流水号
objvEduMSTRGiftedClsCaseQuantitySenateENT.UserKindName = objvEduMSTRGiftedClsCaseQuantitySenateENS.UserKindName; //用户类别名
objvEduMSTRGiftedClsCaseQuantitySenateENT.UserTypeName = objvEduMSTRGiftedClsCaseQuantitySenateENS.UserTypeName; //用户类型名称
objvEduMSTRGiftedClsCaseQuantitySenateENT.OwnerName = objvEduMSTRGiftedClsCaseQuantitySenateENS.OwnerName; //拥有者姓名
objvEduMSTRGiftedClsCaseQuantitySenateENT.id_AppraiseType = objvEduMSTRGiftedClsCaseQuantitySenateENS.id_AppraiseType; //评议类型流水号
objvEduMSTRGiftedClsCaseQuantitySenateENT.AppraiseTypeName = objvEduMSTRGiftedClsCaseQuantitySenateENS.AppraiseTypeName; //评议类型名称
objvEduMSTRGiftedClsCaseQuantitySenateENT.SenateTheme = objvEduMSTRGiftedClsCaseQuantitySenateENS.SenateTheme; //量化评价主题
objvEduMSTRGiftedClsCaseQuantitySenateENT.SenateContent = objvEduMSTRGiftedClsCaseQuantitySenateENS.SenateContent; //评价内容
objvEduMSTRGiftedClsCaseQuantitySenateENT.SenateTotalScore = objvEduMSTRGiftedClsCaseQuantitySenateENS.SenateTotalScore; //评价分数
objvEduMSTRGiftedClsCaseQuantitySenateENT.SenateDate = objvEduMSTRGiftedClsCaseQuantitySenateENS.SenateDate; //评价日期
objvEduMSTRGiftedClsCaseQuantitySenateENT.SenateTime = objvEduMSTRGiftedClsCaseQuantitySenateENS.SenateTime; //评价时间
objvEduMSTRGiftedClsCaseQuantitySenateENT.SenateIp = objvEduMSTRGiftedClsCaseQuantitySenateENS.SenateIp; //评议Ip
objvEduMSTRGiftedClsCaseQuantitySenateENT.BrowseCount = objvEduMSTRGiftedClsCaseQuantitySenateENS.BrowseCount; //浏览次数
objvEduMSTRGiftedClsCaseQuantitySenateENT.id_SenateGaugeVersion = objvEduMSTRGiftedClsCaseQuantitySenateENS.id_SenateGaugeVersion; //评价量表版本流水号
objvEduMSTRGiftedClsCaseQuantitySenateENT.senateGaugeVersionID = objvEduMSTRGiftedClsCaseQuantitySenateENS.senateGaugeVersionID; //评价量表版本ID
objvEduMSTRGiftedClsCaseQuantitySenateENT.senateGaugeVersionName = objvEduMSTRGiftedClsCaseQuantitySenateENS.senateGaugeVersionName; //评价量表版本名称
objvEduMSTRGiftedClsCaseQuantitySenateENT.UserId = objvEduMSTRGiftedClsCaseQuantitySenateENS.UserId; //用户ID
objvEduMSTRGiftedClsCaseQuantitySenateENT.CollegeID = objvEduMSTRGiftedClsCaseQuantitySenateENS.CollegeID; //学院ID
objvEduMSTRGiftedClsCaseQuantitySenateENT.CollegeName = objvEduMSTRGiftedClsCaseQuantitySenateENS.CollegeName; //学院名称
objvEduMSTRGiftedClsCaseQuantitySenateENT.IsLeaved = objvEduMSTRGiftedClsCaseQuantitySenateENS.IsLeaved; //IsLeaved
objvEduMSTRGiftedClsCaseQuantitySenateENT.StuIdTeacherId = objvEduMSTRGiftedClsCaseQuantitySenateENS.StuIdTeacherId; //学工号
objvEduMSTRGiftedClsCaseQuantitySenateENT.UserNameWithUserId = objvEduMSTRGiftedClsCaseQuantitySenateENS.UserNameWithUserId; //UserNameWithUserId
objvEduMSTRGiftedClsCaseQuantitySenateENT.CollegeNameA = objvEduMSTRGiftedClsCaseQuantitySenateENS.CollegeNameA; //学院名称简写
objvEduMSTRGiftedClsCaseQuantitySenateENT.UserName = objvEduMSTRGiftedClsCaseQuantitySenateENS.UserName; //用户名
objvEduMSTRGiftedClsCaseQuantitySenateENT.UserKindId = objvEduMSTRGiftedClsCaseQuantitySenateENS.UserKindId; //用户类别Id
objvEduMSTRGiftedClsCaseQuantitySenateENT.UserTypeId = objvEduMSTRGiftedClsCaseQuantitySenateENS.UserTypeId; //用户类型Id
objvEduMSTRGiftedClsCaseQuantitySenateENT.UpdUser = objvEduMSTRGiftedClsCaseQuantitySenateENS.UpdUser; //修改人
objvEduMSTRGiftedClsCaseQuantitySenateENT.UpdUserName = objvEduMSTRGiftedClsCaseQuantitySenateENS.UpdUserName; //UpdUserName
objvEduMSTRGiftedClsCaseQuantitySenateENT.OwnerNameWithId = objvEduMSTRGiftedClsCaseQuantitySenateENS.OwnerNameWithId; //拥有者名称附Id
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
public static DataTable ToDataTable(List<clsvEduMSTRGiftedClsCaseQuantitySenateEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvEduMSTRGiftedClsCaseQuantitySenateEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvEduMSTRGiftedClsCaseQuantitySenateEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvEduMSTRGiftedClsCaseQuantitySenateEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvEduMSTRGiftedClsCaseQuantitySenateEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvEduMSTRGiftedClsCaseQuantitySenateEN.AttributeName)
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
if (clsTeacherInfoWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeacherInfoWApi没有刷新缓存机制(clsTeacherInfoWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFuncModuleWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleWApi没有刷新缓存机制(clsFuncModuleWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSenateGaugeVersionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeVersionWApi没有刷新缓存机制(clsSenateGaugeVersionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAppraiseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsAppraiseTypeWApi没有刷新缓存机制(clsAppraiseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroteachCaseQuantitySenateWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCaseQuantitySenateWApi没有刷新缓存机制(clsMicroteachCaseQuantitySenateWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUsersWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersWApi没有刷新缓存机制(clsUsersWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserStateWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserStateWApi没有刷新缓存机制(clsUserStateWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzClgWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgWApi没有刷新缓存机制(clsXzClgWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorWApi没有刷新缓存机制(clsXzMajorWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzGradeBaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseWApi没有刷新缓存机制(clsXzGradeBaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserIdentityWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserIdentityWApi没有刷新缓存机制(clsUserIdentityWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudyLevelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelWApi没有刷新缓存机制(clsStudyLevelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRecommendedDegreeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRecommendedDegreeWApi没有刷新缓存机制(clsRecommendedDegreeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCaseLevelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseLevelWApi没有刷新缓存机制(clsCaseLevelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserTypeWApi没有刷新缓存机制(clsUserTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDisciplineWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineWApi没有刷新缓存机制(clsDisciplineWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserKindWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserKindWApi没有刷新缓存机制(clsUserKindWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsEduMSTRGiftedClsCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsEduMSTRGiftedClsCaseWApi没有刷新缓存机制(clsEduMSTRGiftedClsCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsEduMSTRGiftedClsCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsEduMSTRGiftedClsCaseTypeWApi没有刷新缓存机制(clsEduMSTRGiftedClsCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzUniZoneWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzUniZoneWApi没有刷新缓存机制(clsXzUniZoneWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSexWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSexWApi没有刷新缓存机制(clsSexWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsEthnicWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsEthnicWApi没有刷新缓存机制(clsRsEthnicWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsPoliticsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsPoliticsWApi没有刷新缓存机制(clsRsPoliticsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudentInfoWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudentInfoWApi没有刷新缓存机制(clsStudentInfoWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsStuTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsStuTypeWApi没有刷新缓存机制(clsRsStuTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSkillTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSkillTypeWApi没有刷新缓存机制(clsSkillTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachSkillWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachSkillWApi没有刷新缓存机制(clsTeachSkillWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzAdminClsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsWApi没有刷新缓存机制(clsXzAdminClsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzAdminClsTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzAdminClsTypeWApi没有刷新缓存机制(clsXzAdminClsTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_microteachCaseQuantitySenate");
//if (arrvEduMSTRGiftedClsCaseQuantitySenateObjLst_Cache == null)
//{
//arrvEduMSTRGiftedClsCaseQuantitySenateObjLst_Cache = await clsvEduMSTRGiftedClsCaseQuantitySenateWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvEduMSTRGiftedClsCaseQuantitySenateEN._CurrTabName_S);
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
public static List<clsvEduMSTRGiftedClsCaseQuantitySenateEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvEduMSTRGiftedClsCaseQuantitySenateEN._CurrTabName_S);
List<clsvEduMSTRGiftedClsCaseQuantitySenateEN> arrvEduMSTRGiftedClsCaseQuantitySenateObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvEduMSTRGiftedClsCaseQuantitySenateObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvEduMSTRGiftedClsCaseQuantitySenateEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convEduMSTRGiftedClsCaseQuantitySenate.id_microteachCaseQuantitySenate, Type.GetType("System.Int64"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseQuantitySenate.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseQuantitySenate.id_EduMSTRGiftedClsCase, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseDate, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionTtlScore, Type.GetType("System.Single"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseQuantitySenate.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseQuantitySenate.StuName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseQuantitySenate.StuID, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseQuantitySenate.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseQuantitySenate.UserKindName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseQuantitySenate.UserTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseQuantitySenate.OwnerName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseQuantitySenate.id_AppraiseType, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseQuantitySenate.AppraiseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseQuantitySenate.SenateTheme, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseQuantitySenate.SenateContent, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseQuantitySenate.SenateTotalScore, Type.GetType("System.Single"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseQuantitySenate.SenateDate, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseQuantitySenate.SenateTime, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseQuantitySenate.SenateIp, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseQuantitySenate.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseQuantitySenate.id_SenateGaugeVersion, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionID, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseQuantitySenate.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseQuantitySenate.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseQuantitySenate.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseQuantitySenate.IsLeaved, Type.GetType("System.Boolean"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseQuantitySenate.StuIdTeacherId, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseQuantitySenate.UserNameWithUserId, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseQuantitySenate.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseQuantitySenate.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseQuantitySenate.UserKindId, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseQuantitySenate.UserTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseQuantitySenate.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseQuantitySenate.UpdUserName, Type.GetType("System.String"));
objDT.Columns.Add(convEduMSTRGiftedClsCaseQuantitySenate.OwnerNameWithId, Type.GetType("System.String"));
foreach (clsvEduMSTRGiftedClsCaseQuantitySenateEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convEduMSTRGiftedClsCaseQuantitySenate.id_microteachCaseQuantitySenate] = objInFor[convEduMSTRGiftedClsCaseQuantitySenate.id_microteachCaseQuantitySenate];
objDR[convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleId] = objInFor[convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleId];
objDR[convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleName] = objInFor[convEduMSTRGiftedClsCaseQuantitySenate.FuncModuleName];
objDR[convEduMSTRGiftedClsCaseQuantitySenate.id_MicroteachCase] = objInFor[convEduMSTRGiftedClsCaseQuantitySenate.id_MicroteachCase];
objDR[convEduMSTRGiftedClsCaseQuantitySenate.id_EduMSTRGiftedClsCase] = objInFor[convEduMSTRGiftedClsCaseQuantitySenate.id_EduMSTRGiftedClsCase];
objDR[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseID] = objInFor[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseID];
objDR[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseName] = objInFor[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseName];
objDR[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseDate] = objInFor[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseDate];
objDR[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseTypeName] = objInFor[convEduMSTRGiftedClsCaseQuantitySenate.EduMSTRGiftedClsCaseTypeName];
objDR[convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionTtlScore] = objInFor[convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionTtlScore];
objDR[convEduMSTRGiftedClsCaseQuantitySenate.OwnerId] = objInFor[convEduMSTRGiftedClsCaseQuantitySenate.OwnerId];
objDR[convEduMSTRGiftedClsCaseQuantitySenate.StuName] = objInFor[convEduMSTRGiftedClsCaseQuantitySenate.StuName];
objDR[convEduMSTRGiftedClsCaseQuantitySenate.StuID] = objInFor[convEduMSTRGiftedClsCaseQuantitySenate.StuID];
objDR[convEduMSTRGiftedClsCaseQuantitySenate.id_XzCollege] = objInFor[convEduMSTRGiftedClsCaseQuantitySenate.id_XzCollege];
objDR[convEduMSTRGiftedClsCaseQuantitySenate.UserKindName] = objInFor[convEduMSTRGiftedClsCaseQuantitySenate.UserKindName];
objDR[convEduMSTRGiftedClsCaseQuantitySenate.UserTypeName] = objInFor[convEduMSTRGiftedClsCaseQuantitySenate.UserTypeName];
objDR[convEduMSTRGiftedClsCaseQuantitySenate.OwnerName] = objInFor[convEduMSTRGiftedClsCaseQuantitySenate.OwnerName];
objDR[convEduMSTRGiftedClsCaseQuantitySenate.id_AppraiseType] = objInFor[convEduMSTRGiftedClsCaseQuantitySenate.id_AppraiseType];
objDR[convEduMSTRGiftedClsCaseQuantitySenate.AppraiseTypeName] = objInFor[convEduMSTRGiftedClsCaseQuantitySenate.AppraiseTypeName];
objDR[convEduMSTRGiftedClsCaseQuantitySenate.SenateTheme] = objInFor[convEduMSTRGiftedClsCaseQuantitySenate.SenateTheme];
objDR[convEduMSTRGiftedClsCaseQuantitySenate.SenateContent] = objInFor[convEduMSTRGiftedClsCaseQuantitySenate.SenateContent];
objDR[convEduMSTRGiftedClsCaseQuantitySenate.SenateTotalScore] = objInFor[convEduMSTRGiftedClsCaseQuantitySenate.SenateTotalScore];
objDR[convEduMSTRGiftedClsCaseQuantitySenate.SenateDate] = objInFor[convEduMSTRGiftedClsCaseQuantitySenate.SenateDate];
objDR[convEduMSTRGiftedClsCaseQuantitySenate.SenateTime] = objInFor[convEduMSTRGiftedClsCaseQuantitySenate.SenateTime];
objDR[convEduMSTRGiftedClsCaseQuantitySenate.SenateIp] = objInFor[convEduMSTRGiftedClsCaseQuantitySenate.SenateIp];
objDR[convEduMSTRGiftedClsCaseQuantitySenate.BrowseCount] = objInFor[convEduMSTRGiftedClsCaseQuantitySenate.BrowseCount];
objDR[convEduMSTRGiftedClsCaseQuantitySenate.id_SenateGaugeVersion] = objInFor[convEduMSTRGiftedClsCaseQuantitySenate.id_SenateGaugeVersion];
objDR[convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionID] = objInFor[convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionID];
objDR[convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionName] = objInFor[convEduMSTRGiftedClsCaseQuantitySenate.senateGaugeVersionName];
objDR[convEduMSTRGiftedClsCaseQuantitySenate.UserId] = objInFor[convEduMSTRGiftedClsCaseQuantitySenate.UserId];
objDR[convEduMSTRGiftedClsCaseQuantitySenate.CollegeID] = objInFor[convEduMSTRGiftedClsCaseQuantitySenate.CollegeID];
objDR[convEduMSTRGiftedClsCaseQuantitySenate.CollegeName] = objInFor[convEduMSTRGiftedClsCaseQuantitySenate.CollegeName];
objDR[convEduMSTRGiftedClsCaseQuantitySenate.IsLeaved] = objInFor[convEduMSTRGiftedClsCaseQuantitySenate.IsLeaved];
objDR[convEduMSTRGiftedClsCaseQuantitySenate.StuIdTeacherId] = objInFor[convEduMSTRGiftedClsCaseQuantitySenate.StuIdTeacherId];
objDR[convEduMSTRGiftedClsCaseQuantitySenate.UserNameWithUserId] = objInFor[convEduMSTRGiftedClsCaseQuantitySenate.UserNameWithUserId];
objDR[convEduMSTRGiftedClsCaseQuantitySenate.CollegeNameA] = objInFor[convEduMSTRGiftedClsCaseQuantitySenate.CollegeNameA];
objDR[convEduMSTRGiftedClsCaseQuantitySenate.UserName] = objInFor[convEduMSTRGiftedClsCaseQuantitySenate.UserName];
objDR[convEduMSTRGiftedClsCaseQuantitySenate.UserKindId] = objInFor[convEduMSTRGiftedClsCaseQuantitySenate.UserKindId];
objDR[convEduMSTRGiftedClsCaseQuantitySenate.UserTypeId] = objInFor[convEduMSTRGiftedClsCaseQuantitySenate.UserTypeId];
objDR[convEduMSTRGiftedClsCaseQuantitySenate.UpdUser] = objInFor[convEduMSTRGiftedClsCaseQuantitySenate.UpdUser];
objDR[convEduMSTRGiftedClsCaseQuantitySenate.UpdUserName] = objInFor[convEduMSTRGiftedClsCaseQuantitySenate.UpdUserName];
objDR[convEduMSTRGiftedClsCaseQuantitySenate.OwnerNameWithId] = objInFor[convEduMSTRGiftedClsCaseQuantitySenate.OwnerNameWithId];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}