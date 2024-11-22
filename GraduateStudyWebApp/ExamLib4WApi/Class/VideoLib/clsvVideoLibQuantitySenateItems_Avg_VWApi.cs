
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoLibQuantitySenateItems_Avg_VWApi
 表名:vVideoLibQuantitySenateItems_Avg_V(01120471)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:47:58
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:视频库
 模块英文名:VideoLib
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
public static class clsvVideoLibQuantitySenateItems_Avg_VWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateItems_Avg_VEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateItems_Avg_VEN Setid_microteachCaseQuantitySenate(this clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN, long lngid_microteachCaseQuantitySenate, string strComparisonOp="")
	{
objvVideoLibQuantitySenateItems_Avg_VEN.id_microteachCaseQuantitySenate = lngid_microteachCaseQuantitySenate; //微格量化评价流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenateItems_Avg_V.id_microteachCaseQuantitySenate) == false)
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.Add(convVideoLibQuantitySenateItems_Avg_V.id_microteachCaseQuantitySenate, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.id_microteachCaseQuantitySenate] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateItems_Avg_VEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateItems_Avg_VEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateItems_Avg_VEN SetFuncModuleId(this clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convVideoLibQuantitySenateItems_Avg_V.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convVideoLibQuantitySenateItems_Avg_V.FuncModuleId);
objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenateItems_Avg_V.FuncModuleId) == false)
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.Add(convVideoLibQuantitySenateItems_Avg_V.FuncModuleId, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.FuncModuleId] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateItems_Avg_VEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateItems_Avg_VEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateItems_Avg_VEN SetFuncModuleName(this clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convVideoLibQuantitySenateItems_Avg_V.FuncModuleName);
objvVideoLibQuantitySenateItems_Avg_VEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenateItems_Avg_V.FuncModuleName) == false)
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.Add(convVideoLibQuantitySenateItems_Avg_V.FuncModuleName, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.FuncModuleName] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateItems_Avg_VEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateItems_Avg_VEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateItems_Avg_VEN Setid_MicroteachCase(this clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convVideoLibQuantitySenateItems_Avg_V.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convVideoLibQuantitySenateItems_Avg_V.id_MicroteachCase);
objvVideoLibQuantitySenateItems_Avg_VEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenateItems_Avg_V.id_MicroteachCase) == false)
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.Add(convVideoLibQuantitySenateItems_Avg_V.id_MicroteachCase, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.id_MicroteachCase] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateItems_Avg_VEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateItems_Avg_VEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateItems_Avg_VEN SetVideoLibID(this clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN, string strVideoLibID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibID, 8, convVideoLibQuantitySenateItems_Avg_V.VideoLibID);
clsCheckSql.CheckFieldForeignKey(strVideoLibID, 8, convVideoLibQuantitySenateItems_Avg_V.VideoLibID);
objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibID = strVideoLibID; //视频库ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenateItems_Avg_V.VideoLibID) == false)
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.Add(convVideoLibQuantitySenateItems_Avg_V.VideoLibID, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.VideoLibID] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateItems_Avg_VEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateItems_Avg_VEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateItems_Avg_VEN SetVideoLibName(this clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN, string strVideoLibName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibName, 100, convVideoLibQuantitySenateItems_Avg_V.VideoLibName);
objvVideoLibQuantitySenateItems_Avg_VEN.VideoLibName = strVideoLibName; //视频名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenateItems_Avg_V.VideoLibName) == false)
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.Add(convVideoLibQuantitySenateItems_Avg_V.VideoLibName, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.VideoLibName] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateItems_Avg_VEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateItems_Avg_VEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateItems_Avg_VEN Setid_AppraiseType(this clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN, string strid_AppraiseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_AppraiseType, 4, convVideoLibQuantitySenateItems_Avg_V.id_AppraiseType);
clsCheckSql.CheckFieldForeignKey(strid_AppraiseType, 4, convVideoLibQuantitySenateItems_Avg_V.id_AppraiseType);
objvVideoLibQuantitySenateItems_Avg_VEN.id_AppraiseType = strid_AppraiseType; //评议类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenateItems_Avg_V.id_AppraiseType) == false)
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.Add(convVideoLibQuantitySenateItems_Avg_V.id_AppraiseType, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.id_AppraiseType] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateItems_Avg_VEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateItems_Avg_VEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateItems_Avg_VEN SetAppraiseTypeName(this clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN, string strAppraiseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAppraiseTypeName, 50, convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName);
objvVideoLibQuantitySenateItems_Avg_VEN.AppraiseTypeName = strAppraiseTypeName; //评议类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName) == false)
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.Add(convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateItems_Avg_VEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateItems_Avg_VEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateItems_Avg_VEN SetSenateDate(this clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN, string strSenateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateDate, 8, convVideoLibQuantitySenateItems_Avg_V.SenateDate);
clsCheckSql.CheckFieldForeignKey(strSenateDate, 8, convVideoLibQuantitySenateItems_Avg_V.SenateDate);
objvVideoLibQuantitySenateItems_Avg_VEN.SenateDate = strSenateDate; //评价日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenateItems_Avg_V.SenateDate) == false)
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.Add(convVideoLibQuantitySenateItems_Avg_V.SenateDate, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.SenateDate] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateItems_Avg_VEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateItems_Avg_VEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateItems_Avg_VEN SetsenateGaugeVersionName(this clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName);
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName) == false)
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.Add(convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateItems_Avg_VEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateItems_Avg_VEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateItems_Avg_VEN SetUserName(this clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserName, 50, convVideoLibQuantitySenateItems_Avg_V.UserName);
objvVideoLibQuantitySenateItems_Avg_VEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenateItems_Avg_V.UserName) == false)
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.Add(convVideoLibQuantitySenateItems_Avg_V.UserName, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.UserName] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateItems_Avg_VEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateItems_Avg_VEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateItems_Avg_VEN Setid_SenateGaugeItem(this clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN, string strid_SenateGaugeItem, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_SenateGaugeItem, convVideoLibQuantitySenateItems_Avg_V.id_SenateGaugeItem);
clsCheckSql.CheckFieldLen(strid_SenateGaugeItem, 4, convVideoLibQuantitySenateItems_Avg_V.id_SenateGaugeItem);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeItem, 4, convVideoLibQuantitySenateItems_Avg_V.id_SenateGaugeItem);
objvVideoLibQuantitySenateItems_Avg_VEN.id_SenateGaugeItem = strid_SenateGaugeItem; //量表指标流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenateItems_Avg_V.id_SenateGaugeItem) == false)
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.Add(convVideoLibQuantitySenateItems_Avg_V.id_SenateGaugeItem, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.id_SenateGaugeItem] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateItems_Avg_VEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateItems_Avg_VEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateItems_Avg_VEN SetsenateGaugeItemName(this clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN, string strsenateGaugeItemName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeItemName, 200, convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName);
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeItemName = strsenateGaugeItemName; //量表指标名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName) == false)
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.Add(convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateItems_Avg_VEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateItems_Avg_VEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateItems_Avg_VEN SetsenateGaugeItemWeight(this clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN, float fltsenateGaugeItemWeight, string strComparisonOp="")
	{
objvVideoLibQuantitySenateItems_Avg_VEN.senateGaugeItemWeight = fltsenateGaugeItemWeight; //量表指标权重
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight) == false)
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.Add(convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateItems_Avg_VEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibQuantitySenateItems_Avg_VEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibQuantitySenateItems_Avg_VEN SetSenateScore_Avg(this clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN, float fltSenateScore_Avg, string strComparisonOp="")
	{
objvVideoLibQuantitySenateItems_Avg_VEN.SenateScore_Avg = fltSenateScore_Avg; //评议平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.ContainsKey(convVideoLibQuantitySenateItems_Avg_V.SenateScore_Avg) == false)
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp.Add(convVideoLibQuantitySenateItems_Avg_V.SenateScore_Avg, strComparisonOp);
}
else
{
objvVideoLibQuantitySenateItems_Avg_VEN.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.SenateScore_Avg] = strComparisonOp;
}
}
return objvVideoLibQuantitySenateItems_Avg_VEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_V_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvVideoLibQuantitySenateItems_Avg_V_Cond.IsUpdated(convVideoLibQuantitySenateItems_Avg_V.id_microteachCaseQuantitySenate) == true)
{
string strComparisonOp_id_microteachCaseQuantitySenate = objvVideoLibQuantitySenateItems_Avg_V_Cond.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.id_microteachCaseQuantitySenate];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLibQuantitySenateItems_Avg_V.id_microteachCaseQuantitySenate, objvVideoLibQuantitySenateItems_Avg_V_Cond.id_microteachCaseQuantitySenate, strComparisonOp_id_microteachCaseQuantitySenate);
}
if (objvVideoLibQuantitySenateItems_Avg_V_Cond.IsUpdated(convVideoLibQuantitySenateItems_Avg_V.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvVideoLibQuantitySenateItems_Avg_V_Cond.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenateItems_Avg_V.FuncModuleId, objvVideoLibQuantitySenateItems_Avg_V_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvVideoLibQuantitySenateItems_Avg_V_Cond.IsUpdated(convVideoLibQuantitySenateItems_Avg_V.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvVideoLibQuantitySenateItems_Avg_V_Cond.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenateItems_Avg_V.FuncModuleName, objvVideoLibQuantitySenateItems_Avg_V_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvVideoLibQuantitySenateItems_Avg_V_Cond.IsUpdated(convVideoLibQuantitySenateItems_Avg_V.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvVideoLibQuantitySenateItems_Avg_V_Cond.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenateItems_Avg_V.id_MicroteachCase, objvVideoLibQuantitySenateItems_Avg_V_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvVideoLibQuantitySenateItems_Avg_V_Cond.IsUpdated(convVideoLibQuantitySenateItems_Avg_V.VideoLibID) == true)
{
string strComparisonOp_VideoLibID = objvVideoLibQuantitySenateItems_Avg_V_Cond.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.VideoLibID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenateItems_Avg_V.VideoLibID, objvVideoLibQuantitySenateItems_Avg_V_Cond.VideoLibID, strComparisonOp_VideoLibID);
}
if (objvVideoLibQuantitySenateItems_Avg_V_Cond.IsUpdated(convVideoLibQuantitySenateItems_Avg_V.VideoLibName) == true)
{
string strComparisonOp_VideoLibName = objvVideoLibQuantitySenateItems_Avg_V_Cond.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.VideoLibName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenateItems_Avg_V.VideoLibName, objvVideoLibQuantitySenateItems_Avg_V_Cond.VideoLibName, strComparisonOp_VideoLibName);
}
if (objvVideoLibQuantitySenateItems_Avg_V_Cond.IsUpdated(convVideoLibQuantitySenateItems_Avg_V.id_AppraiseType) == true)
{
string strComparisonOp_id_AppraiseType = objvVideoLibQuantitySenateItems_Avg_V_Cond.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.id_AppraiseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenateItems_Avg_V.id_AppraiseType, objvVideoLibQuantitySenateItems_Avg_V_Cond.id_AppraiseType, strComparisonOp_id_AppraiseType);
}
if (objvVideoLibQuantitySenateItems_Avg_V_Cond.IsUpdated(convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName) == true)
{
string strComparisonOp_AppraiseTypeName = objvVideoLibQuantitySenateItems_Avg_V_Cond.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName, objvVideoLibQuantitySenateItems_Avg_V_Cond.AppraiseTypeName, strComparisonOp_AppraiseTypeName);
}
if (objvVideoLibQuantitySenateItems_Avg_V_Cond.IsUpdated(convVideoLibQuantitySenateItems_Avg_V.SenateDate) == true)
{
string strComparisonOp_SenateDate = objvVideoLibQuantitySenateItems_Avg_V_Cond.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.SenateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenateItems_Avg_V.SenateDate, objvVideoLibQuantitySenateItems_Avg_V_Cond.SenateDate, strComparisonOp_SenateDate);
}
if (objvVideoLibQuantitySenateItems_Avg_V_Cond.IsUpdated(convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvVideoLibQuantitySenateItems_Avg_V_Cond.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName, objvVideoLibQuantitySenateItems_Avg_V_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvVideoLibQuantitySenateItems_Avg_V_Cond.IsUpdated(convVideoLibQuantitySenateItems_Avg_V.UserName) == true)
{
string strComparisonOp_UserName = objvVideoLibQuantitySenateItems_Avg_V_Cond.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenateItems_Avg_V.UserName, objvVideoLibQuantitySenateItems_Avg_V_Cond.UserName, strComparisonOp_UserName);
}
if (objvVideoLibQuantitySenateItems_Avg_V_Cond.IsUpdated(convVideoLibQuantitySenateItems_Avg_V.id_SenateGaugeItem) == true)
{
string strComparisonOp_id_SenateGaugeItem = objvVideoLibQuantitySenateItems_Avg_V_Cond.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.id_SenateGaugeItem];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenateItems_Avg_V.id_SenateGaugeItem, objvVideoLibQuantitySenateItems_Avg_V_Cond.id_SenateGaugeItem, strComparisonOp_id_SenateGaugeItem);
}
if (objvVideoLibQuantitySenateItems_Avg_V_Cond.IsUpdated(convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName) == true)
{
string strComparisonOp_senateGaugeItemName = objvVideoLibQuantitySenateItems_Avg_V_Cond.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName, objvVideoLibQuantitySenateItems_Avg_V_Cond.senateGaugeItemName, strComparisonOp_senateGaugeItemName);
}
if (objvVideoLibQuantitySenateItems_Avg_V_Cond.IsUpdated(convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight) == true)
{
string strComparisonOp_senateGaugeItemWeight = objvVideoLibQuantitySenateItems_Avg_V_Cond.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight, objvVideoLibQuantitySenateItems_Avg_V_Cond.senateGaugeItemWeight, strComparisonOp_senateGaugeItemWeight);
}
if (objvVideoLibQuantitySenateItems_Avg_V_Cond.IsUpdated(convVideoLibQuantitySenateItems_Avg_V.SenateScore_Avg) == true)
{
string strComparisonOp_SenateScore_Avg = objvVideoLibQuantitySenateItems_Avg_V_Cond.dicFldComparisonOp[convVideoLibQuantitySenateItems_Avg_V.SenateScore_Avg];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLibQuantitySenateItems_Avg_V.SenateScore_Avg, objvVideoLibQuantitySenateItems_Avg_V_Cond.SenateScore_Avg, strComparisonOp_SenateScore_Avg);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v视频库量化评价详细表_Avg_V(vVideoLibQuantitySenateItems_Avg_V)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvVideoLibQuantitySenateItems_Avg_VWApi
{
private static readonly string mstrApiControllerName = "vVideoLibQuantitySenateItems_Avg_VApi";

 public clsvVideoLibQuantitySenateItems_Avg_VWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_microteachCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsvVideoLibQuantitySenateItems_Avg_VEN GetObjByid_microteachCaseQuantitySenate(long lngid_microteachCaseQuantitySenate)
{
string strAction = "GetObjByid_microteachCaseQuantitySenate";
string strErrMsg = string.Empty;
string strResult = "";
clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN = null;
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
objvVideoLibQuantitySenateItems_Avg_VEN = JsonConvert.DeserializeObject<clsvVideoLibQuantitySenateItems_Avg_VEN>((string)jobjReturn["ReturnObj"]);
return objvVideoLibQuantitySenateItems_Avg_VEN;
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
public static clsvVideoLibQuantitySenateItems_Avg_VEN GetObjByid_microteachCaseQuantitySenate_WA_Cache(long lngid_microteachCaseQuantitySenate)
{
string strAction = "GetObjByid_microteachCaseQuantitySenate_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN = null;
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
objvVideoLibQuantitySenateItems_Avg_VEN = JsonConvert.DeserializeObject<clsvVideoLibQuantitySenateItems_Avg_VEN>((string)jobjReturn["ReturnObj"]);
return objvVideoLibQuantitySenateItems_Avg_VEN;
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
public static clsvVideoLibQuantitySenateItems_Avg_VEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VEN = null;
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
objvVideoLibQuantitySenateItems_Avg_VEN = JsonConvert.DeserializeObject<clsvVideoLibQuantitySenateItems_Avg_VEN>((string)jobjReturn["ReturnObj"]);
return objvVideoLibQuantitySenateItems_Avg_VEN;
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
public static clsvVideoLibQuantitySenateItems_Avg_VEN GetObjByid_microteachCaseQuantitySenate_Cache(long lngid_microteachCaseQuantitySenate)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvVideoLibQuantitySenateItems_Avg_VEN._CurrTabName_S);
List<clsvVideoLibQuantitySenateItems_Avg_VEN> arrvVideoLibQuantitySenateItems_Avg_VObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvVideoLibQuantitySenateItems_Avg_VEN> arrvVideoLibQuantitySenateItems_Avg_VObjLst_Sel =
from objvVideoLibQuantitySenateItems_Avg_VEN in arrvVideoLibQuantitySenateItems_Avg_VObjLst_Cache
where objvVideoLibQuantitySenateItems_Avg_VEN.id_microteachCaseQuantitySenate == lngid_microteachCaseQuantitySenate
select objvVideoLibQuantitySenateItems_Avg_VEN;
if (arrvVideoLibQuantitySenateItems_Avg_VObjLst_Sel.Count() == 0)
{
   clsvVideoLibQuantitySenateItems_Avg_VEN obj = clsvVideoLibQuantitySenateItems_Avg_VWApi.GetObjByid_microteachCaseQuantitySenate(lngid_microteachCaseQuantitySenate);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvVideoLibQuantitySenateItems_Avg_VObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoLibQuantitySenateItems_Avg_VEN> GetObjLst(string strWhereCond)
{
 List<clsvVideoLibQuantitySenateItems_Avg_VEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLibQuantitySenateItems_Avg_VEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoLibQuantitySenateItems_Avg_VEN> GetObjLstById_microteachCaseQuantitySenateLst(List<long> arrId_microteachCaseQuantitySenate)
{
 List<clsvVideoLibQuantitySenateItems_Avg_VEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLibQuantitySenateItems_Avg_VEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvVideoLibQuantitySenateItems_Avg_VEN> GetObjLstById_microteachCaseQuantitySenateLst_Cache(List<long> arrId_microteachCaseQuantitySenate)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvVideoLibQuantitySenateItems_Avg_VEN._CurrTabName_S);
List<clsvVideoLibQuantitySenateItems_Avg_VEN> arrvVideoLibQuantitySenateItems_Avg_VObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvVideoLibQuantitySenateItems_Avg_VEN> arrvVideoLibQuantitySenateItems_Avg_VObjLst_Sel =
from objvVideoLibQuantitySenateItems_Avg_VEN in arrvVideoLibQuantitySenateItems_Avg_VObjLst_Cache
where arrId_microteachCaseQuantitySenate.Contains(objvVideoLibQuantitySenateItems_Avg_VEN.id_microteachCaseQuantitySenate)
select objvVideoLibQuantitySenateItems_Avg_VEN;
return arrvVideoLibQuantitySenateItems_Avg_VObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoLibQuantitySenateItems_Avg_VEN> GetObjLstById_microteachCaseQuantitySenateLst_WA_Cache(List<long> arrId_microteachCaseQuantitySenate)
{
 List<clsvVideoLibQuantitySenateItems_Avg_VEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLibQuantitySenateItems_Avg_VEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoLibQuantitySenateItems_Avg_VEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvVideoLibQuantitySenateItems_Avg_VEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLibQuantitySenateItems_Avg_VEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoLibQuantitySenateItems_Avg_VEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvVideoLibQuantitySenateItems_Avg_VEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLibQuantitySenateItems_Avg_VEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoLibQuantitySenateItems_Avg_VEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvVideoLibQuantitySenateItems_Avg_VEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLibQuantitySenateItems_Avg_VEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoLibQuantitySenateItems_Avg_VEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvVideoLibQuantitySenateItems_Avg_VEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLibQuantitySenateItems_Avg_VEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvVideoLibQuantitySenateItems_Avg_VENS">源对象</param>
 /// <param name = "objvVideoLibQuantitySenateItems_Avg_VENT">目标对象</param>
 public static void CopyTo(clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VENS, clsvVideoLibQuantitySenateItems_Avg_VEN objvVideoLibQuantitySenateItems_Avg_VENT)
{
try
{
objvVideoLibQuantitySenateItems_Avg_VENT.id_microteachCaseQuantitySenate = objvVideoLibQuantitySenateItems_Avg_VENS.id_microteachCaseQuantitySenate; //微格量化评价流水号
objvVideoLibQuantitySenateItems_Avg_VENT.FuncModuleId = objvVideoLibQuantitySenateItems_Avg_VENS.FuncModuleId; //功能模块Id
objvVideoLibQuantitySenateItems_Avg_VENT.FuncModuleName = objvVideoLibQuantitySenateItems_Avg_VENS.FuncModuleName; //功能模块名称
objvVideoLibQuantitySenateItems_Avg_VENT.id_MicroteachCase = objvVideoLibQuantitySenateItems_Avg_VENS.id_MicroteachCase; //微格教学案例流水号
objvVideoLibQuantitySenateItems_Avg_VENT.VideoLibID = objvVideoLibQuantitySenateItems_Avg_VENS.VideoLibID; //视频库ID
objvVideoLibQuantitySenateItems_Avg_VENT.VideoLibName = objvVideoLibQuantitySenateItems_Avg_VENS.VideoLibName; //视频名称
objvVideoLibQuantitySenateItems_Avg_VENT.id_AppraiseType = objvVideoLibQuantitySenateItems_Avg_VENS.id_AppraiseType; //评议类型流水号
objvVideoLibQuantitySenateItems_Avg_VENT.AppraiseTypeName = objvVideoLibQuantitySenateItems_Avg_VENS.AppraiseTypeName; //评议类型名称
objvVideoLibQuantitySenateItems_Avg_VENT.SenateDate = objvVideoLibQuantitySenateItems_Avg_VENS.SenateDate; //评价日期
objvVideoLibQuantitySenateItems_Avg_VENT.senateGaugeVersionName = objvVideoLibQuantitySenateItems_Avg_VENS.senateGaugeVersionName; //评价量表版本名称
objvVideoLibQuantitySenateItems_Avg_VENT.UserName = objvVideoLibQuantitySenateItems_Avg_VENS.UserName; //用户名
objvVideoLibQuantitySenateItems_Avg_VENT.id_SenateGaugeItem = objvVideoLibQuantitySenateItems_Avg_VENS.id_SenateGaugeItem; //量表指标流水号
objvVideoLibQuantitySenateItems_Avg_VENT.senateGaugeItemName = objvVideoLibQuantitySenateItems_Avg_VENS.senateGaugeItemName; //量表指标名称
objvVideoLibQuantitySenateItems_Avg_VENT.senateGaugeItemWeight = objvVideoLibQuantitySenateItems_Avg_VENS.senateGaugeItemWeight; //量表指标权重
objvVideoLibQuantitySenateItems_Avg_VENT.SenateScore_Avg = objvVideoLibQuantitySenateItems_Avg_VENS.SenateScore_Avg; //评议平均分
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
public static DataTable ToDataTable(List<clsvVideoLibQuantitySenateItems_Avg_VEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvVideoLibQuantitySenateItems_Avg_VEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvVideoLibQuantitySenateItems_Avg_VEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvVideoLibQuantitySenateItems_Avg_VEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvVideoLibQuantitySenateItems_Avg_VEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvVideoLibQuantitySenateItems_Avg_VEN.AttributeName)
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
if (clsSenateGaugeItemsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeItemsWApi没有刷新缓存机制(clsSenateGaugeItemsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
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
if (clsUserTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserTypeWApi没有刷新缓存机制(clsUserTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserKindWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserKindWApi没有刷新缓存机制(clsUserKindWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroteachCaseQuantitySenateWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCaseQuantitySenateWApi没有刷新缓存机制(clsMicroteachCaseQuantitySenateWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroteachCaseQuantitySenateItemsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachCaseQuantitySenateItemsWApi没有刷新缓存机制(clsMicroteachCaseQuantitySenateItemsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsVideoLibWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsVideoLibWApi没有刷新缓存机制(clsVideoLibWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRecommendedDegreeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRecommendedDegreeWApi没有刷新缓存机制(clsRecommendedDegreeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsVideoLibTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsVideoLibTypeWApi没有刷新缓存机制(clsVideoLibTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCaseLevelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseLevelWApi没有刷新缓存机制(clsCaseLevelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseWApi没有刷新缓存机制(clscc_CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseTypeWApi没有刷新缓存机制(clscc_CourseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExcellentTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExcellentTypeWApi没有刷新缓存机制(clscc_ExcellentTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ThemesWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ThemesWApi没有刷新缓存机制(clscc_ThemesWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseIsLikeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeWApi没有刷新缓存机制(clscc_CourseIsLikeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_microteachCaseQuantitySenate");
//if (arrvVideoLibQuantitySenateItems_Avg_VObjLst_Cache == null)
//{
//arrvVideoLibQuantitySenateItems_Avg_VObjLst_Cache = await clsvVideoLibQuantitySenateItems_Avg_VWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvVideoLibQuantitySenateItems_Avg_VEN._CurrTabName_S);
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
public static List<clsvVideoLibQuantitySenateItems_Avg_VEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvVideoLibQuantitySenateItems_Avg_VEN._CurrTabName_S);
List<clsvVideoLibQuantitySenateItems_Avg_VEN> arrvVideoLibQuantitySenateItems_Avg_VObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvVideoLibQuantitySenateItems_Avg_VObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvVideoLibQuantitySenateItems_Avg_VEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convVideoLibQuantitySenateItems_Avg_V.id_microteachCaseQuantitySenate, Type.GetType("System.Int64"));
objDT.Columns.Add(convVideoLibQuantitySenateItems_Avg_V.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenateItems_Avg_V.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenateItems_Avg_V.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenateItems_Avg_V.VideoLibID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenateItems_Avg_V.VideoLibName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenateItems_Avg_V.id_AppraiseType, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenateItems_Avg_V.SenateDate, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenateItems_Avg_V.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenateItems_Avg_V.id_SenateGaugeItem, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight, Type.GetType("System.Single"));
objDT.Columns.Add(convVideoLibQuantitySenateItems_Avg_V.SenateScore_Avg, Type.GetType("System.Single"));
foreach (clsvVideoLibQuantitySenateItems_Avg_VEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convVideoLibQuantitySenateItems_Avg_V.id_microteachCaseQuantitySenate] = objInFor[convVideoLibQuantitySenateItems_Avg_V.id_microteachCaseQuantitySenate];
objDR[convVideoLibQuantitySenateItems_Avg_V.FuncModuleId] = objInFor[convVideoLibQuantitySenateItems_Avg_V.FuncModuleId];
objDR[convVideoLibQuantitySenateItems_Avg_V.FuncModuleName] = objInFor[convVideoLibQuantitySenateItems_Avg_V.FuncModuleName];
objDR[convVideoLibQuantitySenateItems_Avg_V.id_MicroteachCase] = objInFor[convVideoLibQuantitySenateItems_Avg_V.id_MicroteachCase];
objDR[convVideoLibQuantitySenateItems_Avg_V.VideoLibID] = objInFor[convVideoLibQuantitySenateItems_Avg_V.VideoLibID];
objDR[convVideoLibQuantitySenateItems_Avg_V.VideoLibName] = objInFor[convVideoLibQuantitySenateItems_Avg_V.VideoLibName];
objDR[convVideoLibQuantitySenateItems_Avg_V.id_AppraiseType] = objInFor[convVideoLibQuantitySenateItems_Avg_V.id_AppraiseType];
objDR[convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName] = objInFor[convVideoLibQuantitySenateItems_Avg_V.AppraiseTypeName];
objDR[convVideoLibQuantitySenateItems_Avg_V.SenateDate] = objInFor[convVideoLibQuantitySenateItems_Avg_V.SenateDate];
objDR[convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName] = objInFor[convVideoLibQuantitySenateItems_Avg_V.senateGaugeVersionName];
objDR[convVideoLibQuantitySenateItems_Avg_V.UserName] = objInFor[convVideoLibQuantitySenateItems_Avg_V.UserName];
objDR[convVideoLibQuantitySenateItems_Avg_V.id_SenateGaugeItem] = objInFor[convVideoLibQuantitySenateItems_Avg_V.id_SenateGaugeItem];
objDR[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName] = objInFor[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemName];
objDR[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight] = objInFor[convVideoLibQuantitySenateItems_Avg_V.senateGaugeItemWeight];
objDR[convVideoLibQuantitySenateItems_Avg_V.SenateScore_Avg] = objInFor[convVideoLibQuantitySenateItems_Avg_V.SenateScore_Avg];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}