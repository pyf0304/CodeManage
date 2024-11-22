
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionnaire4App_TBL
 表名:vQuestionnaire4App_T(01120222)
 * 版本:2024.11.08.1(服务器:WIN-SRV103-116)
 日期:2024/11/09 22:30:29
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:研究生学习游戏化后台(000055, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:问卷维护(QuestionaireEdit)
 框架-层名:业务逻辑层(CS)(BusinessLogic,0003)
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
public static class  clsvQuestionnaire4App_TBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngQuestionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionnaire4App_TEN GetObj(this K_QuestionId_vQuestionnaire4App_T myKey)
{
clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN = clsvQuestionnaire4App_TBL.vQuestionnaire4App_TDA.GetObjByQuestionId(myKey.Value);
return objvQuestionnaire4App_TEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4App_TEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire4App_TEN SetQuestionId(this clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN, long lngQuestionId, string strComparisonOp="")
	{
objvQuestionnaire4App_TEN.QuestionId = lngQuestionId; //题目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire4App_TEN.dicFldComparisonOp.ContainsKey(convQuestionnaire4App_T.QuestionId) == false)
{
objvQuestionnaire4App_TEN.dicFldComparisonOp.Add(convQuestionnaire4App_T.QuestionId, strComparisonOp);
}
else
{
objvQuestionnaire4App_TEN.dicFldComparisonOp[convQuestionnaire4App_T.QuestionId] = strComparisonOp;
}
}
return objvQuestionnaire4App_TEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4App_TEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire4App_TEN SetQuestionIndex(this clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN, int? intQuestionIndex, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4App_TEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire4App_TEN SetQuestionName(this clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN, string strQuestionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionName, 500, convQuestionnaire4App_T.QuestionName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4App_TEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire4App_TEN SetQuestionNo(this clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN, string strQuestionNo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionNo, 10, convQuestionnaire4App_T.QuestionNo);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4App_TEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire4App_TEN SetCourseId(this clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convQuestionnaire4App_T.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convQuestionnaire4App_T.CourseId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4App_TEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire4App_TEN SetCourseChapterId(this clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN, string strCourseChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convQuestionnaire4App_T.CourseChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convQuestionnaire4App_T.CourseChapterId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4App_TEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire4App_TEN SetChapterId(this clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN, string strChapterId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterId, 8, convQuestionnaire4App_T.ChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strChapterId, 8, convQuestionnaire4App_T.ChapterId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4App_TEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire4App_TEN SetChapterName(this clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN, string strChapterName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterName, 100, convQuestionnaire4App_T.ChapterName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4App_TEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire4App_TEN SetChapterNameSim(this clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN, string strChapterNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strChapterNameSim, 10, convQuestionnaire4App_T.ChapterNameSim);
}
objvQuestionnaire4App_TEN.ChapterNameSim = strChapterNameSim; //章名简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire4App_TEN.dicFldComparisonOp.ContainsKey(convQuestionnaire4App_T.ChapterNameSim) == false)
{
objvQuestionnaire4App_TEN.dicFldComparisonOp.Add(convQuestionnaire4App_T.ChapterNameSim, strComparisonOp);
}
else
{
objvQuestionnaire4App_TEN.dicFldComparisonOp[convQuestionnaire4App_T.ChapterNameSim] = strComparisonOp;
}
}
return objvQuestionnaire4App_TEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4App_TEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire4App_TEN SetChapterOrderNum(this clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN, int? intChapterOrderNum, string strComparisonOp="")
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire4App_TEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire4App_TEN SetQuestionTypeId4Course(this clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN, string strQuestionTypeId4Course, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionTypeId4Course, convQuestionnaire4App_T.QuestionTypeId4Course);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeId4Course, 8, convQuestionnaire4App_T.QuestionTypeId4Course);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId4Course, 8, convQuestionnaire4App_T.QuestionTypeId4Course);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQuestionnaire4App_TENS">源对象</param>
 /// <param name = "objvQuestionnaire4App_TENT">目标对象</param>
 public static void CopyTo(this clsvQuestionnaire4App_TEN objvQuestionnaire4App_TENS, clsvQuestionnaire4App_TEN objvQuestionnaire4App_TENT)
{
try
{
objvQuestionnaire4App_TENT.QuestionId = objvQuestionnaire4App_TENS.QuestionId; //题目Id
objvQuestionnaire4App_TENT.QuestionIndex = objvQuestionnaire4App_TENS.QuestionIndex; //题目序号
objvQuestionnaire4App_TENT.QuestionName = objvQuestionnaire4App_TENS.QuestionName; //题目名称
objvQuestionnaire4App_TENT.QuestionNo = objvQuestionnaire4App_TENS.QuestionNo; //题目编号
objvQuestionnaire4App_TENT.CourseId = objvQuestionnaire4App_TENS.CourseId; //课程Id
objvQuestionnaire4App_TENT.CourseChapterId = objvQuestionnaire4App_TENS.CourseChapterId; //课程章节ID
objvQuestionnaire4App_TENT.ChapterId = objvQuestionnaire4App_TENS.ChapterId; //章Id
objvQuestionnaire4App_TENT.ChapterName = objvQuestionnaire4App_TENS.ChapterName; //章名
objvQuestionnaire4App_TENT.ChapterNameSim = objvQuestionnaire4App_TENS.ChapterNameSim; //章名简称
objvQuestionnaire4App_TENT.ChapterOrderNum = objvQuestionnaire4App_TENS.ChapterOrderNum; //章排序号
objvQuestionnaire4App_TENT.QuestionTypeId4Course = objvQuestionnaire4App_TENS.QuestionTypeId4Course; //题目类型Id4课程
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
 /// <param name = "objvQuestionnaire4App_TENS">源对象</param>
 /// <returns>目标对象=>clsvQuestionnaire4App_TEN:objvQuestionnaire4App_TENT</returns>
 public static clsvQuestionnaire4App_TEN CopyTo(this clsvQuestionnaire4App_TEN objvQuestionnaire4App_TENS)
{
try
{
 clsvQuestionnaire4App_TEN objvQuestionnaire4App_TENT = new clsvQuestionnaire4App_TEN()
{
QuestionId = objvQuestionnaire4App_TENS.QuestionId, //题目Id
QuestionIndex = objvQuestionnaire4App_TENS.QuestionIndex, //题目序号
QuestionName = objvQuestionnaire4App_TENS.QuestionName, //题目名称
QuestionNo = objvQuestionnaire4App_TENS.QuestionNo, //题目编号
CourseId = objvQuestionnaire4App_TENS.CourseId, //课程Id
CourseChapterId = objvQuestionnaire4App_TENS.CourseChapterId, //课程章节ID
ChapterId = objvQuestionnaire4App_TENS.ChapterId, //章Id
ChapterName = objvQuestionnaire4App_TENS.ChapterName, //章名
ChapterNameSim = objvQuestionnaire4App_TENS.ChapterNameSim, //章名简称
ChapterOrderNum = objvQuestionnaire4App_TENS.ChapterOrderNum, //章排序号
QuestionTypeId4Course = objvQuestionnaire4App_TENS.QuestionTypeId4Course, //题目类型Id4课程
};
 return objvQuestionnaire4App_TENT;
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
public static void CheckProperty4Condition(this clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN)
{
 clsvQuestionnaire4App_TBL.vQuestionnaire4App_TDA.CheckProperty4Condition(objvQuestionnaire4App_TEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQuestionnaire4App_TEN objvQuestionnaire4App_TCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQuestionnaire4App_TCond.IsUpdated(convQuestionnaire4App_T.QuestionId) == true)
{
string strComparisonOpQuestionId = objvQuestionnaire4App_TCond.dicFldComparisonOp[convQuestionnaire4App_T.QuestionId];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire4App_T.QuestionId, objvQuestionnaire4App_TCond.QuestionId, strComparisonOpQuestionId);
}
if (objvQuestionnaire4App_TCond.IsUpdated(convQuestionnaire4App_T.QuestionIndex) == true)
{
string strComparisonOpQuestionIndex = objvQuestionnaire4App_TCond.dicFldComparisonOp[convQuestionnaire4App_T.QuestionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire4App_T.QuestionIndex, objvQuestionnaire4App_TCond.QuestionIndex, strComparisonOpQuestionIndex);
}
if (objvQuestionnaire4App_TCond.IsUpdated(convQuestionnaire4App_T.QuestionName) == true)
{
string strComparisonOpQuestionName = objvQuestionnaire4App_TCond.dicFldComparisonOp[convQuestionnaire4App_T.QuestionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App_T.QuestionName, objvQuestionnaire4App_TCond.QuestionName, strComparisonOpQuestionName);
}
if (objvQuestionnaire4App_TCond.IsUpdated(convQuestionnaire4App_T.QuestionNo) == true)
{
string strComparisonOpQuestionNo = objvQuestionnaire4App_TCond.dicFldComparisonOp[convQuestionnaire4App_T.QuestionNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App_T.QuestionNo, objvQuestionnaire4App_TCond.QuestionNo, strComparisonOpQuestionNo);
}
if (objvQuestionnaire4App_TCond.IsUpdated(convQuestionnaire4App_T.CourseId) == true)
{
string strComparisonOpCourseId = objvQuestionnaire4App_TCond.dicFldComparisonOp[convQuestionnaire4App_T.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App_T.CourseId, objvQuestionnaire4App_TCond.CourseId, strComparisonOpCourseId);
}
if (objvQuestionnaire4App_TCond.IsUpdated(convQuestionnaire4App_T.CourseChapterId) == true)
{
string strComparisonOpCourseChapterId = objvQuestionnaire4App_TCond.dicFldComparisonOp[convQuestionnaire4App_T.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App_T.CourseChapterId, objvQuestionnaire4App_TCond.CourseChapterId, strComparisonOpCourseChapterId);
}
if (objvQuestionnaire4App_TCond.IsUpdated(convQuestionnaire4App_T.ChapterId) == true)
{
string strComparisonOpChapterId = objvQuestionnaire4App_TCond.dicFldComparisonOp[convQuestionnaire4App_T.ChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App_T.ChapterId, objvQuestionnaire4App_TCond.ChapterId, strComparisonOpChapterId);
}
if (objvQuestionnaire4App_TCond.IsUpdated(convQuestionnaire4App_T.ChapterName) == true)
{
string strComparisonOpChapterName = objvQuestionnaire4App_TCond.dicFldComparisonOp[convQuestionnaire4App_T.ChapterName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App_T.ChapterName, objvQuestionnaire4App_TCond.ChapterName, strComparisonOpChapterName);
}
if (objvQuestionnaire4App_TCond.IsUpdated(convQuestionnaire4App_T.ChapterNameSim) == true)
{
string strComparisonOpChapterNameSim = objvQuestionnaire4App_TCond.dicFldComparisonOp[convQuestionnaire4App_T.ChapterNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App_T.ChapterNameSim, objvQuestionnaire4App_TCond.ChapterNameSim, strComparisonOpChapterNameSim);
}
if (objvQuestionnaire4App_TCond.IsUpdated(convQuestionnaire4App_T.ChapterOrderNum) == true)
{
string strComparisonOpChapterOrderNum = objvQuestionnaire4App_TCond.dicFldComparisonOp[convQuestionnaire4App_T.ChapterOrderNum];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire4App_T.ChapterOrderNum, objvQuestionnaire4App_TCond.ChapterOrderNum, strComparisonOpChapterOrderNum);
}
if (objvQuestionnaire4App_TCond.IsUpdated(convQuestionnaire4App_T.QuestionTypeId4Course) == true)
{
string strComparisonOpQuestionTypeId4Course = objvQuestionnaire4App_TCond.dicFldComparisonOp[convQuestionnaire4App_T.QuestionTypeId4Course];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire4App_T.QuestionTypeId4Course, objvQuestionnaire4App_TCond.QuestionTypeId4Course, strComparisonOpQuestionTypeId4Course);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQuestionnaire4App_T
{
public virtual bool UpdRelaTabDate(long lngQuestionId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v题目表4App_T(vQuestionnaire4App_T)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQuestionnaire4App_TBL
{
public static RelatedActions_vQuestionnaire4App_T relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQuestionnaire4App_TDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQuestionnaire4App_TDA vQuestionnaire4App_TDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQuestionnaire4App_TDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQuestionnaire4App_TBL()
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
if (string.IsNullOrEmpty(clsvQuestionnaire4App_TEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQuestionnaire4App_TEN._ConnectString);
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
public static DataTable GetDataTable_vQuestionnaire4App_T(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQuestionnaire4App_TDA.GetDataTable_vQuestionnaire4App_T(strWhereCond);
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
objDT = vQuestionnaire4App_TDA.GetDataTable(strWhereCond);
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
objDT = vQuestionnaire4App_TDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQuestionnaire4App_TDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQuestionnaire4App_TDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQuestionnaire4App_TDA.GetDataTable_Top(objTopPara);
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
objDT = vQuestionnaire4App_TDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQuestionnaire4App_TDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQuestionnaire4App_TDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrQuestionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvQuestionnaire4App_TEN> GetObjLstByQuestionIdLst(List<long> arrQuestionIdLst)
{
List<clsvQuestionnaire4App_TEN> arrObjLst = new List<clsvQuestionnaire4App_TEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrQuestionIdLst);
 string strWhereCond = string.Format("QuestionId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN = new clsvQuestionnaire4App_TEN();
try
{
objvQuestionnaire4App_TEN.QuestionId = Int32.Parse(objRow[convQuestionnaire4App_T.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire4App_TEN.QuestionIndex = objRow[convQuestionnaire4App_T.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App_T.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire4App_TEN.QuestionName = objRow[convQuestionnaire4App_T.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire4App_TEN.QuestionNo = objRow[convQuestionnaire4App_T.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire4App_TEN.CourseId = objRow[convQuestionnaire4App_T.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire4App_TEN.CourseChapterId = objRow[convQuestionnaire4App_T.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire4App_TEN.ChapterId = objRow[convQuestionnaire4App_T.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire4App_TEN.ChapterName = objRow[convQuestionnaire4App_T.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.ChapterName].ToString().Trim(); //章名
objvQuestionnaire4App_TEN.ChapterNameSim = objRow[convQuestionnaire4App_T.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire4App_TEN.ChapterOrderNum = objRow[convQuestionnaire4App_T.ChapterOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App_T.ChapterOrderNum].ToString().Trim()); //章排序号
objvQuestionnaire4App_TEN.QuestionTypeId4Course = objRow[convQuestionnaire4App_T.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire4App_TEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire4App_TEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrQuestionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQuestionnaire4App_TEN> GetObjLstByQuestionIdLstCache(List<long> arrQuestionIdLst, string strCourseId)
{
string strKey = string.Format("{0}_{1}", clsvQuestionnaire4App_TEN._CurrTabName, strCourseId);
List<clsvQuestionnaire4App_TEN> arrvQuestionnaire4App_TObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvQuestionnaire4App_TEN> arrvQuestionnaire4App_TObjLst_Sel =
arrvQuestionnaire4App_TObjLstCache
.Where(x => arrQuestionIdLst.Contains(x.QuestionId));
return arrvQuestionnaire4App_TObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionnaire4App_TEN> GetObjLst(string strWhereCond)
{
List<clsvQuestionnaire4App_TEN> arrObjLst = new List<clsvQuestionnaire4App_TEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN = new clsvQuestionnaire4App_TEN();
try
{
objvQuestionnaire4App_TEN.QuestionId = Int32.Parse(objRow[convQuestionnaire4App_T.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire4App_TEN.QuestionIndex = objRow[convQuestionnaire4App_T.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App_T.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire4App_TEN.QuestionName = objRow[convQuestionnaire4App_T.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire4App_TEN.QuestionNo = objRow[convQuestionnaire4App_T.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire4App_TEN.CourseId = objRow[convQuestionnaire4App_T.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire4App_TEN.CourseChapterId = objRow[convQuestionnaire4App_T.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire4App_TEN.ChapterId = objRow[convQuestionnaire4App_T.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire4App_TEN.ChapterName = objRow[convQuestionnaire4App_T.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.ChapterName].ToString().Trim(); //章名
objvQuestionnaire4App_TEN.ChapterNameSim = objRow[convQuestionnaire4App_T.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire4App_TEN.ChapterOrderNum = objRow[convQuestionnaire4App_T.ChapterOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App_T.ChapterOrderNum].ToString().Trim()); //章排序号
objvQuestionnaire4App_TEN.QuestionTypeId4Course = objRow[convQuestionnaire4App_T.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire4App_TEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire4App_TEN);
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
public static List<clsvQuestionnaire4App_TEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQuestionnaire4App_TEN> arrObjLst = new List<clsvQuestionnaire4App_TEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN = new clsvQuestionnaire4App_TEN();
try
{
objvQuestionnaire4App_TEN.QuestionId = Int32.Parse(objRow[convQuestionnaire4App_T.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire4App_TEN.QuestionIndex = objRow[convQuestionnaire4App_T.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App_T.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire4App_TEN.QuestionName = objRow[convQuestionnaire4App_T.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire4App_TEN.QuestionNo = objRow[convQuestionnaire4App_T.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire4App_TEN.CourseId = objRow[convQuestionnaire4App_T.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire4App_TEN.CourseChapterId = objRow[convQuestionnaire4App_T.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire4App_TEN.ChapterId = objRow[convQuestionnaire4App_T.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire4App_TEN.ChapterName = objRow[convQuestionnaire4App_T.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.ChapterName].ToString().Trim(); //章名
objvQuestionnaire4App_TEN.ChapterNameSim = objRow[convQuestionnaire4App_T.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire4App_TEN.ChapterOrderNum = objRow[convQuestionnaire4App_T.ChapterOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App_T.ChapterOrderNum].ToString().Trim()); //章排序号
objvQuestionnaire4App_TEN.QuestionTypeId4Course = objRow[convQuestionnaire4App_T.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire4App_TEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire4App_TEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQuestionnaire4App_TCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQuestionnaire4App_TEN> GetSubObjLstCache(clsvQuestionnaire4App_TEN objvQuestionnaire4App_TCond)
{
 string strCourseId = objvQuestionnaire4App_TCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvQuestionnaire4App_TBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvQuestionnaire4App_TEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvQuestionnaire4App_TEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQuestionnaire4App_T.AttributeName)
{
if (objvQuestionnaire4App_TCond.IsUpdated(strFldName) == false) continue;
if (objvQuestionnaire4App_TCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionnaire4App_TCond[strFldName].ToString());
}
else
{
if (objvQuestionnaire4App_TCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQuestionnaire4App_TCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionnaire4App_TCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQuestionnaire4App_TCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQuestionnaire4App_TCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQuestionnaire4App_TCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQuestionnaire4App_TCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQuestionnaire4App_TCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQuestionnaire4App_TCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQuestionnaire4App_TCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQuestionnaire4App_TCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQuestionnaire4App_TCond[strFldName]));
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
public static List<clsvQuestionnaire4App_TEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQuestionnaire4App_TEN> arrObjLst = new List<clsvQuestionnaire4App_TEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN = new clsvQuestionnaire4App_TEN();
try
{
objvQuestionnaire4App_TEN.QuestionId = Int32.Parse(objRow[convQuestionnaire4App_T.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire4App_TEN.QuestionIndex = objRow[convQuestionnaire4App_T.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App_T.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire4App_TEN.QuestionName = objRow[convQuestionnaire4App_T.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire4App_TEN.QuestionNo = objRow[convQuestionnaire4App_T.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire4App_TEN.CourseId = objRow[convQuestionnaire4App_T.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire4App_TEN.CourseChapterId = objRow[convQuestionnaire4App_T.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire4App_TEN.ChapterId = objRow[convQuestionnaire4App_T.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire4App_TEN.ChapterName = objRow[convQuestionnaire4App_T.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.ChapterName].ToString().Trim(); //章名
objvQuestionnaire4App_TEN.ChapterNameSim = objRow[convQuestionnaire4App_T.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire4App_TEN.ChapterOrderNum = objRow[convQuestionnaire4App_T.ChapterOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App_T.ChapterOrderNum].ToString().Trim()); //章排序号
objvQuestionnaire4App_TEN.QuestionTypeId4Course = objRow[convQuestionnaire4App_T.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire4App_TEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire4App_TEN);
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
public static List<clsvQuestionnaire4App_TEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQuestionnaire4App_TEN> arrObjLst = new List<clsvQuestionnaire4App_TEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN = new clsvQuestionnaire4App_TEN();
try
{
objvQuestionnaire4App_TEN.QuestionId = Int32.Parse(objRow[convQuestionnaire4App_T.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire4App_TEN.QuestionIndex = objRow[convQuestionnaire4App_T.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App_T.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire4App_TEN.QuestionName = objRow[convQuestionnaire4App_T.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire4App_TEN.QuestionNo = objRow[convQuestionnaire4App_T.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire4App_TEN.CourseId = objRow[convQuestionnaire4App_T.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire4App_TEN.CourseChapterId = objRow[convQuestionnaire4App_T.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire4App_TEN.ChapterId = objRow[convQuestionnaire4App_T.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire4App_TEN.ChapterName = objRow[convQuestionnaire4App_T.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.ChapterName].ToString().Trim(); //章名
objvQuestionnaire4App_TEN.ChapterNameSim = objRow[convQuestionnaire4App_T.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire4App_TEN.ChapterOrderNum = objRow[convQuestionnaire4App_T.ChapterOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App_T.ChapterOrderNum].ToString().Trim()); //章排序号
objvQuestionnaire4App_TEN.QuestionTypeId4Course = objRow[convQuestionnaire4App_T.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire4App_TEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire4App_TEN);
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
List<clsvQuestionnaire4App_TEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQuestionnaire4App_TEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionnaire4App_TEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQuestionnaire4App_TEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQuestionnaire4App_TEN> arrObjLst = new List<clsvQuestionnaire4App_TEN>(); 
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
	clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN = new clsvQuestionnaire4App_TEN();
try
{
objvQuestionnaire4App_TEN.QuestionId = Int32.Parse(objRow[convQuestionnaire4App_T.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire4App_TEN.QuestionIndex = objRow[convQuestionnaire4App_T.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App_T.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire4App_TEN.QuestionName = objRow[convQuestionnaire4App_T.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire4App_TEN.QuestionNo = objRow[convQuestionnaire4App_T.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire4App_TEN.CourseId = objRow[convQuestionnaire4App_T.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire4App_TEN.CourseChapterId = objRow[convQuestionnaire4App_T.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire4App_TEN.ChapterId = objRow[convQuestionnaire4App_T.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire4App_TEN.ChapterName = objRow[convQuestionnaire4App_T.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.ChapterName].ToString().Trim(); //章名
objvQuestionnaire4App_TEN.ChapterNameSim = objRow[convQuestionnaire4App_T.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire4App_TEN.ChapterOrderNum = objRow[convQuestionnaire4App_T.ChapterOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App_T.ChapterOrderNum].ToString().Trim()); //章排序号
objvQuestionnaire4App_TEN.QuestionTypeId4Course = objRow[convQuestionnaire4App_T.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire4App_TEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire4App_TEN);
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
public static List<clsvQuestionnaire4App_TEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQuestionnaire4App_TEN> arrObjLst = new List<clsvQuestionnaire4App_TEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN = new clsvQuestionnaire4App_TEN();
try
{
objvQuestionnaire4App_TEN.QuestionId = Int32.Parse(objRow[convQuestionnaire4App_T.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire4App_TEN.QuestionIndex = objRow[convQuestionnaire4App_T.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App_T.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire4App_TEN.QuestionName = objRow[convQuestionnaire4App_T.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire4App_TEN.QuestionNo = objRow[convQuestionnaire4App_T.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire4App_TEN.CourseId = objRow[convQuestionnaire4App_T.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire4App_TEN.CourseChapterId = objRow[convQuestionnaire4App_T.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire4App_TEN.ChapterId = objRow[convQuestionnaire4App_T.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire4App_TEN.ChapterName = objRow[convQuestionnaire4App_T.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.ChapterName].ToString().Trim(); //章名
objvQuestionnaire4App_TEN.ChapterNameSim = objRow[convQuestionnaire4App_T.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire4App_TEN.ChapterOrderNum = objRow[convQuestionnaire4App_T.ChapterOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App_T.ChapterOrderNum].ToString().Trim()); //章排序号
objvQuestionnaire4App_TEN.QuestionTypeId4Course = objRow[convQuestionnaire4App_T.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire4App_TEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire4App_TEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQuestionnaire4App_TEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQuestionnaire4App_TEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQuestionnaire4App_TEN> arrObjLst = new List<clsvQuestionnaire4App_TEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN = new clsvQuestionnaire4App_TEN();
try
{
objvQuestionnaire4App_TEN.QuestionId = Int32.Parse(objRow[convQuestionnaire4App_T.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire4App_TEN.QuestionIndex = objRow[convQuestionnaire4App_T.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App_T.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire4App_TEN.QuestionName = objRow[convQuestionnaire4App_T.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire4App_TEN.QuestionNo = objRow[convQuestionnaire4App_T.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire4App_TEN.CourseId = objRow[convQuestionnaire4App_T.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire4App_TEN.CourseChapterId = objRow[convQuestionnaire4App_T.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire4App_TEN.ChapterId = objRow[convQuestionnaire4App_T.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire4App_TEN.ChapterName = objRow[convQuestionnaire4App_T.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.ChapterName].ToString().Trim(); //章名
objvQuestionnaire4App_TEN.ChapterNameSim = objRow[convQuestionnaire4App_T.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire4App_TEN.ChapterOrderNum = objRow[convQuestionnaire4App_T.ChapterOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App_T.ChapterOrderNum].ToString().Trim()); //章排序号
objvQuestionnaire4App_TEN.QuestionTypeId4Course = objRow[convQuestionnaire4App_T.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire4App_TEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire4App_TEN);
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
public static List<clsvQuestionnaire4App_TEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQuestionnaire4App_TEN> arrObjLst = new List<clsvQuestionnaire4App_TEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN = new clsvQuestionnaire4App_TEN();
try
{
objvQuestionnaire4App_TEN.QuestionId = Int32.Parse(objRow[convQuestionnaire4App_T.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire4App_TEN.QuestionIndex = objRow[convQuestionnaire4App_T.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App_T.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire4App_TEN.QuestionName = objRow[convQuestionnaire4App_T.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire4App_TEN.QuestionNo = objRow[convQuestionnaire4App_T.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire4App_TEN.CourseId = objRow[convQuestionnaire4App_T.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire4App_TEN.CourseChapterId = objRow[convQuestionnaire4App_T.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire4App_TEN.ChapterId = objRow[convQuestionnaire4App_T.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire4App_TEN.ChapterName = objRow[convQuestionnaire4App_T.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.ChapterName].ToString().Trim(); //章名
objvQuestionnaire4App_TEN.ChapterNameSim = objRow[convQuestionnaire4App_T.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire4App_TEN.ChapterOrderNum = objRow[convQuestionnaire4App_T.ChapterOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App_T.ChapterOrderNum].ToString().Trim()); //章排序号
objvQuestionnaire4App_TEN.QuestionTypeId4Course = objRow[convQuestionnaire4App_T.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire4App_TEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire4App_TEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionnaire4App_TEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQuestionnaire4App_TEN> arrObjLst = new List<clsvQuestionnaire4App_TEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN = new clsvQuestionnaire4App_TEN();
try
{
objvQuestionnaire4App_TEN.QuestionId = Int32.Parse(objRow[convQuestionnaire4App_T.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire4App_TEN.QuestionIndex = objRow[convQuestionnaire4App_T.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App_T.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire4App_TEN.QuestionName = objRow[convQuestionnaire4App_T.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire4App_TEN.QuestionNo = objRow[convQuestionnaire4App_T.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire4App_TEN.CourseId = objRow[convQuestionnaire4App_T.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire4App_TEN.CourseChapterId = objRow[convQuestionnaire4App_T.CourseChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire4App_TEN.ChapterId = objRow[convQuestionnaire4App_T.ChapterId] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.ChapterId].ToString().Trim(); //章Id
objvQuestionnaire4App_TEN.ChapterName = objRow[convQuestionnaire4App_T.ChapterName] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.ChapterName].ToString().Trim(); //章名
objvQuestionnaire4App_TEN.ChapterNameSim = objRow[convQuestionnaire4App_T.ChapterNameSim] == DBNull.Value ? null : objRow[convQuestionnaire4App_T.ChapterNameSim].ToString().Trim(); //章名简称
objvQuestionnaire4App_TEN.ChapterOrderNum = objRow[convQuestionnaire4App_T.ChapterOrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire4App_T.ChapterOrderNum].ToString().Trim()); //章排序号
objvQuestionnaire4App_TEN.QuestionTypeId4Course = objRow[convQuestionnaire4App_T.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire4App_TEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire4App_TEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQuestionnaire4App_TEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQuestionnaire4App_T(ref clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN)
{
bool bolResult = vQuestionnaire4App_TDA.GetvQuestionnaire4App_T(ref objvQuestionnaire4App_TEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngQuestionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionnaire4App_TEN GetObjByQuestionId(long lngQuestionId)
{
clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN = vQuestionnaire4App_TDA.GetObjByQuestionId(lngQuestionId);
return objvQuestionnaire4App_TEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQuestionnaire4App_TEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN = vQuestionnaire4App_TDA.GetFirstObj(strWhereCond);
 return objvQuestionnaire4App_TEN;
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
public static clsvQuestionnaire4App_TEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN = vQuestionnaire4App_TDA.GetObjByDataRow(objRow);
 return objvQuestionnaire4App_TEN;
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
public static clsvQuestionnaire4App_TEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN = vQuestionnaire4App_TDA.GetObjByDataRow(objRow);
 return objvQuestionnaire4App_TEN;
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
 /// <param name = "lngQuestionId">所给的关键字</param>
 /// <param name = "lstvQuestionnaire4App_TObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQuestionnaire4App_TEN GetObjByQuestionIdFromList(long lngQuestionId, List<clsvQuestionnaire4App_TEN> lstvQuestionnaire4App_TObjLst)
{
foreach (clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN in lstvQuestionnaire4App_TObjLst)
{
if (objvQuestionnaire4App_TEN.QuestionId == lngQuestionId)
{
return objvQuestionnaire4App_TEN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static long GetFirstID_S(string strWhereCond) 
{
 long lngQuestionId;
 try
 {
 lngQuestionId = new clsvQuestionnaire4App_TDA().GetFirstID(strWhereCond);
 return lngQuestionId;
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
 arrList = vQuestionnaire4App_TDA.GetID(strWhereCond);
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
bool bolIsExist = vQuestionnaire4App_TDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngQuestionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngQuestionId)
{
//检测记录是否存在
bool bolIsExist = vQuestionnaire4App_TDA.IsExist(lngQuestionId);
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
 bolIsExist = clsvQuestionnaire4App_TDA.IsExistTable();
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
 bolIsExist = vQuestionnaire4App_TDA.IsExistTable(strTabName);
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
 /// <param name = "objvQuestionnaire4App_TENS">源对象</param>
 /// <param name = "objvQuestionnaire4App_TENT">目标对象</param>
 public static void CopyTo(clsvQuestionnaire4App_TEN objvQuestionnaire4App_TENS, clsvQuestionnaire4App_TEN objvQuestionnaire4App_TENT)
{
try
{
objvQuestionnaire4App_TENT.QuestionId = objvQuestionnaire4App_TENS.QuestionId; //题目Id
objvQuestionnaire4App_TENT.QuestionIndex = objvQuestionnaire4App_TENS.QuestionIndex; //题目序号
objvQuestionnaire4App_TENT.QuestionName = objvQuestionnaire4App_TENS.QuestionName; //题目名称
objvQuestionnaire4App_TENT.QuestionNo = objvQuestionnaire4App_TENS.QuestionNo; //题目编号
objvQuestionnaire4App_TENT.CourseId = objvQuestionnaire4App_TENS.CourseId; //课程Id
objvQuestionnaire4App_TENT.CourseChapterId = objvQuestionnaire4App_TENS.CourseChapterId; //课程章节ID
objvQuestionnaire4App_TENT.ChapterId = objvQuestionnaire4App_TENS.ChapterId; //章Id
objvQuestionnaire4App_TENT.ChapterName = objvQuestionnaire4App_TENS.ChapterName; //章名
objvQuestionnaire4App_TENT.ChapterNameSim = objvQuestionnaire4App_TENS.ChapterNameSim; //章名简称
objvQuestionnaire4App_TENT.ChapterOrderNum = objvQuestionnaire4App_TENS.ChapterOrderNum; //章排序号
objvQuestionnaire4App_TENT.QuestionTypeId4Course = objvQuestionnaire4App_TENS.QuestionTypeId4Course; //题目类型Id4课程
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
 /// <param name = "objvQuestionnaire4App_TEN">源简化对象</param>
 public static void SetUpdFlag(clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN)
{
try
{
objvQuestionnaire4App_TEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQuestionnaire4App_TEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQuestionnaire4App_T.QuestionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire4App_TEN.QuestionId = objvQuestionnaire4App_TEN.QuestionId; //题目Id
}
if (arrFldSet.Contains(convQuestionnaire4App_T.QuestionIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire4App_TEN.QuestionIndex = objvQuestionnaire4App_TEN.QuestionIndex; //题目序号
}
if (arrFldSet.Contains(convQuestionnaire4App_T.QuestionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire4App_TEN.QuestionName = objvQuestionnaire4App_TEN.QuestionName == "[null]" ? null :  objvQuestionnaire4App_TEN.QuestionName; //题目名称
}
if (arrFldSet.Contains(convQuestionnaire4App_T.QuestionNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire4App_TEN.QuestionNo = objvQuestionnaire4App_TEN.QuestionNo == "[null]" ? null :  objvQuestionnaire4App_TEN.QuestionNo; //题目编号
}
if (arrFldSet.Contains(convQuestionnaire4App_T.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire4App_TEN.CourseId = objvQuestionnaire4App_TEN.CourseId == "[null]" ? null :  objvQuestionnaire4App_TEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convQuestionnaire4App_T.CourseChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire4App_TEN.CourseChapterId = objvQuestionnaire4App_TEN.CourseChapterId == "[null]" ? null :  objvQuestionnaire4App_TEN.CourseChapterId; //课程章节ID
}
if (arrFldSet.Contains(convQuestionnaire4App_T.ChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire4App_TEN.ChapterId = objvQuestionnaire4App_TEN.ChapterId == "[null]" ? null :  objvQuestionnaire4App_TEN.ChapterId; //章Id
}
if (arrFldSet.Contains(convQuestionnaire4App_T.ChapterName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire4App_TEN.ChapterName = objvQuestionnaire4App_TEN.ChapterName == "[null]" ? null :  objvQuestionnaire4App_TEN.ChapterName; //章名
}
if (arrFldSet.Contains(convQuestionnaire4App_T.ChapterNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire4App_TEN.ChapterNameSim = objvQuestionnaire4App_TEN.ChapterNameSim == "[null]" ? null :  objvQuestionnaire4App_TEN.ChapterNameSim; //章名简称
}
if (arrFldSet.Contains(convQuestionnaire4App_T.ChapterOrderNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire4App_TEN.ChapterOrderNum = objvQuestionnaire4App_TEN.ChapterOrderNum; //章排序号
}
if (arrFldSet.Contains(convQuestionnaire4App_T.QuestionTypeId4Course, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire4App_TEN.QuestionTypeId4Course = objvQuestionnaire4App_TEN.QuestionTypeId4Course; //题目类型Id4课程
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
 /// <param name = "objvQuestionnaire4App_TEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN)
{
try
{
if (objvQuestionnaire4App_TEN.QuestionName == "[null]") objvQuestionnaire4App_TEN.QuestionName = null; //题目名称
if (objvQuestionnaire4App_TEN.QuestionNo == "[null]") objvQuestionnaire4App_TEN.QuestionNo = null; //题目编号
if (objvQuestionnaire4App_TEN.CourseId == "[null]") objvQuestionnaire4App_TEN.CourseId = null; //课程Id
if (objvQuestionnaire4App_TEN.CourseChapterId == "[null]") objvQuestionnaire4App_TEN.CourseChapterId = null; //课程章节ID
if (objvQuestionnaire4App_TEN.ChapterId == "[null]") objvQuestionnaire4App_TEN.ChapterId = null; //章Id
if (objvQuestionnaire4App_TEN.ChapterName == "[null]") objvQuestionnaire4App_TEN.ChapterName = null; //章名
if (objvQuestionnaire4App_TEN.ChapterNameSim == "[null]") objvQuestionnaire4App_TEN.ChapterNameSim = null; //章名简称
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
public static void CheckProperty4Condition(clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN)
{
 vQuestionnaire4App_TDA.CheckProperty4Condition(objvQuestionnaire4App_TEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strCourseId"></param>
public static void BindCbo_QuestionId(System.Windows.Forms.ComboBox objComboBox , string strCourseId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convQuestionnaire4App_T.QuestionId); 
List<clsvQuestionnaire4App_TEN> arrObjLst = clsvQuestionnaire4App_TBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.CourseId == strCourseId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvQuestionnaire4App_TEN objvQuestionnaire4App_TEN = new clsvQuestionnaire4App_TEN()
{
QuestionId = 0,
QuestionName = "选[v题目表4App_T]..."
};
arrObjLstSel.Insert(0, objvQuestionnaire4App_TEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convQuestionnaire4App_T.QuestionId;
objComboBox.DisplayMember = convQuestionnaire4App_T.QuestionName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strCourseId"></param>
public static void BindDdl_QuestionId(System.Web.UI.WebControls.DropDownList objDDL , string strCourseId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v题目表4App_T]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convQuestionnaire4App_T.QuestionId); 
IEnumerable<clsvQuestionnaire4App_TEN> arrObjLst = clsvQuestionnaire4App_TBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.CourseId == strCourseId).ToList();
objDDL.DataValueField = convQuestionnaire4App_T.QuestionId;
objDDL.DataTextField = convQuestionnaire4App_T.QuestionName;
objDDL.DataSource = arrObjLstSel;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_QuestionIdCache(System.Web.UI.WebControls.DropDownList objDDL, string strCourseId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v题目表4App_T]...","0");
List<clsvQuestionnaire4App_TEN> arrvQuestionnaire4App_TObjLst = GetAllvQuestionnaire4App_TObjLstCache(strCourseId); 
objDDL.DataValueField = convQuestionnaire4App_T.QuestionId;
objDDL.DataTextField = convQuestionnaire4App_T.QuestionName;
objDDL.DataSource = arrvQuestionnaire4App_TObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}


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
if (clsQuestionnaireBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionnaireBL没有刷新缓存机制(clsQuestionnaireBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseChapterBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterBL没有刷新缓存机制(clscc_CourseChapterBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseBL没有刷新缓存机制(clscc_CourseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseTypeBL没有刷新缓存机制(clscc_CourseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExcellentTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExcellentTypeBL没有刷新缓存机制(clscc_ExcellentTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clscc_ThemesBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ThemesBL没有刷新缓存机制(clscc_ThemesBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseIsLikeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeBL没有刷新缓存机制(clscc_CourseIsLikeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by QuestionId");
//if (arrvQuestionnaire4App_TObjLstCache == null)
//{
//arrvQuestionnaire4App_TObjLstCache = vQuestionnaire4App_TDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngQuestionId">所给的关键字</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQuestionnaire4App_TEN GetObjByQuestionIdCache(long lngQuestionId, string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsvQuestionnaire4App_TEN._CurrTabName, strCourseId);
List<clsvQuestionnaire4App_TEN> arrvQuestionnaire4App_TObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvQuestionnaire4App_TEN> arrvQuestionnaire4App_TObjLst_Sel =
arrvQuestionnaire4App_TObjLstCache
.Where(x=> x.QuestionId == lngQuestionId 
);
if (arrvQuestionnaire4App_TObjLst_Sel.Count() == 0)
{
   clsvQuestionnaire4App_TEN obj = clsvQuestionnaire4App_TBL.GetObjByQuestionId(lngQuestionId);
   if (obj != null)
 {
if (obj.CourseId == strCourseId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngQuestionId, strCourseId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvQuestionnaire4App_TObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngQuestionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetQuestionNameByQuestionIdCache(long lngQuestionId, string strCourseId)
{
//获取缓存中的对象列表
clsvQuestionnaire4App_TEN objvQuestionnaire4App_T = GetObjByQuestionIdCache(lngQuestionId, strCourseId);
if (objvQuestionnaire4App_T == null) return "";
return objvQuestionnaire4App_T.QuestionName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngQuestionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByQuestionIdCache(long lngQuestionId, string strCourseId)
{
//获取缓存中的对象列表
clsvQuestionnaire4App_TEN objvQuestionnaire4App_T = GetObjByQuestionIdCache(lngQuestionId, strCourseId);
if (objvQuestionnaire4App_T == null) return "";
return objvQuestionnaire4App_T.QuestionName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQuestionnaire4App_TEN> GetAllvQuestionnaire4App_TObjLstCache(string strCourseId)
{
//获取缓存中的对象列表
List<clsvQuestionnaire4App_TEN> arrvQuestionnaire4App_TObjLstCache = GetObjLstCache(strCourseId); 
return arrvQuestionnaire4App_TObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQuestionnaire4App_TEN> GetObjLstCache(string strCourseId)
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
string strKey = string.Format("{0}_{1}", clsvQuestionnaire4App_TEN._CurrTabName, strCourseId);
string strCondition = string.Format("CourseId='{0}'", strCourseId);
List<clsvQuestionnaire4App_TEN> arrvQuestionnaire4App_TObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvQuestionnaire4App_TObjLstCache;
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
string strKey = string.Format("{0}_{1}", clsvQuestionnaire4App_TEN._CurrTabName, strCourseId);
CacheHelper.Remove(strKey);
clsvQuestionnaire4App_TEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
/// 获取最新的缓存刷新时间
/// </summary>
/// <returns>最新的缓存刷新时间，字符串型</returns>
public static string GetLastRefreshTime()
{
if (clsvQuestionnaire4App_TEN._RefreshTimeLst.Count == 0) return "";
return clsvQuestionnaire4App_TEN._RefreshTimeLst[clsvQuestionnaire4App_TEN._RefreshTimeLst.Count - 1];
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2024-11-09
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <param name = "strCourseId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngQuestionId, string strCourseId)
{
if (strInFldName != convQuestionnaire4App_T.QuestionId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQuestionnaire4App_T.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQuestionnaire4App_T.AttributeName));
throw new Exception(strMsg);
}
var objvQuestionnaire4App_T = clsvQuestionnaire4App_TBL.GetObjByQuestionIdCache(lngQuestionId, strCourseId);
if (objvQuestionnaire4App_T == null) return "";
return objvQuestionnaire4App_T[strOutFldName].ToString();
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
int intRecCount = clsvQuestionnaire4App_TDA.GetRecCount(strTabName);
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
int intRecCount = clsvQuestionnaire4App_TDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQuestionnaire4App_TDA.GetRecCount();
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
int intRecCount = clsvQuestionnaire4App_TDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQuestionnaire4App_TCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQuestionnaire4App_TEN objvQuestionnaire4App_TCond)
{
 string strCourseId = objvQuestionnaire4App_TCond.CourseId;
 if (string.IsNullOrEmpty(strCourseId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvQuestionnaire4App_TBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvQuestionnaire4App_TEN> arrObjLstCache = GetObjLstCache(strCourseId);
IEnumerable <clsvQuestionnaire4App_TEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQuestionnaire4App_T.AttributeName)
{
if (objvQuestionnaire4App_TCond.IsUpdated(strFldName) == false) continue;
if (objvQuestionnaire4App_TCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionnaire4App_TCond[strFldName].ToString());
}
else
{
if (objvQuestionnaire4App_TCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQuestionnaire4App_TCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionnaire4App_TCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQuestionnaire4App_TCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQuestionnaire4App_TCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQuestionnaire4App_TCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQuestionnaire4App_TCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQuestionnaire4App_TCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQuestionnaire4App_TCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQuestionnaire4App_TCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQuestionnaire4App_TCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQuestionnaire4App_TCond[strFldName]));
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
 List<string> arrList = clsvQuestionnaire4App_TDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQuestionnaire4App_TDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQuestionnaire4App_TDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}