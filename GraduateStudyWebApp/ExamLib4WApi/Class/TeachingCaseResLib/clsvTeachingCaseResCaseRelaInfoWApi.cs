
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvTeachingCaseResCaseRelaInfoWApi
 表名:vTeachingCaseResCaseRelaInfo(01120394)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:51:40
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:教学案例资源
 模块英文名:TeachingCaseResLib
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
public static class clsvTeachingCaseResCaseRelaInfoWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN Setid_MicroTeachCaseRelaInfo(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, long lngid_MicroTeachCaseRelaInfo, string strComparisonOp="")
	{
objvTeachingCaseResCaseRelaInfoEN.id_MicroTeachCaseRelaInfo = lngid_MicroTeachCaseRelaInfo; //案例相关信息流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.id_MicroTeachCaseRelaInfo) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.id_MicroTeachCaseRelaInfo, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.id_MicroTeachCaseRelaInfo] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetFuncModuleId(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convTeachingCaseResCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convTeachingCaseResCaseRelaInfo.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convTeachingCaseResCaseRelaInfo.FuncModuleId);
objvTeachingCaseResCaseRelaInfoEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.FuncModuleId) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.FuncModuleId, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.FuncModuleId] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetFuncModuleName(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convTeachingCaseResCaseRelaInfo.FuncModuleName);
objvTeachingCaseResCaseRelaInfoEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.FuncModuleName) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.FuncModuleName, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.FuncModuleName] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN Setid_MicroteachCase(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCase, convTeachingCaseResCaseRelaInfo.id_MicroteachCase);
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convTeachingCaseResCaseRelaInfo.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convTeachingCaseResCaseRelaInfo.id_MicroteachCase);
objvTeachingCaseResCaseRelaInfoEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.id_MicroteachCase) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.id_MicroteachCase, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.id_MicroteachCase] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetId_TeachingCaseResCase(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strId_TeachingCaseResCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_TeachingCaseResCase, 8, convTeachingCaseResCaseRelaInfo.Id_TeachingCaseResCase);
clsCheckSql.CheckFieldForeignKey(strId_TeachingCaseResCase, 8, convTeachingCaseResCaseRelaInfo.Id_TeachingCaseResCase);
objvTeachingCaseResCaseRelaInfoEN.Id_TeachingCaseResCase = strId_TeachingCaseResCase; //教学案例资源案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.Id_TeachingCaseResCase) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.Id_TeachingCaseResCase, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.Id_TeachingCaseResCase] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetTeachingCaseResCaseName(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strTeachingCaseResCaseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strTeachingCaseResCaseName, 100, convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName);
objvTeachingCaseResCaseRelaInfoEN.TeachingCaseResCaseName = strTeachingCaseResCaseName; //教学案例资源案例名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN Setid_XzCollege(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convTeachingCaseResCaseRelaInfo.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convTeachingCaseResCaseRelaInfo.id_XzCollege);
objvTeachingCaseResCaseRelaInfoEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.id_XzCollege) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.id_XzCollege, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.id_XzCollege] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetCollegeID(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convTeachingCaseResCaseRelaInfo.CollegeID);
objvTeachingCaseResCaseRelaInfoEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.CollegeID) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.CollegeID, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.CollegeID] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetCollegeName(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convTeachingCaseResCaseRelaInfo.CollegeName);
objvTeachingCaseResCaseRelaInfoEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.CollegeName) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.CollegeName, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.CollegeName] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetCollegeNameA(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convTeachingCaseResCaseRelaInfo.CollegeNameA);
objvTeachingCaseResCaseRelaInfoEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.CollegeNameA) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.CollegeNameA, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.CollegeNameA] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetMajorID(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strMajorID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorID, 4, convTeachingCaseResCaseRelaInfo.MajorID);
clsCheckSql.CheckFieldForeignKey(strMajorID, 4, convTeachingCaseResCaseRelaInfo.MajorID);
objvTeachingCaseResCaseRelaInfoEN.MajorID = strMajorID; //专业ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.MajorID) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.MajorID, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.MajorID] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetMajorName(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strMajorName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMajorName, 100, convTeachingCaseResCaseRelaInfo.MajorName);
objvTeachingCaseResCaseRelaInfoEN.MajorName = strMajorName; //专业名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.MajorName) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.MajorName, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.MajorName] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetCourseId(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convTeachingCaseResCaseRelaInfo.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convTeachingCaseResCaseRelaInfo.CourseId);
objvTeachingCaseResCaseRelaInfoEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.CourseId) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.CourseId, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.CourseId] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetCourseCode(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convTeachingCaseResCaseRelaInfo.CourseCode);
objvTeachingCaseResCaseRelaInfoEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.CourseCode) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.CourseCode, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.CourseCode] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetCourseName(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convTeachingCaseResCaseRelaInfo.CourseName);
objvTeachingCaseResCaseRelaInfoEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.CourseName) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.CourseName, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.CourseName] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN Setid_Resource(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strid_Resource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Resource, convTeachingCaseResCaseRelaInfo.id_Resource);
clsCheckSql.CheckFieldLen(strid_Resource, 8, convTeachingCaseResCaseRelaInfo.id_Resource);
clsCheckSql.CheckFieldForeignKey(strid_Resource, 8, convTeachingCaseResCaseRelaInfo.id_Resource);
objvTeachingCaseResCaseRelaInfoEN.id_Resource = strid_Resource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.id_Resource) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.id_Resource, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.id_Resource] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetResourceID(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceID, 8, convTeachingCaseResCaseRelaInfo.ResourceID);
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convTeachingCaseResCaseRelaInfo.ResourceID);
objvTeachingCaseResCaseRelaInfoEN.ResourceID = strResourceID; //资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.ResourceID) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.ResourceID, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.ResourceID] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN Setid_FtpResource(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strid_FtpResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_FtpResource, 8, convTeachingCaseResCaseRelaInfo.id_FtpResource);
clsCheckSql.CheckFieldForeignKey(strid_FtpResource, 8, convTeachingCaseResCaseRelaInfo.id_FtpResource);
objvTeachingCaseResCaseRelaInfoEN.id_FtpResource = strid_FtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.id_FtpResource) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.id_FtpResource, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.id_FtpResource] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN Setid_File(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strid_File, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_File, 8, convTeachingCaseResCaseRelaInfo.id_File);
clsCheckSql.CheckFieldForeignKey(strid_File, 8, convTeachingCaseResCaseRelaInfo.id_File);
objvTeachingCaseResCaseRelaInfoEN.id_File = strid_File; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.id_File) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.id_File, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.id_File] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetFileName(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName, 500, convTeachingCaseResCaseRelaInfo.FileName);
objvTeachingCaseResCaseRelaInfoEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.FileName) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.FileName, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.FileName] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetFileType(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileType, 30, convTeachingCaseResCaseRelaInfo.FileType);
objvTeachingCaseResCaseRelaInfoEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.FileType) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.FileType, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.FileType] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetSaveDate(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strSaveDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convTeachingCaseResCaseRelaInfo.SaveDate);
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convTeachingCaseResCaseRelaInfo.SaveDate);
objvTeachingCaseResCaseRelaInfoEN.SaveDate = strSaveDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.SaveDate) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.SaveDate, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.SaveDate] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetFileSize(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileSize, 50, convTeachingCaseResCaseRelaInfo.FileSize);
objvTeachingCaseResCaseRelaInfoEN.FileSize = strFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.FileSize) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.FileSize, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.FileSize] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetSaveTime(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strSaveTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convTeachingCaseResCaseRelaInfo.SaveTime);
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convTeachingCaseResCaseRelaInfo.SaveTime);
objvTeachingCaseResCaseRelaInfoEN.SaveTime = strSaveTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.SaveTime) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.SaveTime, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.SaveTime] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetFtpResourceID(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strFtpResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convTeachingCaseResCaseRelaInfo.FtpResourceID);
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convTeachingCaseResCaseRelaInfo.FtpResourceID);
objvTeachingCaseResCaseRelaInfoEN.FtpResourceID = strFtpResourceID; //FTP资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.FtpResourceID) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.FtpResourceID, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.FtpResourceID] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetFileOriginalName(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strFileOriginalName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convTeachingCaseResCaseRelaInfo.FileOriginalName);
objvTeachingCaseResCaseRelaInfoEN.FileOriginalName = strFileOriginalName; //文件原名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.FileOriginalName) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.FileOriginalName, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.FileOriginalName] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetFileDirName(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strFileDirName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convTeachingCaseResCaseRelaInfo.FileDirName);
objvTeachingCaseResCaseRelaInfoEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.FileDirName) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.FileDirName, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.FileDirName] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetFileRename(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strFileRename, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileRename, 200, convTeachingCaseResCaseRelaInfo.FileRename);
objvTeachingCaseResCaseRelaInfoEN.FileRename = strFileRename; //文件新名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.FileRename) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.FileRename, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.FileRename] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetFileUpDate(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strFileUpDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convTeachingCaseResCaseRelaInfo.FileUpDate);
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convTeachingCaseResCaseRelaInfo.FileUpDate);
objvTeachingCaseResCaseRelaInfoEN.FileUpDate = strFileUpDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.FileUpDate) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.FileUpDate, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.FileUpDate] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetFileUpTime(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strFileUpTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convTeachingCaseResCaseRelaInfo.FileUpTime);
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convTeachingCaseResCaseRelaInfo.FileUpTime);
objvTeachingCaseResCaseRelaInfoEN.FileUpTime = strFileUpTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.FileUpTime) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.FileUpTime, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.FileUpTime] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetSaveMode(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, bool bolSaveMode, string strComparisonOp="")
	{
objvTeachingCaseResCaseRelaInfoEN.SaveMode = bolSaveMode; //文件存放方式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.SaveMode) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.SaveMode, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.SaveMode] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN Setid_ResourceType(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strid_ResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_ResourceType, 4, convTeachingCaseResCaseRelaInfo.id_ResourceType);
clsCheckSql.CheckFieldForeignKey(strid_ResourceType, 4, convTeachingCaseResCaseRelaInfo.id_ResourceType);
objvTeachingCaseResCaseRelaInfoEN.id_ResourceType = strid_ResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.id_ResourceType) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.id_ResourceType, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.id_ResourceType] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetResourceTypeID(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strResourceTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convTeachingCaseResCaseRelaInfo.ResourceTypeID);
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convTeachingCaseResCaseRelaInfo.ResourceTypeID);
objvTeachingCaseResCaseRelaInfoEN.ResourceTypeID = strResourceTypeID; //资源类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.ResourceTypeID) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.ResourceTypeID, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.ResourceTypeID] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetResourceTypeName(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convTeachingCaseResCaseRelaInfo.ResourceTypeName);
objvTeachingCaseResCaseRelaInfoEN.ResourceTypeName = strResourceTypeName; //资源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.ResourceTypeName) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.ResourceTypeName, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.ResourceTypeName] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetResourceOwner(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convTeachingCaseResCaseRelaInfo.ResourceOwner);
objvTeachingCaseResCaseRelaInfoEN.ResourceOwner = strResourceOwner; //上传者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.ResourceOwner) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.ResourceOwner, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.ResourceOwner] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetftpFileType(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convTeachingCaseResCaseRelaInfo.ftpFileType);
objvTeachingCaseResCaseRelaInfoEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.ftpFileType) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.ftpFileType, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.ftpFileType] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetftpFileSize(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strftpFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convTeachingCaseResCaseRelaInfo.ftpFileSize);
objvTeachingCaseResCaseRelaInfoEN.ftpFileSize = strftpFileSize; //ftp文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.ftpFileSize) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.ftpFileSize, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.ftpFileSize] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetftpResourceOwner(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strftpResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convTeachingCaseResCaseRelaInfo.ftpResourceOwner);
objvTeachingCaseResCaseRelaInfoEN.ftpResourceOwner = strftpResourceOwner; //Ftp资源拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.ftpResourceOwner) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.ftpResourceOwner, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.ftpResourceOwner] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetFileOriginName(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strFileOriginName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convTeachingCaseResCaseRelaInfo.FileOriginName);
objvTeachingCaseResCaseRelaInfoEN.FileOriginName = strFileOriginName; //原文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.FileOriginName) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.FileOriginName, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.FileOriginName] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetIsExistFile(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, bool bolIsExistFile, string strComparisonOp="")
	{
objvTeachingCaseResCaseRelaInfoEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.IsExistFile) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.IsExistFile, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.IsExistFile] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetFileNewName(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strFileNewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convTeachingCaseResCaseRelaInfo.FileNewName);
objvTeachingCaseResCaseRelaInfoEN.FileNewName = strFileNewName; //新文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.FileNewName) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.FileNewName, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.FileNewName] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetFileOldName(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strFileOldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convTeachingCaseResCaseRelaInfo.FileOldName);
objvTeachingCaseResCaseRelaInfoEN.FileOldName = strFileOldName; //旧文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.FileOldName) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.FileOldName, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.FileOldName] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN Setid_MicroTeachCaseRelaInfoType(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strid_MicroTeachCaseRelaInfoType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_MicroTeachCaseRelaInfoType, 4, convTeachingCaseResCaseRelaInfo.id_MicroTeachCaseRelaInfoType);
clsCheckSql.CheckFieldForeignKey(strid_MicroTeachCaseRelaInfoType, 4, convTeachingCaseResCaseRelaInfo.id_MicroTeachCaseRelaInfoType);
objvTeachingCaseResCaseRelaInfoEN.id_MicroTeachCaseRelaInfoType = strid_MicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.id_MicroTeachCaseRelaInfoType) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.id_MicroTeachCaseRelaInfoType, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.id_MicroTeachCaseRelaInfoType] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetMicroTeachCaseRelaInfoTypeID(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strMicroTeachCaseRelaInfoTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroTeachCaseRelaInfoTypeID, 4, convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID);
clsCheckSql.CheckFieldForeignKey(strMicroTeachCaseRelaInfoTypeID, 4, convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID);
objvTeachingCaseResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeID = strMicroTeachCaseRelaInfoTypeID; //微格案例相关信息类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetMicroTeachCaseRelaInfoTypeName(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strMicroTeachCaseRelaInfoTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroTeachCaseRelaInfoTypeName, 50, convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName);
objvTeachingCaseResCaseRelaInfoEN.MicroTeachCaseRelaInfoTypeName = strMicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetIsVisible(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, bool bolIsVisible, string strComparisonOp="")
	{
objvTeachingCaseResCaseRelaInfoEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.IsVisible) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.IsVisible, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.IsVisible] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetBrowseCount(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, int intBrowseCount, string strComparisonOp="")
	{
objvTeachingCaseResCaseRelaInfoEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.BrowseCount) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.BrowseCount, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.BrowseCount] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetFlag(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strFlag, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFlag, 50, convTeachingCaseResCaseRelaInfo.Flag);
objvTeachingCaseResCaseRelaInfoEN.Flag = strFlag; //标志
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.Flag) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.Flag, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.Flag] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetUpdDate(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convTeachingCaseResCaseRelaInfo.UpdDate);
objvTeachingCaseResCaseRelaInfoEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.UpdDate) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.UpdDate, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.UpdDate] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetUpdUser(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convTeachingCaseResCaseRelaInfo.UpdUser);
objvTeachingCaseResCaseRelaInfoEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.UpdUser) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.UpdUser, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.UpdUser] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvTeachingCaseResCaseRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvTeachingCaseResCaseRelaInfoEN SetMemo(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convTeachingCaseResCaseRelaInfo.Memo);
objvTeachingCaseResCaseRelaInfoEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.ContainsKey(convTeachingCaseResCaseRelaInfo.Memo) == false)
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp.Add(convTeachingCaseResCaseRelaInfo.Memo, strComparisonOp);
}
else
{
objvTeachingCaseResCaseRelaInfoEN.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.Memo] = strComparisonOp;
}
}
return objvTeachingCaseResCaseRelaInfoEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfo_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.id_MicroTeachCaseRelaInfo) == true)
{
string strComparisonOp_id_MicroTeachCaseRelaInfo = objvTeachingCaseResCaseRelaInfo_Cond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.id_MicroTeachCaseRelaInfo];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCaseRelaInfo.id_MicroTeachCaseRelaInfo, objvTeachingCaseResCaseRelaInfo_Cond.id_MicroTeachCaseRelaInfo, strComparisonOp_id_MicroTeachCaseRelaInfo);
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvTeachingCaseResCaseRelaInfo_Cond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.FuncModuleId, objvTeachingCaseResCaseRelaInfo_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvTeachingCaseResCaseRelaInfo_Cond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.FuncModuleName, objvTeachingCaseResCaseRelaInfo_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvTeachingCaseResCaseRelaInfo_Cond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.id_MicroteachCase, objvTeachingCaseResCaseRelaInfo_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.Id_TeachingCaseResCase) == true)
{
string strComparisonOp_Id_TeachingCaseResCase = objvTeachingCaseResCaseRelaInfo_Cond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.Id_TeachingCaseResCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.Id_TeachingCaseResCase, objvTeachingCaseResCaseRelaInfo_Cond.Id_TeachingCaseResCase, strComparisonOp_Id_TeachingCaseResCase);
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName) == true)
{
string strComparisonOp_TeachingCaseResCaseName = objvTeachingCaseResCaseRelaInfo_Cond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName, objvTeachingCaseResCaseRelaInfo_Cond.TeachingCaseResCaseName, strComparisonOp_TeachingCaseResCaseName);
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvTeachingCaseResCaseRelaInfo_Cond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.id_XzCollege, objvTeachingCaseResCaseRelaInfo_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvTeachingCaseResCaseRelaInfo_Cond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.CollegeID, objvTeachingCaseResCaseRelaInfo_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvTeachingCaseResCaseRelaInfo_Cond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.CollegeName, objvTeachingCaseResCaseRelaInfo_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvTeachingCaseResCaseRelaInfo_Cond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.CollegeNameA, objvTeachingCaseResCaseRelaInfo_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.MajorID) == true)
{
string strComparisonOp_MajorID = objvTeachingCaseResCaseRelaInfo_Cond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.MajorID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.MajorID, objvTeachingCaseResCaseRelaInfo_Cond.MajorID, strComparisonOp_MajorID);
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.MajorName) == true)
{
string strComparisonOp_MajorName = objvTeachingCaseResCaseRelaInfo_Cond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.MajorName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.MajorName, objvTeachingCaseResCaseRelaInfo_Cond.MajorName, strComparisonOp_MajorName);
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.CourseId) == true)
{
string strComparisonOp_CourseId = objvTeachingCaseResCaseRelaInfo_Cond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.CourseId, objvTeachingCaseResCaseRelaInfo_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvTeachingCaseResCaseRelaInfo_Cond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.CourseCode, objvTeachingCaseResCaseRelaInfo_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.CourseName) == true)
{
string strComparisonOp_CourseName = objvTeachingCaseResCaseRelaInfo_Cond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.CourseName, objvTeachingCaseResCaseRelaInfo_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.id_Resource) == true)
{
string strComparisonOp_id_Resource = objvTeachingCaseResCaseRelaInfo_Cond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.id_Resource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.id_Resource, objvTeachingCaseResCaseRelaInfo_Cond.id_Resource, strComparisonOp_id_Resource);
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.ResourceID) == true)
{
string strComparisonOp_ResourceID = objvTeachingCaseResCaseRelaInfo_Cond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.ResourceID, objvTeachingCaseResCaseRelaInfo_Cond.ResourceID, strComparisonOp_ResourceID);
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.id_FtpResource) == true)
{
string strComparisonOp_id_FtpResource = objvTeachingCaseResCaseRelaInfo_Cond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.id_FtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.id_FtpResource, objvTeachingCaseResCaseRelaInfo_Cond.id_FtpResource, strComparisonOp_id_FtpResource);
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.id_File) == true)
{
string strComparisonOp_id_File = objvTeachingCaseResCaseRelaInfo_Cond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.id_File];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.id_File, objvTeachingCaseResCaseRelaInfo_Cond.id_File, strComparisonOp_id_File);
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.FileName) == true)
{
string strComparisonOp_FileName = objvTeachingCaseResCaseRelaInfo_Cond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.FileName, objvTeachingCaseResCaseRelaInfo_Cond.FileName, strComparisonOp_FileName);
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.FileType) == true)
{
string strComparisonOp_FileType = objvTeachingCaseResCaseRelaInfo_Cond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.FileType, objvTeachingCaseResCaseRelaInfo_Cond.FileType, strComparisonOp_FileType);
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.SaveDate) == true)
{
string strComparisonOp_SaveDate = objvTeachingCaseResCaseRelaInfo_Cond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.SaveDate, objvTeachingCaseResCaseRelaInfo_Cond.SaveDate, strComparisonOp_SaveDate);
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.FileSize) == true)
{
string strComparisonOp_FileSize = objvTeachingCaseResCaseRelaInfo_Cond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.FileSize, objvTeachingCaseResCaseRelaInfo_Cond.FileSize, strComparisonOp_FileSize);
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.SaveTime) == true)
{
string strComparisonOp_SaveTime = objvTeachingCaseResCaseRelaInfo_Cond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.SaveTime, objvTeachingCaseResCaseRelaInfo_Cond.SaveTime, strComparisonOp_SaveTime);
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.FtpResourceID) == true)
{
string strComparisonOp_FtpResourceID = objvTeachingCaseResCaseRelaInfo_Cond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.FtpResourceID, objvTeachingCaseResCaseRelaInfo_Cond.FtpResourceID, strComparisonOp_FtpResourceID);
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.FileOriginalName) == true)
{
string strComparisonOp_FileOriginalName = objvTeachingCaseResCaseRelaInfo_Cond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.FileOriginalName, objvTeachingCaseResCaseRelaInfo_Cond.FileOriginalName, strComparisonOp_FileOriginalName);
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.FileDirName) == true)
{
string strComparisonOp_FileDirName = objvTeachingCaseResCaseRelaInfo_Cond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.FileDirName, objvTeachingCaseResCaseRelaInfo_Cond.FileDirName, strComparisonOp_FileDirName);
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.FileRename) == true)
{
string strComparisonOp_FileRename = objvTeachingCaseResCaseRelaInfo_Cond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.FileRename, objvTeachingCaseResCaseRelaInfo_Cond.FileRename, strComparisonOp_FileRename);
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.FileUpDate) == true)
{
string strComparisonOp_FileUpDate = objvTeachingCaseResCaseRelaInfo_Cond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.FileUpDate, objvTeachingCaseResCaseRelaInfo_Cond.FileUpDate, strComparisonOp_FileUpDate);
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.FileUpTime) == true)
{
string strComparisonOp_FileUpTime = objvTeachingCaseResCaseRelaInfo_Cond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.FileUpTime, objvTeachingCaseResCaseRelaInfo_Cond.FileUpTime, strComparisonOp_FileUpTime);
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.SaveMode) == true)
{
if (objvTeachingCaseResCaseRelaInfo_Cond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachingCaseResCaseRelaInfo.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachingCaseResCaseRelaInfo.SaveMode);
}
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.id_ResourceType) == true)
{
string strComparisonOp_id_ResourceType = objvTeachingCaseResCaseRelaInfo_Cond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.id_ResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.id_ResourceType, objvTeachingCaseResCaseRelaInfo_Cond.id_ResourceType, strComparisonOp_id_ResourceType);
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.ResourceTypeID) == true)
{
string strComparisonOp_ResourceTypeID = objvTeachingCaseResCaseRelaInfo_Cond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.ResourceTypeID, objvTeachingCaseResCaseRelaInfo_Cond.ResourceTypeID, strComparisonOp_ResourceTypeID);
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.ResourceTypeName) == true)
{
string strComparisonOp_ResourceTypeName = objvTeachingCaseResCaseRelaInfo_Cond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.ResourceTypeName, objvTeachingCaseResCaseRelaInfo_Cond.ResourceTypeName, strComparisonOp_ResourceTypeName);
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.ResourceOwner) == true)
{
string strComparisonOp_ResourceOwner = objvTeachingCaseResCaseRelaInfo_Cond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.ResourceOwner, objvTeachingCaseResCaseRelaInfo_Cond.ResourceOwner, strComparisonOp_ResourceOwner);
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvTeachingCaseResCaseRelaInfo_Cond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.ftpFileType, objvTeachingCaseResCaseRelaInfo_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.ftpFileSize) == true)
{
string strComparisonOp_ftpFileSize = objvTeachingCaseResCaseRelaInfo_Cond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.ftpFileSize, objvTeachingCaseResCaseRelaInfo_Cond.ftpFileSize, strComparisonOp_ftpFileSize);
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.ftpResourceOwner) == true)
{
string strComparisonOp_ftpResourceOwner = objvTeachingCaseResCaseRelaInfo_Cond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.ftpResourceOwner, objvTeachingCaseResCaseRelaInfo_Cond.ftpResourceOwner, strComparisonOp_ftpResourceOwner);
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.FileOriginName) == true)
{
string strComparisonOp_FileOriginName = objvTeachingCaseResCaseRelaInfo_Cond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.FileOriginName, objvTeachingCaseResCaseRelaInfo_Cond.FileOriginName, strComparisonOp_FileOriginName);
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.IsExistFile) == true)
{
if (objvTeachingCaseResCaseRelaInfo_Cond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachingCaseResCaseRelaInfo.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachingCaseResCaseRelaInfo.IsExistFile);
}
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.FileNewName) == true)
{
string strComparisonOp_FileNewName = objvTeachingCaseResCaseRelaInfo_Cond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.FileNewName, objvTeachingCaseResCaseRelaInfo_Cond.FileNewName, strComparisonOp_FileNewName);
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.FileOldName) == true)
{
string strComparisonOp_FileOldName = objvTeachingCaseResCaseRelaInfo_Cond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.FileOldName, objvTeachingCaseResCaseRelaInfo_Cond.FileOldName, strComparisonOp_FileOldName);
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.id_MicroTeachCaseRelaInfoType) == true)
{
string strComparisonOp_id_MicroTeachCaseRelaInfoType = objvTeachingCaseResCaseRelaInfo_Cond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.id_MicroTeachCaseRelaInfoType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.id_MicroTeachCaseRelaInfoType, objvTeachingCaseResCaseRelaInfo_Cond.id_MicroTeachCaseRelaInfoType, strComparisonOp_id_MicroTeachCaseRelaInfoType);
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID) == true)
{
string strComparisonOp_MicroTeachCaseRelaInfoTypeID = objvTeachingCaseResCaseRelaInfo_Cond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID, objvTeachingCaseResCaseRelaInfo_Cond.MicroTeachCaseRelaInfoTypeID, strComparisonOp_MicroTeachCaseRelaInfoTypeID);
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName) == true)
{
string strComparisonOp_MicroTeachCaseRelaInfoTypeName = objvTeachingCaseResCaseRelaInfo_Cond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName, objvTeachingCaseResCaseRelaInfo_Cond.MicroTeachCaseRelaInfoTypeName, strComparisonOp_MicroTeachCaseRelaInfoTypeName);
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.IsVisible) == true)
{
if (objvTeachingCaseResCaseRelaInfo_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convTeachingCaseResCaseRelaInfo.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convTeachingCaseResCaseRelaInfo.IsVisible);
}
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvTeachingCaseResCaseRelaInfo_Cond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convTeachingCaseResCaseRelaInfo.BrowseCount, objvTeachingCaseResCaseRelaInfo_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.Flag) == true)
{
string strComparisonOp_Flag = objvTeachingCaseResCaseRelaInfo_Cond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.Flag];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.Flag, objvTeachingCaseResCaseRelaInfo_Cond.Flag, strComparisonOp_Flag);
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvTeachingCaseResCaseRelaInfo_Cond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.UpdDate, objvTeachingCaseResCaseRelaInfo_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvTeachingCaseResCaseRelaInfo_Cond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.UpdUser, objvTeachingCaseResCaseRelaInfo_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvTeachingCaseResCaseRelaInfo_Cond.IsUpdated(convTeachingCaseResCaseRelaInfo.Memo) == true)
{
string strComparisonOp_Memo = objvTeachingCaseResCaseRelaInfo_Cond.dicFldComparisonOp[convTeachingCaseResCaseRelaInfo.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convTeachingCaseResCaseRelaInfo.Memo, objvTeachingCaseResCaseRelaInfo_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v教学案例资源案例相关信息(vTeachingCaseResCaseRelaInfo)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvTeachingCaseResCaseRelaInfoWApi
{
private static readonly string mstrApiControllerName = "vTeachingCaseResCaseRelaInfoApi";

 public clsvTeachingCaseResCaseRelaInfoWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_MicroTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeachingCaseResCaseRelaInfoEN GetObjByid_MicroTeachCaseRelaInfo(long lngid_MicroTeachCaseRelaInfo)
{
string strAction = "GetObjByid_MicroTeachCaseRelaInfo";
string strErrMsg = string.Empty;
string strResult = "";
clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroTeachCaseRelaInfo"] = lngid_MicroTeachCaseRelaInfo.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvTeachingCaseResCaseRelaInfoEN = JsonConvert.DeserializeObject<clsvTeachingCaseResCaseRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objvTeachingCaseResCaseRelaInfoEN;
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
 /// <param name = "lngid_MicroTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsvTeachingCaseResCaseRelaInfoEN GetObjByid_MicroTeachCaseRelaInfo_WA_Cache(long lngid_MicroTeachCaseRelaInfo)
{
string strAction = "GetObjByid_MicroTeachCaseRelaInfo_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN = null;
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroTeachCaseRelaInfo"] = lngid_MicroTeachCaseRelaInfo.ToString()
};
try
{
if (clsPubFun4WApi.Get4WebApi(mstrApiControllerName, strAction, dictParam, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
objvTeachingCaseResCaseRelaInfoEN = JsonConvert.DeserializeObject<clsvTeachingCaseResCaseRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objvTeachingCaseResCaseRelaInfoEN;
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
public static clsvTeachingCaseResCaseRelaInfoEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoEN = null;
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
objvTeachingCaseResCaseRelaInfoEN = JsonConvert.DeserializeObject<clsvTeachingCaseResCaseRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objvTeachingCaseResCaseRelaInfoEN;
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
 /// <param name = "lngid_MicroTeachCaseRelaInfo">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvTeachingCaseResCaseRelaInfoEN GetObjByid_MicroTeachCaseRelaInfo_Cache(long lngid_MicroTeachCaseRelaInfo)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvTeachingCaseResCaseRelaInfoEN._CurrTabName_S);
List<clsvTeachingCaseResCaseRelaInfoEN> arrvTeachingCaseResCaseRelaInfoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvTeachingCaseResCaseRelaInfoEN> arrvTeachingCaseResCaseRelaInfoObjLst_Sel =
from objvTeachingCaseResCaseRelaInfoEN in arrvTeachingCaseResCaseRelaInfoObjLst_Cache
where objvTeachingCaseResCaseRelaInfoEN.id_MicroTeachCaseRelaInfo == lngid_MicroTeachCaseRelaInfo
select objvTeachingCaseResCaseRelaInfoEN;
if (arrvTeachingCaseResCaseRelaInfoObjLst_Sel.Count() == 0)
{
   clsvTeachingCaseResCaseRelaInfoEN obj = clsvTeachingCaseResCaseRelaInfoWApi.GetObjByid_MicroTeachCaseRelaInfo(lngid_MicroTeachCaseRelaInfo);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvTeachingCaseResCaseRelaInfoObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachingCaseResCaseRelaInfoEN> GetObjLst(string strWhereCond)
{
 List<clsvTeachingCaseResCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingCaseResCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachingCaseResCaseRelaInfoEN> GetObjLstById_MicroTeachCaseRelaInfoLst(List<long> arrId_MicroTeachCaseRelaInfo)
{
 List<clsvTeachingCaseResCaseRelaInfoEN> arrObjLst = null; 
string strAction = "GetObjLstById_MicroTeachCaseRelaInfoLst";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>();
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_MicroTeachCaseRelaInfo);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingCaseResCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "lngid_MicroTeachCaseRelaInfo">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static IEnumerable<clsvTeachingCaseResCaseRelaInfoEN> GetObjLstById_MicroTeachCaseRelaInfoLst_Cache(List<long> arrId_MicroTeachCaseRelaInfo)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvTeachingCaseResCaseRelaInfoEN._CurrTabName_S);
List<clsvTeachingCaseResCaseRelaInfoEN> arrvTeachingCaseResCaseRelaInfoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvTeachingCaseResCaseRelaInfoEN> arrvTeachingCaseResCaseRelaInfoObjLst_Sel =
from objvTeachingCaseResCaseRelaInfoEN in arrvTeachingCaseResCaseRelaInfoObjLst_Cache
where arrId_MicroTeachCaseRelaInfo.Contains(objvTeachingCaseResCaseRelaInfoEN.id_MicroTeachCaseRelaInfo)
select objvTeachingCaseResCaseRelaInfoEN;
return arrvTeachingCaseResCaseRelaInfoObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvTeachingCaseResCaseRelaInfoEN> GetObjLstById_MicroTeachCaseRelaInfoLst_WA_Cache(List<long> arrId_MicroTeachCaseRelaInfo)
{
 List<clsvTeachingCaseResCaseRelaInfoEN> arrObjLst = null; 
string strAction = "GetObjLstById_MicroTeachCaseRelaInfoLst_Cache";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
};
try
{
string strJSON = clsJSON.GetJsonFromObjLst(arrId_MicroTeachCaseRelaInfo);
if (clsPubFun4WApi.Post(mstrApiControllerName, strAction, dictParam, strJSON, out strResult, out strErrMsg) == true)
{
JObject jobjReturn = JObject.Parse(strResult);
if ((int)jobjReturn["ErrorId"] == 0)
{
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingCaseResCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachingCaseResCaseRelaInfoEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvTeachingCaseResCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingCaseResCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachingCaseResCaseRelaInfoEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvTeachingCaseResCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingCaseResCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachingCaseResCaseRelaInfoEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvTeachingCaseResCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingCaseResCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvTeachingCaseResCaseRelaInfoEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvTeachingCaseResCaseRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvTeachingCaseResCaseRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static bool IsExist(long lngid_MicroTeachCaseRelaInfo)
{
//检测记录是否存在
string strAction = "IsExist";
string strErrMsg = string.Empty;
string strResult = "";
Dictionary<string, string> dictParam = new Dictionary<string, string>()
{
["id_MicroTeachCaseRelaInfo"] = lngid_MicroTeachCaseRelaInfo.ToString()
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
 /// <param name = "objvTeachingCaseResCaseRelaInfoENS">源对象</param>
 /// <param name = "objvTeachingCaseResCaseRelaInfoENT">目标对象</param>
 public static void CopyTo(clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoENS, clsvTeachingCaseResCaseRelaInfoEN objvTeachingCaseResCaseRelaInfoENT)
{
try
{
objvTeachingCaseResCaseRelaInfoENT.id_MicroTeachCaseRelaInfo = objvTeachingCaseResCaseRelaInfoENS.id_MicroTeachCaseRelaInfo; //案例相关信息流水号
objvTeachingCaseResCaseRelaInfoENT.FuncModuleId = objvTeachingCaseResCaseRelaInfoENS.FuncModuleId; //功能模块Id
objvTeachingCaseResCaseRelaInfoENT.FuncModuleName = objvTeachingCaseResCaseRelaInfoENS.FuncModuleName; //功能模块名称
objvTeachingCaseResCaseRelaInfoENT.id_MicroteachCase = objvTeachingCaseResCaseRelaInfoENS.id_MicroteachCase; //微格教学案例流水号
objvTeachingCaseResCaseRelaInfoENT.Id_TeachingCaseResCase = objvTeachingCaseResCaseRelaInfoENS.Id_TeachingCaseResCase; //教学案例资源案例流水号
objvTeachingCaseResCaseRelaInfoENT.TeachingCaseResCaseName = objvTeachingCaseResCaseRelaInfoENS.TeachingCaseResCaseName; //教学案例资源案例名称
objvTeachingCaseResCaseRelaInfoENT.id_XzCollege = objvTeachingCaseResCaseRelaInfoENS.id_XzCollege; //学院流水号
objvTeachingCaseResCaseRelaInfoENT.CollegeID = objvTeachingCaseResCaseRelaInfoENS.CollegeID; //学院ID
objvTeachingCaseResCaseRelaInfoENT.CollegeName = objvTeachingCaseResCaseRelaInfoENS.CollegeName; //学院名称
objvTeachingCaseResCaseRelaInfoENT.CollegeNameA = objvTeachingCaseResCaseRelaInfoENS.CollegeNameA; //学院名称简写
objvTeachingCaseResCaseRelaInfoENT.MajorID = objvTeachingCaseResCaseRelaInfoENS.MajorID; //专业ID
objvTeachingCaseResCaseRelaInfoENT.MajorName = objvTeachingCaseResCaseRelaInfoENS.MajorName; //专业名称
objvTeachingCaseResCaseRelaInfoENT.CourseId = objvTeachingCaseResCaseRelaInfoENS.CourseId; //课程Id
objvTeachingCaseResCaseRelaInfoENT.CourseCode = objvTeachingCaseResCaseRelaInfoENS.CourseCode; //课程代码
objvTeachingCaseResCaseRelaInfoENT.CourseName = objvTeachingCaseResCaseRelaInfoENS.CourseName; //课程名称
objvTeachingCaseResCaseRelaInfoENT.id_Resource = objvTeachingCaseResCaseRelaInfoENS.id_Resource; //资源流水号
objvTeachingCaseResCaseRelaInfoENT.ResourceID = objvTeachingCaseResCaseRelaInfoENS.ResourceID; //资源ID
objvTeachingCaseResCaseRelaInfoENT.id_FtpResource = objvTeachingCaseResCaseRelaInfoENS.id_FtpResource; //FTP资源流水号
objvTeachingCaseResCaseRelaInfoENT.id_File = objvTeachingCaseResCaseRelaInfoENS.id_File; //文件流水号
objvTeachingCaseResCaseRelaInfoENT.FileName = objvTeachingCaseResCaseRelaInfoENS.FileName; //文件名称
objvTeachingCaseResCaseRelaInfoENT.FileType = objvTeachingCaseResCaseRelaInfoENS.FileType; //文件类型
objvTeachingCaseResCaseRelaInfoENT.SaveDate = objvTeachingCaseResCaseRelaInfoENS.SaveDate; //创建日期
objvTeachingCaseResCaseRelaInfoENT.FileSize = objvTeachingCaseResCaseRelaInfoENS.FileSize; //文件大小
objvTeachingCaseResCaseRelaInfoENT.SaveTime = objvTeachingCaseResCaseRelaInfoENS.SaveTime; //创建时间
objvTeachingCaseResCaseRelaInfoENT.FtpResourceID = objvTeachingCaseResCaseRelaInfoENS.FtpResourceID; //FTP资源ID
objvTeachingCaseResCaseRelaInfoENT.FileOriginalName = objvTeachingCaseResCaseRelaInfoENS.FileOriginalName; //文件原名
objvTeachingCaseResCaseRelaInfoENT.FileDirName = objvTeachingCaseResCaseRelaInfoENS.FileDirName; //文件目录名
objvTeachingCaseResCaseRelaInfoENT.FileRename = objvTeachingCaseResCaseRelaInfoENS.FileRename; //文件新名
objvTeachingCaseResCaseRelaInfoENT.FileUpDate = objvTeachingCaseResCaseRelaInfoENS.FileUpDate; //创建日期
objvTeachingCaseResCaseRelaInfoENT.FileUpTime = objvTeachingCaseResCaseRelaInfoENS.FileUpTime; //创建时间
objvTeachingCaseResCaseRelaInfoENT.SaveMode = objvTeachingCaseResCaseRelaInfoENS.SaveMode; //文件存放方式
objvTeachingCaseResCaseRelaInfoENT.id_ResourceType = objvTeachingCaseResCaseRelaInfoENS.id_ResourceType; //资源类型流水号
objvTeachingCaseResCaseRelaInfoENT.ResourceTypeID = objvTeachingCaseResCaseRelaInfoENS.ResourceTypeID; //资源类型ID
objvTeachingCaseResCaseRelaInfoENT.ResourceTypeName = objvTeachingCaseResCaseRelaInfoENS.ResourceTypeName; //资源类型名称
objvTeachingCaseResCaseRelaInfoENT.ResourceOwner = objvTeachingCaseResCaseRelaInfoENS.ResourceOwner; //上传者
objvTeachingCaseResCaseRelaInfoENT.ftpFileType = objvTeachingCaseResCaseRelaInfoENS.ftpFileType; //ftp文件类型
objvTeachingCaseResCaseRelaInfoENT.ftpFileSize = objvTeachingCaseResCaseRelaInfoENS.ftpFileSize; //ftp文件大小
objvTeachingCaseResCaseRelaInfoENT.ftpResourceOwner = objvTeachingCaseResCaseRelaInfoENS.ftpResourceOwner; //Ftp资源拥有者
objvTeachingCaseResCaseRelaInfoENT.FileOriginName = objvTeachingCaseResCaseRelaInfoENS.FileOriginName; //原文件名
objvTeachingCaseResCaseRelaInfoENT.IsExistFile = objvTeachingCaseResCaseRelaInfoENS.IsExistFile; //是否存在文件
objvTeachingCaseResCaseRelaInfoENT.FileNewName = objvTeachingCaseResCaseRelaInfoENS.FileNewName; //新文件名
objvTeachingCaseResCaseRelaInfoENT.FileOldName = objvTeachingCaseResCaseRelaInfoENS.FileOldName; //旧文件名
objvTeachingCaseResCaseRelaInfoENT.id_MicroTeachCaseRelaInfoType = objvTeachingCaseResCaseRelaInfoENS.id_MicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
objvTeachingCaseResCaseRelaInfoENT.MicroTeachCaseRelaInfoTypeID = objvTeachingCaseResCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeID; //微格案例相关信息类型ID
objvTeachingCaseResCaseRelaInfoENT.MicroTeachCaseRelaInfoTypeName = objvTeachingCaseResCaseRelaInfoENS.MicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
objvTeachingCaseResCaseRelaInfoENT.IsVisible = objvTeachingCaseResCaseRelaInfoENS.IsVisible; //是否显示
objvTeachingCaseResCaseRelaInfoENT.BrowseCount = objvTeachingCaseResCaseRelaInfoENS.BrowseCount; //浏览次数
objvTeachingCaseResCaseRelaInfoENT.Flag = objvTeachingCaseResCaseRelaInfoENS.Flag; //标志
objvTeachingCaseResCaseRelaInfoENT.UpdDate = objvTeachingCaseResCaseRelaInfoENS.UpdDate; //修改日期
objvTeachingCaseResCaseRelaInfoENT.UpdUser = objvTeachingCaseResCaseRelaInfoENS.UpdUser; //修改人
objvTeachingCaseResCaseRelaInfoENT.Memo = objvTeachingCaseResCaseRelaInfoENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvTeachingCaseResCaseRelaInfoEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvTeachingCaseResCaseRelaInfoEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvTeachingCaseResCaseRelaInfoEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvTeachingCaseResCaseRelaInfoEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvTeachingCaseResCaseRelaInfoEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvTeachingCaseResCaseRelaInfoEN.AttributeName)
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
if (clsFuncModuleWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFuncModuleWApi没有刷新缓存机制(clsFuncModuleWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroTeachCaseRelaInfoTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroTeachCaseRelaInfoTypeWApi没有刷新缓存机制(clsMicroTeachCaseRelaInfoTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroTeachCaseRelaInfoWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroTeachCaseRelaInfoWApi没有刷新缓存机制(clsMicroTeachCaseRelaInfoWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsResourceTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsResourceTypeWApi没有刷新缓存机制(clsResourceTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsResourceWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsResourceWApi没有刷新缓存机制(clsResourceWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFileServerWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFileServerWApi没有刷新缓存机制(clsFileServerWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFtpResourceWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsFtpResourceWApi没有刷新缓存机制(clsFtpResourceWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzClgWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgWApi没有刷新缓存机制(clsXzClgWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsStudyLevelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsStudyLevelWApi没有刷新缓存机制(clsStudyLevelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRecommendedDegreeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRecommendedDegreeWApi没有刷新缓存机制(clsRecommendedDegreeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSenateGaugeVersionWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSenateGaugeVersionWApi没有刷新缓存机制(clsSenateGaugeVersionWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCaseLevelWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsCaseLevelWApi没有刷新缓存机制(clsCaseLevelWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDisciplineWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsDisciplineWApi没有刷新缓存机制(clsDisciplineWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachingCaseResCaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachingCaseResCaseWApi没有刷新缓存机制(clsTeachingCaseResCaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachingCaseResCaseTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachingCaseResCaseTypeWApi没有刷新缓存机制(clsTeachingCaseResCaseTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUsersWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUsersWApi没有刷新缓存机制(clsUsersWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserStateWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserStateWApi没有刷新缓存机制(clsUserStateWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorWApi没有刷新缓存机制(clsXzMajorWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzGradeBaseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzGradeBaseWApi没有刷新缓存机制(clsXzGradeBaseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsUserIdentityWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsUserIdentityWApi没有刷新缓存机制(clsUserIdentityWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clscc_ThemesWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_ThemesWApi没有刷新缓存机制(clscc_ThemesWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseChapterWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseChapterWApi没有刷新缓存机制(clscc_CourseChapterWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzDegreeTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzDegreeTypeWApi没有刷新缓存机制(clsXzDegreeTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorTypeWApi没有刷新缓存机制(clsXzMajorTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsXzMajorShoolTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzMajorShoolTypeWApi没有刷新缓存机制(clsXzMajorShoolTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsSkillTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsSkillTypeWApi没有刷新缓存机制(clsSkillTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsTeachSkillWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsTeachSkillWApi没有刷新缓存机制(clsTeachSkillWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseIsLikeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeWApi没有刷新缓存机制(clscc_CourseIsLikeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_MicroTeachCaseRelaInfo");
//if (arrvTeachingCaseResCaseRelaInfoObjLst_Cache == null)
//{
//arrvTeachingCaseResCaseRelaInfoObjLst_Cache = await clsvTeachingCaseResCaseRelaInfoWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvTeachingCaseResCaseRelaInfoEN._CurrTabName_S);
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
public static List<clsvTeachingCaseResCaseRelaInfoEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvTeachingCaseResCaseRelaInfoEN._CurrTabName_S);
List<clsvTeachingCaseResCaseRelaInfoEN> arrvTeachingCaseResCaseRelaInfoObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvTeachingCaseResCaseRelaInfoObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvTeachingCaseResCaseRelaInfoEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.id_MicroTeachCaseRelaInfo, Type.GetType("System.Int64"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.Id_TeachingCaseResCase, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.MajorID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.MajorName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.id_Resource, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.ResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.id_FtpResource, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.id_File, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.FileType, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.SaveDate, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.FileSize, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.SaveTime, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.FtpResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.FileOriginalName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.FileDirName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.FileRename, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.FileUpDate, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.FileUpTime, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.SaveMode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.id_ResourceType, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.ResourceTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.ResourceTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.ResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.ftpFileSize, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.ftpResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.FileOriginName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.IsExistFile, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.FileNewName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.FileOldName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.id_MicroTeachCaseRelaInfoType, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.Flag, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convTeachingCaseResCaseRelaInfo.Memo, Type.GetType("System.String"));
foreach (clsvTeachingCaseResCaseRelaInfoEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convTeachingCaseResCaseRelaInfo.id_MicroTeachCaseRelaInfo] = objInFor[convTeachingCaseResCaseRelaInfo.id_MicroTeachCaseRelaInfo];
objDR[convTeachingCaseResCaseRelaInfo.FuncModuleId] = objInFor[convTeachingCaseResCaseRelaInfo.FuncModuleId];
objDR[convTeachingCaseResCaseRelaInfo.FuncModuleName] = objInFor[convTeachingCaseResCaseRelaInfo.FuncModuleName];
objDR[convTeachingCaseResCaseRelaInfo.id_MicroteachCase] = objInFor[convTeachingCaseResCaseRelaInfo.id_MicroteachCase];
objDR[convTeachingCaseResCaseRelaInfo.Id_TeachingCaseResCase] = objInFor[convTeachingCaseResCaseRelaInfo.Id_TeachingCaseResCase];
objDR[convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName] = objInFor[convTeachingCaseResCaseRelaInfo.TeachingCaseResCaseName];
objDR[convTeachingCaseResCaseRelaInfo.id_XzCollege] = objInFor[convTeachingCaseResCaseRelaInfo.id_XzCollege];
objDR[convTeachingCaseResCaseRelaInfo.CollegeID] = objInFor[convTeachingCaseResCaseRelaInfo.CollegeID];
objDR[convTeachingCaseResCaseRelaInfo.CollegeName] = objInFor[convTeachingCaseResCaseRelaInfo.CollegeName];
objDR[convTeachingCaseResCaseRelaInfo.CollegeNameA] = objInFor[convTeachingCaseResCaseRelaInfo.CollegeNameA];
objDR[convTeachingCaseResCaseRelaInfo.MajorID] = objInFor[convTeachingCaseResCaseRelaInfo.MajorID];
objDR[convTeachingCaseResCaseRelaInfo.MajorName] = objInFor[convTeachingCaseResCaseRelaInfo.MajorName];
objDR[convTeachingCaseResCaseRelaInfo.CourseId] = objInFor[convTeachingCaseResCaseRelaInfo.CourseId];
objDR[convTeachingCaseResCaseRelaInfo.CourseCode] = objInFor[convTeachingCaseResCaseRelaInfo.CourseCode];
objDR[convTeachingCaseResCaseRelaInfo.CourseName] = objInFor[convTeachingCaseResCaseRelaInfo.CourseName];
objDR[convTeachingCaseResCaseRelaInfo.id_Resource] = objInFor[convTeachingCaseResCaseRelaInfo.id_Resource];
objDR[convTeachingCaseResCaseRelaInfo.ResourceID] = objInFor[convTeachingCaseResCaseRelaInfo.ResourceID];
objDR[convTeachingCaseResCaseRelaInfo.id_FtpResource] = objInFor[convTeachingCaseResCaseRelaInfo.id_FtpResource];
objDR[convTeachingCaseResCaseRelaInfo.id_File] = objInFor[convTeachingCaseResCaseRelaInfo.id_File];
objDR[convTeachingCaseResCaseRelaInfo.FileName] = objInFor[convTeachingCaseResCaseRelaInfo.FileName];
objDR[convTeachingCaseResCaseRelaInfo.FileType] = objInFor[convTeachingCaseResCaseRelaInfo.FileType];
objDR[convTeachingCaseResCaseRelaInfo.SaveDate] = objInFor[convTeachingCaseResCaseRelaInfo.SaveDate];
objDR[convTeachingCaseResCaseRelaInfo.FileSize] = objInFor[convTeachingCaseResCaseRelaInfo.FileSize];
objDR[convTeachingCaseResCaseRelaInfo.SaveTime] = objInFor[convTeachingCaseResCaseRelaInfo.SaveTime];
objDR[convTeachingCaseResCaseRelaInfo.FtpResourceID] = objInFor[convTeachingCaseResCaseRelaInfo.FtpResourceID];
objDR[convTeachingCaseResCaseRelaInfo.FileOriginalName] = objInFor[convTeachingCaseResCaseRelaInfo.FileOriginalName];
objDR[convTeachingCaseResCaseRelaInfo.FileDirName] = objInFor[convTeachingCaseResCaseRelaInfo.FileDirName];
objDR[convTeachingCaseResCaseRelaInfo.FileRename] = objInFor[convTeachingCaseResCaseRelaInfo.FileRename];
objDR[convTeachingCaseResCaseRelaInfo.FileUpDate] = objInFor[convTeachingCaseResCaseRelaInfo.FileUpDate];
objDR[convTeachingCaseResCaseRelaInfo.FileUpTime] = objInFor[convTeachingCaseResCaseRelaInfo.FileUpTime];
objDR[convTeachingCaseResCaseRelaInfo.SaveMode] = objInFor[convTeachingCaseResCaseRelaInfo.SaveMode];
objDR[convTeachingCaseResCaseRelaInfo.id_ResourceType] = objInFor[convTeachingCaseResCaseRelaInfo.id_ResourceType];
objDR[convTeachingCaseResCaseRelaInfo.ResourceTypeID] = objInFor[convTeachingCaseResCaseRelaInfo.ResourceTypeID];
objDR[convTeachingCaseResCaseRelaInfo.ResourceTypeName] = objInFor[convTeachingCaseResCaseRelaInfo.ResourceTypeName];
objDR[convTeachingCaseResCaseRelaInfo.ResourceOwner] = objInFor[convTeachingCaseResCaseRelaInfo.ResourceOwner];
objDR[convTeachingCaseResCaseRelaInfo.ftpFileType] = objInFor[convTeachingCaseResCaseRelaInfo.ftpFileType];
objDR[convTeachingCaseResCaseRelaInfo.ftpFileSize] = objInFor[convTeachingCaseResCaseRelaInfo.ftpFileSize];
objDR[convTeachingCaseResCaseRelaInfo.ftpResourceOwner] = objInFor[convTeachingCaseResCaseRelaInfo.ftpResourceOwner];
objDR[convTeachingCaseResCaseRelaInfo.FileOriginName] = objInFor[convTeachingCaseResCaseRelaInfo.FileOriginName];
objDR[convTeachingCaseResCaseRelaInfo.IsExistFile] = objInFor[convTeachingCaseResCaseRelaInfo.IsExistFile];
objDR[convTeachingCaseResCaseRelaInfo.FileNewName] = objInFor[convTeachingCaseResCaseRelaInfo.FileNewName];
objDR[convTeachingCaseResCaseRelaInfo.FileOldName] = objInFor[convTeachingCaseResCaseRelaInfo.FileOldName];
objDR[convTeachingCaseResCaseRelaInfo.id_MicroTeachCaseRelaInfoType] = objInFor[convTeachingCaseResCaseRelaInfo.id_MicroTeachCaseRelaInfoType];
objDR[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID] = objInFor[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeID];
objDR[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName] = objInFor[convTeachingCaseResCaseRelaInfo.MicroTeachCaseRelaInfoTypeName];
objDR[convTeachingCaseResCaseRelaInfo.IsVisible] = objInFor[convTeachingCaseResCaseRelaInfo.IsVisible];
objDR[convTeachingCaseResCaseRelaInfo.BrowseCount] = objInFor[convTeachingCaseResCaseRelaInfo.BrowseCount];
objDR[convTeachingCaseResCaseRelaInfo.Flag] = objInFor[convTeachingCaseResCaseRelaInfo.Flag];
objDR[convTeachingCaseResCaseRelaInfo.UpdDate] = objInFor[convTeachingCaseResCaseRelaInfo.UpdDate];
objDR[convTeachingCaseResCaseRelaInfo.UpdUser] = objInFor[convTeachingCaseResCaseRelaInfo.UpdUser];
objDR[convTeachingCaseResCaseRelaInfo.Memo] = objInFor[convTeachingCaseResCaseRelaInfo.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}