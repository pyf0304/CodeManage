
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTeachingPlanWApi
 表名:TeachingPlan(01120387)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:51:42
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
public static class clsTeachingPlanWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingPlanEN Setid_TeachingPlan(this clsTeachingPlanEN objTeachingPlanEN, string strid_TeachingPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_TeachingPlan, 8, conTeachingPlan.id_TeachingPlan);
clsCheckSql.CheckFieldForeignKey(strid_TeachingPlan, 8, conTeachingPlan.id_TeachingPlan);
objTeachingPlanEN.id_TeachingPlan = strid_TeachingPlan; //教案流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingPlanEN.dicFldComparisonOp.ContainsKey(conTeachingPlan.id_TeachingPlan) == false)
{
objTeachingPlanEN.dicFldComparisonOp.Add(conTeachingPlan.id_TeachingPlan, strComparisonOp);
}
else
{
objTeachingPlanEN.dicFldComparisonOp[conTeachingPlan.id_TeachingPlan] = strComparisonOp;
}
}
return objTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingPlanEN SetSubjectName(this clsTeachingPlanEN objTeachingPlanEN, string strSubjectName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSubjectName, 200, conTeachingPlan.SubjectName);
objTeachingPlanEN.SubjectName = strSubjectName; //课题名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingPlanEN.dicFldComparisonOp.ContainsKey(conTeachingPlan.SubjectName) == false)
{
objTeachingPlanEN.dicFldComparisonOp.Add(conTeachingPlan.SubjectName, strComparisonOp);
}
else
{
objTeachingPlanEN.dicFldComparisonOp[conTeachingPlan.SubjectName] = strComparisonOp;
}
}
return objTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingPlanEN SetTeachingPlanAuthor(this clsTeachingPlanEN objTeachingPlanEN, string strTeachingPlanAuthor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingPlanAuthor, 50, conTeachingPlan.TeachingPlanAuthor);
objTeachingPlanEN.TeachingPlanAuthor = strTeachingPlanAuthor; //教案撰写人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingPlanEN.dicFldComparisonOp.ContainsKey(conTeachingPlan.TeachingPlanAuthor) == false)
{
objTeachingPlanEN.dicFldComparisonOp.Add(conTeachingPlan.TeachingPlanAuthor, strComparisonOp);
}
else
{
objTeachingPlanEN.dicFldComparisonOp[conTeachingPlan.TeachingPlanAuthor] = strComparisonOp;
}
}
return objTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingPlanEN SetTeachingObject(this clsTeachingPlanEN objTeachingPlanEN, string strTeachingObject, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingObject, 5000, conTeachingPlan.TeachingObject);
objTeachingPlanEN.TeachingObject = strTeachingObject; //教学目标
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingPlanEN.dicFldComparisonOp.ContainsKey(conTeachingPlan.TeachingObject) == false)
{
objTeachingPlanEN.dicFldComparisonOp.Add(conTeachingPlan.TeachingObject, strComparisonOp);
}
else
{
objTeachingPlanEN.dicFldComparisonOp[conTeachingPlan.TeachingObject] = strComparisonOp;
}
}
return objTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingPlanEN SetTeachingEmphases(this clsTeachingPlanEN objTeachingPlanEN, string strTeachingEmphases, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingEmphases, 5000, conTeachingPlan.TeachingEmphases);
objTeachingPlanEN.TeachingEmphases = strTeachingEmphases; //教学重点
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingPlanEN.dicFldComparisonOp.ContainsKey(conTeachingPlan.TeachingEmphases) == false)
{
objTeachingPlanEN.dicFldComparisonOp.Add(conTeachingPlan.TeachingEmphases, strComparisonOp);
}
else
{
objTeachingPlanEN.dicFldComparisonOp[conTeachingPlan.TeachingEmphases] = strComparisonOp;
}
}
return objTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingPlanEN SetTeachingDifficulty(this clsTeachingPlanEN objTeachingPlanEN, string strTeachingDifficulty, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingDifficulty, 5000, conTeachingPlan.TeachingDifficulty);
objTeachingPlanEN.TeachingDifficulty = strTeachingDifficulty; //教学难点
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingPlanEN.dicFldComparisonOp.ContainsKey(conTeachingPlan.TeachingDifficulty) == false)
{
objTeachingPlanEN.dicFldComparisonOp.Add(conTeachingPlan.TeachingDifficulty, strComparisonOp);
}
else
{
objTeachingPlanEN.dicFldComparisonOp[conTeachingPlan.TeachingDifficulty] = strComparisonOp;
}
}
return objTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingPlanEN SetTeachingTool(this clsTeachingPlanEN objTeachingPlanEN, string strTeachingTool, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingTool, 5000, conTeachingPlan.TeachingTool);
objTeachingPlanEN.TeachingTool = strTeachingTool; //教学用具
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingPlanEN.dicFldComparisonOp.ContainsKey(conTeachingPlan.TeachingTool) == false)
{
objTeachingPlanEN.dicFldComparisonOp.Add(conTeachingPlan.TeachingTool, strComparisonOp);
}
else
{
objTeachingPlanEN.dicFldComparisonOp[conTeachingPlan.TeachingTool] = strComparisonOp;
}
}
return objTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingPlanEN SetTeachingProcess(this clsTeachingPlanEN objTeachingPlanEN, string strTeachingProcess, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingProcess, 8000, conTeachingPlan.TeachingProcess);
objTeachingPlanEN.TeachingProcess = strTeachingProcess; //教学过程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingPlanEN.dicFldComparisonOp.ContainsKey(conTeachingPlan.TeachingProcess) == false)
{
objTeachingPlanEN.dicFldComparisonOp.Add(conTeachingPlan.TeachingProcess, strComparisonOp);
}
else
{
objTeachingPlanEN.dicFldComparisonOp[conTeachingPlan.TeachingProcess] = strComparisonOp;
}
}
return objTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingPlanEN SetTeachingPlanType(this clsTeachingPlanEN objTeachingPlanEN, string strTeachingPlanType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingPlanType, 1, conTeachingPlan.TeachingPlanType);
clsCheckSql.CheckFieldForeignKey(strTeachingPlanType, 1, conTeachingPlan.TeachingPlanType);
objTeachingPlanEN.TeachingPlanType = strTeachingPlanType; //教案类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingPlanEN.dicFldComparisonOp.ContainsKey(conTeachingPlan.TeachingPlanType) == false)
{
objTeachingPlanEN.dicFldComparisonOp.Add(conTeachingPlan.TeachingPlanType, strComparisonOp);
}
else
{
objTeachingPlanEN.dicFldComparisonOp[conTeachingPlan.TeachingPlanType] = strComparisonOp;
}
}
return objTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingPlanEN SetSimplePlanContent(this clsTeachingPlanEN objTeachingPlanEN, string strSimplePlanContent, string strComparisonOp="")
	{
objTeachingPlanEN.SimplePlanContent = strSimplePlanContent; //简案内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingPlanEN.dicFldComparisonOp.ContainsKey(conTeachingPlan.SimplePlanContent) == false)
{
objTeachingPlanEN.dicFldComparisonOp.Add(conTeachingPlan.SimplePlanContent, strComparisonOp);
}
else
{
objTeachingPlanEN.dicFldComparisonOp[conTeachingPlan.SimplePlanContent] = strComparisonOp;
}
}
return objTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingPlanEN SetTeachingPlanInDate(this clsTeachingPlanEN objTeachingPlanEN, string strTeachingPlanInDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingPlanInDate, 8, conTeachingPlan.TeachingPlanInDate);
clsCheckSql.CheckFieldForeignKey(strTeachingPlanInDate, 8, conTeachingPlan.TeachingPlanInDate);
objTeachingPlanEN.TeachingPlanInDate = strTeachingPlanInDate; //教案入库日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingPlanEN.dicFldComparisonOp.ContainsKey(conTeachingPlan.TeachingPlanInDate) == false)
{
objTeachingPlanEN.dicFldComparisonOp.Add(conTeachingPlan.TeachingPlanInDate, strComparisonOp);
}
else
{
objTeachingPlanEN.dicFldComparisonOp[conTeachingPlan.TeachingPlanInDate] = strComparisonOp;
}
}
return objTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingPlanEN SetTeachingPlanInTime(this clsTeachingPlanEN objTeachingPlanEN, string strTeachingPlanInTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingPlanInTime, 6, conTeachingPlan.TeachingPlanInTime);
clsCheckSql.CheckFieldForeignKey(strTeachingPlanInTime, 6, conTeachingPlan.TeachingPlanInTime);
objTeachingPlanEN.TeachingPlanInTime = strTeachingPlanInTime; //教案入库时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingPlanEN.dicFldComparisonOp.ContainsKey(conTeachingPlan.TeachingPlanInTime) == false)
{
objTeachingPlanEN.dicFldComparisonOp.Add(conTeachingPlan.TeachingPlanInTime, strComparisonOp);
}
else
{
objTeachingPlanEN.dicFldComparisonOp[conTeachingPlan.TeachingPlanInTime] = strComparisonOp;
}
}
return objTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingPlanEN SetUpdDate(this clsTeachingPlanEN objTeachingPlanEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conTeachingPlan.UpdDate);
objTeachingPlanEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingPlanEN.dicFldComparisonOp.ContainsKey(conTeachingPlan.UpdDate) == false)
{
objTeachingPlanEN.dicFldComparisonOp.Add(conTeachingPlan.UpdDate, strComparisonOp);
}
else
{
objTeachingPlanEN.dicFldComparisonOp[conTeachingPlan.UpdDate] = strComparisonOp;
}
}
return objTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingPlanEN SetUpdUserId(this clsTeachingPlanEN objTeachingPlanEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conTeachingPlan.UpdUserId);
objTeachingPlanEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingPlanEN.dicFldComparisonOp.ContainsKey(conTeachingPlan.UpdUserId) == false)
{
objTeachingPlanEN.dicFldComparisonOp.Add(conTeachingPlan.UpdUserId, strComparisonOp);
}
else
{
objTeachingPlanEN.dicFldComparisonOp[conTeachingPlan.UpdUserId] = strComparisonOp;
}
}
return objTeachingPlanEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objTeachingPlanEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsTeachingPlanEN SetMemo(this clsTeachingPlanEN objTeachingPlanEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conTeachingPlan.Memo);
objTeachingPlanEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objTeachingPlanEN.dicFldComparisonOp.ContainsKey(conTeachingPlan.Memo) == false)
{
objTeachingPlanEN.dicFldComparisonOp.Add(conTeachingPlan.Memo, strComparisonOp);
}
else
{
objTeachingPlanEN.dicFldComparisonOp[conTeachingPlan.Memo] = strComparisonOp;
}
}
return objTeachingPlanEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsTeachingPlanEN objTeachingPlan_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objTeachingPlan_Cond.IsUpdated(conTeachingPlan.id_TeachingPlan) == true)
{
string strComparisonOp_id_TeachingPlan = objTeachingPlan_Cond.dicFldComparisonOp[conTeachingPlan.id_TeachingPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingPlan.id_TeachingPlan, objTeachingPlan_Cond.id_TeachingPlan, strComparisonOp_id_TeachingPlan);
}
if (objTeachingPlan_Cond.IsUpdated(conTeachingPlan.SubjectName) == true)
{
string strComparisonOp_SubjectName = objTeachingPlan_Cond.dicFldComparisonOp[conTeachingPlan.SubjectName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingPlan.SubjectName, objTeachingPlan_Cond.SubjectName, strComparisonOp_SubjectName);
}
if (objTeachingPlan_Cond.IsUpdated(conTeachingPlan.TeachingPlanAuthor) == true)
{
string strComparisonOp_TeachingPlanAuthor = objTeachingPlan_Cond.dicFldComparisonOp[conTeachingPlan.TeachingPlanAuthor];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingPlan.TeachingPlanAuthor, objTeachingPlan_Cond.TeachingPlanAuthor, strComparisonOp_TeachingPlanAuthor);
}
if (objTeachingPlan_Cond.IsUpdated(conTeachingPlan.TeachingObject) == true)
{
string strComparisonOp_TeachingObject = objTeachingPlan_Cond.dicFldComparisonOp[conTeachingPlan.TeachingObject];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingPlan.TeachingObject, objTeachingPlan_Cond.TeachingObject, strComparisonOp_TeachingObject);
}
if (objTeachingPlan_Cond.IsUpdated(conTeachingPlan.TeachingEmphases) == true)
{
string strComparisonOp_TeachingEmphases = objTeachingPlan_Cond.dicFldComparisonOp[conTeachingPlan.TeachingEmphases];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingPlan.TeachingEmphases, objTeachingPlan_Cond.TeachingEmphases, strComparisonOp_TeachingEmphases);
}
if (objTeachingPlan_Cond.IsUpdated(conTeachingPlan.TeachingDifficulty) == true)
{
string strComparisonOp_TeachingDifficulty = objTeachingPlan_Cond.dicFldComparisonOp[conTeachingPlan.TeachingDifficulty];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingPlan.TeachingDifficulty, objTeachingPlan_Cond.TeachingDifficulty, strComparisonOp_TeachingDifficulty);
}
if (objTeachingPlan_Cond.IsUpdated(conTeachingPlan.TeachingTool) == true)
{
string strComparisonOp_TeachingTool = objTeachingPlan_Cond.dicFldComparisonOp[conTeachingPlan.TeachingTool];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingPlan.TeachingTool, objTeachingPlan_Cond.TeachingTool, strComparisonOp_TeachingTool);
}
if (objTeachingPlan_Cond.IsUpdated(conTeachingPlan.TeachingProcess) == true)
{
string strComparisonOp_TeachingProcess = objTeachingPlan_Cond.dicFldComparisonOp[conTeachingPlan.TeachingProcess];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingPlan.TeachingProcess, objTeachingPlan_Cond.TeachingProcess, strComparisonOp_TeachingProcess);
}
if (objTeachingPlan_Cond.IsUpdated(conTeachingPlan.TeachingPlanType) == true)
{
string strComparisonOp_TeachingPlanType = objTeachingPlan_Cond.dicFldComparisonOp[conTeachingPlan.TeachingPlanType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingPlan.TeachingPlanType, objTeachingPlan_Cond.TeachingPlanType, strComparisonOp_TeachingPlanType);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objTeachingPlan_Cond.IsUpdated(conTeachingPlan.TeachingPlanInDate) == true)
{
string strComparisonOp_TeachingPlanInDate = objTeachingPlan_Cond.dicFldComparisonOp[conTeachingPlan.TeachingPlanInDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingPlan.TeachingPlanInDate, objTeachingPlan_Cond.TeachingPlanInDate, strComparisonOp_TeachingPlanInDate);
}
if (objTeachingPlan_Cond.IsUpdated(conTeachingPlan.TeachingPlanInTime) == true)
{
string strComparisonOp_TeachingPlanInTime = objTeachingPlan_Cond.dicFldComparisonOp[conTeachingPlan.TeachingPlanInTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingPlan.TeachingPlanInTime, objTeachingPlan_Cond.TeachingPlanInTime, strComparisonOp_TeachingPlanInTime);
}
if (objTeachingPlan_Cond.IsUpdated(conTeachingPlan.UpdDate) == true)
{
string strComparisonOp_UpdDate = objTeachingPlan_Cond.dicFldComparisonOp[conTeachingPlan.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingPlan.UpdDate, objTeachingPlan_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objTeachingPlan_Cond.IsUpdated(conTeachingPlan.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objTeachingPlan_Cond.dicFldComparisonOp[conTeachingPlan.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingPlan.UpdUserId, objTeachingPlan_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objTeachingPlan_Cond.IsUpdated(conTeachingPlan.Memo) == true)
{
string strComparisonOp_Memo = objTeachingPlan_Cond.dicFldComparisonOp[conTeachingPlan.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conTeachingPlan.Memo, objTeachingPlan_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objTeachingPlanEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsTeachingPlanEN objTeachingPlanEN)
{
 if (string.IsNullOrEmpty(objTeachingPlanEN.id_TeachingPlan) == true)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objTeachingPlanEN.sf_UpdFldSetStr = objTeachingPlanEN.getsf_UpdFldSetStr();
clsTeachingPlanWApi.CheckPropertyNew(objTeachingPlanEN); 
bool bolResult = clsTeachingPlanWApi.UpdateRecord(objTeachingPlanEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingPlanWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000004)修改记录出错,{1}!(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objTeachingPlanEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsTeachingPlanEN objTeachingPlanEN)
{
 if (string.IsNullOrEmpty(objTeachingPlanEN.id_TeachingPlan) == true)
 {
string strMsg = string.Format("添加记录时，关键字不能为空!(from {0})\r\n", 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
 if (clsTeachingPlanWApi.IsExist(objTeachingPlanEN.id_TeachingPlan) == true)
 {
string strMsg = string.Format("添加记录时，关键字:[{0}]已经存在!(from {1})\r\n", objTeachingPlanEN.id_TeachingPlan, 
clsStackTrace.GetCurrClassFunction()); 
 throw new Exception(strMsg);
 }
try
{
clsTeachingPlanWApi.CheckPropertyNew(objTeachingPlanEN); 
bool bolResult = clsTeachingPlanWApi.AddNewRecord(objTeachingPlanEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingPlanWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000008)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,其中关键字为表中获取的最大值. 该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecordWithMaxId)
 /// </summary>
 /// <param name = "objTeachingPlanEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static string AddNewRecordWithMaxId(this clsTeachingPlanEN objTeachingPlanEN)
{
try
{
clsTeachingPlanWApi.CheckPropertyNew(objTeachingPlanEN); 
string strid_TeachingPlan = clsTeachingPlanWApi.AddNewRecordWithMaxId(objTeachingPlanEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingPlanWApi.ReFreshCache();
return strid_TeachingPlan;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000009)添加记录出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objTeachingPlanEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsTeachingPlanEN objTeachingPlanEN, string strWhereCond)
{
try
{
clsTeachingPlanWApi.CheckPropertyNew(objTeachingPlanEN); 
bool bolResult = clsTeachingPlanWApi.UpdateWithCondition(objTeachingPlanEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingPlanWApi.ReFreshCache();
return bolResult;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Watl000007)根据条件修改记录出错, {1}.(from {0})\r\n",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}
}
 /// <summary>
 /// 教案(TeachingPlan)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsTeachingPlanWApi
{
private static readonly string mstrApiControllerName = "TeachingPlanApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsTeachingPlanWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsTeachingPlanEN objTeachingPlanEN)
{
if (!Object.Equals(null, objTeachingPlanEN.id_TeachingPlan) && GetStrLen(objTeachingPlanEN.id_TeachingPlan) > 8)
{
 throw new Exception("字段[教案流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objTeachingPlanEN.SubjectName) && GetStrLen(objTeachingPlanEN.SubjectName) > 200)
{
 throw new Exception("字段[课题名称]的长度不能超过200!");
}
if (!Object.Equals(null, objTeachingPlanEN.TeachingPlanAuthor) && GetStrLen(objTeachingPlanEN.TeachingPlanAuthor) > 50)
{
 throw new Exception("字段[教案撰写人]的长度不能超过50!");
}
if (!Object.Equals(null, objTeachingPlanEN.TeachingObject) && GetStrLen(objTeachingPlanEN.TeachingObject) > 5000)
{
 throw new Exception("字段[教学目标]的长度不能超过5000!");
}
if (!Object.Equals(null, objTeachingPlanEN.TeachingEmphases) && GetStrLen(objTeachingPlanEN.TeachingEmphases) > 5000)
{
 throw new Exception("字段[教学重点]的长度不能超过5000!");
}
if (!Object.Equals(null, objTeachingPlanEN.TeachingDifficulty) && GetStrLen(objTeachingPlanEN.TeachingDifficulty) > 5000)
{
 throw new Exception("字段[教学难点]的长度不能超过5000!");
}
if (!Object.Equals(null, objTeachingPlanEN.TeachingTool) && GetStrLen(objTeachingPlanEN.TeachingTool) > 5000)
{
 throw new Exception("字段[教学用具]的长度不能超过5000!");
}
if (!Object.Equals(null, objTeachingPlanEN.TeachingProcess) && GetStrLen(objTeachingPlanEN.TeachingProcess) > 8000)
{
 throw new Exception("字段[教学过程]的长度不能超过8000!");
}
if (!Object.Equals(null, objTeachingPlanEN.TeachingPlanType) && GetStrLen(objTeachingPlanEN.TeachingPlanType) > 1)
{
 throw new Exception("字段[教案类型]的长度不能超过1!");
}
if (!Object.Equals(null, objTeachingPlanEN.TeachingPlanInDate) && GetStrLen(objTeachingPlanEN.TeachingPlanInDate) > 8)
{
 throw new Exception("字段[教案入库日期]的长度不能超过8!");
}
if (!Object.Equals(null, objTeachingPlanEN.TeachingPlanInTime) && GetStrLen(objTeachingPlanEN.TeachingPlanInTime) > 6)
{
 throw new Exception("字段[教案入库时间]的长度不能超过6!");
}
if (!Object.Equals(null, objTeachingPlanEN.UpdDate) && GetStrLen(objTeachingPlanEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objTeachingPlanEN.UpdUserId) && GetStrLen(objTeachingPlanEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objTeachingPlanEN.Memo) && GetStrLen(objTeachingPlanEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objTeachingPlanEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_TeachingPlan">表关键字</param>
 /// <returns>表对象</returns>
public static clsTeachingPlanEN GetObjByid_TeachingPlan(string strid_TeachingPlan)
{
string strAction = "GetObjByid_TeachingPlan";
string strErrMsg = string.Empty;
string strResult = "";
clsTeachingPlanEN objTeachingPlanEN = null;
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
objTeachingPlanEN = JsonConvert.DeserializeObject<clsTeachingPlanEN>((string)jobjReturn["ReturnObj"]);
return objTeachingPlanEN;
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
public static clsTeachingPlanEN GetObjByid_TeachingPlan_WA_Cache(string strid_TeachingPlan)
{
string strAction = "GetObjByid_TeachingPlan_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsTeachingPlanEN objTeachingPlanEN = null;
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
objTeachingPlanEN = JsonConvert.DeserializeObject<clsTeachingPlanEN>((string)jobjReturn["ReturnObj"]);
return objTeachingPlanEN;
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
public static clsTeachingPlanEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsTeachingPlanEN objTeachingPlanEN = null;
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
objTeachingPlanEN = JsonConvert.DeserializeObject<clsTeachingPlanEN>((string)jobjReturn["ReturnObj"]);
return objTeachingPlanEN;
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
public static clsTeachingPlanEN GetObjByid_TeachingPlan_Cache(string strid_TeachingPlan)
{
if (string.IsNullOrEmpty(strid_TeachingPlan) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}", clsTeachingPlanEN._CurrTabName_S);
List<clsTeachingPlanEN> arrTeachingPlanObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsTeachingPlanEN> arrTeachingPlanObjLst_Sel =
from objTeachingPlanEN in arrTeachingPlanObjLst_Cache
where objTeachingPlanEN.id_TeachingPlan == strid_TeachingPlan
select objTeachingPlanEN;
if (arrTeachingPlanObjLst_Sel.Count() == 0)
{
   clsTeachingPlanEN obj = clsTeachingPlanWApi.GetObjByid_TeachingPlan(strid_TeachingPlan);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrTeachingPlanObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsTeachingPlanEN> GetObjLst(string strWhereCond)
{
 List<clsTeachingPlanEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTeachingPlanEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsTeachingPlanEN> GetObjLstById_TeachingPlanLst(List<string> arrId_TeachingPlan)
{
 List<clsTeachingPlanEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTeachingPlanEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsTeachingPlanEN> GetObjLstById_TeachingPlanLst_Cache(List<string> arrId_TeachingPlan)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsTeachingPlanEN._CurrTabName_S);
List<clsTeachingPlanEN> arrTeachingPlanObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsTeachingPlanEN> arrTeachingPlanObjLst_Sel =
from objTeachingPlanEN in arrTeachingPlanObjLst_Cache
where arrId_TeachingPlan.Contains(objTeachingPlanEN.id_TeachingPlan)
select objTeachingPlanEN;
return arrTeachingPlanObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsTeachingPlanEN> GetObjLstById_TeachingPlanLst_WA_Cache(List<string> arrId_TeachingPlan)
{
 List<clsTeachingPlanEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTeachingPlanEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsTeachingPlanEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsTeachingPlanEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTeachingPlanEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsTeachingPlanEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsTeachingPlanEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTeachingPlanEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsTeachingPlanEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsTeachingPlanEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTeachingPlanEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsTeachingPlanEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsTeachingPlanEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsTeachingPlanEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// 根据关键字删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecord(string strid_TeachingPlan)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsTeachingPlanEN objTeachingPlanEN = clsTeachingPlanWApi.GetObjByid_TeachingPlan(strid_TeachingPlan);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, strid_TeachingPlan.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsTeachingPlanWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelRecords)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelRecords(string strKeyIdLst)
{
string strAction = "DelRecords";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strKeyIdLst, out strResult, out strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据关键字列表删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecord)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelTeachingPlans(List<string> arrid_TeachingPlan)
{
string strAction = "DelTeachingPlans";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrid_TeachingPlan);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsTeachingPlanWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据条件删除记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DelMultiRecordByCond)
 /// </summary>
 /// <returns>实际删除记录的个数</returns>
public static int DelTeachingPlansByCond(string strWhereCond)
{
string strAction = "DelTeachingPlansByCond";
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool AddNewRecord(clsTeachingPlanEN objTeachingPlanEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTeachingPlanEN>(objTeachingPlanEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingPlanWApi.ReFreshCache();
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 添加记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithMaxId)
 /// </summary>
 /// <returns>是否成功?</returns>
public static string AddNewRecordWithMaxId(clsTeachingPlanEN objTeachingPlanEN)
{
string strAction = "AddNewRecordWithMaxId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTeachingPlanEN>(objTeachingPlanEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingPlanWApi.ReFreshCache();
var strid_TeachingPlan = (string)jobjReturn["ReturnStr"];
return strid_TeachingPlan;
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsTeachingPlanEN objTeachingPlanEN)
{
if (string.IsNullOrEmpty(objTeachingPlanEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objTeachingPlanEN.id_TeachingPlan, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTeachingPlanEN>(objTeachingPlanEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
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
 string strMsg = string.Format("执行WebApi功能出错, {0}.(from {1}). WebApi地址:{2}).",
      HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction(),
clsPubFun4WApi.GetWebApiUrl(mstrApiControllerName, strAction));
 throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateWithCondition)
 /// </summary>
 /// <param name = "objTeachingPlanEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsTeachingPlanEN objTeachingPlanEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objTeachingPlanEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objTeachingPlanEN.id_TeachingPlan, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objTeachingPlanEN.id_TeachingPlan, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsTeachingPlanEN>(objTeachingPlanEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
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
 /// 根据条件设置字段值
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_funSetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strValue">值</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>记录数</returns>
public static int SetFldValue(string strFldName, string strValue, string strWhereCond)
{
string strAction = "SetFldValue";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["strFldName"] = strFldName,
["strValue"] = strValue,
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
string strMsg = string.Format("根据条件设置字段值,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrId)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId()
{
string strAction = "GetMaxStrId";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
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
string strMsg = string.Format("获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 根据前缀获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrIdByPrefix(string strPrefix)
{
//检测记录是否存在
string strAction = "GetMaxStrIdByPrefix";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
dictParam.Add("strPrefix", strPrefix);
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
string strMsg = string.Format("根据前缀获取最大值出错,{0}.(from {1})", HttpUtility.UrlDecode(objException.Message), clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
}

 /// <summary>
 /// 获取字符串长度,其中汉字为2个字节,英文为1个字节
 /// (AutoGCLib.clsGeneCodeBase:GengetStrLen)
 /// </summary>
 /// <param name = "strTemp">给定的原字符串</param>
 /// <returns>返回字符串长度</returns>
public static int GetStrLen(string strTemp)
{
int len ;
byte[] sarr = System.Text.Encoding.Default.GetBytes(strTemp);
len = sarr.Length;//will output as 3+3*2 = 9
return len;
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CopyObj_S)
 /// </summary>
 /// <param name = "objTeachingPlanENS">源对象</param>
 /// <param name = "objTeachingPlanENT">目标对象</param>
 public static void CopyTo(clsTeachingPlanEN objTeachingPlanENS, clsTeachingPlanEN objTeachingPlanENT)
{
try
{
objTeachingPlanENT.id_TeachingPlan = objTeachingPlanENS.id_TeachingPlan; //教案流水号
objTeachingPlanENT.SubjectName = objTeachingPlanENS.SubjectName; //课题名称
objTeachingPlanENT.TeachingPlanAuthor = objTeachingPlanENS.TeachingPlanAuthor; //教案撰写人
objTeachingPlanENT.TeachingObject = objTeachingPlanENS.TeachingObject; //教学目标
objTeachingPlanENT.TeachingEmphases = objTeachingPlanENS.TeachingEmphases; //教学重点
objTeachingPlanENT.TeachingDifficulty = objTeachingPlanENS.TeachingDifficulty; //教学难点
objTeachingPlanENT.TeachingTool = objTeachingPlanENS.TeachingTool; //教学用具
objTeachingPlanENT.TeachingProcess = objTeachingPlanENS.TeachingProcess; //教学过程
objTeachingPlanENT.TeachingPlanType = objTeachingPlanENS.TeachingPlanType; //教案类型
objTeachingPlanENT.SimplePlanContent = objTeachingPlanENS.SimplePlanContent; //简案内容
objTeachingPlanENT.TeachingPlanInDate = objTeachingPlanENS.TeachingPlanInDate; //教案入库日期
objTeachingPlanENT.TeachingPlanInTime = objTeachingPlanENS.TeachingPlanInTime; //教案入库时间
objTeachingPlanENT.UpdDate = objTeachingPlanENS.UpdDate; //修改日期
objTeachingPlanENT.UpdUserId = objTeachingPlanENS.UpdUserId; //修改用户Id
objTeachingPlanENT.Memo = objTeachingPlanENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsTeachingPlanEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsTeachingPlanEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsTeachingPlanEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsTeachingPlanEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsTeachingPlanEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsTeachingPlanEN.AttributeName)
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
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_TeachingPlan");
//if (arrTeachingPlanObjLst_Cache == null)
//{
//arrTeachingPlanObjLst_Cache = await clsTeachingPlanWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsTeachingPlanEN._CurrTabName_S);
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
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshCache)
 /// </summary>
public static void ReFreshCache()
{
  if (clsSysParaEN.spIsUseQueue4Task == true)
{
if (clsSysParaEN.arrFunctionLst4Queue == null)
{
clsSysParaEN.arrFunctionLst4Queue = new Queue<object>();
}
}
if (clsTeachingPlanWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsTeachingPlanEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsTeachingPlanWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsTeachingPlanEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsTeachingPlanEN._CurrTabName_S);
List<clsTeachingPlanEN> arrTeachingPlanObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrTeachingPlanObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsTeachingPlanEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conTeachingPlan.id_TeachingPlan, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingPlan.SubjectName, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingPlan.TeachingPlanAuthor, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingPlan.TeachingObject, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingPlan.TeachingEmphases, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingPlan.TeachingDifficulty, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingPlan.TeachingTool, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingPlan.TeachingProcess, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingPlan.TeachingPlanType, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingPlan.SimplePlanContent, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingPlan.TeachingPlanInDate, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingPlan.TeachingPlanInTime, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingPlan.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingPlan.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conTeachingPlan.Memo, Type.GetType("System.String"));
foreach (clsTeachingPlanEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conTeachingPlan.id_TeachingPlan] = objInFor[conTeachingPlan.id_TeachingPlan];
objDR[conTeachingPlan.SubjectName] = objInFor[conTeachingPlan.SubjectName];
objDR[conTeachingPlan.TeachingPlanAuthor] = objInFor[conTeachingPlan.TeachingPlanAuthor];
objDR[conTeachingPlan.TeachingObject] = objInFor[conTeachingPlan.TeachingObject];
objDR[conTeachingPlan.TeachingEmphases] = objInFor[conTeachingPlan.TeachingEmphases];
objDR[conTeachingPlan.TeachingDifficulty] = objInFor[conTeachingPlan.TeachingDifficulty];
objDR[conTeachingPlan.TeachingTool] = objInFor[conTeachingPlan.TeachingTool];
objDR[conTeachingPlan.TeachingProcess] = objInFor[conTeachingPlan.TeachingProcess];
objDR[conTeachingPlan.TeachingPlanType] = objInFor[conTeachingPlan.TeachingPlanType];
objDR[conTeachingPlan.SimplePlanContent] = objInFor[conTeachingPlan.SimplePlanContent];
objDR[conTeachingPlan.TeachingPlanInDate] = objInFor[conTeachingPlan.TeachingPlanInDate];
objDR[conTeachingPlan.TeachingPlanInTime] = objInFor[conTeachingPlan.TeachingPlanInTime];
objDR[conTeachingPlan.UpdDate] = objInFor[conTeachingPlan.UpdDate];
objDR[conTeachingPlan.UpdUserId] = objInFor[conTeachingPlan.UpdUserId];
objDR[conTeachingPlan.Memo] = objInFor[conTeachingPlan.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 教案(TeachingPlan)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4TeachingPlan : clsCommFun4BL
{

 /// <summary>
 /// 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
 /// (AutoGCLib.CommFun4WA4CSharp:Gen_4CFWA_ReFreshCache)
 /// </summary>
public override void ReFreshCache()
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == false)
{
strMsg = string.Format("刷新缓存已经关闭。(clsSysParaEN.spSetRefreshCacheOn == false)({2}->{1}->{0})",
clsStackTrace.GetCurrClassFunction(),
clsStackTrace.GetCurrClassFunctionByLevel(2),
clsStackTrace.GetCurrClassFunctionByLevel(3));
clsSysParaEN.objLog.WriteDebugLog(strMsg);
return;
}
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsTeachingPlanWApi.ReFreshThisCache();
}
}

}