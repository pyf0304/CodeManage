
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvVideoLibRelaInfoWApi
 表名:vVideoLibRelaInfo(01120405)
 生成代码版本:2021.09.20.1
 生成日期:2021/09/21 02:52:00
 生成者:pyf
 生成服务器IP:103.116.76.183
 工程名称:问卷调查
 工程ID:0112
 相关数据库:103.116.76.183,9433EduHigh_Jsie
 PrjDataBaseId:0170
 模块中文名:视频库
 模块英文名:VideoLib
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
public static class clsvVideoLibRelaInfoWApi_Static
{

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN Setid_MicroTeachCaseRelaInfo(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, long lngid_MicroTeachCaseRelaInfo, string strComparisonOp="")
	{
objvVideoLibRelaInfoEN.id_MicroTeachCaseRelaInfo = lngid_MicroTeachCaseRelaInfo; //案例相关信息流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.id_MicroTeachCaseRelaInfo) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.id_MicroTeachCaseRelaInfo, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.id_MicroTeachCaseRelaInfo] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetFuncModuleId(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strFuncModuleId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFuncModuleId, convVideoLibRelaInfo.FuncModuleId);
clsCheckSql.CheckFieldLen(strFuncModuleId, 4, convVideoLibRelaInfo.FuncModuleId);
clsCheckSql.CheckFieldForeignKey(strFuncModuleId, 4, convVideoLibRelaInfo.FuncModuleId);
objvVideoLibRelaInfoEN.FuncModuleId = strFuncModuleId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.FuncModuleId) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.FuncModuleId, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.FuncModuleId] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetFuncModuleName(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strFuncModuleName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFuncModuleName, 30, convVideoLibRelaInfo.FuncModuleName);
objvVideoLibRelaInfoEN.FuncModuleName = strFuncModuleName; //功能模块名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.FuncModuleName) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.FuncModuleName, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.FuncModuleName] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN Setid_MicroteachCase(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strid_MicroteachCase, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_MicroteachCase, convVideoLibRelaInfo.id_MicroteachCase);
clsCheckSql.CheckFieldLen(strid_MicroteachCase, 8, convVideoLibRelaInfo.id_MicroteachCase);
clsCheckSql.CheckFieldForeignKey(strid_MicroteachCase, 8, convVideoLibRelaInfo.id_MicroteachCase);
objvVideoLibRelaInfoEN.id_MicroteachCase = strid_MicroteachCase; //微格教学案例流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.id_MicroteachCase) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.id_MicroteachCase, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.id_MicroteachCase] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetId_VideoLib(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strId_VideoLib, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strId_VideoLib, 8, convVideoLibRelaInfo.Id_VideoLib);
clsCheckSql.CheckFieldForeignKey(strId_VideoLib, 8, convVideoLibRelaInfo.Id_VideoLib);
objvVideoLibRelaInfoEN.Id_VideoLib = strId_VideoLib; //视频库流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.Id_VideoLib) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.Id_VideoLib, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.Id_VideoLib] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetVideoLibName(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strVideoLibName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strVideoLibName, 100, convVideoLibRelaInfo.VideoLibName);
objvVideoLibRelaInfoEN.VideoLibName = strVideoLibName; //视频名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.VideoLibName) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.VideoLibName, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.VideoLibName] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN Setid_XzCollege(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strid_XzCollege, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_XzCollege, 4, convVideoLibRelaInfo.id_XzCollege);
clsCheckSql.CheckFieldForeignKey(strid_XzCollege, 4, convVideoLibRelaInfo.id_XzCollege);
objvVideoLibRelaInfoEN.id_XzCollege = strid_XzCollege; //学院流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.id_XzCollege) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.id_XzCollege, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.id_XzCollege] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetCollegeID(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strCollegeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeID, 4, convVideoLibRelaInfo.CollegeID);
objvVideoLibRelaInfoEN.CollegeID = strCollegeID; //学院ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.CollegeID) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.CollegeID, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.CollegeID] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetCollegeName(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strCollegeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeName, 100, convVideoLibRelaInfo.CollegeName);
objvVideoLibRelaInfoEN.CollegeName = strCollegeName; //学院名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.CollegeName) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.CollegeName, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.CollegeName] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetCollegeNameA(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strCollegeNameA, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCollegeNameA, 12, convVideoLibRelaInfo.CollegeNameA);
objvVideoLibRelaInfoEN.CollegeNameA = strCollegeNameA; //学院名称简写
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.CollegeNameA) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.CollegeNameA, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.CollegeNameA] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetCourseId(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strCourseId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseId, 8, convVideoLibRelaInfo.CourseId);
clsCheckSql.CheckFieldForeignKey(strCourseId, 8, convVideoLibRelaInfo.CourseId);
objvVideoLibRelaInfoEN.CourseId = strCourseId; //课程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.CourseId) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.CourseId, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.CourseId] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetCourseCode(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strCourseCode, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseCode, 20, convVideoLibRelaInfo.CourseCode);
objvVideoLibRelaInfoEN.CourseCode = strCourseCode; //课程代码
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.CourseCode) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.CourseCode, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.CourseCode] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetCourseName(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strCourseName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strCourseName, 100, convVideoLibRelaInfo.CourseName);
objvVideoLibRelaInfoEN.CourseName = strCourseName; //课程名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.CourseName) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.CourseName, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.CourseName] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN Setid_Resource(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strid_Resource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strid_Resource, convVideoLibRelaInfo.id_Resource);
clsCheckSql.CheckFieldLen(strid_Resource, 8, convVideoLibRelaInfo.id_Resource);
clsCheckSql.CheckFieldForeignKey(strid_Resource, 8, convVideoLibRelaInfo.id_Resource);
objvVideoLibRelaInfoEN.id_Resource = strid_Resource; //资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.id_Resource) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.id_Resource, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.id_Resource] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetResourceID(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceID, 8, convVideoLibRelaInfo.ResourceID);
clsCheckSql.CheckFieldForeignKey(strResourceID, 8, convVideoLibRelaInfo.ResourceID);
objvVideoLibRelaInfoEN.ResourceID = strResourceID; //资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.ResourceID) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.ResourceID, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.ResourceID] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetSaveMode(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, bool bolSaveMode, string strComparisonOp="")
	{
objvVideoLibRelaInfoEN.SaveMode = bolSaveMode; //文件存放方式
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.SaveMode) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.SaveMode, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.SaveMode] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN Setid_FtpResource(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strid_FtpResource, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_FtpResource, 8, convVideoLibRelaInfo.id_FtpResource);
clsCheckSql.CheckFieldForeignKey(strid_FtpResource, 8, convVideoLibRelaInfo.id_FtpResource);
objvVideoLibRelaInfoEN.id_FtpResource = strid_FtpResource; //FTP资源流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.id_FtpResource) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.id_FtpResource, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.id_FtpResource] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetFtpResourceID(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strFtpResourceID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFtpResourceID, 8, convVideoLibRelaInfo.FtpResourceID);
clsCheckSql.CheckFieldForeignKey(strFtpResourceID, 8, convVideoLibRelaInfo.FtpResourceID);
objvVideoLibRelaInfoEN.FtpResourceID = strFtpResourceID; //FTP资源ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.FtpResourceID) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.FtpResourceID, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.FtpResourceID] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetFileOriginalName(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strFileOriginalName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginalName, 200, convVideoLibRelaInfo.FileOriginalName);
objvVideoLibRelaInfoEN.FileOriginalName = strFileOriginalName; //文件原名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.FileOriginalName) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.FileOriginalName, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.FileOriginalName] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetFileDirName(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strFileDirName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileDirName, 200, convVideoLibRelaInfo.FileDirName);
objvVideoLibRelaInfoEN.FileDirName = strFileDirName; //文件目录名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.FileDirName) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.FileDirName, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.FileDirName] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetFileRename(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strFileRename, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileRename, 200, convVideoLibRelaInfo.FileRename);
objvVideoLibRelaInfoEN.FileRename = strFileRename; //文件新名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.FileRename) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.FileRename, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.FileRename] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetFileUpDate(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strFileUpDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpDate, 8, convVideoLibRelaInfo.FileUpDate);
clsCheckSql.CheckFieldForeignKey(strFileUpDate, 8, convVideoLibRelaInfo.FileUpDate);
objvVideoLibRelaInfoEN.FileUpDate = strFileUpDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.FileUpDate) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.FileUpDate, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.FileUpDate] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetFileUpTime(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strFileUpTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileUpTime, 6, convVideoLibRelaInfo.FileUpTime);
clsCheckSql.CheckFieldForeignKey(strFileUpTime, 6, convVideoLibRelaInfo.FileUpTime);
objvVideoLibRelaInfoEN.FileUpTime = strFileUpTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.FileUpTime) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.FileUpTime, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.FileUpTime] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetFileSize(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileSize, 50, convVideoLibRelaInfo.FileSize);
objvVideoLibRelaInfoEN.FileSize = strFileSize; //文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.FileSize) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.FileSize, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.FileSize] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetFileType(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileType, 30, convVideoLibRelaInfo.FileType);
objvVideoLibRelaInfoEN.FileType = strFileType; //文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.FileType) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.FileType, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.FileType] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetResourceOwner(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceOwner, 50, convVideoLibRelaInfo.ResourceOwner);
objvVideoLibRelaInfoEN.ResourceOwner = strResourceOwner; //上传者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.ResourceOwner) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.ResourceOwner, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.ResourceOwner] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetIsExistFile(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, bool bolIsExistFile, string strComparisonOp="")
	{
objvVideoLibRelaInfoEN.IsExistFile = bolIsExistFile; //是否存在文件
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.IsExistFile) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.IsExistFile, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.IsExistFile] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN Setid_File(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strid_File, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_File, 8, convVideoLibRelaInfo.id_File);
clsCheckSql.CheckFieldForeignKey(strid_File, 8, convVideoLibRelaInfo.id_File);
objvVideoLibRelaInfoEN.id_File = strid_File; //文件流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.id_File) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.id_File, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.id_File] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetFileName(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strFileName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileName, 500, convVideoLibRelaInfo.FileName);
objvVideoLibRelaInfoEN.FileName = strFileName; //文件名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.FileName) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.FileName, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.FileName] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetSaveDate(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strSaveDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveDate, 8, convVideoLibRelaInfo.SaveDate);
clsCheckSql.CheckFieldForeignKey(strSaveDate, 8, convVideoLibRelaInfo.SaveDate);
objvVideoLibRelaInfoEN.SaveDate = strSaveDate; //创建日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.SaveDate) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.SaveDate, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.SaveDate] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetSaveTime(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strSaveTime, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strSaveTime, 6, convVideoLibRelaInfo.SaveTime);
clsCheckSql.CheckFieldForeignKey(strSaveTime, 6, convVideoLibRelaInfo.SaveTime);
objvVideoLibRelaInfoEN.SaveTime = strSaveTime; //创建时间
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.SaveTime) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.SaveTime, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.SaveTime] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetFileOriginName(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strFileOriginName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOriginName, 500, convVideoLibRelaInfo.FileOriginName);
objvVideoLibRelaInfoEN.FileOriginName = strFileOriginName; //原文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.FileOriginName) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.FileOriginName, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.FileOriginName] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN Setid_ResourceType(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strid_ResourceType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_ResourceType, 4, convVideoLibRelaInfo.id_ResourceType);
clsCheckSql.CheckFieldForeignKey(strid_ResourceType, 4, convVideoLibRelaInfo.id_ResourceType);
objvVideoLibRelaInfoEN.id_ResourceType = strid_ResourceType; //资源类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.id_ResourceType) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.id_ResourceType, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.id_ResourceType] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetResourceTypeID(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strResourceTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceTypeID, 4, convVideoLibRelaInfo.ResourceTypeID);
clsCheckSql.CheckFieldForeignKey(strResourceTypeID, 4, convVideoLibRelaInfo.ResourceTypeID);
objvVideoLibRelaInfoEN.ResourceTypeID = strResourceTypeID; //资源类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.ResourceTypeID) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.ResourceTypeID, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.ResourceTypeID] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetResourceTypeName(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strResourceTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strResourceTypeName, 50, convVideoLibRelaInfo.ResourceTypeName);
objvVideoLibRelaInfoEN.ResourceTypeName = strResourceTypeName; //资源类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.ResourceTypeName) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.ResourceTypeName, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.ResourceTypeName] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetFileNewName(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strFileNewName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileNewName, 530, convVideoLibRelaInfo.FileNewName);
objvVideoLibRelaInfoEN.FileNewName = strFileNewName; //新文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.FileNewName) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.FileNewName, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.FileNewName] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetFileOldName(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strFileOldName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFileOldName, 530, convVideoLibRelaInfo.FileOldName);
objvVideoLibRelaInfoEN.FileOldName = strFileOldName; //旧文件名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.FileOldName) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.FileOldName, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.FileOldName] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetftpFileType(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strftpFileType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileType, 30, convVideoLibRelaInfo.ftpFileType);
objvVideoLibRelaInfoEN.ftpFileType = strftpFileType; //ftp文件类型
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.ftpFileType) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.ftpFileType, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.ftpFileType] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetftpFileSize(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strftpFileSize, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpFileSize, 50, convVideoLibRelaInfo.ftpFileSize);
objvVideoLibRelaInfoEN.ftpFileSize = strftpFileSize; //ftp文件大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.ftpFileSize) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.ftpFileSize, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.ftpFileSize] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetftpResourceOwner(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strftpResourceOwner, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strftpResourceOwner, 50, convVideoLibRelaInfo.ftpResourceOwner);
objvVideoLibRelaInfoEN.ftpResourceOwner = strftpResourceOwner; //Ftp资源拥有者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.ftpResourceOwner) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.ftpResourceOwner, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.ftpResourceOwner] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN Setid_MicroTeachCaseRelaInfoType(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strid_MicroTeachCaseRelaInfoType, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strid_MicroTeachCaseRelaInfoType, 4, convVideoLibRelaInfo.id_MicroTeachCaseRelaInfoType);
clsCheckSql.CheckFieldForeignKey(strid_MicroTeachCaseRelaInfoType, 4, convVideoLibRelaInfo.id_MicroTeachCaseRelaInfoType);
objvVideoLibRelaInfoEN.id_MicroTeachCaseRelaInfoType = strid_MicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.id_MicroTeachCaseRelaInfoType) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.id_MicroTeachCaseRelaInfoType, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.id_MicroTeachCaseRelaInfoType] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetMicroTeachCaseRelaInfoTypeID(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strMicroTeachCaseRelaInfoTypeID, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroTeachCaseRelaInfoTypeID, 4, convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID);
clsCheckSql.CheckFieldForeignKey(strMicroTeachCaseRelaInfoTypeID, 4, convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID);
objvVideoLibRelaInfoEN.MicroTeachCaseRelaInfoTypeID = strMicroTeachCaseRelaInfoTypeID; //微格案例相关信息类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetMicroTeachCaseRelaInfoTypeName(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strMicroTeachCaseRelaInfoTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMicroTeachCaseRelaInfoTypeName, 50, convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName);
objvVideoLibRelaInfoEN.MicroTeachCaseRelaInfoTypeName = strMicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetIsVisible(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, bool bolIsVisible, string strComparisonOp="")
	{
objvVideoLibRelaInfoEN.IsVisible = bolIsVisible; //是否显示
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.IsVisible) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.IsVisible, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.IsVisible] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetBrowseCount(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, int intBrowseCount, string strComparisonOp="")
	{
objvVideoLibRelaInfoEN.BrowseCount = intBrowseCount; //浏览次数
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.BrowseCount) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.BrowseCount, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.BrowseCount] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetFlag(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strFlag, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strFlag, 50, convVideoLibRelaInfo.Flag);
objvVideoLibRelaInfoEN.Flag = strFlag; //标志
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.Flag) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.Flag, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.Flag] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetUpdDate(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strUpdDate, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convVideoLibRelaInfo.UpdDate);
objvVideoLibRelaInfoEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.UpdDate) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.UpdDate, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.UpdDate] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetUpdUser(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strUpdUser, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convVideoLibRelaInfo.UpdUser);
objvVideoLibRelaInfoEN.UpdUser = strUpdUser; //修改人
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.UpdUser) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.UpdUser, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.UpdUser] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联，多个设置值联在一起写.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvVideoLibRelaInfoEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值，可用于组织条件串</param>
 /// <returns>返回对象，可以继续连写</returns>
