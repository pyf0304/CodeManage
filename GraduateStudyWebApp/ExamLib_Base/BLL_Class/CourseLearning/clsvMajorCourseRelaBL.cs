
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMajorCourseRelaBL
 表名:vMajorCourseRela(01120540)
 * 版本:2023.08.23.1(服务器:WIN-SRV103-116)
 日期:2023/08/24 14:47:04
 生成者:pyf
 生成服务器IP:
 工程名称:问卷调查(0112)
 CM工程:公共后台所有表(变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习(CourseLearning)
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
public static class  clsvMajorCourseRelaBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMajorCourseRelaEN GetObj(this K_mId_vMajorCourseRela myKey)
{
clsvMajorCourseRelaEN objvMajorCourseRelaEN = clsvMajorCourseRelaBL.vMajorCourseRelaDA.GetObjBymId(myKey.Value);
return objvMajorCourseRelaEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorCourseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMajorCourseRelaEN SetmId(this clsvMajorCourseRelaEN objvMajorCourseRelaEN, long lngmId, string strComparisonOp="")
	{
objvMajorCourseRelaEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMajorCourseRelaEN.dicFldComparisonOp.ContainsKey(convMajorCourseRela.mId) == false)
{
objvMajorCourseRelaEN.dicFldComparisonOp.Add(convMajorCourseRela.mId, strComparisonOp);
}
else
{
objvMajorCourseRelaEN.dicFldComparisonOp[convMajorCourseRela.mId] = strComparisonOp;
}
}
return objvMajorCourseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorCourseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMajorCourseRelaEN SetCourseId(this clsvMajorCourseRelaEN objvMajorCourseRelaEN, string strCourseId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseId, 8, convMajorCourseRela.CourseId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convMajorCourseRela.CourseId);
}
objvMajorCourseRelaEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMajorCourseRelaEN.dicFldComparisonOp.ContainsKey(convMajorCourseRela.CourseId) == false)
{
objvMajorCourseRelaEN.dicFldComparisonOp.Add(convMajorCourseRela.CourseId, strComparisonOp);
}
else
{
objvMajorCourseRelaEN.dicFldComparisonOp[convMajorCourseRela.CourseId] = strComparisonOp;
}
}
return objvMajorCourseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorCourseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMajorCourseRelaEN SetCourseCode(this clsvMajorCourseRelaEN objvMajorCourseRelaEN, string strCourseCode, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convMajorCourseRela.CourseCode);
}
objvMajorCourseRelaEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMajorCourseRelaEN.dicFldComparisonOp.ContainsKey(convMajorCourseRela.CourseCode) == false)
{
objvMajorCourseRelaEN.dicFldComparisonOp.Add(convMajorCourseRela.CourseCode, strComparisonOp);
}
else
{
objvMajorCourseRelaEN.dicFldComparisonOp[convMajorCourseRela.CourseCode] = strComparisonOp;
}
}
return objvMajorCourseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorCourseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMajorCourseRelaEN SetCourseDescription(this clsvMajorCourseRelaEN objvMajorCourseRelaEN, string strCourseDescription, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseDescription, 8000, convMajorCourseRela.CourseDescription);
}
objvMajorCourseRelaEN.CourseDescription = strCourseDescription; //课程描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMajorCourseRelaEN.dicFldComparisonOp.ContainsKey(convMajorCourseRela.CourseDescription) == false)
{
objvMajorCourseRelaEN.dicFldComparisonOp.Add(convMajorCourseRela.CourseDescription, strComparisonOp);
}
else
{
objvMajorCourseRelaEN.dicFldComparisonOp[convMajorCourseRela.CourseDescription] = strComparisonOp;
}
}
return objvMajorCourseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorCourseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMajorCourseRelaEN SetCourseName(this clsvMajorCourseRelaEN objvMajorCourseRelaEN, string strCourseName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseName, 100, convMajorCourseRela.CourseName);
}
objvMajorCourseRelaEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMajorCourseRelaEN.dicFldComparisonOp.ContainsKey(convMajorCourseRela.CourseName) == false)
{
objvMajorCourseRelaEN.dicFldComparisonOp.Add(convMajorCourseRela.CourseName, strComparisonOp);
}
else
{
objvMajorCourseRelaEN.dicFldComparisonOp[convMajorCourseRela.CourseName] = strComparisonOp;
}
}
return objvMajorCourseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorCourseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMajorCourseRelaEN SetCourseTypeID(this clsvMajorCourseRelaEN objvMajorCourseRelaEN, string strCourseTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseTypeID, convMajorCourseRela.CourseTypeID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCourseTypeID, 4, convMajorCourseRela.CourseTypeID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCourseTypeID, 4, convMajorCourseRela.CourseTypeID);
}
objvMajorCourseRelaEN.CourseTypeID = strCourseTypeID; //课程类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMajorCourseRelaEN.dicFldComparisonOp.ContainsKey(convMajorCourseRela.CourseTypeID) == false)
{
objvMajorCourseRelaEN.dicFldComparisonOp.Add(convMajorCourseRela.CourseTypeID, strComparisonOp);
}
else
{
objvMajorCourseRelaEN.dicFldComparisonOp[convMajorCourseRela.CourseTypeID] = strComparisonOp;
}
}
return objvMajorCourseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorCourseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMajorCourseRelaEN SetIsOpen(this clsvMajorCourseRelaEN objvMajorCourseRelaEN, bool bolIsOpen, string strComparisonOp="")
	{
objvMajorCourseRelaEN.IsOpen = bolIsOpen; //是否公开
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMajorCourseRelaEN.dicFldComparisonOp.ContainsKey(convMajorCourseRela.IsOpen) == false)
{
objvMajorCourseRelaEN.dicFldComparisonOp.Add(convMajorCourseRela.IsOpen, strComparisonOp);
}
else
{
objvMajorCourseRelaEN.dicFldComparisonOp[convMajorCourseRela.IsOpen] = strComparisonOp;
}
}
return objvMajorCourseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorCourseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMajorCourseRelaEN SetIdXzMajor(this clsvMajorCourseRelaEN objvMajorCourseRelaEN, string strIdXzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strIdXzMajor, convMajorCourseRela.IdXzMajor);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strIdXzMajor, 8, convMajorCourseRela.IdXzMajor);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strIdXzMajor, 8, convMajorCourseRela.IdXzMajor);
}
objvMajorCourseRelaEN.IdXzMajor = strIdXzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMajorCourseRelaEN.dicFldComparisonOp.ContainsKey(convMajorCourseRela.IdXzMajor) == false)
{
objvMajorCourseRelaEN.dicFldComparisonOp.Add(convMajorCourseRela.IdXzMajor, strComparisonOp);
}
else
{
objvMajorCourseRelaEN.dicFldComparisonOp[convMajorCourseRela.IdXzMajor] = strComparisonOp;
}
}
return objvMajorCourseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorCourseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMajorCourseRelaEN SetMajorID(this clsvMajorCourseRelaEN objvMajorCourseRelaEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorID, convMajorCourseRela.MajorID);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorID, 4, convMajorCourseRela.MajorID);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convMajorCourseRela.MajorID);
}
objvMajorCourseRelaEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMajorCourseRelaEN.dicFldComparisonOp.ContainsKey(convMajorCourseRela.MajorID) == false)
{
objvMajorCourseRelaEN.dicFldComparisonOp.Add(convMajorCourseRela.MajorID, strComparisonOp);
}
else
{
objvMajorCourseRelaEN.dicFldComparisonOp[convMajorCourseRela.MajorID] = strComparisonOp;
}
}
return objvMajorCourseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorCourseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMajorCourseRelaEN SetMajorName(this clsvMajorCourseRelaEN objvMajorCourseRelaEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorName, convMajorCourseRela.MajorName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMajorName, 100, convMajorCourseRela.MajorName);
}
objvMajorCourseRelaEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMajorCourseRelaEN.dicFldComparisonOp.ContainsKey(convMajorCourseRela.MajorName) == false)
{
objvMajorCourseRelaEN.dicFldComparisonOp.Add(convMajorCourseRela.MajorName, strComparisonOp);
}
else
{
objvMajorCourseRelaEN.dicFldComparisonOp[convMajorCourseRela.MajorName] = strComparisonOp;
}
}
return objvMajorCourseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorCourseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMajorCourseRelaEN SetUpdDate(this clsvMajorCourseRelaEN objvMajorCourseRelaEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convMajorCourseRela.UpdDate);
}
objvMajorCourseRelaEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMajorCourseRelaEN.dicFldComparisonOp.ContainsKey(convMajorCourseRela.UpdDate) == false)
{
objvMajorCourseRelaEN.dicFldComparisonOp.Add(convMajorCourseRela.UpdDate, strComparisonOp);
}
else
{
objvMajorCourseRelaEN.dicFldComparisonOp[convMajorCourseRela.UpdDate] = strComparisonOp;
}
}
return objvMajorCourseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorCourseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMajorCourseRelaEN SetUpdUserId(this clsvMajorCourseRelaEN objvMajorCourseRelaEN, string strUpdUserId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convMajorCourseRela.UpdUserId);
}
objvMajorCourseRelaEN.UpdUserId = strUpdUserId; //修改用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMajorCourseRelaEN.dicFldComparisonOp.ContainsKey(convMajorCourseRela.UpdUserId) == false)
{
objvMajorCourseRelaEN.dicFldComparisonOp.Add(convMajorCourseRela.UpdUserId, strComparisonOp);
}
else
{
objvMajorCourseRelaEN.dicFldComparisonOp[convMajorCourseRela.UpdUserId] = strComparisonOp;
}
}
return objvMajorCourseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorCourseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvMajorCourseRelaEN SetMemo(this clsvMajorCourseRelaEN objvMajorCourseRelaEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convMajorCourseRela.Memo);
}
objvMajorCourseRelaEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMajorCourseRelaEN.dicFldComparisonOp.ContainsKey(convMajorCourseRela.Memo) == false)
{
objvMajorCourseRelaEN.dicFldComparisonOp.Add(convMajorCourseRela.Memo, strComparisonOp);
}
else
{
objvMajorCourseRelaEN.dicFldComparisonOp[convMajorCourseRela.Memo] = strComparisonOp;
}
}
return objvMajorCourseRelaEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvMajorCourseRelaENS">源对象</param>
 /// <param name = "objvMajorCourseRelaENT">目标对象</param>
 public static void CopyTo(this clsvMajorCourseRelaEN objvMajorCourseRelaENS, clsvMajorCourseRelaEN objvMajorCourseRelaENT)
{
try
{
objvMajorCourseRelaENT.mId = objvMajorCourseRelaENS.mId; //mId
objvMajorCourseRelaENT.CourseId = objvMajorCourseRelaENS.CourseId; //课程Id
objvMajorCourseRelaENT.CourseCode = objvMajorCourseRelaENS.CourseCode; //课程代码
objvMajorCourseRelaENT.CourseDescription = objvMajorCourseRelaENS.CourseDescription; //课程描述
objvMajorCourseRelaENT.CourseName = objvMajorCourseRelaENS.CourseName; //课程名称
objvMajorCourseRelaENT.CourseTypeID = objvMajorCourseRelaENS.CourseTypeID; //课程类型ID
objvMajorCourseRelaENT.IsOpen = objvMajorCourseRelaENS.IsOpen; //是否公开
objvMajorCourseRelaENT.IdXzMajor = objvMajorCourseRelaENS.IdXzMajor; //专业流水号
objvMajorCourseRelaENT.MajorID = objvMajorCourseRelaENS.MajorID; //专业ID
objvMajorCourseRelaENT.MajorName = objvMajorCourseRelaENS.MajorName; //专业名称
objvMajorCourseRelaENT.UpdDate = objvMajorCourseRelaENS.UpdDate; //修改日期
objvMajorCourseRelaENT.UpdUserId = objvMajorCourseRelaENS.UpdUserId; //修改用户Id
objvMajorCourseRelaENT.Memo = objvMajorCourseRelaENS.Memo; //备注
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
 /// <param name = "objvMajorCourseRelaENS">源对象</param>
 /// <returns>目标对象=>clsvMajorCourseRelaEN:objvMajorCourseRelaENT</returns>
 public static clsvMajorCourseRelaEN CopyTo(this clsvMajorCourseRelaEN objvMajorCourseRelaENS)
{
try
{
 clsvMajorCourseRelaEN objvMajorCourseRelaENT = new clsvMajorCourseRelaEN()
{
mId = objvMajorCourseRelaENS.mId, //mId
CourseId = objvMajorCourseRelaENS.CourseId, //课程Id
CourseCode = objvMajorCourseRelaENS.CourseCode, //课程代码
CourseDescription = objvMajorCourseRelaENS.CourseDescription, //课程描述
CourseName = objvMajorCourseRelaENS.CourseName, //课程名称
CourseTypeID = objvMajorCourseRelaENS.CourseTypeID, //课程类型ID
IsOpen = objvMajorCourseRelaENS.IsOpen, //是否公开
IdXzMajor = objvMajorCourseRelaENS.IdXzMajor, //专业流水号
MajorID = objvMajorCourseRelaENS.MajorID, //专业ID
MajorName = objvMajorCourseRelaENS.MajorName, //专业名称
UpdDate = objvMajorCourseRelaENS.UpdDate, //修改日期
UpdUserId = objvMajorCourseRelaENS.UpdUserId, //修改用户Id
Memo = objvMajorCourseRelaENS.Memo, //备注
};
 return objvMajorCourseRelaENT;
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
public static void CheckProperty4Condition(this clsvMajorCourseRelaEN objvMajorCourseRelaEN)
{
 clsvMajorCourseRelaBL.vMajorCourseRelaDA.CheckProperty4Condition(objvMajorCourseRelaEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvMajorCourseRelaEN objvMajorCourseRelaCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvMajorCourseRelaCond.IsUpdated(convMajorCourseRela.mId) == true)
{
string strComparisonOpmId = objvMajorCourseRelaCond.dicFldComparisonOp[convMajorCourseRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convMajorCourseRela.mId, objvMajorCourseRelaCond.mId, strComparisonOpmId);
}
if (objvMajorCourseRelaCond.IsUpdated(convMajorCourseRela.CourseId) == true)
{
string strComparisonOpCourseId = objvMajorCourseRelaCond.dicFldComparisonOp[convMajorCourseRela.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMajorCourseRela.CourseId, objvMajorCourseRelaCond.CourseId, strComparisonOpCourseId);
}
if (objvMajorCourseRelaCond.IsUpdated(convMajorCourseRela.CourseCode) == true)
{
string strComparisonOpCourseCode = objvMajorCourseRelaCond.dicFldComparisonOp[convMajorCourseRela.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMajorCourseRela.CourseCode, objvMajorCourseRelaCond.CourseCode, strComparisonOpCourseCode);
}
if (objvMajorCourseRelaCond.IsUpdated(convMajorCourseRela.CourseDescription) == true)
{
string strComparisonOpCourseDescription = objvMajorCourseRelaCond.dicFldComparisonOp[convMajorCourseRela.CourseDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMajorCourseRela.CourseDescription, objvMajorCourseRelaCond.CourseDescription, strComparisonOpCourseDescription);
}
if (objvMajorCourseRelaCond.IsUpdated(convMajorCourseRela.CourseName) == true)
{
string strComparisonOpCourseName = objvMajorCourseRelaCond.dicFldComparisonOp[convMajorCourseRela.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMajorCourseRela.CourseName, objvMajorCourseRelaCond.CourseName, strComparisonOpCourseName);
}
if (objvMajorCourseRelaCond.IsUpdated(convMajorCourseRela.CourseTypeID) == true)
{
string strComparisonOpCourseTypeID = objvMajorCourseRelaCond.dicFldComparisonOp[convMajorCourseRela.CourseTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMajorCourseRela.CourseTypeID, objvMajorCourseRelaCond.CourseTypeID, strComparisonOpCourseTypeID);
}
if (objvMajorCourseRelaCond.IsUpdated(convMajorCourseRela.IsOpen) == true)
{
if (objvMajorCourseRelaCond.IsOpen == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMajorCourseRela.IsOpen);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMajorCourseRela.IsOpen);
}
}
if (objvMajorCourseRelaCond.IsUpdated(convMajorCourseRela.IdXzMajor) == true)
{
string strComparisonOpIdXzMajor = objvMajorCourseRelaCond.dicFldComparisonOp[convMajorCourseRela.IdXzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMajorCourseRela.IdXzMajor, objvMajorCourseRelaCond.IdXzMajor, strComparisonOpIdXzMajor);
}
if (objvMajorCourseRelaCond.IsUpdated(convMajorCourseRela.MajorID) == true)
{
string strComparisonOpMajorID = objvMajorCourseRelaCond.dicFldComparisonOp[convMajorCourseRela.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMajorCourseRela.MajorID, objvMajorCourseRelaCond.MajorID, strComparisonOpMajorID);
}
if (objvMajorCourseRelaCond.IsUpdated(convMajorCourseRela.MajorName) == true)
{
string strComparisonOpMajorName = objvMajorCourseRelaCond.dicFldComparisonOp[convMajorCourseRela.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMajorCourseRela.MajorName, objvMajorCourseRelaCond.MajorName, strComparisonOpMajorName);
}
if (objvMajorCourseRelaCond.IsUpdated(convMajorCourseRela.UpdDate) == true)
{
string strComparisonOpUpdDate = objvMajorCourseRelaCond.dicFldComparisonOp[convMajorCourseRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMajorCourseRela.UpdDate, objvMajorCourseRelaCond.UpdDate, strComparisonOpUpdDate);
}
if (objvMajorCourseRelaCond.IsUpdated(convMajorCourseRela.UpdUserId) == true)
{
string strComparisonOpUpdUserId = objvMajorCourseRelaCond.dicFldComparisonOp[convMajorCourseRela.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMajorCourseRela.UpdUserId, objvMajorCourseRelaCond.UpdUserId, strComparisonOpUpdUserId);
}
if (objvMajorCourseRelaCond.IsUpdated(convMajorCourseRela.Memo) == true)
{
string strComparisonOpMemo = objvMajorCourseRelaCond.dicFldComparisonOp[convMajorCourseRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMajorCourseRela.Memo, objvMajorCourseRelaCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vMajorCourseRela
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v专业课程关系(vMajorCourseRela)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvMajorCourseRelaBL
{
public static RelatedActions_vMajorCourseRela relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvMajorCourseRelaDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvMajorCourseRelaDA vMajorCourseRelaDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvMajorCourseRelaDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvMajorCourseRelaBL()
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
if (string.IsNullOrEmpty(clsvMajorCourseRelaEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvMajorCourseRelaEN._ConnectString);
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
public static DataTable GetDataTable_vMajorCourseRela(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vMajorCourseRelaDA.GetDataTable_vMajorCourseRela(strWhereCond);
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
objDT = vMajorCourseRelaDA.GetDataTable(strWhereCond);
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
objDT = vMajorCourseRelaDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vMajorCourseRelaDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vMajorCourseRelaDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vMajorCourseRelaDA.GetDataTable_Top(objTopPara);
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
objDT = vMajorCourseRelaDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vMajorCourseRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vMajorCourseRelaDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvMajorCourseRelaEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvMajorCourseRelaEN> arrObjLst = new List<clsvMajorCourseRelaEN>(); 
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
	clsvMajorCourseRelaEN objvMajorCourseRelaEN = new clsvMajorCourseRelaEN();
try
{
objvMajorCourseRelaEN.mId = Int32.Parse(objRow[convMajorCourseRela.mId].ToString().Trim()); //mId
objvMajorCourseRelaEN.CourseId = objRow[convMajorCourseRela.CourseId] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseId].ToString().Trim(); //课程Id
objvMajorCourseRelaEN.CourseCode = objRow[convMajorCourseRela.CourseCode] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseCode].ToString().Trim(); //课程代码
objvMajorCourseRelaEN.CourseDescription = objRow[convMajorCourseRela.CourseDescription] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseDescription].ToString().Trim(); //课程描述
objvMajorCourseRelaEN.CourseName = objRow[convMajorCourseRela.CourseName] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseName].ToString().Trim(); //课程名称
objvMajorCourseRelaEN.CourseTypeID = objRow[convMajorCourseRela.CourseTypeID].ToString().Trim(); //课程类型ID
objvMajorCourseRelaEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convMajorCourseRela.IsOpen].ToString().Trim()); //是否公开
objvMajorCourseRelaEN.IdXzMajor = objRow[convMajorCourseRela.IdXzMajor].ToString().Trim(); //专业流水号
objvMajorCourseRelaEN.MajorID = objRow[convMajorCourseRela.MajorID].ToString().Trim(); //专业ID
objvMajorCourseRelaEN.MajorName = objRow[convMajorCourseRela.MajorName].ToString().Trim(); //专业名称
objvMajorCourseRelaEN.UpdDate = objRow[convMajorCourseRela.UpdDate] == DBNull.Value ? null : objRow[convMajorCourseRela.UpdDate].ToString().Trim(); //修改日期
objvMajorCourseRelaEN.UpdUserId = objRow[convMajorCourseRela.UpdUserId] == DBNull.Value ? null : objRow[convMajorCourseRela.UpdUserId].ToString().Trim(); //修改用户Id
objvMajorCourseRelaEN.Memo = objRow[convMajorCourseRela.Memo] == DBNull.Value ? null : objRow[convMajorCourseRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMajorCourseRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMajorCourseRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvMajorCourseRelaEN> GetObjLstByMIdLstCache(List<long> arrMIdLst)
{
string strKey = string.Format("{0}", clsvMajorCourseRelaEN._CurrTabName);
List<clsvMajorCourseRelaEN> arrvMajorCourseRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvMajorCourseRelaEN> arrvMajorCourseRelaObjLst_Sel =
arrvMajorCourseRelaObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvMajorCourseRelaObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMajorCourseRelaEN> GetObjLst(string strWhereCond)
{
List<clsvMajorCourseRelaEN> arrObjLst = new List<clsvMajorCourseRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMajorCourseRelaEN objvMajorCourseRelaEN = new clsvMajorCourseRelaEN();
try
{
objvMajorCourseRelaEN.mId = Int32.Parse(objRow[convMajorCourseRela.mId].ToString().Trim()); //mId
objvMajorCourseRelaEN.CourseId = objRow[convMajorCourseRela.CourseId] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseId].ToString().Trim(); //课程Id
objvMajorCourseRelaEN.CourseCode = objRow[convMajorCourseRela.CourseCode] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseCode].ToString().Trim(); //课程代码
objvMajorCourseRelaEN.CourseDescription = objRow[convMajorCourseRela.CourseDescription] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseDescription].ToString().Trim(); //课程描述
objvMajorCourseRelaEN.CourseName = objRow[convMajorCourseRela.CourseName] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseName].ToString().Trim(); //课程名称
objvMajorCourseRelaEN.CourseTypeID = objRow[convMajorCourseRela.CourseTypeID].ToString().Trim(); //课程类型ID
objvMajorCourseRelaEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convMajorCourseRela.IsOpen].ToString().Trim()); //是否公开
objvMajorCourseRelaEN.IdXzMajor = objRow[convMajorCourseRela.IdXzMajor].ToString().Trim(); //专业流水号
objvMajorCourseRelaEN.MajorID = objRow[convMajorCourseRela.MajorID].ToString().Trim(); //专业ID
objvMajorCourseRelaEN.MajorName = objRow[convMajorCourseRela.MajorName].ToString().Trim(); //专业名称
objvMajorCourseRelaEN.UpdDate = objRow[convMajorCourseRela.UpdDate] == DBNull.Value ? null : objRow[convMajorCourseRela.UpdDate].ToString().Trim(); //修改日期
objvMajorCourseRelaEN.UpdUserId = objRow[convMajorCourseRela.UpdUserId] == DBNull.Value ? null : objRow[convMajorCourseRela.UpdUserId].ToString().Trim(); //修改用户Id
objvMajorCourseRelaEN.Memo = objRow[convMajorCourseRela.Memo] == DBNull.Value ? null : objRow[convMajorCourseRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMajorCourseRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMajorCourseRelaEN);
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
public static List<clsvMajorCourseRelaEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvMajorCourseRelaEN> arrObjLst = new List<clsvMajorCourseRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMajorCourseRelaEN objvMajorCourseRelaEN = new clsvMajorCourseRelaEN();
try
{
objvMajorCourseRelaEN.mId = Int32.Parse(objRow[convMajorCourseRela.mId].ToString().Trim()); //mId
objvMajorCourseRelaEN.CourseId = objRow[convMajorCourseRela.CourseId] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseId].ToString().Trim(); //课程Id
objvMajorCourseRelaEN.CourseCode = objRow[convMajorCourseRela.CourseCode] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseCode].ToString().Trim(); //课程代码
objvMajorCourseRelaEN.CourseDescription = objRow[convMajorCourseRela.CourseDescription] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseDescription].ToString().Trim(); //课程描述
objvMajorCourseRelaEN.CourseName = objRow[convMajorCourseRela.CourseName] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseName].ToString().Trim(); //课程名称
objvMajorCourseRelaEN.CourseTypeID = objRow[convMajorCourseRela.CourseTypeID].ToString().Trim(); //课程类型ID
objvMajorCourseRelaEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convMajorCourseRela.IsOpen].ToString().Trim()); //是否公开
objvMajorCourseRelaEN.IdXzMajor = objRow[convMajorCourseRela.IdXzMajor].ToString().Trim(); //专业流水号
objvMajorCourseRelaEN.MajorID = objRow[convMajorCourseRela.MajorID].ToString().Trim(); //专业ID
objvMajorCourseRelaEN.MajorName = objRow[convMajorCourseRela.MajorName].ToString().Trim(); //专业名称
objvMajorCourseRelaEN.UpdDate = objRow[convMajorCourseRela.UpdDate] == DBNull.Value ? null : objRow[convMajorCourseRela.UpdDate].ToString().Trim(); //修改日期
objvMajorCourseRelaEN.UpdUserId = objRow[convMajorCourseRela.UpdUserId] == DBNull.Value ? null : objRow[convMajorCourseRela.UpdUserId].ToString().Trim(); //修改用户Id
objvMajorCourseRelaEN.Memo = objRow[convMajorCourseRela.Memo] == DBNull.Value ? null : objRow[convMajorCourseRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMajorCourseRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMajorCourseRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvMajorCourseRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvMajorCourseRelaEN> GetSubObjLstCache(clsvMajorCourseRelaEN objvMajorCourseRelaCond)
{
List<clsvMajorCourseRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvMajorCourseRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convMajorCourseRela.AttributeName)
{
if (objvMajorCourseRelaCond.IsUpdated(strFldName) == false) continue;
if (objvMajorCourseRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMajorCourseRelaCond[strFldName].ToString());
}
else
{
if (objvMajorCourseRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvMajorCourseRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMajorCourseRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvMajorCourseRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvMajorCourseRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvMajorCourseRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvMajorCourseRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvMajorCourseRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvMajorCourseRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvMajorCourseRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvMajorCourseRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvMajorCourseRelaCond[strFldName]));
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
public static List<clsvMajorCourseRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvMajorCourseRelaEN> arrObjLst = new List<clsvMajorCourseRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMajorCourseRelaEN objvMajorCourseRelaEN = new clsvMajorCourseRelaEN();
try
{
objvMajorCourseRelaEN.mId = Int32.Parse(objRow[convMajorCourseRela.mId].ToString().Trim()); //mId
objvMajorCourseRelaEN.CourseId = objRow[convMajorCourseRela.CourseId] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseId].ToString().Trim(); //课程Id
objvMajorCourseRelaEN.CourseCode = objRow[convMajorCourseRela.CourseCode] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseCode].ToString().Trim(); //课程代码
objvMajorCourseRelaEN.CourseDescription = objRow[convMajorCourseRela.CourseDescription] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseDescription].ToString().Trim(); //课程描述
objvMajorCourseRelaEN.CourseName = objRow[convMajorCourseRela.CourseName] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseName].ToString().Trim(); //课程名称
objvMajorCourseRelaEN.CourseTypeID = objRow[convMajorCourseRela.CourseTypeID].ToString().Trim(); //课程类型ID
objvMajorCourseRelaEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convMajorCourseRela.IsOpen].ToString().Trim()); //是否公开
objvMajorCourseRelaEN.IdXzMajor = objRow[convMajorCourseRela.IdXzMajor].ToString().Trim(); //专业流水号
objvMajorCourseRelaEN.MajorID = objRow[convMajorCourseRela.MajorID].ToString().Trim(); //专业ID
objvMajorCourseRelaEN.MajorName = objRow[convMajorCourseRela.MajorName].ToString().Trim(); //专业名称
objvMajorCourseRelaEN.UpdDate = objRow[convMajorCourseRela.UpdDate] == DBNull.Value ? null : objRow[convMajorCourseRela.UpdDate].ToString().Trim(); //修改日期
objvMajorCourseRelaEN.UpdUserId = objRow[convMajorCourseRela.UpdUserId] == DBNull.Value ? null : objRow[convMajorCourseRela.UpdUserId].ToString().Trim(); //修改用户Id
objvMajorCourseRelaEN.Memo = objRow[convMajorCourseRela.Memo] == DBNull.Value ? null : objRow[convMajorCourseRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMajorCourseRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMajorCourseRelaEN);
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
public static List<clsvMajorCourseRelaEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvMajorCourseRelaEN> arrObjLst = new List<clsvMajorCourseRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMajorCourseRelaEN objvMajorCourseRelaEN = new clsvMajorCourseRelaEN();
try
{
objvMajorCourseRelaEN.mId = Int32.Parse(objRow[convMajorCourseRela.mId].ToString().Trim()); //mId
objvMajorCourseRelaEN.CourseId = objRow[convMajorCourseRela.CourseId] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseId].ToString().Trim(); //课程Id
objvMajorCourseRelaEN.CourseCode = objRow[convMajorCourseRela.CourseCode] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseCode].ToString().Trim(); //课程代码
objvMajorCourseRelaEN.CourseDescription = objRow[convMajorCourseRela.CourseDescription] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseDescription].ToString().Trim(); //课程描述
objvMajorCourseRelaEN.CourseName = objRow[convMajorCourseRela.CourseName] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseName].ToString().Trim(); //课程名称
objvMajorCourseRelaEN.CourseTypeID = objRow[convMajorCourseRela.CourseTypeID].ToString().Trim(); //课程类型ID
objvMajorCourseRelaEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convMajorCourseRela.IsOpen].ToString().Trim()); //是否公开
objvMajorCourseRelaEN.IdXzMajor = objRow[convMajorCourseRela.IdXzMajor].ToString().Trim(); //专业流水号
objvMajorCourseRelaEN.MajorID = objRow[convMajorCourseRela.MajorID].ToString().Trim(); //专业ID
objvMajorCourseRelaEN.MajorName = objRow[convMajorCourseRela.MajorName].ToString().Trim(); //专业名称
objvMajorCourseRelaEN.UpdDate = objRow[convMajorCourseRela.UpdDate] == DBNull.Value ? null : objRow[convMajorCourseRela.UpdDate].ToString().Trim(); //修改日期
objvMajorCourseRelaEN.UpdUserId = objRow[convMajorCourseRela.UpdUserId] == DBNull.Value ? null : objRow[convMajorCourseRela.UpdUserId].ToString().Trim(); //修改用户Id
objvMajorCourseRelaEN.Memo = objRow[convMajorCourseRela.Memo] == DBNull.Value ? null : objRow[convMajorCourseRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMajorCourseRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMajorCourseRelaEN);
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
List<clsvMajorCourseRelaEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvMajorCourseRelaEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMajorCourseRelaEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvMajorCourseRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvMajorCourseRelaEN> arrObjLst = new List<clsvMajorCourseRelaEN>(); 
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
	clsvMajorCourseRelaEN objvMajorCourseRelaEN = new clsvMajorCourseRelaEN();
