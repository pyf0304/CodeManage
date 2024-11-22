
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCourseLearningCaseQuantitySenateItems_Avg_VWApi
 表名:vCourseLearningCaseQuantitySenateItems_Avg_V(01120474)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:44:06
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习
 模块英文名:CourseLearning
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
public static class clsvCourseLearningCaseQuantitySenateItems_Avg_VWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateItems_Avg_VEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateItems_Avg_VEN Setid_microteachCaseQuantitySenate(this clsvCourseLearningCaseQuantitySenateItems_Avg_VEN objvCourseLearningCaseQuantitySenateItems_Avg_VEN, long lngid_microteachCaseQuantitySenate, string strComparisonOp="")
	{
objvCourseLearningCaseQuantitySenateItems_Avg_VEN.id_microteachCaseQuantitySenate = lngid_microteachCaseQuantitySenate; //微格量化评价流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateItems_Avg_VEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenateItems_Avg_V.id_microteachCaseQuantitySenate) == false)
{
objvCourseLearningCaseQuantitySenateItems_Avg_VEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenateItems_Avg_V.id_microteachCaseQuantitySenate, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateItems_Avg_VEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenateItems_Avg_V.id_microteachCaseQuantitySenate] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateItems_Avg_VEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateItems_Avg_VEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateItems_Avg_VEN Setid_MicroteachCase(this clsvCourseLearningCaseQuantitySenateItems_Avg_VEN objvCourseLearningCaseQuantitySenateItems_Avg_VEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convCourseLearningCaseQuantitySenateItems_Avg_V.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convCourseLearningCaseQuantitySenateItems_Avg_V.id_MicroteachCase);
objvCourseLearningCaseQuantitySenateItems_Avg_VEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateItems_Avg_VEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenateItems_Avg_V.id_MicroteachCase) == false)
{
objvCourseLearningCaseQuantitySenateItems_Avg_VEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenateItems_Avg_V.id_MicroteachCase, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateItems_Avg_VEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenateItems_Avg_V.id_MicroteachCase] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateItems_Avg_VEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateItems_Avg_VEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateItems_Avg_VEN Setid_AppraiseType(this clsvCourseLearningCaseQuantitySenateItems_Avg_VEN objvCourseLearningCaseQuantitySenateItems_Avg_VEN, string strid_AppraiseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_AppraiseType, 4, convCourseLearningCaseQuantitySenateItems_Avg_V.id_AppraiseType);
clsCheckSql.CheckFieldForeignKey(strid_AppraiseType, 4, convCourseLearningCaseQuantitySenateItems_Avg_V.id_AppraiseType);
objvCourseLearningCaseQuantitySenateItems_Avg_VEN.id_AppraiseType = strid_AppraiseType; //评议类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateItems_Avg_VEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenateItems_Avg_V.id_AppraiseType) == false)
{
objvCourseLearningCaseQuantitySenateItems_Avg_VEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenateItems_Avg_V.id_AppraiseType, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateItems_Avg_VEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenateItems_Avg_V.id_AppraiseType] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateItems_Avg_VEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateItems_Avg_VEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateItems_Avg_VEN SetAppraiseTypeName(this clsvCourseLearningCaseQuantitySenateItems_Avg_VEN objvCourseLearningCaseQuantitySenateItems_Avg_VEN, string strAppraiseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAppraiseTypeName, 50, convCourseLearningCaseQuantitySenateItems_Avg_V.AppraiseTypeName);
objvCourseLearningCaseQuantitySenateItems_Avg_VEN.AppraiseTypeName = strAppraiseTypeName; //评议类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateItems_Avg_VEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenateItems_Avg_V.AppraiseTypeName) == false)
{
objvCourseLearningCaseQuantitySenateItems_Avg_VEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenateItems_Avg_V.AppraiseTypeName, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateItems_Avg_VEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenateItems_Avg_V.AppraiseTypeName] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateItems_Avg_VEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateItems_Avg_VEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateItems_Avg_VEN SetSenateDate(this clsvCourseLearningCaseQuantitySenateItems_Avg_VEN objvCourseLearningCaseQuantitySenateItems_Avg_VEN, string strSenateDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSenateDate, 8, convCourseLearningCaseQuantitySenateItems_Avg_V.SenateDate);
clsCheckSql.CheckFieldForeignKey(strSenateDate, 8, convCourseLearningCaseQuantitySenateItems_Avg_V.SenateDate);
objvCourseLearningCaseQuantitySenateItems_Avg_VEN.SenateDate = strSenateDate; //评价日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateItems_Avg_VEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenateItems_Avg_V.SenateDate) == false)
{
objvCourseLearningCaseQuantitySenateItems_Avg_VEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenateItems_Avg_V.SenateDate, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateItems_Avg_VEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenateItems_Avg_V.SenateDate] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateItems_Avg_VEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateItems_Avg_VEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateItems_Avg_VEN Setid_SenateGaugeItem(this clsvCourseLearningCaseQuantitySenateItems_Avg_VEN objvCourseLearningCaseQuantitySenateItems_Avg_VEN, string strid_SenateGaugeItem, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_SenateGaugeItem, convCourseLearningCaseQuantitySenateItems_Avg_V.id_SenateGaugeItem);
clsCheckSql.CheckFieldLen(strid_SenateGaugeItem, 4, convCourseLearningCaseQuantitySenateItems_Avg_V.id_SenateGaugeItem);
clsCheckSql.CheckFieldForeignKey(strid_SenateGaugeItem, 4, convCourseLearningCaseQuantitySenateItems_Avg_V.id_SenateGaugeItem);
objvCourseLearningCaseQuantitySenateItems_Avg_VEN.id_SenateGaugeItem = strid_SenateGaugeItem; //量表指标流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateItems_Avg_VEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenateItems_Avg_V.id_SenateGaugeItem) == false)
{
objvCourseLearningCaseQuantitySenateItems_Avg_VEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenateItems_Avg_V.id_SenateGaugeItem, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateItems_Avg_VEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenateItems_Avg_V.id_SenateGaugeItem] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateItems_Avg_VEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateItems_Avg_VEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateItems_Avg_VEN SetsenateGaugeItemName(this clsvCourseLearningCaseQuantitySenateItems_Avg_VEN objvCourseLearningCaseQuantitySenateItems_Avg_VEN, string strsenateGaugeItemName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeItemName, 200, convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeItemName);
objvCourseLearningCaseQuantitySenateItems_Avg_VEN.senateGaugeItemName = strsenateGaugeItemName; //量表指标名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateItems_Avg_VEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeItemName) == false)
{
objvCourseLearningCaseQuantitySenateItems_Avg_VEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeItemName, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateItems_Avg_VEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeItemName] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateItems_Avg_VEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateItems_Avg_VEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateItems_Avg_VEN SetsenateGaugeItemWeight(this clsvCourseLearningCaseQuantitySenateItems_Avg_VEN objvCourseLearningCaseQuantitySenateItems_Avg_VEN, float fltsenateGaugeItemWeight, string strComparisonOp="")
	{
objvCourseLearningCaseQuantitySenateItems_Avg_VEN.senateGaugeItemWeight = fltsenateGaugeItemWeight; //量表指标权重
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateItems_Avg_VEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeItemWeight) == false)
{
objvCourseLearningCaseQuantitySenateItems_Avg_VEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeItemWeight, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateItems_Avg_VEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeItemWeight] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateItems_Avg_VEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateItems_Avg_VEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateItems_Avg_VEN SetsenateGaugeVersionName(this clsvCourseLearningCaseQuantitySenateItems_Avg_VEN objvCourseLearningCaseQuantitySenateItems_Avg_VEN, string strsenateGaugeVersionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strsenateGaugeVersionName, 200, convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeVersionName);
objvCourseLearningCaseQuantitySenateItems_Avg_VEN.senateGaugeVersionName = strsenateGaugeVersionName; //评价量表版本名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateItems_Avg_VEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeVersionName) == false)
{
objvCourseLearningCaseQuantitySenateItems_Avg_VEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeVersionName, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateItems_Avg_VEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeVersionName] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateItems_Avg_VEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateItems_Avg_VEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateItems_Avg_VEN SetFuncModuleName(this clsvCourseLearningCaseQuantitySenateItems_Avg_VEN objvCourseLearningCaseQuantitySenateItems_Avg_VEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convCourseLearningCaseQuantitySenateItems_Avg_V.FuncModuleName);
objvCourseLearningCaseQuantitySenateItems_Avg_VEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateItems_Avg_VEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenateItems_Avg_V.FuncModuleName) == false)
{
objvCourseLearningCaseQuantitySenateItems_Avg_VEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenateItems_Avg_V.FuncModuleName, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateItems_Avg_VEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenateItems_Avg_V.FuncModuleName] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateItems_Avg_VEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateItems_Avg_VEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateItems_Avg_VEN SetFuncModuleId(this clsvCourseLearningCaseQuantitySenateItems_Avg_VEN objvCourseLearningCaseQuantitySenateItems_Avg_VEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convCourseLearningCaseQuantitySenateItems_Avg_V.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convCourseLearningCaseQuantitySenateItems_Avg_V.FuncModuleId);
objvCourseLearningCaseQuantitySenateItems_Avg_VEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateItems_Avg_VEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenateItems_Avg_V.FuncModuleId) == false)
{
objvCourseLearningCaseQuantitySenateItems_Avg_VEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenateItems_Avg_V.FuncModuleId, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateItems_Avg_VEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenateItems_Avg_V.FuncModuleId] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateItems_Avg_VEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateItems_Avg_VEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateItems_Avg_VEN SetUserName(this clsvCourseLearningCaseQuantitySenateItems_Avg_VEN objvCourseLearningCaseQuantitySenateItems_Avg_VEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserName, 50, convCourseLearningCaseQuantitySenateItems_Avg_V.UserName);
objvCourseLearningCaseQuantitySenateItems_Avg_VEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateItems_Avg_VEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenateItems_Avg_V.UserName) == false)
{
objvCourseLearningCaseQuantitySenateItems_Avg_VEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenateItems_Avg_V.UserName, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateItems_Avg_VEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenateItems_Avg_V.UserName] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateItems_Avg_VEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateItems_Avg_VEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateItems_Avg_VEN SetSenateScore_Avg(this clsvCourseLearningCaseQuantitySenateItems_Avg_VEN objvCourseLearningCaseQuantitySenateItems_Avg_VEN, float fltSenateScore_Avg, string strComparisonOp="")
	{
objvCourseLearningCaseQuantitySenateItems_Avg_VEN.SenateScore_Avg = fltSenateScore_Avg; //评议平均分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateItems_Avg_VEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenateItems_Avg_V.SenateScore_Avg) == false)
{
objvCourseLearningCaseQuantitySenateItems_Avg_VEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenateItems_Avg_V.SenateScore_Avg, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateItems_Avg_VEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenateItems_Avg_V.SenateScore_Avg] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateItems_Avg_VEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateItems_Avg_VEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateItems_Avg_VEN SetCourseLearningCaseID(this clsvCourseLearningCaseQuantitySenateItems_Avg_VEN objvCourseLearningCaseQuantitySenateItems_Avg_VEN, string strCourseLearningCaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseID, 8, convCourseLearningCaseQuantitySenateItems_Avg_V.CourseLearningCaseID);
clsCheckSql.CheckFieldForeignKey(strCourseLearningCaseID, 8, convCourseLearningCaseQuantitySenateItems_Avg_V.CourseLearningCaseID);
objvCourseLearningCaseQuantitySenateItems_Avg_VEN.CourseLearningCaseID = strCourseLearningCaseID; //课程学习案例ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateItems_Avg_VEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenateItems_Avg_V.CourseLearningCaseID) == false)
{
objvCourseLearningCaseQuantitySenateItems_Avg_VEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenateItems_Avg_V.CourseLearningCaseID, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateItems_Avg_VEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenateItems_Avg_V.CourseLearningCaseID] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateItems_Avg_VEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningCaseQuantitySenateItems_Avg_VEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCourseLearningCaseQuantitySenateItems_Avg_VEN SetCourseLearningCaseName(this clsvCourseLearningCaseQuantitySenateItems_Avg_VEN objvCourseLearningCaseQuantitySenateItems_Avg_VEN, string strCourseLearningCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseLearningCaseName, 100, convCourseLearningCaseQuantitySenateItems_Avg_V.CourseLearningCaseName);
objvCourseLearningCaseQuantitySenateItems_Avg_VEN.CourseLearningCaseName = strCourseLearningCaseName; //课程学习案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningCaseQuantitySenateItems_Avg_VEN.dicFldComparisonOp.ContainsKey(convCourseLearningCaseQuantitySenateItems_Avg_V.CourseLearningCaseName) == false)
{
objvCourseLearningCaseQuantitySenateItems_Avg_VEN.dicFldComparisonOp.Add(convCourseLearningCaseQuantitySenateItems_Avg_V.CourseLearningCaseName, strComparisonOp);
}
else
{
objvCourseLearningCaseQuantitySenateItems_Avg_VEN.dicFldComparisonOp[convCourseLearningCaseQuantitySenateItems_Avg_V.CourseLearningCaseName] = strComparisonOp;
}
}
return objvCourseLearningCaseQuantitySenateItems_Avg_VEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCourseLearningCaseQuantitySenateItems_Avg_VEN objvCourseLearningCaseQuantitySenateItems_Avg_V_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCourseLearningCaseQuantitySenateItems_Avg_V_Cond.IsUpdated(convCourseLearningCaseQuantitySenateItems_Avg_V.id_microteachCaseQuantitySenate) == true)
{
string strComparisonOp_id_microteachCaseQuantitySenate = objvCourseLearningCaseQuantitySenateItems_Avg_V_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenateItems_Avg_V.id_microteachCaseQuantitySenate];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCaseQuantitySenateItems_Avg_V.id_microteachCaseQuantitySenate, objvCourseLearningCaseQuantitySenateItems_Avg_V_Cond.id_microteachCaseQuantitySenate, strComparisonOp_id_microteachCaseQuantitySenate);
}
if (objvCourseLearningCaseQuantitySenateItems_Avg_V_Cond.IsUpdated(convCourseLearningCaseQuantitySenateItems_Avg_V.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvCourseLearningCaseQuantitySenateItems_Avg_V_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenateItems_Avg_V.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenateItems_Avg_V.id_MicroteachCase, objvCourseLearningCaseQuantitySenateItems_Avg_V_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvCourseLearningCaseQuantitySenateItems_Avg_V_Cond.IsUpdated(convCourseLearningCaseQuantitySenateItems_Avg_V.id_AppraiseType) == true)
{
string strComparisonOp_id_AppraiseType = objvCourseLearningCaseQuantitySenateItems_Avg_V_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenateItems_Avg_V.id_AppraiseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenateItems_Avg_V.id_AppraiseType, objvCourseLearningCaseQuantitySenateItems_Avg_V_Cond.id_AppraiseType, strComparisonOp_id_AppraiseType);
}
if (objvCourseLearningCaseQuantitySenateItems_Avg_V_Cond.IsUpdated(convCourseLearningCaseQuantitySenateItems_Avg_V.AppraiseTypeName) == true)
{
string strComparisonOp_AppraiseTypeName = objvCourseLearningCaseQuantitySenateItems_Avg_V_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenateItems_Avg_V.AppraiseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenateItems_Avg_V.AppraiseTypeName, objvCourseLearningCaseQuantitySenateItems_Avg_V_Cond.AppraiseTypeName, strComparisonOp_AppraiseTypeName);
}
if (objvCourseLearningCaseQuantitySenateItems_Avg_V_Cond.IsUpdated(convCourseLearningCaseQuantitySenateItems_Avg_V.SenateDate) == true)
{
string strComparisonOp_SenateDate = objvCourseLearningCaseQuantitySenateItems_Avg_V_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenateItems_Avg_V.SenateDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenateItems_Avg_V.SenateDate, objvCourseLearningCaseQuantitySenateItems_Avg_V_Cond.SenateDate, strComparisonOp_SenateDate);
}
if (objvCourseLearningCaseQuantitySenateItems_Avg_V_Cond.IsUpdated(convCourseLearningCaseQuantitySenateItems_Avg_V.id_SenateGaugeItem) == true)
{
string strComparisonOp_id_SenateGaugeItem = objvCourseLearningCaseQuantitySenateItems_Avg_V_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenateItems_Avg_V.id_SenateGaugeItem];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenateItems_Avg_V.id_SenateGaugeItem, objvCourseLearningCaseQuantitySenateItems_Avg_V_Cond.id_SenateGaugeItem, strComparisonOp_id_SenateGaugeItem);
}
if (objvCourseLearningCaseQuantitySenateItems_Avg_V_Cond.IsUpdated(convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeItemName) == true)
{
string strComparisonOp_senateGaugeItemName = objvCourseLearningCaseQuantitySenateItems_Avg_V_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeItemName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeItemName, objvCourseLearningCaseQuantitySenateItems_Avg_V_Cond.senateGaugeItemName, strComparisonOp_senateGaugeItemName);
}
if (objvCourseLearningCaseQuantitySenateItems_Avg_V_Cond.IsUpdated(convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeItemWeight) == true)
{
string strComparisonOp_senateGaugeItemWeight = objvCourseLearningCaseQuantitySenateItems_Avg_V_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeItemWeight];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeItemWeight, objvCourseLearningCaseQuantitySenateItems_Avg_V_Cond.senateGaugeItemWeight, strComparisonOp_senateGaugeItemWeight);
}
if (objvCourseLearningCaseQuantitySenateItems_Avg_V_Cond.IsUpdated(convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeVersionName) == true)
{
string strComparisonOp_senateGaugeVersionName = objvCourseLearningCaseQuantitySenateItems_Avg_V_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeVersionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeVersionName, objvCourseLearningCaseQuantitySenateItems_Avg_V_Cond.senateGaugeVersionName, strComparisonOp_senateGaugeVersionName);
}
if (objvCourseLearningCaseQuantitySenateItems_Avg_V_Cond.IsUpdated(convCourseLearningCaseQuantitySenateItems_Avg_V.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvCourseLearningCaseQuantitySenateItems_Avg_V_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenateItems_Avg_V.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenateItems_Avg_V.FuncModuleName, objvCourseLearningCaseQuantitySenateItems_Avg_V_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvCourseLearningCaseQuantitySenateItems_Avg_V_Cond.IsUpdated(convCourseLearningCaseQuantitySenateItems_Avg_V.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvCourseLearningCaseQuantitySenateItems_Avg_V_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenateItems_Avg_V.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenateItems_Avg_V.FuncModuleId, objvCourseLearningCaseQuantitySenateItems_Avg_V_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvCourseLearningCaseQuantitySenateItems_Avg_V_Cond.IsUpdated(convCourseLearningCaseQuantitySenateItems_Avg_V.UserName) == true)
{
string strComparisonOp_UserName = objvCourseLearningCaseQuantitySenateItems_Avg_V_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenateItems_Avg_V.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenateItems_Avg_V.UserName, objvCourseLearningCaseQuantitySenateItems_Avg_V_Cond.UserName, strComparisonOp_UserName);
}
if (objvCourseLearningCaseQuantitySenateItems_Avg_V_Cond.IsUpdated(convCourseLearningCaseQuantitySenateItems_Avg_V.SenateScore_Avg) == true)
{
string strComparisonOp_SenateScore_Avg = objvCourseLearningCaseQuantitySenateItems_Avg_V_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenateItems_Avg_V.SenateScore_Avg];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningCaseQuantitySenateItems_Avg_V.SenateScore_Avg, objvCourseLearningCaseQuantitySenateItems_Avg_V_Cond.SenateScore_Avg, strComparisonOp_SenateScore_Avg);
}
if (objvCourseLearningCaseQuantitySenateItems_Avg_V_Cond.IsUpdated(convCourseLearningCaseQuantitySenateItems_Avg_V.CourseLearningCaseID) == true)
{
string strComparisonOp_CourseLearningCaseID = objvCourseLearningCaseQuantitySenateItems_Avg_V_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenateItems_Avg_V.CourseLearningCaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenateItems_Avg_V.CourseLearningCaseID, objvCourseLearningCaseQuantitySenateItems_Avg_V_Cond.CourseLearningCaseID, strComparisonOp_CourseLearningCaseID);
}
if (objvCourseLearningCaseQuantitySenateItems_Avg_V_Cond.IsUpdated(convCourseLearningCaseQuantitySenateItems_Avg_V.CourseLearningCaseName) == true)
{
string strComparisonOp_CourseLearningCaseName = objvCourseLearningCaseQuantitySenateItems_Avg_V_Cond.dicFldComparisonOp[convCourseLearningCaseQuantitySenateItems_Avg_V.CourseLearningCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningCaseQuantitySenateItems_Avg_V.CourseLearningCaseName, objvCourseLearningCaseQuantitySenateItems_Avg_V_Cond.CourseLearningCaseName, strComparisonOp_CourseLearningCaseName);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v课程学习量化评价详细表_Avg_V(vCourseLearningCaseQuantitySenateItems_Avg_V)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCourseLearningCaseQuantitySenateItems_Avg_VWApi
{
private static readonly string mstrApiControllerName = "vCourseLearningCaseQuantitySenateItems_Avg_VApi";

 public clsvCourseLearningCaseQuantitySenateItems_Avg_VWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_microteachCaseQuantitySenate">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCourseLearningCaseQuantitySenateItems_Avg_VEN GetObjByid_microteachCaseQuantitySenate(long lngid_microteachCaseQuantitySenate)
{
string strAction = "GetObjByid_microteachCaseQuantitySenate";
string strErrMsg = string.Empty;
string strResult = "";
clsvCourseLearningCaseQuantitySenateItems_Avg_VEN objvCourseLearningCaseQuantitySenateItems_Avg_VEN = null;
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
objvCourseLearningCaseQuantitySenateItems_Avg_VEN = JsonConvert.DeserializeObject<clsvCourseLearningCaseQuantitySenateItems_Avg_VEN>((string)jobjReturn["ReturnObj"]);
return objvCourseLearningCaseQuantitySenateItems_Avg_VEN;
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
public static clsvCourseLearningCaseQuantitySenateItems_Avg_VEN GetObjByid_microteachCaseQuantitySenate_WA_Cache(long lngid_microteachCaseQuantitySenate)
{
string strAction = "GetObjByid_microteachCaseQuantitySenate_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvCourseLearningCaseQuantitySenateItems_Avg_VEN objvCourseLearningCaseQuantitySenateItems_Avg_VEN = null;
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
objvCourseLearningCaseQuantitySenateItems_Avg_VEN = JsonConvert.DeserializeObject<clsvCourseLearningCaseQuantitySenateItems_Avg_VEN>((string)jobjReturn["ReturnObj"]);
return objvCourseLearningCaseQuantitySenateItems_Avg_VEN;
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
public static clsvCourseLearningCaseQuantitySenateItems_Avg_VEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvCourseLearningCaseQuantitySenateItems_Avg_VEN objvCourseLearningCaseQuantitySenateItems_Avg_VEN = null;
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
objvCourseLearningCaseQuantitySenateItems_Avg_VEN = JsonConvert.DeserializeObject<clsvCourseLearningCaseQuantitySenateItems_Avg_VEN>((string)jobjReturn["ReturnObj"]);
return objvCourseLearningCaseQuantitySenateItems_Avg_VEN;
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
public static clsvCourseLearningCaseQuantitySenateItems_Avg_VEN GetObjByid_microteachCaseQuantitySenate_Cache(long lngid_microteachCaseQuantitySenate)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCourseLearningCaseQuantitySenateItems_Avg_VEN._CurrTabName_S);
List<clsvCourseLearningCaseQuantitySenateItems_Avg_VEN> arrvCourseLearningCaseQuantitySenateItems_Avg_VObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCourseLearningCaseQuantitySenateItems_Avg_VEN> arrvCourseLearningCaseQuantitySenateItems_Avg_VObjLst_Sel =
from objvCourseLearningCaseQuantitySenateItems_Avg_VEN in arrvCourseLearningCaseQuantitySenateItems_Avg_VObjLst_Cache
where objvCourseLearningCaseQuantitySenateItems_Avg_VEN.id_microteachCaseQuantitySenate == lngid_microteachCaseQuantitySenate
select objvCourseLearningCaseQuantitySenateItems_Avg_VEN;
if (arrvCourseLearningCaseQuantitySenateItems_Avg_VObjLst_Sel.Count() == 0)
{
   clsvCourseLearningCaseQuantitySenateItems_Avg_VEN obj = clsvCourseLearningCaseQuantitySenateItems_Avg_VWApi.GetObjByid_microteachCaseQuantitySenate(lngid_microteachCaseQuantitySenate);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCourseLearningCaseQuantitySenateItems_Avg_VObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningCaseQuantitySenateItems_Avg_VEN> GetObjLst(string strWhereCond)
{
 List<clsvCourseLearningCaseQuantitySenateItems_Avg_VEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCaseQuantitySenateItems_Avg_VEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningCaseQuantitySenateItems_Avg_VEN> GetObjLstById_microteachCaseQuantitySenateLst(List<long> arrId_microteachCaseQuantitySenate)
{
 List<clsvCourseLearningCaseQuantitySenateItems_Avg_VEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCaseQuantitySenateItems_Avg_VEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvCourseLearningCaseQuantitySenateItems_Avg_VEN> GetObjLstById_microteachCaseQuantitySenateLst_Cache(List<long> arrId_microteachCaseQuantitySenate)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCourseLearningCaseQuantitySenateItems_Avg_VEN._CurrTabName_S);
List<clsvCourseLearningCaseQuantitySenateItems_Avg_VEN> arrvCourseLearningCaseQuantitySenateItems_Avg_VObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCourseLearningCaseQuantitySenateItems_Avg_VEN> arrvCourseLearningCaseQuantitySenateItems_Avg_VObjLst_Sel =
from objvCourseLearningCaseQuantitySenateItems_Avg_VEN in arrvCourseLearningCaseQuantitySenateItems_Avg_VObjLst_Cache
where arrId_microteachCaseQuantitySenate.Contains(objvCourseLearningCaseQuantitySenateItems_Avg_VEN.id_microteachCaseQuantitySenate)
select objvCourseLearningCaseQuantitySenateItems_Avg_VEN;
return arrvCourseLearningCaseQuantitySenateItems_Avg_VObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningCaseQuantitySenateItems_Avg_VEN> GetObjLstById_microteachCaseQuantitySenateLst_WA_Cache(List<long> arrId_microteachCaseQuantitySenate)
{
 List<clsvCourseLearningCaseQuantitySenateItems_Avg_VEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCaseQuantitySenateItems_Avg_VEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningCaseQuantitySenateItems_Avg_VEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCourseLearningCaseQuantitySenateItems_Avg_VEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCaseQuantitySenateItems_Avg_VEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningCaseQuantitySenateItems_Avg_VEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCourseLearningCaseQuantitySenateItems_Avg_VEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCaseQuantitySenateItems_Avg_VEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningCaseQuantitySenateItems_Avg_VEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCourseLearningCaseQuantitySenateItems_Avg_VEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCaseQuantitySenateItems_Avg_VEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCourseLearningCaseQuantitySenateItems_Avg_VEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvCourseLearningCaseQuantitySenateItems_Avg_VEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCourseLearningCaseQuantitySenateItems_Avg_VEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvCourseLearningCaseQuantitySenateItems_Avg_VENS">源对象</param>
 /// <param name = "objvCourseLearningCaseQuantitySenateItems_Avg_VENT">目标对象</param>
 public static void CopyTo(clsvCourseLearningCaseQuantitySenateItems_Avg_VEN objvCourseLearningCaseQuantitySenateItems_Avg_VENS, clsvCourseLearningCaseQuantitySenateItems_Avg_VEN objvCourseLearningCaseQuantitySenateItems_Avg_VENT)
{
try
{
objvCourseLearningCaseQuantitySenateItems_Avg_VENT.id_microteachCaseQuantitySenate = objvCourseLearningCaseQuantitySenateItems_Avg_VENS.id_microteachCaseQuantitySenate; //微格量化评价流水号
objvCourseLearningCaseQuantitySenateItems_Avg_VENT.id_MicroteachCase = objvCourseLearningCaseQuantitySenateItems_Avg_VENS.id_MicroteachCase; //微格教学案例流水号
objvCourseLearningCaseQuantitySenateItems_Avg_VENT.id_AppraiseType = objvCourseLearningCaseQuantitySenateItems_Avg_VENS.id_AppraiseType; //评议类型流水号
objvCourseLearningCaseQuantitySenateItems_Avg_VENT.AppraiseTypeName = objvCourseLearningCaseQuantitySenateItems_Avg_VENS.AppraiseTypeName; //评议类型名称
objvCourseLearningCaseQuantitySenateItems_Avg_VENT.SenateDate = objvCourseLearningCaseQuantitySenateItems_Avg_VENS.SenateDate; //评价日期
objvCourseLearningCaseQuantitySenateItems_Avg_VENT.id_SenateGaugeItem = objvCourseLearningCaseQuantitySenateItems_Avg_VENS.id_SenateGaugeItem; //量表指标流水号
objvCourseLearningCaseQuantitySenateItems_Avg_VENT.senateGaugeItemName = objvCourseLearningCaseQuantitySenateItems_Avg_VENS.senateGaugeItemName; //量表指标名称
objvCourseLearningCaseQuantitySenateItems_Avg_VENT.senateGaugeItemWeight = objvCourseLearningCaseQuantitySenateItems_Avg_VENS.senateGaugeItemWeight; //量表指标权重
objvCourseLearningCaseQuantitySenateItems_Avg_VENT.senateGaugeVersionName = objvCourseLearningCaseQuantitySenateItems_Avg_VENS.senateGaugeVersionName; //评价量表版本名称
objvCourseLearningCaseQuantitySenateItems_Avg_VENT.FuncModuleName = objvCourseLearningCaseQuantitySenateItems_Avg_VENS.FuncModuleName; //功能模块名称
objvCourseLearningCaseQuantitySenateItems_Avg_VENT.FuncModuleId = objvCourseLearningCaseQuantitySenateItems_Avg_VENS.FuncModuleId; //功能模块Id
objvCourseLearningCaseQuantitySenateItems_Avg_VENT.UserName = objvCourseLearningCaseQuantitySenateItems_Avg_VENS.UserName; //用户名
objvCourseLearningCaseQuantitySenateItems_Avg_VENT.SenateScore_Avg = objvCourseLearningCaseQuantitySenateItems_Avg_VENS.SenateScore_Avg; //评议平均分
objvCourseLearningCaseQuantitySenateItems_Avg_VENT.CourseLearningCaseID = objvCourseLearningCaseQuantitySenateItems_Avg_VENS.CourseLearningCaseID; //课程学习案例ID
objvCourseLearningCaseQuantitySenateItems_Avg_VENT.CourseLearningCaseName = objvCourseLearningCaseQuantitySenateItems_Avg_VENS.CourseLearningCaseName; //课程学习案例名称
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
public static DataTable ToDataTable(List<clsvCourseLearningCaseQuantitySenateItems_Avg_VEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCourseLearningCaseQuantitySenateItems_Avg_VEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCourseLearningCaseQuantitySenateItems_Avg_VEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCourseLearningCaseQuantitySenateItems_Avg_VEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCourseLearningCaseQuantitySenateItems_Avg_VEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCourseLearningCaseQuantitySenateItems_Avg_VEN.AttributeName)
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
if (clsStudyLevelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelWApi没有刷新缓存机制(clsStudyLevelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCourseLearningCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCourseLearningCaseWApi没有刷新缓存机制(clsCourseLearningCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCourseLearningCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCourseLearningCaseTypeWApi没有刷新缓存机制(clsCourseLearningCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseTypeWApi没有刷新缓存机制(clsCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDisciplineWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineWApi没有刷新缓存机制(clsDisciplineWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clscc_CourseChapterWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterWApi没有刷新缓存机制(clscc_CourseChapterWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzDegreeTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzDegreeTypeWApi没有刷新缓存机制(clsXzDegreeTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorTypeWApi没有刷新缓存机制(clsXzMajorTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorShoolTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorShoolTypeWApi没有刷新缓存机制(clsXzMajorShoolTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clscc_CourseIsLikeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeWApi没有刷新缓存机制(clscc_CourseIsLikeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_microteachCaseQuantitySenate");
//if (arrvCourseLearningCaseQuantitySenateItems_Avg_VObjLst_Cache == null)
//{
//arrvCourseLearningCaseQuantitySenateItems_Avg_VObjLst_Cache = await clsvCourseLearningCaseQuantitySenateItems_Avg_VWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvCourseLearningCaseQuantitySenateItems_Avg_VEN._CurrTabName_S);
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
public static List<clsvCourseLearningCaseQuantitySenateItems_Avg_VEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvCourseLearningCaseQuantitySenateItems_Avg_VEN._CurrTabName_S);
List<clsvCourseLearningCaseQuantitySenateItems_Avg_VEN> arrvCourseLearningCaseQuantitySenateItems_Avg_VObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCourseLearningCaseQuantitySenateItems_Avg_VObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCourseLearningCaseQuantitySenateItems_Avg_VEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCourseLearningCaseQuantitySenateItems_Avg_V.id_microteachCaseQuantitySenate, Type.GetType("System.Int64"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenateItems_Avg_V.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenateItems_Avg_V.id_AppraiseType, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenateItems_Avg_V.AppraiseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenateItems_Avg_V.SenateDate, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenateItems_Avg_V.id_SenateGaugeItem, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeItemName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeItemWeight, Type.GetType("System.Single"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeVersionName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenateItems_Avg_V.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenateItems_Avg_V.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenateItems_Avg_V.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenateItems_Avg_V.SenateScore_Avg, Type.GetType("System.Single"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenateItems_Avg_V.CourseLearningCaseID, Type.GetType("System.String"));
objDT.Columns.Add(convCourseLearningCaseQuantitySenateItems_Avg_V.CourseLearningCaseName, Type.GetType("System.String"));
foreach (clsvCourseLearningCaseQuantitySenateItems_Avg_VEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCourseLearningCaseQuantitySenateItems_Avg_V.id_microteachCaseQuantitySenate] = objInFor[convCourseLearningCaseQuantitySenateItems_Avg_V.id_microteachCaseQuantitySenate];
objDR[convCourseLearningCaseQuantitySenateItems_Avg_V.id_MicroteachCase] = objInFor[convCourseLearningCaseQuantitySenateItems_Avg_V.id_MicroteachCase];
objDR[convCourseLearningCaseQuantitySenateItems_Avg_V.id_AppraiseType] = objInFor[convCourseLearningCaseQuantitySenateItems_Avg_V.id_AppraiseType];
objDR[convCourseLearningCaseQuantitySenateItems_Avg_V.AppraiseTypeName] = objInFor[convCourseLearningCaseQuantitySenateItems_Avg_V.AppraiseTypeName];
objDR[convCourseLearningCaseQuantitySenateItems_Avg_V.SenateDate] = objInFor[convCourseLearningCaseQuantitySenateItems_Avg_V.SenateDate];
objDR[convCourseLearningCaseQuantitySenateItems_Avg_V.id_SenateGaugeItem] = objInFor[convCourseLearningCaseQuantitySenateItems_Avg_V.id_SenateGaugeItem];
objDR[convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeItemName] = objInFor[convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeItemName];
objDR[convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeItemWeight] = objInFor[convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeItemWeight];
objDR[convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeVersionName] = objInFor[convCourseLearningCaseQuantitySenateItems_Avg_V.senateGaugeVersionName];
objDR[convCourseLearningCaseQuantitySenateItems_Avg_V.FuncModuleName] = objInFor[convCourseLearningCaseQuantitySenateItems_Avg_V.FuncModuleName];
objDR[convCourseLearningCaseQuantitySenateItems_Avg_V.FuncModuleId] = objInFor[convCourseLearningCaseQuantitySenateItems_Avg_V.FuncModuleId];
objDR[convCourseLearningCaseQuantitySenateItems_Avg_V.UserName] = objInFor[convCourseLearningCaseQuantitySenateItems_Avg_V.UserName];
objDR[convCourseLearningCaseQuantitySenateItems_Avg_V.SenateScore_Avg] = objInFor[convCourseLearningCaseQuantitySenateItems_Avg_V.SenateScore_Avg];
objDR[convCourseLearningCaseQuantitySenateItems_Avg_V.CourseLearningCaseID] = objInFor[convCourseLearningCaseQuantitySenateItems_Avg_V.CourseLearningCaseID];
objDR[convCourseLearningCaseQuantitySenateItems_Avg_V.CourseLearningCaseName] = objInFor[convCourseLearningCaseQuantitySenateItems_Avg_V.CourseLearningCaseName];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}