public static clsvVideoLibRelaInfoEN SetMemo(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN, string strMemo, string strComparisonOp="")
	{
clsCheckSql.CheckFieldLen(strMemo, 1000, convVideoLibRelaInfo.Memo);
objvVideoLibRelaInfoEN.Memo = strMemo; //备注
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvVideoLibRelaInfoEN.dicFldComparisonOp.ContainsKey(convVideoLibRelaInfo.Memo) == false)
{
objvVideoLibRelaInfoEN.dicFldComparisonOp.Add(convVideoLibRelaInfo.Memo, strComparisonOp);
}
else
{
objvVideoLibRelaInfoEN.dicFldComparisonOp[convVideoLibRelaInfo.Memo] = strComparisonOp;
}
}
return objvVideoLibRelaInfoEN;
	}

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvVideoLibRelaInfoEN objvVideoLibRelaInfo_Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.id_MicroTeachCaseRelaInfo) == true)
{
string strComparisonOp_id_MicroTeachCaseRelaInfo = objvVideoLibRelaInfo_Cond.dicFldComparisonOp[convVideoLibRelaInfo.id_MicroTeachCaseRelaInfo];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLibRelaInfo.id_MicroTeachCaseRelaInfo, objvVideoLibRelaInfo_Cond.id_MicroTeachCaseRelaInfo, strComparisonOp_id_MicroTeachCaseRelaInfo);
}
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.FuncModuleId) == true)
{
string strComparisonOp_FuncModuleId = objvVideoLibRelaInfo_Cond.dicFldComparisonOp[convVideoLibRelaInfo.FuncModuleId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.FuncModuleId, objvVideoLibRelaInfo_Cond.FuncModuleId, strComparisonOp_FuncModuleId);
}
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.FuncModuleName) == true)
{
string strComparisonOp_FuncModuleName = objvVideoLibRelaInfo_Cond.dicFldComparisonOp[convVideoLibRelaInfo.FuncModuleName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.FuncModuleName, objvVideoLibRelaInfo_Cond.FuncModuleName, strComparisonOp_FuncModuleName);
}
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.id_MicroteachCase) == true)
{
string strComparisonOp_id_MicroteachCase = objvVideoLibRelaInfo_Cond.dicFldComparisonOp[convVideoLibRelaInfo.id_MicroteachCase];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.id_MicroteachCase, objvVideoLibRelaInfo_Cond.id_MicroteachCase, strComparisonOp_id_MicroteachCase);
}
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.Id_VideoLib) == true)
{
string strComparisonOp_Id_VideoLib = objvVideoLibRelaInfo_Cond.dicFldComparisonOp[convVideoLibRelaInfo.Id_VideoLib];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.Id_VideoLib, objvVideoLibRelaInfo_Cond.Id_VideoLib, strComparisonOp_Id_VideoLib);
}
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.VideoLibName) == true)
{
string strComparisonOp_VideoLibName = objvVideoLibRelaInfo_Cond.dicFldComparisonOp[convVideoLibRelaInfo.VideoLibName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.VideoLibName, objvVideoLibRelaInfo_Cond.VideoLibName, strComparisonOp_VideoLibName);
}
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.id_XzCollege) == true)
{
string strComparisonOp_id_XzCollege = objvVideoLibRelaInfo_Cond.dicFldComparisonOp[convVideoLibRelaInfo.id_XzCollege];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.id_XzCollege, objvVideoLibRelaInfo_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
}
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.CollegeID) == true)
{
string strComparisonOp_CollegeID = objvVideoLibRelaInfo_Cond.dicFldComparisonOp[convVideoLibRelaInfo.CollegeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.CollegeID, objvVideoLibRelaInfo_Cond.CollegeID, strComparisonOp_CollegeID);
}
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.CollegeName) == true)
{
string strComparisonOp_CollegeName = objvVideoLibRelaInfo_Cond.dicFldComparisonOp[convVideoLibRelaInfo.CollegeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.CollegeName, objvVideoLibRelaInfo_Cond.CollegeName, strComparisonOp_CollegeName);
}
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.CollegeNameA) == true)
{
string strComparisonOp_CollegeNameA = objvVideoLibRelaInfo_Cond.dicFldComparisonOp[convVideoLibRelaInfo.CollegeNameA];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.CollegeNameA, objvVideoLibRelaInfo_Cond.CollegeNameA, strComparisonOp_CollegeNameA);
}
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.CourseId) == true)
{
string strComparisonOp_CourseId = objvVideoLibRelaInfo_Cond.dicFldComparisonOp[convVideoLibRelaInfo.CourseId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.CourseId, objvVideoLibRelaInfo_Cond.CourseId, strComparisonOp_CourseId);
}
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.CourseCode) == true)
{
string strComparisonOp_CourseCode = objvVideoLibRelaInfo_Cond.dicFldComparisonOp[convVideoLibRelaInfo.CourseCode];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.CourseCode, objvVideoLibRelaInfo_Cond.CourseCode, strComparisonOp_CourseCode);
}
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.CourseName) == true)
{
string strComparisonOp_CourseName = objvVideoLibRelaInfo_Cond.dicFldComparisonOp[convVideoLibRelaInfo.CourseName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.CourseName, objvVideoLibRelaInfo_Cond.CourseName, strComparisonOp_CourseName);
}
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.id_Resource) == true)
{
string strComparisonOp_id_Resource = objvVideoLibRelaInfo_Cond.dicFldComparisonOp[convVideoLibRelaInfo.id_Resource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.id_Resource, objvVideoLibRelaInfo_Cond.id_Resource, strComparisonOp_id_Resource);
}
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.ResourceID) == true)
{
string strComparisonOp_ResourceID = objvVideoLibRelaInfo_Cond.dicFldComparisonOp[convVideoLibRelaInfo.ResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.ResourceID, objvVideoLibRelaInfo_Cond.ResourceID, strComparisonOp_ResourceID);
}
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.SaveMode) == true)
{
if (objvVideoLibRelaInfo_Cond.SaveMode == true)
{
strWhereCond += string.Format(" And {0} = '1'", convVideoLibRelaInfo.SaveMode);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convVideoLibRelaInfo.SaveMode);
}
}
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.id_FtpResource) == true)
{
string strComparisonOp_id_FtpResource = objvVideoLibRelaInfo_Cond.dicFldComparisonOp[convVideoLibRelaInfo.id_FtpResource];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.id_FtpResource, objvVideoLibRelaInfo_Cond.id_FtpResource, strComparisonOp_id_FtpResource);
}
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.FtpResourceID) == true)
{
string strComparisonOp_FtpResourceID = objvVideoLibRelaInfo_Cond.dicFldComparisonOp[convVideoLibRelaInfo.FtpResourceID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.FtpResourceID, objvVideoLibRelaInfo_Cond.FtpResourceID, strComparisonOp_FtpResourceID);
}
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.FileOriginalName) == true)
{
string strComparisonOp_FileOriginalName = objvVideoLibRelaInfo_Cond.dicFldComparisonOp[convVideoLibRelaInfo.FileOriginalName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.FileOriginalName, objvVideoLibRelaInfo_Cond.FileOriginalName, strComparisonOp_FileOriginalName);
}
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.FileDirName) == true)
{
string strComparisonOp_FileDirName = objvVideoLibRelaInfo_Cond.dicFldComparisonOp[convVideoLibRelaInfo.FileDirName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.FileDirName, objvVideoLibRelaInfo_Cond.FileDirName, strComparisonOp_FileDirName);
}
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.FileRename) == true)
{
string strComparisonOp_FileRename = objvVideoLibRelaInfo_Cond.dicFldComparisonOp[convVideoLibRelaInfo.FileRename];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.FileRename, objvVideoLibRelaInfo_Cond.FileRename, strComparisonOp_FileRename);
}
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.FileUpDate) == true)
{
string strComparisonOp_FileUpDate = objvVideoLibRelaInfo_Cond.dicFldComparisonOp[convVideoLibRelaInfo.FileUpDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.FileUpDate, objvVideoLibRelaInfo_Cond.FileUpDate, strComparisonOp_FileUpDate);
}
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.FileUpTime) == true)
{
string strComparisonOp_FileUpTime = objvVideoLibRelaInfo_Cond.dicFldComparisonOp[convVideoLibRelaInfo.FileUpTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.FileUpTime, objvVideoLibRelaInfo_Cond.FileUpTime, strComparisonOp_FileUpTime);
}
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.FileSize) == true)
{
string strComparisonOp_FileSize = objvVideoLibRelaInfo_Cond.dicFldComparisonOp[convVideoLibRelaInfo.FileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.FileSize, objvVideoLibRelaInfo_Cond.FileSize, strComparisonOp_FileSize);
}
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.FileType) == true)
{
string strComparisonOp_FileType = objvVideoLibRelaInfo_Cond.dicFldComparisonOp[convVideoLibRelaInfo.FileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.FileType, objvVideoLibRelaInfo_Cond.FileType, strComparisonOp_FileType);
}
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.ResourceOwner) == true)
{
string strComparisonOp_ResourceOwner = objvVideoLibRelaInfo_Cond.dicFldComparisonOp[convVideoLibRelaInfo.ResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.ResourceOwner, objvVideoLibRelaInfo_Cond.ResourceOwner, strComparisonOp_ResourceOwner);
}
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.IsExistFile) == true)
{
if (objvVideoLibRelaInfo_Cond.IsExistFile == true)
{
strWhereCond += string.Format(" And {0} = '1'", convVideoLibRelaInfo.IsExistFile);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convVideoLibRelaInfo.IsExistFile);
}
}
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.id_File) == true)
{
string strComparisonOp_id_File = objvVideoLibRelaInfo_Cond.dicFldComparisonOp[convVideoLibRelaInfo.id_File];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.id_File, objvVideoLibRelaInfo_Cond.id_File, strComparisonOp_id_File);
}
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.FileName) == true)
{
string strComparisonOp_FileName = objvVideoLibRelaInfo_Cond.dicFldComparisonOp[convVideoLibRelaInfo.FileName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.FileName, objvVideoLibRelaInfo_Cond.FileName, strComparisonOp_FileName);
}
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.SaveDate) == true)
{
string strComparisonOp_SaveDate = objvVideoLibRelaInfo_Cond.dicFldComparisonOp[convVideoLibRelaInfo.SaveDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.SaveDate, objvVideoLibRelaInfo_Cond.SaveDate, strComparisonOp_SaveDate);
}
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.SaveTime) == true)
{
string strComparisonOp_SaveTime = objvVideoLibRelaInfo_Cond.dicFldComparisonOp[convVideoLibRelaInfo.SaveTime];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.SaveTime, objvVideoLibRelaInfo_Cond.SaveTime, strComparisonOp_SaveTime);
}
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.FileOriginName) == true)
{
string strComparisonOp_FileOriginName = objvVideoLibRelaInfo_Cond.dicFldComparisonOp[convVideoLibRelaInfo.FileOriginName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.FileOriginName, objvVideoLibRelaInfo_Cond.FileOriginName, strComparisonOp_FileOriginName);
}
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.id_ResourceType) == true)
{
string strComparisonOp_id_ResourceType = objvVideoLibRelaInfo_Cond.dicFldComparisonOp[convVideoLibRelaInfo.id_ResourceType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.id_ResourceType, objvVideoLibRelaInfo_Cond.id_ResourceType, strComparisonOp_id_ResourceType);
}
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.ResourceTypeID) == true)
{
string strComparisonOp_ResourceTypeID = objvVideoLibRelaInfo_Cond.dicFldComparisonOp[convVideoLibRelaInfo.ResourceTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.ResourceTypeID, objvVideoLibRelaInfo_Cond.ResourceTypeID, strComparisonOp_ResourceTypeID);
}
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.ResourceTypeName) == true)
{
string strComparisonOp_ResourceTypeName = objvVideoLibRelaInfo_Cond.dicFldComparisonOp[convVideoLibRelaInfo.ResourceTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.ResourceTypeName, objvVideoLibRelaInfo_Cond.ResourceTypeName, strComparisonOp_ResourceTypeName);
}
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.FileNewName) == true)
{
string strComparisonOp_FileNewName = objvVideoLibRelaInfo_Cond.dicFldComparisonOp[convVideoLibRelaInfo.FileNewName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.FileNewName, objvVideoLibRelaInfo_Cond.FileNewName, strComparisonOp_FileNewName);
}
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.FileOldName) == true)
{
string strComparisonOp_FileOldName = objvVideoLibRelaInfo_Cond.dicFldComparisonOp[convVideoLibRelaInfo.FileOldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.FileOldName, objvVideoLibRelaInfo_Cond.FileOldName, strComparisonOp_FileOldName);
}
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.ftpFileType) == true)
{
string strComparisonOp_ftpFileType = objvVideoLibRelaInfo_Cond.dicFldComparisonOp[convVideoLibRelaInfo.ftpFileType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.ftpFileType, objvVideoLibRelaInfo_Cond.ftpFileType, strComparisonOp_ftpFileType);
}
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.ftpFileSize) == true)
{
string strComparisonOp_ftpFileSize = objvVideoLibRelaInfo_Cond.dicFldComparisonOp[convVideoLibRelaInfo.ftpFileSize];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.ftpFileSize, objvVideoLibRelaInfo_Cond.ftpFileSize, strComparisonOp_ftpFileSize);
}
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.ftpResourceOwner) == true)
{
string strComparisonOp_ftpResourceOwner = objvVideoLibRelaInfo_Cond.dicFldComparisonOp[convVideoLibRelaInfo.ftpResourceOwner];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.ftpResourceOwner, objvVideoLibRelaInfo_Cond.ftpResourceOwner, strComparisonOp_ftpResourceOwner);
}
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.id_MicroTeachCaseRelaInfoType) == true)
{
string strComparisonOp_id_MicroTeachCaseRelaInfoType = objvVideoLibRelaInfo_Cond.dicFldComparisonOp[convVideoLibRelaInfo.id_MicroTeachCaseRelaInfoType];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.id_MicroTeachCaseRelaInfoType, objvVideoLibRelaInfo_Cond.id_MicroTeachCaseRelaInfoType, strComparisonOp_id_MicroTeachCaseRelaInfoType);
}
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID) == true)
{
string strComparisonOp_MicroTeachCaseRelaInfoTypeID = objvVideoLibRelaInfo_Cond.dicFldComparisonOp[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID, objvVideoLibRelaInfo_Cond.MicroTeachCaseRelaInfoTypeID, strComparisonOp_MicroTeachCaseRelaInfoTypeID);
}
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName) == true)
{
string strComparisonOp_MicroTeachCaseRelaInfoTypeName = objvVideoLibRelaInfo_Cond.dicFldComparisonOp[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName, objvVideoLibRelaInfo_Cond.MicroTeachCaseRelaInfoTypeName, strComparisonOp_MicroTeachCaseRelaInfoTypeName);
}
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.IsVisible) == true)
{
if (objvVideoLibRelaInfo_Cond.IsVisible == true)
{
strWhereCond += string.Format(" And {0} = '1'", convVideoLibRelaInfo.IsVisible);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convVideoLibRelaInfo.IsVisible);
}
}
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.BrowseCount) == true)
{
string strComparisonOp_BrowseCount = objvVideoLibRelaInfo_Cond.dicFldComparisonOp[convVideoLibRelaInfo.BrowseCount];
strWhereCond += string.Format(" And {0} {2} {1}", convVideoLibRelaInfo.BrowseCount, objvVideoLibRelaInfo_Cond.BrowseCount, strComparisonOp_BrowseCount);
}
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.Flag) == true)
{
string strComparisonOp_Flag = objvVideoLibRelaInfo_Cond.dicFldComparisonOp[convVideoLibRelaInfo.Flag];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.Flag, objvVideoLibRelaInfo_Cond.Flag, strComparisonOp_Flag);
}
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.UpdDate) == true)
{
string strComparisonOp_UpdDate = objvVideoLibRelaInfo_Cond.dicFldComparisonOp[convVideoLibRelaInfo.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.UpdDate, objvVideoLibRelaInfo_Cond.UpdDate, strComparisonOp_UpdDate);
}
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.UpdUser) == true)
{
string strComparisonOp_UpdUser = objvVideoLibRelaInfo_Cond.dicFldComparisonOp[convVideoLibRelaInfo.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.UpdUser, objvVideoLibRelaInfo_Cond.UpdUser, strComparisonOp_UpdUser);
}
if (objvVideoLibRelaInfo_Cond.IsUpdated(convVideoLibRelaInfo.Memo) == true)
{
string strComparisonOp_Memo = objvVideoLibRelaInfo_Cond.dicFldComparisonOp[convVideoLibRelaInfo.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convVideoLibRelaInfo.Memo, objvVideoLibRelaInfo_Cond.Memo, strComparisonOp_Memo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// v视频库相关信息(vVideoLibRelaInfo)
 /// (AutoGCLib.WA_Access4CSharp:GeneCode)
 /// </summary>
public class clsvVideoLibRelaInfoWApi
{
private static readonly string mstrApiControllerName = "vVideoLibRelaInfoApi";

 public clsvVideoLibRelaInfoWApi()
 {
 }

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngid_MicroTeachCaseRelaInfo">表关键字</param>
 /// <returns>表对象</returns>
public static clsvVideoLibRelaInfoEN GetObjByid_MicroTeachCaseRelaInfo(long lngid_MicroTeachCaseRelaInfo)
{
string strAction = "GetObjByid_MicroTeachCaseRelaInfo";
string strErrMsg = string.Empty;
string strResult = "";
clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN = null;
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
objvVideoLibRelaInfoEN = JsonConvert.DeserializeObject<clsvVideoLibRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objvVideoLibRelaInfoEN;
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
public static clsvVideoLibRelaInfoEN GetObjByid_MicroTeachCaseRelaInfo_WA_Cache(long lngid_MicroTeachCaseRelaInfo)
{
string strAction = "GetObjByid_MicroTeachCaseRelaInfo_Cache";
string strErrMsg = string.Empty;
string strResult = "";
clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN = null;
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
objvVideoLibRelaInfoEN = JsonConvert.DeserializeObject<clsvVideoLibRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objvVideoLibRelaInfoEN;
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
public static clsvVideoLibRelaInfoEN GetFirstObj(string strWhereCond)
{
string strAction = "GetFirstObj";
string strErrMsg = string.Empty;
string strResult = "";
clsvVideoLibRelaInfoEN objvVideoLibRelaInfoEN = null;
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
objvVideoLibRelaInfoEN = JsonConvert.DeserializeObject<clsvVideoLibRelaInfoEN>((string)jobjReturn["ReturnObj"]);
return objvVideoLibRelaInfoEN;
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
public static clsvVideoLibRelaInfoEN GetObjByid_MicroTeachCaseRelaInfo_Cache(long lngid_MicroTeachCaseRelaInfo)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvVideoLibRelaInfoEN._CurrTabName_S);
List<clsvVideoLibRelaInfoEN> arrvVideoLibRelaInfoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvVideoLibRelaInfoEN> arrvVideoLibRelaInfoObjLst_Sel =
from objvVideoLibRelaInfoEN in arrvVideoLibRelaInfoObjLst_Cache
where objvVideoLibRelaInfoEN.id_MicroTeachCaseRelaInfo == lngid_MicroTeachCaseRelaInfo
select objvVideoLibRelaInfoEN;
if (arrvVideoLibRelaInfoObjLst_Sel.Count() == 0)
{
   clsvVideoLibRelaInfoEN obj = clsvVideoLibRelaInfoWApi.GetObjByid_MicroTeachCaseRelaInfo(lngid_MicroTeachCaseRelaInfo);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
     return obj;
 }
return null;
}
return arrvVideoLibRelaInfoObjLst_Sel.First();
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoLibRelaInfoEN> GetObjLst(string strWhereCond)
{
 List<clsvVideoLibRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLibRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoLibRelaInfoEN> GetObjLstById_MicroTeachCaseRelaInfoLst(List<long> arrId_MicroTeachCaseRelaInfo)
{
 List<clsvVideoLibRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLibRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static IEnumerable<clsvVideoLibRelaInfoEN> GetObjLstById_MicroTeachCaseRelaInfoLst_Cache(List<long> arrId_MicroTeachCaseRelaInfo)
{
//初始化列表缓存
string strKey = string.Format("{0}", clsvVideoLibRelaInfoEN._CurrTabName_S);
List<clsvVideoLibRelaInfoEN> arrvVideoLibRelaInfoObjLst_Cache = GetObjLst_Cache();
IEnumerable <clsvVideoLibRelaInfoEN> arrvVideoLibRelaInfoObjLst_Sel =
from objvVideoLibRelaInfoEN in arrvVideoLibRelaInfoObjLst_Cache
where arrId_MicroTeachCaseRelaInfo.Contains(objvVideoLibRelaInfoEN.id_MicroTeachCaseRelaInfo)
select objvVideoLibRelaInfoEN;
return arrvVideoLibRelaInfoObjLst_Sel;
}

 /// <summary>
 /// 根据关键字列表获取对象列表
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetObjLstByKeyLst_WA_Cache)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvVideoLibRelaInfoEN> GetObjLstById_MicroTeachCaseRelaInfoLst_WA_Cache(List<long> arrId_MicroTeachCaseRelaInfo)
{
 List<clsvVideoLibRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLibRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoLibRelaInfoEN> GetTopObjLst(stuTopPara objTopPara)
{
 List<clsvVideoLibRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLibRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoLibRelaInfoEN> GetObjLstByRange(stuRangePara objRangePara)
{
 List<clsvVideoLibRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLibRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoLibRelaInfoEN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 List<clsvVideoLibRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLibRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
public static List<clsvVideoLibRelaInfoEN> GetObjLstByPager_Cache(stuPagerPara objPagerPara)
{
 List<clsvVideoLibRelaInfoEN> arrObjLst = null; 
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
arrObjLst = JsonConvert.DeserializeObject<List<clsvVideoLibRelaInfoEN>>((string)jobjReturn["ReturnObjLst"]);
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
 /// <param name = "objvVideoLibRelaInfoENS">源对象</param>
 /// <param name = "objvVideoLibRelaInfoENT">目标对象</param>
 public static void CopyTo(clsvVideoLibRelaInfoEN objvVideoLibRelaInfoENS, clsvVideoLibRelaInfoEN objvVideoLibRelaInfoENT)
{
try
{
objvVideoLibRelaInfoENT.id_MicroTeachCaseRelaInfo = objvVideoLibRelaInfoENS.id_MicroTeachCaseRelaInfo; //案例相关信息流水号
objvVideoLibRelaInfoENT.FuncModuleId = objvVideoLibRelaInfoENS.FuncModuleId; //功能模块Id
objvVideoLibRelaInfoENT.FuncModuleName = objvVideoLibRelaInfoENS.FuncModuleName; //功能模块名称
objvVideoLibRelaInfoENT.id_MicroteachCase = objvVideoLibRelaInfoENS.id_MicroteachCase; //微格教学案例流水号
objvVideoLibRelaInfoENT.Id_VideoLib = objvVideoLibRelaInfoENS.Id_VideoLib; //视频库流水号
objvVideoLibRelaInfoENT.VideoLibName = objvVideoLibRelaInfoENS.VideoLibName; //视频名称
objvVideoLibRelaInfoENT.id_XzCollege = objvVideoLibRelaInfoENS.id_XzCollege; //学院流水号
objvVideoLibRelaInfoENT.CollegeID = objvVideoLibRelaInfoENS.CollegeID; //学院ID
objvVideoLibRelaInfoENT.CollegeName = objvVideoLibRelaInfoENS.CollegeName; //学院名称
objvVideoLibRelaInfoENT.CollegeNameA = objvVideoLibRelaInfoENS.CollegeNameA; //学院名称简写
objvVideoLibRelaInfoENT.CourseId = objvVideoLibRelaInfoENS.CourseId; //课程Id
objvVideoLibRelaInfoENT.CourseCode = objvVideoLibRelaInfoENS.CourseCode; //课程代码
objvVideoLibRelaInfoENT.CourseName = objvVideoLibRelaInfoENS.CourseName; //课程名称
objvVideoLibRelaInfoENT.id_Resource = objvVideoLibRelaInfoENS.id_Resource; //资源流水号
objvVideoLibRelaInfoENT.ResourceID = objvVideoLibRelaInfoENS.ResourceID; //资源ID
objvVideoLibRelaInfoENT.SaveMode = objvVideoLibRelaInfoENS.SaveMode; //文件存放方式
objvVideoLibRelaInfoENT.id_FtpResource = objvVideoLibRelaInfoENS.id_FtpResource; //FTP资源流水号
objvVideoLibRelaInfoENT.FtpResourceID = objvVideoLibRelaInfoENS.FtpResourceID; //FTP资源ID
objvVideoLibRelaInfoENT.FileOriginalName = objvVideoLibRelaInfoENS.FileOriginalName; //文件原名
objvVideoLibRelaInfoENT.FileDirName = objvVideoLibRelaInfoENS.FileDirName; //文件目录名
objvVideoLibRelaInfoENT.FileRename = objvVideoLibRelaInfoENS.FileRename; //文件新名
objvVideoLibRelaInfoENT.FileUpDate = objvVideoLibRelaInfoENS.FileUpDate; //创建日期
objvVideoLibRelaInfoENT.FileUpTime = objvVideoLibRelaInfoENS.FileUpTime; //创建时间
objvVideoLibRelaInfoENT.FileSize = objvVideoLibRelaInfoENS.FileSize; //文件大小
objvVideoLibRelaInfoENT.FileType = objvVideoLibRelaInfoENS.FileType; //文件类型
objvVideoLibRelaInfoENT.ResourceOwner = objvVideoLibRelaInfoENS.ResourceOwner; //上传者
objvVideoLibRelaInfoENT.IsExistFile = objvVideoLibRelaInfoENS.IsExistFile; //是否存在文件
objvVideoLibRelaInfoENT.id_File = objvVideoLibRelaInfoENS.id_File; //文件流水号
objvVideoLibRelaInfoENT.FileName = objvVideoLibRelaInfoENS.FileName; //文件名称
objvVideoLibRelaInfoENT.SaveDate = objvVideoLibRelaInfoENS.SaveDate; //创建日期
objvVideoLibRelaInfoENT.SaveTime = objvVideoLibRelaInfoENS.SaveTime; //创建时间
objvVideoLibRelaInfoENT.FileOriginName = objvVideoLibRelaInfoENS.FileOriginName; //原文件名
objvVideoLibRelaInfoENT.id_ResourceType = objvVideoLibRelaInfoENS.id_ResourceType; //资源类型流水号
objvVideoLibRelaInfoENT.ResourceTypeID = objvVideoLibRelaInfoENS.ResourceTypeID; //资源类型ID
objvVideoLibRelaInfoENT.ResourceTypeName = objvVideoLibRelaInfoENS.ResourceTypeName; //资源类型名称
objvVideoLibRelaInfoENT.FileNewName = objvVideoLibRelaInfoENS.FileNewName; //新文件名
objvVideoLibRelaInfoENT.FileOldName = objvVideoLibRelaInfoENS.FileOldName; //旧文件名
objvVideoLibRelaInfoENT.ftpFileType = objvVideoLibRelaInfoENS.ftpFileType; //ftp文件类型
objvVideoLibRelaInfoENT.ftpFileSize = objvVideoLibRelaInfoENS.ftpFileSize; //ftp文件大小
objvVideoLibRelaInfoENT.ftpResourceOwner = objvVideoLibRelaInfoENS.ftpResourceOwner; //Ftp资源拥有者
objvVideoLibRelaInfoENT.id_MicroTeachCaseRelaInfoType = objvVideoLibRelaInfoENS.id_MicroTeachCaseRelaInfoType; //微格案例相关信息类型流水号
objvVideoLibRelaInfoENT.MicroTeachCaseRelaInfoTypeID = objvVideoLibRelaInfoENS.MicroTeachCaseRelaInfoTypeID; //微格案例相关信息类型ID
objvVideoLibRelaInfoENT.MicroTeachCaseRelaInfoTypeName = objvVideoLibRelaInfoENS.MicroTeachCaseRelaInfoTypeName; //微格案例相关信息类型名称
objvVideoLibRelaInfoENT.IsVisible = objvVideoLibRelaInfoENS.IsVisible; //是否显示
objvVideoLibRelaInfoENT.BrowseCount = objvVideoLibRelaInfoENS.BrowseCount; //浏览次数
objvVideoLibRelaInfoENT.Flag = objvVideoLibRelaInfoENS.Flag; //标志
objvVideoLibRelaInfoENT.UpdDate = objvVideoLibRelaInfoENS.UpdDate; //修改日期
objvVideoLibRelaInfoENT.UpdUser = objvVideoLibRelaInfoENS.UpdUser; //修改人
objvVideoLibRelaInfoENT.Memo = objvVideoLibRelaInfoENS.Memo; //备注
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
public static DataTable ToDataTable(List<clsvVideoLibRelaInfoEN> arrObj)
{
DataTable dataTable = new DataTable(); //实例化
DataTable result;
if (arrObj.Count == 0) return null;
if (clsvVideoLibRelaInfoEN.AttributeName.Length == 0)
{
result = dataTable;
return result;
}
Type type = typeof(clsvVideoLibRelaInfoEN);
PropertyInfo[] arrPropertyInfo = type.GetProperties();
try
{
//Columns
foreach (string strAttrName in clsvVideoLibRelaInfoEN.AttributeName)
{
PropertyInfo proprety_Curr = arrPropertyInfo.Where(x => x.Name == strAttrName).First();
dataTable.Columns.Add(strAttrName, proprety_Curr.PropertyType);
}
foreach (clsvVideoLibRelaInfoEN objInFor in arrObj)
{
//Rows
DataRow dataRow = dataTable.NewRow();
foreach (string strAttrName in clsvVideoLibRelaInfoEN.AttributeName)
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
if (clsXzClgWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsXzClgWApi没有刷新缓存机制(clsXzClgWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsVideoLibWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsVideoLibWApi没有刷新缓存机制(clsVideoLibWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsRecommendedDegreeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsRecommendedDegreeWApi没有刷新缓存机制(clsRecommendedDegreeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsVideoLibTypeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsVideoLibTypeWApi没有刷新缓存机制(clsVideoLibTypeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
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
if (clsVideoLikeLogWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsVideoLikeLogWApi没有刷新缓存机制(clsVideoLikeLogWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsVideoPlayLogWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsVideoPlayLogWApi没有刷新缓存机制(clsVideoPlayLogWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsMicroteachAppraiseWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clsMicroteachAppraiseWApi没有刷新缓存机制(clsMicroteachAppraiseWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clscc_CourseIsLikeWApi.objCommFun4BL == null)
{
strMsg = string.Format("类clscc_CourseIsLikeWApi没有刷新缓存机制(clscc_CourseIsLikeWApi.objCommFun4BL == null), 请联系程序员！(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by id_MicroTeachCaseRelaInfo");
//if (arrvVideoLibRelaInfoObjLst_Cache == null)
//{
//arrvVideoLibRelaInfoObjLst_Cache = await clsvVideoLibRelaInfoWApi.GetObjLst(strWhereCond);
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
string strKey = string.Format("{0}", clsvVideoLibRelaInfoEN._CurrTabName_S);
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
public static List<clsvVideoLibRelaInfoEN> GetObjLst_Cache()
{
//初始化列表缓存
InitListCache(); 
string strKey = string.Format("{0}", clsvVideoLibRelaInfoEN._CurrTabName_S);
List<clsvVideoLibRelaInfoEN> arrvVideoLibRelaInfoObjLst_Cache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvVideoLibRelaInfoObjLst_Cache;
}

 /// <summary>
 /// 根据对象列表获取DataTable
 /// (AutoGCLib.WA_Access4CSharp:Gen_4WA_GetDataTableByObjLst)
 /// </summary>
 /// <param name = "arrObjLst">给定的对象列表</param>
 /// <returns>返回DataTable</returns>
public static DataTable GetDataTableByObjLst(List<clsvVideoLibRelaInfoEN> arrObjLst)
{
DataTable objDT = new DataTable();
objDT.Columns.Add(convVideoLibRelaInfo.id_MicroTeachCaseRelaInfo, Type.GetType("System.Int64"));
objDT.Columns.Add(convVideoLibRelaInfo.FuncModuleId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibRelaInfo.FuncModuleName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibRelaInfo.id_MicroteachCase, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibRelaInfo.Id_VideoLib, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibRelaInfo.VideoLibName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibRelaInfo.id_XzCollege, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibRelaInfo.CollegeID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibRelaInfo.CollegeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibRelaInfo.CollegeNameA, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibRelaInfo.CourseId, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibRelaInfo.CourseCode, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibRelaInfo.CourseName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibRelaInfo.id_Resource, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibRelaInfo.ResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibRelaInfo.SaveMode, Type.GetType("System.Boolean"));
objDT.Columns.Add(convVideoLibRelaInfo.id_FtpResource, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibRelaInfo.FtpResourceID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibRelaInfo.FileOriginalName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibRelaInfo.FileDirName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibRelaInfo.FileRename, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibRelaInfo.FileUpDate, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibRelaInfo.FileUpTime, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibRelaInfo.FileSize, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibRelaInfo.FileType, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibRelaInfo.ResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibRelaInfo.IsExistFile, Type.GetType("System.Boolean"));
objDT.Columns.Add(convVideoLibRelaInfo.id_File, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibRelaInfo.FileName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibRelaInfo.SaveDate, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibRelaInfo.SaveTime, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibRelaInfo.FileOriginName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibRelaInfo.id_ResourceType, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibRelaInfo.ResourceTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibRelaInfo.ResourceTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibRelaInfo.FileNewName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibRelaInfo.FileOldName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibRelaInfo.ftpFileType, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibRelaInfo.ftpFileSize, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibRelaInfo.ftpResourceOwner, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibRelaInfo.id_MicroTeachCaseRelaInfoType, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibRelaInfo.IsVisible, Type.GetType("System.Boolean"));
objDT.Columns.Add(convVideoLibRelaInfo.BrowseCount, Type.GetType("System.Int32"));
objDT.Columns.Add(convVideoLibRelaInfo.Flag, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibRelaInfo.UpdDate, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibRelaInfo.UpdUser, Type.GetType("System.String"));
objDT.Columns.Add(convVideoLibRelaInfo.Memo, Type.GetType("System.String"));
foreach (clsvVideoLibRelaInfoEN objInFor in arrObjLst)
{
DataRow objDR = objDT.NewRow();
objDR[convVideoLibRelaInfo.id_MicroTeachCaseRelaInfo] = objInFor[convVideoLibRelaInfo.id_MicroTeachCaseRelaInfo];
objDR[convVideoLibRelaInfo.FuncModuleId] = objInFor[convVideoLibRelaInfo.FuncModuleId];
objDR[convVideoLibRelaInfo.FuncModuleName] = objInFor[convVideoLibRelaInfo.FuncModuleName];
objDR[convVideoLibRelaInfo.id_MicroteachCase] = objInFor[convVideoLibRelaInfo.id_MicroteachCase];
objDR[convVideoLibRelaInfo.Id_VideoLib] = objInFor[convVideoLibRelaInfo.Id_VideoLib];
objDR[convVideoLibRelaInfo.VideoLibName] = objInFor[convVideoLibRelaInfo.VideoLibName];
objDR[convVideoLibRelaInfo.id_XzCollege] = objInFor[convVideoLibRelaInfo.id_XzCollege];
objDR[convVideoLibRelaInfo.CollegeID] = objInFor[convVideoLibRelaInfo.CollegeID];
objDR[convVideoLibRelaInfo.CollegeName] = objInFor[convVideoLibRelaInfo.CollegeName];
objDR[convVideoLibRelaInfo.CollegeNameA] = objInFor[convVideoLibRelaInfo.CollegeNameA];
objDR[convVideoLibRelaInfo.CourseId] = objInFor[convVideoLibRelaInfo.CourseId];
objDR[convVideoLibRelaInfo.CourseCode] = objInFor[convVideoLibRelaInfo.CourseCode];
objDR[convVideoLibRelaInfo.CourseName] = objInFor[convVideoLibRelaInfo.CourseName];
objDR[convVideoLibRelaInfo.id_Resource] = objInFor[convVideoLibRelaInfo.id_Resource];
objDR[convVideoLibRelaInfo.ResourceID] = objInFor[convVideoLibRelaInfo.ResourceID];
objDR[convVideoLibRelaInfo.SaveMode] = objInFor[convVideoLibRelaInfo.SaveMode];
objDR[convVideoLibRelaInfo.id_FtpResource] = objInFor[convVideoLibRelaInfo.id_FtpResource];
objDR[convVideoLibRelaInfo.FtpResourceID] = objInFor[convVideoLibRelaInfo.FtpResourceID];
objDR[convVideoLibRelaInfo.FileOriginalName] = objInFor[convVideoLibRelaInfo.FileOriginalName];
objDR[convVideoLibRelaInfo.FileDirName] = objInFor[convVideoLibRelaInfo.FileDirName];
objDR[convVideoLibRelaInfo.FileRename] = objInFor[convVideoLibRelaInfo.FileRename];
objDR[convVideoLibRelaInfo.FileUpDate] = objInFor[convVideoLibRelaInfo.FileUpDate];
objDR[convVideoLibRelaInfo.FileUpTime] = objInFor[convVideoLibRelaInfo.FileUpTime];
objDR[convVideoLibRelaInfo.FileSize] = objInFor[convVideoLibRelaInfo.FileSize];
objDR[convVideoLibRelaInfo.FileType] = objInFor[convVideoLibRelaInfo.FileType];
objDR[convVideoLibRelaInfo.ResourceOwner] = objInFor[convVideoLibRelaInfo.ResourceOwner];
objDR[convVideoLibRelaInfo.IsExistFile] = objInFor[convVideoLibRelaInfo.IsExistFile];
objDR[convVideoLibRelaInfo.id_File] = objInFor[convVideoLibRelaInfo.id_File];
objDR[convVideoLibRelaInfo.FileName] = objInFor[convVideoLibRelaInfo.FileName];
objDR[convVideoLibRelaInfo.SaveDate] = objInFor[convVideoLibRelaInfo.SaveDate];
objDR[convVideoLibRelaInfo.SaveTime] = objInFor[convVideoLibRelaInfo.SaveTime];
objDR[convVideoLibRelaInfo.FileOriginName] = objInFor[convVideoLibRelaInfo.FileOriginName];
objDR[convVideoLibRelaInfo.id_ResourceType] = objInFor[convVideoLibRelaInfo.id_ResourceType];
objDR[convVideoLibRelaInfo.ResourceTypeID] = objInFor[convVideoLibRelaInfo.ResourceTypeID];
objDR[convVideoLibRelaInfo.ResourceTypeName] = objInFor[convVideoLibRelaInfo.ResourceTypeName];
objDR[convVideoLibRelaInfo.FileNewName] = objInFor[convVideoLibRelaInfo.FileNewName];
objDR[convVideoLibRelaInfo.FileOldName] = objInFor[convVideoLibRelaInfo.FileOldName];
objDR[convVideoLibRelaInfo.ftpFileType] = objInFor[convVideoLibRelaInfo.ftpFileType];
objDR[convVideoLibRelaInfo.ftpFileSize] = objInFor[convVideoLibRelaInfo.ftpFileSize];
objDR[convVideoLibRelaInfo.ftpResourceOwner] = objInFor[convVideoLibRelaInfo.ftpResourceOwner];
objDR[convVideoLibRelaInfo.id_MicroTeachCaseRelaInfoType] = objInFor[convVideoLibRelaInfo.id_MicroTeachCaseRelaInfoType];
objDR[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID] = objInFor[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeID];
objDR[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName] = objInFor[convVideoLibRelaInfo.MicroTeachCaseRelaInfoTypeName];
objDR[convVideoLibRelaInfo.IsVisible] = objInFor[convVideoLibRelaInfo.IsVisible];
objDR[convVideoLibRelaInfo.BrowseCount] = objInFor[convVideoLibRelaInfo.BrowseCount];
objDR[convVideoLibRelaInfo.Flag] = objInFor[convVideoLibRelaInfo.Flag];
objDR[convVideoLibRelaInfo.UpdDate] = objInFor[convVideoLibRelaInfo.UpdDate];
objDR[convVideoLibRelaInfo.UpdUser] = objInFor[convVideoLibRelaInfo.UpdUser];
objDR[convVideoLibRelaInfo.Memo] = objInFor[convVideoLibRelaInfo.Memo];
objDT.Rows.Add(objDR);
}
return objDT;
}
}
}