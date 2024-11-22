
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCaseCourseKnowledgeRelaWApi
 表名:CaseCourseKnowledgeRela(01120392)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:43:18
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
public static class clsCaseCourseKnowledgeRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCourseKnowledgeRelaEN Setid_CaseCourseKnowledgeRela(this clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN, long lngid_CaseCourseKnowledgeRela, string strComparisonOp="")
	{
objCaseCourseKnowledgeRelaEN.id_CaseCourseKnowledgeRela = lngid_CaseCourseKnowledgeRela; //案例知识点关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseKnowledgeRela.id_CaseCourseKnowledgeRela) == false)
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(conCaseCourseKnowledgeRela.id_CaseCourseKnowledgeRela, strComparisonOp);
}
else
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp[conCaseCourseKnowledgeRela.id_CaseCourseKnowledgeRela] = strComparisonOp;
}
}
return objCaseCourseKnowledgeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCourseKnowledgeRelaEN SetFuncModuleId(this clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, conCaseCourseKnowledgeRela.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, conCaseCourseKnowledgeRela.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, conCaseCourseKnowledgeRela.FuncModuleId);
objCaseCourseKnowledgeRelaEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseKnowledgeRela.FuncModuleId) == false)
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(conCaseCourseKnowledgeRela.FuncModuleId, strComparisonOp);
}
else
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp[conCaseCourseKnowledgeRela.FuncModuleId] = strComparisonOp;
}
}
return objCaseCourseKnowledgeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCourseKnowledgeRelaEN SetCaseId(this clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN, string strCaseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseId, conCaseCourseKnowledgeRela.CaseId);
clsCheckSql.CheckFieldLen(strCaseId, 8, conCaseCourseKnowledgeRela.CaseId);
clsCheckSql.CheckFieldForeignKey(strCaseId, 8, conCaseCourseKnowledgeRela.CaseId);
objCaseCourseKnowledgeRelaEN.CaseId = strCaseId; //案例Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseKnowledgeRela.CaseId) == false)
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(conCaseCourseKnowledgeRela.CaseId, strComparisonOp);
}
else
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp[conCaseCourseKnowledgeRela.CaseId] = strComparisonOp;
}
}
return objCaseCourseKnowledgeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCourseKnowledgeRelaEN SetCaseName(this clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN, string strCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseName, conCaseCourseKnowledgeRela.CaseName);
clsCheckSql.CheckFieldLen(strCaseName, 100, conCaseCourseKnowledgeRela.CaseName);
objCaseCourseKnowledgeRelaEN.CaseName = strCaseName; //案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseKnowledgeRela.CaseName) == false)
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(conCaseCourseKnowledgeRela.CaseName, strComparisonOp);
}
else
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp[conCaseCourseKnowledgeRela.CaseName] = strComparisonOp;
}
}
return objCaseCourseKnowledgeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCourseKnowledgeRelaEN SetOwnerId(this clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerId, 20, conCaseCourseKnowledgeRela.OwnerId);
objCaseCourseKnowledgeRelaEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseKnowledgeRela.OwnerId) == false)
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(conCaseCourseKnowledgeRela.OwnerId, strComparisonOp);
}
else
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp[conCaseCourseKnowledgeRela.OwnerId] = strComparisonOp;
}
}
return objCaseCourseKnowledgeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCourseKnowledgeRelaEN SetCourseKnowledgeId(this clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN, string strCourseKnowledgeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseKnowledgeId, 8, conCaseCourseKnowledgeRela.CourseKnowledgeId);
clsCheckSql.CheckFieldForeignKey(strCourseKnowledgeId, 8, conCaseCourseKnowledgeRela.CourseKnowledgeId);
objCaseCourseKnowledgeRelaEN.CourseKnowledgeId = strCourseKnowledgeId; //知识点Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseKnowledgeRela.CourseKnowledgeId) == false)
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(conCaseCourseKnowledgeRela.CourseKnowledgeId, strComparisonOp);
}
else
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp[conCaseCourseKnowledgeRela.CourseKnowledgeId] = strComparisonOp;
}
}
return objCaseCourseKnowledgeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCourseKnowledgeRelaEN Setid_CaseCourseKnowledgeRelaType(this clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN, string strid_CaseCourseKnowledgeRelaType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_CaseCourseKnowledgeRelaType, conCaseCourseKnowledgeRela.id_CaseCourseKnowledgeRelaType);
clsCheckSql.CheckFieldLen(strid_CaseCourseKnowledgeRelaType, 4, conCaseCourseKnowledgeRela.id_CaseCourseKnowledgeRelaType);
clsCheckSql.CheckFieldForeignKey(strid_CaseCourseKnowledgeRelaType, 4, conCaseCourseKnowledgeRela.id_CaseCourseKnowledgeRelaType);
objCaseCourseKnowledgeRelaEN.id_CaseCourseKnowledgeRelaType = strid_CaseCourseKnowledgeRelaType; //案例知识点关系类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseKnowledgeRela.id_CaseCourseKnowledgeRelaType) == false)
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(conCaseCourseKnowledgeRela.id_CaseCourseKnowledgeRelaType, strComparisonOp);
}
else
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp[conCaseCourseKnowledgeRela.id_CaseCourseKnowledgeRelaType] = strComparisonOp;
}
}
return objCaseCourseKnowledgeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCourseKnowledgeRelaEN SetRelationsDegree(this clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN, int intRelationsDegree, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intRelationsDegree, conCaseCourseKnowledgeRela.RelationsDegree);
objCaseCourseKnowledgeRelaEN.RelationsDegree = intRelationsDegree; //关系度
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseKnowledgeRela.RelationsDegree) == false)
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(conCaseCourseKnowledgeRela.RelationsDegree, strComparisonOp);
}
else
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp[conCaseCourseKnowledgeRela.RelationsDegree] = strComparisonOp;
}
}
return objCaseCourseKnowledgeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCourseKnowledgeRelaEN SetBrowseCount(this clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN, int intBrowseCount, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intBrowseCount, conCaseCourseKnowledgeRela.BrowseCount);
objCaseCourseKnowledgeRelaEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseKnowledgeRela.BrowseCount) == false)
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(conCaseCourseKnowledgeRela.BrowseCount, strComparisonOp);
}
else
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp[conCaseCourseKnowledgeRela.BrowseCount] = strComparisonOp;
}
}
return objCaseCourseKnowledgeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCourseKnowledgeRelaEN SetOrderNum(this clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN, int intOrderNum, string strComparisonOp="")
	{
objCaseCourseKnowledgeRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseKnowledgeRela.OrderNum) == false)
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(conCaseCourseKnowledgeRela.OrderNum, strComparisonOp);
}
else
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp[conCaseCourseKnowledgeRela.OrderNum] = strComparisonOp;
}
}
return objCaseCourseKnowledgeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCourseKnowledgeRelaEN SetUpdDate(this clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCaseCourseKnowledgeRela.UpdDate);
objCaseCourseKnowledgeRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseKnowledgeRela.UpdDate) == false)
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(conCaseCourseKnowledgeRela.UpdDate, strComparisonOp);
}
else
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp[conCaseCourseKnowledgeRela.UpdDate] = strComparisonOp;
}
}
return objCaseCourseKnowledgeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCourseKnowledgeRelaEN SetUpdUserId(this clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conCaseCourseKnowledgeRela.UpdUserId);
objCaseCourseKnowledgeRelaEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseKnowledgeRela.UpdUserId) == false)
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(conCaseCourseKnowledgeRela.UpdUserId, strComparisonOp);
}
else
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp[conCaseCourseKnowledgeRela.UpdUserId] = strComparisonOp;
}
}
return objCaseCourseKnowledgeRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCourseKnowledgeRelaEN SetMemo(this clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCaseCourseKnowledgeRela.Memo);
objCaseCourseKnowledgeRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseKnowledgeRela.Memo) == false)
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp.Add(conCaseCourseKnowledgeRela.Memo, strComparisonOp);
}
else
{
objCaseCourseKnowledgeRelaEN.dicFldComparisonOp[conCaseCourseKnowledgeRela.Memo] = strComparisonOp;
}
}
return objCaseCourseKnowledgeRelaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRela_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCaseCourseKnowledgeRela_Cond.IsUpdated(conCaseCourseKnowledgeRela.id_CaseCourseKnowledgeRela) == true)
{
string strComparisonOp_id_CaseCourseKnowledgeRela = objCaseCourseKnowledgeRela_Cond.dicFldComparisonOp[conCaseCourseKnowledgeRela.id_CaseCourseKnowledgeRela];
strWhereCond += string.Format(" And {0} {2} {1}", conCaseCourseKnowledgeRela.id_CaseCourseKnowledgeRela, objCaseCourseKnowledgeRela_Cond.id_CaseCourseKnowledgeRela, strComparisonOp_id_CaseCourseKnowledgeRela);
}
if (objCaseCourseKnowledgeRela_Cond.IsUpdated(conCaseCourseKnowledgeRela.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objCaseCourseKnowledgeRela_Cond.dicFldComparisonOp[conCaseCourseKnowledgeRela.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCourseKnowledgeRela.FuncModuleId, objCaseCourseKnowledgeRela_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objCaseCourseKnowledgeRela_Cond.IsUpdated(conCaseCourseKnowledgeRela.CaseId) == true)
{
string strComparisonOp_CaseId = objCaseCourseKnowledgeRela_Cond.dicFldComparisonOp[conCaseCourseKnowledgeRela.CaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCourseKnowledgeRela.CaseId, objCaseCourseKnowledgeRela_Cond.CaseId, strComparisonOp_CaseId);
}
if (objCaseCourseKnowledgeRela_Cond.IsUpdated(conCaseCourseKnowledgeRela.CaseName) == true)
{
string strComparisonOp_CaseName = objCaseCourseKnowledgeRela_Cond.dicFldComparisonOp[conCaseCourseKnowledgeRela.CaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCourseKnowledgeRela.CaseName, objCaseCourseKnowledgeRela_Cond.CaseName, strComparisonOp_CaseName);
}
if (objCaseCourseKnowledgeRela_Cond.IsUpdated(conCaseCourseKnowledgeRela.OwnerId) == true)
{
string strComparisonOp_OwnerId = objCaseCourseKnowledgeRela_Cond.dicFldComparisonOp[conCaseCourseKnowledgeRela.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCourseKnowledgeRela.OwnerId, objCaseCourseKnowledgeRela_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objCaseCourseKnowledgeRela_Cond.IsUpdated(conCaseCourseKnowledgeRela.CourseKnowledgeId) == true)
{
string strComparisonOp_CourseKnowledgeId = objCaseCourseKnowledgeRela_Cond.dicFldComparisonOp[conCaseCourseKnowledgeRela.CourseKnowledgeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCourseKnowledgeRela.CourseKnowledgeId, objCaseCourseKnowledgeRela_Cond.CourseKnowledgeId, strComparisonOp_CourseKnowledgeId);
}
if (objCaseCourseKnowledgeRela_Cond.IsUpdated(conCaseCourseKnowledgeRela.id_CaseCourseKnowledgeRelaType) == true)
{
string strComparisonOp_id_CaseCourseKnowledgeRelaType = objCaseCourseKnowledgeRela_Cond.dicFldComparisonOp[conCaseCourseKnowledgeRela.id_CaseCourseKnowledgeRelaType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCourseKnowledgeRela.id_CaseCourseKnowledgeRelaType, objCaseCourseKnowledgeRela_Cond.id_CaseCourseKnowledgeRelaType, strComparisonOp_id_CaseCourseKnowledgeRelaType);
}
if (objCaseCourseKnowledgeRela_Cond.IsUpdated(conCaseCourseKnowledgeRela.RelationsDegree) == true)
{
string strComparisonOp_RelationsDegree = objCaseCourseKnowledgeRela_Cond.dicFldComparisonOp[conCaseCourseKnowledgeRela.RelationsDegree];
strWhereCond += string.Format(" And {0} {2} {1}", conCaseCourseKnowledgeRela.RelationsDegree, objCaseCourseKnowledgeRela_Cond.RelationsDegree, strComparisonOp_RelationsDegree);
}
if (objCaseCourseKnowledgeRela_Cond.IsUpdated(conCaseCourseKnowledgeRela.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objCaseCourseKnowledgeRela_Cond.dicFldComparisonOp[conCaseCourseKnowledgeRela.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conCaseCourseKnowledgeRela.BrowseCount, objCaseCourseKnowledgeRela_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objCaseCourseKnowledgeRela_Cond.IsUpdated(conCaseCourseKnowledgeRela.OrderNum) == true)
{
string strComparisonOp_OrderNum = objCaseCourseKnowledgeRela_Cond.dicFldComparisonOp[conCaseCourseKnowledgeRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conCaseCourseKnowledgeRela.OrderNum, objCaseCourseKnowledgeRela_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objCaseCourseKnowledgeRela_Cond.IsUpdated(conCaseCourseKnowledgeRela.UpdDate) == true)
{
string strComparisonOp_UpdDate = objCaseCourseKnowledgeRela_Cond.dicFldComparisonOp[conCaseCourseKnowledgeRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCourseKnowledgeRela.UpdDate, objCaseCourseKnowledgeRela_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objCaseCourseKnowledgeRela_Cond.IsUpdated(conCaseCourseKnowledgeRela.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objCaseCourseKnowledgeRela_Cond.dicFldComparisonOp[conCaseCourseKnowledgeRela.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCourseKnowledgeRela.UpdUserId, objCaseCourseKnowledgeRela_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objCaseCourseKnowledgeRela_Cond.IsUpdated(conCaseCourseKnowledgeRela.Memo) == true)
{
string strComparisonOp_Memo = objCaseCourseKnowledgeRela_Cond.dicFldComparisonOp[conCaseCourseKnowledgeRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCourseKnowledgeRela.Memo, objCaseCourseKnowledgeRela_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN)
{
 if (objCaseCourseKnowledgeRelaEN.id_CaseCourseKnowledgeRela == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objCaseCourseKnowledgeRelaEN.sf_UpdFldSetStr = objCaseCourseKnowledgeRelaEN.getsf_UpdFldSetStr();
clsCaseCourseKnowledgeRelaWApi.CheckPropertyNew(objCaseCourseKnowledgeRelaEN); 
bool bolResult = clsCaseCourseKnowledgeRelaWApi.UpdateRecord(objCaseCourseKnowledgeRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCourseKnowledgeRelaWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--CaseCourseKnowledgeRela(案例知识点关系), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_CaseId_CourseKnowledgeId(this clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCaseCourseKnowledgeRelaEN == null) return "";
if (objCaseCourseKnowledgeRelaEN.id_CaseCourseKnowledgeRela == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CaseId = '{0}'", objCaseCourseKnowledgeRelaEN.CaseId);
 sbCondition.AppendFormat(" and CourseKnowledgeId = '{0}'", objCaseCourseKnowledgeRelaEN.CourseKnowledgeId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("id_CaseCourseKnowledgeRela !=  {0}", objCaseCourseKnowledgeRelaEN.id_CaseCourseKnowledgeRela);
 sbCondition.AppendFormat(" and CaseId = '{0}'", objCaseCourseKnowledgeRelaEN.CaseId);
 sbCondition.AppendFormat(" and CourseKnowledgeId = '{0}'", objCaseCourseKnowledgeRelaEN.CourseKnowledgeId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN)
{
try
{
clsCaseCourseKnowledgeRelaWApi.CheckPropertyNew(objCaseCourseKnowledgeRelaEN); 
bool bolResult = clsCaseCourseKnowledgeRelaWApi.AddNewRecord(objCaseCourseKnowledgeRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCourseKnowledgeRelaWApi.ReFreshCache();
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
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 缺点:1、不能处理字段中的单撇问题；2、不能处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_UpdateWithCondition)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN, string strWhereCond)
{
try
{
clsCaseCourseKnowledgeRelaWApi.CheckPropertyNew(objCaseCourseKnowledgeRelaEN); 
bool bolResult = clsCaseCourseKnowledgeRelaWApi.UpdateWithCondition(objCaseCourseKnowledgeRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCourseKnowledgeRelaWApi.ReFreshCache();
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
 /// 案例知识点关系(CaseCourseKnowledgeRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsCaseCourseKnowledgeRelaWApi
{
private static readonly string mstrApiControllerName = "CaseCourseKnowledgeRelaApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsCaseCourseKnowledgeRelaWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN)
{
if (!Object.Equals(null, objCaseCourseKnowledgeRelaEN.FuncModuleId) && GetStrLen(objCaseCourseKnowledgeRelaEN.FuncModuleId) > 4)
{
 throw new Exception("字段[功能模块Id]的长度不能超过4!");
}
if (!Object.Equals(null, objCaseCourseKnowledgeRelaEN.CaseId) && GetStrLen(objCaseCourseKnowledgeRelaEN.CaseId) > 8)
{
 throw new Exception("字段[案例Id]的长度不能超过8!");
}
if (!Object.Equals(null, objCaseCourseKnowledgeRelaEN.CaseName) && GetStrLen(objCaseCourseKnowledgeRelaEN.CaseName) > 100)
{
 throw new Exception("字段[案例名称]的长度不能超过100!");
}
if (!Object.Equals(null, objCaseCourseKnowledgeRelaEN.OwnerId) && GetStrLen(objCaseCourseKnowledgeRelaEN.OwnerId) > 20)
{
 throw new Exception("字段[拥有者Id]的长度不能超过20!");
}
if (!Object.Equals(null, objCaseCourseKnowledgeRelaEN.CourseKnowledgeId) && GetStrLen(objCaseCourseKnowledgeRelaEN.CourseKnowledgeId) > 8)
{
 throw new Exception("字段[知识点Id]的长度不能超过8!");
}
if (!Object.Equals(null, objCaseCourseKnowledgeRelaEN.id_CaseCourseKnowledgeRelaType) && GetStrLen(objCaseCourseKnowledgeRelaEN.id_CaseCourseKnowledgeRelaType) > 4)
{
 throw new Exception("字段[案例知识点关系类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objCaseCourseKnowledgeRelaEN.UpdDate) && GetStrLen(objCaseCourseKnowledgeRelaEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objCaseCourseKnowledgeRelaEN.UpdUserId) && GetStrLen(objCaseCourseKnowledgeRelaEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objCaseCourseKnowledgeRelaEN.Memo) && GetStrLen(objCaseCourseKnowledgeRelaEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objCaseCourseKnowledgeRelaEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_CaseCourseKnowledgeRela">表关键字</param>
 /// <returns>表对象</returns>
public static clsCaseCourseKnowledgeRelaEN GetObjByid_CaseCourseKnowledgeRela(long lngid_CaseCourseKnowledgeRela)
{
string strAction = "GetObjByid_CaseCourseKnowledgeRela";
string strErrMsg = string.Empty;
string strResult = "";
clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CaseCourseKnowledgeRela"] = lngid_CaseCourseKnowledgeRela.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objCaseCourseKnowledgeRelaEN = JsonConvert.DeserializeObject<clsCaseCourseKnowledgeRelaEN>((string)jobjReturn["ReturnObj"]);
return objCaseCourseKnowledgeRelaEN;
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
 /// <param name = "lngid_CaseCourseKnowledgeRela">表关键字</param>
 /// <returns>表对象</returns>
public static clsCaseCourseKnowledgeRelaEN GetObjByid_CaseCourseKnowledgeRela_WA_Cache(long lngid_CaseCourseKnowledgeRela)
{
string strAction = "GetObjByid_CaseCourseKnowledgeRela_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CaseCourseKnowledgeRela"] = lngid_CaseCourseKnowledgeRela.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objCaseCourseKnowledgeRelaEN = JsonConvert.DeserializeObject<clsCaseCourseKnowledgeRelaEN>((string)jobjReturn["ReturnObj"]);
return objCaseCourseKnowledgeRelaEN;
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
public static clsCaseCourseKnowledgeRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN = null;
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
objCaseCourseKnowledgeRelaEN = JsonConvert.DeserializeObject<clsCaseCourseKnowledgeRelaEN>((string)jobjReturn["ReturnObj"]);
return objCaseCourseKnowledgeRelaEN;
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
 /// <param name = "lngid_CaseCourseKnowledgeRela">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCaseCourseKnowledgeRelaEN GetObjByid_CaseCourseKnowledgeRela_Cache(long lngid_CaseCourseKnowledgeRela)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsCaseCourseKnowledgeRelaEN._CurrTabName_S);
List<clsCaseCourseKnowledgeRelaEN> arrCaseCourseKnowledgeRelaObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCaseCourseKnowledgeRelaEN> arrCaseCourseKnowledgeRelaObjLst_Sel =
from objCaseCourseKnowledgeRelaEN in arrCaseCourseKnowledgeRelaObjLst_Cache
where objCaseCourseKnowledgeRelaEN.id_CaseCourseKnowledgeRela == lngid_CaseCourseKnowledgeRela
select objCaseCourseKnowledgeRelaEN;
if (arrCaseCourseKnowledgeRelaObjLst_Sel.Count() == 0)
{
   clsCaseCourseKnowledgeRelaEN obj = clsCaseCourseKnowledgeRelaWApi.GetObjByid_CaseCourseKnowledgeRela(lngid_CaseCourseKnowledgeRela);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrCaseCourseKnowledgeRelaObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCaseCourseKnowledgeRelaEN> GetObjLst(string strWhereCond)
{
 List<clsCaseCourseKnowledgeRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseCourseKnowledgeRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCaseCourseKnowledgeRelaEN> GetObjLstById_CaseCourseKnowledgeRelaLst(List<long> arrId_CaseCourseKnowledgeRela)
{
 List<clsCaseCourseKnowledgeRelaEN> arrObjLst = null; 
string strAction = "GetObjLstById_CaseCourseKnowledgeRelaLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CaseCourseKnowledgeRela);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseCourseKnowledgeRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngid_CaseCourseKnowledgeRela">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsCaseCourseKnowledgeRelaEN> GetObjLstById_CaseCourseKnowledgeRelaLst_Cache(List<long> arrId_CaseCourseKnowledgeRela)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsCaseCourseKnowledgeRelaEN._CurrTabName_S);
List<clsCaseCourseKnowledgeRelaEN> arrCaseCourseKnowledgeRelaObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCaseCourseKnowledgeRelaEN> arrCaseCourseKnowledgeRelaObjLst_Sel =
from objCaseCourseKnowledgeRelaEN in arrCaseCourseKnowledgeRelaObjLst_Cache
where arrId_CaseCourseKnowledgeRela.Contains(objCaseCourseKnowledgeRelaEN.id_CaseCourseKnowledgeRela)
select objCaseCourseKnowledgeRelaEN;
return arrCaseCourseKnowledgeRelaObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCaseCourseKnowledgeRelaEN> GetObjLstById_CaseCourseKnowledgeRelaLst_WA_Cache(List<long> arrId_CaseCourseKnowledgeRela)
{
 List<clsCaseCourseKnowledgeRelaEN> arrObjLst = null; 
string strAction = "GetObjLstById_CaseCourseKnowledgeRelaLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CaseCourseKnowledgeRela);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseCourseKnowledgeRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCaseCourseKnowledgeRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsCaseCourseKnowledgeRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseCourseKnowledgeRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCaseCourseKnowledgeRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsCaseCourseKnowledgeRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseCourseKnowledgeRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCaseCourseKnowledgeRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsCaseCourseKnowledgeRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseCourseKnowledgeRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCaseCourseKnowledgeRelaEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsCaseCourseKnowledgeRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseCourseKnowledgeRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(long lngid_CaseCourseKnowledgeRela)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN = clsCaseCourseKnowledgeRelaWApi.GetObjByid_CaseCourseKnowledgeRela(lngid_CaseCourseKnowledgeRela);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngid_CaseCourseKnowledgeRela.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsCaseCourseKnowledgeRelaWApi.ReFreshCache();
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
public static int DelCaseCourseKnowledgeRelas(List<string> arrid_CaseCourseKnowledgeRela)
{
string strAction = "DelCaseCourseKnowledgeRelas";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrid_CaseCourseKnowledgeRela);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsCaseCourseKnowledgeRelaWApi.ReFreshCache();
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
public static int DelCaseCourseKnowledgeRelasByCond(string strWhereCond)
{
string strAction = "DelCaseCourseKnowledgeRelasByCond";
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
public static bool AddNewRecord(clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCaseCourseKnowledgeRelaEN>(objCaseCourseKnowledgeRelaEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCourseKnowledgeRelaWApi.ReFreshCache();
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
 /// 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_AddNewRecordWithReturnKey)
 /// </summary>
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCaseCourseKnowledgeRelaEN>(objCaseCourseKnowledgeRelaEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCourseKnowledgeRelaWApi.ReFreshCache();
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
 /// 修改记录
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_UpdateRecord)
 /// </summary>
 /// <returns>是否成功?</returns>
public static bool UpdateRecord(clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN)
{
if (string.IsNullOrEmpty(objCaseCourseKnowledgeRelaEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCaseCourseKnowledgeRelaEN.id_CaseCourseKnowledgeRela, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCaseCourseKnowledgeRelaEN>(objCaseCourseKnowledgeRelaEN);
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
 /// <param name = "objCaseCourseKnowledgeRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objCaseCourseKnowledgeRelaEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCaseCourseKnowledgeRelaEN.id_CaseCourseKnowledgeRela, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCaseCourseKnowledgeRelaEN.id_CaseCourseKnowledgeRela, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCaseCourseKnowledgeRelaEN>(objCaseCourseKnowledgeRelaEN);
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
public static bool IsExist(long lngid_CaseCourseKnowledgeRela)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CaseCourseKnowledgeRela"] = lngid_CaseCourseKnowledgeRela.ToString()
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
 /// <param name = "objCaseCourseKnowledgeRelaENS">源对象</param>
 /// <param name = "objCaseCourseKnowledgeRelaENT">目标对象</param>
 public static void CopyTo(clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaENS, clsCaseCourseKnowledgeRelaEN objCaseCourseKnowledgeRelaENT)
{
try
{
objCaseCourseKnowledgeRelaENT.id_CaseCourseKnowledgeRela = objCaseCourseKnowledgeRelaENS.id_CaseCourseKnowledgeRela; //案例知识点关系流水号
objCaseCourseKnowledgeRelaENT.FuncModuleId = objCaseCourseKnowledgeRelaENS.FuncModuleId; //功能模块Id
objCaseCourseKnowledgeRelaENT.CaseId = objCaseCourseKnowledgeRelaENS.CaseId; //案例Id
objCaseCourseKnowledgeRelaENT.CaseName = objCaseCourseKnowledgeRelaENS.CaseName; //案例名称
objCaseCourseKnowledgeRelaENT.OwnerId = objCaseCourseKnowledgeRelaENS.OwnerId; //拥有者Id
objCaseCourseKnowledgeRelaENT.CourseKnowledgeId = objCaseCourseKnowledgeRelaENS.CourseKnowledgeId; //知识点Id
objCaseCourseKnowledgeRelaENT.id_CaseCourseKnowledgeRelaType = objCaseCourseKnowledgeRelaENS.id_CaseCourseKnowledgeRelaType; //案例知识点关系类型流水号
objCaseCourseKnowledgeRelaENT.RelationsDegree = objCaseCourseKnowledgeRelaENS.RelationsDegree; //关系度
objCaseCourseKnowledgeRelaENT.BrowseCount = objCaseCourseKnowledgeRelaENS.BrowseCount; //浏览次数
objCaseCourseKnowledgeRelaENT.OrderNum = objCaseCourseKnowledgeRelaENS.OrderNum; //序号
objCaseCourseKnowledgeRelaENT.UpdDate = objCaseCourseKnowledgeRelaENS.UpdDate; //修改日期
objCaseCourseKnowledgeRelaENT.UpdUserId = objCaseCourseKnowledgeRelaENS.UpdUserId; //修改用户Id
objCaseCourseKnowledgeRelaENT.Memo = objCaseCourseKnowledgeRelaENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsCaseCourseKnowledgeRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsCaseCourseKnowledgeRelaEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsCaseCourseKnowledgeRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsCaseCourseKnowledgeRelaEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsCaseCourseKnowledgeRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsCaseCourseKnowledgeRelaEN.AttributeName)
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
if (clsCaseCourseKnowledgeRelaWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseCourseKnowledgeRelaWApi没有刷新缓存机制(clsCaseCourseKnowledgeRelaWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_CaseCourseKnowledgeRela");
//if (arrCaseCourseKnowledgeRelaObjLst_Cache == null)
//{
//arrCaseCourseKnowledgeRelaObjLst_Cache = await clsCaseCourseKnowledgeRelaWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsCaseCourseKnowledgeRelaEN._CurrTabName_S);
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
if (clsCaseCourseKnowledgeRelaWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCaseCourseKnowledgeRelaEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsCaseCourseKnowledgeRelaWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCaseCourseKnowledgeRelaEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsCaseCourseKnowledgeRelaEN._CurrTabName_S);
List<clsCaseCourseKnowledgeRelaEN> arrCaseCourseKnowledgeRelaObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrCaseCourseKnowledgeRelaObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsCaseCourseKnowledgeRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conCaseCourseKnowledgeRela.id_CaseCourseKnowledgeRela, Type.GetType("System.Int64"));
objDT.Columns.Add(conCaseCourseKnowledgeRela.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCourseKnowledgeRela.CaseId, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCourseKnowledgeRela.CaseName, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCourseKnowledgeRela.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCourseKnowledgeRela.CourseKnowledgeId, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCourseKnowledgeRela.id_CaseCourseKnowledgeRelaType, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCourseKnowledgeRela.RelationsDegree, Type.GetType("System.Int32"));
objDT.Columns.Add(conCaseCourseKnowledgeRela.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(conCaseCourseKnowledgeRela.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conCaseCourseKnowledgeRela.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCourseKnowledgeRela.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCourseKnowledgeRela.Memo, Type.GetType("System.String"));
foreach (clsCaseCourseKnowledgeRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conCaseCourseKnowledgeRela.id_CaseCourseKnowledgeRela] = objInFor[conCaseCourseKnowledgeRela.id_CaseCourseKnowledgeRela];
objDR[conCaseCourseKnowledgeRela.FuncModuleId] = objInFor[conCaseCourseKnowledgeRela.FuncModuleId];
objDR[conCaseCourseKnowledgeRela.CaseId] = objInFor[conCaseCourseKnowledgeRela.CaseId];
objDR[conCaseCourseKnowledgeRela.CaseName] = objInFor[conCaseCourseKnowledgeRela.CaseName];
objDR[conCaseCourseKnowledgeRela.OwnerId] = objInFor[conCaseCourseKnowledgeRela.OwnerId];
objDR[conCaseCourseKnowledgeRela.CourseKnowledgeId] = objInFor[conCaseCourseKnowledgeRela.CourseKnowledgeId];
objDR[conCaseCourseKnowledgeRela.id_CaseCourseKnowledgeRelaType] = objInFor[conCaseCourseKnowledgeRela.id_CaseCourseKnowledgeRelaType];
objDR[conCaseCourseKnowledgeRela.RelationsDegree] = objInFor[conCaseCourseKnowledgeRela.RelationsDegree];
objDR[conCaseCourseKnowledgeRela.BrowseCount] = objInFor[conCaseCourseKnowledgeRela.BrowseCount];
objDR[conCaseCourseKnowledgeRela.OrderNum] = objInFor[conCaseCourseKnowledgeRela.OrderNum];
objDR[conCaseCourseKnowledgeRela.UpdDate] = objInFor[conCaseCourseKnowledgeRela.UpdDate];
objDR[conCaseCourseKnowledgeRela.UpdUserId] = objInFor[conCaseCourseKnowledgeRela.UpdUserId];
objDR[conCaseCourseKnowledgeRela.Memo] = objInFor[conCaseCourseKnowledgeRela.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 案例知识点关系(CaseCourseKnowledgeRela)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4CaseCourseKnowledgeRela : clsCommFun4BL
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
clsCaseCourseKnowledgeRelaWApi.ReFreshThisCache();
}
}

}