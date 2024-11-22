
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCaseCourseExamRelaWApi
 表名:CaseCourseExamRela(01120122)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:40:44
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
public static class clsCaseCourseExamRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCourseExamRelaEN Setid_CaseCourseExamRela(this clsCaseCourseExamRelaEN objCaseCourseExamRelaEN, long lngid_CaseCourseExamRela, string strComparisonOp="")
	{
objCaseCourseExamRelaEN.id_CaseCourseExamRela = lngid_CaseCourseExamRela; //案例题库关系流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseExamRela.id_CaseCourseExamRela) == false)
{
objCaseCourseExamRelaEN.dicFldComparisonOp.Add(conCaseCourseExamRela.id_CaseCourseExamRela, strComparisonOp);
}
else
{
objCaseCourseExamRelaEN.dicFldComparisonOp[conCaseCourseExamRela.id_CaseCourseExamRela] = strComparisonOp;
}
}
return objCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCourseExamRelaEN SetFuncModuleId(this clsCaseCourseExamRelaEN objCaseCourseExamRelaEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, conCaseCourseExamRela.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, conCaseCourseExamRela.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, conCaseCourseExamRela.FuncModuleId);
objCaseCourseExamRelaEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseExamRela.FuncModuleId) == false)
{
objCaseCourseExamRelaEN.dicFldComparisonOp.Add(conCaseCourseExamRela.FuncModuleId, strComparisonOp);
}
else
{
objCaseCourseExamRelaEN.dicFldComparisonOp[conCaseCourseExamRela.FuncModuleId] = strComparisonOp;
}
}
return objCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCourseExamRelaEN SetCaseId(this clsCaseCourseExamRelaEN objCaseCourseExamRelaEN, string strCaseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseId, conCaseCourseExamRela.CaseId);
clsCheckSql.CheckFieldLen(strCaseId, 8, conCaseCourseExamRela.CaseId);
clsCheckSql.CheckFieldForeignKey(strCaseId, 8, conCaseCourseExamRela.CaseId);
objCaseCourseExamRelaEN.CaseId = strCaseId; //案例Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseExamRela.CaseId) == false)
{
objCaseCourseExamRelaEN.dicFldComparisonOp.Add(conCaseCourseExamRela.CaseId, strComparisonOp);
}
else
{
objCaseCourseExamRelaEN.dicFldComparisonOp[conCaseCourseExamRela.CaseId] = strComparisonOp;
}
}
return objCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCourseExamRelaEN SetCaseName(this clsCaseCourseExamRelaEN objCaseCourseExamRelaEN, string strCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCaseName, conCaseCourseExamRela.CaseName);
clsCheckSql.CheckFieldLen(strCaseName, 100, conCaseCourseExamRela.CaseName);
objCaseCourseExamRelaEN.CaseName = strCaseName; //案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseExamRela.CaseName) == false)
{
objCaseCourseExamRelaEN.dicFldComparisonOp.Add(conCaseCourseExamRela.CaseName, strComparisonOp);
}
else
{
objCaseCourseExamRelaEN.dicFldComparisonOp[conCaseCourseExamRela.CaseName] = strComparisonOp;
}
}
return objCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCourseExamRelaEN SetOwnerId(this clsCaseCourseExamRelaEN objCaseCourseExamRelaEN, string strOwnerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOwnerId, 20, conCaseCourseExamRela.OwnerId);
objCaseCourseExamRelaEN.OwnerId = strOwnerId; //拥有者Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseExamRela.OwnerId) == false)
{
objCaseCourseExamRelaEN.dicFldComparisonOp.Add(conCaseCourseExamRela.OwnerId, strComparisonOp);
}
else
{
objCaseCourseExamRelaEN.dicFldComparisonOp[conCaseCourseExamRela.OwnerId] = strComparisonOp;
}
}
return objCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCourseExamRelaEN SetQuestionID(this clsCaseCourseExamRelaEN objCaseCourseExamRelaEN, string strQuestionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionID, 8, conCaseCourseExamRela.QuestionID);
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, conCaseCourseExamRela.QuestionID);
objCaseCourseExamRelaEN.QuestionID = strQuestionID; //题目ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseExamRela.QuestionID) == false)
{
objCaseCourseExamRelaEN.dicFldComparisonOp.Add(conCaseCourseExamRela.QuestionID, strComparisonOp);
}
else
{
objCaseCourseExamRelaEN.dicFldComparisonOp[conCaseCourseExamRela.QuestionID] = strComparisonOp;
}
}
return objCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCourseExamRelaEN Setid_CaseCourseExamRelaType(this clsCaseCourseExamRelaEN objCaseCourseExamRelaEN, string strid_CaseCourseExamRelaType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_CaseCourseExamRelaType, conCaseCourseExamRela.id_CaseCourseExamRelaType);
clsCheckSql.CheckFieldLen(strid_CaseCourseExamRelaType, 4, conCaseCourseExamRela.id_CaseCourseExamRelaType);
clsCheckSql.CheckFieldForeignKey(strid_CaseCourseExamRelaType, 4, conCaseCourseExamRela.id_CaseCourseExamRelaType);
objCaseCourseExamRelaEN.id_CaseCourseExamRelaType = strid_CaseCourseExamRelaType; //案例题库关系类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseExamRela.id_CaseCourseExamRelaType) == false)
{
objCaseCourseExamRelaEN.dicFldComparisonOp.Add(conCaseCourseExamRela.id_CaseCourseExamRelaType, strComparisonOp);
}
else
{
objCaseCourseExamRelaEN.dicFldComparisonOp[conCaseCourseExamRela.id_CaseCourseExamRelaType] = strComparisonOp;
}
}
return objCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCourseExamRelaEN SetStartTime(this clsCaseCourseExamRelaEN objCaseCourseExamRelaEN, double dblStartTime, string strComparisonOp="")
	{
objCaseCourseExamRelaEN.StartTime = dblStartTime; //开始时间(s)
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseExamRela.StartTime) == false)
{
objCaseCourseExamRelaEN.dicFldComparisonOp.Add(conCaseCourseExamRela.StartTime, strComparisonOp);
}
else
{
objCaseCourseExamRelaEN.dicFldComparisonOp[conCaseCourseExamRela.StartTime] = strComparisonOp;
}
}
return objCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCourseExamRelaEN SetBrowseCount(this clsCaseCourseExamRelaEN objCaseCourseExamRelaEN, int intBrowseCount, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intBrowseCount, conCaseCourseExamRela.BrowseCount);
objCaseCourseExamRelaEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseExamRela.BrowseCount) == false)
{
objCaseCourseExamRelaEN.dicFldComparisonOp.Add(conCaseCourseExamRela.BrowseCount, strComparisonOp);
}
else
{
objCaseCourseExamRelaEN.dicFldComparisonOp[conCaseCourseExamRela.BrowseCount] = strComparisonOp;
}
}
return objCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCourseExamRelaEN SetOrderNum(this clsCaseCourseExamRelaEN objCaseCourseExamRelaEN, int intOrderNum, string strComparisonOp="")
	{
objCaseCourseExamRelaEN.OrderNum = intOrderNum; //序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseExamRela.OrderNum) == false)
{
objCaseCourseExamRelaEN.dicFldComparisonOp.Add(conCaseCourseExamRela.OrderNum, strComparisonOp);
}
else
{
objCaseCourseExamRelaEN.dicFldComparisonOp[conCaseCourseExamRela.OrderNum] = strComparisonOp;
}
}
return objCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCourseExamRelaEN SetUpdDate(this clsCaseCourseExamRelaEN objCaseCourseExamRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, conCaseCourseExamRela.UpdDate);
objCaseCourseExamRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseExamRela.UpdDate) == false)
{
objCaseCourseExamRelaEN.dicFldComparisonOp.Add(conCaseCourseExamRela.UpdDate, strComparisonOp);
}
else
{
objCaseCourseExamRelaEN.dicFldComparisonOp[conCaseCourseExamRela.UpdDate] = strComparisonOp;
}
}
return objCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCourseExamRelaEN SetUpdUserId(this clsCaseCourseExamRelaEN objCaseCourseExamRelaEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, conCaseCourseExamRela.UpdUserId);
objCaseCourseExamRelaEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseExamRela.UpdUserId) == false)
{
objCaseCourseExamRelaEN.dicFldComparisonOp.Add(conCaseCourseExamRela.UpdUserId, strComparisonOp);
}
else
{
objCaseCourseExamRelaEN.dicFldComparisonOp[conCaseCourseExamRela.UpdUserId] = strComparisonOp;
}
}
return objCaseCourseExamRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objCaseCourseExamRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsCaseCourseExamRelaEN SetMemo(this clsCaseCourseExamRelaEN objCaseCourseExamRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, conCaseCourseExamRela.Memo);
objCaseCourseExamRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objCaseCourseExamRelaEN.dicFldComparisonOp.ContainsKey(conCaseCourseExamRela.Memo) == false)
{
objCaseCourseExamRelaEN.dicFldComparisonOp.Add(conCaseCourseExamRela.Memo, strComparisonOp);
}
else
{
objCaseCourseExamRelaEN.dicFldComparisonOp[conCaseCourseExamRela.Memo] = strComparisonOp;
}
}
return objCaseCourseExamRelaEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsCaseCourseExamRelaEN objCaseCourseExamRela_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objCaseCourseExamRela_Cond.IsUpdated(conCaseCourseExamRela.id_CaseCourseExamRela) == true)
{
string strComparisonOp_id_CaseCourseExamRela = objCaseCourseExamRela_Cond.dicFldComparisonOp[conCaseCourseExamRela.id_CaseCourseExamRela];
strWhereCond += string.Format(" And {0} {2} {1}", conCaseCourseExamRela.id_CaseCourseExamRela, objCaseCourseExamRela_Cond.id_CaseCourseExamRela, strComparisonOp_id_CaseCourseExamRela);
}
if (objCaseCourseExamRela_Cond.IsUpdated(conCaseCourseExamRela.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objCaseCourseExamRela_Cond.dicFldComparisonOp[conCaseCourseExamRela.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCourseExamRela.FuncModuleId, objCaseCourseExamRela_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objCaseCourseExamRela_Cond.IsUpdated(conCaseCourseExamRela.CaseId) == true)
{
string strComparisonOp_CaseId = objCaseCourseExamRela_Cond.dicFldComparisonOp[conCaseCourseExamRela.CaseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCourseExamRela.CaseId, objCaseCourseExamRela_Cond.CaseId, strComparisonOp_CaseId);
}
if (objCaseCourseExamRela_Cond.IsUpdated(conCaseCourseExamRela.CaseName) == true)
{
string strComparisonOp_CaseName = objCaseCourseExamRela_Cond.dicFldComparisonOp[conCaseCourseExamRela.CaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCourseExamRela.CaseName, objCaseCourseExamRela_Cond.CaseName, strComparisonOp_CaseName);
}
if (objCaseCourseExamRela_Cond.IsUpdated(conCaseCourseExamRela.OwnerId) == true)
{
string strComparisonOp_OwnerId = objCaseCourseExamRela_Cond.dicFldComparisonOp[conCaseCourseExamRela.OwnerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCourseExamRela.OwnerId, objCaseCourseExamRela_Cond.OwnerId, strComparisonOp_OwnerId);
}
if (objCaseCourseExamRela_Cond.IsUpdated(conCaseCourseExamRela.QuestionID) == true)
{
string strComparisonOp_QuestionID = objCaseCourseExamRela_Cond.dicFldComparisonOp[conCaseCourseExamRela.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCourseExamRela.QuestionID, objCaseCourseExamRela_Cond.QuestionID, strComparisonOp_QuestionID);
}
if (objCaseCourseExamRela_Cond.IsUpdated(conCaseCourseExamRela.id_CaseCourseExamRelaType) == true)
{
string strComparisonOp_id_CaseCourseExamRelaType = objCaseCourseExamRela_Cond.dicFldComparisonOp[conCaseCourseExamRela.id_CaseCourseExamRelaType];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCourseExamRela.id_CaseCourseExamRelaType, objCaseCourseExamRela_Cond.id_CaseCourseExamRelaType, strComparisonOp_id_CaseCourseExamRelaType);
}
if (objCaseCourseExamRela_Cond.IsUpdated(conCaseCourseExamRela.StartTime) == true)
{
string strComparisonOp_StartTime = objCaseCourseExamRela_Cond.dicFldComparisonOp[conCaseCourseExamRela.StartTime];
strWhereCond += string.Format(" And {0} {2} {1}", conCaseCourseExamRela.StartTime, objCaseCourseExamRela_Cond.StartTime, strComparisonOp_StartTime);
}
if (objCaseCourseExamRela_Cond.IsUpdated(conCaseCourseExamRela.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objCaseCourseExamRela_Cond.dicFldComparisonOp[conCaseCourseExamRela.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", conCaseCourseExamRela.BrowseCount, objCaseCourseExamRela_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objCaseCourseExamRela_Cond.IsUpdated(conCaseCourseExamRela.OrderNum) == true)
{
string strComparisonOp_OrderNum = objCaseCourseExamRela_Cond.dicFldComparisonOp[conCaseCourseExamRela.OrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", conCaseCourseExamRela.OrderNum, objCaseCourseExamRela_Cond.OrderNum, strComparisonOp_OrderNum);
}
if (objCaseCourseExamRela_Cond.IsUpdated(conCaseCourseExamRela.UpdDate) == true)
{
string strComparisonOp_UpdDate = objCaseCourseExamRela_Cond.dicFldComparisonOp[conCaseCourseExamRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCourseExamRela.UpdDate, objCaseCourseExamRela_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objCaseCourseExamRela_Cond.IsUpdated(conCaseCourseExamRela.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objCaseCourseExamRela_Cond.dicFldComparisonOp[conCaseCourseExamRela.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCourseExamRela.UpdUserId, objCaseCourseExamRela_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objCaseCourseExamRela_Cond.IsUpdated(conCaseCourseExamRela.Memo) == true)
{
string strComparisonOp_Memo = objCaseCourseExamRela_Cond.dicFldComparisonOp[conCaseCourseExamRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", conCaseCourseExamRela.Memo, objCaseCourseExamRela_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}

 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_Update)
 /// </summary>
 /// <param name = "objCaseCourseExamRelaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool Update(this clsCaseCourseExamRelaEN objCaseCourseExamRelaEN)
{
 if (objCaseCourseExamRelaEN.id_CaseCourseExamRela == 0)
 {
string strMsg = string.Format("(errid:Watl000003)修改记录时关键字不能为空!(from {0})\r\n",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
 }
try
{
objCaseCourseExamRelaEN.sf_UpdFldSetStr = objCaseCourseExamRelaEN.getsf_UpdFldSetStr();
clsCaseCourseExamRelaWApi.CheckPropertyNew(objCaseCourseExamRelaEN); 
bool bolResult = clsCaseCourseExamRelaWApi.UpdateRecord(objCaseCourseExamRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCourseExamRelaWApi.ReFreshCache();
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
 /// 检查唯一性(Uniqueness)--CaseCourseExamRela(案例题库关系), 如果不唯一,即存在相同的记录,就返回False
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_GetConditionString4Constraint)
 /// </summary>
 /// <param name = "objCaseCourseExamRelaEN">要求唯一的对象</param>
 /// <returns></returns>
public static string GetUniConditionStr_CaseId_QuestionID(this clsCaseCourseExamRelaEN objCaseCourseExamRelaEN)
{
//检测记录是否存在
StringBuilder sbCondition = new StringBuilder();
if (objCaseCourseExamRelaEN == null) return "";
if (objCaseCourseExamRelaEN.id_CaseCourseExamRela == 0)
{
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CaseId = '{0}'", objCaseCourseExamRelaEN.CaseId);
 sbCondition.AppendFormat(" and QuestionID = '{0}'", objCaseCourseExamRelaEN.QuestionID);
return sbCondition.ToString();
}
 else {
sbCondition.AppendFormat("id_CaseCourseExamRela !=  {0}", objCaseCourseExamRelaEN.id_CaseCourseExamRela);
 sbCondition.AppendFormat(" and CaseId = '{0}'", objCaseCourseExamRelaEN.CaseId);
 sbCondition.AppendFormat(" and QuestionID = '{0}'", objCaseCourseExamRelaEN.QuestionID);
 return sbCondition.ToString();
}
}

 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_AddNewRecord)
 /// </summary>
 /// <param name = "objCaseCourseExamRelaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public static bool AddNewRecord(this clsCaseCourseExamRelaEN objCaseCourseExamRelaEN)
{
try
{
clsCaseCourseExamRelaWApi.CheckPropertyNew(objCaseCourseExamRelaEN); 
bool bolResult = clsCaseCourseExamRelaWApi.AddNewRecord(objCaseCourseExamRelaEN);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCourseExamRelaWApi.ReFreshCache();
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
 /// <param name = "objCaseCourseExamRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public static bool UpdateWithCondition(this clsCaseCourseExamRelaEN objCaseCourseExamRelaEN, string strWhereCond)
{
try
{
clsCaseCourseExamRelaWApi.CheckPropertyNew(objCaseCourseExamRelaEN); 
bool bolResult = clsCaseCourseExamRelaWApi.UpdateWithCondition(objCaseCourseExamRelaEN, strWhereCond);
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCourseExamRelaWApi.ReFreshCache();
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
 /// 案例题库关系(CaseCourseExamRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsCaseCourseExamRelaWApi
{
private static readonly string mstrApiControllerName = "CaseCourseExamRelaApi";

 /// <summary>
/// 专门在逻辑层用于处理缓存等公共函数的对象
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DefineObjCommFun4BL)
/// </summary>
public static clsCommFun4BL objCommFun4BL = null;

 public clsCaseCourseExamRelaWApi()
 {
 }

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_CheckPropertyNew)
 /// </summary>
public static void CheckPropertyNew(clsCaseCourseExamRelaEN objCaseCourseExamRelaEN)
{
if (!Object.Equals(null, objCaseCourseExamRelaEN.FuncModuleId) && GetStrLen(objCaseCourseExamRelaEN.FuncModuleId) > 4)
{
 throw new Exception("字段[功能模块Id]的长度不能超过4!");
}
if (!Object.Equals(null, objCaseCourseExamRelaEN.CaseId) && GetStrLen(objCaseCourseExamRelaEN.CaseId) > 8)
{
 throw new Exception("字段[案例Id]的长度不能超过8!");
}
if (!Object.Equals(null, objCaseCourseExamRelaEN.CaseName) && GetStrLen(objCaseCourseExamRelaEN.CaseName) > 100)
{
 throw new Exception("字段[案例名称]的长度不能超过100!");
}
if (!Object.Equals(null, objCaseCourseExamRelaEN.OwnerId) && GetStrLen(objCaseCourseExamRelaEN.OwnerId) > 20)
{
 throw new Exception("字段[拥有者Id]的长度不能超过20!");
}
if (!Object.Equals(null, objCaseCourseExamRelaEN.QuestionID) && GetStrLen(objCaseCourseExamRelaEN.QuestionID) > 8)
{
 throw new Exception("字段[题目ID]的长度不能超过8!");
}
if (!Object.Equals(null, objCaseCourseExamRelaEN.id_CaseCourseExamRelaType) && GetStrLen(objCaseCourseExamRelaEN.id_CaseCourseExamRelaType) > 4)
{
 throw new Exception("字段[案例题库关系类型流水号]的长度不能超过4!");
}
if (!Object.Equals(null, objCaseCourseExamRelaEN.UpdDate) && GetStrLen(objCaseCourseExamRelaEN.UpdDate) > 20)
{
 throw new Exception("字段[修改日期]的长度不能超过20!");
}
if (!Object.Equals(null, objCaseCourseExamRelaEN.UpdUserId) && GetStrLen(objCaseCourseExamRelaEN.UpdUserId) > 20)
{
 throw new Exception("字段[修改用户Id]的长度不能超过20!");
}
if (!Object.Equals(null, objCaseCourseExamRelaEN.Memo) && GetStrLen(objCaseCourseExamRelaEN.Memo) > 1000)
{
 throw new Exception("字段[备注]的长度不能超过1000!");
}
 objCaseCourseExamRelaEN._IsCheckProperty = true;
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_CaseCourseExamRela">表关键字</param>
 /// <returns>表对象</returns>
public static clsCaseCourseExamRelaEN GetObjByid_CaseCourseExamRela(long lngid_CaseCourseExamRela)
{
string strAction = "GetObjByid_CaseCourseExamRela";
string strErrMsg = string.Empty;
string strResult = "";
clsCaseCourseExamRelaEN objCaseCourseExamRelaEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CaseCourseExamRela"] = lngid_CaseCourseExamRela.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objCaseCourseExamRelaEN = JsonConvert.DeserializeObject<clsCaseCourseExamRelaEN>((string)jobjReturn["ReturnObj"]);
return objCaseCourseExamRelaEN;
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
 /// <param name = "lngid_CaseCourseExamRela">表关键字</param>
 /// <returns>表对象</returns>
public static clsCaseCourseExamRelaEN GetObjByid_CaseCourseExamRela_WA_Cache(long lngid_CaseCourseExamRela)
{
string strAction = "GetObjByid_CaseCourseExamRela_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsCaseCourseExamRelaEN objCaseCourseExamRelaEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CaseCourseExamRela"] = lngid_CaseCourseExamRela.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objCaseCourseExamRelaEN = JsonConvert.DeserializeObject<clsCaseCourseExamRelaEN>((string)jobjReturn["ReturnObj"]);
return objCaseCourseExamRelaEN;
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
public static clsCaseCourseExamRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsCaseCourseExamRelaEN objCaseCourseExamRelaEN = null;
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
objCaseCourseExamRelaEN = JsonConvert.DeserializeObject<clsCaseCourseExamRelaEN>((string)jobjReturn["ReturnObj"]);
return objCaseCourseExamRelaEN;
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
 /// <param name = "lngid_CaseCourseExamRela">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsCaseCourseExamRelaEN GetObjByid_CaseCourseExamRela_Cache(long lngid_CaseCourseExamRela)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsCaseCourseExamRelaEN._CurrTabName_S);
List<clsCaseCourseExamRelaEN> arrCaseCourseExamRelaObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCaseCourseExamRelaEN> arrCaseCourseExamRelaObjLst_Sel =
from objCaseCourseExamRelaEN in arrCaseCourseExamRelaObjLst_Cache
where objCaseCourseExamRelaEN.id_CaseCourseExamRela == lngid_CaseCourseExamRela
select objCaseCourseExamRelaEN;
if (arrCaseCourseExamRelaObjLst_Sel.Count() == 0)
{
   clsCaseCourseExamRelaEN obj = clsCaseCourseExamRelaWApi.GetObjByid_CaseCourseExamRela(lngid_CaseCourseExamRela);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrCaseCourseExamRelaObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCaseCourseExamRelaEN> GetObjLst(string strWhereCond)
{
 List<clsCaseCourseExamRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseCourseExamRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCaseCourseExamRelaEN> GetObjLstById_CaseCourseExamRelaLst(List<long> arrId_CaseCourseExamRela)
{
 List<clsCaseCourseExamRelaEN> arrObjLst = null; 
string strAction = "GetObjLstById_CaseCourseExamRelaLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CaseCourseExamRela);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseCourseExamRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngid_CaseCourseExamRela">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsCaseCourseExamRelaEN> GetObjLstById_CaseCourseExamRelaLst_Cache(List<long> arrId_CaseCourseExamRela)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsCaseCourseExamRelaEN._CurrTabName_S);
List<clsCaseCourseExamRelaEN> arrCaseCourseExamRelaObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsCaseCourseExamRelaEN> arrCaseCourseExamRelaObjLst_Sel =
from objCaseCourseExamRelaEN in arrCaseCourseExamRelaObjLst_Cache
where arrId_CaseCourseExamRela.Contains(objCaseCourseExamRelaEN.id_CaseCourseExamRela)
select objCaseCourseExamRelaEN;
return arrCaseCourseExamRelaObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsCaseCourseExamRelaEN> GetObjLstById_CaseCourseExamRelaLst_WA_Cache(List<long> arrId_CaseCourseExamRela)
{
 List<clsCaseCourseExamRelaEN> arrObjLst = null; 
string strAction = "GetObjLstById_CaseCourseExamRelaLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CaseCourseExamRela);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseCourseExamRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCaseCourseExamRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsCaseCourseExamRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseCourseExamRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCaseCourseExamRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsCaseCourseExamRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseCourseExamRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCaseCourseExamRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsCaseCourseExamRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseCourseExamRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsCaseCourseExamRelaEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsCaseCourseExamRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsCaseCourseExamRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static int DelRecord(long lngid_CaseCourseExamRela)
{
string strAction = "DelRecord";
string strErrMsg = string.Empty;
string strResult = "";
try
{
 clsCaseCourseExamRelaEN objCaseCourseExamRelaEN = clsCaseCourseExamRelaWApi.GetObjByid_CaseCourseExamRela(lngid_CaseCourseExamRela);
if (clsPubFun4WApi.Delete(mstrApiControllerName, strAction, lngid_CaseCourseExamRela.ToString(), out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsCaseCourseExamRelaWApi.ReFreshCache();
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
public static int DelCaseCourseExamRelas(List<string> arrid_CaseCourseExamRela)
{
string strAction = "DelCaseCourseExamRelas";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrid_CaseCourseExamRela);
if (clsPubFun4WApi.Deletes(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
clsCaseCourseExamRelaWApi.ReFreshCache();
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
public static int DelCaseCourseExamRelasByCond(string strWhereCond)
{
string strAction = "DelCaseCourseExamRelasByCond";
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
public static bool AddNewRecord(clsCaseCourseExamRelaEN objCaseCourseExamRelaEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCaseCourseExamRelaEN>(objCaseCourseExamRelaEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCourseExamRelaWApi.ReFreshCache();
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
 /// <param name = "objCaseCourseExamRelaEN">需要添加的表对象</param>
 /// <returns>返回新添加记录的关键字</returns>
public static string AddNewRecordWithReturnKey(clsCaseCourseExamRelaEN objCaseCourseExamRelaEN)
{
string strAction = "AddNewRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCaseCourseExamRelaEN>(objCaseCourseExamRelaEN);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJson, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
clsCaseCourseExamRelaWApi.ReFreshCache();
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
public static bool UpdateRecord(clsCaseCourseExamRelaEN objCaseCourseExamRelaEN)
{
if (string.IsNullOrEmpty(objCaseCourseExamRelaEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCaseCourseExamRelaEN.id_CaseCourseExamRela, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateRecord";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCaseCourseExamRelaEN>(objCaseCourseExamRelaEN);
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
 /// <param name = "objCaseCourseExamRelaEN">需要修改的对象</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static bool UpdateWithCondition(clsCaseCourseExamRelaEN objCaseCourseExamRelaEN, string strWhereCond)
{
if (string.IsNullOrEmpty(objCaseCourseExamRelaEN.sf_UpdFldSetStr) == true)
{
string strMsg = string.Format("修改时，修改标志串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCaseCourseExamRelaEN.id_CaseCourseExamRela, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (string.IsNullOrEmpty(strWhereCond) == true)
{
string strMsg = string.Format("按条件修改时，条件串为空，请联系管理员.对象关键字:{0}.(from {1}).",
objCaseCourseExamRelaEN.id_CaseCourseExamRela, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
string strAction = "UpdateWithCondition";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJson = clsJSON.GetJsonFromObj<clsCaseCourseExamRelaEN>(objCaseCourseExamRelaEN);
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
public static bool IsExist(long lngid_CaseCourseExamRela)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CaseCourseExamRela"] = lngid_CaseCourseExamRela.ToString()
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
 /// <param name = "objCaseCourseExamRelaENS">源对象</param>
 /// <param name = "objCaseCourseExamRelaENT">目标对象</param>
 public static void CopyTo(clsCaseCourseExamRelaEN objCaseCourseExamRelaENS, clsCaseCourseExamRelaEN objCaseCourseExamRelaENT)
{
try
{
objCaseCourseExamRelaENT.id_CaseCourseExamRela = objCaseCourseExamRelaENS.id_CaseCourseExamRela; //案例题库关系流水号
objCaseCourseExamRelaENT.FuncModuleId = objCaseCourseExamRelaENS.FuncModuleId; //功能模块Id
objCaseCourseExamRelaENT.CaseId = objCaseCourseExamRelaENS.CaseId; //案例Id
objCaseCourseExamRelaENT.CaseName = objCaseCourseExamRelaENS.CaseName; //案例名称
objCaseCourseExamRelaENT.OwnerId = objCaseCourseExamRelaENS.OwnerId; //拥有者Id
objCaseCourseExamRelaENT.QuestionID = objCaseCourseExamRelaENS.QuestionID; //题目ID
objCaseCourseExamRelaENT.id_CaseCourseExamRelaType = objCaseCourseExamRelaENS.id_CaseCourseExamRelaType; //案例题库关系类型流水号
objCaseCourseExamRelaENT.StartTime = objCaseCourseExamRelaENS.StartTime; //开始时间(s)
objCaseCourseExamRelaENT.BrowseCount = objCaseCourseExamRelaENS.BrowseCount; //浏览次数
objCaseCourseExamRelaENT.OrderNum = objCaseCourseExamRelaENS.OrderNum; //序号
objCaseCourseExamRelaENT.UpdDate = objCaseCourseExamRelaENS.UpdDate; //修改日期
objCaseCourseExamRelaENT.UpdUserId = objCaseCourseExamRelaENS.UpdUserId; //修改用户Id
objCaseCourseExamRelaENT.Memo = objCaseCourseExamRelaENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsCaseCourseExamRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsCaseCourseExamRelaEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsCaseCourseExamRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsCaseCourseExamRelaEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsCaseCourseExamRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsCaseCourseExamRelaEN.AttributeName)
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
if (clsCaseCourseExamRelaWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseCourseExamRelaWApi没有刷新缓存机制(clsCaseCourseExamRelaWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_CaseCourseExamRela");
//if (arrCaseCourseExamRelaObjLst_Cache == null)
//{
//arrCaseCourseExamRelaObjLst_Cache = await clsCaseCourseExamRelaWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsCaseCourseExamRelaEN._CurrTabName_S);
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
if (clsCaseCourseExamRelaWApi.objCommFun4BL != null) 
{
// 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
string strKey = string.Format("{0}", clsCaseCourseExamRelaEN._CurrTabName_S);
CacheHelper.Remove(strKey);
clsCaseCourseExamRelaWApi.objCommFun4BL.ReFreshCache();
}
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst_Cache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsCaseCourseExamRelaEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsCaseCourseExamRelaEN._CurrTabName_S);
List<clsCaseCourseExamRelaEN> arrCaseCourseExamRelaObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrCaseCourseExamRelaObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsCaseCourseExamRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(conCaseCourseExamRela.id_CaseCourseExamRela, Type.GetType("System.Int64"));
objDT.Columns.Add(conCaseCourseExamRela.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCourseExamRela.CaseId, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCourseExamRela.CaseName, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCourseExamRela.OwnerId, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCourseExamRela.QuestionID, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCourseExamRela.id_CaseCourseExamRelaType, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCourseExamRela.StartTime, Type.GetType("System.Decimal"));
objDT.Columns.Add(conCaseCourseExamRela.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(conCaseCourseExamRela.OrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(conCaseCourseExamRela.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCourseExamRela.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(conCaseCourseExamRela.Memo, Type.GetType("System.String"));
foreach (clsCaseCourseExamRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[conCaseCourseExamRela.id_CaseCourseExamRela] = objInFor[conCaseCourseExamRela.id_CaseCourseExamRela];
objDR[conCaseCourseExamRela.FuncModuleId] = objInFor[conCaseCourseExamRela.FuncModuleId];
objDR[conCaseCourseExamRela.CaseId] = objInFor[conCaseCourseExamRela.CaseId];
objDR[conCaseCourseExamRela.CaseName] = objInFor[conCaseCourseExamRela.CaseName];
objDR[conCaseCourseExamRela.OwnerId] = objInFor[conCaseCourseExamRela.OwnerId];
objDR[conCaseCourseExamRela.QuestionID] = objInFor[conCaseCourseExamRela.QuestionID];
objDR[conCaseCourseExamRela.id_CaseCourseExamRelaType] = objInFor[conCaseCourseExamRela.id_CaseCourseExamRelaType];
objDR[conCaseCourseExamRela.StartTime] = objInFor[conCaseCourseExamRela.StartTime];
objDR[conCaseCourseExamRela.BrowseCount] = objInFor[conCaseCourseExamRela.BrowseCount];
objDR[conCaseCourseExamRela.OrderNum] = objInFor[conCaseCourseExamRela.OrderNum];
objDR[conCaseCourseExamRela.UpdDate] = objInFor[conCaseCourseExamRela.UpdDate];
objDR[conCaseCourseExamRela.UpdUserId] = objInFor[conCaseCourseExamRela.UpdUserId];
objDR[conCaseCourseExamRela.Memo] = objInFor[conCaseCourseExamRela.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
 /// <summary>
 /// 案例题库关系(CaseCourseExamRela)
 /// 数据源类型:SQL表
 /// (AutoGCLib.CommFun4WA4CSharp:GeneCode_This)
 /// </summary>
public class clsCommFun4WA4CaseCourseExamRela : clsCommFun4BL
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
clsCaseCourseExamRelaWApi.ReFreshThisCache();
}
}

}