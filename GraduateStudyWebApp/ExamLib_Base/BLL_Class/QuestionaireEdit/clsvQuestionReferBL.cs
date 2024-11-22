
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvQuestionReferBL
 表名:vQuestionRefer(01120342)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:49:09
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:问卷维护(QuestionaireEdit)
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
public static class  clsvQuestionReferBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionReferEN GetObj(this K_mId_vQuestionRefer myKey)
{
clsvQuestionReferEN objvQuestionReferEN = clsvQuestionReferBL.vQuestionReferDA.GetObjBymId(myKey.Value);
return objvQuestionReferEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionReferEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionReferEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionReferEN SetQuestionID(this clsvQuestionReferEN objvQuestionReferEN, string strQuestionID, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionID, 8, convQuestionRefer.QuestionID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strQuestionID, 8, convQuestionRefer.QuestionID);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionReferEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionReferEN SetQuestionName(this clsvQuestionReferEN objvQuestionReferEN, string strQuestionName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strQuestionName, 500, convQuestionRefer.QuestionName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionReferEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionReferEN SetCourseId(this clsvQuestionReferEN objvQuestionReferEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convQuestionRefer.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convQuestionRefer.CourseId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionReferEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionReferEN SetCourseName(this clsvQuestionReferEN objvQuestionReferEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convQuestionRefer.CourseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionReferEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionReferEN SetFuncModuleId(this clsvQuestionReferEN objvQuestionReferEN, string strFuncModuleId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convQuestionRefer.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convQuestionRefer.FuncModuleId);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionReferEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionReferEN SetFuncModuleName(this clsvQuestionReferEN objvQuestionReferEN, string strFuncModuleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convQuestionRefer.FuncModuleName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionReferEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionReferEN SetFuncModuleNameSim(this clsvQuestionReferEN objvQuestionReferEN, string strFuncModuleNameSim, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleNameSim, 30, convQuestionRefer.FuncModuleNameSim);
}
objvQuestionReferEN.FuncModuleNameSim = strFuncModuleNameSim; //功能模块简称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvQuestionReferEN.dicFldComparisonOp.ContainsKey(convQuestionRefer.FuncModuleNameSim) == false)
{
objvQuestionReferEN.dicFldComparisonOp.Add(convQuestionRefer.FuncModuleNameSim, strComparisonOp);
}
else
{
objvQuestionReferEN.dicFldComparisonOp[convQuestionRefer.FuncModuleNameSim] = strComparisonOp;
}
}
return objvQuestionReferEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionReferEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionReferEN SetTableName(this clsvQuestionReferEN objvQuestionReferEN, string strTableName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTableName, 100, convQuestionRefer.TableName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionReferEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionReferEN SetKeyIdValue(this clsvQuestionReferEN objvQuestionReferEN, string strKeyIdValue, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyIdValue, 50, convQuestionRefer.KeyIdValue);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionReferEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionReferEN SetCaseName(this clsvQuestionReferEN objvQuestionReferEN, string strCaseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCaseName, 100, convQuestionRefer.CaseName);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionReferEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionReferEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionReferEN SetUpdDate(this clsvQuestionReferEN objvQuestionReferEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdDate, convQuestionRefer.UpdDate);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convQuestionRefer.UpdDate);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionReferEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionReferEN SetUpdUser(this clsvQuestionReferEN objvQuestionReferEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUpdUser, convQuestionRefer.UpdUser);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convQuestionRefer.UpdUser);
}
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
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvQuestionReferEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvQuestionReferEN SetMemo(this clsvQuestionReferEN objvQuestionReferEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convQuestionRefer.Memo);
}
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
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvQuestionReferENS">源对象</param>
 /// <param name = "objvQuestionReferENT">目标对象</param>
 public static void CopyTo(this clsvQuestionReferEN objvQuestionReferENS, clsvQuestionReferEN objvQuestionReferENT)
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
objvQuestionReferENT.FuncModuleNameSim = objvQuestionReferENS.FuncModuleNameSim; //功能模块简称
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
 /// <param name = "objvQuestionReferENS">源对象</param>
 /// <returns>目标对象=>clsvQuestionReferEN:objvQuestionReferENT</returns>
 public static clsvQuestionReferEN CopyTo(this clsvQuestionReferEN objvQuestionReferENS)
{
try
{
 clsvQuestionReferEN objvQuestionReferENT = new clsvQuestionReferEN()
{
mId = objvQuestionReferENS.mId, //mId
QuestionID = objvQuestionReferENS.QuestionID, //题目ID
QuestionName = objvQuestionReferENS.QuestionName, //题目名称
CourseId = objvQuestionReferENS.CourseId, //课程Id
CourseName = objvQuestionReferENS.CourseName, //课程名称
FuncModuleId = objvQuestionReferENS.FuncModuleId, //功能模块Id
FuncModuleName = objvQuestionReferENS.FuncModuleName, //功能模块名称
FuncModuleNameSim = objvQuestionReferENS.FuncModuleNameSim, //功能模块简称
TableName = objvQuestionReferENS.TableName, //主表表名
KeyIdValue = objvQuestionReferENS.KeyIdValue, //关键字值
CaseName = objvQuestionReferENS.CaseName, //案例名称
IsShow = objvQuestionReferENS.IsShow, //是否启用
UpdDate = objvQuestionReferENS.UpdDate, //修改日期
UpdUser = objvQuestionReferENS.UpdUser, //修改人
Memo = objvQuestionReferENS.Memo, //备注
};
 return objvQuestionReferENT;
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
public static void CheckProperty4Condition(this clsvQuestionReferEN objvQuestionReferEN)
{
 clsvQuestionReferBL.vQuestionReferDA.CheckProperty4Condition(objvQuestionReferEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvQuestionReferEN objvQuestionReferCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvQuestionReferCond.IsUpdated(convQuestionRefer.mId) == true)
{
string strComparisonOpmId = objvQuestionReferCond.dicFldComparisonOp[convQuestionRefer.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convQuestionRefer.mId, objvQuestionReferCond.mId, strComparisonOpmId);
}
if (objvQuestionReferCond.IsUpdated(convQuestionRefer.QuestionID) == true)
{
string strComparisonOpQuestionID = objvQuestionReferCond.dicFldComparisonOp[convQuestionRefer.QuestionID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionRefer.QuestionID, objvQuestionReferCond.QuestionID, strComparisonOpQuestionID);
}
if (objvQuestionReferCond.IsUpdated(convQuestionRefer.QuestionName) == true)
{
string strComparisonOpQuestionName = objvQuestionReferCond.dicFldComparisonOp[convQuestionRefer.QuestionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionRefer.QuestionName, objvQuestionReferCond.QuestionName, strComparisonOpQuestionName);
}
if (objvQuestionReferCond.IsUpdated(convQuestionRefer.CourseId) == true)
{
string strComparisonOpCourseId = objvQuestionReferCond.dicFldComparisonOp[convQuestionRefer.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionRefer.CourseId, objvQuestionReferCond.CourseId, strComparisonOpCourseId);
}
if (objvQuestionReferCond.IsUpdated(convQuestionRefer.CourseName) == true)
{
string strComparisonOpCourseName = objvQuestionReferCond.dicFldComparisonOp[convQuestionRefer.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionRefer.CourseName, objvQuestionReferCond.CourseName, strComparisonOpCourseName);
}
if (objvQuestionReferCond.IsUpdated(convQuestionRefer.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objvQuestionReferCond.dicFldComparisonOp[convQuestionRefer.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionRefer.FuncModuleId, objvQuestionReferCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objvQuestionReferCond.IsUpdated(convQuestionRefer.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvQuestionReferCond.dicFldComparisonOp[convQuestionRefer.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionRefer.FuncModuleName, objvQuestionReferCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvQuestionReferCond.IsUpdated(convQuestionRefer.FuncModuleNameSim) == true)
{
string strComparisonOpFuncModuleNameSim = objvQuestionReferCond.dicFldComparisonOp[convQuestionRefer.FuncModuleNameSim];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionRefer.FuncModuleNameSim, objvQuestionReferCond.FuncModuleNameSim, strComparisonOpFuncModuleNameSim);
}
if (objvQuestionReferCond.IsUpdated(convQuestionRefer.TableName) == true)
{
string strComparisonOpTableName = objvQuestionReferCond.dicFldComparisonOp[convQuestionRefer.TableName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionRefer.TableName, objvQuestionReferCond.TableName, strComparisonOpTableName);
}
if (objvQuestionReferCond.IsUpdated(convQuestionRefer.KeyIdValue) == true)
{
string strComparisonOpKeyIdValue = objvQuestionReferCond.dicFldComparisonOp[convQuestionRefer.KeyIdValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionRefer.KeyIdValue, objvQuestionReferCond.KeyIdValue, strComparisonOpKeyIdValue);
}
if (objvQuestionReferCond.IsUpdated(convQuestionRefer.CaseName) == true)
{
string strComparisonOpCaseName = objvQuestionReferCond.dicFldComparisonOp[convQuestionRefer.CaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionRefer.CaseName, objvQuestionReferCond.CaseName, strComparisonOpCaseName);
}
if (objvQuestionReferCond.IsUpdated(convQuestionRefer.IsShow) == true)
{
if (objvQuestionReferCond.IsShow == true)
{
strWhereCond += string.Format(" And {0} = '1'", convQuestionRefer.IsShow);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convQuestionRefer.IsShow);
}
}
if (objvQuestionReferCond.IsUpdated(convQuestionRefer.UpdDate) == true)
{
string strComparisonOpUpdDate = objvQuestionReferCond.dicFldComparisonOp[convQuestionRefer.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionRefer.UpdDate, objvQuestionReferCond.UpdDate, strComparisonOpUpdDate);
}
if (objvQuestionReferCond.IsUpdated(convQuestionRefer.UpdUser) == true)
{
string strComparisonOpUpdUser = objvQuestionReferCond.dicFldComparisonOp[convQuestionRefer.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionRefer.UpdUser, objvQuestionReferCond.UpdUser, strComparisonOpUpdUser);
}
if (objvQuestionReferCond.IsUpdated(convQuestionRefer.Memo) == true)
{
string strComparisonOpMemo = objvQuestionReferCond.dicFldComparisonOp[convQuestionRefer.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convQuestionRefer.Memo, objvQuestionReferCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vQuestionRefer
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v题目参考(vQuestionRefer)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvQuestionReferBL
{
public static RelatedActions_vQuestionRefer relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvQuestionReferDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvQuestionReferDA vQuestionReferDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvQuestionReferDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvQuestionReferBL()
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
if (string.IsNullOrEmpty(clsvQuestionReferEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvQuestionReferEN._ConnectString);
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
public static DataTable GetDataTable_vQuestionRefer(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vQuestionReferDA.GetDataTable_vQuestionRefer(strWhereCond);
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
objDT = vQuestionReferDA.GetDataTable(strWhereCond);
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
objDT = vQuestionReferDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vQuestionReferDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vQuestionReferDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vQuestionReferDA.GetDataTable_Top(objTopPara);
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
objDT = vQuestionReferDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vQuestionReferDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vQuestionReferDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvQuestionReferEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvQuestionReferEN> arrObjLst = new List<clsvQuestionReferEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMIdLst);
 string strWhereCond = string.Format("mId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionReferEN objvQuestionReferEN = new clsvQuestionReferEN();
try
{
objvQuestionReferEN.mId = Int32.Parse(objRow[convQuestionRefer.mId].ToString().Trim()); //mId
objvQuestionReferEN.QuestionID = objRow[convQuestionRefer.QuestionID] == DBNull.Value ? null : objRow[convQuestionRefer.QuestionID].ToString().Trim(); //题目ID
objvQuestionReferEN.QuestionName = objRow[convQuestionRefer.QuestionName] == DBNull.Value ? null : objRow[convQuestionRefer.QuestionName].ToString().Trim(); //题目名称
objvQuestionReferEN.CourseId = objRow[convQuestionRefer.CourseId] == DBNull.Value ? null : objRow[convQuestionRefer.CourseId].ToString().Trim(); //课程Id
objvQuestionReferEN.CourseName = objRow[convQuestionRefer.CourseName] == DBNull.Value ? null : objRow[convQuestionRefer.CourseName].ToString().Trim(); //课程名称
objvQuestionReferEN.FuncModuleId = objRow[convQuestionRefer.FuncModuleId] == DBNull.Value ? null : objRow[convQuestionRefer.FuncModuleId].ToString().Trim(); //功能模块Id
objvQuestionReferEN.FuncModuleName = objRow[convQuestionRefer.FuncModuleName] == DBNull.Value ? null : objRow[convQuestionRefer.FuncModuleName].ToString().Trim(); //功能模块名称
objvQuestionReferEN.FuncModuleNameSim = objRow[convQuestionRefer.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQuestionRefer.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvQuestionReferEN.TableName = objRow[convQuestionRefer.TableName] == DBNull.Value ? null : objRow[convQuestionRefer.TableName].ToString().Trim(); //主表表名
objvQuestionReferEN.KeyIdValue = objRow[convQuestionRefer.KeyIdValue] == DBNull.Value ? null : objRow[convQuestionRefer.KeyIdValue].ToString().Trim(); //关键字值
objvQuestionReferEN.CaseName = objRow[convQuestionRefer.CaseName] == DBNull.Value ? null : objRow[convQuestionRefer.CaseName].ToString().Trim(); //案例名称
objvQuestionReferEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionRefer.IsShow].ToString().Trim()); //是否启用
objvQuestionReferEN.UpdDate = objRow[convQuestionRefer.UpdDate].ToString().Trim(); //修改日期
objvQuestionReferEN.UpdUser = objRow[convQuestionRefer.UpdUser].ToString().Trim(); //修改人
objvQuestionReferEN.Memo = objRow[convQuestionRefer.Memo] == DBNull.Value ? null : objRow[convQuestionRefer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionReferEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionReferEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvQuestionReferEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvQuestionReferEN._CurrTabName);
List<clsvQuestionReferEN> arrvQuestionReferObjLstCache = GetObjLstCache();
IEnumerable <clsvQuestionReferEN> arrvQuestionReferObjLst_Sel =
arrvQuestionReferObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvQuestionReferObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionReferEN> GetObjLst(string strWhereCond)
{
List<clsvQuestionReferEN> arrObjLst = new List<clsvQuestionReferEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionReferEN objvQuestionReferEN = new clsvQuestionReferEN();
try
{
objvQuestionReferEN.mId = Int32.Parse(objRow[convQuestionRefer.mId].ToString().Trim()); //mId
objvQuestionReferEN.QuestionID = objRow[convQuestionRefer.QuestionID] == DBNull.Value ? null : objRow[convQuestionRefer.QuestionID].ToString().Trim(); //题目ID
objvQuestionReferEN.QuestionName = objRow[convQuestionRefer.QuestionName] == DBNull.Value ? null : objRow[convQuestionRefer.QuestionName].ToString().Trim(); //题目名称
objvQuestionReferEN.CourseId = objRow[convQuestionRefer.CourseId] == DBNull.Value ? null : objRow[convQuestionRefer.CourseId].ToString().Trim(); //课程Id
objvQuestionReferEN.CourseName = objRow[convQuestionRefer.CourseName] == DBNull.Value ? null : objRow[convQuestionRefer.CourseName].ToString().Trim(); //课程名称
objvQuestionReferEN.FuncModuleId = objRow[convQuestionRefer.FuncModuleId] == DBNull.Value ? null : objRow[convQuestionRefer.FuncModuleId].ToString().Trim(); //功能模块Id
objvQuestionReferEN.FuncModuleName = objRow[convQuestionRefer.FuncModuleName] == DBNull.Value ? null : objRow[convQuestionRefer.FuncModuleName].ToString().Trim(); //功能模块名称
objvQuestionReferEN.FuncModuleNameSim = objRow[convQuestionRefer.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQuestionRefer.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvQuestionReferEN.TableName = objRow[convQuestionRefer.TableName] == DBNull.Value ? null : objRow[convQuestionRefer.TableName].ToString().Trim(); //主表表名
objvQuestionReferEN.KeyIdValue = objRow[convQuestionRefer.KeyIdValue] == DBNull.Value ? null : objRow[convQuestionRefer.KeyIdValue].ToString().Trim(); //关键字值
objvQuestionReferEN.CaseName = objRow[convQuestionRefer.CaseName] == DBNull.Value ? null : objRow[convQuestionRefer.CaseName].ToString().Trim(); //案例名称
objvQuestionReferEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionRefer.IsShow].ToString().Trim()); //是否启用
objvQuestionReferEN.UpdDate = objRow[convQuestionRefer.UpdDate].ToString().Trim(); //修改日期
objvQuestionReferEN.UpdUser = objRow[convQuestionRefer.UpdUser].ToString().Trim(); //修改人
objvQuestionReferEN.Memo = objRow[convQuestionRefer.Memo] == DBNull.Value ? null : objRow[convQuestionRefer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionReferEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionReferEN);
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
public static List<clsvQuestionReferEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvQuestionReferEN> arrObjLst = new List<clsvQuestionReferEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionReferEN objvQuestionReferEN = new clsvQuestionReferEN();
try
{
objvQuestionReferEN.mId = Int32.Parse(objRow[convQuestionRefer.mId].ToString().Trim()); //mId
objvQuestionReferEN.QuestionID = objRow[convQuestionRefer.QuestionID] == DBNull.Value ? null : objRow[convQuestionRefer.QuestionID].ToString().Trim(); //题目ID
objvQuestionReferEN.QuestionName = objRow[convQuestionRefer.QuestionName] == DBNull.Value ? null : objRow[convQuestionRefer.QuestionName].ToString().Trim(); //题目名称
objvQuestionReferEN.CourseId = objRow[convQuestionRefer.CourseId] == DBNull.Value ? null : objRow[convQuestionRefer.CourseId].ToString().Trim(); //课程Id
objvQuestionReferEN.CourseName = objRow[convQuestionRefer.CourseName] == DBNull.Value ? null : objRow[convQuestionRefer.CourseName].ToString().Trim(); //课程名称
objvQuestionReferEN.FuncModuleId = objRow[convQuestionRefer.FuncModuleId] == DBNull.Value ? null : objRow[convQuestionRefer.FuncModuleId].ToString().Trim(); //功能模块Id
objvQuestionReferEN.FuncModuleName = objRow[convQuestionRefer.FuncModuleName] == DBNull.Value ? null : objRow[convQuestionRefer.FuncModuleName].ToString().Trim(); //功能模块名称
objvQuestionReferEN.FuncModuleNameSim = objRow[convQuestionRefer.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQuestionRefer.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvQuestionReferEN.TableName = objRow[convQuestionRefer.TableName] == DBNull.Value ? null : objRow[convQuestionRefer.TableName].ToString().Trim(); //主表表名
objvQuestionReferEN.KeyIdValue = objRow[convQuestionRefer.KeyIdValue] == DBNull.Value ? null : objRow[convQuestionRefer.KeyIdValue].ToString().Trim(); //关键字值
objvQuestionReferEN.CaseName = objRow[convQuestionRefer.CaseName] == DBNull.Value ? null : objRow[convQuestionRefer.CaseName].ToString().Trim(); //案例名称
objvQuestionReferEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionRefer.IsShow].ToString().Trim()); //是否启用
objvQuestionReferEN.UpdDate = objRow[convQuestionRefer.UpdDate].ToString().Trim(); //修改日期
objvQuestionReferEN.UpdUser = objRow[convQuestionRefer.UpdUser].ToString().Trim(); //修改人
objvQuestionReferEN.Memo = objRow[convQuestionRefer.Memo] == DBNull.Value ? null : objRow[convQuestionRefer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionReferEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionReferEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvQuestionReferCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvQuestionReferEN> GetSubObjLstCache(clsvQuestionReferEN objvQuestionReferCond)
{
List<clsvQuestionReferEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQuestionReferEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQuestionRefer.AttributeName)
{
if (objvQuestionReferCond.IsUpdated(strFldName) == false) continue;
if (objvQuestionReferCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionReferCond[strFldName].ToString());
}
else
{
if (objvQuestionReferCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQuestionReferCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionReferCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQuestionReferCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQuestionReferCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQuestionReferCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQuestionReferCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQuestionReferCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQuestionReferCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQuestionReferCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQuestionReferCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQuestionReferCond[strFldName]));
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
public static List<clsvQuestionReferEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvQuestionReferEN> arrObjLst = new List<clsvQuestionReferEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionReferEN objvQuestionReferEN = new clsvQuestionReferEN();
try
{
objvQuestionReferEN.mId = Int32.Parse(objRow[convQuestionRefer.mId].ToString().Trim()); //mId
objvQuestionReferEN.QuestionID = objRow[convQuestionRefer.QuestionID] == DBNull.Value ? null : objRow[convQuestionRefer.QuestionID].ToString().Trim(); //题目ID
objvQuestionReferEN.QuestionName = objRow[convQuestionRefer.QuestionName] == DBNull.Value ? null : objRow[convQuestionRefer.QuestionName].ToString().Trim(); //题目名称
objvQuestionReferEN.CourseId = objRow[convQuestionRefer.CourseId] == DBNull.Value ? null : objRow[convQuestionRefer.CourseId].ToString().Trim(); //课程Id
objvQuestionReferEN.CourseName = objRow[convQuestionRefer.CourseName] == DBNull.Value ? null : objRow[convQuestionRefer.CourseName].ToString().Trim(); //课程名称
objvQuestionReferEN.FuncModuleId = objRow[convQuestionRefer.FuncModuleId] == DBNull.Value ? null : objRow[convQuestionRefer.FuncModuleId].ToString().Trim(); //功能模块Id
objvQuestionReferEN.FuncModuleName = objRow[convQuestionRefer.FuncModuleName] == DBNull.Value ? null : objRow[convQuestionRefer.FuncModuleName].ToString().Trim(); //功能模块名称
objvQuestionReferEN.FuncModuleNameSim = objRow[convQuestionRefer.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQuestionRefer.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvQuestionReferEN.TableName = objRow[convQuestionRefer.TableName] == DBNull.Value ? null : objRow[convQuestionRefer.TableName].ToString().Trim(); //主表表名
objvQuestionReferEN.KeyIdValue = objRow[convQuestionRefer.KeyIdValue] == DBNull.Value ? null : objRow[convQuestionRefer.KeyIdValue].ToString().Trim(); //关键字值
objvQuestionReferEN.CaseName = objRow[convQuestionRefer.CaseName] == DBNull.Value ? null : objRow[convQuestionRefer.CaseName].ToString().Trim(); //案例名称
objvQuestionReferEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionRefer.IsShow].ToString().Trim()); //是否启用
objvQuestionReferEN.UpdDate = objRow[convQuestionRefer.UpdDate].ToString().Trim(); //修改日期
objvQuestionReferEN.UpdUser = objRow[convQuestionRefer.UpdUser].ToString().Trim(); //修改人
objvQuestionReferEN.Memo = objRow[convQuestionRefer.Memo] == DBNull.Value ? null : objRow[convQuestionRefer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionReferEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionReferEN);
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
public static List<clsvQuestionReferEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvQuestionReferEN> arrObjLst = new List<clsvQuestionReferEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionReferEN objvQuestionReferEN = new clsvQuestionReferEN();
try
{
objvQuestionReferEN.mId = Int32.Parse(objRow[convQuestionRefer.mId].ToString().Trim()); //mId
objvQuestionReferEN.QuestionID = objRow[convQuestionRefer.QuestionID] == DBNull.Value ? null : objRow[convQuestionRefer.QuestionID].ToString().Trim(); //题目ID
objvQuestionReferEN.QuestionName = objRow[convQuestionRefer.QuestionName] == DBNull.Value ? null : objRow[convQuestionRefer.QuestionName].ToString().Trim(); //题目名称
objvQuestionReferEN.CourseId = objRow[convQuestionRefer.CourseId] == DBNull.Value ? null : objRow[convQuestionRefer.CourseId].ToString().Trim(); //课程Id
objvQuestionReferEN.CourseName = objRow[convQuestionRefer.CourseName] == DBNull.Value ? null : objRow[convQuestionRefer.CourseName].ToString().Trim(); //课程名称
objvQuestionReferEN.FuncModuleId = objRow[convQuestionRefer.FuncModuleId] == DBNull.Value ? null : objRow[convQuestionRefer.FuncModuleId].ToString().Trim(); //功能模块Id
objvQuestionReferEN.FuncModuleName = objRow[convQuestionRefer.FuncModuleName] == DBNull.Value ? null : objRow[convQuestionRefer.FuncModuleName].ToString().Trim(); //功能模块名称
objvQuestionReferEN.FuncModuleNameSim = objRow[convQuestionRefer.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQuestionRefer.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvQuestionReferEN.TableName = objRow[convQuestionRefer.TableName] == DBNull.Value ? null : objRow[convQuestionRefer.TableName].ToString().Trim(); //主表表名
objvQuestionReferEN.KeyIdValue = objRow[convQuestionRefer.KeyIdValue] == DBNull.Value ? null : objRow[convQuestionRefer.KeyIdValue].ToString().Trim(); //关键字值
objvQuestionReferEN.CaseName = objRow[convQuestionRefer.CaseName] == DBNull.Value ? null : objRow[convQuestionRefer.CaseName].ToString().Trim(); //案例名称
objvQuestionReferEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionRefer.IsShow].ToString().Trim()); //是否启用
objvQuestionReferEN.UpdDate = objRow[convQuestionRefer.UpdDate].ToString().Trim(); //修改日期
objvQuestionReferEN.UpdUser = objRow[convQuestionRefer.UpdUser].ToString().Trim(); //修改人
objvQuestionReferEN.Memo = objRow[convQuestionRefer.Memo] == DBNull.Value ? null : objRow[convQuestionRefer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionReferEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionReferEN);
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
List<clsvQuestionReferEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvQuestionReferEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionReferEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvQuestionReferEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvQuestionReferEN> arrObjLst = new List<clsvQuestionReferEN>(); 
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
	clsvQuestionReferEN objvQuestionReferEN = new clsvQuestionReferEN();
try
{
objvQuestionReferEN.mId = Int32.Parse(objRow[convQuestionRefer.mId].ToString().Trim()); //mId
objvQuestionReferEN.QuestionID = objRow[convQuestionRefer.QuestionID] == DBNull.Value ? null : objRow[convQuestionRefer.QuestionID].ToString().Trim(); //题目ID
objvQuestionReferEN.QuestionName = objRow[convQuestionRefer.QuestionName] == DBNull.Value ? null : objRow[convQuestionRefer.QuestionName].ToString().Trim(); //题目名称
objvQuestionReferEN.CourseId = objRow[convQuestionRefer.CourseId] == DBNull.Value ? null : objRow[convQuestionRefer.CourseId].ToString().Trim(); //课程Id
objvQuestionReferEN.CourseName = objRow[convQuestionRefer.CourseName] == DBNull.Value ? null : objRow[convQuestionRefer.CourseName].ToString().Trim(); //课程名称
objvQuestionReferEN.FuncModuleId = objRow[convQuestionRefer.FuncModuleId] == DBNull.Value ? null : objRow[convQuestionRefer.FuncModuleId].ToString().Trim(); //功能模块Id
objvQuestionReferEN.FuncModuleName = objRow[convQuestionRefer.FuncModuleName] == DBNull.Value ? null : objRow[convQuestionRefer.FuncModuleName].ToString().Trim(); //功能模块名称
objvQuestionReferEN.FuncModuleNameSim = objRow[convQuestionRefer.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQuestionRefer.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvQuestionReferEN.TableName = objRow[convQuestionRefer.TableName] == DBNull.Value ? null : objRow[convQuestionRefer.TableName].ToString().Trim(); //主表表名
objvQuestionReferEN.KeyIdValue = objRow[convQuestionRefer.KeyIdValue] == DBNull.Value ? null : objRow[convQuestionRefer.KeyIdValue].ToString().Trim(); //关键字值
objvQuestionReferEN.CaseName = objRow[convQuestionRefer.CaseName] == DBNull.Value ? null : objRow[convQuestionRefer.CaseName].ToString().Trim(); //案例名称
objvQuestionReferEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionRefer.IsShow].ToString().Trim()); //是否启用
objvQuestionReferEN.UpdDate = objRow[convQuestionRefer.UpdDate].ToString().Trim(); //修改日期
objvQuestionReferEN.UpdUser = objRow[convQuestionRefer.UpdUser].ToString().Trim(); //修改人
objvQuestionReferEN.Memo = objRow[convQuestionRefer.Memo] == DBNull.Value ? null : objRow[convQuestionRefer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionReferEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionReferEN);
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
public static List<clsvQuestionReferEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvQuestionReferEN> arrObjLst = new List<clsvQuestionReferEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionReferEN objvQuestionReferEN = new clsvQuestionReferEN();
try
{
objvQuestionReferEN.mId = Int32.Parse(objRow[convQuestionRefer.mId].ToString().Trim()); //mId
objvQuestionReferEN.QuestionID = objRow[convQuestionRefer.QuestionID] == DBNull.Value ? null : objRow[convQuestionRefer.QuestionID].ToString().Trim(); //题目ID
objvQuestionReferEN.QuestionName = objRow[convQuestionRefer.QuestionName] == DBNull.Value ? null : objRow[convQuestionRefer.QuestionName].ToString().Trim(); //题目名称
objvQuestionReferEN.CourseId = objRow[convQuestionRefer.CourseId] == DBNull.Value ? null : objRow[convQuestionRefer.CourseId].ToString().Trim(); //课程Id
objvQuestionReferEN.CourseName = objRow[convQuestionRefer.CourseName] == DBNull.Value ? null : objRow[convQuestionRefer.CourseName].ToString().Trim(); //课程名称
objvQuestionReferEN.FuncModuleId = objRow[convQuestionRefer.FuncModuleId] == DBNull.Value ? null : objRow[convQuestionRefer.FuncModuleId].ToString().Trim(); //功能模块Id
objvQuestionReferEN.FuncModuleName = objRow[convQuestionRefer.FuncModuleName] == DBNull.Value ? null : objRow[convQuestionRefer.FuncModuleName].ToString().Trim(); //功能模块名称
objvQuestionReferEN.FuncModuleNameSim = objRow[convQuestionRefer.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQuestionRefer.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvQuestionReferEN.TableName = objRow[convQuestionRefer.TableName] == DBNull.Value ? null : objRow[convQuestionRefer.TableName].ToString().Trim(); //主表表名
objvQuestionReferEN.KeyIdValue = objRow[convQuestionRefer.KeyIdValue] == DBNull.Value ? null : objRow[convQuestionRefer.KeyIdValue].ToString().Trim(); //关键字值
objvQuestionReferEN.CaseName = objRow[convQuestionRefer.CaseName] == DBNull.Value ? null : objRow[convQuestionRefer.CaseName].ToString().Trim(); //案例名称
objvQuestionReferEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionRefer.IsShow].ToString().Trim()); //是否启用
objvQuestionReferEN.UpdDate = objRow[convQuestionRefer.UpdDate].ToString().Trim(); //修改日期
objvQuestionReferEN.UpdUser = objRow[convQuestionRefer.UpdUser].ToString().Trim(); //修改人
objvQuestionReferEN.Memo = objRow[convQuestionRefer.Memo] == DBNull.Value ? null : objRow[convQuestionRefer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionReferEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionReferEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvQuestionReferEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvQuestionReferEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvQuestionReferEN> arrObjLst = new List<clsvQuestionReferEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionReferEN objvQuestionReferEN = new clsvQuestionReferEN();
try
{
objvQuestionReferEN.mId = Int32.Parse(objRow[convQuestionRefer.mId].ToString().Trim()); //mId
objvQuestionReferEN.QuestionID = objRow[convQuestionRefer.QuestionID] == DBNull.Value ? null : objRow[convQuestionRefer.QuestionID].ToString().Trim(); //题目ID
objvQuestionReferEN.QuestionName = objRow[convQuestionRefer.QuestionName] == DBNull.Value ? null : objRow[convQuestionRefer.QuestionName].ToString().Trim(); //题目名称
objvQuestionReferEN.CourseId = objRow[convQuestionRefer.CourseId] == DBNull.Value ? null : objRow[convQuestionRefer.CourseId].ToString().Trim(); //课程Id
objvQuestionReferEN.CourseName = objRow[convQuestionRefer.CourseName] == DBNull.Value ? null : objRow[convQuestionRefer.CourseName].ToString().Trim(); //课程名称
objvQuestionReferEN.FuncModuleId = objRow[convQuestionRefer.FuncModuleId] == DBNull.Value ? null : objRow[convQuestionRefer.FuncModuleId].ToString().Trim(); //功能模块Id
objvQuestionReferEN.FuncModuleName = objRow[convQuestionRefer.FuncModuleName] == DBNull.Value ? null : objRow[convQuestionRefer.FuncModuleName].ToString().Trim(); //功能模块名称
objvQuestionReferEN.FuncModuleNameSim = objRow[convQuestionRefer.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQuestionRefer.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvQuestionReferEN.TableName = objRow[convQuestionRefer.TableName] == DBNull.Value ? null : objRow[convQuestionRefer.TableName].ToString().Trim(); //主表表名
objvQuestionReferEN.KeyIdValue = objRow[convQuestionRefer.KeyIdValue] == DBNull.Value ? null : objRow[convQuestionRefer.KeyIdValue].ToString().Trim(); //关键字值
objvQuestionReferEN.CaseName = objRow[convQuestionRefer.CaseName] == DBNull.Value ? null : objRow[convQuestionRefer.CaseName].ToString().Trim(); //案例名称
objvQuestionReferEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionRefer.IsShow].ToString().Trim()); //是否启用
objvQuestionReferEN.UpdDate = objRow[convQuestionRefer.UpdDate].ToString().Trim(); //修改日期
objvQuestionReferEN.UpdUser = objRow[convQuestionRefer.UpdUser].ToString().Trim(); //修改人
objvQuestionReferEN.Memo = objRow[convQuestionRefer.Memo] == DBNull.Value ? null : objRow[convQuestionRefer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionReferEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionReferEN);
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
public static List<clsvQuestionReferEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvQuestionReferEN> arrObjLst = new List<clsvQuestionReferEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionReferEN objvQuestionReferEN = new clsvQuestionReferEN();
try
{
objvQuestionReferEN.mId = Int32.Parse(objRow[convQuestionRefer.mId].ToString().Trim()); //mId
objvQuestionReferEN.QuestionID = objRow[convQuestionRefer.QuestionID] == DBNull.Value ? null : objRow[convQuestionRefer.QuestionID].ToString().Trim(); //题目ID
objvQuestionReferEN.QuestionName = objRow[convQuestionRefer.QuestionName] == DBNull.Value ? null : objRow[convQuestionRefer.QuestionName].ToString().Trim(); //题目名称
objvQuestionReferEN.CourseId = objRow[convQuestionRefer.CourseId] == DBNull.Value ? null : objRow[convQuestionRefer.CourseId].ToString().Trim(); //课程Id
objvQuestionReferEN.CourseName = objRow[convQuestionRefer.CourseName] == DBNull.Value ? null : objRow[convQuestionRefer.CourseName].ToString().Trim(); //课程名称
objvQuestionReferEN.FuncModuleId = objRow[convQuestionRefer.FuncModuleId] == DBNull.Value ? null : objRow[convQuestionRefer.FuncModuleId].ToString().Trim(); //功能模块Id
objvQuestionReferEN.FuncModuleName = objRow[convQuestionRefer.FuncModuleName] == DBNull.Value ? null : objRow[convQuestionRefer.FuncModuleName].ToString().Trim(); //功能模块名称
objvQuestionReferEN.FuncModuleNameSim = objRow[convQuestionRefer.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQuestionRefer.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvQuestionReferEN.TableName = objRow[convQuestionRefer.TableName] == DBNull.Value ? null : objRow[convQuestionRefer.TableName].ToString().Trim(); //主表表名
objvQuestionReferEN.KeyIdValue = objRow[convQuestionRefer.KeyIdValue] == DBNull.Value ? null : objRow[convQuestionRefer.KeyIdValue].ToString().Trim(); //关键字值
objvQuestionReferEN.CaseName = objRow[convQuestionRefer.CaseName] == DBNull.Value ? null : objRow[convQuestionRefer.CaseName].ToString().Trim(); //案例名称
objvQuestionReferEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionRefer.IsShow].ToString().Trim()); //是否启用
objvQuestionReferEN.UpdDate = objRow[convQuestionRefer.UpdDate].ToString().Trim(); //修改日期
objvQuestionReferEN.UpdUser = objRow[convQuestionRefer.UpdUser].ToString().Trim(); //修改人
objvQuestionReferEN.Memo = objRow[convQuestionRefer.Memo] == DBNull.Value ? null : objRow[convQuestionRefer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionReferEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionReferEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvQuestionReferEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvQuestionReferEN> arrObjLst = new List<clsvQuestionReferEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvQuestionReferEN objvQuestionReferEN = new clsvQuestionReferEN();
try
{
objvQuestionReferEN.mId = Int32.Parse(objRow[convQuestionRefer.mId].ToString().Trim()); //mId
objvQuestionReferEN.QuestionID = objRow[convQuestionRefer.QuestionID] == DBNull.Value ? null : objRow[convQuestionRefer.QuestionID].ToString().Trim(); //题目ID
objvQuestionReferEN.QuestionName = objRow[convQuestionRefer.QuestionName] == DBNull.Value ? null : objRow[convQuestionRefer.QuestionName].ToString().Trim(); //题目名称
objvQuestionReferEN.CourseId = objRow[convQuestionRefer.CourseId] == DBNull.Value ? null : objRow[convQuestionRefer.CourseId].ToString().Trim(); //课程Id
objvQuestionReferEN.CourseName = objRow[convQuestionRefer.CourseName] == DBNull.Value ? null : objRow[convQuestionRefer.CourseName].ToString().Trim(); //课程名称
objvQuestionReferEN.FuncModuleId = objRow[convQuestionRefer.FuncModuleId] == DBNull.Value ? null : objRow[convQuestionRefer.FuncModuleId].ToString().Trim(); //功能模块Id
objvQuestionReferEN.FuncModuleName = objRow[convQuestionRefer.FuncModuleName] == DBNull.Value ? null : objRow[convQuestionRefer.FuncModuleName].ToString().Trim(); //功能模块名称
objvQuestionReferEN.FuncModuleNameSim = objRow[convQuestionRefer.FuncModuleNameSim] == DBNull.Value ? null : objRow[convQuestionRefer.FuncModuleNameSim].ToString().Trim(); //功能模块简称
objvQuestionReferEN.TableName = objRow[convQuestionRefer.TableName] == DBNull.Value ? null : objRow[convQuestionRefer.TableName].ToString().Trim(); //主表表名
objvQuestionReferEN.KeyIdValue = objRow[convQuestionRefer.KeyIdValue] == DBNull.Value ? null : objRow[convQuestionRefer.KeyIdValue].ToString().Trim(); //关键字值
objvQuestionReferEN.CaseName = objRow[convQuestionRefer.CaseName] == DBNull.Value ? null : objRow[convQuestionRefer.CaseName].ToString().Trim(); //案例名称
objvQuestionReferEN.IsShow = clsEntityBase2.TransNullToBool_S(objRow[convQuestionRefer.IsShow].ToString().Trim()); //是否启用
objvQuestionReferEN.UpdDate = objRow[convQuestionRefer.UpdDate].ToString().Trim(); //修改日期
objvQuestionReferEN.UpdUser = objRow[convQuestionRefer.UpdUser].ToString().Trim(); //修改人
objvQuestionReferEN.Memo = objRow[convQuestionRefer.Memo] == DBNull.Value ? null : objRow[convQuestionRefer.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvQuestionReferEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvQuestionReferEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvQuestionReferEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvQuestionRefer(ref clsvQuestionReferEN objvQuestionReferEN)
{
bool bolResult = vQuestionReferDA.GetvQuestionRefer(ref objvQuestionReferEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvQuestionReferEN GetObjBymId(long lngmId)
{
clsvQuestionReferEN objvQuestionReferEN = vQuestionReferDA.GetObjBymId(lngmId);
return objvQuestionReferEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvQuestionReferEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvQuestionReferEN objvQuestionReferEN = vQuestionReferDA.GetFirstObj(strWhereCond);
 return objvQuestionReferEN;
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
public static clsvQuestionReferEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvQuestionReferEN objvQuestionReferEN = vQuestionReferDA.GetObjByDataRow(objRow);
 return objvQuestionReferEN;
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
public static clsvQuestionReferEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvQuestionReferEN objvQuestionReferEN = vQuestionReferDA.GetObjByDataRow(objRow);
 return objvQuestionReferEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "lstvQuestionReferObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQuestionReferEN GetObjBymIdFromList(long lngmId, List<clsvQuestionReferEN> lstvQuestionReferObjLst)
{
foreach (clsvQuestionReferEN objvQuestionReferEN in lstvQuestionReferObjLst)
{
if (objvQuestionReferEN.mId == lngmId)
{
return objvQuestionReferEN;
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
 long lngmId;
 try
 {
 lngmId = new clsvQuestionReferDA().GetFirstID(strWhereCond);
 return lngmId;
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
 arrList = vQuestionReferDA.GetID(strWhereCond);
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
bool bolIsExist = vQuestionReferDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
bool bolIsExist = vQuestionReferDA.IsExist(lngmId);
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
 bolIsExist = clsvQuestionReferDA.IsExistTable();
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
 bolIsExist = vQuestionReferDA.IsExistTable(strTabName);
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
objvQuestionReferENT.FuncModuleNameSim = objvQuestionReferENS.FuncModuleNameSim; //功能模块简称
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
 /// <param name = "objvQuestionReferEN">源简化对象</param>
 public static void SetUpdFlag(clsvQuestionReferEN objvQuestionReferEN)
{
try
{
objvQuestionReferEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvQuestionReferEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convQuestionRefer.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionReferEN.mId = objvQuestionReferEN.mId; //mId
}
if (arrFldSet.Contains(convQuestionRefer.QuestionID, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionReferEN.QuestionID = objvQuestionReferEN.QuestionID == "[null]" ? null :  objvQuestionReferEN.QuestionID; //题目ID
}
if (arrFldSet.Contains(convQuestionRefer.QuestionName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionReferEN.QuestionName = objvQuestionReferEN.QuestionName == "[null]" ? null :  objvQuestionReferEN.QuestionName; //题目名称
}
if (arrFldSet.Contains(convQuestionRefer.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionReferEN.CourseId = objvQuestionReferEN.CourseId == "[null]" ? null :  objvQuestionReferEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convQuestionRefer.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionReferEN.CourseName = objvQuestionReferEN.CourseName == "[null]" ? null :  objvQuestionReferEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convQuestionRefer.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionReferEN.FuncModuleId = objvQuestionReferEN.FuncModuleId == "[null]" ? null :  objvQuestionReferEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(convQuestionRefer.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionReferEN.FuncModuleName = objvQuestionReferEN.FuncModuleName == "[null]" ? null :  objvQuestionReferEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convQuestionRefer.FuncModuleNameSim, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionReferEN.FuncModuleNameSim = objvQuestionReferEN.FuncModuleNameSim == "[null]" ? null :  objvQuestionReferEN.FuncModuleNameSim; //功能模块简称
}
if (arrFldSet.Contains(convQuestionRefer.TableName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionReferEN.TableName = objvQuestionReferEN.TableName == "[null]" ? null :  objvQuestionReferEN.TableName; //主表表名
}
if (arrFldSet.Contains(convQuestionRefer.KeyIdValue, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionReferEN.KeyIdValue = objvQuestionReferEN.KeyIdValue == "[null]" ? null :  objvQuestionReferEN.KeyIdValue; //关键字值
}
if (arrFldSet.Contains(convQuestionRefer.CaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionReferEN.CaseName = objvQuestionReferEN.CaseName == "[null]" ? null :  objvQuestionReferEN.CaseName; //案例名称
}
if (arrFldSet.Contains(convQuestionRefer.IsShow, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionReferEN.IsShow = objvQuestionReferEN.IsShow; //是否启用
}
if (arrFldSet.Contains(convQuestionRefer.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionReferEN.UpdDate = objvQuestionReferEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convQuestionRefer.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionReferEN.UpdUser = objvQuestionReferEN.UpdUser; //修改人
}
if (arrFldSet.Contains(convQuestionRefer.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvQuestionReferEN.Memo = objvQuestionReferEN.Memo == "[null]" ? null :  objvQuestionReferEN.Memo; //备注
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
 /// <param name = "objvQuestionReferEN">源简化对象</param>
 public static void AccessFldValueNull(clsvQuestionReferEN objvQuestionReferEN)
{
try
{
if (objvQuestionReferEN.QuestionID == "[null]") objvQuestionReferEN.QuestionID = null; //题目ID
if (objvQuestionReferEN.QuestionName == "[null]") objvQuestionReferEN.QuestionName = null; //题目名称
if (objvQuestionReferEN.CourseId == "[null]") objvQuestionReferEN.CourseId = null; //课程Id
if (objvQuestionReferEN.CourseName == "[null]") objvQuestionReferEN.CourseName = null; //课程名称
if (objvQuestionReferEN.FuncModuleId == "[null]") objvQuestionReferEN.FuncModuleId = null; //功能模块Id
if (objvQuestionReferEN.FuncModuleName == "[null]") objvQuestionReferEN.FuncModuleName = null; //功能模块名称
if (objvQuestionReferEN.FuncModuleNameSim == "[null]") objvQuestionReferEN.FuncModuleNameSim = null; //功能模块简称
if (objvQuestionReferEN.TableName == "[null]") objvQuestionReferEN.TableName = null; //主表表名
if (objvQuestionReferEN.KeyIdValue == "[null]") objvQuestionReferEN.KeyIdValue = null; //关键字值
if (objvQuestionReferEN.CaseName == "[null]") objvQuestionReferEN.CaseName = null; //案例名称
if (objvQuestionReferEN.Memo == "[null]") objvQuestionReferEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvQuestionReferEN objvQuestionReferEN)
{
 vQuestionReferDA.CheckProperty4Condition(objvQuestionReferEN);
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
if (clsFuncModuleBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleBL没有刷新缓存机制(clsFuncModuleBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionReferBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionReferBL没有刷新缓存机制(clsQuestionReferBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionnaireBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionnaireBL没有刷新缓存机制(clsQuestionnaireBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAnswerModeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsAnswerModeBL没有刷新缓存机制(clsAnswerModeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAnswerTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsAnswerTypeBL没有刷新缓存机制(clsAnswerTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionTypeBL没有刷新缓存机制(clsQuestionTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseBL没有刷新缓存机制(clscc_CourseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_ExamGradeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ExamGradeBL没有刷新缓存机制(clscc_ExamGradeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsQuestionType4CourseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsQuestionType4CourseBL没有刷新缓存机制(clsQuestionType4CourseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseChapterBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterBL没有刷新缓存机制(clscc_CourseChapterBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvQuestionReferObjLstCache == null)
//{
//arrvQuestionReferObjLstCache = vQuestionReferDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvQuestionReferEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvQuestionReferEN._CurrTabName);
List<clsvQuestionReferEN> arrvQuestionReferObjLstCache = GetObjLstCache();
IEnumerable <clsvQuestionReferEN> arrvQuestionReferObjLst_Sel =
arrvQuestionReferObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvQuestionReferObjLst_Sel.Count() == 0)
{
   clsvQuestionReferEN obj = clsvQuestionReferBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvQuestionReferObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQuestionReferEN> GetAllvQuestionReferObjLstCache()
{
//获取缓存中的对象列表
List<clsvQuestionReferEN> arrvQuestionReferObjLstCache = GetObjLstCache(); 
return arrvQuestionReferObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvQuestionReferEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvQuestionReferEN._CurrTabName);
List<clsvQuestionReferEN> arrvQuestionReferObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvQuestionReferObjLstCache;
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
string strKey = string.Format("{0}", clsvQuestionReferEN._CurrTabName);
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
 /// 日期:2023-08-24
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId)
{
if (strInFldName != convQuestionRefer.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convQuestionRefer.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convQuestionRefer.AttributeName));
throw new Exception(strMsg);
}
var objvQuestionRefer = clsvQuestionReferBL.GetObjBymIdCache(lngmId);
if (objvQuestionRefer == null) return "";
return objvQuestionRefer[strOutFldName].ToString();
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
int intRecCount = clsvQuestionReferDA.GetRecCount(strTabName);
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
int intRecCount = clsvQuestionReferDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvQuestionReferDA.GetRecCount();
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
int intRecCount = clsvQuestionReferDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvQuestionReferCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvQuestionReferEN objvQuestionReferCond)
{
List<clsvQuestionReferEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvQuestionReferEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convQuestionRefer.AttributeName)
{
if (objvQuestionReferCond.IsUpdated(strFldName) == false) continue;
if (objvQuestionReferCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionReferCond[strFldName].ToString());
}
else
{
if (objvQuestionReferCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvQuestionReferCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvQuestionReferCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvQuestionReferCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvQuestionReferCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvQuestionReferCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvQuestionReferCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvQuestionReferCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvQuestionReferCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvQuestionReferCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvQuestionReferCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvQuestionReferCond[strFldName]));
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
 List<string> arrList = clsvQuestionReferDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vQuestionReferDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vQuestionReferDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}