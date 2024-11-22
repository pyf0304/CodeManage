
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvMajorCourseRelaWApi
 表名:vMajorCourseRela(01120540)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:46:15
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:课程学习
 模块英文名:CourseLearning
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
public static class clsvMajorCourseRelaWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorCourseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorCourseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMajorCourseRelaEN SetCourseId(this clsvMajorCourseRelaEN objvMajorCourseRelaEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convMajorCourseRela.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convMajorCourseRela.CourseId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorCourseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMajorCourseRelaEN SetCourseCode(this clsvMajorCourseRelaEN objvMajorCourseRelaEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convMajorCourseRela.CourseCode);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorCourseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMajorCourseRelaEN SetCourseDescription(this clsvMajorCourseRelaEN objvMajorCourseRelaEN, string strCourseDescription, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseDescription, 8000, convMajorCourseRela.CourseDescription);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorCourseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMajorCourseRelaEN SetCourseName(this clsvMajorCourseRelaEN objvMajorCourseRelaEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convMajorCourseRela.CourseName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorCourseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMajorCourseRelaEN SetCourseTypeID(this clsvMajorCourseRelaEN objvMajorCourseRelaEN, string strCourseTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseTypeID, convMajorCourseRela.CourseTypeID);
clsCheckSql.CheckFieldLen(strCourseTypeID, 4, convMajorCourseRela.CourseTypeID);
clsCheckSql.CheckFieldForeignKey(strCourseTypeID, 4, convMajorCourseRela.CourseTypeID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorCourseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorCourseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMajorCourseRelaEN Setid_XzMajor(this clsvMajorCourseRelaEN objvMajorCourseRelaEN, string strid_XzMajor, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_XzMajor, convMajorCourseRela.id_XzMajor);
clsCheckSql.CheckFieldLen(strid_XzMajor, 8, convMajorCourseRela.id_XzMajor);
clsCheckSql.CheckFieldForeignKey(strid_XzMajor, 8, convMajorCourseRela.id_XzMajor);
objvMajorCourseRelaEN.id_XzMajor = strid_XzMajor; //专业流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvMajorCourseRelaEN.dicFldComparisonOp.ContainsKey(convMajorCourseRela.id_XzMajor) == false)
{
objvMajorCourseRelaEN.dicFldComparisonOp.Add(convMajorCourseRela.id_XzMajor, strComparisonOp);
}
else
{
objvMajorCourseRelaEN.dicFldComparisonOp[convMajorCourseRela.id_XzMajor] = strComparisonOp;
}
}
return objvMajorCourseRelaEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorCourseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMajorCourseRelaEN SetMajorID(this clsvMajorCourseRelaEN objvMajorCourseRelaEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorID, convMajorCourseRela.MajorID);
clsCheckSql.CheckFieldLen(strMajorID, 4, convMajorCourseRela.MajorID);
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convMajorCourseRela.MajorID);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorCourseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMajorCourseRelaEN SetMajorName(this clsvMajorCourseRelaEN objvMajorCourseRelaEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strMajorName, convMajorCourseRela.MajorName);
clsCheckSql.CheckFieldLen(strMajorName, 100, convMajorCourseRela.MajorName);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorCourseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMajorCourseRelaEN SetUpdDate(this clsvMajorCourseRelaEN objvMajorCourseRelaEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convMajorCourseRela.UpdDate);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorCourseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMajorCourseRelaEN SetUpdUserId(this clsvMajorCourseRelaEN objvMajorCourseRelaEN, string strUpdUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUserId, 20, convMajorCourseRela.UpdUserId);
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
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvMajorCourseRelaEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvMajorCourseRelaEN SetMemo(this clsvMajorCourseRelaEN objvMajorCourseRelaEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convMajorCourseRela.Memo);
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
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvMajorCourseRelaEN objvMajorCourseRela_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvMajorCourseRela_Cond.IsUpdated(convMajorCourseRela.mId) == true)
{
string strComparisonOp_mId = objvMajorCourseRela_Cond.dicFldComparisonOp[convMajorCourseRela.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convMajorCourseRela.mId, objvMajorCourseRela_Cond.mId, strComparisonOp_mId);
}
if (objvMajorCourseRela_Cond.IsUpdated(convMajorCourseRela.CourseId) == true)
{
string strComparisonOp_CourseId = objvMajorCourseRela_Cond.dicFldComparisonOp[convMajorCourseRela.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMajorCourseRela.CourseId, objvMajorCourseRela_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvMajorCourseRela_Cond.IsUpdated(convMajorCourseRela.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvMajorCourseRela_Cond.dicFldComparisonOp[convMajorCourseRela.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMajorCourseRela.CourseCode, objvMajorCourseRela_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvMajorCourseRela_Cond.IsUpdated(convMajorCourseRela.CourseDescription) == true)
{
string strComparisonOp_CourseDescription = objvMajorCourseRela_Cond.dicFldComparisonOp[convMajorCourseRela.CourseDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMajorCourseRela.CourseDescription, objvMajorCourseRela_Cond.CourseDescription, strComparisonOp_CourseDescription);
}
if (objvMajorCourseRela_Cond.IsUpdated(convMajorCourseRela.CourseName) == true)
{
string strComparisonOp_CourseName = objvMajorCourseRela_Cond.dicFldComparisonOp[convMajorCourseRela.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMajorCourseRela.CourseName, objvMajorCourseRela_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvMajorCourseRela_Cond.IsUpdated(convMajorCourseRela.CourseTypeID) == true)
{
string strComparisonOp_CourseTypeID = objvMajorCourseRela_Cond.dicFldComparisonOp[convMajorCourseRela.CourseTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMajorCourseRela.CourseTypeID, objvMajorCourseRela_Cond.CourseTypeID, strComparisonOp_CourseTypeID);
}
if (objvMajorCourseRela_Cond.IsUpdated(convMajorCourseRela.IsOpen) == true)
{
if (objvMajorCourseRela_Cond.IsOpen == true)
{
strWhereCond += string.Format(" And {0} = '1'", convMajorCourseRela.IsOpen);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convMajorCourseRela.IsOpen);
}
}
if (objvMajorCourseRela_Cond.IsUpdated(convMajorCourseRela.id_XzMajor) == true)
{
string strComparisonOp_id_XzMajor = objvMajorCourseRela_Cond.dicFldComparisonOp[convMajorCourseRela.id_XzMajor];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMajorCourseRela.id_XzMajor, objvMajorCourseRela_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
}
if (objvMajorCourseRela_Cond.IsUpdated(convMajorCourseRela.MajorID) == true)
{
string strComparisonOp_MajorID = objvMajorCourseRela_Cond.dicFldComparisonOp[convMajorCourseRela.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMajorCourseRela.MajorID, objvMajorCourseRela_Cond.MajorID, strComparisonOp_MajorID);
}
if (objvMajorCourseRela_Cond.IsUpdated(convMajorCourseRela.MajorName) == true)
{
string strComparisonOp_MajorName = objvMajorCourseRela_Cond.dicFldComparisonOp[convMajorCourseRela.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMajorCourseRela.MajorName, objvMajorCourseRela_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvMajorCourseRela_Cond.IsUpdated(convMajorCourseRela.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvMajorCourseRela_Cond.dicFldComparisonOp[convMajorCourseRela.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMajorCourseRela.UpdDate, objvMajorCourseRela_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvMajorCourseRela_Cond.IsUpdated(convMajorCourseRela.UpdUserId) == true)
{
string strComparisonOp_UpdUserId = objvMajorCourseRela_Cond.dicFldComparisonOp[convMajorCourseRela.UpdUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMajorCourseRela.UpdUserId, objvMajorCourseRela_Cond.UpdUserId, strComparisonOp_UpdUserId);
}
if (objvMajorCourseRela_Cond.IsUpdated(convMajorCourseRela.Memo) == true)
{
string strComparisonOp_Memo = objvMajorCourseRela_Cond.dicFldComparisonOp[convMajorCourseRela.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convMajorCourseRela.Memo, objvMajorCourseRela_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v专业课程关系(vMajorCourseRela)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvMajorCourseRelaWApi
{
private static readonly string mstrApiControllerName = "vMajorCourseRelaApi";

 public clsvMajorCourseRelaWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvMajorCourseRelaEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsvMajorCourseRelaEN objvMajorCourseRelaEN = null;
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
objvMajorCourseRelaEN = JsonConvert.DeserializeObject<clsvMajorCourseRelaEN>((string)jobjReturn["ReturnObj"]);
return objvMajorCourseRelaEN;
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
public static clsvMajorCourseRelaEN GetObjBymId_WA_Cache(long lngmId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvMajorCourseRelaEN objvMajorCourseRelaEN = null;
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
objvMajorCourseRelaEN = JsonConvert.DeserializeObject<clsvMajorCourseRelaEN>((string)jobjReturn["ReturnObj"]);
return objvMajorCourseRelaEN;
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
public static clsvMajorCourseRelaEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvMajorCourseRelaEN objvMajorCourseRelaEN = null;
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
objvMajorCourseRelaEN = JsonConvert.DeserializeObject<clsvMajorCourseRelaEN>((string)jobjReturn["ReturnObj"]);
return objvMajorCourseRelaEN;
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
public static clsvMajorCourseRelaEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvMajorCourseRelaEN._CurrTabName_S);
List<clsvMajorCourseRelaEN> arrvMajorCourseRelaObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvMajorCourseRelaEN> arrvMajorCourseRelaObjLst_Sel =
from objvMajorCourseRelaEN in arrvMajorCourseRelaObjLst_Cache
where objvMajorCourseRelaEN.mId == lngmId
select objvMajorCourseRelaEN;
if (arrvMajorCourseRelaObjLst_Sel.Count() == 0)
{
   clsvMajorCourseRelaEN obj = clsvMajorCourseRelaWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvMajorCourseRelaObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMajorCourseRelaEN> GetObjLst(string strWhereCond)
{
 List<clsvMajorCourseRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMajorCourseRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMajorCourseRelaEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvMajorCourseRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMajorCourseRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvMajorCourseRelaEN> GetObjLstByMIdLst_Cache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvMajorCourseRelaEN._CurrTabName_S);
List<clsvMajorCourseRelaEN> arrvMajorCourseRelaObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvMajorCourseRelaEN> arrvMajorCourseRelaObjLst_Sel =
from objvMajorCourseRelaEN in arrvMajorCourseRelaObjLst_Cache
where arrMId.Contains(objvMajorCourseRelaEN.mId)
select objvMajorCourseRelaEN;
return arrvMajorCourseRelaObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvMajorCourseRelaEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId)
{
 List<clsvMajorCourseRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMajorCourseRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMajorCourseRelaEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvMajorCourseRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMajorCourseRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMajorCourseRelaEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvMajorCourseRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMajorCourseRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMajorCourseRelaEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvMajorCourseRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMajorCourseRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvMajorCourseRelaEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvMajorCourseRelaEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvMajorCourseRelaEN>>((string)jobjReturn["ReturnObjLst"]);
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
objvMajorCourseRelaENT.id_XzMajor = objvMajorCourseRelaENS.id_XzMajor; //专业流水号
objvMajorCourseRelaENT.MajorID = objvMajorCourseRelaENS.MajorID; //专业ID
objvMajorCourseRelaENT.MajorName = objvMajorCourseRelaENS.MajorName; //专业名称
objvMajorCourseRelaENT.UpdDate = objvMajorCourseRelaENS.UpdDate; //修改日期
objvMajorCourseRelaENT.UpdUserId = objvMajorCourseRelaENS.UpdUserId; //修改用户Id
objvMajorCourseRelaENT.Memo = objvMajorCourseRelaENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvMajorCourseRelaEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvMajorCourseRelaEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvMajorCourseRelaEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvMajorCourseRelaEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvMajorCourseRelaEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvMajorCourseRelaEN.AttributeName)
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
if (clscc_CourseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseWApi没有刷新缓存机制(clscc_CourseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorWApi没有刷新缓存机制(clsXzMajorWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMajorCourseRelaWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMajorCourseRelaWApi没有刷新缓存机制(clsMajorCourseRelaWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvMajorCourseRelaObjLst_Cache == null)
//{
//arrvMajorCourseRelaObjLst_Cache = await clsvMajorCourseRelaWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvMajorCourseRelaEN._CurrTabName_S);
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
public static List<clsvMajorCourseRelaEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvMajorCourseRelaEN._CurrTabName_S);
List<clsvMajorCourseRelaEN> arrvMajorCourseRelaObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvMajorCourseRelaObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvMajorCourseRelaEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convMajorCourseRela.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convMajorCourseRela.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convMajorCourseRela.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convMajorCourseRela.CourseDescription, Type.GetType("System.String"));
objDT.Columns.Add(convMajorCourseRela.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convMajorCourseRela.CourseTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convMajorCourseRela.IsOpen, Type.GetType("System.Boolean"));
objDT.Columns.Add(convMajorCourseRela.id_XzMajor, Type.GetType("System.String"));
objDT.Columns.Add(convMajorCourseRela.MajorID, Type.GetType("System.String"));
objDT.Columns.Add(convMajorCourseRela.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convMajorCourseRela.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convMajorCourseRela.UpdUserId, Type.GetType("System.String"));
objDT.Columns.Add(convMajorCourseRela.Memo, Type.GetType("System.String"));
foreach (clsvMajorCourseRelaEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convMajorCourseRela.mId] = objInFor[convMajorCourseRela.mId];
objDR[convMajorCourseRela.CourseId] = objInFor[convMajorCourseRela.CourseId];
objDR[convMajorCourseRela.CourseCode] = objInFor[convMajorCourseRela.CourseCode];
objDR[convMajorCourseRela.CourseDescription] = objInFor[convMajorCourseRela.CourseDescription];
objDR[convMajorCourseRela.CourseName] = objInFor[convMajorCourseRela.CourseName];
objDR[convMajorCourseRela.CourseTypeID] = objInFor[convMajorCourseRela.CourseTypeID];
objDR[convMajorCourseRela.IsOpen] = objInFor[convMajorCourseRela.IsOpen];
objDR[convMajorCourseRela.id_XzMajor] = objInFor[convMajorCourseRela.id_XzMajor];
objDR[convMajorCourseRela.MajorID] = objInFor[convMajorCourseRela.MajorID];
objDR[convMajorCourseRela.MajorName] = objInFor[convMajorCourseRela.MajorName];
objDR[convMajorCourseRela.UpdDate] = objInFor[convMajorCourseRela.UpdDate];
objDR[convMajorCourseRela.UpdUserId] = objInFor[convMajorCourseRela.UpdUserId];
objDR[convMajorCourseRela.Memo] = objInFor[convMajorCourseRela.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}