try
{
objvMajorCourseRelaEN.mId = Int32.Parse(objRow[convMajorCourseRela.mId].ToString().Trim()); //mId
objvMajorCourseRelaEN.CourseId = objRow[convMajorCourseRela.CourseId] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseId].ToString().Trim(); //课程Id
objvMajorCourseRelaEN.CourseCode = objRow[convMajorCourseRela.CourseCode] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseCode].ToString().Trim(); //课程代码
objvMajorCourseRelaEN.CourseDescription = objRow[convMajorCourseRela.CourseDescription] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseDescription].ToString().Trim(); //课程描述
objvMajorCourseRelaEN.CourseName = objRow[convMajorCourseRela.CourseName] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseName].ToString().Trim(); //课程名称
objvMajorCourseRelaEN.CourseTypeID = objRow[convMajorCourseRela.CourseTypeID].ToString().Trim(); //课程类型ID
objvMajorCourseRelaEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convMajorCourseRela.IsOpen].ToString().Trim()); //是否公开
objvMajorCourseRelaEN.IdXzMajor = objRow[convMajorCourseRela.IdXzMajor].ToString().Trim(); //专业流水号
objvMajorCourseRelaEN.MajorID = objRow[convMajorCourseRela.MajorID].ToString().Trim(); //专业ID
objvMajorCourseRelaEN.MajorName = objRow[convMajorCourseRela.MajorName].ToString().Trim(); //专业名称
objvMajorCourseRelaEN.UpdDate = objRow[convMajorCourseRela.UpdDate] == DBNull.Value ? null : objRow[convMajorCourseRela.UpdDate].ToString().Trim(); //修改日期
objvMajorCourseRelaEN.UpdUserId = objRow[convMajorCourseRela.UpdUserId] == DBNull.Value ? null : objRow[convMajorCourseRela.UpdUserId].ToString().Trim(); //修改用户Id
objvMajorCourseRelaEN.Memo = objRow[convMajorCourseRela.Memo] == DBNull.Value ? null : objRow[convMajorCourseRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMajorCourseRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMajorCourseRelaEN);
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
public static List<clsvMajorCourseRelaEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvMajorCourseRelaEN> arrObjLst = new List<clsvMajorCourseRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMajorCourseRelaEN objvMajorCourseRelaEN = new clsvMajorCourseRelaEN();
try
{
objvMajorCourseRelaEN.mId = Int32.Parse(objRow[convMajorCourseRela.mId].ToString().Trim()); //mId
objvMajorCourseRelaEN.CourseId = objRow[convMajorCourseRela.CourseId] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseId].ToString().Trim(); //课程Id
objvMajorCourseRelaEN.CourseCode = objRow[convMajorCourseRela.CourseCode] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseCode].ToString().Trim(); //课程代码
objvMajorCourseRelaEN.CourseDescription = objRow[convMajorCourseRela.CourseDescription] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseDescription].ToString().Trim(); //课程描述
objvMajorCourseRelaEN.CourseName = objRow[convMajorCourseRela.CourseName] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseName].ToString().Trim(); //课程名称
objvMajorCourseRelaEN.CourseTypeID = objRow[convMajorCourseRela.CourseTypeID].ToString().Trim(); //课程类型ID
objvMajorCourseRelaEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convMajorCourseRela.IsOpen].ToString().Trim()); //是否公开
objvMajorCourseRelaEN.IdXzMajor = objRow[convMajorCourseRela.IdXzMajor].ToString().Trim(); //专业流水号
objvMajorCourseRelaEN.MajorID = objRow[convMajorCourseRela.MajorID].ToString().Trim(); //专业ID
objvMajorCourseRelaEN.MajorName = objRow[convMajorCourseRela.MajorName].ToString().Trim(); //专业名称
objvMajorCourseRelaEN.UpdDate = objRow[convMajorCourseRela.UpdDate] == DBNull.Value ? null : objRow[convMajorCourseRela.UpdDate].ToString().Trim(); //修改日期
objvMajorCourseRelaEN.UpdUserId = objRow[convMajorCourseRela.UpdUserId] == DBNull.Value ? null : objRow[convMajorCourseRela.UpdUserId].ToString().Trim(); //修改用户Id
objvMajorCourseRelaEN.Memo = objRow[convMajorCourseRela.Memo] == DBNull.Value ? null : objRow[convMajorCourseRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMajorCourseRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMajorCourseRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvMajorCourseRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvMajorCourseRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvMajorCourseRelaEN> arrObjLst = new List<clsvMajorCourseRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMajorCourseRelaEN objvMajorCourseRelaEN = new clsvMajorCourseRelaEN();
try
{
objvMajorCourseRelaEN.mId = Int32.Parse(objRow[convMajorCourseRela.mId].ToString().Trim()); //mId
objvMajorCourseRelaEN.CourseId = objRow[convMajorCourseRela.CourseId] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseId].ToString().Trim(); //课程Id
objvMajorCourseRelaEN.CourseCode = objRow[convMajorCourseRela.CourseCode] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseCode].ToString().Trim(); //课程代码
objvMajorCourseRelaEN.CourseDescription = objRow[convMajorCourseRela.CourseDescription] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseDescription].ToString().Trim(); //课程描述
objvMajorCourseRelaEN.CourseName = objRow[convMajorCourseRela.CourseName] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseName].ToString().Trim(); //课程名称
objvMajorCourseRelaEN.CourseTypeID = objRow[convMajorCourseRela.CourseTypeID].ToString().Trim(); //课程类型ID
objvMajorCourseRelaEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convMajorCourseRela.IsOpen].ToString().Trim()); //是否公开
objvMajorCourseRelaEN.IdXzMajor = objRow[convMajorCourseRela.IdXzMajor].ToString().Trim(); //专业流水号
objvMajorCourseRelaEN.MajorID = objRow[convMajorCourseRela.MajorID].ToString().Trim(); //专业ID
objvMajorCourseRelaEN.MajorName = objRow[convMajorCourseRela.MajorName].ToString().Trim(); //专业名称
objvMajorCourseRelaEN.UpdDate = objRow[convMajorCourseRela.UpdDate] == DBNull.Value ? null : objRow[convMajorCourseRela.UpdDate].ToString().Trim(); //修改日期
objvMajorCourseRelaEN.UpdUserId = objRow[convMajorCourseRela.UpdUserId] == DBNull.Value ? null : objRow[convMajorCourseRela.UpdUserId].ToString().Trim(); //修改用户Id
objvMajorCourseRelaEN.Memo = objRow[convMajorCourseRela.Memo] == DBNull.Value ? null : objRow[convMajorCourseRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMajorCourseRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMajorCourseRelaEN);
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
public static List<clsvMajorCourseRelaEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvMajorCourseRelaEN> arrObjLst = new List<clsvMajorCourseRelaEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMajorCourseRelaEN objvMajorCourseRelaEN = new clsvMajorCourseRelaEN();
try
{
objvMajorCourseRelaEN.mId = Int32.Parse(objRow[convMajorCourseRela.mId].ToString().Trim()); //mId
objvMajorCourseRelaEN.CourseId = objRow[convMajorCourseRela.CourseId] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseId].ToString().Trim(); //课程Id
objvMajorCourseRelaEN.CourseCode = objRow[convMajorCourseRela.CourseCode] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseCode].ToString().Trim(); //课程代码
objvMajorCourseRelaEN.CourseDescription = objRow[convMajorCourseRela.CourseDescription] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseDescription].ToString().Trim(); //课程描述
objvMajorCourseRelaEN.CourseName = objRow[convMajorCourseRela.CourseName] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseName].ToString().Trim(); //课程名称
objvMajorCourseRelaEN.CourseTypeID = objRow[convMajorCourseRela.CourseTypeID].ToString().Trim(); //课程类型ID
objvMajorCourseRelaEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convMajorCourseRela.IsOpen].ToString().Trim()); //是否公开
objvMajorCourseRelaEN.IdXzMajor = objRow[convMajorCourseRela.IdXzMajor].ToString().Trim(); //专业流水号
objvMajorCourseRelaEN.MajorID = objRow[convMajorCourseRela.MajorID].ToString().Trim(); //专业ID
objvMajorCourseRelaEN.MajorName = objRow[convMajorCourseRela.MajorName].ToString().Trim(); //专业名称
objvMajorCourseRelaEN.UpdDate = objRow[convMajorCourseRela.UpdDate] == DBNull.Value ? null : objRow[convMajorCourseRela.UpdDate].ToString().Trim(); //修改日期
objvMajorCourseRelaEN.UpdUserId = objRow[convMajorCourseRela.UpdUserId] == DBNull.Value ? null : objRow[convMajorCourseRela.UpdUserId].ToString().Trim(); //修改用户Id
objvMajorCourseRelaEN.Memo = objRow[convMajorCourseRela.Memo] == DBNull.Value ? null : objRow[convMajorCourseRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMajorCourseRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMajorCourseRelaEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMajorCourseRelaEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvMajorCourseRelaEN> arrObjLst = new List<clsvMajorCourseRelaEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvMajorCourseRelaEN objvMajorCourseRelaEN = new clsvMajorCourseRelaEN();
try
{
objvMajorCourseRelaEN.mId = Int32.Parse(objRow[convMajorCourseRela.mId].ToString().Trim()); //mId
objvMajorCourseRelaEN.CourseId = objRow[convMajorCourseRela.CourseId] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseId].ToString().Trim(); //课程Id
objvMajorCourseRelaEN.CourseCode = objRow[convMajorCourseRela.CourseCode] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseCode].ToString().Trim(); //课程代码
objvMajorCourseRelaEN.CourseDescription = objRow[convMajorCourseRela.CourseDescription] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseDescription].ToString().Trim(); //课程描述
objvMajorCourseRelaEN.CourseName = objRow[convMajorCourseRela.CourseName] == DBNull.Value ? null : objRow[convMajorCourseRela.CourseName].ToString().Trim(); //课程名称
objvMajorCourseRelaEN.CourseTypeID = objRow[convMajorCourseRela.CourseTypeID].ToString().Trim(); //课程类型ID
objvMajorCourseRelaEN.IsOpen = clsEntityBase2.TransNullToBool_S(objRow[convMajorCourseRela.IsOpen].ToString().Trim()); //是否公开
objvMajorCourseRelaEN.IdXzMajor = objRow[convMajorCourseRela.IdXzMajor].ToString().Trim(); //专业流水号
objvMajorCourseRelaEN.MajorID = objRow[convMajorCourseRela.MajorID].ToString().Trim(); //专业ID
objvMajorCourseRelaEN.MajorName = objRow[convMajorCourseRela.MajorName].ToString().Trim(); //专业名称
objvMajorCourseRelaEN.UpdDate = objRow[convMajorCourseRela.UpdDate] == DBNull.Value ? null : objRow[convMajorCourseRela.UpdDate].ToString().Trim(); //修改日期
objvMajorCourseRelaEN.UpdUserId = objRow[convMajorCourseRela.UpdUserId] == DBNull.Value ? null : objRow[convMajorCourseRela.UpdUserId].ToString().Trim(); //修改用户Id
objvMajorCourseRelaEN.Memo = objRow[convMajorCourseRela.Memo] == DBNull.Value ? null : objRow[convMajorCourseRela.Memo].ToString().Trim(); //备注
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvMajorCourseRelaEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvMajorCourseRelaEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvMajorCourseRelaEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvMajorCourseRela(ref clsvMajorCourseRelaEN objvMajorCourseRelaEN)
{
bool bolResult = vMajorCourseRelaDA.GetvMajorCourseRela(ref objvMajorCourseRelaEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMajorCourseRelaEN GetObjBymId(long lngmId)
{
clsvMajorCourseRelaEN objvMajorCourseRelaEN = vMajorCourseRelaDA.GetObjBymId(lngmId);
return objvMajorCourseRelaEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvMajorCourseRelaEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvMajorCourseRelaEN objvMajorCourseRelaEN = vMajorCourseRelaDA.GetFirstObj(strWhereCond);
 return objvMajorCourseRelaEN;
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
public static clsvMajorCourseRelaEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvMajorCourseRelaEN objvMajorCourseRelaEN = vMajorCourseRelaDA.GetObjByDataRow(objRow);
 return objvMajorCourseRelaEN;
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
public static clsvMajorCourseRelaEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvMajorCourseRelaEN objvMajorCourseRelaEN = vMajorCourseRelaDA.GetObjByDataRow(objRow);
 return objvMajorCourseRelaEN;
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
 /// <param name = "lstvMajorCourseRelaObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvMajorCourseRelaEN GetObjBymIdFromList(long lngmId, List<clsvMajorCourseRelaEN> lstvMajorCourseRelaObjLst)
{
foreach (clsvMajorCourseRelaEN objvMajorCourseRelaEN in lstvMajorCourseRelaObjLst)
{
if (objvMajorCourseRelaEN.mId == lngmId)
{
return objvMajorCourseRelaEN;
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
 lngmId = new clsvMajorCourseRelaDA().GetFirstID(strWhereCond);
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
 arrList = vMajorCourseRelaDA.GetID(strWhereCond);
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
bool bolIsExist = vMajorCourseRelaDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vMajorCourseRelaDA.IsExist(lngmId);
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
 bolIsExist = clsvMajorCourseRelaDA.IsExistTable();
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
 bolIsExist = vMajorCourseRelaDA.IsExistTable(strTabName);
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
 /// <param name = "objvMajorCourseRelaENS">源对象</param>
 /// <param name = "objvMajorCourseRelaENT">目标对象</param>
 public static void CopyTo(clsvMajorCourseRelaEN objvMajorCourseRelaENS, clsvMajorCourseRelaEN objvMajorCourseRelaENT)
{
try
{
objvMajorCourseRelaENT.mId = objvMajorCourseRelaENS.mId; //mId
objvMajorCourseRelaENT.CourseId = objvMajorCourseRelaENS.CourseId; //课程Id
objvMajorCourseRelaENT.CourseCode = objvMajorCourseRelaENS.CourseCode; //课程代码
objvMajorCourseRelaENT.CourseDescription = objvMajorCourseRelaENS.CourseDescription; //课程描述
objvMajorCourseRelaENT.CourseName = objvMajorCourseRelaENS.CourseName; //课程名称
objvMajorCourseRelaENT.CourseTypeID = objvMajorCourseRelaENS.CourseTypeID; //课程类型ID
objvMajorCourseRelaENT.IsOpen = objvMajorCourseRelaENS.IsOpen; //是否公开
objvMajorCourseRelaENT.IdXzMajor = objvMajorCourseRelaENS.IdXzMajor; //专业流水号
objvMajorCourseRelaENT.MajorID = objvMajorCourseRelaENS.MajorID; //专业ID
objvMajorCourseRelaENT.MajorName = objvMajorCourseRelaENS.MajorName; //专业名称
objvMajorCourseRelaENT.UpdDate = objvMajorCourseRelaENS.UpdDate; //修改日期
objvMajorCourseRelaENT.UpdUserId = objvMajorCourseRelaENS.UpdUserId; //修改用户Id
objvMajorCourseRelaENT.Memo = objvMajorCourseRelaENS.Memo; //备注
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
 /// <param name = "objvMajorCourseRelaEN">源简化对象</param>
 public static void SetUpdFlag(clsvMajorCourseRelaEN objvMajorCourseRelaEN)
{
try
{
objvMajorCourseRelaEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvMajorCourseRelaEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convMajorCourseRela.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMajorCourseRelaEN.mId = objvMajorCourseRelaEN.mId; //mId
}
if (arrFldSet.Contains(convMajorCourseRela.CourseId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMajorCourseRelaEN.CourseId = objvMajorCourseRelaEN.CourseId == "[null]" ? null :  objvMajorCourseRelaEN.CourseId; //课程Id
}
if (arrFldSet.Contains(convMajorCourseRela.CourseCode, new clsStrCompareIgnoreCase())  ==  true)
{
objvMajorCourseRelaEN.CourseCode = objvMajorCourseRelaEN.CourseCode == "[null]" ? null :  objvMajorCourseRelaEN.CourseCode; //课程代码
}
if (arrFldSet.Contains(convMajorCourseRela.CourseDescription, new clsStrCompareIgnoreCase())  ==  true)
{
objvMajorCourseRelaEN.CourseDescription = objvMajorCourseRelaEN.CourseDescription == "[null]" ? null :  objvMajorCourseRelaEN.CourseDescription; //课程描述
}
if (arrFldSet.Contains(convMajorCourseRela.CourseName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMajorCourseRelaEN.CourseName = objvMajorCourseRelaEN.CourseName == "[null]" ? null :  objvMajorCourseRelaEN.CourseName; //课程名称
}
if (arrFldSet.Contains(convMajorCourseRela.CourseTypeID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMajorCourseRelaEN.CourseTypeID = objvMajorCourseRelaEN.CourseTypeID; //课程类型ID
}
if (arrFldSet.Contains(convMajorCourseRela.IsOpen, new clsStrCompareIgnoreCase())  ==  true)
{
objvMajorCourseRelaEN.IsOpen = objvMajorCourseRelaEN.IsOpen; //是否公开
}
if (arrFldSet.Contains(convMajorCourseRela.IdXzMajor, new clsStrCompareIgnoreCase())  ==  true)
{
objvMajorCourseRelaEN.IdXzMajor = objvMajorCourseRelaEN.IdXzMajor; //专业流水号
}
if (arrFldSet.Contains(convMajorCourseRela.MajorID, new clsStrCompareIgnoreCase())  ==  true)
{
objvMajorCourseRelaEN.MajorID = objvMajorCourseRelaEN.MajorID; //专业ID
}
if (arrFldSet.Contains(convMajorCourseRela.MajorName, new clsStrCompareIgnoreCase())  ==  true)
{
objvMajorCourseRelaEN.MajorName = objvMajorCourseRelaEN.MajorName; //专业名称
}
if (arrFldSet.Contains(convMajorCourseRela.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvMajorCourseRelaEN.UpdDate = objvMajorCourseRelaEN.UpdDate == "[null]" ? null :  objvMajorCourseRelaEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convMajorCourseRela.UpdUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvMajorCourseRelaEN.UpdUserId = objvMajorCourseRelaEN.UpdUserId == "[null]" ? null :  objvMajorCourseRelaEN.UpdUserId; //修改用户Id
}
if (arrFldSet.Contains(convMajorCourseRela.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvMajorCourseRelaEN.Memo = objvMajorCourseRelaEN.Memo == "[null]" ? null :  objvMajorCourseRelaEN.Memo; //备注
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
 /// <param name = "objvMajorCourseRelaEN">源简化对象</param>
 public static void AccessFldValueNull(clsvMajorCourseRelaEN objvMajorCourseRelaEN)
{
try
{
if (objvMajorCourseRelaEN.CourseId == "[null]") objvMajorCourseRelaEN.CourseId = null; //课程Id
if (objvMajorCourseRelaEN.CourseCode == "[null]") objvMajorCourseRelaEN.CourseCode = null; //课程代码
if (objvMajorCourseRelaEN.CourseDescription == "[null]") objvMajorCourseRelaEN.CourseDescription = null; //课程描述
if (objvMajorCourseRelaEN.CourseName == "[null]") objvMajorCourseRelaEN.CourseName = null; //课程名称
if (objvMajorCourseRelaEN.UpdDate == "[null]") objvMajorCourseRelaEN.UpdDate = null; //修改日期
if (objvMajorCourseRelaEN.UpdUserId == "[null]") objvMajorCourseRelaEN.UpdUserId = null; //修改用户Id
if (objvMajorCourseRelaEN.Memo == "[null]") objvMajorCourseRelaEN.Memo = null; //备注
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
public static void CheckProperty4Condition(clsvMajorCourseRelaEN objvMajorCourseRelaEN)
{
 vMajorCourseRelaDA.CheckProperty4Condition(objvMajorCourseRelaEN);
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
if (clscc_CourseBL.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseBL没有刷新缓存机制(clscc_CourseBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorBL没有刷新缓存机制(clsXzMajorBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMajorCourseRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsMajorCourseRelaBL没有刷新缓存机制(clsMajorCourseRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvMajorCourseRelaObjLstCache == null)
//{
//arrvMajorCourseRelaObjLstCache = vMajorCourseRelaDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvMajorCourseRelaEN GetObjBymIdCache(long lngmId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvMajorCourseRelaEN._CurrTabName);
List<clsvMajorCourseRelaEN> arrvMajorCourseRelaObjLstCache = GetObjLstCache();
IEnumerable <clsvMajorCourseRelaEN> arrvMajorCourseRelaObjLst_Sel =
arrvMajorCourseRelaObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvMajorCourseRelaObjLst_Sel.Count() == 0)
{
   clsvMajorCourseRelaEN obj = clsvMajorCourseRelaBL.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvMajorCourseRelaObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvMajorCourseRelaEN> GetAllvMajorCourseRelaObjLstCache()
{
//获取缓存中的对象列表
List<clsvMajorCourseRelaEN> arrvMajorCourseRelaObjLstCache = GetObjLstCache(); 
return arrvMajorCourseRelaObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvMajorCourseRelaEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvMajorCourseRelaEN._CurrTabName);
List<clsvMajorCourseRelaEN> arrvMajorCourseRelaObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvMajorCourseRelaObjLstCache;
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
string strKey = string.Format("{0}", clsvMajorCourseRelaEN._CurrTabName);
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
if (strInFldName != convMajorCourseRela.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convMajorCourseRela.AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convMajorCourseRela.AttributeName));
throw new Exception(strMsg);
}
var objvMajorCourseRela = clsvMajorCourseRelaBL.GetObjBymIdCache(lngmId);
if (objvMajorCourseRela == null) return "";
return objvMajorCourseRela[strOutFldName].ToString();
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
int intRecCount = clsvMajorCourseRelaDA.GetRecCount(strTabName);
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
int intRecCount = clsvMajorCourseRelaDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvMajorCourseRelaDA.GetRecCount();
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
int intRecCount = clsvMajorCourseRelaDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvMajorCourseRelaCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvMajorCourseRelaEN objvMajorCourseRelaCond)
{
List<clsvMajorCourseRelaEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvMajorCourseRelaEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convMajorCourseRela.AttributeName)
{
if (objvMajorCourseRelaCond.IsUpdated(strFldName) == false) continue;
if (objvMajorCourseRelaCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMajorCourseRelaCond[strFldName].ToString());
}
else
{
if (objvMajorCourseRelaCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvMajorCourseRelaCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvMajorCourseRelaCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvMajorCourseRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvMajorCourseRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvMajorCourseRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvMajorCourseRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvMajorCourseRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvMajorCourseRelaCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvMajorCourseRelaCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvMajorCourseRelaCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvMajorCourseRelaCond[strFldName]));
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
 List<string> arrList = clsvMajorCourseRelaDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vMajorCourseRelaDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vMajorCourseRelaDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}