
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCaseExerciseRelaWApi
 表名:CaseExerciseRela(01120437)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:44:53
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
public static class clsCaseExerciseRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseExerciseRelaEN Setid_CaseExerciseRela(this clsCaseExerciseRelaEN objCaseExerciseRelaEN, long lngid_CaseExerciseRela, string strComparisonOp="")
	{
objCaseExerciseRelaEN.id_CaseExerciseRela = lngid_CaseExerciseRela; //案例习题关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseExerciseRelaEN.dicFldComparisonOp.ContainsKey(conCaseExerciseRela.id_CaseExerciseRela) == false)
{
objCaseExerciseRelaEN.dicFldComparisonOp.Add(conCaseExerciseRela.id_CaseExerciseRela, strComparisonOp);
}
else
{
objCaseExerciseRelaEN.dicFldComparisonOp[conCaseExerciseRela.id_CaseExerciseRela] = strComparisonOp;
}
}
return objCaseExerciseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseExerciseRelaEN SetFuncModuleId(this clsCaseExerciseRelaEN objCaseExerciseRelaEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, conCaseExerciseRela.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, conCaseExerciseRela.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, conCaseExerciseRela.FuncModuleId);
objCaseExerciseRelaEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseExerciseRelaEN.dicFldComparisonOp.ContainsKey(conCaseExerciseRela.FuncModuleId) == false)
{
objCaseExerciseRelaEN.dicFldComparisonOp.Add(conCaseExerciseRela.FuncModuleId, strComparisonOp);
}
else
{
objCaseExerciseRelaEN.dicFldComparisonOp[conCaseExerciseRela.FuncModuleId] = strComparisonOp;
}
}
return objCaseExerciseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseExerciseRelaEN SetCaseId(this clsCaseExerciseRelaEN objCaseExerciseRelaEN, string strCaseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseId, conCaseExerciseRela.CaseId);
clsCheckSql.CheckFieldLen(strCaseId, 8, conCaseExerciseRela.CaseId);
clsCheckSql.CheckFieldForeignKey(strCaseId, 8, conCaseExerciseRela.CaseId);
objCaseExerciseRelaEN.CaseId = strCaseId; //案例Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseExerciseRelaEN.dicFldComparisonOp.ContainsKey(conCaseExerciseRela.CaseId) == false)
{
objCaseExerciseRelaEN.dicFldComparisonOp.Add(conCaseExerciseRela.CaseId, strComparisonOp);
}
else
{
objCaseExerciseRelaEN.dicFldComparisonOp[conCaseExerciseRela.CaseId] = strComparisonOp;
}
}
return objCaseExerciseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseExerciseRelaEN SetCaseName(this clsCaseExerciseRelaEN objCaseExerciseRelaEN, string strCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseName, conCaseExerciseRela.CaseName);
clsCheckSql.CheckFieldLen(strCaseName, 100, conCaseExerciseRela.CaseName);
objCaseExerciseRelaEN.CaseName = strCaseName; //案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseExerciseRelaEN.dicFldComparisonOp.ContainsKey(conCaseExerciseRela.CaseName) == false)
{
objCaseExerciseRelaEN.dicFldComparisonOp.Add(conCaseExerciseRela.CaseName, strComparisonOp);
}
else
{
objCaseExerciseRelaEN.dicFldComparisonOp[conCaseExerciseRela.CaseName] = strComparisonOp;
}
}
return objCaseExerciseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseExerciseRelaEN SetOwnerId(this clsCaseExerciseRelaEN objCaseExerciseRelaEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerId, 20, conCaseExerciseRela.OwnerId);
objCaseExerciseRelaEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseExerciseRelaEN.dicFldComparisonOp.ContainsKey(conCaseExerciseRela.OwnerId) == false)
{
objCaseExerciseRelaEN.dicFldComparisonOp.Add(conCaseExerciseRela.OwnerId, strComparisonOp);
}
else
{
objCaseExerciseRelaEN.dicFldComparisonOp[conCaseExerciseRela.OwnerId] = strComparisonOp;
}
}
return objCaseExerciseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseExerciseRelaEN SetCourseExamPaperId(this clsCaseExerciseRelaEN objCaseExerciseRelaEN, string strCourseExamPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseExamPaperId, 8, conCaseExerciseRela.CourseExamPaperId);
clsCheckSql.CheckFieldForeignKey(strCourseExamPaperId, 8, conCaseExerciseRela.CourseExamPaperId);
objCaseExerciseRelaEN.CourseExamPaperId = strCourseExamPaperId; //考卷流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseExerciseRelaEN.dicFldComparisonOp.ContainsKey(conCaseExerciseRela.CourseExamPaperId) == false)
{
objCaseExerciseRelaEN.dicFldComparisonOp.Add(conCaseExerciseRela.CourseExamPaperId, strComparisonOp);
}
else
{
objCaseExerciseRelaEN.dicFldComparisonOp[conCaseExerciseRela.CourseExamPaperId] = strComparisonOp;
}
}
return objCaseExerciseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseExerciseRelaEN SetCourseId(this clsCaseExerciseRelaEN objCaseExerciseRelaEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseId, conCaseExerciseRela.CourseId);
clsCheckSql.CheckFieldLen(strCourseId, 8, conCaseExerciseRela.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, conCaseExerciseRela.CourseId);
objCaseExerciseRelaEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseExerciseRelaEN.dicFldComparisonOp.ContainsKey(conCaseExerciseRela.CourseId) == false)
{
objCaseExerciseRelaEN.dicFldComparisonOp.Add(conCaseExerciseRela.CourseId, strComparisonOp);
}
else
{
objCaseExerciseRelaEN.dicFldComparisonOp[conCaseExerciseRela.CourseId] = strComparisonOp;
}
}
return objCaseExerciseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseExerciseRelaEN SetExamPaperTypeId(this clsCaseExerciseRelaEN objCaseExerciseRelaEN, string strExamPaperTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strExamPaperTypeId, conCaseExerciseRela.ExamPaperTypeId);
clsCheckSql.CheckFieldLen(strExamPaperTypeId, 2, conCaseExerciseRela.ExamPaperTypeId);
clsCheckSql.CheckFieldForeignKey(strExamPaperTypeId, 2, conCaseExerciseRela.ExamPaperTypeId);
objCaseExerciseRelaEN.ExamPaperTypeId = strExamPaperTypeId; //试卷类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseExerciseRelaEN.dicFldComparisonOp.ContainsKey(conCaseExerciseRela.ExamPaperTypeId) == false)
{
objCaseExerciseRelaEN.dicFldComparisonOp.Add(conCaseExerciseRela.ExamPaperTypeId, strComparisonOp);
}
else
{
objCaseExerciseRelaEN.dicFldComparisonOp[conCaseExerciseRela.ExamPaperTypeId] = strComparisonOp;
}
}
return objCaseExerciseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseExerciseRelaEN SetBrowseCount(this clsCaseExerciseRelaEN objCaseExerciseRelaEN, int intBrowseCount, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intBrowseCount, conCaseExerciseRela.BrowseCount);
objCaseExerciseRelaEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseExerciseRelaEN.dicFldComparisonOp.ContainsKey(conCaseExerciseRela.BrowseCount) == false)
{
objCaseExerciseRelaEN.dicFldComparisonOp.Add(conCaseExerciseRela.BrowseCount, strComparisonOp);
}
else
{
objCaseExerciseRelaEN.dicFldComparisonOp[conCaseExerciseRela.BrowseCount] = strComparisonOp;
}
}
return objCaseExerciseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseExerciseRelaEN SetUpdDate(this clsCaseExerciseRelaEN objCaseExerciseRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCaseExerciseRela.UpdDate);
objCaseExerciseRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseExerciseRelaEN.dicFldComparisonOp.ContainsKey(conCaseExerciseRela.UpdDate) == false)
{
objCaseExerciseRelaEN.dicFldComparisonOp.Add(conCaseExerciseRela.UpdDate, strComparisonOp);
}
else
{
objCaseExerciseRelaEN.dicFldComparisonOp[conCaseExerciseRela.UpdDate] = strComparisonOp;
}
}
return objCaseExerciseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseExerciseRelaEN SetUpdUserId(this clsCaseExerciseRelaEN objCaseExerciseRelaEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conCaseExerciseRela.UpdUserId);
objCaseExerciseRelaEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseExerciseRelaEN.dicFldComparisonOp.ContainsKey(conCaseExerciseRela.UpdUserId) == false)
{
objCaseExerciseRelaEN.dicFldComparisonOp.Add(conCaseExerciseRela.UpdUserId, strComparisonOp);
}
else
{
objCaseExerciseRelaEN.dicFldComparisonOp[conCaseExerciseRela.UpdUserId] = strComparisonOp;
}
}
return objCaseExerciseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseExerciseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseExerciseRelaEN SetMemo(this clsCaseExerciseRelaEN objCaseExerciseRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCaseExerciseRela.Memo);
objCaseExerciseRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseExerciseRelaEN.dicFldComparisonOp.ContainsKey(conCaseExerciseRela.Memo) == false)
{
objCaseExerciseRelaEN.dicFldComparisonOp.Add(conCaseExerciseRela.Memo, strComparisonOp);
}
else
{
objCaseExerciseRelaEN.dicFldComparisonOp[conCaseExerciseRela.Memo] = strComparisonOp;
}
}
return objCaseExerciseRelaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCaseExerciseRelaEN objCaseExerciseRela_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCaseExerciseRela_Cond.IsUpdated(conCaseExerciseRela.id_CaseExerciseRela) == true)
{
string strComparisonOp_id_CaseExerciseRela = objCaseExerciseRela_Cond.dicFldComparisonOp[conCaseExerciseRela.id_CaseExerciseRela];
strWhereCond += string.Format(" And {0} {2} {1}", conCaseExerciseRela.id_CaseExerciseRela, objCaseExerciseRela_Cond.id_CaseExerciseRela, strComparisonOp_id_CaseExerciseRela);
}
if (objCaseExerciseRela_Cond.IsUpdated(conCaseExerciseRela.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objCaseExerciseRela_Cond.dicFldComparisonOp[conCaseExerciseRela.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseExerciseRela.FuncModuleId, objCaseExerciseRela_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objCaseExerciseRela_Cond.IsUpdated(conCaseExerciseRela.CaseId) == true)
{
string strComparisonOp_CaseId = objCaseExerciseRela_Cond.dicFldComparisonOp[conCaseExerciseRela.CaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseExerciseRela.CaseId, objCaseExerciseRela_Cond.CaseId, strComparisonOp_CaseId);
}
if (objCaseExerciseRela_Cond.IsUpdated(conCaseExerciseRela.CaseName) == true)
{
string strComparisonOp_CaseName = objCaseExerciseRela_Cond.dicFldComparisonOp[conCaseExerciseRela.CaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseExerciseRela.CaseName, objCaseExerciseRela_Cond.CaseName, strComparisonOp_CaseName);
}
if (objCaseExerciseRela_Cond.IsUpdated(conCaseExerciseRela.OwnerId) == true)
{
string strComparisonOp_OwnerId = objCaseExerciseRela_Cond.dicFldComparisonOp[conCaseExerciseRela.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseExerciseRela.OwnerId, objCaseExerciseRela_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objCaseExerciseRela_Cond.IsUpdated(conCaseExerciseRela.CourseExamPaperId) == true)
{
string strComparisonOp_CourseExamPaperId = objCaseExerciseRela_Cond.dicFldComparisonOp[conCaseExerciseRela.CourseExamPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseExerciseRela.CourseExamPaperId, objCaseExerciseRela_Cond.CourseExamPaperId, strComparisonOp_CourseExamPaperId);
}
if (objCaseExerciseRela_Cond.IsUpdated(conCaseExerciseRela.CourseId) == true)
{
string strComparisonOp_CourseId = objCaseExerciseRela_Cond.dicFldComparisonOp[conCaseExerciseRela.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseExerciseRela.CourseId, objCaseExerciseRela_Cond.CourseId, strComparisonOp_CourseId);
}
if (objCaseExerciseRela_Cond.IsUpdated(conCaseExerciseRela.ExamPaperTypeId) == true)
{
string strComparisonOp_ExamPaperTypeId = objCaseExerciseRela_Cond.dicFldComparisonOp[conCaseExerciseRela.ExamPaperTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseExerciseRela.ExamPaperTypeId, objCaseExerciseRela_Cond.ExamPaperTypeId, strComparisonOp_ExamPaperTypeId);
}
if (objCaseExerciseRela_Cond.IsUpdated(conCaseExerciseRela.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objCaseExerciseRela_Cond.dicFldComparisonOp[conCaseExerciseRela.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conCaseExerciseRela.BrowseCount, objCaseExerciseRela_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objCaseExerciseRela_Cond.IsUpdated(conCaseExerciseRela.UpdDate) == true)
{
string strComparisonOp_UpdDate = objCaseExerciseRela_Cond.dicFldComparisonOp[conCaseExerciseRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseExerciseRela.UpdDate, objCaseExerciseRela_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objCaseExerciseRela_Cond.IsUpdated(conCaseExerciseRela.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objCaseExerciseRela_Cond.dicFldComparisonOp[conCaseExerciseRela.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseExerciseRela.UpdUserId, objCaseExerciseRela_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objCaseExerciseRela_Cond.IsUpdated(conCaseExerciseRela.Memo) == true)
{
string strComparisonOp_Memo = objCaseExerciseRela_Cond.dicFldComparisonOp[conCaseExerciseRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseExerciseRela.Memo, objCaseExerciseRela_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objCaseExerciseRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCaseExerciseRelaEN objCaseExerciseRelaEN)
{
 if (objCaseExerciseRelaEN.id_CaseExerciseRela == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objCaseExerciseRelaEN.sf_UpdFldSetStr = objCaseExerciseRelaEN.getsf_UpdFldSetStr();
clsCaseExerciseRelaWApi.CheckPropertyNew(objCaseExerciseRelaEN); 
bool bolResult = clsCaseExerciseRelaWApi.UpdateRecord(objCaseExerciseRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseExerciseRelaWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--CaseExerciseRela(案例习题关系), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCaseExerciseRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_CaseId_CourseExamPaperId(this clsCaseExerciseRelaEN objCaseExerciseRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCaseExerciseRelaEN == null) return "";
if (objCaseExerciseRelaEN.id_CaseExerciseRela == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CaseId = '{0}'", objCaseExerciseRelaEN.CaseId);
 sbCondition.AppendFormat(" and CourseExamPaperId = '{0}'", objCaseExerciseRelaEN.CourseExamPaperId);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("id_CaseExerciseRela !=  {0}", objCaseExerciseRelaEN.id_CaseExerciseRela);
 sbCondition.AppendFormat(" and CaseId = '{0}'", objCaseExerciseRelaEN.CaseId);
 sbCondition.AppendFormat(" and CourseExamPaperId = '{0}'", objCaseExerciseRelaEN.CourseExamPaperId);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCaseExerciseRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCaseExerciseRelaEN objCaseExerciseRelaEN)
{
try
{
clsCaseExerciseRelaWApi.CheckPropertyNew(objCaseExerciseRelaEN); 
bool bolResult = clsCaseExerciseRelaWApi.AddNewRecord(objCaseExerciseRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseExerciseRelaWApi.ReFreshCache();
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
 /// <param name = "objCaseExerciseRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCaseExerciseRelaEN objCaseExerciseRelaEN, string strWhereCond)
{
try
{
clsCaseExerciseRelaWApi.CheckPropertyNew(objCaseExerciseRelaEN); 
bool bolResult = clsCaseExerciseRelaWApi.UpdateWithCondition(objCaseExerciseRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseExerciseRelaWApi.ReFreshCache();
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
 /// 案例习题关系(CaseExerciseRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsCaseExerciseRelaWApi
{
private static readonly string mstrApiControllerName = "CaseExerciseRelaApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsCaseExerciseRelaWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsCaseExerciseRelaEN objCaseExerciseRelaEN)
{
if (!Object.Equals(null, objCaseExerciseRelaEN.FuncModuleId) && GetStrLen(objCaseExerciseRelaEN.FuncModuleId) > 4)
{
 throw new Exception("字段[功能模块Id]的长度不能超过4!");
}
if (!Object.Equals(null, objCaseExerciseRelaEN.CaseId) && GetStrLen(objCaseExerciseRelaEN.CaseId) > 8)
{
 throw new Exception("字段[案例Id]的长度不能超过8!");
}
if (!Object.Equals(null, objCaseExerciseRelaEN.CaseName) && GetStrLen(objCaseExerciseRelaEN.CaseName) > 100)
{
 throw new Exception("字段[案例名称]的长度不能超过100!");
}
if (!Object.Equals(null, objCaseExerciseRelaEN.OwnerId) && GetStrLen(objCaseExerciseRelaEN.OwnerId) > 20)
{
 throw new Exception("字段[拥有者Id]的长度不能超过20!");
}
if (!Object.Equals(null, objCaseExerciseRelaEN.CourseExamPaperId) && GetStrLen(objCaseExerciseRelaEN.CourseExamPaperId) > 8)
{
 throw new Exception("字段[考卷流水号]的长度不能超过8!");
}
if (!Object.Equals(null, objCaseExerciseRelaEN.CourseId) && GetStrLen(objCaseExerciseRelaEN.CourseId) > 8)
{
 throw new Exception("字段[课程Id]的长度不能超过8!");
}
if (!Object.Equals(null, objCaseExerciseRelaEN.ExamPaperTypeId) && GetStrLen(objCaseExerciseRelaEN.ExamPaperTypeId) > 2)
{
 throw new Exception("字段[试卷类型Id]的长度不能超过2!");
}
if (!Object.Equals(null, objCaseExerciseRelaEN.UpdDate) && GetStrLen(objCaseExerciseRelaEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objCaseExerciseRelaEN.UpdUserId) && GetStrLen(objCaseExerciseRelaEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objCaseExerciseRelaEN.Memo) && GetStrLen(objCaseExerciseRelaEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objCaseExerciseRelaEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_CaseExerciseRela">表关键字</param>
 /// <returns>表对象</returns>
public static clsCaseExerciseRelaEN GetObjByid_CaseExerciseRela(long lngid_CaseExerciseRela)
{
string strAction = "GetObjByid_CaseExerciseRela";
string strErrMsg = string.Empty;
string strResult = "";
clsCaseExerciseRelaEN objCaseExerciseRelaEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CaseExerciseRela"] = lngid_CaseExerciseRela.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objCaseExerciseRelaEN = JsonConvert.DeserializeObject<clsCaseExerciseRelaEN>((string)jobjReturn["ReturnObj"]);
return objCaseExerciseRelaEN;
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
 /// <param name = "lngid_CaseExerciseRela">表关键字</param>
 /// <returns>表对象</returns>
public static clsCaseExerciseRelaEN GetObjByid_CaseExerciseRela_WA_Cache(long lngid_CaseExerciseRela)
{
string strAction = "GetObjByid_CaseExerciseRela_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsCaseExerciseRelaEN objCaseExerciseRelaEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CaseExerciseRela"] = lngid_CaseExerciseRela.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objCaseExerciseRelaEN = JsonConvert.DeserializeObject<clsCaseExerciseRelaEN>((string)jobjReturn["ReturnObj"]);
return objCaseExerciseRelaEN;
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
public static clsCaseExerciseRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsCaseExerciseRelaEN objCaseExerciseRelaEN = null;
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
objCaseExerciseRelaEN = JsonConvert.DeserializeObject<clsCaseExerciseRelaEN>((string)jobjReturn["ReturnObj"]);
return objCaseExerciseRelaEN;
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
 /// <param name = "lngid_CaseExerciseRela">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCaseExerciseRelaEN GetObjByid_CaseExerciseRela_Cache(long lngid_CaseExerciseRela)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsCaseExerciseRelaEN._CurrTabName_S);
List<clsCaseExerciseRelaEN> arrCaseExerciseRelaObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCaseExerciseRelaEN> arrCaseExerciseRelaObjLst_Sel =
from objCaseExerciseRelaEN in arrCaseExerciseRelaObjLst_Cache
where objCaseExerciseRelaEN.id_CaseExerciseRela == lngid_CaseExerciseRela
select objCaseExerciseRelaEN;
if (arrCaseExerciseRelaObjLst_Sel.Count() == 0)
{
   clsCaseExerciseRelaEN obj = clsCaseExerciseRelaWApi.GetObjByid_CaseExerciseRela(lngid_CaseExerciseRela);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrCaseExerciseRelaObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCaseExerciseRelaEN> GetObjLst(string strWhereCond)
{
 List<clsCaseExerciseRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseExerciseRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCaseExerciseRelaEN> GetObjLstById_CaseExerciseRelaLst(List<long> arrId_CaseExerciseRela)
{
 List<clsCaseExerciseRelaEN> arrObjLst = null; 
string strAction = "GetObjLstById_CaseExerciseRelaLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CaseExerciseRela);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseExerciseRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngid_CaseExerciseRela">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsCaseExerciseRelaEN> GetObjLstById_CaseExerciseRelaLst_Cache(List<long> arrId_CaseExerciseRela)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsCaseExerciseRelaEN._CurrTabName_S);
List<clsCaseExerciseRelaEN> arrCaseExerciseRelaObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCaseExerciseRelaEN> arrCaseExerciseRelaObjLst_Sel =
from objCaseExerciseRelaEN in arrCaseExerciseRelaObjLst_Cache
where arrId_CaseExerciseRela.Contains(objCaseExerciseRelaEN.id_CaseExerciseRela)
select objCaseExerciseRelaEN;
return arrCaseExerciseRelaObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCaseExerciseRelaEN> GetObjLstById_CaseExerciseRelaLst_WA_Cache(List<long> arrId_CaseExerciseRela)
{
 List<clsCaseExerciseRelaEN> arrObjLst = null; 
string strAction = "GetObjLstById_CaseExerciseRelaLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CaseExerciseRela);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseExerciseRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCaseExerciseRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsCaseExerciseRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseExerciseRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCaseExerciseRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsCaseExerciseRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseExerciseRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCaseExerciseRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsCaseExerciseRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseExerciseRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCaseExerciseRelaEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsCaseExerciseRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseExerciseRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(long lngid_CaseExerciseRela)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsCaseExerciseRelaEN objCaseExerciseRelaEN = clsCaseExerciseRelaWApi.GetObjByid_CaseExerciseRela(lngid_CaseExerciseRela);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngid_CaseExerciseRela.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsCaseExerciseRelaWApi.ReFreshCache();
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
public static int DelCaseExerciseRelas(List<string> arrid_CaseExerciseRela)
{
string strAction = "DelCaseExerciseRelas";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrid_CaseExerciseRela);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsCaseExerciseRelaWApi.ReFreshCache();
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
public static int DelCaseExerciseRelasByCond(string strWhereCond)
{
string strAction = "DelCaseExerciseRelasByCond";
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
public static bool AddNewRecord(clsCaseExerciseRelaEN objCaseExerciseRelaEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCaseExerciseRelaEN>(objCaseExerciseRelaEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseExerciseRelaWApi.ReFreshCache();
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
 /// <param name = "objCaseExerciseRelaEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsCaseExerciseRelaEN objCaseExerciseRelaEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCaseExerciseRelaEN>(objCaseExerciseRelaEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseExerciseRelaWApi.ReFreshCache();
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
public static bool UpdateRecord(clsCaseExerciseRelaEN objCaseExerciseRelaEN)
{
if (string.IsNullOrEmpty(objCaseExerciseRelaEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCaseExerciseRelaEN.id_CaseExerciseRela, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCaseExerciseRelaEN>(objCaseExerciseRelaEN);
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
 /// <param name = "objCaseExerciseRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsCaseExerciseRelaEN objCaseExerciseRelaEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objCaseExerciseRelaEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCaseExerciseRelaEN.id_CaseExerciseRela, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCaseExerciseRelaEN.id_CaseExerciseRela, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCaseExerciseRelaEN>(objCaseExerciseRelaEN);
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
public static bool IsExist(long lngid_CaseExerciseRela)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CaseExerciseRela"] = lngid_CaseExerciseRela.ToString()
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
 /// <param name = "objCaseExerciseRelaENS">源对象</param>
 /// <param name = "objCaseExerciseRelaENT">目标对象</param>
 public static void CopyTo(clsCaseExerciseRelaEN objCaseExerciseRelaENS, clsCaseExerciseRelaEN objCaseExerciseRelaENT)
{
try
{
objCaseExerciseRelaENT.id_CaseExerciseRela = objCaseExerciseRelaENS.id_CaseExerciseRela; //案例习题关系流水号
objCaseExerciseRelaENT.FuncModuleId = objCaseExerciseRelaENS.FuncModuleId; //功能模块Id
objCaseExerciseRelaENT.CaseId = objCaseExerciseRelaENS.CaseId; //案例Id
objCaseExerciseRelaENT.CaseName = objCaseExerciseRelaENS.CaseName; //案例名称
objCaseExerciseRelaENT.OwnerId = objCaseExerciseRelaENS.OwnerId; //拥有者Id
objCaseExerciseRelaENT.CourseExamPaperId = objCaseExerciseRelaENS.CourseExamPaperId; //考卷流水号
objCaseExerciseRelaENT.CourseId = objCaseExerciseRelaENS.CourseId; //课程Id
objCaseExerciseRelaENT.ExamPaperTypeId = objCaseExerciseRelaENS.ExamPaperTypeId; //试卷类型Id
objCaseExerciseRelaENT.BrowseCount = objCaseExerciseRelaENS.BrowseCount; //浏览次数
objCaseExerciseRelaENT.UpdDate = objCaseExerciseRelaENS.UpdDate; //修改日期
objCaseExerciseRelaENT.UpdUserId = objCaseExerciseRelaENS.UpdUserId; //修改用户Id
objCaseExerciseRelaENT.Memo = objCaseExerciseRelaENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsCaseExerciseRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsCaseExerciseRelaEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsCaseExerciseRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsCaseExerciseRelaEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsCaseExerciseRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsCaseExerciseRelaEN.AttributeName)
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
if (clsCaseExerciseRelaWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseExerciseRelaWApi没有刷新缓存机制(clsCaseExerciseRelaWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_CaseExerciseRela");
//if (arrCaseExerciseRelaObjLst_Cache == null)
//{
//arrCaseExerciseRelaObjLst_Cache = await clsCaseExerciseRelaWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsCaseExerciseRelaEN._CurrTabName_S);
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
if (clsCaseExerciseRelaWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCaseExerciseRelaEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsCaseExerciseRelaWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCaseExerciseRelaEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsCaseExerciseRelaEN._CurrTabName_S);
List<clsCaseExerciseRelaEN> arrCaseExerciseRelaObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrCaseExerciseRelaObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsCaseExerciseRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conCaseExerciseRela.id_CaseExerciseRela, Type.GetType("System.Int64"));
objDT.Columns.Add(conCaseExerciseRela.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(conCaseExerciseRela.CaseId, Type.GetType("System.String"));
objDT.Columns.Add(conCaseExerciseRela.CaseName, Type.GetType("System.String"));
objDT.Columns.Add(conCaseExerciseRela.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(conCaseExerciseRela.CourseExamPaperId, Type.GetType("System.String"));
objDT.Columns.Add(conCaseExerciseRela.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(conCaseExerciseRela.ExamPaperTypeId, Type.GetType("System.String"));
objDT.Columns.Add(conCaseExerciseRela.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(conCaseExerciseRela.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conCaseExerciseRela.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conCaseExerciseRela.Memo, Type.GetType("System.String"));
foreach (clsCaseExerciseRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conCaseExerciseRela.id_CaseExerciseRela] = objInFor[conCaseExerciseRela.id_CaseExerciseRela];
objDR[conCaseExerciseRela.FuncModuleId] = objInFor[conCaseExerciseRela.FuncModuleId];
objDR[conCaseExerciseRela.CaseId] = objInFor[conCaseExerciseRela.CaseId];
objDR[conCaseExerciseRela.CaseName] = objInFor[conCaseExerciseRela.CaseName];
objDR[conCaseExerciseRela.OwnerId] = objInFor[conCaseExerciseRela.OwnerId];
objDR[conCaseExerciseRela.CourseExamPaperId] = objInFor[conCaseExerciseRela.CourseExamPaperId];
objDR[conCaseExerciseRela.CourseId] = objInFor[conCaseExerciseRela.CourseId];
objDR[conCaseExerciseRela.ExamPaperTypeId] = objInFor[conCaseExerciseRela.ExamPaperTypeId];
objDR[conCaseExerciseRela.BrowseCount] = objInFor[conCaseExerciseRela.BrowseCount];
objDR[conCaseExerciseRela.UpdDate] = objInFor[conCaseExerciseRela.UpdDate];
objDR[conCaseExerciseRela.UpdUserId] = objInFor[conCaseExerciseRela.UpdUserId];
objDR[conCaseExerciseRela.Memo] = objInFor[conCaseExerciseRela.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 案例习题关系(CaseExerciseRela)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4CaseExerciseRela : clsCommFun4BL
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
clsCaseExerciseRelaWApi.ReFreshThisCache();
}
}

}