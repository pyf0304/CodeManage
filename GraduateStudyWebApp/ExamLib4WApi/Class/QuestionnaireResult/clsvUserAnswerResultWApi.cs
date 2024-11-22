
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvUserAnswerResultWApi
 表名:vUserAnswerResult(01120022)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:44:59
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:问卷结果
 模块英文名:QuestionnaireResult
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
public static class clsvUserAnswerResultWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserAnswerResultEN SetMinID(this clsvUserAnswerResultEN objvUserAnswerResultEN, long lngMinID, string strComparisonOp="")
	{
objvUserAnswerResultEN.MinID = lngMinID; //MinID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.MinID) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.MinID, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.MinID] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserAnswerResultEN SetQuestionID(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strQuestionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionID, 8, convUserAnswerResult.QuestionID);
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, convUserAnswerResult.QuestionID);
objvUserAnswerResultEN.QuestionID = strQuestionID; //题目ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.QuestionID) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.QuestionID, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.QuestionID] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserAnswerResultEN SetQuestionIndex(this clsvUserAnswerResultEN objvUserAnswerResultEN, int intQuestionIndex, string strComparisonOp="")
	{
objvUserAnswerResultEN.QuestionIndex = intQuestionIndex; //题目序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.QuestionIndex) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.QuestionIndex, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.QuestionIndex] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserAnswerResultEN SetQuestionName(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strQuestionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionName, 1000, convUserAnswerResult.QuestionName);
objvUserAnswerResultEN.QuestionName = strQuestionName; //题目名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.QuestionName) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.QuestionName, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.QuestionName] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserAnswerResultEN SetQuestionNo(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strQuestionNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionNo, 10, convUserAnswerResult.QuestionNo);
objvUserAnswerResultEN.QuestionNo = strQuestionNo; //题目编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.QuestionNo) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.QuestionNo, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.QuestionNo] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserAnswerResultEN SetQuestionTypeId(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strQuestionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, convUserAnswerResult.QuestionTypeId);
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, convUserAnswerResult.QuestionTypeId);
objvUserAnswerResultEN.QuestionTypeId = strQuestionTypeId; //题目类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.QuestionTypeId) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.QuestionTypeId, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.QuestionTypeId] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserAnswerResultEN SetQuestionTypeName(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strQuestionTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionTypeName, 20, convUserAnswerResult.QuestionTypeName);
objvUserAnswerResultEN.QuestionTypeName = strQuestionTypeName; //题目类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.QuestionTypeName) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.QuestionTypeName, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.QuestionTypeName] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserAnswerResultEN SetAnswerTypeId(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strAnswerTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerTypeId, 2, convUserAnswerResult.AnswerTypeId);
clsCheckSql.CheckFieldForeignKey(strAnswerTypeId, 2, convUserAnswerResult.AnswerTypeId);
objvUserAnswerResultEN.AnswerTypeId = strAnswerTypeId; //答案类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.AnswerTypeId) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.AnswerTypeId, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.AnswerTypeId] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserAnswerResultEN SetAnswerTypeName(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strAnswerTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerTypeName, 50, convUserAnswerResult.AnswerTypeName);
objvUserAnswerResultEN.AnswerTypeName = strAnswerTypeName; //答案类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.AnswerTypeName) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.AnswerTypeName, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.AnswerTypeName] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserAnswerResultEN SetGridTitle(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strGridTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGridTitle, 30, convUserAnswerResult.GridTitle);
objvUserAnswerResultEN.GridTitle = strGridTitle; //表格标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.GridTitle) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.GridTitle, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.GridTitle] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserAnswerResultEN SetAnswerModeId(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strAnswerModeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerModeId, 4, convUserAnswerResult.AnswerModeId);
clsCheckSql.CheckFieldForeignKey(strAnswerModeId, 4, convUserAnswerResult.AnswerModeId);
objvUserAnswerResultEN.AnswerModeId = strAnswerModeId; //答案模式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.AnswerModeId) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.AnswerModeId, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.AnswerModeId] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserAnswerResultEN SetQuestionnaireSetName(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strQuestionnaireSetName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionnaireSetName, 50, convUserAnswerResult.QuestionnaireSetName);
objvUserAnswerResultEN.QuestionnaireSetName = strQuestionnaireSetName; //问卷集名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.QuestionnaireSetName) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.QuestionnaireSetName, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.QuestionnaireSetName] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserAnswerResultEN SetQuestionScore(this clsvUserAnswerResultEN objvUserAnswerResultEN, float fltQuestionScore, string strComparisonOp="")
	{
objvUserAnswerResultEN.QuestionScore = fltQuestionScore; //题目得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.QuestionScore) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.QuestionScore, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.QuestionScore] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserAnswerResultEN SetRoleId(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strRoleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRoleId, 8, convUserAnswerResult.RoleId);
clsCheckSql.CheckFieldForeignKey(strRoleId, 8, convUserAnswerResult.RoleId);
objvUserAnswerResultEN.RoleId = strRoleId; //角色Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.RoleId) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.RoleId, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.RoleId] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserAnswerResultEN SetRoleName(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strRoleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strRoleName, 100, convUserAnswerResult.RoleName);
objvUserAnswerResultEN.RoleName = strRoleName; //角色名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.RoleName) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.RoleName, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.RoleName] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserAnswerResultEN SetQuestionnaireSetId(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strQuestionnaireSetId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionnaireSetId, 4, convUserAnswerResult.QuestionnaireSetId);
clsCheckSql.CheckFieldForeignKey(strQuestionnaireSetId, 4, convUserAnswerResult.QuestionnaireSetId);
objvUserAnswerResultEN.QuestionnaireSetId = strQuestionnaireSetId; //问卷集ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.QuestionnaireSetId) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.QuestionnaireSetId, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.QuestionnaireSetId] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserAnswerResultEN SetCourseId(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convUserAnswerResult.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convUserAnswerResult.CourseId);
objvUserAnswerResultEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.CourseId) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.CourseId, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.CourseId] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserAnswerResultEN SetCourseName(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convUserAnswerResult.CourseName);
objvUserAnswerResultEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.CourseName) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.CourseName, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.CourseName] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserAnswerResultEN SetCourseExamPaperId(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strCourseExamPaperId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseExamPaperId, 8, convUserAnswerResult.CourseExamPaperId);
clsCheckSql.CheckFieldForeignKey(strCourseExamPaperId, 8, convUserAnswerResult.CourseExamPaperId);
objvUserAnswerResultEN.CourseExamPaperId = strCourseExamPaperId; //考卷流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.CourseExamPaperId) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.CourseExamPaperId, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.CourseExamPaperId] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserAnswerResultEN SetAnswerOptionId(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strAnswerOptionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerOptionId, 8, convUserAnswerResult.AnswerOptionId);
clsCheckSql.CheckFieldForeignKey(strAnswerOptionId, 8, convUserAnswerResult.AnswerOptionId);
objvUserAnswerResultEN.AnswerOptionId = strAnswerOptionId; //回答选项Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.AnswerOptionId) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.AnswerOptionId, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.AnswerOptionId] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserAnswerResultEN SetOptionName(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strOptionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOptionName, 4000, convUserAnswerResult.OptionName);
objvUserAnswerResultEN.OptionName = strOptionName; //选项名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.OptionName) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.OptionName, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.OptionName] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserAnswerResultEN SetOptionIndex(this clsvUserAnswerResultEN objvUserAnswerResultEN, int intOptionIndex, string strComparisonOp="")
	{
objvUserAnswerResultEN.OptionIndex = intOptionIndex; //选项序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.OptionIndex) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.OptionIndex, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.OptionIndex] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserAnswerResultEN SetOptionTitle(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strOptionTitle, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strOptionTitle, 20, convUserAnswerResult.OptionTitle);
objvUserAnswerResultEN.OptionTitle = strOptionTitle; //选项标题
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.OptionTitle) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.OptionTitle, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.OptionTitle] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserAnswerResultEN SetBatchId(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strBatchId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strBatchId, 4, convUserAnswerResult.BatchId);
clsCheckSql.CheckFieldForeignKey(strBatchId, 4, convUserAnswerResult.BatchId);
objvUserAnswerResultEN.BatchId = strBatchId; //批次ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.BatchId) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.BatchId, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.BatchId] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserAnswerResultEN SetUserId(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserId, 20, convUserAnswerResult.UserId);
objvUserAnswerResultEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.UserId) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.UserId, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.UserId] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserAnswerResultEN SetUserName(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strUserName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUserName, 50, convUserAnswerResult.UserName);
objvUserAnswerResultEN.UserName = strUserName; //用户名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.UserName) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.UserName, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.UserName] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserAnswerResultEN SetAnswerText(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strAnswerText, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerText, 8000, convUserAnswerResult.AnswerText);
objvUserAnswerResultEN.AnswerText = strAnswerText; //回答文本
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.AnswerText) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.AnswerText, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.AnswerText] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserAnswerResultEN SetAnswerDate(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strAnswerDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerDate, 8, convUserAnswerResult.AnswerDate);
objvUserAnswerResultEN.AnswerDate = strAnswerDate; //回答日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.AnswerDate) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.AnswerDate, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.AnswerDate] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserAnswerResultEN SetAnswerTime(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strAnswerTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerTime, 10, convUserAnswerResult.AnswerTime);
objvUserAnswerResultEN.AnswerTime = strAnswerTime; //回答时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.AnswerTime) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.AnswerTime, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.AnswerTime] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserAnswerResultEN SetAnswerIP(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strAnswerIP, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAnswerIP, 30, convUserAnswerResult.AnswerIP);
objvUserAnswerResultEN.AnswerIP = strAnswerIP; //回答IP
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.AnswerIP) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.AnswerIP, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.AnswerIP] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserAnswerResultEN SetIsAccess(this clsvUserAnswerResultEN objvUserAnswerResultEN, bool bolIsAccess, string strComparisonOp="")
	{
objvUserAnswerResultEN.IsAccess = bolIsAccess; //IsAccess
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.IsAccess) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.IsAccess, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.IsAccess] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserAnswerResultEN SetIsAccessC(this clsvUserAnswerResultEN objvUserAnswerResultEN, bool bolIsAccessC, string strComparisonOp="")
	{
objvUserAnswerResultEN.IsAccessC = bolIsAccessC; //IsAccessC
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.IsAccessC) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.IsAccessC, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.IsAccessC] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserAnswerResultEN Setid_School(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strid_School, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_School, 4, convUserAnswerResult.id_School);
clsCheckSql.CheckFieldForeignKey(strid_School, 4, convUserAnswerResult.id_School);
objvUserAnswerResultEN.id_School = strid_School; //学校流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.id_School) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.id_School, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.id_School] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserAnswerResultEN SetSchool(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strSchool, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchool, 50, convUserAnswerResult.School);
objvUserAnswerResultEN.School = strSchool; //School
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.School) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.School, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.School] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserAnswerResultEN SetAnswerMode(this clsvUserAnswerResultEN objvUserAnswerResultEN, int intAnswerMode, string strComparisonOp="")
	{
objvUserAnswerResultEN.AnswerMode = intAnswerMode; //AnswerMode
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.AnswerMode) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.AnswerMode, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.AnswerMode] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserAnswerResultEN SetIsMarking(this clsvUserAnswerResultEN objvUserAnswerResultEN, bool bolIsMarking, string strComparisonOp="")
	{
objvUserAnswerResultEN.IsMarking = bolIsMarking; //是否批阅
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.IsMarking) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.IsMarking, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.IsMarking] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserAnswerResultEN SetIsRight(this clsvUserAnswerResultEN objvUserAnswerResultEN, bool bolIsRight, string strComparisonOp="")
	{
objvUserAnswerResultEN.IsRight = bolIsRight; //是否正确
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.IsRight) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.IsRight, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.IsRight] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserAnswerResultEN SetScore(this clsvUserAnswerResultEN objvUserAnswerResultEN, double dblScore, string strComparisonOp="")
	{
objvUserAnswerResultEN.Score = dblScore; //得分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.Score) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.Score, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.Score] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserAnswerResultEN SetMarkTime(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strMarkTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMarkTime, 14, convUserAnswerResult.MarkTime);
objvUserAnswerResultEN.MarkTime = strMarkTime; //批改时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.MarkTime) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.MarkTime, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.MarkTime] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserAnswerResultEN SetMarkerId(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strMarkerId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMarkerId, 20, convUserAnswerResult.MarkerId);
objvUserAnswerResultEN.MarkerId = strMarkerId; //打分者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.MarkerId) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.MarkerId, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.MarkerId] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserAnswerResultEN SetComment(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strComment, string strComparisonOp="")
	{
objvUserAnswerResultEN.Comment = strComment; //批注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.Comment) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.Comment, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.Comment] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserAnswerResultEN SetIsAccessKnowledge(this clsvUserAnswerResultEN objvUserAnswerResultEN, bool bolIsAccessKnowledge, string strComparisonOp="")
	{
objvUserAnswerResultEN.IsAccessKnowledge = bolIsAccessKnowledge; //是否处理知识点
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.IsAccessKnowledge) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.IsAccessKnowledge, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.IsAccessKnowledge] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserAnswerResultEN SetUpdDate(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convUserAnswerResult.UpdDate);
clsCheckSql.CheckFieldLen(strUpdDate, 20, convUserAnswerResult.UpdDate);
objvUserAnswerResultEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.UpdDate) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.UpdDate, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.UpdDate] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserAnswerResultEN SetUpdUser(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convUserAnswerResult.UpdUser);
clsCheckSql.CheckFieldLen(strUpdUser, 20, convUserAnswerResult.UpdUser);
objvUserAnswerResultEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.UpdUser) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.UpdUser, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.UpdUser] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvUserAnswerResultEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvUserAnswerResultEN SetMemo(this clsvUserAnswerResultEN objvUserAnswerResultEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convUserAnswerResult.Memo);
objvUserAnswerResultEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvUserAnswerResultEN.dicFldComparisonOp.ContainsKey(convUserAnswerResult.Memo) == false)
{
objvUserAnswerResultEN.dicFldComparisonOp.Add(convUserAnswerResult.Memo, strComparisonOp);
}
else
{
objvUserAnswerResultEN.dicFldComparisonOp[convUserAnswerResult.Memo] = strComparisonOp;
}
}
return objvUserAnswerResultEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvUserAnswerResultEN objvUserAnswerResult_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvUserAnswerResult_Cond.IsUpdated(convUserAnswerResult.MinID) == true)
{
string strComparisonOp_MinID = objvUserAnswerResult_Cond.dicFldComparisonOp[convUserAnswerResult.MinID];
strWhereCond += string.Format(" And {0} {2} {1}", convUserAnswerResult.MinID, objvUserAnswerResult_Cond.MinID, strComparisonOp_MinID);
}
if (objvUserAnswerResult_Cond.IsUpdated(convUserAnswerResult.QuestionID) == true)
{
string strComparisonOp_QuestionID = objvUserAnswerResult_Cond.dicFldComparisonOp[convUserAnswerResult.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.QuestionID, objvUserAnswerResult_Cond.QuestionID, strComparisonOp_QuestionID);
}
if (objvUserAnswerResult_Cond.IsUpdated(convUserAnswerResult.QuestionIndex) == true)
{
string strComparisonOp_QuestionIndex = objvUserAnswerResult_Cond.dicFldComparisonOp[convUserAnswerResult.QuestionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convUserAnswerResult.QuestionIndex, objvUserAnswerResult_Cond.QuestionIndex, strComparisonOp_QuestionIndex);
}
if (objvUserAnswerResult_Cond.IsUpdated(convUserAnswerResult.QuestionName) == true)
{
string strComparisonOp_QuestionName = objvUserAnswerResult_Cond.dicFldComparisonOp[convUserAnswerResult.QuestionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.QuestionName, objvUserAnswerResult_Cond.QuestionName, strComparisonOp_QuestionName);
}
if (objvUserAnswerResult_Cond.IsUpdated(convUserAnswerResult.QuestionNo) == true)
{
string strComparisonOp_QuestionNo = objvUserAnswerResult_Cond.dicFldComparisonOp[convUserAnswerResult.QuestionNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.QuestionNo, objvUserAnswerResult_Cond.QuestionNo, strComparisonOp_QuestionNo);
}
if (objvUserAnswerResult_Cond.IsUpdated(convUserAnswerResult.QuestionTypeId) == true)
{
string strComparisonOp_QuestionTypeId = objvUserAnswerResult_Cond.dicFldComparisonOp[convUserAnswerResult.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.QuestionTypeId, objvUserAnswerResult_Cond.QuestionTypeId, strComparisonOp_QuestionTypeId);
}
if (objvUserAnswerResult_Cond.IsUpdated(convUserAnswerResult.QuestionTypeName) == true)
{
string strComparisonOp_QuestionTypeName = objvUserAnswerResult_Cond.dicFldComparisonOp[convUserAnswerResult.QuestionTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.QuestionTypeName, objvUserAnswerResult_Cond.QuestionTypeName, strComparisonOp_QuestionTypeName);
}
if (objvUserAnswerResult_Cond.IsUpdated(convUserAnswerResult.AnswerTypeId) == true)
{
string strComparisonOp_AnswerTypeId = objvUserAnswerResult_Cond.dicFldComparisonOp[convUserAnswerResult.AnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.AnswerTypeId, objvUserAnswerResult_Cond.AnswerTypeId, strComparisonOp_AnswerTypeId);
}
if (objvUserAnswerResult_Cond.IsUpdated(convUserAnswerResult.AnswerTypeName) == true)
{
string strComparisonOp_AnswerTypeName = objvUserAnswerResult_Cond.dicFldComparisonOp[convUserAnswerResult.AnswerTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.AnswerTypeName, objvUserAnswerResult_Cond.AnswerTypeName, strComparisonOp_AnswerTypeName);
}
if (objvUserAnswerResult_Cond.IsUpdated(convUserAnswerResult.GridTitle) == true)
{
string strComparisonOp_GridTitle = objvUserAnswerResult_Cond.dicFldComparisonOp[convUserAnswerResult.GridTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.GridTitle, objvUserAnswerResult_Cond.GridTitle, strComparisonOp_GridTitle);
}
if (objvUserAnswerResult_Cond.IsUpdated(convUserAnswerResult.AnswerModeId) == true)
{
string strComparisonOp_AnswerModeId = objvUserAnswerResult_Cond.dicFldComparisonOp[convUserAnswerResult.AnswerModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.AnswerModeId, objvUserAnswerResult_Cond.AnswerModeId, strComparisonOp_AnswerModeId);
}
if (objvUserAnswerResult_Cond.IsUpdated(convUserAnswerResult.QuestionnaireSetName) == true)
{
string strComparisonOp_QuestionnaireSetName = objvUserAnswerResult_Cond.dicFldComparisonOp[convUserAnswerResult.QuestionnaireSetName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.QuestionnaireSetName, objvUserAnswerResult_Cond.QuestionnaireSetName, strComparisonOp_QuestionnaireSetName);
}
if (objvUserAnswerResult_Cond.IsUpdated(convUserAnswerResult.QuestionScore) == true)
{
string strComparisonOp_QuestionScore = objvUserAnswerResult_Cond.dicFldComparisonOp[convUserAnswerResult.QuestionScore];
strWhereCond += string.Format(" And {0} {2} {1}", convUserAnswerResult.QuestionScore, objvUserAnswerResult_Cond.QuestionScore, strComparisonOp_QuestionScore);
}
if (objvUserAnswerResult_Cond.IsUpdated(convUserAnswerResult.RoleId) == true)
{
string strComparisonOp_RoleId = objvUserAnswerResult_Cond.dicFldComparisonOp[convUserAnswerResult.RoleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.RoleId, objvUserAnswerResult_Cond.RoleId, strComparisonOp_RoleId);
}
if (objvUserAnswerResult_Cond.IsUpdated(convUserAnswerResult.RoleName) == true)
{
string strComparisonOp_RoleName = objvUserAnswerResult_Cond.dicFldComparisonOp[convUserAnswerResult.RoleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.RoleName, objvUserAnswerResult_Cond.RoleName, strComparisonOp_RoleName);
}
if (objvUserAnswerResult_Cond.IsUpdated(convUserAnswerResult.QuestionnaireSetId) == true)
{
string strComparisonOp_QuestionnaireSetId = objvUserAnswerResult_Cond.dicFldComparisonOp[convUserAnswerResult.QuestionnaireSetId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.QuestionnaireSetId, objvUserAnswerResult_Cond.QuestionnaireSetId, strComparisonOp_QuestionnaireSetId);
}
if (objvUserAnswerResult_Cond.IsUpdated(convUserAnswerResult.CourseId) == true)
{
string strComparisonOp_CourseId = objvUserAnswerResult_Cond.dicFldComparisonOp[convUserAnswerResult.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.CourseId, objvUserAnswerResult_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvUserAnswerResult_Cond.IsUpdated(convUserAnswerResult.CourseName) == true)
{
string strComparisonOp_CourseName = objvUserAnswerResult_Cond.dicFldComparisonOp[convUserAnswerResult.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.CourseName, objvUserAnswerResult_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvUserAnswerResult_Cond.IsUpdated(convUserAnswerResult.CourseExamPaperId) == true)
{
string strComparisonOp_CourseExamPaperId = objvUserAnswerResult_Cond.dicFldComparisonOp[convUserAnswerResult.CourseExamPaperId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.CourseExamPaperId, objvUserAnswerResult_Cond.CourseExamPaperId, strComparisonOp_CourseExamPaperId);
}
if (objvUserAnswerResult_Cond.IsUpdated(convUserAnswerResult.AnswerOptionId) == true)
{
string strComparisonOp_AnswerOptionId = objvUserAnswerResult_Cond.dicFldComparisonOp[convUserAnswerResult.AnswerOptionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.AnswerOptionId, objvUserAnswerResult_Cond.AnswerOptionId, strComparisonOp_AnswerOptionId);
}
if (objvUserAnswerResult_Cond.IsUpdated(convUserAnswerResult.OptionName) == true)
{
string strComparisonOp_OptionName = objvUserAnswerResult_Cond.dicFldComparisonOp[convUserAnswerResult.OptionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.OptionName, objvUserAnswerResult_Cond.OptionName, strComparisonOp_OptionName);
}
if (objvUserAnswerResult_Cond.IsUpdated(convUserAnswerResult.OptionIndex) == true)
{
string strComparisonOp_OptionIndex = objvUserAnswerResult_Cond.dicFldComparisonOp[convUserAnswerResult.OptionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convUserAnswerResult.OptionIndex, objvUserAnswerResult_Cond.OptionIndex, strComparisonOp_OptionIndex);
}
if (objvUserAnswerResult_Cond.IsUpdated(convUserAnswerResult.OptionTitle) == true)
{
string strComparisonOp_OptionTitle = objvUserAnswerResult_Cond.dicFldComparisonOp[convUserAnswerResult.OptionTitle];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.OptionTitle, objvUserAnswerResult_Cond.OptionTitle, strComparisonOp_OptionTitle);
}
if (objvUserAnswerResult_Cond.IsUpdated(convUserAnswerResult.BatchId) == true)
{
string strComparisonOp_BatchId = objvUserAnswerResult_Cond.dicFldComparisonOp[convUserAnswerResult.BatchId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.BatchId, objvUserAnswerResult_Cond.BatchId, strComparisonOp_BatchId);
}
if (objvUserAnswerResult_Cond.IsUpdated(convUserAnswerResult.UserId) == true)
{
string strComparisonOp_UserId = objvUserAnswerResult_Cond.dicFldComparisonOp[convUserAnswerResult.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.UserId, objvUserAnswerResult_Cond.UserId, strComparisonOp_UserId);
}
if (objvUserAnswerResult_Cond.IsUpdated(convUserAnswerResult.UserName) == true)
{
string strComparisonOp_UserName = objvUserAnswerResult_Cond.dicFldComparisonOp[convUserAnswerResult.UserName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.UserName, objvUserAnswerResult_Cond.UserName, strComparisonOp_UserName);
}
if (objvUserAnswerResult_Cond.IsUpdated(convUserAnswerResult.AnswerText) == true)
{
string strComparisonOp_AnswerText = objvUserAnswerResult_Cond.dicFldComparisonOp[convUserAnswerResult.AnswerText];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.AnswerText, objvUserAnswerResult_Cond.AnswerText, strComparisonOp_AnswerText);
}
if (objvUserAnswerResult_Cond.IsUpdated(convUserAnswerResult.AnswerDate) == true)
{
string strComparisonOp_AnswerDate = objvUserAnswerResult_Cond.dicFldComparisonOp[convUserAnswerResult.AnswerDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.AnswerDate, objvUserAnswerResult_Cond.AnswerDate, strComparisonOp_AnswerDate);
}
if (objvUserAnswerResult_Cond.IsUpdated(convUserAnswerResult.AnswerTime) == true)
{
string strComparisonOp_AnswerTime = objvUserAnswerResult_Cond.dicFldComparisonOp[convUserAnswerResult.AnswerTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.AnswerTime, objvUserAnswerResult_Cond.AnswerTime, strComparisonOp_AnswerTime);
}
if (objvUserAnswerResult_Cond.IsUpdated(convUserAnswerResult.AnswerIP) == true)
{
string strComparisonOp_AnswerIP = objvUserAnswerResult_Cond.dicFldComparisonOp[convUserAnswerResult.AnswerIP];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.AnswerIP, objvUserAnswerResult_Cond.AnswerIP, strComparisonOp_AnswerIP);
}
if (objvUserAnswerResult_Cond.IsUpdated(convUserAnswerResult.IsAccess) == true)
{
if (objvUserAnswerResult_Cond.IsAccess == true)
{
strWhereCond += string.Format(" And {0} = '1'", convUserAnswerResult.IsAccess);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convUserAnswerResult.IsAccess);
}
}
if (objvUserAnswerResult_Cond.IsUpdated(convUserAnswerResult.IsAccessC) == true)
{
if (objvUserAnswerResult_Cond.IsAccessC == true)
{
strWhereCond += string.Format(" And {0} = '1'", convUserAnswerResult.IsAccessC);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convUserAnswerResult.IsAccessC);
}
}
if (objvUserAnswerResult_Cond.IsUpdated(convUserAnswerResult.id_School) == true)
{
string strComparisonOp_id_School = objvUserAnswerResult_Cond.dicFldComparisonOp[convUserAnswerResult.id_School];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.id_School, objvUserAnswerResult_Cond.id_School, strComparisonOp_id_School);
}
if (objvUserAnswerResult_Cond.IsUpdated(convUserAnswerResult.School) == true)
{
string strComparisonOp_School = objvUserAnswerResult_Cond.dicFldComparisonOp[convUserAnswerResult.School];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.School, objvUserAnswerResult_Cond.School, strComparisonOp_School);
}
if (objvUserAnswerResult_Cond.IsUpdated(convUserAnswerResult.AnswerMode) == true)
{
string strComparisonOp_AnswerMode = objvUserAnswerResult_Cond.dicFldComparisonOp[convUserAnswerResult.AnswerMode];
strWhereCond += string.Format(" And {0} {2} {1}", convUserAnswerResult.AnswerMode, objvUserAnswerResult_Cond.AnswerMode, strComparisonOp_AnswerMode);
}
if (objvUserAnswerResult_Cond.IsUpdated(convUserAnswerResult.IsMarking) == true)
{
if (objvUserAnswerResult_Cond.IsMarking == true)
{
strWhereCond += string.Format(" And {0} = '1'", convUserAnswerResult.IsMarking);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convUserAnswerResult.IsMarking);
}
}
if (objvUserAnswerResult_Cond.IsUpdated(convUserAnswerResult.IsRight) == true)
{
if (objvUserAnswerResult_Cond.IsRight == true)
{
strWhereCond += string.Format(" And {0} = '1'", convUserAnswerResult.IsRight);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convUserAnswerResult.IsRight);
}
}
if (objvUserAnswerResult_Cond.IsUpdated(convUserAnswerResult.Score) == true)
{
string strComparisonOp_Score = objvUserAnswerResult_Cond.dicFldComparisonOp[convUserAnswerResult.Score];
strWhereCond += string.Format(" And {0} {2} {1}", convUserAnswerResult.Score, objvUserAnswerResult_Cond.Score, strComparisonOp_Score);
}
if (objvUserAnswerResult_Cond.IsUpdated(convUserAnswerResult.MarkTime) == true)
{
string strComparisonOp_MarkTime = objvUserAnswerResult_Cond.dicFldComparisonOp[convUserAnswerResult.MarkTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.MarkTime, objvUserAnswerResult_Cond.MarkTime, strComparisonOp_MarkTime);
}
if (objvUserAnswerResult_Cond.IsUpdated(convUserAnswerResult.MarkerId) == true)
{
string strComparisonOp_MarkerId = objvUserAnswerResult_Cond.dicFldComparisonOp[convUserAnswerResult.MarkerId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.MarkerId, objvUserAnswerResult_Cond.MarkerId, strComparisonOp_MarkerId);
}
//数据类型string(text)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvUserAnswerResult_Cond.IsUpdated(convUserAnswerResult.IsAccessKnowledge) == true)
{
if (objvUserAnswerResult_Cond.IsAccessKnowledge == true)
{
strWhereCond += string.Format(" And {0} = '1'", convUserAnswerResult.IsAccessKnowledge);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convUserAnswerResult.IsAccessKnowledge);
}
}
if (objvUserAnswerResult_Cond.IsUpdated(convUserAnswerResult.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvUserAnswerResult_Cond.dicFldComparisonOp[convUserAnswerResult.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.UpdDate, objvUserAnswerResult_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvUserAnswerResult_Cond.IsUpdated(convUserAnswerResult.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvUserAnswerResult_Cond.dicFldComparisonOp[convUserAnswerResult.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.UpdUser, objvUserAnswerResult_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvUserAnswerResult_Cond.IsUpdated(convUserAnswerResult.Memo) == true)
{
string strComparisonOp_Memo = objvUserAnswerResult_Cond.dicFldComparisonOp[convUserAnswerResult.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convUserAnswerResult.Memo, objvUserAnswerResult_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v用户答题结果(vUserAnswerResult)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvUserAnswerResultWApi
{
private static readonly string mstrApiControllerName = "vUserAnswerResultApi";

 public clsvUserAnswerResultWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngMinID">表关键字</param>
 /// <returns>表对象</returns>
public static clsvUserAnswerResultEN GetObjByMinID(long lngMinID)
{
string strAction = "GetObjByMinID";
string strErrMsg = string.Empty;
string strResult = "";
clsvUserAnswerResultEN objvUserAnswerResultEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["MinID"] = lngMinID.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvUserAnswerResultEN = JsonConvert.DeserializeObject<clsvUserAnswerResultEN>((string)jobjReturn["ReturnObj"]);
return objvUserAnswerResultEN;
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
 /// <param name = "lngMinID">表关键字</param>
 /// <returns>表对象</returns>
public static clsvUserAnswerResultEN GetObjByMinID_WA_Cache(long lngMinID, string strCourseId)
{
string strAction = "GetObjByMinID_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvUserAnswerResultEN objvUserAnswerResultEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["MinID"] = lngMinID.ToString(),
["CourseId"] = strCourseId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvUserAnswerResultEN = JsonConvert.DeserializeObject<clsvUserAnswerResultEN>((string)jobjReturn["ReturnObj"]);
return objvUserAnswerResultEN;
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
public static clsvUserAnswerResultEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvUserAnswerResultEN objvUserAnswerResultEN = null;
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
objvUserAnswerResultEN = JsonConvert.DeserializeObject<clsvUserAnswerResultEN>((string)jobjReturn["ReturnObj"]);
return objvUserAnswerResultEN;
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
 /// <param name = "lngMinID">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvUserAnswerResultEN GetObjByMinID_Cache(long lngMinID, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvUserAnswerResultEN._CurrTabName_S, strCourseId);
List<clsvUserAnswerResultEN> arrvUserAnswerResultObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvUserAnswerResultEN> arrvUserAnswerResultObjLst_Sel =
from objvUserAnswerResultEN in arrvUserAnswerResultObjLst_Cache
where objvUserAnswerResultEN.MinID == lngMinID
select objvUserAnswerResultEN;
if (arrvUserAnswerResultObjLst_Sel.Count() == 0)
{
   clsvUserAnswerResultEN obj = clsvUserAnswerResultWApi.GetObjByMinID(lngMinID);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvUserAnswerResultObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUserAnswerResultEN> GetObjLst(string strWhereCond)
{
 List<clsvUserAnswerResultEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserAnswerResultEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvUserAnswerResultEN> GetObjLstByMinIDLst(List<long> arrMinID)
{
 List<clsvUserAnswerResultEN> arrObjLst = null; 
string strAction = "GetObjLstByMinIDLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMinID);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserAnswerResultEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngMinID">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvUserAnswerResultEN> GetObjLstByMinIDLst_Cache(List<long> arrMinID, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvUserAnswerResultEN._CurrTabName_S, strCourseId);
List<clsvUserAnswerResultEN> arrvUserAnswerResultObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvUserAnswerResultEN> arrvUserAnswerResultObjLst_Sel =
from objvUserAnswerResultEN in arrvUserAnswerResultObjLst_Cache
where arrMinID.Contains(objvUserAnswerResultEN.MinID)
select objvUserAnswerResultEN;
return arrvUserAnswerResultObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvUserAnswerResultEN> GetObjLstByMinIDLst_WA_Cache(List<long> arrMinID, string strCourseId)
{
 List<clsvUserAnswerResultEN> arrObjLst = null; 
string strAction = "GetObjLstByMinIDLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseId"] = strCourseId
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrMinID);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserAnswerResultEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvUserAnswerResultEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvUserAnswerResultEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserAnswerResultEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvUserAnswerResultEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvUserAnswerResultEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserAnswerResultEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvUserAnswerResultEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvUserAnswerResultEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserAnswerResultEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvUserAnswerResultEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvUserAnswerResultEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvUserAnswerResultEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngMinID)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["MinID"] = lngMinID.ToString()
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
 /// <param name = "objvUserAnswerResultENS">源对象</param>
 /// <param name = "objvUserAnswerResultENT">目标对象</param>
 public static void CopyTo(clsvUserAnswerResultEN objvUserAnswerResultENS, clsvUserAnswerResultEN objvUserAnswerResultENT)
{
try
{
objvUserAnswerResultENT.MinID = objvUserAnswerResultENS.MinID; //MinID
objvUserAnswerResultENT.QuestionID = objvUserAnswerResultENS.QuestionID; //题目ID
objvUserAnswerResultENT.QuestionIndex = objvUserAnswerResultENS.QuestionIndex; //题目序号
objvUserAnswerResultENT.QuestionName = objvUserAnswerResultENS.QuestionName; //题目名称
objvUserAnswerResultENT.QuestionNo = objvUserAnswerResultENS.QuestionNo; //题目编号
objvUserAnswerResultENT.QuestionTypeId = objvUserAnswerResultENS.QuestionTypeId; //题目类型Id
objvUserAnswerResultENT.QuestionTypeName = objvUserAnswerResultENS.QuestionTypeName; //题目类型名
objvUserAnswerResultENT.AnswerTypeId = objvUserAnswerResultENS.AnswerTypeId; //答案类型ID
objvUserAnswerResultENT.AnswerTypeName = objvUserAnswerResultENS.AnswerTypeName; //答案类型名
objvUserAnswerResultENT.GridTitle = objvUserAnswerResultENS.GridTitle; //表格标题
objvUserAnswerResultENT.AnswerModeId = objvUserAnswerResultENS.AnswerModeId; //答案模式Id
objvUserAnswerResultENT.QuestionnaireSetName = objvUserAnswerResultENS.QuestionnaireSetName; //问卷集名
objvUserAnswerResultENT.QuestionScore = objvUserAnswerResultENS.QuestionScore; //题目得分
objvUserAnswerResultENT.RoleId = objvUserAnswerResultENS.RoleId; //角色Id
objvUserAnswerResultENT.RoleName = objvUserAnswerResultENS.RoleName; //角色名
objvUserAnswerResultENT.QuestionnaireSetId = objvUserAnswerResultENS.QuestionnaireSetId; //问卷集ID
objvUserAnswerResultENT.CourseId = objvUserAnswerResultENS.CourseId; //课程Id
objvUserAnswerResultENT.CourseName = objvUserAnswerResultENS.CourseName; //课程名称
objvUserAnswerResultENT.CourseExamPaperId = objvUserAnswerResultENS.CourseExamPaperId; //考卷流水号
objvUserAnswerResultENT.AnswerOptionId = objvUserAnswerResultENS.AnswerOptionId; //回答选项Id
objvUserAnswerResultENT.OptionName = objvUserAnswerResultENS.OptionName; //选项名称
objvUserAnswerResultENT.OptionIndex = objvUserAnswerResultENS.OptionIndex; //选项序号
objvUserAnswerResultENT.OptionTitle = objvUserAnswerResultENS.OptionTitle; //选项标题
objvUserAnswerResultENT.BatchId = objvUserAnswerResultENS.BatchId; //批次ID
objvUserAnswerResultENT.UserId = objvUserAnswerResultENS.UserId; //用户ID
objvUserAnswerResultENT.UserName = objvUserAnswerResultENS.UserName; //用户名
objvUserAnswerResultENT.AnswerText = objvUserAnswerResultENS.AnswerText; //回答文本
objvUserAnswerResultENT.AnswerDate = objvUserAnswerResultENS.AnswerDate; //回答日期
objvUserAnswerResultENT.AnswerTime = objvUserAnswerResultENS.AnswerTime; //回答时间
objvUserAnswerResultENT.AnswerIP = objvUserAnswerResultENS.AnswerIP; //回答IP
objvUserAnswerResultENT.IsAccess = objvUserAnswerResultENS.IsAccess; //IsAccess
objvUserAnswerResultENT.IsAccessC = objvUserAnswerResultENS.IsAccessC; //IsAccessC
objvUserAnswerResultENT.id_School = objvUserAnswerResultENS.id_School; //学校流水号
objvUserAnswerResultENT.School = objvUserAnswerResultENS.School; //School
objvUserAnswerResultENT.AnswerMode = objvUserAnswerResultENS.AnswerMode; //AnswerMode
objvUserAnswerResultENT.IsMarking = objvUserAnswerResultENS.IsMarking; //是否批阅
objvUserAnswerResultENT.IsRight = objvUserAnswerResultENS.IsRight; //是否正确
objvUserAnswerResultENT.Score = objvUserAnswerResultENS.Score; //得分
objvUserAnswerResultENT.MarkTime = objvUserAnswerResultENS.MarkTime; //批改时间
objvUserAnswerResultENT.MarkerId = objvUserAnswerResultENS.MarkerId; //打分者
objvUserAnswerResultENT.Comment = objvUserAnswerResultENS.Comment; //批注
objvUserAnswerResultENT.IsAccessKnowledge = objvUserAnswerResultENS.IsAccessKnowledge; //是否处理知识点
objvUserAnswerResultENT.UpdDate = objvUserAnswerResultENS.UpdDate; //修改日期
objvUserAnswerResultENT.UpdUser = objvUserAnswerResultENS.UpdUser; //修改人
objvUserAnswerResultENT.Memo = objvUserAnswerResultENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvUserAnswerResultEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvUserAnswerResultEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvUserAnswerResultEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvUserAnswerResultEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvUserAnswerResultEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvUserAnswerResultEN.AttributeName)
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
if (clsUserAnswerResultWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserAnswerResultWApi没有刷新缓存机制(clsUserAnswerResultWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUsersWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersWApi没有刷新缓存机制(clsUsersWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseWApi没有刷新缓存机制(clscc_CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionOptionsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionOptionsWApi没有刷新缓存机制(clsQuestionOptionsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by MinID");
//if (arrvUserAnswerResultObjLst_Cache == null)
//{
//arrvUserAnswerResultObjLst_Cache = await clsvUserAnswerResultWApi.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strCourseId = "")
{
string strMsg = "";
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvUserAnswerResultEN._CurrTabName_S, strCourseId);
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
public static List<clsvUserAnswerResultEN> GetObjLst_Cache(string strCourseId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvUserAnswerResultEN._CurrTabName_S, strCourseId);
List<clsvUserAnswerResultEN> arrvUserAnswerResultObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("CourseId='{0}'", strCourseId)); });
return arrvUserAnswerResultObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvUserAnswerResultEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convUserAnswerResult.MinID, Type.GetType("System.Int64"));
objDT.Columns.Add(convUserAnswerResult.QuestionID, Type.GetType("System.String"));
objDT.Columns.Add(convUserAnswerResult.QuestionIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convUserAnswerResult.QuestionName, Type.GetType("System.String"));
objDT.Columns.Add(convUserAnswerResult.QuestionNo, Type.GetType("System.String"));
objDT.Columns.Add(convUserAnswerResult.QuestionTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convUserAnswerResult.QuestionTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convUserAnswerResult.AnswerTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convUserAnswerResult.AnswerTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convUserAnswerResult.GridTitle, Type.GetType("System.String"));
objDT.Columns.Add(convUserAnswerResult.AnswerModeId, Type.GetType("System.String"));
objDT.Columns.Add(convUserAnswerResult.QuestionnaireSetName, Type.GetType("System.String"));
objDT.Columns.Add(convUserAnswerResult.QuestionScore, Type.GetType("System.Single"));
objDT.Columns.Add(convUserAnswerResult.RoleId, Type.GetType("System.String"));
objDT.Columns.Add(convUserAnswerResult.RoleName, Type.GetType("System.String"));
objDT.Columns.Add(convUserAnswerResult.QuestionnaireSetId, Type.GetType("System.String"));
objDT.Columns.Add(convUserAnswerResult.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convUserAnswerResult.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convUserAnswerResult.CourseExamPaperId, Type.GetType("System.String"));
objDT.Columns.Add(convUserAnswerResult.AnswerOptionId, Type.GetType("System.String"));
objDT.Columns.Add(convUserAnswerResult.OptionName, Type.GetType("System.String"));
objDT.Columns.Add(convUserAnswerResult.OptionIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convUserAnswerResult.OptionTitle, Type.GetType("System.String"));
objDT.Columns.Add(convUserAnswerResult.BatchId, Type.GetType("System.String"));
objDT.Columns.Add(convUserAnswerResult.UserId, Type.GetType("System.String"));
objDT.Columns.Add(convUserAnswerResult.UserName, Type.GetType("System.String"));
objDT.Columns.Add(convUserAnswerResult.AnswerText, Type.GetType("System.String"));
objDT.Columns.Add(convUserAnswerResult.AnswerDate, Type.GetType("System.String"));
objDT.Columns.Add(convUserAnswerResult.AnswerTime, Type.GetType("System.String"));
objDT.Columns.Add(convUserAnswerResult.AnswerIP, Type.GetType("System.String"));
objDT.Columns.Add(convUserAnswerResult.IsAccess, Type.GetType("System.Boolean"));
objDT.Columns.Add(convUserAnswerResult.IsAccessC, Type.GetType("System.Boolean"));
objDT.Columns.Add(convUserAnswerResult.id_School, Type.GetType("System.String"));
objDT.Columns.Add(convUserAnswerResult.School, Type.GetType("System.String"));
objDT.Columns.Add(convUserAnswerResult.AnswerMode, Type.GetType("System.Int32"));
objDT.Columns.Add(convUserAnswerResult.IsMarking, Type.GetType("System.Boolean"));
objDT.Columns.Add(convUserAnswerResult.IsRight, Type.GetType("System.Boolean"));
objDT.Columns.Add(convUserAnswerResult.Score, Type.GetType("System.Decimal"));
objDT.Columns.Add(convUserAnswerResult.MarkTime, Type.GetType("System.String"));
objDT.Columns.Add(convUserAnswerResult.MarkerId, Type.GetType("System.String"));
objDT.Columns.Add(convUserAnswerResult.Comment, Type.GetType("System.String"));
objDT.Columns.Add(convUserAnswerResult.IsAccessKnowledge, Type.GetType("System.Boolean"));
objDT.Columns.Add(convUserAnswerResult.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convUserAnswerResult.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convUserAnswerResult.Memo, Type.GetType("System.String"));
foreach (clsvUserAnswerResultEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convUserAnswerResult.MinID] = objInFor[convUserAnswerResult.MinID];
objDR[convUserAnswerResult.QuestionID] = objInFor[convUserAnswerResult.QuestionID];
objDR[convUserAnswerResult.QuestionIndex] = objInFor[convUserAnswerResult.QuestionIndex];
objDR[convUserAnswerResult.QuestionName] = objInFor[convUserAnswerResult.QuestionName];
objDR[convUserAnswerResult.QuestionNo] = objInFor[convUserAnswerResult.QuestionNo];
objDR[convUserAnswerResult.QuestionTypeId] = objInFor[convUserAnswerResult.QuestionTypeId];
objDR[convUserAnswerResult.QuestionTypeName] = objInFor[convUserAnswerResult.QuestionTypeName];
objDR[convUserAnswerResult.AnswerTypeId] = objInFor[convUserAnswerResult.AnswerTypeId];
objDR[convUserAnswerResult.AnswerTypeName] = objInFor[convUserAnswerResult.AnswerTypeName];
objDR[convUserAnswerResult.GridTitle] = objInFor[convUserAnswerResult.GridTitle];
objDR[convUserAnswerResult.AnswerModeId] = objInFor[convUserAnswerResult.AnswerModeId];
objDR[convUserAnswerResult.QuestionnaireSetName] = objInFor[convUserAnswerResult.QuestionnaireSetName];
objDR[convUserAnswerResult.QuestionScore] = objInFor[convUserAnswerResult.QuestionScore];
objDR[convUserAnswerResult.RoleId] = objInFor[convUserAnswerResult.RoleId];
objDR[convUserAnswerResult.RoleName] = objInFor[convUserAnswerResult.RoleName];
objDR[convUserAnswerResult.QuestionnaireSetId] = objInFor[convUserAnswerResult.QuestionnaireSetId];
objDR[convUserAnswerResult.CourseId] = objInFor[convUserAnswerResult.CourseId];
objDR[convUserAnswerResult.CourseName] = objInFor[convUserAnswerResult.CourseName];
objDR[convUserAnswerResult.CourseExamPaperId] = objInFor[convUserAnswerResult.CourseExamPaperId];
objDR[convUserAnswerResult.AnswerOptionId] = objInFor[convUserAnswerResult.AnswerOptionId];
objDR[convUserAnswerResult.OptionName] = objInFor[convUserAnswerResult.OptionName];
objDR[convUserAnswerResult.OptionIndex] = objInFor[convUserAnswerResult.OptionIndex];
objDR[convUserAnswerResult.OptionTitle] = objInFor[convUserAnswerResult.OptionTitle];
objDR[convUserAnswerResult.BatchId] = objInFor[convUserAnswerResult.BatchId];
objDR[convUserAnswerResult.UserId] = objInFor[convUserAnswerResult.UserId];
objDR[convUserAnswerResult.UserName] = objInFor[convUserAnswerResult.UserName];
objDR[convUserAnswerResult.AnswerText] = objInFor[convUserAnswerResult.AnswerText];
objDR[convUserAnswerResult.AnswerDate] = objInFor[convUserAnswerResult.AnswerDate];
objDR[convUserAnswerResult.AnswerTime] = objInFor[convUserAnswerResult.AnswerTime];
objDR[convUserAnswerResult.AnswerIP] = objInFor[convUserAnswerResult.AnswerIP];
objDR[convUserAnswerResult.IsAccess] = objInFor[convUserAnswerResult.IsAccess];
objDR[convUserAnswerResult.IsAccessC] = objInFor[convUserAnswerResult.IsAccessC];
objDR[convUserAnswerResult.id_School] = objInFor[convUserAnswerResult.id_School];
objDR[convUserAnswerResult.School] = objInFor[convUserAnswerResult.School];
objDR[convUserAnswerResult.AnswerMode] = objInFor[convUserAnswerResult.AnswerMode];
objDR[convUserAnswerResult.IsMarking] = objInFor[convUserAnswerResult.IsMarking];
objDR[convUserAnswerResult.IsRight] = objInFor[convUserAnswerResult.IsRight];
objDR[convUserAnswerResult.Score] = objInFor[convUserAnswerResult.Score];
objDR[convUserAnswerResult.MarkTime] = objInFor[convUserAnswerResult.MarkTime];
objDR[convUserAnswerResult.MarkerId] = objInFor[convUserAnswerResult.MarkerId];
objDR[convUserAnswerResult.Comment] = objInFor[convUserAnswerResult.Comment];
objDR[convUserAnswerResult.IsAccessKnowledge] = objInFor[convUserAnswerResult.IsAccessKnowledge];
objDR[convUserAnswerResult.UpdDate] = objInFor[convUserAnswerResult.UpdDate];
objDR[convUserAnswerResult.UpdUser] = objInFor[convUserAnswerResult.UpdUser];
objDR[convUserAnswerResult.Memo] = objInFor[convUserAnswerResult.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}