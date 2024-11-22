
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionStuFinishedStatusWApi
 表名:vQuestionStuFinishedStatus(01120218)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:45:48
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:查询统计
 模块英文名:QueryStatistics
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
public static class clsvQuestionStuFinishedStatusWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionStuFinishedStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionStuFinishedStatusEN Setid_CurrEduCls(this clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, convQuestionStuFinishedStatus.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, convQuestionStuFinishedStatus.id_CurrEduCls);
objvQuestionStuFinishedStatusEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionStuFinishedStatusEN.dicFldComparisonOp.ContainsKey(convQuestionStuFinishedStatus.id_CurrEduCls) == false)
{
objvQuestionStuFinishedStatusEN.dicFldComparisonOp.Add(convQuestionStuFinishedStatus.id_CurrEduCls, strComparisonOp);
}
else
{
objvQuestionStuFinishedStatusEN.dicFldComparisonOp[convQuestionStuFinishedStatus.id_CurrEduCls] = strComparisonOp;
}
}
return objvQuestionStuFinishedStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionStuFinishedStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionStuFinishedStatusEN SetEduClsName(this clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusEN, string strEduClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEduClsName, convQuestionStuFinishedStatus.EduClsName);
clsCheckSql.CheckFieldLen(strEduClsName, 100, convQuestionStuFinishedStatus.EduClsName);
objvQuestionStuFinishedStatusEN.EduClsName = strEduClsName; //教学班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionStuFinishedStatusEN.dicFldComparisonOp.ContainsKey(convQuestionStuFinishedStatus.EduClsName) == false)
{
objvQuestionStuFinishedStatusEN.dicFldComparisonOp.Add(convQuestionStuFinishedStatus.EduClsName, strComparisonOp);
}
else
{
objvQuestionStuFinishedStatusEN.dicFldComparisonOp[convQuestionStuFinishedStatus.EduClsName] = strComparisonOp;
}
}
return objvQuestionStuFinishedStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionStuFinishedStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionStuFinishedStatusEN SetCourseId(this clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convQuestionStuFinishedStatus.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convQuestionStuFinishedStatus.CourseId);
objvQuestionStuFinishedStatusEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionStuFinishedStatusEN.dicFldComparisonOp.ContainsKey(convQuestionStuFinishedStatus.CourseId) == false)
{
objvQuestionStuFinishedStatusEN.dicFldComparisonOp.Add(convQuestionStuFinishedStatus.CourseId, strComparisonOp);
}
else
{
objvQuestionStuFinishedStatusEN.dicFldComparisonOp[convQuestionStuFinishedStatus.CourseId] = strComparisonOp;
}
}
return objvQuestionStuFinishedStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionStuFinishedStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionStuFinishedStatusEN SetCourseName(this clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convQuestionStuFinishedStatus.CourseName);
objvQuestionStuFinishedStatusEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionStuFinishedStatusEN.dicFldComparisonOp.ContainsKey(convQuestionStuFinishedStatus.CourseName) == false)
{
objvQuestionStuFinishedStatusEN.dicFldComparisonOp.Add(convQuestionStuFinishedStatus.CourseName, strComparisonOp);
}
else
{
objvQuestionStuFinishedStatusEN.dicFldComparisonOp[convQuestionStuFinishedStatus.CourseName] = strComparisonOp;
}
}
return objvQuestionStuFinishedStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionStuFinishedStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionStuFinishedStatusEN SetCurrStuNum(this clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusEN, int intCurrStuNum, string strComparisonOp="")
	{
objvQuestionStuFinishedStatusEN.CurrStuNum = intCurrStuNum; //当前学生数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionStuFinishedStatusEN.dicFldComparisonOp.ContainsKey(convQuestionStuFinishedStatus.CurrStuNum) == false)
{
objvQuestionStuFinishedStatusEN.dicFldComparisonOp.Add(convQuestionStuFinishedStatus.CurrStuNum, strComparisonOp);
}
else
{
objvQuestionStuFinishedStatusEN.dicFldComparisonOp[convQuestionStuFinishedStatus.CurrStuNum] = strComparisonOp;
}
}
return objvQuestionStuFinishedStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionStuFinishedStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionStuFinishedStatusEN Setid_StudentInfo(this clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusEN, string strid_StudentInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_StudentInfo, convQuestionStuFinishedStatus.id_StudentInfo);
clsCheckSql.CheckFieldLen(strid_StudentInfo, 8, convQuestionStuFinishedStatus.id_StudentInfo);
clsCheckSql.CheckFieldForeignKey(strid_StudentInfo, 8, convQuestionStuFinishedStatus.id_StudentInfo);
objvQuestionStuFinishedStatusEN.id_StudentInfo = strid_StudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionStuFinishedStatusEN.dicFldComparisonOp.ContainsKey(convQuestionStuFinishedStatus.id_StudentInfo) == false)
{
objvQuestionStuFinishedStatusEN.dicFldComparisonOp.Add(convQuestionStuFinishedStatus.id_StudentInfo, strComparisonOp);
}
else
{
objvQuestionStuFinishedStatusEN.dicFldComparisonOp[convQuestionStuFinishedStatus.id_StudentInfo] = strComparisonOp;
}
}
return objvQuestionStuFinishedStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionStuFinishedStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionStuFinishedStatusEN SetStuID(this clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusEN, string strStuID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuID, 20, convQuestionStuFinishedStatus.StuID);
objvQuestionStuFinishedStatusEN.StuID = strStuID; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionStuFinishedStatusEN.dicFldComparisonOp.ContainsKey(convQuestionStuFinishedStatus.StuID) == false)
{
objvQuestionStuFinishedStatusEN.dicFldComparisonOp.Add(convQuestionStuFinishedStatus.StuID, strComparisonOp);
}
else
{
objvQuestionStuFinishedStatusEN.dicFldComparisonOp[convQuestionStuFinishedStatus.StuID] = strComparisonOp;
}
}
return objvQuestionStuFinishedStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionStuFinishedStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionStuFinishedStatusEN SetStuName(this clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusEN, string strStuName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strStuName, 50, convQuestionStuFinishedStatus.StuName);
objvQuestionStuFinishedStatusEN.StuName = strStuName; //姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionStuFinishedStatusEN.dicFldComparisonOp.ContainsKey(convQuestionStuFinishedStatus.StuName) == false)
{
objvQuestionStuFinishedStatusEN.dicFldComparisonOp.Add(convQuestionStuFinishedStatus.StuName, strComparisonOp);
}
else
{
objvQuestionStuFinishedStatusEN.dicFldComparisonOp[convQuestionStuFinishedStatus.StuName] = strComparisonOp;
}
}
return objvQuestionStuFinishedStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionStuFinishedStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionStuFinishedStatusEN SetSubmitedNum(this clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusEN, int intSubmitedNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intSubmitedNum, convQuestionStuFinishedStatus.SubmitedNum);
objvQuestionStuFinishedStatusEN.SubmitedNum = intSubmitedNum; //提交作业数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionStuFinishedStatusEN.dicFldComparisonOp.ContainsKey(convQuestionStuFinishedStatus.SubmitedNum) == false)
{
objvQuestionStuFinishedStatusEN.dicFldComparisonOp.Add(convQuestionStuFinishedStatus.SubmitedNum, strComparisonOp);
}
else
{
objvQuestionStuFinishedStatusEN.dicFldComparisonOp[convQuestionStuFinishedStatus.SubmitedNum] = strComparisonOp;
}
}
return objvQuestionStuFinishedStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionStuFinishedStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionStuFinishedStatusEN SetAllQuestionNum(this clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusEN, int intAllQuestionNum, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intAllQuestionNum, convQuestionStuFinishedStatus.AllQuestionNum);
objvQuestionStuFinishedStatusEN.AllQuestionNum = intAllQuestionNum; //所有题目数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionStuFinishedStatusEN.dicFldComparisonOp.ContainsKey(convQuestionStuFinishedStatus.AllQuestionNum) == false)
{
objvQuestionStuFinishedStatusEN.dicFldComparisonOp.Add(convQuestionStuFinishedStatus.AllQuestionNum, strComparisonOp);
}
else
{
objvQuestionStuFinishedStatusEN.dicFldComparisonOp[convQuestionStuFinishedStatus.AllQuestionNum] = strComparisonOp;
}
}
return objvQuestionStuFinishedStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionStuFinishedStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionStuFinishedStatusEN SetMarkedNum(this clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusEN, int intMarkedNum, string strComparisonOp="")
	{
objvQuestionStuFinishedStatusEN.MarkedNum = intMarkedNum; //已批改数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionStuFinishedStatusEN.dicFldComparisonOp.ContainsKey(convQuestionStuFinishedStatus.MarkedNum) == false)
{
objvQuestionStuFinishedStatusEN.dicFldComparisonOp.Add(convQuestionStuFinishedStatus.MarkedNum, strComparisonOp);
}
else
{
objvQuestionStuFinishedStatusEN.dicFldComparisonOp[convQuestionStuFinishedStatus.MarkedNum] = strComparisonOp;
}
}
return objvQuestionStuFinishedStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionStuFinishedStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionStuFinishedStatusEN SetNoMarkNum(this clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusEN, int intNoMarkNum, string strComparisonOp="")
	{
objvQuestionStuFinishedStatusEN.NoMarkNum = intNoMarkNum; //未批改数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionStuFinishedStatusEN.dicFldComparisonOp.ContainsKey(convQuestionStuFinishedStatus.NoMarkNum) == false)
{
objvQuestionStuFinishedStatusEN.dicFldComparisonOp.Add(convQuestionStuFinishedStatus.NoMarkNum, strComparisonOp);
}
else
{
objvQuestionStuFinishedStatusEN.dicFldComparisonOp[convQuestionStuFinishedStatus.NoMarkNum] = strComparisonOp;
}
}
return objvQuestionStuFinishedStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionStuFinishedStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionStuFinishedStatusEN SetNoSubmitedNum(this clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusEN, int intNoSubmitedNum, string strComparisonOp="")
	{
objvQuestionStuFinishedStatusEN.NoSubmitedNum = intNoSubmitedNum; //未提交作业数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionStuFinishedStatusEN.dicFldComparisonOp.ContainsKey(convQuestionStuFinishedStatus.NoSubmitedNum) == false)
{
objvQuestionStuFinishedStatusEN.dicFldComparisonOp.Add(convQuestionStuFinishedStatus.NoSubmitedNum, strComparisonOp);
}
else
{
objvQuestionStuFinishedStatusEN.dicFldComparisonOp[convQuestionStuFinishedStatus.NoSubmitedNum] = strComparisonOp;
}
}
return objvQuestionStuFinishedStatusEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatus_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQuestionStuFinishedStatus_Cond.IsUpdated(convQuestionStuFinishedStatus.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objvQuestionStuFinishedStatus_Cond.dicFldComparisonOp[convQuestionStuFinishedStatus.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionStuFinishedStatus.id_CurrEduCls, objvQuestionStuFinishedStatus_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objvQuestionStuFinishedStatus_Cond.IsUpdated(convQuestionStuFinishedStatus.EduClsName) == true)
{
string strComparisonOp_EduClsName = objvQuestionStuFinishedStatus_Cond.dicFldComparisonOp[convQuestionStuFinishedStatus.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionStuFinishedStatus.EduClsName, objvQuestionStuFinishedStatus_Cond.EduClsName, strComparisonOp_EduClsName);
}
if (objvQuestionStuFinishedStatus_Cond.IsUpdated(convQuestionStuFinishedStatus.CourseId) == true)
{
string strComparisonOp_CourseId = objvQuestionStuFinishedStatus_Cond.dicFldComparisonOp[convQuestionStuFinishedStatus.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionStuFinishedStatus.CourseId, objvQuestionStuFinishedStatus_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvQuestionStuFinishedStatus_Cond.IsUpdated(convQuestionStuFinishedStatus.CourseName) == true)
{
string strComparisonOp_CourseName = objvQuestionStuFinishedStatus_Cond.dicFldComparisonOp[convQuestionStuFinishedStatus.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionStuFinishedStatus.CourseName, objvQuestionStuFinishedStatus_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvQuestionStuFinishedStatus_Cond.IsUpdated(convQuestionStuFinishedStatus.CurrStuNum) == true)
{
string strComparisonOp_CurrStuNum = objvQuestionStuFinishedStatus_Cond.dicFldComparisonOp[convQuestionStuFinishedStatus.CurrStuNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionStuFinishedStatus.CurrStuNum, objvQuestionStuFinishedStatus_Cond.CurrStuNum, strComparisonOp_CurrStuNum);
}
if (objvQuestionStuFinishedStatus_Cond.IsUpdated(convQuestionStuFinishedStatus.id_StudentInfo) == true)
{
string strComparisonOp_id_StudentInfo = objvQuestionStuFinishedStatus_Cond.dicFldComparisonOp[convQuestionStuFinishedStatus.id_StudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionStuFinishedStatus.id_StudentInfo, objvQuestionStuFinishedStatus_Cond.id_StudentInfo, strComparisonOp_id_StudentInfo);
}
if (objvQuestionStuFinishedStatus_Cond.IsUpdated(convQuestionStuFinishedStatus.StuID) == true)
{
string strComparisonOp_StuID = objvQuestionStuFinishedStatus_Cond.dicFldComparisonOp[convQuestionStuFinishedStatus.StuID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionStuFinishedStatus.StuID, objvQuestionStuFinishedStatus_Cond.StuID, strComparisonOp_StuID);
}
if (objvQuestionStuFinishedStatus_Cond.IsUpdated(convQuestionStuFinishedStatus.StuName) == true)
{
string strComparisonOp_StuName = objvQuestionStuFinishedStatus_Cond.dicFldComparisonOp[convQuestionStuFinishedStatus.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionStuFinishedStatus.StuName, objvQuestionStuFinishedStatus_Cond.StuName, strComparisonOp_StuName);
}
if (objvQuestionStuFinishedStatus_Cond.IsUpdated(convQuestionStuFinishedStatus.SubmitedNum) == true)
{
string strComparisonOp_SubmitedNum = objvQuestionStuFinishedStatus_Cond.dicFldComparisonOp[convQuestionStuFinishedStatus.SubmitedNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionStuFinishedStatus.SubmitedNum, objvQuestionStuFinishedStatus_Cond.SubmitedNum, strComparisonOp_SubmitedNum);
}
if (objvQuestionStuFinishedStatus_Cond.IsUpdated(convQuestionStuFinishedStatus.AllQuestionNum) == true)
{
string strComparisonOp_AllQuestionNum = objvQuestionStuFinishedStatus_Cond.dicFldComparisonOp[convQuestionStuFinishedStatus.AllQuestionNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionStuFinishedStatus.AllQuestionNum, objvQuestionStuFinishedStatus_Cond.AllQuestionNum, strComparisonOp_AllQuestionNum);
}
if (objvQuestionStuFinishedStatus_Cond.IsUpdated(convQuestionStuFinishedStatus.MarkedNum) == true)
{
string strComparisonOp_MarkedNum = objvQuestionStuFinishedStatus_Cond.dicFldComparisonOp[convQuestionStuFinishedStatus.MarkedNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionStuFinishedStatus.MarkedNum, objvQuestionStuFinishedStatus_Cond.MarkedNum, strComparisonOp_MarkedNum);
}
if (objvQuestionStuFinishedStatus_Cond.IsUpdated(convQuestionStuFinishedStatus.NoMarkNum) == true)
{
string strComparisonOp_NoMarkNum = objvQuestionStuFinishedStatus_Cond.dicFldComparisonOp[convQuestionStuFinishedStatus.NoMarkNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionStuFinishedStatus.NoMarkNum, objvQuestionStuFinishedStatus_Cond.NoMarkNum, strComparisonOp_NoMarkNum);
}
if (objvQuestionStuFinishedStatus_Cond.IsUpdated(convQuestionStuFinishedStatus.NoSubmitedNum) == true)
{
string strComparisonOp_NoSubmitedNum = objvQuestionStuFinishedStatus_Cond.dicFldComparisonOp[convQuestionStuFinishedStatus.NoSubmitedNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionStuFinishedStatus.NoSubmitedNum, objvQuestionStuFinishedStatus_Cond.NoSubmitedNum, strComparisonOp_NoSubmitedNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v题目学生完成状态(vQuestionStuFinishedStatus)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQuestionStuFinishedStatusWApi
{
private static readonly string mstrApiControllerName = "vQuestionStuFinishedStatusApi";

 public clsvQuestionStuFinishedStatusWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strid_CurrEduCls">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionStuFinishedStatusEN GetObjByid_CurrEduCls(string strid_CurrEduCls)
{
string strAction = "GetObjByid_CurrEduCls";
string strErrMsg = string.Empty;
string strResult = "";
clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CurrEduCls"] = strid_CurrEduCls
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvQuestionStuFinishedStatusEN = JsonConvert.DeserializeObject<clsvQuestionStuFinishedStatusEN>((string)jobjReturn["ReturnObj"]);
return objvQuestionStuFinishedStatusEN;
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
 /// <param name = "strid_CurrEduCls">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionStuFinishedStatusEN GetObjByid_CurrEduCls_WA_Cache(string strid_CurrEduCls, string strCourseId)
{
string strAction = "GetObjByid_CurrEduCls_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CurrEduCls"] = strid_CurrEduCls,
["CourseId"] = strCourseId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvQuestionStuFinishedStatusEN = JsonConvert.DeserializeObject<clsvQuestionStuFinishedStatusEN>((string)jobjReturn["ReturnObj"]);
return objvQuestionStuFinishedStatusEN;
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
public static clsvQuestionStuFinishedStatusEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusEN = null;
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
objvQuestionStuFinishedStatusEN = JsonConvert.DeserializeObject<clsvQuestionStuFinishedStatusEN>((string)jobjReturn["ReturnObj"]);
return objvQuestionStuFinishedStatusEN;
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
 /// <param name = "strid_CurrEduCls">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQuestionStuFinishedStatusEN GetObjByid_CurrEduCls_Cache(string strid_CurrEduCls, string strCourseId)
{
if (string.IsNullOrEmpty(strid_CurrEduCls) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvQuestionStuFinishedStatusEN._CurrTabName_S, strCourseId);
List<clsvQuestionStuFinishedStatusEN> arrvQuestionStuFinishedStatusObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvQuestionStuFinishedStatusEN> arrvQuestionStuFinishedStatusObjLst_Sel =
from objvQuestionStuFinishedStatusEN in arrvQuestionStuFinishedStatusObjLst_Cache
where objvQuestionStuFinishedStatusEN.id_CurrEduCls == strid_CurrEduCls
select objvQuestionStuFinishedStatusEN;
if (arrvQuestionStuFinishedStatusObjLst_Sel.Count() == 0)
{
   clsvQuestionStuFinishedStatusEN obj = clsvQuestionStuFinishedStatusWApi.GetObjByid_CurrEduCls(strid_CurrEduCls);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvQuestionStuFinishedStatusObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionStuFinishedStatusEN> GetObjLst(string strWhereCond)
{
 List<clsvQuestionStuFinishedStatusEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionStuFinishedStatusEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionStuFinishedStatusEN> GetObjLstById_CurrEduClsLst(List<string> arrId_CurrEduCls)
{
 List<clsvQuestionStuFinishedStatusEN> arrObjLst = null; 
string strAction = "GetObjLstById_CurrEduClsLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CurrEduCls);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionStuFinishedStatusEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strid_CurrEduCls">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvQuestionStuFinishedStatusEN> GetObjLstById_CurrEduClsLst_Cache(List<string> arrId_CurrEduCls, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvQuestionStuFinishedStatusEN._CurrTabName_S, strCourseId);
List<clsvQuestionStuFinishedStatusEN> arrvQuestionStuFinishedStatusObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvQuestionStuFinishedStatusEN> arrvQuestionStuFinishedStatusObjLst_Sel =
from objvQuestionStuFinishedStatusEN in arrvQuestionStuFinishedStatusObjLst_Cache
where arrId_CurrEduCls.Contains(objvQuestionStuFinishedStatusEN.id_CurrEduCls)
select objvQuestionStuFinishedStatusEN;
return arrvQuestionStuFinishedStatusObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionStuFinishedStatusEN> GetObjLstById_CurrEduClsLst_WA_Cache(List<string> arrId_CurrEduCls, string strCourseId)
{
 List<clsvQuestionStuFinishedStatusEN> arrObjLst = null; 
string strAction = "GetObjLstById_CurrEduClsLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseId"] = strCourseId
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_CurrEduCls);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionStuFinishedStatusEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionStuFinishedStatusEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQuestionStuFinishedStatusEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionStuFinishedStatusEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionStuFinishedStatusEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQuestionStuFinishedStatusEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionStuFinishedStatusEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionStuFinishedStatusEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQuestionStuFinishedStatusEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionStuFinishedStatusEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionStuFinishedStatusEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvQuestionStuFinishedStatusEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionStuFinishedStatusEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strid_CurrEduCls)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_CurrEduCls"] = strid_CurrEduCls
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
 /// <param name = "objvQuestionStuFinishedStatusENS">源对象</param>
 /// <param name = "objvQuestionStuFinishedStatusENT">目标对象</param>
 public static void CopyTo(clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusENS, clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusENT)
{
try
{
objvQuestionStuFinishedStatusENT.id_CurrEduCls = objvQuestionStuFinishedStatusENS.id_CurrEduCls; //当前教学班流水号
objvQuestionStuFinishedStatusENT.EduClsName = objvQuestionStuFinishedStatusENS.EduClsName; //教学班名称
objvQuestionStuFinishedStatusENT.CourseId = objvQuestionStuFinishedStatusENS.CourseId; //课程Id
objvQuestionStuFinishedStatusENT.CourseName = objvQuestionStuFinishedStatusENS.CourseName; //课程名称
objvQuestionStuFinishedStatusENT.CurrStuNum = objvQuestionStuFinishedStatusENS.CurrStuNum; //当前学生数
objvQuestionStuFinishedStatusENT.id_StudentInfo = objvQuestionStuFinishedStatusENS.id_StudentInfo; //学生流水号
objvQuestionStuFinishedStatusENT.StuID = objvQuestionStuFinishedStatusENS.StuID; //学号
objvQuestionStuFinishedStatusENT.StuName = objvQuestionStuFinishedStatusENS.StuName; //姓名
objvQuestionStuFinishedStatusENT.SubmitedNum = objvQuestionStuFinishedStatusENS.SubmitedNum; //提交作业数
objvQuestionStuFinishedStatusENT.AllQuestionNum = objvQuestionStuFinishedStatusENS.AllQuestionNum; //所有题目数
objvQuestionStuFinishedStatusENT.MarkedNum = objvQuestionStuFinishedStatusENS.MarkedNum; //已批改数
objvQuestionStuFinishedStatusENT.NoMarkNum = objvQuestionStuFinishedStatusENS.NoMarkNum; //未批改数
objvQuestionStuFinishedStatusENT.NoSubmitedNum = objvQuestionStuFinishedStatusENS.NoSubmitedNum; //未提交作业数
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
public static DataTable ToDataTable(List<clsvQuestionStuFinishedStatusEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQuestionStuFinishedStatusEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQuestionStuFinishedStatusEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQuestionStuFinishedStatusEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQuestionStuFinishedStatusEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQuestionStuFinishedStatusEN.AttributeName)
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
if (clsStudentInfoWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudentInfoWApi没有刷新缓存机制(clsStudentInfoWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionStuFinishedStatusWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionStuFinishedStatusWApi没有刷新缓存机制(clsQuestionStuFinishedStatusWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseTypeWApi没有刷新缓存机制(clscc_CourseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsCurrEduClsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCurrEduClsWApi没有刷新缓存机制(clsCurrEduClsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzGradeBaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseWApi没有刷新缓存机制(clsXzGradeBaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsgs_EduClsTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_EduClsTypeWApi没有刷新缓存机制(clsgs_EduClsTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseWApi没有刷新缓存机制(clscc_CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsTeachingSolutionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachingSolutionWApi没有刷新缓存机制(clsTeachingSolutionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseIsLikeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeWApi没有刷新缓存机制(clscc_CourseIsLikeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeacherInfoWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeacherInfoWApi没有刷新缓存机制(clsTeacherInfoWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzUniZoneWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzUniZoneWApi没有刷新缓存机制(clsXzUniZoneWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDiscipline_psWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDiscipline_psWApi没有刷新缓存机制(clsDiscipline_psWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsStaffTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsStaffTypeWApi没有刷新缓存机制(clsRsStaffTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzSchool_PsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzSchool_PsWApi没有刷新缓存机制(clsXzSchool_PsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSexWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSexWApi没有刷新缓存机制(clsSexWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsProfGradeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsProfGradeWApi没有刷新缓存机制(clsRsProfGradeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsEthnicWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsEthnicWApi没有刷新缓存机制(clsRsEthnicWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsDegreeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsDegreeWApi没有刷新缓存机制(clsRsDegreeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsProvinceWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsProvinceWApi没有刷新缓存机制(clsRsProvinceWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsReligionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsReligionWApi没有刷新缓存机制(clsRsReligionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsQualifWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsQualifWApi没有刷新缓存机制(clsRsQualifWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsPoliticsWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsPoliticsWApi没有刷新缓存机制(clsRsPoliticsWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsAdminGradeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsAdminGradeWApi没有刷新缓存机制(clsRsAdminGradeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_CurrEduCls");
//if (arrvQuestionStuFinishedStatusObjLst_Cache == null)
//{
//arrvQuestionStuFinishedStatusObjLst_Cache = await clsvQuestionStuFinishedStatusWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}_{1}", clsvQuestionStuFinishedStatusEN._CurrTabName_S, strCourseId);
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
public static List<clsvQuestionStuFinishedStatusEN> GetObjLst_Cache(string strCourseId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvQuestionStuFinishedStatusEN._CurrTabName_S, strCourseId);
List<clsvQuestionStuFinishedStatusEN> arrvQuestionStuFinishedStatusObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("CourseId='{0}'", strCourseId)); });
return arrvQuestionStuFinishedStatusObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvQuestionStuFinishedStatusEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQuestionStuFinishedStatus.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionStuFinishedStatus.EduClsName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionStuFinishedStatus.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionStuFinishedStatus.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionStuFinishedStatus.CurrStuNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convQuestionStuFinishedStatus.id_StudentInfo, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionStuFinishedStatus.StuID, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionStuFinishedStatus.StuName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionStuFinishedStatus.SubmitedNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convQuestionStuFinishedStatus.AllQuestionNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convQuestionStuFinishedStatus.MarkedNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convQuestionStuFinishedStatus.NoMarkNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convQuestionStuFinishedStatus.NoSubmitedNum, Type.GetType("System.Int32"));
foreach (clsvQuestionStuFinishedStatusEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQuestionStuFinishedStatus.id_CurrEduCls] = objInFor[convQuestionStuFinishedStatus.id_CurrEduCls];
objDR[convQuestionStuFinishedStatus.EduClsName] = objInFor[convQuestionStuFinishedStatus.EduClsName];
objDR[convQuestionStuFinishedStatus.CourseId] = objInFor[convQuestionStuFinishedStatus.CourseId];
objDR[convQuestionStuFinishedStatus.CourseName] = objInFor[convQuestionStuFinishedStatus.CourseName];
objDR[convQuestionStuFinishedStatus.CurrStuNum] = objInFor[convQuestionStuFinishedStatus.CurrStuNum];
objDR[convQuestionStuFinishedStatus.id_StudentInfo] = objInFor[convQuestionStuFinishedStatus.id_StudentInfo];
objDR[convQuestionStuFinishedStatus.StuID] = objInFor[convQuestionStuFinishedStatus.StuID];
objDR[convQuestionStuFinishedStatus.StuName] = objInFor[convQuestionStuFinishedStatus.StuName];
objDR[convQuestionStuFinishedStatus.SubmitedNum] = objInFor[convQuestionStuFinishedStatus.SubmitedNum];
objDR[convQuestionStuFinishedStatus.AllQuestionNum] = objInFor[convQuestionStuFinishedStatus.AllQuestionNum];
objDR[convQuestionStuFinishedStatus.MarkedNum] = objInFor[convQuestionStuFinishedStatus.MarkedNum];
objDR[convQuestionStuFinishedStatus.NoMarkNum] = objInFor[convQuestionStuFinishedStatus.NoMarkNum];
objDR[convQuestionStuFinishedStatus.NoSubmitedNum] = objInFor[convQuestionStuFinishedStatus.NoSubmitedNum];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}