
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionStuFinishedStatusBL
 表名:vQuestionStuFinishedStatus(01120218)
 * 版本:2024.02.19.1(服务器:WIN-SRV103-116)
 日期:2024/02/27 16:24:51
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:查询统计(QueryStatistics)
 框架-层名:业务逻辑层(CS)(BusinessLogic)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using Newtonsoft.Json;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.json;
using com.taishsoft.dynamiccompiler;
using com.taishsoft.datetime;
using ExamLib.Entity;
using System.Data; 
using System.Data.SqlClient; 
using ExamLib.DAL;

namespace ExamLib.BusinessLogic
{
public static class  clsvQuestionStuFinishedStatusBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strIdCurrEduCls">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionStuFinishedStatusEN GetObj(this K_IdCurrEduCls_vQuestionStuFinishedStatus myKey)
{
clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusEN = clsvQuestionStuFinishedStatusBL.vQuestionStuFinishedStatusDA.GetObjByIdCurrEduCls(myKey.Value);
return objvQuestionStuFinishedStatusEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionStuFinishedStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionStuFinishedStatusEN SetIdCurrEduCls(this clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusEN, string strIdCurrEduCls, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCurrEduCls, 8, convQuestionStuFinishedStatus.IdCurrEduCls);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCurrEduCls, 8, convQuestionStuFinishedStatus.IdCurrEduCls);
}
objvQuestionStuFinishedStatusEN.IdCurrEduCls = strIdCurrEduCls; //教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionStuFinishedStatusEN.dicFldComparisonOp.ContainsKey(convQuestionStuFinishedStatus.IdCurrEduCls) == false)
{
objvQuestionStuFinishedStatusEN.dicFldComparisonOp.Add(convQuestionStuFinishedStatus.IdCurrEduCls, strComparisonOp);
}
else
{
objvQuestionStuFinishedStatusEN.dicFldComparisonOp[convQuestionStuFinishedStatus.IdCurrEduCls] = strComparisonOp;
}
}
return objvQuestionStuFinishedStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionStuFinishedStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionStuFinishedStatusEN SetEduClsName(this clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusEN, string strEduClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEduClsName, convQuestionStuFinishedStatus.EduClsName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strEduClsName, 100, convQuestionStuFinishedStatus.EduClsName);
}
objvQuestionStuFinishedStatusEN.EduClsName = strEduClsName; //教学班名
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionStuFinishedStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionStuFinishedStatusEN SetCourseId(this clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convQuestionStuFinishedStatus.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convQuestionStuFinishedStatus.CourseId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionStuFinishedStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionStuFinishedStatusEN SetCourseName(this clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convQuestionStuFinishedStatus.CourseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionStuFinishedStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionStuFinishedStatusEN SetCurrStuNum(this clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusEN, int? intCurrStuNum, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionStuFinishedStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionStuFinishedStatusEN SetIdStudentInfo(this clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusEN, string strIdStudentInfo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdStudentInfo, convQuestionStuFinishedStatus.IdStudentInfo);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdStudentInfo, 8, convQuestionStuFinishedStatus.IdStudentInfo);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdStudentInfo, 8, convQuestionStuFinishedStatus.IdStudentInfo);
}
objvQuestionStuFinishedStatusEN.IdStudentInfo = strIdStudentInfo; //学生流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionStuFinishedStatusEN.dicFldComparisonOp.ContainsKey(convQuestionStuFinishedStatus.IdStudentInfo) == false)
{
objvQuestionStuFinishedStatusEN.dicFldComparisonOp.Add(convQuestionStuFinishedStatus.IdStudentInfo, strComparisonOp);
}
else
{
objvQuestionStuFinishedStatusEN.dicFldComparisonOp[convQuestionStuFinishedStatus.IdStudentInfo] = strComparisonOp;
}
}
return objvQuestionStuFinishedStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionStuFinishedStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionStuFinishedStatusEN SetStuId(this clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusEN, string strStuId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuId, 20, convQuestionStuFinishedStatus.StuId);
}
objvQuestionStuFinishedStatusEN.StuId = strStuId; //学号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionStuFinishedStatusEN.dicFldComparisonOp.ContainsKey(convQuestionStuFinishedStatus.StuId) == false)
{
objvQuestionStuFinishedStatusEN.dicFldComparisonOp.Add(convQuestionStuFinishedStatus.StuId, strComparisonOp);
}
else
{
objvQuestionStuFinishedStatusEN.dicFldComparisonOp[convQuestionStuFinishedStatus.StuId] = strComparisonOp;
}
}
return objvQuestionStuFinishedStatusEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionStuFinishedStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionStuFinishedStatusEN SetStuName(this clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusEN, string strStuName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strStuName, 50, convQuestionStuFinishedStatus.StuName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionStuFinishedStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionStuFinishedStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionStuFinishedStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionStuFinishedStatusEN SetMarkedNum(this clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusEN, int? intMarkedNum, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionStuFinishedStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionStuFinishedStatusEN SetNoMarkNum(this clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusEN, int? intNoMarkNum, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionStuFinishedStatusEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionStuFinishedStatusEN SetNoSubmitedNum(this clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusEN, int? intNoSubmitedNum, string strComparisonOp="")
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQuestionStuFinishedStatusENS">源对象</param>
 /// <param name = "objvQuestionStuFinishedStatusENT">目标对象</param>
 public static void CopyTo(this clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusENS, clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusENT)
{
try
{
objvQuestionStuFinishedStatusENT.IdCurrEduCls = objvQuestionStuFinishedStatusENS.IdCurrEduCls; //教学班流水号
objvQuestionStuFinishedStatusENT.EduClsName = objvQuestionStuFinishedStatusENS.EduClsName; //教学班名
objvQuestionStuFinishedStatusENT.CourseId = objvQuestionStuFinishedStatusENS.CourseId; //课程Id
objvQuestionStuFinishedStatusENT.CourseName = objvQuestionStuFinishedStatusENS.CourseName; //课程名称
objvQuestionStuFinishedStatusENT.CurrStuNum = objvQuestionStuFinishedStatusENS.CurrStuNum; //当前学生数
objvQuestionStuFinishedStatusENT.IdStudentInfo = objvQuestionStuFinishedStatusENS.IdStudentInfo; //学生流水号
objvQuestionStuFinishedStatusENT.StuId = objvQuestionStuFinishedStatusENS.StuId; //学号
objvQuestionStuFinishedStatusENT.StuName = objvQuestionStuFinishedStatusENS.StuName; //姓名
objvQuestionStuFinishedStatusENT.SubmitedNum = objvQuestionStuFinishedStatusENS.SubmitedNum; //提交作业数
objvQuestionStuFinishedStatusENT.AllQuestionNum = objvQuestionStuFinishedStatusENS.AllQuestionNum; //所有题目数
objvQuestionStuFinishedStatusENT.MarkedNum = objvQuestionStuFinishedStatusENS.MarkedNum; //已批改数
objvQuestionStuFinishedStatusENT.NoMarkNum = objvQuestionStuFinishedStatusENS.NoMarkNum; //未批改数
objvQuestionStuFinishedStatusENT.NoSubmitedNum = objvQuestionStuFinishedStatusENS.NoSubmitedNum; //未提交作业数
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000166)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyTo)
 /// </summary>
 /// <param name = "objvQuestionStuFinishedStatusENS">源对象</param>
 /// <returns>目标对象=>clsvQuestionStuFinishedStatusEN:objvQuestionStuFinishedStatusENT</returns>
 public static clsvQuestionStuFinishedStatusEN CopyTo(this clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusENS)
{
try
{
 clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusENT = new clsvQuestionStuFinishedStatusEN()
{
IdCurrEduCls = objvQuestionStuFinishedStatusENS.IdCurrEduCls, //教学班流水号
EduClsName = objvQuestionStuFinishedStatusENS.EduClsName, //教学班名
CourseId = objvQuestionStuFinishedStatusENS.CourseId, //课程Id
CourseName = objvQuestionStuFinishedStatusENS.CourseName, //课程名称
CurrStuNum = objvQuestionStuFinishedStatusENS.CurrStuNum, //当前学生数
IdStudentInfo = objvQuestionStuFinishedStatusENS.IdStudentInfo, //学生流水号
StuId = objvQuestionStuFinishedStatusENS.StuId, //学号
StuName = objvQuestionStuFinishedStatusENS.StuName, //姓名
SubmitedNum = objvQuestionStuFinishedStatusENS.SubmitedNum, //提交作业数
AllQuestionNum = objvQuestionStuFinishedStatusENS.AllQuestionNum, //所有题目数
MarkedNum = objvQuestionStuFinishedStatusENS.MarkedNum, //已批改数
NoMarkNum = objvQuestionStuFinishedStatusENS.NoMarkNum, //未批改数
NoSubmitedNum = objvQuestionStuFinishedStatusENS.NoSubmitedNum, //未提交作业数
};
 return objvQuestionStuFinishedStatusENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000167)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusEN)
{
 clsvQuestionStuFinishedStatusBL.vQuestionStuFinishedStatusDA.CheckProperty4Condition(objvQuestionStuFinishedStatusEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQuestionStuFinishedStatusCond.IsUpdated(convQuestionStuFinishedStatus.IdCurrEduCls) == true)
{
string strComparisonOpIdCurrEduCls = objvQuestionStuFinishedStatusCond.dicFldComparisonOp[convQuestionStuFinishedStatus.IdCurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionStuFinishedStatus.IdCurrEduCls, objvQuestionStuFinishedStatusCond.IdCurrEduCls, strComparisonOpIdCurrEduCls);
}
if (objvQuestionStuFinishedStatusCond.IsUpdated(convQuestionStuFinishedStatus.EduClsName) == true)
{
string strComparisonOpEduClsName = objvQuestionStuFinishedStatusCond.dicFldComparisonOp[convQuestionStuFinishedStatus.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionStuFinishedStatus.EduClsName, objvQuestionStuFinishedStatusCond.EduClsName, strComparisonOpEduClsName);
}
if (objvQuestionStuFinishedStatusCond.IsUpdated(convQuestionStuFinishedStatus.CourseId) == true)
{
string strComparisonOpCourseId = objvQuestionStuFinishedStatusCond.dicFldComparisonOp[convQuestionStuFinishedStatus.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionStuFinishedStatus.CourseId, objvQuestionStuFinishedStatusCond.CourseId, strComparisonOpCourseId);
}
if (objvQuestionStuFinishedStatusCond.IsUpdated(convQuestionStuFinishedStatus.CourseName) == true)
{
string strComparisonOpCourseName = objvQuestionStuFinishedStatusCond.dicFldComparisonOp[convQuestionStuFinishedStatus.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionStuFinishedStatus.CourseName, objvQuestionStuFinishedStatusCond.CourseName, strComparisonOpCourseName);
}
if (objvQuestionStuFinishedStatusCond.IsUpdated(convQuestionStuFinishedStatus.CurrStuNum) == true)
{
string strComparisonOpCurrStuNum = objvQuestionStuFinishedStatusCond.dicFldComparisonOp[convQuestionStuFinishedStatus.CurrStuNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionStuFinishedStatus.CurrStuNum, objvQuestionStuFinishedStatusCond.CurrStuNum, strComparisonOpCurrStuNum);
}
if (objvQuestionStuFinishedStatusCond.IsUpdated(convQuestionStuFinishedStatus.IdStudentInfo) == true)
{
string strComparisonOpIdStudentInfo = objvQuestionStuFinishedStatusCond.dicFldComparisonOp[convQuestionStuFinishedStatus.IdStudentInfo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionStuFinishedStatus.IdStudentInfo, objvQuestionStuFinishedStatusCond.IdStudentInfo, strComparisonOpIdStudentInfo);
}
if (objvQuestionStuFinishedStatusCond.IsUpdated(convQuestionStuFinishedStatus.StuId) == true)
{
string strComparisonOpStuId = objvQuestionStuFinishedStatusCond.dicFldComparisonOp[convQuestionStuFinishedStatus.StuId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionStuFinishedStatus.StuId, objvQuestionStuFinishedStatusCond.StuId, strComparisonOpStuId);
}
if (objvQuestionStuFinishedStatusCond.IsUpdated(convQuestionStuFinishedStatus.StuName) == true)
{
string strComparisonOpStuName = objvQuestionStuFinishedStatusCond.dicFldComparisonOp[convQuestionStuFinishedStatus.StuName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionStuFinishedStatus.StuName, objvQuestionStuFinishedStatusCond.StuName, strComparisonOpStuName);
}
if (objvQuestionStuFinishedStatusCond.IsUpdated(convQuestionStuFinishedStatus.SubmitedNum) == true)
{
string strComparisonOpSubmitedNum = objvQuestionStuFinishedStatusCond.dicFldComparisonOp[convQuestionStuFinishedStatus.SubmitedNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionStuFinishedStatus.SubmitedNum, objvQuestionStuFinishedStatusCond.SubmitedNum, strComparisonOpSubmitedNum);
}
if (objvQuestionStuFinishedStatusCond.IsUpdated(convQuestionStuFinishedStatus.AllQuestionNum) == true)
{
string strComparisonOpAllQuestionNum = objvQuestionStuFinishedStatusCond.dicFldComparisonOp[convQuestionStuFinishedStatus.AllQuestionNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionStuFinishedStatus.AllQuestionNum, objvQuestionStuFinishedStatusCond.AllQuestionNum, strComparisonOpAllQuestionNum);
}
if (objvQuestionStuFinishedStatusCond.IsUpdated(convQuestionStuFinishedStatus.MarkedNum) == true)
{
string strComparisonOpMarkedNum = objvQuestionStuFinishedStatusCond.dicFldComparisonOp[convQuestionStuFinishedStatus.MarkedNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionStuFinishedStatus.MarkedNum, objvQuestionStuFinishedStatusCond.MarkedNum, strComparisonOpMarkedNum);
}
if (objvQuestionStuFinishedStatusCond.IsUpdated(convQuestionStuFinishedStatus.NoMarkNum) == true)
{
string strComparisonOpNoMarkNum = objvQuestionStuFinishedStatusCond.dicFldComparisonOp[convQuestionStuFinishedStatus.NoMarkNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionStuFinishedStatus.NoMarkNum, objvQuestionStuFinishedStatusCond.NoMarkNum, strComparisonOpNoMarkNum);
}
if (objvQuestionStuFinishedStatusCond.IsUpdated(convQuestionStuFinishedStatus.NoSubmitedNum) == true)
{
string strComparisonOpNoSubmitedNum = objvQuestionStuFinishedStatusCond.dicFldComparisonOp[convQuestionStuFinishedStatus.NoSubmitedNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionStuFinishedStatus.NoSubmitedNum, objvQuestionStuFinishedStatusCond.NoSubmitedNum, strComparisonOpNoSubmitedNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQuestionStuFinishedStatus
{
public virtual bool UpdRelaTabDate(string strIdCurrEduCls, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v题目学生完成状态(vQuestionStuFinishedStatus)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQuestionStuFinishedStatusBL
{
public static RelatedActions_vQuestionStuFinishedStatus relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQuestionStuFinishedStatusDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQuestionStuFinishedStatusDA vQuestionStuFinishedStatusDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQuestionStuFinishedStatusDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQuestionStuFinishedStatusBL()
 {
 }

 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSpecSQLObj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public static clsSpecSQLforSql GetSpecSQLObj() 
{
if (clsSysParaEN.objLog == null)
{
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象!");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象!");
}
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName == true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
if (string.IsNullOrEmpty(clsvQuestionStuFinishedStatusEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQuestionStuFinishedStatusEN._ConnectString);
}
return objSQL;
}



 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_vQuestionStuFinishedStatus(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQuestionStuFinishedStatusDA.GetDataTable_vQuestionStuFinishedStatus(strWhereCond);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000005)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQuestionStuFinishedStatusDA.GetDataTable(strWhereCond);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vQuestionStuFinishedStatusDA.GetDataTable(strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000007)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName)
{
DataTable objDT;
try
{
objDT = vQuestionStuFinishedStatusDA.GetDataTable(strWhereCond, strTabName);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000061)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vQuestionStuFinishedStatusDA.GetDataTable(strWhereCond, strTabName, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000062)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_Top(stuTopPara objTopPara)
{
DataTable objDT;
try
{
objDT = vQuestionStuFinishedStatusDA.GetDataTable_Top(objTopPara);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000009)获取表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
objTopPara.whereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vQuestionStuFinishedStatusDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000010)获取表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
DataTable objDT;
try
{
objDT = vQuestionStuFinishedStatusDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000012)获取分页表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vQuestionStuFinishedStatusDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000013)获取分页表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 获取数据表的DataTable


 #region 获取数据表的多个对象列表

 /// <summary>
 /// 根据关键字列表获取相关对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "arrIdCurrEduClsLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvQuestionStuFinishedStatusEN> GetObjLstByIdCurrEduClsLst(List<string> arrIdCurrEduClsLst)
{
List<clsvQuestionStuFinishedStatusEN> arrObjLst = new List<clsvQuestionStuFinishedStatusEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdCurrEduClsLst, true);
 string strWhereCond = string.Format("IdCurrEduCls in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusEN = new clsvQuestionStuFinishedStatusEN();
try
{
objvQuestionStuFinishedStatusEN.IdCurrEduCls = objRow[convQuestionStuFinishedStatus.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvQuestionStuFinishedStatusEN.EduClsName = objRow[convQuestionStuFinishedStatus.EduClsName].ToString().Trim(); //教学班名
objvQuestionStuFinishedStatusEN.CourseId = objRow[convQuestionStuFinishedStatus.CourseId] == DBNull.Value ? null : objRow[convQuestionStuFinishedStatus.CourseId].ToString().Trim(); //课程Id
objvQuestionStuFinishedStatusEN.CourseName = objRow[convQuestionStuFinishedStatus.CourseName] == DBNull.Value ? null : objRow[convQuestionStuFinishedStatus.CourseName].ToString().Trim(); //课程名称
objvQuestionStuFinishedStatusEN.CurrStuNum = objRow[convQuestionStuFinishedStatus.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionStuFinishedStatus.CurrStuNum].ToString().Trim()); //当前学生数
objvQuestionStuFinishedStatusEN.IdStudentInfo = objRow[convQuestionStuFinishedStatus.IdStudentInfo].ToString().Trim(); //学生流水号
objvQuestionStuFinishedStatusEN.StuId = objRow[convQuestionStuFinishedStatus.StuId] == DBNull.Value ? null : objRow[convQuestionStuFinishedStatus.StuId].ToString().Trim(); //学号
objvQuestionStuFinishedStatusEN.StuName = objRow[convQuestionStuFinishedStatus.StuName] == DBNull.Value ? null : objRow[convQuestionStuFinishedStatus.StuName].ToString().Trim(); //姓名
objvQuestionStuFinishedStatusEN.SubmitedNum = Int32.Parse(objRow[convQuestionStuFinishedStatus.SubmitedNum].ToString().Trim()); //提交作业数
objvQuestionStuFinishedStatusEN.AllQuestionNum = Int32.Parse(objRow[convQuestionStuFinishedStatus.AllQuestionNum].ToString().Trim()); //所有题目数
objvQuestionStuFinishedStatusEN.MarkedNum = objRow[convQuestionStuFinishedStatus.MarkedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionStuFinishedStatus.MarkedNum].ToString().Trim()); //已批改数
objvQuestionStuFinishedStatusEN.NoMarkNum = objRow[convQuestionStuFinishedStatus.NoMarkNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionStuFinishedStatus.NoMarkNum].ToString().Trim()); //未批改数
objvQuestionStuFinishedStatusEN.NoSubmitedNum = objRow[convQuestionStuFinishedStatus.NoSubmitedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionStuFinishedStatus.NoSubmitedNum].ToString().Trim()); //未提交作业数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionStuFinishedStatusEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionStuFinishedStatusEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdCurrEduClsLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQuestionStuFinishedStatusEN> GetObjLstByIdCurrEduClsLstCache(List<string> arrIdCurrEduClsLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clsvQuestionStuFinishedStatusEN._CurrTabName, strCourseId);
List<clsvQuestionStuFinishedStatusEN> arrvQuestionStuFinishedStatusObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvQuestionStuFinishedStatusEN> arrvQuestionStuFinishedStatusObjLst_Sel =
arrvQuestionStuFinishedStatusObjLstCache
.Where(x => arrIdCurrEduClsLst.Contains(x.IdCurrEduCls));
return arrvQuestionStuFinishedStatusObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionStuFinishedStatusEN> GetObjLst(string strWhereCond)
{
List<clsvQuestionStuFinishedStatusEN> arrObjLst = new List<clsvQuestionStuFinishedStatusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusEN = new clsvQuestionStuFinishedStatusEN();
try
{
objvQuestionStuFinishedStatusEN.IdCurrEduCls = objRow[convQuestionStuFinishedStatus.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvQuestionStuFinishedStatusEN.EduClsName = objRow[convQuestionStuFinishedStatus.EduClsName].ToString().Trim(); //教学班名
objvQuestionStuFinishedStatusEN.CourseId = objRow[convQuestionStuFinishedStatus.CourseId] == DBNull.Value ? null : objRow[convQuestionStuFinishedStatus.CourseId].ToString().Trim(); //课程Id
objvQuestionStuFinishedStatusEN.CourseName = objRow[convQuestionStuFinishedStatus.CourseName] == DBNull.Value ? null : objRow[convQuestionStuFinishedStatus.CourseName].ToString().Trim(); //课程名称
objvQuestionStuFinishedStatusEN.CurrStuNum = objRow[convQuestionStuFinishedStatus.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionStuFinishedStatus.CurrStuNum].ToString().Trim()); //当前学生数
objvQuestionStuFinishedStatusEN.IdStudentInfo = objRow[convQuestionStuFinishedStatus.IdStudentInfo].ToString().Trim(); //学生流水号
objvQuestionStuFinishedStatusEN.StuId = objRow[convQuestionStuFinishedStatus.StuId] == DBNull.Value ? null : objRow[convQuestionStuFinishedStatus.StuId].ToString().Trim(); //学号
objvQuestionStuFinishedStatusEN.StuName = objRow[convQuestionStuFinishedStatus.StuName] == DBNull.Value ? null : objRow[convQuestionStuFinishedStatus.StuName].ToString().Trim(); //姓名
objvQuestionStuFinishedStatusEN.SubmitedNum = Int32.Parse(objRow[convQuestionStuFinishedStatus.SubmitedNum].ToString().Trim()); //提交作业数
objvQuestionStuFinishedStatusEN.AllQuestionNum = Int32.Parse(objRow[convQuestionStuFinishedStatus.AllQuestionNum].ToString().Trim()); //所有题目数
objvQuestionStuFinishedStatusEN.MarkedNum = objRow[convQuestionStuFinishedStatus.MarkedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionStuFinishedStatus.MarkedNum].ToString().Trim()); //已批改数
objvQuestionStuFinishedStatusEN.NoMarkNum = objRow[convQuestionStuFinishedStatus.NoMarkNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionStuFinishedStatus.NoMarkNum].ToString().Trim()); //未批改数
objvQuestionStuFinishedStatusEN.NoSubmitedNum = objRow[convQuestionStuFinishedStatus.NoSubmitedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionStuFinishedStatus.NoSubmitedNum].ToString().Trim()); //未提交作业数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionStuFinishedStatusEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionStuFinishedStatusEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionStuFinishedStatusEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQuestionStuFinishedStatusEN> arrObjLst = new List<clsvQuestionStuFinishedStatusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusEN = new clsvQuestionStuFinishedStatusEN();
try
{
objvQuestionStuFinishedStatusEN.IdCurrEduCls = objRow[convQuestionStuFinishedStatus.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvQuestionStuFinishedStatusEN.EduClsName = objRow[convQuestionStuFinishedStatus.EduClsName].ToString().Trim(); //教学班名
objvQuestionStuFinishedStatusEN.CourseId = objRow[convQuestionStuFinishedStatus.CourseId] == DBNull.Value ? null : objRow[convQuestionStuFinishedStatus.CourseId].ToString().Trim(); //课程Id
objvQuestionStuFinishedStatusEN.CourseName = objRow[convQuestionStuFinishedStatus.CourseName] == DBNull.Value ? null : objRow[convQuestionStuFinishedStatus.CourseName].ToString().Trim(); //课程名称
objvQuestionStuFinishedStatusEN.CurrStuNum = objRow[convQuestionStuFinishedStatus.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionStuFinishedStatus.CurrStuNum].ToString().Trim()); //当前学生数
objvQuestionStuFinishedStatusEN.IdStudentInfo = objRow[convQuestionStuFinishedStatus.IdStudentInfo].ToString().Trim(); //学生流水号
objvQuestionStuFinishedStatusEN.StuId = objRow[convQuestionStuFinishedStatus.StuId] == DBNull.Value ? null : objRow[convQuestionStuFinishedStatus.StuId].ToString().Trim(); //学号
objvQuestionStuFinishedStatusEN.StuName = objRow[convQuestionStuFinishedStatus.StuName] == DBNull.Value ? null : objRow[convQuestionStuFinishedStatus.StuName].ToString().Trim(); //姓名
objvQuestionStuFinishedStatusEN.SubmitedNum = Int32.Parse(objRow[convQuestionStuFinishedStatus.SubmitedNum].ToString().Trim()); //提交作业数
objvQuestionStuFinishedStatusEN.AllQuestionNum = Int32.Parse(objRow[convQuestionStuFinishedStatus.AllQuestionNum].ToString().Trim()); //所有题目数
objvQuestionStuFinishedStatusEN.MarkedNum = objRow[convQuestionStuFinishedStatus.MarkedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionStuFinishedStatus.MarkedNum].ToString().Trim()); //已批改数
objvQuestionStuFinishedStatusEN.NoMarkNum = objRow[convQuestionStuFinishedStatus.NoMarkNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionStuFinishedStatus.NoMarkNum].ToString().Trim()); //未批改数
objvQuestionStuFinishedStatusEN.NoSubmitedNum = objRow[convQuestionStuFinishedStatus.NoSubmitedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionStuFinishedStatus.NoSubmitedNum].ToString().Trim()); //未提交作业数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionStuFinishedStatusEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionStuFinishedStatusEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQuestionStuFinishedStatusCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQuestionStuFinishedStatusEN> GetSubObjLstCache(clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusCond)
{
 string strCourseId = objvQuestionStuFinishedStatusCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvQuestionStuFinishedStatusBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvQuestionStuFinishedStatusEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvQuestionStuFinishedStatusEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQuestionStuFinishedStatus.AttributeName)
{
if (objvQuestionStuFinishedStatusCond.IsUpdated(strFldName) == false) continue;
if (objvQuestionStuFinishedStatusCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionStuFinishedStatusCond[strFldName].ToString());
}
else
{
if (objvQuestionStuFinishedStatusCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQuestionStuFinishedStatusCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionStuFinishedStatusCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQuestionStuFinishedStatusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQuestionStuFinishedStatusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQuestionStuFinishedStatusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQuestionStuFinishedStatusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQuestionStuFinishedStatusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQuestionStuFinishedStatusCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQuestionStuFinishedStatusCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQuestionStuFinishedStatusCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQuestionStuFinishedStatusCond[strFldName]));
}
}
}
return arrObjLstSel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionStuFinishedStatusEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQuestionStuFinishedStatusEN> arrObjLst = new List<clsvQuestionStuFinishedStatusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusEN = new clsvQuestionStuFinishedStatusEN();
try
{
objvQuestionStuFinishedStatusEN.IdCurrEduCls = objRow[convQuestionStuFinishedStatus.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvQuestionStuFinishedStatusEN.EduClsName = objRow[convQuestionStuFinishedStatus.EduClsName].ToString().Trim(); //教学班名
objvQuestionStuFinishedStatusEN.CourseId = objRow[convQuestionStuFinishedStatus.CourseId] == DBNull.Value ? null : objRow[convQuestionStuFinishedStatus.CourseId].ToString().Trim(); //课程Id
objvQuestionStuFinishedStatusEN.CourseName = objRow[convQuestionStuFinishedStatus.CourseName] == DBNull.Value ? null : objRow[convQuestionStuFinishedStatus.CourseName].ToString().Trim(); //课程名称
objvQuestionStuFinishedStatusEN.CurrStuNum = objRow[convQuestionStuFinishedStatus.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionStuFinishedStatus.CurrStuNum].ToString().Trim()); //当前学生数
objvQuestionStuFinishedStatusEN.IdStudentInfo = objRow[convQuestionStuFinishedStatus.IdStudentInfo].ToString().Trim(); //学生流水号
objvQuestionStuFinishedStatusEN.StuId = objRow[convQuestionStuFinishedStatus.StuId] == DBNull.Value ? null : objRow[convQuestionStuFinishedStatus.StuId].ToString().Trim(); //学号
objvQuestionStuFinishedStatusEN.StuName = objRow[convQuestionStuFinishedStatus.StuName] == DBNull.Value ? null : objRow[convQuestionStuFinishedStatus.StuName].ToString().Trim(); //姓名
objvQuestionStuFinishedStatusEN.SubmitedNum = Int32.Parse(objRow[convQuestionStuFinishedStatus.SubmitedNum].ToString().Trim()); //提交作业数
objvQuestionStuFinishedStatusEN.AllQuestionNum = Int32.Parse(objRow[convQuestionStuFinishedStatus.AllQuestionNum].ToString().Trim()); //所有题目数
objvQuestionStuFinishedStatusEN.MarkedNum = objRow[convQuestionStuFinishedStatus.MarkedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionStuFinishedStatus.MarkedNum].ToString().Trim()); //已批改数
objvQuestionStuFinishedStatusEN.NoMarkNum = objRow[convQuestionStuFinishedStatus.NoMarkNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionStuFinishedStatus.NoMarkNum].ToString().Trim()); //未批改数
objvQuestionStuFinishedStatusEN.NoSubmitedNum = objRow[convQuestionStuFinishedStatus.NoSubmitedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionStuFinishedStatus.NoSubmitedNum].ToString().Trim()); //未提交作业数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionStuFinishedStatusEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionStuFinishedStatusEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionStuFinishedStatusEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQuestionStuFinishedStatusEN> arrObjLst = new List<clsvQuestionStuFinishedStatusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusEN = new clsvQuestionStuFinishedStatusEN();
try
{
objvQuestionStuFinishedStatusEN.IdCurrEduCls = objRow[convQuestionStuFinishedStatus.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvQuestionStuFinishedStatusEN.EduClsName = objRow[convQuestionStuFinishedStatus.EduClsName].ToString().Trim(); //教学班名
objvQuestionStuFinishedStatusEN.CourseId = objRow[convQuestionStuFinishedStatus.CourseId] == DBNull.Value ? null : objRow[convQuestionStuFinishedStatus.CourseId].ToString().Trim(); //课程Id
objvQuestionStuFinishedStatusEN.CourseName = objRow[convQuestionStuFinishedStatus.CourseName] == DBNull.Value ? null : objRow[convQuestionStuFinishedStatus.CourseName].ToString().Trim(); //课程名称
objvQuestionStuFinishedStatusEN.CurrStuNum = objRow[convQuestionStuFinishedStatus.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionStuFinishedStatus.CurrStuNum].ToString().Trim()); //当前学生数
objvQuestionStuFinishedStatusEN.IdStudentInfo = objRow[convQuestionStuFinishedStatus.IdStudentInfo].ToString().Trim(); //学生流水号
objvQuestionStuFinishedStatusEN.StuId = objRow[convQuestionStuFinishedStatus.StuId] == DBNull.Value ? null : objRow[convQuestionStuFinishedStatus.StuId].ToString().Trim(); //学号
objvQuestionStuFinishedStatusEN.StuName = objRow[convQuestionStuFinishedStatus.StuName] == DBNull.Value ? null : objRow[convQuestionStuFinishedStatus.StuName].ToString().Trim(); //姓名
objvQuestionStuFinishedStatusEN.SubmitedNum = Int32.Parse(objRow[convQuestionStuFinishedStatus.SubmitedNum].ToString().Trim()); //提交作业数
objvQuestionStuFinishedStatusEN.AllQuestionNum = Int32.Parse(objRow[convQuestionStuFinishedStatus.AllQuestionNum].ToString().Trim()); //所有题目数
objvQuestionStuFinishedStatusEN.MarkedNum = objRow[convQuestionStuFinishedStatus.MarkedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionStuFinishedStatus.MarkedNum].ToString().Trim()); //已批改数
objvQuestionStuFinishedStatusEN.NoMarkNum = objRow[convQuestionStuFinishedStatus.NoMarkNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionStuFinishedStatus.NoMarkNum].ToString().Trim()); //未批改数
objvQuestionStuFinishedStatusEN.NoSubmitedNum = objRow[convQuestionStuFinishedStatus.NoSubmitedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionStuFinishedStatus.NoSubmitedNum].ToString().Trim()); //未提交作业数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionStuFinishedStatusEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionStuFinishedStatusEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static string GetJSONObjLst(string strWhereCond)
{
List<clsvQuestionStuFinishedStatusEN> arrObjLst = GetObjLst(strWhereCond);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}
 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static string GetJSONObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQuestionStuFinishedStatusEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionStuFinishedStatusEN> GetTopObjLst(stuTopPara objTopPara)
{
 return GetTopObjLst( objTopPara.topSize, objTopPara.whereCond, objTopPara.orderBy);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionStuFinishedStatusEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQuestionStuFinishedStatusEN> arrObjLst = new List<clsvQuestionStuFinishedStatusEN>(); 
System.Data.DataTable objDT; 
 stuTopPara objTopPara = new stuTopPara()
 {
 topSize = intTopSize,
 whereCond = strWhereCond,
 orderBy = strOrderBy
 };
 objDT = GetDataTable_Top(objTopPara);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusEN = new clsvQuestionStuFinishedStatusEN();
try
{
objvQuestionStuFinishedStatusEN.IdCurrEduCls = objRow[convQuestionStuFinishedStatus.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvQuestionStuFinishedStatusEN.EduClsName = objRow[convQuestionStuFinishedStatus.EduClsName].ToString().Trim(); //教学班名
objvQuestionStuFinishedStatusEN.CourseId = objRow[convQuestionStuFinishedStatus.CourseId] == DBNull.Value ? null : objRow[convQuestionStuFinishedStatus.CourseId].ToString().Trim(); //课程Id
objvQuestionStuFinishedStatusEN.CourseName = objRow[convQuestionStuFinishedStatus.CourseName] == DBNull.Value ? null : objRow[convQuestionStuFinishedStatus.CourseName].ToString().Trim(); //课程名称
objvQuestionStuFinishedStatusEN.CurrStuNum = objRow[convQuestionStuFinishedStatus.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionStuFinishedStatus.CurrStuNum].ToString().Trim()); //当前学生数
objvQuestionStuFinishedStatusEN.IdStudentInfo = objRow[convQuestionStuFinishedStatus.IdStudentInfo].ToString().Trim(); //学生流水号
objvQuestionStuFinishedStatusEN.StuId = objRow[convQuestionStuFinishedStatus.StuId] == DBNull.Value ? null : objRow[convQuestionStuFinishedStatus.StuId].ToString().Trim(); //学号
objvQuestionStuFinishedStatusEN.StuName = objRow[convQuestionStuFinishedStatus.StuName] == DBNull.Value ? null : objRow[convQuestionStuFinishedStatus.StuName].ToString().Trim(); //姓名
objvQuestionStuFinishedStatusEN.SubmitedNum = Int32.Parse(objRow[convQuestionStuFinishedStatus.SubmitedNum].ToString().Trim()); //提交作业数
objvQuestionStuFinishedStatusEN.AllQuestionNum = Int32.Parse(objRow[convQuestionStuFinishedStatus.AllQuestionNum].ToString().Trim()); //所有题目数
objvQuestionStuFinishedStatusEN.MarkedNum = objRow[convQuestionStuFinishedStatus.MarkedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionStuFinishedStatus.MarkedNum].ToString().Trim()); //已批改数
objvQuestionStuFinishedStatusEN.NoMarkNum = objRow[convQuestionStuFinishedStatus.NoMarkNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionStuFinishedStatus.NoMarkNum].ToString().Trim()); //未批改数
objvQuestionStuFinishedStatusEN.NoSubmitedNum = objRow[convQuestionStuFinishedStatus.NoSubmitedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionStuFinishedStatus.NoSubmitedNum].ToString().Trim()); //未提交作业数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionStuFinishedStatusEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionStuFinishedStatusEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionStuFinishedStatusEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQuestionStuFinishedStatusEN> arrObjLst = new List<clsvQuestionStuFinishedStatusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusEN = new clsvQuestionStuFinishedStatusEN();
try
{
objvQuestionStuFinishedStatusEN.IdCurrEduCls = objRow[convQuestionStuFinishedStatus.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvQuestionStuFinishedStatusEN.EduClsName = objRow[convQuestionStuFinishedStatus.EduClsName].ToString().Trim(); //教学班名
objvQuestionStuFinishedStatusEN.CourseId = objRow[convQuestionStuFinishedStatus.CourseId] == DBNull.Value ? null : objRow[convQuestionStuFinishedStatus.CourseId].ToString().Trim(); //课程Id
objvQuestionStuFinishedStatusEN.CourseName = objRow[convQuestionStuFinishedStatus.CourseName] == DBNull.Value ? null : objRow[convQuestionStuFinishedStatus.CourseName].ToString().Trim(); //课程名称
objvQuestionStuFinishedStatusEN.CurrStuNum = objRow[convQuestionStuFinishedStatus.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionStuFinishedStatus.CurrStuNum].ToString().Trim()); //当前学生数
objvQuestionStuFinishedStatusEN.IdStudentInfo = objRow[convQuestionStuFinishedStatus.IdStudentInfo].ToString().Trim(); //学生流水号
objvQuestionStuFinishedStatusEN.StuId = objRow[convQuestionStuFinishedStatus.StuId] == DBNull.Value ? null : objRow[convQuestionStuFinishedStatus.StuId].ToString().Trim(); //学号
objvQuestionStuFinishedStatusEN.StuName = objRow[convQuestionStuFinishedStatus.StuName] == DBNull.Value ? null : objRow[convQuestionStuFinishedStatus.StuName].ToString().Trim(); //姓名
objvQuestionStuFinishedStatusEN.SubmitedNum = Int32.Parse(objRow[convQuestionStuFinishedStatus.SubmitedNum].ToString().Trim()); //提交作业数
objvQuestionStuFinishedStatusEN.AllQuestionNum = Int32.Parse(objRow[convQuestionStuFinishedStatus.AllQuestionNum].ToString().Trim()); //所有题目数
objvQuestionStuFinishedStatusEN.MarkedNum = objRow[convQuestionStuFinishedStatus.MarkedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionStuFinishedStatus.MarkedNum].ToString().Trim()); //已批改数
objvQuestionStuFinishedStatusEN.NoMarkNum = objRow[convQuestionStuFinishedStatus.NoMarkNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionStuFinishedStatus.NoMarkNum].ToString().Trim()); //未批改数
objvQuestionStuFinishedStatusEN.NoSubmitedNum = objRow[convQuestionStuFinishedStatus.NoSubmitedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionStuFinishedStatus.NoSubmitedNum].ToString().Trim()); //未提交作业数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionStuFinishedStatusEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionStuFinishedStatusEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQuestionStuFinishedStatusEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 return GetObjLstByPager(objPagerPara.pageIndex, objPagerPara.pageSize, objPagerPara.whereCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQuestionStuFinishedStatusEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQuestionStuFinishedStatusEN> arrObjLst = new List<clsvQuestionStuFinishedStatusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusEN = new clsvQuestionStuFinishedStatusEN();
try
{
objvQuestionStuFinishedStatusEN.IdCurrEduCls = objRow[convQuestionStuFinishedStatus.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvQuestionStuFinishedStatusEN.EduClsName = objRow[convQuestionStuFinishedStatus.EduClsName].ToString().Trim(); //教学班名
objvQuestionStuFinishedStatusEN.CourseId = objRow[convQuestionStuFinishedStatus.CourseId] == DBNull.Value ? null : objRow[convQuestionStuFinishedStatus.CourseId].ToString().Trim(); //课程Id
objvQuestionStuFinishedStatusEN.CourseName = objRow[convQuestionStuFinishedStatus.CourseName] == DBNull.Value ? null : objRow[convQuestionStuFinishedStatus.CourseName].ToString().Trim(); //课程名称
objvQuestionStuFinishedStatusEN.CurrStuNum = objRow[convQuestionStuFinishedStatus.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionStuFinishedStatus.CurrStuNum].ToString().Trim()); //当前学生数
objvQuestionStuFinishedStatusEN.IdStudentInfo = objRow[convQuestionStuFinishedStatus.IdStudentInfo].ToString().Trim(); //学生流水号
objvQuestionStuFinishedStatusEN.StuId = objRow[convQuestionStuFinishedStatus.StuId] == DBNull.Value ? null : objRow[convQuestionStuFinishedStatus.StuId].ToString().Trim(); //学号
objvQuestionStuFinishedStatusEN.StuName = objRow[convQuestionStuFinishedStatus.StuName] == DBNull.Value ? null : objRow[convQuestionStuFinishedStatus.StuName].ToString().Trim(); //姓名
objvQuestionStuFinishedStatusEN.SubmitedNum = Int32.Parse(objRow[convQuestionStuFinishedStatus.SubmitedNum].ToString().Trim()); //提交作业数
objvQuestionStuFinishedStatusEN.AllQuestionNum = Int32.Parse(objRow[convQuestionStuFinishedStatus.AllQuestionNum].ToString().Trim()); //所有题目数
objvQuestionStuFinishedStatusEN.MarkedNum = objRow[convQuestionStuFinishedStatus.MarkedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionStuFinishedStatus.MarkedNum].ToString().Trim()); //已批改数
objvQuestionStuFinishedStatusEN.NoMarkNum = objRow[convQuestionStuFinishedStatus.NoMarkNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionStuFinishedStatus.NoMarkNum].ToString().Trim()); //未批改数
objvQuestionStuFinishedStatusEN.NoSubmitedNum = objRow[convQuestionStuFinishedStatus.NoSubmitedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionStuFinishedStatus.NoSubmitedNum].ToString().Trim()); //未提交作业数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionStuFinishedStatusEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionStuFinishedStatusEN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionStuFinishedStatusEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQuestionStuFinishedStatusEN> arrObjLst = new List<clsvQuestionStuFinishedStatusEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusEN = new clsvQuestionStuFinishedStatusEN();
try
{
objvQuestionStuFinishedStatusEN.IdCurrEduCls = objRow[convQuestionStuFinishedStatus.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvQuestionStuFinishedStatusEN.EduClsName = objRow[convQuestionStuFinishedStatus.EduClsName].ToString().Trim(); //教学班名
objvQuestionStuFinishedStatusEN.CourseId = objRow[convQuestionStuFinishedStatus.CourseId] == DBNull.Value ? null : objRow[convQuestionStuFinishedStatus.CourseId].ToString().Trim(); //课程Id
objvQuestionStuFinishedStatusEN.CourseName = objRow[convQuestionStuFinishedStatus.CourseName] == DBNull.Value ? null : objRow[convQuestionStuFinishedStatus.CourseName].ToString().Trim(); //课程名称
objvQuestionStuFinishedStatusEN.CurrStuNum = objRow[convQuestionStuFinishedStatus.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionStuFinishedStatus.CurrStuNum].ToString().Trim()); //当前学生数
objvQuestionStuFinishedStatusEN.IdStudentInfo = objRow[convQuestionStuFinishedStatus.IdStudentInfo].ToString().Trim(); //学生流水号
objvQuestionStuFinishedStatusEN.StuId = objRow[convQuestionStuFinishedStatus.StuId] == DBNull.Value ? null : objRow[convQuestionStuFinishedStatus.StuId].ToString().Trim(); //学号
objvQuestionStuFinishedStatusEN.StuName = objRow[convQuestionStuFinishedStatus.StuName] == DBNull.Value ? null : objRow[convQuestionStuFinishedStatus.StuName].ToString().Trim(); //姓名
objvQuestionStuFinishedStatusEN.SubmitedNum = Int32.Parse(objRow[convQuestionStuFinishedStatus.SubmitedNum].ToString().Trim()); //提交作业数
objvQuestionStuFinishedStatusEN.AllQuestionNum = Int32.Parse(objRow[convQuestionStuFinishedStatus.AllQuestionNum].ToString().Trim()); //所有题目数
objvQuestionStuFinishedStatusEN.MarkedNum = objRow[convQuestionStuFinishedStatus.MarkedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionStuFinishedStatus.MarkedNum].ToString().Trim()); //已批改数
objvQuestionStuFinishedStatusEN.NoMarkNum = objRow[convQuestionStuFinishedStatus.NoMarkNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionStuFinishedStatus.NoMarkNum].ToString().Trim()); //未批改数
objvQuestionStuFinishedStatusEN.NoSubmitedNum = objRow[convQuestionStuFinishedStatus.NoSubmitedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionStuFinishedStatus.NoSubmitedNum].ToString().Trim()); //未提交作业数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionStuFinishedStatusEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionStuFinishedStatusEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionStuFinishedStatusEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQuestionStuFinishedStatusEN> arrObjLst = new List<clsvQuestionStuFinishedStatusEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusEN = new clsvQuestionStuFinishedStatusEN();
try
{
objvQuestionStuFinishedStatusEN.IdCurrEduCls = objRow[convQuestionStuFinishedStatus.IdCurrEduCls].ToString().Trim(); //教学班流水号
objvQuestionStuFinishedStatusEN.EduClsName = objRow[convQuestionStuFinishedStatus.EduClsName].ToString().Trim(); //教学班名
objvQuestionStuFinishedStatusEN.CourseId = objRow[convQuestionStuFinishedStatus.CourseId] == DBNull.Value ? null : objRow[convQuestionStuFinishedStatus.CourseId].ToString().Trim(); //课程Id
objvQuestionStuFinishedStatusEN.CourseName = objRow[convQuestionStuFinishedStatus.CourseName] == DBNull.Value ? null : objRow[convQuestionStuFinishedStatus.CourseName].ToString().Trim(); //课程名称
objvQuestionStuFinishedStatusEN.CurrStuNum = objRow[convQuestionStuFinishedStatus.CurrStuNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionStuFinishedStatus.CurrStuNum].ToString().Trim()); //当前学生数
objvQuestionStuFinishedStatusEN.IdStudentInfo = objRow[convQuestionStuFinishedStatus.IdStudentInfo].ToString().Trim(); //学生流水号
objvQuestionStuFinishedStatusEN.StuId = objRow[convQuestionStuFinishedStatus.StuId] == DBNull.Value ? null : objRow[convQuestionStuFinishedStatus.StuId].ToString().Trim(); //学号
objvQuestionStuFinishedStatusEN.StuName = objRow[convQuestionStuFinishedStatus.StuName] == DBNull.Value ? null : objRow[convQuestionStuFinishedStatus.StuName].ToString().Trim(); //姓名
objvQuestionStuFinishedStatusEN.SubmitedNum = Int32.Parse(objRow[convQuestionStuFinishedStatus.SubmitedNum].ToString().Trim()); //提交作业数
objvQuestionStuFinishedStatusEN.AllQuestionNum = Int32.Parse(objRow[convQuestionStuFinishedStatus.AllQuestionNum].ToString().Trim()); //所有题目数
objvQuestionStuFinishedStatusEN.MarkedNum = objRow[convQuestionStuFinishedStatus.MarkedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionStuFinishedStatus.MarkedNum].ToString().Trim()); //已批改数
objvQuestionStuFinishedStatusEN.NoMarkNum = objRow[convQuestionStuFinishedStatus.NoMarkNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionStuFinishedStatus.NoMarkNum].ToString().Trim()); //未批改数
objvQuestionStuFinishedStatusEN.NoSubmitedNum = objRow[convQuestionStuFinishedStatus.NoSubmitedNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionStuFinishedStatus.NoSubmitedNum].ToString().Trim()); //未提交作业数
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionStuFinishedStatusEN.IdCurrEduCls, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionStuFinishedStatusEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQuestionStuFinishedStatusEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQuestionStuFinishedStatus(ref clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusEN)
{
bool bolResult = vQuestionStuFinishedStatusDA.GetvQuestionStuFinishedStatus(ref objvQuestionStuFinishedStatusEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strIdCurrEduCls">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionStuFinishedStatusEN GetObjByIdCurrEduCls(string strIdCurrEduCls)
{
if (strIdCurrEduCls.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strIdCurrEduCls]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strIdCurrEduCls]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusEN = vQuestionStuFinishedStatusDA.GetObjByIdCurrEduCls(strIdCurrEduCls);
return objvQuestionStuFinishedStatusEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQuestionStuFinishedStatusEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusEN = vQuestionStuFinishedStatusDA.GetFirstObj(strWhereCond);
 return objvQuestionStuFinishedStatusEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000022)获取当前表满足条件的第一条记录数据出错!(strWhereCond = {1}),{2}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 把DataRow转换成相关实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecValueObjByDataRow_S)
 /// </summary>
 /// <param name = "objRow">给定的DataRow</param>
 /// <returns>返回相关的实体对象</returns>
public static clsvQuestionStuFinishedStatusEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusEN = vQuestionStuFinishedStatusDA.GetObjByDataRow(objRow);
 return objvQuestionStuFinishedStatusEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000051)根据DataRow记录获取对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}
 /// <summary>
 /// 把DataRowView转换成相关实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecValueObjByDataRow_S)
 /// </summary>
 /// <param name = "objRow">给定的DataRowView</param>
 /// <returns>返回相关的实体对象</returns>
public static clsvQuestionStuFinishedStatusEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusEN = vQuestionStuFinishedStatusDA.GetObjByDataRow(objRow);
 return objvQuestionStuFinishedStatusEN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000052)通过DataRowView记录对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 根据关键字获取相关对象, 从给定的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyFromList)
 /// </summary>
 /// <param name = "strIdCurrEduCls">所给的关键字</param>
 /// <param name = "lstvQuestionStuFinishedStatusObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQuestionStuFinishedStatusEN GetObjByIdCurrEduClsFromList(string strIdCurrEduCls, List<clsvQuestionStuFinishedStatusEN> lstvQuestionStuFinishedStatusObjLst)
{
foreach (clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusEN in lstvQuestionStuFinishedStatusObjLst)
{
if (objvQuestionStuFinishedStatusEN.IdCurrEduCls == strIdCurrEduCls)
{
return objvQuestionStuFinishedStatusEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表关键字值的最大值,再加1,避免重复
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetMaxStrId_S)
 /// </summary>
 /// <returns>当前表关键字值的最大值,再加1</returns>
public static string GetMaxStrId_S() 
{
 string strMaxIdCurrEduCls;
 try
 {
 strMaxIdCurrEduCls = clsvQuestionStuFinishedStatusDA.GetMaxStrId();
 return strMaxIdCurrEduCls;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000024)获取最大关键字值出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond) 
{
 string strIdCurrEduCls;
 try
 {
 strIdCurrEduCls = new clsvQuestionStuFinishedStatusDA().GetFirstID(strWhereCond);
 return strIdCurrEduCls;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000023)获取First关键字出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 获取一个关键字值


 #region 获取多个关键字值列表

 /// <summary>
 /// 获取当前表满足条件的关键字值列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetPrimaryKeyID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件的关键字列表值</returns>
public static List<string> GetPrimaryKeyID_S(string strWhereCond) 
{
 List<string> arrList;
 try
 {
 arrList = vQuestionStuFinishedStatusDA.GetID(strWhereCond);
 return arrList;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000026)获取关键字列表出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 获取多个关键字值列表


 #region 判断记录是否存在

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistRecord)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
public static bool IsExistRecord(string strWhereCond)
{
//检测记录是否存在
bool bolIsExist = vQuestionStuFinishedStatusDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strIdCurrEduCls">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strIdCurrEduCls)
{
if (string.IsNullOrEmpty(strIdCurrEduCls) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strIdCurrEduCls]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vQuestionStuFinishedStatusDA.IsExist(strIdCurrEduCls);
return bolIsExist;
}

 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable() 
{
 bool bolIsExist;
 try
 {
 bolIsExist = clsvQuestionStuFinishedStatusDA.IsExistTable();
 return bolIsExist;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000028)检查是否存在当前表(IsExistTable)出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}
 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <param name = "strTabName">给定表</param>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable(string strTabName) 
{
 bool bolIsExist;
 try
 {
 bolIsExist = vQuestionStuFinishedStatusDA.IsExistTable(strTabName);
 return bolIsExist;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000029)检查是否存在指定表(IsExistTable)出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 判断记录是否存在


 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
 /// </summary>
 /// <param name = "objvQuestionStuFinishedStatusENS">源对象</param>
 /// <param name = "objvQuestionStuFinishedStatusENT">目标对象</param>
 public static void CopyTo(clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusENS, clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusENT)
{
try
{
objvQuestionStuFinishedStatusENT.IdCurrEduCls = objvQuestionStuFinishedStatusENS.IdCurrEduCls; //教学班流水号
objvQuestionStuFinishedStatusENT.EduClsName = objvQuestionStuFinishedStatusENS.EduClsName; //教学班名
objvQuestionStuFinishedStatusENT.CourseId = objvQuestionStuFinishedStatusENS.CourseId; //课程Id
objvQuestionStuFinishedStatusENT.CourseName = objvQuestionStuFinishedStatusENS.CourseName; //课程名称
objvQuestionStuFinishedStatusENT.CurrStuNum = objvQuestionStuFinishedStatusENS.CurrStuNum; //当前学生数
objvQuestionStuFinishedStatusENT.IdStudentInfo = objvQuestionStuFinishedStatusENS.IdStudentInfo; //学生流水号
objvQuestionStuFinishedStatusENT.StuId = objvQuestionStuFinishedStatusENS.StuId; //学号
objvQuestionStuFinishedStatusENT.StuName = objvQuestionStuFinishedStatusENS.StuName; //姓名
objvQuestionStuFinishedStatusENT.SubmitedNum = objvQuestionStuFinishedStatusENS.SubmitedNum; //提交作业数
objvQuestionStuFinishedStatusENT.AllQuestionNum = objvQuestionStuFinishedStatusENS.AllQuestionNum; //所有题目数
objvQuestionStuFinishedStatusENT.MarkedNum = objvQuestionStuFinishedStatusENS.MarkedNum; //已批改数
objvQuestionStuFinishedStatusENT.NoMarkNum = objvQuestionStuFinishedStatusENS.NoMarkNum; //未批改数
objvQuestionStuFinishedStatusENT.NoSubmitedNum = objvQuestionStuFinishedStatusENS.NoSubmitedNum; //未提交作业数
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000045)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 设置修改标志,即根据字段修改标志字符串获取哪一个字段已经被修改
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SetUpdFlag_S)
 /// </summary>
 /// <param name = "objvQuestionStuFinishedStatusEN">源简化对象</param>
 public static void SetUpdFlag(clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusEN)
{
try
{
objvQuestionStuFinishedStatusEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQuestionStuFinishedStatusEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQuestionStuFinishedStatus.IdCurrEduCls, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionStuFinishedStatusEN.IdCurrEduCls = objvQuestionStuFinishedStatusEN.IdCurrEduCls; //教学班流水号
}
if (arrFldSet.Contains(convQuestionStuFinishedStatus.EduClsName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionStuFinishedStatusEN.EduClsName = objvQuestionStuFinishedStatusEN.EduClsName; //教学班名
}
if (arrFldSet.Contains(convQuestionStuFinishedStatus.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionStuFinishedStatusEN.CourseId = objvQuestionStuFinishedStatusEN.CourseId == "[null]" ? null :  objvQuestionStuFinishedStatusEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convQuestionStuFinishedStatus.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionStuFinishedStatusEN.CourseName = objvQuestionStuFinishedStatusEN.CourseName == "[null]" ? null :  objvQuestionStuFinishedStatusEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convQuestionStuFinishedStatus.CurrStuNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionStuFinishedStatusEN.CurrStuNum = objvQuestionStuFinishedStatusEN.CurrStuNum; //当前学生数
}
if (arrFldSet.Contains(convQuestionStuFinishedStatus.IdStudentInfo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionStuFinishedStatusEN.IdStudentInfo = objvQuestionStuFinishedStatusEN.IdStudentInfo; //学生流水号
}
if (arrFldSet.Contains(convQuestionStuFinishedStatus.StuId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionStuFinishedStatusEN.StuId = objvQuestionStuFinishedStatusEN.StuId == "[null]" ? null :  objvQuestionStuFinishedStatusEN.StuId; //学号
}
if (arrFldSet.Contains(convQuestionStuFinishedStatus.StuName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionStuFinishedStatusEN.StuName = objvQuestionStuFinishedStatusEN.StuName == "[null]" ? null :  objvQuestionStuFinishedStatusEN.StuName; //姓名
}
if (arrFldSet.Contains(convQuestionStuFinishedStatus.SubmitedNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionStuFinishedStatusEN.SubmitedNum = objvQuestionStuFinishedStatusEN.SubmitedNum; //提交作业数
}
if (arrFldSet.Contains(convQuestionStuFinishedStatus.AllQuestionNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionStuFinishedStatusEN.AllQuestionNum = objvQuestionStuFinishedStatusEN.AllQuestionNum; //所有题目数
}
if (arrFldSet.Contains(convQuestionStuFinishedStatus.MarkedNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionStuFinishedStatusEN.MarkedNum = objvQuestionStuFinishedStatusEN.MarkedNum; //已批改数
}
if (arrFldSet.Contains(convQuestionStuFinishedStatus.NoMarkNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionStuFinishedStatusEN.NoMarkNum = objvQuestionStuFinishedStatusEN.NoMarkNum; //未批改数
}
if (arrFldSet.Contains(convQuestionStuFinishedStatus.NoSubmitedNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionStuFinishedStatusEN.NoSubmitedNum = objvQuestionStuFinishedStatusEN.NoSubmitedNum; //未提交作业数
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:001)设置表的修改标志出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 处理从Web端传来的[null]的字段值,在WebApi端设置成null
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AccessFldValueNull)
 /// </summary>
 /// <param name = "objvQuestionStuFinishedStatusEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusEN)
{
try
{
if (objvQuestionStuFinishedStatusEN.CourseId == "[null]") objvQuestionStuFinishedStatusEN.CourseId = null; //课程Id
if (objvQuestionStuFinishedStatusEN.CourseName == "[null]") objvQuestionStuFinishedStatusEN.CourseName = null; //课程名称
if (objvQuestionStuFinishedStatusEN.StuId == "[null]") objvQuestionStuFinishedStatusEN.StuId = null; //学号
if (objvQuestionStuFinishedStatusEN.StuName == "[null]") objvQuestionStuFinishedStatusEN.StuName = null; //姓名
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:002)处理从Web端传来的[null]的字段值出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 克隆复制对象


 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusEN)
{
 vQuestionStuFinishedStatusDA.CheckProperty4Condition(objvQuestionStuFinishedStatusEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框


 #endregion 绑定下拉框


 #region 缓存操作

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg;
if (clsStudentInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudentInfoBL没有刷新缓存机制(clsStudentInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionStuFinishedStatusBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionStuFinishedStatusBL没有刷新缓存机制(clsQuestionStuFinishedStatusBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseTypeBL没有刷新缓存机制(clscc_CourseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzClgBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgBL没有刷新缓存机制(clsXzClgBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorBL没有刷新缓存机制(clsXzMajorBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCurrEduClsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCurrEduClsBL没有刷新缓存机制(clsCurrEduClsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzGradeBaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseBL没有刷新缓存机制(clsXzGradeBaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsgs_EduClsTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsgs_EduClsTypeBL没有刷新缓存机制(clsgs_EduClsTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseBL没有刷新缓存机制(clscc_CourseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExcellentTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExcellentTypeBL没有刷新缓存机制(clscc_ExcellentTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ThemesBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ThemesBL没有刷新缓存机制(clscc_ThemesBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachingSolutionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachingSolutionBL没有刷新缓存机制(clsTeachingSolutionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseIsLikeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeBL没有刷新缓存机制(clscc_CourseIsLikeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeacherInfoBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeacherInfoBL没有刷新缓存机制(clsTeacherInfoBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzUniZoneBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzUniZoneBL没有刷新缓存机制(clsXzUniZoneBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsStaffTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsStaffTypeBL没有刷新缓存机制(clsRsStaffTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSexBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsSexBL没有刷新缓存机制(clsSexBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsProfGradeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsProfGradeBL没有刷新缓存机制(clsRsProfGradeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsEthnicBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsEthnicBL没有刷新缓存机制(clsRsEthnicBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsDegreeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsDegreeBL没有刷新缓存机制(clsRsDegreeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsProvinceBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsProvinceBL没有刷新缓存机制(clsRsProvinceBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsReligionBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsReligionBL没有刷新缓存机制(clsRsReligionBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsQualifBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsQualifBL没有刷新缓存机制(clsRsQualifBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsPoliticsBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsPoliticsBL没有刷新缓存机制(clsRsPoliticsBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRsAdminGradeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsRsAdminGradeBL没有刷新缓存机制(clsRsAdminGradeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdCurrEduCls");
//if (arrvQuestionStuFinishedStatusObjLstCache == null)
//{
//arrvQuestionStuFinishedStatusObjLstCache = vQuestionStuFinishedStatusDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strIdCurrEduCls">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQuestionStuFinishedStatusEN GetObjByIdCurrEduClsCache(string strIdCurrEduCls, string strCourseId)
{

if (string.IsNullOrEmpty(strCourseId) == true)
{
  var strMsg = string.Format("参数:[strCourseId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strCourseId.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strCourseId]的长度:[{0}]不正确!(In {1})", strCourseId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsvQuestionStuFinishedStatusEN._CurrTabName, strCourseId);
List<clsvQuestionStuFinishedStatusEN> arrvQuestionStuFinishedStatusObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvQuestionStuFinishedStatusEN> arrvQuestionStuFinishedStatusObjLst_Sel =
arrvQuestionStuFinishedStatusObjLstCache
.Where(x=> x.IdCurrEduCls == strIdCurrEduCls 
);
if (arrvQuestionStuFinishedStatusObjLst_Sel.Count() == 0)
{
   clsvQuestionStuFinishedStatusEN obj = clsvQuestionStuFinishedStatusBL.GetObjByIdCurrEduCls(strIdCurrEduCls);
   if (obj != null)
 {
if (obj.CourseId == strCourseId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strIdCurrEduCls, strCourseId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvQuestionStuFinishedStatusObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQuestionStuFinishedStatusEN> GetAllvQuestionStuFinishedStatusObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clsvQuestionStuFinishedStatusEN> arrvQuestionStuFinishedStatusObjLstCache = GetObjLstCache(strCourseId); 
return arrvQuestionStuFinishedStatusObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQuestionStuFinishedStatusEN> GetObjLstCache(string strCourseId)
{

if (string.IsNullOrEmpty(strCourseId) == true)
{
  var strMsg = string.Format("参数:[strCourseId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strCourseId.Length != 8)
{
var strMsg = string.Format("缓存分类变量:[strCourseId]的长度:[{0}]不正确!(In {1})", strCourseId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvQuestionStuFinishedStatusEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clsvQuestionStuFinishedStatusEN> arrvQuestionStuFinishedStatusObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvQuestionStuFinishedStatusObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strCourseId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvQuestionStuFinishedStatusEN._CurrTabName, strCourseId);
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


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2024-02-27
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strIdCurrEduCls, string strCourseId)
{
if (strInFldName != convQuestionStuFinishedStatus.IdCurrEduCls)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQuestionStuFinishedStatus.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQuestionStuFinishedStatus.AttributeName));
throw new Exception(strMsg);
}
var objvQuestionStuFinishedStatus = clsvQuestionStuFinishedStatusBL.GetObjByIdCurrEduClsCache(strIdCurrEduCls, strCourseId);
if (objvQuestionStuFinishedStatus == null) return "";
return objvQuestionStuFinishedStatus[strOutFldName].ToString();
}


 #region 有关JSON操作


 #endregion 有关JSON操作


 #region 表操作常用函数

 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount(string strTabName)
{
int intRecCount = clsvQuestionStuFinishedStatusDA.GetRecCount(strTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCond_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond(string strTabName, string strWhereCond)
{
int intRecCount = clsvQuestionStuFinishedStatusDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQuestionStuFinishedStatusDA.GetRecCount();
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond( string strWhereCond)
{
int intRecCount = clsvQuestionStuFinishedStatusDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQuestionStuFinishedStatusCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQuestionStuFinishedStatusEN objvQuestionStuFinishedStatusCond)
{
 string strCourseId = objvQuestionStuFinishedStatusCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvQuestionStuFinishedStatusBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvQuestionStuFinishedStatusEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvQuestionStuFinishedStatusEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQuestionStuFinishedStatus.AttributeName)
{
if (objvQuestionStuFinishedStatusCond.IsUpdated(strFldName) == false) continue;
if (objvQuestionStuFinishedStatusCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionStuFinishedStatusCond[strFldName].ToString());
}
else
{
if (objvQuestionStuFinishedStatusCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQuestionStuFinishedStatusCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionStuFinishedStatusCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQuestionStuFinishedStatusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQuestionStuFinishedStatusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQuestionStuFinishedStatusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQuestionStuFinishedStatusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQuestionStuFinishedStatusCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQuestionStuFinishedStatusCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQuestionStuFinishedStatusCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQuestionStuFinishedStatusCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQuestionStuFinishedStatusCond[strFldName]));
}
}
}
return arrObjLstSel.Count();
}

 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strTabName, string strFldName, string strWhereCond)
{
 List<string> arrList = clsvQuestionStuFinishedStatusDA.GetFldValue(strTabName, strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strFldName, string strWhereCond)
{
 List<string> arrList = vQuestionStuFinishedStatusDA.GetFldValue(strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValueNoDistinct)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValueNoDistinct(string strFldName, string strWhereCond)
{
 List<string> arrList = vQuestionStuFinishedStatusDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}