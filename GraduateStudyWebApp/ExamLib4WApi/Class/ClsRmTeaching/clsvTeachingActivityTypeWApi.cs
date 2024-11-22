
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTeachingActivityTypeWApi
 表名:vTeachingActivityType(01120524)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:50:00
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课堂教学
 模块英文名:ClsRmTeaching
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
public static class clsvTeachingActivityTypeWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingActivityTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingActivityTypeEN SetTeachingActivityTypeId(this clsvTeachingActivityTypeEN objvTeachingActivityTypeEN, string strTeachingActivityTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingActivityTypeId, 2, convTeachingActivityType.TeachingActivityTypeId);
clsCheckSql.CheckFieldForeignKey(strTeachingActivityTypeId, 2, convTeachingActivityType.TeachingActivityTypeId);
objvTeachingActivityTypeEN.TeachingActivityTypeId = strTeachingActivityTypeId; //教学活动类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingActivityTypeEN.dicFldComparisonOp.ContainsKey(convTeachingActivityType.TeachingActivityTypeId) == false)
{
objvTeachingActivityTypeEN.dicFldComparisonOp.Add(convTeachingActivityType.TeachingActivityTypeId, strComparisonOp);
}
else
{
objvTeachingActivityTypeEN.dicFldComparisonOp[convTeachingActivityType.TeachingActivityTypeId] = strComparisonOp;
}
}
return objvTeachingActivityTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingActivityTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingActivityTypeEN SetTeachingActivityTypeName(this clsvTeachingActivityTypeEN objvTeachingActivityTypeEN, string strTeachingActivityTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachingActivityTypeName, convTeachingActivityType.TeachingActivityTypeName);
clsCheckSql.CheckFieldLen(strTeachingActivityTypeName, 30, convTeachingActivityType.TeachingActivityTypeName);
objvTeachingActivityTypeEN.TeachingActivityTypeName = strTeachingActivityTypeName; //教学活动类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingActivityTypeEN.dicFldComparisonOp.ContainsKey(convTeachingActivityType.TeachingActivityTypeName) == false)
{
objvTeachingActivityTypeEN.dicFldComparisonOp.Add(convTeachingActivityType.TeachingActivityTypeName, strComparisonOp);
}
else
{
objvTeachingActivityTypeEN.dicFldComparisonOp[convTeachingActivityType.TeachingActivityTypeName] = strComparisonOp;
}
}
return objvTeachingActivityTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingActivityTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingActivityTypeEN SetIsSummaryField(this clsvTeachingActivityTypeEN objvTeachingActivityTypeEN, bool bolIsSummaryField, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsSummaryField, convTeachingActivityType.IsSummaryField);
objvTeachingActivityTypeEN.IsSummaryField = bolIsSummaryField; //是否汇总字段
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingActivityTypeEN.dicFldComparisonOp.ContainsKey(convTeachingActivityType.IsSummaryField) == false)
{
objvTeachingActivityTypeEN.dicFldComparisonOp.Add(convTeachingActivityType.IsSummaryField, strComparisonOp);
}
else
{
objvTeachingActivityTypeEN.dicFldComparisonOp[convTeachingActivityType.IsSummaryField] = strComparisonOp;
}
}
return objvTeachingActivityTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingActivityTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingActivityTypeEN SetUseMedia(this clsvTeachingActivityTypeEN objvTeachingActivityTypeEN, string strUseMedia, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUseMedia, convTeachingActivityType.UseMedia);
clsCheckSql.CheckFieldLen(strUseMedia, 30, convTeachingActivityType.UseMedia);
objvTeachingActivityTypeEN.UseMedia = strUseMedia; //使用媒体
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingActivityTypeEN.dicFldComparisonOp.ContainsKey(convTeachingActivityType.UseMedia) == false)
{
objvTeachingActivityTypeEN.dicFldComparisonOp.Add(convTeachingActivityType.UseMedia, strComparisonOp);
}
else
{
objvTeachingActivityTypeEN.dicFldComparisonOp[convTeachingActivityType.UseMedia] = strComparisonOp;
}
}
return objvTeachingActivityTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingActivityTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingActivityTypeEN SetFuncModuleId(this clsvTeachingActivityTypeEN objvTeachingActivityTypeEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convTeachingActivityType.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convTeachingActivityType.FuncModuleId);
objvTeachingActivityTypeEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingActivityTypeEN.dicFldComparisonOp.ContainsKey(convTeachingActivityType.FuncModuleId) == false)
{
objvTeachingActivityTypeEN.dicFldComparisonOp.Add(convTeachingActivityType.FuncModuleId, strComparisonOp);
}
else
{
objvTeachingActivityTypeEN.dicFldComparisonOp[convTeachingActivityType.FuncModuleId] = strComparisonOp;
}
}
return objvTeachingActivityTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingActivityTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingActivityTypeEN SetFuncModuleName(this clsvTeachingActivityTypeEN objvTeachingActivityTypeEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convTeachingActivityType.FuncModuleName);
objvTeachingActivityTypeEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingActivityTypeEN.dicFldComparisonOp.ContainsKey(convTeachingActivityType.FuncModuleName) == false)
{
objvTeachingActivityTypeEN.dicFldComparisonOp.Add(convTeachingActivityType.FuncModuleName, strComparisonOp);
}
else
{
objvTeachingActivityTypeEN.dicFldComparisonOp[convTeachingActivityType.FuncModuleName] = strComparisonOp;
}
}
return objvTeachingActivityTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingActivityTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingActivityTypeEN SetFuncModuleName_Sim(this clsvTeachingActivityTypeEN objvTeachingActivityTypeEN, string strFuncModuleName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName_Sim, 30, convTeachingActivityType.FuncModuleName_Sim);
objvTeachingActivityTypeEN.FuncModuleName_Sim = strFuncModuleName_Sim; //功能模块简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingActivityTypeEN.dicFldComparisonOp.ContainsKey(convTeachingActivityType.FuncModuleName_Sim) == false)
{
objvTeachingActivityTypeEN.dicFldComparisonOp.Add(convTeachingActivityType.FuncModuleName_Sim, strComparisonOp);
}
else
{
objvTeachingActivityTypeEN.dicFldComparisonOp[convTeachingActivityType.FuncModuleName_Sim] = strComparisonOp;
}
}
return objvTeachingActivityTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingActivityTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingActivityTypeEN Setid_MicroteachCase(this clsvTeachingActivityTypeEN objvTeachingActivityTypeEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convTeachingActivityType.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convTeachingActivityType.id_MicroteachCase);
objvTeachingActivityTypeEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingActivityTypeEN.dicFldComparisonOp.ContainsKey(convTeachingActivityType.id_MicroteachCase) == false)
{
objvTeachingActivityTypeEN.dicFldComparisonOp.Add(convTeachingActivityType.id_MicroteachCase, strComparisonOp);
}
else
{
objvTeachingActivityTypeEN.dicFldComparisonOp[convTeachingActivityType.id_MicroteachCase] = strComparisonOp;
}
}
return objvTeachingActivityTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingActivityTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingActivityTypeEN SetCaseName(this clsvTeachingActivityTypeEN objvTeachingActivityTypeEN, string strCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseName, 100, convTeachingActivityType.CaseName);
objvTeachingActivityTypeEN.CaseName = strCaseName; //案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingActivityTypeEN.dicFldComparisonOp.ContainsKey(convTeachingActivityType.CaseName) == false)
{
objvTeachingActivityTypeEN.dicFldComparisonOp.Add(convTeachingActivityType.CaseName, strComparisonOp);
}
else
{
objvTeachingActivityTypeEN.dicFldComparisonOp[convTeachingActivityType.CaseName] = strComparisonOp;
}
}
return objvTeachingActivityTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingActivityTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingActivityTypeEN SetOwnerId(this clsvTeachingActivityTypeEN objvTeachingActivityTypeEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerId, 20, convTeachingActivityType.OwnerId);
objvTeachingActivityTypeEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingActivityTypeEN.dicFldComparisonOp.ContainsKey(convTeachingActivityType.OwnerId) == false)
{
objvTeachingActivityTypeEN.dicFldComparisonOp.Add(convTeachingActivityType.OwnerId, strComparisonOp);
}
else
{
objvTeachingActivityTypeEN.dicFldComparisonOp[convTeachingActivityType.OwnerId] = strComparisonOp;
}
}
return objvTeachingActivityTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingActivityTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingActivityTypeEN SetOrderNum(this clsvTeachingActivityTypeEN objvTeachingActivityTypeEN, int intOrderNum, string strComparisonOp="")
	{
objvTeachingActivityTypeEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingActivityTypeEN.dicFldComparisonOp.ContainsKey(convTeachingActivityType.OrderNum) == false)
{
objvTeachingActivityTypeEN.dicFldComparisonOp.Add(convTeachingActivityType.OrderNum, strComparisonOp);
}
else
{
objvTeachingActivityTypeEN.dicFldComparisonOp[convTeachingActivityType.OrderNum] = strComparisonOp;
}
}
return objvTeachingActivityTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingActivityTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingActivityTypeEN Setid_School(this clsvTeachingActivityTypeEN objvTeachingActivityTypeEN, string strid_School, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_School, 4, convTeachingActivityType.id_School);
clsCheckSql.CheckFieldForeignKey(strid_School, 4, convTeachingActivityType.id_School);
objvTeachingActivityTypeEN.id_School = strid_School; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingActivityTypeEN.dicFldComparisonOp.ContainsKey(convTeachingActivityType.id_School) == false)
{
objvTeachingActivityTypeEN.dicFldComparisonOp.Add(convTeachingActivityType.id_School, strComparisonOp);
}
else
{
objvTeachingActivityTypeEN.dicFldComparisonOp[convTeachingActivityType.id_School] = strComparisonOp;
}
}
return objvTeachingActivityTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingActivityTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingActivityTypeEN SetSchoolId(this clsvTeachingActivityTypeEN objvTeachingActivityTypeEN, string strSchoolId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolId, convTeachingActivityType.SchoolId);
clsCheckSql.CheckFieldLen(strSchoolId, 10, convTeachingActivityType.SchoolId);
objvTeachingActivityTypeEN.SchoolId = strSchoolId; //学校编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingActivityTypeEN.dicFldComparisonOp.ContainsKey(convTeachingActivityType.SchoolId) == false)
{
objvTeachingActivityTypeEN.dicFldComparisonOp.Add(convTeachingActivityType.SchoolId, strComparisonOp);
}
else
{
objvTeachingActivityTypeEN.dicFldComparisonOp[convTeachingActivityType.SchoolId] = strComparisonOp;
}
}
return objvTeachingActivityTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingActivityTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingActivityTypeEN SetSchoolName(this clsvTeachingActivityTypeEN objvTeachingActivityTypeEN, string strSchoolName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSchoolName, convTeachingActivityType.SchoolName);
clsCheckSql.CheckFieldLen(strSchoolName, 50, convTeachingActivityType.SchoolName);
objvTeachingActivityTypeEN.SchoolName = strSchoolName; //学校名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingActivityTypeEN.dicFldComparisonOp.ContainsKey(convTeachingActivityType.SchoolName) == false)
{
objvTeachingActivityTypeEN.dicFldComparisonOp.Add(convTeachingActivityType.SchoolName, strComparisonOp);
}
else
{
objvTeachingActivityTypeEN.dicFldComparisonOp[convTeachingActivityType.SchoolName] = strComparisonOp;
}
}
return objvTeachingActivityTypeEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingActivityTypeEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingActivityTypeEN SetMemo(this clsvTeachingActivityTypeEN objvTeachingActivityTypeEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convTeachingActivityType.Memo);
objvTeachingActivityTypeEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingActivityTypeEN.dicFldComparisonOp.ContainsKey(convTeachingActivityType.Memo) == false)
{
objvTeachingActivityTypeEN.dicFldComparisonOp.Add(convTeachingActivityType.Memo, strComparisonOp);
}
else
{
objvTeachingActivityTypeEN.dicFldComparisonOp[convTeachingActivityType.Memo] = strComparisonOp;
}
}
return objvTeachingActivityTypeEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvTeachingActivityTypeEN objvTeachingActivityType_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvTeachingActivityType_Cond.IsUpdated(convTeachingActivityType.TeachingActivityTypeId) == true)
{
string strComparisonOp_TeachingActivityTypeId = objvTeachingActivityType_Cond.dicFldComparisonOp[convTeachingActivityType.TeachingActivityTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingActivityType.TeachingActivityTypeId, objvTeachingActivityType_Cond.TeachingActivityTypeId, strComparisonOp_TeachingActivityTypeId);
}
if (objvTeachingActivityType_Cond.IsUpdated(convTeachingActivityType.TeachingActivityTypeName) == true)
{
string strComparisonOp_TeachingActivityTypeName = objvTeachingActivityType_Cond.dicFldComparisonOp[convTeachingActivityType.TeachingActivityTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingActivityType.TeachingActivityTypeName, objvTeachingActivityType_Cond.TeachingActivityTypeName, strComparisonOp_TeachingActivityTypeName);
}
if (objvTeachingActivityType_Cond.IsUpdated(convTeachingActivityType.IsSummaryField) == true)
{
if (objvTeachingActivityType_Cond.IsSummaryField == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachingActivityType.IsSummaryField);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachingActivityType.IsSummaryField);
}
}
if (objvTeachingActivityType_Cond.IsUpdated(convTeachingActivityType.UseMedia) == true)
{
string strComparisonOp_UseMedia = objvTeachingActivityType_Cond.dicFldComparisonOp[convTeachingActivityType.UseMedia];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingActivityType.UseMedia, objvTeachingActivityType_Cond.UseMedia, strComparisonOp_UseMedia);
}
if (objvTeachingActivityType_Cond.IsUpdated(convTeachingActivityType.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvTeachingActivityType_Cond.dicFldComparisonOp[convTeachingActivityType.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingActivityType.FuncModuleId, objvTeachingActivityType_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvTeachingActivityType_Cond.IsUpdated(convTeachingActivityType.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvTeachingActivityType_Cond.dicFldComparisonOp[convTeachingActivityType.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingActivityType.FuncModuleName, objvTeachingActivityType_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvTeachingActivityType_Cond.IsUpdated(convTeachingActivityType.FuncModuleName_Sim) == true)
{
string strComparisonOp_FuncModuleName_Sim = objvTeachingActivityType_Cond.dicFldComparisonOp[convTeachingActivityType.FuncModuleName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingActivityType.FuncModuleName_Sim, objvTeachingActivityType_Cond.FuncModuleName_Sim, strComparisonOp_FuncModuleName_Sim);
}
if (objvTeachingActivityType_Cond.IsUpdated(convTeachingActivityType.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvTeachingActivityType_Cond.dicFldComparisonOp[convTeachingActivityType.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingActivityType.id_MicroteachCase, objvTeachingActivityType_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvTeachingActivityType_Cond.IsUpdated(convTeachingActivityType.CaseName) == true)
{
string strComparisonOp_CaseName = objvTeachingActivityType_Cond.dicFldComparisonOp[convTeachingActivityType.CaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingActivityType.CaseName, objvTeachingActivityType_Cond.CaseName, strComparisonOp_CaseName);
}
if (objvTeachingActivityType_Cond.IsUpdated(convTeachingActivityType.OwnerId) == true)
{
string strComparisonOp_OwnerId = objvTeachingActivityType_Cond.dicFldComparisonOp[convTeachingActivityType.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingActivityType.OwnerId, objvTeachingActivityType_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objvTeachingActivityType_Cond.IsUpdated(convTeachingActivityType.OrderNum) == true)
{
string strComparisonOp_OrderNum = objvTeachingActivityType_Cond.dicFldComparisonOp[convTeachingActivityType.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingActivityType.OrderNum, objvTeachingActivityType_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objvTeachingActivityType_Cond.IsUpdated(convTeachingActivityType.id_School) == true)
{
string strComparisonOp_id_School = objvTeachingActivityType_Cond.dicFldComparisonOp[convTeachingActivityType.id_School];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingActivityType.id_School, objvTeachingActivityType_Cond.id_School, strComparisonOp_id_School);
}
if (objvTeachingActivityType_Cond.IsUpdated(convTeachingActivityType.SchoolId) == true)
{
string strComparisonOp_SchoolId = objvTeachingActivityType_Cond.dicFldComparisonOp[convTeachingActivityType.SchoolId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingActivityType.SchoolId, objvTeachingActivityType_Cond.SchoolId, strComparisonOp_SchoolId);
}
if (objvTeachingActivityType_Cond.IsUpdated(convTeachingActivityType.SchoolName) == true)
{
string strComparisonOp_SchoolName = objvTeachingActivityType_Cond.dicFldComparisonOp[convTeachingActivityType.SchoolName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingActivityType.SchoolName, objvTeachingActivityType_Cond.SchoolName, strComparisonOp_SchoolName);
}
if (objvTeachingActivityType_Cond.IsUpdated(convTeachingActivityType.Memo) == true)
{
string strComparisonOp_Memo = objvTeachingActivityType_Cond.dicFldComparisonOp[convTeachingActivityType.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingActivityType.Memo, objvTeachingActivityType_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v教学活动类型(vTeachingActivityType)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvTeachingActivityTypeWApi
{
private static readonly string mstrApiControllerName = "vTeachingActivityTypeApi";

 public clsvTeachingActivityTypeWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_TeachingActivityTypeId(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v教学活动类型]...","0");
List<clsvTeachingActivityTypeEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="TeachingActivityTypeId";
objDDL.DataTextField="TeachingActivityTypeName";
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
public static void BindCbo_TeachingActivityTypeId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convTeachingActivityType.TeachingActivityTypeId); 
List<clsvTeachingActivityTypeEN> arrObjLst = clsvTeachingActivityTypeWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvTeachingActivityTypeEN objvTeachingActivityTypeEN = new clsvTeachingActivityTypeEN()
{
TeachingActivityTypeId = "0",
TeachingActivityTypeName = "选[v教学活动类型]..."
};
arrObjLst.Insert(0, objvTeachingActivityTypeEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convTeachingActivityType.TeachingActivityTypeId;
objComboBox.DisplayMember = convTeachingActivityType.TeachingActivityTypeName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTeachingActivityTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeachingActivityTypeEN GetObjByTeachingActivityTypeId(string strTeachingActivityTypeId)
{
string strAction = "GetObjByTeachingActivityTypeId";
string strErrMsg = string.Empty;
string strResult = "";
clsvTeachingActivityTypeEN objvTeachingActivityTypeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["TeachingActivityTypeId"] = strTeachingActivityTypeId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvTeachingActivityTypeEN = JsonConvert.DeserializeObject<clsvTeachingActivityTypeEN>((string)jobjReturn["ReturnObj"]);
return objvTeachingActivityTypeEN;
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
 /// <param name = "strTeachingActivityTypeId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeachingActivityTypeEN GetObjByTeachingActivityTypeId_WA_Cache(string strTeachingActivityTypeId)
{
string strAction = "GetObjByTeachingActivityTypeId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvTeachingActivityTypeEN objvTeachingActivityTypeEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["TeachingActivityTypeId"] = strTeachingActivityTypeId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvTeachingActivityTypeEN = JsonConvert.DeserializeObject<clsvTeachingActivityTypeEN>((string)jobjReturn["ReturnObj"]);
return objvTeachingActivityTypeEN;
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
public static clsvTeachingActivityTypeEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvTeachingActivityTypeEN objvTeachingActivityTypeEN = null;
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
objvTeachingActivityTypeEN = JsonConvert.DeserializeObject<clsvTeachingActivityTypeEN>((string)jobjReturn["ReturnObj"]);
return objvTeachingActivityTypeEN;
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
 /// <param name = "strTeachingActivityTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTeachingActivityTypeEN GetObjByTeachingActivityTypeId_Cache(string strTeachingActivityTypeId)
{
if (string.IsNullOrEmpty(strTeachingActivityTypeId) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvTeachingActivityTypeEN._CurrTabName_S);
List<clsvTeachingActivityTypeEN> arrvTeachingActivityTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvTeachingActivityTypeEN> arrvTeachingActivityTypeObjLst_Sel =
from objvTeachingActivityTypeEN in arrvTeachingActivityTypeObjLst_Cache
where objvTeachingActivityTypeEN.TeachingActivityTypeId == strTeachingActivityTypeId
select objvTeachingActivityTypeEN;
if (arrvTeachingActivityTypeObjLst_Sel.Count() == 0)
{
   clsvTeachingActivityTypeEN obj = clsvTeachingActivityTypeWApi.GetObjByTeachingActivityTypeId(strTeachingActivityTypeId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvTeachingActivityTypeObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strTeachingActivityTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetTeachingActivityTypeNameByTeachingActivityTypeId_Cache(string strTeachingActivityTypeId)
{
if (string.IsNullOrEmpty(strTeachingActivityTypeId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvTeachingActivityTypeEN._CurrTabName_S);
List<clsvTeachingActivityTypeEN> arrvTeachingActivityTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvTeachingActivityTypeEN> arrvTeachingActivityTypeObjLst_Sel1 =
from objvTeachingActivityTypeEN in arrvTeachingActivityTypeObjLst_Cache
where objvTeachingActivityTypeEN.TeachingActivityTypeId == strTeachingActivityTypeId
select objvTeachingActivityTypeEN;
List <clsvTeachingActivityTypeEN> arrvTeachingActivityTypeObjLst_Sel = new List<clsvTeachingActivityTypeEN>();
foreach (clsvTeachingActivityTypeEN obj in arrvTeachingActivityTypeObjLst_Sel1)
{
arrvTeachingActivityTypeObjLst_Sel.Add(obj);
}
if (arrvTeachingActivityTypeObjLst_Sel.Count > 0)
{
return arrvTeachingActivityTypeObjLst_Sel[0].TeachingActivityTypeName;
}
string strErrMsgForGetObjById = string.Format("在vTeachingActivityType对象缓存列表中,找不到记录[TeachingActivityTypeId = {0}](函数:{1})", strTeachingActivityTypeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvTeachingActivityTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strTeachingActivityTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByTeachingActivityTypeId_Cache(string strTeachingActivityTypeId)
{
if (string.IsNullOrEmpty(strTeachingActivityTypeId) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}", clsvTeachingActivityTypeEN._CurrTabName_S);
List<clsvTeachingActivityTypeEN> arrvTeachingActivityTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvTeachingActivityTypeEN> arrvTeachingActivityTypeObjLst_Sel1 =
from objvTeachingActivityTypeEN in arrvTeachingActivityTypeObjLst_Cache
where objvTeachingActivityTypeEN.TeachingActivityTypeId == strTeachingActivityTypeId
select objvTeachingActivityTypeEN;
List <clsvTeachingActivityTypeEN> arrvTeachingActivityTypeObjLst_Sel = new List<clsvTeachingActivityTypeEN>();
foreach (clsvTeachingActivityTypeEN obj in arrvTeachingActivityTypeObjLst_Sel1)
{
arrvTeachingActivityTypeObjLst_Sel.Add(obj);
}
if (arrvTeachingActivityTypeObjLst_Sel.Count > 0)
{
return arrvTeachingActivityTypeObjLst_Sel[0].TeachingActivityTypeName;
}
string strErrMsgForGetObjById = string.Format("在vTeachingActivityType对象缓存列表中,找不到记录的相关名称[TeachingActivityTypeId = {0}](函数:{1})", strTeachingActivityTypeId, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvTeachingActivityTypeBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachingActivityTypeEN> GetObjLst(string strWhereCond)
{
 List<clsvTeachingActivityTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingActivityTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachingActivityTypeEN> GetObjLstByTeachingActivityTypeIdLst(List<string> arrTeachingActivityTypeId)
{
 List<clsvTeachingActivityTypeEN> arrObjLst = null; 
string strAction = "GetObjLstByTeachingActivityTypeIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrTeachingActivityTypeId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingActivityTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strTeachingActivityTypeId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvTeachingActivityTypeEN> GetObjLstByTeachingActivityTypeIdLst_Cache(List<string> arrTeachingActivityTypeId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvTeachingActivityTypeEN._CurrTabName_S);
List<clsvTeachingActivityTypeEN> arrvTeachingActivityTypeObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvTeachingActivityTypeEN> arrvTeachingActivityTypeObjLst_Sel =
from objvTeachingActivityTypeEN in arrvTeachingActivityTypeObjLst_Cache
where arrTeachingActivityTypeId.Contains(objvTeachingActivityTypeEN.TeachingActivityTypeId)
select objvTeachingActivityTypeEN;
return arrvTeachingActivityTypeObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachingActivityTypeEN> GetObjLstByTeachingActivityTypeIdLst_WA_Cache(List<string> arrTeachingActivityTypeId)
{
 List<clsvTeachingActivityTypeEN> arrObjLst = null; 
string strAction = "GetObjLstByTeachingActivityTypeIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrTeachingActivityTypeId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingActivityTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachingActivityTypeEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvTeachingActivityTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingActivityTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachingActivityTypeEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvTeachingActivityTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingActivityTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachingActivityTypeEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvTeachingActivityTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingActivityTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachingActivityTypeEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvTeachingActivityTypeEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingActivityTypeEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strTeachingActivityTypeId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["TeachingActivityTypeId"] = strTeachingActivityTypeId
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
 /// <param name = "objvTeachingActivityTypeENS">源对象</param>
 /// <param name = "objvTeachingActivityTypeENT">目标对象</param>
 public static void CopyTo(clsvTeachingActivityTypeEN objvTeachingActivityTypeENS, clsvTeachingActivityTypeEN objvTeachingActivityTypeENT)
{
try
{
objvTeachingActivityTypeENT.TeachingActivityTypeId = objvTeachingActivityTypeENS.TeachingActivityTypeId; //教学活动类型Id
objvTeachingActivityTypeENT.TeachingActivityTypeName = objvTeachingActivityTypeENS.TeachingActivityTypeName; //教学活动类型名称
objvTeachingActivityTypeENT.IsSummaryField = objvTeachingActivityTypeENS.IsSummaryField; //是否汇总字段
objvTeachingActivityTypeENT.UseMedia = objvTeachingActivityTypeENS.UseMedia; //使用媒体
objvTeachingActivityTypeENT.FuncModuleId = objvTeachingActivityTypeENS.FuncModuleId; //功能模块Id
objvTeachingActivityTypeENT.FuncModuleName = objvTeachingActivityTypeENS.FuncModuleName; //功能模块名称
objvTeachingActivityTypeENT.FuncModuleName_Sim = objvTeachingActivityTypeENS.FuncModuleName_Sim; //功能模块简称
objvTeachingActivityTypeENT.id_MicroteachCase = objvTeachingActivityTypeENS.id_MicroteachCase; //微格教学案例流水号
objvTeachingActivityTypeENT.CaseName = objvTeachingActivityTypeENS.CaseName; //案例名称
objvTeachingActivityTypeENT.OwnerId = objvTeachingActivityTypeENS.OwnerId; //拥有者Id
objvTeachingActivityTypeENT.OrderNum = objvTeachingActivityTypeENS.OrderNum; //序号
objvTeachingActivityTypeENT.id_School = objvTeachingActivityTypeENS.id_School; //学校流水号
objvTeachingActivityTypeENT.SchoolId = objvTeachingActivityTypeENS.SchoolId; //学校编号
objvTeachingActivityTypeENT.SchoolName = objvTeachingActivityTypeENS.SchoolName; //学校名称
objvTeachingActivityTypeENT.Memo = objvTeachingActivityTypeENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvTeachingActivityTypeEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvTeachingActivityTypeEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvTeachingActivityTypeEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvTeachingActivityTypeEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvTeachingActivityTypeEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvTeachingActivityTypeEN.AttributeName)
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
if (clsTeachingActivityTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachingActivityTypeWApi没有刷新缓存机制(clsTeachingActivityTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by TeachingActivityTypeId");
//if (arrvTeachingActivityTypeObjLst_Cache == null)
//{
//arrvTeachingActivityTypeObjLst_Cache = await clsvTeachingActivityTypeWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvTeachingActivityTypeEN._CurrTabName_S);
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
public static List<clsvTeachingActivityTypeEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvTeachingActivityTypeEN._CurrTabName_S);
List<clsvTeachingActivityTypeEN> arrvTeachingActivityTypeObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvTeachingActivityTypeObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvTeachingActivityTypeEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convTeachingActivityType.TeachingActivityTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingActivityType.TeachingActivityTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingActivityType.IsSummaryField, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTeachingActivityType.UseMedia, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingActivityType.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingActivityType.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingActivityType.FuncModuleName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingActivityType.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingActivityType.CaseName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingActivityType.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingActivityType.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convTeachingActivityType.id_School, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingActivityType.SchoolId, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingActivityType.SchoolName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingActivityType.Memo, Type.GetType("System.String"));
foreach (clsvTeachingActivityTypeEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convTeachingActivityType.TeachingActivityTypeId] = objInFor[convTeachingActivityType.TeachingActivityTypeId];
objDR[convTeachingActivityType.TeachingActivityTypeName] = objInFor[convTeachingActivityType.TeachingActivityTypeName];
objDR[convTeachingActivityType.IsSummaryField] = objInFor[convTeachingActivityType.IsSummaryField];
objDR[convTeachingActivityType.UseMedia] = objInFor[convTeachingActivityType.UseMedia];
objDR[convTeachingActivityType.FuncModuleId] = objInFor[convTeachingActivityType.FuncModuleId];
objDR[convTeachingActivityType.FuncModuleName] = objInFor[convTeachingActivityType.FuncModuleName];
objDR[convTeachingActivityType.FuncModuleName_Sim] = objInFor[convTeachingActivityType.FuncModuleName_Sim];
objDR[convTeachingActivityType.id_MicroteachCase] = objInFor[convTeachingActivityType.id_MicroteachCase];
objDR[convTeachingActivityType.CaseName] = objInFor[convTeachingActivityType.CaseName];
objDR[convTeachingActivityType.OwnerId] = objInFor[convTeachingActivityType.OwnerId];
objDR[convTeachingActivityType.OrderNum] = objInFor[convTeachingActivityType.OrderNum];
objDR[convTeachingActivityType.id_School] = objInFor[convTeachingActivityType.id_School];
objDR[convTeachingActivityType.SchoolId] = objInFor[convTeachingActivityType.SchoolId];
objDR[convTeachingActivityType.SchoolName] = objInFor[convTeachingActivityType.SchoolName];
objDR[convTeachingActivityType.Memo] = objInFor[convTeachingActivityType.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}