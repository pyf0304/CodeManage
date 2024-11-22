
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionReferWApi
 表名:vQuestionRefer(01120342)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:41:41
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:问卷维护
 模块英文名:QuestionaireEdit
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
public static class clsvQuestionReferWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionReferEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionReferEN SetmId(this clsvQuestionReferEN objvQuestionReferEN, long lngmId, string strComparisonOp="")
	{
objvQuestionReferEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionReferEN.dicFldComparisonOp.ContainsKey(convQuestionRefer.mId) == false)
{
objvQuestionReferEN.dicFldComparisonOp.Add(convQuestionRefer.mId, strComparisonOp);
}
else
{
objvQuestionReferEN.dicFldComparisonOp[convQuestionRefer.mId] = strComparisonOp;
}
}
return objvQuestionReferEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionReferEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionReferEN SetQuestionID(this clsvQuestionReferEN objvQuestionReferEN, string strQuestionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionID, 8, convQuestionRefer.QuestionID);
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, convQuestionRefer.QuestionID);
objvQuestionReferEN.QuestionID = strQuestionID; //题目ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionReferEN.dicFldComparisonOp.ContainsKey(convQuestionRefer.QuestionID) == false)
{
objvQuestionReferEN.dicFldComparisonOp.Add(convQuestionRefer.QuestionID, strComparisonOp);
}
else
{
objvQuestionReferEN.dicFldComparisonOp[convQuestionRefer.QuestionID] = strComparisonOp;
}
}
return objvQuestionReferEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionReferEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionReferEN SetQuestionName(this clsvQuestionReferEN objvQuestionReferEN, string strQuestionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionName, 1000, convQuestionRefer.QuestionName);
objvQuestionReferEN.QuestionName = strQuestionName; //题目名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionReferEN.dicFldComparisonOp.ContainsKey(convQuestionRefer.QuestionName) == false)
{
objvQuestionReferEN.dicFldComparisonOp.Add(convQuestionRefer.QuestionName, strComparisonOp);
}
else
{
objvQuestionReferEN.dicFldComparisonOp[convQuestionRefer.QuestionName] = strComparisonOp;
}
}
return objvQuestionReferEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionReferEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionReferEN SetCourseId(this clsvQuestionReferEN objvQuestionReferEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convQuestionRefer.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convQuestionRefer.CourseId);
objvQuestionReferEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionReferEN.dicFldComparisonOp.ContainsKey(convQuestionRefer.CourseId) == false)
{
objvQuestionReferEN.dicFldComparisonOp.Add(convQuestionRefer.CourseId, strComparisonOp);
}
else
{
objvQuestionReferEN.dicFldComparisonOp[convQuestionRefer.CourseId] = strComparisonOp;
}
}
return objvQuestionReferEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionReferEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionReferEN SetCourseName(this clsvQuestionReferEN objvQuestionReferEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convQuestionRefer.CourseName);
objvQuestionReferEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionReferEN.dicFldComparisonOp.ContainsKey(convQuestionRefer.CourseName) == false)
{
objvQuestionReferEN.dicFldComparisonOp.Add(convQuestionRefer.CourseName, strComparisonOp);
}
else
{
objvQuestionReferEN.dicFldComparisonOp[convQuestionRefer.CourseName] = strComparisonOp;
}
}
return objvQuestionReferEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionReferEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionReferEN SetFuncModuleId(this clsvQuestionReferEN objvQuestionReferEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convQuestionRefer.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convQuestionRefer.FuncModuleId);
objvQuestionReferEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionReferEN.dicFldComparisonOp.ContainsKey(convQuestionRefer.FuncModuleId) == false)
{
objvQuestionReferEN.dicFldComparisonOp.Add(convQuestionRefer.FuncModuleId, strComparisonOp);
}
else
{
objvQuestionReferEN.dicFldComparisonOp[convQuestionRefer.FuncModuleId] = strComparisonOp;
}
}
return objvQuestionReferEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionReferEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionReferEN SetFuncModuleName(this clsvQuestionReferEN objvQuestionReferEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convQuestionRefer.FuncModuleName);
objvQuestionReferEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionReferEN.dicFldComparisonOp.ContainsKey(convQuestionRefer.FuncModuleName) == false)
{
objvQuestionReferEN.dicFldComparisonOp.Add(convQuestionRefer.FuncModuleName, strComparisonOp);
}
else
{
objvQuestionReferEN.dicFldComparisonOp[convQuestionRefer.FuncModuleName] = strComparisonOp;
}
}
return objvQuestionReferEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionReferEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionReferEN SetFuncModuleName_Sim(this clsvQuestionReferEN objvQuestionReferEN, string strFuncModuleName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName_Sim, 30, convQuestionRefer.FuncModuleName_Sim);
objvQuestionReferEN.FuncModuleName_Sim = strFuncModuleName_Sim; //功能模块简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionReferEN.dicFldComparisonOp.ContainsKey(convQuestionRefer.FuncModuleName_Sim) == false)
{
objvQuestionReferEN.dicFldComparisonOp.Add(convQuestionRefer.FuncModuleName_Sim, strComparisonOp);
}
else
{
objvQuestionReferEN.dicFldComparisonOp[convQuestionRefer.FuncModuleName_Sim] = strComparisonOp;
}
}
return objvQuestionReferEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionReferEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionReferEN SetTableName(this clsvQuestionReferEN objvQuestionReferEN, string strTableName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTableName, 100, convQuestionRefer.TableName);
objvQuestionReferEN.TableName = strTableName; //主表表名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionReferEN.dicFldComparisonOp.ContainsKey(convQuestionRefer.TableName) == false)
{
objvQuestionReferEN.dicFldComparisonOp.Add(convQuestionRefer.TableName, strComparisonOp);
}
else
{
objvQuestionReferEN.dicFldComparisonOp[convQuestionRefer.TableName] = strComparisonOp;
}
}
return objvQuestionReferEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionReferEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionReferEN SetKeyIdValue(this clsvQuestionReferEN objvQuestionReferEN, string strKeyIdValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strKeyIdValue, 50, convQuestionRefer.KeyIdValue);
objvQuestionReferEN.KeyIdValue = strKeyIdValue; //关键字值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionReferEN.dicFldComparisonOp.ContainsKey(convQuestionRefer.KeyIdValue) == false)
{
objvQuestionReferEN.dicFldComparisonOp.Add(convQuestionRefer.KeyIdValue, strComparisonOp);
}
else
{
objvQuestionReferEN.dicFldComparisonOp[convQuestionRefer.KeyIdValue] = strComparisonOp;
}
}
return objvQuestionReferEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionReferEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionReferEN SetCaseName(this clsvQuestionReferEN objvQuestionReferEN, string strCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCaseName, 100, convQuestionRefer.CaseName);
objvQuestionReferEN.CaseName = strCaseName; //案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionReferEN.dicFldComparisonOp.ContainsKey(convQuestionRefer.CaseName) == false)
{
objvQuestionReferEN.dicFldComparisonOp.Add(convQuestionRefer.CaseName, strComparisonOp);
}
else
{
objvQuestionReferEN.dicFldComparisonOp[convQuestionRefer.CaseName] = strComparisonOp;
}
}
return objvQuestionReferEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionReferEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionReferEN SetIsShow(this clsvQuestionReferEN objvQuestionReferEN, bool bolIsShow, string strComparisonOp="")
	{
objvQuestionReferEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionReferEN.dicFldComparisonOp.ContainsKey(convQuestionRefer.IsShow) == false)
{
objvQuestionReferEN.dicFldComparisonOp.Add(convQuestionRefer.IsShow, strComparisonOp);
}
else
{
objvQuestionReferEN.dicFldComparisonOp[convQuestionRefer.IsShow] = strComparisonOp;
}
}
return objvQuestionReferEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionReferEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionReferEN SetUpdDate(this clsvQuestionReferEN objvQuestionReferEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convQuestionRefer.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQuestionRefer.UpdDate);
objvQuestionReferEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionReferEN.dicFldComparisonOp.ContainsKey(convQuestionRefer.UpdDate) == false)
{
objvQuestionReferEN.dicFldComparisonOp.Add(convQuestionRefer.UpdDate, strComparisonOp);
}
else
{
objvQuestionReferEN.dicFldComparisonOp[convQuestionRefer.UpdDate] = strComparisonOp;
}
}
return objvQuestionReferEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionReferEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionReferEN SetUpdUser(this clsvQuestionReferEN objvQuestionReferEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convQuestionRefer.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, convQuestionRefer.UpdUser);
objvQuestionReferEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionReferEN.dicFldComparisonOp.ContainsKey(convQuestionRefer.UpdUser) == false)
{
objvQuestionReferEN.dicFldComparisonOp.Add(convQuestionRefer.UpdUser, strComparisonOp);
}
else
{
objvQuestionReferEN.dicFldComparisonOp[convQuestionRefer.UpdUser] = strComparisonOp;
}
}
return objvQuestionReferEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionReferEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionReferEN SetMemo(this clsvQuestionReferEN objvQuestionReferEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQuestionRefer.Memo);
objvQuestionReferEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionReferEN.dicFldComparisonOp.ContainsKey(convQuestionRefer.Memo) == false)
{
objvQuestionReferEN.dicFldComparisonOp.Add(convQuestionRefer.Memo, strComparisonOp);
}
else
{
objvQuestionReferEN.dicFldComparisonOp[convQuestionRefer.Memo] = strComparisonOp;
}
}
return objvQuestionReferEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQuestionReferEN objvQuestionRefer_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQuestionRefer_Cond.IsUpdated(convQuestionRefer.mId) == true)
{
string strComparisonOp_mId = objvQuestionRefer_Cond.dicFldComparisonOp[convQuestionRefer.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionRefer.mId, objvQuestionRefer_Cond.mId, strComparisonOp_mId);
}
if (objvQuestionRefer_Cond.IsUpdated(convQuestionRefer.QuestionID) == true)
{
string strComparisonOp_QuestionID = objvQuestionRefer_Cond.dicFldComparisonOp[convQuestionRefer.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionRefer.QuestionID, objvQuestionRefer_Cond.QuestionID, strComparisonOp_QuestionID);
}
if (objvQuestionRefer_Cond.IsUpdated(convQuestionRefer.QuestionName) == true)
{
string strComparisonOp_QuestionName = objvQuestionRefer_Cond.dicFldComparisonOp[convQuestionRefer.QuestionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionRefer.QuestionName, objvQuestionRefer_Cond.QuestionName, strComparisonOp_QuestionName);
}
if (objvQuestionRefer_Cond.IsUpdated(convQuestionRefer.CourseId) == true)
{
string strComparisonOp_CourseId = objvQuestionRefer_Cond.dicFldComparisonOp[convQuestionRefer.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionRefer.CourseId, objvQuestionRefer_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvQuestionRefer_Cond.IsUpdated(convQuestionRefer.CourseName) == true)
{
string strComparisonOp_CourseName = objvQuestionRefer_Cond.dicFldComparisonOp[convQuestionRefer.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionRefer.CourseName, objvQuestionRefer_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvQuestionRefer_Cond.IsUpdated(convQuestionRefer.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvQuestionRefer_Cond.dicFldComparisonOp[convQuestionRefer.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionRefer.FuncModuleId, objvQuestionRefer_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvQuestionRefer_Cond.IsUpdated(convQuestionRefer.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvQuestionRefer_Cond.dicFldComparisonOp[convQuestionRefer.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionRefer.FuncModuleName, objvQuestionRefer_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvQuestionRefer_Cond.IsUpdated(convQuestionRefer.FuncModuleName_Sim) == true)
{
string strComparisonOp_FuncModuleName_Sim = objvQuestionRefer_Cond.dicFldComparisonOp[convQuestionRefer.FuncModuleName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionRefer.FuncModuleName_Sim, objvQuestionRefer_Cond.FuncModuleName_Sim, strComparisonOp_FuncModuleName_Sim);
}
if (objvQuestionRefer_Cond.IsUpdated(convQuestionRefer.TableName) == true)
{
string strComparisonOp_TableName = objvQuestionRefer_Cond.dicFldComparisonOp[convQuestionRefer.TableName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionRefer.TableName, objvQuestionRefer_Cond.TableName, strComparisonOp_TableName);
}
if (objvQuestionRefer_Cond.IsUpdated(convQuestionRefer.KeyIdValue) == true)
{
string strComparisonOp_KeyIdValue = objvQuestionRefer_Cond.dicFldComparisonOp[convQuestionRefer.KeyIdValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionRefer.KeyIdValue, objvQuestionRefer_Cond.KeyIdValue, strComparisonOp_KeyIdValue);
}
if (objvQuestionRefer_Cond.IsUpdated(convQuestionRefer.CaseName) == true)
{
string strComparisonOp_CaseName = objvQuestionRefer_Cond.dicFldComparisonOp[convQuestionRefer.CaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionRefer.CaseName, objvQuestionRefer_Cond.CaseName, strComparisonOp_CaseName);
}
if (objvQuestionRefer_Cond.IsUpdated(convQuestionRefer.IsShow) == true)
{
if (objvQuestionRefer_Cond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQuestionRefer.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQuestionRefer.IsShow);
}
}
if (objvQuestionRefer_Cond.IsUpdated(convQuestionRefer.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvQuestionRefer_Cond.dicFldComparisonOp[convQuestionRefer.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionRefer.UpdDate, objvQuestionRefer_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvQuestionRefer_Cond.IsUpdated(convQuestionRefer.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvQuestionRefer_Cond.dicFldComparisonOp[convQuestionRefer.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionRefer.UpdUser, objvQuestionRefer_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvQuestionRefer_Cond.IsUpdated(convQuestionRefer.Memo) == true)
{
string strComparisonOp_Memo = objvQuestionRefer_Cond.dicFldComparisonOp[convQuestionRefer.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionRefer.Memo, objvQuestionRefer_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v题目参考(vQuestionRefer)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQuestionReferWApi
{
private static readonly string mstrApiControllerName = "vQuestionReferApi";

 public clsvQuestionReferWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionReferEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsvQuestionReferEN objvQuestionReferEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvQuestionReferEN = JsonConvert.DeserializeObject<clsvQuestionReferEN>((string)jobjReturn["ReturnObj"]);
return objvQuestionReferEN;
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
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionReferEN GetObjBymId_WA_Cache(long lngmId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvQuestionReferEN objvQuestionReferEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvQuestionReferEN = JsonConvert.DeserializeObject<clsvQuestionReferEN>((string)jobjReturn["ReturnObj"]);
return objvQuestionReferEN;
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
public static clsvQuestionReferEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvQuestionReferEN objvQuestionReferEN = null;
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
objvQuestionReferEN = JsonConvert.DeserializeObject<clsvQuestionReferEN>((string)jobjReturn["ReturnObj"]);
return objvQuestionReferEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQuestionReferEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvQuestionReferEN._CurrTabName_S);
List<clsvQuestionReferEN> arrvQuestionReferObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvQuestionReferEN> arrvQuestionReferObjLst_Sel =
from objvQuestionReferEN in arrvQuestionReferObjLst_Cache
where objvQuestionReferEN.mId == lngmId
select objvQuestionReferEN;
if (arrvQuestionReferObjLst_Sel.Count() == 0)
{
   clsvQuestionReferEN obj = clsvQuestionReferWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvQuestionReferObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionReferEN> GetObjLst(string strWhereCond)
{
 List<clsvQuestionReferEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionReferEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionReferEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvQuestionReferEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionReferEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvQuestionReferEN> GetObjLstByMIdLst_Cache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvQuestionReferEN._CurrTabName_S);
List<clsvQuestionReferEN> arrvQuestionReferObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvQuestionReferEN> arrvQuestionReferObjLst_Sel =
from objvQuestionReferEN in arrvQuestionReferObjLst_Cache
where arrMId.Contains(objvQuestionReferEN.mId)
select objvQuestionReferEN;
return arrvQuestionReferObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionReferEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId)
{
 List<clsvQuestionReferEN> arrObjLst = null; 
string strAction = "GetObjLstByMIdLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMId);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionReferEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionReferEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQuestionReferEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionReferEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionReferEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQuestionReferEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionReferEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionReferEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQuestionReferEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionReferEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionReferEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvQuestionReferEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionReferEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngmId)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["mId"] = lngmId.ToString()
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
 /// <param name = "objvQuestionReferENS">源对象</param>
 /// <param name = "objvQuestionReferENT">目标对象</param>
 public static void CopyTo(clsvQuestionReferEN objvQuestionReferENS, clsvQuestionReferEN objvQuestionReferENT)
{
try
{
objvQuestionReferENT.mId = objvQuestionReferENS.mId; //mId
objvQuestionReferENT.QuestionID = objvQuestionReferENS.QuestionID; //题目ID
objvQuestionReferENT.QuestionName = objvQuestionReferENS.QuestionName; //题目名称
objvQuestionReferENT.CourseId = objvQuestionReferENS.CourseId; //课程Id
objvQuestionReferENT.CourseName = objvQuestionReferENS.CourseName; //课程名称
objvQuestionReferENT.FuncModuleId = objvQuestionReferENS.FuncModuleId; //功能模块Id
objvQuestionReferENT.FuncModuleName = objvQuestionReferENS.FuncModuleName; //功能模块名称
objvQuestionReferENT.FuncModuleName_Sim = objvQuestionReferENS.FuncModuleName_Sim; //功能模块简称
objvQuestionReferENT.TableName = objvQuestionReferENS.TableName; //主表表名
objvQuestionReferENT.KeyIdValue = objvQuestionReferENS.KeyIdValue; //关键字值
objvQuestionReferENT.CaseName = objvQuestionReferENS.CaseName; //案例名称
objvQuestionReferENT.IsShow = objvQuestionReferENS.IsShow; //是否启用
objvQuestionReferENT.UpdDate = objvQuestionReferENS.UpdDate; //修改日期
objvQuestionReferENT.UpdUser = objvQuestionReferENS.UpdUser; //修改人
objvQuestionReferENT.Memo = objvQuestionReferENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvQuestionReferEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQuestionReferEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQuestionReferEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQuestionReferEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQuestionReferEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQuestionReferEN.AttributeName)
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
if (clsFuncModuleWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleWApi没有刷新缓存机制(clsFuncModuleWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionReferWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionReferWApi没有刷新缓存机制(clsQuestionReferWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionnaireWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionnaireWApi没有刷新缓存机制(clsQuestionnaireWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAnswerModeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsAnswerModeWApi没有刷新缓存机制(clsAnswerModeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAnswerTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsAnswerTypeWApi没有刷新缓存机制(clsAnswerTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionTypeWApi没有刷新缓存机制(clsQuestionTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseWApi没有刷新缓存机制(clscc_CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExamGradeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExamGradeWApi没有刷新缓存机制(clscc_ExamGradeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionType4CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionType4CourseWApi没有刷新缓存机制(clsQuestionType4CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseChapterWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterWApi没有刷新缓存机制(clscc_CourseChapterWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvQuestionReferObjLst_Cache == null)
//{
//arrvQuestionReferObjLst_Cache = await clsvQuestionReferWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvQuestionReferEN._CurrTabName_S);
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
public static List<clsvQuestionReferEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvQuestionReferEN._CurrTabName_S);
List<clsvQuestionReferEN> arrvQuestionReferObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQuestionReferObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvQuestionReferEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQuestionRefer.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convQuestionRefer.QuestionID, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionRefer.QuestionName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionRefer.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionRefer.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionRefer.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionRefer.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionRefer.FuncModuleName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionRefer.TableName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionRefer.KeyIdValue, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionRefer.CaseName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionRefer.IsShow, Type.GetType("System.Boolean"));
objDT.Columns.Add(convQuestionRefer.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionRefer.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionRefer.Memo, Type.GetType("System.String"));
foreach (clsvQuestionReferEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQuestionRefer.mId] = objInFor[convQuestionRefer.mId];
objDR[convQuestionRefer.QuestionID] = objInFor[convQuestionRefer.QuestionID];
objDR[convQuestionRefer.QuestionName] = objInFor[convQuestionRefer.QuestionName];
objDR[convQuestionRefer.CourseId] = objInFor[convQuestionRefer.CourseId];
objDR[convQuestionRefer.CourseName] = objInFor[convQuestionRefer.CourseName];
objDR[convQuestionRefer.FuncModuleId] = objInFor[convQuestionRefer.FuncModuleId];
objDR[convQuestionRefer.FuncModuleName] = objInFor[convQuestionRefer.FuncModuleName];
objDR[convQuestionRefer.FuncModuleName_Sim] = objInFor[convQuestionRefer.FuncModuleName_Sim];
objDR[convQuestionRefer.TableName] = objInFor[convQuestionRefer.TableName];
objDR[convQuestionRefer.KeyIdValue] = objInFor[convQuestionRefer.KeyIdValue];
objDR[convQuestionRefer.CaseName] = objInFor[convQuestionRefer.CaseName];
objDR[convQuestionRefer.IsShow] = objInFor[convQuestionRefer.IsShow];
objDR[convQuestionRefer.UpdDate] = objInFor[convQuestionRefer.UpdDate];
objDR[convQuestionRefer.UpdUser] = objInFor[convQuestionRefer.UpdUser];
objDR[convQuestionRefer.Memo] = objInFor[convQuestionRefer.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}