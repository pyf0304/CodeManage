
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCourseLearningAppraise4AppBL
 表名:vCourseLearningAppraise4App(01120273)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:45:34
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:微格教学评议(MicroTeachSenate)
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
public static class  clsvCourseLearningAppraise4AppBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdMicroteachAppraise">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCourseLearningAppraise4AppEN GetObj(this K_IdMicroteachAppraise_vCourseLearningAppraise4App myKey)
{
clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppEN = clsvCourseLearningAppraise4AppBL.vCourseLearningAppraise4AppDA.GetObjByIdMicroteachAppraise(myKey.Value);
return objvCourseLearningAppraise4AppEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraise4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraise4AppEN SetIdMicroteachAppraise(this clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppEN, long lngIdMicroteachAppraise, string strComparisonOp="")
	{
objvCourseLearningAppraise4AppEN.IdMicroteachAppraise = lngIdMicroteachAppraise; //评议流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraise4AppEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise4App.IdMicroteachAppraise) == false)
{
objvCourseLearningAppraise4AppEN.dicFldComparisonOp.Add(convCourseLearningAppraise4App.IdMicroteachAppraise, strComparisonOp);
}
else
{
objvCourseLearningAppraise4AppEN.dicFldComparisonOp[convCourseLearningAppraise4App.IdMicroteachAppraise] = strComparisonOp;
}
}
return objvCourseLearningAppraise4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraise4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraise4AppEN SetFuncModuleId(this clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convCourseLearningAppraise4App.FuncModuleId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convCourseLearningAppraise4App.FuncModuleId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convCourseLearningAppraise4App.FuncModuleId);
}
objvCourseLearningAppraise4AppEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraise4AppEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise4App.FuncModuleId) == false)
{
objvCourseLearningAppraise4AppEN.dicFldComparisonOp.Add(convCourseLearningAppraise4App.FuncModuleId, strComparisonOp);
}
else
{
objvCourseLearningAppraise4AppEN.dicFldComparisonOp[convCourseLearningAppraise4App.FuncModuleId] = strComparisonOp;
}
}
return objvCourseLearningAppraise4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraise4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraise4AppEN SetFuncModuleName(this clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppEN, string strFuncModuleName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convCourseLearningAppraise4App.FuncModuleName);
}
objvCourseLearningAppraise4AppEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraise4AppEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise4App.FuncModuleName) == false)
{
objvCourseLearningAppraise4AppEN.dicFldComparisonOp.Add(convCourseLearningAppraise4App.FuncModuleName, strComparisonOp);
}
else
{
objvCourseLearningAppraise4AppEN.dicFldComparisonOp[convCourseLearningAppraise4App.FuncModuleName] = strComparisonOp;
}
}
return objvCourseLearningAppraise4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraise4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraise4AppEN SetIdMicroteachCase(this clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppEN, string strIdMicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdMicroteachCase, convCourseLearningAppraise4App.IdMicroteachCase);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdMicroteachCase, 8, convCourseLearningAppraise4App.IdMicroteachCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdMicroteachCase, 8, convCourseLearningAppraise4App.IdMicroteachCase);
}
objvCourseLearningAppraise4AppEN.IdMicroteachCase = strIdMicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraise4AppEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise4App.IdMicroteachCase) == false)
{
objvCourseLearningAppraise4AppEN.dicFldComparisonOp.Add(convCourseLearningAppraise4App.IdMicroteachCase, strComparisonOp);
}
else
{
objvCourseLearningAppraise4AppEN.dicFldComparisonOp[convCourseLearningAppraise4App.IdMicroteachCase] = strComparisonOp;
}
}
return objvCourseLearningAppraise4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraise4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraise4AppEN SetIdCourseLearningCase(this clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppEN, string strIdCourseLearningCase, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdCourseLearningCase, 8, convCourseLearningAppraise4App.IdCourseLearningCase);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdCourseLearningCase, 8, convCourseLearningAppraise4App.IdCourseLearningCase);
}
objvCourseLearningAppraise4AppEN.IdCourseLearningCase = strIdCourseLearningCase; //课程学习案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraise4AppEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise4App.IdCourseLearningCase) == false)
{
objvCourseLearningAppraise4AppEN.dicFldComparisonOp.Add(convCourseLearningAppraise4App.IdCourseLearningCase, strComparisonOp);
}
else
{
objvCourseLearningAppraise4AppEN.dicFldComparisonOp[convCourseLearningAppraise4App.IdCourseLearningCase] = strComparisonOp;
}
}
return objvCourseLearningAppraise4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraise4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraise4AppEN SetCourseLearningCaseName(this clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppEN, string strCourseLearningCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseLearningCaseName, convCourseLearningAppraise4App.CourseLearningCaseName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseLearningCaseName, 100, convCourseLearningAppraise4App.CourseLearningCaseName);
}
objvCourseLearningAppraise4AppEN.CourseLearningCaseName = strCourseLearningCaseName; //课程学习案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraise4AppEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise4App.CourseLearningCaseName) == false)
{
objvCourseLearningAppraise4AppEN.dicFldComparisonOp.Add(convCourseLearningAppraise4App.CourseLearningCaseName, strComparisonOp);
}
else
{
objvCourseLearningAppraise4AppEN.dicFldComparisonOp[convCourseLearningAppraise4App.CourseLearningCaseName] = strComparisonOp;
}
}
return objvCourseLearningAppraise4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraise4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraise4AppEN SetIdAppraiseType(this clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppEN, string strIdAppraiseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdAppraiseType, convCourseLearningAppraise4App.IdAppraiseType);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdAppraiseType, 4, convCourseLearningAppraise4App.IdAppraiseType);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdAppraiseType, 4, convCourseLearningAppraise4App.IdAppraiseType);
}
objvCourseLearningAppraise4AppEN.IdAppraiseType = strIdAppraiseType; //评议类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraise4AppEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise4App.IdAppraiseType) == false)
{
objvCourseLearningAppraise4AppEN.dicFldComparisonOp.Add(convCourseLearningAppraise4App.IdAppraiseType, strComparisonOp);
}
else
{
objvCourseLearningAppraise4AppEN.dicFldComparisonOp[convCourseLearningAppraise4App.IdAppraiseType] = strComparisonOp;
}
}
return objvCourseLearningAppraise4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraise4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraise4AppEN SetAppraiseTypeName(this clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppEN, string strAppraiseTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAppraiseTypeName, 50, convCourseLearningAppraise4App.AppraiseTypeName);
}
objvCourseLearningAppraise4AppEN.AppraiseTypeName = strAppraiseTypeName; //评议类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraise4AppEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise4App.AppraiseTypeName) == false)
{
objvCourseLearningAppraise4AppEN.dicFldComparisonOp.Add(convCourseLearningAppraise4App.AppraiseTypeName, strComparisonOp);
}
else
{
objvCourseLearningAppraise4AppEN.dicFldComparisonOp[convCourseLearningAppraise4App.AppraiseTypeName] = strComparisonOp;
}
}
return objvCourseLearningAppraise4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraise4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraise4AppEN SetAppraiseContent(this clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppEN, string strAppraiseContent, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAppraiseContent, 2000, convCourseLearningAppraise4App.AppraiseContent);
}
objvCourseLearningAppraise4AppEN.AppraiseContent = strAppraiseContent; //评议内容
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraise4AppEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise4App.AppraiseContent) == false)
{
objvCourseLearningAppraise4AppEN.dicFldComparisonOp.Add(convCourseLearningAppraise4App.AppraiseContent, strComparisonOp);
}
else
{
objvCourseLearningAppraise4AppEN.dicFldComparisonOp[convCourseLearningAppraise4App.AppraiseContent] = strComparisonOp;
}
}
return objvCourseLearningAppraise4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraise4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraise4AppEN SetAppraiseDate(this clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppEN, string strAppraiseDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAppraiseDate, 8, convCourseLearningAppraise4App.AppraiseDate);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAppraiseDate, 8, convCourseLearningAppraise4App.AppraiseDate);
}
objvCourseLearningAppraise4AppEN.AppraiseDate = strAppraiseDate; //评议日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraise4AppEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise4App.AppraiseDate) == false)
{
objvCourseLearningAppraise4AppEN.dicFldComparisonOp.Add(convCourseLearningAppraise4App.AppraiseDate, strComparisonOp);
}
else
{
objvCourseLearningAppraise4AppEN.dicFldComparisonOp[convCourseLearningAppraise4App.AppraiseDate] = strComparisonOp;
}
}
return objvCourseLearningAppraise4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraise4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraise4AppEN SetAppraiseTime(this clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppEN, string strAppraiseTime, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strAppraiseTime, 6, convCourseLearningAppraise4App.AppraiseTime);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strAppraiseTime, 6, convCourseLearningAppraise4App.AppraiseTime);
}
objvCourseLearningAppraise4AppEN.AppraiseTime = strAppraiseTime; //评议时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraise4AppEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise4App.AppraiseTime) == false)
{
objvCourseLearningAppraise4AppEN.dicFldComparisonOp.Add(convCourseLearningAppraise4App.AppraiseTime, strComparisonOp);
}
else
{
objvCourseLearningAppraise4AppEN.dicFldComparisonOp[convCourseLearningAppraise4App.AppraiseTime] = strComparisonOp;
}
}
return objvCourseLearningAppraise4AppEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCourseLearningAppraise4AppEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCourseLearningAppraise4AppEN SetUserId(this clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convCourseLearningAppraise4App.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convCourseLearningAppraise4App.UserId);
}
objvCourseLearningAppraise4AppEN.UserId = strUserId; //用户ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCourseLearningAppraise4AppEN.dicFldComparisonOp.ContainsKey(convCourseLearningAppraise4App.UserId) == false)
{
objvCourseLearningAppraise4AppEN.dicFldComparisonOp.Add(convCourseLearningAppraise4App.UserId, strComparisonOp);
}
else
{
objvCourseLearningAppraise4AppEN.dicFldComparisonOp[convCourseLearningAppraise4App.UserId] = strComparisonOp;
}
}
return objvCourseLearningAppraise4AppEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvCourseLearningAppraise4AppENS">源对象</param>
 /// <param name = "objvCourseLearningAppraise4AppENT">目标对象</param>
 public static void CopyTo(this clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppENS, clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppENT)
{
try
{
objvCourseLearningAppraise4AppENT.IdMicroteachAppraise = objvCourseLearningAppraise4AppENS.IdMicroteachAppraise; //评议流水号
objvCourseLearningAppraise4AppENT.FuncModuleId = objvCourseLearningAppraise4AppENS.FuncModuleId; //功能模块Id
objvCourseLearningAppraise4AppENT.FuncModuleName = objvCourseLearningAppraise4AppENS.FuncModuleName; //功能模块名称
objvCourseLearningAppraise4AppENT.IdMicroteachCase = objvCourseLearningAppraise4AppENS.IdMicroteachCase; //微格教学案例流水号
objvCourseLearningAppraise4AppENT.IdCourseLearningCase = objvCourseLearningAppraise4AppENS.IdCourseLearningCase; //课程学习案例流水号
objvCourseLearningAppraise4AppENT.CourseLearningCaseName = objvCourseLearningAppraise4AppENS.CourseLearningCaseName; //课程学习案例名称
objvCourseLearningAppraise4AppENT.IdAppraiseType = objvCourseLearningAppraise4AppENS.IdAppraiseType; //评议类型流水号
objvCourseLearningAppraise4AppENT.AppraiseTypeName = objvCourseLearningAppraise4AppENS.AppraiseTypeName; //评议类型名称
objvCourseLearningAppraise4AppENT.AppraiseContent = objvCourseLearningAppraise4AppENS.AppraiseContent; //评议内容
objvCourseLearningAppraise4AppENT.AppraiseDate = objvCourseLearningAppraise4AppENS.AppraiseDate; //评议日期
objvCourseLearningAppraise4AppENT.AppraiseTime = objvCourseLearningAppraise4AppENS.AppraiseTime; //评议时间
objvCourseLearningAppraise4AppENT.UserId = objvCourseLearningAppraise4AppENS.UserId; //用户ID
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
 /// <param name = "objvCourseLearningAppraise4AppENS">源对象</param>
 /// <returns>目标对象=>clsvCourseLearningAppraise4AppEN:objvCourseLearningAppraise4AppENT</returns>
 public static clsvCourseLearningAppraise4AppEN CopyTo(this clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppENS)
{
try
{
 clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppENT = new clsvCourseLearningAppraise4AppEN()
{
IdMicroteachAppraise = objvCourseLearningAppraise4AppENS.IdMicroteachAppraise, //评议流水号
FuncModuleId = objvCourseLearningAppraise4AppENS.FuncModuleId, //功能模块Id
FuncModuleName = objvCourseLearningAppraise4AppENS.FuncModuleName, //功能模块名称
IdMicroteachCase = objvCourseLearningAppraise4AppENS.IdMicroteachCase, //微格教学案例流水号
IdCourseLearningCase = objvCourseLearningAppraise4AppENS.IdCourseLearningCase, //课程学习案例流水号
CourseLearningCaseName = objvCourseLearningAppraise4AppENS.CourseLearningCaseName, //课程学习案例名称
IdAppraiseType = objvCourseLearningAppraise4AppENS.IdAppraiseType, //评议类型流水号
AppraiseTypeName = objvCourseLearningAppraise4AppENS.AppraiseTypeName, //评议类型名称
AppraiseContent = objvCourseLearningAppraise4AppENS.AppraiseContent, //评议内容
AppraiseDate = objvCourseLearningAppraise4AppENS.AppraiseDate, //评议日期
AppraiseTime = objvCourseLearningAppraise4AppENS.AppraiseTime, //评议时间
UserId = objvCourseLearningAppraise4AppENS.UserId, //用户ID
};
 return objvCourseLearningAppraise4AppENT;
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
public static void CheckProperty4Condition(this clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppEN)
{
 clsvCourseLearningAppraise4AppBL.vCourseLearningAppraise4AppDA.CheckProperty4Condition(objvCourseLearningAppraise4AppEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCourseLearningAppraise4AppCond.IsUpdated(convCourseLearningAppraise4App.IdMicroteachAppraise) == true)
{
string strComparisonOpIdMicroteachAppraise = objvCourseLearningAppraise4AppCond.dicFldComparisonOp[convCourseLearningAppraise4App.IdMicroteachAppraise];
strWhereCond += string.Format(" And {0} {2} {1}", convCourseLearningAppraise4App.IdMicroteachAppraise, objvCourseLearningAppraise4AppCond.IdMicroteachAppraise, strComparisonOpIdMicroteachAppraise);
}
if (objvCourseLearningAppraise4AppCond.IsUpdated(convCourseLearningAppraise4App.FuncModuleId) == true)
{
string strComparisonOpFuncModuleId = objvCourseLearningAppraise4AppCond.dicFldComparisonOp[convCourseLearningAppraise4App.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise4App.FuncModuleId, objvCourseLearningAppraise4AppCond.FuncModuleId, strComparisonOpFuncModuleId);
}
if (objvCourseLearningAppraise4AppCond.IsUpdated(convCourseLearningAppraise4App.FuncModuleName) == true)
{
string strComparisonOpFuncModuleName = objvCourseLearningAppraise4AppCond.dicFldComparisonOp[convCourseLearningAppraise4App.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise4App.FuncModuleName, objvCourseLearningAppraise4AppCond.FuncModuleName, strComparisonOpFuncModuleName);
}
if (objvCourseLearningAppraise4AppCond.IsUpdated(convCourseLearningAppraise4App.IdMicroteachCase) == true)
{
string strComparisonOpIdMicroteachCase = objvCourseLearningAppraise4AppCond.dicFldComparisonOp[convCourseLearningAppraise4App.IdMicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise4App.IdMicroteachCase, objvCourseLearningAppraise4AppCond.IdMicroteachCase, strComparisonOpIdMicroteachCase);
}
if (objvCourseLearningAppraise4AppCond.IsUpdated(convCourseLearningAppraise4App.IdCourseLearningCase) == true)
{
string strComparisonOpIdCourseLearningCase = objvCourseLearningAppraise4AppCond.dicFldComparisonOp[convCourseLearningAppraise4App.IdCourseLearningCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise4App.IdCourseLearningCase, objvCourseLearningAppraise4AppCond.IdCourseLearningCase, strComparisonOpIdCourseLearningCase);
}
if (objvCourseLearningAppraise4AppCond.IsUpdated(convCourseLearningAppraise4App.CourseLearningCaseName) == true)
{
string strComparisonOpCourseLearningCaseName = objvCourseLearningAppraise4AppCond.dicFldComparisonOp[convCourseLearningAppraise4App.CourseLearningCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise4App.CourseLearningCaseName, objvCourseLearningAppraise4AppCond.CourseLearningCaseName, strComparisonOpCourseLearningCaseName);
}
if (objvCourseLearningAppraise4AppCond.IsUpdated(convCourseLearningAppraise4App.IdAppraiseType) == true)
{
string strComparisonOpIdAppraiseType = objvCourseLearningAppraise4AppCond.dicFldComparisonOp[convCourseLearningAppraise4App.IdAppraiseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise4App.IdAppraiseType, objvCourseLearningAppraise4AppCond.IdAppraiseType, strComparisonOpIdAppraiseType);
}
if (objvCourseLearningAppraise4AppCond.IsUpdated(convCourseLearningAppraise4App.AppraiseTypeName) == true)
{
string strComparisonOpAppraiseTypeName = objvCourseLearningAppraise4AppCond.dicFldComparisonOp[convCourseLearningAppraise4App.AppraiseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise4App.AppraiseTypeName, objvCourseLearningAppraise4AppCond.AppraiseTypeName, strComparisonOpAppraiseTypeName);
}
if (objvCourseLearningAppraise4AppCond.IsUpdated(convCourseLearningAppraise4App.AppraiseContent) == true)
{
string strComparisonOpAppraiseContent = objvCourseLearningAppraise4AppCond.dicFldComparisonOp[convCourseLearningAppraise4App.AppraiseContent];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise4App.AppraiseContent, objvCourseLearningAppraise4AppCond.AppraiseContent, strComparisonOpAppraiseContent);
}
if (objvCourseLearningAppraise4AppCond.IsUpdated(convCourseLearningAppraise4App.AppraiseDate) == true)
{
string strComparisonOpAppraiseDate = objvCourseLearningAppraise4AppCond.dicFldComparisonOp[convCourseLearningAppraise4App.AppraiseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise4App.AppraiseDate, objvCourseLearningAppraise4AppCond.AppraiseDate, strComparisonOpAppraiseDate);
}
if (objvCourseLearningAppraise4AppCond.IsUpdated(convCourseLearningAppraise4App.AppraiseTime) == true)
{
string strComparisonOpAppraiseTime = objvCourseLearningAppraise4AppCond.dicFldComparisonOp[convCourseLearningAppraise4App.AppraiseTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise4App.AppraiseTime, objvCourseLearningAppraise4AppCond.AppraiseTime, strComparisonOpAppraiseTime);
}
if (objvCourseLearningAppraise4AppCond.IsUpdated(convCourseLearningAppraise4App.UserId) == true)
{
string strComparisonOpUserId = objvCourseLearningAppraise4AppCond.dicFldComparisonOp[convCourseLearningAppraise4App.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCourseLearningAppraise4App.UserId, objvCourseLearningAppraise4AppCond.UserId, strComparisonOpUserId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vCourseLearningAppraise4App
{
public virtual bool UpdRelaTabDate(long lngIdMicroteachAppraise, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v课程学习定性评议_App(vCourseLearningAppraise4App)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvCourseLearningAppraise4AppBL
{
public static RelatedActions_vCourseLearningAppraise4App relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvCourseLearningAppraise4AppDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvCourseLearningAppraise4AppDA vCourseLearningAppraise4AppDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvCourseLearningAppraise4AppDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvCourseLearningAppraise4AppBL()
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
if (string.IsNullOrEmpty(clsvCourseLearningAppraise4AppEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCourseLearningAppraise4AppEN._ConnectString);
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
public static DataTable GetDataTable_vCourseLearningAppraise4App(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vCourseLearningAppraise4AppDA.GetDataTable_vCourseLearningAppraise4App(strWhereCond);
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
objDT = vCourseLearningAppraise4AppDA.GetDataTable(strWhereCond);
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
objDT = vCourseLearningAppraise4AppDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vCourseLearningAppraise4AppDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vCourseLearningAppraise4AppDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vCourseLearningAppraise4AppDA.GetDataTable_Top(objTopPara);
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
objDT = vCourseLearningAppraise4AppDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vCourseLearningAppraise4AppDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vCourseLearningAppraise4AppDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrIdMicroteachAppraiseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvCourseLearningAppraise4AppEN> GetObjLstByIdMicroteachAppraiseLst(List<long> arrIdMicroteachAppraiseLst)
{
List<clsvCourseLearningAppraise4AppEN> arrObjLst = new List<clsvCourseLearningAppraise4AppEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrIdMicroteachAppraiseLst);
 string strWhereCond = string.Format("IdMicroteachAppraise in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppEN = new clsvCourseLearningAppraise4AppEN();
try
{
objvCourseLearningAppraise4AppEN.IdMicroteachAppraise = Int32.Parse(objRow[convCourseLearningAppraise4App.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvCourseLearningAppraise4AppEN.FuncModuleId = objRow[convCourseLearningAppraise4App.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningAppraise4AppEN.FuncModuleName = objRow[convCourseLearningAppraise4App.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningAppraise4AppEN.IdMicroteachCase = objRow[convCourseLearningAppraise4App.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningAppraise4AppEN.IdCourseLearningCase = objRow[convCourseLearningAppraise4App.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningAppraise4AppEN.CourseLearningCaseName = objRow[convCourseLearningAppraise4App.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningAppraise4AppEN.IdAppraiseType = objRow[convCourseLearningAppraise4App.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvCourseLearningAppraise4AppEN.AppraiseTypeName = objRow[convCourseLearningAppraise4App.AppraiseTypeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvCourseLearningAppraise4AppEN.AppraiseContent = objRow[convCourseLearningAppraise4App.AppraiseContent] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.AppraiseContent].ToString().Trim(); //评议内容
objvCourseLearningAppraise4AppEN.AppraiseDate = objRow[convCourseLearningAppraise4App.AppraiseDate] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.AppraiseDate].ToString().Trim(); //评议日期
objvCourseLearningAppraise4AppEN.AppraiseTime = objRow[convCourseLearningAppraise4App.AppraiseTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.AppraiseTime].ToString().Trim(); //评议时间
objvCourseLearningAppraise4AppEN.UserId = objRow[convCourseLearningAppraise4App.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningAppraise4AppEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningAppraise4AppEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrIdMicroteachAppraiseLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvCourseLearningAppraise4AppEN> GetObjLstByIdMicroteachAppraiseLstCache(List<long> arrIdMicroteachAppraiseLst)
{
string strKey = string.Format("{0}", clsvCourseLearningAppraise4AppEN._CurrTabName);
List<clsvCourseLearningAppraise4AppEN> arrvCourseLearningAppraise4AppObjLstCache = GetObjLstCache();
IEnumerable <clsvCourseLearningAppraise4AppEN> arrvCourseLearningAppraise4AppObjLst_Sel =
arrvCourseLearningAppraise4AppObjLstCache
.Where(x => arrIdMicroteachAppraiseLst.Contains(x.IdMicroteachAppraise));
return arrvCourseLearningAppraise4AppObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningAppraise4AppEN> GetObjLst(string strWhereCond)
{
List<clsvCourseLearningAppraise4AppEN> arrObjLst = new List<clsvCourseLearningAppraise4AppEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppEN = new clsvCourseLearningAppraise4AppEN();
try
{
objvCourseLearningAppraise4AppEN.IdMicroteachAppraise = Int32.Parse(objRow[convCourseLearningAppraise4App.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvCourseLearningAppraise4AppEN.FuncModuleId = objRow[convCourseLearningAppraise4App.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningAppraise4AppEN.FuncModuleName = objRow[convCourseLearningAppraise4App.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningAppraise4AppEN.IdMicroteachCase = objRow[convCourseLearningAppraise4App.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningAppraise4AppEN.IdCourseLearningCase = objRow[convCourseLearningAppraise4App.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningAppraise4AppEN.CourseLearningCaseName = objRow[convCourseLearningAppraise4App.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningAppraise4AppEN.IdAppraiseType = objRow[convCourseLearningAppraise4App.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvCourseLearningAppraise4AppEN.AppraiseTypeName = objRow[convCourseLearningAppraise4App.AppraiseTypeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvCourseLearningAppraise4AppEN.AppraiseContent = objRow[convCourseLearningAppraise4App.AppraiseContent] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.AppraiseContent].ToString().Trim(); //评议内容
objvCourseLearningAppraise4AppEN.AppraiseDate = objRow[convCourseLearningAppraise4App.AppraiseDate] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.AppraiseDate].ToString().Trim(); //评议日期
objvCourseLearningAppraise4AppEN.AppraiseTime = objRow[convCourseLearningAppraise4App.AppraiseTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.AppraiseTime].ToString().Trim(); //评议时间
objvCourseLearningAppraise4AppEN.UserId = objRow[convCourseLearningAppraise4App.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningAppraise4AppEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningAppraise4AppEN);
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
public static List<clsvCourseLearningAppraise4AppEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvCourseLearningAppraise4AppEN> arrObjLst = new List<clsvCourseLearningAppraise4AppEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppEN = new clsvCourseLearningAppraise4AppEN();
try
{
objvCourseLearningAppraise4AppEN.IdMicroteachAppraise = Int32.Parse(objRow[convCourseLearningAppraise4App.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvCourseLearningAppraise4AppEN.FuncModuleId = objRow[convCourseLearningAppraise4App.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningAppraise4AppEN.FuncModuleName = objRow[convCourseLearningAppraise4App.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningAppraise4AppEN.IdMicroteachCase = objRow[convCourseLearningAppraise4App.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningAppraise4AppEN.IdCourseLearningCase = objRow[convCourseLearningAppraise4App.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningAppraise4AppEN.CourseLearningCaseName = objRow[convCourseLearningAppraise4App.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningAppraise4AppEN.IdAppraiseType = objRow[convCourseLearningAppraise4App.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvCourseLearningAppraise4AppEN.AppraiseTypeName = objRow[convCourseLearningAppraise4App.AppraiseTypeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvCourseLearningAppraise4AppEN.AppraiseContent = objRow[convCourseLearningAppraise4App.AppraiseContent] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.AppraiseContent].ToString().Trim(); //评议内容
objvCourseLearningAppraise4AppEN.AppraiseDate = objRow[convCourseLearningAppraise4App.AppraiseDate] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.AppraiseDate].ToString().Trim(); //评议日期
objvCourseLearningAppraise4AppEN.AppraiseTime = objRow[convCourseLearningAppraise4App.AppraiseTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.AppraiseTime].ToString().Trim(); //评议时间
objvCourseLearningAppraise4AppEN.UserId = objRow[convCourseLearningAppraise4App.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningAppraise4AppEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningAppraise4AppEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvCourseLearningAppraise4AppCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvCourseLearningAppraise4AppEN> GetSubObjLstCache(clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppCond)
{
List<clsvCourseLearningAppraise4AppEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCourseLearningAppraise4AppEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCourseLearningAppraise4App.AttributeName)
{
if (objvCourseLearningAppraise4AppCond.IsUpdated(strFldName) == false) continue;
if (objvCourseLearningAppraise4AppCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCourseLearningAppraise4AppCond[strFldName].ToString());
}
else
{
if (objvCourseLearningAppraise4AppCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCourseLearningAppraise4AppCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCourseLearningAppraise4AppCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCourseLearningAppraise4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCourseLearningAppraise4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCourseLearningAppraise4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCourseLearningAppraise4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCourseLearningAppraise4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCourseLearningAppraise4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCourseLearningAppraise4AppCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCourseLearningAppraise4AppCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCourseLearningAppraise4AppCond[strFldName]));
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
public static List<clsvCourseLearningAppraise4AppEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvCourseLearningAppraise4AppEN> arrObjLst = new List<clsvCourseLearningAppraise4AppEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppEN = new clsvCourseLearningAppraise4AppEN();
try
{
objvCourseLearningAppraise4AppEN.IdMicroteachAppraise = Int32.Parse(objRow[convCourseLearningAppraise4App.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvCourseLearningAppraise4AppEN.FuncModuleId = objRow[convCourseLearningAppraise4App.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningAppraise4AppEN.FuncModuleName = objRow[convCourseLearningAppraise4App.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningAppraise4AppEN.IdMicroteachCase = objRow[convCourseLearningAppraise4App.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningAppraise4AppEN.IdCourseLearningCase = objRow[convCourseLearningAppraise4App.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningAppraise4AppEN.CourseLearningCaseName = objRow[convCourseLearningAppraise4App.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningAppraise4AppEN.IdAppraiseType = objRow[convCourseLearningAppraise4App.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvCourseLearningAppraise4AppEN.AppraiseTypeName = objRow[convCourseLearningAppraise4App.AppraiseTypeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvCourseLearningAppraise4AppEN.AppraiseContent = objRow[convCourseLearningAppraise4App.AppraiseContent] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.AppraiseContent].ToString().Trim(); //评议内容
objvCourseLearningAppraise4AppEN.AppraiseDate = objRow[convCourseLearningAppraise4App.AppraiseDate] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.AppraiseDate].ToString().Trim(); //评议日期
objvCourseLearningAppraise4AppEN.AppraiseTime = objRow[convCourseLearningAppraise4App.AppraiseTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.AppraiseTime].ToString().Trim(); //评议时间
objvCourseLearningAppraise4AppEN.UserId = objRow[convCourseLearningAppraise4App.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningAppraise4AppEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningAppraise4AppEN);
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
public static List<clsvCourseLearningAppraise4AppEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvCourseLearningAppraise4AppEN> arrObjLst = new List<clsvCourseLearningAppraise4AppEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppEN = new clsvCourseLearningAppraise4AppEN();
try
{
objvCourseLearningAppraise4AppEN.IdMicroteachAppraise = Int32.Parse(objRow[convCourseLearningAppraise4App.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvCourseLearningAppraise4AppEN.FuncModuleId = objRow[convCourseLearningAppraise4App.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningAppraise4AppEN.FuncModuleName = objRow[convCourseLearningAppraise4App.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningAppraise4AppEN.IdMicroteachCase = objRow[convCourseLearningAppraise4App.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningAppraise4AppEN.IdCourseLearningCase = objRow[convCourseLearningAppraise4App.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningAppraise4AppEN.CourseLearningCaseName = objRow[convCourseLearningAppraise4App.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningAppraise4AppEN.IdAppraiseType = objRow[convCourseLearningAppraise4App.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvCourseLearningAppraise4AppEN.AppraiseTypeName = objRow[convCourseLearningAppraise4App.AppraiseTypeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvCourseLearningAppraise4AppEN.AppraiseContent = objRow[convCourseLearningAppraise4App.AppraiseContent] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.AppraiseContent].ToString().Trim(); //评议内容
objvCourseLearningAppraise4AppEN.AppraiseDate = objRow[convCourseLearningAppraise4App.AppraiseDate] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.AppraiseDate].ToString().Trim(); //评议日期
objvCourseLearningAppraise4AppEN.AppraiseTime = objRow[convCourseLearningAppraise4App.AppraiseTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.AppraiseTime].ToString().Trim(); //评议时间
objvCourseLearningAppraise4AppEN.UserId = objRow[convCourseLearningAppraise4App.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningAppraise4AppEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningAppraise4AppEN);
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
List<clsvCourseLearningAppraise4AppEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvCourseLearningAppraise4AppEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningAppraise4AppEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvCourseLearningAppraise4AppEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvCourseLearningAppraise4AppEN> arrObjLst = new List<clsvCourseLearningAppraise4AppEN>(); 
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
	clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppEN = new clsvCourseLearningAppraise4AppEN();
try
{
objvCourseLearningAppraise4AppEN.IdMicroteachAppraise = Int32.Parse(objRow[convCourseLearningAppraise4App.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvCourseLearningAppraise4AppEN.FuncModuleId = objRow[convCourseLearningAppraise4App.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningAppraise4AppEN.FuncModuleName = objRow[convCourseLearningAppraise4App.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningAppraise4AppEN.IdMicroteachCase = objRow[convCourseLearningAppraise4App.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningAppraise4AppEN.IdCourseLearningCase = objRow[convCourseLearningAppraise4App.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningAppraise4AppEN.CourseLearningCaseName = objRow[convCourseLearningAppraise4App.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningAppraise4AppEN.IdAppraiseType = objRow[convCourseLearningAppraise4App.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvCourseLearningAppraise4AppEN.AppraiseTypeName = objRow[convCourseLearningAppraise4App.AppraiseTypeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvCourseLearningAppraise4AppEN.AppraiseContent = objRow[convCourseLearningAppraise4App.AppraiseContent] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.AppraiseContent].ToString().Trim(); //评议内容
objvCourseLearningAppraise4AppEN.AppraiseDate = objRow[convCourseLearningAppraise4App.AppraiseDate] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.AppraiseDate].ToString().Trim(); //评议日期
objvCourseLearningAppraise4AppEN.AppraiseTime = objRow[convCourseLearningAppraise4App.AppraiseTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.AppraiseTime].ToString().Trim(); //评议时间
objvCourseLearningAppraise4AppEN.UserId = objRow[convCourseLearningAppraise4App.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningAppraise4AppEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningAppraise4AppEN);
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
public static List<clsvCourseLearningAppraise4AppEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvCourseLearningAppraise4AppEN> arrObjLst = new List<clsvCourseLearningAppraise4AppEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppEN = new clsvCourseLearningAppraise4AppEN();
try
{
objvCourseLearningAppraise4AppEN.IdMicroteachAppraise = Int32.Parse(objRow[convCourseLearningAppraise4App.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvCourseLearningAppraise4AppEN.FuncModuleId = objRow[convCourseLearningAppraise4App.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningAppraise4AppEN.FuncModuleName = objRow[convCourseLearningAppraise4App.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningAppraise4AppEN.IdMicroteachCase = objRow[convCourseLearningAppraise4App.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningAppraise4AppEN.IdCourseLearningCase = objRow[convCourseLearningAppraise4App.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningAppraise4AppEN.CourseLearningCaseName = objRow[convCourseLearningAppraise4App.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningAppraise4AppEN.IdAppraiseType = objRow[convCourseLearningAppraise4App.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvCourseLearningAppraise4AppEN.AppraiseTypeName = objRow[convCourseLearningAppraise4App.AppraiseTypeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvCourseLearningAppraise4AppEN.AppraiseContent = objRow[convCourseLearningAppraise4App.AppraiseContent] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.AppraiseContent].ToString().Trim(); //评议内容
objvCourseLearningAppraise4AppEN.AppraiseDate = objRow[convCourseLearningAppraise4App.AppraiseDate] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.AppraiseDate].ToString().Trim(); //评议日期
objvCourseLearningAppraise4AppEN.AppraiseTime = objRow[convCourseLearningAppraise4App.AppraiseTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.AppraiseTime].ToString().Trim(); //评议时间
objvCourseLearningAppraise4AppEN.UserId = objRow[convCourseLearningAppraise4App.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningAppraise4AppEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningAppraise4AppEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvCourseLearningAppraise4AppEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvCourseLearningAppraise4AppEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvCourseLearningAppraise4AppEN> arrObjLst = new List<clsvCourseLearningAppraise4AppEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppEN = new clsvCourseLearningAppraise4AppEN();
try
{
objvCourseLearningAppraise4AppEN.IdMicroteachAppraise = Int32.Parse(objRow[convCourseLearningAppraise4App.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvCourseLearningAppraise4AppEN.FuncModuleId = objRow[convCourseLearningAppraise4App.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningAppraise4AppEN.FuncModuleName = objRow[convCourseLearningAppraise4App.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningAppraise4AppEN.IdMicroteachCase = objRow[convCourseLearningAppraise4App.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningAppraise4AppEN.IdCourseLearningCase = objRow[convCourseLearningAppraise4App.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningAppraise4AppEN.CourseLearningCaseName = objRow[convCourseLearningAppraise4App.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningAppraise4AppEN.IdAppraiseType = objRow[convCourseLearningAppraise4App.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvCourseLearningAppraise4AppEN.AppraiseTypeName = objRow[convCourseLearningAppraise4App.AppraiseTypeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvCourseLearningAppraise4AppEN.AppraiseContent = objRow[convCourseLearningAppraise4App.AppraiseContent] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.AppraiseContent].ToString().Trim(); //评议内容
objvCourseLearningAppraise4AppEN.AppraiseDate = objRow[convCourseLearningAppraise4App.AppraiseDate] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.AppraiseDate].ToString().Trim(); //评议日期
objvCourseLearningAppraise4AppEN.AppraiseTime = objRow[convCourseLearningAppraise4App.AppraiseTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.AppraiseTime].ToString().Trim(); //评议时间
objvCourseLearningAppraise4AppEN.UserId = objRow[convCourseLearningAppraise4App.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningAppraise4AppEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningAppraise4AppEN);
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
public static List<clsvCourseLearningAppraise4AppEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvCourseLearningAppraise4AppEN> arrObjLst = new List<clsvCourseLearningAppraise4AppEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppEN = new clsvCourseLearningAppraise4AppEN();
try
{
objvCourseLearningAppraise4AppEN.IdMicroteachAppraise = Int32.Parse(objRow[convCourseLearningAppraise4App.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvCourseLearningAppraise4AppEN.FuncModuleId = objRow[convCourseLearningAppraise4App.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningAppraise4AppEN.FuncModuleName = objRow[convCourseLearningAppraise4App.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningAppraise4AppEN.IdMicroteachCase = objRow[convCourseLearningAppraise4App.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningAppraise4AppEN.IdCourseLearningCase = objRow[convCourseLearningAppraise4App.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningAppraise4AppEN.CourseLearningCaseName = objRow[convCourseLearningAppraise4App.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningAppraise4AppEN.IdAppraiseType = objRow[convCourseLearningAppraise4App.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvCourseLearningAppraise4AppEN.AppraiseTypeName = objRow[convCourseLearningAppraise4App.AppraiseTypeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvCourseLearningAppraise4AppEN.AppraiseContent = objRow[convCourseLearningAppraise4App.AppraiseContent] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.AppraiseContent].ToString().Trim(); //评议内容
objvCourseLearningAppraise4AppEN.AppraiseDate = objRow[convCourseLearningAppraise4App.AppraiseDate] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.AppraiseDate].ToString().Trim(); //评议日期
objvCourseLearningAppraise4AppEN.AppraiseTime = objRow[convCourseLearningAppraise4App.AppraiseTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.AppraiseTime].ToString().Trim(); //评议时间
objvCourseLearningAppraise4AppEN.UserId = objRow[convCourseLearningAppraise4App.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningAppraise4AppEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningAppraise4AppEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCourseLearningAppraise4AppEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvCourseLearningAppraise4AppEN> arrObjLst = new List<clsvCourseLearningAppraise4AppEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppEN = new clsvCourseLearningAppraise4AppEN();
try
{
objvCourseLearningAppraise4AppEN.IdMicroteachAppraise = Int32.Parse(objRow[convCourseLearningAppraise4App.IdMicroteachAppraise].ToString().Trim()); //评议流水号
objvCourseLearningAppraise4AppEN.FuncModuleId = objRow[convCourseLearningAppraise4App.FuncModuleId].ToString().Trim(); //功能模块Id
objvCourseLearningAppraise4AppEN.FuncModuleName = objRow[convCourseLearningAppraise4App.FuncModuleName] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.FuncModuleName].ToString().Trim(); //功能模块名称
objvCourseLearningAppraise4AppEN.IdMicroteachCase = objRow[convCourseLearningAppraise4App.IdMicroteachCase].ToString().Trim(); //微格教学案例流水号
objvCourseLearningAppraise4AppEN.IdCourseLearningCase = objRow[convCourseLearningAppraise4App.IdCourseLearningCase] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.IdCourseLearningCase].ToString().Trim(); //课程学习案例流水号
objvCourseLearningAppraise4AppEN.CourseLearningCaseName = objRow[convCourseLearningAppraise4App.CourseLearningCaseName].ToString().Trim(); //课程学习案例名称
objvCourseLearningAppraise4AppEN.IdAppraiseType = objRow[convCourseLearningAppraise4App.IdAppraiseType].ToString().Trim(); //评议类型流水号
objvCourseLearningAppraise4AppEN.AppraiseTypeName = objRow[convCourseLearningAppraise4App.AppraiseTypeName] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.AppraiseTypeName].ToString().Trim(); //评议类型名称
objvCourseLearningAppraise4AppEN.AppraiseContent = objRow[convCourseLearningAppraise4App.AppraiseContent] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.AppraiseContent].ToString().Trim(); //评议内容
objvCourseLearningAppraise4AppEN.AppraiseDate = objRow[convCourseLearningAppraise4App.AppraiseDate] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.AppraiseDate].ToString().Trim(); //评议日期
objvCourseLearningAppraise4AppEN.AppraiseTime = objRow[convCourseLearningAppraise4App.AppraiseTime] == DBNull.Value ? null : objRow[convCourseLearningAppraise4App.AppraiseTime].ToString().Trim(); //评议时间
objvCourseLearningAppraise4AppEN.UserId = objRow[convCourseLearningAppraise4App.UserId].ToString().Trim(); //用户ID
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCourseLearningAppraise4AppEN.IdMicroteachAppraise, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCourseLearningAppraise4AppEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvCourseLearningAppraise4AppEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvCourseLearningAppraise4App(ref clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppEN)
{
bool bolResult = vCourseLearningAppraise4AppDA.GetvCourseLearningAppraise4App(ref objvCourseLearningAppraise4AppEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngIdMicroteachAppraise">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCourseLearningAppraise4AppEN GetObjByIdMicroteachAppraise(long lngIdMicroteachAppraise)
{
clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppEN = vCourseLearningAppraise4AppDA.GetObjByIdMicroteachAppraise(lngIdMicroteachAppraise);
return objvCourseLearningAppraise4AppEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvCourseLearningAppraise4AppEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppEN = vCourseLearningAppraise4AppDA.GetFirstObj(strWhereCond);
 return objvCourseLearningAppraise4AppEN;
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
public static clsvCourseLearningAppraise4AppEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppEN = vCourseLearningAppraise4AppDA.GetObjByDataRow(objRow);
 return objvCourseLearningAppraise4AppEN;
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
public static clsvCourseLearningAppraise4AppEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppEN = vCourseLearningAppraise4AppDA.GetObjByDataRow(objRow);
 return objvCourseLearningAppraise4AppEN;
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
 /// <param name = "lngIdMicroteachAppraise">所给的关键字</param>
 /// <param name = "lstvCourseLearningAppraise4AppObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCourseLearningAppraise4AppEN GetObjByIdMicroteachAppraiseFromList(long lngIdMicroteachAppraise, List<clsvCourseLearningAppraise4AppEN> lstvCourseLearningAppraise4AppObjLst)
{
foreach (clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppEN in lstvCourseLearningAppraise4AppObjLst)
{
if (objvCourseLearningAppraise4AppEN.IdMicroteachAppraise == lngIdMicroteachAppraise)
{
return objvCourseLearningAppraise4AppEN;
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
 long lngIdMicroteachAppraise;
 try
 {
 lngIdMicroteachAppraise = new clsvCourseLearningAppraise4AppDA().GetFirstID(strWhereCond);
 return lngIdMicroteachAppraise;
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
 arrList = vCourseLearningAppraise4AppDA.GetID(strWhereCond);
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
bool bolIsExist = vCourseLearningAppraise4AppDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngIdMicroteachAppraise">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngIdMicroteachAppraise)
{
//检测记录是否存在
bool bolIsExist = vCourseLearningAppraise4AppDA.IsExist(lngIdMicroteachAppraise);
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
 bolIsExist = clsvCourseLearningAppraise4AppDA.IsExistTable();
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
 bolIsExist = vCourseLearningAppraise4AppDA.IsExistTable(strTabName);
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
 /// <param name = "objvCourseLearningAppraise4AppENS">源对象</param>
 /// <param name = "objvCourseLearningAppraise4AppENT">目标对象</param>
 public static void CopyTo(clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppENS, clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppENT)
{
try
{
objvCourseLearningAppraise4AppENT.IdMicroteachAppraise = objvCourseLearningAppraise4AppENS.IdMicroteachAppraise; //评议流水号
objvCourseLearningAppraise4AppENT.FuncModuleId = objvCourseLearningAppraise4AppENS.FuncModuleId; //功能模块Id
objvCourseLearningAppraise4AppENT.FuncModuleName = objvCourseLearningAppraise4AppENS.FuncModuleName; //功能模块名称
objvCourseLearningAppraise4AppENT.IdMicroteachCase = objvCourseLearningAppraise4AppENS.IdMicroteachCase; //微格教学案例流水号
objvCourseLearningAppraise4AppENT.IdCourseLearningCase = objvCourseLearningAppraise4AppENS.IdCourseLearningCase; //课程学习案例流水号
objvCourseLearningAppraise4AppENT.CourseLearningCaseName = objvCourseLearningAppraise4AppENS.CourseLearningCaseName; //课程学习案例名称
objvCourseLearningAppraise4AppENT.IdAppraiseType = objvCourseLearningAppraise4AppENS.IdAppraiseType; //评议类型流水号
objvCourseLearningAppraise4AppENT.AppraiseTypeName = objvCourseLearningAppraise4AppENS.AppraiseTypeName; //评议类型名称
objvCourseLearningAppraise4AppENT.AppraiseContent = objvCourseLearningAppraise4AppENS.AppraiseContent; //评议内容
objvCourseLearningAppraise4AppENT.AppraiseDate = objvCourseLearningAppraise4AppENS.AppraiseDate; //评议日期
objvCourseLearningAppraise4AppENT.AppraiseTime = objvCourseLearningAppraise4AppENS.AppraiseTime; //评议时间
objvCourseLearningAppraise4AppENT.UserId = objvCourseLearningAppraise4AppENS.UserId; //用户ID
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
 /// <param name = "objvCourseLearningAppraise4AppEN">源简化对象</param>
 public static void SetUpdFlag(clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppEN)
{
try
{
objvCourseLearningAppraise4AppEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvCourseLearningAppraise4AppEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convCourseLearningAppraise4App.IdMicroteachAppraise, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraise4AppEN.IdMicroteachAppraise = objvCourseLearningAppraise4AppEN.IdMicroteachAppraise; //评议流水号
}
if (arrFldSet.Contains(convCourseLearningAppraise4App.FuncModuleId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraise4AppEN.FuncModuleId = objvCourseLearningAppraise4AppEN.FuncModuleId; //功能模块Id
}
if (arrFldSet.Contains(convCourseLearningAppraise4App.FuncModuleName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraise4AppEN.FuncModuleName = objvCourseLearningAppraise4AppEN.FuncModuleName == "[null]" ? null :  objvCourseLearningAppraise4AppEN.FuncModuleName; //功能模块名称
}
if (arrFldSet.Contains(convCourseLearningAppraise4App.IdMicroteachCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraise4AppEN.IdMicroteachCase = objvCourseLearningAppraise4AppEN.IdMicroteachCase; //微格教学案例流水号
}
if (arrFldSet.Contains(convCourseLearningAppraise4App.IdCourseLearningCase, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraise4AppEN.IdCourseLearningCase = objvCourseLearningAppraise4AppEN.IdCourseLearningCase == "[null]" ? null :  objvCourseLearningAppraise4AppEN.IdCourseLearningCase; //课程学习案例流水号
}
if (arrFldSet.Contains(convCourseLearningAppraise4App.CourseLearningCaseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraise4AppEN.CourseLearningCaseName = objvCourseLearningAppraise4AppEN.CourseLearningCaseName; //课程学习案例名称
}
if (arrFldSet.Contains(convCourseLearningAppraise4App.IdAppraiseType, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraise4AppEN.IdAppraiseType = objvCourseLearningAppraise4AppEN.IdAppraiseType; //评议类型流水号
}
if (arrFldSet.Contains(convCourseLearningAppraise4App.AppraiseTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraise4AppEN.AppraiseTypeName = objvCourseLearningAppraise4AppEN.AppraiseTypeName == "[null]" ? null :  objvCourseLearningAppraise4AppEN.AppraiseTypeName; //评议类型名称
}
if (arrFldSet.Contains(convCourseLearningAppraise4App.AppraiseContent, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraise4AppEN.AppraiseContent = objvCourseLearningAppraise4AppEN.AppraiseContent == "[null]" ? null :  objvCourseLearningAppraise4AppEN.AppraiseContent; //评议内容
}
if (arrFldSet.Contains(convCourseLearningAppraise4App.AppraiseDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraise4AppEN.AppraiseDate = objvCourseLearningAppraise4AppEN.AppraiseDate == "[null]" ? null :  objvCourseLearningAppraise4AppEN.AppraiseDate; //评议日期
}
if (arrFldSet.Contains(convCourseLearningAppraise4App.AppraiseTime, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraise4AppEN.AppraiseTime = objvCourseLearningAppraise4AppEN.AppraiseTime == "[null]" ? null :  objvCourseLearningAppraise4AppEN.AppraiseTime; //评议时间
}
if (arrFldSet.Contains(convCourseLearningAppraise4App.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCourseLearningAppraise4AppEN.UserId = objvCourseLearningAppraise4AppEN.UserId; //用户ID
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
 /// <param name = "objvCourseLearningAppraise4AppEN">源简化对象</param>
 public static void AccessFldValueNull(clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppEN)
{
try
{
if (objvCourseLearningAppraise4AppEN.FuncModuleName == "[null]") objvCourseLearningAppraise4AppEN.FuncModuleName = null; //功能模块名称
if (objvCourseLearningAppraise4AppEN.IdCourseLearningCase == "[null]") objvCourseLearningAppraise4AppEN.IdCourseLearningCase = null; //课程学习案例流水号
if (objvCourseLearningAppraise4AppEN.AppraiseTypeName == "[null]") objvCourseLearningAppraise4AppEN.AppraiseTypeName = null; //评议类型名称
if (objvCourseLearningAppraise4AppEN.AppraiseContent == "[null]") objvCourseLearningAppraise4AppEN.AppraiseContent = null; //评议内容
if (objvCourseLearningAppraise4AppEN.AppraiseDate == "[null]") objvCourseLearningAppraise4AppEN.AppraiseDate = null; //评议日期
if (objvCourseLearningAppraise4AppEN.AppraiseTime == "[null]") objvCourseLearningAppraise4AppEN.AppraiseTime = null; //评议时间
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
public static void CheckProperty4Condition(clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppEN)
{
 vCourseLearningAppraise4AppDA.CheckProperty4Condition(objvCourseLearningAppraise4AppEN);
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
if (clsMicroteachAppraiseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachAppraiseBL没有刷新缓存机制(clsMicroteachAppraiseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCourseLearningCaseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCourseLearningCaseBL没有刷新缓存机制(clsCourseLearningCaseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsAppraiseTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsAppraiseTypeBL没有刷新缓存机制(clsAppraiseTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by IdMicroteachAppraise");
//if (arrvCourseLearningAppraise4AppObjLstCache == null)
//{
//arrvCourseLearningAppraise4AppObjLstCache = vCourseLearningAppraise4AppDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngIdMicroteachAppraise">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCourseLearningAppraise4AppEN GetObjByIdMicroteachAppraiseCache(long lngIdMicroteachAppraise)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvCourseLearningAppraise4AppEN._CurrTabName);
List<clsvCourseLearningAppraise4AppEN> arrvCourseLearningAppraise4AppObjLstCache = GetObjLstCache();
IEnumerable <clsvCourseLearningAppraise4AppEN> arrvCourseLearningAppraise4AppObjLst_Sel =
arrvCourseLearningAppraise4AppObjLstCache
.Where(x=> x.IdMicroteachAppraise == lngIdMicroteachAppraise 
);
if (arrvCourseLearningAppraise4AppObjLst_Sel.Count() == 0)
{
   clsvCourseLearningAppraise4AppEN obj = clsvCourseLearningAppraise4AppBL.GetObjByIdMicroteachAppraise(lngIdMicroteachAppraise);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvCourseLearningAppraise4AppObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCourseLearningAppraise4AppEN> GetAllvCourseLearningAppraise4AppObjLstCache()
{
//获取缓存中的对象列表
List<clsvCourseLearningAppraise4AppEN> arrvCourseLearningAppraise4AppObjLstCache = GetObjLstCache(); 
return arrvCourseLearningAppraise4AppObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCourseLearningAppraise4AppEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvCourseLearningAppraise4AppEN._CurrTabName);
List<clsvCourseLearningAppraise4AppEN> arrvCourseLearningAppraise4AppObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCourseLearningAppraise4AppObjLstCache;
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
string strKey = string.Format("{0}", clsvCourseLearningAppraise4AppEN._CurrTabName);
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
public static string Func(string strInFldName, string strOutFldName, long lngIdMicroteachAppraise)
{
if (strInFldName != convCourseLearningAppraise4App.IdMicroteachAppraise)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convCourseLearningAppraise4App.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convCourseLearningAppraise4App.AttributeName));
throw new Exception(strMsg);
}
var objvCourseLearningAppraise4App = clsvCourseLearningAppraise4AppBL.GetObjByIdMicroteachAppraiseCache(lngIdMicroteachAppraise);
if (objvCourseLearningAppraise4App == null) return "";
return objvCourseLearningAppraise4App[strOutFldName].ToString();
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
int intRecCount = clsvCourseLearningAppraise4AppDA.GetRecCount(strTabName);
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
int intRecCount = clsvCourseLearningAppraise4AppDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvCourseLearningAppraise4AppDA.GetRecCount();
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
int intRecCount = clsvCourseLearningAppraise4AppDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvCourseLearningAppraise4AppCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvCourseLearningAppraise4AppEN objvCourseLearningAppraise4AppCond)
{
List<clsvCourseLearningAppraise4AppEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvCourseLearningAppraise4AppEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCourseLearningAppraise4App.AttributeName)
{
if (objvCourseLearningAppraise4AppCond.IsUpdated(strFldName) == false) continue;
if (objvCourseLearningAppraise4AppCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCourseLearningAppraise4AppCond[strFldName].ToString());
}
else
{
if (objvCourseLearningAppraise4AppCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCourseLearningAppraise4AppCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCourseLearningAppraise4AppCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCourseLearningAppraise4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCourseLearningAppraise4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCourseLearningAppraise4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCourseLearningAppraise4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCourseLearningAppraise4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCourseLearningAppraise4AppCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCourseLearningAppraise4AppCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCourseLearningAppraise4AppCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCourseLearningAppraise4AppCond[strFldName]));
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
 List<string> arrList = clsvCourseLearningAppraise4AppDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vCourseLearningAppraise4AppDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vCourseLearningAppraise4AppDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}