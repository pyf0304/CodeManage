
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionnaire_SimBL
 表名:vQuestionnaire_Sim(01120949)
 * 版本:2024.11.10.1(服务器:WIN-SRV103-116)
 日期:2024/11/12 09:25:09
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
public static class  clsvQuestionnaire_SimBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngQuestionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionnaire_SimEN GetObj(this K_QuestionId_vQuestionnaire_Sim myKey)
{
clsvQuestionnaire_SimEN objvQuestionnaire_SimEN = clsvQuestionnaire_SimBL.vQuestionnaire_SimDA.GetObjByQuestionId(myKey.Value);
return objvQuestionnaire_SimEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_SimEN SetQuestionId(this clsvQuestionnaire_SimEN objvQuestionnaire_SimEN, long lngQuestionId, string strComparisonOp="")
	{
objvQuestionnaire_SimEN.QuestionId = lngQuestionId; //题目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_SimEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Sim.QuestionId) == false)
{
objvQuestionnaire_SimEN.dicFldComparisonOp.Add(convQuestionnaire_Sim.QuestionId, strComparisonOp);
}
else
{
objvQuestionnaire_SimEN.dicFldComparisonOp[convQuestionnaire_Sim.QuestionId] = strComparisonOp;
}
}
return objvQuestionnaire_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_SimEN SetQuestionName(this clsvQuestionnaire_SimEN objvQuestionnaire_SimEN, string strQuestionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionName, 500, convQuestionnaire_Sim.QuestionName);
}
objvQuestionnaire_SimEN.QuestionName = strQuestionName; //题目名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_SimEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Sim.QuestionName) == false)
{
objvQuestionnaire_SimEN.dicFldComparisonOp.Add(convQuestionnaire_Sim.QuestionName, strComparisonOp);
}
else
{
objvQuestionnaire_SimEN.dicFldComparisonOp[convQuestionnaire_Sim.QuestionName] = strComparisonOp;
}
}
return objvQuestionnaire_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_SimEN SetQuestionIndex(this clsvQuestionnaire_SimEN objvQuestionnaire_SimEN, int? intQuestionIndex, string strComparisonOp="")
	{
objvQuestionnaire_SimEN.QuestionIndex = intQuestionIndex; //题目序号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_SimEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Sim.QuestionIndex) == false)
{
objvQuestionnaire_SimEN.dicFldComparisonOp.Add(convQuestionnaire_Sim.QuestionIndex, strComparisonOp);
}
else
{
objvQuestionnaire_SimEN.dicFldComparisonOp[convQuestionnaire_Sim.QuestionIndex] = strComparisonOp;
}
}
return objvQuestionnaire_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_SimEN SetQuestionNo(this clsvQuestionnaire_SimEN objvQuestionnaire_SimEN, string strQuestionNo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionNo, 10, convQuestionnaire_Sim.QuestionNo);
}
objvQuestionnaire_SimEN.QuestionNo = strQuestionNo; //题目编号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_SimEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Sim.QuestionNo) == false)
{
objvQuestionnaire_SimEN.dicFldComparisonOp.Add(convQuestionnaire_Sim.QuestionNo, strComparisonOp);
}
else
{
objvQuestionnaire_SimEN.dicFldComparisonOp[convQuestionnaire_Sim.QuestionNo] = strComparisonOp;
}
}
return objvQuestionnaire_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_SimEN SetCourseId(this clsvQuestionnaire_SimEN objvQuestionnaire_SimEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convQuestionnaire_Sim.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convQuestionnaire_Sim.CourseId);
}
objvQuestionnaire_SimEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_SimEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Sim.CourseId) == false)
{
objvQuestionnaire_SimEN.dicFldComparisonOp.Add(convQuestionnaire_Sim.CourseId, strComparisonOp);
}
else
{
objvQuestionnaire_SimEN.dicFldComparisonOp[convQuestionnaire_Sim.CourseId] = strComparisonOp;
}
}
return objvQuestionnaire_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_SimEN SetCourseChapterId(this clsvQuestionnaire_SimEN objvQuestionnaire_SimEN, string strCourseChapterId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseChapterId, convQuestionnaire_Sim.CourseChapterId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseChapterId, 8, convQuestionnaire_Sim.CourseChapterId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseChapterId, 8, convQuestionnaire_Sim.CourseChapterId);
}
objvQuestionnaire_SimEN.CourseChapterId = strCourseChapterId; //课程章节ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_SimEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Sim.CourseChapterId) == false)
{
objvQuestionnaire_SimEN.dicFldComparisonOp.Add(convQuestionnaire_Sim.CourseChapterId, strComparisonOp);
}
else
{
objvQuestionnaire_SimEN.dicFldComparisonOp[convQuestionnaire_Sim.CourseChapterId] = strComparisonOp;
}
}
return objvQuestionnaire_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_SimEN SetParentQuestionId(this clsvQuestionnaire_SimEN objvQuestionnaire_SimEN, string strParentQuestionId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentQuestionId, 8, convQuestionnaire_Sim.ParentQuestionId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strParentQuestionId, 8, convQuestionnaire_Sim.ParentQuestionId);
}
objvQuestionnaire_SimEN.ParentQuestionId = strParentQuestionId; //父题目Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_SimEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Sim.ParentQuestionId) == false)
{
objvQuestionnaire_SimEN.dicFldComparisonOp.Add(convQuestionnaire_Sim.ParentQuestionId, strComparisonOp);
}
else
{
objvQuestionnaire_SimEN.dicFldComparisonOp[convQuestionnaire_Sim.ParentQuestionId] = strComparisonOp;
}
}
return objvQuestionnaire_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_SimEN SetQuestionTypeId(this clsvQuestionnaire_SimEN objvQuestionnaire_SimEN, string strQuestionTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeId, 2, convQuestionnaire_Sim.QuestionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId, 2, convQuestionnaire_Sim.QuestionTypeId);
}
objvQuestionnaire_SimEN.QuestionTypeId = strQuestionTypeId; //题目类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_SimEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Sim.QuestionTypeId) == false)
{
objvQuestionnaire_SimEN.dicFldComparisonOp.Add(convQuestionnaire_Sim.QuestionTypeId, strComparisonOp);
}
else
{
objvQuestionnaire_SimEN.dicFldComparisonOp[convQuestionnaire_Sim.QuestionTypeId] = strComparisonOp;
}
}
return objvQuestionnaire_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_SimEN SetQuestionTypeId4Course(this clsvQuestionnaire_SimEN objvQuestionnaire_SimEN, string strQuestionTypeId4Course, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strQuestionTypeId4Course, convQuestionnaire_Sim.QuestionTypeId4Course);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionTypeId4Course, 8, convQuestionnaire_Sim.QuestionTypeId4Course);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionTypeId4Course, 8, convQuestionnaire_Sim.QuestionTypeId4Course);
}
objvQuestionnaire_SimEN.QuestionTypeId4Course = strQuestionTypeId4Course; //题目类型Id4课程
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_SimEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Sim.QuestionTypeId4Course) == false)
{
objvQuestionnaire_SimEN.dicFldComparisonOp.Add(convQuestionnaire_Sim.QuestionTypeId4Course, strComparisonOp);
}
else
{
objvQuestionnaire_SimEN.dicFldComparisonOp[convQuestionnaire_Sim.QuestionTypeId4Course] = strComparisonOp;
}
}
return objvQuestionnaire_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_SimEN SetAnswerTypeId(this clsvQuestionnaire_SimEN objvQuestionnaire_SimEN, string strAnswerTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAnswerTypeId, 2, convQuestionnaire_Sim.AnswerTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAnswerTypeId, 2, convQuestionnaire_Sim.AnswerTypeId);
}
objvQuestionnaire_SimEN.AnswerTypeId = strAnswerTypeId; //答案类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_SimEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Sim.AnswerTypeId) == false)
{
objvQuestionnaire_SimEN.dicFldComparisonOp.Add(convQuestionnaire_Sim.AnswerTypeId, strComparisonOp);
}
else
{
objvQuestionnaire_SimEN.dicFldComparisonOp[convQuestionnaire_Sim.AnswerTypeId] = strComparisonOp;
}
}
return objvQuestionnaire_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_SimEN SetIsShow(this clsvQuestionnaire_SimEN objvQuestionnaire_SimEN, bool bolIsShow, string strComparisonOp="")
	{
objvQuestionnaire_SimEN.IsShow = bolIsShow; //是否启用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_SimEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Sim.IsShow) == false)
{
objvQuestionnaire_SimEN.dicFldComparisonOp.Add(convQuestionnaire_Sim.IsShow, strComparisonOp);
}
else
{
objvQuestionnaire_SimEN.dicFldComparisonOp[convQuestionnaire_Sim.IsShow] = strComparisonOp;
}
}
return objvQuestionnaire_SimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionnaire_SimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionnaire_SimEN SetDifficultyLevelId(this clsvQuestionnaire_SimEN objvQuestionnaire_SimEN, string strDifficultyLevelId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDifficultyLevelId, 2, convQuestionnaire_Sim.DifficultyLevelId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDifficultyLevelId, 2, convQuestionnaire_Sim.DifficultyLevelId);
}
objvQuestionnaire_SimEN.DifficultyLevelId = strDifficultyLevelId; //难度等级Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionnaire_SimEN.dicFldComparisonOp.ContainsKey(convQuestionnaire_Sim.DifficultyLevelId) == false)
{
objvQuestionnaire_SimEN.dicFldComparisonOp.Add(convQuestionnaire_Sim.DifficultyLevelId, strComparisonOp);
}
else
{
objvQuestionnaire_SimEN.dicFldComparisonOp[convQuestionnaire_Sim.DifficultyLevelId] = strComparisonOp;
}
}
return objvQuestionnaire_SimEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQuestionnaire_SimENS">源对象</param>
 /// <param name = "objvQuestionnaire_SimENT">目标对象</param>
 public static void CopyTo(this clsvQuestionnaire_SimEN objvQuestionnaire_SimENS, clsvQuestionnaire_SimEN objvQuestionnaire_SimENT)
{
try
{
objvQuestionnaire_SimENT.QuestionId = objvQuestionnaire_SimENS.QuestionId; //题目Id
objvQuestionnaire_SimENT.QuestionName = objvQuestionnaire_SimENS.QuestionName; //题目名称
objvQuestionnaire_SimENT.QuestionIndex = objvQuestionnaire_SimENS.QuestionIndex; //题目序号
objvQuestionnaire_SimENT.QuestionNo = objvQuestionnaire_SimENS.QuestionNo; //题目编号
objvQuestionnaire_SimENT.CourseId = objvQuestionnaire_SimENS.CourseId; //课程Id
objvQuestionnaire_SimENT.CourseChapterId = objvQuestionnaire_SimENS.CourseChapterId; //课程章节ID
objvQuestionnaire_SimENT.ParentQuestionId = objvQuestionnaire_SimENS.ParentQuestionId; //父题目Id
objvQuestionnaire_SimENT.QuestionTypeId = objvQuestionnaire_SimENS.QuestionTypeId; //题目类型Id
objvQuestionnaire_SimENT.QuestionTypeId4Course = objvQuestionnaire_SimENS.QuestionTypeId4Course; //题目类型Id4课程
objvQuestionnaire_SimENT.AnswerTypeId = objvQuestionnaire_SimENS.AnswerTypeId; //答案类型ID
objvQuestionnaire_SimENT.IsShow = objvQuestionnaire_SimENS.IsShow; //是否启用
objvQuestionnaire_SimENT.DifficultyLevelId = objvQuestionnaire_SimENS.DifficultyLevelId; //难度等级Id
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
 /// <param name = "objvQuestionnaire_SimENS">源对象</param>
 /// <returns>目标对象=>clsvQuestionnaire_SimEN:objvQuestionnaire_SimENT</returns>
 public static clsvQuestionnaire_SimEN CopyTo(this clsvQuestionnaire_SimEN objvQuestionnaire_SimENS)
{
try
{
 clsvQuestionnaire_SimEN objvQuestionnaire_SimENT = new clsvQuestionnaire_SimEN()
{
QuestionId = objvQuestionnaire_SimENS.QuestionId, //题目Id
QuestionName = objvQuestionnaire_SimENS.QuestionName, //题目名称
QuestionIndex = objvQuestionnaire_SimENS.QuestionIndex, //题目序号
QuestionNo = objvQuestionnaire_SimENS.QuestionNo, //题目编号
CourseId = objvQuestionnaire_SimENS.CourseId, //课程Id
CourseChapterId = objvQuestionnaire_SimENS.CourseChapterId, //课程章节ID
ParentQuestionId = objvQuestionnaire_SimENS.ParentQuestionId, //父题目Id
QuestionTypeId = objvQuestionnaire_SimENS.QuestionTypeId, //题目类型Id
QuestionTypeId4Course = objvQuestionnaire_SimENS.QuestionTypeId4Course, //题目类型Id4课程
AnswerTypeId = objvQuestionnaire_SimENS.AnswerTypeId, //答案类型ID
IsShow = objvQuestionnaire_SimENS.IsShow, //是否启用
DifficultyLevelId = objvQuestionnaire_SimENS.DifficultyLevelId, //难度等级Id
};
 return objvQuestionnaire_SimENT;
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
public static void CheckProperty4Condition(this clsvQuestionnaire_SimEN objvQuestionnaire_SimEN)
{
 clsvQuestionnaire_SimBL.vQuestionnaire_SimDA.CheckProperty4Condition(objvQuestionnaire_SimEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQuestionnaire_SimEN objvQuestionnaire_SimCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQuestionnaire_SimCond.IsUpdated(convQuestionnaire_Sim.QuestionId) == true)
{
string strComparisonOpQuestionId = objvQuestionnaire_SimCond.dicFldComparisonOp[convQuestionnaire_Sim.QuestionId];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire_Sim.QuestionId, objvQuestionnaire_SimCond.QuestionId, strComparisonOpQuestionId);
}
if (objvQuestionnaire_SimCond.IsUpdated(convQuestionnaire_Sim.QuestionName) == true)
{
string strComparisonOpQuestionName = objvQuestionnaire_SimCond.dicFldComparisonOp[convQuestionnaire_Sim.QuestionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Sim.QuestionName, objvQuestionnaire_SimCond.QuestionName, strComparisonOpQuestionName);
}
if (objvQuestionnaire_SimCond.IsUpdated(convQuestionnaire_Sim.QuestionIndex) == true)
{
string strComparisonOpQuestionIndex = objvQuestionnaire_SimCond.dicFldComparisonOp[convQuestionnaire_Sim.QuestionIndex];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionnaire_Sim.QuestionIndex, objvQuestionnaire_SimCond.QuestionIndex, strComparisonOpQuestionIndex);
}
if (objvQuestionnaire_SimCond.IsUpdated(convQuestionnaire_Sim.QuestionNo) == true)
{
string strComparisonOpQuestionNo = objvQuestionnaire_SimCond.dicFldComparisonOp[convQuestionnaire_Sim.QuestionNo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Sim.QuestionNo, objvQuestionnaire_SimCond.QuestionNo, strComparisonOpQuestionNo);
}
if (objvQuestionnaire_SimCond.IsUpdated(convQuestionnaire_Sim.CourseId) == true)
{
string strComparisonOpCourseId = objvQuestionnaire_SimCond.dicFldComparisonOp[convQuestionnaire_Sim.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Sim.CourseId, objvQuestionnaire_SimCond.CourseId, strComparisonOpCourseId);
}
if (objvQuestionnaire_SimCond.IsUpdated(convQuestionnaire_Sim.CourseChapterId) == true)
{
string strComparisonOpCourseChapterId = objvQuestionnaire_SimCond.dicFldComparisonOp[convQuestionnaire_Sim.CourseChapterId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Sim.CourseChapterId, objvQuestionnaire_SimCond.CourseChapterId, strComparisonOpCourseChapterId);
}
if (objvQuestionnaire_SimCond.IsUpdated(convQuestionnaire_Sim.ParentQuestionId) == true)
{
string strComparisonOpParentQuestionId = objvQuestionnaire_SimCond.dicFldComparisonOp[convQuestionnaire_Sim.ParentQuestionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Sim.ParentQuestionId, objvQuestionnaire_SimCond.ParentQuestionId, strComparisonOpParentQuestionId);
}
if (objvQuestionnaire_SimCond.IsUpdated(convQuestionnaire_Sim.QuestionTypeId) == true)
{
string strComparisonOpQuestionTypeId = objvQuestionnaire_SimCond.dicFldComparisonOp[convQuestionnaire_Sim.QuestionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Sim.QuestionTypeId, objvQuestionnaire_SimCond.QuestionTypeId, strComparisonOpQuestionTypeId);
}
if (objvQuestionnaire_SimCond.IsUpdated(convQuestionnaire_Sim.QuestionTypeId4Course) == true)
{
string strComparisonOpQuestionTypeId4Course = objvQuestionnaire_SimCond.dicFldComparisonOp[convQuestionnaire_Sim.QuestionTypeId4Course];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Sim.QuestionTypeId4Course, objvQuestionnaire_SimCond.QuestionTypeId4Course, strComparisonOpQuestionTypeId4Course);
}
if (objvQuestionnaire_SimCond.IsUpdated(convQuestionnaire_Sim.AnswerTypeId) == true)
{
string strComparisonOpAnswerTypeId = objvQuestionnaire_SimCond.dicFldComparisonOp[convQuestionnaire_Sim.AnswerTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Sim.AnswerTypeId, objvQuestionnaire_SimCond.AnswerTypeId, strComparisonOpAnswerTypeId);
}
if (objvQuestionnaire_SimCond.IsUpdated(convQuestionnaire_Sim.IsShow) == true)
{
if (objvQuestionnaire_SimCond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQuestionnaire_Sim.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQuestionnaire_Sim.IsShow);
}
}
if (objvQuestionnaire_SimCond.IsUpdated(convQuestionnaire_Sim.DifficultyLevelId) == true)
{
string strComparisonOpDifficultyLevelId = objvQuestionnaire_SimCond.dicFldComparisonOp[convQuestionnaire_Sim.DifficultyLevelId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionnaire_Sim.DifficultyLevelId, objvQuestionnaire_SimCond.DifficultyLevelId, strComparisonOpDifficultyLevelId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQuestionnaire_Sim
{
public virtual bool UpdRelaTabDate(long lngQuestionId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vQuestionnaire_Sim(vQuestionnaire_Sim)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQuestionnaire_SimBL
{
public static RelatedActions_vQuestionnaire_Sim relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQuestionnaire_SimDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQuestionnaire_SimDA vQuestionnaire_SimDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQuestionnaire_SimDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQuestionnaire_SimBL()
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
if (string.IsNullOrEmpty(clsvQuestionnaire_SimEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQuestionnaire_SimEN._ConnectString);
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
public static DataTable GetDataTable_vQuestionnaire_Sim(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQuestionnaire_SimDA.GetDataTable_vQuestionnaire_Sim(strWhereCond);
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
objDT = vQuestionnaire_SimDA.GetDataTable(strWhereCond);
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
objDT = vQuestionnaire_SimDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQuestionnaire_SimDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQuestionnaire_SimDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQuestionnaire_SimDA.GetDataTable_Top(objTopPara);
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
objDT = vQuestionnaire_SimDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQuestionnaire_SimDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQuestionnaire_SimDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvQuestionnaire_SimEN> GetObjLstByQuestionIdLst(List<long> arrQuestionIdLst)
{
List<clsvQuestionnaire_SimEN> arrObjLst = new List<clsvQuestionnaire_SimEN>(); 
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
	clsvQuestionnaire_SimEN objvQuestionnaire_SimEN = new clsvQuestionnaire_SimEN();
try
{
objvQuestionnaire_SimEN.QuestionId = Int32.Parse(objRow[convQuestionnaire_Sim.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire_SimEN.QuestionName = objRow[convQuestionnaire_Sim.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire_SimEN.QuestionIndex = objRow[convQuestionnaire_Sim.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Sim.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire_SimEN.QuestionNo = objRow[convQuestionnaire_Sim.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire_SimEN.CourseId = objRow[convQuestionnaire_Sim.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire_SimEN.CourseChapterId = objRow[convQuestionnaire_Sim.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire_SimEN.ParentQuestionId = objRow[convQuestionnaire_Sim.ParentQuestionId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.ParentQuestionId].ToString().Trim(); //父题目Id
objvQuestionnaire_SimEN.QuestionTypeId = objRow[convQuestionnaire_Sim.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire_SimEN.QuestionTypeId4Course = objRow[convQuestionnaire_Sim.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionnaire_SimEN.AnswerTypeId = objRow[convQuestionnaire_Sim.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaire_SimEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Sim.IsShow].ToString().Trim()); //是否启用
objvQuestionnaire_SimEN.DifficultyLevelId = objRow[convQuestionnaire_Sim.DifficultyLevelId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.DifficultyLevelId].ToString().Trim(); //难度等级Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire_SimEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrQuestionIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQuestionnaire_SimEN> GetObjLstByQuestionIdLstCache(List<long> arrQuestionIdLst)
{
string strKey = string.Format("{0}", clsvQuestionnaire_SimEN._CurrTabName);
List<clsvQuestionnaire_SimEN> arrvQuestionnaire_SimObjLstCache = GetObjLstCache();
IEnumerable <clsvQuestionnaire_SimEN> arrvQuestionnaire_SimObjLst_Sel =
arrvQuestionnaire_SimObjLstCache
.Where(x => arrQuestionIdLst.Contains(x.QuestionId));
return arrvQuestionnaire_SimObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionnaire_SimEN> GetObjLst(string strWhereCond)
{
List<clsvQuestionnaire_SimEN> arrObjLst = new List<clsvQuestionnaire_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire_SimEN objvQuestionnaire_SimEN = new clsvQuestionnaire_SimEN();
try
{
objvQuestionnaire_SimEN.QuestionId = Int32.Parse(objRow[convQuestionnaire_Sim.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire_SimEN.QuestionName = objRow[convQuestionnaire_Sim.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire_SimEN.QuestionIndex = objRow[convQuestionnaire_Sim.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Sim.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire_SimEN.QuestionNo = objRow[convQuestionnaire_Sim.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire_SimEN.CourseId = objRow[convQuestionnaire_Sim.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire_SimEN.CourseChapterId = objRow[convQuestionnaire_Sim.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire_SimEN.ParentQuestionId = objRow[convQuestionnaire_Sim.ParentQuestionId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.ParentQuestionId].ToString().Trim(); //父题目Id
objvQuestionnaire_SimEN.QuestionTypeId = objRow[convQuestionnaire_Sim.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire_SimEN.QuestionTypeId4Course = objRow[convQuestionnaire_Sim.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionnaire_SimEN.AnswerTypeId = objRow[convQuestionnaire_Sim.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaire_SimEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Sim.IsShow].ToString().Trim()); //是否启用
objvQuestionnaire_SimEN.DifficultyLevelId = objRow[convQuestionnaire_Sim.DifficultyLevelId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.DifficultyLevelId].ToString().Trim(); //难度等级Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire_SimEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire_SimEN);
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
public static List<clsvQuestionnaire_SimEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQuestionnaire_SimEN> arrObjLst = new List<clsvQuestionnaire_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire_SimEN objvQuestionnaire_SimEN = new clsvQuestionnaire_SimEN();
try
{
objvQuestionnaire_SimEN.QuestionId = Int32.Parse(objRow[convQuestionnaire_Sim.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire_SimEN.QuestionName = objRow[convQuestionnaire_Sim.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire_SimEN.QuestionIndex = objRow[convQuestionnaire_Sim.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Sim.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire_SimEN.QuestionNo = objRow[convQuestionnaire_Sim.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire_SimEN.CourseId = objRow[convQuestionnaire_Sim.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire_SimEN.CourseChapterId = objRow[convQuestionnaire_Sim.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire_SimEN.ParentQuestionId = objRow[convQuestionnaire_Sim.ParentQuestionId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.ParentQuestionId].ToString().Trim(); //父题目Id
objvQuestionnaire_SimEN.QuestionTypeId = objRow[convQuestionnaire_Sim.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire_SimEN.QuestionTypeId4Course = objRow[convQuestionnaire_Sim.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionnaire_SimEN.AnswerTypeId = objRow[convQuestionnaire_Sim.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaire_SimEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Sim.IsShow].ToString().Trim()); //是否启用
objvQuestionnaire_SimEN.DifficultyLevelId = objRow[convQuestionnaire_Sim.DifficultyLevelId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.DifficultyLevelId].ToString().Trim(); //难度等级Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire_SimEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQuestionnaire_SimCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQuestionnaire_SimEN> GetSubObjLstCache(clsvQuestionnaire_SimEN objvQuestionnaire_SimCond)
{
List<clsvQuestionnaire_SimEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQuestionnaire_SimEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQuestionnaire_Sim.AttributeName)
{
if (objvQuestionnaire_SimCond.IsUpdated(strFldName) == false) continue;
if (objvQuestionnaire_SimCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionnaire_SimCond[strFldName].ToString());
}
else
{
if (objvQuestionnaire_SimCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQuestionnaire_SimCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionnaire_SimCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQuestionnaire_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQuestionnaire_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQuestionnaire_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQuestionnaire_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQuestionnaire_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQuestionnaire_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQuestionnaire_SimCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQuestionnaire_SimCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQuestionnaire_SimCond[strFldName]));
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
public static List<clsvQuestionnaire_SimEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQuestionnaire_SimEN> arrObjLst = new List<clsvQuestionnaire_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire_SimEN objvQuestionnaire_SimEN = new clsvQuestionnaire_SimEN();
try
{
objvQuestionnaire_SimEN.QuestionId = Int32.Parse(objRow[convQuestionnaire_Sim.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire_SimEN.QuestionName = objRow[convQuestionnaire_Sim.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire_SimEN.QuestionIndex = objRow[convQuestionnaire_Sim.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Sim.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire_SimEN.QuestionNo = objRow[convQuestionnaire_Sim.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire_SimEN.CourseId = objRow[convQuestionnaire_Sim.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire_SimEN.CourseChapterId = objRow[convQuestionnaire_Sim.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire_SimEN.ParentQuestionId = objRow[convQuestionnaire_Sim.ParentQuestionId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.ParentQuestionId].ToString().Trim(); //父题目Id
objvQuestionnaire_SimEN.QuestionTypeId = objRow[convQuestionnaire_Sim.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire_SimEN.QuestionTypeId4Course = objRow[convQuestionnaire_Sim.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionnaire_SimEN.AnswerTypeId = objRow[convQuestionnaire_Sim.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaire_SimEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Sim.IsShow].ToString().Trim()); //是否启用
objvQuestionnaire_SimEN.DifficultyLevelId = objRow[convQuestionnaire_Sim.DifficultyLevelId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.DifficultyLevelId].ToString().Trim(); //难度等级Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire_SimEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire_SimEN);
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
public static List<clsvQuestionnaire_SimEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQuestionnaire_SimEN> arrObjLst = new List<clsvQuestionnaire_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire_SimEN objvQuestionnaire_SimEN = new clsvQuestionnaire_SimEN();
try
{
objvQuestionnaire_SimEN.QuestionId = Int32.Parse(objRow[convQuestionnaire_Sim.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire_SimEN.QuestionName = objRow[convQuestionnaire_Sim.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire_SimEN.QuestionIndex = objRow[convQuestionnaire_Sim.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Sim.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire_SimEN.QuestionNo = objRow[convQuestionnaire_Sim.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire_SimEN.CourseId = objRow[convQuestionnaire_Sim.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire_SimEN.CourseChapterId = objRow[convQuestionnaire_Sim.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire_SimEN.ParentQuestionId = objRow[convQuestionnaire_Sim.ParentQuestionId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.ParentQuestionId].ToString().Trim(); //父题目Id
objvQuestionnaire_SimEN.QuestionTypeId = objRow[convQuestionnaire_Sim.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire_SimEN.QuestionTypeId4Course = objRow[convQuestionnaire_Sim.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionnaire_SimEN.AnswerTypeId = objRow[convQuestionnaire_Sim.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaire_SimEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Sim.IsShow].ToString().Trim()); //是否启用
objvQuestionnaire_SimEN.DifficultyLevelId = objRow[convQuestionnaire_Sim.DifficultyLevelId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.DifficultyLevelId].ToString().Trim(); //难度等级Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire_SimEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire_SimEN);
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
List<clsvQuestionnaire_SimEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQuestionnaire_SimEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionnaire_SimEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQuestionnaire_SimEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQuestionnaire_SimEN> arrObjLst = new List<clsvQuestionnaire_SimEN>(); 
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
	clsvQuestionnaire_SimEN objvQuestionnaire_SimEN = new clsvQuestionnaire_SimEN();
try
{
objvQuestionnaire_SimEN.QuestionId = Int32.Parse(objRow[convQuestionnaire_Sim.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire_SimEN.QuestionName = objRow[convQuestionnaire_Sim.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire_SimEN.QuestionIndex = objRow[convQuestionnaire_Sim.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Sim.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire_SimEN.QuestionNo = objRow[convQuestionnaire_Sim.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire_SimEN.CourseId = objRow[convQuestionnaire_Sim.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire_SimEN.CourseChapterId = objRow[convQuestionnaire_Sim.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire_SimEN.ParentQuestionId = objRow[convQuestionnaire_Sim.ParentQuestionId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.ParentQuestionId].ToString().Trim(); //父题目Id
objvQuestionnaire_SimEN.QuestionTypeId = objRow[convQuestionnaire_Sim.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire_SimEN.QuestionTypeId4Course = objRow[convQuestionnaire_Sim.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionnaire_SimEN.AnswerTypeId = objRow[convQuestionnaire_Sim.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaire_SimEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Sim.IsShow].ToString().Trim()); //是否启用
objvQuestionnaire_SimEN.DifficultyLevelId = objRow[convQuestionnaire_Sim.DifficultyLevelId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.DifficultyLevelId].ToString().Trim(); //难度等级Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire_SimEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire_SimEN);
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
public static List<clsvQuestionnaire_SimEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQuestionnaire_SimEN> arrObjLst = new List<clsvQuestionnaire_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire_SimEN objvQuestionnaire_SimEN = new clsvQuestionnaire_SimEN();
try
{
objvQuestionnaire_SimEN.QuestionId = Int32.Parse(objRow[convQuestionnaire_Sim.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire_SimEN.QuestionName = objRow[convQuestionnaire_Sim.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire_SimEN.QuestionIndex = objRow[convQuestionnaire_Sim.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Sim.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire_SimEN.QuestionNo = objRow[convQuestionnaire_Sim.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire_SimEN.CourseId = objRow[convQuestionnaire_Sim.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire_SimEN.CourseChapterId = objRow[convQuestionnaire_Sim.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire_SimEN.ParentQuestionId = objRow[convQuestionnaire_Sim.ParentQuestionId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.ParentQuestionId].ToString().Trim(); //父题目Id
objvQuestionnaire_SimEN.QuestionTypeId = objRow[convQuestionnaire_Sim.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire_SimEN.QuestionTypeId4Course = objRow[convQuestionnaire_Sim.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionnaire_SimEN.AnswerTypeId = objRow[convQuestionnaire_Sim.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaire_SimEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Sim.IsShow].ToString().Trim()); //是否启用
objvQuestionnaire_SimEN.DifficultyLevelId = objRow[convQuestionnaire_Sim.DifficultyLevelId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.DifficultyLevelId].ToString().Trim(); //难度等级Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire_SimEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQuestionnaire_SimEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQuestionnaire_SimEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQuestionnaire_SimEN> arrObjLst = new List<clsvQuestionnaire_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire_SimEN objvQuestionnaire_SimEN = new clsvQuestionnaire_SimEN();
try
{
objvQuestionnaire_SimEN.QuestionId = Int32.Parse(objRow[convQuestionnaire_Sim.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire_SimEN.QuestionName = objRow[convQuestionnaire_Sim.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire_SimEN.QuestionIndex = objRow[convQuestionnaire_Sim.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Sim.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire_SimEN.QuestionNo = objRow[convQuestionnaire_Sim.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire_SimEN.CourseId = objRow[convQuestionnaire_Sim.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire_SimEN.CourseChapterId = objRow[convQuestionnaire_Sim.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire_SimEN.ParentQuestionId = objRow[convQuestionnaire_Sim.ParentQuestionId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.ParentQuestionId].ToString().Trim(); //父题目Id
objvQuestionnaire_SimEN.QuestionTypeId = objRow[convQuestionnaire_Sim.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire_SimEN.QuestionTypeId4Course = objRow[convQuestionnaire_Sim.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionnaire_SimEN.AnswerTypeId = objRow[convQuestionnaire_Sim.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaire_SimEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Sim.IsShow].ToString().Trim()); //是否启用
objvQuestionnaire_SimEN.DifficultyLevelId = objRow[convQuestionnaire_Sim.DifficultyLevelId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.DifficultyLevelId].ToString().Trim(); //难度等级Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire_SimEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire_SimEN);
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
public static List<clsvQuestionnaire_SimEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQuestionnaire_SimEN> arrObjLst = new List<clsvQuestionnaire_SimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire_SimEN objvQuestionnaire_SimEN = new clsvQuestionnaire_SimEN();
try
{
objvQuestionnaire_SimEN.QuestionId = Int32.Parse(objRow[convQuestionnaire_Sim.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire_SimEN.QuestionName = objRow[convQuestionnaire_Sim.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire_SimEN.QuestionIndex = objRow[convQuestionnaire_Sim.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Sim.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire_SimEN.QuestionNo = objRow[convQuestionnaire_Sim.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire_SimEN.CourseId = objRow[convQuestionnaire_Sim.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire_SimEN.CourseChapterId = objRow[convQuestionnaire_Sim.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire_SimEN.ParentQuestionId = objRow[convQuestionnaire_Sim.ParentQuestionId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.ParentQuestionId].ToString().Trim(); //父题目Id
objvQuestionnaire_SimEN.QuestionTypeId = objRow[convQuestionnaire_Sim.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire_SimEN.QuestionTypeId4Course = objRow[convQuestionnaire_Sim.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionnaire_SimEN.AnswerTypeId = objRow[convQuestionnaire_Sim.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaire_SimEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Sim.IsShow].ToString().Trim()); //是否启用
objvQuestionnaire_SimEN.DifficultyLevelId = objRow[convQuestionnaire_Sim.DifficultyLevelId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.DifficultyLevelId].ToString().Trim(); //难度等级Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire_SimEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire_SimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionnaire_SimEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQuestionnaire_SimEN> arrObjLst = new List<clsvQuestionnaire_SimEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionnaire_SimEN objvQuestionnaire_SimEN = new clsvQuestionnaire_SimEN();
try
{
objvQuestionnaire_SimEN.QuestionId = Int32.Parse(objRow[convQuestionnaire_Sim.QuestionId].ToString().Trim()); //题目Id
objvQuestionnaire_SimEN.QuestionName = objRow[convQuestionnaire_Sim.QuestionName] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.QuestionName].ToString().Trim(); //题目名称
objvQuestionnaire_SimEN.QuestionIndex = objRow[convQuestionnaire_Sim.QuestionIndex] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convQuestionnaire_Sim.QuestionIndex].ToString().Trim()); //题目序号
objvQuestionnaire_SimEN.QuestionNo = objRow[convQuestionnaire_Sim.QuestionNo] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.QuestionNo].ToString().Trim(); //题目编号
objvQuestionnaire_SimEN.CourseId = objRow[convQuestionnaire_Sim.CourseId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.CourseId].ToString().Trim(); //课程Id
objvQuestionnaire_SimEN.CourseChapterId = objRow[convQuestionnaire_Sim.CourseChapterId].ToString().Trim(); //课程章节ID
objvQuestionnaire_SimEN.ParentQuestionId = objRow[convQuestionnaire_Sim.ParentQuestionId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.ParentQuestionId].ToString().Trim(); //父题目Id
objvQuestionnaire_SimEN.QuestionTypeId = objRow[convQuestionnaire_Sim.QuestionTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.QuestionTypeId].ToString().Trim(); //题目类型Id
objvQuestionnaire_SimEN.QuestionTypeId4Course = objRow[convQuestionnaire_Sim.QuestionTypeId4Course].ToString().Trim(); //题目类型Id4课程
objvQuestionnaire_SimEN.AnswerTypeId = objRow[convQuestionnaire_Sim.AnswerTypeId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.AnswerTypeId].ToString().Trim(); //答案类型ID
objvQuestionnaire_SimEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionnaire_Sim.IsShow].ToString().Trim()); //是否启用
objvQuestionnaire_SimEN.DifficultyLevelId = objRow[convQuestionnaire_Sim.DifficultyLevelId] == DBNull.Value ? null : objRow[convQuestionnaire_Sim.DifficultyLevelId].ToString().Trim(); //难度等级Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionnaire_SimEN.QuestionId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionnaire_SimEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQuestionnaire_SimEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQuestionnaire_Sim(ref clsvQuestionnaire_SimEN objvQuestionnaire_SimEN)
{
bool bolResult = vQuestionnaire_SimDA.GetvQuestionnaire_Sim(ref objvQuestionnaire_SimEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngQuestionId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionnaire_SimEN GetObjByQuestionId(long lngQuestionId)
{
clsvQuestionnaire_SimEN objvQuestionnaire_SimEN = vQuestionnaire_SimDA.GetObjByQuestionId(lngQuestionId);
return objvQuestionnaire_SimEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQuestionnaire_SimEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQuestionnaire_SimEN objvQuestionnaire_SimEN = vQuestionnaire_SimDA.GetFirstObj(strWhereCond);
 return objvQuestionnaire_SimEN;
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
public static clsvQuestionnaire_SimEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQuestionnaire_SimEN objvQuestionnaire_SimEN = vQuestionnaire_SimDA.GetObjByDataRow(objRow);
 return objvQuestionnaire_SimEN;
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
public static clsvQuestionnaire_SimEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQuestionnaire_SimEN objvQuestionnaire_SimEN = vQuestionnaire_SimDA.GetObjByDataRow(objRow);
 return objvQuestionnaire_SimEN;
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
 /// <param name = "lstvQuestionnaire_SimObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQuestionnaire_SimEN GetObjByQuestionIdFromList(long lngQuestionId, List<clsvQuestionnaire_SimEN> lstvQuestionnaire_SimObjLst)
{
foreach (clsvQuestionnaire_SimEN objvQuestionnaire_SimEN in lstvQuestionnaire_SimObjLst)
{
if (objvQuestionnaire_SimEN.QuestionId == lngQuestionId)
{
return objvQuestionnaire_SimEN;
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
 lngQuestionId = new clsvQuestionnaire_SimDA().GetFirstID(strWhereCond);
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
 arrList = vQuestionnaire_SimDA.GetID(strWhereCond);
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
bool bolIsExist = vQuestionnaire_SimDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vQuestionnaire_SimDA.IsExist(lngQuestionId);
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
 bolIsExist = clsvQuestionnaire_SimDA.IsExistTable();
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
 bolIsExist = vQuestionnaire_SimDA.IsExistTable(strTabName);
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
 /// <param name = "objvQuestionnaire_SimENS">源对象</param>
 /// <param name = "objvQuestionnaire_SimENT">目标对象</param>
 public static void CopyTo(clsvQuestionnaire_SimEN objvQuestionnaire_SimENS, clsvQuestionnaire_SimEN objvQuestionnaire_SimENT)
{
try
{
objvQuestionnaire_SimENT.QuestionId = objvQuestionnaire_SimENS.QuestionId; //题目Id
objvQuestionnaire_SimENT.QuestionName = objvQuestionnaire_SimENS.QuestionName; //题目名称
objvQuestionnaire_SimENT.QuestionIndex = objvQuestionnaire_SimENS.QuestionIndex; //题目序号
objvQuestionnaire_SimENT.QuestionNo = objvQuestionnaire_SimENS.QuestionNo; //题目编号
objvQuestionnaire_SimENT.CourseId = objvQuestionnaire_SimENS.CourseId; //课程Id
objvQuestionnaire_SimENT.CourseChapterId = objvQuestionnaire_SimENS.CourseChapterId; //课程章节ID
objvQuestionnaire_SimENT.ParentQuestionId = objvQuestionnaire_SimENS.ParentQuestionId; //父题目Id
objvQuestionnaire_SimENT.QuestionTypeId = objvQuestionnaire_SimENS.QuestionTypeId; //题目类型Id
objvQuestionnaire_SimENT.QuestionTypeId4Course = objvQuestionnaire_SimENS.QuestionTypeId4Course; //题目类型Id4课程
objvQuestionnaire_SimENT.AnswerTypeId = objvQuestionnaire_SimENS.AnswerTypeId; //答案类型ID
objvQuestionnaire_SimENT.IsShow = objvQuestionnaire_SimENS.IsShow; //是否启用
objvQuestionnaire_SimENT.DifficultyLevelId = objvQuestionnaire_SimENS.DifficultyLevelId; //难度等级Id
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
 /// <param name = "objvQuestionnaire_SimEN">源简化对象</param>
 public static void SetUpdFlag(clsvQuestionnaire_SimEN objvQuestionnaire_SimEN)
{
try
{
objvQuestionnaire_SimEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQuestionnaire_SimEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQuestionnaire_Sim.QuestionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_SimEN.QuestionId = objvQuestionnaire_SimEN.QuestionId; //题目Id
}
if (arrFldSet.Contains(convQuestionnaire_Sim.QuestionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_SimEN.QuestionName = objvQuestionnaire_SimEN.QuestionName == "[null]" ? null :  objvQuestionnaire_SimEN.QuestionName; //题目名称
}
if (arrFldSet.Contains(convQuestionnaire_Sim.QuestionIndex, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_SimEN.QuestionIndex = objvQuestionnaire_SimEN.QuestionIndex; //题目序号
}
if (arrFldSet.Contains(convQuestionnaire_Sim.QuestionNo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_SimEN.QuestionNo = objvQuestionnaire_SimEN.QuestionNo == "[null]" ? null :  objvQuestionnaire_SimEN.QuestionNo; //题目编号
}
if (arrFldSet.Contains(convQuestionnaire_Sim.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_SimEN.CourseId = objvQuestionnaire_SimEN.CourseId == "[null]" ? null :  objvQuestionnaire_SimEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convQuestionnaire_Sim.CourseChapterId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_SimEN.CourseChapterId = objvQuestionnaire_SimEN.CourseChapterId; //课程章节ID
}
if (arrFldSet.Contains(convQuestionnaire_Sim.ParentQuestionId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_SimEN.ParentQuestionId = objvQuestionnaire_SimEN.ParentQuestionId == "[null]" ? null :  objvQuestionnaire_SimEN.ParentQuestionId; //父题目Id
}
if (arrFldSet.Contains(convQuestionnaire_Sim.QuestionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_SimEN.QuestionTypeId = objvQuestionnaire_SimEN.QuestionTypeId == "[null]" ? null :  objvQuestionnaire_SimEN.QuestionTypeId; //题目类型Id
}
if (arrFldSet.Contains(convQuestionnaire_Sim.QuestionTypeId4Course, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_SimEN.QuestionTypeId4Course = objvQuestionnaire_SimEN.QuestionTypeId4Course; //题目类型Id4课程
}
if (arrFldSet.Contains(convQuestionnaire_Sim.AnswerTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_SimEN.AnswerTypeId = objvQuestionnaire_SimEN.AnswerTypeId == "[null]" ? null :  objvQuestionnaire_SimEN.AnswerTypeId; //答案类型ID
}
if (arrFldSet.Contains(convQuestionnaire_Sim.IsShow, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_SimEN.IsShow = objvQuestionnaire_SimEN.IsShow; //是否启用
}
if (arrFldSet.Contains(convQuestionnaire_Sim.DifficultyLevelId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionnaire_SimEN.DifficultyLevelId = objvQuestionnaire_SimEN.DifficultyLevelId == "[null]" ? null :  objvQuestionnaire_SimEN.DifficultyLevelId; //难度等级Id
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
 /// <param name = "objvQuestionnaire_SimEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQuestionnaire_SimEN objvQuestionnaire_SimEN)
{
try
{
if (objvQuestionnaire_SimEN.QuestionName == "[null]") objvQuestionnaire_SimEN.QuestionName = null; //题目名称
if (objvQuestionnaire_SimEN.QuestionNo == "[null]") objvQuestionnaire_SimEN.QuestionNo = null; //题目编号
if (objvQuestionnaire_SimEN.CourseId == "[null]") objvQuestionnaire_SimEN.CourseId = null; //课程Id
if (objvQuestionnaire_SimEN.ParentQuestionId == "[null]") objvQuestionnaire_SimEN.ParentQuestionId = null; //父题目Id
if (objvQuestionnaire_SimEN.QuestionTypeId == "[null]") objvQuestionnaire_SimEN.QuestionTypeId = null; //题目类型Id
if (objvQuestionnaire_SimEN.AnswerTypeId == "[null]") objvQuestionnaire_SimEN.AnswerTypeId = null; //答案类型ID
if (objvQuestionnaire_SimEN.DifficultyLevelId == "[null]") objvQuestionnaire_SimEN.DifficultyLevelId = null; //难度等级Id
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
public static void CheckProperty4Condition(clsvQuestionnaire_SimEN objvQuestionnaire_SimEN)
{
 vQuestionnaire_SimDA.CheckProperty4Condition(objvQuestionnaire_SimEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_QuestionIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vQuestionnaire_Sim]...","0");
List<clsvQuestionnaire_SimEN> arrvQuestionnaire_SimObjLst = GetAllvQuestionnaire_SimObjLstCache(); 
objDDL.DataValueField = convQuestionnaire_Sim.QuestionId;
objDDL.DataTextField = convQuestionnaire_Sim.QuestionName;
objDDL.DataSource = arrvQuestionnaire_SimObjLst;
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
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by QuestionId");
//if (arrvQuestionnaire_SimObjLstCache == null)
//{
//arrvQuestionnaire_SimObjLstCache = vQuestionnaire_SimDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngQuestionId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQuestionnaire_SimEN GetObjByQuestionIdCache(long lngQuestionId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvQuestionnaire_SimEN._CurrTabName);
List<clsvQuestionnaire_SimEN> arrvQuestionnaire_SimObjLstCache = GetObjLstCache();
IEnumerable <clsvQuestionnaire_SimEN> arrvQuestionnaire_SimObjLst_Sel =
arrvQuestionnaire_SimObjLstCache
.Where(x=> x.QuestionId == lngQuestionId 
);
if (arrvQuestionnaire_SimObjLst_Sel.Count() == 0)
{
   clsvQuestionnaire_SimEN obj = clsvQuestionnaire_SimBL.GetObjByQuestionId(lngQuestionId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvQuestionnaire_SimObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngQuestionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetQuestionNameByQuestionIdCache(long lngQuestionId)
{
//获取缓存中的对象列表
clsvQuestionnaire_SimEN objvQuestionnaire_Sim = GetObjByQuestionIdCache(lngQuestionId);
if (objvQuestionnaire_Sim == null) return "";
return objvQuestionnaire_Sim.QuestionName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "lngQuestionId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByQuestionIdCache(long lngQuestionId)
{
//获取缓存中的对象列表
clsvQuestionnaire_SimEN objvQuestionnaire_Sim = GetObjByQuestionIdCache(lngQuestionId);
if (objvQuestionnaire_Sim == null) return "";
return objvQuestionnaire_Sim.QuestionName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQuestionnaire_SimEN> GetAllvQuestionnaire_SimObjLstCache()
{
//获取缓存中的对象列表
List<clsvQuestionnaire_SimEN> arrvQuestionnaire_SimObjLstCache = GetObjLstCache(); 
return arrvQuestionnaire_SimObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQuestionnaire_SimEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvQuestionnaire_SimEN._CurrTabName);
List<clsvQuestionnaire_SimEN> arrvQuestionnaire_SimObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQuestionnaire_SimObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvQuestionnaire_SimEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvQuestionnaire_SimEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvQuestionnaire_SimEN._RefreshTimeLst.Count == 0) return "";
return clsvQuestionnaire_SimEN._RefreshTimeLst[clsvQuestionnaire_SimEN._RefreshTimeLst.Count - 1];
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2024-11-12
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngQuestionId)
{
if (strInFldName != convQuestionnaire_Sim.QuestionId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQuestionnaire_Sim.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQuestionnaire_Sim.AttributeName));
throw new Exception(strMsg);
}
var objvQuestionnaire_Sim = clsvQuestionnaire_SimBL.GetObjByQuestionIdCache(lngQuestionId);
if (objvQuestionnaire_Sim == null) return "";
return objvQuestionnaire_Sim[strOutFldName].ToString();
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
int intRecCount = clsvQuestionnaire_SimDA.GetRecCount(strTabName);
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
int intRecCount = clsvQuestionnaire_SimDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQuestionnaire_SimDA.GetRecCount();
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
int intRecCount = clsvQuestionnaire_SimDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQuestionnaire_SimCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQuestionnaire_SimEN objvQuestionnaire_SimCond)
{
List<clsvQuestionnaire_SimEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQuestionnaire_SimEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQuestionnaire_Sim.AttributeName)
{
if (objvQuestionnaire_SimCond.IsUpdated(strFldName) == false) continue;
if (objvQuestionnaire_SimCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionnaire_SimCond[strFldName].ToString());
}
else
{
if (objvQuestionnaire_SimCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQuestionnaire_SimCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionnaire_SimCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQuestionnaire_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQuestionnaire_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQuestionnaire_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQuestionnaire_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQuestionnaire_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQuestionnaire_SimCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQuestionnaire_SimCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQuestionnaire_SimCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQuestionnaire_SimCond[strFldName]));
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
 List<string> arrList = clsvQuestionnaire_SimDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQuestionnaire_SimDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQuestionnaire_SimDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}