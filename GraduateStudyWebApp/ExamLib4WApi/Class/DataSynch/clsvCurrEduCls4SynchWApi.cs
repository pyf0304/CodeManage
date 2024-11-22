
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCurrEduCls4SynchWApi
 表名:vCurrEduCls4Synch(01120361)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:39:02
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:数据同步
 模块英文名:DataSynch
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
public static class clsvCurrEduCls4SynchWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetmId(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, long lngmId, string strComparisonOp="")
	{
objvCurrEduCls4SynchEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.mId) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.mId, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.mId] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetIpAddress(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strIpAddress, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strIpAddress, 50, convCurrEduCls4Synch.IpAddress);
objvCurrEduCls4SynchEN.IpAddress = strIpAddress; //Ip地址
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.IpAddress) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.IpAddress, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.IpAddress] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN Setid_CurrEduCls(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strid_CurrEduCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_CurrEduCls, convCurrEduCls4Synch.id_CurrEduCls);
clsCheckSql.CheckFieldLen(strid_CurrEduCls, 8, convCurrEduCls4Synch.id_CurrEduCls);
clsCheckSql.CheckFieldForeignKey(strid_CurrEduCls, 8, convCurrEduCls4Synch.id_CurrEduCls);
objvCurrEduCls4SynchEN.id_CurrEduCls = strid_CurrEduCls; //当前教学班流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.id_CurrEduCls) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.id_CurrEduCls, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.id_CurrEduCls] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetCurrEduClsId(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strCurrEduClsId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCurrEduClsId, 15, convCurrEduCls4Synch.CurrEduClsId);
objvCurrEduCls4SynchEN.CurrEduClsId = strCurrEduClsId; //当前教学班Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.CurrEduClsId) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.CurrEduClsId, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.CurrEduClsId] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetEduClsName(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strEduClsName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEduClsName, convCurrEduCls4Synch.EduClsName);
clsCheckSql.CheckFieldLen(strEduClsName, 100, convCurrEduCls4Synch.EduClsName);
objvCurrEduCls4SynchEN.EduClsName = strEduClsName; //教学班名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.EduClsName) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.EduClsName, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.EduClsName] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetEduClsTypeId(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strEduClsTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strEduClsTypeId, convCurrEduCls4Synch.EduClsTypeId);
clsCheckSql.CheckFieldLen(strEduClsTypeId, 4, convCurrEduCls4Synch.EduClsTypeId);
clsCheckSql.CheckFieldForeignKey(strEduClsTypeId, 4, convCurrEduCls4Synch.EduClsTypeId);
objvCurrEduCls4SynchEN.EduClsTypeId = strEduClsTypeId; //教学班类型代号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.EduClsTypeId) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.EduClsTypeId, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.EduClsTypeId] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetCourseId(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convCurrEduCls4Synch.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convCurrEduCls4Synch.CourseId);
objvCurrEduCls4SynchEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.CourseId) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.CourseId, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.CourseId] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetCourseCode(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convCurrEduCls4Synch.CourseCode);
objvCurrEduCls4SynchEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.CourseCode) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.CourseCode, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.CourseCode] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetCourseDescription(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strCourseDescription, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseDescription, 8000, convCurrEduCls4Synch.CourseDescription);
objvCurrEduCls4SynchEN.CourseDescription = strCourseDescription; //课程描述
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.CourseDescription) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.CourseDescription, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.CourseDescription] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetCourseName(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convCurrEduCls4Synch.CourseName);
objvCurrEduCls4SynchEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.CourseName) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.CourseName, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.CourseName] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetExampleImgPath(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strExampleImgPath, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strExampleImgPath, 300, convCurrEduCls4Synch.ExampleImgPath);
objvCurrEduCls4SynchEN.ExampleImgPath = strExampleImgPath; //示例图路径
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.ExampleImgPath) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.ExampleImgPath, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.ExampleImgPath] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetViewCount(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, int intViewCount, string strComparisonOp="")
	{
objvCurrEduCls4SynchEN.ViewCount = intViewCount; //浏览量
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.ViewCount) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.ViewCount, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.ViewCount] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetTeachingSolutionId(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strTeachingSolutionId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachingSolutionId, convCurrEduCls4Synch.TeachingSolutionId);
clsCheckSql.CheckFieldLen(strTeachingSolutionId, 8, convCurrEduCls4Synch.TeachingSolutionId);
clsCheckSql.CheckFieldForeignKey(strTeachingSolutionId, 8, convCurrEduCls4Synch.TeachingSolutionId);
objvCurrEduCls4SynchEN.TeachingSolutionId = strTeachingSolutionId; //教学方案Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.TeachingSolutionId) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.TeachingSolutionId, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.TeachingSolutionId] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetTeachingSolutionName(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strTeachingSolutionName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeachingSolutionName, convCurrEduCls4Synch.TeachingSolutionName);
clsCheckSql.CheckFieldLen(strTeachingSolutionName, 100, convCurrEduCls4Synch.TeachingSolutionName);
objvCurrEduCls4SynchEN.TeachingSolutionName = strTeachingSolutionName; //教学方案名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.TeachingSolutionName) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.TeachingSolutionName, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.TeachingSolutionName] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN Setid_Teacher(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strid_Teacher, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Teacher, convCurrEduCls4Synch.id_Teacher);
clsCheckSql.CheckFieldLen(strid_Teacher, 8, convCurrEduCls4Synch.id_Teacher);
clsCheckSql.CheckFieldForeignKey(strid_Teacher, 8, convCurrEduCls4Synch.id_Teacher);
objvCurrEduCls4SynchEN.id_Teacher = strid_Teacher; //教师流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.id_Teacher) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.id_Teacher, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.id_Teacher] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetTeacherID(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strTeacherID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeacherID, convCurrEduCls4Synch.TeacherID);
clsCheckSql.CheckFieldLen(strTeacherID, 12, convCurrEduCls4Synch.TeacherID);
objvCurrEduCls4SynchEN.TeacherID = strTeacherID; //教师工号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.TeacherID) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.TeacherID, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.TeacherID] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetTeacherName(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strTeacherName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strTeacherName, convCurrEduCls4Synch.TeacherName);
clsCheckSql.CheckFieldLen(strTeacherName, 50, convCurrEduCls4Synch.TeacherName);
objvCurrEduCls4SynchEN.TeacherName = strTeacherName; //教师姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.TeacherName) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.TeacherName, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.TeacherName] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN Setid_XzCollege(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convCurrEduCls4Synch.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convCurrEduCls4Synch.id_XzCollege);
objvCurrEduCls4SynchEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.id_XzCollege) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.id_XzCollege, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.id_XzCollege] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetCollegeID(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeID, convCurrEduCls4Synch.CollegeID);
clsCheckSql.CheckFieldLen(strCollegeID, 4, convCurrEduCls4Synch.CollegeID);
objvCurrEduCls4SynchEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.CollegeID) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.CollegeID, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.CollegeID] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetCollegeName(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCollegeName, convCurrEduCls4Synch.CollegeName);
clsCheckSql.CheckFieldLen(strCollegeName, 100, convCurrEduCls4Synch.CollegeName);
objvCurrEduCls4SynchEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.CollegeName) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.CollegeName, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.CollegeName] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetClgEnglishName(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strClgEnglishName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strClgEnglishName, 60, convCurrEduCls4Synch.ClgEnglishName);
objvCurrEduCls4SynchEN.ClgEnglishName = strClgEnglishName; //ClgEnglishName
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.ClgEnglishName) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.ClgEnglishName, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.ClgEnglishName] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetPhoneNumber(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strPhoneNumber, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPhoneNumber, 15, convCurrEduCls4Synch.PhoneNumber);
objvCurrEduCls4SynchEN.PhoneNumber = strPhoneNumber; //PhoneNumber
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.PhoneNumber) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.PhoneNumber, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.PhoneNumber] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN Setid_EduWay(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strid_EduWay, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_EduWay, convCurrEduCls4Synch.id_EduWay);
clsCheckSql.CheckFieldLen(strid_EduWay, 4, convCurrEduCls4Synch.id_EduWay);
clsCheckSql.CheckFieldForeignKey(strid_EduWay, 4, convCurrEduCls4Synch.id_EduWay);
objvCurrEduCls4SynchEN.id_EduWay = strid_EduWay; //教学方式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.id_EduWay) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.id_EduWay, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.id_EduWay] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN Setid_ClassRoomType(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strid_ClassRoomType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_ClassRoomType, convCurrEduCls4Synch.id_ClassRoomType);
clsCheckSql.CheckFieldLen(strid_ClassRoomType, 4, convCurrEduCls4Synch.id_ClassRoomType);
clsCheckSql.CheckFieldForeignKey(strid_ClassRoomType, 4, convCurrEduCls4Synch.id_ClassRoomType);
objvCurrEduCls4SynchEN.id_ClassRoomType = strid_ClassRoomType; //教室类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.id_ClassRoomType) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.id_ClassRoomType, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.id_ClassRoomType] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetTotalLessonQty(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, int intTotalLessonQty, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intTotalLessonQty, convCurrEduCls4Synch.TotalLessonQty);
objvCurrEduCls4SynchEN.TotalLessonQty = intTotalLessonQty; //总课时数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.TotalLessonQty) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.TotalLessonQty, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.TotalLessonQty] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetMaxStuQty(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, int intMaxStuQty, string strComparisonOp="")
	{
objvCurrEduCls4SynchEN.MaxStuQty = intMaxStuQty; //最大学生数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.MaxStuQty) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.MaxStuQty, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.MaxStuQty] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetWeekQty(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, int intWeekQty, string strComparisonOp="")
	{
objvCurrEduCls4SynchEN.WeekQty = intWeekQty; //总周数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.WeekQty) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.WeekQty, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.WeekQty] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetScheUnitPW(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, short shtScheUnitPW, string strComparisonOp="")
	{
objvCurrEduCls4SynchEN.ScheUnitPW = shtScheUnitPW; //周排课次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.ScheUnitPW) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.ScheUnitPW, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.ScheUnitPW] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetWeekStatusID(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strWeekStatusID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strWeekStatusID, 2, convCurrEduCls4Synch.WeekStatusID);
clsCheckSql.CheckFieldForeignKey(strWeekStatusID, 2, convCurrEduCls4Synch.WeekStatusID);
objvCurrEduCls4SynchEN.WeekStatusID = strWeekStatusID; //周状态编号(单,双,全周)
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.WeekStatusID) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.WeekStatusID, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.WeekStatusID] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetCustomerWeek(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strCustomerWeek, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCustomerWeek, 50, convCurrEduCls4Synch.CustomerWeek);
objvCurrEduCls4SynchEN.CustomerWeek = strCustomerWeek; //自定义上课周
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.CustomerWeek) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.CustomerWeek, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.CustomerWeek] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetIsCompleteScore(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, bool bolIsCompleteScore, string strComparisonOp="")
	{
objvCurrEduCls4SynchEN.IsCompleteScore = bolIsCompleteScore; //是否成绩齐全
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.IsCompleteScore) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.IsCompleteScore, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.IsCompleteScore] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN Setid_ExecPlan(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strid_ExecPlan, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_ExecPlan, convCurrEduCls4Synch.id_ExecPlan);
clsCheckSql.CheckFieldLen(strid_ExecPlan, 8, convCurrEduCls4Synch.id_ExecPlan);
clsCheckSql.CheckFieldForeignKey(strid_ExecPlan, 8, convCurrEduCls4Synch.id_ExecPlan);
objvCurrEduCls4SynchEN.id_ExecPlan = strid_ExecPlan; //执行计划流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.id_ExecPlan) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.id_ExecPlan, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.id_ExecPlan] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetLessonQtyPerWeek(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, short shtLessonQtyPerWeek, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(shtLessonQtyPerWeek, convCurrEduCls4Synch.LessonQtyPerWeek);
objvCurrEduCls4SynchEN.LessonQtyPerWeek = shtLessonQtyPerWeek; //周课时数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.LessonQtyPerWeek) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.LessonQtyPerWeek, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.LessonQtyPerWeek] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetMark(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, double dblMark, string strComparisonOp="")
	{
objvCurrEduCls4SynchEN.Mark = dblMark; //获得学分
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.Mark) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.Mark, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.Mark] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetCheckClassRoom(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strCheckClassRoom, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCheckClassRoom, 2000, convCurrEduCls4Synch.CheckClassRoom);
objvCurrEduCls4SynchEN.CheckClassRoom = strCheckClassRoom; //检查教室结果
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.CheckClassRoom) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.CheckClassRoom, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.CheckClassRoom] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetCheckAdminCls(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strCheckAdminCls, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCheckAdminCls, 2000, convCurrEduCls4Synch.CheckAdminCls);
objvCurrEduCls4SynchEN.CheckAdminCls = strCheckAdminCls; //检查行政班结果
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.CheckAdminCls) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.CheckAdminCls, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.CheckAdminCls] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetCheckTeacher(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strCheckTeacher, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCheckTeacher, 2000, convCurrEduCls4Synch.CheckTeacher);
objvCurrEduCls4SynchEN.CheckTeacher = strCheckTeacher; //检查教师结果
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.CheckTeacher) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.CheckTeacher, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.CheckTeacher] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetEditLocked(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, bool bolEditLocked, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolEditLocked, convCurrEduCls4Synch.EditLocked);
objvCurrEduCls4SynchEN.EditLocked = bolEditLocked; //编辑锁定
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.EditLocked) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.EditLocked, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.EditLocked] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetSched(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, bool bolSched, string strComparisonOp="")
	{
objvCurrEduCls4SynchEN.Sched = bolSched; //是否排课
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.Sched) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.Sched, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.Sched] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN Setid_UniZone(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strid_UniZone, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_UniZone, convCurrEduCls4Synch.id_UniZone);
clsCheckSql.CheckFieldLen(strid_UniZone, 4, convCurrEduCls4Synch.id_UniZone);
clsCheckSql.CheckFieldForeignKey(strid_UniZone, 4, convCurrEduCls4Synch.id_UniZone);
objvCurrEduCls4SynchEN.id_UniZone = strid_UniZone; //校区流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.id_UniZone) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.id_UniZone, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.id_UniZone] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetLocked(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, bool bolLocked, string strComparisonOp="")
	{
objvCurrEduCls4SynchEN.Locked = bolLocked; //锁定状态
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.Locked) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.Locked, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.Locked] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN Setid_GradeBase(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strid_GradeBase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_GradeBase, 4, convCurrEduCls4Synch.id_GradeBase);
clsCheckSql.CheckFieldForeignKey(strid_GradeBase, 4, convCurrEduCls4Synch.id_GradeBase);
objvCurrEduCls4SynchEN.id_GradeBase = strid_GradeBase; //年级流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.id_GradeBase) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.id_GradeBase, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.id_GradeBase] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetGradeBaseID(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strGradeBaseID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGradeBaseID, 4, convCurrEduCls4Synch.GradeBaseID);
clsCheckSql.CheckFieldForeignKey(strGradeBaseID, 4, convCurrEduCls4Synch.GradeBaseID);
objvCurrEduCls4SynchEN.GradeBaseID = strGradeBaseID; //年级代号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.GradeBaseID) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.GradeBaseID, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.GradeBaseID] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetGradeBaseName(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strGradeBaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGradeBaseName, convCurrEduCls4Synch.GradeBaseName);
clsCheckSql.CheckFieldLen(strGradeBaseName, 50, convCurrEduCls4Synch.GradeBaseName);
objvCurrEduCls4SynchEN.GradeBaseName = strGradeBaseName; //年级名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.GradeBaseName) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.GradeBaseName, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.GradeBaseName] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetGradeBaseNameA(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strGradeBaseNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strGradeBaseNameA, convCurrEduCls4Synch.GradeBaseNameA);
clsCheckSql.CheckFieldLen(strGradeBaseNameA, 10, convCurrEduCls4Synch.GradeBaseNameA);
objvCurrEduCls4SynchEN.GradeBaseNameA = strGradeBaseNameA; //年级名称缩写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.GradeBaseNameA) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.GradeBaseNameA, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.GradeBaseNameA] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetIsEffective(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, bool bolIsEffective, string strComparisonOp="")
	{
objvCurrEduCls4SynchEN.IsEffective = bolIsEffective; //是否有效
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.IsEffective) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.IsEffective, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.IsEffective] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetIsUnDeterminedClsRm(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, bool bolIsUnDeterminedClsRm, string strComparisonOp="")
	{
objvCurrEduCls4SynchEN.IsUnDeterminedClsRm = bolIsUnDeterminedClsRm; //是否待定教室
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.IsUnDeterminedClsRm) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.IsUnDeterminedClsRm, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.IsUnDeterminedClsRm] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetSchoolYear(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strSchoolYear, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolYear, 10, convCurrEduCls4Synch.SchoolYear);
objvCurrEduCls4SynchEN.SchoolYear = strSchoolYear; //学年
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.SchoolYear) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.SchoolYear, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.SchoolYear] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetSchoolTerm(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strSchoolTerm, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSchoolTerm, 1, convCurrEduCls4Synch.SchoolTerm);
clsCheckSql.CheckFieldForeignKey(strSchoolTerm, 1, convCurrEduCls4Synch.SchoolTerm);
objvCurrEduCls4SynchEN.SchoolTerm = strSchoolTerm; //学期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.SchoolTerm) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.SchoolTerm, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.SchoolTerm] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetArrangeCourseMemo(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strArrangeCourseMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strArrangeCourseMemo, 50, convCurrEduCls4Synch.ArrangeCourseMemo);
objvCurrEduCls4SynchEN.ArrangeCourseMemo = strArrangeCourseMemo; //排课备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.ArrangeCourseMemo) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.ArrangeCourseMemo, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.ArrangeCourseMemo] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN Setid_CourseType(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strid_CourseType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_CourseType, convCurrEduCls4Synch.id_CourseType);
clsCheckSql.CheckFieldLen(strid_CourseType, 4, convCurrEduCls4Synch.id_CourseType);
clsCheckSql.CheckFieldForeignKey(strid_CourseType, 4, convCurrEduCls4Synch.id_CourseType);
objvCurrEduCls4SynchEN.id_CourseType = strid_CourseType; //课程类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.id_CourseType) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.id_CourseType, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.id_CourseType] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetCourseTypeID(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strCourseTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseTypeID, convCurrEduCls4Synch.CourseTypeID);
clsCheckSql.CheckFieldLen(strCourseTypeID, 4, convCurrEduCls4Synch.CourseTypeID);
clsCheckSql.CheckFieldForeignKey(strCourseTypeID, 4, convCurrEduCls4Synch.CourseTypeID);
objvCurrEduCls4SynchEN.CourseTypeID = strCourseTypeID; //课程类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.CourseTypeID) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.CourseTypeID, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.CourseTypeID] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetCourseTypeName(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strCourseTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCourseTypeName, convCurrEduCls4Synch.CourseTypeName);
clsCheckSql.CheckFieldLen(strCourseTypeName, 30, convCurrEduCls4Synch.CourseTypeName);
objvCurrEduCls4SynchEN.CourseTypeName = strCourseTypeName; //课程类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.CourseTypeName) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.CourseTypeName, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.CourseTypeName] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetIsDegree(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, bool bolIsDegree, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(bolIsDegree, convCurrEduCls4Synch.IsDegree);
objvCurrEduCls4SynchEN.IsDegree = bolIsDegree; //是否学位课
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.IsDegree) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.IsDegree, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.IsDegree] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN Setid_ScoreType(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strid_ScoreType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_ScoreType, convCurrEduCls4Synch.id_ScoreType);
clsCheckSql.CheckFieldLen(strid_ScoreType, 4, convCurrEduCls4Synch.id_ScoreType);
clsCheckSql.CheckFieldForeignKey(strid_ScoreType, 4, convCurrEduCls4Synch.id_ScoreType);
objvCurrEduCls4SynchEN.id_ScoreType = strid_ScoreType; //成绩类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.id_ScoreType) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.id_ScoreType, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.id_ScoreType] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetGetScoreWayId(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strGetScoreWayId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGetScoreWayId, 2, convCurrEduCls4Synch.GetScoreWayId);
clsCheckSql.CheckFieldForeignKey(strGetScoreWayId, 2, convCurrEduCls4Synch.GetScoreWayId);
objvCurrEduCls4SynchEN.GetScoreWayId = strGetScoreWayId; //获得成绩方式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.GetScoreWayId) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.GetScoreWayId, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.GetScoreWayId] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetIsProportionalCtrl(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, bool bolIsProportionalCtrl, string strComparisonOp="")
	{
objvCurrEduCls4SynchEN.IsProportionalCtrl = bolIsProportionalCtrl; //是否比例控制
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.IsProportionalCtrl) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.IsProportionalCtrl, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.IsProportionalCtrl] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetIsSynchToWeb(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, bool bolIsSynchToWeb, string strComparisonOp="")
	{
objvCurrEduCls4SynchEN.IsSynchToWeb = bolIsSynchToWeb; //是否同步Web
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.IsSynchToWeb) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.IsSynchToWeb, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.IsSynchToWeb] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetSynchToWebDate(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strSynchToWebDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSynchToWebDate, 20, convCurrEduCls4Synch.SynchToWebDate);
objvCurrEduCls4SynchEN.SynchToWebDate = strSynchToWebDate; //同步Web日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.SynchToWebDate) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.SynchToWebDate, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.SynchToWebDate] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetSynchToWebUser(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strSynchToWebUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSynchToWebUser, 18, convCurrEduCls4Synch.SynchToWebUser);
objvCurrEduCls4SynchEN.SynchToWebUser = strSynchToWebUser; //同步Web用户
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.SynchToWebUser) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.SynchToWebUser, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.SynchToWebUser] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetSignInDate(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strSignInDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSignInDate, 20, convCurrEduCls4Synch.SignInDate);
objvCurrEduCls4SynchEN.SignInDate = strSignInDate; //签入时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.SignInDate) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.SignInDate, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.SignInDate] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetSignInStateID(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strSignInStateID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSignInStateID, 2, convCurrEduCls4Synch.SignInStateID);
clsCheckSql.CheckFieldForeignKey(strSignInStateID, 2, convCurrEduCls4Synch.SignInStateID);
objvCurrEduCls4SynchEN.SignInStateID = strSignInStateID; //签入状态表流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.SignInStateID) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.SignInStateID, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.SignInStateID] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetSignInUser(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strSignInUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSignInUser, 18, convCurrEduCls4Synch.SignInUser);
objvCurrEduCls4SynchEN.SignInUser = strSignInUser; //签入人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.SignInUser) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.SignInUser, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.SignInUser] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN Setid_ExamType(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strid_ExamType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_ExamType, convCurrEduCls4Synch.id_ExamType);
clsCheckSql.CheckFieldLen(strid_ExamType, 4, convCurrEduCls4Synch.id_ExamType);
clsCheckSql.CheckFieldForeignKey(strid_ExamType, 4, convCurrEduCls4Synch.id_ExamType);
objvCurrEduCls4SynchEN.id_ExamType = strid_ExamType; //考试方式流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.id_ExamType) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.id_ExamType, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.id_ExamType] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetExamPortion(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, short shtExamPortion, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(shtExamPortion, convCurrEduCls4Synch.ExamPortion);
objvCurrEduCls4SynchEN.ExamPortion = shtExamPortion; //平时成绩所占比例
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.ExamPortion) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.ExamPortion, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.ExamPortion] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetMidExamScorePortion(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, short shtMidExamScorePortion, string strComparisonOp="")
	{
objvCurrEduCls4SynchEN.MidExamScorePortion = shtMidExamScorePortion; //期末成绩所占比例
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.MidExamScorePortion) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.MidExamScorePortion, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.MidExamScorePortion] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetIsClearScore(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, bool bolIsClearScore, string strComparisonOp="")
	{
objvCurrEduCls4SynchEN.IsClearScore = bolIsClearScore; //是否重录成绩
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.IsClearScore) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.IsClearScore, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.IsClearScore] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetIsGeneratePwd(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, bool bolIsGeneratePwd, string strComparisonOp="")
	{
objvCurrEduCls4SynchEN.IsGeneratePwd = bolIsGeneratePwd; //是否生成口令
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.IsGeneratePwd) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.IsGeneratePwd, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.IsGeneratePwd] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetGeneratePwdDate(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strGeneratePwdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strGeneratePwdDate, 20, convCurrEduCls4Synch.GeneratePwdDate);
objvCurrEduCls4SynchEN.GeneratePwdDate = strGeneratePwdDate; //生成口令时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.GeneratePwdDate) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.GeneratePwdDate, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.GeneratePwdDate] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetPkWeekTime(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strPkWeekTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPkWeekTime, 2000, convCurrEduCls4Synch.PkWeekTime);
objvCurrEduCls4SynchEN.PkWeekTime = strPkWeekTime; //排课时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.PkWeekTime) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.PkWeekTime, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.PkWeekTime] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetPkClassRooms(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strPkClassRooms, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strPkClassRooms, 150, convCurrEduCls4Synch.PkClassRooms);
objvCurrEduCls4SynchEN.PkClassRooms = strPkClassRooms; //排课教室
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.PkClassRooms) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.PkClassRooms, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.PkClassRooms] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetBeginWeek(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, short shtBeginWeek, string strComparisonOp="")
	{
objvCurrEduCls4SynchEN.BeginWeek = shtBeginWeek; //开始周
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.BeginWeek) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.BeginWeek, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.BeginWeek] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetTeacherNames(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strTeacherNames, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeacherNames, 100, convCurrEduCls4Synch.TeacherNames);
objvCurrEduCls4SynchEN.TeacherNames = strTeacherNames; //教师姓名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.TeacherNames) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.TeacherNames, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.TeacherNames] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetIsAccessSynch(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, bool bolIsAccessSynch, string strComparisonOp="")
	{
objvCurrEduCls4SynchEN.IsAccessSynch = bolIsAccessSynch; //是否处理同步
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.IsAccessSynch) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.IsAccessSynch, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.IsAccessSynch] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetAccessSynchDate(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strAccessSynchDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strAccessSynchDate, 14, convCurrEduCls4Synch.AccessSynchDate);
objvCurrEduCls4SynchEN.AccessSynchDate = strAccessSynchDate; //处理同步日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.AccessSynchDate) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.AccessSynchDate, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.AccessSynchDate] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetIsExistEduClsInCurr(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, bool bolIsExistEduClsInCurr, string strComparisonOp="")
	{
objvCurrEduCls4SynchEN.IsExistEduClsInCurr = bolIsExistEduClsInCurr; //当前是否存在教学班
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.IsExistEduClsInCurr) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.IsExistEduClsInCurr, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.IsExistEduClsInCurr] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetModifyDate(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strModifyDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyDate, 20, convCurrEduCls4Synch.ModifyDate);
objvCurrEduCls4SynchEN.ModifyDate = strModifyDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.ModifyDate) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.ModifyDate, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.ModifyDate] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetModifyUserID(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strModifyUserID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strModifyUserID, 18, convCurrEduCls4Synch.ModifyUserID);
objvCurrEduCls4SynchEN.ModifyUserID = strModifyUserID; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.ModifyUserID) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.ModifyUserID, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.ModifyUserID] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetMemo(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCurrEduCls4Synch.Memo);
objvCurrEduCls4SynchEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.Memo) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.Memo, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.Memo] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetCurrStuNum_Valid(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, int intCurrStuNum_Valid, string strComparisonOp="")
	{
objvCurrEduCls4SynchEN.CurrStuNum_Valid = intCurrStuNum_Valid; //CurrStuNum_Valid
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.CurrStuNum_Valid) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.CurrStuNum_Valid, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.CurrStuNum_Valid] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCurrEduCls4SynchEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvCurrEduCls4SynchEN SetCurrStuNum(this clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN, int intCurrStuNum, string strComparisonOp="")
	{
objvCurrEduCls4SynchEN.CurrStuNum = intCurrStuNum; //当前学生数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCurrEduCls4SynchEN.dicFldComparisonOp.ContainsKey(convCurrEduCls4Synch.CurrStuNum) == false)
{
objvCurrEduCls4SynchEN.dicFldComparisonOp.Add(convCurrEduCls4Synch.CurrStuNum, strComparisonOp);
}
else
{
objvCurrEduCls4SynchEN.dicFldComparisonOp[convCurrEduCls4Synch.CurrStuNum] = strComparisonOp;
}
}
return objvCurrEduCls4SynchEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCurrEduCls4SynchEN objvCurrEduCls4Synch_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.mId) == true)
{
string strComparisonOp_mId = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduCls4Synch.mId, objvCurrEduCls4Synch_Cond.mId, strComparisonOp_mId);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.IpAddress) == true)
{
string strComparisonOp_IpAddress = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.IpAddress];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.IpAddress, objvCurrEduCls4Synch_Cond.IpAddress, strComparisonOp_IpAddress);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.id_CurrEduCls) == true)
{
string strComparisonOp_id_CurrEduCls = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.id_CurrEduCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.id_CurrEduCls, objvCurrEduCls4Synch_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.CurrEduClsId) == true)
{
string strComparisonOp_CurrEduClsId = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.CurrEduClsId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.CurrEduClsId, objvCurrEduCls4Synch_Cond.CurrEduClsId, strComparisonOp_CurrEduClsId);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.EduClsName) == true)
{
string strComparisonOp_EduClsName = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.EduClsName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.EduClsName, objvCurrEduCls4Synch_Cond.EduClsName, strComparisonOp_EduClsName);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.EduClsTypeId) == true)
{
string strComparisonOp_EduClsTypeId = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.EduClsTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.EduClsTypeId, objvCurrEduCls4Synch_Cond.EduClsTypeId, strComparisonOp_EduClsTypeId);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.CourseId) == true)
{
string strComparisonOp_CourseId = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.CourseId, objvCurrEduCls4Synch_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.CourseCode, objvCurrEduCls4Synch_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.CourseDescription) == true)
{
string strComparisonOp_CourseDescription = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.CourseDescription];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.CourseDescription, objvCurrEduCls4Synch_Cond.CourseDescription, strComparisonOp_CourseDescription);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.CourseName) == true)
{
string strComparisonOp_CourseName = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.CourseName, objvCurrEduCls4Synch_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.ExampleImgPath) == true)
{
string strComparisonOp_ExampleImgPath = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.ExampleImgPath];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.ExampleImgPath, objvCurrEduCls4Synch_Cond.ExampleImgPath, strComparisonOp_ExampleImgPath);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.ViewCount) == true)
{
string strComparisonOp_ViewCount = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.ViewCount];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduCls4Synch.ViewCount, objvCurrEduCls4Synch_Cond.ViewCount, strComparisonOp_ViewCount);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.TeachingSolutionId) == true)
{
string strComparisonOp_TeachingSolutionId = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.TeachingSolutionId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.TeachingSolutionId, objvCurrEduCls4Synch_Cond.TeachingSolutionId, strComparisonOp_TeachingSolutionId);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.TeachingSolutionName) == true)
{
string strComparisonOp_TeachingSolutionName = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.TeachingSolutionName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.TeachingSolutionName, objvCurrEduCls4Synch_Cond.TeachingSolutionName, strComparisonOp_TeachingSolutionName);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.id_Teacher) == true)
{
string strComparisonOp_id_Teacher = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.id_Teacher];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.id_Teacher, objvCurrEduCls4Synch_Cond.id_Teacher, strComparisonOp_id_Teacher);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.TeacherID) == true)
{
string strComparisonOp_TeacherID = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.TeacherID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.TeacherID, objvCurrEduCls4Synch_Cond.TeacherID, strComparisonOp_TeacherID);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.TeacherName) == true)
{
string strComparisonOp_TeacherName = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.TeacherName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.TeacherName, objvCurrEduCls4Synch_Cond.TeacherName, strComparisonOp_TeacherName);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.id_XzCollege, objvCurrEduCls4Synch_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.CollegeID, objvCurrEduCls4Synch_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.CollegeName, objvCurrEduCls4Synch_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.ClgEnglishName) == true)
{
string strComparisonOp_ClgEnglishName = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.ClgEnglishName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.ClgEnglishName, objvCurrEduCls4Synch_Cond.ClgEnglishName, strComparisonOp_ClgEnglishName);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.PhoneNumber) == true)
{
string strComparisonOp_PhoneNumber = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.PhoneNumber];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.PhoneNumber, objvCurrEduCls4Synch_Cond.PhoneNumber, strComparisonOp_PhoneNumber);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.id_EduWay) == true)
{
string strComparisonOp_id_EduWay = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.id_EduWay];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.id_EduWay, objvCurrEduCls4Synch_Cond.id_EduWay, strComparisonOp_id_EduWay);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.id_ClassRoomType) == true)
{
string strComparisonOp_id_ClassRoomType = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.id_ClassRoomType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.id_ClassRoomType, objvCurrEduCls4Synch_Cond.id_ClassRoomType, strComparisonOp_id_ClassRoomType);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.TotalLessonQty) == true)
{
string strComparisonOp_TotalLessonQty = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.TotalLessonQty];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduCls4Synch.TotalLessonQty, objvCurrEduCls4Synch_Cond.TotalLessonQty, strComparisonOp_TotalLessonQty);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.MaxStuQty) == true)
{
string strComparisonOp_MaxStuQty = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.MaxStuQty];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduCls4Synch.MaxStuQty, objvCurrEduCls4Synch_Cond.MaxStuQty, strComparisonOp_MaxStuQty);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.WeekQty) == true)
{
string strComparisonOp_WeekQty = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.WeekQty];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduCls4Synch.WeekQty, objvCurrEduCls4Synch_Cond.WeekQty, strComparisonOp_WeekQty);
}
//数据类型short(smallint)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.WeekStatusID) == true)
{
string strComparisonOp_WeekStatusID = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.WeekStatusID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.WeekStatusID, objvCurrEduCls4Synch_Cond.WeekStatusID, strComparisonOp_WeekStatusID);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.CustomerWeek) == true)
{
string strComparisonOp_CustomerWeek = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.CustomerWeek];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.CustomerWeek, objvCurrEduCls4Synch_Cond.CustomerWeek, strComparisonOp_CustomerWeek);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.IsCompleteScore) == true)
{
if (objvCurrEduCls4Synch_Cond.IsCompleteScore == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduCls4Synch.IsCompleteScore);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduCls4Synch.IsCompleteScore);
}
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.id_ExecPlan) == true)
{
string strComparisonOp_id_ExecPlan = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.id_ExecPlan];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.id_ExecPlan, objvCurrEduCls4Synch_Cond.id_ExecPlan, strComparisonOp_id_ExecPlan);
}
//数据类型short(smallint)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.Mark) == true)
{
string strComparisonOp_Mark = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.Mark];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduCls4Synch.Mark, objvCurrEduCls4Synch_Cond.Mark, strComparisonOp_Mark);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.CheckClassRoom) == true)
{
string strComparisonOp_CheckClassRoom = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.CheckClassRoom];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.CheckClassRoom, objvCurrEduCls4Synch_Cond.CheckClassRoom, strComparisonOp_CheckClassRoom);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.CheckAdminCls) == true)
{
string strComparisonOp_CheckAdminCls = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.CheckAdminCls];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.CheckAdminCls, objvCurrEduCls4Synch_Cond.CheckAdminCls, strComparisonOp_CheckAdminCls);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.CheckTeacher) == true)
{
string strComparisonOp_CheckTeacher = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.CheckTeacher];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.CheckTeacher, objvCurrEduCls4Synch_Cond.CheckTeacher, strComparisonOp_CheckTeacher);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.EditLocked) == true)
{
if (objvCurrEduCls4Synch_Cond.EditLocked == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduCls4Synch.EditLocked);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduCls4Synch.EditLocked);
}
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.Sched) == true)
{
if (objvCurrEduCls4Synch_Cond.Sched == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduCls4Synch.Sched);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduCls4Synch.Sched);
}
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.id_UniZone) == true)
{
string strComparisonOp_id_UniZone = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.id_UniZone];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.id_UniZone, objvCurrEduCls4Synch_Cond.id_UniZone, strComparisonOp_id_UniZone);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.Locked) == true)
{
if (objvCurrEduCls4Synch_Cond.Locked == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduCls4Synch.Locked);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduCls4Synch.Locked);
}
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.id_GradeBase) == true)
{
string strComparisonOp_id_GradeBase = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.id_GradeBase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.id_GradeBase, objvCurrEduCls4Synch_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.GradeBaseID) == true)
{
string strComparisonOp_GradeBaseID = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.GradeBaseID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.GradeBaseID, objvCurrEduCls4Synch_Cond.GradeBaseID, strComparisonOp_GradeBaseID);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.GradeBaseName) == true)
{
string strComparisonOp_GradeBaseName = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.GradeBaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.GradeBaseName, objvCurrEduCls4Synch_Cond.GradeBaseName, strComparisonOp_GradeBaseName);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.GradeBaseNameA) == true)
{
string strComparisonOp_GradeBaseNameA = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.GradeBaseNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.GradeBaseNameA, objvCurrEduCls4Synch_Cond.GradeBaseNameA, strComparisonOp_GradeBaseNameA);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.IsEffective) == true)
{
if (objvCurrEduCls4Synch_Cond.IsEffective == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduCls4Synch.IsEffective);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduCls4Synch.IsEffective);
}
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.IsUnDeterminedClsRm) == true)
{
if (objvCurrEduCls4Synch_Cond.IsUnDeterminedClsRm == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduCls4Synch.IsUnDeterminedClsRm);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduCls4Synch.IsUnDeterminedClsRm);
}
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.SchoolYear) == true)
{
string strComparisonOp_SchoolYear = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.SchoolYear];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.SchoolYear, objvCurrEduCls4Synch_Cond.SchoolYear, strComparisonOp_SchoolYear);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.SchoolTerm) == true)
{
string strComparisonOp_SchoolTerm = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.SchoolTerm];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.SchoolTerm, objvCurrEduCls4Synch_Cond.SchoolTerm, strComparisonOp_SchoolTerm);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.ArrangeCourseMemo) == true)
{
string strComparisonOp_ArrangeCourseMemo = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.ArrangeCourseMemo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.ArrangeCourseMemo, objvCurrEduCls4Synch_Cond.ArrangeCourseMemo, strComparisonOp_ArrangeCourseMemo);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.id_CourseType) == true)
{
string strComparisonOp_id_CourseType = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.id_CourseType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.id_CourseType, objvCurrEduCls4Synch_Cond.id_CourseType, strComparisonOp_id_CourseType);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.CourseTypeID) == true)
{
string strComparisonOp_CourseTypeID = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.CourseTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.CourseTypeID, objvCurrEduCls4Synch_Cond.CourseTypeID, strComparisonOp_CourseTypeID);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.CourseTypeName) == true)
{
string strComparisonOp_CourseTypeName = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.CourseTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.CourseTypeName, objvCurrEduCls4Synch_Cond.CourseTypeName, strComparisonOp_CourseTypeName);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.IsDegree) == true)
{
if (objvCurrEduCls4Synch_Cond.IsDegree == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduCls4Synch.IsDegree);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduCls4Synch.IsDegree);
}
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.id_ScoreType) == true)
{
string strComparisonOp_id_ScoreType = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.id_ScoreType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.id_ScoreType, objvCurrEduCls4Synch_Cond.id_ScoreType, strComparisonOp_id_ScoreType);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.GetScoreWayId) == true)
{
string strComparisonOp_GetScoreWayId = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.GetScoreWayId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.GetScoreWayId, objvCurrEduCls4Synch_Cond.GetScoreWayId, strComparisonOp_GetScoreWayId);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.IsProportionalCtrl) == true)
{
if (objvCurrEduCls4Synch_Cond.IsProportionalCtrl == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduCls4Synch.IsProportionalCtrl);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduCls4Synch.IsProportionalCtrl);
}
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.IsSynchToWeb) == true)
{
if (objvCurrEduCls4Synch_Cond.IsSynchToWeb == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduCls4Synch.IsSynchToWeb);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduCls4Synch.IsSynchToWeb);
}
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.SynchToWebDate) == true)
{
string strComparisonOp_SynchToWebDate = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.SynchToWebDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.SynchToWebDate, objvCurrEduCls4Synch_Cond.SynchToWebDate, strComparisonOp_SynchToWebDate);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.SynchToWebUser) == true)
{
string strComparisonOp_SynchToWebUser = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.SynchToWebUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.SynchToWebUser, objvCurrEduCls4Synch_Cond.SynchToWebUser, strComparisonOp_SynchToWebUser);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.SignInDate) == true)
{
string strComparisonOp_SignInDate = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.SignInDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.SignInDate, objvCurrEduCls4Synch_Cond.SignInDate, strComparisonOp_SignInDate);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.SignInStateID) == true)
{
string strComparisonOp_SignInStateID = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.SignInStateID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.SignInStateID, objvCurrEduCls4Synch_Cond.SignInStateID, strComparisonOp_SignInStateID);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.SignInUser) == true)
{
string strComparisonOp_SignInUser = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.SignInUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.SignInUser, objvCurrEduCls4Synch_Cond.SignInUser, strComparisonOp_SignInUser);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.id_ExamType) == true)
{
string strComparisonOp_id_ExamType = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.id_ExamType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.id_ExamType, objvCurrEduCls4Synch_Cond.id_ExamType, strComparisonOp_id_ExamType);
}
//数据类型short(smallint)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
//数据类型short(smallint)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.IsClearScore) == true)
{
if (objvCurrEduCls4Synch_Cond.IsClearScore == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduCls4Synch.IsClearScore);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduCls4Synch.IsClearScore);
}
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.IsGeneratePwd) == true)
{
if (objvCurrEduCls4Synch_Cond.IsGeneratePwd == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduCls4Synch.IsGeneratePwd);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduCls4Synch.IsGeneratePwd);
}
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.GeneratePwdDate) == true)
{
string strComparisonOp_GeneratePwdDate = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.GeneratePwdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.GeneratePwdDate, objvCurrEduCls4Synch_Cond.GeneratePwdDate, strComparisonOp_GeneratePwdDate);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.PkWeekTime) == true)
{
string strComparisonOp_PkWeekTime = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.PkWeekTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.PkWeekTime, objvCurrEduCls4Synch_Cond.PkWeekTime, strComparisonOp_PkWeekTime);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.PkClassRooms) == true)
{
string strComparisonOp_PkClassRooms = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.PkClassRooms];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.PkClassRooms, objvCurrEduCls4Synch_Cond.PkClassRooms, strComparisonOp_PkClassRooms);
}
//数据类型short(smallint)在函数:[AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj]中没有处理！
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.TeacherNames) == true)
{
string strComparisonOp_TeacherNames = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.TeacherNames];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.TeacherNames, objvCurrEduCls4Synch_Cond.TeacherNames, strComparisonOp_TeacherNames);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.IsAccessSynch) == true)
{
if (objvCurrEduCls4Synch_Cond.IsAccessSynch == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduCls4Synch.IsAccessSynch);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduCls4Synch.IsAccessSynch);
}
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.AccessSynchDate) == true)
{
string strComparisonOp_AccessSynchDate = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.AccessSynchDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.AccessSynchDate, objvCurrEduCls4Synch_Cond.AccessSynchDate, strComparisonOp_AccessSynchDate);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.IsExistEduClsInCurr) == true)
{
if (objvCurrEduCls4Synch_Cond.IsExistEduClsInCurr == true)
{
strWhereCond += string.Format(" And {0} = '1'", convCurrEduCls4Synch.IsExistEduClsInCurr);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convCurrEduCls4Synch.IsExistEduClsInCurr);
}
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.ModifyDate) == true)
{
string strComparisonOp_ModifyDate = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.ModifyDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.ModifyDate, objvCurrEduCls4Synch_Cond.ModifyDate, strComparisonOp_ModifyDate);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.ModifyUserID) == true)
{
string strComparisonOp_ModifyUserID = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.ModifyUserID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.ModifyUserID, objvCurrEduCls4Synch_Cond.ModifyUserID, strComparisonOp_ModifyUserID);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.Memo) == true)
{
string strComparisonOp_Memo = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCurrEduCls4Synch.Memo, objvCurrEduCls4Synch_Cond.Memo, strComparisonOp_Memo);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.CurrStuNum_Valid) == true)
{
string strComparisonOp_CurrStuNum_Valid = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.CurrStuNum_Valid];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduCls4Synch.CurrStuNum_Valid, objvCurrEduCls4Synch_Cond.CurrStuNum_Valid, strComparisonOp_CurrStuNum_Valid);
}
if (objvCurrEduCls4Synch_Cond.IsUpdated(convCurrEduCls4Synch.CurrStuNum) == true)
{
string strComparisonOp_CurrStuNum = objvCurrEduCls4Synch_Cond.dicFldComparisonOp[convCurrEduCls4Synch.CurrStuNum];
strWhereCond += string.Format(" And {0} {2} {1}", convCurrEduCls4Synch.CurrStuNum, objvCurrEduCls4Synch_Cond.CurrStuNum, strComparisonOp_CurrStuNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v当前教学班_同步(vCurrEduCls4Synch)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvCurrEduCls4SynchWApi
{
private static readonly string mstrApiControllerName = "vCurrEduCls4SynchApi";

 public clsvCurrEduCls4SynchWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCurrEduCls4SynchEN GetObjBymId(long lngmId)
{
string strAction = "GetObjBymId";
string strErrMsg = string.Empty;
string strResult = "";
clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN = null;
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
objvCurrEduCls4SynchEN = JsonConvert.DeserializeObject<clsvCurrEduCls4SynchEN>((string)jobjReturn["ReturnObj"]);
return objvCurrEduCls4SynchEN;
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
public static clsvCurrEduCls4SynchEN GetObjBymId_WA_Cache(long lngmId)
{
string strAction = "GetObjBymId_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN = null;
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
objvCurrEduCls4SynchEN = JsonConvert.DeserializeObject<clsvCurrEduCls4SynchEN>((string)jobjReturn["ReturnObj"]);
return objvCurrEduCls4SynchEN;
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
public static clsvCurrEduCls4SynchEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvCurrEduCls4SynchEN objvCurrEduCls4SynchEN = null;
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
objvCurrEduCls4SynchEN = JsonConvert.DeserializeObject<clsvCurrEduCls4SynchEN>((string)jobjReturn["ReturnObj"]);
return objvCurrEduCls4SynchEN;
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
public static clsvCurrEduCls4SynchEN GetObjBymId_Cache(long lngmId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCurrEduCls4SynchEN._CurrTabName_S);
List<clsvCurrEduCls4SynchEN> arrvCurrEduCls4SynchObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCurrEduCls4SynchEN> arrvCurrEduCls4SynchObjLst_Sel =
from objvCurrEduCls4SynchEN in arrvCurrEduCls4SynchObjLst_Cache
where objvCurrEduCls4SynchEN.mId == lngmId
select objvCurrEduCls4SynchEN;
if (arrvCurrEduCls4SynchObjLst_Sel.Count() == 0)
{
   clsvCurrEduCls4SynchEN obj = clsvCurrEduCls4SynchWApi.GetObjBymId(lngmId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvCurrEduCls4SynchObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCurrEduCls4SynchEN> GetObjLst(string strWhereCond)
{
 List<clsvCurrEduCls4SynchEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduCls4SynchEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCurrEduCls4SynchEN> GetObjLstByMIdLst(List<long> arrMId)
{
 List<clsvCurrEduCls4SynchEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduCls4SynchEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvCurrEduCls4SynchEN> GetObjLstByMIdLst_Cache(List<long> arrMId)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvCurrEduCls4SynchEN._CurrTabName_S);
List<clsvCurrEduCls4SynchEN> arrvCurrEduCls4SynchObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvCurrEduCls4SynchEN> arrvCurrEduCls4SynchObjLst_Sel =
from objvCurrEduCls4SynchEN in arrvCurrEduCls4SynchObjLst_Cache
where arrMId.Contains(objvCurrEduCls4SynchEN.mId)
select objvCurrEduCls4SynchEN;
return arrvCurrEduCls4SynchObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCurrEduCls4SynchEN> GetObjLstByMIdLst_WA_Cache(List<long> arrMId)
{
 List<clsvCurrEduCls4SynchEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduCls4SynchEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCurrEduCls4SynchEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvCurrEduCls4SynchEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduCls4SynchEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCurrEduCls4SynchEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvCurrEduCls4SynchEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduCls4SynchEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCurrEduCls4SynchEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvCurrEduCls4SynchEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduCls4SynchEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvCurrEduCls4SynchEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvCurrEduCls4SynchEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvCurrEduCls4SynchEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvCurrEduCls4SynchENS">源对象</param>
 /// <param name = "objvCurrEduCls4SynchENT">目标对象</param>
 public static void CopyTo(clsvCurrEduCls4SynchEN objvCurrEduCls4SynchENS, clsvCurrEduCls4SynchEN objvCurrEduCls4SynchENT)
{
try
{
objvCurrEduCls4SynchENT.mId = objvCurrEduCls4SynchENS.mId; //mId
objvCurrEduCls4SynchENT.IpAddress = objvCurrEduCls4SynchENS.IpAddress; //Ip地址
objvCurrEduCls4SynchENT.id_CurrEduCls = objvCurrEduCls4SynchENS.id_CurrEduCls; //当前教学班流水号
objvCurrEduCls4SynchENT.CurrEduClsId = objvCurrEduCls4SynchENS.CurrEduClsId; //当前教学班Id
objvCurrEduCls4SynchENT.EduClsName = objvCurrEduCls4SynchENS.EduClsName; //教学班名称
objvCurrEduCls4SynchENT.EduClsTypeId = objvCurrEduCls4SynchENS.EduClsTypeId; //教学班类型代号
objvCurrEduCls4SynchENT.CourseId = objvCurrEduCls4SynchENS.CourseId; //课程Id
objvCurrEduCls4SynchENT.CourseCode = objvCurrEduCls4SynchENS.CourseCode; //课程代码
objvCurrEduCls4SynchENT.CourseDescription = objvCurrEduCls4SynchENS.CourseDescription; //课程描述
objvCurrEduCls4SynchENT.CourseName = objvCurrEduCls4SynchENS.CourseName; //课程名称
objvCurrEduCls4SynchENT.ExampleImgPath = objvCurrEduCls4SynchENS.ExampleImgPath; //示例图路径
objvCurrEduCls4SynchENT.ViewCount = objvCurrEduCls4SynchENS.ViewCount; //浏览量
objvCurrEduCls4SynchENT.TeachingSolutionId = objvCurrEduCls4SynchENS.TeachingSolutionId; //教学方案Id
objvCurrEduCls4SynchENT.TeachingSolutionName = objvCurrEduCls4SynchENS.TeachingSolutionName; //教学方案名称
objvCurrEduCls4SynchENT.id_Teacher = objvCurrEduCls4SynchENS.id_Teacher; //教师流水号
objvCurrEduCls4SynchENT.TeacherID = objvCurrEduCls4SynchENS.TeacherID; //教师工号
objvCurrEduCls4SynchENT.TeacherName = objvCurrEduCls4SynchENS.TeacherName; //教师姓名
objvCurrEduCls4SynchENT.id_XzCollege = objvCurrEduCls4SynchENS.id_XzCollege; //学院流水号
objvCurrEduCls4SynchENT.CollegeID = objvCurrEduCls4SynchENS.CollegeID; //学院ID
objvCurrEduCls4SynchENT.CollegeName = objvCurrEduCls4SynchENS.CollegeName; //学院名称
objvCurrEduCls4SynchENT.ClgEnglishName = objvCurrEduCls4SynchENS.ClgEnglishName; //ClgEnglishName
objvCurrEduCls4SynchENT.PhoneNumber = objvCurrEduCls4SynchENS.PhoneNumber; //PhoneNumber
objvCurrEduCls4SynchENT.id_EduWay = objvCurrEduCls4SynchENS.id_EduWay; //教学方式流水号
objvCurrEduCls4SynchENT.id_ClassRoomType = objvCurrEduCls4SynchENS.id_ClassRoomType; //教室类型流水号
objvCurrEduCls4SynchENT.TotalLessonQty = objvCurrEduCls4SynchENS.TotalLessonQty; //总课时数
objvCurrEduCls4SynchENT.MaxStuQty = objvCurrEduCls4SynchENS.MaxStuQty; //最大学生数
objvCurrEduCls4SynchENT.WeekQty = objvCurrEduCls4SynchENS.WeekQty; //总周数
objvCurrEduCls4SynchENT.ScheUnitPW = objvCurrEduCls4SynchENS.ScheUnitPW; //周排课次数
objvCurrEduCls4SynchENT.WeekStatusID = objvCurrEduCls4SynchENS.WeekStatusID; //周状态编号(单,双,全周)
objvCurrEduCls4SynchENT.CustomerWeek = objvCurrEduCls4SynchENS.CustomerWeek; //自定义上课周
objvCurrEduCls4SynchENT.IsCompleteScore = objvCurrEduCls4SynchENS.IsCompleteScore; //是否成绩齐全
objvCurrEduCls4SynchENT.id_ExecPlan = objvCurrEduCls4SynchENS.id_ExecPlan; //执行计划流水号
objvCurrEduCls4SynchENT.LessonQtyPerWeek = objvCurrEduCls4SynchENS.LessonQtyPerWeek; //周课时数
objvCurrEduCls4SynchENT.Mark = objvCurrEduCls4SynchENS.Mark; //获得学分
objvCurrEduCls4SynchENT.CheckClassRoom = objvCurrEduCls4SynchENS.CheckClassRoom; //检查教室结果
objvCurrEduCls4SynchENT.CheckAdminCls = objvCurrEduCls4SynchENS.CheckAdminCls; //检查行政班结果
objvCurrEduCls4SynchENT.CheckTeacher = objvCurrEduCls4SynchENS.CheckTeacher; //检查教师结果
objvCurrEduCls4SynchENT.EditLocked = objvCurrEduCls4SynchENS.EditLocked; //编辑锁定
objvCurrEduCls4SynchENT.Sched = objvCurrEduCls4SynchENS.Sched; //是否排课
objvCurrEduCls4SynchENT.id_UniZone = objvCurrEduCls4SynchENS.id_UniZone; //校区流水号
objvCurrEduCls4SynchENT.Locked = objvCurrEduCls4SynchENS.Locked; //锁定状态
objvCurrEduCls4SynchENT.id_GradeBase = objvCurrEduCls4SynchENS.id_GradeBase; //年级流水号
objvCurrEduCls4SynchENT.GradeBaseID = objvCurrEduCls4SynchENS.GradeBaseID; //年级代号
objvCurrEduCls4SynchENT.GradeBaseName = objvCurrEduCls4SynchENS.GradeBaseName; //年级名称
objvCurrEduCls4SynchENT.GradeBaseNameA = objvCurrEduCls4SynchENS.GradeBaseNameA; //年级名称缩写
objvCurrEduCls4SynchENT.IsEffective = objvCurrEduCls4SynchENS.IsEffective; //是否有效
objvCurrEduCls4SynchENT.IsUnDeterminedClsRm = objvCurrEduCls4SynchENS.IsUnDeterminedClsRm; //是否待定教室
objvCurrEduCls4SynchENT.SchoolYear = objvCurrEduCls4SynchENS.SchoolYear; //学年
objvCurrEduCls4SynchENT.SchoolTerm = objvCurrEduCls4SynchENS.SchoolTerm; //学期
objvCurrEduCls4SynchENT.ArrangeCourseMemo = objvCurrEduCls4SynchENS.ArrangeCourseMemo; //排课备注
objvCurrEduCls4SynchENT.id_CourseType = objvCurrEduCls4SynchENS.id_CourseType; //课程类型流水号
objvCurrEduCls4SynchENT.CourseTypeID = objvCurrEduCls4SynchENS.CourseTypeID; //课程类型ID
objvCurrEduCls4SynchENT.CourseTypeName = objvCurrEduCls4SynchENS.CourseTypeName; //课程类型名称
objvCurrEduCls4SynchENT.IsDegree = objvCurrEduCls4SynchENS.IsDegree; //是否学位课
objvCurrEduCls4SynchENT.id_ScoreType = objvCurrEduCls4SynchENS.id_ScoreType; //成绩类型流水号
objvCurrEduCls4SynchENT.GetScoreWayId = objvCurrEduCls4SynchENS.GetScoreWayId; //获得成绩方式Id
objvCurrEduCls4SynchENT.IsProportionalCtrl = objvCurrEduCls4SynchENS.IsProportionalCtrl; //是否比例控制
objvCurrEduCls4SynchENT.IsSynchToWeb = objvCurrEduCls4SynchENS.IsSynchToWeb; //是否同步Web
objvCurrEduCls4SynchENT.SynchToWebDate = objvCurrEduCls4SynchENS.SynchToWebDate; //同步Web日期
objvCurrEduCls4SynchENT.SynchToWebUser = objvCurrEduCls4SynchENS.SynchToWebUser; //同步Web用户
objvCurrEduCls4SynchENT.SignInDate = objvCurrEduCls4SynchENS.SignInDate; //签入时间
objvCurrEduCls4SynchENT.SignInStateID = objvCurrEduCls4SynchENS.SignInStateID; //签入状态表流水号
objvCurrEduCls4SynchENT.SignInUser = objvCurrEduCls4SynchENS.SignInUser; //签入人
objvCurrEduCls4SynchENT.id_ExamType = objvCurrEduCls4SynchENS.id_ExamType; //考试方式流水号
objvCurrEduCls4SynchENT.ExamPortion = objvCurrEduCls4SynchENS.ExamPortion; //平时成绩所占比例
objvCurrEduCls4SynchENT.MidExamScorePortion = objvCurrEduCls4SynchENS.MidExamScorePortion; //期末成绩所占比例
objvCurrEduCls4SynchENT.IsClearScore = objvCurrEduCls4SynchENS.IsClearScore; //是否重录成绩
objvCurrEduCls4SynchENT.IsGeneratePwd = objvCurrEduCls4SynchENS.IsGeneratePwd; //是否生成口令
objvCurrEduCls4SynchENT.GeneratePwdDate = objvCurrEduCls4SynchENS.GeneratePwdDate; //生成口令时间
objvCurrEduCls4SynchENT.PkWeekTime = objvCurrEduCls4SynchENS.PkWeekTime; //排课时间
objvCurrEduCls4SynchENT.PkClassRooms = objvCurrEduCls4SynchENS.PkClassRooms; //排课教室
objvCurrEduCls4SynchENT.BeginWeek = objvCurrEduCls4SynchENS.BeginWeek; //开始周
objvCurrEduCls4SynchENT.TeacherNames = objvCurrEduCls4SynchENS.TeacherNames; //教师姓名
objvCurrEduCls4SynchENT.IsAccessSynch = objvCurrEduCls4SynchENS.IsAccessSynch; //是否处理同步
objvCurrEduCls4SynchENT.AccessSynchDate = objvCurrEduCls4SynchENS.AccessSynchDate; //处理同步日期
objvCurrEduCls4SynchENT.IsExistEduClsInCurr = objvCurrEduCls4SynchENS.IsExistEduClsInCurr; //当前是否存在教学班
objvCurrEduCls4SynchENT.ModifyDate = objvCurrEduCls4SynchENS.ModifyDate; //修改日期
objvCurrEduCls4SynchENT.ModifyUserID = objvCurrEduCls4SynchENS.ModifyUserID; //修改人
objvCurrEduCls4SynchENT.Memo = objvCurrEduCls4SynchENS.Memo; //备注
objvCurrEduCls4SynchENT.CurrStuNum_Valid = objvCurrEduCls4SynchENS.CurrStuNum_Valid; //CurrStuNum_Valid
objvCurrEduCls4SynchENT.CurrStuNum = objvCurrEduCls4SynchENS.CurrStuNum; //当前学生数
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
public static DataTable ToDataTable(List<clsvCurrEduCls4SynchEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvCurrEduCls4SynchEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvCurrEduCls4SynchEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvCurrEduCls4SynchEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvCurrEduCls4SynchEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvCurrEduCls4SynchEN.AttributeName)
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
if (clsXzGradeBaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseWApi没有刷新缓存机制(clsXzGradeBaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCurrEduCls4SynchWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCurrEduCls4SynchWApi没有刷新缓存机制(clsCurrEduCls4SynchWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvCurrEduCls4SynchObjLst_Cache == null)
//{
//arrvCurrEduCls4SynchObjLst_Cache = await clsvCurrEduCls4SynchWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvCurrEduCls4SynchEN._CurrTabName_S);
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
public static List<clsvCurrEduCls4SynchEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvCurrEduCls4SynchEN._CurrTabName_S);
List<clsvCurrEduCls4SynchEN> arrvCurrEduCls4SynchObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvCurrEduCls4SynchObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvCurrEduCls4SynchEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convCurrEduCls4Synch.mId, Type.GetType("System.Int64"));
objDT.Columns.Add(convCurrEduCls4Synch.IpAddress, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.id_CurrEduCls, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.CurrEduClsId, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.EduClsName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.EduClsTypeId, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.CourseDescription, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.ExampleImgPath, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.ViewCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convCurrEduCls4Synch.TeachingSolutionId, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.TeachingSolutionName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.id_Teacher, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.TeacherID, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.TeacherName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.ClgEnglishName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.PhoneNumber, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.id_EduWay, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.id_ClassRoomType, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.TotalLessonQty, Type.GetType("System.Int32"));
objDT.Columns.Add(convCurrEduCls4Synch.MaxStuQty, Type.GetType("System.Int32"));
objDT.Columns.Add(convCurrEduCls4Synch.WeekQty, Type.GetType("System.Int32"));
objDT.Columns.Add(convCurrEduCls4Synch.ScheUnitPW, Type.GetType("System.Int16"));
objDT.Columns.Add(convCurrEduCls4Synch.WeekStatusID, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.CustomerWeek, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.IsCompleteScore, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCurrEduCls4Synch.id_ExecPlan, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.LessonQtyPerWeek, Type.GetType("System.Int16"));
objDT.Columns.Add(convCurrEduCls4Synch.Mark, Type.GetType("System.Decimal"));
objDT.Columns.Add(convCurrEduCls4Synch.CheckClassRoom, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.CheckAdminCls, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.CheckTeacher, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.EditLocked, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCurrEduCls4Synch.Sched, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCurrEduCls4Synch.id_UniZone, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.Locked, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCurrEduCls4Synch.id_GradeBase, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.GradeBaseID, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.GradeBaseName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.GradeBaseNameA, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.IsEffective, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCurrEduCls4Synch.IsUnDeterminedClsRm, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCurrEduCls4Synch.SchoolYear, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.SchoolTerm, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.ArrangeCourseMemo, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.id_CourseType, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.CourseTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.CourseTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.IsDegree, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCurrEduCls4Synch.id_ScoreType, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.GetScoreWayId, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.IsProportionalCtrl, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCurrEduCls4Synch.IsSynchToWeb, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCurrEduCls4Synch.SynchToWebDate, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.SynchToWebUser, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.SignInDate, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.SignInStateID, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.SignInUser, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.id_ExamType, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.ExamPortion, Type.GetType("System.Int16"));
objDT.Columns.Add(convCurrEduCls4Synch.MidExamScorePortion, Type.GetType("System.Int16"));
objDT.Columns.Add(convCurrEduCls4Synch.IsClearScore, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCurrEduCls4Synch.IsGeneratePwd, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCurrEduCls4Synch.GeneratePwdDate, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.PkWeekTime, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.PkClassRooms, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.BeginWeek, Type.GetType("System.Int16"));
objDT.Columns.Add(convCurrEduCls4Synch.TeacherNames, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.IsAccessSynch, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCurrEduCls4Synch.AccessSynchDate, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.IsExistEduClsInCurr, Type.GetType("System.Boolean"));
objDT.Columns.Add(convCurrEduCls4Synch.ModifyDate, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.ModifyUserID, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.Memo, Type.GetType("System.String"));
objDT.Columns.Add(convCurrEduCls4Synch.CurrStuNum_Valid, Type.GetType("System.Int32"));
objDT.Columns.Add(convCurrEduCls4Synch.CurrStuNum, Type.GetType("System.Int32"));
foreach (clsvCurrEduCls4SynchEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convCurrEduCls4Synch.mId] = objInFor[convCurrEduCls4Synch.mId];
objDR[convCurrEduCls4Synch.IpAddress] = objInFor[convCurrEduCls4Synch.IpAddress];
objDR[convCurrEduCls4Synch.id_CurrEduCls] = objInFor[convCurrEduCls4Synch.id_CurrEduCls];
objDR[convCurrEduCls4Synch.CurrEduClsId] = objInFor[convCurrEduCls4Synch.CurrEduClsId];
objDR[convCurrEduCls4Synch.EduClsName] = objInFor[convCurrEduCls4Synch.EduClsName];
objDR[convCurrEduCls4Synch.EduClsTypeId] = objInFor[convCurrEduCls4Synch.EduClsTypeId];
objDR[convCurrEduCls4Synch.CourseId] = objInFor[convCurrEduCls4Synch.CourseId];
objDR[convCurrEduCls4Synch.CourseCode] = objInFor[convCurrEduCls4Synch.CourseCode];
objDR[convCurrEduCls4Synch.CourseDescription] = objInFor[convCurrEduCls4Synch.CourseDescription];
objDR[convCurrEduCls4Synch.CourseName] = objInFor[convCurrEduCls4Synch.CourseName];
objDR[convCurrEduCls4Synch.ExampleImgPath] = objInFor[convCurrEduCls4Synch.ExampleImgPath];
objDR[convCurrEduCls4Synch.ViewCount] = objInFor[convCurrEduCls4Synch.ViewCount];
objDR[convCurrEduCls4Synch.TeachingSolutionId] = objInFor[convCurrEduCls4Synch.TeachingSolutionId];
objDR[convCurrEduCls4Synch.TeachingSolutionName] = objInFor[convCurrEduCls4Synch.TeachingSolutionName];
objDR[convCurrEduCls4Synch.id_Teacher] = objInFor[convCurrEduCls4Synch.id_Teacher];
objDR[convCurrEduCls4Synch.TeacherID] = objInFor[convCurrEduCls4Synch.TeacherID];
objDR[convCurrEduCls4Synch.TeacherName] = objInFor[convCurrEduCls4Synch.TeacherName];
objDR[convCurrEduCls4Synch.id_XzCollege] = objInFor[convCurrEduCls4Synch.id_XzCollege];
objDR[convCurrEduCls4Synch.CollegeID] = objInFor[convCurrEduCls4Synch.CollegeID];
objDR[convCurrEduCls4Synch.CollegeName] = objInFor[convCurrEduCls4Synch.CollegeName];
objDR[convCurrEduCls4Synch.ClgEnglishName] = objInFor[convCurrEduCls4Synch.ClgEnglishName];
objDR[convCurrEduCls4Synch.PhoneNumber] = objInFor[convCurrEduCls4Synch.PhoneNumber];
objDR[convCurrEduCls4Synch.id_EduWay] = objInFor[convCurrEduCls4Synch.id_EduWay];
objDR[convCurrEduCls4Synch.id_ClassRoomType] = objInFor[convCurrEduCls4Synch.id_ClassRoomType];
objDR[convCurrEduCls4Synch.TotalLessonQty] = objInFor[convCurrEduCls4Synch.TotalLessonQty];
objDR[convCurrEduCls4Synch.MaxStuQty] = objInFor[convCurrEduCls4Synch.MaxStuQty];
objDR[convCurrEduCls4Synch.WeekQty] = objInFor[convCurrEduCls4Synch.WeekQty];
objDR[convCurrEduCls4Synch.ScheUnitPW] = objInFor[convCurrEduCls4Synch.ScheUnitPW];
objDR[convCurrEduCls4Synch.WeekStatusID] = objInFor[convCurrEduCls4Synch.WeekStatusID];
objDR[convCurrEduCls4Synch.CustomerWeek] = objInFor[convCurrEduCls4Synch.CustomerWeek];
objDR[convCurrEduCls4Synch.IsCompleteScore] = objInFor[convCurrEduCls4Synch.IsCompleteScore];
objDR[convCurrEduCls4Synch.id_ExecPlan] = objInFor[convCurrEduCls4Synch.id_ExecPlan];
objDR[convCurrEduCls4Synch.LessonQtyPerWeek] = objInFor[convCurrEduCls4Synch.LessonQtyPerWeek];
objDR[convCurrEduCls4Synch.Mark] = objInFor[convCurrEduCls4Synch.Mark];
objDR[convCurrEduCls4Synch.CheckClassRoom] = objInFor[convCurrEduCls4Synch.CheckClassRoom];
objDR[convCurrEduCls4Synch.CheckAdminCls] = objInFor[convCurrEduCls4Synch.CheckAdminCls];
objDR[convCurrEduCls4Synch.CheckTeacher] = objInFor[convCurrEduCls4Synch.CheckTeacher];
objDR[convCurrEduCls4Synch.EditLocked] = objInFor[convCurrEduCls4Synch.EditLocked];
objDR[convCurrEduCls4Synch.Sched] = objInFor[convCurrEduCls4Synch.Sched];
objDR[convCurrEduCls4Synch.id_UniZone] = objInFor[convCurrEduCls4Synch.id_UniZone];
objDR[convCurrEduCls4Synch.Locked] = objInFor[convCurrEduCls4Synch.Locked];
objDR[convCurrEduCls4Synch.id_GradeBase] = objInFor[convCurrEduCls4Synch.id_GradeBase];
objDR[convCurrEduCls4Synch.GradeBaseID] = objInFor[convCurrEduCls4Synch.GradeBaseID];
objDR[convCurrEduCls4Synch.GradeBaseName] = objInFor[convCurrEduCls4Synch.GradeBaseName];
objDR[convCurrEduCls4Synch.GradeBaseNameA] = objInFor[convCurrEduCls4Synch.GradeBaseNameA];
objDR[convCurrEduCls4Synch.IsEffective] = objInFor[convCurrEduCls4Synch.IsEffective];
objDR[convCurrEduCls4Synch.IsUnDeterminedClsRm] = objInFor[convCurrEduCls4Synch.IsUnDeterminedClsRm];
objDR[convCurrEduCls4Synch.SchoolYear] = objInFor[convCurrEduCls4Synch.SchoolYear];
objDR[convCurrEduCls4Synch.SchoolTerm] = objInFor[convCurrEduCls4Synch.SchoolTerm];
objDR[convCurrEduCls4Synch.ArrangeCourseMemo] = objInFor[convCurrEduCls4Synch.ArrangeCourseMemo];
objDR[convCurrEduCls4Synch.id_CourseType] = objInFor[convCurrEduCls4Synch.id_CourseType];
objDR[convCurrEduCls4Synch.CourseTypeID] = objInFor[convCurrEduCls4Synch.CourseTypeID];
objDR[convCurrEduCls4Synch.CourseTypeName] = objInFor[convCurrEduCls4Synch.CourseTypeName];
objDR[convCurrEduCls4Synch.IsDegree] = objInFor[convCurrEduCls4Synch.IsDegree];
objDR[convCurrEduCls4Synch.id_ScoreType] = objInFor[convCurrEduCls4Synch.id_ScoreType];
objDR[convCurrEduCls4Synch.GetScoreWayId] = objInFor[convCurrEduCls4Synch.GetScoreWayId];
objDR[convCurrEduCls4Synch.IsProportionalCtrl] = objInFor[convCurrEduCls4Synch.IsProportionalCtrl];
objDR[convCurrEduCls4Synch.IsSynchToWeb] = objInFor[convCurrEduCls4Synch.IsSynchToWeb];
objDR[convCurrEduCls4Synch.SynchToWebDate] = objInFor[convCurrEduCls4Synch.SynchToWebDate];
objDR[convCurrEduCls4Synch.SynchToWebUser] = objInFor[convCurrEduCls4Synch.SynchToWebUser];
objDR[convCurrEduCls4Synch.SignInDate] = objInFor[convCurrEduCls4Synch.SignInDate];
objDR[convCurrEduCls4Synch.SignInStateID] = objInFor[convCurrEduCls4Synch.SignInStateID];
objDR[convCurrEduCls4Synch.SignInUser] = objInFor[convCurrEduCls4Synch.SignInUser];
objDR[convCurrEduCls4Synch.id_ExamType] = objInFor[convCurrEduCls4Synch.id_ExamType];
objDR[convCurrEduCls4Synch.ExamPortion] = objInFor[convCurrEduCls4Synch.ExamPortion];
objDR[convCurrEduCls4Synch.MidExamScorePortion] = objInFor[convCurrEduCls4Synch.MidExamScorePortion];
objDR[convCurrEduCls4Synch.IsClearScore] = objInFor[convCurrEduCls4Synch.IsClearScore];
objDR[convCurrEduCls4Synch.IsGeneratePwd] = objInFor[convCurrEduCls4Synch.IsGeneratePwd];
objDR[convCurrEduCls4Synch.GeneratePwdDate] = objInFor[convCurrEduCls4Synch.GeneratePwdDate];
objDR[convCurrEduCls4Synch.PkWeekTime] = objInFor[convCurrEduCls4Synch.PkWeekTime];
objDR[convCurrEduCls4Synch.PkClassRooms] = objInFor[convCurrEduCls4Synch.PkClassRooms];
objDR[convCurrEduCls4Synch.BeginWeek] = objInFor[convCurrEduCls4Synch.BeginWeek];
objDR[convCurrEduCls4Synch.TeacherNames] = objInFor[convCurrEduCls4Synch.TeacherNames];
objDR[convCurrEduCls4Synch.IsAccessSynch] = objInFor[convCurrEduCls4Synch.IsAccessSynch];
objDR[convCurrEduCls4Synch.AccessSynchDate] = objInFor[convCurrEduCls4Synch.AccessSynchDate];
objDR[convCurrEduCls4Synch.IsExistEduClsInCurr] = objInFor[convCurrEduCls4Synch.IsExistEduClsInCurr];
objDR[convCurrEduCls4Synch.ModifyDate] = objInFor[convCurrEduCls4Synch.ModifyDate];
objDR[convCurrEduCls4Synch.ModifyUserID] = objInFor[convCurrEduCls4Synch.ModifyUserID];
objDR[convCurrEduCls4Synch.Memo] = objInFor[convCurrEduCls4Synch.Memo];
objDR[convCurrEduCls4Synch.CurrStuNum_Valid] = objInFor[convCurrEduCls4Synch.CurrStuNum_Valid];
objDR[convCurrEduCls4Synch.CurrStuNum] = objInFor[convCurrEduCls4Synch.CurrStuNum];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}