
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTeachingPlanWApi
 表名:vTeachingPlan(01120388)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:42:24
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:技能示范
 模块英文名:SkillDemo
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
public static class clsvTeachingPlanWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingPlanEN Setid_TeachingPlan(this clsvTeachingPlanEN objvTeachingPlanEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, convTeachingPlan.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, convTeachingPlan.id_TeachingPlan);
objvTeachingPlanEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingPlanEN.dicFldComparisonOp.ContainsKey(convTeachingPlan.id_TeachingPlan) == false)
{
objvTeachingPlanEN.dicFldComparisonOp.Add(convTeachingPlan.id_TeachingPlan, strComparisonOp);
}
else
{
objvTeachingPlanEN.dicFldComparisonOp[convTeachingPlan.id_TeachingPlan] = strComparisonOp;
}
}
return objvTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingPlanEN SetSubjectName(this clsvTeachingPlanEN objvTeachingPlanEN, string strSubjectName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strSubjectName, convTeachingPlan.SubjectName);
clsCheckSql.CheckFieldLen(strSubjectName, 200, convTeachingPlan.SubjectName);
objvTeachingPlanEN.SubjectName = strSubjectName; //课题名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingPlanEN.dicFldComparisonOp.ContainsKey(convTeachingPlan.SubjectName) == false)
{
objvTeachingPlanEN.dicFldComparisonOp.Add(convTeachingPlan.SubjectName, strComparisonOp);
}
else
{
objvTeachingPlanEN.dicFldComparisonOp[convTeachingPlan.SubjectName] = strComparisonOp;
}
}
return objvTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingPlanEN SetTeachingPlanAuthor(this clsvTeachingPlanEN objvTeachingPlanEN, string strTeachingPlanAuthor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingPlanAuthor, 50, convTeachingPlan.TeachingPlanAuthor);
objvTeachingPlanEN.TeachingPlanAuthor = strTeachingPlanAuthor; //教案撰写人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingPlanEN.dicFldComparisonOp.ContainsKey(convTeachingPlan.TeachingPlanAuthor) == false)
{
objvTeachingPlanEN.dicFldComparisonOp.Add(convTeachingPlan.TeachingPlanAuthor, strComparisonOp);
}
else
{
objvTeachingPlanEN.dicFldComparisonOp[convTeachingPlan.TeachingPlanAuthor] = strComparisonOp;
}
}
return objvTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingPlanEN SetTeachingObject(this clsvTeachingPlanEN objvTeachingPlanEN, string strTeachingObject, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingObject, 5000, convTeachingPlan.TeachingObject);
objvTeachingPlanEN.TeachingObject = strTeachingObject; //教学目标
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingPlanEN.dicFldComparisonOp.ContainsKey(convTeachingPlan.TeachingObject) == false)
{
objvTeachingPlanEN.dicFldComparisonOp.Add(convTeachingPlan.TeachingObject, strComparisonOp);
}
else
{
objvTeachingPlanEN.dicFldComparisonOp[convTeachingPlan.TeachingObject] = strComparisonOp;
}
}
return objvTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingPlanEN SetTeachingEmphases(this clsvTeachingPlanEN objvTeachingPlanEN, string strTeachingEmphases, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingEmphases, 5000, convTeachingPlan.TeachingEmphases);
objvTeachingPlanEN.TeachingEmphases = strTeachingEmphases; //教学重点
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingPlanEN.dicFldComparisonOp.ContainsKey(convTeachingPlan.TeachingEmphases) == false)
{
objvTeachingPlanEN.dicFldComparisonOp.Add(convTeachingPlan.TeachingEmphases, strComparisonOp);
}
else
{
objvTeachingPlanEN.dicFldComparisonOp[convTeachingPlan.TeachingEmphases] = strComparisonOp;
}
}
return objvTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingPlanEN SetTeachingDifficulty(this clsvTeachingPlanEN objvTeachingPlanEN, string strTeachingDifficulty, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingDifficulty, 5000, convTeachingPlan.TeachingDifficulty);
objvTeachingPlanEN.TeachingDifficulty = strTeachingDifficulty; //教学难点
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingPlanEN.dicFldComparisonOp.ContainsKey(convTeachingPlan.TeachingDifficulty) == false)
{
objvTeachingPlanEN.dicFldComparisonOp.Add(convTeachingPlan.TeachingDifficulty, strComparisonOp);
}
else
{
objvTeachingPlanEN.dicFldComparisonOp[convTeachingPlan.TeachingDifficulty] = strComparisonOp;
}
}
return objvTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingPlanEN SetTeachingTool(this clsvTeachingPlanEN objvTeachingPlanEN, string strTeachingTool, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingTool, 5000, convTeachingPlan.TeachingTool);
objvTeachingPlanEN.TeachingTool = strTeachingTool; //教学用具
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingPlanEN.dicFldComparisonOp.ContainsKey(convTeachingPlan.TeachingTool) == false)
{
objvTeachingPlanEN.dicFldComparisonOp.Add(convTeachingPlan.TeachingTool, strComparisonOp);
}
else
{
objvTeachingPlanEN.dicFldComparisonOp[convTeachingPlan.TeachingTool] = strComparisonOp;
}
}
return objvTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingPlanEN SetTeachingProcess(this clsvTeachingPlanEN objvTeachingPlanEN, string strTeachingProcess, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingProcess, 8000, convTeachingPlan.TeachingProcess);
objvTeachingPlanEN.TeachingProcess = strTeachingProcess; //教学过程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingPlanEN.dicFldComparisonOp.ContainsKey(convTeachingPlan.TeachingProcess) == false)
{
objvTeachingPlanEN.dicFldComparisonOp.Add(convTeachingPlan.TeachingProcess, strComparisonOp);
}
else
{
objvTeachingPlanEN.dicFldComparisonOp[convTeachingPlan.TeachingProcess] = strComparisonOp;
}
}
return objvTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingPlanEN SetTeachingPlanType(this clsvTeachingPlanEN objvTeachingPlanEN, string strTeachingPlanType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingPlanType, 1, convTeachingPlan.TeachingPlanType);
clsCheckSql.CheckFieldForeignKey(strTeachingPlanType, 1, convTeachingPlan.TeachingPlanType);
objvTeachingPlanEN.TeachingPlanType = strTeachingPlanType; //教案类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingPlanEN.dicFldComparisonOp.ContainsKey(convTeachingPlan.TeachingPlanType) == false)
{
objvTeachingPlanEN.dicFldComparisonOp.Add(convTeachingPlan.TeachingPlanType, strComparisonOp);
}
else
{
objvTeachingPlanEN.dicFldComparisonOp[convTeachingPlan.TeachingPlanType] = strComparisonOp;
}
}
return objvTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingPlanEN SetTeachPlanTypeName(this clsvTeachingPlanEN objvTeachingPlanEN, string strTeachPlanTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachPlanTypeName, 50, convTeachingPlan.TeachPlanTypeName);
objvTeachingPlanEN.TeachPlanTypeName = strTeachPlanTypeName; //教案类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingPlanEN.dicFldComparisonOp.ContainsKey(convTeachingPlan.TeachPlanTypeName) == false)
{
objvTeachingPlanEN.dicFldComparisonOp.Add(convTeachingPlan.TeachPlanTypeName, strComparisonOp);
}
else
{
objvTeachingPlanEN.dicFldComparisonOp[convTeachingPlan.TeachPlanTypeName] = strComparisonOp;
}
}
return objvTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingPlanEN SetSimplePlanContent(this clsvTeachingPlanEN objvTeachingPlanEN, string strSimplePlanContent, string strComparisonOp="")
	{
objvTeachingPlanEN.SimplePlanContent = strSimplePlanContent; //简案内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingPlanEN.dicFldComparisonOp.ContainsKey(convTeachingPlan.SimplePlanContent) == false)
{
objvTeachingPlanEN.dicFldComparisonOp.Add(convTeachingPlan.SimplePlanContent, strComparisonOp);
}
else
{
objvTeachingPlanEN.dicFldComparisonOp[convTeachingPlan.SimplePlanContent] = strComparisonOp;
}
}
return objvTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingPlanEN SetTeachingPlanInDate(this clsvTeachingPlanEN objvTeachingPlanEN, string strTeachingPlanInDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingPlanInDate, 8, convTeachingPlan.TeachingPlanInDate);
clsCheckSql.CheckFieldForeignKey(strTeachingPlanInDate, 8, convTeachingPlan.TeachingPlanInDate);
objvTeachingPlanEN.TeachingPlanInDate = strTeachingPlanInDate; //教案入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingPlanEN.dicFldComparisonOp.ContainsKey(convTeachingPlan.TeachingPlanInDate) == false)
{
objvTeachingPlanEN.dicFldComparisonOp.Add(convTeachingPlan.TeachingPlanInDate, strComparisonOp);
}
else
{
objvTeachingPlanEN.dicFldComparisonOp[convTeachingPlan.TeachingPlanInDate] = strComparisonOp;
}
}
return objvTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingPlanEN SetTeachingPlanInTime(this clsvTeachingPlanEN objvTeachingPlanEN, string strTeachingPlanInTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingPlanInTime, 6, convTeachingPlan.TeachingPlanInTime);
clsCheckSql.CheckFieldForeignKey(strTeachingPlanInTime, 6, convTeachingPlan.TeachingPlanInTime);
objvTeachingPlanEN.TeachingPlanInTime = strTeachingPlanInTime; //教案入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingPlanEN.dicFldComparisonOp.ContainsKey(convTeachingPlan.TeachingPlanInTime) == false)
{
objvTeachingPlanEN.dicFldComparisonOp.Add(convTeachingPlan.TeachingPlanInTime, strComparisonOp);
}
else
{
objvTeachingPlanEN.dicFldComparisonOp[convTeachingPlan.TeachingPlanInTime] = strComparisonOp;
}
}
return objvTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingPlanEN SetMemo(this clsvTeachingPlanEN objvTeachingPlanEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convTeachingPlan.Memo);
objvTeachingPlanEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingPlanEN.dicFldComparisonOp.ContainsKey(convTeachingPlan.Memo) == false)
{
objvTeachingPlanEN.dicFldComparisonOp.Add(convTeachingPlan.Memo, strComparisonOp);
}
else
{
objvTeachingPlanEN.dicFldComparisonOp[convTeachingPlan.Memo] = strComparisonOp;
}
}
return objvTeachingPlanEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvTeachingPlanEN objvTeachingPlan_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvTeachingPlan_Cond.IsUpdated(convTeachingPlan.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objvTeachingPlan_Cond.dicFldComparisonOp[convTeachingPlan.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingPlan.id_TeachingPlan, objvTeachingPlan_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objvTeachingPlan_Cond.IsUpdated(convTeachingPlan.SubjectName) == true)
{
string strComparisonOp_SubjectName = objvTeachingPlan_Cond.dicFldComparisonOp[convTeachingPlan.SubjectName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingPlan.SubjectName, objvTeachingPlan_Cond.SubjectName, strComparisonOp_SubjectName);
}
if (objvTeachingPlan_Cond.IsUpdated(convTeachingPlan.TeachingPlanAuthor) == true)
{
string strComparisonOp_TeachingPlanAuthor = objvTeachingPlan_Cond.dicFldComparisonOp[convTeachingPlan.TeachingPlanAuthor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingPlan.TeachingPlanAuthor, objvTeachingPlan_Cond.TeachingPlanAuthor, strComparisonOp_TeachingPlanAuthor);
}
if (objvTeachingPlan_Cond.IsUpdated(convTeachingPlan.TeachingObject) == true)
{
string strComparisonOp_TeachingObject = objvTeachingPlan_Cond.dicFldComparisonOp[convTeachingPlan.TeachingObject];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingPlan.TeachingObject, objvTeachingPlan_Cond.TeachingObject, strComparisonOp_TeachingObject);
}
if (objvTeachingPlan_Cond.IsUpdated(convTeachingPlan.TeachingEmphases) == true)
{
string strComparisonOp_TeachingEmphases = objvTeachingPlan_Cond.dicFldComparisonOp[convTeachingPlan.TeachingEmphases];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingPlan.TeachingEmphases, objvTeachingPlan_Cond.TeachingEmphases, strComparisonOp_TeachingEmphases);
}
if (objvTeachingPlan_Cond.IsUpdated(convTeachingPlan.TeachingDifficulty) == true)
{
string strComparisonOp_TeachingDifficulty = objvTeachingPlan_Cond.dicFldComparisonOp[convTeachingPlan.TeachingDifficulty];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingPlan.TeachingDifficulty, objvTeachingPlan_Cond.TeachingDifficulty, strComparisonOp_TeachingDifficulty);
}
if (objvTeachingPlan_Cond.IsUpdated(convTeachingPlan.TeachingTool) == true)
{
string strComparisonOp_TeachingTool = objvTeachingPlan_Cond.dicFldComparisonOp[convTeachingPlan.TeachingTool];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingPlan.TeachingTool, objvTeachingPlan_Cond.TeachingTool, strComparisonOp_TeachingTool);
}
if (objvTeachingPlan_Cond.IsUpdated(convTeachingPlan.TeachingProcess) == true)
{
string strComparisonOp_TeachingProcess = objvTeachingPlan_Cond.dicFldComparisonOp[convTeachingPlan.TeachingProcess];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingPlan.TeachingProcess, objvTeachingPlan_Cond.TeachingProcess, strComparisonOp_TeachingProcess);
}
if (objvTeachingPlan_Cond.IsUpdated(convTeachingPlan.TeachingPlanType) == true)
{
string strComparisonOp_TeachingPlanType = objvTeachingPlan_Cond.dicFldComparisonOp[convTeachingPlan.TeachingPlanType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingPlan.TeachingPlanType, objvTeachingPlan_Cond.TeachingPlanType, strComparisonOp_TeachingPlanType);
}
if (objvTeachingPlan_Cond.IsUpdated(convTeachingPlan.TeachPlanTypeName) == true)
{
string strComparisonOp_TeachPlanTypeName = objvTeachingPlan_Cond.dicFldComparisonOp[convTeachingPlan.TeachPlanTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingPlan.TeachPlanTypeName, objvTeachingPlan_Cond.TeachPlanTypeName, strComparisonOp_TeachPlanTypeName);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvTeachingPlan_Cond.IsUpdated(convTeachingPlan.TeachingPlanInDate) == true)
{
string strComparisonOp_TeachingPlanInDate = objvTeachingPlan_Cond.dicFldComparisonOp[convTeachingPlan.TeachingPlanInDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingPlan.TeachingPlanInDate, objvTeachingPlan_Cond.TeachingPlanInDate, strComparisonOp_TeachingPlanInDate);
}
if (objvTeachingPlan_Cond.IsUpdated(convTeachingPlan.TeachingPlanInTime) == true)
{
string strComparisonOp_TeachingPlanInTime = objvTeachingPlan_Cond.dicFldComparisonOp[convTeachingPlan.TeachingPlanInTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingPlan.TeachingPlanInTime, objvTeachingPlan_Cond.TeachingPlanInTime, strComparisonOp_TeachingPlanInTime);
}
if (objvTeachingPlan_Cond.IsUpdated(convTeachingPlan.Memo) == true)
{
string strComparisonOp_Memo = objvTeachingPlan_Cond.dicFldComparisonOp[convTeachingPlan.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingPlan.Memo, objvTeachingPlan_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v教案(vTeachingPlan)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvTeachingPlanWApi
{
private static readonly string mstrApiControllerName = "vTeachingPlanApi";

 public clsvTeachingPlanWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_TeachingPlan">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeachingPlanEN GetObjByid_TeachingPlan(string strid_TeachingPlan)
{
string strAction = "GetObjByid_TeachingPlan";
string strErrMsg = string.Empty;
string strResult = "";
clsvTeachingPlanEN objvTeachingPlanEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_TeachingPlan"] = strid_TeachingPlan
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvTeachingPlanEN = JsonConvert.DeserializeObject<clsvTeachingPlanEN>((string)jobjReturn["ReturnObj"]);
return objvTeachingPlanEN;
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
 /// <param name = "strid_TeachingPlan">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeachingPlanEN GetObjByid_TeachingPlan_WA_Cache(string strid_TeachingPlan)
{
string strAction = "GetObjByid_TeachingPlan_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvTeachingPlanEN objvTeachingPlanEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_TeachingPlan"] = strid_TeachingPlan
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvTeachingPlanEN = JsonConvert.DeserializeObject<clsvTeachingPlanEN>((string)jobjReturn["ReturnObj"]);
return objvTeachingPlanEN;
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
public static clsvTeachingPlanEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvTeachingPlanEN objvTeachingPlanEN = null;
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
objvTeachingPlanEN = JsonConvert.DeserializeObject<clsvTeachingPlanEN>((string)jobjReturn["ReturnObj"]);
return objvTeachingPlanEN;
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
 /// <param name = "strid_TeachingPlan">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTeachingPlanEN GetObjByid_TeachingPlan_Cache(string strid_TeachingPlan)
{
if (string.IsNullOrEmpty(strid_TeachingPlan) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsvTeachingPlanEN._CurrTabName_S);
List<clsvTeachingPlanEN> arrvTeachingPlanObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvTeachingPlanEN> arrvTeachingPlanObjLst_Sel =
from objvTeachingPlanEN in arrvTeachingPlanObjLst_Cache
where objvTeachingPlanEN.id_TeachingPlan == strid_TeachingPlan
select objvTeachingPlanEN;
if (arrvTeachingPlanObjLst_Sel.Count() == 0)
{
   clsvTeachingPlanEN obj = clsvTeachingPlanWApi.GetObjByid_TeachingPlan(strid_TeachingPlan);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvTeachingPlanObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachingPlanEN> GetObjLst(string strWhereCond)
{
 List<clsvTeachingPlanEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingPlanEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachingPlanEN> GetObjLstById_TeachingPlanLst(List<string> arrId_TeachingPlan)
{
 List<clsvTeachingPlanEN> arrObjLst = null; 
string strAction = "GetObjLstById_TeachingPlanLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_TeachingPlan);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingPlanEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_TeachingPlan">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvTeachingPlanEN> GetObjLstById_TeachingPlanLst_Cache(List<string> arrId_TeachingPlan)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvTeachingPlanEN._CurrTabName_S);
List<clsvTeachingPlanEN> arrvTeachingPlanObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvTeachingPlanEN> arrvTeachingPlanObjLst_Sel =
from objvTeachingPlanEN in arrvTeachingPlanObjLst_Cache
where arrId_TeachingPlan.Contains(objvTeachingPlanEN.id_TeachingPlan)
select objvTeachingPlanEN;
return arrvTeachingPlanObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachingPlanEN> GetObjLstById_TeachingPlanLst_WA_Cache(List<string> arrId_TeachingPlan)
{
 List<clsvTeachingPlanEN> arrObjLst = null; 
string strAction = "GetObjLstById_TeachingPlanLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_TeachingPlan);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingPlanEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachingPlanEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvTeachingPlanEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingPlanEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachingPlanEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvTeachingPlanEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingPlanEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachingPlanEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvTeachingPlanEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingPlanEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachingPlanEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvTeachingPlanEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingPlanEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strid_TeachingPlan)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_TeachingPlan"] = strid_TeachingPlan
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
 /// <param name = "objvTeachingPlanENS">源对象</param>
 /// <param name = "objvTeachingPlanENT">目标对象</param>
 public static void CopyTo(clsvTeachingPlanEN objvTeachingPlanENS, clsvTeachingPlanEN objvTeachingPlanENT)
{
try
{
objvTeachingPlanENT.id_TeachingPlan = objvTeachingPlanENS.id_TeachingPlan; //教案流水号
objvTeachingPlanENT.SubjectName = objvTeachingPlanENS.SubjectName; //课题名称
objvTeachingPlanENT.TeachingPlanAuthor = objvTeachingPlanENS.TeachingPlanAuthor; //教案撰写人
objvTeachingPlanENT.TeachingObject = objvTeachingPlanENS.TeachingObject; //教学目标
objvTeachingPlanENT.TeachingEmphases = objvTeachingPlanENS.TeachingEmphases; //教学重点
objvTeachingPlanENT.TeachingDifficulty = objvTeachingPlanENS.TeachingDifficulty; //教学难点
objvTeachingPlanENT.TeachingTool = objvTeachingPlanENS.TeachingTool; //教学用具
objvTeachingPlanENT.TeachingProcess = objvTeachingPlanENS.TeachingProcess; //教学过程
objvTeachingPlanENT.TeachingPlanType = objvTeachingPlanENS.TeachingPlanType; //教案类型
objvTeachingPlanENT.TeachPlanTypeName = objvTeachingPlanENS.TeachPlanTypeName; //教案类型名称
objvTeachingPlanENT.SimplePlanContent = objvTeachingPlanENS.SimplePlanContent; //简案内容
objvTeachingPlanENT.TeachingPlanInDate = objvTeachingPlanENS.TeachingPlanInDate; //教案入库日期
objvTeachingPlanENT.TeachingPlanInTime = objvTeachingPlanENS.TeachingPlanInTime; //教案入库时间
objvTeachingPlanENT.Memo = objvTeachingPlanENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvTeachingPlanEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvTeachingPlanEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvTeachingPlanEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvTeachingPlanEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvTeachingPlanEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvTeachingPlanEN.AttributeName)
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
if (clsTeachingPlanWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachingPlanWApi没有刷新缓存机制(clsTeachingPlanWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachPlanTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachPlanTypeWApi没有刷新缓存机制(clsTeachPlanTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_TeachingPlan");
//if (arrvTeachingPlanObjLst_Cache == null)
//{
//arrvTeachingPlanObjLst_Cache = await clsvTeachingPlanWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvTeachingPlanEN._CurrTabName_S);
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
public static List<clsvTeachingPlanEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvTeachingPlanEN._CurrTabName_S);
List<clsvTeachingPlanEN> arrvTeachingPlanObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvTeachingPlanObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvTeachingPlanEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convTeachingPlan.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingPlan.SubjectName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingPlan.TeachingPlanAuthor, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingPlan.TeachingObject, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingPlan.TeachingEmphases, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingPlan.TeachingDifficulty, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingPlan.TeachingTool, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingPlan.TeachingProcess, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingPlan.TeachingPlanType, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingPlan.TeachPlanTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingPlan.SimplePlanContent, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingPlan.TeachingPlanInDate, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingPlan.TeachingPlanInTime, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingPlan.Memo, Type.GetType("System.String"));
foreach (clsvTeachingPlanEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convTeachingPlan.id_TeachingPlan] = objInFor[convTeachingPlan.id_TeachingPlan];
objDR[convTeachingPlan.SubjectName] = objInFor[convTeachingPlan.SubjectName];
objDR[convTeachingPlan.TeachingPlanAuthor] = objInFor[convTeachingPlan.TeachingPlanAuthor];
objDR[convTeachingPlan.TeachingObject] = objInFor[convTeachingPlan.TeachingObject];
objDR[convTeachingPlan.TeachingEmphases] = objInFor[convTeachingPlan.TeachingEmphases];
objDR[convTeachingPlan.TeachingDifficulty] = objInFor[convTeachingPlan.TeachingDifficulty];
objDR[convTeachingPlan.TeachingTool] = objInFor[convTeachingPlan.TeachingTool];
objDR[convTeachingPlan.TeachingProcess] = objInFor[convTeachingPlan.TeachingProcess];
objDR[convTeachingPlan.TeachingPlanType] = objInFor[convTeachingPlan.TeachingPlanType];
objDR[convTeachingPlan.TeachPlanTypeName] = objInFor[convTeachingPlan.TeachPlanTypeName];
objDR[convTeachingPlan.SimplePlanContent] = objInFor[convTeachingPlan.SimplePlanContent];
objDR[convTeachingPlan.TeachingPlanInDate] = objInFor[convTeachingPlan.TeachingPlanInDate];
objDR[convTeachingPlan.TeachingPlanInTime] = objInFor[convTeachingPlan.TeachingPlanInTime];
objDR[convTeachingPlan.Memo] = objInFor[convTeachingPlan.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}