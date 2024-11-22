
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionnaire4App_TWApi
 表名:vQuestionnaire4App_T(01120222)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:46:06
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
public static class clsvQuestionnaire4App_TWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4App_TEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire4App_TEN SetQuestionID(this clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN, string strQuestionID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionID, 8, convQuestionnaire4App_T.QuestionID);
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, convQuestionnaire4App_T.QuestionID);
objvQuestionnaire4App_TEN.QuestionID = strQuestionID; //题目ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire4App_TEN.dicFldComparisonOp.ContainsKey(convQuestionnaire4App_T.QuestionID) == false)
{
objvQuestionnaire4App_TEN.dicFldComparisonOp.Add(convQuestionnaire4App_T.QuestionID, strComparisonOp);
}
else
{
objvQuestionnaire4App_TEN.dicFldComparisonOp[convQuestionnaire4App_T.QuestionID] = strComparisonOp;
}
}
return objvQuestionnaire4App_TEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4App_TEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire4App_TEN SetQuestionIndex(this clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN, int intQuestionIndex, string strComparisonOp="")
	{
objvQuestionnaire4App_TEN.QuestionIndex = intQuestionIndex; //题目序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire4App_TEN.dicFldComparisonOp.ContainsKey(convQuestionnaire4App_T.QuestionIndex) == false)
{
objvQuestionnaire4App_TEN.dicFldComparisonOp.Add(convQuestionnaire4App_T.QuestionIndex, strComparisonOp);
}
else
{
objvQuestionnaire4App_TEN.dicFldComparisonOp[convQuestionnaire4App_T.QuestionIndex] = strComparisonOp;
}
}
return objvQuestionnaire4App_TEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4App_TEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire4App_TEN SetQuestionName(this clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN, string strQuestionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionName, 1000, convQuestionnaire4App_T.QuestionName);
objvQuestionnaire4App_TEN.QuestionName = strQuestionName; //题目名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire4App_TEN.dicFldComparisonOp.ContainsKey(convQuestionnaire4App_T.QuestionName) == false)
{
objvQuestionnaire4App_TEN.dicFldComparisonOp.Add(convQuestionnaire4App_T.QuestionName, strComparisonOp);
}
else
{
objvQuestionnaire4App_TEN.dicFldComparisonOp[convQuestionnaire4App_T.QuestionName] = strComparisonOp;
}
}
return objvQuestionnaire4App_TEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4App_TEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire4App_TEN SetQuestionNo(this clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN, string strQuestionNo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strQuestionNo, 10, convQuestionnaire4App_T.QuestionNo);
objvQuestionnaire4App_TEN.QuestionNo = strQuestionNo; //题目编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire4App_TEN.dicFldComparisonOp.ContainsKey(convQuestionnaire4App_T.QuestionNo) == false)
{
objvQuestionnaire4App_TEN.dicFldComparisonOp.Add(convQuestionnaire4App_T.QuestionNo, strComparisonOp);
}
else
{
objvQuestionnaire4App_TEN.dicFldComparisonOp[convQuestionnaire4App_T.QuestionNo] = strComparisonOp;
}
}
return objvQuestionnaire4App_TEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4App_TEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire4App_TEN SetCourseId(this clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convQuestionnaire4App_T.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convQuestionnaire4App_T.CourseId);
objvQuestionnaire4App_TEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire4App_TEN.dicFldComparisonOp.ContainsKey(convQuestionnaire4App_T.CourseId) == false)
{
objvQuestionnaire4App_TEN.dicFldComparisonOp.Add(convQuestionnaire4App_T.CourseId, strComparisonOp);
}
else
{
objvQuestionnaire4App_TEN.dicFldComparisonOp[convQuestionnaire4App_T.CourseId] = strComparisonOp;
}
}
return objvQuestionnaire4App_TEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4App_TEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire4App_TEN SetCourseChapterId(this clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convQuestionnaire4App_T.CourseChapterId);
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convQuestionnaire4App_T.CourseChapterId);
objvQuestionnaire4App_TEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire4App_TEN.dicFldComparisonOp.ContainsKey(convQuestionnaire4App_T.CourseChapterId) == false)
{
objvQuestionnaire4App_TEN.dicFldComparisonOp.Add(convQuestionnaire4App_T.CourseChapterId, strComparisonOp);
}
else
{
objvQuestionnaire4App_TEN.dicFldComparisonOp[convQuestionnaire4App_T.CourseChapterId] = strComparisonOp;
}
}
return objvQuestionnaire4App_TEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4App_TEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire4App_TEN SetChapterId(this clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN, string strChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterId, 8, convQuestionnaire4App_T.ChapterId);
clsCheckSql.CheckFieldForeignKey(strChapterId, 8, convQuestionnaire4App_T.ChapterId);
objvQuestionnaire4App_TEN.ChapterId = strChapterId; //章Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire4App_TEN.dicFldComparisonOp.ContainsKey(convQuestionnaire4App_T.ChapterId) == false)
{
objvQuestionnaire4App_TEN.dicFldComparisonOp.Add(convQuestionnaire4App_T.ChapterId, strComparisonOp);
}
else
{
objvQuestionnaire4App_TEN.dicFldComparisonOp[convQuestionnaire4App_T.ChapterId] = strComparisonOp;
}
}
return objvQuestionnaire4App_TEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4App_TEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire4App_TEN SetChapterName(this clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN, string strChapterName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName, 100, convQuestionnaire4App_T.ChapterName);
objvQuestionnaire4App_TEN.ChapterName = strChapterName; //章名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire4App_TEN.dicFldComparisonOp.ContainsKey(convQuestionnaire4App_T.ChapterName) == false)
{
objvQuestionnaire4App_TEN.dicFldComparisonOp.Add(convQuestionnaire4App_T.ChapterName, strComparisonOp);
}
else
{
objvQuestionnaire4App_TEN.dicFldComparisonOp[convQuestionnaire4App_T.ChapterName] = strComparisonOp;
}
}
return objvQuestionnaire4App_TEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4App_TEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire4App_TEN SetChapterName_Sim(this clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN, string strChapterName_Sim, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strChapterName_Sim, 10, convQuestionnaire4App_T.ChapterName_Sim);
objvQuestionnaire4App_TEN.ChapterName_Sim = strChapterName_Sim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire4App_TEN.dicFldComparisonOp.ContainsKey(convQuestionnaire4App_T.ChapterName_Sim) == false)
{
objvQuestionnaire4App_TEN.dicFldComparisonOp.Add(convQuestionnaire4App_T.ChapterName_Sim, strComparisonOp);
}
else
{
objvQuestionnaire4App_TEN.dicFldComparisonOp[convQuestionnaire4App_T.ChapterName_Sim] = strComparisonOp;
}
}
return objvQuestionnaire4App_TEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4App_TEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire4App_TEN SetChapterOrderNum(this clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN, int intChapterOrderNum, string strComparisonOp="")
	{
objvQuestionnaire4App_TEN.ChapterOrderNum = intChapterOrderNum; //章排序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire4App_TEN.dicFldComparisonOp.ContainsKey(convQuestionnaire4App_T.ChapterOrderNum) == false)
{
objvQuestionnaire4App_TEN.dicFldComparisonOp.Add(convQuestionnaire4App_T.ChapterOrderNum, strComparisonOp);
}
else
{
objvQuestionnaire4App_TEN.dicFldComparisonOp[convQuestionnaire4App_T.ChapterOrderNum] = strComparisonOp;
}
}
return objvQuestionnaire4App_TEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4App_TEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvQuestionnaire4App_TEN SetQuestionTypeId4Course(this clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN, string strQuestionTypeId4Course, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionTypeId4Course, convQuestionnaire4App_T.QuestionTypeId4Course);
clsCheckSql.CheckFieldLen(strQuestionTypeId4Course, 8, convQuestionnaire4App_T.QuestionTypeId4Course);
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId4Course, 8, convQuestionnaire4App_T.QuestionTypeId4Course);
objvQuestionnaire4App_TEN.QuestionTypeId4Course = strQuestionTypeId4Course; //题目类型Id4课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire4App_TEN.dicFldComparisonOp.ContainsKey(convQuestionnaire4App_T.QuestionTypeId4Course) == false)
{
objvQuestionnaire4App_TEN.dicFldComparisonOp.Add(convQuestionnaire4App_T.QuestionTypeId4Course, strComparisonOp);
}
else
{
objvQuestionnaire4App_TEN.dicFldComparisonOp[convQuestionnaire4App_T.QuestionTypeId4Course] = strComparisonOp;
}
}
return objvQuestionnaire4App_TEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQuestionnaire4App_TEN objvQuestionnaire4App_T_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQuestionnaire4App_T_Cond.IsUpdated(convQuestionnaire4App_T.QuestionID) == true)
{
string strComparisonOp_QuestionID = objvQuestionnaire4App_T_Cond.dicFldComparisonOp[convQuestionnaire4App_T.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App_T.QuestionID, objvQuestionnaire4App_T_Cond.QuestionID, strComparisonOp_QuestionID);
}
if (objvQuestionnaire4App_T_Cond.IsUpdated(convQuestionnaire4App_T.QuestionIndex) == true)
{
string strComparisonOp_QuestionIndex = objvQuestionnaire4App_T_Cond.dicFldComparisonOp[convQuestionnaire4App_T.QuestionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire4App_T.QuestionIndex, objvQuestionnaire4App_T_Cond.QuestionIndex, strComparisonOp_QuestionIndex);
}
if (objvQuestionnaire4App_T_Cond.IsUpdated(convQuestionnaire4App_T.QuestionName) == true)
{
string strComparisonOp_QuestionName = objvQuestionnaire4App_T_Cond.dicFldComparisonOp[convQuestionnaire4App_T.QuestionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App_T.QuestionName, objvQuestionnaire4App_T_Cond.QuestionName, strComparisonOp_QuestionName);
}
if (objvQuestionnaire4App_T_Cond.IsUpdated(convQuestionnaire4App_T.QuestionNo) == true)
{
string strComparisonOp_QuestionNo = objvQuestionnaire4App_T_Cond.dicFldComparisonOp[convQuestionnaire4App_T.QuestionNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App_T.QuestionNo, objvQuestionnaire4App_T_Cond.QuestionNo, strComparisonOp_QuestionNo);
}
if (objvQuestionnaire4App_T_Cond.IsUpdated(convQuestionnaire4App_T.CourseId) == true)
{
string strComparisonOp_CourseId = objvQuestionnaire4App_T_Cond.dicFldComparisonOp[convQuestionnaire4App_T.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App_T.CourseId, objvQuestionnaire4App_T_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvQuestionnaire4App_T_Cond.IsUpdated(convQuestionnaire4App_T.CourseChapterId) == true)
{
string strComparisonOp_CourseChapterId = objvQuestionnaire4App_T_Cond.dicFldComparisonOp[convQuestionnaire4App_T.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App_T.CourseChapterId, objvQuestionnaire4App_T_Cond.CourseChapterId, strComparisonOp_CourseChapterId);
}
if (objvQuestionnaire4App_T_Cond.IsUpdated(convQuestionnaire4App_T.ChapterId) == true)
{
string strComparisonOp_ChapterId = objvQuestionnaire4App_T_Cond.dicFldComparisonOp[convQuestionnaire4App_T.ChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App_T.ChapterId, objvQuestionnaire4App_T_Cond.ChapterId, strComparisonOp_ChapterId);
}
if (objvQuestionnaire4App_T_Cond.IsUpdated(convQuestionnaire4App_T.ChapterName) == true)
{
string strComparisonOp_ChapterName = objvQuestionnaire4App_T_Cond.dicFldComparisonOp[convQuestionnaire4App_T.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App_T.ChapterName, objvQuestionnaire4App_T_Cond.ChapterName, strComparisonOp_ChapterName);
}
if (objvQuestionnaire4App_T_Cond.IsUpdated(convQuestionnaire4App_T.ChapterName_Sim) == true)
{
string strComparisonOp_ChapterName_Sim = objvQuestionnaire4App_T_Cond.dicFldComparisonOp[convQuestionnaire4App_T.ChapterName_Sim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App_T.ChapterName_Sim, objvQuestionnaire4App_T_Cond.ChapterName_Sim, strComparisonOp_ChapterName_Sim);
}
if (objvQuestionnaire4App_T_Cond.IsUpdated(convQuestionnaire4App_T.ChapterOrderNum) == true)
{
string strComparisonOp_ChapterOrderNum = objvQuestionnaire4App_T_Cond.dicFldComparisonOp[convQuestionnaire4App_T.ChapterOrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire4App_T.ChapterOrderNum, objvQuestionnaire4App_T_Cond.ChapterOrderNum, strComparisonOp_ChapterOrderNum);
}
if (objvQuestionnaire4App_T_Cond.IsUpdated(convQuestionnaire4App_T.QuestionTypeId4Course) == true)
{
string strComparisonOp_QuestionTypeId4Course = objvQuestionnaire4App_T_Cond.dicFldComparisonOp[convQuestionnaire4App_T.QuestionTypeId4Course];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App_T.QuestionTypeId4Course, objvQuestionnaire4App_T_Cond.QuestionTypeId4Course, strComparisonOp_QuestionTypeId4Course);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v题目表4App_T(vQuestionnaire4App_T)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvQuestionnaire4App_TWApi
{
private static readonly string mstrApiControllerName = "vQuestionnaire4App_TApi";

 public clsvQuestionnaire4App_TWApi()
 {
 }

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_DdlBindFunction)
 /// </summary>
 /// <param name="objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_QuestionID(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v题目表4App_T]...","0");
List<clsvQuestionnaire4App_TEN> arrObjLst = GetObjLst("1=1");
objDDL.DataValueField="QuestionID";
objDDL.DataTextField="QuestionName";
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
public static void BindCbo_QuestionID(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convQuestionnaire4App_T.QuestionID); 
List<clsvQuestionnaire4App_TEN> arrObjLst = clsvQuestionnaire4App_TWApi.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN = new clsvQuestionnaire4App_TEN()
{
QuestionID = "0",
QuestionName = "选[v题目表4App_T]..."
};
arrObjLst.Insert(0, objvQuestionnaire4App_TEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convQuestionnaire4App_T.QuestionID;
objComboBox.DisplayMember = convQuestionnaire4App_T.QuestionName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "strQuestionID">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionnaire4App_TEN GetObjByQuestionID(string strQuestionID)
{
string strAction = "GetObjByQuestionID";
string strErrMsg = string.Empty;
string strResult = "";
clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["QuestionID"] = strQuestionID
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvQuestionnaire4App_TEN = JsonConvert.DeserializeObject<clsvQuestionnaire4App_TEN>((string)jobjReturn["ReturnObj"]);
return objvQuestionnaire4App_TEN;
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
 /// <param name = "strQuestionID">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionnaire4App_TEN GetObjByQuestionID_WA_Cache(string strQuestionID, string strCourseId)
{
string strAction = "GetObjByQuestionID_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["QuestionID"] = strQuestionID,
["CourseId"] = strCourseId
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvQuestionnaire4App_TEN = JsonConvert.DeserializeObject<clsvQuestionnaire4App_TEN>((string)jobjReturn["ReturnObj"]);
return objvQuestionnaire4App_TEN;
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
public static clsvQuestionnaire4App_TEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN = null;
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
objvQuestionnaire4App_TEN = JsonConvert.DeserializeObject<clsvQuestionnaire4App_TEN>((string)jobjReturn["ReturnObj"]);
return objvQuestionnaire4App_TEN;
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
 /// <param name = "strQuestionID">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQuestionnaire4App_TEN GetObjByQuestionID_Cache(string strQuestionID, string strCourseId)
{
if (string.IsNullOrEmpty(strQuestionID) == true) return null;
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvQuestionnaire4App_TEN._CurrTabName_S, strCourseId);
List<clsvQuestionnaire4App_TEN> arrvQuestionnaire4App_TObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvQuestionnaire4App_TEN> arrvQuestionnaire4App_TObjLst_Sel =
from objvQuestionnaire4App_TEN in arrvQuestionnaire4App_TObjLst_Cache
where objvQuestionnaire4App_TEN.QuestionID == strQuestionID
select objvQuestionnaire4App_TEN;
if (arrvQuestionnaire4App_TObjLst_Sel.Count() == 0)
{
   clsvQuestionnaire4App_TEN obj = clsvQuestionnaire4App_TWApi.GetObjByQuestionID(strQuestionID);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvQuestionnaire4App_TObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strQuestionID">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetQuestionNameByQuestionID_Cache(string strQuestionID, string strCourseId)
{
if (string.IsNullOrEmpty(strQuestionID) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvQuestionnaire4App_TEN._CurrTabName_S, strCourseId);
List<clsvQuestionnaire4App_TEN> arrvQuestionnaire4App_TObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvQuestionnaire4App_TEN> arrvQuestionnaire4App_TObjLst_Sel1 =
from objvQuestionnaire4App_TEN in arrvQuestionnaire4App_TObjLst_Cache
where objvQuestionnaire4App_TEN.QuestionID == strQuestionID
select objvQuestionnaire4App_TEN;
List <clsvQuestionnaire4App_TEN> arrvQuestionnaire4App_TObjLst_Sel = new List<clsvQuestionnaire4App_TEN>();
foreach (clsvQuestionnaire4App_TEN obj in arrvQuestionnaire4App_TObjLst_Sel1)
{
arrvQuestionnaire4App_TObjLst_Sel.Add(obj);
}
if (arrvQuestionnaire4App_TObjLst_Sel.Count > 0)
{
return arrvQuestionnaire4App_TObjLst_Sel[0].QuestionName;
}
string strErrMsgForGetObjById = string.Format("在vQuestionnaire4App_T对象缓存列表中,找不到记录[QuestionID = {0}](函数:{1})", strQuestionID, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvQuestionnaire4App_TBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetRecNameByKey_Cache)
 /// </summary>
 /// <param name = "strQuestionID">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByQuestionID_Cache(string strQuestionID, string strCourseId)
{
if (string.IsNullOrEmpty(strQuestionID) == true) return "";
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvQuestionnaire4App_TEN._CurrTabName_S, strCourseId);
List<clsvQuestionnaire4App_TEN> arrvQuestionnaire4App_TObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvQuestionnaire4App_TEN> arrvQuestionnaire4App_TObjLst_Sel1 =
from objvQuestionnaire4App_TEN in arrvQuestionnaire4App_TObjLst_Cache
where objvQuestionnaire4App_TEN.QuestionID == strQuestionID
select objvQuestionnaire4App_TEN;
List <clsvQuestionnaire4App_TEN> arrvQuestionnaire4App_TObjLst_Sel = new List<clsvQuestionnaire4App_TEN>();
foreach (clsvQuestionnaire4App_TEN obj in arrvQuestionnaire4App_TObjLst_Sel1)
{
arrvQuestionnaire4App_TObjLst_Sel.Add(obj);
}
if (arrvQuestionnaire4App_TObjLst_Sel.Count > 0)
{
return arrvQuestionnaire4App_TObjLst_Sel[0].QuestionName;
}
string strErrMsgForGetObjById = string.Format("在vQuestionnaire4App_T对象缓存列表中,找不到记录的相关名称[QuestionID = {0}](函数:{1})", strQuestionID, clsStackTrace.GetCurrFunction());
clsLog.LogErrorS2("clsvQuestionnaire4App_TBL", clsStackTrace.GetCurrClassFunction(), strErrMsgForGetObjById, "", "");
throw new Exception(strErrMsgForGetObjById);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionnaire4App_TEN> GetObjLst(string strWhereCond)
{
 List<clsvQuestionnaire4App_TEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaire4App_TEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionnaire4App_TEN> GetObjLstByQuestionIDLst(List<string> arrQuestionID)
{
 List<clsvQuestionnaire4App_TEN> arrObjLst = null; 
string strAction = "GetObjLstByQuestionIDLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrQuestionID);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaire4App_TEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "strQuestionID">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvQuestionnaire4App_TEN> GetObjLstByQuestionIDLst_Cache(List<string> arrQuestionID, string strCourseId)
{
//初始化列表缓存
string strKey = string.Format("{0}_{1}", clsvQuestionnaire4App_TEN._CurrTabName_S, strCourseId);
List<clsvQuestionnaire4App_TEN> arrvQuestionnaire4App_TObjLst_Cache = GetObjLst_Cache(strCourseId);
IEnumerable <clsvQuestionnaire4App_TEN> arrvQuestionnaire4App_TObjLst_Sel =
from objvQuestionnaire4App_TEN in arrvQuestionnaire4App_TObjLst_Cache
where arrQuestionID.Contains(objvQuestionnaire4App_TEN.QuestionID)
select objvQuestionnaire4App_TEN;
return arrvQuestionnaire4App_TObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionnaire4App_TEN> GetObjLstByQuestionIDLst_WA_Cache(List<string> arrQuestionID, string strCourseId)
{
 List<clsvQuestionnaire4App_TEN> arrObjLst = null; 
string strAction = "GetObjLstByQuestionIDLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["CourseId"] = strCourseId
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrQuestionID);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaire4App_TEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionnaire4App_TEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvQuestionnaire4App_TEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaire4App_TEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionnaire4App_TEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvQuestionnaire4App_TEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaire4App_TEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionnaire4App_TEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvQuestionnaire4App_TEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaire4App_TEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvQuestionnaire4App_TEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvQuestionnaire4App_TEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvQuestionnaire4App_TEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(string strQuestionID)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["QuestionID"] = strQuestionID
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
 /// <param name = "objvQuestionnaire4App_TENS">源对象</param>
 /// <param name = "objvQuestionnaire4App_TENT">目标对象</param>
 public static void CopyTo(clsvQuestionnaire4App_TEN objvQuestionnaire4App_TENS, clsvQuestionnaire4App_TEN objvQuestionnaire4App_TENT)
{
try
{
objvQuestionnaire4App_TENT.QuestionID = objvQuestionnaire4App_TENS.QuestionID; //题目ID
objvQuestionnaire4App_TENT.QuestionIndex = objvQuestionnaire4App_TENS.QuestionIndex; //题目序号
objvQuestionnaire4App_TENT.QuestionName = objvQuestionnaire4App_TENS.QuestionName; //题目名称
objvQuestionnaire4App_TENT.QuestionNo = objvQuestionnaire4App_TENS.QuestionNo; //题目编号
objvQuestionnaire4App_TENT.CourseId = objvQuestionnaire4App_TENS.CourseId; //课程Id
objvQuestionnaire4App_TENT.CourseChapterId = objvQuestionnaire4App_TENS.CourseChapterId; //课程章节ID
objvQuestionnaire4App_TENT.ChapterId = objvQuestionnaire4App_TENS.ChapterId; //章Id
objvQuestionnaire4App_TENT.ChapterName = objvQuestionnaire4App_TENS.ChapterName; //章名
objvQuestionnaire4App_TENT.ChapterName_Sim = objvQuestionnaire4App_TENS.ChapterName_Sim; //章名简称
objvQuestionnaire4App_TENT.ChapterOrderNum = objvQuestionnaire4App_TENS.ChapterOrderNum; //章排序号
objvQuestionnaire4App_TENT.QuestionTypeId4Course = objvQuestionnaire4App_TENS.QuestionTypeId4Course; //题目类型Id4课程
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
public static DataTable ToDataTable(List<clsvQuestionnaire4App_TEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvQuestionnaire4App_TEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvQuestionnaire4App_TEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvQuestionnaire4App_TEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvQuestionnaire4App_TEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvQuestionnaire4App_TEN.AttributeName)
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
if (clsQuestionnaireWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionnaireWApi没有刷新缓存机制(clsQuestionnaireWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseChapterWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterWApi没有刷新缓存机制(clscc_CourseChapterWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseWApi没有刷新缓存机制(clscc_CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by QuestionID");
//if (arrvQuestionnaire4App_TObjLst_Cache == null)
//{
//arrvQuestionnaire4App_TObjLst_Cache = await clsvQuestionnaire4App_TWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}_{1}", clsvQuestionnaire4App_TEN._CurrTabName_S, strCourseId);
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
public static List<clsvQuestionnaire4App_TEN> GetObjLst_Cache(string strCourseId)
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvQuestionnaire4App_TEN._CurrTabName_S, strCourseId);
List<clsvQuestionnaire4App_TEN> arrvQuestionnaire4App_TObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst(string.Format("CourseId='{0}'", strCourseId)); });
return arrvQuestionnaire4App_TObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvQuestionnaire4App_TEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convQuestionnaire4App_T.QuestionID, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire4App_T.QuestionIndex, Type.GetType("System.Int32"));
objDT.Columns.Add(convQuestionnaire4App_T.QuestionName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire4App_T.QuestionNo, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire4App_T.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire4App_T.CourseChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire4App_T.ChapterId, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire4App_T.ChapterName, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire4App_T.ChapterName_Sim, Type.GetType("System.String"));
objDT.Columns.Add(convQuestionnaire4App_T.ChapterOrderNum, Type.GetType("System.Int32"));
objDT.Columns.Add(convQuestionnaire4App_T.QuestionTypeId4Course, Type.GetType("System.String"));
foreach (clsvQuestionnaire4App_TEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convQuestionnaire4App_T.QuestionID] = objInFor[convQuestionnaire4App_T.QuestionID];
objDR[convQuestionnaire4App_T.QuestionIndex] = objInFor[convQuestionnaire4App_T.QuestionIndex];
objDR[convQuestionnaire4App_T.QuestionName] = objInFor[convQuestionnaire4App_T.QuestionName];
objDR[convQuestionnaire4App_T.QuestionNo] = objInFor[convQuestionnaire4App_T.QuestionNo];
objDR[convQuestionnaire4App_T.CourseId] = objInFor[convQuestionnaire4App_T.CourseId];
objDR[convQuestionnaire4App_T.CourseChapterId] = objInFor[convQuestionnaire4App_T.CourseChapterId];
objDR[convQuestionnaire4App_T.ChapterId] = objInFor[convQuestionnaire4App_T.ChapterId];
objDR[convQuestionnaire4App_T.ChapterName] = objInFor[convQuestionnaire4App_T.ChapterName];
objDR[convQuestionnaire4App_T.ChapterName_Sim] = objInFor[convQuestionnaire4App_T.ChapterName_Sim];
objDR[convQuestionnaire4App_T.ChapterOrderNum] = objInFor[convQuestionnaire4App_T.ChapterOrderNum];
objDR[convQuestionnaire4App_T.QuestionTypeId4Course] = objInFor[convQuestionnaire4App_T.QuestionTypeId4Course];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}